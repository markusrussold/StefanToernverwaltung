Public Class Kurs
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public iij As Integer
    Dim SatzAnzahl As String
    Dim buch1 As String
    Dim position As String
    Dim ort_temp As String
    Dim Testversion As Boolean = False
    Dim beitrag As Single = 1000
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Public j As Integer
    Private Sub Kurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Listbox". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taListbox.Fill(Me.DsAusbildung.Listbox)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Standort". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taStandort.Fill(Me.DsAusbildung.Standort)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Standort". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taStandort.Fill(Me.DsAusbildung.Standort)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsKurse.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Kurse"
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        pAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0
        SatzAnzahl = bsKurse.Count
        Label8.Text = "Anzahl der gespeicherten Kurse: " + SatzAnzahl
        bsKurse.AddNew()
        If Menü.FreischaltZiffer = "2" Or Menü.FreischaltZiffer = "3" Then
            MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt.")
            Testversion = True
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        DataGridView1.Visible = False
        MaskedTextBox1.Mask = "00.00.0000"                    '  Kursbeginn
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from listbox where FormularName like 'Kurse - Kursart' "
        bsListbox.CancelEdit()
        DsAusbildung.Listbox.Clear()
        pAdapter.Fill(DsAusbildung.Listbox)
        bsListbox.Position = 0
        If bsListbox.Count = 1 Then
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld1").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld2").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld3").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld4").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld5").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld6").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld7").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld8").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld9").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld10").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld11").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld12").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld13").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld14").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld15").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld16").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld17").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld18").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld19").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld20").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld21").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld22").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld23").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld24").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld25").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld26").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld27").ToString)
            '           comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        Formularloeschen()
    End Sub
    Private Sub comboFuellen1(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox1.Items.Add(text)
            End If
        End If
    End Sub
    Private Sub speichern()
        '
        '                                Speichern

        '
        DataGridView2.Visible = False
        TextBox12.Text = TextBox10.Text
        TextBox13.Text = TextBox11.Text
        TextBox15.Text = ComboBox1.Text
        If TextBox1.Text > " " Then
            If aenderung Then
                bsKurse.EndEdit()
                taKurse.Update(DsAusbildung.Kurse)
                iii = 0
            Else
                If Testversion Then
                    MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt. Speichern ist nicht mehr möglich!")
                Else
                    bsKurse.AddNew()
                    taKurse.Update(DsAusbildung.Kurse)
                End If
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
        TextBox4.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox14.Text = ""
        Button3.Text = "Kursteilnemher zeigen"
        MaskedTextBox1.Text = ""
        aenderung = False
        DataGridView1.Visible = False
        RichTextBox1.Text = ""
        dsausbildung.Kurse.Clear()
        bsKurse.AddNew()
        GroupBox1.Enabled = True
        DataGridView1.Visible = True
        ComboBox1.Text = ""
        TeilnehmerDGV.Location = New Point(1119, 203)
        DataGridView1.Location = New Point(1200, 403)
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsKurse.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        Label8.Text = ""
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    xAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung, Fahrtbereich"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Kurse where Kursbezeichnung like '%" & TextBox1.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Kurse where Mid(Kursbezeichnung,1,1) like '%" & TextBox1.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Kurse order by Kursbeginn desc"
        End If
        bsKurse.CancelEdit()
        aenderung = True
        dsausbildung.Kurse.Clear()
        xAdapter.Fill(dsausbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
                xAdapter.Fill(dsausbildung.Kurse)
                Formularloeschen()
            Case 1
                bsKurse.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                Preise()
                TextBox11.Text = TextBox13.Text
                TextBox10.Text = TextBox12.Text
                ComboBox1.Text = TextBox15.Text
                Label6.Visible = True
                RichTextBox1.Visible = True
            Case Else
                DataGridView1.Columns(0).Frozen = True
                DataGridView1.Visible = True
                Label6.Visible = False
                RichTextBox1.Visible = False
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        speichern()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If

    End Sub

    Private Sub Preise()
        If TextBox7.Text > "0" Then
            beitrag = TextBox7.Text
            TextBox6.Text = beitrag.ToString("##,#0.00") + " €"
        End If
        If TextBox27.Text > "0" Then
            beitrag = TextBox27.Text
            TextBox5.Text = beitrag.ToString("##,#0.00") + " €"
        End If
        If TextBox4.Text > "0" Then
            beitrag = TextBox4.Text
            TextBox3.Text = beitrag.ToString("##,#0.00") + " €"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Formularloeschen()
    End Sub
    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        DataGridView1.Visible = False
        RichTextBox1.Visible = True
        Label6.Visible = True
        GroupBox1.Enabled = True
        '      Preise()
        suchen()
        TextBox14.Text = TextBox10.Text
    End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox4.Text = TextBox3.Text
    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox27.Text = TextBox5.Text
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        TextBox7.Text = TextBox6.Text
    End Sub

    '               Kalender
    Private Sub Button7Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7Speichern.Click
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        MaskedTextBox1.Focus()
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub Button5Zurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Kursteilnemher drucken" Then
            Button3.Text = "Kursteilnemher zeigen"
            Dim XL As New PrintoutKT
            Dim dv As DataView
            Dim t As DataTable
            SatzAnzahl = bsTeilnehmer.Count
            dv = bsTeilnehmer.List
            t = dv.ToTable("Printing", False, "VZname", "Kurs", "FB", "Kurspreis", "Kursbezahlt", "materialpreis", "materialbezahlt")
            XL.PrintTeilnehmerListe(t)
        Else
            Dim rt As System.Data.DataRowView = bsTeilnehmer.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox1.Text & "' "
            bsTeilnehmer.CancelEdit()
            DsAusbildung.Teilnehmer.Clear()
            tAdapter.Fill(DsAusbildung.Teilnehmer)
            bsTeilnehmer.Position = 0
            SatzAnzahl = bsTeilnehmer.Count
            Label8.Text = "Anzahl der Teilnehmer des Kurses: " + SatzAnzahl
            TeilnehmerDGV.Location = New Point(25, 275)
            DataGridView1.Visible = False
            Button3.Text = "Kursteilnemher drucken"
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(TextBox1.Text) > 25 Then
            MsgBox(" DieLänge des Kursnamens ist auf 25 Zeichen beschränkt")
            TextBox1.Text = TextBox1.Text.Substring(0, 25)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        '      GroupBox1.Enabled = False
        DataGridView1.Location = New Point(10, 250)
        RichTextBox1.Visible = False
        Label6.Visible = False
        suchen()
    End Sub
    Private Sub SuchenOrt()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsStandort.Current
        DataGridView2.Visible = True
        '      Richtextbox10.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        '       TextBox18.Text = RTrim(TextBox18.Text)
        If TextBox10.Text > "  " Then
            If Len(TextBox10.Text) > 1 Then
                If Mid(TextBox10.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox10.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Standort where Bezeichnung like '%" & TextBox10.Text & "%'  order by Bezeichnung"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Standort where Mid(Bezeichnung,1,1) like '%" & TextBox10.Text & "%'  order by Bezeichnung"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsStandort.CancelEdit()
        DsAusbildung.Standort.Clear()
        xAdapter.Fill(DsAusbildung.Standort)
        Dim msgOKNo As MsgBoxResult
        Select Case bsStandort.Count
            Case 0
                msgOKNo = MsgBox("Es ist kein Standort mit angegebenen Buchstabenkombination in der Datenbank gespeichert. Soll dieser als Kursstandort gespeichert werden?", 4)
                If msgOKNo = vbNo Then
                    xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
                    xAdapter.Fill(DsAusbildung.Standort)
                    Formularloeschen()
                Else
                    TextBox10.Text = ort_temp
                End If
            Case 1
                bsStandort.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                DataGridView2.Location = New Point(10, 2500)
                TextBox14.Text = TextBox10.Text
            Case Else
                position = 0
                If buch1 > " " Then
                    positionierenOrt()
                End If
                buch1 = ""
                bsStandort.Position = position
                DataGridView2.Visible = True
                DataGridView2.Location = New Point(10, 250)
                DataGridView2.Size = New Point(543, 160)
        End Select
    End Sub
    Private Sub positionierenOrt()
        iii = bsStandort.Count - 1
        For i = 0 To iii
            aaa = Mid(DsAusbildung.Standort.Rows(i)("Bezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub DataGridView2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        TextBox14.Text = TextBox10.Text
        SuchenOrt()
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        TextBox10.Text = TextBox14.Text
        SuchenOrt()
    End Sub

    Private Sub TextBox1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            '         GroupBox1.Enabled = False
            DataGridView1.Location = New Point(10, 250)
            suchen()
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If
    End Sub

 
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(250, 100)

    End Sub

    Private Sub TextBox14_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox14.LostFocus
        DataGridView2.Location = New Point(10, 250)
        DataGridView2.Size = New Point(543, 160)
        ort_temp = TextBox14.Text
        TextBox10.Text = TextBox14.Text
        SuchenOrt()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KursLoeschen.Click
          Dim msg As MsgBoxResult
        msg = MsgBox(" Kurs: " & Convert.ToString(TextBox1.Text) & " - " & Convert.ToString(TextBox2.Text) & " und alle Teilnehmer werden gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            Dim rt As System.Data.DataRowView = bsTeilnehmer.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox1.Text & "' and fb = '" & TextBox2.Text & "' "
            bsTeilnehmer.CancelEdit()
            DsAusbildung.Teilnehmer.Clear()
            tAdapter.Fill(DsAusbildung.Teilnehmer)
            bsTeilnehmer.Position = 0
            For i = 0 To bsTeilnehmer.Count - 1
                bsTeilnehmer.RemoveCurrent()
                taTeilnehmer.Update(DsAusbildung)

            Next
            bsKurse.RemoveCurrent()
            taKurse.Update(DsAusbildung)
            Formularloeschen()
            bsKurse.AddNew()
        End If
    End Sub
End Class