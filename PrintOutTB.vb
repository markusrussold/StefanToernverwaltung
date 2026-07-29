Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutTB
    '                                                                                           Drucken Törnblatt
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim xPos(7) As Single
    Public speicherbild As String
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
    Dim row As DataRow = Nothing
    Dim rNbr As Integer
    Dim logo As Image
    Dim Block As Integer = 1
 
    Public Sub PrintToernBlatt(ByVal tIn As DataTable)
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
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim von As String
        Dim bis As String
        Dim plz As String
        Dim quelle As String
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 60
        xPos(1) = xPos(0) + 300
        xPos(2) = xPos(1) + 300
        xPos(3) = xPos(2) + 140
        xPos(4) = xPos(3) + 130
        xPos(5) = xPos(4) + 110
        xPos(6) = xPos(5) + 80
        xPos(7) = xPos(6) + 100
        rNbr = lastRow
        row = dt.Rows(rNbr)
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        '      die Crew
        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
           Select Block
                Case 1

                    printFont = New Font("Arial", 18, FontStyle.Bold)
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Törn: " + row(0), printFont, Brushes.Black, xPos(1) + 30, yPos, New StringFormat())
                    printFont = New Font("Arial", 10)
                    ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(2) + 30, yPos - 30, New StringFormat())
                    ' Feld1 ...4    Skipper, von, bis, Boot
                    If row(1) > "" Then
                        von = row(1).substring(0, 10)
                    Else
                        von = "  "
                    End If
                    If row(2) > "" Then
                        bis = row(2).substring(0, 10)
                    Else
                        bis = "  "
                    End If
                    zeile += 2
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(von, printFont, Brushes.Black, xPos(1) + 100, yPos, New StringFormat())
                    ev.Graphics.DrawString(" - " + bis, printFont, Brushes.Black, xPos(1) + 170, yPos, New StringFormat())
                    zeile += 6
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Marina: " + row(14), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Skipper: " + row(11), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("sm unter Segel : " + row(3), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Bordtage : " + row(7), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("sm im FB3 : " + row(8), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("sm unter Motor : " + row(4), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Nachtfahrten : " + row(6), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("sm im FB4 : " + row(9), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Nachtansteuerungen : " + row(15), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Bord Kassa : " + row(13), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString("sm gesamt : " + row(5), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    quelle = "Bemerkung : " & row(26)
                    zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0), ev, linesPerPage)                                                ' Törn Bemerkung
                    Block = 2
                Case 2
                    ' Boot
                    '                   zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Boot: " + row(0), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Marke: " + row(1), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Schiffstyp: " + row(2), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Schiffsnr.: " + row(4), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("MMSI: " + row(27), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Baujahr: " + row(19), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Länge : " + row(5), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Breite : " + row(6), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Verdrängung t : " + row(7), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Tiefgang : " + row(8), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Kielart: " + row(3), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Treibstofftank : " + row(12), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Wassertank: " + row(11), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Motor PS : " + row(16), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Großsegel : " + row(20), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Großsegel m² : " + row(9), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Vorsegel m² : " + row(10), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Kabinen : " + row(13), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Kojen : " + row(14), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Naßräume : " + row(15), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Kaution: " + row(17), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString(row(0) + " ist zugelassen als " + row(25), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())


                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Marinaort : " + row(21), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Marina : " + row(22), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Betreuer : " + row(23), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Mobil : " + row(24), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    quelle = "Bemerkung : " & row(26)
                    zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0), ev, linesPerPage)                                                  ' Boot Bemerkung
                    Block = 3
                Case 3

                    ' Charter
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                     zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Charterfirma: " + row(0), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("Agentur : " + row(13), printFont, Brushes.Black, xPos(2) - 150, yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Adresse : " + row(1) + ", " + row(3) + " " + row(4) + ", " + row(2), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Telefon : " + row(5), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("e-mail : " + row(7), printFont, Brushes.Black, xPos(2) - 150, yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Handy: " + row(6), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    ev.Graphics.DrawString("WEB : " + row(8), printFont, Brushes.Black, xPos(2) - 150, yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Kontaktperson : " + row(9), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    quelle = "Bemerkung : " & row(26)
                    zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(0), ev, linesPerPage)                                                  ' Charter Bemerkung
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                    '                 zeile += 1
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Crew: ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    Block = 4
                Case 4
                    '                 ij += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(row(0) + " " + row(1), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    If DBNull.Value.Equals(row(3)) Then
                        plz = "    "
                    Else
                        plz = row(3)
                    End If
                    If DBNull.Value.Equals(row(4)) Then
                        plz += "    "
                    Else
                        plz += " " + row(4)
                    End If
                    ev.Graphics.DrawString(plz, printFont, Brushes.Black, xPos(1) - 80, yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", row(8)), printFont, Brushes.Black, xPos(2) - 150, yPos, New StringFormat())
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(10)), "", row(10)), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
            End Select
            zeile += 1
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                zeile += 5
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                Exit While
            End If
        End While


            lastRow = rNbr
            zeile = 10
            If Not (row Is Nothing) Then
                ev.HasMorePages = True
            End If

    End Sub
End Class
