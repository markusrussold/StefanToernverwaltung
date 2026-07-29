Public Class Zusammenfassung
    Dim aaa As String
    Dim buch1 As String
    Dim position As Integer
    Dim aenderung As Boolean
    Dim astro As Boolean = True
    Dim iii As Integer
    Dim logtag As String
    Dim summeGSegel As Single = 0
    Dim summeGMotor As Single = 0
    Dim SummeTSegel As Single = 0
    Dim summeTMotor As Single = 0
    Dim sm1 As Single
    Dim datumalt As String = " "
    Dim datealt As Date
    Dim NachtfahrtBeginn As String = ""
    Dim NachtfahrtEnde As String = ""
    Dim TageszeitAnfang As String
    Dim TageszeitEnde As String
    Dim pos1 As String
    Dim pos2 As String
    Dim ersteTag As String
    Dim letzterTag As String
    Dim dWd As Single = 0
    Dim iW As Integer = 0
    Dim dRi As Single = 0
    Dim iR As Integer = 0
    Dim Motorstunden As Single
    Dim antrieb As String
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                ' zusafass
    Dim zAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                ' Zusammenfassung2
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                ' TC
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Törn
    Dim yAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Logdaten
    Dim dAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Logdaten
    Dim wAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' LogWacheplan
    Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Wacheplan
    Dim nAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Toerndaten

    Private Sub Zusammenfassung_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Wacheplan". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taWacheplan.Fill(Me.dsToernverwaltung.Wacheplan)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Toerndaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToerndaten.Fill(Me.DsLogbuch.Toerndaten)
        Me.taTc.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.LogWacheplan". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taLogWacheplan.Fill(Me.DsLogbuch.LogWacheplan)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Astrodaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taDokumentation.Fill(Me.DsLogbuch.Dokumentation)
        Me.taZusammenfassung2.Fill(Me.DsLogbuch.Zusammenfassung2)
        Me.taLogdaten.Fill(Me.DsLogbuch.Logdaten)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)


        Dim rz As System.Data.DataRowView = bsZusammenfassung2.Current
        zAdapter.SelectCommand = New OleDb.OleDbCommand
        zAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        zAdapter.SelectCommand.CommandText = "Select * from Zusammenfassung2"
        bsZusammenfassung2.CancelEdit()
        DsLogbuch.Zusammenfassung2.Clear()
        zAdapter.Fill(DsLogbuch.Zusammenfassung2)
        bsZusammenfassung2.Position = 0
        aaa = bsZusammenfassung2.Count
        bsZusammenfassung2.AddNew()
        Label4.Text = ""
        Label6.Text = ""
        Label9.Text = ""
        Label11.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Button1.Enabled = False
        DataGridtoern.Location = New Point(1200, 110)
        DataGridZuFa.Visible = False
        aaa = TextBox1.Text
        Me.Text = "Zusammenfassung für Törn: " + aaa
        suchen()
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
        DataGridtoern.Location = New Point(9, 21)
        DataGridtoern.Visible = True
        DataGridZuFa.Visible = False
        Button1.Enabled = True
        '       GroupBox1.Enabled = False
        GroupBox2.Text = "Törn auswählen mit Doppelklick"
        DataGridZuFa.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        '       TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If IsNumeric(TextBox1.Text) And Len(TextBox1.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
            Else
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox1.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where Mid(toernbezeichnung,1,1) like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        End If
        bsToernname.CancelEdit()
        '       aenderung = True
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                TextBox9.Text = TextBox1.Text
                Formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                '              Label2.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                DataGridtoern.Location = New Point(1200, 110)
                GroupBox2.Text = "Logbuch Auswertungen "
                TextBox9.Text = TextBox1.Text
                ersteTag = dsToernverwaltung.Toernname.Rows(0)("datumvon").ToString
                letzterTag = dsToernverwaltung.Toernname.Rows(0)("datumbis").ToString
                Button1.Enabled = True
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
        End Select
    End Sub
    Private Sub SuchenZusammenfassung()
        Dim motanf As Single
        Dim tageslog As Boolean = True
        DataGridZuFa.Visible = True
        Dim rz As System.Data.DataRowView = bsZusammenfassung2.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Zusammenfassung2 where toernbezeichnung = '" & TextBox1.Text & "' "
        bsZusammenfassung2.CancelEdit()
        DsLogbuch.Zusammenfassung2.Clear()
        pAdapter.Fill(DsLogbuch.Zusammenfassung2)
        bsZusammenfassung2.Position = 0
        aaa = bsZusammenfassung2.Count
        For i = 0 To bsZusammenfassung2.Count - 1
            bsZusammenfassung2.RemoveCurrent()
            taZusammenfassung2.Update(DsLogbuch.Zusammenfassung2)
        Next
        bsZusammenfassung2.AddNew()

        Dim tagBis As String

        Dim ry As System.Data.DataRowView = bsLogdaten.Current
        yAdapter.SelectCommand = New OleDb.OleDbCommand
        yAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        yAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & TextBox1.Text & "' order by datum, uhrzeit"
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        yAdapter.Fill(DsLogbuch.Logdaten)
        bsLogdaten.Position = 0
        If bsLogdaten.Count = 0 Then
            MsgBox("Es sind noch keine Logdaten erfasst.")
            Exit Sub
        End If
        logtag = DsLogbuch.Logdaten.Rows(0)("datum").ToString
        TageszeitAnfang = DsLogbuch.Logdaten.Rows(0)("uhrzeit").ToString
        ProgressBar1.Maximum = bsLogdaten.Count - 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Step = 1
        If bsLogdaten.Count > 0 Then
            For i = 0 To bsLogdaten.Count - 1
                ProgressBar1.Value = i
                ProgressBar1.PerformStep()
                If Len(DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString) > 0 Then
                    summeGMotor += DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString
                End If
                If Len(DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString) > 0 Then
                    summeGSegel += DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString
                End If
                If logtag = DsLogbuch.Logdaten.Rows(i)("datum").ToString Then
                    If Len(DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString) > 0 Then
                        summeTMotor += DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString
                    End If
                    If Len(DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString) > 0 Then
                        SummeTSegel += DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString
                    End If
                    TextBox11.Text = DsLogbuch.Logdaten.Rows(i)("datum").ToString
                    StartZiel(DsLogbuch.Logdaten.Rows(i)("datum").ToString)
                    Wind(DsLogbuch.Logdaten.Rows(i)("windrichtung").ToString, DsLogbuch.Logdaten.Rows(i)("windstaerke").ToString)
                    TextBox12.Text = TageszeitAnfang
                    TageszeitEnde = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
                    tagBis = DsLogbuch.Logdaten.Rows(i)("datum").ToString
                    antrieb = DsLogbuch.Logdaten.Rows(i)("Antriebsart").ToString
                    If Len(DsLogbuch.Logdaten.Rows(i)("duegtag").ToString) > 0 Then
                        If DsLogbuch.Logdaten.Rows(i)("duegtag").ToString > 0 Then
                            tageslog = True
                        Else
                            tageslog = False
                        End If
                    Else
                        tageslog = False
                    End If
                Else
                    TextBox13.Text = TageszeitEnde
                    TextBox3.Text = TextBox1.Text
                    TextBox14.Text = tagBis
                    TextBox15.Text = SummeTSegel
                    TextBox16.Text = summeTMotor
                    TextBox17.Text = SummeTSegel + summeTMotor
                    bsZusammenfassung2.AddNew()
                    taZusammenfassung2.Update(DsLogbuch.Zusammenfassung2)
                    dWd = 0
                    iW = 0
                    dRi = 0
                    iR = 0
                    If antrieb = "" And tageslog Then
                        Label14.Text = "Achtung: am " + SafeData.FormatDateDe(tagBis, SafeData.LeftSafe(tagBis, 10)) + " " + TageszeitEnde + " ist die Antriebsart nicht versorgt."
                    End If
                    logtag = DsLogbuch.Logdaten.Rows(i)("datum").ToString
                    SummeTSegel = 0
                    summeTMotor = 0
                    If Len(DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString) > 0 Then
                        summeTMotor += DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString
                    End If
                    If Len(DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString) > 0 Then
                        SummeTSegel += DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString
                    End If
                    TageszeitAnfang = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
                    '                                                                  Landtag ohne Ausfahrt
                    If DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString = "" And DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString = "" Then
                        '             If DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(i)("duegmotor").ToString) And DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(i)("duegsegel").ToString) Then
                        TageszeitEnde = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
                        tagBis = DsLogbuch.Logdaten.Rows(i)("datum").ToString
                        TextBox4.Text = DsLogbuch.Dokumentation.Rows(0)("zielort").ToString
                        TextBox5.Text = DsLogbuch.Dokumentation.Rows(0)("zielort").ToString
                        TextBox11.Text = tagBis
                        TextBox12.Text = TageszeitEnde
                        TextBox18.Text = " "
                        TextBox19.Text = " "
                    End If
                End If
            Next
            TextBox15.Text = SummeTSegel
            TextBox16.Text = summeTMotor
            TextBox17.Text = SummeTSegel + summeTMotor
            TextBox13.Text = TageszeitEnde
            TextBox3.Text = TextBox1.Text
            TextBox14.Text = tagBis
            bsZusammenfassung2.AddNew()
            taZusammenfassung2.Update(DsLogbuch.Zusammenfassung2)
        End If
        '                                              Toerndaten
        Dim rn As System.Data.DataRowView = bsToerndaten.Current
        nAdapter.SelectCommand = New OleDb.OleDbCommand
        nAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        nAdapter.SelectCommand.CommandText = "Select * from Toerndaten where toernbezeichnung = '" & TextBox1.Text & "'"
        bsToerndaten.CancelEdit()
        DsLogbuch.Toerndaten.Clear()
        nAdapter.Fill(DsLogbuch.Toerndaten)
        bsToerndaten.Position = 0
        aaa = bsToerndaten.Count
        If aaa > 0 Then
            Label6.Text = summeGMotor
            Label4.Text = summeGSegel
            TextBox22.Text = summeGMotor
            TextBox23.Text = summeGSegel
            '           nachtfast()
            '          If astro Then Nachtreise()
            dunkel()
            Dim rd As System.Data.DataRowView = bsDokumentation.Current
            dAdapter.SelectCommand = New OleDb.OleDbCommand
            dAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
            dAdapter.SelectCommand.CommandText = "Select * from Dokumentation where toernbezeichnung = '" & TextBox1.Text & "'order by datum "
            bsDokumentation.CancelEdit()
            DsLogbuch.Dokumentation.Clear()
            dAdapter.Fill(DsLogbuch.Dokumentation)
            bsDokumentation.Position = 0
            aaa = bsDokumentation.Count
            TextBox36.Text = DsLogbuch.Dokumentation.Rows(0)("ausgangsort").ToString           '   gefahrene Route
            Dim ausgOrt As String = DsLogbuch.Dokumentation.Rows(0)("ausgangsort").ToString
            For i = 1 To aaa - 1
                If DsLogbuch.Dokumentation.Rows(i)("ausgangsort").ToString > "" And DsLogbuch.Dokumentation.Rows(i)("ausgangsort").ToString <> ausgOrt Then
                    ausgOrt = DsLogbuch.Dokumentation.Rows(i)("ausgangsort").ToString
                    TextBox36.Text += " - " + DsLogbuch.Dokumentation.Rows(i)("ausgangsort").ToString
                End If
            Next
            If DsLogbuch.Dokumentation.Rows(aaa - 1)("zielort").ToString > "" And DsLogbuch.Dokumentation.Rows(aaa - 1)("zielort").ToString <> ausgOrt Then   'letzter Tag
                TextBox36.Text += " - " + DsLogbuch.Dokumentation.Rows(aaa - 1)("zielort").ToString
            End If
            If IsNumeric(DsLogbuch.Dokumentation.Rows(aaa - 1)("Motorstdende").ToString) Then
            Else
                MsgBox("Motorstunden am letzten Tag fehlen.")
            End If
            If IsNumeric(DsLogbuch.Dokumentation.Rows(0)("Motorstdanfang").ToString) Then
                motanf = DsLogbuch.Dokumentation.Rows(0)("Motorstdanfang").ToString
            Else
                If IsNumeric(DsLogbuch.Dokumentation.Rows(1)("Motorstdanfang").ToString) Then
                    motanf = DsLogbuch.Dokumentation.Rows(1)("Motorstdanfang").ToString
                Else
                    MsgBox("Motorstunden am Anfang des Törns fehlen.")
                End If
            End If
            If IsNumeric(DsLogbuch.Dokumentation.Rows(aaa - 1)("Motorstdende").ToString) And IsNumeric(motanf) Then
                Motorstunden = DsLogbuch.Dokumentation.Rows(aaa - 1)("Motorstdende").ToString - motanf
                Label9.Text = Format(Motorstunden, "#0.0")
                TextBox24.Text = Format(Motorstunden, "#0.0")
            End If
            '     End If
            bsToerndaten.EndEdit()
            taToerndaten.Update(DsLogbuch.Toerndaten)
        End If

        SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
        Tageskontrolle()
        Toernverwaltung()
    End Sub
    Private Sub Dunkel()
        TextBox25.Text = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten").ToString
        TextBox26.Text = dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen").ToString
        Label11.Text = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten").ToString
        Label13.Text = dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen").ToString
    End Sub
    Private Sub Nachtreise()
        Dim nFahrten As Integer = 0
        Dim rech As Integer = TextBox2.Text.Substring(0, 2)             ' Nachtfahrt 3 Std vor Sonnenaufgang
        Dim soauf As String = "0" + rech.ToString + ":" + TextBox2.Text.Substring(3, 2)
        rech = TextBox6.Text.Substring(0, 2) + 3                                ' Nachtfahrt 3 Std nach Sonnenuntergang
        Dim sount As String = TextBox6.Text
        Dim i As Integer
        Dim smAnf As Single
        Dim inFahrt As Boolean
        Dim MorgenBeginn As String
        MorgenBeginn = (soauf.Substring(0, 2) - 3)
        MorgenBeginn = "0" + MorgenBeginn + soauf.Substring(2, 3)
        rech = (24 - TextBox6.Text.Substring(0, 2) - 1) * 60 + 60 - TextBox6.Text.Substring(3, 2)      '   Nanchtfahrt in Min bis Mitternacht 
         Dim ry As System.Data.DataRowView = bsLogdaten.Current
        yAdapter.SelectCommand = New OleDb.OleDbCommand
        yAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        yAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & TextBox1.Text & "' order by datum, uhrzeit"
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        yAdapter.Fill(DsLogbuch.Logdaten)
        bsLogdaten.Position = 0
        aaa = bsLogdaten.Count
        If aaa > "0" Then
            datumalt = DsLogbuch.Logdaten.Rows(0)("datum").ToString
            '           NachtfahrtBeginn = DsLogbuch.Logdaten.Rows(0)("uhrzeit").ToString
            NachtfahrtBeginn = ""


            For i = 0 To aaa - 1
                If DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString > " " Then
                    If (DsLogbuch.Logdaten.Rows(i)("Antriebsart").ToString.Contains("M")) Or (DsLogbuch.Logdaten.Rows(i)("Antriebsart").ToString.Contains("GE")) Or (DsLogbuch.Logdaten.Rows(i)("Antriebsart").ToString.Contains("Gr")) Then
                        inFahrt = True
                    Else
                        inFahrt = False
                    End If
                    If inFahrt Then
                        If DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString >= MorgenBeginn And NachtfahrtBeginn = "" And DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString <= soauf Then
                            GoTo schleife
                        End If
                        If datumalt = DsLogbuch.Logdaten.Rows(i)("datum").ToString Then
                            If DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString <= sount Then
                                NachtfahrtBeginn = sount
                                smAnf = DsLogbuch.Logdaten.Rows(i)("duegtag").ToString
                                pos1 = DsLogbuch.Logdaten.Rows(i)("position").ToString
                            Else
                                If NachtfahrtBeginn > " " Then
                                    NachtfahrtEnde = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
                                    sm1 = DsLogbuch.Logdaten.Rows(i)("duegtag").ToString - smAnf
                                    pos2 = DsLogbuch.Logdaten.Rows(i)("position").ToString
                                Else
                                    NachtfahrtBeginn = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
                                    pos1 = DsLogbuch.Logdaten.Rows(i)("position").ToString
                                    smAnf = DsLogbuch.Logdaten.Rows(i)("duegtag").ToString
                                End If
                            End If
                        Else
                            If NachtfahrtBeginn > " " Then
                                If DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString > soauf Then
                                    NachtfahrtEnde = soauf
                                    sm1 = DsLogbuch.Logdaten.Rows(i)("duegtag").ToString - smAnf
                                    pos2 = DsLogbuch.Logdaten.Rows(i)("position").ToString
                                Else
                                    NachtfahrtEnde = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
                                    sm1 = DsLogbuch.Logdaten.Rows(i)("duegtag").ToString - smAnf
                                    pos2 = DsLogbuch.Logdaten.Rows(i)("position").ToString
                                End If
                            Else
                                If DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString <= sount Then
                                    NachtfahrtBeginn = sount
                                    smAnf = DsLogbuch.Logdaten.Rows(i)("duegtag").ToString
                                    pos1 = DsLogbuch.Logdaten.Rows(i)("position").ToString
                                Else
                                    NachtfahrtBeginn = DsLogbuch.Logdaten.Rows(i)("uhrzeit").ToString
                                    smAnf = DsLogbuch.Logdaten.Rows(i)("duegtag").ToString
                                    pos1 = DsLogbuch.Logdaten.Rows(i)("position").ToString
                                End If
                            End If
                        End If
                    Else
                        If NachtfahrtBeginn > " " And NachtfahrtEnde > " " Then
                            Dauer3Std(NachtfahrtBeginn, NachtfahrtEnde, sount, soauf, nFahrten, i)
                        End If
                        NachtfahrtEnde = ""
                        NachtfahrtBeginn = ""
                        If i < aaa - 1 Then
                            datumalt = DsLogbuch.Logdaten.Rows(i + 1)("datum").ToString
                            datealt = DateAdd("d", 1, datumalt)
                        End If
                    End If
                End If
