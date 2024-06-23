Public Class Frm_venda


    Private Sub Frm_venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_acess()
    End Sub

    Private Sub Btn_BA_Click(sender As Object, e As EventArgs) Handles Btn_BA.Click
        Try
            resp = MsgBox("Deseja Confirmar sua viagem para Bahia-BA por 881,00?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                Me.Hide()
                Frm_cartao.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_RJ_Click(sender As Object, e As EventArgs) Handles Btn_RJ.Click
        resp = MsgBox("Deseja Confirmar sua viagem para Rio de Janeiro- RJ por 427,00?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Hide()
            Frm_cartao.Show()
        End If
    End Sub

    Private Sub Btn_CE_Click(sender As Object, e As EventArgs) Handles Btn_CE.Click
        resp = MsgBox("Deseja Confirmar sua viagem para Ceara-CE por 1020,00?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Hide()
            Frm_cartao.Show()
        End If
    End Sub

    Private Sub Frm_venda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Frm_login.Show()
    End Sub
End Class