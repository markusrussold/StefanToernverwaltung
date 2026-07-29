
Imports System.Data.OleDb
Imports System.Data
Class ExpoNeu
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
    Dim verz As String = Environment.CurrentDirectory
    Public it As Integer
    Public iic As Integer
    Public ic As Integer
    Public iip As Integer
    Public ip As Integer
    Dim bootnameL As String
    Private Sub ExpoNeu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ExportDataSet.Bordkassa". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernnameE.Fill(Me.dsExport.ToernnameE)
        Me.taAgenturE.Fill(Me.dsExport.AgenturE)
        Me.taCrewAdressenE.Fill(Me.dsExport.CrewAdressenE)
        Me.taCharterE.Fill(Me.dsExport.CharterE)
        Me.taBootE.Fill(Me.dsExport.BootE)
        Me.taTCE.Fill(Me.dsExport.TCE)
    
        Me.taWacheplan.Fill(Me.dsToernverwaltung.Wacheplan)
        Me.taBordkassa.Fill(Me.dsToernverwaltung.Bordkassa)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taAgentur.Fill(Me.dsToernverwaltung.Agentur)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taCharter.Fill(Me.dsToernverwaltung.Charter)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taCharter.Fill(Me.dsToernverwaltung.Charter)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)

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
        Button1.Enabled = False
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ListBox2.Items.Add(ListBox1.Text)
        Button1.Enabled = True
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        If ListBox2.Items.Count > 1 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        aaa = ListBox2.Text
        ListBox2.Items.Remove(aaa)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Button1.Enabled = False
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

        '-------------------------------------------------------------------------------------------------------------
        Dim wadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim wd As System.Data.DataRowView = bsWacheplanE.Current
        xadapter.SelectCommand = New OleDb.OleDbCommand
        xadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xadapter.SelectCommand.CommandText = "Select * from Wacheplan"
        bsWacheplanE.CancelEdit()
        dsExport.Wacheplan.Clear()
        xadapter.Fill(dsExport.Wacheplan)
        bsWacheplane.AddNew()
        If bsWacheplanE.Count > 0 Then
            iii = bsWacheplanE.Count - 1
            For Me.ij = 0 To iii
                bsWacheplanE.RemoveCurrent()
                taWacheplanE.Update(dsExport)
            Next
        End If

        Dim kadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim kd As System.Data.DataRowView = bsBordkassaE.Current
        xadapter.SelectCommand = New OleDb.OleDbCommand
        xadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xadapter.SelectCommand.CommandText = "Select * from Bordkassa"
        bsBordkassaE.CancelEdit()
        dsExport.Bordkassa.Clear()
        xadapter.Fill(dsExport.Bordkassa)
        bsBordkassaE.AddNew()
        If bsBordkassaE.Count > 0 Then
            iii = bsBordkassaE.Count - 1
            For Me.ij = 0 To iii
                bsBordkassaE.RemoveCurrent()
                taBordkassaE.Update(dsExport)
            Next
        End If

        '-------------------------------------------------------------------------------------------------------
        ' Verbindung zur Logbuch

        loeschendat("DELETE * FROM Bootlog")

        loeschendat("DELETE * FROM Sicherheitseinweisung")

        loeschendat("DELETE * FROM Toerndaten")

        loeschendat("DELETE * FROM Dokumentation")

        loeschendat("DELETE * FROM Logdaten")

        loeschendat("DELETE * FROM Maengel")

        loeschendat("DELETE * FROM Zusammenfassung2")

        loeschendat("DELETE * FROM LogWacheplan")

        '--------------------------------------------------------------------------------------------------------------

        BootDel()
        ToernDel()
        CrewDel()

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
        Me.Cursor = Cursors.Default
        Button1.Enabled = True
    End Sub
    Private Sub loeschendat(ByVal sql)
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb;")
        Dim cmd As New OleDbCommand(sql, conn)

        Try
            conn.Open()
            Dim anzahl As Integer = cmd.ExecuteNonQuery()
            Console.WriteLine("Es wurden " & anzahl & " Datensätze gelöscht.")
        Catch ex As Exception
            Console.WriteLine("Fehler: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub toernexp()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & aaa & "'"
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.Position = 0
        ip = bsToernname.Count
        ip = bsToernnameE.Count
        bsToernnameE.Position = 0
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
        dsExport.ToernnameE.Rows(ij)("NachtZeitvon1") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitvon1").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("NachtfDatumbis1").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("NachtfDatumbis1") = dsToernverwaltung.Toernname.Rows(0)("NachtfDatumbis1").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("NachtZeitbis1") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitbis1").ToString()
        dsExport.ToernnameE.Rows(ij)("NachtFahrtvon2") = dsToernverwaltung.Toernname.Rows(0)("NachtFahrtvon2").ToString()
        dsExport.ToernnameE.Rows(ij)("NachtFahrtbis2") = dsToernverwaltung.Toernname.Rows(0)("NachtFahrtbis2").ToString()
        dsExport.ToernnameE.Rows(ij)("SM2") = dsToernverwaltung.Toernname.Rows(0)("SM2").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("NachtDatumvon2").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("NachtDatumvon2") = dsToernverwaltung.Toernname.Rows(0)("NachtDatumvon2").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("NachtZeitvon2") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitvon2").ToString()
        If IsDate(dsToernverwaltung.Toernname.Rows(0)("NachtDatumbis2").ToString()) Then
            dsExport.ToernnameE.Rows(ij)("NachtDatumbis2") = dsToernverwaltung.Toernname.Rows(0)("NachtDatumbis2").ToString()
        End If
        dsExport.ToernnameE.Rows(ij)("NachtZeitbis2") = dsToernverwaltung.Toernname.Rows(0)("NachtZeitbis2").ToString()
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
        mrina(dsToernverwaltung.Toernname.Rows(0)("AusgangsMarina").ToString())
        mrina(dsToernverwaltung.Toernname.Rows(0)("EndeMarina").ToString())
        ToernDir(aaa)
        crewDir(skipper)
        crewexp(skipper)
        bootexp()
        charterexp()
        TCEExp()
        BootLogExp()
        sicherexp()
        bordkassaexp()
        Wacheplanexp()
        Toerndatenexp()
        DokumentationExp()
        LogDatenExp()
        Maengelexp()
        Zusammenfassung2()
        LogWacheplan()

    End Sub
    Private Sub TCEExp()
        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim tr As System.Data.DataRowView = bsTC.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from tc where toern = '" & aaa & "'"
        dsToernverwaltung.TC.Clear()
        xtAdapter.Fill(dsToernverwaltung.TC)
        bsTC.Position = 0
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
        Dim xadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim xd As System.Data.DataRowView = bsCrewAdressenE.Current
        xadapter.SelectCommand = New OleDb.OleDbCommand
        xadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xadapter.SelectCommand.CommandText = "Select * from crewadressenE where vzname = '" & crewname & "'"
        bsCrewAdressenE.CancelEdit()
        dsExport.CrewAdressenE.Clear()
        xadapter.Fill(dsExport.CrewAdressenE)
        If bsCrewAdressenE.Count = 0 Then

            Dim xcAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim cr As System.Data.DataRowView = bsCrewAdressen.Current
            Dim heute As Date
            xcAdapter.SelectCommand = New OleDb.OleDbCommand
            xcAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            xcAdapter.SelectCommand.CommandText = "Select * from CrewAdressen where vzname = '" & crewname & "'"
            dsToernverwaltung.CrewAdressen.Clear()
            xcAdapter.Fill(dsToernverwaltung.CrewAdressen)
            bsCrewAdressen.Position = 0
            heute = Today
            '       ic = bsCrewAdressenE.Count - 1
            If bsCrewAdressen.Count > 0 Then
                bsCrewAdressenE.AddNew()
                bsCrewAdressenE.AddNew()
                dsExport.CrewAdressenE.Rows(0)("Zuname") = dsToernverwaltung.CrewAdressen.Rows(0)("Zuname").ToString()
                dsExport.CrewAdressenE.Rows(0)("Vorname") = dsToernverwaltung.CrewAdressen.Rows(0)("Vorname").ToString()
                dsExport.CrewAdressenE.Rows(0)("Anrede") = dsToernverwaltung.CrewAdressen.Rows(0)("Anrede").ToString()
                dsExport.CrewAdressenE.Rows(0)("VZname") = dsToernverwaltung.CrewAdressen.Rows(0)("VZname").ToString()
                dsExport.CrewAdressenE.Rows(0)("Handy") = dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString()
                dsExport.CrewAdressenE.Rows(0)("email") = dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString()
                dsExport.CrewAdressenE.Rows(0)("toernnr") = dsToernverwaltung.CrewAdressen.Rows(0)("toernnr").ToString()
                dsExport.CrewAdressenE.Rows(0)("AlterersterToern") = IIf(DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString(), ""), 0, dsToernverwaltung.CrewAdressen.Rows(0)("AlterersterToern").ToString())
                dsExport.CrewAdressenE.Rows(0)("Straße") = dsToernverwaltung.CrewAdressen.Rows(0)("Straße").ToString()
                dsExport.CrewAdressenE.Rows(0)("Plz") = dsToernverwaltung.CrewAdressen.Rows(0)("Plz").ToString()
                dsExport.CrewAdressenE.Rows(0)("Ort") = dsToernverwaltung.CrewAdressen.Rows(0)("Ort").ToString()
                dsExport.CrewAdressenE.Rows(0)("ReisepassNr") = dsToernverwaltung.CrewAdressen.Rows(0)("ReisepassNr").ToString()
                If dsToernverwaltung.CrewAdressen.Rows(0)("GebDatum").ToString() > "" Then
                    dsExport.CrewAdressenE.Rows(0)("GebDatum") = IIf(DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("GebDatum").ToString(), ""), heute, dsToernverwaltung.CrewAdressen.Rows(0)("GebDatum").ToString())
                End If
                dsExport.CrewAdressenE.Rows(0)("GebOrt") = dsToernverwaltung.CrewAdressen.Rows(0)("GebOrt").ToString()
                dsExport.CrewAdressenE.Rows(0)("Funk") = dsToernverwaltung.CrewAdressen.Rows(0)("Funk").ToString()
                dsExport.CrewAdressenE.Rows(0)("Segelschein") = dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString()
                dsExport.CrewAdressenE.Rows(0)("Bemerkung") = dsToernverwaltung.CrewAdressen.Rows(0)("Bemerkung").ToString()
                dsExport.CrewAdressenE.Rows(0)("nationalitaet") = dsToernverwaltung.CrewAdressen.Rows(0)("nationalitaet").ToString()
                dsExport.CrewAdressenE.Rows(0)("Reihenfolge") = IIf(DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("Reihenfolge").ToString(), ""), 0, dsToernverwaltung.CrewAdressen.Rows(0)("Reihenfolge").ToString())
                dsExport.CrewAdressenE.Rows(0)("SegelscheinDatum") = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinDatum").ToString()
                dsExport.CrewAdressenE.Rows(0)("SegelscheinVerband") = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinVerband").ToString()
                dsExport.CrewAdressenE.Rows(0)("Status") = dsToernverwaltung.CrewAdressen.Rows(0)("Status").ToString()
                dsExport.CrewAdressenE.Rows(0)("Clubmitglied") = dsToernverwaltung.CrewAdressen.Rows(0)("Clubmitglied").ToString()
                dsExport.CrewAdressenE.Rows(0)("FB1") = dsToernverwaltung.CrewAdressen.Rows(0)("FB1").ToString()
                dsExport.CrewAdressenE.Rows(0)("FB2") = dsToernverwaltung.CrewAdressen.Rows(0)("FB2").ToString()
                dsExport.CrewAdressenE.Rows(0)("FB3") = dsToernverwaltung.CrewAdressen.Rows(0)("FB3").ToString()
                dsExport.CrewAdressenE.Rows(0)("FB4") = dsToernverwaltung.CrewAdressen.Rows(0)("FB4").ToString()
                dsExport.CrewAdressenE.Rows(0)("A-Schein") = dsToernverwaltung.CrewAdressen.Rows(0)("A-Schein").ToString()
                dsExport.CrewAdressenE.Rows(0)("Motorboot") = dsToernverwaltung.CrewAdressen.Rows(0)("Motorboot").ToString()
                dsExport.CrewAdressenE.Rows(0)("R1") = dsToernverwaltung.CrewAdressen.Rows(0)("R1").ToString()
                dsExport.CrewAdressenE.Rows(0)("R2") = dsToernverwaltung.CrewAdressen.Rows(0)("R2").ToString()
                dsExport.CrewAdressenE.Rows(0)("R3") = dsToernverwaltung.CrewAdressen.Rows(0)("R3").ToString()
                If dsToernverwaltung.CrewAdressen.Rows(0)("Sterbedatum").ToString() > "" Then
                    dsExport.CrewAdressenE.Rows(0)("Sterbedatum") = dsToernverwaltung.CrewAdressen.Rows(0)("Sterbedatum").ToString()
                End If
                taCrewAdressenE.Update(dsExport.CrewAdressenE)
                crewDir(crewname)
                '           Else
                '              bsCrewAdressenE.AddNew()
                '             dsExport.CrewAdressenE.Rows(ic)("Zuname") = crewname + "fehlt"
                '            taCrewAdressenE.Update(dsExport.CrewAdressenE)
            End If
        End If
    End Sub
    Public Sub bootexp()
        Dim xadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim xd As System.Data.DataRowView = bsBootE.Current
        xadapter.SelectCommand = New OleDb.OleDbCommand
        xadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xadapter.SelectCommand.CommandText = "Select * from bootE where bootname = '" & boot & "'"
        bsBootE.CancelEdit()
        dsExport.BootE.Clear()
        xadapter.Fill(dsExport.BootE)
        If bsBootE.Count = 0 Then

            Dim xbAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim br As System.Data.DataRowView = bsBoot.Current
            xbAdapter.SelectCommand = New OleDb.OleDbCommand
            xbAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            xbAdapter.SelectCommand.CommandText = "Select * from boot where bootname = '" & boot & "'"
            dsToernverwaltung.Boot.Clear()
            xbAdapter.Fill(dsToernverwaltung.Boot)
            bsBoot.Position = 0
            bsBootE.Position = 0
            bsBootE.AddNew()
            bsBootE.AddNew()
            dsExport.BootE.Rows(0)("Bootname") = dsToernverwaltung.Boot.Rows(0)("Bootname").ToString()
            bootnameL = dsToernverwaltung.Boot.Rows(0)("Bootname").ToString()
            dsExport.BootE.Rows(0)("Marke") = dsToernverwaltung.Boot.Rows(0)("Marke").ToString()
            dsExport.BootE.Rows(0)("Schiffstyp") = dsToernverwaltung.Boot.Rows(0)("Schiffstyp").ToString()
            dsExport.BootE.Rows(0)("Kielart") = dsToernverwaltung.Boot.Rows(0)("Kielart").ToString()
            dsExport.BootE.Rows(0)("Schiffsnummer") = dsToernverwaltung.Boot.Rows(0)("Schiffsnummer").ToString()
            dsExport.BootE.Rows(0)("Durchfahrtshoehe") = dsToernverwaltung.Boot.Rows(0)("Durchfahrtshoehe").ToString()
            dsExport.BootE.Rows(0)("Länge") = dsToernverwaltung.Boot.Rows(0)("Länge").ToString()
            dsExport.BootE.Rows(0)("Breite") = dsToernverwaltung.Boot.Rows(0)("Breite").ToString()
            dsExport.BootE.Rows(0)("Verdrängung") = dsToernverwaltung.Boot.Rows(0)("Verdrängung").ToString()
            dsExport.BootE.Rows(0)("Tiefgang") = dsToernverwaltung.Boot.Rows(0)("Tiefgang").ToString()
            dsExport.BootE.Rows(0)("Großsegel") = dsToernverwaltung.Boot.Rows(0)("Großsegel").ToString()
            dsExport.BootE.Rows(0)("Vorsegel") = dsToernverwaltung.Boot.Rows(0)("Vorsegel").ToString()
            dsExport.BootE.Rows(0)("Wassertank") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Wassertank").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Wassertank").ToString())
            dsExport.BootE.Rows(0)("Dieseltank") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Dieseltank").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Dieseltank").ToString())
            dsExport.BootE.Rows(0)("Starterbatterie") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Starterbatterie").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Starterbatterie").ToString())
            dsExport.BootE.Rows(0)("Servicebatterie") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Servicebatterie").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Servicebatterie").ToString())
            dsExport.BootE.Rows(0)("Kabinenanzahl") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Kabinenanzahl").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Kabinenanzahl").ToString())
            dsExport.BootE.Rows(0)("Kojenanzahl") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Kojenanzahl").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Kojenanzahl").ToString())
            dsExport.BootE.Rows(0)("Nassraeumeanzahl") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Nassraeumeanzahl").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Nassraeumeanzahl").ToString())
            dsExport.BootE.Rows(0)("Motor") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Motor").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Motor").ToString())
            dsExport.BootE.Rows(0)("Kaution") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Kaution").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Kaution").ToString())
            dsExport.BootE.Rows(0)("Bild") = dsToernverwaltung.Boot.Rows(0)("Bild").ToString()
            dsExport.BootE.Rows(0)("Charterfirma") = dsToernverwaltung.Boot.Rows(0)("Charterfirma").ToString()
            dsExport.BootE.Rows(0)("Bemerkung") = dsToernverwaltung.Boot.Rows(0)("Bemerkung").ToString()
            dsExport.BootE.Rows(0)("MMSI") = dsToernverwaltung.Boot.Rows(0)("MMSI").ToString()
            dsExport.BootE.Rows(0)("Grosssegelart") = dsToernverwaltung.Boot.Rows(0)("Grosssegelart").ToString()
            dsExport.BootE.Rows(0)("Baujahr") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Baujahr").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Baujahr").ToString())
            dsExport.BootE.Rows(0)("Radar") = dsToernverwaltung.Boot.Rows(0)("Radar").ToString()
            dsExport.BootE.Rows(0)("Bugstrahlruder") = dsToernverwaltung.Boot.Rows(0)("Bugstrahlruder").ToString()
            dsExport.BootE.Rows(0)("Marinaort") = dsToernverwaltung.Boot.Rows(0)("Marinaort").ToString()
            dsExport.BootE.Rows(0)("Marina") = dsToernverwaltung.Boot.Rows(0)("Marina").ToString()
            dsExport.BootE.Rows(0)("Ansprechsperson") = dsToernverwaltung.Boot.Rows(0)("Ansprechsperson").ToString()
            dsExport.BootE.Rows(0)("Heizung") = dsToernverwaltung.Boot.Rows(0)("Heizung").ToString()
            dsExport.BootE.Rows(0)("Klimaanlage") = dsToernverwaltung.Boot.Rows(0)("Klimaanlage").ToString()
            dsExport.BootE.Rows(0)("Mobile") = dsToernverwaltung.Boot.Rows(0)("Mobile").ToString()
            dsExport.BootE.Rows(0)("R1") = dsToernverwaltung.Boot.Rows(0)("R1").ToString()
            dsExport.BootE.Rows(0)("R2") = dsToernverwaltung.Boot.Rows(0)("R2").ToString()
            dsExport.BootE.Rows(0)("R3") = dsToernverwaltung.Boot.Rows(0)("R3").ToString()
            dsExport.BootE.Rows(0)("Motoryacht") = dsToernverwaltung.Boot.Rows(0)("Motoryacht").ToString()
            dsExport.BootE.Rows(0)("Segelyacht") = dsToernverwaltung.Boot.Rows(0)("Segelyacht").ToString()
            dsExport.BootE.Rows(0)("VerbrauchLiterproSm") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("VerbrauchLiterproSm").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("VerbrauchLiterproSm").ToString())
            dsExport.BootE.Rows(0)("Reinigung") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Reinigung").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Reinigung").ToString())
            dsExport.BootE.Rows(0)("Bettzeug") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Bettzeug").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Bettzeug").ToString())
            dsExport.BootE.Rows(0)("Aussenborder") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Aussenborder").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Aussenborder").ToString())
            dsExport.BootE.Rows(0)("Gas") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Gas").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Gas").ToString())
            dsExport.BootE.Rows(0)("Spinaker") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Spinaker").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Spinaker").ToString())
            dsExport.BootE.Rows(0)("Permit") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Permit").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Permit").ToString())
            dsExport.BootE.Rows(0)("Marinakosten") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Marinakosten").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Marinakosten").ToString())
            dsExport.BootE.Rows(0)("SonstigeKosten") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("SonstigeKosten").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("SonstigeKosten").ToString())
            dsExport.BootE.Rows(0)("Inverter") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Inverter").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("Inverter").ToString())
            dsExport.BootE.Rows(0)("WiFi") = IIf(DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("WiFi").ToString(), ""), 0, dsToernverwaltung.Boot.Rows(0)("WiFi").ToString())
            taBootE.Update(dsExport.BootE)
            BootDir(dsToernverwaltung.Boot.Rows(0)("Bootname").ToString())
            mrina(dsToernverwaltung.Boot.Rows(0)("Marina").ToString())
            charter = dsToernverwaltung.Boot.Rows(0)("Charterfirma").ToString()
        End If
    End Sub
    Private Sub charterexp()
        Dim xadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim xd As System.Data.DataRowView = bsCharterE.Current
        xadapter.SelectCommand = New OleDb.OleDbCommand
        xadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xadapter.SelectCommand.CommandText = "Select * from charterE where charterfirma = '" & charter & "'"
        bsCharterE.CancelEdit()
        dsExport.CharterE.Clear()
        xadapter.Fill(dsExport.CharterE)
        If bsCharterE.Count = 0 Then

            Dim xcAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim br As System.Data.DataRowView = bsCharter.Current
            xcAdapter.SelectCommand = New OleDb.OleDbCommand
            xcAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            xcAdapter.SelectCommand.CommandText = "Select * from charter where Charterfirma = '" & charter & "'"
            dsToernverwaltung.Charter.Clear()
            xcAdapter.Fill(dsToernverwaltung.Charter)
            If bsCharter.Count > 0 Then
                bsCharter.Position = 0
                bsCharterE.AddNew()
                bsCharterE.AddNew()
                dsExport.CharterE.Rows(0)("Charterfirma") = dsToernverwaltung.Charter.Rows(0)("Charterfirma").ToString()
                dsExport.CharterE.Rows(0)("Straße") = dsToernverwaltung.Charter.Rows(0)("Straße").ToString()
                dsExport.CharterE.Rows(0)("PLZ") = dsToernverwaltung.Charter.Rows(0)("PLZ").ToString()
                dsExport.CharterE.Rows(0)("Ort") = dsToernverwaltung.Charter.Rows(0)("Ort").ToString()
                dsExport.CharterE.Rows(0)("Land") = dsToernverwaltung.Charter.Rows(0)("Land").ToString()
                dsExport.CharterE.Rows(0)("Telefon") = dsToernverwaltung.Charter.Rows(0)("Telefon").ToString()
                dsExport.CharterE.Rows(0)("Handy") = dsToernverwaltung.Charter.Rows(0)("Handy").ToString()
                dsExport.CharterE.Rows(0)("email") = dsToernverwaltung.Charter.Rows(0)("email").ToString()
                dsExport.CharterE.Rows(0)("WEBAuftritt") = dsToernverwaltung.Charter.Rows(0)("WEBAuftritt").ToString()
                dsExport.CharterE.Rows(0)("Ansprechsperson") = dsToernverwaltung.Charter.Rows(0)("Ansprechsperson").ToString()
                dsExport.CharterE.Rows(0)("Marina") = dsToernverwaltung.Charter.Rows(0)("Marina").ToString()
                dsExport.CharterE.Rows(0)("Marinaort") = dsToernverwaltung.Charter.Rows(0)("Marinaort").ToString()
                dsExport.CharterE.Rows(0)("Bemerkung") = dsToernverwaltung.Charter.Rows(0)("Bemerkung").ToString()
                dsExport.CharterE.Rows(0)("Fax") = dsToernverwaltung.Charter.Rows(0)("Fax").ToString()
                dsExport.CharterE.Rows(0)("Agentur") = dsToernverwaltung.Charter.Rows(0)("Agentur").ToString()
                dsExport.CharterE.Rows(0)("R1") = dsToernverwaltung.Charter.Rows(0)("R1").ToString()
                dsExport.CharterE.Rows(0)("R2") = dsToernverwaltung.Charter.Rows(0)("R2").ToString()
                dsExport.CharterE.Rows(0)("R3") = dsToernverwaltung.Charter.Rows(0)("R3").ToString()
                taCharterE.Update(dsExport.CharterE)
                agentura = dsToernverwaltung.Charter.Rows(0)("Agentur").ToString()
                agenturexp()
                '        Else
                '            bsCharterE.AddNew()
                '            dsExport.CharterE.Rows(ij)("Charterfirma") = "Charterfirma"
                '            taCharterE.Update(dsExport.CharterE)
            End If
        End If
    End Sub
    Private Sub agenturexp()
        Dim xaAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim br As System.Data.DataRowView = bsAgentur.Current
        xaAdapter.SelectCommand = New OleDb.OleDbCommand
        xaAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xaAdapter.SelectCommand.CommandText = "Select * from agentur where Agentur = '" & agentura & "'"
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
                bsAgentur.Position = 0
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
                dsExport.AgenturE.Rows(0)("Ansprechspartner") = dsToernverwaltung.Agentur.Rows(0)("Ansprechspartner").ToString()
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
    Private Sub mrina(ByVal mari)
        Dim Marinafoto As String
        Marinafoto = GetSetting("marina", "Pfad", "T", " ")
        aaa1 = Trennen(mari)
        aaa1 = aaa1.Replace(" ", "")
        If Marinafoto > " " Then
            If My.Computer.FileSystem.FileExists(Trim$((Marinafoto + aaa1 + ".jpg"))) Then
                If My.Computer.FileSystem.DirectoryExists(verz + "\export\marina") Then
                Else
                    My.Computer.FileSystem.CreateDirectory(verz + "\export\marina")
                End If
                IO.File.Copy(Marinafoto + aaa1 + ".jpg", verz + "\export\marina\" + aaa1 + ".jpg", True)
            End If
        End If

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
    Private Sub BootDel()
        If My.Computer.FileSystem.DirectoryExists(verz + "\export\boot") Then
            For Each a As String In IO.Directory.GetFiles(verz + "\export\boot\")
                IO.File.Delete(a)
            Next
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
    Private Sub ToernDel()
        If My.Computer.FileSystem.DirectoryExists(verz + "\export\karte") Then
            For Each a As String In IO.Directory.GetFiles(verz + "\export\karte\")
                IO.File.Delete(a)
            Next
        End If
        If My.Computer.FileSystem.DirectoryExists(verz + "\export\logbuch") Then
            For Each a As String In IO.Directory.GetFiles(verz + "\export\logbuch\")
                IO.File.Delete(a)
            Next
        End If
        If My.Computer.FileSystem.DirectoryExists(verz + "\export\bericht") Then
            For Each a As String In IO.Directory.GetFiles(verz + "\export\bericht\")
                IO.File.Delete(a)
            Next
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
    Private Sub CrewDel()
        If My.Computer.FileSystem.DirectoryExists(verz + "\export\crewfoto") Then
            For Each a As String In IO.Directory.GetFiles(verz + "\export\CrewFoto\")
                IO.File.Delete(a)
            Next
        End If
    End Sub
    Private Sub bordkassaexp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Bordkassa WHERE Toern = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Bordkassa (Toern, VZName, Betrag, Verwendung, Datum, Kategorie, Bemerkung, Waehrung, WBetrag) VALUES (@Toern, @VZName, @Betrag, @Verwendung, @Datum, @Kategorie, @Bemerkung, @Waehrung, @WBetrag)"
            '         Dim sqlInsert As String = "INSERT INTO Bordkassa (Toern, VZName, Betrag, Verwendung, Datum, Kategorie, Bemerkung, Waehrung) VALUES (@Toern, @VZName, @Betrag, @Verwendung, @Datum, @Kategorie, @Bemerkung, @Waehrung)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toern", reader("Toern"))
            cmdZiel.Parameters.AddWithValue("@VZName", reader("VZName"))
            cmdZiel.Parameters.AddWithValue("@Betrag", reader("Betrag"))
            cmdZiel.Parameters.AddWithValue("@Verwendung", reader("Verwendung"))
            cmdZiel.Parameters.AddWithValue("@Datum", reader("Datum"))
            cmdZiel.Parameters.AddWithValue("@Kategorie", reader("Kategorie"))
            cmdZiel.Parameters.AddWithValue("@Bemerkung", reader("Bemerkung"))
            cmdZiel.Parameters.AddWithValue("@Waehrung", reader("Waehrung"))
            cmdZiel.Parameters.AddWithValue("@WBetrag", reader("WBetrag"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub
    Private Sub Wacheplanexp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Wacheplan WHERE Toern = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Wacheplan (Toern, Person1, Datum1, Person2, Datum2,synchron,Methode, vzname1,vzname2,vzname3,person3, datum3, reserve1, reserve2, reserve3) VALUES (@Toern, @Person1, @Datum1, @Person2, @Datum2,@synchron,@Methode, @vzname1,@vzname2,@vzname3,@person3, @datum3, @reserve1, @reserve2, @reserve3)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)
            cmdZiel.Parameters.AddWithValue("@Toern", reader("Toern"))
            cmdZiel.Parameters.AddWithValue("@Person1", reader("Person1"))
            cmdZiel.Parameters.AddWithValue("@Datum1", reader("Datum1"))
            cmdZiel.Parameters.AddWithValue("@Person2", reader("Person2"))
            cmdZiel.Parameters.AddWithValue("@Datum2", reader("Datum2"))
            cmdZiel.Parameters.AddWithValue("@Synchron", reader("Synchron"))
            cmdZiel.Parameters.AddWithValue("@Methode", reader("Methode"))
            cmdZiel.Parameters.AddWithValue("@vzname1", reader("VZName1"))
            cmdZiel.Parameters.AddWithValue("@vzname2", reader("vzname2"))
            cmdZiel.Parameters.AddWithValue("@vzname3", reader("vzname3"))
            cmdZiel.Parameters.AddWithValue("@Person3", reader("Person3"))
            cmdZiel.Parameters.AddWithValue("@Datum3", reader("Datum3"))
            cmdZiel.Parameters.AddWithValue("@Reserve1", reader("Reserve1"))
            cmdZiel.Parameters.AddWithValue("@Reserve2", reader("Reserve2"))
            cmdZiel.Parameters.AddWithValue("@Reserve3", reader("Reserve3"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub

    Private Sub BootLogExp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Bootlog WHERE Bootname = '" & bootnameL & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Bootlog (Bootname, Motormarke, Beibootmarke, Beobootleistung, Baustoff, Bootsbild) VALUES (@Bootname, @Motormarke, @Beibootmarke, @Beobootleistung, @Baustoff, @Bootsbild)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Bootname", reader("Bootname"))
            cmdZiel.Parameters.AddWithValue("@Motormarke", reader("Motormarke"))
            cmdZiel.Parameters.AddWithValue("@Beibootmarke", reader("Beibootmarke"))
            cmdZiel.Parameters.AddWithValue("@Beobootleistung", reader("Beobootleistung"))
            cmdZiel.Parameters.AddWithValue("@Baustoff", reader("Baustoff"))
            cmdZiel.Parameters.AddWithValue("@Bootsbild", reader("Bootsbild"))
        
            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()

    End Sub
    Private Sub sicherexp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Sicherheitseinweisung WHERE Toernbezeichnung = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Sicherheitseinweisung (Toernbezeichnung, SiDatum, SiVon, SiBis, Lifebelt, Feuer, Gas, Rettungsinsel, Signalmittel, POB, Gesundheit, Dokumentation, Innen, Pantry, EleAnlagen, Sprechfunk, Motor, Segel, Wasser, Aussen) VALUES (@Toernbezeichnung, @SiDatum, @SiVon, @SiBis, @Lifebelt, @Feuer, @Gas, @Rettungsinsel, @Signalmittel, @POB, @Gesundheit, @Dokumentation, @Innen, @Pantry, @EleAnlagen, @Sprechfunk, @Motor, @Segel, @Wasser, @Aussen)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toernbezeichnung", reader("Toernbezeichnung"))
            cmdZiel.Parameters.AddWithValue("@SiDatum", reader("SiDatum"))
            cmdZiel.Parameters.AddWithValue("@SiVon", reader("SiVon"))
            cmdZiel.Parameters.AddWithValue("@SiBis", reader("SiBis"))
            cmdZiel.Parameters.AddWithValue("@Lifebelt", reader("Lifebelt"))
            cmdZiel.Parameters.AddWithValue("@Feuer", reader("Feuer"))
            cmdZiel.Parameters.AddWithValue("@Gas", reader("Gas"))
            cmdZiel.Parameters.AddWithValue("@Rettungsinsel", reader("Rettungsinsel"))
            cmdZiel.Parameters.AddWithValue("@Signalmittel", reader("Signalmittel"))
            cmdZiel.Parameters.AddWithValue("@POB", reader("POB"))
            cmdZiel.Parameters.AddWithValue("@Gesundheit", reader("Gesundheit"))
            cmdZiel.Parameters.AddWithValue("@Dokumentation", reader("Dokumentation"))
            cmdZiel.Parameters.AddWithValue("@Innen", reader("Innen"))
            cmdZiel.Parameters.AddWithValue("@Pantry", reader("Pantry"))
            cmdZiel.Parameters.AddWithValue("@EleAnlagen", reader("EleAnlagen"))
            cmdZiel.Parameters.AddWithValue("@Sprechfunk", reader("Sprechfunk"))
            cmdZiel.Parameters.AddWithValue("@Motor", reader("Motor"))
            cmdZiel.Parameters.AddWithValue("@Segel", reader("Segel"))
            cmdZiel.Parameters.AddWithValue("@Wasser", reader("Wasser"))
            cmdZiel.Parameters.AddWithValue("@Aussen", reader("Aussen"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()


    End Sub
    Private Sub Toerndatenexp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Toerndaten WHERE Toernbezeichnung = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Toerndaten (Toernbezeichnung, SeemeilenM, SeemeilenS, MotorStd, Nachtfahrten, Nachtansteuerungen, KartenMissweisung, Sonnenaufgang, Sonnenuntergang, Navtexstationen, Vollmond, MaxTidenhub, Sonstiges, R1, R2, R3, GeplanteRoute, KassaManager, Ersteinzahlung, PantryManager, ErstEinkauf, RevierBild, GefahreneRoute) VALUES (@Toernbezeichnung, @SeemeilenM, @SeemeilenS, @MotorStd, @Nachtfahrten, @Nachtansteuerungen, @KartenMissweisung, @Sonnenaufgang, @Sonnenuntergang, @Navtexstationen, @Vollmond, @MaxTidenhub, @Sonstiges, @R1, @R2, @R3, @GeplanteRoute, @KassaManager, @Ersteinzahlung, @PantryManager, @ErstEinkauf, @RevierBild, @GefahreneRoute)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toernbezeichnung", reader("Toernbezeichnung"))
            cmdZiel.Parameters.AddWithValue("@SeemeilenM", reader("SeemeilenM"))
            cmdZiel.Parameters.AddWithValue("@SeemeilenS", reader("SeemeilenS"))
            cmdZiel.Parameters.AddWithValue("@MotorStd", reader("MotorStd"))
            cmdZiel.Parameters.AddWithValue("@Nachtfahrten", reader("Nachtfahrten"))
            cmdZiel.Parameters.AddWithValue("@Nachtansteuerungen", reader("Nachtansteuerungen"))
            cmdZiel.Parameters.AddWithValue("@KartenMissweisung", reader("KartenMissweisung"))
            cmdZiel.Parameters.AddWithValue("@Sonnenaufgang", reader("Sonnenaufgang"))
            cmdZiel.Parameters.AddWithValue("@Sonnenuntergang", reader("Sonnenuntergang"))
            cmdZiel.Parameters.AddWithValue("@Navtexstationen", reader("Navtexstationen"))
            cmdZiel.Parameters.AddWithValue("@Vollmond", reader("Vollmond"))
            cmdZiel.Parameters.AddWithValue("@MaxTidenhub", reader("MaxTidenhub"))
            cmdZiel.Parameters.AddWithValue("@Sonstiges", reader("Sonstiges"))
            cmdZiel.Parameters.AddWithValue("@R1", reader("R1"))
            cmdZiel.Parameters.AddWithValue("@R2", reader("R2"))
            cmdZiel.Parameters.AddWithValue("@R3", reader("R3"))
            cmdZiel.Parameters.AddWithValue("@GeplanteRoute", reader("GeplanteRoute"))
            cmdZiel.Parameters.AddWithValue("@KassaManager", reader("KassaManager"))
            cmdZiel.Parameters.AddWithValue("@Ersteinzahlung", reader("Ersteinzahlung"))
            cmdZiel.Parameters.AddWithValue("@PantryManager", reader("PantryManager"))
            cmdZiel.Parameters.AddWithValue("@ErstEinkauf", reader("ErstEinkauf"))
            cmdZiel.Parameters.AddWithValue("@RevierBild", reader("RevierBild"))
            cmdZiel.Parameters.AddWithValue("@GefahreneRoute", reader("GefahreneRoute"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()

    End Sub
    Private Sub DokumentationExp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Dokumentation WHERE Toernbezeichnung = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Dokumentation (Toernbezeichnung, Datum, Wetterbericht1,  Wetterbericht2,  Wetterbericht3, Uhrzeit, Bemerkungen, Besonderes, ZielAnlegeart, ZielGebühr, ZielMüll, ZielStrom, MotorStdAnfang, MotorStdEnde, Kraftstoffgetankt, KraffstoffKosten, CheckBilge, WasserTanken, CheckOel, CheckBatterie, AusgangsOrt, ZielOrt) VALUES (@Toernbezeichnung, @Datum, @Wetterbericht1,  @Wetterbericht2,  @Wetterbericht3, @Uhrzeit, @Bemerkungen, @Besonderes, @ZielAnlegeart, @ZielGebühr, @ZielMüll, @ZielStrom, @MotorStdAnfang, @MotorStdEnde, @Kraftstoffgetankt, @KraffstoffKosten, @CheckBilge, @WasserTanken, @CheckOel, @CheckBatterie, @AusgangsOrt, @ZielOrt)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toernbezeichnung", reader("Toernbezeichnung"))
            cmdZiel.Parameters.AddWithValue("@Datum", reader("Datum"))
            cmdZiel.Parameters.AddWithValue("@Wetterbericht1", reader("Wetterbericht1"))
            cmdZiel.Parameters.AddWithValue("@Wetterbericht2", reader("Wetterbericht2"))
            cmdZiel.Parameters.AddWithValue("@Wetterbericht3", reader("Wetterbericht3"))
            cmdZiel.Parameters.AddWithValue("@Uhrzeit", reader("Uhrzeit"))
            cmdZiel.Parameters.AddWithValue("@Bemerkungen", reader("Bemerkungen"))
            cmdZiel.Parameters.AddWithValue("@Besonderes", reader("Besonderes"))
            cmdZiel.Parameters.AddWithValue("@ZielAnlegeart", reader("ZielAnlegeart"))
            cmdZiel.Parameters.AddWithValue("@ZielGebühr", reader("ZielGebühr"))
            cmdZiel.Parameters.AddWithValue("@ZielMüll", reader("ZielMüll"))
            cmdZiel.Parameters.AddWithValue("@ZielStrom", reader("ZielStrom"))
            cmdZiel.Parameters.AddWithValue("@MotorStdAnfang", reader("MotorStdAnfang"))
            cmdZiel.Parameters.AddWithValue("@MotorStdEnde", reader("MotorStdEnde"))
            cmdZiel.Parameters.AddWithValue("@Kraftstoffgetankt", reader("Kraftstoffgetankt"))
            cmdZiel.Parameters.AddWithValue("@KraffstoffKosten", reader("KraffstoffKosten"))
            cmdZiel.Parameters.AddWithValue("@CheckBilge", reader("CheckBilge"))
            cmdZiel.Parameters.AddWithValue("@WasserTanken", reader("WasserTanken"))
            cmdZiel.Parameters.AddWithValue("@CheckOel", reader("CheckOel"))
            cmdZiel.Parameters.AddWithValue("@CheckBatterie", reader("CheckBatterie"))
            cmdZiel.Parameters.AddWithValue("@AusgangsOrt", reader("AusgangsOrt"))
            cmdZiel.Parameters.AddWithValue("@ZielOrt", reader("ZielOrt"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()

    End Sub
    Private Sub LogDatenExp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM LogDaten WHERE Toerbezeichnung = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            '          Dim sqlInsert As String = "INSERT INTO Logdaten (Toerbezeichnung, Datum, Uhrzeit, WindRichtung, Windstaerke, Seegang, Luftdruck, Wolken, KueG, Position, Antriebsart, DueGTag, DueGSegel, DueGMotor) VALUES (@Toerbezeichnung, @Datum, @Uhrzeit, @Windrichtung, @Windstaerke, @Seegang, @Luftdruck, @Wolken, @KueG, @Position, @Antriebsart, @DueGTag, @DueGSegel, @DueGMotor)"
            Dim sqlInsert As String = "INSERT INTO Logdaten (Toerbezeichnung, Datum, Uhrzeit, WindRichtung, Windstaerke, Seegang, Luftdruck, Wolken, KueG, ort, Antriebsart, DueGTag, DueGSegel, DueGMotor) VALUES (@Toerbezeichnung, @Datum, @Uhrzeit, @Windrichtung, @Windstaerke, @Seegang, @Luftdruck, @Wolken, @KueG, @ort, @Antriebsart, @DueGTag, @DueGSegel, @DueGMotor)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toerbezeichnung", reader("Toerbezeichnung"))
            cmdZiel.Parameters.AddWithValue("@Datum", reader("Datum"))
            cmdZiel.Parameters.AddWithValue("@Uhrzeit", reader("Uhrzeit"))
            cmdZiel.Parameters.AddWithValue("@WindRichtung", reader("WindRichtung"))
            cmdZiel.Parameters.AddWithValue("@Windstaerke", reader("Windstaerke"))
            cmdZiel.Parameters.AddWithValue("@Seegang", reader("Seegang"))
            cmdZiel.Parameters.AddWithValue("@Luftdruck", reader("Luftdruck"))
            cmdZiel.Parameters.AddWithValue("@Wolken", reader("Wolken"))
            cmdZiel.Parameters.AddWithValue("@KueG", reader("KueG"))
            cmdZiel.Parameters.AddWithValue("@ort", reader("ort"))
            cmdZiel.Parameters.AddWithValue("@Antriebsart", reader("Antriebsart"))
            cmdZiel.Parameters.AddWithValue("@DueGTag", reader("DueGTag"))
            cmdZiel.Parameters.AddWithValue("@DueGSegel", reader("DueGSegel"))
            cmdZiel.Parameters.AddWithValue("@DueGMotor", reader("DueGMotor"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()

    End Sub
    Private Sub Maengelexp()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Maengel WHERE Toernbezeichnung = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            '          Dim sqlInsert As String = "INSERT INTO Logdaten (Toerbezeichnung, Datum, Uhrzeit, WindRichtung, Windstaerke, Seegang, Luftdruck, Wolken, KueG, Position, Antriebsart, DueGTag, DueGSegel, DueGMotor) VALUES (@Toerbezeichnung, @Datum, @Uhrzeit, @Windrichtung, @Windstaerke, @Seegang, @Luftdruck, @Wolken, @KueG, @Position, @Antriebsart, @DueGTag, @DueGSegel, @DueGMotor)"
            Dim sqlInsert As String = "INSERT INTO Maengel (Toernbezeichnung, Datum, Betrifft, Defekt, Auswirkung) VALUES (@Toernbezeichnung, @Datum, @UBetrifft, @Defekt, @Auswirkung)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toernbezeichnung", reader("Toernbezeichnung"))
            cmdZiel.Parameters.AddWithValue("@Datum", reader("Datum"))
            cmdZiel.Parameters.AddWithValue("@Betrifft", reader("Betrifft"))
            cmdZiel.Parameters.AddWithValue("@Defekt", reader("Defekt"))
            cmdZiel.Parameters.AddWithValue("@Auswirkung", reader("Auswirkung"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub
    Private Sub Zusammenfassung2()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Zusammenfassung2 WHERE Toernbezeichnung = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Zusammenfassung2 (Toernbezeichnung, DatumVon, ZeitVon, Ausfahrt, DatumBis, ZeitBis, Ziel, Windrichtung, SmuSegel, SmuMotor,SMGesamt, Bemerkung, R1, R2, R3, Windstaerke) VALUES (@Toernbezeichnung, @DatumVon, @ZeitVon, @Ausfahrt, @DatumBis, @ZeitBis, @Ziel, @Windrichtung, @SmuSegel, @SmuMotor,@SMGesamt, @Bemerkung, @R1, @R2, @R3, @Windstaerke)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toernbezeichnung", reader("Toernbezeichnung"))
            cmdZiel.Parameters.AddWithValue("@DatumVon", reader("DatumVon"))
            cmdZiel.Parameters.AddWithValue("@ZeitVon", reader("ZeitVon"))
            cmdZiel.Parameters.AddWithValue("@Ausfahrt", reader("Ausfahrt"))
            cmdZiel.Parameters.AddWithValue("@DatumBis", reader("DatumBis"))
            cmdZiel.Parameters.AddWithValue("@ZeitBis", reader("ZeitBis"))
            cmdZiel.Parameters.AddWithValue("@Ziel", reader("Ziel"))
            cmdZiel.Parameters.AddWithValue("@Windrichtung", reader("Windrichtung"))
            cmdZiel.Parameters.AddWithValue("@SmuSegel", reader("SmuSegel"))
            cmdZiel.Parameters.AddWithValue("@SMGesamt", reader("SMGesamt"))
            cmdZiel.Parameters.AddWithValue("@Bemerkung", reader("Bemerkung"))
            cmdZiel.Parameters.AddWithValue("@R1", reader("R1"))
            cmdZiel.Parameters.AddWithValue("@R2", reader("R2"))
            cmdZiel.Parameters.AddWithValue("@R3", reader("R3"))
            cmdZiel.Parameters.AddWithValue("@Windstaerke", reader("Windstaerke"))
            cmdZiel.Parameters.AddWithValue("@SmuMotor", reader("SmuMotor"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()

    End Sub
    Private Sub LogWacheplan()
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM LogWacheplan WHERE Toern = '" & aaa & "' "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            '          Dim sqlInsert As String = "INSERT INTO LogWacheplan (Toern, Person1, Person2, Person3, Synchron, Methode, Datum, TextVon, TextBis, VZName1, VZName2, VZName3) VALUES (@Toern, @Person1, @Person2, @Person3, @Synchron, @Methode, @Datum, @TextVon, @TextBis, @VZName1, @VZName2, @VZName3)"
            Dim sqlInsert As String = "INSERT INTO LogWacheplan (Toern, Person1, Person2, Person3, Synchron, Methode, Datum, TextVon, TextBis, VZName1, VZName2, VZName3) VALUES (@Toern, @Person1, @Person2, @Person3, @Synchron, @Methode, @Datum, @TextVon, @TextBis, @VZName1, @VZName2, @VZName3)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)

            cmdZiel.Parameters.AddWithValue("@Toern", reader("Toern"))
            cmdZiel.Parameters.AddWithValue("@Person1", reader("Person1"))
            cmdZiel.Parameters.AddWithValue("@Person2", reader("Person2"))
            cmdZiel.Parameters.AddWithValue("@Person3", reader("Person3"))
            cmdZiel.Parameters.AddWithValue("@Synchron", reader("Synchron"))
            cmdZiel.Parameters.AddWithValue("@Methode", reader("Methode"))
            cmdZiel.Parameters.AddWithValue("@Datum", reader("Datum"))
            cmdZiel.Parameters.AddWithValue("@TextVon", reader("TextVon"))
            cmdZiel.Parameters.AddWithValue("@TextBis", reader("TextBis"))
            cmdZiel.Parameters.AddWithValue("@VZName1", reader("VZName1"))
            cmdZiel.Parameters.AddWithValue("@VZName2", reader("VZName2"))
            cmdZiel.Parameters.AddWithValue("@VZName3", reader("VZName3"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub
End Class