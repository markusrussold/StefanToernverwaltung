Public Class Toern
    Public logbuch As String
    Public bericht As String
    Public aenderung As Boolean
    Public Namensaenderung As Boolean
    Public ToernAlt As String
    Public sum1 As Single
    Public sum2 As Single
    Public iii As Integer
    Public aaa As String
    Public ij As Integer
    Public picture As Single
    Dim marina As String
    Dim Karte As Image
    Dim PDFname As String
    Dim buch1 As String
    Dim position As Integer
    Dim idnr As Integer
    Dim IDcheck As Boolean
    Dim route As String
    Dim bildB As Single
    Dim msg As Integer
    Dim BildH As Single
    Dim faktor As Single
    Dim bildKleinBreite As Integer = 330
    Dim bildKleinhoehe As Integer = 200
    Dim bildGrossBreite As Integer = 1000
    Dim bildGrosshoehe As Integer = 700
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Dim verbrauch As Single
    Private _dateDiff As Integer
    Dim sPath As String
    Dim ansteuerungszaehler As Integer
    Dim nachtfahrtenzaehler As Integer
 
    Private Sub Toern_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Me.taBordkassa.Fill(Me.dsToernverwaltung.Bordkassa)
         Me.taWacheplan.Fill(Me.dsToernverwaltung.Wacheplan)
        '
        '  Crewmitgliedsalter in der Tabelle TC in R1 gespeichert
        '
        '  Ordner für Fotoalbum in der Tabelle Toern in R1 gespeichert
        '
        ' IDToern wird nicht mehr verwendet
        '
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Dim spath As String
        Dim spath1 As String
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        route = GetSetting("Karte", "Pfad", "T", "")
        logbuch = GetSetting("Logbuch", "Pfad", "T", "")
        marina = GetSetting("Marina", "Pfad", "T")
        If logbuch = "" Then
            MsgBox("Speicherplatz der Logbücher ist nicht festgelegt - Extras/Speicherort anpassen ")
            Me.Close()
        End If
        bericht = GetSetting("Berichte", "Pfad", "T")
        If bericht = "" Then
            MsgBox("Speicherplatz der Törnberichte ist nicht festgelegt - Extras/Speicherort anpassen ")
            Me.Close()
        End If
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from boot order by bootname"
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        DbAccess.SafePosition(bsBoot)
        iii = bsBoot.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.Boot.Rows(i)("Bootname").ToString
            ComboBox1.Items.Add(aaa)
        Next

        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from CrewAdressen order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        iii = bsCrewAdressen.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.CrewAdressen.Rows(i)("vzname").ToString
            ComboBox2.Items.Add(aaa)
        Next

        bsToernname.AddNew()
        aenderung = False
        DataGridView1.Columns(0).Frozen = True
        '       DataGridView1.Columns(2).HeaderText = "Geburtsdatum"
        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView2.Columns(0).Width = 150

        Dim LAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rl As System.Data.DataRowView = bsBoot.Current
        LAdapter.SelectCommand = New OleDb.OleDbCommand
        LAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        LAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Törn - Revier 1' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        LAdapter.Fill(dsToernverwaltung.Listdaten)
        DbAccess.SafePosition(bsListdaten)
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
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        LAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        LAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Törn - Revier 2' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        LAdapter.Fill(dsToernverwaltung.Listdaten)
        DbAccess.SafePosition(bsListdaten)
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
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If

        LAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        LAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Törn - Revier 3' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        LAdapter.Fill(dsToernverwaltung.Listdaten)
        DbAccess.SafePosition(bsListdaten)
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
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If

        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        MaskedTextBox5.Mask = "00:00"
        MaskedTextBox6.Mask = "00:00"
        MaskedTextBox7.Mask = "00.00.0000"
        MaskedTextBox8.Mask = "00.00.0000"
        MaskedTextBox9.Mask = "00.00.0000"
        MaskedTextBox10.Mask = "00.00.0000"
        MaskedTextBox11.Mask = "00:00"
        MaskedTextBox12.Mask = "00:00"
        MaskedTextBox13.Mask = "00:00"
        MaskedTextBox14.Mask = "00:00"
        MaskedTextBox15.Mask = "00.00.0000"
        MaskedTextBox16.Mask = "00.00.0000"
        MaskedTextBox17.Mask = "00:00"
        MaskedTextBox18.Mask = "00:00"
        MaskedTextBox19.Mask = "00.00.0000"
        MaskedTextBox20.Mask = "00.00.0000"
        MaskedTextBox21.Mask = "00:00"
        MaskedTextBox22.Mask = "00:00"
        '       checkboxLoeschen()
        Formularloeschen()
        spath = Application.StartupPath & "\Berichte\"
        spath = bericht
        Dim odir As New System.IO.DirectoryInfo(spath)
        Dim ofiles As System.IO.FileInfo() = odir.GetFiles
        spath1 = logbuch
        Dim odir1 As New System.IO.DirectoryInfo(spath1)
        Dim ofiles1 As System.IO.FileInfo() = odir1.GetFiles
        If Menü.ToernKey > " " Then
            TextBox1.Text = Menü.ToernKey
        Else
            TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        End If
        suchen()
        TextBox5.Text = nachtfahrtenzaehler
        TextBox14.Text = ansteuerungszaehler
        Label62.Text = ""
        Label63.Text = ""
        Label64.Text = ""

    End Sub
    Private Sub comboFuellen3(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox3.Items.Add(text)
            End If
        End If

    End Sub
    Private Sub checkboxLoeschen()
        CheckBox1.Text = ""
        CheckBox2.Text = ""
        CheckBox3.Text = ""
        CheckBox4.Text = ""
        CheckBox5.Text = ""
        CheckBox6.Text = ""
        CheckBox7.Text = ""
        CheckBox8.Text = ""
        CheckBox9.Text = ""
        CheckBox10.Text = ""
        CheckBox11.Text = ""
        CheckBox12.Text = ""


        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False
        CheckBox9.Visible = False
        CheckBox10.Visible = False
        CheckBox11.Visible = False
        CheckBox12.Visible = False
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
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        checkboxLoeschen()
        GroupBox1.Enabled = False
        GroupBox4.Enabled = False
        GroupBox2.Text = "Törn auswählen mit Doppelklick"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
         xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox1.Text & "' "
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
                DbAccess.SafePosition(bsToernname)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                ComboBox2.Text = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString
                ComboBox1.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                ansteuerungszaehler = 0
                GroupBox4.Enabled = True
                CrewlisteAnzeigen()
                GroupBox1.Enabled = True
                PDFname = TextBox1.Text.Replace(" ", "") & ".pdf"
                If System.IO.File.Exists(bericht & PDFname) Then
                    Button5.Enabled = True
                Else
                    Button5.Enabled = False
                End If
                If System.IO.File.Exists(logbuch & PDFname) Then
                    Button7.Enabled = True
                Else
                    Button7.Enabled = False
                End If
                If dsToernverwaltung.Toernname.Rows(0)("R1").ToString > "" Then
                    buttonAlbum.Enabled = True
                Else
                    buttonAlbum.Enabled = False
                End If
                ComboBox3.Text = TextBox17.Text
                ButtonCrewSuchen.Enabled = True
                aaa = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString
                aaa = aaa.Replace(" ", "")
                aaa = aaa.Replace("/", "")
                If My.Computer.FileSystem.FileExists(Trim$((route + aaa + ".jpg"))) Then
                    Karte = Image.FromFile(Trim$((route + aaa + ".jpg")))
                    With PictureBox4
                        .Image = AutoSizeI.AutoSizeImage(Karte, bildKleinBreite, bildKleinhoehe, True)
                    End With
                Else
                    PictureBox4.Image = Nothing
                End If
                TextBox18.Visible = True
                If IsNumeric(TextBox19.Text) And IsNumeric(TextBox7.Text) Then
                    verbrauch = TextBox19.Text / TextBox7.Text
                    verbrauch = CSng(Math.Round(CDbl(verbrauch), 2))
                    Label5.Text = verbrauch.ToString + " l/sm"
                End If
                aenderung = True
                Nachtfahrten()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
        End Select
    End Sub
    Private Sub datenbaknul()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like 'XxXXxxYxYYxxa'"
        bsToernname.CancelEdit()
        aenderung = False
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.AddNew()
    End Sub
    Private Sub Formularloeschen()
        dsToernverwaltung.Toernname.Clear()
        bsToernname.AddNew()
        PictureBox4.Image = Nothing
        TextBox17.Text = " "
        DataGridView4.Rows.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        datenbaknul()
        IDcheck = False
        Label5.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = "0"
        TextBox6.Text = "0"
        TextBox7.Text = "0"
        TextBox8.Text = "0"
        TextBox9.Text = "0"
        TextBox10.Text = "0"
        TextBox11.Text = "0"
        TextBox14.Text = "0"
        TextBox18.Text = ""
        TextBox21.Text = ""
        TextBox18.Visible = False
        MaskedTextBox1.Text = " "
        MaskedTextBox2.Text = " "
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        checkboxLoeschen()
        CheckletzterTag.Checked = False
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False
        CheckBox9.Visible = False
        CheckBox10.Visible = False
        CheckBox11.Visible = False
        CheckBox12.Visible = False
        DataGridView2.Visible = False
        GroupBox1.Enabled = True
        Button3.Enabled = False
        ButtonCrewSuchen.Enabled = False
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Size = New Point(708, 395)
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        '        Button5.Visible = True
        '       Button7.Visible = True
        Button5.Enabled = False
        Button7.Enabled = False
        GroupBox4.Text = "Crew"
        ButtenVorher.Enabled = False
        ButtonNaechst.Enabled = True

    End Sub

    Private Sub CrewlisteAnzeigen()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' order by vzname"
         '      tAdapter.SelectCommand.CommandText = "Select * from TC where idtoern = '" & TextBox15.Text & "' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        '        aaa = TextBox15.Text
        ij = bsTC.Count
        If ij >= 1 Then
            CheckBox1.Text = dsToernverwaltung.TC.Rows(0)("vzname").ToString
            CheckBox1.Visible = True
            CheckBox1.Checked = True
            NachtanAusgabe(0)
            If ij >= 2 Then
                CheckBox2.Text = dsToernverwaltung.TC.Rows(1)("vzname").ToString
                CheckBox2.Visible = True
                CheckBox2.Checked = True
                NachtanAusgabe(1)
                If ij >= 3 Then
                    CheckBox3.Text = dsToernverwaltung.TC.Rows(2)("vzname").ToString
                    CheckBox3.Visible = True
                    CheckBox3.Checked = True
                    NachtanAusgabe(2)
                    If ij >= 4 Then
                        CheckBox4.Text = dsToernverwaltung.TC.Rows(3)("vzname").ToString
                        CheckBox4.Visible = True
                        CheckBox4.Checked = True
                        NachtanAusgabe(3)
                        If ij >= 5 Then
                            CheckBox5.Text = dsToernverwaltung.TC.Rows(4)("vzname").ToString
                            CheckBox5.Visible = True
                            CheckBox5.Checked = True
                            NachtanAusgabe(4)
                            If ij >= 6 Then
                                CheckBox6.Text = dsToernverwaltung.TC.Rows(5)("vzname").ToString
                                CheckBox6.Visible = True
                                CheckBox6.Checked = True
                                NachtanAusgabe(5)
                                If ij >= 7 Then
                                    CheckBox7.Text = dsToernverwaltung.TC.Rows(6)("vzname").ToString
                                    CheckBox7.Visible = True
                                    CheckBox7.Checked = True
                                    NachtanAusgabe(6)
                                    If ij >= 8 Then
                                        CheckBox8.Text = dsToernverwaltung.TC.Rows(7)("vzname").ToString
                                        CheckBox8.Visible = True
                                        CheckBox8.Checked = True
                                        NachtanAusgabe(7)
                                        If ij >= 9 Then
                                            CheckBox9.Text = dsToernverwaltung.TC.Rows(8)("vzname").ToString
                                            CheckBox9.Visible = True
                                            CheckBox9.Checked = True
                                            NachtanAusgabe(8)
                                            If ij >= 10 Then
                                                CheckBox10.Text = dsToernverwaltung.TC.Rows(9)("vzname").ToString
                                                CheckBox10.Visible = True
                                                CheckBox10.Checked = True
                                                NachtanAusgabe(9)
                                                If ij >= 11 Then
                                                    CheckBox11.Text = dsToernverwaltung.TC.Rows(10)("vzname").ToString
                                                    CheckBox11.Checked = True
                                                    CheckBox11.Visible = True
                                                    NachtanAusgabe(10)
                                                    If ij = 12 Then
                                                        CheckBox12.Text = dsToernverwaltung.TC.Rows(11)("vzname").ToString
                                                        CheckBox12.Visible = True
                                                        CheckBox12.Checked = True
                                                        NachtanAusgabe(11)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Durchschnittsalter()
    End Sub
    Private Sub NachtanAusgabe(ByVal nr)
        Dim na As String
        Dim da As String
        Dim ze As String
        Dim ha As String
        Dim gu As Boolean = True

        na = dsToernverwaltung.TC.Rows(nr)("vzname").ToString
        If na = ComboBox2.Text Then
            MsgBox(" Achtung Crewmitglied ist Skipper!")
        End If
        da = dsToernverwaltung.TC.Rows(nr)("nachtadatum1").ToString
        ze = dsToernverwaltung.TC.Rows(nr)("nachtazeit1").ToString
        ha = dsToernverwaltung.TC.Rows(nr)("nachtahafen1").ToString
        If Not IsDBNull(ha) Then
            If ha > "" Then
                DataGridView4.Rows.Add(na, da, ze, ha, gu)
                ansteuerungszaehler += 1
            End If
        End If
        na = dsToernverwaltung.TC.Rows(nr)("vzname").ToString
        da = dsToernverwaltung.TC.Rows(nr)("nachtadatum2").ToString
        ze = dsToernverwaltung.TC.Rows(nr)("nachtazeit2").ToString
        ha = dsToernverwaltung.TC.Rows(nr)("nachtahafen2").ToString
        If Not IsDBNull(ha) Then
            If ha > "" Then
                DataGridView4.Rows.Add(na, da, ze, ha, gu)
                ansteuerungszaehler += 1
            End If
        End If
        na = dsToernverwaltung.TC.Rows(nr)("vzname").ToString
        da = dsToernverwaltung.TC.Rows(nr)("nachtadatum3").ToString
        ze = dsToernverwaltung.TC.Rows(nr)("nachtazeit3").ToString
        ha = dsToernverwaltung.TC.Rows(nr)("nachtahafen3").ToString
        If Not IsDBNull(ha) Then
            If ha > "" Then
                DataGridView4.Rows.Add(na, da, ze, ha, gu)
                ansteuerungszaehler += 1
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        speichern()
        TextBox5.Text = nachtfahrtenzaehler
    End Sub
    Private Sub IDversorgen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where Toernbezeichnung = '" & ToernAlt & "' "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        aaa = bsToernname.Count
        DbAccess.SafePosition(bsToernname)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        TextBox16.Text = TextBox15.Text
        bsToernname.EndEdit()
        taToernname.Update(dsToernverwaltung.Toernname)
    End Sub
    Private Sub speichern()
        '
        '                                Speichern
        '
        '       dsToernverwaltung.Toernname.Rows(0)("skipper") = ComboBox2.Text
        '        dsToernverwaltung.Toernname.Rows(0)("Bootsname") = ComboBox1.Text
        '        dsToernverwaltung.Toernname.Rows(0)("letzterSegeltag") = CheckletzterTag.Checked
        '       If DBNull.Value.Equals(MaskedTextBox1.Text) Or DBNull.Value.Equals(MaskedTextBox2.Text) Then
        If SafeData.IsBlankOrMask(MaskedTextBox1.Text) OrElse SafeData.IsBlankOrMask(MaskedTextBox2.Text) Then
            MsgBox("Datum von oder Datum bis ist nicht ausgefüllt! Speichern ist nicht möglich.")
            GoTo endeSpeichern
        End If
        Dim d1 As Date
        Dim d2 As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox1.Text, d1) OrElse Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, d2) Then
            MsgBox("Datum von oder Datum bis hat ein falsches Format! Speichern ist nicht möglich.")
            GoTo endeSpeichern
        End If
        Dim diff As TimeSpan = d2 - d1
        If diff.Days < 0 Then
            MsgBox("--Datum bis--  liegt vor dem --Datum von--.")
            GoTo endeSpeichern
        End If

        If TextBox1.Text > "   " Then
            '           NachtansteuerungSpeichern()
            TextBox13.Text = ComboBox2.Text
            TextBox12.Text = ComboBox1.Text
            TextBox17.Text = ComboBox3.Text
            If TextBox9.Text = "" Then
                TextBox9.Text = "0"
            End If
            If TextBox10.Text = "" Then
                TextBox10.Text = "0"
            End If
            If TextBox8.Text = "" Then
                TextBox8.Text = "0"
            End If
            If TextBox6.Text = "" Then
                TextBox6.Text = "0"
            End If
            If TextBox7.Text = "" Then
                TextBox7.Text = "0"
            End If
            If IsNumeric(TextBox14.Text) Then
                TextBox14.Text = ansteuerungszaehler
            Else
                TextBox14.Text = 0
            End If
            If IsNumeric(TextBox5.Text) Then
                Nachtfahrten()
                TextBox5.Text = nachtfahrtenzaehler
            Else
                TextBox5.Text = 0
            End If
            If aenderung Then
                '              aaa = TextBox1.Text
                '             aaa = TextBox15.Text
                bsToernname.EndEdit()
                taToernname.Update(dsToernverwaltung.Toernname)
                iii = 0
            Else
                bsToernname.AddNew()
                taToernname.Update(dsToernverwaltung.Toernname)
                '                IDversorgen()
                ToernAlt = ""
                '         End If
            End If
        If Namensaenderung Then
            '                                                                       Crewliste
            Dim taAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsTC.Current()
            taAdapter.SelectCommand = New OleDb.OleDbCommand
            taAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            taAdapter.SelectCommand.CommandText = "Select * from tc where toern like '%" & ToernAlt & "%' order by vzname"
            bsTC.CancelEdit()
            dsToernverwaltung.TC.Clear()
            taAdapter.Fill(dsToernverwaltung.TC)
            ij = bsTC.Count
            For Me.iii = 0 To ij - 1
                dsToernverwaltung.TC.Rows(iii)("Toern") = TextBox1.Text
                bsTC.EndEdit()
                taTC.Update(dsToernverwaltung.TC)
            Next
            '                                                                     Logbuch
            Dim bbb As String
            Dim ccc As String
            aaa = ToernAlt
            aaa = aaa.Replace(" ", "")
            bbb = Trim$((logbuch + aaa + ".pdf"))
            ccc = Trim$((TextBox1.Text + ".pdf"))
            ccc = ccc.Replace(" ", "")
            If My.Computer.FileSystem.FileExists(Trim$((logbuch + aaa + ".pdf"))) Then
                My.Computer.FileSystem.CopyFile(bbb, logbuch + ccc)
                System.IO.File.Delete(bbb)
            End If
            '                                                                   Bericht
            bbb = Trim$((bericht + aaa + ".pdf"))
            ccc = Trim$((TextBox1.Text + ".pdf"))
            ccc = ccc.Replace(" ", "")
            If My.Computer.FileSystem.FileExists(Trim$((bericht + aaa + ".pdf"))) Then
                My.Computer.FileSystem.CopyFile(bbb, bericht + ccc)
                System.IO.File.Delete(bbb)
            End If
            '                                                                  Route
            bbb = Trim$((route + aaa + ".jpg"))
            ccc = Trim$((TextBox1.Text + ".jpg"))
            ccc = ccc.Replace(" ", "")
            If My.Computer.FileSystem.FileExists(Trim$((route + aaa + ".jpg"))) Then
                Try
                    My.Computer.FileSystem.CopyFile(bbb, route + ccc)
                    PictureBox4.Image.Dispose()
                    '   My.Computer.FileSystem.RenameFile(bbb, route + ccc)
                    '             System.IO.File.Delete(bbb)
                    PictureBox4.Image = Image.FromFile(Trim$((route + ccc)))
                Catch ex As Exception
                    MsgBox(" Die Karte mit der Bezeichnung " & Convert.ToString(bbb) & " muß händisch gelöscht werden.")
                End Try
            End If
            '                                                                 Wacheplan
            Dim waAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rw As System.Data.DataRowView = bsWacheplan.Current()
            waAdapter.SelectCommand = New OleDb.OleDbCommand
            waAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            waAdapter.SelectCommand.CommandText = "Select * from wacheplan where toern like '%" & ToernAlt & "%' "
            bsWacheplan.CancelEdit()
            dsToernverwaltung.Wacheplan.Clear()
            waAdapter.Fill(dsToernverwaltung.Wacheplan)
            ij = bsWacheplan.Count
            For Me.iii = 0 To ij - 1
                dsToernverwaltung.Wacheplan.Rows(iii)("Toern") = TextBox1.Text
                bsWacheplan.EndEdit()
                taWacheplan.Update(dsToernverwaltung.Wacheplan)
            Next
            '                                                                 Kassabuch
            Dim kaAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rk As System.Data.DataRowView = bsBordkassa.Current()
            kaAdapter.SelectCommand = New OleDb.OleDbCommand
            kaAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            kaAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & ToernAlt & "%' order by vzname"
            bsBordkassa.CancelEdit()
            dsToernverwaltung.Bordkassa.Clear()
            kaAdapter.Fill(dsToernverwaltung.TC)
            ij = bsBordkassa.Count
            For Me.iii = 0 To ij - 1
                dsToernverwaltung.Bordkassa.Rows(iii)("Toern") = TextBox1.Text
                bsBordkassa.EndEdit()
                taBordkassa.Update(dsToernverwaltung.Bordkassa)
            Next
            TripRenameHelper.RenameInCrewbesprechung(ToernAlt, TextBox1.Text)
        End If
        Namensaenderung = False
        aenderung = False
        Button1.Text = "Speichern"
        SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
        Formularloeschen()
        Else
        MsgBox("Törnname ist Pflichteingabe")
        TextBox1.Focus()
        End If
