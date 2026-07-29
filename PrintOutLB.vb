Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutLB                                                                 '   Logbuch drucken
    Public speicherbild As String
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim SummeCrewSm As Single
    Dim logo As Image
    Dim podpis As Image
    Public sign As String
    Dim linesPerPage As Single = 0
    Dim yPos As Single = 0
    Dim xPos(10) As Single
    Dim ij As Integer = 0
    Dim zeile As Integer = 0
    Public zs As Integer
    Public zr As Integer
    Public zeilenanf As Single
    Public x As New Leerstelle
    Public aaa As String
    Public zeilentext As String
    Dim ErsteZeile As Boolean = True
    Dim text As String
    Dim row11 As String
    Dim sSize As SizeF
    Dim breite2 As Single
    Dim SeitenNummer As Integer = 1
    Dim erstecrew As Boolean = True
    Dim skipper As String
    Dim printFont_A10 As Font = New Font("Arial", 10)
    Dim printFont_A11 As Font = New Font("Arial", 11)
    Dim printFont_A12f As Font = New Font("Arial", 12, FontStyle.Bold)
    Dim printFont_E35f As Font = New Font("Old English Text MT", 35, FontStyle.Bold)
    Dim printFont_l12f As Font = New Font("Lucida Handwriting", 10)
    Dim printFont_l12w As Font = New Font("Wingdings", 15)
    Dim printFont_l12w2 As Font = New Font("Wingdings 2", 15)
    Dim row As DataRow = Nothing
    Dim bildboot As String
    Dim Sidatum As String
    Dim SiAnf As String
    Dim siEnde As String
    Dim gefRoute As String
    Dim seitendatum As String = " "
    Dim ausgangsort As String
    Dim zielort As String
    Dim anlegeart As String
    Dim gebühr As String
    Dim müll As Boolean
    Dim strom As Boolean
    Dim bilge As Boolean
    Dim Wasser As Boolean
    Dim öl As Boolean
    Dim Batterie As Boolean
    Dim Tanf As String
    Dim taend As String
    Dim diesel As String
    Dim dKosten As String
    Dim summeTsegel As Single
    Dim summeTmotor As Single
    Dim summeVsegel As Single = 0
    Dim summeVmotor As Single = 0
    Dim summeGsegel As Single = 0
    Dim summeGmotor As Single = 0
    Dim Pkt7 As Boolean = True
    Dim zeilennr As Integer = 0
    Dim Bootsname As String
    Dim datDok As String
    Dim datDok1 As String
    Dim rechts As Single
    Dim Feld1 As String
    Dim hh As Single
    Dim pkt6 As Boolean = True
    Dim fix As Boolean = False
    Dim datumr As Date
    Dim datuml As Date
    Dim lezterTag As String
    Dim Wache23 As Boolean = True
    Public Sub Printlogbuch(ByVal tIn As DataTable)                                          '   Logbuch drucken
        dt = tIn
        Dim pd As New PrintDocument()
        pd.DefaultPageSettings.Landscape = True
        If LogbuchDruck.RadioButton1.Checked Then
            AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
            pd.Print()
        Else
            AddHandler pd.PrintPage, AddressOf Me.pd_PrintLeer
            pd.Print()
        End If
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim rNbr As Integer
        leftMargin = ev.MarginBounds.Left
        topMargin = ev.MarginBounds.Top
        zeile = 0
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont_A10.GetHeight(ev.Graphics)
        xPos(0) = leftMargin - 50
        xPos(1) = xPos(0) + 100
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 100
        xPos(5) = xPos(4) + 100
        xPos(6) = xPos(5) + 100
        xPos(7) = xPos(6) + 100
        xPos(8) = xPos(7) + 100
        xPos(9) = xPos(8) + 100
        xPos(10) = xPos(9) + 100
        row = dt.Rows(0)
        rNbr = lastRow
        row = dt.Rows(rNbr)
        topMargin -= 60
        '        While zeile < (linesPerPage - 1)
        While zeile < 44
            If row Is Nothing Then GoTo druckende
            row = dt.Rows(rNbr)
            Select Case row(0)
                Case "1"
                    lezterTag = row(2)
                    datuml = CDate(lezterTag)

                    If Not DBNull.Value.Equals(row(23)) Then
                        If row(23) > " " Then
                            If My.Computer.FileSystem.FileExists(row(23)) Then
                                logo = Image.FromFile(Trim$(row(23)))
                                Dim imgWidth As Integer = logo.Width
                                Dim imgHeight As Integer = logo.Height
                                Dim imgRatio As Single
                                If imgHeight > imgWidth Then
                                    '                                     Hochformat
                                    If imgHeight > 600 Then
                                        imgRatio = imgHeight / 600
                                        imgWidth = imgWidth / imgRatio
                                        imgHeight = 600
                                    End If
                                    If imgWidth > 550 Then
                                        imgRatio = imgWidth / 550
                                        imgHeight = imgHeight / imgRatio
                                        imgWidth = 550
                                    End If
                                    ev.Graphics.DrawImage(logo, New Rectangle(xPos(5) + 20, topMargin + 70, imgWidth, imgHeight))
                                    caverh(leftMargin, topMargin, ev)
                                Else
                                    '                                    Breitformat
                                    If imgHeight > 300 Then
                                        imgRatio = imgHeight / 300
                                        imgWidth = imgWidth / imgRatio
                                        imgHeight = 300
                                    End If
                                    ev.Graphics.DrawImage(logo, New Rectangle(xPos(6) - (imgWidth / 2), topMargin + 70, imgWidth, imgHeight))
                                    caverb(leftMargin, topMargin, ev)
                                End If
                            Else
                                caverb(leftMargin, topMargin, ev)
                            End If
                        End If
                    End If
                    Bootsname = row(31)
                    zeile = 50
                    Feld1 = 1
                Case "2"
                    törndaten(leftMargin, topMargin, ev)
                    gefRoute = row(9)
                    Feld1 = 2
                Case "3"
                    If erstecrew Then
                        zeile = 6
                        zs = 4
                    Else
                        zs = 0
                    End If
                    Crew(leftMargin, topMargin, row(4), ev)
                    erstecrew = False
                    Feld1 = 3
                Case "4"
                    zeile = 50
                    Sidatum = row(4)
                    SiAnf = row(5)
                    siEnde = row(6)
                    Feld1 = 4
                Case "5"
                    Sicherheit(leftMargin, topMargin, ev)
                    zeile = 50
                    Feld1 = 5
                Case "6"
                    Select Case row(1)
                        Case "1"                      '                        Dokumentation jeden Tag
                            If Not DBNull.Value.Equals(row(8)) Then
                                Wache23 = False
                            Else
                                Wache23 = True
                            End If
                            Logdoku(leftMargin, topMargin, ev)
                            datDok = row(2)
                            ausgangsort = row(14)
                            zielort = row(15)
                            anlegeart = row(8)
                            gebühr = row(9)
                            If Not DBNull.Value.Equals(row(25)) Then
                                müll = row(25)
                            Else
                                müll = False
                            End If
                            If Not DBNull.Value.Equals(row(26)) Then
                                strom = row(26)
                            Else
                                strom = False
                            End If
                            If Not DBNull.Value.Equals(row(27)) Then
                                bilge = row(27)
                            Else
                                bilge = False
                            End If
                            If Not DBNull.Value.Equals(row(28)) Then
                                Wasser = row(28)
                            Else
                                Wasser = False
                            End If
                            If Not DBNull.Value.Equals(row(29)) Then
                                öl = row(29)
                            Else
                                öl = False
                            End If
                            If Not DBNull.Value.Equals(row(30)) Then
                                Batterie = row(25)
                            Else
                                Batterie = False
                            End If

                            Tanf = row(10)
                            If Tanf <> " " Then
                                If Tanf.Contains(",") Then
                                Else
                                    Tanf = Tanf + ",0"
                                End If
                            End If
                            taend = row(11)
                            If taend <> " " Then
                                If taend.Contains(",") Then
                                Else
                                    taend = taend + ",0"
                                End If
                            End If

                            If Not DBNull.Value.Equals(row(12)) Then
                                diesel = row(12)
                                dKosten = row(13)
                            Else
                                diesel = "0"
                            End If
                        Case "2"                          '                 Wachedienst
                            Wachedienst(leftMargin, topMargin, ev)
                            rNbr += 1
                            row = dt.Rows(rNbr)
                            If row(0) = "6" Then
                                If row(1) = "3" Then
                                    GoTo Neueseite
                                End If
                            End If
                            rNbr -= 1
                            row = dt.Rows(rNbr)
                        Case "3"                         '                   Tägliche Logdaten und Summenblock jeder Seite
                            datumr = CDate(row(2))
                            aaa = row(3)
                            If DBNull.Value.Equals(row(11)) Then
                                row(11) = " "
                            End If
                            If datumr = datuml And row(11) = "Keine Ausfahrt" Then
                            Else
                                If zeile >= 44 Then
                                    Summenblock(leftMargin, topMargin, ev)
                                    '     rNbr -= 1
                                    row = dt.Rows(rNbr)
                                    SeitenNummer += 1
                                    GoTo Neueseite
                                End If
                                FixSeite(leftMargin, topMargin, ev)
                                Logdaten(leftMargin, topMargin, ev)
                                rNbr += 1
                                row = dt.Rows(rNbr)
                                If row(0) = "6" Then
                                    If row(1) = "1" Then
                                        Summenblock(leftMargin, topMargin, ev)
                                        GoTo Neueseite
                                    End If
                                End If
                                rNbr -= 1
                                row = dt.Rows(rNbr)
                            End If
                    End Select
                    Feld1 = 6
                Case "7"
                    datumr = CDate(row(2))
                    If datumr = datuml And row(13) = 0 Then
                    Else
                        If Pkt7 Then
                            Summenblock(leftMargin, topMargin, ev)
                            Pkt7 = False
                            GoTo Neueseite
                        End If
                        rNbr -= 1
                        row = dt.Rows(rNbr)
                        If row(0) = "6" Then
                            zusammenfassT(leftMargin, topMargin, ev)
                        End If
                        rNbr += 1
                        row = dt.Rows(rNbr)
                        zeilennr += 1
                        zusammenfassW(leftMargin, topMargin, ev)
                    End If
                    Feld1 = 7
                Case "8"
                    If Pkt7 = False Then
                        zuasmSumme(leftMargin, topMargin, ev)
                        Pkt7 = True
                        GoTo Neueseite
                    End If
                    rNbr -= 1
                    row = dt.Rows(rNbr)
                    If row(0) = "7" Then
                        MängelK(leftMargin, topMargin, ev)
                    End If
                    rNbr += 1
                    row = dt.Rows(rNbr)
                    MängelT(leftMargin, topMargin, ev)
            End Select
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
            '           leZei = True
            ev.HasMorePages = False
        End If

