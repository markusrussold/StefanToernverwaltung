Public Class Astrodaten
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter                ' Astrodaten
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Törn
    Dim aaa As String
    Dim buch1 As String
    Dim position As Integer
    Dim iii As Integer
    Dim aenderung As Boolean
    Private Sub Astrodaten_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Astrodaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taAstrodaten.Fill(Me.DsLogbuch.Astrodaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox3.Mask = "00:00"
        MaskedTextBox2.Mask = "00:00"
        Label2.Visible = False
        aaa = TextBox1.Text
        Me.Text = "Astrodaten für Törn: " + aaa
        If TextBox1.Text > "" Then
            suchen()
        End If
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
        '     GroupBox3.Location = New Point(12, 90)
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
                TextBox9.Text = TextBox1.Text
                GroupBox3.Location = New Point(1200, 110)
                GroupBox2.Location = New Point(12, 90)
            Case 1
                DbAccess.SafePosition(bsToernname)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                '              Label2.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                '       GroupBox3.Location = New Point(12, 90)
                GroupBox2.Location = New Point(1200, 110)
                TextBox9.Text = TextBox1.Text
                Label2.Visible = True
                Label2.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                suchenAstro()
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
    Private Sub suchenAstro()
        Dim rp As System.Data.DataRowView = bsAstrodaten.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Astrodaten where toernbezeichnung = '" & TextBox1.Text & "'"
        bsAstrodaten.CancelEdit()
        DsLogbuch.Astrodaten.Clear()
        pAdapter.Fill(DsLogbuch.Astrodaten)
        DbAccess.SafePosition(bsAstrodaten)
        aaa = bsAstrodaten.Count
        If aaa = 0 Then
            bsAstrodaten.AddNew()
            aenderung = False
        Else
            aenderung = True
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox9.Text = TextBox1.Text
        If aenderung Then
            bsAstrodaten.EndEdit()
            taAstrodaten.Update(DsLogbuch.Astrodaten)
        Else
            bsAstrodaten.AddNew()
            taAstrodaten.Update(DsLogbuch.Astrodaten)
        End If
        SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
        Me.Close()
    End Sub
End Class