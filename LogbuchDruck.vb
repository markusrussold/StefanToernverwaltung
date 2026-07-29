Public Class LogbuchDruck
    Dim aaa As String
    Dim ToernN As String
    Dim BootN As String
    Dim buch1 As String
    Dim position As Integer
    Dim iii As Integer
    Dim datvon As String
    Dim datbis As String
    Public wach3 As Boolean = False
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Private Sub Logbuch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Wacheplan". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taWacheplan.Fill(Me.dsToernverwaltung.Wacheplan)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Toerndaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToerndaten.Fill(Me.DsLogbuch.Toerndaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.DsLogbuch.Temp)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.BootLog". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taBootLog.Fill(Me.DsLogbuch.BootLog)
        Me.taLogWacheplan.Fill(Me.DsLogbuch.LogWacheplan)
        Me.taZusammenfassung2.Fill(Me.DsLogbuch.Zusammenfassung2)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Logdaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taLogdaten.Fill(Me.DsLogbuch.Logdaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Dokumentation". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taDokumentation.Fill(Me.DsLogbuch.Dokumentation)
        Me.taMaengel.Fill(Me.DsLogbuch.Maengel)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Sicherheitseinweisung". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taSicherheitseinweisung.Fill(Me.DsLogbuch.Sicherheitseinweisung)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Boot". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        '    MaskedTextBox1.Mask = Today
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        If TextBox1.Text > "" Then
            Dim r As System.Data.DataRowView = bsToernname.Current
            xAdapter.SelectCommand = New OleDb.OleDbCommand
            xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
            bsToernname.CancelEdit()
            dsToernverwaltung.Toernname.Clear()
            xAdapter.Fill(dsToernverwaltung.Toernname)
            Label2.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
          End If
        Dim rxt As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        DsLogbuch.Temp.Clear()
        xtAdapter.Fill(DsLogbuch.Temp)
        bsTemp.AddNew()

        Dim rp As System.Data.DataRowView = bsMaengel.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Maengel"
        bsMaengel.CancelEdit()
        DsLogbuch.Maengel.Clear()
        pAdapter.Fill(DsLogbuch.Maengel)
        bsMaengel.Position = 0
        aaa = bsMaengel.Count
        bsMaengel.AddNew()
        GroupBox2.Location = New Point(1200, 1100)
        GroupBox3.Location = New Point(1200, 1100)
        GroupBox4.Location = New Point(1200, 1100)
        '    Label2.Visible = False
        Label3.Text = ""
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current

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
                GroupBox2.Location = New Point(21, 110)
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                Formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                Label2.Visible = True
                Label2.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                Label2.Refresh()
                GroupBox2.Location = New Point(1200, 1100)
                GroupBox4.Location = New Point(16, 161)
                ToernN = TextBox1.Text
                BootN = Label2.Text
                '             TextBox3.Text = TextBox1.Text                                         ' Feld2
                TextBox18.Text = dsToernverwaltung.Toernname.Rows(0)("Skipper")
                TextBox3.Text = dsToernverwaltung.Toernname.Rows(0)("datumvon")
                datvon = dsToernverwaltung.Toernname.Rows(0)("datumvon")
                datbis = dsToernverwaltung.Toernname.Rows(0)("datumbis")
                TextBox4.Text = dsToernverwaltung.Toernname.Rows(0)("datumbis")
                If Not DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("Revier")) Then TextBox5.Text = dsToernverwaltung.Toernname.Rows(0)("Revier")
                TextBox26.Text = dsToernverwaltung.Toernname.Rows(0)("bootsname")
                Button1.Enabled = False
            Case Else
                GroupBox2.Location = New Point(21, 110)
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position

        End Select

    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub Formularloeschen()
        TextBox1.Text = ""
    End Sub
    Private Sub positionieren()
        Me.iii = bsToernname.Count - 1
        For i = 0 To Me.iii
            aaa = Mid(dsToernverwaltung.Toernname.Rows(i)("toernbezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub

    Private Sub SuchenMaengel()
        Dim rp As System.Data.DataRowView = bsMaengel.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Maengel where toernbezeichnung = '" & TextBox1.Text & "'  order by datum"
        bsMaengel.CancelEdit()
        DsLogbuch.Maengel.Clear()
        pAdapter.Fill(DsLogbuch.Maengel)
        bsMaengel.Position = 0
        aaa = bsMaengel.Count
        If aaa > 0 Then
            For Me.iii = 0 To aaa - 1
                ProgressBar9.Maximum = aaa - 1
                ProgressBar9.Minimum = 0
                ProgressBar9.Step = 1
                ProgressBar9.Value = Me.iii              ' i 
                ProgressBar9.PerformStep()
                TextBox2.Text = "8"                                            '            Reihenfolge   Feld1
                Blank(TextBox4.Text, DsLogbuch.Maengel.Rows(Me.iii)("Datum"), " ")
                Blank(TextBox7.Text, DsLogbuch.Maengel.Rows(Me.iii)("Betrifft"), " ")
                Blank(TextBox8.Text, DsLogbuch.Maengel.Rows(Me.iii)("Defekt"), " ")
                Blank(TextBox9.Text, DsLogbuch.Maengel.Rows(Me.iii)("Auswirkung"), " ")
                bsTemp.AddNew()
                taTemp.Update(DsLogbuch.Temp)
            Next
        Else
            TextBox2.Text = "8"                                            '            Reihenfolge   Feld1
            TextBox4.Text = " "
            TextBox7.Text = " "        'feld6
            TextBox8.Text = " "
            TextBox9.Text = " "
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
        End If
    End Sub
    Private Sub suchenBoot()
        Label3.Text = "Bootdaten"
        Label3.Visible = True
        Label3.Refresh()
        CheckBox23.Visible = True
        Dim rp As System.Data.DataRowView = bsBoot.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & BootN & "' "
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        bsBoot.Position = 0
        aaa = bsBoot.Count
        CheckBox23.Checked = True
        TextBox2.Text = "1"                                            '            Reihenfolge   Feld1
        TextBox6.Text = dsToernverwaltung.Boot.Rows(0)("marke")                ' Marke    Feld5
        TextBox7.Text = dsToernverwaltung.Boot.Rows(0)("Schiffstyp")           ' Schiffstyp      feld6
        TextBox8.Text = dsToernverwaltung.Boot.Rows(0)("Kielart")              'feld7
        If Not DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Schiffsnummer")) Then TextBox9.Text = dsToernverwaltung.Boot.Rows(0)("Schiffsnummer") 'feld8
        TextBox10.Text = dsToernverwaltung.Boot.Rows(0)("Länge")        'feld9
        TextBox11.Text = dsToernverwaltung.Boot.Rows(0)("Breite")        'feld10
        If Not DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Verdrängung")) Then TextBox12.Text = dsToernverwaltung.Boot.Rows(0)("Verdrängung") 'feld11
        TextBox13.Text = dsToernverwaltung.Boot.Rows(0)("Tiefgang")        'feld12
        If IsNumeric(dsToernverwaltung.Boot.Rows(0)("Vorsegel")) And IsNumeric(dsToernverwaltung.Boot.Rows(0)("großsegel")) Then
            Dim ge As Single = dsToernverwaltung.Boot.Rows(0)("Vorsegel")
            Dim gs As Single = dsToernverwaltung.Boot.Rows(0)("großsegel")
            TextBox14.Text = ge + gs
        End If
        Blank(TextBox15.Text, dsToernverwaltung.Boot.Rows(0)("Baujahr"), 0)       'feld14
        Blank(TextBox16.Text, dsToernverwaltung.Boot.Rows(0)("Charterfirma"), " ")     'feld15
        Blank(TextBox17.Text, dsToernverwaltung.Boot.Rows(0)("Motor"), " ")     'feld16
        Blank(TextBox25.Text, dsToernverwaltung.Boot.Rows(0)("Mmsi"), " ")     'feld16


        Dim rpl As System.Data.DataRowView = bsBootLog.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from BootLog where bootname = '" & BootN & "'"
        bsBootLog.CancelEdit()
        DsLogbuch.BootLog.Clear()
        pAdapter.Fill(DsLogbuch.BootLog)
        bsBootLog.Position = 0
        aaa = bsBootLog.Count
        If aaa = 0 Then
            GoTo endeboot
        End If
        Blank(TextBox19.Text, DsLogbuch.BootLog.Rows(0)("Motormarke"), " ")              ' Feld18
        Blank(TextBox20.Text, DsLogbuch.BootLog.Rows(0)("Beibootmarke"), " ")
        Blank(TextBox21.Text, DsLogbuch.BootLog.Rows(0)("Beobootleistung"), 0)  'feld20
        Blank(TextBox22.Text, DsLogbuch.BootLog.Rows(0)("Baustoff"), " ") 'feld21
        Blank(TextBox23.Text, DsLogbuch.BootLog.Rows(0)("Bootsbild"), " ")
        Bildprüfung(DsLogbuch.BootLog.Rows(0)("Bootsbild"), "Bootes")
        Dim rpt As System.Data.DataRowView = bsToerndaten.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Toerndaten where toernbezeichnung = '" & TextBox1.Text & "' "
        bsToerndaten.CancelEdit()
        DsLogbuch.Toerndaten.Clear()
        pAdapter.Fill(DsLogbuch.Toerndaten)
        bsToerndaten.Position = 0
        aaa = bsToerndaten.Count
        If aaa = 0 Then
            GoTo endeboot
        End If
        Blank(TextBox24.Text, DsLogbuch.Toerndaten.Rows(0)("Revierbild"), " ")
        Bildprüfung(DsLogbuch.Toerndaten.Rows(0)("Revierbild"), "Reviers")
endeboot:
        bsTemp.AddNew()
        taTemp.Update(DsLogbuch.Temp)

    End Sub
    Private Sub Bildprüfung(speicherort, art)
        If IsDBNull(speicherort) Then
        Else
            If My.Computer.FileSystem.FileExists(speicherort) Then
            Else
                MsgBox("Das Bild des " & Convert.ToString(art) & " ist nicht richtig verlinkt. Siehe Logbuch/Törnbeschreibung.")
            End If
        End If
    End Sub
    Private Sub suchenToerndaten()
        If aaa > 0 Then
            CheckBox24.Visible = True
            Label4.Visible = True
            Label4.Refresh()
            TextBox2.Text = "2"                                            '            Reihenfolge   Feld1
            Blank(TextBox6.Text, DsLogbuch.Toerndaten.Rows(0)("geplanteroute"), " ")
            Blank(TextBox7.Text, DsLogbuch.Toerndaten.Rows(0)("Kassamanager"), " ")
            Blank(TextBox8.Text, DsLogbuch.Toerndaten.Rows(0)("Ersteinzahlung"), " ")
            Blank(TextBox9.Text, DsLogbuch.Toerndaten.Rows(0)("Pantrymanager"), " ")
            Blank(TextBox10.Text, DsLogbuch.Toerndaten.Rows(0)("Ersteinkauf"), " ")
            Blank(TextBox11.Text, DsLogbuch.Toerndaten.Rows(0)("gefahreneroute"), " ")
            CheckBox24.Checked = True
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
            TextBox2.Text = "5"                                            '            Reihenfolge   Feld1
            Blank(TextBox6.Text, DsLogbuch.Toerndaten.Rows(0)("SeemeilenM"), " ")
            Blank(TextBox7.Text, DsLogbuch.Toerndaten.Rows(0)("SeemeilenS"), " ")
            Blank(TextBox8.Text, DsLogbuch.Toerndaten.Rows(0)("MotorStd"), " ")
            Blank(TextBox9.Text, DsLogbuch.Toerndaten.Rows(0)("Nachtfahrten"), "")
            Blank(TextBox10.Text, DsLogbuch.Toerndaten.Rows(0)("Nachtansteuerungen"), "")
            Blank(TextBox11.Text, DsLogbuch.Toerndaten.Rows(0)("KartenMissweisung"), " ")
            Select Case TextBox11.Text
                Case Is > 0
                    TextBox11.Text = TextBox11.Text + "°E"
                Case Is < 0
                    TextBox11.Text = TextBox11.Text * (-1)
                    TextBox11.Text = TextBox11.Text + "°W"
            End Select
            Blank(TextBox12.Text, DsLogbuch.Toerndaten.Rows(0)("Sonnenaufgang"), " ")
            Blank(TextBox13.Text, DsLogbuch.Toerndaten.Rows(0)("Sonnenuntergang"), " ")
            Blank(TextBox14.Text, DsLogbuch.Toerndaten.Rows(0)("Navtexstationen"), " ")
            Blank(TextBox15.Text, DsLogbuch.Toerndaten.Rows(0)("MaxTidenhub"), " ")
            Blank(TextBox16.Text, DsLogbuch.Toerndaten.Rows(0)("Vollmond"), " ")
            '         If Not DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(Me.iii)("Sonstiges")) Then TextBox17.Text = DsLogbuch.Toerndaten.Rows(Me.iii)("Sonstiges")
            If Not DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Sonstiges")) Then TextBox17.Text = DsLogbuch.Toerndaten.Rows(Me.iii)("Sonstiges")
        Else
            bsTemp.AddNew()
            TextBox2.Text = "2"                                            '            Reihenfolge   Feld1
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
            bsTemp.AddNew()
            TextBox2.Text = "4"                                            '            Reihenfolge   Feld1
            taTemp.Update(DsLogbuch.Temp)
            bsTemp.AddNew()
            TextBox2.Text = "5"                                            '            Reihenfolge   Feld1
            Blank(TextBox14.Text, DsLogbuch.Toerndaten.Rows(0)("Navtexstationen"), " ")
            taTemp.Update(DsLogbuch.Temp)
            bsTemp.AddNew()
        End If
        bsTemp.AddNew()
        taTemp.Update(DsLogbuch.Temp)
    End Sub
    Private Sub Blank(ByRef text, ByVal disk, ByVal st)
        If Not DBNull.Value.Equals(disk) Then
            If Len(disk) = 0 Then text = st Else text = disk
        Else
            text = st
        End If
    End Sub
    Private Sub SuchenCrew()
        Dim rp As System.Data.DataRowView = bsTC.Current
        ProgressBar3.Visible = True
        Label5.Visible = True
        Label5.Refresh()
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from tc where toern = '" & TextBox1.Text & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        pAdapter.Fill(dsToernverwaltung.TC)
        bsTC.Position = 0
        aaa = bsTC.Count
        For Me.iii = 0 To aaa - 1
            ProgressBar3.Maximum = aaa - 1
            ProgressBar3.Minimum = 0
            ProgressBar3.Step = 1
            ProgressBar3.Value = Me.iii              ' i 
            ProgressBar3.PerformStep()
            '         ProgressBar3.Refresh()
            TextBox2.Text = "3"                                            '            Reihenfolge   Feld1
            TextBox6.Text = dsToernverwaltung.TC.Rows(Me.iii)("VZname")              ' Feld5
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
        Next
    End Sub
    Private Sub suchenSicherheit()
        Dim rp As System.Data.DataRowView = bsSicherheitseinweisung.Current
        CheckBox25.Visible = True
        Label6.Visible = True
        Label6.Refresh()
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Sicherheitseinweisung where toernbezeichnung = '" & TextBox1.Text & "'"
        bsSicherheitseinweisung.CancelEdit()
        DsLogbuch.Sicherheitseinweisung.Clear()
        pAdapter.Fill(DsLogbuch.Sicherheitseinweisung)
        bsSicherheitseinweisung.Position = 0
        aaa = bsSicherheitseinweisung.Count
        If aaa > 0 Then
            For Me.iii = 0 To aaa - 1
                CheckBox25.Checked = True
                TextBox2.Text = "4"                                            '            Reihenfolge   Feld1
                Blank(TextBox6.Text, DsLogbuch.Sicherheitseinweisung.Rows(Me.iii)("SiDatum"), " ")             ' Feld5
                Blank(TextBox7.Text, DsLogbuch.Sicherheitseinweisung.Rows(Me.iii)("SiVon"), " ")       'feld6
                Blank(TextBox8.Text, DsLogbuch.Sicherheitseinweisung.Rows(Me.iii)("SiBis"), " ")     'feld7
                bsTemp.AddNew()
                taTemp.Update(DsLogbuch.Temp)
            Next
        Else
            TextBox2.Text = "4"                                            '            Reihenfolge   Feld1
            TextBox6.Text = " "           ' Feld5
            TextBox7.Text = " "           'feld6
            TextBox8.Text = " "           'feld7
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
        End If
    End Sub
    Private Sub suchenLog()
        Dim geb As String
        Dim ErsterSegeltag As String = datvon
        Dim LetzterTag As String = datbis
        Dim rp As System.Data.DataRowView = bsDokumentation.Current
        Dim aab As String
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Dokumentation where toernbezeichnung = '" & TextBox1.Text & "'  order by datum"
        bsDokumentation.CancelEdit()
        DsLogbuch.Dokumentation.Clear()
        pAdapter.Fill(DsLogbuch.Dokumentation)
        bsDokumentation.Position = 0
        aaa = bsDokumentation.Count
        If aaa > 0 Then
            If RadioButton2.Checked Then
                MsgBox("Für diesen Törn ist das Logbuch bereits ausgefüllt.")
                Me.Close()
            End If
            If Not DBNull.Value.Equals(DsLogbuch.Dokumentation.Rows(0)("Datum")) Then ErsterSegeltag = DsLogbuch.Dokumentation.Rows(0)("Datum")
            If Not DBNull.Value.Equals(DsLogbuch.Dokumentation.Rows(aaa - 1)("Datum")) Then LetzterTag = DsLogbuch.Dokumentation.Rows(aaa - 1)("Datum")
            For Me.iii = 0 To aaa - 1
                ProgressBar5.Maximum = aaa - 1
                ProgressBar5.Minimum = 0
                ProgressBar5.Step = 1
                ProgressBar5.Value = Me.iii              ' i 
                ProgressBar5.PerformStep()
                TextBox2.Text = "6"
                TextBox3.Text = "1"                                 '            Reihenfolge intern  Feld2
                TextBox4.Text = DsLogbuch.Dokumentation.Rows(Me.iii)("Datum")              ' Feld5
                Blank(TextBox6.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Wetterbericht1"), " ")              ' Feld18
                Blank(TextBox7.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Wetterbericht2"), " ")              ' Feld18
                Blank(TextBox8.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Wetterbericht3"), " ")              ' Feld18
                Blank(TextBox9.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Uhrzeit"), " ")              ' Feld18
                Blank(TextBox10.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Zielanlegeart"), " ")              ' Feld18
                If Not DBNull.Value.Equals(DsLogbuch.Dokumentation.Rows(Me.iii)("Zielgebühr")) Then
                    geb = DsLogbuch.Dokumentation.Rows(Me.iii)("Zielgebühr")
                Else
                    geb = "0"
                End If
                Blank(TextBox11.Text, geb, " ")              ' Feld18
                Blank(TextBox12.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("MotorstdAnfang"), " ")              ' Feld18
                Blank(TextBox13.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("MotorstdEnde"), " ")              ' Feld18
                Blank(TextBox14.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Kraftstoffgetankt"), " ")              ' Feld18
                Blank(TextBox15.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Kraffstoffkosten"), " ")              ' Feld18
                Blank(TextBox16.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Ausgangsort"), " ")              ' Feld18
                Blank(TextBox17.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("zielort"), " ")              ' Feld18
                Blank(RichTextBox1.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Bemerkungen"), " ")              ' Feld18
                Blank(RichTextBox2.Text, DsLogbuch.Dokumentation.Rows(Me.iii)("Besonderes"), " ")              ' Feld18
                bsTemp.AddNew()
                '          taTemp.Update(DsLogbuch.Temp)
                aab = bsTemp.Count
                DsLogbuch.Temp.Rows(aab - 2)("feld26") = DsLogbuch.Dokumentation.Rows(Me.iii)("ZielMüll")
                DsLogbuch.Temp.Rows(aab - 2)("feld27") = DsLogbuch.Dokumentation.Rows(Me.iii)("ZielStrom")
                DsLogbuch.Temp.Rows(aab - 2)("feld28") = DsLogbuch.Dokumentation.Rows(Me.iii)("Checkbilge")
                DsLogbuch.Temp.Rows(aab - 2)("feld29") = DsLogbuch.Dokumentation.Rows(Me.iii)("Wassertanken")
                DsLogbuch.Temp.Rows(aab - 2)("feld30") = DsLogbuch.Dokumentation.Rows(Me.iii)("checkoel")
                DsLogbuch.Temp.Rows(aab - 2)("feld31") = DsLogbuch.Dokumentation.Rows(Me.iii)("checkBatterie")
                taTemp.Update(DsLogbuch.Temp)
            Next
        Else
            LeereSeiten(1)
        End If
        ProgressBar6.Visible = True
        Label9.Visible = True
        Label9.Refresh()
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & TextBox1.Text & "'  order by datum, textvon"
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        pAdapter.Fill(DsLogbuch.LogWacheplan)
        bsLogWacheplan.Position = 0
        aaa = bsLogWacheplan.Count
        If aaa > 0 Then
            For Me.iii = 0 To aaa - 1
                If ErsterSegeltag <= DsLogbuch.LogWacheplan.Rows(Me.iii)("Datum") And LetzterTag >= DsLogbuch.LogWacheplan.Rows(Me.iii)("Datum") Then
                    ProgressBar6.Maximum = aaa - 1
                    ProgressBar6.Minimum = 0
                    ProgressBar6.Step = 1
                    ProgressBar6.Value = Me.iii              ' i 
                    ProgressBar6.PerformStep()
                    TextBox2.Text = "6"
                    TextBox3.Text = "2"                                 '            Reihenfolge intern  Feld2
                    TextBox4.Text = DsLogbuch.LogWacheplan.Rows(Me.iii)("Datum")              ' Feld5
                    TextBox23.Text = Year(TextBox4.Text)
                    TextBox24.Text = Month(TextBox4.Text)
                    TextBox21.Text = TextBox4.Text.Substring(0, 2)
                    If Not DBNull.Value.Equals(DsLogbuch.LogWacheplan.Rows(Me.iii)("Person1")) And Not DBNull.Value.Equals(DsLogbuch.LogWacheplan.Rows(Me.iii)("Person2")) Then
                        If Not DBNull.Value.Equals(DsLogbuch.LogWacheplan.Rows(Me.iii)("Textvon")) Then TextBox5.Text = DsLogbuch.LogWacheplan.Rows(Me.iii)("Textvon")
                        TextBox6.Text = DsLogbuch.LogWacheplan.Rows(Me.iii)("Person1")           'feld6
                        TextBox9.Text = DsLogbuch.LogWacheplan.Rows(Me.iii)("Person2")              ' Feld8
                        If DsLogbuch.LogWacheplan.Rows(Me.iii)("Person3").ToString > "" Then
                            wach3 = True
                            TextBox27.Text = DsLogbuch.LogWacheplan.Rows(Me.iii)("Person3")              ' Feld9
                        Else
                            TextBox27.Text = ""
                        End If
                        If Not DBNull.Value.Equals(DsLogbuch.LogWacheplan.Rows(Me.iii)("Textbis")) Then TextBox11.Text = DsLogbuch.LogWacheplan.Rows(Me.iii)("Textbis")
                        bsTemp.AddNew()
                        taTemp.Update(DsLogbuch.Temp)
                    End If
                End If
            Next
            If RadioButton2.Checked Then
                TextBox2.Text = "6"
                TextBox3.Text = "2"                                 '            Reihenfolge intern  Feld2
                TextBox4.Text = datbis
                TextBox23.Text = Year(TextBox4.Text)
                TextBox24.Text = Month(TextBox4.Text)
                TextBox21.Text = TextBox4.Text.Substring(0, 2)
                bsTemp.AddNew()
                taTemp.Update(DsLogbuch.Temp)
            End If
        Else
            LeereSeiten(2)
        End If
        ProgressBar7.Visible = True
        Label10.Visible = True
        Label10.Refresh()
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Logdaten where toerbezeichnung = '" & TextBox1.Text & "'  order by datum, uhrzeit"
        bsLogdaten.CancelEdit()
        DsLogbuch.Logdaten.Clear()
        pAdapter.Fill(DsLogbuch.Logdaten)
        bsLogdaten.Position = 0
        aaa = bsLogdaten.Count
        For Me.iii = 0 To aaa - 1
            ProgressBar7.Maximum = aaa - 1
            ProgressBar7.Minimum = 0
            ProgressBar7.Step = 1
            ProgressBar7.Value = Me.iii              ' i 
            ProgressBar7.PerformStep()
            TextBox2.Text = "6"
            TextBox3.Text = "3"                                 '            Reihenfolge intern  Feld2
            TextBox4.Text = DsLogbuch.Logdaten.Rows(Me.iii)("Datum")              ' Feld5
            Blank(TextBox5.Text, DsLogbuch.Logdaten.Rows(Me.iii)("Uhrzeit"), " ")              ' Feld18
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("Windrichtung")) Then TextBox7.Text = DsLogbuch.Logdaten.Rows(Me.iii)("Windrichtung")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("windstaerke")) Then TextBox8.Text = DsLogbuch.Logdaten.Rows(Me.iii)("Windstaerke")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("Seegang")) Then TextBox9.Text = DsLogbuch.Logdaten.Rows(Me.iii)("seegang")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("Luftdruck")) Then TextBox10.Text = DsLogbuch.Logdaten.Rows(Me.iii)("Luftdruck")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("wolken")) Then TextBox11.Text = DsLogbuch.Logdaten.Rows(Me.iii)("wolken")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("Kueg")) Then TextBox12.Text = DsLogbuch.Logdaten.Rows(Me.iii)("Kueg")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("ort")) Then TextBox13.Text = DsLogbuch.Logdaten.Rows(Me.iii)("ort") Else TextBox13.Text = " "
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("Antriebsart")) Then TextBox14.Text = DsLogbuch.Logdaten.Rows(Me.iii)("Antriebsart")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("DueGTag")) Then TextBox15.Text = DsLogbuch.Logdaten.Rows(Me.iii)("DuegTag")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("Duegsegel")) Then TextBox16.Text = DsLogbuch.Logdaten.Rows(Me.iii)("duegsegel")
            If Not DBNull.Value.Equals(DsLogbuch.Logdaten.Rows(Me.iii)("duegmotor")) Then TextBox17.Text = DsLogbuch.Logdaten.Rows(Me.iii)("duegmotor")
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
        Next

    End Sub
    Private Sub LeereSeiten(seitenteil)
        Dim aab As String
        Dim von As Date = CDate(datvon)
        Dim bis As Date = CDate(datbis)
        Dim datum As Date = von
        Dim datdiff As Long = DateDiff("d", von, bis)
        If seitenteil = 1 Then
            For Me.iii = 0 To datdiff
                TextBox2.Text = "6"
                TextBox3.Text = "1"                                 '            Reihenfolge intern  Feld2

                TextBox4.Text = DateAdd(DateInterval.Day, Me.iii, datum)
                '               year(feld3), month(feld3), day(feld3)
                TextBox23.Text = Year(TextBox4.Text)
                TextBox24.Text = Month(TextBox4.Text)
                TextBox21.Text = TextBox4.Text.Substring(0, 2)
                TextBox6.Text = " "              ' 
                TextBox7.Text = " "              ' 
                TextBox8.Text = " "              ' 
                TextBox9.Text = " "              ' 
                TextBox10.Text = " "              ' 
                TextBox11.Text = " "              ' 
                TextBox12.Text = " "              ' 
                TextBox13.Text = " "              ' 
                TextBox14.Text = " "              ' 
                TextBox15.Text = " "              ' 
                TextBox16.Text = " "              ' 
                TextBox17.Text = " "              ' 
                RichTextBox1.Text = " "              ' 
                RichTextBox2.Text = " "              ' 
                bsTemp.AddNew()
                taTemp.Update(DsLogbuch.Temp)

                TextBox2.Text = "6"
                TextBox3.Text = "3"                                 '            Reihenfolge intern  Feld2

                TextBox4.Text = DateAdd(DateInterval.Day, Me.iii, datum)
                '               year(feld3), month(feld3), day(feld3)
                TextBox23.Text = Year(TextBox4.Text)
                TextBox24.Text = Month(TextBox4.Text)
                TextBox21.Text = TextBox4.Text.Substring(0, 2)
                TextBox6.Text = " "              ' 
                TextBox7.Text = " "              ' 
                TextBox8.Text = " "              ' 
                TextBox9.Text = " "              ' 
                TextBox10.Text = " "              ' 
                TextBox11.Text = " "              ' 
                TextBox12.Text = " "              ' 
                TextBox13.Text = " "              ' 
                TextBox14.Text = " "              ' 
                TextBox15.Text = " "              ' 
                TextBox16.Text = " "              ' 
                TextBox17.Text = " "              ' 
                RichTextBox1.Text = " "              ' 
                RichTextBox2.Text = " "              ' 
                bsTemp.AddNew()
                taTemp.Update(DsLogbuch.Temp)

                TextBox2.Text = "7"
                TextBox3.Text = " "
                TextBox4.Text = DateAdd(DateInterval.Day, Me.iii, datum)          ' Feld
                TextBox6.Text = " "              ' 
                TextBox7.Text = " "              ' 
                TextBox8.Text = " "              ' 
                TextBox9.Text = " "              ' 
                TextBox10.Text = " "              ' 
                TextBox11.Text = " "              ' 
                TextBox12.Text = " "              ' 
                TextBox13.Text = " "              ' 
                TextBox14.Text = " "              ' 
                TextBox15.Text = " "              ' 
                TextBox16.Text = " "              ' 
                TextBox17.Text = " "              ' 
                RichTextBox1.Text = " "              ' 
                RichTextBox2.Text = " "              ' 
                bsTemp.AddNew()
                taTemp.Update(DsLogbuch.Temp)
            Next
        End If
        If seitenteil = 2 Then
            For Me.iii = 0 To datdiff
                TextBox2.Text = "6"
                TextBox3.Text = "2"                                 '            Reihenfolge intern  Feld2

                TextBox4.Text = DateAdd(DateInterval.Day, Me.iii, datum)       ' Feld
                TextBox23.Text = Year(TextBox4.Text)
                TextBox24.Text = Month(TextBox4.Text)
                TextBox21.Text = TextBox4.Text.Substring(0, 2)
                TextBox6.Text = " "              ' 
                TextBox7.Text = " "              ' 
                TextBox8.Text = " "              ' 
                TextBox9.Text = " "              ' 
                TextBox10.Text = " "              ' 
                TextBox11.Text = " "              ' 
                TextBox12.Text = " "              ' 
                TextBox13.Text = " "              ' 
                TextBox14.Text = " "              ' 
                TextBox15.Text = " "              ' 
                TextBox16.Text = " "              ' 
                TextBox17.Text = " "              ' 
                RichTextBox1.Text = " "              ' 
                RichTextBox2.Text = " "              ' 
                bsTemp.AddNew()
                taTemp.Update(DsLogbuch.Temp)
            Next
        End If
    End Sub
    Private Sub suchenZusammen()
        Dim rp As System.Data.DataRowView = bsZusammenfassung2.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Zusammenfassung2 where toernbezeichnung = '" & TextBox1.Text & "'  order by datumvon"
        bsZusammenfassung2.CancelEdit()
        DsLogbuch.Zusammenfassung2.Clear()
        pAdapter.Fill(DsLogbuch.Zusammenfassung2)
        bsZusammenfassung2.Position = 0
        aaa = bsZusammenfassung2.Count
        For Me.iii = 0 To aaa - 1
            ProgressBar8.Maximum = aaa - 1
            ProgressBar8.Minimum = 0
            ProgressBar8.Step = 1
            ProgressBar8.Value = Me.iii              ' i 
            ProgressBar8.PerformStep()
            TextBox2.Text = "7"                                            '            Reihenfolge   Feld1
            TextBox4.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("DatumVon")              ' Feld5
            Blank(TextBox7.Text, DsLogbuch.Zusammenfassung2.Rows(Me.iii)("ZeitVon"), " ")              ' Feld18
            If Not DBNull.Value.Equals(DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Ausfahrt")) Then
                TextBox8.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Ausfahrt")
            Else
                TextBox8.Text = " "
            End If
            TextBox9.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("DatumBis")           'feld8
            Blank(TextBox10.Text, DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Zeitbis"), " ")              ' Feld18
            If Not DBNull.Value.Equals(DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Ziel")) Then
                TextBox11.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Ziel")
            Else
                TextBox11.Text = " "
            End If
            Blank(TextBox12.Text, DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Windrichtung"), " ")              ' Feld18
             Blank(TextBox13.Text, DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Windstaerke"), " ")              ' Feld18
            TextBox14.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("SmuSegel")           'feld8
            TextBox15.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("SmuMotor")           'feld8
            TextBox16.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("SmGesamt")           'feld8
            '        TextBox13.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Bemerkung")           'feld8
            If Not DBNull.Value.Equals(DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Bemerkung")) Then TextBox23.Text = DsLogbuch.Zusammenfassung2.Rows(Me.iii)("Bemerkung") 'feld23
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
        Next

    End Sub
    Private Sub Wacheplan()
        Dim rp As System.Data.DataRowView = bsWacheplan.Current()
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Wacheplan where toern = '" & ToernN & "' "
        bsWacheplan.CancelEdit()
        dsToernverwaltung.Wacheplan.Clear()
        pAdapter.Fill(dsToernverwaltung.Wacheplan)
        bsWacheplan.Position = 0
        aaa = bsWacheplan.Count
        CheckBox23.Checked = True
        For Me.iii = 0 To aaa - 2
            ProgressBar6.Maximum = aaa - 1
            ProgressBar6.Minimum = 0
            ProgressBar6.Step = 1
            ProgressBar6.Value = Me.iii              ' i 
            ProgressBar6.PerformStep()
            TextBox2.Text = "6"
            TextBox3.Text = "2"                                 '            Reihenfolge intern  Feld2
            TextBox4.Text = dsToernverwaltung.Wacheplan.Rows(Me.iii)("Datum1").ToString.Substring(0, 10)
            If Not DBNull.Value.Equals(dsToernverwaltung.Wacheplan.Rows(Me.iii)("Datum1").ToString.Substring(11, 5)) Then TextBox5.Text = dsToernverwaltung.Wacheplan.Rows(Me.iii)("Datum1").ToString.Substring(11, 5)
            TextBox6.Text = dsToernverwaltung.Wacheplan.Rows(Me.iii)("Person1")           'feld6
            Blank(TextBox9.Text, dsToernverwaltung.Wacheplan.Rows(Me.iii)("Person2"), " ")              ' Feld18
            If Not DBNull.Value.Equals(dsToernverwaltung.Wacheplan.Rows(Me.iii + 1)("Datum2").ToString.Substring(11, 5)) Then TextBox11.Text = dsToernverwaltung.Wacheplan.Rows(Me.iii + 1)("Datum2").ToString.Substring(11, 5)
            bsTemp.AddNew()
            taTemp.Update(DsLogbuch.Temp)
        Next
    End Sub
    Private Sub ButtonDrucken_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDrucken.Click
        Me.Cursor = Cursors.WaitCursor
        Dim XLB As New PrintOutLB
        Dim dv As DataView
        Dim t As DataTable
        Dim pxAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpx As System.Data.DataRowView = bsTemp.Current
        pxAdapter.SelectCommand = New OleDb.OleDbCommand
        pxAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        If RadioButton1.Checked Then
            pxAdapter.SelectCommand.CommandText = "Select * from temp order by feld1, year(feld3), month(feld3), day(feld3), feld2, feld4"
        Else
            pxAdapter.SelectCommand.CommandText = "Select * from temp order by feld1, feld23, feld24, feld20, feld2, feld4"
        End If
        bsTemp.CancelEdit()
        DsLogbuch.Temp.Clear()
        pxAdapter.Fill(DsLogbuch.Temp)
        bsTemp.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld8", "Feld9", "Feld10", "Feld11", "Feld12", "Feld13", "Feld14", "Feld15", "Feld16", "Feld17", "Feld18", "Feld19", "Feld20", "Feld21", "Feld22", "Feld23", "Feld24", "Feld25", "Feld26", "Feld27", "Feld28", "Feld29", "Feld30", "Feld31", "Feld32")
        XLB.Printlogbuch(t)
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        suchen()
    End Sub

    Private Sub DataGridtoern_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridtoern.CellMouseClick
        suchen()
    End Sub
    Private Sub RadioButton1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButton1.MouseClick
        If RadioButton1.Checked Then
            GroupBox4.Location = New Point(2100, 1100)
            GroupBox3.Location = New Point(16, 161)
            suchenBoot()
            If aaa = 0 Then
                MsgBox("Für diesen Törn ist noch kein Logbuch angelegt.")
                GroupBox2.Location = New Point(16, 161)
                GoTo endesuch
            End If
            suchenToerndaten()

            SuchenCrew()
            suchenSicherheit()
            '             suchenAstro()

            ProgressBar5.Visible = True
            Label8.Visible = True
            Label8.Refresh()
            suchenLog()

            ProgressBar8.Visible = True
            Label11.Visible = True
            Label11.Refresh()
            suchenZusammen()

            ProgressBar9.Visible = True
            Label12.Visible = True
            Label12.Text = "Technische Mängel"
            Label12.Refresh()
            SuchenMaengel()
            ButtonDrucken.Enabled = True
            ButtonDrucken.Focus()
        End If
endesuch:
    End Sub
    Private Sub RadioButton2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButton2.MouseClick
        If RadioButton2.Checked Then
            Me.Cursor = Cursors.WaitCursor
            GroupBox4.Location = New Point(2100, 1100)
            GroupBox3.Location = New Point(16, 161)
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            suchenBoot()
            suchenLog()
            suchenToerndaten()
            SuchenCrew()
            ProgressBar6.Visible = True
            Label9.Visible = True
            Label9.Refresh()
            '           Wacheplan()
            SuchenMaengel()
            ButtonDrucken.Enabled = True
            ButtonDrucken.Focus()
            Me.Cursor = Cursors.Default
        End If
    End Sub

  
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        suchen()
    End Sub
End Class