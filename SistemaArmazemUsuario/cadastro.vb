Public Class frm_cadastro
    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        carregar_usuarios()
        carregar_campos()
    End Sub

    Public Sub preencherCampos(Nome As String, Senha As String, Email As String, Foto As String)
        txt_nomeUser.Text = Nome
        txt_senhaUser.Text = Senha
        txt_emailUser.Text = Email

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(diretorio) Then
                MsgBox("Selecione uma imagem para o usuário!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txt_nomeUser.Text = "" Or txt_senhaUser.Text = "" Or txt_emailUser.Text = "" Or cmb_tipoU.SelectedIndex = -1 Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim adm As Integer
            If cmb_tipoU.SelectedIndex = 0 Then
                adm = 1 ' Administrador
            Else
                adm = 0 ' Usuario
            End If

            If aux_id = 0 Then
                ' Inseri novo usuário
                sql = $"insert into usuarios (nome,email,senha,bloqueado,foto,adm) values ('{txt_nomeUser.Text}','{txt_emailUser.Text}','{txt_senhaUser.Text}','{0}','{diretorio}','{adm}')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                ' Atualiza usuário
                sql = $"update usuarios set nome='{txt_nomeUser.Text}', email='{txt_emailUser.Text}', senha='{txt_senhaUser.Text}', foto='{diretorio}', adm='{adm}' where id='{aux_id}'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If

            limpar_cadastro()
            carregar_usuarios()
            aux_id = 0
        Catch ex As Exception
            MsgBox("Erro ao processar os dados: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub img_produto_Click(sender As Object, e As EventArgs) Handles img_usuario.Click
        Try
            Dim OpenFileDialog2 As New OpenFileDialog()
            With OpenFileDialog2
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotosU\"
                If .ShowDialog() = DialogResult.OK Then
                    diretorio = .FileName
                    img_usuario.Load(diretorio)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

End Class