Public Class frm_inventario
    Private Sub frm_inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        carregar_dados()
        carregar_campos()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If String.IsNullOrEmpty(diretorio) Then
                MsgBox("Selecione uma imagem para o produto!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txt_nome.Text = "" Or txt_quantidade.Text = "" Or txt_preco.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim quantidade As Integer = Integer.Parse(txt_quantidade.Text)

            Dim precoTexto As String = txt_preco.Text.Replace(",", ".")

            If aux_id = 0 Then
                sql = $"insert into produtos (Nome,Quantidade,Preco,data_Chegada,validade,foto) values ('{txt_nome.Text}','{quantidade}','{precoTexto}','{cmb_chegada.Value.Date}','{cmb_validade.Value.Date}','{diretorio}')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = $"update produtos set Nome='{txt_nome.Text}',Quantidade='{quantidade}',Preco='{precoTexto}', data_Chegada='{cmb_chegada.Value.Date}',validade='{cmb_validade.Value.Date}',foto='{diretorio}' where id='{aux_id}'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If

            limpar_cadastro()
            carregar_dados()
            aux_id = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub img_produto_Click(sender As Object, e As EventArgs) Handles img_produto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos\"
                .ShowDialog()
                diretorio = .FileName
                img_produto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub preencherCampos(Nome As String, Quantidade As Integer, Preco As String, dataChegada As Date, dataValidade As Date)
        txt_nome.Text = Nome
        txt_quantidade.Text = Quantidade.ToString()
        txt_preco.Text = Preco
        cmb_chegada.Value = dataChegada
        cmb_validade.Value = dataValidade
    End Sub

    Private Sub txt_preco_Leave(sender As Object, e As EventArgs) Handles txt_preco.Leave
        Dim valor As Decimal

        If Decimal.TryParse(txt_preco.Text.Replace(".", ","), valor) Then
            txt_preco.Text = valor.ToString("N2")
        End If
    End Sub
End Class