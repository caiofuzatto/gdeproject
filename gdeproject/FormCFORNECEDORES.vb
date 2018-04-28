Imports System.Data
Imports System.Data.OleDb

Public Class FormCFORNECEDORES
    Private Lista As String
    Private ValidarSenha As String
    Private EXCLUIDO As String
    Public Function ValidarCampos() As Boolean
        If TextBoxCNOME.Text = "" Then
            MsgBox("Você não colocou o nome do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf MaskedTextBoxTELEFONE.Text = "" Then
            MsgBox("Você não colocou o telefone do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf MaskedTextBoxCCNPJ.Text = "" Then
            MsgBox("Você não colocou o CNPJ do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf MaskedTextBoxCCEP.Text = "" Then
            MsgBox("Você não colocou o CEP do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf MaskedTextBoxTELEFONE.Text = "" Then
            MsgBox("Você não colocou o telefone do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxCENDERECO.Text = "" Then
            MsgBox("Você não colocou o endereço do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxCBAIRRO.Text = "" Then
            MsgBox("Você não colocou o bairro do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxCUF.Text = "" Then
            MsgBox("Você não colocou a UF do fornecedor", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxCCIDADE.Text = "" Then
            MsgBox("Você não colocou o cidade do fornecedor", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub PCadastrar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO fornecedores (Nome,Telefone,CNPJ,Email,CEP,Endereco,Cidade,UF,Bairro) VALUES (?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Nome", TextBoxCNOME.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Telefone", MaskedTextBoxTELEFONE.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CNPJ", MaskedTextBoxCCNPJ.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Email", TextBoxCEMAIL.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CEP", MaskedTextBoxCCEP.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Endereco", TextBoxCENDERECO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Cidade", TextBoxCCIDADE.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@UF", TextBoxCUF.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Bairro", TextBoxCBAIRRO.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Fornecedor cadastrado com sucesso", MsgBoxStyle.Information)
                Limpar()
            Catch ex As Exception
                MsgBox("Erro ao tentar cadastrar o fornecedor. " & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub PExcluir()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "DELETE FROM fornecedores WHERE Codigo=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Codigo", EXCLUIDO))
                cmd.ExecuteNonQuery()
                MsgBox("Fornecedor excluido com sucesso", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Erro ao tentar excluir o fornecedor." & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ListaUsers()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM fornecedores"
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
        MaskedTextBoxTELEFONE.Text = ""
        MaskedTextBoxCCNPJ.Text = ""
        TextBoxCEMAIL.Text = ""
        MaskedTextBoxCCEP.Text = ""
        TextBoxCENDERECO.Text = ""
        TextBoxCBAIRRO.Text = ""
        TextBoxCUF.Text = ""
        TextBoxCCIDADE.Text = ""
        TextBoxCNOME.Focus()
    End Sub
    Private Sub ButtonCADASTRAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCADASTRAR.Click
        If ValidarCampos() = False Then
            Exit Sub
        Else
            PCadastrar()
        End If
    End Sub
    Private Sub ButtonEXCLUIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXCLUIR.Click
        On Error Resume Next
        EXCLUIDO = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        If EXCLUIDO = "Nada" Then
            MsgBox("Selecione um fornecedor!", MsgBoxStyle.Information)
        ElseIf EXCLUIDO <> "" And MsgBox("Tem certeza que deseja excluir esse fornecedor?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = vbYes Then
            PExcluir()
            ListaUsers()
            EXCLUIDO = "Nada"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ButtonLISTA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLISTA.Click
        If Lista = "" Then
            Lista = "ON"
            DataGridView1.Show()
            LabelLOGO.Text = "Lista de Fornecedores"
            ButtonEXCLUIR.Enabled = True
            ButtonCADASTRAR.Enabled = False
            ButtonLIMPAR.Enabled = False
            ListaUsers()
        Else
            Lista = ""
            DataGridView1.Hide()
            ButtonEXCLUIR.Enabled = False
            ButtonCADASTRAR.Enabled = True
            ButtonLIMPAR.Enabled = True
            LabelLOGO.Text = "Cadastro de Fornecedores"
        End If
    End Sub

    Private Sub ButtonLIMPAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLIMPAR.Click
        Dim Pergunta As Integer
        Pergunta = MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If Pergunta = vbYes Then
            Limpar()
        End If
    End Sub


    Private Sub TextBoxCUF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCUF.TextChanged
        If IsNumeric(TextBoxCUF.Text) = True Then
            TextBoxCUF.Text = ""
        End If
    End Sub
End Class