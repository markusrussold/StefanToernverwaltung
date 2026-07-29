Public Class Kursbestellung
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kmAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Private Sub Kursbestellung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Teilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kursmaterial". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKursmaterial.Fill(Me.DsAusbildung.Kursmaterial)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
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

        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by vzname"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()

        RadioButton3.Checked = False
        RadioButton2.Checked = False
        GroupBox3.Visible = False
        GroupBox3.Location = New Point(330.2)
        GroupBox2.Visible = False
        GroupBox4.Visible = False
        DataGridView3.Columns(0).Width = 220
    End Sub
    Private Sub suchen()
        '     mkAdapter.SelectCommand.CommandText = "Select * from materialkurs order by VZName"
        GroupBox4.Visible = True
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If TextBox1.Text > " " Then
                mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where VZName like '%" & TextBox1.Text & "%' order by VZName,kurs,fb"
            Else
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox1.Text, 2, 1) = "*" Then
                        mkAdapter.SelectCommand.CommandText = "Select * from materialkurs  order by VZName,kurs,fb"
                    Else
                        mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where VZName like '%" & TextBox1.Text & "%' order by VZName,kurs,fb"
                    End If
                Else
                    mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where  Mid(VZName,1,1) like '%" & TextBox1.Text & "%'   order by VZName,kurs,fb"
                End If
            End If
        Else
            mkAdapter.SelectCommand.CommandText = "Select * from materialkurs  order by VZName,kurs,fb"
        End If
        bsMaterialKurs.CancelEdit()
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        Select Case bsMaterialKurs.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                mkAdapter.SelectCommand.CommandText = "Select * from materialkurs  order by VZName,kurs,fb"
                bsMaterialKurs.CancelEdit()
                DsAusbildung.MaterialKurs.Clear()
                mkAdapter.Fill(DsAusbildung.MaterialKurs)
            Case 1
                DbAccess.SafePosition(bsMaterialKurs)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                GroupBox3.Visible = False
                GroupBox2.Location = New Point(330, 20)
                GroupBox2.Visible = True
                GroupBox1.Enabled = True
                '              If DsAusbildung.MaterialKurs.Rows(0)("Clubmitglied").ToString Then

            Case Else
                '               If buch1 > " " Then
                'positionieren()
                '                End If
                '               buch1 = ""
                '              bsMaterialKurs.Position = position
         End Select
    End Sub
    Private Sub suchenkurs()
        '      GroupBox4.Visible = True
       TextBox2.Text = RTrim(TextBox2.Text)
        If TextBox2.Text > "  " Then
            If TextBox2.Text > " " Then
                '              mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where kurs like '%" & TextBox2.Text & "%' order by kurs,fb,VZName"
                mkAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung like '%" & TextBox2.Text & "%' order by kursbezeichnung,fahrtbereich"
            Else
                If Len(TextBox2.Text) > 1 Then
                    If Mid(TextBox2.Text, 2, 1) = "*" Then
                        '            mkAdapter.SelectCommand.CommandText = "Select * from materialkurs  order by  kurs,fb,VZName"
                        mkAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbezeichnung,fahrtbereich"
                    Else
                        '            mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where kurs like '%" & TextBox2.Text & "%' order by kurs,fb,VZName"
                        mkAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung like '%" & TextBox2.Text & "%' order by kursbezeichnung,fahrtbereich"
                    End If
                Else
                    '               mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where  Mid(kurs,1,1) like '%" & TextBox2.Text & "%'   order by  kurs,fb,VZName"
                    mkAdapter.SelectCommand.CommandText = "Select * from kurse where Mid(kursbezeichnung,1,1) like '%" & TextBox2.Text & "%' order by kursbezeichnung,fahrtbereich"
                End If
            End If
        Else
            '           mkAdapter.SelectCommand.CommandText = "Select * from materialkurs  order by  kurs,fb,VZName"
            mkAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbeginn desc "
        End If
        '        bsMaterialKurs.CancelEdit()
        '        DsAusbildung.MaterialKurs.Clear()
        '        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        mkAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsMaterialKurs.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                '               mkAdapter.SelectCommand.CommandText = "Select * from materialkurs  order by  kurs,fb,VZName"
                mkAdapter.SelectCommand.CommandText = "Select * from kurse order by kursbezeichnung,fahrtbereich"
                '        bsMaterialKurs.CancelEdit()
                '        DsAusbildung.MaterialKurs.Clear()
                '        mkAdapter.Fill(DsAusbildung.MaterialKurs)
                bsKurse.CancelEdit()
                DsAusbildung.Kurse.Clear()
                mkAdapter.Fill(DsAusbildung.Kurse)
            Case 1
                DbAccess.SafePosition(bsMaterialKurs)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                GroupBox3.Visible = False
                GroupBox2.Location = New Point(330, 20)
                GroupBox2.Visible = True
                GroupBox1.Enabled = True
                '              If DsAusbildung.MaterialKurs.Rows(0)("Clubmitglied").ToString Then

            Case Else
                '               If buch1 > " " Then
                'positionieren()
                '                End If
                '               buch1 = ""
                '              bsMaterialKurs.Position = position
        End Select
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton1.Checked Then
            GroupBox2.Visible = True
            GroupBox3.Visible = False
        End If
        If RadioButton2.Checked Then
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            GroupBox3.Location = New Point(330, 20)
        End If
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        suchen()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub formularloeschen()
        TextBox1.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox2.Text = ""
         GroupBox4.Visible = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formularloeschen()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchenkurs()
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenkurs()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            GroupBox2.Visible = True
            GroupBox3.Visible = False
            DataGridView4.Visible = False
        End If
        If RadioButton2.Checked Then
            GroupBox2.Visible = False
            DataGridView4.Visible = True
            DataGridView4.Size = New Point(706, 271)
            DataGridView4.Location = New Point(32, 155)
            GroupBox3.Visible = True
            GroupBox3.Location = New Point(330, 20)
        End If
    End Sub

    Private Sub ButtonDrucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDrucken.Click
        Dim Xmk As New PrintOutMK
        Dim dv As DataView
        Dim t As DataTable
        Dim iii As Integer
        Dim ik As Integer = 1
        Dim ij As Integer
        Menü.programmquelle = "Kursbestellung"
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
        '       If bsTemp.Count > 0 Then
        ' iii = bsTemp.Count - 1
        ' For ij = 0 To iii
        ' bsTemp.RemoveCurrent()
        ' taTemp.Update(dsToernverwaltung)
        ' Next
        ' End If
        bsTemp.AddNew()

        If RadioButton2.Checked Then
            Dim matV As String = " "
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
                        mAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where material = '" & matV & "' "
                        bsKursmaterial.CancelEdit()
                        DsAusbildung.Kursmaterial.Clear()
                        mAdapter.Fill(DsAusbildung.Kursmaterial)
                        DbAccess.SafePosition(bsKursmaterial)
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
            mAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where material = '" & matV & "' "
            bsKursmaterial.CancelEdit()
            DsAusbildung.Kursmaterial.Clear()
            mAdapter.Fill(DsAusbildung.Kursmaterial)
            DbAccess.SafePosition(bsKursmaterial)
            If bsKursmaterial.Count = 1 Then
                TextBox5.Text = DsAusbildung.Kursmaterial.Rows(0)("Listenpreis").ToString
                TextBox6.Text = DsAusbildung.Kursmaterial.Rows(0)("Einkaufspreis").ToString
                TextBox7.Text = DsAusbildung.Kursmaterial.Rows(0)("Lieferant").ToString
            End If
            bsTemp.AddNew()
            taTemp.Update(dsToernverwaltung)
            bsTemp.AddNew()
            taTemp.Update(dsToernverwaltung)
            dv = bsTemp.List
            t = dv.ToTable("Printing", False, "feld1", "feld2", "feld3", "feld4", "feld5")
            Xmk.PrintBestellung(t)
        End If
        If RadioButton3.Checked Then
            mkAdapter.SelectCommand.CommandText = "Select * from materialkurs where vzname = '" & TextBox1.Text & "' and kurs = '" & TextBox12.Text & "' and fb = '" & TextBox11.Text & "' order by material"
            bsMaterialKurs.CancelEdit()
            DsAusbildung.MaterialKurs.Clear()
            mkAdapter.Fill(DsAusbildung.MaterialKurs)
            dv = bsMaterialKurs.List
            t = dv.ToTable("Printing", False, "Kurs", "FB", "Material", "VZName", "Verkaufspreis", "Bemerkung")
            Xmk.PrintBestellung(t)
        End If
        If RadioButton4.Checked Then
            TextBox5.Text = TextBox2.Text
            TextBox6.Text = TextBox10.Text
            TextBox7.Text = "1"
            '        bsTemp.AddNew()
            '       taTemp.Update(dsToernverwaltung)
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
                TextBox5.Text = DsAusbildung.Kursmaterial.Rows(0)("Material").ToString
                TextBox6.Text = DsAusbildung.Kursmaterial.Rows(0)("Listenpreis").ToString
                TextBox7.Text = "2"
                '               bsTemp.AddNew()
                '               taTemp.Update(dsToernverwaltung)
                bsTemp.AddNew()
                taTemp.Update(dsToernverwaltung)
            Next
            tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox2.Text & "' and fb = '" & TextBox10.Text & "' order by vzname"
            bsTeilnehmer.CancelEdit()
            DsAusbildung.Teilnehmer.Clear()
            tAdapter.Fill(DsAusbildung.Teilnehmer)
            iii = bsTeilnehmer.Count - 1
            For ij = 0 To iii
                TextBox5.Text = DsAusbildung.Teilnehmer.Rows(ij)("vzname").ToString
                TextBox7.Text = "3"
                '             bsTemp.AddNew()
                '            taTemp.Update(dsToernverwaltung)
                bsTemp.AddNew()
                taTemp.Update(dsToernverwaltung)
            Next


            dv = bsTemp.List
            t = dv.ToTable("Printing", False, "feld1", "feld2", "feld3", "feld4", "feld5")
            Xmk.PrintBestellung(t)
        End If
    End Sub
    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        suchen()
        GroupBox4.Visible = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            GroupBox3.Location = New Point(330, 20)
            DataGridView4.Location = New Point(29, 155)
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        ListBox1.Items.Add(TextBox8.Text)
    End Sub

    Private Sub ListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        aaa = ListBox1.Text
        ListBox1.Items.Remove(aaa)
    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        If RadioButton4.Checked Then
            DataGridView4.Location = New Point(929, 155)
            DataGridView3.Location = New Point(29, 155)
            ListBox1.Location = New Point(582, 155)
        End If
    End Sub
End Class