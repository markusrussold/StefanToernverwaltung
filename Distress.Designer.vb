<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Distress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Distress))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Toern = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToernbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmNachweisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WachfuehrerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NavigatorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RudergaengerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bsTC = New System.Windows.Forms.BindingSource(Me.components)
        Me.taTC = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toern.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Toern)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 388)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Törn Auswahl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(137, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Schiffsnummer fehlt"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(137, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MMSI Nr. fehlt"
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Drucken"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Törn"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Toern
        '
        Me.Toern.Controls.Add(Me.DataGridView1)
        Me.Toern.Location = New System.Drawing.Point(7, 122)
        Me.Toern.Name = "Toern"
        Me.Toern.Size = New System.Drawing.Size(493, 197)
        Me.Toern.TabIndex = 0
        Me.Toern.TabStop = False
        Me.Toern.Text = "Törn"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsToernname
        Me.DataGridView1.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(481, 171)
        Me.DataGridView1.TabIndex = 0
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        '
        'DatumVonDataGridViewTextBoxColumn
        '
        Me.DatumVonDataGridViewTextBoxColumn.DataPropertyName = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.HeaderText = "DatumVon"
        Me.DatumVonDataGridViewTextBoxColumn.Name = "DatumVonDataGridViewTextBoxColumn"
        '
        'DatumBisDataGridViewTextBoxColumn
        '
        Me.DatumBisDataGridViewTextBoxColumn.DataPropertyName = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.HeaderText = "DatumBis"
        Me.DatumBisDataGridViewTextBoxColumn.Name = "DatumBisDataGridViewTextBoxColumn"
        '
        'BootsnameDataGridViewTextBoxColumn
        '
        Me.BootsnameDataGridViewTextBoxColumn.DataPropertyName = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.HeaderText = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.Name = "BootsnameDataGridViewTextBoxColumn"
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
        'bsBoot
        '
        Me.bsBoot.DataMember = "Boot"
        Me.bsBoot.DataSource = Me.dsToernverwaltung
        '
        'taBoot
        '
        Me.taBoot.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Toernbezeichnung", True))
        Me.TextBox2.Location = New System.Drawing.Point(734, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 1
        '
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ToernDataGridViewTextBoxColumn, Me.VZnameDataGridViewTextBoxColumn, Me.SmNachweisDataGridViewCheckBoxColumn, Me.WachfuehrerDataGridViewCheckBoxColumn, Me.NavigatorDataGridViewCheckBoxColumn, Me.RudergaengerDataGridViewCheckBoxColumn})
        Me.DataGridView2.DataSource = Me.bsTC
        Me.DataGridView2.Location = New System.Drawing.Point(785, 134)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 2
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
        'SmNachweisDataGridViewCheckBoxColumn
        '
        Me.SmNachweisDataGridViewCheckBoxColumn.DataPropertyName = "smNachweis"
        Me.SmNachweisDataGridViewCheckBoxColumn.HeaderText = "smNachweis"
        Me.SmNachweisDataGridViewCheckBoxColumn.Name = "SmNachweisDataGridViewCheckBoxColumn"
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
        'taTC
        '
        Me.taTC.ClearBeforeFill = True
        '
        'Distress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 412)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Distress"
        Me.Text = "Distressformular"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toern.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Toern As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootsnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents bsTC As System.Windows.Forms.BindingSource
    Friend WithEvents taTC As WindowsApplication1.ToernverwaltungDataSetTableAdapters.TCTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmNachweisDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WachfuehrerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NavigatorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RudergaengerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
