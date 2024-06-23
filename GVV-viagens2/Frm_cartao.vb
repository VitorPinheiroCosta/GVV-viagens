Public Class Frm_cartao
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sql = " insert into tb_raul values ('" & txt_cpf_cnpj.Text & "', " &
                                                    "'" & txt_nome_port.Text & "', " &
                                                    "'" & txt_datavalid.Text & "', " &
                                                    "'" & txt_numero.Text & "', " &
                                                    "'" & txt_cod.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Cartão Clonado com Sucesso: ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Catch ex As Exception
            Debug.WriteLine("Erro ao gravar: " & ex.Message)
            MsgBox("Erro ao gravar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Frm_cartao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
    End Sub

    Private Sub Frm_cartao_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Frm_venda.Show()
    End Sub
End Class