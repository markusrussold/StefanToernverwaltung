Public Class Kalkulationsblatt
    Public aenderung As Boolean
    Public aaa As String
    Public iii As Integer
    Public ij As Integer
    Public Anzahlung As Single
    Public Restzahlung As Single
    Public Wochen As Integer
    Public Konto As String
    Public Bic As String
    Public BLZ As String
    Public IBAN As String
    Public Drucksteuerung As String
    Public clubrabatt As Boolean
    Public charterskonto1 As Boolean
    Public charterskonto2 As Boolean
    Public zweiteSeite As Boolean
    Dim ok As Boolean
    Dim position As Integer
    Dim buch1 As String
    Private Sub Kalkulationsblatt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Me.taBootKalkulation.Fill(Me.dsToernverwaltung.BootKalkulation)
        Me.taToernKalkulation.Fill(Me.dsToernverwaltung.ToernKalkulation)
         Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernKalkulation.Current
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)


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
        End If

        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from toernkalkulation"
        bsToernKalkulation.CancelEdit()
        dsToernverwaltung.ToernKalkulation.Clear()
        pAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        bsToernKalkulation.Position = 0
        bsToernKalkulation.AddNew()
        If IsDBNull(GetSetting("toern", "Anzahlung", "T", "0")) Then
            Anzahlung = 0
        Else
            Anzahlung = GetSetting("toern", "Anzahlung", "T", "0")
        End If
        If IsDBNull(GetSetting("toern", "Restzahlung", "T", "0")) Then
            Restzahlung = 0
        Else
            Restzahlung = GetSetting("toern", "Restzahlung", "T", "0")
        End If
        If IsDBNull(GetSetting("toern", "Wochen", "T", "0")) Then
            Wochen = 0
        Else
            Wochen = GetSetting("toern", "Wochen", "T", "0")
        End If
        Konto = GetSetting("Toern", "Konto", "T", "0")
        Bic = GetSetting("Toern", "Bic", "T", "0")
        BLZ = GetSetting("Toern", "BLZ", "T", "0")
        IBAN = GetSetting("Toern", "IBAN", "T", "0")
        TextBox7.Text = Anzahlung
        TextBox8.Text = Restzahlung
        TextBox9.Text = Wochen
        TextBox11.Text = Konto
        TextBox14.Text = Bic
        TextBox12.Text = BLZ
        TextBox13.Text = IBAN
        CheckBox1.Checked = False
        CheckBox2.Checked = True
        DataGridView1.Visible = False
        GroupBox4.Text = "Bemerkung"
        GroupBox1.Focus()
        TextBox2.Text = GetSetting("Toern", "Logbuch", "T", "")
        TextBox2.Focus()
        Drucken.Enabled = False
    End Sub

    Private Sub anzeige()
        Dim Reisekosten As Single
        Dim Bordkassa As Single
        Dim Versicherung As Single
        Dim Charterkosten As Single
        Dim temp As Single
        Dim bootn As String
        Dim lang As Integer
        Dim bAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rb As System.Data.DataRowView = bsBoot.Current
        bAdapter.SelectCommand = New OleDb.OleDbCommand
        bAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        If Not DBNull.Value.Equals(dsToernverwaltung.ToernKalkulation.Rows(0)("boot")) Then
            lang = dsToernverwaltung.ToernKalkulation.Rows(0)("boot").IndexOf("/")
            If lang > 0 Then
                bootn = dsToernverwaltung.ToernKalkulation.Rows(0)("boot").Substring(0, lang)
            Else
                bootn = dsToernverwaltung.ToernKalkulation.Rows(0)("boot")
            End If
        Else
            bootn = " "
        End If
        bAdapter.SelectCommand.CommandText = "Select * from boot where bootname like '%" & bootn & "%'"
        bsBoot.CancelEdit()
        dsToernverwaltung.Boot.Clear()
        bAdapter.Fill(dsToernverwaltung.Boot)
        If bsBoot.Count = 1 And dsToernverwaltung.Boot.Rows(0)("Clubnachlas") Then
            clubrabatt = True
            CheckBox3.Checked = True
        Else
            clubrabatt = False
            CheckBox3.Checked = False
        End If
        If dsToernverwaltung.ToernKalkulation.Rows(0)("rabatt1") > 0 Then
            charterskonto1 = True
        Else
            charterskonto1 = False
        End If
        If dsToernverwaltung.ToernKalkulation.Rows(0)("rabatt2") > 0 Then
            charterskonto2 = True
        Else
            charterskonto2 = False
        End If
        temp = dsToernverwaltung.ToernKalkulation.Rows(0)("Charterkosten")
        Charterkosten = temp - (temp / 100) * dsToernverwaltung.ToernKalkulation.Rows(0)("rabatt1")
        Charterkosten = Charterkosten - (Charterkosten / 100) * dsToernverwaltung.ToernKalkulation.Rows(0)("rabatt2")
        temp = dsToernverwaltung.ToernKalkulation.Rows(0)("Skipperverdienst")
        Charterkosten += temp
        TextBox1.Text = Format(Charterkosten, "##,##.00")
        Reisekosten = 0
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Flugpreis"))
        Reisekosten = Reisekosten + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Autoanreisekosten"))
        Reisekosten = Reisekosten + temp / 3
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Marinaanfahrt"))
        Reisekosten = Reisekosten + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Marinarueckfahrt"))
        Reisekosten = Reisekosten + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Leihwagen"))
        Reisekosten = Reisekosten + temp
        Bordkassa = dsToernverwaltung.ToernKalkulation.Rows(0)("Einkaufstaxi")
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Treibstoff"))
        Bordkassa = Bordkassa + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Bunkern"))
        Bordkassa = Bordkassa + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Landmahlzeiten"))
        Bordkassa = Bordkassa + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Marinakosten"))
        Bordkassa = Bordkassa + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Permit"))
        Bordkassa = Bordkassa + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Endreinigung"))
        Bordkassa = Bordkassa + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Sonstigekosten"))
        Bordkassa = Bordkassa + temp
        Versicherung = dsToernverwaltung.ToernKalkulation.Rows(0)("Haftpflichtversicherung")
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Unfallversicherung"))
        Versicherung = Versicherung + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Rechtsschutzversicherung"))
        Versicherung = Versicherung + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Beschlagnahmerisiko"))
        Versicherung = Versicherung + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Kautionsversicherung"))
        Versicherung = Versicherung + temp
        temp = checkDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Rücktrittsversicherung"))
        Versicherung = Versicherung + temp
        If IsDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Folgeschadenversicherung")) = False Then
            temp = dsToernverwaltung.ToernKalkulation.Rows(0)("Folgeschadenversicherung")
            Versicherung = Versicherung + temp
        Else
            TextBox15.Text = 0
        End If


        If TextBox2.Text > "" Then
            TextBox3.Text = Reisekosten.ToString("##,##.00")
            TextBox4.Text = Bordkassa.ToString("##,##.00")
            TextBox5.Text = Versicherung.ToString("##,##.00")
        End If
        GroupBox1.Enabled = True
        Drucken.Enabled = True
        Anzahlung = TextBox7.Text
        Restzahlung = TextBox8.Text
        Wochen = TextBox9.Text
        Konto = TextBox11.Text
        Bic = TextBox14.Text
        BLZ = TextBox12.Text
        IBAN = TextBox13.Text
    End Sub
    Private Function checkDBNull(ByRef wert)
        Dim check As Single
        If IsDBNull(wert) = False Then
            check = wert
        Else
            check = 0
        End If
        Return check
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        suchen()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        suchen()
        DataGridView1.Visible = False
        Drucken.Enabled = True
        GroupBox4.Text = "Bemerkung"
        anzeige()
    End Sub

    Private Sub suchen()
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsToernKalkulation.Current
        GroupBox1.Enabled = False
        Drucken.Enabled = False
        GroupBox4.Text = "Törn auswählen mit Doppelklick"
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox2.Text = RTrim(TextBox2.Text)
        If TextBox2.Text > "  " Then
            If IsNumeric(TextBox2.Text) And Len(TextBox2.Text) = 4 Then
                xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where year(toernanfang) like '%" & TextBox2.Text & "%'  order by toern"
            Else
                If Len(TextBox2.Text) > 1 Then
                    If Mid(TextBox2.Text, 2, 1) = "*" Then
                        buch1 = Mid(TextBox2.Text, 1, 1).ToUpper
                        xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation order by toern"
                    Else
                        xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where toern like '%" & TextBox2.Text & "%'  order by toern"
                    End If
                Else
                    xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation where Mid(toern,1,1) like '%" & TextBox2.Text & "%'  order by toern"
                End If
            End If
        Else
            xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation order by toern"
        End If
        bsToernKalkulation.CancelEdit()
        aenderung = True
        dsToernverwaltung.ToernKalkulation.Clear()
        xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
        Select Case bsToernKalkulation.Count
            Case 0
                MsgBox("Kein Name mit angegebenen Buchstabenkombination vorhanden")
                xAdapter.SelectCommand.CommandText = "Select * from Toernkalkulation  order by toern"
                xAdapter.Fill(dsToernverwaltung.ToernKalkulation)
                '              Formularloeschen()
            Case 1
                If IsDBNull(dsToernverwaltung.ToernKalkulation.Rows(0)("Crewanzahl")) Then
                    MsgBox("Bei der Törnkalkulation muss die geplante Crewanzahl festgelegt werden.  - Abbruch")
                    GoTo ende
                Else
                    If dsToernverwaltung.ToernKalkulation.Rows(0)("Crewanzahl") < 1 Then
                        MsgBox("Bei der Törnkalkulation muss die geplante Crewanzahl festgelegt werden.  - Abbruch")
                        GoTo ende
                    End If
                End If
                GroupBox1.Enabled = True
                Drucken.Enabled = True
                Drucken.Enabled = True
                anzeige()
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                bsToernKalkulation.Position = position
                buch1 = ""
                DataGridView1.Visible = True
                '               DataGridView1.Location = New Point(10, 20)
        End Select
