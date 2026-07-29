Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Imports System.Windows.Forms

''' <summary>
''' Central Jet/OleDb access helpers: provider check, retry on locks,
''' parameterized commands, and safe BindingSource/DataTable access.
''' Access/Jet remains the runtime store; this layer is the migration seam for a future engine.
''' </summary>
Public Module DbAccess

    Public Const JetProviderPrefix As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

    Public Function JetConnectionString(ByVal mdbPath As String) As String
        Return JetProviderPrefix & mdbPath
    End Function

    Public Function IsJetAvailable(ByRef errorMessage As String) As Boolean
        errorMessage = Nothing

        Try
            Dim test As New OleDbConnectionStringBuilder() With {
                .Provider = "Microsoft.Jet.OLEDB.4.0",
                .DataSource = "C:\__toernverwaltung_provider_probe__.mdb"
            }
            Using conn As New OleDbConnection(test.ConnectionString)
                ' Construction validates OleDb + Jet provider registration on x86.
            End Using
            Return True
        Catch ex As Exception
            Try
                Dim cat As Object = CreateObject("ADOX.Catalog")
                If cat IsNot Nothing Then Return True
            Catch
            End Try
            Try
                Dim engine As Object = CreateObject("DAO.DBEngine.36")
                If engine IsNot Nothing Then Return True
            Catch
            End Try
            errorMessage = "Microsoft Jet OLEDB 4.0 (32-Bit) ist nicht verfügbar: " & ex.Message
            Return False
        End Try
    End Function

    Public Function EnsureJetOrThrow() As Boolean
        Dim msg As String = Nothing
        If IsJetAvailable(msg) Then Return True
        Throw New InvalidOperationException(
            "Die Anwendung benötigt den 32-Bit Microsoft Jet OLEDB 4.0-Provider (oder DAO/ADOX)." &
            Environment.NewLine & If(msg, String.Empty) &
            Environment.NewLine & "Bitte als 32-Bit (.NET x86) ausführen und Jet/Access Database Engine installieren.")
    End Function

    Public Sub SafePosition(ByVal binding As BindingSource, Optional ByVal index As Integer = 0)
        If binding Is Nothing Then Return
        Try
            If binding.Count > 0 AndAlso index >= 0 AndAlso index < binding.Count Then
                binding.Position = index
            End If
        Catch ex As Exception
            AppLog.Warn("SafePosition: " & ex.Message)
        End Try
    End Sub

    Public Function HasRows(ByVal table As DataTable) As Boolean
        Return table IsNot Nothing AndAlso table.Rows.Count > 0
    End Function

    Public Function TryGetRow(ByVal table As DataTable, ByVal index As Integer, ByRef row As DataRow) As Boolean
        row = Nothing
        If table Is Nothing OrElse index < 0 OrElse index >= table.Rows.Count Then Return False
        row = table.Rows(index)
        Return True
    End Function

    Public Function ExecuteNonQuery(
        ByVal mdbPath As String,
        ByVal sql As String,
        Optional ByVal parameters As IEnumerable(Of OleDbParameter) = Nothing,
        Optional ByVal maxAttempts As Integer = 5) As Integer

        Return WithRetry(Function()
                             Using conn As New OleDbConnection(JetConnectionString(mdbPath))
                                 conn.Open()
                                 Using cmd As New OleDbCommand(sql, conn)
                                     If parameters IsNot Nothing Then
                                         For Each p In parameters
                                             cmd.Parameters.Add(CloneParameter(p))
                                         Next
                                     End If
                                     Return cmd.ExecuteNonQuery()
                                 End Using
                             End Using
                         End Function, maxAttempts)
    End Function

    Public Function ExecuteScalar(
        ByVal mdbPath As String,
        ByVal sql As String,
        Optional ByVal parameters As IEnumerable(Of OleDbParameter) = Nothing,
        Optional ByVal maxAttempts As Integer = 5) As Object

        Return WithRetry(Function()
                             Using conn As New OleDbConnection(JetConnectionString(mdbPath))
                                 conn.Open()
                                 Using cmd As New OleDbCommand(sql, conn)
                                     If parameters IsNot Nothing Then
                                         For Each p In parameters
                                             cmd.Parameters.Add(CloneParameter(p))
                                         Next
                                     End If
                                     Return cmd.ExecuteScalar()
                                 End Using
                             End Using
                         End Function, maxAttempts)
    End Function

    Public Function FillTable(
        ByVal mdbPath As String,
        ByVal sql As String,
        ByVal target As DataTable,
        Optional ByVal parameters As IEnumerable(Of OleDbParameter) = Nothing,
        Optional ByVal maxAttempts As Integer = 5) As Integer

        Return WithRetry(Function()
                             Using conn As New OleDbConnection(JetConnectionString(mdbPath))
                                 Using cmd As New OleDbCommand(sql, conn)
                                     If parameters IsNot Nothing Then
                                         For Each p In parameters
                                             cmd.Parameters.Add(CloneParameter(p))
                                         Next
                                     End If
                                     Using adapter As New OleDbDataAdapter(cmd)
                                         target.Clear()
                                         Return adapter.Fill(target)
                                     End Using
                                 End Using
                             End Using
                         End Function, maxAttempts)
    End Function

    Public Function Param(ByVal name As String, ByVal value As Object) As OleDbParameter
        Dim v As Object = If(value Is Nothing, DBNull.Value, value)
        Return New OleDbParameter(name, v)
    End Function

    Public Function WithRetry(Of T)(ByVal action As Func(Of T), Optional ByVal maxAttempts As Integer = 5) As T
        Dim attempt As Integer = 0
        Do
            attempt += 1
            Try
                Return action()
            Catch ex As OleDbException When IsLockOrBusy(ex) AndAlso attempt < maxAttempts
                AppLog.Warn("OleDb lock/retry " & attempt.ToString() & ": " & ex.Message)
                Thread.Sleep(100 * attempt)
            Catch ex As Exception When IsLockOrBusy(ex) AndAlso attempt < maxAttempts
                AppLog.Warn("DB lock/retry " & attempt.ToString() & ": " & ex.Message)
                Thread.Sleep(100 * attempt)
            End Try
        Loop
    End Function

    Public Sub WithRetry(ByVal action As Action, Optional ByVal maxAttempts As Integer = 5)
        WithRetry(Of Integer)(Function()
                                  action()
                                  Return 0
                              End Function, maxAttempts)
    End Sub

    Private Function CloneParameter(ByVal source As OleDbParameter) As OleDbParameter
        Dim p As New OleDbParameter(source.ParameterName, source.Value)
        p.OleDbType = source.OleDbType
        p.Size = source.Size
        Return p
    End Function

    Private Function IsLockOrBusy(ByVal ex As Exception) As Boolean
        Dim msg As String = If(ex.Message, String.Empty).ToLowerInvariant()
        If msg.Contains("locked") OrElse msg.Contains("gesperrt") OrElse msg.Contains("in use") OrElse msg.Contains("verwendet") Then
            Return True
        End If
        Dim ole As OleDbException = TryCast(ex, OleDbException)
        If ole IsNot Nothing Then
            For Each err As OleDbError In ole.Errors
                ' Jet typical lock / could not update / disk or network
                If err.NativeError = -1102 OrElse err.NativeError = -1101 OrElse err.NativeError = 3218 OrElse err.NativeError = 3260 Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

End Module
