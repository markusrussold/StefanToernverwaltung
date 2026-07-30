<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logdaten
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logdaten))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UhrzeitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WindRichtungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WindstaerkeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeegangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuftdruckDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WolkenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KueGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AntriebsartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueGTagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueGSegelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuegMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToerbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLogdaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLogbuch = New WindowsApplication1.dsLogbuch()
        Me.gbDoku = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBesonderes = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.bsDokumentation = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLogWacheplan = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.gbCheck = New System.Windows.Forms.GroupBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbZielort = New System.Windows.Forms.GroupBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.gbBemerkung = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.gbFahrt = New System.Windows.Forms.GroupBox()
        Me.lblRelayStatus = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.Be9 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Be8 = New System.Windows.Forms.PictureBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Be7 = New System.Windows.Forms.PictureBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Be6 = New System.Windows.Forms.PictureBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Be5 = New System.Windows.Forms.PictureBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Be4 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Be3 = New System.Windows.Forms.PictureBox()
        Me.Be2 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Be1 = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Be0 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.ButtonSpeichern = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toernbezeichnung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wetterbericht1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wetterbericht2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wetterbericht3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uhrzeit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bemerkungen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Besonderes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielGebühr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielMüll = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ZielStrom = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MotorStdAnfang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorStdEnde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kraftstoffgetankt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kraffstoffkosten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBilge = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WasserTanken = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckOel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckBatterie = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Ausgangsort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zielort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.bsWacheplan = New System.Windows.Forms.BindingSource(Me.components)
        Me.taWacheplan = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter()
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.MaterialKursTableAdapter1 = New WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter()
        Me.taLogdaten = New WindowsApplication1.dsLogbuchTableAdapters.LogdatenTableAdapter()
        Me.taLogWacheplan = New WindowsApplication1.dsLogbuchTableAdapters.LogWacheplanTableAdapter()
        Me.taDokumentation = New WindowsApplication1.dsLogbuchTableAdapters.DokumentationTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogdaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDoku.SuspendLayout()
        Me.gbBesonderes.SuspendLayout()
        CType(Me.bsDokumentation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogWacheplan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCheck.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbZielort.SuspendLayout()
        Me.gbBemerkung.SuspendLayout()
        Me.gbFahrt.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Be0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UhrzeitDataGridViewTextBoxColumn, Me.WindRichtungDataGridViewTextBoxColumn, Me.WindstaerkeDataGridViewTextBoxColumn, Me.SeegangDataGridViewTextBoxColumn, Me.LuftdruckDataGridViewTextBoxColumn, Me.WolkenDataGridViewTextBoxColumn, Me.KueGDataGridViewTextBoxColumn, Me.ort, Me.AntriebsartDataGridViewTextBoxColumn, Me.DueGTagDataGridViewTextBoxColumn, Me.DueGSegelDataGridViewTextBoxColumn, Me.DuegMotorDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.ToerbezeichnungDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsLogdaten
        Me.DataGridView1.Location = New System.Drawing.Point(5, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(957, 378)
        Me.DataGridView1.TabIndex = 0
        '
        'UhrzeitDataGridViewTextBoxColumn
        '
        Me.UhrzeitDataGridViewTextBoxColumn.DataPropertyName = "Uhrzeit"
        Me.UhrzeitDataGridViewTextBoxColumn.HeaderText = "Uhrzeit"
        Me.UhrzeitDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UhrzeitDataGridViewTextBoxColumn.Name = "UhrzeitDataGridViewTextBoxColumn"
        Me.UhrzeitDataGridViewTextBoxColumn.Width = 60
        '
        'WindRichtungDataGridViewTextBoxColumn
        '
        Me.WindRichtungDataGridViewTextBoxColumn.DataPropertyName = "WindRichtung"
        Me.WindRichtungDataGridViewTextBoxColumn.HeaderText = "Wind Richtung"
        Me.WindRichtungDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WindRichtungDataGridViewTextBoxColumn.Name = "WindRichtungDataGridViewTextBoxColumn"
        Me.WindRichtungDataGridViewTextBoxColumn.Width = 60
        '
        'WindstaerkeDataGridViewTextBoxColumn
        '
        Me.WindstaerkeDataGridViewTextBoxColumn.DataPropertyName = "Windstaerke"
        Me.WindstaerkeDataGridViewTextBoxColumn.HeaderText = "Wind Stärke"
        Me.WindstaerkeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WindstaerkeDataGridViewTextBoxColumn.Name = "WindstaerkeDataGridViewTextBoxColumn"
        Me.WindstaerkeDataGridViewTextBoxColumn.Width = 50
        '
        'SeegangDataGridViewTextBoxColumn
        '
        Me.SeegangDataGridViewTextBoxColumn.DataPropertyName = "Seegang"
        Me.SeegangDataGridViewTextBoxColumn.HeaderText = "Seegang"
        Me.SeegangDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SeegangDataGridViewTextBoxColumn.Name = "SeegangDataGridViewTextBoxColumn"
        Me.SeegangDataGridViewTextBoxColumn.Width = 60
        '
        'LuftdruckDataGridViewTextBoxColumn
        '
        Me.LuftdruckDataGridViewTextBoxColumn.DataPropertyName = "Luftdruck"
        Me.LuftdruckDataGridViewTextBoxColumn.HeaderText = "Luftdruck"
        Me.LuftdruckDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LuftdruckDataGridViewTextBoxColumn.Name = "LuftdruckDataGridViewTextBoxColumn"
        Me.LuftdruckDataGridViewTextBoxColumn.Width = 60
        '
        'WolkenDataGridViewTextBoxColumn
        '
        Me.WolkenDataGridViewTextBoxColumn.DataPropertyName = "Wolken"
        Me.WolkenDataGridViewTextBoxColumn.HeaderText = "Wolken"
        Me.WolkenDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WolkenDataGridViewTextBoxColumn.Name = "WolkenDataGridViewTextBoxColumn"
        '
        'KueGDataGridViewTextBoxColumn
        '
        Me.KueGDataGridViewTextBoxColumn.DataPropertyName = "KueG"
        Me.KueGDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.KueGDataGridViewTextBoxColumn.HeaderText = "Kurs ü. Grund"
        Me.KueGDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KueGDataGridViewTextBoxColumn.Name = "KueGDataGridViewTextBoxColumn"
        Me.KueGDataGridViewTextBoxColumn.Width = 50
        '
        'ort
        '
        Me.ort.DataPropertyName = "ort"
        Me.ort.HeaderText = "Position"
        Me.ort.Name = "ort"
        Me.ort.Width = 170
        '
        'AntriebsartDataGridViewTextBoxColumn
        '
        Me.AntriebsartDataGridViewTextBoxColumn.DataPropertyName = "Antriebsart"
        Me.AntriebsartDataGridViewTextBoxColumn.HeaderText = "Antriebsart"
        Me.AntriebsartDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AntriebsartDataGridViewTextBoxColumn.Name = "AntriebsartDataGridViewTextBoxColumn"
        Me.AntriebsartDataGridViewTextBoxColumn.Width = 80
        '
        'DueGTagDataGridViewTextBoxColumn
        '
        Me.DueGTagDataGridViewTextBoxColumn.DataPropertyName = "DueGTag"
        Me.DueGTagDataGridViewTextBoxColumn.HeaderText = "Distanz am Tag"
        Me.DueGTagDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DueGTagDataGridViewTextBoxColumn.Name = "DueGTagDataGridViewTextBoxColumn"
        Me.DueGTagDataGridViewTextBoxColumn.Width = 60
        '
        'DueGSegelDataGridViewTextBoxColumn
        '
        Me.DueGSegelDataGridViewTextBoxColumn.DataPropertyName = "DueGSegel"
        Me.DueGSegelDataGridViewTextBoxColumn.HeaderText = "Distanz Segel"
        Me.DueGSegelDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DueGSegelDataGridViewTextBoxColumn.Name = "DueGSegelDataGridViewTextBoxColumn"
        Me.DueGSegelDataGridViewTextBoxColumn.Width = 60
        '
        'DuegMotorDataGridViewTextBoxColumn
        '
        Me.DuegMotorDataGridViewTextBoxColumn.DataPropertyName = "DuegMotor"
        Me.DuegMotorDataGridViewTextBoxColumn.HeaderText = "Distanz Motor"
        Me.DuegMotorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DuegMotorDataGridViewTextBoxColumn.Name = "DuegMotorDataGridViewTextBoxColumn"
        Me.DuegMotorDataGridViewTextBoxColumn.Width = 80
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        Me.DatumDataGridViewTextBoxColumn.Width = 60
        '
        'ToerbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToerbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toerbezeichnung"
        Me.ToerbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toerbezeichnung"
        Me.ToerbezeichnungDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ToerbezeichnungDataGridViewTextBoxColumn.Name = "ToerbezeichnungDataGridViewTextBoxColumn"
        Me.ToerbezeichnungDataGridViewTextBoxColumn.Width = 150
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'bsLogdaten
        '
        Me.bsLogdaten.DataMember = "Logdaten"
        Me.bsLogdaten.DataSource = Me.DsLogbuch
        '
        'DsLogbuch
        '
        Me.DsLogbuch.DataSetName = "dsLogbuch"
        Me.DsLogbuch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbDoku
        '
        Me.gbDoku.Controls.Add(Me.Label1)
        Me.gbDoku.Controls.Add(Me.gbBesonderes)
        Me.gbDoku.Controls.Add(Me.DataGridView2)
        Me.gbDoku.Controls.Add(Me.MaskedTextBox2)
        Me.gbDoku.Controls.Add(Me.gbCheck)
        Me.gbDoku.Controls.Add(Me.GroupBox2)
        Me.gbDoku.Controls.Add(Me.gbZielort)
        Me.gbDoku.Controls.Add(Me.TextBox11)
        Me.gbDoku.Controls.Add(Me.Label19)
        Me.gbDoku.Controls.Add(Me.TextBox10)
        Me.gbDoku.Controls.Add(Me.Label18)
        Me.gbDoku.Controls.Add(Me.MaskedTextBox1)
        Me.gbDoku.Controls.Add(Me.TextBox9)
        Me.gbDoku.Controls.Add(Me.TextBox8)
        Me.gbDoku.Controls.Add(Me.TextBox7)
        Me.gbDoku.Controls.Add(Me.gbBemerkung)
        Me.gbDoku.Controls.Add(Me.Label17)
        Me.gbDoku.Controls.Add(Me.Label16)
        Me.gbDoku.Controls.Add(Me.Label15)
        Me.gbDoku.Controls.Add(Me.Label14)
        Me.gbDoku.Controls.Add(Me.Label13)
        Me.gbDoku.Controls.Add(Me.Label12)
        Me.gbDoku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDoku.Location = New System.Drawing.Point(1554, 18)
        Me.gbDoku.Name = "gbDoku"
        Me.gbDoku.Size = New System.Drawing.Size(980, 523)
        Me.gbDoku.TabIndex = 1
        Me.gbDoku.TabStop = False
        Me.gbDoku.Text = "Tagesdokumentation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(657, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Zeile löschen: Zeit Von mit Leerstelle überschreiben"
        '
        'gbBesonderes
        '
        Me.gbBesonderes.Controls.Add(Me.RichTextBox2)
        Me.gbBesonderes.Location = New System.Drawing.Point(9, 236)
        Me.gbBesonderes.Name = "gbBesonderes"
        Me.gbBesonderes.Size = New System.Drawing.Size(531, 143)
        Me.gbBesonderes.TabIndex = 7
        Me.gbBesonderes.TabStop = False
        Me.gbBesonderes.Text = "Besonderes"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Besonderes", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(519, 118)
        Me.RichTextBox2.TabIndex = 120
        Me.RichTextBox2.Text = ""
        '
        'bsDokumentation
        '
        Me.bsDokumentation.DataMember = "Dokumentation"
        Me.bsDokumentation.DataSource = Me.DsLogbuch
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TextVonDataGridViewTextBoxColumn, Me.TextBisDataGridViewTextBoxColumn, Me.Person1DataGridViewTextBoxColumn, Me.Person2DataGridViewTextBoxColumn, Me.Person3})
        Me.DataGridView2.DataSource = Me.bsLogWacheplan
        Me.DataGridView2.Location = New System.Drawing.Point(546, 114)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.Size = New System.Drawing.Size(425, 370)
        Me.DataGridView2.TabIndex = 22
        '
        'TextVonDataGridViewTextBoxColumn
        '
        Me.TextVonDataGridViewTextBoxColumn.DataPropertyName = "TextVon"
        Me.TextVonDataGridViewTextBoxColumn.HeaderText = "Von"
        Me.TextVonDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TextVonDataGridViewTextBoxColumn.Name = "TextVonDataGridViewTextBoxColumn"
        Me.TextVonDataGridViewTextBoxColumn.Width = 43
        '
        'TextBisDataGridViewTextBoxColumn
        '
        Me.TextBisDataGridViewTextBoxColumn.DataPropertyName = "TextBis"
        Me.TextBisDataGridViewTextBoxColumn.HeaderText = "Bis"
        Me.TextBisDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TextBisDataGridViewTextBoxColumn.Name = "TextBisDataGridViewTextBoxColumn"
        Me.TextBisDataGridViewTextBoxColumn.Width = 43
        '
        'Person1DataGridViewTextBoxColumn
        '
        Me.Person1DataGridViewTextBoxColumn.DataPropertyName = "Person1"
        Me.Person1DataGridViewTextBoxColumn.HeaderText = "Person1"
        Me.Person1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Person1DataGridViewTextBoxColumn.Name = "Person1DataGridViewTextBoxColumn"
        Me.Person1DataGridViewTextBoxColumn.Width = 150
        '
        'Person2DataGridViewTextBoxColumn
        '
        Me.Person2DataGridViewTextBoxColumn.DataPropertyName = "Person2"
        Me.Person2DataGridViewTextBoxColumn.HeaderText = "Person2"
        Me.Person2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Person2DataGridViewTextBoxColumn.Name = "Person2DataGridViewTextBoxColumn"
        Me.Person2DataGridViewTextBoxColumn.Width = 150
        '
        'Person3
        '
        Me.Person3.DataPropertyName = "Person3"
        Me.Person3.HeaderText = "Person3"
        Me.Person3.MinimumWidth = 8
        Me.Person3.Name = "Person3"
        Me.Person3.Width = 150
        '
        'bsLogWacheplan
        '
        Me.bsLogWacheplan.DataMember = "LogWacheplan"
        Me.bsLogWacheplan.DataSource = Me.DsLogbuch
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Datum", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(53, 19)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(70, 22)
        Me.MaskedTextBox2.TabIndex = 0
        '
        'gbCheck
        '
        Me.gbCheck.Controls.Add(Me.CheckBox6)
        Me.gbCheck.Controls.Add(Me.CheckBox5)
        Me.gbCheck.Controls.Add(Me.CheckBox4)
        Me.gbCheck.Controls.Add(Me.CheckBox3)
        Me.gbCheck.Location = New System.Drawing.Point(15, 386)
        Me.gbCheck.Name = "gbCheck"
        Me.gbCheck.Size = New System.Drawing.Size(161, 126)
        Me.gbCheck.TabIndex = 20
        Me.gbCheck.TabStop = False
        Me.gbCheck.Text = "Prüfen vor Auslaufen"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsDokumentation, "CheckBatterie", True))
        Me.CheckBox6.Location = New System.Drawing.Point(7, 100)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(131, 20)
        Me.CheckBox6.TabIndex = 27
        Me.CheckBox6.Text = "Batteriespannung"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsDokumentation, "CheckOel", True))
        Me.CheckBox5.Location = New System.Drawing.Point(7, 77)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(72, 20)
        Me.CheckBox5.TabIndex = 26
        Me.CheckBox5.Text = "Ölstand"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsDokumentation, "WasserTanken", True))
        Me.CheckBox4.Location = New System.Drawing.Point(7, 50)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(144, 20)
        Me.CheckBox4.TabIndex = 25
        Me.CheckBox4.Text = "Wasser voll getankt"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsDokumentation, "CheckBilge", True))
        Me.CheckBox3.Location = New System.Drawing.Point(7, 21)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(57, 20)
        Me.CheckBox3.TabIndex = 24
        Me.CheckBox3.Text = "Bilge"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox17)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.TextBox16)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Location = New System.Drawing.Point(189, 386)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 126)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Motorstunden"
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Kraffstoffkosten", True))
        Me.TextBox17.Location = New System.Drawing.Point(94, 98)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(52, 22)
        Me.TextBox17.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 101)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 16)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Kraftstoff [€]"
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Kraftstoffgetankt", True))
        Me.TextBox16.Location = New System.Drawing.Point(94, 73)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(52, 22)
        Me.TextBox16.TabIndex = 22
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "MotorStdEnde", True))
        Me.TextBox15.Location = New System.Drawing.Point(94, 47)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(52, 22)
        Me.TextBox15.TabIndex = 21
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "MotorStdAnfang", True))
        Me.TextBox14.Location = New System.Drawing.Point(94, 18)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(52, 22)
        Me.TextBox14.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 16)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Kraftstoff [l]"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 16)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Tagesende"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Tagesanfang"
        '
        'gbZielort
        '
        Me.gbZielort.Controls.Add(Me.TextBox13)
        Me.gbZielort.Controls.Add(Me.TextBox12)
        Me.gbZielort.Controls.Add(Me.CheckBox2)
        Me.gbZielort.Controls.Add(Me.CheckBox1)
        Me.gbZielort.Controls.Add(Me.Label21)
        Me.gbZielort.Controls.Add(Me.Label20)
        Me.gbZielort.Location = New System.Drawing.Point(356, 386)
        Me.gbZielort.Name = "gbZielort"
        Me.gbZielort.Size = New System.Drawing.Size(184, 126)
        Me.gbZielort.TabIndex = 18
        Me.gbZielort.TabStop = False
        Me.gbZielort.Text = "Hafen Zielort"
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "ZielGebühr", True))
        Me.TextBox13.Location = New System.Drawing.Point(76, 47)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 22)
        Me.TextBox13.TabIndex = 17
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "ZielAnlegeart", True))
        Me.TextBox12.Location = New System.Drawing.Point(76, 18)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 22)
        Me.TextBox12.TabIndex = 16
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsDokumentation, "ZielStrom", True))
        Me.CheckBox2.Location = New System.Drawing.Point(6, 100)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(115, 20)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "Stromanschluß"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsDokumentation, "ZielMüll", True))
        Me.CheckBox1.Location = New System.Drawing.Point(6, 75)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 20)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Müllensorgung"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Gebühr  €"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Anlegeart"
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Wetterbericht2", True))
        Me.TextBox11.Location = New System.Drawing.Point(787, 47)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(93, 22)
        Me.TextBox11.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(684, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Wetterbericht 2"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Wetterbericht3", True))
        Me.TextBox10.Location = New System.Drawing.Point(787, 75)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(93, 22)
        Me.TextBox10.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(684, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Wetterbericht 3"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Uhrzeit", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(936, 19)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(38, 22)
        Me.MaskedTextBox1.TabIndex = 6
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Wetterbericht1", True))
        Me.TextBox9.Location = New System.Drawing.Point(787, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(93, 22)
        Me.TextBox9.TabIndex = 3
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Zielort", True))
        Me.TextBox8.Location = New System.Drawing.Point(518, 19)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(151, 22)
        Me.TextBox8.TabIndex = 2
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Ausgangsort", True))
        Me.TextBox7.Location = New System.Drawing.Point(292, 19)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(153, 22)
        Me.TextBox7.TabIndex = 1
        '
        'gbBemerkung
        '
        Me.gbBemerkung.Controls.Add(Me.RichTextBox1)
        Me.gbBemerkung.Location = New System.Drawing.Point(9, 55)
        Me.gbBemerkung.Name = "gbBemerkung"
        Me.gbBemerkung.Size = New System.Drawing.Size(531, 185)
        Me.gbBemerkung.TabIndex = 6
        Me.gbBemerkung.TabStop = False
        Me.gbBemerkung.Text = "Bemerkungen, Schiffsort, Kursmarken, Peilungen, Abtrifft, Vorkommnisse"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Bemerkungen", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 23)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(517, 150)
        Me.RichTextBox1.TabIndex = 110
        Me.RichTextBox1.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(886, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Uhrzeit"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(684, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Wetterbericht 1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(467, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Zielort"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(205, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Ausgangsort"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(125, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Tag"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Datum"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Uhrzeit", True))
        Me.TextBox6.Location = New System.Drawing.Point(8, 206)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(70, 20)
        Me.TextBox6.TabIndex = 900
        '
        'gbFahrt
        '
        Me.gbFahrt.Controls.Add(Me.lblRelayStatus)
        Me.gbFahrt.Controls.Add(Me.Button1)
        Me.gbFahrt.Controls.Add(Me.PictureBox1)
        Me.gbFahrt.Controls.Add(Me.Label35)
        Me.gbFahrt.Controls.Add(Me.MaskedTextBox4)
        Me.gbFahrt.Controls.Add(Me.Be9)
        Me.gbFahrt.Controls.Add(Me.MaskedTextBox3)
        Me.gbFahrt.Controls.Add(Me.Be8)
        Me.gbFahrt.Controls.Add(Me.TextBox18)
        Me.gbFahrt.Controls.Add(Me.Be7)
        Me.gbFahrt.Controls.Add(Me.Label30)
        Me.gbFahrt.Controls.Add(Me.Be6)
        Me.gbFahrt.Controls.Add(Me.ComboBox4)
        Me.gbFahrt.Controls.Add(Me.Be5)
        Me.gbFahrt.Controls.Add(Me.ComboBox3)
        Me.gbFahrt.Controls.Add(Me.Be4)
        Me.gbFahrt.Controls.Add(Me.ComboBox2)
        Me.gbFahrt.Controls.Add(Me.Be3)
        Me.gbFahrt.Controls.Add(Me.Be2)
        Me.gbFahrt.Controls.Add(Me.TextBox4)
        Me.gbFahrt.Controls.Add(Me.Label9)
        Me.gbFahrt.Controls.Add(Me.ComboBox1)
        Me.gbFahrt.Controls.Add(Me.Be1)
        Me.gbFahrt.Controls.Add(Me.TextBox5)
        Me.gbFahrt.Controls.Add(Me.Be0)
        Me.gbFahrt.Controls.Add(Me.TextBox3)
        Me.gbFahrt.Controls.Add(Me.TextBox2)
        Me.gbFahrt.Controls.Add(Me.Label11)
        Me.gbFahrt.Controls.Add(Me.Label10)
        Me.gbFahrt.Controls.Add(Me.Label8)
        Me.gbFahrt.Controls.Add(Me.Label7)
        Me.gbFahrt.Controls.Add(Me.Label6)
        Me.gbFahrt.Controls.Add(Me.Label5)
        Me.gbFahrt.Controls.Add(Me.Label4)
        Me.gbFahrt.Controls.Add(Me.Label3)
        Me.gbFahrt.Controls.Add(Me.GroupBox1)
        Me.gbFahrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFahrt.Location = New System.Drawing.Point(15, 18)
        Me.gbFahrt.Name = "gbFahrt"
        Me.gbFahrt.Size = New System.Drawing.Size(989, 542)
        Me.gbFahrt.TabIndex = 2
        Me.gbFahrt.TabStop = False
        Me.gbFahrt.Text = "Fahrt Log"
        '
        'lblRelayStatus
        '
        Me.lblRelayStatus.AutoSize = True
        Me.lblRelayStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelayStatus.Location = New System.Drawing.Point(326, 529)
        Me.lblRelayStatus.Name = "lblRelayStatus"
        Me.lblRelayStatus.Size = New System.Drawing.Size(93, 13)
        Me.lblRelayStatus.TabIndex = 1125
        Me.lblRelayStatus.Text = "NMEA-Relay: …"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(639, 454)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 27)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Daten holen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 427)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1122
        Me.PictureBox1.TabStop = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(757, 461)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 16)
        Me.Label35.TabIndex = 1121
        Me.Label35.Text = "oder"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(803, 458)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(141, 22)
        Me.MaskedTextBox4.TabIndex = 109
        '
        'Be9
        '
        Me.Be9.Image = CType(resources.GetObject("Be9.Image"), System.Drawing.Image)
        Me.Be9.Location = New System.Drawing.Point(415, 623)
        Me.Be9.Name = "Be9"
        Me.Be9.Size = New System.Drawing.Size(26, 26)
        Me.Be9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be9.TabIndex = 1111
        Me.Be9.TabStop = False
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Uhrzeit", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(148, 433)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox3.TabIndex = 100
        '
        'Be8
        '
        Me.Be8.Image = CType(resources.GetObject("Be8.Image"), System.Drawing.Image)
        Me.Be8.Location = New System.Drawing.Point(383, 623)
        Me.Be8.Name = "Be8"
        Me.Be8.Size = New System.Drawing.Size(26, 26)
        Me.Be8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be8.TabIndex = 1110
        Me.Be8.TabStop = False
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "ort", True))
        Me.TextBox18.Location = New System.Drawing.Point(731, 430)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(213, 22)
        Me.TextBox18.TabIndex = 107
        '
        'Be7
        '
        Me.Be7.Image = CType(resources.GetObject("Be7.Image"), System.Drawing.Image)
        Me.Be7.Location = New System.Drawing.Point(351, 623)
        Me.Be7.Name = "Be7"
        Me.Be7.Size = New System.Drawing.Size(26, 26)
        Me.Be7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be7.TabIndex = 1109
        Me.Be7.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(657, 435)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 16)
        Me.Label30.TabIndex = 20
        Me.Label30.Text = "Position"
        '
        'Be6
        '
        Me.Be6.Image = CType(resources.GetObject("Be6.Image"), System.Drawing.Image)
        Me.Be6.Location = New System.Drawing.Point(319, 623)
        Me.Be6.Name = "Be6"
        Me.Be6.Size = New System.Drawing.Size(26, 26)
        Me.Be6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be6.TabIndex = 1108
        Me.Be6.TabStop = False
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Antriebsart", True))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(844, 485)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox4.TabIndex = 111
        '
        'Be5
        '
        Me.Be5.Image = CType(resources.GetObject("Be5.Image"), System.Drawing.Image)
        Me.Be5.Location = New System.Drawing.Point(287, 623)
        Me.Be5.Name = "Be5"
        Me.Be5.Size = New System.Drawing.Size(26, 26)
        Me.Be5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be5.TabIndex = 1107
        Me.Be5.TabStop = False
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Wolken", True))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(442, 460)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox3.TabIndex = 105
        '
        'Be4
        '
        Me.Be4.Image = CType(resources.GetObject("Be4.Image"), System.Drawing.Image)
        Me.Be4.Location = New System.Drawing.Point(255, 623)
        Me.Be4.Name = "Be4"
        Me.Be4.Size = New System.Drawing.Size(26, 26)
        Me.Be4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be4.TabIndex = 1106
        Me.Be4.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "WindRichtung", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(148, 460)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox2.TabIndex = 101
        '
        'Be3
        '
        Me.Be3.Image = CType(resources.GetObject("Be3.Image"), System.Drawing.Image)
        Me.Be3.Location = New System.Drawing.Point(222, 623)
        Me.Be3.Name = "Be3"
        Me.Be3.Size = New System.Drawing.Size(26, 26)
        Me.Be3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be3.TabIndex = 1105
        Me.Be3.TabStop = False
        '
        'Be2
        '
        Me.Be2.Image = CType(resources.GetObject("Be2.Image"), System.Drawing.Image)
        Me.Be2.Location = New System.Drawing.Point(190, 623)
        Me.Be2.Name = "Be2"
        Me.Be2.Size = New System.Drawing.Size(26, 26)
        Me.Be2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be2.TabIndex = 1104
        Me.Be2.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "KueG", True))
        Me.TextBox4.Location = New System.Drawing.Point(442, 490)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(326, 493)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kurs über Grund"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Seegang", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(148, 512)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox1.TabIndex = 103
        '
        'Be1
        '
        Me.Be1.Image = CType(resources.GetObject("Be1.Image"), System.Drawing.Image)
        Me.Be1.Location = New System.Drawing.Point(153, 623)
        Me.Be1.Name = "Be1"
        Me.Be1.Size = New System.Drawing.Size(26, 26)
        Me.Be1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be1.TabIndex = 1103
        Me.Be1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "DueGTag", True))
        Me.TextBox5.Location = New System.Drawing.Point(844, 512)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 112
        '
        'Be0
        '
        Me.Be0.Image = CType(resources.GetObject("Be0.Image"), System.Drawing.Image)
        Me.Be0.Location = New System.Drawing.Point(116, 623)
        Me.Be0.Name = "Be0"
        Me.Be0.Size = New System.Drawing.Size(26, 26)
        Me.Be0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Be0.TabIndex = 113
        Me.Be0.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Luftdruck", True))
        Me.TextBox3.Location = New System.Drawing.Point(442, 433)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 104
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Windstaerke", True))
        Me.TextBox2.Location = New System.Drawing.Point(148, 487)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(704, 515)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Distanz des Tages"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(704, 488)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Antriebsart"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(375, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Wolken"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(375, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Luftdruck"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 515)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Seegang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Windstärke [kn]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Windrichtung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 436)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Uhrzeit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 411)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'TextBox37
        '
        Me.TextBox37.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Toerbezeichnung", True))
        Me.TextBox37.Location = New System.Drawing.Point(1107, 425)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(100, 20)
        Me.TextBox37.TabIndex = 1124
        '
        'ButtonSpeichern
        '
        Me.ButtonSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpeichern.Location = New System.Drawing.Point(818, 577)
        Me.ButtonSpeichern.Name = "ButtonSpeichern"
        Me.ButtonSpeichern.Size = New System.Drawing.Size(123, 45)
        Me.ButtonSpeichern.TabIndex = 300
        Me.ButtonSpeichern.Text = "Speichern"
        Me.ButtonSpeichern.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Wingdings", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label26.Location = New System.Drawing.Point(935, 569)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 53)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "F"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Wingdings", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 563)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 53)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "E"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Wingdings", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label28.Location = New System.Drawing.Point(509, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(50, 53)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "G"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Wingdings", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label29.Location = New System.Drawing.Point(509, 573)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 53)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "H"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(564, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 13)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Tag vorher"
        Me.Label31.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(979, 596)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(25, 13)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Log"
        Me.Label32.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox26)
        Me.GroupBox3.Controls.Add(Me.TextBox19)
        Me.GroupBox3.Location = New System.Drawing.Point(1099, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 105)
        Me.GroupBox3.TabIndex = 1000
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dokumentatio"
        '
        'TextBox26
        '
        Me.TextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Datum", True))
        Me.TextBox26.Location = New System.Drawing.Point(18, 49)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(100, 20)
        Me.TextBox26.TabIndex = 902
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDokumentation, "Toernbezeichnung", True))
        Me.TextBox19.Location = New System.Drawing.Point(18, 20)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 901
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox25)
        Me.GroupBox4.Controls.Add(Me.TextBox24)
        Me.GroupBox4.Controls.Add(Me.TextBox23)
        Me.GroupBox4.Controls.Add(Me.TextBox22)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.TextBox21)
        Me.GroupBox4.Controls.Add(Me.TextBox20)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(1099, 164)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 242)
        Me.GroupBox4.TabIndex = 1100
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Logdaten"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(8, 183)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(100, 20)
        Me.TextBox25.TabIndex = 910
        '
        'TextBox24
        '
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "DuegMotor", True))
        Me.TextBox24.Location = New System.Drawing.Point(8, 155)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 908
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "DueGSegel", True))
        Me.TextBox23.Location = New System.Drawing.Point(8, 128)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 20)
        Me.TextBox23.TabIndex = 907
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "DueGTag", True))
        Me.TextBox22.Location = New System.Drawing.Point(8, 101)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 20)
        Me.TextBox22.TabIndex = 906
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Antriebsart", True))
        Me.TextBox1.Location = New System.Drawing.Point(8, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 905
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Datum", True))
        Me.TextBox21.Location = New System.Drawing.Point(7, 47)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 20)
        Me.TextBox21.TabIndex = 904
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogdaten, "Toerbezeichnung", True))
        Me.TextBox20.Location = New System.Drawing.Point(8, 20)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 903
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(64, 580)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(33, 13)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "Doku"
        Me.Label33.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(551, 599)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 13)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Nächster Tag"
        Me.Label34.Visible = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.Toernbezeichnung, Me.Datum, Me.Wetterbericht1, Me.Wetterbericht2, Me.Wetterbericht3, Me.Uhrzeit, Me.Bemerkungen, Me.Besonderes, Me.ZielGebühr, Me.ZielMüll, Me.ZielStrom, Me.MotorStdAnfang, Me.MotorStdEnde, Me.Kraftstoffgetankt, Me.Kraffstoffkosten, Me.CheckBilge, Me.WasserTanken, Me.CheckOel, Me.CheckBatterie, Me.Ausgangsort, Me.Zielort})
        Me.DataGridView3.DataSource = Me.bsDokumentation
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.Location = New System.Drawing.Point(1288, 40)
        Me.DataGridView3.Name = "DataGridView3"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView3.RowHeadersWidth = 62
        Me.DataGridView3.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView3.TabIndex = 1101
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        Me.IDDataGridViewTextBoxColumn2.Width = 150
        '
        'Toernbezeichnung
        '
        Me.Toernbezeichnung.DataPropertyName = "Toernbezeichnung"
        Me.Toernbezeichnung.HeaderText = "Toernbezeichnung"
        Me.Toernbezeichnung.MinimumWidth = 8
        Me.Toernbezeichnung.Name = "Toernbezeichnung"
        Me.Toernbezeichnung.Width = 150
        '
        'Datum
        '
        Me.Datum.DataPropertyName = "Datum"
        Me.Datum.HeaderText = "Datum"
        Me.Datum.MinimumWidth = 8
        Me.Datum.Name = "Datum"
        Me.Datum.Width = 150
        '
        'Wetterbericht1
        '
        Me.Wetterbericht1.DataPropertyName = "Wetterbericht1"
        Me.Wetterbericht1.HeaderText = "Wetterbericht1"
        Me.Wetterbericht1.MinimumWidth = 8
        Me.Wetterbericht1.Name = "Wetterbericht1"
        Me.Wetterbericht1.Width = 150
        '
        'Wetterbericht2
        '
        Me.Wetterbericht2.DataPropertyName = "Wetterbericht2"
        Me.Wetterbericht2.HeaderText = "Wetterbericht2"
        Me.Wetterbericht2.MinimumWidth = 8
        Me.Wetterbericht2.Name = "Wetterbericht2"
        Me.Wetterbericht2.Width = 150
        '
        'Wetterbericht3
        '
        Me.Wetterbericht3.DataPropertyName = "Wetterbericht3"
        Me.Wetterbericht3.HeaderText = "Wetterbericht3"
        Me.Wetterbericht3.MinimumWidth = 8
        Me.Wetterbericht3.Name = "Wetterbericht3"
        Me.Wetterbericht3.Width = 150
        '
        'Uhrzeit
        '
        Me.Uhrzeit.DataPropertyName = "Uhrzeit"
        Me.Uhrzeit.HeaderText = "Uhrzeit"
        Me.Uhrzeit.MinimumWidth = 8
        Me.Uhrzeit.Name = "Uhrzeit"
        Me.Uhrzeit.Width = 150
        '
        'Bemerkungen
        '
        Me.Bemerkungen.DataPropertyName = "Bemerkungen"
        Me.Bemerkungen.HeaderText = "Bemerkungen"
        Me.Bemerkungen.MinimumWidth = 8
        Me.Bemerkungen.Name = "Bemerkungen"
        Me.Bemerkungen.Width = 150
        '
        'Besonderes
        '
        Me.Besonderes.DataPropertyName = "Besonderes"
        Me.Besonderes.HeaderText = "Besonderes"
        Me.Besonderes.MinimumWidth = 8
        Me.Besonderes.Name = "Besonderes"
        Me.Besonderes.Width = 150
        '
        'ZielGebühr
        '
        Me.ZielGebühr.DataPropertyName = "ZielGebühr"
        Me.ZielGebühr.HeaderText = "ZielGebühr"
        Me.ZielGebühr.MinimumWidth = 8
        Me.ZielGebühr.Name = "ZielGebühr"
        Me.ZielGebühr.Width = 150
        '
        'ZielMüll
        '
        Me.ZielMüll.DataPropertyName = "ZielMüll"
        Me.ZielMüll.HeaderText = "ZielMüll"
        Me.ZielMüll.MinimumWidth = 8
        Me.ZielMüll.Name = "ZielMüll"
        Me.ZielMüll.Width = 150
        '
        'ZielStrom
        '
        Me.ZielStrom.DataPropertyName = "ZielStrom"
        Me.ZielStrom.HeaderText = "ZielStrom"
        Me.ZielStrom.MinimumWidth = 8
        Me.ZielStrom.Name = "ZielStrom"
        Me.ZielStrom.Width = 150
        '
        'MotorStdAnfang
        '
        Me.MotorStdAnfang.DataPropertyName = "MotorStdAnfang"
        Me.MotorStdAnfang.HeaderText = "MotorStdAnfang"
        Me.MotorStdAnfang.MinimumWidth = 8
        Me.MotorStdAnfang.Name = "MotorStdAnfang"
        Me.MotorStdAnfang.Width = 150
        '
        'MotorStdEnde
        '
        Me.MotorStdEnde.DataPropertyName = "MotorStdEnde"
        Me.MotorStdEnde.HeaderText = "MotorStdEnde"
        Me.MotorStdEnde.MinimumWidth = 8
        Me.MotorStdEnde.Name = "MotorStdEnde"
        Me.MotorStdEnde.Width = 150
        '
        'Kraftstoffgetankt
        '
        Me.Kraftstoffgetankt.DataPropertyName = "Kraftstoffgetankt"
        Me.Kraftstoffgetankt.HeaderText = "Kraftstoffgetankt"
        Me.Kraftstoffgetankt.MinimumWidth = 8
        Me.Kraftstoffgetankt.Name = "Kraftstoffgetankt"
        Me.Kraftstoffgetankt.Width = 150
        '
        'Kraffstoffkosten
        '
        Me.Kraffstoffkosten.DataPropertyName = "Kraffstoffkosten"
        Me.Kraffstoffkosten.HeaderText = "Kraffstoffkosten"
        Me.Kraffstoffkosten.MinimumWidth = 8
        Me.Kraffstoffkosten.Name = "Kraffstoffkosten"
        Me.Kraffstoffkosten.Width = 150
        '
        'CheckBilge
        '
        Me.CheckBilge.DataPropertyName = "CheckBilge"
        Me.CheckBilge.HeaderText = "CheckBilge"
        Me.CheckBilge.MinimumWidth = 8
        Me.CheckBilge.Name = "CheckBilge"
        Me.CheckBilge.Width = 150
        '
        'WasserTanken
        '
        Me.WasserTanken.DataPropertyName = "WasserTanken"
        Me.WasserTanken.HeaderText = "WasserTanken"
        Me.WasserTanken.MinimumWidth = 8
        Me.WasserTanken.Name = "WasserTanken"
        Me.WasserTanken.Width = 150
        '
        'CheckOel
        '
        Me.CheckOel.DataPropertyName = "CheckOel"
        Me.CheckOel.HeaderText = "CheckOel"
        Me.CheckOel.MinimumWidth = 8
        Me.CheckOel.Name = "CheckOel"
        Me.CheckOel.Width = 150
        '
        'CheckBatterie
        '
        Me.CheckBatterie.DataPropertyName = "CheckBatterie"
        Me.CheckBatterie.HeaderText = "CheckBatterie"
        Me.CheckBatterie.MinimumWidth = 8
        Me.CheckBatterie.Name = "CheckBatterie"
        Me.CheckBatterie.Width = 150
        '
        'Ausgangsort
        '
        Me.Ausgangsort.DataPropertyName = "Ausgangsort"
        Me.Ausgangsort.HeaderText = "Ausgangsort"
        Me.Ausgangsort.MinimumWidth = 8
        Me.Ausgangsort.Name = "Ausgangsort"
        Me.Ausgangsort.Width = 150
        '
        'Zielort
        '
        Me.Zielort.DataPropertyName = "Zielort"
        Me.Zielort.HeaderText = "Zielort"
        Me.Zielort.MinimumWidth = 8
        Me.Zielort.Name = "Zielort"
        Me.Zielort.Width = 150
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox36)
        Me.GroupBox5.Controls.Add(Me.TextBox35)
        Me.GroupBox5.Controls.Add(Me.TextBox34)
        Me.GroupBox5.Controls.Add(Me.TextBox33)
        Me.GroupBox5.Controls.Add(Me.CheckBox7)
        Me.GroupBox5.Controls.Add(Me.TextBox32)
        Me.GroupBox5.Controls.Add(Me.TextBox31)
        Me.GroupBox5.Controls.Add(Me.TextBox30)
        Me.GroupBox5.Controls.Add(Me.TextBox29)
        Me.GroupBox5.Controls.Add(Me.TextBox28)
        Me.GroupBox5.Controls.Add(Me.TextBox27)
        Me.GroupBox5.Location = New System.Drawing.Point(2564, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(267, 225)
        Me.GroupBox5.TabIndex = 1102
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "WacheplanLog"
        '
        'TextBox36
        '
        Me.TextBox36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "VZName3", True))
        Me.TextBox36.Location = New System.Drawing.Point(138, 100)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(100, 20)
        Me.TextBox36.TabIndex = 10
        '
        'TextBox35
        '
        Me.TextBox35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "Person3", True))
        Me.TextBox35.Location = New System.Drawing.Point(138, 73)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(100, 20)
        Me.TextBox35.TabIndex = 9
        '
        'TextBox34
        '
        Me.TextBox34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "VZName2", True))
        Me.TextBox34.Location = New System.Drawing.Point(138, 46)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(100, 20)
        Me.TextBox34.TabIndex = 8
        '
        'TextBox33
        '
        Me.TextBox33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "VZName1", True))
        Me.TextBox33.Location = New System.Drawing.Point(138, 20)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(100, 20)
        Me.TextBox33.TabIndex = 7
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsLogWacheplan, "Synchron", True))
        Me.CheckBox7.Location = New System.Drawing.Point(16, 198)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.TabStop = False
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'TextBox32
        '
        Me.TextBox32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "Toern", True))
        Me.TextBox32.Location = New System.Drawing.Point(16, 161)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(100, 20)
        Me.TextBox32.TabIndex = 5
        Me.TextBox32.TabStop = False
        '
        'TextBox31
        '
        Me.TextBox31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "Datum", True))
        Me.TextBox31.Location = New System.Drawing.Point(17, 136)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(100, 20)
        Me.TextBox31.TabIndex = 4
        Me.TextBox31.TabStop = False
        '
        'TextBox30
        '
        Me.TextBox30.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "TextBis", True))
        Me.TextBox30.Location = New System.Drawing.Point(17, 109)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(100, 20)
        Me.TextBox30.TabIndex = 3
        Me.TextBox30.TabStop = False
        '
        'TextBox29
        '
        Me.TextBox29.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "TextVon", True))
        Me.TextBox29.Location = New System.Drawing.Point(17, 73)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(100, 20)
        Me.TextBox29.TabIndex = 2
        Me.TextBox29.TabStop = False
        '
        'TextBox28
        '
        Me.TextBox28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "Person2", True))
        Me.TextBox28.Location = New System.Drawing.Point(16, 46)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(100, 20)
        Me.TextBox28.TabIndex = 1
        Me.TextBox28.TabStop = False
        '
        'TextBox27
        '
        Me.TextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLogWacheplan, "Person1", True))
        Me.TextBox27.Location = New System.Drawing.Point(17, 20)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(100, 20)
        Me.TextBox27.TabIndex = 0
        Me.TextBox27.TabStop = False
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.TornberichtDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.BordkassaDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.LogbuchDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn, Me.Nachtfahrtvon1DataGridViewTextBoxColumn, Me.Nachtfahrtbis1DataGridViewTextBoxColumn, Me.Sm1DataGridViewTextBoxColumn, Me.NachtfDatumvon1DataGridViewTextBoxColumn, Me.NachtZeitvon1DataGridViewTextBoxColumn, Me.NachtfDatumbis1DataGridViewTextBoxColumn, Me.NachtZeitbis1DataGridViewTextBoxColumn, Me.NachtFahrtvon2DataGridViewTextBoxColumn, Me.NachtFahrtbis2DataGridViewTextBoxColumn, Me.SM2DataGridViewTextBoxColumn, Me.NachtDatumvon2DataGridViewTextBoxColumn, Me.NachtZeitvon2DataGridViewTextBoxColumn, Me.NachtDatumbis2DataGridViewTextBoxColumn, Me.NachtZeitbis2DataGridViewTextBoxColumn, Me.Std50StartDataGridViewTextBoxColumn, Me.Std50ZielDataGridViewTextBoxColumn, Me.Std50SmGesDataGridViewTextBoxColumn, Me.Std50smFB2DataGridViewTextBoxColumn, Me.Std50DatumStartDataGridViewTextBoxColumn, Me.Std50ZeitStartDataGridViewTextBoxColumn, Me.Std50DatumZielDataGridViewTextBoxColumn, Me.Std50ZeitZielDataGridViewTextBoxColumn, Me.GezHafen1DataGridViewTextBoxColumn, Me.GezDatum1DataGridViewTextBoxColumn, Me.GezZeit1DataGridViewTextBoxColumn, Me.GezHafen2DataGridViewTextBoxColumn, Me.GezDatum2DataGridViewTextBoxColumn, Me.GezZeit2DataGridViewTextBoxColumn, Me.FB4StartDataGridViewTextBoxColumn, Me.FB4ZielDataGridViewTextBoxColumn, Me.FB4SmGesDataGridViewTextBoxColumn, Me.FB4SmFb3DataGridViewTextBoxColumn, Me.FB4DatumStartDataGridViewTextBoxColumn, Me.FB4ZeitStartDataGridViewTextBoxColumn, Me.FB4DatumZielDataGridViewTextBoxColumn, Me.FB4ZeitZielDataGridViewTextBoxColumn, Me.RevierDataGridViewTextBoxColumn, Me.VerbrauchproToernDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.bsToernname
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView4.Location = New System.Drawing.Point(1288, 209)
        Me.DataGridView4.Name = "DataGridView4"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView4.RowHeadersWidth = 62
        Me.DataGridView4.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView4.TabIndex = 1103
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        Me.IDDataGridViewTextBoxColumn3.Width = 150
        '
        'DatumVonDataGridViewTextBoxColumn
        '
        Me.DatumVonDataGridViewTextBoxColumn.DataPropertyName = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.HeaderText = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DatumVonDataGridViewTextBoxColumn.Name = "DatumVonDataGridViewTextBoxColumn"
        Me.DatumVonDataGridViewTextBoxColumn.Width = 150
        '
        'DatumBisDataGridViewTextBoxColumn
        '
        Me.DatumBisDataGridViewTextBoxColumn.DataPropertyName = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.HeaderText = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DatumBisDataGridViewTextBoxColumn.Name = "DatumBisDataGridViewTextBoxColumn"
        Me.DatumBisDataGridViewTextBoxColumn.Width = 150
        '
        'AusgangsmarinaDataGridViewTextBoxColumn
        '
        Me.AusgangsmarinaDataGridViewTextBoxColumn.DataPropertyName = "Ausgangsmarina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.HeaderText = "Ausgangsmarina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AusgangsmarinaDataGridViewTextBoxColumn.Name = "AusgangsmarinaDataGridViewTextBoxColumn"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.Width = 150
        '
        'EndeMarinaDataGridViewTextBoxColumn
        '
        Me.EndeMarinaDataGridViewTextBoxColumn.DataPropertyName = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.HeaderText = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EndeMarinaDataGridViewTextBoxColumn.Name = "EndeMarinaDataGridViewTextBoxColumn"
        Me.EndeMarinaDataGridViewTextBoxColumn.Width = 150
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Width = 150
        '
        'SmSegelDataGridViewTextBoxColumn
        '
        Me.SmSegelDataGridViewTextBoxColumn.DataPropertyName = "smSegel"
        Me.SmSegelDataGridViewTextBoxColumn.HeaderText = "smSegel"
        Me.SmSegelDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SmSegelDataGridViewTextBoxColumn.Name = "SmSegelDataGridViewTextBoxColumn"
        Me.SmSegelDataGridViewTextBoxColumn.Width = 150
        '
        'SmMotorDataGridViewTextBoxColumn
        '
        Me.SmMotorDataGridViewTextBoxColumn.DataPropertyName = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.HeaderText = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SmMotorDataGridViewTextBoxColumn.Name = "SmMotorDataGridViewTextBoxColumn"
        Me.SmMotorDataGridViewTextBoxColumn.Width = 150
        '
        'SmGesamtDataGridViewTextBoxColumn
        '
        Me.SmGesamtDataGridViewTextBoxColumn.DataPropertyName = "smGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.HeaderText = "smGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SmGesamtDataGridViewTextBoxColumn.Name = "SmGesamtDataGridViewTextBoxColumn"
        Me.SmGesamtDataGridViewTextBoxColumn.Width = 150
        '
        'NachtfahrtenDataGridViewTextBoxColumn
        '
        Me.NachtfahrtenDataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn.HeaderText = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtfahrtenDataGridViewTextBoxColumn.Name = "NachtfahrtenDataGridViewTextBoxColumn"
        Me.NachtfahrtenDataGridViewTextBoxColumn.Width = 150
        '
        'NachtansteuerungenDataGridViewTextBoxColumn
        '
        Me.NachtansteuerungenDataGridViewTextBoxColumn.DataPropertyName = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn.HeaderText = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtansteuerungenDataGridViewTextBoxColumn.Name = "NachtansteuerungenDataGridViewTextBoxColumn"
        Me.NachtansteuerungenDataGridViewTextBoxColumn.Width = 150
        '
        'BordtageDataGridViewTextBoxColumn
        '
        Me.BordtageDataGridViewTextBoxColumn.DataPropertyName = "Bordtage"
        Me.BordtageDataGridViewTextBoxColumn.HeaderText = "Bordtage"
        Me.BordtageDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BordtageDataGridViewTextBoxColumn.Name = "BordtageDataGridViewTextBoxColumn"
        Me.BordtageDataGridViewTextBoxColumn.Width = 150
        '
        'AusserhalbFB2DataGridViewTextBoxColumn
        '
        Me.AusserhalbFB2DataGridViewTextBoxColumn.DataPropertyName = "ausserhalbFB2"
        Me.AusserhalbFB2DataGridViewTextBoxColumn.HeaderText = "ausserhalbFB2"
        Me.AusserhalbFB2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AusserhalbFB2DataGridViewTextBoxColumn.Name = "AusserhalbFB2DataGridViewTextBoxColumn"
        Me.AusserhalbFB2DataGridViewTextBoxColumn.Width = 150
        '
        'AusserhalbFB3DataGridViewTextBoxColumn
        '
        Me.AusserhalbFB3DataGridViewTextBoxColumn.DataPropertyName = "ausserhalbFB3"
        Me.AusserhalbFB3DataGridViewTextBoxColumn.HeaderText = "ausserhalbFB3"
        Me.AusserhalbFB3DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AusserhalbFB3DataGridViewTextBoxColumn.Name = "AusserhalbFB3DataGridViewTextBoxColumn"
        Me.AusserhalbFB3DataGridViewTextBoxColumn.Width = 150
        '
        'TornberichtDataGridViewTextBoxColumn
        '
        Me.TornberichtDataGridViewTextBoxColumn.DataPropertyName = "Tornbericht"
        Me.TornberichtDataGridViewTextBoxColumn.HeaderText = "Tornbericht"
        Me.TornberichtDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TornberichtDataGridViewTextBoxColumn.Name = "TornberichtDataGridViewTextBoxColumn"
        Me.TornberichtDataGridViewTextBoxColumn.Width = 150
        '
        'BootsnameDataGridViewTextBoxColumn
        '
        Me.BootsnameDataGridViewTextBoxColumn.DataPropertyName = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.HeaderText = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BootsnameDataGridViewTextBoxColumn.Name = "BootsnameDataGridViewTextBoxColumn"
        Me.BootsnameDataGridViewTextBoxColumn.Width = 150
        '
        'SkipperDataGridViewTextBoxColumn
        '
        Me.SkipperDataGridViewTextBoxColumn.DataPropertyName = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.HeaderText = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SkipperDataGridViewTextBoxColumn.Name = "SkipperDataGridViewTextBoxColumn"
        Me.SkipperDataGridViewTextBoxColumn.Width = 150
        '
        'LetzterSegeltagDataGridViewCheckBoxColumn
        '
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.DataPropertyName = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.HeaderText = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.MinimumWidth = 8
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.Name = "LetzterSegeltagDataGridViewCheckBoxColumn"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.Width = 150
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        Me.BemerkungDataGridViewTextBoxColumn.Width = 150
        '
        'BordkassaDataGridViewTextBoxColumn
        '
        Me.BordkassaDataGridViewTextBoxColumn.DataPropertyName = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.HeaderText = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BordkassaDataGridViewTextBoxColumn.Name = "BordkassaDataGridViewTextBoxColumn"
        Me.BordkassaDataGridViewTextBoxColumn.Width = 150
        '
        'RouteDataGridViewTextBoxColumn
        '
        Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "Route"
        Me.RouteDataGridViewTextBoxColumn.HeaderText = "Route"
        Me.RouteDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
        Me.RouteDataGridViewTextBoxColumn.Width = 150
        '
        'LogbuchDataGridViewTextBoxColumn
        '
        Me.LogbuchDataGridViewTextBoxColumn.DataPropertyName = "Logbuch"
        Me.LogbuchDataGridViewTextBoxColumn.HeaderText = "Logbuch"
        Me.LogbuchDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LogbuchDataGridViewTextBoxColumn.Name = "LogbuchDataGridViewTextBoxColumn"
        Me.LogbuchDataGridViewTextBoxColumn.Width = 150
        '
        'R1DataGridViewTextBoxColumn
        '
        Me.R1DataGridViewTextBoxColumn.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.R1DataGridViewTextBoxColumn.Name = "R1DataGridViewTextBoxColumn"
        Me.R1DataGridViewTextBoxColumn.Width = 150
        '
        'R2DataGridViewTextBoxColumn
        '
        Me.R2DataGridViewTextBoxColumn.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.R2DataGridViewTextBoxColumn.Name = "R2DataGridViewTextBoxColumn"
        Me.R2DataGridViewTextBoxColumn.Width = 150
        '
        'R3DataGridViewTextBoxColumn
        '
        Me.R3DataGridViewTextBoxColumn.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.R3DataGridViewTextBoxColumn.Name = "R3DataGridViewTextBoxColumn"
        Me.R3DataGridViewTextBoxColumn.Width = 150
        '
        'IDToernDataGridViewTextBoxColumn
        '
        Me.IDToernDataGridViewTextBoxColumn.DataPropertyName = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.HeaderText = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDToernDataGridViewTextBoxColumn.Name = "IDToernDataGridViewTextBoxColumn"
        Me.IDToernDataGridViewTextBoxColumn.Width = 150
        '
        'Nachtfahrtvon1DataGridViewTextBoxColumn
        '
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrtvon1"
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.HeaderText = "Nachtfahrtvon1"
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.Name = "Nachtfahrtvon1DataGridViewTextBoxColumn"
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.Width = 150
        '
        'Nachtfahrtbis1DataGridViewTextBoxColumn
        '
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrtbis1"
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.HeaderText = "Nachtfahrtbis1"
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.Name = "Nachtfahrtbis1DataGridViewTextBoxColumn"
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.Width = 150
        '
        'Sm1DataGridViewTextBoxColumn
        '
        Me.Sm1DataGridViewTextBoxColumn.DataPropertyName = "Sm1"
        Me.Sm1DataGridViewTextBoxColumn.HeaderText = "Sm1"
        Me.Sm1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Sm1DataGridViewTextBoxColumn.Name = "Sm1DataGridViewTextBoxColumn"
        Me.Sm1DataGridViewTextBoxColumn.Width = 150
        '
        'NachtfDatumvon1DataGridViewTextBoxColumn
        '
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.DataPropertyName = "NachtfDatumvon1"
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.HeaderText = "NachtfDatumvon1"
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.Name = "NachtfDatumvon1DataGridViewTextBoxColumn"
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.Width = 150
        '
        'NachtZeitvon1DataGridViewTextBoxColumn
        '
        Me.NachtZeitvon1DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitvon1"
        Me.NachtZeitvon1DataGridViewTextBoxColumn.HeaderText = "NachtZeitvon1"
        Me.NachtZeitvon1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtZeitvon1DataGridViewTextBoxColumn.Name = "NachtZeitvon1DataGridViewTextBoxColumn"
        Me.NachtZeitvon1DataGridViewTextBoxColumn.Width = 150
        '
        'NachtfDatumbis1DataGridViewTextBoxColumn
        '
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.DataPropertyName = "NachtfDatumbis1"
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.HeaderText = "NachtfDatumbis1"
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.Name = "NachtfDatumbis1DataGridViewTextBoxColumn"
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.Width = 150
        '
        'NachtZeitbis1DataGridViewTextBoxColumn
        '
        Me.NachtZeitbis1DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitbis1"
        Me.NachtZeitbis1DataGridViewTextBoxColumn.HeaderText = "NachtZeitbis1"
        Me.NachtZeitbis1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtZeitbis1DataGridViewTextBoxColumn.Name = "NachtZeitbis1DataGridViewTextBoxColumn"
        Me.NachtZeitbis1DataGridViewTextBoxColumn.Width = 150
        '
        'NachtFahrtvon2DataGridViewTextBoxColumn
        '
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtFahrtvon2"
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.HeaderText = "NachtFahrtvon2"
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.Name = "NachtFahrtvon2DataGridViewTextBoxColumn"
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.Width = 150
        '
        'NachtFahrtbis2DataGridViewTextBoxColumn
        '
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtFahrtbis2"
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.HeaderText = "NachtFahrtbis2"
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.Name = "NachtFahrtbis2DataGridViewTextBoxColumn"
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.Width = 150
        '
        'SM2DataGridViewTextBoxColumn
        '
        Me.SM2DataGridViewTextBoxColumn.DataPropertyName = "SM2"
        Me.SM2DataGridViewTextBoxColumn.HeaderText = "SM2"
        Me.SM2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SM2DataGridViewTextBoxColumn.Name = "SM2DataGridViewTextBoxColumn"
        Me.SM2DataGridViewTextBoxColumn.Width = 150
        '
        'NachtDatumvon2DataGridViewTextBoxColumn
        '
        Me.NachtDatumvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtDatumvon2"
        Me.NachtDatumvon2DataGridViewTextBoxColumn.HeaderText = "NachtDatumvon2"
        Me.NachtDatumvon2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtDatumvon2DataGridViewTextBoxColumn.Name = "NachtDatumvon2DataGridViewTextBoxColumn"
        Me.NachtDatumvon2DataGridViewTextBoxColumn.Width = 150
        '
        'NachtZeitvon2DataGridViewTextBoxColumn
        '
        Me.NachtZeitvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitvon2"
        Me.NachtZeitvon2DataGridViewTextBoxColumn.HeaderText = "NachtZeitvon2"
        Me.NachtZeitvon2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtZeitvon2DataGridViewTextBoxColumn.Name = "NachtZeitvon2DataGridViewTextBoxColumn"
        Me.NachtZeitvon2DataGridViewTextBoxColumn.Width = 150
        '
        'NachtDatumbis2DataGridViewTextBoxColumn
        '
        Me.NachtDatumbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtDatumbis2"
        Me.NachtDatumbis2DataGridViewTextBoxColumn.HeaderText = "NachtDatumbis2"
        Me.NachtDatumbis2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtDatumbis2DataGridViewTextBoxColumn.Name = "NachtDatumbis2DataGridViewTextBoxColumn"
        Me.NachtDatumbis2DataGridViewTextBoxColumn.Width = 150
        '
        'NachtZeitbis2DataGridViewTextBoxColumn
        '
        Me.NachtZeitbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitbis2"
        Me.NachtZeitbis2DataGridViewTextBoxColumn.HeaderText = "NachtZeitbis2"
        Me.NachtZeitbis2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NachtZeitbis2DataGridViewTextBoxColumn.Name = "NachtZeitbis2DataGridViewTextBoxColumn"
        Me.NachtZeitbis2DataGridViewTextBoxColumn.Width = 150
        '
        'Std50StartDataGridViewTextBoxColumn
        '
        Me.Std50StartDataGridViewTextBoxColumn.DataPropertyName = "Std50Start"
        Me.Std50StartDataGridViewTextBoxColumn.HeaderText = "Std50Start"
        Me.Std50StartDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50StartDataGridViewTextBoxColumn.Name = "Std50StartDataGridViewTextBoxColumn"
        Me.Std50StartDataGridViewTextBoxColumn.Width = 150
        '
        'Std50ZielDataGridViewTextBoxColumn
        '
        Me.Std50ZielDataGridViewTextBoxColumn.DataPropertyName = "Std50Ziel"
        Me.Std50ZielDataGridViewTextBoxColumn.HeaderText = "Std50Ziel"
        Me.Std50ZielDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50ZielDataGridViewTextBoxColumn.Name = "Std50ZielDataGridViewTextBoxColumn"
        Me.Std50ZielDataGridViewTextBoxColumn.Width = 150
        '
        'Std50SmGesDataGridViewTextBoxColumn
        '
        Me.Std50SmGesDataGridViewTextBoxColumn.DataPropertyName = "Std50SmGes"
        Me.Std50SmGesDataGridViewTextBoxColumn.HeaderText = "Std50SmGes"
        Me.Std50SmGesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50SmGesDataGridViewTextBoxColumn.Name = "Std50SmGesDataGridViewTextBoxColumn"
        Me.Std50SmGesDataGridViewTextBoxColumn.Width = 150
        '
        'Std50smFB2DataGridViewTextBoxColumn
        '
        Me.Std50smFB2DataGridViewTextBoxColumn.DataPropertyName = "Std50smFB2"
        Me.Std50smFB2DataGridViewTextBoxColumn.HeaderText = "Std50smFB2"
        Me.Std50smFB2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50smFB2DataGridViewTextBoxColumn.Name = "Std50smFB2DataGridViewTextBoxColumn"
        Me.Std50smFB2DataGridViewTextBoxColumn.Width = 150
        '
        'Std50DatumStartDataGridViewTextBoxColumn
        '
        Me.Std50DatumStartDataGridViewTextBoxColumn.DataPropertyName = "Std50DatumStart"
        Me.Std50DatumStartDataGridViewTextBoxColumn.HeaderText = "Std50DatumStart"
        Me.Std50DatumStartDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50DatumStartDataGridViewTextBoxColumn.Name = "Std50DatumStartDataGridViewTextBoxColumn"
        Me.Std50DatumStartDataGridViewTextBoxColumn.Width = 150
        '
        'Std50ZeitStartDataGridViewTextBoxColumn
        '
        Me.Std50ZeitStartDataGridViewTextBoxColumn.DataPropertyName = "Std50ZeitStart"
        Me.Std50ZeitStartDataGridViewTextBoxColumn.HeaderText = "Std50ZeitStart"
        Me.Std50ZeitStartDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50ZeitStartDataGridViewTextBoxColumn.Name = "Std50ZeitStartDataGridViewTextBoxColumn"
        Me.Std50ZeitStartDataGridViewTextBoxColumn.Width = 150
        '
        'Std50DatumZielDataGridViewTextBoxColumn
        '
        Me.Std50DatumZielDataGridViewTextBoxColumn.DataPropertyName = "Std50DatumZiel"
        Me.Std50DatumZielDataGridViewTextBoxColumn.HeaderText = "Std50DatumZiel"
        Me.Std50DatumZielDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50DatumZielDataGridViewTextBoxColumn.Name = "Std50DatumZielDataGridViewTextBoxColumn"
        Me.Std50DatumZielDataGridViewTextBoxColumn.Width = 150
        '
        'Std50ZeitZielDataGridViewTextBoxColumn
        '
        Me.Std50ZeitZielDataGridViewTextBoxColumn.DataPropertyName = "Std50ZeitZiel"
        Me.Std50ZeitZielDataGridViewTextBoxColumn.HeaderText = "Std50ZeitZiel"
        Me.Std50ZeitZielDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Std50ZeitZielDataGridViewTextBoxColumn.Name = "Std50ZeitZielDataGridViewTextBoxColumn"
        Me.Std50ZeitZielDataGridViewTextBoxColumn.Width = 150
        '
        'GezHafen1DataGridViewTextBoxColumn
        '
        Me.GezHafen1DataGridViewTextBoxColumn.DataPropertyName = "GezHafen1"
        Me.GezHafen1DataGridViewTextBoxColumn.HeaderText = "GezHafen1"
        Me.GezHafen1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GezHafen1DataGridViewTextBoxColumn.Name = "GezHafen1DataGridViewTextBoxColumn"
        Me.GezHafen1DataGridViewTextBoxColumn.Width = 150
        '
        'GezDatum1DataGridViewTextBoxColumn
        '
        Me.GezDatum1DataGridViewTextBoxColumn.DataPropertyName = "GezDatum1"
        Me.GezDatum1DataGridViewTextBoxColumn.HeaderText = "GezDatum1"
        Me.GezDatum1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GezDatum1DataGridViewTextBoxColumn.Name = "GezDatum1DataGridViewTextBoxColumn"
        Me.GezDatum1DataGridViewTextBoxColumn.Width = 150
        '
        'GezZeit1DataGridViewTextBoxColumn
        '
        Me.GezZeit1DataGridViewTextBoxColumn.DataPropertyName = "GezZeit1"
        Me.GezZeit1DataGridViewTextBoxColumn.HeaderText = "GezZeit1"
        Me.GezZeit1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GezZeit1DataGridViewTextBoxColumn.Name = "GezZeit1DataGridViewTextBoxColumn"
        Me.GezZeit1DataGridViewTextBoxColumn.Width = 150
        '
        'GezHafen2DataGridViewTextBoxColumn
        '
        Me.GezHafen2DataGridViewTextBoxColumn.DataPropertyName = "GezHafen2"
        Me.GezHafen2DataGridViewTextBoxColumn.HeaderText = "GezHafen2"
        Me.GezHafen2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GezHafen2DataGridViewTextBoxColumn.Name = "GezHafen2DataGridViewTextBoxColumn"
        Me.GezHafen2DataGridViewTextBoxColumn.Width = 150
        '
        'GezDatum2DataGridViewTextBoxColumn
        '
        Me.GezDatum2DataGridViewTextBoxColumn.DataPropertyName = "GezDatum2"
        Me.GezDatum2DataGridViewTextBoxColumn.HeaderText = "GezDatum2"
        Me.GezDatum2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GezDatum2DataGridViewTextBoxColumn.Name = "GezDatum2DataGridViewTextBoxColumn"
        Me.GezDatum2DataGridViewTextBoxColumn.Width = 150
        '
        'GezZeit2DataGridViewTextBoxColumn
        '
        Me.GezZeit2DataGridViewTextBoxColumn.DataPropertyName = "GezZeit2"
        Me.GezZeit2DataGridViewTextBoxColumn.HeaderText = "GezZeit2"
        Me.GezZeit2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GezZeit2DataGridViewTextBoxColumn.Name = "GezZeit2DataGridViewTextBoxColumn"
        Me.GezZeit2DataGridViewTextBoxColumn.Width = 150
        '
        'FB4StartDataGridViewTextBoxColumn
        '
        Me.FB4StartDataGridViewTextBoxColumn.DataPropertyName = "FB4Start"
        Me.FB4StartDataGridViewTextBoxColumn.HeaderText = "FB4Start"
        Me.FB4StartDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4StartDataGridViewTextBoxColumn.Name = "FB4StartDataGridViewTextBoxColumn"
        Me.FB4StartDataGridViewTextBoxColumn.Width = 150
        '
        'FB4ZielDataGridViewTextBoxColumn
        '
        Me.FB4ZielDataGridViewTextBoxColumn.DataPropertyName = "FB4Ziel"
        Me.FB4ZielDataGridViewTextBoxColumn.HeaderText = "FB4Ziel"
        Me.FB4ZielDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4ZielDataGridViewTextBoxColumn.Name = "FB4ZielDataGridViewTextBoxColumn"
        Me.FB4ZielDataGridViewTextBoxColumn.Width = 150
        '
        'FB4SmGesDataGridViewTextBoxColumn
        '
        Me.FB4SmGesDataGridViewTextBoxColumn.DataPropertyName = "FB4SmGes"
        Me.FB4SmGesDataGridViewTextBoxColumn.HeaderText = "FB4SmGes"
        Me.FB4SmGesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4SmGesDataGridViewTextBoxColumn.Name = "FB4SmGesDataGridViewTextBoxColumn"
        Me.FB4SmGesDataGridViewTextBoxColumn.Width = 150
        '
        'FB4SmFb3DataGridViewTextBoxColumn
        '
        Me.FB4SmFb3DataGridViewTextBoxColumn.DataPropertyName = "FB4SmFb3"
        Me.FB4SmFb3DataGridViewTextBoxColumn.HeaderText = "FB4SmFb3"
        Me.FB4SmFb3DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4SmFb3DataGridViewTextBoxColumn.Name = "FB4SmFb3DataGridViewTextBoxColumn"
        Me.FB4SmFb3DataGridViewTextBoxColumn.Width = 150
        '
        'FB4DatumStartDataGridViewTextBoxColumn
        '
        Me.FB4DatumStartDataGridViewTextBoxColumn.DataPropertyName = "FB4DatumStart"
        Me.FB4DatumStartDataGridViewTextBoxColumn.HeaderText = "FB4DatumStart"
        Me.FB4DatumStartDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4DatumStartDataGridViewTextBoxColumn.Name = "FB4DatumStartDataGridViewTextBoxColumn"
        Me.FB4DatumStartDataGridViewTextBoxColumn.Width = 150
        '
        'FB4ZeitStartDataGridViewTextBoxColumn
        '
        Me.FB4ZeitStartDataGridViewTextBoxColumn.DataPropertyName = "FB4ZeitStart"
        Me.FB4ZeitStartDataGridViewTextBoxColumn.HeaderText = "FB4ZeitStart"
        Me.FB4ZeitStartDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4ZeitStartDataGridViewTextBoxColumn.Name = "FB4ZeitStartDataGridViewTextBoxColumn"
        Me.FB4ZeitStartDataGridViewTextBoxColumn.Width = 150
        '
        'FB4DatumZielDataGridViewTextBoxColumn
        '
        Me.FB4DatumZielDataGridViewTextBoxColumn.DataPropertyName = "FB4DatumZiel"
        Me.FB4DatumZielDataGridViewTextBoxColumn.HeaderText = "FB4DatumZiel"
        Me.FB4DatumZielDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4DatumZielDataGridViewTextBoxColumn.Name = "FB4DatumZielDataGridViewTextBoxColumn"
        Me.FB4DatumZielDataGridViewTextBoxColumn.Width = 150
        '
        'FB4ZeitZielDataGridViewTextBoxColumn
        '
        Me.FB4ZeitZielDataGridViewTextBoxColumn.DataPropertyName = "FB4ZeitZiel"
        Me.FB4ZeitZielDataGridViewTextBoxColumn.HeaderText = "FB4ZeitZiel"
        Me.FB4ZeitZielDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FB4ZeitZielDataGridViewTextBoxColumn.Name = "FB4ZeitZielDataGridViewTextBoxColumn"
        Me.FB4ZeitZielDataGridViewTextBoxColumn.Width = 150
        '
        'RevierDataGridViewTextBoxColumn
        '
        Me.RevierDataGridViewTextBoxColumn.DataPropertyName = "Revier"
        Me.RevierDataGridViewTextBoxColumn.HeaderText = "Revier"
        Me.RevierDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RevierDataGridViewTextBoxColumn.Name = "RevierDataGridViewTextBoxColumn"
        Me.RevierDataGridViewTextBoxColumn.Width = 150
        '
        'VerbrauchproToernDataGridViewTextBoxColumn
        '
        Me.VerbrauchproToernDataGridViewTextBoxColumn.DataPropertyName = "VerbrauchproToern"
        Me.VerbrauchproToernDataGridViewTextBoxColumn.HeaderText = "VerbrauchproToern"
        Me.VerbrauchproToernDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.VerbrauchproToernDataGridViewTextBoxColumn.Name = "VerbrauchproToernDataGridViewTextBoxColumn"
        Me.VerbrauchproToernDataGridViewTextBoxColumn.Width = 150
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
        'bsWacheplan
        '
        Me.bsWacheplan.DataMember = "Wacheplan"
        Me.bsWacheplan.DataSource = Me.dsToernverwaltung
        '
        'taWacheplan
        '
        Me.taWacheplan.ClearBeforeFill = True
        '
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'MaterialKursTableAdapter1
        '
        Me.MaterialKursTableAdapter1.ClearBeforeFill = True
        '
        'taLogdaten
        '
        Me.taLogdaten.ClearBeforeFill = True
        '
        'taLogWacheplan
        '
        Me.taLogWacheplan.ClearBeforeFill = True
        '
        'taDokumentation
        '
        Me.taDokumentation.ClearBeforeFill = True
        '
        'Logdaten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 627)
        Me.Controls.Add(Me.TextBox37)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gbDoku)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.ButtonSpeichern)
        Me.Controls.Add(Me.gbFahrt)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Logdaten"
        Me.Text = "Logdaten"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogdaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLogbuch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDoku.ResumeLayout(False)
        Me.gbDoku.PerformLayout()
        Me.gbBesonderes.ResumeLayout(False)
        CType(Me.bsDokumentation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogWacheplan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCheck.ResumeLayout(False)
        Me.gbCheck.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbZielort.ResumeLayout(False)
        Me.gbZielort.PerformLayout()
        Me.gbBemerkung.ResumeLayout(False)
        Me.gbFahrt.ResumeLayout(False)
        Me.gbFahrt.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Be0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWacheplan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AusgangsortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbDoku As System.Windows.Forms.GroupBox
    Friend WithEvents gbFahrt As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSpeichern As System.Windows.Forms.Button
    Friend WithEvents gbBesonderes As System.Windows.Forms.GroupBox
    Friend WithEvents gbBemerkung As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents gbCheck As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents gbZielort As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents ZeitVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZeitBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsWacheplan As System.Windows.Forms.BindingSource
    Friend WithEvents taWacheplan As WindowsApplication1.ToernverwaltungDataSetTableAdapters.WacheplanTableAdapter
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DsLogbuch As WindowsApplication1.dsLogbuch
    Friend WithEvents bsLogdaten As System.Windows.Forms.BindingSource
    Friend WithEvents taLogdaten As WindowsApplication1.dsLogbuchTableAdapters.LogdatenTableAdapter
    Friend WithEvents bsLogWacheplan As System.Windows.Forms.BindingSource
    Friend WithEvents taLogWacheplan As WindowsApplication1.dsLogbuchTableAdapters.LogWacheplanTableAdapter
    Friend WithEvents bsDokumentation As System.Windows.Forms.BindingSource
    Friend WithEvents taDokumentation As WindowsApplication1.dsLogbuchTableAdapters.DokumentationTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Toernbezeichnung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wetterbericht1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wetterbericht2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wetterbericht3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uhrzeit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bemerkungen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Besonderes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielGebühr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielMüll As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ZielStrom As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MotorStdAnfang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorStdEnde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kraftstoffgetankt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kraffstoffkosten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBilge As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WasserTanken As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckOel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckBatterie As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ausgangsort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Zielort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Be0 As System.Windows.Forms.PictureBox
    Friend WithEvents Be1 As System.Windows.Forms.PictureBox
    Friend WithEvents Be2 As System.Windows.Forms.PictureBox
    Friend WithEvents Be3 As System.Windows.Forms.PictureBox
    Friend WithEvents Be4 As System.Windows.Forms.PictureBox
    Friend WithEvents Be5 As System.Windows.Forms.PictureBox
    Friend WithEvents Be6 As System.Windows.Forms.PictureBox
    Friend WithEvents Be7 As System.Windows.Forms.PictureBox
    Friend WithEvents Be8 As System.Windows.Forms.PictureBox
    Friend WithEvents Be9 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents MaterialKursTableAdapter1 As WindowsApplication1.dsAusbildungTableAdapters.MaterialKursTableAdapter
    Friend WithEvents TextVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Person3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblRelayStatus As System.Windows.Forms.Label
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents UhrzeitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WindRichtungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WindstaerkeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeegangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LuftdruckDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WolkenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KueGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AntriebsartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueGTagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueGSegelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DuegMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToerbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
