<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KursTeilnVerw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KursTeilnVerw))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKBFaelligDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumMatBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumMatFaelligDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.taTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ButtonLeeren = New System.Windows.Forms.Button()
        Me.ButtonSpeichern = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.KursbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FahrtbereichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursbeginnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VortragendeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursdauerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenKursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsKurse = New System.Windows.Forms.BindingSource(Me.components)
        Me.taKurse = New WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox6Kalender = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button5Zurueck = New System.Windows.Forms.Button()
        Me.Button7Speichern = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6Kalender.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZNameDataGridViewTextBoxColumn, Me.KursDataGridViewTextBoxColumn, Me.FBDataGridViewTextBoxColumn, Me.KursPreisDataGridViewTextBoxColumn, Me.MaterialpreisDataGridViewTextBoxColumn, Me.KursBezahltDataGridViewTextBoxColumn, Me.MaterialBezahltDataGridViewTextBoxColumn, Me.DatumKursBezahltDataGridViewTextBoxColumn, Me.DatumKBFaelligDataGridViewTextBoxColumn, Me.DatumMatBezahltDataGridViewTextBoxColumn, Me.DatumMatFaelligDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsTeilnehmer
        Me.DataGridView1.Location = New System.Drawing.Point(12, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 188)
        Me.DataGridView1.TabIndex = 0
        '
        'VZNameDataGridViewTextBoxColumn
        '
        Me.VZNameDataGridViewTextBoxColumn.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.Name = "VZNameDataGridViewTextBoxColumn"
        Me.VZNameDataGridViewTextBoxColumn.Width = 150
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
        Me.FBDataGridViewTextBoxColumn.Width = 50
        '
        'KursPreisDataGridViewTextBoxColumn
        '
        Me.KursPreisDataGridViewTextBoxColumn.DataPropertyName = "KursPreis"
        Me.KursPreisDataGridViewTextBoxColumn.HeaderText = "KursPreis"
        Me.KursPreisDataGridViewTextBoxColumn.Name = "KursPreisDataGridViewTextBoxColumn"
        '
        'MaterialpreisDataGridViewTextBoxColumn
        '
        Me.MaterialpreisDataGridViewTextBoxColumn.DataPropertyName = "Materialpreis"
        Me.MaterialpreisDataGridViewTextBoxColumn.HeaderText = "Materialpreis"
        Me.MaterialpreisDataGridViewTextBoxColumn.Name = "MaterialpreisDataGridViewTextBoxColumn"
        '
        'KursBezahltDataGridViewTextBoxColumn
        '
        Me.KursBezahltDataGridViewTextBoxColumn.DataPropertyName = "KursBezahlt"
        Me.KursBezahltDataGridViewTextBoxColumn.HeaderText = "KursBezahlt"
        Me.KursBezahltDataGridViewTextBoxColumn.Name = "KursBezahltDataGridViewTextBoxColumn"
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
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
        'taTeilnehmer
        '
        Me.taTeilnehmer.ClearBeforeFill = True
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "FB", True))
        Me.TextBox22.Location = New System.Drawing.Point(460, 65)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 22)
        Me.TextBox22.TabIndex = 120
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "Kurs", True))
        Me.TextBox21.Location = New System.Drawing.Point(136, 65)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 22)
        Me.TextBox21.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(457, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Clubmitglied"
        Me.Label10.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "VZName", True))
        Me.TextBox1.Location = New System.Drawing.Point(136, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 22)
        Me.TextBox1.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Fahrtbereich"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Kurs"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Name"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(414, 349)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 130
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(118, 349)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 129
        Me.PictureBox5.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(371, 359)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 16)
        Me.Label24.TabIndex = 128
        Me.Label24.Text = "am"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 358)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 16)
        Me.Label25.TabIndex = 127
        Me.Label25.Text = "fällig am"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumKursBezahlt", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(460, 356)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox3.TabIndex = 126
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumKBFaellig", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(177, 356)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox4.TabIndex = 125
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "KursBezahlt", True))
        Me.TextBox4.Location = New System.Drawing.Point(460, 324)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 124
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(177, 327)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox1.TabIndex = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Bezahlt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Kurspreis"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.PictureBox3)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TextBox6)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 430)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(566, 133)
        Me.GroupBox5.TabIndex = 131
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kursmaterial"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(79, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(402, 72)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 114
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 15)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "am"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "fällig am"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumMatBezahlt", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(446, 80)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox1.TabIndex = 110
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumMatFaellig", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(126, 80)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox2.TabIndex = 109
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Summe €"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(162, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(356, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Bezahlt €"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(126, 14)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(30, 21)
        Me.TextBox7.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "Materialpreis", True))
        Me.TextBox5.Location = New System.Drawing.Point(126, 44)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(79, 21)
        Me.TextBox5.TabIndex = 17
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Preisnachlass"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "MaterialBezahlt", True))
        Me.TextBox6.Location = New System.Drawing.Point(446, 44)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 21)
        Me.TextBox6.TabIndex = 19
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonLeeren
        '
        Me.ButtonLeeren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLeeren.Location = New System.Drawing.Point(159, 569)
        Me.ButtonLeeren.Name = "ButtonLeeren"
        Me.ButtonLeeren.Size = New System.Drawing.Size(129, 45)
        Me.ButtonLeeren.TabIndex = 133
        Me.ButtonLeeren.Text = "Formular leeren"
        Me.ButtonLeeren.UseVisualStyleBackColor = True
        '
        'ButtonSpeichern
        '
        Me.ButtonSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpeichern.Location = New System.Drawing.Point(429, 569)
        Me.ButtonSpeichern.Name = "ButtonSpeichern"
        Me.ButtonSpeichern.Size = New System.Drawing.Size(149, 45)
        Me.ButtonSpeichern.TabIndex = 132
        Me.ButtonSpeichern.Text = "Speichern"
        Me.ButtonSpeichern.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KursbezeichnungDataGridViewTextBoxColumn, Me.FahrtbereichDataGridViewTextBoxColumn, Me.Preis1DataGridViewTextBoxColumn, Me.Preis2DataGridViewTextBoxColumn, Me.Preis3DataGridViewTextBoxColumn, Me.KursbeginnDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.VortragendeDataGridViewTextBoxColumn, Me.ReserveDataGridViewTextBoxColumn, Me.KursdauerDataGridViewTextBoxColumn, Me.KursortDataGridViewTextBoxColumn, Me.KostenKursortDataGridViewTextBoxColumn, Me.KursartDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.bsKurse
        Me.DataGridView2.Location = New System.Drawing.Point(873, 36)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(257, 163)
        Me.DataGridView2.TabIndex = 134
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
        'taKurse
        '
        Me.taKurse.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "KursPreis", True))
        Me.TextBox2.Location = New System.Drawing.Point(177, 328)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 135
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKurse, "Fahrtbereich", True))
        Me.TextBox3.Location = New System.Drawing.Point(638, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 136
        '
        'GroupBox6Kalender
        '
        Me.GroupBox6Kalender.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox6Kalender.Controls.Add(Me.Button5Zurueck)
        Me.GroupBox6Kalender.Controls.Add(Me.Button7Speichern)
        Me.GroupBox6Kalender.Location = New System.Drawing.Point(873, 243)
        Me.GroupBox6Kalender.Name = "GroupBox6Kalender"
        Me.GroupBox6Kalender.Size = New System.Drawing.Size(220, 219)
        Me.GroupBox6Kalender.TabIndex = 137
        Me.GroupBox6Kalender.TabStop = False
        Me.GroupBox6Kalender.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 17)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 86
        '
        'Button5Zurueck
        '
        Me.Button5Zurueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5Zurueck.Location = New System.Drawing.Point(15, 188)
        Me.Button5Zurueck.Name = "Button5Zurueck"
        Me.Button5Zurueck.Size = New System.Drawing.Size(66, 26)
        Me.Button5Zurueck.TabIndex = 88
        Me.Button5Zurueck.Text = "Zurück"
        Me.Button5Zurueck.UseVisualStyleBackColor = True
        '
        'Button7Speichern
        '
        Me.Button7Speichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7Speichern.Location = New System.Drawing.Point(87, 188)
        Me.Button7Speichern.Name = "Button7Speichern"
        Me.Button7Speichern.Size = New System.Drawing.Size(102, 27)
        Me.Button7Speichern.TabIndex = 87
        Me.Button7Speichern.Text = "Speichern"
        Me.Button7Speichern.UseVisualStyleBackColor = True
        '
        'KursTeilnVerw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 621)
        Me.Controls.Add(Me.GroupBox6Kalender)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ButtonLeeren)
        Me.Controls.Add(Me.ButtonSpeichern)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "KursTeilnVerw"
        Me.Text = "Kosten der Kursteilnehmer verwalten"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6Kalender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursPreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKBFaelligDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumMatBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumMatFaelligDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLeeren As System.Windows.Forms.Button
    Friend WithEvents ButtonSpeichern As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsKurse As System.Windows.Forms.BindingSource
    Friend WithEvents taKurse As WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter
    Friend WithEvents KursbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FahrtbereichDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursbeginnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VortragendeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReserveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursdauerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenKursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6Kalender As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button5Zurueck As System.Windows.Forms.Button
    Friend WithEvents Button7Speichern As System.Windows.Forms.Button
End Class
