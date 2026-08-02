Public Class CrewDetails
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Public iii As Integer
    Dim boot As String
    Public aaa As String
    Public ij As Integer
    Dim buch1 As String
    Dim gleich As Integer
    Dim position As Integer
    Private nIndex As Long
    '    Dim details As Boolean = False
    Dim Bildwechsel As Boolean = True
    Dim BildwechselT As Boolean = True
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim lAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim iAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim rAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub CrewDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.CrewAdressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsCrewbesprechung.AnRueckReise". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taAnRueckReise.Fill(Me.dsCrewbesprechung.AnRueckReise)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.CrewDetails". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taCrewDetails.Fill(Me.dsCrewbesprechung.CrewDetails)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        boot = GetSetting("Boot", "Pfad", "T")
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Dim ri As System.Data.DataRowView = bsCrewDetails.Current
        iAdapter.SelectCommand = New OleDb.OleDbCommand
        iAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        iAdapter.SelectCommand.CommandText = "Select * from crewdetails"
        bsCrewDetails.CancelEdit()
        dsCrewbesprechung.CrewDetails.Clear()
        iAdapter.Fill(dsCrewbesprechung.CrewDetails)
        bsCrewDetails.AddNew()
        GroupBoxAnreiseKenn.Location = New Point(1700, 107)
        GroupBoxKojen.Location = New Point(1700, 107)
        GroupBoxTörn.Location = New Point(1700, 107)
        MaskedTextBox1.Mask = "00.00.0000"
         MaskedTextBox18.Mask = "00.00.0000"
         MaskedTextBox2.Mask = "00:00"
           MaskedTextBox17.Mask = "00:00"
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
        ListBox2.Visible = False
        ButtonGleich.Visible = False
        ButtonSpeichernAnreise.Visible = False
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        BtBearbeiten.Visible = False
        Dim namevz As String
        GroupBoxTörn.Location = New Point(20, 130)
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
                namevz = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString
                Label13.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                ListBox1.Items.Add(namevz)
                ListBox2.Items.Add(namevz)
                TextBox7.Text = namevz
                GroupBoxKojen.Location = New Point(20, 130)
                GroupBoxTörn.Location = New Point(1700, 107)
                TextBox1.Text = TextBox36.Text
                bootfoto()
                aaa = TextBox1.Text
                KojenZuordnung()
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
    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        TextBox1.Text = TextBox36.Text
        suchen()
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
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If

    End Sub
    Private Sub bootfoto()

        aaa = dsToernverwaltung.Toernname.Rows(0)("bootsname").ToString
        aaa = aaa.Replace(" ", "")
 
        ' Bild soll optimal an die Größe der PictureBox 
        ' angepasst und angezeigt werden
        Dim fotoboot As Image
        If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "1.jpg"))) Then
            TextBox62.Text = Trim$((boot + aaa + "1.jpg"))
            fotoboot = Image.FromFile(Trim$((boot + aaa + "1.jpg")))
            With PictureBox2
                .Image = AutoSizeI.AutoSizeImage(fotoboot, 162, 435)
            End With
        Else
            PictureBox2.Image = Nothing
            MsgBox("Bild des Bootes ist nicht vorhanden")
        End If
        BildwechselT = False
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

        aaa = dsToernverwaltung.Toernname.Rows(0)("bootsname").ToString
        aaa = aaa.Replace(" ", "")

        ' Bild soll optimal an die Größe der PictureBox 
        ' angepasst und angezeigt werden
        Dim fotoboot As Image
        If My.Computer.FileSystem.FileExists(Trim$((boot + aaa + "2.jpg"))) Then
            TextBox62.Text = Trim$((boot + aaa + "2.jpg"))
            fotoboot = Image.FromFile(Trim$((boot + aaa + "2.jpg")))
            With PictureBox2
                .Image = AutoSizeI.AutoSizeImage(fotoboot, 162, 435)
            End With
        Else
            PictureBox2.Image = Nothing
            MsgBox("Das zweite Bild des Bootes ist nicht vorhanden")
        End If
        If Bildwechsel = False Then
            bootfoto()
            Bildwechsel = True
        Else
            Bildwechsel = False
        End If
    End Sub
    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click
        If BildwechselT = True Then
            bootfoto()
            BildwechselT = False
        Else
            BildwechselT = True
            PictureBox2_Click(sender, e)
        End If

    End Sub
    Private Sub KojenZuordnung()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim namevz As String
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & aaa & "' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        For ij = 0 To bsTC.Count - 1
            namevz = dsToernverwaltung.TC.Rows(ij)("vzname").ToString
            ListBox1.Items.Add(namevz)
            ListBox2.Items.Add(namevz)
            Select Case ij

            End Select
        Next
        Dim ri As System.Data.DataRowView = bsCrewDetails.Current
        iAdapter.SelectCommand = New OleDb.OleDbCommand
        iAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        iAdapter.SelectCommand.CommandText = "Select * from crewdetails where toernname = '" & TextBox1.Text & "' "
        bsCrewDetails.CancelEdit()
        dsCrewbesprechung.CrewDetails.Clear()
        iAdapter.Fill(dsCrewbesprechung.CrewDetails)
        If bsCrewDetails.Count > 0 Then
            For ij = ListBox1.Items.Count - 1 To 0 Step -1
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("bb1").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("bs1").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("hb2").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("hb1").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("hs1").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("bb2").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("bs2").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("hs2").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("stockoben").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                    GoTo weiter
                End If
                If ListBox1.Items(ij) = dsCrewbesprechung.CrewDetails.Rows(0)("stockunten").ToString Then
                    ListBox1.Items.RemoveAt(ij)
                End If