ende:
    End Sub
    Private Sub positionieren()
        iii = bsToernkalkulation.Count - 1
        For i = 0 To iii
            aaa = Mid(dsToernverwaltung.ToernKalkulation.Rows(i)("toern").ToString, 1, 1).ToUpper
            If buch1 = aaa Then
                position = i
                GoTo Gefunden
            End If
        Next
Gefunden:
    End Sub


    Private Sub Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drucken.Click
        Dim X As New PrintOut
        Dim dv As DataView
        Dim t As DataTable
        If CheckBox1.Checked = True Then
            Drucksteuerung = "1"
        Else
            Drucksteuerung = "0"
        End If
        If CheckBox2.Checked = True Then
            aenderung = dsToernverwaltung.ToernKalkulation.Rows(0)("skipperversicherung")
            If aenderung = True Then
                Drucksteuerung = Drucksteuerung & "1"
            Else
                Drucksteuerung = Drucksteuerung & "0"
            End If
            aenderung = dsToernverwaltung.ToernKalkulation.Rows(0)("skippercharterkosten")
            If aenderung = True Then
                Drucksteuerung = Drucksteuerung & "1"
            Else
                Drucksteuerung = Drucksteuerung & "0"
            End If
            aenderung = dsToernverwaltung.ToernKalkulation.Rows(0)("skipperbordkassa")
            If aenderung = True Then
                Drucksteuerung = Drucksteuerung & "1"
            Else
                Drucksteuerung = Drucksteuerung & "0"
            End If
        Else
            Drucksteuerung = Drucksteuerung & "   "
        End If
         SaveSetting("Toern", "Drucksteuerung", "T", Drucksteuerung)
        If ok Then
            dv = bsToernKalkulation.List
            zweiteSeite = False
            t = dv.ToTable("Printing", False, "Toern", "Boot", "Charterkosten", "Crewanteil", "Hinflugdatum", "Rueflugdatum", "Flugpreis", "Marinaanfahrt", "Marinarueckfahrt", "Einkaufstaxi", "Crewanzahl", "Treibstoff", "Bemerkung", "Hinflugnr", "RueFlugnr", "Haftpflichtversicherung", "Unfallversicherung", "Rechtsschutzversicherung", "Beschlagnahmerisiko", "Kautionsversicherung", "Rücktrittsversicherung", "Bunkern", "Landmahlzeiten", "Marinakosten", "Flughafen", "Sonstigekosten", "NettoChartVerAnteil", "Permit", "Rabatt1", "Rabatt2", "Aussenborder", "Endreinigung", "Autoanreisekosten", "Skipperverdienst", "Toernanfang", "Toernende", "Route", "Skipper", "Folgeschadenversicherung", "BruttoChartVerAnteil", "Reserve2", "Reserve1")
            X.PrintKalkulation(t)
            If charterskonto2 And clubrabatt Then
                clubrabatt = False
                zweiteSeite = True
                dv = bsToernKalkulation.List
                t = dv.ToTable("Printing", False, "Toern", "Boot", "Charterkosten", "Crewanteil", "Hinflugdatum", "Rueflugdatum", "Flugpreis", "Marinaanfahrt", "Marinarueckfahrt", "Einkaufstaxi", "Crewanzahl", "Treibstoff", "Bemerkung", "Hinflugnr", "RueFlugnr", "Haftpflichtversicherung", "Unfallversicherung", "Rechtsschutzversicherung", "Beschlagnahmerisiko", "Kautionsversicherung", "Rücktrittsversicherung", "Bunkern", "Landmahlzeiten", "Marinakosten", "Flughafen", "Sonstigekosten", "NettoChartVerAnteil", "Permit", "Rabatt1", "Rabatt2", "Aussenborder", "Endreinigung", "Autoanreisekosten", "Skipperverdienst", "Toernanfang", "Toernende", "Route", "Skipper", "Folgeschadenversicherung", "BruttoChartVerAnteil", "Reserve2", "Reserve1")
                X.PrintKalkulation(t)
            End If
        Else
            MsgBox("Funktion - Drucken - unterstützt nur die freigeschaltete Version. ")
        End If

        '                                    Zahlungstermine und Kosten zurückschreiben


        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsBootKalkulation.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        TextBox2.Text = RTrim(TextBox2.Text)
        xAdapter.SelectCommand.CommandText = "Select * from bootkalkulation where toern like '%" & TextBox2.Text & "%' order by toern"
        bsBootKalkulation.CancelEdit()
        aenderung = True
        dsToernverwaltung.BootKalkulation.Clear()
        xAdapter.Fill(dsToernverwaltung.BootKalkulation)
        bsBootKalkulation.Position = 0
        For i = 0 To bsBootKalkulation.Count - 1
            '          dsToernverwaltung.BootKalkulation.Rows(i)("anteil") = dsToernverwaltung.BootKalkulation.Rows(i)("Kosten").ToString() * Anzahlung / 100
            '         Restdatum = TextBox19.Text
            '        dsToernverwaltung.BootKalkulation.Rows(i)("Datumrest") = Restdatum.AddDays(-Wochen * 7)
            '       bsBootKalkulation.EndEdit()
            '      taBootKalkulation.Update(dsToernverwaltung.BootKalkulation)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Anzahlung = TextBox7.Text
        Restzahlung = TextBox8.Text
        Wochen = TextBox9.Text
        Konto = TextBox11.Text
        Bic = TextBox14.Text
        BLZ = TextBox12.Text
        IBAN = TextBox13.Text
        SaveSetting("Toern", "Anzahlung", "T", Anzahlung)
        SaveSetting("Toern", "Restzahlung", "T", Restzahlung)
        SaveSetting("Toern", "Wochen", "T", Wochen)
        SaveSetting("Toern", "Konto", "T", Konto)
        SaveSetting("Toern", "Bic", "T", Bic)
        SaveSetting("Toern", "BLZ", "T", BLZ)
        SaveSetting("Toern", "IBAN", "T", IBAN)

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub

End Class