endeSpeichern:
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
        TextBox5.Text = nachtfahrtenzaehler
        TextBox14.Text = ansteuerungszaehler
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        IDcheck = True
        suchen()
        TextBox5.Text = nachtfahrtenzaehler
        TextBox14.Text = ansteuerungszaehler
        DataGridView1.Visible = False
        GroupBox1.Enabled = True
        GroupBox4.Enabled = True
        GroupBox2.Text = "Bemerkung"
        CheckletzterTag.Checked = dsToernverwaltung.Toernname.Rows(0)("letzterSegeltag")
        BordtageRechnung()
    End Sub
    Private Sub ButtonCrewSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrewSuchen.Click
        aaa = ij
        If aaa > TextBox1.Text Then
            MsgBox("Achtung, Boot ist ausgebucht!")
        End If
        If aaa = TextBox1.Text Then
            MsgBox("Achtung, Boot ist voll!")
        End If
        aaa = ""
        DataGridView2.Visible = True
        DataGridView2.Location = New Point(10, 20)
        GroupBox1.Enabled = False
        GroupBox1.Size = New Point(708, 350)
        Label31.Visible = True
        TextBox21.Visible = True
        Button3.Enabled = True
        GroupBox2.Text = "Crew auswählen mit Doppelklick"
        ButtonCrewSuchen.Enabled = False
    End Sub

    Private Sub Durchschnittsalter()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        Dim dAlter As Integer
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' order by vzname"
        '      tAdapter.SelectCommand.CommandText = "Select * from TC where idtoern = '" & TextBox15.Text & "' order by vzname"
        'tAdapter.SelectCommand.CommandText = "Select * from TC"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        iii = bsTC.Count - 1
        dAlter = 0
        For i = 0 To iii
            If dsToernverwaltung.TC.Rows(i)("R1").ToString > "" Then
                dAlter += dsToernverwaltung.TC.Rows(i)("R1").ToString
            Else
                dAlter = 0
            End If
        Next
        If dAlter > 0 AndAlso bsTC.Count > 0 Then
            Dim durchschnitt As Double = CDbl(dAlter) / CDbl(bsTC.Count)
            GroupBox4.Text = "Crew      Durchschnittsalter: " & durchschnitt.ToString("0.0")
        Else
            GroupBox4.Text = "Crew"
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView2.Visible = False
        GroupBox1.Enabled = True
        Button3.Enabled = False
        ButtonCrewSuchen.Enabled = True
        GroupBox2.Text = "Bemerkung"
        GroupBox1.Size = New Point(708, 395)
        Label31.Visible = False
        TextBox21.Visible = False
        TextBox21.Text = ""
        aaa = ij
        If aaa > TextBox1.Text Then
            MsgBox("Achtung, Boot ist ausgebucht!")
        End If
        If aaa = TextBox1.Text Then
            MsgBox("Achtung, Boot ist voll!")
        End If
        aaa = ""
        Durchschnittsalter()
    End Sub
    Private Sub DataGridView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        CrewWahl()
    End Sub
    Private Sub CrewWahl()
        Dim alter As Integer
        ij = DataGridView2.CurrentCell.RowIndex
        aaa = dsToernverwaltung.CrewAdressen.Rows(ij)("VZName").ToString
        If aaa = ComboBox2.Text Then
            MsgBox(" Skipper kann nicht gleichzeitig Crew sein!")
            GoTo subende
        End If
        If dsToernverwaltung.CrewAdressen.Rows(ij)("gebdatum").ToString > "" Then
            alter = Year(Today) - Year(dsToernverwaltung.CrewAdressen.Rows(ij)("gebdatum").ToString)
        Else
            alter = 40
        End If
        If CheckBox1.Text = "" Then
            CheckBox1.Text = aaa
            CheckBox1.Visible = True
            CheckBox1.Checked = True
        Else
            If CheckBox2.Text = "" Then
                CheckBox2.Text = aaa
                CheckBox2.Visible = True
                CheckBox2.Checked = True
            Else
                If CheckBox3.Text = "" Then
                    CheckBox3.Text = aaa
                    CheckBox3.Visible = True
                    CheckBox3.Checked = True
                Else
                    If CheckBox4.Text = "" Then
                        CheckBox4.Text = aaa
                        CheckBox4.Visible = True
                        CheckBox4.Checked = True
                    Else
                        If CheckBox5.Text = "" Then
                            CheckBox5.Text = aaa
                            CheckBox5.Visible = True
                            CheckBox5.Checked = True
                        Else
                            If CheckBox6.Text = "" Then
                                CheckBox6.Text = aaa
                                CheckBox6.Visible = True
                                CheckBox6.Checked = True
                            Else
                                If CheckBox7.Text = "" Then
                                    CheckBox7.Text = aaa
                                    CheckBox7.Visible = True
                                    CheckBox7.Checked = True
                                Else
                                    If CheckBox8.Text = "" Then
                                        CheckBox8.Text = aaa
                                        CheckBox8.Visible = True
                                        CheckBox8.Checked = True
                                    Else
                                        If CheckBox9.Text = "" Then
                                            CheckBox9.Text = aaa
                                            CheckBox9.Visible = True
                                            CheckBox9.Checked = True
                                        Else
                                            If CheckBox10.Text = "" Then
                                                CheckBox10.Text = aaa
                                                CheckBox10.Visible = True
                                                CheckBox10.Checked = True
                                            Else
                                                MsgBox("Max. 10 Personen werden verwaltet")
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern =  '" & TextBox1.Text & "' and vzname = '" & aaa & "' "
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        If bsTC.Count = 0 Then
            bsTC.AddNew()
            Dim drv As DataRowView = bsTC.Item(0)
            drv(1) = TextBox1.Text
            drv(2) = aaa
            drv(7) = alter
            '            drv(10) = TextBox15.Text
             bsTC.EndEdit()
            taTC.Update(dsToernverwaltung)
        End If
