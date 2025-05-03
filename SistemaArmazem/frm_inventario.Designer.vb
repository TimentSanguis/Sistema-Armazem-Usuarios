<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_inventario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.cmb_chegada = New System.Windows.Forms.DateTimePicker()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.cmb_validade = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_quantidade = New System.Windows.Forms.MaskedTextBox()
        Me.img_produto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(32, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Preço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data chegada"
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome.Location = New System.Drawing.Point(31, 96)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(98, 20)
        Me.txt_nome.TabIndex = 5
        '
        'cmb_chegada
        '
        Me.cmb_chegada.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmb_chegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_chegada.Location = New System.Drawing.Point(36, 297)
        Me.cmb_chegada.Name = "cmb_chegada"
        Me.cmb_chegada.Size = New System.Drawing.Size(98, 20)
        Me.cmb_chegada.TabIndex = 9
        '
        'btn_salvar
        '
        Me.btn_salvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_salvar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.Location = New System.Drawing.Point(122, 349)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(84, 27)
        Me.btn_salvar.TabIndex = 10
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'cmb_validade
        '
        Me.cmb_validade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_validade.Location = New System.Drawing.Point(191, 297)
        Me.cmb_validade.Name = "cmb_validade"
        Me.cmb_validade.Size = New System.Drawing.Size(98, 20)
        Me.cmb_validade.TabIndex = 11
        Me.cmb_validade.Value = New Date(2025, 4, 13, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(187, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Data validade"
        '
        'txt_quantidade
        '
        Me.txt_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_quantidade.Location = New System.Drawing.Point(31, 238)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantidade.TabIndex = 13
        Me.txt_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'img_produto
        '
        Me.img_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_produto.Image = CType(resources.GetObject("img_produto.Image"), System.Drawing.Image)
        Me.img_produto.InitialImage = CType(resources.GetObject("img_produto.InitialImage"), System.Drawing.Image)
        Me.img_produto.Location = New System.Drawing.Point(181, 73)
        Me.img_produto.Name = "img_produto"
        Me.img_produto.Size = New System.Drawing.Size(144, 157)
        Me.img_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_produto.TabIndex = 16
        Me.img_produto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_preco
        '
        Me.txt_preco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_preco.Location = New System.Drawing.Point(29, 173)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(100, 20)
        Me.txt_preco.TabIndex = 18
        Me.txt_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Novo Produto"
        '
        'frm_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.img_produto)
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_validade)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.cmb_chegada)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventário"
        Me.TopMost = True
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents cmb_validade As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_quantidade As MaskedTextBox
    Friend WithEvents cmb_chegada As DateTimePicker
    Friend WithEvents img_produto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Label6 As Label
End Class
