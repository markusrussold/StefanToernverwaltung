Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutTl
    '                                   Kurs Teilnehmerliste
    Public speicherbild As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Public Sub PrintTeilnehmerliste(ByVal tIn As DataTable)
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
        Dim yPos As Single = 0
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Single = 0
        Dim rNbr As Integer
        Dim bis As String
        Dim text As String
        Dim sSize As SizeF
        Dim summe As Single = 0
        Dim breite2 As Single
        Dim stk As String = " "
        Dim Bem As String = " "
        Dim endp As String = " "
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 250
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 10
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 50
        xPos(6) = xPos(5) + 180
        xPos(7) = xPos(6) + 100
        ' Row(0)    "VZName"          
        ' Row(1)    "Kurs"           
        ' Row(2)    "FB""Material"   
        ' Row(3)    "Kursspreis"      
        ' Row(4)     "Kursbezahlt"         
        ' Row(5)    "Bemerkung"
        ' Row(6)    "MaterialPreis"
        ' Row(7)    "MaterialBezahlt

        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        row = dt.Rows(0)
            printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Teilnehmerliste", printFont, Brushes.Black, xPos(1) + 30, topMargin - 20, New StringFormat())
        printFont = New Font("Arial", 14, FontStyle.Bold)
        text = row(1) + " " + row(2)
        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
        breite2 = sSize.Width.ToString / 2
        ev.Graphics.DrawString(text, printFont, Brushes.Black, 410 - breite2, topMargin + 15, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin - 45, New StringFormat())
        rNbr = lastRow
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Teilnehmer", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Kurspreis", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Materialpreis", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Bemerkung", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        bis = 1
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            If IIf(DBNull.Value.Equals(row(3)), 0, row(3)) > 0 Then
                text = Format$(row(3), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text + " € "), printFont, Brushes.Black, xPos(1) + 50 - breite2, yPos, New StringFormat())
            End If
            If IIf(DBNull.Value.Equals(row(4)), 0, row(4)) > 0 Then
            Else
                ev.Graphics.DrawString("offen", printFont, Brushes.Black, New RectangleF(xPos(1) + 60, yPos, 70, 20), New StringFormat())
            End If
            If IIf(DBNull.Value.Equals(row(6)), 0, row(6)) > 0 Then
                text = Format$(row(6), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text + " € "), printFont, Brushes.Black, xPos(3) + 70 - breite2, yPos, New StringFormat())
                If IIf(DBNull.Value.Equals(row(7)), 0, row(7)) > 0 Then
                Else
                    ev.Graphics.DrawString("offen", printFont, Brushes.Black, New RectangleF(xPos(3) + 80, yPos, 70, 20), New StringFormat())
                End If
            End If
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
            zeile += 1.3
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
weiter:
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While

        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
    End Sub
End Class
