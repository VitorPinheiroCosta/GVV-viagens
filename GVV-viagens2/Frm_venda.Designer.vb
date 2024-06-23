<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_venda
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
        Me.Btn_BA = New System.Windows.Forms.Button()
        Me.Btn_RJ = New System.Windows.Forms.Button()
        Me.Btn_CE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_BA
        '
        Me.Btn_BA.BackColor = System.Drawing.Color.White
        Me.Btn_BA.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_BA.Image = Global.GVV_viagens.My.Resources.Resources.Paomedia_Small_N_Flat_Basket_32
        Me.Btn_BA.Location = New System.Drawing.Point(642, 333)
        Me.Btn_BA.Name = "Btn_BA"
        Me.Btn_BA.Size = New System.Drawing.Size(64, 46)
        Me.Btn_BA.TabIndex = 3
        Me.Btn_BA.TabStop = False
        Me.Btn_BA.UseVisualStyleBackColor = False
        '
        'Btn_RJ
        '
        Me.Btn_RJ.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_RJ.ForeColor = System.Drawing.Color.White
        Me.Btn_RJ.Image = Global.GVV_viagens.My.Resources.Resources.Paomedia_Small_N_Flat_Basket_32
        Me.Btn_RJ.Location = New System.Drawing.Point(402, 338)
        Me.Btn_RJ.Name = "Btn_RJ"
        Me.Btn_RJ.Size = New System.Drawing.Size(61, 43)
        Me.Btn_RJ.TabIndex = 2
        Me.Btn_RJ.TabStop = False
        Me.Btn_RJ.UseVisualStyleBackColor = False
        '
        'Btn_CE
        '
        Me.Btn_CE.BackColor = System.Drawing.Color.White
        Me.Btn_CE.ForeColor = System.Drawing.Color.White
        Me.Btn_CE.Image = Global.GVV_viagens.My.Resources.Resources.Paomedia_Small_N_Flat_Basket_32
        Me.Btn_CE.Location = New System.Drawing.Point(161, 333)
        Me.Btn_CE.Name = "Btn_CE"
        Me.Btn_CE.Size = New System.Drawing.Size(58, 43)
        Me.Btn_CE.TabIndex = 1
        Me.Btn_CE.TabStop = False
        Me.Btn_CE.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.GVV_viagens.My.Resources.Resources.Teal_and_Yellow_Photographic_Travel_Service_Website1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 434)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Frm_venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 434)
        Me.Controls.Add(Me.Btn_BA)
        Me.Controls.Add(Me.Btn_RJ)
        Me.Controls.Add(Me.Btn_CE)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_venda"
        Me.Text = "VIAGENS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_CE As Button
    Friend WithEvents Btn_RJ As Button
    Friend WithEvents Btn_BA As Button
End Class
