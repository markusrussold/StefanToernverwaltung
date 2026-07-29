
Imports System.IO
Imports System.Text
Public Class Adressen
    Public speicherformular As String
    Public aaa As String
    Dim auswahl As Boolean = False
    Dim ok As Boolean
    Dim FB_auswahl As Single = 0
    Private Sub Adressen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Listdaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)

        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsListdaten.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung

        If Menü.FreischaltZiffer = 1 Or Menü.FreischaltZiffer = 3 Or Menü.FreischaltZiffer = 4 Then
            ok = True
        Else
            ok = False
        End If

        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Listdaten where Bezeichnung like 'Crew - Status' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        DbAccess.SafePosition(bsListdaten)
        If bsListdaten.Count = 1 Then
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            comboFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        End If
        With CrewAdressenDataGridView.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        With CrewAdressenDataGridView
            .Columns(0).Width = 70
            .Columns(1).Width = 180
            .Columns(2).Width = 120
        End With

        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where R3 > ' ' order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        aaa = bsCrewAdressen.Count
        For i = 0 To aaa - 1
            dsToernverwaltung.CrewAdressen.Rows(i)("R3") = " "
            bsCrewAdressen.EndEdit()
            taCrewAdressen.Update(dsToernverwaltung.CrewAdressen)
        Next
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        aaa = bsCrewAdressen.Count
        CheckBox1.Checked = True
        Crew.crewprogramm = False
        Label6.Visible = False
        TextBox8.Visible = False
    End Sub
    Private Sub comboFuellen(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                ComboBox1.Items.Add(text)
            End If
        End If
    End Sub

    Private Sub selektion(ByVal code)
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        Select Case code
            Case 1
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where Plz >= '" & TextBox1.Text & "' and Plz <= '" & TextBox2.Text & "'order by vzname"
            Case 11
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where plz = '" & TextBox1.Text & "' order by vzname"
            Case 2
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where status like '" & ComboBox1.Text & "' order by vzname"
            Case 3
                Select Case FB_auswahl
                    Case 1
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb1 order by vzname"
                    Case 2
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where  fb2  order by vzname"
                    Case 3
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where  fb1 or fb2 order by vzname"
                    Case 4
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where  fb3 order by vzname"
                    Case 5
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb1  or fb3 order by vzname"
                    Case 6
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb2 or fb3 order by vzname"
                    Case 7
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb1 or fb2 or fb3 order by vzname"
                    Case 8
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb4 order by vzname"
                    Case 9
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb1 or fb4 order by vzname"
                    Case 10
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where  fb2  or fb4 order by vzname"
                    Case 11
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb1 or fb2 or fb4 order by vzname"
                    Case 12
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where  fb3 or fb4 order by vzname"
                    Case 13
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb1  or fb3 or fb4 order by vzname"
                    Case 14
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where  fb2 or fb3 or fb4 order by vzname"
                    Case 15
                        cAdapter.SelectCommand.CommandText = "Select * from crewadressen where fb1 or fb2 or fb3 or fb4 order by vzname"
                End Select
            Case 4
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where Funk >   ' '  order by vzname"
            Case 5
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where clubmitglied  order by vzname"
            Case 6
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where not clubmitglied  order by vzname"
        End Select
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        aaa = bsCrewAdressen.Count

    End Sub
    Private Sub RadioButton2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.GotFocus
        ListBox1.Visible = False
        Button2.Visible = False
        DataGridView1.Location = New Point(1000, 1280)
        CrewAdressenDataGridView.Visible = True
        auswahl = False
        If ComboBox1.Text > " " Then
            RadioButton2.Checked = True
            ComboBox1.Focus()
        End If
        TextBox6.Text = ComboBox1.Text
    End Sub
    Private Sub RadioButton1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.GotFocus
        ListBox1.Visible = False
        Button2.Visible = False
        DataGridView1.Location = New Point(1000, 1280)
        CrewAdressenDataGridView.Visible = True
        auswahl = False
        RadioButton1.Checked = True
        If TextBox1.Text > " " And TextBox2.Text > " " Then
            selektion("1")
        Else
            If TextBox1.Text > " " Then
                selektion("11")
            End If
        End If
    End Sub
    Private Sub RadioButton4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.GotFocus
        radioDelet()
        ListBox1.Visible = False
        Button2.Visible = False
        DataGridView1.Location = New Point(1000, 1280)
        CrewAdressenDataGridView.Visible = True
        auswahl = False
        selektion("4")
        TextBox6.Text = "mit Funklizenz"
    End Sub
    Private Sub RadioButton6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.GotFocus
        radioDelet()
        ListBox1.Visible = True
        Button2.Visible = True
        auswahl = True
        DataGridView1.Location = New Point(1000, 1280)
        CrewAdressenDataGridView.Visible = True
        TextBox6.Text = "Ausgewählt"
    End Sub
    Private Sub RadioButton5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.GotFocus
        radioDelet()
        ListBox1.Visible = True
        Button2.Visible = True
        auswahl = True
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        GroupBox1.Text = "Törn auswählen"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox1.Text = RTrim(TextBox1.Text)
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by Toernbezeichnung "
        '       xAdapter.SelectCommand.CommandText = "Select * from Toernname where IDtoern = '" & TextBox15.Text & "' "
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        DataGridView1.Location = New Point(30, 290)
        CrewAdressenDataGridView.Visible = False
        With DataGridView1
            .Columns(0).Width = 180
        End With
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            FBgb.Location = New Point(200, 85)
            FBgb.Visible = True
            radioDelet()
            ListBox1.Visible = False
            Button2.Visible = False
            DataGridView1.Location = New Point(1000, 1280)
            CrewAdressenDataGridView.Visible = True
            auswahl = False
            TextBox6.Text = "mit Segelschein"
            FB_auswahl = 0
        Else
            FBgb.Visible = False
        End If
    End Sub
    Private Sub RadioButton7_GotFocus(sender As Object, e As System.EventArgs) Handles RadioButton7.GotFocus
        radioDelet()
        ListBox1.Visible = False
        Button2.Visible = False
        DataGridView1.Location = New Point(1000, 1280)
        CrewAdressenDataGridView.Visible = True
        auswahl = False
        selektion("5")
        TextBox6.Text = "Clubmitglieder"
    End Sub
    Private Sub RadioButton8_GotFocus(sender As Object, e As System.EventArgs) Handles RadioButton8.GotFocus
        radioDelet()
        ListBox1.Visible = False
        Button2.Visible = False
        DataGridView1.Location = New Point(1000, 1280)
        CrewAdressenDataGridView.Visible = True
        auswahl = False
        selektion("6")
        TextBox6.Text = "Ohne Clubmitgliederschaft"
    End Sub
    Private Sub RadioButton9_GotFocus(sender As Object, e As System.EventArgs) Handles RadioButton9.GotFocus
        radioDelet()
        ListBox1.Visible = True
        TextBox8.Visible = True
        PictureBox1.Visible = True
        Label6.Visible = True
        Button2.Visible = False
        DataGridView1.Location = New Point(1000, 1280)
        CrewAdressenDataGridView.Visible = True
        auswahl = True
    End Sub
    Private Sub radioDelet()
        TextBox2.Text = ""
        TextBox1.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub TextBox8_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox8.LostFocus
        Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from crewadressen  order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        cAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        For i = 0 To bsCrewAdressen.Count - 1
            If Not DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(i)("Bemerkung")) Then
                If Inhalt(dsToernverwaltung.CrewAdressen.Rows(i)("Bemerkung"), TextBox8.Text) Then
                    ListBox1.Items.Add(dsToernverwaltung.CrewAdressen.Rows(i)("vzname"))
                End If
            End If
        Next
        '        selektion("7")
        TextBox6.Text = "'" + TextBox8.Text + "' Text in der Bemerkung"
    End Sub
    Public Function Inhalt(ByVal Memo As String, ByVal text As String) As Boolean
        If Memo.Contains(text) Then Return True Else Return False
    End Function
    Private Sub DruckenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenButton.Click
        GroupBox2.Visible = True
        Button2.Visible = True
        GroupBox2.Location = New Point(140, 70)
        CrewAdressenDataGridView.Visible = False
        DruckenButton.Enabled = False
        ExportButton.Enabled = False
        FBgb.Visible = False
    End Sub
    Private Sub ausgabe()
        Dim XL As New PrintOutAA
        Dim dv As DataView
        Dim t As DataTable
        Me.Cursor = Cursors.WaitCursor
        If auswahl Then
            Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
            cAdapter.SelectCommand = New OleDb.OleDbCommand
            cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            For i = 0 To ListBox1.Items.Count - 1
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname =   '" & ListBox1.Items(i) & "'  order by vzname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                cAdapter.Fill(dsToernverwaltung.CrewAdressen)
                DbAccess.SafePosition(bsCrewAdressen)
                dsToernverwaltung.CrewAdressen.Rows(0)("R3") = "X"
                bsCrewAdressen.EndEdit()
                taCrewAdressen.Update(dsToernverwaltung.CrewAdressen)
            Next
            cAdapter.SelectCommand.CommandText = "Select * from crewadressen where R3 >   ' '  order by vzname"
            bsCrewAdressen.CancelEdit()
            dsToernverwaltung.CrewAdressen.Clear()
            cAdapter.Fill(dsToernverwaltung.CrewAdressen)
            DbAccess.SafePosition(bsCrewAdressen)
        Else
            aaa = bsCrewAdressen.Count
            For i = 0 To aaa - 1
                dsToernverwaltung.CrewAdressen.Rows(i)("R3") = " "
                bsCrewAdressen.EndEdit()
                taCrewAdressen.Update(dsToernverwaltung.CrewAdressen)
            Next
        End If
        If bsCrewAdressen.Count > 0 Then
            dv = bsCrewAdressen.List
            t = dv.ToTable("Printing", False, "Zuname", "Vorname", "Anrede", "Handy", "email", "straße", "plz", "ort", "Reisepassnr", "gebdatum", "gebort", "funk", "segelschein", "nationalitaet", "status", "Bemerkung", "FB1", "FB2", "FB3", "FB4", "A-schein", "Motorboot", "toernnr", "R3")
            XL.PrintAdressen(t)
        End If
        aaa = bsCrewAdressen.Count
        For i = 0 To aaa - 1
            '           dsToernverwaltung.CrewAdressen.Rows(i)("R3") = " "
            bsCrewAdressen.EndEdit()
            taCrewAdressen.Update(dsToernverwaltung.CrewAdressen)
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        selektion("2")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        RadioButton2.Checked = True
        selektion("2")
        TextBox6.Text = ComboBox1.Text
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        RadioButton1.Checked = True
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text > " " Then
            selektion("11")
            TextBox6.Text = "Plz " + TextBox1.Text
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox1.Text > " " And TextBox2.Text > " " Then
            selektion("1")
            TextBox6.Text = "Plz von " + TextBox1.Text + " bis " + TextBox2.Text
        End If
    End Sub

    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click
        speicherformular = GetSetting("Toernadressen", "Pfad", "T")
        TextBox3.Visible = True
        Button1.Visible = True
        TextBox3.Text = speicherformular
    End Sub
    Private Sub excel()
        If auswahl Then
            Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rc As System.Data.DataRowView = bsCrewAdressen.Current
            cAdapter.SelectCommand = New OleDb.OleDbCommand
            cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            For i = 0 To ListBox1.Items.Count - 1
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname =   '" & ListBox1.Items(i) & "'  order by vzname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                cAdapter.Fill(dsToernverwaltung.CrewAdressen)
                DbAccess.SafePosition(bsCrewAdressen)
                dsToernverwaltung.CrewAdressen.Rows(0)("R3") = "X"
                bsCrewAdressen.EndEdit()
                taCrewAdressen.Update(dsToernverwaltung.CrewAdressen)
            Next
            cAdapter.SelectCommand.CommandText = "Select * from crewadressen where R3 >   ' '  order by vzname"
            bsCrewAdressen.CancelEdit()
            dsToernverwaltung.CrewAdressen.Clear()
            cAdapter.Fill(dsToernverwaltung.CrewAdressen)
            DbAccess.SafePosition(bsCrewAdressen)
        End If
        Dim ii As Integer
        Dim anzahl As Integer
        speicherformular = TextBox3.Text
        Dim fOut As StreamWriter = New StreamWriter(speicherformular, False, Encoding.Default)
        Dim j As Integer
        ii = CrewAdressenDataGridView.ColumnCount
        For i = 0 To ii - 1
            fOut.Write(CrewAdressenDataGridView.Columns(i).HeaderText)
            If i < (ii - 1) Then
                fOut.Write(";")
            End If
        Next
        fOut.WriteLine()
        'Tabelle
        anzahl = CrewAdressenDataGridView.Rows.Count
        For j = 0 To anzahl - 1
            For i = 0 To ii - 1
                If IsDBNull(CrewAdressenDataGridView.Item(i, j).Value) = True Then
                Else
                    aaa = CrewAdressenDataGridView.Item(i, j).Value
                    fOut.Write(aaa)
                End If
                If i < (ii - 1) Then
                    fOut.Write(";")
                End If
            Next
            fOut.WriteLine()
        Next
        fOut.Close()
        TextBox3.Text = "fertig"
        TextBox3.ForeColor = Color.Red
        TextBox3.Refresh()
        System.Threading.Thread.Sleep(2000)     '2 Sec Wartezeit
        Me.Close()
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        excel()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        excel()
    End Sub
    Private Sub CrewAdressenDataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrewAdressenDataGridView.Click
        If auswahl Then
            ListBox1.Items.Add(TextBox4.Text)
            Button2.Visible = True
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text > " " And TextBox2.Text > " " Then
            selektion("1")
            TextBox6.Text = "Plz von " + TextBox1.Text + " bis " + TextBox2.Text
        End If

    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        If RadioButton5.Checked Or RadioButton6.Checked Then
            Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rt As System.Data.DataRowView = bsTC.Current
            ListBox1.Items.Add(TextBox7.Text)
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from TC where idtoern = '" & TextBox15.Text & "' order by vzname"
            bsTC.CancelEdit()
            dsToernverwaltung.TC.Clear()
            tAdapter.Fill(dsToernverwaltung.TC)
            For i = 0 To bsTC.Count - 1
                ListBox1.Items.Add(dsToernverwaltung.TC.Rows(i)("vzname"))
            Next
            TextBox6.Text = dsToernverwaltung.TC.Rows(0)("toern")
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Button2.Visible = False
    End Sub

    Private Sub Button3Ausgabe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3Ausgabe.Click
        If ok Then
            ausgabe()
            GroupBox2.Visible = False
        Else
            MsgBox("Funktion - Drucken - unterstützt nur die freigeschaltete Version. ")
        End If
    End Sub


    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            FB_auswahl += 1
        Else
            FB_auswahl -= 1
        End If
        selektion("3")
    End Sub
    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked Then
            FB_auswahl += 2
        Else
            FB_auswahl -= 2
        End If
        selektion("3")
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            FB_auswahl += 4
        Else
            FB_auswahl -= 4
        End If
        selektion("3")
    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked Then
            FB_auswahl += 8
        Else
            FB_auswahl -= 8
        End If
        selektion("3")
    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked Then
            CheckBox18.Text = "Alle abwählen"
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
            CheckBox13.Checked = True
        Else
            CheckBox18.Text = "Alle auswählen"
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        aaa = ListBox1.Text
        ListBox1.Items.Remove(aaa)
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        ' Verlassen Bemerkungsfeld
        PictureBox1.Focus()
    End Sub
End Class
