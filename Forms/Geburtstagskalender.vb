Public Class Geburtstagskalender
    Public Freischaltung As String
    Public aenderung As Boolean
    Public aaa As String
    Dim mon As String
    Public iii As Integer
    Dim x As New CheckKey
    Public ok As Boolean
    Private Sub Geburtstagskalender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.CrewAdressen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taCrewAdressen.Fill(Me.dsToernverwaltung.CrewAdressen)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        Freischaltung = GetSetting("toern", "Pfad", "T")

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

        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen order by vzname"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        ComboBox1.Items.Add("Jänner")
        ComboBox1.Items.Add("Februar")
        ComboBox1.Items.Add("März")
        ComboBox1.Items.Add("April")
        ComboBox1.Items.Add("Mai")
        ComboBox1.Items.Add("Juni")
        ComboBox1.Items.Add("Juli")
        ComboBox1.Items.Add("August")
        ComboBox1.Items.Add("September")
        ComboBox1.Items.Add("Oktober")
        ComboBox1.Items.Add("November")
        ComboBox1.Items.Add("Dezember")
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 200
        GroupBox2.Visible = False
    End Sub

    Private Sub Drucken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Drucken.Click
        Dim XL As New PrintOutGK
        Dim dv As DataView
        Dim t As DataTable
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsCrewAdressen.Current
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        If aaa = "J" Then
            xAdapter.SelectCommand.CommandText = "Select * from crewadressen order by month(gebdatum), day(gebdatum)"
        Else
            xAdapter.SelectCommand.CommandText = "Select * from crewadressen where month(gebdatum) = '" & mon & "' order by month(gebdatum), day(gebdatum)"
        End If
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        xAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
        dv = bsCrewAdressen.List
        '       t = dv.ToTable("Printing", False, "Name", "Vorname", "Plz", "Ort", "MNr", "MBereich", "MDatum")
        If ok Then
            t = dv.ToTable("Printing", False, "VZname", "GebDatum", "Handy", "email")
        Else
            t = dv.ToTable("Printing", False, "nationalitaet", "GebDatum", "Handy", "ort")
        End If
        XL.PrintGebKalender(t)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        monat()
    End Sub
    Private Sub monat()
        GroupBox2.Visible = True
        ComboBox1.Visible = True
        mon = ComboBox1.Text
        Select Case mon
            Case "Jänner"
                mon = 1
            Case "Februar"
                mon = 2
            Case "März"
                mon = 3
            Case "April"
                mon = 4
            Case "Mai"
                mon = 5
            Case "Juni"
                mon = 6
            Case "Juli"
                mon = 7
            Case "August"
                mon = 8
            Case "September"
                mon = 9
            Case "Oktober"
                mon = 10
            Case "November"
                mon = 11
            Case "Dezember"
                mon = 12
        End Select
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
         pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen where month(gebdatum) = '" & mon & "' order by month(gebdatum), day(gebdatum)"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        aaa = "M"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        monat()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        jahr()
    End Sub
    Private Sub Jahr()
        GroupBox2.Visible = True
        ComboBox1.Visible = False
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsCrewAdressen.Current
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from crewadressen  order by month(gebdatum), day(gebdatum)"
        bsCrewAdressen.CancelEdit()
        dsToernverwaltung.CrewAdressen.Clear()
        pAdapter.Fill(dsToernverwaltung.CrewAdressen)
        DbAccess.SafePosition(bsCrewAdressen)
        aaa = "J"
    End Sub

End Class