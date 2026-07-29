Option Explicit On
Option Strict On

Imports System.IO
Imports System.Diagnostics

''' <summary>Validates file/folder paths before Process.Start or file IO.</summary>
Public Module PathGuard

    Public Function IsSafeExistingFile(ByVal filePath As String, ByRef fullPath As String, ByRef errorMessage As String) As Boolean
        fullPath = Nothing
        errorMessage = Nothing
        If String.IsNullOrWhiteSpace(filePath) Then
            errorMessage = "Kein Dateipfad angegeben."
            Return False
        End If
        Try
            Dim candidate As String = Environment.ExpandEnvironmentVariables(filePath.Trim().Trim(""""c))
            fullPath = System.IO.Path.GetFullPath(candidate)
            If Not File.Exists(fullPath) Then
                errorMessage = "Datei existiert nicht: " & fullPath
                Return False
            End If
            Return True
        Catch ex As Exception
            errorMessage = "Ungültiger Dateipfad: " & ex.Message
            Return False
        End Try
    End Function

    Public Function IsSafeExistingDirectory(ByVal dirPath As String, ByRef fullPath As String, ByRef errorMessage As String) As Boolean
        fullPath = Nothing
        errorMessage = Nothing
        If String.IsNullOrWhiteSpace(dirPath) Then
            errorMessage = "Kein Ordnerpfad angegeben."
            Return False
        End If
        Try
            Dim candidate As String = Environment.ExpandEnvironmentVariables(dirPath.Trim().Trim(""""c))
            fullPath = System.IO.Path.GetFullPath(candidate)
            If Not Directory.Exists(fullPath) Then
                errorMessage = "Ordner existiert nicht: " & fullPath
                Return False
            End If
            Return True
        Catch ex As Exception
            errorMessage = "Ungültiger Ordnerpfad: " & ex.Message
            Return False
        End Try
    End Function

    Public Function TryStartFile(ByVal filePath As String, Optional ByVal arguments As String = Nothing) As Boolean
        Dim full As String = Nothing
        Dim err As String = Nothing
        If Not IsSafeExistingFile(filePath, full, err) Then
            AppLog.Warn(err)
            Return False
        End If
        Try
            Dim psi As New ProcessStartInfo() With {
                .FileName = full,
                .UseShellExecute = True
            }
            If Not String.IsNullOrEmpty(arguments) Then
                psi.Arguments = arguments
            End If
            Process.Start(psi)
            Return True
        Catch ex As Exception
            AppLog.ErrorLog("Process.Start fehlgeschlagen: " & full, ex)
            Return False
        End Try
    End Function

    Public Function TryStartPdf(ByVal acrobatOrPdfPath As String, ByVal pdfName As String) As Boolean
        Dim pdfFull As String = Nothing
        Dim err As String = Nothing
        If Not IsSafeExistingFile(pdfName, pdfFull, err) Then
            Dim alt As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pdfName)
            If Not IsSafeExistingFile(alt, pdfFull, err) Then
                AppLog.Warn(err)
                Return False
            End If
        End If

        Dim viewer As String = Nothing
        Dim viewerErr As String = Nothing
        If IsSafeExistingFile(acrobatOrPdfPath, viewer, viewerErr) Then
            Try
                Process.Start(New ProcessStartInfo() With {
                    .FileName = viewer,
                    .Arguments = """" & pdfFull & """",
                    .UseShellExecute = True
                })
                Return True
            Catch ex As Exception
                AppLog.Warn("Acrobat-Start fehlgeschlagen, fallback ShellExecute: " & ex.Message)
            End Try
        End If

        Try
            Process.Start(New ProcessStartInfo() With {
                .FileName = pdfFull,
                .UseShellExecute = True
            })
            Return True
        Catch ex As Exception
            AppLog.ErrorLog("PDF konnte nicht geöffnet werden: " & pdfFull, ex)
            Return False
        End Try
    End Function
End Module
