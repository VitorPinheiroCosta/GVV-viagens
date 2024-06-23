<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_gerenciar_cadastro
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.Tab_cadastro = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATANASC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAIRRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENDERECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMGFOTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EDITAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EXCLUIR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BUSCA = New System.Windows.Forms.ToolStripLabel()
        Me.TIPO = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.Tab_cadastro.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BUSCA, Me.txt_busca, Me.TIPO, Me.cmb_tipo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1334, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(100, 25)
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 25)
        '
        'Tab_cadastro
        '
        Me.Tab_cadastro.Controls.Add(Me.TabPage2)
        Me.Tab_cadastro.Location = New System.Drawing.Point(0, 40)
        Me.Tab_cadastro.Name = "Tab_cadastro"
        Me.Tab_cadastro.SelectedIndex = 0
        Me.Tab_cadastro.Size = New System.Drawing.Size(1340, 481)
        Me.Tab_cadastro.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_contas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1332, 455)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_contas
        '
        Me.dgv_contas.AllowUserToAddRows = False
        Me.dgv_contas.AllowUserToDeleteRows = False
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.CPF, Me.Nome, Me.DATANASC, Me.CEP, Me.BAIRRO, Me.CIDADE, Me.UF, Me.ENDERECO, Me.CEL, Me.EMAIL, Me.EDITAR, Me.EXCLUIR, Me.IMGFOTO})
        Me.dgv_contas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_contas.Location = New System.Drawing.Point(3, 3)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.ReadOnly = True
        Me.dgv_contas.Size = New System.Drawing.Size(1326, 449)
        Me.dgv_contas.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'DATANASC
        '
        Me.DATANASC.HeaderText = "DATA DE NASCIMENTO"
        Me.DATANASC.Name = "DATANASC"
        Me.DATANASC.ReadOnly = True
        '
        'CEP
        '
        Me.CEP.HeaderText = "CEP"
        Me.CEP.Name = "CEP"
        Me.CEP.ReadOnly = True
        '
        'BAIRRO
        '
        Me.BAIRRO.HeaderText = "BAIRRO"
        Me.BAIRRO.Name = "BAIRRO"
        Me.BAIRRO.ReadOnly = True
        '
        'CIDADE
        '
        Me.CIDADE.HeaderText = "CIDADE"
        Me.CIDADE.Name = "CIDADE"
        Me.CIDADE.ReadOnly = True
        '
        'UF
        '
        Me.UF.HeaderText = "UF"
        Me.UF.Name = "UF"
        Me.UF.ReadOnly = True
        '
        'ENDERECO
        '
        Me.ENDERECO.HeaderText = "ENDEREÇO"
        Me.ENDERECO.Name = "ENDERECO"
        Me.ENDERECO.ReadOnly = True
        '
        'CEL
        '
        Me.CEL.HeaderText = "CELULAR"
        Me.CEL.Name = "CEL"
        Me.CEL.ReadOnly = True
        '
        'EMAIL
        '
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'IMGFOTO
        '
        Me.IMGFOTO.HeaderText = "IMAGEM"
        Me.IMGFOTO.Name = "IMGFOTO"
        Me.IMGFOTO.ReadOnly = True
        Me.IMGFOTO.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn1.Image = Global.GVV_viagens.My.Resources.Resources.editar
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "EXCLUIR"
        Me.DataGridViewImageColumn2.Image = Global.GVV_viagens.My.Resources.Resources.deletar
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 59
        '
        'EDITAR
        '
        Me.EDITAR.HeaderText = "EDITAR"
        Me.EDITAR.Image = Global.GVV_viagens.My.Resources.Resources.editar
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.ReadOnly = True
        '
        'EXCLUIR
        '
        Me.EXCLUIR.HeaderText = "EXCLUIR"
        Me.EXCLUIR.Image = Global.GVV_viagens.My.Resources.Resources.deletar
        Me.EXCLUIR.Name = "EXCLUIR"
        Me.EXCLUIR.ReadOnly = True
        Me.EXCLUIR.Width = 59
        '
        'BUSCA
        '
        Me.BUSCA.Image = Global.GVV_viagens.My.Resources.Resources.consultar
        Me.BUSCA.Name = "BUSCA"
        Me.BUSCA.Size = New System.Drawing.Size(60, 22)
        Me.BUSCA.Text = "BUSCA"
        '
        'TIPO
        '
        Me.TIPO.Image = Global.GVV_viagens.My.Resources.Resources.consultar
        Me.TIPO.Name = "TIPO"
        Me.TIPO.Size = New System.Drawing.Size(48, 22)
        Me.TIPO.Text = "TIPO"
        '
        'Frm_gerenciar_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 533)
        Me.Controls.Add(Me.Tab_cadastro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_gerenciar_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERENCIAR USUÁRIOS"
        Me.TopMost = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Tab_cadastro.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Tab_cadastro As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BUSCA As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents TIPO As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents dgv_contas As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents DATANASC As DataGridViewTextBoxColumn
    Friend WithEvents CEP As DataGridViewTextBoxColumn
    Friend WithEvents BAIRRO As DataGridViewTextBoxColumn
    Friend WithEvents CIDADE As DataGridViewTextBoxColumn
    Friend WithEvents UF As DataGridViewTextBoxColumn
    Friend WithEvents ENDERECO As DataGridViewTextBoxColumn
    Friend WithEvents CEL As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents EDITAR As DataGridViewImageColumn
    Friend WithEvents EXCLUIR As DataGridViewImageColumn
    Friend WithEvents IMGFOTO As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class
