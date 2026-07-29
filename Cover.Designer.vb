<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cover))
        Me.bsBootLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLogbuch = New WindowsApplication1.dsLogbuch()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToernbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusgangsmarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndeMarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmSegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmGesamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtfahrtenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NachtansteuerungenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordtageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusserhalbFB3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TornberichtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetzterSegeltagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordkassaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogbuchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewLog = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotormarkeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeibootmarkeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeobootleistungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaustoffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootsBildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxToern = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.bsToerndaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GroupBoxBoot = New System.Windows.Forms.GroupBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Toernbezeichnung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeplanteRoute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kassamanager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ersteinzahlung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pantrymanager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ersteinkauf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevierBild = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GefahrenRoute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernbezeichnungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.R1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeplanteRouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KassaManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErsteinzahlungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PantryManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErsteinkaufDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevierBildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GefahreneRouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxTD = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBoxB = New System.Windows.Forms.GroupBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.ButtonSpeichern = New System.Windows.Forms.Button()
        Me.ButtonFL = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.taBootLog = New WindowsApplication1.dsLogbuchTableAdapters.BootLogTableAdapter()
        Me.taToerndaten = New WindowsApplication1.dsLogbuchTableAdapters.ToerndatenTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.bsBootLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxToern.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToerndaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBoot.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTD.SuspendLayout()
        Me.GroupBoxB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Toernbezeichnung", True))
        Me.TextBox1.Location = New System.Drawing.Point(6, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 0
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.TornberichtDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.BordkassaDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.LogbuchDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn, Me.Nachtfahrtvon1DataGridViewTextBoxColumn, Me.Nachtfahrtbis1DataGridViewTextBoxColumn, Me.Sm1DataGridViewTextBoxColumn, Me.NachtfDatumvon1DataGridViewTextBoxColumn, Me.NachtZeitvon1DataGridViewTextBoxColumn, Me.NachtfDatumbis1DataGridViewTextBoxColumn, Me.NachtZeitbis1DataGridViewTextBoxColumn, Me.NachtFahrtvon2DataGridViewTextBoxColumn, Me.NachtFahrtbis2DataGridViewTextBoxColumn, Me.SM2DataGridViewTextBoxColumn, Me.NachtDatumvon2DataGridViewTextBoxColumn, Me.NachtZeitvon2DataGridViewTextBoxColumn, Me.NachtDatumbis2DataGridViewTextBoxColumn, Me.NachtZeitbis2DataGridViewTextBoxColumn, Me.Std50StartDataGridViewTextBoxColumn, Me.Std50ZielDataGridViewTextBoxColumn, Me.Std50SmGesDataGridViewTextBoxColumn, Me.Std50smFB2DataGridViewTextBoxColumn, Me.Std50DatumStartDataGridViewTextBoxColumn, Me.Std50ZeitStartDataGridViewTextBoxColumn, Me.Std50DatumZielDataGridViewTextBoxColumn, Me.Std50ZeitZielDataGridViewTextBoxColumn, Me.GezHafen1DataGridViewTextBoxColumn, Me.GezDatum1DataGridViewTextBoxColumn, Me.GezZeit1DataGridViewTextBoxColumn, Me.GezHafen2DataGridViewTextBoxColumn, Me.GezDatum2DataGridViewTextBoxColumn, Me.GezZeit2DataGridViewTextBoxColumn, Me.FB4StartDataGridViewTextBoxColumn, Me.FB4ZielDataGridViewTextBoxColumn, Me.FB4SmGesDataGridViewTextBoxColumn, Me.FB4SmFb3DataGridViewTextBoxColumn, Me.FB4DatumStartDataGridViewTextBoxColumn, Me.FB4ZeitStartDataGridViewTextBoxColumn, Me.FB4DatumZielDataGridViewTextBoxColumn, Me.FB4ZeitZielDataGridViewTextBoxColumn, Me.RevierDataGridViewTextBoxColumn, Me.VerbrauchproToernDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsToernname
        Me.DataGridView1.Location = New System.Drawing.Point(859, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(814, 304)
        Me.DataGridView1.TabIndex = 200
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Törnbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Width = 200
        '
        'DatumVonDataGridViewTextBoxColumn
        '
        Me.DatumVonDataGridViewTextBoxColumn.DataPropertyName = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.HeaderText = "Datum Von"
        Me.DatumVonDataGridViewTextBoxColumn.Name = "DatumVonDataGridViewTextBoxColumn"
        '
        'DatumBisDataGridViewTextBoxColumn
        '
        Me.DatumBisDataGridViewTextBoxColumn.DataPropertyName = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.HeaderText = "Datum Bis"
        Me.DatumBisDataGridViewTextBoxColumn.Name = "DatumBisDataGridViewTextBoxColumn"
        '
        'BootsnameDataGridViewTextBoxColumn
        '
        Me.BootsnameDataGridViewTextBoxColumn.DataPropertyName = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.HeaderText = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.Name = "BootsnameDataGridViewTextBoxColumn"
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
        Me.SmSegelDataGridViewTextBoxColumn.HeaderText = "sm Segel"
        Me.SmSegelDataGridViewTextBoxColumn.Name = "SmSegelDataGridViewTextBoxColumn"
        '
        'SmMotorDataGridViewTextBoxColumn
        '
        Me.SmMotorDataGridViewTextBoxColumn.DataPropertyName = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.HeaderText = "sm Motor"
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'DataGridViewLog
        '
        Me.DataGridViewLog.AutoGenerateColumns = False
        Me.DataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.BootnameDataGridViewTextBoxColumn, Me.MotormarkeDataGridViewTextBoxColumn, Me.BeibootmarkeDataGridViewTextBoxColumn, Me.BeobootleistungDataGridViewTextBoxColumn, Me.BaustoffDataGridViewTextBoxColumn, Me.BootsBildDataGridViewTextBoxColumn})
        Me.DataGridViewLog.DataSource = Me.bsBootLog
        Me.DataGridViewLog.Location = New System.Drawing.Point(1493, 12)
        Me.DataGridViewLog.Name = "DataGridViewLog"
        Me.DataGridViewLog.Size = New System.Drawing.Size(251, 149)
        Me.DataGridViewLog.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
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
        'GroupBoxToern
        '
        Me.GroupBoxToern.Controls.Add(Me.PictureBox3)
        Me.GroupBoxToern.Controls.Add(Me.PictureBox1)
        Me.GroupBoxToern.Controls.Add(Me.Label19)
        Me.GroupBoxToern.Controls.Add(Me.DataGridView1)
        Me.GroupBoxToern.Controls.Add(Me.TextBox13)
        Me.GroupBoxToern.Controls.Add(Me.Label11)
        Me.GroupBoxToern.Controls.Add(Me.TextBox8)
        Me.GroupBoxToern.Controls.Add(Me.TextBox7)
        Me.GroupBoxToern.Controls.Add(Me.TextBox6)
        Me.GroupBoxToern.Controls.Add(Me.TextBox5)
        Me.GroupBoxToern.Controls.Add(Me.TextBox4)
        Me.GroupBoxToern.Controls.Add(Me.Label10)
        Me.GroupBoxToern.Controls.Add(Me.Label9)
        Me.GroupBoxToern.Controls.Add(Me.Label8)
        Me.GroupBoxToern.Controls.Add(Me.Label6)
        Me.GroupBoxToern.Controls.Add(Me.Label5)
        Me.GroupBoxToern.Controls.Add(Me.Label4)
        Me.GroupBoxToern.Controls.Add(Me.Label3)
        Me.GroupBoxToern.Controls.Add(Me.TextBox3)
        Me.GroupBoxToern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxToern.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxToern.Name = "GroupBoxToern"
        Me.GroupBoxToern.Size = New System.Drawing.Size(761, 208)
        Me.GroupBoxToern.TabIndex = 4
        Me.GroupBoxToern.TabStop = False
        Me.GroupBoxToern.Text = "Törnbeschreibung"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(180, 150)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(692, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(219, 174)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(176, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "z.B.: D:\segeln\foto\adria.jpg"
        Me.Label19.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "RevierBild", True))
        Me.TextBox13.Location = New System.Drawing.Point(219, 152)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(516, 22)
        Me.TextBox13.TabIndex = 12
        '
        'bsToerndaten
        '
        Me.bsToerndaten.DataMember = "Toerndaten"
        Me.bsToerndaten.DataSource = Me.DsLogbuch
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Bild der geplanten Route"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "GefahreneRoute", True))
        Me.TextBox8.Location = New System.Drawing.Point(219, 120)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(518, 22)
        Me.TextBox8.TabIndex = 6
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Ersteinkauf", True))
        Me.TextBox7.Location = New System.Drawing.Point(513, 92)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "PantryManager", True))
        Me.TextBox6.Location = New System.Drawing.Point(219, 89)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Ersteinzahlung", True))
        Me.TextBox5.Location = New System.Drawing.Point(513, 60)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "KassaManager", True))
        Me.TextBox4.Location = New System.Drawing.Point(219, 60)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Verzeichnis: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Gefahrene Route "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Ersteinkauf            €"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Verantwortlich für Pantry"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ersteinzahlung je € "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Verantwortlich für Bordkassa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Geplante Route"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "GeplanteRoute", True))
        Me.TextBox3.Location = New System.Drawing.Point(219, 27)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(518, 22)
        Me.TextBox3.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(372, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 201
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(694, 88)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(43, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(441, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(216, 16)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "z.B.: D:\segeln\foto\boote\yacht.jpg"
        Me.Label18.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootLog, "BootsBild", True))
        Me.TextBox9.Location = New System.Drawing.Point(411, 60)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(324, 22)
        Me.TextBox9.TabIndex = 7
        '
        'GroupBoxBoot
        '
        Me.GroupBoxBoot.Controls.Add(Me.PictureBox2)
        Me.GroupBoxBoot.Controls.Add(Me.PictureBox4)
        Me.GroupBoxBoot.Controls.Add(Me.TextBox14)
        Me.GroupBoxBoot.Controls.Add(Me.TextBox12)
        Me.GroupBoxBoot.Controls.Add(Me.TextBox9)
        Me.GroupBoxBoot.Controls.Add(Me.TextBox11)
        Me.GroupBoxBoot.Controls.Add(Me.TextBox10)
        Me.GroupBoxBoot.Controls.Add(Me.Label17)
        Me.GroupBoxBoot.Controls.Add(Me.Label16)
        Me.GroupBoxBoot.Controls.Add(Me.Label15)
        Me.GroupBoxBoot.Controls.Add(Me.Label14)
        Me.GroupBoxBoot.Controls.Add(Me.Label13)
        Me.GroupBoxBoot.Controls.Add(Me.Label12)
        Me.GroupBoxBoot.Controls.Add(Me.Label18)
        Me.GroupBoxBoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBoot.Location = New System.Drawing.Point(12, 373)
        Me.GroupBoxBoot.Name = "GroupBoxBoot"
        Me.GroupBoxBoot.Size = New System.Drawing.Size(761, 118)
        Me.GroupBoxBoot.TabIndex = 15
        Me.GroupBoxBoot.TabStop = False
        Me.GroupBoxBoot.Text = "Bootbeschreibung"
        Me.GroupBoxBoot.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootLog, "Baustoff", True))
        Me.TextBox14.Location = New System.Drawing.Point(132, 58)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 22)
        Me.TextBox14.TabIndex = 11
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootLog, "Beobootleistung", True))
        Me.TextBox12.Location = New System.Drawing.Point(637, 26)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 22)
        Me.TextBox12.TabIndex = 10
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootLog, "Beibootmarke", True))
        Me.TextBox11.Location = New System.Drawing.Point(411, 26)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 22)
        Me.TextBox11.TabIndex = 9
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootLog, "Motormarke", True))
        Me.TextBox10.Location = New System.Drawing.Point(132, 26)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 22)
        Me.TextBox10.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(301, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 16)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Innenbild des Bootes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(275, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Verzeichnis:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Rumpfbaustoff"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(530, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Beibootleistung"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(275, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Marke Beibootmotor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Marke Motor"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Toernbezeichnung, Me.GeplanteRoute, Me.Kassamanager, Me.Ersteinzahlung, Me.Pantrymanager, Me.Ersteinkauf, Me.RevierBild, Me.GefahrenRoute, Me.IDDataGridViewTextBoxColumn2, Me.ToernbezeichnungDataGridViewTextBoxColumn1, Me.SeemeilenMDataGridViewTextBoxColumn, Me.SeemeilenSDataGridViewTextBoxColumn, Me.MotorStdDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn1, Me.NachtansteuerungenDataGridViewTextBoxColumn1, Me.KartenMissweisungDataGridViewTextBoxColumn, Me.SonnenaufgangDataGridViewTextBoxColumn, Me.SonnenuntergangDataGridViewTextBoxColumn, Me.NavtexstationenDataGridViewTextBoxColumn, Me.VollmondDataGridViewTextBoxColumn, Me.MaxTidenhubDataGridViewTextBoxColumn, Me.SonstigesDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn1, Me.R2DataGridViewTextBoxColumn1, Me.R3DataGridViewTextBoxColumn1, Me.GeplanteRouteDataGridViewTextBoxColumn, Me.KassaManagerDataGridViewTextBoxColumn, Me.ErsteinzahlungDataGridViewTextBoxColumn, Me.PantryManagerDataGridViewTextBoxColumn, Me.ErsteinkaufDataGridViewTextBoxColumn, Me.RevierBildDataGridViewTextBoxColumn, Me.GefahreneRouteDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsToerndaten
        Me.DataGridView3.Location = New System.Drawing.Point(1493, 167)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView3.TabIndex = 5
        '
        'Toernbezeichnung
        '
        Me.Toernbezeichnung.DataPropertyName = "Toernbezeichnung"
        Me.Toernbezeichnung.HeaderText = "Toernbezeichnung"
        Me.Toernbezeichnung.Name = "Toernbezeichnung"
        '
        'GeplanteRoute
        '
        Me.GeplanteRoute.DataPropertyName = "GeplanteRoute"
        Me.GeplanteRoute.HeaderText = "GeplanteRoute"
        Me.GeplanteRoute.Name = "GeplanteRoute"
        '
        'Kassamanager
        '
        Me.Kassamanager.DataPropertyName = "Kassamanager"
        Me.Kassamanager.HeaderText = "Kassamanager"
        Me.Kassamanager.Name = "Kassamanager"
        '
        'Ersteinzahlung
        '
        Me.Ersteinzahlung.DataPropertyName = "Ersteinzahlung"
        Me.Ersteinzahlung.HeaderText = "Ersteinzahlung"
        Me.Ersteinzahlung.Name = "Ersteinzahlung"
        '
        'Pantrymanager
        '
        Me.Pantrymanager.DataPropertyName = "Pantrymanager"
        Me.Pantrymanager.HeaderText = "Pantrymanager"
        Me.Pantrymanager.Name = "Pantrymanager"
        '
        'Ersteinkauf
        '
        Me.Ersteinkauf.DataPropertyName = "Ersteinkauf"
        Me.Ersteinkauf.HeaderText = "Ersteinkauf"
        Me.Ersteinkauf.Name = "Ersteinkauf"
        '
        'RevierBild
        '
        Me.RevierBild.DataPropertyName = "RevierBild"
        Me.RevierBild.HeaderText = "RevierBild"
        Me.RevierBild.Name = "RevierBild"
        '
        'GefahrenRoute
        '
        Me.GefahrenRoute.DataPropertyName = "GefahrenRoute"
        Me.GefahrenRoute.HeaderText = "GefahrenRoute"
        Me.GefahrenRoute.Name = "GefahrenRoute"
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'ToernbezeichnungDataGridViewTextBoxColumn1
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn1.Name = "ToernbezeichnungDataGridViewTextBoxColumn1"
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
        'GroupBoxTD
        '
        Me.GroupBoxTD.Controls.Add(Me.TextBox2)
        Me.GroupBoxTD.Controls.Add(Me.TextBox1)
        Me.GroupBoxTD.Location = New System.Drawing.Point(904, 12)
        Me.GroupBoxTD.Name = "GroupBoxTD"
        Me.GroupBoxTD.Size = New System.Drawing.Size(129, 83)
        Me.GroupBoxTD.TabIndex = 60
        Me.GroupBoxTD.TabStop = False
        Me.GroupBoxTD.Text = "Törndaten"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Toernbezeichnung", True))
        Me.TextBox2.Location = New System.Drawing.Point(7, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.TabStop = False
        '
        'GroupBoxB
        '
        Me.GroupBoxB.Controls.Add(Me.TextBox15)
        Me.GroupBoxB.Location = New System.Drawing.Point(911, 301)
        Me.GroupBoxB.Name = "GroupBoxB"
        Me.GroupBoxB.Size = New System.Drawing.Size(129, 88)
        Me.GroupBoxB.TabIndex = 70
        Me.GroupBoxB.TabStop = False
        Me.GroupBoxB.Text = "Boot Log"
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootLog, "Bootname", True))
        Me.TextBox15.Location = New System.Drawing.Point(7, 20)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 0
        Me.TextBox15.TabStop = False
        '
        'ButtonSpeichern
        '
        Me.ButtonSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpeichern.Location = New System.Drawing.Point(644, 497)
        Me.ButtonSpeichern.Name = "ButtonSpeichern"
        Me.ButtonSpeichern.Size = New System.Drawing.Size(133, 44)
        Me.ButtonSpeichern.TabIndex = 20
        Me.ButtonSpeichern.Text = "Speichern"
        Me.ButtonSpeichern.UseVisualStyleBackColor = True
        '
        'ButtonFL
        '
        Me.ButtonFL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFL.Location = New System.Drawing.Point(338, 497)
        Me.ButtonFL.Name = "ButtonFL"
        Me.ButtonFL.Size = New System.Drawing.Size(133, 44)
        Me.ButtonFL.TabIndex = 11
        Me.ButtonFL.Text = "Formular löschen"
        Me.ButtonFL.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1090, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(203, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "DataGridView im GroupboxTörn versteckt"
        '
        'taBootLog
        '
        Me.taBootLog.ClearBeforeFill = True
        '
        'taToerndaten
        '
        Me.taToerndaten.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox20)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 141)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Terrestische Vorgaben"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(141, 21)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(40, 22)
        Me.TextBox20.TabIndex = 20
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(212, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 16)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "Navtexstationen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sonstiges"
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Sonstiges", True))
        Me.TextBox16.Location = New System.Drawing.Point(138, 104)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(599, 22)
        Me.TextBox16.TabIndex = 19
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Sonnenuntergang", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(265, 60)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(43, 22)
        Me.MaskedTextBox3.TabIndex = 16
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Sonnenaufgang", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(138, 60)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(43, 22)
        Me.MaskedTextBox2.TabIndex = 15
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Vollmond", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(406, 60)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(75, 22)
        Me.MaskedTextBox1.TabIndex = 17
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "Navtexstationen", True))
        Me.TextBox17.Location = New System.Drawing.Point(322, 21)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(415, 22)
        Me.TextBox17.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(529, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Max.Tidenhub [m]"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(335, 63)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 16)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Vollmond"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(187, 62)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 16)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "-untergang"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 16)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Sonnenaufgang"
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "MaxTidenhub", True))
        Me.TextBox18.Location = New System.Drawing.Point(644, 57)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(46, 22)
        Me.TextBox18.TabIndex = 18
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(126, 16)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Missweisung - Karte"
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToerndaten, "KartenMissweisung", True))
        Me.TextBox19.Location = New System.Drawing.Point(911, 415)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(45, 20)
        Me.TextBox19.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(907, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Navtexstationen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(980, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(31, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Cover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 598)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxBoot)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonFL)
        Me.Controls.Add(Me.ButtonSpeichern)
        Me.Controls.Add(Me.GroupBoxB)
        Me.Controls.Add(Me.GroupBoxTD)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridViewLog)
        Me.Controls.Add(Me.GroupBoxToern)
        Me.Controls.Add(Me.TextBox19)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cover"
        Me.Text = "Cover"
        CType(Me.bsBootLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxToern.ResumeLayout(False)
        Me.GroupBoxToern.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToerndaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBoot.ResumeLayout(False)
        Me.GroupBoxBoot.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTD.ResumeLayout(False)
        Me.GroupBoxTD.PerformLayout()
        Me.GroupBoxB.ResumeLayout(False)
        Me.GroupBoxB.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusgangsmarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndeMarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmSegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmGesamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtfahrtenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NachtansteuerungenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordtageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusserhalbFB3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TornberichtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetzterSegeltagDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordkassaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogbuchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewLog As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBoxToern As System.Windows.Forms.GroupBox
    Friend WithEvents DsLogbuch As WindowsApplication1.dsLogbuch
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Toernbezeichnung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeplanteRoute As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kassamanager As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ersteinzahlung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pantrymanager As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ersteinkauf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevierBild As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GefahrenRoute As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxTD As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxB As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxBoot As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ButtonSpeichern As System.Windows.Forms.Button
    Friend WithEvents ButtonFL As System.Windows.Forms.Button
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents bsBootLog As System.Windows.Forms.BindingSource
    Friend WithEvents taBootLog As WindowsApplication1.dsLogbuchTableAdapters.BootLogTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotormarkeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeibootmarkeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeobootleistungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaustoffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsBildDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents bsToerndaten As System.Windows.Forms.BindingSource
    Friend WithEvents taToerndaten As WindowsApplication1.dsLogbuchTableAdapters.ToerndatenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents R1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeplanteRouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KassaManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErsteinzahlungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PantryManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErsteinkaufDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevierBildDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GefahreneRouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
End Class
