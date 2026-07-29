<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulationsblatt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kalkulationsblatt))
        Me.Drucken = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.bsToernKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinFlugNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinFlugDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RueFlugNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RueFlugDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlugpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutoanreisekostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinaanfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinarueckfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EinkaufstaxiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharterkostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnfallversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KautionsversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RücktrittsversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Aussenborder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Endreinigung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ToernDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsBootKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter()
        Me.taBootKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootKalkulationTableAdapter()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBootKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Drucken
        '
        Me.Drucken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Drucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drucken.Image = CType(resources.GetObject("Drucken.Image"), System.Drawing.Image)
        Me.Drucken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Drucken.Location = New System.Drawing.Point(729, 486)
        Me.Drucken.Name = "Drucken"
        Me.Drucken.Size = New System.Drawing.Size(181, 48)
        Me.Drucken.TabIndex = 77
        Me.Drucken.Text = "     Drucken"
        Me.Drucken.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 281)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kalkulation"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(218, 176)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(109, 22)
        Me.TextBox3.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Reisekosten/Crew"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Crewanteil", True))
        Me.TextBox10.Location = New System.Drawing.Point(218, 215)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(109, 22)
        Me.TextBox10.TabIndex = 91
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 218)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 16)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Gesamtkosten/Crew"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Crewanzahl", True))
        Me.TextBox6.Location = New System.Drawing.Point(218, 249)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(109, 22)
        Me.TextBox6.TabIndex = 89
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(218, 140)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(109, 22)
        Me.TextBox5.TabIndex = 88
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(218, 102)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(109, 22)
        Me.TextBox4.TabIndex = 87
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 22)
        Me.TextBox1.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 16)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Crewanzahl ohne Skipper"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Versicherungen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Bordkassa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Charterkosten"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toern", True))
        Me.TextBox2.Location = New System.Drawing.Point(218, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(250, 22)
        Me.TextBox2.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(127, 16)
        Me.Label25.TabIndex = 77
        Me.Label25.Text = "Törnbezeichnung"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(525, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 454)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Druckparameter"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(8, 384)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(185, 20)
        Me.CheckBox3.TabIndex = 81
        Me.CheckBox3.Text = "Clubrabatt auf Charterpreis"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TextBox14)
        Me.GroupBox5.Controls.Add(Me.TextBox13)
        Me.GroupBox5.Controls.Add(Me.TextBox12)
        Me.GroupBox5.Controls.Add(Me.TextBox11)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(377, 137)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Bankverbindung"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "BIC:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(247, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "BLZ:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "IBAN:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Kontonr.:"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(71, 101)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(176, 22)
        Me.TextBox14.TabIndex = 3
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(71, 61)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(176, 22)
        Me.TextBox13.TabIndex = 2
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(288, 26)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(83, 22)
        Me.TextBox12.TabIndex = 1
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(71, 26)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(176, 22)
        Me.TextBox11.TabIndex = 0
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 351)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(235, 20)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Skipper Kostenbeteiligung drucken"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(218, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 38)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "Parameter speichern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 325)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Bemerkung drucken"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 70)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Zahlungsbedingungen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(207, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Wochen vor Törnbeginn"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(164, 43)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(39, 21)
        Me.TextBox9.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(139, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(139, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "%     bei Anmeldung"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(98, 43)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(35, 21)
        Me.TextBox8.TabIndex = 3
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(98, 20)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(35, 21)
        Me.TextBox7.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Restzahlung"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Anzahlung"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.RichTextBox1)
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 308)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(482, 226)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernDataGridViewTextBoxColumn, Me.HinFlugNrDataGridViewTextBoxColumn, Me.HinFlugDatumDataGridViewTextBoxColumn, Me.RueFlugNrDataGridViewTextBoxColumn, Me.RueFlugDatumDataGridViewTextBoxColumn, Me.FlugpreisDataGridViewTextBoxColumn, Me.AutoanreisekostenDataGridViewTextBoxColumn, Me.MarinaanfahrtDataGridViewTextBoxColumn, Me.MarinarueckfahrtDataGridViewTextBoxColumn, Me.EinkaufstaxiDataGridViewTextBoxColumn, Me.CharterkostenDataGridViewTextBoxColumn, Me.HaftpflichtversicherungDataGridViewTextBoxColumn, Me.UnfallversicherungDataGridViewTextBoxColumn, Me.RechtsschutzversicherungDataGridViewTextBoxColumn, Me.BeschlagnahmerisikoDataGridViewTextBoxColumn, Me.KautionsversicherungDataGridViewTextBoxColumn, Me.RücktrittsversicherungDataGridViewTextBoxColumn, Me.TreibstoffDataGridViewTextBoxColumn, Me.BunkernDataGridViewTextBoxColumn, Me.LandmahlzeitenDataGridViewTextBoxColumn, Me.MarinakostenDataGridViewTextBoxColumn, Me.CrewanzahlDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.LeihwagenDataGridViewTextBoxColumn, Me.SkipperVersicherungDataGridViewCheckBoxColumn, Me.SkipperCharterkostenDataGridViewCheckBoxColumn, Me.SkipperBordkassaDataGridViewCheckBoxColumn, Me.FlughafenDataGridViewTextBoxColumn, Me.SonstigekostenDataGridViewTextBoxColumn, Me.BootDataGridViewTextBoxColumn, Me.CrewanteilDataGridViewTextBoxColumn, Me.Aussenborder, Me.Endreinigung, Me.Rabatt1, Me.Rabatt2, Me.Permit, Me.Column1})
        Me.DataGridView1.DataSource = Me.bsToernKalkulation
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(476, 207)
        Me.DataGridView1.TabIndex = 1
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
        Me.ToernDataGridViewTextBoxColumn.ReadOnly = True
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
        'Aussenborder
        '
        Me.Aussenborder.DataPropertyName = "Aussenborder"
        Me.Aussenborder.HeaderText = "Aussenborder"
        Me.Aussenborder.Name = "Aussenborder"
        Me.Aussenborder.ReadOnly = True
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
        'Permit
        '
        Me.Permit.DataPropertyName = "Permit"
        Me.Permit.HeaderText = "Permit"
        Me.Permit.Name = "Permit"
        Me.Permit.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(476, 204)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernDataGridViewTextBoxColumn1, Me.BootDataGridViewTextBoxColumn1, Me.VZNameDataGridViewTextBoxColumn, Me.KostenDataGridViewTextBoxColumn, Me.BezahltDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsBootKalkulation
        Me.DataGridView2.Location = New System.Drawing.Point(95, 97)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(289, 92)
        Me.DataGridView2.TabIndex = 82
        Me.DataGridView2.Visible = False
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
        'taToernKalkulation
        '
        Me.taToernKalkulation.ClearBeforeFill = True
        '
        'taBootKalkulation
        '
        Me.taBootKalkulation.ClearBeforeFill = True
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Folgeschadenversicherung", True))
        Me.TextBox15.Location = New System.Drawing.Point(1043, 38)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(101, 20)
        Me.TextBox15.TabIndex = 83
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BootnameDataGridViewTextBoxColumn, Me.MarkeDataGridViewTextBoxColumn, Me.SchiffstypDataGridViewTextBoxColumn, Me.KielartDataGridViewTextBoxColumn, Me.SchiffsnummerDataGridViewTextBoxColumn, Me.DurchfahrtshoeheDataGridViewTextBoxColumn, Me.LängeDataGridViewTextBoxColumn, Me.BreiteDataGridViewTextBoxColumn, Me.VerdrängungDataGridViewTextBoxColumn, Me.TiefgangDataGridViewTextBoxColumn, Me.GroßsegelDataGridViewTextBoxColumn, Me.VorsegelDataGridViewTextBoxColumn, Me.WassertankDataGridViewTextBoxColumn, Me.DieseltankDataGridViewTextBoxColumn, Me.StarterbatterieDataGridViewTextBoxColumn, Me.ServicebatterieDataGridViewTextBoxColumn, Me.KabinenanzahlDataGridViewTextBoxColumn, Me.KojenanzahlDataGridViewTextBoxColumn, Me.NassraeumeanzahlDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.KautionDataGridViewTextBoxColumn, Me.BildDataGridViewTextBoxColumn, Me.CharterfirmaDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.TestDataGridViewTextBoxColumn, Me.GrosssegelartDataGridViewTextBoxColumn, Me.BaujahrDataGridViewTextBoxColumn, Me.MarinaortDataGridViewTextBoxColumn, Me.MarinaDataGridViewTextBoxColumn, Me.AnsprechspersonDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.RadarDataGridViewCheckBoxColumn, Me.BugstrahlruderDataGridViewCheckBoxColumn, Me.ClubnachlasDataGridViewCheckBoxColumn})
        Me.DataGridView3.DataSource = Me.bsBoot
        Me.DataGridView3.Location = New System.Drawing.Point(1043, 78)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(134, 150)
        Me.DataGridView3.TabIndex = 84
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
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
        'bsBoot
        '
        Me.bsBoot.DataMember = "Boot"
        Me.bsBoot.DataSource = Me.dsToernverwaltung
        '
        'taBoot
        '
        Me.taBoot.ClearBeforeFill = True
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toernanfang", True))
        Me.TextBox19.Location = New System.Drawing.Point(1043, 328)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 89
        '
        'Kalkulationsblatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 542)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Drucken)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kalkulationsblatt"
        Me.Text = "Kalkulationsblatt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBootKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Drucken As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taToernKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinFlugNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinFlugDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RueFlugNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RueFlugDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlugpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoanreisekostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinaanfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinarueckfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EinkaufstaxiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharterkostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaftpflichtversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnfallversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RechtsschutzversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeschlagnahmerisikoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KautionsversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RücktrittsversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents CharVerAnteilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsBootKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taBootKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootKalkulationTableAdapter
    Friend WithEvents ToernDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Aussenborder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Endreinigung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Permit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
End Class