subende:
        TextBox21.Text = ""
        TextBox21.Focus()
    End Sub

    Private Sub ChckBoxen(ByVal checkB)
        If Not checkB.Checked Then
            checkB.Checked = True
            aaa = checkB.Text
            If aaa > "" Then
                msg = MsgBox("Crewmitglied im Törn entfernen JA, Stammdaten zeigen NEIN ", 3)
            End If
            If msg <> vbCancel Then
                If msg = vbYes Then
                    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
                    Dim rt As System.Data.DataRowView = bsTC.Current
                    tAdapter.SelectCommand = New OleDb.OleDbCommand
                    tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                    tAdapter.SelectCommand.CommandText = "Select * from TC where toern =  '" & TextBox1.Text & "' and vzname = '" & aaa & "' "
                    bsTC.CancelEdit()
                    dsToernverwaltung.TC.Clear()
                    tAdapter.Fill(dsToernverwaltung.TC)
                    If bsTC.Count = 1 Then
                        ' löschen
                        checkB.Visible = False
                        bsTC.RemoveCurrent()
                        taTC.Update(dsToernverwaltung)
                    End If
                Else
                    Menü.crewkey = aaa
                    FormUi.ShowChild(Crew)
                End If
            End If
        End If

    End Sub
    Private Sub test()
        If Not CheckBox1.Checked Then
            CheckBox1.Checked = True
            aaa = CheckBox1.Text
            msg = MsgBox("Crewmitglied entfernen JA, Stammdaten NEIN ", 3)
            If msg <> vbCancel Then
                If msg = vbYes Then
                    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
                    Dim rt As System.Data.DataRowView = bsTC.Current
                    tAdapter.SelectCommand = New OleDb.OleDbCommand
                    tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                    tAdapter.SelectCommand.CommandText = "Select * from TC where toern =  '" & TextBox1.Text & "' and vzname = '" & aaa & "' "
                    bsTC.CancelEdit()
                    dsToernverwaltung.TC.Clear()
                    tAdapter.Fill(dsToernverwaltung.TC)
                    If bsTC.Count = 1 Then
                        ' löschen
                        CheckBox1.Visible = False
                        bsTC.RemoveCurrent()
                        taTC.Update(dsToernverwaltung)
                    End If
                Else
                    Menü.crewkey = aaa
                    FormUi.ShowChild(Crew)
                End If
            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ChckBoxen(CheckBox1)
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        ChckBoxen(CheckBox2)
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        ChckBoxen(CheckBox3)
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        ChckBoxen(CheckBox4)
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        ChckBoxen(CheckBox5)
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        ChckBoxen(CheckBox6)
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        ChckBoxen(CheckBox7)
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        ChckBoxen(CheckBox8)
    End Sub
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        ChckBoxen(CheckBox9)
    End Sub
    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        ChckBoxen(CheckBox10)
    End Sub
    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        ChckBoxen(CheckBox11)
    End Sub
    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        ChckBoxen(CheckBox12)
    End Sub

    Private Sub FormularButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormularButton.Click
        Formularloeschen()
    End Sub

    Private Sub CheckletzterTag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckletzterTag.CheckedChanged
        BordtageRechnung()
    End Sub

    Private Sub MaskedTextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.LostFocus
        Dim tage As Single
        Dim d2 As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, d2) Then
            MsgBox("Datum hat falsches Format")
            MaskedTextBox2.Text = vbNullString
            MaskedTextBox2.Focus()
            Exit Sub
        End If
        If d2 < Begruessung.anfang OrElse d2 > Begruessung.ende Then
            MsgBox("Datum hat falsches Format")
            MaskedTextBox2.Text = vbNullString
            MaskedTextBox2.Focus()
        Else
            Dim d1 As Date
            If Not SafeData.TryParseMaskedDate(MaskedTextBox1.Text, d1) Then Exit Sub
            Dim diff As TimeSpan = d2 - d1
            tage = diff.Days
            TextBox4.Text = tage.ToString("#")
        End If
    End Sub
    Private Sub BordtageRechnung()
        Dim tage As Single
        If Not SafeData.IsBlankOrMask(MaskedTextBox1.Text) Then
            Dim d1 As Date
            Dim d2 As Date
            If Not SafeData.TryParseMaskedDate(MaskedTextBox1.Text, d1) OrElse Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, d2) Then Exit Sub
            Dim diff As TimeSpan = d2 - d1
            tage = diff.Days
            If CheckletzterTag.Checked Then
                '          tage = DateDiff("d", CDate(MaskedTextBox1.Text), CDate(MaskedTextBox2.Text))
                tage = tage + 1
                TextBox4.Text = tage.ToString("#")
            Else
                '            tage = DateDiff("d", CDate(MaskedTextBox1.Text), CDate(MaskedTextBox2.Text))
                TextBox4.Text = tage.ToString("#")
            End If
        End If

    End Sub

    Private Sub LoeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoeschenButton.Click
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        aaa = TextBox1.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where  Toern = '" & aaa & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        If TextBox1.Text > "" Then
            msg = MsgBox(" Der Törn: " & Convert.ToString(TextBox1.Text) & " wird gelöscht.", 1, "Löschen")
            If msg = vbOK Then
                Select Case bsTC.Count
                    Case 0
                        bsToernname.RemoveCurrent()
                        taToernname.Update(dsToernverwaltung)
                    Case Else
                        For ii = 0 To bsTC.Count - 1
                            bsTC.RemoveCurrent()
                            taTC.Update(dsToernverwaltung)
                        Next
                        bsToernname.RemoveCurrent()
                        taToernname.Update(dsToernverwaltung)
                End Select
            End If
            Formularloeschen()
        Else
            MsgBox("Wähle zuerst einen Törn aus.")
        End If
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        ToernAlt = TextBox1.Text
        Namensaenderung = False
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
            TextBox5.Text = nachtfahrtenzaehler
            TextBox14.Text = ansteuerungszaehler
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If

    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = TextBox1.Text.Replace("'", "´")
        If TextBox1.Text > "  " And Menü.ToernKey <= " " And Not aenderung Then
            Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim r As System.Data.DataRowView = bsToernname.Current
            Dim ein1 As String
            Dim ToernNeu As String
            TextBox1.Text = RTrim(TextBox1.Text)
            ein1 = TextBox1.Text
            xAdapter.SelectCommand = New OleDb.OleDbCommand
            xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox1.Text & "'"
           bsToernname.CancelEdit()
            dsToernverwaltung.Toernname.Clear()
            xAdapter.Fill(dsToernverwaltung.Toernname)
            If bsToernname.Count = 1 Then
                aenderung = True
            Else
                bsToernname.AddNew()
                TextBox5.Text = "0"
                TextBox6.Text = "0"
                TextBox7.Text = "0"
                TextBox8.Text = "0"
                TextBox9.Text = "0"
                TextBox10.Text = "0"
                TextBox11.Text = "0"
                TextBox14.Text = "0"
                TextBox1.Text = ein1
                GoTo ok
            End If

            If ToernAlt = "" Or ToernAlt = " " Or ToernAlt = TextBox1.Text Then
                GoTo ok
            End If
            ToernNeu = TextBox1.Text
            If TextBox1.Text > "  " Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & ToernAlt & "'"
            End If
            bsToernname.CancelEdit()
            dsToernverwaltung.Toernname.Clear()
            xAdapter.Fill(dsToernverwaltung.Toernname)
            TextBox1.Text = ToernNeu
            Namensaenderung = True
            '           aaa = TextBox15.Text
        End If
