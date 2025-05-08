<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.txt_nomeUser = New System.Windows.Forms.TextBox()
        Me.txt_senhaUser = New System.Windows.Forms.TextBox()
        Me.txt_emailUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_tipoU = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.img_usuario = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.img_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nomeUser
        '
        Me.txt_nomeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nomeUser.Location = New System.Drawing.Point(29, 92)
        Me.txt_nomeUser.Name = "txt_nomeUser"
        Me.txt_nomeUser.Size = New System.Drawing.Size(120, 20)
        Me.txt_nomeUser.TabIndex = 0
        '
        'txt_senhaUser
        '
        Me.txt_senhaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senhaUser.Location = New System.Drawing.Point(28, 158)
        Me.txt_senhaUser.Name = "txt_senhaUser"
        Me.txt_senhaUser.Size = New System.Drawing.Size(121, 20)
        Me.txt_senhaUser.TabIndex = 1
        '
        'txt_emailUser
        '
        Me.txt_emailUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_emailUser.Location = New System.Drawing.Point(28, 217)
        Me.txt_emailUser.Name = "txt_emailUser"
        Me.txt_emailUser.Size = New System.Drawing.Size(121, 20)
        Me.txt_emailUser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(25, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(25, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(25, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo de usuario"
        '
        'cmb_tipoU
        '
        Me.cmb_tipoU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipoU.FormattingEnabled = True
        Me.cmb_tipoU.Items.AddRange(New Object() {"Administrador", "Usuario comum"})
        Me.cmb_tipoU.Location = New System.Drawing.Point(28, 283)
        Me.cmb_tipoU.Name = "cmb_tipoU"
        Me.cmb_tipoU.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoU.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(145, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'img_usuario
        '
        Me.img_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_usuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_usuario.Image = CType(resources.GetObject("img_usuario.Image"), System.Drawing.Image)
        Me.img_usuario.InitialImage = CType(resources.GetObject("img_usuario.InitialImage"), System.Drawing.Image)
        Me.img_usuario.Location = New System.Drawing.Point(209, 116)
        Me.img_usuario.Name = "img_usuario"
        Me.img_usuario.Size = New System.Drawing.Size(144, 157)
        Me.img_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_usuario.TabIndex = 17
        Me.img_usuario.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(206, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Foto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Novo Usuário"
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.img_usuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_tipoU)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_emailUser)
        Me.Controls.Add(Me.txt_senhaUser)
        Me.Controls.Add(Me.txt_nomeUser)
        Me.Name = "frm_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastro"
        CType(Me.img_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nomeUser As TextBox
    Friend WithEvents txt_senhaUser As TextBox
    Friend WithEvents txt_emailUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_tipoU As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents img_usuario As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
