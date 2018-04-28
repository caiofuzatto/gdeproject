Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class FormACURACIA
    Dim LSTATUS As String
    Dim cmd As OleDbCommand
    Private paginaAtual As Integer = 1
    Private MyConnection As OleDbConnection
    Private Leitor As OleDbDataReader
    Private RelatorioTitulo As String

    Private Sub ButtonVOLTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVOLTAR.Click
        Me.Hide()
        FormPRINCIPAL.Show()
    End Sub

    Private Sub ButtonIMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIMPRIMIR.Click
        MyConnection = New OleDbConnection(My.Settings.dbgdaConnectionString)
        RelatorioTitulo = "Relatorio de Acurácia - "

        Dim pd As Printing.PrintDocument = New Printing.PrintDocument()

        AddHandler pd.PrintPage, New Printing.PrintPageEventHandler(AddressOf Me.pdRelatorios_PrintPage)
        AddHandler pd.BeginPrint, New Printing.PrintEventHandler(AddressOf Me.Begin_Print)
        AddHandler pd.EndPrint, New Printing.PrintEventHandler(AddressOf Me.End_Print)

        Dim objPrintPreview As New PrintPreviewDialog

        Try
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Relacao de Clientes"
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Begin_Print(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)

        Dim Sql As String = "SELECT * from lista"
        Dim MyComand As New OleDbCommand(Sql, MyConnection)

        MyConnection.Open()
        Leitor = MyComand.ExecuteReader()
        paginaAtual = 1

    End Sub

    Private Sub pdRelatorios_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim LinhasPorPagina As Single = 0
        Dim PosicaoDaLinha As Single = 0
        Dim LinhaAtual As Integer = 0

        Dim MargemEsquerda As Single = e.MarginBounds.Left
        Dim MargemSuperior As Single = e.MarginBounds.Top + 100
        Dim MargemDireita As Single = e.MarginBounds.Right
        Dim MargemInferior As Single = e.MarginBounds.Bottom
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)
        Dim codigo As Integer
        Dim produto As String
        Dim barra As String
        Dim contagem As String
        Dim total As String
        Dim acuracia As String

        Dim FonteNegrito As Font
        Dim FonteTitulo As Font
        Dim FonteSubTitulo As Font
        Dim FonteRodape As Font
        Dim FonteNormal As Font

        FonteNegrito = New Font("Arial", 9, FontStyle.Bold)
        FonteTitulo = New Font("Arial", 15, FontStyle.Bold)
        FonteSubTitulo = New Font("Arial", 12, FontStyle.Bold)
        FonteRodape = New Font("Arial", 8)
        FonteNormal = New Font("Arial", 9)

        LinhaAtual = 0
        Dim L As Integer = 0

        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)
        e.Graphics.DrawString("GDA System", FonteTitulo, Brushes.Blue, MargemEsquerda + 210, 80, New StringFormat())
        e.Graphics.DrawString(RelatorioTitulo & System.DateTime.Today, FonteSubTitulo, Brushes.Black, MargemEsquerda + 150, 120, New StringFormat())

        e.Graphics.DrawString("Cod.", FonteNegrito, Brushes.Black, MargemEsquerda, 170, New StringFormat())
        e.Graphics.DrawString("Produto", FonteNegrito, Brushes.Black, MargemEsquerda + 40, 170, New StringFormat())
        e.Graphics.DrawString("Código de Barra", FonteNegrito, Brushes.Black, MargemEsquerda + 220, 170, New StringFormat())
        e.Graphics.DrawString("Contagem", FonteNegrito, Brushes.Black, MargemEsquerda + 350, 170, New StringFormat())
        e.Graphics.DrawString("Total de Itens", FonteNegrito, Brushes.Black, MargemEsquerda + 420, 170, New StringFormat())
        e.Graphics.DrawString("Acuracia", FonteNegrito, Brushes.Black, MargemEsquerda + 520, 170, New StringFormat())
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)

        LinhasPorPagina = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

        While (LinhaAtual < LinhasPorPagina AndAlso Leitor.Read())
            codigo = Leitor.GetInt32(0)
            produto = Leitor.GetString(1)
            barra = Leitor.GetString(2)
            contagem = Leitor.GetString(3)
            total = Leitor.GetString(4)
            acuracia = Leitor.GetString(5)
            PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
            e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, MargemEsquerda, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(produto.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 40, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(barra.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 220, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(contagem.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 350, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(total.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 420, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(acuracia.ToString, FonteNormal, Brushes.Black, MargemEsquerda + 520, PosicaoDaLinha, New StringFormat())
            LinhaAtual += 1
        End While
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
        e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())
        LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
        LinhaAtual += 1
        e.Graphics.DrawString("P gina : " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())
        paginaAtual += 1
        If (LinhaAtual > LinhasPorPagina) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub End_Print(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        Leitor.Close()
        MyConnection.Close()
    End Sub

    Private Sub FormACURACIA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.ListaTableAdapter.FillBy(Me.DbgdaDataSet.lista)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        LVERIFICAR()
        If LSTATUS = "Aberta" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub ButtonFINALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFINALIZAR.Click
        Dim PERGUNTA As String
        PERGUNTA = MsgBox("Tem certeza que deseja finalizar a contagem? Isso excluira a lista permanentemente dos registros.", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation)
        If PERGUNTA = vbOK Then
            CFINALIZAR()
            LFINALIZAR()
            Try
                Me.ListaTableAdapter.FillBy(Me.DbgdaDataSet.lista)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CFINALIZAR()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "DELETE FROM lista WHERE Código <> 0"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub LFINALIZAR()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE variaveis SET Valor='Não' WHERE Variavel='ListaGerada'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
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

    Private Sub LABRIR()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE variaveis SET Valor='Aberta' WHERE Variavel='ListaStatus'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub LFECHAR()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE variaveis SET Valor='Fechada' WHERE Variavel='ListaStatus'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            LABRIR()
        Else
            LFECHAR()
        End If
    End Sub
End Class