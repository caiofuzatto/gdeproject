Imports System.Data
Imports System.Data.OleDb

Public Class FormCONTAGEM
    Dim Produto As String
    Dim CodigoBarra As String
    Dim Quantia As String
    Dim Produto2 As String
    Dim ListaGerada As String
    Dim LSTATUS As String
    Dim LTotal As Integer
    Private Sub GerandoP()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT TOP " & LTotal & " Produto,CodigoBarra FROM inventario ORDER BY Rnd(Código)"
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

    Public Function ValidarCampos() As Boolean
        If TextBox1.Text = "" Then
            MsgBox("Você não colocou a quantidade do produto.", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub ProcurarQuantia()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Quantia FROM inventario WHERE CodigoBARRA='" & CodigoBarra & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    Quantia = dr.Item("Quantia")
                End If
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ColocarNoBD()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO lista (Produto, CodigoBarra, QuantiaContada, Quantia, Acuracia) VALUES (?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Produto", Produto))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", CodigoBarra))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@QuantiaContada", "-"))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Quantia", Quantia))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Acuracia", "0"))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ColocarNoDG()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Produto,CodigoBarra,QuantiaContada FROM lista"
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

    Private Sub ColocarNaTabela()
        Dim L As Integer
        L = 0
        Do While DataGridView1.Rows(L).Cells(0).Value <> Nothing
            Produto = DataGridView1.Rows(L).Cells(0).Value.ToString()
            CodigoBarra = DataGridView1.Rows(L).Cells(1).Value.ToString()
            ProcurarQuantia()
            ColocarNoBD()
            L = Val(L) + 1
        Loop
        Exit Sub
    End Sub

    Private Sub ContagemDeLinhas()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM inventario"
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
        LTotal = 0
        Dim L As Integer
        L = 0
        Do While DataGridView1.Rows(L).Cells(0).Value <> Nothing
            LTotal = LTotal + 1
            L = Val(L) + 1
        Loop
        LTotal = LTotal * 0.7
        Exit Sub
    End Sub

    Private Sub Gerada()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Valor FROM variaveis WHERE Variavel='ListaGerada'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    ListaGerada = dr.Item("Valor")
                End If
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PegarQuantia()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Quantia FROM lista WHERE CodigoBarra='" & Produto2 & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", Produto2))
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    Quantia = dr.Item("Quantia")
                End If
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ColocarVariavelLG()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE variaveis SET Valor=? WHERE Variavel='ListaGerada'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Valor", "Sim"))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ButtonGERARLISTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGERARLISTA.Click
        ContagemDeLinhas()
        ProgressBar1.Value = 5
        GerandoP()
        ProgressBar1.Value = 10
        ColocarNaTabela()
        ProgressBar1.Value = 40
        ColocarVariavelLG()
        ProgressBar1.Value = 50
        ColocarNoDG()
        ProgressBar1.Value = 80
        TextBox1.Enabled = True
        Button1.Enabled = True
        ProgressBar1.Value = 80
        ButtonGERARLISTA.Enabled = False
        ProgressBar1.Value = 100
    End Sub

    Private Sub LancarValor()
        Dim Acuracia As Integer
        Acuracia = (TextBox1.Text / Quantia) * 100

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE lista SET QuantiaContada=?,Acuracia=? WHERE CodigoBarra=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@QuantiaContada", TextBox1.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Acuracia", Acuracia & "%"))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CodigoBarra", Produto2))
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub LVERIFICAR()
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Valor FROM variaveis WHERE Variavel='ListaStatus'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    LSTATUS = dr.Item("Valor")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Rows As Integer
        Rows = DataGridView1.CurrentRow.Index
        On Error Resume Next
        Produto2 = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        If Produto2 = "Nada" Then
            MsgBox("Selecione um produto!", MsgBoxStyle.Information)
        ElseIf Produto2 <> "" Then
            LVERIFICAR()
            If LSTATUS = "Aberta" Then
                Dim Continuando As Integer
                If ValidarCampos() = False Then
                    Exit Sub
                Else
                    Continuando = MsgBox("Tem certeza que deseja inserir esses dados?" & Produto2 & ": " & TextBox1.Text, MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation)
                    If Continuando = vbOK Then
                        PegarQuantia()
                        LancarValor()
                        ColocarNoDG()
                        DataGridView1.CurrentCell = DataGridView1.Item(2, Rows + 1)
                        TextBox1.Focus()
                        Continuando = Nothing
                    Else
                        Continuando = Nothing
                    End If
                End If
            Else
                MsgBox("Erro ao tentar atualizar a contagem. A contagem esta fechada.", MsgBoxStyle.Critical)
            End If
            Produto2 = "Nada"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub



    Private Sub FormCONTAGEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbgdaDataSet.lista' table. You can move, or remove it, as needed.
        Me.ListaTableAdapter.Fill(Me.DbgdaDataSet.lista)
        Gerada()
        If ListaGerada = "Sim" Then
            ColocarNoDG()
            ProgressBar1.Value = 50
            ProgressBar1.Value = 80
            TextBox1.Enabled = True
            Button1.Enabled = True
            ProgressBar1.Value = 100
            DataGridView1.CurrentCell = DataGridView1.Item(2, 0)
            ButtonGERARLISTA.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim Rows As Integer
        Rows = DataGridView1.CurrentRow.Index
        DataGridView1.CurrentCell = DataGridView1.Item(2, Rows)
        TextBox1.Focus()
    End Sub

    Protected Overrides Sub Finalize()
        System.Windows.Forms.Application.Exit()
    End Sub
End Class