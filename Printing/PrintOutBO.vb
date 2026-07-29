Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutBO
    '                                                                                           Drucken Boot
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim xPos(7) As Single
    Public speicherbild As String
    Public Bootpfad As String
    Dim zeile As Integer = 0
    Public zs As Integer
    Public zr As Integer
    Public zeilenanf As Single
    Public x As New Leerstelle
    Public routelange As Integer
    Public aaa As String
    Public zeilentext As String
    Private printFont As Font
    Private printFontf As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Private toerns As New ListBox
    Dim logo As Image
    Dim ij As Integer
    Dim leftMargin As Single
    Dim topMargin As Single
    Public Sub PrintBootBlatt(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        Bootpfad = GetSetting("Boot", "Pfad", "T")
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
        drucken(ev, row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12), row(13), row(14), row(15), row(16), row(17), row(18), row(19), row(20), row(21), row(22), row(23), row(24), row(25), row(26), row(27), row(28), row(29), row(30), row(31), row(32), row(33), row(34), row(35), row(36), row(37), row(38), row(39), row(40), row(41), row(42), row(43))
    End Sub
    ' The PrintPage event is raised for each page to be printed.
    Private Sub drucken(ByVal ev, ByVal Bootname, ByVal Marke, ByVal Schiffstyp, ByVal Kielart, ByVal Schiffsnummer, ByVal Durchfahrtshoehe, ByVal Länge, ByVal Breite, ByVal Verdrängung, ByVal Tiefgang, ByVal Großsegel, ByVal Vorsegel, ByVal Wassertank, ByVal Dieseltank, ByVal Kabinenanzahl, ByVal Kojenanzahl, _
                        ByVal Nassraeumeanzahl, ByVal Motor, ByVal Kaution, ByVal Charterfirma, ByVal Bemerkung, ByVal MMSI, ByVal Grosssegelart, ByVal Baujahr, ByVal Marinaort, ByVal Ansprechsperson, ByVal Mobile, ByVal Radar, ByVal Bugstrahlruder, ByVal Clubnachlas, ByVal Heizung, ByVal Klimaanlage, ByVal marina, _
                        ByVal Reinigung, ByVal Bettzeug, ByVal Aussenborder, ByVal Gas, ByVal Spinaker, ByVal Marinekosten, ByVal SonstigeKosten, ByVal Inverter, ByVal WiFi, ByVal Permit, ByVal Verbrauch)
        Dim linesPerPage As Single = 0
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
        ev.Graphics.DrawString(Bootname, printFont, Brushes.Black, ev.MarginBounds.Left + 250, yPos, New StringFormat())
        printFont = New Font("Arial", 10)
        printFontf = New Font("Arial", 10, FontStyle.Bold)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 6
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Baujahr:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Baujahr), "", Baujahr), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Marke: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Marke), "", Marke), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Schiffstyp:", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Schiffstyp), "", Schiffstyp), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Länge [m/Fuss]:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Länge), "", Länge), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Breite [m]: ", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Breite), "", Breite), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Tiefgang [m]: ", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(Tiefgang), "", Tiefgang), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        ij = 0
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        wert(ev, "Masthöhe [m]:", Durchfahrtshoehe)
        wert(ev, "Kielart:", Kielart)
        wert(ev, "Wassertank [L]:", Wassertank)
        wert(ev, "Verdrängung [t]:", Verdrängung)
        zeile += 2
        ij = 0
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        wert(ev, "Grosssegelart: ", Grosssegelart)
        wert(ev, "Grosssegel [m²]:", Großsegel)
        wert(ev, "Vorsegel [m²]:", Vorsegel)
        wert(ev, "Kabinen:", Kabinenanzahl)
        wert(ev, "Kojen:", Kojenanzahl)
        wert(ev, "Nassräume:", Nassraeumeanzahl)
        wert(ev, "Krafstofftank [L]:", Dieseltank)
        wert(ev, "Motor [PS]: ", Motor)
        wert(ev, "Verbrauch L/Sm: ", Verbrauch)
        zeile += 2
        ij = 0
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        wert(ev, "Charterfirma: ", Charterfirma)
        wert(ev, "Marinaort: ", Marinaort)
        wert(ev, "Marina: ", marina)
        wert(ev, "Ansprechsperson: ", Ansprechsperson)
        wert(ev, "Mobile: ", Mobile)
        wert(ev, "Kaution [€]: ", Kaution)
        wert(ev, "Call sign:", Schiffsnummer)
        wert(ev, "MMSI: ", MMSI)
        zeile += 2
        ij = 0
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        wert0(ev, "Reinigung [€]:", Reinigung)
        wert0(ev, "Bettzeug [€]:", Bettzeug)
        wert0(ev, "Aussenborder [€]:", Aussenborder)
        wert0(ev, "Gas [€]:", Gas)
        wert0(ev, "Spinaker [€]:", Spinaker)
        wert0(ev, "Marinekosten [€]:", Marinekosten)
        wert0(ev, "Sonstige Kosten [€]:", SonstigeKosten)
        wert0(ev, "Inverter [€]:", Inverter)
        wert0(ev, "WiFi [€]:", WiFi)
        wert0(ev, "Permit [€]:", Permit)
        zeile += 2
        ij = 0
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ausstattung(ev, "Radar ", Radar)
        ausstattung(ev, "Bugstrahlruder ", Bugstrahlruder)
        ausstattung(ev, "Clubnachlass ", Clubnachlas)
        ausstattung(ev, "Heizung ", Heizung)
        ausstattung(ev, "Klimaanlage ", Klimaanlage)
        zeile += 2
        ij = 0
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        wert(ev, "Bemerkung: ", Bemerkung)

        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        Dim bootfoto As Image
        Dim BildB As Single
        Dim bildh As Single
        Dim faktor As Single
        Dim pixel As GraphicsUnit = GraphicsUnit.Pixel
        Dim bildbb As Single = 350
        Bootname = Bootname.Replace(" ", "")

        If My.Computer.FileSystem.FileExists(Trim$((Bootpfad + Bootname + "1.jpg"))) Then
            bootfoto = Image.FromFile(Trim$((Bootpfad + Bootname + "1.jpg")))
            BildB = bootfoto.Width
            bildh = bootfoto.Height
            faktor = BildB / bildh
            '  bildbb / faktor    muss klein 580 sein in einer Schleife
