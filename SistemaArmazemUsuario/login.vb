Public Class frm_Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        carregar_usuarios()
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            sql = $"select * from usuarios where email='{txt_emailLogin.Text}' and senha='{txt_senhaLogin.Text}'"
            rs = db.Execute(UCase(sql))

            If Not rs.EOF Then
                If rs.Fields("bloqueado").Value = True Then
                    MsgBox("Usuário bloqueado! Solicite acesso a um administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                    Exit Sub
                End If

                If rs.Fields("adm").Value = True Then
                    frm_opcao.Show()

                Else
                    visualizar.Show()

                End If
            Else
                MsgBox("Email ou senha incorretos.", MsgBoxStyle.Exclamation, "Erro de Login")
            End If

            limpar_cadastro()
        Catch ex As Exception
            MsgBox("Erro ao tentar fazer login", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub


End Class