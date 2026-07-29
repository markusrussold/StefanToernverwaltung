Public Class AktivStatistik
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, _
    ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim vAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Dim mann As Single = 0
    Dim frau As Single = 0
    Dim sfvs As Single = 0
    Dim gaeste As Single = 0
    Public Schritt As String = "Name"
    Private Sub AktivStatistik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taVeranstaltungen.Fill(Me.DsAusbildung.Veranstaltungen)
        Me.taVeranstalTeilnehmer.Fill(Me.DsAusbildung.VeranstalTeilnehmer)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
     
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        TempLoeschen()
        ButtonDrucken.Enabled = False
        Label7.Text = ""
        Label8.Text = ""
        Label6.Text = ""
        Label10.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub TempLoeschen()
        Dim p As System.Data.DataRowView = bsTemp.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        '        For i = 0 To bsTemp.Count - 1
        ' bsTemp.RemoveCurrent()
        ' taTemp.Update(dsToernverwaltung)
        ' Next

        mann = 0
        frau = 0
        sfvs = 0
        gaeste = 0

    End Sub
    Private Sub ButtonStarten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStarten.Click
        TempLoeschen()
        If TextBox1.Text > " " And TextBox2.Text > " " Then
        Else
            MsgBox("Eingabe Jahrgänge fehlt.")
            GoTo ende
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim ij As Integer
        Dim v As System.Data.DataRowView = bsCrewAdressen.Current
        vAdapter.SelectCommand = New OleDb.OleDbCommand
        vAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        vAdapter.SelectCommand.CommandText = "Select * from Veranstaltungen where year(datum) >= '" & TextBox1.Text & "' AND year(datum) <= '" & TextBox2.Text & "' order by datum"
        bsVeranstaltungen.CancelEdit()
        DsAusbildung.Veranstaltungen.Clear()
        vAdapter.Fill(DsAusbildung.Veranstaltungen)
        bsVeranstaltungen.Position = 0
        For i = 0 To bsVeranstaltungen.Count - 1
            aaa = DsAusbildung.Veranstaltungen.Rows(i)("Veranstaltung").ToString
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from VeranstalTeilnehmer where Veranstaltung = '" & aaa & "' "
            bsVeranstalTeilnehmer.CancelEdit()
            DsAusbildung.VeranstalTeilnehmer.Clear()
            tAdapter.Fill(DsAusbildung.VeranstalTeilnehmer)
            bsVeranstalTeilnehmer.Position = 0
            For j = 0 To bsVeranstalTeilnehmer.Count - 1
                aaa = DsAusbildung.VeranstalTeilnehmer.Rows(j)("vzname").ToString
                Dim c As System.Data.DataRowView = bsCrewAdressen.Current
                cAdapter.SelectCommand = New OleDb.OleDbCommand
                cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                cAdapter.SelectCommand.CommandText = "Select * from Crewadressen where vzname = '" & aaa & "' "
                dsToernverwaltung.CrewAdressen.Clear()
                cAdapter.Fill(dsToernverwaltung.CrewAdressen)
                bsCrewAdressen.Position = 0
                bsTemp.AddNew()
                Feld6.Text = "False"
                If bsCrewAdressen.Count = 1 Then
                    If Not DBNull.Value.Equals(dsToernverwaltung.CrewAdressen.Rows(0)("anrede")) Then
                        If dsToernverwaltung.CrewAdressen.Rows(0)("anrede") = "Frau" Then
                            frau += 1
                        Else
                            mann += 1
                        End If
                    End If
                    If dsToernverwaltung.CrewAdressen.Rows(0)("Clubmitglied") Then
                        sfvs += 1
                        Feld6.Text = dsToernverwaltung.CrewAdressen.Rows(0)("Clubmitglied").ToString
                    Else
                        gaeste += 1
                    End If
                Else
                    gaeste += 1
                End If
                ij = i + j
                Feld1.Text = DsAusbildung.Veranstaltungen.Rows(i)("Veranstaltung").ToString
                Feld2.Text = DsAusbildung.VeranstalTeilnehmer.Rows(j)("vzname").ToString
                Feld3.Text = DsAusbildung.Veranstaltungen.Rows(i)("Ort1").ToString
                Feld4.Text = DsAusbildung.Veranstaltungen.Rows(i)("Datum").ToString.Substring(0, 10)
                aaa = DsAusbildung.Veranstaltungen.Rows(i)("Datum").ToString.Substring(0, 10)
                Feld5.Text = aaa.Substring(6, 4) + aaa.Substring(3, 2) + aaa.Substring(0, 2)
                taTemp.Update(dsToernverwaltung.Temp)
                '            Next
                '            Next
                bsTemp.AddNew()
                taTemp.Update(dsToernverwaltung.Temp)
                ProgressBarM.Minimum = 0
                ProgressBarM.Maximum = mann + frau
                ProgressBarM.Step = 0
                ProgressBarM.Value = mann
                ProgressBarM.PerformStep()
                Label8.Text = mann

                ProgressBarW.Minimum = 0
                ProgressBarW.Maximum = mann + frau
                ProgressBarW.Step = 0
                ProgressBarW.Value = frau
                ProgressBarW.PerformStep()
                Label7.Text = frau

                SendMessage(ProgressBar1.Handle, &H400 + 16, &H3, 0) 'Gelb
                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = mann + frau
                ProgressBar1.Step = 0
                ProgressBar1.Value = sfvs
                ProgressBar1.PerformStep()
                Label6.Text = sfvs

                SendMessage(ProgressBar2.Handle, &H400 + 16, &H3, 0) 'Gelb
                ProgressBar2.Minimum = 0
                ProgressBar2.Maximum = sfvs + gaeste
                ProgressBar2.Step = 0
                ProgressBar2.Value = gaeste
                ProgressBar2.PerformStep()
                Label10.Text = gaeste
                ButtonDrucken.Enabled = True
            Next
        Next

ende:
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonDrucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDrucken.Click
        pAdapter.SelectCommand.CommandText = "Select * from Temp order by feld2, feld5, feld1 "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0

        Dim XL As New PrintOutVS
        Dim dv As DataView
        Dim t As DataTable
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld6")
        XL.PrintAktivStatistik(t)

        Schritt = "2"
        pAdapter.SelectCommand.CommandText = "Select * from Temp order by feld5, feld1, feld2"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0

        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6")
        XL.PrintAktivStatistik(t)
        Me.Close()

    End Sub
End Class