Public Class ComboMarketing
    Public aaa As String
    Public zz As String = 0
    Public iii As Integer
    Public ij As Integer
    Dim wieder As Boolean
    Dim lns As Integer
    Private Sub ComboMarketing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Listbox". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taListbox.Fill(Me.DsAusbildung.Listbox)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsListbox.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Listbox order by FormularName"
        bsListbox.CancelEdit()
        dsausbildung.Listbox.Clear()
        pAdapter.Fill(dsausbildung.Listbox)
        bsListbox.Position = 0
        iii = bsListbox.Count - 1
        For i = 0 To iii
            aaa = DsAusbildung.Listbox.Rows(i)("FormularName").ToString
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
        Dim rp As System.Data.DataRowView = bsListbox.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Listbox where FormularName like '%" & TextBox1.Text & "%'"
        dsausbildung.Listbox.Clear()
        pAdapter.Fill(dsausbildung.Listbox)
        If bsListbox.Count = 1 Then
            bsListbox.Position = 0
            zz = 0
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld1").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld2").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld3").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld4").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld5").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld6").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld7").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld8").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld9").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld10").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld11").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld12").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld13").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld14").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld15").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld16").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld17").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld18").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld19").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld20").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld21").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld22").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld23").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld24").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld25").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld26").ToString)
            listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld27").ToString)
            '           listboxFuellen(dsausbildung.Listbox.Rows(0)("Feld28").ToString)
        Else
            If TextBox1.Text > "" Then
                bsListbox.AddNew()
                TextBox2.Text = TextBox1.Text
                TextBox3.Text = "Privat"
                bsListbox.AddNew()
                TextBox2.Text = TextBox1.Text
                TextBox3.Text = "Privat"
                taListbox.Update(DsAusbildung.Listbox)
                ComboBox1.Items.Add(TextBox1.Text)
            End If
        End If
        If DsAusbildung.Listbox.Rows(0)("Feld28").ToString = "Privat" Then
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
            Textfuellen()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text
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
        bAnzahl = RichTextBox1.Text.Length
        zz = 0
        For i = 0 To bAnzahl - 1
            If RichTextBox1.Text.Substring(i, 1) = vbLf Or i = bAnzahl - 1 Then
                ende = i
                zz += 1
                aaa = "Feld" + zz
                If i = bAnzahl - 1 Then
                    dsausbildung.Listbox.Rows(0)(aaa) = RichTextBox1.Text.Substring(start, ende - start + 1)
                Else
                    dsausbildung.Listbox.Rows(0)(aaa) = RichTextBox1.Text.Substring(start, ende - start)
                End If
                bsListbox.EndEdit()
                taListbox.Update(dsausbildung.Listbox)
                start = i + 1
            End If
        Next
        For i = zz + 1 To 27
            aaa = "Feld" + i.ToString
            DsAusbildung.Listbox.Rows(0)(aaa) = ""
            bsListbox.EndEdit()
            taListbox.Update(DsAusbildung.Listbox)
        Next
        RichTextBox1.Clear()
        ComboBox1.Text = ""
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