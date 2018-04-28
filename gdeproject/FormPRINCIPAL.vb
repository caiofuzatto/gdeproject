Public Class FormPRINCIPAL
    Private Sub FormPRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelUser.Text = srtUsuario
    End Sub

    Private Sub CadastrarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarUsuarioToolStripMenuItem.Click
        If srtGrupo = "Administrador" Then
            FormCADASTRO.Show()
        Else
            MsgBox("Você não tem permissão para cadastrar usuarios.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem.Click
        FormCFORNECEDORES.Show()
    End Sub

    Private Sub EquipamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipamentosToolStripMenuItem.Click
        FormCPRODUTOS.Show()
    End Sub

    Private Sub PosiçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PosiçõesToolStripMenuItem.Click
        FormCPOSICAO.Show()
    End Sub

    Private Sub EntradaMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaMToolStripMenuItem.Click
        FormENTRADA.Show()
    End Sub

    Private Sub ExpedicaoMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpedicaoMToolStripMenuItem.Click
        FormEXPEDICAO.Show()
    End Sub

    Private Sub EspedicaoRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspedicaoRToolStripMenuItem.Click
        Relatorio = "Expedição"
        FormRELATORIO.Show()
    End Sub

    Private Sub EntradaRToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaRToolStripMenuItem1.Click
        Relatorio = "Entrada"
        FormRELATORIO.Show()
    End Sub

    Private Sub GerarListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerarListaToolStripMenuItem.Click
        FormCONTAGEM.Show()
    End Sub

    Private Sub RelatDeAcuráciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatDeAcuráciaToolStripMenuItem.Click
        If srtGrupo = "Administrador" Then
            FormACURACIA.Show()
        Else
            MsgBox("Você não tem permissão para ver o relatorio de acurácia.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub FormPRINCIPAL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Tem certeza que deseja deixar o sistema?", vbYesNo + vbQuestion, "Sair") = vbYes Then
            System.Windows.Forms.Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

End Class