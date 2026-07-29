Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutMA
    '                                                                                           Drucken Personenbezogene Auswertung
    Public speicherbild As String
    Private printFont As Font
    Private printFFont As Font
    Private printFFontW As Font
    Private printF14Font As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim SummeCrewSm As Single
    Dim logo As Image
    Dim btg As Single
    Dim smg As Single
    Dim ssg As Single
    Dim sgg As Single
    Dim bts As Single
    Dim sms As Single
    Dim sss As Single
    Dim sgs As Single
    Dim nfg As Single
    Dim fb2g As Single
    Dim fb3g As Single
    Dim nfs As Single
    Dim nfas As Single
    Dim nfa As Single
    Dim fb2s As Single
    Dim fb3s As Single
    Dim linesPerPage As Single = 0
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim xPos(7) As Single
     Dim ij As Integer = 0
    Dim zeile As Integer = 0
    Public zs As Integer
    Public zr As Integer
    Public zeilenanf As Single
    Public x As New Leerstelle
    Public routelange As Integer
    Public aaa As String
    Public zeilentext As String
    Dim stern As String = " "
    Dim mbtg As Single
    Dim msmg As Single
    Dim mssg As Single
    Dim msgg As Single
    Dim mbts As Single
    Dim msms As Single
    Dim msss As Single
    Dim msgs As Single
    Dim mnfg As Single
    Dim mfb2g As Single
    Dim mfb3g As Single
    Dim mnfs As Single
    Dim mnfas As Single
    Dim mnfa As Single
    Dim mfb2s As Single
    Dim mfb3s As Single
    Dim leZei As Boolean = False
    Dim ErsteZeile As Boolean = True
    Dim rechts As Single
    Dim text As String
    Dim sSize As SizeF
    Dim aus As String = ""
    Dim SeitenNummer As Integer = 1
    Dim skipper As String
    Public Sub PrintMeilen(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
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
        Dim linesPerPage As Single = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim rNbr As Integer
        Dim von As String
        Dim bis As String
        Dim hh As Single
        Dim quelle As String
        leftMargin = ev.MarginBounds.Left
        topMargin = ev.MarginBounds.Top

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 50
        xPos(1) = xPos(0) + 30
        xPos(2) = xPos(1) + 180
        xPos(3) = xPos(2) + 150
        xPos(4) = xPos(3) + 100
        xPos(5) = xPos(4) + 80
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 10)
        printFFont = New Font("Arial", 10, FontStyle.Bold)
        printFFontW = New Font("Wingdings", 12, FontStyle.Bold)
        '      If row(0) = "Revier" Then
        '       If leZei Then
        'summenzeile(ev)
        'GoTo ende
        'End If
        row = dt.Rows(0)
        rNbr = lastRow
        row = dt.Rows(rNbr)
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        yypos = yPos
        If rNbr = 0 Then
            skipper = row(12)
        End If
        If row(0) <> "Revier" And row(0) <> "Nautische Ausbildung" Then
            ueberschriften(ev)
        End If


        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            Select Case row(0)
                Case "Summe"
                    zeile = 100
                    ' nächstes rNr einlesen
                Case "Nautische Ausbildung"
                         If aus <> "Revier" Then
                            printFont = New Font("Arial", 18, FontStyle.Bold)
                            printF14Font = New Font("Arial", 14, FontStyle.Bold)
                            '           zeile = -1
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString("Nautische Ausbildung", printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                            '                                                                                           Auswertungsperson
                            sSize = ev.Graphics.MeasureString(skipper, printF14Font, 1000)
                            rechts = xPos(3) - sSize.Width.ToString / 2 + 85
                            zeile += 1
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString(skipper, printF14Font, Brushes.Black, rechts, yPos, New StringFormat())
                            zeile += 7
                            printFont = New Font("Arial", 10)
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Kurs ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                        ev.Graphics.DrawString("Ausbildende ", printFont, Brushes.Black, xPos(2) + 20, yPos, New StringFormat())
                        ev.Graphics.DrawString("Kursdauer", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                        ev.Graphics.DrawString("Kursbeginn", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                        zeile += 1
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                            aus = "Revier"
                        End If
                        '                 zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

                    hh = row(6)                                                              'Ausbildungsdauer
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 30
                    ev.Graphics.DrawString(text + " Std.", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    ev.Graphics.DrawString(row(10), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                 ' Kurs
                    ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(2) + 20, yPos, New StringFormat())                        ' Ausbildende
                    ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(6), yPos, New StringFormat())                        ' Kursbeginn

                Case "Revier"
                    If ErsteZeile Then
                        summenzeile(ev)
                        ErsteZeile = False
                        rNbr -= 1
                        '                       Exit While
                    Else
                        If Meilenauswertung.ckb_Revieruebersicht.Checked Then
                            If aus <> "Revier" Then
                                printFont = New Font("Arial", 18, FontStyle.Bold)
                                printF14Font = New Font("Arial", 14, FontStyle.Bold)
                                '           zeile = -1
                                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                                ev.Graphics.DrawString("Auswertungen der Törns", printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
                                '                                                                                           Auswertungsperson
                                sSize = ev.Graphics.MeasureString(skipper, printF14Font, 1000)
                                rechts = xPos(3) - sSize.Width.ToString / 2 + 85
                                zeile += 1
                                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                                ev.Graphics.DrawString(skipper, printF14Font, Brushes.Black, rechts, yPos, New StringFormat())
                                zeile += 7
                                printFont = New Font("Arial", 10)
                                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                                ev.Graphics.DrawString("Törns  Revier ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                                ev.Graphics.DrawString("Seemeilen ", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                                zeile += 1
                                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                                ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                                aus = "Revier"
                            End If
                            '                 zeile += 1
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

                            hh = row(6)
                            text = Format$(hh, "#0")
                            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                            rechts = xPos(0) - sSize.Width.ToString + 30
                            ev.Graphics.DrawString(text + "x", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                            If Len(row(10)) > 90 Then
                                Dim strich As Integer
                                Dim laenge As Integer = Len(row(10))
                                strich = row(10).ToString.IndexOf(" - ", 0)
                                aaa = row(10)
                                ev.Graphics.DrawString(aaa.Substring(0, strich), printFont, Brushes.Black, xPos(0) + 45, yPos, New StringFormat())
                                zeile += 1
                                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                                ev.Graphics.DrawString(aaa.Substring(strich, laenge - strich), printFont, Brushes.Black, xPos(1) + 45, yPos, New StringFormat())
                            Else
                                ev.Graphics.DrawString(row(10), printFont, Brushes.Black, xPos(0) + 45, yPos, New StringFormat())
                            End If

                            hh = row(3)
                            text = Format$(hh, "#0.0")
                            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                            rechts = xPos(6) - sSize.Width.ToString + 50
                            ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                        End If
                    End If
                    SummeCrewSm = 0
                Case Else
                    ij += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    If row(17) = 1 Then
                        ev.Graphics.DrawString("C", printFFontW, Brushes.Black, xPos(0) - 15, yPos, New StringFormat())
                    End If
                    ev.Graphics.DrawString(ij, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(15) + " " + row(10), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    sSize = ev.Graphics.MeasureString(row(7), printFont, 1000)
                    rechts = xPos(3) - sSize.Width.ToString + 60
                    ev.Graphics.DrawString(row(7), printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    If row(4) <> "*" Then
                        hh = row(4)
                        text = Format$(hh, "#0.0")
                        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    Else
                        sSize = ev.Graphics.MeasureString(row(4), printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(row(4), printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    End If
                    hh = row(8)
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(6) - sSize.Width.ToString + 60
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())

                    '                             2. Zeile
                    If row(1) > "" Then
                        von = row(1).substring(0, 10)
                    Else
                        von = "  "
                    End If
                    If row(2) > "" Then
                        bis = row(2).substring(0, 10)
                    Else
                        bis = "  "
                    End If
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(von, printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString(" - " + bis, printFont, Brushes.Black, xPos(1) + 70, yPos, New StringFormat())
                    ev.Graphics.DrawString(row(11), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    sSize = ev.Graphics.MeasureString(row(6), printFont, 100)
                    rechts = xPos(3) - sSize.Width.ToString + 50
                    ev.Graphics.DrawString(row(6).ToString + "/" + row(14).ToString, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    If row(3) <> "*" Then
                        hh = row(3)
                        text = Format$(hh, "#0.0")
                        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    Else
                        sSize = ev.Graphics.MeasureString(row(3), printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(row(3), printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    End If
                    If row(5) <> "*" Then
                        hh = row(5)
                        text = Format$(hh, "#0.0")
                        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                        rechts = xPos(5) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    Else
                        sSize = ev.Graphics.MeasureString(row(5), printFont, 1000)
                        rechts = xPos(5) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    End If
                    hh = row(9)
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(6) - sSize.Width.ToString + 60
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    quelle = row(13)
                    zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(1), ev, linesPerPage)
                    If Not DBNull.Value.Equals(row(16)) And Meilenauswertung.CheckBox1.Checked = True Then
                        If row(16) > " " Then
                            quelle = "Bemerkung: " + row(16)
                            zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(1), ev, linesPerPage)
                        End If
                    End If

                    aaa = row(10)
                    If row(15) = "Segelboot" Then
                        btg += row(7).ToString
                        If row(4).ToString > "" Then
                            If row(4).ToString <> "*" Then
                                smg += row(4).ToString
                                ssg += row(3).ToString
                            Else
                                stern = "*"
                            End If
                        End If
                        sgg += row(5).ToString
                        nfg += row(6).ToString
                        nfa += row(14).ToString
                        fb2g += row(8).ToString
                        fb3g += row(9).ToString
                        If row(11) = row(12) Then
                            bts += row(7).ToString
                            If row(4).ToString > "" Then
                                If row(4).ToString <> "*" Then
                                    sms += row(4).ToString
                                    sss += row(3).ToString
                                End If
                            End If
                            sgs += row(5).ToString
                            nfs += row(6).ToString
                            nfas += row(14).ToString
                            fb2s += row(8).ToString
                            fb3s += row(9).ToString
                        End If
                    Else
                        mbtg += row(7).ToString
                        If row(4).ToString > "" Then
                            If row(4).ToString <> "*" Then
                                msmg += row(4).ToString
                                mssg += row(3).ToString
                            Else
                                stern = "*"
                            End If
                        End If
                        msgg += row(5).ToString
                        mnfg += row(6).ToString
                        mnfa += row(14).ToString
                        mfb2g += row(8).ToString
                        mfb3g += row(9).ToString
                        If row(11) = row(12) Then
                            mbts += row(7).ToString
                            If row(4).ToString > "" Then
                                If row(4).ToString <> "*" Then
                                    msms += row(4).ToString
                                    msss += row(3).ToString
                                End If
                            End If
                            msgs += row(5).ToString
                            mnfs += row(6).ToString
                            mnfas += row(14).ToString
                            mfb2s += row(8).ToString
                            mfb3s += row(9).ToString
                        End If
                    End If
                    zeile += 1
            End Select
            zeile += 1
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If

        End While

        lastRow = rNbr
        '  If more lines exist, print another page.
        ev.HasMorePages = True
        zeile = 0
        If Not (row Is Nothing) Then
        Else
            '           leZei = True
            ev.HasMorePages = False
        End If

ende:
        yPos = topMargin + 64 * printFont.GetHeight(ev.Graphics)
        If stern = "*" And zeile < 64 Then
            ev.Graphics.DrawString("*      Die Trennung sm Segel und Motor wurde nicht dokumentiert und fehlt in den Spaltensummen.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            stern = ""
        Else
            ev.Graphics.DrawString("       Logbuch oder Logbuchkopie ist vorhanden.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("C", printFFontW, Brushes.Black, xPos(0), yPos, New StringFormat())
        End If
        If zeile < 64 Then
            ev.Graphics.DrawString("Seite: " + SeitenNummer.ToString, printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
            SeitenNummer += 1
            aus = " "
        End If
    End Sub
    Private Sub summenzeile(ByVal ev)
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        ueberschriften(ev)
          segelsumme(ev)
        If mbtg > 0 Then
            motorsumme(ev)
        End If
        '       ev.HasMorePages = False
        zeile = 100
    End Sub
    Private Sub motorsumme(ByVal ev)
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) + 8
        '     ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        yPos = yPos + 8
        ev.Graphics.DrawString("Summen gesamt auf einer Motorjacht", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        sSize = ev.Graphics.MeasureString(mbtg, printFFont, 100)
        rechts = xPos(3) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(mbtg, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(msmg, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(4) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(mfb2g, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(6) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())

        '                             2. Zeile
        zeile += 2
        yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
        sSize = ev.Graphics.MeasureString(nfg, printFFont, 100)
        rechts = xPos(3) - sSize.Width.ToString + 50
        ev.Graphics.DrawString(mnfg.ToString + "/" + mnfa.ToString, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(mssg, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(4) - sSize.Width.ToString + 60
        '    ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(msgg, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(5) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(mfb3g, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(6) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())

        '                           als Skipper
        If mbts >= 1 Then
            zeile += 1
            yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("davon als Skipper", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            sSize = ev.Graphics.MeasureString(bts, printFFont, 100)
            rechts = xPos(3) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(mbts, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(msms, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(4) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(mfb2s, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(6) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())

            '                             2. Zeile
            zeile += 1
            yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
            sSize = ev.Graphics.MeasureString(nfs, printFFont, 100)
            rechts = xPos(3) - sSize.Width.ToString + 50
            ev.Graphics.DrawString(mnfs.ToString + "/" + mnfas.ToString, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(msss, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(4) - sSize.Width.ToString + 60
            '             ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(msgs, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(5) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(mfb3s, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(6) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        End If
        zeile += 1
        yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Nachtansteuerungen ohne elektronische Hilfsmittel!", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())

    End Sub
    Private Sub segelsumme(ByVal ev)
        '        zeile += 5
        '       yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) + 8
        '      ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        '        zeile += 1
        yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
        '       yPos = yPos + 8
        ev.Graphics.DrawString("Summen gesamt auf einer Segeljacht", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        sSize = ev.Graphics.MeasureString(btg, printFFont, 100)
        rechts = xPos(3) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(btg, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(smg, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(4) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(fb2g, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(6) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())

        '                             2. Zeile
        zeile += 1
        yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
        sSize = ev.Graphics.MeasureString(nfg, printFFont, 100)
        rechts = xPos(3) - sSize.Width.ToString + 50
        ev.Graphics.DrawString(nfg.ToString + "/" + nfa.ToString, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(ssg, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(4) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(sgg, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(5) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        text = Format$(fb3g, "N1")
        sSize = ev.Graphics.MeasureString(text, printFFont, 100)
        rechts = xPos(6) - sSize.Width.ToString + 60
        ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())

        '                           als Skipper
        If bts > 1 Then
            zeile += 2
            yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("davon als Skipper", printFFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            sSize = ev.Graphics.MeasureString(bts, printFFont, 100)
            rechts = xPos(3) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(bts, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(sms, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(4) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(fb2s, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(6) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())

            '                             2. Zeile
            zeile += 1
            yPos = topMargin + zeile * printFFont.GetHeight(ev.Graphics)
            sSize = ev.Graphics.MeasureString(nfs, printFFont, 100)
            rechts = xPos(3) - sSize.Width.ToString + 50
            ev.Graphics.DrawString(nfs.ToString + "/" + nfas.ToString, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(sss, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(4) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(sgs, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(5) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
            text = Format$(fb3s, "N1")
            sSize = ev.Graphics.MeasureString(text, printFFont, 100)
            rechts = xPos(6) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(text, printFFont, Brushes.Black, rechts, yPos, New StringFormat())
        End If

    End Sub
    Private Sub ueberschriften(ByVal ev)
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
             printFont = New Font("Arial", 18, FontStyle.Bold)
            printF14Font = New Font("Arial", 14, FontStyle.Bold)
        '           zeile = -1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Auswertungen der Törns", printFont, Brushes.Black, xPos(3) - 70, yPos, New StringFormat())
            '                                                                                           Auswertungsperson
            sSize = ev.Graphics.MeasureString(skipper, printF14Font, 1000)
            rechts = xPos(3) - sSize.Width.ToString / 2 + 85
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(skipper, printF14Font, Brushes.Black, rechts, yPos, New StringFormat())
            zeile += 7
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin + 20, New StringFormat())

            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString("Törnbezeichnung", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString("Bootsname", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString("Bordtage", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString("sm Motor", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
            ev.Graphics.DrawString("sm im FB3", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("von      -       bis", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString("Skipper", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString("Nachtfahrten", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString("sm Segel", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
            ev.Graphics.DrawString("sm gesamt", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
            ev.Graphics.DrawString("sm im FB4", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("/-ansteuerungen", printFont, Brushes.Black, xPos(3) - 10, yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
            zeile += 1

    End Sub
End Class
