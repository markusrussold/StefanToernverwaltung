Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutPL
    '                                                  Preisliste
    Public speicherbild As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Public Sub PrintPreisliste(ByVal tIn As DataTable)
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
        Dim zeile As Integer = 0
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
        xPos(3) = xPos(2) + 130
        xPos(4) = xPos(3) + 170
        xPos(5) = xPos(4) + 30
        ' Row(0)                       "Material"
        ' Row(1)                   "Listenpreis"  
        ' Row(2)                   "Einkaufspreis"            
        ' Row(3)                    "Lieferant"               
        ' Row(4)                    "Datum"          
        ' Row(5)                    "Bemerkung"

        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        row = dt.Rows(0)
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Preisliste", printFont, Brushes.Black, xPos(2), topMargin - 20, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(5), topMargin - 45, New StringFormat())
        rNbr = lastRow
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Material", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        If Kursmaterial.CheckBox1.Checked Then
            ev.Graphics.DrawString("Listenpreis", printFont, Brushes.Black, xPos(1) + 15, yPos, New StringFormat())
        Else
            If Kursmaterial.CheckBox1.Checked Then
                ev.Graphics.DrawString("Einkaufspreis", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            Else
                If Kursmaterial.CheckBox1.Checked Then
                    ev.Graphics.DrawString("Lieferat", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                Else
                    If Kursmaterial.CheckBox1.Checked Then
                        ev.Graphics.DrawString("Datum", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    End If
                End If
            End If
        End If

        If Kursmaterial.CheckBox2.Checked Then
            ev.Graphics.DrawString("Einkaufspreis", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        Else
            If Kursmaterial.CheckBox2.Checked Then
                ev.Graphics.DrawString("Lieferant", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            Else
                If Kursmaterial.CheckBox2.Checked Then
                    ev.Graphics.DrawString("Datum", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                End If
            End If
        End If

        If Kursmaterial.CheckBox3.Checked Then
            ev.Graphics.DrawString("Lieferant", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        Else
            If Kursmaterial.CheckBox3.Checked Then
                ev.Graphics.DrawString("Datum", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            End If
        End If

        If Kursmaterial.CheckBox4.Checked Then
            ev.Graphics.DrawString("Datum", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        End If

        If Kursmaterial.CheckBox5.Checked Then
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Bemerkung", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        End If

        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1
        bis = 1
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

            If Kursmaterial.CheckBox1.Checked Then
                text = Format$(row(1), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text), printFont, Brushes.Black, New RectangleF(xPos(1) + 80 - breite2, yPos, 50, 20), New StringFormat())
            Else
                If Kursmaterial.CheckBox1.Checked Then
                    text = Format$(row(2), "#0.00")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    breite2 = sSize.Width.ToString
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text), printFont, Brushes.Black, New RectangleF(xPos(1) + 80 - breite2, yPos, 50, 20), New StringFormat())
                Else
                    If Kursmaterial.CheckBox1.Checked Then
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    Else
                        If Kursmaterial.CheckBox1.Checked Then
                            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                        End If
                    End If
                End If
            End If

            If Kursmaterial.CheckBox2.Checked Then
                text = Format$(row(2), "#0.00")
                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                breite2 = sSize.Width.ToString
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(text), "", text), printFont, Brushes.Black, New RectangleF(xPos(2) + 80 - breite2, yPos, 50, 20), New StringFormat())
            Else
                If Kursmaterial.CheckBox2.Checked Then
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                Else
                    If Kursmaterial.CheckBox2.Checked Then
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    End If
                End If
            End If

            If Kursmaterial.CheckBox3.Checked Then
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            Else
                If Kursmaterial.CheckBox3.Checked Then
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                End If
            End If

            If Kursmaterial.CheckBox4.Checked Then
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
            End If

            If Kursmaterial.CheckBox5.Checked Then                                                           ' Bemerkung
                If IIf(DBNull.Value.Equals(row(5)), "", row(5)) > "" Then
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(0) + 40, yPos, New StringFormat())
                    '                 zeile += 1
                End If
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
    End Sub
End Class
