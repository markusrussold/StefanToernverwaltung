Public Class Kursstatistik
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, _
   ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim cAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim aaa As String
    Dim iii As Integer
    Dim ij As Integer
    Dim schiAnz As Integer
    Dim Lehrer As String
    Dim kurs As String
    Dim fahrtbereich As String
    Dim geschlecht As String
    Dim VZ_Name As String
    Dim anfdatum As Date
    Dim Kursdauer As Single
    Public Statistik As String = "Namen"
    Dim pi As Integer = -1
    Private Sub Kursstatistik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taTemp.Fill(Me.dsToernverwaltung.Temp)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taKurse.Fill(Me.DsAusbildung.Kurse)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        '
        Dim r As System.Data.DataRowView = bsKurse.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from Kurse order by vortragende"
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0
        If bsKurse.Count > 0 Then
            aaa = ""
            iii = bsKurse.Count - 1
            For Me.ij = 0 To iii
                If aaa <> DsAusbildung.Kurse.Rows(ij)("Vortragende").ToString Then
                    ComboBox1.Items.Add(DsAusbildung.Kurse.Rows(ij)("Vortragende").ToString)
                    aaa = DsAusbildung.Kurse.Rows(ij)("Vortragende").ToString
                    schiAnz += 1
                End If
            Next
        Else
            MsgBox("Es sind keine Kurse gespeichert")
            Me.Close()
        End If
        '
        Dim t As System.Data.DataRowView = bsTeilnehmer.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer"
        Dim c As System.Data.DataRowView = bsTeilnehmer.Current
        cAdapter.SelectCommand = New OleDb.OleDbCommand
        cAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        cAdapter.SelectCommand.CommandText = "Select * from Crewadressen"
        TempRemove()

        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        ButtonDrucken.Enabled = False
    End Sub
    Private Sub TempRemove()
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
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Lehrer = "alle"
        End If
        TempRemove()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If RadioButton2.Checked Then
            Lehrer = ComboBox1.Text
        End If
        TempRemove()
    End Sub
    Private Sub KurseSuchen()
        Dim hilfsdatum As String
        If Lehrer = "alle" Then
            kAdapter.SelectCommand.CommandText = "Select * from Kurse order by vortragende"
        Else
            kAdapter.SelectCommand.CommandText = "Select * from Kurse where vortragende= '" & Lehrer & "' "
        End If
        bsKurse.CancelEdit()
        DsAusbildung.Kurse.Clear()
        kAdapter.Fill(DsAusbildung.Kurse)
        bsKurse.Position = 0
        '       bsTemp.AddNew()
        For Me.ij = 0 To bsKurse.Count - 1
            Lehrer = DsAusbildung.Kurse.Rows(ij)("Vortragende").ToString
            kurs = DsAusbildung.Kurse.Rows(ij)("Kursbezeichnung").ToString
            fahrtbereich = DsAusbildung.Kurse.Rows(ij)("Fahrtbereich").ToString
            If Not DBNull.Value.Equals(DsAusbildung.Kurse.Rows(ij)("kursbeginn").ToString) Then
                If DsAusbildung.Kurse.Rows(ij)("kursbeginn").ToString > "" Then
                    anfdatum = DsAusbildung.Kurse.Rows(ij)("kursbeginn").ToString
                Else
                    anfdatum = Today
                End If
            Else
                anfdatum = Today
            End If
            If Not DBNull.Value.Equals(DsAusbildung.Kurse.Rows(ij)("kursdauer").ToString) Then
                If DsAusbildung.Kurse.Rows(ij)("kursdauer").ToString > "" Then
                    Kursdauer = DsAusbildung.Kurse.Rows(ij)("kursdauer").ToString
                Else
                    Kursdauer = 0
                End If
            Else
                Kursdauer = 0
            End If
            tAdapter.SelectCommand.CommandText = "Select * from Teilnehmer where kurs = '" & kurs & "' and FB = '" & fahrtbereich & "' "
            bsTeilnehmer.CancelEdit()
            DsAusbildung.Teilnehmer.Clear()
            tAdapter.Fill(DsAusbildung.Teilnehmer)
            bsTeilnehmer.Position = 0
            For Me.iii = 0 To bsTeilnehmer.Count - 1
                VZ_Name = DsAusbildung.Teilnehmer.Rows(iii)("vzname").ToString
                cAdapter.SelectCommand.CommandText = "Select * from crewadressen where vzname = '" & VZ_Name & "' "
                bsCrewAdressen.CancelEdit()
                dsToernverwaltung.CrewAdressen.Clear()
                cAdapter.Fill(dsToernverwaltung.CrewAdressen)
                bsCrewAdressen.Position = 0
                If bsCrewAdressen.Count = 1 Then
                    geschlecht = dsToernverwaltung.CrewAdressen.Rows(0)("anrede").ToString
                Else
                    geschlecht = " "
                End If
                bsTemp.AddNew()
                '              pi += 1
                '              dsToernverwaltung.Temp.Rows(pi)("Feld1") = kurs
                '              dsToernverwaltung.Temp.Rows(pi)("Feld2") = fahrtbereich
                '              dsToernverwaltung.Temp.Rows(pi)("Feld3") = Lehrer
                '              dsToernverwaltung.Temp.Rows(pi)("Feld4") = VZ_Name
                '              dsToernverwaltung.Temp.Rows(pi)("Feld5") = geschlecht
                TextBox1.Text = kurs
                TextBox2.Text = fahrtbereich
                TextBox3.Text = Lehrer
                TextBox4.Text = VZ_Name
                TextBox5.Text = geschlecht
                TextBox6.Text = anfdatum
                TextBox7.Text = Kursdauer
                hilfsdatum = CDate(anfdatum)
                TextBox8.Text = hilfsdatum.Substring(6, 4) + hilfsdatum.Substring(3, 2) + hilfsdatum.Substring(0, 2)
                taTemp.Update(dsToernverwaltung.Temp)
            Next
       Next
        bsTemp.AddNew()
        TextBox1.Text = kurs
        TextBox2.Text = fahrtbereich
        TextBox3.Text = Lehrer
        TextBox4.Text = VZ_Name
        TextBox5.Text = geschlecht
        TextBox6.Text = anfdatum
        TextBox7.Text = Kursdauer
        hilfsdatum = CDate(anfdatum)
        TextBox8.Text = hilfsdatum.Substring(6, 4) + hilfsdatum.Substring(3, 2) + hilfsdatum.Substring(0, 2)
        taTemp.Update(dsToernverwaltung.Temp)
    End Sub

    Private Sub ButtonStarten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStarten.Click
        Me.Cursor = Cursors.WaitCursor
        KurseSuchen()
        GraphikG()
        GraphikF()
        Me.Cursor = Cursors.Default
        ButtonDrucken.Enabled = True
    End Sub
    Private Sub GraphikG()
        Dim Herr As Integer
        Dim Frau As Integer
        aaa = "Herr"
        pAdapter.SelectCommand.CommandText = "Select * from Temp where feld5 like '%" & aaa & "%' "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0
        Herr = bsTemp.Count
        aaa = "Frau"
        pAdapter.SelectCommand.CommandText = "Select * from Temp where feld5 like '%" & aaa & "%' "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0
        Frau = bsTemp.Count
        '       
        ProgressBarM.Minimum = 0
        ProgressBarM.Maximum = Herr + Frau
        ProgressBarM.Step = 0
        ProgressBarM.Value = Herr
        ProgressBarM.PerformStep()
        Label8.Text = Herr

        SendMessage(ProgressBarW.Handle, &H400 + 16, &H3, 0) 'Gelb
        ProgressBarW.Minimum = 0
        ProgressBarW.Maximum = Herr + Frau
        ProgressBarW.Step = 0
        ProgressBarW.Value = Frau
        ProgressBarW.PerformStep()
        Label7.Text = Frau
    End Sub
    Private Sub GraphikF()
        Dim FB1 As Integer
        Dim FB2 As Integer
        Dim FB3 As Integer
        Dim FB4 As Integer

        pAdapter.SelectCommand.CommandText = "Select * from Temp "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0
        ProgressBar1.Maximum = bsTemp.Count
        ProgressBar2.Maximum = bsTemp.Count
        ProgressBar3.Maximum = bsTemp.Count
        ProgressBar4.Maximum = bsTemp.Count
        ProgressBar1.Minimum = 0
        ProgressBar2.Minimum = 0
        ProgressBar3.Minimum = 0
        ProgressBar4.Minimum = 0
        ProgressBar1.Step = 0
        ProgressBar2.Step = 0
        ProgressBar3.Step = 0
        ProgressBar4.Step = 0

        aaa = "FB1"
        pAdapter.SelectCommand.CommandText = "Select * from Temp where feld2 like '%" & aaa & "%' "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0
        SendMessage(ProgressBar1.Handle, &H400 + 16, &H1, 0) 'Grün
        FB1 = bsTemp.Count
        ProgressBar1.Value = FB1
        ProgressBar1.PerformStep()
        Label9.Text = FB1

        aaa = "FB2"
        pAdapter.SelectCommand.CommandText = "Select * from Temp where feld2 like '%" & aaa & "%' "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0
        FB2 = bsTemp.Count
        SendMessage(ProgressBar2.Handle, &H400 + 16, &H3, 0) 'Gelb
        ProgressBar2.Value = FB2
        ProgressBar2.PerformStep()
        Label10.Text = FB2

        aaa = "FB3"
        pAdapter.SelectCommand.CommandText = "Select * from Temp where feld2 like '%" & aaa & "%' "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0
        FB3 = bsTemp.Count
        SendMessage(ProgressBar3.Handle, &H400 + 16, &H1, 0) '?
        ProgressBar3.Value = FB3
        ProgressBar3.PerformStep()
        Label11.Text = FB3

        aaa = "FB4"
        pAdapter.SelectCommand.CommandText = "Select * from Temp where feld2 like '%" & aaa & "%' "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0
        FB4 = bsTemp.Count
        SendMessage(ProgressBar4.Handle, &H400 + 16, &H2, 0) 'Rot
        ProgressBar4.Value = FB4
        ProgressBar4.PerformStep()
        Label12.Text = FB4
    End Sub

    Private Sub ButtonDrucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDrucken.Click
        pAdapter.SelectCommand.CommandText = "Select * from Temp order by feld4, feld8 "
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0

        Dim XL As New PrintoutKS
        Dim dv As DataView
        Dim t As DataTable
        dv = bsTemp.List
        t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7")
        XL.PrintKursstatistik(t)

        Statistik = "Kurs"
        pAdapter.SelectCommand.CommandText = "Select * from Temp order by feld8, feld1, feld2, feld4"
        bsTemp.CancelEdit()
        dsToernverwaltung.Temp.Clear()
        pAdapter.Fill(dsToernverwaltung.Temp)
        bsTemp.Position = 0

         t = dv.ToTable("Printing", False, "Feld1", "Feld2", "Feld3", "Feld4", "Feld5", "Feld6", "Feld7")
        XL.PrintKursstatistik(t)
        Me.Close()
    End Sub
End Class