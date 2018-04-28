Imports System.Data
Imports System.Data.OleDb

Public Class FormCADASTRO
    Private Lista As String
    Private ValidarSenha As String
    Private EXCLUIDO As String
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If TextBoxSENHA1.Text <> TextBoxSENHA2.Text And TextBoxSENHA1.Text <> "" Then
            TextBoxSENHA1.BackColor = Color.Red
            TextBoxSENHA2.BackColor = Color.Red
            Label1.Text = "As senhas não correspodem."
            ValidarSenha = "No1"
        ElseIf TextBoxSENHA1.Text = "" Then
            TextBoxSENHA1.BackColor = Color.Red
            TextBoxSENHA2.BackColor = Color.Red
            Label1.Text = "Digite uma senha!"
            ValidarSenha = "No2"
        Else
            TextBoxSENHA1.BackColor = Color.White
            TextBoxSENHA2.BackColor = Color.White
            Label1.Text = ""
            ValidarSenha = "OK"
        End If
    End Sub
    Public Function ValidarCampos() As Boolean
        If TextBoxUSUARIOC.Text = "" Then
            MsgBox("Você não colocou o usuário", MsgBoxStyle.Information)
            Return False
        ElseIf ComboBoxGRUPOC.Text = "" Then
            MsgBox("Você não colocou o grupo do usuário", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxUSUARIO.Text = "" Then
            MsgBox("Você não colocou seu usuário!", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxSENHA.Text = "" Then
            MsgBox("Você não colocou sua senha!", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxSENHA.Text <> srtSenha Or TextBoxUSUARIO.Text <> srtUsuario Then
            MsgBox("Usuário ou senha inválidos.", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub PCadastrar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO usuarios (usuario,senha,grupo) VALUES (?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@usuario", TextBoxUSUARIOC.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@senha", TextBoxSENHA2.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@grupo", ComboBoxGRUPOC.Text))
                MsgBox("Usuário cadastrado com sucesso", MsgBoxStyle.Information)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Erro ao tentar cadastrar o usuário." & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PEditar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE usuarios SET usuario=?,senha=?,grupo=? WHERE Codigo=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@usuario", TextBoxUSUARIOC.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@senha", TextBoxSENHA2.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@grupo", ComboBoxGRUPOC.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Codigo", EXCLUIDO))
                cmd.ExecuteNonQuery()
                MsgBox("Usuário editado com sucesso!", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Erro ao tentar editar o usuário." & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PExcluir()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "DELETE FROM usuarios WHERE Codigo=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Codigo", EXCLUIDO))
                cmd.ExecuteNonQuery()
                MsgBox("Usuário excluído com sucesso", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao tentar excluir o usuário." & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ListaUsers()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM usuarios"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao tentar excluir o usuário." & ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ButtonVOLTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FormPRINCIPAL.Show()
    End Sub

    Private Sub ButtonCADASTRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCADASTRAR.Click
        If ValidarCampos() = False Then
            Exit Sub
        ElseIf ValidarSenha = "No1" Then
            MsgBox("As senhas não correspodem.", MsgBoxStyle.Information)
        ElseIf ValidarSenha = "No2" Then
            MsgBox("Digite uma senha!", MsgBoxStyle.Information)
        Else
            PCadastrar()
            Limpar()
        End If
    End Sub

    Private Sub Limpar()
        TextBoxSENHA.Text = ""
        TextBoxSENHA1.Text = ""
        TextBoxSENHA2.Text = ""
        TextBoxUSUARIO.Text = ""
        TextBoxUSUARIOC.Text = ""
        ComboBoxGRUPOC.Text = ""
        TextBoxUSUARIOC.Focus()
    End Sub

    Private Sub ButtonLIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLIMPAR.Click
        Dim Pergunta As Integer
        Pergunta = MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If Pergunta = vbYes Then
            Limpar()
        End If
    End Sub
    Private Sub ButtonEXCLUIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXCLUIR.Click
        On Error Resume Next
        EXCLUIDO = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        If EXCLUIDO = "Nada" Then
            MsgBox("Selecione um usuário!", MsgBoxStyle.Information)
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
            LabelLogo.Text = "Lista de Usuários"
            ButtonCADASTRAR.Enabled = False
            ButtonLIMPAR.Enabled = False
            ButtonEXCLUIR.Enabled = True
            ButtonEDITAR.Enabled = True
            ListaUsers()
        Else
            Lista = ""
            DataGridView1.Hide()
            ButtonCADASTRAR.Enabled = True
            ButtonLIMPAR.Enabled = True
            ButtonEXCLUIR.Enabled = False
            ButtonEDITAR.Enabled = False
            LabelLogo.Text = "Cadastro de Usuários"
        End If
    End Sub

    Private Sub ButtonEDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEDITAR.Click
        On Error Resume Next
        EXCLUIDO = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        If EXCLUIDO = "Nada" Then
            MsgBox("Selecione um usuário!", MsgBoxStyle.Information)
        ElseIf EXCLUIDO <> "" And MsgBox("Tem certeza que deseja editar esse usuário?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = vbYes Then
            If ValidarCampos() = False Then
                Exit Sub
            ElseIf ValidarSenha = "No1" Then
                MsgBox("As senhas não correspodem.", MsgBoxStyle.Information)
            ElseIf ValidarSenha = "No2" Then
                MsgBox("Digite uma senha!", MsgBoxStyle.Information)
            Else
                PEditar()
                Limpar()
                ListaUsers()
                EXCLUIDO = "Nada"
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub FormCADASTRO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbgdaDataSet.usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.DbgdaDataSet.usuarios)

    End Sub
End Class