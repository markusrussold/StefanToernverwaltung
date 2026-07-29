Public Class VersichTarifeY
    Dim hafadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim unfadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim Recadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim KauAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim FolAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim RueAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub VersichTarifeY_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.taYPderech.Fill(Me.dsVersicherung.YPderech)
        Me.taYPdefol.Fill(Me.dsVersicherung.YPdefol)
        Me.taYPdeUnf.Fill(Me.dsVersicherung.YPdeUnf)
        Me.taYPdeRue.Fill(Me.dsVersicherung.YPdeRue)
        Me.taYPdekau.Fill(Me.dsVersicherung.YPdekau)
        Me.taYPdehaf.Fill(Me.dsVersicherung.YPdehaf)

        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        GroupBox1.Location = New Point(12, 22)

    End Sub

    Private Sub RadioButtonHafBe_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonHafBe.CheckedChanged
        If RadioButtonHafBe.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxHaf.Location = New Point(12, 22)
            Dim rs As System.Data.DataRowView = bsYPdehaf.Current
            hafadapter.SelectCommand = New OleDb.OleDbCommand
            hafadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            hafadapter.SelectCommand.CommandText = "Select * from YPdehaf order by deckung"
            bsYPdehaf.CancelEdit()
            dsVersicherung.YPdehaf.Clear()
            hafadapter.Fill(dsVersicherung.YPdehaf)
            For i = 0 To 2
                bsYPdehaf.Position = i
                Select Case i
                    Case 0
                        TextBox18.Text = TextBox72.Text
                        TextBox36.Text = TextBox73.Text
                        TextBox39.Text = TextBox74.Text
                        TextBox40.Text = TextBox79.Text
                    Case 1
                        TextBox17.Text = TextBox72.Text
                        TextBox35.Text = TextBox73.Text
                        TextBox38.Text = TextBox74.Text
                    Case 2
                        TextBox16.Text = TextBox72.Text
                        TextBox19.Text = TextBox73.Text
                        TextBox37.Text = TextBox74.Text
                End Select
            Next
        End If
    End Sub
    Private Sub ButtonHAFSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHAFSpeichern.Click
        For i = 0 To 2
            bsYPdehaf.Position = i
            Select Case i
                Case 0
                    TextBox72.Text = TextBox18.Text
                    TextBox73.Text = TextBox36.Text
                    TextBox74.Text = TextBox39.Text
                    TextBox79.Text = TextBox40.Text
                Case 1
                    TextBox72.Text = TextBox17.Text
                    TextBox73.Text = TextBox35.Text
                    TextBox74.Text = TextBox38.Text
                Case 2
                    TextBox72.Text = TextBox16.Text
                    TextBox73.Text = TextBox19.Text
                    TextBox74.Text = TextBox37.Text
            End Select
            bsYPdehaf.EndEdit()
            taYPdehaf.Update(dsVersicherung.YPdehaf)
        Next
        GroupBoxHaf.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(12, 22)
    End Sub

    Private Sub RadioButtonUnf_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonUnf.CheckedChanged
        If RadioButtonUnf.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxUnf.Location = New Point(12, 22)
            Dim rsunf As System.Data.DataRowView = bsYPdeUnf.Current
            unfadapter.SelectCommand = New OleDb.OleDbCommand
            unfadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            unfadapter.SelectCommand.CommandText = "Select * from YPdeUnf order by invalid"
            bsYPdeUnf.CancelEdit()
            dsVersicherung.YPdeUnf.Clear()
            unfadapter.Fill(dsVersicherung.YPdeUnf)
            For i = 0 To 4
                bsYPdeUnf.Position = i
                Select Case i
                    Case 0
                        mile(TextBox20.Text, TextBox71.Text)
                        mile(TextBox21.Text, TextBox70.Text)
                        mile(TextBox22.Text, TextBox69.Text)
                        TextBox15.Text = TextBox68.Text
                    Case 1
                        mile(TextBox23.Text, TextBox71.Text)
                        mile(TextBox24.Text, TextBox70.Text)
                        mile(TextBox25.Text, TextBox69.Text)
                        TextBox14.Text = TextBox68.Text
                    Case 2
                        mile(TextBox26.Text, TextBox71.Text)
                        mile(TextBox27.Text, TextBox70.Text)
                        mile(TextBox28.Text, TextBox69.Text)
                        TextBox13.Text = TextBox68.Text
                    Case 3
                        mile(TextBox29.Text, TextBox71.Text)
                        mile(TextBox30.Text, TextBox70.Text)
                        mile(TextBox31.Text, TextBox69.Text)
                        TextBox12.Text = TextBox68.Text
                    Case 4
                        mile(TextBox32.Text, TextBox71.Text)
                        mile(TextBox33.Text, TextBox70.Text)
                        mile(TextBox34.Text, TextBox69.Text)
                        TextBox11.Text = TextBox68.Text
                End Select
            Next
        End If

    End Sub
    Private Sub mile(ByRef ausgabe, ByVal eingabe)
        Dim anzahl As Single
        anzahl = eingabe
        ausgabe = anzahl.ToString("##,#0")
    End Sub
    Private Sub ButtonUnfSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUnfSpeichern.Click
        For i = 0 To 4
            bsYPdeUnf.Position = i
            Select Case i
                Case 0
                    TextBox71.Text = TextBox20.Text
                    TextBox70.Text = TextBox21.Text
                    TextBox69.Text = TextBox22.Text
                    TextBox68.Text = TextBox15.Text
                Case 1
                    TextBox71.Text = TextBox23.Text
                    TextBox70.Text = TextBox24.Text
                    TextBox69.Text = TextBox25.Text
                    TextBox68.Text = TextBox14.Text
                Case 2
                    TextBox71.Text = TextBox26.Text
                    TextBox70.Text = TextBox27.Text
                    TextBox69.Text = TextBox28.Text
                    TextBox68.Text = TextBox13.Text
                Case 3
                    TextBox71.Text = TextBox29.Text
                    TextBox70.Text = TextBox30.Text
                    TextBox69.Text = TextBox31.Text
                    TextBox68.Text = TextBox12.Text
                Case 4
                    TextBox71.Text = TextBox32.Text
                    TextBox70.Text = TextBox33.Text
                    TextBox69.Text = TextBox34.Text
                    TextBox68.Text = TextBox11.Text
            End Select
            bsYPdeUnf.EndEdit()
            taYPdeunf.Update(dsVersicherung.YPdeUnf)
        Next
        GroupBoxUnf.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(12, 22)

    End Sub

    Private Sub RadioButtonRech_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRech.CheckedChanged
        If RadioButtonRech.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxRech.Location = New Point(12, 22)
            Dim rsrec As System.Data.DataRowView = bsYPderech.Current
            Recadapter.SelectCommand = New OleDb.OleDbCommand
            Recadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            Recadapter.SelectCommand.CommandText = "Select * from YPderech"
            bsYPderech.CancelEdit()
            dsVersicherung.YPderech.Clear()
            Recadapter.Fill(dsVersicherung.YPderech)
            mile(TextBox41.Text, TextBox41.Text)
        End If
    End Sub
    Private Sub ButtonrechSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonrechSpeichern.Click
        bsYPderech.EndEdit()
        taYPderech.Update(dsVersicherung.YPderech)
        GroupBoxRech.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(12, 22)
    End Sub

    Private Sub RadioButtonRue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRue.CheckedChanged
        If RadioButtonRue.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxRue.Location = New Point(12, 22)
            Dim rsRue As System.Data.DataRowView = bsYPdeRue.Current
            RueAdapter.SelectCommand = New OleDb.OleDbCommand
            RueAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            RueAdapter.SelectCommand.CommandText = "Select * from YPdeRue order by Toernname"
            bsYPdeRue.CancelEdit()
            dsVersicherung.YPdeRue.Clear()
            RueAdapter.Fill(dsVersicherung.YPdeRue)
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        bsYPdeRue.EndEdit()
        taYPdeRue.Update(dsVersicherung.YPdeRue)
          GroupBoxRue.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(12, 22)
    End Sub

    Private Sub RadioButtonKau_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonKau.CheckedChanged
        If RadioButtonKau.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            groupboxkau.Location = New Point(12, 22)
            Dim rskau As System.Data.DataRowView = bsYPdekau.Current
            KauAdapter.SelectCommand = New OleDb.OleDbCommand
            KauAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            KauAdapter.SelectCommand.CommandText = "Select * from YPdekau order by kaution"
            bsYPdekau.CancelEdit()
            dsVersicherung.YPdekau.Clear()
            KauAdapter.Fill(dsVersicherung.YPdekau)
            For i = 0 To 10
                bsYPdekau.Position = i
                Select Case i
                    Case 0
                        TextBox43.Text = TextBox66.Text
                        TextBox65.Text = TextBox67.Text
                    Case 1
                        TextBox44.Text = TextBox66.Text
                        TextBox64.Text = TextBox67.Text
                    Case 2
                        TextBox45.Text = TextBox66.Text
                        TextBox62.Text = TextBox67.Text
                    Case 3
                        TextBox46.Text = TextBox66.Text
                        TextBox61.Text = TextBox67.Text
                    Case 4
                        TextBox47.Text = TextBox66.Text
                        TextBox60.Text = TextBox67.Text
                    Case 5
                        TextBox48.Text = TextBox66.Text
                        TextBox59.Text = TextBox67.Text
                    Case 6
                        TextBox75.Text = TextBox66.Text
                        TextBox53.Text = TextBox67.Text
                    Case 7
                        TextBox76.Text = TextBox66.Text
                        TextBox51.Text = TextBox67.Text
                    Case 8
                        TextBox77.Text = TextBox66.Text
                        TextBox50.Text = TextBox67.Text
                    Case 9
                        TextBox78.Text = TextBox66.Text
                        TextBox42.Text = TextBox67.Text
                    Case 10
                        mile(TextBox49.Text, TextBox66.Text)
                        TextBox52.Text = TextBox67.Text
                End Select
            Next
        End If
    End Sub
    Private Sub ButtonKautionSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonKautionSpeichern.Click
        For i = 0 To 10
            bsYPdekau.Position = i
            Select Case i
                Case 0
                    TextBox66.Text = TextBox43.Text
                    TextBox67.Text = TextBox65.Text
                Case 1
                    TextBox66.Text = TextBox44.Text
                    TextBox67.Text = TextBox64.Text
                Case 2
                    TextBox66.Text = TextBox45.Text
                    TextBox67.Text = TextBox62.Text
                Case 3
                    TextBox66.Text = TextBox46.Text
                    TextBox67.Text = TextBox61.Text
                Case 4
                    TextBox66.Text = TextBox47.Text
                    TextBox67.Text = TextBox60.Text
                Case 5
                    TextBox66.Text = (TextBox48.Text)
                    TextBox67.Text = TextBox59.Text
                Case 6
                    TextBox66.Text = TextBox75.Text
                    TextBox67.Text = TextBox53.Text
                Case 7
                    TextBox66.Text = TextBox76.Text
                    TextBox67.Text = TextBox51.Text
                Case 8
                    TextBox66.Text = TextBox77.Text
                    TextBox67.Text = TextBox50.Text
                Case 9
                    TextBox66.Text = TextBox78.Text
                    TextBox67.Text = TextBox42.Text
                Case 10
                    TextBox66.Text = TextBox49.Text
                    TextBox67.Text = TextBox52.Text
            End Select
            bsYPdekau.EndEdit()
            taYPdekau.Update(dsVersicherung.YPdekau)
        Next
        groupboxkau.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(12, 22)
    End Sub

    Private Sub RadioButtonFol_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonFol.CheckedChanged
        If RadioButtonFol.Checked Then
            GroupBox1.Location = New Point(2000, 2000)
            GroupBoxFol.Location = New Point(12, 22)
            Dim rsFol As System.Data.DataRowView = bsYPdefol.Current
            FolAdapter.SelectCommand = New OleDb.OleDbCommand
            FolAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
            FolAdapter.SelectCommand.CommandText = "Select * from YPdeFol order by Laenge"
            bsYPdefol.CancelEdit()
            dsVersicherung.YPdefol.Clear()
            FolAdapter.Fill(dsVersicherung.YPdefol)
            For i = 0 To 10
                If i < 5 Then
                    bsYPdefol.Position = i
                Else
                    bsYPdefol.Position = i - 5
                End If
                Select Case i
                    Case 0
                        TextBox54.Text = TextBox80.Text
                        TextBox5.Text = TextBox81.Text
                        TextBox10.Text = TextBox82.Text
                    Case 1
                        TextBox55.Text = TextBox80.Text
                        TextBox4.Text = TextBox81.Text
                        TextBox9.Text = TextBox82.Text
                    Case 2
                        TextBox56.Text = TextBox80.Text
                        TextBox3.Text = TextBox81.Text
                        TextBox8.Text = TextBox82.Text
                    Case 3
                        TextBox57.Text = TextBox80.Text
                        TextBox2.Text = TextBox81.Text
                        TextBox7.Text = TextBox82.Text
                    Case 4
                        TextBox58.Text = TextBox80.Text
                        TextBox1.Text = TextBox81.Text
                        TextBox6.Text = TextBox82.Text
                End Select
            Next
        End If
    End Sub

    Private Sub ButtonFoSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFoSpeichern.Click
        For i = 0 To 10
            If i < 5 Then
                bsYPdefol.Position = i
            Else
                bsYPdefol.Position = i - 5
            End If
            Select Case i
                Case 0
                    TextBox80.Text = TextBox54.Text
                    TextBox81.Text = TextBox5.Text
                    TextBox82.Text = TextBox10.Text
                Case 1
                    TextBox80.Text = TextBox55.Text
                    TextBox81.Text = (TextBox4.Text)
                    TextBox82.Text = TextBox9.Text
                Case 2
                    TextBox80.Text = TextBox56.Text
                    TextBox81.Text = TextBox3.Text
                    TextBox82.Text = TextBox8.Text
                Case 3
                    TextBox80.Text = TextBox57.Text
                    TextBox81.Text = TextBox2.Text
                    TextBox82.Text = TextBox7.Text
                Case 4
                    TextBox80.Text = TextBox58.Text
                    TextBox81.Text = TextBox1.Text
                    TextBox82.Text = TextBox6.Text
            End Select
            bsYPdefol.EndEdit()
            taYPdefol.Update(dsVersicherung.YPdefol)
        Next
        GroupBoxFol.Location = New Point(2000, 2000)
        GroupBox1.Location = New Point(12, 22)
    End Sub
End Class