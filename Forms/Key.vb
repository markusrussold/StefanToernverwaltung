Public Class Key
    Dim Freischaltung As String
    Dim x As New CheckKey
    Dim kod As String
    Dim aaa As String
    Dim ok1 As Boolean = True
    Dim ok2 As Boolean = False
    Dim ok3 As Boolean = False
    Private Sub Key_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung
        Dim fbreite As Integer
        Dim fhoehe As Integer
        fbreite = Me.Size.Width
        fhoehe = Me.Size.Height
        Me.MaximumSize = New Size(fbreite, fhoehe)
        Freischaltung = GetSetting("Toern", "Pfad", "T")
        If Freischaltung Is Nothing Then
        Else
            ok2 = CheckKey.keypruefen(Freischaltung)
            If ok2 Then
                Label6.Visible = True
                '              GroupBox1.Enabled = False
            End If
            ok3 = CheckKurs.keypruefen(Freischaltung)
            If ok3 Then
                Label9.Visible = True
                '              GroupBox1.Enabled = False
            End If
        End If
        Select Case Menü.FreischaltZiffer
            Case 0
                CheckBox5.Checked = True
            Case 1
                CheckBox4.Checked = True
            Case 2
                CheckBox8.Checked = True
                CheckBox5.Checked = True
            Case 3
                CheckBox8.Checked = True
                CheckBox4.Checked = True
            Case 4
                CheckBox1.Checked = True
                CheckBox4.Checked = True
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label6.Visible = False
        Label7.Visible = False
        kod = MaskedTextBox1.Text & MaskedTextBox2.Text & MaskedTextBox3.Text & MaskedTextBox4.Text & MaskedTextBox5.Text
        ok1 = CheckGesamt.keygesamt(kod)
        If Not ok1 Then
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            MsgBox("Schlüssel ist falsch!")
            GoTo ende
        End If
        ok2 = CheckKey.keypruefen(kod)
        If ok2 Then
            Label6.Visible = True
            If kod Is Nothing Then
            Else
                SaveSetting("Toern", "Pfad", "T", kod)
            End If
        Else
            Label7.Visible = True
        End If
        ok3 = CheckKurs.keypruefen(kod)
        If ok3 Then
            Label9.Visible = True
            If kod Is Nothing Then
            Else
                SaveSetting("Toern", "Pfad", "T", kod)
            End If
            Me.Close()
        Else
            Label8.Visible = True
        End If
ende:
        Menü.FreischaltZiffer = (Checkkod.keygesamt(ok1, ok2, ok3))
        If Menü.FreischaltZiffer = 0 Then
            CheckBox1.Enabled = False
            CheckBox4.Enabled = False
        End If
        SaveSetting("Ziffer", "Einstellungen", "T", Menü.FreischaltZiffer)
    End Sub

    Private Sub MaskedTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.TextChanged
        If Len(MaskedTextBox1.Text) > 3 Then
            MaskedTextBox2.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.TextChanged
        If Len(MaskedTextBox2.Text) > 3 Then
            MaskedTextBox3.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox3.TextChanged
        If Len(MaskedTextBox3.Text) > 3 Then
            MaskedTextBox4.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox4.TextChanged
        If Len(MaskedTextBox4.Text) > 3 Then
            MaskedTextBox5.Focus()
        End If
    End Sub
    Private Sub MaskedTextBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox5.TextChanged
        If Len(MaskedTextBox5.Text) > 3 Then
            Button1.Focus()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        '   FreischaltZiffer:
        '0      Test Törnverwaltung, keine Kursverwaltung
        '1      Törnverwaltung
        '2      Test Törnverwaltung + Test Kursverwaltung
        '3      Törnverwaltung  + Test Kursverwaltung
        '4      Törnverwaltung + Kursverwaltung
        If CheckBox4.Checked And ok2 Then                      ' Törnverwaltung voll
            CheckBox5.Checked = False
            If CheckBox1.Checked And ok3 Then                  ' Kursverwaltung voll
                Menü.FreischaltZiffer = 4
            Else
                If CheckBox8.Checked Then               ' Kursverwaltung test
                    Menü.FreischaltZiffer = 3
                Else
                    Menü.FreischaltZiffer = 1
                End If
            End If
        Else
            CheckBox5.Checked = True
            If CheckBox1.Checked Then                   ' Kursverwaltung voll
                Menü.FreischaltZiffer = 2
                CheckBox8.Checked = True
                CheckBox1.Checked = False
            Else
                If CheckBox8.Checked Then               ' Kursverwaltung test
                    Menü.FreischaltZiffer = 2
                Else
                    Menü.FreischaltZiffer = 0
                End If
            End If

        End If
        Label10.Text = Menü.FreischaltZiffer
        SaveSetting("Ziffer", "Einstellungen", "T", Menü.FreischaltZiffer)
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then                       ' Törnverwaltung test
            CheckBox4.Checked = False
            If CheckBox1.Checked Or CheckBox8.Checked Then                   ' Kursverwaltung voll oder test
                CheckBox8.Checked = True
                CheckBox1.Checked = False
                Menü.FreischaltZiffer = 2
            Else
                Menü.FreischaltZiffer = 0
            End If
        Else
            CheckBox4_CheckedChanged(sender, e)
        End If
        Label10.Text = Menü.FreischaltZiffer
        SaveSetting("Ziffer", "Einstellungen", "T", Menü.FreischaltZiffer)
    End Sub
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then                       ' Kursverwaltung test
            CheckBox8.Checked = False
            CheckBox1.Checked = True
        End If
        CheckBox4_CheckedChanged(sender, e)
        SaveSetting("Ziffer", "Einstellungen", "T", Menü.FreischaltZiffer)
    End Sub
    Private Sub CheckBox8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox8.Click
        If CheckBox8.Checked Then                       ' Kursverwaltung test
            CheckBox1.Checked = False
        End If
        CheckBox4_CheckedChanged(sender, e)
        SaveSetting("Ziffer", "Einstellungen", "T", Menü.FreischaltZiffer)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menü.Close()
        PathGuard.TryStartFile(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "verwaltung.exe"))
        Me.Close()
    End Sub
End Class