druckende:
    End Sub
    Private Sub caverh(leftMargin, topMargin, ev)
        yPos = topMargin + zeile * printFont_E35f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Logbuch", printFont_E35f, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont_E35f.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos + 1), New Point(ev.MarginBounds.Right + 40, yPos + 1))
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos + 3), New Point(ev.MarginBounds.Right + 40, yPos + 3))
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics) + 15
        ev.Graphics.DrawString("Für den Törn von", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("bis", printFont_A11, Brushes.Black, xPos(3) + 15, yPos, New StringFormat())
        ev.Graphics.DrawString(row(1), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(row(2), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())

        zeile += 1
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 15), New Point(xPos(3), yPos + 15))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 15), New Point(xPos(5), yPos + 15))
        zeile += 1
        yPos = topMargin + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("            im Gebiet", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 10), New Point(xPos(5), yPos + 10))


        '      If Not DBNull.Value.Equals(row(23)) Then
        '      If row(23) > " " Then
        '        If My.Computer.FileSystem.FileExists(row(23)) Then
        '        logo = Image.FromFile(Trim$(row(23)))
        '        Dim imgWidth As Integer = logo.Width
        '       Dim imgHeight As Integer = logo.Height
        '        Dim imgRatio As Single
        '       If imgHeight > 600 Then
        '        imgRatio = imgHeight / 600
        '       imgWidth = imgWidth / imgRatio
        '      imgHeight = 600
        '     End If
        '    If imgWidth > 550 Then
        '        imgRatio = imgWidth / 550
        '       imgHeight = imgHeight / imgRatio
        '      imgWidth = 550
        '     End If
        '        ev.Graphics.DrawImage(logo, New Rectangle(xPos(5) + 20, yPos + 13, imgWidth, imgHeight))
        '        End If
        '       End If
        '       End If
        If Not DBNull.Value.Equals(row(22)) Then bildboot = row(22)
        zeile += 2
        yPos = topMargin + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("  Daten der Yacht", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("                    Name", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(31), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("                   Eigner", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(14), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("               Hersteller", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(4), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("            Baustoff", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        If Not DBNull.Value.Equals(row(20)) Then ev.Graphics.DrawString(row(20), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("           Registriernr.", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", row(7)), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString("MMSI", printFont_A11, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(24), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("            Klasse/Typ", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(5), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("           Segelfläche", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(12) + " m²", printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("                  Baujahr", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(13), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("    Länge über alles", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Breite", printFont_A11, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(8) + " m", printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(row(9) + " m", printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("        Verdrängung", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Tiefgang", printFont_A11, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(10) + " t", printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(row(11) + " m", printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Bootsmotor", printFont_A12f, Brushes.Black, xPos(1) + 50, yPos, New StringFormat())
        ev.Graphics.DrawString("Beibootmotor", printFont_A12f, Brushes.Black, xPos(3) + 50, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("               Marke", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        If Not DBNull.Value.Equals(row(17)) Then ev.Graphics.DrawString(row(17), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(18)) Then ev.Graphics.DrawString(row(18), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("         Leistung [PS]", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(15), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(19)) Then ev.Graphics.DrawString(row(19), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        zeile += 3
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("                  Skipper", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(16), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        skipper = row(16)
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("           Unterschrift ", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        '     ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))

        sign = GetSetting("sign", "Pfad", "T", " ")
        If sign > " " Then
            podpis = Image.FromFile(Trim$(sign))
            Dim bildb As Single
            Dim bildh As Single
            Dim faktor As Single
            bildb = podpis.Width
            bildh = podpis.Height
            If bildh > 580 Then
                faktor = bildb / 3
                ev.Graphics.DrawImage(podpis, New Rectangle(xPos(2), yPos - 20, bildb / faktor, bildh / faktor))
            Else
                ev.Graphics.DrawImage(podpis, New Point(xPos(2), yPos - 20))
            End If
        End If
    End Sub
    Private Sub caverb(leftMargin, topMargin, ev)
        yPos = topMargin + zeile * printFont_E35f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Logbuch", printFont_E35f, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont_E35f.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        '       ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos + 1), New Point(ev.MarginBounds.Right + 40, yPos + 1))
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos + 3), New Point(ev.MarginBounds.Right + 40, yPos + 3))
        zeile += 21
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics) + 15
        ev.Graphics.DrawString("Für den Törn von", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("bis", printFont_A11, Brushes.Black, xPos(3) + 15, yPos, New StringFormat())
        ev.Graphics.DrawString(row(1), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(row(2), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        ev.Graphics.DrawString(" im Gebiet", printFont_A11, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont_l12f, Brushes.Black, xPos(6), yPos, New StringFormat())
        ev.Graphics.DrawString(" Skipper", printFont_A11, Brushes.Black, xPos(8), yPos, New StringFormat())
        ev.Graphics.DrawString(row(16), printFont_l12f, Brushes.Black, xPos(9), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(6), yPos + 20), New Point(xPos(8), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(9), yPos + 20), New Point(xPos(10) + 60, yPos + 20))

        If Not DBNull.Value.Equals(row(22)) Then bildboot = row(22)

        zeile += 3
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.graphics.drawrectangle(Pens.Black, leftMargin - 55, yPos - 1, ev.MarginBounds.Right - leftMargin + 120, 25)
        ev.Graphics.DrawString("  Daten der Yacht", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
 
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("                    Name", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(row(31), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(" Eigner", printFont_A11, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(row(14), printFont_l12f, Brushes.Black, xPos(6), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(6), yPos + 20), New Point(xPos(8), yPos + 20))

        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("            Klasse/Typ", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(row(5), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(" Hersteller", printFont_A11, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(row(4), printFont_l12f, Brushes.Black, xPos(6), yPos, New StringFormat())
        ev.Graphics.DrawString(" Baustoff", printFont_A11, Brushes.Black, xPos(8), yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(20)) Then ev.Graphics.DrawString(row(20), printFont_l12f, Brushes.Black, xPos(9), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(6), yPos + 20), New Point(xPos(8), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(9), yPos + 20), New Point(xPos(10) + 60, yPos + 20))

        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("           Registriernr.", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", row(7)), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString("MMSI", printFont_A11, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
        ev.Graphics.DrawString(row(24), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        ev.Graphics.DrawString(" Segelfläche", printFont_A11, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(row(12) + " m²", printFont_l12f, Brushes.Black, xPos(6), yPos, New StringFormat())
        ev.Graphics.DrawString(" Baujahr", printFont_A11, Brushes.Black, xPos(8), yPos, New StringFormat())
        ev.Graphics.DrawString(row(13), printFont_l12f, Brushes.Black, xPos(9), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(6), yPos + 20), New Point(xPos(8), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(9), yPos + 20), New Point(xPos(10) + 60, yPos + 20))

        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("    Länge über alles", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Breite", printFont_A11, Brushes.Black, xPos(3) + 5, yPos, New StringFormat())
        ev.Graphics.DrawString(row(8) + " m", printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString(row(9) + " m", printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        ev.Graphics.DrawString(" Tiefgang", printFont_A11, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString(row(11) + " m", printFont_l12f, Brushes.Black, xPos(6), yPos, New StringFormat())
        ev.Graphics.DrawString(" Verdrängung", printFont_A11, Brushes.Black, xPos(8), yPos, New StringFormat())
        ev.Graphics.DrawString(row(10) + " t", printFont_l12f, Brushes.Black, xPos(9), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(6), yPos + 20), New Point(xPos(8), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(9), yPos + 20), New Point(xPos(10) + 60, yPos + 20))

        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Bootsmotor", printFont_A12f, Brushes.Black, xPos(1) + 50, yPos, New StringFormat())
        ev.Graphics.DrawString("Beibootmotor", printFont_A12f, Brushes.Black, xPos(3) + 50, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("                 Marke", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        If Not DBNull.Value.Equals(row(17)) Then ev.Graphics.DrawString(row(17), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(18)) Then ev.Graphics.DrawString(row(18), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("         Leistung [PS]", printFont_A11, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(3), yPos + 20))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(3) + 50, yPos + 20), New Point(xPos(5), yPos + 20))
        ev.Graphics.DrawString(row(15), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(19)) Then ev.Graphics.DrawString(row(19), printFont_l12f, Brushes.Black, xPos(3) + 70, yPos, New StringFormat())
      skipper = row(16)
        '       yPos = topMargin + zeile * printFont_A11.GetHeight(ev.Graphics)
        '     ev.Graphics.DrawLine(Pens.Black, New Point(xPos(2) - 50, yPos + 20), New Point(xPos(5), yPos + 20))
       sign = GetSetting("sign", "Pfad", "T", " ")
        If sign > " " Then
            podpis = Image.FromFile(Trim$(sign))
            Dim bildb As Single
            Dim bildh As Single
            Dim faktor As Single
            bildb = podpis.Width
            bildh = podpis.Height
            If bildh > 580 Then
                faktor = bildb / 3
                ev.Graphics.DrawImage(podpis, New Rectangle(xPos(7), yPos - 20, bildb / faktor, bildh / faktor))
            Else
                ev.Graphics.DrawImage(podpis, New Point(xPos(7), yPos - 20))
            End If
            ev.Graphics.DrawString("Unterschrift des Skippers", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        End If
    End Sub
    Private Sub törndaten(leftmargin, topmargin, ev)
        '    g.FillRectangle(Brushes.Black, rec)
        DoppelRechteck(50, 50, 1050, 60, ev)
        zeile = 1
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Geplante Route:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(4)) Then
            aaa = Len(row(4))
            If aaa > 100 Then
                For i = 100 To 80 Step -1
                    If row(4).ToString.Substring(i, 1) = " " Then
                        ev.Graphics.DrawString(row(4).ToString.Substring(0, i), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos - 10, New StringFormat())
                        ev.Graphics.DrawString(row(4).ToString.Substring(i + 1, aaa - i - 2), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos + 10, New StringFormat())
                        GoTo schleife
                    End If
                Next
                '               ev.Graphics.DrawString(row(4), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
            Else
                ev.Graphics.DrawString(row(4), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
            End If
        End If
schleife:
        zeile += 3
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Crew", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Vorname  Nachname", printFont_A12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString("Bemerkung", printFont_A12f, Brushes.Black, xPos(7), yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 8), New Point(1100, yPos + 8))

        zeile += 1
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("1.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        ev.Graphics.DrawString(skipper, printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        ev.Graphics.DrawString("Skipper", printFont_l12f, Brushes.Black, xPos(7), yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        zs = 5
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("2.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("3.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("4.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        ev.Graphics.DrawString("Co-Skipper", printFont_l12f, Brushes.Black, xPos(7), yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("5.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("6.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("7.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("8.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("9.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos + 5), New Point(1100, yPos + 5))

        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString("10.", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())

        DoppelRechteck(50, 120, 1050, 380, ev)
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 30, 120), New Point(xPos(1) + 30, 500))
        ev.Graphics.DrawLine(Pens.Black, New Point(xPos(7) - 10, 120), New Point(xPos(7) - 10, 500))
        ' --------------------------------------------------------------------------------------------------------------------------
        zeile += 3
        yPos = 48 + zeile * printFont_A12f.GetHeight(ev.Graphics) - zs
        ev.Graphics.DrawString("Verantwortlich für", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = 48 + zeile * printFont_A12f.GetHeight(ev.Graphics) - zs
        ev.Graphics.DrawString("Bordkassa", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(5)) Then ev.Graphics.DrawString(row(5), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics) - zs
        ev.Graphics.DrawString("Einzahlung je:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(6)) Then ev.Graphics.DrawString(row(6) + " €", printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        DoppelRechteck(50, 550, 350, 100, ev)

        zeile += 3
        yPos = 48 + zeile * printFont_A12f.GetHeight(ev.Graphics) - zs
        ev.Graphics.DrawString("Verantwortlich für", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = 48 + zeile * printFont_A12f.GetHeight(ev.Graphics) - zs
        ev.Graphics.DrawString("Pantry", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(7)) Then ev.Graphics.DrawString(row(7), printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        zeile += 2
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics) - zs
        ev.Graphics.DrawString("Ersteinkauf:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(8)) Then ev.Graphics.DrawString(row(8) + " €", printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())
        DoppelRechteck(50, 667, 350, 100, ev)
        If bildboot = Nothing Then
        Else
            If bildboot > " " Then
                If My.Computer.FileSystem.FileExists(bildboot) Then
                    logo = Image.FromFile(Trim$(bildboot))
                    logo.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    Dim imgWidth As Integer = logo.Width
                    Dim imgHeight As Integer = logo.Height
                    Dim imgRatio As Single
                    If imgHeight > 600 Then
                        imgRatio = imgHeight / 600
                        imgWidth = imgWidth / imgRatio
                        imgHeight = 600
                    End If
                    If imgWidth > 600 Then
                        imgRatio = imgWidth / 600
                        imgHeight = imgHeight / imgRatio
                        imgWidth = 600
                    End If
                    ev.Graphics.DrawImage(logo, New Rectangle(xPos(4), yPos - 230, imgWidth, imgHeight))
                End If
            End If
        End If
     End Sub
    Private Sub Crew(leftmargin, topmargin, name, ev)
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) + zs
        ev.Graphics.DrawString(name, printFont_l12f, Brushes.Black, xPos(2) - 30, yPos, New StringFormat())

    End Sub
    Private Sub Sicherheit(leftMargin, topMargin, ev)
        DoppelRechteck(50, 50, 1050, 50, ev)
        zeile = 1
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Datum:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString(Sidatum, printFont_l12f, Brushes.Black, xPos(1) - 35, yPos + 2, New StringFormat())
        ev.Graphics.DrawString("von:", printFont_A12f, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(SiAnf, printFont_l12f, Brushes.Black, xPos(2) + 40, yPos + 2, New StringFormat())
        ev.Graphics.DrawString("bis:", printFont_A12f, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString(siEnde, printFont_l12f, Brushes.Black, xPos(3) + 40, yPos + 2, New StringFormat())
        DoppelRechteck(50, 110, 1050, 285, ev)
        zeile += 3
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Sicherheitseinweisung", printFont_A12f, Brushes.Black, xPos(0), yPos - 2, New StringFormat())
        ev.Graphics.DrawString("Bordeinweisung", printFont_A12f, Brushes.Black, xPos(6) - 50, yPos - 2, New StringFormat())
        ev.Graphics.DrawString("Lifebelt,Schwimmweste,Sorgeleine", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Organisation, Dokumentation", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox1.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox8.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Feuer, Feuerlöscher", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Innen", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox2.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox9.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Gas", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Pantry", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox3.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox10.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Rettungsring, Rettungsinsel", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Elektrische Anlagen", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox4.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox11.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Wasser", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Sprechfunk,Instrumente", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox15.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox12.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Signalmittel", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Aussen", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox5.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox16.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("POB", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Motor", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox6.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox13.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Gesundheit am Bord", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Segel", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        If LogbuchDruck.CheckBox7.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        End If
        If LogbuchDruck.CheckBox14.Checked Then
            ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(9) + 40, yPos, New StringFormat())
        End If

        DoppelRechteck(50, 440, 1050, 185, ev)
        zeile += 3
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Zusammenfassung:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Sm Antriebsart Motor", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "____________", row(4)), printFont_l12f, Brushes.Black, xPos(5) - 40, yPos + 2, New StringFormat())
        ev.Graphics.DrawString("Missweisung", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "____________", row(9)), printFont_l12f, Brushes.Black, xPos(9) + 40, yPos + 2, New StringFormat())
        zeile += 4
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Sm Antriebsart Segel", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "____________", row(5)), printFont_l12f, Brushes.Black, xPos(5) - 40, yPos + 2, New StringFormat())
        ev.Graphics.DrawString("Sonnenaufgang [Lokalzeit]", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "____________", row(10)), printFont_l12f, Brushes.Black, xPos(9) + 40, yPos + 2, New StringFormat())
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Motorstunden", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "____________", row(6)), printFont_l12f, Brushes.Black, xPos(5) - 40, yPos + 2, New StringFormat())
        ev.Graphics.DrawString("Sonnenuntergang [Lokalzeit]", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "____________", row(11)), printFont_l12f, Brushes.Black, xPos(9) + 40, yPos + 2, New StringFormat())
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        '      ev.Graphics.DrawString("Nachtfahrten/Nachtansteuerungen", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        Dim navtex As String = row(12)
        If Len(navtex) > 30 Then navtex = navtex.Substring(0, 29)
        ev.Graphics.DrawString("Navtexstationen", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(12)), "____________", navtex), printFont_l12f, Brushes.Black, xPos(5) - 40, yPos + 2, New StringFormat())
        Dim nf As Integer
        Dim na As Integer
        If LogbuchDruck.RadioButton1.Checked Then
            If Not DBNull.Value.Equals(row(7)) Then
                nf = row(7)
            Else
                nf = 0
            End If
            If Not DBNull.Value.Equals(row(8)) Then
                na = row(8)
            Else
                na = 0
            End If
            ev.Graphics.DrawString(nf.ToString + "/" + na.ToString, printFont_l12f, Brushes.Black, xPos(9) + 40, yPos + 2, New StringFormat())
        Else
            ev.Graphics.DrawString("____________", printFont_l12f, Brushes.Black, xPos(9) + 40, yPos + 2, New StringFormat())
        End If
        ev.Graphics.DrawString("Nachtfahrten/Nachtansteuerungen", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        '        ev.Graphics.DrawString("Navtexstationen", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        zeile += 2
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Sonstiges", printFont_A11, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(15)), "____________", row(15)), printFont_l12f, Brushes.Black, xPos(5) - 40, yPos + 2, New StringFormat())
        ev.Graphics.DrawString("Vollmond", printFont_A11, Brushes.Black, xPos(7), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(14)), "____________", row(14)), printFont_l12f, Brushes.Black, xPos(9) + 40, yPos + 2, New StringFormat())

        DoppelRechteck(50, 640, 1050, 100, ev)
        zeile += 3
        yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Gefahrene Route:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        LangXText.LangXtextDrucken(gefRoute, zeile - 6, yPos, printFont_l12f, xPos(2), ev, 100)
    End Sub
    Private Sub Logdoku(leftMargin, topMargin, ev)
        zeile = 1
        yPos = 20 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Wettervorschau", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Internetseiten:", printFont_A12f, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Datum:", printFont_A12f, Brushes.Black, xPos(7), yPos, New StringFormat())
        ev.Graphics.DrawString(row(2), printFont_l12f, Brushes.Black, xPos(7) + 70, yPos + 2, New StringFormat())
        If LogbuchDruck.RadioButton1.Checked Then
            If Not DBNull.Value.Equals(row(4)) Then
                Dim internet As String = row(4)
                If Not DBNull.Value.Equals(row(5)) Then
                    If row(5) = " " Or row(5) = "" Then
                    Else
                        internet = internet + ", " + row(5)
                    End If
                    If Not DBNull.Value.Equals(row(6)) Then
                        If row(6) = " " Or row(6) = "" Then
                        Else
                            internet = internet + ", " + row(6)
                        End If
                    End If
                End If
                If internet = ", , " Then internet = " "
                ev.Graphics.DrawString(internet, printFont_l12f, Brushes.Black, xPos(3) + 30, yPos + 2, New StringFormat())
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "____________", row(7)), printFont_l12f, Brushes.Black, xPos(9) + 70, yPos + 2, New StringFormat())
            Else
                ev.Graphics.DrawString("_____________________", printFont_l12f, Brushes.Black, xPos(3) + 30, yPos + 2, New StringFormat())
            End If
        Else
            ev.Graphics.DrawString("__________________________________", printFont_l12f, Brushes.Black, xPos(3) + 30, yPos + 2, New StringFormat())
            ev.Graphics.DrawString("__________", printFont_l12f, Brushes.Black, xPos(9) + 70, yPos + 2, New StringFormat())
        End If
        ev.Graphics.DrawString("Uhrzeit:", printFont_A12f, Brushes.Black, xPos(9), yPos, New StringFormat())
        DoppelRechteck(50, 70, 1050, 350, ev)
        zeile += 1
        yPos = 45 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Bemerkungen, Schiffsort, Kursmarken, Peilungen, Strom, Abtrifft, Gezeiten, Tidenhub:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1100, yPos))
        If Not DBNull.Value.Equals(row(21)) Then
            zeile += 3
            yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
            LangXText.LangXtextDrucken(row(21), zeile - 6, yPos, printFont_l12f, xPos(0) + 10, ev, 120)
        End If

        DoppelRechteck(50, 430, 450, 350, ev)
        zeile = 21
        yPos = 45 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Besonderes:", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1100, yPos))
        If Not DBNull.Value.Equals(row(24)) Then
            zeile += 3
            yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
            LangXText.LangXtextDrucken(row(24), zeile - 6, yPos, printFont_l12f, xPos(0) + 10, ev, 52)          ' Besonderes
        End If

        DoppelRechteck(505, 430, 595, 350, ev)
        zeile = 20
        yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Wachedienst", printFont_A12f, Brushes.Black, xPos(7), yPos, New StringFormat())
        zeile += 3
        yPos = 48 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("von - bis", printFont_A12f, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        ev.Graphics.DrawString("Wachführer", printFont_A12f, Brushes.Black, xPos(6) - 20, yPos, New StringFormat())
        If Wache23 Then
            ev.Graphics.DrawString("Navigator ", printFont_A12f, Brushes.Black, xPos(8) - 70, yPos, New StringFormat())
            ev.Graphics.DrawString("Rudergänger", printFont_A12f, Brushes.Black, xPos(9), yPos, New StringFormat())
        Else
            ev.Graphics.DrawString("+ Navigator ", printFont_A12f, Brushes.Black, xPos(7) - 20, yPos, New StringFormat())
            ev.Graphics.DrawString("Rudergänger", printFont_A12f, Brushes.Black, xPos(8), yPos, New StringFormat())
        End If
        zeile += -1
    End Sub
    Private Sub Wachedienst(leftMargin, topMargin, ev)
        zeile += 1
        yPos = 44 + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(3) + " - " + row(9), printFont_l12f, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
        If Not DBNull.Value.Equals(row(8)) Then
            ev.Graphics.DrawString(row(4), printFont_l12f, Brushes.Black, xPos(6) - 20, yPos, New StringFormat())
            ev.Graphics.DrawString(row(7), printFont_l12f, Brushes.Black, xPos(8) - 70, yPos, New StringFormat())
            ev.Graphics.DrawString(row(8), printFont_l12f, Brushes.Black, xPos(9), yPos, New StringFormat())
            Wache23 = True
        Else
            If Not DBNull.Value.Equals(row(4)) Then ev.Graphics.DrawString(row(4), printFont_l12f, Brushes.Black, xPos(6) - 20, yPos, New StringFormat())
            If Not DBNull.Value.Equals(row(7)) Then ev.Graphics.DrawString(row(7), printFont_l12f, Brushes.Black, xPos(8), yPos, New StringFormat())
            Wache23 = False
        End If
    End Sub
    Private Sub Logdaten(leftMargin, topMargin, ev)
        Dim rech As Single
        zeile += 2
        If zeile = 4 Then
            yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
            zeile += 1
        Else
            yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics) * 0.75
        End If
        ev.Graphics.DrawString(row(3), printFont_l12f, Brushes.Black, xPos(0), yPos, New StringFormat())         ' Uhrzeit
        If Not DBNull.Value.Equals(row(5)) Then ev.Graphics.DrawString(row(5), printFont_l12f, Brushes.Black, xPos(1) - 20, yPos, New StringFormat()) ' Winrichtung
        If Not DBNull.Value.Equals(row(6)) Then ev.Graphics.DrawString(row(6), printFont_l12f, Brushes.Black, xPos(1) + 60, yPos, New StringFormat()) ' Windstärke
        If Not DBNull.Value.Equals(row(7)) Then ev.Graphics.DrawString(row(7), printFont_l12f, Brushes.Black, xPos(2) + 15, yPos, New StringFormat()) ' Seegang
        If Not DBNull.Value.Equals(row(8)) Then ev.Graphics.DrawString(row(8), printFont_l12f, Brushes.Black, xPos(2) + 80, yPos, New StringFormat()) ' Luftdruck
        If Not DBNull.Value.Equals(row(9)) Then wolken(ev)
        If Not DBNull.Value.Equals(row(10)) Then ev.Graphics.DrawString(row(10), printFont_l12f, Brushes.Black, xPos(4) + 40, yPos, New StringFormat()) ' KüG
        If Not DBNull.Value.Equals(row(11)) Then ev.Graphics.DrawString(row(11), printFont_l12f, Brushes.Black, xPos(5) + 20, yPos, New StringFormat()) ' Position
        If Not DBNull.Value.Equals(row(12)) Then ev.Graphics.DrawString(row(12), printFont_l12f, Brushes.Black, xPos(8) - 30, yPos, New StringFormat()) ' Antriebsart
        If Not DBNull.Value.Equals(row(13)) Then
            hh = row(13)
            text = Format$(hh, "#0.0")
            sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
            rechts = xPos(9) - sSize.Width.ToString + 20
            ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) '              tagesdistanz
        End If
        If Not DBNull.Value.Equals(row(14)) Then
            hh = row(14)
            text = Format$(hh, "#0.0")
            sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
            rechts = xPos(10) - sSize.Width.ToString - 20
            ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) '     Segeldistanz
            summeTsegel += row(14)
        End If
        If Not DBNull.Value.Equals(row(15)) Then
             hh = row(15)
            text = Format$(hh, "#0.0")
            sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
            rechts = xPos(10) - sSize.Width.ToString + 70
            ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) '          Motordistanz
            summeTmotor += row(15)
        End If
        '      Format$(row(15), "#0.0")
    End Sub
    Private Sub wolken(ev)
        Select Case row(9)
            Case ("wolkenlos")
                aaa = "Be0.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("sonnig 1/8")
                aaa = "Be1.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("heller 2/8")
                aaa = "Be2.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("leicht bewölkt 3/8")
                aaa = "Be3.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("wolkig 4/8")
                aaa = "Be4.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("bewölkt 5/8")
                aaa = "Be5.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("stark bewölkt 6/8")
                aaa = "Be6.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("fast bedeckt 7/8")
                aaa = "Be7.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("bedeckt 8/8")
                aaa = "Be8.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
            Case ("nicht erkennbar")

                aaa = "Be9.png"
                logo = Image.FromFile(Trim$(aaa))
                Dim imgWidth As Integer = logo.Width
                Dim imgHeight As Integer = logo.Height
                Dim imgRatio As Single
                If imgHeight > 20 Then
                    imgRatio = imgHeight / 20
                    imgWidth = imgWidth / imgRatio
                    imgHeight = 20
                End If
                If imgWidth > 20 Then
                    imgRatio = imgWidth / 20
                    imgHeight = imgHeight / imgRatio
                    imgWidth = 20
                End If
                ev.Graphics.DrawImage(logo, New Rectangle(xPos(3) + 80, yPos, imgWidth, imgHeight))
        End Select

    End Sub
    Private Sub Summenblock(leftMargin, topMargin, ev)
         zeile = 35
        yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
        hh = summeTsegel
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString - 20
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel
        hh = summeTmotor
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString + 70
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel

        aaa = Math.Round(summeTsegel, 1)
        If InStr(aaa, ",") = 0 Then
            aaa = aaa + ",0"
        End If
        '      ev.Graphics.DrawString(aaa, printFont_l12f, Brushes.Black, xPos(9) + 59, yPos, New StringFormat())

        aaa = Math.Round(summeTmotor, 1)
        If InStr(aaa, ",") = 0 Then
            aaa = aaa + ",0"
        End If
        '       ev.Graphics.DrawString(aaa, printFont_l12f, Brushes.Black, xPos(10) + 29, yPos, New StringFormat())
        zeile += 2
        yPos = 70 + zeile * printFont_A11.GetHeight(ev.Graphics)
        hh = summeVsegel
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString - 20
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel
        hh = summeVmotor
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString + 70
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel
        '     ev.Graphics.DrawString(summeVsegel, printFont_l12f, Brushes.Black, xPos(9) + 59, yPos, New StringFormat())
        '    ev.Graphics.DrawString(summeVmotor, printFont_l12f, Brushes.Black, xPos(10) + 29, yPos, New StringFormat())
        summeVsegel += summeTsegel
        summeVmotor += summeTmotor
        summeGsegel = summeVsegel
        summeGmotor = summeVmotor
        zeile += 2
        yPos = 75 + zeile * printFont_A11.GetHeight(ev.Graphics)
        '    ev.Graphics.DrawString(summeGsegel, printFont_l12f, Brushes.Black, xPos(9) + 59, yPos, New StringFormat())
        '    ev.Graphics.DrawString(summeGmotor, printFont_l12f, Brushes.Black, xPos(10) + 29, yPos, New StringFormat())

        hh = summeGsegel
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString - 20
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel
        hh = summeGmotor
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString + 70
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel
        SeitenNummer += 1
    End Sub
    Private Sub FixSeite(leftMargin, topMargin, ev)
        If zeile = 0 Then
            yPos = 50 + zeile * printFont_A12f.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Datum", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Tag", printFont_A12f, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString("Ausgangsort", printFont_A12f, Brushes.Black, xPos(4), yPos, New StringFormat())
            ev.Graphics.DrawString("Zielort", printFont_A12f, Brushes.Black, xPos(7), yPos, New StringFormat())
            ev.Graphics.DrawString("Seite", printFont_A12f, Brushes.Black, xPos(10), yPos, New StringFormat())
                Dim dtn As String
            '               If LogbuchDruck.RadioButton1.Checked Then
            '        Else
            '           dtn = datDok1
            '      End If
            dtn = row(2)
            Dim thisWeekDay As Integer
            Dim tagname As String
            Dim datmu As Date = CDate(dtn)
            thisWeekDay = Weekday(datmu, FirstDayOfWeek.Monday)
            tagname = WeekdayName(thisWeekDay)
            ev.Graphics.DrawString(dtn, printFont_l12f, Brushes.Black, xPos(0) + 60, yPos + 2, New StringFormat())
            ev.Graphics.DrawString(tagname, printFont_l12f, Brushes.Black, xPos(2) + 40, yPos + 2, New StringFormat())
            ev.Graphics.DrawString(ausgangsort, printFont_l12f, Brushes.Black, xPos(5) + 10, yPos + 2, New StringFormat())
            ev.Graphics.DrawString(zielort, printFont_l12f, Brushes.Black, xPos(8) - 40, yPos + 2, New StringFormat())
            ev.Graphics.DrawString(SeitenNummer, printFont_l12f, Brushes.Black, xPos(10) + 50, yPos + 2, New StringFormat())

            DoppelRechteck(50, 80, 1080, 582, ev)
            zeile += 2
            yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Uhrzeit", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Wind", printFont_A12f, Brushes.Black, xPos(1) + 20, yPos - 5, New StringFormat())
            ev.Graphics.DrawString("Richtung", printFont_A12f, Brushes.Black, xPos(1) - 30, yPos + 9, New StringFormat())
            ev.Graphics.DrawString("[kn]", printFont_A12f, Brushes.Black, xPos(1) + 60, yPos + 9, New StringFormat())
            ev.Graphics.DrawString("See-", printFont_A12f, Brushes.Black, xPos(2) + 10, yPos - 5, New StringFormat())
            ev.Graphics.DrawString("gang", printFont_A12f, Brushes.Black, xPos(2) + 10, yPos + 9, New StringFormat())
            ev.Graphics.DrawString("Luft-", printFont_A12f, Brushes.Black, xPos(2) + 80, yPos - 5, New StringFormat())
            ev.Graphics.DrawString("druck", printFont_A12f, Brushes.Black, xPos(2) + 80, yPos + 9, New StringFormat())
            ev.Graphics.DrawString("Wolken", printFont_A12f, Brushes.Black, xPos(3) + 50, yPos, New StringFormat())
            ev.Graphics.DrawString("KüG", printFont_A12f, Brushes.Black, xPos(4) + 40, yPos, New StringFormat())
            ev.Graphics.DrawString("Position", printFont_A12f, Brushes.Black, xPos(5) + 20, yPos, New StringFormat())
            ev.Graphics.DrawString("Antrieb", printFont_A12f, Brushes.Black, xPos(8) - 30, yPos, New StringFormat())
            ev.Graphics.DrawString("Distanz über Grund", printFont_A12f, Brushes.Black, xPos(9) - 10, yPos - 5, New StringFormat())
            ev.Graphics.DrawString("des Tages", printFont_A12f, Brushes.Black, xPos(8) + 50, yPos + 9, New StringFormat())
            ev.Graphics.DrawString("Segel", printFont_A12f, Brushes.Black, xPos(9) + 50, yPos + 9, New StringFormat())
            ev.Graphics.DrawString("Motor", printFont_A12f, Brushes.Black, xPos(10) + 20, yPos + 9, New StringFormat())
            zeile += 2
            yPos = 45 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))

            DoppelRechteck(50, 670, 287, 115, ev)
            zeile = 35
            yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Hafen Zielort", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = 60 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Anlegeart", printFont_A11, Brushes.Black, xPos(0) + 10, yPos, New StringFormat())
            ev.Graphics.DrawString(anlegeart, printFont_l12f, Brushes.Black, xPos(1) + 50, yPos + 2, New StringFormat())
            zeile += 1
            yPos = 65 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Gebühr ", printFont_A11, Brushes.Black, xPos(0) + 10, yPos, New StringFormat())
            ev.Graphics.DrawString(gebühr + " €", printFont_l12f, Brushes.Black, xPos(1) + 50, yPos + 2, New StringFormat())
            zeile += 1
            yPos = 70 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Müllertsorgung", printFont_A11, Brushes.Black, xPos(0) + 10, yPos, New StringFormat())
            If müll Then
                ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(1) + 50, yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(1) + 50, yPos, New StringFormat())
            End If
            zeile += 1
            yPos = 75 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Stromanschluß", printFont_A11, Brushes.Black, xPos(0) + 10, yPos, New StringFormat())
            If strom Then
                ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(1) + 50, yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(1) + 50, yPos, New StringFormat())
            End If

            DoppelRechteck(340, 670, 247, 115, ev)
            zeile = 35
            yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Motorstunden", printFont_A12f, Brushes.Black, xPos(3) - 10, yPos, New StringFormat())
            zeile += 1
            yPos = 60 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Tagesanfang", printFont_A11, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString(Tanf, printFont_l12f, Brushes.Black, xPos(4), yPos + 2, New StringFormat())
            zeile += 1
            yPos = 65 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Tagesende", printFont_A11, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString(taend, printFont_l12f, Brushes.Black, xPos(4), yPos + 2, New StringFormat())
            If diesel > "0" Then
                zeile += 1
                yPos = 70 + zeile * printFont_A11.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Kraftstoff", printFont_A11, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString(" l getankt", printFont_l12f, Brushes.Black, xPos(4) + 45, yPos, New StringFormat())
                ev.Graphics.DrawString(diesel, printFont_l12f, Brushes.Black, xPos(4) + 15, yPos + 2, New StringFormat())
                zeile += 1
                yPos = 75 + zeile * printFont_A11.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(" €", printFont_l12f, Brushes.Black, xPos(4) + 60, yPos, New StringFormat())
                ev.Graphics.DrawString(dKosten, printFont_l12f, Brushes.Black, xPos(4) + 15, yPos + 2, New StringFormat())
            End If

            DoppelRechteck(590, 670, 287, 115, ev)
            zeile = 35
            yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Tägliche Prüfung", printFont_A12f, Brushes.Black, xPos(6) - 60, yPos, New StringFormat())
            zeile += 1
            yPos = 60 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Bilge", printFont_A11, Brushes.Black, xPos(6) - 50, yPos, New StringFormat())
            If bilge Then
                ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            End If
            zeile += 1
            yPos = 65 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Wasser getankt", printFont_A11, Brushes.Black, xPos(6) - 50, yPos, New StringFormat())
            If Wasser Then
                ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            End If
            zeile += 1
            yPos = 70 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Ölstand", printFont_A11, Brushes.Black, xPos(6) - 50, yPos, New StringFormat())
            If öl Then
                ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            End If
            zeile += 1
            yPos = 75 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Batteriespannung", printFont_A11, Brushes.Black, xPos(6) - 50, yPos, New StringFormat())
            If Batterie Then
                ev.Graphics.DrawString("R", printFont_l12w2, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            Else
                ev.Graphics.DrawString("o", printFont_l12w, Brushes.Black, xPos(7) + 25, yPos, New StringFormat())
            End If

            DoppelRechteck(880, 670, 250, 115, ev)
            zeile = 35
            yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Tagessumme", printFont_A12f, Brushes.Black, xPos(8) + 30, yPos, New StringFormat())
            zeile += 2
            yPos = 70 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Vortrag", printFont_A12f, Brushes.Black, xPos(8) + 30, yPos, New StringFormat())
            zeile += 2
            yPos = 75 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Gesamt", printFont_A12f, Brushes.Black, xPos(8) + 30, yPos, New StringFormat())

            summeTmotor = 0
            summeTsegel = 0
            zeile = 2
        End If

    End Sub
    Private Sub zusammenfassT(leftMargin, topMargin, ev)
        yPos = topMargin + zeile * printFont_E35f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Zusammenfassung", printFont_E35f, Brushes.Black, xPos(4), yPos, New StringFormat())
        DoppelRechteck(50, 110, 1080, 650, ev)
        zeile += 4
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Nr.", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Tag", printFont_A12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Zeit", printFont_A12f, Brushes.Black, xPos(1) + 40, yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Startort", printFont_A12f, Brushes.Black, xPos(2), yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Tag", printFont_A12f, Brushes.Black, xPos(4) - 30, yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Zeit", printFont_A12f, Brushes.Black, xPos(5) - 30, yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Ziel", printFont_A12f, Brushes.Black, xPos(5) + 30, yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Wind-", printFont_A12f, Brushes.Black, xPos(7) + 30, yPos - 5, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Richtung", printFont_A12f, Brushes.Black, xPos(7) - 10, yPos + 9, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("[kn]", printFont_A12f, Brushes.Black, xPos(7) + 75, yPos + 9, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Seemeilen", printFont_A12f, Brushes.Black, xPos(9), yPos - 5, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Segel", printFont_A12f, Brushes.Black, xPos(8) + 50, yPos + 9, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Motor", printFont_A12f, Brushes.Black, xPos(9) + 30, yPos + 9, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Gesamt", printFont_A12f, Brushes.Black, xPos(10) + 10, yPos + 9, New StringFormat()) ' Winrichtung
        zeile += 2
        yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))

    End Sub
    Private Sub zusammenfassW(leftMargin, topMargin, ev)
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(zeilennr, printFont_l12f, Brushes.Black, xPos(0), yPos, New StringFormat()) ' Nr.
        If Not DBNull.Value.Equals(row(2)) Then ev.Graphics.DrawString(row(2), printFont_l12f, Brushes.Black, xPos(0) + 40, yPos, New StringFormat()) ' Tag
        If Not DBNull.Value.Equals(row(5)) Then ev.Graphics.DrawString(row(5), printFont_l12f, Brushes.Black, xPos(1) + 40, yPos, New StringFormat()) ' Zeit
        If Not DBNull.Value.Equals(row(6)) Then ev.Graphics.DrawString(row(6), printFont_l12f, Brushes.Black, xPos(2), yPos, New StringFormat()) ' Start
        If Not DBNull.Value.Equals(row(7)) Then ev.Graphics.DrawString(row(7), printFont_l12f, Brushes.Black, xPos(4) - 30, yPos, New StringFormat()) ' Tag
        If Not DBNull.Value.Equals(row(8)) Then ev.Graphics.DrawString(row(8), printFont_l12f, Brushes.Black, xPos(5) - 30, yPos, New StringFormat()) ' Zeit
        If Not DBNull.Value.Equals(row(9)) Then ev.Graphics.DrawString(row(9), printFont_l12f, Brushes.Black, xPos(5) + 30, yPos, New StringFormat()) ' Ziel
        If Not DBNull.Value.Equals(row(10)) Then ev.Graphics.DrawString(row(10), printFont_l12f, Brushes.Black, xPos(7) + 10, yPos, New StringFormat()) ' Richtung
        If IsNumeric(row(11)) Then
            hh = row(11)
            text = Format$(hh, "#0")
            sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
            rechts = xPos(8) - sSize.Width.ToString
            If Not DBNull.Value.Equals(row(11)) Then ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' kn
        End If
        hh = row(12)
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(9) - sSize.Width.ToString
        If Not DBNull.Value.Equals(row(12)) Then ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' segel
        hh = row(13)
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString - 20
        If Not DBNull.Value.Equals(row(13)) Then ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' motor
        hh = row(14)
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString + 70
        If Not DBNull.Value.Equals(row(14)) Then ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' gesamt
        zeile += 1
    End Sub
  
    Private Sub zuasmSumme(leftMargin, topMargin, ev)
        zeile += 1
        yPos = 45 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Summe", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat()) ' Winrichtung
        hh = summeGsegel
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(9) - sSize.Width.ToString
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' segel
        hh = summeGmotor
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString - 20
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel
        hh = summeGsegel + summeGmotor
        text = Format$(hh, "#0.0")
        sSize = ev.Graphics.MeasureString(text, printFont_l12f, 1000)
        rechts = xPos(10) - sSize.Width.ToString + 70
        ev.Graphics.DrawString(text, printFont_l12f, Brushes.Black, rechts, yPos, New StringFormat()) ' Ziel
       End Sub
    Private Sub MängelK(leftMargin, topMargin, ev)
        yPos = topMargin + zeile * printFont_E35f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Technische Mängel", printFont_E35f, Brushes.Black, xPos(4), yPos, New StringFormat())
        zeile += 1
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Bootsname: ", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString(Bootsname, printFont_l12f, Brushes.Black, xPos(1), yPos + 2, New StringFormat()) ' Tag
        DoppelRechteck(50, 110, 1080, 650, ev)
        zeile += 3
        yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Datum", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Betrifft", printFont_A12f, Brushes.Black, xPos(1), yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Defekt", printFont_A12f, Brushes.Black, xPos(3), yPos, New StringFormat()) ' Winrichtung
        ev.Graphics.DrawString("Auswirkungen", printFont_A12f, Brushes.Black, xPos(8), yPos, New StringFormat()) ' Winrichtung
        zeile += 1
        yPos = 55 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
        '       zeile += 1
    End Sub
    Private Sub MängelT(leftMargin, topMargin, ev)
        Dim Hilfszeile As Integer
        zeile += 1
        Hilfszeile = zeile
        yPos = topMargin + 4 + zeile * printFont_l12f.GetHeight(ev.Graphics)
        '       yPos = 50 + zeile * printFont_A11.GetHeight(ev.Graphics)
        If Not DBNull.Value.Equals(row(2)) Then ev.Graphics.DrawString(row(2), printFont_l12f, Brushes.Black, xPos(0), yPos, New StringFormat()) ' Tag
        If Not DBNull.Value.Equals(row(5)) Then ev.Graphics.DrawString(row(5), printFont_l12f, Brushes.Black, xPos(1), yPos, New StringFormat()) ' Tag
        If Not DBNull.Value.Equals(row(6)) Then
            If row(6) > " " And Len(row(6)) > 55 Then
                zeile = LangXText.LangXtextDrucken(row(6), zeile - 4, yPos, printFont_l12f, xPos(3), ev, 55) + 4
            Else
                If Not DBNull.Value.Equals(row(6)) Then ev.Graphics.DrawString(row(6), printFont_l12f, Brushes.Black, xPos(3), yPos, New StringFormat()) ' Tag
            End If
        End If

        '      If Not DBNull.Value.Equals(row(7)) Then ev.Graphics.DrawString(row(7), printFont_l12f, Brushes.Black, xPos(8), yPos, New StringFormat()) ' Tag
        If Not DBNull.Value.Equals(row(7)) Then
            If row(7) > " " And Len(row(7)) > 35 Then
                zeile = LangXText.LangXtextDrucken(row(7), Hilfszeile - 4, yPos, printFont_l12f, xPos(8), ev, 35) + 4
            Else
                If Not DBNull.Value.Equals(row(7)) Then ev.Graphics.DrawString(row(7), printFont_l12f, Brushes.Black, xPos(8), yPos, New StringFormat()) ' Tag
            End If
        End If
        zeile += 1
    End Sub

    Private Sub DoppelRechteck(posx, posy, breite, hoehe, ev)
        ev.graphics.drawrectangle(Pens.Black, posx, posy, breite, hoehe)
        ev.graphics.drawrectangle(Pens.Black, posx - 2, posy - 2, breite + 5, hoehe + 4)
    End Sub
    Private Sub lieneal(leftmargin, topmargin, ev)
        zeile += 38
        yPos = topmargin + zeile * printFont_A12f.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("|0", printFont_A12f, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("|1", printFont_A12f, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("|2", printFont_A12f, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("|3", printFont_A12f, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("|4", printFont_A12f, Brushes.Black, xPos(4), yPos, New StringFormat())
        ev.Graphics.DrawString("|5", printFont_A12f, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString("|6", printFont_A12f, Brushes.Black, xPos(6), yPos, New StringFormat())
        ev.Graphics.DrawString("|7", printFont_A12f, Brushes.Black, xPos(7), yPos, New StringFormat())
        ev.Graphics.DrawString("|8", printFont_A12f, Brushes.Black, xPos(8), yPos, New StringFormat())
        ev.Graphics.DrawString("|9", printFont_A12f, Brushes.Black, xPos(9), yPos, New StringFormat())
        ev.Graphics.DrawString("|6", printFont_A12f, Brushes.Black, xPos(10), yPos, New StringFormat())

    End Sub

    '                                                               PrintLeer

    Private Sub pd_printleer(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim rNbr As Integer
        leftMargin = ev.MarginBounds.Left
        topMargin = ev.MarginBounds.Top
        zeile = 0
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont_A10.GetHeight(ev.Graphics)
        xPos(0) = leftMargin - 50
        xPos(1) = xPos(0) + 100
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 100
        xPos(5) = xPos(4) + 100
        xPos(6) = xPos(5) + 100
        xPos(7) = xPos(6) + 100
        xPos(8) = xPos(7) + 100
        xPos(9) = xPos(8) + 100
        xPos(10) = xPos(9) + 100
        row = dt.Rows(0)
        rNbr = lastRow
        row = dt.Rows(rNbr)
        topMargin -= 60
        While zeile < (linesPerPage - 1)
            If row Is Nothing Then GoTo druckende
            row = dt.Rows(rNbr)
            If DBNull.Value.Equals(row(0)) Then GoTo weiter
            Select Case row(0)
                Case "1"
                    If Not DBNull.Value.Equals(row(23)) Then
                        If row(23) > " " Then
                            If My.Computer.FileSystem.FileExists(row(23)) Then
                                logo = Image.FromFile(Trim$(row(23)))
                                Dim imgWidth As Integer = logo.Width
                                Dim imgHeight As Integer = logo.Height
                                Dim imgRatio As Single
                                If imgHeight > imgWidth Then
                                    '                                     Hochformat
                                    If imgHeight > 600 Then
                                        imgRatio = imgHeight / 600
                                        imgWidth = imgWidth / imgRatio
                                        imgHeight = 600
                                    End If
                                    If imgWidth > 550 Then
                                        imgRatio = imgWidth / 550
                                        imgHeight = imgHeight / imgRatio
                                        imgWidth = 550
                                    End If
                                    ev.Graphics.DrawImage(logo, New Rectangle(xPos(5) + 20, topMargin + 70, imgWidth, imgHeight))
                                    caverh(leftMargin, topMargin, ev)
                                Else
                                    '                                    Breitformat
                                    If imgHeight > 300 Then
                                        imgRatio = imgHeight / 300
                                        imgWidth = imgWidth / imgRatio
                                        imgHeight = 300
                                   End If
                                    ev.Graphics.DrawImage(logo, New Rectangle(xPos(6) - (imgWidth / 2), topMargin + 70, imgWidth, imgHeight))
                                    caverb(leftMargin, topMargin, ev)
                                End If
                            End If
                        End If
                    End If
                    '                  caverh(leftMargin, topMargin, ev)
                    Bootsname = row(31)
                    lezterTag = row(2)
                    zeile = 50
                Case "2"
                    törndaten(leftMargin, topMargin, ev)
                    '             gefRoute = row(9)
                    Feld1 = 2
                Case "3"
                    If erstecrew Then
                        zeile = 6
                        zs = 4
                    Else
                        zs = 0
                    End If
                    Crew(leftMargin, topMargin, row(4), ev)
                    erstecrew = False
                    Feld1 = 3
                Case "4"
                    If row(0) > Feld1 Then
                        '                     rNbr -= 1
                        Feld1 = 4
                        GoTo Neueseite
                    End If
                    '                  zeile = 50
                    Sidatum = "_______________ "
                    SiAnf = "_______"
                    siEnde = "________"
                Case "5"
                    Sicherheit(leftMargin, topMargin, ev)
                    zeile = 50
                    Feld1 = 5
                Case "6"
                    ausgangsort = "_______________________ "
                    zielort = "_______________________ "
                    Tanf = "       _____________ "
                    taend = "       _____________ "
                    datumr = CDate(row(2))
                    datuml = CDate(lezterTag)
                    Select Case row(1)
                        Case "1"
                            Rasterdoku(leftMargin, topMargin, ev)
                            Logdoku(leftMargin, topMargin, ev)
                        Case "2"
                            Wachedienst(leftMargin, topMargin, ev)
                            rNbr += 1
                            row = dt.Rows(rNbr)
                            If row(1) = "3" Then
                                SeitenNummer += 1
                                GoTo Neueseite
                            End If
                            rNbr -= 1
                        Case "3"
                            FixSeite(leftMargin, topMargin, ev)
                            Rasterlog(leftMargin, topMargin, ev)
                            SeitenNummer += 1
                            zeile = 50
                    End Select
            Case "7"
                    If Feld1 = 7 Then GoTo weiter
                    zusammenfassT(leftMargin, topMargin, ev)
                    zeile = 3
                    yPos = 140 + zeile * printFont_A11.GetHeight(ev.Graphics)
                    ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
                    For i = 1 To 15
                        zeile += 2
                        yPos = 140 + zeile * printFont_A11.GetHeight(ev.Graphics)
                        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
                    Next

                    ev.Graphics.DrawLine(Pens.Black, New Point(85, 110), New Point(80, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(170, 110), New Point(170, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(240, 110), New Point(240, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(410, 110), New Point(410, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(495, 110), New Point(495, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(565, 110), New Point(565, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(735, 110), New Point(735, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(820, 135), New Point(820, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(880, 110), New Point(880, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(960, 135), New Point(960, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(1045, 135), New Point(1045, 760))
                    Feld1 = 7
                    rNbr += 1
                    GoTo Neueseite
                Case "8"
                    MängelK(leftMargin, topMargin, ev)
                    zeile = 4
                    yPos = 110 + zeile * printFont_A11.GetHeight(ev.Graphics)
                    ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
                    For i = 1 To 16
                        zeile += 2
                        yPos = 110 + zeile * printFont_A11.GetHeight(ev.Graphics)
                        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
                    Next

                    ev.Graphics.DrawLine(Pens.Black, New Point(125, 110), New Point(125, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(340, 110), New Point(340, 760))
                    ev.Graphics.DrawLine(Pens.Black, New Point(840, 110), New Point(840, 760))

                    rNbr += 1
            End Select
weiter:
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        '---------------------------  Schleifenende ----------------------------
   
Neueseite:
        zeile = 0
        lastRow = rNbr
        '  If more lines exist, print another page.
        ev.HasMorePages = True
        If Not (row Is Nothing) Then
        Else
            '           leZei = True
            ev.HasMorePages = False
        End If
druckende:
    End Sub
    Private Sub Rasterlog(leftMargin, topMargin, ev)
        ev.Graphics.DrawLine(Pens.Black, New Point(115, 78), New Point(115, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(200, 105), New Point(200, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(253, 78), New Point(253, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(318, 78), New Point(318, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(390, 78), New Point(390, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(480, 78), New Point(480, 787))
        ev.Graphics.DrawLine(Pens.Black, New Point(550, 78), New Point(550, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(810, 78), New Point(810, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(900, 78), New Point(900, 660))
        ev.Graphics.DrawLine(Pens.Black, New Point(990, 105), New Point(990, 787))
        ev.Graphics.DrawLine(Pens.Black, New Point(1060, 105), New Point(1060, 787))


        zeile = 3
        yPos = 95 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
        For i = 1 To 14
            zeile += 2
            yPos = 95 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1130, yPos))
        Next

        zeile += 4
        yPos = 95 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(880, yPos), New Point(1130, yPos))
        '        ev.Graphics.DrawLine(Pens.Black, New Point(340, yPos), New Point(590, yPos))
        zeile += 2
        yPos = 95 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(880, yPos), New Point(1130, yPos))
        zeile += 0
        yPos = 95 + zeile * printFont_A11.GetHeight(ev.Graphics)
        '       ev.Graphics.DrawLine(Pens.Black, New Point(340, yPos), New Point(590, yPos))

    End Sub
    Private Sub Rasterdoku(leftMargin, topMargin, ev)
        zeile = 3
        yPos = 90 + zeile * printFont_A11.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1100, yPos))
        For i = 1 To 7
            zeile += 2
            yPos = 95 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(1100, yPos))
        Next
        zeile += 5
        For i = 1 To 8
            zeile += 2
            yPos = 90 + zeile * printFont_A11.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(50, yPos), New Point(500, yPos))
        Next

    End Sub
    Private Sub test(leftMargin, topMargin, ev, rnbr)
        ausgangsort = "_______________________ "
        zielort = "_______________________ "
        Tanf = "       _____________ "
        taend = "       _____________ "
        datumr = CDate(row(2))
        datuml = CDate(lezterTag)
        If row(1) = "1" And datuml >= datumr Then
            Rasterdoku(leftMargin, topMargin, ev)
            Logdoku(leftMargin, topMargin, ev)
        End If
        If row(1) = "2" And datuml >= datumr Then          '          Wachedienst
            If datDok1 = row(2) Then
                If pkt6 Then
                    Rasterdoku(leftMargin, topMargin, ev)
                    Logdoku(leftMargin, topMargin, ev)
                    pkt6 = False
                End If
                Wachedienst(leftMargin, topMargin, ev)
            Else
                If fix Then
                    If datDok1 = Nothing Then
                    Else
                        FixSeite(leftMargin, topMargin, ev)
                        Rasterlog(leftMargin, topMargin, ev)
                        SeitenNummer += 1
                    End If
                    fix = False
                    datDok1 = row(2)
                    pkt6 = True
                Else
                    fix = True
                End If
                GoTo Neueseite
            End If
        End If
        rNbr += 1
        row = dt.Rows(rNbr)
        If row(0) = "7" Then
            If fix = False Then
                rNbr -= 1
                fix = True
                GoTo Neueseite
            End If
            FixSeite(leftMargin, topMargin, ev)
            Rasterlog(leftMargin, topMargin, ev)
            SeitenNummer += 1
            GoTo Neueseite
        End If
        rNbr -= 1
        Feld1 = 6
neueseite:  ' löschen im Original
    End Sub
End Class
