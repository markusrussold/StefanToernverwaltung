Public Class KursTeilnVerw
    Dim aaa As String
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim bAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kostendatum As Integer
    Private Sub KursTeilnVerw_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where VZName like '%" & TextBox1.Text & "%' order by Kurs"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.Position = bsTeilnehmer.Count
        bsTeilnehmer.AddNew()

        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        MaskedTextBox4.Mask = "00.00.0000"
        MaskedTextBox3.Mask = "00.00.0000"
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        TeilnehmerSuchen()
    End Sub
    Private Sub TeilnehmerSuchen()
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where VZName like '%" & TextBox1.Text & "%' order by Kurs"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.Position = bsTeilnehmer.Count
    End Sub
    Private Sub SucheKurse()
        bAdapter.SelectCommand = New OleDb.OleDbCommand
        bAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        bAdapter.SelectCommand.CommandText = "Select * from Kurse where Kursbezeichnung like '%" & TextBox21.Text & "%' and Fahrtbereich like '%" & TextBox22.Text & "%'"
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        bAdapter.Fill(DsAusbildung.Kurse)
        DbAccess.SafePosition(bsKurse)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis1").ToString)
        ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis2").ToString)
        ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis3").ToString)
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        SucheKurse()
        If TextBox2.Text > 0 Then
            TextBox2.Visible = True
        Else
            TextBox2.Visible = False
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Text = ComboBox1.SelectedItem
    End Sub
    Private Sub Formloeschen()
        bsTeilnehmer.AddNew()
        ComboBox1.Items.Clear()
    End Sub
    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        bsTeilnehmer.EndEdit()
        taTeilnehmer.Update(DsAusbildung.Teilnehmer)
        Formloeschen()
    End Sub

    Private Sub Button7Speichern_Click(sender As System.Object, e As System.EventArgs) Handles Button7Speichern.Click
        kodatum()
    End Sub

    Private Sub Button5Zurueck_Click(sender As System.Object, e As System.EventArgs) Handles Button5Zurueck.Click
        kodatum()
    End Sub
    Private Sub kodatum()
        Select Case kostenDatum
            Case 1
                MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox1.Focus()
            Case 2
                MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox2.Focus()
            Case 3
                MaskedTextBox3.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox3.Focus()
            Case 4
                MaskedTextBox4.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox4.Focus()
        End Select
        GroupBox6Kalender.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        kodatum()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostendatum = 4
    End Sub
    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostendatum = 3
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostendatum = 2
    End Sub
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostendatum = 1
    End Sub

    Private Sub ButtonLeeren_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLeeren.Click
        Formloeschen()
    End Sub
    Private Sub DataGridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TeilnehmerSuchen()
        End If
    End Sub
End Class