Public Class SchadenY
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim sAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Dim bbb As String
    Dim aenderung As Boolean
    Dim foto As Image
    Dim msgAntw As String
    Dim path As String
    Dim textV As String
    Dim textboxNr As Single
    Dim anhang As String

    Private Sub SchadenY_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taVersicherter.Fill(Me.dsVersicherung.Versicherter)
        Me.taSchaden.Fill(Me.dsVersicherung.Schaden)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height

        Dim r As System.Data.DataRowView = bsVersicherter.Current
        Dim rr As System.Data.DataRowView = bsToernname.Current
        Dim rs As System.Data.DataRowView = bsSchaden.Current
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from Schaden  "
        bsSchaden.CancelEdit()
        dsVersicherung.Schaden.Clear()
        sAdapter.Fill(dsVersicherung.Schaden)
        bsSchaden.AddNew()
        aaa = bsSchaden.Count

        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.AddNew()

        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
        bsVersicherter.CancelEdit()
        dsVersicherung.Versicherter.Clear()
        tAdapter.Fill(dsVersicherung.Versicherter)
        bsVersicherter.AddNew()

        ButtonSpeichern.Enabled = False
        ButtonSpeichern.Visible = False
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00:00"
        gbBemerkung.Visible = False
        RadioNeu.Checked = False
        RadioButton5.Checked = False
        Fenster("l")
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsVersicherter.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        '       TextBox78.Text = RTrim(TextBox78.Text)
        If TextBox7.Text > "  " Then
            If Len(TextBox7.Text) > 1 Then
                If Mid(TextBox7.Text, 2, 1) = "*" Then
                    tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from Versicherter where Polizze like '%" & TextBox7.Text & "%'  order by Polizze"
                End If
            Else
                tAdapter.SelectCommand.CommandText = "Select * from Versicherter where Mid(Polizze,1,1) like '%" & TextBox7.Text & "%'  order by Polizze"
            End If
        Else
            tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
        End If
        With dgvToern
            .Columns(0).Width = 150
        End With
        With dgvToern.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsVersicherter.CancelEdit()
        dsVersicherung.Versicherter.Clear()
        tAdapter.Fill(dsVersicherung.Versicherter)
        DbAccess.SafePosition(bsVersicherter)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        Select Case bsVersicherter.Count
            Case 0
                MsgBox("Kein Versicherter mit angegebenen Buchstabenkombination vorhanden")
                tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
                tAdapter.Fill(dsVersicherung.Versicherter)
                Fenster("v")
            Case 1
                bbb = SafeData.FormatDateDe(dsVersicherung.Versicherter.Rows(0)("Abschlussdatum"))
                aaa = SafeData.FormatDateDe(dsVersicherung.Versicherter.Rows(0)("Gueltigbis"))
                Label21.Text = bbb + " bis " + aaa
                Fenster("b")
                TextBox34.Focus()
            Case Else
                DbAccess.SafePosition(bsVersicherter)
                dgvToern.Visible = True
                Fenster("v")
        End Select
    End Sub
     Private Sub Fenster(ByVal Inhalt)
        '       RichTextBox2.Location = New Point(2000, 2000)
        '        dgvSchaden.Location = New Point(2500, 2500)
        '       dgvToern.Location = New Point(3000, 3000)
        gbtoern.Location = New Point(10002, 12300)
        gbBemerkung.Location = New Point(10200, 30000)
        gbFenster.Location = New Point(2000, 2000)
        gbNeu.Location = New Point(2000, 2000)
        gbSchadenmeldung.Location = New Point(2300, 3200)
        '       gbBemerkung.Focus()
        Select Case Inhalt
            Case "n"
                gbNeu.Location = New Point(12, 300)
                gbNeu.Text = "Polizze auswählen mit Doppelklick"
            Case "v"
                gbFenster.Location = New Point(12, 300)
                gbFenster.Text = "Polizze auswählen mit Doppelklick"
                '             dgvSchaden.Location = New Point(23, 320)
            Case "t"
                gbtoern.Location = New Point(12, 300)
                gbFenster.Text = "Torn auswählen mit Doppelklick"
                '         dgvToern.Location = New Point(23, 320)
            Case "b"
                gbBemerkung.Visible = True
                gbBemerkung.Location = New Point(12, 300)
           Case "s"
                '              gbBemerkung.Location = New Point(2212, 3200)
                gbSchadenmeldung.Location = New Point(12, 300)
            Case "l"
                gbschnell.Location = New Point(12, 13)
                gbHaftschaden.Location = New Point(2000, 1500)
                RadioNeu.Checked = False
                RadioButton5.Checked = False
        End Select
    End Sub
    Private Sub suchenToern()
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox13.Text & "' "
        If TextBox13.Text > "  " Then
            If IsNumeric(TextBox13.Text) And Len(TextBox13.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox13.Text & "%'  order by toernbezeichnung"
            Else
                If Len(TextBox13.Text) > 1 Then
                    If Mid(TextBox13.Text, 2, 1) = "*" Then
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox13.Text & "%'  order by toernbezeichnung"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where Mid(toernbezeichnung,1,1) like '%" & TextBox13.Text & "%'  order by toernbezeichnung"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        End If
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 0
                MsgBox("Kein Törn mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                Fenster("t")
            Case 1
                DbAccess.SafePosition(bsToernname)
                Fenster("b")
                TextBox8.Focus()
                sucheSchaden()
            Case Else
                Fenster("t")
        End Select
    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub TextBox7_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox7.LostFocus
        suchen()
    End Sub
    Private Sub dgvSchaden_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgvSchaden.MouseClick
        suchen()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Fenster("t")
        suchenToern()
    End Sub
    Private Sub dgvToern_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgvToern.MouseClick
        Fenster("t")
        suchenToern()
        ButtonSpeichern.Visible = True
        ButtonSpeichern.Enabled = True

    End Sub
    Private Sub TextBox13_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox13.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenToern()
        End If
    End Sub

    Private Sub sucheSchaden()
        Dim rs As System.Data.DataRowView = bsSchaden.Current
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from Schaden where Polizze = '" & TextBox7.Text & "' and Törn = '" & TextBox13.Text & "'  "
        bsSchaden.CancelEdit()
        dsVersicherung.Schaden.Clear()
        sAdapter.Fill(dsVersicherung.Schaden)
        Select Case bsSchaden.Count
            Case 0
                aenderung = False
                bsSchaden.AddNew()
                sAdapter.SelectCommand.CommandText = "Select * from Schaden   "
                bsSchaden.CancelEdit()
                dsVersicherung.Schaden.Clear()
                sAdapter.Fill(dsVersicherung.Schaden)
                TextBox32.Text = TextBox13.Text
                TextBox31.Text = TextBox7.Text
            Case 1
                aenderung = True
                '               RichTextBox2.Location = New Point(11, 20)
            Case Else
                DbAccess.SafePosition(bsSchaden)
                Fenster("v")
        End Select
        ButtonSpeichern.Enabled = True
    End Sub
    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        Dim rs As System.Data.DataRowView = bsSchaden.Current
        If aenderung Then
            bsSchaden.EndEdit()
            taSchaden.Update(dsVersicherung.Schaden)
            sAdapter.SelectCommand = New OleDb.OleDbCommand
            sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            sAdapter.SelectCommand.CommandText = "Select * from Schaden where Polizze = '" & TextBox7.Text & "' and Törn = '" & TextBox13.Text & "'  "
            bsSchaden.CancelEdit()
            dsVersicherung.Schaden.Clear()
            sAdapter.Fill(dsVersicherung.Schaden)
        Else
            sAdapter.SelectCommand = New OleDb.OleDbCommand
            sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            sAdapter.SelectCommand.CommandText = "Select * from Schaden where Polizze = '" & TextBox7.Text & "' and Törn = '" & TextBox13.Text & "'  "
            bsSchaden.CancelEdit()
            dsVersicherung.Schaden.Clear()
            sAdapter.Fill(dsVersicherung.Schaden)
            aenderung = True
            bsSchaden.AddNew()
            TextBox32.Text = TextBox13.Text
            TextBox31.Text = TextBox7.Text
            bsSchaden.AddNew()
            taSchaden.Update(dsVersicherung.Schaden)
            GroupBox5.Size = New Size(544, 180)
            GroupBox6.Enabled = True
            gbBemerkung.Enabled = True
            Close()
        End If
        Fenster("s")
        If gbVersicherung.Location = New Point(12, 13) Then
            Select Case TextBox33.Text
                Case 1
                    RadioButton1.Checked = True
                Case 2
                    RadioButton2.Checked = True
                Case 3
                    RadioButton3.Checked = True
            End Select
        Else
            Close()
        End If
    End Sub

    Private Sub RadioButton1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButton1.MouseClick
        If RadioButton1.Checked Then
            Fenster(" ")
            gbHaftschaden.Location = New Point(12, 13)
            gbVersicherung.Location = New Point(4000, 2000)
            '            RichTextBox2.Location = New Point(11, 20)
            TextBox33.Text = 1
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            gbSchilderung.Location = New Point(2222, 2222)
            gbHaftschaden.Location = New Point(3200, 4000)
            gbUnfallbericht.Location = New Point(12, 13)
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked Then
            Fenster(" ")
            gbKaution.Location = New Point(12, 13)
            gbVersicherung.Location = New Point(4000, 2000)
            '           RichTextBox2.Location = New Point(11, 20)
            TextBox33.Text = 2
        End If
    End Sub
    Private Sub RadioButton3_Click(sender As Object, e As System.EventArgs) Handles RadioButton3.Click
        If RadioButton3.Checked Then
            Fenster(" ")
            gbRuecktritt.Location = New Point(12, 13)
            gbVersicherung.Location = New Point(4000, 2000)
            '          RichTextBox2.Location = New Point(11, 20)
            TextBox33.Text = 3
        End If

    End Sub

    Private Sub cbSchadensschilderung_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbSchadensschilderung.CheckedChanged
        If cbSchadensschilderung.Checked Then
            gbUnfallbericht.Location = New Point(3333, 3333)
            gbHaftschaden.Location = New Point(3200, 4000)
            gbSchilderung.Location = New Point(12, 13)
            If IsDBNull(dsVersicherung.Schaden.Rows(0)("schadensbeschreibung")) Then
            Else
                If dsVersicherung.Schaden.Rows(0)("schadensbeschreibung") > "" Then
                    TextBox1.ForeColor = Color.Black
                    TextBox4.ForeColor = Color.Black
                    TextBox5.ForeColor = Color.Black
                    RichTextBox1.ForeColor = Color.Black
                    MaskedTextBox1.ForeColor = Color.Black
                    MaskedTextBox2.ForeColor = Color.Black
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.ForeColor = Color.Black
    End Sub
    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox1.GotFocus
        MaskedTextBox1.ForeColor = Color.Black
    End Sub
    Private Sub MaskedTextBox2_GotFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox2.GotFocus
        MaskedTextBox2.ForeColor = Color.Black
    End Sub
    Private Sub TextBox4_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox4.GotFocus
        TextBox4.ForeColor = Color.Black
    End Sub
    Private Sub TextBox5_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox5.GotFocus
        TextBox5.ForeColor = Color.Black
    End Sub
    Private Sub RichTextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles RichTextBox1.GotFocus
        RichTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub TextBox34_Click(sender As Object, e As System.EventArgs) Handles TextBox34.Click
        textboxNr = 34
        anhang = ".pdf"
        If Len(TextBox34.Text) > 5 Then
            '          fotoausgabe(TextBox2.Text)
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            Else
            End If
        Else
            suchedatei()
        End If

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As System.EventArgs) Handles TextBox2.Click
        textboxNr = 2
        anhang = ".jpg"
        If Len(TextBox2.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            Else
            End If
        Else
            suchedatei()
        End If
    End Sub
    Private Sub fotoausgabe(ByVal abc)
        '       aaa = textV
        If My.Computer.FileSystem.FileExists(Trim$((abc))) Then
            foto = Image.FromFile(Trim$((abc)))
            With PictureBox1
                .Image = AutoSizeI.AutoSizeImage(foto, 395, 395)
            End With
        Else
            PictureBox1.Image = Nothing
        End If

    End Sub
    Private Sub suchedatei()
        GroupBoxV.Location = New Point(20, 20)
        GroupBoxV.Text = "Datei suchen"
        For Each drv As IO.DriveInfo In IO.DriveInfo.GetDrives
            With drv
                If .DriveType = IO.DriveType.Fixed Or .DriveType = IO.DriveType.Network Or .DriveType = IO.DriveType.Removable Then ' USB und Festplatte
                    ListBoxV.Items.Add(.Name)
                End If
            End With
        Next
    End Sub
    Private Sub ListBoxV_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBoxV.MouseClick
        TextBoxV.Text = ListBoxV.Text
        ListBoxH.Items.Add(TextBoxV.Text)
    End Sub
    Private Sub ListBoxV_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBoxV.SelectedIndexChanged
        If Len(TextBoxV.Text) >= 3 Then
            unterordner()
        End If
    End Sub
    Private Sub unterordner()
        Dim l As Integer = Len(ListBoxV.Text)
        If l < 4 Then
            Dim disk As String = ListBoxV.Text
            path = TextBoxV.Text
            ListBoxV.Items.Clear()
            GroupBoxV.Text = "Wähle Ordner"
            ListBoxV.Items.AddRange(IO.Directory.GetDirectories(disk))
            Dim bilder = IO.Directory.GetFiles(path, "*" + anhang).ToList()
            For Each bild In bilder
                Dim textVonBild = IO.Path.ChangeExtension(bild, anhang)
                Dim xx = IO.Path.GetFileName(textVonBild)
                Me.ListBoxV.Items.Add(xx)
            Next
            GoTo endsub
        End If
        If ListBoxV.Text.Substring(l - 4, 4) = anhang Then
            TextBoxV.Text = path + "\" + ListBoxV.Text
        Else
            Dim disk As String = ListBoxV.Text
            path = TextBoxV.Text
            ListBoxV.Items.Clear()
            GroupBoxV.Text = "Wähle Ordner"
            ListBoxV.Items.AddRange(IO.Directory.GetDirectories(disk))
            Dim bilder = IO.Directory.GetFiles(path, "*" + anhang).ToList()
            For Each bild In bilder
                Dim textVonBild = IO.Path.ChangeExtension(bild, anhang)
                Dim xx = IO.Path.GetFileName(textVonBild)
                Me.ListBoxV.Items.Add(xx)
            Next
        End If
endsub:

    End Sub
    Private Sub BLaden_Click(sender As System.Object, e As System.EventArgs) Handles BLaden.Click
        textV = TextBoxV.Text
        GroupBoxV.Location = New Point(10000, 11000)
        textzurueck()
        TextBoxV.Text = " "
        '      ListBoxH.Items.Clear()

    End Sub

    Private Sub BZurueck_Click(sender As System.Object, e As System.EventArgs) Handles BZurueck.Click
        Dim aaa As String
        Dim test As String
        GroupBoxV.Text = "Wähle Ordner"
        aaa = ListBoxH.Items.Count
        TextBoxV.Text = ListBoxH.Items(aaa - 2)
        '      test = ListBoxH.Items(aaa - 1)
        ListBoxH.Items.RemoveAt(aaa - 1)
        '       aaa = ListBoxH.Items.Count
        '       test = ListBoxH.Items(aaa - 1)

        Dim disk As String = TextBoxV.Text
        path = TextBoxV.Text
        ListBoxV.Items.Clear()
        ListBoxV.Items.AddRange(IO.Directory.GetDirectories(disk))
        Dim bilder = IO.Directory.GetFiles(path, "*" + anhang).ToList()
        For Each bild In bilder
            Dim textVonBild = IO.Path.ChangeExtension(bild, anhang)
            Dim xx = IO.Path.GetFileName(textVonBild)
            Me.ListBoxV.Items.Add(xx)
        Next
    End Sub
    Private Sub BAbruch_Click(sender As System.Object, e As System.EventArgs) Handles BAbruch.Click
        textV = "X"
        GroupBoxV.Location = New Point(10000, 11000)
    End Sub
    Private Sub textzurueck()
        Select Case textboxNr
            Case 2
                TextBox2.Text = textV
                fotoausgabe(TextBox2.Text)
            Case 3
                TextBox3.Text = textV
                fotoausgabe(TextBox3.Text)
            Case 6
                TextBox6.Text = textV
                fotoausgabe(TextBox6.Text)
            Case 14
                TextBox14.Text = textV
            Case 15
                TextBox15.Text = textV
            Case 16
                TextBox16.Text = textV
            Case 17
                TextBox17.Text = textV
            Case 18
                TextBox18.Text = textV
            Case 19
                TextBox19.Text = textV
            Case 20
                TextBox20.Text = textV
            Case 21
                TextBox21.Text = textV
            Case 28
                TextBox28.Text = textV
            Case 29
                TextBox29.Text = textV
            Case 30
                TextBox30.Text = textV
            Case 34
                TextBox34.Text = textV
            Case 35
                TextBox35.Text = textV
        End Select
    End Sub
    Private Sub TextBox3_Click(sender As Object, e As System.EventArgs) Handles TextBox3.Click
        textboxNr = 3
        anhang = ".jpg"
        If Len(TextBox3.Text) > 5 Then
            fotoausgabe(TextBox3.Text)
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            Else
            End If
        Else
            suchedatei()
        End If
    End Sub
    Private Sub TextBox6_Click(sender As Object, e As System.EventArgs) Handles TextBox6.Click
        textboxNr = 6
        anhang = ".jpg"
        If Len(TextBox6.Text) > 5 Then
            fotoausgabe(TextBox6.Text)
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            Else
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox30_Click(sender As Object, e As System.EventArgs) Handles TextBox30.Click
        textboxNr = 30
        anhang = ".pdf"
        If Len(TextBox30.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox29_Click(sender As Object, e As System.EventArgs) Handles TextBox29.Click
        textboxNr = 29
        anhang = ".pdf"
        If Len(TextBox29.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox28_Click(sender As Object, e As System.EventArgs) Handles TextBox28.Click
        textboxNr = 28
        anhang = ".pdf"
        If Len(TextBox28.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox17_Click(sender As Object, e As System.EventArgs) Handles TextBox17.Click
        textboxNr = 17
        anhang = ".pdf"
        If Len(TextBox17.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox18_Click(sender As Object, e As System.EventArgs) Handles TextBox18.Click
        textboxNr = 18
        anhang = ".pdf"
        If Len(TextBox18.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox19_Click(sender As Object, e As System.EventArgs) Handles TextBox19.Click
        textboxNr = 19
        anhang = ".pdf"
        If Len(TextBox19.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox20_Click(sender As Object, e As System.EventArgs) Handles TextBox20.Click
        textboxNr = 20
        anhang = ".pdf"
        If Len(TextBox20.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox21_Click(sender As Object, e As System.EventArgs) Handles TextBox21.Click
        textboxNr = 21
        anhang = ".pdf"
        If Len(TextBox21.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox14_Click(sender As Object, e As System.EventArgs) Handles TextBox14.Click
        textboxNr = 14
        anhang = ".pdf"
        If Len(TextBox14.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox15_Click(sender As Object, e As System.EventArgs) Handles TextBox15.Click
        textboxNr = 15
        anhang = ".pdf"
        path = ""
        If Len(TextBox15.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox16_Click(sender As Object, e As System.EventArgs) Handles TextBox16.Click
        textboxNr = 16
        anhang = ".pdf"
        If Len(TextBox16.Text) > 5 Then
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            End If
        Else
            suchedatei()
        End If
    End Sub

    Private Sub TextBox35_Click(sender As Object, e As System.EventArgs) Handles TextBox35.Click
        textboxNr = 35
        anhang = ".pdf"
        If Len(TextBox35.Text) > 5 Then
            '          fotoausgabe(TextBox2.Text)
            msgAntw = MsgBox("Andere Datei Suchen?", 4)
            If msgAntw = "6" Then
                suchedatei()
            Else
            End If
        Else
            suchedatei()
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        ' zurück Haftschaden 
        Fenster(" ")
        gbHaftschaden.Location = New Point(12, 13)
        gbVersicherung.Location = New Point(4000, 2000)
        '        RichTextBox2.Location = New Point(11, 20)
        '        gbSchilderung.Location = New Point(120, 130)
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Fenster("s")
        gbHaftschaden.Location = New Point(12000, 2213)
        gbVersicherung.Location = New Point(12, 13)
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        ' zurück Haftschaden 
        Fenster(" ")
        gbHaftschaden.Location = New Point(12, 13)
        gbUnfallbericht.Location = New Point(4000, 2000)
        RichTextBox2.Location = New Point(11, 20)
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        Fenster("s")
        gbKaution.Location = New Point(12000, 2213)
        gbVersicherung.Location = New Point(12, 13)
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        Fenster("s")
        gbRuecktritt.Location = New Point(12000, 2213)
        gbVersicherung.Location = New Point(12, 13)
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        If RadioButton5.Checked Then
            Fenster("v")
        Else
            Fenster("n")
        End If
    End Sub

    Private Sub dgvSchaden_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSchaden.CellContentClick
        suchen()
        TextBox13.Text = TextBox32.Text
        TextBox7.Text = TextBox31.Text
        Fenster("b")
        ButtonSpeichern.Visible = True
        ButtonSpeichern.Enabled = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Fenster("b")
            gbschnell.Location = New Point(12000, 2213)
            gbVersicherung.Location = New Point(12, 13)
            gbHaftschaden.Location = New Point(12000, 2213)
            gbSchadenmeldung.Location = New Point(22222, 33333)
            aenderung = True
        End If
    End Sub
    Private Sub TextBox13_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox13.LostFocus
        TextBox32.Text = TextBox13.Text
        TextBox31.Text = TextBox7.Text
        ButtonSpeichern.Visible = True
        ButtonSpeichern.Enabled = True
    End Sub

    Private Sub RadioButton4_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioNeu.MouseClick
        If RadioNeu.Checked Then
            Fenster("b")
            gbschnell.Location = New Point(12000, 2213)
            gbVersicherung.Location = New Point(12, 13)
            gbHaftschaden.Location = New Point(12000, 2213)
            gbSchadenmeldung.Location = New Point(22222, 33333)
            GroupBox5.Size = New Size(544, 120)
            GroupBox6.Enabled = False
            gbBemerkung.Enabled = False
        End If

    End Sub

    Private Sub dgvversi_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvversi.CellContentClick
        suchen()
    End Sub
End Class