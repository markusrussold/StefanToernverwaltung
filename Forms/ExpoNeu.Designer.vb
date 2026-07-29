<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpoNeu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsBordkassaE = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDataSet = New WindowsApplication1.ExportDataSet()
        Me.bsWacheplane = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charterfirma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Straße = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Land = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Handy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBAuftritt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ansprechsperson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marinaort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bemerkung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsWacheplan = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.bsCharter = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCharter = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CharterTableAdapter()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.bsAgentur = New System.Windows.Forms.BindingSource(Me.components)
        Me.taAgentur = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.AgenturTableAdapter()
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.bsBordkassa = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBordkassa = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BordkassaTableAdapter()
        Me.taWacheplan = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter()
        Me.bsAgenturE = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExport = New WindowsApplication1.ExportDataSet()
        Me.bsBootE = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBootE = New WindowsApplication1.ExportDataSetTableAdapters.BootETableAdapter()
        Me.bsCharterE = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCharterE = New WindowsApplication1.ExportDataSetTableAdapters.CharterETableAdapter()
        Me.bsCrewAdressenE = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCrewAdressenE = New WindowsApplication1.ExportDataSetTableAdapters.CrewAdressenETableAdapter()
        Me.bsTCE = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTCE = New WindowsApplication1.ExportDataSetTableAdapters.TCETableAdapter()
        Me.bsToernnameE = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernnameE = New WindowsApplication1.ExportDataSetTableAdapters.ToernnameETableAdapter()
        Me.taAgenturE = New WindowsApplication1.ExportDataSetTableAdapters.AgenturETableAdapter()
        Me.taWacheplanE = New WindowsApplication1.ExportDataSetTableAdapters.WacheplanTableAdapter()
        Me.taBordkassaE = New WindowsApplication1.ExportDataSetTableAdapters.BordkassaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBordkassaE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWacheplane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCharter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAgentur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBordkassa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAgenturE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBootE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCharterE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressenE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernnameE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 245)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Törns für Export auswählen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "<--- Doppelclick"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Doppelclick --->"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(274, 24)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(226, 186)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(19, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(238, 186)
        Me.ListBox1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.ToernDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsBordkassaE
        Me.DataGridView2.Location = New System.Drawing.Point(586, 140)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 8
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
        '
        'bsBordkassaE
        '
        Me.bsBordkassaE.DataMember = "Bordkassa"
        Me.bsBordkassaE.DataSource = Me.ExportDataSet
        '
        'ExportDataSet
        '
        Me.ExportDataSet.DataSetName = "ExportDataSet"
        Me.ExportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsWacheplane
        '
        Me.bsWacheplane.DataMember = "Wacheplan"
        Me.bsWacheplane.DataSource = Me.ExportDataSet
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(378, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 53)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Export starten"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 63)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.Charterfirma, Me.Straße, Me.PLZ, Me.Ort, Me.Land, Me.Telefon, Me.Handy, Me.email, Me.WEBAuftritt, Me.Ansprechsperson, Me.Marina, Me.Marinaort, Me.Bemerkung})
        Me.DataGridView1.DataSource = Me.bsWacheplan
        Me.DataGridView1.Location = New System.Drawing.Point(586, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(294, 113)
        Me.DataGridView1.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'Charterfirma
        '
        Me.Charterfirma.DataPropertyName = "Charterfirma"
        Me.Charterfirma.HeaderText = "Charterfirma"
        Me.Charterfirma.Name = "Charterfirma"
        '
        'Straße
        '
        Me.Straße.DataPropertyName = "Straße"
        Me.Straße.HeaderText = "Straße"
        Me.Straße.Name = "Straße"
        '
        'PLZ
        '
        Me.PLZ.DataPropertyName = "PLZ"
        Me.PLZ.HeaderText = "PLZ"
        Me.PLZ.Name = "PLZ"
        '
        'Ort
        '
        Me.Ort.DataPropertyName = "Ort"
        Me.Ort.HeaderText = "Ort"
        Me.Ort.Name = "Ort"
        '
        'Land
        '
        Me.Land.DataPropertyName = "Land"
        Me.Land.HeaderText = "Land"
        Me.Land.Name = "Land"
        '
        'Telefon
        '
        Me.Telefon.DataPropertyName = "Telefon"
        Me.Telefon.HeaderText = "Telefon"
        Me.Telefon.Name = "Telefon"
        '
        'Handy
        '
        Me.Handy.DataPropertyName = "Handy"
        Me.Handy.HeaderText = "Handy"
        Me.Handy.Name = "Handy"
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "email"
        Me.email.Name = "email"
        '
        'WEBAuftritt
        '
        Me.WEBAuftritt.DataPropertyName = "WEBAuftritt"
        Me.WEBAuftritt.HeaderText = "WEBAuftritt"
        Me.WEBAuftritt.Name = "WEBAuftritt"
        '
        'Ansprechsperson
        '
        Me.Ansprechsperson.DataPropertyName = "Ansprechsperson"
        Me.Ansprechsperson.HeaderText = "Ansprechsperson"
        Me.Ansprechsperson.Name = "Ansprechsperson"
        '
        'Marina
        '
        Me.Marina.DataPropertyName = "Marina"
        Me.Marina.HeaderText = "Marina"
        Me.Marina.Name = "Marina"
        '
        'Marinaort
        '
        Me.Marinaort.DataPropertyName = "Marinaort"
        Me.Marinaort.HeaderText = "Marinaort"
        Me.Marinaort.Name = "Marinaort"
        '
        'Bemerkung
        '
        Me.Bemerkung.DataPropertyName = "Bemerkung"
        Me.Bemerkung.HeaderText = "Bemerkung"
        Me.Bemerkung.Name = "Bemerkung"
        '
        'bsWacheplan
        '
        Me.bsWacheplan.DataMember = "Wacheplan"
        Me.bsWacheplan.DataSource = Me.dsToernverwaltung
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
        'bsCharter
        '
        Me.bsCharter.DataMember = "Charter"
        Me.bsCharter.DataSource = Me.dsToernverwaltung
        '
        'taCharter
        '
        Me.taCharter.ClearBeforeFill = True
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
        'bsTC
        '
        Me.bsTC.DataMember = "TC"
        Me.bsTC.DataSource = Me.dsToernverwaltung
        '
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
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
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'bsBordkassa
        '
        Me.bsBordkassa.DataMember = "Bordkassa"
        Me.bsBordkassa.DataSource = Me.dsToernverwaltung
        '
        'taBordkassa
        '
        Me.taBordkassa.ClearBeforeFill = True
        '
        'taWacheplan
        '
        Me.taWacheplan.ClearBeforeFill = True
        '
        'bsAgenturE
        '
        Me.bsAgenturE.DataMember = "AgenturE"
        Me.bsAgenturE.DataSource = Me.dsExport
        '
        'dsExport
        '
        Me.dsExport.DataSetName = "ExportDataSet"
        Me.dsExport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsBootE
        '
        Me.bsBootE.DataMember = "BootE"
        Me.bsBootE.DataSource = Me.dsExport
        '
        'taBootE
        '
        Me.taBootE.ClearBeforeFill = True
        '
        'bsCharterE
        '
        Me.bsCharterE.DataMember = "CharterE"
        Me.bsCharterE.DataSource = Me.dsExport
        '
        'taCharterE
        '
        Me.taCharterE.ClearBeforeFill = True
        '
        'bsCrewAdressenE
        '
        Me.bsCrewAdressenE.DataMember = "CrewAdressenE"
        Me.bsCrewAdressenE.DataSource = Me.dsExport
        '
        'taCrewAdressenE
        '
        Me.taCrewAdressenE.ClearBeforeFill = True
        '
        'bsTCE
        '
        Me.bsTCE.DataMember = "TCE"
        Me.bsTCE.DataSource = Me.dsExport
        '
        'taTCE
        '
        Me.taTCE.ClearBeforeFill = True
        '
        'bsToernnameE
        '
        Me.bsToernnameE.DataMember = "ToernnameE"
        Me.bsToernnameE.DataSource = Me.dsExport
        '
        'taToernnameE
        '
        Me.taToernnameE.ClearBeforeFill = True
        '
        'taAgenturE
        '
        Me.taAgenturE.ClearBeforeFill = True
        '
        'taWacheplanE
        '
        Me.taWacheplanE.ClearBeforeFill = True
        '
        'taBordkassaE
        '
        Me.taBordkassaE.ClearBeforeFill = True
        '
        'ExpoNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 401)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ExpoNeu"
        Me.Text = "Export"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBordkassaE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWacheplane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCharter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAgentur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBordkassa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAgenturE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBootE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCharterE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressenE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernnameE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Charterfirma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Straße As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLZ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Land As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Handy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEBAuftritt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ansprechsperson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marina As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marinaort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bemerkung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsExport As WindowsApplication1.ExportDataSet
    Friend WithEvents bsBootE As System.Windows.Forms.BindingSource
    Friend WithEvents taBootE As WindowsApplication1.ExportDataSetTableAdapters.BootETableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsCharterE As System.Windows.Forms.BindingSource
    Friend WithEvents taCharterE As WindowsApplication1.ExportDataSetTableAdapters.CharterETableAdapter
    Friend WithEvents bsCrewAdressenE As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressenE As WindowsApplication1.ExportDataSetTableAdapters.CrewAdressenETableAdapter
    Friend WithEvents bsTCE As System.Windows.Forms.BindingSource
    Friend WithEvents taTCE As WindowsApplication1.ExportDataSetTableAdapters.TCETableAdapter
    Friend WithEvents bsToernnameE As System.Windows.Forms.BindingSource
    Friend WithEvents taToernnameE As WindowsApplication1.ExportDataSetTableAdapters.ToernnameETableAdapter
    Friend WithEvents bsAgenturE As System.Windows.Forms.BindingSource
    Friend WithEvents taAgenturE As WindowsApplication1.ExportDataSetTableAdapters.AgenturETableAdapter
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents bsCharter As System.Windows.Forms.BindingSource
    Friend WithEvents taCharter As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CharterTableAdapter
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents bsAgentur As System.Windows.Forms.BindingSource
    Friend WithEvents taAgentur As WindowsApplication1.ToernverwaltungDataSetTableAdapters.AgenturTableAdapter
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents bsBordkassa As System.Windows.Forms.BindingSource
    Friend WithEvents taBordkassa As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BordkassaTableAdapter
    Friend WithEvents bsWacheplan As System.Windows.Forms.BindingSource
    Friend WithEvents taWacheplan As WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter
    Friend WithEvents ExportDataSet As WindowsApplication1.ExportDataSet
    '    Friend WithEvents taBordkassaE As WindowsApplication1.ExportDataSetTableAdapters.BordkassaETableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsWacheplane As System.Windows.Forms.BindingSource
    Friend WithEvents taWacheplanE As WindowsApplication1.ExportDataSetTableAdapters.WacheplanTableAdapter
    Friend WithEvents bsBordkassaE As System.Windows.Forms.BindingSource
    Friend WithEvents taBordkassaE As WindowsApplication1.ExportDataSetTableAdapters.BordkassaTableAdapter
End Class
