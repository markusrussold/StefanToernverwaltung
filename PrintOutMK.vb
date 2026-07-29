Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class Printoutmk
    '                                   Bestelllisten
    Public speicherbild As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim xPos(7) As Single
    Dim logo As Image
    Dim rabut2 As Boolean
    Dim rabut3 As Boolean
    Dim rabut4 As Boolean
    Dim linesPerPage As Single = 0
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim sSize As SizeF
    Dim summe As Single = 0
    Dim breite2 As Single
    Dim zeile As Integer = 0
    Dim rNbr As Integer
    Dim text As String
    Dim bis As String
    Dim stk As String = " "
    Dim Bem As String = " "
    Dim teilnehmer As String
    Public Sub PrintBestellung(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        If Menü.programmquelle = 1 Then
            pd.DefaultPageSettings.Landscape = True
        End If
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim endp As String = " "
        Dim pospreis As Single
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        ' Calculate the number of lines per page.
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 200
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        ' Row(0)    "Kurs"                   "Material"
        ' Row(1)    "FB"                     "Stück"
        ' Row(2)    "Material"               "Listenpreis"               Kurs          Material             VZName
        ' Row(3)    "VZName"                 "Einkaufspreis"             FB            Listenpreis
        ' Row(4)    "Verkaufspreis"          "Lieferant"                 1             2                    3
        ' Row(5)    "Bemerkung"

        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        row = dt.Rows(0)
        Select Case Menü.programmquelle
            Case 1
                Bestellliste(ev)
            Case 2
                Teilnehmerbestellung(ev)
            Case 3
                Sammelbestellung(ev)
        End Select
    End Sub
   
    Private Sub Sammelbestellung(ev)
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim endp As String = " "
        Dim pospreis As Single
        Dim r3 As Single
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 200
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        ' Row(0)    "Kurs"                   "Material"
        ' Row(1)    "FB"                     "Stück"
        ' Row(2)    "Material"               "Listenpreis"               Kurs          Material             VZName
        ' Row(3)    "VZName"                 "Einkaufspreis"             FB            Listenpreis
        ' Row(4)    "Verkaufspreis"          "Lieferant"                 1             2                    3
        ' Row(5)    "Bemerkung"

        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Sammelbestellung", printFont, Brushes.Black, xPos(2), topMargin - 20, New StringFormat())
         printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin - 45, New StringFormat())
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Material", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Stk", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Einkaufspreis", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Positionspreis", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1
        row = dt.Rows(0)
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            If Not DBNull.Value.Equals(row(0)) Then
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                '         text = Format$(row(1), "#0.00")
                '        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                '       breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(1)), "", row(1)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                If IsNumeric(row(3)) Then
                    r3 = row(3)
                    text = Format$(r3, "#0.00")
                    pospreis = row(1) * r3
                Else
                    text = "0.00"
                    pospreis = row(1)
                End If
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text + " € "), printFont, Brushes.Black, New RectangleF(xPos(3) + 70 - breite2, yPos, 70, 20), New StringFormat())

                text = Format$(pospreis, "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text + " € "), printFont, Brushes.Black, New RectangleF(xPos(5) + 70 - breite2, yPos, 70, 20), New StringFormat())
                summe += pospreis
            End If
                zeile += 1
weiter:
                rNbr += 1
                If rNbr >= dt.Rows.Count Then
                    row = Nothing
                    Exit While
                End If
        End While

        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                   zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Summe", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            text = Format$(summe, "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(summe), "", Format$(summe, "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(5) + 70 - breite2, yPos, 70, 20), New StringFormat())   'Anflug
      End Sub

    Private Sub Teilnehmerbestellung(ev)
        ' Teilnehmerbestellung
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        ' Calculate the number of lines per page.
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 200
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100

        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        row = dt.Rows(0)
        rNbr = lastRow
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            teilnehmer = row(3)
            If zeile = 0 Then
                printFont = New Font("Arial", 18, FontStyle.Bold)
                ev.Graphics.DrawString("Bestellung", printFont, Brushes.Black, xPos(2), topMargin - 20, New StringFormat())
                printFont = New Font("Arial", 14, FontStyle.Bold)
                sSize = ev.Graphics.MeasureString(row(3), printFont, 1000)
                breite2 = sSize.Width.ToString / 2
                ev.Graphics.DrawString(row(3), printFont, Brushes.Black, 410 - breite2, topMargin + 15, New StringFormat())
                printFont = New Font("Arial", 10)
                ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin - 45, New StringFormat())
                zeile += 7
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Material", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString("Verkaufspreis", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString("Bemerkung", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                zeile += 1
                bis = 1
            End If
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            text = Format$(row(4), "#0.00")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            breite2 = sSize.Width.ToString
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", Format$(row(4), "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 70 - breite2, yPos, 70, 20), New StringFormat())   'Anflug
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            summe += row(4)
            zeile += 1
