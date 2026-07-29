Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutIM
    '                                                                            Importierte Törns
    Public speicherbild As String
    Private printFont As Font
    Private printF14Font As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Private anzahl As String
    Dim logo As Image
    Public var As Single
    Dim rNbr As Integer
    Dim Brush As New SolidBrush(Color.LightGray)
    Public Sub PrintImport(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        dt = tIn
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        pd.DefaultPageSettings.Landscape = True
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
        Dim zeile As Single = 2
        Dim zz As Single = 1.2
        '      Dim xxx As Integer
        '      Dim yyy As Integer
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 50
        xPos(1) = xPos(0) + 150
        xPos(2) = xPos(1) + 150
        xPos(3) = xPos(2) + 150
        xPos(4) = xPos(3) + 200
        xPos(5) = xPos(4) + 240
        xPos(6) = xPos(5) + 180
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        row = dt.Rows(0)
        If row Is Nothing Then
            GoTo druckende
        End If
        printF14Font = New Font("Arial", 14, FontStyle.Bold)
        yPos = topMargin + zeile * printF14Font.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Importprotokoll", printF14Font, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(5) + 10, yPos, New StringFormat())
        zeile += 6
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Törnbezeichnung", printFont, Brushes.Black, xPos(0) - 20, yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Bootsname", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Charterfirma", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
        ev.Graphics.DrawString("Agentur", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        ev.Graphics.DrawString("Crew Name", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
        ev.Graphics.DrawString("Wert", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
        ev.Graphics.DrawString("Status", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
        zeile += 2
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 90, yPos), New Point(ev.MarginBounds.Right + 50, yPos))
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            zeile += 1
            If IsDBNull(row(0)) Then
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(1)), "", row(1)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
            Else
                If row(0) > " " Then
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(0)), "", row(0)), printFont, Brushes.Black, xPos(0) - 20, yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                Else
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(1)), "", row(1)), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(2)), "", row(2)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5)), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(6)), "", row(6)), printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                End If
            End If
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If

        End While

        '                                                                                                     Neue Seite
        rNbr += 1
        If row Is Nothing Or rNbr > 2 Then
            GoTo druckende
        End If

        ev.HasMorePages = True
druckende:
    End Sub
End Class

