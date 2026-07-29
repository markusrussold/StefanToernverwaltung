Imports System.IO
Imports System.Text
Public Class Crewformular
    Dim aaa As String
    Dim speicherformular As String = " "
    Dim position As Integer
    Dim buch1 As String
    Dim iii As Integer
    Private Sub Crewformular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        speicherformular = GetSetting("Toernformular", "Pfad", "T")
        TextBox1.Text = speicherformular
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        bsCrewAdressen.Position = 0
        bsCrewAdressen.AddNew()
        bsCrewAdressen.AddNew()
        If RadioButton2.Checked Then
            Label3.Enabled = True
            PictureBox1.Enabled = True
            TextBox15.Enabled = True
            TextBox2.Enabled = True
            GroupBox1.Enabled = True
            TextBox15.Text = Crew.TextBox15.Text
            TextBox2.Text = Crew.TextBox1.Text
            suchen()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim XY As New PrintoutCF
        Dim dv As DataView
        Dim t As DataTable

        If RadioButton1.Checked Then
            dv = bsCrewAdressen.List
            t = dv.ToTable("Printing", False, "Zuname", "Vorname", "Anrede", "Handy", "email", "straße", "plz", "ort", "Reisepassnr", "gebdatum", "gebort", "funk", "segelschein", "nationalitaet")
            XY.PrintCrewFormular(t)
        End If

        If bsCrewAdressen.Count = 1 Then
            dv = bsCrewAdressen.List
            t = dv.ToTable("Printing", False, "Zuname", "Vorname", "Anrede", "Handy", "email", "straße", "plz", "ort", "Reisepassnr", "gebdatum", "gebort", "funk", "segelschein", "nationalitaet")
            XY.PrintCrewAergenzung(t)
        End If
        Label2.Visible = False
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        buton2()
    End Sub
    Private Sub buton2()
        speicherformular = TextBox1.Text
        If RadioButton1.Checked Or bsCrewAdressen.Count = 1 Then
            If Len(speicherformular) < 5 Then
                MsgBox("Speicherort der Datei ist nicht festgelegt! (oder in Extras/Speicherort)")
            Else
                 Dim fOut As StreamWriter = New StreamWriter(speicherformular, False, Encoding.Default)
                Dim Zeilentext(15) As String
                Dim j As Integer
                ' Überschriften
                fOut.WriteLine()
                'Tabelle
                Zeilentext(14) = "                                                             "
                Zeilentext(0) = ";;Crew Aufnahmeformular"
                Zeilentext(1) = "____________________________________________________________________________________________________________"
                If RadioButton1.Checked Then
                    If dsToernverwaltung.CrewAdressen.Rows(0)("Zuname").ToString > "" Then
                        Zeilentext(2) = ";Name*:; ___________________"
                        Zeilentext(2) = Zeilentext(2) + ";;; Geburtsdatum*:;;___________________"
                        Zeilentext(3) = ";Vorname*:; ___________________"
                        Zeilentext(3) = Zeilentext(3) + ";;; Geburtsort/Land*:;;___________________"
                        Zeilentext(4) = ";Strasse*:; ___________________"
                        Zeilentext(4) = Zeilentext(4) + ";;; Reisepass Nr.*:;;___________________"
                        Zeilentext(5) = ";Plz*:; ___________________"
                        Zeilentext(5) = Zeilentext(5) + ";;; Nationalität*:;;___________________"
                        Zeilentext(6) = ";Ort*:; ___________________"
                        Zeilentext(6) = Zeilentext(6) + ";;; Segelschein/Nr.*:;;___________________"
                        Zeilentext(7) = ";Handy:; ___________________"
                        Zeilentext(7) = Zeilentext(7) + ";;; ausgestellt am:;;___________________"
                        Zeilentext(8) = ";e-mail:; ___________________"
                        Zeilentext(8) = Zeilentext(8) + ";;; ausgestellt von:;;___________________"
                        Zeilentext(9) = ";;;;; Funklizenz*:;;___________________"
                    End If
                Else
                    If dsToernverwaltung.CrewAdressen.Rows(0)("Zuname").ToString > "" Then
                        Zeilentext(2) = ";Name*:;" + dsToernverwaltung.CrewAdressen.Rows(0)("Zuname").ToString
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("gebdatum").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("gebdatum").ToString.Substring(0, 10)
                        Zeilentext(2) = Zeilentext(2) + ";;; Geburtsdatum*:;;" + aaa
                    Else
                        Zeilentext(2) = Zeilentext(2) + ";;; Geburtsdatum*:;;___________________"
                    End If
                    '          Zeilentext(2) = ";Name*:; ___________________;; Geburtsdatum*:;;___________________"

                    If dsToernverwaltung.CrewAdressen.Rows(0)("vorname").ToString > "" Then
                        Zeilentext(3) = ";Vorname*:;" + dsToernverwaltung.CrewAdressen.Rows(0)("vorname").ToString
                    Else
                        Zeilentext(3) = ";Vorname*:; ___________________"
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("gebort").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("gebort").ToString
                        Zeilentext(3) = Zeilentext(3) + ";;; Geburtsort/Land*:;;" + aaa
                    Else
                        Zeilentext(3) = Zeilentext(3) + ";;; Geburtsort/Land*:;;___________________"
                    End If
                    '               Zeilentext(3) = ";Vorname*:;___________________;; Geburtsort/Land*:;;___________________"

                    If dsToernverwaltung.CrewAdressen.Rows(0)("straße").ToString > "" Then
                        Zeilentext(4) = ";Strasse*:;" + dsToernverwaltung.CrewAdressen.Rows(0)("straße").ToString
                    Else
                        Zeilentext(4) = ";Strasse*:; ___________________"
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("ReisepassNr").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("ReisepassNr").ToString
                        Zeilentext(4) = Zeilentext(4) + ";;; Reisepass Nr.*:;;" + aaa
                    Else
                        Zeilentext(4) = Zeilentext(4) + ";;; Reisepass Nr.*:;;___________________"
                    End If
                    '                Zeilentext(4) = ";Strasse*:;___________________;; Reisepass Nr.*:;; ___________________"

                    If dsToernverwaltung.CrewAdressen.Rows(0)("plz").ToString > "" Then
                        Zeilentext(5) = ";Plz*:;" + dsToernverwaltung.CrewAdressen.Rows(0)("plz").ToString
                    Else
                        Zeilentext(5) = ";Plz*:; ___________________"
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("nationalitaet").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("nationalitaet").ToString
                        Zeilentext(5) = Zeilentext(5) + ";;; Nationalität*:;;" + aaa
                    Else
                        Zeilentext(5) = Zeilentext(5) + ";;; Nationalität*:;;___________________"
                    End If
                    '               Zeilentext(5) = ";Plz:*; ___________________;; Nationalität*:;;___________________"

                    If dsToernverwaltung.CrewAdressen.Rows(0)("ort").ToString > "" Then
                        Zeilentext(6) = ";Ort*:;" + dsToernverwaltung.CrewAdressen.Rows(0)("ort").ToString
                    Else
                        Zeilentext(6) = ";Ort*:; ___________________"
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString
                        Zeilentext(6) = Zeilentext(6) + ";;; Segelschein/Nr.*:;;" + aaa
                    Else
                        Zeilentext(6) = Zeilentext(6) + ";;; Segelschein/Nr.*:;;___________________"
                    End If
                    '               Zeilentext(6) = ";Ort:*; ___________________;; Segelschein/Nr.:*;;___________________"

                    If dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString > "" Then
                        Zeilentext(7) = ";Handy:;" + dsToernverwaltung.CrewAdressen.Rows(0)("Handy").ToString
                    Else
                        Zeilentext(7) = ";Handy:; ___________________"
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinDatum").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinDatum").ToString
                        Zeilentext(7) = Zeilentext(7) + ";;; ausgestellt am:;;" + aaa
                    Else
                        Zeilentext(7) = Zeilentext(7) + ";;; ausgestellt am:;;___________________"
                    End If
                    '              Zeilentext(7) = ";Handy:; ___________________;; ausgestellt am:;; ___________________"

                    If dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString > "" Then
                        Zeilentext(8) = ";e-mail:;" + dsToernverwaltung.CrewAdressen.Rows(0)("email").ToString
                    Else
                        Zeilentext(8) = ";e-mail:; ___________________"
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinVerband").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("SegelscheinVerband").ToString
                        Zeilentext(8) = Zeilentext(8) + ";;; ausgestellt von:;;" + aaa
                    Else
                        Zeilentext(8) = Zeilentext(8) + ";;; ausgestellt von:;;___________________"
                    End If
                    '                Zeilentext(8) = ";e-mail:; ___________________;; ausgestellt von:;; ___________________"

                    If dsToernverwaltung.CrewAdressen.Rows(0)("funk").ToString > "" Then
                        aaa = dsToernverwaltung.CrewAdressen.Rows(0)("funk").ToString
                        Zeilentext(9) = ";;;; Funklizenz*:;;" + aaa
                    Else
                        Zeilentext(9) = ";;;;; Funklizenz*:;;___________________"
                    End If

                End If
                '              Zeilentext(9) = ";;;; Funklizenz:*;; ___________________"
                Zeilentext(10) = Zeilentext(1)
                Zeilentext(11) = ";Alle Angaben werden elektronisch gespeichert; die mit * bezeichnete Daten werden in der Crewliste"
                Zeilentext(12) = ";an die Charterfirma und an ausländische Einklarierungsbehörde übergeben."
                For j = 0 To 10
                    fOut.Write(Zeilentext(14))
                    fOut.WriteLine()
                    fOut.Write(Zeilentext(14))
                    fOut.WriteLine()
                    fOut.Write(Zeilentext(14))
                    fOut.WriteLine()
                    fOut.Write(Zeilentext(14))
                    fOut.WriteLine()
                    fOut.Write(Zeilentext(j))
                    fOut.WriteLine()
                Next
                For j = 0 To 20
                    fOut.Write(Zeilentext(14))
                    fOut.WriteLine()
                Next
                fOut.Write(Zeilentext(11))
                fOut.WriteLine()
                fOut.Write(Zeilentext(12))
                fOut.WriteLine()
                fOut.Close()
                Label2.Visible = True
            End If
        End If
        Me.Close()
    End Sub
    Private Sub RadioButton1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.GotFocus
        Label3.Enabled = False
        PictureBox1.Enabled = False
        TextBox15.Enabled = False
        GroupBox1.Enabled = False
        DataGridView1.Visible = False
    End Sub
    Private Sub RadioButton2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.GotFocus
        Label3.Enabled = True
        PictureBox1.Enabled = True
        TextBox15.Enabled = True
        TextBox2.Enabled = True
        GroupBox1.Enabled = True
        '      DataGridView1.Visible = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        GroupBox1.Text = "Crew auswählen mit Doppelklick"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox15.Text = RTrim(TextBox15.Text)
        If TextBox15.Text > "  " Then
            If TextBox2.Text > " " Then
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen where zuname = '" & TextBox15.Text & "' and vorname = '" & TextBox2.Text & "' order by zuname"
            Else
                If Len(TextBox15.Text) > 1 Then
                    If Mid(TextBox15.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox15.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname like '%" & TextBox15.Text & "%' order by zuname"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from crewadressen where mid(zuname,1,1) like '%" & TextBox15.Text & "%' order by zuname"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
        End If
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        Select Case bsCrewAdressen.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by zuname"
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                xAdapter.Fill(dsToernverwaltung.CrewAdressen)
                '               Formularloeschen()
                DataGridView1.Visible = True
                DataGridView1.Location = New Point(10, 20)
            Case 1
                bsCrewAdressen.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsCrewAdressen.Position = position
                DataGridView1.Visible = True
                '                DataGridView1.Location = New Point(10, 20)
                DataGridView1.Focus()
        End Select
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

    Private Sub TextBox15_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox15.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

    Private Sub TextBox15_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.LostFocus
        If bsCrewAdressen.Count <= 1 Then
            suchen()
        End If
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        suchen()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class