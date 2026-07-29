Public Class Maengel
    Dim aaa As String
    Dim buch1 As String
    Dim position As Integer
    Dim iii As Integer
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Private Sub Maengel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taMaengel.Fill(Me.DsLogbuch.Maengel)
        MaskedTextBox1.Mask = "00.00.0000"
        '    MaskedTextBox1.Mask = Today
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        Dim rp As System.Data.DataRowView = bsMaengel.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Maengel"
        bsMaengel.CancelEdit()
        DsLogbuch.Maengel.Clear()
        pAdapter.Fill(DsLogbuch.Maengel)
        bsMaengel.Position = 0
        aaa = bsMaengel.Count
        bsMaengel.AddNew()
        aaa = TextBox1.Text
        Me.Text = "Mängel im Törn: " + aaa
        If TextBox1.Text > "" Then
            suchen()
        End If
        ButtonL.Enabled = False
        GroupBox2.Focus()
        MaskedTextBox1.Focus()
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
        DataGridToern.Location = New Point(12, 110)
        '       GroupBox1.Enabled = False
        '        GroupBox2.Text = "Törn auswählen mit Doppelklick"
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
                Formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                '              Label2.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                DataGridToern.Location = New Point(1200, 110)
                TextBox5.Text = TextBox1.Text
                SuchenMaengel()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
        End Select
    End Sub
    Private Sub SuchenMaengel()
        Dim rp As System.Data.DataRowView = bsMaengel.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Maengel where toernbezeichnung = '" & TextBox1.Text & "'  order by datum"
        bsMaengel.CancelEdit()
        DsLogbuch.Maengel.Clear()
        pAdapter.Fill(DsLogbuch.Maengel)
        bsMaengel.Position = 0
        aaa = bsMaengel.Count
        bsMaengel.AddNew()
        GroupBox2.Focus()
        MaskedTextBox1.Focus()

    End Sub
    Private Sub Formularloeschen()
        MaskedTextBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
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
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
     End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub

    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        TextBox5.Text = TextBox1.Text
        If TextBox3.Text > "" Then
            bsMaengel.AddNew()
            taMaengel.Update(DsLogbuch.Maengel)
            SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
        End If
        MaskedTextBox1.Focus()
    End Sub
    Private Sub DataGridToern_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridToern.CellMouseClick
        suchen()
    End Sub

    Private Sub ButtonL_Click(sender As System.Object, e As System.EventArgs) Handles ButtonL.Click
        bsMaengel.RemoveCurrent()
        taMaengel.Update(DsLogbuch.Maengel)
        SuchenMaengel()
        ButtonL.Enabled = False
        MaskedTextBox1.Focus()
    End Sub
    Private Sub DataGridMaengel_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridMaengel.CellMouseClick
        ButtonL.Enabled = True
    End Sub
End Class