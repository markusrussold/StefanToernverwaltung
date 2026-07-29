Public Class KursMTeilnehmer
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             'Teilnehmer
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Kontakte
    Dim mAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter            '  Materialkurs
    Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter           'Adressen
    Dim bAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter           ' Kurse
    Dim ckAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter          ' Teilnehmer Veranstaltung
    Dim dkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.taVeranstalTeilnehmer.Fill(Me.DsAusbildung.VeranstalTeilnehmer)
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        Me.taKontakte.Fill(Me.DsAusbildung.Kontakte)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Label10.Visible = False
        TextBox8.Visible = False
        Label7.Visible = False
        Button4.Enabled = False
        SucheKurse()
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        aAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.AddNew()

        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.Position = bsTeilnehmer.Count
        bsTeilnehmer.AddNew()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        SucheName()
    End Sub
    Private Sub DataGridView3_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseClick
        SucheName()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SucheName()
        End If
    End Sub
    Private Sub SucheName()
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        If Len(TextBox1.Text) > 1 Then
            If Mid(TextBox1.Text, 2, 1) = "*" Then
                aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
            Else
                aAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox1.Text & "%' order by zuname"
            End If
        Else
            aAdapter.SelectCommand.CommandText = "Select * from crewadressen where  Mid(zuname,1,1) like '%" & TextBox1.Text & "%'  order by zuname"
        End If
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        aAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                aAdapter.Fill(dsToernverwaltung.CrewAdressen)
                DataGridView1.Visible = True
            Case 1
                '             bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                TeilnehmerSuchen()
                If CheckBox1.Checked Then
                    Label10.Visible = True
                Else
                    Label10.Visible = False
                End If
            Case Else
        End Select
    End Sub
    Private Sub SucheKurse()
        bAdapter.SelectCommand = New OleDb.OleDbCommand
        bAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        bAdapter.SelectCommand.CommandText = "Select * from Kurse order by Kursbezeichnung desc"
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        bAdapter.Fill(DsAusbildung.Kurse)

    End Sub
    Private Sub TeilnehmerSuchen()
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where VZName like '%" & TextBox1.Text & "%' order by Kurs"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.Position = bsTeilnehmer.Count
        bsTeilnehmer.AddNew()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox6.Text = TextBox3.Text
        TextBox7.Text = TextBox4.Text
        TextBox21.Text = TextBox3.Text
        TextBox5.Text = TextBox4.Text
        TextBox2.Text = TextBox1.Text
        TextBox13.Text = 0
    End Sub

    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        If GroupBox1.Visible Then
            bsTeilnehmer.AddNew()
            taTeilnehmer.Update(DsAusbildung.Teilnehmer)
            TeilnehmerSuchen()
        Else
            NamensAenderung()
        End If
    End Sub
    Private Sub NamensAenderung()
        GroupBox1.Visible = True
        Label2.Visible = True
        Label6.Visible = True
        TextBox21.Visible = True
        TextBox5.Visible = True
        TextBox8.Visible = False
        Label7.Visible = False
        ButtonSpeichern.Text = "Speichern"
        '                                               Teilnehmer
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where VZName like '%" & TextBox8.Text & "%' "
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        For i = 0 To bsTeilnehmer.Count - 1
            bsTeilnehmer.Position = i
            TextBox2.Text = TextBox1.Text
            bsTeilnehmer.EndEdit()
            taTeilnehmer.Update(DsAusbildung.Teilnehmer)
        Next
        '                                                Kontakte
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kontakte where VZName like '%" & TextBox8.Text & "%' "
        bsKontakte.CancelEdit()
        DsAusbildung.Kontakte.Clear()
        kAdapter.Fill(DsAusbildung.Kontakte)
        For i = 0 To bsKontakte.Count - 1
            bsKontakte.Position = i
            TextBox9.Text = TextBox1.Text
            bsKontakte.EndEdit()
            taKontakte.Update(DsAusbildung.Kontakte)
        Next
        '                                                      Materialkurs
        mAdapter.SelectCommand = New OleDb.OleDbCommand
        mAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        mAdapter.SelectCommand.CommandText = "Select * from Materialkurs where VZName like '%" & TextBox8.Text & "%' "
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mAdapter.Fill(DsAusbildung.MaterialKurs)
        For i = 0 To bsMaterialKurs.Count - 1
            bsMaterialKurs.Position = i
            TextBox10.Text = TextBox1.Text
            bsMaterialKurs.EndEdit()
            taMaterialKurs.Update(DsAusbildung.MaterialKurs)
        Next

        '                                                      VeranstalTeilnehmer
        ckAdapter.SelectCommand = New OleDb.OleDbCommand
        ckAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        ckAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where VZName like '%" & TextBox8.Text & "%' "
        bsVeranstalTeilnehmer.CancelEdit()
        DsAusbildung.VeranstalTeilnehmer.Clear()
        ckAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
        For i = 0 To bsVeranstalTeilnehmer.Count - 1
            bsVeranstalTeilnehmer.Position = i
            TextBox11.Text = TextBox1.Text
            bsVeranstalTeilnehmer.EndEdit()
            taVeranstalTeilnehmer.Update(DsAusbildung.VeranstalTeilnehmer)
        Next

    End Sub
    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        '                                                     Name eines Teilnehmers ändern
        MsgBox("Der Name muss zuerst in der Crew-Adressendatei geändert werden.")
        GroupBox1.Visible = False
        Label2.Visible = False
        Label6.Visible = False
        TextBox21.Visible = False
        TextBox5.Visible = False
        TextBox8.Visible = True
        Label7.Visible = True
        ButtonSpeichern.Text = "Name ändern"
    End Sub

    Private Sub ButtonLeeren_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLeeren.Click
        GroupBox1.Visible = True
        Label2.Visible = True
        Label6.Visible = True
        TextBox21.Visible = True
        TextBox5.Visible = True
        TextBox8.Visible = False
        Label7.Visible = False
        ButtonSpeichern.Text = "Speichern"
        TextBox1.Text = ""
        TextBox21.Text = ""
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim msg As Integer
        TextBox12.Text = " " & Convert.ToString(TextBox1.Text) & " wird aus den Kurs " & Convert.ToString(TextBox21.Text) & "  " & Convert.ToString(TextBox5.Text) & ""
        msg = MsgBox(" Teilnehmer: " & Convert.ToString(TextBox12.Text) & " gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            mAdapter.SelectCommand = New OleDb.OleDbCommand
            mAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
            mAdapter.SelectCommand.CommandText = "Select * from MaterialKurs where vzname = '" & TextBox1.Text & "' and kurs = '" & TextBox21.Text & "' and fb = '" & TextBox5.Text & "' "
            bsMaterialKurs.CancelEdit()
            DsAusbildung.MaterialKurs.Clear()
            mAdapter.Fill(DsAusbildung.MaterialKurs)
            DsAusbildung.MaterialKurs.Clear()
            mAdapter.Fill(DsAusbildung.MaterialKurs)
            For ii = 0 To bsMaterialKurs.Count - 1
                bsMaterialKurs.RemoveCurrent()
                taMaterialKurs.Update(DsAusbildung)
            Next
            bsTeilnehmer.RemoveCurrent()
            taTeilnehmer.Update(DsAusbildung)
        End If
        Button4.Enabled = False
    End Sub
    Private Sub DataGridView2_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        TextBox21.Text = TextBox6.Text
        TextBox5.Text = TextBox7.Text
        Button4.Enabled = True
    End Sub
End Class