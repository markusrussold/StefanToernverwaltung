Public Class Kursbestellung2
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String

    Private Sub Kursbestellung2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.MaterialKurs". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Teilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)

        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Dim k As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbeginn desc "
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.AddNew()


        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by vzname"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()


        Dim mk As System.Data.DataRowView = bsMaterialKurs.Current
        mkAdapter.SelectCommand = New OleDb.OleDbCommand
        mkAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        mkAdapter.SelectCommand.CommandText = "Select * from materialkurs order by VZName"
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        bsMaterialKurs.AddNew()

    End Sub
    Private Sub suchenkurs()
        TextBox2.Text = RTrim(TextBox2.Text)
        If TextBox2.Text > "  " Then
            If TextBox2.Text > " " Then
                kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung like '%" & TextBox2.Text & "%' order by kursbezeichnung,fahrtbereich"
            Else
                If Len(TextBox2.Text) > 1 Then
                    If Mid(TextBox2.Text, 2, 1) = "*" Then
                        kAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbezeichnung,fahrtbereich"
                    Else
                        kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung like '%" & TextBox2.Text & "%' order by kursbezeichnung,fahrtbereich"
                    End If
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from kurse where Mid(kursbezeichnung,1,1) like '%" & TextBox2.Text & "%' order by kursbezeichnung,fahrtbereich"
                End If
            End If
        Else
            kAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbeginn desc "
        End If
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                kAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbezeichnung,fahrtbereich"
                bsKurse.CancelEdit()
                DsAusbildung.Kurse.Clear()
                kAdapter.Fill(DsAusbildung.Kurse)
            Case 1
                DataGridView4.Visible = False
            Case Else
                GroupBox2.Visible = False
                DataGridView4.Location = New Point(12, 168)
        End Select
    End Sub
    Private Sub suchenTeilnehmer()
        GroupBox2.Visible = False
        DataGridView5.Location = New Point(12, 168)
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where kurs = '" & TextBox2.Text & "' and fb = '" & TextBox10.Text & "' order by vzname"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()
    End Sub
    Private Sub ZeigenTeilnehmer()
        GroupBox2.Visible = False
        DataGridView5.Location = New Point(12, 168)
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where vzname = '" & TextBox1.Text & "' and kurs = '" & TextBox2.Text & "' and fb = '" & TextBox10.Text & "' order by vzname"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
          aaa = bsTeilnehmer.Count
    End Sub
    Private Sub formularloeschen()
        TextBox1.Text = ""
        TextBox10.Text = ""
        TextBox2.Text = ""
        DataGridView4.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchenkurs()
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenkurs()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            GroupBox2.Visible = True
            suchenTeilnehmer()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            alle()
        End If
    End Sub
    Private Sub alle()

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        suchenkurs()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        ZeigenTeilnehmer()
        GroupBox2.Visible = True
        DataGridView5.Location = New Point(1200, 168)
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        DataGridView5.Location = New Point(12, 168)
        suchenTeilnehmer()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridView5.Location = New Point(12, 168)
            suchenTeilnehmer()
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        formularloeschen()
    End Sub

    Private Sub ButtonDrucken_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDrucken.Click
        Dim Xmk As New Printoutmk
        Dim dv As DataView
        Dim t As DataTable
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Druckentscheidung fehlt: Teilnehmer oder Alle")
        Else
            Menü.programmquelle = "2"
            If RadioButton1.Checked Then
                mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where vzname = '" & TextBox1.Text & "' and kurs = '" & TextBox2.Text & "' and fb = '" & TextBox10.Text & "' order by material"
            Else
                mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where kurs = '" & TextBox2.Text & "' and fb = '" & TextBox10.Text & "' order by vzname"
            End If
            bsMaterialKurs.CancelEdit()
            DsAusbildung.MaterialKurs.Clear()
            mkAdapter.Fill(DsAusbildung.MaterialKurs)
            aaa = bsMaterialKurs.Count
            dv = bsMaterialKurs.List
            t = dv.ToTable("Printing", False, "Kurs", "FB", "Material", "VZName", "Verkaufspreis", "Bemerkung")
            Xmk.PrintBestellung(t)
        End If
        formularloeschen()
    End Sub
End Class