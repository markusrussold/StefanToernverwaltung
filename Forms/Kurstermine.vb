Public Class Kurstermine
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim teAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aenderung As Boolean
    Dim Kursbez As String
    Dim Kursdatum(50, 3) As String
    Dim jk As Integer = 0
    Dim ku As String
    Dim fa As String
    Dim k As String
    Dim Testversion As Boolean = False
    Dim f As String
    Dim aaa As String
    Dim th As String
    Dim anz As String
    Dim d As String

    Private Sub Kurstermine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.takurse.Fill(Me.DsAusbildung.kurse)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Termine". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTermine.Fill(Me.DsAusbildung.Termine)
        formularloeschen()
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from teilnehmer order by VZName"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()

        Dim te As System.Data.DataRowView = bsTermine.Current
        teAdapter.SelectCommand = New OleDb.OleDbCommand
        teAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        teAdapter.SelectCommand.CommandText = "Select * from Termine order by VZName"
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        bsTermine.AddNew()
        If Menü.FreischaltZiffer = "2" Or Menü.FreischaltZiffer = "3" Then
            MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt.")
            Testversion = True
        End If

        Dim kp As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbeginn desc "
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0


        DataGridView3.Columns(0).Width = 150
        DataGridView2.Columns(0).Width = 150
        DataGridView2.Columns(3).Width = 250

        MaskedTextBox1.Mask = "##.##.####"
        MaskedTextBox2.Mask = "##.##.####"
        MaskedTextBox3.Mask = "##.##.####"
        MaskedTextBox4.mask = "#"
        GroupBox1.Visible = False
        PictureBox9.Visible = False
        CheckBox3.Checked = False
    End Sub
    Private Sub formularloeschen()
        ListBox2.Items.Clear()
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        MaskedTextBox1.Text = ""
        GroupBox1.Location = New Point(20, 20)
        GroupBox1.Visible = False
        GroupBox2.Location = New Point(20, 20)
        GroupBox2.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        DataGridView3.Visible = False
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        CheckBox2.Checked = False
        aenderung = False
    End Sub
    Private Sub DataGridView3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView3.MouseClick
        '     suchenkurseE()
        DataGridView3.Visible = False
        TextBox9.Text = TextBox8.Text
        TextBox12.Text = TextBox15.Text
        TextBox11.Text = TextBox16.Text
        GroupBox4.Focus()
        MaskedTextBox3.Focus()
    End Sub
    Private Sub gruppenDaten()
        k = TextBox7.Text
        f = TextBox6.Text
        d = MaskedTextBox2.Text
        th = TextBox5.Text
        anz = TextBox18.Text
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        '                     Termine speichern
        If Not SafeData.IsBlankOrMask(MaskedTextBox2.Text) And TextBox18.Text > "" And TextBox5.Text > "" Then
            If TextBox7.Text > "" Then
                Dim da As Date
                If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, da) Then
                    MsgBox("Datum hat falsches Format")
                    MaskedTextBox2.Focus()
                    Exit Sub
                End If
                Dim dy As Integer = da.Day
                Dim mo As Integer = da.Month
                Dim ye As Integer = da.Year
                '          year(datumvon) >= '" & TextBox22.Text & "' and year(datumvon) <= '" & TextBox24.Text & "'"
                GroupBox1.Visible = True
                GroupBox1.Location = New Point(1444, 444)
                '           bsTermine.AddNew()
                For i = 0 To ListBox1.Items.Count - 1
                    TextBox1.Text = k
                    TextBox2.Text = f
                    TextBox5.Text = th
                    MaskedTextBox2.Text = d
                    TextBox4.Text = ListBox1.Items.Item(i).ToString
                    CheckBox3.CheckState = 1
                    TextBox18.Text = anz
                    If Testversion Then
                        MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt. Speichern ist nicht mehr möglich!")
                    Else
                        bsTermine.AddNew()
                        taTermine.Update(DsAusbildung.Termine)
                    End If
                Next
                formularloeschen()
            Else
                MsgBox("Kursname fehlt")
            End If
        Else
            MsgBox("Eingabefelder sind nicht versogt.")
        End If
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenTermine()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox3.Visible = False
            PictureBox9.Visible = True
            GroupBox1.Visible = True
            GroupBox1.Location = New Point(30, 30)
        End If
    End Sub
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        RadioButton1.Checked = True
        If RadioButton1.Checked = True Then
            GroupBox3.Visible = False
            GroupBox2.Visible = False
            PictureBox9.Visible = True
            GroupBox1.Visible = True
            GroupBox1.Location = New Point(30, 30)
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox3.Visible = False
            PictureBox9.Visible = True
            GroupBox4.Visible = True
            GroupBox4.Location = New Point(30, 30)
        End If
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        RadioButton2.Checked = True
        If RadioButton2.Checked = True Then
            GroupBox3.Visible = False
            PictureBox9.Visible = True
            GroupBox4.Visible = True
            GroupBox4.Location = New Point(30, 30)
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            GroupBox3.Visible = False
            PictureBox9.Visible = True
            GroupBox2.Visible = True
            GroupBox2.Location = New Point(30, 30)
        End If
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        RadioButton3.Checked = True
        GroupBox3.Visible = False
        PictureBox9.Visible = True
        GroupBox2.Visible = True
        GroupBox2.Location = New Point(30, 30)
    End Sub
    Private Sub MaskedTextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.LostFocus
        gruppenDaten()
    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        gruppenDaten()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GroupBox3.Visible = False
            PictureBox9.Visible = True
            GroupBox5.Visible = True
            GroupBox5.Location = New Point(30, 30)
        End If
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        RadioButton4.Checked = True
        GroupBox3.Visible = False
        PictureBox9.Visible = True
        GroupBox5.Visible = True
        GroupBox5.Location = New Point(30, 30)
    End Sub
    Private Sub Button5Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Drucken.Click
        Dim dt As Date
        teAdapter.SelectCommand.CommandText = "Select * from Termine where Kursbezeichnung = '" & TextBox13.Text & "' and fahrtbereich ='" & TextBox14.Text & "' order by Datum  "
        bsTermine.CancelEdit()
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        If bsTermine.Count = 0 Then
            MsgBox("Dieser Kurs hat noch keine Anwesenheiten gespeichert.")
            GoTo DruckEnde
        End If
        dt = DsAusbildung.Termine.Rows(0)("Datum").ToString
        Kursdatum(jk, 0) = dt
        Kursdatum(jk, 1) = DsAusbildung.Termine.Rows(0)("Thema").ToString
        If DsAusbildung.Termine.Rows(0)("AnzahlEinheiten").ToString > "" Then
            Kursdatum(jk, 2) = DsAusbildung.Termine.Rows(0)("AnzahlEinheiten").ToString
        Else
            Kursdatum(jk, 2) = 1
        End If
        For i = 0 To bsTermine.Count - 1
            If dt = DsAusbildung.Termine.Rows(i)("Datum").ToString Then
            Else
                jk += 1
                dt = DsAusbildung.Termine.Rows(i)("Datum").ToString
                If DsAusbildung.Termine.Rows(i)("AnzahlEinheiten").ToString > "" Then
                    Kursdatum(jk, 2) = DsAusbildung.Termine.Rows(i)("AnzahlEinheiten").ToString
                Else
                    Kursdatum(jk, 2) = 1
                End If
                Kursdatum(jk, 1) = DsAusbildung.Termine.Rows(i)("Thema").ToString
                Kursdatum(jk, 0) = dt
            End If
        Next

        teAdapter.SelectCommand.CommandText = "Select * from Termine where Kursbezeichnung = '" & TextBox13.Text & "' and fahrtbereich ='" & TextBox14.Text & "' order by vzname, Datum  "
        bsTermine.CancelEdit()
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        aaa = bsTermine.Count

        Dim XL As New PrintOutAL
        Dim dv As DataView
        Dim t As DataTable
        dv = bsTermine.List
        t = dv.ToTable("Printing", False, "VZname", "Datum", "Anwesend")
        XL.PrintAnwesendListe(t)
