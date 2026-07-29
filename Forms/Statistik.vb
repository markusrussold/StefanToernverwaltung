Public Class Statistik
    Public Freischaltung As String
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public iit As Integer
    Public it As Integer
    Public iic As Integer
    Public ic As Integer
    Public iip As Integer
    Dim pi As Integer
    Public tornanzahl As Single
    Public Bordtage As Single
    Public Nachtf As Single
    Public Schiffsfuehrer As String
    Public schiAnz As Single
    Public toernn As String
    Public mehrmals As Single
    Public smg As Single
    Public sms As Single
    Public aFB2 As Single
    Public aFB3 As Single
    Public crew As Single
    Public herren As Single
    Public damen As Single
    Public jungst As Single
    Public alter As Single
    Dim bootnm As String
    Public DuAlter As Single
    Public var As Single
    Dim x As New CheckKey
    Public ok As Boolean
    Private Sub Statistik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Freischaltung = GetSetting("toern", "Pfad", "T")
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
        End If

        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        '        If bsTemp.Count > 0 Then
        'iip = bsTemp.Count - 1
        'For Me.pi = 0 To iip
        ' bsTemp.RemoveCurrent()
        ' taTemp.Update(dsToernverwaltung)
        ' Next
        ' End If

        bsTemp.AddNew()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by skipper"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        schiAnz = 0
        If bsToernname.Count > 0 Then
            aaa = ""
            iii = bsToernname.Count - 1
            For Me.ij = 0 To iii
                If aaa <> dsToernverwaltung.Toernname.Rows(ij)("Skipper").ToString Then
                    ListBox1.Items.Add(dsToernverwaltung.Toernname.Rows(ij)("Skipper").ToString)
                    aaa = dsToernverwaltung.Toernname.Rows(ij)("Skipper").ToString
                    schiAnz += 1
                End If
            Next
        End If
        alter = 0
        jungst = 100
        TextBox22.Text = "1990"
        TextBox24.Text = "2050"
        '     Me.Text = Format$(Now.Subtract(nTime).TotalSeconds, "0.#### Sek.")

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ListBox2.Items.Add(ListBox1.Text)
        var_loeschen()
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        aaa = ListBox2.Text
        ListBox2.Items.Remove(aaa)
        var_loeschen()
    End Sub

    Private Sub Stati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stati.Click
        If ListBox2.Items.Count = 0 Then
            MsgBox("Wähle zuerst mindestens einen Skipper aus")
            GoTo endeSub
        End If
        Me.Cursor = Cursors.WaitCursor
        var_loeschen()
        iii = ListBox2.Items.Count - 1
        ListBox2.TopIndex = 1
        pi = -1
        ProgressBar1.Maximum = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Step = 1
        For Me.ij = 0 To iii
            ListBox2.SelectedIndex = ij
            Schiffsfuehrer = ListBox2.Text
            maxSuchen()
            ProgressBar1.Maximum = ProgressBar1.Maximum + bsToernname.Count
        Next
        pi = -1
        For Me.ij = 0 To iii
            ListBox2.SelectedIndex = ij
            Schiffsfuehrer = ListBox2.Text
            Toernsuchen()
        Next
        If var = 0 Then
            MsgBox("Dieser Skipper hat nicht kein Boot alleine geführt.")
            GoTo endeSub
        End If
        ausgabe()
        TextBox9.Text = Format(mehrmals, "##")
        var = mehrmals * 100 / crew
        TextBox23.Text = Format(var, "0.#")
        Drucken.Enabled = True

