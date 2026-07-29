Public Class Seemeilenbestaetigung
    Public Freischaltung As String
     Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public von As String
    Public bis As String
    Public boot As String
    Public type As String
    Public laenge As String
    Public route As String
    Public start As String
    Public ziel As String
    Public smg As String
    Public sms As String
    Public nachta As String
    Public nachtf As String
    Public aFB2 As String
    Public aFB3 As String
    Public Schiffsfuehrer As String
    Public schAdresse As String
    Public lizenz As String
    Public lizDatum As String
    Public lizVerband As String
    Public funktionen As String
    Dim PDFReader As String

    Dim dokument As String
    Dim ablage As String
    Dim syacht As Boolean
    Dim schgebdatum As String
    Dim schgebort As String
    Dim schhandy As String
    Dim schemail As String
    Dim tiefBreite As String
    Dim x As New CheckKey
    Public ok As Boolean
    Dim buch1 As String
    Dim position As Integer
    Dim mehrfach As Boolean
    Private Sub Seemeilenbestaetigung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Listdaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        Freischaltung = GetSetting("toern", "Pfad", "T")
        TextBox16.Text = GetSetting("Ort", "Einstellungen", "T", " ")
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

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
            Label25.Visible = True
        End If

        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from CrewAdressen order by vzname"
        bsCrewAdressen.CancelEdit()

        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        bsToernname.AddNew()
        aenderung = False
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        checkboxLoeschen()
        Formularloeschen()
        GroupBox4.Location = New Point(12, 320)
        GroupBox2.Visible = False
        GroupBox4.Visible = False

        ComboBox1.Items.Add("JachtVO2020")
        ComboBox1.Items.Add("MSVÖ")
        ComboBox1.Text = "JachtVO2020"
        With DataGridView1
            .Columns(0).Width = 150
        End With
        mehrfach = False
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTemp.Current
        DataGridView1.Visible = True
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox1.Text & "'  order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.AddNew()
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        Drucken.Enabled = False
    End Sub
    Private Sub comboFuellen(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox1.Items.Add(text)
            End If
        End If

    End Sub

    Private Sub checkboxLoeschen()
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox54.Checked = False
        CheckBox53.Checked = False
        CheckBox52.Checked = False
        CheckBox51.Checked = False
        CheckBox50.Checked = False
        CheckBox49.Checked = False
        CheckBox48.Checked = False
        CheckBox47.Checked = False
        CheckBox46.Checked = False
        CheckBox45.Checked = False
        CheckBox44.Checked = False
        CheckBox43.Checked = False
        CheckBox42.Checked = False
        CheckBox41.Checked = False
        CheckBox40.Checked = False
        CheckBox39.Checked = False
        CheckBox38.Checked = False
        CheckBox37.Checked = False
        CheckBox36.Checked = False
        CheckBox35.Checked = False
        CheckBox34.Checked = False
        CheckBox33.Checked = False
        CheckBox32.Checked = False
        CheckBox31.Checked = False
        CheckBox30.Checked = False
        CheckBox29.Checked = False
        CheckBox28.Checked = False
        CheckBox27.Checked = False
        CheckBox26.Checked = False
        CheckBox25.Checked = False
        CheckBox21.Checked = False
        CheckBox20.Checked = False
        CheckBox19.Checked = False
        CheckBox18.Checked = False
        CheckBox17.Checked = False
        CheckBox16.Checked = False
    End Sub

    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        GroupBox2.Text = "Törn auswählen mit Doppelklick"
        GroupBox2.Visible = True
        GroupBox4.Visible = False
        DataGridView1.Visible = True
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If IsNumeric(TextBox1.Text) And Len(TextBox1.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
            Else
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox1.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        If mehrfach Then
                            xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox1.Text & "'  order by toernbezeichnung"
                        Else
                            xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                        End If
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where mid(toernbezeichnung,1,1) like '%" & TextBox1.Text & "%' order by toernbezeichnung"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        End If
        bsToernname.CancelEdit()
        aenderung = True
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)

        Select Case bsToernname.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                xAdapter.Fill(dsToernverwaltung.Toernname)
                Formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                CrewlisteAnzeigen()
                GroupBox2.Visible = False
                GroupBox4.Visible = True
                von = dsToernverwaltung.Toernname.Rows(0)("Datumvon")
                bis = dsToernverwaltung.Toernname.Rows(0)("Datumbis")
                boot = dsToernverwaltung.Toernname.Rows(0)("Bootsname")
                start = dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina")
                ziel = dsToernverwaltung.Toernname.Rows(0)("Endemarina")
                smg = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("SmGesamt")), " ", dsToernverwaltung.Toernname.Rows(0)("SmGesamt"))
                If smg = " " Or smg = 0 Then
                    MsgBox(" Bei diesem Törn sind die Seemeilen noch nicht bestimmt. Abbruch.")
                    Close()
                    GoTo ende
                End If
                sms = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("Smsegel")), " ", dsToernverwaltung.Toernname.Rows(0)("Smsegel"))
                nachta = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen")), "0", dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen"))
                nachtf = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten")), "0", dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten"))
                aFB2 = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB2")), "0", dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB2"))
                aFB3 = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB3")), "0", dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB3"))
                route = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("route")), " ", dsToernverwaltung.Toernname.Rows(0)("route"))
                Schiffsfuehrer = IIf(DBNull.Value.Equals(dsToernverwaltung.Toernname.Rows(0)("Skipper")), " ", dsToernverwaltung.Toernname.Rows(0)("Skipper"))
                If Schiffsfuehrer = " " Then
                    MsgBox(" Bei diesem Törn ist der Skipper noch nicht bestimmt. Abbruch.")
                    Close()
                    GoTo ende
                End If
                skipper()
                boote()
                Drucken.Enabled = True
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
                GroupBox2.Visible = True
                GroupBox4.Visible = False
        End Select

        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        DataGridtemp.Visible = True
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        '        If bsTemp.Count > 0 Then
        ' iii = bsTemp.Count - 1
        ' For Me.ij = 0 To iii
        ' bsTemp.RemoveCurrent()
        ' taTemp.Update(dsToernverwaltung)
        ' Next
        ' End If
        ij = 0
        bsTemp.AddNew()
