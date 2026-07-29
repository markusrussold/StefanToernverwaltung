Public Class SucheDatei
    Dim path As String
    Private Sub suchedatei_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PiClick()
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        PiClick()
    End Sub
    Public Sub PiClick()
        GroupBoxV.Location = New Point(10, 11)
        GroupBoxV.Text = "Datei suchen"
        For Each drv As IO.DriveInfo In IO.DriveInfo.GetDrives
            With drv
                If .DriveType = IO.DriveType.Fixed Or .DriveType = IO.DriveType.Network Or .DriveType = IO.DriveType.Removable Then ' USB und Festplatte
                    ListBoxV.Items.Add(.Name)
                End If
            End With
        Next

    End Sub
    Private Sub ListBoxV_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBoxV.MouseClick
        TextBoxV.Text = ListBoxV.Text
        ListBoxH.Items.Add(TextBoxV.Text)
    End Sub
    Private Sub ListBoxV_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBoxV.SelectedIndexChanged
        unterordner()
    End Sub
    Private Sub unterordner()
        Dim l As Integer = Len(ListBoxV.Text)
        If l < 4 Then
            Dim disk As String = ListBoxV.Text
            path = TextBoxV.Text
            ListBoxV.Items.Clear()
            GroupBoxV.Text = "Wähle Ordner"
            ListBoxV.Items.AddRange(IO.Directory.GetDirectories(disk))
            Dim bilder = IO.Directory.GetFiles(path, "*.jpg").ToList()
            For Each bild In bilder
                Dim textVonBild = IO.Path.ChangeExtension(bild, ".jpg")
                Dim xx = IO.Path.GetFileName(textVonBild)
                Me.ListBoxV.Items.Add(xx)
            Next
            GoTo endsub
        End If
        If ListBoxV.Text.Substring(l - 4, 4) = ".jpg" Then
            TextBoxV.Text = path + "\" + ListBoxV.Text
        Else
            Dim disk As String = ListBoxV.Text
            path = TextBoxV.Text
            ListBoxV.Items.Clear()
            GroupBoxV.Text = "Wähle Ordner"
            ListBoxV.Items.AddRange(IO.Directory.GetDirectories(disk))
            Dim bilder = IO.Directory.GetFiles(path, "*.jpg").ToList()
            For Each bild In bilder
                Dim textVonBild = IO.Path.ChangeExtension(bild, ".jpg")
                Dim xx = IO.Path.GetFileName(textVonBild)
                Me.ListBoxV.Items.Add(xx)
            Next
        End If
endsub:

    End Sub
    Private Sub BLaden_Click(sender As System.Object, e As System.EventArgs) Handles BLaden.Click
        TextBox1.Text = TextBoxV.Text
        GroupBoxV.Location = New Point(1210, 1110)
        Menü.ordner = TextBoxV.Text
        Me.Close()
    End Sub

    Private Sub BZurueck_Click(sender As System.Object, e As System.EventArgs) Handles BZurueck.Click
        Dim aaa As String
        Dim test As String
        aaa = ListBoxH.Items.Count
        TextBoxV.Text = ListBoxH.Items(aaa - 2)
        test = ListBoxH.Items(aaa - 1)
        ListBoxH.Items.RemoveAt(aaa - 1)
        aaa = ListBoxH.Items.Count
        test = ListBoxH.Items(aaa - 1)

        Dim disk As String = TextBoxV.Text
        path = TextBoxV.Text
        ListBoxV.Items.Clear()
        GroupBoxV.Text = "Wähle Ordner"
        ListBoxV.Items.AddRange(IO.Directory.GetDirectories(disk))
        Dim bilder = IO.Directory.GetFiles(path, "*.jpg").ToList()
        For Each bild In bilder
            Dim textVonBild = IO.Path.ChangeExtension(bild, ".jpg")
            Dim xx = IO.Path.GetFileName(textVonBild)
            Me.ListBoxV.Items.Add(xx)
        Next
    End Sub

    Private Sub BAbruch_Click(sender As System.Object, e As System.EventArgs) Handles BAbruch.Click
        Menü.ordner = "X"
        Me.Close()
    End Sub
End Class