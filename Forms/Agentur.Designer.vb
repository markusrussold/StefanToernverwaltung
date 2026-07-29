<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agentur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agentur))
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.LängeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchiffsnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroßsegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerdrängungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KielartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiefgangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchiffstypDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoeschenButton = New System.Windows.Forms.Button()
        Me.MarkeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormularloeschenButton = New System.Windows.Forms.Button()
        Me.SpeichernButton = New System.Windows.Forms.Button()
        Me.BootnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.CharterfirmaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrosssegelartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaujahrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.bsAgentur = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ansprechspartner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Strasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bemerkung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.taAgentur = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.AgenturTableAdapter()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgenturDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCharter = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCharter = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CharterTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bsPostleitzahlen = New System.Windows.Forms.BindingSource(Me.components)
        Me.taPostleitzahlen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.PostleitzahlenTableAdapter()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAgentur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCharter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPostleitzahlen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DurchfahrtshoeheDataGridViewTextBoxColumn
        '
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn.DataPropertyName = "Durchfahrtshoehe"
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn.HeaderText = "Durchfahrtshoehe"
        Me.DurchfahrtshoeheDataGridViewTextBoxColumn.Name = "DurchfahrtshoeheDataGridViewTextBoxColumn"
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LängeDataGridViewTextBoxColumn
        '
        Me.LängeDataGridViewTextBoxColumn.DataPropertyName = "Länge"
        Me.LängeDataGridViewTextBoxColumn.HeaderText = "Länge"
        Me.LängeDataGridViewTextBoxColumn.Name = "LängeDataGridViewTextBoxColumn"
        '
        'SchiffsnummerDataGridViewTextBoxColumn
        '
        Me.SchiffsnummerDataGridViewTextBoxColumn.DataPropertyName = "Schiffsnummer"
        Me.SchiffsnummerDataGridViewTextBoxColumn.HeaderText = "Schiffsnummer"
        Me.SchiffsnummerDataGridViewTextBoxColumn.Name = "SchiffsnummerDataGridViewTextBoxColumn"
        '
        'BreiteDataGridViewTextBoxColumn
        '
        Me.BreiteDataGridViewTextBoxColumn.DataPropertyName = "Breite"
        Me.BreiteDataGridViewTextBoxColumn.HeaderText = "Breite"
        Me.BreiteDataGridViewTextBoxColumn.Name = "BreiteDataGridViewTextBoxColumn"
        '
        'GroßsegelDataGridViewTextBoxColumn
        '
        Me.GroßsegelDataGridViewTextBoxColumn.DataPropertyName = "Großsegel"
        Me.GroßsegelDataGridViewTextBoxColumn.HeaderText = "Großsegel"
        Me.GroßsegelDataGridViewTextBoxColumn.Name = "GroßsegelDataGridViewTextBoxColumn"
        '
        'VerdrängungDataGridViewTextBoxColumn
        '
        Me.VerdrängungDataGridViewTextBoxColumn.DataPropertyName = "Verdrängung"
        Me.VerdrängungDataGridViewTextBoxColumn.HeaderText = "Verdrängung"
        Me.VerdrängungDataGridViewTextBoxColumn.Name = "VerdrängungDataGridViewTextBoxColumn"
        '
        'KielartDataGridViewTextBoxColumn
        '
        Me.KielartDataGridViewTextBoxColumn.DataPropertyName = "Kielart"
        Me.KielartDataGridViewTextBoxColumn.HeaderText = "Kielart"
        Me.KielartDataGridViewTextBoxColumn.Name = "KielartDataGridViewTextBoxColumn"
        '
        'TiefgangDataGridViewTextBoxColumn
        '
        Me.TiefgangDataGridViewTextBoxColumn.DataPropertyName = "Tiefgang"
        Me.TiefgangDataGridViewTextBoxColumn.HeaderText = "Tiefgang"
        Me.TiefgangDataGridViewTextBoxColumn.Name = "TiefgangDataGridViewTextBoxColumn"
        '
        'SchiffstypDataGridViewTextBoxColumn
        '
        Me.SchiffstypDataGridViewTextBoxColumn.DataPropertyName = "Schiffstyp"
        Me.SchiffstypDataGridViewTextBoxColumn.HeaderText = "Schiffstyp"
        Me.SchiffstypDataGridViewTextBoxColumn.Name = "SchiffstypDataGridViewTextBoxColumn"
        '
        'LoeschenButton
        '
        Me.LoeschenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoeschenButton.Location = New System.Drawing.Point(12, 493)
        Me.LoeschenButton.Name = "LoeschenButton"
        Me.LoeschenButton.Size = New System.Drawing.Size(172, 40)
        Me.LoeschenButton.TabIndex = 13
        Me.LoeschenButton.Text = "Firma löschen"
        Me.LoeschenButton.UseVisualStyleBackColor = True
        '
        'MarkeDataGridViewTextBoxColumn
        '
        Me.MarkeDataGridViewTextBoxColumn.DataPropertyName = "Marke"
        Me.MarkeDataGridViewTextBoxColumn.HeaderText = "Marke"
        Me.MarkeDataGridViewTextBoxColumn.Name = "MarkeDataGridViewTextBoxColumn"
        '
        'FormularloeschenButton
        '
        Me.FormularloeschenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormularloeschenButton.Location = New System.Drawing.Point(243, 493)
        Me.FormularloeschenButton.Name = "FormularloeschenButton"
        Me.FormularloeschenButton.Size = New System.Drawing.Size(157, 40)
        Me.FormularloeschenButton.TabIndex = 12
        Me.FormularloeschenButton.Text = "Formular leeren"
        Me.FormularloeschenButton.UseVisualStyleBackColor = True
        '
        'SpeichernButton
        '
        Me.SpeichernButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeichernButton.Location = New System.Drawing.Point(455, 493)
        Me.SpeichernButton.Name = "SpeichernButton"
        Me.SpeichernButton.Size = New System.Drawing.Size(162, 40)
        Me.SpeichernButton.TabIndex = 11
        Me.SpeichernButton.Text = "Speichern"
        Me.SpeichernButton.UseVisualStyleBackColor = True
        '
        'BootnameDataGridViewTextBoxColumn
        '
        Me.BootnameDataGridViewTextBoxColumn.DataPropertyName = "Bootname"
        Me.BootnameDataGridViewTextBoxColumn.HeaderText = "Bootname"
        Me.BootnameDataGridViewTextBoxColumn.Name = "BootnameDataGridViewTextBoxColumn"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BootnameDataGridViewTextBoxColumn, Me.MarkeDataGridViewTextBoxColumn, Me.SchiffstypDataGridViewTextBoxColumn, Me.KielartDataGridViewTextBoxColumn, Me.SchiffsnummerDataGridViewTextBoxColumn, Me.DurchfahrtshoeheDataGridViewTextBoxColumn, Me.LängeDataGridViewTextBoxColumn, Me.BreiteDataGridViewTextBoxColumn, Me.VerdrängungDataGridViewTextBoxColumn, Me.TiefgangDataGridViewTextBoxColumn, Me.GroßsegelDataGridViewTextBoxColumn, Me.VorsegelDataGridViewTextBoxColumn, Me.WassertankDataGridViewTextBoxColumn, Me.DieseltankDataGridViewTextBoxColumn, Me.StarterbatterieDataGridViewTextBoxColumn, Me.ServicebatterieDataGridViewTextBoxColumn, Me.KabinenanzahlDataGridViewTextBoxColumn, Me.KojenanzahlDataGridViewTextBoxColumn, Me.NassraeumeanzahlDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.KautionDataGridViewTextBoxColumn, Me.BildDataGridViewTextBoxColumn, Me.CharterfirmaDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.TestDataGridViewTextBoxColumn, Me.GrosssegelartDataGridViewTextBoxColumn, Me.BaujahrDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsBoot
        Me.DataGridView2.Location = New System.Drawing.Point(1130, 211)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 14
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'CharterfirmaDataGridViewTextBoxColumn1
        '
        Me.CharterfirmaDataGridViewTextBoxColumn1.DataPropertyName = "Charterfirma"
        Me.CharterfirmaDataGridViewTextBoxColumn1.HeaderText = "Charterfirma"
        Me.CharterfirmaDataGridViewTextBoxColumn1.Name = "CharterfirmaDataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
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
        'bsBoot
        '
        Me.bsBoot.DataMember = "Boot"
        Me.bsBoot.DataSource = Me.dsToernverwaltung
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 499)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 13)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Doppelklick auf Boot --> Boot"
        '
        'taBoot
        '
        Me.taBoot.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(623, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(178, 522)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Boote"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(11, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(158, 472)
        Me.ListBox1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agenturadresse"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(65, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Bankverbindung"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "R1", True))
        Me.TextBox8.Location = New System.Drawing.Point(130, 237)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(183, 22)
        Me.TextBox8.TabIndex = 25
        '
        'bsAgentur
        '
        Me.bsAgentur.DataMember = "Agentur"
        Me.bsAgentur.DataSource = Me.dsToernverwaltung
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Handy", True))
        Me.TextBox7.Location = New System.Drawing.Point(443, 237)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(143, 22)
        Me.TextBox7.TabIndex = 23
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "WEB", True))
        Me.TextBox9.Location = New System.Drawing.Point(443, 160)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(145, 22)
        Me.TextBox9.TabIndex = 21
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "email", True))
        Me.TextBox10.Location = New System.Drawing.Point(443, 119)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(144, 22)
        Me.TextBox10.TabIndex = 20
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Fax", True))
        Me.TextBox11.Location = New System.Drawing.Point(443, 80)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(144, 22)
        Me.TextBox11.TabIndex = 19
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Tel", True))
        Me.TextBox12.Location = New System.Drawing.Point(443, 37)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(144, 22)
        Me.TextBox12.TabIndex = 18
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Ansprechspartner", True))
        Me.TextBox6.Location = New System.Drawing.Point(443, 197)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(142, 22)
        Me.TextBox6.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Land", True))
        Me.TextBox5.Location = New System.Drawing.Point(130, 197)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(186, 22)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Ort", True))
        Me.TextBox4.Location = New System.Drawing.Point(130, 158)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 22)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Plz", True))
        Me.TextBox3.Location = New System.Drawing.Point(130, 117)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 22)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Strasse", True))
        Me.TextBox2.Location = New System.Drawing.Point(130, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(185, 22)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Agentur", True))
        Me.TextBox1.Location = New System.Drawing.Point(130, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(350, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Kontaktperson"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(350, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "WEB Seite"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "e-mail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fax"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Mobile"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Telefon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Land"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Plz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Straße"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agentur"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 171)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Ansprechspartner, Me.OrtDataGridViewTextBoxColumn, Me.LandDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.Strasse, Me.Plz, Me.Tel, Me.WEB, Me.Bemerkung})
        Me.DataGridView1.DataSource = Me.bsAgentur
        Me.DataGridView1.Location = New System.Drawing.Point(105, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(612, 144)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Agentur"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Agentur"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Ansprechspartner
        '
        Me.Ansprechspartner.DataPropertyName = "Ansprechspartner"
        Me.Ansprechspartner.HeaderText = "Ansprechspartner"
        Me.Ansprechspartner.Name = "Ansprechspartner"
        Me.Ansprechspartner.ReadOnly = True
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        Me.OrtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LandDataGridViewTextBoxColumn
        '
        Me.LandDataGridViewTextBoxColumn.DataPropertyName = "Land"
        Me.LandDataGridViewTextBoxColumn.HeaderText = "Land"
        Me.LandDataGridViewTextBoxColumn.Name = "LandDataGridViewTextBoxColumn"
        Me.LandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HandyDataGridViewTextBoxColumn
        '
        Me.HandyDataGridViewTextBoxColumn.DataPropertyName = "Handy"
        Me.HandyDataGridViewTextBoxColumn.HeaderText = "Handy"
        Me.HandyDataGridViewTextBoxColumn.Name = "HandyDataGridViewTextBoxColumn"
        Me.HandyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fax"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Strasse
        '
        Me.Strasse.DataPropertyName = "Strasse"
        Me.Strasse.HeaderText = "Strasse"
        Me.Strasse.Name = "Strasse"
        Me.Strasse.ReadOnly = True
        '
        'Plz
        '
        Me.Plz.DataPropertyName = "Plz"
        Me.Plz.HeaderText = "Plz"
        Me.Plz.Name = "Plz"
        Me.Plz.ReadOnly = True
        '
        'Tel
        '
        Me.Tel.DataPropertyName = "Tel"
        Me.Tel.HeaderText = "Tel"
        Me.Tel.Name = "Tel"
        Me.Tel.ReadOnly = True
        '
        'WEB
        '
        Me.WEB.DataPropertyName = "WEB"
        Me.WEB.HeaderText = "WEB"
        Me.WEB.Name = "WEB"
        Me.WEB.ReadOnly = True
        '
        'Bemerkung
        '
        Me.Bemerkung.DataPropertyName = "Bemerkung"
        Me.Bemerkung.HeaderText = "Bemerkung"
        Me.Bemerkung.Name = "Bemerkung"
        Me.Bemerkung.ReadOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgentur, "Bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 21)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(610, 135)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.ListBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(807, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(181, 522)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Charterfirma"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 499)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Doppelklick auf Name --> Charter"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(11, 24)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(159, 472)
        Me.ListBox2.TabIndex = 8
        '
        'taAgentur
        '
        Me.taAgentur.ClearBeforeFill = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.AgenturDataGridViewTextBoxColumn1})
        Me.DataGridView4.DataSource = Me.bsCharter
        Me.DataGridView4.Location = New System.Drawing.Point(1130, 44)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView4.TabIndex = 20
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'AgenturDataGridViewTextBoxColumn1
        '
        Me.AgenturDataGridViewTextBoxColumn1.DataPropertyName = "Agentur"
        Me.AgenturDataGridViewTextBoxColumn1.HeaderText = "Agentur"
        Me.AgenturDataGridViewTextBoxColumn1.Name = "AgenturDataGridViewTextBoxColumn1"
        '
        'bsCharter
        '
        Me.bsCharter.DataMember = "Charter"
        Me.bsCharter.DataSource = Me.dsToernverwaltung
        '
        'taCharter
        '
        Me.taCharter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 474)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Label13"
        '
        'bsPostleitzahlen
        '
        Me.bsPostleitzahlen.DataMember = "Postleitzahlen"
        Me.bsPostleitzahlen.DataSource = Me.dsToernverwaltung
        '
        'taPostleitzahlen
        '
        Me.taPostleitzahlen.ClearBeforeFill = True
        '
        'Agentur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 550)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LoeschenButton)
        Me.Controls.Add(Me.FormularloeschenButton)
        Me.Controls.Add(Me.SpeichernButton)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agentur"
        Me.Text = "Agentur"
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAgentur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCharter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPostleitzahlen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DurchfahrtshoeheDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents LängeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchiffsnummerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BreiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroßsegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerdrängungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KielartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiefgangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchiffstypDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoeschenButton As System.Windows.Forms.Button
    Friend WithEvents MarkeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormularloeschenButton As System.Windows.Forms.Button
    Friend WithEvents SpeichernButton As System.Windows.Forms.Button
    Friend WithEvents BootnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents CharterfirmaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrosssegelartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaujahrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents bsAgentur As System.Windows.Forms.BindingSource
    Friend WithEvents taAgentur As WindowsApplication1.ToernverwaltungDataSetTableAdapters.AgenturTableAdapter
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenturDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ansprechspartner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Strasse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Plz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bemerkung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsCharter As System.Windows.Forms.BindingSource
    Friend WithEvents taCharter As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CharterTableAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents bsPostleitzahlen As System.Windows.Forms.BindingSource
    Friend WithEvents taPostleitzahlen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.PostleitzahlenTableAdapter
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
