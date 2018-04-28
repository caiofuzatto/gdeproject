<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEXPEDICAO
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelLOGO = New System.Windows.Forms.Label()
        Me.ButtonLIMPAR = New System.Windows.Forms.Button()
        Me.ButtonLANCAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonMUDAR = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCODIGO = New System.Windows.Forms.TextBox()
        Me.TextBoxPRODUTO = New System.Windows.Forms.TextBox()
        Me.TextBoxATOTAL = New System.Windows.Forms.TextBox()
        Me.TextBoxAUNIT = New System.Windows.Forms.TextBox()
        Me.TextBoxAQUANT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxOperador = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxANO = New System.Windows.Forms.TextBox()
        Me.TextBoxMES = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDIA = New System.Windows.Forms.TextBox()
        Me.TextBoxQUANT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPTOTAL = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPOSICAO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RichTextBoxDPOSICAO = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelLOGO
        '
        Me.LabelLOGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGO.Location = New System.Drawing.Point(190, 10)
        Me.LabelLOGO.Name = "LabelLOGO"
        Me.LabelLOGO.Size = New System.Drawing.Size(220, 25)
        Me.LabelLOGO.TabIndex = 43
        Me.LabelLOGO.Text = "Expedição de Produtos"
        Me.LabelLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonLIMPAR
        '
        Me.ButtonLIMPAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLIMPAR.Location = New System.Drawing.Point(485, 318)
        Me.ButtonLIMPAR.Name = "ButtonLIMPAR"
        Me.ButtonLIMPAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonLIMPAR.TabIndex = 41
        Me.ButtonLIMPAR.Text = "Limpar"
        Me.ButtonLIMPAR.UseVisualStyleBackColor = True
        '
        'ButtonLANCAR
        '
        Me.ButtonLANCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLANCAR.Location = New System.Drawing.Point(12, 318)
        Me.ButtonLANCAR.Name = "ButtonLANCAR"
        Me.ButtonLANCAR.Size = New System.Drawing.Size(171, 52)
        Me.ButtonLANCAR.TabIndex = 40
        Me.ButtonLANCAR.Text = "Lançar"
        Me.ButtonLANCAR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonMUDAR)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxCODIGO)
        Me.GroupBox1.Controls.Add(Me.TextBoxPRODUTO)
        Me.GroupBox1.Controls.Add(Me.TextBoxATOTAL)
        Me.GroupBox1.Controls.Add(Me.TextBoxAUNIT)
        Me.GroupBox1.Controls.Add(Me.TextBoxAQUANT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 168)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacoes do Produto"
        '
        'ButtonMUDAR
        '
        Me.ButtonMUDAR.Location = New System.Drawing.Point(227, 39)
        Me.ButtonMUDAR.Name = "ButtonMUDAR"
        Me.ButtonMUDAR.Size = New System.Drawing.Size(71, 20)
        Me.ButtonMUDAR.TabIndex = 47
        Me.ButtonMUDAR.Text = "Mudar Cod."
        Me.ButtonMUDAR.UseVisualStyleBackColor = True
        Me.ButtonMUDAR.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Produto:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 40)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Codigo de Barras:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxCODIGO
        '
        Me.TextBoxCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCODIGO.Location = New System.Drawing.Point(85, 19)
        Me.TextBoxCODIGO.Name = "TextBoxCODIGO"
        Me.TextBoxCODIGO.Size = New System.Drawing.Size(213, 22)
        Me.TextBoxCODIGO.TabIndex = 9
        '
        'TextBoxPRODUTO
        '
        Me.TextBoxPRODUTO.Enabled = False
        Me.TextBoxPRODUTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPRODUTO.Location = New System.Drawing.Point(95, 63)
        Me.TextBoxPRODUTO.Name = "TextBoxPRODUTO"
        Me.TextBoxPRODUTO.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxPRODUTO.TabIndex = 8
        '
        'TextBoxATOTAL
        '
        Me.TextBoxATOTAL.Enabled = False
        Me.TextBoxATOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxATOTAL.Location = New System.Drawing.Point(95, 137)
        Me.TextBoxATOTAL.Name = "TextBoxATOTAL"
        Me.TextBoxATOTAL.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxATOTAL.TabIndex = 7
        '
        'TextBoxAUNIT
        '
        Me.TextBoxAUNIT.Enabled = False
        Me.TextBoxAUNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAUNIT.Location = New System.Drawing.Point(95, 112)
        Me.TextBoxAUNIT.Name = "TextBoxAUNIT"
        Me.TextBoxAUNIT.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxAUNIT.TabIndex = 6
        '
        'TextBoxAQUANT
        '
        Me.TextBoxAQUANT.Enabled = False
        Me.TextBoxAQUANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAQUANT.Location = New System.Drawing.Point(95, 87)
        Me.TextBoxAQUANT.Name = "TextBoxAQUANT"
        Me.TextBoxAQUANT.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxAQUANT.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "P. Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "P. Unit:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCliente)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBoxOperador)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBoxANO)
        Me.GroupBox2.Controls.Add(Me.TextBoxMES)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxDIA)
        Me.GroupBox2.Controls.Add(Me.TextBoxQUANT)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBoxPTOTAL)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 90)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações da Expedição"
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxCliente.Location = New System.Drawing.Point(386, 65)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxCliente.TabIndex = 73
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(311, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Cliente:"
        '
        'TextBoxOperador
        '
        Me.TextBoxOperador.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxOperador.Enabled = False
        Me.TextBoxOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOperador.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxOperador.Location = New System.Drawing.Point(386, 40)
        Me.TextBoxOperador.Name = "TextBoxOperador"
        Me.TextBoxOperador.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxOperador.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(311, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Operador:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(492, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 15)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Ano"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(426, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 15)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Mes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(361, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 15)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Dia"
        '
        'TextBoxANO
        '
        Me.TextBoxANO.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxANO.Enabled = False
        Me.TextBoxANO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxANO.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxANO.Location = New System.Drawing.Point(491, 14)
        Me.TextBoxANO.Name = "TextBoxANO"
        Me.TextBoxANO.Size = New System.Drawing.Size(83, 22)
        Me.TextBoxANO.TabIndex = 66
        Me.TextBoxANO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxMES
        '
        Me.TextBoxMES.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMES.Enabled = False
        Me.TextBoxMES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMES.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxMES.Location = New System.Drawing.Point(425, 14)
        Me.TextBoxMES.Name = "TextBoxMES"
        Me.TextBoxMES.Size = New System.Drawing.Size(60, 22)
        Me.TextBoxMES.TabIndex = 65
        Me.TextBoxMES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Data:"
        '
        'TextBoxDIA
        '
        Me.TextBoxDIA.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDIA.Enabled = False
        Me.TextBoxDIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDIA.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxDIA.Location = New System.Drawing.Point(359, 14)
        Me.TextBoxDIA.Name = "TextBoxDIA"
        Me.TextBoxDIA.Size = New System.Drawing.Size(60, 22)
        Me.TextBoxDIA.TabIndex = 64
        Me.TextBoxDIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxQUANT
        '
        Me.TextBoxQUANT.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxQUANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQUANT.Location = New System.Drawing.Point(102, 25)
        Me.TextBoxQUANT.Name = "TextBoxQUANT"
        Me.TextBoxQUANT.Size = New System.Drawing.Size(153, 22)
        Me.TextBoxQUANT.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Quantidade:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Preço total:"
        '
        'TextBoxPTOTAL
        '
        Me.TextBoxPTOTAL.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPTOTAL.Enabled = False
        Me.TextBoxPTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPTOTAL.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxPTOTAL.Location = New System.Drawing.Point(102, 53)
        Me.TextBoxPTOTAL.Name = "TextBoxPTOTAL"
        Me.TextBoxPTOTAL.Size = New System.Drawing.Size(153, 22)
        Me.TextBoxPTOTAL.TabIndex = 55
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxPOSICAO)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.RichTextBoxDPOSICAO)
        Me.GroupBox3.Location = New System.Drawing.Point(334, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 168)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações da Posição"
        '
        'TextBoxPOSICAO
        '
        Me.TextBoxPOSICAO.Enabled = False
        Me.TextBoxPOSICAO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPOSICAO.Location = New System.Drawing.Point(145, 27)
        Me.TextBoxPOSICAO.Name = "TextBoxPOSICAO"
        Me.TextBoxPOSICAO.Size = New System.Drawing.Size(107, 22)
        Me.TextBoxPOSICAO.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Código da Posição:"
        '
        'RichTextBoxDPOSICAO
        '
        Me.RichTextBoxDPOSICAO.Enabled = False
        Me.RichTextBoxDPOSICAO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxDPOSICAO.Location = New System.Drawing.Point(15, 59)
        Me.RichTextBoxDPOSICAO.MaxLength = 255
        Me.RichTextBoxDPOSICAO.Name = "RichTextBoxDPOSICAO"
        Me.RichTextBoxDPOSICAO.Size = New System.Drawing.Size(237, 93)
        Me.RichTextBoxDPOSICAO.TabIndex = 0
        Me.RichTextBoxDPOSICAO.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormEXPEDICAO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 381)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelLOGO)
        Me.Controls.Add(Me.ButtonLIMPAR)
        Me.Controls.Add(Me.ButtonLANCAR)
        Me.MaximizeBox = False
        Me.Name = "FormEXPEDICAO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Expedição de Produtos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelLOGO As System.Windows.Forms.Label
    Friend WithEvents ButtonLIMPAR As System.Windows.Forms.Button
    Friend WithEvents ButtonLANCAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxATOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAUNIT As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAQUANT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxQUANT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxDPOSICAO As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxPOSICAO As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBoxPRODUTO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxANO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMES As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDIA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonMUDAR As System.Windows.Forms.Button
    Friend WithEvents TextBoxCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