ok:
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        GroupBox3.Visible = True
        picture = 2
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        GroupBox3.Visible = True
        picture = 3
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox3.Visible = False
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kalenderSpeichern()
    End Sub
    Private Sub kalenderSpeichern()

        Select Case picture
            Case 2
                MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox1.Focus()
            Case 3
                MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox2.Focus()
        End Select
        GroupBox3.Visible = False

    End Sub
    ' Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
    '      kalenderSpeichern()
    '   End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        kalenderSpeichern()
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        If IsNumeric(TextBox6.Text) And IsNumeric(TextBox7.Text) Then
            sum1 = TextBox6.Text
            sum2 = TextBox7.Text
            TextBox8.Text = sum1 + sum2
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If System.IO.File.Exists(bericht & PDFname) Then
            If Not PathGuard.TryStartPdf(Menü.AcrobatReader, bericht & PDFname) Then
                MsgBox("PDF konnte nicht geöffnet werden: " & bericht & PDFname)
            End If
        Else
            MsgBox("Datei existiert nicht am Ort ' " & bericht & TextBox1.Text & ".pdf")
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If System.IO.File.Exists(logbuch & PDFname) Then
            If Not PathGuard.TryStartPdf(Menü.AcrobatReader, logbuch & PDFname) Then
                MsgBox("PDF konnte nicht geöffnet werden: " & logbuch & PDFname)
            End If
        Else
            MsgBox("Datei existiert nicht am Ort ' " & logbuch & PDFname) ' ")
        End If
    End Sub
    Private Sub MaskedTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.LostFocus
        Dim datum As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox1.Text, datum) Then
            MsgBox("Datum hat falsches Format")
            MaskedTextBox1.Text = vbNullString
            MaskedTextBox1.Focus()
            Exit Sub
        End If
        If datum < Begruessung.anfang OrElse datum > Begruessung.ende Then
            MsgBox("Datum hat falsches Format")
            MaskedTextBox1.Text = vbNullString
            MaskedTextBox1.Focus()
        End If
    End Sub

    Private Sub ButtonBild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        groesser()
    End Sub
    Private Sub groesser()
        PictureBox4.Location = New Point(10, 12)
        PictureBox4.Size = New Point(1000, 700)
        aaa = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString
        aaa = aaa.Replace(" ", "")


        If My.Computer.FileSystem.FileExists(Trim$((route + aaa + ".jpg"))) Then
            Karte = Image.FromFile(Trim$((route + aaa + ".jpg")))
            bildB = Karte.Width
            BildH = Karte.Height

            Me.MaximumSize = New Size(1100, 900)

            With PictureBox4
                '               .Image = AutoSizeI.AutoSizeImage(Karte, bildGrosshoehe, bildGrossBreite)
                .Image = AutoSizeI.AutoSizeImage(Karte, 1000, 680)
            End With
        End If
        '       ButtonVerkleinen.Visible = True

    End Sub
    Private Sub ButtonVerkleinen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        verkleiner()
    End Sub
    Private Sub verkleiner()
        '       ButtonVerkleinen.Visible = False
        PictureBox4.Location = New Point(641, 413)
        PictureBox4.Size = New Point(330, 200)
        aaa = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString
        aaa = aaa.Replace(" ", "")
        If My.Computer.FileSystem.FileExists(Trim$((route + aaa + ".jpg"))) Then
            Karte = Image.FromFile(Trim$((route + aaa + ".jpg")))
            With PictureBox4
                .Image = AutoSizeI.AutoSizeImage(Karte, bildKleinBreite, bildKleinhoehe)
            End With
        End If
        Me.MaximumSize = New Size(fbreite, fhoehe)

    End Sub
    Private Sub ButtonDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDetails.Click
        GroupBox6.Location = New Point(12, 12)
        '       ButtonBild.Enabled = False
        ButtonDetails.Visible = False
        Button1.Enabled = False
        LoeschenButton.Enabled = False
        FormularButton.Enabled = False
        ButtonUeberblick.Visible = True


        GroupBoxNachtA.Location = New Point(1000, 1000)
        ListBox1.Location = New Point(1000, 1000)
        GroupBoxNachtf.Location = New Point(1000, 1000)
        GroupBoxGez.Location = New Point(1000, 1000)
        GroupBox50Std.Location = New Point(1000, 1000)
        GroupBox500Sm.Location = New Point(1000, 1000)

        RadioButton1.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        Label79.Visible = False
        Label80.Visible = False

        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        '       tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox15.Text & "' order by vzname"
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' order by vzname"
        'tAdapter.SelectCommand.CommandText = "Select * from TC"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        If bsTC.Count > 0 Then
            aaa = ""
            iii = bsTC.Count - 1
            ListBox1.Items.Clear()
            For Me.ij = 0 To iii
                ListBox1.Items.Add(dsToernverwaltung.TC.Rows(ij)("vzname").ToString)
            Next
        End If
        DataGridView4.Columns(0).Width = 200
        DataGridView4.Columns(1).Width = 80
        DataGridView4.Columns(3).Width = 200
    End Sub

    Private Sub ButtonUeberblick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUeberblick.Click

        GroupBoxNachtA.Location = New Point(1000, 1000)
        ListBox1.Location = New Point(1000, 1000)
        GroupBoxNachtf.Location = New Point(1000, 1000)
        GroupBoxGez.Location = New Point(1000, 1000)
        GroupBox50Std.Location = New Point(1000, 1000)
        GroupBox500Sm.Location = New Point(1000, 1000)
        Label79.Visible = False
        Label80.Visible = False

        GroupBox6.Location = New Point(1100, 600)
        '       ButtonBild.Enabled = True
        ButtonDetails.Visible = True
        Button1.Enabled = True
        LoeschenButton.Enabled = True
        FormularButton.Enabled = True
        ButtonUeberblick.Visible = False
        Nachtfahrten()
        NachtansteuerungSpeichern()
    End Sub
    Private Sub Nachtfahrten()
        If TextBox23.Text > "" Then
            Dim zwitage As Single
            Dim von1 As Date
            Dim bis1 As Date
            If Not SafeData.TryParseMaskedDate(MaskedTextBox7.Text, von1) OrElse Not SafeData.TryParseMaskedDate(MaskedTextBox8.Text, bis1) Then Exit Sub
            TextBox5.Text = bis1.Day - von1.Day
            If TextBox36.Text > "" Then
                zwitage = TextBox5.Text
                Dim von2 As Date
                Dim bis2 As Date
                If Not SafeData.TryParseMaskedDate(MaskedTextBox9.Text, von2) OrElse Not SafeData.TryParseMaskedDate(MaskedTextBox10.Text, bis2) Then Exit Sub
                TextBox5.Text = zwitage + bis2.Day - von2.Day
                nachtfahrtenzaehler = 2
            Else
                nachtfahrtenzaehler = 1
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        '
        '                                 Nachtansteuerungen
        '
        GroupBoxNachtA.Location = New Point(220, 75)
        ListBox1.Location = New Point(20, 75)
        GroupBoxNachtf.Location = New Point(1000, 1000)
        GroupBoxGez.Location = New Point(1000, 1000)
        GroupBox50Std.Location = New Point(1000, 1000)
        GroupBox500Sm.Location = New Point(1000, 1000)
        Label79.Visible = True
        Label80.Visible = True
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        '
        '                                 Nachtfahrten
        '
        GroupBoxNachtA.Location = New Point(1000, 1000)
        ListBox1.Location = New Point(1000, 1000)
        GroupBoxNachtf.Location = New Point(20, 70)
        GroupBoxGez.Location = New Point(1000, 1000)
        GroupBox50Std.Location = New Point(1000, 1000)
        GroupBox500Sm.Location = New Point(1000, 1000)
        Label79.Visible = False
        Label80.Visible = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        '
        '                                 50 Std non stop
        '
        GroupBoxNachtA.Location = New Point(1000, 1000)
        ListBox1.Location = New Point(1000, 1000)
        GroupBoxNachtf.Location = New Point(1000, 1000)
        GroupBoxGez.Location = New Point(1000, 1000)
        GroupBox50Std.Location = New Point(20, 70)
        GroupBox500Sm.Location = New Point(1000, 1000)
        Label79.Visible = False
        Label80.Visible = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        '
        '                                 Gezeitenrevier
        '
        GroupBoxNachtA.Location = New Point(1000, 1000)
        ListBox1.Location = New Point(1000, 1000)
        GroupBoxNachtf.Location = New Point(1000, 1000)
        GroupBoxGez.Location = New Point(20, 70)
        GroupBox50Std.Location = New Point(1000, 1000)
        GroupBox500Sm.Location = New Point(1000, 1000)
        Label79.Visible = False
        Label80.Visible = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        '
        '                                 500 sm
        '
        GroupBoxNachtA.Location = New Point(1000, 1000)
        ListBox1.Location = New Point(1000, 1000)
        GroupBoxNachtf.Location = New Point(1000, 1000)
        GroupBoxGez.Location = New Point(1000, 1000)
        GroupBox50Std.Location = New Point(1000, 1000)
        GroupBox500Sm.Location = New Point(20, 70)
        Label79.Visible = False
        Label80.Visible = False
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        DataGridView4.Rows.Add(ListBox1.Text, "", "", "")
        DataGridView4.Rows(DataGridView4.RowCount - 2).Cells(4).Value = True
        If DataGridView4.RowCount > 2 Then
            DataGridView4.Rows(DataGridView4.RowCount - 2).Cells(1).Value = DataGridView4.Rows(DataGridView4.RowCount - 3).Cells(1).Value.ToString
            DataGridView4.CurrentCell = DataGridView4.Rows(DataGridView4.RowCount - 2).Cells(2)
            DataGridView4.BeginEdit(True)
        End If
    End Sub
    Private Sub NachtansteuerungSpeichern()
        iii = DataGridView4.RowCount
        For i = 0 To iii - 2
            Dim hafenValue As Object = DataGridView4.Rows(i).Cells(3).Value
            If Not SafeData.IsNullOrEmptyValue(hafenValue) Then
                Dim datumText As String = SafeData.FormatDateDe(DataGridView4.Rows(i).Cells(1).Value)
                If datumText > "" Then
                    SpeichernTC(SafeData.CoalesceString(DataGridView4.Rows(i).Cells(0).Value), datumText, SafeData.CoalesceString(DataGridView4.Rows(i).Cells(2).Value), SafeData.CoalesceString(hafenValue), SafeData.CoalesceString(DataGridView4.Rows(i).Cells(4).Value))
                End If
            End If
        Next
        ListBox2.Sorted = True
        For i = 1 To ListBox2.Items.Count - 2
            If ListBox2.Items.Item(i).ToString = ListBox2.Items.Item(i + 1).ToString Then
            Else
                ListBox3.Items.Add(ListBox2.Items.Item(i).ToString)
            End If
        Next i
        If ListBox3.Items.Count > 0 Then
            TextBox14.Text = ListBox3.Items.Count
        End If
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
    End Sub
    Private Sub SpeichernTC(ByVal vozuname, ByVal tag, ByVal zeit, ByVal hafen, ByVal ok)
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern =  '" & TextBox1.Text & "' and vzname = '" & vozuname & "' "
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        If bsTC.Count = 1 Then
            '        If Not IsDBNull(dsToernverwaltung.TC.Rows(0)("nachtahafen1").ToString) Then
            Select Case hafen + tag
                Case dsToernverwaltung.TC.Rows(0)("nachtahafen1").ToString + dsToernverwaltung.TC.Rows(0)("nachtadatum1")
                    If ok Then
                        dsToernverwaltung.TC.Rows(0)("nachtadatum1") = tag
                        dsToernverwaltung.TC.Rows(0)("nachtaZeit1") = zeit
                        ListBox2.Items.Add(hafen + tag)
                    Else
                        dsToernverwaltung.TC.Rows(0)("nachtaZeit1") = ""
                        dsToernverwaltung.TC.Rows(0)("nachtahafen1") = ""
                    End If
                Case dsToernverwaltung.TC.Rows(0)("nachtahafen2").ToString + dsToernverwaltung.TC.Rows(0)("nachtadatum2")
                    If ok Then
                        dsToernverwaltung.TC.Rows(0)("nachtadatum2") = tag
                        dsToernverwaltung.TC.Rows(0)("nachtaZeit2") = zeit
                        ListBox2.Items.Add(hafen + tag)
                    Else
                        dsToernverwaltung.TC.Rows(0)("nachtaZeit2") = ""
                        dsToernverwaltung.TC.Rows(0)("nachtahafen2") = ""
                    End If
                Case dsToernverwaltung.TC.Rows(0)("nachtahafen3").ToString + dsToernverwaltung.TC.Rows(0)("nachtadatum3")
                    If ok Then
                        dsToernverwaltung.TC.Rows(0)("nachtadatum3") = tag
                        dsToernverwaltung.TC.Rows(0)("nachtaZeit3") = zeit
                        ListBox2.Items.Add(hafen + tag)
                    Else
                        dsToernverwaltung.TC.Rows(0)("nachtaZeit3") = ""
                        dsToernverwaltung.TC.Rows(0)("nachtahafen3") = ""
                    End If
                Case Else
                    If dsToernverwaltung.TC.Rows(0)("nachtahafen1").ToString > "" Then
                        If dsToernverwaltung.TC.Rows(0)("nachtahafen2").ToString > "" Then
                            If dsToernverwaltung.TC.Rows(0)("nachtahafen3").ToString > "" Then
                            Else
                                dsToernverwaltung.TC.Rows(0)("nachtahafen3") = hafen
                                dsToernverwaltung.TC.Rows(0)("nachtadatum3") = tag
                                dsToernverwaltung.TC.Rows(0)("nachtaZeit3") = zeit
                                ListBox2.Items.Add(hafen + tag)
                            End If
                        Else
                            dsToernverwaltung.TC.Rows(0)("nachtahafen2") = hafen
                            dsToernverwaltung.TC.Rows(0)("nachtadatum2") = tag
                            dsToernverwaltung.TC.Rows(0)("nachtaZeit2") = zeit
                            ListBox2.Items.Add(hafen + tag)
                        End If
                    Else
                        dsToernverwaltung.TC.Rows(0)("nachtahafen1") = hafen
                        dsToernverwaltung.TC.Rows(0)("nachtadatum1") = tag
                        dsToernverwaltung.TC.Rows(0)("nachtaZeit1") = zeit
                        ListBox2.Items.Add(hafen + tag)
                    End If
            End Select
            bsTC.EndEdit()
            taTC.Update(dsToernverwaltung)
        End If

    End Sub

    Private Sub TextBox18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.Click
        Menü.bootkey = ComboBox1.Text
        FormUi.ShowChild(Boot)
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        MarinaSuchen()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        MarinaSuchen()
        TextBox18.Visible = True
        TextBox18.Text = ComboBox1.Text
    End Sub
    Private Sub MarinaSuchen()
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & ComboBox1.Text & "' order by bootname"
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        DbAccess.SafePosition(bsBoot)
        If bsBoot.Count = 1 Then
            If TextBox2.Text = "" Then
                TextBox2.Text = dsToernverwaltung.Boot.Rows(0)("Marinaort").ToString + "/" + dsToernverwaltung.Boot.Rows(0)("Marina").ToString
            End If
            If TextBox3.Text = "" Then
                TextBox3.Text = dsToernverwaltung.Boot.Rows(0)("Marinaort").ToString + "/" + dsToernverwaltung.Boot.Rows(0)("Marina").ToString
            End If
        End If
    End Sub
    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        aaa = ComboBox2.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern =  '" & TextBox1.Text & "' and vzname = '" & aaa & "' "
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        If bsTC.Count = 0 Then
            bsTC.AddNew()
            Dim drv As DataRowView = bsTC.Item(0)
            drv(1) = TextBox1.Text
            drv(2) = aaa
            '            drv(10) = TextBox15.Text
            bsTC.EndEdit()
            taTC.Update(dsToernverwaltung)
        End If

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox4.Height = 200 Then
            groesser()
        Else
            verkleiner()
        End If
    End Sub

    Private Sub TextBox19_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox19.LostFocus
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & TextBox18.Text & "'"
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        DbAccess.SafePosition(bsBoot)
        If IsNumeric(TextBox20.Text) Then
            TextBox20.Text = (verbrauch + TextBox20.Text) / 2
        Else
            TextBox20.Text = verbrauch
        End If
        If verbrauch > 0 Then
            bsBoot.EndEdit()
            taBoot.Update(dsToernverwaltung.Boot)
        End If
    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        If IsNumeric(TextBox19.Text) And IsNumeric(TextBox7.Text) Then
            verbrauch = TextBox19.Text / TextBox7.Text
            verbrauch = CSng(Math.Round(CDbl(verbrauch), 2))
            Label5.Text = verbrauch.ToString + " l/sm"
        Else
            verbrauch = 0
        End If
    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        Dim laen As Integer
        If TextBox21.Text > "" Then
            laen = Len(TextBox21.Text)
            iii = bsCrewAdressen.Count - 1
            For i = 0 To iii
                aaa = Mid(dsToernverwaltung.CrewAdressen.Rows(i)("vzname").ToString, 1, 1).ToUpper + Mid(dsToernverwaltung.CrewAdressen.Rows(i)("vzname").ToString, 2, laen - 1).ToUpper
                If TextBox21.Text.ToUpper = aaa Then
                    position = i
                    GoTo Gefunden
                End If
            Next
