Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintoutKT
    '                                                                                           Drucken Kurs - Teilnehmerliste
    Public speicherbild As String
    Public speicherplatz As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image

    Public Sub PrintTeilnehmerListe(ByVal tIn As DataTable)
        dt = tIn
        printFont = New Font("Arial", 10)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        dt = tIn
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
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
        Dim zeile As Integer = 4
        Dim rNbr As Integer
        Dim sSize As SizeF
        Dim ij As Integer
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 250
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 120
        xPos(4) = xPos(3) + 80
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Kurs Teilnehmerliste ", printFont, Brushes.Black, xPos(1), topMargin - 50, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 12, FontStyle.Bold)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(5) + 30, topMargin - 50, New StringFormat())
        ev.Graphics.DrawString(row(1) + " " + row(2), printFont, Brushes.Black, xPos(1) + 20, topMargin - 15, New StringFormat())
        '        ev.Graphics.DrawString(row(2), printFont, Brushes.Black, topMargin, yPos, New StringFormat())
        printFont = New Font("Arial", 10)
        ' Print each line of the file.
        '----------------------------------------------------------- allgemeine Törndaten ------------------------------------------------
        rNbr = lastRow
        row = dt.Rows(rNbr)
        ' Feld1 ...4    Skipper, von, bis, Boot
 
        rNbr += 0

        'zeigt nur wie Texte abgemessen werden, hat sonst keine Funktion
        sSize = ev.Graphics.MeasureString("ABSC", printFont, 1000)
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

        '---------------------------------------------------------------------------------------  Crew Daten ---------------------------------------------------------------------

        ev.Graphics.DrawString("Name", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Preis", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("bereits bezahlt", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Material", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("bereits bezahlt", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
        zeile += 1

        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            ij += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
            zeile += 1
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While

    End Sub

End Class
