Public Class Einkaufsliste
    Dim fbreite As Integer
    Dim fhoehe As Integer
    Public iii As Integer
    Public aaa As String
    Public ij As Integer
    Dim t5 As Integer
    Dim törn As String
    Dim grp As String
    Dim buch1 As String
    Dim position As Integer
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim lAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xtAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter

    Private Sub Einkaufsliste_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsCrewbesprechung.Temp". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTemp.Fill(Me.dsCrewbesprechung.Temp)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "CrewbesprechungDataSet.Einkaufsliste". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taEinkaufsliste.Fill(Me.dsCrewbesprechung.Einkaufsliste)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.AddNew()
        TextBox1.Focus()
        Dim rxt As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsCrewbesprechung.Temp.Clear()
        xtAdapter.Fill(dsCrewbesprechung.Temp)
        bsTemp.AddNew()
        gbKopie.Location = New Point(12, 9400)
        gbEinkauf.Location = New Point(12, 9400)
        TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
        gbArbeitsbox.Text = "Törn auswählen mit Doppelklick"
        gbArbeitsbox.Location = New Point(12, 94)
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
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                Label2.Text = "Bootsname: " + dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                Label1.Text = SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumvon")) + " - " + SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumbis"))
                gbArbeitsbox.Location = New Point(12000, 94)
                gbKopie.Location = New Point(12, 94)
                törn = TextBox1.Text
                Crewanzahl()
                liste()
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
    Private Sub Crewanzahl()
        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & TextBox1.Text & "' order by vzname"
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        tAdapter.Fill(dsToernverwaltung.TC)
        ij = bsTC.Count + 1
        Label3.Text = "Crewanzahl: " + ij.ToString
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        suchen()
    End Sub

    Private Sub liste()
        Dim r As System.Data.DataRowView = bsToernname.Current
        lAdapter.SelectCommand = New OleDb.OleDbCommand
        lAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        lAdapter.SelectCommand.CommandText = "Select * from Einkaufsliste where toernname = '" & TextBox1.Text & "' order by gruppe, Artikel"
        bsEinkaufsliste.CancelEdit()
        dsCrewbesprechung.Einkaufsliste.Clear()
        lAdapter.Fill(dsCrewbesprechung.Einkaufsliste)
        If bsEinkaufsliste.Count = 0 Then
            Label5.Enabled = False
            TextBox2.Enabled = False
            Kopieren()
        Else
            gbEinkauf.Location = New Point(16, 121)
            gbKopie.Location = New Point(12, 9400)
            Gruppenerstellen()
         End If
    End Sub
    Private Sub Kopieren()
        DataGridView1.Visible = False
        gbArbeitsbox.Text = "Eine neu Einkaufsliste kopieren"
        aaa = ""
        Dim r As System.Data.DataRowView = bsToernname.Current
        lAdapter.SelectCommand = New OleDb.OleDbCommand
        lAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        lAdapter.SelectCommand.CommandText = "Select * from Einkaufsliste  order by toernname"
        bsEinkaufsliste.CancelEdit()
        dsCrewbesprechung.Einkaufsliste.Clear()
        lAdapter.Fill(dsCrewbesprechung.Einkaufsliste)
        For iii = 0 To bsEinkaufsliste.Count - 1
            If aaa <> dsCrewbesprechung.Einkaufsliste.Rows(iii)("Toernname").ToString Then
                aaa = dsCrewbesprechung.Einkaufsliste.Rows(iii)("Toernname").ToString
                Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
                Dim rt As System.Data.DataRowView = bsTC.Current
                tAdapter.SelectCommand = New OleDb.OleDbCommand
                tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
                tAdapter.SelectCommand.CommandText = "Select * from TC where toern = '" & aaa & "' order by vzname"
                bsTC.CancelEdit()
                dsToernverwaltung.TC.Clear()
                tAdapter.Fill(dsToernverwaltung.TC)
                ij = bsTC.Count + 1
                TextBox4.Text = ij.ToString
                TextBox3.Text = aaa
                bsTemp.AddNew()
                taTemp.Update(dsCrewbesprechung.Temp)
            End If
        Next
    End Sub
     Private Sub DataGridView4_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView4.MouseClick
        ButtonBearbeiten.Enabled = True
        Label5.Enabled = True
        TextBox2.Enabled = True
        TextBox2.Text = TextBox3.Text
    End Sub

    Private Sub ButtonBearbeiten_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBearbeiten.Click
        Me.Cursor = Cursors.WaitCursor
        ButtonBearbeiten.Enabled = False
        Dim r As System.Data.DataRowView = bsEinkaufsliste.Current
        lAdapter.SelectCommand = New OleDb.OleDbCommand
        lAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        lAdapter.SelectCommand.CommandText = "Select * from Einkaufsliste  where toernname = '" & TextBox2.Text & "' order by toernname"
        bsEinkaufsliste.CancelEdit()
        dsCrewbesprechung.Einkaufsliste.Clear()
        lAdapter.Fill(dsCrewbesprechung.Einkaufsliste)

        Dim rxt As System.Data.DataRowView = bsTemp.Current
        xtAdapter.SelectCommand = New OleDb.OleDbCommand
        xtAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        xtAdapter.SelectCommand.CommandText = "delete * from Temp"
        bsTemp.CancelEdit()
        dsCrewbesprechung.Temp.Clear()
        xtAdapter.Fill(dsCrewbesprechung.Temp)
        bsTemp.AddNew()
        For iii = 0 To bsEinkaufsliste.Count - 1
            TextBox3.Text = TextBox1.Text
            TextBox4.Text = dsCrewbesprechung.Einkaufsliste.Rows(iii)("Gruppe").ToString
            TextBox10.Text = dsCrewbesprechung.Einkaufsliste.Rows(iii)("Artikel").ToString
            TextBox11.Text = dsCrewbesprechung.Einkaufsliste.Rows(iii)("Mengeneinheit").ToString
            TextBox12.Text = dsCrewbesprechung.Einkaufsliste.Rows(iii)("Menge").ToString
            TextBox13.Text = dsCrewbesprechung.Einkaufsliste.Rows(iii)("Bemerkung").ToString
            bsTemp.AddNew()
            taTemp.Update(dsCrewbesprechung.Temp)
        Next
        bsEinkaufsliste.AddNew()
        For iii = 0 To bsTemp.Count - 2
            TextBox14.Text = dsCrewbesprechung.Temp.Rows(iii)("Feld0").ToString
            TextBox15.Text = dsCrewbesprechung.Temp.Rows(iii)("Feld1").ToString
            TextBox16.Text = dsCrewbesprechung.Temp.Rows(iii)("Feld2").ToString
            TextBox18.Text = dsCrewbesprechung.Temp.Rows(iii)("Feld3").ToString
            TextBox19.Text = dsCrewbesprechung.Temp.Rows(iii)("Feld4").ToString
            TextBox17.Text = dsCrewbesprechung.Temp.Rows(iii)("Feld5").ToString
            bsEinkaufsliste.AddNew()
            taEinkaufsliste.Update(dsCrewbesprechung.Einkaufsliste)
        Next
        Gruppenerstellen()
    End Sub
    Private Sub Gruppenerstellen()
        Dim r As System.Data.DataRowView = bsEinkaufsliste.Current
        lAdapter.SelectCommand = New OleDb.OleDbCommand
        lAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        lAdapter.SelectCommand.CommandText = "Select * from Einkaufsliste  where toernname = '" & TextBox1.Text & "' order by gruppe, Artikel"
        bsEinkaufsliste.CancelEdit()
        dsCrewbesprechung.Einkaufsliste.Clear()
        lAdapter.Fill(dsCrewbesprechung.Einkaufsliste)
        Me.Cursor = Cursors.Default
        gbEinkauf.Location = New Point(16, 121)
        gbKopie.Location = New Point(12, 9400)
        aaa = ""
        For iii = 0 To bsEinkaufsliste.Count - 1
            If dsCrewbesprechung.Einkaufsliste.Rows(iii)("Gruppe").ToString <> aaa Then
                ListBox1.Items.Add(dsCrewbesprechung.Einkaufsliste.Rows(iii)("Gruppe").ToString)
                aaa = dsCrewbesprechung.Einkaufsliste.Rows(iii)("Gruppe").ToString
            End If
        Next
        Label12.Text = "Alle Gruppen"
    End Sub
     Private Sub ButtonNeuerArtikel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNeuerArtikel.Click
        TextBox14.Text = törn
        bsEinkaufsliste.AddNew()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If grp = "" Or grp = " " Then
            MsgBox("Die Einkaufsgruppe ist noch nicht definiert. - Klick in die Listbox und dann speichern. -")
        Else
            TextBox5.Text = grp
            TextBox14.Text = törn
            bsEinkaufsliste.EndEdit()
            taEinkaufsliste.Update(dsCrewbesprechung.Einkaufsliste)
            Dim r As System.Data.DataRowView = bsToernname.Current
            lAdapter.SelectCommand = New OleDb.OleDbCommand
            lAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
            lAdapter.SelectCommand.CommandText = "Select * from Einkaufsliste where toernname = '" & TextBox1.Text & "'  and gruppe = '" & grp & "' order by  Artikel"
            bsEinkaufsliste.CancelEdit()
            dsCrewbesprechung.Einkaufsliste.Clear()
            lAdapter.Fill(dsCrewbesprechung.Einkaufsliste)
            Me.Refresh()
            TextBox6.Focus()
        End If
    End Sub

    Private Sub Buttonloeschen_Click(sender As System.Object, e As System.EventArgs) Handles Buttonloeschen.Click
        bsEinkaufsliste.RemoveCurrent()
        taEinkaufsliste.Update(dsCrewbesprechung)
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        TextBox8.Focus()
    End Sub

    Private Sub Button2FormularLöschen_Click(sender As System.Object, e As System.EventArgs) Handles Button2FormularLöschen.Click
        TextBox1.Text = ""
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        gbKopie.Location = New Point(12, 9400)
        gbEinkauf.Location = New Point(12, 9400)
        gbArbeitsbox.Location = New Point(12000, 94)
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        grp = ListBox1.Text
        Label12.Text = grp
        Dim r As System.Data.DataRowView = bsEinkaufsliste.Current
        lAdapter.SelectCommand = New OleDb.OleDbCommand
        lAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=crewbesprechung.mdb")
        lAdapter.SelectCommand.CommandText = "Select * from Einkaufsliste  where toernname = '" & TextBox1.Text & "' and gruppe = '" & grp & "' order by  Artikel"
        bsEinkaufsliste.CancelEdit()
        dsCrewbesprechung.Einkaufsliste.Clear()
        lAdapter.Fill(dsCrewbesprechung.Einkaufsliste)

    End Sub

    Private Sub ButtonNeueGruppe_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNeueGruppe.Click
        TextBox5.Location = New Point(6, 346)
        TextBox5.Focus()
        TextBox5.Text = ""
    End Sub
    Private Sub TextBox5_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyUp
        If Len(TextBox5.Text) = 1 Then
            ListBox1.Items.Add(TextBox5.Text)
            t5 = ListBox1.Items.Count - 2
            ListBox1.Items.RemoveAt(t5 + 1)
        Else
            If t5 > 0 Then
                ListBox1.Items.RemoveAt(t5)
                ListBox1.Items.Insert(t5, TextBox5.Text)
            End If
        End If

    End Sub
    Private Sub TextBox5_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox5.Location = New Point(6, 3460)
      End Sub

    Private Sub BtBearbeiten_Click(sender As System.Object, e As System.EventArgs) Handles BtBearbeiten.Click
        suchen()
    End Sub
End Class