Public Class Frm_redefinir
    Private Sub Btn_criar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_redefinir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()

    End Sub

    Private Sub Btn_criar_Click_1(sender As Object, e As EventArgs) Handles Btn_criar.Click
        Try
            If txt_nome_usuario.Text = "" Or
                txt_senha_usuario.Text = "" Or
                txt_rsenha_usuario.Text = "" Then
                MsgBox("Preencha todos os campos!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txt_senha_usuario.Text <> txt_rsenha_usuario.Text Then
                MsgBox("As senhas devem ser iguais", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "select * from tb_login where usuario = '" & txt_nome_usuario.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "Update tb_login SET senha = '" & txt_senha_usuario.Text & "' WHERE usuario = '" & txt_nome_usuario.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("SENHA REDIFINIDA COM SUCESSO", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                End If

                '  gerar_id()
                ' sql = "insert into tb_login values (" & id_conta & ", '" & txt_nome_usuario.Text & "'," &
                '                                 "'" & txt_email_usuario.Text & "', " &
                '                                "'" & txt_senha_usuario.Text & "', 'ATIVA')"
                '   rs = db.Execute(sql)
                ' MsgBox("conta criada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                ' txt_nome_usuario.Clear()
                'txt_rsenha_usuario.Clear()
                'txt_senha_usuario.Clear()
                'txt_nome_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao criar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO") 'msg de erro
        End Try
        Frm_login.Show()
    End Sub

    Private Sub check_visualizar_CheckedChanged_1(sender As Object, e As EventArgs) Handles check_visualizar.CheckedChanged
        If txt_senha_usuario.PasswordChar = "*" Or
            txt_rsenha_usuario.PasswordChar = "*" Then
            txt_senha_usuario.PasswordChar = ""
            txt_rsenha_usuario.PasswordChar = ""
        Else
            txt_senha_usuario.PasswordChar = "*"
            txt_rsenha_usuario.PasswordChar = "*"
        End If
    End Sub

    Private Sub Frm_redefinir_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        Frm_login.Show()
    End Sub
End Class