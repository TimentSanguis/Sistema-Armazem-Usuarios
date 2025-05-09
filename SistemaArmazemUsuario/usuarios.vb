Public Class usuarios
    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        carregar_usuarios()
        carregar_campos()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            sql = $"select * from usuarios where {cmb_campo.Text} like '{txt_pesquisa.Text}%' order by nome asc"
            rs = db.Execute(sql)
            cont = 0
            With Dgv_usuarios
                .Rows.Clear()
                Do While rs.EOF = False
                    cont = cont + 1
                    Dim caminhoImagem As String = rs.Fields("foto").Value
                    Dim imagemUsuario As Image = Nothing
                    imagemUsuario = Image.FromFile(caminhoImagem)
                    .Rows.Add(rs.Fields("id").Value, rs.Fields("nome").Value, rs.Fields("email").Value, rs.Fields("senha").Value, rs.Fields("bloqueado").Value, imagemUsuario)
                    rs.MoveNext()
                Loop
            End With

        Catch ex As Exception
            MsgBox("Erro ao carregar imagem: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_novoUser.Click
        aux_id = 0
        frm_cadastro.Show()
    End Sub

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_usuarios.CellContentClick
        Try
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
            If Dgv_usuarios.Rows.Count <= e.RowIndex Then Exit Sub

            Dim row = Dgv_usuarios.Rows(e.RowIndex)

            aux_id = row.Cells(0).Value

            If e.ColumnIndex = 6 Then ' Editar (ícone)
                sql = $"SELECT * FROM usuarios WHERE id='{aux_id}'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    Dim caminhoImagem As String = rs.Fields("foto").Value
                    Dim imagemUsuario As Image = Nothing
                    imagemUsuario = Image.FromFile(caminhoImagem)
                    frm_cadastro.preencherCampos(rs.Fields("nome").Value, rs.Fields("email").Value, rs.Fields("senha").Value, rs.Fields("foto").Value)
                    frm_cadastro.img_usuario.Image = Image.FromFile(caminhoImagem)
                    frm_cadastro.Show()
                    txt_pesquisa.Clear()
                End If

            ElseIf e.ColumnIndex = 7 Then ' Excluir (ícone)
                sql = $"SELECT * FROM usuarios WHERE id='{aux_id}'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    Dim resp = MsgBox("Deseja excluir o usuário de ID: " & aux_id & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"DELETE FROM usuarios WHERE id='{aux_id}'"
                        rs = db.Execute(sql)
                        MsgBox("Usuário excluído", MsgBoxStyle.Information, "AVISO")
                        carregar_usuarios()
                        limpar_cadastro()
                        txt_pesquisa.Clear()
                    End If
                End If

            ElseIf e.ColumnIndex = 8 Then
                sql = $"select * from usuarios where id='{aux_id}'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    If rs.Fields("bloqueado").Value = 0 Then
                        Dim resp = MsgBox("Quer mesmo bloquear o usúario " & rs.Fields("nome").Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atente-se")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"update usuarios set bloqueado = 1 where id='{aux_id}'"
                            rs = db.Execute(sql)
                        Else
                            Exit Sub
                        End If
                    Else
                        Dim resp = MsgBox("Quer mesmo desbloquear o usúario " & rs.Fields("nome").Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atente-se")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"update usuarios set bloqueado = 0 where id='{aux_id}'"
                            rs = db.Execute(sql)
                        End If
                    End If
                    carregar_usuarios()
                    limpar_cadastro()
                    txt_pesquisa.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar clique: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frm_opcao.Show()
        Me.Close()
    End Sub
End Class