Public Class Kalkulation
    Public aenderung As Boolean
    Public namensaenderung As Boolean
    Dim Restdatum As Date
    Dim Charteranteil As Single
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public ijj As Integer
    Public CharVerAnteil As Integer
    Public CharVerAnteilClub As Integer
    Dim clubkosten As Integer
    Public Bootsmarke As String
    Public ToernAlt As String
    Public picture As Single
    Public chch As Boolean
    Public bootsrabatt As Boolean
    Dim datumanzahlung As Date
    Dim kosten As Single
    Dim datumrest As Date
    Dim position As Integer
    Dim buch1 As String
    Dim Reisekosten As Single
    Dim Autokosten As Single
    Dim beitrag As Single
    Dim anzahl As Single
    Dim n As Single
    Dim IDcheck As Boolean
    Dim toernID As String
    Dim anz As Single
    Dim alter As Integer
    Dim anzahlungEU As Single
    Public Anzahlung As Single
    Public Restzahlung As Single
    Dim crewclick As Boolean
    Public Wochen As Integer
    Dim kmgeld As Single
    Dim OhneClubtext55 As Single
    Dim Versicherung As Single
    Dim Charterkosten As Single
    Dim Bordkassa As Single
    Dim skipperant As Single
    Dim speicherButton As Boolean = False
    Dim KalkAlt As String
    Dim KalkNeu As String
    Dim lAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim caAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kabinenbucher As Integer = 0
    Private Sub Kalkulation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
        ' Autokosten - Textbox7 in Toernkalkulation(Reserve3) gespeichert 
        ' Datum Anzahlung  in Toernkalkulation(Reserve2)
        ' Datum Restzahlung  in Toernkalkulation(Reserve1)
        ' Anzahlung in Bootkalkulation(R1) gespeichert
        ' Alter in Bootkalkulation(R2) gespeichert
        ' IDToern wird nicht mehr verwendet


        Me.taVertrag.Fill(Me.dsVersicherung.Vertrag)
        Me.taVersicherter.Fill(Me.dsVersicherung.Versicherter)
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taBootKalkulation.Fill(Me.dsToernverwaltung.BootKalkulation)
        Me.taToernKalkulation.Fill(Me.dsToernverwaltung.ToernKalkulation)

        Anzahlung = GetSetting("toern", "Anzahlung", "T", "60")
        Restzahlung = GetSetting("toern", "Restzahlung", "T", "40")
        Wochen = GetSetting("toern", "Wochen", "T", "6")
        kmgeld = GetSetting("toern", "Fahrgeld", "T", "42")
        kmgeld = kmgeld / 100
        '       Formularloeschen()
        Dim lp As System.Data.DataRowView = bsListdaten.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsBoot.Current
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from CrewAdressen order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        iii = bsCrewAdressen.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.CrewAdressen.Rows(i)("vzname").ToString
            ComboBox2.Items.Add(aaa)
            ComboBox3.Items.Add(aaa)
        Next

        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Boot order by Bootname"
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        pAdapter.Fill(dsToernverwaltung.Boot)
        DbAccess.SafePosition(bsBoot)
        iii = bsBoot.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.Boot.Rows(i)("Bootname").ToString
            ComboBox1.Items.Add(aaa)
        Next
        With DataGridView3
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        With DataGridView2.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        With DataGridView3.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsToernKalkulation.AddNew()
        aenderung = False
        '       HelpProvider.SetHelpString(Me.TextBox2, "Test Text")
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        MaskedTextBox3.Mask = "00.00.0000"
        MaskedTextBox4.Mask = "00.00.0000"
        MaskedTextBox6.Mask = "00.00.0000"
        MaskedTextBox7.Mask = "00.00.0000"
        MaskedTextBox5.Mask = "00.00.0000"
        MaskedTextBox8.Mask = "00.00.0000"
        MaskedTextBox9.Mask = "00.00.0000"
        MaskedTextBox10.Mask = "00.00.0000"
        MaskedTextBox11.Mask = "00.00.0000"
        MaskedTextBox12.Mask = "00.00.0000"
        MaskedTextBox13.Mask = "00.00.0000"
        MaskedTextBox14.Mask = "00.00.0000"
        MaskedTextBox15.Mask = "00.00.0000"
        MaskedTextBox16.Mask = "00.00.0000"
        MaskedTextBox17.Mask = "00.00.0000"
        MaskedTextBox18.Mask = "00.00.0000"
        MaskedTextBox19.Mask = "00.00.0000"
        MaskedTextBox20.Mask = "00.00.0000"
        MaskedTextBox21.Mask = "00.00.0000"
        MaskedTextBox22.Mask = "00.00.0000"
        MaskedTextBox23.Mask = "00.00.0000"
        MaskedTextBox24.Mask = "00.00.0000"
        MaskedTextBox25.Mask = "00.00.0000"
        MaskedTextBox26.Mask = "00.00.0000"
        With DataGridView1
            .Columns(0).Width = 250
        End With
        Formularloeschen()
        TextBox2.Text = GetSetting("Toern", "Logbuch", "T", "")
        GroupBox13.Enabled = False
    End Sub
    Private Sub datenbanknul()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernkalkulation.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern like 'XxXxXXxxXxxXxxY'"
        bsToernkalkulation.CancelEdit()
        dsToernverwaltung.ToernKalkulation.Clear()
        xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        bsToernkalkulation.AddNew()
    End Sub
    Private Sub Formularloeschen()
        datenbanknul()
        IDcheck = False
        picture = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = "0"
        TextBox4.Text = ""
        TextBox5.Text = "0"
        TextBox6.Text = "0"
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = "0"
        TextBox11.Text = "0"
        TextBox14.Text = "0"
        TextBox15.Text = "0"
        TextBox16.Text = "0"
        TextBox17.Text = "0"
        TextBox18.Text = "0"
        TextBox19.Text = "0"
        TextBox20.Text = "0"
        TextBox21.Text = "0"
        TextBox22.Text = "0"
        TextBox23.Text = "0"
        TextBox24.Text = "0"
        TextBox25.Text = "0"
        TextBox26.Text = "0"
        TextBox47.Text = "0"
        TextBox48.Text = "0"
        TextBox49.Text = "0"
        TextBox50.Text = "0"
        TextBox55.Text = "0"
        TextBox56.Text = "0"
        TextBox57.Text = "0"
        TextBox58.Text = "0"
        TextBox59.Text = "0"
        TextBox60.Text = "0"
        TextBox61.Text = "0"
        TextBox62.Text = "0"
        TextBox64.Text = "0"
        TextBox75.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label30.Text = "0"
        Label45.Text = "0"
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
        MaskedTextBox6.Text = ""
        MaskedTextBox7.Text = ""
        crewclick = False
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        Checkcharter.Checked = False
        Checkkassa.Checked = False
        Checkvers.Checked = False
        checkboxLöschen()
        aenderung = False
        DataGridView1.Visible = False
        GroupBox1.Enabled = True
        Button3.Enabled = False
        GroupBox2.Text = "Bemerkung"
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        DataGridView3.Visible = False
        speicherButton = False
        KalkAlt = ""
        KalkNeu = ""
        datumrest = Now
        datumanzahlung = Now
        '       GroupBox13.Enabled = False
        '       MaskedTextBox6.Enabled = False
        '      MaskedTextBox7.Enabled = False
    End Sub
    Private Sub checkboxLöschen()
        MaskedTextBox8.Text = ""
        MaskedTextBox9.Text = ""
        MaskedTextBox10.Text = ""
        MaskedTextBox11.Text = ""
        MaskedTextBox12.Text = ""
        MaskedTextBox13.Text = ""
        MaskedTextBox14.Text = ""
        MaskedTextBox15.Text = ""
        MaskedTextBox16.Text = ""
        MaskedTextBox17.Text = ""
        MaskedTextBox18.Text = ""
        MaskedTextBox19.Text = ""
        MaskedTextBox20.Text = ""
        MaskedTextBox21.Text = ""
        MaskedTextBox22.Text = ""
        MaskedTextBox23.Text = ""
        MaskedTextBox24.Text = ""
        MaskedTextBox25.Text = ""
        MaskedTextBox26.Text = ""
        Label60.Text = ""
        Label61.Text = ""
        Label62.Text = ""
        Label63.Text = ""
        Label64.Text = ""
        Label65.Text = ""
        Label66.Text = ""
        Label67.Text = ""
        Label68.Text = ""
        Label69.Text = ""
        TextBox27.Text = "0"
        TextBox28.Text = "0"
        TextBox29.Text = "0"
        TextBox30.Text = "0"
        TextBox31.Text = "0"
        TextBox32.Text = "0"
        TextBox33.Text = "0"
        TextBox34.Text = "0"
        TextBox35.Text = "0"
        TextBox36.Text = "0"
        TextBox37.Text = "0"
        TextBox38.Text = "0"
        TextBox39.Text = "0"
        TextBox40.Text = "0"
        TextBox41.Text = "0"
        TextBox42.Text = "0"
        TextBox43.Text = "0"
        TextBox44.Text = "0"
        TextBox45.Text = "0"
        TextBox46.Text = "0"
        TextBox76.Text = "0"
        TextBox77.Text = "0"
        TextBox78.Text = "0"
        TextBox79.Text = "0"
        TextBox80.Text = "0"
        TextBox81.Text = "0"
        TextBox82.Text = "0"
        TextBox83.Text = "0"
        TextBox84.Text = "0"
        TextBox85.Text = "0"
        CheckBox1.Text = ""
        CheckBox2.Text = ""
        CheckBox3.Text = ""
        CheckBox4.Text = ""
        CheckBox5.Text = ""
        CheckBox6.Text = ""
        CheckBox7.Text = ""
        CheckBox8.Text = ""
        CheckBox9.Text = ""
        CheckBox10.Text = ""
        CheckBox11.Text = ""
        CheckBox12.Text = ""
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False
        CheckBox9.Visible = False
        CheckBox10.Visible = False
        CheckBox11.Visible = False
        CheckBox12.Visible = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
    End Sub
    Private Sub suchen()
        ' Kalkulation suchen
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim tname As String
        Dim r As System.Data.DataRowView = bsToernKalkulation.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox2.Text = RTrim(TextBox2.Text)
        If TextBox2.Text > "  " Then
            If IsNumeric(TextBox2.Text) And Len(TextBox2.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where year(Toernanfang) like '%" & TextBox2.Text & "%'  order by toern"
            Else
                If Len(TextBox2.Text) > 1 Then
                    If Mid(TextBox2.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox2.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation  order by toern"
                    Else
                        tname = TextBox2.Text
                        xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern = '" & TextBox2.Text & "' order by toern"
                        bsToernKalkulation.CancelEdit()
                        '                       aenderung = True
                        dsToernverwaltung.ToernKalkulation.Clear()
                        xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
                        If bsToernKalkulation.Count = 0 Then
                            TextBox2.Text = tname
                            xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern like '%" & TextBox2.Text & "%' order by toern"
                        End If
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where mid(toern,1,1) like '%" & TextBox2.Text & "%' order by toern"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation order by toern"
        End If
        bsToernKalkulation.CancelEdit()
        '        aenderung = True
        dsToernverwaltung.ToernKalkulation.Clear()
        xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        '      ButtonCrewSuchen.Enabled = False
        Select Case bsToernKalkulation.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation  order by toern"
                xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
                 Formularloeschen()
            Case 1
                DbAccess.SafePosition(bsToernKalkulation)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                Restdatum = MaskedTextBox4.Text
                KalkAlt = dsToernverwaltung.ToernKalkulation.Rows(0)("Toern").ToString
                MaskedTextBox6.Enabled = True
                MaskedTextBox7.Enabled = True
                If IsDate(TextBox70.Text) Then
                    datumanzahlung = TextBox70.Text
                    MaskedTextBox6.Text = TextBox70.Text
                End If
                If IsDate(TextBox71.Text) Then
                    datumrest = TextBox71.Text
                    MaskedTextBox7.Text = TextBox71.Text
                End If
                RabattBoot()
                gesamtkosten()
                CrewlisteAnzeigen()
                '            CrewlisteAnzeigen()
                If TextBox1.Text > 0 Then
                    ButtonCrewSuchen.Enabled = True
                End If
                GroupBox13.Enabled = True
                GroupBox1.Enabled = True
            Case Else
                GroupBox1.Enabled = False
                GroupBox2.Text = "Törn auswählen mit Doppelklick"
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                bsToernKalkulation.Position = position
                buch1 = ""
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
                DataGridView2.Visible = False
                DataGridView3.Visible = False
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsToernkalkulation.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.ToernKalkulation.Rows(i)("toern").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub RabattBoot()
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsBoot.Current
        Dim NameBoot As String
        Dim lang As Integer

        lang = ComboBox1.Text.IndexOf("/")
        If lang < 0 Then
            NameBoot = ComboBox1.Text
        Else
            NameBoot = ComboBox1.Text.Substring(0, lang)
        End If
        lang = Len(NameBoot)
        If lang = 0 Then
            Label56.Visible = False
        Else
            pAdapter.SelectCommand = New OleDb.OleDbCommand
            pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            pAdapter.SelectCommand.CommandText = "Select * from Boot where Bootname like '%" & NameBoot & "%' order by Bootname"
            bsBoot.CancelEdit()
            dsToernverwaltung.Boot.Clear()
            pAdapter.Fill(dsToernverwaltung.Boot)
            DbAccess.SafePosition(bsBoot)
            If bsBoot.Count > 0 Then
                bootsrabatt = dsToernverwaltung.Boot.Rows(0)("Clubnachlas")
                If Not DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Reinigung")) Then
                    TextBox56.Text = dsToernverwaltung.Boot.Rows(0)("Reinigung")
                Else
                    TextBox56.Text = 0
                End If

                If Not DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Permit")) Then
                    TextBox60.Text = dsToernverwaltung.Boot.Rows(0)("Permit")
                Else
                    TextBox60.Text = 0
                End If
                Dim tage As Single
                If MaskedTextBox3.Text > "  ,  ,    " Then
                    '              tage = DateDiff("d", CDate(MaskedTextBox3.Text), CDate(MaskedTextBox4.Text))
                    Dim d1 As Date = MaskedTextBox3.Text
                    Dim d2 As Date = MaskedTextBox4.Text
                    Dim diff As TimeSpan = d2 - d1
                    tage = diff.Days
                End If
                If Not DBNull.Value.Equals(dsToernverwaltung.Boot.Rows(0)("Aussenborder")) Then
                    If tage > 7 Then
                        TextBox57.Text = dsToernverwaltung.Boot.Rows(0)("Aussenborder") * 2
                    Else
                        TextBox57.Text = dsToernverwaltung.Boot.Rows(0)("Aussenborder")
                    End If
                Else
                    TextBox57.Text = 0
                End If
                If bootsrabatt Then
                    Label56.Visible = True
                Else
                    Label56.Visible = False
                End If
            Else
                MsgBox("Boot fehlt")
            End If
        End If
    End Sub
    Private Sub cla(ByVal satznr, ByVal chBox, ByVal chfix)
        bsBootKalkulation.Position = satznr

        chfix.checked = dsToernverwaltung.BootKalkulation.Rows(satznr)("Fixpreis")
        chBox.Text = dsToernverwaltung.BootKalkulation.Rows(satznr)("vzname").ToString
        If dsToernverwaltung.BootKalkulation.Rows(satznr)("bezahlt").ToString > "" Then
            anzahl = dsToernverwaltung.BootKalkulation.Rows(satznr)("bezahlt").ToString
        Else
            anzahl = 0
        End If
        If chfix.checked Then
            beitrag = dsToernverwaltung.BootKalkulation.Rows(satznr)("anteil").ToString
        Else
            If dsToernverwaltung.BootKalkulation.Rows(satznr)("Clubmitglied") And bootsrabatt Then
                beitrag = CharVerAnteilClub.ToString("##,##.00") + " €"
            Else
                beitrag = CharVerAnteil.ToString("##,##.00") + " €"
            End If
        End If
        If IsDBNull(dsToernverwaltung.BootKalkulation.Rows(satznr)("datumanzahlung")) Then
            datumanzahlung = MaskedTextBox6.Text
        Else
            datumanzahlung = dsToernverwaltung.BootKalkulation.Rows(satznr)("datumanzahlung")
        End If
        If IsDBNull(dsToernverwaltung.BootKalkulation.Rows(satznr)("datumrest")) Then
            datumrest = MaskedTextBox7.Text
        Else
            datumrest = dsToernverwaltung.BootKalkulation.Rows(satznr)("datumrest")
        End If
        If IsDBNull(dsToernverwaltung.BootKalkulation.Rows(satznr)("R1")) Then
            anz = 0
        Else
            anz = dsToernverwaltung.BootKalkulation.Rows(satznr)("R1")
        End If
        kosten = dsToernverwaltung.BootKalkulation.Rows(satznr)("kosten").ToString
        chBox.Visible = True
        chBox.Checked = True
    End Sub
    Private Sub CrewlisteAnzeigen()

        kabinenbucher = 0
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current()
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern = '" & TextBox2.Text & "' order by vzname"
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        '     Kabine0()
        aaa = charteranteil
        ij = bsBootKalkulation.Count
        If ij >= 1 Then
            cla(0, CheckBox1, CheckBox16)
            KabineEinlesen(1)
            TextBox28.Text = anzahl.ToString("##,#0.00") + " €"
            TextBox27.Text = beitrag.ToString("##,#0.00") + " €"
            TextBox82.Text = anz.ToString("##,#0.00") + " €"
            MaskedTextBox5.Text = SafeData.FormatDateDe(datumanzahlung)
            MaskedTextBox8.Text = SafeData.FormatDateDe(datumrest)
            Label60.Text = kosten.ToString("##,#0.00") + " €"
            If ij >= 2 Then
                cla(1, CheckBox2, CheckBox17)
                KabineEinlesen(2)
                TextBox29.Text = anzahl.ToString("##,#0.00") + " €"
                TextBox30.Text = beitrag.ToString("##,#0.00") + " €"
                TextBox84.Text = anz.ToString("##,#0.00") + " €"
                MaskedTextBox10.Text = SafeData.FormatDateDe(datumanzahlung)
                MaskedTextBox9.Text = SafeData.FormatDateDe(datumrest)
                Label61.Text = kosten.ToString("##,#0.00") + " €"
                If ij >= 3 Then
                    cla(2, CheckBox3, CheckBox18)
                    KabineEinlesen(3)
                    TextBox31.Text = anzahl.ToString("##,#0.00") + " €"
                    TextBox32.Text = beitrag.ToString("##,#0.00") + " €"
                    TextBox85.Text = anz.ToString("##,#0.00") + " €"
                    MaskedTextBox12.Text = SafeData.FormatDateDe(datumanzahlung)
                    MaskedTextBox11.Text = SafeData.FormatDateDe(datumrest)
                    Label62.Text = kosten.ToString("##,#0.00") + " €"
                    If ij >= 4 Then
                        cla(3, CheckBox4, CheckBox19)
                        KabineEinlesen(4)
                        TextBox33.Text = anzahl.ToString("##,#0.00") + " €"
                        TextBox34.Text = beitrag.ToString("##,#0.00") + " €"
                        TextBox83.Text = anz.ToString("##,#0.00") + " €"
                        MaskedTextBox14.Text = SafeData.FormatDateDe(datumanzahlung)
                        MaskedTextBox13.Text = SafeData.FormatDateDe(datumrest)
                        Label63.Text = kosten.ToString("##,#0.00") + " €"
                        If ij >= 5 Then
                            cla(4, CheckBox5, CheckBox20)
                            KabineEinlesen(5)
                            TextBox35.Text = anzahl.ToString("##,#0.00") + " €"
                            TextBox36.Text = beitrag.ToString("##,#0.00") + " €"
                            TextBox81.Text = anz.ToString("##,#0.00") + " €"
                            MaskedTextBox16.Text = SafeData.FormatDateDe(datumanzahlung)
                            MaskedTextBox15.Text = SafeData.FormatDateDe(datumrest)
                            Label64.Text = kosten.ToString("##,#0.00") + " €"
                            If ij >= 6 Then
                                cla(5, CheckBox6, CheckBox21)
                                KabineEinlesen(6)
                                TextBox37.Text = anzahl.ToString("##,#0.00") + " €"
                                TextBox38.Text = beitrag.ToString("##,#0.00") + " €"
                                TextBox80.Text = anz.ToString("##,#0.00") + " €"
                                MaskedTextBox18.Text = SafeData.FormatDateDe(datumanzahlung)
                                MaskedTextBox17.Text = SafeData.FormatDateDe(datumrest)
                                Label65.Text = kosten.ToString("##,#0.00") + " €"
                                If ij >= 7 Then
                                    cla(6, CheckBox7, CheckBox22)
                                    KabineEinlesen(7)
                                    TextBox39.Text = anzahl.ToString("##,#0.00") + " €"
                                    TextBox40.Text = beitrag.ToString("##,#0.00") + " €"
                                    TextBox79.Text = anz.ToString("##,#0.00") + " €"
                                    MaskedTextBox20.Text = SafeData.FormatDateDe(datumanzahlung)
                                    MaskedTextBox19.Text = SafeData.FormatDateDe(datumrest)
                                    Label66.Text = kosten.ToString("##,#0.00") + " €"
                                    If ij >= 8 Then
                                        cla(7, CheckBox8, CheckBox23)
                                        TextBox41.Text = anzahl.ToString("##,#0.00") + " €"
                                        KabineEinlesen(8)
                                        TextBox42.Text = beitrag.ToString("##,#0.00") + " €"
                                        TextBox78.Text = anz.ToString("##,#0.00") + " €"
                                        MaskedTextBox22.Text = SafeData.FormatDateDe(datumanzahlung)
                                        MaskedTextBox21.Text = SafeData.FormatDateDe(datumrest)
                                        Label67.Text = kosten.ToString("##,#0.00") + " €"
                                        If ij >= 9 Then
                                            cla(8, CheckBox9, CheckBox24)
                                            KabineEinlesen(9)
                                            TextBox43.Text = anzahl.ToString("##,#0.00") + " €"
                                            TextBox44.Text = beitrag.ToString("##,#0.00") + " €"
                                            TextBox77.Text = anz.ToString("##,#0.00") + " €"
                                            MaskedTextBox24.Text = SafeData.FormatDateDe(datumanzahlung)
                                            MaskedTextBox23.Text = SafeData.FormatDateDe(datumrest)
                                            Label68.Text = kosten.ToString("##,#0.00") + " €"
                                            If ij >= 10 Then
                                                cla(9, CheckBox10, CheckBox25)
                                                KabineEinlesen(10)
                                                TextBox45.Text = anzahl.ToString("##,#0.00") + " €"
                                                TextBox46.Text = beitrag.ToString("##,#0.00") + " €"
                                                TextBox76.Text = anz.ToString("##,#0.00") + " €"
                                                MaskedTextBox26.Text = SafeData.FormatDateDe(datumanzahlung)
                                                MaskedTextBox25.Text = SafeData.FormatDateDe(datumrest)
                                                Label69.Text = kosten.ToString("##,#0.00") + " €"
                                                If ij >= 11 Then
                                                    cla(10, CheckBox11, CheckBox25)
                                                    KabineEinlesen(11)
                                                    TextBox47.Text = anzahl.ToString("##,#0.00") + " €"
                                                    TextBox48.Text = beitrag.ToString("##,#0.00") + " €"
                                                    If ij >= 12 Then
                                                        cla(11, CheckBox12, CheckBox25)
                                                        KabineEinlesen(12)
                                                        TextBox49.Text = anzahl.ToString("##,#0.00") + " €"
                                                        TextBox50.Text = beitrag.ToString("##,#0.00") + " €"
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        aaa = ""
    End Sub

    Private Sub gesamtkosten()
        Dim Gesamtkosten As Single
        Dim Anzahl As Single
        Dim bordanteil As Single
        Dim versicherunganteil As Single
        Dim OhneClubrabatt As Single
        Dim skipperverdienst As Single
        Dim stornovers As Single
        If TextBox59.Text = "" Then
            TextBox59.Text = 0
        End If
        If TextBox58.Text = "" Then
            TextBox58.Text = 0
        End If
        If TextBox7.Text = "" Then
            TextBox7.Text = 0
        End If
        Charterkosten = TextBox3.Text
        Charterkosten += -Charterkosten * TextBox58.Text / 100
        OhneClubrabatt = Charterkosten
        Charterkosten += -Charterkosten * TextBox59.Text / 100
        '        Charterkosten += TextBox62.Text
        Label45.Text = Charterkosten.ToString("##,##.00") + " €"
        Reisekosten = TextBox5.Text
        Reisekosten = Reisekosten + TextBox6.Text
        Reisekosten = Reisekosten + TextBox10.Text
        Reisekosten = Reisekosten + TextBox11.Text
        Label30.Text = Reisekosten.ToString("##,##.00") + " €"
        Label28.Text = "0.00 €"
        Autokosten = TextBox7.Text * kmgeld / 3                                           ' Textbox7 in Reserve3 gespeichert
        TextBox61.Text = Autokosten.ToString
        Label28.Text = Autokosten.ToString("##,##.00") + " €"
        Label70.Text = kmgeld.ToString + " €"
        Reisekosten += Autokosten
        Bordkassa = TextBox14.Text
        Bordkassa = Bordkassa + TextBox15.Text
        Bordkassa = Bordkassa + TextBox16.Text
        Bordkassa = Bordkassa + TextBox17.Text
        Bordkassa = Bordkassa + TextBox18.Text
        Bordkassa = Bordkassa + TextBox19.Text
        Bordkassa = Bordkassa + TextBox56.Text
        Bordkassa = Bordkassa + TextBox57.Text
        Bordkassa = Bordkassa + TextBox60.Text
        Label27.Text = Bordkassa.ToString("##,##.00") + " €"
        Versicherung = TextBox20.Text
        If IsNumeric(TextBox21.Text) Then
            Versicherung = Versicherung + TextBox21.Text
        End If
        Versicherung = Versicherung + TextBox22.Text
        Versicherung = Versicherung + TextBox23.Text
        Versicherung = Versicherung + TextBox24.Text
        If CheckBox13.Checked Then
            '         stornoperz = MaskedTextBox5.Text
            '        stornovers = stornoperz * (TextBox3.Text + TextBox5.Text * (TextBox1.Text + 1)) / 100
            TextBox25.Text = stornovers.ToString("##,##.00")
        End If
        Versicherung = Versicherung + TextBox25.Text
        If TextBox64.Text > "" Then
            Versicherung = Versicherung + TextBox64.Text
        Else
            TextBox64.Text = "0"
        End If
        Gesamtkosten = Charterkosten + Bordkassa + Versicherung + TextBox62.Text
        TextBox26.Text = Gesamtkosten.ToString("##,##.00") + " €"
        Label26.Text = Versicherung.ToString("##,##.00") + " €"

        If TextBox1.Text > "0" Then
            Anzahl = TextBox1.Text

            If Checkcharter.Checked Then
                Charteranteil = Charterkosten / (Anzahl + 1 + kabinenbucher)
            Else
                Charteranteil = Charterkosten / Anzahl + kabinenbucher
            End If

            If Checkkassa.Checked Then
                bordanteil = Bordkassa / (Anzahl + 1)
            Else
                bordanteil = Bordkassa / Anzahl
            End If

            If Checkvers.Checked Then
                versicherunganteil = Versicherung / (Anzahl + 1)
            Else
                versicherunganteil = Versicherung / Anzahl
            End If

            skipperverdienst = TextBox62.Text / Anzahl

            n = Charteranteil + bordanteil + versicherunganteil + Reisekosten + skipperverdienst
            If Checkcharter.Checked Then
                skipperant = Charteranteil
            Else
                skipperant = 0
            End If
            If Checkvers.Checked Then
                skipperant += versicherunganteil
            End If
            TextBox55.Text = n.ToString("##,##.00") + " €"
            OhneClubtext55 = n.ToString("##,##.00") + " €"
            CharVerAnteilClub = Charteranteil + versicherunganteil + skipperverdienst

            If bootsrabatt Then
                If Checkcharter.Checked Then
                    Charteranteil = OhneClubrabatt / (Anzahl + 1 + kabinenbucher)
                    '                Charteranteil = (OhneClubrabatt + OhneClubrabatt * TextBox59.Text / 100) / (Anzahl + 1)
                Else
                    Charteranteil = OhneClubrabatt / Anzahl + kabinenbucher
                End If
                OhneClubtext55 = Charteranteil + bordanteil + versicherunganteil + Reisekosten + skipperverdienst
            End If
            CharVerAnteil = Charteranteil + versicherunganteil + skipperverdienst

            TextBox67.Text = CharVerAnteil.ToString
            '            CrewlisteAnzeigen()
        Else
            n = Gesamtkosten + Reisekosten
            TextBox55.Text = n.ToString("##,##.00") + " €"

        End If
    End Sub

    Private Sub SpeichernButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernButton.Click
        Dim msg As Integer
        speichern()
    End Sub
    Private Sub speichern()
        '                                Speichern
        '
        aaa = kabinenbucher
        Dim nameTab(15) As String
        If IsDate(MaskedTextBox3.Text) Then
        Else
            MsgBox("Törnbeginn fehlt, speichern nicht möglich")
            Exit Sub
        End If
        If IsDate(MaskedTextBox4.Text) Then
        Else
            MsgBox("Törnende fehlt, speichern nicht möglich")
            Exit Sub
        End If
        If IsDate(MaskedTextBox6.Text) Then
        Else
            MsgBox("Datum Anzahlung fehlt, speichern nicht möglich")
            Exit Sub
        End If
        If IsDate(MaskedTextBox7.Text) Then
        Else
            MsgBox("Datum Restzahlung fehlt, speichern nicht möglich.")
            Exit Sub
        End If
        If IsNumeric(TextBox1.Text) Then
        Else
            TextBox1.Text = 1
        End If
        speicherButton = True
        If TextBox2.Text > "   " Then
            Dim bbb As String
            gesamtkosten()
            TextBox12.Text = ComboBox1.Text
            RabattBoot()
            TextBox63.Text = ComboBox2.Text
            TextBox66.Text = CharVerAnteilClub
            bbb = KalkAlt
            KalkNeu = TextBox2.Text
            Dim taAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current()
            taAdapter.SelectCommand = New OleDb.OleDbCommand
            taAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            taAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern = '" & bbb & "' order by vzname"
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            taAdapter.Fill(dsToernverwaltung.BootKalkulation)
            ij = bsBootKalkulation.Count - 1
            If ij > 0 Then
                For Me.iii = 0 To ij
                    nameTab(iii) = dsToernverwaltung.BootKalkulation.Rows(iii)("vzname")
                Next

                For Me.iii = 0 To ij
                    aaa = nameTab(iii)
                    taAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern = '" & bbb & "' and vzname = '" & aaa & "' order by vzname"
                    bsBootKalkulation.CancelEdit()
                    dsToernverwaltung.BootKalkulation.Clear()
                    taAdapter.Fill(dsToernverwaltung.BootKalkulation)
                    '                    BootKalkSpeichern()
                    TextBox51.Text = TextBox2.Text
                    TextBox13.Text = aaa
                    TextBox73.Text = toernID
                    Kabinespeichern(iii + 1)
                    If Not CheckBox26.Checked Then
                        If CheckBox15.Checked And bootsrabatt Then
                            TextBox52.Text = TextBox55.Text
                            TextBox74.Text = CharVerAnteilClub.ToString
                            TextBox75.Text = (CharVerAnteilClub * Anzahlung / 100).ToString
                        Else
                            TextBox52.Text = OhneClubtext55.ToString
                            TextBox74.Text = CharVerAnteil.ToString
                            TextBox75.Text = (CharVerAnteil * Anzahlung / 100).ToString
                        End If
                        If MaskedTextBox6.Text > "  ,  ,     " Then
                            '                          TextBox70.Text = MaskedTextBox6.Text
                            TextBox70.Text = datumanzahlung
                        Else
                            TextBox70.Text = Now.AddDays(5)
                        End If
                        If MaskedTextBox7.Text > "  ,  ,     " Then
                            TextBox71.Text = datumrest
                            '                         TextBox71.Text = MaskedTextBox7.Text
                        Else
                            TextBox71.Text = Now.AddDays(5)
                        End If
                        TextBox70.Text = SafeData.FormatDateDe(TextBox70.Text)
                        '                    MaskedTextBox7.Text = TextBox71.Text.Substring(0, 10)
                        '                   MaskedTextBox6.Text = TextBox70.Text

                        TextBox54.Text = TextBox12.Text
                        '                 TextBox53.Text = 0
                        bsBootKalkulation.EndEdit()
                        taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
                        CheckBox47.Checked = False
                    End If
                Next
                SaveSetting("Toern", "Logbuch", "T", TextBox2.Text)
            End If
            If crewclick = False And bsBootKalkulation.Count < 1 Then
                '               MsgBox("Datum An- und Restzahlung wird mit der Crew gespeichert.")
            End If

            If aenderung Then
                '               dsToernverwaltung.ToernKalkulation.Rows(0)("idToern") = TextBox72.Text
                Try
                    bsToernKalkulation.EndEdit()
                    taToernKalkulation.Update(dsToernverwaltung.ToernKalkulation)
                Catch xx As Exception
                End Try

                iii = 0
            Else
                TextBox70.Text = MaskedTextBox6.Text
                TextBox71.Text = MaskedTextBox7.Text
                bsToernKalkulation.AddNew()
                taToernKalkulation.Update(dsToernverwaltung.ToernKalkulation)

                Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
                Dim r As System.Data.DataRowView = bsToernKalkulation.Current
                xAdapter.SelectCommand = New OleDb.OleDbCommand
                xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern = '" & bbb & "' "
                dsToernverwaltung.ToernKalkulation.Clear()
                xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
                aaa = bsToernKalkulation.Count
                If aaa > 0 Then
                    '                  dsToernverwaltung.ToernKalkulation.Rows(0)("idToern") = TextBox72.Text
                    '               dsToernverwaltung.ToernKalkulation.Rows(0)("Reserve2") = MaskedTextBox6.Text
                    '              dsToernverwaltung.ToernKalkulation.Rows(0)("Reserve1") = MaskedTextBox7.Text
                    '              toernID = TextBox72.Text
                    bsToernKalkulation.EndEdit()
                    taToernKalkulation.Update(dsToernverwaltung.ToernKalkulation)
                End If
            End If
            If namensaenderung Then
                taAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern = '" & ToernAlt & "' order by vzname"
                bsBootKalkulation.CancelEdit()
                dsToernverwaltung.BootKalkulation.Clear()
                taAdapter.Fill(dsToernverwaltung.BootKalkulation)
                ij = bsBootKalkulation.Count
                For Me.iii = 0 To ij - 1
                    dsToernverwaltung.BootKalkulation.Rows(iii)("Toern") = TextBox2.Text
                    '                       dsToernverwaltung.BootKalkulation.Rows(iii)("idToern") = toernID
                    bsBootKalkulation.EndEdit()
                    taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
                Next

            End If
            namensaenderung = False
            aenderung = False
            SpeichernButton.Text = "Speichern"
        Else
            MsgBox("Törnname ist Pflichteingabe")
            TextBox2.Focus()
        End If
        Me.Close()
    End Sub

    Private Sub FormularButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormularButton.Click
        Formularloeschen()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        IDcheck = True
        suchen()
        DataGridView1.Visible = False
        GroupBox1.Enabled = True
        GroupBox2.Text = "Bemerkung"
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        IDcheck = True
        suchen()
        DataGridView1.Visible = False
        GroupBox1.Enabled = True
        GroupBox2.Text = "Bemerkung"
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = CheckBNull.checkDBNull(TextBox1.Text)
        gesamtkosten()
        GroupBox13.Enabled = True
        If TextBox1.Text > 0 Then
            ButtonCrewSuchen.Enabled = True
        End If
    End Sub
    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.Text = TextBox2.Text.Replace("'", "´")
        ToernAlt = TextBox2.Text
        namensaenderung = False
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
            Formularloeschen()
        End If

    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.Text = TextBox2.Text.Replace("'", " ")
        If ToernAlt = "" Or ToernAlt = " " Or ToernAlt = TextBox2.Text Then
            GoTo ok
        End If
        namensaenderung = True
ok:
       End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.Text = CheckBNull.checkDBNull(TextBox3.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox5.Text = CheckBNull.checkDBNull(TextBox5.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        TextBox6.Text = CheckBNull.checkDBNull(TextBox6.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        gesamtkosten()
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text > "0" Then
            Reisekosten = TextBox7.Text * 0.42 / 3                                           ' Textbox7 in Reserve3 gespeichert
            TextBox61.Text = Reisekosten.ToString
            Label44.Text = "pro Person " + TextBox61.Text + " €"
        End If
    End Sub
    Private Sub TextBox10_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.LostFocus
        TextBox10.Text = CheckBNull.checkDBNull(TextBox10.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.LostFocus
        TextBox11.Text = CheckBNull.checkDBNull(TextBox11.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox14_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox14.LostFocus
        TextBox14.Text = CheckBNull.checkDBNull(TextBox14.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox15_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.LostFocus
        TextBox15.Text = CheckBNull.checkDBNull(TextBox15.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox16_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox16.LostFocus
        TextBox16.Text = CheckBNull.checkDBNull(TextBox16.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox17_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.LostFocus
        TextBox17.Text = CheckBNull.checkDBNull(TextBox17.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox18_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.LostFocus
        TextBox18.Text = CheckBNull.checkDBNull(TextBox18.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox19_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox19.LostFocus
        TextBox19.Text = CheckBNull.checkDBNull(TextBox19.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox20_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.LostFocus
        TextBox20.Text = CheckBNull.checkDBNull(TextBox20.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox21_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox21.LostFocus
        TextBox21.Text = CheckBNull.checkDBNull(TextBox21.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox22_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox22.LostFocus
        TextBox22.Text = CheckBNull.checkDBNull(TextBox22.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox23_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox23.LostFocus
        TextBox23.Text = CheckBNull.checkDBNull(TextBox23.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox24_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox24.LostFocus
        TextBox24.Text = CheckBNull.checkDBNull(TextBox24.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox25_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox25.LostFocus
        TextBox25.Text = CheckBNull.checkDBNull(TextBox25.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox28_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox28.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox1.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '          geskosten()
            TextBox53.Text = TextBox28.Text      ' Bezahlt
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox29_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox29.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox2.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '          geskosten()
            TextBox53.Text = TextBox29.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox31_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox31.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox3.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '           geskosten()
            TextBox53.Text = TextBox31.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox33_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox33.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox4.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '           geskosten()
            TextBox53.Text = TextBox33.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox35_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox35.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox5.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '          geskosten()
            TextBox53.Text = TextBox35.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox37_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox37.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox6.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '           geskosten()
            TextBox53.Text = TextBox37.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox39_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox39.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox7.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '           geskosten()
            TextBox53.Text = TextBox39.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox41_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox41.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox8.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '           geskosten()
            TextBox53.Text = TextBox41.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox43_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox43.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox9.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '          geskosten()
            TextBox53.Text = TextBox43.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox45_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox45.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox10.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '            geskosten()
            TextBox53.Text = TextBox45.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox47_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox47.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox11.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '           geskosten()
            TextBox53.Text = TextBox47.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox49_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox49.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox12.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            '            geskosten()
            TextBox53.Text = TextBox49.Text
            TextBox54.Text = TextBox12.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox58_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox58.LostFocus
        TextBox58.Text = CheckBNull.checkDBNull(TextBox58.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox59_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox59.LostFocus
        TextBox59.Text = CheckBNull.checkDBNull(TextBox59.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox60_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox60.LostFocus
        TextBox60.Text = CheckBNull.checkDBNull(TextBox60.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox61_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox61.LostFocus
        TextBox61.Text = CheckBNull.checkDBNull(TextBox61.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox62_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox62.LostFocus
        TextBox62.Text = CheckBNull.checkDBNull(TextBox62.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox64_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox64.LostFocus
        TextBox64.Text = CheckBNull.checkDBNull(TextBox64.Text)
        gesamtkosten()
    End Sub
    Private Sub TextBox82_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox82.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox1.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox82.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox84_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox84.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox2.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox84.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox85_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox85.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox3.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox85.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox83_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox83.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox4.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox83.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox81_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox81.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox5.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox81.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox80_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox80.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox6.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox80.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox79_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox79.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox7.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox79.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox78_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox78.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox8.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox78.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox77_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox77.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox9.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox77.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox76_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox76.LostFocus
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        aaa = CheckBox10.Text
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox75.Text = TextBox76.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        aaa = CheckBox1.Text
        If Not CheckBox1.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox1.Text = ""
                CheckBox1.Visible = False
                CheckBox16.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        aaa = CheckBox2.Text
        If Not CheckBox2.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox2.Text = ""
                CheckBox2.Visible = False
                CheckBox17.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        aaa = CheckBox3.Text
        If Not CheckBox3.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox3.Text = ""
                CheckBox3.Visible = False
                CheckBox18.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        aaa = CheckBox4.Text
        If Not CheckBox4.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox4.Text = ""
                CheckBox4.Visible = False
                CheckBox19.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        aaa = CheckBox5.Text
        If Not CheckBox5.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox5.Text = ""
                CheckBox5.Visible = False
                CheckBox20.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        aaa = CheckBox6.Text
        If Not CheckBox6.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox6.Text = ""
                CheckBox6.Visible = False
                CheckBox21.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        aaa = CheckBox7.Text
        If Not CheckBox7.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox7.Text = ""
                CheckBox7.Visible = False
                CheckBox22.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        aaa = CheckBox8.Text
        If Not CheckBox8.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox8.Text = ""
                CheckBox8.Visible = False
                CheckBox23.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        aaa = CheckBox9.Text
        If Not CheckBox9.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox9.Text = ""
                CheckBox9.Visible = False
                CheckBox24.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        aaa = CheckBox10.Text
        If Not CheckBox10.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count >= 0 Then
                ' löschen
                CheckBox10.Text = ""
                CheckBox10.Visible = False
                CheckBox25.Checked = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        aaa = CheckBox11.Text
        If Not CheckBox11.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count > 0 Then
                ' löschen
                CheckBox11.Text = ""
                CheckBox11.Visible = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        aaa = CheckBox12.Text
        If Not CheckBox12.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
            bsBootKalkulation.CancelEdit()
            dsToernverwaltung.BootKalkulation.Clear()
            tAdapter.Fill(dsToernverwaltung.BootKalkulation)
            If bsBootKalkulation.Count = 1 Then
                ' löschen
                CheckBox12.Text = ""
                CheckBox12.Visible = False
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung)
                checkboxLöschen()
                CrewlisteAnzeigen()
            End If
        End If
    End Sub
    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked Then
            lAdapter.SelectCommand = New OleDb.OleDbCommand
            lAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            lAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Kalkulation - Versicherung' "
            bsListdaten.CancelEdit()
            dsToernverwaltung.Listdaten.Clear()
            lAdapter.Fill(dsToernverwaltung.Listdaten)
            DbAccess.SafePosition(bsListdaten)
            If bsListdaten.Count = 1 Then
                comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString, 1)
                comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString, 2)
                comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString, 3)
                comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString, 4)
                comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString, 5)
                comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString, 6)
                comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString, 7)
                '               comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString, TextBox20.Text)
            End If
        End If
        gesamtkosten()
    End Sub

    Private Sub ButtonCrewSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrewSuchen.Click
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        aaa = ij
        If TextBox1.Text > "" Then
            If ij > TextBox1.Text Then
                MsgBox("Achtung, Boot ist überbucht!")
            End If
            If ij = TextBox1.Text Then
                MsgBox("Achtung, Boot ist voll!")
            End If
        Else
            MsgBox("Crewanzahl ohne Skipper wird auf 6 gestellt und kann geändert werden.")
            TextBox1.Text = "6"
        End If
        TextBox86.Visible = True
        Label79.Visible = True
        aaa = ""
        crewclick = True
        If MaskedTextBox7.Text > "  ,  ," Then
            TextBox71.Text = MaskedTextBox7.Text
            '          speichern()
            aenderung = False
            DataGridView3.Visible = True
            DataGridView3.Location = New Point(10, 20)
            GroupBox1.Enabled = False
            Button3.Enabled = True
            GroupBox2.Text = "Crew auswählen mit Doppelklick"
            TextBox86.Focus()
            '         ButtonCrewSuchen.Enabled = False
            '         Button4Bearbeiten.Enabled = False
        Else
            MsgBox("Datum der Restzahlung muss bestimmt werden!")
            MaskedTextBox7.Focus()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '                                                           Crewsuche beendet
        GroupBox5.Visible = True
        GroupBox6.Visible = True
        GroupBox7.Visible = True
        GroupBox8.Visible = True
        GroupBox9.Visible = True
        DataGridView3.Visible = False
        GroupBox1.Enabled = True
        Button3.Enabled = False
        ButtonCrewSuchen.Enabled = True
        GroupBox2.Text = "Bemerkung"
        CrewlisteAnzeigen()
        Button4Bearbeiten.Enabled = True
        TextBox86.Text = ""
        TextBox86.Visible = False
        Label79.Visible = False
        aaa = ij
        If ij > TextBox1.Text Then
            MsgBox("Achtung, Boot ist überbucht!")
        End If
        If ij = TextBox1.Text Then
            MsgBox("Achtung, Boot ist voll!")
        End If
        aaa = ""
    End Sub
    Private Sub LoeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoeschenButton.Click
        Dim xdAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernKalkulation.Current
        xdAdapter.SelectCommand = New OleDb.OleDbCommand
        xdAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        If TextBox2.Text > "  " Then
            xdAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern = '" & TextBox2.Text & "'"
        End If
        bsToernKalkulation.CancelEdit()
        aenderung = True
        dsToernverwaltung.ToernKalkulation.Clear()
        xdAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        Select Case bsToernKalkulation.Count
            Case 1
                aaa = TextBox2.Text
                bsToernKalkulation.RemoveCurrent()
                taToernKalkulation.Update(dsToernverwaltung.ToernKalkulation)
        End Select
        CrewLoeschen()
        Formularloeschen()
    End Sub
    Private Sub CrewLoeschen()
        Dim taAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current()
        Dim ij As Integer
        taAdapter.SelectCommand = New OleDb.OleDbCommand
        taAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        taAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern = '" & aaa & "' order by vzname"
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        taAdapter.Fill(dsToernverwaltung.BootKalkulation)
        ij = bsBootKalkulation.Count - 1
        If ij > 0 Then
            For Me.iii = 0 To ij
                bsBootKalkulation.RemoveCurrent()
                taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
            Next
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        KalenderSpeichern()
    End Sub

    Private Sub DataGridView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.DoubleClick
        ijj = DataGridView3.CurrentCell.RowIndex
        Restdatum = MaskedTextBox4.Text
        aaa = dsToernverwaltung.CrewAdressen.Rows(ijj)("VZName").ToString
         If CheckBox1.Text = "" Then
            CheckBox1.Text = aaa
            CheckBox1.Visible = True
            CheckBox1.Checked = True
            KabineEinlesen(1)
            '            CheckBox16.Checked = CheckBox26.Checked
        Else
            If CheckBox2.Text = "" Then
                CheckBox2.Text = aaa
                CheckBox2.Visible = True
                CheckBox2.Checked = True
                KabineEinlesen(2)
                '               CheckBox17.Checked = CheckBox26.Checked
            Else
                If CheckBox3.Text = "" Then
                    CheckBox3.Text = aaa
                    CheckBox3.Visible = True
                    CheckBox3.Checked = True
                    CheckBox47.Checked = CheckBox47.Checked
                    KabineEinlesen(3)
                    '                  CheckBox18.Checked = CheckBox26.Checked
                Else
                    If CheckBox4.Text = "" Then
                        CheckBox4.Text = aaa
                        CheckBox4.Visible = True
                        CheckBox4.Checked = True
                        KabineEinlesen(4)
                        '                     CheckBox19.Checked = CheckBox26.Checked
                    Else
                        If CheckBox5.Text = "" Then
                            CheckBox5.Text = aaa
                            CheckBox5.Visible = True
                            CheckBox5.Checked = True
                            KabineEinlesen(5)
                            '                        CheckBox20.Checked = CheckBox26.Checked
                        Else
                            If CheckBox6.Text = "" Then
                                CheckBox6.Text = aaa
                                CheckBox6.Visible = True
                                CheckBox6.Checked = True
                                KabineEinlesen(6)
                                '                           CheckBox21.Checked = CheckBox26.Checked
                            Else
                                If CheckBox7.Text = "" Then
                                    CheckBox7.Text = aaa
                                    CheckBox7.Visible = True
                                    CheckBox7.Checked = True
                                    KabineEinlesen(7)
                                    '                              CheckBox22.Checked = CheckBox26.Checked
                                Else
                                    If CheckBox8.Text = "" Then
                                        CheckBox8.Text = aaa
                                        CheckBox8.Visible = True
                                        CheckBox8.Checked = True
                                        KabineEinlesen(8)
                                        '                                 CheckBox23.Checked = CheckBox26.Checked
                                    Else
                                        If CheckBox9.Text = "" Then
                                            CheckBox9.Text = aaa
                                            CheckBox9.Visible = True
                                            CheckBox9.Checked = True
                                            KabineEinlesen(9)
                                            '                                    CheckBox24.Checked = CheckBox26.Checked
                                        Else
                                            If CheckBox10.Text = "" Then
                                                CheckBox10.Text = aaa
                                                CheckBox10.Visible = True
                                                CheckBox10.Checked = True
                                                KabineEinlesen(10)
                                                '                                       CheckBox25.Checked = CheckBox26.Checked
                                            Else
                                                If CheckBox11.Text = "" Then
                                                    CheckBox11.Text = aaa
                                                    CheckBox11.Visible = True
                                                    CheckBox11.Checked = True
                                                Else
                                                    If CheckBox12.Text = "" Then
                                                        CheckBox12.Text = aaa
                                                        CheckBox12.Visible = True
                                                        CheckBox12.Checked = True
                                                    Else
                                                        MsgBox("Max. 12 Personen werden verwaltet")
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 0 Then
            bsBootKalkulation.AddNew()
            If dsToernverwaltung.CrewAdressen.Rows(ijj)("gebdatum").ToString > "" Then
                TextBox127.Text = Year(Today) - Year(dsToernverwaltung.CrewAdressen.Rows(ijj)("gebdatum").ToString)
            Else
                TextBox127.Text = 0
            End If
            TextBox51.Text = TextBox2.Text
            TextBox13.Text = aaa
            TextBox73.Text = toernID
            CheckBox15.Checked = dsToernverwaltung.CrewAdressen.Rows(ijj)("clubmitglied")
            If CheckBox15.Checked And bootsrabatt Then
                TextBox52.Text = TextBox55.Text
                TextBox74.Text = CharVerAnteilClub.ToString
                TextBox75.Text = (CharVerAnteilClub * Anzahlung / 100).ToString
            Else
                TextBox52.Text = OhneClubtext55.ToString
                TextBox74.Text = CharVerAnteil.ToString
                TextBox75.Text = (CharVerAnteil * Anzahlung / 100).ToString
            End If
            If MaskedTextBox6.Text > "  ,  ,     " Then
                TextBox70.Text = MaskedTextBox6.Text
            Else
                TextBox70.Text = Now.AddDays(5)
            End If
            MaskedTextBox7.Text = datumrest
            If MaskedTextBox7.Text > "  ,  ,     " Then
                TextBox71.Text = MaskedTextBox7.Text
            Else
                TextBox71.Text = Now.AddDays(5)
            End If
            TextBox70.Text = SafeData.FormatDateDe(TextBox70.Text)
            '           MaskedTextBox7.Text = TextBox71.Text.Substring(0, 10)
            '          MaskedTextBox6.Text = TextBox70.Text

            TextBox54.Text = TextBox12.Text
            TextBox53.Text = 0
            bsBootKalkulation.AddNew()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
        TextBox86.Text = ""
        TextBox86.Focus()
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        GroupBox4.Visible = True
        picture = 2
    End Sub

    Private Sub KalenderSpeichern()
        Select Case picture
            Case 2
                MaskedTextBox3.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox3.Focus()
            Case 3
                MaskedTextBox2.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox2.Focus()
            Case 4
                MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox1.Focus()
            Case 5
                MaskedTextBox4.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox4.Focus()
            Case 8
                MaskedTextBox6.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox6.Focus()
            Case 9
                MaskedTextBox7.Text = MonthCalendar1.SelectionStart.ToString
                MaskedTextBox7.Focus()
        End Select
        GroupBox4.Visible = False
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        KalenderSpeichern()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        GroupBox4.Visible = True
        picture = 5
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        GroupBox4.BringToFront()
        GroupBox4.Visible = True
        picture = 4
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        GroupBox4.BringToFront()
        GroupBox4.Visible = True
        picture = 3
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox4.Visible = False
    End Sub

    Private Sub rbtnClick(ByVal sender As System.Object, _
ByVal e As System.EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click, RadioButton5.Click
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        Select Case True
            Case RadioButton1.Checked
                GroupBox5.Visible = True
                GroupBox5.Location = New Point(14, 305)
            Case RadioButton2.Checked
                GroupBox8.Visible = True
                GroupBox8.Location = New Point(14, 295)
            Case RadioButton3.Checked
                GroupBox9.Visible = True
                GroupBox9.Location = New Point(14, 305)
            Case RadioButton4.Checked
                GroupBox7.Visible = True
                GroupBox7.Location = New Point(14, 305)
            Case RadioButton5.Checked
                GroupBox6.Visible = True
                GroupBox6.Location = New Point(14, 305)
        End Select
        VersicherungSuchen()
    End Sub
    Private Sub VersicherungSuchen()
        Dim bbb As String
        Dim r As System.Data.DataRowView = bsVersicherter.Current
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim vAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        '       TextBox18.Text = RTrim(TextBox18.Text)
        If ComboBox2.Text > "  " Then
            If Len(ComboBox2.Text) > 1 Then
                If Mid(ComboBox2.Text, 2, 1) = "*" Then
                    xAdapter.SelectCommand.CommandText = "Select * from Versicherter order by VersicherterName"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Versicherter where VersicherterName like '%" & ComboBox2.Text & "%'  order by VersicherterName"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Versicherter where Mid(VersicherterName,1,1) like '%" & ComboBox2.Text & "%'  order by VersicherterName"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Versicherter order by VersicherterName"
        End If
        bsVersicherter.CancelEdit()
        dsVersicherung.Versicherter.Clear()
        xAdapter.Fill(dsVersicherung.Versicherter)
        Select Case bsVersicherter.Count
            Case 0
                MsgBox("Dieser Skipper ist nicht versichert")
                xAdapter.SelectCommand.CommandText = "Select * from Versicherter order by VersicherterName"
                xAdapter.Fill(dsVersicherung.Versicherter)
            Case 1
                DbAccess.SafePosition(bsVersicherter)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bbb = dsVersicherung.Versicherter.Rows(0)("Polizze").ToString
                aaa = dsVersicherung.Versicherter.Rows(0)("VersicherterName").ToString
                vAdapter.SelectCommand = New OleDb.OleDbCommand
                vAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
                vAdapter.SelectCommand.CommandText = "Select * from Vertrag where polizze like '%" & TextBox128.Text & "%'  order by Polizze"
                bsVertrag.CancelEdit()
                dsVersicherung.Vertrag.Clear()
                vAdapter.Fill(dsVersicherung.Vertrag)
                TextBox20.Text = dsVersicherung.Vertrag.Rows(0)("rech-kosten").ToString
                TextBox22.Text = dsVersicherung.Vertrag.Rows(0)("unf-kosten").ToString
                TextBox21.Text = "inkludiert"
                TextBox23.Text = dsVersicherung.Vertrag.Rows(0)("kau-kosten").ToString
                TextBox24.Text = dsVersicherung.Vertrag.Rows(0)("haf-kosten").ToString
                TextBox25.Text = dsVersicherung.Vertrag.Rows(0)("rue-kosten").ToString
                TextBox64.Text = dsVersicherung.Vertrag.Rows(0)("fol-kosten").ToString
            Case Else
                DbAccess.SafePosition(bsVersicherter)
                DataGridView1.Visible = True
        End Select
    End Sub
    Private Sub Checkcharter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Checkcharter.Click
        gesamtkosten()
    End Sub

    Private Sub Checkvers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Checkvers.Click
        gesamtkosten()
    End Sub

    Private Sub Checkkassa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Checkkassa.Click
        gesamtkosten()
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        RabattBoot()
    End Sub

    Private Sub MaskedTextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox4.LostFocus
        If Not SafeData.IsBlankOrMask(MaskedTextBox4.Text) Then
            Dim datum As Date
            If Not SafeData.TryParseMaskedDate(MaskedTextBox4.Text, datum) OrElse datum < Begruessung.anfang OrElse datum > Begruessung.ende Then
                MsgBox("Datum hat falsches Format")
                MaskedTextBox4.Text = vbNullString
                MaskedTextBox4.Focus()
            End If
        Else
            MsgBox("Törn Endedatum ist Pflichteingabe.")
            MaskedTextBox4.Text = vbNullString
            '          MaskedTextBox4.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.LostFocus
        Dim datum As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox1.Text, datum) OrElse datum < Begruessung.anfang OrElse datum > Begruessung.ende Then
            MsgBox("Datum hat falsches Format")
            MaskedTextBox1.Text = vbNullString
            MaskedTextBox1.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.LostFocus
        Dim datum As Date
        If Not SafeData.TryParseMaskedDate(MaskedTextBox2.Text, datum) OrElse datum < Begruessung.anfang OrElse datum > Begruessung.ende Then
            MsgBox("Datum hat falsches Format")
            MaskedTextBox2.Text = vbNullString
            MaskedTextBox2.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox3.LostFocus
        If Not SafeData.IsBlankOrMask(MaskedTextBox3.Text) Then
            Dim datum As Date
            If Not SafeData.TryParseMaskedDate(MaskedTextBox3.Text, datum) OrElse datum < Begruessung.anfang OrElse datum > Begruessung.ende Then
                MsgBox("Datum hat falsches Format")
                MaskedTextBox3.Text = vbNullString
                MaskedTextBox3.Focus()
            End If
        Else
            MsgBox("Törn Anfangdatum ist Pflichteingabe.")
            MaskedTextBox3.Text = vbNullString
            '           MaskedTextBox3.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        gesamtkosten()
    End Sub

    Private Sub comboFuellen1(ByVal text, ByVal feld)
        If IsDBNull(text) = False Then
            If text > " " Then
                Select Case feld
                    Case 1
                        TextBox20.Text = text
                    Case 2
                        TextBox22.Text = text
                    Case 3
                        TextBox24.Text = text
                    Case 4
                        TextBox21.Text = text
                    Case 5
                        TextBox23.Text = text
                    Case 6
                        TextBox25.Text = text
                    Case 7
                        TextBox64.Text = text
                End Select
                '               feld = text
            End If
        End If
    End Sub

    Private Sub Button4Bearbeiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4Bearbeiten.Click
        '                                                                Kosten bearbeiten
        Dim bbb As Single = 0
        Dim ccc As Single = 0
        GroupBox3.Location = New Point(14, 12)
        GroupBox15.Location = New Point(14, 12)
        GroupBox1.Visible = False
        GroupBox10.Visible = False
        GroupBox2.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        GroupBox11.Visible = False
        GroupBox12.Visible = False
        GroupBox13.Visible = False
        GroupBox3.Size = New Point(850, 600)
        Button3.Enabled = False
        Button4Bearbeiten.Enabled = False
        ButtonCrewSuchen.Enabled = False
        PictureBox6.Visible = True
        PictureBox6.Location = New Point(70, 400)
        LoeschenButton.Enabled = False
        FormularButton.Enabled = False
        SpeichernButton.Enabled = False
        bbb = SafeData.ParseMoneyText(TextBox26.Text) - Bordkassa
        Label75.Text = bbb.ToString("##,##.00") + " €"
        ccc = SafeData.ParseMoneyText(TextBox27.Text) + skipperant
        ccc += SafeData.ParseMoneyText(TextBox30.Text)
        ccc += SafeData.ParseMoneyText(TextBox32.Text)
        ccc += SafeData.ParseMoneyText(TextBox34.Text)
        ccc += SafeData.ParseMoneyText(TextBox36.Text)
        ccc += SafeData.ParseMoneyText(TextBox38.Text)
        ccc += SafeData.ParseMoneyText(TextBox40.Text)
        ccc += SafeData.ParseMoneyText(TextBox42.Text)
        ccc += SafeData.ParseMoneyText(TextBox44.Text)
        ccc += SafeData.ParseMoneyText(TextBox46.Text)
        Label77.Text = ccc.ToString("##,##.00") + " €"
        ccc -= bbb
        Label78.Text = ccc.ToString("##,##.00") + " €"
        CheckBox27.Text = CheckBox1.Text
        CheckBox28.Text = CheckBox2.Text
        CheckBox29.Text = CheckBox3.Text
        CheckBox30.Text = CheckBox4.Text
        CheckBox31.Text = CheckBox5.Text
        CheckBox32.Text = CheckBox6.Text
        CheckBox33.Text = CheckBox7.Text
        CheckBox34.Text = CheckBox8.Text
        CheckBox35.Text = CheckBox9.Text
        CheckBox36.Text = CheckBox10.Text
        CheckBox27.Checked = CheckBox1.Checked
        CheckBox28.Checked = CheckBox2.Checked
        CheckBox29.Checked = CheckBox3.Checked
        CheckBox30.Checked = CheckBox4.Checked
        CheckBox31.Checked = CheckBox5.Checked
        CheckBox32.Checked = CheckBox6.Checked
        CheckBox33.Checked = CheckBox7.Checked
        CheckBox34.Checked = CheckBox8.Checked
        CheckBox35.Checked = CheckBox9.Checked
        CheckBox36.Checked = CheckBox10.Checked
        RestzahlungRechnen(TextBox106.Text, TextBox27.Text, TextBox93.Text, TextBox28.Text, TextBox115.Text)
        RestzahlungRechnen(TextBox105.Text, TextBox30.Text, TextBox95.Text, TextBox29.Text, TextBox114.Text)
        RestzahlungRechnen(TextBox104.Text, TextBox32.Text, TextBox96.Text, TextBox31.Text, TextBox113.Text)
        RestzahlungRechnen(TextBox103.Text, TextBox34.Text, TextBox94.Text, TextBox33.Text, TextBox116.Text)
        RestzahlungRechnen(TextBox102.Text, TextBox36.Text, TextBox92.Text, TextBox35.Text, TextBox107.Text)
        RestzahlungRechnen(TextBox101.Text, TextBox38.Text, TextBox91.Text, TextBox37.Text, TextBox112.Text)
        RestzahlungRechnen(TextBox100.Text, TextBox40.Text, TextBox90.Text, TextBox39.Text, TextBox111.Text)
        RestzahlungRechnen(TextBox99.Text, TextBox42.Text, TextBox89.Text, TextBox41.Text, TextBox110.Text)
        RestzahlungRechnen(TextBox98.Text, TextBox44.Text, TextBox88.Text, TextBox43.Text, TextBox109.Text)
        RestzahlungRechnen(TextBox97.Text, TextBox46.Text, TextBox87.Text, TextBox45.Text, TextBox108.Text)
        datAnz(MaskedTextBox5.Text, CheckBox1.Text, TextBox2.Text)
        datAnz(MaskedTextBox10.Text, CheckBox2.Text, TextBox2.Text)
        datAnz(MaskedTextBox12.Text, CheckBox3.Text, TextBox2.Text)
        datAnz(MaskedTextBox14.Text, CheckBox4.Text, TextBox2.Text)
        datAnz(MaskedTextBox16.Text, CheckBox5.Text, TextBox2.Text)
        datAnz(MaskedTextBox18.Text, CheckBox6.Text, TextBox2.Text)
        datAnz(MaskedTextBox20.Text, CheckBox7.Text, TextBox2.Text)
        datAnz(MaskedTextBox22.Text, CheckBox8.Text, TextBox2.Text)
        datAnz(MaskedTextBox24.Text, CheckBox9.Text, TextBox2.Text)
        datAnz(MaskedTextBox26.Text, CheckBox10.Text, TextBox2.Text)

        datrest(MaskedTextBox8.Text, CheckBox1.Text, TextBox2.Text)
        datrest(MaskedTextBox9.Text, CheckBox2.Text, TextBox2.Text)
        datrest(MaskedTextBox11.Text, CheckBox3.Text, TextBox2.Text)
        datrest(MaskedTextBox13.Text, CheckBox4.Text, TextBox2.Text)
        datrest(MaskedTextBox15.Text, CheckBox5.Text, TextBox2.Text)
        datrest(MaskedTextBox17.Text, CheckBox6.Text, TextBox2.Text)
        datrest(MaskedTextBox19.Text, CheckBox7.Text, TextBox2.Text)
        datrest(MaskedTextBox21.Text, CheckBox8.Text, TextBox2.Text)
        datrest(MaskedTextBox23.Text, CheckBox9.Text, TextBox2.Text)
        datrest(MaskedTextBox25.Text, CheckBox10.Text, TextBox2.Text)
        checkenable()
    End Sub
    Private Sub datAnz(ByRef mask, ByVal meno, ByVal jazda)
        If IsDate(MaskedTextBox6.Text) Then
            If IsDate(mask) Then
            Else
                mask = MaskedTextBox6.Text
            End If
            BootkalkSpeichern(meno, jazda, mask)
        End If
    End Sub
    Private Sub datrest(ByRef mask, ByVal meno, ByVal jazda)
        If IsDate(MaskedTextBox7.Text) Then
            If IsDate(mask) Then
            Else
                mask = MaskedTextBox7.Text
            End If
            BootkalkRestSpeichern(meno, jazda, mask)
        End If
    End Sub
    Private Sub RestzahlungRechnen(ByRef t106, ByVal t27, ByRef t93, ByVal t28, ByRef t115)
        t106 = t27
        t93 = t28
        If t106 > 0 Then
            t115 = t106 - t93
        Else
            t115 = 0
        End If
    End Sub
    Private Sub checkenable()
        If CheckBox16.Checked Then
            TextBox106.Enabled = False
        Else
            TextBox106.Enabled = True
        End If

        If CheckBox17.Checked Then
            TextBox105.Enabled = False
        Else
            TextBox105.Enabled = True
        End If

        If CheckBox18.Checked Then
            TextBox104.Enabled = False
        Else
            TextBox104.Enabled = True
        End If

        If CheckBox19.Checked Then
            TextBox103.Enabled = False
        Else
            TextBox103.Enabled = True
        End If

        If CheckBox20.Checked Then
            TextBox102.Enabled = False
        Else
            TextBox102.Enabled = True
        End If

        If CheckBox21.Checked Then
            TextBox101.Enabled = False
        Else
            TextBox101.Enabled = True
        End If

        If CheckBox22.Checked Then
            TextBox100.Enabled = False
        Else
            TextBox100.Enabled = True
        End If

        If CheckBox23.Checked Then
            TextBox99.Enabled = False
        Else
            TextBox99.Enabled = True
        End If

        If CheckBox24.Checked Then
            TextBox98.Enabled = False
        Else
            TextBox98.Enabled = True
        End If

        If CheckBox24.Checked Then
            TextBox97.Enabled = False
        Else
            TextBox97.Enabled = True
        End If

    End Sub
    Private Sub BootkalkSpeichern(ByVal Meno, ByVal Jazda, ByVal Termin)

        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & Jazda & "' and vzname = '" & Meno & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox68.Text = Termin
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub BootkalkRestSpeichern(ByVal Meno, ByVal Jazda, ByVal Termin)

        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & Jazda & "' and vzname = '" & Meno & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            TextBox69.Text = Termin
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub

    Private Sub MaskedTextBox5_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox5.LostFocus
        BootkalkSpeichern(CheckBox1.Text, TextBox2.Text, MaskedTextBox5.Text)
    End Sub
    Private Sub MaskedTextBox8_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox8.LostFocus
        BootkalkRestSpeichern(CheckBox1.Text, TextBox2.Text, MaskedTextBox8.Text)
    End Sub
    Private Sub MaskedTextBox10_LostFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox10.LostFocus
        BootkalkSpeichern(CheckBox2.Text, TextBox2.Text, MaskedTextBox10.Text)
    End Sub
    Private Sub MaskedTextBox9_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox9.LostFocus
        BootkalkRestSpeichern(CheckBox2.Text, TextBox2.Text, MaskedTextBox9.Text)
    End Sub
    Private Sub MaskedTextBox12_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox12.LostFocus
        BootkalkSpeichern(CheckBox3.Text, TextBox2.Text, MaskedTextBox12.Text)
    End Sub
    Private Sub MaskedTextBox11_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox11.LostFocus
        BootkalkRestSpeichern(CheckBox3.Text, TextBox2.Text, MaskedTextBox11.Text)
    End Sub
    Private Sub MaskedTextBox14_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox14.LostFocus
        BootkalkSpeichern(CheckBox4.Text, TextBox2.Text, MaskedTextBox14.Text)
    End Sub
    Private Sub MaskedTextBox13_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox13.LostFocus
        BootkalkRestSpeichern(CheckBox4.Text, TextBox2.Text, MaskedTextBox13.Text)
    End Sub
    Private Sub MaskedTextBox16_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox16.LostFocus
        BootkalkSpeichern(CheckBox5.Text, TextBox2.Text, MaskedTextBox16.Text)
    End Sub
    Private Sub MaskedTextBox15_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox15.LostFocus
        BootkalkRestSpeichern(CheckBox5.Text, TextBox2.Text, MaskedTextBox15.Text)
    End Sub
    Private Sub MaskedTextBox18_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox18.LostFocus
        BootkalkSpeichern(CheckBox6.Text, TextBox2.Text, MaskedTextBox18.Text)
    End Sub
    Private Sub MaskedTextBox17_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox17.LostFocus
        BootkalkRestSpeichern(CheckBox6.Text, TextBox2.Text, MaskedTextBox17.Text)
    End Sub
    Private Sub MaskedTextBox20_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox20.LostFocus
        BootkalkSpeichern(CheckBox7.Text, TextBox2.Text, MaskedTextBox20.Text)
    End Sub
    Private Sub MaskedTextBox19_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox19.LostFocus
        BootkalkRestSpeichern(CheckBox7.Text, TextBox2.Text, MaskedTextBox19.Text)
    End Sub
    Private Sub MaskedTextBox22_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox22.LostFocus
        BootkalkSpeichern(CheckBox8.Text, TextBox2.Text, MaskedTextBox22.Text)
    End Sub
    Private Sub MaskedTextBox21_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox21.LostFocus
        BootkalkRestSpeichern(CheckBox8.Text, TextBox2.Text, MaskedTextBox21.Text)
    End Sub
    Private Sub MaskedTextBox24_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox24.LostFocus
        BootkalkSpeichern(CheckBox9.Text, TextBox2.Text, MaskedTextBox24.Text)
    End Sub
    Private Sub MaskedTextBox23_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox23.LostFocus
        BootkalkRestSpeichern(CheckBox9.Text, TextBox2.Text, MaskedTextBox23.Text)
    End Sub
    Private Sub MaskedTextBox26_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox26.LostFocus
        BootkalkSpeichern(CheckBox10.Text, TextBox2.Text, MaskedTextBox26.Text)
    End Sub
    Private Sub MaskedTextBox25_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox25.LostFocus
        BootkalkRestSpeichern(CheckBox10.Text, TextBox2.Text, MaskedTextBox25.Text)
    End Sub

    Private Sub CheckBox16_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox16.LostFocus
        aaa = CheckBox1.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox16.Checked
            TextBox74.Text = TextBox27.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox17_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox17.LostFocus
        aaa = CheckBox2.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox17.Checked
            TextBox74.Text = TextBox30.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox18_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox18.LostFocus
        aaa = CheckBox3.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox18.Checked
            TextBox74.Text = TextBox32.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox19_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox19.LostFocus
        aaa = CheckBox4.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox19.Checked
            TextBox74.Text = TextBox34.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox20_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox20.LostFocus
        aaa = CheckBox5.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox20.Checked
            TextBox74.Text = TextBox36.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox21_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox21.LostFocus
        aaa = CheckBox6.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox21.Checked
            TextBox74.Text = TextBox38.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox22_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox22.LostFocus
        aaa = CheckBox7.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox22.Checked
            TextBox74.Text = TextBox40.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox23_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox23.LostFocus
        aaa = CheckBox8.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox23.Checked
            TextBox74.Text = TextBox42.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox24_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox24.LostFocus
        aaa = CheckBox9.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox24.Checked
            TextBox74.Text = TextBox44.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub CheckBox25_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox25.LostFocus
        aaa = CheckBox10.Text
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsBootKalkulation.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern =  '" & TextBox2.Text & "' and vzname = '" & aaa & "' "
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        tAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count = 1 Then
            CheckBox26.Checked = CheckBox25.Checked
            TextBox74.Text = TextBox46.Text
            bsBootKalkulation.EndEdit()
            taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        End If
    End Sub
    Private Sub TextBox86_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox86.TextChanged
        Dim laen As Integer
        If TextBox86.Text > "" Then
            laen = Len(TextBox86.Text)
            iii = bsCrewAdressen.Count - 1
            For i = 0 To iii
                aaa = Mid(dsToernverwaltung.CrewAdressen.Rows(i)("vzname").ToString, 1, 1).ToUpper + Mid(dsToernverwaltung.CrewAdressen.Rows(i)("vzname").ToString, 2, laen - 1).ToUpper
                If TextBox86.Text.ToUpper = aaa Then
                    position = i
                    GoTo Gefunden
                End If
            Next
Gefunden:
            bsCrewAdressen.Position = position
        End If
    End Sub

    Private Sub PictureBox6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        GroupBox3.Location = New Point(705, 144)
        GroupBox15.Location = New Point(2010, 126)
        GroupBox1.Visible = True
        GroupBox10.Visible = True
        GroupBox2.Visible = True
        GroupBox11.Visible = True
        GroupBox12.Visible = True
        GroupBox13.Visible = True
        GroupBox3.Size = New Point(292, 484)
        Button3.Enabled = True
        Button4Bearbeiten.Enabled = True
        ButtonCrewSuchen.Enabled = True
        PictureBox6.Visible = False
        LoeschenButton.Enabled = True
        FormularButton.Enabled = True
        SpeichernButton.Enabled = True
        CheckBox1.Text = CheckBox27.Text
        CheckBox2.Text = CheckBox28.Text
        CheckBox3.Text = CheckBox29.Text
        CheckBox4.Text = CheckBox30.Text
        CheckBox5.Text = CheckBox31.Text
        CheckBox6.Text = CheckBox32.Text
        CheckBox7.Text = CheckBox33.Text
        CheckBox8.Text = CheckBox34.Text
        CheckBox9.Text = CheckBox35.Text
        CheckBox10.Text = CheckBox36.Text
        CheckBox1.Checked = CheckBox27.Checked
        CheckBox2.Checked = CheckBox28.Checked
        CheckBox3.Checked = CheckBox29.Checked
        CheckBox4.Checked = CheckBox30.Checked
        CheckBox5.Checked = CheckBox31.Checked
        CheckBox6.Checked = CheckBox32.Checked
        CheckBox7.Checked = CheckBox33.Checked
        CheckBox8.Checked = CheckBox34.Checked
        CheckBox9.Checked = CheckBox35.Checked
        CheckBox10.Checked = CheckBox36.Checked
        TextBox27.Text = TextBox106.Text
        TextBox30.Text = TextBox105.Text
        TextBox32.Text = TextBox104.Text
        TextBox34.Text = TextBox103.Text
        TextBox36.Text = TextBox102.Text
        TextBox38.Text = TextBox101.Text
        TextBox40.Text = TextBox100.Text
        TextBox42.Text = TextBox99.Text
        TextBox44.Text = TextBox98.Text
        TextBox46.Text = TextBox97.Text

        Gezahlt(TextBox28.Text, TextBox93.Text, TextBox123.Text)
        Gezahlt(TextBox29.Text, TextBox95.Text, TextBox125.Text)
        Gezahlt(TextBox31.Text, TextBox96.Text, TextBox126.Text)
        Gezahlt(TextBox33.Text, TextBox94.Text, TextBox124.Text)
        Gezahlt(TextBox35.Text, TextBox92.Text, TextBox122.Text)
        Gezahlt(TextBox37.Text, TextBox91.Text, TextBox121.Text)
        Gezahlt(TextBox39.Text, TextBox90.Text, TextBox120.Text)
        Gezahlt(TextBox41.Text, TextBox89.Text, TextBox119.Text)
        Gezahlt(TextBox43.Text, TextBox88.Text, TextBox118.Text)
        Gezahlt(TextBox45.Text, TextBox87.Text, TextBox117.Text)
        kabinenbucher = 0
        Kabine()
        gesamtkosten()

    End Sub
    Private Sub Gezahlt(ByRef neuersaldo, ByVal bezahlt, ByRef zahlung)
        anzahl = SafeData.ParseMoneyText(Convert.ToString(bezahlt))
        If zahlung > "0" Then
            anzahl += zahlung
        End If
        '       zahlung = 0
        neuersaldo = anzahl.ToString("##,#0.00") + " €"
    End Sub
    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox28.TextChanged
        If TextBox123.Text > "0" Then
            TextBox28_LostFocus(sender, e)
            TextBox123.Text = "0"
        End If
    End Sub
    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged
        If TextBox125.Text > "0" Then
            TextBox29_LostFocus(sender, e)
            TextBox125.Text = "0"
        End If

    End Sub
    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox31.TextChanged
        If TextBox126.Text > "0" Then
            TextBox31_LostFocus(sender, e)
            TextBox126.Text = "0"
        End If

    End Sub
    Private Sub TextBox33_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox33.TextChanged
        If TextBox124.Text > "0" Then
            TextBox33_LostFocus(sender, e)
            TextBox124.Text = "0"
        End If

    End Sub
    Private Sub TextBox35_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox35.TextChanged
        If TextBox122.Text > "0" Then
            TextBox35_LostFocus(sender, e)
            TextBox122.Text = "0"
        End If

    End Sub
    Private Sub TextBox37_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox37.TextChanged
        If TextBox121.Text > "0" Then
            TextBox37_LostFocus(sender, e)
            TextBox121.Text = "0"
        End If

    End Sub
    Private Sub TextBox39_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox39.TextChanged
        If TextBox120.Text > "0" Then
            TextBox39_LostFocus(sender, e)
            TextBox120.Text = "0"
        End If

    End Sub
    Private Sub TextBox41_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox41.TextChanged
        If TextBox119.Text > "0" Then
            TextBox41_LostFocus(sender, e)
            TextBox119.Text = "0"
        End If

    End Sub
    Private Sub TextBox43_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox43.TextChanged
        If TextBox118.Text > "0" Then
            TextBox43_LostFocus(sender, e)
            TextBox118.Text = "0"
        End If

    End Sub
    Private Sub TextBox45_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox45.TextChanged
        If TextBox117.Text > "0" Then
            TextBox45_LostFocus(sender, e)
            TextBox117.Text = "0"
        End If

    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label87.Text = "Suchen"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label87.Text = ""
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        aenderung = True
        SpeichernButton.Text = "Änderung speichern"
    End Sub

    Private Sub PictureBox7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseHover
        Label87.Text = "Ändern"
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        Label87.Text = ""
    End Sub

    Private Sub MaskedTextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox7.KeyDown
        If Len(MaskedTextBox7.Text) = "9" Then
            GroupBox13.Enabled = True
        End If

    End Sub

    Private Sub Label43_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label43.MouseHover
        gbInfo.Location = New Point(150, 390)
    End Sub

    Private Sub Label43_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label43.MouseLeave
        gbInfo.Location = New Point(1100, 800)
    End Sub
    Private Sub Label39_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label39.MouseHover
        gbInfo.Location = New Point(150, 390)
    End Sub

    Private Sub Label39_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label39.MouseLeave
        gbInfo.Location = New Point(1100, 800)
    End Sub
    Private Sub Label40_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label40.MouseHover
        gbInfo.Location = New Point(150, 390)
    End Sub

    Private Sub Label40_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label40.MouseLeave
        gbInfo.Location = New Point(1100, 800)
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        GroupBox4.Visible = True
        picture = 8
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        GroupBox4.Visible = True
        picture = 9
    End Sub

    Private Sub MaskedTextBox7_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox7.MaskInputRejected
        If IsDate(MaskedTextBox7.Text) Then
            datumrest = MaskedTextBox7.Text

        End If
    End Sub
    Private Sub MaskedTextBox6_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox6.MaskInputRejected
        If IsDate(MaskedTextBox6.Text) Then
            datumanzahlung = MaskedTextBox6.Text
        End If
    End Sub
    Private Sub Kabine0()
        If CheckBox47.Checked = True Then CheckBox1.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox2.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox3.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox4.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox5.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox6.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox7.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox8.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox9.ForeColor = Color.Blue
        If CheckBox47.Checked = True Then CheckBox10.ForeColor = Color.Blue
    End Sub
    Private Sub Kabine()
        If CheckBox37.Checked = True Then
            CheckBox1.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox1.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox38.Checked = True Then
            CheckBox2.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox2.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox39.Checked = True Then
            CheckBox3.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox3.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox40.Checked = True Then
            CheckBox4.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox4.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox41.Checked = True Then
            CheckBox5.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox5.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox42.Checked = True Then
            CheckBox6.ForeColor = Color.Blue
            kabinenbucher += 1
        Else
            CheckBox6.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox43.Checked = True Then
            CheckBox7.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox7.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox44.Checked = True Then
            CheckBox8.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox8.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox45.Checked = True Then
            CheckBox9.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox9.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
        If CheckBox46.Checked = True Then
            CheckBox10.ForeColor = Color.Blue
            CheckBox47.Checked = True
            kabinenbucher += 1
        Else
            CheckBox10.ForeColor = Color.Black
            CheckBox47.Checked = False
        End If
    End Sub
    Private Sub KabineEinlesen(ByVal lfn)
        Select Case lfn
            Case 1 And CheckBox47.Checked = True
                CheckBox37.Checked = True
                CheckBox27.ForeColor = Color.Blue
                CheckBox1.ForeColor = Color.Blue
                beitrag = beitrag + Charteranteil
                kabinenbucher += 1
            Case 2 And CheckBox47.Checked = True
                CheckBox38.Checked = True
                CheckBox28.ForeColor = Color.Blue
                CheckBox2.ForeColor = Color.Blue
                kabinenbucher += 1
                beitrag = beitrag + Charteranteil
            Case 3 And CheckBox47.Checked = True
                CheckBox39.Checked = True
                CheckBox29.ForeColor = Color.Blue
                CheckBox3.ForeColor = Color.Blue
                kabinenbucher += 1
            Case 4 And CheckBox47.Checked = True
                CheckBox40.Checked = True
                CheckBox30.ForeColor = Color.Blue
                CheckBox4.ForeColor = Color.Blue
                kabinenbucher += 1
                beitrag = beitrag + Charteranteil
            Case 5 And CheckBox47.Checked = True
                CheckBox41.Checked = True
                CheckBox31.ForeColor = Color.Blue
                CheckBox5.ForeColor = Color.Blue
                kabinenbucher += 1
                beitrag = beitrag + Charteranteil
            Case 6 And CheckBox47.Checked = True
                CheckBox42.Checked = True
                CheckBox32.ForeColor = Color.Blue
                CheckBox6.ForeColor = Color.Blue
                kabinenbucher += 1
                beitrag = beitrag + Charteranteil
            Case 7 And CheckBox47.Checked = True
                CheckBox43.Checked = True
                CheckBox33.ForeColor = Color.Blue
                CheckBox7.ForeColor = Color.Blue
                kabinenbucher += 1
                beitrag = beitrag + Charteranteil
            Case 8 And CheckBox47.Checked = True
                CheckBox44.Checked = True
                CheckBox34.ForeColor = Color.Blue
                CheckBox8.ForeColor = Color.Blue
                kabinenbucher += 1
                beitrag = beitrag + Charteranteil
            Case 9 And CheckBox47.Checked = True
                CheckBox45.Checked = True
                CheckBox35.ForeColor = Color.Blue
                CheckBox9.ForeColor = Color.Blue
                kabinenbucher += 1
                beitrag = beitrag + Charteranteil
            Case 10 And CheckBox47.Checked = True
                CheckBox46.Checked = True
                CheckBox36.ForeColor = Color.Blue
                CheckBox10.ForeColor = Color.Blue
                beitrag = beitrag + Charteranteil
                '          Case 11 And CheckBox47.Checked = True
                '             CheckBox37.ForeColor = Color.Blue
                '            CheckBox11.ForeColor = Color.Blue
                '       Case 12 And CheckBox47.Checked = True
                '          CheckBox37.ForeColor = Color.Blue
                '         CheckBox12.ForeColor = Color.Blue
        End Select
    End Sub
    Private Sub Kabinespeichern(lfn)
        Select Case lfn
            Case 1
                If CheckBox37.Checked = True Then
                    CheckBox47.Checked = True
                    beitrag = beitrag + Charteranteil
                Else
                    CheckBox47.Checked = False
                End If
            Case 2
                If CheckBox38.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 3
                If CheckBox39.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 4
                If CheckBox40.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 5
                If CheckBox41.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 6
                If CheckBox42.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 7
                If CheckBox43.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 8
                If CheckBox44.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 9
                If CheckBox45.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
            Case 10
                If CheckBox46.Checked = True Then
                    CheckBox47.Checked = True
                Else
                    CheckBox47.Checked = False
                End If
        End Select
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        CrewlisteAnzeigen()
    End Sub
End Class