<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCONTAGEM
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
        Me.ListaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbgdaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbgdaDataSet = New gdeproject.dbgdaDataSet()
        Me.ButtonGERARLISTA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioTableAdapter = New gdeproject.dbgdaDataSetTableAdapters.inventarioTableAdapter()
        Me.ListaTableAdapter = New gdeproject.dbgdaDataSetTableAdapters.listaTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantiaContadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbgdaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaBindingSource
        '
        Me.ListaBindingSource.DataMember = "lista"
        Me.ListaBindingSource.DataSource = Me.DbgdaDataSetBindingSource
        '
        'DbgdaDataSetBindingSource
        '
        Me.DbgdaDataSetBindingSource.DataSource = Me.DbgdaDataSet
        Me.DbgdaDataSetBindingSource.Position = 0
        '
        'DbgdaDataSet
        '
        Me.DbgdaDataSet.DataSetName = "dbgdaDataSet"
        Me.DbgdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonGERARLISTA
        '
        Me.ButtonGERARLISTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonGERARLISTA.Location = New System.Drawing.Point(485, 318)
        Me.ButtonGERARLISTA.Name = "ButtonGERARLISTA"
        Me.ButtonGERARLISTA.Size = New System.Drawing.Size(115, 52)
        Me.ButtonGERARLISTA.TabIndex = 57
        Me.ButtonGERARLISTA.Text = "Gerar Lista"
        Me.ButtonGERARLISTA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Contagem de Inventario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 289)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(589, 23)
        Me.ProgressBar1.TabIndex = 62
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "inventario"
        Me.InventarioBindingSource.DataSource = Me.DbgdaDataSetBindingSource
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'ListaTableAdapter
        '
        Me.ListaTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(38, 328)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 29)
        Me.TextBox1.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(278, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 32)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Lançar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListaBindingSource1
        '
        Me.ListaBindingSource1.DataMember = "lista"
        Me.ListaBindingSource1.DataSource = Me.DbgdaDataSet
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdutoDataGridViewTextBoxColumn, Me.CodigoBarraDataGridViewTextBoxColumn, Me.QuantiaContadaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ListaBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(589, 246)
        Me.DataGridView1.TabIndex = 63
        '
        'ProdutoDataGridViewTextBoxColumn
        '
        Me.ProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProdutoDataGridViewTextBoxColumn.DataPropertyName = "Produto"
        Me.ProdutoDataGridViewTextBoxColumn.HeaderText = "Produto"
        Me.ProdutoDataGridViewTextBoxColumn.Name = "ProdutoDataGridViewTextBoxColumn"
        Me.ProdutoDataGridViewTextBoxColumn.Width = 70
        '
        'CodigoBarraDataGridViewTextBoxColumn
        '
        Me.CodigoBarraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodigoBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarra"
        Me.CodigoBarraDataGridViewTextBoxColumn.HeaderText = "Código de Barra"
        Me.CodigoBarraDataGridViewTextBoxColumn.Name = "CodigoBarraDataGridViewTextBoxColumn"
        Me.CodigoBarraDataGridViewTextBoxColumn.Width = 180
        '
        'QuantiaContadaDataGridViewTextBoxColumn
        '
        Me.QuantiaContadaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.QuantiaContadaDataGridViewTextBoxColumn.DataPropertyName = "QuantiaContada"
        Me.QuantiaContadaDataGridViewTextBoxColumn.HeaderText = "Contagem"
        Me.QuantiaContadaDataGridViewTextBoxColumn.Name = "QuantiaContadaDataGridViewTextBoxColumn"
        Me.QuantiaContadaDataGridViewTextBoxColumn.Width = 80
        '
        'ListaBindingSource2
        '
        Me.ListaBindingSource2.DataMember = "lista"
        Me.ListaBindingSource2.DataSource = Me.DbgdaDataSet
        '
        'FormCONTAGEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 381)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonGERARLISTA)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FormCONTAGEM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Contagem de Inventario"
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbgdaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonGERARLISTA As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DbgdaDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbgdaDataSet As gdeproject.dbgdaDataSet
    Friend WithEvents InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioTableAdapter As gdeproject.dbgdaDataSetTableAdapters.inventarioTableAdapter
    Friend WithEvents ListaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTableAdapter As gdeproject.dbgdaDataSetTableAdapters.listaTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ListaBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantiaContadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
