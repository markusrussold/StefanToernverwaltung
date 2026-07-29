Public Class Export
    Public exportdatei As String
    Public aenderung As Boolean
    Public aaa As String
    Public aaa1 As String
    Public crew As String
    Public skipper As String
    Public charter As String
    Public boot As String
    Public agentura As String
    Public iii As Integer
    Public ij As Integer
    Public iit As Integer
    Public it As Integer
    Public iic As Integer
    Public ic As Integer
    Public iip As Integer
    Public ip As Integer
    Dim verz As String = Environment.CurrentDirectory
    Private Sub Export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taAgentur.Fill(Me.dsToernverwaltung.Agentur)
        Me.taAgenturE.Fill(Me.dsExport.AgenturE)
        Me.taToernnameE.Fill(Me.dsExport.ToernnameE)
        Me.taTCE.Fill(Me.dsExport.TCE)
        Me.taCrewAdressenE.Fill(Me.dsExport.CrewAdressenE)
        Me.taCharterE.Fill(Me.dsExport.CharterE)
        Me.taBootE.Fill(Me.dsExport.BootE)
        Me.taBootE.Fill(Me.dsExport.BootE)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taCharter.Fill(Me.dsToernverwaltung.Charter)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taToernnameE.Fill(Me.dsExport.ToernnameE)
        Me.taTCE.Fill(Me.dsExport.TCE)
        Me.taCrewAdressenE.Fill(Me.dsExport.CrewAdressenE)
        Me.taCharterE.Fill(Me.dsExport.CharterE)
        Me.taBootE.Fill(Me.dsExport.BootE)
        exportdatei = GetSetting("Export", "Pfad", "T")
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Label1.Text = "                                                                            "
        Me.Label1.Refresh()

        If bsToernname.Count > 0 Then
            iii = bsToernname.Count - 1
            For Me.ij = 0 To iii
                ListBox1.Items.Add(dsToernverwaltung.Toernname.Rows(ij)("Toernbezeichnung").ToString)
            Next
        End If
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ListBox2.Items.Add(ListBox1.Text)
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        aaa = ListBox2.Text
        ListBox2.Items.Remove(aaa)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '
        Label1.Text = "Inhalt der alten Exportdatei wird gelöscht."
        '
        Me.Label1.Refresh()
        Dim aadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim ra As System.Data.DataRowView = bsToernnameE.Current
        aadapter.SelectCommand = New OleDb.OleDbCommand
        aadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        aadapter.SelectCommand.CommandText = "Select * from ToernnameE"
        bsToernnameE.CancelEdit()
        dsExport.ToernnameE.Clear()
        aadapter.Fill(dsExport.ToernnameE)
        If bsToernnameE.Count > 0 Then
            iii = bsToernnameE.Count - 1
            For Me.ij = 0 To iii
                bsToernnameE.RemoveCurrent()
                taToernnameE.Update(dsExport)
            Next
        End If

        Dim badapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rb As System.Data.DataRowView = bsBootE.Current
        badapter.SelectCommand = New OleDb.OleDbCommand
        badapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        badapter.SelectCommand.CommandText = "Select * from BootE"
        bsBootE.CancelEdit()
        dsExport.BootE.Clear()
        badapter.Fill(dsExport.BootE)
        If bsBootE.Count > 0 Then
            iii = bsBootE.Count - 1
            For Me.ij = 0 To iii
                bsBootE.RemoveCurrent()
                taBootE.Update(dsExport)
            Next
        End If


        Dim cadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsTCE.Current
        cadapter.SelectCommand = New OleDb.OleDbCommand
        cadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        cadapter.SelectCommand.CommandText = "Select * from tcE"
        bsTCE.CancelEdit()
        dsExport.TCE.Clear()
        cadapter.Fill(dsExport.TCE)
        If bsTCE.Count > 0 Then
            iii = bsTCE.Count - 1
            For Me.ij = 0 To iii
                bsTCE.RemoveCurrent()
                taTCE.Update(dsExport)
            Next
        End If


        Dim dadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rd As System.Data.DataRowView = bsCharterE.Current
        dadapter.SelectCommand = New OleDb.OleDbCommand
        dadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        dadapter.SelectCommand.CommandText = "Select * from charterE"
        bsCharterE.CancelEdit()
        dsExport.CharterE.Clear()
        dadapter.Fill(dsExport.CharterE)
        bsTCE.AddNew()
        If bsCharterE.Count > 0 Then
            iii = bsCharterE.Count - 1
            For Me.ij = 0 To iii
                bsCharterE.RemoveCurrent()
                taCharterE.Update(dsExport)
            Next
        End If

        Dim xadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim xd As System.Data.DataRowView = bsAgenturE.Current
        xadapter.SelectCommand = New OleDb.OleDbCommand
        xadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xadapter.SelectCommand.CommandText = "Select * from agenturE"
        bsAgenturE.CancelEdit()
        dsExport.AgenturE.Clear()
        xadapter.Fill(dsExport.AgenturE)
        '        bsTCE.AddNew()
        If bsAgenturE.Count > 0 Then
            iii = bsAgenturE.Count - 1
            For Me.ij = 0 To iii
                bsAgenturE.RemoveCurrent()
                taAgenturE.Update(dsExport)
            Next
        End If

        Dim eadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim re As System.Data.DataRowView = bsCrewAdressenE.Current
        eadapter.SelectCommand = New OleDb.OleDbCommand
        eadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        eadapter.SelectCommand.CommandText = "Select * from crewadressenE"
        bsCrewAdressenE.CancelEdit()
        dsExport.CrewAdressenE.Clear()
        eadapter.Fill(dsExport.CrewAdressenE)
        If bsCrewAdressenE.Count > 0 Then
            iii = bsCrewAdressenE.Count - 1
            For Me.ij = 0 To iii
                bsCrewAdressenE.RemoveCurrent()
                taCrewAdressenE.Update(dsExport)
            Next
        End If
        Label1.Text = "Der Törn wird exportiert.                                                           "
        Me.Label1.Refresh()

        iii = ListBox2.Items.Count - 1
        ListBox2.TopIndex = 1
        ip = -1
        bsToernnameE.AddNew()
        bsBootE.AddNew()
        bsCharterE.AddNew()
        bsCrewAdressenE.AddNew()
        For Me.ij = 0 To iii
            ListBox2.SelectedIndex = ij
            aaa = ListBox2.Text
            toernexp()
        Next
        Label1.Text = "Fertig                                                                  "
        Me.Label1.Refresh()

    End Sub
    Private Sub toernexp()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & aaa & "'"
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        DbAccess.SafePosition(bsToernname)
        ip = bsToernname.Count
        ip = bsToernnameE.Count
        DbAccess.SafePosition(bsToernnameE)
        bsToernnameE.AddNew()
        dsExport.ToernnameE.Rows(ij)("DatumVon") = dsToernverwaltung.Toernname.Rows(0)("DatumVon").ToString()
        dsExport.ToernnameE.Rows(ij)("DatumBis") = dsToernverwaltung.Toernname.Rows(0)("DatumBis").ToString()
        dsExport.ToernnameE.Rows(ij)("Ausgangsmarina") = dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina").ToString()
        dsExport.ToernnameE.Rows(ij)("EndeMarina") = dsToernverwaltung.Toernname.Rows(0)("EndeMarina").ToString()
        dsExport.ToernnameE.Rows(ij)("toernbezeichnung") = dsToernverwaltung.Toernname.Rows(0)("toernbezeichnung").ToString()
        dsExport.ToernnameE.Rows(ij)("smSegel") = dsToernverwaltung.Toernname.Rows(0)("smSegel").ToString()
        dsExport.ToernnameE.Rows(ij)("smMotor") = dsToernverwaltung.Toernname.Rows(0)("smMotor").ToString()
        dsExport.ToernnameE.Rows(ij)("smGesamt") = dsToernverwaltung.Toernname.Rows(0)("smGesamt").ToString()
        dsExport.ToernnameE.Rows(ij)("Nachtfahrten") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten").ToString()
        dsExport.ToernnameE.Rows(ij)("Nachtansteuerungen") = dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen").ToString()
        dsExport.ToernnameE.Rows(ij)("Bordtage") = dsToernverwaltung.Toernname.Rows(0)("Bordtage").ToString()
        dsExport.ToernnameE.Rows(ij)("ausserhalbFB2") = dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB2").ToString()
        dsExport.ToernnameE.Rows(ij)("ausserhalbFB3") = dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB3").ToString()
        dsExport.ToernnameE.Rows(ij)("Tornbericht") = dsToernverwaltung.Toernname.Rows(0)("Tornbericht").ToString()
        dsExport.ToernnameE.Rows(ij)("Bootsname") = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString()
        dsExport.ToernnameE.Rows(ij)("Skipper") = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString()
        dsExport.ToernnameE.Rows(ij)("letzterSegeltag") = dsToernverwaltung.Toernname.Rows(0)("letzterSegeltag").ToString()
        dsExport.ToernnameE.Rows(ij)("Bemerkung") = dsToernverwaltung.Toernname.Rows(0)("Bemerkung").ToString()
        dsExport.ToernnameE.Rows(ij)("Bordkassa") = dsToernverwaltung.Toernname.Rows(0)("Bordkassa").ToString()
        dsExport.ToernnameE.Rows(ij)("Route") = dsToernverwaltung.Toernname.Rows(0)("Route").ToString()
        dsExport.ToernnameE.Rows(ij)("Logbuch") = dsToernverwaltung.Toernname.Rows(0)("Logbuch").ToString()
        dsExport.ToernnameE.Rows(ij)("Nachtfahrtvon1") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtvon1").ToString()
        dsExport.ToernnameE.Rows(ij)("Nachtfahrtbis1") = dsToernverwaltung.Toernname.Rows(0)("Nachtfahrtbis1").ToString()
        dsExport.ToernnameE.Rows(ij)("Sm1") = dsToernverwaltung.Toernname.Rows(0)("Sm1").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("NachtfDatumvon1").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("NachtfDatumvon1") = dsToernverwaltung.Toernname.Rows(0)("NachtfDatumvon1").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("NachtfZeitvon1") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitvon1").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("NachtfDatumbis1").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("NachtfDatumbis1") = dsToernverwaltung.Toernname.Rows(0)("NachtfDatumbis1").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("NachtfZeitbis1") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitbis1").ToString()
        dsExport.ToernnameE.Rows(ij)("NachtFahrtvon2") = dsToernverwaltung.Toernname.Rows(0)("NachtFahrtvon2").ToString()
        dsExport.ToernnameE.Rows(ij)("NachtFahrtbis2") = dsToernverwaltung.Toernname.Rows(0)("NachtFahrtbis2").ToString()
        dsExport.ToernnameE.Rows(ij)("SM2") = dsToernverwaltung.Toernname.Rows(0)("SM2").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("NachtDatumvon2").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("NachtfDatumvon2") = dsToernverwaltung.Toernname.Rows(0)("NachtDatumvon2").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("NachtfZeitvon2") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitvon2").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("NachtDatumbis2").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("NachtfDatumbis2") = dsToernverwaltung.Toernname.Rows(0)("NachtDatumbis2").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("NachtfZeitbis2") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitbis2").ToString()
        dsExport.ToernnameE.Rows(ij)("Std50Start") = dsToernverwaltung.Toernname.Rows(0)("Std50Start").ToString()
        dsExport.ToernnameE.Rows(ij)("Std50Ziel") = dsToernverwaltung.Toernname.Rows(0)("Std50Ziel").ToString()
        dsExport.ToernnameE.Rows(ij)("Std50SmGes") = dsToernverwaltung.Toernname.Rows(0)("Std50SmGes").ToString()
        dsExport.ToernnameE.Rows(ij)("Std50smFB2") = dsToernverwaltung.Toernname.Rows(0)("Std50smFB2").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("Std50DatumStart").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("Std50DatumStart") = dsToernverwaltung.Toernname.Rows(0)("Std50DatumStart").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("Std50ZeitStart") = dsToernverwaltung.Toernname.Rows(0)("Std50ZeitStart").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("Std50DatumZiel").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("Std50DatumZiel") = dsToernverwaltung.Toernname.Rows(0)("Std50DatumZiel").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("Std50ZeitZiel") = dsToernverwaltung.Toernname.Rows(0)("Std50ZeitZiel").ToString()
        dsExport.ToernnameE.Rows(ij)("GezHafen1") = dsToernverwaltung.Toernname.Rows(0)("GezHafen1").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("GezDatum1").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("GezDatum1") = dsToernverwaltung.Toernname.Rows(0)("GezDatum1").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("GezZeit1") = dsToernverwaltung.Toernname.Rows(0)("GezZeit1").ToString()
        dsExport.ToernnameE.Rows(ij)("GezHafen2") = dsToernverwaltung.Toernname.Rows(0)("GezHafen2").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("GezDatum2").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("GezDatum2") = dsToernverwaltung.Toernname.Rows(0)("GezDatum2").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("GezZeit2") = dsToernverwaltung.Toernname.Rows(0)("GezZeit2").ToString()
        dsExport.ToernnameE.Rows(ij)("FB4Start") = dsToernverwaltung.Toernname.Rows(0)("FB4Start").ToString()
        dsExport.ToernnameE.Rows(ij)("FB4Ziel") = dsToernverwaltung.Toernname.Rows(0)("FB4Ziel").ToString()
        dsExport.ToernnameE.Rows(ij)("FB4SmGes") = dsToernverwaltung.Toernname.Rows(0)("FB4SmGes").ToString()
        dsExport.ToernnameE.Rows(ij)("FB4SmFb3") = dsToernverwaltung.Toernname.Rows(0)("FB4SmFb3").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("FB4DatumStart").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("FB4DatumStart") = dsToernverwaltung.Toernname.Rows(0)("FB4DatumStart").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("FB4ZeitStart") = dsToernverwaltung.Toernname.Rows(0)("FB4ZeitStart").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("FB4DatumZiel").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("FB4DatumZiel") = dsToernverwaltung.Toernname.Rows(0)("FB4DatumZiel").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("FB4ZeitZiel") = dsToernverwaltung.Toernname.Rows(0)("FB4ZeitZiel").ToString()
        dsExport.ToernnameE.Rows(ij)("Revier") = dsToernverwaltung.Toernname.Rows(0)("Revier").ToString()
        taToernnameE.Update(dsExport.ToernnameE)
        skipper = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString()
        boot = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString()
        ToernDir(aaa)
        crewDir(skipper)
        crewexp(skipper)
        bootexp()
        TCEExp()
    End Sub
    Private Sub TCEExp()
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim tr As System.Data.DataRowView = bsTC.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from tc where toern = '" & aaa & "'"
        dsToernverwaltung.TC.Clear()
        xtAdapter.Fill(dsToernverwaltung.TC)
        DbAccess.SafePosition(bsTC)
        iip = bsTC.Count - 1
        it = bsTCE.Count - 1
        For Me.ip = 0 To iip
            bsTCE.AddNew()
            dsExport.TCE.Rows(ip + it)("toern") = dsToernverwaltung.TC.Rows(ip)("Toern").ToString()
            dsExport.TCE.Rows(ip + it)("VZname") = dsToernverwaltung.TC.Rows(ip)("VZname").ToString()
            dsExport.TCE.Rows(ip + it)("smNachweis") = dsToernverwaltung.TC.Rows(ip)("smNachweis").ToString()
            dsExport.TCE.Rows(ip + it)("Wachfuehrer") = dsToernverwaltung.TC.Rows(ip)("Wachfuehrer").ToString()
            dsExport.TCE.Rows(ip + it)("Navigator") = dsToernverwaltung.TC.Rows(ip)("Navigator").ToString()
            dsExport.TCE.Rows(ip + it)("Rudergaenger") = dsToernverwaltung.TC.Rows(ip)("Rudergaenger").ToString()
            dsExport.TCE.Rows(ip + it)("R1") = dsToernverwaltung.TC.Rows(ip)("R1").ToString()
            dsExport.TCE.Rows(ip + it)("R2") = dsToernverwaltung.TC.Rows(ip)("R2").ToString()
            dsExport.TCE.Rows(ip + it)("R3") = dsToernverwaltung.TC.Rows(ip)("R3").ToString()
            dsExport.TCE.Rows(ip + it)("NachtaHafen1") = dsToernverwaltung.TC.Rows(ip)("NachtaHafen1").ToString()
            If IsDate(dsToernverwaltung.TC.Rows(ip)("NachtaDatum1").ToString()) Then
                dsExport.TCE.Rows(ip + it)("NachtaDatum1") = dsToernverwaltung.TC.Rows(ip)("NachtaDatum1").ToString()
            End If
            dsExport.TCE.Rows(ip + it)("NachtaZeit1") = dsToernverwaltung.TC.Rows(ip)("NachtaZeit1").ToString()
            dsExport.TCE.Rows(ip + it)("NachtaHafen2") = dsToernverwaltung.TC.Rows(ip)("NachtaHafen2").ToString()
            If IsDate(dsToernverwaltung.TC.Rows(ip)("NachtaDatum2").ToString()) Then
                dsExport.TCE.Rows(ip + it)("NachtaDatum2") = dsToernverwaltung.TC.Rows(ip)("NachtaDatum2").ToString()
            End If
            dsExport.TCE.Rows(ip + it)("NachtaZeit2") = dsToernverwaltung.TC.Rows(ip)("NachtaZeit2").ToString()
            dsExport.TCE.Rows(ip + it)("NachtaHafen3") = dsToernverwaltung.TC.Rows(ip)("NachtaHafen3").ToString()
            If IsDate(dsToernverwaltung.TC.Rows(ip)("NachtaDatum3").ToString()) Then
                dsExport.TCE.Rows(ip + it)("NachtaDatum3") = dsToernverwaltung.TC.Rows(ip)("NachtaDatum3").ToString()
            End If
            dsExport.TCE.Rows(ip + it)("NachtaZeit3") = dsToernverwaltung.TC.Rows(ip)("NachtaZeit3").ToString()
            taTCE.Update(dsExport.TCE)
            crew = dsToernverwaltung.TC.Rows(ip)("VZname").ToString()
            crewexp(crew)
        Next
    End Sub
    Public Sub crewexp(ByVal crewname)
        Dim xcAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim cr As System.Data.DataRowView = bsCrewAdressen.Current
        Dim heute As Date
        xcAdapter.SelectCommand = New OleDb.OleDbCommand
        xcAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xcAdapter.SelectCommand.CommandText = "Select * from CrewAdressen where vzname = '" & crewname & "'"
        dsToernverwaltung.CrewAdressen.Clear()
        xcAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        heute = Today
        ic = bsCrewAdressenE.Count - 1
        If bsCrewAdressen.Count > 0 Then
            bsCrewAdressenE.AddNew()
            dsExport.CrewAdressenE.Rows(ic)("Zuname") = dsToernverwaltung.CrewAdressen.Rows(0)("Zuname").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Vorname") = dsToernverwaltung.CrewAdressen.Rows(0)("Vorname").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Anrede") = dsToernverwaltung.CrewAdressen.Rows(0)("Anrede").ToString()
            dsExport.CrewAdressenE.Rows(ic)("VZname") = dsToernverwaltung.CrewAdressen.Rows(0)("VZname").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Handy") = dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString()
            dsExport.CrewAdressenE.Rows(ic)("email") = dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString()
            dsExport.CrewAdressenE.Rows(ic)("toernnr") = dsToernverwaltung.CrewAdressen.Rows(0)("toernnr").ToString()
            dsExport.CrewAdressenE.Rows(ic)("AlterersterToern") = IIf(DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString(), ""), 0, dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString())
            dsExport.CrewAdressenE.Rows(ic)("Straße") = dsToernverwaltung.CrewAdressen.Rows(0)("Straße").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Plz") = dsToernverwaltung.CrewAdressen.Rows(0)("Plz").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Ort") = dsToernverwaltung.CrewAdressen.Rows(0)("Ort").ToString()
            dsExport.CrewAdressenE.Rows(ic)("ReisepassNr") = dsToernverwaltung.CrewAdressen.Rows(0)("ReisepassNr").ToString()
            If dsToernverwaltung.CrewAdressen.Rows(0)("GebDatum").ToString() > "" Then
                dsExport.CrewAdressenE.Rows(ic)("GebDatum") = IIf(DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("GebDatum").ToString(), ""), heute, dsToernverwaltung.CrewAdressen.Rows(0)("GebDatum").ToString())
            End If
            dsExport.CrewAdressenE.Rows(ic)("GebOrt") = dsToernverwaltung.CrewAdressen.Rows(0)("GebOrt").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Funk") = dsToernverwaltung.CrewAdressen.Rows(0)("Funk").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Segelschein") = dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Bemerkung") = dsToernverwaltung.CrewAdressen.Rows(0)("Bemerkung").ToString()
            dsExport.CrewAdressenE.Rows(ic)("nationalitaet") = dsToernverwaltung.CrewAdressen.Rows(0)("nationalitaet").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Reihenfolge") = IIf(DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("Reihenfolge").ToString(), ""), 0, dsToernverwaltung.CrewAdressen.Rows(0)("Reihenfolge").ToString())
            dsExport.CrewAdressenE.Rows(ic)("SegelscheinDatum") = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinDatum").ToString()
            dsExport.CrewAdressenE.Rows(ic)("SegelscheinVerband") = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinVerband").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Status") = dsToernverwaltung.CrewAdressen.Rows(0)("Status").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Clubmitglied") = dsToernverwaltung.CrewAdressen.Rows(0)("Clubmitglied").ToString()
            dsExport.CrewAdressenE.Rows(ic)("FB1") = dsToernverwaltung.CrewAdressen.Rows(0)("FB1").ToString()
            dsExport.CrewAdressenE.Rows(ic)("FB2") = dsToernverwaltung.CrewAdressen.Rows(0)("FB2").ToString()
            dsExport.CrewAdressenE.Rows(ic)("FB3") = dsToernverwaltung.CrewAdressen.Rows(0)("FB3").ToString()
            dsExport.CrewAdressenE.Rows(ic)("FB4") = dsToernverwaltung.CrewAdressen.Rows(0)("FB4").ToString()
            dsExport.CrewAdressenE.Rows(ic)("A-Schein") = dsToernverwaltung.CrewAdressen.Rows(0)("A-Schein").ToString()
            dsExport.CrewAdressenE.Rows(ic)("Motorboot") = dsToernverwaltung.CrewAdressen.Rows(0)("Motorboot").ToString()
            dsExport.CrewAdressenE.Rows(ic)("R1") = dsToernverwaltung.CrewAdressen.Rows(0)("R1").ToString()
            dsExport.CrewAdressenE.Rows(ic)("R2") = dsToernverwaltung.CrewAdressen.Rows(0)("R2").ToString()
            dsExport.CrewAdressenE.Rows(ic)("R3") = dsToernverwaltung.CrewAdressen.Rows(0)("R3").ToString()
            If dsToernverwaltung.CrewAdressen.Rows(0)("Sterbedatum").ToString() > "" Then
                dsExport.CrewAdressenE.Rows(ic)("Sterbedatum") = dsToernverwaltung.CrewAdressen.Rows(0)("Sterbedatum").ToString()
            End If
             taCrewAdressenE.Update(dsExport.CrewAdressenE)
            crewDir(crewname)
        Else
            bsCrewAdressenE.AddNew()
            dsExport.CrewAdressenE.Rows(ic)("Zuname") = crewname + "fehlt"
            taCrewAdressenE.Update(dsExport.CrewAdressenE)
        End If
    End Sub
    Public Sub bootexp()
        Dim xbAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim br As System.Data.DataRowView = bsBoot.Current
        xbAdapter.SelectCommand = New OleDb.OleDbCommand
        xbAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xbAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & boot & "'"
        dsToernverwaltung.Boot.Clear()
        xbAdapter.Fill(dsToernverwaltung.Boot)
        DbAccess.SafePosition(bsBoot)
        DbAccess.SafePosition(bsBootE)
        bsBootE.AddNew()
        dsExport.BootE.Rows(ij)("Bootname") = dsToernverwaltung.Boot.Rows(0)("Bootname").ToString()
        dsExport.BootE.Rows(ij)("Marke") = dsToernverwaltung.Boot.Rows(0)("Marke").ToString()
        dsExport.BootE.Rows(ij)("Schiffstyp") = dsToernverwaltung.Boot.Rows(0)("Schiffstyp").ToString()
        dsExport.BootE.Rows(ij)("Kielart") = dsToernverwaltung.Boot.Rows(0)("Kielart").ToString()
        dsExport.BootE.Rows(ij)("Schiffsnummer") = dsToernverwaltung.Boot.Rows(0)("Schiffsnummer").ToString()
        dsExport.BootE.Rows(ij)("Durchfahrtshoehe") = dsToernverwaltung.Boot.Rows(0)("Durchfahrtshoehe").ToString()
        dsExport.BootE.Rows(ij)("Länge") = dsToernverwaltung.Boot.Rows(0)("Länge").ToString()
        dsExport.BootE.Rows(ij)("Breite") = dsToernverwaltung.Boot.Rows(0)("Breite").ToString()
        dsExport.BootE.Rows(ij)("Verdrängung") = dsToernverwaltung.Boot.Rows(0)("Verdrängung").ToString()
        dsExport.BootE.Rows(ij)("Tiefgang") = dsToernverwaltung.Boot.Rows(0)("Tiefgang").ToString()
        dsExport.BootE.Rows(ij)("Großsegel") = dsToernverwaltung.Boot.Rows(0)("Großsegel").ToString()
        dsExport.BootE.Rows(ij)("Vorsegel") = dsToernverwaltung.Boot.Rows(0)("Vorsegel").ToString()
        dsExport.BootE.Rows(ij)("Wassertank") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Wassertank").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Wassertank").ToString())
        dsExport.BootE.Rows(ij)("Dieseltank") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Dieseltank").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Dieseltank").ToString())
        dsExport.BootE.Rows(ij)("Starterbatterie") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Starterbatterie").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Starterbatterie").ToString())
        dsExport.BootE.Rows(ij)("Servicebatterie") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Servicebatterie").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Servicebatterie").ToString())
        dsExport.BootE.Rows(ij)("Kabinenanzahl") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Kabinenanzahl").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Kabinenanzahl").ToString())
        dsExport.BootE.Rows(ij)("Kojenanzahl") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Kojenanzahl").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Kojenanzahl").ToString())
        dsExport.BootE.Rows(ij)("Nassraeumeanzahl") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Nassraeumeanzahl").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Nassraeumeanzahl").ToString())
        dsExport.BootE.Rows(ij)("Motor") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Motor").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Motor").ToString())
        dsExport.BootE.Rows(ij)("Kaution") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Kaution").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Kaution").ToString())
        dsExport.BootE.Rows(ij)("Bild") = dsToernverwaltung.Boot.Rows(0)("Bild").ToString()
        dsExport.BootE.Rows(ij)("Charterfirma") = dsToernverwaltung.Boot.Rows(0)("Charterfirma").ToString()
        dsExport.BootE.Rows(ij)("Bemerkung") = dsToernverwaltung.Boot.Rows(0)("Bemerkung").ToString()
        dsExport.BootE.Rows(ij)("MMSI") = dsToernverwaltung.Boot.Rows(0)("MMSI").ToString()
        dsExport.BootE.Rows(ij)("Grosssegelart") = dsToernverwaltung.Boot.Rows(0)("Grosssegelart").ToString()
        dsExport.BootE.Rows(ij)("Baujahr") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Baujahr").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Baujahr").ToString())
        dsExport.BootE.Rows(ij)("Radar") = dsToernverwaltung.Boot.Rows(0)("Radar").ToString()
        dsExport.BootE.Rows(ij)("Bugstrahlruder") = dsToernverwaltung.Boot.Rows(0)("Bugstrahlruder").ToString()
        dsExport.BootE.Rows(ij)("Marinaort") = dsToernverwaltung.Boot.Rows(0)("Marinaort").ToString()
        dsExport.BootE.Rows(ij)("Marina") = dsToernverwaltung.Boot.Rows(0)("Marina").ToString()
        dsExport.BootE.Rows(ij)("Ansprechsperson") = dsToernverwaltung.Boot.Rows(0)("Ansprechsperson").ToString()
        dsExport.BootE.Rows(ij)("Heizung") = dsToernverwaltung.Boot.Rows(0)("Heizung").ToString()
        dsExport.BootE.Rows(ij)("Klimaanlage") = dsToernverwaltung.Boot.Rows(0)("Klimaanlage").ToString()
        dsExport.BootE.Rows(ij)("Mobile") = dsToernverwaltung.Boot.Rows(0)("Mobile").ToString()
        dsExport.BootE.Rows(ij)("R1") = dsToernverwaltung.Boot.Rows(0)("R1").ToString()
        dsExport.BootE.Rows(ij)("R2") = dsToernverwaltung.Boot.Rows(0)("R2").ToString()
        dsExport.BootE.Rows(ij)("R3") = dsToernverwaltung.Boot.Rows(0)("R3").ToString()
        dsExport.BootE.Rows(ij)("Motoryacht") = dsToernverwaltung.Boot.Rows(0)("Motoryacht").ToString()
        dsExport.BootE.Rows(ij)("Segelyacht") = dsToernverwaltung.Boot.Rows(0)("Segelyacht").ToString()
        taBootE.Update(dsExport.BootE)
        BootDir(dsToernverwaltung.Boot.Rows(0)("Bootname").ToString())
        charter = dsToernverwaltung.Boot.Rows(0)("Charterfirma").ToString()
        charterexp()
    End Sub
    Private Sub charterexp()
        Dim xcAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim br As System.Data.DataRowView = bsCharter.Current
        xcAdapter.SelectCommand = New OleDb.OleDbCommand
        xcAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xcAdapter.SelectCommand.CommandText = "Select * from charter where Charterfirma = '" & charter & "'"
        dsToernverwaltung.Charter.Clear()
        xcAdapter.Fill(dsToernverwaltung.Charter)
        If bsCharter.Count > 0 Then
            DbAccess.SafePosition(bsCharter)
            bsCharterE.AddNew()
            dsExport.CharterE.Rows(ij)("Charterfirma") = dsToernverwaltung.Charter.Rows(0)("Charterfirma").ToString()
            dsExport.CharterE.Rows(ij)("Straße") = dsToernverwaltung.Charter.Rows(0)("Straße").ToString()
            dsExport.CharterE.Rows(ij)("PLZ") = dsToernverwaltung.Charter.Rows(0)("PLZ").ToString()
            dsExport.CharterE.Rows(ij)("Ort") = dsToernverwaltung.Charter.Rows(0)("Ort").ToString()
            dsExport.CharterE.Rows(ij)("Land") = dsToernverwaltung.Charter.Rows(0)("Land").ToString()
            dsExport.CharterE.Rows(ij)("Telefon") = dsToernverwaltung.Charter.Rows(0)("Telefon").ToString()
            dsExport.CharterE.Rows(ij)("Handy") = dsToernverwaltung.Charter.Rows(0)("Handy").ToString()
            dsExport.CharterE.Rows(ij)("email") = dsToernverwaltung.Charter.Rows(0)("email").ToString()
            dsExport.CharterE.Rows(ij)("WEBAuftritt") = dsToernverwaltung.Charter.Rows(0)("WEBAuftritt").ToString()
            dsExport.CharterE.Rows(ij)("Ansprechsperson") = dsToernverwaltung.Charter.Rows(0)("Ansprechsperson").ToString()
            dsExport.CharterE.Rows(ij)("Marina") = dsToernverwaltung.Charter.Rows(0)("Marina").ToString()
            dsExport.CharterE.Rows(ij)("Marinaort") = dsToernverwaltung.Charter.Rows(0)("Marinaort").ToString()
            dsExport.CharterE.Rows(ij)("Bemerkung") = dsToernverwaltung.Charter.Rows(0)("Bemerkung").ToString()
            dsExport.CharterE.Rows(ij)("Fax") = dsToernverwaltung.Charter.Rows(0)("Fax").ToString()
            dsExport.CharterE.Rows(ij)("Agentur") = dsToernverwaltung.Charter.Rows(0)("Agentur").ToString()
            dsExport.CharterE.Rows(ij)("R1") = dsToernverwaltung.Charter.Rows(0)("R1").ToString()
            dsExport.CharterE.Rows(ij)("R2") = dsToernverwaltung.Charter.Rows(0)("R2").ToString()
            dsExport.CharterE.Rows(ij)("R3") = dsToernverwaltung.Charter.Rows(0)("R3").ToString()
            taCharterE.Update(dsExport.CharterE)
            agentura = dsToernverwaltung.Charter.Rows(0)("Agentur").ToString()
            agenturexp()
        Else
            bsCharterE.AddNew()
            dsExport.CharterE.Rows(ij)("Charterfirma") = "Charterfirma"
            taCharterE.Update(dsExport.CharterE)
        End If
    End Sub
    Private Sub agenturexp()
        Dim xaAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim br As System.Data.DataRowView = bsAgentur.Current
        xaAdapter.SelectCommand = New OleDb.OleDbCommand
        xaAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xaAdapter.SelectCommand.CommandText = "Select * from agentur where Agentur = '" & Agentura & "'"
        dsToernverwaltung.Agentur.Clear()
        xaAdapter.Fill(dsToernverwaltung.Agentur)
        Dim xadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim xd As System.Data.DataRowView = bsAgenturE.Current
        xadapter.SelectCommand = New OleDb.OleDbCommand
        xadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xadapter.SelectCommand.CommandText = "Select * from agenturE where Agentur = '" & agentura & "'"
        bsAgenturE.CancelEdit()
        dsExport.AgenturE.Clear()
        xadapter.Fill(dsExport.AgenturE)
        If bsAgenturE.Count = 0 Then
            If bsAgentur.Count > 0 Then
                DbAccess.SafePosition(bsAgentur)
                bsAgenturE.AddNew()
                bsAgenturE.AddNew()
                dsExport.AgenturE.Rows(0)("Agentur") = dsToernverwaltung.Agentur.Rows(0)("Agentur").ToString()
                dsExport.AgenturE.Rows(0)("Strasse") = dsToernverwaltung.Agentur.Rows(0)("Strasse").ToString()
                dsExport.AgenturE.Rows(0)("PLZ") = dsToernverwaltung.Agentur.Rows(0)("PLZ").ToString()
                dsExport.AgenturE.Rows(0)("Ort") = dsToernverwaltung.Agentur.Rows(0)("Ort").ToString()
                dsExport.AgenturE.Rows(0)("Land") = dsToernverwaltung.Agentur.Rows(0)("Land").ToString()
                dsExport.AgenturE.Rows(0)("Tel") = dsToernverwaltung.Agentur.Rows(0)("Tel").ToString()
                dsExport.AgenturE.Rows(0)("Handy") = dsToernverwaltung.Agentur.Rows(0)("Handy").ToString()
                dsExport.AgenturE.Rows(0)("email") = dsToernverwaltung.Agentur.Rows(0)("email").ToString()
                dsExport.AgenturE.Rows(0)("WEB") = dsToernverwaltung.Agentur.Rows(0)("WEB").ToString()
                dsExport.AgenturE.Rows(0)("Ansprechsperson") = dsToernverwaltung.Agentur.Rows(0)("Ansprechspartner").ToString()
                dsExport.AgenturE.Rows(0)("Bemerkung") = dsToernverwaltung.Agentur.Rows(0)("Bemerkung").ToString()
                dsExport.AgenturE.Rows(0)("Fax") = dsToernverwaltung.Agentur.Rows(0)("Fax").ToString()
                dsExport.AgenturE.Rows(0)("R1") = dsToernverwaltung.Agentur.Rows(0)("R1").ToString()
                dsExport.AgenturE.Rows(0)("R2") = dsToernverwaltung.Agentur.Rows(0)("R2").ToString()
                dsExport.AgenturE.Rows(0)("R3") = dsToernverwaltung.Agentur.Rows(0)("R3").ToString()
                taAgenturE.Update(dsExport.AgenturE)
            Else
                '               bsAgenturE.AddNew()
                '               dsExport.AgenturE.Rows(ij)("Agentur") = "Agentur"
                '               taAgenturE.Update(dsExport.AgenturE)
            End If
        End If
    End Sub
    Private Sub BootDir(ByVal bez)
        Dim bootfoto As String
        bootfoto = GetSetting("Boot", "Pfad", "T", " ")
        aaa1 = bez
        aaa1 = aaa1.Replace(" ", "")
        aaa1 = aaa1.Replace("/", "")
        If bootfoto > " " Then
            If My.Computer.FileSystem.FileExists(Trim$((bootfoto + aaa1 + "1.jpg"))) Then
                If My.Computer.FileSystem.DirectoryExists(verz + "\export\boot") Then
                Else
                    My.Computer.FileSystem.CreateDirectory(verz + "\export\boot")
                End If
                IO.File.Copy(bootfoto + aaa1 + "1.jpg", verz + "\export\boot\" + aaa1 + "1.jpg", True)
            End If

            If My.Computer.FileSystem.FileExists(Trim$((bootfoto + aaa1 + "2.jpg"))) Then
                If My.Computer.FileSystem.DirectoryExists(verz + "\export\boot") Then
                Else
                    My.Computer.FileSystem.CreateDirectory(verz + "\export\boot")
                End If
                IO.File.Copy(bootfoto + aaa1 + "2.jpg", verz + "\export\boot\" + aaa1 + "2.jpg", True)
            End If
        End If

    End Sub
    Private Sub ToernDir(ByVal bez)
        Dim logbuch As String
        Dim bericht As String
        Dim karte As String
        logbuch = GetSetting("Logbuch", "Pfad", "T")
        bericht = GetSetting("Bericht", "Pfad", "T")
        karte = GetSetting("karte", "Pfad", "T", " ")
        aaa1 = bez
        aaa1 = aaa1.Replace(" ", "")
        aaa1 = aaa1.Replace("/", "")
        If karte > " " Then
            If My.Computer.FileSystem.FileExists(Trim$((karte + aaa1 + ".jpg"))) Then
                If My.Computer.FileSystem.DirectoryExists(verz + "\export\karte") Then
                Else
                    My.Computer.FileSystem.CreateDirectory(verz + "\export\karte")
                End If
                IO.File.Copy(karte + aaa1 + ".jpg", verz + "\export\karte\" + aaa1 + ".jpg", True)
            End If
        End If

        If logbuch > " " Then
            If My.Computer.FileSystem.FileExists(Trim$((logbuch + aaa1 + ".pdf"))) Then
                If My.Computer.FileSystem.DirectoryExists(verz + "\export\logbuch") Then
                Else
                    My.Computer.FileSystem.CreateDirectory(verz + "\export\logbuch")
                End If
                IO.File.Copy(logbuch + aaa1 + ".pdf", verz + "\export\logbuch\" + aaa1 + ".pdf", True)
            End If
        End If

        If bericht > " " Then
            If My.Computer.FileSystem.FileExists(Trim$((bericht + aaa1 + ".pdf"))) Then
                If My.Computer.FileSystem.DirectoryExists(verz + "\export\bericht") Then
                Else
                    My.Computer.FileSystem.CreateDirectory(verz + "\export\bericht")
                End If
                IO.File.Copy(bericht + aaa1 + ".pdf", verz + "\export\bericht\" + aaa1 + ".pdf", True)
            End If
        End If
    End Sub
    Private Sub crewDir(ByVal bez)
        Dim foto As String
        foto = GetSetting("Foto", "Pfad", "T")
        aaa1 = bez
        aaa1 = aaa1.Replace(" ", "")
        aaa1 = aaa1.Replace("/", "")
        If foto > " " Then
            If My.Computer.FileSystem.FileExists(Trim$((foto + aaa1 + ".jpg"))) Then
                If My.Computer.FileSystem.DirectoryExists(verz + "\export\CrewFoto") Then
                Else
                    My.Computer.FileSystem.CreateDirectory(verz + "\export\CrewFoto")
                End If
                IO.File.Copy(foto + aaa1 + ".jpg", verz + "\export\CrewFoto\" + aaa1 + ".jpg", True)
            End If
        End If
    End Sub
End Class