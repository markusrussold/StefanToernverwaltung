<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crewliste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crewliste))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioDeutsch = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Toernbezeichnung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ausgangsmarina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bootsname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Route = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Revier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.RadioTürkisch = New System.Windows.Forms.RadioButton()
        Me.RadioGriechisch = New System.Windows.Forms.RadioButton()
        Me.RadioAdria = New System.Windows.Forms.RadioButton()
        Me.Radioschwedisch = New System.Windows.Forms.RadioButton()
        Me.RadioSpanisch = New System.Windows.Forms.RadioButton()
        Me.RadioItaliano = New System.Windows.Forms.RadioButton()
        Me.RadioFranzoesisch = New System.Windows.Forms.RadioButton()
        Me.RadioEnglisch = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bsTemp = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.taTemp = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bsToernKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.taToernKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioDeutsch)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.RadioTürkisch)
        Me.GroupBox1.Controls.Add(Me.RadioGriechisch)
        Me.GroupBox1.Controls.Add(Me.RadioAdria)
        Me.GroupBox1.Controls.Add(Me.Radioschwedisch)
        Me.GroupBox1.Controls.Add(Me.RadioSpanisch)
        Me.GroupBox1.Controls.Add(Me.RadioItaliano)
        Me.GroupBox1.Controls.Add(Me.RadioFranzoesisch)
        Me.GroupBox1.Controls.Add(Me.RadioEnglisch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 442)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crewliste "
        '
        'RadioDeutsch
        '
        Me.RadioDeutsch.AutoSize = True
        Me.RadioDeutsch.Location = New System.Drawing.Point(146, 154)
        Me.RadioDeutsch.Name = "RadioDeutsch"
        Me.RadioDeutsch.Size = New System.Drawing.Size(75, 20)
        Me.RadioDeutsch.TabIndex = 14
        Me.RadioDeutsch.TabStop = True
        Me.RadioDeutsch.Text = "Deutsch"
        Me.RadioDeutsch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Toernbezeichnung, Me.Ausgangsmarina, Me.DatumVon, Me.Bootsname, Me.SkipperDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.DatumBis, Me.Route, Me.Revier})
        Me.DataGridView1.DataSource = Me.bsToernname
        Me.DataGridView1.Location = New System.Drawing.Point(17, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(704, 332)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'Toernbezeichnung
        '
        Me.Toernbezeichnung.DataPropertyName = "Toernbezeichnung"
        Me.Toernbezeichnung.HeaderText = "Toernbezeichnung"
        Me.Toernbezeichnung.Name = "Toernbezeichnung"
        Me.Toernbezeichnung.ReadOnly = True
        '
        'Ausgangsmarina
        '
        Me.Ausgangsmarina.DataPropertyName = "Ausgangsmarina"
        Me.Ausgangsmarina.HeaderText = "Ausgangsmarina"
        Me.Ausgangsmarina.Name = "Ausgangsmarina"
        Me.Ausgangsmarina.ReadOnly = True
        '
        'DatumVon
        '
        Me.DatumVon.DataPropertyName = "DatumVon"
        Me.DatumVon.HeaderText = "DatumVon"
        Me.DatumVon.Name = "DatumVon"
        Me.DatumVon.ReadOnly = True
        '
        'Bootsname
        '
        Me.Bootsname.DataPropertyName = "Bootsname"
        Me.Bootsname.HeaderText = "Bootsname"
        Me.Bootsname.Name = "Bootsname"
        Me.Bootsname.ReadOnly = True
        '
        'SkipperDataGridViewTextBoxColumn
        '
        Me.SkipperDataGridViewTextBoxColumn.DataPropertyName = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.HeaderText = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.Name = "SkipperDataGridViewTextBoxColumn"
        Me.SkipperDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        Me.BemerkungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatumBis
        '
        Me.DatumBis.DataPropertyName = "DatumBis"
        Me.DatumBis.HeaderText = "DatumBis"
        Me.DatumBis.Name = "DatumBis"
        Me.DatumBis.ReadOnly = True
        '
        'Route
        '
        Me.Route.DataPropertyName = "Route"
        Me.Route.HeaderText = "Route"
        Me.Route.Name = "Route"
        Me.Route.ReadOnly = True
        '
        'Revier
        '
        Me.Revier.DataPropertyName = "Revier"
        Me.Revier.HeaderText = "Revier"
        Me.Revier.Name = "Revier"
        Me.Revier.ReadOnly = True
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
        'RadioTürkisch
        '
        Me.RadioTürkisch.AutoSize = True
        Me.RadioTürkisch.Location = New System.Drawing.Point(146, 365)
        Me.RadioTürkisch.Name = "RadioTürkisch"
        Me.RadioTürkisch.Size = New System.Drawing.Size(77, 20)
        Me.RadioTürkisch.TabIndex = 13
        Me.RadioTürkisch.Text = "Türkisch"
        Me.RadioTürkisch.UseVisualStyleBackColor = True
        '
        'RadioGriechisch
        '
        Me.RadioGriechisch.AutoSize = True
        Me.RadioGriechisch.Location = New System.Drawing.Point(146, 338)
        Me.RadioGriechisch.Name = "RadioGriechisch"
        Me.RadioGriechisch.Size = New System.Drawing.Size(89, 20)
        Me.RadioGriechisch.TabIndex = 12
        Me.RadioGriechisch.Text = "Griechisch"
        Me.RadioGriechisch.UseVisualStyleBackColor = True
        '
        'RadioAdria
        '
        Me.RadioAdria.AutoSize = True
        Me.RadioAdria.Location = New System.Drawing.Point(146, 311)
        Me.RadioAdria.Name = "RadioAdria"
        Me.RadioAdria.Size = New System.Drawing.Size(155, 20)
        Me.RadioAdria.TabIndex = 11
        Me.RadioAdria.Text = "Kroatisch, Slowenisch"
        Me.RadioAdria.UseVisualStyleBackColor = True
        '
        'Radioschwedisch
        '
        Me.Radioschwedisch.AutoSize = True
        Me.Radioschwedisch.Location = New System.Drawing.Point(146, 284)
        Me.Radioschwedisch.Name = "Radioschwedisch"
        Me.Radioschwedisch.Size = New System.Drawing.Size(98, 20)
        Me.Radioschwedisch.TabIndex = 10
        Me.Radioschwedisch.Text = "Schwedisch"
        Me.Radioschwedisch.UseVisualStyleBackColor = True
        '
        'RadioSpanisch
        '
        Me.RadioSpanisch.AutoSize = True
        Me.RadioSpanisch.Location = New System.Drawing.Point(146, 258)
        Me.RadioSpanisch.Name = "RadioSpanisch"
        Me.RadioSpanisch.Size = New System.Drawing.Size(169, 20)
        Me.RadioSpanisch.TabIndex = 9
        Me.RadioSpanisch.Text = "Spanisch, Cuba, Mexico"
        Me.RadioSpanisch.UseVisualStyleBackColor = True
        '
        'RadioItaliano
        '
        Me.RadioItaliano.AutoSize = True
        Me.RadioItaliano.Location = New System.Drawing.Point(146, 232)
        Me.RadioItaliano.Name = "RadioItaliano"
        Me.RadioItaliano.Size = New System.Drawing.Size(85, 20)
        Me.RadioItaliano.TabIndex = 8
        Me.RadioItaliano.Text = "Italienisch"
        Me.RadioItaliano.UseVisualStyleBackColor = True
        '
        'RadioFranzoesisch
        '
        Me.RadioFranzoesisch.AutoSize = True
        Me.RadioFranzoesisch.Location = New System.Drawing.Point(146, 206)
        Me.RadioFranzoesisch.Name = "RadioFranzoesisch"
        Me.RadioFranzoesisch.Size = New System.Drawing.Size(98, 20)
        Me.RadioFranzoesisch.TabIndex = 7
        Me.RadioFranzoesisch.Text = "Französisch"
        Me.RadioFranzoesisch.UseVisualStyleBackColor = True
        '
        'RadioEnglisch
        '
        Me.RadioEnglisch.AutoSize = True
        Me.RadioEnglisch.Checked = True
        Me.RadioEnglisch.Location = New System.Drawing.Point(146, 180)
        Me.RadioEnglisch.Name = "RadioEnglisch"
        Me.RadioEnglisch.Size = New System.Drawing.Size(77, 20)
        Me.RadioEnglisch.TabIndex = 6
        Me.RadioEnglisch.TabStop = True
        Me.RadioEnglisch.Text = "Englisch"
        Me.RadioEnglisch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sprache auswählen:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Toernbezeichnung", True))
        Me.TextBox1.Location = New System.Drawing.Point(178, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Törn auswählen"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(591, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Crewliste drucken"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bsTemp
        '
        Me.bsTemp.DataMember = "Temp"
        Me.bsTemp.DataSource = Me.dsToernverwaltung
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
        'bsTC
        '
        Me.bsTC.DataMember = "TC"
        Me.bsTC.DataSource = Me.dsToernverwaltung
        '
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
        '
        'taTemp
        '
        Me.taTemp.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(435, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Freischaltung ist nicht erfolgreich - Funktion ist eingeschränkt! "
        Me.Label2.Visible = False
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(533, 51)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(188, 20)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Skipperunterschrift drucken"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Crewliste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 543)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Crewliste"
        Me.Text = "Crewliste"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RevierNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents bsTemp As System.Windows.Forms.BindingSource
    Friend WithEvents taTemp As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TempTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioTürkisch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioGriechisch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAdria As System.Windows.Forms.RadioButton
    Friend WithEvents Radioschwedisch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSpanisch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioItaliano As System.Windows.Forms.RadioButton
    Friend WithEvents RadioFranzoesisch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioEnglisch As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bsToernKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taToernKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter
    Friend WithEvents Toernbezeichnung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ausgangsmarina As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bootsname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Route As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Revier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioDeutsch As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
