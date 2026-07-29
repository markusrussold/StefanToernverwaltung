Public Class Cover
    Dim aaa As String
    Dim buch1 As String
    Dim position As Integer
    Dim iii As Integer
    Dim aenderungB As Boolean = False
    Dim aenderungT As Boolean = False
    Dim path As String
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub Cover_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Toerndaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToerndaten.Fill(Me.DsLogbuch.Toerndaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.BootLog". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taBootLog.Fill(Me.DsLogbuch.BootLog)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)

        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        Dim rp As System.Data.DataRowView = bsBootLog.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from bootlog"
        bsBootLog.CancelEdit()
        DsLogbuch.BootLog.Clear()
        pAdapter.Fill(DsLogbuch.BootLog)
        bsBootLog.Position = 0
        aaa = bsBootLog.Count
        bsBootLog.AddNew()
        ButtonFL.Enabled = False
        ButtonSpeichern.Enabled = False
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox3.Mask = "00:00"
        MaskedTextBox2.Mask = "00:00"

        aaa = TextBox1.Text
        Me.Text = "Daten für Törn: " + aaa
        suchen()
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
        GroupBoxToern.Select()
        DataGridView1.Location = New Point(9, 16)
        '      GroupBoxToern.Enabled = False
        '       GroupBoxBoot.Enabled = False
        GroupBoxToern.Text = "Törn auswählen mit Doppelklick"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        '       TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If IsNumeric(TextBox1.Text) And Len(TextBox1.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
            Else
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox1.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where Mid(toernbezeichnung,1,1) like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        End If
        bsToernname.CancelEdit()
        '       aenderung = True
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                Formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Location = New Point(1200, 110)
                GroupBoxToern.Enabled = True
                GroupBoxBoot.Enabled = True
                TextBox2.Text = TextBox1.Text
                TextBox15.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                GroupBoxBoot.Visible = True
                ButtonFL.Enabled = True
                ButtonSpeichern.Enabled = True
                 Suchenboot()
                Suchentoern()
                GroupBoxToern.Text = "Törnbeschreibung"
                TextBox3.Focus()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
        End Select
    End Sub
    Private Sub Formularloeschen()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
    End Sub
    Private Sub positionieren()
        iii = bsToernname.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.Toernname.Rows(i)("toernbezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub Suchentoern()
        Dim rt As System.Data.DataRowView = bsToerndaten.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Toerndaten where toernbezeichnung = '" & TextBox1.Text & "'  "
        bsToerndaten.CancelEdit()
        DsLogbuch.Toerndaten.Clear()
        tAdapter.Fill(DsLogbuch.Toerndaten)
        bsToerndaten.Position = 0
        aaa = bsToerndaten.Count
        If aaa > 0 Then
            aenderungT = True
            TextBox20.Text = TextBox19.Text + "°"
        Else
            bsToerndaten.AddNew()
        End If

    End Sub
    Private Sub Suchenboot()
        Dim rp As System.Data.DataRowView = bsBootLog.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from bootlog where bootname = '" & TextBox15.Text & "' "
        bsBootLog.CancelEdit()
        DsLogbuch.BootLog.Clear()
        pAdapter.Fill(DsLogbuch.BootLog)
        bsBootLog.Position = 0
        aaa = bsBootLog.Count
        If aaa > 0 Then
            aenderungB = True
        Else
            bsBootLog.AddNew()
            TextBox15.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        suchen()
    End Sub

    Private Sub ButtonFL_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFL.Click
        Formularloeschen()
    End Sub
    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        TextBox2.Text = TextBox1.Text
        If aenderungT Then
            bsToerndaten.EndEdit()
            taToerndaten.Update(DsLogbuch.Toerndaten)
        Else
            bsToerndaten.AddNew()
            taToerndaten.Update(DsLogbuch.Toerndaten)
        End If
        If aenderungB Then
            bsBootLog.EndEdit()
            taBootLog.Update(DsLogbuch.BootLog)
        Else
            bsBootLog.AddNew()
            taBootLog.Update(DsLogbuch.BootLog)
        End If
        SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        suchen()
    End Sub

    Private Sub Label10_MouseHover(sender As Object, e As System.EventArgs) Handles Label10.MouseHover
        Label18.Visible = True
        f9()
    End Sub
    Private Sub Label10_MouseLeave(sender As Object, e As System.EventArgs) Handles Label10.MouseLeave
        Label18.Visible = False
        f9()
    End Sub
    Private Sub Label17_MouseHover(sender As Object, e As System.EventArgs) Handles Label17.MouseHover
        Label18.Visible = True
        f9()
    End Sub
    Private Sub Label17_MouseLeave(sender As Object, e As System.EventArgs) Handles Label17.MouseLeave
        Label19.Visible = False
        f13()
    End Sub
    Private Sub Label11_MouseHover(sender As Object, e As System.EventArgs) Handles Label11.MouseHover
        Label19.Visible = True
        f13()
    End Sub
    Private Sub Label11_MouseLeave(sender As Object, e As System.EventArgs) Handles Label11.MouseLeave
        Label18.Visible = False
        f9()
    End Sub
    Private Sub Label16_MouseHover(sender As Object, e As System.EventArgs) Handles Label16.MouseHover
        Label19.Visible = True
        f13()
    End Sub
    Private Sub Label16_MouseLeave(sender As Object, e As System.EventArgs) Handles Label16.MouseLeave
        Label19.Visible = False
        f13()
    End Sub
    Private Sub TextBox9_MouseHover(sender As Object, e As System.EventArgs) Handles TextBox9.MouseHover
        Label18.Visible = True
        f9()
    End Sub
    Private Sub TextBox9_MouseLeave(sender As Object, e As System.EventArgs) Handles TextBox9.MouseLeave
        Label18.Visible = False
        f9()
    End Sub
    Private Sub TextBox13_MouseHover(sender As Object, e As System.EventArgs) Handles TextBox13.MouseHover
        Label19.Visible = True
        f13()
    End Sub
    Private Sub TextBox13_MouseLeave(sender As Object, e As System.EventArgs) Handles TextBox13.MouseLeave
        Label19.Visible = False
        f13()
    End Sub
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        FormUi.ShowChild(SucheDatei)
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        FormUi.ShowChild(SucheDatei)
    End Sub
    Private Sub TextBox9_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox9.GotFocus
        f9()
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        f13()
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseLeave
        f9()
    End Sub
    Private Sub f9()
        If Menü.ordner > "" Then
            TextBox9.Text = Menü.ordner
            Menü.ordner = ""
        End If
    End Sub
    Private Sub f13()
        If Menü.ordner > "" Then
            TextBox13.Text = Menü.ordner
            Menü.ordner = ""
        End If
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseHover
        'bild zeigen
        Dim crewfoto As Image
        GroupBox2.Size = New Point(400, 400)
        GroupBox2.Location = New Point(10, 10)
        PictureBox5.Size = New Point(395, 395)
        PictureBox5.Location = New Point(2, 2)
        GroupBox2.Visible = True
        aaa = TextBox9.Text
        If My.Computer.FileSystem.FileExists(Trim$((aaa))) Then
            crewfoto = Image.FromFile(Trim$((aaa)))
            With PictureBox5
                .Image = AutoSizeI.AutoSizeImage(crewfoto, 395, 395)
            End With
        Else
            PictureBox5.Image = Nothing
        End If

    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseLeave
        GroupBox2.Location = New Point(10000, 10000)

    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseHover
        'bild zeigen
        Dim crewfoto As Image
        GroupBox2.Size = New Point(400, 400)
        GroupBox2.Location = New Point(10, 10)
        PictureBox5.Size = New Point(395, 395)
        PictureBox5.Location = New Point(2, 2)
        GroupBox2.Visible = True
        aaa = TextBox13.Text
        If My.Computer.FileSystem.FileExists(Trim$((aaa))) Then
            crewfoto = Image.FromFile(Trim$((aaa)))
            With PictureBox5
                .Image = AutoSizeI.AutoSizeImage(crewfoto, 395, 395)
            End With
        Else
            PictureBox5.Image = Nothing
        End If

    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseLeave
        GroupBox2.Location = New Point(10000, 10000)
    End Sub

    Private Sub TextBox17_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox17.LostFocus
        TextBox17.Text = TextBox17.Text.ToUpper
    End Sub

    Private Sub TextBox20_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox20.LostFocus
        Dim lae As Single = Len(TextBox20.Text)
        TextBox20.Text = Replace(TextBox20.Text, ".", ",")
        If IsNumeric(TextBox20.Text) Then
            TextBox19.Text = TextBox20.Text
        Else
            TextBox19.Text = ""
            For i = 1 To lae
                If IsNumeric(TextBox20.Text.Substring(i - 1, 1)) Then
                    TextBox19.Text += TextBox20.Text.Substring(i - 1, 1)
                End If
            Next
        End If
    End Sub

    Private Sub TextBox18_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox18.LostFocus
        TextBox18.Text = Replace(TextBox18.Text, ".", ",")
    End Sub

    Private Sub TextBox7_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox7.LostFocus
        TextBox7.Text = Replace(TextBox7.Text, ".", ",")
    End Sub

End Class
