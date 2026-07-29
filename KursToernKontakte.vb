Public Class KursToernKontakte
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim Name_Kontakt As Boolean
    Dim aaa As String
    Dim buch1 As String
    Dim Kontakt As String
    Dim namen As String
    Dim aenderung As Boolean
    Dim dt As String
    Dim position As Integer
    Public iii As Integer
    Dim namevz As String
    Dim irow As Integer

    Private Sub KursToernKontakte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        ' Resreve1 
        ' Reserve2 
        '

        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taKontakte.Fill(Me.DsAusbildung.Kontakte)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung

        If Menü.FreischaltZiffer = 4 Then
        Else
            DruckenButton.Enabled = False
        End If

        ' Kontaktart:
        '            E-Mail
        '            Schriftlich
        '            Personlich
        '            Telefonisch
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0

        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        Dim rk As System.Data.DataRowView = bsKontakte.Current

        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from kontakte order by Datum desc"
        bsKontakte.CancelEdit()
        DsAusbildung.Kontakte.Clear()
        kAdapter.Fill(DsAusbildung.Kontakte)
        bsKontakte.Position = 0
        aaa = bsKontakte.Count
        Label23.Text = "Anzahl der gespeicherten Kontakte: " + aaa
        bsKontakte.AddNew()
        Name_Kontakt = False
        aenderung = False
        MaskedTextBox1.Mask = "##.##.#### ##:##"
        MaskedTextBox4.Mask = "##.##.#### ##:##"
        MaskedTextBox2.Mask = "##.##.####"
        MaskedTextBox3.Mask = "##.##.####"
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 140
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 150
        Label3.Text = " "
        DataGridView2.Columns(0).Width = 200
        DataGridView2.Columns(1).Width = 140
        DataGridView2.Columns(2).Width = 200
        Menü.RestText = ""
        Formularloeschen()
    End Sub
    Private Sub SpeichernButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernButton.Click
        If TextBox1.Text > "  " Then
            If MaskedTextBox1.Text > "" Then
                If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
                    MsgBox("Kontaktart ist Pflichteingabe")
                    RadioButton1.Focus()
                    '                 RadioText()
                Else
                    If aenderung Then
                        bsKontakte.EndEdit()
                        taKontakte.Update(DsAusbildung.Kontakte)
                        TextBox1.Text = ""
                        TextBox2.Text = " "
                        TextBox3.Text = " "
                        TextBox4.Text = " "
                        TextBox5.Text = " "
                        TextBox6.Text = " "
                        MaskedTextBox1.Text = " "
                        RichTextBox1.Text = ""
                    Else
                        '                    RadioText()
                        kAdapter.SelectCommand.CommandText = "Select * from kontakte order by Datum"
                        bsKontakte.CancelEdit()
                        DsAusbildung.Kontakte.Clear()
                        kAdapter.Fill(DsAusbildung.Kontakte)
                        aaa = bsKontakte.Count
                        bsKontakte.AddNew()
                        bsKontakte.AddNew()
                        DsAusbildung.Kontakte.Rows(aaa)("vzname") = TextBox9.Text
                        DsAusbildung.Kontakte.Rows(aaa)("Datum") = MaskedTextBox4.Text
                        DsAusbildung.Kontakte.Rows(aaa)("Kontaktart") = Kontakt
                        DsAusbildung.Kontakte.Rows(aaa)("DatumT") = dt
                        DsAusbildung.Kontakte.Rows(aaa)("Bemerkung") = RichTextBox1.Text
                        DsAusbildung.Kontakte.Rows(aaa)("emailadresse") = TextBox6.Text
                        DsAusbildung.Kontakte.Rows(aaa)("Handynr") = TextBox5.Text
                         aaa = RichTextBox1.Text
                        taKontakte.Update(DsAusbildung.Kontakte)
                        kAdapter.SelectCommand.CommandText = "Select * from kontakte order by Datum desc"
                        bsKontakte.CancelEdit()
                        DsAusbildung.Kontakte.Clear()
                        kAdapter.Fill(DsAusbildung.Kontakte)
                        bsKontakte.Position = 0
                        Label23.Text = "Anzahl der gespeicherten Kontakte: " + aaa
                        bsKontakte.AddNew()
                        Formularloeschen()
                    End If
                    aenderung = False
                End If
            Else
                MsgBox("Datum ist Pflichteingabe")
                MaskedTextBox1.Focus()
            End If

        Else
            MsgBox("Name ist Pflichteingabe")
            TextBox1.Focus()
        End If

    End Sub
    Private Sub Formularloeschen()
        kAdapter.SelectCommand.CommandText = "Select * from kontakte order by Datum desc"
        bsKontakte.CancelEdit()
        DsAusbildung.Kontakte.Clear()
        kAdapter.Fill(DsAusbildung.Kontakte)
        bsKontakte.Position = 0
        '       bsKontakte.AddNew()
        '        DsAusbildung.Kontakte.Last()
        TextBox1.Text = ""
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
        MaskedTextBox1.Text = " "
        MaskedTextBox4.Text = " "
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        KontakteGruppe.Location = New Point(12, 175)
        BemerkungGruppe.Location = New Point(2000, 1000)
        AdressenGruppe.Location = New Point(2000, 1000)
        aenderung = False
        Label3.Text = " "
        Kontakt = ""
        '       Label23.Text = " "
        Name_Kontakt = False
        '        NaKoButton.Text = "Name - Adressen"
        RichTextBox1.Text = ""
    End Sub
    Private Sub TextRadio()
        If Kontakt = "Telefonisch" Then
            RadioButton1.Checked = True
        End If
        If Kontakt = "Personlich" Then
            RadioButton2.Checked = True
        End If
        If Kontakt = "Schriftlich" Then
            RadioButton3.Checked = True
        End If
        If Kontakt = "E-Mail" Then
            RadioButton4.Checked = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Kontakt = "Telefonisch"
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Kontakt = "Personlich"
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Kontakt = "Schriftlich"
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Kontakt = "E-Mail"
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim min As String
        Dim std As String
        min = CStr(Date.Now.Minute)
        If Len(min) > 1 Then
            MaskedTextBox4.Text = CStr(Date.Now.Date) + " " + CStr(Date.Now.Hour) + ":" + CStr(Date.Now.Minute)
        Else
            MaskedTextBox4.Text = CStr(Date.Now.Date) + " " + CStr(Date.Now.Hour) + ":0" + CStr(Date.Now.Minute)
        End If
        std = CStr(Date.Now.Hour)
        If Len(std) > 1 Then
            MaskedTextBox4.Text = CStr(Date.Now.Date) + " " + CStr(Date.Now.Hour) + ":" + MaskedTextBox4.Text.Substring(14, 2)
        Else
            MaskedTextBox4.Text = CStr(Date.Now.Date) + "0" + CStr(Date.Now.Hour) + ":" + MaskedTextBox4.Text.Substring(14, 2)
        End If
        MaskedTextBox4.Focus()
        BemerkungGruppe.Location = New Point(12, 175)
        BemerkungGruppe.Size = New Point(920, 362)
    End Sub
    Private Sub NaKoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NaKoButton.Click
        namen = TextBox9.Text
        Formularloeschen()
        Name_Kontakt = True
        TextBox9.Focus()
        AdresseSuchen()
    End Sub
    Private Sub AdresseSuchen()
        If namen > " " Then
            pAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & namen & "%' order by vzname"
        Else
            pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
        End If
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        KontakteGruppe.Location = New Point(2000, 1000)
        RichTextBox1.Size = New Point(908, 330)
        AdressenGruppe.Location = New Point(12, 175)
        AdressenGruppe.Size = New Point(920, 362)
        DataGridView2.Size = New Point(908, 330)
        aenderung = False
        NaKoButton.Visible = False
    End Sub
    Private Sub KontakteSuchen()
        kAdapter.SelectCommand.CommandText = "Select * from kontakte order by Datum desc"
        bsKontakte.CancelEdit()
        DsAusbildung.Kontakte.Clear()
        kAdapter.Fill(DsAusbildung.Kontakte)
        bsKontakte.Position = 0
        aaa = bsKontakte.Count
        Label23.Text = "Anzahl der gespeicherten Kontakte: " + aaa
        KontakteGruppe.Location = New Point(12, 175)
        BemerkungGruppe.Location = New Point(2000, 1000)
        AdressenGruppe.Location = New Point(2000, 1000)
        aenderung = True
    End Sub
    Private Sub positionieren()
        iii = bsCrewAdressen.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub positionierenK()
        iii = bsKontakte.Count - 1
        For i = 0 To iii
            aaa = Mid(DsAusbildung.Kontakte.Rows(i)("vzname").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo GefundenK
            End If
        Next
GefundenK:
    End Sub
    Private Sub NameSuchen()
        AdressenGruppe.Text = "Name mit Klick auswählen"
        '       GroupBox1.Enabled = False
        Label23.Text = ""
        TextBox1.Text = TextBox9.Text
        If TextBox1.Text = "" And TextBox4.Text > "" Then
            TextBox1.Text = TextBox4.Text
        End If
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
                Else
                    pAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox1.Text & "%' order by vzname"
                End If
            Else
                pAdapter.SelectCommand.CommandText = "Select * from crewadressen where  Mid(zuname,1,1) like '%" & TextBox1.Text & "%'  order by vzname"
            End If
        Else
            pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
        End If
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                pAdapter.Fill(dsToernverwaltung.CrewAdressen)
                '               Formularloeschen()
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(12, 20)
            Case 1
                bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                '              GroupBox1.Enabled = True
                TextBox2.Text = TextBox6.Text
                TextBox3.Text = TextBox5.Text
                TextBox9.Text = TextBox4.Text
                Label3.Text = TextBox2.Text + "   " + TextBox3.Text
                AdressenGruppe.Location = New Point(2000, 1000)
                BemerkungGruppe.Location = New Point(12, 175)
                BemerkungGruppe.Size = New Point(920, 362)
                Name_Kontakt = False
                NaKoButton.Visible = True
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCrewAdressen.Position = position
                '               DataGridView1.Visible = True
                DataGridView1.Location = New Point(12, 20)
        End Select
        TextBox1.Text = TextBox4.Text

    End Sub
    Private Sub konteSuchen()
        KontakteGruppe.Text = "Kontakt mit Klick auswählen"
        Label23.Text = ""
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    kAdapter.SelectCommand.CommandText = "Select * from Kontakte order by vzname"
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from Kontakte where vzname like '%" & TextBox1.Text & "%'  order by Datum desc"

                End If
            Else
                '              kAdapter.SelectCommand.CommandText = "Select * from Kontakte where  Mid(vzname,1,1) like '%" & TextBox1.Text & "%'  order by vzname"
                kAdapter.SelectCommand.CommandText = "Select * from Kontakte where  Mid(vzname,1,1) = '" & TextBox1.Text & "'  order by vzname, Datum desc"
            End If
        Else
            kAdapter.SelectCommand.CommandText = "Select * from Kontakte order by vzname"
        End If
        bsKontakte.CancelEdit()
        DsAusbildung.Kontakte.Clear()
        kAdapter.Fill(DsAusbildung.Kontakte)
        Select Case bsKontakte.Count
            Case 0
                MsgBox("Kein Kontakt mit angegebenen Buchstabenkombination vorhanden")
                kAdapter.SelectCommand.CommandText = "Select * from Kontakte order by vzname"
                bsKontakte.CancelEdit()
                DsAusbildung.Kontakte.Clear()
                kAdapter.Fill(DsAusbildung.Kontakte)
                '               Formularloeschen()
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(12, 20)
            Case 1
                bsKontakte.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                Label3.Text = TextBox2.Text + "   " + TextBox3.Text
                KontakteGruppe.Location = New Point(2000, 1000)
                BemerkungGruppe.Location = New Point(12, 175)
                BemerkungGruppe.Size = New Point(920, 362)
                Kontakt = DsAusbildung.Kontakte.Rows(0)("kontaktart").ToString
                TextRadio()
                TextBox9.Text = TextBox1.Text
                MaskedTextBox4.Text = MaskedTextBox1.Text
            Case Else
                position = 0
                If buch1 > " " Then
                    positionierenK()
                End If
                buch1 = ""
                bsKontakte.Position = position
                KontakteGruppe.Location = New Point(12, 175)
                BemerkungGruppe.Location = New Point(2000, 1000)
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(12, 20)
        End Select
    End Sub
    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        TextBox9.Text = ""
        NameSuchen()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Name_Kontakt = True Then
            NameSuchen()
        Else
            TextBox1.Text = TextBox9.Text
            konteSuchen()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Label3.Text = DataGridView1.CurrentRow.Cells(2).Value + "   " + DataGridView1.CurrentRow.Cells(1).Value
        RichTextBox1.Size = New Point(908, 330)
        BemerkungGruppe.Size = New Point(920, 362)
        BemerkungGruppe.Location = New Point(12, 175)
        KontakteGruppe.Location = New Point(2000, 1000)
        aenderung = True
        Kontakt = DataGridView1.CurrentRow.Cells(4).Value
        TextRadio()
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox9.Text = TextBox1.Text
        MaskedTextBox4.Text = MaskedTextBox1.Text
        RichTextBox1.Text = RichTextBox2.Text
        '        konteSuchen()
    End Sub

    Private Sub LeerFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerFButton.Click
        Formularloeschen()
    End Sub

    Private Sub LöschenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenButton.Click
        If TextBox1.Text > " " Then
            bsKontakte.RemoveCurrent()
            taKontakte.Update(DsAusbildung)
            '      taKontakte.Update(DsAusbildung.Kontakte)
            bsKontakte.AddNew()
        Else
            MsgBox("Kein Kontakt ausgewählt")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Name_Kontakt = True Then
                NameSuchen()
            Else
                konteSuchen()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            SpeichernButton_Click(sender, e)
        End If

    End Sub

    Private Sub DruckenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenButton.Click
        If TextBox1.Text > " " Then
            namevz = TextBox1.Text
            kAdapter.SelectCommand.CommandText = "Select * from Kontakte where vzname like '%" & TextBox1.Text & "%'  order by Datum"
            bsKontakte.CancelEdit()
            DsAusbildung.Kontakte.Clear()
            kAdapter.Fill(DsAusbildung.Kontakte)
            If bsKontakte.Count > 0 Then
                PeriodeGruppe.Location = New Point(200, 150)
                MaskedTextBox2.Focus()
                If Not IsDBNull(DsAusbildung.Kontakte.Rows(0)("Datum")) Then
                    MaskedTextBox2.Text = DsAusbildung.Kontakte.Rows(0)("Datum").ToString.Substring(0, 10)
                Else
                    MaskedTextBox2.Text = "01.01.2001"
                End If
                If Not IsDBNull(DsAusbildung.Kontakte.Rows(bsKontakte.Count - 1)("Datum").ToString) Then MaskedTextBox3.Text = DsAusbildung.Kontakte.Rows(bsKontakte.Count - 1)("Datum").ToString.Substring(0, 10)
            Else
                MsgBox("Keine Kontakte mit dieser Person")
            End If
        Else
            MsgBox("Kein Kontakt ausgewählt")
            PeriodeGruppe.Location = New Point(2000, 1500)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PeriodeGruppe.Location = New Point(2000, 1050)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim von As String = MaskedTextBox2.Text.Substring(6, 4) + MaskedTextBox2.Text.Substring(3, 2) + MaskedTextBox2.Text.Substring(0, 2) + "0000"
        Dim bis As String = MaskedTextBox3.Text.Substring(6, 4) + MaskedTextBox3.Text.Substring(3, 2) + MaskedTextBox3.Text.Substring(0, 2) + "2359"
        kAdapter.SelectCommand.CommandText = "Select * from Kontakte where  vzname = '" & namevz & "' and (datumt between '" & von & "' and '" & bis & "') order by datumt desc "
        bsKontakte.CancelEdit()
        DsAusbildung.Kontakte.Clear()
        kAdapter.Fill(DsAusbildung.Kontakte)
        If bsKontakte.Count > 0 Then
            Dim XB As New PrintOutKO
            Dim dv As DataView
            Dim t As DataTable
            dv = bsKontakte.List
            '          t = dv.ToTable("Printing", False, "vzname", "datum", "anruf", "personlich", "schriftlich", "email", "emailadresse", "Handynr", "Bemerkung")
            t = dv.ToTable("Printing", False, "vzname", "datum", "kontaktart", "emailadresse", "Handynr", "Bemerkung")
            XB.PrintKontaktBlatt(t)
        Else
            MsgBox("Keine Kontakte in dieser Periode")
        End If
        PeriodeGruppe.Location = New Point(2000, 1050)
    End Sub
    Private Sub TextBox9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.LostFocus
        TextBox1.Text = TextBox9.Text
    End Sub
    Private Sub MaskedTextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox4.LostFocus
        MaskedTextBox1.Text = MaskedTextBox4.Text
        dt = MaskedTextBox1.Text.Substring(6, 4)
        dt += MaskedTextBox1.Text.Substring(3, 2)
        dt += MaskedTextBox1.Text.Substring(0, 2)
        dt += MaskedTextBox1.Text.Substring(11, 2)
        dt += MaskedTextBox1.Text.Substring(14, 2)
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label6.Text = "Suche in den Aktivitäten"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label6.Text = ""
    End Sub

End Class