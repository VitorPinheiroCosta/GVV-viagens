Public Class Frm_reclama
    Private Sub Frm_reclama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Frm_reclama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Frm_login.Show()
    End Sub
End Class