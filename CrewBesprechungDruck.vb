Public Class CrewBesprechungDruck
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Public iii As Integer
    Public aaa As String
    Public ij As Integer
    Dim buch1 As String
    Dim crewanzahl As Single = 0
    Dim TörnA As String
    Dim position As Integer
    Dim boot As String
    Dim termin As String
    Dim revier As String
    Dim charter As String
    Dim produkt As String
    Dim verz As String
    Dim bAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim rAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim etAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim eAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim cdAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tcAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub CrewBesprechungDruck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Boot". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.dsCrewbesprechung.Temp)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.Einkaufsliste". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taEinkaufsliste.Fill(Me.dsCrewbesprechung.Einkaufsliste)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.ErsteTag". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taErsteTag.Fill(Me.dsCrewbesprechung.ErsteTag)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.AnRueckReise". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taAnRueckReise.Fill(Me.dsCrewbesprechung.AnRueckReise)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.CrewDetails". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taCrewDetails.Fill(Me.dsCrewbesprechung.CrewDetails)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.Ablauf". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taAblauf.Fill(Me.dsCrewbesprechung.Ablauf)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        verz = GetSetting("CrewBsp", "Pfad", "T")
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Dim rxt As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsCrewbesprechung.Temp.Clear()
        xtAdapter.Fill(dsCrewbesprechung.Temp)
        bsTemp.AddNew()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        GroupBox1Törn.Location = New Point(1700, 107)
        gbAuswertungen.Location = New Point(1700, 107)
        If My.Computer.FileSystem.FileExists(verz + "Pantry-Hinweise.pdf") Then
        Else
            MsgBox("Datei -Pantry-Hinweise.pdf- kann im Verzeichnis " & Convert.ToString(verz) & " nicht gefunden werden.")
        End If
        If My.Computer.FileSystem.FileExists(verz + "Crew-Hinweise.pdf") Then
        Else
            MsgBox("Datei -Crew-Hinweise.pdf-  kann im Verzeichnis " & Convert.ToString(verz) & " nicht gefunden werden.")
        End If
        If My.Computer.FileSystem.FileExists(verz + "Aufgaben-Skipper.pdf") Then
        Else
            MsgBox("Datei -Aufgaben-Skipper.pdf- kann im Verzeichnis " & Convert.ToString(verz) & " nicht gefunden werden.")
        End If
        If My.Computer.FileSystem.FileExists(verz + "Checkliste-Sicherheitseinweisung.pdf") Then
        Else
            MsgBox("Datei -Checkliste-Sicherheitseinweisung.pdf- kann im Verzeichnis " & Convert.ToString(verz) & " nicht gefunden werden.")
        End If
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")

    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        GroupBox1Törn.Location = New Point(19, 130)
        Dim r As System.Data.DataRowView = bsAblauf.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        '       TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If IsNumeric(TextBox1.Text) And Len(TextBox1.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Ablauf where year(DAtumvon) like '%" & TextBox1.Text & "%'  order by Toernname"
            Else
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox1.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Ablauf order by Toernname"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Ablauf where Toernname like '%" & TextBox1.Text & "%'  order by Toernname"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Ablauf where Mid(Toernname,1,1) like '%" & TextBox1.Text & "%'  order by Toernname"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Ablauf order by Toernname"
        End If
        bsAblauf.CancelEdit()
        '       aenderung = True
        dsCrewbesprechung.Ablauf.Clear()
        xAdapter.Fill(dsCrewbesprechung.Ablauf)
        Select Case bsAblauf.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Ablauf order by Toernname"
                bsAblauf.CancelEdit()
                dsCrewbesprechung.Ablauf.Clear()
                xAdapter.Fill(dsCrewbesprechung.Ablauf)
                '                Formularloeschen()
            Case 1
                bsAblauf.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                gbAuswertungen.Location = New Point(19, 130)
                GroupBox1Törn.Location = New Point(1700, 107)
                TörnA = TextBox1.Text
                Dim rp As System.Data.DataRowView = bsToernname.Current
                pAdapter.SelectCommand = New OleDb.OleDbCommand
                pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                pAdapter.SelectCommand.CommandText = "Select * from toernname where toernbezeichnung = '" & TörnA & "' "
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                pAdapter.Fill(dsToernverwaltung.Toernname)
                bsToernname.Position = 0
                boot = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                termin = SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("Datumvon")) + " - " + SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("Datumbis"))
                revier = ""
                If dsToernverwaltung.Toernname.Rows(0)("Revier").ToString > " " Then revier = dsToernverwaltung.Toernname.Rows(0)("Revier").ToString
                If revier > "" And dsToernverwaltung.Toernname.Rows(0)("Route").ToString > " " Then revier = revier + "/" + dsToernverwaltung.Toernname.Rows(0)("Route").ToString
                If revier = "" And dsToernverwaltung.Toernname.Rows(0)("Route").ToString > " " Then revier = dsToernverwaltung.Toernname.Rows(0)("Route").ToString

                Dim rt As System.Data.DataRowView = bsTC.Current
                tcAdapter.SelectCommand = New OleDb.OleDbCommand
                tcAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                tcAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TörnA & "' order by vzname"
                bsTC.CancelEdit()
                dsToernverwaltung.TC.Clear()
                tcAdapter.Fill(dsToernverwaltung.TC)
                crewanzahl = bsTC.Count + 1


                Dim rb As System.Data.DataRowView = bsBoot.Current
                bAdapter.SelectCommand = New OleDb.OleDbCommand
                bAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                bAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & boot & "' "
                bsBoot.CancelEdit()
                dsToernverwaltung.Boot.Clear()
                bAdapter.Fill(dsToernverwaltung.Boot)
                bsToernname.Position = 0
                charter = dsToernverwaltung.Boot.Rows(0)("Charterfirma").ToString
                produkt = dsToernverwaltung.Boot.Rows(0)("Marke").ToString
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsAblauf.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsAblauf.Count - 1
        For i = 0 To iii
            aaa = Mid(dsCrewbesprechung.Ablauf.Rows(i)("Toernname").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        suchen()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim leer As String = "0"
        Me.Cursor = Cursors.WaitCursor
        Dim pr As New Process
        If cbPantry.Checked Then
            pr.StartInfo.FileName = verz + "pantry-hinweise.pdf"
            pr.StartInfo.Verb = "Print"
            pr.Start()
        End If
        If cbOrganisation.Checked Then
            pr.StartInfo.FileName = verz + "crew-hinweise.pdf"
            pr.StartInfo.Verb = "Print"
            pr.Start()
        End If
        If cbSkipper.Checked Then
            pr.StartInfo.FileName = verz + "Aufgaben-Skipper.pdf"
            pr.StartInfo.Verb = "Print"
            pr.Start()
        End If
        If cbSicherheit.Checked Then
            pr.StartInfo.FileName = verz + "Checkliste-Sicherheitseinweisung.pdf"
            pr.StartInfo.Verb = "Print"
            pr.Start()
        End If
        If cbAblauf.Checked Then Ablauf1()
        If cbCrewDetails.Checked Then crewDetails1()
        If cbErsterTag.Checked Then ersterTag1()
        If cbEinkaufsliste.Checked Then einkaufsliste1()
        Dim Xs As New PrintoutCB
        Dim dv As DataView
        Dim t As DataTable
        Dim xr As System.Data.DataRowView = bsTemp.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from temp where feld3 >  ' " & leer & " '  order by feld3, feld4, feld5"
        bsTemp.CancelEdit()
        dsCrewbesprechung.Temp.Clear()
        xtAdapter.Fill(dsCrewbesprechung.Temp)
        bsTemp.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld8", "Feld9", "Feld10", "Feld11", "Feld12", "Feld13", "Feld14", "Feld15", "Feld16", "Feld17", "Feld18", "Feld19", "Feld20", "Feld21", "Feld23", "Feld24")
        Xs.PrintCrewbesprechung(t)
        Me.Cursor = Cursors.Default
        Me.Close()

    End Sub
    Private Sub crewDetails1()
        bsTemp.AddNew()
        Dim cr As System.Data.DataRowView = bsCrewDetails.Current
        cdAdapter.SelectCommand = New OleDb.OleDbCommand
        cdAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        cdAdapter.SelectCommand.CommandText = "Select * from crewdetails where toernname = '" & TextBox1.Text & "' "
        bsCrewDetails.CancelEdit()
        dsCrewbesprechung.CrewDetails.Clear()
        cdAdapter.Fill(dsCrewbesprechung.CrewDetails)
        If bsCrewDetails.Count = 0 Then
            MsgBox("Crewdetails sind nicht definiert.")
        Else
            TextBox2.Text = TörnA
            TextBox3.Text = 2
            TextBox4.Text = dsCrewbesprechung.CrewDetails.Rows(0)("bb1").ToString
            TextBox5.Text = dsCrewbesprechung.CrewDetails.Rows(0)("bs1").ToString
            TextBox6.Text = dsCrewbesprechung.CrewDetails.Rows(0)("hb1").ToString
            TextBox7.Text = dsCrewbesprechung.CrewDetails.Rows(0)("hs1").ToString
            TextBox8.Text = dsCrewbesprechung.CrewDetails.Rows(0)("Stockoben").ToString
            TextBox9.Text = dsCrewbesprechung.CrewDetails.Rows(0)("Stockunten").ToString
            TextBox10.Text = dsCrewbesprechung.CrewDetails.Rows(0)("bb2").ToString
            TextBox11.Text = dsCrewbesprechung.CrewDetails.Rows(0)("bs2").ToString
            TextBox12.Text = dsCrewbesprechung.CrewDetails.Rows(0)("hb2").ToString
            TextBox13.Text = dsCrewbesprechung.CrewDetails.Rows(0)("hs2").ToString
            TextBox14.Text = dsCrewbesprechung.CrewDetails.Rows(0)("Kenntnisse").ToString
            TextBox21.Text = dsCrewbesprechung.CrewDetails.Rows(0)("Bild").ToString
            TextBox22.Text = dsCrewbesprechung.CrewDetails.Rows(0)("R1").ToString
            TextBox24.Text = dsCrewbesprechung.CrewDetails.Rows(0)("R2").ToString
            TextBox15.Text = charter
            TextBox16.Text = produkt
            TextBox18.Text = boot
            bsTemp.EndEdit()
            taTemp.Update(dsCrewbesprechung.Temp)
        End If
        Dim rr As System.Data.DataRowView = bsAnRueckReise.Current
        rAdapter.SelectCommand = New OleDb.OleDbCommand
        rAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        rAdapter.SelectCommand.CommandText = "Select * from AnRueckReise where toernname = '" & TextBox1.Text & "' "
        bsAnRueckReise.CancelEdit()
        dsCrewbesprechung.AnRueckReise.Clear()
        rAdapter.Fill(dsCrewbesprechung.AnRueckReise)
        If bsAnRueckReise.Count = 0 Then
            MsgBox(" Anreise ist nicht definiert.")
        Else
            For ij = 0 To bsAnRueckReise.Count - 1
                bsTemp.AddNew()
                TextBox2.Text = TörnA
                TextBox3.Text = 3
                Ablauf1copy(TextBox4.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("cw_name").ToString)
                Ablauf1copy(TextBox5.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("cw_ankunftort").ToString)
                Ablauf1copy(TextBox6.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("cw_rueckreise").ToString)
                Ablauf1copy(TextBox7.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("cw_ankunftzeit").ToString)
                Ablauf1copy(TextBox8.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("CW_AbresieZeit").ToString)
                Ablauf1copy(TextBox9.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("cw_bemerkung").ToString)
                Ablauf1copy(TextBox10.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("cw_kenntnisse").ToString)
                Ablauf1copy(TextBox11.Text, dsCrewbesprechung.AnRueckReise.Rows(ij)("cw_telefon").ToString)
                bsTemp.EndEdit()
                taTemp.Update(dsCrewbesprechung.Temp)
            Next
            cbCrewDetails.Checked = True
        End If
    End Sub
    Private Sub ersterTag1()
        Dim rr As System.Data.DataRowView = bsErsteTag.Current
        etAdapter.SelectCommand = New OleDb.OleDbCommand
        etAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        etAdapter.SelectCommand.CommandText = "Select * from ErsteTag where toernname = '" & TextBox1.Text & "' "
        bsErsteTag.CancelEdit()
        dsCrewbesprechung.ErsteTag.Clear()
        etAdapter.Fill(dsCrewbesprechung.ErsteTag)
        If bsErsteTag.Count = 0 Then
            MsgBox("Erster Tag ist nicht definiert.")
        Else
            For ij = 0 To bsErsteTag.Count - 1
                bsTemp.AddNew()
                TextBox2.Text = TörnA
                TextBox3.Text = 4
                TextBox5.Text = dsCrewbesprechung.ErsteTag.Rows(ij)("was").ToString
                TextBox4.Text = dsCrewbesprechung.ErsteTag.Rows(ij)("wann").ToString
                TextBox6.Text = dsCrewbesprechung.ErsteTag.Rows(ij)("wer").ToString
                TextBox7.Text = dsCrewbesprechung.ErsteTag.Rows(ij)("Bemerkung").ToString
                bsTemp.EndEdit()
                taTemp.Update(dsCrewbesprechung.Temp)
                cbErsterTag.Checked = True
            Next
        End If
    End Sub
    Private Sub einkaufsliste1()
        Dim rr As System.Data.DataRowView = bsEinkaufsliste.Current
        eAdapter.SelectCommand = New OleDb.OleDbCommand
        eAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        eAdapter.SelectCommand.CommandText = "Select * from Einkaufsliste where toernname = '" & TextBox1.Text & "' order by gruppe"
        bsEinkaufsliste.CancelEdit()
        dsCrewbesprechung.Einkaufsliste.Clear()
        eAdapter.Fill(dsCrewbesprechung.Einkaufsliste)
        If bsEinkaufsliste.Count = 0 Then
            MsgBox("Einkafsliste ist nicht definiert.")
        Else
            For ij = 0 To bsEinkaufsliste.Count - 1
                If dsCrewbesprechung.Einkaufsliste.Rows(ij)("menge").ToString = "0" Or dsCrewbesprechung.Einkaufsliste.Rows(ij)("Gruppe").ToString < "0" Or dsCrewbesprechung.Einkaufsliste.Rows(ij)("artikel").ToString < "0" Then GoTo weiter
                bsTemp.AddNew()
                TextBox2.Text = TörnA
                TextBox3.Text = 5
                TextBox4.Text = dsCrewbesprechung.Einkaufsliste.Rows(ij)("gruppe").ToString
                TextBox5.Text = dsCrewbesprechung.Einkaufsliste.Rows(ij)("artikel").ToString
                TextBox6.Text = dsCrewbesprechung.Einkaufsliste.Rows(ij)("mengeneinheit").ToString
                TextBox7.Text = dsCrewbesprechung.Einkaufsliste.Rows(ij)("menge").ToString
                TextBox8.Text = dsCrewbesprechung.Einkaufsliste.Rows(ij)("bemerkung").ToString
                TextBox23.Text = crewanzahl
                bsTemp.EndEdit()
                taTemp.Update(dsCrewbesprechung.Temp)
                cbEinkaufsliste.Checked = True
weiter:
            Next
        End If
    End Sub
    Private Sub Ablauf1()
        TextBox2.Text = TörnA
        TextBox3.Text = 1
        TextBox4.Text = " "
        If Not DBNull.Value.Equals(dsCrewbesprechung.Ablauf.Rows(0)("Datum").ToString) Then
            If dsCrewbesprechung.Ablauf.Rows(0)("Datum").ToString > "" Then
                TextBox4.Text = SafeData.FormatDateDe(dsCrewbesprechung.Ablauf.Rows(0)("Datum"))
            End If
        End If
        Ablauf1copy(TextBox5.Text, dsCrewbesprechung.Ablauf.Rows(0)("Thema").ToString)
        Ablauf1copy(TextBox6.Text, dsCrewbesprechung.Ablauf.Rows(0)("Bordkassa").ToString)
        Ablauf1copy(TextBox7.Text, dsCrewbesprechung.Ablauf.Rows(0)("PantryManager").ToString)
        Ablauf1copy(TextBox8.Text, dsCrewbesprechung.Ablauf.Rows(0)("Bemerkung").ToString)
        Ablauf1copy(TextBox9.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender1").ToString)
        Ablauf1copy(TextBox10.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender2").ToString)
        Ablauf1copy(TextBox11.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender3").ToString)
        Ablauf1copy(TextBox12.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender4").ToString)
        Ablauf1copy(TextBox13.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender5").ToString)
        Ablauf1copy(TextBox14.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender6").ToString)
        Ablauf1copy(TextBox15.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender7").ToString)
        Ablauf1copy(TextBox16.Text, dsCrewbesprechung.Ablauf.Rows(0)("Anwesender8").ToString)
        Ablauf1copy(TextBox17.Text, dsCrewbesprechung.Ablauf.Rows(0)("ort").ToString)
        TextBox18.Text = boot
        TextBox19.Text = termin
        TextBox20.Text = revier
        bsTemp.EndEdit()
        taTemp.Update(dsCrewbesprechung.Temp)
        cbAblauf.Checked = True
    End Sub
    Private Sub Ablauf1copy(ByRef text, ByVal Quelle)
        text = " "
        If Not DBNull.Value.Equals(Quelle) Then
            If Quelle > "" Then
                text = Quelle
            End If
        End If

    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

    Private Sub BtBearbeiten_Click(sender As System.Object, e As System.EventArgs) Handles BtBearbeiten.Click
        suchen()
    End Sub

 
End Class