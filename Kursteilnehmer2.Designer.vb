<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kursteilnehmer2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kursteilnehmer2))
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.bsTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1Material = New System.Windows.Forms.Button()
        Me.Button2Bemerkung = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListenpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EinkaufspreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LieferantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsKursmaterial = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4loeschen = New System.Windows.Forms.Button()
        Me.ButtonLeeren = New System.Windows.Forms.Button()
        Me.ButtonSpeichern = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.VZName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kurs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursPreis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursBezahlt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materialpreis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialBezahlt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKBFaelligDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter()
        Me.taKursmaterial = New WindowsApplication1.dsAusbildungTableAdapters.KursmaterialTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsMaterialKurs = New System.Windows.Forms.BindingSource(Me.components)
        Me.taMaterialKurs = New WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox6Kalender = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button5Zurueck = New System.Windows.Forms.Button()
        Me.Button7Speichern = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKursmaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaterialKurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6Kalender.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.PictureBox6)
        Me.GroupBox8.Controls.Add(Me.PictureBox10)
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Controls.Add(Me.TextBox23)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox8.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox8.Controls.Add(Me.TextBox9)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.TextBox10)
        Me.GroupBox8.Controls.Add(Me.TextBox11)
        Me.GroupBox8.Controls.Add(Me.TextBox12)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.PictureBox4)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(670, 153)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Teilnehmer auswählen"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(406, 118)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 108
        Me.PictureBox6.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(83, 118)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 107
        Me.PictureBox10.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(235, 122)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 15)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "label20"
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "VZName", True))
        Me.TextBox23.Location = New System.Drawing.Point(128, 22)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(309, 21)
        Me.TextBox23.TabIndex = 1
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(356, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 15)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "am"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 15)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "fällig am"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumKursBezahlt", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(446, 119)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox2.TabIndex = 10
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumKBFaellig", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(128, 119)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox1.TabIndex = 8
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "KursPreis", True))
        Me.TextBox9.Location = New System.Drawing.Point(128, 90)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 21)
        Me.TextBox9.TabIndex = 4
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(481, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Clubmitglied"
        Me.Label11.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "KursBezahlt", True))
        Me.TextBox10.Location = New System.Drawing.Point(446, 90)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 21)
        Me.TextBox10.TabIndex = 5
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "FB", True))
        Me.TextBox11.Location = New System.Drawing.Point(444, 53)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 21)
        Me.TextBox11.TabIndex = 3
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "Kurs", True))
        Me.TextBox12.Location = New System.Drawing.Point(128, 53)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(210, 21)
        Me.TextBox12.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(356, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Bezahlt €"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Kurspreis €"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(354, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 15)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Fahrtbereich"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 15)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Kurs"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(70, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Name"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TextBox6)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(670, 116)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kursmaterial"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(83, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "am"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "fällig am"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumMatBezahlt", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(446, 80)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox4.TabIndex = 110
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "DatumMatFaellig", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(126, 80)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox3.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Summe €"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Bezahlt €"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Preisnachlass"
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
        'Button1Material
        '
        Me.Button1Material.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Material.Location = New System.Drawing.Point(277, 531)
        Me.Button1Material.Name = "Button1Material"
        Me.Button1Material.Size = New System.Drawing.Size(115, 62)
        Me.Button1Material.TabIndex = 15
        Me.Button1Material.Text = "Material suchen"
        Me.Button1Material.UseVisualStyleBackColor = True
        '
        'Button2Bemerkung
        '
        Me.Button2Bemerkung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2Bemerkung.Location = New System.Drawing.Point(140, 531)
        Me.Button2Bemerkung.Name = "Button2Bemerkung"
        Me.Button2Bemerkung.Size = New System.Drawing.Size(120, 62)
        Me.Button2Bemerkung.TabIndex = 19
        Me.Button2Bemerkung.Text = "Bemerkung"
        Me.Button2Bemerkung.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.ListBox1)
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1259, 239)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(670, 258)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Material bestellen"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(415, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(202, 15)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Doppelklick auf Position --> löschen"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(418, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(234, 199)
        Me.ListBox1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialDataGridViewTextBoxColumn, Me.ListenpreisDataGridViewTextBoxColumn, Me.EinkaufspreisDataGridViewTextBoxColumn, Me.LieferantDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.bsKursmaterial
        Me.DataGridView2.Location = New System.Drawing.Point(14, 22)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(395, 219)
        Me.DataGridView2.TabIndex = 0
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "Material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        Me.MaterialDataGridViewTextBoxColumn.Width = 250
        '
        'ListenpreisDataGridViewTextBoxColumn
        '
        Me.ListenpreisDataGridViewTextBoxColumn.DataPropertyName = "Listenpreis"
        Me.ListenpreisDataGridViewTextBoxColumn.HeaderText = "Listenpreis"
        Me.ListenpreisDataGridViewTextBoxColumn.Name = "ListenpreisDataGridViewTextBoxColumn"
        '
        'EinkaufspreisDataGridViewTextBoxColumn
        '
        Me.EinkaufspreisDataGridViewTextBoxColumn.DataPropertyName = "Einkaufspreis"
        Me.EinkaufspreisDataGridViewTextBoxColumn.HeaderText = "Einkaufspreis"
        Me.EinkaufspreisDataGridViewTextBoxColumn.Name = "EinkaufspreisDataGridViewTextBoxColumn"
        '
        'LieferantDataGridViewTextBoxColumn
        '
        Me.LieferantDataGridViewTextBoxColumn.DataPropertyName = "Lieferant"
        Me.LieferantDataGridViewTextBoxColumn.HeaderText = "Lieferant"
        Me.LieferantDataGridViewTextBoxColumn.Name = "LieferantDataGridViewTextBoxColumn"
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
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
        'Button4loeschen
        '
        Me.Button4loeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4loeschen.Location = New System.Drawing.Point(12, 531)
        Me.Button4loeschen.Name = "Button4loeschen"
        Me.Button4loeschen.Size = New System.Drawing.Size(119, 62)
        Me.Button4loeschen.TabIndex = 58
        Me.Button4loeschen.Text = "Teilnehmer löschen"
        Me.Button4loeschen.UseVisualStyleBackColor = True
        '
        'ButtonLeeren
        '
        Me.ButtonLeeren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLeeren.Location = New System.Drawing.Point(427, 531)
        Me.ButtonLeeren.Name = "ButtonLeeren"
        Me.ButtonLeeren.Size = New System.Drawing.Size(110, 62)
        Me.ButtonLeeren.TabIndex = 57
        Me.ButtonLeeren.Text = "Formular leeren"
        Me.ButtonLeeren.UseVisualStyleBackColor = True
        '
        'ButtonSpeichern
        '
        Me.ButtonSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpeichern.Location = New System.Drawing.Point(574, 531)
        Me.ButtonSpeichern.Name = "ButtonSpeichern"
        Me.ButtonSpeichern.Size = New System.Drawing.Size(108, 62)
        Me.ButtonSpeichern.TabIndex = 56
        Me.ButtonSpeichern.Text = "Speichern"
        Me.ButtonSpeichern.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DataGridView5)
        Me.GroupBox7.Location = New System.Drawing.Point(752, 260)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(667, 371)
        Me.GroupBox7.TabIndex = 59
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Mit Klick Kursteilnehmer auswählen"
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZName, Me.Kurs, Me.FB, Me.KursPreis, Me.KursBezahlt, Me.Materialpreis, Me.MaterialBezahlt, Me.VZNameDataGridViewTextBoxColumn, Me.KursDataGridViewTextBoxColumn, Me.FBDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.KursPreisDataGridViewTextBoxColumn, Me.KursBezahltDataGridViewTextBoxColumn, Me.MaterialpreisDataGridViewTextBoxColumn, Me.MaterialBezahltDataGridViewTextBoxColumn, Me.DatumKursBezahltDataGridViewTextBoxColumn, Me.DatumKBFaelligDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.bsTeilnehmer
        Me.DataGridView5.Location = New System.Drawing.Point(15, 24)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(635, 330)
        Me.DataGridView5.TabIndex = 20
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
        'KursPreis
        '
        Me.KursPreis.DataPropertyName = "KursPreis"
        Me.KursPreis.HeaderText = "KursPreis"
        Me.KursPreis.Name = "KursPreis"
        '
        'KursBezahlt
        '
        Me.KursBezahlt.DataPropertyName = "KursBezahlt"
        Me.KursBezahlt.HeaderText = "KursBezahlt"
        Me.KursBezahlt.Name = "KursBezahlt"
        '
        'Materialpreis
        '
        Me.Materialpreis.DataPropertyName = "Materialpreis"
        Me.Materialpreis.HeaderText = "Materialpreis"
        Me.Materialpreis.Name = "Materialpreis"
        '
        'MaterialBezahlt
        '
        Me.MaterialBezahlt.DataPropertyName = "MaterialBezahlt"
        Me.MaterialBezahlt.HeaderText = "MaterialBezahlt"
        Me.MaterialBezahlt.Name = "MaterialBezahlt"
        '
        'VZNameDataGridViewTextBoxColumn
        '
        Me.VZNameDataGridViewTextBoxColumn.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.Name = "VZNameDataGridViewTextBoxColumn"
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
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'taTeilnehmer
        '
        Me.taTeilnehmer.ClearBeforeFill = True
        '
        'taKursmaterial
        '
        Me.taKursmaterial.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView1.DataSource = Me.bsMaterialKurs
        Me.DataGridView1.Location = New System.Drawing.Point(780, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(362, 163)
        Me.DataGridView1.TabIndex = 60
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Material"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Bemerkung"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bemerkung"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'bsMaterialKurs
        '
        Me.bsMaterialKurs.DataMember = "MaterialKurs"
        Me.bsMaterialKurs.DataSource = Me.DsAusbildung
        '
        'taMaterialKurs
        '
        Me.taMaterialKurs.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 222)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bemerkung"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "Bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(20, 19)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(637, 185)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'GroupBox6Kalender
        '
        Me.GroupBox6Kalender.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox6Kalender.Controls.Add(Me.Button5Zurueck)
        Me.GroupBox6Kalender.Controls.Add(Me.Button7Speichern)
        Me.GroupBox6Kalender.Location = New System.Drawing.Point(1172, 12)
        Me.GroupBox6Kalender.Name = "GroupBox6Kalender"
        Me.GroupBox6Kalender.Size = New System.Drawing.Size(205, 219)
        Me.GroupBox6Kalender.TabIndex = 90
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
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(780, 188)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 82)
        Me.ListBox2.TabIndex = 91
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMaterialKurs, "Kurs", True))
        Me.TextBox1.Location = New System.Drawing.Point(1011, 188)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 92
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMaterialKurs, "FB", True))
        Me.TextBox2.Location = New System.Drawing.Point(1011, 215)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 93
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMaterialKurs, "Material", True))
        Me.TextBox3.Location = New System.Drawing.Point(1011, 242)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 94
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMaterialKurs, "VZName", True))
        Me.TextBox4.Location = New System.Drawing.Point(1011, 269)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 95
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMaterialKurs, "Verkaufspreis", True))
        Me.TextBox8.Location = New System.Drawing.Point(1011, 304)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 96
        '
        'Kursteilnehmer2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1769, 605)
        Me.Controls.Add(Me.Button2Bemerkung)
        Me.Controls.Add(Me.Button1Material)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.GroupBox6Kalender)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Button4loeschen)
        Me.Controls.Add(Me.ButtonLeeren)
        Me.Controls.Add(Me.ButtonSpeichern)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kursteilnehmer2"
        Me.Text = "Kursmaterial der Teilnehmer"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKursmaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaterialKurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6Kalender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1Material As System.Windows.Forms.Button
    Friend WithEvents Button2Bemerkung As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4loeschen As System.Windows.Forms.Button
    Friend WithEvents ButtonLeeren As System.Windows.Forms.Button
    Friend WithEvents ButtonSpeichern As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter
    Friend WithEvents VZName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kurs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursPreis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursBezahlt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Materialpreis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialBezahlt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursPreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKBFaelligDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsKursmaterial As System.Windows.Forms.BindingSource
    Friend WithEvents taKursmaterial As WindowsApplication1.dsAusbildungTableAdapters.KursmaterialTableAdapter
    Friend WithEvents MaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListenpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EinkaufspreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LieferantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsMaterialKurs As System.Windows.Forms.BindingSource
    Friend WithEvents taMaterialKurs As WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox6Kalender As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button5Zurueck As System.Windows.Forms.Button
    Friend WithEvents Button7Speichern As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
End Class
