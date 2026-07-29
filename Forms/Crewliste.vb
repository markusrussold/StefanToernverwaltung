Public Class Crewliste
    Public Freischaltung As String
    Public toername As String
    Public aaa As String
    Public pii As Integer
    Public kk As Integer
    Dim x As New CheckKey
    Public ok As Boolean
    Dim buch1 As String
    Dim position As Integer
    Dim iii As Integer
    Dim land As String
    Private Sub Crewliste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.ToernKalkulation". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernKalkulation.Fill(Me.dsToernverwaltung.ToernKalkulation)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernname.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Freischaltung = GetSetting("toern", "Pfad", "T")

        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung

        If Menü.FreischaltZiffer = 1 Or Menü.FreischaltZiffer = 3 Or Menü.FreischaltZiffer = 4 Then
            ok = True
        Else
            ok = False
            Label2.Visible = True
        End If


        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from toernname"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        pAdapter.Fill(dsToernverwaltung.Toernname)
        DbAccess.SafePosition(bsToernname)
        bsToernname.AddNew()

        With DataGridView1
            .Columns(0).Width = 250

        End With
             TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub

    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")

        Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsToernname.Current
        Dim ptAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpt As System.Data.DataRowView = bsCrewAdressen.Current
         DataGridView1.Visible = True
        DataGridView1.Visible = True
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xtAdapter.Fill(dsToernverwaltung.Temp)
         pii = 0
        bsTemp.AddNew()

        TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    buch1 = Mid(TextBox1.Text, 1, 1).ToUpper
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & TextBox1.Text & "%'  order by toernbezeichnung"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where mid( toernbezeichnung,1,1) like '%" & TextBox1.Text & "%' order by toernbezeichnung"
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
                xAdapter.Fill(dsToernverwaltung.Toernname)
            Case 1
                DbAccess.SafePosition(bsToernname)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                toername = TextBox1.Text
                bsTemp.AddNew()
                If ok Then
                    dsToernverwaltung.Temp.Rows(0)("Feld1") = dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString
                Else
                    dsToernverwaltung.Temp.Rows(0)("Feld1") = "NN"
                End If
                dsToernverwaltung.Temp.Rows(0)("Feld2") = dsToernverwaltung.Toernname.Rows(0)("Datumvon").ToString
                dsToernverwaltung.Temp.Rows(0)("Feld3") = dsToernverwaltung.Toernname.Rows(0)("Datumbis").ToString
                dsToernverwaltung.Temp.Rows(0)("Feld4") = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                dsToernverwaltung.Temp.Rows(0)("Feld5") = dsToernverwaltung.Toernname.Rows(0)("Route").ToString
                '              taTemp.Update(dsToernverwaltung.Temp)
                kk = 0
                If (dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString) > "" Then
                    kk = 1
                    crew(dsToernverwaltung.Toernname.Rows(0)("Skipper").ToString)
                End If
                DataGridView1.Visible = False
                Button1.Focus()
                Dim pos2 As Single
                If Len(dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina").ToString) > 2 Then
                    pos2 = InStr(dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina").ToString, "/")
                    land = dsToernverwaltung.Toernname.Rows(0)("Ausgangsmarina").ToString.Substring(0, pos2 - 1)
                Else
                    MsgBox("Beim Törn ist die Marina unbekannt.  -  Abbruch")
                    Close()
                End If
                radiobutons()
                kalkSuchen()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
        End Select
    End Sub
    Private Sub positionieren()
        iii = bsToernname.Count - 1
        For Me.pii = 0 To iii
            aaa = Mid(dsToernverwaltung.Toernname.Rows(pii)("toernbezeichnung").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = pii
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub
    Private Sub kalkSuchen()

        Dim pkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rpk As System.Data.DataRowView = bsToernKalkulation.Current

        pkAdapter.SelectCommand = New OleDb.OleDbCommand
        pkAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pkAdapter.SelectCommand.CommandText = "Select * from toernkalkulation where toern like '%" & TextBox1.Text & "%'"
        bsToernKalkulation.CancelEdit()
        dsToernverwaltung.ToernKalkulation.Clear()
        pkAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        DbAccess.SafePosition(bsToernKalkulation)
    End Sub
    Private Sub radiobutons()
        Select Case land
            Case "Griechenland"
                RadioGriechisch.Checked = True
            Case "Türkei"
                RadioTürkisch.Checked = True
            Case "Italien"
                RadioItaliano.Checked = True
            Case "Spanien"
                RadioSpanisch.Checked = True
            Case "Cuba"
                RadioSpanisch.Checked = True
            Case "Mexico"
                RadioSpanisch.Checked = True
            Case "Slowenien"
                RadioAdria.Checked = True
            Case "Slovenien"
                RadioAdria.Checked = True
            Case "Kroatien"
                RadioAdria.Checked = True
            Case "Frankreich"
                RadioFranzoesisch.Checked = True
            Case "Schweden"
                Radioschwedisch.Checked = True
            Case "Deutschland"
                RadioDeutsch.Checked = True
        End Select

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        Dim iii As Integer
        suchen()
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from tc where toern =  '" & toername & "' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        DbAccess.SafePosition(bsTC)
        iii = bsTC.Count - 1
        kk += 1
        For Me.pii = 0 To iii
            crew(dsToernverwaltung.TC.Rows(pii)("VZName").ToString)
        Next
        Ausgabe()

    End Sub

    Private Sub crew(ByVal nm)
        ' in Crewadressen - toernnr den Törnname vorübergehend speichern
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname = '" & nm & "' "
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        If kk = 1 Then
            dsToernverwaltung.Temp.Rows(pii)("Feld9") = dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString
            dsToernverwaltung.Temp.Rows(pii)("Feld14") = dsToernverwaltung.CrewAdressen.Rows(0)("funk").ToString
            taTemp.Update(dsToernverwaltung.Temp)
        End If
        Select Case bsCrewAdressen.Count
            Case 1
                DbAccess.SafePosition(bsCrewAdressen)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bsTemp.AddNew()
                If ok Then
                    dsToernverwaltung.Temp.Rows(pii + kk)("Feld1") = dsToernverwaltung.CrewAdressen.Rows(0)("Zuname").ToString
                    dsToernverwaltung.Temp.Rows(pii + kk)("Feld2") = dsToernverwaltung.CrewAdressen.Rows(0)("Vorname").ToString
                Else
                    dsToernverwaltung.Temp.Rows(pii + kk)("Feld1") = "Name"
                    dsToernverwaltung.Temp.Rows(pii + kk)("Feld2") = "Vorname"
                End If
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld3") = dsToernverwaltung.CrewAdressen.Rows(0)("Straße").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld4") = dsToernverwaltung.CrewAdressen.Rows(0)("Plz").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld5") = dsToernverwaltung.CrewAdressen.Rows(0)("ort").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld6") = dsToernverwaltung.CrewAdressen.Rows(0)("Reisepassnr").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld7") = dsToernverwaltung.CrewAdressen.Rows(0)("Gebdatum").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld8") = dsToernverwaltung.CrewAdressen.Rows(0)("Gebort").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld9") = dsToernverwaltung.CrewAdressen.Rows(0)("Segelschein").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld10") = dsToernverwaltung.CrewAdressen.Rows(0)("nationalitaet").ToString
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld11") = " "
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld12") = " "
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld13") = " "
                dsToernverwaltung.Temp.Rows(pii + kk)("Feld14") = dsToernverwaltung.CrewAdressen.Rows(0)("funk").ToString
                Select Case bsToernKalkulation.Count
                    Case 1
                        If dsToernverwaltung.ToernKalkulation.Rows(0)("HinFlugNr").ToString > "" And dsToernverwaltung.ToernKalkulation.Rows(0)("rueFlugNr").ToString > "" Then dsToernverwaltung.Temp.Rows(pii + kk)("Feld11") = dsToernverwaltung.ToernKalkulation.Rows(0)("HinFlugNr").ToString + "/" + dsToernverwaltung.ToernKalkulation.Rows(0)("RueFlugNr").ToString
                        If dsToernverwaltung.ToernKalkulation.Rows(0)("HinFlugDatum").ToString > "" And dsToernverwaltung.ToernKalkulation.Rows(0)("rueFlugDatum").ToString > "" Then dsToernverwaltung.Temp.Rows(pii + kk)("Feld12") = SafeData.FormatDateDe(dsToernverwaltung.ToernKalkulation.Rows(0)("HinFlugDatum")) + "/" + SafeData.FormatDateDe(dsToernverwaltung.ToernKalkulation.Rows(0)("RueFlugDatum"))
                        If dsToernverwaltung.ToernKalkulation.Rows(0)("Flughafen").ToString > "" Then dsToernverwaltung.Temp.Rows(pii + kk)("Feld13") = dsToernverwaltung.ToernKalkulation.Rows(0)("Flughafen").ToString
                End Select
                taTemp.Update(dsToernverwaltung.Temp)
            Case Else
                kk -= 1
        End Select
    End Sub

    Private Sub Ausgabe()
        Dim XL As New PrintoutCL
        Dim dv As DataView
        Dim t As DataTable
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsTemp.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsTemp.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        xAdapter.Fill(dsToernverwaltung.Temp)
        DbAccess.SafePosition(bsTemp)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld7", "Feld8", "Feld6", "Feld9", "Feld3", "Feld4", "Feld5", "Feld10", "Feld11", "Feld12", "Feld13", "Feld14")
        XL.PrintCrewListe(t)
        Me.Close()
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        suchen()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        suchen()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

    Private Sub RadioDeutsch_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioDeutsch.CheckedChanged

    End Sub
End Class