Public Class ComboBox
    Public aaa As String
    Public zz As String = 0
    Public iii As Integer
    Public ij As Integer
    Dim wieder As Boolean
    Dim lns As Integer
    Private Sub ComboBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taListdaten.Fill(Me.dsToernverwaltung.Listdaten)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsListdaten.Current
        '
        ' Alle Listboxen aus dem Programm sind bereits vordefiniert. Neue sind immer e-mail Absender "Privat"
        '
        Dim fbreite As Integer
        Dim fhoehe As Integer
        Dim kalk As String = "Kalkulation - Versicherung"
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Listdaten where bezeichnung = '" & kalk & "' order by Bezeichnung"
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        If bsListdaten.Count = 0 Then
            bsListdaten.AddNew()
            TextBox4.Text = "Rechtsschutzversicherung"
            TextBox6.Text = "Unfallversicherung"
            TextBox7.Text = "Haftpflichtversicherung"
            TextBox8.Text = "Beschlagnahmeversicherung"
            TextBox9.Text = "Kautionsversicherung"
            TextBox10.Text = "Stornoversicherung"
            TextBox5.Text = "Folgeschadenversicherung"
            TextBox2.Text = "Kalkulation - Versicherung"
            bsListdaten.AddNew()
            taListdaten.Update(dsToernverwaltung.Listdaten)
        End If
        aaa = " "
        pAdapter.SelectCommand.CommandText = "Select * from Listdaten where bezeichnung > '" & aaa & "' order by Bezeichnung"
        bsListdaten.CancelEdit()
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        bsListdaten.Position = 0
        iii = bsListdaten.Count - 1
        For i = 0 To iii
            aaa = dsToernverwaltung.Listdaten.Rows(i)("Bezeichnung").ToString
            ComboBox1.Items.Add(aaa)
        Next
        wieder = False
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        TextBox1.Text = ComboBox1.Text
        '      Textfuellen()
    End Sub
    Private Sub Textfuellen()
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsListdaten.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Listdaten where Bezeichnung like '%" & TextBox1.Text & "%'"
        dsToernverwaltung.Listdaten.Clear()
        pAdapter.Fill(dsToernverwaltung.Listdaten)
        If bsListdaten.Count = 1 Then
            bsListdaten.Position = 0
            zz = 0
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld1").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld2").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld3").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld4").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld5").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld6").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld7").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld8").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld9").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld10").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld11").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld12").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld13").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld14").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld15").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld16").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld17").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld18").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld19").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld20").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld21").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld22").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld23").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld24").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld25").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld26").ToString)
            listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld27").ToString)
            '          listboxFuellen(dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString)
        Else
            bsListdaten.AddNew()
            TextBox2.Text = TextBox1.Text
            TextBox3.Text = "Privat"
            bsListdaten.AddNew()
            TextBox2.Text = TextBox1.Text
            TextBox3.Text = "Privat"
            taListdaten.Update(dsToernverwaltung.Listdaten)
            pAdapter.SelectCommand.CommandText = "Select * from Listdaten where Bezeichnung like '%" & TextBox1.Text & "%'"
            dsToernverwaltung.Listdaten.Clear()
            pAdapter.Fill(dsToernverwaltung.Listdaten)
            ComboBox1.Items.Add(TextBox1.Text)
        End If
        If dsToernverwaltung.Listdaten.Rows(0)("Feld28").ToString = "Privat" Then
            Label4.Text = "e-mail Absender"
        Else
            Label4.Text = "Textbox"
        End If
        lns = 27 - RichTextBox1.Lines.Length
        Label3.Text = "Noch verfügbare Anzahl Zeilen: " + lns.ToString
        Button1.Enabled = True
    End Sub
    Private Sub listboxFuellen(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                RichTextBox1.Text = RichTextBox1.Text + text & vbCrLf
             End If
        End If
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        If wieder Then
        Else
            TextBox1.Text = ComboBox1.Text
            RichTextBox1.Clear()
            Textfuellen()
            '           Textfuellen()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text
        If TextBox1.Text = "Kalkulation - Versicherung" Then
            RichTextBox1.Visible = False
            Label2.Text = "            Versicherungstext                                        Kosten"
            GroupBox1.Location = New Point(52, 102)
            Label3.Visible = False
        End If
        RichTextBox1.Clear()
        Textfuellen()
        wieder = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        speichern()
    End Sub
    Private Sub speichern()
        Dim bAnzahl As Integer
        Dim start As Integer = 0
        Dim ende As Integer = 0
        Dim i As Integer
        bAnzahl = RichTextBox1.Text.Length
        zz = 0
        If TextBox1.Text = "Kalkulation - Versicherung" Then
            bsListdaten.EndEdit()
            taListdaten.Update(dsToernverwaltung.Listdaten)
            Me.Close()
        Else
            For i = 0 To bAnzahl - 1
                If RichTextBox1.Text.Substring(i, 1) = vbLf Or i = bAnzahl - 1 Then
                    ende = i
                    zz += 1
                    aaa = "Feld" + zz
                    If i = bAnzahl - 1 Then
                        dsToernverwaltung.Listdaten.Rows(0)(aaa) = RichTextBox1.Text.Substring(start, ende - start + 1)
                    Else
                        dsToernverwaltung.Listdaten.Rows(0)(aaa) = RichTextBox1.Text.Substring(start, ende - start)
                    End If
                    '                   bsListdaten.AddNew()
                    bsListdaten.EndEdit()
                    taListdaten.Update(dsToernverwaltung.Listdaten)
                    start = i + 1
                End If
            Next
            For i = zz + 1 To 27
                aaa = "Feld" + i.ToString
                dsToernverwaltung.Listdaten.Rows(0)(aaa) = ""
                bsListdaten.EndEdit()
                taListdaten.Update(dsToernverwaltung.Listdaten)
            Next

            RichTextBox1.Clear()
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            lns = 27 - RichTextBox1.Lines.Length
            If lns > 0 Then
                Label3.Text = "Noch verfügbare Anzahl Zeilen: " + lns.ToString
            Else
                '            MsgBox("Max. Anzahl Zeilen erreicht. Speichern")
                If MsgBox("Max. Anzahl Zeilen erreicht. ", 1, "Speichern") = vbOK Then
                    speichern()
                End If
            End If
            End If

    End Sub
End Class