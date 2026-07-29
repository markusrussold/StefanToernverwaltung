<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Veranstalltung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Veranstalltung))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bsVeranstaltungen = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.bsVeranstalTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.VeranstaltungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxAnzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VZnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnredeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlterersterToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReisepassNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GebDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GebOrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FunkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelscheinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1Speichern = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3VLoeschen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Veranstaltung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Veranstaltungsdatum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anmeldedatum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Beitrag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.bsStandort = New System.Windows.Forms.BindingSource(Me.components)
        Me.GruppeVeranstaltung = New System.Windows.Forms.GroupBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button4TSpeichern = New System.Windows.Forms.Button()
        Me.Button1TLoeschen = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox6Kalender = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button5Zurueck = New System.Windows.Forms.Button()
        Me.Button7Speichern = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Button1Drucken = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.taVeranstalTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.VeranstalTeilnehmerTableAdapter()
        Me.taVeranstaltungen = New WindowsApplication1.dsAusbildungTableAdapters.VeranstaltungenTableAdapter()
        Me.taTemp = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.BezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrasseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxTeilnehmerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfrastrukturDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KarteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBSeiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taStandort = New WindowsApplication1.dsAusbildungTableAdapters.StandortTableAdapter()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        CType(Me.bsVeranstaltungen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsVeranstalTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.bsStandort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GruppeVeranstaltung.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6Kalender.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Veranstaltung", True))
        Me.TextBox1.Location = New System.Drawing.Point(332, 576)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 22)
        Me.TextBox1.TabIndex = 0
        '
        'bsVeranstaltungen
        '
        Me.bsVeranstaltungen.DataMember = "Veranstaltungen"
        Me.bsVeranstaltungen.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Kosten", True))
        Me.TextBox3.Location = New System.Drawing.Point(332, 604)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "MaxAnzahl", True))
        Me.TextBox4.Location = New System.Drawing.Point(332, 632)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(75, 22)
        Me.TextBox4.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.RichTextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 157)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bemerkung"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(36, 41)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(524, 132)
        Me.RichTextBox1.TabIndex = 92
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstalTeilnehmer, "Bemerkung", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(9, 19)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(524, 132)
        Me.RichTextBox2.TabIndex = 28
        Me.RichTextBox2.Text = ""
        '
        'bsVeranstalTeilnehmer
        '
        Me.bsVeranstalTeilnehmer.DataMember = "VeranstalTeilnehmer"
        Me.bsVeranstalTeilnehmer.DataSource = Me.DsAusbildung
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(979, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 179)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Veranstaltungen"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VeranstaltungDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.KostenDataGridViewTextBoxColumn, Me.MaxAnzahlDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.Ort1DataGridViewTextBoxColumn, Me.Ort2DataGridViewTextBoxColumn, Me.Ort3DataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.bsVeranstaltungen
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(484, 158)
        Me.DataGridView2.TabIndex = 0
        '
        'VeranstaltungDataGridViewTextBoxColumn
        '
        Me.VeranstaltungDataGridViewTextBoxColumn.DataPropertyName = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn.HeaderText = "Veranstaltung"
        Me.VeranstaltungDataGridViewTextBoxColumn.Name = "VeranstaltungDataGridViewTextBoxColumn"
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
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
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
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(1001, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(490, 179)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Adressenauswahl"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZnameDataGridViewTextBoxColumn, Me.AnredeDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ToernnrDataGridViewTextBoxColumn, Me.AlterersterToernDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn, Me.ReisepassNrDataGridViewTextBoxColumn, Me.GebDatumDataGridViewTextBoxColumn, Me.ZunameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.GebOrtDataGridViewTextBoxColumn, Me.FunkDataGridViewTextBoxColumn, Me.SegelscheinDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.NationalitaetDataGridViewTextBoxColumn, Me.ReihenfolgeDataGridViewTextBoxColumn, Me.SegelscheinDatumDataGridViewTextBoxColumn, Me.SegelscheinVerbandDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.ClubmitgliedDataGridViewCheckBoxColumn, Me.FB1DataGridViewCheckBoxColumn, Me.FB2DataGridViewCheckBoxColumn, Me.FB3DataGridViewCheckBoxColumn, Me.FB4DataGridViewCheckBoxColumn, Me.AScheinDataGridViewCheckBoxColumn, Me.MotorbootDataGridViewCheckBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsCrewAdressen
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(484, 158)
        Me.DataGridView1.TabIndex = 0
        '
        'VZnameDataGridViewTextBoxColumn
        '
        Me.VZnameDataGridViewTextBoxColumn.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn.Name = "VZnameDataGridViewTextBoxColumn"
        '
        'AnredeDataGridViewTextBoxColumn
        '
        Me.AnredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.HeaderText = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.Name = "AnredeDataGridViewTextBoxColumn"
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
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
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(172, 26)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(358, 22)
        Me.TextBox5.TabIndex = 8
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(579, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(147, 340)
        Me.ListBox1.TabIndex = 9
        '
        'Button1Speichern
        '
        Me.Button1Speichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Speichern.Location = New System.Drawing.Point(600, 422)
        Me.Button1Speichern.Name = "Button1Speichern"
        Me.Button1Speichern.Size = New System.Drawing.Size(126, 43)
        Me.Button1Speichern.TabIndex = 10
        Me.Button1Speichern.Text = "Speichern"
        Me.Button1Speichern.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(417, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 43)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Formular löschen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3VLoeschen
        '
        Me.Button3VLoeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3VLoeschen.Location = New System.Drawing.Point(10, 424)
        Me.Button3VLoeschen.Name = "Button3VLoeschen"
        Me.Button3VLoeschen.Size = New System.Drawing.Size(126, 43)
        Me.Button3VLoeschen.TabIndex = 12
        Me.Button3VLoeschen.Text = "Veranstaltung löschen"
        Me.Button3VLoeschen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(576, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Teilnehmer mit Klick verwalten"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(576, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Teilnehmer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Veranstaltung"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Kosten"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Teilnehmer Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datum"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(372, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Max.Anzahl"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView3)
        Me.GroupBox4.Location = New System.Drawing.Point(1004, 342)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(490, 179)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Teilnehmer"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn18, Me.Veranstaltung, Me.Veranstaltungsdatum, Me.Anmeldedatum, Me.Beitrag})
        Me.DataGridView3.DataSource = Me.bsVeranstalTeilnehmer
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(484, 158)
        Me.DataGridView3.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VZname"
        Me.DataGridViewTextBoxColumn5.HeaderText = "VZname"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Bemerkung"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Bemerkung"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'Veranstaltung
        '
        Me.Veranstaltung.DataPropertyName = "Veranstaltung"
        Me.Veranstaltung.HeaderText = "Veranstaltung"
        Me.Veranstaltung.Name = "Veranstaltung"
        '
        'Veranstaltungsdatum
        '
        Me.Veranstaltungsdatum.DataPropertyName = "Veranstaltungsdatum"
        Me.Veranstaltungsdatum.HeaderText = "Veranstaltungsdatum"
        Me.Veranstaltungsdatum.Name = "Veranstaltungsdatum"
        '
        'Anmeldedatum
        '
        Me.Anmeldedatum.DataPropertyName = "Anmeldedatum"
        Me.Anmeldedatum.HeaderText = "Anmeldedatum"
        Me.Anmeldedatum.Name = "Anmeldedatum"
        '
        'Beitrag
        '
        Me.Beitrag.DataPropertyName = "Beitrag"
        Me.Beitrag.HeaderText = "Beitrag"
        Me.Beitrag.Name = "Beitrag"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(101, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.CausesValidation = False
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Datum", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(458, 16)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(75, 22)
        Me.MaskedTextBox1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox18)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox5)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox5.Controls.Add(Me.TextBox8)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(789, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(171, 270)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "VZname", True))
        Me.TextBox18.Location = New System.Drawing.Point(22, 48)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 22)
        Me.TextBox18.TabIndex = 7
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(22, 233)
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox5.TabIndex = 6
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(22, 191)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox4.TabIndex = 5
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(22, 147)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox2.TabIndex = 4
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(22, 116)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 22)
        Me.TextBox8.TabIndex = 3
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(22, 81)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(22, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsStandort, "Kosten", True))
        Me.TextBox6.Location = New System.Drawing.Point(142, 137)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 10
        '
        'bsStandort
        '
        Me.bsStandort.DataMember = "Standort"
        Me.bsStandort.DataSource = Me.DsAusbildung
        '
        'GruppeVeranstaltung
        '
        Me.GruppeVeranstaltung.Controls.Add(Me.TextBox19)
        Me.GruppeVeranstaltung.Controls.Add(Me.PictureBox3)
        Me.GruppeVeranstaltung.Controls.Add(Me.TextBox17)
        Me.GruppeVeranstaltung.Controls.Add(Me.TextBox16)
        Me.GruppeVeranstaltung.Controls.Add(Me.TextBox14)
        Me.GruppeVeranstaltung.Controls.Add(Me.TextBox13)
        Me.GruppeVeranstaltung.Controls.Add(Me.PictureBox10)
        Me.GruppeVeranstaltung.Controls.Add(Me.TextBox6)
        Me.GruppeVeranstaltung.Controls.Add(Me.Label10)
        Me.GruppeVeranstaltung.Controls.Add(Me.MaskedTextBox1)
        Me.GruppeVeranstaltung.Controls.Add(Me.Label4)
        Me.GruppeVeranstaltung.Controls.Add(Me.Label3)
        Me.GruppeVeranstaltung.Controls.Add(Me.PictureBox4)
        Me.GruppeVeranstaltung.Controls.Add(Me.Label6)
        Me.GruppeVeranstaltung.Controls.Add(Me.Label7)
        Me.GruppeVeranstaltung.Location = New System.Drawing.Point(10, 12)
        Me.GruppeVeranstaltung.Name = "GruppeVeranstaltung"
        Me.GruppeVeranstaltung.Size = New System.Drawing.Size(543, 165)
        Me.GruppeVeranstaltung.TabIndex = 0
        Me.GruppeVeranstaltung.TabStop = False
        Me.GruppeVeranstaltung.Text = "Veranstaltung"
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Ort1", True))
        Me.TextBox19.Location = New System.Drawing.Point(142, 51)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(390, 22)
        Me.TextBox19.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(97, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 95
        Me.PictureBox3.TabStop = False
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Ort3", True))
        Me.TextBox17.Location = New System.Drawing.Point(142, 109)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(391, 22)
        Me.TextBox17.TabIndex = 94
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Ort2", True))
        Me.TextBox16.Location = New System.Drawing.Point(142, 81)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(391, 22)
        Me.TextBox16.TabIndex = 93
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsStandort, "MaxTeilnehmer", True))
        Me.TextBox14.Location = New System.Drawing.Point(458, 137)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(75, 22)
        Me.TextBox14.TabIndex = 12
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Veranstaltung", True))
        Me.TextBox13.Location = New System.Drawing.Point(142, 16)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(221, 22)
        Me.TextBox13.TabIndex = 5
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(417, 9)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 27
        Me.PictureBox10.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Ort"
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsStandort, "Bezeichnung", True))
        Me.TextBox15.Location = New System.Drawing.Point(19, 521)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(92, 22)
        Me.TextBox15.TabIndex = 92
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(332, 729)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(87, 22)
        Me.TextBox12.TabIndex = 26
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(329, 692)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(90, 22)
        Me.TextBox11.TabIndex = 25
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(332, 664)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(75, 22)
        Me.TextBox10.TabIndex = 24
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 180)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(540, 62)
        Me.GroupBox6.TabIndex = 26
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Weitere Teilnehmer"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.PictureBox2)
        Me.GroupBox7.Controls.Add(Me.Button4TSpeichern)
        Me.GroupBox7.Controls.Add(Me.Button1TLoeschen)
        Me.GroupBox7.Controls.Add(Me.TextBox9)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(525, 544)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(490, 190)
        Me.GroupBox7.TabIndex = 27
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Button4TSpeichern
        '
        Me.Button4TSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4TSpeichern.Location = New System.Drawing.Point(347, 141)
        Me.Button4TSpeichern.Name = "Button4TSpeichern"
        Me.Button4TSpeichern.Size = New System.Drawing.Size(126, 43)
        Me.Button4TSpeichern.TabIndex = 14
        Me.Button4TSpeichern.Text = "Speichern"
        Me.Button4TSpeichern.UseVisualStyleBackColor = True
        '
        'Button1TLoeschen
        '
        Me.Button1TLoeschen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1TLoeschen.Location = New System.Drawing.Point(114, 141)
        Me.Button1TLoeschen.Name = "Button1TLoeschen"
        Me.Button1TLoeschen.Size = New System.Drawing.Size(126, 43)
        Me.Button1TLoeschen.TabIndex = 13
        Me.Button1TLoeschen.Text = "Teilnehmer löschen"
        Me.Button1TLoeschen.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstalTeilnehmer, "Beitrag", True))
        Me.TextBox9.Location = New System.Drawing.Point(225, 98)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 24)
        Me.TextBox9.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Geleisteter Beitrag"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Anmeldedatum"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstalTeilnehmer, "Anmeldedatum", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(225, 41)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 24)
        Me.MaskedTextBox3.TabIndex = 0
        '
        'GroupBox6Kalender
        '
        Me.GroupBox6Kalender.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox6Kalender.Controls.Add(Me.Button5Zurueck)
        Me.GroupBox6Kalender.Controls.Add(Me.Button7Speichern)
        Me.GroupBox6Kalender.Location = New System.Drawing.Point(789, 302)
        Me.GroupBox6Kalender.Name = "GroupBox6Kalender"
        Me.GroupBox6Kalender.Size = New System.Drawing.Size(205, 219)
        Me.GroupBox6Kalender.TabIndex = 88
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
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.Feld1DataGridViewTextBoxColumn, Me.Feld2DataGridViewTextBoxColumn, Me.Feld3DataGridViewTextBoxColumn, Me.Feld4DataGridViewTextBoxColumn, Me.Feld5DataGridViewTextBoxColumn, Me.Feld6DataGridViewTextBoxColumn, Me.Feld7DataGridViewTextBoxColumn, Me.Feld8DataGridViewTextBoxColumn, Me.Feld9DataGridViewTextBoxColumn, Me.Feld10DataGridViewTextBoxColumn, Me.Feld11DataGridViewTextBoxColumn, Me.Feld12DataGridViewTextBoxColumn, Me.Feld13DataGridViewTextBoxColumn, Me.Feld14DataGridViewTextBoxColumn, Me.Feld15DataGridViewTextBoxColumn, Me.Feld16DataGridViewTextBoxColumn, Me.Feld17DataGridViewTextBoxColumn, Me.Feld18DataGridViewTextBoxColumn, Me.Feld19DataGridViewTextBoxColumn, Me.Feld20DataGridViewTextBoxColumn, Me.Feld21DataGridViewTextBoxColumn, Me.Feld22DataGridViewTextBoxColumn, Me.Feld23DataGridViewTextBoxColumn, Me.Feld24DataGridViewTextBoxColumn, Me.Feld25DataGridViewTextBoxColumn, Me.Feld26DataGridViewTextBoxColumn, Me.Feld27DataGridViewTextBoxColumn, Me.Feld28DataGridViewTextBoxColumn, Me.Feld0DataGridViewTextBoxColumn, Me.Feld29DataGridViewTextBoxColumn, Me.Feld30DataGridViewTextBoxColumn, Me.Feld31DataGridViewTextBoxColumn, Me.Feld32DataGridViewTextBoxColumn, Me.Feld33DataGridViewTextBoxColumn, Me.Feld34DataGridViewTextBoxColumn, Me.Feld35DataGridViewTextBoxColumn, Me.Feld36DataGridViewTextBoxColumn, Me.Feld37DataGridViewTextBoxColumn, Me.Feld38DataGridViewTextBoxColumn, Me.Feld39DataGridViewTextBoxColumn, Me.Feld40DataGridViewTextBoxColumn, Me.Feld41DataGridViewTextBoxColumn, Me.Feld42DataGridViewTextBoxColumn, Me.Feld43DataGridViewTextBoxColumn, Me.Feld44DataGridViewTextBoxColumn, Me.Feld45DataGridViewTextBoxColumn, Me.Feld46DataGridViewTextBoxColumn, Me.Feld47DataGridViewTextBoxColumn, Me.Feld48DataGridViewTextBoxColumn, Me.Feld49DataGridViewTextBoxColumn, Me.Feld50DataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.bsTemp
        Me.DataGridView4.Location = New System.Drawing.Point(1021, 561)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView4.TabIndex = 89
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
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
        'Button1Drucken
        '
        Me.Button1Drucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Drucken.Location = New System.Drawing.Point(213, 424)
        Me.Button1Drucken.Name = "Button1Drucken"
        Me.Button1Drucken.Size = New System.Drawing.Size(116, 43)
        Me.Button1Drucken.TabIndex = 90
        Me.Button1Drucken.Text = "Veranstaltung drucken"
        Me.Button1Drucken.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(597, 466)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 15)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Speichertext"
        '
        'taCrewAdressen
        '
        Me.taCrewAdressen.ClearBeforeFill = True
        '
        'taVeranstalTeilnehmer
        '
        Me.taVeranstalTeilnehmer.ClearBeforeFill = True
        '
        'taVeranstaltungen
        '
        Me.taVeranstaltungen.ClearBeforeFill = True
        '
        'taTemp
        '
        Me.taTemp.ClearBeforeFill = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BezeichnungDataGridViewTextBoxColumn, Me.StrasseDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn1, Me.OrtDataGridViewTextBoxColumn1, Me.TypDataGridViewTextBoxColumn, Me.MaxTeilnehmerDataGridViewTextBoxColumn, Me.InfrastrukturDataGridViewTextBoxColumn, Me.KostenDataGridViewTextBoxColumn1, Me.BemerkungDataGridViewTextBoxColumn2, Me.LinkDataGridViewTextBoxColumn, Me.KarteDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn1, Me.WEBSeiteDataGridViewTextBoxColumn, Me.TelefonDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn3})
        Me.DataGridView5.DataSource = Me.bsStandort
        Me.DataGridView5.Location = New System.Drawing.Point(15, 549)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView5.TabIndex = 92
        '
        'BezeichnungDataGridViewTextBoxColumn
        '
        Me.BezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung"
        Me.BezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung"
        Me.BezeichnungDataGridViewTextBoxColumn.Name = "BezeichnungDataGridViewTextBoxColumn"
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
        'OrtDataGridViewTextBoxColumn1
        '
        Me.OrtDataGridViewTextBoxColumn1.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.Name = "OrtDataGridViewTextBoxColumn1"
        '
        'TypDataGridViewTextBoxColumn
        '
        Me.TypDataGridViewTextBoxColumn.DataPropertyName = "Typ"
        Me.TypDataGridViewTextBoxColumn.HeaderText = "Typ"
        Me.TypDataGridViewTextBoxColumn.Name = "TypDataGridViewTextBoxColumn"
        '
        'MaxTeilnehmerDataGridViewTextBoxColumn
        '
        Me.MaxTeilnehmerDataGridViewTextBoxColumn.DataPropertyName = "MaxTeilnehmer"
        Me.MaxTeilnehmerDataGridViewTextBoxColumn.HeaderText = "MaxTeilnehmer"
        Me.MaxTeilnehmerDataGridViewTextBoxColumn.Name = "MaxTeilnehmerDataGridViewTextBoxColumn"
        '
        'InfrastrukturDataGridViewTextBoxColumn
        '
        Me.InfrastrukturDataGridViewTextBoxColumn.DataPropertyName = "Infrastruktur"
        Me.InfrastrukturDataGridViewTextBoxColumn.HeaderText = "Infrastruktur"
        Me.InfrastrukturDataGridViewTextBoxColumn.Name = "InfrastrukturDataGridViewTextBoxColumn"
        '
        'KostenDataGridViewTextBoxColumn1
        '
        Me.KostenDataGridViewTextBoxColumn1.DataPropertyName = "Kosten"
        Me.KostenDataGridViewTextBoxColumn1.HeaderText = "Kosten"
        Me.KostenDataGridViewTextBoxColumn1.Name = "KostenDataGridViewTextBoxColumn1"
        '
        'BemerkungDataGridViewTextBoxColumn2
        '
        Me.BemerkungDataGridViewTextBoxColumn2.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn2.Name = "BemerkungDataGridViewTextBoxColumn2"
        '
        'LinkDataGridViewTextBoxColumn
        '
        Me.LinkDataGridViewTextBoxColumn.DataPropertyName = "Link"
        Me.LinkDataGridViewTextBoxColumn.HeaderText = "Link"
        Me.LinkDataGridViewTextBoxColumn.Name = "LinkDataGridViewTextBoxColumn"
        '
        'KarteDataGridViewTextBoxColumn
        '
        Me.KarteDataGridViewTextBoxColumn.DataPropertyName = "Karte"
        Me.KarteDataGridViewTextBoxColumn.HeaderText = "Karte"
        Me.KarteDataGridViewTextBoxColumn.Name = "KarteDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn1
        '
        Me.EmailDataGridViewTextBoxColumn1.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn1.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn1.Name = "EmailDataGridViewTextBoxColumn1"
        '
        'WEBSeiteDataGridViewTextBoxColumn
        '
        Me.WEBSeiteDataGridViewTextBoxColumn.DataPropertyName = "WEBSeite"
        Me.WEBSeiteDataGridViewTextBoxColumn.HeaderText = "WEBSeite"
        Me.WEBSeiteDataGridViewTextBoxColumn.Name = "WEBSeiteDataGridViewTextBoxColumn"
        '
        'TelefonDataGridViewTextBoxColumn
        '
        Me.TelefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon"
        Me.TelefonDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.TelefonDataGridViewTextBoxColumn.Name = "TelefonDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        '
        'taStandort
        '
        Me.taStandort.ClearBeforeFill = True
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Location = New System.Drawing.Point(332, 549)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox6.TabIndex = 93
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Sterbedatum", True))
        Me.TextBox20.Location = New System.Drawing.Point(1526, 21)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 22)
        Me.TextBox20.TabIndex = 94
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVeranstaltungen, "Bemerkung", True))
        Me.TextBox21.Location = New System.Drawing.Point(13, 713)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 22)
        Me.TextBox21.TabIndex = 95
        '
        'Veranstalltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 503)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.MaskedTextBox6)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1Drucken)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.GroupBox6Kalender)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GruppeVeranstaltung)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3VLoeschen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1Speichern)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Veranstalltung"
        Me.Text = "Veranstaltung"
        CType(Me.bsVeranstaltungen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.bsVeranstalTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.bsStandort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GruppeVeranstaltung.ResumeLayout(False)
        Me.GruppeVeranstaltung.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6Kalender.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1Speichern As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3VLoeschen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsVeranstalTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taVeranstalTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.VeranstalTeilnehmerTableAdapter
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents VZnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnredeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlterersterToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReisepassNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZunameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebOrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FunkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents GruppeVeranstaltung As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4TSpeichern As System.Windows.Forms.Button
    Friend WithEvents Button1TLoeschen As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6Kalender As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button5Zurueck As System.Windows.Forms.Button
    Friend WithEvents Button7Speichern As System.Windows.Forms.Button
    Friend WithEvents Veranstaltung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Veranstaltungsdatum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anmeldedatum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Beitrag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsVeranstaltungen As System.Windows.Forms.BindingSource
    Friend WithEvents taVeranstaltungen As WindowsApplication1.dsAusbildungTableAdapters.VeranstaltungenTableAdapter
    Friend WithEvents VeranstaltungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxAnzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ort1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ort2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ort3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTemp As System.Windows.Forms.BindingSource
    Friend WithEvents taTemp As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Button1Drucken As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents bsStandort As System.Windows.Forms.BindingSource
    Friend WithEvents taStandort As WindowsApplication1.dsAusbildungTableAdapters.StandortTableAdapter
    Friend WithEvents BezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StrasseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaxTeilnehmerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfrastrukturDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LinkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KarteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEBSeiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox6 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
End Class
