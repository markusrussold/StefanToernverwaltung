Public Class Einstellungen
    Dim D1 As Integer
    Dim kmgeld As Single
    Dim Austria As String
    Dim deutschland As String
    Private Sub Einstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        D1 = GetSetting("D1", "Einstellungen", "T", "95")
        kmgeld = GetSetting("toern", "Fahrgeld", "T", "42")
        If D1 > 0 Then
            TextBox1.Text = D1
        Else
            TextBox1.Text = 110
        End If
        TextBox2.Text = kmgeld
        deutschland = GetSetting("Land", "Einstellungen", "T", "A")
        If deutschland = "A" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        D1 = TextBox1.Text
        SaveSetting("D1", "Einstellungen", "T", D1)
        If RadioButton1.Checked Then
            deutschland = "A"
        Else
            deutschland = "D"
        End If
        SaveSetting("Land", "Einstellungen", "T", deutschland)
        kmgeld = TextBox2.Text
        SaveSetting("toern", "Fahrgeld", "T", kmgeld)
        Me.Close()
    End Sub
End Class