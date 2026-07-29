Public Class Kursteilnehmer
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Dim matebes As Boolean
    Dim kaufrabatt As String = ""
    Dim position As Integer
    Dim buch1 As String
    Dim neuerTeilnehmer As Boolean = True
    Dim neuerTeilnehmeram As Boolean = True
    Dim Testversion As Boolean = False
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter


    Private Sub Kursteilnehmer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        Me.taKursmaterial.Fill(Me.DsAusbildung.Kursmaterial)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        formularloeschen()
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        ' ThenByDescending
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        bsCrewAdressen.AddNew()

        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by VZName"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()
        If Menü.FreischaltZiffer = "2" Or Menü.FreischaltZiffer = "3" Then
            MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt.")
            Testversion = True
        End If

        Dim kp As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0
        bsKurse.AddNew()

        Dim mk As System.Data.DataRowView = bsMaterialKurs.Current
        mkAdapter.SelectCommand = New OleDb.OleDbCommand
        mkAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        mkAdapter.SelectCommand.CommandText = "Select * from Materialkurs order by VZName"
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        Dim iip As Integer
        Dim pi As Integer
        If bsMaterialKurs.Count > 0 Then
            iip = bsMaterialKurs.Count - 1
            For pi = 0 To iip
                If DsAusbildung.MaterialKurs.Rows(0)("Kurs").ToString > " " Then
                Else
                    bsMaterialKurs.RemoveCurrent()
                    taMaterialKurs.Update(DsAusbildung)
                End If
            Next
        End If

        bsMaterialKurs.AddNew()
        TextBox7.Text = 0
        DataGridView5.Columns(0).Frozen = True
        DataGridView5.Columns(0).Width = 150
        DataGridView2.Columns(0).Width = 150
        GroupBox10.Visible = False
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        MaskedTextBox3.Mask = "00.00.0000"
        MaskedTextBox4.Mask = "00.00.0000"
        Label20.Text = ""
        Label23.Text = ""
        TextBox23.Focus()
    End Sub
    Private Sub formularloeschen()
        GroupBox1.Visible = False
        GroupBox2.Location = New Point(25, 300)
        GroupBox2.Visible = True
        GroupBox8.Location = New Point(25, 10)
        GroupBox8.Visible = True
        GroupBox8.Enabled = True
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox6.Visible = False
        Button2.Visible = False
        Button4.Enabled = False
        Label10.Visible = False
        matebes = False
        DsAusbildung.Teilnehmer.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = kaufrabatt
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ComboBox1.Items.Clear()
        Label20.Text = ""
        Label23.Text = ""
        RichTextBox1.Text = ""
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchencrew()
    End Sub
    Private Sub suchencrew()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        GroupBox1.Enabled = False
        position = 0
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If TextBox8.Text > " " Then
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen where zuname = '" & TextBox1.Text & "' and vorname = '" & TextBox8.Text & "'"
            Else
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox1.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox1.Text & "%' order by zuname"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from crewadressen where  Mid(zuname,1,1) like '%" & TextBox1.Text & "%'  order by zuname"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        End If
        bsCrewAdressen.CancelEdit()
        aenderung = True
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                xAdapter.Fill(dsToernverwaltung.CrewAdressen)
                '               Formularloeschen()
                GroupBox3.Visible = True
                GroupBox3.Location = New Point(25, 300)
            Case 1
                bsTeilnehmer.AddNew()
                bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                GroupBox3.Visible = False
                GroupBox2.Location = New Point(25, 300)
                GroupBox2.Visible = True
                GroupBox1.Enabled = True
                If dsToernverwaltung.CrewAdressen.Rows(0)("Clubmitglied").ToString Then
                    Label10.Visible = True
                End If
                TextBox13.Text = TextBox20.Text
                TextBox23.Text = TextBox20.Text
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCrewAdressen.Position = position
                GroupBox3.Visible = True
                GroupBox3.Location = New Point(25, 300)
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
    Private Sub suchenKurs()
        '      Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        '     Dim kr As System.Data.DataRowView = bsKurse.Current
        '    kAdapter.SelectCommand = New OleDb.OleDbCommand
        '   kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        TextBox2.Text = RTrim(TextBox21.Text)
        If TextBox3.Text > "  " Then
            kAdapter.SelectCommand.CommandText = "Select * from Kurse where Kursbezeichnung = '" & TextBox2.Text & "' and Fahrtbereich = '" & TextBox3.Text & "' "
        Else
            If TextBox2.Text > "  " Then
                If Len(TextBox2.Text) > 1 Then
                    If Mid(TextBox2.Text, 2, 1) = "*" Then
                        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung, Fahrtbereich"
                    Else
                        kAdapter.SelectCommand.CommandText = "Select * from Kurse where Kursbezeichnung like '%" & TextBox2.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
                    End If
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from Kurse where Mid(Kursbezeichnung,1,1) like '%" & TextBox2.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
                End If
            Else
                kAdapter.SelectCommand.CommandText = "Select * from Kurse order by Kursbezeichnung, Fahrtbereich"
            End If
        End If
        bsKurse.CancelEdit()
        aenderung = True
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Kein Kurs mit angegebenen Buchstabenkombination vorhanden")
                kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
                DsAusbildung.Kurse.Clear()
                kAdapter.Fill(DsAusbildung.Kurse)
                GroupBox6.Visible = True
                GroupBox6.Location = New Point(25, 300)
            Case 1
                bsKurse.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                GroupBox6.Visible = False
                ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis1").ToString)
                ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis2").ToString)
                ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis3").ToString)
                TextBox21.Text = TextBox2.Text
                TextBox22.Text = TextBox3.Text
            Case Else
                DataGridView1.Columns(0).Frozen = True
                GroupBox6.Visible = True
                GroupBox6.Location = New Point(25, 300)
        End Select

    End Sub
    Private Sub suchenTeilnehmer()
        Dim tln As String
        Dim rete As MsgBoxResult
        TextBox13.Text = RTrim(TextBox13.Text)
        TextBox1.Text = TextBox23.Text
        tln = TextBox1.Text
        GroupBox8.Enabled = False
        If TextBox12.Text > "  " Then
            tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where VZName = '" & TextBox13.Text & "' and kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "'   "
        Else
            If TextBox23.Text > "  " Then
                If Len(TextBox23.Text) > 1 Then
                    If Mid(TextBox2.Text, 2, 1) = "*" Then
                        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer   order by VZName"
                    Else
                        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer  where VZName like '%" & TextBox23.Text & "%'  order by VZName"
                    End If
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer  where Mid(VZName,1,1) like '%" & TextBox23.Text & "%'  order by VZName"
                End If
            Else
                tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer  order by VZName"
            End If
        End If
        bsTeilnehmer.CancelEdit()
        aenderung = True
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        Select Case bsTeilnehmer.Count
            Case 0
                rete = MsgBox("Kein Kursteilnehmer mit angegebenen Buchstabenkombination vorhanden. Soll ein neuer angelegt werden?", MsgBoxStyle.YesNo)
                bsKurse.AddNew()
                If rete = vbYes Then
                    GroupBox1.Visible = True
                    GroupBox8.Visible = False
                    GroupBox1.Location = New Point(25, 10)
                    GroupBox7.Visible = False
                    TextBox1.Focus()
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by VZName"
                    tAdapter.Fill(DsAusbildung.Teilnehmer)
                End If
            Case 1
                bsKurse.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                GroupBox6.Visible = False
                GroupBox7.Visible = False
                GroupBox8.Enabled = True
                TextBox23.Text = TextBox13.Text
                Button4.Enabled = True
            Case Else
                DataGridView1.Columns(0).Frozen = True
                GroupBox6.Visible = True
                GroupBox6.Location = New Point(25, 300)
        End Select


    End Sub
    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        '                                   Crewadressen
        suchencrew()
        GroupBox3.Visible = False
        GroupBox2.Location = New Point(25, 300)
        GroupBox2.Visible = True
        GroupBox1.Enabled = True
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        suchenKurs()
    End Sub
    Private Sub DataGridView4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView4.MouseClick
        '                                             Kurse
        TextBox21.Text = TextBox2.Text
        suchenKurs()
        GroupBox6.Visible = False
        If GroupBox10.Visible = True Then
            GroupBox7.Location = New Point(25, 178)
            GroupBox7.Size = New Point(670, 320)
            GroupBox7.Visible = True
            GroupBox7.Text = "Liste der Kursteilnehmer"
            DataGridView5.Size = New Point(640, 290)
            tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where kurs = '" & TextBox26.Text & "' and fb ='" & TextBox25.Text & "' order by vzname  "
            bsTeilnehmer.CancelEdit()
            DsAusbildung.Teilnehmer.Clear()
            tAdapter.Fill(DsAusbildung.Teilnehmer)
        Else
            GroupBox2.Location = New Point(25, 300)
            GroupBox2.Visible = True
        End If
    End Sub
     Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchencrew()
        End If
        If e.KeyCode = Keys.F5 Then
            '         speichern()
        End If

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenKurs()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        GroupBox7.Visible = True
        GroupBox7.Location = New Point(25, 300)
        suchenTeilnehmer()
    End Sub

    Private Sub ButtonSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpeichern.Click
        Dim k As String
        Dim f As String
        Dim v As String
        Dim p As String
        Dim b As String
        Dim kb As String
        If (TextBox12.Text > " " And TextBox11.Text > " ") Or (TextBox2.Text > " " And TextBox3.Text > " ") Then
            If GroupBox1.Visible = True Then
                bsTeilnehmer.AddNew()
                p = TextBox5.Text
                b = TextBox6.Text
                kb = TextBox4.Text
                TextBox13.Text = dsToernverwaltung.CrewAdressen.Rows(0)("VZname").ToString
                '               TextBox23.Text = TextBox13.Text
                TextBox12.Text = TextBox2.Text
                TextBox11.Text = TextBox3.Text
                TextBox9.Text = ComboBox1.Text
                TextBox5.Text = p
                TextBox6.Text = b
                TextBox4.Text = kb
                k = TextBox12.Text
                f = TextBox11.Text
                v = TextBox13.Text
                If Testversion Then
                    MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt. Speichern ist nicht mehr möglich!")
                Else
                    taTeilnehmer.Update(DsAusbildung.Teilnehmer)
                End If
            Else
                k = TextBox12.Text
                f = TextBox11.Text
                v = TextBox13.Text
                bsTeilnehmer.EndEdit()
                taTeilnehmer.Update(DsAusbildung.Teilnehmer)
            End If
            If ListBox1.Items.Count > 0 Then
                BestellungSpeichern(k, f, v)
            End If
                If matebes Then
                    Dim rete As MsgBoxResult
                    rete = MsgBox("Bestellliste Drucken?", MsgBoxStyle.YesNo)
                    If rete = vbYes Then
                        bestellDruck()
                    End If
                End If
            formularloeschen()
            TextBox23.Text = ""
            Else
                MsgBox("Kurs und/oder Fahrtbereich nicht definiert.")
            End If
    End Sub
    Private Sub BestellungSpeichern(ByVal k, ByVal f, ByVal v)
        For i = 0 To ListBox1.Items.Count - 1
            Dim mk As System.Data.DataRowView = bsMaterialKurs.Current
            mkAdapter.SelectCommand = New OleDb.OleDbCommand
            mkAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
            mkAdapter.SelectCommand.CommandText = "Select * from Materialkurs order by VZName"
            DsAusbildung.MaterialKurs.Clear()
            mkAdapter.Fill(DsAusbildung.MaterialKurs)
            TextBox14.Text = k
            TextBox15.Text = f
            TextBox17.Text = v
            TextBox16.Text = ListBox1.Items.Item(i).ToString
            TextBox18.Text = ListBox2.Items.Item(i).ToString
            bsMaterialKurs.AddNew()
            taMaterialKurs.Update(DsAusbildung.MaterialKurs)
        Next
    End Sub
    Private Sub ButtonLeeren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLeeren.Click
        formularloeschen()
    End Sub

    Private Sub TextBox23_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox23.KeyDown
        If e.KeyCode = Keys.Enter Then
            GroupBox7.Visible = True
            GroupBox7.Location = New Point(25, 300)
            suchenTeilnehmer()
        End If
    End Sub
    Private Sub DataGridView5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView5.MouseClick
        '                                     Teilnehmer
        If GroupBox10.Visible = False Then
            suchenTeilnehmer()
            GroupBox7.Visible = False
            GroupBox8.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox7.Text > "" Then
            kaufrabatt = TextBox7.Text
            GroupBox4.Visible = True
            If TextBox5.Text > "" Then
            Else
                TextBox5.Text = "0"
            End If
            Button2.Visible = True
            matebes = True
        Else
            MsgBox(" Zuerst Preisnachlass definieren. Listenpreis = 0%  ")
        End If
    End Sub
    Private Sub DataGridView2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        '                    KursMaterial
        ListBox1.Items.Add(DataGridView2.CurrentRow.Cells(0).Value)
        TextBox5.Text = TextBox5.Text + DataGridView2.CurrentRow.Cells(1).Value * (100 - TextBox7.Text) / 100
        ListBox2.Items.Add(DataGridView2.CurrentRow.Cells(1).Value * (100 - TextBox7.Text) / 100)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox4.Visible = False
        Button2.Visible = False
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Dim indexl As Integer
        Dim abzug As String
        indexl = ListBox1.SelectedIndex
        aaa = ListBox1.Text
        ListBox1.Items.Remove(aaa)
        abzug = ListBox2.Items.Item(indexl).ToString
        TextBox5.Text = TextBox5.Text - abzug
        ListBox2.Items.RemoveAt(indexl)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        formularloeschen()
        GroupBox7.Visible = False
        TextBox1.Text = TextBox23.Text
        GroupBox8.Visible = False
        GroupBox1.Visible = True
        GroupBox1.Location = New Point(25, 10)

        suchencrew()
    End Sub

    Private Sub bestellDruck()
        Menü.programmquelle = "Kursteilnehmer"
        Dim Xmk As New Printoutmk
        Dim dv As DataView
        Dim t As DataTable
        If GroupBox8.Visible = True Then
            mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where vzname = '" & TextBox13.Text & "' and kurs = '" & TextBox12.Text & "' and fb = '" & TextBox11.Text & "' order by material"
        Else
            mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where vzname = '" & TextBox20.Text & "' and kurs = '" & TextBox2.Text & "' and fb = '" & TextBox3.Text & "' order by material"
        End If
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        aaa = bsMaterialKurs.Count
        dv = bsMaterialKurs.List
        t = dv.ToTable("Printing", False, "Kurs", "FB", "Material", "VZName", "Verkaufspreis", "Bemerkung")
        Xmk.PrintBestellung(t)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim msg As Integer
        msg = MsgBox(" Teilnehmer: " & Convert.ToString(TextBox13.Text) & " wird aus den Kurs gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where vzname = '" & TextBox13.Text & "' and kurs = '" & TextBox12.Text & "' and fb = '" & TextBox11.Text & "' order by VZName"
            DsAusbildung.MaterialKurs.Clear()
            mkAdapter.Fill(DsAusbildung.MaterialKurs)
            For ii = 0 To bsMaterialKurs.Count - 1
                bsMaterialKurs.RemoveCurrent()
                taMaterialKurs.Update(DsAusbildung)
            Next
            bsTeilnehmer.RemoveCurrent()
            taTeilnehmer.Update(DsAusbildung)
            formularloeschen()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox10.Visible = True
        GroupBox6.Visible = True
        GroupBox10.Location = New Point(25, 10)
        GroupBox6.Location = New Point(100, 100)
        Button4.Visible = False
        Button5.Visible = False
        ButtonLeeren.Visible = False
        ButtonSpeichern.Visible = False
        Button6.Location = New Point(538, 512)
        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0
        TextBox2.Text = ""
        TextBox3.Text = ""
        suchenKurs()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where kurs = '" & TextBox26.Text & "' and fb ='" & TextBox25.Text & "' order by vzname  "
        Dim Xtl As New PrintOutTl
        Dim dv As DataView
        Dim t As DataTable
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        If bsTeilnehmer.Count > 0 Then
            dv = bsTeilnehmer.List
            t = dv.ToTable("Printing", False, "VZName", "Kurs", "FB", "Kurspreis", "Kursbezahlt", "Bemerkung", "Materialpreis", "MaterialBezahlt")
            Xtl.PrintTeilnehmerliste(t)
        Else
            MsgBox("Kurs oder/und Fahrtbereich nicht ausgewählt.")
        End If
    End Sub
    Private Sub TextBox10_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.LostFocus
        MaskedTextBox2.Text = Today
    End Sub

    Private Sub TextBox21_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox21.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenKurs()
        End If
    End Sub

    Private Sub TextBox9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.LostFocus
        If TextBox9.Text > 0 Then
            Label20.Text = "Pflichteingabe"
            ButtonSpeichern.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        If ComboBox1.Text > 0 Then
            Label23.Text = "Pflichteingabe"
            ButtonSpeichern.Enabled = False
        End If
    End Sub

    Private Sub MaskedTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.GotFocus
        ButtonSpeichern.Enabled = True
    End Sub
    Private Sub MaskedTextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox4.GotFocus
        ButtonSpeichern.Enabled = True
    End Sub

    '                                    Kalender

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If neuerTeilnehmeram Then
            MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
            MaskedTextBox4.Text = MonthCalendar1.SelectionStart.ToString
            If neuerTeilnehmer Then
                MaskedTextBox1.Focus()
            Else
                MaskedTextBox4.Focus()
            End If
        Else
            MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
            MaskedTextBox3.Text = MonthCalendar1.SelectionStart.ToString
            If neuerTeilnehmer Then
                MaskedTextBox2.Focus()
            Else
                MaskedTextBox3.Focus()
            End If
        End If
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub Button5Zurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub Button7Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7Speichern.Click
        If neuerTeilnehmeram Then
            MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
            MaskedTextBox4.Text = MonthCalendar1.SelectionStart.ToString
        Else
            MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
            MaskedTextBox3.Text = MonthCalendar1.SelectionStart.ToString
        End If
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        neuerTeilnehmer = True
        neuerTeilnehmeram = True
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        neuerTeilnehmer = False
        neuerTeilnehmeram = True
    End Sub
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        neuerTeilnehmer = False
        neuerTeilnehmeram = False
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        neuerTeilnehmer = True
        neuerTeilnehmeram = False
    End Sub
End Class