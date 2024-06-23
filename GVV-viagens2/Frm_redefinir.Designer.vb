<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_redefinir
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
        Me.check_visualizar = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_rsenha_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha_usuario = New System.Windows.Forms.TextBox()
        Me.txt_nome_usuario = New System.Windows.Forms.TextBox()
        Me.Btn_criar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'check_visualizar
        '
        Me.check_visualizar.AutoSize = True
        Me.check_visualizar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.check_visualizar.Location = New System.Drawing.Point(449, 232)
        Me.check_visualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.check_visualizar.Name = "check_visualizar"
        Me.check_visualizar.Size = New System.Drawing.Size(82, 20)
        Me.check_visualizar.TabIndex = 34
        Me.check_visualizar.Text = "Visualizar"
        Me.check_visualizar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(84, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "DIGITE SEU USUÁRIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Location = New System.Drawing.Point(269, 211)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "REPETIR SENHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(87, 210)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "SENHA"
        '
        'txt_rsenha_usuario
        '
        Me.txt_rsenha_usuario.Location = New System.Drawing.Point(267, 230)
        Me.txt_rsenha_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rsenha_usuario.Name = "txt_rsenha_usuario"
        Me.txt_rsenha_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_rsenha_usuario.Size = New System.Drawing.Size(162, 21)
        Me.txt_rsenha_usuario.TabIndex = 29
        '
        'txt_senha_usuario
        '
        Me.txt_senha_usuario.Location = New System.Drawing.Point(87, 230)
        Me.txt_senha_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha_usuario.Name = "txt_senha_usuario"
        Me.txt_senha_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_usuario.Size = New System.Drawing.Size(162, 21)
        Me.txt_senha_usuario.TabIndex = 28
        '
        'txt_nome_usuario
        '
        Me.txt_nome_usuario.Location = New System.Drawing.Point(87, 173)
        Me.txt_nome_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nome_usuario.Name = "txt_nome_usuario"
        Me.txt_nome_usuario.Size = New System.Drawing.Size(242, 21)
        Me.txt_nome_usuario.TabIndex = 26
        '
        'Btn_criar
        '
        Me.Btn_criar.BackColor = System.Drawing.Color.Yellow
        Me.Btn_criar.Location = New System.Drawing.Point(87, 299)
        Me.Btn_criar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_criar.Name = "Btn_criar"
        Me.Btn_criar.Size = New System.Drawing.Size(172, 47)
        Me.Btn_criar.TabIndex = 24
        Me.Btn_criar.Text = "REDEFINIR"
        Me.Btn_criar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GVV_viagens.My.Resources.Resources._12
        Me.PictureBox2.Location = New System.Drawing.Point(59, 61)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(499, 323)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.GVV_viagens.My.Resources.Resources.Bora_Bora_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(690, 433)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Frm_redefinir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(690, 433)
        Me.Controls.Add(Me.check_visualizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_rsenha_usuario)
        Me.Controls.Add(Me.txt_senha_usuario)
        Me.Controls.Add(Me.txt_nome_usuario)
        Me.Controls.Add(Me.Btn_criar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_redefinir"
        Me.Text = "REDEFINIR SENHA"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents check_visualizar As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_rsenha_usuario As TextBox
    Friend WithEvents txt_senha_usuario As TextBox
    Friend WithEvents txt_nome_usuario As TextBox
    Friend WithEvents Btn_criar As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
