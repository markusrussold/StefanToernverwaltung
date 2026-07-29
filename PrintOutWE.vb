Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutWE
    Dim linesPerPage As Single = 0
    Dim Name4Summe As String = ""
    Dim SummeCrewSm As Single
    Dim yPos As Single = 0
    Dim xPos(7) As Single
    Dim row As DataRow = Nothing
    Dim zeile As Integer = 5
    Dim letztezeile As Integer
    Dim rNbr As Integer
    Public speicherbild As String
    Private printFont As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim logo As Image
    Public var As Single
    Public Sub PrintWerbung(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        dt = tIn
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
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim von As String = " "
        Dim name As String = " "
        Dim pers1 As String
        Dim pers2 As String
        Dim dat1 As Date
        Dim dat2 As Date
        Dim datum1 As String
        Dim datum11 As String = " "
        Dim datum2 As String
        Dim tag1 As String
        Dim wochentag As String
        Dim grauzaehler As Integer = 0
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 30
        xPos(1) = xPos(0) + 120
        xPos(2) = xPos(1) + 150
        xPos(3) = xPos(2) + 40
        xPos(4) = xPos(3) + 100
        xPos(5) = xPos(4) + 60
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 80
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        '          "Kurs", "FB", "DatumBeginn", "Werbeart", "Werbeort", "Werbedatum", "Betrifft", "Werbekosten", "Bemerkung"
        '           r0      r1       r2          r3          r4             r5           r6            r7            r8
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("W e r b e ü b e r s i c h t", printFont, Brushes.Black, xPos(2), topMargin - 50, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(7), topMargin - 20, New StringFormat())
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Aktion: " + row(0) + " " + row(1), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        zeile += 1
        While zeile < (linesPerPage)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                rNbr += 1
                Exit While
            End If

            zeile += 2
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Beginn der Aktion:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString("Werbeart:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
            ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            ev.Graphics.DrawString("Ort:", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            ev.Graphics.DrawString(row(4), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
            ev.Graphics.DrawString("Datum:", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
            ev.Graphics.DrawString(row(5), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
            ev.Graphics.DrawString("Kosten €:", printFont, Brushes.Black, xPos(6), yPos, New StringFormat())
            ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(7)), "", row(7)), printFont, Brushes.Black, xPos(7), yPos, New StringFormat())
            If DBNull.Value.Equals(row(8)) Then
            Else
                If row(8) > " " Then
                    '        zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    zeile = LangXText.LangXtextDrucken(row(8), zeile, yPos, printFont, xPos(0), ev, 100)

                End If
            End If
            rNbr += 1
            If rNbr > dt.Rows.Count - 1 Then
                row = Nothing
                Exit While
            End If
        End While

        lastRow = rNbr
        zeile = 5
        datum11 = " "
        If Not (row Is Nothing) Then
            ev.HasMorePages = True
        End If

    End Sub
End Class
