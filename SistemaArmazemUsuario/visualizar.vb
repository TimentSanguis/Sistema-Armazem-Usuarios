Imports System.Runtime.InteropServices

Public Class visualizar
    Private Sub visualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        carregar_dados()
        carregar_campos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_inventario.Show()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            sql = $"select * from produtos where {cmb_campo.Text} like '{txt_pesquisa.Text}%' order by nome asc"
            rs = db.Execute(sql)
            cont = 0
            With Dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    cont = cont + 1
                    Dim caminhoImagem As String = rs.Fields("foto").Value
                    Dim imagemProduto As Image = Nothing
                    imagemProduto = Image.FromFile(caminhoImagem)
                    Dim preco As String = FormatCurrency(rs.Fields("Preco").Value, 2)
                    Dim data_Chegada = CDate(rs.Fields("data_Chegada").Value).ToString("dd/MM/yyyy")
                    Dim validade = CDate(rs.Fields("validade").Value).ToString("dd/MM/yyyy")
                    .Rows.Add(rs.Fields("id").Value, rs.Fields("Nome").Value, "-", rs.Fields("Quantidade").Value, "+", preco, data_Chegada, validade, imagemProduto)
                    rs.MoveNext()
                Loop
            End With

        Catch ex As Exception
            MsgBox("Erro ao carregar imagem: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_dados.CellContentClick
        Try
            With Dgv_dados
                If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
                If .Rows.Count <= e.RowIndex Then Exit Sub

                Dim row = .Rows(e.RowIndex)
                If row Is Nothing OrElse row.Cells.Count < 11 Then Exit Sub

                aux_id = row.Cells(0).Value

                If row.Cells(2).Selected = True Then
                    sql = $"select * from produtos where id='{aux_id}'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        Dim qtdHipotetica = rs.Fields("Quantidade").Value - 1
                        If qtdHipotetica <= 0 Then
                            sql = $"delete from produtos where id ='{aux_id}'"
                            db.Execute(sql)
                            carregar_dados()
                            MsgBox("Produto excluído porque acabou :(", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Else
                            sql = $"update produtos set Quantidade = Quantidade - 1 where id='{aux_id}'"
                            db.Execute(sql)
                            carregar_dados()
                        End If
                    End If
                End If

                If row.Cells(4).Selected = True Then
                    sql = $"select * from produtos where id='{aux_id}'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        sql = $"update produtos set Quantidade = Quantidade + 1 where id='{aux_id}'"
                        db.Execute(sql)
                        carregar_dados()
                    End If
                End If

                If row.Cells(9).Selected = True Then
                    sql = $"select * from produtos where id='{aux_id}'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        Dim caminhoImagem As String = rs.Fields("foto").Value
                        Dim imagemProduto As Image = Nothing
                        imagemProduto = Image.FromFile(caminhoImagem)
                        frm_inventario.preencherCampos(rs.Fields("Nome").Value, rs.Fields("Quantidade").Value, rs.Fields("Preco").Value, rs.Fields("data_Chegada").Value, rs.Fields("validade").Value)
                        frm_cadastro.img_usuario.Image = Image.FromFile(caminhoImagem)
                        frm_inventario.Show()
                        txt_pesquisa.Clear()
                    End If
                ElseIf row.Cells(10).Selected = True Then
                    sql = $"select * from produtos where id='{aux_id}'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja excluir o" + vbNewLine &
                                    "Produto de ID: " & aux_id & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"delete from produtos where id='{aux_id}'"
                            rs = db.Execute(sql)
                            MsgBox("Produto excluído", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            carregar_dados()
                            limpar_cadastro()
                            txt_pesquisa.Clear()
                        Else
                            Exit Sub
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_campo_Click(sender As Object, e As EventArgs) Handles cmb_campo.Click

    End Sub
End Class