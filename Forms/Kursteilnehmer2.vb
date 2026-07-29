Public Class Kursteilnehmer2
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kmAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kaufrabatt As String = "0"
    Dim kostenDatum As Integer
    Dim aaa As String
    Dim summe As Single

    Private Sub Kursteilnehmer2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        Me.taKursmaterial.Fill(Me.DsAusbildung.Kursmaterial)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        formularloeschen()
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by VZName"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()

        Dim km As System.Data.DataRowView = bsKursmaterial.Current
        kmAdapter.SelectCommand = New OleDb.OleDbCommand
        kmAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kmAdapter.SelectCommand.CommandText = "Select * from Kursmaterial order by material"
        DsAusbildung.Kursmaterial.Clear()
        kmAdapter.Fill(DsAusbildung.Kursmaterial)


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
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        MaskedTextBox4.Mask = "00.00.0000"
        MaskedTextBox3.Mask = "00.00.0000"
        Label1.Text = ""
        Label20.Text = ""

    End Sub
    Private Sub formularloeschen()
        '       GroupBox1.Visible = False
        '     Button2Bemerkung.Visible = False
        '       GroupBox4.Visible = False
         Button4loeschen.Enabled = False
        DsAusbildung.Teilnehmer.Clear()
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = kaufrabatt
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = ""
        TextBox12.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        RichTextBox1.Text = ""
        summe = 0
    End Sub
    Private Sub suchenTeilnehmer()

        If TextBox23.Text > "  " Then
            If TextBox12.Text > "  " And TextBox11.Text > "  " Then
                tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where VZName = '" & TextBox23.Text & "' and kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "'   "
            Else
                If Len(TextBox23.Text) > 1 Then
                    If Mid(TextBox23.Text, 2, 1) = "*" Then
                        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer   order by VZName"
                    Else
                        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer  where VZName like '%" & TextBox23.Text & "%'  order by VZName"
                    End If
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer  where Mid(VZName,1,1) like '%" & TextBox23.Text & "%'  order by VZName"
                End If
            End If
        Else
            tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer  order by VZName"
        End If
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        Select Case bsTeilnehmer.Count
            Case 0
                MsgBox("Kein Kursteilnehmer mit angegebenen Buchstabenkombination vorhanden")
                TextBox23.Text = ""
            Case 1
                GroupBox7.Location = New Point(1200, 1710)
                GroupBox5.Location = New Point(12, 171)
                suchenMaterialbestellt()
            Case Else
        End Select
    End Sub
    Private Sub suchenMaterialbestellt()
        mkAdapter.SelectCommand.CommandText = "Select * from MaterialKurs where VZName = '" & TextBox23.Text & "' and kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "' order by material  "
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        For i = 0 To bsMaterialKurs.Count - 1
            ListBox1.Items.Add((DsAusbildung.MaterialKurs.Rows(i)("material").ToString))
            ListBox2.Items.Add((DsAusbildung.MaterialKurs.Rows(i)("Verkaufspreis").ToString))
            summe = summe + DsAusbildung.MaterialKurs.Rows(i)("Verkaufspreis").ToString
        Next
        TextBox5.Text = summe
    End Sub
    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        GroupBox2.Location = New Point(1000, 1000)
        GroupBox5.Location = New Point(1000, 1000)
        GroupBox7.Location = New Point(12, 171)
        suchenTeilnehmer()
    End Sub
    Private Sub DataGridView5_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        suchenTeilnehmer()
        GroupBox2.Location = New Point(12, 284)
        GroupBox5.Location = New Point(12, 171)
        GroupBox7.Location = New Point(1000, 1000)
    End Sub

    Private Sub Button2Bemerkung_Click(sender As System.Object, e As System.EventArgs) Handles Button2Bemerkung.Click
        GroupBox4.Location = New Point(1111, 2841)
        GroupBox2.Location = New Point(12, 284)
        Button1Material.Visible = True
        Button2Bemerkung.Visible = False
    End Sub
    Private Sub Button1Material_Click(sender As System.Object, e As System.EventArgs) Handles Button1Material.Click
        GroupBox4.Location = New Point(12, 284)
        GroupBox2.Location = New Point(1000, 2840)
        Button1Material.Visible = False
        Button2Bemerkung.Visible = True
    End Sub
    Private Sub Button7Speichern_Click(sender As System.Object, e As System.EventArgs) Handles Button7Speichern.Click
        kodatum()
    End Sub
    Private Sub Button5Zurueck_Click(sender As System.Object, e As System.EventArgs) Handles Button5Zurueck.Click
        Select Case kostenDatum
            Case 1
                MaskedTextBox1.Focus()
            Case 2
                MaskedTextBox2.Focus()
            Case 3
                MaskedTextBox3.Focus()
            Case 4
                MaskedTextBox4.Focus()
        End Select
    End Sub
    Private Sub ButtonLeeren_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLeeren.Click
        formularloeschen()
    End Sub
    Private Sub Button4loeschen_Click(sender As System.Object, e As System.EventArgs) Handles Button4loeschen.Click
        Dim msg As Integer
        msg = MsgBox(" Teilnehmer: " & Convert.ToString(TextBox23.Text) & " wird aus den Kurs gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            mkAdapter.SelectCommand.CommandText = "Select * from MaterialKurs where vzname = '" & TextBox23.Text & "' and kurs = '" & TextBox12.Text & "' and fb = '" & TextBox11.Text & "' order by VZName"
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
    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        Dim name As String = TextBox23.Text
        Dim kurs As String = TextBox12.Text
        Dim fb As String = TextBox11.Text
        bsTeilnehmer.EndEdit()
        taTeilnehmer.Update(DsAusbildung.Teilnehmer)
        BestellungSpeichern(name, kurs, fb)
        formularloeschen()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostenDatum = 3
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostenDatum = 4
    End Sub
    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostenDatum = 2
    End Sub
    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostenDatum = 1
    End Sub

    Private Sub TextBox23_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox23.KeyDown
        If e.KeyCode = Keys.Enter Then
            GroupBox2.Location = New Point(1000, 1000)
            GroupBox5.Location = New Point(1000, 1000)
            GroupBox7.Location = New Point(12, 171)
            suchenTeilnehmer()
        End If
    End Sub

   Private Sub kodatum()
        Select kostenDatum
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

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        ListBox1.Items.Add(DataGridView2.CurrentRow.Cells(0).Value)
        summe = summe + DataGridView2.CurrentRow.Cells(1).Value * (100 - TextBox7.Text) / 100
        TextBox5.Text = summe
        ListBox2.Items.Add(DataGridView2.CurrentRow.Cells(1).Value * (100 - TextBox7.Text) / 100)
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Dim indexl As Integer
        Dim abzug As String
        indexl = ListBox1.SelectedIndex
        aaa = ListBox1.Text
        ListBox1.Items.Remove(aaa)
        abzug = ListBox2.Items.Item(indexl).ToString
        TextBox5.Text = TextBox5.Text - abzug
        summe = summe - abzug
        ListBox2.Items.RemoveAt(indexl)
    End Sub

    Private Sub BestellungSpeichern(n, k, f)
        mkAdapter.SelectCommand.CommandText = "Select * from MaterialKurs where VZName = '" & TextBox23.Text & "' and kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "' order by material  "
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        For i = 0 To bsMaterialKurs.Count - 1
            bsMaterialKurs.RemoveCurrent()
            taMaterialKurs.Update(DsAusbildung.MaterialKurs)
        Next
        bsMaterialKurs.AddNew()
        For i = 0 To ListBox1.Items.Count - 1
            TextBox1.Text = k
            TextBox2.Text = f
            TextBox4.Text = n
            TextBox3.Text = ListBox1.Items.Item(i).ToString
            TextBox8.Text = ListBox2.Items.Item(i).ToString
            bsMaterialKurs.AddNew()
            taMaterialKurs.Update(DsAusbildung.MaterialKurs)
        Next
    End Sub


    Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        kodatum()
    End Sub
End Class