Public Class Menü
    Public screenwidth As Single = My.Computer.Screen.WorkingArea.Width.ToString
    Public screenheight As Single = My.Computer.Screen.WorkingArea.Height.ToString
    Public druckzeile As Integer
    Public ToernKey As String
    Public charterkye As String
    Public bootkey As String
    Public crewkey As String
    Public werbungg As String
    Public AcrobatReader As String = "Acrobat.exe"
    Friend Shared RestText As String
    Friend Shared FreischaltZiffer As String
    Public freischaltung As String
    Public programmquelle As String
    Public ordner As String
    Friend Shared charterkey As String
    Dim deutschland As String
    Dim Speicherbild As String
    Dim ok As Boolean
    Dim leer As String = "                                               "
    Dim j As Integer
    Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
    Dim mon As Single
    Dim ttag As Single
    Dim geburtstag As String
    Dim leerJN As Boolean
    Dim leerJN1 As Boolean
    Dim Marina As String
    Dim saldo As Boolean
    Dim saldobetrag As Single
    Dim faellig As String
    Dim verz As String = Environment.CurrentDirectory
    Dim speicheradressen As String
    Dim speicherformular As String
    Dim logbuch As String
    Dim boot1 As String
    Dim bericht As String
    Dim Karte As String
    Dim pdfname As String
    Dim Foto As String
    Dim sign As String
    Dim aaa As String
    Dim MeldungsZeile As Integer = -1
    Dim erstinstallation As String

    Private Sub Menü_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.taSteuerdaten.Fill(Me.dsToernverwaltung.Steuerdaten)
        Me.taTeilnehmer.Fill(Me.DsAusbildung.Teilnehmer)
        Me.taBootKalkulation.Fill(Me.dsToernverwaltung.BootKalkulation)
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)

        '       Definition der Versionen    X.ZZ.Y      :
        '            X ändert sich bei Datenbankänderung
        '            Z ändert sich bei Funktionsänderung/Ergänzung
        '            Y ändert sich bei Fehlerbehebung
        Me.Text = "Törnverwaltung Version 13.02.04"
        '
        '
        SaveSetting("Datenbank", "neu", "T", SafeData.ExtractVersionStamp(Me.Text))
        version(Me.Text)
        If Me.Text.StartsWith("Falsch") Then
            Application.Exit()
            End
        End If
        SaveSetting("Datenbank", "alt", "T", SafeData.ExtractVersionStamp(Me.Text))

        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung
        FreischaltZiffer = GetSetting("Ziffer", "Einstellungen", "T", "0")

        Try
        Catch ex As Exception
        End Try

        Label26.Text = Today
        Label57.Text = WeekdayName(Weekday(Today, FirstDayOfWeek.Monday))
        Speicherbild = GetSetting("ToernLogo", "Pfad", "T", " ")
        If Speicherbild = " " Then
            SaveSetting("ToernLogo", "Pfad", "T", Speicherbild)
        End If
        deutschland = GetSetting("Land", "Einstellungen", "T", " ")
        If deutschland = " " Then
            deutschland = "A"
            SaveSetting("Land", "Einstellungen", "T", deutschland)
        End If
        Dim D1 As Integer
        D1 = GetSetting("D1", "Einstellungen", "T", "95")
        If D1 > 0 Then
            druckzeile = D1
        Else
            druckzeile = 110
        End If
        freischaltung = GetSetting("toern", "Pfad", "T")
        If freischaltung Is Nothing Then
        Else
            ok = CheckKurs.keypruefen(freischaltung)
        End If
        freischaltung = GetSetting("Toern", "Pfad", "T")
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        Dim ok1 As Boolean = True
        Dim ok2 As Boolean = False
        Dim ok3 As Boolean = False
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)

        Select Case FreischaltZiffer
            Case 0
                freischaltung = False
                KursmaterialToolStripMenuItem.Visible = False
                KurseToolStripMenuItem.Visible = False
                KursablaufToolStripMenuItem.Visible = False
                AktivitätenToolStripMenuItem.Visible = False
                TexteMarketingToolStripMenuItem.Visible = False
                StandortToolStripMenuItem.Visible = False
            Case 1
                freischaltung = True
                KursmaterialToolStripMenuItem.Visible = False
                KurseToolStripMenuItem.Visible = False
                KursablaufToolStripMenuItem.Visible = False
                AktivitätenToolStripMenuItem.Visible = False
                TexteMarketingToolStripMenuItem.Visible = False
                StandortToolStripMenuItem.Visible = False
            Case 2
                freischaltung = False
                KurseToolStripMenuItem.Visible = True
                KursablaufToolStripMenuItem.Visible = True
                AktivitätenToolStripMenuItem.Visible = True
                TexteMarketingToolStripMenuItem.Visible = True
            Case 3
                freischaltung = True
                KurseToolStripMenuItem.Visible = True
                KursablaufToolStripMenuItem.Visible = True
                AktivitätenToolStripMenuItem.Visible = True
                TexteMarketingToolStripMenuItem.Visible = True
            Case 4
                freischaltung = True
                KurseToolStripMenuItem.Visible = True
                KursablaufToolStripMenuItem.Visible = True
                AktivitätenToolStripMenuItem.Visible = True
                TexteMarketingToolStripMenuItem.Visible = True
            Case Else
                KurseToolStripMenuItem.Visible = True
                KursablaufToolStripMenuItem.Visible = True
                AktivitätenToolStripMenuItem.Visible = True
                TexteMarketingToolStripMenuItem.Visible = True
        End Select

        ToernKey = " "
        crewkey = " "
        bootkey = " "
        ttag = DateTime.Now.Day
        mon = Month(Today)
        loeschen()

        geburtstage()
        Toernkosten()
        kurskosten()
        materialkosten()
        speicherorte()

        pdfname = "Handbuch.pdf"
        If System.IO.File.Exists(pdfname) Then
            Label58.Visible = True
        End If

        FormUi.CenterMain(Me)
    End Sub

    Private Sub Menü_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        FormUi.CenterMain(Me)
    End Sub

    Private Sub Toernkosten()
        '                                    Zahlungen Törns

        Dim rechts As String = " "
        Dim btrgr1 As Single
        Dim btrgre As Single
        Dim btrgbe As Single
        Dim datum1 As Date = System.DateTime.Now
        Dim datum2 As String
       Dim datum4 As Date
        Dim grosser As Boolean
        Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rk As System.Data.DataRowView = bsBootKalkulation.Current
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from bootkalkulation order by toern"
        bsBootKalkulation.CancelEdit()
        dsToernverwaltung.BootKalkulation.Clear()
        kAdapter.Fill(dsToernverwaltung.BootKalkulation)
        If bsBootKalkulation.Count > 0 Then
            bsBootKalkulation.Position = 0
        End If
        '      j = bsCrewAdressen.Count + 1
        j = 1
        If bsBootKalkulation.Count > 0 Then
            For i = 0 To bsBootKalkulation.Count - 1
                leer = "Fällige Törnkosten:            "
                saldo = False
                faellig = FormatDateDe(Now)
                Dim dueAnzahlung As Date
                If SafeData.TryParseDate(dsToernverwaltung.BootKalkulation.Rows(i)("datumanzahlung"), dueAnzahlung) Then
                    datum4 = dueAnzahlung
                    If datum1 > datum4 Then
                        btrgr1 = SafeData.ParseNumberOrZero(dsToernverwaltung.BootKalkulation.Rows(i)("r1"))
                        btrgbe = SafeData.ParseNumberOrZero(dsToernverwaltung.BootKalkulation.Rows(i)("bezahlt"))
                        If Now.Date > dueAnzahlung.Date And btrgbe < btrgr1 Then
                            saldobetrag = CSng(btrgr1 - btrgbe)
                            saldo = True
                            faellig = FormatDateDe(dueAnzahlung)
                        End If
                    End If
                End If
                Dim dueRest As Date
                If SafeData.TryParseDate(dsToernverwaltung.BootKalkulation.Rows(i)("datumrest"), dueRest) Then
                    datum4 = dueRest
                    If datum1 > datum4 Then
                        btrgre = SafeData.ParseNumberOrZero(dsToernverwaltung.BootKalkulation.Rows(i)("anteil"))
                        btrgbe = SafeData.ParseNumberOrZero(dsToernverwaltung.BootKalkulation.Rows(i)("bezahlt"))
                        If Now.Date > dueRest.Date And btrgbe < btrgre Then
                            saldobetrag = CSng(btrgre - btrgbe)
                            Select Case Len(Format(saldobetrag, "0.00"))
                                Case 4
                                    rechts = "     "
                                Case 5
                                    rechts = "  "
                                Case Else
                                    rechts = ""
                            End Select
                            If saldobetrag > 0 Then
                                saldo = True
                            End If
                            faellig = FormatDateDe(dueRest)
                        End If
                    End If
                End If
                Dim schuldner As String
                schuldner = dsToernverwaltung.BootKalkulation.Rows(i)("vzname").ToString + "/" + dsToernverwaltung.BootKalkulation.Rows(i)("toern").ToString
                If j > 0 Then
                    If Len(schuldner) > 70 Then
                        schuldner = SafeData.LeftSafe(schuldner, 70)
                    End If
                Else
                    If Len(schuldner) > 55 Then
                        schuldner = SafeData.LeftSafe(schuldner, 55) + "..."
                    End If
                End If
                SaldoZeigen(rechts, saldobetrag, saldo, schuldner)
                saldo = False
            Next
        End If
      End Sub
    Private Sub geburtstage()
        Dim alter As Integer
        leerJN = True
        leerJN1 = True
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        xAdapter.SelectCommand.CommandText = "Select * from CrewAdressen where month(gebdatum) = '" & mon & "' and (day(gebdatum) = '" & ttag + 1 & "' or day(gebdatum) = '" & ttag & "' or day(gebdatum) = '" & ttag + 2 & " ') order by day(gebdatum)"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        If bsCrewAdressen.Count > 0 Then
            bsCrewAdressen.Position = 0
        End If
        If bsCrewAdressen.Count > 0 Then
            For i = 0 To bsCrewAdressen.Count - 1
                If IsDBNull(dsToernverwaltung.CrewAdressen.Rows(i)("sterbedatum")) Then
                    'GoTo weiter
                Else
                    If Year(dsToernverwaltung.CrewAdressen.Rows(i)("sterbedatum")) > 2000 Then
                        GoTo weiter
                    End If
                End If
                    Dim gebDat As Date
                    If Not SafeData.TryParseDate(dsToernverwaltung.CrewAdressen.Rows(i)("gebdatum"), gebDat) Then
                        GoTo weiter
                    End If
                    geburtstag = FormatDateDe(gebDat)
                    alter = Year(Today) - Year(gebDat)
                    If gebDat.Day = ttag Then
                        If leerJN Then
                            leer = "Geburtstage heute:            "
                            leerJN = False
                        Else
                            leer = "                                               "
                        End If
                        geburtstag = geburtstag + "    ist " + Str(alter)
                    End If
                    If gebDat.Day > ttag Then
                        If leerJN1 Then
                            leer = "Geburtstage demnächst:  "
                            leerJN1 = False
                        Else
                            leer = "                                               "
                        End If
                        geburtstag = geburtstag + "    wird " + Str(alter)
                    End If
                    Select Case i
                        Case 0
                            Label11.Visible = True
                            Label11.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label25.Text = geburtstag
                        Case 1
                            Label12.Visible = True
                            Label12.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label27.Text = geburtstag
                        Case 2
                            Label13.Visible = True
                            Label13.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label28.Text = geburtstag
                        Case 3
                            Label14.Visible = True
                            Label14.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label29.Text = geburtstag
                        Case 4
                            Label15.Visible = True
                            Label15.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label30.Text = geburtstag
                        Case 5
                            Label16.Visible = True
                            Label16.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label31.Text = geburtstag
                        Case 6
                            Label17.Visible = True
                            Label17.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label32.Text = geburtstag
                        Case 7
                            Label18.Visible = True
                            Label18.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label33.Text = geburtstag
                        Case 8
                            Label19.Visible = True
                            Label19.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label34.Text = geburtstag
                        Case 9
                            Label20.Visible = True
                            Label20.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label35.Text = geburtstag
                        Case 10
                            Label21.Visible = True
                            Label21.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label36.Text = geburtstag
                        Case 11
                            Label22.Visible = True
                            Label22.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label37.Text = geburtstag
                        Case 12
                            Label23.Visible = True
                            Label23.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label38.Text = geburtstag
                        Case 13
                            Label24.Visible = True
                            Label24.Text = leer + dsToernverwaltung.CrewAdressen.Rows(i)("zuname").ToString + " " + dsToernverwaltung.CrewAdressen.Rows(i)("vorname").ToString
                            Label39.Text = geburtstag
                End Select
                MeldungsZeile = i
