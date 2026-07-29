Public Class Toernblatt
    Public Freischaltung As String
    Public toername As String
    Public aaa As String
    Dim i As Integer
    Public kk As Integer
    Dim skipper As String
    Dim boot As String
    Dim charter As String
    Dim x As New CheckKey
    Public ok As Boolean
    Dim buch1 As String
    Dim position As Integer
    Dim iiii As Integer
    Private Sub Toernblatt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.CrewAdressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Charter". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taCharter.Fill(Me.dsToernverwaltung.Charter)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Boot". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernname.Current
        Freischaltung = GetSetting("toern", "Pfad", "T")
        If Menü.FreischaltZiffer = 1 Or Menü.FreischaltZiffer = 3 Or Menü.FreischaltZiffer = 4 Then
            ok = True
        Else
            ok = False
        End If
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from toernname"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        pAdapter.Fill(dsToernverwaltung.Toernname)
        DbAccess.SafePosition(bsToernname)
        bsToernname.AddNew()
        DataGridView1.Columns(0).Width = 150
             TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")

        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
         DataGridView1.Visible = True
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        '       If bsTemp.Count > 0 Then
        ' iii = bsTemp.Count - 1
        ' For Me.i = 0 To iii
        ' bsTemp.RemoveCurrent()
        ' taTemp.Update(dsToernverwaltung)
        ' Next
        ' End If
        i = 0
        bsTemp.AddNew()

        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where mid(toernbezeichnung,1,1) like '%" & TextBox1.Text & "%' order by toernbezeichnung"
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
                xAdapter.Fill(dsToernverwaltung.Toernname)
            Case 1
                DbAccess.SafePosition(bsToernname)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                toername = TextBox1.Text
                skipper = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString
                boot = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                DataGridView1.Visible = False
                Drucken.Focus()
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
        iiii = bsToernname.Count - 1
        For Me.i = 0 To iiii
            aaa = Mid(dsToernverwaltung.Toernname.Rows(i)("toernbezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub crew(ByVal nm)
        ' in Crewadressen - toernnr den Törnname vorübergehend speichern
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname = '" & nm & "' "
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DataGridView1.Visible = True
        Select Case bsCrewAdressen.Count
            Case 0
                kk = kk - 1
                MsgBox(nm + " ist nicht mehr in der Crew Adressenliste")
            Case 1
                DbAccess.SafePosition(bsCrewAdressen)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bsTemp.AddNew()
                If ok Then
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld1") = dsToernverwaltung.CrewAdressen.Rows(0)("Zuname").ToString
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld2") = dsToernverwaltung.CrewAdressen.Rows(0)("Vorname").ToString
                Else
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld1") = "Crewname"
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld2") = "Vorname"
                End If
                dsToernverwaltung.Temp.Rows(i + kk)("Feld3") = dsToernverwaltung.CrewAdressen.Rows(0)("Straße").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld4") = dsToernverwaltung.CrewAdressen.Rows(0)("Plz").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld5") = dsToernverwaltung.CrewAdressen.Rows(0)("ort").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld6") = dsToernverwaltung.CrewAdressen.Rows(0)("Reisepassnr").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld7") = dsToernverwaltung.CrewAdressen.Rows(0)("Gebdatum").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld8") = dsToernverwaltung.CrewAdressen.Rows(0)("Gebort").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld9") = dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld10") = dsToernverwaltung.CrewAdressen.Rows(0)("nationalitaet").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld11") = dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString
                taTemp.Update(dsToernverwaltung.Temp)
        End Select
    End Sub

    Private Sub Ausgabe()
        Dim XL As New PrintOutTB
        Dim dv As DataView
        Dim t As DataTable
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsTemp.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsTemp.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xAdapter.Fill(dsToernverwaltung.Temp)
        DbAccess.SafePosition(bsTemp)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld8", "Feld9", "Feld10", "Feld11", "Feld12", "Feld13", "Feld14", "Feld15", "Feld16", "Feld17", "Feld18", "Feld19", "Feld20", "Feld21", "Feld23", "Feld24", "Feld25", "Feld26", "feld27", "Feld22", "Feld28")
        XL.PrintToernBlatt(t)
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        suchen()
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        suchen()
    End Sub

    Private Sub Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drucken.Click
        suchen()
        Toernbeschreibung()
        kk = 1
        Bootbeschreibung()
        kk = 2
        Charterfirma()
        kk = 3
        crew(skipper)
        kk = 4
        Crewausgabe()
        Ausgabe()
    End Sub
    Private Sub Charterfirma()
        ' in Crewadressen - toernnr den Törnname vorübergehend speichern
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCharter.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCharter.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Charter where Charterfirma = '" & Charter & "' "
        bsCharter.CancelEdit()
        dsToernverwaltung.Charter.Clear()
        xAdapter.Fill(dsToernverwaltung.Charter)
        Select Case bsCharter.Count
            Case 1
                DbAccess.SafePosition(bsCharter)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bsTemp.AddNew()
                dsToernverwaltung.Temp.Rows(i + kk)("Feld1") = dsToernverwaltung.Charter.Rows(0)("Charterfirma").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld2") = dsToernverwaltung.Charter.Rows(0)("Land").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld3") = dsToernverwaltung.Charter.Rows(0)("Straße").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld4") = dsToernverwaltung.Charter.Rows(0)("Plz").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld5") = dsToernverwaltung.Charter.Rows(0)("ort").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld6") = dsToernverwaltung.Charter.Rows(0)("Telefon").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld7") = dsToernverwaltung.Charter.Rows(0)("Handy").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld8") = dsToernverwaltung.Charter.Rows(0)("email").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld9") = dsToernverwaltung.Charter.Rows(0)("Webauftritt").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld10") = dsToernverwaltung.Charter.Rows(0)("Ansprechsperson").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld11") = dsToernverwaltung.Charter.Rows(0)("Marina").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld12") = dsToernverwaltung.Charter.Rows(0)("Marinaort").ToString
                If CheckBox1.Checked Then
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld22") = dsToernverwaltung.Charter.Rows(0)("Bemerkung").ToString
                Else
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld22") = ""
                End If
                dsToernverwaltung.Temp.Rows(i + kk)("Feld14") = dsToernverwaltung.Charter.Rows(0)("Agentur").ToString
                taTemp.Update(dsToernverwaltung.Temp)
            Case Else
                MsgBox("Charterbasis wurde verändert; überprüfe die Törndaten")
                Me.Close()
        End Select
    End Sub
    Private Sub Bootbeschreibung()
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
                DbAccess.SafePosition(bsBoot)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bsTemp.AddNew()
                dsToernverwaltung.Temp.Rows(i + kk)("Feld1") = dsToernverwaltung.Boot.Rows(0)("Bootname").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld2") = dsToernverwaltung.Boot.Rows(0)("Marke").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld3") = dsToernverwaltung.Boot.Rows(0)("Schiffstyp").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld4") = dsToernverwaltung.Boot.Rows(0)("Kielart").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld5") = dsToernverwaltung.Boot.Rows(0)("Schiffsnummer").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld6") = dsToernverwaltung.Boot.Rows(0)("Länge").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld7") = dsToernverwaltung.Boot.Rows(0)("Breite").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld8") = dsToernverwaltung.Boot.Rows(0)("Verdrängung").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld9") = dsToernverwaltung.Boot.Rows(0)("Tiefgang").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld10") = dsToernverwaltung.Boot.Rows(0)("Großsegel").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld11") = dsToernverwaltung.Boot.Rows(0)("Vorsegel").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld12") = dsToernverwaltung.Boot.Rows(0)("Wassertank").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld13") = dsToernverwaltung.Boot.Rows(0)("Dieseltank").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld14") = dsToernverwaltung.Boot.Rows(0)("Kabinenanzahl").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld15") = dsToernverwaltung.Boot.Rows(0)("Kojenanzahl").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld16") = dsToernverwaltung.Boot.Rows(0)("Nassraeumeanzahl").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld17") = dsToernverwaltung.Boot.Rows(0)("Motor").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld18") = dsToernverwaltung.Boot.Rows(0)("Kaution").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld28") = dsToernverwaltung.Boot.Rows(0)("MMSI").ToString
                '               dsToernverwaltung.Temp.Rows(i + kk)("Feld19") = " "
                '              dsToernverwaltung.Temp.Rows(i + kk)("Feld19") = dsToernverwaltung.Boot.Rows(0)("Bemerkung").ToString
                dsToernverwaltung.Temp.Rows(i + kk)("Feld21") = dsToernverwaltung.Boot.Rows(0)("Grosssegelart").ToString
                If IsDBNull(dsToernverwaltung.Boot.Rows(0)("Baujahr")) = True Then
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld20") = " "
                Else
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld20") = dsToernverwaltung.Boot.Rows(0)("Baujahr").ToString
                End If
                If CheckBox1.Checked Then
                    If IsDBNull(dsToernverwaltung.Boot.Rows(0)("Bemerkung")) = True Then
                        dsToernverwaltung.Temp.Rows(i + kk)("Feld22") = " "
                    Else
                        dsToernverwaltung.Temp.Rows(i + kk)("Feld22") = dsToernverwaltung.Boot.Rows(0)("Bemerkung").ToString
                    End If
                Else
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld22") = " "
                End If


                If IsDBNull(dsToernverwaltung.Boot.Rows(0)("Marinaort")) = True Then
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld23") = " "
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld24") = " "
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld25") = " "
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld26") = " "
                Else
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld23") = dsToernverwaltung.Boot.Rows(0)("Marinaort").ToString
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld24") = dsToernverwaltung.Boot.Rows(0)("Marina").ToString
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld25") = dsToernverwaltung.Boot.Rows(0)("Ansprechsperson").ToString
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld26") = dsToernverwaltung.Boot.Rows(0)("Mobile").ToString
                End If
                If dsToernverwaltung.Boot.Rows(0)("Motoryacht").ToString Then
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld27") = "Motorjacht"
                End If
                If dsToernverwaltung.Boot.Rows(0)("Segelyacht").ToString Then
                    dsToernverwaltung.Temp.Rows(i + kk)("Feld27") = "Segeljacht"
                End If
                taTemp.Update(dsToernverwaltung.Temp)
                charter = dsToernverwaltung.Boot.Rows(0)("Charterfirma").ToString
            Case Else
                MsgBox("Bootsname wurde verändert; überprüfe die Törndaten")
                Me.Close()
        End Select
    End Sub
    Private Sub Toernbeschreibung()
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(i)("Feld1") = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString
        If ok Then
            dsToernverwaltung.Temp.Rows(i)("Feld2") = dsToernverwaltung.Toernname.Rows(0)("DatumVon").ToString
            dsToernverwaltung.Temp.Rows(i)("Feld3") = dsToernverwaltung.Toernname.Rows(0)("DatumBis").ToString
        Else
            dsToernverwaltung.Temp.Rows(i)("Feld2") = "01.01.2000"
            dsToernverwaltung.Temp.Rows(i)("Feld3") = "31.12.2000"
        End If
        dsToernverwaltung.Temp.Rows(i)("Feld4") = dsToernverwaltung.Toernname.Rows(0)("smSegel").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld5") = dsToernverwaltung.Toernname.Rows(0)("smMotor").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld6") = dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld7") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld8") = dsToernverwaltung.Toernname.Rows(0)("Bordtage").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld9") = dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB2").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld10") = dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB3").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld11") = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld12") = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString
        If CheckBox1.Checked Then
            dsToernverwaltung.Temp.Rows(i)("Feld22") = dsToernverwaltung.Toernname.Rows(0)("Bemerkung").ToString
        Else
            dsToernverwaltung.Temp.Rows(i)("Feld22") = ""
        End If
        dsToernverwaltung.Temp.Rows(i)("Feld14") = dsToernverwaltung.Toernname.Rows(0)("Bordkassa").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld15") = dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina").ToString
        dsToernverwaltung.Temp.Rows(i)("Feld16") = dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen").ToString
        taTemp.Update(dsToernverwaltung.Temp)
        kk = 1

    End Sub
    Private Sub Crewausgabe()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        Dim iii As Integer

        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from tc where toern =  '" & toername & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        DbAccess.SafePosition(bsTC)
        iii = bsTC.Count - 1
        For Me.i = 0 To iii
            aaa = dsToernverwaltung.TC.Rows(i)("VZName").ToString
            crew(dsToernverwaltung.TC.Rows(i)("VZName").ToString)
        Next

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

End Class