weiter:
            Next
        Else
            bsCrewDetails.AddNew()
            TextBox1.Text = TextBox36.Text
        End If
    End Sub
    Private Sub zurueck(ByRef crewname)
        If Len(crewname) > 0 Then
            ListBox1.Items.Add(crewname)
            crewname = ""
        Else
            MsgBox(" Koje war noch nicht belegt.")
        End If
    End Sub
    Private Sub TextBox9_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox9.MouseClick
        zurueck(TextBox9.Text)
    End Sub
    Private Sub TextBox10_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox10.MouseClick
        zurueck(TextBox10.Text)
    End Sub
    Private Sub TextBox2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        zurueck(TextBox2.Text)
    End Sub
    Private Sub TextBox34_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox34.MouseClick
        zurueck(TextBox34.Text)
    End Sub
    Private Sub TextBox4_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseClick
        zurueck(TextBox4.Text)
    End Sub
    Private Sub TextBox35_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox35.MouseClick
        zurueck(TextBox35.Text)
    End Sub
    Private Sub TextBox3_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseClick
        zurueck(TextBox3.Text)
    End Sub
    Private Sub TextBox33_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox33.MouseClick
        zurueck(TextBox33.Text)
    End Sub
    Private Sub TextBox6_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox6.MouseClick
        zurueck(TextBox6.Text)
    End Sub
    Private Sub TextBox8_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox8.MouseClick
        zurueck(TextBox8.Text)
    End Sub
    Private Sub TextBox5_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox5.MouseClick
        zurueck(TextBox5.Text)
    End Sub
    Private Sub TextBox32_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox32.MouseClick
        zurueck(TextBox32.Text)
    End Sub
    Private Sub ListBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown
        ' Index des Eintrags "merken"
        nIndex = ListBox1.SelectedIndex
    End Sub
    Private Sub ListBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseMove
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
    Private Sub ListBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseUp
        Dim x, y As Integer
        Dim yzusatz As Integer = 367
        x = Cursor.Position.X - Me.Location.X
        y = Cursor.Position.Y - Me.Location.Y
        '      x = Cursor.Position.X
        '     y = Cursor.Position.Y
        '                140;22          Size von Textbox2 - 9
        Dim x2, y2, boxl As Integer
        x2 = TextBox2.Location.X + 29
        '      y2 = TextBox2.Location.Y + yzusatz
        y2 = TextBox2.Location.Y + 162
        boxl = TextBox2.Size.Width
        Dim x3, y3 As Integer
        x3 = TextBox3.Location.X + 29
        y3 = TextBox3.Location.Y + 162
        Dim x4, y4 As Integer
        x4 = TextBox4.Location.X + 29
        y4 = TextBox4.Location.Y + 162
        Dim x5, y5 As Integer
        x5 = TextBox5.Location.X + 29
        y5 = TextBox5.Location.Y + 162

        Dim x34, y34 As Integer
        x34 = TextBox34.Location.X + 29
        y34 = TextBox34.Location.Y + 162
        boxl = TextBox2.Size.Width
        Dim x33, y33 As Integer
        x33 = TextBox33.Location.X + 29
        y33 = TextBox33.Location.Y + 162
        Dim x35, y35 As Integer
        x35 = TextBox35.Location.X + 29
        y35 = TextBox35.Location.Y + 162
        Dim x32, y32 As Integer
        x32 = TextBox32.Location.X + 29
        y32 = TextBox32.Location.Y + 162
        Dim x10, y10 As Integer
        x10 = TextBox10.Location.X + 29
        y10 = TextBox10.Location.Y + 162
        Dim x9, y9 As Integer
        x9 = TextBox9.Location.X + 29
        y9 = TextBox9.Location.Y + 162


        If y > y10 And y < y10 + 22 Then
            If x > x10 And x < x10 + 180 Then
                koje(TextBox10.Text)
            End If
        End If
        If y > y9 And y < y9 + 22 Then
            If x > x9 And x < x9 + 180 Then
                koje(TextBox9.Text)
            End If
        End If

        If y > y2 And y < y2 + 22 Then
            If x > x2 And x < x2 + 180 Then                                  '    If x > 110 And x < 250 Then
                koje(TextBox2.Text)
            End If
            If x > x3 And x < x3 + 180 Then                                  '    If x > 260 And x < 405 Then
                koje(TextBox3.Text)
            End If
        End If

        If y > y5 And y < y5 + 22 Then
            If x > x5 And x < x5 + 180 Then
                koje(TextBox5.Text)
            End If
            If x > x4 And x < x4 + 180 Then
                koje(TextBox4.Text)
            End If
        End If

        If y > y33 And y < y33 + 22 Then
            If x > x33 And x < x33 + 180 Then
                koje(TextBox33.Text)
            End If
            If x > x34 And x < x34 + 180 Then
                koje(TextBox34.Text)
            End If
        End If
        If y > y32 And y < y32 + 22 Then
            If x > x32 And x < x32 + 180 Then
                koje(TextBox32.Text)
            End If
            If x > x35 And x < x35 + 180 Then
                koje(TextBox35.Text)
            End If
        End If

        Dim x6, y6 As Integer
        x6 = TextBox6.Location.X + 29
        y6 = TextBox6.Location.Y + 162
        Dim x8, y8 As Integer
        x8 = TextBox8.Location.X + 29
        y8 = TextBox8.Location.Y + 162
        If x > x8 And x < x8 + 180 And y > y8 And y < y8 + 22 Then
            koje(TextBox8.Text)
        End If
        If x > x6 And x < x6 + 180 And y > y6 And y < y6 + 22 Then
            koje(TextBox6.Text)
        End If
        nIndex = -1
    End Sub
    Private Sub koje(ByRef Platz)
        If Len(Platz) > 0 Then
            ListBox1.Items.Add(Platz)
        End If
        Platz = ListBox1.Text
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
    Private Sub ButtonSpeichernKojen_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichernKojen.Click
        aaa = TextBox62.Text
        Try
            bsCrewDetails.EndEdit()
            taCrewDetails.Update(dsCrewbesprechung.CrewDetails)
        Catch ex As Exception
            AppLog.Warn("CrewDetails speichern: " & ex.Message)
            MsgBox("Crewdetails konnten nicht gespeichert werden." & Environment.NewLine &
                   "Prüfen Sie, ob in Crewbesprechung.mdb die Spalte Bild in der Tabelle CrewDetails vorhanden ist." &
                   Environment.NewLine & ex.Message)
            Return
        End Try
        GroupBoxAnreiseKenn.Location = New Point(180, 130)
        GroupBoxKojen.Location = New Point(1700, 107)
        ButtonGleich.Enabled = False
        ListBox2.Visible = True
        ButtonSpeichernAnreise.Visible = True
        TextBox7.Text = ""
        '       Kenntnise()
        TextBox16.Focus()
    End Sub

    '                    An- und Rückreise

    Private Sub TextBox16_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox16.LostFocus
        ButtonGleich.Enabled = True
        gleich = 1
    End Sub
    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox1.GotFocus
        gleich = 2
    End Sub
    Private Sub MaskedTextBox2_GotFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox2.GotFocus
        gleich = 3
    End Sub
    Private Sub TextBox45_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox45.GotFocus
        gleich = 4
    End Sub
    Private Sub MaskedTextBox18_GotFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox18.GotFocus
        gleich = 5
    End Sub
    Private Sub MaskedTextBox17_GotFocus(sender As Object, e As System.EventArgs) Handles MaskedTextBox17.GotFocus
        gleich = 6
    End Sub







    Private Sub Crewadrese(ByVal nm, ByRef ken, ByRef tel)
        Dim aAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        aAdapter.SelectCommand = New OleDb.OleDbCommand
        aAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        aAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname = '" & nm & "'"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        aAdapter.Fill(dsToernverwaltung.CrewAdressen)
        ken = ""
        tel = ""
        If Not DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("fb1").ToString) Then
            If dsToernverwaltung.CrewAdressen.Rows(0)("fb1").ToString = True Then ken = "FB1"
        End If
        If Not DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("fb2").ToString) Then
            If dsToernverwaltung.CrewAdressen.Rows(0)("fb2").ToString = True Then ken = "FB2"
        End If
        If Not DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("fb3").ToString) Then
            If dsToernverwaltung.CrewAdressen.Rows(0)("fb3").ToString = True Then ken = "FB3"
        End If
        If Not DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("fb4").ToString) Then
            If dsToernverwaltung.CrewAdressen.Rows(0)("fb4").ToString = True Then ken = "FB4"
        End If
        If dsToernverwaltung.CrewAdressen.Rows(0)("A-Schein").ToString = True Then ken += ", A-Schein"
        If dsToernverwaltung.CrewAdressen.Rows(0)("Motorboot").ToString = True Then ken += ", Donaupatent"
        If dsToernverwaltung.CrewAdressen.Rows(0)("Funk").ToString > " " Then ken += ", " + dsToernverwaltung.CrewAdressen.Rows(0)("Funk").ToString
        If dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString > " " Then tel = dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString
    End Sub
    Private Sub ButtonGleich_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGleich.Click
        Allesgleich()
        Me.Close()
    End Sub
    Private Sub Allesgleich()
        Dim rr As System.Data.DataRowView = bsAnRueckReise.Current
        For ij = 0 To ListBox2.Items.Count - 1
            rAdapter.SelectCommand = New OleDb.OleDbCommand
            rAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
            rAdapter.SelectCommand.CommandText = "Select * from AnRueckReise where toernname = '" & TextBox1.Text & "' and cw_name='" & ListBox2.Items(ij) & "'  "
            bsAnRueckReise.CancelEdit()
            dsCrewbesprechung.AnRueckReise.Clear()
            rAdapter.Fill(dsCrewbesprechung.AnRueckReise)
            If bsAnRueckReise.Count = 1 Then
                If Not DBNull.Value.Equals(TextBox16.Text) Then TextBox39.Text = TextBox16.Text ' Ankuntsort
                If Not DBNull.Value.Equals(TextBox45.Text) Then TextBox40.Text = TextBox45.Text ' Rückreise
                If Not DBNull.Value.Equals(TextBox17.Text) Then TextBox43.Text = TextBox17.Text ' Kenntnise
                If Not DBNull.Value.Equals(MaskedTextBox1.Text) Then TextBox41.Text = MaskedTextBox1.Text '                                 Ankunftszeit
                If Not DBNull.Value.Equals(MaskedTextBox2.Text) Then TextBox41.Text += "§" + MaskedTextBox2.Text '                                 Ankunftszeit
                If Not DBNull.Value.Equals(MaskedTextBox18.Text) Then TextBox44.Text = MaskedTextBox18.Text '                                 Abfahrtszeit
                If Not DBNull.Value.Equals(MaskedTextBox17.Text) Then TextBox44.Text += "§" + MaskedTextBox17.Text '                                 Abfahrtszeit
                bsAnRueckReise.EndEdit()
                taAnRueckReise.Update(dsCrewbesprechung.AnRueckReise)
            Else
                bsAnRueckReise.AddNew()
                If Not DBNull.Value.Equals(TextBox16.Text) Then TextBox39.Text = TextBox16.Text ' Ankuntsort
                If Not DBNull.Value.Equals(TextBox45.Text) Then TextBox40.Text = TextBox45.Text ' Rückreise
                If Not DBNull.Value.Equals(TextBox17.Text) Then TextBox43.Text = TextBox17.Text ' Kenntnise
                If Not DBNull.Value.Equals(MaskedTextBox1.Text) Then TextBox41.Text = MaskedTextBox1.Text '                                 Ankunftszeit
                If Not DBNull.Value.Equals(MaskedTextBox2.Text) Then TextBox41.Text += "§" + MaskedTextBox2.Text '                                 Ankunftszeit
                If Not DBNull.Value.Equals(MaskedTextBox18.Text) Then TextBox44.Text = MaskedTextBox18.Text '                                 Abfahrtszeit
                If Not DBNull.Value.Equals(MaskedTextBox17.Text) Then TextBox44.Text += "§" + MaskedTextBox17.Text '                                 Abfahrtszeit
                TextBox37.Text = TextBox1.Text
                TextBox38.Text = ListBox2.Items(ij)
                Crewadrese(ListBox2.Items(ij), TextBox43.Text, TextBox61.Text)
                bsAnRueckReise.AddNew()
                taAnRueckReise.Update(dsCrewbesprechung.AnRueckReise)
            End If
            TextBox17.Text = ""
            TextBox61.Text = ""
        Next
    End Sub
    Private Sub detailsLoschen()
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox45.Text = ""
        TextBox61.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox18.Text = ""
        MaskedTextBox17.Text = ""

    End Sub
    Private Sub ButtonSpeichernAnreise_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpeichernAnreise.Click
        Dim rr As System.Data.DataRowView = bsAnRueckReise.Current
        rAdapter.SelectCommand = New OleDb.OleDbCommand
        rAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        rAdapter.SelectCommand.CommandText = "Select * from AnRueckReise where toernname = '" & TextBox1.Text & "' and cw_name='" & TextBox7.Text & "'  "
        bsAnRueckReise.CancelEdit()
        dsCrewbesprechung.AnRueckReise.Clear()
        rAdapter.Fill(dsCrewbesprechung.AnRueckReise)
        If bsAnRueckReise.Count = 1 Then
            If Not DBNull.Value.Equals(TextBox16.Text) Then TextBox39.Text = TextBox16.Text ' Ankuntsort
            If Not DBNull.Value.Equals(TextBox45.Text) Then TextBox40.Text = TextBox45.Text ' Rückreise
            If Not DBNull.Value.Equals(TextBox17.Text) Then TextBox43.Text = TextBox17.Text ' Kenntnise
            If Not DBNull.Value.Equals(MaskedTextBox1.Text) Then TextBox41.Text = MaskedTextBox1.Text '                                 Ankunftszeit
            If Not DBNull.Value.Equals(MaskedTextBox2.Text) Then TextBox41.Text += "§" + MaskedTextBox2.Text '                                 Ankunftszeit
            If Not DBNull.Value.Equals(MaskedTextBox18.Text) Then TextBox44.Text = MaskedTextBox18.Text '                                 Abfahrtszeit
            If Not DBNull.Value.Equals(MaskedTextBox17.Text) Then TextBox44.Text += "§" + MaskedTextBox17.Text '                                 Abfahrtszeit
            bsAnRueckReise.EndEdit()
            taAnRueckReise.Update(dsCrewbesprechung.AnRueckReise)
        Else
        End If
        detailsLoschen()
    End Sub
    Private Sub ListBox2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        nIndex = ListBox2.SelectedIndex
        TextBox7.Text = ListBox2.Items(nIndex)
        CrewAnAb(TextBox1.Text, TextBox7.Text)
    End Sub
    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseDoubleClick
        nIndex = ListBox2.SelectedIndex
        TextBox7.Text = ListBox2.Items(nIndex)
        CrewAnAb(TextBox1.Text, TextBox7.Text)
    End Sub
    Private Sub CrewAnAb(toern, name)
        Dim rr As System.Data.DataRowView = bsAnRueckReise.Current
        rAdapter.SelectCommand = New OleDb.OleDbCommand
        rAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        rAdapter.SelectCommand.CommandText = "Select * from AnRueckReise where toernname = '" & toern & "' and cw_name='" & name & "'  "
        bsAnRueckReise.CancelEdit()
        dsCrewbesprechung.AnRueckReise.Clear()
        rAdapter.Fill(dsCrewbesprechung.AnRueckReise)
        ButtonGleich.Visible = True
        If bsAnRueckReise.Count = 0 Then
            bsAnRueckReise.AddNew()
            TextBox37.Text = toern
            TextBox38.Text = name
            Crewadrese(name, TextBox43.Text, TextBox61.Text)
            bsAnRueckReise.AddNew()
            taAnRueckReise.Update(dsCrewbesprechung.AnRueckReise)
        Else
            If Not DBNull.Value.Equals(TextBox39.Text) Then TextBox16.Text = TextBox39.Text ' Ankuntsort
            If Not DBNull.Value.Equals(TextBox40.Text) Then TextBox45.Text = TextBox40.Text ' Rückreise
            If Not DBNull.Value.Equals(TextBox43.Text) Then TextBox17.Text = TextBox43.Text ' Kenntnise
            If Not DBNull.Value.Equals(TextBox41.Text) Then '                                 Ankunftszeit
                MaskedTextBox1.Text = SafeData.FormatDateDe(TextBox41.Text)
                MaskedTextBox2.Text = SafeData.FormatTimeHm(TextBox41.Text)
            End If
            If Not DBNull.Value.Equals(TextBox44.Text) Then '                                 Ankunftszeit
                MaskedTextBox18.Text = SafeData.FormatDateDe(TextBox44.Text)
                MaskedTextBox17.Text = SafeData.FormatTimeHm(TextBox44.Text)
            End If
        End If
    End Sub
    Private Sub BtBearbeiten_Click(sender As System.Object, e As System.EventArgs) Handles BtBearbeiten.Click
        suchen()
    End Sub



End Class