Imports System.Data
Imports System.Data.OleDb

Public Class FormLOGIN
    Public Function ValidarCampos() As Boolean
        If TextBoxUSUARIO.Text = "" Then
            MsgBox("Você tem que colocar o seu usuário.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxSENHA.Text = "" Then
            MsgBox("Você tem que colocar a sua senha.", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function
    Private Sub PLogar()
        Dim file As String = "C:\Users\ANTIVIRUS INFO\Documents\Visual Studio 2010\Projects\gdeproject\gdeproject\BarcodeFont.ttf"
        Dim dr As OleDbDataReader
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM usuarios WHERE usuario=? and senha=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDbParameter("@usuario", TextBoxUSUARIO.Text))
                cmd.Parameters.Add(New OleDbParameter("@senha", TextBoxSENHA.Text))
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    dr.Read()
                    srtUsuario = dr.Item("usuario")
                    srtSenha = dr.Item("senha")
                    srtGrupo = dr.Item("grupo")
                    If My.Settings.Instalada = "Nao" Then
                        If System.IO.File.Exists(file) = True And System.IO.File.Exists("C:\Windows\Fonts\BarcodeFont.tff") = False Then
                            System.IO.File.Copy(file, "C:\Windows\Fonts\")
                        End If
                    End If

                    Me.Hide()
                    FormPRINCIPAL.Show()
                Else
                    MsgBox("Usuário ou senha inválidos.", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ButtonENTRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonENTRAR.Click
        If ValidarCampos() = False Then Exit Sub
        PLogar()
    End Sub

    Private Sub ButtonSAIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSAIR.Click
        intPergunta = MsgBox("Tem certeza que deseja sair do GDA?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If intPergunta <> vbYes Then Exit Sub
        End
    End Sub

    Protected Overrides Sub Finalize()
        Exit Sub
    End Sub
End Class