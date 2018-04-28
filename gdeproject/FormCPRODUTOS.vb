Imports System.Data
Imports System.Data.OleDb

Public Class FormCPRODUTOS
    Private Lista As String
    Private ValidarSenha As String
    Private EXCLUIDO As String

    Private Sub FormCPRODUTOS_Load(ByVal Sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbgdaDataSet.produto' table. You can move, or remove it, as needed.
        Me.ProdutoTableAdapter.Fill(Me.DbgdaDataSet.produto)
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Nome From fornecedores"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)

                ComboBoxCFORNECEDOR.DisplayMember = "Nome"
                ComboBoxCFORNECEDOR.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub


    Public Function ValidarCampos() As Boolean
        If TextBoxCNOME.Text = "" Then
            MsgBox("Você não colocou o nome do produto.", MsgBoxStyle.Information)
            Return False
        ElseIf ComboBoxCFORNECEDOR.Text = "" Then
            MsgBox("Você não colocou o fornecedor do produto.", MsgBoxStyle.Information)
            Return False
        ElseIf RichTextBoxCDESCRICAO.Text = "" Then
            MsgBox("Você não colocou a descrição do produto.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxCBARCODE.Text = "" Then
            MsgBox("Você não colocou o código de barras do produto.", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub PCadastrar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO produto (Nome,Fornecedor,Descricao,CodigoBARRA) VALUES (?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Nome", TextBoxCNOME.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Fornecedor", ComboBoxCFORNECEDOR.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Descricao", RichTextBoxCDESCRICAO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBARRA", TextBoxCBARCODE.Text))
                MsgBox("Produto cadastrado com sucesso", MsgBoxStyle.Information)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Erro ao tentar cadastrar o produto." & ex.Message, MsgBoxStyle.Critical)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PExcluir()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "DELETE FROM produto WHERE Codigo=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Codigo", EXCLUIDO))
                cmd.ExecuteNonQuery()
                MsgBox("Produto excluido com sucesso", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Erro ao tentar excluir o produto." & ex.Message, MsgBoxStyle.Critical)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ListaUsers()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM produto"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cmd.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub Limpar()
        TextBoxCNOME.Text = ""
        ComboBoxCFORNECEDOR.Text = ""
        RichTextBoxCDESCRICAO.Text = ""
        TextBoxCBARCODE.Text = ""
        TextBoxCNOME.Focus()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBoxCBARCODE.Text <> "" Then
            LabelBARCODE.Text = TextBoxCBARCODE.Text
        End If
    End Sub

    Private Sub ButtonCADASTRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCADASTRAR.Click
        If ValidarCampos() = False Then
            Exit Sub
        Else
            PCadastrar()
            Limpar()
        End If
    End Sub

    Private Sub ButtonEXCLUIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXCLUIR.Click
        On Error Resume Next
        EXCLUIDO = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        If EXCLUIDO = "Nada" Then
            MsgBox("Selecione um produto!", MsgBoxStyle.Information)
        ElseIf EXCLUIDO <> "" And MsgBox("Tem certeza que deseja excluir esse fornecedor?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = vbYes Then
            PExcluir()
            ListaUsers()
            EXCLUIDO = "Nada"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ButtonLISTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLISTA.Click
        If Lista = "" Then
            Lista = "ON"
            DataGridView1.Show()
            ButtonCADASTRAR.Enabled = False
            ButtonLIMPAR.Enabled = False
            LabelLOGO.Text = "Lista de Produtos"
            ListaUsers()
        Else
            Lista = ""
            DataGridView1.Hide()
            ButtonCADASTRAR.Enabled = True
            ButtonLIMPAR.Enabled = True
            LabelLOGO.Text = "Cadastro de Produtos"
        End If
    End Sub

    Private Sub ButtonLIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLIMPAR.Click
        Dim Pergunta As Integer
        Pergunta = MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If Pergunta = vbYes Then
            Limpar()
        End If
    End Sub

    Private Sub TextBoxCBARCODE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCBARCODE.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class