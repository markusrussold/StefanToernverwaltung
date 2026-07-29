Imports System.Runtime.InteropServices
Public Class Bordkassa
    Dim buch1 As String
    Dim aaa As String
    Dim iii As Integer
    Dim position As Integer
    Dim ij As Integer
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Dim iip As Integer
    Dim kassaeingang As Single
    Dim pi As Integer
    Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim TAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim BAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim LAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim KAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Public Bootsname As String
    Public Termin As String
    Dim toernkassa As String
    Dim mValue(11) As Integer
    Dim tvalue(11) As String
    Dim zw As String
    Dim waehrung As String
    Dim crewanzahl As Single                  ' ohne Skipper

    Private Sub Bordkassa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taToernKalkulation.Fill(Me.dsToernverwaltung.ToernKalkulation)
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taBordkassa.Fill(Me.dsToernverwaltung.Bordkassa)
        '
        'Wechselkurs: Törnname, VZName = Text - Wechselkurs, Betrag = Eurowert für 1 Fremdwährung, Verwendung = Name der Fremdwährung
        '
          fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        toernkassa = GetSetting("Toern", "Kassa", "Toern", " ")


        Dim list As System.Data.DataRowView = bsListdaten.Current
        LAdapter.SelectCommand = New OleDb.OleDbCommand
        LAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        LAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'Bordkassa' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        LAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        ComboBox2.Items.Add("Kassa")
        If bsListdaten.Count = 1 Then
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            comboFuellen3(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        MaskedTextBox1.Mask = "00.00.0000"
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.AddNew()
        formularloeschen()
        TextBox1.Focus()
        Drucken.Enabled = False
        ButtonGraphik.Enabled = False
        If toernkassa > " " Then
            TextBox1.Text = toernkassa
            '           suchen()
            MaskedTextBox1.Focus()
        End If
     End Sub
    Private Sub formularloeschen()
        TextBox1.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox2.Text = ""
        MaskedTextBox1.Text = ""
        RichTextBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        '       GroupBox1.Enabled = False
        Label38.Visible = False
        Label37.Visible = False
        ComboBox1.Items.Clear()
        GroupBox2.Text = "Törn auswählen mit Doppelklick"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        '       TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If IsNumeric(TextBox1.Text) And Len(TextBox1.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
            Else
                If Len(TextBox1.Text) > 1 Then
                    If Mid(TextBox1.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where Mid(toernbezeichnung,1,1) like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        End If
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 0
                MsgBox("Kein Törn mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                TextBox1.Text = TextBox22.Text
                TextBox16.Text = TextBox1.Text      'Törnname
                Bootsname = dsToernverwaltung.Toernname.Rows(0)("bootsname").ToString
                Termin = dsToernverwaltung.Toernname.Rows(0)("datumvon").ToString.Substring(0, 10) + " bis " + dsToernverwaltung.Toernname.Rows(0)("datumbis").ToString.Substring(0, 10)
                '           CrewlisteAnzeigen()
                MaskedTextBox1.Text = Today
                Dim rB As System.Data.DataRowView = bsBordkassa.Current
                BAdapter.SelectCommand = New OleDb.OleDbCommand
                BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' "
                bsBordkassa.CancelEdit()
                dsToernverwaltung.Bordkassa.Clear()
                BAdapter.Fill(dsToernverwaltung.Bordkassa)
                Dim rk As System.Data.DataRowView = bsToernKalkulation.Current
                KAdapter.SelectCommand = New OleDb.OleDbCommand
                KAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                KAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern = '" & TextBox1.Text & "' "
                bsToernKalkulation.CancelEdit()
                dsToernverwaltung.ToernKalkulation.Clear()
                KAdapter.Fill(dsToernverwaltung.ToernKalkulation)
                If bsBordkassa.Count > 0 Then
                    Drucken.Enabled = True
                    ButtonGraphik.Enabled = True
                Else
                    Drucken.Enabled = False
                    ButtonGraphik.Enabled = False
                End If
                GroupBox1.Enabled = True
                Fremdwaehrung()
                CrewlisteAnzeigen()
                SkipperKassa()                  ' Skipper beteiligt sich an der Bordkassa?
                If CheckBox1.Checked = False Then
                    Label37.Visible = True
                    Label37.Text = "Skipper geht frei"
                End If

            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(13, 326)
                Label45.Text = ""
                Label46.Text = ""
        End Select
    End Sub
    Private Sub SkipperKassa()
          If bsToernKalkulation.Count = 1 Then
            CheckBox1.Checked = dsToernverwaltung.ToernKalkulation.Rows(0)("skipperbordkassa")
        Else
            CheckBox1.Checked = False
        End If
        If dsToernverwaltung.ToernKalkulation.Rows(0)("crewanzahl") + 1 <> crewanzahl Then
            CheckBox2.Checked = True                                                        ' Co Skipper zahl Bordkassa
        Else
            CheckBox2.Checked = False                                                       ' Co Skipper zahlt nicht
            ComboBox1.Items.Remove(dsToernverwaltung.ToernKalkulation.Rows(0)("coSkipper").ToString)
            Label38.Visible = True
            Label38.Text = "Co-Skipper geht frei"
        End If
    End Sub
    Private Sub positionieren()
        iii = bsToernname.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.Toernname.Rows(i)("toernbezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub CrewlisteAnzeigen()
        Dim rt As System.Data.DataRowView = bsTC.Current
        TAdapter.SelectCommand = New OleDb.OleDbCommand
        TAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' order by vzname"
        '     TAdapter.SelectCommand.CommandText = "Select * from TC where idtoern = '" & TextBox11.Text & "' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        TAdapter.Fill(dsToernverwaltung.TC)
        '       aaa = TextBox11.Text
        ComboBox1.Items.Add("Kassa")
        ij = bsTC.Count - 1
        crewanzahl = bsTC.Count
        For i = 0 To ij
            ComboBox1.Items.Add(dsToernverwaltung.TC.Rows(i)("vzname").ToString)
        Next
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
        Else
            ComboBox1.Items.Clear()
            CrewlisteAnzeigen()
        End If

    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged        ' Skipper zahlt Bordkassa oder nicht
        If CheckBox1.Checked Then
            ComboBox1.Items.Add(dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString)
        Else
            ComboBox1.Items.Clear()
            CrewlisteAnzeigen()
        End If
    End Sub
    Private Sub comboFuellen3(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox2.Items.Add(text)
            End If
        End If

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        DataGridView1.Location = New Point(746, 463)
        suchen()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
            '         DataGridView1.Location = New Point(746, 463)
        End If
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        GroupBox4.Location = New Point(270, 20)
    End Sub
    Private Sub DatumSp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatumSp.Click
        datumspeichern()
    End Sub
    Private Sub datumspeichern()
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        MaskedTextBox1.Focus()
        GroupBox4.Location = New Point(880, 300)
    End Sub
    Private Sub DatumZu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatumZu.Click
        GroupBox4.Location = New Point(880, 300)
    End Sub
    Private Sub Fremdwaehrung()
        aaa = "Wechselkurs"
        Dim r As System.Data.DataRowView = bsBordkassa.Current
        BAdapter.SelectCommand = New OleDb.OleDbCommand
        BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and vzname like '%" & aaa & "%' order by Verwendung"
        bsBordkassa.CancelEdit()
        dsToernverwaltung.Bordkassa.Clear()
        BAdapter.Fill(dsToernverwaltung.Bordkassa)
        Select Case bsBordkassa.Count
            Case 0
                RadioButton1.Checked = True
                TextBox2.Visible = False
                ComboBox3.Visible = False
                Label21.Visible = False
                Label35.Visible = False
            Case Else
                RadioButton2.Checked = True
                TextBox2.Visible = True
                ComboBox3.Visible = True
                Label21.Visible = True
                Label35.Visible = True
                ij = bsBordkassa.Count - 1
                ComboBox3.Items.Clear()
                For i = 0 To ij
                    ComboBox3.Items.Add((dsToernverwaltung.Bordkassa.Rows(i)("Betrag").ToString) + " " + (dsToernverwaltung.Bordkassa.Rows(i)("Verwendung").ToString))
                    Select Case i
                        Case 0
                            TextBox10.Text = dsToernverwaltung.Bordkassa.Rows(i)("Betrag").ToString
                            TextBox3.Text = dsToernverwaltung.Bordkassa.Rows(i)("Verwendung").ToString
                        Case 1
                            TextBox12.Text = dsToernverwaltung.Bordkassa.Rows(i)("Betrag").ToString
                            TextBox4.Text = dsToernverwaltung.Bordkassa.Rows(i)("Verwendung").ToString
                        Case 2
                            TextBox13.Text = dsToernverwaltung.Bordkassa.Rows(i)("Betrag").ToString
                            TextBox5.Text = dsToernverwaltung.Bordkassa.Rows(i)("Verwendung").ToString
                        Case 3
                            TextBox14.Text = dsToernverwaltung.Bordkassa.Rows(i)("Betrag").ToString
                            TextBox7.Text = dsToernverwaltung.Bordkassa.Rows(i)("Verwendung").ToString
                        Case 4
                            TextBox15.Text = dsToernverwaltung.Bordkassa.Rows(i)("Betrag").ToString
                            TextBox9.Text = dsToernverwaltung.Bordkassa.Rows(i)("Verwendung").ToString
                    End Select
                Next
        End Select
        bsBordkassa.AddNew()
    End Sub
    Private Sub RadioButton2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton2.MouseClick
        If RadioButton2.Checked Then
            GroupBox3.Location = New Point(12, 12)
        Else
            GroupBox3.Location = New Point(750, 25)
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        GroupBox3.Location = New Point(750, 25)
    End Sub
    Private Sub RadioButton1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton1.MouseClick
        If RadioButton1.Checked Then
            GroupBox3.Location = New Point(750, 25)
        Else
            GroupBox3.Location = New Point(12, 12)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '                  Speichern Währung
        '
        'Wechselkurs: Törnname, VZName = Text - Wechselkurs, Betrag = Eurowert für 1 Fremdwährung, Verwendung = Name der Fremdwährung
        '
        TextBox10.Text = Replace(TextBox10.Text, ".", ",")
        TextBox12.Text = Replace(TextBox12.Text, ".", ",")
        TextBox13.Text = Replace(TextBox13.Text, ".", ",")
        TextBox14.Text = Replace(TextBox14.Text, ".", ",")
        TextBox15.Text = Replace(TextBox15.Text, ".", ",")

        Dim iip As Integer
        Dim pi As Integer
        aaa = "Wechselkurs"
        Dim r As System.Data.DataRowView = bsBordkassa.Current
        BAdapter.SelectCommand = New OleDb.OleDbCommand
        BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and vzname like '%" & aaa & "%' order by Verwendung"
        bsBordkassa.CancelEdit()
        dsToernverwaltung.Bordkassa.Clear()
        BAdapter.Fill(dsToernverwaltung.Bordkassa)
        If bsBordkassa.Count > 0 Then
            iip = bsBordkassa.Count - 1
            For pi = 0 To iip
                bsBordkassa.RemoveCurrent()
                taBordkassa.Update(dsToernverwaltung)
            Next
        End If

        bsBordkassa.AddNew()

        If TextBox3.Text > "" Then
            '           bsBordkassa.AddNew()
            TextBox16.Text = TextBox1.Text
            TextBox17.Text = "Wechselkurs"
            TextBox18.Text = TextBox10.Text                 ' Betrag
            TextBox19.Text = TextBox3.Text                  ' Name der Fremdwährung
            TextBox20.Text = ""
            RichTextBox1.Text = ""
            TextBox21.Text = MaskedTextBox1.Text
            '        bsBordkassa.EndEdit()
            bsBordkassa.AddNew()
            taBordkassa.Update(dsToernverwaltung.Bordkassa)
        End If
        If TextBox4.Text > "" Then
            '           bsBordkassa.AddNew()
            TextBox16.Text = TextBox1.Text
            TextBox17.Text = "Wechselkurs"
            TextBox18.Text = TextBox12.Text                 ' Betrag
            TextBox19.Text = TextBox4.Text                  ' Name der Fremdwährung
            TextBox20.Text = ""
            RichTextBox1.Text = ""
            TextBox21.Text = MaskedTextBox1.Text
            '        bsBordkassa.EndEdit()
            bsBordkassa.AddNew()
            taBordkassa.Update(dsToernverwaltung.Bordkassa)
        End If
        If TextBox5.Text > "" Then
            '           bsBordkassa.AddNew()
            TextBox16.Text = TextBox1.Text
            TextBox17.Text = "Wechselkurs"
            TextBox18.Text = TextBox13.Text                 ' Betrag
            TextBox19.Text = TextBox5.Text                  ' Name der Fremdwährung
            TextBox20.Text = ""
            RichTextBox1.Text = ""
            TextBox21.Text = MaskedTextBox1.Text
            '        bsBordkassa.EndEdit()
            bsBordkassa.AddNew()
            taBordkassa.Update(dsToernverwaltung.Bordkassa)
        End If
        If TextBox7.Text > "" Then
            '            bsBordkassa.AddNew()
            TextBox16.Text = TextBox1.Text
            TextBox17.Text = "Wechselkurs"
            TextBox18.Text = TextBox14.Text                 ' Betrag
            TextBox19.Text = TextBox7.Text                  ' Name der Fremdwährung
            TextBox20.Text = ""
            RichTextBox1.Text = ""
            TextBox21.Text = MaskedTextBox1.Text
            '        bsBordkassa.EndEdit()
            bsBordkassa.AddNew()
            taBordkassa.Update(dsToernverwaltung.Bordkassa)
        End If
        If TextBox9.Text > "" Then
            '            bsBordkassa.AddNew()
            TextBox16.Text = TextBox1.Text
            TextBox17.Text = "Wechselkurs"
            TextBox18.Text = TextBox15.Text                 ' Betrag
            TextBox19.Text = TextBox9.Text                  ' Name der Fremdwährung
            TextBox20.Text = ""
            RichTextBox1.Text = ""
            TextBox21.Text = MaskedTextBox1.Text
            '        bsBordkassa.EndEdit()
            bsBordkassa.AddNew()
            taBordkassa.Update(dsToernverwaltung.Bordkassa)
        End If
        Fremdwaehrung()
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        Dim index As Single
        TextBox2.Text = Replace(TextBox2.Text, ".", ",")
        index = InStr(ComboBox3.Text, " ")
        aaa = ComboBox3.Text.Substring(0, index - 1)
        TextBox6.Text = aaa * TextBox2.Text
        aaa = Len(ComboBox3.Text) - index
        waehrung = ComboBox3.Text.Substring(index, aaa)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpeichern.Click
        '                                     Speichern Belege
        If ComboBox1.SelectedItem = ComboBox2.SelectedItem Then
            MsgBox(" Zahler und Kategorie dürfen nicht identisch oder leer sein. Speichern ncht möglich!")
            GoTo ende
        End If
        Dim r As System.Data.DataRowView = bsBordkassa.Current
        BAdapter.SelectCommand = New OleDb.OleDbCommand
        BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' "
        bsBordkassa.CancelEdit()
        dsToernverwaltung.Bordkassa.Clear()
        BAdapter.Fill(dsToernverwaltung.Bordkassa)
        bsBordkassa.AddNew()
        If TextBox1.Text > "/" Then
            If ComboBox1.Text > "/" Then
                If MaskedTextBox1.Text > " " Then
                    If IsNumeric(TextBox6.Text) Then
                        If TextBox6.Text <> 0 Then
                            If TextBox8.Text > "/" Then
                                If ComboBox2.Text > "/" Then
                                    TextBox16.Text = TextBox1.Text                  ' Törn
                                    TextBox17.Text = ComboBox1.Text                 ' Crew Name
                                    TextBox18.Text = TextBox6.Text                 ' Betrag
                                    TextBox19.Text = TextBox8.Text                  ' Name der Fremdwährung
                                    TextBox20.Text = ComboBox2.Text                 ' Kategorie
                                    TextBox21.Text = MaskedTextBox1.Text            '  Datum
                                    TextBox35.Text = waehrung                       ' Währung
                                    TextBox36.Text = TextBox2.Text                    ' Betrag in org. Währung
                                    bsBordkassa.AddNew()
                                    taBordkassa.Update(dsToernverwaltung.Bordkassa)
                                    SaveSetting("Toern", "Kassa", "Toern", TextBox1.Text)
                                    bokatoe()
                                    UnterFuLoesch()
                                Else
                                    MsgBox("Kategorie fehlt")
                                End If
                            Else
                                MsgBox("Belegtext fehlt")
                            End If
                        Else
                            MsgBox("Betrag fehlt")
                        End If
                    Else
                        MsgBox("Betrag ist nicht nummerisch")
                    End If
                Else
                    MsgBox("Datum fehlt")
                End If
            Else
                MsgBox("Zahler: Crewmitglied oder Kassa nicht ausgewählt")
            End If
        Else
            MsgBox("Törn auswählen")
        End If
ende:
    End Sub
    Private Sub UnterFuLoesch()
        TextBox6.Text = ""
        '      TextBox8.Text = ""
        TextBox2.Text = ""
        '      ComboBox2.Text = ""
        '       ComboBox3.Text = ""
    End Sub
    Private Sub bokatoe()
        If ComboBox2.Text = "Kassa" Then
            Dim zwsumme As Single
            zwsumme = Val(dsToernverwaltung.Toernname.Rows(0)("Bordkassa").ToString)
            zwsumme += TextBox6.Text
            dsToernverwaltung.Toernname.Rows(0)("Bordkassa") = zwsumme
            taToernname.Update(dsToernverwaltung.Toernname)
        End If
    End Sub
    Private Sub einzelumsatz(ByVal name, ByRef einkauf, ByRef kassaein)
        aaa = name
        Dim r As System.Data.DataRowView = bsBordkassa.Current
        Dim summe1 As Single = 0
        Dim summe2 As Single = 0
        BAdapter.SelectCommand = New OleDb.OleDbCommand
        BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and vzname like '%" & aaa & "%' order by Verwendung"
        bsBordkassa.CancelEdit()
        dsToernverwaltung.Bordkassa.Clear()
        BAdapter.Fill(dsToernverwaltung.Bordkassa)
        If bsBordkassa.Count > 0 Then
            iip = bsBordkassa.Count - 1
            For Me.pi = 0 To iip
                If dsToernverwaltung.Bordkassa.Rows(Me.pi)("Kategorie").ToString = "Kassa" Then
                    summe1 += dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
                Else
                    summe2 += dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
                End If
            Next
        End If
        kassaein = summe1
        einkauf = summe2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        formularloeschen()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drucken.Click
        Me.Cursor = Cursors.WaitCursor
        BuchungCheck()
        druck()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BuchungCheck()
        Dim sumaus As Single = 0
        Dim einnahmen As Single = 0
        Dim wechselkurs As String = "Wechselkurs"
        Dim ausgaben As Single = 0
        Dim saldo As Single
        Dim kauf As Single = 0
        Dim kassa As Single = 0
        Dim csaldo As Single = 0
        Dim vSaldo As Single = 0
        Dim kat As String = " "
        Dim T_index As Integer = 0
        Dim r As System.Data.DataRowView = bsBordkassa.Current
        BAdapter.SelectCommand = New OleDb.OleDbCommand
        BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and vzname <> '" & wechselkurs & "' order by Kategorie"
        bsBordkassa.CancelEdit()
        dsToernverwaltung.Bordkassa.Clear()
        BAdapter.Fill(dsToernverwaltung.Bordkassa)
        If bsBordkassa.Count > 0 Then
            iip = bsBordkassa.Count - 1
            For Me.pi = 0 To iip
                If dsToernverwaltung.Bordkassa.Rows(Me.pi)("Kategorie").ToString = "Kassa" Then  ' Kassa Einzahlung
                    einnahmen += dsToernverwaltung.Bordkassa.Rows(pi)("Betrag").ToString
                End If
                If dsToernverwaltung.Bordkassa.Rows(Me.pi)("VZName").ToString = "Kassa" Then     ' Aus Kassa bezahlt
                    ausgaben += dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
                End If
                If dsToernverwaltung.Bordkassa.Rows(Me.pi)("Kategorie").ToString <> "Kassa" Then
                    sumaus += dsToernverwaltung.Bordkassa.Rows(pi)("Betrag").ToString
                    bsTemp.AddNew()
                    Felderloeschen(T_index)
                    dsToernverwaltung.Temp.Rows(T_index)("Feld0") = "3"                            ' Einzelbuchungen
                    dsToernverwaltung.Temp.Rows(T_index)("Feld1") = dsToernverwaltung.Bordkassa.Rows(pi)("VZname").ToString
                    dsToernverwaltung.Temp.Rows(T_index)("Feld2") = dsToernverwaltung.Bordkassa.Rows(pi)("Betrag").ToString
                    dsToernverwaltung.Temp.Rows(T_index)("Feld3") = dsToernverwaltung.Bordkassa.Rows(pi)("Kategorie").ToString
                    dsToernverwaltung.Temp.Rows(T_index)("Feld22") = dsToernverwaltung.Bordkassa.Rows(pi)("Datum").ToString.Substring(0, 10)
                    dsToernverwaltung.Temp.Rows(T_index)("Feld5") = dsToernverwaltung.Bordkassa.Rows(pi)("Verwendung").ToString
                    dsToernverwaltung.Temp.Rows(T_index)("Feld23") = dsToernverwaltung.Bordkassa.Rows(pi)("Bemerkung").ToString
                    taTemp.Update(dsToernverwaltung)
                    T_index += 1
                End If

                If dsToernverwaltung.Bordkassa.Rows(Me.pi)("Kategorie").ToString <> "Kassa" Then
                    If dsToernverwaltung.Bordkassa.Rows(pi)("Waehrung").ToString > "" Then
                        bsTemp.AddNew()
                        Felderloeschen(T_index)
                        dsToernverwaltung.Temp.Rows(T_index)("Feld0") = "5"                            ' Einzelbuchungen währung
                        dsToernverwaltung.Temp.Rows(T_index)("Feld1") = dsToernverwaltung.Bordkassa.Rows(pi)("Waehrung").ToString
                        dsToernverwaltung.Temp.Rows(T_index)("Feld2") = dsToernverwaltung.Bordkassa.Rows(pi)("Betrag").ToString
                        dsToernverwaltung.Temp.Rows(T_index)("Feld3") = dsToernverwaltung.Bordkassa.Rows(pi)("W-Betrag").ToString
                        dsToernverwaltung.Temp.Rows(T_index)("Feld22") = dsToernverwaltung.Bordkassa.Rows(pi)("Datum").ToString.Substring(0, 10)
                        dsToernverwaltung.Temp.Rows(T_index)("Feld5") = dsToernverwaltung.Bordkassa.Rows(pi)("Verwendung").ToString
                        taTemp.Update(dsToernverwaltung)
                        T_index += 1
                    End If
                End If

                If kat > " " And kat <> dsToernverwaltung.Bordkassa.Rows(pi)("Kategorie").ToString Then
                    bsTemp.AddNew()
                    dsToernverwaltung.Temp.Rows(T_index)("Feld0") = "4"                     ' Kategorie Buchungen
                    dsToernverwaltung.Temp.Rows(T_index)("Feld1") = kat
                    dsToernverwaltung.Temp.Rows(T_index)("Feld2") = vSaldo
                    dsToernverwaltung.Temp.Rows(T_index)("Feld22") = dsToernverwaltung.Bordkassa.Rows(pi)("Datum").ToString.Substring(0, 10)
                    taTemp.Update(dsToernverwaltung)
                    T_index += 1
                    aaa = dsToernverwaltung.Bordkassa.Rows(pi)("Betrag").ToString
                    vSaldo = aaa
                Else
                    aaa = dsToernverwaltung.Bordkassa.Rows(pi)("Betrag").ToString
                    vSaldo += aaa
                End If
                kat = dsToernverwaltung.Bordkassa.Rows(pi)("Kategorie").ToString
            Next
            bsTemp.AddNew()
            dsToernverwaltung.Temp.Rows(T_index)("Feld0") = "4"                     ' Kategorie Buchungen
            dsToernverwaltung.Temp.Rows(T_index)("Feld1") = kat
            dsToernverwaltung.Temp.Rows(T_index)("Feld2") = vSaldo
            dsToernverwaltung.Temp.Rows(T_index)("Feld22") = Today.ToString.Substring(0, 10)
            taTemp.Update(dsToernverwaltung)
            T_index += 1
        End If
        saldo = einnahmen - ausgaben

        For pii = 1 To ComboBox1.Items.Count - 1                                       ' Ausgabe pro Crewmitglied
            '           ausgaben = 0
            einzelumsatz(ComboBox1.Items.Item(pii), kauf, kassa)
            bsTemp.AddNew()
            dsToernverwaltung.Temp.Rows(T_index)("Feld0") = "1"                        ' Ausgabe pro Crewmitglied
            dsToernverwaltung.Temp.Rows(T_index)("Feld1") = "Kassa"
            dsToernverwaltung.Temp.Rows(T_index)("Feld2") = einnahmen
            dsToernverwaltung.Temp.Rows(T_index)("Feld3") = ausgaben
            dsToernverwaltung.Temp.Rows(T_index)("Feld4") = ComboBox1.Items.Item(pii)
            dsToernverwaltung.Temp.Rows(T_index)("Feld5") = kauf
            dsToernverwaltung.Temp.Rows(T_index)("Feld6") = kassa
            dsToernverwaltung.Temp.Rows(T_index)("Feld22") = Today.ToString.Substring(0, 10)
            taTemp.Update(dsToernverwaltung)
            T_index += 1
        Next

        For pii = 1 To ComboBox1.Items.Count - 1                                       ' Ausgabe pro Crewmitglied
            '           ausgaben = 0
            einzelumsatz(ComboBox1.Items.Item(pii), kauf, kassa)
            bsTemp.AddNew()
            dsToernverwaltung.Temp.Rows(T_index)("Feld0") = "2"                        ' Ausgabe pro Crewmitglied
            dsToernverwaltung.Temp.Rows(T_index)("Feld1") = "Kassa"
            dsToernverwaltung.Temp.Rows(T_index)("Feld2") = einnahmen
            dsToernverwaltung.Temp.Rows(T_index)("Feld3") = ausgaben
            dsToernverwaltung.Temp.Rows(T_index)("Feld4") = ComboBox1.Items.Item(pii)
            dsToernverwaltung.Temp.Rows(T_index)("Feld5") = kauf
            dsToernverwaltung.Temp.Rows(T_index)("Feld6") = kassa
            dsToernverwaltung.Temp.Rows(T_index)("Feld22") = Today.ToString.Substring(0, 10)
            taTemp.Update(dsToernverwaltung)
            T_index += 1
        Next
        bsTemp.AddNew()
        dsToernverwaltung.Temp.Rows(T_index)("Feld0") = "0"                        ' Summe Ausgaben
        dsToernverwaltung.Temp.Rows(T_index)("Feld2") = sumaus
        taTemp.Update(dsToernverwaltung)
    End Sub
    Private Sub Felderloeschen(ByVal t_index)
        dsToernverwaltung.Temp.Rows(t_index)("Feld1") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld2") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld3") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld4") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld5") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld6") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld7") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld8") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld9") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld10") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld11") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld12") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld13") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld14") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld15") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld16") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld17") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld18") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld19") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld20") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld21") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld22") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld23") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld24") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld25") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld26") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld27") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld28") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld29") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld30") = " "
        dsToernverwaltung.Temp.Rows(t_index)("Feld31") = " "
    End Sub
    Private Sub druck()
        Dim Xs As New PrintoutBK
        Dim dv As DataView
        Dim t As DataTable
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsTemp.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from temp order by feld0,year(feld22),month(feld22),day(feld22)"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld0", "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7", "Feld8", "Feld9", "Feld10", "Feld11", "Feld12", "Feld13", "Feld14", "Feld15", "Feld16", "Feld17", "Feld18", "Feld19", "Feld20", "Feld21", "Feld22", "Feld23", "Feld24", "Feld25", "Feld26", "Feld27", "Feld28", "Feld29", "Feld30", "Feld31")
        Xs.PrintBordkassa(t)
        Me.Cursor = Cursors.Default
        Me.Close()

    End Sub

    Private Sub Zurueck2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zurueck2.Click
        Auswertungen.Location = New Point(750, 12)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If RadioButton3.Checked Then
            betragName(Label3.Text)
        Else
            betragKategorie(Label3.Text)
        End If
    End Sub
    Private Sub betragName(ByVal nm)
        dgvBordkassa.Visible = True
        If nm = "Kassa" Then
            betragkassa(nm)
        Else
            Dim r As System.Data.DataRowView = bsBordkassa.Current
            BAdapter.SelectCommand = New OleDb.OleDbCommand
            BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and vzname = '" & nm & "' "
            bsBordkassa.CancelEdit()
            dsToernverwaltung.Bordkassa.Clear()
            BAdapter.Fill(dsToernverwaltung.Bordkassa)
        End If
    End Sub
    Private Sub betragKategorie(ByVal kat)
        dgvBordkassa.Visible = True
        If kat = "Kassa" Then
            betragkassa(kat)
        Else
            Dim r As System.Data.DataRowView = bsBordkassa.Current
            BAdapter.SelectCommand = New OleDb.OleDbCommand
            BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and kategorie = '" & kat & "'  "
            bsBordkassa.CancelEdit()
            dsToernverwaltung.Bordkassa.Clear()
            BAdapter.Fill(dsToernverwaltung.Bordkassa)
        End If
    End Sub
    Private Sub betragkassa(ByVal kat)
        Dim r As System.Data.DataRowView = bsBordkassa.Current
        BAdapter.SelectCommand = New OleDb.OleDbCommand
        BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and (kategorie = '" & kat & "' or vzname = '" & kat & "') "
        bsBordkassa.CancelEdit()
        dsToernverwaltung.Bordkassa.Clear()
        BAdapter.Fill(dsToernverwaltung.Bordkassa)
    End Sub
    Private Sub labelloeschen()
        Label3.Text = ""
        Label4.Text = ""
        Label8.Text = ""
        Label10.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox28.Text = ""
        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = ""
        TextBox32.Text = ""
        TextBox33.Text = ""
        TextBox34.Text = ""
        TextBox23.Visible = False
        TextBox24.Visible = False
        TextBox25.Visible = False
        TextBox26.Visible = False
        TextBox27.Visible = False
        TextBox28.Visible = False
        TextBox29.Visible = False
        TextBox30.Visible = False
        TextBox31.Visible = False
        TextBox32.Visible = False
        TextBox33.Visible = False
        TextBox34.Visible = False
    End Sub
    Private Sub labelversorgen(ByVal sum, ByVal crew, ByVal aa)
        Dim summe As String
        summe = Format(sum, "##,##0.00 €")
        If aa = "Wechselkurs" Then Exit Sub
        Select Case crew
            Case 1
                Label3.Text = aa
                TextBox23.Text = summe
                TextBox23.Visible = True
            Case 2
                Label4.Text = aa
                TextBox24.Text = summe
                TextBox24.Visible = True
            Case 3
                Label8.Text = aa
                TextBox25.Visible = True
                TextBox25.Text = summe
            Case 4
                Label10.Text = aa
                TextBox26.Visible = True
                TextBox26.Text = summe
            Case 5
                Label12.Text = aa
                TextBox27.Visible = True
                TextBox27.Text = summe
            Case 6
                Label13.Text = aa
                TextBox28.Visible = True
                TextBox28.Text = summe
            Case 7
                TextBox29.Visible = True
                Label14.Text = aa
                TextBox29.Text = summe
            Case 8
                Label15.Text = aa
                TextBox30.Visible = True
                TextBox30.Text = summe
            Case 9
                Label16.Text = aa
                TextBox31.Visible = True
                TextBox31.Text = summe
            Case 10
                Label17.Text = aa
                TextBox32.Visible = True
                TextBox32.Text = summe
            Case 11
                Label18.Text = aa
                TextBox33.Visible = True
                TextBox33.Text = summe
            Case 12
                Label19.Text = aa
                TextBox34.Visible = True
                TextBox34.Text = summe
        End Select

    End Sub
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        datumspeichern()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUeberblick.Click
        Auswertungen.Location = New Point(12, 12)
        RadioButton3.Checked = True
        labelloeschen()
        kassaeingang = 0
        Dim kassa As String = "Kassa"
        Dim r As System.Data.DataRowView = bsBordkassa.Current
        BAdapter.SelectCommand = New OleDb.OleDbCommand
        BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' and kategorie = '" & kassa & "' "
        bsBordkassa.CancelEdit()
        dsToernverwaltung.Bordkassa.Clear()
        BAdapter.Fill(dsToernverwaltung.Bordkassa)
        iip = bsBordkassa.Count - 1
        For Me.pi = 0 To iip
            kassaeingang += dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
        Next
        '       dgvBordkassa.Visible = False
        Radiobuttons()
    End Sub
    Private Sub Radiobuttons()
        '       dgvBordkassa.Visible = False
        labelloeschen()
        If RadioButton3.Checked Then
            Label47.Text = "Name"
            Label48.Text = "Bezahlt"
            Dim crew As Integer = 1
            Dim summe As Single = 0
            Dim summeA As Single = 0
            Dim r As System.Data.DataRowView = bsBordkassa.Current
            BAdapter.SelectCommand = New OleDb.OleDbCommand
            BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where toern like '%" & TextBox1.Text & "%' order by Vzname"
            bsBordkassa.CancelEdit()
            dsToernverwaltung.Bordkassa.Clear()
            BAdapter.Fill(dsToernverwaltung.Bordkassa)
            If bsBordkassa.Count > 0 Then
                aaa = dsToernverwaltung.Bordkassa.Rows(0)("vzname").ToString
                iip = bsBordkassa.Count - 1
                For Me.pi = 0 To iip
                    If dsToernverwaltung.Bordkassa.Rows(Me.pi)("VZName").ToString = "Kassa" Then     ' Aus Kassa bezahlt
                        summeA += dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
                    End If
                    If aaa = dsToernverwaltung.Bordkassa.Rows(Me.pi)("vzname").ToString Then
                        summe += dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
                    Else
                        labelversorgen(summe, crew, aaa)
                        crew += 1
                        summe = dsToernverwaltung.Bordkassa.Rows(pi)("Betrag").ToString
                        aaa = dsToernverwaltung.Bordkassa.Rows(pi)("vzname").ToString
                        '                   If aaa = "Kassa" Then
                        Label45.Text = "Kassastand"
                        Label46.Text = Format((kassaeingang - summeA), "##,##0.00 €")
                        If kassaeingang < summe Then
                            Label45.ForeColor = Color.Red
                            Label46.ForeColor = Color.Red
                        Else
                            Label45.ForeColor = Color.Black
                            Label46.ForeColor = Color.Black
                        End If
                        ' End If
                    End If
                Next
                labelversorgen(summe, crew, aaa)                        'letzter Name
            End If
        End If
        If RadioButton4.Checked Then
            Label47.Text = "Kategorie"
            Label48.Text = "Aufwendung"
            Dim r As System.Data.DataRowView = bsBordkassa.Current
            Dim crew As Integer = 1
            Dim summe As Single = 0
            Dim kassa As String = "Kassa"
            BAdapter.SelectCommand = New OleDb.OleDbCommand
            BAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            BAdapter.SelectCommand.CommandText = "Select * from Bordkassa where ( toern like '%" & TextBox1.Text & "%' and kategorie<> '" & kassa & "')order by Kategorie"
            bsBordkassa.CancelEdit()
            dsToernverwaltung.Bordkassa.Clear()
            BAdapter.Fill(dsToernverwaltung.Bordkassa)
            If bsBordkassa.Count > 0 Then
                aaa = dsToernverwaltung.Bordkassa.Rows(0)("Kategorie").ToString
                iip = bsBordkassa.Count - 1
                For Me.pi = 0 To iip
                    If aaa = dsToernverwaltung.Bordkassa.Rows(Me.pi)("Kategorie").ToString Then
                        summe += dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
                    Else
                        labelversorgen(summe, crew, aaa)
                        crew += 1
                        summe = dsToernverwaltung.Bordkassa.Rows(Me.pi)("Betrag").ToString
                        aaa = dsToernverwaltung.Bordkassa.Rows(Me.pi)("Kategorie").ToString
                    End If
                Next
                labelversorgen(summe, crew, aaa)                        'letzter Name
            End If
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Radiobuttons()
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Radiobuttons()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If RadioButton3.Checked Then
            betragName(Label4.Text)
        Else
            betragKategorie(Label4.Text)
        End If

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If RadioButton3.Checked Then
            betragName(Label8.Text)
        Else
            betragKategorie(Label8.Text)
        End If
    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        If RadioButton3.Checked Then
            betragName(Label10.Text)
        Else
            betragKategorie(Label10.Text)
        End If
    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        If RadioButton3.Checked Then
            betragName(Label12.Text)
        Else
            betragKategorie(Label12.Text)
        End If
    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        If RadioButton3.Checked Then
            betragName(Label13.Text)
        Else
            betragKategorie(Label13.Text)
        End If
    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        If RadioButton3.Checked Then
            betragName(Label14.Text)
        Else
            betragKategorie(Label14.Text)
        End If
    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        If RadioButton3.Checked Then
            betragName(Label15.Text)
        Else
            betragKategorie(Label15.Text)
        End If
    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        If RadioButton3.Checked Then
            betragName(Label16.Text)
        Else
            betragKategorie(Label16.Text)
        End If
    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        If RadioButton3.Checked Then
            betragName(Label17.Text)
        Else
            betragKategorie(Label17.Text)
        End If
    End Sub
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        If RadioButton3.Checked Then
            betragName(Label18.Text)
        Else
            betragKategorie(Label18.Text)
        End If
    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        If RadioButton3.Checked Then
            betragName(Label19.Text)
        Else
            betragKategorie(Label19.Text)
        End If
    End Sub

    Private Sub ButtonGraphik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGraphik.Click
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        Dim ll() = {Label51, Label52, Label53, Label54, Label55, Label56, Label57, Label58, Label59, Label60, Label61}
        For Each lbl In ll
            lbl.Text = ""
        Next
        gbGraphik.Location = New Point(40, 30)
        ' Werte
    End Sub
    Private Sub zeichnen()
        Dim i As Integer
        Dim vier As String = "4"
        Me.Cursor = Cursors.WaitCursor
        BuchungCheck()
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "Select * from temp where feld0 like '%" & vier & "%'  "
        ' year(DAtumvon) like '%" & TextBox1.Text & "%'
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        If bsTemp.Count > 0 Then
            iip = bsTemp.Count - 1
            For Me.pi = 0 To iip
                If dsToernverwaltung.Temp.Rows(pi)("Feld1") <> "Kassa" Then
                    zw = dsToernverwaltung.Temp.Rows(Me.pi)("Feld2").ToString
                    tvalue(i) = dsToernverwaltung.Temp.Rows(Me.pi)("Feld1").ToString
                    mValue(i) = zw
                    i += 1
                    If i > 11 Then
                        MsgBox("Max. 11 Segmente sind möglich")
                        GoTo subende
                    End If
                End If

            Next
        End If
