Public Class Crew
     Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public crewprogramm As Boolean = True
    Dim position As Integer
    Dim buch1 As String
    Dim foto As String
    Dim vznameAlt As String = ""
    '
    '                               Achtung             Wohnland wird in ToerNr gespeichert
    '
    Private Sub crew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        ' Todestag mit F5 am Geburtstag
        '
        Me.taPostleitzahlen.Fill(Me.dsToernverwaltung.Postleitzahlen)
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        foto = GetSetting("Foto", "Pfad", "T")
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        Dim land As String
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        addskipper()
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        aaa = bsCrewAdressen.Count
        Label23.Text = "Anzahl der gespeicherten Adressen: " + aaa
        bsCrewAdressen.AddNew()
        aenderung = False
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Crew - Status' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        If bsListdaten.Count = 1 Then
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            '           comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        pAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Crew - Land' "
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
            '           comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If

        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        With DataGridView1
            .Columns(0).Width = 150
        End With
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        land = GetSetting("Land", "Einstellungen", "T", "A")
        If land = "D" Then
            RadioButton1.Text = "SKS"
            RadioButton2.Text = "SSS"
            RadioButton4.Text = "SHS"
            RadioButton3.Visible = False
        End If
        RadioButton7.Checked = True
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        If Menü.crewkey > " " Then
            TextBox15.Text = Menü.crewkey
            suchen()
        End If
        Button3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        ButtonAdresse.Visible = False
    End Sub
    Private Sub comboFuellen(ByVal text)
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
    Private Sub SpeichernButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernButton.Click
        Dim msgantw As String
        '
        '                                Speichern
        If (vznameAlt <> TextBox1.Text + " " + TextBox15.Text) And vznameAlt > "" Then
            msgantw = MsgBox("Änderung des Name durchführen?", 4)
            If msgantw = "6" Then
                aenderung = True
            Else
                GoTo endesp
            End If
        End If
        If MaskedTextBox2.Text = "  ,  ," Then MaskedTextBox2.Text = "01.01.2000"
        Me.Cursor = Cursors.WaitCursor
        If aenderung Then
            iii = ListBox2.Items.Count - 1
            For i = 0 To iii
                aaa = ListBox2.Items(i).ToString
                CrewTC()
            Next
            iii = ListBox3.Items.Count - 1
            For i = 0 To iii
                aaa = ListBox3.Items(i).ToString
                CrewSkipper()
            Next
            iii = ListBox3.Items.Count - 1
            For i = 0 To iii
                aaa = ListBox3.Items(i).ToString
                Kurs()
            Next
        End If
        speichern()
        SpeichernButton.Text = "Speichern"
