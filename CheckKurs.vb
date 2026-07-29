Public Class CheckKurs

    Public Shared Function keypruefen(ByVal key)
        Dim ok As Boolean
        Dim z1 As Integer
        Dim z2 As Integer
        Dim z3 As Integer
        Dim z4 As Integer
        Dim summand As Integer

        If key Is Nothing Then
            ok = False
        Else
            If Len(key) = 20 Then
                Dim keyText As String = Convert.ToString(key)
                If Not Integer.TryParse(keyText.Substring(0, 1), z1) OrElse
                   Not Integer.TryParse(keyText.Substring(4, 1), z2) OrElse
                   Not Integer.TryParse(keyText.Substring(8, 1), z3) OrElse
                   Not Integer.TryParse(keyText.Substring(12, 1), z4) OrElse
                   Not Integer.TryParse(keyText.Substring(13, 1), summand) Then Return False
                If ((z1 * z2 * z3) + z4) Mod 10 = summand Then
                    ok = True
                Else
                    ok = False
                End If
            Else
                ok = False
            End If
        End If
        Return ok
    End Function

End Class
