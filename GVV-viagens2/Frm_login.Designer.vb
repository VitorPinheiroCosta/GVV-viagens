<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_cadastro = New System.Windows.Forms.LinkLabel()
        Me.lbl_esqueci = New System.Windows.Forms.LinkLabel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Btn_entrar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "SENHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "USUÁRIO"
        '
        'lbl_cadastro
        '
        Me.lbl_cadastro.AutoSize = True
        Me.lbl_cadastro.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_cadastro.Location = New System.Drawing.Point(198, 296)
        Me.lbl_cadastro.Name = "lbl_cadastro"
        Me.lbl_cadastro.Size = New System.Drawing.Size(101, 13)
        Me.lbl_cadastro.TabIndex = 19
        Me.lbl_cadastro.TabStop = True
        Me.lbl_cadastro.Text = "Não tenho cadastro"
        '
        'lbl_esqueci
        '
        Me.lbl_esqueci.AutoSize = True
        Me.lbl_esqueci.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_esqueci.Location = New System.Drawing.Point(76, 296)
        Me.lbl_esqueci.Name = "lbl_esqueci"
        Me.lbl_esqueci.Size = New System.Drawing.Size(108, 13)
        Me.lbl_esqueci.TabIndex = 18
        Me.lbl_esqueci.TabStop = True
        Me.lbl_esqueci.Text = "Esqueci minha senha"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(67, 236)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(190, 20)
        Me.txt_senha.TabIndex = 17
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(67, 167)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(190, 20)
        Me.txt_usuario.TabIndex = 16
        '
        'Btn_entrar
        '
        Me.Btn_entrar.BackColor = System.Drawing.Color.Yellow
        Me.Btn_entrar.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_entrar.Location = New System.Drawing.Point(123, 413)
        Me.Btn_entrar.Name = "Btn_entrar"
        Me.Btn_entrar.Size = New System.Drawing.Size(156, 51)
        Me.Btn_entrar.TabIndex = 14
        Me.Btn_entrar.Text = "ENTRAR"
        Me.Btn_entrar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GVV_viagens.My.Resources.Resources._12
        Me.PictureBox2.Location = New System.Drawing.Point(38, 122)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(332, 204)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.GVV_viagens.My.Resources.Resources.Packages
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(810, 514)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(810, 514)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_cadastro)
        Me.Controls.Add(Me.lbl_esqueci)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btn_entrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_login"
        Me.Text = "LOGIN"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_cadastro As LinkLabel
    Friend WithEvents lbl_esqueci As LinkLabel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_entrar As Button
End Class
