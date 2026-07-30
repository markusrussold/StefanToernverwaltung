Public Class Logdaten
    Dim toerna As String
    Dim aaa As String = 1
    Dim Wacheplanleer As Boolean = False
    Dim luftdruck As Integer = 0
    Dim windrichtung As String = ""
    Dim bewolkung As String = ""
    Dim aenderungD As Boolean
    Dim aenderungL As Boolean = False
    Dim logSeite As Boolean
    Dim aktuellerTag As Date
    Dim motorStd As Single
    Dim rowNr As Integer
    Dim letzteuhrzeit As String = "00:00"
    Dim colNr As Integer
    Dim datvon As String
    Dim textänderung As Boolean
    Dim datbis As String
    Dim ortZiel As String
    Dim anzahlAlpha As Integer
    Dim antrieb As String
    Dim LogWaCount As Integer = 0
    Dim Windstaerke As String = " "
    Dim Seegangalt As String = " "
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Dokumentation
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Logdaten
    Dim WAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' LogWacheplan
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Törn Wacheplan
    Dim nAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Törnname

    Private Sub Logdaten_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Dokumentation". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taDokumentation.Fill(Me.DsLogbuch.Dokumentation)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.LogWacheplan". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taLogWacheplan.Fill(Me.DsLogbuch.LogWacheplan)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Logdaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taLogdaten.Fill(Me.DsLogbuch.Logdaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch2.LogWacheplan". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taWacheplan.Fill(Me.dsToernverwaltung.Wacheplan)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        toerna = GetSetting("Toern", "Logbuch", "T", "")
        If toerna > "" Then
            Me.Text = "Logdaten für Törn: " + toerna
        Else
            MsgBox("Zuerst muss der Törn in den Logbuch/Törndaten definiert werden")
            Me.Close()
        End If
         Dim rn As System.Data.DataRowView = bsToernname.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & toerna & "' "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        pAdapter.Fill(dsToernverwaltung.Toernname)
        datvon = dsToernverwaltung.Toernname.Rows(0)("Datumvon")
        datbis = dsToernverwaltung.Toernname.Rows(0)("Datumbis")

        MaskedTextBox2.Mask = "00.00.0000"
        MaskedTextBox3.Mask = "00:00"
        MaskedTextBox1.Mask = "00:00"
        MaskedTextBox4.Mask = "00°00.0'L    000°00.0'L"
        ComboBox2.Items.Add("N")
        ComboBox2.Items.Add("NO")
        ComboBox2.Items.Add("O")
        ComboBox2.Items.Add("SO")
        ComboBox2.Items.Add("S")
        ComboBox2.Items.Add("SW")
        ComboBox2.Items.Add("W")
        ComboBox2.Items.Add("NW")

        ComboBox1.Items.Add("0")
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.Items.Add("9")

        ComboBox3.Items.Add("wolkenlos")
        ComboBox3.Items.Add("sonnig 1/8")
        ComboBox3.Items.Add("heller 2/8")
        ComboBox3.Items.Add("leicht bewölkt 3/8")
        ComboBox3.Items.Add("wolkig 4/8")
        ComboBox3.Items.Add("bewölkt 5/8")
        ComboBox3.Items.Add("stark bewölkt 6/8")
        ComboBox3.Items.Add("fast bedeckt 7/8")
        ComboBox3.Items.Add("bedeckt 8/8")
        ComboBox3.Items.Add("nicht erkennbar")

        ComboBox4.Items.Add("M")
        ComboBox4.Items.Add("M ge")
        ComboBox4.Items.Add("M gr")
        ComboBox4.Items.Add("M GR")
        ComboBox4.Items.Add("M GE")
        ComboBox4.Items.Add("M gr ge")
        ComboBox4.Items.Add("M GR GE")
        ComboBox4.Items.Add("m")
        ComboBox4.Items.Add("m GR")
        ComboBox4.Items.Add("m GE")
        ComboBox4.Items.Add("m GR GE")
        ComboBox4.Items.Add("GE")
        ComboBox4.Items.Add("ge")
        ComboBox4.Items.Add("GR GE")
        ComboBox4.Items.Add("gr ge")

        Dim rw As System.Data.DataRowView = bsLogWacheplan.Current
        WAdapter.SelectCommand = New OleDb.OleDbCommand
        WAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        WAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & toerna & "' order by datum"
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        WAdapter.Fill(DsLogbuch.LogWacheplan)
        aaa = bsLogWacheplan.Count
        LogWaCount = bsLogWacheplan.Count
        If aaa > 0 Then
            If DsLogbuch.LogWacheplan.Rows(0)("Person3").ToString > "" Then
                DataGridView2.Columns(2).HeaderText = "Wachführer"
                DataGridView2.Columns(3).HeaderText = "Navigator"
                DataGridView2.Columns(4).HeaderText = "Rudergänger"
            Else
                DataGridView2.Columns(2).HeaderText = "Wachführer Navigator"
                DataGridView2.Columns(3).HeaderText = "Rudergänger"
                DataGridView2.Columns(4).HeaderText = ""
            End If
        End If
        If LogWaCount = 0 Then Wacheplanleer = True
        suchenDoku1()
        MaskedTextBox2.Enabled = False
        Leerzeilen()
        Leerzeilen()
    End Sub
    Private Sub suchenDoku1()                                                    ' lesen letzten Tag
        Dim rp As System.Data.DataRowView = bsDokumentation.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Dokumentation where toernbezeichnung = '" & toerna & "'  order by datum"
        bsDokumentation.CancelEdit()
        DsLogbuch.Dokumentation.Clear()
        pAdapter.Fill(DsLogbuch.Dokumentation)
        aaa = bsDokumentation.Count
        bsDokumentation.Position = bsDokumentation.Count - 1
        If TextBox26.Text = "" Then
            aktuellerTag = datvon
            TextBox26.Text = datvon
        Else
            aktuellerTag = TextBox26.Text
            ortZiel = TextBox8.Text
            If TextBox15.Text > "" Then
                motorStd = TextBox15.Text
            End If
        End If
        Select Case aaa
            Case 0
                bsDokumentation.AddNew()
                TextBox26.Text = datvon
                MaskedTextBox2.Text = datvon
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Wochentag()
                wacheplan()
            Case 1
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Wochentag()
                wacheplan()
            Case Else
                Label27.Visible = False
                Label29.Visible = False
                bsDokumentation.Position = aaa - 1
                aenderungD = True
                logSeite = False
                aenderungL = False
                Wochentag()
                wacheplan()
        End Select
        gbDoku.Location = New Point(17, 40)
        gbFahrt.Location = New Point(17, 4000)
        Label29.Visible = True
    End Sub
    Private Sub Label28_Click(sender As System.Object, e As System.EventArgs) Handles Label28.Click
        speichernFragen(sender, e)
        aktuellerTag = DateAdd(DateInterval.Day, -1, aktuellerTag)
        If datvon <= aktuellerTag And datbis >= aktuellerTag Then
            MaskedTextBox2.Text = aktuellerTag
            Label27.Visible = False
            Label26.Visible = True
            AT_Lesen()
        Else
            MsgBox("Datum " & Convert.ToString(aktuellerTag) & " liegt vor dem Törnbeginn.")
            aktuellerTag = DateAdd(DateInterval.Day, 1, aktuellerTag)
        End If
    End Sub
    Private Sub dokulesen()
        MaskedTextBox2.Text = aktuellerTag
        Dim datmu As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
        datmu = DateAdd(DateInterval.Day, -1, datmu)
        MaskedTextBox2.Text = CStr(datmu)
        Dim mmon As Single = Month(datmu)
        Dim ttag As Single = datmu.Day
        Dim yyear As Single = Year(datmu)
        Dim rp As System.Data.DataRowView = bsDokumentation.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Dokumentation where toernbezeichnung = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "'  order by datum"
        bsDokumentation.CancelEdit()
        DsLogbuch.Dokumentation.Clear()
        pAdapter.Fill(DsLogbuch.Dokumentation)
        Select Case bsDokumentation.Count
            Case 0
                bsDokumentation.AddNew()
                MaskedTextBox2.Text = CStr(datmu)
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                MaskedTextBox2.Focus()
            Case 1
                Label27.Visible = False
                Label28.Visible = True
                Label29.Visible = True
                Label26.Visible = True
                Wochentag()
                wacheplan()
                '               Label29.Visible = False
            Case Else
                Label27.Visible = False
                Label29.Visible = False
                bsDokumentation.Position = aaa - 1
                aenderungD = True
                logSeite = False
                aenderungL = False
                wacheplan()
        End Select
        gbDoku.Visible = True
        gbDoku.Location = New Point(17, 18)
        gbFahrt.Visible = False
    End Sub
    Private Sub Label28_MouseHover(sender As Object, e As System.EventArgs) Handles Label28.MouseHover
        Label31.Visible = True
    End Sub
    Private Sub Label28_MouseLeave(sender As Object, e As System.EventArgs) Handles Label28.MouseLeave
        Label31.Visible = False
    End Sub
    Private Sub Label26_Click(sender As System.Object, e As System.EventArgs) Handles Label26.Click
        speichernFragen(sender, e)
        gbDoku.Visible = False
        gbFahrt.Visible = True
        gbFahrt.Location = New Point(17, 18)
        Label27.Visible = True
        Label26.Visible = False
        logSeite = True
        gbFahrt.Text = "Fahrt log am " + Label13.Text + " den " + MaskedTextBox2.Text
        '       aenderungL = True
        Dim datmu As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
        Dim mmon As Single = Month(datmu)
        Dim ttag As Single = datmu.Day
        Dim yyear As Single = Year(datmu)
        Dim rx As System.Data.DataRowView = bsDokumentation.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' order by uhrzeit"
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        xAdapter.Fill(DsLogbuch.Logdaten)
        aaa = bsLogdaten.Count
        bsLogdaten.AddNew()
        '      MaskedTextBox3.Focus()
    End Sub
    Private Sub Label26_MouseHover(sender As Object, e As System.EventArgs) Handles Label26.MouseHover
        Label32.Visible = True
    End Sub
    Private Sub Label26_MouseLeave(sender As Object, e As System.EventArgs) Handles Label26.MouseLeave
        Label32.Visible = False
    End Sub
    Private Sub Label27_Click(sender As System.Object, e As System.EventArgs) Handles Label27.Click
        '     suchenDoku()
        speichernFragen(sender, e)
        Label27.Visible = False
        Label26.Visible = True
        AT_Lesen()
    End Sub
    Private Sub Label27_MouseHover(sender As Object, e As System.EventArgs) Handles Label27.MouseHover
        Label33.Visible = True
    End Sub
    Private Sub Label27_MouseLeave(sender As Object, e As System.EventArgs) Handles Label27.MouseLeave
        Label33.Visible = False
    End Sub
    Private Sub Label29_Click(sender As System.Object, e As System.EventArgs) Handles Label29.Click
        speichernFragen(sender, e)
        aktuellerTag = DateAdd(DateInterval.Day, 1, aktuellerTag)
        If datvon <= aktuellerTag And datbis >= aktuellerTag Then
            MaskedTextBox2.Text = aktuellerTag
            Label27.Visible = False
            Label26.Visible = True
            ortZiel = TextBox8.Text
            If TextBox15.Text > "" Then
                motorStd = TextBox15.Text
            End If
            AT_Lesen()
        Else
            MsgBox("Datum " & Convert.ToString(aktuellerTag) & " liegt nach/vor dem Törn.")
            aktuellerTag = DateAdd(DateInterval.Day, -1, aktuellerTag)
        End If
    End Sub
    Private Sub AT_Lesen()
        Dim datmu As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
        '       datmu = DateAdd(DateInterval.Day, 1, datmu)
        MaskedTextBox2.Text = CStr(datmu)
        Dim mmon As Single = Month(datmu)
        Dim ttag As Single = datmu.Day
        Dim yyear As Single = Year(datmu)
        Dim rp As System.Data.DataRowView = bsDokumentation.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Dokumentation where toernbezeichnung = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "'  order by datum"
        bsDokumentation.CancelEdit()
        DsLogbuch.Dokumentation.Clear()
        pAdapter.Fill(DsLogbuch.Dokumentation)
        '      bsDokumentation.Position = bsDokumentation.Count - 1
        Label28.Visible = True
        Label29.Visible = True
        Select Case bsDokumentation.Count
            Case 0
                bsDokumentation.AddNew()
                MaskedTextBox2.Text = CStr(datmu)
                Label26.Visible = False
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                If ortZiel > "" Then
                    TextBox7.Text = ortZiel
                    TextBox14.Text = motorStd
                End If
                MaskedTextBox2.Focus()
                Wochentag()
                wacheplan()
             Case 1
                Label26.Visible = True
                Label27.Visible = False
                Label28.Visible = True
                Label29.Visible = True
                Wochentag()
                wacheplan()
            Case Else
                bsDokumentation.Position = aaa - 1
                aenderungD = True
                aenderungL = False
        End Select
        logSeite = False
        '       If gbDoku.Visible = True Then
        gbDoku.Visible = True
        gbDoku.Location = New Point(17, 40)
        gbFahrt.Visible = False
    End Sub
    Private Sub Label29_MouseHover(sender As Object, e As System.EventArgs) Handles Label29.MouseHover
        Label34.Visible = True
    End Sub
    Private Sub Label29_MouseLeave(sender As Object, e As System.EventArgs) Handles Label29.MouseLeave
        Label34.Visible = False
    End Sub
    Private Sub TagesbuchungLesen()
        Dim datmu As Date
        Dim mmon As Single
        Dim ttag As Single
        Dim yyear As Single
        Dim i As Integer
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
        mmon = Month(datmu)
        ttag = datmu.Day
        yyear = Year(datmu)
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' order by uhrzeit"
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        xAdapter.Fill(DsLogbuch.Logdaten)
        If bsLogdaten.Count = 1 Then
            letzteuhrzeit = "00:00"
        Else
            i = bsLogdaten.Count - 1
            letzteuhrzeit = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
        End If

    End Sub
    Private Sub tagessprung(sender, e)
        Dim msg As Integer
        '      TagesbuchungLesen()
        If MaskedTextBox3.Text < letzteuhrzeit Then
            msg = MsgBox(" Logbucheintrag am nächsten Tag?", 4, "Tagänderung")
            If msg = vbYes Then
                ' Buchung am nächsten Tag
                Label29_Click(sender, e)
                TextBox21.Text = MaskedTextBox2.Text
            End If
        End If
    End Sub
    Private Sub speichern(sender, e)
        Dim msg As Integer
        textänderung = False
        TextBox19.Text = toerna
        TextBox20.Text = toerna
        TextBox21.Text = MaskedTextBox2.Text
        Dim motor As Boolean
        Dim gross As Boolean
        Dim genua As Boolean
        Dim distanzr As Single
        Dim distanzt As Single = 0
        Dim i As Integer
        Dim datmu As Date
        Dim mmon As Single
        Dim ttag As Single
        Dim yyear As Single
        aktuellerTag = MaskedTextBox2.Text
        If logSeite Then
            If TextBox5.Text = "" And ComboBox4.Text > "" Then
                MsgBox("Distanz des Tages ist nicht versorgt, speichern ist nicht möglich.")
                GoTo endesub
            End If
            If TextBox5.Text = "" And ComboBox4.Text = "" Then
                bsLogdaten.AddNew()
                taLogdaten.Update(DsLogbuch.Logdaten)
                GoTo endesub
            End If
            If MaskedTextBox3.Text.Substring(0, 2) < "00" And TextBox5.Text > "" Then
                MsgBox("Uhrzeit nicht versorgt, speichern nicht möglich!")
                GoTo endesub
            End If
            '                                     Daten zwischenspeichern
            luftdruck = TextBox3.Text
            windrichtung = ComboBox2.Text
            Windstaerke = TextBox2.Text
            Seegangalt = ComboBox1.Text
            bewolkung = ComboBox3.Text
            antrieb = ComboBox4.Text

            '
            If aenderungL Then
                If TextBox5.Text = "" Or TextBox5.Text = " " Or TextBox5.Text = "0" Then
                    msg = MsgBox(" Zeile löschen", 4, "Löschen")
                    If msg = vbOK Then
                        bsLogdaten.RemoveCurrent()
                        taLogdaten.Update(DsLogbuch.Logdaten)
                    Else
                        bsLogdaten.EndEdit()
                        taLogdaten.Update(DsLogbuch.Logdaten)
                        PublishDriveStatusToPipe(antrieb)
                    End If
                Else
                    bsLogdaten.EndEdit()
                    taLogdaten.Update(DsLogbuch.Logdaten)
                    PublishDriveStatusToPipe(antrieb)
                End If
            Else
                tagessprung(sender, e)
                If TextBox3.Text > "" Then
                    luftdruck = TextBox3.Text
                End If
                bewolkung = ComboBox3.Text
                bsLogdaten.AddNew()
                taLogdaten.Update(DsLogbuch.Logdaten)
                PublishDriveStatusToPipe(antrieb)
            End If

            TagesTrace0(distanzt)                   ' Tagesdistanz des Vortages übernehmen wenn nicht mit 0 begonnen

            '          TagesbuchungLesen()
            If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then GoTo endesub
            mmon = Month(datmu)
            ttag = datmu.Day
            yyear = Year(datmu)
            xAdapter.SelectCommand = New OleDb.OleDbCommand
            xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
            xAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' order by uhrzeit"
            bsLogdaten.CancelEdit()
            DsLogbuch.Logdaten.Clear()
            xAdapter.Fill(DsLogbuch.Logdaten)
            If bsLogdaten.Count = 1 Or bsLogdaten.Count = 0 Then
                letzteuhrzeit = "00:00"
            Else
                i = bsLogdaten.Count - 1
                letzteuhrzeit = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
            End If

            distanzr = 0
            motor = False
            gross = False
            genua = False
             For i = 0 To bsLogdaten.Count - 1
                bsLogdaten.Position = i
                If bsLogdaten.Count = 1 Then
                    If Len(ComboBox4.Text) < 1 And (ComboBox1.Text > "" Or ComboBox2.Text > "" Or TextBox2.Text > "") Then
                        MsgBox("Antriebsart definieren.")
                        ComboBox4.Focus()
                        GoTo endesub
                    End If
                    '                  distanzT = 0
                Else
                    '                   If distanzt > 0 Then
                    If Len(TextBox1.Text) > 0 Then
                        If Len(TextBox22.Text) > 0 Then
                            distanzr = TextBox22.Text - distanzt     ' Differenzdistanz
                            If distanzr < 0 Then distanzr = 0
                            distanzt = TextBox22.Text                ' Tagesdistanz
                            If gross Or genua Then
                                TextBox23.Text = distanzr.ToString("0.###", Globalization.CultureInfo.GetCultureInfo("de-DE"))       ' Unter Segel
                                TextBox24.Text = 0
                            Else
                                TextBox23.Text = 0
                                TextBox24.Text = distanzr.ToString("0.###", Globalization.CultureInfo.GetCultureInfo("de-DE"))       ' mit Motor
                            End If
                         End If
                    End If
                    '                   Else
                    '                End If
                End If
                If TextBox1.Text.Contains("M") Then motor = True
                If TextBox1.Text.Contains("GR") Then gross = True
                If TextBox1.Text.Contains("GE") Then genua = True
                If TextBox1.Text.Contains("m") Then motor = False
                If TextBox1.Text.Contains("gr") Then gross = False
                If TextBox1.Text.Contains("ge") Then genua = False
                bsLogdaten.EndEdit()
                taLogdaten.Update(DsLogbuch.Logdaten)
            Next
            bsLogdaten.AddNew()
            MaskedTextBox3.Focus()

        Else
            If TextBox29.Text < "00:00" Then
                '               msg = MsgBox(" Leere Von Zeiten werden gelöscht.", 1, "Löschen")
                '              If msg = vbOK Then
                '                   bsCharter.RemoveCurrent()
                '                  taCharter.Update(dsToernverwaltung)
                Dim LeerVon As String = " "
                Dim Leernov As String = ""
                WAdapter.SelectCommand = New OleDb.OleDbCommand
                WAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
                WAdapter.SelectCommand.CommandText = "delete * from LogWacheplan where toern = '" & toerna & "' and (textvon <= '" & LeerVon & "' or textvon = '" & Leernov & "') "
                DsLogbuch.LogWacheplan.Clear()
                WAdapter.Fill(DsLogbuch.LogWacheplan)
                '           End If
            End If
        If Wacheplanleer = True Then
            wacheanlegen()
        End If

        If aenderungD Then
            bsDokumentation.EndEdit()
            taDokumentation.Update(DsLogbuch.Dokumentation)
        Else
            bsDokumentation.AddNew()
            taDokumentation.Update(DsLogbuch.Dokumentation)
            Label29.Visible = True
            Label26.Visible = True
            Label28.Visible = True
            '              suchenDoku1()
        End If
        MaskedTextBox2.Text = aktuellerTag
        AT_Lesen()
        End If
endesub:
        aenderungL = False
    End Sub
    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        speichern(sender, e)
    End Sub
    Private Sub TagesTrace0(ByRef alt_distanz)
        Dim datmu As Date
        Dim mmon As Single
        Dim ttag As Single
        Dim yyear As Single
        Dim rx As System.Data.DataRowView = bsLogdaten.Current
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
        mmon = Month(datmu)
        ttag = datmu.Day
        yyear = Year(datmu)
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' order by uhrzeit"
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        xAdapter.Fill(DsLogbuch.Logdaten)
        DbAccess.SafePosition(bsLogdaten)
        aaa = bsLogdaten.Count
        If TextBox22.Text = "" Then
            alt_distanz = 0
        Else
            If TextBox22.Text = 0 Then
                alt_distanz = 0
            Else
                alt_distanz = TextBox22.Text
                If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
                datmu = DateAdd("d", -1, datmu)
                mmon = Month(datmu)
                ttag = datmu.Day
                yyear = Year(datmu)
                xAdapter.SelectCommand = New OleDb.OleDbCommand
                xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
                xAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' order by uhrzeit"
                bsLogdaten.CancelEdit()
                DsLogbuch.Logdaten.Clear()
                xAdapter.Fill(DsLogbuch.Logdaten)
                aaa = bsLogdaten.Count
                If aaa > 1 Then
                    alt_distanz = DsLogbuch.Logdaten.Rows(aaa - 1)("duegtag").ToString
                End If
            End If
        End If
    End Sub
     Private Sub MaskedTextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox2.LostFocus
        Wochentag()
    End Sub
    Private Sub Wochentag()
        Dim thisWeekDay As Integer
        If Not SafeData.IsBlankOrMask(MaskedTextBox2.Text) Then
            Dim datmu As Date
            If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
            thisWeekDay = Weekday(datmu, FirstDayOfWeek.Monday)
            Label13.Text = WeekdayName(thisWeekDay)
        End If
    End Sub
    Private Sub wacheplan()
        Dim datmu As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datmu) Then Exit Sub
        Dim mmon As Single = Month(datmu)
        Dim ttag As Single = datmu.Day
        Dim yyear As Single = Year(datmu)
        Dim rw As System.Data.DataRowView = bsLogWacheplan.Current
        WAdapter.SelectCommand = New OleDb.OleDbCommand
        WAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        WAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & toerna & "' order by datum"
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        WAdapter.Fill(DsLogbuch.LogWacheplan)
        aaa = bsLogWacheplan.Count
        If aaa = 0 And aaa > 100 Then                                       ' noch nicht gelöscht
            Dim rt As System.Data.DataRowView = bsWacheplan.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from wacheplan where toern = '" & toerna & "'  order by datum1"
            bsWacheplan.CancelEdit()
            dsToernverwaltung.Wacheplan.Clear()
            tAdapter.Fill(dsToernverwaltung.Wacheplan)
            aaa = bsWacheplan.Count
            If aaa = 0 Then
                MsgBox("Für den Törn ist kein Wacheplan geplant.")
                Dim datleerA As Date = CDate(datvon)
                Dim datleerB As Date = CDate(datbis)
                Dim datdiff As Long = DateDiff(DateInterval.Day, datleerA, datleerB)

                For iii = 0 To datdiff + 1
                    TextBox27.Text = "-"
                    TextBox28.Text = "-"
                    TextBox32.Text = toerna
                    TextBox31.Text = DateAdd(DateInterval.Day, iii - 1, datleerA)
                    bsLogWacheplan.AddNew()
                    taLogWacheplan.Update(DsLogbuch.LogWacheplan)
                Next
            Else
                bsLogWacheplan.AddNew()
                For iii = 0 To aaa - 1
                    TextBox27.Text = dsToernverwaltung.Wacheplan.Rows(iii)("Person1").ToString
                    TextBox28.Text = dsToernverwaltung.Wacheplan.Rows(iii)("Person2").ToString
                    TextBox35.Text = dsToernverwaltung.Wacheplan.Rows(iii)("Person3").ToString
                    TextBox33.Text = dsToernverwaltung.Wacheplan.Rows(iii)("vzname1").ToString
                    TextBox34.Text = dsToernverwaltung.Wacheplan.Rows(iii)("vzname2").ToString
                    TextBox36.Text = dsToernverwaltung.Wacheplan.Rows(iii)("vzname3").ToString
                    TextBox29.Text = SafeData.FormatTimeHm(dsToernverwaltung.Wacheplan.Rows(iii)("Datum1"))
                    If iii < aaa - 1 Then
                        TextBox30.Text = SafeData.FormatTimeHm(dsToernverwaltung.Wacheplan.Rows(iii + 1)("Datum1"))
                    Else
                        TextBox30.Text = "Ende"
                    End If
                    TextBox31.Text = SafeData.FormatDateDe(dsToernverwaltung.Wacheplan.Rows(iii)("datum1"))
                    TextBox32.Text = toerna
                    bsLogWacheplan.AddNew()
                    taLogWacheplan.Update(DsLogbuch.LogWacheplan)
                Next
            End If

        End If
        WAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & toerna & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' order by textvon "
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        WAdapter.Fill(DsLogbuch.LogWacheplan)
        aaa = bsLogWacheplan.Count
        If aaa = 0 Then Wacheplanleer = True
    End Sub
    Private Sub wacheanlegen()
       TextBox33.Text = TextBox27.Text
        TextBox34.Text = TextBox28.Text
        TextBox36.Text = TextBox35.Text
        TextBox31.Text = MaskedTextBox2.Text
        TextBox32.Text = toerna
        bsLogWacheplan.AddNew()
        taLogWacheplan.Update(DsLogbuch.LogWacheplan)
        Wacheplanleer = False
    End Sub
    Private Sub ComboBox2_GotFocus(sender As Object, e As System.EventArgs) Handles ComboBox2.GotFocus
        ComboBox2.Text = windrichtung
        ComboBox2.SelectAll()
    End Sub
    Private Sub ComboBox2_LostFocus(sender As Object, e As System.EventArgs) Handles ComboBox2.LostFocus
        ComboBox2.Text = ComboBox2.Text.ToUpper
        windrichtung = ComboBox2.Text
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox3.GotFocus
        If ComboBox1.Text = "" And ComboBox2.Text = "" And TextBox2.Text = "" Then
            TextBox3.Text = 0
        Else
            TextBox3.Text = luftdruck
        End If
    End Sub
    Private Sub ComboBox3_GotFocus(sender As Object, e As System.EventArgs) Handles ComboBox3.GotFocus
        ComboBox3.Text = bewolkung
    End Sub

    Private Sub ComboBox3_LostFocus(sender As Object, e As System.EventArgs) Handles ComboBox3.LostFocus
        Be0.Location = New Point(2000, 2000)
        Be1.Location = New Point(2000, 2000)
        Be2.Location = New Point(2000, 2000)
        Be3.Location = New Point(2000, 2000)
        Be4.Location = New Point(2000, 2000)
        Be5.Location = New Point(2000, 2000)
        Be6.Location = New Point(2000, 2000)
        Be7.Location = New Point(2000, 2000)
        Be8.Location = New Point(2000, 2000)
        Be9.Location = New Point(2000, 2000)

        If ComboBox3.Text > "" Then
            Select Case ComboBox3.SelectedIndex
                Case 0
                    Be0.Location = New Point(545, 460)
                Case 1
                    Be1.Location = New Point(545, 460)
                Case 2
                    Be2.Location = New Point(545, 460)
                Case 3
                    Be3.Location = New Point(545, 460)
                Case 4
                    Be4.Location = New Point(545, 460)
                Case 5
                    Be5.Location = New Point(545, 460)
                Case 6
                    Be6.Location = New Point(545, 460)
                Case 7
                    Be7.Location = New Point(545, 460)
                Case 8
                    Be8.Location = New Point(545, 460)
                Case 9
                    Be9.Location = New Point(545, 460)
            End Select
        End If
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        colNr = DataGridView2.CurrentCell.ColumnIndex
        rowNr = DataGridView2.CurrentCell.RowIndex
    End Sub

    Private Sub DataGridView2_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        If DsLogbuch.LogWacheplan.Count > 0 Then
            Dim na1 As String
            Dim na2 As String
            Dim ze1 As String
            Dim ze2 As String
            If IsDBNull(DataGridView2.Item(2, rowNr).Value) Then
                na1 = ""
            Else
                na1 = DataGridView2.Item(2, rowNr).Value
            End If
            If IsDBNull(DataGridView2.Item(3, rowNr).Value) Then
                na2 = ""
            Else
                na2 = DataGridView2.Item(3, rowNr).Value
            End If
            If IsDBNull(DataGridView2.Item(0, rowNr).Value) Then
                ze1 = ""
            Else
                ze1 = DataGridView2.Item(0, rowNr).Value
            End If
            If IsDBNull(DataGridView2.Item(1, rowNr).Value) Then
                ze2 = ""
            Else
                ze2 = DataGridView2.Item(1, rowNr).Value
            End If

            If na1 > "" And na2 > "" And ze1 > "" And ze2 > "" Then
                TextBox27.Text = na1
                TextBox28.Text = na2
                TextBox29.Text = ze1
                TextBox30.Text = ze2
                CheckBox7.Checked = True
                If rowNr >= DsLogbuch.LogWacheplan.Count Then
                    TextBox31.Text = TextBox26.Text
                    TextBox32.Text = toerna
                    bsLogWacheplan.AddNew()
                    taLogWacheplan.Update(DsLogbuch.LogWacheplan)
                Else
                    bsDokumentation.Position = rowNr + 1
                    bsLogWacheplan.EndEdit()
                    taLogWacheplan.Update(DsLogbuch.LogWacheplan)
                End If
            End If
        End If
    End Sub
    Private Sub MaskedTextBox4_LostFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox4.LostFocus
        If MaskedTextBox4.Text.Substring(0, 2) > "00" Then
            MaskedTextBox4.Text = MaskedTextBox4.Text.ToUpper
            TextBox18.Text = MaskedTextBox4.Text
            MaskedTextBox4.Text = ""
        End If
    End Sub

    Private Sub TextBox7_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox7.GotFocus
        anzahlAlpha = 0
    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If anzahlAlpha > 20 Then
            MsgBox("Text ist zu lang, bitte abkürzen.")
        Else
            anzahlAlpha = Len(TextBox7.Text)
        End If
    End Sub

    Private Sub TextBox8_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox8.GotFocus
        anzahlAlpha = 0
    End Sub

    Private Sub TextBox8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox8.KeyDown
        If anzahlAlpha > 20 Then
            MsgBox("Text ist zu lang, bitte abkürzen.")
        Else
            anzahlAlpha = Len(TextBox8.Text)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        MaskedTextBox3.Text = System.DateTime.Now.ToString("HH:mm")
        ComboBox2.Focus()
    End Sub

     Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        aenderungL = True
    End Sub

    Private Sub MaskedTextBox3_LostFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox3.LostFocus
        If Len(MaskedTextBox3.Text) = 3 And MaskedTextBox3.Text > "00:" Then MaskedTextBox3.Text += "00"
        If Len(MaskedTextBox3.Text) = 4 Then MaskedTextBox3.Text += "0"
    End Sub
    Private Sub TextBox12_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox12.KeyDown
        If Len(TextBox12.Text) > 15 Then
            MsgBox("Text ist zu lang, bitte abkürzen.")
        End If
    End Sub

    Private Sub RichTextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles RichTextBox1.GotFocus
        textänderung = True
    End Sub
    Private Sub RichTextBox2_GotFocus(sender As Object, e As System.EventArgs) Handles RichTextBox2.GotFocus
        textänderung = True
    End Sub
    Private Sub speichernFragen(sender, e)
        Dim antwort As String
        If textänderung Then
            antwort = MsgBox("Änderungen speichern?", 1, "Speichern")
            If antwort = 1 Then speichern(sender, e)
        End If
        textänderung = False
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox4.LostFocus
        TextBox4.Text = FormatPipeDecimal(TextBox4.Text)
    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox5.Text = FormatPipeDecimal(TextBox5.Text)
    End Sub

    ''' <summary>
    ''' Pushes Antriebsart to the NMEA relay. Never raises; pipe may be offline.
    ''' </summary>
    Private Sub PublishDriveStatusToPipe(ByVal antriebsart As String)
        Try
            NMEARelayPipeHelper.TryPublishDriveStatus(antriebsart)
        Catch
            ' Defensive: pipe status must never block logbook save.
        End Try
    End Sub

    ''' <summary>
    ''' Keeps decimal precision from NMEA/pipe values and normalizes to de-DE (comma)
    ''' so Single bindings (DueGTag etc.) parse and store correctly.
    ''' </summary>
    Private Function FormatPipeDecimal(ByVal raw As String) As String
        If String.IsNullOrWhiteSpace(raw) Then Return ""
        Dim s As String = raw.Trim()
        Dim n As Double
        If SafeData.TryParseNumber(s, n) Then
            Return n.ToString("0.###", Globalization.CultureInfo.GetCultureInfo("de-DE"))
        End If
        Return s.Replace("."c, ","c)
    End Function

    Private Sub TextBox14_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox14.LostFocus
        TextBox14.Text = Replace(TextBox14.Text, ".", ",")
    End Sub

    Private Sub TextBox15_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox15.LostFocus
        TextBox15.Text = Replace(TextBox15.Text, ".", ",")
    End Sub

    Private Sub TextBox17_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox17.TextChanged
        TextBox17.Text = Replace(TextBox17.Text, ".", ",")
    End Sub

    Private Sub TextBox16_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox16.LostFocus
        TextBox16.Text = Replace(TextBox16.Text, ".", ",")
    End Sub

    Private Sub ComboBox4_GotFocus(sender As Object, e As System.EventArgs) Handles ComboBox4.GotFocus
        ComboBox4.Text = antrieb
        ComboBox4.SelectAll()
    End Sub

    Private Sub ComboBox4_LostFocus(sender As Object, e As System.EventArgs) Handles ComboBox4.LostFocus
        antrieb = ComboBox4.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaskedTextBox3.Text = DateTime.Now.ToString("HH:mm:ss")
        Try
            If NMEARelayPipeHelper.IsPipeAvailable() = 1 Then
                Dim latLon As String = SendPipeCommand("GET_LATLON")
                If Not String.IsNullOrWhiteSpace(latLon) Then
                    TextBox18.Text = latLon.Trim()
                End If

                ' Keep decimals: pipe returns String; do not coerce to Integer.
                Dim cog As String = FormatPipeDecimal(SendPipeCommand("GET_COG"))
                If cog.Length > 0 Then
                    TextBox4.Text = cog
                End If

                Dim tripDist As String = FormatPipeDecimal(SendPipeCommand("GET_TRIPDIST"))
                If tripDist.Length > 0 Then
                    TextBox5.Text = tripDist
                End If
            End If
        Catch xx As Exception
            AppLog.Warn("Daten holen fehlgeschlagen: " & xx.Message)
        End Try
        TextBox3.Text = luftdruck
        ComboBox2.Text = windrichtung
        TextBox2.Text = Windstaerke
        ComboBox1.Text = Seegangalt
        ComboBox3.Text = bewolkung
        ComboBox4.Text = antrieb
    End Sub
    Private Sub Leerzeilen()
        Dim leer As String = "0"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from logdaten "
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        xAdapter.Fill(DsLogbuch.Logdaten)
        aaa = bsLogdaten.Count
        For i = 0 To aaa - 1
            bsLogdaten.Position = i
            If TextBox37.Text = "" Then
                bsLogdaten.RemoveCurrent()
                taLogdaten.Update(DsLogbuch)
            End If
        Next
        '           where toerbezeichnung < '" & leer & "'
    End Sub
End Class