endesp: Me.Cursor = Cursors.Default
    End Sub
    Private Sub Kurs()

    End Sub
    Private Sub CrewTC()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from tc where vzname = '" & vznameAlt & "'  and Toern = '" & aaa & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        aaa = bsTC.Count
        dsToernverwaltung.TC.Rows(0)("vzname") = TextBox1.Text + " " + TextBox15.Text
        bsTC.EndEdit()
        taTC.Update(dsToernverwaltung.TC)
    End Sub
    Private Sub CrewSkipper()
        Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        aAdapter.SelectCommand.CommandText = "Select * from toernname where toernbezeichnung like '" & aaa & "' order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        aAdapter.Fill(dsToernverwaltung.Toernname)
        dsToernverwaltung.Toernname.Rows(0)("Skipper") = TextBox1.Text + " " + TextBox15.Text
        bsToernname.EndEdit()
        taToernname.Update(dsToernverwaltung.Toernname)
    End Sub
    Private Sub speichern()
        If TextBox15.Text > "  " And TextBox1.Text > " " Then
            TextBox7.Text = TextBox1.Text + " " + TextBox15.Text
            TextBox19.Text = ComboBox1.Text
            If aenderung Then
                bsCrewAdressen.EndEdit()
                taCrewAdressen.Update(dsToernverwaltung.CrewAdressen)
                iii = 0
            Else
                bsCrewAdressen.AddNew()
                taCrewAdressen.Update(dsToernverwaltung.CrewAdressen)
            End If
            aenderung = False
            Formularloeschen()
        Else
            MsgBox("Crew Vorname und Name sind Pflichteingabe")
            TextBox15.Focus()
        End If
    End Sub
    Private Sub Formularloeschen()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox17.Text = ""
        TextBox19.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ListBox1.Items.Clear()
        MaskedTextBox1.Text = ""
        TextBox15.Text = ""
        aenderung = False
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        RichTextBox1.Text = ""
        dsToernverwaltung.CrewAdressen.Clear()
        bsCrewAdressen.AddNew()
        PictureBox2.Image = Nothing
        Button1.Visible = True
        Button2.Visible = False
        vznameAlt = ""
        GroupBox1.Visible = True
        GroupBox5.Location = New Point(12, 812)
        GroupBox2.Enabled = True


        MaskedTextBox1.Size = New Point(171, 22)
        MaskedTextBox2.Visible = False
        PictureKreuz.Visible = False
        GroupBox5.Location = New Point(12, 800)
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        Button3.Visible = False
        LoeschenButton.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        FormularButton.Enabled = True
        SpeichernButton.Enabled = True
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton7.Checked = True
    End Sub
    Private Sub FormularButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormularButton.Click
        Formularloeschen()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        GroupBox2.Text = "Crew auswählen mit Doppelklick"
        GroupBox1.Enabled = False
        position = 0
        Label23.Text = ""
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox15.Text = RTrim(TextBox15.Text)
        If TextBox15.Text > "  " Then
            If TextBox1.Text > " " Then
                aAdapter.SelectCommand.CommandText = "Select * from crewadressen where zuname = '" & TextBox15.Text & "' and vorname = '" & TextBox1.Text & "'"
            Else
                If Len(TextBox15.Text) > 1 Then
                    If Mid(TextBox15.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox15.Text, 1, 1).ToUpper
                        aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                    Else
                        aAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox15.Text & "%' order by zuname"
                    End If
                Else
                    aAdapter.SelectCommand.CommandText = "Select * from crewadressen where  Mid(zuname,1,1) like '%" & TextBox15.Text & "%'  order by zuname"
                End If
            End If
        Else
            aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        End If
        bsCrewAdressen.CancelEdit()
        '       aenderung = True
        dsToernverwaltung.CrewAdressen.Clear()
        aAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                aAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                aAdapter.Fill(dsToernverwaltung.CrewAdressen)
                '               Formularloeschen()
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
            Case 1
                bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                ComboBox1.Text = TextBox19.Text
                ComboBox2.Text = TextBox18.Text
                GroupBox2.Text = "Bemerkung"
                GroupBox1.Enabled = True
                If TextBox10.Text > "" Then
                Else
                    If MaskedTextBox1.Text > "  ,  ,    " Then
                        TextBox10.Text = Year(Today) - Year(MaskedTextBox1.Text)
                    End If
                End If
                Dim crewfoto As Image
                aaa = dsToernverwaltung.CrewAdressen.Rows(0)("vzname").ToString
                vznameAlt = aaa
                aaa = aaa.Replace(" ", "")
                If My.Computer.FileSystem.FileExists(Trim$((foto + aaa + ".jpg"))) Then
                    crewfoto = Image.FromFile(Trim$((foto + aaa + ".jpg")))
                    With PictureBox2
                        .Image = AutoSizeI.AutoSizeImage(crewfoto, 200, 420)
                    End With
                Else
                    PictureBox2.Image = Nothing
                End If
                ToernSuche()
                Button1.Visible = False
                Button2.Visible = True
                Button2.Location = New Point(207, 601)
                If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then RadioButton7.Checked = True

                If MaskedTextBox2.Text > "  ,  ,    " Then
                    If MaskedTextBox2.Text.Substring(6, 4) > "2000" Then
                        MaskedTextBox1.Size = New Point(68, 22)
                        MaskedTextBox2.Size = New Point(68, 22)
                        MaskedTextBox2.Visible = True
                        MaskedTextBox2.Location = New Point(630, 27)
                        PictureKreuz.Visible = True
                    End If
                End If
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCrewAdressen.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
                ToernSuche()
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        suchen()
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        suchen()
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True

    End Sub


    Private Sub MaskedTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.LostFocus
        Try
            Dim geburtsdatum As Date
            If TextBox10.Text > "" Then
            Else
                If SafeData.TryParseMaskedDate(MaskedTextBox1.Text, geburtsdatum) Then
                    TextBox10.Text = Year(Today) - Year(geburtsdatum)
                Else
                End If
            End If
            TextBox9.Focus()
            If Not SafeData.TryParseMaskedDate(MaskedTextBox1.Text, geburtsdatum) OrElse geburtsdatum < Begruessung.anfang OrElse geburtsdatum > Begruessung.ende Then
                MsgBox("Datum hat falsches Format")
                MaskedTextBox1.Text = vbNullString
                TextBox10.Text = vbNullString
                MaskedTextBox1.Focus()
            End If
        Catch
        End Try
    End Sub

    Private Sub LoeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoeschenButton.Click
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        '      Dim toern As String
        Dim msg As Integer
        aaa = TextBox7.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where  vzname = '" & aaa & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        If TextBox1.Text > "" Then
            msg = MsgBox(" Die Adresse: " & Convert.ToString(TextBox7.Text) & " wird gelöscht.", 1, "Löschen")
            If msg = vbOK Then
                Select Case bsTC.Count
                    Case 0
                        bsCrewAdressen.RemoveCurrent()
                        taCrewAdressen.Update(dsToernverwaltung)
                    Case Else
                        msg = MsgBox(" Crewmitglied: " & Convert.ToString(TextBox7.Text) & " wird auch aus den Törns gelöscht.", 1, "Löschen")
                        If msg = vbOK Then
                            For ii = 0 To bsTC.Count - 1
                                bsTC.RemoveCurrent()
                                taTC.Update(dsToernverwaltung)
                            Next
                            bsCrewAdressen.RemoveCurrent()
                            taCrewAdressen.Update(dsToernverwaltung)
                        End If
                End Select
            End If
            Formularloeschen()
        Else
            MsgBox("Wähle zuerst eine Adresse aus.")
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        suchen()
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
    End Sub

    Private Sub TextBox8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.LostFocus
        If TextBox8.Text = "Ö" Or TextBox8.Text = "ö" Or TextBox8.Text = "A" Or TextBox8.Text = "a" Then
            TextBox8.Text = "Austria"
        End If
        If TextBox8.Text = "D" Or TextBox8.Text = "d" Then
            TextBox8.Text = "Germany"
        End If
        If TextBox8.Text = "P" Or TextBox8.Text = "p" Then
            TextBox8.Text = "Polen"
        End If
    End Sub

    Private Sub addskipper()
        Dim FNameColumn As New DataColumn("FirstName")
        FNameColumn.DataType = GetType(String)

        Dim LNameColumn As New DataColumn("LastName")
        LNameColumn.DataType = GetType(String)

        Dim EmployeeTable As New DataTable("dsToernverwaltung.CrewAdressen")
        EmployeeTable.Columns.Add(FNameColumn)
        EmployeeTable.Columns.Add(LNameColumn)


    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        suchen()
        DataGridView1.Visible = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True

    End Sub

    Private Sub TextBox15_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox15.KeyDown
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub ToernSuche()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        '       Dim toern As String
        '      Dim msg As Integer
        aaa = TextBox7.Text
        ListBox1.Items.Clear()
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where  vzname like '" & aaa & "' order by toern"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        bsTC.Position = 0
        iii = bsTC.Count - 1
        For i = 0 To iii
            aaa = "Crew       " + dsToernverwaltung.TC.Rows(i)("Toern").ToString
            ListBox1.Items.Add(aaa)
            ListBox2.Items.Add(dsToernverwaltung.TC.Rows(i)("Toern").ToString)
        Next


        Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernname.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        aAdapter.SelectCommand.CommandText = "Select * from toernname where Skipper like '" & TextBox7.Text & "' order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        aAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        iii = bsToernname.Count - 1
        For i = 0 To iii
            aaa = "Skipper  " + dsToernverwaltung.Toernname.Rows(i)("Toernbezeichnung").ToString
            ListBox1.Items.Add(aaa)
            ListBox3.Items.Add(dsToernverwaltung.Toernname.Rows(i)("Toernbezeichnung").ToString)
        Next

    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If TextBox4.Text > "" Or TextBox3.Text < "0000" Then
        Else
            Dim ppAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rp As System.Data.DataRowView = bsToernname.Current
            ppAdapter.SelectCommand = New OleDb.OleDbCommand
            ppAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            ppAdapter.SelectCommand.CommandText = "Select * from postleitzahlen where plz like '" & TextBox3.Text & "' "
            bsPostleitzahlen.CancelEdit()
            dsToernverwaltung.Postleitzahlen.Clear()
            ppAdapter.Fill(dsToernverwaltung.Postleitzahlen)
            If bsPostleitzahlen.Count > 0 Then
                TextBox4.Text = dsToernverwaltung.Postleitzahlen.Rows(0)("ort").ToString
                ComboBox2.Text = "Austria"
                TextBox18.Text = ComboBox2.Text
            End If
        End If
    End Sub
    Private Sub TextBox17_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.LostFocus
        If TextBox17.TextLength = 1 And (TextBox17.Text = "h" Or TextBox17.Text = "H") Then
            TextBox17.Text = "Herr"
        End If
        If TextBox17.TextLength = 1 And (TextBox17.Text = "f" Or TextBox17.Text = "F") Then
            TextBox17.Text = "Frau"
        End If
        If TextBox17.TextLength = 0 Then
            TextBox2.Focus()
            aenderung = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox15.Text > "" Then
            Crewformular.RadioButton2.Checked = True
        Else
            Crewformular.TextBox15.Text = TextBox15.Text
            Crewformular.RadioButton1.Checked = True
            Crewformular.Label3.Enabled = True
            Crewformular.PictureBox1.Enabled = True
            Crewformular.TextBox15.Enabled = True
            Crewformular.TextBox2.Enabled = True
            Crewformular.GroupBox1.Enabled = True
        End If
        FormUi.ShowChild(Crewformular)
    End Sub

    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If ListBox1.Text > " " Then
            Menü.ToernKey = ListBox1.Text.Substring(11, Len(ListBox1.Text) - 11)
            FormUi.ShowChild(Toern)
        End If
    End Sub

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        TextBox18.Text = ComboBox2.Text
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label28.Visible = False
        TextBox20.Visible = False
        GroupBox1.Visible = False
        GroupBox5.Location = New Point(12, 210)
        GroupBox2.Enabled = False
    End Sub
    Private Sub alleDaten()
        Dim XL As New PrintOutAA
        Dim dv As DataView
        Dim t As DataTable
        aaa = bsCrewAdressen.Count
        dv = bsCrewAdressen.List
        dsToernverwaltung.CrewAdressen.Rows(0)("R3") = " "

        t = dv.ToTable("Printing", False, "Zuname", "Vorname", "Anrede", "Handy", "email", "straße", "plz", "ort", "Reisepassnr", "gebdatum", "gebort", "funk", "segelschein", "nationalitaet", "status", "Bemerkung", "FB1", "FB2", "FB3", "FB4", "A-schein", "Motorboot", "toernnr", "R3")
        XL.PrintAdressen(t)
    End Sub

    Private Sub TextBox15_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.LostFocus
        TextBox15.Text = TextBox15.Text.Replace("'", "´")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        GroupBox4.Visible = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim crewfoto As Image
        GroupBox4.Size = New Point(1000, 700)
        GroupBox4.Location = New Point(10, 10)
        PictureBox3.Size = New Point(1000, 700)
        PictureBox3.Location = New Point(1, 1)
        GroupBox4.Visible = True
        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("vzname").ToString
        aaa = aaa.Replace(" ", "")
        If My.Computer.FileSystem.FileExists(Trim$((foto + aaa + ".jpg"))) Then
            crewfoto = Image.FromFile(Trim$((foto + aaa + ".jpg")))
            With PictureBox3
                .Image = AutoSizeI.AutoSizeImage(crewfoto, 1000, 700)
            End With
        Else
            PictureBox3.Image = Nothing
        End If

    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.F5 Then
            MaskedTextBox1.Size = New Point(68, 22)
            MaskedTextBox2.Size = New Point(68, 22)
            MaskedTextBox2.Location = New Point(630, 24)
            PictureKreuz.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label27.Text = "Suchen"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label27.Text = ""
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        aenderung = True
        SpeichernButton.Text = "Änderung speichern"
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        Label27.Text = "Ändern"
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        Label27.Text = ""
    End Sub
    Private Sub Brief()
        Dim XL As New PrintOutBF
        Dim dv As DataView
        Dim t As DataTable
        aaa = bsCrewAdressen.Count
        dv = bsCrewAdressen.List
        t = dv.ToTable("Printing", False, "Zuname", "Vorname", "Anrede", "straße", "plz", "ort")
        XL.PrintBrief(t)
    End Sub

    Private Sub RadioButton5_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Label28.Visible = False
            TextBox20.Visible = False
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            ButtonAdresse.Visible = True
        End If
    End Sub
    Private Sub ButtonAdresse_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAdresse.Click
        alleDaten()
        GroupBox1.Visible = True
        GroupBox5.Location = New Point(12, 812)
        GroupBox2.Enabled = True
    End Sub

    Private Sub RadioButton6_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Label28.Visible = True
            TextBox20.Visible = True
            TextBox20.Text = 1
            TextBox20.Focus()
            GroupBox1.Visible = True
            GroupBox1.Enabled = False
            GroupBox2.Enabled = True
            GroupBox2.Text = "Kurze Briefnachricht"
            RichTextBox1.Text = ""
            Button3.Visible = True
            LoeschenButton.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            '          FormularButton.Enabled = False
            SpeichernButton.Enabled = False
            RadioButton6.Checked = False
        End If
    End Sub
    Private Sub briefDrucken()
        Brief()
        GroupBox5.Location = New Point(12, 800)
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Enabled = True
        Button3.Visible = False
        LoeschenButton.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        FormularButton.Enabled = True
        SpeichernButton.Enabled = True
        suchen()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        briefDrucken()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        GroupBox1.Visible = True
        GroupBox5.Location = New Point(12, 812)
        GroupBox2.Enabled = True

    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        GroupBox4.Visible = False
    End Sub
End Class