bild1:
            If bildbb / faktor > 400 Then
                bildbb -= 10
                GoTo bild1
            End If
            ev.Graphics.DrawImage(bootfoto, New Rectangle(xPos(1) + 60, yPos, bildbb, bildbb / faktor))
            '            ev.Graphics.DrawImage(bootfoto, New Rectangle(ev.MarginBounds.Left - 60, yPos, bildbb, bildbb / faktor))
        End If

        bildbb = 350
        If My.Computer.FileSystem.FileExists(Trim$((Bootpfad + Bootname + "2.jpg"))) Then
            bootfoto = Image.FromFile(Trim$((Bootpfad + Bootname + "2.jpg")))
            BildB = bootfoto.Width
            bildh = bootfoto.Height
            faktor = BildB / bildh
bild2:
            If bildbb / faktor > 400 Then
                bildbb -= 10
                GoTo bild2
            End If
            ev.Graphics.DrawImage(bootfoto, New Rectangle(ev.MarginBounds.left + xPos(4) + 60 - bildbb, yPos, bildbb, bildbb / faktor))
        End If
        If Boot.ListBox1.Items.Count > 0 Then
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Törn:", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        End If
        For i = 0 To Boot.ListBox1.Items.Count - 1
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(Boot.ListBox1.Items(i), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        Next
        zeile += 1

    End Sub
    Function ResizeBitmap(ByVal bitmapToResize As Bitmap, ByVal width As Integer, ByVal height As Integer)
2:
        'make a blank bitmap the correct size
3:
        Dim NewBitmap As New Bitmap(width, height)
4:
        'make an instance of graphics that will draw on "NewBitmap"
5:
        Dim BitmpGraphics As Graphics = Graphics.FromImage(NewBitmap)
6:
        'work out the scale factor
7:
        Dim scaleFactorX As Integer = bitmapToResize.Width / width
8:
        Dim scaleFactorY As Integer = bitmapToResize.Height / width
9:
        'resize the graphics
10:
        BitmpGraphics.ScaleTransform(scaleFactorX, scaleFactorY)
11:
        'draw the bitmap to NewBitmap
12:
        BitmpGraphics.DrawImage(bitmapToResize, 0, 0)
13:
        Return NewBitmap
14:
    End Function
    Private Sub wert(ByVal ev, ByVal text, ByVal DB)
        If Not DBNull.Value.Equals(DB) Then
            ev.Graphics.DrawString(text, printFont, Brushes.Black, xPos(ij), yPos, New StringFormat())
            If DB.ToString.Length > 21 Then
                DB = DB.ToString.Substring(0, 21) + "..."
            End If
            ev.Graphics.DrawString(DB, printFont, Brushes.Black, xPos(ij + 1), yPos, New StringFormat())
                ij += 2
                If ij > 4 Then
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ij = 0
                End If
            End If
    End Sub
    Private Sub wert0(ByVal ev, ByVal text, ByVal DB)
        If Not DBNull.Value.Equals(DB) Then
            ev.Graphics.DrawString(text, printFont, Brushes.Black, xPos(ij), yPos, New StringFormat())
            If DB = 0 Then
                ev.Graphics.DrawString("0,00", printFont, Brushes.Black, xPos(ij + 1), yPos, New StringFormat())
            Else
                ev.Graphics.DrawString(DB, printFont, Brushes.Black, xPos(ij + 1), yPos, New StringFormat())
            End If
            ij += 2
            If ij > 4 Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ij = 0
            End If
        End If
    End Sub
    Private Sub ausstattung(ByVal ev, ByVal text, ByVal DB)
        If DB Then
            ev.Graphics.DrawString(text, printFont, Brushes.Black, xPos(ij), yPos, New StringFormat())
            ij += 2
            If ij > 4 Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ij = 0
            End If

        End If

    End Sub

End Class

