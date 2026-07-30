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

        chkCopyFromPrevious.Checked = LogbookDatenHolenSettings.CopyFromPreviousEnabled
        chkWindRichtung.Checked = LogbookDatenHolenSettings.CopyWindRichtung
        chkWindstaerke.Checked = LogbookDatenHolenSettings.CopyWindstaerke
        chkSeegang.Checked = LogbookDatenHolenSettings.CopySeegang
        chkLuftdruck.Checked = LogbookDatenHolenSettings.CopyLuftdruck
        chkWolken.Checked = LogbookDatenHolenSettings.CopyWolken
        chkAntriebsart.Checked = LogbookDatenHolenSettings.CopyAntriebsart
        UpdateCopyFieldEnabledState()
    End Sub

    Private Sub chkCopyFromPrevious_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCopyFromPrevious.CheckedChanged
        UpdateCopyFieldEnabledState()
    End Sub

    Private Sub UpdateCopyFieldEnabledState()
        Dim enabled As Boolean = chkCopyFromPrevious.Checked
        chkWindRichtung.Enabled = enabled
        chkWindstaerke.Enabled = enabled
        chkSeegang.Enabled = enabled
        chkLuftdruck.Enabled = enabled
        chkWolken.Enabled = enabled
        chkAntriebsart.Enabled = enabled
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

        LogbookDatenHolenSettings.CopyFromPreviousEnabled = chkCopyFromPrevious.Checked
        LogbookDatenHolenSettings.CopyWindRichtung = chkWindRichtung.Checked
        LogbookDatenHolenSettings.CopyWindstaerke = chkWindstaerke.Checked
        LogbookDatenHolenSettings.CopySeegang = chkSeegang.Checked
        LogbookDatenHolenSettings.CopyLuftdruck = chkLuftdruck.Checked
        LogbookDatenHolenSettings.CopyWolken = chkWolken.Checked
        LogbookDatenHolenSettings.CopyAntriebsart = chkAntriebsart.Checked

        Me.Close()
    End Sub
End Class
