Public Class KurstermineGZ
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

    Private Sub KurstermineGZ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Termine". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTermine.Fill(Me.DsAusbildung.Termine)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Teilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)

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

        Dim kp As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbeginn desc "
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0


        DataGridView3.Columns(0).Width = 150
        DataGridView2.Columns(0).Width = 150
        DataGridView2.Columns(3).Width = 250

        MaskedTextBox2.Mask = "##.##.####"
        CheckBox3.Checked = False
     End Sub


    '   Gruppe eingeben


    Private Sub suchenKurseG()
        TextBox7.Text = RTrim(TextBox7.Text)
        '        TextBox1.Text = TextBox13.Text
        If TextBox6.Text > "  " And TextBox7.Text > "  " Then
            '           tAdapter.SelectCommand.CommandText = "Select * from kurse where VZName = '" & TextBox8.Text & "' and kurs = '" & TextBox7.Text & "' and fb ='" & TextBox6.Text & "'   "
            kAdapter.SelectCommand.CommandText = "Select * from kurse where kursbezeichnung = '" & TextBox7.Text & "' and fahrtbereich ='" & TextBox6.Text & "'  "
        Else
            If TextBox7.Text > "  " Then
                If Len(TextBox7.Text) > 1 Then
                    If Mid(TextBox7.Text, 2, 1) = "*" Then
                        kAdapter.SelectCommand.CommandText = "Select * from kurse   order by  Kursbeginn desc"
                    Else
                        kAdapter.SelectCommand.CommandText = "Select * from kurse  where kursbezeichnung like '%" & TextBox7.Text & "%'  order by  Kursbeginn desc"
                    End If
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from kurse  where Mid(kursbezeichnung,1,1) like '%" & TextBox7.Text & "%'  order by  Kursbeginn desc"
                End If
            End If
        End If
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Keine Kurse mit gesuchtem Namen vorhanden.")
                DataGridView2.Visible = True
            Case 1
                bsKurse.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView2.Visible = False
                 ku = TextBox7.Text
                fa = TextBox6.Text
                tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox7.Text & "' and fb ='" & TextBox6.Text & "' order by vzname  "
                bsTeilnehmer.CancelEdit()
                DsAusbildung.Teilnehmer.Clear()
                tAdapter.Fill(DsAusbildung.Teilnehmer)
                CheckBox3.Checked = False
                For i = 0 To bsTeilnehmer.Count - 1
                    ListBox2.Items.Add(DsAusbildung.Teilnehmer.Rows(i)("vzname").ToString)
                Next
            Case Else
        End Select
    End Sub
    Private Sub formularloeschen()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        DataGridView3.Visible = False
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        aenderung = False
    End Sub
    Private Sub PictureBox10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(100, 100)
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        DataGridView2.Visible = True
        DataGridView2.Location = New Point(40, 280)
        suchenKurseG()
    End Sub
    Private Sub DataGridView2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        DataGridView2.Visible = False
        Kursbez = TextBox7.Text + " " + TextBox6.Text
        suchenKurseG()
        GroupBox2.Focus()
        MaskedTextBox2.Focus()
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            ListBox1.Items.Clear()
            For i = 0 To ListBox2.Items.Count - 1
                ListBox1.Items.Add(ListBox2.Items(i))
            Next
        End If
    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        aaa = ListBox1.Text
        ListBox1.Items.Remove(aaa)
    End Sub
    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridView2.Visible = True
            DataGridView2.Location = New Point(40, 280)
            suchenKurseG()
        End If
        If e.KeyCode = Keys.F5 Then
            DataGridView2.Visible = True
            DataGridView2.Location = New Point(40, 280)
            suchenKurseG()
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        '                     Termine speichern
        If MaskedTextBox2.Text > "  ,  , " And TextBox18.Text > "" And TextBox5.Text > "" Then
            If TextBox7.Text > "" Then
                Dim da As String = CDate(MaskedTextBox2.Text)
                Dim dy As String = da.Substring(0, 2)
                Dim mo As String = da.Substring(3, 2)
                Dim ye As String = da.Substring(6, 4)
                '          year(datumvon) >= '" & TextBox22.Text & "' and year(datumvon) <= '" & TextBox24.Text & "'"
                '           bsTermine.AddNew()
                For i = 0 To ListBox1.Items.Count - 1
                    TextBox1.Text = k
                    TextBox2.Text = f
                    TextBox5.Text = th
                    MaskedTextBox2.Text = d
                    TextBox18.Text = anz
                    TextBox4.Text = ListBox1.Items.Item(i).ToString
                    '              CheckBox3.CheckState = 1
                    CheckBox1.Checked = True
                    CheckBox1.CheckState = 1
                    If Testversion Then
                        MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt. Speichern ist nicht mehr möglich!")
                    Else
                        bsTermine.AddNew()
                        taTermine.Update(DsAusbildung.Termine)
                    End If
                Next
                formularloeschen()
            Else
                MsgBox("Kursname fehlt")
            End If
        Else
            MsgBox("Eingabefelder sind nicht versogt.")
        End If
    End Sub
    Private Sub gruppenDaten()
        k = TextBox7.Text                  ' Kursbezeichnung
        f = TextBox6.Text                  ' Fahrtbereich
        d = MaskedTextBox2.Text            ' Datum
        th = TextBox5.Text                 ' Thema
        anz = TextBox18.Text
    End Sub
    '
    '           Kalender
    '
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        kalender()
    End Sub
    Private Sub kalender()
        MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
        TextBox18.Focus()
        GroupBox6Kalender.Visible = False
    End Sub

    Private Sub TextBox18_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox18.TextChanged

    End Sub
    Private Sub TextBox5_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox5.LostFocus
        gruppenDaten()
    End Sub
End Class