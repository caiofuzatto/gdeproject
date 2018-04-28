<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelLOGO = New System.Windows.Forms.Label()
        Me.ButtonENTRAR = New System.Windows.Forms.Button()
        Me.ButtonSAIR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxSENHA = New System.Windows.Forms.TextBox()
        Me.TextBoxUSUARIO = New System.Windows.Forms.TextBox()
        Me.LabelSENHA = New System.Windows.Forms.Label()
        Me.LabelUSUARIO = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelLOGO
        '
        Me.LabelLOGO.AutoSize = True
        Me.LabelLOGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGO.Location = New System.Drawing.Point(82, 23)
        Me.LabelLOGO.Name = "LabelLOGO"
        Me.LabelLOGO.Size = New System.Drawing.Size(192, 39)
        Me.LabelLOGO.TabIndex = 0
        Me.LabelLOGO.Text = "GDA Entrar"
        '
        'ButtonENTRAR
        '
        Me.ButtonENTRAR.Location = New System.Drawing.Point(13, 221)
        Me.ButtonENTRAR.Name = "ButtonENTRAR"
        Me.ButtonENTRAR.Size = New System.Drawing.Size(143, 23)
        Me.ButtonENTRAR.TabIndex = 2
        Me.ButtonENTRAR.Text = "Entrar"
        Me.ButtonENTRAR.UseVisualStyleBackColor = True
        '
        'ButtonSAIR
        '
        Me.ButtonSAIR.Location = New System.Drawing.Point(187, 221)
        Me.ButtonSAIR.Name = "ButtonSAIR"
        Me.ButtonSAIR.Size = New System.Drawing.Size(143, 23)
        Me.ButtonSAIR.TabIndex = 3
        Me.ButtonSAIR.Text = "Sair"
        Me.ButtonSAIR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxSENHA)
        Me.GroupBox1.Controls.Add(Me.TextBoxUSUARIO)
        Me.GroupBox1.Controls.Add(Me.LabelSENHA)
        Me.GroupBox1.Controls.Add(Me.LabelUSUARIO)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 119)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Autenticação de usuário"
        '
        'TextBoxSENHA
        '
        Me.TextBoxSENHA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxSENHA.Location = New System.Drawing.Point(85, 79)
        Me.TextBoxSENHA.Name = "TextBoxSENHA"
        Me.TextBoxSENHA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSENHA.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxSENHA.TabIndex = 7
        '
        'TextBoxUSUARIO
        '
        Me.TextBoxUSUARIO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxUSUARIO.Location = New System.Drawing.Point(85, 32)
        Me.TextBoxUSUARIO.Name = "TextBoxUSUARIO"
        Me.TextBoxUSUARIO.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxUSUARIO.TabIndex = 6
        '
        'LabelSENHA
        '
        Me.LabelSENHA.AutoSize = True
        Me.LabelSENHA.Location = New System.Drawing.Point(24, 82)
        Me.LabelSENHA.Name = "LabelSENHA"
        Me.LabelSENHA.Size = New System.Drawing.Size(41, 13)
        Me.LabelSENHA.TabIndex = 5
        Me.LabelSENHA.Text = "Senha:"
        '
        'LabelUSUARIO
        '
        Me.LabelUSUARIO.AutoSize = True
        Me.LabelUSUARIO.Location = New System.Drawing.Point(24, 35)
        Me.LabelUSUARIO.Name = "LabelUSUARIO"
        Me.LabelUSUARIO.Size = New System.Drawing.Size(46, 13)
        Me.LabelUSUARIO.TabIndex = 4
        Me.LabelUSUARIO.Text = "Usuário:"
        '
        'FormLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 265)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSAIR)
        Me.Controls.Add(Me.ButtonENTRAR)
        Me.Controls.Add(Me.LabelLOGO)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(358, 303)
        Me.MinimumSize = New System.Drawing.Size(358, 303)
        Me.Name = "FormLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Autenticação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelLOGO As System.Windows.Forms.Label
    Friend WithEvents ButtonENTRAR As System.Windows.Forms.Button
    Friend WithEvents ButtonSAIR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxSENHA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents LabelSENHA As System.Windows.Forms.Label
    Friend WithEvents LabelUSUARIO As System.Windows.Forms.Label
End Class
