<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormENTRADA
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
        Me.ButtonLIMPAR = New System.Windows.Forms.Button()
        Me.ButtonLANCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLOGO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxFORNECEDOR = New System.Windows.Forms.TextBox()
        Me.TextBoxPRODUTO = New System.Windows.Forms.TextBox()
        Me.TextBoxCODIGO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonMUDAR = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxANO = New System.Windows.Forms.TextBox()
        Me.TextBoxMES = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxAPUNIT = New System.Windows.Forms.TextBox()
        Me.TextBoxAQUANT = New System.Windows.Forms.TextBox()
        Me.TextBoxAPTOTAL = New System.Windows.Forms.TextBox()
        Me.TextBoxNF = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPUNIT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxQUANT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDIA = New System.Windows.Forms.TextBox()
        Me.TextBoxPTOTAL = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxCODIGOP = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RichTextBoxDPOSICAO = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonLIMPAR
        '
        Me.ButtonLIMPAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLIMPAR.Location = New System.Drawing.Point(485, 317)
        Me.ButtonLIMPAR.Name = "ButtonLIMPAR"
        Me.ButtonLIMPAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonLIMPAR.TabIndex = 36
        Me.ButtonLIMPAR.Text = "Limpar"
        Me.ButtonLIMPAR.UseVisualStyleBackColor = True
        '
        'ButtonLANCAR
        '
        Me.ButtonLANCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLANCAR.Location = New System.Drawing.Point(12, 317)
        Me.ButtonLANCAR.Name = "ButtonLANCAR"
        Me.ButtonLANCAR.Size = New System.Drawing.Size(171, 52)
        Me.ButtonLANCAR.TabIndex = 35
        Me.ButtonLANCAR.Text = "Lançar"
        Me.ButtonLANCAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Produto:"
        '
        'LabelLOGO
        '
        Me.LabelLOGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGO.Location = New System.Drawing.Point(190, 9)
        Me.LabelLOGO.Name = "LabelLOGO"
        Me.LabelLOGO.Size = New System.Drawing.Size(220, 25)
        Me.LabelLOGO.TabIndex = 39
        Me.LabelLOGO.Text = "Entrada de Produtos"
        Me.LabelLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Fornecedor:"
        '
        'TextBoxFORNECEDOR
        '
        Me.TextBoxFORNECEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxFORNECEDOR.Enabled = False
        Me.TextBoxFORNECEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFORNECEDOR.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxFORNECEDOR.Location = New System.Drawing.Point(101, 102)
        Me.TextBoxFORNECEDOR.Name = "TextBoxFORNECEDOR"
        Me.TextBoxFORNECEDOR.Size = New System.Drawing.Size(190, 22)
        Me.TextBoxFORNECEDOR.TabIndex = 42
        '
        'TextBoxPRODUTO
        '
        Me.TextBoxPRODUTO.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPRODUTO.Enabled = False
        Me.TextBoxPRODUTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPRODUTO.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxPRODUTO.Location = New System.Drawing.Point(78, 76)
        Me.TextBoxPRODUTO.Name = "TextBoxPRODUTO"
        Me.TextBoxPRODUTO.Size = New System.Drawing.Size(213, 22)
        Me.TextBoxPRODUTO.TabIndex = 43
        '
        'TextBoxCODIGO
        '
        Me.TextBoxCODIGO.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCODIGO.Location = New System.Drawing.Point(91, 31)
        Me.TextBoxCODIGO.MaxLength = 13
        Me.TextBoxCODIGO.Name = "TextBoxCODIGO"
        Me.TextBoxCODIGO.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxCODIGO.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 40)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Codigo de Barras:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonMUDAR)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxCODIGO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxFORNECEDOR)
        Me.GroupBox1.Controls.Add(Me.TextBoxPRODUTO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 149)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações do Produto"
        '
        'ButtonMUDAR
        '
        Me.ButtonMUDAR.Location = New System.Drawing.Point(220, 51)
        Me.ButtonMUDAR.Name = "ButtonMUDAR"
        Me.ButtonMUDAR.Size = New System.Drawing.Size(71, 20)
        Me.ButtonMUDAR.TabIndex = 46
        Me.ButtonMUDAR.Text = "Mudar Cod."
        Me.ButtonMUDAR.UseVisualStyleBackColor = True
        Me.ButtonMUDAR.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBoxANO)
        Me.GroupBox2.Controls.Add(Me.TextBoxMES)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBoxAPUNIT)
        Me.GroupBox2.Controls.Add(Me.TextBoxAQUANT)
        Me.GroupBox2.Controls.Add(Me.TextBoxAPTOTAL)
        Me.GroupBox2.Controls.Add(Me.TextBoxNF)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBoxPUNIT)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxQUANT)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxDIA)
        Me.GroupBox2.Controls.Add(Me.TextBoxPTOTAL)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 100)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações da Entrada"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(500, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 15)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Ano"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(434, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Mes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(369, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 15)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Dia"
        '
        'TextBoxANO
        '
        Me.TextBoxANO.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxANO.Enabled = False
        Me.TextBoxANO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxANO.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxANO.Location = New System.Drawing.Point(499, 22)
        Me.TextBoxANO.Name = "TextBoxANO"
        Me.TextBoxANO.Size = New System.Drawing.Size(83, 22)
        Me.TextBoxANO.TabIndex = 59
        Me.TextBoxANO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxMES
        '
        Me.TextBoxMES.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMES.Enabled = False
        Me.TextBoxMES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMES.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxMES.Location = New System.Drawing.Point(433, 22)
        Me.TextBoxMES.Name = "TextBoxMES"
        Me.TextBoxMES.Size = New System.Drawing.Size(60, 22)
        Me.TextBoxMES.TabIndex = 58
        Me.TextBoxMES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(201, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 12)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Atual:"
        '
        'TextBoxAPUNIT
        '
        Me.TextBoxAPUNIT.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAPUNIT.Enabled = False
        Me.TextBoxAPUNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAPUNIT.Location = New System.Drawing.Point(198, 49)
        Me.TextBoxAPUNIT.Name = "TextBoxAPUNIT"
        Me.TextBoxAPUNIT.Size = New System.Drawing.Size(103, 22)
        Me.TextBoxAPUNIT.TabIndex = 56
        '
        'TextBoxAQUANT
        '
        Me.TextBoxAQUANT.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAQUANT.Enabled = False
        Me.TextBoxAQUANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAQUANT.Location = New System.Drawing.Point(198, 24)
        Me.TextBoxAQUANT.Name = "TextBoxAQUANT"
        Me.TextBoxAQUANT.Size = New System.Drawing.Size(103, 22)
        Me.TextBoxAQUANT.TabIndex = 54
        '
        'TextBoxAPTOTAL
        '
        Me.TextBoxAPTOTAL.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAPTOTAL.Enabled = False
        Me.TextBoxAPTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAPTOTAL.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxAPTOTAL.Location = New System.Drawing.Point(198, 74)
        Me.TextBoxAPTOTAL.Name = "TextBoxAPTOTAL"
        Me.TextBoxAPTOTAL.Size = New System.Drawing.Size(103, 22)
        Me.TextBoxAPTOTAL.TabIndex = 55
        '
        'TextBoxNF
        '
        Me.TextBoxNF.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNF.Location = New System.Drawing.Point(321, 70)
        Me.TextBoxNF.MaxLength = 44
        Me.TextBoxNF.Name = "TextBoxNF"
        Me.TextBoxNF.Size = New System.Drawing.Size(261, 22)
        Me.TextBoxNF.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(319, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Nota Fiscal:"
        '
        'TextBoxPUNIT
        '
        Me.TextBoxPUNIT.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPUNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPUNIT.Location = New System.Drawing.Point(84, 49)
        Me.TextBoxPUNIT.Name = "TextBoxPUNIT"
        Me.TextBoxPUNIT.Size = New System.Drawing.Size(103, 22)
        Me.TextBoxPUNIT.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Preço unit.:"
        '
        'TextBoxQUANT
        '
        Me.TextBoxQUANT.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxQUANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQUANT.Location = New System.Drawing.Point(84, 24)
        Me.TextBoxQUANT.Name = "TextBoxQUANT"
        Me.TextBoxQUANT.Size = New System.Drawing.Size(103, 22)
        Me.TextBoxQUANT.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Quantidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(319, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Data:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Preço total:"
        '
        'TextBoxDIA
        '
        Me.TextBoxDIA.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDIA.Enabled = False
        Me.TextBoxDIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDIA.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxDIA.Location = New System.Drawing.Point(367, 22)
        Me.TextBoxDIA.Name = "TextBoxDIA"
        Me.TextBoxDIA.Size = New System.Drawing.Size(60, 22)
        Me.TextBoxDIA.TabIndex = 49
        Me.TextBoxDIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxPTOTAL
        '
        Me.TextBoxPTOTAL.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPTOTAL.Enabled = False
        Me.TextBoxPTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPTOTAL.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBoxPTOTAL.Location = New System.Drawing.Point(84, 74)
        Me.TextBoxPTOTAL.Name = "TextBoxPTOTAL"
        Me.TextBoxPTOTAL.Size = New System.Drawing.Size(103, 22)
        Me.TextBoxPTOTAL.TabIndex = 48
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBoxCODIGOP)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.RichTextBoxDPOSICAO)
        Me.GroupBox3.Location = New System.Drawing.Point(334, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 149)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações da Posição"
        '
        'ComboBoxCODIGOP
        '
        Me.ComboBoxCODIGOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCODIGOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCODIGOP.FormattingEnabled = True
        Me.ComboBoxCODIGOP.Location = New System.Drawing.Point(145, 27)
        Me.ComboBoxCODIGOP.Name = "ComboBoxCODIGOP"
        Me.ComboBoxCODIGOP.Size = New System.Drawing.Size(107, 24)
        Me.ComboBoxCODIGOP.TabIndex = 47
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
        Me.RichTextBoxDPOSICAO.Size = New System.Drawing.Size(237, 74)
        Me.RichTextBoxDPOSICAO.TabIndex = 0
        Me.RichTextBoxDPOSICAO.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormENTRADA
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
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FormENTRADA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Entrada de Produtos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonLIMPAR As System.Windows.Forms.Button
    Friend WithEvents ButtonLANCAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelLOGO As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFORNECEDOR As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPRODUTO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPUNIT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxQUANT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDIA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBoxDPOSICAO As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBoxNF As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonMUDAR As System.Windows.Forms.Button
    Friend WithEvents ComboBoxCODIGOP As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAPUNIT As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAQUANT As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAPTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxANO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMES As System.Windows.Forms.TextBox
End Class
