Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutVS
    Public speicherplatz As String
    Private printFont As Font
    Private printFettFont As Font
    Private printfFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Public sign As String
    Private lastRow As Integer = 0
    Public speicherbild As String
    Dim ij As Integer = 0
    Dim ji As Integer = 0
    Dim name As String = " "
    Dim vera As String = " "
    Dim datu As String = " "
    Dim logo As Image
    Dim row As DataRow = Nothing
    Dim rNbr As Integer

    Public Sub PrintAktivStatistik(ByVal tIn As DataTable)                  ' Statistik der Aktivitäten
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
        xPos(3) = xPos(2) + 250
        xPos(4) = xPos(3) + 230
        xPos(5) = xPos(4) + 90
        xPos(6) = xPos(5) + 80
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printfFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Statistik der Aktivitäten", printfFont, Brushes.Black, xPos(3), topMargin - 50, New StringFormat())
        printFettFont = New Font("Arial", 10, FontStyle.Bold)
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin - 40, New StringFormat())
        ' Print each line of the file.
        '----------------------------------------------------------- allgemeine Törndaten ------------------------------------------------
        row = dt.Rows(rNbr)

        'zeigt nur wie Texte abgemessen werden, hat sonst keine Funktion
        sSize = ev.Graphics.MeasureString("ABSC", printFont, 1000)
        zeile += 7
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

   
        ev.Graphics.DrawString("Nr.", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Name", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Veranstaltung", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Datum", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        ev.Graphics.DrawString("Ort", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 80, yPos))
        If AktivStatistik.Schritt = "Name" Then
            While zeile < (linesPerPage - 1)
                row = dt.Rows(rNbr)
                If row Is Nothing Then
                    Exit While
                End If
                If DBNull.Value.Equals(row(1)) Then
                    GoTo leer1
                End If
                If row(1) <> name Then
                    ij += 1
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(ij, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    If row(4) = "True" Then
                        ev.Graphics.DrawString(row(1), printFettFont, Brushes.Black, xPos(1) + 5, yPos, New StringFormat())
                    Else
                        ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(1) + 5, yPos, New StringFormat())
                    End If
                    name = row(1)
                Else
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                End If
                ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                If DBNull.Value.Equals(row(2)) Then
                Else
                    ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                End If
                zeile += 1
leer1:
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
                If DBNull.Value.Equals(row(1)) Then
                    GoTo leer2
                End If
                If row(3) <> datu Or row(0) <> vera Then
                    ji += 1
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(ji, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    If DBNull.Value.Equals(row(2)) Then
                    Else
                        ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                    End If
                    datu = row(3)
                    vera = row(0)
                Else
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                End If
                If row(5) = "True" Then
                    ev.Graphics.DrawString(row(1), printFettFont, Brushes.Black, xPos(1) + 5, yPos, New StringFormat())
                Else
                    ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(1) + 5, yPos, New StringFormat())
                End If
                '              ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                zeile += 1
leer2:
                rNbr += 1
                If rNbr >= dt.Rows.Count Then
                    row = Nothing
                    Exit While
                End If
            End While
        End If

        rNbr += 1
        If row Is Nothing Then
            GoTo druckende
        End If
        ev.HasMorePages = True
        zeile = 0
druckende:
    End Sub
End Class
