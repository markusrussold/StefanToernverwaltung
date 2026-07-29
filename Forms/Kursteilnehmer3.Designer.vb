<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kursteilnehmer3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kursteilnehmer3))
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.bsKurse = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKBFaelligDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1Drucken = New System.Windows.Forms.Button()
        Me.taTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KursbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FahrtbereichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursbeginnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preis3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VortragendeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursdauerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenKursortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taKurse = New WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter()
        Me.GroupBox10.SuspendLayout()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.TextBox25)
        Me.GroupBox10.Controls.Add(Me.TextBox26)
        Me.GroupBox10.Controls.Add(Me.Label21)
        Me.GroupBox10.Controls.Add(Me.Label22)
        Me.GroupBox10.Controls.Add(Me.PictureBox3)
        Me.GroupBox10.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(522, 93)
        Me.GroupBox10.TabIndex = 31
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Kurs auswählen"
        '
        'TextBox25
        '
        Me.TextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKurse, "Fahrtbereich", True))
        Me.TextBox25.Location = New System.Drawing.Point(369, 29)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(100, 20)
        Me.TextBox25.TabIndex = 3
        '
        'bsKurse
        '
        Me.bsKurse.DataMember = "Kurse"
        Me.bsKurse.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox26
        '
        Me.TextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKurse, "Kursbezeichnung", True))
        Me.TextBox26.Location = New System.Drawing.Point(108, 29)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(166, 20)
        Me.TextBox26.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(280, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Fahrtbereich"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Kurs"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(53, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZNameDataGridViewTextBoxColumn, Me.KursDataGridViewTextBoxColumn, Me.FBDataGridViewTextBoxColumn, Me.KursPreisDataGridViewTextBoxColumn, Me.MaterialpreisDataGridViewTextBoxColumn, Me.KursBezahltDataGridViewTextBoxColumn, Me.MaterialBezahltDataGridViewTextBoxColumn, Me.DatumKursBezahltDataGridViewTextBoxColumn, Me.DatumKBFaelligDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.bsTeilnehmer
        Me.DataGridView3.Location = New System.Drawing.Point(637, 111)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(522, 183)
        Me.DataGridView3.TabIndex = 32
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
        'KursPreisDataGridViewTextBoxColumn
        '
        Me.KursPreisDataGridViewTextBoxColumn.DataPropertyName = "KursPreis"
        Me.KursPreisDataGridViewTextBoxColumn.HeaderText = "KursPreis"
        Me.KursPreisDataGridViewTextBoxColumn.Name = "KursPreisDataGridViewTextBoxColumn"
        '
        'MaterialpreisDataGridViewTextBoxColumn
        '
        Me.MaterialpreisDataGridViewTextBoxColumn.DataPropertyName = "Materialpreis"
        Me.MaterialpreisDataGridViewTextBoxColumn.HeaderText = "Materialpreis"
        Me.MaterialpreisDataGridViewTextBoxColumn.Name = "MaterialpreisDataGridViewTextBoxColumn"
        '
        'KursBezahltDataGridViewTextBoxColumn
        '
        Me.KursBezahltDataGridViewTextBoxColumn.DataPropertyName = "KursBezahlt"
        Me.KursBezahltDataGridViewTextBoxColumn.HeaderText = "KursBezahlt"
        Me.KursBezahltDataGridViewTextBoxColumn.Name = "KursBezahltDataGridViewTextBoxColumn"
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
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'bsTeilnehmer
        '
        Me.bsTeilnehmer.DataMember = "Teilnehmer"
        Me.bsTeilnehmer.DataSource = Me.DsAusbildung
        '
        'Button1Drucken
        '
        Me.Button1Drucken.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Drucken.Location = New System.Drawing.Point(415, 300)
        Me.Button1Drucken.Name = "Button1Drucken"
        Me.Button1Drucken.Size = New System.Drawing.Size(131, 43)
        Me.Button1Drucken.TabIndex = 33
        Me.Button1Drucken.Text = "Drucken"
        Me.Button1Drucken.UseVisualStyleBackColor = True
        '
        'taTeilnehmer
        '
        Me.taTeilnehmer.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KursbezeichnungDataGridViewTextBoxColumn, Me.FahrtbereichDataGridViewTextBoxColumn, Me.KursbeginnDataGridViewTextBoxColumn, Me.KursortDataGridViewTextBoxColumn, Me.Preis1DataGridViewTextBoxColumn, Me.Preis2DataGridViewTextBoxColumn, Me.Preis3DataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.VortragendeDataGridViewTextBoxColumn, Me.ReserveDataGridViewTextBoxColumn, Me.KursdauerDataGridViewTextBoxColumn, Me.KostenKursortDataGridViewTextBoxColumn, Me.KursartDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.bsKurse
        Me.DataGridView1.Location = New System.Drawing.Point(25, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(521, 183)
        Me.DataGridView1.TabIndex = 34
        '
        'KursbezeichnungDataGridViewTextBoxColumn
        '
        Me.KursbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Kursbezeichnung"
        Me.KursbezeichnungDataGridViewTextBoxColumn.HeaderText = "Kursbezeichnung"
        Me.KursbezeichnungDataGridViewTextBoxColumn.Name = "KursbezeichnungDataGridViewTextBoxColumn"
        '
        'FahrtbereichDataGridViewTextBoxColumn
        '
        Me.FahrtbereichDataGridViewTextBoxColumn.DataPropertyName = "Fahrtbereich"
        Me.FahrtbereichDataGridViewTextBoxColumn.HeaderText = "Fahrtbereich"
        Me.FahrtbereichDataGridViewTextBoxColumn.Name = "FahrtbereichDataGridViewTextBoxColumn"
        '
        'KursbeginnDataGridViewTextBoxColumn
        '
        Me.KursbeginnDataGridViewTextBoxColumn.DataPropertyName = "Kursbeginn"
        Me.KursbeginnDataGridViewTextBoxColumn.HeaderText = "Kursbeginn"
        Me.KursbeginnDataGridViewTextBoxColumn.Name = "KursbeginnDataGridViewTextBoxColumn"
        '
        'KursortDataGridViewTextBoxColumn
        '
        Me.KursortDataGridViewTextBoxColumn.DataPropertyName = "Kursort"
        Me.KursortDataGridViewTextBoxColumn.HeaderText = "Kursort"
        Me.KursortDataGridViewTextBoxColumn.Name = "KursortDataGridViewTextBoxColumn"
        '
        'Preis1DataGridViewTextBoxColumn
        '
        Me.Preis1DataGridViewTextBoxColumn.DataPropertyName = "Preis1"
        Me.Preis1DataGridViewTextBoxColumn.HeaderText = "Preis1"
        Me.Preis1DataGridViewTextBoxColumn.Name = "Preis1DataGridViewTextBoxColumn"
        '
        'Preis2DataGridViewTextBoxColumn
        '
        Me.Preis2DataGridViewTextBoxColumn.DataPropertyName = "Preis2"
        Me.Preis2DataGridViewTextBoxColumn.HeaderText = "Preis2"
        Me.Preis2DataGridViewTextBoxColumn.Name = "Preis2DataGridViewTextBoxColumn"
        '
        'Preis3DataGridViewTextBoxColumn
        '
        Me.Preis3DataGridViewTextBoxColumn.DataPropertyName = "Preis3"
        Me.Preis3DataGridViewTextBoxColumn.HeaderText = "Preis3"
        Me.Preis3DataGridViewTextBoxColumn.Name = "Preis3DataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'VortragendeDataGridViewTextBoxColumn
        '
        Me.VortragendeDataGridViewTextBoxColumn.DataPropertyName = "Vortragende"
        Me.VortragendeDataGridViewTextBoxColumn.HeaderText = "Vortragende"
        Me.VortragendeDataGridViewTextBoxColumn.Name = "VortragendeDataGridViewTextBoxColumn"
        '
        'ReserveDataGridViewTextBoxColumn
        '
        Me.ReserveDataGridViewTextBoxColumn.DataPropertyName = "Reserve"
        Me.ReserveDataGridViewTextBoxColumn.HeaderText = "Reserve"
        Me.ReserveDataGridViewTextBoxColumn.Name = "ReserveDataGridViewTextBoxColumn"
        '
        'KursdauerDataGridViewTextBoxColumn
        '
        Me.KursdauerDataGridViewTextBoxColumn.DataPropertyName = "Kursdauer"
        Me.KursdauerDataGridViewTextBoxColumn.HeaderText = "Kursdauer"
        Me.KursdauerDataGridViewTextBoxColumn.Name = "KursdauerDataGridViewTextBoxColumn"
        '
        'KostenKursortDataGridViewTextBoxColumn
        '
        Me.KostenKursortDataGridViewTextBoxColumn.DataPropertyName = "KostenKursort"
        Me.KostenKursortDataGridViewTextBoxColumn.HeaderText = "KostenKursort"
        Me.KostenKursortDataGridViewTextBoxColumn.Name = "KostenKursortDataGridViewTextBoxColumn"
        '
        'KursartDataGridViewTextBoxColumn
        '
        Me.KursartDataGridViewTextBoxColumn.DataPropertyName = "Kursart"
        Me.KursartDataGridViewTextBoxColumn.HeaderText = "Kursart"
        Me.KursartDataGridViewTextBoxColumn.Name = "KursartDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'taKurse
        '
        Me.taKurse.ClearBeforeFill = True
        '
        'Kursteilnehmer3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 353)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1Drucken)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.GroupBox10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kursteilnehmer3"
        Me.Text = "Teilnehmerliste"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.bsKurse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents Button1Drucken As System.Windows.Forms.Button
    Friend WithEvents bsTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursPreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKBFaelligDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bsKurse As System.Windows.Forms.BindingSource
    Friend WithEvents taKurse As WindowsApplication1.dsAusbildungTableAdapters.KurseTableAdapter
    Friend WithEvents KursbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FahrtbereichDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursbeginnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preis3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VortragendeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReserveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursdauerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenKursortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
