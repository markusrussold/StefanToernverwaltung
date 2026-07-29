Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintoutBK                                                        ' Bordkassa
    Inherits System.Windows.Forms.Form
    Public speicherbild As String
    Private printFont As Font
    Private printFfont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Private anzahl As String
    Dim logo As Image
    Public var As Single
    Dim mmsi As String
    Dim bootsname As String = " "
    Dim rNbr As Integer
    Dim termin As String
    Dim Brush As New SolidBrush(Color.LightGray)
    Dim rechts As Single
    Dim textN As String
    Dim sSize As SizeF
    Dim xPos(7) As Single
    Dim mittel As Single
    Dim Teilnehmer As Integer = 0
    Dim summeEinzahlungen As Single = 0
    Dim summeauszahlungen As Single = 0
    Public Sub PrintBordkassa(ByVal tIn As DataTable)
        '                                                                               Bordkassa drucken
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        dt = tIn
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
        Dim yPos As Single = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Single = 2
        Dim zz As Single = 1.2
        Dim xxx As Integer = 1
        Dim hh As Single
        Dim yyy As Integer = 0
        Dim zzz As Boolean = True
        Dim datumwechsel As String
        Dim saldo As Single
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = 40
        xPos(1) = xPos(0) + 100
        xPos(2) = xPos(1) + 80
        xPos(3) = xPos(2) + 120
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 120
        xPos(6) = xPos(5) + 100
        xPos(7) = xPos(6) + 100
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        If bootsname <> " " Then zeile = 5
        printFfont = New Font("Arial", 10, FontStyle.Bold)
        row = dt.Rows(rNbr)
        While zeile < (linesPerPage)
            row = dt.Rows(rNbr)
            Select Case row(0)
                Case 0                                                                      ' Kassa Ein- und Ausgaben
                    summeauszahlungen = row(2)
                Case 1                                                                      ' Kassa Ein- und Ausgaben
                    If yyy = 0 Then
                        printFont = New Font("Arial", 24, FontStyle.Bold)
                        ev.Graphics.DrawString("Bordkassa Abrechnung", printFont, Brushes.Black, xPos(3) - 30, topMargin, New StringFormat())
                        printFont = New Font("Arial", 14)

                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        bootsname = Bordkassa.Bootsname
                        ev.Graphics.DrawString("Boot: " + bootsname, printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6) + 50, yPos, New StringFormat())
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        termin = Bordkassa.Termin
                        ev.Graphics.DrawString(termin, printFont, Brushes.Black, xPos(3) + 40, yPos, New StringFormat())
                        printFont = New Font("Arial", 10)

                        zeile += 5
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Kassa", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                        ev.Graphics.DrawString("Einnahmen €: ", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                        hh = row(2)
                        textN = Format$(hh, "#0.00")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(2) - sSize.Width.ToString + 70
                        ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())

                        ev.Graphics.DrawString("Ausgaben €: ", printFont, Brushes.Black, xPos(3) + 20, yPos, New StringFormat())
                        hh = row(3)
                        textN = Format$(hh, "#0.00")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 80
                        ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())

                        ev.Graphics.DrawString("Saldo €: ", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                        saldo = row(2) - row(3)
                        textN = Format$(saldo, "#0.00")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(5) - sSize.Width.ToString + 100
                        ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                        zeile += 1
                        yyy = 1
                    End If
                    If zzz Then
                        zzz = False
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Aufstellung der Zahlungen", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                    End If

                    zeile += 1
                    If row(4) > " " Then
                        Teilnehmer += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(row(4), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                        If row(5) > 0 Then
                            zahlungen(ev, row(5), "Barzahlung €:", yPos, summeEinzahlungen)
                            If row(6) > 0 Then
                                zeile += 1
                                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            End If
                        End If
                        If row(6) > 0 Then
                            zahlungen(ev, row(6), "Einzahlung €:", yPos, summeEinzahlungen)
                        End If
                        zeile += 0.5
                    End If
                    datumwechsel = row(22)
                    yyy = 2
                Case 2
                    '                    If zzz Then
                    zeile += 1
                    zzz = False
                    '               End If

                    ' Ausgleich der Zahlungen
                    '                      zeile += 1
                    If yyy = 2 Then
                        zeile += 2
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Ausgleich von Kassa- und Barzahlungen", printFont, Brushes.Black, xPos(2) + 100, yPos, New StringFormat())
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))

                        '              zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Summe Kosten € ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

                        hh = summeauszahlungen
                        textN = Format$(hh, "#0.00")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(1) - sSize.Width.ToString + 80
                        ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                        ev.Graphics.DrawString("Durchschnitt/Person €", printFont, Brushes.Black, xPos(3) - 60, yPos, New StringFormat())
                         hh = summeauszahlungen / Teilnehmer
                        mittel = hh
                        textN = Format$(hh, "#0.00")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                        ev.Graphics.DrawString("Saldo €: ", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                        hh = saldo
                        textN = Format$(hh, "#0.00")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(5) - sSize.Width.ToString + 100
                        ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                        zeile += 2
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Bezahlt von ", printFfont, Brushes.Black, xPos(0), yPos, New StringFormat())
                        ev.Graphics.DrawString("Betrag ", printFfont, Brushes.Black, xPos(2) + 10, yPos, New StringFormat())
                        ev.Graphics.DrawString("zu zahlen", printFfont, Brushes.Black, xPos(4) - 10, yPos, New StringFormat())
                        ev.Graphics.DrawString("zu bekommen", printFfont, Brushes.Black, xPos(5) - 40, yPos, New StringFormat())
                        zeile += 1
                    End If
                    '              ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                    yyy = 3
                    '           zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    zahlungsausgleich(row(4), row(5), row(6), mittel, zeile, yPos, topMargin, leftMargin, ev)
                    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Case 3
                    If datumwechsel <> row(22) Then
                        zeile += 0.5
                        datumwechsel = row(22)
                    End If
                    If yyy = 3 Then
                        ' Aufstellung der Belege
                        zeile += 2
                        überschrift(zeile, yPos, topMargin, leftMargin, ev)
                        yyy = 2
                    End If
                    If zeile = 2 Then
                        zeile += 3
                        überschrift(zeile, yPos, topMargin, leftMargin, ev)
                    End If
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(22), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                    hh = row(2)
                    If row(3) <> "Kassa" Then
                        summeauszahlungen += row(2)
                    End If
                    textN = Format$(hh, "#0.00")
                    sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                    rechts = xPos(5) - sSize.Width.ToString + 60
                    ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    If Not DBNull.Value.Equals(row(23)) Then
                        If row(23) > "" Then
                            zeile += 1
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString(row(23), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                        End If
                    End If
                    xxx = 1
                Case 4
                    '                                                Aufstellung nach Kategorie
                    If xxx = 1 Then
                        xxx = 2
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Übersicht der Kategorien ", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Kategorie ", printFfont, Brushes.Black, xPos(2), yPos, New StringFormat())
                        ev.Graphics.DrawString("Betrag ", printFfont, Brushes.Black, xPos(5), yPos, New StringFormat())
                        ev.Graphics.DrawString("Anteil in % ", printFfont, Brushes.Black, xPos(6), yPos, New StringFormat())
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                    End If
                    If row(1) <> "Kassa" Then
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                        hh = row(2)
                        textN = Format$(hh, "#0.00")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(5) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                        hh = row(2) * 100 / summeauszahlungen
                        textN = Format$(hh, "#0.0")
                        sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                        rechts = xPos(6) - sSize.Width.ToString + 60
                        ev.Graphics.DrawString(textN + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    End If
                    rNbr += 1
                    If rNbr >= dt.Rows.Count Then
                        Exit While
                    End If
                    row = dt.Rows(rNbr)
                    If row(0) = 5 Then
                        zeile = 100
                    End If
                    rNbr -= 1
                Case 5
                    If datumwechsel <> row(22) Then
                        zeile += 0.5
                        datumwechsel = row(22)
                    End If
                    If yyy = 0 Then
                        ' Aufstellung der Belege
                        zeile += 2
                        überschriftW(zeile, yPos, topMargin, leftMargin, ev)
                        yyy = 2
                    End If
                    If zeile = 2 Then
                        zeile += 3
                        überschrift(zeile, yPos, topMargin, leftMargin, ev)
                    End If
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(22), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())

                    hh = row(2)
                    textN = Format$(hh, "#0.00")
                    sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 60
                    ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '                 ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    hh = row(3)
                    textN = Format$(hh, "#0.00")
                    sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                    rechts = xPos(5) - sSize.Width.ToString + 60
                    ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, yPos, New StringFormat())

                    ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                    yyy = 1

            End Select
            '                                                                                                     Neue Seite
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        zeile = 5
        If rNbr >= dt.Rows.Count Then
            ev.HasMorePages = False
        Else
            ev.HasMorePages = True

        End If