schleife:
            Next
            Label11.Text = nFahrten.ToString
            TextBox25.Text = nFahrten
        End If
    End Sub
    Private Sub Dauer3Std(anfa, ende, soun, soauf, ByRef nf, jd)
        Dim min As Single
        If anfa <= "24:00" And anfa >= soun Then
            min = (24 - anfa.substring(0, 2) - 1) * 60 + 60 - anfa.substring(3, 2)      '   Nanchtfahrt in Min bis Mitternacht 
        Else
            min = -(anfa.substring(3, 2) + anfa.substring(0, 2) * 60)
        End If
        If ende > soun Then
            min += -((24 - ende.substring(0, 2) - 1) * 60 + 60 - ende.substring(3, 2))      '   Nanchtfahrt in Min bis Mitternacht werden abgezugen
        Else
            min += ende.substring(0, 2) * 60 + ende.substring(3, 2)
        End If
        If min > 180 Then
            nFahrt(jd - 1, "1", nf)
            MsgBox(" " & Convert.ToString(datumalt) & " Nachtfahrt")
            nf += 1
        End If
    End Sub
    Private Sub nFahrt(ByVal z, ByVal teil, ByVal nfahrten)
        If nfahrten = 0 Then
            ' Format$(hh, "#0.0")
            If teil = "1" Then
                '              sm1 = DsLogbuch.Logdaten.Rows(z)("duegtag").ToString
                TextBox42NFv.Text = pos1                '  DsLogbuch.Logdaten.Rows(z)("position").ToString
                TextBox46Nzv.Text = NachtfahrtBeginn
                TextBox45NDv.Text = datumalt
                TextBox47Ndb.Text = datealt
                '            Else
                TextBox44sm.Text = sm1                       ' Format$(DsLogbuch.Logdaten.Rows(z)("duegtag").ToString - sm1, "#0.0")
                TextBox43Nfb.Text = pos2                '          DsLogbuch.Logdaten.Rows(z)("position").ToString
                TextBox48Nzb.Text = NachtfahrtEnde
                bsToernname.EndEdit()
                taToernname.Update(dsToernverwaltung.Toernname)
            End If
        Else
            If teil = "1" Then
                sm1 = DsLogbuch.Logdaten.Rows(z)("duegtag").ToString
                TextBox42nfv2.Text = DsLogbuch.Logdaten.Rows(z)("position").ToString
                TextBox46nzv2.Text = DsLogbuch.Logdaten.Rows(z)("uhrzeit").ToString
                TextBox45Ndv2.Text = datumalt
                TextBox47Ndb2.Text = datealt
                '           Else
                TextBox44sm2.Text = sm1                     'Format$(DsLogbuch.Logdaten.Rows(z)("duegtag").ToString - sm1, "#0.0")
                TextBox43nfb2.Text = DsLogbuch.Logdaten.Rows(z)("position").ToString
                TextBox48nzb2.Text = DsLogbuch.Logdaten.Rows(z)("uhrzeit").ToString
                bsToernname.EndEdit()
                taToernname.Update(dsToernverwaltung.Toernname)
            End If
        End If
    End Sub
    Private Sub nachtfast()
        Label13.Text = "0"
        If DsLogbuch.Toerndaten.Rows(0)("sonnenaufgang").ToString = "" Or DsLogbuch.Toerndaten.Rows(0)("sonnenuntergang").ToString = "" Then
            MsgBox("Astrodaten sind nicht angegeben, Nachtansteuerungen können nicht gerechnet werden.")
            astro = False
            GoTo endesub
        End If
        Dim nFahrten As Integer
        Dim nansteuerung As Integer
        Dim rech As Integer = TextBox2.Text.Substring(0, 2) - 2                 ' Nachtasteuerung 2 Std vor Sonnenaufgang
        Dim soauf As String = "0" + rech.ToString + ":" + TextBox2.Text.Substring(3, 2)
        rech = TextBox6.Text.Substring(0, 2) + 2                                ' Nachtasteuerung 2 Std nach Sonnenuntergang
        Dim sount As String = rech.ToString + ":" + TextBox6.Text.Substring(3, 2)
        Dim logbis As String
        Dim logbis1 As String
        Dim datumalt As String = " "
        Dim i As Integer
        Dim nm1 As String
        Dim nm2 As String
        If TextBox2.Text = "" Then
            rech = 0
        Else
            rech = TextBox2.Text.Substring(0, 2) - 2 + 24         '   Nanchtansteuerung nach Mitternacht + 24 Std
        End If
        Dim rw As System.Data.DataRowView = bsLogWacheplan.Current
        wAdapter.SelectCommand = New OleDb.OleDbCommand
        wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        wAdapter.SelectCommand.CommandText = "Select * from Logwacheplan where toern = '" & TextBox1.Text & "' and synchron "
        '       wAdapter.SelectCommand.CommandText = "Select * from Logwacheplan where toern = '" & TextBox1.Text & "' "
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        wAdapter.Fill(DsLogbuch.LogWacheplan)
        bsLogWacheplan.Position = 0
        aaa = bsLogWacheplan.Count

        If aaa > "0" Then
            For i = 0 To aaa - 1
                If DsLogbuch.LogWacheplan.Rows(i)("textbis") > sount Or DsLogbuch.LogWacheplan.Rows(i)("textbis") < soauf Then
                    If Len(DsLogbuch.LogWacheplan.Rows(i)("textbis").ToString) = 4 Then
                        DsLogbuch.LogWacheplan.Rows(i)("textbis") = DsLogbuch.LogWacheplan.Rows(i)("textbis").ToString.Substring(0, 2) + ":" + DsLogbuch.LogWacheplan.Rows(i)("textbis").ToString.Substring(2, 2)
                        bsLogWacheplan.EndEdit()
                        taLogWacheplan.Update(DsLogbuch.LogWacheplan)
                    End If
                    logbis = DsLogbuch.LogWacheplan.Rows(i)("textbis").ToString
                    logbis1 = DsLogbuch.LogWacheplan.Rows(i)("textbis").ToString
                    If logbis > sount Then
                    Else
                        rech = logbis.Substring(0, 2) + 24
                        logbis = rech.ToString + ":" + logbis.Substring(3, 2)
                    End If
                    If logbis > sount Or logbis1 < soauf Then
                        vzsuchen(DsLogbuch.LogWacheplan.Rows(i)("person1").ToString, nm1)
                        vzsuchen(DsLogbuch.LogWacheplan.Rows(i)("person2").ToString, nm2)
                        If nm2 <> "NN" Then
                            crewnachtan(DsLogbuch.LogWacheplan.Rows(i)("Datum").ToString, nm1, nm2, DsLogbuch.LogWacheplan.Rows(i)("textbis").ToString)
                            nansteuerung += 1
                        End If
                    End If
                    Label13.Text = nansteuerung.ToString
                End If
            Next

        End If
        TextBox26.Text = nansteuerung
        Button1.Enabled = False
