Public Class KalkToToern
    Public toernbez As String
    Public aaa As String
    Public iia As Integer
    Dim IDcheck As Boolean
    Private Sub KalkToToern_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        IDToern wird nicht mehr verwendet
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        Me.taBootKalkulation.Fill(Me.dsToernverwaltung.BootKalkulation)
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        Me.taToernKalkulation.Fill(Me.dsToernverwaltung.ToernKalkulation)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        With DataGridView1
            .Columns(0).Width = 250
        End With
        bsToernKalkulation.AddNew()
        GroupBox2.Visible = False
    End Sub
    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernkalkulation.Current
        GroupBox2.Visible = True
        GroupBox2.Text = "Törn auswählen mit Doppelklick"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox2.Text = RTrim(TextBox2.Text)
             If TextBox2.Text > "  " Then
                If Len(TextBox2.Text) > 1 Then
                    xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern like '%" & TextBox2.Text & "%' order by toern"
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where mid(toern,1,1) like '%" & TextBox2.Text & "%' order by toern"
                End If
            Else
                xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation order by toern"
            End If
          bsToernKalkulation.CancelEdit()
        dsToernverwaltung.ToernKalkulation.Clear()
        xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        Select Case bsToernKalkulation.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation order by toern"
                xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
                Formularloeschen()
            Case 1
                If IsDate(dsToernverwaltung.ToernKalkulation.Rows(0)("Toernanfang").ToString()) And IsDate(dsToernverwaltung.ToernKalkulation.Rows(0)("Toernende").ToString()) Then
                    GroupBox1.Enabled = True
                Else
                    MsgBox("Kopieren ist nicht möglich, Törnanfang und/oder Törnende fehlt.")
                End If
            Case Else
                DataGridView1.Visible = True
         End Select
    End Sub
    Private Sub Formularloeschen()
        IDcheck = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
        RichTextBox2.Text = ""
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        IDcheck = True
        suchen()
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        suchen()
    End Sub

    Private Sub Kopieren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kopieren.Click
        toernbez = TextBox2.Text
        toerncheck()
    End Sub

    Private Sub Leeren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leeren.Click
        Formularloeschen()
    End Sub
    Private Sub toerncheck()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernname.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        If TextBox2.Text > "  " Then
            xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & toernbez & "' "
        End If
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        xAdapter.Fill(dsToernverwaltung.Toernname)
        Select Case bsToernname.Count
            Case 0
                KopierenToern()
                xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung = '" & toernbez & "'"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
                bsToernname.Position = 0
                '               TextBox6.Text = dsToernverwaltung.Toernname.Rows(0)("id")
                bsToernname.EndEdit()
                taToernname.Update(dsToernverwaltung.Toernname)
                KopierenCrew()
                MsgBox("  F e r t i g   ")
                Me.Close()
            Case Else
                GroupBox2.Visible = False
                MsgBox(" Unter diesen Name ist bereits ein Törn vorhanden. Wähle eine andere Törnbezeichnung.")
                GroupBox3.Visible = True
                TextBox4.Focus()
        End Select
    End Sub
    Private Sub KopierenToern()
        Dim tage As Integer
        bsToernname.Position = 0
        bsToernname.AddNew()
        bsToernname.AddNew()
        dsToernverwaltung.Toernname.Rows(0)("DatumVon") = dsToernverwaltung.ToernKalkulation.Rows(0)("Toernanfang").ToString()
        dsToernverwaltung.Toernname.Rows(0)("DatumBis") = dsToernverwaltung.ToernKalkulation.Rows(0)("Toernende").ToString()
        Dim d1 As Date = dsToernverwaltung.ToernKalkulation.Rows(0)("Toernanfang").ToString()
        Dim d2 As Date = dsToernverwaltung.ToernKalkulation.Rows(0)("Toernende").ToString()
        Dim diff As TimeSpan = d2 - d1
        tage = diff.Days
        '        tage = DateDiff("d", CDate(dsToernverwaltung.ToernKalkulation.Rows(0)("Toernanfang").ToString()), CDate(dsToernverwaltung.ToernKalkulation.Rows(0)("Toernende").ToString()))
        dsToernverwaltung.Toernname.Rows(0)("Bordtage") = tage.ToString("#")
        dsToernverwaltung.Toernname.Rows(0)("toernbezeichnung") = toernbez
        dsToernverwaltung.Toernname.Rows(0)("Bootsname") = dsToernverwaltung.ToernKalkulation.Rows(0)("Boot").ToString()
        dsToernverwaltung.Toernname.Rows(0)("Skipper") = dsToernverwaltung.ToernKalkulation.Rows(0)("Skipper").ToString()
        dsToernverwaltung.Toernname.Rows(0)("Bemerkung") = dsToernverwaltung.ToernKalkulation.Rows(0)("Bemerkung").ToString()
        dsToernverwaltung.Toernname.Rows(0)("Route") = dsToernverwaltung.ToernKalkulation.Rows(0)("Route").ToString()
        dsToernverwaltung.Toernname.Rows(0)("smSegel") = "0"
        dsToernverwaltung.Toernname.Rows(0)("smMotor") = "0"
        dsToernverwaltung.Toernname.Rows(0)("smGesamt") = "0"
        dsToernverwaltung.Toernname.Rows(0)("Nachtfahrten") = "0"
        dsToernverwaltung.Toernname.Rows(0)("Nachtansteuerungen") = "0"
        dsToernverwaltung.Toernname.Rows(0)("Bordkassa") = "0"
        dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB2") = "0"
        dsToernverwaltung.Toernname.Rows(0)("ausserhalbFB3") = "0"
        taToernname.Update(dsToernverwaltung.Toernname)
    End Sub
    Private Sub KopierenCrew()
        Dim eadapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim re As System.Data.DataRowView = bsBootKalkulation.Current
        eadapter.SelectCommand = New OleDb.OleDbCommand
        eadapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        eadapter.SelectCommand.CommandText = "Select * from Bootkalkulation where toern =  '" & TextBox2.Text & "'"

        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        eadapter.Fill(dsToernverwaltung.BootKalkulation)
        iia = bsBootKalkulation.Count - 1

        Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rt As System.Data.DataRowView = bsTC.Current
        tAdapter.SelectCommand = New OleDb.OleDbCommand
        tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")

        For ia = 0 To iia
            aaa = dsToernverwaltung.BootKalkulation.Rows(ia)("VZname").ToString()
            tAdapter.SelectCommand.CommandText = "Select * from TC where toern =  '" & toernbez & "' and vzname = '" & aaa & "' "
            dsToernverwaltung.TC.Clear()
            tAdapter.Fill(dsToernverwaltung.TC)
            If bsTC.Count = 0 Then
                bsTC.AddNew()
                bsTC.AddNew()
                dsToernverwaltung.TC.Rows(0)("toern") = toernbez
                '              dsToernverwaltung.TC.Rows(0)("idtoern") = TextBox6.Text
                dsToernverwaltung.TC.Rows(0)("VZname") = dsToernverwaltung.BootKalkulation.Rows(ia)("VZname").ToString()
                dsToernverwaltung.TC.Rows(0)("R1") = dsToernverwaltung.BootKalkulation.Rows(ia)("R2").ToString()
                taTC.Update(dsToernverwaltung.TC)
            End If
        Next
    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        toernbez = TextBox4.Text
        GroupBox3.Visible = False
        toerncheck()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

End Class