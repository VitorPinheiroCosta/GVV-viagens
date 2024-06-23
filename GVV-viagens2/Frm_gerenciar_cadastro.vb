Public Class Frm_gerenciar_cadastro
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
        carregar_dados()
        carregar_tipo()
    End Sub
    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            With dgv_contas
                cont = 1
                sql = "select * from tb_cadastro where " & cmb_tipo.Text & " like  '%" & txt_busca.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao buscar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AENÇÃO")
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conecta_banco_acess()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick

        Try
            With dgv_contas
                If .CurrentRow.Cells(11).Selected = True Then
                    Me.Hide()
                    Frm_cadastro.txt_nome.Text = .CurrentRow.Cells("Nome").Value.ToString()
                    Frm_cadastro.txt_cpf.Text = .CurrentRow.Cells("CPF").Value.ToString()
                    Frm_cadastro.txt_bairro.Text = .CurrentRow.Cells("BAIRRO").Value.ToString()
                    Frm_cadastro.txt_cep.Text = .CurrentRow.Cells("CEP").Value.ToString()
                    Frm_cadastro.cmb_data_nasc.Value = .CurrentRow.Cells("DATANASC").Value.ToString()
                    Frm_cadastro.txt_cel.Text = .CurrentRow.Cells("CEL").Value.ToString()
                    Frm_cadastro.txt_cidade.Text = .CurrentRow.Cells("CIDADE").Value.ToString()
                    Frm_cadastro.txt_endereco.Text = .CurrentRow.Cells("ENDERECO").Value.ToString()
                    Frm_cadastro.txt_email.Text = .CurrentRow.Cells("EMAIL").Value.ToString()
                    Frm_cadastro.txt_uf.Text = .CurrentRow.Cells("UF").Value.ToString()
                    Frm_cadastro.Show()

                ElseIf .CurrentRow.Cells(12).Selected = True Then
                    aux_usuario = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                  "cpf: " & aux_usuario & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_cadastro where cpf='" & aux_usuario & "'"
                        rs = db.Execute(sql)
                    End If
                Else
                    Exit Sub
                End If
                carregar_dados()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class