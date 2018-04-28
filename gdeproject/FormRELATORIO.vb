Imports System.Data
Imports System.Data.OleDb
Public Class FormRELATORIO

    Private Sub FormRELATORIO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Relatorio = "Expedição" Then
            LabelLOGO.Text = "Relatorio de Expedição"
            ProcurarEXT()
            RadioButtonEX.Checked = True
        ElseIf Relatorio = "Entrada" Then
            LabelLOGO.Text = "Relatorio de Entrada"
            ProcurarENT()
            RadioButtonEN.Checked = True
        End If
    End Sub

    Private Sub ProcurarEX()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Data,Produto,CodigoBarra,Quant,Unit,Posicao FROM Rexpedicao WHERE Mes=? and Ano=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Mes", ComboBox2.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Ano", ComboBox1.Text))

                da.Fill(dt)
                DataGridView1.DataSource = dt
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ProcurarEN()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Data,Produto,CodigoBarra,Quant,Unit,Posicao,NF FROM Rentrada WHERE Mes=? and Ano=?"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Mes", ComboBox2.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Ano", ComboBox1.Text))

                da.Fill(dt)
                DataGridView1.DataSource = dt
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ProcurarEXT()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Data,Produto,CodigoBarra,Quant,Unit,Posicao FROM Rexpedicao"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ProcurarENT()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Data,Produto,CodigoBarra,Quant,Unit,Posicao,NF FROM Rentrada"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ButtonPROCURAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPROCURAR.Click
        If Relatorio = "Expedição" Then
            ProcurarEX()
        ElseIf Relatorio = "Entrada" Then
            ProcurarEN()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox2.Enabled = True
            ComboBox1.Enabled = True
        Else
            ComboBox2.Enabled = False
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButtonEN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonEN.CheckedChanged
        LabelLOGO.Text = "Relatorio de Entrada"
        ProcurarENT()
    End Sub

    Private Sub RadioButtonEX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonEX.CheckedChanged
        LabelLOGO.Text = "Relatorio de Expedição"
        ProcurarEXT()
    End Sub
End Class