Imports System.Data
Imports System.Data.OleDb

Public Class FormCPOSICAO

    Private Lista As String
    Private ValidarSenha As String
    Private EXCLUIDO As String
    Public Function ValidarCampos() As Boolean
        If RichTextBoxCDESCRICAO.Text = "" Then
            MsgBox("Você não colocou a descrição da posição.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxCODIGOP.Text = "" Then
            MsgBox("Você não colocou o código da posição.", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub PCadastrar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO posicoes (CodigoP,Descricao) VALUES (?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoP", TextBoxCODIGOP.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Descricao", RichTextBoxCDESCRICAO.Text))
                MsgBox("Produto cadastrado com sucesso")
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Erro ao tentar cadastrar a posição. " & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PExcluir()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "DELETE FROM posicoes WHERE Codigo=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Codigo", EXCLUIDO))
                cmd.ExecuteNonQuery()
                MsgBox("Produto excluido com sucesso", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Erro ao tentar excluir a posição. " & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ListaUsers()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM posicoes"
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
            MsgBox("Selecione uma posição!", MsgBoxStyle.Information)
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
            LabelLOGO.Text = "Lista de Posições"
            ButtonCADASTRAR.Enabled = False
            ButtonLIMPAR.Enabled = False
            ListaUsers()
        Else
            Lista = ""
            DataGridView1.Hide()
            ButtonCADASTRAR.Enabled = True
            ButtonLIMPAR.Enabled = True
            LabelLOGO.Text = "Cadastro de Posições"
        End If
    End Sub
    Private Sub Limpar()
        RichTextBoxCDESCRICAO.Text = ""
        TextBoxCODIGOP.Text = ""
        TextBoxCODIGOP.Focus()
    End Sub

    Private Sub ButtonLIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLIMPAR.Click
        Dim Pergunta As Integer
        Pergunta = MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If Pergunta = vbYes Then
            Limpar()
        End If
    End Sub

    Private Sub ButtonVOLTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FormPRINCIPAL.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Caracteres As Integer
        Caracteres = 255 - RichTextBoxCDESCRICAO.TextLength
        If Caracteres >= 1 Then
            LabelCARACQ.Text = Caracteres
            LabelCARACQ.ForeColor = Color.Green
        ElseIf Caracteres = 0 Then
            LabelCARACQ.Text = Caracteres
            LabelCARACQ.ForeColor = Color.Black
        End If
    End Sub

    Private Sub FormCPOSICAO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbgdaDataSet.posicoes' table. You can move, or remove it, as needed.
        Me.PosicoesTableAdapter.Fill(Me.DbgdaDataSet.posicoes)

    End Sub
End Class