endesub:
    End Sub
    Private Sub vzsuchen(ByVal crewname, ByRef Vzname)
        Dim rh As System.Data.DataRowView = bsWacheplan.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        aAdapter.SelectCommand.CommandText = "Select * from Wacheplan where toern = '" & TextBox1.Text & "' and person1 = '" & crewname & "'  "
        bsWacheplan.CancelEdit()
        dsToernverwaltung.Wacheplan.Clear()
        aAdapter.Fill(dsToernverwaltung.Wacheplan)
        bsWacheplan.Position = 0
        If bsWacheplan.Count = 0 Then
            aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            aAdapter.SelectCommand.CommandText = "Select * from Wacheplan where toern = '" & TextBox1.Text & "' and person2 = '" & crewname & "'  "
            bsWacheplan.CancelEdit()
            dsToernverwaltung.Wacheplan.Clear()
            aAdapter.Fill(dsToernverwaltung.Wacheplan)
            bsWacheplan.Position = 0
            If bsWacheplan.Count = 0 Then
                MsgBox(" " & Convert.ToString(crewname) & " befindet sich nicht im Wachplan.")
                Vzname = "NN"
            Else
                Vzname = dsToernverwaltung.Wacheplan.Rows(0)("VZname2").ToString
            End If
        Else
            Vzname = dsToernverwaltung.Wacheplan.Rows(0)("VZname1").ToString
        End If

    End Sub
    Private Sub crewnachtan(dtm, p1, p2, zeit)
        Dim parsed As Date
        Dim mmon As Single
        Dim ttag As Single
        Dim yyear As Single
        If SafeData.TryParseDate(dtm, parsed) Then
            mmon = parsed.Month
            ttag = parsed.Day
            yyear = parsed.Year
        Else
            mmon = SafeData.ParseNumberOrZero(SafeData.SafeSubstring(dtm, 3, 2))
            ttag = SafeData.ParseNumberOrZero(SafeData.SafeSubstring(dtm, 0, 2))
            yyear = SafeData.ParseNumberOrZero(SafeData.SafeSubstring(dtm, 6, 4))
        End If
        Dim dateText As String = SafeData.FormatDateDe(dtm, SafeData.LeftSafe(dtm, 10))
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from tc where toern = '" & SafeData.SqlQuote(TextBox1.Text) & "' and  vzname = '" & SafeData.SqlQuote(p1) & "'  "
        bsToernname.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)

        yAdapter.SelectCommand = New OleDb.OleDbCommand
        yAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        yAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & SafeData.SqlQuote(TextBox1.Text) & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' and  Uhrzeit =  '" & SafeData.SqlQuote(zeit) & "' "
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        yAdapter.Fill(DsLogbuch.Logdaten)
        bsLogdaten.Position = 0
        If bsLogdaten.Count = 1 Then
            If dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString = "" Then
                TextBox27.Text = DsLogbuch.Logdaten.Rows(0)("Position").ToString
                TextBox28.Text = dateText
                TextBox29.Text = zeit
            Else
                If dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString = DsLogbuch.Logdaten.Rows(0)("Position").ToString Then
                    GoTo vorhanden1
                End If
                If dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString = "" Then
                    TextBox30.Text = DsLogbuch.Logdaten.Rows(0)("Position").ToString
                    TextBox31.Text = dateText
                    TextBox32.Text = zeit
                Else
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString = DsLogbuch.Logdaten.Rows(0)("Position").ToString Then
                        GoTo vorhanden2
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen3").ToString = "" Then
                        TextBox33.Text = DsLogbuch.Logdaten.Rows(0)("Position").ToString
                        TextBox34.Text = dateText
                        TextBox35.Text = zeit
                    End If
                End If
            End If
            bsTC.EndEdit()
            taTc.Update(dsToernverwaltung.TC)
            GoTo vorhanden2