weiter:
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
            row = dt.Rows(rNbr)
            If row(3) <> teilnehmer Then     '                      Teilnehmerwechsel
                teilnehmer = row(3)
                ' Seitenwechsel
                GoTo endwhile
            Else
            End If

        End While
endwhile:
        lastRow = rNbr
        ' Seitenwechsel
        If Not (row Is Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If

        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Summe", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        text = Format$(summe, "#0.00")
        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
        breite2 = sSize.Width.ToString
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(summe), "", Format$(summe, "#.00").ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(2) + 70 - breite2, yPos, 70, 20), New StringFormat())   'Anflug
        zeile = 0
        summe = 0

    End Sub

    Private Sub Bestellliste(ByVal ev)
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim lf As Single = 0
        Dim u1 As Boolean = True
        Dim preis As Single
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 200
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        printFont = New Font("Arial", 18, FontStyle.Bold)
        sSize = ev.Graphics.MeasureString("Bestellliste", printFont, 1000)
        breite2 = sSize.Width.ToString / 2
        ev.Graphics.DrawString("Bestellliste", printFont, Brushes.Black, 550 - breite2, topMargin - 20, New StringFormat())

        printFont = New Font("Arial", 14, FontStyle.Bold)
        sSize = ev.Graphics.MeasureString(Kursbestellung1.TextBox2.Text + " " + Kursbestellung1.TextBox10.Text, printFont, 1000)
        breite2 = sSize.Width.ToString / 2
        ev.Graphics.DrawString(Kursbestellung1.TextBox2.Text + " " + Kursbestellung1.TextBox10.Text, printFont, Brushes.Black, 550 - breite2, topMargin + 15, New StringFormat())

        printFont = New Font("Arial", 8)
        rNbr = lastRow
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin - 45, New StringFormat())
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            If IsDBNull(row(2)) Then
                GoTo aus
            End If
            Select Case row(2)
                Case 2
                    preis = row(1)
                    text = Format$(preis, "#0.00")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    breite2 = sSize.Width.ToString
                    If u1 Then
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(1) + lf, yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 30 + lf - breite2, yPos + 12, 70, 20), New StringFormat())   'Anflug
                        '               ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3).ToString + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 30 + lf - breite2, yPos + 12, 70, 20), New StringFormat())   'Anflug
                        u1 = False
                    Else
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(1) + lf, yPos + 40, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text + " € "), printFont, Brushes.Black, New RectangleF(xPos(1) + 30 + lf - breite2, yPos + 52, 70, 20), New StringFormat())   'Anflug
                        u1 = True
                    End If
                    lf += 100
                Case 3
                    printFont = New Font("Arial", 10)
                    zeile += 1

                    If lf > 0 Then
                        zeile += 2
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right, yPos))
                        yPos = yPos + 3
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right, yPos))
                        zeile += 1
                        lf = 0
                    End If
                    yypos = yPos
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) - 10, yypos), New Point(xPos(1) - 10, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 90, yypos), New Point(xPos(1) + 90, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 190, yypos), New Point(xPos(1) + 190, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 290, yypos), New Point(xPos(1) + 290, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 390, yypos), New Point(xPos(1) + 390, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 490, yypos), New Point(xPos(1) + 490, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 590, yypos), New Point(xPos(1) + 590, yPos))
                    ev.Graphics.DrawLine(Pens.Black, New Point(xPos(1) + 690, yypos), New Point(xPos(1) + 690, yPos))
            End Select

            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
aus:
    End Sub
End Class
