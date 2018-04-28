<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCPOSICAO
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
        Me.ButtonLISTA = New System.Windows.Forms.Button()
        Me.ButtonEXCLUIR = New System.Windows.Forms.Button()
        Me.ButtonLIMPAR = New System.Windows.Forms.Button()
        Me.ButtonCADASTRAR = New System.Windows.Forms.Button()
        Me.LabelLOGO = New System.Windows.Forms.Label()
        Me.RichTextBoxCDESCRICAO = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCARACQ = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCODIGOP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosicoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbgdaDataSet = New gdeproject.dbgdaDataSet()
        Me.PosicoesTableAdapter = New gdeproject.dbgdaDataSetTableAdapters.posicoesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PosicoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLISTA
        '
        Me.ButtonLISTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLISTA.Location = New System.Drawing.Point(312, 317)
        Me.ButtonLISTA.Name = "ButtonLISTA"
        Me.ButtonLISTA.Size = New System.Drawing.Size(105, 52)
        Me.ButtonLISTA.TabIndex = 39
        Me.ButtonLISTA.Text = "Lista de Posições"
        Me.ButtonLISTA.UseVisualStyleBackColor = True
        '
        'ButtonEXCLUIR
        '
        Me.ButtonEXCLUIR.Enabled = False
        Me.ButtonEXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEXCLUIR.Location = New System.Drawing.Point(191, 317)
        Me.ButtonEXCLUIR.Name = "ButtonEXCLUIR"
        Me.ButtonEXCLUIR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonEXCLUIR.TabIndex = 38
        Me.ButtonEXCLUIR.Text = "Excluir"
        Me.ButtonEXCLUIR.UseVisualStyleBackColor = True
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
        'LabelLOGO
        '
        Me.LabelLOGO.AutoSize = True
        Me.LabelLOGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGO.Location = New System.Drawing.Point(210, 9)
        Me.LabelLOGO.Name = "LabelLOGO"
        Me.LabelLOGO.Size = New System.Drawing.Size(204, 25)
        Me.LabelLOGO.TabIndex = 41
        Me.LabelLOGO.Text = "Cadastro de Posições"
        '
        'RichTextBoxCDESCRICAO
        '
        Me.RichTextBoxCDESCRICAO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxCDESCRICAO.Location = New System.Drawing.Point(11, 160)
        Me.RichTextBoxCDESCRICAO.MaxLength = 255
        Me.RichTextBoxCDESCRICAO.Name = "RichTextBoxCDESCRICAO"
        Me.RichTextBoxCDESCRICAO.Size = New System.Drawing.Size(589, 146)
        Me.RichTextBoxCDESCRICAO.TabIndex = 42
        Me.RichTextBoxCDESCRICAO.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Descrição:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(235, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 73)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atenção"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = " cadastrada no sistema."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = " Verifique se não esta cadastrando uma posição que já foi"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(504, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Caracteres:"
        '
        'LabelCARACQ
        '
        Me.LabelCARACQ.AutoSize = True
        Me.LabelCARACQ.Location = New System.Drawing.Point(571, 293)
        Me.LabelCARACQ.Name = "LabelCARACQ"
        Me.LabelCARACQ.Size = New System.Drawing.Size(0, 13)
        Me.LabelCARACQ.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Código da Posição:"
        '
        'TextBoxCODIGOP
        '
        Me.TextBoxCODIGOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCODIGOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCODIGOP.Location = New System.Drawing.Point(12, 76)
        Me.TextBoxCODIGOP.Name = "TextBoxCODIGOP"
        Me.TextBoxCODIGOP.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxCODIGOP.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(12, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 29)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Digite um codigo para a posição. Exemplo: FN11"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.CodigoPDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PosicoesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(589, 264)
        Me.DataGridView1.TabIndex = 51
        Me.DataGridView1.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 65
        '
        'CodigoPDataGridViewTextBoxColumn
        '
        Me.CodigoPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodigoPDataGridViewTextBoxColumn.DataPropertyName = "CodigoP"
        Me.CodigoPDataGridViewTextBoxColumn.HeaderText = "Código de Posição"
        Me.CodigoPDataGridViewTextBoxColumn.Name = "CodigoPDataGridViewTextBoxColumn"
        Me.CodigoPDataGridViewTextBoxColumn.Width = 130
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.Width = 250
        '
        'PosicoesBindingSource
        '
        Me.PosicoesBindingSource.DataMember = "posicoes"
        Me.PosicoesBindingSource.DataSource = Me.DbgdaDataSet
        '
        'DbgdaDataSet
        '
        Me.DbgdaDataSet.DataSetName = "dbgdaDataSet"
        Me.DbgdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PosicoesTableAdapter
        '
        Me.PosicoesTableAdapter.ClearBeforeFill = True
        '
        'FormCPOSICAO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 381)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxCODIGOP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelCARACQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBoxCDESCRICAO)
        Me.Controls.Add(Me.LabelLOGO)
        Me.Controls.Add(Me.ButtonLISTA)
        Me.Controls.Add(Me.ButtonEXCLUIR)
        Me.Controls.Add(Me.ButtonLIMPAR)
        Me.Controls.Add(Me.ButtonCADASTRAR)
        Me.MaximizeBox = False
        Me.Name = "FormCPOSICAO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Cadastro de Produtos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PosicoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonLISTA As System.Windows.Forms.Button
    Friend WithEvents ButtonEXCLUIR As System.Windows.Forms.Button
    Friend WithEvents ButtonLIMPAR As System.Windows.Forms.Button
    Friend WithEvents ButtonCADASTRAR As System.Windows.Forms.Button
    Friend WithEvents LabelLOGO As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxCDESCRICAO As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelCARACQ As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCODIGOP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DbgdaDataSet As gdeproject.dbgdaDataSet
    Friend WithEvents PosicoesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PosicoesTableAdapter As gdeproject.dbgdaDataSetTableAdapters.posicoesTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
