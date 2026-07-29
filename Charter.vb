Public Class Charter
     Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Dim position As Integer
    Dim buch1 As String
    Private Sub Charter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Postleitzahlen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taPostleitzahlen.Fill(Me.dsToernverwaltung.Postleitzahlen)
        '                                             R1  wird für Bankverbindung verwendet
        Me.taAgentur.Fill(Me.dsToernverwaltung.Agentur)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taCharter.Fill(Me.dsToernverwaltung.Charter)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCharter.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Charter"
        bsCharter.CancelEdit()
        dsToernverwaltung.Charter.Clear()
        pAdapter.Fill(dsToernverwaltung.Charter)
        bsCharter.Position = 0
        aaa = bsCharter.Count
        Label13.Text = "Anzahl der gespeicherten Charterfirmen: " + aaa
        bsCharter.AddNew()
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        aenderung = False
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        pAdapter.SelectCommand.CommandText = "Select * from Agentur order by Agentur "
        bsAgentur.CancelEdit()
        dsToernverwaltung.Agentur.Clear()
        pAdapter.Fill(dsToernverwaltung.Agentur)
        bsAgentur.Position = 0
        For i = 0 To bsAgentur.Count - 1
            ComboBox1.Items.Add(dsToernverwaltung.Agentur.Rows(i)("Agentur").ToString)
        Next
        If Menü.charterkey > " " Then
            TextBox1.Text = Menü.charterkey
            suchen()
        End If
    End Sub
    Private Sub SpeichernButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernButton.Click
        If aenderung Then
            iii = ListBox1.Items.Count - 1
            For i = 0 To iii
                aaa = ListBox1.Items(i).ToString
                CharterBoot()
            Next
        End If
        speichern()
        SpeichernButton.Text = "Speichern"
    End Sub
    Private Sub CharterBoot()
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsBoot.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & aaa & "' "
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        dsToernverwaltung.Boot.Rows(0)("Charterfirma") = TextBox1.Text
        bsBoot.EndEdit()
        taBoot.Update(dsToernverwaltung.Boot)
    End Sub
    Private Sub speichern()
        '
        '                                Speichern

        '
        If TextBox1.Text > "   " Then
            TextBox8.Text = ComboBox1.Text
            If aenderung Then
                bsCharter.EndEdit()
                taCharter.Update(dsToernverwaltung.Charter)
                iii = 0
            Else
                bsCharter.AddNew()
                taCharter.Update(dsToernverwaltung.Charter)
            End If
            aenderung = False
            Formularloeschen()
        Else
            MsgBox("Firmenname ist Pflichteingabe")
            TextBox1.Focus()
        End If
    End Sub
    Private Sub Formularloeschen()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        ComboBox1.Text = ""
        aenderung = False
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        RichTextBox1.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        dsToernverwaltung.Charter.Clear()
        bsCharter.AddNew()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCharter.Current
        GroupBox2.Text = "Firma auswählen mit Doppelklick"
        GroupBox1.Enabled = False
        Label13.Text = ""
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from Charter  order by charterfirma"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Charter where charterfirma like '%" & TextBox1.Text & "%'  order by charterfirma"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Charter where Mid(charterfirma,1,1) like '%" & TextBox1.Text & "%'  order by charterfirma"
            End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Charter order by charterfirma"
            End If
        bsCharter.CancelEdit()
        '       aenderung = True
        dsToernverwaltung.Charter.Clear()
        xAdapter.Fill(dsToernverwaltung.Charter)
        Select Case bsCharter.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Charter  order by charterfirma"
                xAdapter.Fill(dsToernverwaltung.Charter)
                Formularloeschen()
            Case 1
                bsCharter.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                GroupBox2.Text = "Bemerkung"
                GroupBox1.Enabled = True
                ComboBox1.Text = TextBox8.Text
                BootSuchen()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCharter.Position = position
                DataGridView1.Columns(0).Frozen = True
                DataGridView1.Columns(10).HeaderText = "Fax Nr."
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsCharter.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.Charter.Rows(i)("charterfirma").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        suchen()
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True

    End Sub

    Private Sub FormularloeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormularloeschenButton.Click
        Formularloeschen()
    End Sub

    Private Sub LoeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoeschenButton.Click
        Dim bootname As String
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsBoot.Current
        Dim msg As Integer
        DataGridView1.Visible = True
        GroupBox2.Text = "Crew auswählen mit Doppelklick"
        GroupBox1.Enabled = False
        RichTextBox1.Visible = False
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from boot where charterfirma like '%" & TextBox1.Text & "%'"
        bsBoot.CancelEdit()
        '       aenderung = True
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        If TextBox1.Text > "" Then
            Select Case bsBoot.Count
                Case 0
                    msg = MsgBox(" Die Charterfirma: " & Convert.ToString(TextBox1.Text) & " wird gelöscht.", 1, "Löschen")
                    If msg = vbOK Then
                        bsCharter.RemoveCurrent()
                        taCharter.Update(dsToernverwaltung)
                    End If
                Case Else
                    bootname = dsToernverwaltung.Boot.Rows(0)("Bootname").ToString
                    MsgBox(" Das Boot: " & Convert.ToString(bootname) & " ist noch bei dieser Charterfirma registriert. " & Chr(10) & Chr(13) & "          Löschen ist nicht möglich.")
            End Select
            Formularloeschen()
        Else
            MsgBox("Wähle zuerst eine Firma aus.")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If
    End Sub
    Private Sub BootSuchen()
         Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsBoot.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from boot where charterfirma like '%" & TextBox1.Text & "%' order by bootname"
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        iii = bsBoot.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.Boot.Rows(i)("Bootname").ToString
            ListBox1.Items.Add(aaa)
            Toernsuchen()
        Next

    End Sub
    Private Sub Toernsuchen()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim tp As System.Data.DataRowView = bsToernname.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from toernname where bootsname like '%" & aaa & "%' "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        tAdapter.Fill(dsToernverwaltung.Toernname)
        ij = bsToernname.Count - 1
        For j = 0 To ij
            aaa = dsToernverwaltung.Toernname.Rows(j)("toernbezeichnung").ToString
            ListBox2.Items.Add(aaa)
            ListBox1.Items.Add("   ")
        Next
        ListBox2.Items.Add("   ")

    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If TextBox5.Text = "Ö" Or TextBox5.Text = "ö" Or TextBox5.Text = "A" Or TextBox5.Text = "a" Then
            TextBox5.Text = "Österreich"
        End If
        If TextBox5.Text = "D" Or TextBox5.Text = "d" Then
            TextBox5.Text = "Deutschland"
        End If
        If TextBox5.Text = "P" Or TextBox5.Text = "p" Then
            TextBox5.Text = "Polen"
        End If
    End Sub

    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If ListBox1.Text > " " Then
            Menü.bootkey = ListBox1.Text
            FormUi.ShowChild(Boot)
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = TextBox1.Text.Replace("'", " ")
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If TextBox4.Text > "" Or TextBox3.Text < "0000" Then
        Else
            Dim ppAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rp As System.Data.DataRowView = bsPostleitzahlen.Current
            ppAdapter.SelectCommand = New OleDb.OleDbCommand
            ppAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            ppAdapter.SelectCommand.CommandText = "Select * from postleitzahlen where plz like '" & TextBox3.Text & "' "
            bsPostleitzahlen.CancelEdit()
            dsToernverwaltung.Postleitzahlen.Clear()
            ppAdapter.Fill(dsToernverwaltung.Postleitzahlen)
            If bsPostleitzahlen.Count > 0 Then
                TextBox4.Text = dsToernverwaltung.Postleitzahlen.Rows(0)("ort").ToString
                TextBox5.Text = "Austria"
             End If
        End If

    End Sub
    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label15.Text = "Suchen"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label15.Text = ""
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        aenderung = True
        SpeichernButton.Text = "Änderung speichern"
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        Label15.Text = "Ändern"
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Label15.Text = ""
    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseDoubleClick
        If ListBox2.Text > " " Then
            Menü.bootkey = ListBox1.Text
            Menü.ToernKey = ListBox2.Text
            FormUi.ShowChild(Toern)
        End If

    End Sub

End Class
