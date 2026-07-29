<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crew))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureKreuz = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.SpeichernButton = New System.Windows.Forms.Button()
        Me.FormularButton = New System.Windows.Forms.Button()
        Me.LoeschenButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ZunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlterersterToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReisepassNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WachfuehrerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NavigatorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RudergaengerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.SteuerdatenDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.bsListdaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ToernnameDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLZDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VorwahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsPostleitzahlen = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.taListdaten = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ListdatenTableAdapter()
        Me.taPostleitzahlen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.PostleitzahlenTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ButtonAdresse = New System.Windows.Forms.Button()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureKreuz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SteuerdatenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListdaten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ToernnameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPostleitzahlen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.PictureKreuz)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 389)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crew verwalten"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(643, 187)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(56, 20)
        Me.RadioButton7.TabIndex = 69
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "ohne"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'bsCrewAdressen
        '
        Me.bsCrewAdressen.DataMember = "CrewAdressen"
        Me.bsCrewAdressen.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(85, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(0, 13)
        Me.Label27.TabIndex = 68
        '
        'PictureBox4
        '
        Me.PictureBox4.ErrorImage = CType(resources.GetObject("PictureBox4.ErrorImage"), System.Drawing.Image)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(73, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 67
        Me.PictureBox4.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(700, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 9)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "F5"
        '
        'PictureKreuz
        '
        Me.PictureKreuz.Image = CType(resources.GetObject("PictureKreuz.Image"), System.Drawing.Image)
        Me.PictureKreuz.Location = New System.Drawing.Point(600, 24)
        Me.PictureKreuz.Name = "PictureKreuz"
        Me.PictureKreuz.Size = New System.Drawing.Size(28, 28)
        Me.PictureKreuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureKreuz.TabIndex = 65
        Me.PictureKreuz.TabStop = False
        Me.PictureKreuz.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(402, 189)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 16)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Scheinstufe"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(135, 207)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(192, 24)
        Me.ComboBox2.TabIndex = 62
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 16)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "Land"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(573, 367)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 16)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "Donaupatent"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "Motorboot", True))
        Me.CheckBox3.Location = New System.Drawing.Point(678, 367)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 59
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "FB4", True))
        Me.RadioButton4.Location = New System.Drawing.Point(586, 204)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(50, 20)
        Me.RadioButton4.TabIndex = 57
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "FB4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "FB3", True))
        Me.RadioButton3.Location = New System.Drawing.Point(522, 204)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(50, 20)
        Me.RadioButton3.TabIndex = 55
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "FB3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "FB2", True))
        Me.RadioButton2.Location = New System.Drawing.Point(586, 185)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(50, 20)
        Me.RadioButton2.TabIndex = 53
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "FB2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "FB1", True))
        Me.RadioButton1.Location = New System.Drawing.Point(522, 185)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(50, 20)
        Me.RadioButton1.TabIndex = 51
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "FB1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(402, 365)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 16)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "A-Schein"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "A-Schein", True))
        Me.CheckBox2.Location = New System.Drawing.Point(522, 369)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 49
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "Clubmitglied", True))
        Me.CheckBox1.Location = New System.Drawing.Point(135, 335)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 48
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 335)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 16)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Clubmitglied"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 300)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 24)
        Me.ComboBox1.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 300)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 16)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Status"
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "anrede", True))
        Me.TextBox17.Location = New System.Drawing.Point(135, 90)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(192, 22)
        Me.TextBox17.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Anrede"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "AlterersterToern", True))
        Me.TextBox10.Location = New System.Drawing.Point(522, 57)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(171, 22)
        Me.TextBox10.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(402, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Alter zum Ersttörn"
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "SegelscheinVerband", True))
        Me.TextBox16.Location = New System.Drawing.Point(522, 300)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(171, 22)
        Me.TextBox16.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(402, 300)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 16)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "ausgestellt von"
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "SegelscheinDatum", True))
        Me.TextBox14.Location = New System.Drawing.Point(522, 270)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(171, 22)
        Me.TextBox14.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(402, 270)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 16)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "ausgestellt am"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "nationalitaet", True))
        Me.TextBox8.Location = New System.Drawing.Point(522, 150)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(171, 22)
        Me.TextBox8.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(402, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Nationalität"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.CausesValidation = False
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "GebDatum", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(523, 28)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(171, 22)
        Me.MaskedTextBox1.TabIndex = 9
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Zuname", True))
        Me.TextBox15.Location = New System.Drawing.Point(135, 30)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(192, 22)
        Me.TextBox15.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(105, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "funk", True))
        Me.TextBox13.Location = New System.Drawing.Point(522, 330)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(171, 22)
        Me.TextBox13.TabIndex = 17
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "segelschein", True))
        Me.TextBox12.Location = New System.Drawing.Point(522, 240)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(171, 22)
        Me.TextBox12.TabIndex = 14
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "ReisepassNr", True))
        Me.TextBox11.Location = New System.Drawing.Point(522, 120)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(171, 22)
        Me.TextBox11.TabIndex = 12
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "gebort", True))
        Me.TextBox9.Location = New System.Drawing.Point(522, 87)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(204, 22)
        Me.TextBox9.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "email", True))
        Me.TextBox6.Location = New System.Drawing.Point(135, 270)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(241, 22)
        Me.TextBox6.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Handy", True))
        Me.TextBox5.Location = New System.Drawing.Point(135, 240)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 22)
        Me.TextBox5.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Ort", True))
        Me.TextBox4.Location = New System.Drawing.Point(135, 180)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 22)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Plz", True))
        Me.TextBox3.Location = New System.Drawing.Point(135, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 22)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Straße", True))
        Me.TextBox2.Location = New System.Drawing.Point(135, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 22)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Vorname", True))
        Me.TextBox1.Location = New System.Drawing.Point(135, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(402, 333)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Funklizenz"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(402, 240)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Schein Nr.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(402, 87)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Geburtsort/Land"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Geburtsdatum"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 120)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Reisepass Nr."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 180)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ort"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Plz"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Straße"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 270)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 240)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mobile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Vorname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.CausesValidation = False
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Sterbedatum", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(523, 28)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(171, 22)
        Me.MaskedTextBox2.TabIndex = 64
        '
        'SpeichernButton
        '
        Me.SpeichernButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeichernButton.Location = New System.Drawing.Point(598, 601)
        Me.SpeichernButton.Name = "SpeichernButton"
        Me.SpeichernButton.Size = New System.Drawing.Size(150, 48)
        Me.SpeichernButton.TabIndex = 18
        Me.SpeichernButton.Text = "Speichern"
        Me.SpeichernButton.UseVisualStyleBackColor = True
        '
        'FormularButton
        '
        Me.FormularButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormularButton.Location = New System.Drawing.Point(402, 601)
        Me.FormularButton.Name = "FormularButton"
        Me.FormularButton.Size = New System.Drawing.Size(150, 49)
        Me.FormularButton.TabIndex = 15
        Me.FormularButton.Text = "Formular leeren"
        Me.FormularButton.UseVisualStyleBackColor = True
        '
        'LoeschenButton
        '
        Me.LoeschenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoeschenButton.Location = New System.Drawing.Point(12, 601)
        Me.LoeschenButton.Name = "LoeschenButton"
        Me.LoeschenButton.Size = New System.Drawing.Size(150, 48)
        Me.LoeschenButton.TabIndex = 16
        Me.LoeschenButton.Text = "Name löschen"
        Me.LoeschenButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 407)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 174)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bemerkung"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(600, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 25)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Ausgabe"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ZunameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ToernnrDataGridViewTextBoxColumn, Me.AlterersterToernDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.ReisepassNrDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsCrewAdressen
        Me.DataGridView1.Location = New System.Drawing.Point(195, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(692, 142)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'ZunameDataGridViewTextBoxColumn
        '
        Me.ZunameDataGridViewTextBoxColumn.DataPropertyName = "Zuname"
        Me.ZunameDataGridViewTextBoxColumn.HeaderText = "Zuname"
        Me.ZunameDataGridViewTextBoxColumn.Name = "ZunameDataGridViewTextBoxColumn"
        '
        'VornameDataGridViewTextBoxColumn
        '
        Me.VornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.HeaderText = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.Name = "VornameDataGridViewTextBoxColumn"
        '
        'HandyDataGridViewTextBoxColumn
        '
        Me.HandyDataGridViewTextBoxColumn.DataPropertyName = "Handy"
        Me.HandyDataGridViewTextBoxColumn.HeaderText = "Handy"
        Me.HandyDataGridViewTextBoxColumn.Name = "HandyDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'ToernnrDataGridViewTextBoxColumn
        '
        Me.ToernnrDataGridViewTextBoxColumn.DataPropertyName = "toernnr"
        Me.ToernnrDataGridViewTextBoxColumn.HeaderText = "toernnr"
        Me.ToernnrDataGridViewTextBoxColumn.Name = "ToernnrDataGridViewTextBoxColumn"
        '
        'AlterersterToernDataGridViewTextBoxColumn
        '
        Me.AlterersterToernDataGridViewTextBoxColumn.DataPropertyName = "AlterersterToern"
        Me.AlterersterToernDataGridViewTextBoxColumn.HeaderText = "AlterersterToern"
        Me.AlterersterToernDataGridViewTextBoxColumn.Name = "AlterersterToernDataGridViewTextBoxColumn"
        '
        'StraßeDataGridViewTextBoxColumn
        '
        Me.StraßeDataGridViewTextBoxColumn.DataPropertyName = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.HeaderText = "Straße"
        Me.StraßeDataGridViewTextBoxColumn.Name = "StraßeDataGridViewTextBoxColumn"
        '
        'PlzDataGridViewTextBoxColumn
        '
        Me.PlzDataGridViewTextBoxColumn.DataPropertyName = "Plz"
        Me.PlzDataGridViewTextBoxColumn.HeaderText = "Plz"
        Me.PlzDataGridViewTextBoxColumn.Name = "PlzDataGridViewTextBoxColumn"
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        '
        'ReisepassNrDataGridViewTextBoxColumn
        '
        Me.ReisepassNrDataGridViewTextBoxColumn.DataPropertyName = "ReisepassNr"
        Me.ReisepassNrDataGridViewTextBoxColumn.HeaderText = "ReisepassNr"
        Me.ReisepassNrDataGridViewTextBoxColumn.Name = "ReisepassNrDataGridViewTextBoxColumn"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 18)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(693, 130)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "VZname", True))
        Me.TextBox7.Location = New System.Drawing.Point(1081, 96)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(93, 22)
        Me.TextBox7.TabIndex = 38
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ToernDataGridViewTextBoxColumn, Me.VZnameDataGridViewTextBoxColumn, Me.WachfuehrerDataGridViewCheckBoxColumn, Me.NavigatorDataGridViewCheckBoxColumn, Me.RudergaengerDataGridViewCheckBoxColumn})
        Me.DataGridView2.DataSource = Me.bsTC
        Me.DataGridView2.Location = New System.Drawing.Point(1338, 162)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(68, 81)
        Me.DataGridView2.TabIndex = 39
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
        '
        'VZnameDataGridViewTextBoxColumn
        '
        Me.VZnameDataGridViewTextBoxColumn.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.Name = "VZnameDataGridViewTextBoxColumn"
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
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Status", True))
        Me.TextBox19.Location = New System.Drawing.Point(1091, 143)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 22)
        Me.TextBox19.TabIndex = 40
        '
        'SteuerdatenDataGridView
        '
        Me.SteuerdatenDataGridView.AutoGenerateColumns = False
        Me.SteuerdatenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SteuerdatenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.BezeichnungDataGridViewTextBoxColumn, Me.Feld1DataGridViewTextBoxColumn, Me.Feld2DataGridViewTextBoxColumn, Me.Feld3DataGridViewTextBoxColumn, Me.Feld4DataGridViewTextBoxColumn, Me.Feld5DataGridViewTextBoxColumn, Me.Feld6DataGridViewTextBoxColumn, Me.Feld7DataGridViewTextBoxColumn, Me.Feld8DataGridViewTextBoxColumn, Me.Feld9DataGridViewTextBoxColumn, Me.Feld10DataGridViewTextBoxColumn, Me.Feld11DataGridViewTextBoxColumn, Me.Feld12DataGridViewTextBoxColumn, Me.Feld13DataGridViewTextBoxColumn, Me.Feld14DataGridViewTextBoxColumn, Me.Feld15DataGridViewTextBoxColumn, Me.Feld16DataGridViewTextBoxColumn, Me.Feld17DataGridViewTextBoxColumn, Me.Feld18DataGridViewTextBoxColumn, Me.Feld19DataGridViewTextBoxColumn, Me.Feld20DataGridViewTextBoxColumn, Me.Feld21DataGridViewTextBoxColumn, Me.Feld22DataGridViewTextBoxColumn, Me.Feld23DataGridViewTextBoxColumn, Me.Feld24DataGridViewTextBoxColumn, Me.Feld25DataGridViewTextBoxColumn, Me.Feld26DataGridViewTextBoxColumn, Me.Feld27DataGridViewTextBoxColumn, Me.Feld28DataGridViewTextBoxColumn})
        Me.SteuerdatenDataGridView.DataSource = Me.bsListdaten
        Me.SteuerdatenDataGridView.Location = New System.Drawing.Point(1338, 283)
        Me.SteuerdatenDataGridView.Name = "SteuerdatenDataGridView"
        Me.SteuerdatenDataGridView.Size = New System.Drawing.Size(86, 118)
        Me.SteuerdatenDataGridView.TabIndex = 40
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'BezeichnungDataGridViewTextBoxColumn
        '
        Me.BezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung"
        Me.BezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung"
        Me.BezeichnungDataGridViewTextBoxColumn.Name = "BezeichnungDataGridViewTextBoxColumn"
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
        'bsListdaten
        '
        Me.bsListdaten.DataMember = "Listdaten"
        Me.bsListdaten.DataSource = Me.dsToernverwaltung
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(760, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 389)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Törns"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 373)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Doppelklick auf Törn --> Törn"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(206, 355)
        Me.ListBox1.TabIndex = 0
        '
        'ToernnameDataGridView
        '
        Me.ToernnameDataGridView.AutoGenerateColumns = False
        Me.ToernnameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ToernnameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50})
        Me.ToernnameDataGridView.DataSource = Me.bsToernname
        Me.ToernnameDataGridView.Location = New System.Drawing.Point(1114, 458)
        Me.ToernnameDataGridView.Name = "ToernnameDataGridView"
        Me.ToernnameDataGridView.Size = New System.Drawing.Size(85, 220)
        Me.ToernnameDataGridView.TabIndex = 41
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn31.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "DatumVon"
        Me.DataGridViewTextBoxColumn32.HeaderText = "DatumVon"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "DatumBis"
        Me.DataGridViewTextBoxColumn33.HeaderText = "DatumBis"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Ausgangsmarina"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Ausgangsmarina"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "EndeMarina"
        Me.DataGridViewTextBoxColumn35.HeaderText = "EndeMarina"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Toernbezeichnung"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Toernbezeichnung"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "smSegel"
        Me.DataGridViewTextBoxColumn37.HeaderText = "smSegel"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "smMotor"
        Me.DataGridViewTextBoxColumn38.HeaderText = "smMotor"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "smGesamt"
        Me.DataGridViewTextBoxColumn39.HeaderText = "smGesamt"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Nachtfahrten"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Nachtfahrten"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Nachtansteuerungen"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Nachtansteuerungen"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Bordtage"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Bordtage"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "ausserhalbFB2"
        Me.DataGridViewTextBoxColumn43.HeaderText = "ausserhalbFB2"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "ausserhalbFB3"
        Me.DataGridViewTextBoxColumn44.HeaderText = "ausserhalbFB3"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "Bootsname"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Bootsname"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Skipper"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Skipper"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "letzterSegeltag"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "letzterSegeltag"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "Bemerkung"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Bemerkung"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "Bordkassa"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Bordkassa"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "Route"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Route"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
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
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.PLZDataGridViewTextBoxColumn1, Me.OrtDataGridViewTextBoxColumn1, Me.VorwahlDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsPostleitzahlen
        Me.DataGridView3.Location = New System.Drawing.Point(1243, 154)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(70, 150)
        Me.DataGridView3.TabIndex = 42
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'PLZDataGridViewTextBoxColumn1
        '
        Me.PLZDataGridViewTextBoxColumn1.DataPropertyName = "PLZ"
        Me.PLZDataGridViewTextBoxColumn1.HeaderText = "PLZ"
        Me.PLZDataGridViewTextBoxColumn1.Name = "PLZDataGridViewTextBoxColumn1"
        '
        'OrtDataGridViewTextBoxColumn1
        '
        Me.OrtDataGridViewTextBoxColumn1.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.Name = "OrtDataGridViewTextBoxColumn1"
        '
        'VorwahlDataGridViewTextBoxColumn
        '
        Me.VorwahlDataGridViewTextBoxColumn.DataPropertyName = "Vorwahl"
        Me.VorwahlDataGridViewTextBoxColumn.HeaderText = "Vorwahl"
        Me.VorwahlDataGridViewTextBoxColumn.Name = "VorwahlDataGridViewTextBoxColumn"
        '
        'bsPostleitzahlen
        '
        Me.bsPostleitzahlen.DataMember = "Postleitzahlen"
        Me.bsPostleitzahlen.DataSource = Me.dsToernverwaltung
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(207, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 48)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Formular Crewaufnahme"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(766, 416)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(212, 233)
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 584)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 16)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Anzahl"
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "toernnr", True))
        Me.TextBox18.Location = New System.Drawing.Point(1267, 56)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 22)
        Me.TextBox18.TabIndex = 46
        '
        'taCrewAdressen
        '
        Me.taCrewAdressen.ClearBeforeFill = True
        '
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
        '
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'taListdaten
        '
        Me.taListdaten.ClearBeforeFill = True
        '
        'taPostleitzahlen
        '
        Me.taPostleitzahlen.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1081, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 48)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Adresse drucken"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(27, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 86)
        Me.PictureBox3.TabIndex = 64
        Me.PictureBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox6)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Location = New System.Drawing.Point(1566, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 127)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(850, 520)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(109, 94)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 65
        Me.PictureBox6.TabStop = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(1566, 26)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 84)
        Me.ListBox2.TabIndex = 66
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(1566, 132)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 84)
        Me.ListBox3.TabIndex = 67
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ButtonAdresse)
        Me.GroupBox5.Controls.Add(Me.CheckBox5)
        Me.GroupBox5.Controls.Add(Me.CheckBox4)
        Me.GroupBox5.Controls.Add(Me.PictureBox5)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.TextBox20)
        Me.GroupBox5.Controls.Add(Me.RadioButton6)
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Location = New System.Drawing.Point(21, 681)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(727, 134)
        Me.GroupBox5.TabIndex = 69
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Druckfunktion auswählen"
        '
        'ButtonAdresse
        '
        Me.ButtonAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdresse.Location = New System.Drawing.Point(292, 92)
        Me.ButtonAdresse.Name = "ButtonAdresse"
        Me.ButtonAdresse.Size = New System.Drawing.Size(104, 28)
        Me.ButtonAdresse.TabIndex = 11
        Me.ButtonAdresse.Text = "Drucken"
        Me.ButtonAdresse.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(100, 97)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(113, 20)
        Me.CheckBox5.TabIndex = 10
        Me.CheckBox5.Text = "Törns drucken"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(100, 71)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(147, 20)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Text = "Bemerkung drucken"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(654, 85)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(435, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(93, 16)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Anzahl Kopien"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(579, 68)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(39, 22)
        Me.TextBox20.TabIndex = 6
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(417, 45)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(210, 20)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Kurzen Brief schreiben/drucken"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(100, 45)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(180, 20)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Alle Adressdaten drucken"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Crew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 662)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.ToernnameDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SteuerdatenDataGridView)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LoeschenButton)
        Me.Controls.Add(Me.FormularButton)
        Me.Controls.Add(Me.SpeichernButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Crew"
        Me.Text = "Crew"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureKreuz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SteuerdatenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListdaten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ToernnameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPostleitzahlen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SpeichernButton As System.Windows.Forms.Button
    Friend WithEvents FormularButton As System.Windows.Forms.Button
    Friend WithEvents LoeschenButton As System.Windows.Forms.Button
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ZunameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlterersterToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReisepassNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebdatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FunkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WachfuehrerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NavigatorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RudergaengerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents SteuerdatenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents ToernnameDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents bsListdaten As System.Windows.Forms.BindingSource
    Friend WithEvents taListdaten As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ListdatenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents bsPostleitzahlen As System.Windows.Forms.BindingSource
    Friend WithEvents taPostleitzahlen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.PostleitzahlenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLZDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VorwahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureKreuz As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonAdresse As System.Windows.Forms.Button
End Class
