Public Class CheckBNull
    Public Shared Function checkDBNull(ByRef wert)
        Dim check As Single
        If IsDBNull(wert) = False Then
            If IsNumeric(wert) Then
                check = wert
            Else
                check = 0
            End If
        End If
        Return check
    End Function
End Class
