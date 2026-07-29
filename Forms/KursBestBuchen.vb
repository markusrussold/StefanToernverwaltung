Public Class KursBestBuchen
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kmAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim summe As Single
    Dim aaa As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.MaterialKurs". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kursmaterial". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKursmaterial.Fill(Me.DsAusbildung.Kursmaterial)
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
        kAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbeginn "
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.AddNew()

        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by VZName"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()

        Dim mk As System.Data.DataRowView = bsMaterialKurs.Current
        mkAdapter.SelectCommand = New OleDb.OleDbCommand
        mkAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        mkAdapter.SelectCommand.CommandText = "Select * from Materialkurs order by VZName"
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        bsMaterialKurs.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        bsMaterialKurs.AddNew()

        Dim km As System.Data.DataRowView = bsKursmaterial.Current
        kmAdapter.SelectCommand = New OleDb.OleDbCommand
        kmAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kmAdapter.SelectCommand.CommandText = "Select * from Kursmaterial order by material"
        bsKursmaterial.CancelEdit()
        DsAusbildung.Kursmaterial.Clear()
        mkAdapter.Fill(DsAusbildung.Kursmaterial)
        bsKursmaterial.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
    End Sub
    Private Sub SuchenTeilnehmer()
        If TextBox12.Text > "  " And TextBox11.Text > "  " And TextBox23.Text = "" Then
            tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "' order by vzname  "
        Else
            tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer  where VZName like '%" & TextBox23.Text & "%' and kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "'"
         End If
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        Select Case bsTeilnehmer.Count
            Case 0
                MsgBox("Kein Kursteilnehmer mit angegebenen Buchstabenkombination vorhanden")
                TextBox23.Text = ""
            Case 1
                ListBox1.Items.Clear()
                GroupBox2.Location = New Point(1200, 1710)
                GroupBox3.Location = New Point(12, 155)
                suchenMaterialBestellt()
            Case Else
        End Select

    End Sub
    Private Sub suchenkurs()
        TextBox12.Text = RTrim(TextBox12.Text)
        If TextBox12.Text > "  " Then
            If TextBox12.Text > " " Then
                kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung like '%" & TextBox12.Text & "%' order by kursbezeichnung,fahrtbereich"
            Else
                If Len(TextBox12.Text) > 1 Then
                    If Mid(TextBox12.Text, 2, 1) = "*" Then
                        kAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbezeichnung,fahrtbereich"
                    Else
                        kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung like '%" & TextBox12.Text & "%' order by kursbezeichnung,fahrtbereich"
                    End If
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from kurse where Mid(kursbezeichnung,1,1) like '%" & TextBox12.Text & "%' order by kursbezeichnung,fahrtbereich"
                End If
            End If
            If Not DBNull.Value.Equals(TextBox11.Text) Then
                kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung = '" & TextBox12.Text & "' and fahrtbereich = '" & TextBox11.Text & "' order by kursbezeichnung,fahrtbereich"
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
                '               bsMaterialKurs.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView4.Visible = False
                GroupBox2.Location = New Point(12, 155)
                SuchenTeilnehmer()
            Case Else
        End Select
    End Sub
    Private Sub DataGridView4_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView4.CellMouseClick
        suchenkurs()
        TextBox23.Text = ""
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        SuchenTeilnehmer()
    End Sub
    Private Sub suchenMaterialBestellt()
        mkAdapter.SelectCommand.CommandText = "Select * from MaterialKurs  where VZName like '%" & TextBox23.Text & "%' and kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "'"
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        summe = 0
        For i = 0 To bsMaterialKurs.Count - 1
            bsMaterialKurs.Position = i
            ListBox1.Items.Add(TextBox1.Text)
            summe += TextBox3.Text
        Next
        aaa = summe
        Label3.Text = "€ " + aaa
    End Sub
    Private Sub MatAuswahl()
        If TextBox6.Text = "*" Then
            kmAdapter.SelectCommand.CommandText = "Select * from Kursmaterial order by material"
        Else
            kmAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where material='" & TextBox6.Text & "'"
        End If
        bsKursmaterial.CancelEdit()
        DsAusbildung.Kursmaterial.Clear()
        kmAdapter.Fill(DsAusbildung.Kursmaterial)
        aaa = bsKursmaterial.Count
    End Sub
    Private Sub DataGridView2_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Dim mat As String
        MatAuswahl()
        ListBox1.Items.Add(TextBox6.Text)
        summe += TextBox7.Text
         TextBox6.Text = "*"
        MatAuswahl()
        aaa = summe
        Label3.Text = "€ " + aaa
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As System.EventArgs) Handles ListBox1.Click
        aaa = ListBox1.Text
        TextBox6.Text = aaa
        MatAuswahl()
        ListBox1.Items.Remove(TextBox6.Text)
        summe -= TextBox7.Text
        aaa = summe
        Label3.Text = "€ " + aaa
        TextBox6.Text = "*"
        MatAuswahl()
    End Sub
    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        mkAdapter.SelectCommand.CommandText = "delete * from MaterialKurs  where VZName like '%" & TextBox23.Text & "%' and kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "'"
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        For i = 0 To ListBox1.Items.Count - 1
            bsMaterialKurs.AddNew()
            TextBox1.Text = ListBox1.Items(i)
            TextBox2.Text = TextBox23.Text
            TextBox4.Text = TextBox12.Text
            TextBox5.Text = TextBox11.Text
            TextBox6.Text = ListBox1.Items(i)
            MatAuswahl()
            TextBox3.Text = TextBox7.Text
            bsMaterialKurs.AddNew()
            taMaterialKurs.Update(DsAusbildung.MaterialKurs)
        Next

        TextBox8.Text = summe
        bsTeilnehmer.EndEdit()
        taTeilnehmer.Update(DsAusbildung.Teilnehmer)

    End Sub
End Class