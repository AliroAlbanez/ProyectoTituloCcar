Module Diagnosticocodigo
    Dim sql As String
    Public Sub cargarDiag1()
        sql = "SELECT c.rut, c.nombre_cliente, c.direccion, co.nombre_comuna, e.correo FROM cliente c INNER JOIN comunas co ON c.id_comuna=co.id_comuna INNER JOIN correos e ON c.rut=e.rut_asociado WHERE c.vis=1"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(4)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "rut"
        General.consultaVector(1) = "nombre_cliente"
        General.consultaVector(2) = "direccion"
        General.consultaVector(3) = "nombre_comuna"
        General.consultaVector(4) = "correo"
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim General.clientes(4, 0)
        General.clientes = General.recuperar(sql)
        Form1.ComboBox7.Items.Clear()
        For i = 0 To General.clientes.GetUpperBound(1)
            Form1.ComboBox7.Items.Add(General.clientes(0, i))
        Next
    End Sub

    Public Sub llenardatosclienteDiag1(ByVal a)
        Form1.TextBox39.Text = General.clientes(1, a)
        Form1.TextBox38.Text = General.clientes(2, a)
        Form1.TextBox37.Text = General.clientes(3, a)
        Form1.TextBox40.Text = General.clientes(4, a)

        sql = "SELECT v.patente, v.modelo, v.color_registro, v.año, v.n_chasis, m.marca FROM cliente c INNER JOIN vehiculo v ON c.rut=v.rut_asociado INNER JOIN modelos m ON v.modelo=m.nombre_modelo WHERE c.rut='" & General.clientes(0, a) & "';"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(5)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "patente"
        General.consultaVector(1) = "modelo"
        General.consultaVector(2) = "color_registro"
        General.consultaVector(3) = "año"
        General.consultaVector(4) = "n_chasis"
        General.consultaVector(5) = "marca"

        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim General.vehiculos(5, 0)
        General.vehiculos = General.recuperar(sql)
        Form1.ComboBox16.Items.Clear()
        For i = 0 To General.vehiculos.GetUpperBound(1)
            If General.vehiculos(0, 0) = "" Then
                MsgBox("No se ha encontrado un vehículo asociado a este rut")
            Else
                Form1.ComboBox16.Items.Add(General.vehiculos(0, i))
            End If

        Next
        Form1.ComboBox16.Text = ""
        Form1.TextBox48.Text = ""
        Form1.TextBox47.Text = ""
        Form1.TextBox46.Text = ""
        Form1.TextBox44.Text = ""
        Form1.TextBox49.Text = ""
        Form1.PictureBox23.Enabled = False
    End Sub

    Public Sub llenardatosautodiag1(a)
        Form1.TextBox48.Text = General.vehiculos(1, a)
        Form1.TextBox47.Text = General.vehiculos(2, a)
        Form1.TextBox46.Text = General.vehiculos(3, a)
        Form1.TextBox44.Text = General.vehiculos(4, a)
        Form1.TextBox49.Text = General.vehiculos(5, a)
        Form1.PictureBox23.Enabled = True
    End Sub

    Public Sub sumasvalores()
        Dim mano As Integer = 0
        Dim repu As Integer = 0
        Dim valor As Integer
        For i = 0 To Form1.DataGridView3.RowCount - 2
            Try
                valor = CInt(Form1.DataGridView3(1, i).Value)
            Catch ex As Exception
                Form1.DataGridView3(1, i).Value = 0
            End Try
            repu = repu + CInt(Form1.DataGridView3(1, i).Value)
            For j = 2 To 4
                Try
                    valor = CInt(Form1.DataGridView3(j, i).Value)
                Catch ex As Exception
                    Form1.DataGridView3(j, i).Value = 0
                End Try
                mano = mano + CInt(Form1.DataGridView3(j, i).Value)
            Next
        Next
        Form1.TextBox50.Text = repu
        Form1.TextBox51.Text = mano
    End Sub

    Public Sub valorestotales()
        sql = "SELECT valor FROM parametros WHERE nombre_parametro='iva'"
        ReDim General.consultaVector(0)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "valor"
        Dim iva(0, 0) As String
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim iva(0, 0)
        iva = General.recuperar(sql)
        Form1.TextBox5.Text = CInt(Form1.TextBox50.Text) + CInt(Form1.TextBox51.Text) - CInt(Form1.TextBox52.Text) - CInt(Form1.TextBox53.Text)
        Form1.Label79.Text = "IVA (" & iva(0, 0) & "%):"
        Form1.TextBox55.Text = CInt(Form1.TextBox5.Text) * CInt(iva(0, 0)) / 100
        Form1.TextBox54.Text = CInt(Form1.TextBox5.Text) + CInt(Form1.TextBox55.Text)
    End Sub

    Public Sub guardarDiag(a)
        Dim estado
        If a = 0 Then
            estado = "pendiente"
        Else
            estado = "aprobado"
        End If
        sql = "INSERT INTO `presupuesto`(`id_presupuesto`, `patente_vehiculo`, `n_siniestro`, `pintura_color`, `estado`, `total_repuesto`, `total_mo`, `total_iva`, `total_presupuesto`, `total_neto`, `dcto_repuesto`, `dcto_mo`, `comentarios`, `user`) VALUES ('" & Form1.TextBox34.Text & "','" & Form1.ComboBox16.Text & "','" & Form1.TextBox36.Text & "','" & Form1.TextBox47.Text & "','" & estado & "','" & Form1.TextBox50.Text & "','" & Form1.TextBox51.Text & "','" & Form1.TextBox55.Text & "','" & Form1.TextBox54.Text & "','" & Form1.TextBox5.Text & "','" & Form1.TextBox53.Text & "','" & Form1.TextBox52.Text & "','" & Form1.RichTextBox3.Text & "','" & General.usuario(0, 0) & "');"
        General.IngresarDatos(sql)
        For i = 0 To Form1.DataGridView3.RowCount - 1
            If Form1.DataGridView3(0, i).Value <> Nothing Then
                Dim repuestos As String
                Dim dym As String
                Dim desab As String
                Dim pintura As String

                If Form1.DataGridView3(1, i).Value <> Nothing Then
                    repuestos = Form1.DataGridView3(1, i).Value.ToString
                Else
                    repuestos = "0"
                End If

                If Form1.DataGridView3(2, i).Value <> Nothing Then
                    dym = Form1.DataGridView3(2, i).Value.ToString
                Else
                    dym = "0"
                End If

                If Form1.DataGridView3(3, i).Value <> Nothing Then
                    desab = Form1.DataGridView3(3, i).Value.ToString
                Else
                    desab = "0"
                End If

                If Form1.DataGridView3(4, i).Value <> Nothing Then
                    pintura = Form1.DataGridView3(4, i).Value.ToString
                Else
                    pintura = "0"
                End If

                sql = "INSERT INTO `cuerpo_trabajo`(`id_presupuesto`, `descripcion`, `repuestos`, `dym`, `desab`, `pintura`, `user`) VALUES ('" & Form1.TextBox34.Text & "', '" & Form1.DataGridView3(0, i).Value.ToString & "', '" & repuestos & "', '" & dym & "', '" & desab & "', '" & pintura & "', '" & General.usuario(0, 0) & "');"
                General.IngresarDatos(sql)
            End If
        Next

        If a = 0 Then
        Else
            sql = "UPDATE `presupuesto` SET `rut_aprobado`='" & Form1.TextBox57.Text & "',`nombre_aprobado`='" & Form1.TextBox58.Text & "' WHERE id_presupuesto='" & Form1.TextBox34.Text & "';"
            General.IngresarDatos(sql)

        End If
    End Sub

End Module
