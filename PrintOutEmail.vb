Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutEmail
    '                                                                                           Drucken E-Mail
    Public speicherbild As String
    Private printFont As Font
    Private printFFont As Font
    Private printF14Font As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Dim btg As Single
    Dim smg As Single
    Dim ssg As Single
    Dim sgg As Single
    Dim bts As Single
    Dim sms As Single
    Dim sss As Single
    Dim sgs As Single
    Dim nfg As Single
    Dim fb2g As Single
    Dim fb3g As Single
    Dim nfs As Single
    Dim nfas As Single
    Dim nfa As Single
    Dim fb2s As Single
    Dim fb3s As Single
    Dim linesPerPage As Single = 0
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim xPos(7) As Single
    Dim leftMargin As Single
    Dim topMargin As Single
    Dim ij As Integer = 0
    Dim zeile As Integer = 0
    Public zs As Integer
    Public zr As Integer
    Public zeilenanf As Single
    Public x As New Leerstelle
    Public routelange As Integer
    Public aaa As String
    Public zeilentext As String
    Dim stern As String = " "

    Public Sub PrintEmail(ByVal tIn As DataTable)
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
        Dim yypos As Single
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Integer = 8
        Dim rNbr As Integer
        '      Dim lf As Integer
        Dim quelle As String
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 40
        xPos(2) = xPos(1) + 300
        xPos(3) = xPos(2) + 200
        xPos(4) = xPos(3) + 200
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Gesendete e-mail", printFont, Brushes.Black, xPos(1) + 200, topMargin - 50, New StringFormat())
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(3), topMargin, New StringFormat())

        row = dt.Rows(0)
        rNbr = lastRow
        row = dt.Rows(rNbr)

        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        yypos = yPos
        ev.Graphics.DrawString("Betreff:     " + row(3), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        '       ev.Graphics.DrawString(row(4), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())                                                   'Text

        quelle = row(4)                                                                               ' Textübergabe
         If rNbr = 0 Then
            zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0), ev, linesPerPage)
        End If
        If EMail.anhang1 > "" Then
            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Anhang: " + EMail.anhang1 + "   " + EMail.anhang2, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(EMail.anhang3, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        End If

        '        rNbr += 1
        zeile += 3
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

        '---------------------------------------------------------------------------------------  Crew Daten ---------------------------------------------------------------------

        ev.Graphics.DrawString("e-mail Adresse", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Name", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Vorname", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
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
            ev.Graphics.DrawString(ij, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            aaa = row(0)
            If aaa.Length < 3 Then
                ev.Graphics.DrawString("E-Mail Adresse fehlt", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            Else
                If row(5) = "0" Then
                    ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                Else
                    ev.Graphics.DrawString(row(0) + "      Fehler: " + row(5), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                End If
            End If
            zeile += 1
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        lastRow = rNbr
        '  If more lines exist, print another page.
        If Not (row Is Nothing) Then
            ev.HasMorePages = True
        End If
    End Sub


End Class
