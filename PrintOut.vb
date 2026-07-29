Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOut
    '                                                                                                   Drucken Kalkulationsblatt
    Public Anzahlung As Single
    Public Restzahlung As Single
    Public Wochen As Integer
    Public Konto As String
    Public Bic As String
    Public BLZ As String
    Public IBAN As String
    Private printFont As Font
    Private printFFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Public speicherbild As String
    Dim logo As Image
    Public drucksteuerung As String
    Public cha As String
    Public ver As String
    Public bar As String
    Public aaa As String
    Dim hex As String
    Public routelange As Integer
    Public zr As Integer
    Public zs As Integer
    Public zeilentext As String
    Public zeilenanf As Single
    Public x As New Leerstelle

    ' The Click event is raised when the user clicks the Print button.
    Public Sub PrintKalkulation(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        dt = tIn
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        Anzahlung = GetSetting("toern", "Anzahlung", "T")
        drucksteuerung = GetSetting("toern", "Drucksteuerung", "T")
        Restzahlung = GetSetting("toern", "Restzahlung", "T")
        Wochen = GetSetting("toern", "Wochen", "T")
        Konto = Kalkulationsblatt.TextBox11.Text
        Bic = Kalkulationsblatt.TextBox14.Text
        BLZ = Kalkulationsblatt.TextBox12.Text
        IBAN = Kalkulationsblatt.TextBox13.Text
        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub

    ' The PrintPage event is raised for each page to be printed.
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim temp As Single
        Dim yPos As Single = 0
        Dim xPos(6) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 7
        Dim rNbr As Integer
        Dim CharVerAnt As Integer
        Dim AnzahlungBar As Integer
        Dim restzahlungBar As Integer
        Dim var As Integer
        Dim var2 As Integer
        Dim var1 As Integer
        Dim Versicherungssumme As Single
        Dim Bordkassasumme As Single
        Dim Transportsumme As Single
        Dim text As String
        Dim sSize As SizeF
        Dim breite2 As Single
        Dim pp As Integer
        Dim ppk As Integer
        Dim anzc As Integer
        Dim anzv As Integer
        Dim anzk As Integer
        Dim k1 As Single = 0
        Dim k2 As Single = 0
        Dim k3 As Single = 0
        Dim k4 As Single = 0
        Dim k5 As Single = 0
        Dim kabinerest As Integer
        Dim kabine As Integer
         Dim quelle As String
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 130
        xPos(2) = xPos(1) + 200
        xPos(6) = xPos(2) + 300
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("K a l k u l a t i o n ", printFont, Brushes.Black, xPos(2) - 120, topMargin, New StringFormat())
        row = dt.Rows(0)
        '  ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(3), topMargin - 50, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin, New StringFormat())
        printFFont = New Font("Arial", 10, FontStyle.Bold)
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(34)), "", row(34)) + " - " + row(35), printFont, Brushes.Black, xPos(0) + 240, topMargin + 2 * printFont.GetHeight(ev.Graphics), New StringFormat())  'Crewanzahl

        anzc = row(10)
        anzv = row(10)
        anzk = row(10)
        If SafeData.SafeSubstring(drucksteuerung, 1, 1) = "1" Then
            anzv += 1
        End If
        If SafeData.SafeSubstring(drucksteuerung, 2, 1) = "1" Then
            anzc += 1
        End If
        If SafeData.SafeSubstring(drucksteuerung, 3, 1) = "1" Then
            anzk += 1
        End If

        ' Print each line of the file.
        rNbr = lastRow

        'zeigt nur wie Texte abgemessen werden, hat sonst keine Funktion
        sSize = ev.Graphics.MeasureString(row(2), printFont, 1000)
        breite2 = sSize.Width.ToString
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 240
        xPos(2) = xPos(1) + 220
        xPos(3) = xPos(2) + 110

        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(37)), "", "Skipper: " + row(37)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        '      zeile += 1
        '     yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        '      ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(36)), "", "Route: " + row(36)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        If Not DBNull.Value.Equals(row(36)) Then
             quelle = "Route: " & row(36)
            zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0), ev, linesPerPage)
        End If
        '  --------------------------------------------------------------------------------------    Charterkosten  -------------------------------------------------------------------------------------
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Törn: " + row(0), printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())                   'Törn
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(1)), "", "Boot: " + row(1)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", "Charterkosten: "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        '      45 Länge des Augabefensters für Wert
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2).ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 50, 20), New StringFormat())
        ppk = row(2)
        If row(28) > 0 And Not Kalkulationsblatt.zweiteSeite Or row(28) > 0 And Kalkulationsblatt.clubrabatt Or row(29) > 0 Then
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", row(10)), printFont, Brushes.Black, xPos(0) + 85, yPos, New StringFormat())  'Crewanzahl
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", "Crewanzahl:       Personen"), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())  'Crewanzahl
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(28)), "", "Rabatt:   " + row(28) + " %"), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            var = -row(2) * row(28) / 100
            sSize = ev.Graphics.MeasureString(var, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(28)), "", var.ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 50, 20), New StringFormat())
            ppk = var
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            If SafeData.SafeSubstring(drucksteuerung, 1, 3, "000") > "000" Then
                ev.Graphics.DrawString("+ Skipper = " + Str(row(10) + 1), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("Skipper ist frei ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            End If
            If row(29) > 0 And Not Kalkulationsblatt.zweiteSeite Then
                '               zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(29)), "", "Rabatt:   " + row(29) + " %"), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                var2 = -(row(2) + var) * row(29) / 100
                sSize = ev.Graphics.MeasureString(var2, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(29)), "", var2.ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 50, 20), New StringFormat())
                ppk = var2
                var1 = row(2) + var + var2
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2), yPos), New Point(xPos(3) + 50, yPos))
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var1), "", "Nettokosten:   "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                sSize = ev.Graphics.MeasureString(var1, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var1), "", var1.ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 50, 20), New StringFormat())
                ppk = var1
            Else
                var1 = row(2) + var
                '              zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2), yPos), New Point(xPos(3) + 50, yPos))
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var1), "", "Nettokosten:   "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                sSize = ev.Graphics.MeasureString(var1, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var1), "", var1.ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 50, 20), New StringFormat())
                ppk = var1
            End If
        Else
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", row(10)), printFont, Brushes.Black, xPos(0) + 85, yPos, New StringFormat())  'Crewanzahl
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", "Crewanzahl:       Personen"), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())  'Crewanzahl
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            If SafeData.SafeSubstring(drucksteuerung, 1, 3, "000") > "000" Then
                ev.Graphics.DrawString("+ Skipper = " + Str(row(10) + 1), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("Skipper ist frei ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            End If
        End If
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Eine Kabine wird mit einem anderen Reisegast geteilt, wenn nicht explizit eine ganze Kabine gebucht ist.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        pp = 2 * ppk / anzc                                                                                                                    'Kabinenpreis
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pp), "", "pro Kabine: "), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        sSize = ev.Graphics.MeasureString(pp, printFont, 1000)
        breite2 = sSize.Width.ToString
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var1), "", pp.ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 110 - breite2, yPos, 50, 20), New StringFormat())
        pp = ppk / anzc                                                                                                                       ' Kojenpreis
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pp), "", "pro Koje:   "), printFFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        sSize = ev.Graphics.MeasureString(pp, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var1), "", pp.ToString + " € "), printFFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 50, 20), New StringFormat())
            k1 = pp

            ' ---------------------------------------------------------------------------------------------------------   Reisekosten   ----------------------------------------------------------------------------------------------------
        zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Reisekosten/Person", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            If row(6) > 0 Then
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(24)), "", "Flughafen:   " + row(24)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())   'Flughafen
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", "Hinflug Datum.: " + row(4)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())   'Anflug Datum
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", "Rückflug Datum.: " + row(5)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())  'Rückflug Datum
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", "Flugkosten ca.: "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())   'Flugkosten
                text = Format$(row(6), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", Format$(row(6), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(0) + 155 - breite2, yPos, 70, 20), New StringFormat())   'Flugkosten
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(13)), "", "Hinflug Nr.:        " + row(13)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())   'Anflug Nr
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(14)), "", "Rückflug Nr.:       " + row(14)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())  'Rückflug Nr
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", "Marina (Shuttle, Taxi)"), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())  'Rückflug
                '          zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                text = Format$(row(7), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", "- Anreise: "), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())  'Rückflug
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", Format$(row(7), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 130 - breite2, yPos, 70, 20), New StringFormat())  'Rückflug
                text = Format$(row(8), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", "- Rückreise:"), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())   'Anflug
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", Format$(row(8), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Anflug
            Else
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(32)), "", "Km-Geld für die Autoanreise mit 3 Personen: "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())   'Flugkosten
                text = Format$(row(32) * 3, "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(32)), "", Format$(row(32) * 3, "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 130 - breite2, yPos, 70, 20), New StringFormat())   'Flugkosten
                text = Format$(row(32), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(32)), "", "pro Person: "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())   'Flugkosten
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(32)), "", text + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Flugkosten
            End If
            Transportsumme = 0
            temp = CheckBNull.checkDBNull(row(6))
            Transportsumme += row(6)
            Transportsumme += row(7)
            Transportsumme += row(8)
            Transportsumme += CheckBNull.checkDBNull(row(32))
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            text = Format$(Transportsumme, "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Transportsumme), "", "Summe: "), printFFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Transportsumme), "", Format$((Transportsumme), "#0.00").ToString + " € "), printFFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Rücktritt
            k2 = Transportsumme




            '--------------------------------------------------------   Bordkassa --------------------------------------------------------------------------------------------------
        zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Bordkassa", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("(durchschnittliche Erfahrungswerte):", printFont, Brushes.Black, xPos(0) + 75, yPos, New StringFormat())

            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            text = Format$(row(9), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "", "Einkaufstaxi: "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())   'Taxi
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "", Format$(row(9), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(0) + 155 - breite2, yPos, 70, 20), New StringFormat())   'Taxi
            text = Format$(row(21), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(21)), "", "Bunkern: "), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())   'Taxi
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(21)), "", Format$(row(21), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 130 - breite2, yPos, 70, 20), New StringFormat())   'Bunkern
            text = Format$(row(23), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(23)), "", "Marinakosten: "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())   'Taxi
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(23)), "", Format$(row(23), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Marinakosten

            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            text = Format$(row(22), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(22)), "", "Land Essen: "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())   'Taxi
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(22)), "", Format$(row(22), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(0) + 155 - breite2, yPos, 70, 20), New StringFormat())   'Landessen
            text = Format$(row(11), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "", "Treibstoff: "), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())  'Rückflug
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "", Format$(row(11), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 130 - breite2, yPos, 70, 20), New StringFormat())   'Treibstoff
            text = Format$(row(25), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(25)), "", "Sonstiges: "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())   'Taxi
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(25)), "", Format$(row(25), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Taxi

            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            text = Format$(row(31), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(31)), "", "Endreinigung:  "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())   'Taxi
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(31)), "", Format$(row(31), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(0) + 155 - breite2, yPos, 70, 20), New StringFormat())   'Landessen
            text = Format$(row(27), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(27)), "", "Permit:"), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())  'Rückflug
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(27)), "", Format$(row(27), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 130 - breite2, yPos, 70, 20), New StringFormat())
            text = Format$(row(30), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(30)), "", "Aussenborder:   "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())   'Taxi
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(30)), "", Format$(row(30), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Taxi
            Bordkassasumme = 0
            Bordkassasumme += row(9)
            Bordkassasumme += row(21)
            Bordkassasumme += row(22)
            Bordkassasumme += row(23)
            Bordkassasumme += row(11)
            Bordkassasumme += row(25)
            Bordkassasumme += row(30)
            Bordkassasumme += row(31)
            Bordkassasumme += row(27)
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            text = Format$(Bordkassasumme, "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Bordkassasumme), "", "Summe: "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Bordkassasumme), "", Format$((Bordkassasumme), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Rücktritt
            pp = Bordkassasumme / anzk
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pp), "", "pro Person:   "), printFFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            text = Format$(pp, "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pp), "", Format$((pp), "#0.00").ToString + " € "), printFFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())
            k3 = pp
        zeile += 1
        '-----------------------------------------------------------------------------------------------------       Versicherungen  --------------------------------------------------------------------------------------------------------------
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

        ev.Graphics.DrawString("Versicherungen", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(15)), "", "Haftpflicht: "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            text = Format$(row(15), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(15)), "", Format$(row(15), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(0) + 155 - breite2, yPos, 70, 20), New StringFormat())   'Haftpflicht
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(16)), "", "Crew Unfall:  "), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            text = Format$(row(16), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(16)), "", Format$(row(16), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 130 - breite2, yPos, 70, 20), New StringFormat())   'Crew Unfall
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(17)), "", "Rechtschutz:  "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            text = Format$(row(17), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(17)), "", Format$(row(17), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Rechtschutz

            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(18)), "", "Beschlagnahme:  "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            text = Format$(row(18), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(18)), "", Format$(row(18), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(0) + 155 - breite2, yPos, 70, 20), New StringFormat())   'Beschlagnahme
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(19)), "", "Kaution : "), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            text = Format$(row(19), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(19)), "", Format$(row(19), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 130 - breite2, yPos, 70, 20), New StringFormat())   'Kaution
            text = Format$(row(20), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(20)), "", "Rücktritt: "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(20)), "", Format$(row(20), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Rücktritt

            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(38)), "", "Folgeschaden:  "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            text = Format$(row(38), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(38)), "", Format$(row(38), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(0) + 155 - breite2, yPos, 70, 20), New StringFormat())   'Folgeschaden
            Versicherungssumme = 0
            Versicherungssumme += row(17)
            Versicherungssumme += row(15)
            Versicherungssumme += row(16)
            Versicherungssumme += row(18)
            Versicherungssumme += row(19)
            Versicherungssumme += row(20)
            Versicherungssumme += row(38)
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            text = Format$(Versicherungssumme, "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Versicherungssumme), "", "Summe: "), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Versicherungssumme), "", Format$((Versicherungssumme), "#0.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())   'Rücktritt
            pp = Versicherungssumme / anzv
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pp), "", "pro Person:   "), printFFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            text = Format$(pp, "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pp), "", Format$((pp), "#0.00").ToString + " € "), printFFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())
            k4 = pp
        ' -------------------------------------------------------------------- Skipperkosten ------------------------------------------------------------------------
        zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
        If drucksteuerung.Substring(1, 3) = "   " Then
        Else
            If drucksteuerung.Substring(1, 3) > "000" Then
                If drucksteuerung.Substring(1, 3) = "111" Then
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Skipper beteiligt sich an allen Kosten ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                Else
                    If drucksteuerung.Substring(1, 1) = "1" Then
                        ver = "Versicherung "
                    Else
                        ver = ""
                    End If
                    If drucksteuerung.Substring(2, 1) = "1" Then
                        cha = "Charterkosten "
                    Else
                        cha = ""
                    End If
                    If drucksteuerung.Substring(3, 1) = "1" Then
                        bar = "Bordkassa "
                    Else
                        bar = ""
                    End If
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Skipper beteiligt sich an der: " + cha + ver + bar, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                End If
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Skipper ist frei ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            End If
        End If
            If row(33) > 0 Then
                text = Format$(row(33), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Skipper Kosten:  " + Format$(row(33), "#.00") + " €", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                k5 = row(33) / anzc
            Else
                k5 = 0
            End If
            '-----------------------------------------------------------------------------------   Gesamtkosten pro Person -----------------------------------------------------------------------------------------------------
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "", "Gesamtkosten* pro Person "), printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            '        var = row(3)
            var = k1 + k2 + k3 + k4 + k5
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var), "", " (Anteil für Charter, Bordkassa und Versicherung, inkl. Reisekosten) :"), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            text = Format$(var, "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(var), "", Format$(var, "#0.00").ToString + " € "), printFFont, Brushes.Black, New RectangleF(xPos(2) + 145 - breite2, yPos, 70, 20), New StringFormat())  'Kosten/Person
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(("* Die Kosten können sich erhöhen, falls nicht die geplante Crewanzahl am Törn teilnimmt. "), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

        zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
            text = IIf(DBNull.Value.Equals(row(12)), " ", row(12))

            '
            '---------------------------------------------------------------------- Bemerkung ------------------------------------------------------------------------------
            '
            If drucksteuerung.Substring(0, 1) = "1" And text <> " " Then
                quelle = "Bemerkung : " & row(12)
            zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0), ev, linesPerPage)                                                ' Törn Bemerkung
            End If
            ' -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        If CheckBNull.checkDBNull(row(32)) > 0 Then
            ev.Graphics.DrawString("Bordkassa wird beim Einchecken in bar befüllt.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("Flug buchst Du selber im Internet. Bordkassa wird beim Einchecken in bar befüllt.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        End If
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Anteil Charter und Versicherung wird als Anzahlung und Restzahlung überwiesen. Bankverbindung siehe", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("unten. Erst mit der Anzahlung ist die Koje fixiert.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ' ----------------------------------------------------------- Anzahlung --------  Restzahlung --------------------------------
        zeile += 1
            If Kalkulationsblatt.clubrabatt Then
                CharVerAnt = CheckBNull.checkDBNull(row(26))
            Else
                CharVerAnt = CheckBNull.checkDBNull(row(39))
        End If
        kabine = CharVerAnt * 2 - (Versicherungssumme / anzv)
        kabine = kabine * Anzahlung / 100
        kabinerest = CharVerAnt * 2 - (Versicherungssumme / anzv) - kabine
        AnzahlungBar = CharVerAnt * Anzahlung / 100
        restzahlungBar = CharVerAnt - AnzahlungBar
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Anzahlung  ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(Anzahlung, printFont, Brushes.Black, xPos(0) + 90, yPos, New StringFormat())
        ev.Graphics.DrawString("% d.h. pro Koje", printFont, Brushes.Black, xPos(0) + 110, yPos, New StringFormat())
        text = Format$(AnzahlungBar, "#0.00")
        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
        breite2 = sSize.Width.ToString
        ev.Graphics.DrawString(Format$(AnzahlungBar, "#.00") + " €", printFont, Brushes.Black, New RectangleF(xPos(0) + 265 - breite2, yPos, 70, 20), New StringFormat())
        ev.Graphics.DrawString("pro Kabine", printFont, Brushes.Black, xPos(0) + 330, yPos, New StringFormat())
        text = Format$(kabine, "#0.00")
        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
        breite2 = sSize.Width.ToString
        ev.Graphics.DrawString(Format$(kabine, "#.00") + " €", printFont, Brushes.Black, New RectangleF(xPos(0) + 460 - breite2, yPos, 70, 20), New StringFormat())
        If DBNull.Value.Equals(row(40)) Then
        Else
            ev.Graphics.DrawString("bis " + (Replace(row(40), ",", ".")), printFont, Brushes.Black, xPos(2) + 90, yPos, New StringFormat())
        End If
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Restzahlung ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(Restzahlung, printFont, Brushes.Black, xPos(0) + 90, yPos, New StringFormat())
        ev.Graphics.DrawString("% d.h. pro Koje ", printFont, Brushes.Black, xPos(0) + 110, yPos, New StringFormat())
        text = Format$(restzahlungBar, "#0.00")
        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
        breite2 = sSize.Width.ToString
        ev.Graphics.DrawString(Format$(restzahlungBar, "#.00") + " €", printFont, Brushes.Black, New RectangleF(xPos(0) + 265 - breite2, yPos, 70, 20), New StringFormat())
        ev.Graphics.DrawString("pro Kabine", printFont, Brushes.Black, xPos(0) + 330, yPos, New StringFormat())
        text = Format$(kabinerest, "#0.00")
        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
        breite2 = sSize.Width.ToString
        ev.Graphics.DrawString(Format$(kabinerest, "#.00") + " €", printFont, Brushes.Black, New RectangleF(xPos(0) + 460 - breite2, yPos, 70, 20), New StringFormat())
        If DBNull.Value.Equals(row(41)) Then
        Else
            ev.Graphics.DrawString("bis " + (Replace(row(41), ",", ".")), printFont, Brushes.Black, xPos(2) + 90, yPos, New StringFormat())
        End If
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Bei Nichtteilnahme können bereits eingezahlte Beträge nicht rückerstattet werden. Bitte, sorge selbst für ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("einen Ersatz. Die ev. Rücktrittversicherung deckt die Kosten nur im ärtztlich bestätigten Krankheitsfall. ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())


        zeile = 63
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin, yPos), New Point(ev.MarginBounds.Right + 10, yPos))
            '        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        If Konto <> "0" Then
            ev.Graphics.DrawString("Bankverbindung Konto:  ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(Konto + "   " + IBAN, printFont, Brushes.Black, xPos(0) + 150, yPos, New StringFormat())
        End If
        '       ev.Graphics.DrawString("IBAN:  ", printFont, Brushes.Black, xPos(1) + 40, yPos, New StringFormat())
        '      ev.Graphics.DrawString(IBAN, printFont, Brushes.Black, xPos(1) + 80, yPos, New StringFormat())
      End Sub
End Class