DruckEnde:
        Me.Close()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        DataGridView2.Visible = True
        DataGridView2.Location = New Point(50, 150)
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        formularloeschen()
        GroupBox6Kalender.Visible = False
        GroupBox3.Visible = True
        PictureBox9.Visible = False
        Kurstermine_Load(sender, e)
    End Sub
    Private Sub Button7Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7Speichern.Click
        kalender()
    End Sub
    Private Sub Button5Zurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        kalender()
    End Sub
    Private Sub kalender()
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
        MaskedTextBox3.Text = MonthCalendar1.SelectionStart.ToString
        If RadioButton3.Checked Then
            TextBox18.Focus()
        End If
        If RadioButton2.Checked Then
            TextBox19.Focus()
        End If
        If RadioButton1.Checked Then
            TextBox10.Focus()
        End If
        GroupBox6Kalender.Visible = False
    End Sub


    '   Gruppe eingeben


    Private Sub suchenKurseG()
        TextBox7.Text = RTrim(TextBox7.Text)
        '        TextBox1.Text = TextBox13.Text
        If TextBox6.Text > "  " And TextBox7.Text > "  " Then
            '           tAdapter.SelectCommand.CommandText = "Select * from kurse where VZName = '" & TextBox8.Text & "' and kurs = '" & TextBox7.Text & "' and fb ='" & TextBox6.Text & "'   "
            kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung = '" & TextBox7.Text & "' and fahrtbereich ='" & TextBox6.Text & "'  "
        Else
            If TextBox7.Text > "  " Then
                If Len(TextBox7.Text) > 1 Then
                    If Mid(TextBox7.Text, 2, 1) = "*" Then
                        kAdapter.SelectCommand.CommandText = "Select * from kurse   order by  Kursbeginn desc"
                    Else
                        kAdapter.SelectCommand.CommandText = "Select * from kurse  where kursbezeichnung like '%" & TextBox7.Text & "%'  order by  Kursbeginn desc"
                    End If
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from kurse  where Mid(kursbezeichnung,1,1) like '%" & TextBox7.Text & "%'  order by  Kursbeginn desc"
                End If
            End If
        End If
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Keine Kurskurse mit gesuchtem Kurs vorhanden.")
                DataGridView2.Visible = True
            Case 1
                bsKurse.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView2.Visible = False
                TextBox7.Text = TextBox13.Text
                TextBox6.Text = TextBox14.Text
                ku = TextBox7.Text
                fa = TextBox6.Text
                tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox7.Text & "' and fb ='" & TextBox6.Text & "' order by vzname  "
                bsTeilnehmer.CancelEdit()
                DsAusbildung.Teilnehmer.Clear()
                tAdapter.Fill(DsAusbildung.Teilnehmer)
                CheckBox3.Checked = False
                For i = 0 To bsTeilnehmer.Count - 1
                    ListBox2.Items.Add(DsAusbildung.Teilnehmer.Rows(i)("vzname").ToString)
                Next
            Case Else
        End Select
    End Sub
    Private Sub PictureBox10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(100, 100)
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        DataGridView2.Visible = True
        DataGridView2.Location = New Point(40, 280)
        suchenKurseG()
    End Sub
    Private Sub DataGridView2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        DataGridView2.Visible = False
        TextBox7.Text = TextBox13.Text
        TextBox6.Text = TextBox14.Text
        Kursbez = TextBox7.Text + " " + TextBox6.Text
        suchenKurseG()
        GroupBox2.Focus()
        MaskedTextBox2.Focus()
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            ListBox1.Items.Clear()
            For i = 0 To ListBox2.Items.Count - 1
                ListBox1.Items.Add(ListBox2.Items(i))
            Next
        End If
    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        aaa = ListBox1.Text
        ListBox1.Items.Remove(aaa)
    End Sub
    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridView2.Visible = True
            DataGridView2.Location = New Point(40, 280)
            suchenKurseG()
        End If
        If e.KeyCode = Keys.F5 Then
            DataGridView2.Visible = True
            DataGridView2.Location = New Point(40, 280)
            suchenKurseG()
        End If
    End Sub

    '   Einzel eingeben

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(100, 100)
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        DataGridView2.Visible = False
        DataGridView3.Visible = True
        DataGridView3.Location = New Point(40, 220)
        TextBox8.Text = TextBox9.Text
        suchenteilnehmerE()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CheckBox1.Checked = True
        bsTermine.AddNew()
        taTermine.Update(DsAusbildung.Termine)
    End Sub
    Private Sub suchenteilnehmerE()
        TextBox7.Text = RTrim(TextBox7.Text)
        '        TextBox1.Text = TextBox13.Text
        If TextBox6.Text > "  " Then
            '           tAdapter.SelectCommand.CommandText = "Select * from kurse where VZName = '" & TextBox8.Text & "' and kurs = '" & TextBox7.Text & "' and fb ='" & TextBox6.Text & "'   "
            tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox7.Text & "' and fb ='" & TextBox6.Text & "'   "
        Else
            If TextBox7.Text > "  " Then
                If Len(TextBox7.Text) > 1 Then
                    If Mid(TextBox7.Text, 2, 1) = "*" Then
                        tAdapter.SelectCommand.CommandText = "Select * from teilnehmer   order by VZName"
                    Else
                        tAdapter.SelectCommand.CommandText = "Select * from teilnehmer  where kurs like '%" & TextBox7.Text & "%'  order by VZName"
                    End If
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from teilnehmer  where Mid(kurs,1,1) like '%" & TextBox7.Text & "%'  order by VZName"
                End If
            Else
                If TextBox8.Text > "  " Then
                    tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where VZName like '" & TextBox8.Text & "'  "
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from teilnehmer  order by VZName"
                End If
            End If
        End If
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        Select Case bsTeilnehmer.Count
            Case 0
                MsgBox("Keine Kurskurse mit gesuchtem Kurs vorhanden.")
                '               rete = MsgBox("Kein Kurskurse mit angegebenen Buchstabenkombination vorhanden. Soll ein neuer angelegt werden?", MsgBoxStyle.YesNo)
                '               If rete = vbYes Then
                '                Kurskurse.Show()
                '               Else
                '              tAdapter.SelectCommand.CommandText = "Select * from kurse order by VZName"
                '             tAdapter.Fill(DsAusbildung.kurse)
                '            End If
                DataGridView3.Visible = True
            Case 1
                bsKurse.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox7.Text & "' and fb ='" & TextBox6.Text & "' order by vzname  "
                bsTeilnehmer.CancelEdit()
                DsAusbildung.Teilnehmer.Clear()
                tAdapter.Fill(DsAusbildung.Teilnehmer)
                ku = TextBox7.Text
                fa = TextBox6.Text
                For i = 0 To bsKurse.Count - 1
                    ListBox2.Items.Add(DsAusbildung.Teilnehmer.Rows(i)("vzname").ToString)
                Next
            Case Else
                DataGridView3.Visible = True
        End Select
    End Sub

    '   Einzel bearbeiten

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchenTermine()
    End Sub
    Private Sub suchenTermine()
        Dim rete As MsgBoxResult
        ku = TextBox1.Text
        TextBox1.Text = RTrim(TextBox1.Text)
        '        TextBox1.Text = TextBox13.Text
        If TextBox2.Text > "  " Then
            Dim datum As Date
            If Not SafeData.TryParseMaskedDate(MaskedTextBox1.Text, datum) Then Exit Sub
            Dim tag As Integer = datum.Day
            Dim mon As Integer = datum.Month
            Dim jahr As Integer = datum.Year
            teAdapter.SelectCommand.CommandText = "Select * from Termine where VZName = '" & TextBox4.Text & "' and Kursbezeichnung = '" & TextBox1.Text & "' and fahrtbereich ='" & TextBox2.Text & "' and year(datum) = '" & jahr & "' and month(datum) = '" & mon & "' and  day(datum) = '" & tag & "' " '  "
            '           xAdapter.SelectCommand.CommandText = "Select * from CrewAdressen where yaer(datum) = '"jahr"' and month(datum) = '" & mon & "' and  day(datum) = '" & tag & "' order by day(gebdatum)"                Datum = '" & MaskedTextBox1.Text &

        Else
            If TextBox1.Text > "  " Then
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox2.Text, 2, 1) = "*" Then
                        teAdapter.SelectCommand.CommandText = "Select * from Termine order by datum desc, VZName asc"
                    Else
                        teAdapter.SelectCommand.CommandText = "Select * from Termine where Kursbezeichnung like '%" & TextBox1.Text & "%'  order by VZName"
                    End If
                Else
                    teAdapter.SelectCommand.CommandText = "Select * from Termine where Mid(Kursbezeichnung,1,1) like '%" & TextBox1.Text & "%'  order by VZName"
                End If
            Else
                teAdapter.SelectCommand.CommandText = "Select * from Termine order by datum desc, VZName asc"
            End If
        End If
        bsTermine.CancelEdit()
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        Select Case bsTermine.Count
            Case 0
                rete = MsgBox("Kein Termin gefunden. Soll ein neuer angelegt werden?", MsgBoxStyle.YesNo)
                bsKurse.AddNew()
                If rete = vbYes Then
                    GroupBox1.Visible = False
                    GroupBox2.Visible = True
                    TextBox7.Text = ku
                    TextBox7.Focus()
                Else
                    teAdapter.SelectCommand.CommandText = "Select * from Termine order by datum desc, VZName asc"
                    teAdapter.Fill(DsAusbildung.Termine)
                End If
            Case 1
                bsTermine.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                aenderung = True
            Case Else
                DataGridView1.Visible = True
        End Select
    End Sub
    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        suchenTermine()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If aenderung Then
            bsTermine.EndEdit()
            taTermine.Update(DsAusbildung.Termine)
        Else
            bsTermine.AddNew()
            taTermine.Update(DsAusbildung.Termine)
        End If
        formularloeschen()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        formularloeschen()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        bsTermine.RemoveCurrent()
        taTermine.Update(DsAusbildung)
    End Sub
    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        GroupBox6Kalender.BringToFront()
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(100, 100)
    End Sub

    Private Sub TextBox19_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox19.LostFocus
        If IsNumeric(TextBox19.Text) Then
        Else
            MsgBox("Kurseinheit ist nicht numerisch.")
        End If
    End Sub

    Private Sub TextBox17_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox17.LostFocus
        If IsNumeric(TextBox17.Text) Then
        Else
            MsgBox("Kurseinheit ist nicht numerisch.")
        End If
    End Sub

    Private Sub TextBox18_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox18.LostFocus
        If IsNumeric(TextBox18.Text) Then
        Else
            MsgBox("Kurseinheit ist nicht numerisch.")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class