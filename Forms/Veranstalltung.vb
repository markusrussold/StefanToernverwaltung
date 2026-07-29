Public Class Veranstalltung
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim vAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aenderung As Boolean = False
    Dim VeranstaltungAlt As String
    Dim VeranstaltungNeu As String
    Dim position As Integer
    Dim aaa As String
    Dim buch1 As String
    Dim iii As Integer
    Dim ij As Integer
    Dim vnm As String
    Dim nm As String
    Dim anr As String
    Dim CMG As String
    Dim VerDatum As Date
    Dim AnmDatum As Date
    Dim VDatumAlt As Date
    Dim VDatumneu As Date
    Dim datum As String
    Dim BeitragK As String
    Dim Bemerkung As String
    Dim ok As Boolean
    Dim teilnahme As Boolean = False

    Private Sub Veranstalltung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Standort". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taStandort.Fill(Me.DsAusbildung.Standort)
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taVeranstaltungen.Fill(Me.DsAusbildung.Veranstaltungen)
        Me.taVeranstalTeilnehmer.Fill(Me.DsAusbildung.VeranstalTeilnehmer)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung

        If Menü.FreischaltZiffer = 1 Or Menü.FreischaltZiffer = 3 Or Menü.FreischaltZiffer = 4 Then
            ok = True
        Else
            ok = False
        End If


        tAdapter.SelectCommand = New OleDb.OleDbCommand
        Dim t As System.Data.DataRowView = bsVeranstalTeilnehmer.Current
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer order by VZName"
        DsAusbildung.VeranstalTeilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
        bsVeranstalTeilnehmer.AddNew()

        Dim v As System.Data.DataRowView = bsVeranstaltungen.Current
        vAdapter.SelectCommand = New OleDb.OleDbCommand
        vAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen order by datum  "
        '       vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen order by datum desc "
        DsAusbildung.Veranstaltungen.Clear()
        vAdapter.Fill(DsAusbildung.Veranstaltungen)
        DsAusbildung.Veranstaltungen.First()
        bsVeranstaltungen.AddNew()

        Dim a As System.Data.DataRowView = bsCrewAdressen.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        aAdapter.SelectCommand.CommandText = "Select * from crewadressen  order by vzName"
        dsToernverwaltung.CrewAdressen.Clear()
        aAdapter.Fill(dsToernverwaltung.CrewAdressen)

         Dim r As System.Data.DataRowView = bsTemp.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "delete * from temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xAdapter.Fill(dsToernverwaltung.Temp)
  
        MaskedTextBox1.Mask = "##.##.####"
        MaskedTextBox2.Mask = "##.##.####"
        MaskedTextBox3.Mask = "##.##.####"
        MaskedTextBox4.Mask = "##.##.####"
        MaskedTextBox5.Mask = "##.##.####"
        DataGridView1.Columns(0).Width = 250
        DataGridView2.Columns(0).Width = 250
        RichTextBox1.Visible = True
        RichTextBox1.Location = New Point(9, 19)
        RichTextBox2.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox3.Visible = False
        GroupBox2.Location = New Point(10, 245)
        TextBox13.Text = ""
        MaskedTextBox3.Text = ""
        TextBox5.Text = ""
        GroupBox6.Enabled = False
        Formularloeschen()
        GruppeVeranstaltung.Focus()
        TextBox13.Focus()
    End Sub
    Private Sub Formularloeschen()
        aenderung = False
        teilnahme = False
        TextBox13.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox19.Text = ""
        Label11.Text = " "
        ListBox1.Items.Clear()
        RichTextBox2.Visible = False
        RichTextBox2.Text = ""
        RichTextBox1.Text = ""
        GruppeVeranstaltung.Enabled = True
        Label2.Text = "Teilnehmer"
        VeranstaltungAlt = ""
        VeranstaltungNeu = ""
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox3.Visible = False
        GroupBox2.Location = New Point(10, 245)
        GroupBox6.Enabled = False
    End Sub
    Private Sub SuchenVeranstaltung()
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox3.Visible = False
        GroupBox2.Location = New Point(10, 245)
        If TextBox13.Text > "  " Then
            If TextBox13.Text > " " Then
                '              vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen where veranstaltung = '" & TextBox13.Text & "' and datum like '%" & MaskedTextBox3.Text & "%' "
                vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen where veranstaltung like '%" & TextBox13.Text & "%' order by datum desc"
            Else
                If Len(TextBox13.Text) > 1 Then
                    If Mid(TextBox13.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox13.Text, 1, 1).ToUpper
                        vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen order by datum desc"
                    Else
                        vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen where veranstaltung like '%" & TextBox13.Text & "%' order by datum desc"
                    End If
                Else
                    vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen where  Mid(veranstaltung,1,1) like '%" & TextBox13.Text & "%'  order by datum desc"
                End If
            End If
        Else
            vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen order by datum desc"
        End If
        bsVeranstaltungen.CancelEdit()
        DsAusbildung.Veranstaltungen.Clear()
        vAdapter.Fill(DsAusbildung.Veranstaltungen)
        Select Case bsVeranstaltungen.Count
            Case 0
                MsgBox("Keine Veranstaltung mit angegebenen Buchstabenkombination vorhanden")
                vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen order by datum desc"
                bsVeranstaltungen.CancelEdit()
                DsAusbildung.Veranstaltungen.Clear()
                vAdapter.Fill(DsAusbildung.Veranstaltungen)
                '               Formularloeschen()
            Case 1
                DbAccess.SafePosition(bsVeranstaltungen)                 'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                ListBox1.Enabled = True
                '               TextBox13.Text = TextBox1.Text
                GroupBox2.Visible = False
                GroupBox1.Visible = True
                '       MaskedTextBox1.Text = MaskedTextBox6.Text
                VeranstaltungAlt = TextBox13.Text
                VDatumAlt = MaskedTextBox1.Text
                VeranstaltungNeu = TextBox13.Text
                VDatumneu = MaskedTextBox1.Text
                TextBox6.Text = TextBox3.Text
                TextBox14.Text = TextBox4.Text
                '                TextBox15.Text = TextBox10.Text
                '               TextBox16.Text = TextBox11.Text
                '              TextBox17.Text = TextBox12.Text
                '             TextBox19.Text = TextBox10.Text
                aenderung = True
                GroupBox6.Enabled = True
                SuchenTeilnehmer()
            Case Else
                '               GruppeVeranstaltung.Enabled = False
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsVeranstaltungen.Position = position
        End Select
    End Sub
    Private Sub SuchenTeilnehmer()
        '      tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & TextBox13.Text & "' and Veranstaltungsdatum = '" & MaskedTextBox3.Text & "' order by VZName"
        ListBox1.Items.Clear()
        Dim tag As String
        Dim mon As String
        Dim jahr As String
        tag = VDatumAlt.Day
        mon = VDatumAlt.Month
        jahr = VDatumAlt.Year
        tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & VeranstaltungAlt & "' and day(Veranstaltungsdatum) = '" & tag & "' and month(Veranstaltungsdatum) = '" & mon & "' and year(Veranstaltungsdatum) = '" & jahr & "' order by VZName"
        DsAusbildung.VeranstalTeilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
        Label2.Text = bsVeranstalTeilnehmer.Count.ToString + " Teilnehmer"
        For i = 0 To bsVeranstalTeilnehmer.Count - 1
            MaskedTextBox2.Text = (DsAusbildung.VeranstalTeilnehmer.Rows(i)("Veranstaltungsdatum").ToString)
            If MaskedTextBox2.Text = MaskedTextBox1.Text Then
                ListBox1.Items.Add((DsAusbildung.VeranstalTeilnehmer.Rows(i)("vzname").ToString))
            End If
        Next
    End Sub
    Private Sub SuchenAdresse()
        Dim msg As MsgBoxResult
        Dim leer As String = "  ,  ,"
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
        GroupBox3.Location = New Point(10, 245)
        bsVeranstalTeilnehmer.AddNew()
        TextBox5.Text = RTrim(TextBox5.Text)
        If TextBox5.Text > "  " Then
            If TextBox5.Text > " " Then
                aAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox5.Text & "%' and  year(sterbedatum) = '" & 2000 & "'  "
            Else
                If Len(TextBox5.Text) > 1 Then
                    If Mid(TextBox5.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox5.Text, 1, 1).ToUpper
                        aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
                    Else
                        aAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox5.Text & "%' and year(sterbedatum) = '" & 2000 & "' order by vzname"
                    End If
                Else
                    aAdapter.SelectCommand.CommandText = "Select * from crewadressen where  Mid(vzname,1,1) like '%" & TextBox5.Text & "%' and year(sterbedatum) = '" & 2000 & "' order by vzname"
                End If
            End If
        Else
            aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
        End If
        bsCrewAdressen.CancelEdit()
        aenderung = True
        dsToernverwaltung.CrewAdressen.Clear()
        aAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                msg = MsgBox("  Ist " & Convert.ToString(TextBox5.Text) & " ein in der Datenbank nicht gespeicherter Teilnehmer?", 1, "Teilnehmer übernehmen?")
                If msg = vbOK Then
                    DbAccess.SafePosition(bsCrewAdressen)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                    '                  GroupBox3.Visible = False
                    '                 GroupBox1.Visible = True
                    TextBox2.Text = TextBox5.Text
                    TextBox7.Text = MaskedTextBox1.Text
                    teilnahme = True
                Else

                    aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
                    bsCrewAdressen.CancelEdit()
                    dsToernverwaltung.CrewAdressen.Clear()
                    aAdapter.Fill(dsToernverwaltung.CrewAdressen)
                    '               Formularloeschen()
                    DataGridView1.Visible = True
                    DataGridView1.Location = New Point(10, 20)
                End If
            Case 1
                DbAccess.SafePosition(bsCrewAdressen)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                TextBox5.Text = TextBox18.Text
                '              GroupBox3.Visible = False
                '             GroupBox1.Visible = True
                TextBox2.Text = TextBox5.Text
                TextBox7.Text = MaskedTextBox1.Text
                teilnahme = True
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCrewAdressen.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
        End Select

    End Sub
    Private Sub positionieren()
        iii = bsCrewAdressen.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        VeranstaltungNeu = TextBox13.Text
        VDatumneu = MaskedTextBox1.Text
        SuchenAdresse()
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        SuchenVeranstaltung()
    End Sub

    Private Sub TextBox13_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.GotFocus
        '    bsVeranstaltungen.AddNew()
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        ListBox1.Enabled = False
    End Sub
    Private Sub TextBox13_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox13.KeyDown
        If e.KeyCode = Keys.Enter Then
            SuchenVeranstaltung()
        End If
    End Sub
    Private Sub TextBox13_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.LostFocus
        TextBox13.Text = TextBox13.Text.Replace("'", "´")
        VeranstaltungNeu = TextBox13.Text
        If VeranstaltungAlt > "" Then
            VDatumneu = MaskedTextBox1.Text
        End If
    End Sub
    Private Sub MaskedTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.LostFocus
        If MaskedTextBox1.Text = "  ,  ," Then
        Else
            VeranstaltungNeu = TextBox13.Text
            VDatumneu = MaskedTextBox1.Text
        End If
    End Sub

    Private Sub TeilnehmerAendern()
        SuchenTeilnehmer()
        For i = 0 To bsVeranstalTeilnehmer.Count - 1
            DsAusbildung.VeranstalTeilnehmer.Rows(i)("Veranstaltung") = VeranstaltungNeu
            DsAusbildung.VeranstalTeilnehmer.Rows(i)("Veranstaltungsdatum") = VDatumneu
            bsVeranstalTeilnehmer.EndEdit()
            taVeranstalTeilnehmer.Update(DsAusbildung.VeranstalTeilnehmer)
        Next
    End Sub
    Private Sub speichern()
        TextBox3.Text = TextBox6.Text
        TextBox4.Text = TextBox14.Text
        TextBox10.Text = TextBox15.Text
        TextBox11.Text = TextBox16.Text
        TextBox12.Text = TextBox17.Text
        If MaskedTextBox1.Text = "  ,  ," Then
            MsgBox("Verabstaltungsdatum fehlt, noch nicht gespeichert!")
            Exit Sub
        End If
        MaskedTextBox6.Text = MaskedTextBox1.Text
        Dim vrlung As String = TextBox13.Text
        If TextBox13.Text > " " And IsDate(MaskedTextBox1.Text) Then
            If aenderung Then
                bsVeranstaltungen.EndEdit()
                taVeranstaltungen.Update(DsAusbildung.Veranstaltungen)
                iii = 0
                TeilnehmerAendern()
                Label11.Text = "... geändert"
            Else
                bsVeranstaltungen.AddNew()
                taVeranstaltungen.Update(DsAusbildung.Veranstaltungen)
                '               bsVeranstaltungen.AddNew()
                Label11.Text = "... gespeichert"
            End If
            If TextBox5.Text > " " Then
                TeilnehmerSpeichern()
            End If
            TextBox5.Text = ""
            '            Me.Close()
            Exit Sub
        Else
            MsgBox("Bezeichnung und Datum der Veranstaltung sind Pflichteingabe")
            TextBox13.Focus()
        End If
        GroupBox6.Enabled = True
        TextBox13.Text = vrlung
        SuchenVeranstaltung()
    End Sub
    Private Sub TeilnehmerSpeichern()
        '       Dim t As System.Data.DataRowView = bsVeranstalTeilnehmer.Current
        ListBox1.Items.Add(TextBox5.Text)

        Dim tag As String
        Dim mon As String
        Dim jahr As String
        tag = VDatumAlt.Day
        mon = VDatumAlt.Month
        jahr = VDatumAlt.Year
        tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & VeranstaltungAlt & "' and day(Veranstaltungsdatum) = '" & tag & "' and month(Veranstaltungsdatum) = '" & mon & "' and year(Veranstaltungsdatum) = '" & jahr & "' order by VZName"
        '   tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer order by VZName"
        DsAusbildung.VeranstalTeilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
        bsVeranstalTeilnehmer.AddNew()
        bsVeranstalTeilnehmer.AddNew()
        Label2.Text = bsVeranstalTeilnehmer.Count - 1
        Label2.Text = Label2.Text + " Teilnehmer"
        ij = bsVeranstalTeilnehmer.Count - 2
        DsAusbildung.VeranstalTeilnehmer.Rows(ij)("vzname") = TextBox5.Text
        DsAusbildung.VeranstalTeilnehmer.Rows(ij)("Veranstaltung") = VeranstaltungNeu
        TextBox7.Text = Date.Now
        DsAusbildung.VeranstalTeilnehmer.Rows(ij)("Anmeldedatum") = SafeData.FormatDateDe(TextBox7.Text)
        DsAusbildung.VeranstalTeilnehmer.Rows(ij)("Bemerkung") = RichTextBox2.Text
        DsAusbildung.VeranstalTeilnehmer.Rows(ij)("Veranstaltungsdatum") = VDatumneu
        taVeranstalTeilnehmer.Update(DsAusbildung.VeranstalTeilnehmer)
    End Sub
    Private Sub DataGridView2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        '       TextBox13.Text = TextBox1.Text
        '       TextBox6.Text = TextBox3.Text
        '      TextBox14.Text = TextBox4.Text
        '     TextBox15.Text = TextBox10.Text
        '    TextBox16.Text = TextBox11.Text
        '   TextBox17.Text = TextBox12.Text
        '  TextBox19.Text = TextBox10.Text
        '        GruppeVeranstaltung.Enabled = True
        '       If MaskedTextBox1.Text = "  ,  ," Then
        '        aaa = DsAusbildung.Veranstaltungen.Rows(0)("datum").ToString.Substring(0, 10)
        '       Else
        '     End If
        '       MaskedTextBox1.Text = aaa
        aenderung = True
        GroupBox6.Enabled = True
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        SuchenVeranstaltung()
        '       SuchenTeilnehmer()
        VeranstaltungAlt = TextBox13.Text
        VeranstaltungNeu = TextBox13.Text
        aaa = MaskedTextBox1.Text
        VDatumAlt = aaa
        VDatumneu = aaa
    End Sub
    Private Sub ListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        TextBox2.Text = ListBox1.Text
        GroupBox7.Text = "Teilnehmer: " + TextBox2.Text + " in " + TextBox13.Text
        GroupBox1.Visible = True
        GroupBox6.Visible = False
        GroupBox3.Visible = False
        '       GruppeVeranstaltung.Visible = False
        GroupBox7.Visible = True
        GroupBox7.Location = New Point(10, 20)
        RichTextBox2.Location = New Point(11, 21)
        RichTextBox2.Visible = True
        RichTextBox1.Visible = False
        GroupBox1.Text = "Teilnehmer Bemerkung"
        Button1Speichern.Enabled = False
        Button3VLoeschen.Enabled = False
        Button2.Enabled = False
        datum = MaskedTextBox1.Text
        Dim tag As String
        Dim mon As String
        Dim jahr As String
        tag = VDatumAlt.Day
        mon = VDatumAlt.Month
        jahr = VDatumAlt.Year
        tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & VeranstaltungAlt & "' and day(Veranstaltungsdatum) = '" & tag & "' and month(Veranstaltungsdatum) = '" & mon & "' and year(Veranstaltungsdatum) = '" & jahr & "'  and VZName = '" & TextBox2.Text & "' "
        '       tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & TextBox13.Text & "' and cstr(Veranstaltungsdatum) = '" & dat & "' and VZName = '" & TextBox2.Text & "'"
        DsAusbildung.VeranstalTeilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
        If bsVeranstalTeilnehmer.Count = 0 Then
            MsgBox("Der Teilnehmer ist nicht gespeichert.")
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        '                           Zurück
         GroupBox6.Visible = True
        GruppeVeranstaltung.Visible = True
        MaskedTextBox1.Text = datum
        GroupBox7.Location = New Point(420, 520)
        RichTextBox1.Visible = True
        RichTextBox2.Visible = False
        GroupBox1.Text = "Bemerkung"
        Button1Speichern.Enabled = True
        Button3VLoeschen.Enabled = True
        Button2.Enabled = True
        TextBox5.Focus()
     End Sub

    Private Sub Button1Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1Drucken.Click
        Me.Cursor = Cursors.WaitCursor
        bsTemp.AddNew()
        ij = 0
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(ij)("Feld1") = TextBox1.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld2") = TextBox3.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld3") = TextBox4.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld4") = TextBox19.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld5") = TextBox16.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld6") = TextBox17.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld8") = TextBox21.Text
        dsToernverwaltung.Temp.Rows(ij)("Feld22") = MaskedTextBox1.Text
        taTemp.Update(dsToernverwaltung.Temp)
        ij = 1
        For i = 0 To ListBox1.Items.Count - 1
            aaa = ListBox1.Items(i)
            If aaa > " " Then
                aAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '" & aaa & "' order by vzname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                aAdapter.Fill(dsToernverwaltung.CrewAdressen)
                DbAccess.SafePosition(bsCrewAdressen)
                If bsCrewAdressen.Count = 1 Then
                    nm = dsToernverwaltung.CrewAdressen.Rows(0)("zuname").ToString
                    vnm = dsToernverwaltung.CrewAdressen.Rows(0)("vorname").ToString
                    anr = dsToernverwaltung.CrewAdressen.Rows(0)("anrede").ToString
                    If dsToernverwaltung.CrewAdressen.Rows(0)("clubmitglied") Then
                        CMG = "J"
                    Else
                        CMG = "N"
                    End If
                Else
                    nm = aaa
                    vnm = " "
                    anr = " "
                    CMG = "N"
                End If
                tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where vzname like '" & aaa & "' and veranstaltung like '" & TextBox13.Text & "'  "
                DsAusbildung.VeranstalTeilnehmer.Clear()
                tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
                VerDatum = SafeData.FormatDateDe(DsAusbildung.VeranstalTeilnehmer.Rows(0)("Veranstaltungsdatum"))
                AnmDatum = SafeData.FormatDateDe(DsAusbildung.VeranstalTeilnehmer.Rows(0)("Anmeldedatum"))
                BeitragK = DsAusbildung.VeranstalTeilnehmer.Rows(0)("Beitrag").ToString
                Bemerkung = DsAusbildung.VeranstalTeilnehmer.Rows(0)("Bemerkung").ToString
                Druckbereiten()
            End If
        Next
        Me.Cursor = Cursors.Default
        drucken()
        Me.Close()
    End Sub
    Private Sub Button1Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1Speichern.Click
        TextBox1.Text = TextBox13.Text
        speichern()
    End Sub
    Private Sub Button1TLoeschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1TLoeschen.Click
        Dim msg As MsgBoxResult
        TextBox2.Text = ListBox1.Text
        aaa = ListBox1.Text
        Dim tag As String
        Dim mon As String
        Dim jahr As String
        tag = VDatumAlt.Day
        mon = VDatumAlt.Month
        jahr = VDatumAlt.Year
        tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & VeranstaltungAlt & "' and day(Veranstaltungsdatum) = '" & tag & "' and month(Veranstaltungsdatum) = '" & mon & "' and year(Veranstaltungsdatum) = '" & jahr & "'  and VZName = '" & TextBox2.Text & "' "
        ' tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & TextBox13.Text & "' and cstr(Veranstaltungsdatum) = '" & dat & "' and VZName = '" & TextBox2.Text & "'"
        DsAusbildung.VeranstalTeilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
        msg = MsgBox(" Teilnehmer: " & Convert.ToString(TextBox2.Text) & " wird gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            bsVeranstalTeilnehmer.RemoveCurrent()
            taVeranstalTeilnehmer.Update(DsAusbildung)
            ListBox1.Items.Remove(aaa)
            SuchenTeilnehmer()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Formularloeschen()
    End Sub

    Private Sub Button3VLoeschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3VLoeschen.Click
        Dim tag As String
        Dim mon As String
        Dim jahr As String
        Dim msg As MsgBoxResult
        msg = MsgBox(" Veranstaltung: " & Convert.ToString(TextBox13.Text) & " und alle Teilnehmer werden gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            For i = 0 To ListBox1.Items.Count - 1
                TextBox2.Text = ListBox1.Items(i)
                aaa = ListBox1.Text
                Tag = VDatumAlt.Day
                mon = VDatumAlt.Month
                jahr = VDatumAlt.Year
                tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & VeranstaltungAlt & "' and day(Veranstaltungsdatum) = '" & tag & "' and month(Veranstaltungsdatum) = '" & mon & "' and year(Veranstaltungsdatum) = '" & jahr & "'  and VZName = '" & TextBox2.Text & "' "
                '            tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where veranstaltung = '" & TextBox13.Text & "' and cstr(Veranstaltungsdatum) = '" & dat & "' and VZName = '" & TextBox2.Text & "'"
                DsAusbildung.VeranstalTeilnehmer.Clear()
                tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
                If TextBox2.Text > " " Then
                    bsVeranstalTeilnehmer.RemoveCurrent()
                    taVeranstalTeilnehmer.Update(DsAusbildung)
                End If
            Next
            ListBox1.Items.Clear()
            bsVeranstaltungen.RemoveCurrent()
            taVeranstaltungen.Update(DsAusbildung)
            Formularloeschen()
            bsVeranstaltungen.AddNew()
        End If
    End Sub

    Private Sub Button4TSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4TSpeichern.Click
        DsAusbildung.VeranstalTeilnehmer.Rows(0)("Bemerkung") = RichTextBox2.Text
        bsVeranstalTeilnehmer.EndEdit()
        taVeranstalTeilnehmer.Update(DsAusbildung.VeranstalTeilnehmer)
        MaskedTextBox1.Text = ""
        TextBox9.Text = ""
        GroupBox7.Text = "Teilnehmer: "
        RichTextBox2.Text = ""
    End Sub
    Private Sub Button5Zurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
    End Sub


    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(100, 100)
    End Sub


    Private Sub Button7Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7Speichern.Click
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        GroupBox6Kalender.Visible = False
        VeranstaltungNeu = TextBox13.Text
        If VeranstaltungAlt > "" Then
            VDatumneu = MaskedTextBox1.Text
        End If
    End Sub
    Private Sub DataGridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        TextBox1.Text = TextBox13.Text
        TextBox5.Text = TextBox18.Text
        If TextBox5.Text > " " Then
            TeilnehmerSpeichern()
        End If
        TextBox5.Text = ""
        '         speichern()
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox5.Text = TextBox5.Text.Replace("'", "´")
    End Sub
    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter And Not teilnahme Then
            SuchenAdresse()
        End If
        If e.KeyCode = Keys.Enter And teilnahme Then
            speichern()
            teilnahme = False
        End If
    End Sub

    Private Sub TextBox5_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox5.MouseDoubleClick
        speichern()
     End Sub
    Private Sub Druckbereiten()
        bsTemp.AddNew()
        If ok Then
            dsToernverwaltung.Temp.Rows(ij)("Feld1") = vnm + " " + nm
        Else
            dsToernverwaltung.Temp.Rows(ij)("Feld1") = anr + " NNNN NNNN"
        End If
        dsToernverwaltung.Temp.Rows(ij)("Feld8") = Bemerkung
        dsToernverwaltung.Temp.Rows(ij)("Feld3") = " "
        dsToernverwaltung.Temp.Rows(ij)("Feld4") = VerDatum
        dsToernverwaltung.Temp.Rows(ij)("Feld5") = AnmDatum
        dsToernverwaltung.Temp.Rows(ij)("Feld6") = BeitragK
        dsToernverwaltung.Temp.Rows(ij)("Feld22") = " "
        dsToernverwaltung.Temp.Rows(ij)("Feld7") = CMG
        taTemp.Update(dsToernverwaltung.Temp)
        ij += 1
    End Sub
    Private Sub drucken()
        Dim XLA As New PrintOutAktion
        Dim dv As DataView
        Dim t As DataTable
        xAdapter.SelectCommand.CommandText = "Select * from temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xAdapter.Fill(dsToernverwaltung.Temp)
        DbAccess.SafePosition(bsTemp)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld22", "Feld8")
        XLA.PrintAktion(t)
    End Sub

    Private Sub TextBox15_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.LostFocus
        DataGridView5.Location = New Point(10, 250)
        DataGridView5.Size = New Point(543, 160)
        SuchenOrt()
    End Sub
    Private Sub SuchenOrt()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsStandort.Current
        DataGridView2.Visible = True
        '      Richtextbox19.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        '       TextBox18.Text = RTrim(TextBox18.Text)
        If TextBox19.Text > "  " Then
            If Len(TextBox19.Text) > 1 Then
                If Mid(TextBox19.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox19.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Standort where Bezeichnung like '%" & TextBox19.Text & "%'  order by Bezeichnung"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Standort where Mid(Bezeichnung,1,1) like '%" & TextBox19.Text & "%'  order by Bezeichnung"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsStandort.CancelEdit()
        DsAusbildung.Standort.Clear()
        xAdapter.Fill(DsAusbildung.Standort)
        Select Case bsStandort.Count
            Case 0
                MsgBox("Kein Standort mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
                xAdapter.Fill(DsAusbildung.Standort)
                '              Formularloeschen()
            Case 1
                DbAccess.SafePosition(bsStandort)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                TextBox19.Text = TextBox15.Text
                TextBox16.Text = DsAusbildung.Standort.Rows(0)("Plz").ToString + " " + DsAusbildung.Standort.Rows(0)("Ort").ToString + ", " + DsAusbildung.Standort.Rows(0)("Strasse").ToString
                TextBox17.Text = DsAusbildung.Standort.Rows(0)("Typ").ToString + " " + DsAusbildung.Standort.Rows(0)("Telefon").ToString
                TextBox10.Text = TextBox19.Text
                TextBox11.Text = TextBox16.Text
                TextBox12.Text = TextBox17.Text
                DataGridView5.Location = New Point(10, 2500)
            Case Else
                position = 0
                If buch1 > " " Then
                    positionierenOrt()
                End If
                buch1 = ""
                bsStandort.Position = position
                DataGridView5.Visible = True
                DataGridView5.Location = New Point(10, 250)
                DataGridView5.Size = New Point(543, 160)
        End Select
    End Sub
    Private Sub positionierenOrt()
        iii = bsStandort.Count - 1
        For i = 0 To iii
            aaa = Mid(DsAusbildung.Standort.Rows(i)("Bezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        SuchenOrt()
    End Sub
    Private Sub DataGridView5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView5.MouseClick
        TextBox19.Text = TextBox15.Text
        SuchenOrt()
    End Sub

    Private Sub TextBox19_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox19.KeyDown
        If e.KeyCode = Keys.Enter Then
            SuchenOrt()
        End If
    End Sub

 
    Private Sub TextBox13_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class