Public Class CheckKurs

    Public Shared Function keypruefen(ByVal key)
        Dim ok As Boolean
        Dim z1 As String
        Dim z2 As String
        Dim z3 As String
        Dim z4 As String
        Dim summe As Single
        Dim intege As Decimal
        Dim summand As String

        If key Is Nothing Then
            ok = False
        Else
            If Len(key) = 20 Then
                z1 = key.substring(0, 1)
                z2 = key.substring(4, 1)
                z3 = key.substring(8, 1)
                z4 = key.substring(12, 1)
                summand = key.substring(13, 1)
                summe = z1
                summe = summe * z2
                summe = summe * z3
                summe += z4
                intege = summe.ToString.Substring(Len(summe.ToString) - 1, 1)

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
