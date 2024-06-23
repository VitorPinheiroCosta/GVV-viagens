Module Module1
    Public diretorio As String
    Public db As New ADODB.Connection 'variável do banco de dados
    Public rs As New ADODB.Recordset    'varivel da tabela
    Public sql, aux_cpf, resp, id_conta, aux_usuario, login_usuario, login_senha As String 'variavel de querys (crud) (gravar, exluir, aleterar, consultar)
    Public TXT_CPF, TXT_NOME, TXT_EMAIL, TXT_CEP, cmb_data_nasc, TXT_ENDERECO, TXT_BAIRRO, TXT_CIDADE, TXT_UF, TXT_TEL, TXT_CEL As TextBox
    Public IMG_FOTO As PictureBox
    Public cont As Integer
    Public banco_acess = Application.StartupPath & "\Banco_Dados\cadastro.mdb"

    Sub conecta_banco_acess()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider = Microsoft.JET.OLEDB.4.0;Data Source=" & banco_acess)
            MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
        Catch ex As Exception
            MsgBox("Erro ao conectar" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            Debug.Print("Erro ao conectar: " & ex.Message)
        End Try
    End Sub
    Sub carregar_tipo()
        Try
            With Frm_gerenciar_cadastro.cmb_tipo.Items
                .Add("CPF")
                .Add("NOME")
            End With
            Frm_gerenciar_cadastro.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            With Frm_gerenciar_cadastro.dgv_contas
                cont = 1
                sql = "select * from tb_cadastro order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(8).Value, rs.Fields(9).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()

                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    'Sub conectar_banco()
    'Try 'tentar
    'db = CreateObject("ADODB.Connection") 'Cnectando banco de dados(padrão)
    'db.Open("Provider=SQLOLEDB; Data source=DESKTOP-O87VKEB;inital catalog=atividade_ads_gvv;trusted_connection=yes;")
    'MsgBox("Conexão com sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO") 'msg de conexão
    'Catch ex As Exception
    ' MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO") 'msg de erro
    'End Try
    'End Sub

    Sub limpar_cadastro()
        With Frm_cadastro
            .txt_nome.Clear()
            .txt_cpf.Clear()
            .txt_cep.Clear()
            .cmb_data_nasc.Value = Now
            .txt_endereco.Clear()
            .txt_cidade.Clear()
            .txt_bairro.Clear()
            .txt_cel.Clear()
            .txt_uf.Clear()
            .txt_email.Clear()
            .img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
            .txt_cpf.Focus()
        End With
    End Sub

    Sub gerar_id()
        sql = "select * from tb_login order by id_conta desc "
        rs = db.Execute(sql)
        If rs.BOF = True Then ' se a tabela não conter nenhum registro
            id_conta = 1
        Else
            id_conta = rs.Fields(0).Value + 1
        End If
    End Sub
End Module
