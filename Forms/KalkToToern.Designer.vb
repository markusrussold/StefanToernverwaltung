<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KalkToToern
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KalkToToern))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.bsToernKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Route = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Skipper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinFlugNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinFlugDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RueFlugNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RueFlugDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlugpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutoanreisekostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinaanfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Endreinigung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aussenborder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinarueckfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EinkaufstaxiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharterkostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnfallversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KautionsversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RücktrittsversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreibstoffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunkernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandmahlzeitenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinakostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrewanzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeihwagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperVersicherungDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SkipperBordkassaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FlughafenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonstigekostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrewanteilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AussenborderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndreinigungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperverdienstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernanfangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernendeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taToernKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.BootsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LetzterSegeltagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BordkassaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsBootKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmNachweisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WachfuehrerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NavigatorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RudergaengerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.taBootKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootKalkulationTableAdapter()
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.Kopieren = New System.Windows.Forms.Button()
        Me.Leeren = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBootKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.RichTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(725, 172)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Törnkalkulation"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Boot", True))
        Me.TextBox3.Location = New System.Drawing.Point(534, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 22)
        Me.TextBox3.TabIndex = 90
        '
        'bsToernKalkulation
        '
        Me.bsToernKalkulation.DataMember = "ToernKalkulation"
        Me.bsToernKalkulation.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Skipper", True))
        Me.TextBox1.Location = New System.Drawing.Point(205, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 22)
        Me.TextBox1.TabIndex = 89
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(137, 87)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(55, 16)
        Me.Label52.TabIndex = 88
        Me.Label52.Text = "Skipper"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Route", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(205, 122)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(489, 36)
        Me.RichTextBox2.TabIndex = 85
        Me.RichTextBox2.Text = ""
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(152, 124)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(44, 16)
        Me.Label51.TabIndex = 86
        Me.Label51.Text = "Route"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toernende", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(533, 57)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox4.TabIndex = 4
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toernanfang", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(205, 55)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(101, 22)
        Me.MaskedTextBox3.TabIndex = 3
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(491, 61)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(26, 16)
        Me.Label49.TabIndex = 80
        Me.Label49.Text = "bis"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(169, 61)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(30, 16)
        Me.Label48.TabIndex = 79
        Me.Label48.Text = "von"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toern", True))
        Me.TextBox2.Location = New System.Drawing.Point(205, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(250, 22)
        Me.TextBox2.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(33, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(127, 16)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Törnbezeichnung"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(491, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 16)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "Boot"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(725, 198)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kalkulierte Törns"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernDataGridViewTextBoxColumn, Me.Route, Me.Skipper, Me.HinFlugNrDataGridViewTextBoxColumn, Me.HinFlugDatumDataGridViewTextBoxColumn, Me.RueFlugNrDataGridViewTextBoxColumn, Me.RueFlugDatumDataGridViewTextBoxColumn, Me.FlugpreisDataGridViewTextBoxColumn, Me.AutoanreisekostenDataGridViewTextBoxColumn, Me.MarinaanfahrtDataGridViewTextBoxColumn, Me.Endreinigung, Me.Rabatt1, Me.Rabatt2, Me.Aussenborder, Me.MarinarueckfahrtDataGridViewTextBoxColumn, Me.EinkaufstaxiDataGridViewTextBoxColumn, Me.CharterkostenDataGridViewTextBoxColumn, Me.HaftpflichtversicherungDataGridViewTextBoxColumn, Me.UnfallversicherungDataGridViewTextBoxColumn, Me.RechtsschutzversicherungDataGridViewTextBoxColumn, Me.BeschlagnahmerisikoDataGridViewTextBoxColumn, Me.KautionsversicherungDataGridViewTextBoxColumn, Me.RücktrittsversicherungDataGridViewTextBoxColumn, Me.ID, Me.TreibstoffDataGridViewTextBoxColumn, Me.BunkernDataGridViewTextBoxColumn, Me.LandmahlzeitenDataGridViewTextBoxColumn, Me.MarinakostenDataGridViewTextBoxColumn, Me.CrewanzahlDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.LeihwagenDataGridViewTextBoxColumn, Me.SkipperVersicherungDataGridViewCheckBoxColumn, Me.SkipperCharterkostenDataGridViewCheckBoxColumn, Me.SkipperBordkassaDataGridViewCheckBoxColumn, Me.FlughafenDataGridViewTextBoxColumn, Me.SonstigekostenDataGridViewTextBoxColumn, Me.BootDataGridViewTextBoxColumn, Me.CrewanteilDataGridViewTextBoxColumn, Me.AussenborderDataGridViewTextBoxColumn, Me.EndreinigungDataGridViewTextBoxColumn, Me.Rabatt1DataGridViewTextBoxColumn, Me.Rabatt2DataGridViewTextBoxColumn, Me.PermitDataGridViewTextBoxColumn, Me.SkipperverdienstDataGridViewTextBoxColumn, Me.ToernanfangDataGridViewTextBoxColumn, Me.ToernendeDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsToernKalkulation
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(719, 177)
        Me.DataGridView1.TabIndex = 1
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
        Me.ToernDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Route
        '
        Me.Route.DataPropertyName = "Route"
        Me.Route.HeaderText = "Route"
        Me.Route.Name = "Route"
        Me.Route.ReadOnly = True
        Me.Route.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Route.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Skipper
        '
        Me.Skipper.DataPropertyName = "Skipper"
        Me.Skipper.HeaderText = "Skipper"
        Me.Skipper.Name = "Skipper"
        Me.Skipper.ReadOnly = True
        '
        'HinFlugNrDataGridViewTextBoxColumn
        '
        Me.HinFlugNrDataGridViewTextBoxColumn.DataPropertyName = "HinFlugNr"
        Me.HinFlugNrDataGridViewTextBoxColumn.HeaderText = "HinFlugNr"
        Me.HinFlugNrDataGridViewTextBoxColumn.Name = "HinFlugNrDataGridViewTextBoxColumn"
        Me.HinFlugNrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HinFlugDatumDataGridViewTextBoxColumn
        '
        Me.HinFlugDatumDataGridViewTextBoxColumn.DataPropertyName = "HinFlugDatum"
        Me.HinFlugDatumDataGridViewTextBoxColumn.HeaderText = "HinFlugDatum"
        Me.HinFlugDatumDataGridViewTextBoxColumn.Name = "HinFlugDatumDataGridViewTextBoxColumn"
        Me.HinFlugDatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RueFlugNrDataGridViewTextBoxColumn
        '
        Me.RueFlugNrDataGridViewTextBoxColumn.DataPropertyName = "RueFlugNr"
        Me.RueFlugNrDataGridViewTextBoxColumn.HeaderText = "RueFlugNr"
        Me.RueFlugNrDataGridViewTextBoxColumn.Name = "RueFlugNrDataGridViewTextBoxColumn"
        Me.RueFlugNrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RueFlugDatumDataGridViewTextBoxColumn
        '
        Me.RueFlugDatumDataGridViewTextBoxColumn.DataPropertyName = "RueFlugDatum"
        Me.RueFlugDatumDataGridViewTextBoxColumn.HeaderText = "RueFlugDatum"
        Me.RueFlugDatumDataGridViewTextBoxColumn.Name = "RueFlugDatumDataGridViewTextBoxColumn"
        Me.RueFlugDatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FlugpreisDataGridViewTextBoxColumn
        '
        Me.FlugpreisDataGridViewTextBoxColumn.DataPropertyName = "Flugpreis"
        Me.FlugpreisDataGridViewTextBoxColumn.HeaderText = "Flugpreis"
        Me.FlugpreisDataGridViewTextBoxColumn.Name = "FlugpreisDataGridViewTextBoxColumn"
        Me.FlugpreisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutoanreisekostenDataGridViewTextBoxColumn
        '
        Me.AutoanreisekostenDataGridViewTextBoxColumn.DataPropertyName = "Autoanreisekosten"
        Me.AutoanreisekostenDataGridViewTextBoxColumn.HeaderText = "Autoanreisekosten"
        Me.AutoanreisekostenDataGridViewTextBoxColumn.Name = "AutoanreisekostenDataGridViewTextBoxColumn"
        Me.AutoanreisekostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarinaanfahrtDataGridViewTextBoxColumn
        '
        Me.MarinaanfahrtDataGridViewTextBoxColumn.DataPropertyName = "Marinaanfahrt"
        Me.MarinaanfahrtDataGridViewTextBoxColumn.HeaderText = "Marinaanfahrt"
        Me.MarinaanfahrtDataGridViewTextBoxColumn.Name = "MarinaanfahrtDataGridViewTextBoxColumn"
        Me.MarinaanfahrtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Endreinigung
        '
        Me.Endreinigung.DataPropertyName = "Endreinigung"
        Me.Endreinigung.HeaderText = "Endreinigung"
        Me.Endreinigung.Name = "Endreinigung"
        Me.Endreinigung.ReadOnly = True
        '
        'Rabatt1
        '
        Me.Rabatt1.DataPropertyName = "Rabatt1"
        Me.Rabatt1.HeaderText = "Rabatt1"
        Me.Rabatt1.Name = "Rabatt1"
        Me.Rabatt1.ReadOnly = True
        '
        'Rabatt2
        '
        Me.Rabatt2.DataPropertyName = "Rabatt2"
        Me.Rabatt2.HeaderText = "Rabatt2"
        Me.Rabatt2.Name = "Rabatt2"
        Me.Rabatt2.ReadOnly = True
        '
        'Aussenborder
        '
        Me.Aussenborder.DataPropertyName = "Aussenborder"
        Me.Aussenborder.HeaderText = "Aussenborder"
        Me.Aussenborder.Name = "Aussenborder"
        Me.Aussenborder.ReadOnly = True
        '
        'MarinarueckfahrtDataGridViewTextBoxColumn
        '
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.DataPropertyName = "Marinarueckfahrt"
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.HeaderText = "Marinarueckfahrt"
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.Name = "MarinarueckfahrtDataGridViewTextBoxColumn"
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EinkaufstaxiDataGridViewTextBoxColumn
        '
        Me.EinkaufstaxiDataGridViewTextBoxColumn.DataPropertyName = "Einkaufstaxi"
        Me.EinkaufstaxiDataGridViewTextBoxColumn.HeaderText = "Einkaufstaxi"
        Me.EinkaufstaxiDataGridViewTextBoxColumn.Name = "EinkaufstaxiDataGridViewTextBoxColumn"
        Me.EinkaufstaxiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CharterkostenDataGridViewTextBoxColumn
        '
        Me.CharterkostenDataGridViewTextBoxColumn.DataPropertyName = "Charterkosten"
        Me.CharterkostenDataGridViewTextBoxColumn.HeaderText = "Charterkosten"
        Me.CharterkostenDataGridViewTextBoxColumn.Name = "CharterkostenDataGridViewTextBoxColumn"
        Me.CharterkostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HaftpflichtversicherungDataGridViewTextBoxColumn
        '
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.DataPropertyName = "Haftpflichtversicherung"
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.HeaderText = "Haftpflichtversicherung"
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.Name = "HaftpflichtversicherungDataGridViewTextBoxColumn"
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnfallversicherungDataGridViewTextBoxColumn
        '
        Me.UnfallversicherungDataGridViewTextBoxColumn.DataPropertyName = "Unfallversicherung"
        Me.UnfallversicherungDataGridViewTextBoxColumn.HeaderText = "Unfallversicherung"
        Me.UnfallversicherungDataGridViewTextBoxColumn.Name = "UnfallversicherungDataGridViewTextBoxColumn"
        Me.UnfallversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RechtsschutzversicherungDataGridViewTextBoxColumn
        '
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.DataPropertyName = "Rechtsschutzversicherung"
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.HeaderText = "Rechtsschutzversicherung"
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.Name = "RechtsschutzversicherungDataGridViewTextBoxColumn"
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BeschlagnahmerisikoDataGridViewTextBoxColumn
        '
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.DataPropertyName = "Beschlagnahmerisiko"
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.HeaderText = "Beschlagnahmerisiko"
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.Name = "BeschlagnahmerisikoDataGridViewTextBoxColumn"
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KautionsversicherungDataGridViewTextBoxColumn
        '
        Me.KautionsversicherungDataGridViewTextBoxColumn.DataPropertyName = "Kautionsversicherung"
        Me.KautionsversicherungDataGridViewTextBoxColumn.HeaderText = "Kautionsversicherung"
        Me.KautionsversicherungDataGridViewTextBoxColumn.Name = "KautionsversicherungDataGridViewTextBoxColumn"
        Me.KautionsversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RücktrittsversicherungDataGridViewTextBoxColumn
        '
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.DataPropertyName = "Rücktrittsversicherung"
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.HeaderText = "Rücktrittsversicherung"
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.Name = "RücktrittsversicherungDataGridViewTextBoxColumn"
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'TreibstoffDataGridViewTextBoxColumn
        '
        Me.TreibstoffDataGridViewTextBoxColumn.DataPropertyName = "Treibstoff"
        Me.TreibstoffDataGridViewTextBoxColumn.HeaderText = "Treibstoff"
        Me.TreibstoffDataGridViewTextBoxColumn.Name = "TreibstoffDataGridViewTextBoxColumn"
        Me.TreibstoffDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BunkernDataGridViewTextBoxColumn
        '
        Me.BunkernDataGridViewTextBoxColumn.DataPropertyName = "Bunkern"
        Me.BunkernDataGridViewTextBoxColumn.HeaderText = "Bunkern"
        Me.BunkernDataGridViewTextBoxColumn.Name = "BunkernDataGridViewTextBoxColumn"
        Me.BunkernDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LandmahlzeitenDataGridViewTextBoxColumn
        '
        Me.LandmahlzeitenDataGridViewTextBoxColumn.DataPropertyName = "Landmahlzeiten"
        Me.LandmahlzeitenDataGridViewTextBoxColumn.HeaderText = "Landmahlzeiten"
        Me.LandmahlzeitenDataGridViewTextBoxColumn.Name = "LandmahlzeitenDataGridViewTextBoxColumn"
        Me.LandmahlzeitenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarinakostenDataGridViewTextBoxColumn
        '
        Me.MarinakostenDataGridViewTextBoxColumn.DataPropertyName = "Marinakosten"
        Me.MarinakostenDataGridViewTextBoxColumn.HeaderText = "Marinakosten"
        Me.MarinakostenDataGridViewTextBoxColumn.Name = "MarinakostenDataGridViewTextBoxColumn"
        Me.MarinakostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CrewanzahlDataGridViewTextBoxColumn
        '
        Me.CrewanzahlDataGridViewTextBoxColumn.DataPropertyName = "Crewanzahl"
        Me.CrewanzahlDataGridViewTextBoxColumn.HeaderText = "Crewanzahl"
        Me.CrewanzahlDataGridViewTextBoxColumn.Name = "CrewanzahlDataGridViewTextBoxColumn"
        Me.CrewanzahlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        Me.BemerkungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeihwagenDataGridViewTextBoxColumn
        '
        Me.LeihwagenDataGridViewTextBoxColumn.DataPropertyName = "Leihwagen"
        Me.LeihwagenDataGridViewTextBoxColumn.HeaderText = "Leihwagen"
        Me.LeihwagenDataGridViewTextBoxColumn.Name = "LeihwagenDataGridViewTextBoxColumn"
        Me.LeihwagenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SkipperVersicherungDataGridViewCheckBoxColumn
        '
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.DataPropertyName = "SkipperVersicherung"
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.HeaderText = "SkipperVersicherung"
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.Name = "SkipperVersicherungDataGridViewCheckBoxColumn"
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SkipperCharterkostenDataGridViewCheckBoxColumn
        '
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.DataPropertyName = "SkipperCharterkosten"
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.HeaderText = "SkipperCharterkosten"
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.Name = "SkipperCharterkostenDataGridViewCheckBoxColumn"
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SkipperBordkassaDataGridViewCheckBoxColumn
        '
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.DataPropertyName = "SkipperBordkassa"
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.HeaderText = "SkipperBordkassa"
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.Name = "SkipperBordkassaDataGridViewCheckBoxColumn"
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FlughafenDataGridViewTextBoxColumn
        '
        Me.FlughafenDataGridViewTextBoxColumn.DataPropertyName = "Flughafen"
        Me.FlughafenDataGridViewTextBoxColumn.HeaderText = "Flughafen"
        Me.FlughafenDataGridViewTextBoxColumn.Name = "FlughafenDataGridViewTextBoxColumn"
        Me.FlughafenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SonstigekostenDataGridViewTextBoxColumn
        '
        Me.SonstigekostenDataGridViewTextBoxColumn.DataPropertyName = "Sonstigekosten"
        Me.SonstigekostenDataGridViewTextBoxColumn.HeaderText = "Sonstigekosten"
        Me.SonstigekostenDataGridViewTextBoxColumn.Name = "SonstigekostenDataGridViewTextBoxColumn"
        Me.SonstigekostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BootDataGridViewTextBoxColumn
        '
        Me.BootDataGridViewTextBoxColumn.DataPropertyName = "Boot"
        Me.BootDataGridViewTextBoxColumn.HeaderText = "Boot"
        Me.BootDataGridViewTextBoxColumn.Name = "BootDataGridViewTextBoxColumn"
        Me.BootDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CrewanteilDataGridViewTextBoxColumn
        '
        Me.CrewanteilDataGridViewTextBoxColumn.DataPropertyName = "Crewanteil"
        Me.CrewanteilDataGridViewTextBoxColumn.HeaderText = "Crewanteil"
        Me.CrewanteilDataGridViewTextBoxColumn.Name = "CrewanteilDataGridViewTextBoxColumn"
        Me.CrewanteilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AussenborderDataGridViewTextBoxColumn
        '
        Me.AussenborderDataGridViewTextBoxColumn.DataPropertyName = "Aussenborder"
        Me.AussenborderDataGridViewTextBoxColumn.HeaderText = "Aussenborder"
        Me.AussenborderDataGridViewTextBoxColumn.Name = "AussenborderDataGridViewTextBoxColumn"
        Me.AussenborderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndreinigungDataGridViewTextBoxColumn
        '
        Me.EndreinigungDataGridViewTextBoxColumn.DataPropertyName = "Endreinigung"
        Me.EndreinigungDataGridViewTextBoxColumn.HeaderText = "Endreinigung"
        Me.EndreinigungDataGridViewTextBoxColumn.Name = "EndreinigungDataGridViewTextBoxColumn"
        Me.EndreinigungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Rabatt1DataGridViewTextBoxColumn
        '
        Me.Rabatt1DataGridViewTextBoxColumn.DataPropertyName = "Rabatt1"
        Me.Rabatt1DataGridViewTextBoxColumn.HeaderText = "Rabatt1"
        Me.Rabatt1DataGridViewTextBoxColumn.Name = "Rabatt1DataGridViewTextBoxColumn"
        Me.Rabatt1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Rabatt2DataGridViewTextBoxColumn
        '
        Me.Rabatt2DataGridViewTextBoxColumn.DataPropertyName = "Rabatt2"
        Me.Rabatt2DataGridViewTextBoxColumn.HeaderText = "Rabatt2"
        Me.Rabatt2DataGridViewTextBoxColumn.Name = "Rabatt2DataGridViewTextBoxColumn"
        Me.Rabatt2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PermitDataGridViewTextBoxColumn
        '
        Me.PermitDataGridViewTextBoxColumn.DataPropertyName = "Permit"
        Me.PermitDataGridViewTextBoxColumn.HeaderText = "Permit"
        Me.PermitDataGridViewTextBoxColumn.Name = "PermitDataGridViewTextBoxColumn"
        Me.PermitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SkipperverdienstDataGridViewTextBoxColumn
        '
        Me.SkipperverdienstDataGridViewTextBoxColumn.DataPropertyName = "Skipperverdienst"
        Me.SkipperverdienstDataGridViewTextBoxColumn.HeaderText = "Skipperverdienst"
        Me.SkipperverdienstDataGridViewTextBoxColumn.Name = "SkipperverdienstDataGridViewTextBoxColumn"
        Me.SkipperverdienstDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToernanfangDataGridViewTextBoxColumn
        '
        Me.ToernanfangDataGridViewTextBoxColumn.DataPropertyName = "Toernanfang"
        Me.ToernanfangDataGridViewTextBoxColumn.HeaderText = "Toernanfang"
        Me.ToernanfangDataGridViewTextBoxColumn.Name = "ToernanfangDataGridViewTextBoxColumn"
        Me.ToernanfangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToernendeDataGridViewTextBoxColumn
        '
        Me.ToernendeDataGridViewTextBoxColumn.DataPropertyName = "Toernende"
        Me.ToernendeDataGridViewTextBoxColumn.HeaderText = "Toernende"
        Me.ToernendeDataGridViewTextBoxColumn.Name = "ToernendeDataGridViewTextBoxColumn"
        Me.ToernendeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SkipperDataGridViewTextBoxColumn
        '
        Me.SkipperDataGridViewTextBoxColumn.DataPropertyName = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.HeaderText = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.Name = "SkipperDataGridViewTextBoxColumn"
        Me.SkipperDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RouteDataGridViewTextBoxColumn
        '
        Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "Route"
        Me.RouteDataGridViewTextBoxColumn.HeaderText = "Route"
        Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
        Me.RouteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 20)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(697, 137)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(725, 106)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Törnbezeichnung"
        Me.GroupBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(195, 45)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(249, 22)
        Me.TextBox4.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Neue Törnbezeichnung"
        '
        'taToernKalkulation
        '
        Me.taToernKalkulation.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn1, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.BordkassaDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.bsToernname
        Me.DataGridView2.Location = New System.Drawing.Point(813, 34)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 81)
        Me.DataGridView2.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'BootsnameDataGridViewTextBoxColumn
        '
        Me.BootsnameDataGridViewTextBoxColumn.DataPropertyName = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.HeaderText = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.Name = "BootsnameDataGridViewTextBoxColumn"
        '
        'SkipperDataGridViewTextBoxColumn1
        '
        Me.SkipperDataGridViewTextBoxColumn1.DataPropertyName = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn1.HeaderText = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn1.Name = "SkipperDataGridViewTextBoxColumn1"
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
        'BordkassaDataGridViewTextBoxColumn
        '
        Me.BordkassaDataGridViewTextBoxColumn.DataPropertyName = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.HeaderText = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.Name = "BordkassaDataGridViewTextBoxColumn"
        '
        'RouteDataGridViewTextBoxColumn1
        '
        Me.RouteDataGridViewTextBoxColumn1.DataPropertyName = "Route"
        Me.RouteDataGridViewTextBoxColumn1.HeaderText = "Route"
        Me.RouteDataGridViewTextBoxColumn1.Name = "RouteDataGridViewTextBoxColumn1"
        '
        'bsToernname
        '
        Me.bsToernname.DataMember = "Toernname"
        Me.bsToernname.DataSource = Me.dsToernverwaltung
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.ToernDataGridViewTextBoxColumn1, Me.BootDataGridViewTextBoxColumn1, Me.VZNameDataGridViewTextBoxColumn, Me.KostenDataGridViewTextBoxColumn, Me.BezahltDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsBootKalkulation
        Me.DataGridView3.Location = New System.Drawing.Point(813, 134)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(240, 81)
        Me.DataGridView3.TabIndex = 4
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'ToernDataGridViewTextBoxColumn1
        '
        Me.ToernDataGridViewTextBoxColumn1.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.Name = "ToernDataGridViewTextBoxColumn1"
        '
        'BootDataGridViewTextBoxColumn1
        '
        Me.BootDataGridViewTextBoxColumn1.DataPropertyName = "Boot"
        Me.BootDataGridViewTextBoxColumn1.HeaderText = "Boot"
        Me.BootDataGridViewTextBoxColumn1.Name = "BootDataGridViewTextBoxColumn1"
        '
        'VZNameDataGridViewTextBoxColumn
        '
        Me.VZNameDataGridViewTextBoxColumn.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.Name = "VZNameDataGridViewTextBoxColumn"
        '
        'KostenDataGridViewTextBoxColumn
        '
        Me.KostenDataGridViewTextBoxColumn.DataPropertyName = "Kosten"
        Me.KostenDataGridViewTextBoxColumn.HeaderText = "Kosten"
        Me.KostenDataGridViewTextBoxColumn.Name = "KostenDataGridViewTextBoxColumn"
        '
        'BezahltDataGridViewTextBoxColumn
        '
        Me.BezahltDataGridViewTextBoxColumn.DataPropertyName = "Bezahlt"
        Me.BezahltDataGridViewTextBoxColumn.HeaderText = "Bezahlt"
        Me.BezahltDataGridViewTextBoxColumn.Name = "BezahltDataGridViewTextBoxColumn"
        '
        'bsBootKalkulation
        '
        Me.bsBootKalkulation.DataMember = "BootKalkulation"
        Me.bsBootKalkulation.DataSource = Me.dsToernverwaltung
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.ToernDataGridViewTextBoxColumn2, Me.VZnameDataGridViewTextBoxColumn1, Me.SmNachweisDataGridViewCheckBoxColumn, Me.WachfuehrerDataGridViewCheckBoxColumn, Me.NavigatorDataGridViewCheckBoxColumn, Me.RudergaengerDataGridViewCheckBoxColumn})
        Me.DataGridView4.DataSource = Me.bsTC
        Me.DataGridView4.Location = New System.Drawing.Point(813, 228)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(240, 81)
        Me.DataGridView4.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'ToernDataGridViewTextBoxColumn2
        '
        Me.ToernDataGridViewTextBoxColumn2.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn2.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn2.Name = "ToernDataGridViewTextBoxColumn2"
        '
        'VZnameDataGridViewTextBoxColumn1
        '
        Me.VZnameDataGridViewTextBoxColumn1.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.Name = "VZnameDataGridViewTextBoxColumn1"
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
        'bsTC
        '
        Me.bsTC.DataMember = "TC"
        Me.bsTC.DataSource = Me.dsToernverwaltung
        '
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'taBootKalkulation
        '
        Me.taBootKalkulation.ClearBeforeFill = True
        '
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
        '
        'Kopieren
        '
        Me.Kopieren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kopieren.Location = New System.Drawing.Point(539, 425)
        Me.Kopieren.Name = "Kopieren"
        Me.Kopieren.Size = New System.Drawing.Size(205, 49)
        Me.Kopieren.TabIndex = 6
        Me.Kopieren.Text = "Kalkulation kopieren"
        Me.Kopieren.UseVisualStyleBackColor = True
        '
        'Leeren
        '
        Me.Leeren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leeren.Location = New System.Drawing.Point(228, 425)
        Me.Leeren.Name = "Leeren"
        Me.Leeren.Size = New System.Drawing.Size(205, 49)
        Me.Leeren.TabIndex = 7
        Me.Leeren.Text = "Formular leeren"
        Me.Leeren.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "IDToern", True))
        Me.TextBox5.Location = New System.Drawing.Point(813, 337)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "IDToern", True))
        Me.TextBox6.Location = New System.Drawing.Point(938, 337)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 10
        '
        'KalkToToern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 495)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Leeren)
        Me.Controls.Add(Me.Kopieren)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KalkToToern"
        Me.Text = "Kalkulation --> Törn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBootKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taToernKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter
    Friend WithEvents CharVerAnteilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents RevierNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetzterSegeltagDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BordkassaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsBootKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taBootKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootKalkulationTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmNachweisDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WachfuehrerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NavigatorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RudergaengerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Kopieren As System.Windows.Forms.Button
    Friend WithEvents Leeren As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Route As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Skipper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinFlugNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinFlugDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RueFlugNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RueFlugDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlugpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoanreisekostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinaanfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Endreinigung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aussenborder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinarueckfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EinkaufstaxiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharterkostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaftpflichtversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnfallversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RechtsschutzversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeschlagnahmerisikoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KautionsversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RücktrittsversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreibstoffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunkernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandmahlzeitenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinakostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrewanzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeihwagenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperVersicherungDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SkipperCharterkostenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SkipperBordkassaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FlughafenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonstigekostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrewanteilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AussenborderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndreinigungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperverdienstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernanfangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernendeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
