Option Explicit On
Option Strict On

Imports System.IO
Imports Microsoft.VisualBasic

''' <summary>Hardened wrappers around VB GetSetting/SaveSetting (registry).</summary>
Public Module AppSettings

    Public Function GetString(ByVal appName As String, ByVal section As String, ByVal key As String, Optional ByVal defaultValue As String = "") As String
        Try
            Dim raw As String = GetSetting(appName, section, key, defaultValue)
            If raw Is Nothing Then Return defaultValue
            Return raw.Trim()
        Catch ex As Exception
            AppLog.Warn("GetSetting fehlgeschlagen (" & appName & "/" & section & "/" & key & "): " & ex.Message)
            Return defaultValue
        End Try
    End Function

    Public Sub SetString(ByVal appName As String, ByVal section As String, ByVal key As String, ByVal value As String)
        Try
            SaveSetting(appName, section, key, If(value, String.Empty))
        Catch ex As Exception
            AppLog.ErrorLog("SaveSetting fehlgeschlagen (" & appName & "/" & section & "/" & key & ")", ex)
        End Try
    End Sub

    ''' <summary>Reads a path setting and returns empty if the path is blank/invalid.</summary>
    Public Function GetPath(ByVal appName As String, ByVal section As String, ByVal key As String, Optional ByVal defaultValue As String = "") As String
            Dim raw As String = GetString(appName, section, key, defaultValue)
        If String.IsNullOrWhiteSpace(raw) Then Return defaultValue
        Try
            Return System.IO.Path.GetFullPath(Environment.ExpandEnvironmentVariables(raw.Trim().Trim(""""c)))
        Catch
            Return raw.Trim()
        End Try
    End Function

    Public Function GetLicenseKey() As String
        Dim key As String = GetString("toern", "Pfad", "T", "")
        If String.IsNullOrWhiteSpace(key) Then
            key = GetString("Toern", "Pfad", "T", "")
        End If
        Return If(key, String.Empty).Trim()
    End Function

    Public Function IsLicenseValid() As Boolean
        Dim key As String = GetLicenseKey()
        If String.IsNullOrWhiteSpace(key) Then Return False
        If key.Length <> 20 Then Return False
        If key.IndexOf(" "c) >= 0 OrElse key.IndexOf(ControlChars.Tab) >= 0 Then Return False
        ' Course license uses CheckKurs; fall back to CheckKey for legacy keys.
        Return CheckKurs.keypruefen(key) OrElse CheckKey.keypruefen(key)
    End Function

End Module
