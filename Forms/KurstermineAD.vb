Public Class KurstermineAD
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim teAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Public Kursbez1 As String
    Public Kursdatum1(50, 3) As String
    Public jt As Integer = 0
    Dim aaa As String

    Private Sub KurstermineAD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Termine". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTermine.Fill(Me.DsAusbildung.Termine)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Teilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Dim kp As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbeginn desc "
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        DbAccess.SafePosition(bsKurse)
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        suchenKurseG()
        Kursbez1 = TextBox13.Text + " " + TextBox14.Text
    End Sub
    Private Sub suchenKurseG()
        Dim kp As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from kurse where Kursbezeichnung like '%" & TextBox13.Text & "%'  "
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Keine Kurskurse mit gesuchtem Kurs vorhanden.")
                DataGridView2.Visible = True
            Case 1
                DbAccess.SafePosition(bsKurse)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView2.Visible = False
                '               ku = TextBox7.Text
                '              fa = TextBox6.Text
                Dim t As System.Data.DataRowView = bsTeilnehmer.Current
                tAdapter.SelectCommand = New OleDb.OleDbCommand
                tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
                tAdapter.SelectCommand.CommandText = "Select * from teilnehmer where kurs = '" & TextBox13.Text & "' and fb ='" & TextBox14.Text & "' order by vzname  "
                bsTeilnehmer.CancelEdit()
                DsAusbildung.Teilnehmer.Clear()
                tAdapter.Fill(DsAusbildung.Teilnehmer)
                For i = 0 To bsTeilnehmer.Count - 1
                    ListBox2.Items.Add(DsAusbildung.Teilnehmer.Rows(i)("vzname").ToString)
                Next
            Case Else
        End Select
    End Sub

    Private Sub Button5Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Drucken.Click
        Dim dt As Date
        Dim te As System.Data.DataRowView = bsTermine.Current
        teAdapter.SelectCommand = New OleDb.OleDbCommand
        teAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        teAdapter.SelectCommand.CommandText = "Select * from Termine where Kursbezeichnung = '" & TextBox13.Text & "' and fahrtbereich ='" & TextBox14.Text & "' order by Datum  "
        bsTermine.CancelEdit()
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        If bsTermine.Count = 0 Then
            MsgBox("Dieser Kurs hat noch keine Anwesenheiten gespeichert.")
            GoTo DruckEnde
        End If
        dt = DsAusbildung.Termine.Rows(0)("Datum").ToString
        Kursdatum1(jt, 0) = dt
        Kursdatum1(jt, 1) = DsAusbildung.Termine.Rows(0)("Thema").ToString
        If DsAusbildung.Termine.Rows(0)("AnzahlEinheiten").ToString > "" Then
            Kursdatum1(jt, 2) = DsAusbildung.Termine.Rows(0)("AnzahlEinheiten").ToString
        Else
            Kursdatum1(jt, 2) = 1
        End If
        For i = 0 To bsTermine.Count - 1
            If dt = DsAusbildung.Termine.Rows(i)("Datum").ToString Then
            Else
                jt += 1
                dt = DsAusbildung.Termine.Rows(i)("Datum").ToString
                If DsAusbildung.Termine.Rows(i)("AnzahlEinheiten").ToString > "" Then
                    Kursdatum1(jt, 2) = DsAusbildung.Termine.Rows(i)("AnzahlEinheiten").ToString
                Else
                    Kursdatum1(jt, 2) = 1
                End If
                Kursdatum1(jt, 1) = DsAusbildung.Termine.Rows(i)("Thema").ToString
                Kursdatum1(jt, 0) = dt
            End If
        Next

        teAdapter.SelectCommand.CommandText = "Select * from Termine where Kursbezeichnung = '" & TextBox13.Text & "' and fahrtbereich ='" & TextBox14.Text & "' order by vzname, Datum, Thema  "
        bsTermine.CancelEdit()
        DsAusbildung.Termine.Clear()
        teAdapter.Fill(DsAusbildung.Termine)
        aaa = bsTermine.Count

        Dim XL As New PrintOutAL
        Dim dv As DataView
        Dim t As DataTable
        dv = bsTermine.List
        t = dv.ToTable("Printing", False, "VZname", "Datum", "Anwesend")
        XL.PrintAnwesendListe(t)
DruckEnde:
        Me.Close()
    End Sub
    Private Sub DataGridView2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView2.MouseClick
        suchenKurseG()
        Kursbez1 = TextBox13.Text + " " + TextBox14.Text

    End Sub
End Class