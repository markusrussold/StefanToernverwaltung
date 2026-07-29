Public Class LetzterString
    Public Shared Sub letztes(ByVal Input, ByVal Zeichen, ByRef output)
        Dim a As String
        Dim l As Integer
        a = InStr(1, Input, Zeichen)
        If a = "0" Then
            output = Input
            GoTo ausgang
        End If
        l = Len(Input)
        output = Input.ToString.Substring(a, l - a)
ausgang:
    End Sub
End Class
