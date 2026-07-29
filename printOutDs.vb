Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class printOutDs
    Public speicherbild As String
    Private printFont As Font
    Private printFontf As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Private anzahl As String
    Dim logo As Image
    Public var As Single
    Dim mmsi As String
    Dim bootsname As String
    Dim rNbr As Integer
    Dim schiffnr As String
    Dim Brush As New SolidBrush(Color.LightGray)
    Public Sub PrintDistress(ByVal tIn As DataTable)
        '                                                                               Distress Formular drucken
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
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim xPos(7) As Single
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim row As DataRow = Nothing
        Dim zeile As Single = 2
        Dim zz As Single = 1.2
        Dim xxx As Integer
        Dim yyy As Integer
        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        xPos(0) = leftMargin - 20
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
        row = dt.Rows(0)
        If row Is Nothing Then
            GoTo druckende
        End If
        xxx = leftMargin - 30
        Select Case rNbr
            Case 0
                row = dt.Rows(rNbr)
                printFont = New Font("Arial", 24, FontStyle.Bold)
                ev.Graphics.DrawString("D i s t r e s s   V o r l a g e n", printFont, Brushes.Black, xPos(2), topMargin, New StringFormat())
                If Not DBNull.Value.Equals(row(0)) Then
                    bootsname = row(0)
                Else
                    bootsname = "_______________________"
                End If
                schiffnr = "_______________________"
                If Not DBNull.Value.Equals(row(1)) Then
                    If row(1) <> " " Then
                        schiffnr = row(1)
                    End If
                End If
                mmsi = "_______________________"
                If Not DBNull.Value.Equals(row(2)) Then
                    If row(2) <> " " Then
                        mmsi = row(2)
                    End If
                End If

                row = dt.Rows(rNbr)
                '                                                Mayday

                zeile += 3
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Not Aussendung", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("Mayday     Mayday     Mayday", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("This is:  " + bootsname + ", " + bootsname + ", " + bootsname, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("Call sign: " + schiffnr, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("MMSI:     " + mmsi, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Mayday   " + bootsname + "   " + schiffnr + "   " + mmsi, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("My Position is ______________     ______________", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Art des Notfalls: ship is sinking (on fire, person over bord, ....", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Art der erbetenen Hilfe: I require immediate assistance", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                printFont = New Font("Arial", 14)
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                anzahl = Distress.crewanzahl
                ev.Graphics.DrawString(anzahl + " person incl. skipper on bord", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("OVER", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '             ev.Graphics.DrawLine(Pens.LightGray, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                '            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics) + 5
                '              ev.Graphics.DrawLine(Pens.LightGray, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)

                '                                               Hilfe anbieten

                zeile += 1
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Hilfe anbieten", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("Mayday", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("_________________ / call sign ______________", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Schiffsname  des FZ in Not                             Rufzeichen des FZ in Not", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("This is:  " + bootsname, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("My Position is ______________     ______________    ETE ________", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("OVER", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

                zeile += 1
                '               yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)


                '                                               Funkstille anfordern

                zeile += 1
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Funkstille für Notverkehr", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("All stations         oder Name der störenden Funkstelle", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("Silence Mayday", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                '               yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)


                '                                               Mayday beenden

                zeile += 1
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Notverkehr beenden", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("Mayday", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("This is:  " + bootsname + "/ " + schiffnr + " at  _________ (UTC)", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("_____________________/ ______________________", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Name des Schiffes in Not            Rufzeichen des Schiffes in Not  ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14, FontStyle.Bold)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Silence fini", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                '               yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)
            Case 1

                '                                              Fehlalarm Mayday aufheben

                printFont = New Font("Arial", 24, FontStyle.Bold)
                ev.Graphics.DrawString("D i s t r e s s   V o r l a g e n", printFont, Brushes.Black, xPos(2), topMargin, New StringFormat())
                zeile += 3
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Fehlalarm Mayday aufheben", printFont, Brushes.Black, xPos(4) - 30, yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("All Stations    All Stations    All Stations", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("This is:  " + bootsname + "/ " + schiffnr + "/ " + mmsi, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("On Position ______________     ______________", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Cancel my distress alert of  _________ (UTC) ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("OVER", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())

                zeile += 1
                '               yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)

                '                                                                                                           Notalarm weiterleten

                zeile += 1
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Notalarm weiterleiten", printFont, Brushes.Black, xPos(4), yPos, New StringFormat())
                zeile += 1
                printFont = New Font("Arial", 14, FontStyle.Bold)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Mayday Relay    Mayday Relay    Mayday Relay", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("This is:  " + bootsname + "/ " + schiffnr + "/ " + mmsi + " at  ________ (UTC)", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("on Chanel ___ following received                     following observed", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Mayday", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Wörtliche Wiederholung der empfangenen Notmeldung", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("This is:  " + bootsname + "/ " + schiffnr, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("OVER", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                '               yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)
            Case 2
                '                                                Pan Pan

                printFont = New Font("Arial", 24, FontStyle.Bold)
                ev.Graphics.DrawString("Drinlichkeitsverkehr", printFont, Brushes.Black, xPos(2), topMargin, New StringFormat())
                zeile += 3
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Pan Pan", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("Pan Pan     Pan Pan     Pan Pan     ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("All Stations    All Stations    All Stations", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("This is:  " + bootsname + ", " + schiffnr + ", " + mmsi, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("My Position is ______________     ______________", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Text der Meldung", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("OVER", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                '                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '               ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)

                '                                                                                                Aufhebung Pan Pan

                zeile += 1
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Pan Pan aufheben", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("Pan Pan     Pan Pan     Pan Pan     ", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("All Stations    All Stations    All Stations", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("This is:  " + bootsname + ", " + schiffnr + ", " + mmsi, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Cancel my urgency message of __________ UTC", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("OVER", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                '                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '               ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)

                '                                                                                         Securite

                zeile += 7
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 24, FontStyle.Bold)
                ev.Graphics.DrawString("Sicherheitsverkehr", printFont, Brushes.Black, xPos(2), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Securite", printFont, Brushes.Black, xPos(5), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("Securite     Securite     Securite", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14, FontStyle.Bold)
                ev.Graphics.DrawString("All Stations    All Stations    All Stations", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += zz
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 14)
                ev.Graphics.DrawString("This is:  " + bootsname + ", " + schiffnr + ", " + mmsi, printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                printFont = New Font("Arial", 11)
                ev.Graphics.DrawString("Text der Meldung", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 2
                printFont = New Font("Arial", 14)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("OVER", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                zeile += 1
                '               yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                '              ev.Graphics.DrawLine(Pens.Black, New Point(leftMargin - 60, yPos), New Point(ev.MarginBounds.Right + 40, yPos))
                yyy = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.FillRectangle(Brush, xxx, yyy, 720, 8)
            Case 3
                '                                                Int. Alphabet

                printFont = New Font("Arial", 24, FontStyle.Bold)
                ev.Graphics.DrawString("Internationales Buchstabieralhabet", printFont, Brushes.Black, xPos(1), topMargin, New StringFormat())
                zeile += 5
                printFont = New Font("Arial", 18)
                printFontf = New Font("Arial", 18)
                '               printFontf = New Font("Arial", 18, FontStyle.Bold)
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("A  Alfa", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("N  November", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("B  Bravo", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("O  Oscar", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("C  Charlie", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("P  Papa", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("D  Delta", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("Q  Quebec", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("E  Echo", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("R  Romeo", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("F  Foxtrot", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("S  Sierra", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("G  Golf", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("T  Tango", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("H  Hotel", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("U  Uniform", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("I  India", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("V  Viktor", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("J  Juliett", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("W  Whiskey", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("K  Kilo", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("X  X-ray", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("L  Lima", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("Y  Yankee", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 2
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("M  Mike", printFontf, Brushes.Black, xPos(0) + 20, yPos, New StringFormat())
                ev.Graphics.DrawString("Z  Zulu", printFont, Brushes.Black, xPos(3), yPos, New StringFormat())
                zeile += 1
        End Select
 
            '                                                                                                     Neue Seite
        rNbr += 1
        If row Is Nothing Or rNbr > 3 Then
            GoTo druckende
        End If

        ev.HasMorePages = True
druckende:
    End Sub
End Class
