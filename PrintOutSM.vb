Option Explicit On
Imports System.Drawing.Printing
Imports System.IO

Public Class PrintOutSM
    '                                                                                           Drucken Seemeilenbestätigung
    Public speicherplatz As String
    Private printFont As Font
    Private printFonts As Font
    Private printFontks As Font
    Private printFontk As Font
    Private printFontkf As Font
    Private printFontf As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Dim podpis As Image
    Dim seite As Integer = 0
    Public routelange As Integer
    Public aaa As String
    Public bbb As String
    Public zr As Integer
    Public zeilentext As String
    Public zeilenanf As Single
    Public x As New Leerstelle
    Dim vona As String
    Dim bisb As String
    Public speicherbild As String
    Dim rNbr As Integer
    Public boot As String
    Public sign As String
    Private route As String
    Public Sub PrintSmBestaetugungOSV(ByVal tIn As DataTable)
        speicherplatz = GetSetting("schein", "Pfad", "T", " ")
        dt = tIn
        boot = GetSetting("Boot", "Pfad", "T", " ")
        If Seemeilenbestaetigung.CheckBox23.Checked Then
            sign = GetSetting("sign", "Pfad", "T", " ")
            If sign > " " Then
                podpis = Image.FromFile(Trim$(sign))
            End If
        Else
        End If
        speicherbild = GetSetting("ToernLogo", "Pfad", "T", " ")
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        printFont = New Font("Arial", 10)
        Dim pdO As New PrintDocument()
        AddHandler pdO.PrintPage, AddressOf Me.pdO_PrintPage
        pdO.Print()
    End Sub
    ' The PrintPage event is raised for each page to be printed.
    Private Sub pdO_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 0
        Dim rNbr As Integer
        Dim quelle As String
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 20
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 200
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        route = Seemeilenbestaetigung.route
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        printFont = New Font("Arial", 24, FontStyle.Bold)
        ev.Graphics.DrawString("Seemeilenbestätigung", printFont, Brushes.Black, xPos(2) + 50, yPos, New StringFormat())
        row = dt.Rows(0)
        '    ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(3), topMargin - 50, New StringFormat())
        printFont = New Font("Arial", 12)
        printFontk = New Font("Arial", 9)
        ' Print each line of the file.
        '      ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)


        rNbr = lastRow
        row = dt.Rows(rNbr)
        ' Feld1 ...4    Skipper, von, bis, Boot
        zeile += 4


        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Herr / Frau   " + row(0), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Geburtsort und Geburtsdatum:  " + row(1), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Adresse:   " + row(3), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", "hat in der Zeit von         " + row(4)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", "bis      " + row(5)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", "an Bord der Segeljacht:  " + row(6)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", "Type:  " + row(7)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", "LüA: " + row(8)), printFont, Brushes.Black, xPos(5) + 35, yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("an einem Segeltörn teilgenommen.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            aaa = ""
            bbb = row(9)
            If bbb.Contains("R") Then aaa = "Rudergänger"
            If bbb.Contains("W") Then aaa += " Wachführer"
            If bbb.Contains("N") Then aaa += " Navigator"
 
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", "Funktionen an Bord: " + aaa), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ' -----------------------------------------------
            If route > " " Then
                quelle = "Fahrtgebiet und Fahrtroute:   " & route
                zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0), ev, linesPerPage)
            End If
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "", "Seemeilen: gesamt       " + row(11)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(50)), "", "sm, davon unter Segel:    " + row(50) + "    sm"), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Seemeilenbestaetigung.nachta), "", "Nachtansteuerung:  " + Seemeilenbestaetigung.nachta), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Seemeilenbestaetigung.nachtf), "", "Nachtfahrten:   " + Seemeilenbestaetigung.nachtf), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(49)), "", "Fahrtstrecke außerhalb FB 2: " + row(49) + "   sm,           Fahrtstrecke außerhalb FB 3:  " + row(16) + "    sm"), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            '         ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(15)), "", "sm, Fahrtstrecke außerhalb FB 3" + row(15) + "    sm"), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(17)), "", "Name des Schiffsführers: " + row(17)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(18)), "", "Anschrift des Schiffsführers: " + row(18)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            aaa = Seemeilenbestaetigung.lizenz
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", "Befähigungsausweis des Schiffsführers, Nummer, Fahrtbereich: " + aaa), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            aaa = Seemeilenbestaetigung.lizDatum
            bbb = Seemeilenbestaetigung.lizVerband
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", "ausgestellt am: " + aaa + "                               ausgestellt von (Verband): " + bbb), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 4
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            zeile += 0
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("________________________________ ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(" _____________________________________", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("      Datum, Unterschrift des Schiffsführers ", printFontk, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("         Datum, Unterschrift des Inhabers dieser Bestätigung", printFontk, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 4
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(" Mit ihrer Unterschrift bestätigen beide Unterzeichner an Eides statt die Richtigkeit der angeführten", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(" Angaben sowie die Einhaltung der Bestimmungen der PRO 2009, insbesondere Punkt 2.2.2.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 62
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        lastRow = rNbr
        If Not (row Is Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If

    End Sub

    Public Sub PrintSmBestaetugungMSVO(ByVal tIn As DataTable)
        '     ---------------------------------------------------------------- MSVÖ ---------------------------------------------
        speicherplatz = GetSetting("schein", "Pfad", "T")
        dt = tIn
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        boot = GetSetting("Boot", "Pfad", "T")
        If Seemeilenbestaetigung.CheckBox23.Checked Then
            sign = GetSetting("sign", "Pfad", "T", " ")
            If sign > " " Then
                podpis = Image.FromFile(Trim$(sign))
            End If
        Else
        End If
        speicherbild = GetSetting("ToernLogo", "Pfad", "T", " ")
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        printFont = New Font("Arial", 10)
        Dim pdM As New PrintDocument()
        AddHandler pdM.PrintPage, AddressOf Me.pdM_PrintPage
        pdM.Print()
    End Sub
    Private Sub pdM_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 0
        Dim rNbr As Integer
         Dim geburtsdatum As String
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 20
        xPos(2) = xPos(1) + 150
        xPos(3) = xPos(2) + 250
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        route = Seemeilenbestaetigung.route
        vona = ""
        bisb = ""
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 100, topMargin + 50))
        End If
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Seemeilenbestätigung", printFont, Brushes.Black, xPos(1) + 130, 20, New StringFormat())
        row = dt.Rows(0)
        '    ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(3), topMargin - 50, New StringFormat())
        printFont = New Font("Arial", 12)
        printFontf = New Font("Arial", 12, FontStyle.Bold)
        printFontk = New Font("Arial", 9)
        printFonts = New Font("Wingdings", 18)
        printFontks = New Font("Wingdings", 14, FontStyle.Bold)
        ev.Graphics.DrawString("gemäß §20 Abs. 2 Z 1 und §26 Abs. 1 der Jachtverordnung - Jacht VO", printFontk, Brushes.Black, xPos(1) + 60, 60, New StringFormat())
        ' Print each line of the file.

        rNbr = lastRow
        row = dt.Rows(rNbr)
        ' Feld1 ...4    Skipper, von, bis, Boot
        zeile += 1


        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            If row(1) > "" Then
                geburtsdatum = row(1)
                If geburtsdatum.Length > 9 Then
                    geburtsdatum = geburtsdatum.Substring(0, 10)
                End If
            Else
                geburtsdatum = " "
            End If

            '---------------------------------------  Bewerber -------------------------------------
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Bewerber/in:   ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Herr / Frau:  " + row(0), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("geb. am:  " + geburtsdatum, printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Geb. Ort:     " + row(2), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Tel.Nr.:    " + row(13), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("PLZ, Ort, Strasse, Nr.: " + row(3), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Funktion(en) an Bord:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(2) + 5, yPos - 5, New StringFormat())
            ev.Graphics.DrawString("Rudergänger/in", printFont, Brushes.Black, xPos(2) + 30, yPos, New StringFormat())
            ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(3) + 5, yPos - 5, New StringFormat())
            ev.Graphics.DrawString("Wachführer/in", printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            aaa = row(9)
            If aaa.Contains("R") Then
                ev.Graphics.DrawString("ü", printFontks, Brushes.Black, xPos(2) + 8, yPos, New StringFormat())
            End If
            If aaa.Contains("W") Then
                ev.Graphics.DrawString("ü", printFontks, Brushes.Black, xPos(3) + 8, yPos, New StringFormat())
            End If
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(2) + 5, yPos, New StringFormat())
            ev.Graphics.DrawString("Navigator/in", printFont, Brushes.Black, xPos(2) + 30, yPos, New StringFormat())
            ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
            ev.Graphics.DrawString("______________", printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            If aaa.Contains("N") Then
                ev.Graphics.DrawString("ü", printFontks, Brushes.Black, xPos(2) + 8, yPos + 3, New StringFormat())
            End If
            aaa = ""

            ' -----------------------      Schiffsführer ------------------------------------------
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Schiffsführer/in" + aaa, printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(17)), "", "Herr / Frau    " + row(17)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("geb. am:  " + geburtsdatum, printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(20)), "", "Geb. Ort:     " + row(20)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Tel.Nr.:    " + row(13), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(18)), "", "Wohnsitz:     " + row(18)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

            ' -----------------------------  Jacht  ----------------------------------------------
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Jacht         ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Motorjacht" + aaa, printFont, Brushes.Black, xPos(3) + 30, yPos + 3, New StringFormat())
            ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(3), yPos, New StringFormat())
            If row(23) = "M" Then
                ev.Graphics.DrawString("ü", printFontks, Brushes.Black, xPos(3) + 5, yPos + 3, New StringFormat())
            End If
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", "Name / Kennzeichen:  " + row(6)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Segeljacht" + aaa, printFont, Brushes.Black, xPos(3) + 30, yPos + 3, New StringFormat())
            ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(3), yPos, New StringFormat())
            If row(23) = "S" Then
                ev.Graphics.DrawString("ü", printFontks, Brushes.Black, xPos(3) + 5, yPos + 3, New StringFormat())
            End If
            zeile += 1
            Dim breite As String
            Dim tiefgang As String
            aaa = InStr(1, row(12).ToString, "/")
            breite = row(12).ToString.Substring(0, aaa - 1)
            LetzterString.letztes(row(12), "/", tiefgang)
            '    tiefgang = row(12).ToString.Substring(5, 4)
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", "Type: " + row(7)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", "Länge: " + row(8)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(breite), "", "Breite: " + breite), printFont, Brushes.Black, xPos(2) + 150, yPos, New StringFormat())
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(tiefgang), "", "Tiefgang: " + tiefgang), printFont, Brushes.Black, xPos(3) + 50, yPos, New StringFormat())
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Törn", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", "Revier:   " + row(15)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", "Zeitraum Datum: " + row(4)), printFont, Brushes.Black, xPos(2) + 50, yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", "bis " + row(5)), printFont, Brushes.Black, xPos(3) + 20, yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            LetzterString.letztes(row(10), "/", aaa)
            LetzterString.letztes(aaa, "/", aaa)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", "Ausgangsort: " + aaa), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            aaa = Seemeilenbestaetigung.route.Substring(0, 15)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", "Fahrtroute: " + aaa), printFont, Brushes.Black, xPos(2) + 50, yPos, New StringFormat())
            LetzterString.letztes(row(48), "/", aaa)
            LetzterString.letztes(aaa, "/", aaa)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", "Zielort: " + aaa), printFont, Brushes.Black, xPos(3) + 40, yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "", "zurückgelegte Seemeilen gesamt:  " + row(11)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Nachtansteuerungen:  ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

            ' ------------------------------------- Nachtansteuerungen ---------------------------------------------------------------------

            '                    ev,  x,  y,  Hoehe,  Breite,  Anzahl_Zeilen,  Anzahl_Spalten
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Tabellengitter.gitter(ev, xPos(0), yPos, 1.5, 210, 6, 3)
            yPos = topMargin + (zeile + 0.3) * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Hafen  ", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString("Datum   ", printFont, Brushes.Black, xPos(2) + 60, yPos, New StringFormat())
            ev.Graphics.DrawString("Uhrzeit   ", printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            zeile += 1
            If row(42) > "-----" Then
                yPos = topMargin + (zeile + 0.8) * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(42)), "", row(42)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                aaa = row(43).ToString.Substring(0, 10)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(2) + 60, yPos, New StringFormat())
                LetzterString.letztes(row(43), " ", aaa)
                '             aaa = row(43).ToString.Substring(11, 5)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            End If
            zeile += 1
            If row(44) > "----- " Then
                yPos = topMargin + (zeile + 1.3) * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(44)), "", row(44)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                aaa = row(45).ToString.Substring(0, 10)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(2) + 60, yPos, New StringFormat())
                LetzterString.letztes(row(45), " ", aaa)
                '      aaa = row(45).ToString.Substring(11, 5)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            End If
            zeile += 1
            If row(46) > "----- " Then
                yPos = topMargin + (zeile + 1.8) * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(46)), "", row(46)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                aaa = row(47).ToString.Substring(0, 10)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(2) + 60, yPos, New StringFormat())
                LetzterString.letztes(row(47), " ", aaa)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            End If

            '--------------------------------------------------------- Nachtfahrten ----------------------------------
            zeile += 7
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Nachtfahrten: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Tabellengitter.gitter(ev, xPos(0), yPos, 1.5, 260, 6, 1)
            Tabellengitter.gitter(ev, 360, yPos, 1.5, 90, 6, 2)
            Tabellengitter.gitter(ev, 540, yPos, 1.5, 190, 6, 1)
            yPos = topMargin + (zeile + 0.3) * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Strecke von - bis", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString("Seemeilen   ", printFont, Brushes.Black, xPos(2) + 90, yPos, New StringFormat())
            ev.Graphics.DrawString("Datum   ", printFont, Brushes.Black, xPos(3) - 55, yPos, New StringFormat())
            ev.Graphics.DrawString("Uhrzeit (Beginn / Ende)   ", printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            zeile += 1
            Dim datende As String
            If row(24) > "----- " Then
                LetzterString.letztes(row(26), " / ", aaa)
                datende = aaa.Substring(2, 10)
                Dim dat_dif As Long = DateDiff("d", row(26).ToString.Substring(0, 10), datende)
                Select Case dat_dif
                    Case 1
                        yPos = topMargin + (zeile + 0.8) * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(24)), "", row(24)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(25)), "", row(25)), printFont, Brushes.Black, xPos(2) + 95, yPos, New StringFormat())
                        aaa = row(26).ToString.Substring(0, 10)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                        LetzterString.letztes(row(26), " / ", aaa)
                        LetzterString.letztes(aaa.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", " / " + aaa), printFont, Brushes.Black, xPos(3) + 80, yPos, New StringFormat())
                        LetzterString.letztes(row(26).ToString.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
                    Case Is > 1
                        yPos = topMargin + (zeile + 0.8) * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(24)), "", row(24)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(25)), "", row(25)), printFont, Brushes.Black, xPos(2) + 95, yPos, New StringFormat())
                        aaa = row(26).ToString.Substring(0, 10)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                        LetzterString.letztes(row(26).ToString.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
                        '  -------------------- neue Zeile ----------------------
                        zeile += 1
                        yPos = topMargin + (zeile + 1.3) * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(datende), "", datende), printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                        LetzterString.letztes(row(26), " / ", aaa)
                        LetzterString.letztes(aaa.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", " / " + aaa), printFont, Brushes.Black, xPos(3) + 80, yPos, New StringFormat())
                    Case Else
                End Select
            End If


            zeile += 1
            If row(27) > "----- " Then
                LetzterString.letztes(row(29), " / ", aaa)
                datende = aaa.Substring(2, 10)
                Dim dat_dif As Long = DateDiff("d", row(29).ToString.Substring(0, 10), datende)
                Select Case dat_dif
                    Case 1
                        yPos = topMargin + (zeile + 1.3) * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(27)), "", row(27)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(28)), "", row(28)), printFont, Brushes.Black, xPos(2) + 95, yPos, New StringFormat())
                        aaa = row(29).ToString.Substring(0, 10)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                        LetzterString.letztes(row(29), " / ", aaa)
                        LetzterString.letztes(aaa.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", " / " + aaa), printFont, Brushes.Black, xPos(3) + 80, yPos, New StringFormat())
                        LetzterString.letztes(row(29).ToString.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
                    Case Is > 1
                        yPos = topMargin + (zeile + 1.3) * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(27)), "", row(27)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(28)), "", row(28)), printFont, Brushes.Black, xPos(2) + 95, yPos, New StringFormat())
                        aaa = row(29).ToString.Substring(0, 10)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                        LetzterString.letztes(row(29).ToString.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", aaa), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
                        '  -------------------- neue Zeile ----------------------
                        zeile += 1
                        yPos = topMargin + (zeile + 1.8) * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(datende), "", datende), printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                        LetzterString.letztes(row(29), " / ", aaa)
                        LetzterString.letztes(aaa.Substring(2, 16), " ", aaa)
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aaa), "", " / " + aaa), printFont, Brushes.Black, xPos(3) + 80, yPos, New StringFormat())
                    Case Else
                End Select
            End If


            ' -----------------------------------------------
            zeile += 10
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            If sign > " " And Seemeilenbestaetigung.CheckBox23.Checked = True Then
                '                zeile += 10
                '*               yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                Dim bildb As Single
                Dim bildh As Single
                Dim faktor As Single
                bildb = podpis.Width
                bildh = podpis.Height
                If bildh > 600 Then
                    faktor = bildb / 200
                    ev.Graphics.DrawImage(podpis, New Rectangle(xPos(3) + 20, yPos - 50, bildb / faktor, bildh / faktor))
                Else
                    ev.Graphics.DrawImage(podpis, New Point(xPos(3) + 20, yPos - 50))
                End If

             End If
             ev.Graphics.DrawString("_______________  _________________________  _________________________", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("      Ort, Datum ", printFontk, Brushes.Black, xPos(0) + 30, yPos, New StringFormat())
            If Seemeilenbestaetigung.TextBox16.Text > " " Then
                ev.Graphics.DrawString(Seemeilenbestaetigung.TextBox16.Text + ", " + Today, printFont, Brushes.Black, xPos(0), yPos - 30, New StringFormat())
            End If
            ev.Graphics.DrawString("   Unterschrift Bewerber/in", printFontk, Brushes.Black, xPos(2), yPos, New StringFormat())


            ev.Graphics.DrawString("Unterschrift Schiffsführer/in", printFontk, Brushes.Black, xPos(4) - 50, yPos, New StringFormat())

            zeile += 62
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        lastRow = rNbr
        If Not (row Is Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If

    End Sub

    Public Sub PrintSmBestaetugungJachtPro(ByVal tIn As DataTable)
         speicherbild = GetSetting("ToernLogo", "Pfad", "T", " ")
        If Seemeilenbestaetigung.CheckBox23.Checked Then
            sign = GetSetting("sign", "Pfad", "T", " ")
            If sign > " " Then
                podpis = Image.FromFile(Trim$(sign))
            End If
        Else
        End If
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pdH As New PrintDocument()
        AddHandler pdH.PrintPage, AddressOf Me.pdH_PrintPage
        pdH.Print()
    End Sub
    Private Sub pdH_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 0
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 20
        xPos(1) = leftMargin + 235
        xPos(2) = leftMargin + 255
        xPos(3) = leftMargin + 315
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        zeile += 3
         printFont = New Font("Arial", 12)
        printFonts = New Font("Wingdings", 12, FontStyle.Bold)
        printFontk = New Font("Arial", 9)
        printFontf = New Font("Arial", 12, FontStyle.Bold)
        printFontkf = New Font("Arial", 9, FontStyle.Bold)


        '       row = dt.Rows(0)
        '      rNbr = lastRow
        '     row = dt.Rows(rNbr)
        '        While zeile < (linesPerPage - 1)
        row = dt.Rows(rNbr)
        Select Case seite
            Case 0
                '                If row Is Nothing Then
                'Exit While
                '               End If
                ev.Graphics.DrawString("Seemeilenbestätigung", printFontf, Brushes.Black, 240, topMargin - 50, New StringFormat())
                ev.Graphics.DrawString("(Nachweis der seemänischen Praxis)", printFontk, Brushes.Black, 420, topMargin - 45, New StringFormat())
                ev.Graphics.DrawString("gemäß § 20 Abs. 2 Z 1 und § 26 Abs. 1 der Jachtverordnung - JachVO ", printFontk, Brushes.Black, 240, topMargin - 30, New StringFormat())
              
                zeile = 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Bewerberin / Bewerber", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile = 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '                                                                    Tabellengitter           ev,  x,  y,  Hoehe,  Breite,  Anzahl_Zeilen,  Anzahl_Spalten
                ' ------------------------------------------------  Bewerber -------------------------------------------------------------------------------------
                Tabellengitter.gitter(ev, xPos(0), yPos, 2, 330, 2, 2)
                ev.Graphics.DrawString("Vorname, Name", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("Geburtsdatum", printFontk, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("Geburtsort", printFontk, Brushes.Black, xPos(3), yPos + 20, New StringFormat())
                ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(0) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(3) + 90, yPos, New StringFormat())
                ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(3) + 90, yPos + 15, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Hauptwohnsitz", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(0) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString("Tel.", printFontk, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("E-Mail", printFontk, Brushes.Black, xPos(3), yPos + 18, New StringFormat())
                ev.Graphics.DrawString(row(13), printFont, Brushes.Black, xPos(3) + 90, yPos, New StringFormat())
                ev.Graphics.DrawString(row(14), printFont, Brushes.Black, xPos(3) + 90, yPos + 15, New StringFormat())
                zeile += 3
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Funktion(en) an Bord", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                Tabellengitter.gitter(ev, xPos(0), yPos, 2, 660, 1, 1)
                ev.Graphics.DrawString("Rudergängerin/Rudergänger", printFontk, Brushes.Black, xPos(0) + 30, yPos, New StringFormat())
                ev.Graphics.DrawString("Wachführerin/Wachführer", printFontk, Brushes.Black, xPos(0) + 280, yPos, New StringFormat())
                ev.Graphics.DrawString("Navigatorin/Navigator", printFontk, Brushes.Black, xPos(0) + 480, yPos, New StringFormat())
                ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0) + 250, yPos, New StringFormat())
                ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0) + 450, yPos, New StringFormat())
                aaa = row(9)
                If aaa.Contains("R") Then
                    ev.Graphics.DrawString("ü", printFonts, Brushes.Black, xPos(0) + 7, yPos, New StringFormat())
                End If
                If aaa.Contains("W") Then
                    ev.Graphics.DrawString("ü", printFonts, Brushes.Black, xPos(0) + 252, yPos, New StringFormat())
                End If
                If aaa.Contains("N") Then
                    ev.Graphics.DrawString("ü", printFonts, Brushes.Black, xPos(0) + 452, yPos, New StringFormat())
                End If
                ev.Graphics.DrawString("______________________", printFontk, Brushes.Black, xPos(0) + 30, yPos + 18, New StringFormat())
                ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0) + 5, yPos + 18, New StringFormat())

                ' -------------------------------------------------------------------------Schiffsführer ----------------------------------------
                zeile += 3
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Schiffsführerin / Schiffsführer", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                Tabellengitter.gitter(ev, xPos(0), yPos, 2, 330, 2, 2)
                ev.Graphics.DrawString("Vorname, Name", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("Geburtsdatum", printFontk, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("Geburtsort", printFontk, Brushes.Black, xPos(3) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString(row(17), printFont, Brushes.Black, xPos(0) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString(row(19), printFont, Brushes.Black, xPos(3) + 100, yPos, New StringFormat())
                ev.Graphics.DrawString(row(20), printFont, Brushes.Black, xPos(3) + 100, yPos + 15, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                 ev.Graphics.DrawString("Hauptwohnsitz", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(18), printFont, Brushes.Black, xPos(0) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString("Tel.", printFontk, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("E-Mail", printFontk, Brushes.Black, xPos(3) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString(row(21), printFont, Brushes.Black, xPos(3) + 100, yPos, New StringFormat())
                ev.Graphics.DrawString(row(22), printFont, Brushes.Black, xPos(3) + 100, yPos + 15, New StringFormat())
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

                '------------------------------------------------------------------------------ Jacht ------------------------------------
                zeile += 3
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Jacht", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                Tabellengitter.gitter(ev, xPos(0), yPos, 2, 330, 2, 2)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Name", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(6), printFont, Brushes.Black, xPos(0) + 5, yPos + 20, New StringFormat())
                aaa = row(23)
                ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(3) + 5, yPos + 20, New StringFormat())
                ev.Graphics.DrawString("Motorjacht", printFontk, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
                ev.Graphics.DrawString("Segeljacht", printFontk, Brushes.Black, xPos(3) + 30, yPos + 20, New StringFormat())
                If aaa.Contains("M") Then
                    ev.Graphics.DrawString("ü", printFonts, Brushes.Black, xPos(3) + 7, yPos, New StringFormat())
                End If
                If aaa.Contains("S") Then
                    ev.Graphics.DrawString("ü", printFonts, Brushes.Black, xPos(3) + 7, yPos + 20, New StringFormat())
                End If
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                 ev.Graphics.DrawString("Typenbezeichnung", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(7), printFont, Brushes.Black, xPos(0) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString("Länge / Breite / Tiefgang", printFontk, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                aaa = InStr(1, row(8), "/")
                If aaa = "0" Then
                    ev.Graphics.DrawString(row(8) + " " + row(12), printFont, Brushes.Black, xPos(3) + 5, yPos + 15, New StringFormat())
                Else
                    ev.Graphics.DrawString(row(8).ToString.Substring(0, aaa) + row(12), printFont, Brushes.Black, xPos(3) + 5, yPos + 15, New StringFormat())
                End If

                ' ----------------------------------------------------------------- Törn -----------------------------------------
                zeile += 3

                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Törn", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                Tabellengitter.gitter(ev, xPos(0), yPos, 2, 330, 1, 2)
                ev.Graphics.DrawString("Revier", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("Datum", printFontk, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(15), printFont, Brushes.Black, xPos(0) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString(row(4) + " - " + row(5), printFont, Brushes.Black, xPos(3) + 5, yPos + 15, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                Tabellengitter.gitter(ev, xPos(0), yPos, 12, 330, 1, 2)
                ev.Graphics.DrawString("Ausgangsort", printFontk, Brushes.Black, xPos(0) + 5, yPos + 5, New StringFormat())
                ev.Graphics.DrawString(row(10), printFont, Brushes.Black, xPos(0) + 80, yPos + 3, New StringFormat())
                ev.Graphics.DrawString("zurückgelegte Seemeilen gesamt", printFontk, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(11), printFont, Brushes.Black, xPos(3) + 5, yPos + 15, New StringFormat())
                ev.Graphics.DrawString("Fahrtroute", printFontk, Brushes.Black, xPos(0) + 5, yPos + 25, New StringFormat())
                zeile += 1
                Dim zeilee As Integer = zeile
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                aaa = Seemeilenbestaetigung.route
                LangXText.LangXtextDrucken(aaa, zeile, yPos, printFont, xPos(0) + 5, ev, 40)
                zeile = zeilee + 10
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Zielort", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(48), printFont, Brushes.Black, xPos(0) + 80, yPos - 5, New StringFormat())

            Case 1
                zeile -= 4
                yPos = topMargin + (zeile + 0.5) * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Nachtansteuerungen", printFontk, Brushes.Black, xPos(0), yPos + 10, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '                                                                    Tabellengitter           ev,  x,  y,  Hoehe,  Breite,  Anzahl_Zeilen,  Anzahl_Spalten
                Tabellengitter.gitter(ev, xPos(0), yPos, 2, 330, 6, 2)
                ev.Graphics.DrawString("Hafen", printFontk, Brushes.Black, xPos(0) + 5, yPos + 10, New StringFormat())
                ev.Graphics.DrawString("Datum und Uhrzeit", printFontk, Brushes.Black, xPos(3) + 5, yPos + 10, New StringFormat())
                zeile += 2
                yPos = topMargin + (zeile + 0.5) * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(row(42), printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString(row(43), printFont, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                If row(44) > " " Then
                    zeile += 2
                    yPos = topMargin + (zeile + 0.5) * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(row(44), printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                    ev.Graphics.DrawString(row(45), printFont, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                End If
                If row(46) > " " Then
                    zeile += 2
                    yPos = topMargin + (zeile + 0.5) * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(row(46), printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                    ev.Graphics.DrawString(row(47), printFont, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                End If

                zeile += 9
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Nachtfahrten", printFontk, Brushes.Black, xPos(0), yPos + 10, New StringFormat())
                zeile += 2
                yPos = topMargin + (zeile - 0.5) * printFont.GetHeight(ev.Graphics)
                Tabellengitter.gitter(ev, xPos(0), yPos, 2, 330, 6, 2)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                  ev.Graphics.DrawString("Strecke von - bis, Seemeilen", printFontk, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                ev.Graphics.DrawString("Datum und Uhrzeit (Beginn / Ende)", printFontk, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                If row(24) <> "-----" Then
                    ev.Graphics.DrawString(row(24), printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                    ev.Graphics.DrawString(row(25), printFont, Brushes.Black, xPos(1) + 15, yPos, New StringFormat())
                Else
                    ev.Graphics.DrawString(row(24) + " " + row(25), printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                End If
                ev.Graphics.DrawString(row(26), printFont, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                If row(27) <> "-----" Then
                    ev.Graphics.DrawString(row(27), printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                    ev.Graphics.DrawString(row(28), printFont, Brushes.Black, xPos(1) + 15, yPos, New StringFormat())
                Else
                    ev.Graphics.DrawString(row(27) + "  " + row(28), printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                End If
                ev.Graphics.DrawString(row(29), printFont, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())

 

                If sign > " " And Seemeilenbestaetigung.CheckBox23.Checked = True Then
                    zeile += 10
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    Dim bildb As Single
                    Dim bildh As Single
                    Dim faktor As Single
                    bildb = podpis.Width
                    bildh = podpis.Height
                    If bildb > 580 Then
                        faktor = bildb / 250
                        ev.Graphics.DrawImage(podpis, New Rectangle(xPos(3) + 40, yPos - 10, bildb / faktor, bildh / faktor))
                    Else
                        ev.Graphics.DrawImage(podpis, New Point(xPos(3) + 60, yPos - 10))
                    End If

                    zeile -= 10
                End If

   

                zeile += 10
                '                                                                    Tabellengitter           ev,  x,  y,  Hoehe,  Breite,  Anzahl_Zeilen,  Anzahl_Spalten
                yPos = topMargin + (zeile + 0.3) * printFont.GetHeight(ev.Graphics)
                Tabellengitter.gitter(ev, xPos(0), yPos, 10, 330, 1, 1)
                Tabellengitter.gitter(ev, 410, yPos, 5, 330, 2, 1)
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Ort, Datum", printFontk, Brushes.Black, xPos(0) + 5, yPos - 10, New StringFormat())
                If Seemeilenbestaetigung.TextBox16.Text > " " Then
                    ev.Graphics.DrawString(Seemeilenbestaetigung.TextBox16.Text + ", " + Today, printFont, Brushes.Black, xPos(0) + 5, yPos + 40, New StringFormat())
                End If

                ev.Graphics.DrawString("Unterschrift der Schiffsführerin / des Schiffsführers", printFontk, Brushes.Black, xPos(3) + 5, yPos - 10, New StringFormat())
                '           ev.Graphics.DrawString("Schiffsführers", printFontk, Brushes.Black, xPos(3) + 5, yPos + 10, New StringFormat())

                zeile += 5
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Unterschrift der Bewerberin / des Bewerbers", printFontk, Brushes.Black, xPos(3) + 5, yPos - 10, New StringFormat())

                '              zeile += 4
                '              yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawString("Beilagen: Logbuch, vom Schiffsführer unterfertigte auszugsweise Abschrift des Logbuchs oder sonstige", printFontk, Brushes.Black, xPos(0) + 5, yPos - 10, New StringFormat())
                '              zeile += 1
                '              yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawString("logbuchähnliche Aufzeichnungen.", printFontk, Brushes.Black, xPos(0) + 5, yPos - 10, New StringFormat())

        End Select
        seite += 1
         If seite = 1 Then
        Else
            rNbr += 1
            seite = 0
        End If
        If rNbr >= dt.Rows.Count Then
            row = Nothing
        End If
        If rNbr >= dt.Rows.Count Then
            ev.HasMorePages = False
        Else
            ev.HasMorePages = True
        End If
    End Sub
    Private Sub VonBis(ByVal row, ByRef von, ByRef bis)
        Dim i As Integer = 0
        For i = 0 To Len(row) - 2
            aaa = row.ToString.Substring(i, 1)
            If row.ToString.Substring(i, 1) = " - " Then
                von = row.ToString.Substring(0, i - 1)
                bis = row.ToString.Substring(i + 1, Len(row) - i - 1)
                Exit For
            End If
            i += 1
        Next
    End Sub
End Class
