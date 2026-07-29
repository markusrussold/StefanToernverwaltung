Public Class Nachtansteuerung
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Dim Anzahl As Integer
    Dim tcAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Private Sub Nachtansteuerung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00:00"

    End Sub
    Private Sub crew(ByVal Toern)
        Dim text
        Dim rt As System.Data.DataRowView = bsTC.Current()
        tcAdapter.SelectCommand = New OleDb.OleDbCommand
        tcAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tcAdapter.SelectCommand.CommandText = "Select * from tc where toern like '%" & Toern & "%' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tcAdapter.Fill(dsToernverwaltung.TC)
        ListBox1.Items.Clear()
        Anzahl = bsTC.Count
        For i = 0 To Anzahl - 1
            text = dsToernverwaltung.TC.Rows(i)("VZName")
            If IsDBNull(Text) = False Then
                If Text > " " Then
                    ListBox1.Items.Add(text)
                End If
            End If
        Next
    End Sub
    Private Sub DataGridView4_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox2.LostFocus

    End Sub

    Private Sub MaskedTextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox1.LostFocus

    End Sub

    Private Sub MaskedTextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox2.LostFocus

    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox3.LostFocus

    End Sub
    Private Sub CheckBox1_Click(sender As Object, e As System.EventArgs) Handles CheckBox1.Click

    End Sub
End Class