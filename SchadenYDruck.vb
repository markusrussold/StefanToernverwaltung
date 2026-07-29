Imports System.IO
Public Class SchadenYDruck
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim sAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Dim bbb As String
    Dim verz As String = Environment.CurrentDirectory
    Dim overwrite As Boolean = True
    Private Sub SchadenYDruck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsVersicherung.Versicherter". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taVersicherter.Fill(Me.dsVersicherung.Versicherter)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taSchaden.Fill(Me.dsVersicherung.Schaden)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Dim rr As System.Data.DataRowView = bsToernname.Current
        Dim rs As System.Data.DataRowView = bsSchaden.Current
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from Schaden  "
        bsSchaden.CancelEdit()
        dsVersicherung.Schaden.Clear()
        sAdapter.Fill(dsVersicherung.Schaden)
        bsSchaden.AddNew()
        aaa = bsSchaden.Count

        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.AddNew()
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
        bsVersicherter.CancelEdit()
        dsVersicherung.Versicherter.Clear()
        tAdapter.Fill(dsVersicherung.Versicherter)
        If bsVersicherter.Count = 1 Then
            EinKunde()
        End If
        ButtonDrucken.Enabled = False
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsVersicherter.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        '       TextBox78.Text = RTrim(TextBox78.Text)
        If TextBox7.Text > "  " Then
            If Len(TextBox7.Text) > 1 Then
                If Mid(TextBox7.Text, 2, 1) = "*" Then
                    tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
                Else
                    tAdapter.SelectCommand.CommandText = "Select * from Versicherter where Polizze like '%" & TextBox7.Text & "%'  order by Polizze"
                End If
            Else
                tAdapter.SelectCommand.CommandText = "Select * from Versicherter where Mid(Polizze,1,1) like '%" & TextBox7.Text & "%'  order by Polizze"
            End If
        Else
            tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
        End If
        bsVersicherter.CancelEdit()
        dsVersicherung.Versicherter.Clear()
        tAdapter.Fill(dsVersicherung.Versicherter)
        Select Case bsVersicherter.Count
            Case 0
                MsgBox("Kein Versicherter mit angegebenen Buchstabenkombination vorhanden")
                tAdapter.SelectCommand.CommandText = "Select * from Versicherter order by Polizze"
                tAdapter.Fill(dsVersicherung.Versicherter)
            Case 1
                EinKunde()
            Case Else
                bsVersicherter.Position = 0
        End Select
    End Sub
    Private Sub EinKunde()
        bsVersicherter.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        bbb = SafeData.FormatDateDe(dsVersicherung.Versicherter.Rows(0)("Abschlussdatum"))
        aaa = SafeData.FormatDateDe(dsVersicherung.Versicherter.Rows(0)("Gueltigbis"))
        Label21.Text = bbb + " bis " + aaa
        TextBox13.Focus()
    End Sub
    Private Sub suchenToern()
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & TextBox13.Text & "' "
        If TextBox13.Text > "  " Then
            If IsNumeric(TextBox13.Text) And Len(TextBox13.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where year(DAtumvon) like '%" & TextBox13.Text & "%'  order by toernbezeichnung"
            Else
                If Len(TextBox13.Text) > 1 Then
                    If Mid(TextBox13.Text, 2, 1) = "*" Then
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox13.Text & "%'  order by toernbezeichnung"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where Mid(toernbezeichnung,1,1) like '%" & TextBox13.Text & "%'  order by toernbezeichnung"
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
                MsgBox("Kein Törn mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
            Case 1
                bsToernname.Position = 0
                sucheSchaden()
            Case Else
        End Select
    End Sub
    Private Sub sucheSchaden()
        Dim rs As System.Data.DataRowView = bsSchaden.Current
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Versicherung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from Schaden where Polizze = '" & TextBox7.Text & "' and Törn = '" & TextBox13.Text & "'  "
        bsSchaden.CancelEdit()
        dsVersicherung.Schaden.Clear()
        sAdapter.Fill(dsVersicherung.Schaden)
        Select Case bsSchaden.Count
            Case 0
                bsSchaden.AddNew()
            Case 1
                ButtonDrucken.Enabled = True
                Select Case TextBox1.Text
                    Case 1
                        Label2.Text = "Haftpflicht Versicherung"
                    Case 2
                        Label2.Text = "Kaution Versicherung"
                    Case 3
                        Label2.Text = "Rücktritt Versicherung"
                End Select
            Case Else
                bsSchaden.Position = 0
                MsgBox("Von dem Törn  " & Convert.ToString(TextBox13.Text) & " ist noch kein Schaden erfasst.")
        End Select
        TextBox13.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        suchenToern()
    End Sub
    Private Sub TextBox13_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox13.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenToern()
        End If
    End Sub

    Private Sub ButtonDrucken_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDrucken.Click
        Dim Xs As New PrintOutSch
        Dim dv As DataView
        Dim t As DataTable
        Label31.Visible = True
        dv = bsSchaden.List
        t = dv.ToTable("Printing", False, "Polizze", "törn", "schadensnummer", "schadensbetrag", "bemerkung", "bearbeiter", "bea-mail", "bea-telefon", "schadensort", "datum", "Versicherungsart", "schadensbeschreibung", "wie", "r1", "r2", "r3", "belegkaution", "belegrep", "belegdieb", "Hafenkapitean", "Versicherungcharter", "Versicherunggegner", "chartermeldung", "skizze", "Segelfuehrung", "windrichtung", "motoranaus", "kurseigen", "kursgegner", "zeugen", "arztbesch", "flugstorno", "charterstorno", "was", "uhrzeit", "foto1", "foto2", "foto3", "schadensart")
        Xs.PrintVersicherungsSchaden(t)
        Dokumente()
        Label29.Visible = True
    End Sub
    Private Sub schadenmeldung()
        Dim pol As String
        Dim Zeichen1 As String
        Dim Zeichen2 As String
        Select Case TextBox1.Text
            Case 1
                bbb = "Haftpflicht Versicherung"
                pol = dsVersicherung.Schaden.Rows(0)("polizze")
                RichTextBox1.Text = "Schadensmeldung" + vbCrLf + "Polizze: " + pol + vbCrLf + bbb + vbCrLf + vbCrLf _
                         + "Ort: " + dsVersicherung.Schaden.Rows(0)("schadensort") + vbCrLf
                Zeichen1 = dsVersicherung.Schaden.Rows(0)("datum")
                If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("schadensbetrag")) Then
                    Zeichen2 = dsVersicherung.Schaden.Rows(0)("schadensbetrag")
                Else
                    Zeichen2 = "?"
                End If
                RichTextBox1.Text = RichTextBox1.Text + "Datum: " + Zeichen1 + vbCrLf _
                     + "Schadenshöhe €: " + Zeichen2 + vbCrLf
                RichTextBox1.Text = RichTextBox1.Text + "Schadensbeschreibung: " + dsVersicherung.Schaden.Rows(0)("schadensbeschreibung") + vbCrLf
                RichTextBox1.Text = RichTextBox1.Text + "Bemerkung:" + vbCrLf + dsVersicherung.Schaden.Rows(0)("bemerkung") + vbCrLf _
                    + "Wie: " + dsVersicherung.Schaden.Rows(0)("wie") + vbCrLf + "Segelführung: " + dsVersicherung.Schaden.Rows(0)("segelfuehrung") + vbCrLf
                Zeichen1 = dsVersicherung.Schaden.Rows(0)("windrichtung")
                RichTextBox1.Text = RichTextBox1.Text + "Windrichtung: " + Zeichen1 + vbCrLf + "Motor: " + dsVersicherung.Schaden.Rows(0)("motoranaus") + vbCrLf
                Zeichen1 = dsVersicherung.Schaden.Rows(0)("kurseigen")
                Zeichen2 = dsVersicherung.Schaden.Rows(0)("kursgegner")
                RichTextBox1.Text = RichTextBox1.Text + "Eigener Kurs: " + Zeichen1 + vbCrLf + "Kurs Gegner: " + Zeichen2 + vbCrLf _
                + "Zeigen: " + dsVersicherung.Schaden.Rows(0)("zeugen") + vbCrLf + "Was: " + dsVersicherung.Schaden.Rows(0)("was") + vbCrLf _
                + "Uhrzeit: " + dsVersicherung.Schaden.Rows(0)("uhrzeit")
                Dim writer As TextWriter = New StreamWriter(aaa + "Schadensmeldung.txt")
                writer.Write(RichTextBox1.Text)
                writer.Close()
            Case 2
                bbb = "Kaution Versicherung"
            Case 3
                bbb = "Rücktritt Versicherung"
        End Select

    End Sub
    '
    '                                                              Dokumente kopieren
    '
    Private Sub Dokumente()
        Prüfen()
        Foto()
        Crewliste()
        Schein()
        CharterVertrag()
        Schadensschilderung()
        Select Case TextBox1.Text
            Case 1
                '                   Haftpflicht Versicherung
                UnfallberichtSkizze()
                Hafenkapitaen()
                Versicherungeig()
                Versicherunggeg()
                SchadensmeldungCharter()
            Case 2
                '                    Kaution Versicherung
                BelegEinbehalt()
                RepKosten()
                Diebstahl()
            Case 3
                '                   Rücktritt Versicherung
                Arzt()
                FlugStorno()
                CharterStorno()
        End Select

    End Sub
    Private Sub Foto()
        Label13.Text = "Fotos fehlen"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("foto1")) Then
            If dsVersicherung.Schaden.Rows(0)("foto1") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("foto1"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("foto1"), aaa + "Foto1.jpg", overwrite)
                    Label13.Text = "Foto"
                    Label5.Visible = True
                End If
            End If
        End If

        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("foto2")) Then
            If dsVersicherung.Schaden.Rows(0)("foto2") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("foto2"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("foto2"), aaa + "Foto2.jpg", overwrite)
                    Label13.Text = "Foto"
                    Label5.Visible = True
                End If
            End If
        End If

        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("foto3")) Then
            If dsVersicherung.Schaden.Rows(0)("foto3") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("foto3"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("foto3"), aaa + "Foto3.jpg", overwrite)
                    Label13.Text = "Foto"
                    Label5.Visible = True
                End If
            End If
        End If
        Label13.Visible = True
    End Sub
    Private Sub Crewliste()
        Label14.Text = "Crewliste fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("crewliste")) Then
            If dsVersicherung.Schaden.Rows(0)("crewliste") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("crewliste"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("crewliste"), aaa + "Crewliste.pdf", overwrite)
                    Label14.Text = "Crewliste"
                    Label6.Visible = True
                End If
            End If
        End If
        Label14.Visible = True
    End Sub
    Private Sub CharterVertrag()
        Label15.Text = "Chartervertrag fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Chartervertrag")) Then
            If dsVersicherung.Schaden.Rows(0)("Chartervertrag") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Chartervertrag"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Chartervertrag"), aaa + "Chartervertrag.pdf", overwrite)
                    Label15.Text = "Chartervertrag"
                    Label7.Visible = True
                End If
            End If
        End If
        Label15.Visible = True
    End Sub
    Private Sub Schein()
        Dim scheina As String
        Label16.Text = "Bootsführerschein fehlt"

        scheina = GetSetting("schein", "Pfad", "T")
        If scheina > "" Then
            If scheina.Substring(Len(scheina) - 3, 3) = "pdf" Then
                My.Computer.FileSystem.CopyFile(scheina, aaa + "Bootsführerschein.pdf", overwrite)
            Else
                My.Computer.FileSystem.CopyFile(scheina, aaa + "Bootsführerschein.jpg", overwrite)
            End If
            Label16.Text = "Bootsführerschein"
            Label8.Visible = True
        End If
        Label16.Visible = True
    End Sub
    Private Sub Schadensschilderung()

    End Sub
    Private Sub Hafenkapitaen()
        Label17.Text = "Beleg des Hafenkapitäns fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Hafenkapitean")) Then
            If dsVersicherung.Schaden.Rows(0)("Hafenkapitean") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Hafenkapitean"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Hafenkapitean"), aaa + "Hafenkapitän.pdf", overwrite)
                    Label17.Text = "Beleg des Hafenkapitäns"
                    Label9.Visible = True
                End If
            End If
        End If
        Label17.Visible = True
    End Sub
    Private Sub Diebstahl()
        Label24.Text = "Beleg der Diebstahl fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("belegdieb")) Then
            If dsVersicherung.Schaden.Rows(0)("BelegDieb") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("BelegDieb"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("BelegDieb"), aaa + "BelegDiebstahl.pdf", overwrite)
                    Label24.Text = "Diebstahl"
                    Label11.Visible = True
                End If
            End If
        End If
        Label24.Visible = True
    End Sub
    Private Sub Versicherungeig()
        Label22.Text = "Pollize eigener Bootsversicherung fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Versicherungcharter")) Then
            If dsVersicherung.Schaden.Rows(0)("Versicherungcharter") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Versicherungcharter"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Versicherungcharter"), aaa + "Pollize eigener Bootsversicherung.pdf", overwrite)
                    Label22.Text = "Pollize eigener Bootsversicherung"
                    Label10.Visible = True
                End If
            End If
        End If
        Label22.Visible = True
    End Sub
    Private Sub Versicherunggeg()
        Label24.Text = "Pollize fremder Bootsversicherung fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("VersicherungGegner")) Then
            If dsVersicherung.Schaden.Rows(0)("VersicherungGegner") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("VersicherungGegner"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("VersicherungGegner"), aaa + "Pollize fremder Bootsversicherung.pdf", overwrite)
                    Label24.Text = "Pollize fremder Bootsversicherung"
                    Label11.Visible = True
                End If
            End If
        End If
        Label24.Visible = True
    End Sub
    Private Sub SchadensmeldungCharter()
        Label28.Text = "Schadensmeldung an Vercharterer fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Chartermeldung")) Then
            If dsVersicherung.Schaden.Rows(0)("Chartermeldung") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Chartermeldung"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Chartermeldung"), aaa + "Schadensmeldung Vercharterer.pdf", overwrite)
                    Label4.Text = "Schadensmeldung an Vercharterer"
                    Label11.Visible = True
                End If
            End If
            Label28.Visible = True
        End If
    End Sub
    Private Sub UnfallberichtSkizze()
        Label25.Text = "Unfallskizze fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Skizze")) Then
            If dsVersicherung.Schaden.Rows(0)("Skizze") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Skizze"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Skizze"), aaa + "Unfallskizze.pdf", overwrite)
                    Label24.Text = "Unfallskizze"
                    Label12.Visible = True
                End If
            End If
        End If
        Label25.Visible = True
    End Sub
    Private Sub BelegEinbehalt()
        Label22.Text = "Beleg für Einbehalt der Kaution fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("belegkaution")) Then
            If dsVersicherung.Schaden.Rows(0)("BelegKaution") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("BelegKaution"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("BelegKaution"), aaa + "BelegKaution.pdf", overwrite)
                    Label22.Text = "Einbehalt der Kaution"
                    Label10.Visible = True
                End If
            End If
        End If
        Label22.Visible = True
    End Sub
    Private Sub RepKosten()
        Label17.Text = "Beleg für Reparaturkosten fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("belegrep")) Then
            If dsVersicherung.Schaden.Rows(0)("BelegRep") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("BelegRep"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("BelegRep"), aaa + "ReparaturKosten.pdf", overwrite)
                    Label17.Text = "Reparatur Kosten"
                    Label9.Visible = True
                End If
            End If
        End If
        Label17.Visible = True
    End Sub
    Private Sub Arzt()
        Label24.Text = "Arztbestätigung fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Arztbesch")) Then
            If dsVersicherung.Schaden.Rows(0)("Arztbesch") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Arztbesch"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Arztbesch"), aaa + "Arztbestätigung.pdf", overwrite)
                    Label24.Text = "Arztbestätigung"
                    Label11.Visible = True
                End If
            End If
        End If
        Label24.Visible = True
    End Sub
    Private Sub FlugStorno()
        Label17.Text = "Beleg Flugticket/Storno fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Flugstorno")) Then
            If dsVersicherung.Schaden.Rows(0)("Flugstorno") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Flugstorno"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Flugstorno"), aaa + "Flugstorno.pdf", overwrite)
                    Label17.Text = "Beleg Flugticket/Storno"
                    Label9.Visible = True
                End If
            End If
        End If
        Label17.Visible = True
    End Sub
    Private Sub CharterStorno()
        Label22.Text = "Beleg Charter Storno fehlt"
        If Not IsDBNull(dsVersicherung.Schaden.Rows(0)("Charterstorno")) Then
            If dsVersicherung.Schaden.Rows(0)("Charterstorno") > " " Then
                If My.Computer.FileSystem.FileExists(Trim$(dsVersicherung.Schaden.Rows(0)("Charterstorno"))) Then
                    My.Computer.FileSystem.CopyFile(dsVersicherung.Schaden.Rows(0)("Charterstorno"), aaa + "Charter Storno.pdf", overwrite)
                    Label22.Text = "Charter Storno"
                    Label10.Visible = True
                End If
            End If
        End If
        Label22.Visible = True
    End Sub
    Private Sub Prüfen()
        aaa = verz + "\Schaden\" + TextBox13.Text
        If My.Computer.FileSystem.FileExists(verz + "\Schaden\" + TextBox13.Text) Then
        Else
            My.Computer.FileSystem.CreateDirectory(aaa)
        End If
        aaa = aaa + "\"
        Label26.Text = aaa
        Label26.Visible = True
        schadenmeldung()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
End Class