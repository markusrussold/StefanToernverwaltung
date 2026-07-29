Public Class Tabellen
    Dim umre As Single
    Dim std As Integer
    Dim min As Integer
    Dim sek As Integer
    Private Sub Tabellen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "0,000"
        TextBox2.Text = "0,000"
        TextBox3.Text = "0,0"
        TextBox4.Text = "0,0"
        TextBox5.Text = "0,0"
        TextBox6.Text = "0,0"
        TextBox7.Text = "0,0"
        TextBox8.Text = "0,0"
        TextBox9.Text = "0,0"
        TextBox13.Text = "0,0"
        TextBox18.Text = "0,0"
        TextBox19.Text = "0,0"
        Label99.Text = "Windzeichen," & vbLf & "Der Schaft der Symbole zeigt auf der Wetterkarte in die Richtung, " & vbLf & "in die der Wind weht." & vbLf & " " & vbLf & "Langer (ganzer) Strich (Fieder): 10 Knoten" & vbLf & "Kurzer (halber) Strich (Fieder): 5 Knoten" & vbLf & "Ausgefüllter Wimpel: 50 Knoten "
        Label100.Text = "Mit Klick auf die Summe werden Etfernung und Zeit addiert." & vbLf & " " & vbLf & "Mit Klick auf die Zeile in der Listbox wird diese gelöscht."
        windfahnenDelet()
        ListBox1.Items.Clear()
        RadioButton1.Checked = True
        WindDeu()
        GroupBox2.Focus()
        TableLayoutPanel2.Location = New Point(15, 21)

    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) And TextBox1.Focused = True Then           ' Seemeile
            TB1_versorgen()
        End If
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) And TextBox2.Focused = True Then    ' Kilometer
            TextBox2.Text = Replace(TextBox2.Text, ".", ",")
            TextBox2.SelectionStart = Len(TextBox2.Text)
            TextBox2.ScrollToCaret()
            umre = TextBox2.Text / 1.852216
            TextBox1.Text = umre.ToString("0.000")     '  sm

            umre = TextBox1.Text * 10
            TextBox8.Text = umre.ToString("0.0")       ' Kbl
            umre = TextBox1.Text * 3600
            TextBox9.Text = umre.ToString("0.0")       ' mtr
            umre = TextBox1.Text * 1852.216
            TextBox3.Text = umre.ToString("0.0")       ' m
            umre = TextBox1.Text * 1.852216 / 0.0003048
            TextBox4.Text = umre.ToString("0.0")       ' Fuss
            TextBox20.Text = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        TextBox3.Text = ""
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If IsNumeric(TextBox3.Text) And TextBox3.Focused = True Then          ' Meter
            TextBox3.Text = Replace(TextBox3.Text, ".", ",")
            TextBox3.SelectionStart = Len(TextBox3.Text)
            TextBox3.ScrollToCaret()
            umre = TextBox3.Text / 0.3048
            TextBox4.Text = umre.ToString("0.0")                         ' Fuss
            umre = TextBox3.Text / 1000
            TextBox2.Text = umre.ToString("0.000")                         ' km
            umre = TextBox3.Text / 185.2
            TextBox8.Text = umre.ToString("0.00")                         ' kbl
            umre = TextBox3.Text / 1852.216
            TextBox1.Text = umre.ToString("0.000")                         ' sm
            umre = TextBox1.Text * 3600
            TextBox9.Text = umre.ToString("0.0")                         ' mtr
            TextBox20.Text = TextBox1.Text
        End If

    End Sub

    Private Sub TextBox8_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.GotFocus
        TextBox8.Text = ""
    End Sub
    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If IsNumeric(TextBox8.Text) And TextBox8.Focused = True Then           ' kbl
            TextBox8.Text = Replace(TextBox8.Text, ".", ",")
            TextBox8.SelectionStart = Len(TextBox8.Text)
            TextBox8.ScrollToCaret()
            umre = TextBox8.Text * 0.1852216
            TextBox2.Text = umre.ToString("0.000")     ' km
            umre = TextBox8.Text / 10
            TextBox1.Text = umre.ToString("0.0")       ' sm
            umre = TextBox8.Text * 360
            TextBox9.Text = umre.ToString("0.0")       ' mtr
            umre = TextBox8.Text * 185.2216
            TextBox3.Text = umre.ToString("0.0")       ' m
            umre = TextBox8.Text * 1.852216 / 0.003048
            TextBox4.Text = umre.ToString("0.0")       ' Fuss
            TextBox20.Text = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.GotFocus
        TextBox4.Text = ""
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If IsNumeric(TextBox4.Text) And TextBox4.Focused = True Then           ' Fuss
            TextBox4.Text = Replace(TextBox4.Text, ".", ",")
            TextBox4.SelectionStart = Len(TextBox4.Text)
            TextBox4.ScrollToCaret()
            umre = TextBox4.Text * 0.3048
            TextBox3.Text = umre.ToString("0.00")                         ' m
            umre = TextBox3.Text / 1000
            TextBox2.Text = umre.ToString("0.000")                         ' km
            umre = TextBox3.Text / 185.2
            TextBox8.Text = umre.ToString("0.00")                         ' kbl
            umre = TextBox3.Text / 1852.216
            TextBox1.Text = umre.ToString("0.000")                         ' sm
            umre = TextBox1.Text * 3600
            TextBox9.Text = umre.ToString("0.0")                         ' mtr
            TextBox20.Text = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox9_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.GotFocus
        TextBox9.Text = ""
    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If IsNumeric(TextBox9.Text) And TextBox9.Focused = True Then           ' Meridianteritie
            TextBox9.Text = Replace(TextBox9.Text, ".", ",")
            TextBox9.SelectionStart = Len(TextBox9.Text)
            TextBox9.ScrollToCaret()
            umre = TextBox9.Text / 3600
            TextBox1.Text = umre.ToString("0.000")                         ' sm
            umre = TextBox3.Text / 1000
            umre = TextBox1.Text * 1.852216
            TextBox2.Text = umre.ToString("0.000")     ' km
            umre = TextBox1.Text * 10
            TextBox8.Text = umre.ToString("0.0")       ' Kbl
            umre = TextBox1.Text * 1852.216
            TextBox3.Text = umre.ToString("0.0")       ' m
            umre = TextBox1.Text * 1.852216 / 0.0003048
            TextBox4.Text = umre.ToString("0.0")       ' Fuss
            TextBox20.Text = TextBox1.Text
        End If
    End Sub
    '                                      Geschwindigkeit

    Private Sub TextBox5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.GotFocus
        TextBox5.Text = ""
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If IsNumeric(TextBox5.Text) And TextBox5.Focused = True Then
            TextBox5.Text = Replace(TextBox5.Text, ".", ",")
            TextBox5.SelectionStart = Len(TextBox5.Text)
            TextBox5.ScrollToCaret()
            umre = TextBox5.Text * 3.6
            TextBox6.Text = umre.ToString("0.0")
            umre = TextBox5.Text * 3.6 / 1.852216
            TextBox7.Text = umre.ToString("0.0")
            FahnenBild()
            Beaufort()
        End If
    End Sub

    Private Sub TextBox6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.GotFocus
        TextBox6.Text = ""
        '       TextBox6.Text = Replace(TextBox6.Text, ".", ",")
        '      TextBox6.SelectionStart = Len(TextBox6.Text)
        '     TextBox6.ScrollToCaret()
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If IsNumeric(TextBox6.Text) And TextBox6.Focused = True Then
            TextBox6.Text = Replace(TextBox6.Text, ".", ",")
            TextBox6.SelectionStart = Len(TextBox6.Text)
            umre = TextBox6.Text / 3.6
            TextBox5.Text = umre.ToString("0.0")
            umre = TextBox6.Text / 1.852216
            TextBox7.Text = umre.ToString("0.0")
            FahnenBild()
            Beaufort()
        End If

    End Sub

    Private Sub TextBox7_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.GotFocus
        TextBox7.Text = ""
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If IsNumeric(TextBox7.Text) And TextBox7.Focused = True Then
            TB7_versorgen()
        End If
    End Sub
    Private Sub windfahnenDelet()
        Windfahne5.Visible = False
        Windfahne10.Visible = False
        Windfahne15.Visible = False
        Windfahne20.Visible = False
        Windfahne25.Visible = False
        Windfahne30.Visible = False
        Windfahne35.Visible = False
        Windfahne40.Visible = False
        Windfahne45.Visible = False
        Windfahne50.Visible = False
        Windfahne55.Visible = False
        Windfahne60.Visible = False
        WindfahneO.Visible = False

    End Sub
    Private Sub FahnenBild()
        Dim wind As Single = TextBox7.Text
        windfahnenDelet()
        Select Case wind
            Case Is <= 3
                WindfahneO.Location = New Point(420, 132)
                WindfahneO.Visible = True
            Case Is <= 5
                Windfahne5.Location = New Point(420, 132)
                Windfahne5.Visible = True
            Case Is <= 10
                Windfahne10.Location = New Point(420, 132)
                Windfahne10.Visible = True
            Case Is <= 15
                Windfahne15.Location = New Point(420, 132)
                Windfahne15.Visible = True
            Case Is <= 20
                Windfahne20.Location = New Point(420, 132)
                Windfahne20.Visible = True
            Case Is <= 25
                Windfahne25.Location = New Point(420, 132)
                Windfahne25.Visible = True
            Case Is <= 30
                Windfahne30.Location = New Point(420, 132)
                Windfahne30.Visible = True
            Case Is <= 35
                Windfahne35.Location = New Point(420, 132)
                Windfahne35.Visible = True
            Case Is <= 40
                Windfahne40.Location = New Point(420, 132)
                Windfahne40.Visible = True
            Case Is <= 45
                Windfahne45.Location = New Point(420, 132)
                Windfahne45.Visible = True
            Case Is <= 50
                Windfahne50.Location = New Point(420, 132)
                Windfahne50.Visible = True
            Case Is <= 55
                Windfahne55.Location = New Point(420, 132)
                Windfahne55.Visible = True
            Case Else
                Windfahne60.Location = New Point(420, 132)
                Windfahne60.Visible = True
        End Select
    End Sub
    Private Sub Beaufort()
        Dim wind As Single = TextBox7.Text
        Select Case wind
            Case Is < 1
                Label88.Text = 0
            Case Is < 4
                Label88.Text = 1
            Case Is < 7
                Label88.Text = 2
            Case Is < 11
                Label88.Text = 3
            Case Is < 16
                Label88.Text = 4
            Case Is < 22
                Label88.Text = 5
            Case Is < 28
                Label88.Text = 6
            Case Is < 34
                Label88.Text = 7
            Case Is < 41
                Label88.Text = 8
            Case Is < 48
                Label88.Text = 9
            Case Is < 56
                Label88.Text = 10
            Case Is < 64
                Label88.Text = 11
            Case Else
                Label88.Text = 12

        End Select
    End Sub
     Private Sub Windfahne5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne5.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne5.MouseLeave
        GroupBox6.Location = New Point(750, 280)
    End Sub
    Private Sub Windfahne15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne15.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne25_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne25.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne35_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne35.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne45_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne45.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne55_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne55.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne20_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne20.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne30_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne30.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne40_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne40.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne50_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne50.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne60_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne60.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne15.MouseLeave
        GroupBox6.Location = New Point(750, 280)
    End Sub
    Private Sub Windfahne10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne10.MouseHover
        GroupBox6.Location = New Point(18, 220)
    End Sub
    Private Sub Windfahne10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne10.MouseLeave
        GroupBox6.Location = New Point(750, 280)
    End Sub
    Private Sub Windfahne25_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne25.MouseLeave
        GroupBox6.Location = New Point(750, 280)
    End Sub
    Private Sub Windfahne35_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne35.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub
    Private Sub Windfahne45_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne45.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub
    Private Sub Windfahne55_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne55.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub
    Private Sub Windfahne20_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne20.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub
    Private Sub Windfahne30_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne30.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub
    Private Sub Windfahne40_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne40.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub
    Private Sub Windfahne50_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne50.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub

    Private Sub Windfahne60_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Windfahne60.MouseLeave
        GroupBox6.Location = New Point(750, 280)

    End Sub
    Private Sub TextBox10_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.GotFocus
        TextBox10.Text = ""
    End Sub
    Private Sub TextBox10_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        If IsNumeric(TextBox10.Text) And TextBox10.Focused = True Then
            TB10_versorgen()
        End If
    End Sub
    Private Sub TextBox11_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox11.Text = ""
    End Sub
    Private Sub TextBox11_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        If IsNumeric(TextBox11.Text) And TextBox11.Focused = True Then
            TextBox11.Text = Replace(TextBox11.Text, ".", ",")
            TextBox11.SelectionStart = Len(TextBox11.Text)
            umre = TextBox11.Text * 60
            TextBox12.Text = umre.ToString("0.0")
            umre = TextBox11.Text / 60
            TextBox10.Text = umre.ToString("0.0000")
            TextBox13.Text = TextBox10.Text
            zeitaufteilen()
        End If
    End Sub
    Private Sub TextBox12_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.GotFocus
        TextBox12.Text = ""
    End Sub
    Private Sub TextBox12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        If IsNumeric(TextBox12.Text) And TextBox12.Focused = True Then
            TextBox12.Text = Replace(TextBox12.Text, ".", ",")
            TextBox12.SelectionStart = Len(TextBox12.Text)
            umre = TextBox12.Text / 60
            TextBox11.Text = umre.ToString("0.00")
            umre = TextBox11.Text / 60
            TextBox10.Text = umre.ToString("0.0000")
            TextBox13.Text = TextBox10.Text
            zeitaufteilen()
        End If
    End Sub
    Private Sub zeitaufteilen()
        std = Fix(TextBox10.Text)
        TextBox13.Text = std
        min = Fix(TextBox11.Text - TextBox13.Text * 60)
        TextBox18.Text = min
        sek = TextBox12.Text - TextBox13.Text * 3600 - TextBox18.Text * 60
        TextBox19.Text = sek
    End Sub
    Private Sub zeitzusammen()
        TextBox10.Text = TextBox13.Text
        If TextBox18.Text > "" Then
            TextBox10.Text = Math.Round(TextBox13.Text + TextBox18.Text / 60, 3)
            TextBox11.Text = TextBox13.Text * 60 + TextBox18.Text
            TextBox12.Text = TextBox13.Text * 3600 + TextBox18.Text * 60
        End If
        If TextBox19.Text > "" Then
            TextBox10.Text = Math.Round(TextBox13.Text + TextBox18.Text / 60 + TextBox19.Text / 3600, 4)
            TextBox11.Text = Math.Round(TextBox13.Text * 60 + TextBox18.Text + TextBox19.Text / 60, 3)
            TextBox12.Text = TextBox13.Text * 3600 + TextBox18.Text * 60 + TextBox19.Text
        End If
    End Sub
    Private Sub TextBox13_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.GotFocus
        TextBox13.Text = ""
    End Sub
    Private Sub TextBox13_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.LostFocus
        If IsNumeric(TextBox13.Text) Then
        Else
            TextBox13.Text = 0
        End If

    End Sub
    Private Sub TextBox13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        If IsNumeric(TextBox13.Text) And TextBox13.Focused = True Then
            TextBox13.Text = Fix(TextBox13.Text)
            TextBox13.SelectionStart = Len(TextBox13.Text)
            umre = TextBox13.Text * 60
            TextBox11.Text = umre.ToString("0.0")
            umre = TextBox11.Text * 60
            TextBox12.Text = umre.ToString("0.0")
            zeitzusammen()
        End If
    End Sub
    Private Sub TextBox18_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.GotFocus
        TextBox18.Text = ""
    End Sub
    Private Sub TextBox18_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.LostFocus
        If IsNumeric(TextBox18.Text) Then
        Else
            TextBox18.Text = 0
        End If

    End Sub
    Private Sub TextBox18_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged
        If IsNumeric(TextBox18.Text) And TextBox18.Focused = True Then
            TextBox18.Text = Fix(TextBox18.Text)
            TextBox18.SelectionStart = Len(TextBox18.Text)
            umre = TextBox18.Text * 60
            TextBox11.Text = umre.ToString("0.0")
            umre = TextBox11.Text * 60
            TextBox12.Text = umre.ToString("0.0")
            zeitzusammen()
        End If
    End Sub
    Private Sub TextBox19_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox19.GotFocus
        TextBox19.Text = ""
    End Sub
    Private Sub TextBox19_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox19.LostFocus
        If IsNumeric(TextBox19.Text) Then
        Else
            TextBox19.Text = 0
        End If
    End Sub
    Private Sub TextBox19_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        If IsNumeric(TextBox19.Text) And TextBox19.Focused = True Then
            TextBox19.Text = Fix(TextBox19.Text)
            TextBox13.SelectionStart = Len(TextBox19.Text)
            umre = TextBox19.Text * 60
            TextBox11.Text = umre.ToString("0.0")
            umre = TextBox11.Text * 60
            TextBox12.Text = umre.ToString("0.0")
            zeitzusammen()
        End If
    End Sub
    Private Sub TextBox14_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox14.GotFocus
        TextBox14.Text = ""
    End Sub
    Private Sub TextBox14_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged                ' Geschwindigkeit
        If IsNumeric(TextBox14.Text) And TextBox14.Focused = True Then
            TextBox7.Text = TextBox14.Text
            TB7_versorgen()
            Aus_v()
        End If
    End Sub
    Private Sub TextBox16_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox16.GotFocus
        TextBox16.Text = ""
    End Sub
    Private Sub TextBox16_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
        If IsNumeric(TextBox16.Text) And TextBox16.Focused = True Then
            TextBox10.Text = TextBox16.Text
            TB10_versorgen()
            Aus_t()
        End If
    End Sub              ' Zeit
    Private Sub TextBox20_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.GotFocus
        TextBox20.Text = ""
    End Sub
    Private Sub TextBox20_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged
        If IsNumeric(TextBox20.Text) And TextBox20.Focused = True Then
            TextBox1.Text = TextBox20.Text
            TB1_versorgen()
            Aus_s()
        End If
    End Sub             '  Entfernung
    Private Sub TB7_versorgen()
        TextBox7.Text = Replace(TextBox7.Text, ".", ",")
        TextBox7.SelectionStart = Len(TextBox7.Text)
        FahnenBild()
        umre = TextBox7.Text * 1.852216
        TextBox6.Text = umre.ToString("0.0")
        umre = TextBox6.Text / 3.6
        TextBox5.Text = umre.ToString("0.0")
        Beaufort()
        '      TextBox14.Text = TextBox7.Text
    End Sub
    Private Sub TB10_versorgen()
        TextBox10.Text = Replace(TextBox10.Text, ".", ",")
        TextBox10.SelectionStart = Len(TextBox10.Text)
        umre = TextBox10.Text * 60
        TextBox11.Text = umre.ToString("0.0")
        umre = TextBox11.Text * 60
        TextBox12.Text = umre.ToString("0.0")
        TextBox13.Text = TextBox10.Text
        zeitaufteilen()
        '      TextBox16.Text = TextBox10.Text
    End Sub
    Private Sub TB1_versorgen()
        TextBox1.Text = Replace(TextBox1.Text, ".", ",")
        TextBox1.SelectionStart = Len(TextBox1.Text)
        TextBox1.ScrollToCaret()
        umre = TextBox1.Text * 1.852216
        TextBox2.Text = umre.ToString("0.000")     ' km
        umre = TextBox1.Text * 10
        TextBox8.Text = umre.ToString("0.0")       ' Kbl
        umre = TextBox1.Text * 3600
        TextBox9.Text = umre.ToString("0.0")       ' mtr
        umre = TextBox1.Text * 1852.216
        TextBox3.Text = umre.ToString("0.0")       ' m
        umre = TextBox1.Text * 1.852216 / 0.0003048
        TextBox4.Text = umre.ToString("0.0")       ' Fuss
    End Sub
    Private Sub Aus_v()                                                                                    ' Geschwindigkeit bekannt
        If IsNumeric(TextBox14.Text) And IsNumeric(TextBox20.Text) Then
            umre = TextBox20.Text / TextBox14.Text
            TextBox16.Text = umre.ToString("0.00")             ' Zeit wird gerechnet
            Exit Sub
        End If
        If IsNumeric(TextBox14.Text) And IsNumeric(TextBox16.Text) Then
            umre = TextBox16.Text * TextBox14.Text
            TextBox20.Text = umre.ToString("0.000")                                                      ' Entfernung wird gerechnet
        End If

    End Sub
    Private Sub Aus_t()                                                                                 ' Zeit ist bekannt
        If IsNumeric(TextBox16.Text) And IsNumeric(TextBox20.Text) Then
            umre = TextBox20.Text / TextBox16.Text
            TextBox14.Text = umre.ToString("0.00")                                                       ' Geschwindigkeit wird gerechnet
            Exit Sub
        End If
        If IsNumeric(TextBox14.Text) And IsNumeric(TextBox16.Text) Then
            umre = TextBox16.Text * TextBox14.Text
            TextBox20.Text = umre.ToString("0.000")                                                      'Entfernung wird gerechnet
        End If
    End Sub
    Private Sub Aus_s()                                                                                 ' Entfernung ist bekannt
        If IsNumeric(TextBox14.Text) And IsNumeric(TextBox20.Text) Then
            umre = TextBox20.Text / TextBox14.Text
            TextBox16.Text = umre.ToString("0.00")                                                      ' Zeit wird gerechnet
            Exit Sub
        End If
        If IsNumeric(TextBox14.Text) And IsNumeric(TextBox16.Text) Then
            umre = TextBox16.Text * TextBox14.Text
            TextBox20.Text = umre.ToString("0.00")                                                     ' Geschwindigkeit wird gerechnet  
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim umre2 As Single
        If ListBox1.Items.Count = 0 Then
            TextBox15.Text = "0"
            TextBox17.Text = "0"
            ListBox1.Items.Add("v        s         t")
        End If
        If IsNumeric(TextBox16.Text) Then
        Else
            MsgBox("Zeit ist nicht nummerisch.")
            TextBox16.Focus()
            Exit Sub
        End If
        If IsNumeric(TextBox20.Text) Then
        Else
            MsgBox("Entfernung ist nicht nummerisch.")
            TextBox20.Focus()
            Exit Sub
        End If
        If IsNumeric(TextBox14.Text) Then
        Else
            MsgBox("Geschwindigkeit ist nicht nummerisch.")
            TextBox14.Focus()
            Exit Sub
        End If
        ListBox1.Items.Add(TextBox14.Text + "     " + TextBox20.Text + "      " + TextBox16.Text)   ' 5 bzw 6 Leerstellen wichtig
        umre = TextBox16.Text
        umre2 = TextBox15.Text
        TextBox15.Text = Math.Round(umre + umre2, 2)
        umre = TextBox20.Text
        umre += TextBox17.Text
        TextBox17.Text = umre
    End Sub

    Private Sub ListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        Dim ia As String = ListBox1.Text
        Dim aa As String = ListBox1.Text
        Dim msg As Integer
        Dim pos1 As Integer
        Dim pos2 As Integer
        Dim pos4 As Integer
        Dim zeit As Single
        Dim entf As Single
        msg = MsgBox("Soll die Position  > " & Convert.ToString(ia) & " <   wirklich gelöscht werden", 1, "Löschen")
        If msg = vbOK Then

            pos1 = InStr(aa, "     ") + 5
            pos2 = InStr(aa, "      ")
            entf = aa.Substring(pos1 - 1, pos2 - pos1 + 1)
            pos4 = Len(aa) - 1
            zeit = aa.Substring(pos2, pos4 - pos2 + 1)
            TextBox15.Text -= Math.Round(zeit, 2)
            TextBox17.Text -= Math.Round(entf, 2)
            ListBox1.Items.Remove(ia)
        End If
    End Sub
    Private Sub WindDeu()
        Label18.Text = "Bezeichnung"
        GroupBox2.Text = "Windtabelle segeln"
        TableLayoutPanel1.Visible = True
        TableLayoutPanel2.Visible = False
        Label22.Text = "Windstille, Flaute"
        Label26.Text = "leiser Zug"
        Label30.Text = "leichter Brise"
        Label34.Text = "schwache Brise"
        Label38.Text = "mäßige Brise"
        Label42.Text = "frische Brise"
        Label46.Text = "starker Wind"
        Label50.Text = "steifer Wind"
        Label54.Text = "stürmischer Wind"
        Label58.Text = "Sturm"
        Label62.Text = "schwerer Sturm"
        Label66.Text = "orkanartiger Sturm"
        Label70.Text = "Orkan"
    End Sub
    Private Sub WindEng()
        Label18.Text = "Term"
        GroupBox2.Text = "sailing wind table"
        TableLayoutPanel1.Visible = True
        TableLayoutPanel2.Visible = False
        Label22.Text = "calm air"
        Label26.Text = "light air"
        Label30.Text = "light breeze"
        Label34.Text = "gentle breeze"
        Label38.Text = "moderate breeze"
        Label42.Text = "fresh breeze"
        Label46.Text = "strong breeze"
        Label50.Text = "moderate/near gale"
        Label54.Text = "fresh gale"
        Label58.Text = "strong gale"
        Label62.Text = "whole gale"
        Label66.Text = "storm, violent storm"
        Label70.Text = "hurricane"
    End Sub
    Private Sub WelleDeu()
        Label169.Text = "Bezeichnung"
        Label155.Text = "Seegangstärke"
        Label154.Text = "Wellenhöhe [m]"
        GroupBox2.Text = "Welle"
        TableLayoutPanel1.Visible = False
        TableLayoutPanel2.Visible = True
        TableLayoutPanel2.Location = New Point(27, 243)
        Label151.Text = "Glatte See"
        Label147.Text = "Sehr ruhige See"
        Label143.Text = "Ruhige See"
        Label139.Text = "Leicht bewegte See"
        Label135.Text = "Mäßig bewegte See"
        Label131.Text = "Ziemlich grobe See "
        Label127.Text = "Grobe See"
        Label123.Text = "Hohe See "
        Label119.Text = "Sehr hohe See"
        Label115.Text = "Schwere See"
    End Sub
    Private Sub WelleEng()
        TableLayoutPanel1.Visible = False
        TableLayoutPanel2.Visible = True
        TableLayoutPanel2.Location = New Point(27, 243)
        Label169.Text = "Term"
        Label155.Text = "Sea state"
        Label154.Text = "Wave height [m]"
        GroupBox2.Text = "Wave"
        Label151.Text = "Calm (glassy)"
        Label147.Text = "Calm (rippled)"
        Label143.Text = "Smooth"
        Label139.Text = "Slight"
        Label135.Text = "Moderate"
        Label131.Text = "Rough"
        Label127.Text = "Very rough"
        Label123.Text = "High"
        Label119.Text = "Very High"
        Label115.Text = "Phenomenal"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            WindDeu()
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            WindEng()
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            WelleDeu()
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            WelleEng()
        End If
    End Sub

    Private Sub TextBox15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.MouseHover
        TextBox10.Text = TextBox15.Text
        TB10_versorgen()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        GroupBox7.Location = New Point(18, 220)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        GroupBox7.Location = New Point(7718, 220)
    End Sub

    Private Sub TextBox17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.MouseHover
        TextBox1.Text = TextBox17.Text
        TB1_versorgen()
    End Sub
End Class