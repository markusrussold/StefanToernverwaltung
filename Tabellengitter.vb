Public Class Tabellengitter
    Public Shared Sub gitter(ByVal ev, ByVal x, ByVal y, ByVal Hoehe, ByVal Breite, ByVal Anzahl_Zeilen, ByVal Anzahl_Spalten)
        '   Tabellengitter           ev,  x,  y,  Hoehe,  Breite,  Anzahl_Zeilen,  Anzahl_Spalten
        Dim printFont As Font
        Dim xe As Integer
        Dim ye As Integer
        Dim xs As Integer
        Dim ys As Integer
        xe = x + Breite * Anzahl_Spalten
        printFont = New Font("Arial", 12)
        ye = y + Anzahl_Zeilen * printFont.GetHeight(ev.Graphics) * Hoehe
        ys = y + printFont.GetHeight(ev.Graphics) * Hoehe
        ev.Graphics.Drawline(Pens.Black, x, y, xe, y)      ' gesamte Breite Oberstrich
        ev.Graphics.Drawline(Pens.Black, x, y, x, ye)      ' gesamte Höhe erste Kante
        For i = 1 To Anzahl_Zeilen
            ev.Graphics.Drawline(Pens.Black, x, ys, xe, ys)    ' 1 Zeilen Strich
            For ii = 1 To Anzahl_Spalten
                xs = x + Breite * ii
                ev.Graphics.Drawline(Pens.Black, xs, y, xs, ye)
            Next
            ys = ys + printFont.GetHeight(ev.Graphics) * Hoehe
        Next
    End Sub
    Public Shared Sub Datenbank(ByVal text)

    End Sub
End Class
