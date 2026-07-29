Public Class Standort
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Dim aenderung As Boolean
    Dim iii As Integer
    Dim position As Integer
    Dim msg As Integer
    Dim buch1 As String
    Dim altname As String
    Dim neuname As String
    Dim route As String
    Private Sub Standort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taVeranstaltungen.Fill(Me.DsAusbildung.Veranstaltungen)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Me.taListbox.Fill(Me.DsAusbildung.Listbox)
        Me.taStandort.Fill(Me.DsAusbildung.Standort)
        Me.taPostleitzahlen.Fill(Me.dsToernverwaltung.Postleitzahlen)
        Dim rp As System.Data.DataRowView = bsStandort.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        route = GetSetting("Karte", "Pfad", "T", "")
        lesenStandort()
      With DataGridView2
            .Columns(0).Width = 150
        End With
        Dim lp As System.Data.DataRowView = bsListbox.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from listbox where FormularName like 'Standort - Typ' "
        bsListbox.CancelEdit()
        DsAusbildung.Listbox.Clear()
        pAdapter.Fill(DsAusbildung.Listbox)
        DbAccess.SafePosition(bsListbox)
        If bsListbox.Count = 1 Then
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld1").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld2").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld3").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld4").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld5").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld6").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld7").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld8").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld9").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld10").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld11").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld12").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld13").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld14").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld15").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld16").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld17").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld18").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld19").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld20").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld21").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld22").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld23").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld24").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld25").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld26").ToString)
            comboFuellen1(DsAusbildung.Listbox.Rows(0)("Feld27").ToString)
            '           comboFuellen1(dsAusbildung.Listbox.Rows(0)("Feld28").ToString)
        End If
        pAdapter.SelectCommand.CommandText = "Select * from Listbox where FormularName like 'Standort - Infrastruktur' "
        bsListbox.CancelEdit()
        DsAusbildung.Listbox.Clear()
        pAdapter.Fill(DsAusbildung.Listbox)
        DbAccess.SafePosition(bsListbox)
        If bsListbox.Count = 1 Then
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld1").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld2").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld3").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld4").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld5").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld6").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld7").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld8").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld9").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld10").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld11").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld12").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld13").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld14").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld15").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld16").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld17").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld18").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld19").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld20").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld21").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld22").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld23").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld24").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld25").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld26").ToString)
            comboFuellen2(DsAusbildung.Listbox.Rows(0)("Feld27").ToString)
        End If
        Label15.Text = "Bild unter " + route + " speichern"
    End Sub
    Private Sub comboFuellen1(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                cbTyp.Items.Add(text)
            End If
        End If

    End Sub
    Private Sub comboFuellen2(ByVal text)
        If IsDBNull(text) = False Then
            If text > " " Then
                cbInfrastruktur.Items.Add(text)
            End If
        End If

    End Sub
    Private Sub lesenStandort()
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Standort"
        bsStandort.CancelEdit()
        DsAusbildung.Standort.Clear()
        pAdapter.Fill(DsAusbildung.Standort)
        DbAccess.SafePosition(bsStandort)
        aaa = bsStandort.Count
        Label13.Text = "Anzahl der gespeicherten Standorte: " + aaa
        bsStandort.AddNew()
    End Sub
    Private Sub FormularLoeschen()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        cbTyp.Text = ""
        cbInfrastruktur.Text = ""
        RichTextBox1.Text = ""
        altname = ""
        aenderung = False
        PictureBox1.Image = Nothing
        DataGridView2.Location = New Point(40, 1420)
        lesenStandort()
    End Sub
    Private Sub speichern()
        If TextBox1.Text > "     " Then
            txbTyp.Text = cbTyp.Text
            txbInfrastruktur.Text = cbInfrastruktur.Text
            If aenderung Then
                iii = 0
                If Altname <> TextBox1.Text And Altname > " " Then
                    msg = MsgBox(" Das Standort " & Convert.ToString(Altname) & " auf " & Convert.ToString(TextBox1.Text) & " umbenenen.", 1, "Umbenenen")
                    Me.Cursor = Cursors.WaitCursor
                    If msg = vbOK Then
                        StandortsnameAenderung()
                    Else
                        GoTo abbruch
                    End If
                End If
                bsStandort.EndEdit()
                taStandort.Update(DsAusbildung.Standort)
            Else
                bsStandort.AddNew()
                taStandort.Update(DsAusbildung.Standort)
            End If
            FormularLoeschen()
        Else
            MsgBox("Standortsname ist Pflichteingabe")
            TextBox1.Focus()
        End If
        aenderung = False
abbruch:
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub StandortsnameAenderung()
        Dim ccc As String
        Dim fl As Boolean
        aaa = altname
        aaa = aaa.Replace(" ", "")
        aaa = route + aaa + ".jpg"                           ' alter Name
        ccc = Trim$((route + TextBox1.Text + ".jpg"))       ' neuer Name
        ccc = ccc.Replace(" ", "")
        If My.Computer.FileSystem.FileExists(aaa) Then
            fl = IsFileInUse(ccc)
            My.Computer.FileSystem.CopyFile(aaa, ccc)
            fl = IsFileInUse(aaa)
            '           System.IO.File.Delete(aaa)
            Kill(aaa)
            MsgBox("Das alte Bild muß händisch gelöscht werden.")
        End If

    End Sub
    Public Function IsFileInUse(ByVal fullFilePath As String) As Boolean
        ' Gibt zurück, ob die übergebene Datei momentan exklusiv zu haben ist.
        ' Prüft, ob die angegeben Datei aktuell durch eine
        ' andere Anwendung in Benutzung ist
        Dim ff As Integer = FreeFile()

        If System.IO.File.Exists(fullFilePath) Then

            Try
                ' Versuchen, die Datei mit *exklusiven* Lese- und
                ' Schreibrechten zu öffnen
                FileOpen(ff, fullFilePath, OpenMode.Binary, _
                                           OpenAccess.ReadWrite, _
                                           OpenShare.LockReadWrite)

            Catch

                ' Ist ein Fehler aufgetreten, so wird nach außen hin generell
                ' davon ausgegangen, dass die Datei in Benutzung ist (obwohl
                ' auch andere Ursachen, etwa Rechteprobleme, möglich sind).
                IsFileInUse = True

            Finally

                ' Die eventuell geöffnete Datei schließen
                FileClose(ff)

            End Try
            FileClose(ff)

        End If

    End Function
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsStandort.Current
        DataGridView2.Visible = True
        '      RichTextBox1.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        '       TextBox18.Text = RTrim(TextBox18.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Standort where Bezeichnung like '%" & TextBox1.Text & "%'  order by Bezeichnung"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Standort where Mid(Bezeichnung,1,1) like '%" & TextBox1.Text & "%'  order by Bezeichnung"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsStandort.CancelEdit()
        DsAusbildung.Standort.Clear()
        xAdapter.Fill(DsAusbildung.Standort)
        Select Case bsStandort.Count
            Case 0
                MsgBox("Kein Standort mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Standort order by Bezeichnung"
                xAdapter.Fill(DsAusbildung.Standort)
                FormularLoeschen()
            Case 1
                DbAccess.SafePosition(bsStandort)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                RichTextBox1.Visible = True
                cbTyp.Text = txbTyp.Text
                aenderung = True
                aaa = DsAusbildung.Standort.Rows(0)("Bezeichnung").ToString
                aaa = aaa.Replace(" ", "")

                ' Bild soll optimal an die Größe der PictureBox 
                ' angepasst und angezeigt werden
                Dim Standortfoto As Image
                If My.Computer.FileSystem.FileExists(Trim$((route + aaa + ".jpg"))) Then
                    Standortfoto = Image.FromFile(Trim$((route + aaa + ".jpg")))
                    With PictureBox1
                        .Image = AutoSizeI.AutoSizeImage(Standortfoto, 520, 480)
                        Label15.Visible = False
                    End With
                Else
                    PictureBox1.Image = Nothing
                End If
                altname = TextBox1.Text
             Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsStandort.Position = position
                DataGridView2.Visible = True
                DataGridView2.Location = New Point(40, 390)
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsStandort.Count - 1
        For i = 0 To iii
            aaa = Mid(DsAusbildung.Standort.Rows(i)("Bezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        suchen()
    End Sub

    Private Sub LoeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoeschenButton.Click
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsStandort.Current
        Dim torname As String
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from kurse where Kursort like '%" & TextBox1.Text & "%' order by Kursbezeichnung"
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        xAdapter.Fill(DsAusbildung.Kurse)
        If TextBox1.Text > "" Then
            Select Case bsKurse.Count
                Case 0
                    xAdapter.SelectCommand.CommandText = "Select * from veranstaltungen where Ort1 like '%" & TextBox1.Text & "%' order by veranstaltung"
                    bsVeranstaltungen.CancelEdit()
                    DsAusbildung.Veranstaltungen.Clear()
                    xAdapter.Fill(DsAusbildung.Veranstaltungen)
                    Select Case bsVeranstaltungen.Count
                        Case 0
                            msg = MsgBox(" Das Standort: " & Convert.ToString(TextBox1.Text) & " wird gelöscht.", 1, "Löschen")
                            If msg = vbOK Then
                                bsStandort.RemoveCurrent()
                                taStandort.Update(DsAusbildung)
                            End If
                        Case Else
                            torname = DsAusbildung.Veranstaltungen.Rows(0)("veranstaltung").ToString
                            MsgBox(" Der Standort ist in der Veranstaltung: " & Convert.ToString(torname) & " gespeichert. " & Chr(10) & Chr(13) & "          Löschen ist nicht möglich.")
                    End Select
                  Case Else
                    torname = DsAusbildung.Kurse.Rows(0)("Kursbezeichnung").ToString
                    MsgBox(" Der Standort ist im Kurs: " & Convert.ToString(torname) & " gespeichert. " & Chr(10) & Chr(13) & "          Löschen ist nicht möglich.")
            End Select
            FormularLoeschen()
        Else
            MsgBox("Wähle zuerst ein Standort aus.")
        End If

    End Sub

    Private Sub SpeichernButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernButton.Click
        speichern()
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If TextBox4.Text > "" Or TextBox3.Text < "0000" Then

        Else
            Dim ppAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
            Dim rp As System.Data.DataRowView = bsPostleitzahlen.Current
            ppAdapter.SelectCommand = New OleDb.OleDbCommand
            ppAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            ppAdapter.SelectCommand.CommandText = "Select * from postleitzahlen where plz like '" & TextBox3.Text & "' "
            bsPostleitzahlen.CancelEdit()
            dsToernverwaltung.Postleitzahlen.Clear()
            ppAdapter.Fill(dsToernverwaltung.Postleitzahlen)
            If bsPostleitzahlen.Count > 0 Then
                TextBox4.Text = dsToernverwaltung.Postleitzahlen.Rows(0)("ort").ToString
            End If
        End If
    End Sub
    Private Sub DataGridView2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        cbTyp.Text = txbTyp.Text
        cbInfrastruktur.Text = txbInfrastruktur.Text
        DataGridView2.Location = New Point(40, 1420)
        suchen()
    End Sub

    Private Sub FormularloeschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormularloeschenButton.Click
        FormularLoeschen()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If

    End Sub

    Private Sub ButtonDrucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDrucken.Click
        Dim XB As New PrintOutSD
        Dim dv As DataView
        Dim t As DataTable
        dv = bsStandort.List
        t = dv.ToTable("Printing", False, "Bezeichnung", "Strasse", "Plz", "Ort", "Typ", "MaxTeilnehmer", "Infrastruktur", "Kosten", "Bemerkung", "Link", "Karte", "email", "WEBSeite", "Telefon")
        XB.PrintStandort(t)

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        suchenOrt()
    End Sub
    Private Sub suchenOrt()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsStandort.Current
        DataGridView2.Visible = True
        '      RichTextBox1.Visible = False
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        '       TextBox18.Text = RTrim(TextBox18.Text)
        If TextBox4.Text > "  " Then
            If Len(TextBox4.Text) > 1 Then
                If Mid(TextBox4.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox4.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from Standort order by ort"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Standort where ort like '%" & TextBox4.Text & "%'  order by ort"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Standort where Mid(ort,1,1) like '%" & TextBox4.Text & "%'  order by ort"
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Standort order by ort"
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        bsStandort.CancelEdit()
        DsAusbildung.Standort.Clear()
        xAdapter.Fill(DsAusbildung.Standort)
        Select Case bsStandort.Count
            Case 0
                MsgBox("Kein Standort mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Standort order by ort"
                xAdapter.Fill(DsAusbildung.Standort)
                FormularLoeschen()
            Case 1
                DbAccess.SafePosition(bsStandort)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
                RichTextBox1.Visible = True
                cbTyp.Text = txbTyp.Text
                aenderung = True
                aaa = DsAusbildung.Standort.Rows(0)("ort").ToString
                aaa = aaa.Replace(" ", "")

                ' Bild soll optimal an die Größe der PictureBox 
                ' angepasst und angezeigt werden
                Dim Standortfoto As Image
                If My.Computer.FileSystem.FileExists(Trim$((route + aaa + ".jpg"))) Then
                    Standortfoto = Image.FromFile(Trim$((route + aaa + ".jpg")))
                    With PictureBox1
                        .Image = AutoSizeI.AutoSizeImage(Standortfoto, 520, 480)
                        Label15.Visible = False
                    End With
                Else
                    PictureBox1.Image = Nothing
                End If
                altname = TextBox4.Text
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsStandort.Position = position
                DataGridView2.Visible = True
                DataGridView2.Location = New Point(40, 390)
        End Select
    End Sub
End Class