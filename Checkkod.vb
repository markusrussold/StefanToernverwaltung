Public Class Checkkod
    Public Shared Function keygesamt(ByVal key1, ByVal key2, ByVal key3)
        ' key1 Gesamtkey
        ' key2 Törnkey
        ' key3 Kurskey

        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung

        Dim ok As String
        If key1 Then
            If key2 Then
                If key3 Then
                    ok = "4"
                Else
                    ok = "1"
                End If
            Else
                ok = "0"
            End If
        Else
            ok = "0"
        End If
        Return ok
    End Function

End Class
