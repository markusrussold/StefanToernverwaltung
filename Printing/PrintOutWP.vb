Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutWP
    '                                                    Wacheplan drucken
    Dim linesPerPage As Single = 0
    Dim Name4Summe As String = ""
    Dim SummeCrewSm As Single
    Dim printFonts As Font
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
    Dim seite As Boolean = True
    Dim logo As Image
    Public var As Single
    Dim Brush As New SolidBrush(Color.LightGray)
    Dim Schriftfarbe As New SolidBrush(Color.DarkOrange)
    Dim WacheAnzahl As Integer
    Public Sub PrintWacheplan(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        dt = tIn
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        dt = tIn
        printFont = New Font("Arial", 12)
        WacheAnzahl = Wacheplan.WacheAnzahl
        '       WacheAnzahl = WacheAnzahl / 2
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
        '          "toern", "person1", "datum1", "person2", "datum2", "methode"
        '           r0         r1       r2          r3          r4     r5
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim von As String = " "
        Dim name As String = " "
        Dim pers1 As String
        Dim pers2 As String
        Dim pers3 As String
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
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 180
        xPos(2) = xPos(1) + 220
        xPos(3) = xPos(2) + 150
        xPos(4) = xPos(3) + 150
        xPos(5) = xPos(4) + 50
        xPos(6) = xPos(5) + 50
        xPos(7) = xPos(6) + 100
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("W a c h e p l a n ", printFont, Brushes.Black, xPos(1), topMargin - 50, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 12)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(3) + 20, topMargin - 40, New StringFormat())
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        If seite Then
            ev.Graphics.DrawString("für Törn: " + row(0), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())
            zeile += 1


            While zeile < (linesPerPage)
                row = dt.Rows(rNbr)
                If Not IsDBNull(row(1)) Then
                    pers1 = row(1)
                Else
                    pers1 = ""
                End If
                If Not IsDBNull(row(3)) Then
                    pers2 = row(3)
                Else
                    pers2 = ""
                End If
                If Not IsDBNull(row(6)) Then
                    pers3 = row(6)
                Else
                    pers3 = ""
                End If
                dat1 = row(2)
                dat2 = row(4)
                row = dt.Rows(rNbr + 1)

                If row Is Nothing Or pers1 = "" Then
                    rNbr += 1
                    Exit While
                End If

                zeile += 1
                grauzaehler += 1
                Select Case grauzaehler
                    Case 1
                        Schriftfarbe = New SolidBrush(Color.Black)
                    Case 2
                        Schriftfarbe = New SolidBrush(Color.DarkOrange)
                        If grauzaehler = WacheAnzahl Then grauzaehler = 0
                    Case 3
                        Schriftfarbe = New SolidBrush(Color.DarkOrchid)
                        If grauzaehler = WacheAnzahl Then grauzaehler = 0
                    Case 4
                        Schriftfarbe = New SolidBrush(Color.Blue)
                        If grauzaehler = WacheAnzahl Then grauzaehler = 0
                End Select
                If Wacheplan.CheckBox1.Checked = True Then
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    If Wacheplan.CheckBox4.Checked = True Then
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pers1), "", pers1), printFont, Schriftfarbe, xPos(0), yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pers2), "", pers2), printFont, Schriftfarbe, xPos(1) - 70, yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pers3), "", pers3), printFont, Schriftfarbe, xPos(1) + 70, yPos, New StringFormat())
                    Else
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pers1), "", pers1), printFont, Schriftfarbe, xPos(0), yPos, New StringFormat())
                        ev.Graphics.DrawString(IIf(DBNull.Value.Equals(pers2), "", pers2), printFont, Schriftfarbe, xPos(1), yPos, New StringFormat())
                    End If
                    datum2 = row(2)
                    If Len(datum2) < 16 Then
                        datum2 = datum2 + " 00:00:00"
                    End If
                    datum1 = dat1
                    If Len(datum1) < 16 Then
                        datum1 = datum1 + " 00:00:00"
                    End If
                    tag1 = SafeData.FormatDateDe(datum1)
                    If tag1 <> datum11 Then                                             ' neuer Tag
                        wochentag = WeekdayName(Weekday(tag1, FirstDayOfWeek.Monday))
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                        ev.Graphics.DrawString(tag1, printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                        ev.Graphics.DrawString(wochentag, printFont, Brushes.Black, xPos(3), topMargin + (zeile + 1) * printFont.GetHeight(ev.Graphics), New StringFormat())
                        datum11 = tag1
                        '                   grauzaehler = 0
                    End If
                    ev.Graphics.DrawString(SafeData.FormatTimeHm(datum1) + " bis " + SafeData.FormatTimeHm(datum2), printFont, Schriftfarbe, xPos(2), yPos, New StringFormat())
                Else
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(pers1, printFont, Schriftfarbe, xPos(0), yPos, New StringFormat())
                    datum2 = row(2)
                    If Len(datum2) < 16 Then
                        datum2 = datum2 + " 00:00:00"
                    End If
                    datum1 = dat1
                    If Len(datum1) < 16 Then
                        datum1 = datum1 + " 00:00:00"
                    End If
                    tag1 = SafeData.FormatDateDe(datum1)
                    If tag1 <> datum11 Then
                        ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                        ev.Graphics.DrawString(tag1, printFont, Schriftfarbe, xPos(3), yPos, New StringFormat())
                        datum11 = tag1
                    End If
                    ev.Graphics.DrawString(SafeData.FormatTimeHm(datum1) + " bis " + SafeData.FormatTimeHm(datum2), printFont, Schriftfarbe, xPos(2), yPos, New StringFormat())
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(pers2, printFont, Schriftfarbe, xPos(1), yPos, New StringFormat())
                    datum2 = row(4)
                    If Len(datum2) < 16 Then
                        datum2 = datum2 + " 00:00:00"
                    End If
                    datum1 = dat2
                    If Len(datum1) < 16 Then
                        datum1 = datum1 + " 00:00:00"
                    End If
                    tag1 = SafeData.FormatDateDe(datum1)
                    ev.Graphics.DrawString(SafeData.FormatTimeHm(datum1) + " bis " + SafeData.FormatTimeHm(datum2), printFont, Schriftfarbe, xPos(2), yPos, New StringFormat())
                End If
                letztezeile = zeile
                rNbr += 1
                If rNbr >= dt.Rows.Count - 1 Then
                    row = Nothing
                    Exit While
                End If
            End While
            lastRow = rNbr
        End If
        If Not (row Is Nothing) And seite Then
            zeile = 5
            datum11 = " "
            ev.HasMorePages = True
        Else
            If seite Then
                seite = False
                ev.HasMorePages = True
            Else
                Nachsatz(zeile, ev, topMargin)
            End If
        End If

    End Sub
    Private Sub Nachsatz(ByRef zeile, ev, topmargin)
        zeile = 10
        xPos(0) = xPos(0) - 60
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.graphics.drawrectangle(Pens.Black, xPos(0) - 10, yPos, 720, 155)
        printFonts = New Font("Arial", 12, FontStyle.Bold)
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("Skipper verständigen bei:", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.03
        printFonts = New Font("Wingdings", 12, FontStyle.Bold)
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Wetterverschlechterung", printFont, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(1) + 100, yPos, New StringFormat())
        ev.Graphics.DrawString("Ausfall von Crewmitgliedern", printFont, Brushes.Black, xPos(1) + 120, yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Person über Bord", printFont, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(1) + 100, yPos, New StringFormat())
        ev.Graphics.DrawString("unklarer Standort", printFont, Brushes.Black, xPos(1) + 120, yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("unklare Schiffsbegegnungen", printFont, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(1) + 100, yPos, New StringFormat())
        ev.Graphics.DrawString("Störungen an der Yacht", printFont, Brushes.Black, xPos(1) + 120, yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("beim Einlaufen in Hafen", printFont, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(1) + 100, yPos, New StringFormat())
        ev.Graphics.DrawString("Empfang: Mayday, PanPan oder ", printFont, Brushes.Black, xPos(1) + 120, yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("         die Yacht wird gerufen", printFont, Brushes.Black, xPos(1) + 120, yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.03
        ev.Graphics.DrawString("Im Zweifel lieber einmal zu oft den Skipper verständigen!!!", printFont, Brushes.Black, xPos(1) - 40, yPos, New StringFormat())

        zeile += 4
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.graphics.drawrectangle(Pens.Black, xPos(0) - 10, yPos, 720, 140)
        printFonts = New Font("Arial", 12, FontStyle.Bold)

        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("Wacheübergabe mit:", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("Wacheführer muß Nachfolger ausführlich einweisen!!!", printFont, Brushes.Black, xPos(1) - 80, yPos, New StringFormat())
        zeile += 1
        printFonts = New Font("Wingdings", 12, FontStyle.Bold)
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Standort mit Länge und Breite, Kurs, Ziel", printFont, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Wetterentwicklung, Windrichtung, Windstärke", printFont, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.02
        ev.Graphics.DrawString("o", printFonts, Brushes.Black, xPos(0), yPos, New StringFormat())
        ev.Graphics.DrawString("Segelführung", printFont, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())

        zeile += 1
        yPos = topmargin + zeile * printFont.GetHeight(ev.Graphics) * 1.03
         printFonts = New Font("Arial", 12, FontStyle.Bold)
        ev.Graphics.DrawString("Die jeweils folgende Wache ist ca 10 Min vorher zu wecken.", printFonts, Brushes.Black, xPos(0) + 100, yPos, New StringFormat())
    End Sub
End Class