Gefunden:
            bsCrewAdressen.Position = position
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label30.Text = "Suchen"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label30.Text = ""
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        aenderung = True
        Button1.Text = "Änderung speichern"
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        Label30.Text = "Ändern"
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        Label30.Text = ""
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        If IsNumeric(TextBox6.Text) And IsNumeric(TextBox7.Text) Then
            sum1 = TextBox6.Text
            sum2 = TextBox7.Text
            TextBox8.Text = sum1 + sum2
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        aaa = Trennen(TextBox3.Text)
        aaa = aaa.Replace(" ", "")
        Dim Marinafoto As Image
        If My.Computer.FileSystem.FileExists(Trim$((marina + aaa + ".jpg"))) Then
            GroupBox7.Size = New Point(1100, 700)
            GroupBox7.Visible = True
            GroupBox7.Location = New Point(11, 13)
            GroupBox1.Visible = False
            PictureBox8.Size = New Point(1100, 700)
            PictureBox8.Location = New Point(1, 1)
            Marinafoto = Image.FromFile(Trim$((marina + aaa + ".jpg")))
            With PictureBox8
                .Image = AutoSizeI.AutoSizeImage(Marinafoto, 1100, 700)
            End With
        Else
            PictureBox8.Image = Nothing
        End If
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        GroupBox7.Visible = False
        GroupBox1.Visible = True
    End Sub
    Private Function Trennen(ByVal input)
        Dim anzahl As Integer
        anzahl = Len(input)
        If anzahl = 0 Then
            MsgBox(" Marina ist nicht bekannt. ")
            Trennen = 0
        Else
            For i = anzahl To 1 Step -1
                If input.ToString.Substring(i - 1, 1) = "/" Then
                    Trennen = input.ToString.Substring(i, anzahl - i)
                    Exit Function
                End If
            Next
            Trennen = input
        End If
    End Function

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        aaa = Trennen(TextBox2.Text)
        aaa = aaa.Replace(" ", "")
        Dim Marinafoto As Image
        If My.Computer.FileSystem.FileExists(Trim$((marina + aaa + ".jpg"))) Then
            GroupBox7.Size = New Point(1100, 700)
            GroupBox7.Visible = True
            GroupBox7.Location = New Point(11, 13)
            GroupBox1.Visible = False
            PictureBox8.Size = New Point(1100, 700)
            PictureBox8.Location = New Point(1, 1)
            Marinafoto = Image.FromFile(Trim$((marina + aaa + ".jpg")))
            With PictureBox8
                .Image = AutoSizeI.AutoSizeImage(Marinafoto, 1100, 700)
            End With
        Else
            PictureBox8.Image = Nothing
        End If
    End Sub

    Private Sub buttonAlbum_Click(sender As System.Object, e As System.EventArgs) Handles buttonAlbum.Click
        Dim anz As Integer
        ListBox4.Items.Clear()
        GroupBox8.Location = New Point(3, 3)
        '  Fotos aus dem Ordner suchen
        sPath = dsToernverwaltung.Toernname.Rows(0)("R1").ToString
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
            MsgBox("Fotos im Ordner " & Convert.ToString(dsToernverwaltung.Toernname.Rows(0)("R1")) & " existieren nicht oder der Ordner ist nicht mehr vorhanden.")
            GoTo schleife
        End Try

        ' Datei-Array durchlaufen und in 
        ' ListBox übertragen
        Dim oFile As System.IO.FileInfo
        For Each oFile In oFiles
            aaa = oFile.Name
            anz = Len(oFile.Name)
            If aaa.EndsWith(".JPG", StringComparison.OrdinalIgnoreCase) OrElse aaa.EndsWith(".JPEG", StringComparison.OrdinalIgnoreCase) Then
                ListBox4.Items.Add(oFile.Name)
            End If
        Next

        ' Das erste Foto zeigen
        iii = 0
