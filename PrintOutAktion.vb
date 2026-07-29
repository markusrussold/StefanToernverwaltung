Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutAktion
    Public speicherbild As String                       ' Veranstalltung drucken
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

    Public Sub PrintAktion(ByVal tIn As DataTable)
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
        Dim kosten As Boolean = False
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        xPos(0) = leftMargin - 50
        xPos(1) = xPos(0) + 100
        xPos(2) = xPos(1) + 100
        xPos(3) = xPos(2) + 100
        xPos(4) = xPos(3) + 100
        xPos(5) = xPos(4) + 70
        xPos(6) = xPos(5) + 100
        xPos(7) = xPos(6) + 100
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Veranstaltung", printFont, Brushes.Black, xPos(1) + 200, topMargin - 50, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin - 25, New StringFormat())

        rNbr = lastRow
        row = dt.Rows(rNbr)

        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        yypos = yPos

        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            If row(7) > " " Then
                ev.Graphics.DrawString("Veranstaltung: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString("am: ", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                aaa = Replace(row(7), ",", ".")
                ev.Graphics.DrawString(aaa, printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                If Not DBNull.Value.Equals(row(1)) Then
                    If IsNumeric(row(1)) Then
                        ev.Graphics.DrawString("Kostenbeitrag: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                        ev.Graphics.DrawString(row(1) + " €", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                        kosten = True
                    End If
                End If
                ev.Graphics.DrawString("max. Teilnehmeranzahl: ", printFont, Brushes.Black, xPos(3) - 25, yPos, New StringFormat())
                ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Ort: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("    " + row(4), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("    " + row(5), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                If row(8) > " " Then
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Bemerkung: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(8), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                 End If

                zeile += 3
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

                '---------------------------------------------------------------------------------------  Crew Daten ---------------------------------------------------------------------

                ev.Graphics.DrawString("Name", printFont, Brushes.Black, xPos(1) - 60, yPos, New StringFormat())
                ev.Graphics.DrawString("Anmeldedatum", printFont, Brushes.Black, xPos(2) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("Clubmitglied", printFont, Brushes.Black, xPos(4) - 30, yPos, New StringFormat())
                ev.Graphics.DrawString("Bemerkung", printFont, Brushes.Black, xPos(5) - 10, yPos, New StringFormat())
                If kosten Then
                    ev.Graphics.DrawString("gezahlt", printFont, Brushes.Black, xPos(3) + 20, yPos, New StringFormat())
                End If
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                zeile += 1
            Else

                ij += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(ij, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                aaa = row(4).ToString.Substring(0, 10)
                ev.Graphics.DrawString(row(0), printFont, Brushes.Black, xPos(1) - 60, yPos, New StringFormat())
                ev.Graphics.DrawString(aaa, printFont, Brushes.Black, xPos(2) + 20, yPos, New StringFormat())
                If row(5) > "0" Then
                    ev.Graphics.DrawString(row(5) + " €", printFont, Brushes.Black, xPos(3) + 20, yPos, New StringFormat())
                End If
                ev.Graphics.DrawString(row(6), printFont, Brushes.Black, xPos(4) + 10, yPos, New StringFormat())
                ev.Graphics.DrawString(row(8), printFont, Brushes.Black, xPos(5) - 10, yPos, New StringFormat())
                zeile += 1
            End If
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