endeSub:
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Toernsuchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        Dim land As String
        Dim pos As Single
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where Skipper = '" & Schiffsfuehrer & "' and year(datumvon) >= '" & TextBox22.Text & "' and year(datumvon) <= '" & TextBox24.Text & "'"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        '     DbAccess.SafePosition(bsToernname)    
        If bsToernname.Count = 0 Then
            MsgBox("Keine Törns in dieser Periode")
            GoTo ende
        End If
        iit = bsToernname.Count - 1
        For Me.it = 0 To iit
            If ProgressBar1.Value < ProgressBar1.Maximum Then
                ProgressBar1.Value = tornanzahl
                '       ProgressBar1.Value = ProgressBar1.Value + 1
                ProgressBar1.PerformStep()
            End If
            tornanzahl += 1
            addieren(var, dsToernverwaltung.Toernname.Rows(it)("bordtage").ToString())
            Bordtage += var
            addieren(var, dsToernverwaltung.Toernname.Rows(it)("Nachtfahrten").ToString())
            Nachtf += var
            addieren(var, dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString())
            smg += var
            If dsToernverwaltung.Toernname.Rows(it)("smSegel").ToString() > "0" And dsToernverwaltung.Toernname.Rows(it)("smSegel").ToString() < "99999" Then
                addieren(var, dsToernverwaltung.Toernname.Rows(it)("smSegel").ToString())
                sms += var
            End If
            addieren(var, dsToernverwaltung.Toernname.Rows(it)("ausserhalbFB2").ToString())
            aFB2 += var
            addieren(var, dsToernverwaltung.Toernname.Rows(it)("ausserhalbFB3").ToString())
            aFB3 += var
            toernn = dsToernverwaltung.Toernname.Rows(it)("Toernbezeichnung").ToString()
            bootnm = dsToernverwaltung.Toernname.Rows(it)("bootsname").ToString()
            TextBox13.Text = tornanzahl
            TextBox19.Text = Bordtage
            TextBox17.Text = Nachtf
            var = Nachtf * 100 / Bordtage
            TextBox11.Text = Format$(var, "0.#")
            TextBox18.Text = smg
            TextBox16.Text = sms
            var = sms * 100 / smg
            TextBox15.Text = aFB2
            TextBox14.Text = Format$(var, "0.#")
            var = aFB2 * 100 / smg
            TextBox12.Text = Format$(var, "0.#")
            TextBox21.Text = aFB3
            var = aFB3 * 100 / smg
            TextBox20.Text = Format$(var, "0.#")
            var = smg / Bordtage
            TextBox10.Text = Format$(var, "0.#")
            Crewsuchen(dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString)
            '           pos = InStr(dsToernverwaltung.Toernname.Rows(it)("Ausgangsmarina").ToString, "/")
            pos = Len(dsToernverwaltung.Toernname.Rows(it)("Ausgangsmarina").ToString)
            If (dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString) > "0" Then
                If pos > 0 Then
                    '               land = dsToernverwaltung.Toernname.Rows(it)("Ausgangsmarina").ToString.Substring(0, pos - 1)
                    land = dsToernverwaltung.Toernname.Rows(it)("Ausgangsmarina").ToString
                    '              pos = InStr(dsToernverwaltung.Toernname.Rows(it)("Endemarina").ToString, "/")
                    '               If land = dsToernverwaltung.Toernname.Rows(it)("Endemarina").ToString.Substring(0, pos - 1) Then
                    If land = dsToernverwaltung.Toernname.Rows(it)("Endemarina").ToString Then
                        ListBox3.Items.Add(land + "§" + dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString)
                    Else
                        '                   ListBox3.Items.Add(land + " - " + dsToernverwaltung.Toernname.Rows(it)("Endemarina").ToString.Substring(0, pos - 1) + "§" + dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString)
                        ListBox3.Items.Add(land + " - " + dsToernverwaltung.Toernname.Rows(it)("Endemarina").ToString + "§" + dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString)
                    End If
                Else
                    ListBox3.Items.Add(" " + "§" + dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString)
                End If
            End If

            '            BootSuchen(dsToernverwaltung.Toernname.Rows(it)("smGesamt").ToString)
        Next
