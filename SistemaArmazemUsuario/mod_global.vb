Module mod_global
    Public diretorio, sql, resp, aux_id As String 'Declaração de variaveis publicas-
    Public db As New ADODB.Connection 'variavel do banco
    Public rs As New ADODB.Recordset 'variavel tabela
    Public cont As Integer

    Sub Conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-3NM5K65\MSSQLSERVER1;Initial Catalog=armazem;Trusted_Connection=Yes;")
            MsgBox("Conexão Ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub carregar_campos()
        Try
            With visualizar.cmb_campo.Items
                .Add("ID")
                .Add("Nome")
            End With

            With usuarios.cmb_campo.Items
                .Add("ID")
                .Add("Nome")
            End With
            visualizar.cmb_campo.SelectedIndex = 1
            usuarios.cmb_campo.SelectedIndex = 1
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_dados()
        Try
            sql = "select * from produtos order by nome asc"
            rs = db.Execute(sql)
            cont = 0
            With visualizar.Dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    Dim caminhoImagem As String = rs.Fields("foto").Value
                    Dim imagemProduto As Image = Nothing
                    imagemProduto = Image.FromFile(caminhoImagem)

                    Dim preco As String = FormatCurrency(rs.Fields("Preco").Value, 2)
                    Dim data_Chegada = CDate(rs.Fields("data_Chegada").Value).ToString("dd/MM/yyyy")
                    Dim validade = CDate(rs.Fields("validade").Value).ToString("dd/MM/yyyy")

                    cont = cont + 1
                    .Rows.Add(rs.Fields("id").Value, rs.Fields("Nome").Value, "-", rs.Fields("Quantidade").Value, "+", preco, data_Chegada, validade, imagemProduto)
                    rs.MoveNext()
                Loop
            End With

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_usuarios()
        Try
            sql = "select * from usuarios order by id asc"
            rs = db.Execute(sql)
            With usuarios.Dgv_usuarios
                .Rows.Clear()
                Do While rs.EOF = False

                    'carrega a foto/imagem'
                    Dim caminhoImagem As String = rs.Fields("foto").Value
                    Dim imagemUsuario As Image = Nothing
                    imagemUsuario = Image.FromFile(caminhoImagem)

                    'status de bloqueado ou não'
                    Dim status As String
                    If rs.Fields("bloqueado").Value = 0 Then
                        status = "Desbloqueado"
                    Else
                        status = "Bloqueado"
                    End If

                    cont = cont + 1
                    .Rows.Add(rs.Fields("id").Value, rs.Fields("nome").Value, rs.Fields("email").Value, rs.Fields("senha").Value, status, imagemUsuario)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
        End Try
    End Sub

    Sub limpar_cadastro()
        Try
            With frm_inventario
                .txt_nome.Clear()
                .txt_quantidade.Clear()
                .txt_preco.Clear()
                .cmb_chegada.Value = Now
                .cmb_validade.Value = Now
                .img_produto.Load(Application.StartupPath & "\fotos\nova_foto.png")
                .txt_nome.Focus()
            End With

            With frm_cadastro
                .txt_nomeUser.Clear()
                .txt_emailUser.Clear()
                .txt_senhaUser.Clear()
                .img_usuario.Load(Application.StartupPath & "\fotos\nova_foto.png")
            End With

            With frm_Login
                .txt_emailLogin.Clear()
                .txt_senhaLogin.Clear()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

End Module
