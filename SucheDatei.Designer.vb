<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SucheDatei
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SucheDatei))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBoxV = New System.Windows.Forms.GroupBox()
        Me.ListBoxH = New System.Windows.Forms.ListBox()
        Me.BAbruch = New System.Windows.Forms.Button()
        Me.BZurueck = New System.Windows.Forms.Button()
        Me.BLaden = New System.Windows.Forms.Button()
        Me.TextBoxV = New System.Windows.Forms.TextBox()
        Me.ListBoxV = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxV.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 362)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(225, 384)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(301, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBoxV
        '
        Me.GroupBoxV.Controls.Add(Me.ListBoxH)
        Me.GroupBoxV.Controls.Add(Me.BAbruch)
        Me.GroupBoxV.Controls.Add(Me.BZurueck)
        Me.GroupBoxV.Controls.Add(Me.BLaden)
        Me.GroupBoxV.Controls.Add(Me.TextBoxV)
        Me.GroupBoxV.Controls.Add(Me.ListBoxV)
        Me.GroupBoxV.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxV.Name = "GroupBoxV"
        Me.GroupBoxV.Size = New System.Drawing.Size(462, 316)
        Me.GroupBoxV.TabIndex = 2
        Me.GroupBoxV.TabStop = False
        Me.GroupBoxV.Text = "GroupBox1"
        '
        'ListBoxH
        '
        Me.ListBoxH.FormattingEnabled = True
        Me.ListBoxH.Location = New System.Drawing.Point(483, 21)
        Me.ListBoxH.Name = "ListBoxH"
        Me.ListBoxH.Size = New System.Drawing.Size(478, 225)
        Me.ListBoxH.TabIndex = 5
        '
        'BAbruch
        '
        Me.BAbruch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAbruch.Location = New System.Drawing.Point(167, 265)
        Me.BAbruch.Name = "BAbruch"
        Me.BAbruch.Size = New System.Drawing.Size(110, 34)
        Me.BAbruch.TabIndex = 4
        Me.BAbruch.Text = "Abrechen"
        Me.BAbruch.UseVisualStyleBackColor = True
        '
        'BZurueck
        '
        Me.BZurueck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BZurueck.Location = New System.Drawing.Point(6, 267)
        Me.BZurueck.Name = "BZurueck"
        Me.BZurueck.Size = New System.Drawing.Size(127, 34)
        Me.BZurueck.TabIndex = 3
        Me.BZurueck.Text = "1 Ordner zurück"
        Me.BZurueck.UseVisualStyleBackColor = True
        '
        'BLaden
        '
        Me.BLaden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLaden.Location = New System.Drawing.Point(315, 265)
        Me.BLaden.Name = "BLaden"
        Me.BLaden.Size = New System.Drawing.Size(128, 34)
        Me.BLaden.TabIndex = 2
        Me.BLaden.Text = "Übernehmen"
        Me.BLaden.UseVisualStyleBackColor = True
        '
        'TextBoxV
        '
        Me.TextBoxV.Location = New System.Drawing.Point(6, 21)
        Me.TextBoxV.Name = "TextBoxV"
        Me.TextBoxV.Size = New System.Drawing.Size(448, 20)
        Me.TextBoxV.TabIndex = 1
        '
        'ListBoxV
        '
        Me.ListBoxV.FormattingEnabled = True
        Me.ListBoxV.Location = New System.Drawing.Point(6, 49)
        Me.ListBoxV.Name = "ListBoxV"
        Me.ListBoxV.Size = New System.Drawing.Size(448, 199)
        Me.ListBoxV.TabIndex = 0
        '
        'SucheDatei
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(483, 340)
        Me.Controls.Add(Me.GroupBoxV)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SucheDatei"
        Me.Text = "Suchen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxV.ResumeLayout(False)
        Me.GroupBoxV.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxV As System.Windows.Forms.GroupBox
    Friend WithEvents BAbruch As System.Windows.Forms.Button
    Friend WithEvents BZurueck As System.Windows.Forms.Button
    Friend WithEvents BLaden As System.Windows.Forms.Button
    Friend WithEvents TextBoxV As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxV As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxH As System.Windows.Forms.ListBox
End Class
