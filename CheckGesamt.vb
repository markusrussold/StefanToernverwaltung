Public Class CheckGesamt
    Public Shared Function keygesamt(ByVal key)
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
                z1 = key.substring(0, 4)
                z2 = key.substring(4, 4)
                z3 = key.substring(8, 4)
                z4 = key.substring(12, 4)
                summe = z1
                summe = summe + z2
                summe = summe + z3
                summe = summe + z4
                summand = summe
                summe = summand.Substring(0, 1)
                summe = summe + summand.Substring(1, 1)
                summe = summe + summand.Substring(2, 1)
                summe = summe + summand.Substring(3, 1)
                summand = summe
                If summe >= 10 Then
                    summand = summand.Substring(1, 1)
                Else
                    summand = summand.Substring(0, 1)
                End If
                intege = key.substring(17, 1)

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
