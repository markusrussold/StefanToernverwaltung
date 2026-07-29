Public Class Datenbank
    Dim speicherbild As String
    Dim speicheradressen As String
    Dim speicherformular As String
    Dim logbuch As String
    Dim boot As String
    Dim Marina As String
    Dim bericht As String
    Dim Karte As String
    Dim CrewBp As String
    Dim Foto As String
    Dim Exportdatei As String
    Dim sign As String
    Dim schein As String
    Dim len As Integer
    Dim buch1 As String
    Dim position As Integer
    Dim reader As String
    Public iii As Integer
    Public aaa As String
    Dim BildAnzahl As Integer = 0
    Dim Speicherplatz As Double = 0
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        speicherbild = LTrim(RTrim(TextBox2.Text))
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        speicherformular = LTrim(RTrim(TextBox3.Text))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveSetting("ToernLogo", "Pfad", "T", speicherbild)
        If My.Computer.FileSystem.FileExists(Trim$((TextBox2.Text))) Then
        Else
            MsgBox(TextBox2.Text + " Datei existiert nicht")
        End If
        SaveSetting("Toernformular", "Pfad", "T", speicherformular)
        SaveSetting("Toernadressen", "Pfad", "T", speicheradressen)
        SaveSetting("Logbuch", "Pfad", "T", logbuch)
        SaveSetting("Berichte", "Pfad", "T", bericht)
        SaveSetting("Boote", "Pfad", "T", boot)
        SaveSetting("Sign", "Pfad", "T", sign)
        SaveSetting("Schein", "Pfad", "T", Schein)
        SaveSetting("Marina", "Pfad", "T", Marina)
        If My.Computer.FileSystem.FileExists(Trim$((TextBox7.Text))) Then
        Else
            MsgBox(TextBox7.Text + " Datei existiert nicht")
        End If
        SaveSetting("CrewBsp", "Pfad", "T", CrewBp)
        SaveSetting("Karte", "Pfad", "T", Karte)
        SaveSetting("Foto", "Pfad", "T", Foto)
        SaveSetting("Acrobat", "Pfad", "T", reader)

        bsToernname.EndEdit()
        taToernname.Update(dsToernverwaltung.Toernname)

        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Datenbank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        speicherbild = GetSetting("ToernLogo", "Pfad", "T")
        If speicherbild > "" Then
            TextBox2.Text = speicherbild
         Else
            TextBox2.Text = Space(20)
        End If
        speicherformular = GetSetting("Toernformular", "Pfad", "T")
        If speicherformular > "" Then
            TextBox3.Text = speicherformular
        Else
            TextBox3.Text = Space(20)
        End If
        speicheradressen = GetSetting("Toernadressen", "Pfad", "T")
        If speicheradressen > "" Then
            TextBox1.Text = speicheradressen
        Else
            TextBox1.Text = Space(20)
        End If
        logbuch = GetSetting("Logbuch", "Pfad", "T")
        If logbuch > "" Then
            TextBox5.Text = logbuch
        Else
            TextBox5.Text = Space(20)
        End If
        bericht = GetSetting("Berichte", "Pfad", "T")
        If bericht > "" Then
            TextBox4.Text = bericht
        Else
            TextBox4.Text = Space(20)
        End If
        boot = GetSetting("Boote", "Pfad", "T")
        If boot > "" Then
            TextBox6.Text = boot
        Else
            TextBox6.Text = Space(20)
        End If
        Marina = GetSetting("Marina", "Pfad", "T")
        If Marina > "" Then
            TextBox10.Text = Marina
        Else
            TextBox10.Text = Space(20)
        End If
        sign = GetSetting("sign", "Pfad", "T")
        If sign > "" Then
            TextBox7.Text = sign
       Else
            TextBox7.Text = Space(20)
        End If
        schein = GetSetting("schein", "Pfad", "T")
        If schein > "" Then
            TextBox16.Text = schein
        Else
            TextBox16.Text = Space(20)
        End If
        Foto = GetSetting("Foto", "Pfad", "T")
        If Foto > "" Then
            TextBox8.Text = Foto
        Else
            TextBox8.Text = Space(20)
        End If
        Karte = GetSetting("Karte", "Pfad", "T")
        If Karte > "" Then
            TextBox9.Text = Karte
        Else
            TextBox9.Text = Space(20)
        End If
        CrewBp = GetSetting("CrewBsp", "Pfad", "T")
        If CrewBp > "" Then
            TextBox15.Text = CrewBp
        Else
            TextBox15.Text = Space(20)
        End If
        reader = GetSetting("acrobat", "Pfad", "T")
        If reader > "" Then
            TextBox17.Text = reader
        Else
            TextBox17.Text = Menü.AcrobatReader
        End If

        With DataGridView1
            .Columns(0).Width = 150
            .Columns(1).Width = 200
        End With
        ListBox1.Location = New Point(29, 131)
        ListBox1.Visible = False
        Label15.Location = New Point(29, 112)
        Label15.Visible = False
         DataGridView1.Visible = False
        Label14.Visible = False
        PictureBox2.Visible = False
        TextBox12.Visible = False
        ProgressBar1.Visible = False
        Label18.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        speicheradressen = LTrim(RTrim(TextBox1.Text))
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        len = TextBox4.Text.Length
        If TextBox4.Text.Substring(len - 1, 1) = "\" Then
            bericht = LTrim(RTrim(TextBox4.Text))
        Else
            bericht = LTrim(RTrim(TextBox4.Text)) + "\"
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        len = TextBox5.Text.Length
        If TextBox5.Text.Substring(len - 1, 1) = "\" Then
            logbuch = LTrim(RTrim(TextBox5.Text))
        Else
            logbuch = LTrim(RTrim(TextBox5.Text)) + "\"
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        len = TextBox6.Text.Length
        If TextBox6.Text.Substring(len - 1, 1) = "\" Then
            boot = LTrim(RTrim(TextBox6.Text))
        Else
            boot = LTrim(RTrim(TextBox6.Text)) + "\"
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        sign = LTrim(RTrim(TextBox7.Text))
    End Sub
    Private Sub TextBox16_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox16.TextChanged
        schein = LTrim(RTrim(TextBox16.Text))
    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        len = TextBox9.Text.Length
        If TextBox9.Text.Substring(len - 1, 1) = "\" Then
            Karte = LTrim(RTrim(TextBox9.Text))
        Else
            Karte = LTrim(RTrim(TextBox9.Text)) + "\"
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        len = TextBox8.Text.Length
        If TextBox8.Text.Substring(len - 1, 1) = "\" Then
            Foto = LTrim(RTrim(TextBox8.Text))
        Else
            Foto = LTrim(RTrim(TextBox8.Text)) + "\"
        End If

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        len = TextBox10.Text.Length
        If TextBox10.Text.Substring(len - 1, 1) = "\" Then
            Marina = LTrim(RTrim(TextBox10.Text))
        Else
            Marina = LTrim(RTrim(TextBox10.Text)) + "\"
        End If
    End Sub

      Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        DataGridView1.Visible = True
        AlbumExport.Visible = False
        suchen()
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        DataGridView1.Visible = True
        ListBox1.Visible = False
        Label15.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
         If TextBox11.Text > "  " Then
            If IsNumeric(TextBox11.Text) And TextBox11.Text.Length = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox11.Text & "%'  order by toernbezeichnung"
            Else
                If TextBox11.Text.Length > 1 Then
                    If Mid(TextBox11.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox11.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox11.Text & "%'  order by toernbezeichnung"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where Mid(toernbezeichnung,1,1) like '%" & TextBox11.Text & "%'  order by toernbezeichnung"
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
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                TextBox11.Text = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString
                '              ListBox1.Focus()
                PictureBox2.Visible = True
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
         End Select
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
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox11.Text = TextBox13.Text
        TextBox12.Visible = True
        suchen()
        DataGridView1.Visible = False
    End Sub
    Private Sub TextBox11_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then
            AlbumExport.Visible = False
            suchen()
        End If
    End Sub
    Private Sub AlbumExport_Click(sender As System.Object, e As System.EventArgs) Handles AlbumExport.Click
        Label13.Visible = False
        Label14.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        AlbumExport.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        ListBox1.Visible = True
        ListBox1.Location = New Point(29, 131)
        Label15.Visible = True
        For Each drv As IO.DriveInfo In IO.DriveInfo.GetDrives
            With drv
                If .DriveType = IO.DriveType.Fixed Or .DriveType = IO.DriveType.Network Or .DriveType = IO.DriveType.Removable Then ' USB und Festplatte
                    ListBox1.Items.Add(.Name)
                End If
            End With
        Next
    End Sub
    Private Sub kopieren()
        Dim msg As Integer
        Dim di As New System.IO.DriveInfo(TextBox14.Text)
        Dim gb As Long = di.TotalFreeSpace / 1000000000
        msg = MsgBox("Auf Laufwerk  " & Convert.ToString(TextBox14.Text) & " sind " & Convert.ToString(gb) & " GB frei.", 1, "Copy")
        If msg <> vbOK Then GoTo subende
        ListBox1.Visible = False

        ListBox4.Items.Clear()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Album("Suchen")
        aaa = Speicherplatz / 1000000000
        aaa = aaa.Substring(0, 4)
        aaa = BildAnzahl.ToString + " Dateien, das sind " + aaa + " GB"
        msg = MsgBox("Sollen wirklich " & Convert.ToString(aaa) & "  auf Laufwerk  " & Convert.ToString(TextBox14.Text) & " kopiert werden?", 1, "Copy")
        If msg <> vbOK Then GoTo subende
        Label18.Visible = True
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = BildAnzahl
        ProgressBar1.Minimum = 0
        ProgressBar1.Step = 1
        BildAnzahl = 0
        Label15.Text = "Kopiere Dateien"
        Album("Copy")
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
subende:
    End Sub
    Private Sub Album(ByVal Aktion)
        Dim sPath As String
        Dim quelle As String
        Dim ziel As String
        For i = 0 To bsToernname.Count - 1
            If dsToernverwaltung.Toernname.Rows(i)("R1").ToString > "" Then
                Dim anz As Integer
                '  Fotos aus dem Ordner suchen
                sPath = dsToernverwaltung.Toernname.Rows(i)("R1").ToString
                If sPath.EndsWith("\") And sPath.Length > 3 Then
                    sPath = sPath.Substring(0, sPath.Length - 1)
                End If

                ' Directory-Object erstellen
                Dim oDir As New System.IO.DirectoryInfo(sPath)

                ' alle Dateien des Ordners
                Dim oFiles As System.IO.FileInfo()
               Try
                    oFiles = oDir.GetFiles()
                Catch ex As Exception
                    MsgBox("Fotos im Ordner " & Convert.ToString(dsToernverwaltung.Toernname.Rows(i)("R1")) & " existieren nicht oder der Ordner ist nicht mehr vorhanden.")
                    GoTo schleife
                End Try

                ' Datei-Array durchlaufen und in 
                ' ListBox übertragen

                Dim oFile As System.IO.FileInfo
                Dim ofso As New System.Object
                For Each oFile In oFiles
                    aaa = oFile.Name
                    '                   anz = len(oFile.Name)
                    anz = oFile.Name.Length
                    If anz > 5 Then
                        If (aaa.Substring(anz - 4, 4)).ToUpper = ".JPG" Or (aaa.Substring(anz - 5, 5)).ToUpper = ".JPEG" Then
                            quelle = sPath + "\" + oFile.Name
                            anz = sPath.Length
                            ListBox4.Items.Add(quelle)
                            ziel = TextBox14.Text + sPath.Substring(3, anz - 3)
                            If Aktion = "Copy" Then
                                If Not IO.Directory.Exists(ziel) Then
                                    ' Nein! Jetzt erstellen...
                                    Try
                                        IO.Directory.CreateDirectory(ziel)
                                        ' Ordner wurde korrekt erstellt!
                                    Catch ex As Exception
                                        ' Ordner wurde nich erstellt
                                    End Try
                                End If
                                FileCopy(quelle, ziel + "\" + oFile.Name)
                                If ProgressBar1.Value < ProgressBar1.Maximum Then
                                    ProgressBar1.Value = BildAnzahl
                                    BildAnzahl += 1
                                    Label18.Text = BildAnzahl.ToString + "/" + ProgressBar1.Maximum.ToString
                                    Me.Refresh()
                                    ProgressBar1.PerformStep()
                                End If

                            Else
                                Dim fi As New System.IO.FileInfo(quelle)
                                Dim gb As Long = fi.Length
                                BildAnzahl += 1
                                Speicherplatz += gb
                            End If

                        End If
                    End If
                Next

            End If
schleife:
        Next
    End Sub

    Private Sub TextBox12_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox12.GotFocus
        If Menü.ordner > "" Then
            TextBox12.Text = Menü.ordner
            Menü.ordner = ""
        End If
    End Sub

    Private Sub TextBox12_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox12.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox11.Focus()
        End If
    End Sub
     Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        FormUi.ShowChild(SucheDatei)
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        TextBox14.Text = ListBox1.Text
        kopieren()
    End Sub

    Private Sub TextBox15_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox15.TextChanged
        len = TextBox15.Text.Length
        If TextBox15.Text.Substring(len - 1, 1) = "\" Then
            CrewBp = LTrim(RTrim(TextBox15.Text))
        Else
            CrewBp = LTrim(RTrim(TextBox15.Text)) + "\"
        End If

    End Sub


    Private Sub TextBox17_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox17.TextChanged
        reader = TextBox17.Text
    End Sub
End Class
