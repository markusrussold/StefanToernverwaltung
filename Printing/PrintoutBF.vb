Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintoutBF
    Private printFont As Font
    Private printFontF As Font
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim Kopieanzahl As Integer
    Dim aaa As String = Crew.TextBox20.Text
    Dim Brieftext As String = Crew.RichTextBox1.Text
    Dim zeile As Integer = 4
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim xPos(7) As Single
    Dim i As Integer = 1
    Public Sub PrintBrief(ByVal tIn As DataTable)                                   ' Briefkopf
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
        zeile = 4
        printFont = New Font("Arial", 10)
        printFontF = New Font("Arial", 13, FontStyle.Bold)
        Kopieanzahl = aaa
        leftMargin = ev.MarginBounds.Left
        topMargin = ev.MarginBounds.Top
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 50

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        '       ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin, New StringFormat())

        rNbr = lastRow
        row = dt.Rows(rNbr)
        yPos = topMargin + zeile * printFontF.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(2), printFontF, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Anrede
        zeile += 1
        yPos = topMargin + zeile * printFontF.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(1) + " " + row(0), printFontF, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Anrede
        zeile += 2
        yPos = topMargin + zeile * printFontF.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(3), printFontF, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Anrede
        zeile += 1
        yPos = topMargin + zeile * printFontF.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(row(4) + " " + row(5), printFontF, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Anrede
        '           yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        '          ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 10
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        '        ev.Graphics.DrawString(Brieftext, printFont, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Anrede
        zeile = Langtext.LangtextDrucken(Brieftext, zeile, yPos, printFont, xPos(0) - 10, ev, linesPerPage)                                                ' Törn Bemerkung
        i += 1
        If i > Kopieanzahl Then
            GoTo druckende
        End If
         ev.HasMorePages = True
 
druckende:
    End Sub

End Class
