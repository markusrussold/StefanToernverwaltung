Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintoutCB
    '                                         Crewbesprechung
    Dim linesPerPage As Single = 0
    Private printFont As Font = New Font("Arial", 11)
    Private printFontf As Font = New Font("Arial", 11, FontStyle.Bold)
    Private printFont14f As Font = New Font("Arial", 16, FontStyle.Bold)
    Private printFWFont = New Font("Wingdings", 12, FontStyle.Bold)
    Dim letztezeile As Integer
    Dim rNbr As Integer
    Dim bootname As String
    Public speicherbild As String
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim zeile As Integer = 0
    Dim logo As Image
    Dim bootfoto As Image
    Dim yPos As Single = 0
    Dim xPos(7) As Single
    Public Bootpfad As String
    Public var As Single
    Dim row As DataRow = Nothing
    Dim törndatum As String
    Dim aaa As String
    Dim gruppe As String = " "
    Dim ueberschrift As Boolean = False
    Public Sub PrintCrewbesprechung(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        Bootpfad = GetSetting("Boot", "Pfad", "T")
        dt = tIn
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim rNbr As Integer
        Dim zz As Single = 1.2
        Dim xxx As Integer
        Dim yyy As Integer
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim Seitenkopf As Single = topMargin - 50
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        zeile = 0
        xPos(0) = leftMargin - 20
        xPos(1) = xPos(0) + 120
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 100
        xPos(5) = xPos(4) + 100
        xPos(6) = xPos(5) + 100
        xPos(7) = xPos(6) + 100
        rNbr = lastRow
        row = dt.Rows(rNbr)
        While zeile < (linesPerPage + 7)
            If row Is Nothing Then GoTo druckende
            row = dt.Rows(rNbr)
            If IsDBNull(row(1)) Then
            Else
                Select Case row(1)
                    Case "1"
                        ablauf1(ev, Seitenkopf)
                        rNbr += 1
                        If rNbr >= dt.Rows.Count Then
                            row = Nothing
                            Exit While
                        End If
                        row = dt.Rows(rNbr)
                        GoTo Neueseite
                    Case "2"
                        kojen(ev, Seitenkopf)
                        rNbr += 1
                        GoTo Neueseite
                    Case "3"
                        If ueberschrift Then
                            zeile += 7
                            yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString("Reisedaten:", printFontf, Brushes.Black, xPos(0) - 40, yPos, New StringFormat())
                            zeile += 1
                            yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString("Name", printFontf, Brushes.Black, xPos(0) - 35, yPos, New StringFormat())
                            ev.Graphics.DrawString("Datum    Hin", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                            ev.Graphics.DrawString("Besondere Kenntnisse", printFontf, Brushes.Black, xPos(5) - 15, yPos, New StringFormat())

                            zeile += 1
                            yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
                            '                         ev.Graphics.DrawString("Zeit", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                            ev.Graphics.DrawString("Telefonnr.", printFontf, Brushes.Black, xPos(0) - 35, yPos, New StringFormat())
                            '                ev.Graphics.DrawString("Zeit", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                            ev.Graphics.DrawString("Datum    Zurück", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                            ev.Graphics.DrawString("Bemerkung", printFontf, Brushes.Black, xPos(5) - 15, yPos, New StringFormat())
                            zeile += 1
                            yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos + 5), New Point(ev.MarginBounds.Right + 40, yPos + 5))
                        End If
                        ueberschrift = False
                        zeile += 1
                        yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(0) - 40, yPos, New StringFormat())                                        'name
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(3) - 50, yPos, New StringFormat())          ' Hin
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", row(8)), printFont, Brushes.Black, xPos(5) - 15, yPos, New StringFormat())  ' Kenntnisse
                        row(5) = row(5).replace(",", ".")
                        zeit(ev, yPos, xPos(1), row(5))      'Datum Uhrzeit hin3
                        zeile += 1
                        yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
                        row(6) = row(6).replace(",", ".")
                        zeit(ev, yPos, xPos(1), row(6))       ' Datum Uhrzeit zurück
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(3) - 50, yPos, New StringFormat())   '  Zurück
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "", row(9)), printFont, Brushes.Black, xPos(0) - 40, yPos, New StringFormat())    ' Telfonnummer
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", row(7)), printFont, Brushes.Black, xPos(5) - 15, yPos, New StringFormat())    ' Bemerkung
                        zeile += 1
                        rNbr += 1
                        If rNbr >= dt.Rows.Count Then
                            row = Nothing
                            Exit While
                        End If
                        row = dt.Rows(rNbr)
                        If row(1) = "4" Then
                            GoTo Neueseite
                        End If
                        rNbr -= 1
                        row = dt.Rows(rNbr)
                    Case "4"
                        Tag1(ev, Seitenkopf)
                        rNbr += 1
                        If rNbr >= dt.Rows.Count Then
                            row = Nothing
                            Exit While
                        End If
                        row = dt.Rows(rNbr)
                        If row(1) = "5" Then
                            GoTo Neueseite
                        End If
                        rNbr -= 1
                        row = dt.Rows(rNbr)
                    Case "5"
                        eink(ev, Seitenkopf)
                        rNbr += 1
                        If rNbr >= dt.Rows.Count Then
                            row = Nothing
                            Exit While
                        End If
                        If rNbr >= dt.Rows.Count Then
                            GoTo druckende
                        End If
                        row = dt.Rows(rNbr)
                        If row(2) <> gruppe Then
                            gruppe = row(2)
                            GoTo Neueseite
                        End If
                        rNbr -= 1
                        row = dt.Rows(rNbr)
                End Select
            End If
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
Neueseite:
        zeile = 0
        lastRow = rNbr
        '  If more lines exist, print another page.
        ev.HasMorePages = True
        If Not (row Is Nothing) Then
        Else
            ev.HasMorePages = False
        End If
