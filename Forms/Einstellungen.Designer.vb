<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Einstellungen))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkAntriebsart = New System.Windows.Forms.CheckBox()
        Me.chkWolken = New System.Windows.Forms.CheckBox()
        Me.chkLuftdruck = New System.Windows.Forms.CheckBox()
        Me.chkSeegang = New System.Windows.Forms.CheckBox()
        Me.chkWindstaerke = New System.Windows.Forms.CheckBox()
        Me.chkWindRichtung = New System.Windows.Forms.CheckBox()
        Me.chkCopyFromPrevious = New System.Windows.Forms.CheckBox()
        Me.lblDatenHolenHint = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Druckereinstellungen"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(236, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anzahl der Buchstaben in einer Druckzeile"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(323, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(489, 110)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ländereinstellung"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(199, 30)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Deutschland"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(25, 30)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Österreich"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(80, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(48, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "km - Geld"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cent"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDatenHolenHint)
        Me.GroupBox3.Controls.Add(Me.chkAntriebsart)
        Me.GroupBox3.Controls.Add(Me.chkWolken)
        Me.GroupBox3.Controls.Add(Me.chkLuftdruck)
        Me.GroupBox3.Controls.Add(Me.chkSeegang)
        Me.GroupBox3.Controls.Add(Me.chkWindstaerke)
        Me.GroupBox3.Controls.Add(Me.chkWindRichtung)
        Me.GroupBox3.Controls.Add(Me.chkCopyFromPrevious)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 155)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Logbuch – Daten holen"
        '
        'chkCopyFromPrevious
        '
        Me.chkCopyFromPrevious.AutoSize = True
        Me.chkCopyFromPrevious.Location = New System.Drawing.Point(25, 28)
        Me.chkCopyFromPrevious.Name = "chkCopyFromPrevious"
        Me.chkCopyFromPrevious.Size = New System.Drawing.Size(280, 17)
        Me.chkCopyFromPrevious.TabIndex = 0
        Me.chkCopyFromPrevious.Text = "Felder vom vorherigen Eintrag übernehmen"
        Me.chkCopyFromPrevious.UseVisualStyleBackColor = True
        '
        'chkWindRichtung
        '
        Me.chkWindRichtung.AutoSize = True
        Me.chkWindRichtung.Location = New System.Drawing.Point(45, 55)
        Me.chkWindRichtung.Name = "chkWindRichtung"
        Me.chkWindRichtung.Size = New System.Drawing.Size(94, 17)
        Me.chkWindRichtung.TabIndex = 1
        Me.chkWindRichtung.Text = "Windrichtung"
        Me.chkWindRichtung.UseVisualStyleBackColor = True
        '
        'chkWindstaerke
        '
        Me.chkWindstaerke.AutoSize = True
        Me.chkWindstaerke.Location = New System.Drawing.Point(199, 55)
        Me.chkWindstaerke.Name = "chkWindstaerke"
        Me.chkWindstaerke.Size = New System.Drawing.Size(88, 17)
        Me.chkWindstaerke.TabIndex = 2
        Me.chkWindstaerke.Text = "Windstärke"
        Me.chkWindstaerke.UseVisualStyleBackColor = True
        '
        'chkSeegang
        '
        Me.chkSeegang.AutoSize = True
        Me.chkSeegang.Location = New System.Drawing.Point(345, 55)
        Me.chkSeegang.Name = "chkSeegang"
        Me.chkSeegang.Size = New System.Drawing.Size(68, 17)
        Me.chkSeegang.TabIndex = 3
        Me.chkSeegang.Text = "Seegang"
        Me.chkSeegang.UseVisualStyleBackColor = True
        '
        'chkLuftdruck
        '
        Me.chkLuftdruck.AutoSize = True
        Me.chkLuftdruck.Location = New System.Drawing.Point(45, 82)
        Me.chkLuftdruck.Name = "chkLuftdruck"
        Me.chkLuftdruck.Size = New System.Drawing.Size(73, 17)
        Me.chkLuftdruck.TabIndex = 4
        Me.chkLuftdruck.Text = "Luftdruck"
        Me.chkLuftdruck.UseVisualStyleBackColor = True
        '
        'chkWolken
        '
        Me.chkWolken.AutoSize = True
        Me.chkWolken.Location = New System.Drawing.Point(199, 82)
        Me.chkWolken.Name = "chkWolken"
        Me.chkWolken.Size = New System.Drawing.Size(62, 17)
        Me.chkWolken.TabIndex = 5
        Me.chkWolken.Text = "Wolken"
        Me.chkWolken.UseVisualStyleBackColor = True
        '
        'chkAntriebsart
        '
        Me.chkAntriebsart.AutoSize = True
        Me.chkAntriebsart.Location = New System.Drawing.Point(345, 82)
        Me.chkAntriebsart.Name = "chkAntriebsart"
        Me.chkAntriebsart.Size = New System.Drawing.Size(79, 17)
        Me.chkAntriebsart.TabIndex = 6
        Me.chkAntriebsart.Text = "Antriebsart"
        Me.chkAntriebsart.UseVisualStyleBackColor = True
        '
        'lblDatenHolenHint
        '
        Me.lblDatenHolenHint.Location = New System.Drawing.Point(22, 112)
        Me.lblDatenHolenHint.Name = "lblDatenHolenHint"
        Me.lblDatenHolenHint.Size = New System.Drawing.Size(450, 32)
        Me.lblDatenHolenHint.TabIndex = 7
        Me.lblDatenHolenHint.Text = "Gilt beim Klick auf 'Daten holen'. Ohne vorherigen Eintrag am selben Tag bleiben die Felder leer. Uhrzeit und NMEA-Daten werden weiterhin aktualisiert."
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 448)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Einstellungen"
        Me.Text = "Einstellungen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCopyFromPrevious As System.Windows.Forms.CheckBox
    Friend WithEvents chkWindRichtung As System.Windows.Forms.CheckBox
    Friend WithEvents chkWindstaerke As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeegang As System.Windows.Forms.CheckBox
    Friend WithEvents chkLuftdruck As System.Windows.Forms.CheckBox
    Friend WithEvents chkWolken As System.Windows.Forms.CheckBox
    Friend WithEvents chkAntriebsart As System.Windows.Forms.CheckBox
    Friend WithEvents lblDatenHolenHint As System.Windows.Forms.Label
End Class