subende:
        Me.Cursor = Cursors.Default
        With PictureBox2
            ' Kreis zeichnen (PictureBox wird als Ausgabe-Objekt übergeben)
            DrawPie(mValue, PictureBox2)
        End With
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.AddNew()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        gbGraphik.Location = New Point(2000, 30)
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        ButtonGraphHerst.Visible = True
    End Sub
    Private Sub DrawPie(ByVal nValue() As Integer, ByVal oOutput As Object)
        ' Farben
        Dim nColor() As Color = {Color.Red, _
          Color.Navy, _
          Color.Cyan, _
          Color.Silver, _
          Color.SandyBrown, _
          Color.AliceBlue, _
          Color.MistyRose, _
          Color.MediumPurple, _
          Color.LimeGreen, _
          Color.Yellow, _
          Color.Beige, _
          Color.Moccasin}

        ' Graphics-Objekt
        Dim g As Graphics = oOutput.CreateGraphics

        ' Außmaße
        Dim nWidth As Integer = oOutput.Width
        Dim nHeight As Integer = oOutput.Height

        ' Summe aller Werte ermitteln
        Dim nMax As Integer
        Dim i As Integer

        For i = 0 To UBound(nValue)
            nMax += nValue(i)
        Next

        Dim nPercent As Integer
        Dim nAngle As Integer
        Dim nStartAngle As Integer
        Dim brush As System.Drawing.SolidBrush
        Dim nColIndex As Integer = 0

        ' Kreis zeichnen
        For i = 0 To UBound(nValue)
            brush = New System.Drawing.SolidBrush(nColor(nColIndex))

            ' Größe des Kreissegment berechnen und Text
            nPercent = CInt(nValue(i) / nMax * 100 + 0.5)
            nAngle = 360 * (nPercent / 100)
            If nPercent > 0 Then
                If nPercent > 10 Then
                    zw = nPercent
                Else
                    zw = nPercent
                    zw = zw + "  "
                End If
                Select Case i
                    Case 0
                        Label51.Text = zw + "%   " + tvalue(i)
                        Label51.ForeColor = nColor(i)
                    Case 1
                        Label52.Text = zw + "%   " + tvalue(i)
                        Label52.ForeColor = nColor(i)
                    Case 2
                        Label53.Text = zw + "%   " + tvalue(i)
                        Label53.ForeColor = nColor(i)
                    Case 3
                        Label54.Text = zw + "%   " + tvalue(i)
                        Label54.ForeColor = nColor(i)
                    Case 4
                        Label55.Text = zw + "%   " + tvalue(i)
                        Label55.ForeColor = nColor(i)
                    Case 5
                        Label56.Text = zw + "%   " + tvalue(i)
                        Label56.ForeColor = nColor(i)
                        Label56.BackColor = Color.Black
                    Case 6
                        Label57.Text = zw + "%   " + tvalue(i)
                        Label57.ForeColor = nColor(i)
                    Case 7
                        Label58.Text = zw + "%   " + tvalue(i)
                        Label58.ForeColor = nColor(i)
                    Case 8
                        Label59.Text = zw + "%   " + tvalue(i)
                        Label59.ForeColor = nColor(i)
                    Case 9
                        Label60.Text = zw + "%   " + tvalue(i)
                        Label60.ForeColor = nColor(i)
                    Case 10
                        Label61.Text = zw + "%   " + tvalue(i)
                        Label61.ForeColor = nColor(i)
                End Select
            End If

            ' Anfangswinkel
            If nStartAngle + nAngle > 360 Then nAngle = 360 - nStartAngle

            ' Segment zeichnen
            g.FillPie(brush, New Rectangle(0, 0, nWidth, nHeight), nStartAngle, nAngle)

            ' neuen Anfangspunkt berechnen
            nStartAngle += nAngle

            ' nächster Farbwert
            nColIndex += 1
            If nColIndex > UBound(nColor) Then nColIndex = 0

        Next i
        g.Dispose()
    End Sub

    Private Sub ButtonGraphHerst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGraphHerst.Click
        ButtonGraphHerst.Visible = False
        PictureBox2.Refresh()
        zeichnen()
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        If ComboBox1.SelectedItem = ComboBox2.SelectedItem Then
            MsgBox(" Zahler und Kategorie dürfen nicht identisch oder leer sein.")
        End If
    End Sub
    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        If ComboBox1.SelectedItem = ComboBox2.SelectedItem Then
            MsgBox(" Zahler und Kategorie dürfen nicht identisch oder leer sein.")
        End If
    End Sub

    Private Sub TextBox6_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox6.LostFocus
        TextBox6.Text = Replace(TextBox6.Text, ".", ",")
    End Sub
    Private Sub dgvBordkassa_LostFocus(sender As Object, e As System.EventArgs) Handles dgvBordkassa.LostFocus
        bsBordkassa.EndEdit()
        taBordkassa.Update(dsToernverwaltung.Bordkassa)
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged
        If Len(TextBox8.Text) > 30 Then
            MsgBox("Rehnungstext ist auf 30 Buchstaben beschränkt.")
            TextBox8.Text = TextBox8.Text.Substring(0, 30)
        End If
    End Sub


End Class