vorhanden1:
            tAdapter.SelectCommand.CommandText = "Select * from tc where toern = '" & SafeData.SqlQuote(TextBox1.Text) & "' and  vzname = '" & SafeData.SqlQuote(p2) & "'  "
            bsToernname.CancelEdit()
            dsToernverwaltung.TC.Clear()
            tAdapter.Fill(dsToernverwaltung.TC)
            If dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString = "" Then
                TextBox27.Text = DsLogbuch.Logdaten.Rows(0)("Position").ToString
                TextBox28.Text = dateText
                TextBox29.Text = zeit
            Else
                If dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString = DsLogbuch.Logdaten.Rows(0)("Position").ToString Then
                    GoTo vorhanden2
                End If
                If dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString = "" Then
                    TextBox30.Text = DsLogbuch.Logdaten.Rows(0)("Position").ToString
                    TextBox31.Text = dateText
                    TextBox32.Text = zeit
                Else
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString = DsLogbuch.Logdaten.Rows(0)("Position").ToString Then
                        GoTo vorhanden2
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen3").ToString = "" Then
                        TextBox33.Text = DsLogbuch.Logdaten.Rows(0)("Position").ToString
                        TextBox34.Text = dateText
                        TextBox35.Text = zeit
                    End If
                End If
            End If
            bsTC.EndEdit()
            taTc.Update(dsToernverwaltung.TC)
        End If
