Public Class Frm_painel_adm
    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        Try
            Frm_gerenciar_cadastro.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem1.Click
        Try
            Frm_cadastro.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class