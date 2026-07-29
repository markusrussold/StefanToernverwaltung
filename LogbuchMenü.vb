Public Class LogbuchMenü
    Dim aaa As String
    Dim buch1 As String
    Dim position As Integer
    Dim iii As Integer
    Dim WAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' LogWacheplan
    Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim tAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter             ' Törn Wacheplan
    Dim datvon As String
    Dim datbis As String
    Dim msg As Integer
    Private Sub LogbuchMenü_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Wacheplan". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taWacheplan.Fill(Me.dsToernverwaltung.Wacheplan)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.LogWacheplan". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taLogWacheplan.Fill(Me.DsLogbuch.LogWacheplan)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.BootLog". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taBootLog.Fill(Me.DsLogbuch.BootLog)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Toerndaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToerndaten.Fill(Me.DsLogbuch.Toerndaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Zusammenfassung2". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taZusammenfassung2.Fill(Me.DsLogbuch.Zusammenfassung2)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Dokumentation". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taDokumentation.Fill(Me.DsLogbuch.Dokumentation)
          Me.taSicherheitseinweisung.Fill(Me.DsLogbuch.Sicherheitseinweisung)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsLogbuch.Maengel". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taMaengel.Fill(Me.DsLogbuch.Maengel)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        GroupBox1.Location = New Point(1200, 110)
        GroupBox3.Location = New Point(1200, 110)
        Label12.Text = ""
        Label7.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label14.Text = ""
        Label17.Text = ""
        Label1.Text = ""
        aaa = GetSetting("Toern", "Logbuch", "T", "")
        If aaa > " " Then
            Dim r As System.Data.DataRowView = bsToernname.Current
            xAdapter.SelectCommand = New OleDb.OleDbCommand
            xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            xAdapter.SelectCommand.CommandText = "Select * from Toernname where toernbezeichnung like '%" & aaa & "%'  order by toernbezeichnung"
            bsToernname.CancelEdit()
            dsToernverwaltung.Toernname.Clear()
            xAdapter.Fill(dsToernverwaltung.Toernname)
            If bsToernname.Count > 0 Then
                Label14.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                datvon = SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumvon"))
                datbis = SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumbis"))
                Label17.Text = "von " + datvon + " bis " + datbis
            Else
                MsgBox("Logbuch gilt nur für Törns in der Verwaltung. Törn " + aaa + " wird erst kalkuliert.")
            End If
        End If
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
    End Sub
    Private Sub suchen()
        Dim r As System.Data.DataRowView = bsToernname.Current
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
                GroupBox3.Location = New Point(30, 130)
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernname order by toernbezeichnung"
                bsToernname.CancelEdit()
                dsToernverwaltung.Toernname.Clear()
                xAdapter.Fill(dsToernverwaltung.Toernname)
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                Label14.Text = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                datvon = SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumvon"))
                datbis = SafeData.FormatDateDe(dsToernverwaltung.Toernname.Rows(0)("datumbis"))
                Label17.Text = "von " + datvon + " bis " + datbis
                GroupBox3.Location = New Point(1200, 110)
                GroupBox1.Location = New Point(30, 130)
                wacheplan()
                toerndoku()
                Sicherheit()
                Tageslog()
                zusammen()
                SuchenMaengel()
                SaveSetting("Toern", "Logbuch", "T", TextBox1.Text)
            Case Else
                GroupBox3.Location = New Point(30, 130)
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
        End Select
    End Sub
    Private Sub wacheplan()
        WAdapter.SelectCommand = New OleDb.OleDbCommand
        WAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        WAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & TextBox1.Text & "' order by datum"
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        WAdapter.Fill(DsLogbuch.LogWacheplan)
        aaa = bsLogWacheplan.Count
        If aaa > 0 Then
            Label1.Text = "Wacheplan ist bereits in das Logbuch kopiert."
        Else
            Label1.Text = "Wacheplan fehlt im Logbuch."
        End If
    End Sub
    Private Sub toerndoku()
        Dim rp As System.Data.DataRowView = bsToerndaten.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Toerndaten where toernbezeichnung = '" & TextBox1.Text & "'"
        bsToerndaten.CancelEdit()
        DsLogbuch.Toerndaten.Clear()
        pAdapter.Fill(DsLogbuch.Toerndaten)
        bsToerndaten.Position = 0
        aaa = bsToerndaten.Count
        Label7.Text = 0
        If aaa = 0 Then
            Label7.Text = "Törnbeschreibung ist noch nicht eingegeben."
        Else
            DataGridView2.DataSource = bsToerndaten
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("GeplanteRoute")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Kassamanager")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Ersteinzahlung")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Pantrymanager")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Revierbild")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Gefahreneroute")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("KartenMissweisung")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Sonnenaufgang")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Sonnenuntergang")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Navtexstationen")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("Vollmond")) Then Label7.Text += 1
            If DBNull.Value.Equals(DsLogbuch.Toerndaten.Rows(0)("MaxTidenhub")) Then Label7.Text += 1
        End If
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from bootlog where bootname = '" & dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString & "'"
        bsBootLog.CancelEdit()
        DsLogbuch.BootLog.Clear()
        pAdapter.Fill(DsLogbuch.BootLog)
        bsBootLog.Position = 0
        aaa = bsBootLog.Count
        If IsNumeric(Label7.Text) Then
            If aaa = 0 Then
                Label7.Text += 5
            Else
                If DBNull.Value.Equals(DsLogbuch.BootLog.Rows(0)("Motormarke")) Then Label7.Text += 1
                If DBNull.Value.Equals(DsLogbuch.BootLog.Rows(0)("Beibootmarke")) Then Label7.Text += 1
                If DBNull.Value.Equals(DsLogbuch.BootLog.Rows(0)("Beobootleistung")) Then Label7.Text += 1
                If DBNull.Value.Equals(DsLogbuch.BootLog.Rows(0)("Baustoff")) Then Label7.Text += 1
                If DBNull.Value.Equals(DsLogbuch.BootLog.Rows(0)("Bootsbild")) Then Label7.Text += 1
            End If
        End If
        Label7.Text = "(" + Label7.Text + ")"
    End Sub
    Private Sub zusammen()
        Dim datmu As Date = CDate(datbis)
        datmu = DateAdd(DateInterval.Day, -1, datmu)
        Dim rp As System.Data.DataRowView = bsZusammenfassung2.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from zusammenfassung2 where toernbezeichnung = '" & TextBox1.Text & "' order by datumvon"
        bsZusammenfassung2.CancelEdit()
        DsLogbuch.Zusammenfassung2.Clear()
        pAdapter.Fill(DsLogbuch.Zusammenfassung2)
        bsZusammenfassung2.Position = 0
        aaa = bsZusammenfassung2.Count
         If aaa = 0 Then
            Label11.Text = "Zusammenfassung wurde noch nicht gestartet."
        Else
            DataGridView2.DataSource = bsZusammenfassung2
            bsZusammenfassung2.Position = aaa - 1
            If DsLogbuch.Zusammenfassung2.Rows(aaa - 1)("datumbis") < datmu Then Label11.Text = "Zusammenfassung ab den  " & SafeData.FormatDateDe(DsLogbuch.Zusammenfassung2.Rows(aaa - 1)("datumbis")) & " wurde noch nicht durchgeführt." Else Label11.Text = "o.k."
        End If
    End Sub
    Private Sub Tageslog()
        Dim letztertag As Date = datbis
        Dim datbiss As String = DateAdd("d", -1, letztertag)
        Dim rp As System.Data.DataRowView = bsDokumentation.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Dokumentation where toernbezeichnung = '" & TextBox1.Text & "' order by datum"
        bsDokumentation.CancelEdit()
        DsLogbuch.Dokumentation.Clear()
        pAdapter.Fill(DsLogbuch.Dokumentation)
        bsDokumentation.Position = 0
        aaa = bsDokumentation.Count
        If aaa = 0 Then
            Label10.Text = "Tageslogbuch und Tagesdokumentation sind noch nicht eingegeben."
        Else
            DataGridView2.DataSource = bsDokumentation
            bsDokumentation.Position = aaa - 1
            If DsLogbuch.Dokumentation.Rows(aaa - 1)("datum") < datbiss Then Label10.Text = "Tageslogbuch und Tagesdokumentation ab den  " & SafeData.FormatDateDe(DsLogbuch.Dokumentation.Rows(aaa - 1)("datum")) & " fehlen" Else Label10.Text = "o.k."
        End If
    End Sub
    Private Sub Sicherheit()
        Dim rp As System.Data.DataRowView = bsSicherheitseinweisung.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Sicherheitseinweisung where toernbezeichnung = '" & TextBox1.Text & "'"
        bsSicherheitseinweisung.CancelEdit()
        DsLogbuch.Sicherheitseinweisung.Clear()
        pAdapter.Fill(DsLogbuch.Sicherheitseinweisung)
        bsSicherheitseinweisung.Position = 0
        aaa = bsSicherheitseinweisung.Count
        If aaa > 0 Then
             If DsLogbuch.Sicherheitseinweisung.Rows(0)("lifebelt") And
                DsLogbuch.Sicherheitseinweisung.Rows(0)("Feuer") And
                DsLogbuch.Sicherheitseinweisung.Rows(0)("Gas") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Rettungsinsel") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Signalmittel") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("POB") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Gesundheit") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Dokumentation") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Innen") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Pantry") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("EleAnlagen") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Sprechfunk") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Motor") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Segel") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Aussen") And
                 DsLogbuch.Sicherheitseinweisung.Rows(0)("Wasser") Then
                Label9.Text = "o.k."
            Else
                Label9.Text = "Sicherheitseiweisung wurde nicht durchgeführt."
            End If
        End If
    End Sub
    Private Sub SuchenMaengel()
        Dim rp As System.Data.DataRowView = bsMaengel.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from Maengel where toernbezeichnung = '" & TextBox1.Text & "'  order by datum"
        bsMaengel.CancelEdit()
        DsLogbuch.Maengel.Clear()
        pAdapter.Fill(DsLogbuch.Maengel)
        bsMaengel.Position = 0
        aaa = bsMaengel.Count
        If aaa = 0 Then
            Label12.Text = "Keine Mängel am Boot festgestellt."
        Else
            Label12.Text = aaa + " Mängel am Boot festgestellt."
        End If
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
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub
    Private Sub DataGridtoern_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridtoern.MouseClick
        suchen()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Cover.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Sicherheitseinweisung.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Logdaten.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Zusammenfassung.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Maengel.Show()
        '      Me.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        suchen()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        WAdapter.SelectCommand = New OleDb.OleDbCommand
        WAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        WAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & TextBox1.Text & "' order by datum"
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        WAdapter.Fill(DsLogbuch.LogWacheplan)
        aaa = bsLogWacheplan.Count
        If aaa > 0 Then
            '                                             Wacheplan bereits vorhanden
            msg = MsgBox(" Wacheplan für das Logbuch ist bereits vorhanden. Soll er neu erstellt werden?", 1, "Wacheplan überschreiben")
            If msg = vbOK Then
                WAdapter.SelectCommand = New OleDb.OleDbCommand
                WAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
                WAdapter.SelectCommand.CommandText = "delete * from LogWacheplan where toern = '" & TextBox1.Text & "' "
                bsLogWacheplan.CancelEdit()
                DsLogbuch.LogWacheplan.Clear()
                WAdapter.Fill(DsLogbuch.LogWacheplan)
                logWache()
            End If
        Else
                logWache()
                Label1.Text = "Wacheplan ist bereits in das Logbuch kopiert."
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub logWache()
        '       Dim datmu As Date = CDate(MaskedTextBox2.Text)
        '      Dim mmon As Single = Month(datmu)
        '     Dim ttag As Single = MaskedTextBox2.Text.Substring(0, 2)
        '    Dim yyear As Single = Year(datmu)
        Dim rw As System.Data.DataRowView = bsLogWacheplan.Current
        Me.Cursor = Cursors.WaitCursor
        WAdapter.SelectCommand = New OleDb.OleDbCommand
        WAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=logbuch.mdb")
        '       WAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & toerna & "'  zeitvon"
        WAdapter.SelectCommand.CommandText = "Select * from LogWacheplan where toern = '" & TextBox1.Text & "' order by datum"
        bsLogWacheplan.CancelEdit()
        DsLogbuch.LogWacheplan.Clear()
        WAdapter.Fill(DsLogbuch.LogWacheplan)
        aaa = bsLogWacheplan.Count
        '     bsLogWacheplan.Position = bsLogWacheplan.Count - 1
        If aaa = 0 Then
            Dim rt As System.Data.DataRowView = bsWacheplan.Current
            tAdapter.SelectCommand = New OleDb.OleDbCommand
            tAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
            tAdapter.SelectCommand.CommandText = "Select * from wacheplan where toern = '" & TextBox1.Text & "'  order by datum1"
            bsWacheplan.CancelEdit()
            dsToernverwaltung.Wacheplan.Clear()
            tAdapter.Fill(dsToernverwaltung.Wacheplan)
            aaa = bsWacheplan.Count
            If aaa = 0 Then
                MsgBox("Für den Törn ist kein Wacheplan erstellt.")
                Dim datleerA As Date = CDate(datvon)
                Dim datleerB As Date = CDate(datbis)
                Dim datdiff As Long = DateDiff(DateInterval.Day, datleerA, datleerB)

                For iii = 0 To datdiff + 1
                    TextBox27.Text = "-"
                    TextBox28.Text = "-"
                    TextBox32.Text = TextBox1.Text
                    TextBox31.Text = DateAdd(DateInterval.Day, iii - 1, datleerA)
                    bsLogWacheplan.AddNew()
                    taLogWacheplan.Update(DsLogbuch.LogWacheplan)
                Next
            Else
                bsLogWacheplan.AddNew()
                For iii = 0 To aaa - 1
                    TextBox27.Text = dsToernverwaltung.Wacheplan.Rows(iii)("Person1").ToString
                    TextBox28.Text = dsToernverwaltung.Wacheplan.Rows(iii)("Person2").ToString
                    TextBox2.Text = dsToernverwaltung.Wacheplan.Rows(iii)("Person3").ToString
                    TextBox33.Text = dsToernverwaltung.Wacheplan.Rows(iii)("vzname1").ToString
                    TextBox34.Text = dsToernverwaltung.Wacheplan.Rows(iii)("vzname2").ToString
                    TextBox3.Text = dsToernverwaltung.Wacheplan.Rows(iii)("vzname3").ToString
                    TextBox29.Text = SafeData.FormatTimeHm(dsToernverwaltung.Wacheplan.Rows(iii)("Datum1"))
                    If iii < aaa - 1 Then
                        TextBox30.Text = SafeData.FormatTimeHm(dsToernverwaltung.Wacheplan.Rows(iii + 1)("Datum1"))
                    Else
                        TextBox30.Text = "Ende"
                    End If
                    TextBox31.Text = SafeData.FormatDateDe(dsToernverwaltung.Wacheplan.Rows(iii)("datum1"))
                    TextBox32.Text = TextBox1.Text
                    bsLogWacheplan.AddNew()
                    taLogWacheplan.Update(DsLogbuch.LogWacheplan)
                Next
            End If

        End If
    End Sub
End Class