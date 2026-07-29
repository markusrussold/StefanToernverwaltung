Public Class Wacheplan
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Dim aenderung As Boolean
    Dim buch1 As String
    Dim position As Integer
    Dim idnr As Integer
    Dim IDcheck As Boolean
    Dim aaa As String
    Dim iii As Integer
    Dim WAnf As String
    Dim WEnde As String
    Dim mausKlick As Boolean = False
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim wAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Private nIndex As Long
    Dim ij As Integer
    Public WacheAnzahl As Integer

    Private Sub Wacheplan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taWacheplan.Fill(Me.dsToernverwaltung.Wacheplan)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        bsToernname.AddNew()
        MaskedTextBox1.Mask = "00.00.0000"
        MaskedTextBox2.Mask = "00.00.0000"
        ComboBox1.Items.Add("2 Std. Schicht")
        ComboBox1.Items.Add("3 Std. Schicht")
        ComboBox1.Items.Add("4 Std. Schicht")
        ComboBox1.Items.Add("3 Nacht/4 Tag Std. Schicht")
        Label15.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        ButtonSpeichern.Enabled = False
        GroupBox3.Enabled = False
        '                                                  prüfen auf Navigator solo
        wAdapter.SelectCommand = New OleDb.OleDbCommand
        wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        wAdapter.SelectCommand.CommandText = "Select * from wacheplan "
        bsToernname.CancelEdit()
        dsToernverwaltung.Wacheplan.Clear()
        wAdapter.Fill(dsToernverwaltung.Wacheplan)
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        Try
            aaa = dsToernverwaltung.Wacheplan.Rows(0)("Person3").ToString

        Catch ex As Exception
            CheckBox4.Visible = False
        End Try
        GroupBox2.Enabled = False
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
        GroupBox1.Enabled = False
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
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                Formularloeschen()
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                Dim d1 As Date = dsToernverwaltung.Toernname.Rows(0)("Datumvon").ToString
                Dim d2 As Date = dsToernverwaltung.Toernname.Rows(0)("DAtumbis").ToString
                Dim diff As TimeSpan = d2 - d1
                If diff.Days < 0 Then
                    MsgBox("--Datum bis--  liegt vor dem --Datum von--. Korrigiere den Törn in der Törnverwaltung!")
                    GoTo endeSpeichern
                End If
                GroupBox2.Enabled = True
                ListBox1.Items.Clear()
                ListBox1.Items.Add(dsToernverwaltung.Toernname.Rows(0)("skipper").ToString)
                CrewlisteAnzeigen()
                GroupBox1.Enabled = True
                GroupBox3.Visible = True
                DataGridView1.Visible = False
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                WacheSuchen()
                WacheErweitern()
            Case Else
                position = 0
                GroupBox3.Visible = False
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(18, 275)
endespeichern:
        End Select
    End Sub
    Private Sub WacheSuchen()
        Dim sch1 As String
        Dim sch2 As String
        wAdapter.SelectCommand = New OleDb.OleDbCommand
        wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        wAdapter.SelectCommand.CommandText = "Select * from wacheplan where toern like '%" & TextBox1.Text & "%' order by datum1"
        bsToernname.CancelEdit()
        dsToernverwaltung.Wacheplan.Clear()
        wAdapter.Fill(dsToernverwaltung.Wacheplan)
        WacheAnzahl = 0
        If bsWacheplan.Count > 0 Then
            MaskedTextBox1.Text = dsToernverwaltung.Wacheplan.Rows(0)("datum1").ToString
            MaskedTextBox2.Text = dsToernverwaltung.Wacheplan.Rows(bsWacheplan.Count - 1)("datum1").ToString
            MaskedTextBox2.Text = DateAdd("d", 1, MaskedTextBox2.Text)
            ComboBox1.Text = dsToernverwaltung.Wacheplan.Rows(0)("methode").ToString
            If Len(dsToernverwaltung.Wacheplan.Rows(0)("person3").ToString) > 0 Then
                CheckBox4.Checked = True
            End If
            aenderung = True
            sch1 = dsToernverwaltung.Wacheplan.Rows(0)("person1").ToString + dsToernverwaltung.Wacheplan.Rows(0)("person2").ToString
            If CheckBox4.Checked = True Then                                               '1. Reihe
                sch1 += dsToernverwaltung.Wacheplan.Rows(0)("person3").ToString
                TextBox25.Text = dsToernverwaltung.Wacheplan.Rows(0)("person1").ToString
                TextBox24.Text = dsToernverwaltung.Wacheplan.Rows(0)("person2").ToString
                TextBox29.Text = dsToernverwaltung.Wacheplan.Rows(0)("person3").ToString
            Else
                TextBox2.Text = dsToernverwaltung.Wacheplan.Rows(0)("person1").ToString
                TextBox3.Text = dsToernverwaltung.Wacheplan.Rows(0)("person2").ToString
            End If

            If Len(dsToernverwaltung.Wacheplan.Rows(1)("person1").ToString) > 0 Then
                sch2 = dsToernverwaltung.Wacheplan.Rows(1)("person1").ToString + dsToernverwaltung.Wacheplan.Rows(1)("person2").ToString
                If CheckBox4.Checked = True Then sch2 += dsToernverwaltung.Wacheplan.Rows(1)("person3").ToString
                If sch1 <> sch2 Then
                    If CheckBox4.Checked = True Then                                      ' 2.Reihe
                        TextBox23.Text = dsToernverwaltung.Wacheplan.Rows(1)("person1").ToString
                        TextBox22.Text = dsToernverwaltung.Wacheplan.Rows(1)("person2").ToString
                        TextBox28.Text = dsToernverwaltung.Wacheplan.Rows(1)("person3").ToString
                    Else
                        TextBox5.Text = dsToernverwaltung.Wacheplan.Rows(1)("person1").ToString
                        TextBox4.Text = dsToernverwaltung.Wacheplan.Rows(1)("person2").ToString
                    End If
                End If
            End If
 
            If Len(dsToernverwaltung.Wacheplan.Rows(2)("person1").ToString) > 0 Then
                sch2 = dsToernverwaltung.Wacheplan.Rows(2)("person1").ToString + dsToernverwaltung.Wacheplan.Rows(2)("person2").ToString
                If CheckBox4.Checked = True Then sch2 += dsToernverwaltung.Wacheplan.Rows(2)("person3").ToString
                If sch1 <> sch2 Then
                    If CheckBox4.Checked = True Then                                      ' 3.Reihe
                        TextBox21.Text = dsToernverwaltung.Wacheplan.Rows(2)("person1").ToString
                        TextBox19.Text = dsToernverwaltung.Wacheplan.Rows(2)("person2").ToString
                        TextBox27.Text = dsToernverwaltung.Wacheplan.Rows(2)("person3").ToString
                    Else
                        TextBox7.Text = dsToernverwaltung.Wacheplan.Rows(2)("person1").ToString
                        TextBox6.Text = dsToernverwaltung.Wacheplan.Rows(2)("person2").ToString
                    End If
                End If
            End If

            If Len(dsToernverwaltung.Wacheplan.Rows(3)("person1").ToString) > 0 Then
                sch2 = dsToernverwaltung.Wacheplan.Rows(3)("person1").ToString + dsToernverwaltung.Wacheplan.Rows(3)("person2").ToString
                If CheckBox4.Checked = True Then sch2 += dsToernverwaltung.Wacheplan.Rows(3)("person3").ToString
                If sch1 <> sch2 Then
                    If CheckBox4.Checked = True Then                                      ' 4.Reihe
                        TextBox18.Text = dsToernverwaltung.Wacheplan.Rows(3)("person1").ToString
                        TextBox17.Text = dsToernverwaltung.Wacheplan.Rows(3)("person2").ToString
                        TextBox26.Text = dsToernverwaltung.Wacheplan.Rows(3)("person3").ToString
                    Else
                        TextBox9.Text = dsToernverwaltung.Wacheplan.Rows(3)("person1").ToString
                        TextBox8.Text = dsToernverwaltung.Wacheplan.Rows(3)("person2").ToString
                    End If
                End If
            End If

        Else
            MaskedTextBox1.Text = Label16.Text
            MaskedTextBox2.Text = Label17.Text
            aenderung = False
        End If
    End Sub
    Private Sub WacheErweitern()
        Dim d1 As Date = MaskedTextBox1.Text
        Dim d2 As Date = MaskedTextBox2.Text
         Dim faktor As Single
        Dim msg As MsgBoxResult
        wAdapter.SelectCommand = New OleDb.OleDbCommand
        wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        wAdapter.SelectCommand.CommandText = "Select * from wacheplan where toern like '%" & TextBox1.Text & "%' order by datum1 "
        bsToernname.CancelEdit()
        dsToernverwaltung.Wacheplan.Clear()
        wAdapter.Fill(dsToernverwaltung.Wacheplan)
        If bsWacheplan.Count > 0 Then
            msg = MsgBox("Wachenplan von " & MaskedTextBox1.Text & " bis " & MaskedTextBox2.Text & " ist bereits gespeichert, neu erstellen? ", 3)
            If msg = vbYes Then
                Me.Cursor = Cursors.WaitCursor
                For i = bsWacheplan.Count - 1 To 0 Step -1
                    faktor = Date.Compare(dsToernverwaltung.Wacheplan.Rows(i)("datum1").ToString, d1)
                    If faktor = 1 Then
                        bsWacheplan.RemoveCurrent()
                        taWacheplan.Update(dsToernverwaltung)
                    End If
                Next
                Me.Cursor = Cursors.Default
                MaskedTextBox1.Text = Label16.Text
                MaskedTextBox2.Text = Label17.Text
                aenderung = False
            Else
                ButtonDrucken.Enabled = True
                '                  ist die ganze Törnzeit schon eingeteilt?
                If MaskedTextBox1.Text = Label16.Text And MaskedTextBox2.Text = Label17.Text Then
                    MsgBox("Die ganze Törnzeit ist durch den Wacheplan abgedeckt.")
                    ButtonSpeichern.Enabled = False
                End If
                WAnf = MaskedTextBox1.Text
                WEnde = MaskedTextBox2.Text
                MaskedTextBox1.Text = MaskedTextBox2.Text
                MaskedTextBox2.Text = Label17.Text
                MaskedTextBox2.Focus()
            End If
        End If

    End Sub
    Private Sub Formularloeschen()
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        MaskedTextBox1.Text = " "
        MaskedTextBox2.Text = " "
        Label15.Text = ""
        ButtonDrucken.Enabled = False
        ButtonSpeichern.Enabled = True
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
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' order by vzname"
        'tAdapter.SelectCommand.CommandText = "Select * from TC"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        aaa = TextBox1.Text
        ij = bsTC.Count
        For Me.iii = 0 To ij - 1
            ListBox1.Items.Add(dsToernverwaltung.TC.Rows(Me.iii)("vzname").ToString)
        Next
    End Sub

    Private Sub Listbox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown
         ' Index des Eintrags "merken"
        nIndex = Listbox1.SelectedIndex
    End Sub
    Private Sub Listbox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseMove
        Dim sTemp As String
        ' Button gedrückt und Eintrag ausgewählt?
        If e.Button > 0 And nIndex > -1 Then
            With ListBox1
                If nIndex <> .SelectedIndex Then
                    sTemp = .Items(nIndex)                 ' vorhergehenden Eintrag zwischenspeichern
                    .Items(nIndex) = .Items(.SelectedIndex)                  ' vorhergehenden Eintrag durch aktuellen Eintrag ersetzen
                    .Items(.SelectedIndex) = sTemp                     ' aktuellen Eintrag durch vorgehenden  ' Eintrag ersetzen
                    nIndex = .SelectedIndex                     ' Index des aktuellen Eintrags "merken"
                End If
            End With
        End If
    End Sub
    Private Sub Listbox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseUp
        Dim x, y As Integer
        Dim yzusatz As Integer = 381
        Dim xzusatz As Integer = 334
        x = Cursor.Position.X - Me.Location.X
        y = Cursor.Position.Y - Me.Location.Y
        Dim x2, y2, boxl As Integer

        If CheckBox4.Checked = False Then
            '                140;22          Size von Textbox2 - 9
            x2 = TextBox2.Location.X + xzusatz
            y2 = TextBox2.Location.Y + yzusatz
            boxl = TextBox2.Size.Width + 10
            Dim x3, y3 As Integer
            x3 = TextBox3.Location.X + xzusatz
            y3 = TextBox3.Location.Y + yzusatz
            Dim x4, y4 As Integer
            x4 = TextBox4.Location.X + xzusatz
            y4 = TextBox4.Location.Y + yzusatz
            Dim x5, y5 As Integer
            x5 = TextBox5.Location.X + xzusatz
            y5 = TextBox5.Location.Y + yzusatz
            Dim x6, y6 As Integer
            x6 = TextBox6.Location.X + xzusatz
            y6 = TextBox6.Location.Y + yzusatz
            '        boxl = TextBox2.Size.Width
            Dim x7, y7 As Integer
            x7 = TextBox7.Location.X + xzusatz
            y7 = TextBox7.Location.Y + yzusatz
            Dim x8, y8 As Integer
            x8 = TextBox8.Location.X + xzusatz
            y8 = TextBox8.Location.Y + yzusatz
            Dim x9, y9 As Integer
            x9 = TextBox9.Location.X + xzusatz
            y9 = TextBox9.Location.Y + yzusatz

            If y > y2 And y < y2 + 25 Then
                If x > x2 And x < x2 + boxl Then                                  '    If x > 110 And x < 250 Then
                    schicht(TextBox32.Text, TextBox2.Text)
                End If
                If x > x3 And x < x3 + 140 Then                                  '    If x > 260 And x < 405 Then
                    schicht(TextBox33.Text, TextBox3.Text)
                End If
            End If
            If y > y5 And y < y5 + 22 Then
                If x > x5 And x < x5 + boxl Then
                    schicht(TextBox35.Text, TextBox5.Text)
                End If
                If x > x4 And x < x4 + 140 Then
                    schicht(TextBox34.Text, TextBox4.Text)
                End If
            End If
            If y > y7 And y < y7 + 22 Then
                If x > x7 And x < x7 + boxl Then
                    schicht(TextBox37.Text, TextBox7.Text)
                End If
                If x > x6 And x < x6 + 140 Then
                    schicht(TextBox36.Text, TextBox6.Text)
                End If
            End If
            If y > y9 And y < y9 + 22 Then
                If x > x9 And x < x9 + boxl Then
                    schicht(TextBox39.Text, TextBox9.Text)
                End If
                If x > x8 And x < x8 + 140 Then
                    schicht(TextBox38.Text, TextBox8.Text)
                End If
            End If
        Else
            Dim x25, y25, x24, y24, x29, y29 As Integer
            boxl = TextBox25.Size.Width + 10
            '                110;22          Size von Textbox25 
            x25 = TextBox25.Location.X + xzusatz
            y25 = TextBox25.Location.Y + yzusatz
            x24 = TextBox24.Location.X + xzusatz
            y24 = TextBox24.Location.Y + yzusatz
            x29 = TextBox29.Location.X + xzusatz
            y29 = TextBox29.Location.Y + yzusatz
            If y > y25 And y < y25 + 25 Then
                If x > x25 And x < x25 + boxl Then
                    schicht(TextBox32.Text, TextBox25.Text)
                End If
                If x > x24 And x < x24 + 130 Then
                    schicht(TextBox33.Text, TextBox24.Text)
                End If
                If x > x29 And x < x29 + 130 Then
                    schicht(TextBox41.Text, TextBox29.Text)
                End If
            End If
            '                                                         2.Zeile
            Dim x23, y23, x22, y22, x28, y28 As Integer
            x23 = TextBox23.Location.X + xzusatz
            y23 = TextBox23.Location.Y + yzusatz
            x22 = TextBox22.Location.X + xzusatz
            y22 = TextBox22.Location.Y + yzusatz
            x28 = TextBox28.Location.X + xzusatz
            y28 = TextBox28.Location.Y + yzusatz
            If y > y23 And y < y23 + 25 Then
                If x > x23 And x < x23 + boxl Then
                    schicht(TextBox35.Text, TextBox23.Text)
                End If
                If x > x22 And x < x22 + 130 Then
                    schicht(TextBox34.Text, TextBox22.Text)
                End If
                If x > x28 And x < x28 + 130 Then
                    schicht(TextBox40.Text, TextBox28.Text)
                End If
            End If
            '                                                           3. Zeile
            Dim x21, y21, x19, y19, x27, y27 As Integer
            x21 = TextBox21.Location.X + xzusatz
            y21 = TextBox21.Location.Y + yzusatz
            x19 = TextBox19.Location.X + xzusatz
            y19 = TextBox19.Location.Y + yzusatz
            x27 = TextBox27.Location.X + xzusatz
            y27 = TextBox27.Location.Y + yzusatz
            If y > y21 And y < y21 + 25 Then
                If x > x21 And x < x21 + boxl Then
                    schicht(TextBox37.Text, TextBox21.Text)
                End If
                If x > x19 And x < x19 + 130 Then
                    schicht(TextBox36.Text, TextBox19.Text)
                End If
                If x > x27 And x < x27 + 130 Then
                    schicht(TextBox31.Text, TextBox27.Text)
                End If
            End If
            '                                                            4.Zeile
            Dim x18, y18, x17, y17, x26, y26 As Integer
            x18 = TextBox18.Location.X + xzusatz
            y18 = TextBox18.Location.Y + yzusatz
            x17 = TextBox17.Location.X + xzusatz
            y17 = TextBox17.Location.Y + yzusatz
            x26 = TextBox26.Location.X + xzusatz
            y26 = TextBox26.Location.Y + yzusatz
            If y > y18 And y < y18 + 25 Then
                If x > x18 And x < x18 + boxl Then
                    schicht(TextBox39.Text, TextBox18.Text)
                End If
                If x > x17 And x < x17 + 130 Then
                    schicht(TextBox38.Text, TextBox17.Text)
                End If
                If x > x26 And x < x26 + 130 Then
                    schicht(TextBox30.Text, TextBox26.Text)
                End If
            End If
        End If
        nIndex = -1
    End Sub
    Private Sub schicht(ByRef vzname, ByRef crewname)
        If Len(vzname) > 0 And CheckBox3.Checked = False Then
            ListBox1.Items.Add(vzname)
        End If
        vzname = ListBox1.Text
        crewname = ListBox1.Text
        If CheckBox3.Checked = False Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        aaa = TextBox1.Text
        suchen()
        DataGridView1.Visible = False
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        aaa = TextBox1.Text
        suchen()
        DataGridView1.Visible = False
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        aaa = TextBox1.Text
        suchen()
        DataGridView1.Visible = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Formularloeschen()
    End Sub

    Private Sub ButtonSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpeichern.Click
        Me.Cursor = Cursors.WaitCursor
        If aenderung Then
            wAdapter.SelectCommand = New OleDb.OleDbCommand
            wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            wAdapter.SelectCommand.CommandText = "Select * from wacheplan where toern like '%" & TextBox1.Text & "%' order by datum1 "
            bsToernname.CancelEdit()
            dsToernverwaltung.Wacheplan.Clear()
            wAdapter.Fill(dsToernverwaltung.Wacheplan)
            MaskedTextBox1.Text = DateAdd("d", -1, MaskedTextBox1.Text)
            '           bsWacheplan.RemoveAt(bsWacheplan.Count - 1)
            '            taWacheplan.Update(dsToernverwaltung)
        End If
        Dim d1 As Date = MaskedTextBox2.Text
        Dim d2 As Date = MaskedTextBox1.Text
        aaa = "2018 03 21 17 00 00"
        aaa = MaskedTextBox1.Text.Substring(6, 4) + " " + MaskedTextBox1.Text.Substring(3, 2) + " " + MaskedTextBox1.Text.Substring(0, 2) + " 17 00 00"
        Dim d3 = Date.ParseExact(aaa, "yyyy MM dd HH mm ss", Globalization.CultureInfo.InvariantCulture)
        Dim tage As TimeSpan = d1 - d2
        Dim stunden As Integer
        Dim diff As String = tage.ToString.Substring(0, Len(tage.ToString) - 9)
        Dim Schichten As Integer
        Dim ijj As Integer
        Dim st As Integer
        Dim mi As Integer
        If ComboBox1.Text = "" Then
            MsgBox("Es sind keine Wachestunden ausgewählt!")
            GoTo nix
        End If
        If TextBox3.Text = "" And TextBox4.Text = "" And TextBox6.Text = "" And TextBox8.Text = "" Then
            '          If ComboBox1.Text = "4 Std. Schicht" Or ComboBox1.Text = "3 Nacht/4 Tag Std. Schicht" Then
            If ComboBox1.Text = "4 Std. Schicht" Then
                MsgBox("Solowache ist nur für 2 oder 3 Std. verantwortbar. Auswahl wird auf 3 Std. gesetzt.")
                ComboBox1.Text = "3 Std. Schicht"
            End If
        Else
            If (TextBox3.Text > "" And TextBox2.Text = "") Or (TextBox3.Text = "" And TextBox2.Text > "") Then
                MsgBox("Solowache und Doppelwache gemischt ist nicht vorgesehen.")
                GoTo nix
            End If

            If (TextBox5.Text > "" And TextBox4.Text = "") Or (TextBox5.Text = "" And TextBox4.Text > "") Then
                MsgBox("Solowache und Doppelwache gemischt ist nicht vorgesehen.")
                GoTo nix
            End If

            If (TextBox7.Text > "" And TextBox6.Text = "") Or (TextBox7.Text = "" And TextBox6.Text > "") Then
                MsgBox("Solowache und Doppelwache gemischt ist nicht vorgesehen.")
                GoTo nix
            End If

            If (TextBox9.Text > "" And TextBox8.Text = "") Or (TextBox9.Text = "" And TextBox8.Text > "") Then
                MsgBox("Solowache und Doppelwache gemischt ist nicht vorgesehen.")
                GoTo nix
            End If
        End If
        stunden = 7 + (diff - 2) * 24 + 18
        Select Case ComboBox1.Text
            Case "2 Std. Schicht"
                Schichten = 2
            Case "3 Std. Schicht"
                Schichten = 3
            Case "4 Std. Schicht"
                Schichten = 4
            Case "3 Nacht/4 Tag Std. Schicht"
                Schichten = 4
        End Select
        If CheckBox1.Checked Then
        Else
            If Schichten < 5 Then
                st = 17 + Schichten / 2
                If Schichten = 3 Then
                    mi = 30
                Else
                    mi = 0
                End If
            End If
            aaa = MaskedTextBox1.Text.Substring(6, 4) + " " + MaskedTextBox1.Text.Substring(3, 2) + " " + MaskedTextBox1.Text.Substring(0, 2) + " " + null(Str(st)) + " " + null(Str(mi)) + " 00"
        End If
        Dim d4 = Date.ParseExact(aaa, "yyyy MM dd HH mm ss", Globalization.CultureInfo.InvariantCulture)

        wAdapter.SelectCommand = New OleDb.OleDbCommand
        wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        wAdapter.SelectCommand.CommandText = "Select * from wacheplan "
        bsWacheplan.CancelEdit()
        dsToernverwaltung.Wacheplan.Clear()
        wAdapter.Fill(dsToernverwaltung.Wacheplan)
        bsWacheplan.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        ijj = bsWacheplan.Count - 1
        Do While stunden > 0
            If CheckBox4.Checked = True Then                        ' Wachführer, Navigator und Rudergänger
                If Len(TextBox25.Text) > 0 Then
                    aenderung = False
                    If aenderung = False Then                          ' Schicht 1   25 24 29
                        bsWacheplan.AddNew()
                        TextBox14.Text = ComboBox1.Text                 '   Wachestunden
                        TextBox11.Text = TextBox1.Text
                        TextBox12.Text = TextBox25.Text
                        TextBox13.Text = TextBox24.Text
                        TextBox42.Text = TextBox29.Text
                        TextBox15.Text = TextBox32.Text
                        TextBox16.Text = TextBox33.Text
                        TextBox44.Text = TextBox41.Text
                        Schichtdauer(d3, d4, Schichten)
                        bsWacheplan.EndEdit()
                        taWacheplan.Update(dsToernverwaltung.Wacheplan)
                    Else
                        aenderung = False
                        TextBox14.Text = ComboBox1.Text
                        TextBox11.Text = TextBox1.Text
                        TextBox12.Text = ""
                        TextBox13.Text = ""
                        TextBox15.Text = ""
                        TextBox16.Text = ""
                        Schichtdauer(d3, d4, Schichten)
                    End If
                    stunden -= Schichten
                    If stunden <= 0 Then GoTo ende
                    If Len(TextBox23.Text) > 0 Then                ' Schicht 2    23 22 28
                        bsWacheplan.AddNew()
                        TextBox14.Text = ComboBox1.Text
                        TextBox11.Text = TextBox1.Text
                        TextBox12.Text = TextBox23.Text
                        TextBox13.Text = TextBox22.Text
                        TextBox42.Text = TextBox28.Text
                        TextBox15.Text = TextBox35.Text
                        TextBox16.Text = TextBox34.Text
                        TextBox44.Text = TextBox40.Text
                        Schichtdauer(d3, d4, Schichten)
                        bsWacheplan.EndEdit()
                        taWacheplan.Update(dsToernverwaltung.Wacheplan)
                        stunden -= Schichten
                        If stunden <= 0 Then GoTo ende
                        If Len(TextBox21.Text) > 0 Then                   ' Schicht 3   21 19 27
                            bsWacheplan.AddNew()
                            TextBox14.Text = ComboBox1.Text
                            TextBox11.Text = TextBox1.Text
                            TextBox12.Text = TextBox21.Text
                            TextBox13.Text = TextBox19.Text
                            TextBox42.Text = TextBox27.Text
                            TextBox15.Text = TextBox37.Text
                            TextBox16.Text = TextBox36.Text
                            TextBox44.Text = TextBox31.Text
                            Schichtdauer(d3, d4, Schichten)
                            bsWacheplan.EndEdit()
                            taWacheplan.Update(dsToernverwaltung.Wacheplan)
                            stunden -= Schichten
                            If stunden <= 0 Then GoTo ende
                            If Len(TextBox18.Text) > 0 Then                 ' Schucht 4   18 17 26
                                bsWacheplan.AddNew()
                                TextBox14.Text = ComboBox1.Text
                                TextBox11.Text = TextBox1.Text
                                TextBox12.Text = TextBox18.Text
                                TextBox13.Text = TextBox17.Text
                                TextBox42.Text = TextBox26.Text
                                TextBox44.Text = TextBox30.Text
                                TextBox15.Text = TextBox39.Text
                                TextBox16.Text = TextBox38.Text
                                Schichtdauer(d3, d4, Schichten)
                                bsWacheplan.EndEdit()
                                taWacheplan.Update(dsToernverwaltung.Wacheplan)
                                stunden -= Schichten
                            End If
                        End If
                    End If
                Else
                    MsgBox("Es sind keine Schichten zugeteilt.")
                    GoTo ende
                End If
            Else
                If Len(TextBox2.Text) > 0 Then                         ' Wachführer und Navigator in einer Person + Rudergänger
                    aenderung = False
                    If aenderung = False Then                          ' Schicht 1
                        bsWacheplan.AddNew()
                        TextBox14.Text = ComboBox1.Text
                        TextBox11.Text = TextBox1.Text
                        TextBox12.Text = TextBox2.Text
                        TextBox13.Text = TextBox3.Text
                        TextBox15.Text = TextBox32.Text
                        TextBox16.Text = TextBox33.Text
                        Schichtdauer(d3, d4, Schichten)
                        bsWacheplan.EndEdit()
                        taWacheplan.Update(dsToernverwaltung.Wacheplan)
                    Else
                        aenderung = False
                        TextBox14.Text = ComboBox1.Text
                        TextBox11.Text = TextBox1.Text
                        TextBox12.Text = ""
                        TextBox13.Text = ""
                        TextBox15.Text = ""
                        TextBox16.Text = ""
                        Schichtdauer(d3, d4, Schichten)
                    End If
                    stunden -= Schichten
                    If stunden <= 0 Then GoTo ende
                    If Len(TextBox5.Text) > 0 Then                ' Schicht 2
                        bsWacheplan.AddNew()
                        TextBox14.Text = ComboBox1.Text
                        TextBox11.Text = TextBox1.Text
                        TextBox12.Text = TextBox5.Text
                        TextBox13.Text = TextBox4.Text
                        TextBox15.Text = TextBox35.Text
                        TextBox16.Text = TextBox34.Text
                        Schichtdauer(d3, d4, Schichten)
                        bsWacheplan.EndEdit()
                        taWacheplan.Update(dsToernverwaltung.Wacheplan)
                        stunden -= Schichten
                        If stunden <= 0 Then GoTo ende
                        If Len(TextBox7.Text) > 0 Then                   ' Schicht 3
                            bsWacheplan.AddNew()
                            TextBox14.Text = ComboBox1.Text
                            TextBox11.Text = TextBox1.Text
                            TextBox12.Text = TextBox7.Text
                            TextBox13.Text = TextBox6.Text
                            TextBox15.Text = TextBox37.Text
                            TextBox16.Text = TextBox36.Text
                            Schichtdauer(d3, d4, Schichten)
                            bsWacheplan.EndEdit()
                            taWacheplan.Update(dsToernverwaltung.Wacheplan)
                            stunden -= Schichten
                            If stunden <= 0 Then GoTo ende
                            If Len(TextBox9.Text) > 0 Then                 ' Schucht 4
                                bsWacheplan.AddNew()
                                TextBox14.Text = ComboBox1.Text
                                TextBox11.Text = TextBox1.Text
                                TextBox12.Text = TextBox9.Text
                                TextBox13.Text = TextBox8.Text
                                TextBox15.Text = TextBox39.Text
                                TextBox16.Text = TextBox38.Text
                                Schichtdauer(d3, d4, Schichten)
                                bsWacheplan.EndEdit()
                                taWacheplan.Update(dsToernverwaltung.Wacheplan)
                                stunden -= Schichten
                            End If
                        End If
                    End If
                Else
                    MsgBox("Es sind keine Schichten zugeteilt.")
                    GoTo ende
                End If

            End If
        Loop
