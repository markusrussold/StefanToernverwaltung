<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Werbung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Werbung))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBeginnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WerbeartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WerbeortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WerbedatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Werbekosten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsWerbemassnahme = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feld28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsListbox = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.taWerbemassnahme = New WindowsApplication1.dsAusbildungTableAdapters.WerbemassnahmeTableAdapter()
        Me.taListbox = New WindowsApplication1.dsAusbildungTableAdapters.ListboxTableAdapter()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6Kalender = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button5Zurueck = New System.Windows.Forms.Button()
        Me.Button7Speichern = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.BtAktionDruck = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWerbemassnahme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6Kalender.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KursDataGridViewTextBoxColumn, Me.FBDataGridViewTextBoxColumn, Me.DatumBeginnDataGridViewTextBoxColumn, Me.WerbeartDataGridViewTextBoxColumn, Me.WerbeortDataGridViewTextBoxColumn, Me.WerbedatumDataGridViewTextBoxColumn, Me.Werbekosten, Me.BemerkungDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsWerbemassnahme
        Me.DataGridView1.Location = New System.Drawing.Point(33, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(949, 300)
        Me.DataGridView1.TabIndex = 0
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
        'DatumBeginnDataGridViewTextBoxColumn
        '
        Me.DatumBeginnDataGridViewTextBoxColumn.DataPropertyName = "DatumBeginn"
        Me.DatumBeginnDataGridViewTextBoxColumn.HeaderText = "DatumBeginn"
        Me.DatumBeginnDataGridViewTextBoxColumn.Name = "DatumBeginnDataGridViewTextBoxColumn"
        '
        'WerbeartDataGridViewTextBoxColumn
        '
        Me.WerbeartDataGridViewTextBoxColumn.DataPropertyName = "Werbeart"
        Me.WerbeartDataGridViewTextBoxColumn.HeaderText = "Werbeart"
        Me.WerbeartDataGridViewTextBoxColumn.Name = "WerbeartDataGridViewTextBoxColumn"
        '
        'WerbeortDataGridViewTextBoxColumn
        '
        Me.WerbeortDataGridViewTextBoxColumn.DataPropertyName = "Werbeort"
        Me.WerbeortDataGridViewTextBoxColumn.HeaderText = "Werbeort"
        Me.WerbeortDataGridViewTextBoxColumn.Name = "WerbeortDataGridViewTextBoxColumn"
        '
        'WerbedatumDataGridViewTextBoxColumn
        '
        Me.WerbedatumDataGridViewTextBoxColumn.DataPropertyName = "Werbedatum"
        Me.WerbedatumDataGridViewTextBoxColumn.HeaderText = "Werbedatum"
        Me.WerbedatumDataGridViewTextBoxColumn.Name = "WerbedatumDataGridViewTextBoxColumn"
        '
        'Werbekosten
        '
        Me.Werbekosten.DataPropertyName = "Werbekosten"
        Me.Werbekosten.HeaderText = "Werbekosten"
        Me.Werbekosten.Name = "Werbekosten"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        '
        'bsWerbemassnahme
        '
        Me.bsWerbemassnahme.DataMember = "Werbemassnahme"
        Me.bsWerbemassnahme.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Kurs", True))
        Me.TextBox1.Location = New System.Drawing.Point(153, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 21)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "FB", True))
        Me.TextBox2.Location = New System.Drawing.Point(422, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 21)
        Me.TextBox2.TabIndex = 2
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "DatumBeginn", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(880, 46)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(80, 21)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Werbeort", True))
        Me.TextBox3.Location = New System.Drawing.Point(422, 87)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(209, 21)
        Me.TextBox3.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Werbeart", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(153, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 23)
        Me.ComboBox1.TabIndex = 4
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Werbedatum", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(880, 86)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(80, 21)
        Me.MaskedTextBox2.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(33, 181)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(949, 300)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Aktion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bereich"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(675, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Datum der Aktion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(675, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Datum Werbemassnahme"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Werbeart"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Werbeort"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Bemerkung"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(112, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(818, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(491, 498)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 47)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Formular löschen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.feld8, Me.feld9, Me.feld10, Me.feld11, Me.feld12, Me.feld13, Me.feld14, Me.feld15, Me.feld16, Me.feld17, Me.feld18, Me.feld19, Me.feld20, Me.feld21, Me.feld22, Me.feld23, Me.feld24, Me.feld25, Me.feld26, Me.feld27, Me.feld28})
        Me.DataGridView2.DataSource = Me.bsListbox
        Me.DataGridView2.Location = New System.Drawing.Point(1294, 72)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 18
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FormularName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FormularName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "feld1"
        Me.DataGridViewTextBoxColumn2.HeaderText = "feld1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "feld2"
        Me.DataGridViewTextBoxColumn3.HeaderText = "feld2"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "feld3"
        Me.DataGridViewTextBoxColumn4.HeaderText = "feld3"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "feld4"
        Me.DataGridViewTextBoxColumn5.HeaderText = "feld4"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "feld5"
        Me.DataGridViewTextBoxColumn6.HeaderText = "feld5"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "feld7"
        Me.DataGridViewTextBoxColumn7.HeaderText = "feld7"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "feld6"
        Me.DataGridViewTextBoxColumn8.HeaderText = "feld6"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'feld8
        '
        Me.feld8.DataPropertyName = "feld8"
        Me.feld8.HeaderText = "feld8"
        Me.feld8.Name = "feld8"
        '
        'feld9
        '
        Me.feld9.DataPropertyName = "feld9"
        Me.feld9.HeaderText = "feld9"
        Me.feld9.Name = "feld9"
        '
        'feld10
        '
        Me.feld10.DataPropertyName = "feld10"
        Me.feld10.HeaderText = "feld10"
        Me.feld10.Name = "feld10"
        '
        'feld11
        '
        Me.feld11.DataPropertyName = "feld11"
        Me.feld11.HeaderText = "feld11"
        Me.feld11.Name = "feld11"
        '
        'feld12
        '
        Me.feld12.DataPropertyName = "feld12"
        Me.feld12.HeaderText = "feld12"
        Me.feld12.Name = "feld12"
        '
        'feld13
        '
        Me.feld13.DataPropertyName = "feld13"
        Me.feld13.HeaderText = "feld13"
        Me.feld13.Name = "feld13"
        '
        'feld14
        '
        Me.feld14.DataPropertyName = "feld14"
        Me.feld14.HeaderText = "feld14"
        Me.feld14.Name = "feld14"
        '
        'feld15
        '
        Me.feld15.DataPropertyName = "feld15"
        Me.feld15.HeaderText = "feld15"
        Me.feld15.Name = "feld15"
        '
        'feld16
        '
        Me.feld16.DataPropertyName = "feld16"
        Me.feld16.HeaderText = "feld16"
        Me.feld16.Name = "feld16"
        '
        'feld17
        '
        Me.feld17.DataPropertyName = "feld17"
        Me.feld17.HeaderText = "feld17"
        Me.feld17.Name = "feld17"
        '
        'feld18
        '
        Me.feld18.DataPropertyName = "feld18"
        Me.feld18.HeaderText = "feld18"
        Me.feld18.Name = "feld18"
        '
        'feld19
        '
        Me.feld19.DataPropertyName = "feld19"
        Me.feld19.HeaderText = "feld19"
        Me.feld19.Name = "feld19"
        '
        'feld20
        '
        Me.feld20.DataPropertyName = "feld20"
        Me.feld20.HeaderText = "feld20"
        Me.feld20.Name = "feld20"
        '
        'feld21
        '
        Me.feld21.DataPropertyName = "feld21"
        Me.feld21.HeaderText = "feld21"
        Me.feld21.Name = "feld21"
        '
        'feld22
        '
        Me.feld22.DataPropertyName = "feld22"
        Me.feld22.HeaderText = "feld22"
        Me.feld22.Name = "feld22"
        '
        'feld23
        '
        Me.feld23.DataPropertyName = "feld23"
        Me.feld23.HeaderText = "feld23"
        Me.feld23.Name = "feld23"
        '
        'feld24
        '
        Me.feld24.DataPropertyName = "feld24"
        Me.feld24.HeaderText = "feld24"
        Me.feld24.Name = "feld24"
        '
        'feld25
        '
        Me.feld25.DataPropertyName = "feld25"
        Me.feld25.HeaderText = "feld25"
        Me.feld25.Name = "feld25"
        '
        'feld26
        '
        Me.feld26.DataPropertyName = "feld26"
        Me.feld26.HeaderText = "feld26"
        Me.feld26.Name = "feld26"
        '
        'feld27
        '
        Me.feld27.DataPropertyName = "feld27"
        Me.feld27.HeaderText = "feld27"
        Me.feld27.Name = "feld27"
        '
        'feld28
        '
        Me.feld28.DataPropertyName = "feld28"
        Me.feld28.HeaderText = "feld28"
        Me.feld28.Name = "feld28"
        '
        'bsListbox
        '
        Me.bsListbox.DataMember = "Listbox"
        Me.bsListbox.DataSource = Me.DsAusbildung
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Werbeart", True))
        Me.TextBox4.Location = New System.Drawing.Point(1346, 238)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 21)
        Me.TextBox4.TabIndex = 19
        '
        'taWerbemassnahme
        '
        Me.taWerbemassnahme.ClearBeforeFill = True
        '
        'taListbox
        '
        Me.taListbox.ClearBeforeFill = True
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(833, 45)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 21
        Me.PictureBox10.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(833, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'GroupBox6Kalender
        '
        Me.GroupBox6Kalender.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox6Kalender.Controls.Add(Me.Button5Zurueck)
        Me.GroupBox6Kalender.Controls.Add(Me.Button7Speichern)
        Me.GroupBox6Kalender.Location = New System.Drawing.Point(1133, 281)
        Me.GroupBox6Kalender.Name = "GroupBox6Kalender"
        Me.GroupBox6Kalender.Size = New System.Drawing.Size(227, 219)
        Me.GroupBox6Kalender.TabIndex = 89
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
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Betrifft", True))
        Me.TextBox5.Location = New System.Drawing.Point(1133, 114)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(65, 21)
        Me.TextBox5.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Werbekosten"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsWerbemassnahme, "Werbekosten", True))
        Me.TextBox6.Location = New System.Drawing.Point(153, 133)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(175, 21)
        Me.TextBox6.TabIndex = 92
        '
        'BtAktionDruck
        '
        Me.BtAktionDruck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAktionDruck.Location = New System.Drawing.Point(33, 505)
        Me.BtAktionDruck.Name = "BtAktionDruck"
        Me.BtAktionDruck.Size = New System.Drawing.Size(143, 40)
        Me.BtAktionDruck.TabIndex = 93
        Me.BtAktionDruck.Text = "Aktion Übersicht"
        Me.BtAktionDruck.UseVisualStyleBackColor = True
        '
        'Werbung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 562)
        Me.Controls.Add(Me.GroupBox6Kalender)
        Me.Controls.Add(Me.BtAktionDruck)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Werbung"
        Me.Text = "Werbung"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWerbemassnahme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6Kalender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsWerbemassnahme As System.Windows.Forms.BindingSource
    Friend WithEvents taWerbemassnahme As WindowsApplication1.dsAusbildungTableAdapters.WerbemassnahmeTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsListbox As System.Windows.Forms.BindingSource
    Friend WithEvents taListbox As WindowsApplication1.dsAusbildungTableAdapters.ListboxTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feld28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6Kalender As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button5Zurueck As System.Windows.Forms.Button
    Friend WithEvents Button7Speichern As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents BtAktionDruck As System.Windows.Forms.Button
    Friend WithEvents KursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBeginnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WerbeartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WerbeortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WerbedatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Werbekosten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
