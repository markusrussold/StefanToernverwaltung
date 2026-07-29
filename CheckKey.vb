Public Class CheckKey

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
                If Not Integer.TryParse(keyText.Substring(2, 1), z1) OrElse
                   Not Integer.TryParse(keyText.Substring(6, 1), z2) OrElse
                   Not Integer.TryParse(keyText.Substring(10, 1), z3) OrElse
                   Not Integer.TryParse(keyText.Substring(14, 1), z4) OrElse
                   Not Integer.TryParse(keyText.Substring(15, 1), summand) Then Return False
                If (z1 + z2 + z3 + z4) Mod 10 = summand Then
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
