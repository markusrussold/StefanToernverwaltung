Public Class Ablauf
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Public iii As Integer
    Public aaa As String
    Public ij As Integer
    Dim buch1 As String
    Dim position As Integer
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim lAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim iAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Private Sub Ablauf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.Ablauf". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taAblauf.Fill(Me.dsCrewbesprechung.Ablauf)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False
        Dim ri As System.Data.DataRowView = bsTC.Current
        iAdapter.SelectCommand = New OleDb.OleDbCommand
        iAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        iAdapter.SelectCommand.CommandText = "Select * from ablauf"
        bsAblauf.CancelEdit()
        dsCrewbesprechung.Ablauf.Clear()
        iAdapter.Fill(dsCrewbesprechung.Ablauf)
        bsAblauf.AddNew()
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        MaskedTextBox1.Mask = "00.00.0000"
        GroupBoxBesprechung.Location = New Point(1700, 107)
        GroupBox1Törn.Location = New Point(1700, 107)
        ButtonSpeichern.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        GroupBox1Törn.Location = New Point(17, 107)
        Dim r As System.Data.DataRowView = bsToernname.Current
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
                DbAccess.SafePosition(bsToernname)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                CheckBox1.Text = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString
                GroupBoxBesprechung.Location = New Point(17, 107)
                GroupBox1Törn.Location = New Point(1700, 107)
                TextBox1.Text = TextBox6.Text
                aaa = TextBox1.Text
                ButtonSpeichern.Visible = True
                infos()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
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
    Private Sub Crew()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & aaa & "' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        For ij = 0 To bsTC.Count - 1
            Select Case ij
                Case 0
                    CheckBox2.Visible = True
                    CheckBox2.Text = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
                Case 1
                    CheckBox3.Visible = True
                    CheckBox3.Text = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
                Case 2
                    CheckBox4.Visible = True
                    CheckBox4.Text = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
                Case 3
                    CheckBox5.Visible = True
                    CheckBox5.Text = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
                Case 4
                    CheckBox6.Visible = True
                    CheckBox6.Text = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
                Case 5
                    CheckBox7.Visible = True
                    CheckBox7.Text = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
                Case 6
                    CheckBox8.Visible = True
                    CheckBox8.Text = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
           End Select
        Next
    End Sub
     Private Sub infos()
        Dim ri As System.Data.DataRowView = bsAblauf.Current
        iAdapter.SelectCommand = New OleDb.OleDbCommand
        iAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        iAdapter.SelectCommand.CommandText = "Select * from ablauf where toernname = '" & aaa & "'"
        bsAblauf.CancelEdit()
        dsCrewbesprechung.Ablauf.Clear()
        iAdapter.Fill(dsCrewbesprechung.Ablauf)
        Crew()
        If bsAblauf.Count = 0 Then
            bsAblauf.AddNew()
            TextBox1.Text = aaa
        Else
            For ij = 0 To bsAblauf.Count - 1
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender1").ToString = CheckBox1.Text Then
                    CheckBox1.Checked = True
                End If
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender2").ToString = CheckBox2.Text Then
                    CheckBox2.Checked = True
                End If
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender3").ToString = CheckBox3.Text Then
                    CheckBox3.Checked = True
                End If
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender4").ToString = CheckBox4.Text Then
                    CheckBox4.Checked = True
                End If
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender5").ToString = CheckBox5.Text Then
                    CheckBox5.Checked = True
                End If
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender6").ToString = CheckBox6.Text Then
                    CheckBox6.Checked = True
                End If
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender7").ToString = CheckBox7.Text Then
                    CheckBox7.Checked = True
                End If
                If dsCrewbesprechung.Ablauf.Rows(ij)("Anwesender8").ToString = CheckBox8.Text Then
                    CheckBox8.Checked = True
                End If
            Next
        End If
    End Sub

    Private Sub ButtonSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichern.Click
        If CheckBox1.Checked Then
            TextBox7.Text = CheckBox1.Text
        Else
            TextBox7.Text = ""
        End If
        If CheckBox2.Checked Then
            TextBox8.Text = CheckBox2.Text
        Else
            TextBox8.Text = ""
        End If
        If CheckBox3.Checked Then
            TextBox9.Text = CheckBox3.Text
        Else
            TextBox9.Text = ""
        End If
        If CheckBox4.Checked Then
            TextBox10.Text = CheckBox4.Text
        Else
            TextBox10.Text = ""
        End If
        If CheckBox5.Checked Then
            TextBox11.Text = CheckBox5.Text
        Else
            TextBox11.Text = ""
        End If
        If CheckBox6.Checked Then
            TextBox12.Text = CheckBox6.Text
        Else
            TextBox12.Text = ""
        End If
        If CheckBox7.Checked Then
            TextBox13.Text = CheckBox7.Text
        Else
            TextBox13.Text = ""
        End If
        If CheckBox8.Checked Then
            TextBox14.Text = CheckBox8.Text
        Else
            TextBox14.Text = ""
        End If
        SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
        bsAblauf.EndEdit()
        taAblauf.Update(dsCrewbesprechung.Ablauf)

        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        TextBox1.Text = TextBox6.Text
        suchen()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        GroupBox3.Location = New Point(100, 200)
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        GroupBox3.Location = New Point(10000, 100)
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
    End Sub
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        GroupBox3.Location = New Point(10000, 100)
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
    End Sub

    Private Sub BtBearbeiten_Click(sender As System.Object, e As System.EventArgs) Handles BtBearbeiten.Click
        suchen()
    End Sub
End Class