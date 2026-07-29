Public Class Kursbestellung3
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kmAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub Kursbestellung3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kursmaterial". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKursmaterial.Fill(Me.DsAusbildung.Kursmaterial)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.MaterialKurs". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
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

        Dim mk As System.Data.DataRowView = bsMaterialKurs.Current
        mkAdapter.SelectCommand = New OleDb.OleDbCommand
        mkAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        mkAdapter.SelectCommand.CommandText = "Select * from materialkurs order by VZName"
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        bsMaterialKurs.AddNew()

        Dim km As System.Data.DataRowView = bsKursmaterial.Current
        kmAdapter.SelectCommand = New OleDb.OleDbCommand
        kmAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kmAdapter.SelectCommand.CommandText = "Select * from kursmaterial order by lieferant"
        DsAusbildung.Kursmaterial.Clear()
        kmAdapter.Fill(DsAusbildung.Kursmaterial)
        bsKursmaterial.AddNew()

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
         End Select
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchenkurs()
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenkurs()
        End If
    End Sub
    Private Sub formularloeschen()
        TextBox10.Text = ""
        TextBox2.Text = ""
        DataGridView4.Visible = True
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        formularloeschen()
    End Sub

    Private Sub ButtonDrucken_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDrucken.Click
        Dim Xmk As New Printoutmk
        Dim dv As DataView
        Dim t As DataTable
        Dim iii As Integer
        Dim ik As Integer = 1
        Dim ij As Integer
        Dim matV As String = " "
        Menü.programmquelle = "3"
    
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.AddNew()

        mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where kurs = '" & TextBox2.Text & "' and fb = '" & TextBox10.Text & "' order by material"
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        iii = bsMaterialKurs.Count - 1
        For ij = 0 To iii
            If DsAusbildung.MaterialKurs.Rows(ij)("material").ToString <> matV Then
                If matV > " " Then
                    TextBox3.Text = matV
                    TextBox4.Text = ik.ToString
                    ik = 1
                    kmAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where material = '" & matV & "' "
                    bsKursmaterial.CancelEdit()
                    DsAusbildung.Kursmaterial.Clear()
                    kmAdapter.Fill(DsAusbildung.Kursmaterial)
                    bsKursmaterial.Position = 0
                    If bsKursmaterial.Count = 1 Then
                        TextBox5.Text = DsAusbildung.Kursmaterial.Rows(0)("Listenpreis").ToString
                        TextBox6.Text = DsAusbildung.Kursmaterial.Rows(0)("Einkaufspreis").ToString
                        TextBox7.Text = DsAusbildung.Kursmaterial.Rows(0)("Lieferant").ToString
                    End If
                    bsTemp.AddNew()
                    taTemp.Update(dsToernverwaltung)
                End If
                matV = DsAusbildung.MaterialKurs.Rows(ij)("material").ToString
            Else
                ik += 1
            End If
        Next
        TextBox3.Text = matV
        TextBox4.Text = ik.ToString
        kmAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where material = '" & matV & "' "
        bsKursmaterial.CancelEdit()
        DsAusbildung.Kursmaterial.Clear()
        kmAdapter.Fill(DsAusbildung.Kursmaterial)
        bsKursmaterial.Position = 0
        If bsKursmaterial.Count = 1 Then
            TextBox5.Text = DsAusbildung.Kursmaterial.Rows(0)("Listenpreis").ToString
            TextBox6.Text = DsAusbildung.Kursmaterial.Rows(0)("Einkaufspreis").ToString
            TextBox7.Text = DsAusbildung.Kursmaterial.Rows(0)("Lieferant").ToString
        End If
        bsTemp.AddNew()
        taTemp.Update(dsToernverwaltung)
        '      bsTemp.AddNew()
        '     taTemp.Update(dsToernverwaltung)
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "feld1", "feld2", "feld3", "feld4", "feld5")
        Xmk.PrintBestellung(t)
    
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        suchenkurs()
        DataGridView4.Visible = False
    End Sub
End Class