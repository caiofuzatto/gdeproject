<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCFORNECEDORES
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCNOME = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxCCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCEMAIL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxTELEFONE = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BairroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbgdaDataSet = New gdeproject.dbgdaDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCBAIRRO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCUF = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxCCIDADE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCENDERECO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCCEP = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonLISTA = New System.Windows.Forms.Button()
        Me.ButtonEXCLUIR = New System.Windows.Forms.Button()
        Me.ButtonLIMPAR = New System.Windows.Forms.Button()
        Me.ButtonCADASTRAR = New System.Windows.Forms.Button()
        Me.DbgdaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DbgdaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLOGO
        '
        Me.LabelLOGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGO.Location = New System.Drawing.Point(190, 9)
        Me.LabelLOGO.Name = "LabelLOGO"
        Me.LabelLOGO.Size = New System.Drawing.Size(245, 25)
        Me.LabelLOGO.TabIndex = 0
        Me.LabelLOGO.Text = "Cadastro de Fornecedores"
        Me.LabelLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*Nome:"
        '
        'TextBoxCNOME
        '
        Me.TextBoxCNOME.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxCNOME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCNOME.Location = New System.Drawing.Point(64, 24)
        Me.TextBoxCNOME.Name = "TextBoxCNOME"
        Me.TextBoxCNOME.Size = New System.Drawing.Size(289, 22)
        Me.TextBoxCNOME.TabIndex = 2
        '
        'MaskedTextBoxCCNPJ
        '
        Me.MaskedTextBoxCCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxCCNPJ.Location = New System.Drawing.Point(64, 64)
        Me.MaskedTextBoxCCNPJ.Mask = "00.000.000/0000-00"
        Me.MaskedTextBoxCCNPJ.Name = "MaskedTextBoxCCNPJ"
        Me.MaskedTextBoxCCNPJ.Size = New System.Drawing.Size(135, 22)
        Me.MaskedTextBoxCCNPJ.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "*CNPJ:"
        '
        'TextBoxCEMAIL
        '
        Me.TextBoxCEMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCEMAIL.Location = New System.Drawing.Point(262, 64)
        Me.TextBoxCEMAIL.Name = "TextBoxCEMAIL"
        Me.TextBoxCEMAIL.Size = New System.Drawing.Size(284, 22)
        Me.TextBoxCEMAIL.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(219, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "*Telefone:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxTELEFONE)
        Me.GroupBox1.Controls.Add(Me.TextBoxCNOME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxCEMAIL)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxCCNPJ)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'MaskedTextBoxTELEFONE
        '
        Me.MaskedTextBoxTELEFONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxTELEFONE.Location = New System.Drawing.Point(432, 24)
        Me.MaskedTextBoxTELEFONE.Mask = "(00) 0000-0000"
        Me.MaskedTextBoxTELEFONE.Name = "MaskedTextBoxTELEFONE"
        Me.MaskedTextBoxTELEFONE.Size = New System.Drawing.Size(135, 22)
        Me.MaskedTextBoxTELEFONE.TabIndex = 12
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.CNPJDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CEPDataGridViewTextBoxColumn, Me.EnderecoDataGridViewTextBoxColumn, Me.CidadeDataGridViewTextBoxColumn, Me.UFDataGridViewTextBoxColumn, Me.BairroDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FornecedoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(589, 270)
        Me.DataGridView1.TabIndex = 41
        Me.DataGridView1.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 50
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.Width = 74
        '
        'CNPJDataGridViewTextBoxColumn
        '
        Me.CNPJDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ"
        Me.CNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ"
        Me.CNPJDataGridViewTextBoxColumn.Name = "CNPJDataGridViewTextBoxColumn"
        Me.CNPJDataGridViewTextBoxColumn.Width = 150
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'CEPDataGridViewTextBoxColumn
        '
        Me.CEPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CEPDataGridViewTextBoxColumn.DataPropertyName = "CEP"
        Me.CEPDataGridViewTextBoxColumn.HeaderText = "CEP"
        Me.CEPDataGridViewTextBoxColumn.Name = "CEPDataGridViewTextBoxColumn"
        Me.CEPDataGridViewTextBoxColumn.Width = 150
        '
        'EnderecoDataGridViewTextBoxColumn
        '
        Me.EnderecoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EnderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.HeaderText = "Endereço"
        Me.EnderecoDataGridViewTextBoxColumn.Name = "EnderecoDataGridViewTextBoxColumn"
        Me.EnderecoDataGridViewTextBoxColumn.Width = 80
        '
        'CidadeDataGridViewTextBoxColumn
        '
        Me.CidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.HeaderText = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.Name = "CidadeDataGridViewTextBoxColumn"
        Me.CidadeDataGridViewTextBoxColumn.Width = 65
        '
        'UFDataGridViewTextBoxColumn
        '
        Me.UFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UFDataGridViewTextBoxColumn.DataPropertyName = "UF"
        Me.UFDataGridViewTextBoxColumn.HeaderText = "UF"
        Me.UFDataGridViewTextBoxColumn.Name = "UFDataGridViewTextBoxColumn"
        Me.UFDataGridViewTextBoxColumn.Width = 30
        '
        'BairroDataGridViewTextBoxColumn
        '
        Me.BairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.HeaderText = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.Name = "BairroDataGridViewTextBoxColumn"
        Me.BairroDataGridViewTextBoxColumn.Width = 59
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.DbgdaDataSet
        '
        'DbgdaDataSet
        '
        Me.DbgdaDataSet.DataSetName = "dbgdaDataSet"
        Me.DbgdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCBAIRRO)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBoxCUF)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBoxCCIDADE)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBoxCENDERECO)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxCCEP)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 121)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Localização"
        '
        'TextBoxCBAIRRO
        '
        Me.TextBoxCBAIRRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCBAIRRO.Location = New System.Drawing.Point(362, 69)
        Me.TextBoxCBAIRRO.Name = "TextBoxCBAIRRO"
        Me.TextBoxCBAIRRO.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxCBAIRRO.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(315, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Bairro:"
        '
        'TextBoxCUF
        '
        Me.TextBoxCUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCUF.Location = New System.Drawing.Point(257, 69)
        Me.TextBoxCUF.MaxLength = 2
        Me.TextBoxCUF.Name = "TextBoxCUF"
        Me.TextBoxCUF.Size = New System.Drawing.Size(43, 22)
        Me.TextBoxCUF.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(222, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "*UF:"
        '
        'TextBoxCCIDADE
        '
        Me.TextBoxCCIDADE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCCIDADE.Location = New System.Drawing.Point(64, 69)
        Me.TextBoxCCIDADE.Name = "TextBoxCCIDADE"
        Me.TextBoxCCIDADE.Size = New System.Drawing.Size(147, 22)
        Me.TextBoxCCIDADE.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "*Cidade:"
        '
        'TextBoxCENDERECO
        '
        Me.TextBoxCENDERECO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCENDERECO.Location = New System.Drawing.Point(292, 31)
        Me.TextBoxCENDERECO.Multiline = True
        Me.TextBoxCENDERECO.Name = "TextBoxCENDERECO"
        Me.TextBoxCENDERECO.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxCENDERECO.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(219, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "*Endereço:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "*CEP:"
        '
        'MaskedTextBoxCCEP
        '
        Me.MaskedTextBoxCCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxCCEP.Location = New System.Drawing.Point(64, 31)
        Me.MaskedTextBoxCCEP.Mask = "00.000-000"
        Me.MaskedTextBoxCCEP.Name = "MaskedTextBoxCCEP"
        Me.MaskedTextBoxCCEP.Size = New System.Drawing.Size(135, 22)
        Me.MaskedTextBoxCCEP.TabIndex = 14
        '
        'ButtonLISTA
        '
        Me.ButtonLISTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLISTA.Location = New System.Drawing.Point(314, 317)
        Me.ButtonLISTA.Name = "ButtonLISTA"
        Me.ButtonLISTA.Size = New System.Drawing.Size(105, 52)
        Me.ButtonLISTA.TabIndex = 39
        Me.ButtonLISTA.Text = "Lista de Fornecedores"
        Me.ButtonLISTA.UseVisualStyleBackColor = True
        '
        'ButtonEXCLUIR
        '
        Me.ButtonEXCLUIR.Enabled = False
        Me.ButtonEXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEXCLUIR.Location = New System.Drawing.Point(193, 317)
        Me.ButtonEXCLUIR.Name = "ButtonEXCLUIR"
        Me.ButtonEXCLUIR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonEXCLUIR.TabIndex = 38
        Me.ButtonEXCLUIR.Text = "Excluir"
        Me.ButtonEXCLUIR.UseVisualStyleBackColor = True
        '
        'ButtonLIMPAR
        '
        Me.ButtonLIMPAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLIMPAR.Location = New System.Drawing.Point(486, 317)
        Me.ButtonLIMPAR.Name = "ButtonLIMPAR"
        Me.ButtonLIMPAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonLIMPAR.TabIndex = 36
        Me.ButtonLIMPAR.Text = "Limpar"
        Me.ButtonLIMPAR.UseVisualStyleBackColor = True
        '
        'ButtonCADASTRAR
        '
        Me.ButtonCADASTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonCADASTRAR.Location = New System.Drawing.Point(12, 317)
        Me.ButtonCADASTRAR.Name = "ButtonCADASTRAR"
        Me.ButtonCADASTRAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonCADASTRAR.TabIndex = 35
        Me.ButtonCADASTRAR.Text = "Cadastrar"
        Me.ButtonCADASTRAR.UseVisualStyleBackColor = True
        '
        'DbgdaDataSetBindingSource
        '
        Me.DbgdaDataSetBindingSource.DataSource = Me.DbgdaDataSet
        Me.DbgdaDataSetBindingSource.Position = 0
        '
        'FormCFORNECEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 381)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonLISTA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonEXCLUIR)
        Me.Controls.Add(Me.LabelLOGO)
        Me.Controls.Add(Me.ButtonCADASTRAR)
        Me.Controls.Add(Me.ButtonLIMPAR)
        Me.MaximizeBox = False
        Me.Name = "FormCFORNECEDORES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Cadastro de Fornecedores"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DbgdaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelLOGO As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCNOME As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxCCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCBAIRRO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCUF As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCCIDADE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCENDERECO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxCCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonLISTA As System.Windows.Forms.Button
    Friend WithEvents ButtonEXCLUIR As System.Windows.Forms.Button
    Friend WithEvents ButtonLIMPAR As System.Windows.Forms.Button
    Friend WithEvents ButtonCADASTRAR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FornecedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbgdaDataSet As gdeproject.dbgdaDataSet
    Friend WithEvents DbgdaDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaskedTextBoxTELEFONE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BairroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
