Option Explicit On
Option Strict Off

Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

''' <summary>
''' Ensures required Access databases exist next to the EXE.
''' Creates empty MDBs when missing, adopts *Neu* files when present,
''' backs up before schema changes, and adds missing tables/columns from typed DataSets.
''' </summary>
Public Module DatabaseBootstrap

    ''' <summary>DB compatibility major; always mirrors AppVersion.Major.</summary>
    Public ReadOnly Property AppMajorVersion As String
        Get
            Return AppVersion.MajorString
        End Get
    End Property

    Private Const JetProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

    Public Sub EnsureAll(Optional ByVal baseDirectory As String = Nothing)
        If String.IsNullOrEmpty(baseDirectory) Then
            baseDirectory = Environment.CurrentDirectory
        End If
        Directory.SetCurrentDirectory(baseDirectory)

        DbAccess.EnsureJetOrThrow()
        AppLog.Info("DatabaseBootstrap start in " & baseDirectory)

        EnsureDatabase(
            Path.Combine(baseDirectory, "Toernverwaltung.mdb"),
            Function() CType(New ToernverwaltungDataSet(), DataSet),
            New String() {"ToernverwaltungNeu.mdb", "ToernverwaltungNeu_be.mdb"})

        EnsureDatabase(
            Path.Combine(baseDirectory, "Ausbildung.mdb"),
            Function() CType(New dsAusbildung(), DataSet),
            New String() {})

        EnsureDatabase(
            Path.Combine(baseDirectory, "Export.mdb"),
            Function() CType(New ExportDataSet(), DataSet),
            New String() {})

        EnsureDatabase(
            Path.Combine(baseDirectory, "Logbuch.mdb"),
            Function() CType(New dsLogbuch(), DataSet),
            New String() {})

        EnsureDatabase(
            Path.Combine(baseDirectory, "Crewbesprechung.mdb"),
            Function() CType(New CrewbesprechungDataSet(), DataSet),
            New String() {})

        EnsureDatabase(
            Path.Combine(baseDirectory, "Versicherung.mdb"),
            Function() CType(New VersicherungDataSet(), DataSet),
            New String() {})

        SeedToernverwaltungVersion(Path.Combine(baseDirectory, "Toernverwaltung.mdb"))
        AppLog.Info("DatabaseBootstrap finished")
    End Sub

    Private Sub EnsureDatabase(ByVal targetPath As String, ByVal schemaFactory As Func(Of DataSet), ByVal convertFrom As String())
        Dim dir As String = Path.GetDirectoryName(targetPath)
        If Not File.Exists(targetPath) Then
            Dim adopted As Boolean = False
            For Each candidateName As String In convertFrom
                Dim candidatePath As String = Path.Combine(dir, candidateName)
                If File.Exists(candidatePath) Then
                    File.Copy(candidatePath, targetPath, False)
                    AppLog.Info("Adopted " & candidateName & " -> " & Path.GetFileName(targetPath))
                    adopted = True
                    Exit For
                End If
            Next
            If Not adopted Then
                CreateEmptyMdb(targetPath)
                AppLog.Info("Created empty " & Path.GetFileName(targetPath))
            End If
        End If

        Dim schema As DataSet = schemaFactory()
        Try
            If NeedsSchemaChange(targetPath, schema) Then
                BackupMdb(targetPath)
            End If
            DbAccess.WithRetry(Sub() EnsureSchema(targetPath, schema))
        Finally
            schema.Dispose()
        End Try
    End Sub

    Private Function NeedsSchemaChange(ByVal mdbPath As String, ByVal schema As DataSet) As Boolean
        Try
            Using conn As New OleDbConnection(JetProvider & mdbPath)
                conn.Open()
                Dim existingTables As HashSet(Of String) = GetTableNames(conn)
                For Each table As DataTable In schema.Tables
                    Dim tableName As String = table.TableName
                    If String.IsNullOrEmpty(tableName) Then Continue For
                    If Not existingTables.Contains(tableName.ToLowerInvariant()) Then Return True
                    Dim existingColumns As HashSet(Of String) = GetColumnNames(conn, tableName)
                    For Each column As DataColumn In table.Columns
                        If Not existingColumns.Contains(column.ColumnName.ToLowerInvariant()) Then Return True
                    Next
                Next
            End Using
        Catch ex As Exception
            AppLog.Warn("NeedsSchemaChange probe failed for " & Path.GetFileName(mdbPath) & ": " & ex.Message)
            Return True
        End Try
        Return False
    End Function

    Private Sub BackupMdb(ByVal mdbPath As String)
        If Not File.Exists(mdbPath) Then Return
        Try
            Dim backupDir As String = Path.Combine(Path.GetDirectoryName(mdbPath), "Backups")
            Directory.CreateDirectory(backupDir)
            Dim stamp As String = DateTime.Now.ToString("yyyyMMdd-HHmmss")
            Dim dest As String = Path.Combine(backupDir, Path.GetFileNameWithoutExtension(mdbPath) & "-" & stamp & ".mdb")
            File.Copy(mdbPath, dest, False)
            AppLog.Info("Backup created: " & dest)
            PruneOldBackups(backupDir, Path.GetFileNameWithoutExtension(mdbPath), keep:=10)
        Catch ex As Exception
            AppLog.Warn("Backup failed for " & Path.GetFileName(mdbPath) & ": " & ex.Message)
        End Try
    End Sub

    Private Sub PruneOldBackups(ByVal backupDir As String, ByVal baseName As String, ByVal keep As Integer)
        Try
            Dim files = New DirectoryInfo(backupDir).GetFiles(baseName & "-*.mdb")
            Array.Sort(files, Function(a, b) b.CreationTimeUtc.CompareTo(a.CreationTimeUtc))
            For i As Integer = keep To files.Length - 1
                Try
                    files(i).Delete()
                Catch
                End Try
            Next
        Catch
        End Try
    End Sub

    Private Sub CreateEmptyMdb(ByVal mdbPath As String)
        If File.Exists(mdbPath) Then Return

        Dim connectionString As String = JetProvider & mdbPath

        Try
            Dim cat As Object = CreateObject("ADOX.Catalog")
            cat.Create(connectionString)
            Try
                If cat.ActiveConnection IsNot Nothing Then
                    cat.ActiveConnection.Close()
                End If
            Catch
            End Try
            Return
        Catch
        End Try

        Try
            Dim engine As Object = CreateObject("DAO.DBEngine.36")
            Dim db As Object = engine.CreateDatabase(mdbPath, ";LANGID=0x0407;CP=1252;COUNTRY=0")
            db.Close()
            Return
        Catch
        End Try

        Throw New InvalidOperationException(
            "Leere Access-Datenbank konnte nicht erzeugt werden (" & IO.Path.GetFileName(mdbPath) &
            "). ADOX/DAO (Microsoft Jet) ist nicht verfügbar.")
    End Sub

    Private Sub EnsureSchema(ByVal mdbPath As String, ByVal schema As DataSet)
        Using conn As New OleDbConnection(JetProvider & mdbPath)
            conn.Open()
            Dim existingTables As HashSet(Of String) = GetTableNames(conn)

            For Each table As DataTable In schema.Tables
                Dim tableName As String = table.TableName
                If String.IsNullOrEmpty(tableName) Then Continue For

                If Not existingTables.Contains(tableName.ToLowerInvariant()) Then
                    CreateTable(conn, table)
                    existingTables.Add(tableName.ToLowerInvariant())
                Else
                    Dim existingColumns As HashSet(Of String) = GetColumnNames(conn, tableName)
                    For Each column As DataColumn In table.Columns
                        If Not existingColumns.Contains(column.ColumnName.ToLowerInvariant()) Then
                            AddColumn(conn, tableName, column)
                            existingColumns.Add(column.ColumnName.ToLowerInvariant())
                        End If
                    Next
                End If
            Next
        End Using
    End Sub

    Private Function GetTableNames(ByVal conn As OleDbConnection) As HashSet(Of String)
        Dim names As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        If schemaTable IsNot Nothing Then
            For Each row As DataRow In schemaTable.Rows
                Dim name As String = Convert.ToString(row("TABLE_NAME"))
                If Not String.IsNullOrEmpty(name) AndAlso Not name.StartsWith("MSys", StringComparison.OrdinalIgnoreCase) Then
                    names.Add(name.ToLowerInvariant())
                End If
            Next
        End If
        Return names
    End Function

    Private Function GetColumnNames(ByVal conn As OleDbConnection, ByVal tableName As String) As HashSet(Of String)
        Dim names As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, tableName, Nothing})
        If schemaTable IsNot Nothing Then
            For Each row As DataRow In schemaTable.Rows
                Dim name As String = Convert.ToString(row("COLUMN_NAME"))
                If Not String.IsNullOrEmpty(name) Then
                    names.Add(name.ToLowerInvariant())
                End If
            Next
        End If
        Return names
    End Function

    Private Sub CreateTable(ByVal conn As OleDbConnection, ByVal table As DataTable)
        Dim parts As New List(Of String)
        Dim usedCounter As Boolean = False

        For Each column As DataColumn In table.Columns
            Dim sqlType As String
            If column.AutoIncrement AndAlso Not usedCounter Then
                sqlType = "COUNTER"
                usedCounter = True
                parts.Add(QuoteName(column.ColumnName) & " " & sqlType & " PRIMARY KEY")
            Else
                sqlType = MapJetType(column, allowCounter:=False)
                parts.Add(QuoteName(column.ColumnName) & " " & sqlType)
            End If
        Next

        If parts.Count = 0 Then Return

        Dim sql As String = "CREATE TABLE " & QuoteName(table.TableName) & " (" & String.Join(", ", parts.ToArray()) & ")"
        Using cmd As New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub AddColumn(ByVal conn As OleDbConnection, ByVal tableName As String, ByVal column As DataColumn)
        Dim sqlType As String = MapJetType(column, allowCounter:=False)
        Dim sql As String = "ALTER TABLE " & QuoteName(tableName) & " ADD COLUMN " & QuoteName(column.ColumnName) & " " & sqlType
        Using cmd As New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function MapJetType(ByVal column As DataColumn, ByVal allowCounter As Boolean) As String
        If allowCounter AndAlso column.AutoIncrement Then
            Return "COUNTER"
        End If

        Dim t As Type = column.DataType
        If t Is GetType(String) Then
            If column.MaxLength < 0 OrElse column.MaxLength > 255 Then
                Return "MEMO"
            End If
            If column.MaxLength = 0 Then
                Return "TEXT(255)"
            End If
            Return "TEXT(" & column.MaxLength.ToString() & ")"
        End If
        If t Is GetType(Integer) OrElse t Is GetType(Int32) Then
            Return "LONG"
        End If
        If t Is GetType(Short) OrElse t Is GetType(Int16) Then
            Return "SHORT"
        End If
        If t Is GetType(Long) OrElse t Is GetType(Int64) Then
            Return "DOUBLE"
        End If
        If t Is GetType(Byte) Then
            Return "BYTE"
        End If
        If t Is GetType(Boolean) Then
            Return "YESNO"
        End If
        If t Is GetType(DateTime) OrElse t Is GetType(Date) Then
            Return "DATETIME"
        End If
        If t Is GetType(Decimal) Then
            Return "CURRENCY"
        End If
        If t Is GetType(Double) Then
            Return "DOUBLE"
        End If
        If t Is GetType(Single) Then
            Return "SINGLE"
        End If
        If t Is GetType(Guid) Then
            Return "TEXT(38)"
        End If
        If t Is GetType(Byte()) Then
            Return "OLEOBJECT"
        End If

        Return "MEMO"
    End Function

    Private Function QuoteName(ByVal name As String) As String
        Return "[" & name.Replace("]", "]]") & "]"
    End Function

    Private Sub SeedToernverwaltungVersion(ByVal mdbPath As String)
        If Not File.Exists(mdbPath) Then Return

        DbAccess.WithRetry(Sub()
                               Using conn As New OleDbConnection(JetProvider & mdbPath)
                                   conn.Open()

                                   Dim tables As HashSet(Of String) = GetTableNames(conn)
                                   If Not tables.Contains("steuerdaten") Then Return

                                   Dim count As Integer
                                   Using cmd As New OleDbCommand("SELECT COUNT(*) FROM [Steuerdaten] WHERE [Bezeichnung]=?", conn)
                                       cmd.Parameters.AddWithValue("@p1", "Version")
                                       count = Convert.ToInt32(cmd.ExecuteScalar())
                                   End Using

                                   If count = 0 Then
                                       Using cmd As New OleDbCommand("INSERT INTO [Steuerdaten] ([Bezeichnung], [Feld1]) VALUES (?, ?)", conn)
                                           cmd.Parameters.AddWithValue("@p1", "Version")
                                           cmd.Parameters.AddWithValue("@p2", AppMajorVersion)
                                           cmd.ExecuteNonQuery()
                                       End Using
                                   Else
                                       Using cmd As New OleDbCommand("UPDATE [Steuerdaten] SET [Feld1]=? WHERE [Bezeichnung]=?", conn)
                                           cmd.Parameters.AddWithValue("@p1", AppMajorVersion)
                                           cmd.Parameters.AddWithValue("@p2", "Version")
                                           cmd.ExecuteNonQuery()
                                       End Using
                                   End If
                               End Using
                           End Sub)
    End Sub

End Module