vorhanden2:
    End Sub
    Private Sub StartZiel(dtum)
        Dim mmon As Single = dtum.Substring(3, 2)
        Dim ttag As Single = dtum.Substring(0, 2)
        Dim yyear As Single = dtum.Substring(6, 4)
        Dim rd As System.Data.DataRowView = bsDokumentation.Current
        dAdapter.SelectCommand = New OleDb.OleDbCommand
        dAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        dAdapter.SelectCommand.CommandText = "Select * from Dokumentation where toernbezeichnung = '" & TextBox1.Text & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' "
        bsDokumentation.CancelEdit()
        DsLogbuch.Dokumentation.Clear()
        dAdapter.Fill(DsLogbuch.Dokumentation)
        bsDokumentation.Position = 0
        TextBox4.Text = DsLogbuch.Dokumentation.Rows(0)("ausgangsort").ToString
        TextBox5.Text = DsLogbuch.Dokumentation.Rows(0)("zielort").ToString
    End Sub
    Private Sub Wind(ri, kn)
        If ri = "" Or kn = "" Then
            Exit Sub
        End If
        dWd += kn
        iW += 1
        TextBox18.Text = Format(dWd / iW, "#0")
        iR += 1
        Select Case ri
            Case "N"
                dRi += 1
            Case "NO"
                dRi += 2
            Case "O"
                dRi += 3
            Case "SO"
                dRi += 4
            Case "S"
                dRi += 5
            Case "SW"
                dRi += 6
            Case "W"
                dRi += 7
            Case "NW"
                dRi += 8
        End Select

        Dim riW As Single
        riW = dRi / iR
        Select Case riW
            Case Is < 1.5
                TextBox19.Text = "N"
            Case Is < 2.5
                TextBox19.Text = "NO"
            Case Is < 3.5
                TextBox19.Text = "O"
            Case Is < 4.5
                TextBox19.Text = "SO"
            Case Is < 5.5
                TextBox19.Text = "S"
            Case Is < 6.5
                TextBox19.Text = "SW"
            Case Is < 7.5
                TextBox19.Text = "W"
            Case Is < 8.5
                TextBox19.Text = "NW"
        End Select
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub Formularloeschen()
        TextBox1.Text = ""
    End Sub
    Private Sub positionieren()
        iii = bsToernname.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.Toernname.Rows(i)("toernbezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub DataGridZuFa_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridZuFa.CellMouseClick
        MsgBox(" Die Zeile kann nicht bearbeitet werden, sie entsteht aus den Eingaben im Logbuch.")
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

    Private Sub DataGridtoern_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridtoern.CellMouseClick
        suchen()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        fehlendelogdatentage()
        fehlenderWachdienst()
        SuchenZusammenfassung()
    End Sub
    Private Sub fehlendelogdatentage()
        Dim von As Date = CDate(ersteTag)
        Dim bis As Date = CDate(letzterTag)
        Dim mmon As Single
        Dim ttag As Single
        Dim yyear As Single
        bis = bis.AddDays(1)               ' damit auch der letzter Tag geprüft wird
        Do While von <> bis
            mmon = Month(von)
            ttag = von.Day
            yyear = Year(von)
            Dim ry As System.Data.DataRowView = bsLogdaten.Current
            yAdapter.SelectCommand = New OleDb.OleDbCommand
            yAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
            yAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & TextBox1.Text & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' "
            bsLogdaten.CancelEdit()
            DsLogbuch.Logdaten.Clear()
            yAdapter.Fill(DsLogbuch.Logdaten)
            If bsLogdaten.Count = 0 Then
                ' satz ausgeben
                bsLogdaten.AddNew()
                bsLogdaten.AddNew()
                DsLogbuch.Logdaten.Rows(0)("toerbezeichnung") = TextBox1.Text
                DsLogbuch.Logdaten.Rows(0)("datum") = von
                DsLogbuch.Logdaten.Rows(0)("Uhrzeit") = "09:00"
                '              DsLogbuch.Logdaten.Rows(0)("Position") = "Keine Ausfahrt"
                '             DsLogbuch.Logdaten.Rows(0)("toernbezeichnung") = TextBox1.Text
                taLogdaten.Update(DsLogbuch.Logdaten)
            End If
            von = von.AddDays(1)
        Loop
     End Sub
    Private Sub fehlenderWachdienst()
        Dim von As Date = CDate(ersteTag)
        Dim bis As Date = CDate(letzterTag)
        Dim mmon As Single
        Dim ttag As Single
        Dim yyear As Single
        bis = bis.AddDays(1)               ' damit auch der letzter Tag geprüft wird
        Do While von <> bis
            mmon = Month(von)
            ttag = von.Day
            yyear = Year(von)
            Dim ry As System.Data.DataRowView = bsLogWacheplan.Current
            wAdapter.SelectCommand = New OleDb.OleDbCommand
            wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
            wAdapter.SelectCommand.CommandText = "Select * from logwacheplan where toern = '" & TextBox1.Text & "' and  month(datum) = '" & mmon & "' and day(datum) = '" & ttag & "'  and year(datum) = '" & yyear & "' "
            bsLogWacheplan.CancelEdit()
            DsLogbuch.LogWacheplan.Clear()
            wAdapter.Fill(DsLogbuch.LogWacheplan)
            If bsLogWacheplan.Count = 0 Then
                ' satz ausgeben
                bsLogWacheplan.AddNew()
                bsLogWacheplan.AddNew()
                DsLogbuch.LogWacheplan.Rows(0)("toern") = TextBox1.Text
                DsLogbuch.LogWacheplan.Rows(0)("datum") = von
                DsLogbuch.LogWacheplan.Rows(0)("textvon") = "00:00"
                DsLogbuch.LogWacheplan.Rows(0)("textbis") = "04:00"
                DsLogbuch.LogWacheplan.Rows(0)("Person1") = "   "
                DsLogbuch.LogWacheplan.Rows(0)("Person2") = "   "
                taLogWacheplan.Update(DsLogbuch.LogWacheplan)
            End If
            von = von.AddDays(1)
        Loop

    End Sub
    Private Sub Toernverwaltung()
        Dim msg As Integer
        msg = MsgBox(" Die Zusammenfassung in die Törnverwaltung speichern?", 1, "Speichern")
        If msg = vbOK Then
            Dim smsum As Single = Label4.Text
            smsum += Label6.Text
            TextBox37.Text = Label4.Text
            TextBox38.Text = Label6.Text
            TextBox39.Text = smsum
            TextBox40.Text = Label11.Text
            TextBox41.Text = Label13.Text
            bsToernname.AddNew()
            taToernname.Update(dsToernverwaltung.Toernname)
        End If
    End Sub
    Private Sub Tageskontrolle()
        Dim ry As System.Data.DataRowView = bsLogdaten.Current
        yAdapter.SelectCommand = New OleDb.OleDbCommand
        yAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        yAdapter.SelectCommand.CommandText = "Select * from logdaten where toerbezeichnung = '" & TextBox1.Text & "' order by datum, uhrzeit"
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        yAdapter.Fill(DsLogbuch.Logdaten)
        bsLogdaten.Position = 0
        If bsLogdaten.Count = 0 Then
            MsgBox("Es sind noch keine Logdaten erfasst.")
            Exit Sub
        End If
        logtag = DsLogbuch.Logdaten.Rows(0)("datum").ToString
        For iii = 1 To bsLogdaten.Count - 1
            If logtag <> DsLogbuch.Logdaten.Rows(iii)("datum").ToString Then
                logtag = DsLogbuch.Logdaten.Rows(iii)("datum").ToString
                '          If DsLogbuch.Logdaten.Rows(iii - 1)("ort").ToString <> "Keine Ausfahrt" Then
                If DsLogbuch.Logdaten.Rows(iii - 1)("DueGTag").ToString <> "" Then

                    If DsLogbuch.Logdaten.Rows(iii - 1)("uhrzeit").ToString < "22:00" And DsLogbuch.Logdaten.Rows(iii)("uhrzeit").ToString > "03:00" Then
                        If DsLogbuch.Logdaten.Rows(iii - 1)("antriebsart").ToString <> "m" And DsLogbuch.Logdaten.Rows(iii - 1)("DueGTag").ToString > 0 Then
                            MsgBox("Tagesabschluss am " & SafeData.FormatDateDe(DsLogbuch.Logdaten.Rows(iii - 1)("datum")) & " ist nicht durchgeführt.")
                        Else
                            If Char.IsUpper(DsLogbuch.Logdaten.Rows(iii - 1)("antriebsart").ToString) Then
                                MsgBox("Tagesabschluss am " & SafeData.FormatDateDe(DsLogbuch.Logdaten.Rows(iii - 1)("datum")) & " ist nicht durchgeführt.")
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
End Class