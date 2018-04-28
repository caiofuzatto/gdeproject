Imports System.Data
Imports System.Data.OleDb

Public Class FormEXPEDICAO
    Public Function ValidarCampos() As Boolean
        If TextBoxQUANT.Text = "" Then
            MsgBox("Você não colocou a quantidade a ser expedida.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxCliente.Text = "" Then
            MsgBox("Você não colocou o cliente.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxQUANT.Text > TextBoxAQUANT.Text Then
            MsgBox("O estoque não tem isso tudo para expedir. Quantia total do estoque: " & TextBoxAQUANT.Text, MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function



    Private Sub FormEXPEDICAO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxDIA.Text = CDate(Now).ToString("dd")
        TextBoxMES.Text = CDate(Now).ToString("MM")
        TextBoxANO.Text = CDate(Now).ToString("yyyy")
        TextBoxOperador.Text = srtUsuario
    End Sub

    Private Sub PInformacoes()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Produto,Posicao,Quantia,Unit,Total FROM inventario WHERE CodigoBarra='" & TextBoxCODIGO.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    TextBoxPRODUTO.Text = dr.Item("Produto")
                    TextBoxPOSICAO.Text = dr.Item("Posicao")
                    TextBoxAQUANT.Text = dr.Item("Quantia")
                    TextBoxAUNIT.Text = dr.Item("Unit")
                    TextBoxATOTAL.Text = dr.Item("Total")
                    TextBoxCODIGO.Enabled = False
                    ButtonMUDAR.Visible = True
                    PPosicao()
                End If

            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PPosicao()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Descricao FROM posicoes WHERE CodigoP='" & TextBoxPOSICAO.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    RichTextBoxDPOSICAO.Text = dr.Item("Descricao")
                End If

            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PULancar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE inventario SET Quantia=?,Unit=?,Total=? Where CodigoBarra=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim Quant As Integer = Val(TextBoxAQUANT.Text) - Val(TextBoxQUANT.Text)
                Dim Total As Integer = Val(TextBoxPTOTAL.Text) + Val(TextBoxATOTAL.Text)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Produto", TextBoxPRODUTO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Quantia", Quant))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Total", Total))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", TextBoxCODIGO.Text))
                cmd.ExecuteNonQuery()
                PRExpedicao()
                MsgBox("Inventario atualizado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub PRExpedicao()
        Dim DATA As String = TextBoxDIA.Text & "/" & TextBoxMES.Text & "/" & TextBoxANO.Text
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO Rexpedicao (Data, Mes, Ano, Produto, CodigoBarra, Quant, Unit, Posicao, Operador, Cliente) VALUES (?,?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Data", DATA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Mes", TextBoxMES.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Ano", TextBoxANO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Produto", TextBoxPRODUTO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", TextBoxCODIGO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Quantia", TextBoxQUANT.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Unit", TextBoxAUNIT.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Posicao", TextBoxPOSICAO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Operador", TextBoxOperador.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Cliente", TextBoxCliente.Text))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub ButtonVOLTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FormPRINCIPAL.Show()
    End Sub

    Private Sub ButtonLANCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLANCAR.Click
        If ValidarCampos() = False Then
            Exit Sub
        Else
            PULancar()
            Limpar()
        End If
    End Sub

    Private Sub TextBoxQUANT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxQUANT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
        If e.KeyChar = "," And (InStr(TextBoxQUANT.Text, ",")) > 0 Then e.Handled = True
    End Sub



    Private Sub Limpar()
        TextBoxQUANT.Text = ""
        TextBoxPTOTAL.Text = ""
        TextBoxPRODUTO.Text = ""
        TextBoxCODIGO.Text = ""
        TextBoxAQUANT.Text = ""
        TextBoxATOTAL.Text = ""
        TextBoxAUNIT.Text = ""
        TextBoxPOSICAO.Text = ""
        RichTextBoxDPOSICAO.Text = ""
        TextBoxCODIGO.Focus()
    End Sub

    Private Sub ButtonLIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLIMPAR.Click
        Limpar()
    End Sub

    Private Sub TextBoxCODIGO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCODIGO.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCODIGO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCODIGO.Leave
        If TextBoxCODIGO.Text <> "" Then
            PInformacoes()
            If TextBoxQUANT.Text <> "" And TextBoxAUNIT.Text <> "" Then
                TextBoxPTOTAL.Text = Val(TextBoxQUANT.Text) * Val(TextBoxAUNIT.Text)
            End If
        End If
    End Sub

    Private Sub ButtonMUDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMUDAR.Click
        TextBoxCODIGO.Enabled = True
        ButtonMUDAR.Visible = False
        Limpar()
    End Sub
End Class