ruckende:
    End Sub
    Private Sub überschrift(ByRef zeile, ByVal ypos, ByVal topmargin, ByVal leftmargin, ByVal ev)
        ypos = topmargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Aufstellung der Belege ", printFont, Brushes.Black, xPos(3), ypos, New StringFormat())
        zeile += 1
        ypos = topmargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Bezahlt von ", printFfont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString("Belegtext ", printFfont, Brushes.Black, xPos(2), ypos, New StringFormat())
        ev.Graphics.DrawString("Datum ", printFfont, Brushes.Black, xPos(4), ypos, New StringFormat())
        ev.Graphics.DrawString("Kategorie ", printFfont, Brushes.Black, xPos(6), ypos, New StringFormat())
        '     ev.Graphics.DrawString("Bezahlt von ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Betrag ", printFfont, Brushes.Black, xPos(5), ypos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(leftmargin - 60, ypos), New Point(ev.MarginBounds.Right + 40, ypos))
        zeile += 0.5
    End Sub
    Private Sub zahlungen(ByVal ev, ByVal betrag, ByVal textN, ByVal ypos, ByRef summe)
        Dim hh As Single
        Dim textN1 As String
        ev.Graphics.DrawString(Text, printFont, Brushes.Black, xPos(1), ypos, New StringFormat())
        ev.Graphics.DrawString(textN, printFont, Brushes.Black, xPos(2) + 50, ypos, New StringFormat())
        hh = betrag
        summe += betrag
        textN1 = Format$(hh, "#0.00")
        sSize = ev.Graphics.MeasureString(textN1, printFont, 1000)
        rechts = xPos(3) - sSize.Width.ToString + 70
        ev.Graphics.DrawString(textN1, printFont, Brushes.Black, rechts, ypos, New StringFormat())

    End Sub
    Private Sub zahlungsausgleich(ByVal row1, ByVal row2, ByVal row3, ByVal mittel, ByRef zeile, ByVal ypos, ByVal topmargin, ByVal leftmargin, ByVal ev)
        Dim hh As Single
        If row1 > " " Then
            ypos = topmargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(row1, printFont, Brushes.Black, xPos(0), ypos, New StringFormat())
            hh = row2
            hh += row3
            textN = Format$(hh, "#0.00")
            sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
            rechts = xPos(2) - sSize.Width.ToString + 60
            ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, ypos, New StringFormat())
            '      ev.Graphics.DrawString("€: ", printFont, Brushes.Black, xPos(4) + 20, ypos, New StringFormat())
            hh = row2
            hh += row3 - mittel
            textN = Format$(hh, "#0.00")
            If hh < 0 Then
                sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                rechts = xPos(4) - sSize.Width.ToString + 60
                textN = textN * (-1)
                ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, ypos, New StringFormat())
            Else
                sSize = ev.Graphics.MeasureString(textN, printFont, 1000)
                rechts = xPos(5) - sSize.Width.ToString + 60
                ev.Graphics.DrawString(textN, printFont, Brushes.Black, rechts, ypos, New StringFormat())
            End If
        End If
        If rNbr >= dt.Rows.Count Then
            ev.HasMorePages = False
        Else
            ev.HasMorePages = True
        End If
    End Sub
    Private Sub überschriftW(ByRef zeile, ByVal ypos, ByVal topmargin, ByVal leftmargin, ByVal ev)
        ypos = topmargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Aufstellung der Belege in der Landeswährung", printFont, Brushes.Black, xPos(3), ypos, New StringFormat())
        zeile += 1
        ypos = topmargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Belegtext ", printFfont, Brushes.Black, xPos(0), ypos, New StringFormat())
        ev.Graphics.DrawString("Datum ", printFfont, Brushes.Black, xPos(2), ypos, New StringFormat())
        ev.Graphics.DrawString("Betrag € ", printFfont, Brushes.Black, xPos(4), ypos, New StringFormat())
        ev.Graphics.DrawString("Währung ", printFfont, Brushes.Black, xPos(6), ypos, New StringFormat())
        ev.Graphics.DrawString("Betrag ", printFfont, Brushes.Black, xPos(5), ypos, New StringFormat())
        ev.Graphics.DrawLine(Pens.Black, New Point(leftmargin - 60, ypos), New Point(ev.MarginBounds.Right + 40, ypos))
        zeile += 0.5
    End Sub
End Class

