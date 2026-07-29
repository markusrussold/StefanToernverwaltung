Public Class Werbung
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public iij As Integer
    Public j As Integer
    Public datumZ As Single
    Private Sub Werbung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Listbox". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taListbox.Fill(Me.DsAusbildung.Listbox)
        Me.taWerbemassnahme.Fill(Me.DsAusbildung.Werbemassnahme)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsWerbemassnahme.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme"
        bsWerbemassnahme.CancelEdit()
        DsAusbildung.Werbemassnahme.Clear()
        pAdapter.Fill(DsAusbildung.Werbemassnahme)
        bsWerbemassnahme.Position = 0
        bsWerbemassnahme.AddNew()
        With DataGridView1
            .Columns(0).Width = 150
            .Columns(6).Width = 450
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        DataGridView1.Visible = False
        aenderung = False
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Listbox where Formularname like 'Werbung - Werbeart' "
        bsListbox.CancelEdit()
        DsAusbildung.Listbox.Clear()
        pAdapter.Fill(DsAusbildung.Listbox)
        bsListbox.Position = 0
        If bsListbox.Count = 1 Then
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld1").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld2").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld3").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld4").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld5").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld6").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld7").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld8").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld9").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld10").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld11").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld12").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld13").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld14").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld15").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld16").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld17").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld18").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld19").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld20").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld21").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld22").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld23").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld24").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld25").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld26").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld27").ToString)
            comboFuellen(DsAusbildung.Listbox.Rows(0)("Feld28").ToString)
        End If
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"

    End Sub
    Private Sub comboFuellen(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox1.Items.Add(text)
            End If
        End If
    End Sub
    Private Sub speichern()
        '
        '                                Speichern
        TextBox5.Text = Menü.werbungg
        '
        If TextBox1.Text > " " Then
            TextBox4.Text = ComboBox1.Text
            If aenderung Then
                bsWerbemassnahme.EndEdit()
                taWerbemassnahme.Update(DsAusbildung.Werbemassnahme)
                iii = 0
            Else
                bsWerbemassnahme.AddNew()
                taWerbemassnahme.Update(DsAusbildung.Werbemassnahme)
            End If
            aenderung = False
            Formularloeschen()

        Else
            MsgBox("Kursbezeichnung ist Pflichteingabe")
            TextBox1.Focus()
        End If

    End Sub
    Private Sub Formularloeschen()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        aenderung = False
        DataGridView1.Visible = False
        RichTextBox1.Text = ""
        DsAusbildung.Werbemassnahme.Clear()
        bsWerbemassnahme.AddNew()
    End Sub
    Private Sub suchen_allg()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsWerbemassnahme.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme  order by Datumbeginn desc"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme where Kurs like '%" & TextBox1.Text & "%'  order by Datumbeginn desc"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme where Mid(Kurs,1,1) like '%" & TextBox1.Text & "%'  order by Datumbeginn desc"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme order by Datumbeginn desc"
        End If
        bsWerbemassnahme.CancelEdit()
        aenderung = True
        DsAusbildung.Werbemassnahme.Clear()
        xAdapter.Fill(DsAusbildung.Werbemassnahme)
        Select Case bsWerbemassnahme.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme  order by Datumbeginn desc"
                xAdapter.Fill(DsAusbildung.Werbemassnahme)
                Formularloeschen()
            Case 1
                bsWerbemassnahme.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                ComboBox1.Text = TextBox4.Text
            Case Else
                DataGridView1.Columns(0).Frozen = True
                DataGridView1.Visible = True
        End Select
    End Sub
    Private Sub suchen_torn()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsWerbemassnahme.Current
        Dim torn As String = "Törn"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme  and betrifft = '" & torn & "'  order by Datumbeginn desc"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme where Kurs like '%" & TextBox1.Text & "%' and betrifft = '" & torn & "' order by Datumbeginn desc"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme where Mid(Kurs,1,1) like '%" & TextBox1.Text & "%'  and betrifft = '" & torn & "'  order by Datumbeginn desc"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme  where betrifft = '" & torn & "' order by Datumbeginn desc"
        End If
        bsWerbemassnahme.CancelEdit()
        aenderung = True
        DsAusbildung.Werbemassnahme.Clear()
        xAdapter.Fill(DsAusbildung.Werbemassnahme)
        Select Case bsWerbemassnahme.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme where betrifft = '" & torn & "'  order by Datumbeginn desc"
                xAdapter.Fill(DsAusbildung.Werbemassnahme)
                Formularloeschen()
            Case 1
                bsWerbemassnahme.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                ComboBox1.Text = TextBox4.Text
            Case Else
                DataGridView1.Columns(0).Frozen = True
                DataGridView1.Visible = True
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        speichern()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Menü.werbungg = "Törn" Then
                suchen_torn()
            Else
                suchen_allg()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Menü.werbungg = "Törn" Then
            suchen_torn()
        Else
            suchen_allg()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Formularloeschen()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.Visible = False
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Button7Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7Speichern.Click
        If datumZ = 1 Then MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        If datumZ = 2 Then MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub Button5Zurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If datumZ = 1 Then
            MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
            MaskedTextBox1.Focus()
        Else
            MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
            MaskedTextBox2.Focus()
        End If
        GroupBox6Kalender.Visible = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(600, 100)
        datumZ = 2
    End Sub

    Private Sub PictureBox10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(600, 100)
        datumZ = 1

    End Sub

    Private Sub BtAktionDruck_Click(sender As System.Object, e As System.EventArgs) Handles BtAktionDruck.Click
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsWerbemassnahme.Current
        Dim torn As String = "Törn"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        xAdapter.SelectCommand.CommandText = "Select * from Werbemassnahme where Kurs like '%" & TextBox1.Text & "%' and fb = '" & TextBox2.Text & "' order by Datumbeginn desc"
        bsWerbemassnahme.CancelEdit()
        DsAusbildung.Werbemassnahme.Clear()
        xAdapter.Fill(DsAusbildung.Werbemassnahme)
        If bsWerbemassnahme.Count = 0 Then
            MsgBox("Diese Aktion wurde noch nicht beworben.")
        Else
            Dim Xs As New PrintOutWE
            Dim dv As DataView
            Dim t As DataTable
            dv = bsWerbemassnahme.List
            t = dv.ToTable("Printing", False, "Kurs", "FB", "DatumBeginn", "Werbeart", "Werbeort", "Werbedatum", "Betrifft", "Werbekosten", "Bemerkung")
            Xs.PrintWerbung(t)
            Me.Cursor = Cursors.Default
            Me.Close()
        End If

    End Sub
End Class