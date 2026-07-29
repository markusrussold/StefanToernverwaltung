Public Class Kursteilnehmer1
    Dim aenderung As Boolean
    Dim VNaenderung As Boolean
    Dim kostendatum As Boolean
    Dim iii As Integer
    Dim position As Integer
    Dim buch1 As String
    Dim aaa As String
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim Testversion As Boolean = False

    Private Sub Kursteilnehmer1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.MaterialKurs". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taMaterialKurs.Fill(Me.DsAusbildung.MaterialKurs)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        formularloeschen()
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        ' ThenByDescending
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        bsCrewAdressen.AddNew()

        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by VZName"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.AddNew()
        If Menü.FreischaltZiffer = "2" Or Menü.FreischaltZiffer = "3" Then
            MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt.")
            Testversion = True
        End If

        Dim kp As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0
        bsKurse.AddNew()

        Dim mk As System.Data.DataRowView = bsMaterialKurs.Current
        mkAdapter.SelectCommand = New OleDb.OleDbCommand
        mkAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        mkAdapter.SelectCommand.CommandText = "Select * from Materialkurs order by VZName"
        DsAusbildung.MaterialKurs.Clear()
        mkAdapter.Fill(DsAusbildung.MaterialKurs)
        Dim iip As Integer
        Dim pi As Integer
        If bsMaterialKurs.Count > 0 Then
            iip = bsMaterialKurs.Count - 1
            For pi = 0 To iip
                If DsAusbildung.MaterialKurs.Rows(0)("Kurs").ToString > " " Then
                Else
                    bsMaterialKurs.RemoveCurrent()
                    taMaterialKurs.Update(DsAusbildung)
                End If
            Next
        End If

        MaskedTextBox3.Mask = "00.00.0000"
        MaskedTextBox4.Mask = "00.00.0000"
        GroupBox3.Location = New Point(2400, 1)
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""

    End Sub
    Private Sub formularloeschen()
        Label10.Visible = False
         DsAusbildung.Teilnehmer.Clear()
        '       TextBox21.Text = ""
        '      TextBox22.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Items.Clear()
     End Sub
    Private Sub suchencrew()
        GroupBox6.Location = New Point(2400, 1)
        GroupBox3.Location = New Point(24, 188)
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        '        GroupBox1.Enabled = False
        position = 0
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox1.Text & "%' order by zuname"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen where  Mid(zuname,1,1) like '%" & TextBox1.Text & "%'  order by zuname"
            End If

        Else
            xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        End If
        bsCrewAdressen.CancelEdit()
        aenderung = True
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                xAdapter.Fill(dsToernverwaltung.CrewAdressen)
                '               Formularloeschen()
            Case 1
                bsTeilnehmer.AddNew()
                bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                If dsToernverwaltung.CrewAdressen.Rows(0)("Clubmitglied").ToString Then
                    Label10.Visible = True
                End If
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCrewAdressen.Position = position
        End Select
    End Sub
    Private Sub suchenKurs()
        GroupBox3.Location = New Point(2400, 1)
        GroupBox6.Location = New Point(24, 188)
        If TextBox3.Text > "  " Then
            kAdapter.SelectCommand.CommandText = "Select * from Kurse where Kursbezeichnung = '" & TextBox21.Text & "' and Fahrtbereich = '" & TextBox3.Text & "' "
        Else
            If TextBox21.Text > "  " Then
                If Len(TextBox21.Text) > 1 Then
                    If Mid(TextBox21.Text, 2, 1) = "*" Then
                        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung, Fahrtbereich"
                    Else
                        kAdapter.SelectCommand.CommandText = "Select * from Kurse where Kursbezeichnung like '%" & TextBox21.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
                    End If
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from Kurse where Mid(Kursbezeichnung,1,1) like '%" & TextBox21.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
                End If
            Else
                kAdapter.SelectCommand.CommandText = "Select * from Kurse order by Kursbezeichnung, Fahrtbereich"
            End If
        End If
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Kein Kurs mit angegebenen Buchstabenkombination vorhanden")
                kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
                DsAusbildung.Kurse.Clear()
                kAdapter.Fill(DsAusbildung.Kurse)
            Case 1
                bsKurse.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis1").ToString)
                ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis2").ToString)
                ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(0)("Preis3").ToString)
                suchenTeilnehmer()
            Case Else
                DataGridView1.Columns(0).Frozen = True
        End Select
    End Sub
    Private Sub suchenTeilnehmer()
        Dim tln As String
        Dim rete As MsgBoxResult
        If TextBox1.Text > "  " And TextBox21.Text > "  " And TextBox22.Text > "  " Then
            tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where VZName = '" & TextBox1.Text & "' and kurs = '" & TextBox21.Text & "' and fb ='" & TextBox22.Text & "'   "
        End If
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        Select Case bsTeilnehmer.Count
            Case 0
                aenderung = False
            Case 1
                ComboBox1.Text = TextBox6.Text
                aenderung = True
            Case Else
                MsgBox("Teilnehmer ist mehrmals dem Kurs zugeordnet.")
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsCrewAdressen.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub ButtonLeeren_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLeeren.Click
        formularloeschen()
    End Sub

    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        If aenderung = False Then
            bsTeilnehmer.AddNew()
            TextBox6.Text = ComboBox1.Text
            TextBox2.Text = TextBox1.Text
            TextBox5.Text = TextBox21.Text
            TextBox3.Text = TextBox22.Text
            If IsDBNull(TextBox4.Text) Then
                TextBox4.Text = 0
            End If
            If Testversion Then
                MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt. Speichern ist nicht mehr möglich!")
            Else
                TextBox6.Text = ComboBox1.Text
                bsTeilnehmer.AddNew()
                taTeilnehmer.Update(DsAusbildung.Teilnehmer)
            End If
        Else
            TextBox6.Text = ComboBox1.Text
            bsTeilnehmer.EndEdit()
            taTeilnehmer.Update(DsAusbildung.Teilnehmer)
        End If

        If VNaenderung Then
            bsTeilnehmer.EndEdit()
            taTeilnehmer.Update(DsAusbildung.Teilnehmer)
        End If
        aenderung = False
        ButtonSpeichern.Text = "Speichern"

        formularloeschen()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        suchenKurs()
        GroupBox6.Location = New Point(2400, 1)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchencrew()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        suchenKurs()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchencrew()
        End If
    End Sub

    Private Sub TextBox21_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox21.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenKurs()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostendatum = False
    End Sub
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If kostendatum Then
            MaskedTextBox3.Text = MonthCalendar1.SelectionStart.ToString
        Else
            MaskedTextBox4.Text = MonthCalendar1.SelectionStart.ToString
        End If
        GroupBox6Kalender.Visible = False
    End Sub

    Private Sub Button5Zurueck_Click(sender As System.Object, e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
        MaskedTextBox4.Focus()
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)
        kostendatum = True
    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As System.EventArgs) Handles ComboBox1.GotFocus
        GroupBox6.Location = New Point(2400, 1)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim msg As Integer
        msg = MsgBox(" Teilnehmer: " & Convert.ToString(TextBox1.Text) & " wird aus den Kurs gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            mkAdapter.SelectCommand.CommandText = "Select * from MaterialKurs where vzname = '" & TextBox1.Text & "' and kurs = '" & TextBox21.Text & "' and fb = '" & TextBox22.Text & "' order by VZName"
            DsAusbildung.MaterialKurs.Clear()
            mkAdapter.Fill(DsAusbildung.MaterialKurs)
            For ii = 0 To bsMaterialKurs.Count - 1
                bsMaterialKurs.RemoveCurrent()
                taMaterialKurs.Update(DsAusbildung)
            Next
            bsTeilnehmer.RemoveCurrent()
            taTeilnehmer.Update(DsAusbildung)
            formularloeschen()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        suchencrew()
        GroupBox3.Location = New Point(2400, 1)
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        Label6.Text = "Name ändern"
    End Sub
    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        Label6.Text = ""
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseHover
        Label7.Text = "Suchen"
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label7.Text = ""
    End Sub
    Private Sub PictureBox5_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseHover
        Label8.Text = "Datum"
    End Sub
    Private Sub PictureBox5_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseLeave
        Label8.Text = ""
    End Sub
    Private Sub PictureBox7_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseHover
        Label9.Text = "Datum"
    End Sub
    Private Sub PictureBox7_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseLeave
        Label9.Text = ""
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseHover
        Label7.Text = "Suchen"
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        Label7.Text = ""
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        VNaenderung = True
        ButtonSpeichern.Text = "Änderung speichern"
    End Sub
End Class