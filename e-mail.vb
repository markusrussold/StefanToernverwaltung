Imports System
Imports System.Net.Mail
Public Class EMail
    Dim variableemail As String
    Dim fehler As String
    Dim t1 As String
    Dim t2 As String
    Dim fb_Auswahl As Single
    Dim t3 As String
    Dim t4 As String
    Dim t5 As String
    Dim t6 As String
    Dim t7 As String
    Dim t8 As String
    Dim t9 As String
    Dim t0 As Boolean
    Dim aaa As String
    Dim ij As Integer
    Dim lebend As DateTime = "01.01.2000"
    Dim handy As String
    Dim adrzaehler As String
    Dim vnm As String
    Dim nm As String
    Dim r1 As String
    Dim anr As String
    Dim iii As Integer
    Dim zmail As Integer
    Dim emailText As String
    Dim betreff As String
    Dim kodatum As DateTime
    Public anhang1 As String
    Public anhang2 As String
    Public anhang3 As String
    Dim ok As Boolean
    Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                         ' Adressen
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim vtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                       ' Veranstaltungsteilnehmer
    Dim vaAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                       ' Veranstaltung
    Dim tcAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                       ' Törncrew 
    Dim tnAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                       ' Törnname
    Dim ktAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                       ' Kontakte
    Private Sub EMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKontakte.Fill(Me.DsAusbildung.Kontakte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.VeranstalTeilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taVeranstalTeilnehmer.Fill(Me.DsAusbildung.VeranstalTeilnehmer)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Veranstaltungen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taVeranstaltungen.Fill(Me.DsAusbildung.Veranstaltungen)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        '
        '                                                          vbr1    für r1 in der Datenbank
        '
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rkt As System.Data.DataRowView = bsKurse.Current
        Dim rva As System.Data.DataRowView = bsVeranstaltungen.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        emailText = GetSetting("emailtext", "T1", "Text", " ")
        betreff = GetSetting("emailtext", "T1", "Betreff", " ")
        anhang1 = GetSetting("emailtext", "T1", "Anhang1", "")
        anhang2 = GetSetting("emailtext", "T1", "Anhang2", "")
        anhang3 = GetSetting("emailtext", "T1", "Anhang3", "")
        If Not IsDBNull(anhang1) And My.Computer.FileSystem.FileExists(anhang1) Then
            Label19.Visible = True
            Label19.Text = anhang1
        End If
        If Not IsDBNull(anhang2) And My.Computer.FileSystem.FileExists(anhang2) Then
            Label20.Text = anhang2
            Label20.Visible = True
        End If
        If Not IsDBNull(anhang3) And My.Computer.FileSystem.FileExists(anhang3) Then
            Label21.Text = anhang3
            Label21.Visible = True
        End If
        If Label19.Text > "" Then Button7.Visible = True
        If Label20.Text > "" Then Button9.Visible = True
        If Label21.Text > "" Then Button8.Visible = True
        RichTextBox1.Text = emailText
            TextBox6.Text = betreff
            Me.MaximumSize = New Size(fbreite, fhoehe)

            '   FreischaltZiffer:
            '0      Test Törnverwaltung, keine Kursverwaltung
            '1      Törnverwaltung
            '2      Test Törnverwaltung + Test Kursverwaltung
            '3      Törnverwaltung  + Test Kursverwaltung
            '4      Törnverwaltung + Kursverwaltung

            If Menü.FreischaltZiffer = 1 Or Menü.FreischaltZiffer = 3 Or Menü.FreischaltZiffer = 4 Then
                ok = True
                Label23.Text = ""
            Else
                ok = False
                Label23.Text = " Ohne Freischaltung eingeschränkte Funktion. "
                Button4.Enabled = False
            End If

            If Menü.FreischaltZiffer = 4 Or Menü.FreischaltZiffer = 3 Then
                kAdapter.SelectCommand = New OleDb.OleDbCommand
                kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
                kAdapter.SelectCommand.CommandText = "Select * from Kurse"
                bsKurse.CancelEdit()
                DsAusbildung.Kurse.Clear()
                kAdapter.Fill(DsAusbildung.Kurse)
                bsKurse.Position = 0
                RadioButton4.Visible = True
                RadioButton5.Visible = True
                ComboBox3.Visible = True
                ComboBox3.Enabled = False
                ComboBox4.Visible = True
                ComboBox4.Enabled = False
                TextBox14.Enabled = False
                iii = bsKurse.Count - 1
                For i = 0 To iii
                    aaa = DsAusbildung.Kurse.Rows(i)("Kursbezeichnung").ToString + " & " + DsAusbildung.Kurse.Rows(i)("Fahrtbereich").ToString
                    ComboBox3.Items.Add(aaa)
                Next

                vaAdapter.SelectCommand = New OleDb.OleDbCommand
                vaAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
                vaAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen"
                bsKurse.CancelEdit()
                DsAusbildung.Veranstaltungen.Clear()
                vaAdapter.Fill(DsAusbildung.Veranstaltungen)
                bsVeranstaltungen.Position = 0
                iii = bsVeranstaltungen.Count - 1
                For i = 0 To iii
                    If DsAusbildung.Veranstaltungen.Rows(i)("Veranstaltung").ToString > "" Then
                        aaa = DsAusbildung.Veranstaltungen.Rows(i)("Veranstaltung").ToString + " am " + SafeData.FormatDateDe(DsAusbildung.Veranstaltungen.Rows(i)("Datum"))
                        ComboBox4.Items.Add(aaa)
                    End If
                Next
            Else
                RadioButton4.Visible = False
                ComboBox3.Visible = False
                RadioButton5.Visible = False
                ComboBox4.Visible = False
            End If
            xtAdapter.SelectCommand = New OleDb.OleDbCommand
            xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            xtAdapter.SelectCommand.CommandText = "delete * from Temp "
            bsTemp.CancelEdit()
            dsToernverwaltung.Temp.Clear()
            xtAdapter.Fill(dsToernverwaltung.Temp)
            '        If bsTemp.Count > 0 Then
            ' iii = bsTemp.Count - 1
            ' For Me.ij = 0 To iii
            ' bsTemp.RemoveCurrent()
            ' taTemp.Update(dsToernverwaltung)
            ' Next
            ' End If
            ' auch möglich mit datagridview.rows.clear()
            bsTemp.AddNew()

            Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
            Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
            Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rp As System.Data.DataRowView = bsListdaten.Current
            pAdapter.SelectCommand = New OleDb.OleDbCommand
            pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            pAdapter.SelectCommand.CommandText = "Select * from Listdaten where feld28 like 'Privat' order by Bezeichnung "
            bsListdaten.CancelEdit()
            dsToernverwaltung.Listdaten.Clear()
            pAdapter.Fill(dsToernverwaltung.Listdaten)
            bsListdaten.Position = 0
            iii = bsListdaten.Count - 1
            For i = 0 To iii
                aaa = dsToernverwaltung.Listdaten.Rows(i)("Bezeichnung").ToString
                ComboBox2.Items.Add(aaa)
            Next
            pAdapter.SelectCommand.CommandText = "Select * from Listdaten where Bezeichnung like 'Crew - Status' "
            bsListdaten.CancelEdit()
            dsToernverwaltung.Listdaten.Clear()
            pAdapter.Fill(dsToernverwaltung.Listdaten)
            bsListdaten.Position = 0
            If bsListdaten.Count = 1 Then
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
                comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            End If

            With DataGridView1.ColumnHeadersDefaultCellStyle
                .Font = New Font(.Font.FontFamily, .Font.Size, _
                .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            End With
            With DataGridView1
                .Columns(0).Width = 180
                .Columns(1).Width = 200
                .Columns(2).Width = 120
            End With
            With DataGridView4
                .Columns(0).Width = 180
                .Columns(1).Width = 200
                .Columns(2).Width = 120
            End With
            DataGridView1.Location = New Point(3, 18)
            DataGridView4.Visible = False
            DataGridView1.Visible = False
            Dim ktc As System.Data.DataRowView = bsKontakte.Current
            ktAdapter.SelectCommand = New OleDb.OleDbCommand
            ktAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
            ktAdapter.SelectCommand.CommandText = "Select * from kontakte order by vzname"
            bsKontakte.CancelEdit()
            DsAusbildung.Kontakte.Clear()
            ktAdapter.Fill(DsAusbildung.Kontakte)
            bsKontakte.Position = 0

            Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
            cAdapter.SelectCommand = New OleDb.OleDbCommand
            cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where sterbedatum like '" & lebend & "'order by vzname"
            bsCrewAdressen.CancelEdit()
            dsToernverwaltung.CrewAdressen.Clear()
            cAdapter.Fill(dsToernverwaltung.CrewAdressen)
            bsCrewAdressen.Position = 0

            t1 = GetSetting("T1", "mail", "T")
            If t1 > "" Then
                TextBox1.Text = t1
            Else
                TextBox1.Text = Space(1)
            End If

            t2 = GetSetting("T2", "mail", "T")
            If t2 > "" Then
                TextBox2.Text = t2
            Else
                TextBox2.Text = Space(1)
            End If

            t3 = GetSetting("T3", "mail", "T")
            If t3 > "" Then
                TextBox3.Text = t3
            Else
                TextBox3.Text = Space(1)
            End If

            t4 = GetSetting("T4", "mail", "T")
            If t4 > "" Then
                TextBox4.Text = t4
            Else
                TextBox4.Text = Space(1)
            End If

            t8 = GetSetting("T8", "mail", "T")
            If t8 > "" Then
                TextBox13.Text = t8
            Else
                TextBox13.Text = Space(1)
            End If
        t9 = GetSetting("T9", "mail", "T")
        If t9 > "" Then
            TextBox15.Text = t9
        Else
            TextBox15.Text = Space(1)
            t0 = False
            SaveSetting("T0", "mail", "T", t0)
        End If
        t0 = GetSetting("T0", "mail", "T")
        If t0 = True Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        Label18.Text = " "
        Label22.Text = " "
        TextBox3.PasswordChar = "*"
    End Sub
    Private Sub comboFuellen(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox1.Items.Add(text)
            End If
        End If
    End Sub
    Private Sub senden()
        fehler = 1
        If TextBox5.Text.Length < 3 Then
            GoTo endsub
        End If
        TestEmail.Visible = False
        zmail += 1
        Label17.Text = zmail.ToString + " e-mail versendet"
        fehler += 1
        RichTextBox2.Text = RichTextBox1.Text.Replace("vbanrede", anr)
        fehler += 1
        RichTextBox3.Text = RichTextBox2.Text.Replace("vbname", nm)
        fehler += 1
        RichTextBox3.Text = RichTextBox3.Text.Replace("vbvorname", vnm)
        fehler += 1
        RichTextBox3.Text = RichTextBox3.Text.Replace("vbr1", r1)
        fehler += 1
        Dim eMail As MailMessage = New MailMessage
        Dim client As New SmtpClient
        Dim anmeldung As New Net.NetworkCredential
        fehler += 1
        anmeldung.UserName = TextBox2.Text
        fehler += 1
        anmeldung.Password = TextBox3.Text
        fehler += 1
        If TextBox1.Text = " " Or TextBox13.Text = " " Then
            MsgBox("Die Einstellungen der e-mail Adresse fehlen. Es ist kein Versand möglich.")
            GoTo endsub
        End If
        client.Host = TextBox1.Text                                'TextBox1 = Eingabe des SMTP - Servers
        client.Port = TextBox13.Text                                               'Port deines SMTP Servers
        client.UseDefaultCredentials = False
        client.Credentials = anmeldung
        fehler += 1

        eMail.From = New MailAddress(TextBox4.Text)                 'Absender festlegen. Generell deine Emailadresse
        fehler += 1
        eMail.To.Add(TextBox5.Text)                                  'Empfänger
        fehler += 1
        eMail.Subject = TextBox6.Text                                    ' Betreff
        fehler += 1
        eMail.IsBodyHtml = False
        fehler += 1
        '       eMail.BodyEncoding = System.Text.Encoding.Default
        fehler += 1
        eMail.Body = RichTextBox3.Text & "    " & vbCrLf & "   " & vbCrLf & "   " & vbCrLf & RichTextBox4.Text
        fehler += 1
        eMail.Priority = MailPriority.High
        fehler += 1
        If CheckBox2.Checked Then
            '                                             Lesebestätigung der e-mail
            eMail.Headers("Disposition-Notification-To") = (TextBox15.Text)
        End If
        If anhang1 > "" Then
            eMail.Attachments.Add(New System.Net.Mail.Attachment(anhang1))
        End If
        fehler += 1
        If anhang2 > "" Then
            eMail.Attachments.Add(New System.Net.Mail.Attachment(anhang2))
        End If
        fehler += 1
        If anhang3 > "" Then
            eMail.Attachments.Add(New System.Net.Mail.Attachment(anhang3))
        End If

        Try
            client.Send(eMail)
        Catch ex As Exception
            MsgBox(Err.Number & ex.Message & ex.StackTrace.ToString) 'Falls ein Fehler auftritt wird eine MsgBox angezeigt
            '        MsgBox("Fehler " & Convert.ToString(TextBox5.Text) & "; senden nicht möglich, Fehler in den Einstellungen. Fehler Nr.: " & Convert.ToString(fehler) & "")
            MsgBox("Senden nicht möglich, Fehler in den Einstellungen")
        End Try
        fehler = 0
endsub:
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        t1 = TextBox1.Text
        t2 = TextBox2.Text
        t3 = TextBox3.Text
        t4 = TextBox4.Text
        t8 = TextBox13.Text
        t9 = TextBox15.Text
        If CheckBox2.Checked Then
            t0 = True
        Else
            t0 = False
        End If
        SaveSetting("T1", "mail", "T", t1)
        SaveSetting("T2", "mail", "T", t2)
        SaveSetting("T3", "mail", "T", t3)
        SaveSetting("T4", "mail", "T", t4)
        SaveSetting("T8", "mail", "T", t8)
        SaveSetting("T9", "mail", "T", t9)
        SaveSetting("T0", "mail", "T", t0)
        If InStr(TextBox4.Text, "@") Then
            GroupBox2.Visible = True
            GroupBox1.Visible = False
        Else
            MsgBox("Absender muss eine e-mail Adresse sein")
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox2.Items.Count > 0 Then
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
            TextBox5.Enabled = False
            Label5.Enabled = False
        Else
            MsgBox("Zuerst Adressen aus Vorauswahl in den Versand übertragen.")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox3.Visible = False
        GroupBox2.Visible = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        auswahl()
    End Sub

    Private Sub auswahl()
        If ComboBox1.Text > " " Then
            RadioButton2.Checked = True
            ComboBox1.Focus()
        End If
        ComboBox1.Enabled = True
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where status like '" & ComboBox1.Text & "' and sterbedatum like '" & lebend & "' order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        adrzaehler = bsCrewAdressen.Count
        Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        listboxfuellen()
    End Sub
    Private Sub auswahl8()
        If ComboBox1.Text > " " Then
            RadioButton2.Checked = True
            ComboBox1.Focus()
        End If
        ComboBox1.Enabled = True
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where clubmitglied  and sterbedatum like '" & lebend & "' order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        adrzaehler = bsCrewAdressen.Count
        Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        listboxfuellen()
    End Sub
    Private Sub auswahl9()
        If ComboBox1.Text > " " Then
            RadioButton2.Checked = True
            ComboBox1.Focus()
        End If
        ComboBox1.Enabled = True
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where not clubmitglied  and sterbedatum like '" & lebend & "' order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        adrzaehler = bsCrewAdressen.Count
        Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        listboxfuellen()
    End Sub

    Private Sub listboxfuellen()
        Dim iii As Integer
        If bsCrewAdressen.Count > 0 Then
            ListBox1.Items.Clear()
            iii = bsCrewAdressen.Count - 1
            For Me.ij = 0 To iii
                If aaa <> dsToernverwaltung.CrewAdressen.Rows(ij)("vzname").ToString Then
                    ListBox1.Items.Add(dsToernverwaltung.CrewAdressen.Rows(ij)("vzname").ToString)
                End If
            Next
        End If

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '" & ListBox1.Text & "'  and sterbedatum like '" & lebend & "'  order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        If bsCrewAdressen.Count = 1 Then
            If dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString > " " Then
                ListBox2.Items.Add(ListBox1.Text)
                aaa = ListBox1.Text
                ListBox1.Items.Remove(aaa)
                adrzaehler = ListBox2.Items.Count
                Label10.Text = adrzaehler + " Adressen für den e-mail Versand"
            Else
                MsgBox("Bei " & Convert.ToString(dsToernverwaltung.CrewAdressen.Rows(0)("vzname")) & " fehlt die E-mail Adresse.")
            End If
        Else
            MsgBox("Bei " & Convert.ToString(ListBox1.Text) & " Adresse nicht auffindbar.")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '" & ListBox1.Text & "' and sterbedatum like '" & lebend & "'  order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
    End Sub

    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        aaa = ListBox2.Text
        ListBox2.Items.Remove(aaa)
        ListBox1.Items.Add(aaa)
        adrzaehler = ListBox2.Items.Count
        Label10.Text = adrzaehler + " Adressen für den e-mail Versand"
    End Sub

    Private Sub Druckbereiten()
        Dim tagesdatum As String
        '       Dim irow As Integer
        bsTemp.AddNew()
        '        If aaa = 0 Then
        dsToernverwaltung.Temp.Rows(ij)("Feld22") = RichTextBox1.Text & vbCrLf & RichTextBox4.Text
        '       End If
        dsToernverwaltung.Temp.Rows(ij)("Feld1") = TextBox5.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld2") = nm
        dsToernverwaltung.Temp.Rows(ij)("Feld3") = vnm
        dsToernverwaltung.Temp.Rows(ij)("Feld4") = TextBox6.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld0") = fehler
        taTemp.Update(dsToernverwaltung.Temp)

        bsKontakte.AddNew()
        '       bsKontakte.AddNew()
        RichTextBox5.Text = TextBox6.Text & vbCrLf & RichTextBox1.Text & vbCrLf & RichTextBox4.Text
        RichTextBox5.Text = RichTextBox5.Text.Replace("vbanrede", anr)
        RichTextBox5.Text = RichTextBox5.Text.Replace("vbname", nm)
        RichTextBox5.Text = RichTextBox5.Text.Replace("vbvorname", vnm)
        RichTextBox5.Text = RichTextBox5.Text.Replace("vbr1", r1)
        TextBox7.Text = vnm + " " + nm
        TextBox8.Text = TextBox5.Text
        TextBox11.Text = handy
        TextBox12.Text = "E-Mail"
        TextBox9.Text = System.DateTime.Now.ToString.Substring(0, 16)
        tagesdatum = System.DateTime.Now.ToString
        TextBox10.Text = tagesdatum.Substring(6, 4) + tagesdatum.Substring(3, 2) + tagesdatum.Substring(0, 2) + tagesdatum.Substring(11, 2) + tagesdatum.Substring(14, 2)
        taKontakte.Update(DsAusbildung.Kontakte)
        ij += 1
    End Sub
    Private Sub drucken()
        bsKontakte.AddNew()
        taKontakte.Update(DsAusbildung.Kontakte)
       Dim XLE As New PrintOutEmail
        Dim dv As DataView
        Dim t As DataTable
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsTemp.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsTemp.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from temp order by feld1"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld22", "Feld0")
        XLE.PrintEmail(t)
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim sign As String
        sign = ComboBox2.Text
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsListdaten.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Listdaten where Bezeichnung =  '" & sign & "'"
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        If bsListdaten.Count = 1 Then
            RichTextBox4.Clear()
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            richFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
        End If
    End Sub
    Private Sub richFuellen(ByVal text)
        If IsDBNull(text) = False Then
            If text > "  " Then
                RichTextBox4.Text = RichTextBox4.Text + text & vbCrLf
            End If
        End If
    End Sub

    Private Sub Anhang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anhang.Click
        GroupBox7.Visible = True
        OpenFileDialog1.InitialDirectory = "C:\"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If anhang1 > "" Then
                If anhang2 > "" Then
                    If anhang3 > "" Then
                        MsgBox("Max. 3 Anhänge sind möglich")
                    Else
                        anhang3 = OpenFileDialog1.FileName
                        Label21.Text = anhang3
                        Label21.Visible = True
                        Button8.Visible = True
                    End If
                Else
                    anhang2 = OpenFileDialog1.FileName
                    Label20.Text = anhang2
                    Label20.Visible = True
                    Button9.Visible = True
                End If
            Else
                anhang1 = OpenFileDialog1.FileName
                Label19.Text = anhang1
                Label19.Visible = True
                Button7.Visible = True
            End If
       End If
        GroupBox7.Visible = False
    End Sub
    Private Sub DataGridView4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView4.MouseClick
        '       Label22.Text = ToernbezeichnungDataGridViewTextBoxColumn
        Dim rc As System.Data.DataRowView = bsTC.Current
        tcAdapter.SelectCommand = New OleDb.OleDbCommand
        tcAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tcAdapter.SelectCommand.CommandText = "Select * from tc where toern = '" & Label22.Text & "' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tcAdapter.Fill(dsToernverwaltung.TC)
        bsTC.Position = 0
        adrzaehler = bsTC.Count
        Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        Dim iii As Integer
        If bsTC.Count > 0 Then
            ListBox1.Items.Clear()
            iii = bsTC.Count - 1
            For Me.ij = 0 To iii
                If aaa <> dsToernverwaltung.TC.Rows(ij)("vzname").ToString Then
                    ListBox1.Items.Add(dsToernverwaltung.TC.Rows(ij)("vzname").ToString)
                End If
            Next
        End If

        Dim rn As System.Data.DataRowView = bsToernname.Current
        tnAdapter.SelectCommand = New OleDb.OleDbCommand
        tnAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tnAdapter.SelectCommand.CommandText = "Select * from Toernname  where toernbezeichnung = '" & Label22.Text & "'"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        tnAdapter.Fill(dsToernverwaltung.Toernname)
        ListBox1.Items.Add(dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        Dim rilaenge As Single
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        ij = 0
        Me.Cursor = Cursors.WaitCursor
        rilaenge = RichTextBox1.TextLength - 1
        emailText = RichTextBox1.Text.Substring(0, rilaenge)
        SaveSetting("emailText", "T1", "Text", emailText)
        betreff = TextBox6.Text
        SaveSetting("emailText", "T1", "Betreff", betreff)
        SaveSetting("emailText", "T1", "Anhang1", anhang1)
        SaveSetting("emailText", "T1", "Anhang2", anhang2)
        SaveSetting("emailText", "T1", "Anhang3", anhang3)

        For i = 0 To ListBox2.Items.Count - 1
            Label18.Text = "... in Arbeit, bitte warten " + i.ToString
            Label18.Refresh()
            aaa = ListBox2.Items(i)
            cAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '" & aaa & "'  and sterbedatum like '" & lebend & "' order by vzname"
            bsCrewAdressen.CancelEdit()
            dsToernverwaltung.CrewAdressen.Clear()
            cAdapter.Fill(dsToernverwaltung.CrewAdressen)
            bsCrewAdressen.Position = 0
            TextBox5.Text = dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString
            nm = dsToernverwaltung.CrewAdressen.Rows(0)("zuname").ToString
            vnm = dsToernverwaltung.CrewAdressen.Rows(0)("vorname").ToString
            r1 = dsToernverwaltung.CrewAdressen.Rows(0)("r1").ToString
            handy = dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString
            If dsToernverwaltung.CrewAdressen.Rows(0)("anrede").ToString = "Herr" Then
                anr = "r"
            Else
                anr = ""
            End If
            senden()
            aaa = i
            Druckbereiten()
        Next
        Me.Cursor = Cursors.Default
        Label18.Text = " "
        drucken()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = True
            auswahl()
        Else
            ComboBox1.Enabled = False
        End If
    End Sub
    Private Sub RadioButton1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.GotFocus
        Dim adrzaehler As String
        If ComboBox1.Text > " " Then
            RadioButton2.Checked = True
            ComboBox1.Focus()
        End If
        ComboBox1.Enabled = False
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen  where sterbedatum like '" & lebend & "' order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        adrzaehler = bsCrewAdressen.Count
        Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        listboxfuellen()
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            DataGridView4.Location = New Point(3, 18)
            DataGridView1.Visible = False
            DataGridView4.Visible = True
            Dim rn As System.Data.DataRowView = bsToernname.Current
            tnAdapter.SelectCommand = New OleDb.OleDbCommand
            tnAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tnAdapter.SelectCommand.CommandText = "Select * from Toernname  order by Toernbezeichnung"
            bsToernname.CancelEdit()
            dsToernverwaltung.Toernname.Clear()
            tnAdapter.Fill(dsToernverwaltung.Toernname)
            RadioButton6.Visible = False
        Else
            RadioButton6.Visible = True
            Label22.Text = ""
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            ComboBox4.Enabled = True
        Else
            ComboBox4.Enabled = False
        End If
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            DataGridView4.Visible = False
            TextBox14.Text = ""
            TextBox14.Enabled = True
            TextBox14.Focus()
        Else
            TextBox14.Enabled = False
        End If

    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBox3.Enabled = True
        Else
            ComboBox3.Enabled = False
        End If
    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            FBgb.Location = New Point(220, 75)
            FBgb.Visible = True
        Else
            FBgb.Visible = False
        End If
    End Sub
    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            ComboBox1.Enabled = True
            auswahl8()
        Else
            ComboBox1.Enabled = False
        End If

    End Sub
    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            ComboBox1.Enabled = True
            auswahl9()
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub Kursteilnehmer()
        Dim rtt As System.Data.DataRowView = bsTeilnehmer.Current
        Dim krs As String = " "
        Dim fba As String = " "
        aaa = ComboBox3.Text
        For i = 0 To Len(aaa) - 1
            If aaa.Substring(i, 1) = "&" Then
                krs = aaa.Substring(0, i - 1)
                fba = aaa.Substring(i + 2, Len(aaa) - i - 2)
                Exit For
            End If
        Next

        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where Kurs = '" & krs & "' and fb = '" & fba & "' order by vzname"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.Position = 0
        aaa = bsTeilnehmer.Count
        If bsTeilnehmer.Count = 0 Then
            MsgBox(" Diesen Kurs haben noch keine Teilnehmer gebucht.")
        End If
        For Me.ij = 0 To bsTeilnehmer.Count - 1
            ListBox1.Items.Add(DsAusbildung.Teilnehmer.Rows(ij)("vzname").ToString)
        Next
    End Sub
    Private Sub VerTeilnehmer()
        Dim rvt As System.Data.DataRowView = bsVeranstalTeilnehmer.Current
        Dim krs As String = " "
        Dim fba As String = " "
        aaa = ComboBox4.Text
        For i = 0 To Len(aaa) - 4
            If aaa.Substring(i, 4) = " am " Then
                krs = aaa.Substring(0, i)
                fba = Date.Parse(aaa.Substring(i + 3, Len(aaa) - i - 3))
                Exit For
            End If
        Next

        vtAdapter.SelectCommand = New OleDb.OleDbCommand
        vtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        vtAdapter.SelectCommand.CommandText = "Select * from Veranstalteilnehmer where Veranstaltung = '" & krs & "' and veranstaltungsdatum like '%" & fba & "%' order by vzname"
        bsVeranstalTeilnehmer.CancelEdit()
        DsAusbildung.VeranstalTeilnehmer.Clear()
        vtAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
        bsVeranstalTeilnehmer.Position = 0
        aaa = bsVeranstalTeilnehmer.Count
        If bsVeranstalTeilnehmer.Count = 0 Then
            MsgBox(" Diesen Veranstaltung haben noch keine Teilnehmer gebucht.")
        End If
        For Me.ij = 0 To bsVeranstalTeilnehmer.Count - 1
            ListBox1.Items.Add(DsAusbildung.VeranstalTeilnehmer.Rows(ij)("vzname").ToString)
        Next

    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ListBox1.Items.Clear()
        Kursteilnehmer()
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        ListBox1.Items.Clear()
        VerTeilnehmer()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestEmail.Click
        Dim msg As Integer
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        '       cAdapter.SelectCommand.CommandText = "Select * from crewadressen where email = '" & TextBox17.Text & "' "
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where email = '" & TextBox4.Text & "'  and sterbedatum like '" & lebend & "' "
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        nm = dsToernverwaltung.CrewAdressen.Rows(0)("zuname").ToString
        vnm = dsToernverwaltung.CrewAdressen.Rows(0)("vorname").ToString
        r1 = dsToernverwaltung.CrewAdressen.Rows(0)("r1").ToString
        If dsToernverwaltung.CrewAdressen.Rows(0)("anrede").ToString = "Herr" Then
            anr = "r"
        Else
            anr = ""
        End If
        TextBox5.Text = TextBox4.Text
        msg = MsgBox(" E-mail wird an " & Convert.ToString(TextBox4.Text) & " gesendet.", 1, " Senden ")
        If msg = vbOK Then
            senden()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox3.PasswordChar = ""
        Else
            TextBox3.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox14.TextChanged
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox14.Text & "%'  and sterbedatum like '" & lebend & "' order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        adrzaehler = bsCrewAdressen.Count
        Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        listboxfuellen()
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Label19.Text = ""
        anhang1 = ""
        SaveSetting("emailText", "T1", "Anhang1", anhang1)
        Button7.Visible = False
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Label20.Text = ""
        anhang2 = ""
        SaveSetting("emailText", "T1", "Anhang2", anhang2)
        Button9.Visible = False
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Label21.Text = ""
        anhang3 = ""
        SaveSetting("emailText", "T1", "Anhang3", anhang3)
        Button8.Visible = False
    End Sub


    Private Sub CheckBox14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            fb_Auswahl = 1
            FB_suchen()
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked Then
            fb_Auswahl = 2
            FB_suchen()
        End If

    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            fb_Auswahl = 3
            FB_suchen()
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked Then
            fb_Auswahl = 4
            FB_suchen()
        End If
    End Sub
    Private Sub FB_suchen()
        Dim eins As Boolean = True
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen  where sterbedatum like '" & lebend & "' order by vzname "
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        iii = bsCrewAdressen.Count - 1
        For Me.ij = 0 To iii
            Select Case fb_Auswahl
                Case 1
                    If dsToernverwaltung.CrewAdressen.Rows(ij)("fb1").ToString = True Then
                        ListBox1.Items.Add(dsToernverwaltung.CrewAdressen.Rows(ij)("vzname").ToString)
                        adrzaehler += 1
                    End If
                Case 2
                    If dsToernverwaltung.CrewAdressen.Rows(ij)("fb2").ToString = True Then
                        ListBox1.Items.Add(dsToernverwaltung.CrewAdressen.Rows(ij)("vzname").ToString)
                        adrzaehler += 1
                    End If
                Case 3
                    If dsToernverwaltung.CrewAdressen.Rows(ij)("fb3").ToString = True Then
                        ListBox1.Items.Add(dsToernverwaltung.CrewAdressen.Rows(ij)("vzname").ToString)
                        adrzaehler += 1
                    End If
                Case 4
                    If dsToernverwaltung.CrewAdressen.Rows(ij)("fb4").ToString = True Then
                        ListBox1.Items.Add(dsToernverwaltung.CrewAdressen.Rows(ij)("vzname").ToString)
                        adrzaehler += 1
                    End If
            End Select
            Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        Next
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            DataGridView4.Visible = False
            TextBox16.Text = ""
            TextBox16.Enabled = True
            TextBox16.Focus()
        Else
            TextBox16.Enabled = False
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox16.TextChanged
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where bemerkung like '%" & TextBox16.Text & "%'  and sterbedatum like '" & lebend & "' order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        adrzaehler = bsCrewAdressen.Count
        Label9.Text = adrzaehler + " Adressen aus der Vorauswahl"
        listboxfuellen()
    End Sub
End Class