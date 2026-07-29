Public Class Leerstelle
    Public Shared Function letzteLeerstelle(ByVal Zeilentext)
        Dim ok As Integer
        Dim laenge As Integer
        laenge = Len(Zeilentext)
        For ok = 0 To laenge - 1
            If Zeilentext.substring(laenge - ok - 1, 1) = " " Then
                Return ok
            End If
        Next
        ok = 0
        Return ok
      End Function
End Class
