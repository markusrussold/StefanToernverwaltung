Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintoutCL
    '                                                                                           Drucken Crewliste
    Public speicherplatz As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Public sign As String
    Dim podpis As Image
    Private lastRow As Integer = 0
    Dim logo As Image
    Dim flughafen As String
    Dim flugnr As String
    Dim flugdate As String
    Public Sub PrintCrewListe(ByVal tIn As DataTable)
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        sign = GetSetting("sign", "Pfad", "T", " ")
        If sign > " " Then
            podpis = Image.FromFile(Trim$(sign))
        End If
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub
    ' The PrintPage event is raised for each page to be printed.
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim yypos As Single
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 0
        Dim rNbr As Integer
        Dim sSize As SizeF
        Dim ij As Integer
        Dim zs As Integer
        Dim zl As Integer
        Dim nationality As String
        Dim geburtsort As String
        Dim geburtsland As String
        Dim von As String
        Dim bis As String
         ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 20
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 78
        xPos(4) = xPos(3) + 92
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("C r e w   L i s t ", printFont, Brushes.Black, xPos(3), topMargin - 50, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        ' Print each line of the file.
        '----------------------------------------------------------- allgemeine Törndaten ------------------------------------------------
        rNbr = lastRow
        row = dt.Rows(rNbr)
        ' Feld1 ...4    Skipper, von, bis, Boot
        zeile += 2
        If row(1) > "" Then
            von = SafeData.FormatDateDe(row(1), "  ")
        Else
            von = "  "
        End If
        If row(6) > "" Then
            bis = SafeData.FormatDateDe(row(6), "  ")
        Else
            bis = "  "
        End If
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        yypos = yPos
        ev.Graphics.DrawString("Skipper:      " + row(0), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Nr. of licence:          " + row(5), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Nr. Radio licence:    " + row(13), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Boatname:  " + row(7), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        '        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Date of travel from:  " + von, printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString("     to: " + bis, printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(8)) Then
            Dim quelle As String
            zeile += 2
            quelle = "Navigation area: " & row(8)
            zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(1), ev, linesPerPage)
        End If
        rNbr += 1

        'zeigt nur wie Texte abgemessen werden, hat sonst keine Funktion
        sSize = ev.Graphics.MeasureString("ABSC", printFont, 1000)
        zeile += 6
        printFont = New Font("Arial", 8)
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

        '---------------------------------------------------------------------------------------  Crew Daten ---------------------------------------------------------------------
        Select Case True
            Case Crewliste.RadioFranzoesisch.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Nom et Prénom", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("Date", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("Lieu de naissance", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("Natiionalité", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("Passport - No", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("Domicile", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Case Crewliste.RadioAdria.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Ime i Prezime", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("Datum rodenja", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("Mjesto rođenja", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("Drzavlijanstvo", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("Broj pasosa", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("Prebivalište", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Case Crewliste.RadioItaliano.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Nome e Cognome", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("Data di nascitá", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("Luogo di nascita", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("Nazionalitá", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("Data di nascitá", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("Residenza", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Case Crewliste.Radioschwedisch.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Namn och Förnamn", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("födelsedatum", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("födelseort", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("medborgerskap", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("Pass nummer", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("uppehålls", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Case Crewliste.RadioSpanisch.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Apellido y nombre de pila", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("Dia di nacimiento", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("Lugar de nacimiento", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("Nacionalidad", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("Pasaporte – No", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("Domicilio ", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Case Crewliste.RadioGriechisch.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("ΕΠΩΝΥΜΟ + ΟΝΟΜΑ", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("ημερ.γέννησης", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("γενέτειρα", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("ιθαγένεια", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("ΑΡ.ΔΙΑΒΑΤΗΡ.", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("κατοικία", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Case Crewliste.RadioTürkisch.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Adi Soyedi", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("Dogum günü", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("Dagum yeri", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("Tabilyet", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("Pasaport numerasi", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("Konut", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Case Crewliste.RadioDeutsch.Checked
                ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Name Vorname", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("Geburtsdatum", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString("Geburtsort", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString("Nationalität", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString("Reisepass Nr.", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                ev.Graphics.DrawString("Wohnort", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        End Select
        ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Surname Prename", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        '       ev.Graphics.DrawString("", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Date of birth", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Place of birth", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        ev.Graphics.DrawString("Nationality", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString("Passport No.", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
        ev.Graphics.DrawString("City of residence", printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile -= 2
        printFont = New Font("Arial", 10)

        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            ij += 1
            '           If ij = 1 Then
            '          End If
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(ij, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            If Len(row(0) + row(1)) < 26 Then
                ev.Graphics.DrawString(row(0) + " " + row(1), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            Else
                ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            End If
            If row(2) > "" Then
                von = SafeData.FormatDateDe(row(2), von)
            End If
            ev.Graphics.DrawString(von, printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            zs = row(3).indexof("/")
            If zs > 0 Then
                zl = row(3).length - zs - 1
                geburtsort = row(3).substring(0, zs)
                geburtsland = row(3).substring(zs + 1, zl)
            Else
                geburtsort = row(3)
                geburtsland = "   "
            End If
            ev.Graphics.DrawString(geburtsort, printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
            nationality = row(9).ToString
            If nationality > "" Then
                If nationality = "Österreich" Or nationality = "Ö" Or nationality = "ö" Then
                    nationality = "Austria"
                End If
            Else
                nationality = "Austria"
            End If
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(nationality), "", nationality), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            If Len(row(0) + row(1)) >= 26 Then
                ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(1) + 5, yPos, New StringFormat())
            End If
            ev.Graphics.DrawString(geburtsland, printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
            If row(7) > "" Then
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", row(7) + " " + row(8)), printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
            Else
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", row(8)), printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
            End If
            flughafen = row(12)
            flugdate = row(11)
            flugnr = row(10)
            zeile += 2
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        If flughafen > " " Then
            zeile += 3
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(flughafen), "", "Arrival/Departure Aiport: " + flughafen), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(flugdate), "", "Date: " + flugdate), printFont, Brushes.Black, xPos(4) + 10, yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(flugnr), "", "Flight No: " + flugnr), printFont, Brushes.Black, xPos(6) + 20, yPos, New StringFormat())
        End If

        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 5
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Date: " + Today, printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        '       ev.Graphics.DrawImage(podpis, New Point(xPos(4), yPos - 60))
        ev.Graphics.DrawString("Signature of Skipper: ", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())


        If sign > " " And Crewliste.CheckBox1.Checked = True Then
            zeile += 5
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            Dim bildb As Single
            Dim bildh As Single
            Dim faktor As Single
            bildb = podpis.Width
            bildh = podpis.Height
            If bildb > 580 Then
                faktor = bildb / 250
                ev.Graphics.DrawImage(podpis, New Rectangle(xPos(5), yPos - 60, bildb / faktor, bildh / faktor))
            Else
                ev.Graphics.DrawImage(podpis, New Point(xPos(5), yPos - 60))
            End If
        End If







    End Sub

End Class

