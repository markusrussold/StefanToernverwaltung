Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' Propagates a trip name change into Crewbesprechung.mdb tables keyed by Toernname.
''' </summary>
Public Module TripRenameHelper

    Private ReadOnly CrewbesprechungTables() As String = {
        "CrewDetails",
        "AnRueckReise",
        "Ablauf",
        "ErsteTag",
        "Einkaufsliste"
    }

    ''' <summary>
    ''' Renames Toernname in all Crewbesprechung tables that reference a trip.
    ''' Fail-safe: logs and continues if a table/column is missing.
    ''' </summary>
    Public Sub RenameInCrewbesprechung(ByVal oldName As String, ByVal newName As String)
        If String.IsNullOrWhiteSpace(oldName) OrElse String.IsNullOrWhiteSpace(newName) Then Return
        If String.Equals(oldName.Trim(), newName.Trim(), StringComparison.Ordinal) Then Return

        Try
            DbAccess.WithRetry(
                Sub()
                    Using conn As New OleDbConnection(DbAccess.JetConnectionString("Crewbesprechung.mdb"))
                        conn.Open()
                        For Each tableName As String In CrewbesprechungTables
                            RenameInTable(conn, tableName, "Toernname", oldName.Trim(), newName.Trim())
                        Next
                    End Using
                End Sub)
        Catch ex As Exception
            AppLog.Warn("TripRenameHelper.RenameInCrewbesprechung: " & ex.Message)
            MsgBox("Crewbesprechung-Daten konnten nicht umbenannt werden: " & ex.Message)
        End Try
    End Sub

    Private Sub RenameInTable(ByVal conn As OleDbConnection, ByVal tableName As String, ByVal columnName As String, ByVal oldName As String, ByVal newName As String)
        Try
            If Not TableExists(conn, tableName) Then Return
            If Not ColumnExists(conn, tableName, columnName) Then Return

            Using cmd As New OleDbCommand(
                "UPDATE [" & tableName & "] SET [" & columnName & "] = ? WHERE [" & columnName & "] = ?",
                conn)
                cmd.Parameters.AddWithValue("@new", newName)
                cmd.Parameters.AddWithValue("@old", oldName)
                Dim affected As Integer = cmd.ExecuteNonQuery()
                If affected > 0 Then
                    AppLog.Info("TripRenameHelper: " & tableName & " " & affected.ToString() & " row(s) " & oldName & " -> " & newName)
                End If
            End Using
        Catch ex As Exception
            AppLog.Warn("TripRenameHelper.RenameInTable(" & tableName & "): " & ex.Message)
        End Try
    End Sub

    Private Function TableExists(ByVal conn As OleDbConnection, ByVal tableName As String) As Boolean
        Dim schema As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        If schema Is Nothing Then Return False
        For Each row As DataRow In schema.Rows
            If String.Equals(Convert.ToString(row("TABLE_NAME")), tableName, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function ColumnExists(ByVal conn As OleDbConnection, ByVal tableName As String, ByVal columnName As String) As Boolean
        Dim schema As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, tableName, Nothing})
        If schema Is Nothing Then Return False
        For Each row As DataRow In schema.Rows
            If String.Equals(Convert.ToString(row("COLUMN_NAME")), columnName, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
