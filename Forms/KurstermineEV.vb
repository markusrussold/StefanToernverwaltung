Public Class KurstermineEV
    '    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim teAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aenderung As Boolean
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

    Private Sub KurstermineEV_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Termine". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTermine.Fill(Me.DsAusbildung.Termine)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Teilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        formularloeschen()
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        '       Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        '      tAdapter.SelectCommand = New OleDb.OleDbCommand
        'tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        'tAdapter.SelectCommand.CommandText = "Select * from teilnehmer order by VZName"
        '        DsAusbildung.Teilnehmer.Clear()
        '       tAdapter.Fill(DsAusbildung.Teilnehmer)
        '      bsTeilnehmer.AddNew()

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
        aaa = bsTermine.Count

        '            DataGridView3.Columns(0).Width = 150

        MaskedTextBox3.Mask = "##.##.####"
    End Sub
    Private Sub formularloeschen()
        TextBox8.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox19.Text = ""
        TextBox12.Text = ""
        MaskedTextBox3.Text = ""
        DataGridView3.Visible = False
        DataGridView1.Visible = False
        aenderung = False
    End Sub
    Private Sub DataGridView3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView3.MouseClick
        '       d = TextBox4.Text
        d = MaskedTextBox3.Text
        suchenterminE()
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
        suchenterminE()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '        TextBox3.Text = TextBox8.Text
        '       TextBox1.Text = TextBox12.Text
        '      TextBox2.Text = TextBox11.Text
        CheckBox2.Checked = True
        CheckBox2.CheckState = 1
        bsTermine.EndEdit()
        taTermine.Update(DsAusbildung.Termine)
    End Sub
    Private Sub suchenterminE()
        DataGridView3.Visible = True
        DataGridView3.Location = New Point(40, 220)
        Dim te As System.Data.DataRowView = bsTermine.Current
        teAdapter.SelectCommand = New OleDb.OleDbCommand
        teAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        If TextBox12.Text > "  " Then
            If d > "" Then
                Dim datum As Date
                If Not SafeData.TryParseMaskedDate(MaskedTextBox3.Text, datum) Then
                    MsgBox("Datum hat falsches Format")
                    MaskedTextBox3.Focus()
                    Exit Sub
                End If
                Dim tag As Integer = datum.Day
                Dim mon As Integer = datum.Month
                Dim jahr As Integer = datum.Year
                '         teAdapter.SelectCommand.CommandText = "Select * from termine where  year(datum) = '" & jahr & "' and month(datum) = '" & mon & "'  and   day(datum) = '" & tag & "' " '  "
                teAdapter.SelectCommand.CommandText = "Select * from Termine where fahrtbereich ='" & TextBox11.Text & "' and year(datum) = '" & jahr & "' and month(datum) = '" & mon & "' and VZName = '" & TextBox8.Text & "' and Kursbezeichnung = '" & TextBox12.Text & "' and   day(datum) = '" & tag & "' " '  "
            Else
                '                tAdapter.SelectCommand.CommandText = "Select * from termine where kursbezeichnung = '" & TextBox12.Text & "' and fahrtbereich ='" & TextBox11.Text & "' and vzname = '" & TextBox8.Text & "'   "
                teAdapter.SelectCommand.CommandText = "Select * from termine where kursbezeichnung = '" & TextBox12.Text & "'  "
            End If
        Else
            If TextBox8.Text > "  " Then
                teAdapter.SelectCommand.CommandText = "Select * from termine where VZName like '%" & TextBox8.Text & "%'  "
            Else
                teAdapter.SelectCommand.CommandText = "Select * from termine  order by VZName"
            End If
        End If
        bsTermine.CancelEdit()
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        Select Case bsTermine.Count
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
        If e.KeyCode = Keys.Enter Then suchenterminE()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        kalender()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        bsTermine.RemoveCurrent()
        taTermine.Update(DsAusbildung)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        formularloeschen()
    End Sub
End Class