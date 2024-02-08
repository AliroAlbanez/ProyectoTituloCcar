Public Class Vre
    Dim sql As String 'variable para el sql 
    Private Sub Vre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub mostrar()
        'SQL a consultar que cabe destacar que sera MODIFICADO una vez empecemos a trabajar con las orden de trabajo 
        Sql = "SELECT c.nombre_cliente, c.rut, vehiculo.patente,vehiculo.modelo, modelos.marca FROM cliente c INNER JOIN vehiculo ON c.rut=vehiculo.rut_asociado INNER JOIN modelos ON vehiculo.modelo=modelos.nombre_modelo WHERE c.nombre_cliente LIKE '%" & TextBox1.Text & "%' OR vehiculo.patente LIKE '%" & TextBox1.Text & "%';"

        ReDim General.consultaVector(3)
        General.consultaVector(0) = "nombre_cliente"
        General.consultaVector(1) = "patente"
        General.consultaVector(2) = "marca"
        General.consultaVector(3) = "modelo"
        ReDim General.vrestado(0, 0)
        'Igualamos la matriz donde se quieren guardar los datos  con la funcion General.recuperar(sql)
        General.vrestado = General.recuperar(Sql)
        DataGridView1.Rows.Clear()

        If General.vrestado(0, 0) <> "" Then

            For j = 0 To General.vrestado.GetUpperBound(1) 'for para recorrer la matriz
                DataGridView1.RowCount = j + 1
                DataGridView1(0, j).Value = General.vrestado(0, j)
                DataGridView1(1, j).Value = General.vrestado(1, j)
                DataGridView1(2, j).Value = General.vrestado(2, j)
                DataGridView1(3, j).Value = General.vrestado(3, j)

                Sql = "SELECT e.nombre_estado FROM estado e INNER JOIN vehiculo_estado r ON e.id_estado=r.id_estado WHERE r.patente='" & DataGridView1(1, j).Value & "' AND r.status=1;"

                ReDim General.consultaVector(0)
                General.consultaVector(0) = "nombre_estado"

                ReDim General.estadoc(0, 0)
                'Igualamos la matriz donde se quieren guardar los datos  con la funcion General.recuperar(sql)
                General.estadoc = General.recuperar(Sql)


                DataGridView1(4, j).Value = General.estadoc(0, 0)

            Next

        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            General.Exportar(DataGridView1, save.FileName)
            MsgBox("Documento creado")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        mostrar()
    End Sub
End Class