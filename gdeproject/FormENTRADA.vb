Imports System.Data
Imports System.Data.OleDb

Public Class FormENTRADA

    Private Codigo As Integer
    Private Sub FormENTRADA_Load(ByVal Sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxDIA.Text = CDate(Now).ToString("dd")
        TextBoxMES.Text = CDate(Now).ToString("MM")
        TextBoxANO.Text = CDate(Now).ToString("yyyy")
    End Sub

    Public ProdFornBar As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBoxQUANT.Text <> "" And TextBoxPUNIT.Text <> "" Then
            TextBoxPTOTAL.Text = TextBoxQUANT.Text * TextBoxPUNIT.Text
        End If
        If ComboBoxCODIGOP.Text <> "" Then
            PDescricao()
        End If
    End Sub
    Public Function ValidarCampos() As Boolean
        If TextBoxCODIGO.Text = "" Then
            MsgBox("Você não colocou codigo de barra do produto.", MsgBoxStyle.Information)
            Return False
        ElseIf ComboBoxCODIGOP.Text = "" Then
            MsgBox("Você não colocou o código da posição do produto.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxQUANT.Text = "" Then
            MsgBox("Você não colocou a quantidade de unidades do produto.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxPUNIT.Text = "" Then
            MsgBox("Você não colocou o preço do produto.", MsgBoxStyle.Information)
            Return False
        ElseIf TextBoxNF.Text = "" Then
            MsgBox("Você não colocou a nota fiscal do produto.", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub PULancar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE inventario SET Posicao=?,Quantia=?,Unit=?,Total=? Where CodigoBarra=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim Quant As Integer = Val(TextBoxQUANT.Text) + Val(TextBoxAQUANT.Text)
                Dim Total As Integer = Val(TextBoxPTOTAL.Text) + Val(TextBoxAPTOTAL.Text)
                Dim Unit As String = Total / Quant

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Posicao", ComboBoxCODIGOP.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Quantia", Quant))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Unit", Unit))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Total", Total))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", TextBoxCODIGO.Text))
                cmd.ExecuteNonQuery()
                PRentrada()
                MsgBox("Inventario atualizado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PILancar()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO inventario (Produto, CodigoBarra, Posicao, Quantia, Unit, Total) VALUES (?, ?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Produto", ProdFornBar))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", TextBoxCODIGO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Posicao", ComboBoxCODIGOP.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Quantia", TextBoxQUANT.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Unit", TextBoxPUNIT.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Total", TextBoxPTOTAL.Text))
                cmd.ExecuteNonQuery()
                PRentrada()
                MsgBox("Produto registrado no inventario", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub PRentrada()
        Dim DATA As String = TextBoxDIA.Text & "/" & TextBoxMES.Text & "/" & TextBoxANO.Text
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO Rentrada (Data, Mes, Ano, Produto, CodigoBarra, Quant, Unit, Posicao, NF) VALUES (?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Data", DATA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Mes", TextBoxMES.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Ano", TextBoxANO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Produto", ProdFornBar))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", TextBoxCODIGO.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Quantia", TextBoxQUANT.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Unit", TextBoxPUNIT.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Posicao", ComboBoxCODIGOP.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@NF", TextBoxNF.Text))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub FormCPRODUTOS_Load(ByVal Sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT CodigoP From posicoes"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)

                ComboBoxCODIGOP.DisplayMember = "CodigoP"
                ComboBoxCODIGOP.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PInformacoes()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Nome,Fornecedor FROM produto WHERE CodigoBARRA='" & TextBoxCODIGO.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    TextBoxPRODUTO.Text = dr.Item("Nome")
                    TextBoxFORNECEDOR.Text = dr.Item("Fornecedor")
                    TextBoxCODIGO.Enabled = False
                    ButtonMUDAR.Visible = True
                    ProdFornBar = (dr.Item("Nome") & "/" & dr.Item("Fornecedor"))
                    PINFOAtual()
                End If

            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Public Jatem As Boolean
    Private Sub PINFOAtual()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Quantia,Unit,Total FROM inventario WHERE CodigoBarra='" & TextBoxCODIGO.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    TextBoxAQUANT.Text = dr.Item("Quantia")
                    TextBoxAPUNIT.Text = dr.Item("Unit")
                    TextBoxAPTOTAL.Text = dr.Item("Total")
                    Jatem = True
                Else
                    TextBoxAQUANT.Text = 0
                    TextBoxAPUNIT.Text = 0
                    TextBoxAPTOTAL.Text = 0
                    Jatem = False
                End If

            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub PDescricao()
        Dim dri As OleDbDataReader = Nothing
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sqli As String = "SELECT descricao FROM posicoes WHERE CodigoP='" & ComboBoxCODIGOP.Text & "'"
                Dim cmdi As OleDbCommand = New OleDbCommand(sqli, con)

                dri = cmdi.ExecuteReader(CommandBehavior.SingleRow)

                If dri.HasRows Then
                    dri.Read()
                    RichTextBoxDPOSICAO.Text = dri.Item("descricao")
                End If

            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ButtonVOLTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FormPRINCIPAL.Show()
    End Sub

    Private Sub ButtonMUDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMUDAR.Click
        TextBoxCODIGO.Text = ""
        TextBoxFORNECEDOR.Text = ""
        TextBoxPRODUTO.Text = ""
        TextBoxCODIGO.Focus()
        TextBoxCODIGO.Enabled = True
        ButtonMUDAR.Visible = False
    End Sub

    Private Sub ButtonLANCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLANCAR.Click
        If ValidarCampos() = False Then
            Exit Sub
        Else
            If Jatem = False Then
                PILancar()
                Limpar()
            Else
                PULancar()
                Limpar()
            End If
        End If
    End Sub

    Private Sub Limpar()
        TextBoxCODIGO.Text = ""
        TextBoxFORNECEDOR.Text = ""
        TextBoxPRODUTO.Text = ""
        TextBoxAPTOTAL.Text = ""
        TextBoxAPUNIT.Text = ""
        TextBoxNF.Text = ""
        TextBoxAQUANT.Text = ""
        TextBoxPUNIT.Text = ""
        TextBoxPTOTAL.Text = ""
        TextBoxQUANT.Text = ""
        TextBoxCODIGO.Focus()
        TextBoxCODIGO.Enabled = True
        ButtonMUDAR.Visible = False
    End Sub

    Private Sub ButtonLIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLIMPAR.Click
        Limpar()
    End Sub

    Private Sub TextBoxCODIGO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCODIGO.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxQUANT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxQUANT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
        If e.KeyChar = "," And (InStr(TextBoxQUANT.Text, ",")) > 0 Then e.Handled = True
    End Sub

    Private Sub TextBoxPUNIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPUNIT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
        If e.KeyChar = "," And (InStr(TextBoxQUANT.Text, ",")) > 0 Then e.Handled = True
    End Sub

    Private Sub TextBoxCODIGO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCODIGO.Leave
        If TextBoxCODIGO.Text <> "" Then
            PInformacoes()
            PINFOAtual()
        End If
    End Sub


End Class