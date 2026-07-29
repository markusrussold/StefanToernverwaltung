Public Class Versicherter
    Dim hafadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim unfadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim Recadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim KauAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim FolAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim RueAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim vAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Dim bbb As String = 0
    Dim anz As String
    Dim tbeg As String
    Dim tend As String
    Dim chk As String
    Dim wk As String

    Private Sub Versicherter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung.YPdeRue". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taYPdeRue.Fill(Me.dsVersicherung.YPdeRue)
        Me.taToernKalkulation.Fill(Me.dsToernverwaltung.ToernKalkulation)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.ToernKalkulation". Sie können sie bei Bedarf verschieben oder entfernen.
         Me.taYPdefol.Fill(Me.dsVersicherung.YPdefol)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung.YPdekau". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taYPdekau.Fill(Me.dsVersicherung.YPdekau)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung.YPderech". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.ta1YPderech.Fill(Me.dsVersicherung.YPderech)
        Me.taYPdeUnf.Fill(Me.dsVersicherung.YPdeUnf)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung.Versicherter". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taVersicherter.Fill(Me.dsVersicherung.Versicherter)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung.YPdehaf". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taYPdehaf.Fill(Me.dsVersicherung.YPdehaf)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taVertrag.Fill(Me.dsVersicherung.Vertrag)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung._YP_de_haf". Sie können sie bei Bedarf verschieben oder entfernen.

        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height

        Dim r As System.Data.DataRowView = bsVersicherter.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Versicherter order by VersicherterName"
        bsVersicherter.CancelEdit()
        dsVersicherung.Versicherter.Clear()
        xAdapter.Fill(dsVersicherung.Versicherter)
        bsVersicherter.AddNew()

        vAdapter.SelectCommand = New OleDb.OleDbCommand
        vAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        vAdapter.SelectCommand.CommandText = "Select * from Vertrag order by Polizze"
        bsVertrag.CancelEdit()
        dsVersicherung.Vertrag.Clear()
        vAdapter.Fill(dsVersicherung.Vertrag)
        bsVertrag.AddNew()

        GroupBox1.Enabled = False
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsVersicherter.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        '       TextBox18.Text = RTrim(TextBox18.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    xAdapter.SelectCommand.CommandText = "Select * from Versicherter order by VersicherterName"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Versicherter where VersicherterName like '%" & TextBox1.Text & "%' and polizze like '%" & TextBox2.Text & "%' order by VersicherterName"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Versicherter where Mid(VersicherterName,1,1) like '%" & TextBox1.Text & "%' and polizze like '%" & TextBox2.Text & "%' order by VersicherterName"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Versicherter order by VersicherterName"
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsVersicherter.CancelEdit()
        dsVersicherung.Versicherter.Clear()
        xAdapter.Fill(dsVersicherung.Versicherter)
        Select Case bsVersicherter.Count
            Case 0
                MsgBox("Kein Versicherter mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Versicherter order by VersicherterName"
                xAdapter.Fill(dsVersicherung.Versicherter)
            Case 1
                DbAccess.SafePosition(bsVersicherter)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bbb = dsVersicherung.Versicherter.Rows(0)("Polizze").ToString
                aaa = dsVersicherung.Versicherter.Rows(0)("VersicherterName").ToString
                vAdapter.SelectCommand = New OleDb.OleDbCommand
                vAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
                vAdapter.SelectCommand.CommandText = "Select * from Vertrag where polizze like '%" & TextBox2.Text & "%'  order by Polizze"
                bsVertrag.CancelEdit()
                dsVersicherung.Vertrag.Clear()
                vAdapter.Fill(dsVersicherung.Vertrag)
                If bsVertrag.Count = 0 Then
                    bsVertrag.AddNew()
                    taVertrag.Update(dsVersicherung.Vertrag)
                    TextBox17.Text = TextBox2.Text
                    bsVertrag.EndEdit()
                    taVertrag.Update(dsVersicherung.Vertrag)
                End If
            Case Else
                DbAccess.SafePosition(bsVersicherter)
                DataGridView1.Visible = True
                GroupBox1.Location = New Point(2000, 2000)
                GroupBox2.Location = New Point(25, 115)
        End Select
    End Sub
    Private Sub ButtonNameSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNameSpeichern.Click
        Dim pol As String
        pol = TextBox2.Text
        '     And bbb < " " 
        If (aaa <> TextBox1.Text Or bbb <> TextBox2.Text) And bbb < " " Then
            bsVersicherter.AddNew()
        Else
            bsVersicherter.EndEdit()
        End If
        taVersicherter.Update(dsVersicherung.Versicherter)
        If bbb <> pol Then
            Polizzenaenderung(pol)
        End If
        GroupBox1.Location = New Point(25, 115)
        ButtonNameSpeichern.Visible = False
        GroupBox1.Enabled = True
        TextBox1.Text = aaa
        suchen()
        Praemiensumme()
    End Sub
    Private Sub Polizzenaenderung(ByRef p)
        vAdapter.SelectCommand = New OleDb.OleDbCommand
        vAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        vAdapter.SelectCommand.CommandText = "Select * from Vertrag where polizze = '" & bbb & "'  order by Polizze"
        bsVertrag.CancelEdit()
        dsVersicherung.Vertrag.Clear()
        vAdapter.Fill(dsVersicherung.Vertrag)
        If bsVertrag.Count = 0 Then
            bsVertrag.AddNew()
            TextBox17.Text = p
            bsVertrag.AddNew()
        Else
            TextBox17.Text = p
            bsVertrag.EndEdit()
        End If
        taVertrag.Update(dsVersicherung.Vertrag)
    End Sub
    Private Sub TextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text < " " Then
            TextBox2.Text = 1
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        suchen()
        GroupBox2.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(25, 115)
    End Sub

    Private Sub RadioButtonHafBe_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonHafBe.CheckedChanged
        If RadioButtonHafBe.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxHaf.Location = New Point(25, 115)
            Dim rs As System.Data.DataRowView = bsYPdehaf.Current
            hafadapter.SelectCommand = New OleDb.OleDbCommand
            hafadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            hafadapter.SelectCommand.CommandText = "Select * from YPdehaf order by deckung"
            bsYPdehaf.CancelEdit()
            dsVersicherung.YPdehaf.Clear()
            hafadapter.Fill(dsVersicherung.YPdehaf)
            For i = 0 To 6
                If i < 3 Then
                    bsYPdehaf.Position = i
                Else
                    bsYPdehaf.Position = i - 3
                End If
                Select Case i
                    Case 0
                        TextBox10.Text = TextBox13.Text
                        RadioButtonS5.Text = TextBox14.Text + " €"
                        RadioTrue(RadioButtonS5, 15, TextBox82.Text)
                    Case 1
                        TextBox11.Text = TextBox13.Text
                        RadioButtonS7.Text = TextBox14.Text + " €"
                        RadioTrue(RadioButtonS7, 17, TextBox82.Text)
                    Case 2
                        TextBox12.Text = TextBox13.Text
                        RadioButtonS10.Text = TextBox14.Text + " €"
                        RadioTrue(RadioButtonS10, 110, TextBox82.Text)
                    Case 3
                        TextBox10.Text = TextBox13.Text
                        RadioButtonM5.Text = TextBox15.Text + " €"
                        RadioTrue(RadioButtonM5, 25, TextBox82.Text)
                    Case 4
                        TextBox11.Text = TextBox13.Text
                        RadioButtonM7.Text = TextBox15.Text + " €"
                        RadioTrue(RadioButtonM7, 27, TextBox82.Text)
                    Case 5
                        TextBox12.Text = TextBox13.Text
                        RadioButtonM10.Text = TextBox15.Text + " €"
                        RadioTrue(RadioButtonM10, 210, TextBox82.Text)
                    Case 6                                         '            nicht Versichert
                        RadioTrue(RadioButton14, 0, TextBox82.Text)
                End Select
            Next
         End If
    End Sub
    Private Sub RadioButtonS5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS5.CheckedChanged
        If RadioButtonS5.Checked Then
            TextBox19.Text = RadioButtonS5.Text
            TextBox82.Text = 15
        End If
    End Sub
    Private Sub RadioButtonM5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM5.CheckedChanged
        If RadioButtonM5.Checked Then
            TextBox19.Text = RadioButtonM5.Text
            TextBox82.Text = 25
        End If
    End Sub
    Private Sub RadioButtonS7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS7.CheckedChanged
        If RadioButtonS7.Checked Then
            TextBox19.Text = RadioButtonS7.Text
            TextBox82.Text = 17
        End If
    End Sub
    Private Sub RadioButtonM7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM7.CheckedChanged
        If RadioButtonM7.Checked Then
            TextBox19.Text = RadioButtonM7.Text
            TextBox82.Text = 27
        End If
    End Sub
    Private Sub RadioButtonS10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS10.CheckedChanged
        If RadioButtonS10.Checked Then
            TextBox19.Text = RadioButtonS10.Text
            TextBox82.Text = 110
        End If
    End Sub
    Private Sub RadioButtonM10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM10.CheckedChanged
        If RadioButtonM10.Checked Then
            TextBox19.Text = RadioButtonM10.Text
            TextBox82.Text = 210
        End If
    End Sub
    Private Sub RadioButton14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked Then
            TextBox19.Text = 0
            TextBox82.Text = 0
        End If
    End Sub
    Private Sub ButtonHAF_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHAFSpeichern.Click
        TextBox3.Text = TextBox19.Text
        bsYPdehaf.EndEdit()
        taYPdehaf.Update(dsVersicherung.YPdehaf)

        bsVertrag.EndEdit()
        taVertrag.Update(dsVersicherung.Vertrag)

        GroupBoxHaf.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(25, 115)
        Praemiensumme()
    End Sub

    Private Sub RadioButtonUnf_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonUnf.CheckedChanged
        If RadioButtonUnf.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxUnf.Location = New Point(25, 115)
            Dim rsunf As System.Data.DataRowView = bsYPdeUnf.Current
            unfadapter.SelectCommand = New OleDb.OleDbCommand
            unfadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            unfadapter.SelectCommand.CommandText = "Select * from YPdeUnf order by invalid"
            bsYPdeUnf.CancelEdit()
            dsVersicherung.YPdeUnf.Clear()
            unfadapter.Fill(dsVersicherung.YPdeUnf)
            aaa = bsYPdeUnf.Count
            For i = 0 To 5
                bsYPdeUnf.Position = i
                Select Case i
                    Case 0
                        TextBox20.Text = TextBox36.Text
                        TextBox21.Text = TextBox37.Text
                        TextBox22.Text = TextBox38.Text
                        RadioButton155.Text = TextBox39.Text + " €"
                        RadioTrue(RadioButton155, 155, TextBox80.Text)
                    Case 1
                        TextBox23.Text = TextBox36.Text
                        TextBox24.Text = TextBox37.Text
                        TextBox25.Text = TextBox38.Text
                        RadioButton230.Text = TextBox39.Text + " €"
                        RadioTrue(RadioButton230, 230, TextBox80.Text)
                    Case 2
                        TextBox26.Text = TextBox36.Text
                        TextBox27.Text = TextBox37.Text
                        TextBox28.Text = TextBox38.Text
                        RadioButton380.Text = TextBox39.Text + " €"
                        RadioTrue(RadioButton380, 380, TextBox80.Text)
                    Case 3
                        TextBox29.Text = TextBox36.Text
                        TextBox30.Text = TextBox37.Text
                        TextBox31.Text = TextBox38.Text
                        RadioButton510.Text = TextBox39.Text + " €"
                        RadioTrue(RadioButton510, 510, TextBox80.Text)
                    Case 4
                        TextBox32.Text = TextBox36.Text
                        TextBox33.Text = TextBox37.Text
                        TextBox34.Text = TextBox38.Text
                        RadioButton770.Text = TextBox39.Text + " €"
                        RadioTrue(RadioButton770, 770, TextBox80.Text)
                    Case 5                                         '            nicht Versichert
                        RadioTrue(RadioButton11, 0, TextBox80.Text)
                End Select
            Next
        End If
    End Sub
    Private Sub ButtonUnfSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUnfSpeichern.Click
        TextBox4.Text = TextBox35.Text
        bsYPdeUnf.EndEdit()
        taYPdeUnf.Update(dsVersicherung.YPdeUnf)
        bsVertrag.EndEdit()
        taVertrag.Update(dsVersicherung.Vertrag)
        GroupBoxUnf.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(25, 115)
        Praemiensumme()
    End Sub
    Private Sub RadioButton11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            TextBox40.Text = 0
            TextBox35.Text = 0
            TextBox80.Text = 0
        End If
    End Sub
    Private Sub RadioButton155_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton155.CheckedChanged
        If RadioButton155.Checked Then
            TextBox40.Text = RadioButton155.Text
            TextBox35.Text = RadioButton155.Text
            TextBox80.Text = 155
        End If
    End Sub
    Private Sub RadioButton230_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton230.CheckedChanged
        If RadioButton230.Checked Then
            TextBox40.Text = RadioButton230.Text
            TextBox35.Text = RadioButton230.Text
            TextBox80.Text = 230
        End If
    End Sub
    Private Sub RadioButton380_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton380.CheckedChanged
        If RadioButton380.Checked Then
            TextBox40.Text = RadioButton380.Text
            TextBox35.Text = RadioButton380.Text
            TextBox80.Text = 380
        End If
    End Sub
    Private Sub RadioButton510_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton510.CheckedChanged
        If RadioButton510.Checked Then
            TextBox40.Text = RadioButton510.Text
            TextBox35.Text = RadioButton510.Text
            TextBox80.Text = 510
        End If
    End Sub
    Private Sub RadioButton770_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton770.CheckedChanged
        If RadioButton770.Checked Then
            TextBox40.Text = RadioButton770.Text
            TextBox35.Text = RadioButton770.Text
            TextBox80.Text = 770
        End If
    End Sub

    Private Sub RadioButtonRech_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRech.CheckedChanged
        If RadioButtonRech.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxRech.Location = New Point(25, 115)
            Dim rsrec As System.Data.DataRowView = bsYPderech.Current
            Recadapter.SelectCommand = New OleDb.OleDbCommand
            Recadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            Recadapter.SelectCommand.CommandText = "Select * from YPderech"
            bsYPderech.CancelEdit()
            dsVersicherung.YPderech.Clear()
            Recadapter.Fill(dsVersicherung.YPderech)
            aaa = bsYPderech.Count
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRekost.CheckedChanged
        If RadioButtonRekost.Checked Then
            TextBox42.Text = RadioButtonRekost.Text
        Else
            TextBox42.Text = 0
        End If
    End Sub
    Private Sub ButtonrechSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonrechSpeichern.Click
        TextBox5.Text = TextBox42.Text
        bsYPderech.EndEdit()
        ta1YPderech.Update(dsVersicherung.YPderech)
        bsVertrag.EndEdit()
        taVertrag.Update(dsVersicherung.Vertrag)
        GroupBoxRech.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(25, 115)
        Praemiensumme()
    End Sub

    Private Sub Praemiensumme()
        Dim zahl As Single
        zahl = 0
        If TextBox3.Text > "" Then
            zahl += TextBox3.Text
        End If
        If TextBox4.Text > "" Then
            zahl += TextBox4.Text
        End If
        If TextBox5.Text > "" Then
            zahl += TextBox5.Text
        End If
        If TextBox6.Text > "" Then
            zahl += TextBox6.Text
        End If
        If TextBox7.Text > "" Then
            zahl += TextBox7.Text
        End If
        If TextBox8.Text > "" Then
            zahl += TextBox8.Text
        End If
        TextBox9.Text = Format$(zahl, "0.##")

    End Sub

    Private Sub RadioButtonKau_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonKau.CheckedChanged               '   Kautionsversicherung
        If RadioButtonKau.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            groupboxkau.Location = New Point(25, 115)
            Dim rskau As System.Data.DataRowView = bsYPdekau.Current
            KauAdapter.SelectCommand = New OleDb.OleDbCommand
            KauAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            KauAdapter.SelectCommand.CommandText = "Select * from YPdekau order by kaution"
            bsYPdekau.CancelEdit()
            dsVersicherung.YPdekau.Clear()
            KauAdapter.Fill(dsVersicherung.YPdekau)
            aaa = bsYPdekau.Count
            For i = 0 To 10
                bsYPdekau.Position = i
                Select Case i
                    Case 0
                        TextBox43.Text = TextBox51.Text
                        RadioButton1.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton1, 1, TextBox79.Text)
                    Case 1
                        TextBox44.Text = TextBox51.Text
                        RadioButton2.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton2, 2, TextBox79.Text)
                    Case 2
                        TextBox45.Text = TextBox51.Text
                        RadioButton3.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton3, 3, TextBox79.Text)
                    Case 3
                        TextBox46.Text = TextBox51.Text
                        RadioButton4.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton4, 4, TextBox79.Text)
                    Case 4
                        TextBox47.Text = TextBox51.Text
                        RadioButton5.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton5, 5, TextBox79.Text)
                    Case 5
                        TextBox48.Text = TextBox51.Text
                        RadioButton6.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton6, 6, TextBox79.Text)
                    Case 6
                        TextBox75.Text = TextBox51.Text
                        RadioButton15.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton15, 15, TextBox79.Text)
                    Case 7
                        TextBox76.Text = TextBox51.Text
                        RadioButton16.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton16, 16, TextBox79.Text)
                    Case 8
                        TextBox77.Text = TextBox51.Text
                        RadioButton17.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton17, 17, TextBox79.Text)
                    Case 9
                        TextBox78.Text = TextBox51.Text
                        RadioButton18.Text = TextBox52.Text + " €"
                        RadioTrue(RadioButton18, 18, TextBox79.Text)
                    Case 10
                        TextBox49.Text = TextBox51.Text
                        If TextBox52.Text > "0" Then
                            TextBox49.Visible = True
                            RadioButton7.Visible = True
                            '               TextBox79.Text = TextBox51.Text + " €"
                            RadioButton7.Text = TextBox52.Text + " €"
                            '                 Label48.Visible = False
                            '                     Label47.Visible = False
                            RadioTrue(RadioButton7, 7, TextBox79.Text)
                        Else
                            TextBox49.Visible = False
                            RadioButton7.Visible = False
                            Label48.Visible = True
                            Label47.Visible = True
                        End If
                    Case 11                                         '            nicht Versichert
                        RadioTrue(RadioButton12, 0, TextBox79.Text)
                End Select
            Next
        End If
    End Sub
   Private Sub RadioButton1_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox50.Text = RadioButton1.Text
            TextBox79.Text = 1
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox50.Text = RadioButton2.Text
            TextBox79.Text = 2
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox50.Text = RadioButton3.Text
            TextBox79.Text = 3
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox50.Text = RadioButton4.Text
            TextBox79.Text = 4
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox50.Text = RadioButton5.Text
            TextBox79.Text = 5
        End If
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox50.Text = RadioButton6.Text
            TextBox79.Text = 6
        End If
    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            TextBox50.Text = RadioButton7.Text
            TextBox79.Text = 7
        End If

    End Sub
    Private Sub RadioButton15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked Then
            TextBox50.Text = RadioButton15.Text
            TextBox79.Text = 15
        End If
    End Sub
    Private Sub RadioButton16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked Then
            TextBox50.Text = RadioButton16.Text
            TextBox79.Text = 16
        End If
    End Sub
    Private Sub RadioButton17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked Then
            TextBox50.Text = RadioButton17.Text
            TextBox79.Text = 17
        End If
    End Sub
    Private Sub RadioButton18_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked Then
            TextBox50.Text = RadioButton18.Text
            TextBox79.Text = 18
        End If
    End Sub
    Private Sub ButtonKautionSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonKautionSpeichern.Click
        TextBox6.Text = TextBox50.Text
        bsYPdekau.EndEdit()
        taYPdekau.Update(dsVersicherung.YPdekau)
        bsVertrag.EndEdit()
        taVertrag.Update(dsVersicherung.Vertrag)
        groupboxkau.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(25, 115)
        Praemiensumme()
    End Sub
    Private Sub RadioButton12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked Then
            TextBox50.Text = 0
            TextBox79.Text = 0
        End If
    End Sub

    Private Sub RadioButtonFol_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonFol.CheckedChanged
        If RadioButtonFol.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxFol.Location = New Point(25, 115)
            Dim rsFol As System.Data.DataRowView = bsYPdefol.Current
            FolAdapter.SelectCommand = New OleDb.OleDbCommand
            FolAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            FolAdapter.SelectCommand.CommandText = "Select * from YPdeFol order by Laenge"
            bsYPdefol.CancelEdit()
            dsVersicherung.YPdefol.Clear()
            FolAdapter.Fill(dsVersicherung.YPdefol)
            aaa = bsYPdefol.Count
            For i = 0 To 10
                If i < 5 Then
                    bsYPdefol.Position = i
                Else
                    bsYPdefol.Position = i - 5
                End If
                Select Case i
                    Case 0
                        TextBox54.Text = TextBox59.Text + "'"
                        RadioButtonS33.Text = TextBox60.Text + " €"
                        RadioTrue(RadioButtonS33, 133, TextBox81.Text)
                    Case 1
                        TextBox55.Text = TextBox59.Text + "'"
                        RadioButtonS38.Text = TextBox60.Text + " €"
                    Case 2
                        TextBox56.Text = TextBox59.Text + "'"
                        RadioButtonS43.Text = TextBox60.Text + " €"
                    Case 3
                        TextBox57.Text = TextBox59.Text + "'"
                        RadioButtonS52.Text = TextBox60.Text + " €"
                    Case 4
                        TextBox58.Text = TextBox59.Text + "'"
                        RadioButtonS63.Text = TextBox60.Text + " €"
                    Case 5
                        TextBox54.Text = TextBox59.Text + "'"
                        RadioButtonM33.Text = TextBox61.Text + " €"
                        RadioTrue(RadioButtonM33, 233, TextBox81.Text)
                    Case 6
                        TextBox55.Text = TextBox59.Text + "'"
                        RadioTrue(RadioButtonM38, 238, TextBox81.Text)
                        RadioButtonM38.Text = TextBox61.Text + " €"
                    Case 7
                        TextBox56.Text = TextBox59.Text + "'"
                        RadioTrue(RadioButtonM43, 243, TextBox81.Text)
                        RadioButtonM43.Text = TextBox61.Text + " €"
                    Case 8
                        TextBox57.Text = TextBox59.Text + "'"
                        RadioTrue(RadioButtonM52, 252, TextBox81.Text)
                        RadioButtonM52.Text = TextBox61.Text + " €"
                    Case 9
                        TextBox58.Text = TextBox59.Text + "'"
                        RadioTrue(RadioButtonM63, 263, TextBox81.Text)
                        RadioButtonM63.Text = TextBox61.Text + " €"
                    Case 10                                         '            nicht Versichert
                        RadioTrue(RadioButton8, 0, TextBox81.Text)
                End Select
            Next
        End If
    End Sub
    Private Sub RadioButtonS33_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS33.CheckedChanged
        If RadioButtonS33.Checked Then
            TextBox53.Text = RadioButtonS33.Text
            TextBox81.Text = 133
        End If
    End Sub
    Private Sub RadioButtonM33_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM33.CheckedChanged
        If RadioButtonM33.Checked Then
            TextBox53.Text = RadioButtonM33.Text
            TextBox81.Text = 233
        End If
    End Sub
    Private Sub RadioButtonS38_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS38.CheckedChanged
        If RadioButtonS38.Checked Then
            TextBox53.Text = RadioButtonS38.Text
            TextBox81.Text = 138
        End If
    End Sub
    Private Sub RadioButtonM38_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM38.CheckedChanged
        If RadioButtonM38.Checked Then
            TextBox53.Text = RadioButtonM38.Text
            TextBox81.Text = 238
        End If
    End Sub
    Private Sub RadioButtonS43_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS43.CheckedChanged
        If RadioButtonS43.Checked Then
            TextBox53.Text = RadioButtonS43.Text
            TextBox81.Text = 143
        End If
    End Sub
    Private Sub RadioButtonM43_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM43.CheckedChanged
        If RadioButtonM43.Checked Then
            TextBox53.Text = RadioButtonM43.Text
            TextBox81.Text = 243
        End If
    End Sub
    Private Sub RadioButtonS52_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS52.CheckedChanged
        If RadioButtonS52.Checked Then
            TextBox53.Text = RadioButtonS52.Text
            TextBox81.Text = 152
        End If
    End Sub
    Private Sub RadioButtonM52_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM52.CheckedChanged
        If RadioButtonM52.Checked Then
            TextBox53.Text = RadioButtonM52.Text
            TextBox81.Text = 252
        End If
    End Sub
    Private Sub RadioButtonS63_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonS63.CheckedChanged
        If RadioButtonS63.Checked Then
            TextBox53.Text = RadioButtonS63.Text
            TextBox81.Text = 163
        Else
            TextBox53.Text = 0
        End If
    End Sub
    Private Sub RadioButtonM63_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonM63.CheckedChanged
        If RadioButtonM63.Checked Then
            TextBox53.Text = RadioButtonM63.Text
            TextBox81.Text = 263
        End If
    End Sub
    Private Sub ButtonFoSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFoSpeichern.Click
        TextBox7.Text = TextBox53.Text
        bsYPdefol.EndEdit()
        taYPdefol.Update(dsVersicherung.YPdefol)
        bsVertrag.EndEdit()
        taVertrag.Update(dsVersicherung.Vertrag)
        GroupBoxFol.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(25, 115)
        Praemiensumme()
    End Sub
    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        TextBox53.Text = 0
        TextBox81.Text = 0
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        '      GroupBox1.Location = New Point(2000, 2000)
        SuchenKalk()
    End Sub
    Private Sub SuchenKalk()
        Dim r As System.Data.DataRowView = bsToernKalkulation.Current
        Dim tname As String
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox70.Text = RTrim(TextBox70.Text)
        If TextBox70.Text > "  " Then
            If IsNumeric(TextBox70.Text) And Len(TextBox70.Text) = 4 Then
                kAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where year(Toernanfang) like '%" & TextBox70.Text & "%'  order by toern"
            Else
                If Len(TextBox70.Text) > 1 Then
                    If Mid(TextBox70.Text, 2, 1) = "*" Then
                        '               buch1 = Mid(TextBox70.Text, 1, 1).ToUpper
                        kAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation  order by toern"
                    Else
                        tname = TextBox70.Text
                        kAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern = '" & TextBox70.Text & "' order by toern"
                        bsToernKalkulation.CancelEdit()
                        '                       aenderung = True
                        dsToernverwaltung.ToernKalkulation.Clear()
                        kAdapter.Fill(dsToernverwaltung.ToernKalkulation)
                        If bsToernKalkulation.Count = 0 Then
                            TextBox70.Text = tname
                            kAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern like '%" & TextBox70.Text & "%' order by toern"
                        End If
                    End If
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where mid(toern,1,1) like '%" & TextBox70.Text & "%' order by toern"
                End If
            End If
        Else
            kAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation order by toern"
        End If
        bsToernKalkulation.CancelEdit()
        '        aenderung = True
        dsToernverwaltung.ToernKalkulation.Clear()
        kAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        '      ButtonCrewSuchen.Enabled = False
        Select Case bsToernKalkulation.Count
            Case 0
                DataGridView3.Visible = True
                DataGridView2.Visible = False
                suchentoern()
            Case 1
                DbAccess.SafePosition(bsToernKalkulation)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                '   (anz, tbeg, tend, chk, wk)
                anz = dsToernverwaltung.ToernKalkulation.Rows(0)("crewanzahl").ToString
                tbeg = dsToernverwaltung.ToernKalkulation.Rows(0)("Toernanfang").ToString
                tend = dsToernverwaltung.ToernKalkulation.Rows(0)("toernende").ToString
                chk = dsToernverwaltung.ToernKalkulation.Rows(0)("Charterkosten").ToString + " €"
                wk = dsToernverwaltung.ToernKalkulation.Rows(0)("Flugpreis").ToString + " €"
                ruecktritt()
            Case Else
                DataGridView2.Location = New Point(24, 442)
        End Select
    End Sub
    Private Sub suchentoern()
        Dim r As System.Data.DataRowView = bsToernname.Current
        '     GroupBox2.Text = "Törn auswählen mit Doppelklick"
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox70.Text & "' "
        If TextBox70.Text > "  " Then
            If IsNumeric(TextBox70.Text) And Len(TextBox70.Text) = 4 Then
                tAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox70.Text & "%'  order by toernbezeichnung"
            Else
                If Len(TextBox70.Text) > 1 Then
                    If Mid(TextBox70.Text, 2, 1) = "*" Then
                        '                      buch1 = Mid(Textbox70.Text, 1, 1).ToUpper
                        tAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        tAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox70.Text & "%'  order by toernbezeichnung"
                    End If
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from Toernname where Mid(toernbezeichnung,1,1) like '%" & TextBox70.Text & "%'  order by toernbezeichnung"
                End If
            End If
        Else
            tAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        End If
        '       End If
        '       aenderung = True
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        tAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                tAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                tAdapter.Fill(dsToernverwaltung.Toernname)
            Case 1
                DbAccess.SafePosition(bsToernname)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                '   (anz, tbeg, tend, chk, wk)
                '           anz = dsToernverwaltung.Toernname.Rows(0)("crewanzahl").ToString
                tbeg = dsToernverwaltung.Toernname.Rows(0)("Datumvon").ToString
                tend = dsToernverwaltung.Toernname.Rows(0)("Datumbis").ToString
                chk = " "
                wk = " "
                ruecktritt()
            Case Else
                DataGridView3.Location = New Point(24, 442)
        End Select

    End Sub
    Private Sub TextBox70_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox70.KeyDown
        If e.KeyCode = Keys.Enter Then
            SuchenKalk()
        End If
    End Sub
    Private Sub RadioButtonRue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRue.CheckedChanged
        If RadioButtonFol.Checked Then
            ruecktritt()
        End If
    End Sub
    Private Sub ruecktritt()
        Dim zahl As Single
        Dim wert As Single
        GroupBox1.Location = New Point(2000, 2000)
        GroupBoxRue.Location = New Point(25, 115)
        Dim rsRue As System.Data.DataRowView = bsYPdeRue.Current
        RueAdapter.SelectCommand = New OleDb.OleDbCommand
        RueAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        RueAdapter.SelectCommand.CommandText = "Select * from YPdeRue order by Toernname"
        bsYPdeRue.CancelEdit()
        dsVersicherung.YPdeRue.Clear()
        RueAdapter.Fill(dsVersicherung.YPdeRue)
        TextBox64.Text = anz
        TextBox65.Text = SafeData.FormatDateDe(tbeg)
        TextBox66.Text = SafeData.FormatDateDe(tend)
        TextBox67.Text = chk
        TextBox68.Text = wk
        zahl = chk
        zahl += wk
        TextBox69.Text = Format(zahl, "#,0")
        wert = TextBox63.Text * zahl / 100
        RadioButton10.Text = wert.ToString("##,#0.00") + " €"
        DataGridView2.Visible = False
        DataGridView3.Visible = False
    End Sub
    Private Sub DataGridView3_Click(sender As Object, e As System.EventArgs) Handles DataGridView3.Click
        TextBox70.Text = TextBox73.Text
        suchentoern()
    End Sub
    Private Sub DataGridView2_Click1(sender As Object, e As System.EventArgs) Handles DataGridView2.Click
        TextBox70.Text = TextBox74.Text
        SuchenKalk()
    End Sub
    Private Sub RadioButton10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked Then
            TextBox62.Text = RadioButton10.Text
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox8.Text = TextBox62.Text
        bsYPdeRue.EndEdit()
        taYPdeRue.Update(dsVersicherung.YPdeRue)
        bsVertrag.EndEdit()
        taVertrag.Update(dsVersicherung.Vertrag)
        GroupBoxRue.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(25, 115)
        Praemiensumme()
    End Sub
    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged
        TextBox62.Text = 0
    End Sub



    Private Sub RadioButton13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked Then
            TextBox42.Text = 0
        End If
    End Sub


    Private Sub RadioTrue(ByRef rd, ByRef zif, ByVal TB)
        If Not DBNull.Value.Equals(TB) Then
            If TB > "" Then
                If TB = zif Then
                    rd.Checked = True
                End If
            End If
        End If
    End Sub

 End Class