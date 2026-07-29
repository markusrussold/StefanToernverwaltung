<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Charter))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.bsCharter = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.CharterfirmaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLZDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBAuftrittDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnsprechspersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SpeichernButton = New System.Windows.Forms.Button()
        Me.FormularloeschenButton = New System.Windows.Forms.Button()
        Me.LoeschenButton = New System.Windows.Forms.Button()
        Me.taCharter = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CharterTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
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
        Me.CharterfirmaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrosssegelartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaujahrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgenturDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrasseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnsprechspartnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAgentur = New System.Windows.Forms.BindingSource(Me.components)
        Me.taAgentur = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.AgenturTableAdapter()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bsPostleitzahlen = New System.Windows.Forms.BindingSource(Me.components)
        Me.taPostleitzahlen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.PostleitzahlenTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCharter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAgentur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPostleitzahlen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Charteradresse"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(103, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(96, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "R1", True))
        Me.TextBox13.Location = New System.Drawing.Point(150, 217)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(184, 22)
        Me.TextBox13.TabIndex = 28
        '
        'bsCharter
        '
        Me.bsCharter.DataMember = "Charter"
        Me.bsCharter.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 16)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Bankverbindung"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(439, 187)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 24)
        Me.ComboBox1.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(343, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Agentur"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Handy", True))
        Me.TextBox7.Location = New System.Drawing.Point(440, 68)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(144, 22)
        Me.TextBox7.TabIndex = 23
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "WEBAuftritt", True))
        Me.TextBox9.Location = New System.Drawing.Point(439, 158)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(144, 22)
        Me.TextBox9.TabIndex = 21
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "email", True))
        Me.TextBox10.Location = New System.Drawing.Point(439, 127)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(144, 22)
        Me.TextBox10.TabIndex = 20
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Fax", True))
        Me.TextBox11.Location = New System.Drawing.Point(439, 97)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(144, 22)
        Me.TextBox11.TabIndex = 19
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Telefon", True))
        Me.TextBox12.Location = New System.Drawing.Point(440, 37)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(144, 22)
        Me.TextBox12.TabIndex = 18
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Ansprechsperson", True))
        Me.TextBox6.Location = New System.Drawing.Point(150, 187)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(184, 22)
        Me.TextBox6.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Land", True))
        Me.TextBox5.Location = New System.Drawing.Point(150, 157)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(186, 22)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Ort", True))
        Me.TextBox4.Location = New System.Drawing.Point(150, 127)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 22)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "PLZ", True))
        Me.TextBox3.Location = New System.Drawing.Point(150, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 22)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Straße", True))
        Me.TextBox2.Location = New System.Drawing.Point(150, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(185, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Charterfirma", True))
        Me.TextBox1.Location = New System.Drawing.Point(150, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 22)
        Me.TextBox1.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Kontaktperson"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(343, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "WEB Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(343, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "e-mail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fax"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Mobile"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Telefon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Land"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Plz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Straße"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Charterfirma"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 171)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CharterfirmaDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PLZDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.LandDataGridViewTextBoxColumn, Me.TelefonDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.WEBAuftrittDataGridViewTextBoxColumn, Me.MarinaDataGridViewTextBoxColumn, Me.AnsprechspersonDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsCharter
        Me.DataGridView1.Location = New System.Drawing.Point(134, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(612, 144)
        Me.DataGridView1.TabIndex = 1
        '
        'CharterfirmaDataGridViewTextBoxColumn
        '
        Me.CharterfirmaDataGridViewTextBoxColumn.DataPropertyName = "Charterfirma"
        Me.CharterfirmaDataGridViewTextBoxColumn.HeaderText = "Charterfirma"
        Me.CharterfirmaDataGridViewTextBoxColumn.Name = "CharterfirmaDataGridViewTextBoxColumn"
        Me.CharterfirmaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StraßeDataGridViewTextBoxColumn
        '
        Me.StraßeDataGridViewTextBoxColumn.DataPropertyName = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.HeaderText = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.Name = "StraßeDataGridViewTextBoxColumn"
        Me.StraßeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PLZDataGridViewTextBoxColumn
        '
        Me.PLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ"
        Me.PLZDataGridViewTextBoxColumn.HeaderText = "PLZ"
        Me.PLZDataGridViewTextBoxColumn.Name = "PLZDataGridViewTextBoxColumn"
        Me.PLZDataGridViewTextBoxColumn.ReadOnly = True
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
        'TelefonDataGridViewTextBoxColumn
        '
        Me.TelefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon"
        Me.TelefonDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.TelefonDataGridViewTextBoxColumn.Name = "TelefonDataGridViewTextBoxColumn"
        Me.TelefonDataGridViewTextBoxColumn.ReadOnly = True
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
        'WEBAuftrittDataGridViewTextBoxColumn
        '
        Me.WEBAuftrittDataGridViewTextBoxColumn.DataPropertyName = "WEBAuftritt"
        Me.WEBAuftrittDataGridViewTextBoxColumn.HeaderText = "WEBAuftritt"
        Me.WEBAuftrittDataGridViewTextBoxColumn.Name = "WEBAuftrittDataGridViewTextBoxColumn"
        Me.WEBAuftrittDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarinaDataGridViewTextBoxColumn
        '
        Me.MarinaDataGridViewTextBoxColumn.DataPropertyName = "Marina"
        Me.MarinaDataGridViewTextBoxColumn.HeaderText = "Marina"
        Me.MarinaDataGridViewTextBoxColumn.Name = "MarinaDataGridViewTextBoxColumn"
        Me.MarinaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnsprechspersonDataGridViewTextBoxColumn
        '
        Me.AnsprechspersonDataGridViewTextBoxColumn.DataPropertyName = "Ansprechsperson"
        Me.AnsprechspersonDataGridViewTextBoxColumn.HeaderText = "Ansprechsperson"
        Me.AnsprechspersonDataGridViewTextBoxColumn.Name = "AnsprechspersonDataGridViewTextBoxColumn"
        Me.AnsprechspersonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 21)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(569, 135)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'SpeichernButton
        '
        Me.SpeichernButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeichernButton.Location = New System.Drawing.Point(449, 503)
        Me.SpeichernButton.Name = "SpeichernButton"
        Me.SpeichernButton.Size = New System.Drawing.Size(162, 40)
        Me.SpeichernButton.TabIndex = 3
        Me.SpeichernButton.Text = "Speichern"
        Me.SpeichernButton.UseVisualStyleBackColor = True
        '
        'FormularloeschenButton
        '
        Me.FormularloeschenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormularloeschenButton.Location = New System.Drawing.Point(228, 503)
        Me.FormularloeschenButton.Name = "FormularloeschenButton"
        Me.FormularloeschenButton.Size = New System.Drawing.Size(157, 40)
        Me.FormularloeschenButton.TabIndex = 4
        Me.FormularloeschenButton.Text = "Formular leeren"
        Me.FormularloeschenButton.UseVisualStyleBackColor = True
        '
        'LoeschenButton
        '
        Me.LoeschenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoeschenButton.Location = New System.Drawing.Point(16, 503)
        Me.LoeschenButton.Name = "LoeschenButton"
        Me.LoeschenButton.Size = New System.Drawing.Size(172, 40)
        Me.LoeschenButton.TabIndex = 5
        Me.LoeschenButton.Text = "Firma löschen"
        Me.LoeschenButton.UseVisualStyleBackColor = True
        '
        'taCharter
        '
        Me.taCharter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BootnameDataGridViewTextBoxColumn, Me.MarkeDataGridViewTextBoxColumn, Me.SchiffstypDataGridViewTextBoxColumn, Me.KielartDataGridViewTextBoxColumn, Me.SchiffsnummerDataGridViewTextBoxColumn, Me.DurchfahrtshoeheDataGridViewTextBoxColumn, Me.LängeDataGridViewTextBoxColumn, Me.BreiteDataGridViewTextBoxColumn, Me.VerdrängungDataGridViewTextBoxColumn, Me.TiefgangDataGridViewTextBoxColumn, Me.GroßsegelDataGridViewTextBoxColumn, Me.VorsegelDataGridViewTextBoxColumn, Me.WassertankDataGridViewTextBoxColumn, Me.DieseltankDataGridViewTextBoxColumn, Me.StarterbatterieDataGridViewTextBoxColumn, Me.ServicebatterieDataGridViewTextBoxColumn, Me.KabinenanzahlDataGridViewTextBoxColumn, Me.KojenanzahlDataGridViewTextBoxColumn, Me.NassraeumeanzahlDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.KautionDataGridViewTextBoxColumn, Me.BildDataGridViewTextBoxColumn, Me.CharterfirmaDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.TestDataGridViewTextBoxColumn, Me.GrosssegelartDataGridViewTextBoxColumn, Me.BaujahrDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsBoot
        Me.DataGridView2.Location = New System.Drawing.Point(1052, 179)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 6
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
        'taBoot
        '
        Me.taBoot.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(617, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 522)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Boote"
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(171, 472)
        Me.ListBox1.TabIndex = 8
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.AgenturDataGridViewTextBoxColumn, Me.StrasseDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn1, Me.LandDataGridViewTextBoxColumn1, Me.OrtDataGridViewTextBoxColumn1, Me.TelDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn1, Me.EmailDataGridViewTextBoxColumn1, Me.WEBDataGridViewTextBoxColumn, Me.AnsprechspartnerDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.FaxDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsAgentur
        Me.DataGridView3.Location = New System.Drawing.Point(1052, 337)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView3.TabIndex = 9
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'AgenturDataGridViewTextBoxColumn
        '
        Me.AgenturDataGridViewTextBoxColumn.DataPropertyName = "Agentur"
        Me.AgenturDataGridViewTextBoxColumn.HeaderText = "Agentur"
        Me.AgenturDataGridViewTextBoxColumn.Name = "AgenturDataGridViewTextBoxColumn"
        '
        'StrasseDataGridViewTextBoxColumn
        '
        Me.StrasseDataGridViewTextBoxColumn.DataPropertyName = "Strasse"
        Me.StrasseDataGridViewTextBoxColumn.HeaderText = "Strasse"
        Me.StrasseDataGridViewTextBoxColumn.Name = "StrasseDataGridViewTextBoxColumn"
        '
        'PlzDataGridViewTextBoxColumn1
        '
        Me.PlzDataGridViewTextBoxColumn1.DataPropertyName = "Plz"
        Me.PlzDataGridViewTextBoxColumn1.HeaderText = "Plz"
        Me.PlzDataGridViewTextBoxColumn1.Name = "PlzDataGridViewTextBoxColumn1"
        '
        'LandDataGridViewTextBoxColumn1
        '
        Me.LandDataGridViewTextBoxColumn1.DataPropertyName = "Land"
        Me.LandDataGridViewTextBoxColumn1.HeaderText = "Land"
        Me.LandDataGridViewTextBoxColumn1.Name = "LandDataGridViewTextBoxColumn1"
        '
        'OrtDataGridViewTextBoxColumn1
        '
        Me.OrtDataGridViewTextBoxColumn1.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.Name = "OrtDataGridViewTextBoxColumn1"
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        '
        'HandyDataGridViewTextBoxColumn1
        '
        Me.HandyDataGridViewTextBoxColumn1.DataPropertyName = "Handy"
        Me.HandyDataGridViewTextBoxColumn1.HeaderText = "Handy"
        Me.HandyDataGridViewTextBoxColumn1.Name = "HandyDataGridViewTextBoxColumn1"
        '
        'EmailDataGridViewTextBoxColumn1
        '
        Me.EmailDataGridViewTextBoxColumn1.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn1.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn1.Name = "EmailDataGridViewTextBoxColumn1"
        '
        'WEBDataGridViewTextBoxColumn
        '
        Me.WEBDataGridViewTextBoxColumn.DataPropertyName = "WEB"
        Me.WEBDataGridViewTextBoxColumn.HeaderText = "WEB"
        Me.WEBDataGridViewTextBoxColumn.Name = "WEBDataGridViewTextBoxColumn"
        '
        'AnsprechspartnerDataGridViewTextBoxColumn
        '
        Me.AnsprechspartnerDataGridViewTextBoxColumn.DataPropertyName = "Ansprechspartner"
        Me.AnsprechspartnerDataGridViewTextBoxColumn.HeaderText = "Ansprechspartner"
        Me.AnsprechspartnerDataGridViewTextBoxColumn.Name = "AnsprechspartnerDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bemerkung"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bemerkung"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        '
        'bsAgentur
        '
        Me.bsAgentur.DataMember = "Agentur"
        Me.bsAgentur.DataSource = Me.dsToernverwaltung
        '
        'taAgentur
        '
        Me.taAgentur.ClearBeforeFill = True
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCharter, "Agentur", True))
        Me.TextBox8.Location = New System.Drawing.Point(1069, 513)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 478)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 12
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.ListBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(804, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(180, 522)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Törn"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(7, 24)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(167, 472)
        Me.ListBox2.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 499)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Doppelklick auf Törn --> Törn"
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.TornberichtDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.DataGridViewTextBoxColumn3, Me.BordkassaDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.LogbuchDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn, Me.Nachtfahrtvon1DataGridViewTextBoxColumn, Me.Nachtfahrtbis1DataGridViewTextBoxColumn, Me.Sm1DataGridViewTextBoxColumn, Me.NachtfDatumvon1DataGridViewTextBoxColumn, Me.NachtZeitvon1DataGridViewTextBoxColumn, Me.NachtfDatumbis1DataGridViewTextBoxColumn, Me.NachtZeitbis1DataGridViewTextBoxColumn, Me.NachtFahrtvon2DataGridViewTextBoxColumn, Me.NachtFahrtbis2DataGridViewTextBoxColumn, Me.SM2DataGridViewTextBoxColumn, Me.NachtDatumvon2DataGridViewTextBoxColumn, Me.NachtZeitvon2DataGridViewTextBoxColumn, Me.NachtDatumbis2DataGridViewTextBoxColumn, Me.NachtZeitbis2DataGridViewTextBoxColumn, Me.Std50StartDataGridViewTextBoxColumn, Me.Std50ZielDataGridViewTextBoxColumn, Me.Std50SmGesDataGridViewTextBoxColumn, Me.Std50smFB2DataGridViewTextBoxColumn, Me.Std50DatumStartDataGridViewTextBoxColumn, Me.Std50ZeitStartDataGridViewTextBoxColumn, Me.Std50DatumZielDataGridViewTextBoxColumn, Me.Std50ZeitZielDataGridViewTextBoxColumn, Me.GezHafen1DataGridViewTextBoxColumn, Me.GezDatum1DataGridViewTextBoxColumn, Me.GezZeit1DataGridViewTextBoxColumn, Me.GezHafen2DataGridViewTextBoxColumn, Me.GezDatum2DataGridViewTextBoxColumn, Me.GezZeit2DataGridViewTextBoxColumn, Me.FB4StartDataGridViewTextBoxColumn, Me.FB4ZielDataGridViewTextBoxColumn, Me.FB4SmGesDataGridViewTextBoxColumn, Me.FB4SmFb3DataGridViewTextBoxColumn, Me.FB4DatumStartDataGridViewTextBoxColumn, Me.FB4ZeitStartDataGridViewTextBoxColumn, Me.FB4DatumZielDataGridViewTextBoxColumn, Me.FB4ZeitZielDataGridViewTextBoxColumn, Me.RevierDataGridViewTextBoxColumn, Me.VerbrauchproToernDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.bsToernname
        Me.DataGridView5.Location = New System.Drawing.Point(1052, 12)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView5.TabIndex = 14
        '
        'bsToernname
        '
        Me.bsToernname.DataMember = "Toernname"
        Me.bsToernname.DataSource = Me.dsToernverwaltung
        '
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bemerkung"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bemerkung"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        'Charter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 555)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.LoeschenButton)
        Me.Controls.Add(Me.FormularloeschenButton)
        Me.Controls.Add(Me.SpeichernButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Charter"
        Me.Text = "Charterbasis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCharter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAgentur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPostleitzahlen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents SpeichernButton As System.Windows.Forms.Button
    Friend WithEvents FormularloeschenButton As System.Windows.Forms.Button
    Friend WithEvents LoeschenButton As System.Windows.Forms.Button
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsCharter As System.Windows.Forms.BindingSource
    Friend WithEvents taCharter As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CharterTableAdapter
    Friend WithEvents CharterfirmaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLZDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEBAuftrittDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnsprechspersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
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
    Friend WithEvents CharterfirmaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrosssegelartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaujahrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents bsAgentur As System.Windows.Forms.BindingSource
    Friend WithEvents taAgentur As WindowsApplication1.ToernverwaltungDataSetTableAdapters.AgenturTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenturDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StrasseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnsprechspartnerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bsPostleitzahlen As System.Windows.Forms.BindingSource
    Friend WithEvents taPostleitzahlen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.PostleitzahlenTableAdapter
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