weiter:
            Next
        Else

        End If

    End Sub
    Private Sub speicherorte()
 

        speicherbild = GetSetting("ToernLogo", "Pfad", "T", " ")
        If speicherbild > " " Then
        Else
            speicherbild = verz + "Wikinger.jpg"
            SaveSetting("ToernLogo", "Pfad", "T", speicherbild)
        End If

        speicherformular = GetSetting("Toernformular", "Pfad", "T", " ")
        If speicherformular > " " Then
        Else
            speicherformular = verz + "Crewaufnahme.csv"
            SaveSetting("Toernformular", "Pfad", "T", speicherformular)
        End If

        speicheradressen = GetSetting("Toernadressen", "Pfad", "T", " ")
        If speicheradressen > " " Then
        Else
            speicheradressen = verz + "Adressenauswertung.csv"
            SaveSetting("Toernadressen", "Pfad", "T", speicheradressen)
        End If

        logbuch = GetSetting("Logbuch", "Pfad", "T", " ")
        If logbuch > " " Then
        Else
            logbuch = verz + "\Logbuch"
            SaveSetting("Logbuch", "Pfad", "T", logbuch)
            My.Computer.FileSystem.CreateDirectory(logbuch)
        End If

        bericht = GetSetting("Berichte", "Pfad", "T", " ")
        If bericht > " " Then
        Else
            bericht = verz + "\Berichte"
            SaveSetting("Bericht", "Pfad", "T", bericht)
            My.Computer.FileSystem.CreateDirectory(bericht)
        End If

        boot1 = GetSetting("Boot", "Pfad", "T", " ")
        If boot1 > " " Then
        Else
            boot1 = verz + "\Boote"
            SaveSetting("Boot", "Pfad", "T", boot1)
            My.Computer.FileSystem.CreateDirectory(boot1)
        End If

        sign = GetSetting("sign", "Pfad", "T", " ")
        If sign > " " Then
        Else
            sign = verz + "sign.jpg"
            SaveSetting("Sign", "Pfad", "T", sign)
        End If

        Foto = GetSetting("Foto", "Pfad", "T", " ")
        If Foto > " " Then
        Else
            Foto = verz + "\Crewfotos"
            SaveSetting("Foto", "Pfad", "T", Foto)
            My.Computer.FileSystem.CreateDirectory(Foto)
        End If

        Marina = GetSetting("Marina", "Pfad", "T", " ")
        If Marina > " " Then
        Else
            Marina = verz + "\Marina"
            SaveSetting("Marina", "Pfad", "T", Marina)
            My.Computer.FileSystem.CreateDirectory(Marina)
        End If

        Karte = GetSetting("Karte", "Pfad", "T", " ")
        If Karte > " " Then
        Else
            Karte = verz + "\Karten"
            SaveSetting("Karte", "Pfad", "T", Karte)
            My.Computer.FileSystem.CreateDirectory(Karte)
        End If
    End Sub
 
    Private Sub SaldoZeigen(ByVal rechts, ByVal saldobetrag, ByVal saldo, ByVal Name)
        If saldo Then
            Select Case MeldungsZeile + 1
                Case 0
                    Label11.Visible = True
                    Label11.Text = leer + Name
                    Label25.Text = SafeData.LeftSafe(faellig, 10)
                    Label40.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 1
                    Label12.Visible = True
                    Label12.Text = leer + Name
                    Label27.Text = SafeData.LeftSafe(faellig, 10)
                    Label41.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 2
                    Label13.Visible = True
                    Label13.Text = leer + Name
                    Label28.Text = SafeData.LeftSafe(faellig, 10)
                    Label42.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 3
                    Label14.Visible = True
                    Label14.Text = leer + Name
                    Label29.Text = SafeData.LeftSafe(faellig, 10)
                    Label43.Text = Format(saldobetrag, "  0.00") + " €"
                Case 4
                    Label15.Visible = True
                    Label15.Text = leer + Name
                    Label30.Text = SafeData.LeftSafe(faellig, 10)
                    Label44.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 5
                    Label16.Visible = True
                    Label16.Text = leer + Name
                    Label31.Text = SafeData.LeftSafe(faellig, 10)
                    Label45.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 6
                    Label17.Visible = True
                    Label17.Text = leer + Name
                    Label32.Text = SafeData.LeftSafe(faellig, 10)
                    Label46.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 7
                    Label18.Visible = True
                    Label18.Text = leer + Name
                    Label33.Text = SafeData.LeftSafe(faellig, 10)
                    Label47.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 8
                    Label19.Visible = True
                    Label19.Text = leer + Name
                    Label34.Text = SafeData.LeftSafe(faellig, 10)
                    Label48.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 9
                    Label20.Visible = True
                    Label20.Text = leer + Name
                    Label35.Text = SafeData.LeftSafe(faellig, 10)
                    Label49.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 10
                    Label21.Visible = True
                    Label21.Text = leer + Name
                    Label36.Text = SafeData.LeftSafe(faellig, 10)
                    Label50.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 11
                    Label22.Visible = True
                    Label22.Text = leer + Name
                    Label37.Text = SafeData.LeftSafe(faellig, 10)
                    Label51.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 12
                    Label23.Visible = True
                    Label23.Text = leer + Name
                    Label38.Text = SafeData.LeftSafe(faellig, 10)
                    Label52.Text = rechts + Format(saldobetrag, "  0.00") + " €"
                Case 13
                    Label24.Visible = True
                    Label24.Text = leer + Name
                    Label39.Text = SafeData.LeftSafe(faellig, 10)
                    Label53.Text = rechts + Format(saldobetrag, "  0.00") + " €"
            End Select
            MeldungsZeile += 1
            leer = "                                    "
        End If
    End Sub
    Private Sub materialkosten()
        Dim saldo As Boolean
        Dim saldobetrag As Single
        Dim faellig As String
        '                                    Zahlungen Kurse
        Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rk As System.Data.DataRowView = bsTeilnehmer.Current
        Dim rechts As String = " "
        faellig = Now
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from teilnehmer order by vzname"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        kAdapter.Fill(DsAusbildung.Teilnehmer)
        If bsTeilnehmer.Count > 0 Then
            bsTeilnehmer.Position = 0
        End If
        If bsTeilnehmer.Count > 0 Then
            For i = 0 To bsTeilnehmer.Count - 1
                leer = "Fällige Materialkosten:     "
                If DsAusbildung.Teilnehmer.Rows(i)("datummatfaellig").ToString > "" Then
                    If Now > DsAusbildung.Teilnehmer.Rows(i)("datummatfaellig").ToString And DsAusbildung.Teilnehmer.Rows(i)("materialbezahlt").ToString < DsAusbildung.Teilnehmer.Rows(i)("materialpreis").ToString Then
                        If DsAusbildung.Teilnehmer.Rows(i)("datummatbezahlt").ToString > " " Then
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("materialpreis").ToString - DsAusbildung.Teilnehmer.Rows(i)("materialbezahlt").ToString
                        Else
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("materialpreis").ToString
                        End If
                        saldo = True
                        faellig = DsAusbildung.Teilnehmer.Rows(i)("datumkbfaellig").ToString
                    End If
                End If
                ' 
                If DsAusbildung.Teilnehmer.Rows(i)("datummatbezahlt").ToString > "" Then
                    If Now > DsAusbildung.Teilnehmer.Rows(i)("datummatbezahlt").ToString And DsAusbildung.Teilnehmer.Rows(i)("materialbezahlt").ToString < DsAusbildung.Teilnehmer.Rows(i)("materialpreis").ToString Then
                        If DsAusbildung.Teilnehmer.Rows(i)("materialbezahlt").ToString > " " Then
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("materialpreis").ToString - DsAusbildung.Teilnehmer.Rows(i)("materialbezahlt").ToString
                        Else
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("materialpreis").ToString
                        End If
                        Select Case Len(Format(saldobetrag, "0.00"))
                            Case 4
                                rechts = "     "
                            Case 5
                                rechts = "  "
                            Case Else
                                rechts = ""
                        End Select
                        If saldobetrag > 0 Then
                            saldo = True
                        End If
                        faellig = DsAusbildung.Teilnehmer.Rows(i)("datummatfaellig").ToString
                    End If
                End If
                SaldoZeigen(rechts, saldobetrag, saldo, DsAusbildung.Teilnehmer.Rows(i)("vzname").ToString)
                saldobetrag = 0
                saldo = False
                '             leer = "                        "
            Next
        Else

        End If
    End Sub
    Private Sub kurskosten()
        Dim saldo As Boolean
        Dim saldobetrag As Single
        Dim faellig As String
        '                                    Zahlungen Kurse
        Dim kAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rk As System.Data.DataRowView = bsTeilnehmer.Current
        Dim rechts As String = " "
        faellig = Now
        kAdapter.SelectCommand = New OleDb.OleDbCommand
        kAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ausbildung.mdb")
        kAdapter.SelectCommand.CommandText = "Select * from teilnehmer order by vzname"
        bsTeilnehmer.CancelEdit()
        DsAusbildung.Teilnehmer.Clear()
        kAdapter.Fill(DsAusbildung.Teilnehmer)
        If bsTeilnehmer.Count > 0 Then
            bsTeilnehmer.Position = 0
        End If
        If bsTeilnehmer.Count > 0 Then
            For i = 0 To bsTeilnehmer.Count - 1
                leer = "Fällige Kurskosten:            "
                '          MsgBox(i.ToString + " " + dsAusbildung.Teilnehmer.Rows(i)("datumkbfaellig").ToString + " " + dsAusbildung.Teilnehmer.Rows(i)("vzname").ToString)
                If DsAusbildung.Teilnehmer.Rows(i)("datumkbfaellig").ToString > "" Then
                    If Now > DsAusbildung.Teilnehmer.Rows(i)("datumkbfaellig").ToString And DsAusbildung.Teilnehmer.Rows(i)("kursbezahlt").ToString < DsAusbildung.Teilnehmer.Rows(i)("kurspreis").ToString Then
                        If DsAusbildung.Teilnehmer.Rows(i)("datumkursbezahlt").ToString > " " Then
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("kurspreis").ToString - DsAusbildung.Teilnehmer.Rows(i)("kursbezahlt").ToString
                        Else
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("kurspreis").ToString
                        End If
                        saldo = True
                        faellig = DsAusbildung.Teilnehmer.Rows(i)("datumkbfaellig").ToString
                    End If
                End If
                ' 
                If DsAusbildung.Teilnehmer.Rows(i)("datumkursbezahlt").ToString > "" Then
                    If Now > DsAusbildung.Teilnehmer.Rows(i)("datumkursbezahlt").ToString And DsAusbildung.Teilnehmer.Rows(i)("kursbezahlt").ToString < DsAusbildung.Teilnehmer.Rows(i)("kurspreis").ToString Then
                        If DsAusbildung.Teilnehmer.Rows(i)("Kursbezahlt").ToString > " " Then
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("kurspreis").ToString - DsAusbildung.Teilnehmer.Rows(i)("kursbezahlt").ToString
                        Else
                            saldobetrag = DsAusbildung.Teilnehmer.Rows(i)("kurspreis").ToString
                        End If
                        Select Case Len(Format(saldobetrag, "0.00"))
                            Case 4
                                rechts = "     "
                            Case 5
                                rechts = "  "
                            Case Else
                                rechts = ""
                        End Select
                        If saldobetrag > 0 Then
                            saldo = True
                        End If
                        faellig = DsAusbildung.Teilnehmer.Rows(i)("datumkbfaellig").ToString
                    End If
                End If
                SaldoZeigen(rechts, saldobetrag, saldo, DsAusbildung.Teilnehmer.Rows(i)("vzname").ToString)
                saldobetrag = 0
                saldo = False
                '             leer = "                        "
            Next
        Else

        End If

    End Sub
    Private Sub loeschen()
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label25.Text = ""
        Label27.Text = ""
        Label28.Text = ""
        Label29.Text = ""
        Label30.Text = ""
        Label31.Text = ""
        Label32.Text = ""
        Label33.Text = ""
        Label34.Text = ""
        Label35.Text = ""
        Label36.Text = ""
        Label37.Text = ""
        Label38.Text = ""
        Label39.Text = ""
        Label40.Text = ""
        Label41.Text = ""
        Label42.Text = ""
        Label43.Text = ""
        Label44.Text = ""
        Label45.Text = ""
        Label46.Text = ""
        Label47.Text = ""
        Label48.Text = ""
        Label49.Text = ""
        Label50.Text = ""
        Label51.Text = ""
        Label52.Text = ""
        Label53.Text = ""
        Label54.Text = ""
        Label55.Text = ""
        Label56.Text = ""
    End Sub

    Private Sub version(ByRef Vers)
        Dim sAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from steuerdaten"
        bsSteuerdaten.CancelEdit()
        dsToernverwaltung.Steuerdaten.Clear()
        sAdapter.Fill(dsToernverwaltung.Steuerdaten)
        If bsSteuerdaten.Count = 0 Then
            Dim neu As DataRow = dsToernverwaltung.Steuerdaten.NewRow()
            neu("Bezeichnung") = "Version"
            neu("feld1") = SafeData.ExtractVersionMajor(Convert.ToString(Vers)).ToString(Globalization.CultureInfo.InvariantCulture)
            dsToernverwaltung.Steuerdaten.Rows.Add(neu)
            Try
                taSteuerdaten.Update(dsToernverwaltung.Steuerdaten)
            Catch
            End Try
            bsSteuerdaten.CancelEdit()
            dsToernverwaltung.Steuerdaten.Clear()
            sAdapter.Fill(dsToernverwaltung.Steuerdaten)
        End If
        If bsSteuerdaten.Count > 0 Then
            bsSteuerdaten.Position = 0
        End If
        If dsToernverwaltung.Steuerdaten.Rows.Count = 0 Then
            Dim neu As DataRow = dsToernverwaltung.Steuerdaten.NewRow()
            neu("Bezeichnung") = "Version"
            neu("feld1") = "0"
            dsToernverwaltung.Steuerdaten.Rows.Add(neu)
        End If

        Dim requiredMajor As Integer = SafeData.ExtractVersionMajor(Convert.ToString(Vers))
        Dim bezeichnung As String = SafeData.CoalesceString(dsToernverwaltung.Steuerdaten.Rows(0)("bezeichnung"))
        Dim feld1 As Object = dsToernverwaltung.Steuerdaten.Rows(0)("feld1")
        If bezeichnung = "Version" AndAlso SafeData.VersionAtLeast(feld1, requiredMajor) Then
            Return
        End If

        If My.Computer.FileSystem.FileExists("Toernverwaltung.mdb") AndAlso My.Computer.FileSystem.FileExists("update.exe") Then
            SaveSetting("Datenbank", "vorhanden", "T", SafeData.ExtractVersionStamp(Me.Text))
            Process.Start("Update.exe")
        End If
        dsToernverwaltung.Steuerdaten.Rows(0)("Bezeichnung") = "Version"
        dsToernverwaltung.Steuerdaten.Rows(0)("feld1") = requiredMajor.ToString(Globalization.CultureInfo.InvariantCulture)
        bsSteuerdaten.EndEdit()
        Try
            taSteuerdaten.Update(dsToernverwaltung.Steuerdaten)
        Catch
        End Try
    End Sub


    Private Sub DatenbankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatenbankToolStripMenuItem.Click
        FormUi.ShowChild(Datenbank)
    End Sub

    Private Sub BootToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BootToolStripMenuItem.Click
        bootkey = " "
        FormUi.ShowChild(Boot)
    End Sub
    Private Sub CrewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrewToolStripMenuItem.Click
        FormUi.ShowChild(Crew)
    End Sub

    Private Sub CharterbasisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CharterbasisToolStripMenuItem.Click
        FormUi.ShowChild(Charter)
    End Sub

    Private Sub TörnverwaltungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TörnverwaltungToolStripMenuItem.Click
        ToernKey = " "
        FormUi.ShowChild(Toern)
    End Sub

    Private Sub KalkulationsblattToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KalkulationsblattToolStripMenuItem.Click
        FormUi.ShowChild(Kalkulationsblatt)
    End Sub

    Private Sub FormularFürCrewdatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormularFürCrewdatenToolStripMenuItem.Click
        FormUi.ShowChild(Crewformular)
    End Sub

    Private Sub CrewlisteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrewlisteToolStripMenuItem.Click
        FormUi.ShowChild(Crewliste)
    End Sub

    Private Sub MeilenauswertungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeilenauswertungToolStripMenuItem.Click
        FormUi.ShowChild(Meilenauswertung)
    End Sub

    Private Sub TörnblattToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TörnblattToolStripMenuItem.Click
        FormUi.ShowChild(Toernblatt)
    End Sub

    Private Sub GeburtstagskalenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeburtstagskalenderToolStripMenuItem.Click
        FormUi.ShowChild(Geburtstagskalender)
    End Sub

    Private Sub SeemeilenbestätigungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeemeilenbestätigungToolStripMenuItem.Click
        FormUi.ShowChild(Seemeilenbestaetigung)
    End Sub

    Private Sub StatistikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatistikToolStripMenuItem.Click
        FormUi.ShowChild(Statistik)
    End Sub

    Private Sub TörnexportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TörnexportToolStripMenuItem.Click
        FormUi.ShowChild(ExpoNeu)
    End Sub

    Private Sub TörnimportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TörnimportToolStripMenuItem.Click
        FormUi.ShowChild(ImportNeu)
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        FormUi.ShowChild(Info)
    End Sub

    Private Sub FreischaltungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreischaltungToolStripMenuItem.Click
        FormUi.ShowChild(Key)
    End Sub

    Private Sub KalkulationKopierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KalkulationKopierenToolStripMenuItem.Click
        FormUi.ShowChild(KalkToToern)
    End Sub

    Private Sub TexteVerwaltenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TexteVerwaltenToolStripMenuItem.Click
        FormUi.ShowChild(ComboBox)
    End Sub

    Private Sub AdressenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdressenToolStripMenuItem.Click
        FormUi.ShowChild(Adressen)
    End Sub

    Private Sub EmailSendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailSendenToolStripMenuItem.Click
        FormUi.ShowChild(EMail)
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click
        FormUi.ShowChild(Einstellungen)
    End Sub

    Private Sub DistressformularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistressformularToolStripMenuItem.Click
        FormUi.ShowChild(Distress)
    End Sub

    Private Sub AgenturToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenturToolStripMenuItem.Click
        FormUi.ShowChild(Agentur)
    End Sub
    Private Sub TexteMarketingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TexteMarketingToolStripMenuItem.Click
        FormUi.ShowChild(ComboMarketing)
    End Sub

    Private Sub KursmaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KursmaterialToolStripMenuItem.Click
        FormUi.ShowChild(Kursmaterial)
    End Sub

    Private Sub KurseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurseToolStripMenuItem.Click
        FormUi.ShowChild(Kurs)
    End Sub
    Private Sub TermineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TermineToolStripMenuItem.Click
        '       Kurstermine.Show()
    End Sub
    Private Sub WerbungToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WerbungToolStripMenuItem1.Click
        werbungg = "Allg"
        FormUi.ShowChild(Werbung)
    End Sub

    Private Sub VeranstaltungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VeranstaltungenToolStripMenuItem.Click
        FormUi.ShowChild(Veranstalltung)
    End Sub

    Private Sub KontakteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KontakteToolStripMenuItem1.Click
        FormUi.ShowChild(KursToernKontakte)
    End Sub

    Private Sub TabellenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabellenToolStripMenuItem.Click
        FormUi.ShowChild(Tabellen)
    End Sub

    Private Sub KursstatistikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KursstatistikToolStripMenuItem.Click
        FormUi.ShowChild(Kursstatistik)
    End Sub

    Private Sub StatistikToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatistikToolStripMenuItem1.Click
        FormUi.ShowChild(AktivStatistik)
    End Sub

    Private Sub StandortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandortToolStripMenuItem.Click
        FormUi.ShowChild(Standort)
    End Sub

    Private Sub WacheplanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WacheplanToolStripMenuItem.Click
        FormUi.ShowChild(Wacheplan)
    End Sub

    Private Sub BordkassaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BordkassaToolStripMenuItem.Click
        FormUi.ShowChild(Bordkassa)
    End Sub
    Private Sub Label58_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label58.MouseClick
        Process.Start(AcrobatReader, pdfname)
    End Sub
    Private Sub LogbuchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogbuchToolStripMenuItem.Click
        FormUi.ShowChild(LogbuchDruck)
    End Sub
    Private Sub LogbuchToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles LogbuchToolStripMenuItem1.Click
        FormUi.ShowChild(LogbuchMenü)
    End Sub

    Private Sub TeilnehmerKursToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FormUi.ShowChild(Kursteilnehmer1)
    End Sub

    Private Sub TeilnehmerlisteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeilnehmerlisteToolStripMenuItem.Click
        FormUi.ShowChild(Kursteilnehmer3)
    End Sub

    Private Sub TeilnehmerVerwaltenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FormUi.ShowChild(Kursteilnehmer2)
    End Sub

    Private Sub BestellformularToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BestellformularToolStripMenuItem.Click
        FormUi.ShowChild(Kursbestellung1)
    End Sub

    Private Sub BestellungProTeilnehmerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BestellungProTeilnehmerToolStripMenuItem.Click
        FormUi.ShowChild(Kursbestellung2)
    End Sub

    Private Sub SammelbestellungToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SammelbestellungToolStripMenuItem.Click
        FormUi.ShowChild(Kursbestellung3)
    End Sub

    Private Sub KalkulationToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles KalkulationToolStripMenuItem1.Click
        FormUi.ShowChild(Kalkulation)
    End Sub

    Private Sub CrewwerbungToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrewwerbungToolStripMenuItem.Click
        werbungg = "Törn"
        FormUi.ShowChild(Werbung)
    End Sub

    Private Sub EinkaufslisteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EinkaufslisteToolStripMenuItem.Click
        FormUi.ShowChild(Einkaufsliste)
    End Sub

    Private Sub DerErsteTagToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DerErsteTagToolStripMenuItem.Click
        FormUi.ShowChild(Ablauf)
    End Sub

    Private Sub CrewDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrewDetailsToolStripMenuItem.Click
        FormUi.ShowChild(CrewDetails)
    End Sub

    Private Sub DerErsteTagToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DerErsteTagToolStripMenuItem1.Click
        FormUi.ShowChild(ErsterTag)
    End Sub

    Private Sub CrewbesprechungToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CrewbesprechungToolStripMenuItem1.Click
        FormUi.ShowChild(CrewBesprechungDruck)
    End Sub

    Private Sub CharterToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles CharterToolStripMenuItem2.Click
        FormUi.ShowChild(VersichTarifeY)
    End Sub

    Private Sub CharterToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles CharterToolStripMenuItem3.Click
        FormUi.ShowChild(Versicherter)
    End Sub

    Private Sub SchadenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SchadenToolStripMenuItem.Click
        FormUi.ShowChild(SchadenY)
    End Sub

    Private Sub SchadenToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles SchadenToolStripMenuItem1.Click
        FormUi.ShowChild(SchadenYDruck)
    End Sub

    Private Sub GruppeZuordnenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GruppeZuordnenToolStripMenuItem.Click
        FormUi.ShowChild(KurstermineGZ)
    End Sub

    Private Sub EinzelZuordnenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EinzelZuordnenToolStripMenuItem.Click
        FormUi.ShowChild(KurstermineEZ)
    End Sub

    Private Sub EnzeiVerwaltenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnzeiVerwaltenToolStripMenuItem.Click
        FormUi.ShowChild(KurstermineEV)
    End Sub

    Private Sub AnwesenheitslisteDruckenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnwesenheitslisteDruckenToolStripMenuItem.Click
        FormUi.ShowChild(KurstermineAD)
    End Sub

    Private Sub KursZuordnenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KursZuordnenToolStripMenuItem.Click
        '       KursMTeilnehmer.Show()
        FormUi.ShowChild(Kursteilnehmer1)
    End Sub

    Private Sub KostenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KostenToolStripMenuItem.Click
        FormUi.ShowChild(KursTeilnVerw)
    End Sub

    Private Sub BestellungenBuchenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BestellungenBuchenToolStripMenuItem.Click
        FormUi.ShowChild(KursBestBuchen)
    End Sub

    Private Sub CrewbesprechungDruckenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrewbesprechungDruckenToolStripMenuItem.Click
        FormUi.ShowChild(CrewBesprechungDruck)
    End Sub

    Private Sub NachtansteuerungenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NachtansteuerungenToolStripMenuItem.Click
        FormUi.ShowChild(Nachtansteuerung)
    End Sub
End Class
