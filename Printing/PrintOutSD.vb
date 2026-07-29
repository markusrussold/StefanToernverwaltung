Option Explicit On
Imports System.Drawing.Printing
Imports System.IOPublic
Class PrintOutSD
    Dim ypos As Single
    Dim landkarte As String
    Dim xPos(7) As Single
    Dim zeile As Integer = 0
    Public speicherbild As String
    Private printFont As Font
    Private dt As DataTable
    Dim logo As Image
    Dim leftMargin As Single
    Dim topMargin As Single
    Private lastRow As Integer = 0
    Dim aaa As String
    Public Sub PrintStandort(ByVal tIn As DataTable)                                           '       Standort
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        landkarte = GetSetting("karte", "Pfad", "T")
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim row As DataRow = Nothing
        Dim rNbr As Integer
        leftMargin = ev.MarginBounds.Left
        topMargin = ev.MarginBounds.Top
        rNbr = lastRow
        row = dt.Rows(rNbr)
        drucken(ev, row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12), row(13))
    End Sub
    Private Sub drucken(ByVal ev, ByVal Bezeichnung, ByVal Strasse, ByVal Plz, ByVal Ort, ByVal Typ, ByVal MaxTeilnehmer, ByVal Infrastruktur, ByVal Kosten, ByVal Bemerkung, ByVal Link, ByVal Karte, ByVal email, ByVal WEBSeite, ByVal Telefon)
        Dim linesPerPage As Single = 0
        Dim postleitzahl As String
        If IsDBNull(Plz) Then
            postleitzahl = "0000"
        Else
            postleitzahl = Plz
        End If
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 120
        xPos(2) = xPos(1) + 155
        xPos(3) = xPos(2) + 120
        xPos(4) = xPos(3) + 155
        xPos(5) = xPos(4) + 120
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(Bezeichnung, printFont, Brushes.Black, ev.MarginBounds.Left + 250, ypos, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(5), ypos, New StringFormat())
        zeile += 6
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Strasse:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Strasse), "", Strasse), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Ort:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Ort), "", postleitzahl + " " + Ort), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Typ:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Typ), "", Typ), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Infrastruktur:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Infrastruktur), "", Infrastruktur), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Max. Teilnehmer:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(MaxTeilnehmer), "", MaxTeilnehmer), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Kosten:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Kosten), "", Kosten), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Telefon:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Telefon), "", Telefon), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("email:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(email), "", email), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        zeile += 1
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("WEB Seite:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(WEBSeite), "", WEBSeite), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        If Not DBNull.Value.Equals(Bemerkung) Then
            zeile += 1
            ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Bemerkung:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
            zeile = Langtext.LangtextDrucken(Bemerkung, zeile, ypos, printFont, xPos(0), ev, linesPerPage)                                                '  Bemerkung
        End If
        If Not DBNull.Value.Equals(Link) Then
            zeile += 1
            ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Link:", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
            aaa = Len(Link)
            If Len(Link) > 90 Then
                ev.Graphics.DrawString(Link.ToString.Substring(0, 89), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
                zeile += 1
                ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(Link.ToString.Substring(90, aaa - 90), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
            Else
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Link), "", Link), printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
            End If
        End If


        zeile += 5
        ypos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(" ", printFont, Brushes.Black, xPos(0), ypos, New StringFormat())

        Dim foto As Image
        Dim BildB As Single
        Dim bildh As Single
        Dim faktor As Single
        Dim pixel As GraphicsUnit = GraphicsUnit.Pixel
        Dim bildbb As Single = 750
        Bezeichnung = Bezeichnung.Replace(" ", "")

        If My.Computer.FileSystem.FileExists(Trim$((landkarte + Bezeichnung + ".jpg"))) Then
            foto = Image.FromFile(Trim$((landkarte + Bezeichnung + ".jpg")))
            BildB = foto.Width
            bildh = foto.Height
            faktor = BildB / bildh
            '  bildbb / faktor    muss klein 580 sein in einer Schleife
bild1:
            If bildbb / faktor > 800 Then
                bildbb -= 10
                GoTo bild1
            End If
            ev.Graphics.DrawImage(foto, New Rectangle(ev.MarginBounds.Left - 60, ypos, bildbb, bildbb / faktor))
        End If


    End Sub

End Class
