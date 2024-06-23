Public Class Frm_cadastro
    Private Sub IMG_FOTO_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO DO CLIENTE"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conecta_banco_acess()
            carregar_dados()
            carregar_tipo()
        Catch ex As Exception
            MsgBox("Banco de dados conectado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs)
        Try
            sql = "select from * tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome.Text = rs.Fields(0).Value
                cmb_data_nasc.Text = rs.Fields(2).Value
                txt_cep.Text = rs.Fields(3).Value
                txt_endereco.Text = rs.Fields(4).Value
                txt_bairro.Text = rs.Fields(5).Value
                txt_uf.Text = rs.Fields(6).Value
                txt_cel.Text = rs.Fields(7).Value
                txt_email.Text = rs.Fields(9).Value
            Else
                txt_nome.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            sql = "SELECT * FROM tb_cadastro WHERE cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                sql = "INSERT INTO tb_cadastro (nome, cpf, data_nasc, cep, endereço, bairro, cidade, uf, cel, email, img_foto) " &
                  "VALUES ('" & txt_nome.Text & "', " &
                          "'" & txt_cpf.Text & "', " &
                          "'" & cmb_data_nasc.Value.Date.ToString("yyyy-MM-dd") & "', " &
                          "'" & txt_cep.Text & "', " &
                          "'" & txt_endereco.Text & "', " &
                          "'" & txt_bairro.Text & "', " &
                          "'" & txt_cidade.Text & "', " &
                          "'" & txt_uf.Text & "', " &
                          "'" & txt_cel.Text & "', " &
                          "'" & txt_email.Text & "', " &
                          "'" & img_foto.ImageLocation & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro()
                carregar_dados()
            Else
                Dim updateFields As String = ""

                If rs.Fields("nome").Value.ToString() <> txt_nome.Text Then
                    updateFields &= "nome = '" & txt_nome.Text & "', "
                End If
                If rs.Fields("data_nasc").Value.ToString("yyyy-MM-dd") <> cmb_data_nasc.Value.Date.ToString("yyyy-MM-dd") Then
                    updateFields &= "data_nasc = '" & cmb_data_nasc.Value.Date.ToString("yyyy-MM-dd") & "', "
                End If
                If rs.Fields("cep").Value.ToString() <> txt_cep.Text Then
                    updateFields &= "cep = '" & txt_cep.Text & "', "
                End If
                If rs.Fields("endereco").Value.ToString() <> txt_endereco.Text Then
                    updateFields &= "endereco = '" & txt_endereco.Text & "', "
                End If
                If rs.Fields("bairro").Value.ToString() <> txt_bairro.Text Then
                    updateFields &= "bairro = '" & txt_bairro.Text & "', "
                End If
                If rs.Fields("cidade").Value.ToString() <> txt_cidade.Text Then
                    updateFields &= "cidade = '" & txt_cidade.Text & "', "
                End If
                If rs.Fields("uf").Value.ToString() <> txt_uf.Text Then
                    updateFields &= "uf = '" & txt_uf.Text & "', "
                End If
                If rs.Fields("cel").Value.ToString() <> txt_cel.Text Then
                    updateFields &= "cel = '" & txt_cel.Text & "', "
                End If
                If rs.Fields("email").Value.ToString() <> txt_email.Text Then
                    updateFields &= "email = '" & txt_email.Text & "', "
                End If
                If rs.Fields("img_foto").Value.ToString() <> img_foto.ImageLocation Then
                    updateFields &= "img_foto = '" & img_foto.ImageLocation & "', "
                End If

                If updateFields <> "" Then
                    updateFields = updateFields.Substring(0, updateFields.Length - 2)
                End If

                If updateFields <> "" Then
                    sql = "UPDATE tb_cadastro SET " & updateFields & " WHERE cpf = '" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    MsgBox("Nenhuma alteração foi detectada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
            carregar_dados()
        Catch ex As Exception
            Debug.WriteLine("Erro ao gravar: " & ex.Message)
            MsgBox("Erro ao gravar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub BTN_CSENHA_Click(sender As Object, e As EventArgs) Handles BTN_CSENHA.Click
        Me.Hide()
        cadastrosenhas.Show()
    End Sub

    Private Sub Frm_cadastro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        Frm_login.Show()
    End Sub
    Private Sub txt_cadast_cep_Leave(sender As Object, e As EventArgs) Handles txt_cep.Leave
        sql = "select * from tb_cep where CEP='" & txt_cep.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_cidade.Text = rs.Fields(2).Value
            txt_endereco.Text = rs.Fields(1).Value
            txt_bairro.Text = rs.Fields(3).Value
            txt_uf.Text = rs.Fields(4).Value
        End If
    End Sub
End Class