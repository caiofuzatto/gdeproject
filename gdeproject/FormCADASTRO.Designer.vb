<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCADASTRO
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
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSENHA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxUSUARIO = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCADASTRAR = New System.Windows.Forms.Button()
        Me.ButtonLIMPAR = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonEXCLUIR = New System.Windows.Forms.Button()
        Me.ButtonLISTA = New System.Windows.Forms.Button()
        Me.LabelVerifSENHA = New System.Windows.Forms.Label()
        Me.TextBoxSENHA2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSENHA1 = New System.Windows.Forms.TextBox()
        Me.LabelUsuarioC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUSUARIOC = New System.Windows.Forms.TextBox()
        Me.ComboBoxGRUPOC = New System.Windows.Forms.ComboBox()
        Me.ButtonEDITAR = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenhaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbgdaDataSet = New gdeproject.dbgdaDataSet()
        Me.UsuariosTableAdapter = New gdeproject.dbgdaDataSetTableAdapters.usuariosTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLogo
        '
        Me.LabelLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogo.Location = New System.Drawing.Point(190, 9)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(228, 25)
        Me.LabelLogo.TabIndex = 2
        Me.LabelLogo.Text = "Cadastro de Usuários"
        Me.LabelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Senha:"
        '
        'TextBoxSENHA
        '
        Me.TextBoxSENHA.Location = New System.Drawing.Point(362, 24)
        Me.TextBoxSENHA.Name = "TextBoxSENHA"
        Me.TextBoxSENHA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSENHA.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxSENHA.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Usuario:"
        '
        'TextBoxUSUARIO
        '
        Me.TextBoxUSUARIO.Location = New System.Drawing.Point(94, 24)
        Me.TextBoxUSUARIO.Name = "TextBoxUSUARIO"
        Me.TextBoxUSUARIO.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxUSUARIO.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxUSUARIO)
        Me.GroupBox1.Controls.Add(Me.TextBoxSENHA)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 54)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Confirmação de Grupo"
        '
        'ButtonCADASTRAR
        '
        Me.ButtonCADASTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonCADASTRAR.Location = New System.Drawing.Point(11, 317)
        Me.ButtonCADASTRAR.Name = "ButtonCADASTRAR"
        Me.ButtonCADASTRAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonCADASTRAR.TabIndex = 15
        Me.ButtonCADASTRAR.Text = "Cadastrar"
        Me.ButtonCADASTRAR.UseVisualStyleBackColor = True
        '
        'ButtonLIMPAR
        '
        Me.ButtonLIMPAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLIMPAR.Location = New System.Drawing.Point(486, 317)
        Me.ButtonLIMPAR.Name = "ButtonLIMPAR"
        Me.ButtonLIMPAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonLIMPAR.TabIndex = 16
        Me.ButtonLIMPAR.Text = "Limpar"
        Me.ButtonLIMPAR.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ButtonEXCLUIR
        '
        Me.ButtonEXCLUIR.Enabled = False
        Me.ButtonEXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEXCLUIR.Location = New System.Drawing.Point(189, 317)
        Me.ButtonEXCLUIR.Name = "ButtonEXCLUIR"
        Me.ButtonEXCLUIR.Size = New System.Drawing.Size(115, 25)
        Me.ButtonEXCLUIR.TabIndex = 18
        Me.ButtonEXCLUIR.Text = "Excluir"
        Me.ButtonEXCLUIR.UseVisualStyleBackColor = True
        '
        'ButtonLISTA
        '
        Me.ButtonLISTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLISTA.Location = New System.Drawing.Point(310, 317)
        Me.ButtonLISTA.Name = "ButtonLISTA"
        Me.ButtonLISTA.Size = New System.Drawing.Size(105, 52)
        Me.ButtonLISTA.TabIndex = 19
        Me.ButtonLISTA.Text = "Lista de Usuários"
        Me.ButtonLISTA.UseVisualStyleBackColor = True
        '
        'LabelVerifSENHA
        '
        Me.LabelVerifSENHA.AutoSize = True
        Me.LabelVerifSENHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerifSENHA.Location = New System.Drawing.Point(386, 79)
        Me.LabelVerifSENHA.Name = "LabelVerifSENHA"
        Me.LabelVerifSENHA.Size = New System.Drawing.Size(0, 13)
        Me.LabelVerifSENHA.TabIndex = 27
        '
        'TextBoxSENHA2
        '
        Me.TextBoxSENHA2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxSENHA2.Location = New System.Drawing.Point(362, 51)
        Me.TextBoxSENHA2.Name = "TextBoxSENHA2"
        Me.TextBoxSENHA2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSENHA2.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxSENHA2.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Senha:"
        '
        'TextBoxSENHA1
        '
        Me.TextBoxSENHA1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxSENHA1.Location = New System.Drawing.Point(362, 25)
        Me.TextBoxSENHA1.Name = "TextBoxSENHA1"
        Me.TextBoxSENHA1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSENHA1.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxSENHA1.TabIndex = 24
        '
        'LabelUsuarioC
        '
        Me.LabelUsuarioC.AutoSize = True
        Me.LabelUsuarioC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarioC.Location = New System.Drawing.Point(21, 23)
        Me.LabelUsuarioC.Name = "LabelUsuarioC"
        Me.LabelUsuarioC.Size = New System.Drawing.Size(61, 17)
        Me.LabelUsuarioC.TabIndex = 22
        Me.LabelUsuarioC.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Grupo:"
        '
        'TextBoxUSUARIOC
        '
        Me.TextBoxUSUARIOC.Location = New System.Drawing.Point(88, 23)
        Me.TextBoxUSUARIOC.Name = "TextBoxUSUARIOC"
        Me.TextBoxUSUARIOC.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxUSUARIOC.TabIndex = 20
        '
        'ComboBoxGRUPOC
        '
        Me.ComboBoxGRUPOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGRUPOC.FormattingEnabled = True
        Me.ComboBoxGRUPOC.Items.AddRange(New Object() {"Operador", "Administrador"})
        Me.ComboBoxGRUPOC.Location = New System.Drawing.Point(88, 67)
        Me.ComboBoxGRUPOC.Name = "ComboBoxGRUPOC"
        Me.ComboBoxGRUPOC.Size = New System.Drawing.Size(174, 21)
        Me.ComboBoxGRUPOC.TabIndex = 21
        '
        'ButtonEDITAR
        '
        Me.ButtonEDITAR.Enabled = False
        Me.ButtonEDITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEDITAR.Location = New System.Drawing.Point(189, 344)
        Me.ButtonEDITAR.Name = "ButtonEDITAR"
        Me.ButtonEDITAR.Size = New System.Drawing.Size(115, 25)
        Me.ButtonEDITAR.TabIndex = 28
        Me.ButtonEDITAR.Text = "Editar"
        Me.ButtonEDITAR.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LabelUsuarioC)
        Me.GroupBox2.Controls.Add(Me.ComboBoxGRUPOC)
        Me.GroupBox2.Controls.Add(Me.TextBoxUSUARIOC)
        Me.GroupBox2.Controls.Add(Me.TextBoxSENHA2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxSENHA1)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 102)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações do Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Digite uma senha!"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.SenhaDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsuariosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(589, 264)
        Me.DataGridView1.TabIndex = 43
        Me.DataGridView1.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 65
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuário"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.Width = 68
        '
        'SenhaDataGridViewTextBoxColumn
        '
        Me.SenhaDataGridViewTextBoxColumn.DataPropertyName = "senha"
        Me.SenhaDataGridViewTextBoxColumn.HeaderText = "Senha"
        Me.SenhaDataGridViewTextBoxColumn.Name = "SenhaDataGridViewTextBoxColumn"
        Me.SenhaDataGridViewTextBoxColumn.Width = 63
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.Width = 61
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.DbgdaDataSet
        '
        'DbgdaDataSet
        '
        Me.DbgdaDataSet.DataSetName = "dbgdaDataSet"
        Me.DbgdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'FormCADASTRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 381)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonEDITAR)
        Me.Controls.Add(Me.LabelVerifSENHA)
        Me.Controls.Add(Me.ButtonLISTA)
        Me.Controls.Add(Me.ButtonEXCLUIR)
        Me.Controls.Add(Me.ButtonLIMPAR)
        Me.Controls.Add(Me.ButtonCADASTRAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelLogo)
        Me.MaximizeBox = False
        Me.Name = "FormCADASTRO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Cadastro de Usuários"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelLogo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSENHA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCADASTRAR As System.Windows.Forms.Button
    Friend WithEvents ButtonLIMPAR As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonEXCLUIR As System.Windows.Forms.Button
    Friend WithEvents ButtonLISTA As System.Windows.Forms.Button
    Friend WithEvents LabelVerifSENHA As System.Windows.Forms.Label
    Friend WithEvents TextBoxSENHA2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSENHA1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelUsuarioC As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUSUARIOC As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxGRUPOC As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonEDITAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DbgdaDataSet As gdeproject.dbgdaDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As gdeproject.dbgdaDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenhaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
