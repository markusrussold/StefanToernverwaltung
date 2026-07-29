<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KursMTeilnehmer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KursMTeilnehmer))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.bsTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VeranstaltungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnmeldedatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeitragDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsVeranstalTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerkaufspreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsMaterialKurs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KontaktartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve11DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Reserve41DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Reserve51DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsKontakte = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.AnredeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClubmitgliedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToernnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlterersterToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReisepassNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GebDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GebOrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FunkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelscheinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalitaetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReihenfolgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelscheinDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelscheinVerbandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FB2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FB3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FB4DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AScheinDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MotorbootDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.R1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SterbedatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.VZNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKBFaelligDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumMatBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumMatFaelligDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KursbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FahrtbereichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursbeginnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VortragendeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursdauerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenKursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsKurse = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonLeeren = New System.Windows.Forms.Button()
        Me.ButtonSpeichern = New System.Windows.Forms.Button()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.taKurse = New WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter()
        Me.taTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter()
        Me.taKontakte = New WindowsApplication1.dsAusbildungTableAdapters.KontakteTableAdapter()
        Me.taMaterialKurs = New WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter()
        Me.taVeranstalTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.VeranstalTeilnehmerTableAdapter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVeranstalTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaterialKurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKontakte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "VZName", True))
        Me.TextBox2.Location = New System.Drawing.Point(843, 18)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 22)
        Me.TextBox2.TabIndex = 151
        '
        'bsTeilnehmer
        '
        Me.bsTeilnehmer.DataMember = "Teilnehmer"
        Me.bsTeilnehmer.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsCrewAdressen
        '
        Me.bsCrewAdressen.DataMember = "CrewAdressen"
        Me.bsCrewAdressen.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn5, Me.VZnameDataGridViewTextBoxColumn4, Me.VeranstaltungDataGridViewTextBoxColumn, Me.VeranstaltungsdatumDataGridViewTextBoxColumn, Me.AnmeldedatumDataGridViewTextBoxColumn, Me.BeitragDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn5})
        Me.DataGridView6.DataSource = Me.bsVeranstalTeilnehmer
        Me.DataGridView6.Location = New System.Drawing.Point(1006, 439)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(320, 185)
        Me.DataGridView6.TabIndex = 150
        '
        'IDDataGridViewTextBoxColumn5
        '
        Me.IDDataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn5.Name = "IDDataGridViewTextBoxColumn5"
        '
        'VZnameDataGridViewTextBoxColumn4
        '
        Me.VZnameDataGridViewTextBoxColumn4.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn4.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn4.Name = "VZnameDataGridViewTextBoxColumn4"
        '
        'VeranstaltungDataGridViewTextBoxColumn
        '
        Me.VeranstaltungDataGridViewTextBoxColumn.DataPropertyName = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn.HeaderText = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn.Name = "VeranstaltungDataGridViewTextBoxColumn"
        '
        'VeranstaltungsdatumDataGridViewTextBoxColumn
        '
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn.DataPropertyName = "Veranstaltungsdatum"
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn.HeaderText = "Veranstaltungsdatum"
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn.Name = "VeranstaltungsdatumDataGridViewTextBoxColumn"
        '
        'AnmeldedatumDataGridViewTextBoxColumn
        '
        Me.AnmeldedatumDataGridViewTextBoxColumn.DataPropertyName = "Anmeldedatum"
        Me.AnmeldedatumDataGridViewTextBoxColumn.HeaderText = "Anmeldedatum"
        Me.AnmeldedatumDataGridViewTextBoxColumn.Name = "AnmeldedatumDataGridViewTextBoxColumn"
        '
        'BeitragDataGridViewTextBoxColumn
        '
        Me.BeitragDataGridViewTextBoxColumn.DataPropertyName = "Beitrag"
        Me.BeitragDataGridViewTextBoxColumn.HeaderText = "Beitrag"
        Me.BeitragDataGridViewTextBoxColumn.Name = "BeitragDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn5
        '
        Me.BemerkungDataGridViewTextBoxColumn5.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn5.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn5.Name = "BemerkungDataGridViewTextBoxColumn5"
        '
        'bsVeranstalTeilnehmer
        '
        Me.bsVeranstalTeilnehmer.DataMember = "VeranstalTeilnehmer"
        Me.bsVeranstalTeilnehmer.DataSource = Me.DsAusbildung
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn4, Me.KursDataGridViewTextBoxColumn1, Me.FBDataGridViewTextBoxColumn1, Me.MaterialDataGridViewTextBoxColumn, Me.VZNameDataGridViewTextBoxColumn3, Me.VerkaufspreisDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn4})
        Me.DataGridView5.DataSource = Me.bsMaterialKurs
        Me.DataGridView5.Location = New System.Drawing.Point(1006, 232)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(320, 185)
        Me.DataGridView5.TabIndex = 149
        '
        'IDDataGridViewTextBoxColumn4
        '
        Me.IDDataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn4.Name = "IDDataGridViewTextBoxColumn4"
        '
        'KursDataGridViewTextBoxColumn1
        '
        Me.KursDataGridViewTextBoxColumn1.DataPropertyName = "Kurs"
        Me.KursDataGridViewTextBoxColumn1.HeaderText = "Kurs"
        Me.KursDataGridViewTextBoxColumn1.Name = "KursDataGridViewTextBoxColumn1"
        '
        'FBDataGridViewTextBoxColumn1
        '
        Me.FBDataGridViewTextBoxColumn1.DataPropertyName = "FB"
        Me.FBDataGridViewTextBoxColumn1.HeaderText = "FB"
        Me.FBDataGridViewTextBoxColumn1.Name = "FBDataGridViewTextBoxColumn1"
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "Material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        '
        'VZNameDataGridViewTextBoxColumn3
        '
        Me.VZNameDataGridViewTextBoxColumn3.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn3.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn3.Name = "VZNameDataGridViewTextBoxColumn3"
        '
        'VerkaufspreisDataGridViewTextBoxColumn
        '
        Me.VerkaufspreisDataGridViewTextBoxColumn.DataPropertyName = "Verkaufspreis"
        Me.VerkaufspreisDataGridViewTextBoxColumn.HeaderText = "Verkaufspreis"
        Me.VerkaufspreisDataGridViewTextBoxColumn.Name = "VerkaufspreisDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn4
        '
        Me.BemerkungDataGridViewTextBoxColumn4.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn4.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn4.Name = "BemerkungDataGridViewTextBoxColumn4"
        '
        'bsMaterialKurs
        '
        Me.bsMaterialKurs.DataMember = "MaterialKurs"
        Me.bsMaterialKurs.DataSource = Me.DsAusbildung
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.VZNameDataGridViewTextBoxColumn2, Me.BemerkungDataGridViewTextBoxColumn3, Me.EmailAdresseDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.HandyNrDataGridViewTextBoxColumn, Me.DatumTDataGridViewTextBoxColumn, Me.KontaktartDataGridViewTextBoxColumn, Me.Reserve1DataGridViewTextBoxColumn, Me.Reserve2DataGridViewTextBoxColumn, Me.Reserve3DataGridViewTextBoxColumn, Me.Reserve4DataGridViewTextBoxColumn, Me.Reserve5DataGridViewTextBoxColumn, Me.Reserve11DataGridViewCheckBoxColumn, Me.Reserve41DataGridViewCheckBoxColumn, Me.Reserve51DataGridViewCheckBoxColumn})
        Me.DataGridView4.DataSource = Me.bsKontakte
        Me.DataGridView4.Location = New System.Drawing.Point(1008, 12)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(320, 185)
        Me.DataGridView4.TabIndex = 148
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        '
        'VZNameDataGridViewTextBoxColumn2
        '
        Me.VZNameDataGridViewTextBoxColumn2.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn2.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn2.Name = "VZNameDataGridViewTextBoxColumn2"
        '
        'BemerkungDataGridViewTextBoxColumn3
        '
        Me.BemerkungDataGridViewTextBoxColumn3.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn3.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn3.Name = "BemerkungDataGridViewTextBoxColumn3"
        '
        'EmailAdresseDataGridViewTextBoxColumn
        '
        Me.EmailAdresseDataGridViewTextBoxColumn.DataPropertyName = "emailAdresse"
        Me.EmailAdresseDataGridViewTextBoxColumn.HeaderText = "emailAdresse"
        Me.EmailAdresseDataGridViewTextBoxColumn.Name = "EmailAdresseDataGridViewTextBoxColumn"
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        '
        'HandyNrDataGridViewTextBoxColumn
        '
        Me.HandyNrDataGridViewTextBoxColumn.DataPropertyName = "HandyNr"
        Me.HandyNrDataGridViewTextBoxColumn.HeaderText = "HandyNr"
        Me.HandyNrDataGridViewTextBoxColumn.Name = "HandyNrDataGridViewTextBoxColumn"
        '
        'DatumTDataGridViewTextBoxColumn
        '
        Me.DatumTDataGridViewTextBoxColumn.DataPropertyName = "DatumT"
        Me.DatumTDataGridViewTextBoxColumn.HeaderText = "DatumT"
        Me.DatumTDataGridViewTextBoxColumn.Name = "DatumTDataGridViewTextBoxColumn"
        '
        'KontaktartDataGridViewTextBoxColumn
        '
        Me.KontaktartDataGridViewTextBoxColumn.DataPropertyName = "Kontaktart"
        Me.KontaktartDataGridViewTextBoxColumn.HeaderText = "Kontaktart"
        Me.KontaktartDataGridViewTextBoxColumn.Name = "KontaktartDataGridViewTextBoxColumn"
        '
        'Reserve1DataGridViewTextBoxColumn
        '
        Me.Reserve1DataGridViewTextBoxColumn.DataPropertyName = "reserve1"
        Me.Reserve1DataGridViewTextBoxColumn.HeaderText = "reserve1"
        Me.Reserve1DataGridViewTextBoxColumn.Name = "Reserve1DataGridViewTextBoxColumn"
        '
        'Reserve2DataGridViewTextBoxColumn
        '
        Me.Reserve2DataGridViewTextBoxColumn.DataPropertyName = "reserve2"
        Me.Reserve2DataGridViewTextBoxColumn.HeaderText = "reserve2"
        Me.Reserve2DataGridViewTextBoxColumn.Name = "Reserve2DataGridViewTextBoxColumn"
        '
        'Reserve3DataGridViewTextBoxColumn
        '
        Me.Reserve3DataGridViewTextBoxColumn.DataPropertyName = "reserve3"
        Me.Reserve3DataGridViewTextBoxColumn.HeaderText = "reserve3"
        Me.Reserve3DataGridViewTextBoxColumn.Name = "Reserve3DataGridViewTextBoxColumn"
        '
        'Reserve4DataGridViewTextBoxColumn
        '
        Me.Reserve4DataGridViewTextBoxColumn.DataPropertyName = "reserve4"
        Me.Reserve4DataGridViewTextBoxColumn.HeaderText = "reserve4"
        Me.Reserve4DataGridViewTextBoxColumn.Name = "Reserve4DataGridViewTextBoxColumn"
        '
        'Reserve5DataGridViewTextBoxColumn
        '
        Me.Reserve5DataGridViewTextBoxColumn.DataPropertyName = "reserve5"
        Me.Reserve5DataGridViewTextBoxColumn.HeaderText = "reserve5"
        Me.Reserve5DataGridViewTextBoxColumn.Name = "Reserve5DataGridViewTextBoxColumn"
        '
        'Reserve11DataGridViewCheckBoxColumn
        '
        Me.Reserve11DataGridViewCheckBoxColumn.DataPropertyName = "reserve11"
        Me.Reserve11DataGridViewCheckBoxColumn.HeaderText = "reserve11"
        Me.Reserve11DataGridViewCheckBoxColumn.Name = "Reserve11DataGridViewCheckBoxColumn"
        '
        'Reserve41DataGridViewCheckBoxColumn
        '
        Me.Reserve41DataGridViewCheckBoxColumn.DataPropertyName = "reserve41"
        Me.Reserve41DataGridViewCheckBoxColumn.HeaderText = "reserve41"
        Me.Reserve41DataGridViewCheckBoxColumn.Name = "Reserve41DataGridViewCheckBoxColumn"
        '
        'Reserve51DataGridViewCheckBoxColumn
        '
        Me.Reserve51DataGridViewCheckBoxColumn.DataPropertyName = "reserve51"
        Me.Reserve51DataGridViewCheckBoxColumn.HeaderText = "reserve51"
        Me.Reserve51DataGridViewCheckBoxColumn.Name = "Reserve51DataGridViewCheckBoxColumn"
        '
        'bsKontakte
        '
        Me.bsKontakte.DataMember = "Kontakte"
        Me.bsKontakte.DataSource = Me.DsAusbildung
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "Adressdatei"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnredeDataGridViewTextBoxColumn, Me.VZnameDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.ClubmitgliedDataGridViewCheckBoxColumn, Me.ToernnrDataGridViewTextBoxColumn, Me.AlterersterToernDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn, Me.ZunameDataGridViewTextBoxColumn, Me.ReisepassNrDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.GebDatumDataGridViewTextBoxColumn, Me.GebOrtDataGridViewTextBoxColumn, Me.FunkDataGridViewTextBoxColumn, Me.SegelscheinDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.NationalitaetDataGridViewTextBoxColumn, Me.ReihenfolgeDataGridViewTextBoxColumn, Me.SegelscheinDatumDataGridViewTextBoxColumn, Me.SegelscheinVerbandDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.FB1DataGridViewCheckBoxColumn, Me.FB2DataGridViewCheckBoxColumn, Me.FB3DataGridViewCheckBoxColumn, Me.FB4DataGridViewCheckBoxColumn, Me.AScheinDataGridViewCheckBoxColumn, Me.MotorbootDataGridViewCheckBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.SterbedatumDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsCrewAdressen
        Me.DataGridView3.Location = New System.Drawing.Point(10, 33)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(723, 168)
        Me.DataGridView3.TabIndex = 146
        '
        'AnredeDataGridViewTextBoxColumn
        '
        Me.AnredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.HeaderText = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.Name = "AnredeDataGridViewTextBoxColumn"
        '
        'VZnameDataGridViewTextBoxColumn
        '
        Me.VZnameDataGridViewTextBoxColumn.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.Name = "VZnameDataGridViewTextBoxColumn"
        Me.VZnameDataGridViewTextBoxColumn.Width = 150
        '
        'HandyDataGridViewTextBoxColumn
        '
        Me.HandyDataGridViewTextBoxColumn.DataPropertyName = "Handy"
        Me.HandyDataGridViewTextBoxColumn.HeaderText = "Handy"
        Me.HandyDataGridViewTextBoxColumn.Name = "HandyDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 120
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        Me.OrtDataGridViewTextBoxColumn.Width = 120
        '
        'ClubmitgliedDataGridViewCheckBoxColumn
        '
        Me.ClubmitgliedDataGridViewCheckBoxColumn.DataPropertyName = "Clubmitglied"
        Me.ClubmitgliedDataGridViewCheckBoxColumn.HeaderText = "SFVS"
        Me.ClubmitgliedDataGridViewCheckBoxColumn.Name = "ClubmitgliedDataGridViewCheckBoxColumn"
        Me.ClubmitgliedDataGridViewCheckBoxColumn.Width = 60
        '
        'ToernnrDataGridViewTextBoxColumn
        '
        Me.ToernnrDataGridViewTextBoxColumn.DataPropertyName = "toernnr"
        Me.ToernnrDataGridViewTextBoxColumn.HeaderText = "toernnr"
        Me.ToernnrDataGridViewTextBoxColumn.Name = "ToernnrDataGridViewTextBoxColumn"
        '
        'AlterersterToernDataGridViewTextBoxColumn
        '
        Me.AlterersterToernDataGridViewTextBoxColumn.DataPropertyName = "AlterersterToern"
        Me.AlterersterToernDataGridViewTextBoxColumn.HeaderText = "AlterersterToern"
        Me.AlterersterToernDataGridViewTextBoxColumn.Name = "AlterersterToernDataGridViewTextBoxColumn"
        '
        'StraßeDataGridViewTextBoxColumn
        '
        Me.StraßeDataGridViewTextBoxColumn.DataPropertyName = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.HeaderText = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.Name = "StraßeDataGridViewTextBoxColumn"
        '
        'PlzDataGridViewTextBoxColumn
        '
        Me.PlzDataGridViewTextBoxColumn.DataPropertyName = "Plz"
        Me.PlzDataGridViewTextBoxColumn.HeaderText = "Plz"
        Me.PlzDataGridViewTextBoxColumn.Name = "PlzDataGridViewTextBoxColumn"
        '
        'ZunameDataGridViewTextBoxColumn
        '
        Me.ZunameDataGridViewTextBoxColumn.DataPropertyName = "Zuname"
        Me.ZunameDataGridViewTextBoxColumn.HeaderText = "Zuname"
        Me.ZunameDataGridViewTextBoxColumn.Name = "ZunameDataGridViewTextBoxColumn"
        '
        'ReisepassNrDataGridViewTextBoxColumn
        '
        Me.ReisepassNrDataGridViewTextBoxColumn.DataPropertyName = "ReisepassNr"
        Me.ReisepassNrDataGridViewTextBoxColumn.HeaderText = "ReisepassNr"
        Me.ReisepassNrDataGridViewTextBoxColumn.Name = "ReisepassNrDataGridViewTextBoxColumn"
        '
        'VornameDataGridViewTextBoxColumn
        '
        Me.VornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.HeaderText = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.Name = "VornameDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'GebDatumDataGridViewTextBoxColumn
        '
        Me.GebDatumDataGridViewTextBoxColumn.DataPropertyName = "GebDatum"
        Me.GebDatumDataGridViewTextBoxColumn.HeaderText = "GebDatum"
        Me.GebDatumDataGridViewTextBoxColumn.Name = "GebDatumDataGridViewTextBoxColumn"
        '
        'GebOrtDataGridViewTextBoxColumn
        '
        Me.GebOrtDataGridViewTextBoxColumn.DataPropertyName = "GebOrt"
        Me.GebOrtDataGridViewTextBoxColumn.HeaderText = "GebOrt"
        Me.GebOrtDataGridViewTextBoxColumn.Name = "GebOrtDataGridViewTextBoxColumn"
        '
        'FunkDataGridViewTextBoxColumn
        '
        Me.FunkDataGridViewTextBoxColumn.DataPropertyName = "Funk"
        Me.FunkDataGridViewTextBoxColumn.HeaderText = "Funk"
        Me.FunkDataGridViewTextBoxColumn.Name = "FunkDataGridViewTextBoxColumn"
        '
        'SegelscheinDataGridViewTextBoxColumn
        '
        Me.SegelscheinDataGridViewTextBoxColumn.DataPropertyName = "Segelschein"
        Me.SegelscheinDataGridViewTextBoxColumn.HeaderText = "Segelschein"
        Me.SegelscheinDataGridViewTextBoxColumn.Name = "SegelscheinDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        '
        'NationalitaetDataGridViewTextBoxColumn
        '
        Me.NationalitaetDataGridViewTextBoxColumn.DataPropertyName = "nationalitaet"
        Me.NationalitaetDataGridViewTextBoxColumn.HeaderText = "nationalitaet"
        Me.NationalitaetDataGridViewTextBoxColumn.Name = "NationalitaetDataGridViewTextBoxColumn"
        '
        'ReihenfolgeDataGridViewTextBoxColumn
        '
        Me.ReihenfolgeDataGridViewTextBoxColumn.DataPropertyName = "Reihenfolge"
        Me.ReihenfolgeDataGridViewTextBoxColumn.HeaderText = "Reihenfolge"
        Me.ReihenfolgeDataGridViewTextBoxColumn.Name = "ReihenfolgeDataGridViewTextBoxColumn"
        '
        'SegelscheinDatumDataGridViewTextBoxColumn
        '
        Me.SegelscheinDatumDataGridViewTextBoxColumn.DataPropertyName = "SegelscheinDatum"
        Me.SegelscheinDatumDataGridViewTextBoxColumn.HeaderText = "SegelscheinDatum"
        Me.SegelscheinDatumDataGridViewTextBoxColumn.Name = "SegelscheinDatumDataGridViewTextBoxColumn"
        '
        'SegelscheinVerbandDataGridViewTextBoxColumn
        '
        Me.SegelscheinVerbandDataGridViewTextBoxColumn.DataPropertyName = "SegelscheinVerband"
        Me.SegelscheinVerbandDataGridViewTextBoxColumn.HeaderText = "SegelscheinVerband"
        Me.SegelscheinVerbandDataGridViewTextBoxColumn.Name = "SegelscheinVerbandDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'FB1DataGridViewCheckBoxColumn
        '
        Me.FB1DataGridViewCheckBoxColumn.DataPropertyName = "FB1"
        Me.FB1DataGridViewCheckBoxColumn.HeaderText = "FB1"
        Me.FB1DataGridViewCheckBoxColumn.Name = "FB1DataGridViewCheckBoxColumn"
        '
        'FB2DataGridViewCheckBoxColumn
        '
        Me.FB2DataGridViewCheckBoxColumn.DataPropertyName = "FB2"
        Me.FB2DataGridViewCheckBoxColumn.HeaderText = "FB2"
        Me.FB2DataGridViewCheckBoxColumn.Name = "FB2DataGridViewCheckBoxColumn"
        '
        'FB3DataGridViewCheckBoxColumn
        '
        Me.FB3DataGridViewCheckBoxColumn.DataPropertyName = "FB3"
        Me.FB3DataGridViewCheckBoxColumn.HeaderText = "FB3"
        Me.FB3DataGridViewCheckBoxColumn.Name = "FB3DataGridViewCheckBoxColumn"
        '
        'FB4DataGridViewCheckBoxColumn
        '
        Me.FB4DataGridViewCheckBoxColumn.DataPropertyName = "FB4"
        Me.FB4DataGridViewCheckBoxColumn.HeaderText = "FB4"
        Me.FB4DataGridViewCheckBoxColumn.Name = "FB4DataGridViewCheckBoxColumn"
        '
        'AScheinDataGridViewCheckBoxColumn
        '
        Me.AScheinDataGridViewCheckBoxColumn.DataPropertyName = "A-Schein"
        Me.AScheinDataGridViewCheckBoxColumn.HeaderText = "A-Schein"
        Me.AScheinDataGridViewCheckBoxColumn.Name = "AScheinDataGridViewCheckBoxColumn"
        '
        'MotorbootDataGridViewCheckBoxColumn
        '
        Me.MotorbootDataGridViewCheckBoxColumn.DataPropertyName = "Motorboot"
        Me.MotorbootDataGridViewCheckBoxColumn.HeaderText = "Motorboot"
        Me.MotorbootDataGridViewCheckBoxColumn.Name = "MotorbootDataGridViewCheckBoxColumn"
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
        'SterbedatumDataGridViewTextBoxColumn
        '
        Me.SterbedatumDataGridViewTextBoxColumn.DataPropertyName = "Sterbedatum"
        Me.SterbedatumDataGridViewTextBoxColumn.HeaderText = "Sterbedatum"
        Me.SterbedatumDataGridViewTextBoxColumn.Name = "SterbedatumDataGridViewTextBoxColumn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Besuchte Kurse"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZNameDataGridViewTextBoxColumn1, Me.KursDataGridViewTextBoxColumn, Me.FBDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn2, Me.KursPreisDataGridViewTextBoxColumn, Me.KursBezahltDataGridViewTextBoxColumn, Me.MaterialpreisDataGridViewTextBoxColumn, Me.MaterialBezahltDataGridViewTextBoxColumn, Me.DatumKursBezahltDataGridViewTextBoxColumn, Me.DatumKBFaelligDataGridViewTextBoxColumn, Me.DatumMatBezahltDataGridViewTextBoxColumn, Me.DatumMatFaelligDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn2})
        Me.DataGridView2.DataSource = Me.bsTeilnehmer
        Me.DataGridView2.Location = New System.Drawing.Point(348, 252)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(385, 203)
        Me.DataGridView2.TabIndex = 144
        '
        'VZNameDataGridViewTextBoxColumn1
        '
        Me.VZNameDataGridViewTextBoxColumn1.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn1.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn1.Name = "VZNameDataGridViewTextBoxColumn1"
        Me.VZNameDataGridViewTextBoxColumn1.Width = 150
        '
        'KursDataGridViewTextBoxColumn
        '
        Me.KursDataGridViewTextBoxColumn.DataPropertyName = "Kurs"
        Me.KursDataGridViewTextBoxColumn.HeaderText = "Kurs"
        Me.KursDataGridViewTextBoxColumn.Name = "KursDataGridViewTextBoxColumn"
        '
        'FBDataGridViewTextBoxColumn
        '
        Me.FBDataGridViewTextBoxColumn.DataPropertyName = "FB"
        Me.FBDataGridViewTextBoxColumn.HeaderText = "FB"
        Me.FBDataGridViewTextBoxColumn.Name = "FBDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn2
        '
        Me.BemerkungDataGridViewTextBoxColumn2.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.Name = "BemerkungDataGridViewTextBoxColumn2"
        '
        'KursPreisDataGridViewTextBoxColumn
        '
        Me.KursPreisDataGridViewTextBoxColumn.DataPropertyName = "KursPreis"
        Me.KursPreisDataGridViewTextBoxColumn.HeaderText = "KursPreis"
        Me.KursPreisDataGridViewTextBoxColumn.Name = "KursPreisDataGridViewTextBoxColumn"
        '
        'KursBezahltDataGridViewTextBoxColumn
        '
        Me.KursBezahltDataGridViewTextBoxColumn.DataPropertyName = "KursBezahlt"
        Me.KursBezahltDataGridViewTextBoxColumn.HeaderText = "KursBezahlt"
        Me.KursBezahltDataGridViewTextBoxColumn.Name = "KursBezahltDataGridViewTextBoxColumn"
        '
        'MaterialpreisDataGridViewTextBoxColumn
        '
        Me.MaterialpreisDataGridViewTextBoxColumn.DataPropertyName = "Materialpreis"
        Me.MaterialpreisDataGridViewTextBoxColumn.HeaderText = "Materialpreis"
        Me.MaterialpreisDataGridViewTextBoxColumn.Name = "MaterialpreisDataGridViewTextBoxColumn"
        '
        'MaterialBezahltDataGridViewTextBoxColumn
        '
        Me.MaterialBezahltDataGridViewTextBoxColumn.DataPropertyName = "MaterialBezahlt"
        Me.MaterialBezahltDataGridViewTextBoxColumn.HeaderText = "MaterialBezahlt"
        Me.MaterialBezahltDataGridViewTextBoxColumn.Name = "MaterialBezahltDataGridViewTextBoxColumn"
        '
        'DatumKursBezahltDataGridViewTextBoxColumn
        '
        Me.DatumKursBezahltDataGridViewTextBoxColumn.DataPropertyName = "DatumKursBezahlt"
        Me.DatumKursBezahltDataGridViewTextBoxColumn.HeaderText = "DatumKursBezahlt"
        Me.DatumKursBezahltDataGridViewTextBoxColumn.Name = "DatumKursBezahltDataGridViewTextBoxColumn"
        '
        'DatumKBFaelligDataGridViewTextBoxColumn
        '
        Me.DatumKBFaelligDataGridViewTextBoxColumn.DataPropertyName = "DatumKBFaellig"
        Me.DatumKBFaelligDataGridViewTextBoxColumn.HeaderText = "DatumKBFaellig"
        Me.DatumKBFaelligDataGridViewTextBoxColumn.Name = "DatumKBFaelligDataGridViewTextBoxColumn"
        '
        'DatumMatBezahltDataGridViewTextBoxColumn
        '
        Me.DatumMatBezahltDataGridViewTextBoxColumn.DataPropertyName = "DatumMatBezahlt"
        Me.DatumMatBezahltDataGridViewTextBoxColumn.HeaderText = "DatumMatBezahlt"
        Me.DatumMatBezahltDataGridViewTextBoxColumn.Name = "DatumMatBezahltDataGridViewTextBoxColumn"
        '
        'DatumMatFaelligDataGridViewTextBoxColumn
        '
        Me.DatumMatFaelligDataGridViewTextBoxColumn.DataPropertyName = "DatumMatFaellig"
        Me.DatumMatFaelligDataGridViewTextBoxColumn.HeaderText = "DatumMatFaellig"
        Me.DatumMatFaelligDataGridViewTextBoxColumn.Name = "DatumMatFaelligDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Kurse"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KursbezeichnungDataGridViewTextBoxColumn, Me.FahrtbereichDataGridViewTextBoxColumn, Me.KursbeginnDataGridViewTextBoxColumn, Me.KursortDataGridViewTextBoxColumn, Me.Preis1DataGridViewTextBoxColumn, Me.Preis2DataGridViewTextBoxColumn, Me.Preis3DataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.VortragendeDataGridViewTextBoxColumn, Me.ReserveDataGridViewTextBoxColumn, Me.KursdauerDataGridViewTextBoxColumn, Me.KostenKursortDataGridViewTextBoxColumn, Me.KursartDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.bsKurse
        Me.DataGridView1.Location = New System.Drawing.Point(11, 252)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(329, 203)
        Me.DataGridView1.TabIndex = 142
        '
        'KursbezeichnungDataGridViewTextBoxColumn
        '
        Me.KursbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Kursbezeichnung"
        Me.KursbezeichnungDataGridViewTextBoxColumn.HeaderText = "Kursbezeichnung"
        Me.KursbezeichnungDataGridViewTextBoxColumn.Name = "KursbezeichnungDataGridViewTextBoxColumn"
        '
        'FahrtbereichDataGridViewTextBoxColumn
        '
        Me.FahrtbereichDataGridViewTextBoxColumn.DataPropertyName = "Fahrtbereich"
        Me.FahrtbereichDataGridViewTextBoxColumn.HeaderText = "Fahrtbereich"
        Me.FahrtbereichDataGridViewTextBoxColumn.Name = "FahrtbereichDataGridViewTextBoxColumn"
        Me.FahrtbereichDataGridViewTextBoxColumn.Width = 85
        '
        'KursbeginnDataGridViewTextBoxColumn
        '
        Me.KursbeginnDataGridViewTextBoxColumn.DataPropertyName = "Kursbeginn"
        Me.KursbeginnDataGridViewTextBoxColumn.HeaderText = "Kursbeginn"
        Me.KursbeginnDataGridViewTextBoxColumn.Name = "KursbeginnDataGridViewTextBoxColumn"
        '
        'KursortDataGridViewTextBoxColumn
        '
        Me.KursortDataGridViewTextBoxColumn.DataPropertyName = "Kursort"
        Me.KursortDataGridViewTextBoxColumn.HeaderText = "Kursort"
        Me.KursortDataGridViewTextBoxColumn.Name = "KursortDataGridViewTextBoxColumn"
        '
        'Preis1DataGridViewTextBoxColumn
        '
        Me.Preis1DataGridViewTextBoxColumn.DataPropertyName = "Preis1"
        Me.Preis1DataGridViewTextBoxColumn.HeaderText = "Preis1"
        Me.Preis1DataGridViewTextBoxColumn.Name = "Preis1DataGridViewTextBoxColumn"
        '
        'Preis2DataGridViewTextBoxColumn
        '
        Me.Preis2DataGridViewTextBoxColumn.DataPropertyName = "Preis2"
        Me.Preis2DataGridViewTextBoxColumn.HeaderText = "Preis2"
        Me.Preis2DataGridViewTextBoxColumn.Name = "Preis2DataGridViewTextBoxColumn"
        '
        'Preis3DataGridViewTextBoxColumn
        '
        Me.Preis3DataGridViewTextBoxColumn.DataPropertyName = "Preis3"
        Me.Preis3DataGridViewTextBoxColumn.HeaderText = "Preis3"
        Me.Preis3DataGridViewTextBoxColumn.Name = "Preis3DataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'VortragendeDataGridViewTextBoxColumn
        '
        Me.VortragendeDataGridViewTextBoxColumn.DataPropertyName = "Vortragende"
        Me.VortragendeDataGridViewTextBoxColumn.HeaderText = "Vortragende"
        Me.VortragendeDataGridViewTextBoxColumn.Name = "VortragendeDataGridViewTextBoxColumn"
        '
        'ReserveDataGridViewTextBoxColumn
        '
        Me.ReserveDataGridViewTextBoxColumn.DataPropertyName = "Reserve"
        Me.ReserveDataGridViewTextBoxColumn.HeaderText = "Reserve"
        Me.ReserveDataGridViewTextBoxColumn.Name = "ReserveDataGridViewTextBoxColumn"
        '
        'KursdauerDataGridViewTextBoxColumn
        '
        Me.KursdauerDataGridViewTextBoxColumn.DataPropertyName = "Kursdauer"
        Me.KursdauerDataGridViewTextBoxColumn.HeaderText = "Kursdauer"
        Me.KursdauerDataGridViewTextBoxColumn.Name = "KursdauerDataGridViewTextBoxColumn"
        '
        'KostenKursortDataGridViewTextBoxColumn
        '
        Me.KostenKursortDataGridViewTextBoxColumn.DataPropertyName = "KostenKursort"
        Me.KostenKursortDataGridViewTextBoxColumn.HeaderText = "KostenKursort"
        Me.KostenKursortDataGridViewTextBoxColumn.Name = "KostenKursortDataGridViewTextBoxColumn"
        '
        'KursartDataGridViewTextBoxColumn
        '
        Me.KursartDataGridViewTextBoxColumn.DataPropertyName = "Kursart"
        Me.KursartDataGridViewTextBoxColumn.HeaderText = "Kursart"
        Me.KursartDataGridViewTextBoxColumn.Name = "KursartDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'bsKurse
        '
        Me.bsKurse.DataMember = "Kurse"
        Me.bsKurse.DataSource = Me.DsAusbildung
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(9, 583)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(208, 55)
        Me.Button4.TabIndex = 141
        Me.Button4.Text = "Teilnehmer löschen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonLeeren
        '
        Me.ButtonLeeren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLeeren.Location = New System.Drawing.Point(282, 583)
        Me.ButtonLeeren.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLeeren.Name = "ButtonLeeren"
        Me.ButtonLeeren.Size = New System.Drawing.Size(172, 55)
        Me.ButtonLeeren.TabIndex = 140
        Me.ButtonLeeren.Text = "Formular leeren"
        Me.ButtonLeeren.UseVisualStyleBackColor = True
        '
        'ButtonSpeichern
        '
        Me.ButtonSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpeichern.Location = New System.Drawing.Point(537, 583)
        Me.ButtonSpeichern.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSpeichern.Name = "ButtonSpeichern"
        Me.ButtonSpeichern.Size = New System.Drawing.Size(199, 55)
        Me.ButtonSpeichern.TabIndex = 139
        Me.ButtonSpeichern.Text = "Speichern"
        Me.ButtonSpeichern.UseVisualStyleBackColor = True
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(239, 64)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(132, 22)
        Me.TextBox21.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Kurs"
        '
        'PictureBox4
        '
        Me.PictureBox4.ErrorImage = CType(resources.GetObject("PictureBox4.ErrorImage"), System.Drawing.Image)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(101, 20)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 135
        Me.PictureBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(620, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "Clubmitglied"
        Me.Label10.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "VZname", True))
        Me.TextBox1.Location = New System.Drawing.Point(239, 17)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 22)
        Me.TextBox1.TabIndex = 132
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(161, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 133
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Name"
        '
        'taCrewAdressen
        '
        Me.taCrewAdressen.ClearBeforeFill = True
        '
        'taKurse
        '
        Me.taKurse.ClearBeforeFill = True
        '
        'taTeilnehmer
        '
        Me.taTeilnehmer.ClearBeforeFill = True
        '
        'taKontakte
        '
        Me.taKontakte.ClearBeforeFill = True
        '
        'taMaterialKurs
        '
        Me.taMaterialKurs.ClearBeforeFill = True
        '
        'taVeranstalTeilnehmer
        '
        Me.taVeranstalTeilnehmer.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "Clubmitglied", True))
        Me.CheckBox1.Location = New System.Drawing.Point(848, 536)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox1.TabIndex = 152
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKurse, "Kursbezeichnung", True))
        Me.TextBox3.Location = New System.Drawing.Point(843, 51)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 153
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKurse, "Fahrtbereich", True))
        Me.TextBox4.Location = New System.Drawing.Point(843, 79)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 154
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(510, 64)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(73, 22)
        Me.TextBox5.TabIndex = 155
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(421, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "Fahrtbereich"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "Kurs", True))
        Me.TextBox6.Location = New System.Drawing.Point(843, 114)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 157
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "FB", True))
        Me.TextBox7.Location = New System.Drawing.Point(843, 143)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 158
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView3)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 473)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "VZname", True))
        Me.TextBox8.Location = New System.Drawing.Point(239, 51)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(276, 22)
        Me.TextBox8.TabIndex = 160
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "Name alt"
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "VZName", True))
        Me.TextBox9.Location = New System.Drawing.Point(843, 176)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 22)
        Me.TextBox9.TabIndex = 162
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMaterialKurs, "VZName", True))
        Me.TextBox10.Location = New System.Drawing.Point(843, 214)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 22)
        Me.TextBox10.TabIndex = 163
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstalTeilnehmer, "VZname", True))
        Me.TextBox11.Location = New System.Drawing.Point(843, 253)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 22)
        Me.TextBox11.TabIndex = 164
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(843, 291)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 22)
        Me.TextBox12.TabIndex = 165
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "KursPreis", True))
        Me.TextBox13.Location = New System.Drawing.Point(843, 317)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 22)
        Me.TextBox13.TabIndex = 166
        '
        'KursMTeilnehmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 647)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonLeeren)
        Me.Controls.Add(Me.ButtonSpeichern)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "KursMTeilnehmer"
        Me.Text = "Teilnehmer einem Kurs zuordnen"
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVeranstalTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaterialKurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKontakte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ButtonLeeren As System.Windows.Forms.Button
    Friend WithEvents ButtonSpeichern As System.Windows.Forms.Button
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsKurse As System.Windows.Forms.BindingSource
    Friend WithEvents taKurse As WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter
    Friend WithEvents bsTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter
    Friend WithEvents bsKontakte As System.Windows.Forms.BindingSource
    Friend WithEvents taKontakte As WindowsApplication1.dsAusbildungTableAdapters.KontakteTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAdresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KontaktartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve11DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Reserve41DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Reserve51DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bsMaterialKurs As System.Windows.Forms.BindingSource
    Friend WithEvents taMaterialKurs As WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerkaufspreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsVeranstalTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taVeranstalTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.VeranstalTeilnehmerTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VeranstaltungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VeranstaltungsdatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnmeldedatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeitragDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnredeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClubmitgliedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToernnrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlterersterToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZunameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReisepassNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebOrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FunkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalitaetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReihenfolgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinVerbandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FB2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FB3DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FB4DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AScheinDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MotorbootDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SterbedatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursPreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKBFaelligDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumMatBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumMatFaelligDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FahrtbereichDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursbeginnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VortragendeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReserveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursdauerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenKursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
End Class
