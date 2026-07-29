Public Class ErsterTag
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Public iii As Integer
    Public aaa As String
    Public ij As Integer
    Public ijj As Integer
    Dim buch1 As String
    Dim dgv As Boolean = False
    Dim nIndex As Integer
    Dim position As Integer
    Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim lAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub ErsterTag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Listdaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.ErsteTag". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taErsteTag.Fill(Me.dsCrewbesprechung.ErsteTag)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.AddNew()
        Dim rp As System.Data.DataRowView = bsListdaten.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from listdaten where Bezeichnung like 'ErsterTag - Aufgaben' "
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        If bsListdaten.Count = 1 Then
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            comboFuellen1(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
        End If
        lbAufgaben.Sorted = True
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        GroupBox1.Location = New Point(12, 9400)
        GroupBox2.Location = New Point(12, 9400)
        Button1.Visible = False
        Label6.Visible = False
        BtAufgabe.Visible = False
        TextBox4.Visible = False
    End Sub
    Private Sub comboFuellen1(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                lbAufgaben.Items.Add(text)
            End If
        End If

    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
        GroupBox1.Location = New Point(20, 140)
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
        '       aenderung = True
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                '                Formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                Label2.Text = "Bootsname: " + dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                lbCrew.Items.Add(dsToernverwaltung.Toernname.Rows(0)("skipper").ToString)
                Label1.Text = SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumvon")) + " - " + SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumbis"))
                GroupBox1.Location = New Point(12000, 94)
                GroupBox2.Location = New Point(20, 140)
                Crewanzahl()
                Aufgaben()
                DataGridView2.Enabled = False

                Button1.Visible = True
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
          End Select
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
    Private Sub Crewanzahl()
         Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        ijj = bsTC.Count + 1
        Label3.Text = "Crewanzahl: " + ijj.ToString
        For ijj = 0 To bsTC.Count - 1
            lbCrew.Items.Add(dsToernverwaltung.TC.Rows(ijj)("vzname").ToString)
        Next
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        suchen()
    End Sub

    Private Sub Aufgaben()
        Dim rt As System.Data.DataRowView = bsErsteTag.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        aAdapter.SelectCommand.CommandText = "Select * from erstetag where toernname = '" & TextBox1.Text & "' order by was "
        bsErsteTag.CancelEdit()
        dsCrewbesprechung.ErsteTag.Clear()
        aAdapter.Fill(dsCrewbesprechung.ErsteTag)
        If bsErsteTag.Count = 0 Then
            For ij = 0 To lbAufgaben.Items.Count - 1
                bsErsteTag.AddNew()
                TextBox2.Text = TextBox1.Text
                TextBox3.Text = lbAufgaben.Items(ij)
                bsErsteTag.EndEdit()
                taErsteTag.Update(dsCrewbesprechung.ErsteTag)
            Next
         End If
    End Sub

    Private Sub DataGridView2_CurrentCellChanged(sender As Object, e As System.EventArgs) Handles DataGridView2.CurrentCellChanged
        If dgv Then Speichern()
    End Sub

    Private Sub DataGridView2_GotFocus(sender As Object, e As System.EventArgs) Handles DataGridView2.GotFocus
        dgv = True
    End Sub
    Private Sub DataGridView2_LostFocus(sender As Object, e As System.EventArgs) Handles DataGridView2.LostFocus
        If dgv Then Speichern()
    End Sub
    Private Sub Speichern()
        '      Aufgaben()
        SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
        bsErsteTag.Position = DataGridView2.CurrentCell.RowIndex
        bsErsteTag.EndEdit()
        taErsteTag.Update(dsCrewbesprechung.ErsteTag)
    End Sub

    Private Sub lbCrew_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbCrew.MouseClick
        aaa = lbCrew.Text
        DataGridView2.Enabled = True
        Label8.Visible = False
        Label7.Visible = False
    End Sub
    Private Sub DataGridView2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        If DataGridView2.CurrentCell.ColumnIndex = 2 Then
            DataGridView2.CurrentCell.Value = aaa
            Speichern()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtBearbeiten_Click(sender As System.Object, e As System.EventArgs) Handles BtBearbeiten.Click
        suchen()
    End Sub

    Private Sub lbAufgaben_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbAufgaben.MouseClick
        Label6.Visible = True
        BtAufgabe.Visible = True
        TextBox4.Visible = True
    End Sub
    Private Sub lbAufgaben_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbAufgaben.MouseDoubleClick
        TextBox3.Text = lbAufgaben.Text
        TextBox2.Text = TextBox1.Text
        bsErsteTag.AddNew()
        taErsteTag.Update(dsCrewbesprechung.ErsteTag)
    End Sub
    Private Sub BtAufgabe_Click(sender As System.Object, e As System.EventArgs) Handles BtAufgabe.Click
        If TextBox4.Text > " " Then
            comboFuellen1(TextBox4.Text)
            '           bsErsteTag.AddNew()
            TextBox2.Text = TextBox1.Text
            TextBox3.Text = TextBox4.Text
            '          bsErsteTag.EndEdit()
            '         taErsteTag.Update(dsCrewbesprechung.ErsteTag)

            For i = 1 To 27
                aaa = "Feld" + i.ToString
                If dsToernverwaltung.Listdaten.Rows(0)(aaa) = "" Then
                    Exit For
                End If
            Next
            dsToernverwaltung.Listdaten.Rows(0)(aaa) = TextBox4.Text
            bsListdaten.EndEdit()
            taListdaten.Update(dsToernverwaltung.Listdaten)
        End If
    End Sub
End Class