<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistik))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Stati = New System.Windows.Forms.Button()
        Me.Drucken = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTemp = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.taTemp = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.HeizungDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.KlimaanlageDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MMSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotoryachtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SegelyachtDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ckb_Revieruebersicht = New System.Windows.Forms.CheckBox()
        Me.ckb_Mehrmalsfahrer = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TextBox24)
        Me.GroupBox1.Controls.Add(Me.TextBox22)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 274)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Skipper auswählen"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(307, 244)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 16)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "bis"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(352, 244)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(90, 20)
        Me.TextBox24.TabIndex = 6
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(201, 240)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(90, 20)
        Me.TextBox22.TabIndex = 5
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(17, 244)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 16)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Periode von"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "<--- Doppelclick"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Doppelclick --->"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(352, 19)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(244, 186)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(20, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(271, 186)
        Me.ListBox1.TabIndex = 0
        '
        'Stati
        '
        Me.Stati.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stati.Location = New System.Drawing.Point(532, 319)
        Me.Stati.Name = "Stati"
        Me.Stati.Size = New System.Drawing.Size(120, 47)
        Me.Stati.TabIndex = 1
        Me.Stati.Text = "Statistik"
        Me.Stati.UseVisualStyleBackColor = True
        '
        'Drucken
        '
        Me.Drucken.Enabled = False
        Me.Drucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drucken.Location = New System.Drawing.Point(532, 522)
        Me.Drucken.Name = "Drucken"
        Me.Drucken.Size = New System.Drawing.Size(120, 46)
        Me.Drucken.TabIndex = 2
        Me.Drucken.Text = "Drucken"
        Me.Drucken.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsTemp
        Me.DataGridView1.Location = New System.Drawing.Point(781, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(238, 93)
        Me.DataGridView1.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'bsTemp
        '
        Me.bsTemp.DataMember = "Temp"
        Me.bsTemp.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsTC
        '
        Me.bsTC.DataMember = "TC"
        Me.bsTC.DataSource = Me.dsToernverwaltung
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
        'bsCrewAdressen
        '
        Me.bsCrewAdressen.DataMember = "CrewAdressen"
        Me.bsCrewAdressen.DataSource = Me.dsToernverwaltung
        '
        'taCrewAdressen
        '
        Me.taCrewAdressen.ClearBeforeFill = True
        '
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
        '
        'taTemp
        '
        Me.taTemp.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(350, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(350, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(51, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(350, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(51, 20)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(350, 109)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(90, 20)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(350, 135)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(90, 20)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(350, 161)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(90, 20)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.TextBox23)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.TextBox20)
        Me.GroupBox2.Controls.Add(Me.TextBox21)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TextBox19)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.TextBox16)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.TextBox17)
        Me.GroupBox2.Controls.Add(Me.TextBox18)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 254)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Statistik Auswertung"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(443, 191)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 13)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "%"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(407, 188)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(33, 20)
        Me.TextBox23.TabIndex = 52
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(350, 188)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(51, 20)
        Me.TextBox9.TabIndex = 51
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(222, 195)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 13)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "%"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(186, 192)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(33, 20)
        Me.TextBox20.TabIndex = 49
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(129, 192)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(51, 20)
        Me.TextBox21.TabIndex = 48
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 195)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "sm im FB4"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(129, 58)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(90, 20)
        Me.TextBox19.TabIndex = 46
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(222, 143)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 13)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "%"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(186, 138)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(33, 20)
        Me.TextBox14.TabIndex = 44
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(129, 138)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(51, 20)
        Me.TextBox16.TabIndex = 43
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(222, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "%"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(186, 164)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(33, 20)
        Me.TextBox12.TabIndex = 41
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(129, 164)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(51, 20)
        Me.TextBox15.TabIndex = 40
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(129, 219)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(90, 20)
        Me.TextBox10.TabIndex = 39
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(222, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 13)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "%"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(186, 86)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(33, 20)
        Me.TextBox11.TabIndex = 36
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(129, 32)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(90, 20)
        Me.TextBox13.TabIndex = 29
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(129, 86)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(51, 20)
        Me.TextBox17.TabIndex = 31
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(129, 112)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(90, 20)
        Me.TextBox18.TabIndex = 32
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(252, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Mehrmalsfahrer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "sm Durchschnitt/Tag"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 167)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "sm im FB3"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 141)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "sm unter Segel"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "sm gesamt"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Nachtfahrten"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Bordtage"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Anzahl der Törns"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(443, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "%"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(407, 83)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(33, 20)
        Me.TextBox8.TabIndex = 17
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(407, 56)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(33, 20)
        Me.TextBox7.TabIndex = 16
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Älterster"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(250, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Jüngster"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Durchschnittsalter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Herren"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Damen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Crewmitglieder"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.BootnameDataGridViewTextBoxColumn, Me.MarkeDataGridViewTextBoxColumn, Me.SchiffstypDataGridViewTextBoxColumn, Me.KielartDataGridViewTextBoxColumn, Me.SchiffsnummerDataGridViewTextBoxColumn, Me.DurchfahrtshoeheDataGridViewTextBoxColumn, Me.LängeDataGridViewTextBoxColumn, Me.BreiteDataGridViewTextBoxColumn, Me.VerdrängungDataGridViewTextBoxColumn, Me.TiefgangDataGridViewTextBoxColumn, Me.GroßsegelDataGridViewTextBoxColumn, Me.VorsegelDataGridViewTextBoxColumn, Me.WassertankDataGridViewTextBoxColumn, Me.DieseltankDataGridViewTextBoxColumn, Me.StarterbatterieDataGridViewTextBoxColumn, Me.ServicebatterieDataGridViewTextBoxColumn, Me.KabinenanzahlDataGridViewTextBoxColumn, Me.KojenanzahlDataGridViewTextBoxColumn, Me.NassraeumeanzahlDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.KautionDataGridViewTextBoxColumn, Me.BildDataGridViewTextBoxColumn, Me.CharterfirmaDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.TestDataGridViewTextBoxColumn, Me.GrosssegelartDataGridViewTextBoxColumn, Me.BaujahrDataGridViewTextBoxColumn, Me.MarinaortDataGridViewTextBoxColumn, Me.MarinaDataGridViewTextBoxColumn, Me.AnsprechspersonDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.RadarDataGridViewCheckBoxColumn, Me.BugstrahlruderDataGridViewCheckBoxColumn, Me.ClubnachlasDataGridViewCheckBoxColumn, Me.HeizungDataGridViewCheckBoxColumn, Me.KlimaanlageDataGridViewCheckBoxColumn, Me.MMSIDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.MotoryachtDataGridViewCheckBoxColumn, Me.SegelyachtDataGridViewCheckBoxColumn})
        Me.DataGridView2.DataSource = Me.bsBoot
        Me.DataGridView2.Location = New System.Drawing.Point(781, 147)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 11
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
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
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
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
        'HeizungDataGridViewCheckBoxColumn
        '
        Me.HeizungDataGridViewCheckBoxColumn.DataPropertyName = "Heizung"
        Me.HeizungDataGridViewCheckBoxColumn.HeaderText = "Heizung"
        Me.HeizungDataGridViewCheckBoxColumn.Name = "HeizungDataGridViewCheckBoxColumn"
        '
        'KlimaanlageDataGridViewCheckBoxColumn
        '
        Me.KlimaanlageDataGridViewCheckBoxColumn.DataPropertyName = "Klimaanlage"
        Me.KlimaanlageDataGridViewCheckBoxColumn.HeaderText = "Klimaanlage"
        Me.KlimaanlageDataGridViewCheckBoxColumn.Name = "KlimaanlageDataGridViewCheckBoxColumn"
        '
        'MMSIDataGridViewTextBoxColumn
        '
        Me.MMSIDataGridViewTextBoxColumn.DataPropertyName = "MMSI"
        Me.MMSIDataGridViewTextBoxColumn.HeaderText = "MMSI"
        Me.MMSIDataGridViewTextBoxColumn.Name = "MMSIDataGridViewTextBoxColumn"
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
        'MotoryachtDataGridViewCheckBoxColumn
        '
        Me.MotoryachtDataGridViewCheckBoxColumn.DataPropertyName = "Motoryacht"
        Me.MotoryachtDataGridViewCheckBoxColumn.HeaderText = "Motoryacht"
        Me.MotoryachtDataGridViewCheckBoxColumn.Name = "MotoryachtDataGridViewCheckBoxColumn"
        '
        'SegelyachtDataGridViewCheckBoxColumn
        '
        Me.SegelyachtDataGridViewCheckBoxColumn.DataPropertyName = "Segelyacht"
        Me.SegelyachtDataGridViewCheckBoxColumn.HeaderText = "Segelyacht"
        Me.SegelyachtDataGridViewCheckBoxColumn.Name = "SegelyachtDataGridViewCheckBoxColumn"
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
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(781, 321)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(240, 95)
        Me.ListBox3.TabIndex = 12
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(781, 435)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(240, 95)
        Me.ListBox4.TabIndex = 13
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(1028, 435)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 95)
        Me.ListBox5.TabIndex = 14
        '
        'ckb_Revieruebersicht
        '
        Me.ckb_Revieruebersicht.AutoSize = True
        Me.ckb_Revieruebersicht.Checked = True
        Me.ckb_Revieruebersicht.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_Revieruebersicht.Location = New System.Drawing.Point(532, 476)
        Me.ckb_Revieruebersicht.Name = "ckb_Revieruebersicht"
        Me.ckb_Revieruebersicht.Size = New System.Drawing.Size(142, 17)
        Me.ckb_Revieruebersicht.TabIndex = 15
        Me.ckb_Revieruebersicht.Text = "Revierübersicht drucken"
        Me.ckb_Revieruebersicht.UseVisualStyleBackColor = True
        '
        'ckb_Mehrmalsfahrer
        '
        Me.ckb_Mehrmalsfahrer.AutoSize = True
        Me.ckb_Mehrmalsfahrer.Location = New System.Drawing.Point(532, 499)
        Me.ckb_Mehrmalsfahrer.Name = "ckb_Mehrmalsfahrer"
        Me.ckb_Mehrmalsfahrer.Size = New System.Drawing.Size(140, 17)
        Me.ckb_Mehrmalsfahrer.TabIndex = 16
        Me.ckb_Mehrmalsfahrer.Text = "Mehrmalsfahrer drucken"
        Me.ckb_Mehrmalsfahrer.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(38, 292)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(616, 16)
        Me.ProgressBar1.TabIndex = 17
        '
        'Statistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 575)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ckb_Mehrmalsfahrer)
        Me.Controls.Add(Me.ckb_Revieruebersicht)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Drucken)
        Me.Controls.Add(Me.Stati)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Statistik"
        Me.Text = "Statistik"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Stati As System.Windows.Forms.Button
    Friend WithEvents Drucken As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents bsTemp As System.Windows.Forms.BindingSource
    Friend WithEvents taTemp As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents HeizungDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents KlimaanlageDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MMSIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotoryachtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SegelyachtDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ckb_Revieruebersicht As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_Mehrmalsfahrer As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
