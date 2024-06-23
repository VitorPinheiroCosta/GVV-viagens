Public Class cadastrosenhas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sql = "INSERT INTO tb_login (usuario, senha) VALUES ('" & txt_usu_cad.Text & "', '" & txt_usu_csenha.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Usuario Cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÂO")

        Catch ex As Exception
            MsgBox("ERRO" & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
        Frm_cadastro.Show()
    End Sub

    Private Sub cadastrosenhas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()

    End Sub

    Private Sub cadastrosenhas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Frm_cadastro.Show()
    End Sub
End Class