Public Class Meilenauswertung
    Public Freischaltung As String
    Public aenderung As Boolean
    Public logbuch As String
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public ijt As Integer
    Public ik As Integer
    Public ki As Integer
    Public vornachname As String
    Public bt As Single
    Public sm As Single
    Public ss As Single
    Public sg As Single
    Dim x As New CheckKey
    Public ok As Boolean
    Dim pdfname As String
    Dim summesmGesamt As Single = 0
    Dim position As Integer
    Dim buch1 As String
    Dim segelboot As Boolean
    Dim geburtstag14 As Date
    Dim Nachtans As Single
    Private Sub Meilenauswertung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Teilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)

        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        Freischaltung = GetSetting("toern", "Pfad", "T")
        logbuch = GetSetting("Logbuch", "Pfad", "T", "")
        If logbuch = "" Then
            MsgBox("Speicherplatz der Logbücher ist nicht festgelegt - Extras/Speicherort anpassen ")
            Me.Close()
        End If
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
            Label6.Visible = True
        End If
        If Menü.FreischaltZiffer = "2" Or Menü.FreischaltZiffer = "3" Then
            ckbNA.Visible = False
            ckbNA.Checked = False
        Else
            ckbNA.Checked = True
        End If

        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        bsCrewAdressen.AddNew()
        DataGridTemp.Columns(0).HeaderText = "Törnbezeichnung"
        DataGridTemp.Columns(0).Width = 130
        DataGridTemp.Columns(1).HeaderText = "Datum von"
        DataGridTemp.Columns(2).HeaderText = "Datum bis"
        DataGridTemp.Columns(3).HeaderText = "sm Segel"
        DataGridTemp.Columns(4).HeaderText = "sm Motor"
        DataGridTemp.Columns(5).HeaderText = "sm gesamt"
        DataGridTemp.Columns(6).HeaderText = "Nachtfahrten"
        DataGridTemp.Columns(7).HeaderText = "Bordtage"
        DataGridTemp.Columns(8).HeaderText = "sm > FB2"
        DataGridTemp.Columns(9).HeaderText = "sm > FB3"
        DataGridTemp.Columns(10).HeaderText = "Bootsname"
        DataGridTemp.Columns(11).HeaderText = "Skipper"
        DataGridTemp.Visible = False
        GroupBox1.Text = ""
        Button1.Enabled = False
        ProgressBar1.Maximum = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Step = 1
    End Sub
    Private Sub FormularLoeschen()
        summesmGesamt = 0

    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        GroupBox1.Text = "Crew auswählen mit Doppelklick"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        bt = 0
        sg = 0
        sm = 0
        ss = 0

        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox1.Text & "%'"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen where mid(zuname,1,1) like '%" & TextBox1.Text & "%'"
            End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
            End If
        bsCrewAdressen.CancelEdit()
        aenderung = True
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
                xAdapter.Fill(dsToernverwaltung.CrewAdressen)
            Case 1
                FormularLoeschen()
                Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
                xtAdapter.SelectCommand = New OleDb.OleDbCommand
                xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                xtAdapter.SelectCommand.CommandText = "delete * from Temp"
                bsTemp.CancelEdit()
                dsToernverwaltung.Temp.Clear()
                xtAdapter.Fill(dsToernverwaltung.Temp)
                ListBox3.Items.Clear()
                bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridcrew.Visible = False
                DataGridTemp.Visible = True
                 Me.Cursor = Cursors.WaitCursor
                geburtstag14 = TextBox2.Text

                geburtstag14 = "28." & Month(geburtstag14) & "." & Year(geburtstag14) + 14
                '        xAdapter.SelectCommand.CommandText = "Select * from CrewAdressen where month(gebdatum) = '" & mon & "' and (day(gebdatum) = '" & ttag + 1 & "' or day(gebdatum) = '" & ttag & "' or day(gebdatum) = '" & ttag + 2 & " ') order by day(gebdatum)"
                GroupBox1.Text = "Gefahrene Törns"
                vornachname = TextBox1.Text
                Button1.Enabled = False
                BarMaxSuchen()
                ToernSuchen()
                toernAnzeigen()
                If ckbNA.Checked Then
                    NautischeAusbildung()
                End If
                Button1.Enabled = True
                Me.Cursor = Cursors.Default
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCrewAdressen.Position = position
                DataGridcrew.Visible = True
                DataGridTemp.Visible = False
        End Select
    End Sub
    Private Sub positionieren()
        Dim iic As Integer
        iic = bsCrewAdressen.Count - 1
        For i = 0 To iic
            aaa = Mid(dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        DataGridcrew.Visible = True
        Button1.Enabled = False
        suchen()
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridcrew.Click
       suchen()
        Button1.Enabled = True
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridcrew.DoubleClick
         suchen()
        Button1.Enabled = True
    End Sub
    Private Sub toernAnzeigen()
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        Dim revier As String = "1"
       DataGridTemp.Visible = True
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from Temp where feld0 = '" & revier & "'order by year(feld2),month(feld2), day(feld2)"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)

    End Sub
    Private Sub BarMaxSuchen()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from tc where vzname =  '" & vornachname & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        ProgressBar1.Maximum = bsTC.Count

        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim x As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from toernname where skipper = '" & vornachname & "' and smGesamt > '" & 0 & "' "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        ProgressBar1.Maximum = ProgressBar1.Maximum + bsToernname.Count
    End Sub
    Private Sub ToernSuchen()
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        Dim iitc As Integer
        DataGridTemp.Visible = True
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        '      xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        '     xtAdapter.SelectCommand.ExecuteNonQuery()
        '        xtAdapter.SelectCommand.CommandText = "Select * from Temp"
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        ik = 0
        '      If bsTemp.Count > 0 Then
        'iii = bsTemp.Count - 1
        '       For Me.ij = 0 To iii
        'bsTemp.RemoveCurrent()
        '       taTemp.Update(dsToernverwaltung)
        '       Next
        '       End If
        ij = 0
        bsTemp.AddNew()
        '      skipper()

        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from tc where vzname =  '" & vornachname & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        bsTC.Position = 0
        ij = 0
        iitc = bsTC.Count - 1
        Nachtans = 0
        '      dsToernverwaltung.Temp.Rows(ij)("Feld21") = 0
        For Me.ijt = 0 To iitc
            If dsToernverwaltung.TC.Rows(ijt)("NachtaHafen1").ToString > "" Then
                Nachtans += 1
            End If
            If dsToernverwaltung.TC.Rows(ijt)("NachtaHafen2").ToString > "" Then
                Nachtans += 1
            End If
            If dsToernverwaltung.TC.Rows(ijt)("NachtaHafen3").ToString > "" Then
                Nachtans += 1
            End If
            GefToern(dsToernverwaltung.TC.Rows(ijt)("toern").ToString)
            '         If IsDBNull(dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen").ToString) = False Then
            'If dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen").ToString > " " Then
            'dsToernverwaltung.Temp.Rows(ij)("Feld21") = dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen").ToString
            '       End If
            '      End If
            DataGridTemp.Refresh()
            ProgressBar1.Value = ijt
            ProgressBar1.PerformStep()
        Next
        skipper()
        GroupBox1.Text = "Gefahrene Törns"
        TextBoxBT.Text = bt
        TextBoxSG.Text = sg
        TextBoxSM.Text = sm
        TextBoxSS.Text = ss
    End Sub
    Private Sub NautischeAusbildung()
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsKurse.Current
        Dim rt As System.Data.DataRowView = bsTeilnehmer.Current
        Dim kurs As String
        Dim fb As String
        Dim ink As Integer = 0
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where vzname = '" & TextBox1.Text & "' order by datumkbfaellig"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        bsTeilnehmer.Position = 0
        bsTemp.AddNew()
        For i = 0 To bsTeilnehmer.Count - 1
            kurs = DsAusbildung.Teilnehmer.Rows(i)("Kurs").ToString
            fb = DsAusbildung.Teilnehmer.Rows(i)("fb").ToString
            pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
            pAdapter.SelectCommand.CommandText = "Select * from Kurse where (kursbezeichnung = '" & kurs & "' and Fahrtbereich = '" & fb & "') "
            bsKurse.CancelEdit()
            DsAusbildung.Kurse.Clear()
            pAdapter.Fill(DsAusbildung.Kurse)
            bsKurse.Position = 0
            If DsAusbildung.Kurse.Rows(0)("Kursart").ToString = "Theorie" Then
                bsTemp.AddNew()
                dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld0") = "5"
                dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld1") = "Nautische Ausbildung"
                If fb = "-" Then
                    dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld11") = kurs
                Else
                    dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld11") = kurs + " " + fb
                End If
                dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld4") = DsAusbildung.Kurse.Rows(0)("Vortragende").ToString
                dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld7") = DsAusbildung.Kurse.Rows(0)("Kursdauer").ToString
                dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld12") = " "
                dsToernverwaltung.Temp.Rows(ij + ki + i + ink)("Feld2") = DsAusbildung.Kurse.Rows(0)("Kursbeginn").ToString.Substring(0, 10)
                taTemp.Update(dsToernverwaltung.Temp)
            Else
                ink -= 1
            End If
        Next
    End Sub
    Private Sub GefToern(ByVal tname)
        ' in toernname - toernnr den Törnname vorübergehend speichern
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernname.Current
        Dim land As String
        Dim pos As Single
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        If CheckBox2.Checked = True Then
            xAdapter.SelectCommand.CommandText = "Select * from toernname where toernbezeichnung = '" & tname & "' and year(datumbis) >= '" & Year(geburtstag14) & "'"
        Else
            xAdapter.SelectCommand.CommandText = "Select * from toernname where toernbezeichnung = '" & tname & "' "
        End If
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                If IsDBNull(dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString) Then
                Else
                    If dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString > "0" Then
                        bsTemp.AddNew()
                        dsToernverwaltung.Temp.Rows(ij)("Feld0") = "1"
                        dsToernverwaltung.Temp.Rows(ij)("Feld1") = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld5") = dsToernverwaltung.Toernname.Rows(0)("smMotor").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld6") = dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld7") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld8") = dsToernverwaltung.Toernname.Rows(0)("Bordtage").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld9") = dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB2").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld10") = dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB3").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld11") = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                        summesmGesamt += dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString
                        If ok Then
                            dsToernverwaltung.Temp.Rows(ij)("Feld2") = dsToernverwaltung.Toernname.Rows(0)("DatumVon").ToString
                            dsToernverwaltung.Temp.Rows(ij)("Feld3") = dsToernverwaltung.Toernname.Rows(0)("DatumBis").ToString
                            dsToernverwaltung.Temp.Rows(ij)("Feld4") = dsToernverwaltung.Toernname.Rows(0)("smSegel").ToString
                            dsToernverwaltung.Temp.Rows(ij)("Feld12") = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString
                        Else
                            dsToernverwaltung.Temp.Rows(ij)("Feld2") = "01.01.2000"
                            dsToernverwaltung.Temp.Rows(ij)("Feld3") = "31.12.2000"
                            dsToernverwaltung.Temp.Rows(ij)("Feld4") = " 0"
                            dsToernverwaltung.Temp.Rows(ij)("Feld12") = "Skippername"
                        End If
                        If Len(dsToernverwaltung.Toernname.Rows(0)("Bemerkung").ToString) > 250 Then
                            dsToernverwaltung.Temp.Rows(ij)("Feld14") = dsToernverwaltung.Toernname.Rows(0)("Bemerkung").ToString.Substring(0, 250)
                        Else
                            dsToernverwaltung.Temp.Rows(ij)("Feld14") = dsToernverwaltung.Toernname.Rows(0)("Bemerkung").ToString
                        End If
                        dsToernverwaltung.Temp.Rows(ij)("Feld13") = vornachname
                        dsToernverwaltung.Temp.Rows(ij)("Feld22") = dsToernverwaltung.Toernname.Rows(0)("route").ToString
                        dsToernverwaltung.Temp.Rows(ij)("Feld21") = Nachtans
                        Nachtans = 0
                        pdfname = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString.Replace(" ", "") & ".pdf"
                        If System.IO.File.Exists(logbuch & pdfname) Then
                            dsToernverwaltung.Temp.Rows(ij)("Feld15") = 1
                        Else
                            dsToernverwaltung.Temp.Rows(ij)("Feld15") = 0
                        End If


                        bt += dsToernverwaltung.Toernname.Rows(0)("Bordtage").ToString
                        If dsToernverwaltung.Toernname.Rows(0)("smSegel").ToString <> "*" Then
                            ss += dsToernverwaltung.Toernname.Rows(0)("smSegel").ToString
                            sm += dsToernverwaltung.Toernname.Rows(0)("smMotor").ToString
                        End If
                        sg += dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString
                        ik += 1
                        Yachtbestimmen(ij)
                        taTemp.Update(dsToernverwaltung.Temp)

                        ij += 1
                        pos = Len(dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina").ToString)
                        If pos > 0 Then
                            land = dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina").ToString
                            If land = dsToernverwaltung.Toernname.Rows(0)("Endemarina").ToString Then
                                ListBox3.Items.Add(land + "§" + dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString)
                            Else
                                ListBox3.Items.Add(land + " - " + dsToernverwaltung.Toernname.Rows(0)("Endemarina").ToString + "§" + dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString)
                            End If
                        Else
                            ListBox3.Items.Add(" " + "§" + dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString)
                        End If
                    Else
                    End If
                End If
        End Select

    End Sub
    Private Sub skipper()
        ' in toernname - toernnr den Törnname vorübergehend speichern
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernname.Current
        Dim iis As Integer
        Dim ij As Integer
        Dim land As String
        Dim pos As Single
        Dim smrevier As Single = 0
        Dim smr As String
        Dim revier As String = " "
        Dim pos2 As Integer
        Dim pose As Integer
        Dim posl As Integer
        Dim it As Integer
        Dim iit As Integer
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from toernname where skipper = '" & vornachname & "' and smGesamt > '" & 0 & "' "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        ij = ik
        If bsToernname.Count > 0 Then
            bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
            iis = bsToernname.Count - 1
            For Me.ki = 0 To iis
                ProgressBar1.Value = ij + ki + 1
                ProgressBar1.PerformStep()
                If IsDBNull(dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString) Then
                Else
                    If dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString > "0" Then
                        bsTemp.AddNew()
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld0") = "1"
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld1") = dsToernverwaltung.Toernname.Rows(ki)("Toernbezeichnung").ToString
                        If ok Then
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld2") = dsToernverwaltung.Toernname.Rows(ki)("DatumVon").ToString
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld3") = dsToernverwaltung.Toernname.Rows(ki)("DatumBis").ToString
                        Else
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld2") = "01.01.2000"
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld3") = "31.12.2000"
                        End If
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld4") = dsToernverwaltung.Toernname.Rows(ki)("smSegel").ToString
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld5") = dsToernverwaltung.Toernname.Rows(ki)("smMotor").ToString
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld6") = dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld7") = dsToernverwaltung.Toernname.Rows(ki)("Nachtfahrten").ToString
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld8") = dsToernverwaltung.Toernname.Rows(ki)("Bordtage").ToString
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld9") = dsToernverwaltung.Toernname.Rows(ki)("ausserhalbFB2").ToString
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld10") = dsToernverwaltung.Toernname.Rows(ki)("ausserhalbFB3").ToString
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld11") = dsToernverwaltung.Toernname.Rows(ki)("Bootsname").ToString
                        summesmGesamt += dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString
                        If ok Then
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld12") = dsToernverwaltung.Toernname.Rows(ki)("Skipper").ToString
                        Else
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld12") = "Skippername"
                        End If
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld13") = vornachname
                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld21") = Nachtans
                        Nachtans = 0
                        '                 If IsDBNull(dsToernverwaltung.Toernname.Rows(ki)("Nachtansteuerungen").ToString) = False Then
                        '               If dsToernverwaltung.Toernname.Rows(ki)("Nachtansteuerungen").ToString > " " Then
                        '              dsToernverwaltung.Temp.Rows(ij + ki)("Feld21") = dsToernverwaltung.Toernname.Rows(ki)("Nachtansteuerungen").ToString
                        '           End If
                        '         End If
                        pdfname = dsToernverwaltung.Toernname.Rows(0)("Toernbezeichnung").ToString.Replace(" ", "") & ".pdf"
                        If System.IO.File.Exists(logbuch & pdfname) Then
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld15") = 1
                        Else
                            dsToernverwaltung.Temp.Rows(ij + ki)("Feld15") = 0
                        End If

                        dsToernverwaltung.Temp.Rows(ij + ki)("Feld22") = dsToernverwaltung.Toernname.Rows(ki)("route").ToString
                        Yachtbestimmen(ij + ki)
                        taTemp.Update(dsToernverwaltung.Temp)

                        pos = Len(dsToernverwaltung.Toernname.Rows(ki)("Ausgangsmarina").ToString)
                        If pos > 0 Then
                            land = dsToernverwaltung.Toernname.Rows(ki)("Ausgangsmarina").ToString
                            If land = dsToernverwaltung.Toernname.Rows(ki)("Endemarina").ToString Then
                                ListBox3.Items.Add(land + "§" + dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString)
                            Else
                                ListBox3.Items.Add(land + " - " + dsToernverwaltung.Toernname.Rows(ki)("Endemarina").ToString + "§" + dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString)
                            End If
                        Else
                            ListBox3.Items.Add(" " + "§" + dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString)
                        End If

                        bt += dsToernverwaltung.Toernname.Rows(ki)("Bordtage").ToString
                        If dsToernverwaltung.Toernname.Rows(ki)("smSegel").ToString <> "*" Then
                            If dsToernverwaltung.Toernname.Rows(ki)("smSegel").ToString <> "" Then
                                ss += dsToernverwaltung.Toernname.Rows(ki)("smSegel").ToString
                                sm += dsToernverwaltung.Toernname.Rows(ki)("smMotor").ToString
                            End If
                        End If
                        sg += dsToernverwaltung.Toernname.Rows(ki)("smGesamt").ToString
                End If
                End If
            Next
        End If
        '
        ListBox3.Sorted = True
        pos2 = InStr(ListBox3.Items(0).ToString, "§")
        revier = ListBox3.Items(0).ToString.Substring(0, pos2 - 1)
        pose = Len(ListBox3.Items(0).ToString) - 1
        smr = ListBox3.Items(0).ToString.Substring(pos2, pose - pos2 + 1)
        smrevier += smr
        iit = 1
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld0") = "2"
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld1") = "Summe"
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld11") = " "
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld12") = " "
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld4") = summesmGesamt
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld7") = iit
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld2") = Today
        taTemp.Update(dsToernverwaltung.Temp)
        ij += 1
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld0") = "4"
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld1") = "Summe"
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld11") = " "
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld12") = " "
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld4") = summesmGesamt
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld7") = iit
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld2") = Today
        taTemp.Update(dsToernverwaltung.Temp)
        ij += 1
        iit = 1
        For it = 0 To ListBox3.Items.Count - 2
            pos2 = InStr(ListBox3.Items(it).ToString, "§")
            pose = InStr(ListBox3.Items(it + 1).ToString, "§")
            posl = Len(ListBox3.Items(it + 1).ToString) - 1
            If revier = ListBox3.Items(it + 1).ToString.Substring(0, pose - 1) Then
                smr = ListBox3.Items(it + 1).ToString.Substring(pos2, posl - pos2 + 1)
                smrevier += smr
                iit += 1
            Else
                bsTemp.AddNew()
                dsToernverwaltung.Temp.Rows(ij + ki)("Feld0") = "3"
                dsToernverwaltung.Temp.Rows(ij + ki)("Feld1") = "Revier"
                dsToernverwaltung.Temp.Rows(ij + ki)("Feld11") = revier
                dsToernverwaltung.Temp.Rows(ij + ki)("Feld12") = " "
                dsToernverwaltung.Temp.Rows(ij + ki)("Feld4") = smrevier
                dsToernverwaltung.Temp.Rows(ij + ki)("Feld7") = iit
                dsToernverwaltung.Temp.Rows(ij + ki)("Feld2") = Today
                taTemp.Update(dsToernverwaltung.Temp)
                ij += 1
                iit = 1
                revier = ListBox3.Items(it + 1).ToString.Substring(0, pose - 1)
                smrevier = ListBox3.Items(it + 1).ToString.Substring(pose, posl - pose + 1)
            End If
        Next
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld0") = "3"
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld1") = "Revier"
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld11") = revier
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld4") = smrevier
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld7") = iit
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld12") = " "
        dsToernverwaltung.Temp.Rows(ij + ki)("Feld2") = Today
        taTemp.Update(dsToernverwaltung.Temp)

    End Sub
    Private Sub Yachtbestimmen(ByVal yi)
        If dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString > "" Then
            Dim bAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim br As System.Data.DataRowView = bsBoot.Current
            bAdapter.SelectCommand = New OleDb.OleDbCommand
            bAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            bAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & dsToernverwaltung.Temp.Rows(yi)("Feld11").ToString & "' "
            bsBoot.CancelEdit()
            dsToernverwaltung.Boot.Clear()
            bAdapter.Fill(dsToernverwaltung.Boot)
            If bsBoot.Count > 0 Then
                dsToernverwaltung.Temp.Rows(yi)("Feld23") = "Segelboot"
                If dsToernverwaltung.Boot.Rows(0)("motoryacht").ToString Then
                    dsToernverwaltung.Temp.Rows(yi)("Feld23") = "Motorboot"
                    segelboot = False
                End If
                If dsToernverwaltung.Boot.Rows(0)("Segelyacht").ToString Then
                    dsToernverwaltung.Temp.Rows(yi)("Feld23") = "Segelboot"
                    segelboot = True
                End If
            End If
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim XL As New PrintOutMA

        Dim dv As DataView
        Dim t As DataTable
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsTemp.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsTemp.Current
        DataGridTemp.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from temp order by feld0, year(feld2),month(feld2), day(feld2), feld11"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld8", "Feld9", "Feld10", "Feld11", "Feld12", "Feld13", "Feld22", "Feld21", "Feld23", "Feld14", "Feld15")
        XL.PrintMeilen(t)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
End Class