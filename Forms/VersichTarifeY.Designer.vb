<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VersichTarifeY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VersichTarifeY))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonRue = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFol = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKau = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRech = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUnf = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHafBe = New System.Windows.Forms.RadioButton()
        Me.GroupBoxRue = New System.Windows.Forms.GroupBox()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
        Me.bsYPdeRue = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsVersicherung = New WindowsApplication1.VersicherungDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GroupBoxFol = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.ButtonFoSpeichern = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBoxUnf = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBoxHaf = New System.Windows.Forms.GroupBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.ButtonHAFSpeichern = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.GroupBoxRech = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox83 = New System.Windows.Forms.TextBox()
        Me.bsYPderech = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonrechSpeichern = New System.Windows.Forms.Button()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsYPdehaf = New System.Windows.Forms.BindingSource(Me.components)
        Me.taYPdehaf = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdehafTableAdapter()
        Me.bsYPdekau = New System.Windows.Forms.BindingSource(Me.components)
        Me.taYPdekau = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdekauTableAdapter()
        Me.taYPdeRue = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdeRueTableAdapter()
        Me.bsYPdeUnf = New System.Windows.Forms.BindingSource(Me.components)
        Me.taYPdeUnf = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdeUnfTableAdapter()
        Me.bsYPdefol = New System.Windows.Forms.BindingSource(Me.components)
        Me.taYPdefol = New WindowsApplication1.VersicherungDataSetTableAdapters.YPdefolTableAdapter()
        Me.taYPderech = New WindowsApplication1.VersicherungDataSetTableAdapters.YPderechTableAdapter()
        Me.groupboxkau = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox78 = New System.Windows.Forms.TextBox()
        Me.TextBox77 = New System.Windows.Forms.TextBox()
        Me.TextBox76 = New System.Windows.Forms.TextBox()
        Me.TextBox75 = New System.Windows.Forms.TextBox()
        Me.ButtonKautionSpeichern = New System.Windows.Forms.Button()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.TextBox74 = New System.Windows.Forms.TextBox()
        Me.TextBox79 = New System.Windows.Forms.TextBox()
        Me.TextBox80 = New System.Windows.Forms.TextBox()
        Me.TextBox81 = New System.Windows.Forms.TextBox()
        Me.TextBox82 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxRue.SuspendLayout()
        CType(Me.bsYPdeRue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFol.SuspendLayout()
        Me.GroupBoxUnf.SuspendLayout()
        Me.GroupBoxHaf.SuspendLayout()
        Me.GroupBoxRech.SuspendLayout()
        CType(Me.bsYPderech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsYPdehaf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsYPdekau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsYPdeUnf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsYPdefol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxkau.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonRue)
        Me.GroupBox1.Controls.Add(Me.RadioButtonFol)
        Me.GroupBox1.Controls.Add(Me.RadioButtonKau)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRech)
        Me.GroupBox1.Controls.Add(Me.RadioButtonUnf)
        Me.GroupBox1.Controls.Add(Me.RadioButtonHafBe)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 270)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chartertarife"
        '
        'RadioButtonRue
        '
        Me.RadioButtonRue.AutoSize = True
        Me.RadioButtonRue.Location = New System.Drawing.Point(66, 224)
        Me.RadioButtonRue.Name = "RadioButtonRue"
        Me.RadioButtonRue.Size = New System.Drawing.Size(207, 17)
        Me.RadioButtonRue.TabIndex = 12
        Me.RadioButtonRue.TabStop = True
        Me.RadioButtonRue.Text = "Charter Rücktritt Versicherung für Törn"
        Me.RadioButtonRue.UseVisualStyleBackColor = True
        '
        'RadioButtonFol
        '
        Me.RadioButtonFol.AutoSize = True
        Me.RadioButtonFol.Location = New System.Drawing.Point(66, 184)
        Me.RadioButtonFol.Name = "RadioButtonFol"
        Me.RadioButtonFol.Size = New System.Drawing.Size(194, 17)
        Me.RadioButtonFol.TabIndex = 11
        Me.RadioButtonFol.TabStop = True
        Me.RadioButtonFol.Text = "Charter Folgeschaden Versicherung"
        Me.RadioButtonFol.UseVisualStyleBackColor = True
        '
        'RadioButtonKau
        '
        Me.RadioButtonKau.AutoSize = True
        Me.RadioButtonKau.Location = New System.Drawing.Point(66, 141)
        Me.RadioButtonKau.Name = "RadioButtonKau"
        Me.RadioButtonKau.Size = New System.Drawing.Size(163, 17)
        Me.RadioButtonKau.TabIndex = 10
        Me.RadioButtonKau.TabStop = True
        Me.RadioButtonKau.Text = "Charter Kaution Versicherung"
        Me.RadioButtonKau.UseVisualStyleBackColor = True
        '
        'RadioButtonRech
        '
        Me.RadioButtonRech.AutoSize = True
        Me.RadioButtonRech.Location = New System.Drawing.Point(66, 105)
        Me.RadioButtonRech.Name = "RadioButtonRech"
        Me.RadioButtonRech.Size = New System.Drawing.Size(190, 17)
        Me.RadioButtonRech.TabIndex = 9
        Me.RadioButtonRech.TabStop = True
        Me.RadioButtonRech.Text = "Skipper Rechtsschutzversicherung"
        Me.RadioButtonRech.UseVisualStyleBackColor = True
        '
        'RadioButtonUnf
        '
        Me.RadioButtonUnf.AutoSize = True
        Me.RadioButtonUnf.Location = New System.Drawing.Point(66, 69)
        Me.RadioButtonUnf.Name = "RadioButtonUnf"
        Me.RadioButtonUnf.Size = New System.Drawing.Size(152, 17)
        Me.RadioButtonUnf.TabIndex = 8
        Me.RadioButtonUnf.TabStop = True
        Me.RadioButtonUnf.Text = "Skipper Unfallversicherung"
        Me.RadioButtonUnf.UseVisualStyleBackColor = True
        '
        'RadioButtonHafBe
        '
        Me.RadioButtonHafBe.AutoSize = True
        Me.RadioButtonHafBe.Location = New System.Drawing.Point(66, 30)
        Me.RadioButtonHafBe.Name = "RadioButtonHafBe"
        Me.RadioButtonHafBe.Size = New System.Drawing.Size(276, 17)
        Me.RadioButtonHafBe.TabIndex = 7
        Me.RadioButtonHafBe.TabStop = True
        Me.RadioButtonHafBe.Text = "Skipper Haftpflicht- und Beschlagnahmeversicherung"
        Me.RadioButtonHafBe.UseVisualStyleBackColor = True
        '
        'GroupBoxRue
        '
        Me.GroupBoxRue.Controls.Add(Me.TextBox63)
        Me.GroupBoxRue.Controls.Add(Me.Button1)
        Me.GroupBoxRue.Controls.Add(Me.Label43)
        Me.GroupBoxRue.Controls.Add(Me.Label42)
        Me.GroupBoxRue.Location = New System.Drawing.Point(640, 22)
        Me.GroupBoxRue.Name = "GroupBoxRue"
        Me.GroupBoxRue.Size = New System.Drawing.Size(530, 270)
        Me.GroupBoxRue.TabIndex = 32
        Me.GroupBoxRue.TabStop = False
        Me.GroupBoxRue.Text = "Chartertarif Rücktritt Versicherung"
        '
        'TextBox63
        '
        Me.TextBox63.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeRue, "KostenPerzent", True))
        Me.TextBox63.Location = New System.Drawing.Point(164, 117)
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(33, 20)
        Me.TextBox63.TabIndex = 50
        Me.TextBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bsYPdeRue
        '
        Me.bsYPdeRue.DataMember = "YPdeRue"
        Me.bsYPdeRue.DataSource = Me.dsVersicherung
        '
        'dsVersicherung
        '
        Me.dsVersicherung.DataSetName = "VersicherungDataSet"
        Me.dsVersicherung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(404, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(115, 119)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(53, 15)
        Me.Label43.TabIndex = 6
        Me.Label43.Text = "Prämie  "
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(203, 117)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(149, 15)
        Me.Label42.TabIndex = 5
        Me.Label42.Text = "% von den  Gesamtkosten"
        '
        'GroupBoxFol
        '
        Me.GroupBoxFol.Controls.Add(Me.TextBox6)
        Me.GroupBoxFol.Controls.Add(Me.TextBox7)
        Me.GroupBoxFol.Controls.Add(Me.TextBox8)
        Me.GroupBoxFol.Controls.Add(Me.TextBox9)
        Me.GroupBoxFol.Controls.Add(Me.TextBox10)
        Me.GroupBoxFol.Controls.Add(Me.TextBox1)
        Me.GroupBoxFol.Controls.Add(Me.TextBox2)
        Me.GroupBoxFol.Controls.Add(Me.TextBox3)
        Me.GroupBoxFol.Controls.Add(Me.TextBox4)
        Me.GroupBoxFol.Controls.Add(Me.TextBox5)
        Me.GroupBoxFol.Controls.Add(Me.TextBox58)
        Me.GroupBoxFol.Controls.Add(Me.TextBox57)
        Me.GroupBoxFol.Controls.Add(Me.TextBox56)
        Me.GroupBoxFol.Controls.Add(Me.TextBox55)
        Me.GroupBoxFol.Controls.Add(Me.TextBox54)
        Me.GroupBoxFol.Controls.Add(Me.ButtonFoSpeichern)
        Me.GroupBoxFol.Controls.Add(Me.Label35)
        Me.GroupBoxFol.Controls.Add(Me.Label34)
        Me.GroupBoxFol.Controls.Add(Me.Label33)
        Me.GroupBoxFol.Location = New System.Drawing.Point(21, 426)
        Me.GroupBoxFol.Name = "GroupBoxFol"
        Me.GroupBoxFol.Size = New System.Drawing.Size(530, 270)
        Me.GroupBoxFol.TabIndex = 33
        Me.GroupBoxFol.TabStop = False
        Me.GroupBoxFol.Text = "Chartertarife Folgeschadenversicherung"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(356, 151)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 43
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(356, 125)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 42
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(356, 99)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 41
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(356, 73)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 40
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(356, 47)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 39
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(186, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(186, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(186, 99)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 36
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(186, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 35
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(186, 47)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 34
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox58
        '
        Me.TextBox58.Location = New System.Drawing.Point(24, 151)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(100, 20)
        Me.TextBox58.TabIndex = 33
        Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox57
        '
        Me.TextBox57.Location = New System.Drawing.Point(24, 125)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(100, 20)
        Me.TextBox57.TabIndex = 32
        Me.TextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox56
        '
        Me.TextBox56.Location = New System.Drawing.Point(24, 99)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(100, 20)
        Me.TextBox56.TabIndex = 31
        Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox55
        '
        Me.TextBox55.Location = New System.Drawing.Point(24, 73)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(100, 20)
        Me.TextBox55.TabIndex = 30
        Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox54
        '
        Me.TextBox54.Location = New System.Drawing.Point(24, 47)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(100, 20)
        Me.TextBox54.TabIndex = 29
        Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonFoSpeichern
        '
        Me.ButtonFoSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFoSpeichern.Location = New System.Drawing.Point(414, 218)
        Me.ButtonFoSpeichern.Name = "ButtonFoSpeichern"
        Me.ButtonFoSpeichern.Size = New System.Drawing.Size(100, 37)
        Me.ButtonFoSpeichern.TabIndex = 27
        Me.ButtonFoSpeichern.Text = "Speichern"
        Me.ButtonFoSpeichern.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(353, 29)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(81, 13)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "Motoryachten €"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(183, 29)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(81, 13)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "Segelyachten €"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(21, 29)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Länge fuss"
        '
        'GroupBoxUnf
        '
        Me.GroupBoxUnf.Controls.Add(Me.Label1)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox11)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox12)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox13)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox14)
        Me.GroupBoxUnf.Controls.Add(Me.TextBox15)
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
        Me.GroupBoxUnf.Controls.Add(Me.Label23)
        Me.GroupBoxUnf.Controls.Add(Me.Label22)
        Me.GroupBoxUnf.Controls.Add(Me.Label21)
        Me.GroupBoxUnf.Location = New System.Drawing.Point(1191, 22)
        Me.GroupBoxUnf.Name = "GroupBoxUnf"
        Me.GroupBoxUnf.Size = New System.Drawing.Size(530, 270)
        Me.GroupBoxUnf.TabIndex = 34
        Me.GroupBoxUnf.TabStop = False
        Me.GroupBoxUnf.Text = "Skipper Unfall Versicherung"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tarif €"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(404, 160)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 29
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(404, 134)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 28
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(404, 105)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 27
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(404, 76)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 26
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(404, 50)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 25
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(277, 160)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(100, 20)
        Me.TextBox34.TabIndex = 24
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(158, 160)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(100, 20)
        Me.TextBox33.TabIndex = 23
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(42, 160)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(100, 20)
        Me.TextBox32.TabIndex = 22
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(277, 134)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(100, 20)
        Me.TextBox31.TabIndex = 21
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(158, 134)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(100, 20)
        Me.TextBox30.TabIndex = 20
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(42, 134)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(100, 20)
        Me.TextBox29.TabIndex = 19
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(277, 105)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(100, 20)
        Me.TextBox28.TabIndex = 18
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(158, 105)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(100, 20)
        Me.TextBox27.TabIndex = 17
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(42, 106)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(100, 20)
        Me.TextBox26.TabIndex = 16
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(277, 76)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(100, 20)
        Me.TextBox25.TabIndex = 15
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(158, 76)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 14
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(42, 76)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 20)
        Me.TextBox23.TabIndex = 13
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(277, 50)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 20)
        Me.TextBox22.TabIndex = 12
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(158, 50)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 20)
        Me.TextBox21.TabIndex = 11
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(42, 50)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 10
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonUnfSpeichern
        '
        Me.ButtonUnfSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnfSpeichern.Location = New System.Drawing.Point(404, 213)
        Me.ButtonUnfSpeichern.Name = "ButtonUnfSpeichern"
        Me.ButtonUnfSpeichern.Size = New System.Drawing.Size(100, 37)
        Me.ButtonUnfSpeichern.TabIndex = 9
        Me.ButtonUnfSpeichern.Text = "Speichern"
        Me.ButtonUnfSpeichern.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(274, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Tod €"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(155, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Bergekosten €"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(39, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Invalidität €"
        '
        'GroupBoxHaf
        '
        Me.GroupBoxHaf.Controls.Add(Me.TextBox40)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox37)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox38)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox39)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox19)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox35)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox36)
        Me.GroupBoxHaf.Controls.Add(Me.ButtonHAFSpeichern)
        Me.GroupBoxHaf.Controls.Add(Me.Label19)
        Me.GroupBoxHaf.Controls.Add(Me.Label18)
        Me.GroupBoxHaf.Controls.Add(Me.Label17)
        Me.GroupBoxHaf.Controls.Add(Me.Label16)
        Me.GroupBoxHaf.Controls.Add(Me.Label15)
        Me.GroupBoxHaf.Controls.Add(Me.Label14)
        Me.GroupBoxHaf.Controls.Add(Me.Label13)
        Me.GroupBoxHaf.Controls.Add(Me.Label12)
        Me.GroupBoxHaf.Controls.Add(Me.Label11)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox16)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox17)
        Me.GroupBoxHaf.Controls.Add(Me.TextBox18)
        Me.GroupBoxHaf.Location = New System.Drawing.Point(1191, 327)
        Me.GroupBoxHaf.Name = "GroupBoxHaf"
        Me.GroupBoxHaf.Size = New System.Drawing.Size(530, 270)
        Me.GroupBoxHaf.TabIndex = 35
        Me.GroupBoxHaf.TabStop = False
        Me.GroupBoxHaf.Text = "Skipper Haftpflicht- und Beschlagnahmeversicherung"
        '
        'TextBox40
        '
        Me.TextBox40.Location = New System.Drawing.Point(44, 203)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(457, 20)
        Me.TextBox40.TabIndex = 33
        '
        'TextBox37
        '
        Me.TextBox37.Location = New System.Drawing.Point(319, 164)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(67, 20)
        Me.TextBox37.TabIndex = 32
        Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox38
        '
        Me.TextBox38.Location = New System.Drawing.Point(320, 120)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(66, 20)
        Me.TextBox38.TabIndex = 31
        Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox39
        '
        Me.TextBox39.Location = New System.Drawing.Point(319, 78)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(67, 20)
        Me.TextBox39.TabIndex = 30
        Me.TextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(188, 164)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(67, 20)
        Me.TextBox19.TabIndex = 29
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(189, 120)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(66, 20)
        Me.TextBox35.TabIndex = 28
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox36
        '
        Me.TextBox36.Location = New System.Drawing.Point(188, 78)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(67, 20)
        Me.TextBox36.TabIndex = 27
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonHAFSpeichern
        '
        Me.ButtonHAFSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHAFSpeichern.Location = New System.Drawing.Point(407, 227)
        Me.ButtonHAFSpeichern.Name = "ButtonHAFSpeichern"
        Me.ButtonHAFSpeichern.Size = New System.Drawing.Size(97, 35)
        Me.ButtonHAFSpeichern.TabIndex = 26
        Me.ButtonHAFSpeichern.Text = "Speichern"
        Me.ButtonHAFSpeichern.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(89, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Mio. €"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(89, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Mio. €"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(89, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Mio. €"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Sachschäden"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(36, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = " Personen- und"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(316, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Motoryachten  €"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(186, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Segelyachten  €"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(442, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Mitversichert ist das Beschlagnahmerisiko bis € 52.000,- gemäß YACHT-POOL Bedingu" & _
    "ngen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Deckung für"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(43, 164)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(44, 20)
        Me.TextBox16.TabIndex = 2
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(44, 120)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(43, 20)
        Me.TextBox17.TabIndex = 1
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(43, 78)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(44, 20)
        Me.TextBox18.TabIndex = 0
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBoxRech
        '
        Me.GroupBoxRech.Controls.Add(Me.Label2)
        Me.GroupBoxRech.Controls.Add(Me.TextBox83)
        Me.GroupBoxRech.Controls.Add(Me.ButtonrechSpeichern)
        Me.GroupBoxRech.Controls.Add(Me.TextBox41)
        Me.GroupBoxRech.Controls.Add(Me.Label26)
        Me.GroupBoxRech.Controls.Add(Me.Label25)
        Me.GroupBoxRech.Location = New System.Drawing.Point(640, 327)
        Me.GroupBoxRech.Name = "GroupBoxRech"
        Me.GroupBoxRech.Size = New System.Drawing.Size(530, 270)
        Me.GroupBoxRech.TabIndex = 36
        Me.GroupBoxRech.TabStop = False
        Me.GroupBoxRech.Text = "Skipper Rechtschutz Versicherung"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tarif €:"
        '
        'TextBox83
        '
        Me.TextBox83.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPderech, "Kosten", True))
        Me.TextBox83.Location = New System.Drawing.Point(405, 95)
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Size = New System.Drawing.Size(98, 20)
        Me.TextBox83.TabIndex = 5
        '
        'bsYPderech
        '
        Me.bsYPderech.DataMember = "YPderech"
        Me.bsYPderech.DataSource = Me.dsVersicherung
        '
        'ButtonrechSpeichern
        '
        Me.ButtonrechSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonrechSpeichern.Location = New System.Drawing.Point(404, 224)
        Me.ButtonrechSpeichern.Name = "ButtonrechSpeichern"
        Me.ButtonrechSpeichern.Size = New System.Drawing.Size(100, 32)
        Me.ButtonrechSpeichern.TabIndex = 4
        Me.ButtonrechSpeichern.Text = "Speichern"
        Me.ButtonrechSpeichern.UseVisualStyleBackColor = True
        '
        'TextBox41
        '
        Me.TextBox41.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPderech, "Deckung", True))
        Me.TextBox41.Location = New System.Drawing.Point(404, 63)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(100, 20)
        Me.TextBox41.TabIndex = 2
        Me.TextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(22, 63)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(341, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Geltungsbereich weltweit. Versicherungssumme je Schadensereignis €:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(22, 37)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(329, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Alle Crewmitglieder sind in den Versicherungsschutz eingeschlossen."
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsYPderech
        Me.DataGridView1.Location = New System.Drawing.Point(1777, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 37
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'bsYPdehaf
        '
        Me.bsYPdehaf.DataMember = "YPdehaf"
        Me.bsYPdehaf.DataSource = Me.dsVersicherung
        '
        'taYPdehaf
        '
        Me.taYPdehaf.ClearBeforeFill = True
        '
        'bsYPdekau
        '
        Me.bsYPdekau.DataMember = "YPdekau"
        Me.bsYPdekau.DataSource = Me.dsVersicherung
        '
        'taYPdekau
        '
        Me.taYPdekau.ClearBeforeFill = True
        '
        'taYPdeRue
        '
        Me.taYPdeRue.ClearBeforeFill = True
        '
        'bsYPdeUnf
        '
        Me.bsYPdeUnf.DataMember = "YPdeUnf"
        Me.bsYPdeUnf.DataSource = Me.dsVersicherung
        '
        'taYPdeUnf
        '
        Me.taYPdeUnf.ClearBeforeFill = True
        '
        'bsYPdefol
        '
        Me.bsYPdefol.DataMember = "YPdefol"
        Me.bsYPdefol.DataSource = Me.dsVersicherung
        '
        'taYPdefol
        '
        Me.taYPdefol.ClearBeforeFill = True
        '
        'taYPderech
        '
        Me.taYPderech.ClearBeforeFill = True
        '
        'groupboxkau
        '
        Me.groupboxkau.Controls.Add(Me.Label3)
        Me.groupboxkau.Controls.Add(Me.TextBox53)
        Me.groupboxkau.Controls.Add(Me.TextBox59)
        Me.groupboxkau.Controls.Add(Me.TextBox60)
        Me.groupboxkau.Controls.Add(Me.TextBox61)
        Me.groupboxkau.Controls.Add(Me.TextBox62)
        Me.groupboxkau.Controls.Add(Me.TextBox64)
        Me.groupboxkau.Controls.Add(Me.TextBox65)
        Me.groupboxkau.Controls.Add(Me.TextBox42)
        Me.groupboxkau.Controls.Add(Me.TextBox50)
        Me.groupboxkau.Controls.Add(Me.TextBox51)
        Me.groupboxkau.Controls.Add(Me.TextBox52)
        Me.groupboxkau.Controls.Add(Me.Label47)
        Me.groupboxkau.Controls.Add(Me.TextBox78)
        Me.groupboxkau.Controls.Add(Me.TextBox77)
        Me.groupboxkau.Controls.Add(Me.TextBox76)
        Me.groupboxkau.Controls.Add(Me.TextBox75)
        Me.groupboxkau.Controls.Add(Me.ButtonKautionSpeichern)
        Me.groupboxkau.Controls.Add(Me.TextBox48)
        Me.groupboxkau.Controls.Add(Me.TextBox47)
        Me.groupboxkau.Controls.Add(Me.TextBox46)
        Me.groupboxkau.Controls.Add(Me.TextBox49)
        Me.groupboxkau.Controls.Add(Me.TextBox45)
        Me.groupboxkau.Controls.Add(Me.TextBox44)
        Me.groupboxkau.Controls.Add(Me.TextBox43)
        Me.groupboxkau.Controls.Add(Me.Label30)
        Me.groupboxkau.Location = New System.Drawing.Point(1746, 287)
        Me.groupboxkau.Name = "groupboxkau"
        Me.groupboxkau.Size = New System.Drawing.Size(530, 270)
        Me.groupboxkau.TabIndex = 38
        Me.groupboxkau.TabStop = False
        Me.groupboxkau.Text = "Charter Kautionsversicherung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Tarif €"
        '
        'TextBox53
        '
        Me.TextBox53.Location = New System.Drawing.Point(129, 212)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(80, 20)
        Me.TextBox53.TabIndex = 49
        Me.TextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox59
        '
        Me.TextBox59.Location = New System.Drawing.Point(129, 184)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(80, 20)
        Me.TextBox59.TabIndex = 48
        Me.TextBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox60
        '
        Me.TextBox60.Location = New System.Drawing.Point(129, 156)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(80, 20)
        Me.TextBox60.TabIndex = 47
        Me.TextBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox61
        '
        Me.TextBox61.Location = New System.Drawing.Point(129, 128)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(80, 20)
        Me.TextBox61.TabIndex = 46
        Me.TextBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox62
        '
        Me.TextBox62.Location = New System.Drawing.Point(129, 100)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(80, 20)
        Me.TextBox62.TabIndex = 45
        Me.TextBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox64
        '
        Me.TextBox64.Location = New System.Drawing.Point(129, 72)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(80, 20)
        Me.TextBox64.TabIndex = 44
        Me.TextBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox65
        '
        Me.TextBox65.Location = New System.Drawing.Point(129, 45)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(80, 20)
        Me.TextBox65.TabIndex = 43
        Me.TextBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(434, 99)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(77, 20)
        Me.TextBox42.TabIndex = 42
        Me.TextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox50
        '
        Me.TextBox50.Location = New System.Drawing.Point(434, 71)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(77, 20)
        Me.TextBox50.TabIndex = 41
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox51
        '
        Me.TextBox51.Location = New System.Drawing.Point(434, 44)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(77, 20)
        Me.TextBox51.TabIndex = 40
        Me.TextBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox52
        '
        Me.TextBox52.Location = New System.Drawing.Point(434, 128)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(77, 20)
        Me.TextBox52.TabIndex = 39
        Me.TextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(281, 135)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(41, 13)
        Me.Label47.TabIndex = 38
        Me.Label47.Text = "Andere"
        '
        'TextBox78
        '
        Me.TextBox78.Location = New System.Drawing.Point(328, 100)
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New System.Drawing.Size(100, 20)
        Me.TextBox78.TabIndex = 36
        Me.TextBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox77
        '
        Me.TextBox77.Location = New System.Drawing.Point(328, 72)
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New System.Drawing.Size(100, 20)
        Me.TextBox77.TabIndex = 34
        Me.TextBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox76
        '
        Me.TextBox76.Location = New System.Drawing.Point(328, 45)
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New System.Drawing.Size(100, 20)
        Me.TextBox76.TabIndex = 32
        Me.TextBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox75
        '
        Me.TextBox75.Location = New System.Drawing.Point(18, 212)
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New System.Drawing.Size(100, 20)
        Me.TextBox75.TabIndex = 30
        Me.TextBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonKautionSpeichern
        '
        Me.ButtonKautionSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKautionSpeichern.Location = New System.Drawing.Point(338, 208)
        Me.ButtonKautionSpeichern.Name = "ButtonKautionSpeichern"
        Me.ButtonKautionSpeichern.Size = New System.Drawing.Size(100, 37)
        Me.ButtonKautionSpeichern.TabIndex = 27
        Me.ButtonKautionSpeichern.Text = "Speichern"
        Me.ButtonKautionSpeichern.UseVisualStyleBackColor = True
        '
        'TextBox48
        '
        Me.TextBox48.Location = New System.Drawing.Point(18, 184)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(100, 20)
        Me.TextBox48.TabIndex = 8
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox47
        '
        Me.TextBox47.Location = New System.Drawing.Point(18, 156)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(100, 20)
        Me.TextBox47.TabIndex = 7
        Me.TextBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox46
        '
        Me.TextBox46.Location = New System.Drawing.Point(18, 128)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(100, 20)
        Me.TextBox46.TabIndex = 6
        Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox49
        '
        Me.TextBox49.Location = New System.Drawing.Point(328, 129)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(100, 20)
        Me.TextBox49.TabIndex = 9
        Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox45
        '
        Me.TextBox45.Location = New System.Drawing.Point(18, 100)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(100, 20)
        Me.TextBox45.TabIndex = 5
        Me.TextBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox44
        '
        Me.TextBox44.Location = New System.Drawing.Point(18, 72)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(100, 20)
        Me.TextBox44.TabIndex = 4
        Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox43
        '
        Me.TextBox43.Location = New System.Drawing.Point(18, 45)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(100, 20)
        Me.TextBox43.TabIndex = 3
        Me.TextBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(15, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(81, 13)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Kautionshöhe €"
        '
        'TextBox66
        '
        Me.TextBox66.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdekau, "Kaution", True))
        Me.TextBox66.Location = New System.Drawing.Point(2079, 572)
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(100, 20)
        Me.TextBox66.TabIndex = 39
        '
        'TextBox67
        '
        Me.TextBox67.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdekau, "Kosten", True))
        Me.TextBox67.Location = New System.Drawing.Point(2199, 574)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(100, 20)
        Me.TextBox67.TabIndex = 40
        '
        'TextBox68
        '
        Me.TextBox68.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Kosten", True))
        Me.TextBox68.Location = New System.Drawing.Point(1598, 299)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(100, 20)
        Me.TextBox68.TabIndex = 41
        '
        'TextBox69
        '
        Me.TextBox69.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Tod", True))
        Me.TextBox69.Location = New System.Drawing.Point(1470, 302)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(100, 20)
        Me.TextBox69.TabIndex = 42
        '
        'TextBox70
        '
        Me.TextBox70.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Bergung", True))
        Me.TextBox70.Location = New System.Drawing.Point(1347, 302)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(100, 20)
        Me.TextBox70.TabIndex = 43
        '
        'TextBox71
        '
        Me.TextBox71.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdeUnf, "Invalid", True))
        Me.TextBox71.Location = New System.Drawing.Point(1237, 301)
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(100, 20)
        Me.TextBox71.TabIndex = 44
        '
        'TextBox72
        '
        Me.TextBox72.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdehaf, "Deckung", True))
        Me.TextBox72.Location = New System.Drawing.Point(1239, 618)
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New System.Drawing.Size(100, 20)
        Me.TextBox72.TabIndex = 45
        '
        'TextBox73
        '
        Me.TextBox73.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdehaf, "Segel", True))
        Me.TextBox73.Location = New System.Drawing.Point(1374, 623)
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(100, 20)
        Me.TextBox73.TabIndex = 46
        '
        'TextBox74
        '
        Me.TextBox74.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdehaf, "Motor", True))
        Me.TextBox74.Location = New System.Drawing.Point(1490, 623)
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New System.Drawing.Size(78, 20)
        Me.TextBox74.TabIndex = 47
        '
        'TextBox79
        '
        Me.TextBox79.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdehaf, "Bemerkung", True))
        Me.TextBox79.Location = New System.Drawing.Point(1589, 624)
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New System.Drawing.Size(100, 20)
        Me.TextBox79.TabIndex = 48
        '
        'TextBox80
        '
        Me.TextBox80.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdefol, "Laenge", True))
        Me.TextBox80.Location = New System.Drawing.Point(45, 703)
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New System.Drawing.Size(100, 20)
        Me.TextBox80.TabIndex = 49
        '
        'TextBox81
        '
        Me.TextBox81.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdefol, "Segel", True))
        Me.TextBox81.Location = New System.Drawing.Point(183, 702)
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New System.Drawing.Size(100, 20)
        Me.TextBox81.TabIndex = 50
        '
        'TextBox82
        '
        Me.TextBox82.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsYPdefol, "Motor", True))
        Me.TextBox82.Location = New System.Drawing.Point(377, 702)
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New System.Drawing.Size(100, 20)
        Me.TextBox82.TabIndex = 51
        '
        'VersichTarifeY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 408)
        Me.Controls.Add(Me.TextBox82)
        Me.Controls.Add(Me.TextBox81)
        Me.Controls.Add(Me.TextBox80)
        Me.Controls.Add(Me.TextBox79)
        Me.Controls.Add(Me.TextBox74)
        Me.Controls.Add(Me.TextBox73)
        Me.Controls.Add(Me.TextBox72)
        Me.Controls.Add(Me.TextBox71)
        Me.Controls.Add(Me.TextBox70)
        Me.Controls.Add(Me.TextBox69)
        Me.Controls.Add(Me.TextBox68)
        Me.Controls.Add(Me.TextBox67)
        Me.Controls.Add(Me.TextBox66)
        Me.Controls.Add(Me.groupboxkau)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBoxRech)
        Me.Controls.Add(Me.GroupBoxHaf)
        Me.Controls.Add(Me.GroupBoxUnf)
        Me.Controls.Add(Me.GroupBoxFol)
        Me.Controls.Add(Me.GroupBoxRue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VersichTarifeY"
        Me.Text = "Yacht-Pool Versicherungstarife"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxRue.ResumeLayout(False)
        Me.GroupBoxRue.PerformLayout()
        CType(Me.bsYPdeRue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFol.ResumeLayout(False)
        Me.GroupBoxFol.PerformLayout()
        Me.GroupBoxUnf.ResumeLayout(False)
        Me.GroupBoxUnf.PerformLayout()
        Me.GroupBoxHaf.ResumeLayout(False)
        Me.GroupBoxHaf.PerformLayout()
        Me.GroupBoxRech.ResumeLayout(False)
        Me.GroupBoxRech.PerformLayout()
        CType(Me.bsYPderech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsYPdehaf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsYPdekau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsYPdeUnf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsYPdefol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxkau.ResumeLayout(False)
        Me.groupboxkau.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonRue As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFol As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonKau As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRech As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUnf As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonHafBe As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxRue As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox63 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxFol As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox55 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox54 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonFoSpeichern As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxUnf As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
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
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxHaf As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonHAFSpeichern As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxRech As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonrechSpeichern As System.Windows.Forms.Button
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dsVersicherung As WindowsApplication1.VersicherungDataSet
    Friend WithEvents bsYPdehaf As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdehaf As WindowsApplication1.VersicherungDataSetTableAdapters.YPdehafTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsYPdekau As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdekau As WindowsApplication1.VersicherungDataSetTableAdapters.YPdekauTableAdapter
    Friend WithEvents bsYPdeRue As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdeRue As WindowsApplication1.VersicherungDataSetTableAdapters.YPdeRueTableAdapter
    Friend WithEvents bsYPdeUnf As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdeUnf As WindowsApplication1.VersicherungDataSetTableAdapters.YPdeUnfTableAdapter
    Friend WithEvents bsYPdefol As System.Windows.Forms.BindingSource
    Friend WithEvents taYPdefol As WindowsApplication1.VersicherungDataSetTableAdapters.YPdefolTableAdapter
    Friend WithEvents bsYPderech As System.Windows.Forms.BindingSource
    Friend WithEvents taYPderech As WindowsApplication1.VersicherungDataSetTableAdapters.YPderechTableAdapter
    Friend WithEvents groupboxkau As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox53 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox59 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox60 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox61 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox62 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox64 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox65 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TextBox78 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox77 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox76 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox75 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonKautionSpeichern As System.Windows.Forms.Button
    Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox66 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox67 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox68 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox69 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox71 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox72 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox73 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox74 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox79 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox80 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox81 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox82 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox83 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
