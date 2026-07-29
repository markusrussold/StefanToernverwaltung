Option Explicit On
Option Strict On

''' <summary>Hardened license key checksum validation.</summary>
Public Class CheckKey

    Public Shared Function keypruefen(ByVal key As Object) As Boolean
        If key Is Nothing OrElse IsDBNull(key) Then Return False

        Dim keyText As String = Convert.ToString(key).Trim()
        If keyText.Length <> 20 Then Return False

        ' Only allow printable ASCII letters/digits and common separators already used by keys.
        For Each ch As Char In keyText
            Dim code As Integer = AscW(ch)
            If code < 33 OrElse code > 126 Then Return False
        Next

        Dim z1 As Integer
        Dim z2 As Integer
        Dim z3 As Integer
        Dim z4 As Integer
        Dim summand As Integer

        If Not Integer.TryParse(keyText.Substring(2, 1), z1) OrElse
           Not Integer.TryParse(keyText.Substring(6, 1), z2) OrElse
           Not Integer.TryParse(keyText.Substring(10, 1), z3) OrElse
           Not Integer.TryParse(keyText.Substring(14, 1), z4) OrElse
           Not Integer.TryParse(keyText.Substring(15, 1), summand) Then
            Return False
        End If

        Return ((z1 + z2 + z3 + z4) Mod 10) = summand
    End Function

End Class
