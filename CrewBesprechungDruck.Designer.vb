<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrewBesprechungDruck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrewBesprechungDruck))
        Me.gbToern = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bsAblauf = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCrewbesprechung = New WindowsApplication1.CrewbesprechungDataSet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1Törn = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToernnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordkassaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PantryManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anwesender8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taAblauf = New WindowsApplication1.CrewbesprechungDataSetTableAdapters.AblaufTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusgangsmarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndeMarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmSegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmGesamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfahrtenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtansteuerungenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordtageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TornberichtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetzterSegeltagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordkassaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KenntnisseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BB1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HB1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HS1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockobenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockuntenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HS2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCrewDetails = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCrewDetails = New WindowsApplication1.CrewbesprechungDataSetTableAdapters.CrewDetailsTableAdapter()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWAnkunftortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWRueckreiseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWAnkunftzeitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWBemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWKenntnisseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWAbresieZeitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAnRueckReise = New System.Windows.Forms.BindingSource(Me.components)
        Me.taAnRueckReise = New WindowsApplication1.CrewbesprechungDataSetTableAdapters.AnRueckReiseTableAdapter()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WannDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsErsteTag = New System.Windows.Forms.BindingSource(Me.components)
        Me.taErsteTag = New WindowsApplication1.CrewbesprechungDataSetTableAdapters.ErsteTagTableAdapter()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GruppeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtikelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MengeneinheitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MengeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsEinkaufsliste = New System.Windows.Forms.BindingSource(Me.components)
        Me.taEinkaufsliste = New WindowsApplication1.CrewbesprechungDataSetTableAdapters.EinkaufslisteTableAdapter()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Feld26DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld27DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld28DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld29DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld30DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld31DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.taTemp = New WindowsApplication1.CrewbesprechungDataSetTableAdapters.TempTableAdapter()
        Me.gbAuswertungen = New System.Windows.Forms.GroupBox()
        Me.cbSicherheit = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbOrganisation = New System.Windows.Forms.CheckBox()
        Me.cbPantry = New System.Windows.Forms.CheckBox()
        Me.cbSkipper = New System.Windows.Forms.CheckBox()
        Me.cbEinkaufsliste = New System.Windows.Forms.CheckBox()
        Me.cbErsterTag = New System.Windows.Forms.CheckBox()
        Me.cbCrewDetails = New System.Windows.Forms.CheckBox()
        Me.cbAblauf = New System.Windows.Forms.CheckBox()
        Me.gpTemp = New System.Windows.Forms.GroupBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchiffstypDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KielartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchiffsnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LängeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerdrängungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiefgangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroßsegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VorsegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WassertankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DieseltankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StarterbatterieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicebatterieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KabinenanzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KojenanzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NassraeumeanzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KautionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharterfirmaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrosssegelartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaujahrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinaortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnsprechspersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadarDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BugstrahlruderDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClubnachlasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HeizungDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.KlimaanlageDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MMSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotoryachtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SegelyachtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VerbrauchLiterproSmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReinigungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BettzeugDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AussenborderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpinakerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinakostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonstigeKostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InverterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WiFiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.BtBearbeiten = New System.Windows.Forms.Button()
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmNachweisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WachfuehrerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NavigatorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RudergaengerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.R1DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.gbToern.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAblauf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCrewbesprechung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1Törn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnRueckReise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsErsteTag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEinkaufsliste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAuswertungen.SuspendLayout()
        Me.gpTemp.SuspendLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbToern
        '
        Me.gbToern.Controls.Add(Me.PictureBox1)
        Me.gbToern.Controls.Add(Me.TextBox1)
        Me.gbToern.Controls.Add(Me.Label11)
        Me.gbToern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbToern.Location = New System.Drawing.Point(19, 17)
        Me.gbToern.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.gbToern.Name = "gbToern"
        Me.gbToern.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.gbToern.Size = New System.Drawing.Size(707, 102)
        Me.gbToern.TabIndex = 14
        Me.gbToern.TabStop = False
        Me.gbToern.Text = "Törn "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(175, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAblauf, "Toernname", True))
        Me.TextBox1.Location = New System.Drawing.Point(288, 34)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(321, 22)
        Me.TextBox1.TabIndex = 13
        '
        'bsAblauf
        '
        Me.bsAblauf.DataMember = "Ablauf"
        Me.bsAblauf.DataSource = Me.dsCrewbesprechung
        '
        'dsCrewbesprechung
        '
        Me.dsCrewbesprechung.DataSetName = "CrewbesprechungDataSet"
        Me.dsCrewbesprechung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 38)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Törnbezeichnung"
        '
        'GroupBox1Törn
        '
        Me.GroupBox1Törn.Controls.Add(Me.DataGridView1)
        Me.GroupBox1Törn.Location = New System.Drawing.Point(1295, 358)
        Me.GroupBox1Törn.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1Törn.Name = "GroupBox1Törn"
        Me.GroupBox1Törn.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1Törn.Size = New System.Drawing.Size(703, 400)
        Me.GroupBox1Törn.TabIndex = 16
        Me.GroupBox1Törn.TabStop = False
        Me.GroupBox1Törn.Text = "Törn auswählen"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernnameDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.ThemaDataGridViewTextBoxColumn, Me.BordkassaDataGridViewTextBoxColumn, Me.PantryManagerDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.Anwesender1DataGridViewTextBoxColumn, Me.Anwesender2DataGridViewTextBoxColumn, Me.Anwesender3DataGridViewTextBoxColumn, Me.Anwesender4DataGridViewTextBoxColumn, Me.Anwesender5DataGridViewTextBoxColumn, Me.Anwesender6DataGridViewTextBoxColumn, Me.Anwesender7DataGridViewTextBoxColumn, Me.Anwesender8DataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsAblauf
        Me.DataGridView1.Location = New System.Drawing.Point(11, 26)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(664, 354)
        Me.DataGridView1.TabIndex = 14
        '
        'ToernnameDataGridViewTextBoxColumn
        '
        Me.ToernnameDataGridViewTextBoxColumn.DataPropertyName = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn.HeaderText = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn.Name = "ToernnameDataGridViewTextBoxColumn"
        Me.ToernnameDataGridViewTextBoxColumn.Width = 200
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        '
        'ThemaDataGridViewTextBoxColumn
        '
        Me.ThemaDataGridViewTextBoxColumn.DataPropertyName = "Thema"
        Me.ThemaDataGridViewTextBoxColumn.HeaderText = "Thema"
        Me.ThemaDataGridViewTextBoxColumn.Name = "ThemaDataGridViewTextBoxColumn"
        '
        'BordkassaDataGridViewTextBoxColumn
        '
        Me.BordkassaDataGridViewTextBoxColumn.DataPropertyName = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.HeaderText = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.Name = "BordkassaDataGridViewTextBoxColumn"
        '
        'PantryManagerDataGridViewTextBoxColumn
        '
        Me.PantryManagerDataGridViewTextBoxColumn.DataPropertyName = "PantryManager"
        Me.PantryManagerDataGridViewTextBoxColumn.HeaderText = "PantryManager"
        Me.PantryManagerDataGridViewTextBoxColumn.Name = "PantryManagerDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        '
        'Anwesender1DataGridViewTextBoxColumn
        '
        Me.Anwesender1DataGridViewTextBoxColumn.DataPropertyName = "Anwesender1"
        Me.Anwesender1DataGridViewTextBoxColumn.HeaderText = "Anwesender1"
        Me.Anwesender1DataGridViewTextBoxColumn.Name = "Anwesender1DataGridViewTextBoxColumn"
        '
        'Anwesender2DataGridViewTextBoxColumn
        '
        Me.Anwesender2DataGridViewTextBoxColumn.DataPropertyName = "Anwesender2"
        Me.Anwesender2DataGridViewTextBoxColumn.HeaderText = "Anwesender2"
        Me.Anwesender2DataGridViewTextBoxColumn.Name = "Anwesender2DataGridViewTextBoxColumn"
        '
        'Anwesender3DataGridViewTextBoxColumn
        '
        Me.Anwesender3DataGridViewTextBoxColumn.DataPropertyName = "Anwesender3"
        Me.Anwesender3DataGridViewTextBoxColumn.HeaderText = "Anwesender3"
        Me.Anwesender3DataGridViewTextBoxColumn.Name = "Anwesender3DataGridViewTextBoxColumn"
        '
        'Anwesender4DataGridViewTextBoxColumn
        '
        Me.Anwesender4DataGridViewTextBoxColumn.DataPropertyName = "Anwesender4"
        Me.Anwesender4DataGridViewTextBoxColumn.HeaderText = "Anwesender4"
        Me.Anwesender4DataGridViewTextBoxColumn.Name = "Anwesender4DataGridViewTextBoxColumn"
        '
        'Anwesender5DataGridViewTextBoxColumn
        '
        Me.Anwesender5DataGridViewTextBoxColumn.DataPropertyName = "Anwesender5"
        Me.Anwesender5DataGridViewTextBoxColumn.HeaderText = "Anwesender5"
        Me.Anwesender5DataGridViewTextBoxColumn.Name = "Anwesender5DataGridViewTextBoxColumn"
        '
        'Anwesender6DataGridViewTextBoxColumn
        '
        Me.Anwesender6DataGridViewTextBoxColumn.DataPropertyName = "Anwesender6"
        Me.Anwesender6DataGridViewTextBoxColumn.HeaderText = "Anwesender6"
        Me.Anwesender6DataGridViewTextBoxColumn.Name = "Anwesender6DataGridViewTextBoxColumn"
        '
        'Anwesender7DataGridViewTextBoxColumn
        '
        Me.Anwesender7DataGridViewTextBoxColumn.DataPropertyName = "Anwesender7"
        Me.Anwesender7DataGridViewTextBoxColumn.HeaderText = "Anwesender7"
        Me.Anwesender7DataGridViewTextBoxColumn.Name = "Anwesender7DataGridViewTextBoxColumn"
        '
        'Anwesender8DataGridViewTextBoxColumn
        '
        Me.Anwesender8DataGridViewTextBoxColumn.DataPropertyName = "Anwesender8"
        Me.Anwesender8DataGridViewTextBoxColumn.HeaderText = "Anwesender8"
        Me.Anwesender8DataGridViewTextBoxColumn.Name = "Anwesender8DataGridViewTextBoxColumn"
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'taAblauf
        '
        Me.taAblauf.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.TornberichtDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.BordkassaDataGridViewTextBoxColumn1, Me.RouteDataGridViewTextBoxColumn, Me.LogbuchDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn, Me.Nachtfahrtvon1DataGridViewTextBoxColumn, Me.Nachtfahrtbis1DataGridViewTextBoxColumn, Me.Sm1DataGridViewTextBoxColumn, Me.NachtfDatumvon1DataGridViewTextBoxColumn, Me.NachtZeitvon1DataGridViewTextBoxColumn, Me.NachtfDatumbis1DataGridViewTextBoxColumn, Me.NachtZeitbis1DataGridViewTextBoxColumn, Me.NachtFahrtvon2DataGridViewTextBoxColumn, Me.NachtFahrtbis2DataGridViewTextBoxColumn, Me.SM2DataGridViewTextBoxColumn, Me.NachtDatumvon2DataGridViewTextBoxColumn, Me.NachtZeitvon2DataGridViewTextBoxColumn, Me.NachtDatumbis2DataGridViewTextBoxColumn, Me.NachtZeitbis2DataGridViewTextBoxColumn, Me.Std50StartDataGridViewTextBoxColumn, Me.Std50ZielDataGridViewTextBoxColumn, Me.Std50SmGesDataGridViewTextBoxColumn, Me.Std50smFB2DataGridViewTextBoxColumn, Me.Std50DatumStartDataGridViewTextBoxColumn, Me.Std50ZeitStartDataGridViewTextBoxColumn, Me.Std50DatumZielDataGridViewTextBoxColumn, Me.Std50ZeitZielDataGridViewTextBoxColumn, Me.GezHafen1DataGridViewTextBoxColumn, Me.GezDatum1DataGridViewTextBoxColumn, Me.GezZeit1DataGridViewTextBoxColumn, Me.GezHafen2DataGridViewTextBoxColumn, Me.GezDatum2DataGridViewTextBoxColumn, Me.GezZeit2DataGridViewTextBoxColumn, Me.FB4StartDataGridViewTextBoxColumn, Me.FB4ZielDataGridViewTextBoxColumn, Me.FB4SmGesDataGridViewTextBoxColumn, Me.FB4SmFb3DataGridViewTextBoxColumn, Me.FB4DatumStartDataGridViewTextBoxColumn, Me.FB4ZeitStartDataGridViewTextBoxColumn, Me.FB4DatumZielDataGridViewTextBoxColumn, Me.FB4ZeitZielDataGridViewTextBoxColumn, Me.RevierDataGridViewTextBoxColumn, Me.VerbrauchproToernDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsToernname
        Me.DataGridView2.Location = New System.Drawing.Point(949, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(109, 135)
        Me.DataGridView2.TabIndex = 17
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'DatumVonDataGridViewTextBoxColumn
        '
        Me.DatumVonDataGridViewTextBoxColumn.DataPropertyName = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.HeaderText = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.Name = "DatumVonDataGridViewTextBoxColumn"
        '
        'DatumBisDataGridViewTextBoxColumn
        '
        Me.DatumBisDataGridViewTextBoxColumn.DataPropertyName = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.HeaderText = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.Name = "DatumBisDataGridViewTextBoxColumn"
        '
        'AusgangsmarinaDataGridViewTextBoxColumn
        '
        Me.AusgangsmarinaDataGridViewTextBoxColumn.DataPropertyName = "Ausgangsmarina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.HeaderText = "Ausgangsmarina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.Name = "AusgangsmarinaDataGridViewTextBoxColumn"
        '
        'EndeMarinaDataGridViewTextBoxColumn
        '
        Me.EndeMarinaDataGridViewTextBoxColumn.DataPropertyName = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.HeaderText = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.Name = "EndeMarinaDataGridViewTextBoxColumn"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        '
        'SmSegelDataGridViewTextBoxColumn
        '
        Me.SmSegelDataGridViewTextBoxColumn.DataPropertyName = "smSegel"
        Me.SmSegelDataGridViewTextBoxColumn.HeaderText = "smSegel"
        Me.SmSegelDataGridViewTextBoxColumn.Name = "SmSegelDataGridViewTextBoxColumn"
        '
        'SmMotorDataGridViewTextBoxColumn
        '
        Me.SmMotorDataGridViewTextBoxColumn.DataPropertyName = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.HeaderText = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.Name = "SmMotorDataGridViewTextBoxColumn"
        '
        'SmGesamtDataGridViewTextBoxColumn
        '
        Me.SmGesamtDataGridViewTextBoxColumn.DataPropertyName = "smGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.HeaderText = "smGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.Name = "SmGesamtDataGridViewTextBoxColumn"
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
        'LetzterSegeltagDataGridViewCheckBoxColumn
        '
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.DataPropertyName = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.HeaderText = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.Name = "LetzterSegeltagDataGridViewCheckBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'BordkassaDataGridViewTextBoxColumn1
        '
        Me.BordkassaDataGridViewTextBoxColumn1.DataPropertyName = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn1.HeaderText = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn1.Name = "BordkassaDataGridViewTextBoxColumn1"
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
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.ToernnameDataGridViewTextBoxColumn1, Me.KenntnisseDataGridViewTextBoxColumn, Me.BB1DataGridViewTextBoxColumn, Me.BS1DataGridViewTextBoxColumn, Me.HB1DataGridViewTextBoxColumn, Me.HS1DataGridViewTextBoxColumn, Me.StockobenDataGridViewTextBoxColumn, Me.StockuntenDataGridViewTextBoxColumn, Me.BB2DataGridViewTextBoxColumn, Me.BS2DataGridViewTextBoxColumn, Me.HB2DataGridViewTextBoxColumn, Me.HS2DataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsCrewDetails
        Me.DataGridView3.Location = New System.Drawing.Point(1083, 23)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(124, 133)
        Me.DataGridView3.TabIndex = 18
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'ToernnameDataGridViewTextBoxColumn1
        '
        Me.ToernnameDataGridViewTextBoxColumn1.DataPropertyName = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn1.HeaderText = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn1.Name = "ToernnameDataGridViewTextBoxColumn1"
        '
        'KenntnisseDataGridViewTextBoxColumn
        '
        Me.KenntnisseDataGridViewTextBoxColumn.DataPropertyName = "Kenntnisse"
        Me.KenntnisseDataGridViewTextBoxColumn.HeaderText = "Kenntnisse"
        Me.KenntnisseDataGridViewTextBoxColumn.Name = "KenntnisseDataGridViewTextBoxColumn"
        '
        'BB1DataGridViewTextBoxColumn
        '
        Me.BB1DataGridViewTextBoxColumn.DataPropertyName = "BB1"
        Me.BB1DataGridViewTextBoxColumn.HeaderText = "BB1"
        Me.BB1DataGridViewTextBoxColumn.Name = "BB1DataGridViewTextBoxColumn"
        '
        'BS1DataGridViewTextBoxColumn
        '
        Me.BS1DataGridViewTextBoxColumn.DataPropertyName = "BS1"
        Me.BS1DataGridViewTextBoxColumn.HeaderText = "BS1"
        Me.BS1DataGridViewTextBoxColumn.Name = "BS1DataGridViewTextBoxColumn"
        '
        'HB1DataGridViewTextBoxColumn
        '
        Me.HB1DataGridViewTextBoxColumn.DataPropertyName = "HB1"
        Me.HB1DataGridViewTextBoxColumn.HeaderText = "HB1"
        Me.HB1DataGridViewTextBoxColumn.Name = "HB1DataGridViewTextBoxColumn"
        '
        'HS1DataGridViewTextBoxColumn
        '
        Me.HS1DataGridViewTextBoxColumn.DataPropertyName = "HS1"
        Me.HS1DataGridViewTextBoxColumn.HeaderText = "HS1"
        Me.HS1DataGridViewTextBoxColumn.Name = "HS1DataGridViewTextBoxColumn"
        '
        'StockobenDataGridViewTextBoxColumn
        '
        Me.StockobenDataGridViewTextBoxColumn.DataPropertyName = "Stockoben"
        Me.StockobenDataGridViewTextBoxColumn.HeaderText = "Stockoben"
        Me.StockobenDataGridViewTextBoxColumn.Name = "StockobenDataGridViewTextBoxColumn"
        '
        'StockuntenDataGridViewTextBoxColumn
        '
        Me.StockuntenDataGridViewTextBoxColumn.DataPropertyName = "Stockunten"
        Me.StockuntenDataGridViewTextBoxColumn.HeaderText = "Stockunten"
        Me.StockuntenDataGridViewTextBoxColumn.Name = "StockuntenDataGridViewTextBoxColumn"
        '
        'BB2DataGridViewTextBoxColumn
        '
        Me.BB2DataGridViewTextBoxColumn.DataPropertyName = "BB2"
        Me.BB2DataGridViewTextBoxColumn.HeaderText = "BB2"
        Me.BB2DataGridViewTextBoxColumn.Name = "BB2DataGridViewTextBoxColumn"
        '
        'BS2DataGridViewTextBoxColumn
        '
        Me.BS2DataGridViewTextBoxColumn.DataPropertyName = "BS2"
        Me.BS2DataGridViewTextBoxColumn.HeaderText = "BS2"
        Me.BS2DataGridViewTextBoxColumn.Name = "BS2DataGridViewTextBoxColumn"
        '
        'HB2DataGridViewTextBoxColumn
        '
        Me.HB2DataGridViewTextBoxColumn.DataPropertyName = "HB2"
        Me.HB2DataGridViewTextBoxColumn.HeaderText = "HB2"
        Me.HB2DataGridViewTextBoxColumn.Name = "HB2DataGridViewTextBoxColumn"
        '
        'HS2DataGridViewTextBoxColumn
        '
        Me.HS2DataGridViewTextBoxColumn.DataPropertyName = "HS2"
        Me.HS2DataGridViewTextBoxColumn.HeaderText = "HS2"
        Me.HS2DataGridViewTextBoxColumn.Name = "HS2DataGridViewTextBoxColumn"
        '
        'bsCrewDetails
        '
        Me.bsCrewDetails.DataMember = "CrewDetails"
        Me.bsCrewDetails.DataSource = Me.dsCrewbesprechung
        '
        'taCrewDetails
        '
        Me.taCrewDetails.ClearBeforeFill = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.ToernnameDataGridViewTextBoxColumn2, Me.CWNameDataGridViewTextBoxColumn, Me.CWAnkunftortDataGridViewTextBoxColumn, Me.CWRueckreiseDataGridViewTextBoxColumn, Me.CWAnkunftzeitDataGridViewTextBoxColumn, Me.CWBemerkungDataGridViewTextBoxColumn, Me.CWKenntnisseDataGridViewTextBoxColumn, Me.CWAbresieZeitDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.bsAnRueckReise
        Me.DataGridView4.Location = New System.Drawing.Point(1225, 26)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(133, 129)
        Me.DataGridView4.TabIndex = 19
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        '
        'ToernnameDataGridViewTextBoxColumn2
        '
        Me.ToernnameDataGridViewTextBoxColumn2.DataPropertyName = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn2.HeaderText = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn2.Name = "ToernnameDataGridViewTextBoxColumn2"
        '
        'CWNameDataGridViewTextBoxColumn
        '
        Me.CWNameDataGridViewTextBoxColumn.DataPropertyName = "CW_Name"
        Me.CWNameDataGridViewTextBoxColumn.HeaderText = "CW_Name"
        Me.CWNameDataGridViewTextBoxColumn.Name = "CWNameDataGridViewTextBoxColumn"
        '
        'CWAnkunftortDataGridViewTextBoxColumn
        '
        Me.CWAnkunftortDataGridViewTextBoxColumn.DataPropertyName = "CW_Ankunftort"
        Me.CWAnkunftortDataGridViewTextBoxColumn.HeaderText = "CW_Ankunftort"
        Me.CWAnkunftortDataGridViewTextBoxColumn.Name = "CWAnkunftortDataGridViewTextBoxColumn"
        '
        'CWRueckreiseDataGridViewTextBoxColumn
        '
        Me.CWRueckreiseDataGridViewTextBoxColumn.DataPropertyName = "CW_Rueckreise"
        Me.CWRueckreiseDataGridViewTextBoxColumn.HeaderText = "CW_Rueckreise"
        Me.CWRueckreiseDataGridViewTextBoxColumn.Name = "CWRueckreiseDataGridViewTextBoxColumn"
        '
        'CWAnkunftzeitDataGridViewTextBoxColumn
        '
        Me.CWAnkunftzeitDataGridViewTextBoxColumn.DataPropertyName = "CW_Ankunftzeit"
        Me.CWAnkunftzeitDataGridViewTextBoxColumn.HeaderText = "CW_Ankunftzeit"
        Me.CWAnkunftzeitDataGridViewTextBoxColumn.Name = "CWAnkunftzeitDataGridViewTextBoxColumn"
        '
        'CWBemerkungDataGridViewTextBoxColumn
        '
        Me.CWBemerkungDataGridViewTextBoxColumn.DataPropertyName = "CW_Bemerkung"
        Me.CWBemerkungDataGridViewTextBoxColumn.HeaderText = "CW_Bemerkung"
        Me.CWBemerkungDataGridViewTextBoxColumn.Name = "CWBemerkungDataGridViewTextBoxColumn"
        '
        'CWKenntnisseDataGridViewTextBoxColumn
        '
        Me.CWKenntnisseDataGridViewTextBoxColumn.DataPropertyName = "CW_Kenntnisse"
        Me.CWKenntnisseDataGridViewTextBoxColumn.HeaderText = "CW_Kenntnisse"
        Me.CWKenntnisseDataGridViewTextBoxColumn.Name = "CWKenntnisseDataGridViewTextBoxColumn"
        '
        'CWAbresieZeitDataGridViewTextBoxColumn
        '
        Me.CWAbresieZeitDataGridViewTextBoxColumn.DataPropertyName = "CW_AbresieZeit"
        Me.CWAbresieZeitDataGridViewTextBoxColumn.HeaderText = "CW_AbresieZeit"
        Me.CWAbresieZeitDataGridViewTextBoxColumn.Name = "CWAbresieZeitDataGridViewTextBoxColumn"
        '
        'bsAnRueckReise
        '
        Me.bsAnRueckReise.DataMember = "AnRueckReise"
        Me.bsAnRueckReise.DataSource = Me.dsCrewbesprechung
        '
        'taAnRueckReise
        '
        Me.taAnRueckReise.ClearBeforeFill = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn4, Me.ToernnameDataGridViewTextBoxColumn3, Me.WasDataGridViewTextBoxColumn, Me.WannDataGridViewTextBoxColumn, Me.WerDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.bsErsteTag
        Me.DataGridView5.Location = New System.Drawing.Point(1373, 30)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(127, 124)
        Me.DataGridView5.TabIndex = 20
        '
        'IDDataGridViewTextBoxColumn4
        '
        Me.IDDataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn4.Name = "IDDataGridViewTextBoxColumn4"
        '
        'ToernnameDataGridViewTextBoxColumn3
        '
        Me.ToernnameDataGridViewTextBoxColumn3.DataPropertyName = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn3.HeaderText = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn3.Name = "ToernnameDataGridViewTextBoxColumn3"
        '
        'WasDataGridViewTextBoxColumn
        '
        Me.WasDataGridViewTextBoxColumn.DataPropertyName = "Was"
        Me.WasDataGridViewTextBoxColumn.HeaderText = "Was"
        Me.WasDataGridViewTextBoxColumn.Name = "WasDataGridViewTextBoxColumn"
        '
        'WannDataGridViewTextBoxColumn
        '
        Me.WannDataGridViewTextBoxColumn.DataPropertyName = "Wann"
        Me.WannDataGridViewTextBoxColumn.HeaderText = "Wann"
        Me.WannDataGridViewTextBoxColumn.Name = "WannDataGridViewTextBoxColumn"
        '
        'WerDataGridViewTextBoxColumn
        '
        Me.WerDataGridViewTextBoxColumn.DataPropertyName = "Wer"
        Me.WerDataGridViewTextBoxColumn.HeaderText = "Wer"
        Me.WerDataGridViewTextBoxColumn.Name = "WerDataGridViewTextBoxColumn"
        '
        'bsErsteTag
        '
        Me.bsErsteTag.DataMember = "ErsteTag"
        Me.bsErsteTag.DataSource = Me.dsCrewbesprechung
        '
        'taErsteTag
        '
        Me.taErsteTag.ClearBeforeFill = True
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn5, Me.ToernnameDataGridViewTextBoxColumn4, Me.GruppeDataGridViewTextBoxColumn, Me.ArtikelDataGridViewTextBoxColumn, Me.MengeneinheitDataGridViewTextBoxColumn, Me.MengeDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn2})
        Me.DataGridView6.DataSource = Me.bsEinkaufsliste
        Me.DataGridView6.Location = New System.Drawing.Point(1516, 31)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(129, 122)
        Me.DataGridView6.TabIndex = 21
        '
        'IDDataGridViewTextBoxColumn5
        '
        Me.IDDataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn5.Name = "IDDataGridViewTextBoxColumn5"
        '
        'ToernnameDataGridViewTextBoxColumn4
        '
        Me.ToernnameDataGridViewTextBoxColumn4.DataPropertyName = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn4.HeaderText = "Toernname"
        Me.ToernnameDataGridViewTextBoxColumn4.Name = "ToernnameDataGridViewTextBoxColumn4"
        '
        'GruppeDataGridViewTextBoxColumn
        '
        Me.GruppeDataGridViewTextBoxColumn.DataPropertyName = "Gruppe"
        Me.GruppeDataGridViewTextBoxColumn.HeaderText = "Gruppe"
        Me.GruppeDataGridViewTextBoxColumn.Name = "GruppeDataGridViewTextBoxColumn"
        '
        'ArtikelDataGridViewTextBoxColumn
        '
        Me.ArtikelDataGridViewTextBoxColumn.DataPropertyName = "Artikel"
        Me.ArtikelDataGridViewTextBoxColumn.HeaderText = "Artikel"
        Me.ArtikelDataGridViewTextBoxColumn.Name = "ArtikelDataGridViewTextBoxColumn"
        '
        'MengeneinheitDataGridViewTextBoxColumn
        '
        Me.MengeneinheitDataGridViewTextBoxColumn.DataPropertyName = "Mengeneinheit"
        Me.MengeneinheitDataGridViewTextBoxColumn.HeaderText = "Mengeneinheit"
        Me.MengeneinheitDataGridViewTextBoxColumn.Name = "MengeneinheitDataGridViewTextBoxColumn"
        '
        'MengeDataGridViewTextBoxColumn
        '
        Me.MengeDataGridViewTextBoxColumn.DataPropertyName = "Menge"
        Me.MengeDataGridViewTextBoxColumn.HeaderText = "Menge"
        Me.MengeDataGridViewTextBoxColumn.Name = "MengeDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn2
        '
        Me.BemerkungDataGridViewTextBoxColumn2.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.Name = "BemerkungDataGridViewTextBoxColumn2"
        '
        'bsEinkaufsliste
        '
        Me.bsEinkaufsliste.DataMember = "Einkaufsliste"
        Me.bsEinkaufsliste.DataSource = Me.dsCrewbesprechung
        '
        'taEinkaufsliste
        '
        Me.taEinkaufsliste.ClearBeforeFill = True
        '
        'DataGridView7
        '
        Me.DataGridView7.AutoGenerateColumns = False
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn6, Me.Feld0DataGridViewTextBoxColumn, Me.Feld1DataGridViewTextBoxColumn, Me.Feld2DataGridViewTextBoxColumn, Me.Feld3DataGridViewTextBoxColumn, Me.Feld4DataGridViewTextBoxColumn, Me.Feld5DataGridViewTextBoxColumn, Me.Feld6DataGridViewTextBoxColumn, Me.Feld7DataGridViewTextBoxColumn, Me.Feld8DataGridViewTextBoxColumn, Me.Feld9DataGridViewTextBoxColumn, Me.Feld10DataGridViewTextBoxColumn, Me.Feld11DataGridViewTextBoxColumn, Me.Feld12DataGridViewTextBoxColumn, Me.Feld13DataGridViewTextBoxColumn, Me.Feld14DataGridViewTextBoxColumn, Me.Feld15DataGridViewTextBoxColumn, Me.Feld16DataGridViewTextBoxColumn, Me.Feld17DataGridViewTextBoxColumn, Me.Feld18DataGridViewTextBoxColumn, Me.Feld19DataGridViewTextBoxColumn, Me.Feld20DataGridViewTextBoxColumn, Me.Feld21DataGridViewTextBoxColumn, Me.Feld22DataGridViewTextBoxColumn, Me.Feld23DataGridViewTextBoxColumn, Me.Feld24DataGridViewTextBoxColumn, Me.Feld25DataGridViewTextBoxColumn, Me.Feld26DataGridViewTextBoxColumn, Me.Feld27DataGridViewTextBoxColumn, Me.Feld28DataGridViewTextBoxColumn, Me.Feld29DataGridViewTextBoxColumn, Me.Feld30DataGridViewTextBoxColumn, Me.Feld31DataGridViewTextBoxColumn, Me.Feld32DataGridViewTextBoxColumn, Me.Feld33DataGridViewTextBoxColumn, Me.Feld34DataGridViewTextBoxColumn, Me.Feld35DataGridViewTextBoxColumn, Me.Feld36DataGridViewTextBoxColumn, Me.Feld37DataGridViewTextBoxColumn, Me.Feld38DataGridViewTextBoxColumn, Me.Feld39DataGridViewTextBoxColumn, Me.Feld40DataGridViewTextBoxColumn, Me.Feld41DataGridViewTextBoxColumn, Me.Feld42DataGridViewTextBoxColumn, Me.Feld43DataGridViewTextBoxColumn, Me.Feld44DataGridViewTextBoxColumn, Me.Feld45DataGridViewTextBoxColumn, Me.Feld46DataGridViewTextBoxColumn, Me.Feld47DataGridViewTextBoxColumn, Me.Feld48DataGridViewTextBoxColumn, Me.Feld49DataGridViewTextBoxColumn, Me.Feld50DataGridViewTextBoxColumn})
        Me.DataGridView7.DataSource = Me.bsTemp
        Me.DataGridView7.Location = New System.Drawing.Point(1517, 174)
        Me.DataGridView7.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(127, 137)
        Me.DataGridView7.TabIndex = 22
        '
        'IDDataGridViewTextBoxColumn6
        '
        Me.IDDataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn6.Name = "IDDataGridViewTextBoxColumn6"
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
        'Feld26DataGridViewTextBoxColumn
        '
        Me.Feld26DataGridViewTextBoxColumn.DataPropertyName = "feld26"
        Me.Feld26DataGridViewTextBoxColumn.HeaderText = "feld26"
        Me.Feld26DataGridViewTextBoxColumn.Name = "Feld26DataGridViewTextBoxColumn"
        '
        'Feld27DataGridViewTextBoxColumn
        '
        Me.Feld27DataGridViewTextBoxColumn.DataPropertyName = "feld27"
        Me.Feld27DataGridViewTextBoxColumn.HeaderText = "feld27"
        Me.Feld27DataGridViewTextBoxColumn.Name = "Feld27DataGridViewTextBoxColumn"
        '
        'Feld28DataGridViewTextBoxColumn
        '
        Me.Feld28DataGridViewTextBoxColumn.DataPropertyName = "feld28"
        Me.Feld28DataGridViewTextBoxColumn.HeaderText = "feld28"
        Me.Feld28DataGridViewTextBoxColumn.Name = "Feld28DataGridViewTextBoxColumn"
        '
        'Feld29DataGridViewTextBoxColumn
        '
        Me.Feld29DataGridViewTextBoxColumn.DataPropertyName = "Feld29"
        Me.Feld29DataGridViewTextBoxColumn.HeaderText = "Feld29"
        Me.Feld29DataGridViewTextBoxColumn.Name = "Feld29DataGridViewTextBoxColumn"
        '
        'Feld30DataGridViewTextBoxColumn
        '
        Me.Feld30DataGridViewTextBoxColumn.DataPropertyName = "Feld30"
        Me.Feld30DataGridViewTextBoxColumn.HeaderText = "Feld30"
        Me.Feld30DataGridViewTextBoxColumn.Name = "Feld30DataGridViewTextBoxColumn"
        '
        'Feld31DataGridViewTextBoxColumn
        '
        Me.Feld31DataGridViewTextBoxColumn.DataPropertyName = "Feld31"
        Me.Feld31DataGridViewTextBoxColumn.HeaderText = "Feld31"
        Me.Feld31DataGridViewTextBoxColumn.Name = "Feld31DataGridViewTextBoxColumn"
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
        Me.bsTemp.DataSource = Me.dsCrewbesprechung
        '
        'taTemp
        '
        Me.taTemp.ClearBeforeFill = True
        '
        'gbAuswertungen
        '
        Me.gbAuswertungen.Controls.Add(Me.cbSicherheit)
        Me.gbAuswertungen.Controls.Add(Me.Label3)
        Me.gbAuswertungen.Controls.Add(Me.Label2)
        Me.gbAuswertungen.Controls.Add(Me.Label1)
        Me.gbAuswertungen.Controls.Add(Me.Button1)
        Me.gbAuswertungen.Controls.Add(Me.cbOrganisation)
        Me.gbAuswertungen.Controls.Add(Me.cbPantry)
        Me.gbAuswertungen.Controls.Add(Me.cbSkipper)
        Me.gbAuswertungen.Controls.Add(Me.cbEinkaufsliste)
        Me.gbAuswertungen.Controls.Add(Me.cbErsterTag)
        Me.gbAuswertungen.Controls.Add(Me.cbCrewDetails)
        Me.gbAuswertungen.Controls.Add(Me.cbAblauf)
        Me.gbAuswertungen.Location = New System.Drawing.Point(19, 130)
        Me.gbAuswertungen.Margin = New System.Windows.Forms.Padding(5)
        Me.gbAuswertungen.Name = "gbAuswertungen"
        Me.gbAuswertungen.Padding = New System.Windows.Forms.Padding(5)
        Me.gbAuswertungen.Size = New System.Drawing.Size(707, 279)
        Me.gbAuswertungen.TabIndex = 23
        Me.gbAuswertungen.TabStop = False
        Me.gbAuswertungen.Text = "Auswertungen"
        '
        'cbSicherheit
        '
        Me.cbSicherheit.AutoSize = True
        Me.cbSicherheit.Location = New System.Drawing.Point(288, 149)
        Me.cbSicherheit.Name = "cbSicherheit"
        Me.cbSicherheit.Size = New System.Drawing.Size(225, 20)
        Me.cbSicherheit.TabIndex = 12
        Me.cbSicherheit.Text = "Checkliste Sicherheitseinweisung"
        Me.cbSicherheit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(546, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(546, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(519, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 47)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Drucken"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbOrganisation
        '
        Me.cbOrganisation.AutoSize = True
        Me.cbOrganisation.Location = New System.Drawing.Point(288, 113)
        Me.cbOrganisation.Name = "cbOrganisation"
        Me.cbOrganisation.Size = New System.Drawing.Size(115, 20)
        Me.cbOrganisation.TabIndex = 6
        Me.cbOrganisation.Text = "Crew Hinweise"
        Me.cbOrganisation.UseVisualStyleBackColor = True
        '
        'cbPantry
        '
        Me.cbPantry.AutoSize = True
        Me.cbPantry.Location = New System.Drawing.Point(288, 74)
        Me.cbPantry.Name = "cbPantry"
        Me.cbPantry.Size = New System.Drawing.Size(123, 20)
        Me.cbPantry.TabIndex = 5
        Me.cbPantry.Text = "Pantry Hinweise"
        Me.cbPantry.UseVisualStyleBackColor = True
        '
        'cbSkipper
        '
        Me.cbSkipper.AutoSize = True
        Me.cbSkipper.Location = New System.Drawing.Point(288, 32)
        Me.cbSkipper.Name = "cbSkipper"
        Me.cbSkipper.Size = New System.Drawing.Size(220, 20)
        Me.cbSkipper.TabIndex = 4
        Me.cbSkipper.Text = "Skipper - Wachführer Funktionen"
        Me.cbSkipper.UseVisualStyleBackColor = True
        '
        'cbEinkaufsliste
        '
        Me.cbEinkaufsliste.AutoSize = True
        Me.cbEinkaufsliste.Location = New System.Drawing.Point(19, 149)
        Me.cbEinkaufsliste.Name = "cbEinkaufsliste"
        Me.cbEinkaufsliste.Size = New System.Drawing.Size(102, 20)
        Me.cbEinkaufsliste.TabIndex = 3
        Me.cbEinkaufsliste.Text = "Einkaufsliste"
        Me.cbEinkaufsliste.UseVisualStyleBackColor = True
        '
        'cbErsterTag
        '
        Me.cbErsterTag.AutoSize = True
        Me.cbErsterTag.Location = New System.Drawing.Point(19, 113)
        Me.cbErsterTag.Name = "cbErsterTag"
        Me.cbErsterTag.Size = New System.Drawing.Size(110, 20)
        Me.cbErsterTag.TabIndex = 2
        Me.cbErsterTag.Text = "Der erste Tag"
        Me.cbErsterTag.UseVisualStyleBackColor = True
        '
        'cbCrewDetails
        '
        Me.cbCrewDetails.AutoSize = True
        Me.cbCrewDetails.Location = New System.Drawing.Point(19, 74)
        Me.cbCrewDetails.Name = "cbCrewDetails"
        Me.cbCrewDetails.Size = New System.Drawing.Size(102, 20)
        Me.cbCrewDetails.TabIndex = 1
        Me.cbCrewDetails.Text = "Crew Details"
        Me.cbCrewDetails.UseVisualStyleBackColor = True
        '
        'cbAblauf
        '
        Me.cbAblauf.AutoSize = True
        Me.cbAblauf.Location = New System.Drawing.Point(19, 32)
        Me.cbAblauf.Name = "cbAblauf"
        Me.cbAblauf.Size = New System.Drawing.Size(65, 20)
        Me.cbAblauf.TabIndex = 0
        Me.cbAblauf.Text = "Ablauf"
        Me.cbAblauf.UseVisualStyleBackColor = True
        '
        'gpTemp
        '
        Me.gpTemp.Controls.Add(Me.TextBox24)
        Me.gpTemp.Controls.Add(Me.TextBox22)
        Me.gpTemp.Controls.Add(Me.TextBox23)
        Me.gpTemp.Controls.Add(Me.TextBox21)
        Me.gpTemp.Controls.Add(Me.TextBox20)
        Me.gpTemp.Controls.Add(Me.TextBox19)
        Me.gpTemp.Controls.Add(Me.TextBox18)
        Me.gpTemp.Controls.Add(Me.TextBox17)
        Me.gpTemp.Controls.Add(Me.TextBox16)
        Me.gpTemp.Controls.Add(Me.TextBox15)
        Me.gpTemp.Controls.Add(Me.TextBox14)
        Me.gpTemp.Controls.Add(Me.TextBox13)
        Me.gpTemp.Controls.Add(Me.TextBox12)
        Me.gpTemp.Controls.Add(Me.TextBox11)
        Me.gpTemp.Controls.Add(Me.TextBox10)
        Me.gpTemp.Controls.Add(Me.TextBox9)
        Me.gpTemp.Controls.Add(Me.TextBox8)
        Me.gpTemp.Controls.Add(Me.TextBox7)
        Me.gpTemp.Controls.Add(Me.TextBox6)
        Me.gpTemp.Controls.Add(Me.TextBox5)
        Me.gpTemp.Controls.Add(Me.TextBox4)
        Me.gpTemp.Controls.Add(Me.TextBox3)
        Me.gpTemp.Controls.Add(Me.TextBox2)
        Me.gpTemp.Location = New System.Drawing.Point(950, 191)
        Me.gpTemp.Name = "gpTemp"
        Me.gpTemp.Size = New System.Drawing.Size(231, 385)
        Me.gpTemp.TabIndex = 24
        Me.gpTemp.TabStop = False
        Me.gpTemp.Text = "Temp"
        '
        'TextBox24
        '
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld19", True))
        Me.TextBox24.Location = New System.Drawing.Point(10, 351)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 22)
        Me.TextBox24.TabIndex = 22
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld20", True))
        Me.TextBox22.Location = New System.Drawing.Point(7, 313)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 22)
        Me.TextBox22.TabIndex = 21
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld23", True))
        Me.TextBox23.Location = New System.Drawing.Point(116, 313)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 22)
        Me.TextBox23.TabIndex = 20
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "feld21", True))
        Me.TextBox21.Location = New System.Drawing.Point(117, 284)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 22)
        Me.TextBox21.TabIndex = 19
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld20", True))
        Me.TextBox20.Location = New System.Drawing.Point(117, 255)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 22)
        Me.TextBox20.TabIndex = 18
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld19", True))
        Me.TextBox19.Location = New System.Drawing.Point(116, 229)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 22)
        Me.TextBox19.TabIndex = 17
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld18", True))
        Me.TextBox18.Location = New System.Drawing.Point(117, 197)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 22)
        Me.TextBox18.TabIndex = 16
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld17", True))
        Me.TextBox17.Location = New System.Drawing.Point(117, 168)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 22)
        Me.TextBox17.TabIndex = 15
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld16", True))
        Me.TextBox16.Location = New System.Drawing.Point(117, 139)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 22)
        Me.TextBox16.TabIndex = 14
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld15", True))
        Me.TextBox15.Location = New System.Drawing.Point(116, 110)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 22)
        Me.TextBox15.TabIndex = 13
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld14", True))
        Me.TextBox14.Location = New System.Drawing.Point(116, 81)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 22)
        Me.TextBox14.TabIndex = 12
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld13", True))
        Me.TextBox13.Location = New System.Drawing.Point(116, 52)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 22)
        Me.TextBox13.TabIndex = 11
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld12", True))
        Me.TextBox12.Location = New System.Drawing.Point(117, 23)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 22)
        Me.TextBox12.TabIndex = 10
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld11", True))
        Me.TextBox11.Location = New System.Drawing.Point(10, 283)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 22)
        Me.TextBox11.TabIndex = 9
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld10", True))
        Me.TextBox10.Location = New System.Drawing.Point(10, 255)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 22)
        Me.TextBox10.TabIndex = 8
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld9", True))
        Me.TextBox9.Location = New System.Drawing.Point(10, 226)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 22)
        Me.TextBox9.TabIndex = 7
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld8", True))
        Me.TextBox8.Location = New System.Drawing.Point(10, 196)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 22)
        Me.TextBox8.TabIndex = 6
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld7", True))
        Me.TextBox7.Location = New System.Drawing.Point(10, 167)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld6", True))
        Me.TextBox6.Location = New System.Drawing.Point(10, 138)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld5", True))
        Me.TextBox5.Location = New System.Drawing.Point(10, 109)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld4", True))
        Me.TextBox4.Location = New System.Drawing.Point(10, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld3", True))
        Me.TextBox3.Location = New System.Drawing.Point(10, 51)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld2", True))
        Me.TextBox2.Location = New System.Drawing.Point(10, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 0
        '
        'DataGridView8
        '
        Me.DataGridView8.AutoGenerateColumns = False
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn7, Me.BootnameDataGridViewTextBoxColumn, Me.MarkeDataGridViewTextBoxColumn, Me.SchiffstypDataGridViewTextBoxColumn, Me.KielartDataGridViewTextBoxColumn, Me.SchiffsnummerDataGridViewTextBoxColumn, Me.DurchfahrtshoeheDataGridViewTextBoxColumn, Me.LängeDataGridViewTextBoxColumn, Me.BreiteDataGridViewTextBoxColumn, Me.VerdrängungDataGridViewTextBoxColumn, Me.TiefgangDataGridViewTextBoxColumn, Me.GroßsegelDataGridViewTextBoxColumn, Me.VorsegelDataGridViewTextBoxColumn, Me.WassertankDataGridViewTextBoxColumn, Me.DieseltankDataGridViewTextBoxColumn, Me.StarterbatterieDataGridViewTextBoxColumn, Me.ServicebatterieDataGridViewTextBoxColumn, Me.KabinenanzahlDataGridViewTextBoxColumn, Me.KojenanzahlDataGridViewTextBoxColumn, Me.NassraeumeanzahlDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.KautionDataGridViewTextBoxColumn, Me.BildDataGridViewTextBoxColumn, Me.CharterfirmaDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn3, Me.TestDataGridViewTextBoxColumn, Me.GrosssegelartDataGridViewTextBoxColumn, Me.BaujahrDataGridViewTextBoxColumn, Me.MarinaortDataGridViewTextBoxColumn, Me.MarinaDataGridViewTextBoxColumn, Me.AnsprechspersonDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.RadarDataGridViewCheckBoxColumn, Me.BugstrahlruderDataGridViewCheckBoxColumn, Me.ClubnachlasDataGridViewCheckBoxColumn, Me.HeizungDataGridViewCheckBoxColumn, Me.KlimaanlageDataGridViewCheckBoxColumn, Me.MMSIDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn1, Me.R2DataGridViewTextBoxColumn1, Me.R3DataGridViewTextBoxColumn1, Me.MotoryachtDataGridViewCheckBoxColumn, Me.SegelyachtDataGridViewCheckBoxColumn, Me.VerbrauchLiterproSmDataGridViewTextBoxColumn, Me.ReinigungDataGridViewTextBoxColumn, Me.BettzeugDataGridViewTextBoxColumn, Me.AussenborderDataGridViewTextBoxColumn, Me.GasDataGridViewTextBoxColumn, Me.SpinakerDataGridViewTextBoxColumn, Me.PermitDataGridViewTextBoxColumn, Me.MarinakostenDataGridViewTextBoxColumn, Me.SonstigeKostenDataGridViewTextBoxColumn, Me.InverterDataGridViewTextBoxColumn, Me.WiFiDataGridViewTextBoxColumn})
        Me.DataGridView8.DataSource = Me.bsBoot
        Me.DataGridView8.Location = New System.Drawing.Point(846, 31)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.Size = New System.Drawing.Size(79, 124)
        Me.DataGridView8.TabIndex = 25
        '
        'IDDataGridViewTextBoxColumn7
        '
        Me.IDDataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn7.Name = "IDDataGridViewTextBoxColumn7"
        '
        'BootnameDataGridViewTextBoxColumn
        '
        Me.BootnameDataGridViewTextBoxColumn.DataPropertyName = "Bootname"
        Me.BootnameDataGridViewTextBoxColumn.HeaderText = "Bootname"
        Me.BootnameDataGridViewTextBoxColumn.Name = "BootnameDataGridViewTextBoxColumn"
        '
        'MarkeDataGridViewTextBoxColumn
        '
        Me.MarkeDataGridViewTextBoxColumn.DataPropertyName = "Marke"
        Me.MarkeDataGridViewTextBoxColumn.HeaderText = "Marke"
        Me.MarkeDataGridViewTextBoxColumn.Name = "MarkeDataGridViewTextBoxColumn"
        '
        'SchiffstypDataGridViewTextBoxColumn
        '
        Me.SchiffstypDataGridViewTextBoxColumn.DataPropertyName = "Schiffstyp"
        Me.SchiffstypDataGridViewTextBoxColumn.HeaderText = "Schiffstyp"
        Me.SchiffstypDataGridViewTextBoxColumn.Name = "SchiffstypDataGridViewTextBoxColumn"
        '
        'KielartDataGridViewTextBoxColumn
        '
        Me.KielartDataGridViewTextBoxColumn.DataPropertyName = "Kielart"
        Me.KielartDataGridViewTextBoxColumn.HeaderText = "Kielart"
        Me.KielartDataGridViewTextBoxColumn.Name = "KielartDataGridViewTextBoxColumn"
        '
        'SchiffsnummerDataGridViewTextBoxColumn
        '
        Me.SchiffsnummerDataGridViewTextBoxColumn.DataPropertyName = "Schiffsnummer"
        Me.SchiffsnummerDataGridViewTextBoxColumn.HeaderText = "Schiffsnummer"
        Me.SchiffsnummerDataGridViewTextBoxColumn.Name = "SchiffsnummerDataGridViewTextBoxColumn"
        '
        'DurchfahrtshoeheDataGridViewTextBoxColumn
        '
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn.DataPropertyName = "Durchfahrtshoehe"
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn.HeaderText = "Durchfahrtshoehe"
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn.Name = "DurchfahrtshoeheDataGridViewTextBoxColumn"
        '
        'LängeDataGridViewTextBoxColumn
        '
        Me.LängeDataGridViewTextBoxColumn.DataPropertyName = "Länge"
        Me.LängeDataGridViewTextBoxColumn.HeaderText = "Länge"
        Me.LängeDataGridViewTextBoxColumn.Name = "LängeDataGridViewTextBoxColumn"
        '
        'BreiteDataGridViewTextBoxColumn
        '
        Me.BreiteDataGridViewTextBoxColumn.DataPropertyName = "Breite"
        Me.BreiteDataGridViewTextBoxColumn.HeaderText = "Breite"
        Me.BreiteDataGridViewTextBoxColumn.Name = "BreiteDataGridViewTextBoxColumn"
        '
        'VerdrängungDataGridViewTextBoxColumn
        '
        Me.VerdrängungDataGridViewTextBoxColumn.DataPropertyName = "Verdrängung"
        Me.VerdrängungDataGridViewTextBoxColumn.HeaderText = "Verdrängung"
        Me.VerdrängungDataGridViewTextBoxColumn.Name = "VerdrängungDataGridViewTextBoxColumn"
        '
        'TiefgangDataGridViewTextBoxColumn
        '
        Me.TiefgangDataGridViewTextBoxColumn.DataPropertyName = "Tiefgang"
        Me.TiefgangDataGridViewTextBoxColumn.HeaderText = "Tiefgang"
        Me.TiefgangDataGridViewTextBoxColumn.Name = "TiefgangDataGridViewTextBoxColumn"
        '
        'GroßsegelDataGridViewTextBoxColumn
        '
        Me.GroßsegelDataGridViewTextBoxColumn.DataPropertyName = "Großsegel"
        Me.GroßsegelDataGridViewTextBoxColumn.HeaderText = "Großsegel"
        Me.GroßsegelDataGridViewTextBoxColumn.Name = "GroßsegelDataGridViewTextBoxColumn"
        '
        'VorsegelDataGridViewTextBoxColumn
        '
        Me.VorsegelDataGridViewTextBoxColumn.DataPropertyName = "Vorsegel"
        Me.VorsegelDataGridViewTextBoxColumn.HeaderText = "Vorsegel"
        Me.VorsegelDataGridViewTextBoxColumn.Name = "VorsegelDataGridViewTextBoxColumn"
        '
        'WassertankDataGridViewTextBoxColumn
        '
        Me.WassertankDataGridViewTextBoxColumn.DataPropertyName = "Wassertank"
        Me.WassertankDataGridViewTextBoxColumn.HeaderText = "Wassertank"
        Me.WassertankDataGridViewTextBoxColumn.Name = "WassertankDataGridViewTextBoxColumn"
        '
        'DieseltankDataGridViewTextBoxColumn
        '
        Me.DieseltankDataGridViewTextBoxColumn.DataPropertyName = "Dieseltank"
        Me.DieseltankDataGridViewTextBoxColumn.HeaderText = "Dieseltank"
        Me.DieseltankDataGridViewTextBoxColumn.Name = "DieseltankDataGridViewTextBoxColumn"
        '
        'StarterbatterieDataGridViewTextBoxColumn
        '
        Me.StarterbatterieDataGridViewTextBoxColumn.DataPropertyName = "Starterbatterie"
        Me.StarterbatterieDataGridViewTextBoxColumn.HeaderText = "Starterbatterie"
        Me.StarterbatterieDataGridViewTextBoxColumn.Name = "StarterbatterieDataGridViewTextBoxColumn"
        '
        'ServicebatterieDataGridViewTextBoxColumn
        '
        Me.ServicebatterieDataGridViewTextBoxColumn.DataPropertyName = "Servicebatterie"
        Me.ServicebatterieDataGridViewTextBoxColumn.HeaderText = "Servicebatterie"
        Me.ServicebatterieDataGridViewTextBoxColumn.Name = "ServicebatterieDataGridViewTextBoxColumn"
        '
        'KabinenanzahlDataGridViewTextBoxColumn
        '
        Me.KabinenanzahlDataGridViewTextBoxColumn.DataPropertyName = "Kabinenanzahl"
        Me.KabinenanzahlDataGridViewTextBoxColumn.HeaderText = "Kabinenanzahl"
        Me.KabinenanzahlDataGridViewTextBoxColumn.Name = "KabinenanzahlDataGridViewTextBoxColumn"
        '
        'KojenanzahlDataGridViewTextBoxColumn
        '
        Me.KojenanzahlDataGridViewTextBoxColumn.DataPropertyName = "Kojenanzahl"
        Me.KojenanzahlDataGridViewTextBoxColumn.HeaderText = "Kojenanzahl"
        Me.KojenanzahlDataGridViewTextBoxColumn.Name = "KojenanzahlDataGridViewTextBoxColumn"
        '
        'NassraeumeanzahlDataGridViewTextBoxColumn
        '
        Me.NassraeumeanzahlDataGridViewTextBoxColumn.DataPropertyName = "Nassraeumeanzahl"
        Me.NassraeumeanzahlDataGridViewTextBoxColumn.HeaderText = "Nassraeumeanzahl"
        Me.NassraeumeanzahlDataGridViewTextBoxColumn.Name = "NassraeumeanzahlDataGridViewTextBoxColumn"
        '
        'MotorDataGridViewTextBoxColumn
        '
        Me.MotorDataGridViewTextBoxColumn.DataPropertyName = "Motor"
        Me.MotorDataGridViewTextBoxColumn.HeaderText = "Motor"
        Me.MotorDataGridViewTextBoxColumn.Name = "MotorDataGridViewTextBoxColumn"
        '
        'KautionDataGridViewTextBoxColumn
        '
        Me.KautionDataGridViewTextBoxColumn.DataPropertyName = "Kaution"
        Me.KautionDataGridViewTextBoxColumn.HeaderText = "Kaution"
        Me.KautionDataGridViewTextBoxColumn.Name = "KautionDataGridViewTextBoxColumn"
        '
        'BildDataGridViewTextBoxColumn
        '
        Me.BildDataGridViewTextBoxColumn.DataPropertyName = "Bild"
        Me.BildDataGridViewTextBoxColumn.HeaderText = "Bild"
        Me.BildDataGridViewTextBoxColumn.Name = "BildDataGridViewTextBoxColumn"
        '
        'CharterfirmaDataGridViewTextBoxColumn
        '
        Me.CharterfirmaDataGridViewTextBoxColumn.DataPropertyName = "Charterfirma"
        Me.CharterfirmaDataGridViewTextBoxColumn.HeaderText = "Charterfirma"
        Me.CharterfirmaDataGridViewTextBoxColumn.Name = "CharterfirmaDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn3
        '
        Me.BemerkungDataGridViewTextBoxColumn3.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn3.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn3.Name = "BemerkungDataGridViewTextBoxColumn3"
        '
        'TestDataGridViewTextBoxColumn
        '
        Me.TestDataGridViewTextBoxColumn.DataPropertyName = "test"
        Me.TestDataGridViewTextBoxColumn.HeaderText = "test"
        Me.TestDataGridViewTextBoxColumn.Name = "TestDataGridViewTextBoxColumn"
        '
        'GrosssegelartDataGridViewTextBoxColumn
        '
        Me.GrosssegelartDataGridViewTextBoxColumn.DataPropertyName = "Grosssegelart"
        Me.GrosssegelartDataGridViewTextBoxColumn.HeaderText = "Grosssegelart"
        Me.GrosssegelartDataGridViewTextBoxColumn.Name = "GrosssegelartDataGridViewTextBoxColumn"
        '
        'BaujahrDataGridViewTextBoxColumn
        '
        Me.BaujahrDataGridViewTextBoxColumn.DataPropertyName = "Baujahr"
        Me.BaujahrDataGridViewTextBoxColumn.HeaderText = "Baujahr"
        Me.BaujahrDataGridViewTextBoxColumn.Name = "BaujahrDataGridViewTextBoxColumn"
        '
        'MarinaortDataGridViewTextBoxColumn
        '
        Me.MarinaortDataGridViewTextBoxColumn.DataPropertyName = "Marinaort"
        Me.MarinaortDataGridViewTextBoxColumn.HeaderText = "Marinaort"
        Me.MarinaortDataGridViewTextBoxColumn.Name = "MarinaortDataGridViewTextBoxColumn"
        '
        'MarinaDataGridViewTextBoxColumn
        '
        Me.MarinaDataGridViewTextBoxColumn.DataPropertyName = "Marina"
        Me.MarinaDataGridViewTextBoxColumn.HeaderText = "Marina"
        Me.MarinaDataGridViewTextBoxColumn.Name = "MarinaDataGridViewTextBoxColumn"
        '
        'AnsprechspersonDataGridViewTextBoxColumn
        '
        Me.AnsprechspersonDataGridViewTextBoxColumn.DataPropertyName = "Ansprechsperson"
        Me.AnsprechspersonDataGridViewTextBoxColumn.HeaderText = "Ansprechsperson"
        Me.AnsprechspersonDataGridViewTextBoxColumn.Name = "AnsprechspersonDataGridViewTextBoxColumn"
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        '
        'RadarDataGridViewCheckBoxColumn
        '
        Me.RadarDataGridViewCheckBoxColumn.DataPropertyName = "Radar"
        Me.RadarDataGridViewCheckBoxColumn.HeaderText = "Radar"
        Me.RadarDataGridViewCheckBoxColumn.Name = "RadarDataGridViewCheckBoxColumn"
        '
        'BugstrahlruderDataGridViewCheckBoxColumn
        '
        Me.BugstrahlruderDataGridViewCheckBoxColumn.DataPropertyName = "Bugstrahlruder"
        Me.BugstrahlruderDataGridViewCheckBoxColumn.HeaderText = "Bugstrahlruder"
        Me.BugstrahlruderDataGridViewCheckBoxColumn.Name = "BugstrahlruderDataGridViewCheckBoxColumn"
        '
        'ClubnachlasDataGridViewCheckBoxColumn
        '
        Me.ClubnachlasDataGridViewCheckBoxColumn.DataPropertyName = "Clubnachlas"
        Me.ClubnachlasDataGridViewCheckBoxColumn.HeaderText = "Clubnachlas"
        Me.ClubnachlasDataGridViewCheckBoxColumn.Name = "ClubnachlasDataGridViewCheckBoxColumn"
        '
        'HeizungDataGridViewCheckBoxColumn
        '
        Me.HeizungDataGridViewCheckBoxColumn.DataPropertyName = "Heizung"
        Me.HeizungDataGridViewCheckBoxColumn.HeaderText = "Heizung"
        Me.HeizungDataGridViewCheckBoxColumn.Name = "HeizungDataGridViewCheckBoxColumn"
        '
        'KlimaanlageDataGridViewCheckBoxColumn
        '
        Me.KlimaanlageDataGridViewCheckBoxColumn.DataPropertyName = "Klimaanlage"
        Me.KlimaanlageDataGridViewCheckBoxColumn.HeaderText = "Klimaanlage"
        Me.KlimaanlageDataGridViewCheckBoxColumn.Name = "KlimaanlageDataGridViewCheckBoxColumn"
        '
        'MMSIDataGridViewTextBoxColumn
        '
        Me.MMSIDataGridViewTextBoxColumn.DataPropertyName = "MMSI"
        Me.MMSIDataGridViewTextBoxColumn.HeaderText = "MMSI"
        Me.MMSIDataGridViewTextBoxColumn.Name = "MMSIDataGridViewTextBoxColumn"
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
        'MotoryachtDataGridViewCheckBoxColumn
        '
        Me.MotoryachtDataGridViewCheckBoxColumn.DataPropertyName = "Motoryacht"
        Me.MotoryachtDataGridViewCheckBoxColumn.HeaderText = "Motoryacht"
        Me.MotoryachtDataGridViewCheckBoxColumn.Name = "MotoryachtDataGridViewCheckBoxColumn"
        '
        'SegelyachtDataGridViewCheckBoxColumn
        '
        Me.SegelyachtDataGridViewCheckBoxColumn.DataPropertyName = "Segelyacht"
        Me.SegelyachtDataGridViewCheckBoxColumn.HeaderText = "Segelyacht"
        Me.SegelyachtDataGridViewCheckBoxColumn.Name = "SegelyachtDataGridViewCheckBoxColumn"
        '
        'VerbrauchLiterproSmDataGridViewTextBoxColumn
        '
        Me.VerbrauchLiterproSmDataGridViewTextBoxColumn.DataPropertyName = "VerbrauchLiterproSm"
        Me.VerbrauchLiterproSmDataGridViewTextBoxColumn.HeaderText = "VerbrauchLiterproSm"
        Me.VerbrauchLiterproSmDataGridViewTextBoxColumn.Name = "VerbrauchLiterproSmDataGridViewTextBoxColumn"
        '
        'ReinigungDataGridViewTextBoxColumn
        '
        Me.ReinigungDataGridViewTextBoxColumn.DataPropertyName = "Reinigung"
        Me.ReinigungDataGridViewTextBoxColumn.HeaderText = "Reinigung"
        Me.ReinigungDataGridViewTextBoxColumn.Name = "ReinigungDataGridViewTextBoxColumn"
        '
        'BettzeugDataGridViewTextBoxColumn
        '
        Me.BettzeugDataGridViewTextBoxColumn.DataPropertyName = "Bettzeug"
        Me.BettzeugDataGridViewTextBoxColumn.HeaderText = "Bettzeug"
        Me.BettzeugDataGridViewTextBoxColumn.Name = "BettzeugDataGridViewTextBoxColumn"
        '
        'AussenborderDataGridViewTextBoxColumn
        '
        Me.AussenborderDataGridViewTextBoxColumn.DataPropertyName = "Aussenborder"
        Me.AussenborderDataGridViewTextBoxColumn.HeaderText = "Aussenborder"
        Me.AussenborderDataGridViewTextBoxColumn.Name = "AussenborderDataGridViewTextBoxColumn"
        '
        'GasDataGridViewTextBoxColumn
        '
        Me.GasDataGridViewTextBoxColumn.DataPropertyName = "Gas"
        Me.GasDataGridViewTextBoxColumn.HeaderText = "Gas"
        Me.GasDataGridViewTextBoxColumn.Name = "GasDataGridViewTextBoxColumn"
        '
        'SpinakerDataGridViewTextBoxColumn
        '
        Me.SpinakerDataGridViewTextBoxColumn.DataPropertyName = "Spinaker"
        Me.SpinakerDataGridViewTextBoxColumn.HeaderText = "Spinaker"
        Me.SpinakerDataGridViewTextBoxColumn.Name = "SpinakerDataGridViewTextBoxColumn"
        '
        'PermitDataGridViewTextBoxColumn
        '
        Me.PermitDataGridViewTextBoxColumn.DataPropertyName = "Permit"
        Me.PermitDataGridViewTextBoxColumn.HeaderText = "Permit"
        Me.PermitDataGridViewTextBoxColumn.Name = "PermitDataGridViewTextBoxColumn"
        '
        'MarinakostenDataGridViewTextBoxColumn
        '
        Me.MarinakostenDataGridViewTextBoxColumn.DataPropertyName = "Marinakosten"
        Me.MarinakostenDataGridViewTextBoxColumn.HeaderText = "Marinakosten"
        Me.MarinakostenDataGridViewTextBoxColumn.Name = "MarinakostenDataGridViewTextBoxColumn"
        '
        'SonstigeKostenDataGridViewTextBoxColumn
        '
        Me.SonstigeKostenDataGridViewTextBoxColumn.DataPropertyName = "SonstigeKosten"
        Me.SonstigeKostenDataGridViewTextBoxColumn.HeaderText = "SonstigeKosten"
        Me.SonstigeKostenDataGridViewTextBoxColumn.Name = "SonstigeKostenDataGridViewTextBoxColumn"
        '
        'InverterDataGridViewTextBoxColumn
        '
        Me.InverterDataGridViewTextBoxColumn.DataPropertyName = "Inverter"
        Me.InverterDataGridViewTextBoxColumn.HeaderText = "Inverter"
        Me.InverterDataGridViewTextBoxColumn.Name = "InverterDataGridViewTextBoxColumn"
        '
        'WiFiDataGridViewTextBoxColumn
        '
        Me.WiFiDataGridViewTextBoxColumn.DataPropertyName = "WiFi"
        Me.WiFiDataGridViewTextBoxColumn.HeaderText = "WiFi"
        Me.WiFiDataGridViewTextBoxColumn.Name = "WiFiDataGridViewTextBoxColumn"
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
        'BtBearbeiten
        '
        Me.BtBearbeiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtBearbeiten.Location = New System.Drawing.Point(587, 130)
        Me.BtBearbeiten.Name = "BtBearbeiten"
        Me.BtBearbeiten.Size = New System.Drawing.Size(138, 37)
        Me.BtBearbeiten.TabIndex = 26
        Me.BtBearbeiten.Text = "Übernehmen"
        Me.BtBearbeiten.UseVisualStyleBackColor = True
        '
        'DataGridView9
        '
        Me.DataGridView9.AutoGenerateColumns = False
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn8, Me.ToernDataGridViewTextBoxColumn, Me.VZnameDataGridViewTextBoxColumn, Me.SmNachweisDataGridViewCheckBoxColumn, Me.WachfuehrerDataGridViewCheckBoxColumn, Me.NavigatorDataGridViewCheckBoxColumn, Me.RudergaengerDataGridViewCheckBoxColumn, Me.R1DataGridViewTextBoxColumn2, Me.R2DataGridViewTextBoxColumn2, Me.R3DataGridViewTextBoxColumn2, Me.IDToernDataGridViewTextBoxColumn1, Me.NachtaHafen1DataGridViewTextBoxColumn, Me.NachtaDatum1DataGridViewTextBoxColumn, Me.NachtaZeit1DataGridViewTextBoxColumn, Me.NachtaHafen2DataGridViewTextBoxColumn, Me.NachtaDatum2DataGridViewTextBoxColumn, Me.NachtaZeit2DataGridViewTextBoxColumn, Me.NachtaHafen3DataGridViewTextBoxColumn, Me.NachtaDatum3DataGridViewTextBoxColumn, Me.NachtaZeit3DataGridViewTextBoxColumn})
        Me.DataGridView9.DataSource = Me.bsTC
        Me.DataGridView9.Location = New System.Drawing.Point(847, 187)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.Size = New System.Drawing.Size(77, 142)
        Me.DataGridView9.TabIndex = 27
        '
        'IDDataGridViewTextBoxColumn8
        '
        Me.IDDataGridViewTextBoxColumn8.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn8.Name = "IDDataGridViewTextBoxColumn8"
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
        'bsTC
        '
        Me.bsTC.DataMember = "TC"
        Me.bsTC.DataSource = Me.dsToernverwaltung
        '
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
        '
        'CrewBesprechungDruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 428)
        Me.Controls.Add(Me.DataGridView9)
        Me.Controls.Add(Me.DataGridView8)
        Me.Controls.Add(Me.gpTemp)
        Me.Controls.Add(Me.gbAuswertungen)
        Me.Controls.Add(Me.DataGridView7)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1Törn)
        Me.Controls.Add(Me.gbToern)
        Me.Controls.Add(Me.BtBearbeiten)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CrewBesprechungDruck"
        Me.Text = "Druck der Crewbesprechung"
        Me.gbToern.ResumeLayout(False)
        Me.gbToern.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAblauf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCrewbesprechung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1Törn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnRueckReise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsErsteTag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEinkaufsliste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAuswertungen.ResumeLayout(False)
        Me.gbAuswertungen.PerformLayout()
        Me.gpTemp.ResumeLayout(False)
        Me.gpTemp.PerformLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbToern As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1Törn As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dsCrewbesprechung As WindowsApplication1.CrewbesprechungDataSet
    Friend WithEvents bsAblauf As System.Windows.Forms.BindingSource
    Friend WithEvents taAblauf As WindowsApplication1.CrewbesprechungDataSetTableAdapters.AblaufTableAdapter
    Friend WithEvents ToernnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThemaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordkassaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PantryManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anwesender8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusgangsmarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndeMarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmSegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmGesamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfahrtenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtansteuerungenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordtageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TornberichtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetzterSegeltagDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordkassaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents bsCrewDetails As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewDetails As WindowsApplication1.CrewbesprechungDataSetTableAdapters.CrewDetailsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KenntnisseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BB1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BS1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HB1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HS1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockobenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockuntenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BS2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HS2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents bsAnRueckReise As System.Windows.Forms.BindingSource
    Friend WithEvents taAnRueckReise As WindowsApplication1.CrewbesprechungDataSetTableAdapters.AnRueckReiseTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CWNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CWAnkunftortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CWRueckreiseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CWAnkunftzeitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CWBemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CWKenntnisseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CWAbresieZeitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents bsErsteTag As System.Windows.Forms.BindingSource
    Friend WithEvents taErsteTag As WindowsApplication1.CrewbesprechungDataSetTableAdapters.ErsteTagTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WannDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents bsEinkaufsliste As System.Windows.Forms.BindingSource
    Friend WithEvents taEinkaufsliste As WindowsApplication1.CrewbesprechungDataSetTableAdapters.EinkaufslisteTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnameDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GruppeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtikelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MengeneinheitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MengeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView7 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTemp As System.Windows.Forms.BindingSource
    Friend WithEvents taTemp As WindowsApplication1.CrewbesprechungDataSetTableAdapters.TempTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Feld26DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld27DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld28DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld29DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld30DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld31DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents gbAuswertungen As System.Windows.Forms.GroupBox
    Friend WithEvents gpTemp As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbOrganisation As System.Windows.Forms.CheckBox
    Friend WithEvents cbPantry As System.Windows.Forms.CheckBox
    Friend WithEvents cbSkipper As System.Windows.Forms.CheckBox
    Friend WithEvents cbEinkaufsliste As System.Windows.Forms.CheckBox
    Friend WithEvents cbErsterTag As System.Windows.Forms.CheckBox
    Friend WithEvents cbCrewDetails As System.Windows.Forms.CheckBox
    Friend WithEvents cbAblauf As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarkeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchiffstypDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KielartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchiffsnummerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DurchfahrtshoeheDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LängeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BreiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerdrängungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiefgangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroßsegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VorsegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WassertankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DieseltankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StarterbatterieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicebatterieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KabinenanzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KojenanzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NassraeumeanzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KautionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BildDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharterfirmaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrosssegelartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaujahrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinaortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnsprechspersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadarDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BugstrahlruderDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClubnachlasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HeizungDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents KlimaanlageDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MMSIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotoryachtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SegelyachtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VerbrauchLiterproSmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReinigungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BettzeugDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AussenborderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpinakerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinakostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonstigeKostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InverterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WiFiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtBearbeiten As System.Windows.Forms.Button
    Friend WithEvents DataGridView9 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmNachweisDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WachfuehrerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NavigatorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RudergaengerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents cbSicherheit As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
End Class
