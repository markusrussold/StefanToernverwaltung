Option Explicit On
Option Strict On

''' <summary>Hardened course-module license key checksum validation.</summary>
Public Class CheckKurs

    Public Shared Function keypruefen(ByVal key As Object) As Boolean
        If key Is Nothing OrElse IsDBNull(key) Then Return False

        Dim keyText As String = Convert.ToString(key).Trim()
        If keyText.Length <> 20 Then Return False

        For Each ch As Char In keyText
            Dim code As Integer = AscW(ch)
            If code < 33 OrElse code > 126 Then Return False
        Next

        Dim z1 As Integer
        Dim z2 As Integer
        Dim z3 As Integer
        Dim z4 As Integer
        Dim summand As Integer

        If Not Integer.TryParse(keyText.Substring(0, 1), z1) OrElse
           Not Integer.TryParse(keyText.Substring(4, 1), z2) OrElse
           Not Integer.TryParse(keyText.Substring(8, 1), z3) OrElse
           Not Integer.TryParse(keyText.Substring(12, 1), z4) OrElse
           Not Integer.TryParse(keyText.Substring(13, 1), summand) Then
            Return False
        End If

        Return (((z1 * z2 * z3) + z4) Mod 10) = summand
    End Function

End Class
