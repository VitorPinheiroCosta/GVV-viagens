<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cadastro))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cadastro = New System.Windows.Forms.TabControl()
        Me.Tab_cadastro_cliente = New System.Windows.Forms.TabPage()
        Me.BTN_CSENHA = New System.Windows.Forms.Button()
        Me.txt_cel = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_cadastrar = New System.Windows.Forms.ToolStripButton()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cadastro.SuspendLayout()
        Me.Tab_cadastro_cliente.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cadastro
        '
        Me.cadastro.Controls.Add(Me.Tab_cadastro_cliente)
        Me.cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadastro.Location = New System.Drawing.Point(-7, -23)
        Me.cadastro.Name = "cadastro"
        Me.cadastro.SelectedIndex = 0
        Me.cadastro.Size = New System.Drawing.Size(452, 457)
        Me.cadastro.TabIndex = 0
        Me.cadastro.TabStop = False
        '
        'Tab_cadastro_cliente
        '
        Me.Tab_cadastro_cliente.BackColor = System.Drawing.Color.Bisque
        Me.Tab_cadastro_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab_cadastro_cliente.Controls.Add(Me.BTN_CSENHA)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_cel)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label10)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label9)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label8)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label7)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label6)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label5)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label4)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_cep)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label2)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label1)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_cpf)
        Me.Tab_cadastro_cliente.Controls.Add(Me.Label3)
        Me.Tab_cadastro_cliente.Controls.Add(Me.ToolStrip1)
        Me.Tab_cadastro_cliente.Controls.Add(Me.img_foto)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_email)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_uf)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_cidade)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_bairro)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_endereco)
        Me.Tab_cadastro_cliente.Controls.Add(Me.cmb_data_nasc)
        Me.Tab_cadastro_cliente.Controls.Add(Me.txt_nome)
        Me.Tab_cadastro_cliente.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_cadastro_cliente.ForeColor = System.Drawing.Color.Black
        Me.Tab_cadastro_cliente.Location = New System.Drawing.Point(4, 22)
        Me.Tab_cadastro_cliente.Name = "Tab_cadastro_cliente"
        Me.Tab_cadastro_cliente.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_cadastro_cliente.Size = New System.Drawing.Size(444, 431)
        Me.Tab_cadastro_cliente.TabIndex = 0
        '
        'BTN_CSENHA
        '
        Me.BTN_CSENHA.Location = New System.Drawing.Point(269, 391)
        Me.BTN_CSENHA.Name = "BTN_CSENHA"
        Me.BTN_CSENHA.Size = New System.Drawing.Size(149, 23)
        Me.BTN_CSENHA.TabIndex = 28
        Me.BTN_CSENHA.Text = "Cadastrar Senha"
        Me.BTN_CSENHA.UseVisualStyleBackColor = True
        '
        'txt_cel
        '
        Me.txt_cel.Location = New System.Drawing.Point(37, 348)
        Me.txt_cel.Mask = "(99)99999-9999"
        Me.txt_cel.Name = "txt_cel"
        Me.txt_cel.Size = New System.Drawing.Size(127, 21)
        Me.txt_cel.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(184, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "E-MAIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "CELULAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(279, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "UF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "CIDADE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "BAIRRO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "ENDEREÇO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CEP"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(171, 181)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(56, 21)
        Me.txt_cep.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NOME"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(31, 120)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(106, 21)
        Me.txt_cpf.TabIndex = 16
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "DATA NASC"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_cadastrar, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(434, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "GVV - VIAGENS"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_cadastrar.Image = CType(resources.GetObject("btn_cadastrar.Image"), System.Drawing.Image)
        Me.btn_cadastrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(23, 22)
        Me.btn_cadastrar.Text = "ToolStripButton1"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.Silver
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_foto.Image = Global.GVV_viagens.My.Resources.Resources.nova_foto
        Me.img_foto.InitialImage = CType(resources.GetObject("img_foto.InitialImage"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(294, 52)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(124, 133)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 11
        Me.img_foto.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(182, 348)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(236, 21)
        Me.txt_email.TabIndex = 10
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(279, 290)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(52, 21)
        Me.txt_uf.TabIndex = 7
        Me.txt_uf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(274, 240)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(144, 21)
        Me.txt_cidade.TabIndex = 6
        Me.txt_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(32, 290)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(222, 21)
        Me.txt_bairro.TabIndex = 5
        Me.txt_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(32, 240)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(222, 21)
        Me.txt_endereco.TabIndex = 4
        Me.txt_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Location = New System.Drawing.Point(37, 180)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(92, 21)
        Me.cmb_data_nasc.TabIndex = 2
        Me.cmb_data_nasc.Value = New Date(2024, 5, 2, 0, 0, 0, 0)
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(31, 71)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(215, 21)
        Me.txt_nome.TabIndex = 0
        Me.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GVV_viagens.My.Resources.Resources.Bora_Bora_
        Me.PictureBox2.Location = New System.Drawing.Point(439, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(269, 228)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GVV_viagens.My.Resources.Resources._112767_destinos_paradisiacos_conheca_os_mais_incriveis_do_mundo
        Me.PictureBox1.Location = New System.Drawing.Point(439, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(23, 22)
        Me.btn_gravar.Text = "ToolStripButton1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(291, 22)
        Me.ToolStripLabel2.Text = "Para concluir o cadastro click no botão a esquerda"
        '
        'Frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 429)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_cadastro"
        Me.Text = "CADASTRO"
        Me.cadastro.ResumeLayout(False)
        Me.Tab_cadastro_cliente.ResumeLayout(False)
        Me.Tab_cadastro_cliente.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cadastro As TabControl
    Friend WithEvents Tab_cadastro_cliente As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents btn_cadastrar As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cel As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BTN_CSENHA As Button
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
