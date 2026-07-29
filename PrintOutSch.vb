Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutSch
    '                                                        Versicherungsschaden
    Dim xPos(7) As Single
    Dim linesPerPage As Single = 0
    Dim row As DataRow = Nothing
    Dim zeile As Integer = 5
    Dim letztezeile As Integer
    Dim rNbr As Integer
    Public speicherbild As String
    Private printFont As Font
    Private printFontf As Font
    Private dt As DataTable
    Private lastRow As Integer = 0
    Dim yPos As Single = 0
    Dim logo As Image
    Dim aaa As String
    Public Sub PrintVersicherungsSchaden(ByVal tIn As DataTable)
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
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim grauzaehler As Integer = 0
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 50
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
        ev.Graphics.DrawString("S c h a d e n m e l d u n g", printFont, Brushes.Black, xPos(2), topMargin - 50, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        printFontf = New Font("Arial", 10, FontStyle.Bold)
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(5), topMargin - 30, New StringFormat())

        Select Case row(38)
            Case 1
                aaa = "Haftpflicht Versicherung"
            Case 2
                aaa = "Kaution Versicherung"
            Case 3
                aaa = "Rücktritt Versicherung"
        End Select

        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString("Polizze: " + row(0), printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        ev.Graphics.DrawString(aaa, printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
        zeile += 1

        '          "Polizze", "Törn", "Schadensnummer", "Schadensbetrag", "Bemerkung", "Bearbeiter", "Bea-Mail", "Bea-Telefon", "Schadensort", "Datum", "Versicherungsart"
        '           r0         r1       r2              r3                 r4            r5           r6           r7             r8            r9       r10



        '          "Schadensbeschreibung", "wie", "R1", "R2", "R3", "BelegKaution", "BelegRep", "BelegDieb", "Hafenkapitaen", "VersicherungCharter", "Versicherunggegner"
        '           r11                    r12     r13   r14   r15    r16            r17         r18           r19             r20                    r21    



        '          "Chartermeldung", "Skizze", "Segelfuehrung", "Windrichtung", "MotorAnAus", "KursEigen", "KursGegner", "Zeugen", "Arztbesch", "Flugstornor", "Charterstorno"
        '           r22               r23       r24              r25             r26           r27          r28           r29          r30        r31           r32 


        '          "was", "uhrzeit", "foto1", "foto2", "foto3", "Schadensart" 
        '           r33   r34         r35      r36      r37      r38


        While zeile < (linesPerPage)
            If Not IsDBNull(row(2)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Schadensnummer:   ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(2), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(8)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Ort:  ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(8), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(9)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Datum: ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(9), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(3)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Schadenshöhe €: ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(3), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(11)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Schadensbeschreibung: ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                LangXText.LangXtextDrucken(row(11), zeile, yPos, printFont, xPos(1), ev, 100)
            End If

            If Not IsDBNull(row(4)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Bemerkung: ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                LangXText.LangXtextDrucken(row(4), zeile, yPos, printFont, xPos(1), ev, 100)
             End If

            If Not IsDBNull(row(12)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Wie: ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(12), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(24)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Segelführung:             ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(24), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(25)) Then
                zeile += 1
                aaa = row(25)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Windrichtung: ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(aaa + "°", printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(26)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Motor: ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(26), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(27)) Then
                zeile += 1
                aaa = row(27)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Eigener Kurs:               ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(aaa + "°", printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(28)) Then
                zeile += 1
                row(28) = aaa
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Kurs Gegner:              ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(aaa + "°", printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If


            If Not IsDBNull(row(29)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Zeugen:  ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(29), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(33)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Was:  ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(33), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If

            If Not IsDBNull(row(34)) Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Uhrzeit:   ", printFontf, Brushes.Black, xPos(1), yPos, New StringFormat())
                ev.Graphics.DrawString(row(34), printFont, Brushes.Black, xPos(1) + 130, yPos, New StringFormat())
            End If






            rNbr += 1
            If rNbr >= dt.Rows.Count - 1 Then
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
    Private Sub foto(ByVal ev)
        Dim topMargin As Single = ev.MarginBounds.Top
        If Not DBNull.Value.Equals(row(35)) Then
            If row(35) > " " Then
                If My.Computer.FileSystem.FileExists(row(35)) Then
                    logo = Image.FromFile(Trim$(row(35)))
                    Dim imgWidth As Integer = logo.Width
                    Dim imgHeight As Integer = logo.Height
                    Dim imgRatio As Single
                    If imgHeight > imgWidth Then
                        '                                     Hochformat
                        If imgHeight > 600 Then
                            imgRatio = imgHeight / 600
                            imgWidth = imgWidth / imgRatio
                            imgHeight = 600
                        End If
                        If imgWidth > 550 Then
                            imgRatio = imgWidth / 550
                            imgHeight = imgHeight / imgRatio
                            imgWidth = 550
                        End If
                        zeile += 2
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawImage(logo, New Rectangle(xPos(1), yPos, imgWidth, imgHeight))
                        '                           caverh(leftMargin, topMargin, ev)
                    Else
                        '                                    Breitformat
                        If imgHeight > 500 Then
                            imgRatio = imgHeight / 500
                            imgWidth = imgWidth / imgRatio
                            imgHeight = 500
                            '                                  End If
                            'If imgWidth > 550 Then
                            '                                        imgRatio = imgWidth / 550
                            '      imgHeight = imgHeight / imgRatio
                            '                                       imgWidth = 550
                        End If
                        zeile += 2
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawImage(logo, New Rectangle(xPos(2) + 20 - (imgWidth / 2), yPos, imgWidth, imgHeight))
                        '                         caverb(leftMargin, topMargin, ev)
                    End If
                End If
            End If
        End If

    End Sub
End Class
