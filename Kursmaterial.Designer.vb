<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kursmaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kursmaterial))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.bsKursmaterial = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MatLoe = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListenpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EinkaufspreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LieferantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taKursmaterial = New WindowsApplication1.dsAusbildungTableAdapters.KursmaterialTableAdapter()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6Kalender = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button5Zurueck = New System.Windows.Forms.Button()
        Me.Button7Speichern = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.bsKursmaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6Kalender.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Listenpreis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Einkaufspreis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lieferant"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.CausesValidation = False
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKursmaterial, "Datum", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(464, 64)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(90, 22)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'bsKursmaterial
        '
        Me.bsKursmaterial.DataMember = "Kursmaterial"
        Me.bsKursmaterial.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(378, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Datum"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKursmaterial, "Material", True))
        Me.TextBox1.Location = New System.Drawing.Point(160, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(305, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKursmaterial, "Lieferant", True))
        Me.TextBox4.Location = New System.Drawing.Point(160, 160)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(159, 22)
        Me.TextBox4.TabIndex = 5
        '
        'MatLoe
        '
        Me.MatLoe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatLoe.Location = New System.Drawing.Point(464, 347)
        Me.MatLoe.Name = "MatLoe"
        Me.MatLoe.Size = New System.Drawing.Size(113, 48)
        Me.MatLoe.TabIndex = 10
        Me.MatLoe.Text = "Speichern"
        Me.MatLoe.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(312, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 48)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Formular leeren"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(176, 347)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 48)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Preisliste"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialDataGridViewTextBoxColumn, Me.ListenpreisDataGridViewTextBoxColumn, Me.EinkaufspreisDataGridViewTextBoxColumn, Me.LieferantDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsKursmaterial
        Me.DataGridView1.Location = New System.Drawing.Point(42, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(535, 133)
        Me.DataGridView1.TabIndex = 13
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "Material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        '
        'ListenpreisDataGridViewTextBoxColumn
        '
        Me.ListenpreisDataGridViewTextBoxColumn.DataPropertyName = "Listenpreis"
        Me.ListenpreisDataGridViewTextBoxColumn.HeaderText = "Listenpreis"
        Me.ListenpreisDataGridViewTextBoxColumn.Name = "ListenpreisDataGridViewTextBoxColumn"
        '
        'EinkaufspreisDataGridViewTextBoxColumn
        '
        Me.EinkaufspreisDataGridViewTextBoxColumn.DataPropertyName = "Einkaufspreis"
        Me.EinkaufspreisDataGridViewTextBoxColumn.HeaderText = "Einkaufspreis"
        Me.EinkaufspreisDataGridViewTextBoxColumn.Name = "EinkaufspreisDataGridViewTextBoxColumn"
        '
        'LieferantDataGridViewTextBoxColumn
        '
        Me.LieferantDataGridViewTextBoxColumn.DataPropertyName = "Lieferant"
        Me.LieferantDataGridViewTextBoxColumn.HeaderText = "Lieferant"
        Me.LieferantDataGridViewTextBoxColumn.Name = "LieferantDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'taKursmaterial
        '
        Me.taKursmaterial.ClearBeforeFill = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKursmaterial, "Bemerkung", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(42, 236)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(534, 104)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bemerkung"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(105, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKursmaterial, "Listenpreis", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(160, 64)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(159, 22)
        Me.MaskedTextBox2.TabIndex = 2
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKursmaterial, "Einkaufspreis", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(160, 111)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(159, 22)
        Me.MaskedTextBox3.TabIndex = 4
        Me.MaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(791, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 326)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Druckauswahl"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(139, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 38)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Drucken"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(35, 229)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(96, 20)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Bemerkung"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(35, 183)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(134, 20)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Datum Listenpreis"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(35, 139)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(78, 20)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Lieferant"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(35, 93)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(108, 20)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Einkaufspreis"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(35, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 20)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Listenpreis"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(427, 57)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 20
        Me.PictureBox10.TabStop = False
        '
        'GroupBox6Kalender
        '
        Me.GroupBox6Kalender.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox6Kalender.Controls.Add(Me.Button5Zurueck)
        Me.GroupBox6Kalender.Controls.Add(Me.Button7Speichern)
        Me.GroupBox6Kalender.Location = New System.Drawing.Point(1049, 87)
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
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(42, 347)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 48)
        Me.Button5.TabIndex = 89
        Me.Button5.Text = "Material löschen"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Kursmaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 405)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox6Kalender)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MatLoe)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kursmaterial"
        Me.Text = "Kursmaterial"
        CType(Me.bsKursmaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6Kalender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents MatLoe As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsKursmaterial As System.Windows.Forms.BindingSource
    Friend WithEvents taKursmaterial As WindowsApplication1.dsAusbildungTableAdapters.KursmaterialTableAdapter
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListenpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EinkaufspreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LieferantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6Kalender As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button5Zurueck As System.Windows.Forms.Button
    Friend WithEvents Button7Speichern As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