weiter:
        If Len(ListBox4.Items(iii)) > 4 And iii <= ListBox4.Items.Count - 1 Then
            Karte = Image.FromFile(Trim$((sPath + "\" + ListBox4.Items(iii))))
            bildB = Karte.Width
            BildH = Karte.Height
            Me.MaximumSize = New Size(1020, 740)
            Label61.Text = Str(iii + 1) + "/" + Str(ListBox4.Items.Count)
            With PictureBoxAlbum
                .Image = AutoSizeI.AutoSizeImage(Karte, 946, 636)
            End With
        Else
            iii += 1
            GoTo weiter
        End If
        If iii = ListBox4.Items.Count - 1 Then
            ButtonNaechst.Enabled = False
        End If
        Karte.Dispose()
        If ListBox4.Items.Count = 1 Then
            ButtenVorher.Enabled = False
            ButtonNaechst.Enabled = False
        End If
schleife:
    End Sub
    Private Sub ButtenVorher_Click(sender As System.Object, e As System.EventArgs) Handles ButtenVorher.Click
        If iii = ListBox4.Items.Count - 1 Then
            ButtonNaechst.Enabled = True
        End If
        iii -= 1
        If Len(ListBox4.Items(iii)) > 4 And iii >= 0 Then
            Karte = Image.FromFile(Trim$((sPath + "\" + ListBox4.Items(iii))))
            bildB = Karte.Width
            BildH = Karte.Height
            Me.MaximumSize = New Size(1020, 740)
            Label61.Text = Str(iii + 1) + "/" + Str(ListBox4.Items.Count)
            With PictureBoxAlbum
                .Image = AutoSizeI.AutoSizeImage(Karte, 946, 636)
            End With
        End If
        If iii = 0 Then
            ButtenVorher.Enabled = False
        End If
        Karte.Dispose()
    End Sub
    Private Sub ButtonToern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonToern.Click
        GroupBox8.Location = New Point(2000, 12)
    End Sub
    Private Sub ButtonNaechst_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNaechst.Click
        iii += 1
        If iii > 0 Then
            ButtenVorher.Enabled = True
        End If
        If Len(ListBox4.Items(iii)) > 4 And iii <= ListBox4.Items.Count - 1 Then
            Karte = Image.FromFile(Trim$((sPath + "\" + ListBox4.Items(iii))))
            bildB = Karte.Width
            BildH = Karte.Height
            Me.MaximumSize = New Size(1020, 740)
            Label61.Text = Str(iii + 1) + "/" + Str(ListBox4.Items.Count)
            With PictureBoxAlbum
                .Image = AutoSizeI.AutoSizeImage(Karte, 946, 636)
            End With
        End If
        If iii = ListBox4.Items.Count - 1 Then
            ButtonNaechst.Enabled = False
        End If
        Karte.Dispose()
    End Sub

    Private Sub PictureBox11_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox11.Click
        ' Links Drehen
        Karte = Image.FromFile(Trim$((sPath + "\" + ListBox4.Items(iii))))
        Karte.RotateFlip(RotateFlipType.Rotate270FlipNone)
        PictureBox11.Refresh()
        Bildanzeige()
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        ' Kopf drehen
        Karte = Image.FromFile(Trim$((sPath + "\" + ListBox4.Items(iii))))
        Karte.RotateFlip(RotateFlipType.Rotate180FlipNone)
        PictureBox11.Refresh()
        Bildanzeige()
    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click
        'rechts drehen
        Karte = Image.FromFile(Trim$((sPath + "\" + ListBox4.Items(iii))))
        Karte.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox11.Refresh()
        Bildanzeige()
    End Sub
    Private Sub Bildanzeige()
        bildB = Karte.Width
        BildH = Karte.Height
        Me.MaximumSize = New Size(1100, 740)
        Label61.Text = Str(iii + 1) + "/" + Str(ListBox4.Items.Count)
        With PictureBoxAlbum
            .Image = AutoSizeI.AutoSizeImage(Karte, 946, 636)
        End With
        If iii = ListBox4.Items.Count - 1 Then
            ButtonNaechst.Enabled = False
        End If

    End Sub

    Private Sub PictureBox11_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox11.MouseHover
        Label62.Text = "Links drehen"
    End Sub

    Private Sub PictureBox11_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox11.MouseLeave
        Label62.Text = ""
    End Sub

    Private Sub PictureBox9_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox9.MouseHover
        Label63.Text = "180° drehen"
    End Sub

    Private Sub PictureBox9_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox9.MouseLeave
        Label63.Text = ""
    End Sub

    Private Sub PictureBox10_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox10.MouseHover
        Label64.Text = "Rechts drehen"
    End Sub

    Private Sub PictureBox10_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox10.MouseLeave
        Label64.Text = ""
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click
        GroupBox7.Visible = False
        GroupBox1.Visible = True
    End Sub
End Class
