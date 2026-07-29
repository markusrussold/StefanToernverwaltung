Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class printOutST
    '                                                                                           Drucken Statistik der Törns
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

    Public Sub PrintStatistik(ByVal tIn As DataTable)
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
        Dim sSize As SizeF
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim rechts As Single
        Dim von As String = " "
        Dim text As String
        Dim hh As Single
        Dim name As String = " "
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 150
        xPos(2) = xPos(1) + 60
        xPos(3) = xPos(2) + 150
        xPos(4) = xPos(3) + 150
        xPos(5) = xPos(4) + 50
        xPos(6) = xPos(5) + 50
        xPos(7) = xPos(6) + 100
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("S t a t i s t i k ", printFont, Brushes.Black, xPos(3) - 60, topMargin, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin, New StringFormat())

        While zeile < (linesPerPage)
            row = dt.Rows(rNbr)
            If row Is Nothing Then
                Exit While
            End If
            Select Case row(0)
                Case "Skipper"
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Skipper:      ", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(2) + 50, yPos, New StringFormat())
                    von = "Skipper"
                Case "Statistik"
                    If von = "Skipper" Then
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                    End If

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Anzahl der Törns:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    hh = row(1)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '               ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Crewmitglieder:", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    hh = row(9)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '                ev.Graphics.DrawString(row(9), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Bordtage:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    hh = row(2)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '              ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    ev.Graphics.DrawString("Damen:", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    hh = row(11)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '                ev.Graphics.DrawString(row(11), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    var = row(11) * 100 / row(9)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(5) - sSize.Width.ToString + 35
                    ev.Graphics.DrawString(text + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '                  ev.Graphics.DrawString(Format$(var, "0.#") + " %", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Nachtfahrten:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    hh = row(3)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '               ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    var = row(3) * 100 / row(2)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(2) - sSize.Width.ToString + 35
                    ev.Graphics.DrawString(text + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '                ev.Graphics.DrawString(Format$(var, "0.#") + " %", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString("Herren:", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    hh = row(10)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '              ev.Graphics.DrawString(row(10), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    var = row(10) * 100 / row(9)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(5) - sSize.Width.ToString + 35
                    ev.Graphics.DrawString(text + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '                ev.Graphics.DrawString(Format$(var, "0.#") + " %", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("sm gesamt:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    hh = row(5)
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 50
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    ev.Graphics.DrawString("Durchschnittsalter:", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    var = row(14) / row(9)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 50
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '               ev.Graphics.DrawString(Format$(var, "0.#"), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("sm unter Segel:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    hh = row(6)
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 50
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '              ev.Graphics.DrawString(row(6), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    var = row(6) * 100 / row(5)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(2) - sSize.Width.ToString + 35
                    ev.Graphics.DrawString(text + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '              ev.Graphics.DrawString(Format$(var, "0.#") + " %", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString("Jüngster:", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    hh = row(12)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '               ev.Graphics.DrawString(row(12), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("sm im FB3:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    hh = row(7)
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 50
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '               ev.Graphics.DrawString(row(7), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    var = row(7) * 100 / row(5)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(2) - sSize.Width.ToString + 35
                    ev.Graphics.DrawString(text + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '             ev.Graphics.DrawString(Format$(var, "0.#") + " %", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString("Älterster:", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    hh = row(13)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '            ev.Graphics.DrawString(row(13), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("sm im FB4:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    hh = row(8)
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 50
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '             ev.Graphics.DrawString(row(8), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    var = row(8) * 100 / row(2)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(2) - sSize.Width.ToString + 35
                    ev.Graphics.DrawString(text + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '             ev.Graphics.DrawString(Format$(var, "0.#") + " %", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                    ev.Graphics.DrawString("Mehrmalsfahrer:", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                    hh = row(4)
                    text = Format$(hh, "#0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(4) - sSize.Width.ToString + 38
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '            ev.Graphics.DrawString(row(4), printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                    var = row(4) * 100 / row(9)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(5) - sSize.Width.ToString + 35
                    ev.Graphics.DrawString(text + " %", printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '                  ev.Graphics.DrawString(Format$(var, "0.#") + " %", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())

                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("sm Durchschnitt/Tag:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    var = row(5) / row(2)
                    hh = var
                    text = Format$(hh, "#0.0")
                    sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                    rechts = xPos(1) - sSize.Width.ToString + 50
                    ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    '              ev.Graphics.DrawString(Format$(var, "0.#"), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    '                   ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                    von = "Statistik"
                Case "Revier"
                    If Statistik.ckb_Revieruebersicht.Checked Then
                        If von = "Statistik" Then
                            zeile += 2
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString("Törns  Revier ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                            ev.Graphics.DrawString("Seemeilen ", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                            zeile += 1
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                        End If
                        '                 zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)

                        hh = row(3)
                        text = Format$(hh, "#0")
                        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                        rechts = xPos(0) - sSize.Width.ToString + 30
                        ev.Graphics.DrawString(text + "x", printFont, Brushes.Black, rechts, yPos, New StringFormat())

                        '              ev.Graphics.DrawString(row(3) + "x", printFont, Brushes.Black, xPos(0) + 5, yPos, New StringFormat())
                        ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(0) + 45, yPos, New StringFormat())
                        '                  ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                        hh = row(2)
                        text = Format$(hh, "#0.0")
                        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 50
                        ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    End If
                    von = "Revier"
                    SummeCrewSm = 0
                Case "Crew"
                    If Statistik.ckb_Mehrmalsfahrer.Checked Then
                        If von = "Revier" Then
                            zeile += 2
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString("Name                                 Törn ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                            ev.Graphics.DrawString("Seemeilen ", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                            zeile += 1
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                        End If
                        If Name4Summe <> row(1) Then
                            If SummeCrewSm > 0 Then
                                hh = SummeCrewSm
                                text = Format$(hh, "#0.0")
                                sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                                rechts = xPos(5) - sSize.Width.ToString + 60
                                yPos = topMargin + (zeile - 1) * printFont.GetHeight(ev.Graphics)
                                ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                                SummeCrewSm = row(3)
                                Name4Summe = row(1)
                            Else
                                Name4Summe = row(1)
                                SummeCrewSm += row(3)
                            End If
                        Else
                            SummeCrewSm += row(3)
                        End If
                        If name <> row(1) Then
                            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                            ev.Graphics.DrawString(row(1), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                            name = row(1)
                        End If
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(1) + 15, yPos, New StringFormat())
                        hh = row(3)
                        text = Format$(hh, "#0.0")
                        sSize = ev.Graphics.MeasureString(text, printFont, 1000)
                        rechts = xPos(4) - sSize.Width.ToString + 50
                        ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
                    End If
                        von = "Crew"
            End Select
            letztezeile = zeile
            zeile += 1
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While
        lastRow = rNbr
        If letztezeile < (linesPerPage) And rNbr >= dt.Rows.Count Then
            hh = SummeCrewSm
            text = Format$(hh, "#0.0")
            sSize = ev.Graphics.MeasureString(text, printFont, 1000)
            rechts = xPos(5) - sSize.Width.ToString + 60
            yPos = topMargin + (letztezeile) * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(text, printFont, Brushes.Black, rechts, yPos, New StringFormat())
        End If
        zeile = 10
        If Not (row Is Nothing) Then
            ev.HasMorePages = True
        End If

    End Sub
End Class
