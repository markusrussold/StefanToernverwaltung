Public Class Agentur
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public iij As Integer
    Public j As Integer
    Dim position As Integer
    Dim buch1 As String
    Private Sub Agentur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taPostleitzahlen.Fill(Me.dsToernverwaltung.Postleitzahlen)
        '                                                   R1 für Bankverbindung verwendet
        Me.taCharter.Fill(Me.dsToernverwaltung.Charter)
        Me.taAgentur.Fill(Me.dsToernverwaltung.Agentur)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsAgentur.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Agentur"
        bsAgentur.CancelEdit()
        dsToernverwaltung.Agentur.Clear()
        pAdapter.Fill(dsToernverwaltung.Agentur)
        bsAgentur.Position = 0
        aaa = bsAgentur.Count
        aaa = pAdapter.SelectCommand.CommandText = "Select count from Agentur"

        Label13.Text = "Anzahl der gespeicherten Agenturen: " + aaa
        bsAgentur.AddNew()
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
        GroupBox1.Focus()
        TextBox1.Focus()
    End Sub
    Private Sub SpeichernButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernButton.Click
        If aenderung Then
            iii = ListBox2.Items.Count - 1
            For i = 0 To iii
                aaa = ListBox2.Items(i).ToString
                AgenturCharter()
            Next
        End If
        speichern()
        SpeichernButton.Text = "Speichern"
    End Sub
    Private Sub AgenturCharter()
        Dim sAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rs As System.Data.DataRowView = bsCharter.Current
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from Charter where charterfirma like '%" & aaa & "%' "
        bsCharter.CancelEdit()
        dsToernverwaltung.Charter.Clear()
        sAdapter.Fill(dsToernverwaltung.Charter)
        dsToernverwaltung.Charter.Rows(0)("agentur") = TextBox1.Text
        bsCharter.EndEdit()
        taCharter.Update(dsToernverwaltung.Charter)
    End Sub
    Private Sub speichern()
        '
        '                                Speichern
        '
        If TextBox1.Text > " " Then
            If aenderung Then
                bsAgentur.EndEdit()
                taAgentur.Update(dsToernverwaltung.Agentur)
                iii = 0
            Else
                bsAgentur.AddNew()
                taAgentur.Update(dsToernverwaltung.Agentur)
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
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        aenderung = False
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        RichTextBox1.Text = ""
        dsToernverwaltung.Agentur.Clear()
        bsAgentur.AddNew()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsAgentur.Current
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
                    xAdapter.SelectCommand.CommandText = "Select * from Agentur  order by Agentur"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Agentur where Agentur like '%" & TextBox1.Text & "%'  order by Agentur"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Agentur where Mid(Agentur,1,1) like '%" & TextBox1.Text & "%'  order by Agentur"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Agentur order by Agentur"
        End If
        bsAgentur.CancelEdit()
        '       aenderung = True
        dsToernverwaltung.Agentur.Clear()
        xAdapter.Fill(dsToernverwaltung.Agentur)
        Select Case bsAgentur.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Agentur  order by Agentur"
                xAdapter.Fill(dsToernverwaltung.Agentur)
                Formularloeschen()
            Case 1
                bsAgentur.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                GroupBox2.Text = "Bemerkung"
                GroupBox1.Enabled = True
                Chartersuchen()
                '               BootSuchen()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsAgentur.Position = position
                DataGridView1.Columns(0).Frozen = True
                DataGridView1.Columns(10).HeaderText = "Fax Nr."
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsAgentur.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.Agentur.Rows(i)("Agentur").ToString, 1, 1).ToUpper
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
         Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsAgentur.Current
        Dim msg As Integer
        DataGridView1.Visible = True
        GroupBox2.Text = "Crew auswählen mit Doppelklick"
        GroupBox1.Enabled = False
        RichTextBox1.Visible = False
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from agentur where Agentur like '%" & TextBox1.Text & "%'"
        bsAgentur.CancelEdit()
        '        aenderung = True
        dsToernverwaltung.Agentur.Clear()
        pAdapter.Fill(dsToernverwaltung.Agentur)
        If TextBox1.Text > "" Then
            Select Case bsAgentur.Count
                Case 1
                    msg = MsgBox(" Die Agenturfirma:wird gelöscht.", 1, "Löschen")
                    If msg = vbOK Then
                        bsAgentur.RemoveCurrent()
                        taAgentur.Update(dsToernverwaltung)
                    End If
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
        pAdapter.SelectCommand.CommandText = "Select * from boot where Charterfirma like '%" & aaa & "%' order by Bootname"
        '       ListBox1.Items.Clear()
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        iii = bsBoot.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.Boot.Rows(i)("Bootname").ToString
            ListBox1.Items.Add(aaa)
        Next
        ListBox1.Sorted = True
    End Sub
    Private Sub Chartersuchen()
        Dim sAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rs As System.Data.DataRowView = bsCharter.Current
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from Charter where Agentur like '%" & TextBox1.Text & "%' order by charterfirma"
        ListBox1.Items.Clear()
        bsCharter.CancelEdit()
        dsToernverwaltung.Charter.Clear()
        sAdapter.Fill(dsToernverwaltung.Charter)
        iij = bsCharter.Count - 1
        For Me.j = 0 To iij
            aaa = dsToernverwaltung.Charter.Rows(j)("Charterfirma").ToString
            ListBox2.Items.Add(aaa)
            BootSuchen()
        Next

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
            Boot.Show()
        End If
    End Sub

    Private Sub ListBox2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseDoubleClick
        If ListBox2.Text > " " Then
            Menü.charterkey = ListBox2.Text
            Charter.Show()
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
    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        Label15.Text = "Ändern"
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Label15.Text = ""
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        aenderung = True
        SpeichernButton.Text = "Änderung speichern"
    End Sub
End Class