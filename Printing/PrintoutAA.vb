Option Explicit On
Imports System.Drawing.Printing
Imports System.IO
Public Class PrintOutAA
    '                                                                                           Drucken Adressen
    Public speicherbild As String
    Private printFont As Font
    Private printFontf As Font
    Private ll As List(Of String)
    Private dt As DataTable
    Private lastRow As Integer = 0
    Private aaa As String
    Dim crewfoto As Image
    Dim quelle As String
    Dim headline1(13) As String
    Dim zeile As Integer = 4
    Dim i As Integer
    Dim logo As Image
    Dim yPos As Single = 0
    Dim yypos As Single
    Dim xPos(7) As Single
    Dim fb As String
    Dim bootfoto As Image
    Dim BildB As Single
    Dim bildh As Single
    Dim faktor As Single
    Dim pixel As GraphicsUnit = GraphicsUnit.Pixel
    Dim bildbb As Single = 350
    Dim foto As String = GetSetting("Foto", "Pfad", "T")
    Dim topMargin As Single

    Public Sub PrintAdressen(ByVal tIn As DataTable)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        dt = tIn
        printFont = New Font("Arial", 10)
        printFontf = New Font("Arial", 10, FontStyle.Bold)
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
        pd.Print()
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim row As DataRow = Nothing
        Dim rNbr As Integer
        Dim sSize As SizeF
        Dim breite As Integer
        Dim aschein As String
        Dim donau As String
        Dim zeilenanfang As Integer
        Dim check4 As Boolean = True
        Dim check5 As Boolean = True
        Dim acheckbox1 As Boolean = True
        Dim acheckbox2 As Boolean = True
        Dim acheckbox3 As Boolean = True
        Dim acheckbox4 As Boolean = True
        Dim acheckbox5 As Boolean = True
        Dim acheckbox6 As Boolean = True
        Dim acheckbox7 As Boolean = True
        Dim acheckbox8 As Boolean = True
        Dim acheckbox9 As Boolean = True
        Dim acheckbox10 As Boolean = True
        Dim acheckbox11 As Boolean = True
        Dim acheckbox12 As Boolean = True
        Dim acheckbox13 As Boolean = True
        Dim acheckbox19 As Boolean = False
        topMargin = ev.MarginBounds.Top

        If Crew.crewprogramm Then
            check4 = Crew.CheckBox4.Checked
            check5 = Crew.CheckBox5.Checked
        Else
            acheckbox1 = Adressen.CheckBox1.Checked
            acheckbox2 = Adressen.CheckBox2.Checked
            acheckbox3 = Adressen.CheckBox3.Checked
            acheckbox4 = Adressen.CheckBox4.Checked
            acheckbox5 = Adressen.CheckBox5.Checked
            acheckbox6 = Adressen.CheckBox6.Checked
            acheckbox7 = Adressen.CheckBox7.Checked
            acheckbox8 = Adressen.CheckBox8.Checked
            acheckbox9 = Adressen.CheckBox9.Checked
            acheckbox10 = Adressen.CheckBox10.Checked
            acheckbox11 = Adressen.CheckBox11.Checked
            acheckbox12 = Adressen.CheckBox12.Checked
            acheckbox13 = Adressen.CheckBox13.Checked
            acheckbox19 = Adressen.CheckBox19.Checked
        End If

        leftMargin = ev.MarginBounds.Left
        topMargin = ev.MarginBounds.Top

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        '        Überschrift
        If speicherbild > " " Then
            logo = Image.FromFile(Trim$(speicherbild))
        End If
        xPos(0) = leftMargin
        xPos(1) = xPos(0) + 150
        xPos(6) = xPos(1) + 450
        If speicherbild > " " Then
            ev.Graphics.DrawImage(logo, New Point(ev.MarginBounds.Left - 90, topMargin - 90))
        End If
        zeile = 4
        printFont = New Font("Arial", 18, FontStyle.Bold)
        ev.Graphics.DrawString("Adressenauswertung", printFont, Brushes.Black, 340, topMargin - 10, New StringFormat())
        printFont = New Font("Arial", 14, FontStyle.Bold)
        sSize = ev.Graphics.MeasureString(Adressen.TextBox6.Text, printFont, 1000)
        breite = sSize.Width.ToString / 2
        ev.Graphics.DrawString(Adressen.TextBox6.Text, printFont, Brushes.Black, 470 - breite, topMargin + 15, New StringFormat())
        row = dt.Rows(0)
        printFont = New Font("Arial", 10)
        ev.Graphics.DrawString(Today, printFont, Brushes.Black, xPos(6), topMargin, New StringFormat())

        rNbr = lastRow
        row = dt.Rows(rNbr)
        '       zeile += 1
        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
        yypos = yPos

        'zeigt nur wie Texte abgemessen werden, hat sonst keine Funktion
        sSize = ev.Graphics.MeasureString("ABSC", printFont, 1000)
        zeile += 3

        While zeile < (linesPerPage - 1)
            row = dt.Rows(rNbr)
            fb = " "
            If row(16) Then               ' FB1
                fb = "FB1"
            End If
            If row(17) Then               ' FB2
                fb = "FB2"
            End If
            If row(18) Then               ' FB3
                fb = "FB3"
            End If
            If row(19) Then               ' FB4
                fb = "FB4"
            End If
            If row(21) Then
                donau = "Donaupatent"
            Else
                donau = " "
            End If
            If row(20) Then
                aschein = "A-Schein"
            Else
                aschein = " "
            End If
          zeile += 1
            yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
            '               Spalte 1
            ev.Graphics.DrawString("Name:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())      '     Name
            ev.Graphics.DrawString(row(2) + " " + row(0) + " " + row(1), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '     Name
            zeilenanfang = zeile
            If IsDBNull(row(5)) Or acheckbox3 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Adresse:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())      '     Adresse
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(5)), "", row(5) + ", " + row(6) + " " + row(7) + ", " + row(22)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '     Adresse
            End If

            If IsDBNull(row(9)) Or acheckbox9 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                If IsDBNull(row(10)) Then
                    ev.Graphics.DrawString("Geburtsdatum:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())     '       Geburtsdatum
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "", row(9)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '       Geburtsdatum
                Else
                    ev.Graphics.DrawString("Geburtsdatum/Ort:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())     '       Geburtsdatum/Ort
                    ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(9)), "", row(9) + "/" + row(10)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '       Geburtsdatum
                End If
            End If

            If IsDBNull(row(14)) Or acheckbox6 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Status:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())      '     Status
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(14)), "", row(14)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '     Status
            End If

            If IsDBNull(row(3)) Or acheckbox2 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Handy:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())           '      Handy
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(3)), "", row(3)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())           '      Handy
            End If

            If IsDBNull(row(15)) Or acheckbox10 = False Then
            Else
                If row(15) > "" And check4 Then
                    zeile += 1
                    yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString("Bemerkung:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())      '     Bemerkung
                    zeile -= 1
                    quelle = row(15)
                    zeile = Langtext.LangtextDrucken(quelle, zeile, yPos, printFont, xPos(1), ev, linesPerPage)
                End If
            End If

            If IsDBNull(row(13)) Or acheckbox5 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Nationalität:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())      '       Nationalität
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(13)), "", row(13)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '       Nationalität
            End If

            If IsDBNull(row(4)) Or acheckbox4 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("e-mail:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())       '    e-mail
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(4)), "", row(4)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())       '    e-mail
            End If

            If IsDBNull(row(8)) Or acheckbox13 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Reisepass Nr.:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())       '    Reisepass Nr.
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(8)), "", row(8)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Reisepass Nr.
            End If

            If fb > " " And acheckbox7 = True Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Segelschein:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())       '        Segelschein
                ev.Graphics.DrawString(fb, printFont, Brushes.Black, xPos(1), yPos, New StringFormat())       '        Segelschein
            End If

            If IsDBNull(row(11)) Or acheckbox8 = False Then
            Else
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Funklizenz:", printFont, Brushes.Black, xPos(0), yPos, New StringFormat())       '        Funklizenz
                ev.Graphics.DrawString(IIf(DBNull.Value.Equals(row(11)), "", row(11)), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())       '        Funklizenz
            End If

            If aschein > " " And acheckbox11 = True Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("A-Schein", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '        A-Schein
                '           ev.Graphics.DrawString(IIf(DBNull.Value.Equals(aschein), "", aschein), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())      '        A-Schein

            End If
            If donau > " " And acheckbox12 = True Then
                zeile += 1
                yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString("Donaupatent", printFont, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Donaupatent
                '          ev.Graphics.DrawString(IIf(DBNull.Value.Equals(donau), "", donau), printFont, Brushes.Black, xPos(1), yPos, New StringFormat())       '    Donaupatent
            End If


            If Crew.crewprogramm Then                                           '       Foto und Törns drucken
                aaa = row(1) + row(0)
                aaa = aaa.Replace(" ", "")
                If My.Computer.FileSystem.FileExists(Trim$((foto + aaa + ".jpg"))) Then
                    crewfoto = Image.FromFile(Trim$((foto + aaa + ".jpg")))
                    BildB = crewfoto.Width
                    bildh = crewfoto.Height
                    faktor = BildB / bildh
bild2:
                    If bildbb / faktor > 400 Then
                        bildbb -= 10
                        GoTo bild2
                    End If
                    ev.Graphics.DrawImage(crewfoto, New Rectangle(ev.MarginBounds.Left + xPos(6) - bildbb, yPos, bildbb, bildbb / faktor))
                End If
                If check5 Then
                    If Crew.ListBox1.Items.Count > 0 Then
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString("Törn:", printFontf, Brushes.Black, xPos(0), yPos, New StringFormat())
                    End If
                    For Me.i = 0 To Crew.ListBox1.Items.Count - 1
                        zeile += 1
                        yPos = topMargin + zeile * printFont.GetHeight(ev.Graphics)
                        ev.Graphics.DrawString(Crew.ListBox1.Items(Me.i), printFont, Brushes.Black, xPos(0), yPos, New StringFormat())
                    Next
                End If
            End If
            If acheckbox19 = True Then Kleinfoto(row(1), row(0), ev, zeilenanfang)

            zeile += 1
            rNbr += 1
            If rNbr >= dt.Rows.Count Then
                row = Nothing
                Exit While
            End If
        End While

        '  If more lines exist, print another page.
        lastRow = rNbr
        ev.HasMorePages = True
        zeile = 0
        If Not (row Is Nothing) Then
        Else
            ev.HasMorePages = False
        End If
    End Sub
    Private Sub Kleinfoto(ByVal vorname, ByVal name, ByVal ev, ByVal za)
        Dim ZeilenDiff As Integer = zeile - za
        aaa = vorname + name
        aaa = aaa.Replace(" ", "")
        If My.Computer.FileSystem.FileExists(Trim$((foto + aaa + ".jpg"))) Then
            crewfoto = Image.FromFile(Trim$((foto + aaa + ".jpg")))
            BildB = crewfoto.Width
            bildh = crewfoto.Height
            faktor = BildB / bildh
bild2:
            If bildbb / faktor > 60 Then
                bildbb -= 10
                GoTo bild2
            End If
            yPos = topMargin + za * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawImage(crewfoto, New Rectangle(ev.MarginBounds.Left + xPos(6) - bildbb, yPos, bildbb, bildbb / faktor))
            If ZeilenDiff < 4 Then zeile = za + 4
        End If

    End Sub
End Class

