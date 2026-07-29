<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kalkulation))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.bsToernKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsToernverwaltung = New WindowsApplication1.ToernverwaltungDataSet()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Checkcharter = New System.Windows.Forms.CheckBox()
        Me.Checkvers = New System.Windows.Forms.CheckBox()
        Me.Checkkassa = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.VZnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlterersterToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StraßeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReisepassNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCrewAdressen = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinFlugNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HinFlugDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RueFlugNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RueFlugDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlugpreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutoanreisekostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinaanfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinarueckfahrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EinkaufstaxiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharterkostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnfallversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KautionsversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RücktrittsversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreibstoffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunkernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandmahlzeitenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarinakostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrewanzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BemerkungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeihwagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperVersicherungDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SkipperBordkassaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FlughafenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SonstigekostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrewanteilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AussenborderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndreinigungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rabatt2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperverdienstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernanfangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToernendeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reserve5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolgeschadenversicherungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StornoversicherungDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StornoPerzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BruttoChartVerAnteilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NettoChartVerAnteilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDToernDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.Button4Bearbeiten = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ButtonCrewSuchen = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CheckBox25 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.TextBox76 = New System.Windows.Forms.TextBox()
        Me.TextBox77 = New System.Windows.Forms.TextBox()
        Me.TextBox78 = New System.Windows.Forms.TextBox()
        Me.TextBox79 = New System.Windows.Forms.TextBox()
        Me.TextBox80 = New System.Windows.Forms.TextBox()
        Me.TextBox81 = New System.Windows.Forms.TextBox()
        Me.TextBox82 = New System.Windows.Forms.TextBox()
        Me.TextBox83 = New System.Windows.Forms.TextBox()
        Me.TextBox84 = New System.Windows.Forms.TextBox()
        Me.TextBox85 = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.MaskedTextBox25 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox26 = New System.Windows.Forms.MaskedTextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.MaskedTextBox23 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox24 = New System.Windows.Forms.MaskedTextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.MaskedTextBox21 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox22 = New System.Windows.Forms.MaskedTextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.MaskedTextBox19 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox20 = New System.Windows.Forms.MaskedTextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.MaskedTextBox17 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox18 = New System.Windows.Forms.MaskedTextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.MaskedTextBox15 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox16 = New System.Windows.Forms.MaskedTextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.MaskedTextBox13 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox14 = New System.Windows.Forms.MaskedTextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.MaskedTextBox11 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox12 = New System.Windows.Forms.MaskedTextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.MaskedTextBox9 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox10 = New System.Windows.Forms.MaskedTextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.MaskedTextBox8 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SpeichernButton = New System.Windows.Forms.Button()
        Me.LoeschenButton = New System.Windows.Forms.Button()
        Me.FormularButton = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.bsBootKalkulation = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ToernDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BootDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VZNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KostenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BezahltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.TextBox74 = New System.Windows.Forms.TextBox()
        Me.DsAusbildung = New WindowsApplication1.dsAusbildung()
        Me.ListboxDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsListdaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox75 = New System.Windows.Forms.TextBox()
        Me.CheckBox26 = New System.Windows.Forms.CheckBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.TextBox86 = New System.Windows.Forms.TextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.CheckBox37 = New System.Windows.Forms.CheckBox()
        Me.CheckBox38 = New System.Windows.Forms.CheckBox()
        Me.CheckBox39 = New System.Windows.Forms.CheckBox()
        Me.CheckBox40 = New System.Windows.Forms.CheckBox()
        Me.CheckBox41 = New System.Windows.Forms.CheckBox()
        Me.CheckBox42 = New System.Windows.Forms.CheckBox()
        Me.CheckBox43 = New System.Windows.Forms.CheckBox()
        Me.CheckBox44 = New System.Windows.Forms.CheckBox()
        Me.CheckBox45 = New System.Windows.Forms.CheckBox()
        Me.CheckBox46 = New System.Windows.Forms.CheckBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TextBox117 = New System.Windows.Forms.TextBox()
        Me.TextBox118 = New System.Windows.Forms.TextBox()
        Me.TextBox119 = New System.Windows.Forms.TextBox()
        Me.TextBox120 = New System.Windows.Forms.TextBox()
        Me.TextBox121 = New System.Windows.Forms.TextBox()
        Me.TextBox122 = New System.Windows.Forms.TextBox()
        Me.TextBox123 = New System.Windows.Forms.TextBox()
        Me.TextBox124 = New System.Windows.Forms.TextBox()
        Me.TextBox125 = New System.Windows.Forms.TextBox()
        Me.TextBox126 = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.TextBox107 = New System.Windows.Forms.TextBox()
        Me.TextBox108 = New System.Windows.Forms.TextBox()
        Me.TextBox109 = New System.Windows.Forms.TextBox()
        Me.TextBox110 = New System.Windows.Forms.TextBox()
        Me.TextBox111 = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.TextBox112 = New System.Windows.Forms.TextBox()
        Me.TextBox113 = New System.Windows.Forms.TextBox()
        Me.TextBox114 = New System.Windows.Forms.TextBox()
        Me.TextBox115 = New System.Windows.Forms.TextBox()
        Me.TextBox116 = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.TextBox87 = New System.Windows.Forms.TextBox()
        Me.TextBox88 = New System.Windows.Forms.TextBox()
        Me.TextBox89 = New System.Windows.Forms.TextBox()
        Me.TextBox90 = New System.Windows.Forms.TextBox()
        Me.TextBox91 = New System.Windows.Forms.TextBox()
        Me.TextBox92 = New System.Windows.Forms.TextBox()
        Me.TextBox93 = New System.Windows.Forms.TextBox()
        Me.TextBox94 = New System.Windows.Forms.TextBox()
        Me.TextBox95 = New System.Windows.Forms.TextBox()
        Me.TextBox96 = New System.Windows.Forms.TextBox()
        Me.TextBox97 = New System.Windows.Forms.TextBox()
        Me.TextBox98 = New System.Windows.Forms.TextBox()
        Me.TextBox99 = New System.Windows.Forms.TextBox()
        Me.TextBox100 = New System.Windows.Forms.TextBox()
        Me.TextBox101 = New System.Windows.Forms.TextBox()
        Me.TextBox102 = New System.Windows.Forms.TextBox()
        Me.TextBox103 = New System.Windows.Forms.TextBox()
        Me.TextBox104 = New System.Windows.Forms.TextBox()
        Me.TextBox105 = New System.Windows.Forms.TextBox()
        Me.TextBox106 = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.CheckBox27 = New System.Windows.Forms.CheckBox()
        Me.CheckBox28 = New System.Windows.Forms.CheckBox()
        Me.CheckBox29 = New System.Windows.Forms.CheckBox()
        Me.CheckBox30 = New System.Windows.Forms.CheckBox()
        Me.CheckBox31 = New System.Windows.Forms.CheckBox()
        Me.CheckBox32 = New System.Windows.Forms.CheckBox()
        Me.CheckBox33 = New System.Windows.Forms.CheckBox()
        Me.CheckBox34 = New System.Windows.Forms.CheckBox()
        Me.CheckBox35 = New System.Windows.Forms.CheckBox()
        Me.CheckBox36 = New System.Windows.Forms.CheckBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TextBox127 = New System.Windows.Forms.TextBox()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolizzeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsVersicherter = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsVersicherung = New WindowsApplication1.VersicherungDataSet()
        Me.bsVertrag = New System.Windows.Forms.BindingSource(Me.components)
        Me.taVertrag = New WindowsApplication1.VersicherungDataSetTableAdapters.VertragTableAdapter()
        Me.taVersicherter = New WindowsApplication1.VersicherungDataSetTableAdapters.VersicherterTableAdapter()
        Me.TextBox128 = New System.Windows.Forms.TextBox()
        Me.CheckBox47 = New System.Windows.Forms.CheckBox()
        Me.bsBoot = New System.Windows.Forms.BindingSource(Me.components)
        Me.taBoot = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter()
        Me.taBootKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootKalkulationTableAdapter()
        Me.taCrewAdressen = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter()
        Me.taListdaten = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ListdatenTableAdapter()
        Me.taToernKalkulation = New WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.bsBootKalkulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListboxDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsListdaten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfo.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVersicherter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVertrag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label89)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox9)
        Me.GroupBox1.Controls.Add(Me.PictureBox8)
        Me.GroupBox1.Controls.Add(Me.Label87)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox7)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox6)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.Label57)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.RichTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kalkulation der Törnkosten "
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(434, 91)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(68, 15)
        Me.Label89.TabIndex = 100
        Me.Label89.Text = "Co-Skipper"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "CoSkipper", True))
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bsToernKalkulation, "CoSkipper", True))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(512, 88)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(161, 23)
        Me.ComboBox3.TabIndex = 99
        '
        'bsToernKalkulation
        '
        Me.bsToernKalkulation.DataMember = "ToernKalkulation"
        Me.bsToernKalkulation.DataSource = Me.dsToernverwaltung
        '
        'dsToernverwaltung
        '
        Me.dsToernverwaltung.DataSetName = "ToernverwaltungDataSet"
        Me.dsToernverwaltung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(618, 164)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 98
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(315, 161)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 97
        Me.PictureBox8.TabStop = False
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(131, 10)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(0, 13)
        Me.Label87.TabIndex = 96
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(128, 28)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 95
        Me.PictureBox7.TabStop = False
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.Location = New System.Drawing.Point(512, 168)
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(101, 21)
        Me.MaskedTextBox7.TabIndex = 94
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Location = New System.Drawing.Point(200, 165)
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(101, 21)
        Me.MaskedTextBox6.TabIndex = 93
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(382, 171)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(124, 16)
        Me.Label58.TabIndex = 90
        Me.Label58.Text = "Datum Restzahlung"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(15, 171)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(105, 15)
        Me.Label57.TabIndex = 89
        Me.Label57.Text = "Datum Anzahlung"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bsToernKalkulation, "Skipper", True))
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Skipper", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(200, 87)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 23)
        Me.ComboBox2.TabIndex = 87
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(15, 87)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(49, 15)
        Me.Label52.TabIndex = 88
        Me.Label52.Text = "Skipper"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Route", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(200, 122)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(473, 36)
        Me.RichTextBox2.TabIndex = 85
        Me.RichTextBox2.Text = ""
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(15, 126)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(40, 15)
        Me.Label51.TabIndex = 86
        Me.Label51.Text = "Route"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(618, 57)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 84
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(315, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 81
        Me.PictureBox2.TabStop = False
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toernende", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(512, 62)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox4.TabIndex = 4
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toernanfang", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(200, 61)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(101, 21)
        Me.MaskedTextBox3.TabIndex = 3
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(479, 61)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(23, 15)
        Me.Label49.TabIndex = 80
        Me.Label49.Text = "bis"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(15, 61)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(26, 15)
        Me.Label48.TabIndex = 79
        Me.Label48.Text = "von"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(164, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsToernKalkulation, "Boot", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bsToernKalkulation, "Boot", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Boot", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(512, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 23)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Toern", True))
        Me.TextBox2.Location = New System.Drawing.Point(200, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(250, 21)
        Me.TextBox2.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(15, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 15)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Törnbezeichnung"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(470, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 15)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "Boot"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(264, 305)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 219)
        Me.GroupBox4.TabIndex = 86
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 17)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 86
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 26)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Zurück"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(87, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 27)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(646, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 83
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(646, 59)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 82
        Me.PictureBox3.TabStop = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(449, 47)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(101, 16)
        Me.Label46.TabIndex = 78
        Me.Label46.Text = "3 Person / PKW"
        '
        'TextBox61
        '
        Me.TextBox61.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Autoanreisekosten", True))
        Me.TextBox61.Location = New System.Drawing.Point(1338, 525)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(84, 20)
        Me.TextBox61.TabIndex = 18
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(274, 47)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(74, 16)
        Me.Label44.TabIndex = 75
        Me.Label44.Text = "pro Person"
        '
        'TextBox60
        '
        Me.TextBox60.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Permit", True))
        Me.TextBox60.Location = New System.Drawing.Point(353, 69)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(90, 22)
        Me.TextBox60.TabIndex = 26
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.Blue
        Me.Label43.Location = New System.Drawing.Point(272, 74)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 16)
        Me.Label43.TabIndex = 73
        Me.Label43.Text = "Permit"
        '
        'TextBox57
        '
        Me.TextBox57.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Aussenborder", True))
        Me.TextBox57.Location = New System.Drawing.Point(592, 71)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(89, 22)
        Me.TextBox57.TabIndex = 27
        '
        'TextBox56
        '
        Me.TextBox56.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Endreinigung", True))
        Me.TextBox56.Location = New System.Drawing.Point(133, 71)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(90, 22)
        Me.TextBox56.TabIndex = 25
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.Blue
        Me.Label40.Location = New System.Drawing.Point(485, 74)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(93, 16)
        Me.Label40.TabIndex = 66
        Me.Label40.Text = "Aussenborder"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Blue
        Me.Label39.Location = New System.Drawing.Point(12, 73)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(87, 16)
        Me.Label39.TabIndex = 65
        Me.Label39.Text = "Endreinigung"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "RueFlugDatum", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(550, 56)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(88, 22)
        Me.MaskedTextBox2.TabIndex = 13
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "HinFlugDatum", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(549, 32)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(91, 22)
        Me.MaskedTextBox1.TabIndex = 10
        '
        'TextBox25
        '
        Me.TextBox25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Rücktrittsversicherung", True))
        Me.TextBox25.Location = New System.Drawing.Point(579, 54)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(94, 22)
        Me.TextBox25.TabIndex = 33
        '
        'TextBox24
        '
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Haftpflichtversicherung", True))
        Me.TextBox24.Location = New System.Drawing.Point(579, 26)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(93, 22)
        Me.TextBox24.TabIndex = 30
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Kautionsversicherung", True))
        Me.TextBox23.Location = New System.Drawing.Point(343, 54)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(89, 22)
        Me.TextBox23.TabIndex = 32
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Unfallversicherung", True))
        Me.TextBox22.Location = New System.Drawing.Point(343, 29)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(89, 22)
        Me.TextBox22.TabIndex = 29
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Beschlagnahmerisiko", True))
        Me.TextBox21.Location = New System.Drawing.Point(123, 51)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(89, 22)
        Me.TextBox21.TabIndex = 31
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Rechtsschutzversicherung", True))
        Me.TextBox20.Location = New System.Drawing.Point(123, 26)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(90, 22)
        Me.TextBox20.TabIndex = 28
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Sonstigekosten", True))
        Me.TextBox19.Location = New System.Drawing.Point(592, 46)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(90, 22)
        Me.TextBox19.TabIndex = 24
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Marinakosten", True))
        Me.TextBox18.Location = New System.Drawing.Point(592, 19)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(89, 22)
        Me.TextBox18.TabIndex = 21
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Treibstoff", True))
        Me.TextBox17.Location = New System.Drawing.Point(354, 44)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(89, 22)
        Me.TextBox17.TabIndex = 23
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Bunkern", True))
        Me.TextBox16.Location = New System.Drawing.Point(354, 19)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(89, 22)
        Me.TextBox16.TabIndex = 20
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Landmahlzeiten", True))
        Me.TextBox15.Location = New System.Drawing.Point(135, 46)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(90, 22)
        Me.TextBox15.TabIndex = 22
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Einkaufstaxi", True))
        Me.TextBox14.Location = New System.Drawing.Point(134, 19)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(90, 22)
        Me.TextBox14.TabIndex = 19
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Leihwagen", True))
        Me.TextBox11.Location = New System.Drawing.Point(549, 83)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(89, 22)
        Me.TextBox11.TabIndex = 16
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Marinarueckfahrt", True))
        Me.TextBox10.Location = New System.Drawing.Point(337, 86)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(89, 22)
        Me.TextBox10.TabIndex = 15
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "RueFlugNr", True))
        Me.TextBox9.Location = New System.Drawing.Point(338, 59)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(89, 22)
        Me.TextBox9.TabIndex = 12
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "HinFlugNr", True))
        Me.TextBox8.Location = New System.Drawing.Point(338, 32)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(89, 22)
        Me.TextBox8.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Reserve3", True))
        Me.TextBox7.Location = New System.Drawing.Point(193, 44)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(67, 22)
        Me.TextBox7.TabIndex = 17
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Marinaanfahrt", True))
        Me.TextBox6.Location = New System.Drawing.Point(154, 85)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(67, 22)
        Me.TextBox6.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Flugpreis", True))
        Me.TextBox5.Location = New System.Drawing.Point(154, 58)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(67, 22)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Flughafen", True))
        Me.TextBox4.Location = New System.Drawing.Point(93, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 22)
        Me.TextBox4.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(485, 51)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 16)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "Sonstiges"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(484, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Marinakosten"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(268, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 16)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Bunkern"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Land Essen"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(266, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Treibstoff"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(468, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Rücktritt (Storno)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(2, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Beschlagnahme"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(257, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Kaution"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Rechtschutz"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(471, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Haftpflicht"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(257, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Crew Unfall"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(441, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Leihwagen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Autoanreise  km  *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Einkaufstaxi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(251, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "und zurück"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Flughafen - Marina"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Flugpreis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rückflug Datum"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rückflug Nr."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hinflug Datum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hinflug Nr."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flughafen"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(188, 16)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Crew Anzahl ohne Skipper"
        '
        'Checkcharter
        '
        Me.Checkcharter.AutoSize = True
        Me.Checkcharter.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsToernKalkulation, "SkipperCharterkosten", True))
        Me.Checkcharter.Location = New System.Drawing.Point(13, 37)
        Me.Checkcharter.Name = "Checkcharter"
        Me.Checkcharter.Size = New System.Drawing.Size(128, 20)
        Me.Checkcharter.TabIndex = 35
        Me.Checkcharter.Text = "an Charterkosten"
        Me.Checkcharter.UseVisualStyleBackColor = True
        '
        'Checkvers
        '
        Me.Checkvers.AutoSize = True
        Me.Checkvers.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsToernKalkulation, "SkipperVersicherung", True))
        Me.Checkvers.Location = New System.Drawing.Point(13, 57)
        Me.Checkvers.Name = "Checkvers"
        Me.Checkvers.Size = New System.Drawing.Size(139, 20)
        Me.Checkvers.TabIndex = 36
        Me.Checkvers.Text = "an Versicherungen"
        Me.Checkvers.UseVisualStyleBackColor = True
        '
        'Checkkassa
        '
        Me.Checkkassa.AutoSize = True
        Me.Checkkassa.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsToernKalkulation, "SkipperBordkassa", True))
        Me.Checkkassa.Location = New System.Drawing.Point(13, 77)
        Me.Checkkassa.Name = "Checkkassa"
        Me.Checkkassa.Size = New System.Drawing.Size(111, 20)
        Me.Checkkassa.TabIndex = 37
        Me.Checkkassa.Text = "an Bordkassa"
        Me.Checkkassa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView3)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 418)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(685, 202)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VZnameDataGridViewTextBoxColumn1, Me.ZunameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.HandyDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ToernnrDataGridViewTextBoxColumn, Me.AlterersterToernDataGridViewTextBoxColumn, Me.StraßeDataGridViewTextBoxColumn, Me.PlzDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.ReisepassNrDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.bsCrewAdressen
        Me.DataGridView3.Location = New System.Drawing.Point(69, 58)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(674, 170)
        Me.DataGridView3.TabIndex = 3
        '
        'VZnameDataGridViewTextBoxColumn1
        '
        Me.VZnameDataGridViewTextBoxColumn1.DataPropertyName = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.HeaderText = "VZname"
        Me.VZnameDataGridViewTextBoxColumn1.Name = "VZnameDataGridViewTextBoxColumn1"
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
        'BemerkungDataGridViewTextBoxColumn1
        '
        Me.BemerkungDataGridViewTextBoxColumn1.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn1.Name = "BemerkungDataGridViewTextBoxColumn1"
        '
        'bsCrewAdressen
        '
        Me.bsCrewAdressen.DataMember = "CrewAdressen"
        Me.bsCrewAdressen.DataSource = Me.dsToernverwaltung
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernDataGridViewTextBoxColumn, Me.BootDataGridViewTextBoxColumn, Me.HinFlugNrDataGridViewTextBoxColumn, Me.HinFlugDatumDataGridViewTextBoxColumn, Me.RueFlugNrDataGridViewTextBoxColumn, Me.RueFlugDatumDataGridViewTextBoxColumn, Me.FlugpreisDataGridViewTextBoxColumn, Me.AutoanreisekostenDataGridViewTextBoxColumn, Me.MarinaanfahrtDataGridViewTextBoxColumn, Me.MarinarueckfahrtDataGridViewTextBoxColumn, Me.EinkaufstaxiDataGridViewTextBoxColumn, Me.CharterkostenDataGridViewTextBoxColumn, Me.HaftpflichtversicherungDataGridViewTextBoxColumn, Me.UnfallversicherungDataGridViewTextBoxColumn, Me.RechtsschutzversicherungDataGridViewTextBoxColumn, Me.BeschlagnahmerisikoDataGridViewTextBoxColumn, Me.KautionsversicherungDataGridViewTextBoxColumn, Me.RücktrittsversicherungDataGridViewTextBoxColumn, Me.TreibstoffDataGridViewTextBoxColumn, Me.BunkernDataGridViewTextBoxColumn, Me.LandmahlzeitenDataGridViewTextBoxColumn, Me.MarinakostenDataGridViewTextBoxColumn, Me.CrewanzahlDataGridViewTextBoxColumn, Me.BemerkungDataGridViewTextBoxColumn, Me.LeihwagenDataGridViewTextBoxColumn, Me.SkipperVersicherungDataGridViewCheckBoxColumn, Me.SkipperCharterkostenDataGridViewCheckBoxColumn, Me.SkipperBordkassaDataGridViewCheckBoxColumn, Me.FlughafenDataGridViewTextBoxColumn, Me.SonstigekostenDataGridViewTextBoxColumn, Me.CrewanteilDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.AussenborderDataGridViewTextBoxColumn, Me.EndreinigungDataGridViewTextBoxColumn, Me.Rabatt1DataGridViewTextBoxColumn, Me.Rabatt2DataGridViewTextBoxColumn, Me.PermitDataGridViewTextBoxColumn, Me.SkipperverdienstDataGridViewTextBoxColumn, Me.ToernanfangDataGridViewTextBoxColumn, Me.ToernendeDataGridViewTextBoxColumn, Me.SkipperDataGridViewTextBoxColumn, Me.RouteDataGridViewTextBoxColumn, Me.Reserve1DataGridViewTextBoxColumn, Me.Reserve2DataGridViewTextBoxColumn, Me.Reserve3DataGridViewTextBoxColumn, Me.Reserve4DataGridViewTextBoxColumn, Me.Reserve5DataGridViewTextBoxColumn, Me.FolgeschadenversicherungDataGridViewTextBoxColumn, Me.StornoversicherungDataGridViewCheckBoxColumn, Me.StornoPerzDataGridViewTextBoxColumn, Me.BruttoChartVerAnteilDataGridViewTextBoxColumn, Me.NettoChartVerAnteilDataGridViewTextBoxColumn, Me.IDToernDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsToernKalkulation
        Me.DataGridView1.Location = New System.Drawing.Point(12, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(673, 170)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'ToernDataGridViewTextBoxColumn
        '
        Me.ToernDataGridViewTextBoxColumn.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn.Name = "ToernDataGridViewTextBoxColumn"
        Me.ToernDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BootDataGridViewTextBoxColumn
        '
        Me.BootDataGridViewTextBoxColumn.DataPropertyName = "Boot"
        Me.BootDataGridViewTextBoxColumn.HeaderText = "Boot"
        Me.BootDataGridViewTextBoxColumn.Name = "BootDataGridViewTextBoxColumn"
        Me.BootDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HinFlugNrDataGridViewTextBoxColumn
        '
        Me.HinFlugNrDataGridViewTextBoxColumn.DataPropertyName = "HinFlugNr"
        Me.HinFlugNrDataGridViewTextBoxColumn.HeaderText = "HinFlugNr"
        Me.HinFlugNrDataGridViewTextBoxColumn.Name = "HinFlugNrDataGridViewTextBoxColumn"
        Me.HinFlugNrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HinFlugDatumDataGridViewTextBoxColumn
        '
        Me.HinFlugDatumDataGridViewTextBoxColumn.DataPropertyName = "HinFlugDatum"
        Me.HinFlugDatumDataGridViewTextBoxColumn.HeaderText = "HinFlugDatum"
        Me.HinFlugDatumDataGridViewTextBoxColumn.Name = "HinFlugDatumDataGridViewTextBoxColumn"
        Me.HinFlugDatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RueFlugNrDataGridViewTextBoxColumn
        '
        Me.RueFlugNrDataGridViewTextBoxColumn.DataPropertyName = "RueFlugNr"
        Me.RueFlugNrDataGridViewTextBoxColumn.HeaderText = "RueFlugNr"
        Me.RueFlugNrDataGridViewTextBoxColumn.Name = "RueFlugNrDataGridViewTextBoxColumn"
        Me.RueFlugNrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RueFlugDatumDataGridViewTextBoxColumn
        '
        Me.RueFlugDatumDataGridViewTextBoxColumn.DataPropertyName = "RueFlugDatum"
        Me.RueFlugDatumDataGridViewTextBoxColumn.HeaderText = "RueFlugDatum"
        Me.RueFlugDatumDataGridViewTextBoxColumn.Name = "RueFlugDatumDataGridViewTextBoxColumn"
        Me.RueFlugDatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FlugpreisDataGridViewTextBoxColumn
        '
        Me.FlugpreisDataGridViewTextBoxColumn.DataPropertyName = "Flugpreis"
        Me.FlugpreisDataGridViewTextBoxColumn.HeaderText = "Flugpreis"
        Me.FlugpreisDataGridViewTextBoxColumn.Name = "FlugpreisDataGridViewTextBoxColumn"
        Me.FlugpreisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutoanreisekostenDataGridViewTextBoxColumn
        '
        Me.AutoanreisekostenDataGridViewTextBoxColumn.DataPropertyName = "Autoanreisekosten"
        Me.AutoanreisekostenDataGridViewTextBoxColumn.HeaderText = "Autoanreisekosten"
        Me.AutoanreisekostenDataGridViewTextBoxColumn.Name = "AutoanreisekostenDataGridViewTextBoxColumn"
        Me.AutoanreisekostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarinaanfahrtDataGridViewTextBoxColumn
        '
        Me.MarinaanfahrtDataGridViewTextBoxColumn.DataPropertyName = "Marinaanfahrt"
        Me.MarinaanfahrtDataGridViewTextBoxColumn.HeaderText = "Marinaanfahrt"
        Me.MarinaanfahrtDataGridViewTextBoxColumn.Name = "MarinaanfahrtDataGridViewTextBoxColumn"
        Me.MarinaanfahrtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarinarueckfahrtDataGridViewTextBoxColumn
        '
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.DataPropertyName = "Marinarueckfahrt"
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.HeaderText = "Marinarueckfahrt"
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.Name = "MarinarueckfahrtDataGridViewTextBoxColumn"
        Me.MarinarueckfahrtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EinkaufstaxiDataGridViewTextBoxColumn
        '
        Me.EinkaufstaxiDataGridViewTextBoxColumn.DataPropertyName = "Einkaufstaxi"
        Me.EinkaufstaxiDataGridViewTextBoxColumn.HeaderText = "Einkaufstaxi"
        Me.EinkaufstaxiDataGridViewTextBoxColumn.Name = "EinkaufstaxiDataGridViewTextBoxColumn"
        Me.EinkaufstaxiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CharterkostenDataGridViewTextBoxColumn
        '
        Me.CharterkostenDataGridViewTextBoxColumn.DataPropertyName = "Charterkosten"
        Me.CharterkostenDataGridViewTextBoxColumn.HeaderText = "Charterkosten"
        Me.CharterkostenDataGridViewTextBoxColumn.Name = "CharterkostenDataGridViewTextBoxColumn"
        Me.CharterkostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HaftpflichtversicherungDataGridViewTextBoxColumn
        '
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.DataPropertyName = "Haftpflichtversicherung"
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.HeaderText = "Haftpflichtversicherung"
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.Name = "HaftpflichtversicherungDataGridViewTextBoxColumn"
        Me.HaftpflichtversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnfallversicherungDataGridViewTextBoxColumn
        '
        Me.UnfallversicherungDataGridViewTextBoxColumn.DataPropertyName = "Unfallversicherung"
        Me.UnfallversicherungDataGridViewTextBoxColumn.HeaderText = "Unfallversicherung"
        Me.UnfallversicherungDataGridViewTextBoxColumn.Name = "UnfallversicherungDataGridViewTextBoxColumn"
        Me.UnfallversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RechtsschutzversicherungDataGridViewTextBoxColumn
        '
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.DataPropertyName = "Rechtsschutzversicherung"
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.HeaderText = "Rechtsschutzversicherung"
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.Name = "RechtsschutzversicherungDataGridViewTextBoxColumn"
        Me.RechtsschutzversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BeschlagnahmerisikoDataGridViewTextBoxColumn
        '
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.DataPropertyName = "Beschlagnahmerisiko"
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.HeaderText = "Beschlagnahmerisiko"
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.Name = "BeschlagnahmerisikoDataGridViewTextBoxColumn"
        Me.BeschlagnahmerisikoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KautionsversicherungDataGridViewTextBoxColumn
        '
        Me.KautionsversicherungDataGridViewTextBoxColumn.DataPropertyName = "Kautionsversicherung"
        Me.KautionsversicherungDataGridViewTextBoxColumn.HeaderText = "Kautionsversicherung"
        Me.KautionsversicherungDataGridViewTextBoxColumn.Name = "KautionsversicherungDataGridViewTextBoxColumn"
        Me.KautionsversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RücktrittsversicherungDataGridViewTextBoxColumn
        '
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.DataPropertyName = "Rücktrittsversicherung"
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.HeaderText = "Rücktrittsversicherung"
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.Name = "RücktrittsversicherungDataGridViewTextBoxColumn"
        Me.RücktrittsversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TreibstoffDataGridViewTextBoxColumn
        '
        Me.TreibstoffDataGridViewTextBoxColumn.DataPropertyName = "Treibstoff"
        Me.TreibstoffDataGridViewTextBoxColumn.HeaderText = "Treibstoff"
        Me.TreibstoffDataGridViewTextBoxColumn.Name = "TreibstoffDataGridViewTextBoxColumn"
        Me.TreibstoffDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BunkernDataGridViewTextBoxColumn
        '
        Me.BunkernDataGridViewTextBoxColumn.DataPropertyName = "Bunkern"
        Me.BunkernDataGridViewTextBoxColumn.HeaderText = "Bunkern"
        Me.BunkernDataGridViewTextBoxColumn.Name = "BunkernDataGridViewTextBoxColumn"
        Me.BunkernDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LandmahlzeitenDataGridViewTextBoxColumn
        '
        Me.LandmahlzeitenDataGridViewTextBoxColumn.DataPropertyName = "Landmahlzeiten"
        Me.LandmahlzeitenDataGridViewTextBoxColumn.HeaderText = "Landmahlzeiten"
        Me.LandmahlzeitenDataGridViewTextBoxColumn.Name = "LandmahlzeitenDataGridViewTextBoxColumn"
        Me.LandmahlzeitenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarinakostenDataGridViewTextBoxColumn
        '
        Me.MarinakostenDataGridViewTextBoxColumn.DataPropertyName = "Marinakosten"
        Me.MarinakostenDataGridViewTextBoxColumn.HeaderText = "Marinakosten"
        Me.MarinakostenDataGridViewTextBoxColumn.Name = "MarinakostenDataGridViewTextBoxColumn"
        Me.MarinakostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CrewanzahlDataGridViewTextBoxColumn
        '
        Me.CrewanzahlDataGridViewTextBoxColumn.DataPropertyName = "Crewanzahl"
        Me.CrewanzahlDataGridViewTextBoxColumn.HeaderText = "Crewanzahl"
        Me.CrewanzahlDataGridViewTextBoxColumn.Name = "CrewanzahlDataGridViewTextBoxColumn"
        Me.CrewanzahlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BemerkungDataGridViewTextBoxColumn
        '
        Me.BemerkungDataGridViewTextBoxColumn.DataPropertyName = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.HeaderText = "Bemerkung"
        Me.BemerkungDataGridViewTextBoxColumn.Name = "BemerkungDataGridViewTextBoxColumn"
        Me.BemerkungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeihwagenDataGridViewTextBoxColumn
        '
        Me.LeihwagenDataGridViewTextBoxColumn.DataPropertyName = "Leihwagen"
        Me.LeihwagenDataGridViewTextBoxColumn.HeaderText = "Leihwagen"
        Me.LeihwagenDataGridViewTextBoxColumn.Name = "LeihwagenDataGridViewTextBoxColumn"
        Me.LeihwagenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SkipperVersicherungDataGridViewCheckBoxColumn
        '
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.DataPropertyName = "SkipperVersicherung"
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.HeaderText = "SkipperVersicherung"
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.Name = "SkipperVersicherungDataGridViewCheckBoxColumn"
        Me.SkipperVersicherungDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SkipperCharterkostenDataGridViewCheckBoxColumn
        '
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.DataPropertyName = "SkipperCharterkosten"
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.HeaderText = "SkipperCharterkosten"
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.Name = "SkipperCharterkostenDataGridViewCheckBoxColumn"
        Me.SkipperCharterkostenDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SkipperBordkassaDataGridViewCheckBoxColumn
        '
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.DataPropertyName = "SkipperBordkassa"
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.HeaderText = "SkipperBordkassa"
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.Name = "SkipperBordkassaDataGridViewCheckBoxColumn"
        Me.SkipperBordkassaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FlughafenDataGridViewTextBoxColumn
        '
        Me.FlughafenDataGridViewTextBoxColumn.DataPropertyName = "Flughafen"
        Me.FlughafenDataGridViewTextBoxColumn.HeaderText = "Flughafen"
        Me.FlughafenDataGridViewTextBoxColumn.Name = "FlughafenDataGridViewTextBoxColumn"
        Me.FlughafenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SonstigekostenDataGridViewTextBoxColumn
        '
        Me.SonstigekostenDataGridViewTextBoxColumn.DataPropertyName = "Sonstigekosten"
        Me.SonstigekostenDataGridViewTextBoxColumn.HeaderText = "Sonstigekosten"
        Me.SonstigekostenDataGridViewTextBoxColumn.Name = "SonstigekostenDataGridViewTextBoxColumn"
        Me.SonstigekostenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CrewanteilDataGridViewTextBoxColumn
        '
        Me.CrewanteilDataGridViewTextBoxColumn.DataPropertyName = "Crewanteil"
        Me.CrewanteilDataGridViewTextBoxColumn.HeaderText = "Crewanteil"
        Me.CrewanteilDataGridViewTextBoxColumn.Name = "CrewanteilDataGridViewTextBoxColumn"
        Me.CrewanteilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AussenborderDataGridViewTextBoxColumn
        '
        Me.AussenborderDataGridViewTextBoxColumn.DataPropertyName = "Aussenborder"
        Me.AussenborderDataGridViewTextBoxColumn.HeaderText = "Aussenborder"
        Me.AussenborderDataGridViewTextBoxColumn.Name = "AussenborderDataGridViewTextBoxColumn"
        Me.AussenborderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndreinigungDataGridViewTextBoxColumn
        '
        Me.EndreinigungDataGridViewTextBoxColumn.DataPropertyName = "Endreinigung"
        Me.EndreinigungDataGridViewTextBoxColumn.HeaderText = "Endreinigung"
        Me.EndreinigungDataGridViewTextBoxColumn.Name = "EndreinigungDataGridViewTextBoxColumn"
        Me.EndreinigungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Rabatt1DataGridViewTextBoxColumn
        '
        Me.Rabatt1DataGridViewTextBoxColumn.DataPropertyName = "Rabatt1"
        Me.Rabatt1DataGridViewTextBoxColumn.HeaderText = "Rabatt1"
        Me.Rabatt1DataGridViewTextBoxColumn.Name = "Rabatt1DataGridViewTextBoxColumn"
        Me.Rabatt1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Rabatt2DataGridViewTextBoxColumn
        '
        Me.Rabatt2DataGridViewTextBoxColumn.DataPropertyName = "Rabatt2"
        Me.Rabatt2DataGridViewTextBoxColumn.HeaderText = "Rabatt2"
        Me.Rabatt2DataGridViewTextBoxColumn.Name = "Rabatt2DataGridViewTextBoxColumn"
        Me.Rabatt2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PermitDataGridViewTextBoxColumn
        '
        Me.PermitDataGridViewTextBoxColumn.DataPropertyName = "Permit"
        Me.PermitDataGridViewTextBoxColumn.HeaderText = "Permit"
        Me.PermitDataGridViewTextBoxColumn.Name = "PermitDataGridViewTextBoxColumn"
        Me.PermitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SkipperverdienstDataGridViewTextBoxColumn
        '
        Me.SkipperverdienstDataGridViewTextBoxColumn.DataPropertyName = "Skipperverdienst"
        Me.SkipperverdienstDataGridViewTextBoxColumn.HeaderText = "Skipperverdienst"
        Me.SkipperverdienstDataGridViewTextBoxColumn.Name = "SkipperverdienstDataGridViewTextBoxColumn"
        Me.SkipperverdienstDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToernanfangDataGridViewTextBoxColumn
        '
        Me.ToernanfangDataGridViewTextBoxColumn.DataPropertyName = "Toernanfang"
        Me.ToernanfangDataGridViewTextBoxColumn.HeaderText = "Toernanfang"
        Me.ToernanfangDataGridViewTextBoxColumn.Name = "ToernanfangDataGridViewTextBoxColumn"
        Me.ToernanfangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToernendeDataGridViewTextBoxColumn
        '
        Me.ToernendeDataGridViewTextBoxColumn.DataPropertyName = "Toernende"
        Me.ToernendeDataGridViewTextBoxColumn.HeaderText = "Toernende"
        Me.ToernendeDataGridViewTextBoxColumn.Name = "ToernendeDataGridViewTextBoxColumn"
        Me.ToernendeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SkipperDataGridViewTextBoxColumn
        '
        Me.SkipperDataGridViewTextBoxColumn.DataPropertyName = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.HeaderText = "Skipper"
        Me.SkipperDataGridViewTextBoxColumn.Name = "SkipperDataGridViewTextBoxColumn"
        Me.SkipperDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RouteDataGridViewTextBoxColumn
        '
        Me.RouteDataGridViewTextBoxColumn.DataPropertyName = "Route"
        Me.RouteDataGridViewTextBoxColumn.HeaderText = "Route"
        Me.RouteDataGridViewTextBoxColumn.Name = "RouteDataGridViewTextBoxColumn"
        Me.RouteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Reserve1DataGridViewTextBoxColumn
        '
        Me.Reserve1DataGridViewTextBoxColumn.DataPropertyName = "Reserve1"
        Me.Reserve1DataGridViewTextBoxColumn.HeaderText = "Reserve1"
        Me.Reserve1DataGridViewTextBoxColumn.Name = "Reserve1DataGridViewTextBoxColumn"
        Me.Reserve1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Reserve2DataGridViewTextBoxColumn
        '
        Me.Reserve2DataGridViewTextBoxColumn.DataPropertyName = "Reserve2"
        Me.Reserve2DataGridViewTextBoxColumn.HeaderText = "Reserve2"
        Me.Reserve2DataGridViewTextBoxColumn.Name = "Reserve2DataGridViewTextBoxColumn"
        Me.Reserve2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Reserve3DataGridViewTextBoxColumn
        '
        Me.Reserve3DataGridViewTextBoxColumn.DataPropertyName = "Reserve3"
        Me.Reserve3DataGridViewTextBoxColumn.HeaderText = "Reserve3"
        Me.Reserve3DataGridViewTextBoxColumn.Name = "Reserve3DataGridViewTextBoxColumn"
        Me.Reserve3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Reserve4DataGridViewTextBoxColumn
        '
        Me.Reserve4DataGridViewTextBoxColumn.DataPropertyName = "Reserve4"
        Me.Reserve4DataGridViewTextBoxColumn.HeaderText = "Reserve4"
        Me.Reserve4DataGridViewTextBoxColumn.Name = "Reserve4DataGridViewTextBoxColumn"
        Me.Reserve4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Reserve5DataGridViewTextBoxColumn
        '
        Me.Reserve5DataGridViewTextBoxColumn.DataPropertyName = "Reserve5"
        Me.Reserve5DataGridViewTextBoxColumn.HeaderText = "Reserve5"
        Me.Reserve5DataGridViewTextBoxColumn.Name = "Reserve5DataGridViewTextBoxColumn"
        Me.Reserve5DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FolgeschadenversicherungDataGridViewTextBoxColumn
        '
        Me.FolgeschadenversicherungDataGridViewTextBoxColumn.DataPropertyName = "Folgeschadenversicherung"
        Me.FolgeschadenversicherungDataGridViewTextBoxColumn.HeaderText = "Folgeschadenversicherung"
        Me.FolgeschadenversicherungDataGridViewTextBoxColumn.Name = "FolgeschadenversicherungDataGridViewTextBoxColumn"
        Me.FolgeschadenversicherungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StornoversicherungDataGridViewCheckBoxColumn
        '
        Me.StornoversicherungDataGridViewCheckBoxColumn.DataPropertyName = "Stornoversicherung"
        Me.StornoversicherungDataGridViewCheckBoxColumn.HeaderText = "Stornoversicherung"
        Me.StornoversicherungDataGridViewCheckBoxColumn.Name = "StornoversicherungDataGridViewCheckBoxColumn"
        Me.StornoversicherungDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'StornoPerzDataGridViewTextBoxColumn
        '
        Me.StornoPerzDataGridViewTextBoxColumn.DataPropertyName = "StornoPerz"
        Me.StornoPerzDataGridViewTextBoxColumn.HeaderText = "StornoPerz"
        Me.StornoPerzDataGridViewTextBoxColumn.Name = "StornoPerzDataGridViewTextBoxColumn"
        Me.StornoPerzDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BruttoChartVerAnteilDataGridViewTextBoxColumn
        '
        Me.BruttoChartVerAnteilDataGridViewTextBoxColumn.DataPropertyName = "BruttoChartVerAnteil"
        Me.BruttoChartVerAnteilDataGridViewTextBoxColumn.HeaderText = "BruttoChartVerAnteil"
        Me.BruttoChartVerAnteilDataGridViewTextBoxColumn.Name = "BruttoChartVerAnteilDataGridViewTextBoxColumn"
        Me.BruttoChartVerAnteilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NettoChartVerAnteilDataGridViewTextBoxColumn
        '
        Me.NettoChartVerAnteilDataGridViewTextBoxColumn.DataPropertyName = "NettoChartVerAnteil"
        Me.NettoChartVerAnteilDataGridViewTextBoxColumn.HeaderText = "NettoChartVerAnteil"
        Me.NettoChartVerAnteilDataGridViewTextBoxColumn.Name = "NettoChartVerAnteilDataGridViewTextBoxColumn"
        Me.NettoChartVerAnteilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDToernDataGridViewTextBoxColumn
        '
        Me.IDToernDataGridViewTextBoxColumn.DataPropertyName = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.HeaderText = "IDToern"
        Me.IDToernDataGridViewTextBoxColumn.Name = "IDToernDataGridViewTextBoxColumn"
        Me.IDToernDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Bemerkung", True))
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 20)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(665, 169)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox13)
        Me.GroupBox3.Controls.Add(Me.GroupBox12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(705, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 482)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Crew"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.TextBox45)
        Me.GroupBox13.Controls.Add(Me.TextBox43)
        Me.GroupBox13.Controls.Add(Me.TextBox41)
        Me.GroupBox13.Controls.Add(Me.TextBox39)
        Me.GroupBox13.Controls.Add(Me.TextBox37)
        Me.GroupBox13.Controls.Add(Me.TextBox35)
        Me.GroupBox13.Controls.Add(Me.TextBox28)
        Me.GroupBox13.Controls.Add(Me.TextBox33)
        Me.GroupBox13.Controls.Add(Me.TextBox29)
        Me.GroupBox13.Controls.Add(Me.TextBox31)
        Me.GroupBox13.Controls.Add(Me.TextBox46)
        Me.GroupBox13.Controls.Add(Me.TextBox44)
        Me.GroupBox13.Controls.Add(Me.TextBox42)
        Me.GroupBox13.Controls.Add(Me.TextBox40)
        Me.GroupBox13.Controls.Add(Me.TextBox38)
        Me.GroupBox13.Controls.Add(Me.TextBox36)
        Me.GroupBox13.Controls.Add(Me.TextBox34)
        Me.GroupBox13.Controls.Add(Me.TextBox32)
        Me.GroupBox13.Controls.Add(Me.TextBox30)
        Me.GroupBox13.Controls.Add(Me.TextBox27)
        Me.GroupBox13.Controls.Add(Me.Button4Bearbeiten)
        Me.GroupBox13.Controls.Add(Me.Label38)
        Me.GroupBox13.Controls.Add(Me.Label37)
        Me.GroupBox13.Controls.Add(Me.ButtonCrewSuchen)
        Me.GroupBox13.Controls.Add(Me.Button3)
        Me.GroupBox13.Controls.Add(Me.CheckBox1)
        Me.GroupBox13.Controls.Add(Me.CheckBox2)
        Me.GroupBox13.Controls.Add(Me.CheckBox3)
        Me.GroupBox13.Controls.Add(Me.CheckBox4)
        Me.GroupBox13.Controls.Add(Me.CheckBox5)
        Me.GroupBox13.Controls.Add(Me.CheckBox6)
        Me.GroupBox13.Controls.Add(Me.CheckBox7)
        Me.GroupBox13.Controls.Add(Me.CheckBox8)
        Me.GroupBox13.Controls.Add(Me.CheckBox9)
        Me.GroupBox13.Controls.Add(Me.CheckBox10)
        Me.GroupBox13.Controls.Add(Me.Label34)
        Me.GroupBox13.Location = New System.Drawing.Point(9, 129)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(272, 353)
        Me.GroupBox13.TabIndex = 100
        Me.GroupBox13.TabStop = False
        '
        'TextBox45
        '
        Me.TextBox45.Location = New System.Drawing.Point(214, 323)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(55, 22)
        Me.TextBox45.TabIndex = 128
        Me.TextBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox43
        '
        Me.TextBox43.Location = New System.Drawing.Point(214, 297)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(55, 22)
        Me.TextBox43.TabIndex = 127
        Me.TextBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox41
        '
        Me.TextBox41.Location = New System.Drawing.Point(214, 271)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(55, 22)
        Me.TextBox41.TabIndex = 126
        Me.TextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox39
        '
        Me.TextBox39.Location = New System.Drawing.Point(214, 245)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(55, 22)
        Me.TextBox39.TabIndex = 125
        Me.TextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox37
        '
        Me.TextBox37.Location = New System.Drawing.Point(214, 219)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(55, 22)
        Me.TextBox37.TabIndex = 124
        Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(214, 192)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(55, 22)
        Me.TextBox35.TabIndex = 123
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(214, 88)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(55, 22)
        Me.TextBox28.TabIndex = 119
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(214, 167)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(55, 22)
        Me.TextBox33.TabIndex = 122
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(214, 114)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(55, 22)
        Me.TextBox29.TabIndex = 120
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(214, 141)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(55, 22)
        Me.TextBox31.TabIndex = 121
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox46
        '
        Me.TextBox46.Location = New System.Drawing.Point(148, 323)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(60, 22)
        Me.TextBox46.TabIndex = 63
        Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox44
        '
        Me.TextBox44.Location = New System.Drawing.Point(148, 297)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(60, 22)
        Me.TextBox44.TabIndex = 61
        Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(148, 271)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(60, 22)
        Me.TextBox42.TabIndex = 59
        Me.TextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox40
        '
        Me.TextBox40.Location = New System.Drawing.Point(148, 245)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(60, 22)
        Me.TextBox40.TabIndex = 57
        Me.TextBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox38
        '
        Me.TextBox38.Location = New System.Drawing.Point(148, 219)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(60, 22)
        Me.TextBox38.TabIndex = 55
        Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox36
        '
        Me.TextBox36.Location = New System.Drawing.Point(148, 192)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(60, 22)
        Me.TextBox36.TabIndex = 53
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(148, 167)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(60, 22)
        Me.TextBox34.TabIndex = 51
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(148, 141)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(60, 22)
        Me.TextBox32.TabIndex = 49
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(148, 113)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(60, 22)
        Me.TextBox30.TabIndex = 47
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(148, 88)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(60, 22)
        Me.TextBox27.TabIndex = 45
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button4Bearbeiten
        '
        Me.Button4Bearbeiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4Bearbeiten.Location = New System.Drawing.Point(186, 16)
        Me.Button4Bearbeiten.Name = "Button4Bearbeiten"
        Me.Button4Bearbeiten.Size = New System.Drawing.Size(78, 36)
        Me.Button4Bearbeiten.TabIndex = 74
        Me.Button4Bearbeiten.Text = "Kosten bearbeiten"
        Me.Button4Bearbeiten.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(132, 72)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 13)
        Me.Label38.TabIndex = 73
        Me.Label38.Text = "+ Versicherung"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(222, 67)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(51, 16)
        Me.Label37.TabIndex = 72
        Me.Label37.Text = "bezahlt"
        '
        'ButtonCrewSuchen
        '
        Me.ButtonCrewSuchen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCrewSuchen.Location = New System.Drawing.Point(13, 16)
        Me.ButtonCrewSuchen.Name = "ButtonCrewSuchen"
        Me.ButtonCrewSuchen.Size = New System.Drawing.Size(80, 37)
        Me.ButtonCrewSuchen.TabIndex = 28
        Me.ButtonCrewSuchen.Text = "Crew suchen"
        Me.ButtonCrewSuchen.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(102, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 36)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Suche beenden"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 89)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 115)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(12, 141)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 33
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(12, 167)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 34
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(12, 193)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 35
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(12, 219)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 36
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(12, 245)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox7.TabIndex = 37
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(12, 271)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 38
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(12, 297)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox9.TabIndex = 39
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(12, 323)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox10.TabIndex = 40
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(140, 60)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(70, 13)
        Me.Label34.TabIndex = 43
        Me.Label34.Text = "Anteil Charter"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label35)
        Me.GroupBox12.Controls.Add(Me.Label23)
        Me.GroupBox12.Controls.Add(Me.Label33)
        Me.GroupBox12.Controls.Add(Me.TextBox1)
        Me.GroupBox12.Controls.Add(Me.TextBox26)
        Me.GroupBox12.Controls.Add(Me.TextBox55)
        Me.GroupBox12.Controls.Add(Me.Label36)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(9, 18)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(275, 107)
        Me.GroupBox12.TabIndex = 100
        Me.GroupBox12.TabStop = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(8, 65)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(93, 13)
        Me.Label35.TabIndex = 76
        Me.Label35.Text = "ohne Reisekosten"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 52)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(95, 16)
        Me.Label33.TabIndex = 75
        Me.Label33.Text = "Gesamtkosten"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Crewanzahl", True))
        Me.TextBox1.Location = New System.Drawing.Point(232, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(33, 22)
        Me.TextBox1.TabIndex = 39
        '
        'TextBox26
        '
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(176, 52)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(89, 22)
        Me.TextBox26.TabIndex = 74
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox55
        '
        Me.TextBox55.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Crewanteil", True))
        Me.TextBox55.Location = New System.Drawing.Point(175, 80)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(90, 22)
        Me.TextBox55.TabIndex = 69
        Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(5, 85)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(161, 16)
        Me.Label36.TabIndex = 70
        Me.Label36.Text = "Gesamtkosten/Person"
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.Location = New System.Drawing.Point(906, 289)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox25.TabIndex = 139
        Me.CheckBox25.UseVisualStyleBackColor = True
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Location = New System.Drawing.Point(906, 264)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox24.TabIndex = 138
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Location = New System.Drawing.Point(906, 239)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox23.TabIndex = 137
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Location = New System.Drawing.Point(906, 212)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox22.TabIndex = 136
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Location = New System.Drawing.Point(906, 187)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox21.TabIndex = 135
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Location = New System.Drawing.Point(906, 160)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox20.TabIndex = 134
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(906, 135)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox19.TabIndex = 133
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(906, 108)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox18.TabIndex = 132
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(906, 81)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox17.TabIndex = 131
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(893, 31)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(55, 16)
        Me.Label72.TabIndex = 130
        Me.Label72.Text = "Fixpreis"
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(906, 55)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox16.TabIndex = 129
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'TextBox76
        '
        Me.TextBox76.Location = New System.Drawing.Point(528, 288)
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New System.Drawing.Size(55, 22)
        Me.TextBox76.TabIndex = 118
        Me.TextBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox77
        '
        Me.TextBox77.Location = New System.Drawing.Point(528, 262)
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New System.Drawing.Size(55, 22)
        Me.TextBox77.TabIndex = 117
        Me.TextBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox78
        '
        Me.TextBox78.Location = New System.Drawing.Point(528, 236)
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New System.Drawing.Size(55, 22)
        Me.TextBox78.TabIndex = 116
        Me.TextBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox79
        '
        Me.TextBox79.Location = New System.Drawing.Point(528, 210)
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New System.Drawing.Size(55, 22)
        Me.TextBox79.TabIndex = 115
        Me.TextBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox80
        '
        Me.TextBox80.Location = New System.Drawing.Point(528, 184)
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New System.Drawing.Size(55, 22)
        Me.TextBox80.TabIndex = 114
        Me.TextBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox81
        '
        Me.TextBox81.Location = New System.Drawing.Point(528, 157)
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New System.Drawing.Size(55, 22)
        Me.TextBox81.TabIndex = 113
        Me.TextBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox82
        '
        Me.TextBox82.Location = New System.Drawing.Point(528, 53)
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New System.Drawing.Size(55, 22)
        Me.TextBox82.TabIndex = 109
        Me.TextBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox83
        '
        Me.TextBox83.Location = New System.Drawing.Point(528, 132)
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Size = New System.Drawing.Size(55, 22)
        Me.TextBox83.TabIndex = 112
        Me.TextBox83.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox84
        '
        Me.TextBox84.Location = New System.Drawing.Point(528, 79)
        Me.TextBox84.Name = "TextBox84"
        Me.TextBox84.Size = New System.Drawing.Size(55, 22)
        Me.TextBox84.TabIndex = 110
        Me.TextBox84.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox85
        '
        Me.TextBox85.Location = New System.Drawing.Point(528, 106)
        Me.TextBox85.Name = "TextBox85"
        Me.TextBox85.Size = New System.Drawing.Size(55, 22)
        Me.TextBox85.TabIndex = 111
        Me.TextBox85.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(528, 32)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(57, 13)
        Me.Label71.TabIndex = 108
        Me.Label71.Text = "Anzahlung"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(260, 295)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(56, 16)
        Me.Label69.TabIndex = 107
        Me.Label69.Text = "Label69"
        '
        'MaskedTextBox25
        '
        Me.MaskedTextBox25.Location = New System.Drawing.Point(675, 291)
        Me.MaskedTextBox25.Name = "MaskedTextBox25"
        Me.MaskedTextBox25.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox25.TabIndex = 106
        '
        'MaskedTextBox26
        '
        Me.MaskedTextBox26.Location = New System.Drawing.Point(439, 287)
        Me.MaskedTextBox26.Name = "MaskedTextBox26"
        Me.MaskedTextBox26.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox26.TabIndex = 105
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(260, 270)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(56, 16)
        Me.Label68.TabIndex = 104
        Me.Label68.Text = "Label68"
        '
        'MaskedTextBox23
        '
        Me.MaskedTextBox23.Location = New System.Drawing.Point(675, 266)
        Me.MaskedTextBox23.Name = "MaskedTextBox23"
        Me.MaskedTextBox23.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox23.TabIndex = 103
        '
        'MaskedTextBox24
        '
        Me.MaskedTextBox24.Location = New System.Drawing.Point(439, 262)
        Me.MaskedTextBox24.Name = "MaskedTextBox24"
        Me.MaskedTextBox24.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox24.TabIndex = 102
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(260, 244)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(56, 16)
        Me.Label67.TabIndex = 101
        Me.Label67.Text = "Label67"
        '
        'MaskedTextBox21
        '
        Me.MaskedTextBox21.Location = New System.Drawing.Point(675, 240)
        Me.MaskedTextBox21.Name = "MaskedTextBox21"
        Me.MaskedTextBox21.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox21.TabIndex = 100
        '
        'MaskedTextBox22
        '
        Me.MaskedTextBox22.Location = New System.Drawing.Point(439, 236)
        Me.MaskedTextBox22.Name = "MaskedTextBox22"
        Me.MaskedTextBox22.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox22.TabIndex = 99
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(260, 218)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(56, 16)
        Me.Label66.TabIndex = 98
        Me.Label66.Text = "Label66"
        '
        'MaskedTextBox19
        '
        Me.MaskedTextBox19.Location = New System.Drawing.Point(675, 214)
        Me.MaskedTextBox19.Name = "MaskedTextBox19"
        Me.MaskedTextBox19.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox19.TabIndex = 97
        '
        'MaskedTextBox20
        '
        Me.MaskedTextBox20.Location = New System.Drawing.Point(439, 210)
        Me.MaskedTextBox20.Name = "MaskedTextBox20"
        Me.MaskedTextBox20.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox20.TabIndex = 96
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(260, 192)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(56, 16)
        Me.Label65.TabIndex = 95
        Me.Label65.Text = "Label65"
        '
        'MaskedTextBox17
        '
        Me.MaskedTextBox17.Location = New System.Drawing.Point(675, 188)
        Me.MaskedTextBox17.Name = "MaskedTextBox17"
        Me.MaskedTextBox17.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox17.TabIndex = 94
        '
        'MaskedTextBox18
        '
        Me.MaskedTextBox18.Location = New System.Drawing.Point(439, 184)
        Me.MaskedTextBox18.Name = "MaskedTextBox18"
        Me.MaskedTextBox18.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox18.TabIndex = 93
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(259, 165)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(56, 16)
        Me.Label64.TabIndex = 92
        Me.Label64.Text = "Label64"
        '
        'MaskedTextBox15
        '
        Me.MaskedTextBox15.Location = New System.Drawing.Point(674, 161)
        Me.MaskedTextBox15.Name = "MaskedTextBox15"
        Me.MaskedTextBox15.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox15.TabIndex = 91
        '
        'MaskedTextBox16
        '
        Me.MaskedTextBox16.Location = New System.Drawing.Point(438, 157)
        Me.MaskedTextBox16.Name = "MaskedTextBox16"
        Me.MaskedTextBox16.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox16.TabIndex = 90
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(259, 140)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(56, 16)
        Me.Label63.TabIndex = 89
        Me.Label63.Text = "Label63"
        '
        'MaskedTextBox13
        '
        Me.MaskedTextBox13.Location = New System.Drawing.Point(674, 136)
        Me.MaskedTextBox13.Name = "MaskedTextBox13"
        Me.MaskedTextBox13.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox13.TabIndex = 88
        '
        'MaskedTextBox14
        '
        Me.MaskedTextBox14.Location = New System.Drawing.Point(438, 132)
        Me.MaskedTextBox14.Name = "MaskedTextBox14"
        Me.MaskedTextBox14.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox14.TabIndex = 87
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(259, 114)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(56, 16)
        Me.Label62.TabIndex = 86
        Me.Label62.Text = "Label62"
        '
        'MaskedTextBox11
        '
        Me.MaskedTextBox11.Location = New System.Drawing.Point(674, 110)
        Me.MaskedTextBox11.Name = "MaskedTextBox11"
        Me.MaskedTextBox11.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox11.TabIndex = 85
        '
        'MaskedTextBox12
        '
        Me.MaskedTextBox12.Location = New System.Drawing.Point(438, 106)
        Me.MaskedTextBox12.Name = "MaskedTextBox12"
        Me.MaskedTextBox12.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox12.TabIndex = 84
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(259, 87)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(56, 16)
        Me.Label61.TabIndex = 83
        Me.Label61.Text = "Label61"
        '
        'MaskedTextBox9
        '
        Me.MaskedTextBox9.Location = New System.Drawing.Point(674, 83)
        Me.MaskedTextBox9.Name = "MaskedTextBox9"
        Me.MaskedTextBox9.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox9.TabIndex = 82
        '
        'MaskedTextBox10
        '
        Me.MaskedTextBox10.Location = New System.Drawing.Point(438, 79)
        Me.MaskedTextBox10.Name = "MaskedTextBox10"
        Me.MaskedTextBox10.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox10.TabIndex = 81
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(260, 61)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 16)
        Me.Label60.TabIndex = 80
        Me.Label60.Text = "Label60"
        '
        'MaskedTextBox8
        '
        Me.MaskedTextBox8.Location = New System.Drawing.Point(675, 57)
        Me.MaskedTextBox8.Name = "MaskedTextBox8"
        Me.MaskedTextBox8.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox8.TabIndex = 79
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(439, 53)
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(72, 22)
        Me.MaskedTextBox5.TabIndex = 78
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(445, 36)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(60, 13)
        Me.Label59.TabIndex = 77
        Me.Label59.Text = "Anzahlung "
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(456, 23)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(38, 13)
        Me.Label54.TabIndex = 76
        Me.Label54.Text = "Datum"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(255, 37)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(75, 13)
        Me.Label32.TabIndex = 75
        Me.Label32.Text = "Gesamtkosten"
        '
        'TextBox62
        '
        Me.TextBox62.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Skipperverdienst", True))
        Me.TextBox62.Location = New System.Drawing.Point(188, 96)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(86, 22)
        Me.TextBox62.TabIndex = 38
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(10, 100)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(110, 16)
        Me.Label47.TabIndex = 77
        Me.Label47.Text = "Skipperverdienst"
        '
        'TextBox49
        '
        Me.TextBox49.Location = New System.Drawing.Point(208, 67)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(50, 20)
        Me.TextBox49.TabIndex = 68
        Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox50
        '
        Me.TextBox50.Location = New System.Drawing.Point(142, 66)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(60, 20)
        Me.TextBox50.TabIndex = 67
        Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox47
        '
        Me.TextBox47.Location = New System.Drawing.Point(208, 41)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(50, 20)
        Me.TextBox47.TabIndex = 66
        Me.TextBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox48
        '
        Me.TextBox48.Location = New System.Drawing.Point(142, 40)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(60, 20)
        Me.TextBox48.TabIndex = 65
        Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(6, 66)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox12.TabIndex = 42
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(6, 40)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox11.TabIndex = 41
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(10, 18)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(190, 16)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Skipper Kostenbeteiligung"
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 1547
        Me.LineShape5.X2 = 1284
        Me.LineShape5.Y1 = 221
        Me.LineShape5.Y2 = 221
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 1548
        Me.LineShape4.X2 = 1285
        Me.LineShape4.Y1 = 232
        Me.LineShape4.Y2 = 232
        '
        'SpeichernButton
        '
        Me.SpeichernButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeichernButton.Location = New System.Drawing.Point(795, 634)
        Me.SpeichernButton.Name = "SpeichernButton"
        Me.SpeichernButton.Size = New System.Drawing.Size(201, 45)
        Me.SpeichernButton.TabIndex = 40
        Me.SpeichernButton.Text = "Speichern"
        Me.SpeichernButton.UseVisualStyleBackColor = True
        '
        'LoeschenButton
        '
        Me.LoeschenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoeschenButton.Location = New System.Drawing.Point(14, 634)
        Me.LoeschenButton.Name = "LoeschenButton"
        Me.LoeschenButton.Size = New System.Drawing.Size(178, 45)
        Me.LoeschenButton.TabIndex = 4
        Me.LoeschenButton.Text = "Kalkulation löschen"
        Me.LoeschenButton.UseVisualStyleBackColor = True
        '
        'FormularButton
        '
        Me.FormularButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormularButton.Location = New System.Drawing.Point(279, 634)
        Me.FormularButton.Name = "FormularButton"
        Me.FormularButton.Size = New System.Drawing.Size(174, 45)
        Me.FormularButton.TabIndex = 5
        Me.FormularButton.Text = "Formular leeren"
        Me.FormularButton.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(1071, 549)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 6
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "VZName", True))
        Me.TextBox13.Location = New System.Drawing.Point(1552, 552)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 7
        '
        'bsBootKalkulation
        '
        Me.bsBootKalkulation.DataMember = "BootKalkulation"
        Me.bsBootKalkulation.DataSource = Me.dsToernverwaltung
        '
        'TextBox51
        '
        Me.TextBox51.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "Toern", True))
        Me.TextBox51.Location = New System.Drawing.Point(1339, 554)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(100, 20)
        Me.TextBox51.TabIndex = 8
        '
        'TextBox52
        '
        Me.TextBox52.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "Kosten", True))
        Me.TextBox52.Location = New System.Drawing.Point(1258, 554)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(75, 20)
        Me.TextBox52.TabIndex = 9
        '
        'TextBox53
        '
        Me.TextBox53.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "Bezahlt", True))
        Me.TextBox53.Location = New System.Drawing.Point(1446, 554)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(100, 20)
        Me.TextBox53.TabIndex = 10
        '
        'TextBox54
        '
        Me.TextBox54.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "Boot", True))
        Me.TextBox54.Location = New System.Drawing.Point(1668, 552)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(100, 20)
        Me.TextBox54.TabIndex = 11
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToernDataGridViewTextBoxColumn1, Me.BootDataGridViewTextBoxColumn1, Me.VZNameDataGridViewTextBoxColumn, Me.KostenDataGridViewTextBoxColumn, Me.BezahltDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsBootKalkulation
        Me.DataGridView2.Location = New System.Drawing.Point(1813, 17)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(579, 98)
        Me.DataGridView2.TabIndex = 12
        Me.DataGridView2.Visible = False
        '
        'ToernDataGridViewTextBoxColumn1
        '
        Me.ToernDataGridViewTextBoxColumn1.DataPropertyName = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.HeaderText = "Toern"
        Me.ToernDataGridViewTextBoxColumn1.Name = "ToernDataGridViewTextBoxColumn1"
        '
        'BootDataGridViewTextBoxColumn1
        '
        Me.BootDataGridViewTextBoxColumn1.DataPropertyName = "Boot"
        Me.BootDataGridViewTextBoxColumn1.HeaderText = "Boot"
        Me.BootDataGridViewTextBoxColumn1.Name = "BootDataGridViewTextBoxColumn1"
        '
        'VZNameDataGridViewTextBoxColumn
        '
        Me.VZNameDataGridViewTextBoxColumn.DataPropertyName = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.HeaderText = "VZName"
        Me.VZNameDataGridViewTextBoxColumn.Name = "VZNameDataGridViewTextBoxColumn"
        '
        'KostenDataGridViewTextBoxColumn
        '
        Me.KostenDataGridViewTextBoxColumn.DataPropertyName = "Kosten"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.KostenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.KostenDataGridViewTextBoxColumn.HeaderText = "Kosten"
        Me.KostenDataGridViewTextBoxColumn.Name = "KostenDataGridViewTextBoxColumn"
        '
        'BezahltDataGridViewTextBoxColumn
        '
        Me.BezahltDataGridViewTextBoxColumn.DataPropertyName = "Bezahlt"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.BezahltDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.BezahltDataGridViewTextBoxColumn.HeaderText = "Bezahlt"
        Me.BezahltDataGridViewTextBoxColumn.Name = "BezahltDataGridViewTextBoxColumn"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Charterkosten [€]"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Charterkosten", True))
        Me.TextBox3.Location = New System.Drawing.Point(148, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(89, 22)
        Me.TextBox3.TabIndex = 5
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(284, 35)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 16)
        Me.Label41.TabIndex = 69
        Me.Label41.Text = "-Rabatt 1  [%]"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(477, 35)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 16)
        Me.Label42.TabIndex = 70
        Me.Label42.Text = "-Rabatt 2  [%]"
        '
        'TextBox58
        '
        Me.TextBox58.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Rabatt1", True))
        Me.TextBox58.Location = New System.Drawing.Point(372, 32)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(86, 22)
        Me.TextBox58.TabIndex = 6
        '
        'TextBox59
        '
        Me.TextBox59.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Rabatt2", True))
        Me.TextBox59.Location = New System.Drawing.Point(580, 32)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(91, 22)
        Me.TextBox59.TabIndex = 7
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label56)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Controls.Add(Me.TextBox58)
        Me.GroupBox5.Controls.Add(Me.TextBox59)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(1477, 308)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(685, 79)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Yachtkosten"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(478, 14)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(35, 16)
        Me.Label56.TabIndex = 71
        Me.Label56.Text = "Club"
        Me.Label56.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label55)
        Me.GroupBox6.Controls.Add(Me.CheckBox13)
        Me.GroupBox6.Controls.Add(Me.TextBox64)
        Me.GroupBox6.Controls.Add(Me.Label53)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.TextBox20)
        Me.GroupBox6.Controls.Add(Me.TextBox21)
        Me.GroupBox6.Controls.Add(Me.TextBox22)
        Me.GroupBox6.Controls.Add(Me.TextBox23)
        Me.GroupBox6.Controls.Add(Me.TextBox24)
        Me.GroupBox6.Controls.Add(Me.TextBox25)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(1081, 404)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(685, 115)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Versicherungen"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(597, 87)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(54, 13)
        Me.Label55.TabIndex = 38
        Me.Label55.Text = "Vorschlag"
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(657, 86)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox13.TabIndex = 36
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'TextBox64
        '
        Me.TextBox64.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Folgeschadenversicherung", True))
        Me.TextBox64.Location = New System.Drawing.Point(123, 79)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(89, 22)
        Me.TextBox64.TabIndex = 35
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(2, 81)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(95, 16)
        Me.Label53.TabIndex = 34
        Me.Label53.Text = "Folgeschaden"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label40)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.TextBox57)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.TextBox14)
        Me.GroupBox7.Controls.Add(Me.TextBox15)
        Me.GroupBox7.Controls.Add(Me.TextBox16)
        Me.GroupBox7.Controls.Add(Me.TextBox17)
        Me.GroupBox7.Controls.Add(Me.TextBox18)
        Me.GroupBox7.Controls.Add(Me.TextBox19)
        Me.GroupBox7.Controls.Add(Me.TextBox60)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.TextBox56)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(1078, 608)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(685, 108)
        Me.GroupBox7.TabIndex = 43
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Bordkassa"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBox4)
        Me.GroupBox8.Controls.Add(Me.PictureBox4)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.PictureBox3)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.TextBox5)
        Me.GroupBox8.Controls.Add(Me.TextBox6)
        Me.GroupBox8.Controls.Add(Me.TextBox8)
        Me.GroupBox8.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox8.Controls.Add(Me.TextBox9)
        Me.GroupBox8.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox8.Controls.Add(Me.TextBox10)
        Me.GroupBox8.Controls.Add(Me.TextBox11)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(1081, 49)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(685, 121)
        Me.GroupBox8.TabIndex = 43
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Reisekosten mit Flug"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label70)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.TextBox7)
        Me.GroupBox9.Controls.Add(Me.Label44)
        Me.GroupBox9.Controls.Add(Me.Label46)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(1081, 185)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(685, 105)
        Me.GroupBox9.TabIndex = 43
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Reisekosten mit Auto"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(131, 47)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(56, 16)
        Me.Label70.TabIndex = 79
        Me.Label70.Text = "Label70"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.Label26)
        Me.GroupBox10.Controls.Add(Me.Label27)
        Me.GroupBox10.Controls.Add(Me.Label28)
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Controls.Add(Me.Label45)
        Me.GroupBox10.Controls.Add(Me.Label50)
        Me.GroupBox10.Controls.Add(Me.RadioButton5)
        Me.GroupBox10.Controls.Add(Me.RadioButton4)
        Me.GroupBox10.Controls.Add(Me.RadioButton3)
        Me.GroupBox10.Controls.Add(Me.RadioButton2)
        Me.GroupBox10.Controls.Add(Me.RadioButton1)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(14, 211)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(685, 79)
        Me.GroupBox10.TabIndex = 44
        Me.GroupBox10.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(550, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(102, 16)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Versicherungen"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(440, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 16)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Bordkassa"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(312, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 16)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "AnreiseAuto"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(181, 47)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(75, 16)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Anreiseflug"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(58, 47)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(82, 16)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "Yachtkosten"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(8, 47)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(49, 16)
        Me.Label50.TabIndex = 5
        Me.Label50.Text = "Kosten"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(553, 21)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(120, 20)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Versicherungen"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(443, 21)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(92, 20)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Bordkassa"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(315, 21)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(102, 20)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Anreise Auto"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(184, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(101, 20)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Anreise Flug"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(61, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 20)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yachtkosten"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox63
        '
        Me.TextBox63.Location = New System.Drawing.Point(1186, 552)
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(66, 20)
        Me.TextBox63.TabIndex = 87
        '
        'TextBox65
        '
        Me.TextBox65.Location = New System.Drawing.Point(1892, 132)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(55, 20)
        Me.TextBox65.TabIndex = 88
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsCrewAdressen, "Clubmitglied", True))
        Me.CheckBox14.Location = New System.Drawing.Point(1900, 174)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox14.TabIndex = 89
        Me.CheckBox14.Text = "CheckBox14"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsBootKalkulation, "Clubmitglied", True))
        Me.CheckBox15.Location = New System.Drawing.Point(1072, 525)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox15.TabIndex = 90
        Me.CheckBox15.Text = "CheckBox15"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'TextBox66
        '
        Me.TextBox66.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "NettoChartVerAnteil", True))
        Me.TextBox66.Location = New System.Drawing.Point(1186, 529)
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(65, 20)
        Me.TextBox66.TabIndex = 91
        '
        'TextBox67
        '
        Me.TextBox67.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "BruttoChartVerAnteil", True))
        Me.TextBox67.Location = New System.Drawing.Point(1258, 529)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(68, 20)
        Me.TextBox67.TabIndex = 92
        '
        'TextBox70
        '
        Me.TextBox70.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Reserve2", True))
        Me.TextBox70.Location = New System.Drawing.Point(1081, 303)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(100, 20)
        Me.TextBox70.TabIndex = 93
        '
        'TextBox71
        '
        Me.TextBox71.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "Reserve1", True))
        Me.TextBox71.Location = New System.Drawing.Point(1081, 332)
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(100, 20)
        Me.TextBox71.TabIndex = 94
        '
        'TextBox72
        '
        Me.TextBox72.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsToernKalkulation, "ID", True))
        Me.TextBox72.Location = New System.Drawing.Point(1654, 525)
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New System.Drawing.Size(50, 20)
        Me.TextBox72.TabIndex = 95
        '
        'TextBox73
        '
        Me.TextBox73.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "IDToern", True))
        Me.TextBox73.Location = New System.Drawing.Point(1775, 553)
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(100, 20)
        Me.TextBox73.TabIndex = 96
        '
        'TextBox74
        '
        Me.TextBox74.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "Anteil", True))
        Me.TextBox74.Location = New System.Drawing.Point(1710, 525)
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New System.Drawing.Size(39, 20)
        Me.TextBox74.TabIndex = 97
        '
        'DsAusbildung
        '
        Me.DsAusbildung.DataSetName = "dsAusbildung"
        Me.DsAusbildung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListboxDataGridView
        '
        Me.ListboxDataGridView.AutoGenerateColumns = False
        Me.ListboxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListboxDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.ListboxDataGridView.DataSource = Me.bsListdaten
        Me.ListboxDataGridView.Location = New System.Drawing.Point(1829, 223)
        Me.ListboxDataGridView.Name = "ListboxDataGridView"
        Me.ListboxDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ListboxDataGridView.TabIndex = 97
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "feld21"
        Me.DataGridViewTextBoxColumn23.HeaderText = "feld21"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "feld22"
        Me.DataGridViewTextBoxColumn24.HeaderText = "feld22"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "feld23"
        Me.DataGridViewTextBoxColumn25.HeaderText = "feld23"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "feld24"
        Me.DataGridViewTextBoxColumn26.HeaderText = "feld24"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "feld25"
        Me.DataGridViewTextBoxColumn27.HeaderText = "feld25"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "feld26"
        Me.DataGridViewTextBoxColumn28.HeaderText = "feld26"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "feld27"
        Me.DataGridViewTextBoxColumn29.HeaderText = "feld27"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "feld28"
        Me.DataGridViewTextBoxColumn30.HeaderText = "feld28"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'bsListdaten
        '
        Me.bsListdaten.DataMember = "Listdaten"
        Me.bsListdaten.DataSource = Me.dsToernverwaltung
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.TextBox62)
        Me.GroupBox11.Controls.Add(Me.Checkvers)
        Me.GroupBox11.Controls.Add(Me.Label47)
        Me.GroupBox11.Controls.Add(Me.Checkkassa)
        Me.GroupBox11.Controls.Add(Me.Checkcharter)
        Me.GroupBox11.Controls.Add(Me.Label31)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(705, 12)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(291, 122)
        Me.GroupBox11.TabIndex = 98
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Skipper"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1031, 698)
        Me.ShapeContainer1.TabIndex = 99
        Me.ShapeContainer1.TabStop = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.TextBox48)
        Me.GroupBox14.Controls.Add(Me.CheckBox12)
        Me.GroupBox14.Controls.Add(Me.CheckBox11)
        Me.GroupBox14.Controls.Add(Me.TextBox47)
        Me.GroupBox14.Controls.Add(Me.TextBox50)
        Me.GroupBox14.Controls.Add(Me.TextBox49)
        Me.GroupBox14.Location = New System.Drawing.Point(1813, 711)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(290, 143)
        Me.GroupBox14.TabIndex = 100
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "GroupBox14"
        '
        'TextBox68
        '
        Me.TextBox68.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "DatumAnzahlung", True))
        Me.TextBox68.Location = New System.Drawing.Point(1187, 303)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(100, 20)
        Me.TextBox68.TabIndex = 101
        '
        'TextBox69
        '
        Me.TextBox69.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "DatumRest", True))
        Me.TextBox69.Location = New System.Drawing.Point(1186, 331)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(100, 20)
        Me.TextBox69.TabIndex = 102
        '
        'TextBox75
        '
        Me.TextBox75.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "R1", True))
        Me.TextBox75.Location = New System.Drawing.Point(1296, 580)
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New System.Drawing.Size(100, 20)
        Me.TextBox75.TabIndex = 103
        '
        'CheckBox26
        '
        Me.CheckBox26.AutoSize = True
        Me.CheckBox26.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsBootKalkulation, "Fixpreis", True))
        Me.CheckBox26.Location = New System.Drawing.Point(1084, 12)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox26.TabIndex = 104
        Me.CheckBox26.Text = "CheckBox26"
        Me.CheckBox26.UseVisualStyleBackColor = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(29, 389)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(122, 16)
        Me.Label79.TabIndex = 105
        Me.Label79.Text = "Teilnehmer suchen"
        Me.Label79.Visible = False
        '
        'TextBox86
        '
        Me.TextBox86.Location = New System.Drawing.Point(154, 388)
        Me.TextBox86.Name = "TextBox86"
        Me.TextBox86.Size = New System.Drawing.Size(110, 20)
        Me.TextBox86.TabIndex = 106
        Me.TextBox86.Visible = False
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox15.Controls.Add(Me.Label91)
        Me.GroupBox15.Controls.Add(Me.Label90)
        Me.GroupBox15.Controls.Add(Me.CheckBox37)
        Me.GroupBox15.Controls.Add(Me.CheckBox38)
        Me.GroupBox15.Controls.Add(Me.CheckBox39)
        Me.GroupBox15.Controls.Add(Me.CheckBox40)
        Me.GroupBox15.Controls.Add(Me.CheckBox41)
        Me.GroupBox15.Controls.Add(Me.CheckBox42)
        Me.GroupBox15.Controls.Add(Me.CheckBox43)
        Me.GroupBox15.Controls.Add(Me.CheckBox44)
        Me.GroupBox15.Controls.Add(Me.CheckBox45)
        Me.GroupBox15.Controls.Add(Me.CheckBox46)
        Me.GroupBox15.Controls.Add(Me.Label78)
        Me.GroupBox15.Controls.Add(Me.Label77)
        Me.GroupBox15.Controls.Add(Me.Label76)
        Me.GroupBox15.Controls.Add(Me.Label75)
        Me.GroupBox15.Controls.Add(Me.Label74)
        Me.GroupBox15.Controls.Add(Me.Label73)
        Me.GroupBox15.Controls.Add(Me.PictureBox6)
        Me.GroupBox15.Controls.Add(Me.TextBox117)
        Me.GroupBox15.Controls.Add(Me.TextBox118)
        Me.GroupBox15.Controls.Add(Me.TextBox119)
        Me.GroupBox15.Controls.Add(Me.TextBox120)
        Me.GroupBox15.Controls.Add(Me.TextBox121)
        Me.GroupBox15.Controls.Add(Me.TextBox122)
        Me.GroupBox15.Controls.Add(Me.TextBox123)
        Me.GroupBox15.Controls.Add(Me.TextBox124)
        Me.GroupBox15.Controls.Add(Me.TextBox125)
        Me.GroupBox15.Controls.Add(Me.TextBox126)
        Me.GroupBox15.Controls.Add(Me.Label86)
        Me.GroupBox15.Controls.Add(Me.TextBox107)
        Me.GroupBox15.Controls.Add(Me.TextBox108)
        Me.GroupBox15.Controls.Add(Me.TextBox109)
        Me.GroupBox15.Controls.Add(Me.TextBox110)
        Me.GroupBox15.Controls.Add(Me.TextBox111)
        Me.GroupBox15.Controls.Add(Me.Label85)
        Me.GroupBox15.Controls.Add(Me.TextBox112)
        Me.GroupBox15.Controls.Add(Me.TextBox113)
        Me.GroupBox15.Controls.Add(Me.TextBox114)
        Me.GroupBox15.Controls.Add(Me.TextBox115)
        Me.GroupBox15.Controls.Add(Me.TextBox116)
        Me.GroupBox15.Controls.Add(Me.Label83)
        Me.GroupBox15.Controls.Add(Me.Label84)
        Me.GroupBox15.Controls.Add(Me.TextBox87)
        Me.GroupBox15.Controls.Add(Me.TextBox88)
        Me.GroupBox15.Controls.Add(Me.TextBox89)
        Me.GroupBox15.Controls.Add(Me.TextBox90)
        Me.GroupBox15.Controls.Add(Me.TextBox91)
        Me.GroupBox15.Controls.Add(Me.TextBox92)
        Me.GroupBox15.Controls.Add(Me.TextBox93)
        Me.GroupBox15.Controls.Add(Me.TextBox94)
        Me.GroupBox15.Controls.Add(Me.TextBox95)
        Me.GroupBox15.Controls.Add(Me.TextBox96)
        Me.GroupBox15.Controls.Add(Me.TextBox97)
        Me.GroupBox15.Controls.Add(Me.TextBox98)
        Me.GroupBox15.Controls.Add(Me.TextBox99)
        Me.GroupBox15.Controls.Add(Me.TextBox100)
        Me.GroupBox15.Controls.Add(Me.TextBox101)
        Me.GroupBox15.Controls.Add(Me.TextBox102)
        Me.GroupBox15.Controls.Add(Me.TextBox103)
        Me.GroupBox15.Controls.Add(Me.TextBox104)
        Me.GroupBox15.Controls.Add(Me.TextBox105)
        Me.GroupBox15.Controls.Add(Me.TextBox106)
        Me.GroupBox15.Controls.Add(Me.Label80)
        Me.GroupBox15.Controls.Add(Me.Label81)
        Me.GroupBox15.Controls.Add(Me.CheckBox27)
        Me.GroupBox15.Controls.Add(Me.CheckBox28)
        Me.GroupBox15.Controls.Add(Me.CheckBox29)
        Me.GroupBox15.Controls.Add(Me.CheckBox30)
        Me.GroupBox15.Controls.Add(Me.CheckBox31)
        Me.GroupBox15.Controls.Add(Me.CheckBox32)
        Me.GroupBox15.Controls.Add(Me.CheckBox33)
        Me.GroupBox15.Controls.Add(Me.CheckBox34)
        Me.GroupBox15.Controls.Add(Me.CheckBox35)
        Me.GroupBox15.Controls.Add(Me.CheckBox36)
        Me.GroupBox15.Controls.Add(Me.Label82)
        Me.GroupBox15.Controls.Add(Me.CheckBox25)
        Me.GroupBox15.Controls.Add(Me.TextBox81)
        Me.GroupBox15.Controls.Add(Me.CheckBox24)
        Me.GroupBox15.Controls.Add(Me.Label32)
        Me.GroupBox15.Controls.Add(Me.CheckBox23)
        Me.GroupBox15.Controls.Add(Me.Label54)
        Me.GroupBox15.Controls.Add(Me.CheckBox22)
        Me.GroupBox15.Controls.Add(Me.Label59)
        Me.GroupBox15.Controls.Add(Me.CheckBox21)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox5)
        Me.GroupBox15.Controls.Add(Me.CheckBox20)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox8)
        Me.GroupBox15.Controls.Add(Me.CheckBox19)
        Me.GroupBox15.Controls.Add(Me.Label60)
        Me.GroupBox15.Controls.Add(Me.CheckBox18)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox10)
        Me.GroupBox15.Controls.Add(Me.CheckBox17)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox9)
        Me.GroupBox15.Controls.Add(Me.Label72)
        Me.GroupBox15.Controls.Add(Me.Label61)
        Me.GroupBox15.Controls.Add(Me.CheckBox16)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox12)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox11)
        Me.GroupBox15.Controls.Add(Me.Label62)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox14)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox13)
        Me.GroupBox15.Controls.Add(Me.Label63)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox16)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox15)
        Me.GroupBox15.Controls.Add(Me.Label64)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox18)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox17)
        Me.GroupBox15.Controls.Add(Me.Label65)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox20)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox19)
        Me.GroupBox15.Controls.Add(Me.Label66)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox22)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox21)
        Me.GroupBox15.Controls.Add(Me.Label67)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox24)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox23)
        Me.GroupBox15.Controls.Add(Me.Label68)
        Me.GroupBox15.Controls.Add(Me.TextBox76)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox26)
        Me.GroupBox15.Controls.Add(Me.TextBox77)
        Me.GroupBox15.Controls.Add(Me.MaskedTextBox25)
        Me.GroupBox15.Controls.Add(Me.TextBox78)
        Me.GroupBox15.Controls.Add(Me.Label69)
        Me.GroupBox15.Controls.Add(Me.TextBox79)
        Me.GroupBox15.Controls.Add(Me.Label71)
        Me.GroupBox15.Controls.Add(Me.TextBox80)
        Me.GroupBox15.Controls.Add(Me.TextBox85)
        Me.GroupBox15.Controls.Add(Me.TextBox84)
        Me.GroupBox15.Controls.Add(Me.TextBox82)
        Me.GroupBox15.Controls.Add(Me.TextBox83)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(2158, 143)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(962, 477)
        Me.GroupBox15.TabIndex = 107
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Kosten bearbeiten"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(215, 38)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(40, 13)
        Me.Label91.TabIndex = 215
        Me.Label91.Text = "Kabine"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(215, 23)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(41, 13)
        Me.Label90.TabIndex = 214
        Me.Label90.Text = "Ganze "
        '
        'CheckBox37
        '
        Me.CheckBox37.AutoSize = True
        Me.CheckBox37.Location = New System.Drawing.Point(228, 61)
        Me.CheckBox37.Name = "CheckBox37"
        Me.CheckBox37.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox37.TabIndex = 204
        Me.CheckBox37.UseVisualStyleBackColor = True
        '
        'CheckBox38
        '
        Me.CheckBox38.AutoSize = True
        Me.CheckBox38.Location = New System.Drawing.Point(228, 87)
        Me.CheckBox38.Name = "CheckBox38"
        Me.CheckBox38.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox38.TabIndex = 205
        Me.CheckBox38.UseVisualStyleBackColor = True
        '
        'CheckBox39
        '
        Me.CheckBox39.AutoSize = True
        Me.CheckBox39.Location = New System.Drawing.Point(228, 113)
        Me.CheckBox39.Name = "CheckBox39"
        Me.CheckBox39.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox39.TabIndex = 206
        Me.CheckBox39.UseVisualStyleBackColor = True
        '
        'CheckBox40
        '
        Me.CheckBox40.AutoSize = True
        Me.CheckBox40.Location = New System.Drawing.Point(228, 139)
        Me.CheckBox40.Name = "CheckBox40"
        Me.CheckBox40.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox40.TabIndex = 207
        Me.CheckBox40.UseVisualStyleBackColor = True
        '
        'CheckBox41
        '
        Me.CheckBox41.AutoSize = True
        Me.CheckBox41.Location = New System.Drawing.Point(228, 165)
        Me.CheckBox41.Name = "CheckBox41"
        Me.CheckBox41.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox41.TabIndex = 208
        Me.CheckBox41.UseVisualStyleBackColor = True
        '
        'CheckBox42
        '
        Me.CheckBox42.AutoSize = True
        Me.CheckBox42.Location = New System.Drawing.Point(228, 191)
        Me.CheckBox42.Name = "CheckBox42"
        Me.CheckBox42.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox42.TabIndex = 209
        Me.CheckBox42.UseVisualStyleBackColor = True
        '
        'CheckBox43
        '
        Me.CheckBox43.AutoSize = True
        Me.CheckBox43.Location = New System.Drawing.Point(228, 217)
        Me.CheckBox43.Name = "CheckBox43"
        Me.CheckBox43.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox43.TabIndex = 210
        Me.CheckBox43.UseVisualStyleBackColor = True
        '
        'CheckBox44
        '
        Me.CheckBox44.AutoSize = True
        Me.CheckBox44.Location = New System.Drawing.Point(228, 243)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox44.TabIndex = 211
        Me.CheckBox44.UseVisualStyleBackColor = True
        '
        'CheckBox45
        '
        Me.CheckBox45.AutoSize = True
        Me.CheckBox45.Location = New System.Drawing.Point(228, 269)
        Me.CheckBox45.Name = "CheckBox45"
        Me.CheckBox45.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox45.TabIndex = 212
        Me.CheckBox45.UseVisualStyleBackColor = True
        '
        'CheckBox46
        '
        Me.CheckBox46.AutoSize = True
        Me.CheckBox46.Location = New System.Drawing.Point(228, 295)
        Me.CheckBox46.Name = "CheckBox46"
        Me.CheckBox46.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox46.TabIndex = 213
        Me.CheckBox46.UseVisualStyleBackColor = True
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(685, 427)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(56, 16)
        Me.Label78.TabIndex = 203
        Me.Label78.Text = "Label78"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(685, 403)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(56, 16)
        Me.Label77.TabIndex = 202
        Me.Label77.Text = "Label77"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(526, 403)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(127, 16)
        Me.Label76.TabIndex = 201
        Me.Label76.Text = "Summe der Anteile: "
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(685, 380)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(56, 16)
        Me.Label75.TabIndex = 200
        Me.Label75.Text = "Label75"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(525, 380)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(143, 16)
        Me.Label74.TabIndex = 199
        Me.Label74.Text = "Charter + Versicherung"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(528, 428)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(65, 16)
        Me.Label73.TabIndex = 198
        Me.Label73.Text = "Deckung:"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(42, 388)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 197
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'TextBox117
        '
        Me.TextBox117.Location = New System.Drawing.Point(834, 290)
        Me.TextBox117.Name = "TextBox117"
        Me.TextBox117.Size = New System.Drawing.Size(55, 22)
        Me.TextBox117.TabIndex = 196
        Me.TextBox117.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox118
        '
        Me.TextBox118.Location = New System.Drawing.Point(834, 264)
        Me.TextBox118.Name = "TextBox118"
        Me.TextBox118.Size = New System.Drawing.Size(55, 22)
        Me.TextBox118.TabIndex = 195
        Me.TextBox118.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox119
        '
        Me.TextBox119.Location = New System.Drawing.Point(834, 238)
        Me.TextBox119.Name = "TextBox119"
        Me.TextBox119.Size = New System.Drawing.Size(55, 22)
        Me.TextBox119.TabIndex = 194
        Me.TextBox119.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox120
        '
        Me.TextBox120.Location = New System.Drawing.Point(834, 212)
        Me.TextBox120.Name = "TextBox120"
        Me.TextBox120.Size = New System.Drawing.Size(55, 22)
        Me.TextBox120.TabIndex = 193
        Me.TextBox120.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox121
        '
        Me.TextBox121.Location = New System.Drawing.Point(834, 186)
        Me.TextBox121.Name = "TextBox121"
        Me.TextBox121.Size = New System.Drawing.Size(55, 22)
        Me.TextBox121.TabIndex = 192
        Me.TextBox121.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox122
        '
        Me.TextBox122.Location = New System.Drawing.Point(834, 159)
        Me.TextBox122.Name = "TextBox122"
        Me.TextBox122.Size = New System.Drawing.Size(55, 22)
        Me.TextBox122.TabIndex = 191
        Me.TextBox122.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox123
        '
        Me.TextBox123.Location = New System.Drawing.Point(834, 55)
        Me.TextBox123.Name = "TextBox123"
        Me.TextBox123.Size = New System.Drawing.Size(55, 22)
        Me.TextBox123.TabIndex = 187
        Me.TextBox123.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox124
        '
        Me.TextBox124.Location = New System.Drawing.Point(834, 134)
        Me.TextBox124.Name = "TextBox124"
        Me.TextBox124.Size = New System.Drawing.Size(55, 22)
        Me.TextBox124.TabIndex = 190
        Me.TextBox124.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox125
        '
        Me.TextBox125.Location = New System.Drawing.Point(834, 81)
        Me.TextBox125.Name = "TextBox125"
        Me.TextBox125.Size = New System.Drawing.Size(55, 22)
        Me.TextBox125.TabIndex = 188
        Me.TextBox125.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox126
        '
        Me.TextBox126.Location = New System.Drawing.Point(834, 108)
        Me.TextBox126.Name = "TextBox126"
        Me.TextBox126.Size = New System.Drawing.Size(55, 22)
        Me.TextBox126.TabIndex = 189
        Me.TextBox126.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(833, 33)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(51, 16)
        Me.Label86.TabIndex = 186
        Me.Label86.Text = "bezahlt"
        '
        'TextBox107
        '
        Me.TextBox107.Location = New System.Drawing.Point(762, 159)
        Me.TextBox107.Name = "TextBox107"
        Me.TextBox107.Size = New System.Drawing.Size(55, 22)
        Me.TextBox107.TabIndex = 180
        Me.TextBox107.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox108
        '
        Me.TextBox108.Location = New System.Drawing.Point(762, 290)
        Me.TextBox108.Name = "TextBox108"
        Me.TextBox108.Size = New System.Drawing.Size(55, 22)
        Me.TextBox108.TabIndex = 185
        Me.TextBox108.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox109
        '
        Me.TextBox109.Location = New System.Drawing.Point(762, 264)
        Me.TextBox109.Name = "TextBox109"
        Me.TextBox109.Size = New System.Drawing.Size(55, 22)
        Me.TextBox109.TabIndex = 184
        Me.TextBox109.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox110
        '
        Me.TextBox110.Location = New System.Drawing.Point(762, 238)
        Me.TextBox110.Name = "TextBox110"
        Me.TextBox110.Size = New System.Drawing.Size(55, 22)
        Me.TextBox110.TabIndex = 183
        Me.TextBox110.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox111
        '
        Me.TextBox111.Location = New System.Drawing.Point(762, 212)
        Me.TextBox111.Name = "TextBox111"
        Me.TextBox111.Size = New System.Drawing.Size(55, 22)
        Me.TextBox111.TabIndex = 182
        Me.TextBox111.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(759, 34)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(66, 13)
        Me.Label85.TabIndex = 175
        Me.Label85.Text = "Restzahlung"
        '
        'TextBox112
        '
        Me.TextBox112.Location = New System.Drawing.Point(762, 186)
        Me.TextBox112.Name = "TextBox112"
        Me.TextBox112.Size = New System.Drawing.Size(55, 22)
        Me.TextBox112.TabIndex = 181
        Me.TextBox112.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox113
        '
        Me.TextBox113.Location = New System.Drawing.Point(762, 108)
        Me.TextBox113.Name = "TextBox113"
        Me.TextBox113.Size = New System.Drawing.Size(55, 22)
        Me.TextBox113.TabIndex = 178
        Me.TextBox113.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox114
        '
        Me.TextBox114.Location = New System.Drawing.Point(762, 81)
        Me.TextBox114.Name = "TextBox114"
        Me.TextBox114.Size = New System.Drawing.Size(55, 22)
        Me.TextBox114.TabIndex = 177
        Me.TextBox114.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox115
        '
        Me.TextBox115.Location = New System.Drawing.Point(762, 55)
        Me.TextBox115.Name = "TextBox115"
        Me.TextBox115.Size = New System.Drawing.Size(55, 22)
        Me.TextBox115.TabIndex = 176
        Me.TextBox115.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox116
        '
        Me.TextBox116.Location = New System.Drawing.Point(762, 134)
        Me.TextBox116.Name = "TextBox116"
        Me.TextBox116.Size = New System.Drawing.Size(55, 22)
        Me.TextBox116.TabIndex = 179
        Me.TextBox116.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(685, 23)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(38, 13)
        Me.Label83.TabIndex = 173
        Me.Label83.Text = "Datum"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(677, 39)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(69, 13)
        Me.Label84.TabIndex = 174
        Me.Label84.Text = "Restzahlung "
        '
        'TextBox87
        '
        Me.TextBox87.Enabled = False
        Me.TextBox87.Location = New System.Drawing.Point(592, 289)
        Me.TextBox87.Name = "TextBox87"
        Me.TextBox87.Size = New System.Drawing.Size(55, 22)
        Me.TextBox87.TabIndex = 172
        Me.TextBox87.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox88
        '
        Me.TextBox88.Enabled = False
        Me.TextBox88.Location = New System.Drawing.Point(592, 263)
        Me.TextBox88.Name = "TextBox88"
        Me.TextBox88.Size = New System.Drawing.Size(55, 22)
        Me.TextBox88.TabIndex = 171
        Me.TextBox88.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox89
        '
        Me.TextBox89.Enabled = False
        Me.TextBox89.Location = New System.Drawing.Point(592, 237)
        Me.TextBox89.Name = "TextBox89"
        Me.TextBox89.Size = New System.Drawing.Size(55, 22)
        Me.TextBox89.TabIndex = 170
        Me.TextBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox90
        '
        Me.TextBox90.Enabled = False
        Me.TextBox90.Location = New System.Drawing.Point(592, 211)
        Me.TextBox90.Name = "TextBox90"
        Me.TextBox90.Size = New System.Drawing.Size(55, 22)
        Me.TextBox90.TabIndex = 169
        Me.TextBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox91
        '
        Me.TextBox91.Enabled = False
        Me.TextBox91.Location = New System.Drawing.Point(592, 185)
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.Size = New System.Drawing.Size(55, 22)
        Me.TextBox91.TabIndex = 168
        Me.TextBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox92
        '
        Me.TextBox92.Enabled = False
        Me.TextBox92.Location = New System.Drawing.Point(592, 158)
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.Size = New System.Drawing.Size(55, 22)
        Me.TextBox92.TabIndex = 167
        Me.TextBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox93
        '
        Me.TextBox93.Enabled = False
        Me.TextBox93.Location = New System.Drawing.Point(592, 54)
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.Size = New System.Drawing.Size(55, 22)
        Me.TextBox93.TabIndex = 163
        Me.TextBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox94
        '
        Me.TextBox94.Enabled = False
        Me.TextBox94.Location = New System.Drawing.Point(592, 133)
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.Size = New System.Drawing.Size(55, 22)
        Me.TextBox94.TabIndex = 166
        Me.TextBox94.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox95
        '
        Me.TextBox95.Enabled = False
        Me.TextBox95.Location = New System.Drawing.Point(592, 80)
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.Size = New System.Drawing.Size(55, 22)
        Me.TextBox95.TabIndex = 164
        Me.TextBox95.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox96
        '
        Me.TextBox96.Enabled = False
        Me.TextBox96.Location = New System.Drawing.Point(592, 107)
        Me.TextBox96.Name = "TextBox96"
        Me.TextBox96.Size = New System.Drawing.Size(55, 22)
        Me.TextBox96.TabIndex = 165
        Me.TextBox96.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox97
        '
        Me.TextBox97.Location = New System.Drawing.Point(361, 290)
        Me.TextBox97.Name = "TextBox97"
        Me.TextBox97.Size = New System.Drawing.Size(60, 22)
        Me.TextBox97.TabIndex = 160
        Me.TextBox97.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox98
        '
        Me.TextBox98.Location = New System.Drawing.Point(361, 264)
        Me.TextBox98.Name = "TextBox98"
        Me.TextBox98.Size = New System.Drawing.Size(60, 22)
        Me.TextBox98.TabIndex = 159
        Me.TextBox98.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox99
        '
        Me.TextBox99.Location = New System.Drawing.Point(361, 238)
        Me.TextBox99.Name = "TextBox99"
        Me.TextBox99.Size = New System.Drawing.Size(60, 22)
        Me.TextBox99.TabIndex = 158
        Me.TextBox99.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox100
        '
        Me.TextBox100.Location = New System.Drawing.Point(361, 212)
        Me.TextBox100.Name = "TextBox100"
        Me.TextBox100.Size = New System.Drawing.Size(60, 22)
        Me.TextBox100.TabIndex = 157
        Me.TextBox100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox101
        '
        Me.TextBox101.Location = New System.Drawing.Point(361, 186)
        Me.TextBox101.Name = "TextBox101"
        Me.TextBox101.Size = New System.Drawing.Size(60, 22)
        Me.TextBox101.TabIndex = 156
        Me.TextBox101.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox102
        '
        Me.TextBox102.Location = New System.Drawing.Point(361, 159)
        Me.TextBox102.Name = "TextBox102"
        Me.TextBox102.Size = New System.Drawing.Size(60, 22)
        Me.TextBox102.TabIndex = 155
        Me.TextBox102.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox103
        '
        Me.TextBox103.Location = New System.Drawing.Point(361, 134)
        Me.TextBox103.Name = "TextBox103"
        Me.TextBox103.Size = New System.Drawing.Size(60, 22)
        Me.TextBox103.TabIndex = 154
        Me.TextBox103.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox104
        '
        Me.TextBox104.Location = New System.Drawing.Point(361, 108)
        Me.TextBox104.Name = "TextBox104"
        Me.TextBox104.Size = New System.Drawing.Size(60, 22)
        Me.TextBox104.TabIndex = 153
        Me.TextBox104.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox105
        '
        Me.TextBox105.Location = New System.Drawing.Point(361, 80)
        Me.TextBox105.Name = "TextBox105"
        Me.TextBox105.Size = New System.Drawing.Size(60, 22)
        Me.TextBox105.TabIndex = 152
        Me.TextBox105.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox106
        '
        Me.TextBox106.Location = New System.Drawing.Point(361, 55)
        Me.TextBox106.Name = "TextBox106"
        Me.TextBox106.Size = New System.Drawing.Size(60, 22)
        Me.TextBox106.TabIndex = 151
        Me.TextBox106.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(345, 39)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(78, 13)
        Me.Label80.TabIndex = 162
        Me.Label80.Text = "+ Versicherung"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(591, 32)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(51, 16)
        Me.Label81.TabIndex = 161
        Me.Label81.Text = "bezahlt"
        '
        'CheckBox27
        '
        Me.CheckBox27.AutoSize = True
        Me.CheckBox27.Location = New System.Drawing.Point(21, 55)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox27.TabIndex = 140
        Me.CheckBox27.UseVisualStyleBackColor = True
        '
        'CheckBox28
        '
        Me.CheckBox28.AutoSize = True
        Me.CheckBox28.Location = New System.Drawing.Point(21, 81)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox28.TabIndex = 141
        Me.CheckBox28.UseVisualStyleBackColor = True
        '
        'CheckBox29
        '
        Me.CheckBox29.AutoSize = True
        Me.CheckBox29.Location = New System.Drawing.Point(21, 107)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox29.TabIndex = 142
        Me.CheckBox29.UseVisualStyleBackColor = True
        '
        'CheckBox30
        '
        Me.CheckBox30.AutoSize = True
        Me.CheckBox30.Location = New System.Drawing.Point(21, 133)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox30.TabIndex = 143
        Me.CheckBox30.UseVisualStyleBackColor = True
        '
        'CheckBox31
        '
        Me.CheckBox31.AutoSize = True
        Me.CheckBox31.Location = New System.Drawing.Point(21, 159)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox31.TabIndex = 144
        Me.CheckBox31.UseVisualStyleBackColor = True
        '
        'CheckBox32
        '
        Me.CheckBox32.AutoSize = True
        Me.CheckBox32.Location = New System.Drawing.Point(21, 185)
        Me.CheckBox32.Name = "CheckBox32"
        Me.CheckBox32.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox32.TabIndex = 145
        Me.CheckBox32.UseVisualStyleBackColor = True
        '
        'CheckBox33
        '
        Me.CheckBox33.AutoSize = True
        Me.CheckBox33.Location = New System.Drawing.Point(21, 211)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox33.TabIndex = 146
        Me.CheckBox33.UseVisualStyleBackColor = True
        '
        'CheckBox34
        '
        Me.CheckBox34.AutoSize = True
        Me.CheckBox34.Location = New System.Drawing.Point(21, 237)
        Me.CheckBox34.Name = "CheckBox34"
        Me.CheckBox34.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox34.TabIndex = 147
        Me.CheckBox34.UseVisualStyleBackColor = True
        '
        'CheckBox35
        '
        Me.CheckBox35.AutoSize = True
        Me.CheckBox35.Location = New System.Drawing.Point(21, 263)
        Me.CheckBox35.Name = "CheckBox35"
        Me.CheckBox35.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox35.TabIndex = 148
        Me.CheckBox35.UseVisualStyleBackColor = True
        '
        'CheckBox36
        '
        Me.CheckBox36.AutoSize = True
        Me.CheckBox36.Location = New System.Drawing.Point(21, 289)
        Me.CheckBox36.Name = "CheckBox36"
        Me.CheckBox36.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox36.TabIndex = 149
        Me.CheckBox36.UseVisualStyleBackColor = True
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(353, 23)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(70, 13)
        Me.Label82.TabIndex = 150
        Me.Label82.Text = "Anteil Charter"
        '
        'TextBox127
        '
        Me.TextBox127.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsBootKalkulation, "R2", True))
        Me.TextBox127.Location = New System.Drawing.Point(1407, 580)
        Me.TextBox127.Name = "TextBox127"
        Me.TextBox127.Size = New System.Drawing.Size(100, 20)
        Me.TextBox127.TabIndex = 108
        '
        'gbInfo
        '
        Me.gbInfo.BackColor = System.Drawing.Color.PapayaWhip
        Me.gbInfo.Controls.Add(Me.Label88)
        Me.gbInfo.Location = New System.Drawing.Point(1082, 725)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(259, 57)
        Me.gbInfo.TabIndex = 109
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Info"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(15, 26)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(231, 13)
        Me.Label88.TabIndex = 0
        Me.Label88.Text = "Blauer Text wird im Stammdaten/Boot verwaltet"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.PolizzeDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.bsVersicherter
        Me.DataGridView4.Location = New System.Drawing.Point(609, 737)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(132, 60)
        Me.DataGridView4.TabIndex = 110
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'PolizzeDataGridViewTextBoxColumn
        '
        Me.PolizzeDataGridViewTextBoxColumn.DataPropertyName = "Polizze"
        Me.PolizzeDataGridViewTextBoxColumn.HeaderText = "Polizze"
        Me.PolizzeDataGridViewTextBoxColumn.Name = "PolizzeDataGridViewTextBoxColumn"
        '
        'bsVersicherter
        '
        Me.bsVersicherter.DataMember = "Versicherter"
        Me.bsVersicherter.DataSource = Me.dsVersicherung
        '
        'dsVersicherung
        '
        Me.dsVersicherung.DataSetName = "VersicherungDataSet"
        Me.dsVersicherung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsVertrag
        '
        Me.bsVertrag.DataMember = "Vertrag"
        Me.bsVertrag.DataSource = Me.dsVersicherung
        '
        'taVertrag
        '
        Me.taVertrag.ClearBeforeFill = True
        '
        'taVersicherter
        '
        Me.taVersicherter.ClearBeforeFill = True
        '
        'TextBox128
        '
        Me.TextBox128.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsVersicherter, "Polizze", True))
        Me.TextBox128.Location = New System.Drawing.Point(609, 803)
        Me.TextBox128.Name = "TextBox128"
        Me.TextBox128.Size = New System.Drawing.Size(100, 20)
        Me.TextBox128.TabIndex = 111
        '
        'CheckBox47
        '
        Me.CheckBox47.AutoSize = True
        Me.CheckBox47.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsBootKalkulation, "Kabine", True))
        Me.CheckBox47.Location = New System.Drawing.Point(1358, 302)
        Me.CheckBox47.Name = "CheckBox47"
        Me.CheckBox47.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox47.TabIndex = 112
        Me.CheckBox47.Text = "CheckBox47"
        Me.CheckBox47.UseVisualStyleBackColor = True
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
        'taBootKalkulation
        '
        Me.taBootKalkulation.ClearBeforeFill = True
        '
        'taCrewAdressen
        '
        Me.taCrewAdressen.ClearBeforeFill = True
        '
        'taListdaten
        '
        Me.taListdaten.ClearBeforeFill = True
        '
        'taToernKalkulation
        '
        Me.taToernKalkulation.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(368, 765)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 45)
        Me.Button4.TabIndex = 113
        Me.Button4.Text = "Kalkulation aktualisieren"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Kalkulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 698)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox47)
        Me.Controls.Add(Me.TextBox128)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.TextBox127)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.TextBox86)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CheckBox26)
        Me.Controls.Add(Me.TextBox75)
        Me.Controls.Add(Me.TextBox69)
        Me.Controls.Add(Me.TextBox68)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.ListboxDataGridView)
        Me.Controls.Add(Me.TextBox74)
        Me.Controls.Add(Me.TextBox73)
        Me.Controls.Add(Me.TextBox72)
        Me.Controls.Add(Me.TextBox71)
        Me.Controls.Add(Me.TextBox70)
        Me.Controls.Add(Me.TextBox67)
        Me.Controls.Add(Me.TextBox66)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.TextBox61)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.TextBox65)
        Me.Controls.Add(Me.TextBox63)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox54)
        Me.Controls.Add(Me.TextBox53)
        Me.Controls.Add(Me.TextBox52)
        Me.Controls.Add(Me.TextBox51)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.FormularButton)
        Me.Controls.Add(Me.LoeschenButton)
        Me.Controls.Add(Me.SpeichernButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kalkulation"
        Me.Text = "Kalkulation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsToernKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsToernverwaltung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCrewAdressen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.bsBootKalkulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.DsAusbildung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListboxDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsListdaten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVersicherter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsVersicherung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVertrag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBoot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Checkcharter As System.Windows.Forms.CheckBox
    Friend WithEvents Checkvers As System.Windows.Forms.CheckBox
    Friend WithEvents Checkkassa As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents SpeichernButton As System.Windows.Forms.Button
    Friend WithEvents LoeschenButton As System.Windows.Forms.Button
    Friend WithEvents FormularButton As System.Windows.Forms.Button
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonCrewSuchen As System.Windows.Forms.Button
    Friend WithEvents dsToernverwaltung As WindowsApplication1.ToernverwaltungDataSet
    Friend WithEvents bsBoot As System.Windows.Forms.BindingSource
    Friend WithEvents taBoot As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootTableAdapter
    Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bsBootKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taBootKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.BootKalkulationTableAdapter
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents bsCrewAdressen As System.Windows.Forms.BindingSource
    Friend WithEvents taCrewAdressen As WindowsApplication1.ToernverwaltungDataSetTableAdapters.CrewAdressenTableAdapter
    Friend WithEvents VZnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZunameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernnrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlterersterToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StraßeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReisepassNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebdatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GebortDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FunkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegelscheinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox53 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox54 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TextBox55 As System.Windows.Forms.TextBox
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ToernDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VZNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BezahltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox61 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents TextBox60 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TextBox62 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TextBox59 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TextBox63 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox64 As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox65 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TextBox66 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox67 As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox71 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox72 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox73 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox74 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox7 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox6 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DsAusbildung As WindowsApplication1.dsAusbildung
    Friend WithEvents ListboxDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsListdaten As System.Windows.Forms.BindingSource
    Friend WithEvents taListdaten As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ListdatenTableAdapter
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents bsToernKalkulation As System.Windows.Forms.BindingSource
    Friend WithEvents taToernKalkulation As WindowsApplication1.ToernverwaltungDataSetTableAdapters.ToernKalkulationTableAdapter
    Friend WithEvents ToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BootDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinFlugNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HinFlugDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RueFlugNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RueFlugDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlugpreisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoanreisekostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinaanfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinarueckfahrtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EinkaufstaxiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharterkostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaftpflichtversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnfallversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RechtsschutzversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeschlagnahmerisikoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KautionsversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RücktrittsversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreibstoffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunkernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandmahlzeitenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarinakostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrewanzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BemerkungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeihwagenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperVersicherungDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SkipperCharterkostenDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SkipperBordkassaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FlughafenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SonstigekostenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrewanteilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AussenborderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndreinigungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rabatt2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperverdienstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernanfangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToernendeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SkipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RouteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserve5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolgeschadenversicherungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StornoversicherungDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StornoPerzentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StornoPerzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BruttoChartVerAnteilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NettoChartVerAnteilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDToernDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4Bearbeiten As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox25 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox26 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox23 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox24 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox21 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox22 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox19 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox20 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox17 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox18 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox15 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox16 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox13 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox14 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox11 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox12 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox9 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox10 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox8 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox68 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox69 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox75 As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents TextBox76 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox77 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox78 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox79 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox80 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox81 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox82 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox83 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox84 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox85 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox25 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox26 As System.Windows.Forms.CheckBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TextBox86 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox117 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox118 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox119 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox120 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox121 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox122 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox123 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox124 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox125 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox126 As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents TextBox107 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox108 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox109 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox110 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox111 As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents TextBox112 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox113 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox114 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox115 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox116 As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents TextBox87 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox88 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox89 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox90 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox91 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox92 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox93 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox94 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox95 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox96 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox97 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox98 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox99 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox100 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox101 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox102 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox103 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox104 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox105 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox106 As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents CheckBox27 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox28 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox29 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox30 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox31 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox32 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox33 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox34 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox35 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox36 As System.Windows.Forms.CheckBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox127 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents dsVersicherung As WindowsApplication1.VersicherungDataSet
    Friend WithEvents bsVertrag As System.Windows.Forms.BindingSource
    Friend WithEvents taVertrag As WindowsApplication1.VersicherungDataSetTableAdapters.VertragTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolizzeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsVersicherter As System.Windows.Forms.BindingSource
    Friend WithEvents taVersicherter As WindowsApplication1.VersicherungDataSetTableAdapters.VersicherterTableAdapter
    Friend WithEvents TextBox128 As System.Windows.Forms.TextBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents CheckBox37 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox38 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox39 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox40 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox41 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox42 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox43 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox44 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox45 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox46 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox47 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