ende:
        Label15.Text = "Ist erstellt"
        Me.Cursor = Cursors.Default
        ButtonDrucken.Enabled = True
        aaa = MaskedTextBox2.Text.Replace(",", ".")
        If aaa < Label17.Text Then
            suchen()
        End If
nix:
    End Sub
 
    Private Sub Schichtdauer(ByRef d3, ByRef d4, ByRef schichten)
        Dim ja As Integer
        Dim mo As Integer
        Dim ta As Integer
        Dim st As Integer
        Dim mi As Integer

        TextBox10.Text = d3
        TextBox20.Text = d4
        CheckBox2.Checked = CheckBox1.Checked
        aaa = d3.ToString
        ja = aaa.Substring(6, 4)
        mo = aaa.Substring(3, 2)
        ta = aaa.Substring(0, 2)
        If ComboBox1.Text <> "3 Nacht/4 Tag Std. Schicht" Then
            st = aaa.Substring(11, 2) + schichten
        Else
            st = aaa.Substring(11, 2)
            If st > 6 And st < 20 Then
                st += 4
                schichten = 4
            Else
                st += 3
                schichten = 3
            End If
        End If
        If st >= 24 Then
            st = st - 24
            ta = ta + 1
            If ta = 29 And mo = 2 Then
                ta = 1
                mo += 1
            End If
            If ta = 31 And (mo = 4 Or mo = 6 Or mo = 9 Or mo = 11) Then
                ta = 1
                mo += 1
            End If
            If ta = 32 And mo = 12 Then
                ta = 1
                mo = 1
                ja += 1
            End If
            If ta = 32 Then
                ta = 1
                mo += 1
            End If
        End If
        mi = aaa.Substring(14, 2)
        aaa = LTrim(Str(ja)) + " " + null(Str(mo)) + " " + null(Str(ta)) + " " + null(Str(st)) + " " + null(Str(mi)) + " 00"
        d3 = Date.ParseExact(aaa, "yyyy MM dd HH mm ss", Globalization.CultureInfo.InvariantCulture)

        aaa = d4.ToString
        ja = aaa.Substring(6, 4)
        mo = aaa.Substring(3, 2)
        ta = aaa.Substring(0, 2)
        If ComboBox1.Text <> "3 Nacht/4 Tag Std. Schicht" Then
            st = aaa.Substring(11, 2) + schichten
        Else
            st = aaa.Substring(11, 2)
            If st > 6 And st < 20 Then
                st += 4
            Else
                st += 3
            End If
        End If
        mi = aaa.Substring(14, 2)
        If st >= 24 Or (st = 24 And mi = 30) Then
            st = st - 24
            ta = ta + 1
            If ta = 29 And mo = 2 Then
                ta = 1
                mo += 1
            End If
            If ta = 31 And (mo = 4 Or mo = 6 Or mo = 9 Or mo = 11) Then
                ta = 1
                mo += 1
            End If
            If ta = 32 And mo = 12 Then
                ta = 1
                mo = 1
                ja += 1
            End If
            If ta = 32 Then
                ta = 1
                mo += 1
            End If
        End If
        aaa = LTrim(Str(ja)) + " " + null(Str(mo)) + " " + null(Str(ta)) + " " + null(Str(st)) + " " + null(Str(mi)) + " 00"
        d4 = Date.ParseExact(aaa, "yyyy MM dd HH mm ss", Globalization.CultureInfo.InvariantCulture)
    End Sub
    Private Function null(ByVal zeichen)
        If Len(LTrim(zeichen)) = 1 Then
            zeichen = "0" + LTrim(zeichen)
        Else
            zeichen = LTrim(zeichen)
        End If
        Return zeichen
    End Function

    Private Sub ButtonDrucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDrucken.Click


        Dim Xs As New PrintOutWP
        Dim dv As DataView
        Dim t As DataTable
        wAdapter.SelectCommand = New OleDb.OleDbCommand
        wAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        wAdapter.SelectCommand.CommandText = "Select * from wacheplan where toern like '%" & TextBox1.Text & "%' order by datum1 "
        bsWacheplan.CancelEdit()
        dsToernverwaltung.Wacheplan.Clear()
        wAdapter.Fill(dsToernverwaltung.Wacheplan)
        bsWacheplan.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        If bsWacheplan.Count = 0 Then
            MsgBox("Wachenplan ist nicht erstellt.")
            Exit Sub
        End If
        For i = 1 To bsWacheplan.Count - 1
            If dsToernverwaltung.Wacheplan.Rows(i)("datum1") = dsToernverwaltung.Wacheplan.Rows(i - 1)("datum1") Then
                dsToernverwaltung.Wacheplan.Rows(i - 1)("person1") = ""
                bsWacheplan.EndEdit()
                taWacheplan.Update(dsToernverwaltung.Wacheplan)
            End If
        Next
        For ij = 1 To 4
            WacheAnzahl += 1
            If dsToernverwaltung.Wacheplan.Rows(0)("Person1").ToString = dsToernverwaltung.Wacheplan.Rows(ij)("person1").ToString Then Exit For
        Next
        dv = bsWacheplan.List
        t = dv.ToTable("Printing", False, "toern", "person1", "datum1", "person2", "datum2", "methode", "Person3", "Datum3")
        Xs.PrintWacheplan(t)
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub TextBox2_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseDoubleClick
        zurueck(TextBox2.Text)
    End Sub
    Private Sub zurueck(ByRef crewname)
        If Len(crewname) > 0 Then
            If CheckBox3.Checked = False Then
                ListBox1.Items.Add(crewname)
            End If
        Else
            MsgBox(" Schicht war noch nicht belegt.")
        End If
        crewname = ""
    End Sub
    Private Sub TextBox3_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseDoubleClick
        zurueck(TextBox3.Text)
    End Sub
    Private Sub TextBox4_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseDoubleClick
        zurueck(TextBox4.Text)
    End Sub
    Private Sub TextBox5_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox5.MouseDoubleClick
        zurueck(TextBox5.Text)
    End Sub
    Private Sub TextBox6_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox6.MouseDoubleClick
        zurueck(TextBox6.Text)
    End Sub
    Private Sub TextBox7_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox7.MouseDoubleClick
        zurueck(TextBox7.Text)
    End Sub
    Private Sub TextBox8_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox8.MouseDoubleClick
        zurueck(TextBox8.Text)
    End Sub
    Private Sub TextBox25_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox25.MouseDoubleClick
        zurueck(TextBox25.Text)
    End Sub
    Private Sub TextBox24_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox24.MouseDoubleClick
        zurueck(TextBox24.Text)
    End Sub
    Private Sub TextBox29_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox29.MouseDoubleClick
        zurueck(TextBox29.Text)
    End Sub
    Private Sub TextBox23_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox23.MouseDoubleClick
        zurueck(TextBox23.Text)
    End Sub
    Private Sub TextBox22_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox22.MouseDoubleClick
        zurueck(TextBox22.Text)
    End Sub
    Private Sub TextBox28_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox28.MouseDoubleClick
        zurueck(TextBox28.Text)
    End Sub
    Private Sub TextBox21_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox21.MouseDoubleClick
        zurueck(TextBox21.Text)
    End Sub
    Private Sub TextBox19_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox19.MouseDoubleClick
        zurueck(TextBox19.Text)
    End Sub
    Private Sub TextBox27_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox27.MouseDoubleClick
        zurueck(TextBox27.Text)
    End Sub
    Private Sub TextBox18_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox18.MouseDoubleClick
        zurueck(TextBox18.Text)
    End Sub
    Private Sub TextBox17_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox17.MouseDoubleClick
        zurueck(TextBox17.Text)
    End Sub
    Private Sub TextBox26_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox26.MouseDoubleClick
        zurueck(TextBox26.Text)
    End Sub
    Private Sub TextBox9_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox9.MouseDoubleClick
        zurueck(TextBox9.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text > " " Then
            ButtonSpeichern.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            GroupBox3.Location = New Point(1500, 1500)
            GroupBox5.Location = New Point(334, 352)
        Else
            GroupBox3.Location = New Point(334, 352)
            GroupBox5.Location = New Point(1500, 35300)
        End If
    End Sub


End Class