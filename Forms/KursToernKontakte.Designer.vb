<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KursToernKontakte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KursToernKontakte))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NaKoButton = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.bsKontakte = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.KontakteGruppe = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyNr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kontaktart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.SpeichernButton = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LöschenButton = New System.Windows.Forms.Button()
        Me.DruckenButton = New System.Windows.Forms.Button()
        Me.LeerFButton = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BemerkungGruppe = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.AdressenGruppe = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.VZnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnredeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlterersterToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodeGruppe = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.taKontakte = New WindowsApplication1.dsAusbildungTableAdapters.KontakteTableAdapter()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.bsKontakte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KontakteGruppe.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BemerkungGruppe.SuspendLayout()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdressenGruppe.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeriodeGruppe.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NaKoButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 173)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kontaktdaten"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 50
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(208, 93)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(168, 21)
        Me.MaskedTextBox4.TabIndex = 49
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(206, 40)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(289, 21)
        Me.TextBox9.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = " label3"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(203, 120)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(162, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(709, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 114)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kontaktart"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(126, 74)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(60, 19)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "e-mail"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(17, 70)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(76, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "schriftlich"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(126, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "personlich"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(84, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "telefonisch"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Datum/Uhrzeit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kontakt Name"
        '
        'NaKoButton
        '
        Me.NaKoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NaKoButton.Location = New System.Drawing.Point(522, 29)
        Me.NaKoButton.Name = "NaKoButton"
        Me.NaKoButton.Size = New System.Drawing.Size(140, 40)
        Me.NaKoButton.TabIndex = 47
        Me.NaKoButton.Text = "Name - neuer Kontakt"
        Me.NaKoButton.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "Datum", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(1021, 230)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(240, 20)
        Me.MaskedTextBox1.TabIndex = 2
        '
        'bsKontakte
        '
        Me.bsKontakte.DataMember = "Kontakte"
        Me.bsKontakte.DataSource = Me.DsAusbildung
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "VZName", True))
        Me.TextBox1.Location = New System.Drawing.Point(1021, 195)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 0
        '
        'KontakteGruppe
        '
        Me.KontakteGruppe.Controls.Add(Me.DataGridView1)
        Me.KontakteGruppe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KontakteGruppe.Location = New System.Drawing.Point(12, 175)
        Me.KontakteGruppe.Name = "KontakteGruppe"
        Me.KontakteGruppe.Size = New System.Drawing.Size(920, 362)
        Me.KontakteGruppe.TabIndex = 1
        Me.KontakteGruppe.TabStop = False
        Me.KontakteGruppe.Text = "Auswahl Kontakte"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZNameDataGridViewTextBoxColumn, Me.HandyNr, Me.EmailAdresseDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.Kontaktart, Me.BemerkungDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsKontakte
        Me.DataGridView1.Location = New System.Drawing.Point(12, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(902, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'VZNameDataGridViewTextBoxColumn
        '
        Me.VZNameDataGridViewTextBoxColumn.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.Name = "VZNameDataGridViewTextBoxColumn"
        '
        'HandyNr
        '
        Me.HandyNr.DataPropertyName = "HandyNr"
        Me.HandyNr.HeaderText = "HandyNr"
        Me.HandyNr.Name = "HandyNr"
        '
        'EmailAdresseDataGridViewTextBoxColumn
        '
        Me.EmailAdresseDataGridViewTextBoxColumn.DataPropertyName = "emailAdresse"
        Me.EmailAdresseDataGridViewTextBoxColumn.HeaderText = "emailAdresse"
        Me.EmailAdresseDataGridViewTextBoxColumn.Name = "EmailAdresseDataGridViewTextBoxColumn"
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        '
        'Kontaktart
        '
        Me.Kontaktart.DataPropertyName = "Kontaktart"
        Me.Kontaktart.HeaderText = "Kontaktart"
        Me.Kontaktart.Name = "Kontaktart"
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
        'taCrewAdressen
        '
        Me.taCrewAdressen.ClearBeforeFill = True
        '
        'SpeichernButton
        '
        Me.SpeichernButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeichernButton.Location = New System.Drawing.Point(792, 565)
        Me.SpeichernButton.Name = "SpeichernButton"
        Me.SpeichernButton.Size = New System.Drawing.Size(140, 40)
        Me.SpeichernButton.TabIndex = 3
        Me.SpeichernButton.Text = "Speichern"
        Me.SpeichernButton.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 549)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 13)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Anzahl"
        '
        'LöschenButton
        '
        Me.LöschenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LöschenButton.Location = New System.Drawing.Point(18, 565)
        Me.LöschenButton.Name = "LöschenButton"
        Me.LöschenButton.Size = New System.Drawing.Size(140, 40)
        Me.LöschenButton.TabIndex = 48
        Me.LöschenButton.Text = "Kontakt löschen"
        Me.LöschenButton.UseVisualStyleBackColor = True
        '
        'DruckenButton
        '
        Me.DruckenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DruckenButton.Location = New System.Drawing.Point(267, 565)
        Me.DruckenButton.Name = "DruckenButton"
        Me.DruckenButton.Size = New System.Drawing.Size(140, 40)
        Me.DruckenButton.TabIndex = 49
        Me.DruckenButton.Text = "Kontakte drucken"
        Me.DruckenButton.UseVisualStyleBackColor = True
        '
        'LeerFButton
        '
        Me.LeerFButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeerFButton.Location = New System.Drawing.Point(510, 565)
        Me.LeerFButton.Name = "LeerFButton"
        Me.LeerFButton.Size = New System.Drawing.Size(140, 40)
        Me.LeerFButton.TabIndex = 50
        Me.LeerFButton.Text = "Formular leeren"
        Me.LeerFButton.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "emailAdresse", True))
        Me.TextBox2.Location = New System.Drawing.Point(1021, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 51
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "HandyNr", True))
        Me.TextBox3.Location = New System.Drawing.Point(1021, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 20)
        Me.TextBox3.TabIndex = 52
        '
        'BemerkungGruppe
        '
        Me.BemerkungGruppe.Controls.Add(Me.RichTextBox1)
        Me.BemerkungGruppe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BemerkungGruppe.Location = New System.Drawing.Point(1364, 501)
        Me.BemerkungGruppe.Name = "BemerkungGruppe"
        Me.BemerkungGruppe.Size = New System.Drawing.Size(240, 141)
        Me.BemerkungGruppe.TabIndex = 53
        Me.BemerkungGruppe.TabStop = False
        Me.BemerkungGruppe.Text = "Bemerkung"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 20)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(170, 111)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "VZname", True))
        Me.TextBox4.Location = New System.Drawing.Point(1024, 65)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(234, 20)
        Me.TextBox4.TabIndex = 54
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
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "Handy", True))
        Me.TextBox5.Location = New System.Drawing.Point(1024, 117)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(240, 20)
        Me.TextBox5.TabIndex = 56
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCrewAdressen, "email", True))
        Me.TextBox6.Location = New System.Drawing.Point(1024, 91)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(240, 20)
        Me.TextBox6.TabIndex = 55
        '
        'AdressenGruppe
        '
        Me.AdressenGruppe.BackColor = System.Drawing.Color.Bisque
        Me.AdressenGruppe.Controls.Add(Me.DataGridView2)
        Me.AdressenGruppe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdressenGruppe.Location = New System.Drawing.Point(1048, 501)
        Me.AdressenGruppe.Name = "AdressenGruppe"
        Me.AdressenGruppe.Size = New System.Drawing.Size(286, 211)
        Me.AdressenGruppe.TabIndex = 57
        Me.AdressenGruppe.TabStop = False
        Me.AdressenGruppe.Text = "Vorname Name"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZnameDataGridViewTextBoxColumn1, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ZunameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.AnredeDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn, Me.ToernnrDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.AlterersterToernDataGridViewTextBoxColumn, Me.ReisepassNrDataGridViewTextBoxColumn, Me.GebDatumDataGridViewTextBoxColumn, Me.GebOrtDataGridViewTextBoxColumn, Me.FunkDataGridViewTextBoxColumn, Me.SegelscheinDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.NationalitaetDataGridViewTextBoxColumn, Me.ReihenfolgeDataGridViewTextBoxColumn, Me.SegelscheinDatumDataGridViewTextBoxColumn, Me.SegelscheinVerbandDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.ClubmitgliedDataGridViewCheckBoxColumn, Me.FB1DataGridViewCheckBoxColumn, Me.FB2DataGridViewCheckBoxColumn, Me.FB3DataGridViewCheckBoxColumn, Me.FB4DataGridViewCheckBoxColumn, Me.AScheinDataGridViewCheckBoxColumn, Me.MotorbootDataGridViewCheckBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.bsCrewAdressen
        Me.DataGridView2.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 3
        '
        'VZnameDataGridViewTextBoxColumn1
        '
        Me.VZnameDataGridViewTextBoxColumn1.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.Name = "VZnameDataGridViewTextBoxColumn1"
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
        'ToernnrDataGridViewTextBoxColumn
        '
        Me.ToernnrDataGridViewTextBoxColumn.DataPropertyName = "toernnr"
        Me.ToernnrDataGridViewTextBoxColumn.HeaderText = "toernnr"
        Me.ToernnrDataGridViewTextBoxColumn.Name = "ToernnrDataGridViewTextBoxColumn"
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        '
        'AlterersterToernDataGridViewTextBoxColumn
        '
        Me.AlterersterToernDataGridViewTextBoxColumn.DataPropertyName = "AlterersterToern"
        Me.AlterersterToernDataGridViewTextBoxColumn.HeaderText = "AlterersterToern"
        Me.AlterersterToernDataGridViewTextBoxColumn.Name = "AlterersterToernDataGridViewTextBoxColumn"
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
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'PeriodeGruppe
        '
        Me.PeriodeGruppe.BackColor = System.Drawing.Color.LightBlue
        Me.PeriodeGruppe.Controls.Add(Me.MaskedTextBox3)
        Me.PeriodeGruppe.Controls.Add(Me.MaskedTextBox2)
        Me.PeriodeGruppe.Controls.Add(Me.Button2)
        Me.PeriodeGruppe.Controls.Add(Me.Button1)
        Me.PeriodeGruppe.Controls.Add(Me.Label5)
        Me.PeriodeGruppe.Controls.Add(Me.Label4)
        Me.PeriodeGruppe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodeGruppe.Location = New System.Drawing.Point(1048, 333)
        Me.PeriodeGruppe.Name = "PeriodeGruppe"
        Me.PeriodeGruppe.Size = New System.Drawing.Size(398, 151)
        Me.PeriodeGruppe.TabIndex = 58
        Me.PeriodeGruppe.TabStop = False
        Me.PeriodeGruppe.Text = "Periode"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(238, 41)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox3.TabIndex = 53
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.CausesValidation = False
        Me.MaskedTextBox2.Location = New System.Drawing.Point(78, 41)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox2.TabIndex = 52
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(49, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 40)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Abbrechen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(238, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Drucken"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "bis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "von"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "DatumT", True))
        Me.TextBox7.Location = New System.Drawing.Point(1028, 151)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(235, 20)
        Me.TextBox7.TabIndex = 59
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "Kontaktart", True))
        Me.TextBox8.Location = New System.Drawing.Point(1286, 12)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 60
        '
        'taKontakte
        '
        Me.taKontakte.ClearBeforeFill = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsKontakte, "Bemerkung", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(1286, 46)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox2.TabIndex = 61
        Me.RichTextBox2.Text = ""
        '
        'KursToernKontakte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 622)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.PeriodeGruppe)
        Me.Controls.Add(Me.AdressenGruppe)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BemerkungGruppe)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LeerFButton)
        Me.Controls.Add(Me.DruckenButton)
        Me.Controls.Add(Me.LöschenButton)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.SpeichernButton)
        Me.Controls.Add(Me.KontakteGruppe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KursToernKontakte"
        Me.Text = "Kurs und Törn Kontakte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.bsKontakte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KontakteGruppe.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BemerkungGruppe.ResumeLayout(False)
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdressenGruppe.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeriodeGruppe.ResumeLayout(False)
        Me.PeriodeGruppe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents KontakteGruppe As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents bsKontakte As System.Windows.Forms.BindingSource
    Friend WithEvents taKontakte As WindowsApplication1.dsAusbildungTableAdapters.KontakteTableAdapter
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents SpeichernButton As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents NaKoButton As System.Windows.Forms.Button
    Friend WithEvents LöschenButton As System.Windows.Forms.Button
    Friend WithEvents DruckenButton As System.Windows.Forms.Button
    Friend WithEvents LeerFButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents BemerkungGruppe As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents AdressenGruppe As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents VZnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZunameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnredeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlterersterToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodeGruppe As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents AnrufDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PersonlichDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SchriftlichDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EmailDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyNr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAdresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kontaktart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
