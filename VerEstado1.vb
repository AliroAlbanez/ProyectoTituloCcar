Module VerEstado1
    Dim sql As String 'variable para el sql 

    Public Sub mostrar()
        'SQL a consultar que cabe destacar que sera MODIFICADO una vez empecemos a trabajar con las orden de trabajo 
        sql = "SELECT c.nombre_cliente, c.rut, vehiculo.patente,vehiculo.modelo, modelos.marca FROM cliente c INNER JOIN vehiculo ON c.rut=vehiculo.rut_asociado INNER JOIN modelos ON vehiculo.modelo=modelos.nombre_modelo WHERE c.nombre_cliente LIKE '%" & Form1.TextBox8.Text & "%' OR vehiculo.patente LIKE '%" & Form1.TextBox8.Text & "%';"

        ReDim General.consultaVector(3)
        General.consultaVector(0) = "nombre_cliente"
        General.consultaVector(1) = "patente"
        General.consultaVector(2) = "marca"
        General.consultaVector(3) = "modelo"
        ReDim General.vrestado(0, 0)
        'Igualamos la matriz donde se quieren guardar los datos  con la funcion General.recuperar(sql)
        General.vrestado = General.recuperar(sql)

        Form1.DataGridView2.Rows.Clear()

        If General.vrestado(0, 0) <> "" Then

            For j = 0 To General.vrestado.GetUpperBound(1) 'for para recorrer la matriz
                Form1.DataGridView2.RowCount = j + 1
                Form1.DataGridView2(0, j).Value = General.vrestado(0, j)
                Form1.DataGridView2(1, j).Value = General.vrestado(1, j)
                Form1.DataGridView2(2, j).Value = General.vrestado(2, j)
                Form1.DataGridView2(3, j).Value = General.vrestado(3, j)

                sql = "SELECT e.nombre_estado FROM estado e INNER JOIN vehiculo_estado r ON e.id_estado=r.id_estado WHERE r.patente='" & Form1.DataGridView2(1, j).Value & "' AND r.status=1;"

                ReDim General.consultaVector(0)
                General.consultaVector(0) = "nombre_estado"

                ReDim General.estadoc(0, 0)
                'Igualamos la matriz donde se quieren guardar los datos  con la funcion General.recuperar(sql)
                General.estadoc = General.recuperar(sql)


                Form1.DataGridView2(4, j).Value = General.estadoc(0, 0)

            Next

            'si no exiten coicidencia con el nombre o patente que se busca se mostrara un mensaje por pantalla que no hay resultados de busqueda 

        End If



    End Sub


End Module
