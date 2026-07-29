Public Class CheckKey

    Public Shared Function keypruefen(ByVal key)
        Dim ok As Boolean
    Dim z1 As String
    Dim z2 As String
    Dim z3 As String
    Dim z4 As String
    Dim summe As Single
    Dim ex As String
    Dim intege As Decimal
    Dim summand As String

        If key Is Nothing Then
            ok = False
        Else
            If Len(key) = 20 Then
                z1 = key.substring(2, 1)
                z2 = key.substring(6, 1)
                z3 = key.substring(10, 1)
                z4 = key.substring(14, 1)
                summand = key.substring(15, 1)
                summe = z1
                summe += z2
                summe += z3
                summe += z4
                ex = summe
                intege = ex.Substring(Len(ex) - 1, 1)
                '               summe = summe - intege * 10
                If intege = summand Then
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
