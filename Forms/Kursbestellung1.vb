Public Class Kursbestellung1
    Dim kmAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String

    Private Sub Kursbestellung1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        Me.taKursmaterial.Fill(Me.DsAusbildung.Kursmaterial)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)

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


        Dim km As System.Data.DataRowView = bsKursmaterial.Current
        kmAdapter.SelectCommand = New OleDb.OleDbCommand
        kmAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kmAdapter.SelectCommand.CommandText = "Select * from kursmaterial order by lieferant"
        DsAusbildung.Kursmaterial.Clear()
        kmAdapter.Fill(DsAusbildung.Kursmaterial)
        bsKursmaterial.AddNew()

        DataGridView3.Columns(0).Width = 220
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
            If Not DBNull.Value.Equals(TextBox10.Text) Then
                kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung = '" & TextBox2.Text & "' and fahrtbereich = '" & TextBox10.Text & "' order by kursbezeichnung,fahrtbereich"
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
                bsMaterialKurs.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView4.Visible = False
                DataGridView3.Location = New Point(12, 140)
                ListBox1.Location = New Point(405, 140)
            Case Else
        End Select
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
    Private Sub DataGridView4_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        suchenkurs()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        ListBox1.Items.Add(TextBox1.Text)
    End Sub
    Private Sub ListBox1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        aaa = ListBox1.Text
        ListBox1.Items.Remove(aaa)
    End Sub

    Private Sub ButtonDrucken_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDrucken.Click
        Dim Xmk As New Printoutmk
        Dim dv As DataView
        Dim t As DataTable
        Dim iii As Integer
        Dim ik As Integer = 1
        Dim ij As Integer
        Menü.programmquelle = 1
        Dim mAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rm As System.Data.DataRowView = bsKursmaterial.Current
        mAdapter.SelectCommand = New OleDb.OleDbCommand
        mAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")

        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.AddNew()
        taTemp.Update(dsToernverwaltung)
        iii = ListBox1.Items.Count - 1
        For ij = 0 To iii
            aaa = ListBox1.Items.Item(ij).ToString
            kmAdapter.SelectCommand.CommandText = "Select * from kursmaterial where material = '" & aaa & "' "
            bsKursmaterial.CancelEdit()
            DsAusbildung.Kursmaterial.Clear()
            kmAdapter.Fill(DsAusbildung.Kursmaterial)
            iii = bsKursmaterial.Count - 1
            TextBox3.Text = DsAusbildung.Kursmaterial.Rows(0)("Material").ToString
            TextBox4.Text = DsAusbildung.Kursmaterial.Rows(0)("Listenpreis").ToString
            TextBox5.Text = "2"
            bsTemp.AddNew()
            taTemp.Update(dsToernverwaltung)
        Next
        tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox2.Text & "' and fb = '" & TextBox10.Text & "' order by vzname"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        iii = bsTeilnehmer.Count - 1
        For ij = 0 To iii
            TextBox3.Text = DsAusbildung.Teilnehmer.Rows(ij)("vzname").ToString
            TextBox5.Text = "3"
           bsTemp.AddNew()
            taTemp.Update(dsToernverwaltung)
        Next


        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "feld1", "feld2", "feld3")
        Xmk.PrintBestellung(t)
        Close()
    End Sub

End Class