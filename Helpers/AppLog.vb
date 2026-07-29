Option Explicit On
Option Strict On

Imports System.IO
Imports System.Text
Imports System.Windows.Forms

''' <summary>Simple rolling file logger for unhandled and operational errors.</summary>
Public Module AppLog

    Private ReadOnly SyncRoot As New Object()
    Private Const MaxBytes As Long = 2 * 1024 * 1024

    Public ReadOnly Property LogDirectory As String
        Get
            Dim dir As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs")
            Directory.CreateDirectory(dir)
            Return dir
        End Get
    End Property

    Public ReadOnly Property LogFilePath As String
        Get
            Return Path.Combine(LogDirectory, "verwaltung-" & DateTime.Now.ToString("yyyyMMdd") & ".log")
        End Get
    End Property

    Public Sub Info(ByVal message As String)
        WriteLine("INFO", message, Nothing)
    End Sub

    Public Sub Warn(ByVal message As String)
        WriteLine("WARN", message, Nothing)
    End Sub

    Public Sub ErrorLog(ByVal message As String, Optional ByVal ex As Exception = Nothing)
        WriteLine("ERROR", message, ex)
    End Sub

    Public Sub WriteLine(ByVal level As String, ByVal message As String, ByVal ex As Exception)
        Try
            SyncLock SyncRoot
                Dim path As String = LogFilePath
                RotateIfNeeded(path)
                Dim sb As New StringBuilder()
                sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"))
                sb.Append(" [").Append(level).Append("] ")
                sb.Append(If(message, String.Empty))
                If ex IsNot Nothing Then
                    sb.AppendLine()
                    sb.Append(ex.ToString())
                End If
                sb.AppendLine()
                File.AppendAllText(path, sb.ToString(), Encoding.UTF8)
            End SyncLock
        Catch
            ' Logging must never crash the app.
        End Try
    End Sub

    Public Sub ShowError(ByVal userMessage As String, Optional ByVal ex As Exception = Nothing)
        ErrorLog(userMessage, ex)
        Dim detail As String = userMessage
        If ex IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(ex.Message) Then
            detail &= Environment.NewLine & Environment.NewLine & ex.Message
        End If
        MessageBox.Show(detail, "Törnverwaltung", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub RotateIfNeeded(ByVal path As String)
        Try
            If File.Exists(path) AndAlso New FileInfo(path).Length > MaxBytes Then
                Dim archive As String = path & "." & DateTime.Now.ToString("HHmmss") & ".old"
                File.Move(path, archive)
            End If
        Catch
        End Try
    End Sub

End Module
