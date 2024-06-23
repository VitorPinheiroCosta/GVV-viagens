Public Class Frm_BV
    Private Sub Btn_acessar_Click(sender As Object, e As EventArgs) Handles Btn_acessar.Click
        Frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Frm_reclama.Show()
    End Sub
End Class