druckende:
    End Sub
    Private Sub ablauf1(ev, seitenkopf)
        Dim zwanzig As Integer = 20
        If speicherbild > " " And zeile = 0 Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, seitenkopf - 40))
        End If
        bootname = row(16)
        ev.Graphics.DrawString("A b l a u f   d e r   C r e w b e s p r e c h u n g", printFont14f, Brushes.Black, xPos(1), seitenkopf, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(17), printFont, Brushes.Black, xPos(2) + 50, yPos, New StringFormat())
        törndatum = row(17)
        zeile += 1
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 8
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Datum: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Besprechungsort: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(row(15), printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Anwesende: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        aaa = ""
        If Not (row(7)) = " " Then aaa += row(7)
        If Not (row(8)) = " " Then aaa += ", " + row(8)
        If Not (row(9)) = " " Then aaa += ", " + row(9)
        If Not (row(10)) = " " Then aaa += ", " + row(10)
        If Not (row(11)) = " " Then aaa += ", " + row(11)
        If Not (row(12)) = " " Then aaa += ", " + row(12)
        If Not (row(13)) = " " Then aaa += ", " + row(13)
        If Not (row(14)) = " " Then aaa += ", " + row(14)
        '        If Not DBNull.Value.Equals(row(14)) Then aaa += ", " + row(14)

        LangXText.LangXtextDrucken(aaa, zeile - 4.05, yPos, printFont, xPos(1) + zwanzig, ev, 88)
        '       ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", row(7)) + IIf(DBNull.Value.Equals(row(8)), "", ", " + row(8)) + IIf(DBNull.Value.Equals(row(9)), "", ", " + row(9)) + IIf(DBNull.Value.Equals(row(10)), "", ", " + row(10)) + IIf(DBNull.Value.Equals(row(11)), "", ", " + row(11)) + IIf(DBNull.Value.Equals(row(12)), "", ", " + row(12)) + IIf(DBNull.Value.Equals(row(13)), "", ", " + row(13)) + IIf(DBNull.Value.Equals(row(14)), "", ", " + row(14)), printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 3
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Vorstellung: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Name, Job, Segelerfahrung, Erwartungen, Befürchtungen, Wünsche", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 4
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Ziele/Thema: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Revier/Route: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        '                ev.Graphics.DrawString(row(18), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        LangXText.LangXtextDrucken(row(18), zeile - 4.05, yPos, printFont, xPos(1) + zwanzig, ev, 100)
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Kojenaufteilung und Schiffsdaten: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("siehe eigene Beschreibung", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Packliste: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("entspr. der Jahreszeit, Revier und Ziele; Apotheke, Krankheiten, Ausrüstung aufteilen", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Seekrankheit: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("das erste Mal am Bord? Chronische Krankheiten, eigene Medikamente, Notfallkuvert", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Seemannschaft: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Dresscode,Sprache, Zusammenarbeit", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Einkaufsliste: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("vorbereitete Listen besprechen, kochen oder Essen gehen? - wie oft", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 1
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics) + 0.2 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("   Menüplan: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("wer kocht was, Vorlage", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 1
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("   Einkäufer: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Jobs an Bord: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics) + 0.2 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("  Bordkassa: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(row(4), printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 1
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics) + 0.4 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("  Pantrymanager: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(row(5) + " organisiert Ersteinkauf, weiteres siehe Pantry Hinweise", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        '    zeile += 1
        '      yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics) + 0.4 * printFont.GetHeight(ev.Graphics)
        '      ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 3
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics) + 0.4 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Wache Einteilung ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics) + 0.4 * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Route und Aktivitäten ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())

        zeile += 3
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Anreise: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("siehe eigene Beschreibung", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Erster Tag: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("siehe eigene Beschreibung", printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        If Len(row(6)) > 3 Then
            zeile += 2
            yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Bemerkung: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(1) + zwanzig, yPos, New StringFormat())
        End If
    End Sub
    Private Sub kojen(ev, seitenkopf)
        If speicherbild > " " And zeile = 0 Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, Seitenkopf - 40))
        End If
        '      row = dt.Rows(rNbr)
        ev.Graphics.DrawString("C r e w   D e t a i l s", printFont14f, Brushes.Black, xPos(3) - 70, seitenkopf, New StringFormat())
        zeile += 2
        yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(törndatum, printFont, Brushes.Black, xPos(2) + 50, yPos, New StringFormat())
        zeile += 1
        yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 8
        yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Charter: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(13)), "", row(13)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Boot: ", printFontf, Brushes.Black, xPos(3) + 50, yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(14)), "", row(14)), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        zeile += 2
        yPos = Seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Aufteilung der Kojen ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        Dim BildB As Single
        Dim bildh As Single
        Dim faktor As Single
        Dim pixel As GraphicsUnit = GraphicsUnit.Pixel
        Dim bildbb As Single = 320
        bootname = row(16)
        bootname = bootname.Replace(" ", "")
        bootfoto = Image.FromFile(Trim$(speicherbild))
        If row(19) Is Nothing Then
            MsgBox("Bild des Bootes ist nicht versorgt")
        Else
            If My.Computer.FileSystem.FileExists(row(19)) Then
                bootfoto = Image.FromFile(row(19))
                BildB = bootfoto.Width
                bildh = bootfoto.Height
                faktor = BildB / bildh
                '  bildbb / faktor    muss klein 580 sein in einer Schleife
bild1:
                If bildbb / faktor > 400 Then
                    bildbb -= 10
                    GoTo bild1
                End If
                ev.Graphics.DrawImage(bootfoto, New Rectangle(xPos(3) - 30, yPos, bildbb, bildbb / faktor))
            End If
        End If
        zeile += 4
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)) And DBNull.Value.Equals(row(8)), "", "Bug Backbord: "), printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2)), printFont, Brushes.Black, xPos(0) + 20, yPos + 20, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", row(8)), printFont, Brushes.Black, xPos(0) + 20, yPos + 40, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)) And DBNull.Value.Equals(row(3)), "", "Bug Steuerbord: "), printFontf, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(5) + 20, yPos + 20, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "", row(9)), printFont, Brushes.Black, xPos(5) + 20, yPos + 40, New StringFormat())
        zeile += 6
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", "Stockbett oben: "), printFontf, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(5) + 20, yPos + 20, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", "Stockbett unten: "), printFontf, Brushes.Black, xPos(5), yPos + 40, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", row(7)), printFont, Brushes.Black, xPos(5) + 20, yPos + 60, New StringFormat())

        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", "Salon 1: "), printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(17)), "", row(17)), printFont, Brushes.Black, xPos(0) + 20, yPos + 20, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", "Salon 2: "), printFontf, Brushes.Black, xPos(0), yPos + 40, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(18)), "", row(18)), printFont, Brushes.Black, xPos(0) + 20, yPos + 60, New StringFormat())

        zeile += 6
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Heck Backbord: ", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(0) + 20, yPos + 20, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", row(10)), printFont, Brushes.Black, xPos(0) + 20, yPos + 40, New StringFormat())
        ev.Graphics.DrawString("Heck Steuerbord: ", printFontf, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(5) + 20, yPos + 20, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "", row(11)), printFont, Brushes.Black, xPos(5) + 20, yPos + 40, New StringFormat())
        ueberschrift = True
        rNbr += 1

    End Sub
    Private Sub zeit(ev, ypos, xpos, zt)
        If zt > " " Then
            Dim dat As String
            dat = SafeData.FormatDateDe(zt)
            ev.Graphics.DrawString(dat, printFont, Brushes.Black, xpos, ypos, New StringFormat())
            dat = SafeData.FormatTimeHm(zt)
            If dat > "" Then
                ev.Graphics.DrawString(dat, printFont, Brushes.Black, xpos + 80, ypos, New StringFormat())
            End If
        End If
    End Sub
    Private Sub eink(ev, seitenkopf)
        Dim wortlaenge As Integer
        If speicherbild > " " And zeile = 0 Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, seitenkopf - 40))
            ev.Graphics.DrawString("E i n k a u f s l i s t e", printFont14f, Brushes.Black, xPos(2) + 30, seitenkopf, New StringFormat())
            If IsDBNull(row(2)) Then
                gruppe = " "
            Else
                gruppe = row(2)
            End If
            zeile += 2
            yPos = seitenkopf + zeile * printFontf.GetHeight(ev.Graphics)
            wortlaenge = Len(gruppe) * 4
            ev.Graphics.DrawString(gruppe, printFontf, Brushes.Black, xPos(3) + 30 - wortlaenge, yPos, New StringFormat())
            zeile += 6
            yPos = seitenkopf + zeile * printFontf.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Crewanzahl: " + row(20), printFontf, Brushes.Black, xPos(5), yPos, New StringFormat())
            zeile += 2
            yPos = seitenkopf + zeile * printFontf.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("ü", printFWFont, Brushes.Black, xPos(0) - 20, yPos, New StringFormat())
            ev.Graphics.DrawString("Artikel", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Menge", printFontf, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString("Mengeneinheit", printFontf, Brushes.Black, xPos(3) - 30, yPos, New StringFormat())
            ev.Graphics.DrawString("Bemerkung", printFontf, Brushes.Black, xPos(4), yPos, New StringFormat())
            zeile += 2
            yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(xPos(0) - 60, yPos + 5), New Point(ev.MarginBounds.Right + 40, yPos + 5))
        End If
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("o", printFWFont, Brushes.Black, xPos(0) - 20, yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(3) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        rNbr += 1
    End Sub
    Private Sub Tag1(ev, seitenkopf)
        If speicherbild > " " And zeile = 0 Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, seitenkopf - 40))
            ev.Graphics.DrawString("D e r   1. und 2.   T a g", printFont14f, Brushes.Black, xPos(2) + 30, seitenkopf, New StringFormat())
            zeile += 2
             zeile += 8
            yPos = seitenkopf + zeile * printFontf.GetHeight(ev.Graphics)
            Rechteck(xPos(0) - 10, yPos - 10, 700, 45, ev)
            ev.Graphics.DrawString("Was", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Wann", printFontf, Brushes.Black, xPos(2) + 30, yPos, New StringFormat())
            ev.Graphics.DrawString("Wer", printFontf, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
            ev.Graphics.DrawString("Bemerkung", printFontf, Brushes.Black, xPos(4) + 75, yPos, New StringFormat())
            zeile += 1
            yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        End If
        zeile += 2
        yPos = seitenkopf + zeile * printFont.GetHeight(ev.Graphics)
        Rechteck(xPos(0) - 10, yPos - 10, 700, 33, ev)
        ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2)), printFont, Brushes.Black, xPos(2) + 30, yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(3) + 30, yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(4) + 30, yPos, New StringFormat())
        rNbr += 1

    End Sub
    Private Sub Rechteck(posx, posy, breite, hoehe, ev)
        ev.graphics.drawrectangle(Pens.Black, posx, posy, breite, hoehe)
        ev.graphics.drawrectangle(Pens.Black, posx + 250, posy, 1, hoehe)
        ev.graphics.drawrectangle(Pens.Black, posx + 350, posy, 1, hoehe)
        ev.graphics.drawrectangle(Pens.Black, posx + 500, posy, 1, hoehe)

     End Sub
End Class