ende:
        ListBox3.Sorted = True
        ListBox4.Sorted = True
    End Sub
    Private Sub maxSuchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
         xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where Skipper = '" & Schiffsfuehrer & "' and year(datumvon) >= '" & TextBox22.Text & "' and year(datumvon) <= '" & TextBox24.Text & "'"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
    End Sub
    Private Sub BootSuchen(ByVal a)
        Dim bAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim b As System.Data.DataRowView = bsBoot.Current
        bAdapter.SelectCommand = New OleDb.OleDbCommand
        bAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        bAdapter.SelectCommand.CommandText = "Select * from Boot where Bootname like '%" & bootnm & "%' "
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        bAdapter.Fill(dsToernverwaltung.Boot)
        DbAccess.SafePosition(bsBoot)
        If bsBoot.Count > 0 Then
            ListBox3.Items.Add(dsToernverwaltung.Boot.Rows(0)("Marinaort").ToString + "§" + a)
        End If
    End Sub
    Private Sub addieren(ByVal a, ByVal b)
        Dim temp As String
        If Not IsNumeric(b) Then
            temp = "0"
        Else
            temp = b
        End If
        var = temp
    End Sub
    Private Sub var_loeschen()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        aaa = "0"
        tornanzahl = 0
        Bordtage = 0
        Nachtf = 0
        Schiffsfuehrer = " "
        schiAnz = 0
        toernn = " "
        mehrmals = 0
        smg = 0
        sms = 0
        aFB2 = 0
        aFB3 = 0
        crew = 0
        herren = 0
        damen = 0
        jungst = 100
        alter = 0
        DuAlter = 0
        var = 0
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        '        For i = 0 To bsTemp.Count - 1
        'bsTemp.RemoveCurrent()
        'taTemp.Update(dsToernverwaltung)
        'Next
    End Sub
    Private Sub Crewsuchen(ByVal a)
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)

        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim tr As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from tc where toern =  '" & toernn & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        DbAccess.SafePosition(bsTC)
        iic = bsTC.Count - 1
        bsTemp.AddNew()
        Dim crewm As Boolean = True
        For Me.ic = 0 To iic
            For i = 0 To ListBox2.Items.Count - 1
                If ListBox2.Items(i) = dsToernverwaltung.TC.Rows(ic)("vzname").ToString Then
                    ' Skipper überspringen
                    crewm = False
                Else
                End If
            Next
            If crewm Then
                bsTemp.AddNew()
                pi += 1
                dsToernverwaltung.Temp.Rows(pi)("Feld1") = dsToernverwaltung.TC.Rows(ic)("vzname").ToString
                dsToernverwaltung.Temp.Rows(pi)("Feld2") = dsToernverwaltung.TC.Rows(ic)("Toern").ToString
                taTemp.Update(dsToernverwaltung.Temp)
                ListBox4.Items.Add(dsToernverwaltung.TC.Rows(ic)("vzname").ToString + "§" + dsToernverwaltung.TC.Rows(ic)("Toern").ToString + "$" + a)
            End If
            crewm = True
        Next

    End Sub
    Private Sub ausgabe()
        Dim bbb As String
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from Temp order by Feld1"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        aaa = " "
        bbb = " "
        If bsTemp.Count > 0 Then
            iip = bsTemp.Count - 1
            For Me.pi = 0 To iip
                If aaa <> dsToernverwaltung.Temp.Rows(pi)("Feld1").ToString Then
                    crewadr(dsToernverwaltung.Temp.Rows(pi)("Feld1").ToString)
                    aaa = dsToernverwaltung.Temp.Rows(pi)("Feld1").ToString
                Else
                    If bbb <> dsToernverwaltung.Temp.Rows(pi)("Feld1").ToString Then
                        mehrmals += 1
                        bbb = dsToernverwaltung.Temp.Rows(pi)("Feld1").ToString
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub crewadr(ByVal nm)
        '   crewadr(dsToernverwaltung.TC.Rows(ic)("VZName").ToString)
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
        Select Case bsCrewAdressen.Count
            Case 0
                If nm > " " Then
                    MsgBox(" Crewadresse ist nicht mehr vorhanden: " & Convert.ToString(nm))
                End If
            Case 1
                DbAccess.SafePosition(bsCrewAdressen)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                crew += 1
                If dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString > "" Then
                    If alter < dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString Then
                        alter = dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString
                    End If
                    If jungst > dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString And dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString > 0 Then
                        jungst = dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString
                    End If

                    var = dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString
                    DuAlter += var
                End If

                If dsToernverwaltung.CrewAdressen.Rows(0)("Anrede").ToString.Contains("Herr") Then
                    herren += 1
                End If
                If dsToernverwaltung.CrewAdressen.Rows(0)("Anrede").ToString.Contains("Frau") Then
                    damen += 1
                End If
                TextBox1.Text = crew
                var = damen * 100 / crew
                TextBox2.Text = damen
                TextBox7.Text = Format$(var, "0.#")
                var = herren * 100 / crew
                TextBox3.Text = herren
                TextBox8.Text = Format$(var, "0.#")
                var = DuAlter / crew
                TextBox4.Text = Format$(var, "0.#")
                TextBox5.Text = jungst
                TextBox6.Text = alter
                TextBox9.Text = Format(mehrmals, "##")
                var = mehrmals * 100 / crew
                TextBox23.Text = Format(var, "0.#")
            Case Else
        End Select
    End Sub
    '     Me.Text = Format$(Now.Subtract(nTime).TotalSeconds, "0.#### Sek.")

    Private Sub Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drucken.Click
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
        Dim smrevier As Single = 0
        Dim smr As String
        Dim revier As String = " "
        Dim pos As Integer
        Dim pose As Integer
        Dim posl As Integer
        Me.Cursor = Cursors.WaitCursor
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        '        If bsTemp.Count > 0 Then
        ' iip = bsTemp.Count - 1
        ' For Me.pi = 0 To iip
        ' bsTemp.RemoveCurrent()
        ' taTemp.Update(dsToernverwaltung)
        ' Next
        ' End If
        iii = ListBox2.Items.Count - 1
        ListBox2.TopIndex = 1
        bsTemp.AddNew()
        For Me.ij = 0 To iii
            ListBox2.SelectedIndex = ij
            Schiffsfuehrer = ListBox2.Text
            bsTemp.AddNew()
            dsToernverwaltung.Temp.Rows(ij)("Feld1") = "Skipper"
            If ok Then
                dsToernverwaltung.Temp.Rows(ij)("Feld2") = Schiffsfuehrer
            Else
                dsToernverwaltung.Temp.Rows(ij)("Feld2") = "Skippername"
            End If
            taTemp.Update(dsToernverwaltung.Temp)
        Next
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(ij)("Feld1") = "Statistik"
        If ok Then
            dsToernverwaltung.Temp.Rows(ij)("Feld2") = tornanzahl
            dsToernverwaltung.Temp.Rows(ij)("Feld3") = Bordtage
        Else
            dsToernverwaltung.Temp.Rows(ij)("Feld2") = 0
            dsToernverwaltung.Temp.Rows(ij)("Feld3") = 0
        End If
        dsToernverwaltung.Temp.Rows(ij)("Feld4") = Nachtf
        dsToernverwaltung.Temp.Rows(ij)("Feld5") = mehrmals
        dsToernverwaltung.Temp.Rows(ij)("Feld6") = smg
        dsToernverwaltung.Temp.Rows(ij)("Feld7") = sms
        dsToernverwaltung.Temp.Rows(ij)("Feld8") = aFB2
        dsToernverwaltung.Temp.Rows(ij)("Feld9") = aFB3
        dsToernverwaltung.Temp.Rows(ij)("Feld10") = crew
        dsToernverwaltung.Temp.Rows(ij)("Feld11") = herren
        dsToernverwaltung.Temp.Rows(ij)("Feld12") = damen
        dsToernverwaltung.Temp.Rows(ij)("Feld13") = jungst
        dsToernverwaltung.Temp.Rows(ij)("Feld14") = alter
        dsToernverwaltung.Temp.Rows(ij)("Feld15") = DuAlter
        taTemp.Update(dsToernverwaltung.Temp)
        ij += 1
        pos = InStr(ListBox3.Items(0).ToString, "§")
        revier = ListBox3.Items(0).ToString.Substring(0, pos - 1)
        pose = Len(ListBox3.Items(0).ToString) - 1
        smr = ListBox3.Items(0).ToString.Substring(pos, pose - pos + 1)
        smrevier += smr
        iit = 1
        For Me.it = 0 To ListBox3.Items.Count - 2
            pos = InStr(ListBox3.Items(it).ToString, "§")
            pose = InStr(ListBox3.Items(it + 1).ToString, "§")
            posl = Len(ListBox3.Items(it + 1).ToString) - 1
            If revier = ListBox3.Items(it + 1).ToString.Substring(0, pose - 1) Then
                smr = ListBox3.Items(it + 1).ToString.Substring(pos, posl - pos + 1)
                smrevier += smr
                iit += 1
            Else
                bsTemp.AddNew()
                dsToernverwaltung.Temp.Rows(ij)("Feld1") = "Revier"
                dsToernverwaltung.Temp.Rows(ij)("Feld2") = revier
                dsToernverwaltung.Temp.Rows(ij)("Feld3") = smrevier
                dsToernverwaltung.Temp.Rows(ij)("Feld4") = iit
                taTemp.Update(dsToernverwaltung.Temp)
                ij += 1
                iit = 1
                '               pos = InStr(ListBox3.Items(it + 1).ToString, "§")
                revier = ListBox3.Items(it + 1).ToString.Substring(0, pose - 1)
                '             posl = Len(ListBox3.Items(it + 1).ToString) - 1
                smrevier = ListBox3.Items(it + 1).ToString.Substring(pose, posl - pose + 1)
            End If
        Next
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(ij)("Feld1") = "Revier"
        dsToernverwaltung.Temp.Rows(ij)("Feld2") = revier
        dsToernverwaltung.Temp.Rows(ij)("Feld3") = smrevier
        dsToernverwaltung.Temp.Rows(ij)("Feld4") = iit
        taTemp.Update(dsToernverwaltung.Temp)


        iit = 1
        Dim posd As Integer
        Dim sortz As String
        For Me.it = 0 To ListBox4.Items.Count - 2
            pos = InStr(ListBox4.Items(it).ToString, "§")
            posd = InStr(ListBox4.Items(it).ToString, "$")
            pose = InStr(ListBox4.Items(it + 1).ToString, "§")
            posl = Len(ListBox4.Items(it).ToString)
            If ListBox4.Items(it).ToString.Substring(0, pos - 1) = ListBox4.Items(it + 1).ToString.Substring(0, pose - 1) Then
                iit += 1
            Else
                Sortbegriff(sortz, iit)
                ListBox5.Items.Add(sortz + "?" + ListBox4.Items(it).ToString.Substring(0, pos - 1))                   ' Name
                iit = 1
            End If
        Next
        Sortbegriff(sortz, iit)
        ListBox5.Items.Add(sortz + "?" + ListBox4.Items(it).ToString.Substring(0, pos - 1))                   ' Name
        ListBox5.Sorted = True

        ij += 1
        For i = ListBox5.Items.Count - 1 To ListBox5.Items.Count - 3 Step -1
            Dim posf As Integer = InStr(ListBox5.Items(i).ToString, "?")
            Dim name As String = ListBox5.Items(i).ToString.Substring(posf, Len(ListBox5.Items(i).ToString) - posf)
            iit = 0
            For Me.it = 0 To ListBox4.Items.Count - 1
                pos = InStr(ListBox4.Items(it).ToString, "§")
                posd = InStr(ListBox4.Items(it).ToString, "$")
                '             pose = InStr(ListBox4.Items(it + 1).ToString, "§")
                posl = Len(ListBox4.Items(it).ToString)
                If ListBox4.Items(it).ToString.Substring(0, pos - 1) = name And ListBox4.Items(it).ToString.Substring(posd, posl - posd) > 0 Then
                    bsTemp.AddNew()
                    dsToernverwaltung.Temp.Rows(ij)("Feld1") = "Crew"
                    dsToernverwaltung.Temp.Rows(ij)("Feld2") = ListBox4.Items(it).ToString.Substring(0, pos - 1)                    ' Name
                    dsToernverwaltung.Temp.Rows(ij)("Feld3") = ListBox4.Items(it).ToString.Substring(pos, posd - pos - 1)           'Törn
                    dsToernverwaltung.Temp.Rows(ij)("Feld4") = ListBox4.Items(it).ToString.Substring(posd, posl - posd)             ' Seemeilen
                    taTemp.Update(dsToernverwaltung.Temp)
                    ij += 1
                End If
            Next
        Next
        druck()
    End Sub
    Private Sub Sortbegriff(ByRef sz, ByRef nm)
        If nm < 10 Then
            sz = "00" + nm.ToString
        Else
            If nm < 100 Then
                sz = "0" + nm.ToString
            Else
                sz = nm.ToString
            End If
        End If
    End Sub
    Private Sub druck()
        Dim Xs As New printOutST
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
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld8", "Feld9", "Feld10", "Feld11", "Feld12", "Feld13", "Feld14", "Feld15")
        Xs.PrintStatistik(t)
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub



End Class