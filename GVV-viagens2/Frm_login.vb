Public Class Frm_login
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
    End Sub
    Private Sub Btn_entrar_Click_1(sender As Object, e As EventArgs) Handles Btn_entrar.Click
        login_usuario = txt_usuario.Text
        login_senha = txt_senha.Text

        Try
            If login_usuario = "usuario" Or login_senha = "senha" Or login_usuario = "" Or login_senha = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_usuario.Text = "GUSTAVO" And txt_senha.Text = "LINDO" Then
                Me.Hide()
                Frm_painel_adm.Show()
                txt_usuario.Clear()
                txt_senha.Clear()
            Else
                sql = "select status_conta from tb_login where usuario = '" & login_usuario & "'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    MsgBox("Usuário não encontrado", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    sql = "select * from tb_login where usuario = '" & login_usuario & "' and senha= '" & login_senha & "'"
                    rs = db.Execute(sql)
                    MsgBox("Usuário logado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Me.Hide()
                    Frm_venda.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao tentar fazer login" & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO") ' debug
        End Try
    End Sub

    Private Sub Frm_login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Frm_BV.Show()
    End Sub

    Private Sub lbl_esqueci_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_esqueci.LinkClicked
        Me.Hide()
        Frm_redefinir.Show()
    End Sub

    Private Sub lbl_cadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_cadastro.LinkClicked
        Me.Hide()
        Frm_cadastro.Show()
    End Sub
End Class