Public Class frm_opcao
    Private Sub frm_opcao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        visualizar.Show()
        Me.Close()
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        usuarios.Show()
        Me.Close()
    End Sub
End Class