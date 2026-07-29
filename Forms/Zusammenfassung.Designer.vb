<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zusammenfassung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zusammenfassung))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridZuFa = New System.Windows.Forms.DataGridView()
        Me.DatumVonDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZeitVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZeitBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WindrichtungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Windstaerke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmuSegel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmuMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmGesamtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsZusammenfassung2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLogbuch = New WindowsApplication1.dsLogbuch()
        Me.DataGridtoern = New System.Windows.Forms.DataGridView()
        Me.ToernbezeichnungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bootsname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusgangsmarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndeMarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmSegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmGesamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfahrtenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtansteuerungenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordtageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TornberichtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toernbezeichnung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeemeilenM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeemeilenS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorStd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nachtfahrten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nachtansteuerungen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KartenMissweisung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sonnenaufgang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sonnenuntergang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Navtexstationen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vollmond = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxTidenhub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sonstiges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDokumentation = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.bsToerndaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.bsLogdaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.taLogdaten = New WindowsApplication1.dsLogbuchTableAdapters.LogdatenTableAdapter()
        Me.taZusammenfassung2 = New WindowsApplication1.dsLogbuchTableAdapters.Zusammenfassung2TableAdapter()
        Me.taDokumentation = New WindowsApplication1.dsLogbuchTableAdapters.DokumentationTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SynchronDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MethodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLogWacheplan = New System.Windows.Forms.BindingSource(Me.components)
        Me.taLogWacheplan = New WindowsApplication1.dsLogbuchTableAdapters.LogWacheplanTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.taTc = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeemeilenMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeemeilenSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorStdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfahrtenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtansteuerungenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KartenMissweisungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonnenaufgangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonnenuntergangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavtexstationenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VollmondDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxTidenhubDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonstigesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeplanteRouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KassaManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErsteinzahlungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PantryManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErsteinkaufDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevierBildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GefahreneRouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.taToerndaten = New WindowsApplication1.dsLogbuchTableAdapters.ToerndatenTableAdapter()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TextBox42nfv2 = New System.Windows.Forms.TextBox()
        Me.TextBox43nfb2 = New System.Windows.Forms.TextBox()
        Me.TextBox44sm2 = New System.Windows.Forms.TextBox()
        Me.TextBox45Ndv2 = New System.Windows.Forms.TextBox()
        Me.TextBox46nzv2 = New System.Windows.Forms.TextBox()
        Me.TextBox47Ndb2 = New System.Windows.Forms.TextBox()
        Me.TextBox48nzb2 = New System.Windows.Forms.TextBox()
        Me.TextBox48Nzb = New System.Windows.Forms.TextBox()
        Me.TextBox47Ndb = New System.Windows.Forms.TextBox()
        Me.TextBox46Nzv = New System.Windows.Forms.TextBox()
        Me.TextBox45NDv = New System.Windows.Forms.TextBox()
        Me.TextBox44sm = New System.Windows.Forms.TextBox()
        Me.TextBox43Nfb = New System.Windows.Forms.TextBox()
        Me.TextBox42NFv = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SynchronDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MethodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZName1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZName2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsWacheplan = New System.Windows.Forms.BindingSource(Me.components)
        Me.taWacheplan = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridZuFa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsZusammenfassung2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridtoern, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDokumentation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.bsToerndaten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.bsLogdaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogWacheplan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 603)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Törn"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(510, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Bootsname:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(119, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Bootsname", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(596, 30)
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
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Törnbezeichnung"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Toernbezeichnung", True))
        Me.TextBox1.Location = New System.Drawing.Point(165, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 22)
        Me.TextBox1.TabIndex = 0
        '
        'DataGridZuFa
        '
        Me.DataGridZuFa.AutoGenerateColumns = False
        Me.DataGridZuFa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridZuFa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatumVonDataGridViewTextBoxColumn1, Me.ZeitVonDataGridViewTextBoxColumn, Me.AusfahrtDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn1, Me.ZeitBisDataGridViewTextBoxColumn, Me.ZielDataGridViewTextBoxColumn, Me.WindrichtungDataGridViewTextBoxColumn, Me.Windstaerke, Me.SmuSegel, Me.SmuMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn1, Me.BemerkungDataGridViewTextBoxColumn1, Me.ToernbezeichnungDataGridViewTextBoxColumn})
        Me.DataGridZuFa.DataSource = Me.bsZusammenfassung2
        Me.DataGridZuFa.Location = New System.Drawing.Point(9, 21)
        Me.DataGridZuFa.Name = "DataGridZuFa"
        Me.DataGridZuFa.Size = New System.Drawing.Size(936, 300)
        Me.DataGridZuFa.TabIndex = 2
        '
        'DatumVonDataGridViewTextBoxColumn1
        '
        Me.DatumVonDataGridViewTextBoxColumn1.DataPropertyName = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn1.HeaderText = "Datum von"
        Me.DatumVonDataGridViewTextBoxColumn1.Name = "DatumVonDataGridViewTextBoxColumn1"
        Me.DatumVonDataGridViewTextBoxColumn1.Width = 80
        '
        'ZeitVonDataGridViewTextBoxColumn
        '
        Me.ZeitVonDataGridViewTextBoxColumn.DataPropertyName = "ZeitVon"
        Me.ZeitVonDataGridViewTextBoxColumn.HeaderText = "Zeit von"
        Me.ZeitVonDataGridViewTextBoxColumn.Name = "ZeitVonDataGridViewTextBoxColumn"
        Me.ZeitVonDataGridViewTextBoxColumn.Width = 50
        '
        'AusfahrtDataGridViewTextBoxColumn
        '
        Me.AusfahrtDataGridViewTextBoxColumn.DataPropertyName = "Ausfahrt"
        Me.AusfahrtDataGridViewTextBoxColumn.HeaderText = "Ausfahrt"
        Me.AusfahrtDataGridViewTextBoxColumn.Name = "AusfahrtDataGridViewTextBoxColumn"
        Me.AusfahrtDataGridViewTextBoxColumn.Width = 150
        '
        'DatumBisDataGridViewTextBoxColumn1
        '
        Me.DatumBisDataGridViewTextBoxColumn1.DataPropertyName = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn1.HeaderText = "Datum bis"
        Me.DatumBisDataGridViewTextBoxColumn1.Name = "DatumBisDataGridViewTextBoxColumn1"
        Me.DatumBisDataGridViewTextBoxColumn1.Width = 80
        '
        'ZeitBisDataGridViewTextBoxColumn
        '
        Me.ZeitBisDataGridViewTextBoxColumn.DataPropertyName = "ZeitBis"
        Me.ZeitBisDataGridViewTextBoxColumn.HeaderText = "Zeit bis"
        Me.ZeitBisDataGridViewTextBoxColumn.Name = "ZeitBisDataGridViewTextBoxColumn"
        Me.ZeitBisDataGridViewTextBoxColumn.Width = 50
        '
        'ZielDataGridViewTextBoxColumn
        '
        Me.ZielDataGridViewTextBoxColumn.DataPropertyName = "Ziel"
        Me.ZielDataGridViewTextBoxColumn.HeaderText = "Ziel"
        Me.ZielDataGridViewTextBoxColumn.Name = "ZielDataGridViewTextBoxColumn"
        Me.ZielDataGridViewTextBoxColumn.Width = 150
        '
        'WindrichtungDataGridViewTextBoxColumn
        '
        Me.WindrichtungDataGridViewTextBoxColumn.DataPropertyName = "Windrichtung"
        Me.WindrichtungDataGridViewTextBoxColumn.HeaderText = "Wind- richtung"
        Me.WindrichtungDataGridViewTextBoxColumn.Name = "WindrichtungDataGridViewTextBoxColumn"
        Me.WindrichtungDataGridViewTextBoxColumn.Width = 60
        '
        'Windstaerke
        '
        Me.Windstaerke.DataPropertyName = "Windstaerke"
        Me.Windstaerke.HeaderText = "Wind [kn]"
        Me.Windstaerke.Name = "Windstaerke"
        Me.Windstaerke.Width = 50
        '
        'SmuSegel
        '
        Me.SmuSegel.DataPropertyName = "SmuSegel"
        Me.SmuSegel.HeaderText = "Sm Segel"
        Me.SmuSegel.Name = "SmuSegel"
        Me.SmuSegel.Width = 50
        '
        'SmuMotorDataGridViewTextBoxColumn
        '
        Me.SmuMotorDataGridViewTextBoxColumn.DataPropertyName = "SmuMotor"
        Me.SmuMotorDataGridViewTextBoxColumn.HeaderText = "Sm Motor"
        Me.SmuMotorDataGridViewTextBoxColumn.Name = "SmuMotorDataGridViewTextBoxColumn"
        Me.SmuMotorDataGridViewTextBoxColumn.Width = 50
        '
        'SmGesamtDataGridViewTextBoxColumn1
        '
        Me.SmGesamtDataGridViewTextBoxColumn1.DataPropertyName = "SmGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn1.HeaderText = "Sm Gesamt"
        Me.SmGesamtDataGridViewTextBoxColumn1.Name = "SmGesamtDataGridViewTextBoxColumn1"
        Me.SmGesamtDataGridViewTextBoxColumn1.Width = 60
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        '
        'bsZusammenfassung2
        '
        Me.bsZusammenfassung2.DataMember = "Zusammenfassung2"
        Me.bsZusammenfassung2.DataSource = Me.DsLogbuch
        '
        'DsLogbuch
        '
        Me.DsLogbuch.DataSetName = "dsLogbuch"
        Me.DsLogbuch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridtoern
        '
        Me.DataGridtoern.AutoGenerateColumns = False
        Me.DataGridtoern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridtoern.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernbezeichnungDataGridViewTextBoxColumn1, Me.Bootsname, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn1, Me.NachtansteuerungenDataGridViewTextBoxColumn1, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.TornberichtDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.BordkassaDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.LogbuchDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn, Me.Nachtfahrtvon1DataGridViewTextBoxColumn, Me.Nachtfahrtbis1DataGridViewTextBoxColumn, Me.Sm1DataGridViewTextBoxColumn, Me.NachtfDatumvon1DataGridViewTextBoxColumn, Me.NachtZeitvon1DataGridViewTextBoxColumn, Me.NachtfDatumbis1DataGridViewTextBoxColumn, Me.NachtZeitbis1DataGridViewTextBoxColumn, Me.NachtFahrtvon2DataGridViewTextBoxColumn, Me.NachtFahrtbis2DataGridViewTextBoxColumn, Me.SM2DataGridViewTextBoxColumn, Me.NachtDatumvon2DataGridViewTextBoxColumn, Me.NachtZeitvon2DataGridViewTextBoxColumn, Me.NachtDatumbis2DataGridViewTextBoxColumn, Me.NachtZeitbis2DataGridViewTextBoxColumn, Me.Std50StartDataGridViewTextBoxColumn, Me.Std50ZielDataGridViewTextBoxColumn, Me.Std50SmGesDataGridViewTextBoxColumn, Me.Std50smFB2DataGridViewTextBoxColumn, Me.Std50DatumStartDataGridViewTextBoxColumn, Me.Std50ZeitStartDataGridViewTextBoxColumn, Me.Std50DatumZielDataGridViewTextBoxColumn, Me.Std50ZeitZielDataGridViewTextBoxColumn, Me.GezHafen1DataGridViewTextBoxColumn, Me.GezDatum1DataGridViewTextBoxColumn, Me.GezZeit1DataGridViewTextBoxColumn, Me.GezHafen2DataGridViewTextBoxColumn, Me.GezDatum2DataGridViewTextBoxColumn, Me.GezZeit2DataGridViewTextBoxColumn, Me.FB4StartDataGridViewTextBoxColumn, Me.FB4ZielDataGridViewTextBoxColumn, Me.FB4SmGesDataGridViewTextBoxColumn, Me.FB4SmFb3DataGridViewTextBoxColumn, Me.FB4DatumStartDataGridViewTextBoxColumn, Me.FB4ZeitStartDataGridViewTextBoxColumn, Me.FB4DatumZielDataGridViewTextBoxColumn, Me.FB4ZeitZielDataGridViewTextBoxColumn, Me.RevierDataGridViewTextBoxColumn, Me.VerbrauchproToernDataGridViewTextBoxColumn})
        Me.DataGridtoern.DataSource = Me.bsToernname
        Me.DataGridtoern.Location = New System.Drawing.Point(9, 21)
        Me.DataGridtoern.Name = "DataGridtoern"
        Me.DataGridtoern.Size = New System.Drawing.Size(936, 300)
        Me.DataGridtoern.TabIndex = 3
        '
        'ToernbezeichnungDataGridViewTextBoxColumn1
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.Name = "ToernbezeichnungDataGridViewTextBoxColumn1"
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.Width = 400
        '
        'Bootsname
        '
        Me.Bootsname.DataPropertyName = "Bootsname"
        Me.Bootsname.HeaderText = "Bootsname"
        Me.Bootsname.Name = "Bootsname"
        Me.Bootsname.Width = 200
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
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sm unter Segel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DataGridtoern)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DataGridZuFa)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(960, 404)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logbuch Auswertungen"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 359)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(936, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(804, 334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(666, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Nachtansteuerungen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(597, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(507, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nachtfahrten"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Motorstunden"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sm mit Motor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(6, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.Toernbezeichnung, Me.SeemeilenM, Me.SeemeilenS, Me.MotorStd, Me.Nachtfahrten, Me.Nachtansteuerungen, Me.KartenMissweisung, Me.Sonnenaufgang, Me.Sonnenuntergang, Me.Navtexstationen, Me.Vollmond, Me.MaxTidenhub, Me.Sonstiges, Me.R1, Me.R2, Me.R3})
        Me.DataGridView1.DataSource = Me.bsDokumentation
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'Toernbezeichnung
        '
        Me.Toernbezeichnung.DataPropertyName = "Toernbezeichnung"
        Me.Toernbezeichnung.HeaderText = "Toernbezeichnung"
        Me.Toernbezeichnung.Name = "Toernbezeichnung"
        '
        'SeemeilenM
        '
        Me.SeemeilenM.DataPropertyName = "SeemeilenM"
        Me.SeemeilenM.HeaderText = "SeemeilenM"
        Me.SeemeilenM.Name = "SeemeilenM"
        '
        'SeemeilenS
        '
        Me.SeemeilenS.DataPropertyName = "SeemeilenS"
        Me.SeemeilenS.HeaderText = "SeemeilenS"
        Me.SeemeilenS.Name = "SeemeilenS"
        '
        'MotorStd
        '
        Me.MotorStd.DataPropertyName = "MotorStd"
        Me.MotorStd.HeaderText = "MotorStd"
        Me.MotorStd.Name = "MotorStd"
        '
        'Nachtfahrten
        '
        Me.Nachtfahrten.DataPropertyName = "Nachtfahrten"
        Me.Nachtfahrten.HeaderText = "Nachtfahrten"
        Me.Nachtfahrten.Name = "Nachtfahrten"
        '
        'Nachtansteuerungen
        '
        Me.Nachtansteuerungen.DataPropertyName = "Nachtansteuerungen"
        Me.Nachtansteuerungen.HeaderText = "Nachtansteuerungen"
        Me.Nachtansteuerungen.Name = "Nachtansteuerungen"
        '
        'KartenMissweisung
        '
        Me.KartenMissweisung.DataPropertyName = "KartenMissweisung"
        Me.KartenMissweisung.HeaderText = "KartenMissweisung"
        Me.KartenMissweisung.Name = "KartenMissweisung"
        '
        'Sonnenaufgang
        '
        Me.Sonnenaufgang.DataPropertyName = "Sonnenaufgang"
        Me.Sonnenaufgang.HeaderText = "Sonnenaufgang"
        Me.Sonnenaufgang.Name = "Sonnenaufgang"
        '
        'Sonnenuntergang
        '
        Me.Sonnenuntergang.DataPropertyName = "Sonnenuntergang"
        Me.Sonnenuntergang.HeaderText = "Sonnenuntergang"
        Me.Sonnenuntergang.Name = "Sonnenuntergang"
        '
        'Navtexstationen
        '
        Me.Navtexstationen.DataPropertyName = "Navtexstationen"
        Me.Navtexstationen.HeaderText = "Navtexstationen"
        Me.Navtexstationen.Name = "Navtexstationen"
        '
        'Vollmond
        '
        Me.Vollmond.DataPropertyName = "Vollmond"
        Me.Vollmond.HeaderText = "Vollmond"
        Me.Vollmond.Name = "Vollmond"
        '
        'MaxTidenhub
        '
        Me.MaxTidenhub.DataPropertyName = "MaxTidenhub"
        Me.MaxTidenhub.HeaderText = "MaxTidenhub"
        Me.MaxTidenhub.Name = "MaxTidenhub"
        '
        'Sonstiges
        '
        Me.Sonstiges.DataPropertyName = "Sonstiges"
        Me.Sonstiges.HeaderText = "Sonstiges"
        Me.Sonstiges.Name = "Sonstiges"
        '
        'R1
        '
        Me.R1.DataPropertyName = "R1"
        Me.R1.HeaderText = "R1"
        Me.R1.Name = "R1"
        '
        'R2
        '
        Me.R2.DataPropertyName = "R2"
        Me.R2.HeaderText = "R2"
        Me.R2.Name = "R2"
        '
        'R3
        '
        Me.R3.DataPropertyName = "R3"
        Me.R3.HeaderText = "R3"
        Me.R3.Name = "R3"
        '
        'bsDokumentation
        '
        Me.bsDokumentation.DataMember = "Dokumentation"
        Me.bsDokumentation.DataSource = Me.DsLogbuch
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox26)
        Me.GroupBox4.Controls.Add(Me.TextBox25)
        Me.GroupBox4.Controls.Add(Me.TextBox24)
        Me.GroupBox4.Controls.Add(Me.TextBox23)
        Me.GroupBox4.Controls.Add(Me.TextBox22)
        Me.GroupBox4.Controls.Add(Me.TextBox19)
        Me.GroupBox4.Controls.Add(Me.TextBox18)
        Me.GroupBox4.Controls.Add(Me.TextBox17)
        Me.GroupBox4.Controls.Add(Me.TextBox16)
        Me.GroupBox4.Controls.Add(Me.TextBox15)
        Me.GroupBox4.Controls.Add(Me.TextBox14)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Controls.Add(Me.TextBox12)
        Me.GroupBox4.Controls.Add(Me.TextBox11)
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.Location = New System.Drawing.Point(1030, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(127, 610)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Zusammenfassung"
        '
        'TextBox26
        '
        Me.TextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Nachtansteuerungen", True))
        Me.TextBox26.Location = New System.Drawing.Point(7, 528)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(100, 20)
        Me.TextBox26.TabIndex = 30
        '
        'TextBox25
        '
        Me.TextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Nachtfahrten", True))
        Me.TextBox25.Location = New System.Drawing.Point(7, 501)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(100, 20)
        Me.TextBox25.TabIndex = 29
        '
        'TextBox24
        '
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "MotorStd", True))
        Me.TextBox24.Location = New System.Drawing.Point(7, 474)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 28
        '
        'bsToerndaten
        '
        Me.bsToerndaten.DataMember = "Toerndaten"
        Me.bsToerndaten.DataSource = Me.DsLogbuch
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "SeemeilenS", True))
        Me.TextBox23.Location = New System.Drawing.Point(7, 451)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 20)
        Me.TextBox23.TabIndex = 27
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "SeemeilenM", True))
        Me.TextBox22.Location = New System.Drawing.Point(7, 423)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 20)
        Me.TextBox22.TabIndex = 26
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "Windrichtung", True))
        Me.TextBox19.Location = New System.Drawing.Point(7, 397)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 25
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "Windstaerke", True))
        Me.TextBox18.Location = New System.Drawing.Point(7, 370)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 24
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "SmGesamt", True))
        Me.TextBox17.Location = New System.Drawing.Point(7, 342)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 23
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "SmuMotor", True))
        Me.TextBox16.Location = New System.Drawing.Point(7, 315)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 22
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "SmuSegel", True))
        Me.TextBox15.Location = New System.Drawing.Point(7, 288)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 21
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "DatumBis", True))
        Me.TextBox14.Location = New System.Drawing.Point(7, 261)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 20
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "Toernbezeichnung", True))
        Me.TextBox3.Location = New System.Drawing.Point(7, 234)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "ZeitBis", True))
        Me.TextBox13.Location = New System.Drawing.Point(7, 207)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 18
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "ZeitVon", True))
        Me.TextBox12.Location = New System.Drawing.Point(7, 180)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 17
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "DatumVon", True))
        Me.TextBox11.Location = New System.Drawing.Point(7, 153)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 16
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(6, 126)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "Ziel", True))
        Me.TextBox5.Location = New System.Drawing.Point(7, 99)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsZusammenfassung2, "Ausfahrt", True))
        Me.TextBox4.Location = New System.Drawing.Point(7, 72)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Sonnenuntergang", True))
        Me.TextBox6.Location = New System.Drawing.Point(0, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 32
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Sonnenaufgang", True))
        Me.TextBox2.Location = New System.Drawing.Point(0, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 31
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView2)
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(2006, 180)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(281, 398)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Logdaten"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 190)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Toernbezeichnung"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Toernbezeichnung"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SeemeilenM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SeemeilenM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SeemeilenS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SeemeilenS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MotorStd"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MotorStd"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nachtfahrten"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nachtfahrten"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nachtansteuerungen"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nachtansteuerungen"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "MotorStdAnfang", True))
        Me.TextBox20.Location = New System.Drawing.Point(6, 23)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 26
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "MotorStdEnde", True))
        Me.TextBox21.Location = New System.Drawing.Point(6, 49)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 20)
        Me.TextBox21.TabIndex = 27
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox21)
        Me.GroupBox6.Controls.Add(Me.TextBox20)
        Me.GroupBox6.Location = New System.Drawing.Point(1165, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(108, 88)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dokumentation"
        '
        'bsLogdaten
        '
        Me.bsLogdaten.DataMember = "Logdaten"
        Me.bsLogdaten.DataSource = Me.DsLogbuch
        '
        'taLogdaten
        '
        Me.taLogdaten.ClearBeforeFill = True
        '
        'taZusammenfassung2
        '
        Me.taZusammenfassung2.ClearBeforeFill = True
        '
        'taDokumentation
        '
        Me.taDokumentation.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(793, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Zusammesfassung aktuallisieren"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.ToernDataGridViewTextBoxColumn, Me.Person1DataGridViewTextBoxColumn, Me.Person2DataGridViewTextBoxColumn, Me.SynchronDataGridViewCheckBoxColumn, Me.MethodeDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.TextVonDataGridViewTextBoxColumn, Me.TextBisDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsLogWacheplan
        Me.DataGridView3.Location = New System.Drawing.Point(1458, 19)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView3.TabIndex = 18
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
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
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
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
        'taLogWacheplan
        '
        Me.taLogWacheplan.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Location = New System.Drawing.Point(1165, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(106, 141)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LogWach"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "Datum", True))
        Me.TextBox8.Location = New System.Drawing.Point(-2, 106)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 34
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "TextBis", True))
        Me.TextBox7.Location = New System.Drawing.Point(-2, 80)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 33
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBox35)
        Me.GroupBox7.Controls.Add(Me.TextBox34)
        Me.GroupBox7.Controls.Add(Me.TextBox33)
        Me.GroupBox7.Controls.Add(Me.TextBox32)
        Me.GroupBox7.Controls.Add(Me.TextBox31)
        Me.GroupBox7.Controls.Add(Me.TextBox30)
        Me.GroupBox7.Controls.Add(Me.TextBox29)
        Me.GroupBox7.Controls.Add(Me.TextBox28)
        Me.GroupBox7.Controls.Add(Me.TextBox27)
        Me.GroupBox7.Location = New System.Drawing.Point(1312, 192)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(251, 260)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "TC"
        '
        'TextBox35
        '
        Me.TextBox35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaZeit3", True))
        Me.TextBox35.Location = New System.Drawing.Point(7, 234)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(100, 20)
        Me.TextBox35.TabIndex = 8
        '
        'bsTC
        '
        Me.bsTC.DataMember = "TC"
        Me.bsTC.DataSource = Me.dsToernverwaltung
        '
        'TextBox34
        '
        Me.TextBox34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaDatum3", True))
        Me.TextBox34.Location = New System.Drawing.Point(7, 209)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(100, 20)
        Me.TextBox34.TabIndex = 7
        '
        'TextBox33
        '
        Me.TextBox33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaHafen3", True))
        Me.TextBox33.Location = New System.Drawing.Point(7, 182)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(100, 20)
        Me.TextBox33.TabIndex = 6
        '
        'TextBox32
        '
        Me.TextBox32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaZeit2", True))
        Me.TextBox32.Location = New System.Drawing.Point(7, 155)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(100, 20)
        Me.TextBox32.TabIndex = 5
        '
        'TextBox31
        '
        Me.TextBox31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaDatum2", True))
        Me.TextBox31.Location = New System.Drawing.Point(7, 128)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(100, 20)
        Me.TextBox31.TabIndex = 4
        '
        'TextBox30
        '
        Me.TextBox30.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaHafen2", True))
        Me.TextBox30.Location = New System.Drawing.Point(7, 101)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(100, 20)
        Me.TextBox30.TabIndex = 3
        '
        'TextBox29
        '
        Me.TextBox29.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaZeit1", True))
        Me.TextBox29.Location = New System.Drawing.Point(7, 74)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(100, 20)
        Me.TextBox29.TabIndex = 2
        '
        'TextBox28
        '
        Me.TextBox28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaDatum1", True))
        Me.TextBox28.Location = New System.Drawing.Point(7, 47)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(100, 20)
        Me.TextBox28.TabIndex = 1
        '
        'TextBox27
        '
        Me.TextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTC, "NachtaHafen1", True))
        Me.TextBox27.Location = New System.Drawing.Point(7, 20)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(100, 20)
        Me.TextBox27.TabIndex = 0
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn4, Me.ToernDataGridViewTextBoxColumn1, Me.VZnameDataGridViewTextBoxColumn, Me.SmNachweisDataGridViewCheckBoxColumn, Me.WachfuehrerDataGridViewCheckBoxColumn, Me.NavigatorDataGridViewCheckBoxColumn, Me.RudergaengerDataGridViewCheckBoxColumn, Me.R1DataGridViewTextBoxColumn1, Me.R2DataGridViewTextBoxColumn1, Me.R3DataGridViewTextBoxColumn1, Me.IDToernDataGridViewTextBoxColumn1, Me.NachtaHafen1DataGridViewTextBoxColumn, Me.NachtaDatum1DataGridViewTextBoxColumn, Me.NachtaZeit1DataGridViewTextBoxColumn, Me.NachtaHafen2DataGridViewTextBoxColumn, Me.NachtaDatum2DataGridViewTextBoxColumn, Me.NachtaZeit2DataGridViewTextBoxColumn, Me.NachtaHafen3DataGridViewTextBoxColumn, Me.NachtaDatum3DataGridViewTextBoxColumn, Me.NachtaZeit3DataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.bsTC
        Me.DataGridView4.Location = New System.Drawing.Point(1733, 15)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView4.TabIndex = 21
        '
        'IDDataGridViewTextBoxColumn4
        '
        Me.IDDataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn4.Name = "IDDataGridViewTextBoxColumn4"
        '
        'ToernDataGridViewTextBoxColumn1
        '
        Me.ToernDataGridViewTextBoxColumn1.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.Name = "ToernDataGridViewTextBoxColumn1"
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
        'taTc
        '
        Me.taTc.ClearBeforeFill = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(18, 443)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Label14"
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ToernbezeichnungDataGridViewTextBoxColumn2, Me.SeemeilenMDataGridViewTextBoxColumn, Me.SeemeilenSDataGridViewTextBoxColumn, Me.MotorStdDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.KartenMissweisungDataGridViewTextBoxColumn, Me.SonnenaufgangDataGridViewTextBoxColumn, Me.SonnenuntergangDataGridViewTextBoxColumn, Me.NavtexstationenDataGridViewTextBoxColumn, Me.VollmondDataGridViewTextBoxColumn, Me.MaxTidenhubDataGridViewTextBoxColumn, Me.SonstigesDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn2, Me.R2DataGridViewTextBoxColumn2, Me.R3DataGridViewTextBoxColumn2, Me.GeplanteRouteDataGridViewTextBoxColumn, Me.KassaManagerDataGridViewTextBoxColumn, Me.ErsteinzahlungDataGridViewTextBoxColumn, Me.PantryManagerDataGridViewTextBoxColumn, Me.ErsteinkaufDataGridViewTextBoxColumn, Me.RevierBildDataGridViewTextBoxColumn, Me.GefahreneRouteDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.bsToerndaten
        Me.DataGridView5.Location = New System.Drawing.Point(1323, 20)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView5.TabIndex = 23
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn2
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn2.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn2.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn2.Name = "ToernbezeichnungDataGridViewTextBoxColumn2"
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
        'TextBox36
        '
        Me.TextBox36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "GefahreneRoute", True))
        Me.TextBox36.Location = New System.Drawing.Point(1171, 113)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(100, 20)
        Me.TextBox36.TabIndex = 24
        '
        'taToerndaten
        '
        Me.taToerndaten.ClearBeforeFill = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBox42nfv2)
        Me.GroupBox8.Controls.Add(Me.TextBox43nfb2)
        Me.GroupBox8.Controls.Add(Me.TextBox44sm2)
        Me.GroupBox8.Controls.Add(Me.TextBox45Ndv2)
        Me.GroupBox8.Controls.Add(Me.TextBox46nzv2)
        Me.GroupBox8.Controls.Add(Me.TextBox47Ndb2)
        Me.GroupBox8.Controls.Add(Me.TextBox48nzb2)
        Me.GroupBox8.Controls.Add(Me.TextBox48Nzb)
        Me.GroupBox8.Controls.Add(Me.TextBox47Ndb)
        Me.GroupBox8.Controls.Add(Me.TextBox46Nzv)
        Me.GroupBox8.Controls.Add(Me.TextBox45NDv)
        Me.GroupBox8.Controls.Add(Me.TextBox44sm)
        Me.GroupBox8.Controls.Add(Me.TextBox43Nfb)
        Me.GroupBox8.Controls.Add(Me.TextBox42NFv)
        Me.GroupBox8.Controls.Add(Me.TextBox41)
        Me.GroupBox8.Controls.Add(Me.TextBox40)
        Me.GroupBox8.Controls.Add(Me.TextBox39)
        Me.GroupBox8.Controls.Add(Me.TextBox38)
        Me.GroupBox8.Controls.Add(Me.TextBox37)
        Me.GroupBox8.Location = New System.Drawing.Point(1614, 195)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(359, 226)
        Me.GroupBox8.TabIndex = 25
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Törnverwaltung"
        '
        'TextBox42nfv2
        '
        Me.TextBox42nfv2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtFahrtvon2", True))
        Me.TextBox42nfv2.Location = New System.Drawing.Point(245, 182)
        Me.TextBox42nfv2.Name = "TextBox42nfv2"
        Me.TextBox42nfv2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox42nfv2.TabIndex = 18
        '
        'TextBox43nfb2
        '
        Me.TextBox43nfb2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtFahrtbis2", True))
        Me.TextBox43nfb2.Location = New System.Drawing.Point(245, 155)
        Me.TextBox43nfb2.Name = "TextBox43nfb2"
        Me.TextBox43nfb2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox43nfb2.TabIndex = 17
        '
        'TextBox44sm2
        '
        Me.TextBox44sm2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "SM2", True))
        Me.TextBox44sm2.Location = New System.Drawing.Point(245, 128)
        Me.TextBox44sm2.Name = "TextBox44sm2"
        Me.TextBox44sm2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox44sm2.TabIndex = 16
        '
        'TextBox45Ndv2
        '
        Me.TextBox45Ndv2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtFahrtvon2", True))
        Me.TextBox45Ndv2.Location = New System.Drawing.Point(245, 99)
        Me.TextBox45Ndv2.Name = "TextBox45Ndv2"
        Me.TextBox45Ndv2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox45Ndv2.TabIndex = 15
        '
        'TextBox46nzv2
        '
        Me.TextBox46nzv2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtZeitvon2", True))
        Me.TextBox46nzv2.Location = New System.Drawing.Point(245, 73)
        Me.TextBox46nzv2.Name = "TextBox46nzv2"
        Me.TextBox46nzv2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox46nzv2.TabIndex = 14
        '
        'TextBox47Ndb2
        '
        Me.TextBox47Ndb2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtDatumbis2", True))
        Me.TextBox47Ndb2.Location = New System.Drawing.Point(245, 46)
        Me.TextBox47Ndb2.Name = "TextBox47Ndb2"
        Me.TextBox47Ndb2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox47Ndb2.TabIndex = 13
        '
        'TextBox48nzb2
        '
        Me.TextBox48nzb2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtZeitbis2", True))
        Me.TextBox48nzb2.Location = New System.Drawing.Point(245, 19)
        Me.TextBox48nzb2.Name = "TextBox48nzb2"
        Me.TextBox48nzb2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox48nzb2.TabIndex = 12
        '
        'TextBox48Nzb
        '
        Me.TextBox48Nzb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtZeitbis1", True))
        Me.TextBox48Nzb.Location = New System.Drawing.Point(123, 182)
        Me.TextBox48Nzb.Name = "TextBox48Nzb"
        Me.TextBox48Nzb.Size = New System.Drawing.Size(100, 20)
        Me.TextBox48Nzb.TabIndex = 11
        '
        'TextBox47Ndb
        '
        Me.TextBox47Ndb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtfDatumbis1", True))
        Me.TextBox47Ndb.Location = New System.Drawing.Point(123, 155)
        Me.TextBox47Ndb.Name = "TextBox47Ndb"
        Me.TextBox47Ndb.Size = New System.Drawing.Size(100, 20)
        Me.TextBox47Ndb.TabIndex = 10
        '
        'TextBox46Nzv
        '
        Me.TextBox46Nzv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtZeitvon1", True))
        Me.TextBox46Nzv.Location = New System.Drawing.Point(123, 128)
        Me.TextBox46Nzv.Name = "TextBox46Nzv"
        Me.TextBox46Nzv.Size = New System.Drawing.Size(100, 20)
        Me.TextBox46Nzv.TabIndex = 9
        '
        'TextBox45NDv
        '
        Me.TextBox45NDv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "NachtfDatumvon1", True))
        Me.TextBox45NDv.Location = New System.Drawing.Point(123, 99)
        Me.TextBox45NDv.Name = "TextBox45NDv"
        Me.TextBox45NDv.Size = New System.Drawing.Size(100, 20)
        Me.TextBox45NDv.TabIndex = 8
        '
        'TextBox44sm
        '
        Me.TextBox44sm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Sm1", True))
        Me.TextBox44sm.Location = New System.Drawing.Point(123, 73)
        Me.TextBox44sm.Name = "TextBox44sm"
        Me.TextBox44sm.Size = New System.Drawing.Size(100, 20)
        Me.TextBox44sm.TabIndex = 7
        '
        'TextBox43Nfb
        '
        Me.TextBox43Nfb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Nachtfahrtbis1", True))
        Me.TextBox43Nfb.Location = New System.Drawing.Point(123, 46)
        Me.TextBox43Nfb.Name = "TextBox43Nfb"
        Me.TextBox43Nfb.Size = New System.Drawing.Size(100, 20)
        Me.TextBox43Nfb.TabIndex = 6
        '
        'TextBox42NFv
        '
        Me.TextBox42NFv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Nachtfahrtvon1", True))
        Me.TextBox42NFv.Location = New System.Drawing.Point(123, 19)
        Me.TextBox42NFv.Name = "TextBox42NFv"
        Me.TextBox42NFv.Size = New System.Drawing.Size(100, 20)
        Me.TextBox42NFv.TabIndex = 5
        '
        'TextBox41
        '
        Me.TextBox41.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Nachtansteuerungen", True))
        Me.TextBox41.Location = New System.Drawing.Point(6, 127)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(100, 20)
        Me.TextBox41.TabIndex = 4
        '
        'TextBox40
        '
        Me.TextBox40.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Nachtfahrten", True))
        Me.TextBox40.Location = New System.Drawing.Point(6, 99)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(100, 20)
        Me.TextBox40.TabIndex = 3
        '
        'TextBox39
        '
        Me.TextBox39.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "smGesamt", True))
        Me.TextBox39.Location = New System.Drawing.Point(6, 73)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(100, 20)
        Me.TextBox39.TabIndex = 2
        '
        'TextBox38
        '
        Me.TextBox38.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "smMotor", True))
        Me.TextBox38.Location = New System.Drawing.Point(6, 46)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(100, 20)
        Me.TextBox38.TabIndex = 1
        '
        'TextBox37
        '
        Me.TextBox37.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "smSegel", True))
        Me.TextBox37.Location = New System.Drawing.Point(6, 19)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(100, 20)
        Me.TextBox37.TabIndex = 0
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn5, Me.ToernDataGridViewTextBoxColumn2, Me.Person1DataGridViewTextBoxColumn1, Me.Datum1DataGridViewTextBoxColumn, Me.Person2DataGridViewTextBoxColumn1, Me.Datum2DataGridViewTextBoxColumn, Me.SynchronDataGridViewCheckBoxColumn1, Me.MethodeDataGridViewTextBoxColumn1, Me.VZName1DataGridViewTextBoxColumn, Me.VZName2DataGridViewTextBoxColumn})
        Me.DataGridView6.DataSource = Me.bsWacheplan
        Me.DataGridView6.Location = New System.Drawing.Point(2006, 49)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(129, 58)
        Me.DataGridView6.TabIndex = 26
        '
        'IDDataGridViewTextBoxColumn5
        '
        Me.IDDataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn5.Name = "IDDataGridViewTextBoxColumn5"
        '
        'ToernDataGridViewTextBoxColumn2
        '
        Me.ToernDataGridViewTextBoxColumn2.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn2.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn2.Name = "ToernDataGridViewTextBoxColumn2"
        '
        'Person1DataGridViewTextBoxColumn1
        '
        Me.Person1DataGridViewTextBoxColumn1.DataPropertyName = "Person1"
        Me.Person1DataGridViewTextBoxColumn1.HeaderText = "Person1"
        Me.Person1DataGridViewTextBoxColumn1.Name = "Person1DataGridViewTextBoxColumn1"
        '
        'Datum1DataGridViewTextBoxColumn
        '
        Me.Datum1DataGridViewTextBoxColumn.DataPropertyName = "Datum1"
        Me.Datum1DataGridViewTextBoxColumn.HeaderText = "Datum1"
        Me.Datum1DataGridViewTextBoxColumn.Name = "Datum1DataGridViewTextBoxColumn"
        '
        'Person2DataGridViewTextBoxColumn1
        '
        Me.Person2DataGridViewTextBoxColumn1.DataPropertyName = "Person2"
        Me.Person2DataGridViewTextBoxColumn1.HeaderText = "Person2"
        Me.Person2DataGridViewTextBoxColumn1.Name = "Person2DataGridViewTextBoxColumn1"
        '
        'Datum2DataGridViewTextBoxColumn
        '
        Me.Datum2DataGridViewTextBoxColumn.DataPropertyName = "Datum2"
        Me.Datum2DataGridViewTextBoxColumn.HeaderText = "Datum2"
        Me.Datum2DataGridViewTextBoxColumn.Name = "Datum2DataGridViewTextBoxColumn"
        '
        'SynchronDataGridViewCheckBoxColumn1
        '
        Me.SynchronDataGridViewCheckBoxColumn1.DataPropertyName = "Synchron"
        Me.SynchronDataGridViewCheckBoxColumn1.HeaderText = "Synchron"
        Me.SynchronDataGridViewCheckBoxColumn1.Name = "SynchronDataGridViewCheckBoxColumn1"
        '
        'MethodeDataGridViewTextBoxColumn1
        '
        Me.MethodeDataGridViewTextBoxColumn1.DataPropertyName = "Methode"
        Me.MethodeDataGridViewTextBoxColumn1.HeaderText = "Methode"
        Me.MethodeDataGridViewTextBoxColumn1.Name = "MethodeDataGridViewTextBoxColumn1"
        '
        'VZName1DataGridViewTextBoxColumn
        '
        Me.VZName1DataGridViewTextBoxColumn.DataPropertyName = "VZName1"
        Me.VZName1DataGridViewTextBoxColumn.HeaderText = "VZName1"
        Me.VZName1DataGridViewTextBoxColumn.Name = "VZName1DataGridViewTextBoxColumn"
        '
        'VZName2DataGridViewTextBoxColumn
        '
        Me.VZName2DataGridViewTextBoxColumn.DataPropertyName = "VZName2"
        Me.VZName2DataGridViewTextBoxColumn.HeaderText = "VZName2"
        Me.VZName2DataGridViewTextBoxColumn.Name = "VZName2DataGridViewTextBoxColumn"
        '
        'bsWacheplan
        '
        Me.bsWacheplan.DataMember = "Wacheplan"
        Me.bsWacheplan.DataSource = Me.dsToernverwaltung
        '
        'taWacheplan
        '
        Me.taWacheplan.ClearBeforeFill = True
        '
        'Zusammenfassung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 488)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.TextBox36)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Zusammenfassung"
        Me.Text = "Zusammenfassung"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridZuFa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsZusammenfassung2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridtoern, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDokumentation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.bsToerndaten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.bsLogdaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogWacheplan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridZuFa As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridtoern As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bootsname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusgangsmarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndeMarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmSegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmGesamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfahrtenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtansteuerungenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordtageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TornberichtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents DsLogbuch As WindowsApplication1.dsLogbuch
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bsLogdaten As System.Windows.Forms.BindingSource
    Friend WithEvents taLogdaten As WindowsApplication1.dsLogbuchTableAdapters.LogdatenTableAdapter
    Friend WithEvents AusgangsortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents bsZusammenfassung2 As System.Windows.Forms.BindingSource
    Friend WithEvents taZusammenfassung2 As WindowsApplication1.dsLogbuchTableAdapters.Zusammenfassung2TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Toernbezeichnung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeemeilenM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeemeilenS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorStd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nachtfahrten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nachtansteuerungen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KartenMissweisung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sonnenaufgang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sonnenuntergang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Navtexstationen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vollmond As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxTidenhub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sonstiges As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmuSegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsDokumentation As System.Windows.Forms.BindingSource
    Friend WithEvents taDokumentation As WindowsApplication1.dsLogbuchTableAdapters.DokumentationTableAdapter
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents DatumVonDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZeitVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZeitBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WindrichtungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Windstaerke As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmuSegel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmuMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmGesamtDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents bsLogWacheplan As System.Windows.Forms.BindingSource
    Friend WithEvents taLogWacheplan As WindowsApplication1.dsLogbuchTableAdapters.LogWacheplanTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SynchronDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MethodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTc As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents bsToerndaten As System.Windows.Forms.BindingSource
    Friend WithEvents taToerndaten As WindowsApplication1.dsLogbuchTableAdapters.ToerndatenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeemeilenMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeemeilenSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorStdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfahrtenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtansteuerungenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KartenMissweisungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonnenaufgangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonnenuntergangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NavtexstationenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VollmondDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxTidenhubDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonstigesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeplanteRouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KassaManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErsteinzahlungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PantryManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErsteinkaufDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevierBildDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GefahreneRouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents bsWacheplan As System.Windows.Forms.BindingSource
    Friend WithEvents taWacheplan As WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datum1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datum2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SynchronDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MethodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZName1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZName2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox48Nzb As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47Ndb As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46Nzv As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45NDv As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44sm As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43Nfb As System.Windows.Forms.TextBox
    Friend WithEvents TextBox42NFv As System.Windows.Forms.TextBox
    Friend WithEvents TextBox42nfv2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43nfb2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44sm2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45Ndv2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46nzv2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47Ndb2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox48nzb2 As System.Windows.Forms.TextBox
End Class
