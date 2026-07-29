Public Class Info
    Dim Freischaltung As String
    Dim x As New CheckKey
    Dim ok As Boolean
    '       Definition der Versionen    X.YZ      :
    '            X ändert sich bei Datenbankänderung
    '            Y ändert sich bei Fehlerbehebung
    '            Z ändert sich bei Funktionsänderung/Ergänzung
    Private Sub Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Steuerdaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taSteuerdaten.Fill(Me.dsToernverwaltung.Steuerdaten)
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Freischaltung = GetSetting("Toern", "Pfad", "T")
        Label1.Text = Menü.Text
        If Freischaltung Is Nothing Then
        Else
            ok = CheckKey.keypruefen(Freischaltung)
            If ok Then
                Label4.Text = "Die Freischaltung war erfolgreich"
            End If
        End If
        Dim sAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rs As System.Data.DataRowView = bsSteuerdaten.Current
        sAdapter.SelectCommand = New OleDb.OleDbCommand
        sAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        sAdapter.SelectCommand.CommandText = "Select * from steuerdaten"
        bsSteuerdaten.CancelEdit()
        dsToernverwaltung.Steuerdaten.Clear()
        sAdapter.Fill(dsToernverwaltung.Steuerdaten)
        If bsSteuerdaten.Count > 0 Then
            bsSteuerdaten.Position = 0
        End If
        If bsSteuerdaten.Count > 0 Then
            If dsToernverwaltung.Steuerdaten.Rows(0)("bezeichnung").ToString = "Version" Then
                Label6.Text = "Datenbank        Version " + dsToernverwaltung.Steuerdaten.Rows(0)("feld1").ToString
            End If
        End If
    End Sub
End Class