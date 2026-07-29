<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Versicherter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Versicherter))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bsVersicherter = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsVersicherung = New WindowsApplication1.VersicherungDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.bsVertrag = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RadioButtonRue = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFol = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKau = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRech = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUnf = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHafBe = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBoxHaf = New System.Windows.Forms.GroupBox()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.ButtonHAFSpeichern = New System.Windows.Forms.Button()
        Me.RadioButtonM10 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS10 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonM7 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS7 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonM5 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS5 = New System.Windows.Forms.RadioButton()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VersicherterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Polizze = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersicherterNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolizzeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.bsYPdehaf = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.ButtonNameSpeichern = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.GroupBoxUnf = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.ButtonUnfSpeichern = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.RadioButton770 = New System.Windows.Forms.RadioButton()
        Me.RadioButton510 = New System.Windows.Forms.RadioButton()
        Me.RadioButton380 = New System.Windows.Forms.RadioButton()
        Me.RadioButton230 = New System.Windows.Forms.RadioButton()
        Me.RadioButton155 = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.bsYPdeUnf = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.GroupBoxRech = New System.Windows.Forms.GroupBox()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ButtonrechSpeichern = New System.Windows.Forms.Button()
        Me.RadioButtonRekost = New System.Windows.Forms.RadioButton()
        Me.bsYPderech = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.groupboxkau = New System.Windows.Forms.GroupBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.TextBox78 = New System.Windows.Forms.TextBox()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.TextBox77 = New System.Windows.Forms.TextBox()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.TextBox76 = New System.Windows.Forms.TextBox()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.TextBox75 = New System.Windows.Forms.TextBox()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.ButtonKautionSpeichern = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox79 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.bsYPdekau = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.GroupBoxFol = New System.Windows.Forms.GroupBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonM63 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS63 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonM52 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS52 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonM43 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS43 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonM38 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS38 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonM33 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonS33 = New System.Windows.Forms.RadioButton()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.ButtonFoSpeichern = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.bsYPdefol = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.GroupBoxRue = New System.Windows.Forms.GroupBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
        Me.bsYPdeRue = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ToernbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrewanzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernanfangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernendeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charterkosten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flugpreis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsToernKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.TextBox74 = New System.Windows.Forms.TextBox()
        Me.taVertrag = New WindowsApplication1.VersicherungDataSetTableAdapters.VertragTableAdapter()
        Me.taYPdehaf = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdehafTableAdapter()
        Me.taVersicherter = New WindowsApplication1.VersicherungDataSetTableAdapters.VersicherterTableAdapter()
        Me.taYPdeUnf = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdeUnfTableAdapter()
        Me.ta1YPderech = New WindowsApplication1.VersicherungDataSetTableAdapters.YPderechTableAdapter()
        Me.taYPdekau = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdekauTableAdapter()
        Me.taYPdefol = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdefolTableAdapter()
        Me.taYPdeRue = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdeRueTableAdapter()
        Me.TextBox80 = New System.Windows.Forms.TextBox()
        Me.TextBox81 = New System.Windows.Forms.TextBox()
        Me.TextBox82 = New System.Windows.Forms.TextBox()
        CType(Me.bsVersicherter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVertrag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxHaf.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsYPdehaf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxUnf.SuspendLayout()
        CType(Me.bsYPdeUnf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRech.SuspendLayout()
        CType(Me.bsYPderech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxkau.SuspendLayout()
        CType(Me.bsYPdekau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFol.SuspendLayout()
        CType(Me.bsYPdefol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRue.SuspendLayout()
        CType(Me.bsYPdeRue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVersicherter, "VersicherterName", True))
        Me.TextBox1.Location = New System.Drawing.Point(166, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 21)
        Me.TextBox1.TabIndex = 0
        '
        'bsVersicherter
        '
        Me.bsVersicherter.DataMember = "Versicherter"
        Me.bsVersicherter.DataSource = Me.dsVersicherung
        '
        'dsVersicherung
        '
        Me.dsVersicherung.DataSetName = "VersicherungDataSet"
        Me.dsVersicherung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVersicherter, "Polizze", True))
        Me.TextBox2.Location = New System.Drawing.Point(438, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 21)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vor- und Nachname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Polizzennummer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox70)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRue)
        Me.GroupBox1.Controls.Add(Me.RadioButtonFol)
        Me.GroupBox1.Controls.Add(Me.RadioButtonKau)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRech)
        Me.GroupBox1.Controls.Add(Me.RadioButtonUnf)
        Me.GroupBox1.Controls.Add(Me.RadioButtonHafBe)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 310)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Versicherungsarten"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(253, 233)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'TextBox70
        '
        Me.TextBox70.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "rue-toern", True))
        Me.TextBox70.Location = New System.Drawing.Point(284, 232)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(140, 21)
        Me.TextBox70.TabIndex = 26
        '
        'bsVertrag
        '
        Me.bsVertrag.DataMember = "Vertrag"
        Me.bsVertrag.DataSource = Me.dsVersicherung
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "€"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(443, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "€"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(443, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "€"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "€"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "€"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "€"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Summe €"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(463, 271)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(71, 21)
        Me.TextBox9.TabIndex = 5
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "rue-Kosten", True))
        Me.TextBox8.Location = New System.Drawing.Point(464, 232)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(70, 21)
        Me.TextBox8.TabIndex = 18
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "fol-Kosten", True))
        Me.TextBox7.Location = New System.Drawing.Point(464, 192)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(70, 21)
        Me.TextBox7.TabIndex = 17
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "kau-Kosten", True))
        Me.TextBox6.Location = New System.Drawing.Point(464, 149)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(70, 21)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "rech-Kosten", True))
        Me.TextBox5.Location = New System.Drawing.Point(464, 113)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(70, 21)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "unf-Kosten", True))
        Me.TextBox4.Location = New System.Drawing.Point(464, 76)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(70, 21)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "haf-kosten", True))
        Me.TextBox3.Location = New System.Drawing.Point(464, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(70, 21)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioButtonRue
        '
        Me.RadioButtonRue.AutoSize = True
        Me.RadioButtonRue.Location = New System.Drawing.Point(15, 233)
        Me.RadioButtonRue.Name = "RadioButtonRue"
        Me.RadioButtonRue.Size = New System.Drawing.Size(232, 19)
        Me.RadioButtonRue.TabIndex = 12
        Me.RadioButtonRue.TabStop = True
        Me.RadioButtonRue.Text = "Charter Rücktritt Versicherung für Törn"
        Me.RadioButtonRue.UseVisualStyleBackColor = True
        '
        'RadioButtonFol
        '
        Me.RadioButtonFol.AutoSize = True
        Me.RadioButtonFol.Location = New System.Drawing.Point(15, 193)
        Me.RadioButtonFol.Name = "RadioButtonFol"
        Me.RadioButtonFol.Size = New System.Drawing.Size(221, 19)
        Me.RadioButtonFol.TabIndex = 11
        Me.RadioButtonFol.TabStop = True
        Me.RadioButtonFol.Text = "Charter Folgeschaden Versicherung"
        Me.RadioButtonFol.UseVisualStyleBackColor = True
        '
        'RadioButtonKau
        '
        Me.RadioButtonKau.AutoSize = True
        Me.RadioButtonKau.Location = New System.Drawing.Point(15, 150)
        Me.RadioButtonKau.Name = "RadioButtonKau"
        Me.RadioButtonKau.Size = New System.Drawing.Size(185, 19)
        Me.RadioButtonKau.TabIndex = 10
        Me.RadioButtonKau.TabStop = True
        Me.RadioButtonKau.Text = "Charter Kaution Versicherung"
        Me.RadioButtonKau.UseVisualStyleBackColor = True
        '
        'RadioButtonRech
        '
        Me.RadioButtonRech.AutoSize = True
        Me.RadioButtonRech.Location = New System.Drawing.Point(15, 114)
        Me.RadioButtonRech.Name = "RadioButtonRech"
        Me.RadioButtonRech.Size = New System.Drawing.Size(213, 19)
        Me.RadioButtonRech.TabIndex = 9
        Me.RadioButtonRech.TabStop = True
        Me.RadioButtonRech.Text = "Skipper Rechtsschutzversicherung"
        Me.RadioButtonRech.UseVisualStyleBackColor = True
        '
        'RadioButtonUnf
        '
        Me.RadioButtonUnf.AutoSize = True
        Me.RadioButtonUnf.Location = New System.Drawing.Point(15, 78)
        Me.RadioButtonUnf.Name = "RadioButtonUnf"
        Me.RadioButtonUnf.Size = New System.Drawing.Size(172, 19)
        Me.RadioButtonUnf.TabIndex = 8
        Me.RadioButtonUnf.TabStop = True
        Me.RadioButtonUnf.Text = "Skipper Unfallversicherung"
        Me.RadioButtonUnf.UseVisualStyleBackColor = True
        '
        'RadioButtonHafBe
        '
        Me.RadioButtonHafBe.AutoSize = True
        Me.RadioButtonHafBe.Location = New System.Drawing.Point(15, 39)
        Me.RadioButtonHafBe.Name = "RadioButtonHafBe"
        Me.RadioButtonHafBe.Size = New System.Drawing.Size(315, 19)
        Me.RadioButtonHafBe.TabIndex = 7
        Me.RadioButtonHafBe.TabStop = True
        Me.RadioButtonHafBe.Text = "Skipper Haftpflicht- und Beschlagnahmeversicherung"
        Me.RadioButtonHafBe.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(482, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Preis"
        '
        'GroupBoxHaf
        '
        Me.GroupBoxHaf.Controls.Add(Me.RadioButton14)
        Me.GroupBoxHaf.Controls.Add(Me.ButtonHAFSpeichern)
        Me.GroupBoxHaf.Controls.Add(Me.RadioButtonM10)
        Me.GroupBoxHaf.Controls.Add(Me.RadioButtonS10)
        Me.GroupBoxHaf.Controls.Add(Me.RadioButtonM7)
        Me.GroupBoxHaf.Controls.Add(Me.RadioButtonS7)
        Me.GroupBoxHaf.Controls.Add(Me.RadioButtonM5)
        Me.GroupBoxHaf.Controls.Add(Me.RadioButtonS5)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox19)
        Me.GroupBoxHaf.Controls.Add(Me.Label20)
        Me.GroupBoxHaf.Controls.Add(Me.Label19)
        Me.GroupBoxHaf.Controls.Add(Me.Label18)
        Me.GroupBoxHaf.Controls.Add(Me.Label17)
        Me.GroupBoxHaf.Controls.Add(Me.Label16)
        Me.GroupBoxHaf.Controls.Add(Me.Label15)
        Me.GroupBoxHaf.Controls.Add(Me.Label14)
        Me.GroupBoxHaf.Controls.Add(Me.Label13)
        Me.GroupBoxHaf.Controls.Add(Me.Label12)
        Me.GroupBoxHaf.Controls.Add(Me.Label11)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox12)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox11)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox10)
        Me.GroupBoxHaf.Location = New System.Drawing.Point(2171, 360)
        Me.GroupBoxHaf.Name = "GroupBoxHaf"
        Me.GroupBoxHaf.Size = New System.Drawing.Size(570, 310)
        Me.GroupBoxHaf.TabIndex = 5
        Me.GroupBoxHaf.TabStop = False
        Me.GroupBoxHaf.Text = "Skipper Haftpflicht- und Beschlagnahmeversicherung"
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(317, 207)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(108, 19)
        Me.RadioButton14.TabIndex = 27
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "Nicht versichert"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'ButtonHAFSpeichern
        '
        Me.ButtonHAFSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHAFSpeichern.Location = New System.Drawing.Point(447, 227)
        Me.ButtonHAFSpeichern.Name = "ButtonHAFSpeichern"
        Me.ButtonHAFSpeichern.Size = New System.Drawing.Size(97, 35)
        Me.ButtonHAFSpeichern.TabIndex = 26
        Me.ButtonHAFSpeichern.Text = "Speichern"
        Me.ButtonHAFSpeichern.UseVisualStyleBackColor = True
        '
        'RadioButtonM10
        '
        Me.RadioButtonM10.AutoSize = True
        Me.RadioButtonM10.Location = New System.Drawing.Point(317, 176)
        Me.RadioButtonM10.Name = "RadioButtonM10"
        Me.RadioButtonM10.Size = New System.Drawing.Size(118, 19)
        Me.RadioButtonM10.TabIndex = 25
        Me.RadioButtonM10.TabStop = True
        Me.RadioButtonM10.Text = "RadioButtonM10"
        Me.RadioButtonM10.UseVisualStyleBackColor = True
        '
        'RadioButtonS10
        '
        Me.RadioButtonS10.AutoSize = True
        Me.RadioButtonS10.Location = New System.Drawing.Point(187, 174)
        Me.RadioButtonS10.Name = "RadioButtonS10"
        Me.RadioButtonS10.Size = New System.Drawing.Size(115, 19)
        Me.RadioButtonS10.TabIndex = 24
        Me.RadioButtonS10.TabStop = True
        Me.RadioButtonS10.Text = "RadioButtonS10"
        Me.RadioButtonS10.UseVisualStyleBackColor = True
        '
        'RadioButtonM7
        '
        Me.RadioButtonM7.AutoSize = True
        Me.RadioButtonM7.Location = New System.Drawing.Point(317, 132)
        Me.RadioButtonM7.Name = "RadioButtonM7"
        Me.RadioButtonM7.Size = New System.Drawing.Size(111, 19)
        Me.RadioButtonM7.TabIndex = 23
        Me.RadioButtonM7.TabStop = True
        Me.RadioButtonM7.Text = "RadioButtonM7"
        Me.RadioButtonM7.UseVisualStyleBackColor = True
        '
        'RadioButtonS7
        '
        Me.RadioButtonS7.AutoSize = True
        Me.RadioButtonS7.Location = New System.Drawing.Point(187, 132)
        Me.RadioButtonS7.Name = "RadioButtonS7"
        Me.RadioButtonS7.Size = New System.Drawing.Size(108, 19)
        Me.RadioButtonS7.TabIndex = 22
        Me.RadioButtonS7.TabStop = True
        Me.RadioButtonS7.Text = "RadioButtonS7"
        Me.RadioButtonS7.UseVisualStyleBackColor = True
        '
        'RadioButtonM5
        '
        Me.RadioButtonM5.AutoSize = True
        Me.RadioButtonM5.Location = New System.Drawing.Point(317, 90)
        Me.RadioButtonM5.Name = "RadioButtonM5"
        Me.RadioButtonM5.Size = New System.Drawing.Size(111, 19)
        Me.RadioButtonM5.TabIndex = 21
        Me.RadioButtonM5.TabStop = True
        Me.RadioButtonM5.Text = "RadioButtonM5"
        Me.RadioButtonM5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButtonM5.UseVisualStyleBackColor = True
        '
        'RadioButtonS5
        '
        Me.RadioButtonS5.AutoSize = True
        Me.RadioButtonS5.Location = New System.Drawing.Point(187, 90)
        Me.RadioButtonS5.Name = "RadioButtonS5"
        Me.RadioButtonS5.Size = New System.Drawing.Size(108, 19)
        Me.RadioButtonS5.TabIndex = 20
        Me.RadioButtonS5.TabStop = True
        Me.RadioButtonS5.Text = "RadioButtonS5"
        Me.RadioButtonS5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButtonS5.UseVisualStyleBackColor = True
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "haf-kosten", True))
        Me.TextBox19.Location = New System.Drawing.Point(317, 234)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(85, 21)
        Me.TextBox19.TabIndex = 19
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(257, 237)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 15)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Prämie  €"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(87, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 15)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Mio. €"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(87, 178)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 15)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Mio. €"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(87, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 15)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Mio. €"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(38, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Sachschäden"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 15)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = " Personen- und"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(314, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Motoryachten  €"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(184, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Segelyachten  €"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(510, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Mitversichert ist das Beschlagnahmerisiko bis € 52.000,- gemäß YACHT-POOL Bedingu" & _
    "ngen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Deckung für"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(37, 175)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(44, 21)
        Me.TextBox12.TabIndex = 2
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(38, 131)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(43, 21)
        Me.TextBox11.TabIndex = 1
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(37, 89)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(44, 21)
        Me.TextBox10.TabIndex = 0
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VersicherterName, Me.Polizze, Me.IDDataGridViewTextBoxColumn, Me.VersicherterNameDataGridViewTextBoxColumn, Me.PolizzeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsVersicherter
        Me.DataGridView1.Location = New System.Drawing.Point(15, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(536, 263)
        Me.DataGridView1.TabIndex = 6
        '
        'VersicherterName
        '
        Me.VersicherterName.DataPropertyName = "VersicherterName"
        Me.VersicherterName.HeaderText = "VersicherterName"
        Me.VersicherterName.Name = "VersicherterName"
        Me.VersicherterName.Width = 250
        '
        'Polizze
        '
        Me.Polizze.DataPropertyName = "Polizze"
        Me.Polizze.HeaderText = "Polizze"
        Me.Polizze.Name = "Polizze"
        Me.Polizze.Width = 200
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'VersicherterNameDataGridViewTextBoxColumn
        '
        Me.VersicherterNameDataGridViewTextBoxColumn.DataPropertyName = "VersicherterName"
        Me.VersicherterNameDataGridViewTextBoxColumn.HeaderText = "VersicherterName"
        Me.VersicherterNameDataGridViewTextBoxColumn.Name = "VersicherterNameDataGridViewTextBoxColumn"
        '
        'PolizzeDataGridViewTextBoxColumn
        '
        Me.PolizzeDataGridViewTextBoxColumn.DataPropertyName = "Polizze"
        Me.PolizzeDataGridViewTextBoxColumn.HeaderText = "Polizze"
        Me.PolizzeDataGridViewTextBoxColumn.Name = "PolizzeDataGridViewTextBoxColumn"
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdehaf, "Deckung", True))
        Me.TextBox13.Location = New System.Drawing.Point(24, 661)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 21)
        Me.TextBox13.TabIndex = 7
        '
        'bsYPdehaf
        '
        Me.bsYPdehaf.DataMember = "YPdehaf"
        Me.bsYPdehaf.DataSource = Me.dsVersicherung
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdehaf, "Segel", True))
        Me.TextBox14.Location = New System.Drawing.Point(24, 689)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 21)
        Me.TextBox14.TabIndex = 8
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdehaf, "Motor", True))
        Me.TextBox15.Location = New System.Drawing.Point(25, 717)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 21)
        Me.TextBox15.TabIndex = 9
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "haf-Nr", True))
        Me.TextBox16.Location = New System.Drawing.Point(25, 744)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 21)
        Me.TextBox16.TabIndex = 10
        '
        'ButtonNameSpeichern
        '
        Me.ButtonNameSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNameSpeichern.Location = New System.Drawing.Point(514, 67)
        Me.ButtonNameSpeichern.Name = "ButtonNameSpeichern"
        Me.ButtonNameSpeichern.Size = New System.Drawing.Size(80, 41)
        Me.ButtonNameSpeichern.TabIndex = 11
        Me.ButtonNameSpeichern.Text = "Speichern"
        Me.ButtonNameSpeichern.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(2171, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 310)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "Polizze", True))
        Me.TextBox17.Location = New System.Drawing.Point(25, 772)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 21)
        Me.TextBox17.TabIndex = 14
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(25, 800)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 21)
        Me.TextBox18.TabIndex = 15
        '
        'GroupBoxUnf
        '
        Me.GroupBoxUnf.Controls.Add(Me.RadioButton11)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox35)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox34)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox33)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox32)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox31)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox30)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox29)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox28)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox27)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox26)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox25)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox24)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox23)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox22)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox21)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox20)
        Me.GroupBoxUnf.Controls.Add(Me.ButtonUnfSpeichern)
        Me.GroupBoxUnf.Controls.Add(Me.Label24)
        Me.GroupBoxUnf.Controls.Add(Me.RadioButton770)
        Me.GroupBoxUnf.Controls.Add(Me.RadioButton510)
        Me.GroupBoxUnf.Controls.Add(Me.RadioButton380)
        Me.GroupBoxUnf.Controls.Add(Me.RadioButton230)
        Me.GroupBoxUnf.Controls.Add(Me.RadioButton155)
        Me.GroupBoxUnf.Controls.Add(Me.Label23)
        Me.GroupBoxUnf.Controls.Add(Me.Label22)
        Me.GroupBoxUnf.Controls.Add(Me.Label21)
        Me.GroupBoxUnf.Location = New System.Drawing.Point(1590, 44)
        Me.GroupBoxUnf.Name = "GroupBoxUnf"
        Me.GroupBoxUnf.Size = New System.Drawing.Size(570, 310)
        Me.GroupBoxUnf.TabIndex = 16
        Me.GroupBoxUnf.TabStop = False
        Me.GroupBoxUnf.Text = "Skipper Unfall Versicherung"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(416, 238)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(108, 19)
        Me.RadioButton11.TabIndex = 26
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "Nicht versichert"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'TextBox35
        '
        Me.TextBox35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "unf-Kosten", True))
        Me.TextBox35.Location = New System.Drawing.Point(277, 271)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(100, 21)
        Me.TextBox35.TabIndex = 25
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(277, 205)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(100, 21)
        Me.TextBox34.TabIndex = 24
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(158, 205)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(100, 21)
        Me.TextBox33.TabIndex = 23
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(42, 205)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(100, 21)
        Me.TextBox32.TabIndex = 22
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(277, 164)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(100, 21)
        Me.TextBox31.TabIndex = 21
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(158, 164)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(100, 21)
        Me.TextBox30.TabIndex = 20
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(42, 164)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(100, 21)
        Me.TextBox29.TabIndex = 19
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(277, 125)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(100, 21)
        Me.TextBox28.TabIndex = 18
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(158, 125)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(100, 21)
        Me.TextBox27.TabIndex = 17
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(42, 126)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(100, 21)
        Me.TextBox26.TabIndex = 16
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(277, 89)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(100, 21)
        Me.TextBox25.TabIndex = 15
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(158, 89)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 21)
        Me.TextBox24.TabIndex = 14
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(42, 89)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 21)
        Me.TextBox23.TabIndex = 13
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(277, 50)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 21)
        Me.TextBox22.TabIndex = 12
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(158, 50)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 21)
        Me.TextBox21.TabIndex = 11
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(42, 50)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 21)
        Me.TextBox20.TabIndex = 10
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonUnfSpeichern
        '
        Me.ButtonUnfSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnfSpeichern.Location = New System.Drawing.Point(416, 263)
        Me.ButtonUnfSpeichern.Name = "ButtonUnfSpeichern"
        Me.ButtonUnfSpeichern.Size = New System.Drawing.Size(100, 37)
        Me.ButtonUnfSpeichern.TabIndex = 9
        Me.ButtonUnfSpeichern.Text = "Speichern"
        Me.ButtonUnfSpeichern.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(198, 274)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 15)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Prämie  €"
        '
        'RadioButton770
        '
        Me.RadioButton770.AutoSize = True
        Me.RadioButton770.Location = New System.Drawing.Point(416, 206)
        Me.RadioButton770.Name = "RadioButton770"
        Me.RadioButton770.Size = New System.Drawing.Size(114, 19)
        Me.RadioButton770.TabIndex = 7
        Me.RadioButton770.TabStop = True
        Me.RadioButton770.Text = "RadioButton770"
        Me.RadioButton770.UseVisualStyleBackColor = True
        '
        'RadioButton510
        '
        Me.RadioButton510.AutoSize = True
        Me.RadioButton510.Location = New System.Drawing.Point(416, 165)
        Me.RadioButton510.Name = "RadioButton510"
        Me.RadioButton510.Size = New System.Drawing.Size(114, 19)
        Me.RadioButton510.TabIndex = 6
        Me.RadioButton510.TabStop = True
        Me.RadioButton510.Text = "RadioButton510"
        Me.RadioButton510.UseVisualStyleBackColor = True
        '
        'RadioButton380
        '
        Me.RadioButton380.AutoSize = True
        Me.RadioButton380.Location = New System.Drawing.Point(416, 127)
        Me.RadioButton380.Name = "RadioButton380"
        Me.RadioButton380.Size = New System.Drawing.Size(114, 19)
        Me.RadioButton380.TabIndex = 5
        Me.RadioButton380.TabStop = True
        Me.RadioButton380.Text = "RadioButton380"
        Me.RadioButton380.UseVisualStyleBackColor = True
        '
        'RadioButton230
        '
        Me.RadioButton230.AutoSize = True
        Me.RadioButton230.Location = New System.Drawing.Point(416, 90)
        Me.RadioButton230.Name = "RadioButton230"
        Me.RadioButton230.Size = New System.Drawing.Size(114, 19)
        Me.RadioButton230.TabIndex = 4
        Me.RadioButton230.TabStop = True
        Me.RadioButton230.Text = "RadioButton230"
        Me.RadioButton230.UseVisualStyleBackColor = True
        '
        'RadioButton155
        '
        Me.RadioButton155.AutoSize = True
        Me.RadioButton155.Location = New System.Drawing.Point(416, 51)
        Me.RadioButton155.Name = "RadioButton155"
        Me.RadioButton155.Size = New System.Drawing.Size(114, 19)
        Me.RadioButton155.TabIndex = 3
        Me.RadioButton155.TabStop = True
        Me.RadioButton155.Text = "RadioButton155"
        Me.RadioButton155.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(274, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 15)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Tod"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(155, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 15)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Bergekosten"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(39, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Invalidität"
        '
        'TextBox36
        '
        Me.TextBox36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Invalid", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox36.Location = New System.Drawing.Point(147, 661)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(100, 21)
        Me.TextBox36.TabIndex = 18
        '
        'bsYPdeUnf
        '
        Me.bsYPdeUnf.DataMember = "YPdeUnf"
        Me.bsYPdeUnf.DataSource = Me.dsVersicherung
        '
        'TextBox37
        '
        Me.TextBox37.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Bergung", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox37.Location = New System.Drawing.Point(147, 691)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(100, 21)
        Me.TextBox37.TabIndex = 19
        '
        'TextBox38
        '
        Me.TextBox38.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Tod", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox38.Location = New System.Drawing.Point(147, 720)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(100, 21)
        Me.TextBox38.TabIndex = 20
        '
        'TextBox39
        '
        Me.TextBox39.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Kosten", True))
        Me.TextBox39.Location = New System.Drawing.Point(147, 748)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(100, 21)
        Me.TextBox39.TabIndex = 21
        '
        'TextBox40
        '
        Me.TextBox40.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "unf-Kosten", True))
        Me.TextBox40.Location = New System.Drawing.Point(147, 776)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(100, 21)
        Me.TextBox40.TabIndex = 22
        '
        'GroupBoxRech
        '
        Me.GroupBoxRech.Controls.Add(Me.RadioButton13)
        Me.GroupBoxRech.Controls.Add(Me.TextBox42)
        Me.GroupBoxRech.Controls.Add(Me.Label27)
        Me.GroupBoxRech.Controls.Add(Me.ButtonrechSpeichern)
        Me.GroupBoxRech.Controls.Add(Me.RadioButtonRekost)
        Me.GroupBoxRech.Controls.Add(Me.TextBox41)
        Me.GroupBoxRech.Controls.Add(Me.Label26)
        Me.GroupBoxRech.Controls.Add(Me.Label25)
        Me.GroupBoxRech.Location = New System.Drawing.Point(1643, 406)
        Me.GroupBoxRech.Name = "GroupBoxRech"
        Me.GroupBoxRech.Size = New System.Drawing.Size(560, 310)
        Me.GroupBoxRech.TabIndex = 23
        Me.GroupBoxRech.TabStop = False
        Me.GroupBoxRech.Text = "Skipper Rechtschutz Versicherung"
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(225, 231)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(108, 19)
        Me.RadioButton13.TabIndex = 7
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "Nicht versichert"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'TextBox42
        '
        Me.TextBox42.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "rech-Kosten", True))
        Me.TextBox42.Location = New System.Drawing.Point(225, 256)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(100, 21)
        Me.TextBox42.TabIndex = 6
        Me.TextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(159, 259)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 15)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Prämie  €"
        '
        'ButtonrechSpeichern
        '
        Me.ButtonrechSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonrechSpeichern.Location = New System.Drawing.Point(417, 250)
        Me.ButtonrechSpeichern.Name = "ButtonrechSpeichern"
        Me.ButtonrechSpeichern.Size = New System.Drawing.Size(114, 32)
        Me.ButtonrechSpeichern.TabIndex = 4
        Me.ButtonrechSpeichern.Text = "Speichern"
        Me.ButtonrechSpeichern.UseVisualStyleBackColor = True
        '
        'RadioButtonRekost
        '
        Me.RadioButtonRekost.AutoSize = True
        Me.RadioButtonRekost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPderech, "Kosten", True))
        Me.RadioButtonRekost.Location = New System.Drawing.Point(417, 101)
        Me.RadioButtonRekost.Name = "RadioButtonRekost"
        Me.RadioButtonRekost.Size = New System.Drawing.Size(100, 19)
        Me.RadioButtonRekost.TabIndex = 3
        Me.RadioButtonRekost.TabStop = True
        Me.RadioButtonRekost.Text = "RadioButton1"
        Me.RadioButtonRekost.UseVisualStyleBackColor = True
        '
        'bsYPderech
        '
        Me.bsYPderech.DataMember = "YPderech"
        Me.bsYPderech.DataSource = Me.dsVersicherung
        '
        'TextBox41
        '
        Me.TextBox41.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPderech, "Deckung", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox41.Location = New System.Drawing.Point(417, 63)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.ReadOnly = True
        Me.TextBox41.Size = New System.Drawing.Size(100, 21)
        Me.TextBox41.TabIndex = 2
        Me.TextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(22, 63)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(388, 15)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Geltungsbereich weltweit. Versicherungssumme je Schadensereignis:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(22, 37)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(384, 15)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Alle Crewmitglieder sind in den Versicherungsschutz eingeschlossen."
        '
        'groupboxkau
        '
        Me.groupboxkau.Controls.Add(Me.Label48)
        Me.groupboxkau.Controls.Add(Me.Label47)
        Me.groupboxkau.Controls.Add(Me.RadioButton18)
        Me.groupboxkau.Controls.Add(Me.TextBox78)
        Me.groupboxkau.Controls.Add(Me.RadioButton17)
        Me.groupboxkau.Controls.Add(Me.TextBox77)
        Me.groupboxkau.Controls.Add(Me.RadioButton16)
        Me.groupboxkau.Controls.Add(Me.TextBox76)
        Me.groupboxkau.Controls.Add(Me.RadioButton15)
        Me.groupboxkau.Controls.Add(Me.TextBox75)
        Me.groupboxkau.Controls.Add(Me.RadioButton12)
        Me.groupboxkau.Controls.Add(Me.TextBox50)
        Me.groupboxkau.Controls.Add(Me.ButtonKautionSpeichern)
        Me.groupboxkau.Controls.Add(Me.Label32)
        Me.groupboxkau.Controls.Add(Me.RadioButton6)
        Me.groupboxkau.Controls.Add(Me.RadioButton7)
        Me.groupboxkau.Controls.Add(Me.RadioButton5)
        Me.groupboxkau.Controls.Add(Me.RadioButton4)
        Me.groupboxkau.Controls.Add(Me.RadioButton3)
        Me.groupboxkau.Controls.Add(Me.RadioButton2)
        Me.groupboxkau.Controls.Add(Me.RadioButton1)
        Me.groupboxkau.Controls.Add(Me.TextBox48)
        Me.groupboxkau.Controls.Add(Me.TextBox47)
        Me.groupboxkau.Controls.Add(Me.TextBox46)
        Me.groupboxkau.Controls.Add(Me.TextBox49)
        Me.groupboxkau.Controls.Add(Me.TextBox45)
        Me.groupboxkau.Controls.Add(Me.TextBox44)
        Me.groupboxkau.Controls.Add(Me.TextBox43)
        Me.groupboxkau.Controls.Add(Me.Label30)
        Me.groupboxkau.Controls.Add(Me.Label29)
        Me.groupboxkau.Controls.Add(Me.Label28)
        Me.groupboxkau.Location = New System.Drawing.Point(969, 597)
        Me.groupboxkau.Name = "groupboxkau"
        Me.groupboxkau.Size = New System.Drawing.Size(570, 310)
        Me.groupboxkau.TabIndex = 24
        Me.groupboxkau.TabStop = False
        Me.groupboxkau.Text = "Charter Kautionsversicherung"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(324, 209)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(178, 15)
        Me.Label48.TabIndex = 39
        Me.Label48.Text = "in den Stammdaten die Prämie"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(324, 192)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(207, 15)
        Me.Label47.TabIndex = 38
        Me.Label47.Text = "Bei Kaution über 5.050,-- € definiere "
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(450, 139)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton18.TabIndex = 37
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.Text = "RadioButton18"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'TextBox78
        '
        Me.TextBox78.Location = New System.Drawing.Point(327, 139)
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New System.Drawing.Size(100, 21)
        Me.TextBox78.TabIndex = 36
        Me.TextBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(450, 111)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton17.TabIndex = 35
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.Text = "RadioButton17"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'TextBox77
        '
        Me.TextBox77.Location = New System.Drawing.Point(327, 111)
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New System.Drawing.Size(100, 21)
        Me.TextBox77.TabIndex = 34
        Me.TextBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(450, 84)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton16.TabIndex = 33
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "RadioButton16"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'TextBox76
        '
        Me.TextBox76.Location = New System.Drawing.Point(327, 84)
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New System.Drawing.Size(100, 21)
        Me.TextBox76.TabIndex = 32
        Me.TextBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(147, 250)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton15.TabIndex = 31
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Text = "RadioButton15"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'TextBox75
        '
        Me.TextBox75.Location = New System.Drawing.Point(24, 250)
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New System.Drawing.Size(100, 21)
        Me.TextBox75.TabIndex = 30
        Me.TextBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(15, 280)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(104, 19)
        Me.RadioButton12.TabIndex = 29
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Nicht vesichert"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'TextBox50
        '
        Me.TextBox50.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "kau-Kosten", True))
        Me.TextBox50.Location = New System.Drawing.Point(450, 237)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(100, 21)
        Me.TextBox50.TabIndex = 28
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonKautionSpeichern
        '
        Me.ButtonKautionSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKautionSpeichern.Location = New System.Drawing.Point(450, 264)
        Me.ButtonKautionSpeichern.Name = "ButtonKautionSpeichern"
        Me.ButtonKautionSpeichern.Size = New System.Drawing.Size(100, 37)
        Me.ButtonKautionSpeichern.TabIndex = 27
        Me.ButtonKautionSpeichern.Text = "Speichern"
        Me.ButtonKautionSpeichern.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(373, 240)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 15)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "Prämie  €"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(147, 222)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton6.TabIndex = 15
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(448, 168)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton7.TabIndex = 16
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "RadioButton7"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(147, 195)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton5.TabIndex = 14
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(147, 167)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton4.TabIndex = 13
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(147, 139)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(147, 111)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(147, 84)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox48
        '
        Me.TextBox48.Location = New System.Drawing.Point(24, 222)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(100, 21)
        Me.TextBox48.TabIndex = 8
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox47
        '
        Me.TextBox47.Location = New System.Drawing.Point(24, 194)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(100, 21)
        Me.TextBox47.TabIndex = 7
        Me.TextBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox46
        '
        Me.TextBox46.Location = New System.Drawing.Point(24, 166)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(100, 21)
        Me.TextBox46.TabIndex = 6
        Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox49
        '
        Me.TextBox49.Location = New System.Drawing.Point(327, 168)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(100, 21)
        Me.TextBox49.TabIndex = 9
        Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox45
        '
        Me.TextBox45.Location = New System.Drawing.Point(24, 138)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(100, 21)
        Me.TextBox45.TabIndex = 5
        Me.TextBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox44
        '
        Me.TextBox44.Location = New System.Drawing.Point(24, 110)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(100, 21)
        Me.TextBox44.TabIndex = 4
        Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox43
        '
        Me.TextBox43.Location = New System.Drawing.Point(24, 83)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(100, 21)
        Me.TextBox43.TabIndex = 3
        Me.TextBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(21, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 15)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Kautionshöhe"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 33)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(265, 15)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "mindestens jedoch € 50,- pro Schadenereignis."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(433, 15)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Die Selbstbeteiligung beträgt 5% der Kaution oder des niedrigeren Schadens, "
        '
        'TextBox79
        '
        Me.TextBox79.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "kau-Nr", True))
        Me.TextBox79.Location = New System.Drawing.Point(1590, 744)
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New System.Drawing.Size(80, 21)
        Me.TextBox79.TabIndex = 38
        '
        'TextBox51
        '
        Me.TextBox51.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdekau, "Kaution", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox51.Location = New System.Drawing.Point(164, 849)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(100, 21)
        Me.TextBox51.TabIndex = 25
        '
        'bsYPdekau
        '
        Me.bsYPdekau.DataMember = "YPdekau"
        Me.bsYPdekau.DataSource = Me.dsVersicherung
        '
        'TextBox52
        '
        Me.TextBox52.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdekau, "Kosten", True))
        Me.TextBox52.Location = New System.Drawing.Point(164, 877)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(100, 21)
        Me.TextBox52.TabIndex = 26
        '
        'GroupBoxFol
        '
        Me.GroupBoxFol.Controls.Add(Me.RadioButton8)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonM63)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonS63)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonM52)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonS52)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonM43)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonS43)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonM38)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonS38)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonM33)
        Me.GroupBoxFol.Controls.Add(Me.RadioButtonS33)
        Me.GroupBoxFol.Controls.Add(Me.TextBox58)
        Me.GroupBoxFol.Controls.Add(Me.TextBox57)
        Me.GroupBoxFol.Controls.Add(Me.TextBox56)
        Me.GroupBoxFol.Controls.Add(Me.TextBox55)
        Me.GroupBoxFol.Controls.Add(Me.TextBox54)
        Me.GroupBoxFol.Controls.Add(Me.TextBox53)
        Me.GroupBoxFol.Controls.Add(Me.ButtonFoSpeichern)
        Me.GroupBoxFol.Controls.Add(Me.Label36)
        Me.GroupBoxFol.Controls.Add(Me.Label35)
        Me.GroupBoxFol.Controls.Add(Me.Label34)
        Me.GroupBoxFol.Controls.Add(Me.Label33)
        Me.GroupBoxFol.Location = New System.Drawing.Point(1066, 156)
        Me.GroupBoxFol.Name = "GroupBoxFol"
        Me.GroupBoxFol.Size = New System.Drawing.Size(570, 310)
        Me.GroupBoxFol.TabIndex = 27
        Me.GroupBoxFol.TabStop = False
        Me.GroupBoxFol.Text = "Charter Folgeschadenversicherung"
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(293, 233)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(108, 19)
        Me.RadioButton8.TabIndex = 44
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Nicht versichert"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButtonM63
        '
        Me.RadioButtonM63.AutoSize = True
        Me.RadioButtonM63.Location = New System.Drawing.Point(346, 208)
        Me.RadioButtonM63.Name = "RadioButtonM63"
        Me.RadioButtonM63.Size = New System.Drawing.Size(118, 19)
        Me.RadioButtonM63.TabIndex = 43
        Me.RadioButtonM63.TabStop = True
        Me.RadioButtonM63.Text = "RadioButtonM63"
        Me.RadioButtonM63.UseVisualStyleBackColor = True
        '
        'RadioButtonS63
        '
        Me.RadioButtonS63.AutoSize = True
        Me.RadioButtonS63.Location = New System.Drawing.Point(174, 209)
        Me.RadioButtonS63.Name = "RadioButtonS63"
        Me.RadioButtonS63.Size = New System.Drawing.Size(115, 19)
        Me.RadioButtonS63.TabIndex = 42
        Me.RadioButtonS63.TabStop = True
        Me.RadioButtonS63.Text = "RadioButtonS63"
        Me.RadioButtonS63.UseVisualStyleBackColor = True
        '
        'RadioButtonM52
        '
        Me.RadioButtonM52.AutoSize = True
        Me.RadioButtonM52.Location = New System.Drawing.Point(346, 173)
        Me.RadioButtonM52.Name = "RadioButtonM52"
        Me.RadioButtonM52.Size = New System.Drawing.Size(118, 19)
        Me.RadioButtonM52.TabIndex = 41
        Me.RadioButtonM52.TabStop = True
        Me.RadioButtonM52.Text = "RadioButtonM52"
        Me.RadioButtonM52.UseVisualStyleBackColor = True
        '
        'RadioButtonS52
        '
        Me.RadioButtonS52.AutoSize = True
        Me.RadioButtonS52.Location = New System.Drawing.Point(174, 173)
        Me.RadioButtonS52.Name = "RadioButtonS52"
        Me.RadioButtonS52.Size = New System.Drawing.Size(115, 19)
        Me.RadioButtonS52.TabIndex = 40
        Me.RadioButtonS52.TabStop = True
        Me.RadioButtonS52.Text = "RadioButtonS52"
        Me.RadioButtonS52.UseVisualStyleBackColor = True
        '
        'RadioButtonM43
        '
        Me.RadioButtonM43.AutoSize = True
        Me.RadioButtonM43.Location = New System.Drawing.Point(346, 131)
        Me.RadioButtonM43.Name = "RadioButtonM43"
        Me.RadioButtonM43.Size = New System.Drawing.Size(118, 19)
        Me.RadioButtonM43.TabIndex = 39
        Me.RadioButtonM43.TabStop = True
        Me.RadioButtonM43.Text = "RadioButtonM43"
        Me.RadioButtonM43.UseVisualStyleBackColor = True
        '
        'RadioButtonS43
        '
        Me.RadioButtonS43.AutoSize = True
        Me.RadioButtonS43.Location = New System.Drawing.Point(174, 131)
        Me.RadioButtonS43.Name = "RadioButtonS43"
        Me.RadioButtonS43.Size = New System.Drawing.Size(115, 19)
        Me.RadioButtonS43.TabIndex = 38
        Me.RadioButtonS43.TabStop = True
        Me.RadioButtonS43.Text = "RadioButtonS43"
        Me.RadioButtonS43.UseVisualStyleBackColor = True
        '
        'RadioButtonM38
        '
        Me.RadioButtonM38.AutoSize = True
        Me.RadioButtonM38.Location = New System.Drawing.Point(346, 87)
        Me.RadioButtonM38.Name = "RadioButtonM38"
        Me.RadioButtonM38.Size = New System.Drawing.Size(118, 19)
        Me.RadioButtonM38.TabIndex = 37
        Me.RadioButtonM38.TabStop = True
        Me.RadioButtonM38.Text = "RadioButtonM38"
        Me.RadioButtonM38.UseVisualStyleBackColor = True
        '
        'RadioButtonS38
        '
        Me.RadioButtonS38.AutoSize = True
        Me.RadioButtonS38.Location = New System.Drawing.Point(174, 87)
        Me.RadioButtonS38.Name = "RadioButtonS38"
        Me.RadioButtonS38.Size = New System.Drawing.Size(115, 19)
        Me.RadioButtonS38.TabIndex = 36
        Me.RadioButtonS38.TabStop = True
        Me.RadioButtonS38.Text = "RadioButtonS38"
        Me.RadioButtonS38.UseVisualStyleBackColor = True
        '
        'RadioButtonM33
        '
        Me.RadioButtonM33.AutoSize = True
        Me.RadioButtonM33.Location = New System.Drawing.Point(346, 48)
        Me.RadioButtonM33.Name = "RadioButtonM33"
        Me.RadioButtonM33.Size = New System.Drawing.Size(118, 19)
        Me.RadioButtonM33.TabIndex = 35
        Me.RadioButtonM33.TabStop = True
        Me.RadioButtonM33.Text = "RadioButtonM33"
        Me.RadioButtonM33.UseVisualStyleBackColor = True
        '
        'RadioButtonS33
        '
        Me.RadioButtonS33.AutoSize = True
        Me.RadioButtonS33.Location = New System.Drawing.Point(174, 48)
        Me.RadioButtonS33.Name = "RadioButtonS33"
        Me.RadioButtonS33.Size = New System.Drawing.Size(115, 19)
        Me.RadioButtonS33.TabIndex = 34
        Me.RadioButtonS33.TabStop = True
        Me.RadioButtonS33.Text = "RadioButtonS33"
        Me.RadioButtonS33.UseVisualStyleBackColor = True
        '
        'TextBox58
        '
        Me.TextBox58.Location = New System.Drawing.Point(24, 208)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(100, 21)
        Me.TextBox58.TabIndex = 33
        Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox57
        '
        Me.TextBox57.Location = New System.Drawing.Point(24, 172)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(100, 21)
        Me.TextBox57.TabIndex = 32
        Me.TextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox56
        '
        Me.TextBox56.Location = New System.Drawing.Point(24, 130)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(100, 21)
        Me.TextBox56.TabIndex = 31
        Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox55
        '
        Me.TextBox55.Location = New System.Drawing.Point(24, 86)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(100, 21)
        Me.TextBox55.TabIndex = 30
        Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox54
        '
        Me.TextBox54.Location = New System.Drawing.Point(24, 47)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(100, 21)
        Me.TextBox54.TabIndex = 29
        Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox53
        '
        Me.TextBox53.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "fol-Kosten", True))
        Me.TextBox53.Location = New System.Drawing.Point(293, 258)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(100, 21)
        Me.TextBox53.TabIndex = 28
        Me.TextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonFoSpeichern
        '
        Me.ButtonFoSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFoSpeichern.Location = New System.Drawing.Point(432, 250)
        Me.ButtonFoSpeichern.Name = "ButtonFoSpeichern"
        Me.ButtonFoSpeichern.Size = New System.Drawing.Size(100, 37)
        Me.ButtonFoSpeichern.TabIndex = 27
        Me.ButtonFoSpeichern.Text = "Speichern"
        Me.ButtonFoSpeichern.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(214, 261)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(60, 15)
        Me.Label36.TabIndex = 26
        Me.Label36.Text = "Prämie  €"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(343, 29)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(81, 15)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "Motoryachten"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(171, 29)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(81, 15)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "Segelyachten"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(21, 29)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 15)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Länge"
        '
        'TextBox59
        '
        Me.TextBox59.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdefol, "Laenge", True))
        Me.TextBox59.Location = New System.Drawing.Point(688, 368)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(100, 21)
        Me.TextBox59.TabIndex = 28
        '
        'bsYPdefol
        '
        Me.bsYPdefol.DataMember = "YPdefol"
        Me.bsYPdefol.DataSource = Me.dsVersicherung
        '
        'TextBox60
        '
        Me.TextBox60.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdefol, "Segel", True))
        Me.TextBox60.Location = New System.Drawing.Point(689, 394)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(100, 21)
        Me.TextBox60.TabIndex = 29
        '
        'TextBox61
        '
        Me.TextBox61.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdefol, "Motor", True))
        Me.TextBox61.Location = New System.Drawing.Point(691, 423)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(97, 21)
        Me.TextBox61.TabIndex = 30
        '
        'GroupBoxRue
        '
        Me.GroupBoxRue.Controls.Add(Me.TextBox69)
        Me.GroupBoxRue.Controls.Add(Me.TextBox68)
        Me.GroupBoxRue.Controls.Add(Me.TextBox67)
        Me.GroupBoxRue.Controls.Add(Me.TextBox66)
        Me.GroupBoxRue.Controls.Add(Me.TextBox65)
        Me.GroupBoxRue.Controls.Add(Me.TextBox64)
        Me.GroupBoxRue.Controls.Add(Me.TextBox63)
        Me.GroupBoxRue.Controls.Add(Me.RadioButton10)
        Me.GroupBoxRue.Controls.Add(Me.RadioButton9)
        Me.GroupBoxRue.Controls.Add(Me.TextBox62)
        Me.GroupBoxRue.Controls.Add(Me.Button1)
        Me.GroupBoxRue.Controls.Add(Me.Label44)
        Me.GroupBoxRue.Controls.Add(Me.Label43)
        Me.GroupBoxRue.Controls.Add(Me.Label42)
        Me.GroupBoxRue.Controls.Add(Me.Label41)
        Me.GroupBoxRue.Controls.Add(Me.Label40)
        Me.GroupBoxRue.Controls.Add(Me.Label39)
        Me.GroupBoxRue.Controls.Add(Me.Label38)
        Me.GroupBoxRue.Controls.Add(Me.Label37)
        Me.GroupBoxRue.Location = New System.Drawing.Point(703, 34)
        Me.GroupBoxRue.Name = "GroupBoxRue"
        Me.GroupBoxRue.Size = New System.Drawing.Size(570, 310)
        Me.GroupBoxRue.TabIndex = 31
        Me.GroupBoxRue.TabStop = False
        Me.GroupBoxRue.Text = "Charter Rücktritt Versicherung"
        '
        'TextBox69
        '
        Me.TextBox69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox69.Location = New System.Drawing.Point(168, 174)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(100, 21)
        Me.TextBox69.TabIndex = 56
        Me.TextBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox68
        '
        Me.TextBox68.Location = New System.Drawing.Point(168, 141)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(100, 21)
        Me.TextBox68.TabIndex = 55
        Me.TextBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox67
        '
        Me.TextBox67.Location = New System.Drawing.Point(168, 114)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(100, 21)
        Me.TextBox67.TabIndex = 54
        Me.TextBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox66
        '
        Me.TextBox66.Location = New System.Drawing.Point(168, 87)
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(100, 21)
        Me.TextBox66.TabIndex = 53
        '
        'TextBox65
        '
        Me.TextBox65.Location = New System.Drawing.Point(168, 61)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(100, 21)
        Me.TextBox65.TabIndex = 52
        '
        'TextBox64
        '
        Me.TextBox64.Location = New System.Drawing.Point(168, 36)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(100, 21)
        Me.TextBox64.TabIndex = 51
        '
        'TextBox63
        '
        Me.TextBox63.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeRue, "KostenPerzent", True))
        Me.TextBox63.Location = New System.Drawing.Point(357, 189)
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(33, 21)
        Me.TextBox63.TabIndex = 50
        Me.TextBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bsYPdeRue
        '
        Me.bsYPdeRue.DataMember = "YPdeRue"
        Me.bsYPdeRue.DataSource = Me.dsVersicherung
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(308, 218)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton10.TabIndex = 49
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "RadioButton10"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(308, 240)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(108, 19)
        Me.RadioButton9.TabIndex = 48
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Nicht versichert"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'TextBox62
        '
        Me.TextBox62.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "rue-Kosten", True))
        Me.TextBox62.Location = New System.Drawing.Point(308, 265)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(100, 21)
        Me.TextBox62.TabIndex = 47
        Me.TextBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(447, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(242, 268)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(60, 15)
        Me.Label44.TabIndex = 45
        Me.Label44.Text = "Prämie  €"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(305, 192)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(103, 15)
        Me.Label43.TabIndex = 6
        Me.Label43.Text = "Prämie               %"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(32, 177)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(110, 15)
        Me.Label42.TabIndex = 5
        Me.Label42.Text = "= Gesamtkosten"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(32, 144)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(98, 15)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "+ weitere Kosten"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(32, 117)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(83, 15)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "Charterkosten"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(32, 90)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(60, 15)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "Törnende"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(32, 64)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(70, 15)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Törnbeginn"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(32, 38)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(130, 15)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Anzahl Crewmitglieder"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(21, 70)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(123, 15)
        Me.Label45.TabIndex = 32
        Me.Label45.Text = "Versicherungsbeginn"
        '
        'TextBox71
        '
        Me.TextBox71.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVersicherter, "Abschlussdatum", True))
        Me.TextBox71.Location = New System.Drawing.Point(166, 67)
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(70, 21)
        Me.TextBox71.TabIndex = 33
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(331, 70)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(36, 15)
        Me.Label46.TabIndex = 34
        Me.Label46.Text = "Ende"
        '
        'TextBox72
        '
        Me.TextBox72.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVersicherter, "GueltigBis", True))
        Me.TextBox72.Location = New System.Drawing.Point(438, 67)
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New System.Drawing.Size(70, 21)
        Me.TextBox72.TabIndex = 35
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsToernname
        Me.DataGridView3.Location = New System.Drawing.Point(334, 650)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(570, 150)
        Me.DataGridView3.TabIndex = 36
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Width = 200
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
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernDataGridViewTextBoxColumn, Me.CrewanzahlDataGridViewTextBoxColumn, Me.ToernanfangDataGridViewTextBoxColumn, Me.ToernendeDataGridViewTextBoxColumn, Me.Charterkosten, Me.Flugpreis})
        Me.DataGridView2.DataSource = Me.bsToernKalkulation
        Me.DataGridView2.Location = New System.Drawing.Point(649, 445)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(569, 134)
        Me.DataGridView2.TabIndex = 37
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
        '
        'CrewanzahlDataGridViewTextBoxColumn
        '
        Me.CrewanzahlDataGridViewTextBoxColumn.DataPropertyName = "Crewanzahl"
        Me.CrewanzahlDataGridViewTextBoxColumn.HeaderText = "Crewanzahl"
        Me.CrewanzahlDataGridViewTextBoxColumn.Name = "CrewanzahlDataGridViewTextBoxColumn"
        '
        'ToernanfangDataGridViewTextBoxColumn
        '
        Me.ToernanfangDataGridViewTextBoxColumn.DataPropertyName = "Toernanfang"
        Me.ToernanfangDataGridViewTextBoxColumn.HeaderText = "Toernanfang"
        Me.ToernanfangDataGridViewTextBoxColumn.Name = "ToernanfangDataGridViewTextBoxColumn"
        '
        'ToernendeDataGridViewTextBoxColumn
        '
        Me.ToernendeDataGridViewTextBoxColumn.DataPropertyName = "Toernende"
        Me.ToernendeDataGridViewTextBoxColumn.HeaderText = "Toernende"
        Me.ToernendeDataGridViewTextBoxColumn.Name = "ToernendeDataGridViewTextBoxColumn"
        '
        'Charterkosten
        '
        Me.Charterkosten.DataPropertyName = "Charterkosten"
        Me.Charterkosten.HeaderText = "Charterkosten"
        Me.Charterkosten.Name = "Charterkosten"
        '
        'Flugpreis
        '
        Me.Flugpreis.DataPropertyName = "Flugpreis"
        Me.Flugpreis.HeaderText = "Flugpreis"
        Me.Flugpreis.Name = "Flugpreis"
        '
        'bsToernKalkulation
        '
        Me.bsToernKalkulation.DataMember = "ToernKalkulation"
        Me.bsToernKalkulation.DataSource = Me.dsToernverwaltung
        '
        'taToernKalkulation
        '
        Me.taToernKalkulation.ClearBeforeFill = True
        '
        'TextBox73
        '
        Me.TextBox73.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Toernbezeichnung", True))
        Me.TextBox73.Location = New System.Drawing.Point(826, 373)
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(110, 21)
        Me.TextBox73.TabIndex = 38
        '
        'TextBox74
        '
        Me.TextBox74.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toern", True))
        Me.TextBox74.Location = New System.Drawing.Point(826, 411)
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New System.Drawing.Size(100, 21)
        Me.TextBox74.TabIndex = 39
        '
        'taVertrag
        '
        Me.taVertrag.ClearBeforeFill = True
        '
        'taYPdehaf
        '
        Me.taYPdehaf.ClearBeforeFill = True
        '
        'taVersicherter
        '
        Me.taVersicherter.ClearBeforeFill = True
        '
        'taYPdeUnf
        '
        Me.taYPdeUnf.ClearBeforeFill = True
        '
        'ta1YPderech
        '
        Me.ta1YPderech.ClearBeforeFill = True
        '
        'taYPdekau
        '
        Me.taYPdekau.ClearBeforeFill = True
        '
        'taYPdefol
        '
        Me.taYPdefol.ClearBeforeFill = True
        '
        'taYPdeRue
        '
        Me.taYPdeRue.ClearBeforeFill = True
        '
        'TextBox80
        '
        Me.TextBox80.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "unf-Nr", True))
        Me.TextBox80.Location = New System.Drawing.Point(2006, 360)
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New System.Drawing.Size(100, 21)
        Me.TextBox80.TabIndex = 40
        '
        'TextBox81
        '
        Me.TextBox81.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "fol-Nr", True))
        Me.TextBox81.Location = New System.Drawing.Point(1428, 469)
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New System.Drawing.Size(90, 21)
        Me.TextBox81.TabIndex = 41
        '
        'TextBox82
        '
        Me.TextBox82.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVertrag, "haf-Nr", True))
        Me.TextBox82.Location = New System.Drawing.Point(2573, 688)
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New System.Drawing.Size(100, 21)
        Me.TextBox82.TabIndex = 42
        '
        'Versicherter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 481)
        Me.Controls.Add(Me.TextBox82)
        Me.Controls.Add(Me.TextBox81)
        Me.Controls.Add(Me.TextBox80)
        Me.Controls.Add(Me.TextBox79)
        Me.Controls.Add(Me.GroupBoxUnf)
        Me.Controls.Add(Me.TextBox74)
        Me.Controls.Add(Me.TextBox73)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.TextBox72)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.TextBox71)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.TextBox61)
        Me.Controls.Add(Me.TextBox60)
        Me.Controls.Add(Me.TextBox59)
        Me.Controls.Add(Me.GroupBoxFol)
        Me.Controls.Add(Me.TextBox52)
        Me.Controls.Add(Me.TextBox51)
        Me.Controls.Add(Me.groupboxkau)
        Me.Controls.Add(Me.GroupBoxRech)
        Me.Controls.Add(Me.TextBox40)
        Me.Controls.Add(Me.TextBox39)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.TextBox37)
        Me.Controls.Add(Me.TextBox36)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonNameSpeichern)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.GroupBoxHaf)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBoxRue)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Versicherter"
        Me.Text = "Versicherungsnehmer"
        CType(Me.bsVersicherter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVertrag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxHaf.ResumeLayout(False)
        Me.GroupBoxHaf.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsYPdehaf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBoxUnf.ResumeLayout(False)
        Me.GroupBoxUnf.PerformLayout()
        CType(Me.bsYPdeUnf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRech.ResumeLayout(False)
        Me.GroupBoxRech.PerformLayout()
        CType(Me.bsYPderech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxkau.ResumeLayout(False)
        Me.groupboxkau.PerformLayout()
        CType(Me.bsYPdekau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFol.ResumeLayout(False)
        Me.GroupBoxFol.PerformLayout()
        CType(Me.bsYPdefol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRue.ResumeLayout(False)
        Me.GroupBoxRue.PerformLayout()
        CType(Me.bsYPdeRue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonRue As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFol As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonKau As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRech As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUnf As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonHafBe As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxHaf As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonM10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonM7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonM5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS5 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dsVersicherung As WindowsApplication1.VersicherungDataSet
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents bsVertrag As System.Windows.Forms.BindingSource
    Friend WithEvents taVertrag As WindowsApplication1.VersicherungDataSetTableAdapters.VertragTableAdapter
    Friend WithEvents bsYPdehaf As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdehaf As WindowsApplication1.VersicherungDataSetTableAdapters.YPdehafTableAdapter
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonHAFSpeichern As System.Windows.Forms.Button
    Friend WithEvents bsVersicherter As System.Windows.Forms.BindingSource
    Friend WithEvents taVersicherter As WindowsApplication1.VersicherungDataSetTableAdapters.VersicherterTableAdapter
    Friend WithEvents ButtonNameSpeichern As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents VersicherterName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Polizze As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersicherterNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolizzeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxUnf As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonUnfSpeichern As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents RadioButton770 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton510 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton380 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton230 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton155 As System.Windows.Forms.RadioButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents bsYPdeUnf As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdeUnf As WindowsApplication1.VersicherungDataSetTableAdapters.YPdeUnfTableAdapter
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxRech As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ButtonrechSpeichern As System.Windows.Forms.Button
    Friend WithEvents RadioButtonRekost As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents taYPdeRech As WindowsApplication1.VersicherungDataSetTableAdapters.YPdeRechTableAdapter
    Friend WithEvents groupboxkau As System.Windows.Forms.GroupBox
    Friend WithEvents bsYPderech As System.Windows.Forms.BindingSource
    Friend WithEvents ta1YPderech As WindowsApplication1.VersicherungDataSetTableAdapters.YPderechTableAdapter
    Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonKautionSpeichern As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents bsYPdekau As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdekau As WindowsApplication1.VersicherungDataSetTableAdapters.YPdekauTableAdapter
    Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxFol As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonM63 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS63 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonM52 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS52 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonM43 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS43 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonM38 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS38 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonM33 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonS33 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox55 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox54 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox53 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonFoSpeichern As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents bsYPdefol As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdefol As WindowsApplication1.VersicherungDataSetTableAdapters.YPdefolTableAdapter
    Friend WithEvents TextBox59 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox60 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox61 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxRue As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox69 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox68 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox67 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox66 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox65 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox64 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox63 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox62 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents TextBox71 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TextBox72 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsToernKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taToernKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrewanzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernanfangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernendeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charterkosten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Flugpreis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsYPdeRue As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdeRue As WindowsApplication1.VersicherungDataSetTableAdapters.YPdeRueTableAdapter
    Friend WithEvents TextBox73 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox74 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton14 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton18 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox78 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton17 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox77 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox76 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton15 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox75 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox79 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TextBox80 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox81 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox82 As System.Windows.Forms.TextBox
End Class
