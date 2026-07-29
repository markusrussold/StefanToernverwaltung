Public Class Kursmaterial
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public iij As Integer
    Dim Testversion As Boolean = False
    Public j As Integer
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Private Sub Kursmaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsAusbildung.Kursmaterial". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taKursmaterial.Fill(Me.DsAusbildung.Kursmaterial)
        Dim rp As System.Data.DataRowView = bsKursmaterial.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial"
        bsKursmaterial.CancelEdit()
        DsAusbildung.Kursmaterial.Clear()
        pAdapter.Fill(DsAusbildung.Kursmaterial)
        DbAccess.SafePosition(bsKursmaterial)
        bsKursmaterial.AddNew()
        If Menü.FreischaltZiffer = "2" Or Menü.FreischaltZiffer = "3" Then
            MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt.")
            Testversion = True
        End If
        With DataGridView1
            .Columns(0).Width = 150
        End With
        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        DataGridView1.Visible = False
        MaskedTextBox1.Mask = "##.##.####"
     End Sub
    Private Sub speichern()
        '
        '                                Speichern
        '
        If TextBox1.Text > " " Then
            If IsDate(MaskedTextBox1.Text) Then
                If IsNumeric(MaskedTextBox2.Text) Then
                    If IsNumeric(MaskedTextBox3.Text) Then
                        If aenderung Then
                            bsKursmaterial.EndEdit()
                            taKursmaterial.Update(DsAusbildung.Kursmaterial)
                            iii = 0
                        Else
                            If Testversion Then
                                MsgBox("Die freie Kursverwaltung ist auf 3 Sätze eingeschränkt. Speichern ist nicht mehr möglich!")
                            Else
                                bsKursmaterial.AddNew()
                                taKursmaterial.Update(DsAusbildung.Kursmaterial)
                            End If
                        End If
                        aenderung = False
                        Formularloeschen()
                    Else
                        MsgBox("Der Einkauspreis fehlt.")
                    End If
                Else
                    MsgBox("Der Listenpreis fehlt.")
                End If
            Else
                MsgBox("Datum Listenpreis fehlt.")
            End If

        Else
            MsgBox("Materialbezeichnung ist Pflichteingabe")
            TextBox1.Focus()
        End If

    End Sub
    Private Sub Formularloeschen()
        TextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        TextBox4.Text = ""
        MaskedTextBox1.Text = ""
        aenderung = False
        DataGridView1.Visible = False
        RichTextBox1.Text = ""
        dsausbildung.Kursmaterial.Clear()
        bsKursmaterial.AddNew()
    End Sub
    Private Sub suchen()
 TextBox1.Text = RTrim(TextBox1.Text)
        If TextBox1.Text > "  " Then
            If Len(TextBox1.Text) > 1 Then
                If Mid(TextBox1.Text, 2, 1) = "*" Then
                    pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial  order by Material"
                Else
                    pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where Material like '%" & TextBox1.Text & "%'  order by Material"
                End If
            Else
                pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where Mid(Material,1,1) like '%" & TextBox1.Text & "%'  order by Material"
            End If
        Else
            pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial order by Material"
        End If
        aenderung = True
        bsKursmaterial.CancelEdit()
        DsAusbildung.Kursmaterial.Clear()
        pAdapter.Fill(DsAusbildung.Kursmaterial)
        Select Case bsKursmaterial.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial  order by Material"
                pAdapter.Fill(DsAusbildung.Kursmaterial)
                Formularloeschen()
            Case 1
                DbAccess.SafePosition(bsKursmaterial)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                DataGridView1.Visible = False
            Case Else
                DataGridView1.Columns(0).Frozen = True
                DataGridView1.Visible = True
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatLoe.Click
        speichern()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
        If e.KeyCode = Keys.F5 Then
            speichern()
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Formularloeschen()
    End Sub
    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        DataGridView1.Visible = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '                Preisliste
        GroupBox1.Location = New Point(180, 30)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Xmk As New PrintOutPL
        Dim dv As DataView
        Dim t As DataTable
        pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial order by Material"
        bsKursmaterial.CancelEdit()
        aenderung = True
        DsAusbildung.Kursmaterial.Clear()
        pAdapter.Fill(DsAusbildung.Kursmaterial)
 
        dv = bsKursmaterial.List
        t = dv.ToTable("Printing", False, "Material", "Listenpreis", "Einkaufspreis", "Lieferant", "Datum", "Bemerkung")
        Xmk.PrintPreisliste(t)
        GroupBox1.Visible = False
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        '      MaskedTextBox1.Focus()
        GroupBox6Kalender.Visible = True
        GroupBox6Kalender.Location = New Point(100, 100)
    End Sub
    Private Sub Button7Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7Speichern.Click
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub Button5Zurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5Zurueck.Click
        GroupBox6Kalender.Visible = False
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        MaskedTextBox1.Text = MonthCalendar1.SelectionStart.ToString
        MaskedTextBox1.Focus()
        GroupBox6Kalender.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim msg As MsgBoxResult
        msg = MsgBox(" Kursmaterial: " & Convert.ToString(TextBox1.Text) & " wird gelöscht.", 1, "Löschen")
        If msg = vbOK Then
            pAdapter.SelectCommand.CommandText = "Select * from Kursmaterial where Material = '" & TextBox1.Text & "' "
            bsKursmaterial.CancelEdit()
            DsAusbildung.Kursmaterial.Clear()
            pAdapter.Fill(DsAusbildung.Kursmaterial)
            bsKursmaterial.RemoveCurrent()
            taKursmaterial.Update(DsAusbildung)
            Formularloeschen()
            bsKursmaterial.AddNew()
        End If

    End Sub

  
End Class