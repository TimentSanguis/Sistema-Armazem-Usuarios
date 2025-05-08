<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_opcao
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
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_visualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_usuarios
        '
        Me.btn_usuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_usuarios.Location = New System.Drawing.Point(100, 179)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(91, 30)
        Me.btn_usuarios.TabIndex = 11
        Me.btn_usuarios.Text = "Usuarios"
        Me.btn_usuarios.UseVisualStyleBackColor = True
        '
        'btn_visualizar
        '
        Me.btn_visualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_visualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_visualizar.Location = New System.Drawing.Point(100, 86)
        Me.btn_visualizar.Name = "btn_visualizar"
        Me.btn_visualizar.Size = New System.Drawing.Size(91, 30)
        Me.btn_visualizar.TabIndex = 12
        Me.btn_visualizar.Text = "Inventário"
        Me.btn_visualizar.UseVisualStyleBackColor = True
        '
        'frm_opcao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.btn_visualizar)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Name = "frm_opcao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_opcao"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_visualizar As Button
End Class
