<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuarios))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.label_tipo = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisa = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_novoUser = New System.Windows.Forms.Button()
        Me.Dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel2, Me.ToolStripSeparator1, Me.label_tipo, Me.cmb_campo, Me.ToolStripLabel1, Me.txt_pesquisa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(833, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "Buscar produto"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel2.Text = "Buscar Produtos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'label_tipo
        '
        Me.label_tipo.Name = "label_tipo"
        Me.label_tipo.Size = New System.Drawing.Size(31, 22)
        Me.label_tipo.Text = "Tipo"
        '
        'cmb_campo
        '
        Me.cmb_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel1.Text = "Identificador"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(100, 25)
        '
        'btn_novoUser
        '
        Me.btn_novoUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_novoUser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_novoUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_novoUser.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novoUser.Image = CType(resources.GetObject("btn_novoUser.Image"), System.Drawing.Image)
        Me.btn_novoUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_novoUser.Location = New System.Drawing.Point(0, 23)
        Me.btn_novoUser.Name = "btn_novoUser"
        Me.btn_novoUser.Size = New System.Drawing.Size(846, 51)
        Me.btn_novoUser.TabIndex = 4
        Me.btn_novoUser.Text = "Adicionar Usuario"
        Me.btn_novoUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_novoUser.UseVisualStyleBackColor = False
        '
        'Dgv_usuarios
        '
        Me.Dgv_usuarios.AllowUserToAddRows = False
        Me.Dgv_usuarios.AllowUserToDeleteRows = False
        Me.Dgv_usuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dgv_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgv_usuarios.ColumnHeadersHeight = 30
        Me.Dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column9, Me.Column7})
        Me.Dgv_usuarios.GridColor = System.Drawing.SystemColors.Control
        Me.Dgv_usuarios.Location = New System.Drawing.Point(0, 71)
        Me.Dgv_usuarios.Name = "Dgv_usuarios"
        Me.Dgv_usuarios.RowTemplate.Height = 40
        Me.Dgv_usuarios.Size = New System.Drawing.Size(846, 381)
        Me.Dgv_usuarios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "E-mail"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 180
        '
        'Column4
        '
        Me.Column4.HeaderText = "Senha"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.HeaderText = "Foto"
        Me.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "Editar"
        Me.Column8.Image = CType(resources.GetObject("Column8.Image"), System.Drawing.Image)
        Me.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "Excluir"
        Me.Column9.Image = CType(resources.GetObject("Column9.Image"), System.Drawing.Image)
        Me.Column9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "Bloquear"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 50
        '
        'usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 450)
        Me.Controls.Add(Me.btn_novoUser)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Dgv_usuarios)
        Me.Name = "usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "usuarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents label_tipo As ToolStripLabel
    Friend WithEvents cmb_campo As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisa As ToolStripTextBox
    Friend WithEvents btn_novoUser As Button
    Friend WithEvents Dgv_usuarios As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
