Imports System.Data.OleDb
Imports System.Data
Public Class ImportNeu
    Dim aaa As String
    Dim iii As Integer
    Dim ij As Integer

    Private Sub ImportNeu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsExport.CharterE". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taCharterE.Fill(Me.dsExport.CharterE)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsExport.AgenturE". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taAgenturE.Fill(Me.dsExport.AgenturE)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ExportDataSet.ToernnameE". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernnameE.Fill(Me.dsExport.ToernnameE)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)

        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernnamee order by toernbezeichnung"
        bsToernnameE.CancelEdit()
        dsExport.ToernnameE.Clear()
        xAdapter.Fill(dsExport.ToernnameE)
        Label4.Text = "                                                                            "
        Label1.Text = "              "
        Me.Label4.Refresh()

        If bsToernnameE.Count > 0 Then
            iii = bsToernnameE.Count - 1
            For Me.ij = 0 To iii
                ListBox1.Items.Add(dsExport.ToernnameE.Rows(ij)("Toernbezeichnung").ToString)
            Next
        End If
    End Sub
    Private Sub ImportStart_Click(sender As System.Object, e As System.EventArgs) Handles ImportStart.Click
        Label1.Text = "Der Törn wird importiert.                                                           "
        Me.Label1.Refresh()

        iii = ListBox2.Items.Count - 1
        ListBox2.TopIndex = 1
          For Me.ij = 0 To iii
            ListBox2.SelectedIndex = ij
            aaa = ListBox2.Text
            ToernameImport()
            TCEImport()
            BootImport()
            Charterimport()
            AgenturImport()
            Wacheplanimport()
            bordkassaimport()

            BootLogimport()
            sicherimport()
            Toerndatenimport()
            DokumentationImport()
            LogDatenimport()
            Maengelimport()
            Zusammenfassung2Import()
            LogWacheplanimport()
        Next
        Label4.Text = "Fertig                                                                  "
        Me.Label4.Refresh()
        Me.Cursor = Cursors.Default
        ImportStart.Enabled = False
    End Sub
    Private Sub ToernameImport()
        loeschenVerw("DELETE * FROM Toernname where Toernbezeichnung = ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM ToernnameE WHERE Toernbezeichnung = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO toernname (DatumVon, DatumBis, Ausgangsmarina, EndeMarina, Toernbezeichnung, smSegel, smMotor, smGesamt, Nachtfahrten, Nachtansteuerungen, Bordtage, ausserhalbFB2,ausserhalbFB3, Tornbericht, Bootsname, Skipper, letzterSegeltag, Bemerkung, Bordkassa, Route, Logbuch, R1, R2, R3, Nachtfahrtvon1, Nachtfahrtbis1, NachtfDatumbis1, NachtZeitbis1, Nachtfahrtvon2, Nachtfahrtbis2, sm1, sm2, NachtfDatumVon1, NachtZeitvon1, NachtDatumvon2, NachtZeitvon2, NachtDatumbis2, nachtzeitbis2, Std50Ziel, Std50Start,Std50DatumStart, Std50ZeitSTart, Std50DatumZiel, Std50ZeitZiel, Std50smGes, Std50smFB2, GezDatum1, GezZeit1, GezHafen1, GezHafen2, GezDatum2, GezZeit2, FB4Start,FB4Ziel, FB4SmGes, fb4smFB3, FB4DatumSTart, FB4ZeitStart, FB4DatumZiel, FB4ZeitZiel, Revier) VALUES (@DatumVon, @DatumBis, @Ausgangsmarina, @EndeMarina, @Toernbezeichnung, @smSegel, @smMotor, @smGesamt, @Nachtfahrten, @Nachtansteuerungen, @Bordtage, @ausserhalbFB2, @ausserhalbFB3, @Tornbericht, @Bootsname, @Skipper, @letzterSegeltag, @Bemerkung, @Bordkassa, @Route, @Logbuch, @R1, @R2, @R3, @Nachtfahrtvon1, @Nachtfahrtbis1, @NachtfDatumbis1, @NachtZeitbis1, @Nachtfahrtvon2, @Nachtfahrtbis2, @sm1, @sm2, @NachtfDatumVon1, @NachtZeitvon1, @NachtDatumvon2, @NachtZeitvon2, @NachtDatumbis2, @nachtzeitbis2, @Std50Ziel, @Std50Start, @Std50DatumStart, @Std50ZeitSTart, @Std50DatumZiel, @Std50ZeitZiel, @Std50smGes, @Std50smFB2, @GetDatum1, @GezZeit1, @GezHafen1, @GezHafen2, @GezDatum2, @GezZeit2, @FB4Start, @FB4Ziel, @FB4SmGes, @fb4smFB3, @FB4DatumSTart, @FB4ZeitStart, @FB4DatumZiel, @FB4ZeitZiel, @Revier)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)
            cmdZiel.Parameters.AddWithValue("@DatumVon", reader("DatumVon"))
            cmdZiel.Parameters.AddWithValue("@DatumBis", reader("DatumBis"))
            cmdZiel.Parameters.AddWithValue("@Ausgangsmarina", reader("Ausgangsmarina"))
            cmdZiel.Parameters.AddWithValue("@EndeMarina", reader("EndeMarina"))
            cmdZiel.Parameters.AddWithValue("@Toernbezeichnung", reader("Toernbezeichnung"))
            cmdZiel.Parameters.AddWithValue("@smSegel", reader("smSegel"))
            cmdZiel.Parameters.AddWithValue("@smMotor", reader("smMotor"))
            cmdZiel.Parameters.AddWithValue("@smGesamt", reader("smGesamt"))
            cmdZiel.Parameters.AddWithValue("@Nachtfahrten", reader("Nachtfahrten"))
            cmdZiel.Parameters.AddWithValue("@Nachtansteuerungen", reader("Nachtansteuerungen"))
            cmdZiel.Parameters.AddWithValue("@Bordtage", reader("Bordtage"))
            cmdZiel.Parameters.AddWithValue("@ausserhalbFB2", reader("ausserhalbFB2"))
            cmdZiel.Parameters.AddWithValue("@ausserhalbFB3", reader("ausserhalbFB3"))
            cmdZiel.Parameters.AddWithValue("@Tornbericht", reader("Tornbericht"))
            cmdZiel.Parameters.AddWithValue("@Bootsname", reader("Bootsname"))
            cmdZiel.Parameters.AddWithValue("@Skipper", reader("Skipper"))
            cmdZiel.Parameters.AddWithValue("@letzterSegeltag", reader("letzterSegeltag"))
            cmdZiel.Parameters.AddWithValue("@Bemerkung", reader("Bemerkung"))
            cmdZiel.Parameters.AddWithValue("@Bordkassa", reader("Bordkassa"))
            cmdZiel.Parameters.AddWithValue("@Route", reader("Route"))
            cmdZiel.Parameters.AddWithValue("@Logbuch", reader("Logbuch"))
            cmdZiel.Parameters.AddWithValue("@R1", reader("R1"))
            cmdZiel.Parameters.AddWithValue("@R2", reader("R2"))
            cmdZiel.Parameters.AddWithValue("@R3", reader("R3"))
            cmdZiel.Parameters.AddWithValue("@Nachtfahrtvon1", reader("Nachtfahrtvon1"))
            cmdZiel.Parameters.AddWithValue("@Nachtfahrtbis1", reader("Nachtfahrtbis1"))
            cmdZiel.Parameters.AddWithValue("@NachtfDatumbis1", reader("NachtfDatumbis1"))
            cmdZiel.Parameters.AddWithValue("@NachtZeitbis1", reader("NachtZeitbis1"))
            cmdZiel.Parameters.AddWithValue("@Nachtfahrtvon2", reader("Nachtfahrtvon2"))
            cmdZiel.Parameters.AddWithValue("@Nachtfahrtbis2", reader("Nachtfahrtbis2"))
            cmdZiel.Parameters.AddWithValue("@sm1", reader("sm1"))
            cmdZiel.Parameters.AddWithValue("@sm2", reader("sm2"))
            cmdZiel.Parameters.AddWithValue("@NachtfDatumVon1", reader("NachtfDatumVon1"))
            cmdZiel.Parameters.AddWithValue("@NachtZeitvon1", reader("NachtZeitvon1"))
            cmdZiel.Parameters.AddWithValue("@NachtDatumvon2", reader("NachtDatumvon2"))
            cmdZiel.Parameters.AddWithValue("@NachtZeitvon2", reader("NachtZeitvon2"))
            cmdZiel.Parameters.AddWithValue("@NachtDatumbis2", reader("NachtDatumbis2"))
            cmdZiel.Parameters.AddWithValue("@nachtzeitbis2", reader("nachtzeitbis2"))
            cmdZiel.Parameters.AddWithValue("@Std50Ziel", reader("Std50Ziel"))
            cmdZiel.Parameters.AddWithValue("@Std50Start", reader("Std50Start"))
            cmdZiel.Parameters.AddWithValue("@Std50DatumStart", reader("Std50DatumStart"))
            cmdZiel.Parameters.AddWithValue("@Std50ZeitSTart", reader("Std50ZeitSTart"))
            cmdZiel.Parameters.AddWithValue("@Std50DatumZiel", reader("Std50DatumZiel"))
            cmdZiel.Parameters.AddWithValue("@Std50ZeitZiel", reader("Std50ZeitZiel"))
            cmdZiel.Parameters.AddWithValue("@Std50smGes", reader("Std50smGes"))
            cmdZiel.Parameters.AddWithValue("@Std50smFB2", reader("Std50smFB2"))
            cmdZiel.Parameters.AddWithValue("@GezDatum1", reader("GezDatum1"))
            cmdZiel.Parameters.AddWithValue("@GezZeit1", reader("GezZeit1"))
            cmdZiel.Parameters.AddWithValue("@GezHafen1", reader("GezHafen1"))
            cmdZiel.Parameters.AddWithValue("@GezHafen2", reader("GezHafen2"))
            cmdZiel.Parameters.AddWithValue("@GezDatum2", reader("GezDatum2"))
            cmdZiel.Parameters.AddWithValue("@GezZeit2", reader("GezZeit2"))
            cmdZiel.Parameters.AddWithValue("@FB4Start", reader("FB4Start"))
            cmdZiel.Parameters.AddWithValue("@FB4Ziel", reader("FB4Ziel"))
            cmdZiel.Parameters.AddWithValue("@FB4SmGes", reader("FB4SmGes"))
            cmdZiel.Parameters.AddWithValue("@fb4smFB3", reader("fb4smFB3"))
            cmdZiel.Parameters.AddWithValue("@FB4DatumSTart", reader("FB4DatumSTart"))
            cmdZiel.Parameters.AddWithValue("@FB4ZeitStart", reader("FB4ZeitStart"))
            cmdZiel.Parameters.AddWithValue("@FB4DatumZiel", reader("FB4DatumZiel"))
            cmdZiel.Parameters.AddWithValue("@FB4ZeitZiel", reader("FB4ZeitZiel"))
            cmdZiel.Parameters.AddWithValue("@Revier", reader("Revier"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub
    Private Sub TCEImport()
        loeschenVerw("DELETE * FROM TC where Toern = ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM TCE WHERE Toern = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO TC (Toern, VZName, smNachweis, Wachfuehrer, Navigator, Rudergaenger, R1, R2, R3, NachtaHafen1, NachtaDatum1, NachtaZeit1, NachtaHafen2, NachtaDatum2, NachtaZeit2, NachtaHafen3, NachtaDatum3, NachtaZeit3) VALUES (@Toern, @VZName, @smNachweis, @Wachfuehrer, @Navigator, @Rudergaenger, @R1, @R2, @R3, @NachtaHafen1, @NachtaDatum1, @NachtaZeit1, @NachtaHafen2, @NachtaDatum2, @NachtaZeit2, @NachtaHafen3, @NachtaDatum3, @NachtaZeit3)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)
            cmdZiel.Parameters.AddWithValue("@Toern", reader("Toern"))
            cmdZiel.Parameters.AddWithValue("@VZName", reader("VZName"))
            cmdZiel.Parameters.AddWithValue("@smNachweis", reader("smNachweis"))
            cmdZiel.Parameters.AddWithValue("@Wachfuehrer", reader("Wachfuehrer"))
            cmdZiel.Parameters.AddWithValue("@Navigator", reader("Navigator"))
            cmdZiel.Parameters.AddWithValue("@Rudergaenger", reader("Rudergaenger"))
            cmdZiel.Parameters.AddWithValue("@R1", reader("R1"))
            cmdZiel.Parameters.AddWithValue("@R2", reader("R2"))
            cmdZiel.Parameters.AddWithValue("@R3", reader("R3"))
            cmdZiel.Parameters.AddWithValue("@NachtaHafen1", reader("NachtaHafen1"))
            cmdZiel.Parameters.AddWithValue("@NachtaDatum1", reader("NachtaDatum1"))
            cmdZiel.Parameters.AddWithValue("@NachtaZeit1", reader("NachtaZeit1"))
            cmdZiel.Parameters.AddWithValue("@NachtaHafen2", reader("NachtaHafen2"))
            cmdZiel.Parameters.AddWithValue("@NachtaDatum2", reader("NachtaDatum2"))
            cmdZiel.Parameters.AddWithValue("@NachtaZeit2", reader("NachtaZeit2"))
            cmdZiel.Parameters.AddWithValue("@NachtaHafen3", reader("NachtaHafen3"))
            cmdZiel.Parameters.AddWithValue("@NachtaDatum3", reader("NachtaDatum3"))
            cmdZiel.Parameters.AddWithValue("@NachtaZeit3", reader("NachtaZeit3"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub
    Private Sub BootImport()
        loeschenVerw("DELETE * FROM Boot where Bootname = ?", TextBox4.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM BootE WHERE Bootname = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox4.Text)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Boot (Bootname, Marke,Schiffstyp, Kielart, Schiffsnummer, Durchfahrtshoehe, Länge, Breite, Verdrängung, Tiefgang, Großsegel, Vorsegel, Wassertank, Dieseltank, Starterbatterie, ServiceBatterie, Kabinenanzahl, Kojenanzahl, Nassraeumeanzahl, Motor, Kaution, Bild, Charterfirma, Bemerkung, MMSI, Grosssegelart, Baujahr, Marinaort, Marina, Ansprechsperson, Mobile, Radar, Bugstrahlruder, Clubnachlas, Heizung, Klimaanlage, R1, R2, R3, Motoryacht, Segelyacht, Aussenborder, Gas, Spinaker, Permit, Marinakosten, SonstigeKosten, Inverter, WiFi) VALUES (@Bootname, @Marke, @Schiffstyp, @Kielart, @Schiffsnummer, @Durchfahrtshoehe, @Länge, @Breite, @Verdrängung, @Tiefgang, @Großsegel, @Vorsegel, @Wassertank, @Dieseltank, @Starterbatterie, @ServiceBatteria, @Kabinenanzahl, @Kojenanzahl, @Nassraeumeanzahl, @Motor, @Kaution, @Bild, @Charterfirma, @Bemerkung, @MMSI, @Grosssegelart, @Baujahr, @Marinaort, @Marina, @Ansprechsperson, @Mobile, @Radar, @Bugstrahlruder, @Clubnachlas, @Heizung, @Klimaanlage, @R1, @R2, @R3, @Motoryacht, @Segelyacht, @Aussenborder, @Gas, @Spinaker, @Permit, @Marinakosten, @SonstigeKosten, @Inverter, @WiFi)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)
            cmdZiel.Parameters.AddWithValue("@Bootname", reader("Bootname"))
            cmdZiel.Parameters.AddWithValue("@Marke", reader("Marke"))
            cmdZiel.Parameters.AddWithValue("@Schiffstyp", reader("Schiffstyp"))
            cmdZiel.Parameters.AddWithValue("@Kielart", reader("Kielart"))
            cmdZiel.Parameters.AddWithValue("@Schiffsnummer", reader("Schiffsnummer"))
            cmdZiel.Parameters.AddWithValue("@Durchfahrtshoehe", reader("Durchfahrtshoehe"))
            cmdZiel.Parameters.AddWithValue("@Länge", reader("Länge"))
            cmdZiel.Parameters.AddWithValue("@Breite", reader("Breite"))
            cmdZiel.Parameters.AddWithValue("@Verdrängung", reader("Verdrängung"))
            cmdZiel.Parameters.AddWithValue("@Tiefgang", reader("Tiefgang"))
            cmdZiel.Parameters.AddWithValue("@Großsegel", reader("Großsegel"))
            cmdZiel.Parameters.AddWithValue("@Vorsegel", reader("Vorsegel"))
            cmdZiel.Parameters.AddWithValue("@Wassertank", reader("Wassertank"))
            cmdZiel.Parameters.AddWithValue("@Dieseltank", reader("Dieseltank"))
            cmdZiel.Parameters.AddWithValue("@Starterbatterier", reader("Starterbatterie"))
            cmdZiel.Parameters.AddWithValue("@ServiceBatterie", reader("ServiceBatterie"))
            cmdZiel.Parameters.AddWithValue("@Kabinenanzahl", reader("Kabinenanzahl"))
            cmdZiel.Parameters.AddWithValue("@Kojenanzahlr", reader("Kojenanzahl"))
            cmdZiel.Parameters.AddWithValue("@Nassraeumeanzahl", reader("Nassraeumeanzahl"))
            cmdZiel.Parameters.AddWithValue("@Motor", reader("Motor"))
            cmdZiel.Parameters.AddWithValue("@Kaution", reader("Kaution"))
            cmdZiel.Parameters.AddWithValue("@Bild", reader("Bild"))
            cmdZiel.Parameters.AddWithValue("@Charterfirma", reader("Charterfirma"))
            cmdZiel.Parameters.AddWithValue("@Bemerkung", reader("Bemerkung"))
            cmdZiel.Parameters.AddWithValue("@MMSI", reader("MMSI"))
            cmdZiel.Parameters.AddWithValue("@Grosssegelart", reader("Grosssegelart"))
            cmdZiel.Parameters.AddWithValue("@Baujahr", reader("Baujahr"))
            cmdZiel.Parameters.AddWithValue("@Marinaort", reader("Marinaort"))
            cmdZiel.Parameters.AddWithValue("@Marina", reader("Marina"))
            cmdZiel.Parameters.AddWithValue("@Ansprechsperson", reader("Ansprechsperson"))
            cmdZiel.Parameters.AddWithValue("@Mobile", reader("Mobile"))
            cmdZiel.Parameters.AddWithValue("@Radar", reader("Radar"))
            cmdZiel.Parameters.AddWithValue("@Bugstrahlruder", reader("Bugstrahlruder"))
            cmdZiel.Parameters.AddWithValue("@Clubnachlas", reader("Clubnachlas"))
            cmdZiel.Parameters.AddWithValue("@Heizung", reader("Heizung"))
            cmdZiel.Parameters.AddWithValue("@Klimaanlage", reader("Klimaanlage"))
            cmdZiel.Parameters.AddWithValue("@R1", reader("R1"))
            cmdZiel.Parameters.AddWithValue("@R2", reader("R2"))
            cmdZiel.Parameters.AddWithValue("@R3", reader("R3"))
            cmdZiel.Parameters.AddWithValue("@Motoryacht", reader("Motoryacht"))
            cmdZiel.Parameters.AddWithValue("@Segelyacht", reader("Segelyacht"))
            cmdZiel.Parameters.AddWithValue("@Aussenborder", reader("Aussenborder"))
            cmdZiel.Parameters.AddWithValue("@Gas", reader("Gas"))
            cmdZiel.Parameters.AddWithValue("@Spinaker", reader("Spinaker"))
            cmdZiel.Parameters.AddWithValue("@Permit", reader("Permit"))
            cmdZiel.Parameters.AddWithValue("@Marinakosten", reader("Marinakosten"))
            cmdZiel.Parameters.AddWithValue("@SonstigeKosten", reader("SonstigeKosten"))
            cmdZiel.Parameters.AddWithValue("@Inverter", reader("Inverter"))
            cmdZiel.Parameters.AddWithValue("@WiFi", reader("WiFi"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()

    End Sub
    Private Sub Charterimport()
        loeschenVerw("DELETE * FROM Charter where Charterfirma = ?", TextBox6.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM CharterE WHERE Charterfirma = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox6.Text)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Charter (Charterfirma, Straße, Plz, Ort, Land, Telefon, Handy, email, WEBAuftritt, Ansprechsperson, Marina, Marinaort, Bemerkung, Fax, Agentur, R1, R2, R3) VALUES (@Charterfirma, @Straße, @Plz, @Ort, @Land, @Telefon, @Handy, @email, @WEBAuftritt, @Ansprechsperson, @Marina, @Marinaort, @Bemerkung, @Fax, @Agentur, @R1, @R2, @R3)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)
            cmdZiel.Parameters.AddWithValue("@Charterfirma", reader("Charterfirma"))
            cmdZiel.Parameters.AddWithValue("@Straße", reader("Straße"))
            cmdZiel.Parameters.AddWithValue("@Plz", reader("Plz"))
            cmdZiel.Parameters.AddWithValue("@Ort", reader("Ort"))
            cmdZiel.Parameters.AddWithValue("@Land", reader("Land"))
            cmdZiel.Parameters.AddWithValue("@Telefon", reader("Telefon"))
            cmdZiel.Parameters.AddWithValue("@Handy", reader("Handy"))
            cmdZiel.Parameters.AddWithValue("@email", reader("email"))
            cmdZiel.Parameters.AddWithValue("@WEBAuftritt", reader("WEBAuftritt"))
            cmdZiel.Parameters.AddWithValue("@Ansprechsperson", reader("Ansprechsperson"))
            cmdZiel.Parameters.AddWithValue("@Marina", reader("Marina"))
            cmdZiel.Parameters.AddWithValue("@Marinaort", reader("Marinaort"))
            cmdZiel.Parameters.AddWithValue("@Bemerkung", reader("Bemerkung"))
            cmdZiel.Parameters.AddWithValue("@Fax", reader("Fax"))
            cmdZiel.Parameters.AddWithValue("@Agentur", reader("Agentur"))
            cmdZiel.Parameters.AddWithValue("@R1", reader("R1"))
            cmdZiel.Parameters.AddWithValue("@R2", reader("R2"))
            cmdZiel.Parameters.AddWithValue("@R3", reader("R3"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()

    End Sub
    Private Sub AgenturImport()
        loeschenVerw("DELETE * FROM Agentur where Agentur = ?", TextBox5.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM AgenturE WHERE Agentur = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox5.Text)

        connQuelle.Open()
        Dim reader As OleDbDataReader = cmdQuelle.ExecuteReader()

        connZiel.Open()


        While reader.Read()
            Dim sqlInsert As String = "INSERT INTO Agentur (Agentur, Strasse, Plz, Ort, Land, Tel, Handy, WEB, Ansprechspartner, Bemerkung, Fax, R1, R2, R3) VALUES (@Agentur, @Strasse, @Plz, @Ort, @Land, @Tel, @Handy, @WEB, @Ansprechspartner, @Bemerkung, @Fax, @R1, @R2, @R3)"

            Dim cmdZiel As New OleDbCommand(sqlInsert, connZiel)
            cmdZiel.Parameters.AddWithValue("@Agentur", reader("Agentur"))
            cmdZiel.Parameters.AddWithValue("@Strasse", reader("Strasse"))
            cmdZiel.Parameters.AddWithValue("@Plz", reader("Plz"))
            cmdZiel.Parameters.AddWithValue("@Ort", reader("Ort"))
            cmdZiel.Parameters.AddWithValue("@Land", reader("Land"))
            cmdZiel.Parameters.AddWithValue("@Tel", reader("Tel"))
            cmdZiel.Parameters.AddWithValue("@Handy", reader("Handy"))
            cmdZiel.Parameters.AddWithValue("@WEB", reader("WEB"))
            cmdZiel.Parameters.AddWithValue("@Ansprechspartner", reader("Ansprechspartner"))
            cmdZiel.Parameters.AddWithValue("@Bemerkung", reader("Bemerkung"))
            cmdZiel.Parameters.AddWithValue("@Fax", reader("Fax"))
            cmdZiel.Parameters.AddWithValue("@R1", reader("R1"))
            cmdZiel.Parameters.AddWithValue("@R2", reader("R2"))
            cmdZiel.Parameters.AddWithValue("@R3", reader("R3"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub
    Private Sub Wacheplanimport()
        loeschenVerw("DELETE * FROM Wacheplan where toern= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Wacheplan WHERE Toern = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
    Private Sub bordkassaimport()
        loeschenVerw("DELETE * FROM Bordkassa where toern= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Bordkassa WHERE Toern = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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


    Private Sub BootLogimport()
        loeschendat("DELETE * FROM Bootlog where Bootname= ?", TextBox4.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Bootlog WHERE Bootname = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox4.Text)

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
    Private Sub sicherimport()
        loeschendat("DELETE * FROM Sicherheitseinweisung where toernbezeichnung= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Sicherheitseinweisung WHERE Toernbezeichnung = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
    Private Sub Toerndatenimport()
        loeschendat("DELETE * FROM Toerndaten where toernbezeichnung= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Toerndaten WHERE Toernbezeichnung = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
    Private Sub DokumentationImport()
        loeschendat("DELETE * FROM Dokumentation where toernbezeichnung= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Dokumentation WHERE Toernbezeichnung = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
    Private Sub LogDatenimport()
        loeschendat("DELETE * FROM Logdaten where toerbezeichnung= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM LogDaten WHERE Toerbezeichnung = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
    Private Sub Maengelimport()
        loeschendat("DELETE * FROM Maengel where toernbezeichnung= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Maengel WHERE Toernbezeichnung = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
    Private Sub Zusammenfassung2Import()
        loeschendat("DELETE * FROM Zusammenfassung2 where toernbezeichnung= ?", TextBox1.Text)
        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM Zusammenfassung2 WHERE Toernbezeichnung = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
    Private Sub LogWacheplanimport()
        loeschendat("DELETE * FROM LogWacheplan where toern= ?", TextBox1.Text)

        Dim connZiel As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb")
        Dim connQuelle As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Export.mdb")

        Dim sqlSelect As String = "SELECT * FROM LogWacheplan WHERE Toern = ? "
        Dim cmdQuelle As New OleDbCommand(sqlSelect, connQuelle)
        cmdQuelle.Parameters.AddWithValue("@p1", TextBox1.Text)

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
            cmdZiel.Parameters.AddWithValue("@TextVon", reader("TextVon"))
            cmdZiel.Parameters.AddWithValue("@TextBis", reader("TextBis"))
            cmdZiel.Parameters.AddWithValue("@VZName1", reader("VZName1"))
            cmdZiel.Parameters.AddWithValue("@VZName2", reader("VZName2"))
            cmdZiel.Parameters.AddWithValue("@VZName3", reader("VZName3"))
            cmdZiel.Parameters.AddWithValue("@Datum", reader("Datum"))

            cmdZiel.ExecuteNonQuery()
        End While

        reader.Close()
        connQuelle.Close()
        connZiel.Close()
    End Sub

    Private Sub loeschenVerw(ByVal sql As String, Optional ByVal paramValue As Object = Nothing)
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb;")
        Dim cmd As New OleDbCommand(sql, conn)
        If paramValue IsNot Nothing Then
            cmd.Parameters.AddWithValue("@p1", paramValue)
        End If

        Try
            DbAccess.WithRetry(Sub()
                                   If conn.State <> ConnectionState.Open Then conn.Open()
                                   Dim anzahl As Integer = cmd.ExecuteNonQuery()
                                   Console.WriteLine("Es wurden " & anzahl & " Datensätze gelöscht.")
                               End Sub)
        Catch ex As Exception
            AppLog.ErrorLog("loeschenVerw: " & sql, ex)
            Console.WriteLine("Fehler: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub loeschendat(ByVal sql As String, Optional ByVal paramValue As Object = Nothing)
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Logbuch.mdb;")
        Dim cmd As New OleDbCommand(sql, conn)
        If paramValue IsNot Nothing Then
            cmd.Parameters.AddWithValue("@p1", paramValue)
        End If

        Try
            DbAccess.WithRetry(Sub()
                                   If conn.State <> ConnectionState.Open Then conn.Open()
                                   Dim anzahl As Integer = cmd.ExecuteNonQuery()
                                   Console.WriteLine("Es wurden " & anzahl & " Datensätze gelöscht.")
                               End Sub)
        Catch ex As Exception
            AppLog.ErrorLog("loeschendat: " & sql, ex)
            Console.WriteLine("Fehler: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ListBox2.Items.Add(ListBox1.Text)
        ImportStart.Enabled = True
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        If ListBox2.Items.Count > 1 Then
            ImportStart.Enabled = True
        Else
            ImportStart.Enabled = False
        End If
        aaa = ListBox2.Text
        ListBox2.Items.Remove(aaa)
    End Sub
End Class