Imports System.IO
Public Class Boot
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Dim position As Integer
    Dim msg As Integer
    Dim buch1 As String
    Dim boot As String
    Dim Marina As String
    Dim ok As Boolean
    Dim Altname As String
    Private Sub Boot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '                                               R1   Kettenlänge
        Me.taBootLog.Fill(Me.DsLogbuch.BootLog)
        Me.taToernKalkulation.Fill(Me.dsToernverwaltung.ToernKalkulation)
        Me.taBootKalkulation.Fill(Me.dsToernverwaltung.BootKalkulation)
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taCharter.Fill(Me.dsToernverwaltung.Charter)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        boot = GetSetting("Boot", "Pfad", "T")
        Marina = GetSetting("Marina", "Pfad", "T")
        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung

        If Menü.FreischaltZiffer = 1 Or Menü.FreischaltZiffer = 3 Or Menü.FreischaltZiffer = 4 Then
            ok = True
        Else
            ok = False
            ButtonDruck.Enabled = False
        End If


        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsBoot.Current
        GroupBox2.Text = "Bemerkung"
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Boot order by Bootname"
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        bsBoot.Position = 0
        aaa = bsBoot.Count
        Label36.Text = "Anzahl der gespeicherten Boote: " + aaa
        bsBoot.AddNew()
        aenderung = False
        ComboBox4.Text = ""
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Boot - Art Großsegel' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        If bsListdaten.Count = 1 Then
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            '           comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        pAdapter.SelectCommand.CommandText = "Select * from Listdaten where Bezeichnung like 'Boot - Schiffstyp' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        If bsListdaten.Count = 1 Then
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            '           comboFuellen2(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        pAdapter.SelectCommand.CommandText = "Select * from Listdaten where Bezeichnung like 'Boot - Kielart' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        If bsListdaten.Count = 1 Then
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            '           comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        pAdapter.SelectCommand.CommandText = "Select * from Charter order by charterfirma "
        bsCharter.CancelEdit()
        dsToernverwaltung.Charter.Clear()
        pAdapter.Fill(dsToernverwaltung.Charter)
        bsCharter.Position = 0
        For i = 0 To bsCharter.Count - 1
            ComboBox4.Items.Add(dsToernverwaltung.Charter.Rows(i)("Charterfirma").ToString)
        Next
        If Menü.bootkey > " " Then
            TextBox18.Text = Menü.bootkey
            suchen()
        End If
        Label37.Visible = False
        TextBox30.Visible = False
    End Sub
    Private Sub comboFuellen1(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox1.Items.Add(text)
            End If
        End If

    End Sub
    Private Sub comboFuellen2(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox2.Items.Add(text)
            End If
        End If

    End Sub
    Private Sub comboFuellen3(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox3.Items.Add(text)
            End If
        End If

    End Sub

    Private Sub SpeichernButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernButton.Click
        '
        '                                Speichern
        '
        If aenderung Then
            iii = ListBox1.Items.Count - 1
            For i = 0 To iii
                aaa = ListBox1.Items(i).ToString
                BootToern()
            Next
        End If
        speichern()
        SpeichernButton.Text = "Speichern"
    End Sub
    Private Sub BootToern()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where Toernbezeichnung = '" & aaa & "' "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        dsToernverwaltung.Toernname.Rows(0)("Bootsname") = TextBox18.Text
        bsToernname.EndEdit()
        taToernname.Update(dsToernverwaltung.Toernname)
    End Sub
    Private Sub speichern()
        If TextBox18.Text > "     " Then
            TextBox20.Text = ComboBox4.Text
            TextBox21.Text = ComboBox2.Text
            TextBox22.Text = ComboBox3.Text
            TextBox24.Text = ComboBox1.Text
            If TextBox21.Text <> "Katamaran" Or IsNumeric(TextBox16.Text) Then
                TextBox39.Text = TextBox16.Text
            Else
                Dim pos2x As Integer
                Dim PS As String
                pos2x = TextBox16.Text.Length
                For i = 2 To pos2x - 1
                    If IsNumeric(TextBox16.Text.Substring(i, 1)) Then
                        PS = PS + TextBox16.Text.Substring(i, 1)
                    End If
                Next
                TextBox39.Text = PS
            End If
            If RadioButton1.Checked Or RadioButton2.Checked Then
                If aenderung Then
                    iii = 0
                    If Altname <> TextBox18.Text And Altname > " " Then
                        msg = MsgBox(" Das Boot " & Convert.ToString(Altname) & " auf " & Convert.ToString(TextBox18.Text) & " umbenenen.", 1, "Umbenenen")
                        Me.Cursor = Cursors.WaitCursor
                        If msg = vbOK Then
                            BootsnameAenderung()
                        Else
                            GoTo EndeSub
                        End If
                    End If
                    bsBoot.EndEdit()
                    taBoot.Update(dsToernverwaltung.Boot)
                Else
                    bsBoot.AddNew()
                    taBoot.Update(dsToernverwaltung.Boot)
                End If
EndeSub:        Formularloeschen()
            Else
                MsgBox("Wähle die Antriebsart des Bootes - Segelboot oder Motorboot    ")
                RadioButton1.Focus()
            End If
        Else
            MsgBox("Bootsname ist Pflichteingabe")
            TextBox18.Focus()
        End If
        aenderung = False
        Me.Cursor = Cursors.Default
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
        TextBox14.Text = "0"
        TextBox15.Text = "0"
        TextBox16.Text = ""
        TextBox17.Text = "0"
        TextBox19.Text = ""
        TextBox18.Text = ""
        TextBox23.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox28.Text = ""
        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = "0"
        TextBox32.Text = "0"
        TextBox33.Text = "0"
        TextBox34.Text = "0"
        TextBox35.Text = "0"
        TextBox36.Text = "0"
        TextBox37.Text = "0"
        TextBox38.Text = "0"
        aenderung = False
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        DataGridView1.Visible = False
        RichTextBox1.Visible = True
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        Altname = " "
        Label37.Visible = False
        TextBox30.Visible = False
        dsToernverwaltung.Boot.Clear()
        ListBox1.Items.Clear()
        Zusatzkosten.Location = New Point(15, 780)
        bsBoot.AddNew()
    End Sub

    Private Sub FormularLoeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormularLoeschenButton.Click
        Formularloeschen()
    End Sub

    Private Sub BootloeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BootloeschenButton.Click
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim torname As String
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where bootsname like '%" & TextBox18.Text & "%' order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        If TextBox18.Text > "" Then
            Select Case bsToernname.Count
                Case 0
                    msg = MsgBox(" Das Boot: " & Convert.ToString(TextBox18.Text) & " wird gelöscht.", 1, "Löschen")
                    If msg = vbOK Then
                        bsBoot.RemoveCurrent()
                        taBoot.Update(dsToernverwaltung)
                    End If
                Case Else
                    torname = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString
                    MsgBox(" Der Törn " & Convert.ToString(torname) & " fährt noch mit diesem Boot. " & Chr(10) & Chr(13) & "          Löschen ist nicht möglich.")
            End Select
            Formularloeschen()
        Else
            MsgBox("Wähle zuerst ein Boot aus.")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub

    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsBoot.Current
        DataGridView1.Visible = True
        GroupBox2.Text = "Crew auswählen mit Doppelklick"
        GroupBox1.Enabled = False
        Label36.Text = ""
        RichTextBox1.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        '       TextBox18.Text = RTrim(TextBox18.Text)
        If TextBox18.Text > "  " Then
            If Len(TextBox18.Text) > 1 Then
                If Mid(TextBox18.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox18.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from boot order by bootname"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from boot where bootname like '%" & TextBox18.Text & "%'  order by bootname"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from boot where Mid(bootname,1,1) like '%" & TextBox18.Text & "%'  order by bootname"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from boot order by bootname"
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        xAdapter.Fill(dsToernverwaltung.Boot)
        Select Case bsBoot.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from boot order by bootname"
                xAdapter.Fill(dsToernverwaltung.Boot)
                Formularloeschen()
            Case 1
                bsBoot.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                RichTextBox1.Visible = True
                '               aenderung = True
                GroupBox2.Text = "Bemerkung"
                GroupBox1.Enabled = True
                ComboBox4.Text = dsToernverwaltung.Boot.Rows(0)("Charterfirma").ToString
                ComboBox2.Text = dsToernverwaltung.Boot.Rows(0)("Schiffstyp").ToString
                ComboBox3.Text = dsToernverwaltung.Boot.Rows(0)("Kielart").ToString
                ComboBox1.Text = dsToernverwaltung.Boot.Rows(0)("Grosssegelart").ToString
                aaa = dsToernverwaltung.Boot.Rows(0)("bootname").ToString
                aaa = aaa.Replace(" ", "")
                If TextBox21.Text = "Katamaran" Then
                    TextBox16.Text = "2x " + TextBox39.Text
                Else
                    TextBox16.Text = TextBox39.Text
                End If

                ' Bild soll optimal an die Größe der PictureBox 
                ' angepasst und angezeigt werden
                Dim bootfoto As Image
                If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "1.jpg"))) Then
                    bootfoto = Image.FromFile(Trim$((boot + aaa + "1.jpg")))
                    With PictureBox2
                        .Image = AutoSizeI.AutoSizeImage(bootfoto, 125, 225)
                    End With
                Else
                    PictureBox2.Image = Nothing
                End If
                If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "2.jpg"))) Then
                    bootfoto = Image.FromFile(Trim$((boot + aaa + "2.jpg")))
                    With PictureBox3
                        .Image = AutoSizeI.AutoSizeImage(bootfoto, 125, 225)
                    End With
                Else
                    PictureBox3.Image = Nothing
                End If
                Altname = TextBox18.Text
                If IsNumeric(TextBox30.Text) Then
                    TextBox30.Visible = True
                    Label37.Visible = True
                End If
                ToernSuche()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsBoot.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsBoot.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.Boot.Rows(i)("bootname").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub ToernSuche()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        ListBox1.Items.Clear()
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from toernname where bootsname like '" & TextBox18.Text & "' order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        iii = bsToernname.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.Toernname.Rows(i)("Toernbezeichnung").ToString
            ListBox1.Items.Add(aaa)
        Next

    End Sub
    Private Sub TextBox18_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox18.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        suchen()
        DataGridView1.Visible = False
        RichTextBox1.Visible = True
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        GroupBox1.Focus()
        ComboBox4.Focus()
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.taCharter.FillBy(Me.dsToernverwaltung.Charter)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If ListBox1.Text > " " Then
            Menü.ToernKey = ListBox1.Text
            FormUi.ShowChild(Toern)
        End If

    End Sub


    Private Sub ButtonDruck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDruck.Click
        If TextBox18.Text > " " Then
            Dim XB As New PrintOutBO
            Dim dv As DataView
            Dim t As DataTable
            dv = bsBoot.List
            t = dv.ToTable("Printing", False, "Bootname", "Marke", "Schiffstyp", "Kielart", "Schiffsnummer", "Durchfahrtshoehe", "Länge", "Breite", "Verdrängung", "Tiefgang", "Großsegel", "Vorsegel", "Wassertank", "Dieseltank", "Kabinenanzahl", "Kojenanzahl", "Nassraeumeanzahl", "Motor", "Kaution", "Charterfirma", "Bemerkung", "MMSI", "Grosssegelart", "Baujahr", "Marinaort", "Ansprechsperson", "Mobile", "Radar", "Bugstrahlruder", "Clubnachlas", "Heizung", "Klimaanlage", "Marina", "Reinigung", "Bettzeug", "Aussenborder", "Gas", "Spinaker", "Marinakosten", "SonstigeKosten", "Inverter", "WiFi", "Permit", "VerbrauchLiterproSm")
            XB.PrintBootBlatt(t)
        End If
    End Sub

    Private Sub TextBox18_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.LostFocus
        If Menü.bootkey > " " Then
        Else
            TextBox18.Text = TextBox18.Text.Replace("'", " ")
            If Altname <> TextBox18.Text And Altname > " " Then
                '               aenderung = True
            Else
                Bootpruefen()
            End If
        End If
    End Sub
    Private Sub Bootpruefen()
        If TextBox18.Text > "   " Then
            Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim r As System.Data.DataRowView = bsBoot.Current
            Dim ein1 As String
            xAdapter.SelectCommand = New OleDb.OleDbCommand
            xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            TextBox18.Text = RTrim(TextBox18.Text)
            ein1 = TextBox18.Text
            If TextBox18.Text > "  " Then
                xAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & TextBox18.Text & "' "
            End If
            bsBoot.CancelEdit()
            '            aenderung = True
            dsToernverwaltung.Boot.Clear()
            xAdapter.Fill(dsToernverwaltung.Boot)
            If bsBoot.Count = 1 Then
                suchen()
            Else
                '               Try

                '               Catch ex As Exception
                'dsToernverwaltung.Boot.Clear()
                '            

                '              End Try
                bsBoot.AddNew()
                TextBox18.Text = ein1
            End If
            GroupBox1.Focus()
            ComboBox4.Focus()
        End If
    End Sub

    Private Sub BootsnameAenderung()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from toernname where bootsname =   '" & Altname & "'  "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        For Me.iii = 0 To bsToernname.Count - 1
            dsToernverwaltung.Toernname.Rows(iii)("Bootsname") = TextBox18.Text
            bsToernname.EndEdit()
            taToernname.Update(dsToernverwaltung.Toernname)
        Next

        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from toernkalkulation where Boot =   '" & Altname & "'  "
        bsToernKalkulation.CancelEdit()
        dsToernverwaltung.ToernKalkulation.Clear()
        xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        For Me.iii = 0 To bsToernKalkulation.Count - 1
            dsToernverwaltung.ToernKalkulation.Rows(iii)("Boot") = TextBox18.Text
            bsToernKalkulation.EndEdit()
            taToernKalkulation.Update(dsToernverwaltung.ToernKalkulation)
        Next

        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Bootkalkulation where boot =   '" & Altname & "'  "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        xAdapter.Fill(dsToernverwaltung.BootKalkulation)
        bsBootKalkulation.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        For Me.iii = 0 To bsBootKalkulation.Count - 1
            dsToernverwaltung.BootKalkulation.Rows(iii)("Boot") = TextBox18.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        Next

        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Bootlog where bootname =   '" & Altname & "'  "
        bsBootLog.CancelEdit()
        DsLogbuch.BootLog.Clear()
        xAdapter.Fill(DsLogbuch.BootLog)
        bsBootLog.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        For Me.iii = 0 To bsBootLog.Count - 1
            DsLogbuch.BootLog.Rows(iii)("Bootname") = TextBox18.Text
            bsBootLog.EndEdit()
            taBootLog.Update(DsLogbuch.BootLog)
        Next

        Dim bbb As String
        Dim ccc As String
        aaa = Altname
        aaa = aaa.Replace(" ", "")
        bbb = Trim$((boot + aaa + "1.jpg"))
        ccc = Trim$((TextBox18.Text + "1.jpg"))
        ccc = ccc.Replace(" ", "")
        If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "1.jpg"))) Then
            Try
                My.Computer.FileSystem.CopyFile(bbb, boot + ccc)
                PictureBox2.Image = Image.FromFile(Trim$((boot + ccc)))
                System.IO.File.Delete(bbb)
            Catch ex As Exception
                MsgBox(" Bei umbenennen des Bootfotos " & Convert.ToString(bbb) & " ist ein Fehler aufgetretten.")
            End Try
        End If
        bbb = Trim$((boot + aaa + "2.jpg"))
        ccc = Trim$((TextBox18.Text + "2.jpg"))
        ccc = ccc.Replace(" ", "")
        If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "2.jpg"))) Then
            Try
                My.Computer.FileSystem.CopyFile(bbb, boot + ccc)
                PictureBox3.Image = Image.FromFile(Trim$((boot + ccc)))
                System.IO.File.Delete(bbb)
            Catch ex As Exception
                MsgBox(" Bei umbenennen des Bootfotos " & Convert.ToString(bbb) & " ist ein Fehler aufgetretten.")
            End Try
        End If

    End Sub
   Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        GroupBox4.Size = New Point(1100, 700)
        GroupBox4.Visible = True
        GroupBox4.Location = New Point(11, 13)
        GroupBox1.Visible = False
        PictureBox4.Size = New Point(1100, 700)
        PictureBox4.Location = New Point(1, 1)
        aaa = dsToernverwaltung.Boot.Rows(0)("bootname").ToString
        aaa = aaa.Replace(" ", "")

        ' Bild soll optimal an die Größe der PictureBox 
        ' angepasst und angezeigt werden
        Dim bootfoto As Image
        If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "1.jpg"))) Then
            bootfoto = Image.FromFile(Trim$((boot + aaa + "1.jpg")))
            With PictureBox4
                .Image = AutoSizeI.AutoSizeImage(bootfoto, 1100, 700)
            End With
        Else
            PictureBox4.Image = Nothing
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        GroupBox4.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        GroupBox4.Size = New Point(1100, 700)
        GroupBox4.Visible = True
        GroupBox4.Location = New Point(11, 13)
        GroupBox1.Visible = False
        PictureBox4.Size = New Point(1100, 700)
        PictureBox4.Location = New Point(1, 1)
        aaa = dsToernverwaltung.Boot.Rows(0)("bootname").ToString
        aaa = aaa.Replace(" ", "")

        ' Bild soll optimal an die Größe der PictureBox 
        ' angepasst und angezeigt werden
        Dim bootfoto As Image
        If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "2.jpg"))) Then
            bootfoto = Image.FromFile(Trim$((boot + aaa + "2.jpg")))
            With PictureBox4
                .Image = AutoSizeI.AutoSizeImage(bootfoto, 1100, 700)
            End With
        Else
            PictureBox4.Image = Nothing
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Zusatzkosten.Location = New Point(20, 146)
        PictureBox6.Location = New Point(750, 200)
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Zusatzkosten.Location = New Point(15, 780)
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label46.Text = "Suchen"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label46.Text = ""
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        aenderung = True
        SpeichernButton.Text = "Änderung speichern"
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        Label46.Text = "Ändern"
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        Label46.Text = ""
    End Sub

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        If ComboBox2.Text = "Katamaran" Then
            TextBox16.Text = "2x " + TextBox39.Text
        Else
            TextBox16.Text = TextBox39.Text
        End If

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        ' Bild soll optimal an die Größe der PictureBox 
        ' angepasst und angezeigt werden
        aaa = TextBox25.Text
        aaa = aaa.Replace(" ", "")
        Dim Marinafoto As Image
        If My.Computer.FileSystem.FileExists(Trim$((Marina + aaa + ".jpg"))) Then
            GroupBox4.Size = New Point(1100, 700)
            GroupBox4.Visible = True
            GroupBox4.Location = New Point(11, 13)
            GroupBox1.Visible = False
            PictureBox4.Size = New Point(1100, 700)
            PictureBox4.Location = New Point(1, 1)
            Marinafoto = Image.FromFile(Trim$((Marina + aaa + ".jpg")))
            With PictureBox4
                .Image = AutoSizeI.AutoSizeImage(Marinafoto, 1100, 700)
            End With
        Else
            PictureBox4.Image = Nothing
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        GroupBox4.Visible = False
        GroupBox1.Visible = True
    End Sub
End Class