ende:
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
    Private Sub skipper()
        ' in Crewadressen - toernnr den Törnname vorübergehend speichern
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname = '" & Schiffsfuehrer & "' "
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 1
                bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                schAdresse = dsToernverwaltung.CrewAdressen.Rows(0)("Plz").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(0)("ort").ToString + ", " + dsToernverwaltung.CrewAdressen.Rows(0)("Straße").ToString
                lizenz = dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString
                lizDatum = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinDatum").ToString
                lizVerband = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinVerband").ToString
                schgebdatum = dsToernverwaltung.CrewAdressen.Rows(0)("gebdatum").ToString
                schgebort = dsToernverwaltung.CrewAdressen.Rows(0)("gebort").ToString
                schemail = dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString
                schhandy = dsToernverwaltung.CrewAdressen.Rows(0)("handy").ToString
        End Select
    End Sub
    Private Sub boote()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsBoot.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsBoot.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Boot where bootname = '" & boot & "' "
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        xAdapter.Fill(dsToernverwaltung.Boot)
        Select Case bsBoot.Count
            Case 1
                bsBoot.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bsTemp.AddNew()
                type = dsToernverwaltung.Boot.Rows(0)("Schiffstyp").ToString
                boot = boot + " / " + dsToernverwaltung.Boot.Rows(0)("Schiffsnummer")
                laenge = dsToernverwaltung.Boot.Rows(0)("Länge").ToString
                tiefBreite = dsToernverwaltung.Boot.Rows(0)("Breite").ToString + "/" + dsToernverwaltung.Boot.Rows(0)("Tiefgang").ToString
                If dsToernverwaltung.Boot.Rows(0)("Segelyacht").ToString Then
                    syacht = True
                Else
                    syacht = False
                End If
        End Select
    End Sub

    Private Sub Formularloeschen()
        Label6.Visible = False
        '      TextBox1.Text = ""
        mehrfach = False
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        RichTextBox1.Text = " "
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        checkboxLoeschen()
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False
        CheckBox9.Visible = False
        CheckBox10.Visible = False
        CheckBox11.Visible = False
        CheckBox12.Visible = False
        CheckBox13.Visible = False
        CheckBox14.Visible = False
        CheckBox15.Visible = False
        CheckBox16.Visible = False
        CheckBox17.Visible = False
        CheckBox18.Visible = False
        CheckBox54.Visible = False
        CheckBox53.Visible = False
        CheckBox52.Visible = False
        CheckBox51.Visible = False
        CheckBox50.Visible = False
        CheckBox49.Visible = False
        CheckBox48.Visible = False
        CheckBox47.Visible = False
        CheckBox46.Visible = False
        CheckBox45.Visible = False
        CheckBox44.Visible = False
        CheckBox43.Visible = False
        CheckBox42.Visible = False
        CheckBox41.Visible = False
        CheckBox40.Visible = False
        CheckBox39.Visible = False
        CheckBox38.Visible = False
        CheckBox37.Visible = False
        CheckBox36.Visible = False
        CheckBox35.Visible = False
        CheckBox34.Visible = False
        CheckBox33.Visible = False
        CheckBox32.Visible = False
        CheckBox31.Visible = False
        CheckBox30.Visible = False
        CheckBox29.Visible = False
        CheckBox28.Visible = False
        CheckBox27.Visible = False
        CheckBox26.Visible = False
        CheckBox25.Visible = False
        CheckBox21.Visible = False
        CheckBox20.Visible = False
        CheckBox19.Visible = False
        CheckBox18.Visible = False
        CheckBox17.Visible = False
        CheckBox16.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False
        TextBox23.Visible = False
        TextBox24.Visible = False
        TextBox25.Visible = False
        TextBox26.Visible = False
        TextBox27.Visible = False
        TextBox28.Visible = False
        TextBox29.Visible = False
        TextBox30.Visible = False
        TextBox31.Visible = False
        TextBox32.Visible = False
        DataGridView2.Visible = False
    End Sub

    Private Sub CrewlisteAnzeigen()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern like '%" & TextBox1.Text & "%' order by vzname"
        ' tAdapter.SelectCommand.CommandText = "Select * from TC"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        ij = bsTC.Count
        If ij >= 1 Then
            TextBox21.Text = dsToernverwaltung.TC.Rows(0)("vzname").ToString
            TextBox21.Visible = True
            CheckBox9.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox16.Checked = dsToernverwaltung.TC.Rows(0)("Wachfuehrer")
            CheckBox17.Checked = dsToernverwaltung.TC.Rows(0)("Navigator")
            CheckBox18.Checked = dsToernverwaltung.TC.Rows(0)("Rudergaenger")
            If ij >= 2 Then
                TextBox22.Text = dsToernverwaltung.TC.Rows(1)("vzname").ToString
                TextBox22.Visible = True
                CheckBox4.Visible = True
                CheckBox54.Visible = True
                CheckBox53.Visible = True
                CheckBox52.Visible = True
                CheckBox54.Checked = dsToernverwaltung.TC.Rows(1)("Wachfuehrer")
                CheckBox53.Checked = dsToernverwaltung.TC.Rows(1)("Navigator")
                CheckBox52.Checked = dsToernverwaltung.TC.Rows(1)("Rudergaenger")
                If ij >= 3 Then
                    TextBox23.Text = dsToernverwaltung.TC.Rows(2)("vzname").ToString
                    TextBox23.Visible = True
                    CheckBox5.Visible = True
                    CheckBox51.Visible = True
                    CheckBox50.Visible = True
                    CheckBox49.Visible = True
                    CheckBox51.Checked = dsToernverwaltung.TC.Rows(2)("Wachfuehrer")
                    CheckBox50.Checked = dsToernverwaltung.TC.Rows(2)("Navigator")
                    CheckBox49.Checked = dsToernverwaltung.TC.Rows(2)("Rudergaenger")
                    If ij >= 4 Then
                        TextBox24.Text = dsToernverwaltung.TC.Rows(3)("vzname").ToString
                        TextBox24.Visible = True
                        CheckBox6.Visible = True
                        CheckBox48.Visible = True
                        CheckBox47.Visible = True
                        CheckBox46.Visible = True
                        CheckBox48.Checked = dsToernverwaltung.TC.Rows(3)("Wachfuehrer")
                        CheckBox47.Checked = dsToernverwaltung.TC.Rows(3)("Navigator")
                        CheckBox46.Checked = dsToernverwaltung.TC.Rows(3)("Rudergaenger")
                        If ij >= 5 Then
                            TextBox25.Text = dsToernverwaltung.TC.Rows(4)("vzname").ToString
                            TextBox25.Visible = True
                            CheckBox7.Visible = True
                            CheckBox45.Visible = True
                            CheckBox44.Visible = True
                            CheckBox43.Visible = True
                            CheckBox45.Checked = dsToernverwaltung.TC.Rows(4)("Wachfuehrer")
                            CheckBox44.Checked = dsToernverwaltung.TC.Rows(4)("Navigator")
                            CheckBox43.Checked = dsToernverwaltung.TC.Rows(4)("Rudergaenger")
                            If ij >= 6 Then
                                TextBox26.Text = dsToernverwaltung.TC.Rows(5)("vzname").ToString
                                TextBox26.Visible = True
                                CheckBox8.Visible = True
                                CheckBox42.Visible = True
                                CheckBox41.Visible = True
                                CheckBox40.Visible = True
                                CheckBox42.Checked = dsToernverwaltung.TC.Rows(5)("Wachfuehrer")
                                CheckBox41.Checked = dsToernverwaltung.TC.Rows(5)("Navigator")
                                CheckBox40.Checked = dsToernverwaltung.TC.Rows(5)("Rudergaenger")
                                If ij >= 7 Then
                                    Label6.Visible = True
                                    TextBox27.Text = dsToernverwaltung.TC.Rows(6)("vzname").ToString
                                    TextBox27.Visible = True
                                    CheckBox15.Visible = True
                                    CheckBox21.Visible = True
                                    CheckBox20.Visible = True
                                    CheckBox19.Visible = True
                                    CheckBox21.Checked = dsToernverwaltung.TC.Rows(6)("Wachfuehrer")
                                    CheckBox20.Checked = dsToernverwaltung.TC.Rows(6)("Navigator")
                                    CheckBox19.Checked = dsToernverwaltung.TC.Rows(6)("Rudergaenger")
                                    If ij >= 8 Then
                                        TextBox28.Text = dsToernverwaltung.TC.Rows(7)("vzname").ToString
                                        TextBox28.Visible = True
                                        CheckBox39.Visible = True
                                        CheckBox10.Visible = True
                                        CheckBox38.Visible = True
                                        CheckBox37.Visible = True
                                        CheckBox39.Checked = dsToernverwaltung.TC.Rows(7)("Wachfuehrer")
                                        CheckBox38.Checked = dsToernverwaltung.TC.Rows(7)("Navigator")
                                        CheckBox37.Checked = dsToernverwaltung.TC.Rows(7)("Rudergaenger")
                                        If ij >= 9 Then
                                            TextBox29.Text = dsToernverwaltung.TC.Rows(8)("vzname").ToString
                                            TextBox29.Visible = True
                                            CheckBox11.Visible = True
                                            CheckBox36.Visible = True
                                            CheckBox35.Visible = True
                                            CheckBox34.Visible = True
                                            CheckBox36.Checked = dsToernverwaltung.TC.Rows(8)("Wachfuehrer")
                                            CheckBox35.Checked = dsToernverwaltung.TC.Rows(8)("Navigator")
                                            CheckBox34.Checked = dsToernverwaltung.TC.Rows(8)("Rudergaenger")
                                            If ij >= 10 Then
                                                TextBox30.Text = dsToernverwaltung.TC.Rows(9)("vzname").ToString
                                                TextBox30.Visible = True
                                                CheckBox33.Visible = True
                                                CheckBox12.Visible = True
                                                CheckBox32.Visible = True
                                                CheckBox31.Visible = True
                                                CheckBox33.Checked = dsToernverwaltung.TC.Rows(9)("Wachfuehrer")
                                                CheckBox32.Checked = dsToernverwaltung.TC.Rows(9)("Navigator")
                                                CheckBox31.Checked = dsToernverwaltung.TC.Rows(9)("Rudergaenger")
                                                If ij >= 11 Then
                                                    TextBox31.Text = dsToernverwaltung.TC.Rows(10)("vzname").ToString
                                                    TextBox31.Visible = True
                                                    CheckBox30.Visible = True
                                                    CheckBox13.Visible = True
                                                    CheckBox29.Visible = True
                                                    CheckBox28.Visible = True
                                                    CheckBox30.Checked = dsToernverwaltung.TC.Rows(10)("Wachfuehrer")
                                                    CheckBox29.Checked = dsToernverwaltung.TC.Rows(10)("Navigator")
                                                    CheckBox28.Checked = dsToernverwaltung.TC.Rows(10)("Rudergaenger")
                                                    If ij = 12 Then
                                                        TextBox32.Text = dsToernverwaltung.TC.Rows(11)("vzname").ToString
                                                        TextBox32.Visible = True
                                                        CheckBox27.Visible = True
                                                        CheckBox14.Visible = True
                                                        CheckBox26.Visible = True
                                                        CheckBox25.Visible = True
                                                        CheckBox27.Checked = dsToernverwaltung.TC.Rows(11)("Wachfuehrer")
                                                        CheckBox26.Checked = dsToernverwaltung.TC.Rows(11)("Navigator")
                                                        CheckBox25.Checked = dsToernverwaltung.TC.Rows(11)("Rudergaenger")
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
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Formularloeschen()
        suchen()
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        mehrfach = True
        suchen()
    End Sub
    Private Sub DataGridView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        mehrfach = True
        suchen()
    End Sub

    Private Sub AusgabeTemp(ByVal nm)
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rs As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from temp where feld0 = '" & nm & "' "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)

        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' and vzname = '" & nm & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        dsToernverwaltung.TC.Rows(0)("Rudergaenger") = False
        dsToernverwaltung.TC.Rows(0)("Wachfuehrer") = False
        dsToernverwaltung.TC.Rows(0)("Navigator") = False
        If funktionen.Contains("R") Then dsToernverwaltung.TC.Rows(0)("Rudergaenger") = True
        If funktionen.Contains("W") Then dsToernverwaltung.TC.Rows(0)("Wachfuehrer") = True
        If funktionen.Contains("N") Then dsToernverwaltung.TC.Rows(0)("Navigator") = True
        bsTC.EndEdit()
        taTC.Update(dsToernverwaltung.TC)


        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox1.Text & "'  order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)


        Dim gebdat As String
        Dim yAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        yAdapter.SelectCommand = New OleDb.OleDbCommand
        yAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        yAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname = '" & nm & "' "
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        yAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 1
                If bsTemp.Count = 0 Then
                    bsTemp.AddNew()
                    bsTemp.AddNew()
                    bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                    dsToernverwaltung.Temp.Rows(0)("Feld0") = dsToernverwaltung.CrewAdressen.Rows(0)("VZname").ToString
                    gebdat = dsToernverwaltung.CrewAdressen.Rows(0)("Gebdatum").ToString
                    If gebdat.Length > 10 Then
                        gebdat = gebdat.Substring(0, 10)
                    End If
                    dsToernverwaltung.Temp.Rows(0)("Feld1") = gebdat
                    dsToernverwaltung.Temp.Rows(0)("Feld2") = dsToernverwaltung.CrewAdressen.Rows(0)("Gebort").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld3") = dsToernverwaltung.CrewAdressen.Rows(0)("Plz").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(0)("ort").ToString + ", " + dsToernverwaltung.CrewAdressen.Rows(0)("Straße").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld4") = von
                    dsToernverwaltung.Temp.Rows(0)("Feld5") = bis
                    dsToernverwaltung.Temp.Rows(0)("Feld6") = boot
                    dsToernverwaltung.Temp.Rows(0)("Feld7") = type
                    dsToernverwaltung.Temp.Rows(0)("Feld8") = laenge
                    dsToernverwaltung.Temp.Rows(0)("Feld9") = funktionen
                    dsToernverwaltung.Temp.Rows(0)("Feld10") = start
                    dsToernverwaltung.Temp.Rows(0)("Feld11") = smg
                    dsToernverwaltung.Temp.Rows(0)("Feld12") = tiefBreite
                    dsToernverwaltung.Temp.Rows(0)("Feld13") = dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld14") = dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld15") = dsToernverwaltung.Toernname.Rows(0)("revier").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld16") = aFB3
                    dsToernverwaltung.Temp.Rows(0)("Feld48") = ziel
                    dsToernverwaltung.Temp.Rows(0)("Feld49") = aFB2
                    dsToernverwaltung.Temp.Rows(0)("Feld50") = sms
                    If ok Then
                        dsToernverwaltung.Temp.Rows(0)("Feld17") = Schiffsfuehrer
                        dsToernverwaltung.Temp.Rows(0)("Feld18") = schAdresse
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld17") = " Vorname Name"
                        dsToernverwaltung.Temp.Rows(0)("Feld0") = " Vorname Name"
                        dsToernverwaltung.Temp.Rows(0)("Feld18") = "NN"
                        dsToernverwaltung.Temp.Rows(0)("Feld1") = " XX.XX.XXXX "
                        dsToernverwaltung.Temp.Rows(0)("Feld3") = "NN"
                    End If
                    dsToernverwaltung.Temp.Rows(0)("Feld19") = datum10(schgebdatum)
                    dsToernverwaltung.Temp.Rows(0)("Feld20") = schgebort
                    dsToernverwaltung.Temp.Rows(0)("Feld21") = schhandy
                    dsToernverwaltung.Temp.Rows(0)("Feld22") = schemail
                    If syacht Then
                        dsToernverwaltung.Temp.Rows(0)("Feld23") = "S"
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld23") = "M"
                    End If
                    dsToernverwaltung.Temp.Rows(0)("Feld24") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtvon1").ToString + " - " + dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtbis1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld25") = dsToernverwaltung.Toernname.Rows(0)("sm1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld26") = datum10(dsToernverwaltung.Toernname.Rows(0)("NachtfDatumvon1").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitvon1").ToString + " / " + datum10(dsToernverwaltung.Toernname.Rows(0)("NachtfDatumbis1").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitbis1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld27") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtvon2").ToString + " - " + dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtbis2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld28") = dsToernverwaltung.Toernname.Rows(0)("sm2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld29") = datum10(dsToernverwaltung.Toernname.Rows(0)("NachtDatumvon2").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitvon2").ToString + " / " + datum10(dsToernverwaltung.Toernname.Rows(0)("NachtDatumbis2").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitbis2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld30") = dsToernverwaltung.Toernname.Rows(0)("Std50start").ToString + " - " + dsToernverwaltung.Toernname.Rows(0)("Std50ziel").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld31") = dsToernverwaltung.Toernname.Rows(0)("Std50smges").ToString
                    '            dsToernverwaltung.Temp.Rows(0)("Feld31") = dsToernverwaltung.Toernname.Rows(0)("Std50smges").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("Std50smfb2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld32") = datum10(dsToernverwaltung.Toernname.Rows(0)("Std50datumstart").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("Std50zeitstart").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld33") = datum10(dsToernverwaltung.Toernname.Rows(0)("Std50Datumziel").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("Std50zeitziel").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld34") = dsToernverwaltung.Toernname.Rows(0)("Gezhafen1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld35") = datum10(dsToernverwaltung.Toernname.Rows(0)("gezDatum1").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("gezzeit1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld36") = dsToernverwaltung.Toernname.Rows(0)("Gezhafen2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld37") = datum10(dsToernverwaltung.Toernname.Rows(0)("gezDatum2").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("gezzeit2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld38") = dsToernverwaltung.Toernname.Rows(0)("FB4start").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4ziel").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld39") = dsToernverwaltung.Toernname.Rows(0)("FB4smges").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4smfb3").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld40") = datum10(dsToernverwaltung.Toernname.Rows(0)("FB4datumstart").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4zeitstart").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld41") = datum10(dsToernverwaltung.Toernname.Rows(0)("FB4Datumziel").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4zeitziel").ToString
                    If dsToernverwaltung.Temp.Rows(0)("Feld24") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld24") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld24") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld24")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld24") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld25") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld25") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld25") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld26")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld26") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld27")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld27") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld28") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld28") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld28") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld29")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld29") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld30")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld30") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld31") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld31") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld31") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld32") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld32") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld32") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld33") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld33") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld33") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld34") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld34") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld34") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld35") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld35") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld35") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld36") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld36") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld36") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld37") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld37") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld37") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld38") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld38") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld38") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld39") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld39") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld39") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld40") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld40") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld40") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld41") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld41") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld41") = "-----"
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString > "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld42") = dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString
                        dsToernverwaltung.Temp.Rows(0)("Feld43") = datum10(dsToernverwaltung.TC.Rows(0)("NachtaDatum1").ToString) + " " + dsToernverwaltung.TC.Rows(0)("Nachtazeit1").ToString
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld42") = "-----"
                        dsToernverwaltung.Temp.Rows(0)("Feld43") = "----- "
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString > "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld44") = dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString
                        dsToernverwaltung.Temp.Rows(0)("Feld45") = datum10(dsToernverwaltung.TC.Rows(0)("NachtaDatum2").ToString) + " " + dsToernverwaltung.TC.Rows(0)("Nachtazeit2").ToString
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld44") = "----- "
                        dsToernverwaltung.Temp.Rows(0)("Feld45") = "----- "
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen3").ToString > "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld46") = dsToernverwaltung.TC.Rows(0)("Nachtahafen3").ToString
                        dsToernverwaltung.Temp.Rows(0)("Feld47") = datum10(dsToernverwaltung.TC.Rows(0)("NachtaDatum3").ToString) + " " + dsToernverwaltung.TC.Rows(0)("Nachtazeit3").ToString
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld46") = "----- "
                        dsToernverwaltung.Temp.Rows(0)("Feld47") = "----- "
                    End If
                    taTemp.Update(dsToernverwaltung.Temp)
                Else
                    bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                    dsToernverwaltung.Temp.Rows(0)("Feld0") = dsToernverwaltung.CrewAdressen.Rows(0)("VZname").ToString
                    gebdat = datum10(dsToernverwaltung.CrewAdressen.Rows(0)("Gebdatum").ToString)
                    dsToernverwaltung.Temp.Rows(0)("Feld1") = gebdat
                    dsToernverwaltung.Temp.Rows(0)("Feld2") = dsToernverwaltung.CrewAdressen.Rows(0)("Gebort").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld3") = dsToernverwaltung.CrewAdressen.Rows(0)("Plz").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(0)("ort").ToString + ", " + dsToernverwaltung.CrewAdressen.Rows(0)("Straße").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld4") = von
                    dsToernverwaltung.Temp.Rows(0)("Feld5") = bis
                    dsToernverwaltung.Temp.Rows(0)("Feld6") = boot
                    dsToernverwaltung.Temp.Rows(0)("Feld7") = type
                    dsToernverwaltung.Temp.Rows(0)("Feld8") = laenge + " Fuss/m "
                    dsToernverwaltung.Temp.Rows(0)("Feld9") = funktionen
                    dsToernverwaltung.Temp.Rows(0)("Feld10") = start
                    dsToernverwaltung.Temp.Rows(0)("Feld48") = ziel
                    dsToernverwaltung.Temp.Rows(0)("Feld11") = smg
                    dsToernverwaltung.Temp.Rows(0)("Feld12") = tiefBreite + " Fuss/m"
                    dsToernverwaltung.Temp.Rows(0)("Feld13") = dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld14") = dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld15") = dsToernverwaltung.Toernname.Rows(0)("revier").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld16") = aFB3
                    dsToernverwaltung.Temp.Rows(0)("Feld49") = aFB2
                    dsToernverwaltung.Temp.Rows(0)("Feld50") = sms
                    If ok Then
                        dsToernverwaltung.Temp.Rows(0)("Feld17") = Schiffsfuehrer
                        dsToernverwaltung.Temp.Rows(0)("Feld18") = schAdresse
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld17") = " Vorname Name"
                        dsToernverwaltung.Temp.Rows(0)("Feld18") = "NN"
                    End If
                    dsToernverwaltung.Temp.Rows(0)("Feld19") = datum10(schgebdatum)
                    dsToernverwaltung.Temp.Rows(0)("Feld20") = schgebort
                    dsToernverwaltung.Temp.Rows(0)("Feld21") = schhandy
                    dsToernverwaltung.Temp.Rows(0)("Feld22") = schemail
                    If syacht Then
                        dsToernverwaltung.Temp.Rows(0)("Feld23") = "S"
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld23") = "M"
                    End If
                    dsToernverwaltung.Temp.Rows(0)("Feld24") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtvon1").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtbis1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld25") = dsToernverwaltung.Toernname.Rows(0)("sm1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld26") = datum10(dsToernverwaltung.Toernname.Rows(0)("NachtfDatumvon1").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitvon1").ToString + " / " + datum10(dsToernverwaltung.Toernname.Rows(0)("NachtfDatumbis1").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitbis1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld27") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtvon2").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtbis2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld28") = dsToernverwaltung.Toernname.Rows(0)("sm2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld29") = datum10(dsToernverwaltung.Toernname.Rows(0)("NachtDatumvon2").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitvon2").ToString + " / " + datum10(dsToernverwaltung.Toernname.Rows(0)("NachtDatumbis2").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("Nachtzeitbis2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld30") = dsToernverwaltung.Toernname.Rows(0)("Std50start").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("Std50ziel").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld31") = dsToernverwaltung.Toernname.Rows(0)("Std50smges").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("Std50smfb2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld32") = datum10(dsToernverwaltung.Toernname.Rows(0)("Std50datumstart").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("Std50zeitstart").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld33") = datum10(dsToernverwaltung.Toernname.Rows(0)("Std50Datumziel").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("Std50zeitziel").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld34") = dsToernverwaltung.Toernname.Rows(0)("Gezhafen1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld35") = datum10(dsToernverwaltung.Toernname.Rows(0)("gezDatum1").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("gezzeit1").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld36") = dsToernverwaltung.Toernname.Rows(0)("Gezhafen2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld37") = datum10(dsToernverwaltung.Toernname.Rows(0)("gezDatum2").ToString) + " " + dsToernverwaltung.Toernname.Rows(0)("gezzeit2").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld38") = dsToernverwaltung.Toernname.Rows(0)("FB4start").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4ziel").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld39") = dsToernverwaltung.Toernname.Rows(0)("FB4smges").ToString + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4smfb3").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld40") = datum10(dsToernverwaltung.Toernname.Rows(0)("FB4datumstart").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4zeitstart").ToString
                    dsToernverwaltung.Temp.Rows(0)("Feld41") = datum10(dsToernverwaltung.Toernname.Rows(0)("FB4Datumziel").ToString) + "   " + dsToernverwaltung.Toernname.Rows(0)("FB4zeitziel").ToString
                    If dsToernverwaltung.Temp.Rows(0)("Feld24") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld24") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld24") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld24")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld24") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld25") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld25") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld25") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld26")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld26") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld27")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld27") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld28") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld28") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld28") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld29")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld29") = "-----"
                    End If
                    If Len(dsToernverwaltung.Temp.Rows(0)("Feld30")) < 10 Then
                        dsToernverwaltung.Temp.Rows(0)("Feld30") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld31") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld31") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld31") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld32") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld32") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld32") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld33") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld33") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld33") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld34") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld34") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld34") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld35") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld35") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld35") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld36") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld36") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld36") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld37") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld37") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld37") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld38") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld38") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld38") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld39") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld39") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld39") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld40") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld40") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld40") = "-----"
                    End If
                    If dsToernverwaltung.Temp.Rows(0)("Feld41") <= "    " Or dsToernverwaltung.Temp.Rows(0)("Feld41") = "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld41") = "-----"
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString > "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld42") = dsToernverwaltung.TC.Rows(0)("Nachtahafen1").ToString
                        dsToernverwaltung.Temp.Rows(0)("Feld43") = datum10(dsToernverwaltung.TC.Rows(0)("NachtaDatum1").ToString) + " " + dsToernverwaltung.TC.Rows(0)("Nachtazeit1").ToString
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld42") = "----- "
                        dsToernverwaltung.Temp.Rows(0)("Feld43") = "----- "
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString > "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld44") = dsToernverwaltung.TC.Rows(0)("Nachtahafen2").ToString
                        dsToernverwaltung.Temp.Rows(0)("Feld45") = datum10(dsToernverwaltung.TC.Rows(0)("NachtaDatum2").ToString) + " " + dsToernverwaltung.TC.Rows(0)("Nachtazeit2").ToString
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld44") = "----- "
                        dsToernverwaltung.Temp.Rows(0)("Feld45") = "----- "
                    End If
                    If dsToernverwaltung.TC.Rows(0)("Nachtahafen3").ToString > "" Then
                        dsToernverwaltung.Temp.Rows(0)("Feld46") = dsToernverwaltung.TC.Rows(0)("Nachtahafen3").ToString
                        dsToernverwaltung.Temp.Rows(0)("Feld47") = datum10(dsToernverwaltung.TC.Rows(0)("NachtaDatum3").ToString) + " " + dsToernverwaltung.TC.Rows(0)("Nachtazeit3").ToString
                    Else
                        dsToernverwaltung.Temp.Rows(0)("Feld46") = "----- "
                        dsToernverwaltung.Temp.Rows(0)("Feld47") = "----- "
                    End If
                    bsTemp.EndEdit()
                    taTemp.Update(dsToernverwaltung.Temp)
                End If
        End Select

    End Sub
    Private Function datum10(ByVal dat)
        If Len(dat) > 10 Then
            dat = dat.ToString.Substring(0, 10)
        End If
        Return dat
    End Function
    Private Sub Crewwahl()
        Dim crewnr As Integer
        For crewnr = 1 To 12
            funktionen = ""
            If CheckBox4.Checked And crewnr = 2 Then
                If CheckBox54.Checked Then funktionen = "W"
                If CheckBox53.Checked Then funktionen = funktionen + "N"
                If CheckBox52.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox22.Text)
            End If
            If CheckBox5.Checked And crewnr = 3 Then
                If CheckBox51.Checked Then funktionen = "W"
                If CheckBox50.Checked Then funktionen = funktionen + "N"
                If CheckBox49.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox23.Text)
            End If
            If CheckBox6.Checked And crewnr = 4 Then
                If CheckBox48.Checked Then funktionen = "W"
                If CheckBox47.Checked Then funktionen = funktionen + "N"
                If CheckBox46.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox24.Text)
            End If
            If CheckBox7.Checked And crewnr = 5 Then
                If CheckBox45.Checked Then funktionen = "W"
                If CheckBox44.Checked Then funktionen = funktionen + "N"
                If CheckBox43.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox25.Text)
            End If
            If CheckBox8.Checked And crewnr = 6 Then
                If CheckBox42.Checked Then funktionen = "W"
                If CheckBox41.Checked Then funktionen = funktionen + "N"
                If CheckBox40.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox26.Text)
            End If
            If CheckBox9.Checked And crewnr = 1 Then
                If CheckBox16.Checked Then funktionen = "W"
                If CheckBox17.Checked Then funktionen = funktionen + "N"
                If CheckBox18.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox21.Text)
            End If
            If CheckBox10.Checked And crewnr = 8 Then
                If CheckBox39.Checked Then funktionen = "W"
                If CheckBox38.Checked Then funktionen = funktionen + "N"
                If CheckBox37.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox28.Text)
            End If
            If CheckBox11.Checked And crewnr = 9 Then
                If CheckBox36.Checked Then funktionen = "W"
                If CheckBox35.Checked Then funktionen = funktionen + "N"
                If CheckBox4.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox29.Text)
            End If
            If CheckBox12.Checked And crewnr = 10 Then
                If CheckBox33.Checked Then funktionen = "W"
                If CheckBox32.Checked Then funktionen = funktionen + "N"
                If CheckBox31.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox30.Text)
            End If
            If CheckBox13.Checked And crewnr = 11 Then
                If CheckBox30.Checked Then funktionen = "W"
                If CheckBox29.Checked Then funktionen = funktionen + "N"
                If CheckBox28.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox31.Text)
            End If
            If CheckBox14.Checked And crewnr = 12 Then
                If CheckBox27.Checked Then funktionen = "W"
                If CheckBox26.Checked Then funktionen = funktionen + "N"
                If CheckBox25.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox32.Text)
            End If
            If CheckBox15.Checked And crewnr = 9 Then
                If CheckBox21.Checked Then funktionen = "W"
                If CheckBox20.Checked Then funktionen = funktionen + "N"
                If CheckBox19.Checked Then funktionen = funktionen + "R"
                AusgabeTemp(TextBox27.Text)
            End If
        Next
    End Sub
    Private Sub Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drucken.Click
        Dim XL As New PrintOutSM
        Dim dv As DataView
        Dim t As DataTable
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsTemp.Current
        Crewwahl()
        If TextBox16.Text = "" Or TextBox16.Text = " " Then
            MsgBox("Zuerst Ort eintragen, dann drucken")
            TextBox16.Focus()
            GoTo ende
        End If
        If CheckBox23.Checked Then
            Dim sign As String
            sign = GetSetting("sign", "Pfad", "T", " ")
            If My.Computer.FileSystem.FileExists(Trim$(sign)) Then
             Else
                MsgBox("Unterschriftdatei nicht gefunden; Programm wird ohne Unterschrift fortgesetzt.")
                CheckBox23.Checked = False
            End If
         End If
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        If TextBox1.Text > " " Then
            If bsTemp.Count > 0 Then
                dv = bsTemp.List
                t = dv.ToTable("Printing", False, "Feld0", "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld8", "Feld9", "Feld10", "Feld11", "Feld12", "Feld13", "Feld14", "Feld15", "Feld16", "Feld17", "Feld18", "Feld19", "Feld20", "Feld21", "Feld22", "Feld23", "Feld24", "Feld25", "Feld26", "Feld27", "Feld28", "Feld29", "Feld30", "Feld31", "Feld32", "Feld33", "Feld34", "Feld35", "Feld36", "Feld37", "Feld38", "Feld39", "Feld40", "Feld41", "Feld42", "Feld43", "Feld44", "Feld45", "Feld46", "Feld47", "Feld48", "Feld49", "Feld50")
                Select Case ComboBox1.Text
                    Case "ÖSV"
                        XL.PrintSmBestaetugungOSV(t)
                    Case "MSVÖ"
                        XL.PrintSmBestaetugungMSVO(t)
                    Case "JachtVO2020"
                        XL.PrintSmBestaetugungJachtPro(t)
                End Select
                If TextBox16.Text <> " " Then
                    SaveSetting("ort", "Einstellungen", "T", TextBox16.Text)
                End If
                Me.Close()
            Else
                MsgBox("Es wurde keine Änderung der Funktionen an Bord von bereits gedruckten Seemeilenbestätigungen angegeben")
            End If
        Else
            MsgBox("Wähle einen Törn aus")
        End If
ende:
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
End Class