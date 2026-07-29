Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintoutKS
    '                                                                                           Drucken Kursstatistik
    Public speicherplatz As String
    Private printFont As Font
    Private printfFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Public sign As String
    Private lastRow As Integer = 0
    Public speicherbild As String
    Dim ij As Integer = 0
    Dim ji As Integer = 0
    Dim name As String = " "
    Dim datu As String = " "
    Dim logo As Image
    Dim row As DataRow = Nothing
    Dim rNbr As Integer

    Public Sub PrintKursstatistik(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        sign = GetSetting("sign", "Pfad", "T")
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        row = dt.Rows(0)
        rNbr = lastRow
        pd.Print()
    End Sub
    ' The PrintPage event is raised for each page to be printed.
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim zeile As Integer = 0
        Dim sSize As SizeF
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 20
        xPos(3) = xPos(2) + 300
        xPos(4) = xPos(3) + 230
        xPos(5) = xPos(4) + 130
        xPos(6) = xPos(5) + 80
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printfFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("K u r s s t a t i s t i k", printfFont, Brushes.Black, xPos(3), topMargin - 50, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6) - 40, topMargin - 30, New StringFormat())
        ' Print each line of the file.
        '----------------------------------------------------------- allgemeine Törndaten ------------------------------------------------
        row = dt.Rows(rNbr)
 
        'zeigt nur wie Texte abgemessen werden, hat sonst keine Funktion
        sSize = ev.Graphics.MeasureString("ABSC", printFont, 1000)
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

        '---------------------------------------------------------------------------------------  Crew Daten ---------------------------------------------------------------------

        '            Kurs, Fahrtbereich, Lehrer, VZ_Name, Geschlecht, Kursanfangsdatum, Kursdauer
        '        row  0          1        2       3            4            5               6

        ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Name", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Kursbezeichnung", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Vortragende", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        ev.Graphics.DrawString("Kursanfang", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        ev.Graphics.DrawString("Kursdauer", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 80, yPos))
        If Kursstatistik.Statistik = "Namen" Then
            While zeile < (linesPerPage - 1)
                row = dt.Rows(rNbr)
                If row Is Nothing Then
                    Exit While
                End If
                If row(3) <> name Then
                    ij += 1
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(ij, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    name = row(3)
                Else
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                End If
                ev.Graphics.DrawString(row(0) + " " + row(1), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                ev.Graphics.DrawString(row(6) + " Std.", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                zeile += 1
                rNbr += 1
                If rNbr >= dt.Rows.Count Then
                    row = Nothing
                    Exit While
                End If
            End While
        Else
            While zeile < (linesPerPage - 1)
                row = dt.Rows(rNbr)
                If row Is Nothing Then
                    Exit While
                End If
                If row(5) <> datu Then
                    ji += 1
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(ji, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(0) + " " + row(1), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(6) + " Std.", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
                    datu = row(5)
                Else
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                End If
                ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                zeile += 1
                rNbr += 1
                If rNbr >= dt.Rows.Count Then
                    row = Nothing
                    Exit While
                End If
            End While
        End If

        '       rNbr += 1
        If row Is Nothing Then
            GoTo druckende
        End If
        ev.HasMorePages = True
        zeile = 0
druckende:
    End Sub
End Class
