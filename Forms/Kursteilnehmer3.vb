Public Class Kursteilnehmer3
    Dim mkAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Dim SatzAnzahl As String
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub Kursteilnehmer3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kurse". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Teilnehmer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer order by VZName"
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)

        Dim kp As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        DbAccess.SafePosition(bsKurse)
        bsKurse.AddNew()

    End Sub
    Private Sub suchenKurs()
        If TextBox26.Text > "  " Then
            If Len(TextBox26.Text) > 1 Then
                If Mid(TextBox26.Text, 2, 1) = "*" Then
                    kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung, Fahrtbereich"
                Else
                    kAdapter.SelectCommand.CommandText = "Select * from Kurse where Kursbezeichnung like '%" & TextBox26.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
                End If
            Else
                kAdapter.SelectCommand.CommandText = "Select * from Kurse where Mid(Kursbezeichnung,1,1) like '%" & TextBox26.Text & "%'  order by Kursbezeichnung, Fahrtbereich"
            End If
        Else
            kAdapter.SelectCommand.CommandText = "Select * from Kurse order by Kursbezeichnung, Fahrtbereich"
        End If
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        Select Case bsKurse.Count
            Case 0
                MsgBox("Kein Kurs mit angegebenen Buchstabenkombination vorhanden")
                kAdapter.SelectCommand.CommandText = "Select * from Kurse  order by Kursbezeichnung,Fahrtbereich"
                DsAusbildung.Kurse.Clear()
                kAdapter.Fill(DsAusbildung.Kurse)
            Case 1
                DbAccess.SafePosition(bsKurse)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                suchenTeilnehmer()
            Case Else
        End Select
    End Sub
    Private Sub suchenTeilnehmer()
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where kurs = '" & TextBox26.Text & "' and fb ='" & TextBox25.Text & "'   "
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        tAdapter.Fill(DsAusbildung.Teilnehmer)
        Select Case bsTeilnehmer.Count
            Case 0
                MsgBox("Kein Kursteilnehmer mit angegebenen Buchstabenkombination vorhanden. Soll ein neuer angelegt werden?", MsgBoxStyle.YesNo)
             Case 1
                DbAccess.SafePosition(bsKurse)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        End Select
    End Sub
    Private Sub Button1Drucken_Click(sender As System.Object, e As System.EventArgs) Handles Button1Drucken.Click
        Dim XL As New PrintoutKT
        Dim dv As DataView
        Dim t As DataTable
        '       suchenTeilnehmer()
        SatzAnzahl = bsTeilnehmer.Count
        dv = bsTeilnehmer.List
        t = dv.ToTable("Printing", False, "VZname", "Kurs", "FB", "Kurspreis", "Kursbezahlt", "materialpreis", "materialbezahlt")
        XL.PrintTeilnehmerListe(t)
        Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        suchenKurs()
        DataGridView1.Location = New Point(2500, 111)
        DataGridView3.Location = New Point(25, 111)
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        suchenKurs()
    End Sub

    Private Sub TextBox26_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox26.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchenKurs()
        End If
    End Sub
End Class