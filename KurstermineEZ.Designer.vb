<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KurstermineEZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KurstermineEZ))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.bsTermine = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.bsTeilnehmer = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKursBezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumKBFaelligDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kursbezeichnung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fahrtbereich = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnzahlEinheiten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taTeilnehmer = New WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter()
        Me.taTermine = New WindowsApplication1.dsAusbildungTableAdapters.TermineTableAdapter()
        Me.GroupBox6Kalender = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button5Zurueck = New System.Windows.Forms.Button()
        Me.Button7Speichern = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.bsTermine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6Kalender.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox19)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.PictureBox11)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox4.Controls.Add(Me.TextBox11)
        Me.GroupBox4.Controls.Add(Me.TextBox12)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(601, 491)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kursanwesenheit einzeln eingeben"
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTermine, "AnzahlEinheiten", True))
        Me.TextBox19.Location = New System.Drawing.Point(186, 149)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(82, 20)
        Me.TextBox19.TabIndex = 27
        '
        'bsTermine
        '
        Me.bsTermine.DataMember = "Termine"
        Me.bsTermine.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(33, 152)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Kursteinheiten"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(119, 104)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 26
        Me.PictureBox11.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(433, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 54)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Speichern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(119, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "VZName", True))
        Me.TextBox8.Location = New System.Drawing.Point(186, 36)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(182, 20)
        Me.TextBox8.TabIndex = 1
        '
        'bsTeilnehmer
        '
        Me.bsTeilnehmer.DataMember = "Teilnehmer"
        Me.bsTeilnehmer.DataSource = Me.DsAusbildung
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTermine, "Thema", True))
        Me.TextBox10.Location = New System.Drawing.Point(186, 192)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(182, 20)
        Me.TextBox10.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Kursthema"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Datum"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Teilnehmer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(407, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Fahrtbereich"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Kurs"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTermine, "Datum", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(186, 108)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(82, 20)
        Me.MaskedTextBox3.TabIndex = 4
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "FB", True))
        Me.TextBox11.Location = New System.Drawing.Point(489, 73)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(82, 20)
        Me.TextBox11.TabIndex = 3
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTeilnehmer, "Kurs", True))
        Me.TextBox12.Location = New System.Drawing.Point(186, 73)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(182, 20)
        Me.TextBox12.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsTermine, "Anwesend", True))
        Me.CheckBox2.Location = New System.Drawing.Point(709, 151)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox2.TabIndex = 29
        Me.CheckBox2.Text = "Anwesend"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZNameDataGridViewTextBoxColumn, Me.KursDataGridViewTextBoxColumn, Me.FBDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.KursPreisDataGridViewTextBoxColumn, Me.KursBezahltDataGridViewTextBoxColumn, Me.MaterialpreisDataGridViewTextBoxColumn, Me.MaterialBezahltDataGridViewTextBoxColumn, Me.DatumKursBezahltDataGridViewTextBoxColumn, Me.DatumKBFaelligDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.bsTeilnehmer
        Me.DataGridView3.Location = New System.Drawing.Point(871, 174)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(567, 165)
        Me.DataGridView3.TabIndex = 12
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
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
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
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kursbezeichnung, Me.Fahrtbereich, Me.VZname, Me.Datum, Me.Thema, Me.AnzahlEinheiten, Me.BemerkungDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsTermine
        Me.DataGridView1.Location = New System.Drawing.Point(871, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(568, 158)
        Me.DataGridView1.TabIndex = 11
        '
        'Kursbezeichnung
        '
        Me.Kursbezeichnung.DataPropertyName = "Kursbezeichnung"
        Me.Kursbezeichnung.HeaderText = "Kursbezeichnung"
        Me.Kursbezeichnung.Name = "Kursbezeichnung"
        '
        'Fahrtbereich
        '
        Me.Fahrtbereich.DataPropertyName = "Fahrtbereich"
        Me.Fahrtbereich.HeaderText = "Fahrtbereich"
        Me.Fahrtbereich.Name = "Fahrtbereich"
        '
        'VZname
        '
        Me.VZname.DataPropertyName = "VZname"
        Me.VZname.HeaderText = "VZname"
        Me.VZname.Name = "VZname"
        '
        'Datum
        '
        Me.Datum.DataPropertyName = "Datum"
        Me.Datum.HeaderText = "Datum"
        Me.Datum.Name = "Datum"
        '
        'Thema
        '
        Me.Thema.DataPropertyName = "Thema"
        Me.Thema.HeaderText = "Thema"
        Me.Thema.Name = "Thema"
        '
        'AnzahlEinheiten
        '
        Me.AnzahlEinheiten.DataPropertyName = "AnzahlEinheiten"
        Me.AnzahlEinheiten.HeaderText = "AnzahlEinheiten"
        Me.AnzahlEinheiten.Name = "AnzahlEinheiten"
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
        'taTeilnehmer
        '
        Me.taTeilnehmer.ClearBeforeFill = True
        '
        'taTermine
        '
        Me.taTermine.ClearBeforeFill = True
        '
        'GroupBox6Kalender
        '
        Me.GroupBox6Kalender.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox6Kalender.Controls.Add(Me.Button5Zurueck)
        Me.GroupBox6Kalender.Controls.Add(Me.Button7Speichern)
        Me.GroupBox6Kalender.Location = New System.Drawing.Point(709, 223)
        Me.GroupBox6Kalender.Name = "GroupBox6Kalender"
        Me.GroupBox6Kalender.Size = New System.Drawing.Size(228, 227)
        Me.GroupBox6Kalender.TabIndex = 88
        Me.GroupBox6Kalender.TabStop = False
        Me.GroupBox6Kalender.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(15, 14)
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
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTermine, "Kursbezeichnung", True))
        Me.TextBox1.Location = New System.Drawing.Point(709, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 89
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTermine, "Fahrtbereich", True))
        Me.TextBox2.Location = New System.Drawing.Point(709, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 90
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTermine, "VZname", True))
        Me.TextBox3.Location = New System.Drawing.Point(709, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 91
        '
        'KurstermineEZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 503)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox6Kalender)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KurstermineEZ"
        Me.Text = "Kurstermine - einzeln zuordnen"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.bsTermine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTeilnehmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6Kalender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsTeilnehmer As System.Windows.Forms.BindingSource
    Friend WithEvents taTeilnehmer As WindowsApplication1.dsAusbildungTableAdapters.TeilnehmerTableAdapter
    Friend WithEvents bsTermine As System.Windows.Forms.BindingSource
    Friend WithEvents taTermine As WindowsApplication1.dsAusbildungTableAdapters.TermineTableAdapter
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursPreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKursBezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumKBFaelligDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kursbezeichnung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fahrtbereich As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thema As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnzahlEinheiten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6Kalender As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button5Zurueck As System.Windows.Forms.Button
    Friend WithEvents Button7Speichern As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
