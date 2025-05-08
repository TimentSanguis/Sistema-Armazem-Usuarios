<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_emailLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senhaLogin = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(83, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "E-mail"
        '
        'txt_emailLogin
        '
        Me.txt_emailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_emailLogin.Location = New System.Drawing.Point(87, 71)
        Me.txt_emailLogin.Name = "txt_emailLogin"
        Me.txt_emailLogin.Size = New System.Drawing.Size(120, 20)
        Me.txt_emailLogin.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(83, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Senha"
        '
        'txt_senhaLogin
        '
        Me.txt_senhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senhaLogin.Location = New System.Drawing.Point(87, 150)
        Me.txt_senhaLogin.Name = "txt_senhaLogin"
        Me.txt_senhaLogin.Size = New System.Drawing.Size(120, 20)
        Me.txt_senhaLogin.TabIndex = 7
        '
        'btn_login
        '
        Me.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_login.Location = New System.Drawing.Point(104, 217)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(84, 30)
        Me.btn_login.TabIndex = 10
        Me.btn_login.Text = "Entrar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 295)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_senhaLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_emailLogin)
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_emailLogin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senhaLogin As TextBox
    Friend WithEvents btn_login As Button
End Class
