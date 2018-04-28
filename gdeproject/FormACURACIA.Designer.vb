<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormACURACIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormACURACIA))
        Me.ButtonFINALIZAR = New System.Windows.Forms.Button()
        Me.LabelLOGO = New System.Windows.Forms.Label()
        Me.ButtonVOLTAR = New System.Windows.Forms.Button()
        Me.ButtonIMPRIMIR = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DbgdaDataSet = New gdeproject.dbgdaDataSet()
        Me.ListaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaTableAdapter = New gdeproject.dbgdaDataSetTableAdapters.listaTableAdapter()
        Me.TableAdapterManager = New gdeproject.dbgdaDataSetTableAdapters.TableAdapterManager()
        Me.ListaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonFINALIZAR
        '
        Me.ButtonFINALIZAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonFINALIZAR.Location = New System.Drawing.Point(253, 317)
        Me.ButtonFINALIZAR.Name = "ButtonFINALIZAR"
        Me.ButtonFINALIZAR.Size = New System.Drawing.Size(105, 52)
        Me.ButtonFINALIZAR.TabIndex = 43
        Me.ButtonFINALIZAR.Text = "Finalizar Contagem"
        Me.ButtonFINALIZAR.UseVisualStyleBackColor = True
        '
        'LabelLOGO
        '
        Me.LabelLOGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGO.Location = New System.Drawing.Point(188, 9)
        Me.LabelLOGO.Name = "LabelLOGO"
        Me.LabelLOGO.Size = New System.Drawing.Size(245, 25)
        Me.LabelLOGO.TabIndex = 40
        Me.LabelLOGO.Text = "Relatorio de Acurácia"
        Me.LabelLOGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonVOLTAR
        '
        Me.ButtonVOLTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonVOLTAR.Location = New System.Drawing.Point(485, 317)
        Me.ButtonVOLTAR.Name = "ButtonVOLTAR"
        Me.ButtonVOLTAR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonVOLTAR.TabIndex = 42
        Me.ButtonVOLTAR.Text = "Voltar"
        Me.ButtonVOLTAR.UseVisualStyleBackColor = True
        '
        'ButtonIMPRIMIR
        '
        Me.ButtonIMPRIMIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonIMPRIMIR.Location = New System.Drawing.Point(364, 317)
        Me.ButtonIMPRIMIR.Name = "ButtonIMPRIMIR"
        Me.ButtonIMPRIMIR.Size = New System.Drawing.Size(115, 52)
        Me.ButtonIMPRIMIR.TabIndex = 41
        Me.ButtonIMPRIMIR.Text = "Imprimir Relatorio"
        Me.ButtonIMPRIMIR.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(60, 325)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Contagem Aberta"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(59, 346)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton2.TabIndex = 46
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Contagem Fechada"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DbgdaDataSet
        '
        Me.DbgdaDataSet.DataSetName = "dbgdaDataSet"
        Me.DbgdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaBindingSource
        '
        Me.ListaBindingSource.DataMember = "lista"
        Me.ListaBindingSource.DataSource = Me.DbgdaDataSet
        '
        'ListaTableAdapter
        '
        Me.ListaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.fornecedoresTableAdapter = Nothing
        Me.TableAdapterManager.inventarioTableAdapter = Nothing
        Me.TableAdapterManager.listaTableAdapter = Me.ListaTableAdapter
        Me.TableAdapterManager.posicoesTableAdapter = Nothing
        Me.TableAdapterManager.produtoTableAdapter = Nothing
        Me.TableAdapterManager.RentradaTableAdapter = Nothing
        Me.TableAdapterManager.RexpedicaoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = gdeproject.dbgdaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.variaveisTableAdapter = Nothing
        '
        'ListaDataGridView
        '
        Me.ListaDataGridView.AutoGenerateColumns = False
        Me.ListaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ListaDataGridView.DataSource = Me.ListaBindingSource
        Me.ListaDataGridView.Location = New System.Drawing.Point(12, 37)
        Me.ListaDataGridView.Name = "ListaDataGridView"
        Me.ListaDataGridView.Size = New System.Drawing.Size(596, 274)
        Me.ListaDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Produto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CodigoBarra"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código de Barra"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "QuantiaContada"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contagem"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantia Real"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 95
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Acuracia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Acurácia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 55
        '
        'FormACURACIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 389)
        Me.Controls.Add(Me.ListaDataGridView)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ButtonFINALIZAR)
        Me.Controls.Add(Me.LabelLOGO)
        Me.Controls.Add(Me.ButtonVOLTAR)
        Me.Controls.Add(Me.ButtonIMPRIMIR)
        Me.MaximizeBox = False
        Me.Name = "FormACURACIA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestão de Almoxarifados >> Relatorio de Acuracia"
        CType(Me.DbgdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonFINALIZAR As System.Windows.Forms.Button
    Friend WithEvents LabelLOGO As System.Windows.Forms.Label
    Friend WithEvents ButtonVOLTAR As System.Windows.Forms.Button
    Friend WithEvents ButtonIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DbgdaDataSet As gdeproject.dbgdaDataSet
    Friend WithEvents ListaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTableAdapter As gdeproject.dbgdaDataSetTableAdapters.listaTableAdapter
    Friend WithEvents TableAdapterManager As gdeproject.dbgdaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
