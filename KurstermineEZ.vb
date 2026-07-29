Public Class KurstermineEZ
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim teAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aenderung As Boolean
    Public Kursdatum(50, 3) As String
    Public Kursbez As String
    Dim aaa As String
    Public jk As Integer = 0
    Dim ku As String
    Dim fa As String
    Dim k As String
    Dim Testversion As Boolean = False
    Dim f As String
    Dim th As String
    Dim anz As String
    Dim d As String

    Private Sub KurstermineEZ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.taTermine.Fill(Me.DsAusbildung.Termine)
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
        tAdapter.SelectCommand.CommandText = "Select * from teilnehmer order by VZName"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()

        Dim te As System.Data.DataRowView = bsTermine.Current
        teAdapter.SelectCommand = New OleDb.OleDbCommand
        teAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        teAdapter.SelectCommand.CommandText = "Select * from Termine order by VZName"
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        bsTermine.AddNew()
        If Menü.FreischaltZiffer = "2" Or Menü.FreischaltZiffer = "3" Then
            MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt.")
            Testversion = True
        End If


        DataGridView3.Columns(0).Width = 150
 
         MaskedTextBox3.Mask = "##.##.####"
    End Sub
    Private Sub formularloeschen()
        TextBox8.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox19.Text = ""
        MaskedTextBox3.Text = ""
        DataGridView3.Visible = False
        DataGridView1.Visible = False
        aenderung = False
    End Sub
    Private Sub DataGridView3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView3.MouseClick
        suchenteilnehmerE()
        DataGridView3.Visible = False
         CheckBox2.Checked = True
        MaskedTextBox3.Focus()
    End Sub

    '
    '        Kalender
    '
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(100, 100)
        MaskedTextBox3.Text = Today
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        kalender()
    End Sub
    Private Sub kalender()
        MaskedTextBox3.Text = MonthCalendar1.SelectionStart.ToString
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub Button7Speichern_Click(sender As System.Object, e As System.EventArgs) Handles Button7Speichern.Click
        kalender()
    End Sub
    Private Sub Button5Zurueck_Click(sender As System.Object, e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
    End Sub
    '
    '
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        suchenteilnehmerE()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox3.Text = TextBox8.Text
        TextBox1.Text = TextBox12.Text
        TextBox2.Text = TextBox11.Text
        CheckBox2.Checked = True
        CheckBox2.CheckState = 1
        bsTermine.AddNew()
        taTermine.Update(DsAusbildung.Termine)
    End Sub
    Private Sub suchenteilnehmerE()
         DataGridView3.Visible = True
        DataGridView3.Location = New Point(40, 220)
        If TextBox12.Text > "  " Then
            tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox12.Text & "' and fb ='" & TextBox11.Text & "' and vzname = '" & TextBox8.Text & "'   "
        Else
            If TextBox8.Text > "  " Then
                tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where VZName like '%" & TextBox8.Text & "%'  "
            Else
                tAdapter.SelectCommand.CommandText = "Select * from teilnehmer  order by VZName"
            End If
        End If
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        Select Case bsTeilnehmer.Count
            Case 0
                MsgBox("Keine Kurse mit gesuchtem Name vorhanden.")
                DataGridView3.Visible = True
            Case 1
                DataGridView3.Visible = False
            Case Else
                DataGridView3.Visible = True
        End Select
    End Sub

    Private Sub TextBox8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then suchenteilnehmerE()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        kalender()
    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub
End Class