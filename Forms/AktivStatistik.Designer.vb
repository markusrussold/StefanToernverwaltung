<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AktivStatistik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AktivStatistik))
        Me.gb_Besucher = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBarM = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarW = New System.Windows.Forms.ProgressBar()
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.dgv_Crew = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnredeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlterersterToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReisepassNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GebDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GebOrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FunkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelscheinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalitaetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReihenfolgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelscheinDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelscheinVerbandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClubmitgliedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FB1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FB2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FB3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FB4DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AScheinDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MotorbootDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.R1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.dgv_Teilnehmer = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VeranstaltungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnmeldedatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeitragDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsVeranstalTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.taVeranstalTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.VeranstalTeilnehmerTableAdapter()
        Me.gb_Statistik = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonDrucken = New System.Windows.Forms.Button()
        Me.ButtonStarten = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VeranstaltungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxAnzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsVeranstaltungen = New System.Windows.Forms.BindingSource(Me.components)
        Me.taVeranstaltungen = New WindowsApplication1.dsAusbildungTableAdapters.VeranstaltungenTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Feld0DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld29DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld30DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld31DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld32DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld33DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld34DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld35DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld36DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld37DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld38DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld39DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld40DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld41DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld42DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld43DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld44DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld45DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld46DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld47DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld48DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld49DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Feld50DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTemp = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTemp = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter()
        Me.Feld1 = New System.Windows.Forms.TextBox()
        Me.Feld2 = New System.Windows.Forms.TextBox()
        Me.Feld3 = New System.Windows.Forms.TextBox()
        Me.Feld4 = New System.Windows.Forms.TextBox()
        Me.Feld5 = New System.Windows.Forms.TextBox()
        Me.Feld6 = New System.Windows.Forms.TextBox()
        Me.gb_Besucher.SuspendLayout()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Crew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Teilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVeranstalTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Statistik.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVeranstaltungen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_Besucher
        '
        Me.gb_Besucher.Controls.Add(Me.Label10)
        Me.gb_Besucher.Controls.Add(Me.Label11)
        Me.gb_Besucher.Controls.Add(Me.ProgressBar2)
        Me.gb_Besucher.Controls.Add(Me.Label6)
        Me.gb_Besucher.Controls.Add(Me.Label9)
        Me.gb_Besucher.Controls.Add(Me.ProgressBar1)
        Me.gb_Besucher.Controls.Add(Me.Label8)
        Me.gb_Besucher.Controls.Add(Me.Label7)
        Me.gb_Besucher.Controls.Add(Me.Label2)
        Me.gb_Besucher.Controls.Add(Me.Label1)
        Me.gb_Besucher.Controls.Add(Me.ProgressBarM)
        Me.gb_Besucher.Controls.Add(Me.ProgressBarW)
        Me.gb_Besucher.Location = New System.Drawing.Point(6, 82)
        Me.gb_Besucher.Name = "gb_Besucher"
        Me.gb_Besucher.Size = New System.Drawing.Size(566, 152)
        Me.gb_Besucher.TabIndex = 4
        Me.gb_Besucher.TabStop = False
        Me.gb_Besucher.Text = "Besucher"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(470, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Gäste"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(58, 120)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(403, 23)
        Me.ProgressBar2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Label6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "SFVS"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(58, 91)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(403, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Label7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "männlich"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "weiblich"
        '
        'ProgressBarM
        '
        Me.ProgressBarM.Location = New System.Drawing.Point(58, 48)
        Me.ProgressBarM.Name = "ProgressBarM"
        Me.ProgressBarM.Size = New System.Drawing.Size(403, 23)
        Me.ProgressBarM.TabIndex = 1
        '
        'ProgressBarW
        '
        Me.ProgressBarW.Location = New System.Drawing.Point(58, 19)
        Me.ProgressBarW.Name = "ProgressBarW"
        Me.ProgressBarW.Size = New System.Drawing.Size(403, 23)
        Me.ProgressBarW.TabIndex = 0
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgv_Crew
        '
        Me.dgv_Crew.AutoGenerateColumns = False
        Me.dgv_Crew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Crew.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.ZunameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.AnredeDataGridViewTextBoxColumn, Me.VZnameDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ToernnrDataGridViewTextBoxColumn, Me.AlterersterToernDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.ReisepassNrDataGridViewTextBoxColumn, Me.GebDatumDataGridViewTextBoxColumn, Me.GebOrtDataGridViewTextBoxColumn, Me.FunkDataGridViewTextBoxColumn, Me.SegelscheinDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.NationalitaetDataGridViewTextBoxColumn, Me.ReihenfolgeDataGridViewTextBoxColumn, Me.SegelscheinDatumDataGridViewTextBoxColumn, Me.SegelscheinVerbandDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.ClubmitgliedDataGridViewCheckBoxColumn, Me.FB1DataGridViewCheckBoxColumn, Me.FB2DataGridViewCheckBoxColumn, Me.FB3DataGridViewCheckBoxColumn, Me.FB4DataGridViewCheckBoxColumn, Me.AScheinDataGridViewCheckBoxColumn, Me.MotorbootDataGridViewCheckBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn})
        Me.dgv_Crew.DataSource = Me.bsCrewAdressen
        Me.dgv_Crew.Location = New System.Drawing.Point(752, 163)
        Me.dgv_Crew.Name = "dgv_Crew"
        Me.dgv_Crew.Size = New System.Drawing.Size(218, 104)
        Me.dgv_Crew.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
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
        'AnredeDataGridViewTextBoxColumn
        '
        Me.AnredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.HeaderText = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.Name = "AnredeDataGridViewTextBoxColumn"
        '
        'VZnameDataGridViewTextBoxColumn
        '
        Me.VZnameDataGridViewTextBoxColumn.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.Name = "VZnameDataGridViewTextBoxColumn"
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
        'GebDatumDataGridViewTextBoxColumn
        '
        Me.GebDatumDataGridViewTextBoxColumn.DataPropertyName = "GebDatum"
        Me.GebDatumDataGridViewTextBoxColumn.HeaderText = "GebDatum"
        Me.GebDatumDataGridViewTextBoxColumn.Name = "GebDatumDataGridViewTextBoxColumn"
        '
        'GebOrtDataGridViewTextBoxColumn
        '
        Me.GebOrtDataGridViewTextBoxColumn.DataPropertyName = "GebOrt"
        Me.GebOrtDataGridViewTextBoxColumn.HeaderText = "GebOrt"
        Me.GebOrtDataGridViewTextBoxColumn.Name = "GebOrtDataGridViewTextBoxColumn"
        '
        'FunkDataGridViewTextBoxColumn
        '
        Me.FunkDataGridViewTextBoxColumn.DataPropertyName = "Funk"
        Me.FunkDataGridViewTextBoxColumn.HeaderText = "Funk"
        Me.FunkDataGridViewTextBoxColumn.Name = "FunkDataGridViewTextBoxColumn"
        '
        'SegelscheinDataGridViewTextBoxColumn
        '
        Me.SegelscheinDataGridViewTextBoxColumn.DataPropertyName = "Segelschein"
        Me.SegelscheinDataGridViewTextBoxColumn.HeaderText = "Segelschein"
        Me.SegelscheinDataGridViewTextBoxColumn.Name = "SegelscheinDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'NationalitaetDataGridViewTextBoxColumn
        '
        Me.NationalitaetDataGridViewTextBoxColumn.DataPropertyName = "nationalitaet"
        Me.NationalitaetDataGridViewTextBoxColumn.HeaderText = "nationalitaet"
        Me.NationalitaetDataGridViewTextBoxColumn.Name = "NationalitaetDataGridViewTextBoxColumn"
        '
        'ReihenfolgeDataGridViewTextBoxColumn
        '
        Me.ReihenfolgeDataGridViewTextBoxColumn.DataPropertyName = "Reihenfolge"
        Me.ReihenfolgeDataGridViewTextBoxColumn.HeaderText = "Reihenfolge"
        Me.ReihenfolgeDataGridViewTextBoxColumn.Name = "ReihenfolgeDataGridViewTextBoxColumn"
        '
        'SegelscheinDatumDataGridViewTextBoxColumn
        '
        Me.SegelscheinDatumDataGridViewTextBoxColumn.DataPropertyName = "SegelscheinDatum"
        Me.SegelscheinDatumDataGridViewTextBoxColumn.HeaderText = "SegelscheinDatum"
        Me.SegelscheinDatumDataGridViewTextBoxColumn.Name = "SegelscheinDatumDataGridViewTextBoxColumn"
        '
        'SegelscheinVerbandDataGridViewTextBoxColumn
        '
        Me.SegelscheinVerbandDataGridViewTextBoxColumn.DataPropertyName = "SegelscheinVerband"
        Me.SegelscheinVerbandDataGridViewTextBoxColumn.HeaderText = "SegelscheinVerband"
        Me.SegelscheinVerbandDataGridViewTextBoxColumn.Name = "SegelscheinVerbandDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ClubmitgliedDataGridViewCheckBoxColumn
        '
        Me.ClubmitgliedDataGridViewCheckBoxColumn.DataPropertyName = "Clubmitglied"
        Me.ClubmitgliedDataGridViewCheckBoxColumn.HeaderText = "Clubmitglied"
        Me.ClubmitgliedDataGridViewCheckBoxColumn.Name = "ClubmitgliedDataGridViewCheckBoxColumn"
        '
        'FB1DataGridViewCheckBoxColumn
        '
        Me.FB1DataGridViewCheckBoxColumn.DataPropertyName = "FB1"
        Me.FB1DataGridViewCheckBoxColumn.HeaderText = "FB1"
        Me.FB1DataGridViewCheckBoxColumn.Name = "FB1DataGridViewCheckBoxColumn"
        '
        'FB2DataGridViewCheckBoxColumn
        '
        Me.FB2DataGridViewCheckBoxColumn.DataPropertyName = "FB2"
        Me.FB2DataGridViewCheckBoxColumn.HeaderText = "FB2"
        Me.FB2DataGridViewCheckBoxColumn.Name = "FB2DataGridViewCheckBoxColumn"
        '
        'FB3DataGridViewCheckBoxColumn
        '
        Me.FB3DataGridViewCheckBoxColumn.DataPropertyName = "FB3"
        Me.FB3DataGridViewCheckBoxColumn.HeaderText = "FB3"
        Me.FB3DataGridViewCheckBoxColumn.Name = "FB3DataGridViewCheckBoxColumn"
        '
        'FB4DataGridViewCheckBoxColumn
        '
        Me.FB4DataGridViewCheckBoxColumn.DataPropertyName = "FB4"
        Me.FB4DataGridViewCheckBoxColumn.HeaderText = "FB4"
        Me.FB4DataGridViewCheckBoxColumn.Name = "FB4DataGridViewCheckBoxColumn"
        '
        'AScheinDataGridViewCheckBoxColumn
        '
        Me.AScheinDataGridViewCheckBoxColumn.DataPropertyName = "A-Schein"
        Me.AScheinDataGridViewCheckBoxColumn.HeaderText = "A-Schein"
        Me.AScheinDataGridViewCheckBoxColumn.Name = "AScheinDataGridViewCheckBoxColumn"
        '
        'MotorbootDataGridViewCheckBoxColumn
        '
        Me.MotorbootDataGridViewCheckBoxColumn.DataPropertyName = "Motorboot"
        Me.MotorbootDataGridViewCheckBoxColumn.HeaderText = "Motorboot"
        Me.MotorbootDataGridViewCheckBoxColumn.Name = "MotorbootDataGridViewCheckBoxColumn"
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
        'taCrewAdressen
        '
        Me.taCrewAdressen.ClearBeforeFill = True
        '
        'dgv_Teilnehmer
        '
        Me.dgv_Teilnehmer.AutoGenerateColumns = False
        Me.dgv_Teilnehmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Teilnehmer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.VZnameDataGridViewTextBoxColumn1, Me.VeranstaltungDataGridViewTextBoxColumn, Me.VeranstaltungsdatumDataGridViewTextBoxColumn, Me.AnmeldedatumDataGridViewTextBoxColumn, Me.BeitragDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn})
        Me.dgv_Teilnehmer.DataSource = Me.bsVeranstalTeilnehmer
        Me.dgv_Teilnehmer.Location = New System.Drawing.Point(752, 301)
        Me.dgv_Teilnehmer.Name = "dgv_Teilnehmer"
        Me.dgv_Teilnehmer.Size = New System.Drawing.Size(240, 150)
        Me.dgv_Teilnehmer.TabIndex = 7
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'VZnameDataGridViewTextBoxColumn1
        '
        Me.VZnameDataGridViewTextBoxColumn1.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.Name = "VZnameDataGridViewTextBoxColumn1"
        '
        'VeranstaltungDataGridViewTextBoxColumn
        '
        Me.VeranstaltungDataGridViewTextBoxColumn.DataPropertyName = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn.HeaderText = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn.Name = "VeranstaltungDataGridViewTextBoxColumn"
        '
        'VeranstaltungsdatumDataGridViewTextBoxColumn
        '
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn.DataPropertyName = "Veranstaltungsdatum"
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn.HeaderText = "Veranstaltungsdatum"
        Me.VeranstaltungsdatumDataGridViewTextBoxColumn.Name = "VeranstaltungsdatumDataGridViewTextBoxColumn"
        '
        'AnmeldedatumDataGridViewTextBoxColumn
        '
        Me.AnmeldedatumDataGridViewTextBoxColumn.DataPropertyName = "Anmeldedatum"
        Me.AnmeldedatumDataGridViewTextBoxColumn.HeaderText = "Anmeldedatum"
        Me.AnmeldedatumDataGridViewTextBoxColumn.Name = "AnmeldedatumDataGridViewTextBoxColumn"
        '
        'BeitragDataGridViewTextBoxColumn
        '
        Me.BeitragDataGridViewTextBoxColumn.DataPropertyName = "Beitrag"
        Me.BeitragDataGridViewTextBoxColumn.HeaderText = "Beitrag"
        Me.BeitragDataGridViewTextBoxColumn.Name = "BeitragDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        '
        'bsVeranstalTeilnehmer
        '
        Me.bsVeranstalTeilnehmer.DataMember = "VeranstalTeilnehmer"
        Me.bsVeranstalTeilnehmer.DataSource = Me.DsAusbildung
        '
        'taVeranstalTeilnehmer
        '
        Me.taVeranstalTeilnehmer.ClearBeforeFill = True
        '
        'gb_Statistik
        '
        Me.gb_Statistik.Controls.Add(Me.TextBox2)
        Me.gb_Statistik.Controls.Add(Me.TextBox1)
        Me.gb_Statistik.Controls.Add(Me.Label5)
        Me.gb_Statistik.Controls.Add(Me.Label4)
        Me.gb_Statistik.Controls.Add(Me.Label3)
        Me.gb_Statistik.Controls.Add(Me.gb_Besucher)
        Me.gb_Statistik.Location = New System.Drawing.Point(27, 19)
        Me.gb_Statistik.Name = "gb_Statistik"
        Me.gb_Statistik.Size = New System.Drawing.Size(578, 252)
        Me.gb_Statistik.TabIndex = 9
        Me.gb_Statistik.TabStop = False
        Me.gb_Statistik.Text = "Statistik"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(199, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "bis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "von"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jahrgänge der Auswertung:"
        '
        'ButtonDrucken
        '
        Me.ButtonDrucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDrucken.Location = New System.Drawing.Point(305, 289)
        Me.ButtonDrucken.Name = "ButtonDrucken"
        Me.ButtonDrucken.Size = New System.Drawing.Size(117, 44)
        Me.ButtonDrucken.TabIndex = 4
        Me.ButtonDrucken.Text = "Drucken"
        Me.ButtonDrucken.UseVisualStyleBackColor = True
        '
        'ButtonStarten
        '
        Me.ButtonStarten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStarten.Location = New System.Drawing.Point(488, 289)
        Me.ButtonStarten.Name = "ButtonStarten"
        Me.ButtonStarten.Size = New System.Drawing.Size(117, 44)
        Me.ButtonStarten.TabIndex = 2
        Me.ButtonStarten.Text = "Starten"
        Me.ButtonStarten.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.VeranstaltungDataGridViewTextBoxColumn1, Me.DatumDataGridViewTextBoxColumn, Me.KostenDataGridViewTextBoxColumn, Me.MaxAnzahlDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn2, Me.Ort1DataGridViewTextBoxColumn, Me.Ort2DataGridViewTextBoxColumn, Me.Ort3DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsVeranstaltungen
        Me.DataGridView1.Location = New System.Drawing.Point(991, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 114)
        Me.DataGridView1.TabIndex = 12
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'VeranstaltungDataGridViewTextBoxColumn1
        '
        Me.VeranstaltungDataGridViewTextBoxColumn1.DataPropertyName = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn1.HeaderText = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn1.Name = "VeranstaltungDataGridViewTextBoxColumn1"
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        '
        'KostenDataGridViewTextBoxColumn
        '
        Me.KostenDataGridViewTextBoxColumn.DataPropertyName = "Kosten"
        Me.KostenDataGridViewTextBoxColumn.HeaderText = "Kosten"
        Me.KostenDataGridViewTextBoxColumn.Name = "KostenDataGridViewTextBoxColumn"
        '
        'MaxAnzahlDataGridViewTextBoxColumn
        '
        Me.MaxAnzahlDataGridViewTextBoxColumn.DataPropertyName = "MaxAnzahl"
        Me.MaxAnzahlDataGridViewTextBoxColumn.HeaderText = "MaxAnzahl"
        Me.MaxAnzahlDataGridViewTextBoxColumn.Name = "MaxAnzahlDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn2
        '
        Me.BemerkungDataGridViewTextBoxColumn2.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.Name = "BemerkungDataGridViewTextBoxColumn2"
        '
        'Ort1DataGridViewTextBoxColumn
        '
        Me.Ort1DataGridViewTextBoxColumn.DataPropertyName = "Ort1"
        Me.Ort1DataGridViewTextBoxColumn.HeaderText = "Ort1"
        Me.Ort1DataGridViewTextBoxColumn.Name = "Ort1DataGridViewTextBoxColumn"
        '
        'Ort2DataGridViewTextBoxColumn
        '
        Me.Ort2DataGridViewTextBoxColumn.DataPropertyName = "Ort2"
        Me.Ort2DataGridViewTextBoxColumn.HeaderText = "Ort2"
        Me.Ort2DataGridViewTextBoxColumn.Name = "Ort2DataGridViewTextBoxColumn"
        '
        'Ort3DataGridViewTextBoxColumn
        '
        Me.Ort3DataGridViewTextBoxColumn.DataPropertyName = "Ort3"
        Me.Ort3DataGridViewTextBoxColumn.HeaderText = "Ort3"
        Me.Ort3DataGridViewTextBoxColumn.Name = "Ort3DataGridViewTextBoxColumn"
        '
        'bsVeranstaltungen
        '
        Me.bsVeranstaltungen.DataMember = "Veranstaltungen"
        Me.bsVeranstaltungen.DataSource = Me.DsAusbildung
        '
        'taVeranstaltungen
        '
        Me.taVeranstaltungen.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.Feld1DataGridViewTextBoxColumn, Me.Feld2DataGridViewTextBoxColumn, Me.Feld3DataGridViewTextBoxColumn, Me.Feld4DataGridViewTextBoxColumn, Me.Feld5DataGridViewTextBoxColumn, Me.Feld6DataGridViewTextBoxColumn, Me.Feld7DataGridViewTextBoxColumn, Me.Feld8DataGridViewTextBoxColumn, Me.Feld9DataGridViewTextBoxColumn, Me.Feld10DataGridViewTextBoxColumn, Me.Feld11DataGridViewTextBoxColumn, Me.Feld12DataGridViewTextBoxColumn, Me.Feld13DataGridViewTextBoxColumn, Me.Feld14DataGridViewTextBoxColumn, Me.Feld15DataGridViewTextBoxColumn, Me.Feld16DataGridViewTextBoxColumn, Me.Feld17DataGridViewTextBoxColumn, Me.Feld18DataGridViewTextBoxColumn, Me.Feld19DataGridViewTextBoxColumn, Me.Feld20DataGridViewTextBoxColumn, Me.Feld21DataGridViewTextBoxColumn, Me.Feld22DataGridViewTextBoxColumn, Me.Feld23DataGridViewTextBoxColumn, Me.Feld24DataGridViewTextBoxColumn, Me.Feld25DataGridViewTextBoxColumn, Me.Feld26DataGridViewTextBoxColumn, Me.Feld27DataGridViewTextBoxColumn, Me.Feld28DataGridViewTextBoxColumn, Me.Feld0DataGridViewTextBoxColumn, Me.Feld29DataGridViewTextBoxColumn, Me.Feld30DataGridViewTextBoxColumn, Me.Feld31DataGridViewTextBoxColumn, Me.Feld32DataGridViewTextBoxColumn, Me.Feld33DataGridViewTextBoxColumn, Me.Feld34DataGridViewTextBoxColumn, Me.Feld35DataGridViewTextBoxColumn, Me.Feld36DataGridViewTextBoxColumn, Me.Feld37DataGridViewTextBoxColumn, Me.Feld38DataGridViewTextBoxColumn, Me.Feld39DataGridViewTextBoxColumn, Me.Feld40DataGridViewTextBoxColumn, Me.Feld41DataGridViewTextBoxColumn, Me.Feld42DataGridViewTextBoxColumn, Me.Feld43DataGridViewTextBoxColumn, Me.Feld44DataGridViewTextBoxColumn, Me.Feld45DataGridViewTextBoxColumn, Me.Feld46DataGridViewTextBoxColumn, Me.Feld47DataGridViewTextBoxColumn, Me.Feld48DataGridViewTextBoxColumn, Me.Feld49DataGridViewTextBoxColumn, Me.Feld50DataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsTemp
        Me.DataGridView2.Location = New System.Drawing.Point(752, 13)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 13
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
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
        'Feld0DataGridViewTextBoxColumn
        '
        Me.Feld0DataGridViewTextBoxColumn.DataPropertyName = "Feld0"
        Me.Feld0DataGridViewTextBoxColumn.HeaderText = "Feld0"
        Me.Feld0DataGridViewTextBoxColumn.Name = "Feld0DataGridViewTextBoxColumn"
        '
        'Feld29DataGridViewTextBoxColumn
        '
        Me.Feld29DataGridViewTextBoxColumn.DataPropertyName = "Feld29"
        Me.Feld29DataGridViewTextBoxColumn.HeaderText = "Feld29"
        Me.Feld29DataGridViewTextBoxColumn.Name = "Feld29DataGridViewTextBoxColumn"
        '
        'Feld30DataGridViewTextBoxColumn
        '
        Me.Feld30DataGridViewTextBoxColumn.DataPropertyName = "Feld30"
        Me.Feld30DataGridViewTextBoxColumn.HeaderText = "Feld30"
        Me.Feld30DataGridViewTextBoxColumn.Name = "Feld30DataGridViewTextBoxColumn"
        '
        'Feld31DataGridViewTextBoxColumn
        '
        Me.Feld31DataGridViewTextBoxColumn.DataPropertyName = "Feld31"
        Me.Feld31DataGridViewTextBoxColumn.HeaderText = "Feld31"
        Me.Feld31DataGridViewTextBoxColumn.Name = "Feld31DataGridViewTextBoxColumn"
        '
        'Feld32DataGridViewTextBoxColumn
        '
        Me.Feld32DataGridViewTextBoxColumn.DataPropertyName = "Feld32"
        Me.Feld32DataGridViewTextBoxColumn.HeaderText = "Feld32"
        Me.Feld32DataGridViewTextBoxColumn.Name = "Feld32DataGridViewTextBoxColumn"
        '
        'Feld33DataGridViewTextBoxColumn
        '
        Me.Feld33DataGridViewTextBoxColumn.DataPropertyName = "Feld33"
        Me.Feld33DataGridViewTextBoxColumn.HeaderText = "Feld33"
        Me.Feld33DataGridViewTextBoxColumn.Name = "Feld33DataGridViewTextBoxColumn"
        '
        'Feld34DataGridViewTextBoxColumn
        '
        Me.Feld34DataGridViewTextBoxColumn.DataPropertyName = "Feld34"
        Me.Feld34DataGridViewTextBoxColumn.HeaderText = "Feld34"
        Me.Feld34DataGridViewTextBoxColumn.Name = "Feld34DataGridViewTextBoxColumn"
        '
        'Feld35DataGridViewTextBoxColumn
        '
        Me.Feld35DataGridViewTextBoxColumn.DataPropertyName = "Feld35"
        Me.Feld35DataGridViewTextBoxColumn.HeaderText = "Feld35"
        Me.Feld35DataGridViewTextBoxColumn.Name = "Feld35DataGridViewTextBoxColumn"
        '
        'Feld36DataGridViewTextBoxColumn
        '
        Me.Feld36DataGridViewTextBoxColumn.DataPropertyName = "Feld36"
        Me.Feld36DataGridViewTextBoxColumn.HeaderText = "Feld36"
        Me.Feld36DataGridViewTextBoxColumn.Name = "Feld36DataGridViewTextBoxColumn"
        '
        'Feld37DataGridViewTextBoxColumn
        '
        Me.Feld37DataGridViewTextBoxColumn.DataPropertyName = "Feld37"
        Me.Feld37DataGridViewTextBoxColumn.HeaderText = "Feld37"
        Me.Feld37DataGridViewTextBoxColumn.Name = "Feld37DataGridViewTextBoxColumn"
        '
        'Feld38DataGridViewTextBoxColumn
        '
        Me.Feld38DataGridViewTextBoxColumn.DataPropertyName = "Feld38"
        Me.Feld38DataGridViewTextBoxColumn.HeaderText = "Feld38"
        Me.Feld38DataGridViewTextBoxColumn.Name = "Feld38DataGridViewTextBoxColumn"
        '
        'Feld39DataGridViewTextBoxColumn
        '
        Me.Feld39DataGridViewTextBoxColumn.DataPropertyName = "Feld39"
        Me.Feld39DataGridViewTextBoxColumn.HeaderText = "Feld39"
        Me.Feld39DataGridViewTextBoxColumn.Name = "Feld39DataGridViewTextBoxColumn"
        '
        'Feld40DataGridViewTextBoxColumn
        '
        Me.Feld40DataGridViewTextBoxColumn.DataPropertyName = "Feld40"
        Me.Feld40DataGridViewTextBoxColumn.HeaderText = "Feld40"
        Me.Feld40DataGridViewTextBoxColumn.Name = "Feld40DataGridViewTextBoxColumn"
        '
        'Feld41DataGridViewTextBoxColumn
        '
        Me.Feld41DataGridViewTextBoxColumn.DataPropertyName = "Feld41"
        Me.Feld41DataGridViewTextBoxColumn.HeaderText = "Feld41"
        Me.Feld41DataGridViewTextBoxColumn.Name = "Feld41DataGridViewTextBoxColumn"
        '
        'Feld42DataGridViewTextBoxColumn
        '
        Me.Feld42DataGridViewTextBoxColumn.DataPropertyName = "Feld42"
        Me.Feld42DataGridViewTextBoxColumn.HeaderText = "Feld42"
        Me.Feld42DataGridViewTextBoxColumn.Name = "Feld42DataGridViewTextBoxColumn"
        '
        'Feld43DataGridViewTextBoxColumn
        '
        Me.Feld43DataGridViewTextBoxColumn.DataPropertyName = "Feld43"
        Me.Feld43DataGridViewTextBoxColumn.HeaderText = "Feld43"
        Me.Feld43DataGridViewTextBoxColumn.Name = "Feld43DataGridViewTextBoxColumn"
        '
        'Feld44DataGridViewTextBoxColumn
        '
        Me.Feld44DataGridViewTextBoxColumn.DataPropertyName = "Feld44"
        Me.Feld44DataGridViewTextBoxColumn.HeaderText = "Feld44"
        Me.Feld44DataGridViewTextBoxColumn.Name = "Feld44DataGridViewTextBoxColumn"
        '
        'Feld45DataGridViewTextBoxColumn
        '
        Me.Feld45DataGridViewTextBoxColumn.DataPropertyName = "Feld45"
        Me.Feld45DataGridViewTextBoxColumn.HeaderText = "Feld45"
        Me.Feld45DataGridViewTextBoxColumn.Name = "Feld45DataGridViewTextBoxColumn"
        '
        'Feld46DataGridViewTextBoxColumn
        '
        Me.Feld46DataGridViewTextBoxColumn.DataPropertyName = "Feld46"
        Me.Feld46DataGridViewTextBoxColumn.HeaderText = "Feld46"
        Me.Feld46DataGridViewTextBoxColumn.Name = "Feld46DataGridViewTextBoxColumn"
        '
        'Feld47DataGridViewTextBoxColumn
        '
        Me.Feld47DataGridViewTextBoxColumn.DataPropertyName = "Feld47"
        Me.Feld47DataGridViewTextBoxColumn.HeaderText = "Feld47"
        Me.Feld47DataGridViewTextBoxColumn.Name = "Feld47DataGridViewTextBoxColumn"
        '
        'Feld48DataGridViewTextBoxColumn
        '
        Me.Feld48DataGridViewTextBoxColumn.DataPropertyName = "Feld48"
        Me.Feld48DataGridViewTextBoxColumn.HeaderText = "Feld48"
        Me.Feld48DataGridViewTextBoxColumn.Name = "Feld48DataGridViewTextBoxColumn"
        '
        'Feld49DataGridViewTextBoxColumn
        '
        Me.Feld49DataGridViewTextBoxColumn.DataPropertyName = "Feld49"
        Me.Feld49DataGridViewTextBoxColumn.HeaderText = "Feld49"
        Me.Feld49DataGridViewTextBoxColumn.Name = "Feld49DataGridViewTextBoxColumn"
        '
        'Feld50DataGridViewTextBoxColumn
        '
        Me.Feld50DataGridViewTextBoxColumn.DataPropertyName = "Feld50"
        Me.Feld50DataGridViewTextBoxColumn.HeaderText = "Feld50"
        Me.Feld50DataGridViewTextBoxColumn.Name = "Feld50DataGridViewTextBoxColumn"
        '
        'bsTemp
        '
        Me.bsTemp.DataMember = "Temp"
        Me.bsTemp.DataSource = Me.dsToernverwaltung
        '
        'taTemp
        '
        Me.taTemp.ClearBeforeFill = True
        '
        'Feld1
        '
        Me.Feld1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld1", True))
        Me.Feld1.Location = New System.Drawing.Point(1042, 19)
        Me.Feld1.Name = "Feld1"
        Me.Feld1.Size = New System.Drawing.Size(100, 20)
        Me.Feld1.TabIndex = 14
        '
        'Feld2
        '
        Me.Feld2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld2", True))
        Me.Feld2.Location = New System.Drawing.Point(1042, 46)
        Me.Feld2.Name = "Feld2"
        Me.Feld2.Size = New System.Drawing.Size(100, 20)
        Me.Feld2.TabIndex = 15
        '
        'Feld3
        '
        Me.Feld3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld3", True))
        Me.Feld3.Location = New System.Drawing.Point(1042, 75)
        Me.Feld3.Name = "Feld3"
        Me.Feld3.Size = New System.Drawing.Size(100, 20)
        Me.Feld3.TabIndex = 16
        '
        'Feld4
        '
        Me.Feld4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld4", True))
        Me.Feld4.Location = New System.Drawing.Point(1042, 102)
        Me.Feld4.Name = "Feld4"
        Me.Feld4.Size = New System.Drawing.Size(100, 20)
        Me.Feld4.TabIndex = 17
        '
        'Feld5
        '
        Me.Feld5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld5", True))
        Me.Feld5.Location = New System.Drawing.Point(1042, 125)
        Me.Feld5.Name = "Feld5"
        Me.Feld5.Size = New System.Drawing.Size(100, 20)
        Me.Feld5.TabIndex = 18
        '
        'Feld6
        '
        Me.Feld6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTemp, "Feld6", True))
        Me.Feld6.Location = New System.Drawing.Point(1042, 289)
        Me.Feld6.Name = "Feld6"
        Me.Feld6.Size = New System.Drawing.Size(100, 20)
        Me.Feld6.TabIndex = 19
        '
        'AktivStatistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 345)
        Me.Controls.Add(Me.Feld6)
        Me.Controls.Add(Me.Feld5)
        Me.Controls.Add(Me.Feld4)
        Me.Controls.Add(Me.Feld3)
        Me.Controls.Add(Me.Feld2)
        Me.Controls.Add(Me.Feld1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonDrucken)
        Me.Controls.Add(Me.ButtonStarten)
        Me.Controls.Add(Me.gb_Statistik)
        Me.Controls.Add(Me.dgv_Teilnehmer)
        Me.Controls.Add(Me.dgv_Crew)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AktivStatistik"
        Me.Text = "Statistik der Aktivitäten"
        Me.gb_Besucher.ResumeLayout(False)
        Me.gb_Besucher.PerformLayout()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Crew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Teilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVeranstalTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Statistik.ResumeLayout(False)
        Me.gb_Statistik.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVeranstaltungen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_Besucher As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarM As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBarW As System.Windows.Forms.ProgressBar
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents dgv_Crew As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZunameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnredeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlterersterToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReisepassNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebOrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FunkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalitaetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReihenfolgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinVerbandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClubmitgliedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FB1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FB2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FB3DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FB4DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AScheinDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MotorbootDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_Teilnehmer As System.Windows.Forms.DataGridView
    Friend WithEvents bsVeranstalTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taVeranstalTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.VeranstalTeilnehmerTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VeranstaltungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VeranstaltungsdatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnmeldedatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeitragDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gb_Statistik As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDrucken As System.Windows.Forms.Button
    Friend WithEvents ButtonStarten As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bsVeranstaltungen As System.Windows.Forms.BindingSource
    Friend WithEvents taVeranstaltungen As WindowsApplication1.dsAusbildungTableAdapters.VeranstaltungenTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VeranstaltungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxAnzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ort1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ort2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ort3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTemp As System.Windows.Forms.BindingSource
    Friend WithEvents taTemp As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Feld0DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld29DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld30DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld31DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld32DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld33DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld34DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld35DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld36DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld37DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld38DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld39DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld40DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld41DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld42DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld43DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld44DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld45DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld46DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld47DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld48DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld49DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld50DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld1 As System.Windows.Forms.TextBox
    Friend WithEvents Feld2 As System.Windows.Forms.TextBox
    Friend WithEvents Feld3 As System.Windows.Forms.TextBox
    Friend WithEvents Feld4 As System.Windows.Forms.TextBox
    Friend WithEvents Feld5 As System.Windows.Forms.TextBox
    Friend WithEvents Feld6 As System.Windows.Forms.TextBox
End Class
