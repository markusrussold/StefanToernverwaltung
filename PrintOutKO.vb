Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutKO
    '                                                                                           Drucken Kontakte
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim xPos(7) As Single
    Public speicherbild As String
    Public boot As String
    Dim zeile As Integer = 0
    Public zs As Integer
    Public zr As Integer
    Public zeilenanf As Single
    Public x As New Leerstelle
    Public routelange As Integer
    Public aaa As String
    Public zeilentext As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Dim ij As Integer
    Dim breite As Single
    Dim leftMargin As Single
    Dim topMargin As Single
    Public Sub PrintKontaktBlatt(ByVal tIn As DataTable)
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
        Dim row As DataRow = Nothing
        Dim rNbr As Integer
        Dim quelle As String
        leftMargin = ev.MarginBounds.Left
        topMargin = ev.MarginBounds.Top
        Dim linesPerPage As Single = 0

        '  "vzname", "datum", Kontaktart, "emailadresse", "Handynr", "Bemerkung"
        '     0         1        2         3              4            5          6              7           8

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 140
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 155
        xPos(5) = xPos(4) + 120
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100

        If Menü.RestText > "" And KursToernKontakte.bsKontakte.Count = lastRow Then
            zeile = Langtext.LangtextDrucken(Menü.RestText, zeile, yPos, printFont, xPos(0) + 75, ev, linesPerPage) ' Text Fortsetzung
            Menü.RestText = ""
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 50, yPos))
            zeile += 2
            GoTo subende
        End If

        rNbr = lastRow
        row = dt.Rows(rNbr)
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 10)
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Kontakte mit:", printFont, Brushes.Black, ev.MarginBounds.Left + 200, yPos, New StringFormat())
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString(row(0), printFont, Brushes.Black, ev.MarginBounds.Left + 250, yPos, New StringFormat())
        printFont = New Font("Arial", 10)
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        zeile += 4
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 50, yPos))
        zeile += 2
        If Menü.RestText > "" Then
            zeile = Langtext.LangtextDrucken(Menü.RestText, zeile, yPos, printFont, xPos(0) + 75, ev, linesPerPage) ' Text Fortsetzung
            Menü.RestText = ""
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 50, yPos))
            zeile += 2
        End If
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            '         zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(1)), "", row(1)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())


            If DBNull.Value.Equals(row(5)) Then
            Else
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                quelle = "Betreff : " & row(5)
                zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0) + 75, ev, linesPerPage)                                                ' Text
                If Menü.RestText = "" Then
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 50, yPos))
                End If
            End If
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            zeile += 1
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        lastRow = rNbr
        '  If more lines exist, print another page.
        ev.HasMorePages = True            ' weitere Seiten vorhanden
        zeile = 0
subende:
        If Not (row Is Nothing) Then
        Else
            If Menü.RestText = "" Then
                ev.HasMorePages = False     'letzte Seite bereits gedruckt
            End If
        End If

    End Sub
 
End Class


