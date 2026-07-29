<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchadenY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchadenY))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbschnell = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioNeu = New System.Windows.Forms.RadioButton()
        Me.gbSchadenmeldung = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.bsSchaden = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsVersicherung = New WindowsApplication1.VersicherungDataSet()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.gbSchilderung = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbVersicherung = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.bsToernname = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.bsVersicherter = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ButtonSpeichern = New System.Windows.Forms.Button()
        Me.gbBemerkung = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.gbKaution = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.gbHaftschaden = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cbSchadensschilderung = New System.Windows.Forms.CheckBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.gbUnfallbericht = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.gbRuecktritt = New System.Windows.Forms.GroupBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.dgvToern = New System.Windows.Forms.DataGridView()
        Me.ToernbezeichnungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumVonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumBisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusgangsmarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndeMarinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.taToernname = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter()
        Me.dgvSchaden = New System.Windows.Forms.DataGridView()
        Me.PolizzeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TörnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersicherungsartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchadensbeschreibungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchadensnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchadensbetragDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BearbeiterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeamailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeaTelefonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchadensortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelegKautionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelegRepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelegDiebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HafenkapiteanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersicherungCharterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersicherungGegnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharterMeldungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkizzeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegelfuehrungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WindrichtungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorAnAusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursEigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursGegnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZeugenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArztbeschDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlugstornoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharterStornoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.GroupBoxV = New System.Windows.Forms.GroupBox()
        Me.ListBoxH = New System.Windows.Forms.ListBox()
        Me.BAbruch = New System.Windows.Forms.Button()
        Me.BZurueck = New System.Windows.Forms.Button()
        Me.BLaden = New System.Windows.Forms.Button()
        Me.TextBoxV = New System.Windows.Forms.TextBox()
        Me.ListBoxV = New System.Windows.Forms.ListBox()
        Me.taSchaden = New WindowsApplication1.VersicherungDataSetTableAdapters.SchadenTableAdapter()
        Me.taVersicherter = New WindowsApplication1.VersicherungDataSetTableAdapters.VersicherterTableAdapter()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.gbFenster = New System.Windows.Forms.GroupBox()
        Me.gbtoern = New System.Windows.Forms.GroupBox()
        Me.gbNeu = New System.Windows.Forms.GroupBox()
        Me.dgvversi = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersicherterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abschlussdatum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GueltigBis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.gbschnell.SuspendLayout()
        Me.gbSchadenmeldung.SuspendLayout()
        CType(Me.bsSchaden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSchilderung.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVersicherung.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVersicherter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBemerkung.SuspendLayout()
        Me.gbKaution.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHaftschaden.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUnfallbericht.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRuecktritt.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvToern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSchaden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxV.SuspendLayout()
        Me.gbFenster.SuspendLayout()
        Me.gbtoern.SuspendLayout()
        Me.gbNeu.SuspendLayout()
        CType(Me.dgvversi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1.     Bitte melde Haftpﬂicht- und Kaskoschadenfälle unverzüglich beim Vercharter" & _
    "er an. "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(455, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "WICHTIG: In Kroatien sind alle Haftpﬂichtschäden beim Hafenkapitän anzuzeigen. "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(467, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2.     Bitte melde den Schadenfall per Mail, Fax oder Telefon bei Deinem Versiche" & _
    "rer."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "3.     Ein Diebstahl ist immer polizeilich zu melden."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(502, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "4.     Sorge für Minderung des entstandenen Schadens und Abwen­dung weiterer Schä" & _
    "den."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(318, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Zur Schadenbearbeitung reiche folgende Unterlagen ein:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kopie des Führerscheins"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kopie des Chartervertrages"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kopie der Crewliste"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(369, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Detaillierte Schadensschilderung (was, wann, wie, wo und warum)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(153, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(234, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "von allen Crewmitgliedern unterschrieben"
        '
        'gbschnell
        '
        Me.gbschnell.Controls.Add(Me.RadioButton4)
        Me.gbschnell.Controls.Add(Me.RadioButton5)
        Me.gbschnell.Controls.Add(Me.RadioNeu)
        Me.gbschnell.Controls.Add(Me.Label5)
        Me.gbschnell.Controls.Add(Me.Label11)
        Me.gbschnell.Controls.Add(Me.Label1)
        Me.gbschnell.Controls.Add(Me.Label10)
        Me.gbschnell.Controls.Add(Me.Label2)
        Me.gbschnell.Controls.Add(Me.Label9)
        Me.gbschnell.Controls.Add(Me.Label3)
        Me.gbschnell.Controls.Add(Me.Label8)
        Me.gbschnell.Controls.Add(Me.Label4)
        Me.gbschnell.Controls.Add(Me.Label7)
        Me.gbschnell.Controls.Add(Me.Label6)
        Me.gbschnell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbschnell.Location = New System.Drawing.Point(3019, 21)
        Me.gbschnell.Name = "gbschnell"
        Me.gbschnell.Size = New System.Drawing.Size(570, 279)
        Me.gbschnell.TabIndex = 11
        Me.gbschnell.TabStop = False
        Me.gbschnell.Text = "Damit der Schaden schnell bearbeitet wird"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(404, 201)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(152, 19)
        Me.RadioButton5.TabIndex = 12
        Me.RadioButton5.Text = "bestehende bearbeiten"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioNeu
        '
        Me.RadioNeu.AutoSize = True
        Me.RadioNeu.Location = New System.Drawing.Point(404, 176)
        Me.RadioNeu.Name = "RadioNeu"
        Me.RadioNeu.Size = New System.Drawing.Size(160, 19)
        Me.RadioNeu.TabIndex = 11
        Me.RadioNeu.Text = "neue Schadensmeldung"
        Me.RadioNeu.UseVisualStyleBackColor = True
        '
        'gbSchadenmeldung
        '
        Me.gbSchadenmeldung.Controls.Add(Me.TextBox6)
        Me.gbSchadenmeldung.Controls.Add(Me.TextBox3)
        Me.gbSchadenmeldung.Controls.Add(Me.TextBox2)
        Me.gbSchadenmeldung.Controls.Add(Me.Label17)
        Me.gbSchadenmeldung.Controls.Add(Me.PictureBox1)
        Me.gbSchadenmeldung.Controls.Add(Me.RadioButton3)
        Me.gbSchadenmeldung.Controls.Add(Me.RadioButton2)
        Me.gbSchadenmeldung.Controls.Add(Me.RadioButton1)
        Me.gbSchadenmeldung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSchadenmeldung.Location = New System.Drawing.Point(12, 558)
        Me.gbSchadenmeldung.Name = "gbSchadenmeldung"
        Me.gbSchadenmeldung.Size = New System.Drawing.Size(570, 150)
        Me.gbSchadenmeldung.TabIndex = 12
        Me.gbSchadenmeldung.TabStop = False
        Me.gbSchadenmeldung.Text = "Schadenmeldung"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "foto3", True))
        Me.TextBox6.Location = New System.Drawing.Point(188, 122)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(211, 21)
        Me.TextBox6.TabIndex = 7
        '
        'bsSchaden
        '
        Me.bsSchaden.DataMember = "Schaden"
        Me.bsSchaden.DataSource = Me.dsVersicherung
        '
        'dsVersicherung
        '
        Me.dsVersicherung.DataSetName = "VersicherungDataSet"
        Me.dsVersicherung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Foto2", True))
        Me.TextBox3.Location = New System.Drawing.Point(188, 81)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(211, 21)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Foto1", True))
        Me.TextBox2.Location = New System.Drawing.Point(188, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 21)
        Me.TextBox2.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(185, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 15)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Fotos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(405, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(19, 123)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(113, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Charter-Rücktritt"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(19, 81)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kautionsschaden"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 43)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(126, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Haftpflichtschaden"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'gbSchilderung
        '
        Me.gbSchilderung.Controls.Add(Me.PictureBox3)
        Me.gbSchilderung.Controls.Add(Me.MaskedTextBox2)
        Me.gbSchilderung.Controls.Add(Me.MaskedTextBox1)
        Me.gbSchilderung.Controls.Add(Me.RichTextBox1)
        Me.gbSchilderung.Controls.Add(Me.TextBox5)
        Me.gbSchilderung.Controls.Add(Me.TextBox4)
        Me.gbSchilderung.Controls.Add(Me.TextBox1)
        Me.gbSchilderung.Controls.Add(Me.Label16)
        Me.gbSchilderung.Controls.Add(Me.Label15)
        Me.gbSchilderung.Controls.Add(Me.Label14)
        Me.gbSchilderung.Controls.Add(Me.Label13)
        Me.gbSchilderung.Controls.Add(Me.Label12)
        Me.gbSchilderung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSchilderung.Location = New System.Drawing.Point(635, 392)
        Me.gbSchilderung.Name = "gbSchilderung"
        Me.gbSchilderung.Size = New System.Drawing.Size(570, 275)
        Me.gbSchilderung.TabIndex = 14
        Me.gbSchilderung.TabStop = False
        Me.gbSchilderung.Text = "Schadensschilderung"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(36, 218)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Uhrzeit", True))
        Me.MaskedTextBox2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.MaskedTextBox2.Location = New System.Drawing.Point(233, 55)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(42, 21)
        Me.MaskedTextBox2.TabIndex = 12
        Me.MaskedTextBox2.Text = "14:25"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Datum", True))
        Me.MaskedTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.MaskedTextBox1.Location = New System.Drawing.Point(130, 54)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(81, 21)
        Me.MaskedTextBox1.TabIndex = 11
        Me.MaskedTextBox1.Text = "31.12.2001"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Schadensbeschreibung", True))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.RichTextBox1.Location = New System.Drawing.Point(128, 163)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(415, 100)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Schadensort", True))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox5.Location = New System.Drawing.Point(128, 128)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(414, 21)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "Kroatien/15 sm südlich von Vis"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Wie", True))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox4.Location = New System.Drawing.Point(129, 89)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(414, 21)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "Unterhalb des Grossbaumes"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Was", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.Location = New System.Drawing.Point(128, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(414, 21)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Mast gebrochen"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Warum"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Wo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Wie"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Datum, Uhrzeit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Was "
        '
        'gbVersicherung
        '
        Me.gbVersicherung.Controls.Add(Me.GroupBox6)
        Me.gbVersicherung.Controls.Add(Me.GroupBox5)
        Me.gbVersicherung.Location = New System.Drawing.Point(12, 13)
        Me.gbVersicherung.Name = "gbVersicherung"
        Me.gbVersicherung.Size = New System.Drawing.Size(570, 288)
        Me.gbVersicherung.TabIndex = 15
        Me.gbVersicherung.TabStop = False
        Me.gbVersicherung.Text = "Versicherungsdaten"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox12)
        Me.GroupBox6.Controls.Add(Me.TextBox11)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.TextBox10)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.TextBox8)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(13, 201)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(544, 83)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Versicherung"
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Bea-Telefon", True))
        Me.TextBox12.Location = New System.Drawing.Point(104, 53)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(120, 21)
        Me.TextBox12.TabIndex = 7
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Bea-mail", True))
        Me.TextBox11.Location = New System.Drawing.Point(325, 53)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(212, 21)
        Me.TextBox11.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(25, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 15)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Telefon"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(255, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 15)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "e-mail"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Bearbeiter", True))
        Me.TextBox10.Location = New System.Drawing.Point(325, 24)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(213, 21)
        Me.TextBox10.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(255, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 15)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Bearbeiter"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Schadensnummer", True))
        Me.TextBox8.Location = New System.Drawing.Point(104, 24)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(120, 21)
        Me.TextBox8.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Schadensnr.: "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox9)
        Me.GroupBox5.Controls.Add(Me.TextBox35)
        Me.GroupBox5.Controls.Add(Me.Label50)
        Me.GroupBox5.Controls.Add(Me.TextBox34)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.TextBox13)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.TextBox9)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(544, 180)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Versicherungsnehmer"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(71, 24)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 14
        Me.PictureBox9.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(71, 81)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernname, "Toernbezeichnung", True))
        Me.TextBox13.Location = New System.Drawing.Point(104, 91)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(188, 21)
        Me.TextBox13.TabIndex = 8
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
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 90)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(32, 15)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Törn"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(365, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 15)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "von-bis"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(298, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 15)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Gültigkeit:"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVersicherter, "Polizze", True))
        Me.TextBox7.Location = New System.Drawing.Point(104, 27)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(188, 21)
        Me.TextBox7.TabIndex = 2
        '
        'bsVersicherter
        '
        Me.bsVersicherter.DataMember = "Versicherter"
        Me.bsVersicherter.DataSource = Me.dsVersicherung
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVersicherter, "VersicherterName", True))
        Me.Label19.Location = New System.Drawing.Point(68, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 15)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 15)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Polizze Nr."
        '
        'ButtonSpeichern
        '
        Me.ButtonSpeichern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpeichern.Location = New System.Drawing.Point(449, 460)
        Me.ButtonSpeichern.Name = "ButtonSpeichern"
        Me.ButtonSpeichern.Size = New System.Drawing.Size(133, 48)
        Me.ButtonSpeichern.TabIndex = 16
        Me.ButtonSpeichern.Text = "Speichern"
        Me.ButtonSpeichern.UseVisualStyleBackColor = True
        '
        'gbBemerkung
        '
        Me.gbBemerkung.Controls.Add(Me.RichTextBox2)
        Me.gbBemerkung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBemerkung.Location = New System.Drawing.Point(12, 304)
        Me.gbBemerkung.Name = "gbBemerkung"
        Me.gbBemerkung.Size = New System.Drawing.Size(570, 150)
        Me.gbBemerkung.TabIndex = 17
        Me.gbBemerkung.TabStop = False
        Me.gbBemerkung.Text = "Bemerkung"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Bemerkung", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(11, 20)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(545, 120)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = ""
        '
        'gbKaution
        '
        Me.gbKaution.Controls.Add(Me.PictureBox6)
        Me.gbKaution.Controls.Add(Me.TextBox16)
        Me.gbKaution.Controls.Add(Me.TextBox15)
        Me.gbKaution.Controls.Add(Me.TextBox14)
        Me.gbKaution.Controls.Add(Me.Label30)
        Me.gbKaution.Controls.Add(Me.Label29)
        Me.gbKaution.Controls.Add(Me.Label28)
        Me.gbKaution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbKaution.Location = New System.Drawing.Point(1263, 601)
        Me.gbKaution.Name = "gbKaution"
        Me.gbKaution.Size = New System.Drawing.Size(570, 275)
        Me.gbKaution.TabIndex = 18
        Me.gbKaution.TabStop = False
        Me.gbKaution.Text = "Kautionsschaden (.pdf Dateien)"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(497, 217)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "BelegDieb", True))
        Me.TextBox16.Location = New System.Drawing.Point(324, 176)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(240, 21)
        Me.TextBox16.TabIndex = 5
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "BelegRep", True))
        Me.TextBox15.Location = New System.Drawing.Point(324, 112)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(240, 21)
        Me.TextBox15.TabIndex = 4
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "BelegKaution", True))
        Me.TextBox14.Location = New System.Drawing.Point(324, 48)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(240, 21)
        Me.TextBox14.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(27, 183)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(242, 15)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Bei Diebstahl – Vorlage der Polizeimeldung"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(27, 112)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(224, 15)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Reparaturrechnung/Kostenvoranschlag "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(27, 51)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(215, 15)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Beleg über den Einbehalt der Kaution "
        '
        'gbHaftschaden
        '
        Me.gbHaftschaden.Controls.Add(Me.PictureBox4)
        Me.gbHaftschaden.Controls.Add(Me.cbSchadensschilderung)
        Me.gbHaftschaden.Controls.Add(Me.TextBox20)
        Me.gbHaftschaden.Controls.Add(Me.TextBox19)
        Me.gbHaftschaden.Controls.Add(Me.TextBox18)
        Me.gbHaftschaden.Controls.Add(Me.TextBox17)
        Me.gbHaftschaden.Controls.Add(Me.CheckBox2)
        Me.gbHaftschaden.Controls.Add(Me.Label35)
        Me.gbHaftschaden.Controls.Add(Me.Label34)
        Me.gbHaftschaden.Controls.Add(Me.Label33)
        Me.gbHaftschaden.Controls.Add(Me.Label32)
        Me.gbHaftschaden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHaftschaden.Location = New System.Drawing.Point(1263, 298)
        Me.gbHaftschaden.Name = "gbHaftschaden"
        Me.gbHaftschaden.Size = New System.Drawing.Size(570, 275)
        Me.gbHaftschaden.TabIndex = 19
        Me.gbHaftschaden.TabStop = False
        Me.gbHaftschaden.Text = "Haftschaden (.pdf Dateien)"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(497, 222)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'cbSchadensschilderung
        '
        Me.cbSchadensschilderung.AutoSize = True
        Me.cbSchadensschilderung.Location = New System.Drawing.Point(20, 201)
        Me.cbSchadensschilderung.Name = "cbSchadensschilderung"
        Me.cbSchadensschilderung.Size = New System.Drawing.Size(145, 19)
        Me.cbSchadensschilderung.TabIndex = 9
        Me.cbSchadensschilderung.Text = "Schadensschilderung"
        Me.cbSchadensschilderung.UseVisualStyleBackColor = True
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "CharterMeldung", True))
        Me.TextBox20.Location = New System.Drawing.Point(327, 148)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(237, 21)
        Me.TextBox20.TabIndex = 8
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "VersicherungGegner", True))
        Me.TextBox19.Location = New System.Drawing.Point(327, 104)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(237, 21)
        Me.TextBox19.TabIndex = 7
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "VersicherungCharter", True))
        Me.TextBox18.Location = New System.Drawing.Point(327, 63)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(237, 21)
        Me.TextBox18.TabIndex = 6
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Hafenkapitean", True))
        Me.TextBox17.Location = New System.Drawing.Point(327, 30)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(237, 21)
        Me.TextBox17.TabIndex = 5
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(20, 245)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(95, 19)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Unfallbericht"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(17, 151)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(308, 15)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "Bestätigung der Schadensmeldung an die Charterfirma"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(17, 104)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(222, 15)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Versicherungsbestätigung des Gegners"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(17, 63)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(222, 15)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Versicherungsbestätigung Deiner Yacht"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(17, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(153, 15)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Bericht des Hafenkapitäns "
        '
        'gbUnfallbericht
        '
        Me.gbUnfallbericht.Controls.Add(Me.PictureBox5)
        Me.gbUnfallbericht.Controls.Add(Me.Label45)
        Me.gbUnfallbericht.Controls.Add(Me.Label44)
        Me.gbUnfallbericht.Controls.Add(Me.Label43)
        Me.gbUnfallbericht.Controls.Add(Me.TextBox27)
        Me.gbUnfallbericht.Controls.Add(Me.TextBox26)
        Me.gbUnfallbericht.Controls.Add(Me.TextBox25)
        Me.gbUnfallbericht.Controls.Add(Me.TextBox24)
        Me.gbUnfallbericht.Controls.Add(Me.TextBox23)
        Me.gbUnfallbericht.Controls.Add(Me.TextBox22)
        Me.gbUnfallbericht.Controls.Add(Me.TextBox21)
        Me.gbUnfallbericht.Controls.Add(Me.Label42)
        Me.gbUnfallbericht.Controls.Add(Me.Label41)
        Me.gbUnfallbericht.Controls.Add(Me.Label40)
        Me.gbUnfallbericht.Controls.Add(Me.Label39)
        Me.gbUnfallbericht.Controls.Add(Me.Label38)
        Me.gbUnfallbericht.Controls.Add(Me.Label37)
        Me.gbUnfallbericht.Controls.Add(Me.Label36)
        Me.gbUnfallbericht.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUnfallbericht.Location = New System.Drawing.Point(1263, 13)
        Me.gbUnfallbericht.Name = "gbUnfallbericht"
        Me.gbUnfallbericht.Size = New System.Drawing.Size(570, 275)
        Me.gbUnfallbericht.TabIndex = 20
        Me.gbUnfallbericht.TabStop = False
        Me.gbUnfallbericht.Text = "Unfallbericht"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(497, 219)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(494, 181)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(12, 15)
        Me.Label45.TabIndex = 16
        Me.Label45.Text = "°"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(208, 181)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(12, 15)
        Me.Label44.TabIndex = 15
        Me.Label44.Text = "°"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(208, 95)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(12, 15)
        Me.Label43.TabIndex = 14
        Me.Label43.Text = "°"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox27
        '
        Me.TextBox27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Zeugen", True))
        Me.TextBox27.Location = New System.Drawing.Point(129, 219)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(280, 21)
        Me.TextBox27.TabIndex = 13
        '
        'TextBox26
        '
        Me.TextBox26.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "KursGegner", True))
        Me.TextBox26.Location = New System.Drawing.Point(415, 178)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(73, 21)
        Me.TextBox26.TabIndex = 12
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox25
        '
        Me.TextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "KursEigen", True))
        Me.TextBox25.Location = New System.Drawing.Point(129, 178)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(73, 21)
        Me.TextBox25.TabIndex = 11
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox24
        '
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "MotorAnAus", True))
        Me.TextBox24.Location = New System.Drawing.Point(129, 137)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(73, 21)
        Me.TextBox24.TabIndex = 10
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Windrichtung", True))
        Me.TextBox23.Location = New System.Drawing.Point(129, 93)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(73, 21)
        Me.TextBox23.TabIndex = 9
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Segelfuehrung", True))
        Me.TextBox22.Location = New System.Drawing.Point(129, 58)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(280, 21)
        Me.TextBox22.TabIndex = 8
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Skizze", True))
        Me.TextBox21.Location = New System.Drawing.Point(129, 26)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(280, 21)
        Me.TextBox21.TabIndex = 7
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(19, 222)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(49, 15)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "Zeugen"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(304, 181)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(105, 15)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "Kurs des Gegners"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(19, 181)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(78, 15)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "Eigener Kurs"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(19, 140)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(79, 15)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Motor an/aus"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(19, 96)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 15)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Windrichtung"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(19, 61)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(81, 15)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "Segelführung"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(19, 29)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(106, 15)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Skizze (.pdf Datei)"
        '
        'gbRuecktritt
        '
        Me.gbRuecktritt.Controls.Add(Me.PictureBox7)
        Me.gbRuecktritt.Controls.Add(Me.TextBox30)
        Me.gbRuecktritt.Controls.Add(Me.TextBox29)
        Me.gbRuecktritt.Controls.Add(Me.TextBox28)
        Me.gbRuecktritt.Controls.Add(Me.Label48)
        Me.gbRuecktritt.Controls.Add(Me.Label47)
        Me.gbRuecktritt.Controls.Add(Me.Label46)
        Me.gbRuecktritt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRuecktritt.Location = New System.Drawing.Point(634, 26)
        Me.gbRuecktritt.Name = "gbRuecktritt"
        Me.gbRuecktritt.Size = New System.Drawing.Size(570, 275)
        Me.gbRuecktritt.TabIndex = 21
        Me.gbRuecktritt.TabStop = False
        Me.gbRuecktritt.Text = "Charter-Rücktritt (.pdf Dateien)"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(511, 220)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 15
        Me.PictureBox7.TabStop = False
        '
        'TextBox30
        '
        Me.TextBox30.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Arztbesch", True))
        Me.TextBox30.Location = New System.Drawing.Point(284, 34)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(280, 21)
        Me.TextBox30.TabIndex = 10
        '
        'TextBox29
        '
        Me.TextBox29.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Flugstorno", True))
        Me.TextBox29.Location = New System.Drawing.Point(284, 105)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(280, 21)
        Me.TextBox29.TabIndex = 9
        '
        'TextBox28
        '
        Me.TextBox28.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "CharterStorno", True))
        Me.TextBox28.Location = New System.Drawing.Point(284, 182)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(280, 21)
        Me.TextBox28.TabIndex = 8
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(32, 165)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(342, 15)
        Me.Label48.TabIndex = 2
        Me.Label48.Text = "Beim Skipperausfall, Stornobescheinigung des Vercharterers "
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(25, 88)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(254, 15)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Ggf. Flugstornobescheinigung bzw. Flugticket"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(25, 40)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(108, 15)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Arztbescheinigung"
        '
        'dgvToern
        '
        Me.dgvToern.AutoGenerateColumns = False
        Me.dgvToern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvToern.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernbezeichnungDataGridViewTextBoxColumn, Me.DatumVonDataGridViewTextBoxColumn, Me.DatumBisDataGridViewTextBoxColumn, Me.AusgangsmarinaDataGridViewTextBoxColumn, Me.EndeMarinaDataGridViewTextBoxColumn, Me.SmSegelDataGridViewTextBoxColumn, Me.SmMotorDataGridViewTextBoxColumn, Me.SmGesamtDataGridViewTextBoxColumn, Me.NachtfahrtenDataGridViewTextBoxColumn, Me.NachtansteuerungenDataGridViewTextBoxColumn, Me.BordtageDataGridViewTextBoxColumn, Me.AusserhalbFB2DataGridViewTextBoxColumn, Me.AusserhalbFB3DataGridViewTextBoxColumn, Me.TornberichtDataGridViewTextBoxColumn, Me.BootsnameDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.LetzterSegeltagDataGridViewCheckBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.BordkassaDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.LogbuchDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn, Me.Nachtfahrtvon1DataGridViewTextBoxColumn, Me.Nachtfahrtbis1DataGridViewTextBoxColumn, Me.Sm1DataGridViewTextBoxColumn, Me.NachtfDatumvon1DataGridViewTextBoxColumn, Me.NachtZeitvon1DataGridViewTextBoxColumn, Me.NachtfDatumbis1DataGridViewTextBoxColumn, Me.NachtZeitbis1DataGridViewTextBoxColumn, Me.NachtFahrtvon2DataGridViewTextBoxColumn, Me.NachtFahrtbis2DataGridViewTextBoxColumn, Me.SM2DataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.NachtDatumvon2DataGridViewTextBoxColumn, Me.NachtZeitvon2DataGridViewTextBoxColumn, Me.NachtDatumbis2DataGridViewTextBoxColumn, Me.NachtZeitbis2DataGridViewTextBoxColumn, Me.Std50StartDataGridViewTextBoxColumn, Me.Std50ZielDataGridViewTextBoxColumn, Me.Std50SmGesDataGridViewTextBoxColumn, Me.Std50smFB2DataGridViewTextBoxColumn, Me.Std50DatumStartDataGridViewTextBoxColumn, Me.Std50ZeitStartDataGridViewTextBoxColumn, Me.Std50DatumZielDataGridViewTextBoxColumn, Me.Std50ZeitZielDataGridViewTextBoxColumn, Me.GezHafen1DataGridViewTextBoxColumn, Me.GezDatum1DataGridViewTextBoxColumn, Me.GezZeit1DataGridViewTextBoxColumn, Me.GezHafen2DataGridViewTextBoxColumn, Me.GezDatum2DataGridViewTextBoxColumn, Me.GezZeit2DataGridViewTextBoxColumn, Me.FB4StartDataGridViewTextBoxColumn, Me.FB4ZielDataGridViewTextBoxColumn, Me.FB4SmGesDataGridViewTextBoxColumn, Me.FB4SmFb3DataGridViewTextBoxColumn, Me.FB4DatumStartDataGridViewTextBoxColumn, Me.FB4ZeitStartDataGridViewTextBoxColumn, Me.FB4DatumZielDataGridViewTextBoxColumn, Me.FB4ZeitZielDataGridViewTextBoxColumn, Me.RevierDataGridViewTextBoxColumn, Me.VerbrauchproToernDataGridViewTextBoxColumn})
        Me.dgvToern.DataSource = Me.bsToernname
        Me.dgvToern.Location = New System.Drawing.Point(6, 14)
        Me.dgvToern.Name = "dgvToern"
        Me.dgvToern.Size = New System.Drawing.Size(558, 120)
        Me.dgvToern.TabIndex = 22
        '
        'ToernbezeichnungDataGridViewTextBoxColumn
        '
        Me.ToernbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.HeaderText = "Toernbezeichnung"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Name = "ToernbezeichnungDataGridViewTextBoxColumn"
        Me.ToernbezeichnungDataGridViewTextBoxColumn.Width = 200
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
        'AusgangsmarinaDataGridViewTextBoxColumn
        '
        Me.AusgangsmarinaDataGridViewTextBoxColumn.DataPropertyName = "Ausgangsmarina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.HeaderText = "Ausgangsmarina"
        Me.AusgangsmarinaDataGridViewTextBoxColumn.Name = "AusgangsmarinaDataGridViewTextBoxColumn"
        '
        'EndeMarinaDataGridViewTextBoxColumn
        '
        Me.EndeMarinaDataGridViewTextBoxColumn.DataPropertyName = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.HeaderText = "EndeMarina"
        Me.EndeMarinaDataGridViewTextBoxColumn.Name = "EndeMarinaDataGridViewTextBoxColumn"
        '
        'SmSegelDataGridViewTextBoxColumn
        '
        Me.SmSegelDataGridViewTextBoxColumn.DataPropertyName = "smSegel"
        Me.SmSegelDataGridViewTextBoxColumn.HeaderText = "smSegel"
        Me.SmSegelDataGridViewTextBoxColumn.Name = "SmSegelDataGridViewTextBoxColumn"
        '
        'SmMotorDataGridViewTextBoxColumn
        '
        Me.SmMotorDataGridViewTextBoxColumn.DataPropertyName = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.HeaderText = "smMotor"
        Me.SmMotorDataGridViewTextBoxColumn.Name = "SmMotorDataGridViewTextBoxColumn"
        '
        'SmGesamtDataGridViewTextBoxColumn
        '
        Me.SmGesamtDataGridViewTextBoxColumn.DataPropertyName = "smGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.HeaderText = "smGesamt"
        Me.SmGesamtDataGridViewTextBoxColumn.Name = "SmGesamtDataGridViewTextBoxColumn"
        '
        'NachtfahrtenDataGridViewTextBoxColumn
        '
        Me.NachtfahrtenDataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn.HeaderText = "Nachtfahrten"
        Me.NachtfahrtenDataGridViewTextBoxColumn.Name = "NachtfahrtenDataGridViewTextBoxColumn"
        '
        'NachtansteuerungenDataGridViewTextBoxColumn
        '
        Me.NachtansteuerungenDataGridViewTextBoxColumn.DataPropertyName = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn.HeaderText = "Nachtansteuerungen"
        Me.NachtansteuerungenDataGridViewTextBoxColumn.Name = "NachtansteuerungenDataGridViewTextBoxColumn"
        '
        'BordtageDataGridViewTextBoxColumn
        '
        Me.BordtageDataGridViewTextBoxColumn.DataPropertyName = "Bordtage"
        Me.BordtageDataGridViewTextBoxColumn.HeaderText = "Bordtage"
        Me.BordtageDataGridViewTextBoxColumn.Name = "BordtageDataGridViewTextBoxColumn"
        '
        'AusserhalbFB2DataGridViewTextBoxColumn
        '
        Me.AusserhalbFB2DataGridViewTextBoxColumn.DataPropertyName = "ausserhalbFB2"
        Me.AusserhalbFB2DataGridViewTextBoxColumn.HeaderText = "ausserhalbFB2"
        Me.AusserhalbFB2DataGridViewTextBoxColumn.Name = "AusserhalbFB2DataGridViewTextBoxColumn"
        '
        'AusserhalbFB3DataGridViewTextBoxColumn
        '
        Me.AusserhalbFB3DataGridViewTextBoxColumn.DataPropertyName = "ausserhalbFB3"
        Me.AusserhalbFB3DataGridViewTextBoxColumn.HeaderText = "ausserhalbFB3"
        Me.AusserhalbFB3DataGridViewTextBoxColumn.Name = "AusserhalbFB3DataGridViewTextBoxColumn"
        '
        'TornberichtDataGridViewTextBoxColumn
        '
        Me.TornberichtDataGridViewTextBoxColumn.DataPropertyName = "Tornbericht"
        Me.TornberichtDataGridViewTextBoxColumn.HeaderText = "Tornbericht"
        Me.TornberichtDataGridViewTextBoxColumn.Name = "TornberichtDataGridViewTextBoxColumn"
        '
        'BootsnameDataGridViewTextBoxColumn
        '
        Me.BootsnameDataGridViewTextBoxColumn.DataPropertyName = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.HeaderText = "Bootsname"
        Me.BootsnameDataGridViewTextBoxColumn.Name = "BootsnameDataGridViewTextBoxColumn"
        '
        'SkipperDataGridViewTextBoxColumn
        '
        Me.SkipperDataGridViewTextBoxColumn.DataPropertyName = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.HeaderText = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.Name = "SkipperDataGridViewTextBoxColumn"
        '
        'LetzterSegeltagDataGridViewCheckBoxColumn
        '
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.DataPropertyName = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.HeaderText = "letzterSegeltag"
        Me.LetzterSegeltagDataGridViewCheckBoxColumn.Name = "LetzterSegeltagDataGridViewCheckBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        '
        'BordkassaDataGridViewTextBoxColumn
        '
        Me.BordkassaDataGridViewTextBoxColumn.DataPropertyName = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.HeaderText = "Bordkassa"
        Me.BordkassaDataGridViewTextBoxColumn.Name = "BordkassaDataGridViewTextBoxColumn"
        '
        'RouteDataGridViewTextBoxColumn
        '
        Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "Route"
        Me.RouteDataGridViewTextBoxColumn.HeaderText = "Route"
        Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
        '
        'LogbuchDataGridViewTextBoxColumn
        '
        Me.LogbuchDataGridViewTextBoxColumn.DataPropertyName = "Logbuch"
        Me.LogbuchDataGridViewTextBoxColumn.HeaderText = "Logbuch"
        Me.LogbuchDataGridViewTextBoxColumn.Name = "LogbuchDataGridViewTextBoxColumn"
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
        'IDToernDataGridViewTextBoxColumn
        '
        Me.IDToernDataGridViewTextBoxColumn.DataPropertyName = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.HeaderText = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.Name = "IDToernDataGridViewTextBoxColumn"
        '
        'Nachtfahrtvon1DataGridViewTextBoxColumn
        '
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrtvon1"
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.HeaderText = "Nachtfahrtvon1"
        Me.Nachtfahrtvon1DataGridViewTextBoxColumn.Name = "Nachtfahrtvon1DataGridViewTextBoxColumn"
        '
        'Nachtfahrtbis1DataGridViewTextBoxColumn
        '
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.DataPropertyName = "Nachtfahrtbis1"
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.HeaderText = "Nachtfahrtbis1"
        Me.Nachtfahrtbis1DataGridViewTextBoxColumn.Name = "Nachtfahrtbis1DataGridViewTextBoxColumn"
        '
        'Sm1DataGridViewTextBoxColumn
        '
        Me.Sm1DataGridViewTextBoxColumn.DataPropertyName = "Sm1"
        Me.Sm1DataGridViewTextBoxColumn.HeaderText = "Sm1"
        Me.Sm1DataGridViewTextBoxColumn.Name = "Sm1DataGridViewTextBoxColumn"
        '
        'NachtfDatumvon1DataGridViewTextBoxColumn
        '
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.DataPropertyName = "NachtfDatumvon1"
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.HeaderText = "NachtfDatumvon1"
        Me.NachtfDatumvon1DataGridViewTextBoxColumn.Name = "NachtfDatumvon1DataGridViewTextBoxColumn"
        '
        'NachtZeitvon1DataGridViewTextBoxColumn
        '
        Me.NachtZeitvon1DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitvon1"
        Me.NachtZeitvon1DataGridViewTextBoxColumn.HeaderText = "NachtZeitvon1"
        Me.NachtZeitvon1DataGridViewTextBoxColumn.Name = "NachtZeitvon1DataGridViewTextBoxColumn"
        '
        'NachtfDatumbis1DataGridViewTextBoxColumn
        '
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.DataPropertyName = "NachtfDatumbis1"
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.HeaderText = "NachtfDatumbis1"
        Me.NachtfDatumbis1DataGridViewTextBoxColumn.Name = "NachtfDatumbis1DataGridViewTextBoxColumn"
        '
        'NachtZeitbis1DataGridViewTextBoxColumn
        '
        Me.NachtZeitbis1DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitbis1"
        Me.NachtZeitbis1DataGridViewTextBoxColumn.HeaderText = "NachtZeitbis1"
        Me.NachtZeitbis1DataGridViewTextBoxColumn.Name = "NachtZeitbis1DataGridViewTextBoxColumn"
        '
        'NachtFahrtvon2DataGridViewTextBoxColumn
        '
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtFahrtvon2"
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.HeaderText = "NachtFahrtvon2"
        Me.NachtFahrtvon2DataGridViewTextBoxColumn.Name = "NachtFahrtvon2DataGridViewTextBoxColumn"
        '
        'NachtFahrtbis2DataGridViewTextBoxColumn
        '
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtFahrtbis2"
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.HeaderText = "NachtFahrtbis2"
        Me.NachtFahrtbis2DataGridViewTextBoxColumn.Name = "NachtFahrtbis2DataGridViewTextBoxColumn"
        '
        'SM2DataGridViewTextBoxColumn
        '
        Me.SM2DataGridViewTextBoxColumn.DataPropertyName = "SM2"
        Me.SM2DataGridViewTextBoxColumn.HeaderText = "SM2"
        Me.SM2DataGridViewTextBoxColumn.Name = "SM2DataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NachtDatumvon2DataGridViewTextBoxColumn
        '
        Me.NachtDatumvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtDatumvon2"
        Me.NachtDatumvon2DataGridViewTextBoxColumn.HeaderText = "NachtDatumvon2"
        Me.NachtDatumvon2DataGridViewTextBoxColumn.Name = "NachtDatumvon2DataGridViewTextBoxColumn"
        '
        'NachtZeitvon2DataGridViewTextBoxColumn
        '
        Me.NachtZeitvon2DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitvon2"
        Me.NachtZeitvon2DataGridViewTextBoxColumn.HeaderText = "NachtZeitvon2"
        Me.NachtZeitvon2DataGridViewTextBoxColumn.Name = "NachtZeitvon2DataGridViewTextBoxColumn"
        '
        'NachtDatumbis2DataGridViewTextBoxColumn
        '
        Me.NachtDatumbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtDatumbis2"
        Me.NachtDatumbis2DataGridViewTextBoxColumn.HeaderText = "NachtDatumbis2"
        Me.NachtDatumbis2DataGridViewTextBoxColumn.Name = "NachtDatumbis2DataGridViewTextBoxColumn"
        '
        'NachtZeitbis2DataGridViewTextBoxColumn
        '
        Me.NachtZeitbis2DataGridViewTextBoxColumn.DataPropertyName = "NachtZeitbis2"
        Me.NachtZeitbis2DataGridViewTextBoxColumn.HeaderText = "NachtZeitbis2"
        Me.NachtZeitbis2DataGridViewTextBoxColumn.Name = "NachtZeitbis2DataGridViewTextBoxColumn"
        '
        'Std50StartDataGridViewTextBoxColumn
        '
        Me.Std50StartDataGridViewTextBoxColumn.DataPropertyName = "Std50Start"
        Me.Std50StartDataGridViewTextBoxColumn.HeaderText = "Std50Start"
        Me.Std50StartDataGridViewTextBoxColumn.Name = "Std50StartDataGridViewTextBoxColumn"
        '
        'Std50ZielDataGridViewTextBoxColumn
        '
        Me.Std50ZielDataGridViewTextBoxColumn.DataPropertyName = "Std50Ziel"
        Me.Std50ZielDataGridViewTextBoxColumn.HeaderText = "Std50Ziel"
        Me.Std50ZielDataGridViewTextBoxColumn.Name = "Std50ZielDataGridViewTextBoxColumn"
        '
        'Std50SmGesDataGridViewTextBoxColumn
        '
        Me.Std50SmGesDataGridViewTextBoxColumn.DataPropertyName = "Std50SmGes"
        Me.Std50SmGesDataGridViewTextBoxColumn.HeaderText = "Std50SmGes"
        Me.Std50SmGesDataGridViewTextBoxColumn.Name = "Std50SmGesDataGridViewTextBoxColumn"
        '
        'Std50smFB2DataGridViewTextBoxColumn
        '
        Me.Std50smFB2DataGridViewTextBoxColumn.DataPropertyName = "Std50smFB2"
        Me.Std50smFB2DataGridViewTextBoxColumn.HeaderText = "Std50smFB2"
        Me.Std50smFB2DataGridViewTextBoxColumn.Name = "Std50smFB2DataGridViewTextBoxColumn"
        '
        'Std50DatumStartDataGridViewTextBoxColumn
        '
        Me.Std50DatumStartDataGridViewTextBoxColumn.DataPropertyName = "Std50DatumStart"
        Me.Std50DatumStartDataGridViewTextBoxColumn.HeaderText = "Std50DatumStart"
        Me.Std50DatumStartDataGridViewTextBoxColumn.Name = "Std50DatumStartDataGridViewTextBoxColumn"
        '
        'Std50ZeitStartDataGridViewTextBoxColumn
        '
        Me.Std50ZeitStartDataGridViewTextBoxColumn.DataPropertyName = "Std50ZeitStart"
        Me.Std50ZeitStartDataGridViewTextBoxColumn.HeaderText = "Std50ZeitStart"
        Me.Std50ZeitStartDataGridViewTextBoxColumn.Name = "Std50ZeitStartDataGridViewTextBoxColumn"
        '
        'Std50DatumZielDataGridViewTextBoxColumn
        '
        Me.Std50DatumZielDataGridViewTextBoxColumn.DataPropertyName = "Std50DatumZiel"
        Me.Std50DatumZielDataGridViewTextBoxColumn.HeaderText = "Std50DatumZiel"
        Me.Std50DatumZielDataGridViewTextBoxColumn.Name = "Std50DatumZielDataGridViewTextBoxColumn"
        '
        'Std50ZeitZielDataGridViewTextBoxColumn
        '
        Me.Std50ZeitZielDataGridViewTextBoxColumn.DataPropertyName = "Std50ZeitZiel"
        Me.Std50ZeitZielDataGridViewTextBoxColumn.HeaderText = "Std50ZeitZiel"
        Me.Std50ZeitZielDataGridViewTextBoxColumn.Name = "Std50ZeitZielDataGridViewTextBoxColumn"
        '
        'GezHafen1DataGridViewTextBoxColumn
        '
        Me.GezHafen1DataGridViewTextBoxColumn.DataPropertyName = "GezHafen1"
        Me.GezHafen1DataGridViewTextBoxColumn.HeaderText = "GezHafen1"
        Me.GezHafen1DataGridViewTextBoxColumn.Name = "GezHafen1DataGridViewTextBoxColumn"
        '
        'GezDatum1DataGridViewTextBoxColumn
        '
        Me.GezDatum1DataGridViewTextBoxColumn.DataPropertyName = "GezDatum1"
        Me.GezDatum1DataGridViewTextBoxColumn.HeaderText = "GezDatum1"
        Me.GezDatum1DataGridViewTextBoxColumn.Name = "GezDatum1DataGridViewTextBoxColumn"
        '
        'GezZeit1DataGridViewTextBoxColumn
        '
        Me.GezZeit1DataGridViewTextBoxColumn.DataPropertyName = "GezZeit1"
        Me.GezZeit1DataGridViewTextBoxColumn.HeaderText = "GezZeit1"
        Me.GezZeit1DataGridViewTextBoxColumn.Name = "GezZeit1DataGridViewTextBoxColumn"
        '
        'GezHafen2DataGridViewTextBoxColumn
        '
        Me.GezHafen2DataGridViewTextBoxColumn.DataPropertyName = "GezHafen2"
        Me.GezHafen2DataGridViewTextBoxColumn.HeaderText = "GezHafen2"
        Me.GezHafen2DataGridViewTextBoxColumn.Name = "GezHafen2DataGridViewTextBoxColumn"
        '
        'GezDatum2DataGridViewTextBoxColumn
        '
        Me.GezDatum2DataGridViewTextBoxColumn.DataPropertyName = "GezDatum2"
        Me.GezDatum2DataGridViewTextBoxColumn.HeaderText = "GezDatum2"
        Me.GezDatum2DataGridViewTextBoxColumn.Name = "GezDatum2DataGridViewTextBoxColumn"
        '
        'GezZeit2DataGridViewTextBoxColumn
        '
        Me.GezZeit2DataGridViewTextBoxColumn.DataPropertyName = "GezZeit2"
        Me.GezZeit2DataGridViewTextBoxColumn.HeaderText = "GezZeit2"
        Me.GezZeit2DataGridViewTextBoxColumn.Name = "GezZeit2DataGridViewTextBoxColumn"
        '
        'FB4StartDataGridViewTextBoxColumn
        '
        Me.FB4StartDataGridViewTextBoxColumn.DataPropertyName = "FB4Start"
        Me.FB4StartDataGridViewTextBoxColumn.HeaderText = "FB4Start"
        Me.FB4StartDataGridViewTextBoxColumn.Name = "FB4StartDataGridViewTextBoxColumn"
        '
        'FB4ZielDataGridViewTextBoxColumn
        '
        Me.FB4ZielDataGridViewTextBoxColumn.DataPropertyName = "FB4Ziel"
        Me.FB4ZielDataGridViewTextBoxColumn.HeaderText = "FB4Ziel"
        Me.FB4ZielDataGridViewTextBoxColumn.Name = "FB4ZielDataGridViewTextBoxColumn"
        '
        'FB4SmGesDataGridViewTextBoxColumn
        '
        Me.FB4SmGesDataGridViewTextBoxColumn.DataPropertyName = "FB4SmGes"
        Me.FB4SmGesDataGridViewTextBoxColumn.HeaderText = "FB4SmGes"
        Me.FB4SmGesDataGridViewTextBoxColumn.Name = "FB4SmGesDataGridViewTextBoxColumn"
        '
        'FB4SmFb3DataGridViewTextBoxColumn
        '
        Me.FB4SmFb3DataGridViewTextBoxColumn.DataPropertyName = "FB4SmFb3"
        Me.FB4SmFb3DataGridViewTextBoxColumn.HeaderText = "FB4SmFb3"
        Me.FB4SmFb3DataGridViewTextBoxColumn.Name = "FB4SmFb3DataGridViewTextBoxColumn"
        '
        'FB4DatumStartDataGridViewTextBoxColumn
        '
        Me.FB4DatumStartDataGridViewTextBoxColumn.DataPropertyName = "FB4DatumStart"
        Me.FB4DatumStartDataGridViewTextBoxColumn.HeaderText = "FB4DatumStart"
        Me.FB4DatumStartDataGridViewTextBoxColumn.Name = "FB4DatumStartDataGridViewTextBoxColumn"
        '
        'FB4ZeitStartDataGridViewTextBoxColumn
        '
        Me.FB4ZeitStartDataGridViewTextBoxColumn.DataPropertyName = "FB4ZeitStart"
        Me.FB4ZeitStartDataGridViewTextBoxColumn.HeaderText = "FB4ZeitStart"
        Me.FB4ZeitStartDataGridViewTextBoxColumn.Name = "FB4ZeitStartDataGridViewTextBoxColumn"
        '
        'FB4DatumZielDataGridViewTextBoxColumn
        '
        Me.FB4DatumZielDataGridViewTextBoxColumn.DataPropertyName = "FB4DatumZiel"
        Me.FB4DatumZielDataGridViewTextBoxColumn.HeaderText = "FB4DatumZiel"
        Me.FB4DatumZielDataGridViewTextBoxColumn.Name = "FB4DatumZielDataGridViewTextBoxColumn"
        '
        'FB4ZeitZielDataGridViewTextBoxColumn
        '
        Me.FB4ZeitZielDataGridViewTextBoxColumn.DataPropertyName = "FB4ZeitZiel"
        Me.FB4ZeitZielDataGridViewTextBoxColumn.HeaderText = "FB4ZeitZiel"
        Me.FB4ZeitZielDataGridViewTextBoxColumn.Name = "FB4ZeitZielDataGridViewTextBoxColumn"
        '
        'RevierDataGridViewTextBoxColumn
        '
        Me.RevierDataGridViewTextBoxColumn.DataPropertyName = "Revier"
        Me.RevierDataGridViewTextBoxColumn.HeaderText = "Revier"
        Me.RevierDataGridViewTextBoxColumn.Name = "RevierDataGridViewTextBoxColumn"
        '
        'VerbrauchproToernDataGridViewTextBoxColumn
        '
        Me.VerbrauchproToernDataGridViewTextBoxColumn.DataPropertyName = "VerbrauchproToern"
        Me.VerbrauchproToernDataGridViewTextBoxColumn.HeaderText = "VerbrauchproToern"
        Me.VerbrauchproToernDataGridViewTextBoxColumn.Name = "VerbrauchproToernDataGridViewTextBoxColumn"
        '
        'taToernname
        '
        Me.taToernname.ClearBeforeFill = True
        '
        'dgvSchaden
        '
        Me.dgvSchaden.AutoGenerateColumns = False
        Me.dgvSchaden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchaden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PolizzeDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.TörnDataGridViewTextBoxColumn, Me.VersicherungsartDataGridViewTextBoxColumn, Me.SchadensbeschreibungDataGridViewTextBoxColumn, Me.SchadensnummerDataGridViewTextBoxColumn, Me.SchadensbetragDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1, Me.BearbeiterDataGridViewTextBoxColumn, Me.BeamailDataGridViewTextBoxColumn, Me.BeaTelefonDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn1, Me.SchadensortDataGridViewTextBoxColumn, Me.WieDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn1, Me.R2DataGridViewTextBoxColumn1, Me.R3DataGridViewTextBoxColumn1, Me.BelegKautionDataGridViewTextBoxColumn, Me.BelegRepDataGridViewTextBoxColumn, Me.BelegDiebDataGridViewTextBoxColumn, Me.HafenkapiteanDataGridViewTextBoxColumn, Me.VersicherungCharterDataGridViewTextBoxColumn, Me.VersicherungGegnerDataGridViewTextBoxColumn, Me.CharterMeldungDataGridViewTextBoxColumn, Me.SkizzeDataGridViewTextBoxColumn, Me.SegelfuehrungDataGridViewTextBoxColumn, Me.WindrichtungDataGridViewTextBoxColumn, Me.MotorAnAusDataGridViewTextBoxColumn, Me.KursEigenDataGridViewTextBoxColumn, Me.KursGegnerDataGridViewTextBoxColumn, Me.ZeugenDataGridViewTextBoxColumn, Me.ArztbeschDataGridViewTextBoxColumn, Me.FlugstornoDataGridViewTextBoxColumn, Me.CharterStornoDataGridViewTextBoxColumn})
        Me.dgvSchaden.DataSource = Me.bsSchaden
        Me.dgvSchaden.Location = New System.Drawing.Point(6, 20)
        Me.dgvSchaden.Name = "dgvSchaden"
        Me.dgvSchaden.Size = New System.Drawing.Size(558, 120)
        Me.dgvSchaden.TabIndex = 23
        '
        'PolizzeDataGridViewTextBoxColumn
        '
        Me.PolizzeDataGridViewTextBoxColumn.DataPropertyName = "Polizze"
        Me.PolizzeDataGridViewTextBoxColumn.HeaderText = "Polizze"
        Me.PolizzeDataGridViewTextBoxColumn.Name = "PolizzeDataGridViewTextBoxColumn"
        Me.PolizzeDataGridViewTextBoxColumn.Width = 200
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        '
        'TörnDataGridViewTextBoxColumn
        '
        Me.TörnDataGridViewTextBoxColumn.DataPropertyName = "Törn"
        Me.TörnDataGridViewTextBoxColumn.HeaderText = "Törn"
        Me.TörnDataGridViewTextBoxColumn.Name = "TörnDataGridViewTextBoxColumn"
        '
        'VersicherungsartDataGridViewTextBoxColumn
        '
        Me.VersicherungsartDataGridViewTextBoxColumn.DataPropertyName = "Versicherungsart"
        Me.VersicherungsartDataGridViewTextBoxColumn.HeaderText = "Versicherungsart"
        Me.VersicherungsartDataGridViewTextBoxColumn.Name = "VersicherungsartDataGridViewTextBoxColumn"
        '
        'SchadensbeschreibungDataGridViewTextBoxColumn
        '
        Me.SchadensbeschreibungDataGridViewTextBoxColumn.DataPropertyName = "Schadensbeschreibung"
        Me.SchadensbeschreibungDataGridViewTextBoxColumn.HeaderText = "Schadensbeschreibung"
        Me.SchadensbeschreibungDataGridViewTextBoxColumn.Name = "SchadensbeschreibungDataGridViewTextBoxColumn"
        '
        'SchadensnummerDataGridViewTextBoxColumn
        '
        Me.SchadensnummerDataGridViewTextBoxColumn.DataPropertyName = "Schadensnummer"
        Me.SchadensnummerDataGridViewTextBoxColumn.HeaderText = "Schadensnummer"
        Me.SchadensnummerDataGridViewTextBoxColumn.Name = "SchadensnummerDataGridViewTextBoxColumn"
        '
        'SchadensbetragDataGridViewTextBoxColumn
        '
        Me.SchadensbetragDataGridViewTextBoxColumn.DataPropertyName = "Schadensbetrag"
        Me.SchadensbetragDataGridViewTextBoxColumn.HeaderText = "Schadensbetrag"
        Me.SchadensbetragDataGridViewTextBoxColumn.Name = "SchadensbetragDataGridViewTextBoxColumn"
        '
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'BearbeiterDataGridViewTextBoxColumn
        '
        Me.BearbeiterDataGridViewTextBoxColumn.DataPropertyName = "Bearbeiter"
        Me.BearbeiterDataGridViewTextBoxColumn.HeaderText = "Bearbeiter"
        Me.BearbeiterDataGridViewTextBoxColumn.Name = "BearbeiterDataGridViewTextBoxColumn"
        '
        'BeamailDataGridViewTextBoxColumn
        '
        Me.BeamailDataGridViewTextBoxColumn.DataPropertyName = "Bea-mail"
        Me.BeamailDataGridViewTextBoxColumn.HeaderText = "Bea-mail"
        Me.BeamailDataGridViewTextBoxColumn.Name = "BeamailDataGridViewTextBoxColumn"
        '
        'BeaTelefonDataGridViewTextBoxColumn
        '
        Me.BeaTelefonDataGridViewTextBoxColumn.DataPropertyName = "Bea-Telefon"
        Me.BeaTelefonDataGridViewTextBoxColumn.HeaderText = "Bea-Telefon"
        Me.BeaTelefonDataGridViewTextBoxColumn.Name = "BeaTelefonDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'SchadensortDataGridViewTextBoxColumn
        '
        Me.SchadensortDataGridViewTextBoxColumn.DataPropertyName = "Schadensort"
        Me.SchadensortDataGridViewTextBoxColumn.HeaderText = "Schadensort"
        Me.SchadensortDataGridViewTextBoxColumn.Name = "SchadensortDataGridViewTextBoxColumn"
        '
        'WieDataGridViewTextBoxColumn
        '
        Me.WieDataGridViewTextBoxColumn.DataPropertyName = "Wie"
        Me.WieDataGridViewTextBoxColumn.HeaderText = "Wie"
        Me.WieDataGridViewTextBoxColumn.Name = "WieDataGridViewTextBoxColumn"
        '
        'R1DataGridViewTextBoxColumn1
        '
        Me.R1DataGridViewTextBoxColumn1.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn1.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn1.Name = "R1DataGridViewTextBoxColumn1"
        '
        'R2DataGridViewTextBoxColumn1
        '
        Me.R2DataGridViewTextBoxColumn1.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn1.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn1.Name = "R2DataGridViewTextBoxColumn1"
        '
        'R3DataGridViewTextBoxColumn1
        '
        Me.R3DataGridViewTextBoxColumn1.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn1.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn1.Name = "R3DataGridViewTextBoxColumn1"
        '
        'BelegKautionDataGridViewTextBoxColumn
        '
        Me.BelegKautionDataGridViewTextBoxColumn.DataPropertyName = "BelegKaution"
        Me.BelegKautionDataGridViewTextBoxColumn.HeaderText = "BelegKaution"
        Me.BelegKautionDataGridViewTextBoxColumn.Name = "BelegKautionDataGridViewTextBoxColumn"
        '
        'BelegRepDataGridViewTextBoxColumn
        '
        Me.BelegRepDataGridViewTextBoxColumn.DataPropertyName = "BelegRep"
        Me.BelegRepDataGridViewTextBoxColumn.HeaderText = "BelegRep"
        Me.BelegRepDataGridViewTextBoxColumn.Name = "BelegRepDataGridViewTextBoxColumn"
        '
        'BelegDiebDataGridViewTextBoxColumn
        '
        Me.BelegDiebDataGridViewTextBoxColumn.DataPropertyName = "BelegDieb"
        Me.BelegDiebDataGridViewTextBoxColumn.HeaderText = "BelegDieb"
        Me.BelegDiebDataGridViewTextBoxColumn.Name = "BelegDiebDataGridViewTextBoxColumn"
        '
        'HafenkapiteanDataGridViewTextBoxColumn
        '
        Me.HafenkapiteanDataGridViewTextBoxColumn.DataPropertyName = "Hafenkapitean"
        Me.HafenkapiteanDataGridViewTextBoxColumn.HeaderText = "Hafenkapitean"
        Me.HafenkapiteanDataGridViewTextBoxColumn.Name = "HafenkapiteanDataGridViewTextBoxColumn"
        '
        'VersicherungCharterDataGridViewTextBoxColumn
        '
        Me.VersicherungCharterDataGridViewTextBoxColumn.DataPropertyName = "VersicherungCharter"
        Me.VersicherungCharterDataGridViewTextBoxColumn.HeaderText = "VersicherungCharter"
        Me.VersicherungCharterDataGridViewTextBoxColumn.Name = "VersicherungCharterDataGridViewTextBoxColumn"
        '
        'VersicherungGegnerDataGridViewTextBoxColumn
        '
        Me.VersicherungGegnerDataGridViewTextBoxColumn.DataPropertyName = "VersicherungGegner"
        Me.VersicherungGegnerDataGridViewTextBoxColumn.HeaderText = "VersicherungGegner"
        Me.VersicherungGegnerDataGridViewTextBoxColumn.Name = "VersicherungGegnerDataGridViewTextBoxColumn"
        '
        'CharterMeldungDataGridViewTextBoxColumn
        '
        Me.CharterMeldungDataGridViewTextBoxColumn.DataPropertyName = "CharterMeldung"
        Me.CharterMeldungDataGridViewTextBoxColumn.HeaderText = "CharterMeldung"
        Me.CharterMeldungDataGridViewTextBoxColumn.Name = "CharterMeldungDataGridViewTextBoxColumn"
        '
        'SkizzeDataGridViewTextBoxColumn
        '
        Me.SkizzeDataGridViewTextBoxColumn.DataPropertyName = "Skizze"
        Me.SkizzeDataGridViewTextBoxColumn.HeaderText = "Skizze"
        Me.SkizzeDataGridViewTextBoxColumn.Name = "SkizzeDataGridViewTextBoxColumn"
        '
        'SegelfuehrungDataGridViewTextBoxColumn
        '
        Me.SegelfuehrungDataGridViewTextBoxColumn.DataPropertyName = "Segelfuehrung"
        Me.SegelfuehrungDataGridViewTextBoxColumn.HeaderText = "Segelfuehrung"
        Me.SegelfuehrungDataGridViewTextBoxColumn.Name = "SegelfuehrungDataGridViewTextBoxColumn"
        '
        'WindrichtungDataGridViewTextBoxColumn
        '
        Me.WindrichtungDataGridViewTextBoxColumn.DataPropertyName = "Windrichtung"
        Me.WindrichtungDataGridViewTextBoxColumn.HeaderText = "Windrichtung"
        Me.WindrichtungDataGridViewTextBoxColumn.Name = "WindrichtungDataGridViewTextBoxColumn"
        '
        'MotorAnAusDataGridViewTextBoxColumn
        '
        Me.MotorAnAusDataGridViewTextBoxColumn.DataPropertyName = "MotorAnAus"
        Me.MotorAnAusDataGridViewTextBoxColumn.HeaderText = "MotorAnAus"
        Me.MotorAnAusDataGridViewTextBoxColumn.Name = "MotorAnAusDataGridViewTextBoxColumn"
        '
        'KursEigenDataGridViewTextBoxColumn
        '
        Me.KursEigenDataGridViewTextBoxColumn.DataPropertyName = "KursEigen"
        Me.KursEigenDataGridViewTextBoxColumn.HeaderText = "KursEigen"
        Me.KursEigenDataGridViewTextBoxColumn.Name = "KursEigenDataGridViewTextBoxColumn"
        '
        'KursGegnerDataGridViewTextBoxColumn
        '
        Me.KursGegnerDataGridViewTextBoxColumn.DataPropertyName = "KursGegner"
        Me.KursGegnerDataGridViewTextBoxColumn.HeaderText = "KursGegner"
        Me.KursGegnerDataGridViewTextBoxColumn.Name = "KursGegnerDataGridViewTextBoxColumn"
        '
        'ZeugenDataGridViewTextBoxColumn
        '
        Me.ZeugenDataGridViewTextBoxColumn.DataPropertyName = "Zeugen"
        Me.ZeugenDataGridViewTextBoxColumn.HeaderText = "Zeugen"
        Me.ZeugenDataGridViewTextBoxColumn.Name = "ZeugenDataGridViewTextBoxColumn"
        '
        'ArztbeschDataGridViewTextBoxColumn
        '
        Me.ArztbeschDataGridViewTextBoxColumn.DataPropertyName = "Arztbesch"
        Me.ArztbeschDataGridViewTextBoxColumn.HeaderText = "Arztbesch"
        Me.ArztbeschDataGridViewTextBoxColumn.Name = "ArztbeschDataGridViewTextBoxColumn"
        '
        'FlugstornoDataGridViewTextBoxColumn
        '
        Me.FlugstornoDataGridViewTextBoxColumn.DataPropertyName = "Flugstorno"
        Me.FlugstornoDataGridViewTextBoxColumn.HeaderText = "Flugstorno"
        Me.FlugstornoDataGridViewTextBoxColumn.Name = "FlugstornoDataGridViewTextBoxColumn"
        '
        'CharterStornoDataGridViewTextBoxColumn
        '
        Me.CharterStornoDataGridViewTextBoxColumn.DataPropertyName = "CharterStorno"
        Me.CharterStornoDataGridViewTextBoxColumn.HeaderText = "CharterStorno"
        Me.CharterStornoDataGridViewTextBoxColumn.Name = "CharterStornoDataGridViewTextBoxColumn"
        '
        'TextBox32
        '
        Me.TextBox32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Törn", True))
        Me.TextBox32.Location = New System.Drawing.Point(634, 307)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(100, 20)
        Me.TextBox32.TabIndex = 25
        '
        'TextBox31
        '
        Me.TextBox31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Polizze", True))
        Me.TextBox31.Location = New System.Drawing.Point(635, 334)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(100, 20)
        Me.TextBox31.TabIndex = 26
        '
        'GroupBoxV
        '
        Me.GroupBoxV.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBoxV.Controls.Add(Me.ListBoxH)
        Me.GroupBoxV.Controls.Add(Me.BAbruch)
        Me.GroupBoxV.Controls.Add(Me.BZurueck)
        Me.GroupBoxV.Controls.Add(Me.BLaden)
        Me.GroupBoxV.Controls.Add(Me.TextBoxV)
        Me.GroupBoxV.Controls.Add(Me.ListBoxV)
        Me.GroupBoxV.Location = New System.Drawing.Point(2525, 60)
        Me.GroupBoxV.Name = "GroupBoxV"
        Me.GroupBoxV.Size = New System.Drawing.Size(462, 316)
        Me.GroupBoxV.TabIndex = 27
        Me.GroupBoxV.TabStop = False
        Me.GroupBoxV.Text = "GroupBox1"
        '
        'ListBoxH
        '
        Me.ListBoxH.FormattingEnabled = True
        Me.ListBoxH.Location = New System.Drawing.Point(483, 21)
        Me.ListBoxH.Name = "ListBoxH"
        Me.ListBoxH.Size = New System.Drawing.Size(478, 225)
        Me.ListBoxH.TabIndex = 5
        '
        'BAbruch
        '
        Me.BAbruch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAbruch.Location = New System.Drawing.Point(167, 265)
        Me.BAbruch.Name = "BAbruch"
        Me.BAbruch.Size = New System.Drawing.Size(110, 34)
        Me.BAbruch.TabIndex = 4
        Me.BAbruch.Text = "Abrechen"
        Me.BAbruch.UseVisualStyleBackColor = True
        '
        'BZurueck
        '
        Me.BZurueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BZurueck.Location = New System.Drawing.Point(6, 267)
        Me.BZurueck.Name = "BZurueck"
        Me.BZurueck.Size = New System.Drawing.Size(127, 34)
        Me.BZurueck.TabIndex = 3
        Me.BZurueck.Text = "1 Ordner zurück"
        Me.BZurueck.UseVisualStyleBackColor = True
        '
        'BLaden
        '
        Me.BLaden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLaden.Location = New System.Drawing.Point(315, 265)
        Me.BLaden.Name = "BLaden"
        Me.BLaden.Size = New System.Drawing.Size(128, 34)
        Me.BLaden.TabIndex = 2
        Me.BLaden.Text = "Übernehmen"
        Me.BLaden.UseVisualStyleBackColor = True
        '
        'TextBoxV
        '
        Me.TextBoxV.Location = New System.Drawing.Point(6, 21)
        Me.TextBoxV.Name = "TextBoxV"
        Me.TextBoxV.Size = New System.Drawing.Size(448, 20)
        Me.TextBoxV.TabIndex = 1
        '
        'ListBoxV
        '
        Me.ListBoxV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxV.FormattingEnabled = True
        Me.ListBoxV.ItemHeight = 15
        Me.ListBoxV.Location = New System.Drawing.Point(6, 49)
        Me.ListBoxV.Name = "ListBoxV"
        Me.ListBoxV.Size = New System.Drawing.Size(448, 199)
        Me.ListBoxV.TabIndex = 0
        '
        'taSchaden
        '
        Me.taSchaden.ClearBeforeFill = True
        '
        'taVersicherter
        '
        Me.taVersicherter.ClearBeforeFill = True
        '
        'TextBox33
        '
        Me.TextBox33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "SchadensArt", True))
        Me.TextBox33.Location = New System.Drawing.Point(765, 308)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(100, 20)
        Me.TextBox33.TabIndex = 28
        '
        'gbFenster
        '
        Me.gbFenster.Controls.Add(Me.dgvSchaden)
        Me.gbFenster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFenster.Location = New System.Drawing.Point(1874, 21)
        Me.gbFenster.Name = "gbFenster"
        Me.gbFenster.Size = New System.Drawing.Size(570, 150)
        Me.gbFenster.TabIndex = 29
        Me.gbFenster.TabStop = False
        '
        'gbtoern
        '
        Me.gbtoern.Controls.Add(Me.dgvToern)
        Me.gbtoern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtoern.Location = New System.Drawing.Point(1893, 368)
        Me.gbtoern.Name = "gbtoern"
        Me.gbtoern.Size = New System.Drawing.Size(570, 150)
        Me.gbtoern.TabIndex = 30
        Me.gbtoern.TabStop = False
        '
        'gbNeu
        '
        Me.gbNeu.Controls.Add(Me.dgvversi)
        Me.gbNeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNeu.Location = New System.Drawing.Point(1874, 191)
        Me.gbNeu.Name = "gbNeu"
        Me.gbNeu.Size = New System.Drawing.Size(570, 150)
        Me.gbNeu.TabIndex = 31
        Me.gbNeu.TabStop = False
        '
        'dgvversi
        '
        Me.dgvversi.AutoGenerateColumns = False
        Me.dgvversi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvversi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.VersicherterName, Me.Abschlussdatum, Me.GueltigBis, Me.DataGridViewTextBoxColumn12})
        Me.dgvversi.DataSource = Me.bsVersicherter
        Me.dgvversi.Location = New System.Drawing.Point(6, 20)
        Me.dgvversi.Name = "dgvversi"
        Me.dgvversi.Size = New System.Drawing.Size(558, 120)
        Me.dgvversi.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Polizze"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Polizze"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'VersicherterName
        '
        Me.VersicherterName.DataPropertyName = "VersicherterName"
        Me.VersicherterName.HeaderText = "VersicherterName"
        Me.VersicherterName.Name = "VersicherterName"
        '
        'Abschlussdatum
        '
        Me.Abschlussdatum.DataPropertyName = "Abschlussdatum"
        Me.Abschlussdatum.HeaderText = "Abschlussdatum"
        Me.Abschlussdatum.Name = "Abschlussdatum"
        '
        'GueltigBis
        '
        Me.GueltigBis.DataPropertyName = "GueltigBis"
        Me.GueltigBis.HeaderText = "GueltigBis"
        Me.GueltigBis.Name = "GueltigBis"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(14, 130)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(84, 15)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Chartervertrag"
        '
        'TextBox35
        '
        Me.TextBox35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Chartervertrag", True))
        Me.TextBox35.Location = New System.Drawing.Point(104, 124)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(188, 21)
        Me.TextBox35.TabIndex = 13
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(298, 127)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(57, 15)
        Me.Label49.TabIndex = 10
        Me.Label49.Text = "Crewliste"
        '
        'TextBox34
        '
        Me.TextBox34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "crewliste", True))
        Me.TextBox34.Location = New System.Drawing.Point(361, 124)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(176, 21)
        Me.TextBox34.TabIndex = 11
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsSchaden, "Schadensbetrag", True))
        Me.TextBox9.Location = New System.Drawing.Point(361, 155)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(69, 21)
        Me.TextBox9.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(245, 158)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 15)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Schadensbetrag €:"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(435, 227)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(100, 19)
        Me.RadioButton4.TabIndex = 13
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'SchadenY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 526)
        Me.Controls.Add(Me.gbschnell)
        Me.Controls.Add(Me.gbNeu)
        Me.Controls.Add(Me.gbtoern)
        Me.Controls.Add(Me.gbFenster)
        Me.Controls.Add(Me.TextBox33)
        Me.Controls.Add(Me.GroupBoxV)
        Me.Controls.Add(Me.TextBox31)
        Me.Controls.Add(Me.TextBox32)
        Me.Controls.Add(Me.gbRuecktritt)
        Me.Controls.Add(Me.gbUnfallbericht)
        Me.Controls.Add(Me.gbHaftschaden)
        Me.Controls.Add(Me.gbKaution)
        Me.Controls.Add(Me.ButtonSpeichern)
        Me.Controls.Add(Me.gbVersicherung)
        Me.Controls.Add(Me.gbSchilderung)
        Me.Controls.Add(Me.gbSchadenmeldung)
        Me.Controls.Add(Me.gbBemerkung)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SchadenY"
        Me.Text = "Yacht-Pool Schadensmeldung"
        Me.gbschnell.ResumeLayout(False)
        Me.gbschnell.PerformLayout()
        Me.gbSchadenmeldung.ResumeLayout(False)
        Me.gbSchadenmeldung.PerformLayout()
        CType(Me.bsSchaden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSchilderung.ResumeLayout(False)
        Me.gbSchilderung.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVersicherung.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsToernname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVersicherter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBemerkung.ResumeLayout(False)
        Me.gbKaution.ResumeLayout(False)
        Me.gbKaution.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHaftschaden.ResumeLayout(False)
        Me.gbHaftschaden.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUnfallbericht.ResumeLayout(False)
        Me.gbUnfallbericht.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRuecktritt.ResumeLayout(False)
        Me.gbRuecktritt.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvToern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSchaden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxV.ResumeLayout(False)
        Me.GroupBoxV.PerformLayout()
        Me.gbFenster.ResumeLayout(False)
        Me.gbtoern.ResumeLayout(False)
        Me.gbNeu.ResumeLayout(False)
        CType(Me.dgvversi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gbschnell As System.Windows.Forms.GroupBox
    Friend WithEvents gbSchadenmeldung As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents gbSchilderung As System.Windows.Forms.GroupBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbVersicherung As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ButtonSpeichern As System.Windows.Forms.Button
    Friend WithEvents gbBemerkung As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents gbKaution As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents gbHaftschaden As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents gbUnfallbericht As System.Windows.Forms.GroupBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents gbRuecktritt As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents dgvToern As System.Windows.Forms.DataGridView
    Friend WithEvents dsVersicherung As WindowsApplication1.VersicherungDataSet
    Friend WithEvents bsSchaden As System.Windows.Forms.BindingSource
    Friend WithEvents taSchaden As WindowsApplication1.VersicherungDataSetTableAdapters.SchadenTableAdapter
    Friend WithEvents bsVersicherter As System.Windows.Forms.BindingSource
    Friend WithEvents taVersicherter As WindowsApplication1.VersicherungDataSetTableAdapters.VersicherterTableAdapter
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsToernname As System.Windows.Forms.BindingSource
    Friend WithEvents taToernname As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernnameTableAdapter
    Friend WithEvents dgvSchaden As System.Windows.Forms.DataGridView
    Friend WithEvents ToernbezeichnungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumVonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumBisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AusgangsmarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndeMarinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents PolizzeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TörnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersicherungsartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchadensbeschreibungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchadensnummerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchadensbetragDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BearbeiterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeamailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeaTelefonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchadensortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BelegKautionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BelegRepDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BelegDiebDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HafenkapiteanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersicherungCharterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersicherungGegnerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharterMeldungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkizzeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelfuehrungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WindrichtungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotorAnAusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursEigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KursGegnerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZeugenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArztbeschDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlugstornoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharterStornoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents cbSchadensschilderung As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxV As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxH As System.Windows.Forms.ListBox
    Friend WithEvents BAbruch As System.Windows.Forms.Button
    Friend WithEvents BZurueck As System.Windows.Forms.Button
    Friend WithEvents BLaden As System.Windows.Forms.Button
    Friend WithEvents TextBoxV As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxV As System.Windows.Forms.ListBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents gbFenster As System.Windows.Forms.GroupBox
    Friend WithEvents gbtoern As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioNeu As System.Windows.Forms.RadioButton
    Friend WithEvents gbNeu As System.Windows.Forms.GroupBox
    Friend WithEvents dgvversi As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersicherterName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abschlussdatum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GueltigBis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
End Class
