Option Explicit On
Imports System.Drawing.Printing
Imports System.IO

Public Class PrintOutGK
    '                                                                                           Drucken Geburtstagskalender
    Public speicherbild As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Public Sub PrintGebKalender(ByVal tIn As DataTable)
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
    ' The PrintPage event is raised for each page to be printed.
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 0
        Dim rNbr As Integer
         Dim von As String
        Dim bis As String
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 200
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 200
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Geburtstagskalender", printFont, Brushes.Black, xPos(2) - 20, topMargin - 40, New StringFormat())
        ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
         row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(4) + 40, topMargin - 30, New StringFormat())
        ' Print each line of the file.

        rNbr = lastRow
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

        ev.Graphics.DrawString("Name", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Geburtsdatum", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Handynummer", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("e-mail Adresse", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1
        bis = 1
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            von = IIf(DBNull.Value.Equals(row(1)), " ", row(1))
            '           von = row(1)
            If von > " " Then
                '              von = row(1).substring(0, 10)
            Else
                GoTo weiter
            End If
            If bis <> von.Substring(4, 2) Then
                bis = von.Substring(4, 2)
                zeile += 1
            End If
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            '           ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(von, printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
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
