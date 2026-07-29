Public Class Distress
    Dim buch1 As String
    Dim iii As Integer
    Dim aaa As String
    Dim position As Integer
    Dim mmsi As String
    Dim bootsname As String
    Public crewanzahl As Integer
    Dim schiffnr As String
    Dim ok As Boolean
    Private Sub Distress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.TC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taTC.Fill(Me.dsToernverwaltung.TC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "dsToernverwaltung.Toernname". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taToernname.Fill(Me.dsToernverwaltung.Toernname)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "ToernverwaltungDataSet.Boot". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.taBoot.Fill(Me.dsToernverwaltung.Boot)
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernname.Current
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
        pAdapter.SelectCommand.CommandText = "Select * from toernname order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        pAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.Position = 0
        bsToernname.AddNew()
        Toern.Visible = False
        With DataGridView1
            .Columns(0).Width = 150
        End With
        '        suchen()
            TextBox1.Text = GetSetting("Toern", "Logbuch", "T", "")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Toern.Visible = True
        suchen()
    End Sub
    Private Sub suchen()
        Dim pAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rp As System.Data.DataRowView = bsToernname.Current
        Dim xAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim r As System.Data.DataRowView = bsBoot.Current
        xAdapter.SelectCommand = New OleDb.OleDbCommand
        xAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand = New OleDb.OleDbCommand
        pAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        pAdapter.SelectCommand.CommandText = "Select * from toernname where toernbezeichnung like '%" & TextBox1.Text & "%'order by toernbezeichnung"
        bsToernname.CancelEdit()
        dsToernverwaltung.Toernname.Clear()
        pAdapter.Fill(dsToernverwaltung.Toernname)
        bsToernname.Position = 0
        Select Case bsToernname.Count
            Case 1
                bsToernname.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                bootsname = dsToernverwaltung.Toernname.Rows(0)("Bootsname").ToString
                Toern.Visible = False
                DataGridView1.Visible = True
                xAdapter.SelectCommand.CommandText = "Select * from boot where bootname like '%" & bootsname & "%'  order by bootname"
                With DataGridView1.ColumnHeadersDefaultCellStyle
                    .Font = New Font(.Font.FontFamily, .Font.Size, _
                    .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
                End With
                bsBoot.CancelEdit()
                dsToernverwaltung.Boot.Clear()
                xAdapter.Fill(dsToernverwaltung.Boot)
                TextBox1.Text = TextBox2.Text
                Select Case bsBoot.Count
                    Case 0
                        MsgBox("Kein Boot vorhanden")
                   Case 1
                        bsBoot.Position = 0         'bewirkt dass über <datenbindung die Felder angezeigt (befüllt) werden, zuvor war Pos = -1
                        mmsi = dsToernverwaltung.Boot.Rows(0)("MMSI").ToString
                        schiffnr = dsToernverwaltung.Boot.Rows(0)("Schiffsnummer").ToString
                        Label4.Text = dsToernverwaltung.Boot.Rows(0)("Bootname").ToString
                        personen()
                        If mmsi = "" Then
                            Label2.Visible = True
                        Else
                            Label2.Visible = False
                        End If
                        If schiffnr = "" Then
                            Label3.Visible = True
                        Else
                            Label3.Visible = False
                        End If
                    Case Else
                        MsgBox("Bootsname nicht eindeutig")
                End Select
            Case Else
                position = 0
                If buch1 > " " Then
                    positionieren()
                End If
                buch1 = ""
                bsToernname.Position = position
                Toern.Visible = True
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
    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        TextBox1.Text = TextBox2.Text
        suchen()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            suchen()
        End If
    End Sub
    Private Sub personen()
        Dim nAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim rn As System.Data.DataRowView = bsTC.Current
        nAdapter.SelectCommand = New OleDb.OleDbCommand
        nAdapter.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Toernverwaltung.mdb")
        nAdapter.SelectCommand.CommandText = "Select * from tc where toern like '%" & TextBox1.Text & "%' "
        bsTC.CancelEdit()
        dsToernverwaltung.TC.Clear()
        nAdapter.Fill(dsToernverwaltung.TC)
        bsTC.Position = 0
        crewanzahl = bsTC.Count + 1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        suchen()
        Dim Xs As New printOutDs
        Dim dv As DataView
        Dim t As DataTable
        If ok Then
            dv = bsBoot.List
            t = dv.ToTable("Printing", False, "Bootname", "Schiffsnummer", "MMSI")
            Xs.PrintDistress(t)
        Else
            MsgBox("Funktion - Drucken - unterstützt nur die freigeschaltete Version. ")
        End If
        Me.Close()

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        '       suchen()
    End Sub
End Class