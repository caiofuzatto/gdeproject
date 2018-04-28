<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCPRODUTOS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxCDESCRICAO = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxCFORNECEDOR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCNOME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelBARCODE = New System.Windows.Forms.Label()
        Me.TextBoxCBARCODE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonLISTA = New System.Windows.Forms.Button()
        Me.ButtonEXCLUIR = New System.Windows.Forms.Button()
        Me.ButtonLIMPAR = New System.Windows.Forms.Button()
        Me.ButtonCADASTRAR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornecedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBARRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbgdaDataSet = New gdeproject.dbgdaDataSet()
        Me.ProdutoTableAdapter = New gdeproject.dbgdaDataSetTableAdapters.produtoTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLOGO
        '
        Me.LabelLOGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGO.Location = New System.Drawing.Point(201, 9)
        Me.LabelLOGO.Name = "LabelLOGO"
        Me.LabelLOGO.Size = New System.Drawing.Size(220, 25)
        Me.LabelLOGO.TabIndex = 25
        Me.LabelLOGO.Text = "Cadastro de Produtos"
        Me.LabelLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBoxCDESCRICAO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCFORNECEDOR)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxCNOME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 245)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'RichTextBoxCDESCRICAO
        '
        Me.RichTextBoxCDESCRICAO.Location = New System.Drawing.Point(13, 120)
        Me.RichTextBoxCDESCRICAO.Name = "RichTextBoxCDESCRICAO"
        Me.RichTextBoxCDESCRICAO.Size = New System.Drawing.Size(265, 106)
        Me.RichTextBoxCDESCRICAO.TabIndex = 16
        Me.RichTextBoxCDESCRICAO.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descrição:"
        '
        'ComboBoxCFORNECEDOR
        '
        Me.ComboBoxCFORNECEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCFORNECEDOR.FormattingEnabled = True
        Me.ComboBoxCFORNECEDOR.Location = New System.Drawing.Point(97, 62)
        Me.ComboBoxCFORNECEDOR.Name = "ComboBoxCFORNECEDOR"
        Me.ComboBoxCFORNECEDOR.Size = New System.Drawing.Size(181, 21)
        Me.ComboBoxCFORNECEDOR.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fornecedor:"
        '
        'TextBoxCNOME
        '
        Me.TextBoxCNOME.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxCNOME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCNOME.Location = New System.Drawing.Point(64, 24)
        Me.TextBoxCNOME.Name = "TextBoxCNOME"
        Me.TextBoxCNOME.Size = New System.Drawing.Size(214, 22)
        Me.TextBoxCNOME.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelBARCODE)
        Me.GroupBox3.Controls.Add(Me.TextBoxCBARCODE)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(312, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 226)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Código de Barras"
        '
        'LabelBARCODE
        '
        Me.LabelBARCODE.AutoSize = True
        Me.LabelBARCODE.Font = New System.Drawing.Font("barcode font", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBARCODE.Location = New System.Drawing.Point(24, 91)
        Me.LabelBARCODE.Name = "LabelBARCODE"
        Me.LabelBARCODE.Size = New System.Drawing.Size(0, 97)
        Me.LabelBARCODE.TabIndex = 3
        '
        'TextBoxCBARCODE
        '
        Me.TextBoxCBARCODE.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCBARCODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCBARCODE.Location = New System.Drawing.Point(70, 26)
        Me.TextBoxCBARCODE.MaxLength = 15
        Me.TextBoxCBARCODE.Name = "TextBoxCBARCODE"
        Me.TextBoxCBARCODE.Size = New System.Drawing.Size(208, 22)
        Me.TextBoxCBARCODE.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Código:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ButtonLISTA
        '
        Me.ButtonLISTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLISTA.Location = New System.Drawing.Point(314, 317)
        Me.ButtonLISTA.Name = "ButtonLISTA"
        Me.ButtonLISTA.Size = New System.Drawing.Size(105, 52)
        Me.ButtonLISTA.TabIndex = 33
        Me.ButtonLISTA.Text = "Lista de Produtos"
        Me.ButtonLISTA.UseVisualStyleBackColor = True
        '
        'ButtonEXCLUIR
        '
        Me.ButtonEXCLUIR.Enabled = False
        Me.ButtonEXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEXCLUIR.Location = New System.Drawing.Point(193, 317)
        Me.ButtonEXCLUIR.Name = "ButtonEXCLUIR"
        Me.ButtonEXCLUIR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonEXCLUIR.TabIndex = 32
        Me.ButtonEXCLUIR.Text = "Excluir"
        Me.ButtonEXCLUIR.UseVisualStyleBackColor = True
        '
        'ButtonLIMPAR
        '
        Me.ButtonLIMPAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLIMPAR.Location = New System.Drawing.Point(486, 317)
        Me.ButtonLIMPAR.Name = "ButtonLIMPAR"
        Me.ButtonLIMPAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonLIMPAR.TabIndex = 30
        Me.ButtonLIMPAR.Text = "Limpar"
        Me.ButtonLIMPAR.UseVisualStyleBackColor = True
        '
        'ButtonCADASTRAR
        '
        Me.ButtonCADASTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonCADASTRAR.Location = New System.Drawing.Point(11, 317)
        Me.ButtonCADASTRAR.Name = "ButtonCADASTRAR"
        Me.ButtonCADASTRAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonCADASTRAR.TabIndex = 29
        Me.ButtonCADASTRAR.Text = "Cadastrar"
        Me.ButtonCADASTRAR.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.FornecedorDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.CodigoBARRADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProdutoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(589, 270)
        Me.DataGridView1.TabIndex = 42
        Me.DataGridView1.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 65
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.Width = 60
        '
        'FornecedorDataGridViewTextBoxColumn
        '
        Me.FornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor"
        Me.FornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor"
        Me.FornecedorDataGridViewTextBoxColumn.Name = "FornecedorDataGridViewTextBoxColumn"
        Me.FornecedorDataGridViewTextBoxColumn.Width = 86
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.Width = 150
        '
        'CodigoBARRADataGridViewTextBoxColumn
        '
        Me.CodigoBARRADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodigoBARRADataGridViewTextBoxColumn.DataPropertyName = "CodigoBARRA"
        Me.CodigoBARRADataGridViewTextBoxColumn.HeaderText = "Código de Barra"
        Me.CodigoBARRADataGridViewTextBoxColumn.Name = "CodigoBARRADataGridViewTextBoxColumn"
        Me.CodigoBARRADataGridViewTextBoxColumn.Width = 110
        '
        'ProdutoBindingSource
        '
        Me.ProdutoBindingSource.DataMember = "produto"
        Me.ProdutoBindingSource.DataSource = Me.DbgdaDataSet
        '
        'DbgdaDataSet
        '
        Me.DbgdaDataSet.DataSetName = "dbgdaDataSet"
        Me.DbgdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdutoTableAdapter
        '
        Me.ProdutoTableAdapter.ClearBeforeFill = True
        '
        'FormCPRODUTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 381)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButtonLISTA)
        Me.Controls.Add(Me.ButtonEXCLUIR)
        Me.Controls.Add(Me.LabelLOGO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonLIMPAR)
        Me.Controls.Add(Me.ButtonCADASTRAR)
        Me.MaximizeBox = False
        Me.Name = "FormCPRODUTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Cadastro de Produtos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelLOGO As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCFORNECEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCNOME As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCBARCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelBARCODE As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxCDESCRICAO As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonLISTA As System.Windows.Forms.Button
    Friend WithEvents ButtonEXCLUIR As System.Windows.Forms.Button
    Friend WithEvents ButtonLIMPAR As System.Windows.Forms.Button
    Friend WithEvents ButtonCADASTRAR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DbgdaDataSet As gdeproject.dbgdaDataSet
    Friend WithEvents ProdutoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutoTableAdapter As gdeproject.dbgdaDataSetTableAdapters.produtoTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FornecedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBARRADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
