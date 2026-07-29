<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogbuchDruck
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogbuchDruck))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonDrucken = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridtoern = New System.Windows.Forms.DataGridView()
        Me.ToernbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusgangsmarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmSegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmGesamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfahrtenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtansteuerungenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordtageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TornberichtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndeMarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetzterSegeltagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordkassaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogbuchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sm1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfDatumvon1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtZeitvon1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfDatumbis1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtZeitbis1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtFahrtvon2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtFahrtbis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SM2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtDatumvon2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtZeitvon2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtDatumbis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtZeitbis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50StartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50ZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50SmGesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50smFB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50DatumStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50ZeitStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50DatumZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std50ZeitZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GezHafen1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GezDatum1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GezZeit1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GezHafen2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GezDatum2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GezZeit2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4StartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4ZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4SmGesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4SmFb3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4DatumStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4ZeitStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4DatumZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB4ZeitZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerbrauchproToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Bootname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Schiffstyp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kielart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Schiffsnummer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Durchfahrtshoehe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Länge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Breite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Verdrängung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiefgang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Großsegel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vorsegel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wassertank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dieseltank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Starterbatterie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicebatterie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kabinenanzahl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kojenanzahl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nassraeumeanzahl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charterfirma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Baujahr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grosssegelart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMSI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmNachweisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WachfuehrerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NavigatorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RudergaengerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.R1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDToernDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaHafen1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaDatum1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaZeit1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaHafen2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaDatum2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaZeit2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaHafen3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaDatum3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtaZeit3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotormarkeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeibootmarkeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeobootleistungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaustoffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootsBildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsBootLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLogbuch = New WindowsApplication1.dsLogbuch()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LifebeltDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FeuerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RettungsinselDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SignalmittelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.POBDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GesundheitDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DokumentationDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InnenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PantryDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EleAnlagenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SprechfunkDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MotorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SegelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WasserDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AussenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsSicherheitseinweisung = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BetrifftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefektDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuswirkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsMaengel = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wetterbericht1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wetterbericht2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wetterbericht3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UhrzeitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BesonderesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielAnlegeartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielGebührDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielMüllDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ZielStromDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MotorStdAnfangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorStdEndeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KraftstoffgetanktDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KraffstoffkostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBilgeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WasserTankenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckOelDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckBatterieDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AusgangsortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDokumentation = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toern = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsWacheplan = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsLogdaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView10 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZeitVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZeitBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WindrichtungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmuSegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmuMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmGesamtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WindstaerkeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsZusammenfassung2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView11 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeemeilenMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeemeilenSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorStdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfahrtenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtansteuerungenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KartenMissweisungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonnenaufgangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonnenuntergangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavtexstationenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VollmondDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxTidenhubDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonstigesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeplanteRouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KassaManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErsteinzahlungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PantryManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErsteinkaufDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevierBildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GefahreneRouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsToerndaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView12 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SynchronDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MethodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLogWacheplan = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld0DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld12DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld13DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld14DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld15DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld16DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld17DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld18DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld19DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld20DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld21DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld22DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld23DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld24DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld25DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld26DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Feld27DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Feld28DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Feld29DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Feld30DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Feld31DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Feld32DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld33DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld34DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld35DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld36DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld37DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld38DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld39DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld40DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld41DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld42DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld43DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld44DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld45DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld46DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld47DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld48DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld49DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld50DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTemp = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.taSicherheitseinweisung = New WindowsApplication1.dsLogbuchTableAdapters.SicherheitseinweisungTableAdapter()
        Me.taMaengel = New WindowsApplication1.dsLogbuchTableAdapters.MaengelTableAdapter()
        Me.taDokumentation = New WindowsApplication1.dsLogbuchTableAdapters.DokumentationTableAdapter()
        Me.taLogdaten = New WindowsApplication1.dsLogbuchTableAdapters.LogdatenTableAdapter()
        Me.taZusammenfassung2 = New WindowsApplication1.dsLogbuchTableAdapters.Zusammenfassung2TableAdapter()
        Me.taLogWacheplan = New WindowsApplication1.dsLogbuchTableAdapters.LogWacheplanTableAdapter()
        Me.taBootLog = New WindowsApplication1.dsLogbuchTableAdapters.BootLogTableAdapter()
        Me.taTemp = New WindowsApplication1.dsLogbuchTableAdapters.TempTableAdapter()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.taToerndaten = New WindowsApplication1.dsLogbuchTableAdapters.ToerndatenTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox25 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar9 = New System.Windows.Forms.ProgressBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBar8 = New System.Windows.Forms.ProgressBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProgressBar7 = New System.Windows.Forms.ProgressBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProgressBar6 = New System.Windows.Forms.ProgressBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.taWacheplan = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridtoern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBootLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSicherheitseinweisung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaengel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDokumentation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogdaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsZusammenfassung2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToerndaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogWacheplan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(900, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Törn"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(720, 74)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 43)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Starten"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(619, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Bootsname:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(159, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Bootsname", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(700, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Boot "
        '
        'bsToernname
        '
        Me.bsToernname.DataMember = "Toernname"
        Me.bsToernname.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Törnbezeichnung"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Toernbezeichnung", True))
        Me.TextBox1.Location = New System.Drawing.Point(220, 33)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(340, 22)
        Me.TextBox1.TabIndex = 0
        '
        'ButtonDrucken
        '
        Me.ButtonDrucken.Enabled = False
        Me.ButtonDrucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDrucken.Location = New System.Drawing.Point(736, 477)
        Me.ButtonDrucken.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDrucken.Name = "ButtonDrucken"
        Me.ButtonDrucken.Size = New System.Drawing.Size(148, 43)
        Me.ButtonDrucken.TabIndex = 2
        Me.ButtonDrucken.Text = "Drucken"
        Me.ButtonDrucken.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridtoern)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1120, 571)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(900, 284)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Törn mit Doppelklick auswählen"
        '
        'DataGridtoern
        '
        Me.DataGridtoern.AutoGenerateColumns = False
        Me.DataGridtoern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridtoern.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.TornberichtDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.BordkassaDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.LogbuchDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn, Me.Nachtfahrtvon1DataGridViewTextBoxColumn, Me.Nachtfahrtbis1DataGridViewTextBoxColumn, Me.Sm1DataGridViewTextBoxColumn, Me.NachtfDatumvon1DataGridViewTextBoxColumn, Me.NachtZeitvon1DataGridViewTextBoxColumn, Me.NachtfDatumbis1DataGridViewTextBoxColumn, Me.NachtZeitbis1DataGridViewTextBoxColumn, Me.NachtFahrtvon2DataGridViewTextBoxColumn, Me.NachtFahrtbis2DataGridViewTextBoxColumn, Me.SM2DataGridViewTextBoxColumn, Me.NachtDatumvon2DataGridViewTextBoxColumn, Me.NachtZeitvon2DataGridViewTextBoxColumn, Me.NachtDatumbis2DataGridViewTextBoxColumn, Me.NachtZeitbis2DataGridViewTextBoxColumn, Me.Std50StartDataGridViewTextBoxColumn, Me.Std50ZielDataGridViewTextBoxColumn, Me.Std50SmGesDataGridViewTextBoxColumn, Me.Std50smFB2DataGridViewTextBoxColumn, Me.Std50DatumStartDataGridViewTextBoxColumn, Me.Std50ZeitStartDataGridViewTextBoxColumn, Me.Std50DatumZielDataGridViewTextBoxColumn, Me.Std50ZeitZielDataGridViewTextBoxColumn, Me.GezHafen1DataGridViewTextBoxColumn, Me.GezDatum1DataGridViewTextBoxColumn, Me.GezZeit1DataGridViewTextBoxColumn, Me.GezHafen2DataGridViewTextBoxColumn, Me.GezDatum2DataGridViewTextBoxColumn, Me.GezZeit2DataGridViewTextBoxColumn, Me.FB4StartDataGridViewTextBoxColumn, Me.FB4ZielDataGridViewTextBoxColumn, Me.FB4SmGesDataGridViewTextBoxColumn, Me.FB4SmFb3DataGridViewTextBoxColumn, Me.FB4DatumStartDataGridViewTextBoxColumn, Me.FB4ZeitStartDataGridViewTextBoxColumn, Me.FB4DatumZielDataGridViewTextBoxColumn, Me.FB4ZeitZielDataGridViewTextBoxColumn, Me.RevierDataGridViewTextBoxColumn, Me.VerbrauchproToernDataGridViewTextBoxColumn})
        Me.DataGridtoern.DataSource = Me.bsToernname
        Me.DataGridtoern.Location = New System.Drawing.Point(8, 26)
        Me.DataGridtoern.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridtoern.Name = "DataGridtoern"
        Me.DataGridtoern.Size = New System.Drawing.Size(873, 250)
        Me.DataGridtoern.TabIndex = 0
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Width = 200
        '
        'DatumVonDataGridViewTextBoxColumn
        '
        Me.DatumVonDataGridViewTextBoxColumn.DataPropertyName = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.HeaderText = "Datum Von"
        Me.DatumVonDataGridViewTextBoxColumn.Name = "DatumVonDataGridViewTextBoxColumn"
        Me.DatumVonDataGridViewTextBoxColumn.Width = 80
        '
        'DatumBisDataGridViewTextBoxColumn
        '
        Me.DatumBisDataGridViewTextBoxColumn.DataPropertyName = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.HeaderText = "Datum Bis"
        Me.DatumBisDataGridViewTextBoxColumn.Name = "DatumBisDataGridViewTextBoxColumn"
        Me.DatumBisDataGridViewTextBoxColumn.Width = 80
        '
        'AusgangsmarinaDataGridViewTextBoxColumn
        '
        Me.AusgangsmarinaDataGridViewTextBoxColumn.DataPropertyName = "Ausgangsmarina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.HeaderText = "Marina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.Name = "AusgangsmarinaDataGridViewTextBoxColumn"
        '
        'SmSegelDataGridViewTextBoxColumn
        '
        Me.SmSegelDataGridViewTextBoxColumn.DataPropertyName = "smSegel"
        Me.SmSegelDataGridViewTextBoxColumn.HeaderText = "sm Segel"
        Me.SmSegelDataGridViewTextBoxColumn.Name = "SmSegelDataGridViewTextBoxColumn"
        Me.SmSegelDataGridViewTextBoxColumn.Width = 70
        '
        'SmMotorDataGridViewTextBoxColumn
        '
        Me.SmMotorDataGridViewTextBoxColumn.DataPropertyName = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.HeaderText = "sm Motor"
        Me.SmMotorDataGridViewTextBoxColumn.Name = "SmMotorDataGridViewTextBoxColumn"
        Me.SmMotorDataGridViewTextBoxColumn.Width = 70
        '
        'SmGesamtDataGridViewTextBoxColumn
        '
        Me.SmGesamtDataGridViewTextBoxColumn.DataPropertyName = "smGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.HeaderText = "sm Gesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.Name = "SmGesamtDataGridViewTextBoxColumn"
        Me.SmGesamtDataGridViewTextBoxColumn.Width = 70
        '
        'NachtfahrtenDataGridViewTextBoxColumn
        '
        Me.NachtfahrtenDataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn.HeaderText = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn.Name = "NachtfahrtenDataGridViewTextBoxColumn"
        '
        'NachtansteuerungenDataGridViewTextBoxColumn
        '
        Me.NachtansteuerungenDataGridViewTextBoxColumn.DataPropertyName = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn.HeaderText = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn.Name = "NachtansteuerungenDataGridViewTextBoxColumn"
        '
        'BordtageDataGridViewTextBoxColumn
        '
        Me.BordtageDataGridViewTextBoxColumn.DataPropertyName = "Bordtage"
        Me.BordtageDataGridViewTextBoxColumn.HeaderText = "Bordtage"
        Me.BordtageDataGridViewTextBoxColumn.Name = "BordtageDataGridViewTextBoxColumn"
        '
        'AusserhalbFB2DataGridViewTextBoxColumn
        '
        Me.AusserhalbFB2DataGridViewTextBoxColumn.DataPropertyName = "ausserhalbFB2"
        Me.AusserhalbFB2DataGridViewTextBoxColumn.HeaderText = "ausserhalbFB2"
        Me.AusserhalbFB2DataGridViewTextBoxColumn.Name = "AusserhalbFB2DataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'AusserhalbFB3DataGridViewTextBoxColumn
        '
        Me.AusserhalbFB3DataGridViewTextBoxColumn.DataPropertyName = "ausserhalbFB3"
        Me.AusserhalbFB3DataGridViewTextBoxColumn.HeaderText = "ausserhalbFB3"
        Me.AusserhalbFB3DataGridViewTextBoxColumn.Name = "AusserhalbFB3DataGridViewTextBoxColumn"
        '
        'TornberichtDataGridViewTextBoxColumn
        '
        Me.TornberichtDataGridViewTextBoxColumn.DataPropertyName = "Tornbericht"
        Me.TornberichtDataGridViewTextBoxColumn.HeaderText = "Tornbericht"
        Me.TornberichtDataGridViewTextBoxColumn.Name = "TornberichtDataGridViewTextBoxColumn"
        '
        'BootsnameDataGridViewTextBoxColumn
        '
        Me.BootsnameDataGridViewTextBoxColumn.DataPropertyName = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.HeaderText = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.Name = "BootsnameDataGridViewTextBoxColumn"
        '
        'SkipperDataGridViewTextBoxColumn
        '
        Me.SkipperDataGridViewTextBoxColumn.DataPropertyName = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.HeaderText = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.Name = "SkipperDataGridViewTextBoxColumn"
        '
        'EndeMarinaDataGridViewTextBoxColumn
        '
        Me.EndeMarinaDataGridViewTextBoxColumn.DataPropertyName = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.HeaderText = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.Name = "EndeMarinaDataGridViewTextBoxColumn"
        '
        'LetzterSegeltagDataGridViewCheckBoxColumn
        '
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.DataPropertyName = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.HeaderText = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.Name = "LetzterSegeltagDataGridViewCheckBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        '
        'BordkassaDataGridViewTextBoxColumn
        '
        Me.BordkassaDataGridViewTextBoxColumn.DataPropertyName = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.HeaderText = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.Name = "BordkassaDataGridViewTextBoxColumn"
        '
        'RouteDataGridViewTextBoxColumn
        '
        Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "Route"
        Me.RouteDataGridViewTextBoxColumn.HeaderText = "Route"
        Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
        '
        'LogbuchDataGridViewTextBoxColumn
        '
        Me.LogbuchDataGridViewTextBoxColumn.DataPropertyName = "Logbuch"
        Me.LogbuchDataGridViewTextBoxColumn.HeaderText = "Logbuch"
        Me.LogbuchDataGridViewTextBoxColumn.Name = "LogbuchDataGridViewTextBoxColumn"
        '
        'R1DataGridViewTextBoxColumn
        '
        Me.R1DataGridViewTextBoxColumn.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn.Name = "R1DataGridViewTextBoxColumn"
        '
        'R2DataGridViewTextBoxColumn
        '
        Me.R2DataGridViewTextBoxColumn.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn.Name = "R2DataGridViewTextBoxColumn"
        '
        'R3DataGridViewTextBoxColumn
        '
        Me.R3DataGridViewTextBoxColumn.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn.Name = "R3DataGridViewTextBoxColumn"
        '
        'IDToernDataGridViewTextBoxColumn
        '
        Me.IDToernDataGridViewTextBoxColumn.DataPropertyName = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.HeaderText = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.Name = "IDToernDataGridViewTextBoxColumn"
        '
        'Nachtfahrtvon1DataGridViewTextBoxColumn
        '
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrtvon1"
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.HeaderText = "Nachtfahrtvon1"
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.Name = "Nachtfahrtvon1DataGridViewTextBoxColumn"
        '
        'Nachtfahrtbis1DataGridViewTextBoxColumn
        '
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrtbis1"
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.HeaderText = "Nachtfahrtbis1"
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.Name = "Nachtfahrtbis1DataGridViewTextBoxColumn"
        '
        'Sm1DataGridViewTextBoxColumn
        '
        Me.Sm1DataGridViewTextBoxColumn.DataPropertyName = "Sm1"
        Me.Sm1DataGridViewTextBoxColumn.HeaderText = "Sm1"
        Me.Sm1DataGridViewTextBoxColumn.Name = "Sm1DataGridViewTextBoxColumn"
        '
        'NachtfDatumvon1DataGridViewTextBoxColumn
        '
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.DataPropertyName = "NachtfDatumvon1"
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.HeaderText = "NachtfDatumvon1"
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.Name = "NachtfDatumvon1DataGridViewTextBoxColumn"
        '
        'NachtZeitvon1DataGridViewTextBoxColumn
        '
        Me.NachtZeitvon1DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitvon1"
        Me.NachtZeitvon1DataGridViewTextBoxColumn.HeaderText = "NachtZeitvon1"
        Me.NachtZeitvon1DataGridViewTextBoxColumn.Name = "NachtZeitvon1DataGridViewTextBoxColumn"
        '
        'NachtfDatumbis1DataGridViewTextBoxColumn
        '
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.DataPropertyName = "NachtfDatumbis1"
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.HeaderText = "NachtfDatumbis1"
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.Name = "NachtfDatumbis1DataGridViewTextBoxColumn"
        '
        'NachtZeitbis1DataGridViewTextBoxColumn
        '
        Me.NachtZeitbis1DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitbis1"
        Me.NachtZeitbis1DataGridViewTextBoxColumn.HeaderText = "NachtZeitbis1"
        Me.NachtZeitbis1DataGridViewTextBoxColumn.Name = "NachtZeitbis1DataGridViewTextBoxColumn"
        '
        'NachtFahrtvon2DataGridViewTextBoxColumn
        '
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtFahrtvon2"
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.HeaderText = "NachtFahrtvon2"
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.Name = "NachtFahrtvon2DataGridViewTextBoxColumn"
        '
        'NachtFahrtbis2DataGridViewTextBoxColumn
        '
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtFahrtbis2"
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.HeaderText = "NachtFahrtbis2"
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.Name = "NachtFahrtbis2DataGridViewTextBoxColumn"
        '
        'SM2DataGridViewTextBoxColumn
        '
        Me.SM2DataGridViewTextBoxColumn.DataPropertyName = "SM2"
        Me.SM2DataGridViewTextBoxColumn.HeaderText = "SM2"
        Me.SM2DataGridViewTextBoxColumn.Name = "SM2DataGridViewTextBoxColumn"
        '
        'NachtDatumvon2DataGridViewTextBoxColumn
        '
        Me.NachtDatumvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtDatumvon2"
        Me.NachtDatumvon2DataGridViewTextBoxColumn.HeaderText = "NachtDatumvon2"
        Me.NachtDatumvon2DataGridViewTextBoxColumn.Name = "NachtDatumvon2DataGridViewTextBoxColumn"
        '
        'NachtZeitvon2DataGridViewTextBoxColumn
        '
        Me.NachtZeitvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitvon2"
        Me.NachtZeitvon2DataGridViewTextBoxColumn.HeaderText = "NachtZeitvon2"
        Me.NachtZeitvon2DataGridViewTextBoxColumn.Name = "NachtZeitvon2DataGridViewTextBoxColumn"
        '
        'NachtDatumbis2DataGridViewTextBoxColumn
        '
        Me.NachtDatumbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtDatumbis2"
        Me.NachtDatumbis2DataGridViewTextBoxColumn.HeaderText = "NachtDatumbis2"
        Me.NachtDatumbis2DataGridViewTextBoxColumn.Name = "NachtDatumbis2DataGridViewTextBoxColumn"
        '
        'NachtZeitbis2DataGridViewTextBoxColumn
        '
        Me.NachtZeitbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitbis2"
        Me.NachtZeitbis2DataGridViewTextBoxColumn.HeaderText = "NachtZeitbis2"
        Me.NachtZeitbis2DataGridViewTextBoxColumn.Name = "NachtZeitbis2DataGridViewTextBoxColumn"
        '
        'Std50StartDataGridViewTextBoxColumn
        '
        Me.Std50StartDataGridViewTextBoxColumn.DataPropertyName = "Std50Start"
        Me.Std50StartDataGridViewTextBoxColumn.HeaderText = "Std50Start"
        Me.Std50StartDataGridViewTextBoxColumn.Name = "Std50StartDataGridViewTextBoxColumn"
        '
        'Std50ZielDataGridViewTextBoxColumn
        '
        Me.Std50ZielDataGridViewTextBoxColumn.DataPropertyName = "Std50Ziel"
        Me.Std50ZielDataGridViewTextBoxColumn.HeaderText = "Std50Ziel"
        Me.Std50ZielDataGridViewTextBoxColumn.Name = "Std50ZielDataGridViewTextBoxColumn"
        '
        'Std50SmGesDataGridViewTextBoxColumn
        '
        Me.Std50SmGesDataGridViewTextBoxColumn.DataPropertyName = "Std50SmGes"
        Me.Std50SmGesDataGridViewTextBoxColumn.HeaderText = "Std50SmGes"
        Me.Std50SmGesDataGridViewTextBoxColumn.Name = "Std50SmGesDataGridViewTextBoxColumn"
        '
        'Std50smFB2DataGridViewTextBoxColumn
        '
        Me.Std50smFB2DataGridViewTextBoxColumn.DataPropertyName = "Std50smFB2"
        Me.Std50smFB2DataGridViewTextBoxColumn.HeaderText = "Std50smFB2"
        Me.Std50smFB2DataGridViewTextBoxColumn.Name = "Std50smFB2DataGridViewTextBoxColumn"
        '
        'Std50DatumStartDataGridViewTextBoxColumn
        '
        Me.Std50DatumStartDataGridViewTextBoxColumn.DataPropertyName = "Std50DatumStart"
        Me.Std50DatumStartDataGridViewTextBoxColumn.HeaderText = "Std50DatumStart"
        Me.Std50DatumStartDataGridViewTextBoxColumn.Name = "Std50DatumStartDataGridViewTextBoxColumn"
        '
        'Std50ZeitStartDataGridViewTextBoxColumn
        '
        Me.Std50ZeitStartDataGridViewTextBoxColumn.DataPropertyName = "Std50ZeitStart"
        Me.Std50ZeitStartDataGridViewTextBoxColumn.HeaderText = "Std50ZeitStart"
        Me.Std50ZeitStartDataGridViewTextBoxColumn.Name = "Std50ZeitStartDataGridViewTextBoxColumn"
        '
        'Std50DatumZielDataGridViewTextBoxColumn
        '
        Me.Std50DatumZielDataGridViewTextBoxColumn.DataPropertyName = "Std50DatumZiel"
        Me.Std50DatumZielDataGridViewTextBoxColumn.HeaderText = "Std50DatumZiel"
        Me.Std50DatumZielDataGridViewTextBoxColumn.Name = "Std50DatumZielDataGridViewTextBoxColumn"
        '
        'Std50ZeitZielDataGridViewTextBoxColumn
        '
        Me.Std50ZeitZielDataGridViewTextBoxColumn.DataPropertyName = "Std50ZeitZiel"
        Me.Std50ZeitZielDataGridViewTextBoxColumn.HeaderText = "Std50ZeitZiel"
        Me.Std50ZeitZielDataGridViewTextBoxColumn.Name = "Std50ZeitZielDataGridViewTextBoxColumn"
        '
        'GezHafen1DataGridViewTextBoxColumn
        '
        Me.GezHafen1DataGridViewTextBoxColumn.DataPropertyName = "GezHafen1"
        Me.GezHafen1DataGridViewTextBoxColumn.HeaderText = "GezHafen1"
        Me.GezHafen1DataGridViewTextBoxColumn.Name = "GezHafen1DataGridViewTextBoxColumn"
        '
        'GezDatum1DataGridViewTextBoxColumn
        '
        Me.GezDatum1DataGridViewTextBoxColumn.DataPropertyName = "GezDatum1"
        Me.GezDatum1DataGridViewTextBoxColumn.HeaderText = "GezDatum1"
        Me.GezDatum1DataGridViewTextBoxColumn.Name = "GezDatum1DataGridViewTextBoxColumn"
        '
        'GezZeit1DataGridViewTextBoxColumn
        '
        Me.GezZeit1DataGridViewTextBoxColumn.DataPropertyName = "GezZeit1"
        Me.GezZeit1DataGridViewTextBoxColumn.HeaderText = "GezZeit1"
        Me.GezZeit1DataGridViewTextBoxColumn.Name = "GezZeit1DataGridViewTextBoxColumn"
        '
        'GezHafen2DataGridViewTextBoxColumn
        '
        Me.GezHafen2DataGridViewTextBoxColumn.DataPropertyName = "GezHafen2"
        Me.GezHafen2DataGridViewTextBoxColumn.HeaderText = "GezHafen2"
        Me.GezHafen2DataGridViewTextBoxColumn.Name = "GezHafen2DataGridViewTextBoxColumn"
        '
        'GezDatum2DataGridViewTextBoxColumn
        '
        Me.GezDatum2DataGridViewTextBoxColumn.DataPropertyName = "GezDatum2"
        Me.GezDatum2DataGridViewTextBoxColumn.HeaderText = "GezDatum2"
        Me.GezDatum2DataGridViewTextBoxColumn.Name = "GezDatum2DataGridViewTextBoxColumn"
        '
        'GezZeit2DataGridViewTextBoxColumn
        '
        Me.GezZeit2DataGridViewTextBoxColumn.DataPropertyName = "GezZeit2"
        Me.GezZeit2DataGridViewTextBoxColumn.HeaderText = "GezZeit2"
        Me.GezZeit2DataGridViewTextBoxColumn.Name = "GezZeit2DataGridViewTextBoxColumn"
        '
        'FB4StartDataGridViewTextBoxColumn
        '
        Me.FB4StartDataGridViewTextBoxColumn.DataPropertyName = "FB4Start"
        Me.FB4StartDataGridViewTextBoxColumn.HeaderText = "FB4Start"
        Me.FB4StartDataGridViewTextBoxColumn.Name = "FB4StartDataGridViewTextBoxColumn"
        '
        'FB4ZielDataGridViewTextBoxColumn
        '
        Me.FB4ZielDataGridViewTextBoxColumn.DataPropertyName = "FB4Ziel"
        Me.FB4ZielDataGridViewTextBoxColumn.HeaderText = "FB4Ziel"
        Me.FB4ZielDataGridViewTextBoxColumn.Name = "FB4ZielDataGridViewTextBoxColumn"
        '
        'FB4SmGesDataGridViewTextBoxColumn
        '
        Me.FB4SmGesDataGridViewTextBoxColumn.DataPropertyName = "FB4SmGes"
        Me.FB4SmGesDataGridViewTextBoxColumn.HeaderText = "FB4SmGes"
        Me.FB4SmGesDataGridViewTextBoxColumn.Name = "FB4SmGesDataGridViewTextBoxColumn"
        '
        'FB4SmFb3DataGridViewTextBoxColumn
        '
        Me.FB4SmFb3DataGridViewTextBoxColumn.DataPropertyName = "FB4SmFb3"
        Me.FB4SmFb3DataGridViewTextBoxColumn.HeaderText = "FB4SmFb3"
        Me.FB4SmFb3DataGridViewTextBoxColumn.Name = "FB4SmFb3DataGridViewTextBoxColumn"
        '
        'FB4DatumStartDataGridViewTextBoxColumn
        '
        Me.FB4DatumStartDataGridViewTextBoxColumn.DataPropertyName = "FB4DatumStart"
        Me.FB4DatumStartDataGridViewTextBoxColumn.HeaderText = "FB4DatumStart"
        Me.FB4DatumStartDataGridViewTextBoxColumn.Name = "FB4DatumStartDataGridViewTextBoxColumn"
        '
        'FB4ZeitStartDataGridViewTextBoxColumn
        '
        Me.FB4ZeitStartDataGridViewTextBoxColumn.DataPropertyName = "FB4ZeitStart"
        Me.FB4ZeitStartDataGridViewTextBoxColumn.HeaderText = "FB4ZeitStart"
        Me.FB4ZeitStartDataGridViewTextBoxColumn.Name = "FB4ZeitStartDataGridViewTextBoxColumn"
        '
        'FB4DatumZielDataGridViewTextBoxColumn
        '
        Me.FB4DatumZielDataGridViewTextBoxColumn.DataPropertyName = "FB4DatumZiel"
        Me.FB4DatumZielDataGridViewTextBoxColumn.HeaderText = "FB4DatumZiel"
        Me.FB4DatumZielDataGridViewTextBoxColumn.Name = "FB4DatumZielDataGridViewTextBoxColumn"
        '
        'FB4ZeitZielDataGridViewTextBoxColumn
        '
        Me.FB4ZeitZielDataGridViewTextBoxColumn.DataPropertyName = "FB4ZeitZiel"
        Me.FB4ZeitZielDataGridViewTextBoxColumn.HeaderText = "FB4ZeitZiel"
        Me.FB4ZeitZielDataGridViewTextBoxColumn.Name = "FB4ZeitZielDataGridViewTextBoxColumn"
        '
        'RevierDataGridViewTextBoxColumn
        '
        Me.RevierDataGridViewTextBoxColumn.DataPropertyName = "Revier"
        Me.RevierDataGridViewTextBoxColumn.HeaderText = "Revier"
        Me.RevierDataGridViewTextBoxColumn.Name = "RevierDataGridViewTextBoxColumn"
        '
        'VerbrauchproToernDataGridViewTextBoxColumn
        '
        Me.VerbrauchproToernDataGridViewTextBoxColumn.DataPropertyName = "VerbrauchproToern"
        Me.VerbrauchproToernDataGridViewTextBoxColumn.HeaderText = "VerbrauchproToern"
        Me.VerbrauchproToernDataGridViewTextBoxColumn.Name = "VerbrauchproToernDataGridViewTextBoxColumn"
        '
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bootname, Me.Marke, Me.Schiffstyp, Me.Kielart, Me.Schiffsnummer, Me.Durchfahrtshoehe, Me.Länge, Me.Breite, Me.Verdrängung, Me.Tiefgang, Me.Großsegel, Me.Vorsegel, Me.Wassertank, Me.Dieseltank, Me.Starterbatterie, Me.Servicebatterie, Me.Kabinenanzahl, Me.Kojenanzahl, Me.Nassraeumeanzahl, Me.Motor, Me.Charterfirma, Me.Baujahr, Me.Grosssegelart, Me.MMSI})
        Me.DataGridView2.Location = New System.Drawing.Point(2012, 139)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(320, 97)
        Me.DataGridView2.TabIndex = 4
        '
        'Bootname
        '
        Me.Bootname.DataPropertyName = "Bootname"
        Me.Bootname.HeaderText = "Bootname"
        Me.Bootname.Name = "Bootname"
        '
        'Marke
        '
        Me.Marke.DataPropertyName = "Marke"
        Me.Marke.HeaderText = "Marke"
        Me.Marke.Name = "Marke"
        '
        'Schiffstyp
        '
        Me.Schiffstyp.DataPropertyName = "Schiffstyp"
        Me.Schiffstyp.HeaderText = "Schiffstyp"
        Me.Schiffstyp.Name = "Schiffstyp"
        '
        'Kielart
        '
        Me.Kielart.DataPropertyName = "Kielart"
        Me.Kielart.HeaderText = "Kielart"
        Me.Kielart.Name = "Kielart"
        '
        'Schiffsnummer
        '
        Me.Schiffsnummer.DataPropertyName = "Schiffsnummer"
        Me.Schiffsnummer.HeaderText = "Schiffsnummer"
        Me.Schiffsnummer.Name = "Schiffsnummer"
        '
        'Durchfahrtshoehe
        '
        Me.Durchfahrtshoehe.DataPropertyName = "Durchfahrtshoehe"
        Me.Durchfahrtshoehe.HeaderText = "Durchfahrtshoehe"
        Me.Durchfahrtshoehe.Name = "Durchfahrtshoehe"
        '
        'Länge
        '
        Me.Länge.DataPropertyName = "Länge"
        Me.Länge.HeaderText = "Länge"
        Me.Länge.Name = "Länge"
        '
        'Breite
        '
        Me.Breite.DataPropertyName = "Breite"
        Me.Breite.HeaderText = "Breite"
        Me.Breite.Name = "Breite"
        '
        'Verdrängung
        '
        Me.Verdrängung.DataPropertyName = "Verdrängung"
        Me.Verdrängung.HeaderText = "Verdrängung"
        Me.Verdrängung.Name = "Verdrängung"
        '
        'Tiefgang
        '
        Me.Tiefgang.DataPropertyName = "Tiefgang"
        Me.Tiefgang.HeaderText = "Tiefgang"
        Me.Tiefgang.Name = "Tiefgang"
        '
        'Großsegel
        '
        Me.Großsegel.DataPropertyName = "Großsegel"
        Me.Großsegel.HeaderText = "Großsegel"
        Me.Großsegel.Name = "Großsegel"
        '
        'Vorsegel
        '
        Me.Vorsegel.DataPropertyName = "Vorsegel"
        Me.Vorsegel.HeaderText = "Vorsegel"
        Me.Vorsegel.Name = "Vorsegel"
        '
        'Wassertank
        '
        Me.Wassertank.DataPropertyName = "Wassertank"
        Me.Wassertank.HeaderText = "Wassertank"
        Me.Wassertank.Name = "Wassertank"
        '
        'Dieseltank
        '
        Me.Dieseltank.DataPropertyName = "Dieseltank"
        Me.Dieseltank.HeaderText = "Dieseltank"
        Me.Dieseltank.Name = "Dieseltank"
        '
        'Starterbatterie
        '
        Me.Starterbatterie.DataPropertyName = "Starterbatterie"
        Me.Starterbatterie.HeaderText = "Starterbatterie"
        Me.Starterbatterie.Name = "Starterbatterie"
        '
        'Servicebatterie
        '
        Me.Servicebatterie.DataPropertyName = "Servicebatterie"
        Me.Servicebatterie.HeaderText = "Servicebatterie"
        Me.Servicebatterie.Name = "Servicebatterie"
        '
        'Kabinenanzahl
        '
        Me.Kabinenanzahl.DataPropertyName = "Kabinenanzahl"
        Me.Kabinenanzahl.HeaderText = "Kabinenanzahl"
        Me.Kabinenanzahl.Name = "Kabinenanzahl"
        '
        'Kojenanzahl
        '
        Me.Kojenanzahl.DataPropertyName = "Kojenanzahl"
        Me.Kojenanzahl.HeaderText = "Kojenanzahl"
        Me.Kojenanzahl.Name = "Kojenanzahl"
        '
        'Nassraeumeanzahl
        '
        Me.Nassraeumeanzahl.DataPropertyName = "Nassraeumeanzahl"
        Me.Nassraeumeanzahl.HeaderText = "Nassraeumeanzahl"
        Me.Nassraeumeanzahl.Name = "Nassraeumeanzahl"
        '
        'Motor
        '
        Me.Motor.DataPropertyName = "Motor"
        Me.Motor.HeaderText = "Motor"
        Me.Motor.Name = "Motor"
        '
        'Charterfirma
        '
        Me.Charterfirma.DataPropertyName = "Charterfirma"
        Me.Charterfirma.HeaderText = "Charterfirma"
        Me.Charterfirma.Name = "Charterfirma"
        '
        'Baujahr
        '
        Me.Baujahr.DataPropertyName = "Baujahr"
        Me.Baujahr.HeaderText = "Baujahr"
        Me.Baujahr.Name = "Baujahr"
        '
        'Grosssegelart
        '
        Me.Grosssegelart.DataPropertyName = "Grosssegelart"
        Me.Grosssegelart.HeaderText = "Grosssegelart"
        Me.Grosssegelart.Name = "Grosssegelart"
        '
        'MMSI
        '
        Me.MMSI.DataPropertyName = "MMSI"
        Me.MMSI.HeaderText = "MMSI"
        Me.MMSI.Name = "MMSI"
        '
        'bsTC
        '
        Me.bsTC.DataMember = "TC"
        Me.bsTC.DataSource = Me.dsToernverwaltung
        '
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
        '
        'bsBoot
        '
        Me.bsBoot.DataMember = "Boot"
        Me.bsBoot.DataSource = Me.dsToernverwaltung
        '
        'taBoot
        '
        Me.taBoot.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.ToernDataGridViewTextBoxColumn, Me.VZnameDataGridViewTextBoxColumn, Me.SmNachweisDataGridViewCheckBoxColumn, Me.WachfuehrerDataGridViewCheckBoxColumn, Me.NavigatorDataGridViewCheckBoxColumn, Me.RudergaengerDataGridViewCheckBoxColumn, Me.R1DataGridViewTextBoxColumn1, Me.R2DataGridViewTextBoxColumn1, Me.R3DataGridViewTextBoxColumn1, Me.IDToernDataGridViewTextBoxColumn1, Me.NachtaHafen1DataGridViewTextBoxColumn, Me.NachtaDatum1DataGridViewTextBoxColumn, Me.NachtaZeit1DataGridViewTextBoxColumn, Me.NachtaHafen2DataGridViewTextBoxColumn, Me.NachtaDatum2DataGridViewTextBoxColumn, Me.NachtaZeit2DataGridViewTextBoxColumn, Me.NachtaHafen3DataGridViewTextBoxColumn, Me.NachtaDatum3DataGridViewTextBoxColumn, Me.NachtaZeit3DataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsTC
        Me.DataGridView3.Location = New System.Drawing.Point(2012, 15)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(321, 117)
        Me.DataGridView3.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
        '
        'VZnameDataGridViewTextBoxColumn
        '
        Me.VZnameDataGridViewTextBoxColumn.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.Name = "VZnameDataGridViewTextBoxColumn"
        '
        'SmNachweisDataGridViewCheckBoxColumn
        '
        Me.SmNachweisDataGridViewCheckBoxColumn.DataPropertyName = "smNachweis"
        Me.SmNachweisDataGridViewCheckBoxColumn.HeaderText = "smNachweis"
        Me.SmNachweisDataGridViewCheckBoxColumn.Name = "SmNachweisDataGridViewCheckBoxColumn"
        '
        'WachfuehrerDataGridViewCheckBoxColumn
        '
        Me.WachfuehrerDataGridViewCheckBoxColumn.DataPropertyName = "Wachfuehrer"
        Me.WachfuehrerDataGridViewCheckBoxColumn.HeaderText = "Wachfuehrer"
        Me.WachfuehrerDataGridViewCheckBoxColumn.Name = "WachfuehrerDataGridViewCheckBoxColumn"
        '
        'NavigatorDataGridViewCheckBoxColumn
        '
        Me.NavigatorDataGridViewCheckBoxColumn.DataPropertyName = "Navigator"
        Me.NavigatorDataGridViewCheckBoxColumn.HeaderText = "Navigator"
        Me.NavigatorDataGridViewCheckBoxColumn.Name = "NavigatorDataGridViewCheckBoxColumn"
        '
        'RudergaengerDataGridViewCheckBoxColumn
        '
        Me.RudergaengerDataGridViewCheckBoxColumn.DataPropertyName = "Rudergaenger"
        Me.RudergaengerDataGridViewCheckBoxColumn.HeaderText = "Rudergaenger"
        Me.RudergaengerDataGridViewCheckBoxColumn.Name = "RudergaengerDataGridViewCheckBoxColumn"
        '
        'R1DataGridViewTextBoxColumn1
        '
        Me.R1DataGridViewTextBoxColumn1.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn1.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn1.Name = "R1DataGridViewTextBoxColumn1"
        '
        'R2DataGridViewTextBoxColumn1
        '
        Me.R2DataGridViewTextBoxColumn1.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn1.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn1.Name = "R2DataGridViewTextBoxColumn1"
        '
        'R3DataGridViewTextBoxColumn1
        '
        Me.R3DataGridViewTextBoxColumn1.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn1.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn1.Name = "R3DataGridViewTextBoxColumn1"
        '
        'IDToernDataGridViewTextBoxColumn1
        '
        Me.IDToernDataGridViewTextBoxColumn1.DataPropertyName = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn1.HeaderText = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn1.Name = "IDToernDataGridViewTextBoxColumn1"
        '
        'NachtaHafen1DataGridViewTextBoxColumn
        '
        Me.NachtaHafen1DataGridViewTextBoxColumn.DataPropertyName = "NachtaHafen1"
        Me.NachtaHafen1DataGridViewTextBoxColumn.HeaderText = "NachtaHafen1"
        Me.NachtaHafen1DataGridViewTextBoxColumn.Name = "NachtaHafen1DataGridViewTextBoxColumn"
        '
        'NachtaDatum1DataGridViewTextBoxColumn
        '
        Me.NachtaDatum1DataGridViewTextBoxColumn.DataPropertyName = "NachtaDatum1"
        Me.NachtaDatum1DataGridViewTextBoxColumn.HeaderText = "NachtaDatum1"
        Me.NachtaDatum1DataGridViewTextBoxColumn.Name = "NachtaDatum1DataGridViewTextBoxColumn"
        '
        'NachtaZeit1DataGridViewTextBoxColumn
        '
        Me.NachtaZeit1DataGridViewTextBoxColumn.DataPropertyName = "NachtaZeit1"
        Me.NachtaZeit1DataGridViewTextBoxColumn.HeaderText = "NachtaZeit1"
        Me.NachtaZeit1DataGridViewTextBoxColumn.Name = "NachtaZeit1DataGridViewTextBoxColumn"
        '
        'NachtaHafen2DataGridViewTextBoxColumn
        '
        Me.NachtaHafen2DataGridViewTextBoxColumn.DataPropertyName = "NachtaHafen2"
        Me.NachtaHafen2DataGridViewTextBoxColumn.HeaderText = "NachtaHafen2"
        Me.NachtaHafen2DataGridViewTextBoxColumn.Name = "NachtaHafen2DataGridViewTextBoxColumn"
        '
        'NachtaDatum2DataGridViewTextBoxColumn
        '
        Me.NachtaDatum2DataGridViewTextBoxColumn.DataPropertyName = "NachtaDatum2"
        Me.NachtaDatum2DataGridViewTextBoxColumn.HeaderText = "NachtaDatum2"
        Me.NachtaDatum2DataGridViewTextBoxColumn.Name = "NachtaDatum2DataGridViewTextBoxColumn"
        '
        'NachtaZeit2DataGridViewTextBoxColumn
        '
        Me.NachtaZeit2DataGridViewTextBoxColumn.DataPropertyName = "NachtaZeit2"
        Me.NachtaZeit2DataGridViewTextBoxColumn.HeaderText = "NachtaZeit2"
        Me.NachtaZeit2DataGridViewTextBoxColumn.Name = "NachtaZeit2DataGridViewTextBoxColumn"
        '
        'NachtaHafen3DataGridViewTextBoxColumn
        '
        Me.NachtaHafen3DataGridViewTextBoxColumn.DataPropertyName = "NachtaHafen3"
        Me.NachtaHafen3DataGridViewTextBoxColumn.HeaderText = "NachtaHafen3"
        Me.NachtaHafen3DataGridViewTextBoxColumn.Name = "NachtaHafen3DataGridViewTextBoxColumn"
        '
        'NachtaDatum3DataGridViewTextBoxColumn
        '
        Me.NachtaDatum3DataGridViewTextBoxColumn.DataPropertyName = "NachtaDatum3"
        Me.NachtaDatum3DataGridViewTextBoxColumn.HeaderText = "NachtaDatum3"
        Me.NachtaDatum3DataGridViewTextBoxColumn.Name = "NachtaDatum3DataGridViewTextBoxColumn"
        '
        'NachtaZeit3DataGridViewTextBoxColumn
        '
        Me.NachtaZeit3DataGridViewTextBoxColumn.DataPropertyName = "NachtaZeit3"
        Me.NachtaZeit3DataGridViewTextBoxColumn.HeaderText = "NachtaZeit3"
        Me.NachtaZeit3DataGridViewTextBoxColumn.Name = "NachtaZeit3DataGridViewTextBoxColumn"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.BootnameDataGridViewTextBoxColumn, Me.MotormarkeDataGridViewTextBoxColumn, Me.BeibootmarkeDataGridViewTextBoxColumn, Me.BeobootleistungDataGridViewTextBoxColumn, Me.BaustoffDataGridViewTextBoxColumn, Me.BootsBildDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.bsBootLog
        Me.DataGridView4.Location = New System.Drawing.Point(2012, 244)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(320, 118)
        Me.DataGridView4.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'BootnameDataGridViewTextBoxColumn
        '
        Me.BootnameDataGridViewTextBoxColumn.DataPropertyName = "Bootname"
        Me.BootnameDataGridViewTextBoxColumn.HeaderText = "Bootname"
        Me.BootnameDataGridViewTextBoxColumn.Name = "BootnameDataGridViewTextBoxColumn"
        '
        'MotormarkeDataGridViewTextBoxColumn
        '
        Me.MotormarkeDataGridViewTextBoxColumn.DataPropertyName = "Motormarke"
        Me.MotormarkeDataGridViewTextBoxColumn.HeaderText = "Motormarke"
        Me.MotormarkeDataGridViewTextBoxColumn.Name = "MotormarkeDataGridViewTextBoxColumn"
        '
        'BeibootmarkeDataGridViewTextBoxColumn
        '
        Me.BeibootmarkeDataGridViewTextBoxColumn.DataPropertyName = "Beibootmarke"
        Me.BeibootmarkeDataGridViewTextBoxColumn.HeaderText = "Beibootmarke"
        Me.BeibootmarkeDataGridViewTextBoxColumn.Name = "BeibootmarkeDataGridViewTextBoxColumn"
        '
        'BeobootleistungDataGridViewTextBoxColumn
        '
        Me.BeobootleistungDataGridViewTextBoxColumn.DataPropertyName = "Beobootleistung"
        Me.BeobootleistungDataGridViewTextBoxColumn.HeaderText = "Beobootleistung"
        Me.BeobootleistungDataGridViewTextBoxColumn.Name = "BeobootleistungDataGridViewTextBoxColumn"
        '
        'BaustoffDataGridViewTextBoxColumn
        '
        Me.BaustoffDataGridViewTextBoxColumn.DataPropertyName = "Baustoff"
        Me.BaustoffDataGridViewTextBoxColumn.HeaderText = "Baustoff"
        Me.BaustoffDataGridViewTextBoxColumn.Name = "BaustoffDataGridViewTextBoxColumn"
        '
        'BootsBildDataGridViewTextBoxColumn
        '
        Me.BootsBildDataGridViewTextBoxColumn.DataPropertyName = "BootsBild"
        Me.BootsBildDataGridViewTextBoxColumn.HeaderText = "BootsBild"
        Me.BootsBildDataGridViewTextBoxColumn.Name = "BootsBildDataGridViewTextBoxColumn"
        '
        'bsBootLog
        '
        Me.bsBootLog.DataMember = "BootLog"
        Me.bsBootLog.DataSource = Me.DsLogbuch
        '
        'DsLogbuch
        '
        Me.DsLogbuch.DataSetName = "dsLogbuch"
        Me.DsLogbuch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.ToernbezeichnungDataGridViewTextBoxColumn1, Me.SiDatumDataGridViewTextBoxColumn, Me.SiVonDataGridViewTextBoxColumn, Me.SiBisDataGridViewTextBoxColumn, Me.LifebeltDataGridViewCheckBoxColumn, Me.FeuerDataGridViewCheckBoxColumn, Me.GasDataGridViewCheckBoxColumn, Me.RettungsinselDataGridViewCheckBoxColumn, Me.SignalmittelDataGridViewCheckBoxColumn, Me.POBDataGridViewCheckBoxColumn, Me.GesundheitDataGridViewCheckBoxColumn, Me.DokumentationDataGridViewCheckBoxColumn, Me.InnenDataGridViewCheckBoxColumn, Me.PantryDataGridViewCheckBoxColumn, Me.EleAnlagenDataGridViewCheckBoxColumn, Me.SprechfunkDataGridViewCheckBoxColumn, Me.MotorDataGridViewCheckBoxColumn, Me.SegelDataGridViewCheckBoxColumn, Me.WasserDataGridViewCheckBoxColumn, Me.AussenDataGridViewCheckBoxColumn})
        Me.DataGridView5.DataSource = Me.bsSicherheitseinweisung
        Me.DataGridView5.Location = New System.Drawing.Point(2012, 369)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(320, 103)
        Me.DataGridView5.TabIndex = 7
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn1
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.Name = "ToernbezeichnungDataGridViewTextBoxColumn1"
        '
        'SiDatumDataGridViewTextBoxColumn
        '
        Me.SiDatumDataGridViewTextBoxColumn.DataPropertyName = "SiDatum"
        Me.SiDatumDataGridViewTextBoxColumn.HeaderText = "SiDatum"
        Me.SiDatumDataGridViewTextBoxColumn.Name = "SiDatumDataGridViewTextBoxColumn"
        '
        'SiVonDataGridViewTextBoxColumn
        '
        Me.SiVonDataGridViewTextBoxColumn.DataPropertyName = "SiVon"
        Me.SiVonDataGridViewTextBoxColumn.HeaderText = "SiVon"
        Me.SiVonDataGridViewTextBoxColumn.Name = "SiVonDataGridViewTextBoxColumn"
        '
        'SiBisDataGridViewTextBoxColumn
        '
        Me.SiBisDataGridViewTextBoxColumn.DataPropertyName = "SiBis"
        Me.SiBisDataGridViewTextBoxColumn.HeaderText = "SiBis"
        Me.SiBisDataGridViewTextBoxColumn.Name = "SiBisDataGridViewTextBoxColumn"
        '
        'LifebeltDataGridViewCheckBoxColumn
        '
        Me.LifebeltDataGridViewCheckBoxColumn.DataPropertyName = "Lifebelt"
        Me.LifebeltDataGridViewCheckBoxColumn.HeaderText = "Lifebelt"
        Me.LifebeltDataGridViewCheckBoxColumn.Name = "LifebeltDataGridViewCheckBoxColumn"
        '
        'FeuerDataGridViewCheckBoxColumn
        '
        Me.FeuerDataGridViewCheckBoxColumn.DataPropertyName = "Feuer"
        Me.FeuerDataGridViewCheckBoxColumn.HeaderText = "Feuer"
        Me.FeuerDataGridViewCheckBoxColumn.Name = "FeuerDataGridViewCheckBoxColumn"
        '
        'GasDataGridViewCheckBoxColumn
        '
        Me.GasDataGridViewCheckBoxColumn.DataPropertyName = "Gas"
        Me.GasDataGridViewCheckBoxColumn.HeaderText = "Gas"
        Me.GasDataGridViewCheckBoxColumn.Name = "GasDataGridViewCheckBoxColumn"
        '
        'RettungsinselDataGridViewCheckBoxColumn
        '
        Me.RettungsinselDataGridViewCheckBoxColumn.DataPropertyName = "Rettungsinsel"
        Me.RettungsinselDataGridViewCheckBoxColumn.HeaderText = "Rettungsinsel"
        Me.RettungsinselDataGridViewCheckBoxColumn.Name = "RettungsinselDataGridViewCheckBoxColumn"
        '
        'SignalmittelDataGridViewCheckBoxColumn
        '
        Me.SignalmittelDataGridViewCheckBoxColumn.DataPropertyName = "Signalmittel"
        Me.SignalmittelDataGridViewCheckBoxColumn.HeaderText = "Signalmittel"
        Me.SignalmittelDataGridViewCheckBoxColumn.Name = "SignalmittelDataGridViewCheckBoxColumn"
        '
        'POBDataGridViewCheckBoxColumn
        '
        Me.POBDataGridViewCheckBoxColumn.DataPropertyName = "POB"
        Me.POBDataGridViewCheckBoxColumn.HeaderText = "POB"
        Me.POBDataGridViewCheckBoxColumn.Name = "POBDataGridViewCheckBoxColumn"
        '
        'GesundheitDataGridViewCheckBoxColumn
        '
        Me.GesundheitDataGridViewCheckBoxColumn.DataPropertyName = "Gesundheit"
        Me.GesundheitDataGridViewCheckBoxColumn.HeaderText = "Gesundheit"
        Me.GesundheitDataGridViewCheckBoxColumn.Name = "GesundheitDataGridViewCheckBoxColumn"
        '
        'DokumentationDataGridViewCheckBoxColumn
        '
        Me.DokumentationDataGridViewCheckBoxColumn.DataPropertyName = "Dokumentation"
        Me.DokumentationDataGridViewCheckBoxColumn.HeaderText = "Dokumentation"
        Me.DokumentationDataGridViewCheckBoxColumn.Name = "DokumentationDataGridViewCheckBoxColumn"
        '
        'InnenDataGridViewCheckBoxColumn
        '
        Me.InnenDataGridViewCheckBoxColumn.DataPropertyName = "Innen"
        Me.InnenDataGridViewCheckBoxColumn.HeaderText = "Innen"
        Me.InnenDataGridViewCheckBoxColumn.Name = "InnenDataGridViewCheckBoxColumn"
        '
        'PantryDataGridViewCheckBoxColumn
        '
        Me.PantryDataGridViewCheckBoxColumn.DataPropertyName = "Pantry"
        Me.PantryDataGridViewCheckBoxColumn.HeaderText = "Pantry"
        Me.PantryDataGridViewCheckBoxColumn.Name = "PantryDataGridViewCheckBoxColumn"
        '
        'EleAnlagenDataGridViewCheckBoxColumn
        '
        Me.EleAnlagenDataGridViewCheckBoxColumn.DataPropertyName = "EleAnlagen"
        Me.EleAnlagenDataGridViewCheckBoxColumn.HeaderText = "EleAnlagen"
        Me.EleAnlagenDataGridViewCheckBoxColumn.Name = "EleAnlagenDataGridViewCheckBoxColumn"
        '
        'SprechfunkDataGridViewCheckBoxColumn
        '
        Me.SprechfunkDataGridViewCheckBoxColumn.DataPropertyName = "Sprechfunk"
        Me.SprechfunkDataGridViewCheckBoxColumn.HeaderText = "Sprechfunk"
        Me.SprechfunkDataGridViewCheckBoxColumn.Name = "SprechfunkDataGridViewCheckBoxColumn"
        '
        'MotorDataGridViewCheckBoxColumn
        '
        Me.MotorDataGridViewCheckBoxColumn.DataPropertyName = "Motor"
        Me.MotorDataGridViewCheckBoxColumn.HeaderText = "Motor"
        Me.MotorDataGridViewCheckBoxColumn.Name = "MotorDataGridViewCheckBoxColumn"
        '
        'SegelDataGridViewCheckBoxColumn
        '
        Me.SegelDataGridViewCheckBoxColumn.DataPropertyName = "Segel"
        Me.SegelDataGridViewCheckBoxColumn.HeaderText = "Segel"
        Me.SegelDataGridViewCheckBoxColumn.Name = "SegelDataGridViewCheckBoxColumn"
        '
        'WasserDataGridViewCheckBoxColumn
        '
        Me.WasserDataGridViewCheckBoxColumn.DataPropertyName = "Wasser"
        Me.WasserDataGridViewCheckBoxColumn.HeaderText = "Wasser"
        Me.WasserDataGridViewCheckBoxColumn.Name = "WasserDataGridViewCheckBoxColumn"
        '
        'AussenDataGridViewCheckBoxColumn
        '
        Me.AussenDataGridViewCheckBoxColumn.DataPropertyName = "Aussen"
        Me.AussenDataGridViewCheckBoxColumn.HeaderText = "Aussen"
        Me.AussenDataGridViewCheckBoxColumn.Name = "AussenDataGridViewCheckBoxColumn"
        '
        'bsSicherheitseinweisung
        '
        Me.bsSicherheitseinweisung.DataMember = "Sicherheitseinweisung"
        Me.bsSicherheitseinweisung.DataSource = Me.DsLogbuch
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn4, Me.ToernbezeichnungDataGridViewTextBoxColumn2, Me.DatumDataGridViewTextBoxColumn, Me.BetrifftDataGridViewTextBoxColumn, Me.DefektDataGridViewTextBoxColumn, Me.AuswirkungDataGridViewTextBoxColumn})
        Me.DataGridView6.DataSource = Me.bsMaengel
        Me.DataGridView6.Location = New System.Drawing.Point(2009, 480)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(323, 106)
        Me.DataGridView6.TabIndex = 8
        '
        'IDDataGridViewTextBoxColumn4
        '
        Me.IDDataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn4.Name = "IDDataGridViewTextBoxColumn4"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn2
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn2.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn2.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn2.Name = "ToernbezeichnungDataGridViewTextBoxColumn2"
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        '
        'BetrifftDataGridViewTextBoxColumn
        '
        Me.BetrifftDataGridViewTextBoxColumn.DataPropertyName = "Betrifft"
        Me.BetrifftDataGridViewTextBoxColumn.HeaderText = "Betrifft"
        Me.BetrifftDataGridViewTextBoxColumn.Name = "BetrifftDataGridViewTextBoxColumn"
        '
        'DefektDataGridViewTextBoxColumn
        '
        Me.DefektDataGridViewTextBoxColumn.DataPropertyName = "Defekt"
        Me.DefektDataGridViewTextBoxColumn.HeaderText = "Defekt"
        Me.DefektDataGridViewTextBoxColumn.Name = "DefektDataGridViewTextBoxColumn"
        '
        'AuswirkungDataGridViewTextBoxColumn
        '
        Me.AuswirkungDataGridViewTextBoxColumn.DataPropertyName = "Auswirkung"
        Me.AuswirkungDataGridViewTextBoxColumn.HeaderText = "Auswirkung"
        Me.AuswirkungDataGridViewTextBoxColumn.Name = "AuswirkungDataGridViewTextBoxColumn"
        '
        'bsMaengel
        '
        Me.bsMaengel.DataMember = "Maengel"
        Me.bsMaengel.DataSource = Me.DsLogbuch
        '
        'DataGridView7
        '
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(2009, 593)
        Me.DataGridView7.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(320, 110)
        Me.DataGridView7.TabIndex = 9
        '
        'DataGridView8
        '
        Me.DataGridView8.AutoGenerateColumns = False
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn6, Me.ToernbezeichnungDataGridViewTextBoxColumn4, Me.DatumDataGridViewTextBoxColumn1, Me.Wetterbericht1DataGridViewTextBoxColumn, Me.Wetterbericht2DataGridViewTextBoxColumn, Me.Wetterbericht3DataGridViewTextBoxColumn, Me.UhrzeitDataGridViewTextBoxColumn, Me.BemerkungenDataGridViewTextBoxColumn, Me.BesonderesDataGridViewTextBoxColumn, Me.ZielAnlegeartDataGridViewTextBoxColumn, Me.ZielGebührDataGridViewTextBoxColumn, Me.ZielMüllDataGridViewCheckBoxColumn, Me.ZielStromDataGridViewCheckBoxColumn, Me.MotorStdAnfangDataGridViewTextBoxColumn, Me.MotorStdEndeDataGridViewTextBoxColumn, Me.KraftstoffgetanktDataGridViewTextBoxColumn, Me.KraffstoffkostenDataGridViewTextBoxColumn, Me.CheckBilgeDataGridViewCheckBoxColumn, Me.WasserTankenDataGridViewCheckBoxColumn, Me.CheckOelDataGridViewCheckBoxColumn, Me.CheckBatterieDataGridViewCheckBoxColumn, Me.AusgangsortDataGridViewTextBoxColumn, Me.ZielortDataGridViewTextBoxColumn})
        Me.DataGridView8.DataSource = Me.bsDokumentation
        Me.DataGridView8.Location = New System.Drawing.Point(2013, 710)
        Me.DataGridView8.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.Size = New System.Drawing.Size(320, 107)
        Me.DataGridView8.TabIndex = 10
        '
        'IDDataGridViewTextBoxColumn6
        '
        Me.IDDataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn6.Name = "IDDataGridViewTextBoxColumn6"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn4
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn4.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn4.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn4.Name = "ToernbezeichnungDataGridViewTextBoxColumn4"
        '
        'DatumDataGridViewTextBoxColumn1
        '
        Me.DatumDataGridViewTextBoxColumn1.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn1.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn1.Name = "DatumDataGridViewTextBoxColumn1"
        '
        'Wetterbericht1DataGridViewTextBoxColumn
        '
        Me.Wetterbericht1DataGridViewTextBoxColumn.DataPropertyName = "Wetterbericht1"
        Me.Wetterbericht1DataGridViewTextBoxColumn.HeaderText = "Wetterbericht1"
        Me.Wetterbericht1DataGridViewTextBoxColumn.Name = "Wetterbericht1DataGridViewTextBoxColumn"
        '
        'Wetterbericht2DataGridViewTextBoxColumn
        '
        Me.Wetterbericht2DataGridViewTextBoxColumn.DataPropertyName = "Wetterbericht2"
        Me.Wetterbericht2DataGridViewTextBoxColumn.HeaderText = "Wetterbericht2"
        Me.Wetterbericht2DataGridViewTextBoxColumn.Name = "Wetterbericht2DataGridViewTextBoxColumn"
        '
        'Wetterbericht3DataGridViewTextBoxColumn
        '
        Me.Wetterbericht3DataGridViewTextBoxColumn.DataPropertyName = "Wetterbericht3"
        Me.Wetterbericht3DataGridViewTextBoxColumn.HeaderText = "Wetterbericht3"
        Me.Wetterbericht3DataGridViewTextBoxColumn.Name = "Wetterbericht3DataGridViewTextBoxColumn"
        '
        'UhrzeitDataGridViewTextBoxColumn
        '
        Me.UhrzeitDataGridViewTextBoxColumn.DataPropertyName = "Uhrzeit"
        Me.UhrzeitDataGridViewTextBoxColumn.HeaderText = "Uhrzeit"
        Me.UhrzeitDataGridViewTextBoxColumn.Name = "UhrzeitDataGridViewTextBoxColumn"
        '
        'BemerkungenDataGridViewTextBoxColumn
        '
        Me.BemerkungenDataGridViewTextBoxColumn.DataPropertyName = "Bemerkungen"
        Me.BemerkungenDataGridViewTextBoxColumn.HeaderText = "Bemerkungen"
        Me.BemerkungenDataGridViewTextBoxColumn.Name = "BemerkungenDataGridViewTextBoxColumn"
        '
        'BesonderesDataGridViewTextBoxColumn
        '
        Me.BesonderesDataGridViewTextBoxColumn.DataPropertyName = "Besonderes"
        Me.BesonderesDataGridViewTextBoxColumn.HeaderText = "Besonderes"
        Me.BesonderesDataGridViewTextBoxColumn.Name = "BesonderesDataGridViewTextBoxColumn"
        '
        'ZielAnlegeartDataGridViewTextBoxColumn
        '
        Me.ZielAnlegeartDataGridViewTextBoxColumn.DataPropertyName = "ZielAnlegeart"
        Me.ZielAnlegeartDataGridViewTextBoxColumn.HeaderText = "ZielAnlegeart"
        Me.ZielAnlegeartDataGridViewTextBoxColumn.Name = "ZielAnlegeartDataGridViewTextBoxColumn"
        '
        'ZielGebührDataGridViewTextBoxColumn
        '
        Me.ZielGebührDataGridViewTextBoxColumn.DataPropertyName = "ZielGebühr"
        Me.ZielGebührDataGridViewTextBoxColumn.HeaderText = "ZielGebühr"
        Me.ZielGebührDataGridViewTextBoxColumn.Name = "ZielGebührDataGridViewTextBoxColumn"
        '
        'ZielMüllDataGridViewCheckBoxColumn
        '
        Me.ZielMüllDataGridViewCheckBoxColumn.DataPropertyName = "ZielMüll"
        Me.ZielMüllDataGridViewCheckBoxColumn.HeaderText = "ZielMüll"
        Me.ZielMüllDataGridViewCheckBoxColumn.Name = "ZielMüllDataGridViewCheckBoxColumn"
        '
        'ZielStromDataGridViewCheckBoxColumn
        '
        Me.ZielStromDataGridViewCheckBoxColumn.DataPropertyName = "ZielStrom"
        Me.ZielStromDataGridViewCheckBoxColumn.HeaderText = "ZielStrom"
        Me.ZielStromDataGridViewCheckBoxColumn.Name = "ZielStromDataGridViewCheckBoxColumn"
        '
        'MotorStdAnfangDataGridViewTextBoxColumn
        '
        Me.MotorStdAnfangDataGridViewTextBoxColumn.DataPropertyName = "MotorStdAnfang"
        Me.MotorStdAnfangDataGridViewTextBoxColumn.HeaderText = "MotorStdAnfang"
        Me.MotorStdAnfangDataGridViewTextBoxColumn.Name = "MotorStdAnfangDataGridViewTextBoxColumn"
        '
        'MotorStdEndeDataGridViewTextBoxColumn
        '
        Me.MotorStdEndeDataGridViewTextBoxColumn.DataPropertyName = "MotorStdEnde"
        Me.MotorStdEndeDataGridViewTextBoxColumn.HeaderText = "MotorStdEnde"
        Me.MotorStdEndeDataGridViewTextBoxColumn.Name = "MotorStdEndeDataGridViewTextBoxColumn"
        '
        'KraftstoffgetanktDataGridViewTextBoxColumn
        '
        Me.KraftstoffgetanktDataGridViewTextBoxColumn.DataPropertyName = "Kraftstoffgetankt"
        Me.KraftstoffgetanktDataGridViewTextBoxColumn.HeaderText = "Kraftstoffgetankt"
        Me.KraftstoffgetanktDataGridViewTextBoxColumn.Name = "KraftstoffgetanktDataGridViewTextBoxColumn"
        '
        'KraffstoffkostenDataGridViewTextBoxColumn
        '
        Me.KraffstoffkostenDataGridViewTextBoxColumn.DataPropertyName = "Kraffstoffkosten"
        Me.KraffstoffkostenDataGridViewTextBoxColumn.HeaderText = "Kraffstoffkosten"
        Me.KraffstoffkostenDataGridViewTextBoxColumn.Name = "KraffstoffkostenDataGridViewTextBoxColumn"
        '
        'CheckBilgeDataGridViewCheckBoxColumn
        '
        Me.CheckBilgeDataGridViewCheckBoxColumn.DataPropertyName = "CheckBilge"
        Me.CheckBilgeDataGridViewCheckBoxColumn.HeaderText = "CheckBilge"
        Me.CheckBilgeDataGridViewCheckBoxColumn.Name = "CheckBilgeDataGridViewCheckBoxColumn"
        '
        'WasserTankenDataGridViewCheckBoxColumn
        '
        Me.WasserTankenDataGridViewCheckBoxColumn.DataPropertyName = "WasserTanken"
        Me.WasserTankenDataGridViewCheckBoxColumn.HeaderText = "WasserTanken"
        Me.WasserTankenDataGridViewCheckBoxColumn.Name = "WasserTankenDataGridViewCheckBoxColumn"
        '
        'CheckOelDataGridViewCheckBoxColumn
        '
        Me.CheckOelDataGridViewCheckBoxColumn.DataPropertyName = "CheckOel"
        Me.CheckOelDataGridViewCheckBoxColumn.HeaderText = "CheckOel"
        Me.CheckOelDataGridViewCheckBoxColumn.Name = "CheckOelDataGridViewCheckBoxColumn"
        '
        'CheckBatterieDataGridViewCheckBoxColumn
        '
        Me.CheckBatterieDataGridViewCheckBoxColumn.DataPropertyName = "CheckBatterie"
        Me.CheckBatterieDataGridViewCheckBoxColumn.HeaderText = "CheckBatterie"
        Me.CheckBatterieDataGridViewCheckBoxColumn.Name = "CheckBatterieDataGridViewCheckBoxColumn"
        '
        'AusgangsortDataGridViewTextBoxColumn
        '
        Me.AusgangsortDataGridViewTextBoxColumn.DataPropertyName = "Ausgangsort"
        Me.AusgangsortDataGridViewTextBoxColumn.HeaderText = "Ausgangsort"
        Me.AusgangsortDataGridViewTextBoxColumn.Name = "AusgangsortDataGridViewTextBoxColumn"
        '
        'ZielortDataGridViewTextBoxColumn
        '
        Me.ZielortDataGridViewTextBoxColumn.DataPropertyName = "Zielort"
        Me.ZielortDataGridViewTextBoxColumn.HeaderText = "Zielort"
        Me.ZielortDataGridViewTextBoxColumn.Name = "ZielortDataGridViewTextBoxColumn"
        '
        'bsDokumentation
        '
        Me.bsDokumentation.DataMember = "Dokumentation"
        Me.bsDokumentation.DataSource = Me.DsLogbuch
        '
        'DataGridView9
        '
        Me.DataGridView9.AutoGenerateColumns = False
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn7, Me.Toern, Me.Person1, Me.Datum1, Me.Person2, Me.Datum2})
        Me.DataGridView9.DataSource = Me.bsWacheplan
        Me.DataGridView9.Location = New System.Drawing.Point(1644, -5)
        Me.DataGridView9.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.Size = New System.Drawing.Size(320, 107)
        Me.DataGridView9.TabIndex = 11
        '
        'IDDataGridViewTextBoxColumn7
        '
        Me.IDDataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn7.Name = "IDDataGridViewTextBoxColumn7"
        '
        'Toern
        '
        Me.Toern.DataPropertyName = "Toern"
        Me.Toern.HeaderText = "Toern"
        Me.Toern.Name = "Toern"
        '
        'Person1
        '
        Me.Person1.DataPropertyName = "Person1"
        Me.Person1.HeaderText = "Person1"
        Me.Person1.Name = "Person1"
        '
        'Datum1
        '
        Me.Datum1.DataPropertyName = "Datum1"
        Me.Datum1.HeaderText = "Datum1"
        Me.Datum1.Name = "Datum1"
        '
        'Person2
        '
        Me.Person2.DataPropertyName = "Person2"
        Me.Person2.HeaderText = "Person2"
        Me.Person2.Name = "Person2"
        '
        'Datum2
        '
        Me.Datum2.DataPropertyName = "Datum2"
        Me.Datum2.HeaderText = "Datum2"
        Me.Datum2.Name = "Datum2"
        '
        'bsWacheplan
        '
        Me.bsWacheplan.DataMember = "Wacheplan"
        Me.bsWacheplan.DataSource = Me.dsToernverwaltung
        '
        'bsLogdaten
        '
        Me.bsLogdaten.DataMember = "Logdaten"
        Me.bsLogdaten.DataSource = Me.DsLogbuch
        '
        'DataGridView10
        '
        Me.DataGridView10.AutoGenerateColumns = False
        Me.DataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView10.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn8, Me.ToernbezeichnungDataGridViewTextBoxColumn5, Me.DatumVonDataGridViewTextBoxColumn1, Me.ZeitVonDataGridViewTextBoxColumn, Me.AusfahrtDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn1, Me.ZeitBisDataGridViewTextBoxColumn, Me.ZielDataGridViewTextBoxColumn, Me.WindrichtungDataGridViewTextBoxColumn1, Me.SmuSegelDataGridViewTextBoxColumn, Me.SmuMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn1, Me.BemerkungDataGridViewTextBoxColumn1, Me.R1DataGridViewTextBoxColumn2, Me.R2DataGridViewTextBoxColumn2, Me.R3DataGridViewTextBoxColumn2, Me.WindstaerkeDataGridViewTextBoxColumn1})
        Me.DataGridView10.DataSource = Me.bsZusammenfassung2
        Me.DataGridView10.Location = New System.Drawing.Point(1684, 135)
        Me.DataGridView10.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView10.Name = "DataGridView10"
        Me.DataGridView10.Size = New System.Drawing.Size(320, 124)
        Me.DataGridView10.TabIndex = 12
        '
        'IDDataGridViewTextBoxColumn8
        '
        Me.IDDataGridViewTextBoxColumn8.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn8.Name = "IDDataGridViewTextBoxColumn8"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn5
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn5.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn5.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn5.Name = "ToernbezeichnungDataGridViewTextBoxColumn5"
        '
        'DatumVonDataGridViewTextBoxColumn1
        '
        Me.DatumVonDataGridViewTextBoxColumn1.DataPropertyName = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn1.HeaderText = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn1.Name = "DatumVonDataGridViewTextBoxColumn1"
        '
        'ZeitVonDataGridViewTextBoxColumn
        '
        Me.ZeitVonDataGridViewTextBoxColumn.DataPropertyName = "ZeitVon"
        Me.ZeitVonDataGridViewTextBoxColumn.HeaderText = "ZeitVon"
        Me.ZeitVonDataGridViewTextBoxColumn.Name = "ZeitVonDataGridViewTextBoxColumn"
        '
        'AusfahrtDataGridViewTextBoxColumn
        '
        Me.AusfahrtDataGridViewTextBoxColumn.DataPropertyName = "Ausfahrt"
        Me.AusfahrtDataGridViewTextBoxColumn.HeaderText = "Ausfahrt"
        Me.AusfahrtDataGridViewTextBoxColumn.Name = "AusfahrtDataGridViewTextBoxColumn"
        '
        'DatumBisDataGridViewTextBoxColumn1
        '
        Me.DatumBisDataGridViewTextBoxColumn1.DataPropertyName = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn1.HeaderText = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn1.Name = "DatumBisDataGridViewTextBoxColumn1"
        '
        'ZeitBisDataGridViewTextBoxColumn
        '
        Me.ZeitBisDataGridViewTextBoxColumn.DataPropertyName = "ZeitBis"
        Me.ZeitBisDataGridViewTextBoxColumn.HeaderText = "ZeitBis"
        Me.ZeitBisDataGridViewTextBoxColumn.Name = "ZeitBisDataGridViewTextBoxColumn"
        '
        'ZielDataGridViewTextBoxColumn
        '
        Me.ZielDataGridViewTextBoxColumn.DataPropertyName = "Ziel"
        Me.ZielDataGridViewTextBoxColumn.HeaderText = "Ziel"
        Me.ZielDataGridViewTextBoxColumn.Name = "ZielDataGridViewTextBoxColumn"
        '
        'WindrichtungDataGridViewTextBoxColumn1
        '
        Me.WindrichtungDataGridViewTextBoxColumn1.DataPropertyName = "Windrichtung"
        Me.WindrichtungDataGridViewTextBoxColumn1.HeaderText = "Windrichtung"
        Me.WindrichtungDataGridViewTextBoxColumn1.Name = "WindrichtungDataGridViewTextBoxColumn1"
        '
        'SmuSegelDataGridViewTextBoxColumn
        '
        Me.SmuSegelDataGridViewTextBoxColumn.DataPropertyName = "SmuSegel"
        Me.SmuSegelDataGridViewTextBoxColumn.HeaderText = "SmuSegel"
        Me.SmuSegelDataGridViewTextBoxColumn.Name = "SmuSegelDataGridViewTextBoxColumn"
        '
        'SmuMotorDataGridViewTextBoxColumn
        '
        Me.SmuMotorDataGridViewTextBoxColumn.DataPropertyName = "SmuMotor"
        Me.SmuMotorDataGridViewTextBoxColumn.HeaderText = "SmuMotor"
        Me.SmuMotorDataGridViewTextBoxColumn.Name = "SmuMotorDataGridViewTextBoxColumn"
        '
        'SmGesamtDataGridViewTextBoxColumn1
        '
        Me.SmGesamtDataGridViewTextBoxColumn1.DataPropertyName = "SmGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn1.HeaderText = "SmGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn1.Name = "SmGesamtDataGridViewTextBoxColumn1"
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'R1DataGridViewTextBoxColumn2
        '
        Me.R1DataGridViewTextBoxColumn2.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn2.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn2.Name = "R1DataGridViewTextBoxColumn2"
        '
        'R2DataGridViewTextBoxColumn2
        '
        Me.R2DataGridViewTextBoxColumn2.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn2.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn2.Name = "R2DataGridViewTextBoxColumn2"
        '
        'R3DataGridViewTextBoxColumn2
        '
        Me.R3DataGridViewTextBoxColumn2.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn2.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn2.Name = "R3DataGridViewTextBoxColumn2"
        '
        'WindstaerkeDataGridViewTextBoxColumn1
        '
        Me.WindstaerkeDataGridViewTextBoxColumn1.DataPropertyName = "Windstaerke"
        Me.WindstaerkeDataGridViewTextBoxColumn1.HeaderText = "Windstaerke"
        Me.WindstaerkeDataGridViewTextBoxColumn1.Name = "WindstaerkeDataGridViewTextBoxColumn1"
        '
        'bsZusammenfassung2
        '
        Me.bsZusammenfassung2.DataMember = "Zusammenfassung2"
        Me.bsZusammenfassung2.DataSource = Me.DsLogbuch
        '
        'DataGridView11
        '
        Me.DataGridView11.AutoGenerateColumns = False
        Me.DataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView11.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn5, Me.ToernbezeichnungDataGridViewTextBoxColumn3, Me.SeemeilenMDataGridViewTextBoxColumn, Me.SeemeilenSDataGridViewTextBoxColumn, Me.MotorStdDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn1, Me.NachtansteuerungenDataGridViewTextBoxColumn1, Me.KartenMissweisungDataGridViewTextBoxColumn, Me.SonnenaufgangDataGridViewTextBoxColumn, Me.SonnenuntergangDataGridViewTextBoxColumn, Me.NavtexstationenDataGridViewTextBoxColumn, Me.VollmondDataGridViewTextBoxColumn, Me.MaxTidenhubDataGridViewTextBoxColumn, Me.SonstigesDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn3, Me.R2DataGridViewTextBoxColumn3, Me.R3DataGridViewTextBoxColumn3, Me.GeplanteRouteDataGridViewTextBoxColumn, Me.KassaManagerDataGridViewTextBoxColumn, Me.ErsteinzahlungDataGridViewTextBoxColumn, Me.PantryManagerDataGridViewTextBoxColumn, Me.ErsteinkaufDataGridViewTextBoxColumn, Me.RevierBildDataGridViewTextBoxColumn, Me.GefahreneRouteDataGridViewTextBoxColumn})
        Me.DataGridView11.DataSource = Me.bsToerndaten
        Me.DataGridView11.Location = New System.Drawing.Point(1684, 267)
        Me.DataGridView11.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView11.Name = "DataGridView11"
        Me.DataGridView11.Size = New System.Drawing.Size(320, 112)
        Me.DataGridView11.TabIndex = 13
        '
        'IDDataGridViewTextBoxColumn5
        '
        Me.IDDataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn5.Name = "IDDataGridViewTextBoxColumn5"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn3
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn3.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn3.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn3.Name = "ToernbezeichnungDataGridViewTextBoxColumn3"
        '
        'SeemeilenMDataGridViewTextBoxColumn
        '
        Me.SeemeilenMDataGridViewTextBoxColumn.DataPropertyName = "SeemeilenM"
        Me.SeemeilenMDataGridViewTextBoxColumn.HeaderText = "SeemeilenM"
        Me.SeemeilenMDataGridViewTextBoxColumn.Name = "SeemeilenMDataGridViewTextBoxColumn"
        '
        'SeemeilenSDataGridViewTextBoxColumn
        '
        Me.SeemeilenSDataGridViewTextBoxColumn.DataPropertyName = "SeemeilenS"
        Me.SeemeilenSDataGridViewTextBoxColumn.HeaderText = "SeemeilenS"
        Me.SeemeilenSDataGridViewTextBoxColumn.Name = "SeemeilenSDataGridViewTextBoxColumn"
        '
        'MotorStdDataGridViewTextBoxColumn
        '
        Me.MotorStdDataGridViewTextBoxColumn.DataPropertyName = "MotorStd"
        Me.MotorStdDataGridViewTextBoxColumn.HeaderText = "MotorStd"
        Me.MotorStdDataGridViewTextBoxColumn.Name = "MotorStdDataGridViewTextBoxColumn"
        '
        'NachtfahrtenDataGridViewTextBoxColumn1
        '
        Me.NachtfahrtenDataGridViewTextBoxColumn1.DataPropertyName = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn1.HeaderText = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn1.Name = "NachtfahrtenDataGridViewTextBoxColumn1"
        '
        'NachtansteuerungenDataGridViewTextBoxColumn1
        '
        Me.NachtansteuerungenDataGridViewTextBoxColumn1.DataPropertyName = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn1.HeaderText = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn1.Name = "NachtansteuerungenDataGridViewTextBoxColumn1"
        '
        'KartenMissweisungDataGridViewTextBoxColumn
        '
        Me.KartenMissweisungDataGridViewTextBoxColumn.DataPropertyName = "KartenMissweisung"
        Me.KartenMissweisungDataGridViewTextBoxColumn.HeaderText = "KartenMissweisung"
        Me.KartenMissweisungDataGridViewTextBoxColumn.Name = "KartenMissweisungDataGridViewTextBoxColumn"
        '
        'SonnenaufgangDataGridViewTextBoxColumn
        '
        Me.SonnenaufgangDataGridViewTextBoxColumn.DataPropertyName = "Sonnenaufgang"
        Me.SonnenaufgangDataGridViewTextBoxColumn.HeaderText = "Sonnenaufgang"
        Me.SonnenaufgangDataGridViewTextBoxColumn.Name = "SonnenaufgangDataGridViewTextBoxColumn"
        '
        'SonnenuntergangDataGridViewTextBoxColumn
        '
        Me.SonnenuntergangDataGridViewTextBoxColumn.DataPropertyName = "Sonnenuntergang"
        Me.SonnenuntergangDataGridViewTextBoxColumn.HeaderText = "Sonnenuntergang"
        Me.SonnenuntergangDataGridViewTextBoxColumn.Name = "SonnenuntergangDataGridViewTextBoxColumn"
        '
        'NavtexstationenDataGridViewTextBoxColumn
        '
        Me.NavtexstationenDataGridViewTextBoxColumn.DataPropertyName = "Navtexstationen"
        Me.NavtexstationenDataGridViewTextBoxColumn.HeaderText = "Navtexstationen"
        Me.NavtexstationenDataGridViewTextBoxColumn.Name = "NavtexstationenDataGridViewTextBoxColumn"
        '
        'VollmondDataGridViewTextBoxColumn
        '
        Me.VollmondDataGridViewTextBoxColumn.DataPropertyName = "Vollmond"
        Me.VollmondDataGridViewTextBoxColumn.HeaderText = "Vollmond"
        Me.VollmondDataGridViewTextBoxColumn.Name = "VollmondDataGridViewTextBoxColumn"
        '
        'MaxTidenhubDataGridViewTextBoxColumn
        '
        Me.MaxTidenhubDataGridViewTextBoxColumn.DataPropertyName = "MaxTidenhub"
        Me.MaxTidenhubDataGridViewTextBoxColumn.HeaderText = "MaxTidenhub"
        Me.MaxTidenhubDataGridViewTextBoxColumn.Name = "MaxTidenhubDataGridViewTextBoxColumn"
        '
        'SonstigesDataGridViewTextBoxColumn
        '
        Me.SonstigesDataGridViewTextBoxColumn.DataPropertyName = "Sonstiges"
        Me.SonstigesDataGridViewTextBoxColumn.HeaderText = "Sonstiges"
        Me.SonstigesDataGridViewTextBoxColumn.Name = "SonstigesDataGridViewTextBoxColumn"
        '
        'R1DataGridViewTextBoxColumn3
        '
        Me.R1DataGridViewTextBoxColumn3.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn3.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn3.Name = "R1DataGridViewTextBoxColumn3"
        '
        'R2DataGridViewTextBoxColumn3
        '
        Me.R2DataGridViewTextBoxColumn3.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn3.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn3.Name = "R2DataGridViewTextBoxColumn3"
        '
        'R3DataGridViewTextBoxColumn3
        '
        Me.R3DataGridViewTextBoxColumn3.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn3.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn3.Name = "R3DataGridViewTextBoxColumn3"
        '
        'GeplanteRouteDataGridViewTextBoxColumn
        '
        Me.GeplanteRouteDataGridViewTextBoxColumn.DataPropertyName = "GeplanteRoute"
        Me.GeplanteRouteDataGridViewTextBoxColumn.HeaderText = "GeplanteRoute"
        Me.GeplanteRouteDataGridViewTextBoxColumn.Name = "GeplanteRouteDataGridViewTextBoxColumn"
        '
        'KassaManagerDataGridViewTextBoxColumn
        '
        Me.KassaManagerDataGridViewTextBoxColumn.DataPropertyName = "KassaManager"
        Me.KassaManagerDataGridViewTextBoxColumn.HeaderText = "KassaManager"
        Me.KassaManagerDataGridViewTextBoxColumn.Name = "KassaManagerDataGridViewTextBoxColumn"
        '
        'ErsteinzahlungDataGridViewTextBoxColumn
        '
        Me.ErsteinzahlungDataGridViewTextBoxColumn.DataPropertyName = "Ersteinzahlung"
        Me.ErsteinzahlungDataGridViewTextBoxColumn.HeaderText = "Ersteinzahlung"
        Me.ErsteinzahlungDataGridViewTextBoxColumn.Name = "ErsteinzahlungDataGridViewTextBoxColumn"
        '
        'PantryManagerDataGridViewTextBoxColumn
        '
        Me.PantryManagerDataGridViewTextBoxColumn.DataPropertyName = "PantryManager"
        Me.PantryManagerDataGridViewTextBoxColumn.HeaderText = "PantryManager"
        Me.PantryManagerDataGridViewTextBoxColumn.Name = "PantryManagerDataGridViewTextBoxColumn"
        '
        'ErsteinkaufDataGridViewTextBoxColumn
        '
        Me.ErsteinkaufDataGridViewTextBoxColumn.DataPropertyName = "Ersteinkauf"
        Me.ErsteinkaufDataGridViewTextBoxColumn.HeaderText = "Ersteinkauf"
        Me.ErsteinkaufDataGridViewTextBoxColumn.Name = "ErsteinkaufDataGridViewTextBoxColumn"
        '
        'RevierBildDataGridViewTextBoxColumn
        '
        Me.RevierBildDataGridViewTextBoxColumn.DataPropertyName = "RevierBild"
        Me.RevierBildDataGridViewTextBoxColumn.HeaderText = "RevierBild"
        Me.RevierBildDataGridViewTextBoxColumn.Name = "RevierBildDataGridViewTextBoxColumn"
        '
        'GefahreneRouteDataGridViewTextBoxColumn
        '
        Me.GefahreneRouteDataGridViewTextBoxColumn.DataPropertyName = "GefahreneRoute"
        Me.GefahreneRouteDataGridViewTextBoxColumn.HeaderText = "GefahreneRoute"
        Me.GefahreneRouteDataGridViewTextBoxColumn.Name = "GefahreneRouteDataGridViewTextBoxColumn"
        '
        'bsToerndaten
        '
        Me.bsToerndaten.DataMember = "Toerndaten"
        Me.bsToerndaten.DataSource = Me.DsLogbuch
        '
        'DataGridView12
        '
        Me.DataGridView12.AutoGenerateColumns = False
        Me.DataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView12.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn10, Me.ToernDataGridViewTextBoxColumn1, Me.Person1DataGridViewTextBoxColumn, Me.Person2DataGridViewTextBoxColumn, Me.SynchronDataGridViewCheckBoxColumn, Me.MethodeDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn3, Me.TextVonDataGridViewTextBoxColumn, Me.TextBisDataGridViewTextBoxColumn})
        Me.DataGridView12.DataSource = Me.bsLogWacheplan
        Me.DataGridView12.Location = New System.Drawing.Point(1684, 386)
        Me.DataGridView12.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView12.Name = "DataGridView12"
        Me.DataGridView12.Size = New System.Drawing.Size(320, 113)
        Me.DataGridView12.TabIndex = 14
        '
        'IDDataGridViewTextBoxColumn10
        '
        Me.IDDataGridViewTextBoxColumn10.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn10.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn10.Name = "IDDataGridViewTextBoxColumn10"
        '
        'ToernDataGridViewTextBoxColumn1
        '
        Me.ToernDataGridViewTextBoxColumn1.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.Name = "ToernDataGridViewTextBoxColumn1"
        '
        'Person1DataGridViewTextBoxColumn
        '
        Me.Person1DataGridViewTextBoxColumn.DataPropertyName = "Person1"
        Me.Person1DataGridViewTextBoxColumn.HeaderText = "Person1"
        Me.Person1DataGridViewTextBoxColumn.Name = "Person1DataGridViewTextBoxColumn"
        '
        'Person2DataGridViewTextBoxColumn
        '
        Me.Person2DataGridViewTextBoxColumn.DataPropertyName = "Person2"
        Me.Person2DataGridViewTextBoxColumn.HeaderText = "Person2"
        Me.Person2DataGridViewTextBoxColumn.Name = "Person2DataGridViewTextBoxColumn"
        '
        'SynchronDataGridViewCheckBoxColumn
        '
        Me.SynchronDataGridViewCheckBoxColumn.DataPropertyName = "Synchron"
        Me.SynchronDataGridViewCheckBoxColumn.HeaderText = "Synchron"
        Me.SynchronDataGridViewCheckBoxColumn.Name = "SynchronDataGridViewCheckBoxColumn"
        '
        'MethodeDataGridViewTextBoxColumn
        '
        Me.MethodeDataGridViewTextBoxColumn.DataPropertyName = "Methode"
        Me.MethodeDataGridViewTextBoxColumn.HeaderText = "Methode"
        Me.MethodeDataGridViewTextBoxColumn.Name = "MethodeDataGridViewTextBoxColumn"
        '
        'DatumDataGridViewTextBoxColumn3
        '
        Me.DatumDataGridViewTextBoxColumn3.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn3.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn3.Name = "DatumDataGridViewTextBoxColumn3"
        '
        'TextVonDataGridViewTextBoxColumn
        '
        Me.TextVonDataGridViewTextBoxColumn.DataPropertyName = "TextVon"
        Me.TextVonDataGridViewTextBoxColumn.HeaderText = "TextVon"
        Me.TextVonDataGridViewTextBoxColumn.Name = "TextVonDataGridViewTextBoxColumn"
        '
        'TextBisDataGridViewTextBoxColumn
        '
        Me.TextBisDataGridViewTextBoxColumn.DataPropertyName = "TextBis"
        Me.TextBisDataGridViewTextBoxColumn.HeaderText = "TextBis"
        Me.TextBisDataGridViewTextBoxColumn.Name = "TextBisDataGridViewTextBoxColumn"
        '
        'bsLogWacheplan
        '
        Me.bsLogWacheplan.DataMember = "LogWacheplan"
        Me.bsLogWacheplan.DataSource = Me.DsLogbuch
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn11, Me.Feld0DataGridViewTextBoxColumn, Me.Feld1DataGridViewTextBoxColumn, Me.Feld2DataGridViewTextBoxColumn, Me.Feld3DataGridViewTextBoxColumn, Me.Feld4DataGridViewTextBoxColumn, Me.Feld5DataGridViewTextBoxColumn, Me.Feld6DataGridViewTextBoxColumn, Me.Feld7DataGridViewTextBoxColumn, Me.Feld8DataGridViewTextBoxColumn, Me.Feld9DataGridViewTextBoxColumn, Me.Feld10DataGridViewTextBoxColumn, Me.Feld11DataGridViewTextBoxColumn, Me.Feld12DataGridViewTextBoxColumn, Me.Feld13DataGridViewTextBoxColumn, Me.Feld14DataGridViewTextBoxColumn, Me.Feld15DataGridViewTextBoxColumn, Me.Feld16DataGridViewTextBoxColumn, Me.Feld17DataGridViewTextBoxColumn, Me.Feld18DataGridViewTextBoxColumn, Me.Feld19DataGridViewTextBoxColumn, Me.Feld20DataGridViewTextBoxColumn, Me.Feld21DataGridViewTextBoxColumn, Me.Feld22DataGridViewTextBoxColumn, Me.Feld23DataGridViewTextBoxColumn, Me.Feld24DataGridViewTextBoxColumn, Me.Feld25DataGridViewTextBoxColumn, Me.Feld26DataGridViewCheckBoxColumn, Me.Feld27DataGridViewCheckBoxColumn, Me.Feld28DataGridViewCheckBoxColumn, Me.Feld29DataGridViewCheckBoxColumn, Me.Feld30DataGridViewCheckBoxColumn, Me.Feld31DataGridViewCheckBoxColumn, Me.Feld32DataGridViewTextBoxColumn, Me.Feld33DataGridViewTextBoxColumn, Me.Feld34DataGridViewTextBoxColumn, Me.Feld35DataGridViewTextBoxColumn, Me.Feld36DataGridViewTextBoxColumn, Me.Feld37DataGridViewTextBoxColumn, Me.Feld38DataGridViewTextBoxColumn, Me.Feld39DataGridViewTextBoxColumn, Me.Feld40DataGridViewTextBoxColumn, Me.Feld41DataGridViewTextBoxColumn, Me.Feld42DataGridViewTextBoxColumn, Me.Feld43DataGridViewTextBoxColumn, Me.Feld44DataGridViewTextBoxColumn, Me.Feld45DataGridViewTextBoxColumn, Me.Feld46DataGridViewTextBoxColumn, Me.Feld47DataGridViewTextBoxColumn, Me.Feld48DataGridViewTextBoxColumn, Me.Feld49DataGridViewTextBoxColumn, Me.Feld50DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsTemp
        Me.DataGridView1.Location = New System.Drawing.Point(1261, 1)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 101)
        Me.DataGridView1.TabIndex = 15
        '
        'IDDataGridViewTextBoxColumn11
        '
        Me.IDDataGridViewTextBoxColumn11.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn11.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn11.Name = "IDDataGridViewTextBoxColumn11"
        '
        'Feld0DataGridViewTextBoxColumn
        '
        Me.Feld0DataGridViewTextBoxColumn.DataPropertyName = "Feld0"
        Me.Feld0DataGridViewTextBoxColumn.HeaderText = "Feld0"
        Me.Feld0DataGridViewTextBoxColumn.Name = "Feld0DataGridViewTextBoxColumn"
        '
        'Feld1DataGridViewTextBoxColumn
        '
        Me.Feld1DataGridViewTextBoxColumn.DataPropertyName = "Feld1"
        Me.Feld1DataGridViewTextBoxColumn.HeaderText = "Feld1"
        Me.Feld1DataGridViewTextBoxColumn.Name = "Feld1DataGridViewTextBoxColumn"
        '
        'Feld2DataGridViewTextBoxColumn
        '
        Me.Feld2DataGridViewTextBoxColumn.DataPropertyName = "Feld2"
        Me.Feld2DataGridViewTextBoxColumn.HeaderText = "Feld2"
        Me.Feld2DataGridViewTextBoxColumn.Name = "Feld2DataGridViewTextBoxColumn"
        '
        'Feld3DataGridViewTextBoxColumn
        '
        Me.Feld3DataGridViewTextBoxColumn.DataPropertyName = "Feld3"
        Me.Feld3DataGridViewTextBoxColumn.HeaderText = "Feld3"
        Me.Feld3DataGridViewTextBoxColumn.Name = "Feld3DataGridViewTextBoxColumn"
        '
        'Feld4DataGridViewTextBoxColumn
        '
        Me.Feld4DataGridViewTextBoxColumn.DataPropertyName = "Feld4"
        Me.Feld4DataGridViewTextBoxColumn.HeaderText = "Feld4"
        Me.Feld4DataGridViewTextBoxColumn.Name = "Feld4DataGridViewTextBoxColumn"
        '
        'Feld5DataGridViewTextBoxColumn
        '
        Me.Feld5DataGridViewTextBoxColumn.DataPropertyName = "Feld5"
        Me.Feld5DataGridViewTextBoxColumn.HeaderText = "Feld5"
        Me.Feld5DataGridViewTextBoxColumn.Name = "Feld5DataGridViewTextBoxColumn"
        '
        'Feld6DataGridViewTextBoxColumn
        '
        Me.Feld6DataGridViewTextBoxColumn.DataPropertyName = "Feld6"
        Me.Feld6DataGridViewTextBoxColumn.HeaderText = "Feld6"
        Me.Feld6DataGridViewTextBoxColumn.Name = "Feld6DataGridViewTextBoxColumn"
        '
        'Feld7DataGridViewTextBoxColumn
        '
        Me.Feld7DataGridViewTextBoxColumn.DataPropertyName = "Feld7"
        Me.Feld7DataGridViewTextBoxColumn.HeaderText = "Feld7"
        Me.Feld7DataGridViewTextBoxColumn.Name = "Feld7DataGridViewTextBoxColumn"
        '
        'Feld8DataGridViewTextBoxColumn
        '
        Me.Feld8DataGridViewTextBoxColumn.DataPropertyName = "Feld8"
        Me.Feld8DataGridViewTextBoxColumn.HeaderText = "Feld8"
        Me.Feld8DataGridViewTextBoxColumn.Name = "Feld8DataGridViewTextBoxColumn"
        '
        'Feld9DataGridViewTextBoxColumn
        '
        Me.Feld9DataGridViewTextBoxColumn.DataPropertyName = "Feld9"
        Me.Feld9DataGridViewTextBoxColumn.HeaderText = "Feld9"
        Me.Feld9DataGridViewTextBoxColumn.Name = "Feld9DataGridViewTextBoxColumn"
        '
        'Feld10DataGridViewTextBoxColumn
        '
        Me.Feld10DataGridViewTextBoxColumn.DataPropertyName = "Feld10"
        Me.Feld10DataGridViewTextBoxColumn.HeaderText = "Feld10"
        Me.Feld10DataGridViewTextBoxColumn.Name = "Feld10DataGridViewTextBoxColumn"
        '
        'Feld11DataGridViewTextBoxColumn
        '
        Me.Feld11DataGridViewTextBoxColumn.DataPropertyName = "Feld11"
        Me.Feld11DataGridViewTextBoxColumn.HeaderText = "Feld11"
        Me.Feld11DataGridViewTextBoxColumn.Name = "Feld11DataGridViewTextBoxColumn"
        '
        'Feld12DataGridViewTextBoxColumn
        '
        Me.Feld12DataGridViewTextBoxColumn.DataPropertyName = "Feld12"
        Me.Feld12DataGridViewTextBoxColumn.HeaderText = "Feld12"
        Me.Feld12DataGridViewTextBoxColumn.Name = "Feld12DataGridViewTextBoxColumn"
        '
        'Feld13DataGridViewTextBoxColumn
        '
        Me.Feld13DataGridViewTextBoxColumn.DataPropertyName = "Feld13"
        Me.Feld13DataGridViewTextBoxColumn.HeaderText = "Feld13"
        Me.Feld13DataGridViewTextBoxColumn.Name = "Feld13DataGridViewTextBoxColumn"
        '
        'Feld14DataGridViewTextBoxColumn
        '
        Me.Feld14DataGridViewTextBoxColumn.DataPropertyName = "Feld14"
        Me.Feld14DataGridViewTextBoxColumn.HeaderText = "Feld14"
        Me.Feld14DataGridViewTextBoxColumn.Name = "Feld14DataGridViewTextBoxColumn"
        '
        'Feld15DataGridViewTextBoxColumn
        '
        Me.Feld15DataGridViewTextBoxColumn.DataPropertyName = "Feld15"
        Me.Feld15DataGridViewTextBoxColumn.HeaderText = "Feld15"
        Me.Feld15DataGridViewTextBoxColumn.Name = "Feld15DataGridViewTextBoxColumn"
        '
        'Feld16DataGridViewTextBoxColumn
        '
        Me.Feld16DataGridViewTextBoxColumn.DataPropertyName = "Feld16"
        Me.Feld16DataGridViewTextBoxColumn.HeaderText = "Feld16"
        Me.Feld16DataGridViewTextBoxColumn.Name = "Feld16DataGridViewTextBoxColumn"
        '
        'Feld17DataGridViewTextBoxColumn
        '
        Me.Feld17DataGridViewTextBoxColumn.DataPropertyName = "Feld17"
        Me.Feld17DataGridViewTextBoxColumn.HeaderText = "Feld17"
        Me.Feld17DataGridViewTextBoxColumn.Name = "Feld17DataGridViewTextBoxColumn"
        '
        'Feld18DataGridViewTextBoxColumn
        '
        Me.Feld18DataGridViewTextBoxColumn.DataPropertyName = "Feld18"
        Me.Feld18DataGridViewTextBoxColumn.HeaderText = "Feld18"
        Me.Feld18DataGridViewTextBoxColumn.Name = "Feld18DataGridViewTextBoxColumn"
        '
        'Feld19DataGridViewTextBoxColumn
        '
        Me.Feld19DataGridViewTextBoxColumn.DataPropertyName = "Feld19"
        Me.Feld19DataGridViewTextBoxColumn.HeaderText = "Feld19"
        Me.Feld19DataGridViewTextBoxColumn.Name = "Feld19DataGridViewTextBoxColumn"
        '
        'Feld20DataGridViewTextBoxColumn
        '
        Me.Feld20DataGridViewTextBoxColumn.DataPropertyName = "Feld20"
        Me.Feld20DataGridViewTextBoxColumn.HeaderText = "Feld20"
        Me.Feld20DataGridViewTextBoxColumn.Name = "Feld20DataGridViewTextBoxColumn"
        '
        'Feld21DataGridViewTextBoxColumn
        '
        Me.Feld21DataGridViewTextBoxColumn.DataPropertyName = "feld21"
        Me.Feld21DataGridViewTextBoxColumn.HeaderText = "feld21"
        Me.Feld21DataGridViewTextBoxColumn.Name = "Feld21DataGridViewTextBoxColumn"
        '
        'Feld22DataGridViewTextBoxColumn
        '
        Me.Feld22DataGridViewTextBoxColumn.DataPropertyName = "feld22"
        Me.Feld22DataGridViewTextBoxColumn.HeaderText = "feld22"
        Me.Feld22DataGridViewTextBoxColumn.Name = "Feld22DataGridViewTextBoxColumn"
        '
        'Feld23DataGridViewTextBoxColumn
        '
        Me.Feld23DataGridViewTextBoxColumn.DataPropertyName = "feld23"
        Me.Feld23DataGridViewTextBoxColumn.HeaderText = "feld23"
        Me.Feld23DataGridViewTextBoxColumn.Name = "Feld23DataGridViewTextBoxColumn"
        '
        'Feld24DataGridViewTextBoxColumn
        '
        Me.Feld24DataGridViewTextBoxColumn.DataPropertyName = "feld24"
        Me.Feld24DataGridViewTextBoxColumn.HeaderText = "feld24"
        Me.Feld24DataGridViewTextBoxColumn.Name = "Feld24DataGridViewTextBoxColumn"
        '
        'Feld25DataGridViewTextBoxColumn
        '
        Me.Feld25DataGridViewTextBoxColumn.DataPropertyName = "feld25"
        Me.Feld25DataGridViewTextBoxColumn.HeaderText = "feld25"
        Me.Feld25DataGridViewTextBoxColumn.Name = "Feld25DataGridViewTextBoxColumn"
        '
        'Feld26DataGridViewCheckBoxColumn
        '
        Me.Feld26DataGridViewCheckBoxColumn.DataPropertyName = "feld26"
        Me.Feld26DataGridViewCheckBoxColumn.HeaderText = "feld26"
        Me.Feld26DataGridViewCheckBoxColumn.Name = "Feld26DataGridViewCheckBoxColumn"
        '
        'Feld27DataGridViewCheckBoxColumn
        '
        Me.Feld27DataGridViewCheckBoxColumn.DataPropertyName = "feld27"
        Me.Feld27DataGridViewCheckBoxColumn.HeaderText = "feld27"
        Me.Feld27DataGridViewCheckBoxColumn.Name = "Feld27DataGridViewCheckBoxColumn"
        '
        'Feld28DataGridViewCheckBoxColumn
        '
        Me.Feld28DataGridViewCheckBoxColumn.DataPropertyName = "feld28"
        Me.Feld28DataGridViewCheckBoxColumn.HeaderText = "feld28"
        Me.Feld28DataGridViewCheckBoxColumn.Name = "Feld28DataGridViewCheckBoxColumn"
        '
        'Feld29DataGridViewCheckBoxColumn
        '
        Me.Feld29DataGridViewCheckBoxColumn.DataPropertyName = "Feld29"
        Me.Feld29DataGridViewCheckBoxColumn.HeaderText = "Feld29"
        Me.Feld29DataGridViewCheckBoxColumn.Name = "Feld29DataGridViewCheckBoxColumn"
        '
        'Feld30DataGridViewCheckBoxColumn
        '
        Me.Feld30DataGridViewCheckBoxColumn.DataPropertyName = "Feld30"
        Me.Feld30DataGridViewCheckBoxColumn.HeaderText = "Feld30"
        Me.Feld30DataGridViewCheckBoxColumn.Name = "Feld30DataGridViewCheckBoxColumn"
        '
        'Feld31DataGridViewCheckBoxColumn
        '
        Me.Feld31DataGridViewCheckBoxColumn.DataPropertyName = "Feld31"
        Me.Feld31DataGridViewCheckBoxColumn.HeaderText = "Feld31"
        Me.Feld31DataGridViewCheckBoxColumn.Name = "Feld31DataGridViewCheckBoxColumn"
        '
        'Feld32DataGridViewTextBoxColumn
        '
        Me.Feld32DataGridViewTextBoxColumn.DataPropertyName = "Feld32"
        Me.Feld32DataGridViewTextBoxColumn.HeaderText = "Feld32"
        Me.Feld32DataGridViewTextBoxColumn.Name = "Feld32DataGridViewTextBoxColumn"
        '
        'Feld33DataGridViewTextBoxColumn
        '
        Me.Feld33DataGridViewTextBoxColumn.DataPropertyName = "Feld33"
        Me.Feld33DataGridViewTextBoxColumn.HeaderText = "Feld33"
        Me.Feld33DataGridViewTextBoxColumn.Name = "Feld33DataGridViewTextBoxColumn"
        '
        'Feld34DataGridViewTextBoxColumn
        '
        Me.Feld34DataGridViewTextBoxColumn.DataPropertyName = "Feld34"
        Me.Feld34DataGridViewTextBoxColumn.HeaderText = "Feld34"
        Me.Feld34DataGridViewTextBoxColumn.Name = "Feld34DataGridViewTextBoxColumn"
        '
        'Feld35DataGridViewTextBoxColumn
        '
        Me.Feld35DataGridViewTextBoxColumn.DataPropertyName = "Feld35"
        Me.Feld35DataGridViewTextBoxColumn.HeaderText = "Feld35"
        Me.Feld35DataGridViewTextBoxColumn.Name = "Feld35DataGridViewTextBoxColumn"
        '
        'Feld36DataGridViewTextBoxColumn
        '
        Me.Feld36DataGridViewTextBoxColumn.DataPropertyName = "Feld36"
        Me.Feld36DataGridViewTextBoxColumn.HeaderText = "Feld36"
        Me.Feld36DataGridViewTextBoxColumn.Name = "Feld36DataGridViewTextBoxColumn"
        '
        'Feld37DataGridViewTextBoxColumn
        '
        Me.Feld37DataGridViewTextBoxColumn.DataPropertyName = "Feld37"
        Me.Feld37DataGridViewTextBoxColumn.HeaderText = "Feld37"
        Me.Feld37DataGridViewTextBoxColumn.Name = "Feld37DataGridViewTextBoxColumn"
        '
        'Feld38DataGridViewTextBoxColumn
        '
        Me.Feld38DataGridViewTextBoxColumn.DataPropertyName = "Feld38"
        Me.Feld38DataGridViewTextBoxColumn.HeaderText = "Feld38"
        Me.Feld38DataGridViewTextBoxColumn.Name = "Feld38DataGridViewTextBoxColumn"
        '
        'Feld39DataGridViewTextBoxColumn
        '
        Me.Feld39DataGridViewTextBoxColumn.DataPropertyName = "Feld39"
        Me.Feld39DataGridViewTextBoxColumn.HeaderText = "Feld39"
        Me.Feld39DataGridViewTextBoxColumn.Name = "Feld39DataGridViewTextBoxColumn"
        '
        'Feld40DataGridViewTextBoxColumn
        '
        Me.Feld40DataGridViewTextBoxColumn.DataPropertyName = "Feld40"
        Me.Feld40DataGridViewTextBoxColumn.HeaderText = "Feld40"
        Me.Feld40DataGridViewTextBoxColumn.Name = "Feld40DataGridViewTextBoxColumn"
        '
        'Feld41DataGridViewTextBoxColumn
        '
        Me.Feld41DataGridViewTextBoxColumn.DataPropertyName = "Feld41"
        Me.Feld41DataGridViewTextBoxColumn.HeaderText = "Feld41"
        Me.Feld41DataGridViewTextBoxColumn.Name = "Feld41DataGridViewTextBoxColumn"
        '
        'Feld42DataGridViewTextBoxColumn
        '
        Me.Feld42DataGridViewTextBoxColumn.DataPropertyName = "Feld42"
        Me.Feld42DataGridViewTextBoxColumn.HeaderText = "Feld42"
        Me.Feld42DataGridViewTextBoxColumn.Name = "Feld42DataGridViewTextBoxColumn"
        '
        'Feld43DataGridViewTextBoxColumn
        '
        Me.Feld43DataGridViewTextBoxColumn.DataPropertyName = "Feld43"
        Me.Feld43DataGridViewTextBoxColumn.HeaderText = "Feld43"
        Me.Feld43DataGridViewTextBoxColumn.Name = "Feld43DataGridViewTextBoxColumn"
        '
        'Feld44DataGridViewTextBoxColumn
        '
        Me.Feld44DataGridViewTextBoxColumn.DataPropertyName = "Feld44"
        Me.Feld44DataGridViewTextBoxColumn.HeaderText = "Feld44"
        Me.Feld44DataGridViewTextBoxColumn.Name = "Feld44DataGridViewTextBoxColumn"
        '
        'Feld45DataGridViewTextBoxColumn
        '
        Me.Feld45DataGridViewTextBoxColumn.DataPropertyName = "Feld45"
        Me.Feld45DataGridViewTextBoxColumn.HeaderText = "Feld45"
        Me.Feld45DataGridViewTextBoxColumn.Name = "Feld45DataGridViewTextBoxColumn"
        '
        'Feld46DataGridViewTextBoxColumn
        '
        Me.Feld46DataGridViewTextBoxColumn.DataPropertyName = "Feld46"
        Me.Feld46DataGridViewTextBoxColumn.HeaderText = "Feld46"
        Me.Feld46DataGridViewTextBoxColumn.Name = "Feld46DataGridViewTextBoxColumn"
        '
        'Feld47DataGridViewTextBoxColumn
        '
        Me.Feld47DataGridViewTextBoxColumn.DataPropertyName = "Feld47"
        Me.Feld47DataGridViewTextBoxColumn.HeaderText = "Feld47"
        Me.Feld47DataGridViewTextBoxColumn.Name = "Feld47DataGridViewTextBoxColumn"
        '
        'Feld48DataGridViewTextBoxColumn
        '
        Me.Feld48DataGridViewTextBoxColumn.DataPropertyName = "Feld48"
        Me.Feld48DataGridViewTextBoxColumn.HeaderText = "Feld48"
        Me.Feld48DataGridViewTextBoxColumn.Name = "Feld48DataGridViewTextBoxColumn"
        '
        'Feld49DataGridViewTextBoxColumn
        '
        Me.Feld49DataGridViewTextBoxColumn.DataPropertyName = "Feld49"
        Me.Feld49DataGridViewTextBoxColumn.HeaderText = "Feld49"
        Me.Feld49DataGridViewTextBoxColumn.Name = "Feld49DataGridViewTextBoxColumn"
        '
        'Feld50DataGridViewTextBoxColumn
        '
        Me.Feld50DataGridViewTextBoxColumn.DataPropertyName = "Feld50"
        Me.Feld50DataGridViewTextBoxColumn.HeaderText = "Feld50"
        Me.Feld50DataGridViewTextBoxColumn.Name = "Feld50DataGridViewTextBoxColumn"
        '
        'bsTemp
        '
        Me.bsTemp.DataMember = "Temp"
        Me.bsTemp.DataSource = Me.DsLogbuch
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld1", True))
        Me.TextBox2.Location = New System.Drawing.Point(1261, 151)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld2", True))
        Me.TextBox3.Location = New System.Drawing.Point(1261, 185)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld3", True))
        Me.TextBox4.Location = New System.Drawing.Point(1261, 218)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 22)
        Me.TextBox4.TabIndex = 18
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld4", True))
        Me.TextBox5.Location = New System.Drawing.Point(1261, 251)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 19
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld5", True))
        Me.TextBox6.Location = New System.Drawing.Point(1261, 279)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(132, 22)
        Me.TextBox6.TabIndex = 20
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld6", True))
        Me.TextBox7.Location = New System.Drawing.Point(1261, 313)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 22)
        Me.TextBox7.TabIndex = 21
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld7", True))
        Me.TextBox8.Location = New System.Drawing.Point(1261, 346)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(132, 22)
        Me.TextBox8.TabIndex = 22
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld8", True))
        Me.TextBox9.Location = New System.Drawing.Point(1261, 379)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(132, 22)
        Me.TextBox9.TabIndex = 23
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld9", True))
        Me.TextBox10.Location = New System.Drawing.Point(1404, 150)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(132, 22)
        Me.TextBox10.TabIndex = 24
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld10", True))
        Me.TextBox11.Location = New System.Drawing.Point(1404, 183)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(132, 22)
        Me.TextBox11.TabIndex = 25
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld11", True))
        Me.TextBox12.Location = New System.Drawing.Point(1404, 217)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(132, 22)
        Me.TextBox12.TabIndex = 26
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld12", True))
        Me.TextBox13.Location = New System.Drawing.Point(1404, 251)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(132, 22)
        Me.TextBox13.TabIndex = 27
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld13", True))
        Me.TextBox14.Location = New System.Drawing.Point(1404, 279)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(132, 22)
        Me.TextBox14.TabIndex = 28
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld14", True))
        Me.TextBox15.Location = New System.Drawing.Point(1404, 313)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(132, 22)
        Me.TextBox15.TabIndex = 29
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld15", True))
        Me.TextBox16.Location = New System.Drawing.Point(1404, 345)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(132, 22)
        Me.TextBox16.TabIndex = 30
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld16", True))
        Me.TextBox17.Location = New System.Drawing.Point(1404, 379)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(132, 22)
        Me.TextBox17.TabIndex = 31
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld17", True))
        Me.TextBox18.Location = New System.Drawing.Point(1547, 149)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(132, 22)
        Me.TextBox18.TabIndex = 32
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld18", True))
        Me.TextBox19.Location = New System.Drawing.Point(1547, 183)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(132, 22)
        Me.TextBox19.TabIndex = 33
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld19", True))
        Me.TextBox20.Location = New System.Drawing.Point(1547, 217)
        Me.TextBox20.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(132, 22)
        Me.TextBox20.TabIndex = 34
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld20", True))
        Me.TextBox21.Location = New System.Drawing.Point(1547, 250)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(132, 22)
        Me.TextBox21.TabIndex = 35
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld21", True))
        Me.TextBox22.Location = New System.Drawing.Point(1547, 279)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(132, 22)
        Me.TextBox22.TabIndex = 36
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld23", True))
        Me.TextBox23.Location = New System.Drawing.Point(1547, 311)
        Me.TextBox23.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(132, 22)
        Me.TextBox23.TabIndex = 37
        '
        'TextBox24
        '
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld24", True))
        Me.TextBox24.Location = New System.Drawing.Point(1547, 345)
        Me.TextBox24.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(132, 22)
        Me.TextBox24.TabIndex = 38
        '
        'TextBox25
        '
        Me.TextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld25", True))
        Me.TextBox25.Location = New System.Drawing.Point(1547, 378)
        Me.TextBox25.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(132, 22)
        Me.TextBox25.TabIndex = 39
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Lifebelt", True))
        Me.CheckBox1.Location = New System.Drawing.Point(2385, 21)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Feuer", True))
        Me.CheckBox2.Location = New System.Drawing.Point(2387, 49)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox2.TabIndex = 41
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Gas", True))
        Me.CheckBox3.Location = New System.Drawing.Point(2385, 78)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox3.TabIndex = 42
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Rettungsinsel", True))
        Me.CheckBox4.Location = New System.Drawing.Point(2385, 106)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox4.TabIndex = 43
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Signalmittel", True))
        Me.CheckBox5.Location = New System.Drawing.Point(2385, 135)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox5.TabIndex = 47
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "POB", True))
        Me.CheckBox6.Location = New System.Drawing.Point(2385, 161)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox6.TabIndex = 46
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Gesundheit", True))
        Me.CheckBox7.Location = New System.Drawing.Point(2387, 190)
        Me.CheckBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox7.TabIndex = 45
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Dokumentation", True))
        Me.CheckBox8.Location = New System.Drawing.Point(2385, 215)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox8.TabIndex = 44
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Innen", True))
        Me.CheckBox9.Location = New System.Drawing.Point(2501, 21)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox9.TabIndex = 51
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Pantry", True))
        Me.CheckBox10.Location = New System.Drawing.Point(2501, 53)
        Me.CheckBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox10.TabIndex = 50
        Me.CheckBox10.Text = "CheckBox10"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "EleAnlagen", True))
        Me.CheckBox11.Location = New System.Drawing.Point(2501, 78)
        Me.CheckBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox11.TabIndex = 49
        Me.CheckBox11.Text = "CheckBox11"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Sprechfunk", True))
        Me.CheckBox12.Location = New System.Drawing.Point(2501, 106)
        Me.CheckBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox12.TabIndex = 48
        Me.CheckBox12.Text = "CheckBox12"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Motor", True))
        Me.CheckBox13.Location = New System.Drawing.Point(2501, 134)
        Me.CheckBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox13.TabIndex = 55
        Me.CheckBox13.Text = "CheckBox13"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Segel", True))
        Me.CheckBox14.Location = New System.Drawing.Point(2501, 162)
        Me.CheckBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox14.TabIndex = 54
        Me.CheckBox14.Text = "CheckBox14"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Wasser", True))
        Me.CheckBox15.Location = New System.Drawing.Point(2501, 190)
        Me.CheckBox15.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox15.TabIndex = 53
        Me.CheckBox15.Text = "CheckBox15"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsSicherheitseinweisung, "Aussen", True))
        Me.CheckBox16.Location = New System.Drawing.Point(2501, 215)
        Me.CheckBox16.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox16.TabIndex = 52
        Me.CheckBox16.Text = "CheckBox16"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'taSicherheitseinweisung
        '
        Me.taSicherheitseinweisung.ClearBeforeFill = True
        '
        'taMaengel
        '
        Me.taMaengel.ClearBeforeFill = True
        '
        'taDokumentation
        '
        Me.taDokumentation.ClearBeforeFill = True
        '
        'taLogdaten
        '
        Me.taLogdaten.ClearBeforeFill = True
        '
        'taZusammenfassung2
        '
        Me.taZusammenfassung2.ClearBeforeFill = True
        '
        'taLogWacheplan
        '
        Me.taLogWacheplan.ClearBeforeFill = True
        '
        'taBootLog
        '
        Me.taBootLog.ClearBeforeFill = True
        '
        'taTemp
        '
        Me.taTemp.ClearBeforeFill = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld22", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(1261, 412)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(413, 30)
        Me.RichTextBox1.TabIndex = 56
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld25", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(1261, 450)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(407, 34)
        Me.RichTextBox2.TabIndex = 57
        Me.RichTextBox2.Text = ""
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox17.Checked = True
        Me.CheckBox17.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox17.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsTemp, "feld26", True))
        Me.CheckBox17.Location = New System.Drawing.Point(1261, 494)
        Me.CheckBox17.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox17.TabIndex = 58
        Me.CheckBox17.Text = "CheckBox17"
        Me.CheckBox17.UseVisualStyleBackColor = False
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsTemp, "feld27", True))
        Me.CheckBox18.Location = New System.Drawing.Point(1404, 494)
        Me.CheckBox18.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox18.TabIndex = 59
        Me.CheckBox18.Text = "CheckBox18"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsTemp, "feld28", True))
        Me.CheckBox19.Location = New System.Drawing.Point(1547, 494)
        Me.CheckBox19.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox19.TabIndex = 60
        Me.CheckBox19.Text = "CheckBox19"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsTemp, "Feld29", True))
        Me.CheckBox20.Location = New System.Drawing.Point(1261, 523)
        Me.CheckBox20.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox20.TabIndex = 61
        Me.CheckBox20.Text = "CheckBox20"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsTemp, "Feld30", True))
        Me.CheckBox21.Location = New System.Drawing.Point(1404, 523)
        Me.CheckBox21.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox21.TabIndex = 62
        Me.CheckBox21.Text = "CheckBox21"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsTemp, "Feld31", True))
        Me.CheckBox22.Location = New System.Drawing.Point(1547, 523)
        Me.CheckBox22.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(102, 20)
        Me.CheckBox22.TabIndex = 63
        Me.CheckBox22.Text = "CheckBox22"
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'TextBox26
        '
        Me.TextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld32", True))
        Me.TextBox26.Location = New System.Drawing.Point(1549, 120)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(100, 22)
        Me.TextBox26.TabIndex = 67
        '
        'taToerndaten
        '
        Me.taToerndaten.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox25)
        Me.GroupBox3.Controls.Add(Me.CheckBox24)
        Me.GroupBox3.Controls.Add(Me.CheckBox23)
        Me.GroupBox3.Controls.Add(Me.ProgressBar9)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ProgressBar8)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ProgressBar7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ProgressBar6)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ProgressBar5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ProgressBar3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(900, 293)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Daten für Druck aufbereiten"
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.Location = New System.Drawing.Point(159, 107)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox25.TabIndex = 105
        Me.CheckBox25.UseVisualStyleBackColor = True
        Me.CheckBox25.Visible = False
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Location = New System.Drawing.Point(159, 47)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox24.TabIndex = 104
        Me.CheckBox24.UseVisualStyleBackColor = True
        Me.CheckBox24.Visible = False
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Location = New System.Drawing.Point(159, 22)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox23.TabIndex = 103
        Me.CheckBox23.UseVisualStyleBackColor = True
        Me.CheckBox23.Visible = False
        '
        'ProgressBar9
        '
        Me.ProgressBar9.Location = New System.Drawing.Point(159, 250)
        Me.ProgressBar9.Name = "ProgressBar9"
        Me.ProgressBar9.Size = New System.Drawing.Size(709, 23)
        Me.ProgressBar9.TabIndex = 102
        Me.ProgressBar9.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 257)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 16)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "Technische Mängel"
        Me.Label12.Visible = False
        '
        'ProgressBar8
        '
        Me.ProgressBar8.Location = New System.Drawing.Point(159, 221)
        Me.ProgressBar8.Name = "ProgressBar8"
        Me.ProgressBar8.Size = New System.Drawing.Size(709, 23)
        Me.ProgressBar8.TabIndex = 100
        Me.ProgressBar8.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 228)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Zusammenfassung"
        Me.Label11.Visible = False
        '
        'ProgressBar7
        '
        Me.ProgressBar7.Location = New System.Drawing.Point(159, 191)
        Me.ProgressBar7.Name = "ProgressBar7"
        Me.ProgressBar7.Size = New System.Drawing.Size(709, 23)
        Me.ProgressBar7.TabIndex = 98
        Me.ProgressBar7.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 198)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Logdaten"
        Me.Label10.Visible = False
        '
        'ProgressBar6
        '
        Me.ProgressBar6.Location = New System.Drawing.Point(159, 160)
        Me.ProgressBar6.Name = "ProgressBar6"
        Me.ProgressBar6.Size = New System.Drawing.Size(709, 23)
        Me.ProgressBar6.TabIndex = 96
        Me.ProgressBar6.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 167)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Wacheeinteilung"
        Me.Label9.Visible = False
        '
        'ProgressBar5
        '
        Me.ProgressBar5.Location = New System.Drawing.Point(159, 131)
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.Size = New System.Drawing.Size(709, 23)
        Me.ProgressBar5.TabIndex = 94
        Me.ProgressBar5.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 138)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Tagesdokumentation"
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 109)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 16)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Sicherheiteinweisung"
        Me.Label6.Visible = False
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(159, 73)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(709, 23)
        Me.ProgressBar3.TabIndex = 91
        Me.ProgressBar3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Crew"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Törndaten"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Bootdaten"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Location = New System.Drawing.Point(1029, 521)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(900, 293)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Logbuch Auswahl"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(29, 154)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(417, 20)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Törnbeschreibung mit Raster für manueles ausfüllen der Logdaten"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(29, 64)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(236, 20)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "fertig ausgefülltes Logbuch drucken"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'taWacheplan
        '
        Me.taWacheplan.ClearBeforeFill = True
        '
        'TextBox27
        '
        Me.TextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld9", True))
        Me.TextBox27.Location = New System.Drawing.Point(2387, 270)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(100, 22)
        Me.TextBox27.TabIndex = 70
        '
        'LogbuchDruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 555)
        Me.Controls.Add(Me.TextBox27)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox26)
        Me.Controls.Add(Me.CheckBox22)
        Me.Controls.Add(Me.CheckBox21)
        Me.Controls.Add(Me.CheckBox20)
        Me.Controls.Add(Me.CheckBox19)
        Me.Controls.Add(Me.CheckBox18)
        Me.Controls.Add(Me.CheckBox17)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CheckBox13)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.CheckBox16)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox25)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.TextBox23)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView12)
        Me.Controls.Add(Me.DataGridView11)
        Me.Controls.Add(Me.DataGridView10)
        Me.Controls.Add(Me.DataGridView8)
        Me.Controls.Add(Me.DataGridView7)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ButtonDrucken)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LogbuchDruck"
        Me.Text = "Logbuch drucken"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridtoern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBootLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSicherheitseinweisung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaengel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDokumentation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogdaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsZusammenfassung2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToerndaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogWacheplan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDrucken As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridtoern As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusgangsmarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmSegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmGesamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfahrtenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtansteuerungenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordtageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TornberichtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndeMarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetzterSegeltagDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordkassaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogbuchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nachtfahrtvon1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nachtfahrtbis1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sm1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfDatumvon1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtZeitvon1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfDatumbis1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtZeitbis1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtFahrtvon2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtFahrtbis2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SM2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtDatumvon2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtZeitvon2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtDatumbis2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtZeitbis2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50StartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50ZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50SmGesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50smFB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50DatumStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50ZeitStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50DatumZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std50ZeitZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GezHafen1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GezDatum1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GezZeit1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GezHafen2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GezDatum2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GezZeit2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4StartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4ZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4SmGesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4SmFb3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4DatumStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4ZeitStartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4DatumZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB4ZeitZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerbrauchproToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents Bootname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marke As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Schiffstyp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kielart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Schiffsnummer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Durchfahrtshoehe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Länge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Breite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Verdrängung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tiefgang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Großsegel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vorsegel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wassertank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dieseltank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Starterbatterie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicebatterie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kabinenanzahl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kojenanzahl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nassraeumeanzahl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charterfirma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Baujahr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grosssegelart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMSI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmNachweisDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WachfuehrerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NavigatorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RudergaengerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDToernDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaHafen1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaDatum1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaZeit1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaHafen2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaDatum2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaZeit2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaHafen3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaDatum3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtaZeit3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents DsLogbuch As WindowsApplication1.dsLogbuch
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents bsSicherheitseinweisung As System.Windows.Forms.BindingSource
    Friend WithEvents taSicherheitseinweisung As WindowsApplication1.dsLogbuchTableAdapters.SicherheitseinweisungTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LifebeltDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FeuerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RettungsinselDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SignalmittelDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents POBDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GesundheitDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DokumentationDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InnenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PantryDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EleAnlagenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SprechfunkDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MotorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SegelDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WasserDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AussenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents bsMaengel As System.Windows.Forms.BindingSource
    Friend WithEvents taMaengel As WindowsApplication1.dsLogbuchTableAdapters.MaengelTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BetrifftDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefektDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuswirkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView7 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Friend WithEvents bsDokumentation As System.Windows.Forms.BindingSource
    Friend WithEvents taDokumentation As WindowsApplication1.dsLogbuchTableAdapters.DokumentationTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wetterbericht1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wetterbericht2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wetterbericht3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UhrzeitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BesonderesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielAnlegeartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielGebührDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielMüllDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ZielStromDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MotorStdAnfangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorStdEndeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KraftstoffgetanktDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KraffstoffkostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBilgeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WasserTankenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckOelDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckBatterieDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AusgangsortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView9 As System.Windows.Forms.DataGridView
    Friend WithEvents bsLogdaten As System.Windows.Forms.BindingSource
    Friend WithEvents taLogdaten As WindowsApplication1.dsLogbuchTableAdapters.LogdatenTableAdapter
    Friend WithEvents DataGridView10 As System.Windows.Forms.DataGridView
    Friend WithEvents bsZusammenfassung2 As System.Windows.Forms.BindingSource
    Friend WithEvents taZusammenfassung2 As WindowsApplication1.dsLogbuchTableAdapters.Zusammenfassung2TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZeitVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZeitBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WindrichtungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmuSegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmuMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmGesamtDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WindstaerkeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView11 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView12 As System.Windows.Forms.DataGridView
    Friend WithEvents bsLogWacheplan As System.Windows.Forms.BindingSource
    Friend WithEvents taLogWacheplan As WindowsApplication1.dsLogbuchTableAdapters.LogWacheplanTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SynchronDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MethodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents bsBootLog As System.Windows.Forms.BindingSource
    Friend WithEvents taBootLog As WindowsApplication1.dsLogbuchTableAdapters.BootLogTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotormarkeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeibootmarkeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeobootleistungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaustoffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsBildDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents bsTemp As System.Windows.Forms.BindingSource
    Friend WithEvents taTemp As WindowsApplication1.dsLogbuchTableAdapters.TempTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld0DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld13DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld14DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld17DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld18DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld19DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld20DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld21DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld22DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld23DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld24DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld25DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld26DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Feld27DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Feld28DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Feld29DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Feld30DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Feld31DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Feld32DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld33DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld34DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld35DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld36DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld37DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld38DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld39DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld40DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld41DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld42DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld43DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld44DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld45DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld46DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld47DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld48DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld49DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld50DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents bsToerndaten As System.Windows.Forms.BindingSource
    Friend WithEvents taToerndaten As WindowsApplication1.dsLogbuchTableAdapters.ToerndatenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeemeilenMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeemeilenSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorStdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfahrtenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtansteuerungenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KartenMissweisungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonnenaufgangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonnenuntergangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NavtexstationenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VollmondDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxTidenhubDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonstigesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeplanteRouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KassaManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErsteinzahlungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PantryManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErsteinkaufDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevierBildDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GefahreneRouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox25 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar9 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar8 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar7 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar6 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar5 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents bsWacheplan As System.Windows.Forms.BindingSource
    Friend WithEvents taWacheplan As WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Toern As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datum1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datum2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
End Class
