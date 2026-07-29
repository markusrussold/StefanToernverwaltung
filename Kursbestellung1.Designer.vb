<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kursbestellung1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kursbestellung1))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.bsKurse = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.KursbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FahrtbereichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursbeginnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VortragendeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursdauerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenKursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taKurse = New WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonDrucken = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Listenpreis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Einkaufspreis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lieferant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsKursmaterial = New System.Windows.Forms.BindingSource(Me.components)
        Me.taKursmaterial = New WindowsApplication1.dsAusbildungTableAdapters.KursmaterialTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bsMaterialKurs = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.bsTemp = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.taMaterialKurs = New WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Feld0DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.taTemp = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kurs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKursmaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaterialKurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 122)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kurs"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(65, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKurse, "Fahrtbereich", True))
        Me.TextBox10.Location = New System.Drawing.Point(461, 51)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(45, 21)
        Me.TextBox10.TabIndex = 13
        '
        'bsKurse
        '
        Me.bsKurse.DataMember = "Kurse"
        Me.bsKurse.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKurse, "Kursbezeichnung", True))
        Me.TextBox2.Location = New System.Drawing.Point(127, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 21)
        Me.TextBox2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fahrtbereich"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Kurs"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KursbezeichnungDataGridViewTextBoxColumn, Me.FahrtbereichDataGridViewTextBoxColumn, Me.Preis1DataGridViewTextBoxColumn, Me.Preis2DataGridViewTextBoxColumn, Me.Preis3DataGridViewTextBoxColumn, Me.KursbeginnDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.VortragendeDataGridViewTextBoxColumn, Me.ReserveDataGridViewTextBoxColumn, Me.KursdauerDataGridViewTextBoxColumn, Me.KursortDataGridViewTextBoxColumn, Me.KostenKursortDataGridViewTextBoxColumn, Me.KursartDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.bsKurse
        Me.DataGridView4.Location = New System.Drawing.Point(12, 140)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(549, 260)
        Me.DataGridView4.TabIndex = 14
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
        'KursbeginnDataGridViewTextBoxColumn
        '
        Me.KursbeginnDataGridViewTextBoxColumn.DataPropertyName = "Kursbeginn"
        Me.KursbeginnDataGridViewTextBoxColumn.HeaderText = "Kursbeginn"
        Me.KursbeginnDataGridViewTextBoxColumn.Name = "KursbeginnDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
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
        'KursortDataGridViewTextBoxColumn
        '
        Me.KursortDataGridViewTextBoxColumn.DataPropertyName = "Kursort"
        Me.KursortDataGridViewTextBoxColumn.HeaderText = "Kursort"
        Me.KursortDataGridViewTextBoxColumn.Name = "KursortDataGridViewTextBoxColumn"
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'taKurse
        '
        Me.taKurse.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(129, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 56)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Formular löschen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonDrucken
        '
        Me.ButtonDrucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDrucken.Location = New System.Drawing.Point(403, 418)
        Me.ButtonDrucken.Name = "ButtonDrucken"
        Me.ButtonDrucken.Size = New System.Drawing.Size(158, 56)
        Me.ButtonDrucken.TabIndex = 15
        Me.ButtonDrucken.Text = "Drucken"
        Me.ButtonDrucken.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(644, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(156, 259)
        Me.ListBox1.TabIndex = 17
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialDataGridViewTextBoxColumn, Me.Listenpreis, Me.Einkaufspreis, Me.Lieferant, Me.Datum, Me.BemerkungDataGridViewTextBoxColumn1, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.bsKursmaterial
        Me.DataGridView3.Location = New System.Drawing.Point(706, 25)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(387, 260)
        Me.DataGridView3.TabIndex = 18
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "Material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        '
        'Listenpreis
        '
        Me.Listenpreis.DataPropertyName = "Listenpreis"
        Me.Listenpreis.HeaderText = "Listenpreis"
        Me.Listenpreis.Name = "Listenpreis"
        '
        'Einkaufspreis
        '
        Me.Einkaufspreis.DataPropertyName = "Einkaufspreis"
        Me.Einkaufspreis.HeaderText = "Einkaufspreis"
        Me.Einkaufspreis.Name = "Einkaufspreis"
        '
        'Lieferant
        '
        Me.Lieferant.DataPropertyName = "Lieferant"
        Me.Lieferant.HeaderText = "Lieferant"
        Me.Lieferant.Name = "Lieferant"
        '
        'Datum
        '
        Me.Datum.DataPropertyName = "Datum"
        Me.Datum.HeaderText = "Datum"
        Me.Datum.Name = "Datum"
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'bsKursmaterial
        '
        Me.bsKursmaterial.DataMember = "Kursmaterial"
        Me.bsKursmaterial.DataSource = Me.DsAusbildung
        '
        'taKursmaterial
        '
        Me.taKursmaterial.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKursmaterial, "Material", True))
        Me.TextBox1.Location = New System.Drawing.Point(653, 334)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 19
        '
        'bsMaterialKurs
        '
        Me.bsMaterialKurs.DataMember = "MaterialKurs"
        Me.bsMaterialKurs.DataSource = Me.DsAusbildung
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld1", True))
        Me.TextBox3.Location = New System.Drawing.Point(653, 379)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 21)
        Me.TextBox3.TabIndex = 20
        '
        'bsTemp
        '
        Me.bsTemp.DataMember = "Temp"
        Me.bsTemp.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'taMaterialKurs
        '
        Me.taMaterialKurs.ClearBeforeFill = True
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld2", True))
        Me.TextBox4.Location = New System.Drawing.Point(653, 418)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 21)
        Me.TextBox4.TabIndex = 22
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.Feld1DataGridViewTextBoxColumn, Me.Feld2DataGridViewTextBoxColumn, Me.Feld3DataGridViewTextBoxColumn, Me.Feld4DataGridViewTextBoxColumn, Me.Feld5DataGridViewTextBoxColumn, Me.Feld6DataGridViewTextBoxColumn, Me.Feld7DataGridViewTextBoxColumn, Me.Feld8DataGridViewTextBoxColumn, Me.Feld9DataGridViewTextBoxColumn, Me.Feld10DataGridViewTextBoxColumn, Me.Feld11DataGridViewTextBoxColumn, Me.Feld12DataGridViewTextBoxColumn, Me.Feld13DataGridViewTextBoxColumn, Me.Feld14DataGridViewTextBoxColumn, Me.Feld15DataGridViewTextBoxColumn, Me.Feld16DataGridViewTextBoxColumn, Me.Feld17DataGridViewTextBoxColumn, Me.Feld18DataGridViewTextBoxColumn, Me.Feld19DataGridViewTextBoxColumn, Me.Feld20DataGridViewTextBoxColumn, Me.Feld21DataGridViewTextBoxColumn, Me.Feld22DataGridViewTextBoxColumn, Me.Feld23DataGridViewTextBoxColumn, Me.Feld24DataGridViewTextBoxColumn, Me.Feld25DataGridViewTextBoxColumn, Me.Feld26DataGridViewTextBoxColumn, Me.Feld27DataGridViewTextBoxColumn, Me.Feld28DataGridViewTextBoxColumn, Me.Feld0DataGridViewTextBoxColumn, Me.Feld29DataGridViewTextBoxColumn, Me.Feld30DataGridViewTextBoxColumn, Me.Feld31DataGridViewTextBoxColumn, Me.Feld32DataGridViewTextBoxColumn, Me.Feld33DataGridViewTextBoxColumn, Me.Feld34DataGridViewTextBoxColumn, Me.Feld35DataGridViewTextBoxColumn, Me.Feld36DataGridViewTextBoxColumn, Me.Feld37DataGridViewTextBoxColumn, Me.Feld38DataGridViewTextBoxColumn, Me.Feld39DataGridViewTextBoxColumn, Me.Feld40DataGridViewTextBoxColumn, Me.Feld41DataGridViewTextBoxColumn, Me.Feld42DataGridViewTextBoxColumn, Me.Feld43DataGridViewTextBoxColumn, Me.Feld44DataGridViewTextBoxColumn, Me.Feld45DataGridViewTextBoxColumn, Me.Feld46DataGridViewTextBoxColumn, Me.Feld47DataGridViewTextBoxColumn, Me.Feld48DataGridViewTextBoxColumn, Me.Feld49DataGridViewTextBoxColumn, Me.Feld50DataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsTemp
        Me.DataGridView2.Location = New System.Drawing.Point(832, 324)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 23
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
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
        'Feld0DataGridViewTextBoxColumn
        '
        Me.Feld0DataGridViewTextBoxColumn.DataPropertyName = "Feld0"
        Me.Feld0DataGridViewTextBoxColumn.HeaderText = "Feld0"
        Me.Feld0DataGridViewTextBoxColumn.Name = "Feld0DataGridViewTextBoxColumn"
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
        'taTemp
        '
        Me.taTemp.ClearBeforeFill = True
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld3", True))
        Me.TextBox5.Location = New System.Drawing.Point(653, 446)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 21)
        Me.TextBox5.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.VZName, Me.Kurs, Me.FB})
        Me.DataGridView1.DataSource = Me.bsTeilnehmer
        Me.DataGridView1.Location = New System.Drawing.Point(774, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'VZName
        '
        Me.VZName.DataPropertyName = "VZName"
        Me.VZName.HeaderText = "VZName"
        Me.VZName.Name = "VZName"
        '
        'Kurs
        '
        Me.Kurs.DataPropertyName = "Kurs"
        Me.Kurs.HeaderText = "Kurs"
        Me.Kurs.Name = "Kurs"
        '
        'FB
        '
        Me.FB.DataPropertyName = "FB"
        Me.FB.HeaderText = "FB"
        Me.FB.Name = "FB"
        '
        'bsTeilnehmer
        '
        Me.bsTeilnehmer.DataMember = "Teilnehmer"
        Me.bsTeilnehmer.DataSource = Me.DsAusbildung
        '
        'taTeilnehmer
        '
        Me.taTeilnehmer.ClearBeforeFill = True
        '
        'Kursbestellung1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 493)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonDrucken)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kursbestellung1"
        Me.Text = "Bestellformular"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKursmaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaterialKurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsKurse As System.Windows.Forms.BindingSource
    Friend WithEvents taKurse As WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonDrucken As System.Windows.Forms.Button
    Friend WithEvents KursbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FahrtbereichDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursbeginnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VortragendeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReserveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursdauerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenKursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents bsKursmaterial As System.Windows.Forms.BindingSource
    Friend WithEvents taKursmaterial As WindowsApplication1.dsAusbildungTableAdapters.KursmaterialTableAdapter
    Friend WithEvents MaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Listenpreis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Einkaufspreis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lieferant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents bsMaterialKurs As System.Windows.Forms.BindingSource
    Friend WithEvents taMaterialKurs As WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsTemp As System.Windows.Forms.BindingSource
    Friend WithEvents taTemp As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Feld0DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kurs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
