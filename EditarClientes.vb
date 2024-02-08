Module EditarClientes
    Dim sql As String

    Public Sub RecuRegion()
        sql = "Select * from regiones"
        ReDim General.consultaVector(1)
        General.consultaVector(0) = "id_region"
        General.consultaVector(1) = "nombre_region"
        General.region = General.recuperar(sql)
        For i = 0 To General.region.GetUpperBound(1)
            Form1.ComboBox19.Items.Add(General.region(1, i))
        Next
    End Sub


    Public Sub RecuProvincia()
        sql = "Select * from provincias where id_region LIKE'" & General.region(0, Form1.ComboBox19.SelectedIndex) & "%';"
        ReDim General.consultaVector(2)
        General.consultaVector(0) = "id_provincia"
        General.consultaVector(1) = "Nombre_provincia"
        General.consultaVector(2) = "id_region"
        General.provincia = General.recuperar(sql)
        Form1.ComboBox18.Items.Clear()
        For i = 0 To General.modelo.GetUpperBound(1)
            Form1.ComboBox18.Items.Add(General.provincia(1, i))
        Next
        Form1.ComboBox18.Text = ""
    End Sub

    Public Sub RecuComuna()
        sql = "Select * from comunas where id_provincia LIKE'" & General.provincia(0, Form1.ComboBox18.SelectedIndex) & "%';"
        ReDim General.consultaVector(2)
        General.consultaVector(0) = "id_comuna"
        General.consultaVector(1) = "nombre_comuna"
        General.consultaVector(2) = "id_provincia"
        General.comuna = General.recuperar(sql)
        Form1.ComboBox8.Items.Clear()
        For i = 0 To General.comuna.GetUpperBound(1)
            Form1.ComboBox8.Items.Add(General.comuna(1, i))
        Next
        Form1.ComboBox8.Text = ""
    End Sub

    Public Sub RecuperarClientes()
        sql = "SELECT c.rut, c.nombre_cliente, c.direccion, c.id_comuna, c.giro_comercial, co.nombre_comuna, p.nombre_provincia, r.nombre_region FROM cliente c INNER JOIN comunas co ON c.id_comuna=co.id_comuna INNER JOIN provincias p ON co.id_provincia=p.id_provincia INNER JOIN regiones r ON p.id_region=r.id_region WHERE c.vis=1"
        'sql = "Select rut,nombre_cliente,direccion,id_comuna,giro_comercial From cliente" 'Preparamos la sentencia a utilizar
        ReDim General.consultaVector(7) 'Redimensionamos consultavector con la cantidad de datos necesitados
        General.consultaVector(0) = "rut"
        General.consultaVector(1) = "nombre_cliente"
        General.consultaVector(2) = "direccion"
        General.consultaVector(3) = "id_comuna"
        General.consultaVector(4) = "giro_comercial"
        General.consultaVector(5) = "nombre_provincia"
        General.consultaVector(6) = "nombre_region"
        General.consultaVector(7) = "nombre_comuna"
        General.cliente = General.recuperar(sql) 'Igualamos la matriz donde almacenaremos los datos con la funcion General.recuperar
        Form1.ComboBox10.Items.Clear()
        For i = 0 To General.cliente.GetUpperBound(1) 'Ciclo for para recorrer la matriz que se igualo anteriormente
            Form1.ComboBox10.Items.Add(General.cliente(0, i)) 'Cargamos los datos de nuestra base de datos al comboBox 
        Next
        Form1.ComboBox10.Text = ""
    End Sub


    Public Sub LimpiarCampos()
        Form1.ComboBox8.Text = ("")
        Form1.ComboBox10.Text = ("")
        Form1.ComboBox18.Text = ("")
        Form1.ComboBox19.Text = ("")
        Form1.TextBox78.Clear()
        Form1.TextBox73.Clear()
        Form1.TextBox79.Clear()
    End Sub

    Public Sub RecuperacionDatos()
        For i = 0 To General.cliente.GetUpperBound(1)
            Dim data = Form1.ComboBox10.Text 'Asignamos el dato del rut a la variable creada

            If data = General.cliente(0, i) Then 'Si la variable creada es igual al rut traspasa los datos relacionados a los campos correspondientes
                Form1.TextBox73.Text = (General.cliente(1, i)) 'Nombre Cliente
                Form1.TextBox78.Text = (General.cliente(2, i)) 'Direccion
                Form1.ComboBox8.Text = (General.cliente(7, i)) 'Nombre Comuna
                Form1.TextBox79.Text = (General.cliente(4, i)) 'Giro Comercial
                Form1.ComboBox18.Text = (General.cliente(5, i)) 'Nombre Provincia
                Form1.ComboBox19.Text = (General.cliente(6, i)) 'Nombre Region
            End If
        Next
    End Sub

    Public Sub Editar()
        Dim op As DialogResult = MessageBox.Show("¿Desea modificar este Cliente?", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            Dim comuna = General.cliente(3, Form1.ComboBox10.SelectedIndex)
            'Preparamos la sentencia a utilizar
            sql = "Update cliente set rut='" & Form1.ComboBox10.Text & "',nombre_cliente='" & Form1.TextBox73.Text & "',direccion='" & Form1.TextBox78.Text & "',id_comuna='" & comuna & "',giro_comercial='" & Form1.TextBox79.Text & "'where rut='" & Form1.ComboBox10.Text & "'"
            General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            MsgBox("Operación Exitosa")
            LimpiarCampos()
            RecuperarClientes()
        End If
    End Sub

    Public Sub Eliminar()
        Dim consulta As DialogResult
        consulta = MessageBox.Show("¿Desea eliminar al cliente " & Form1.TextBox73.Text & "?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If consulta = DialogResult.Yes Then
            sql = "UPDATE `cliente` SET `vis`= 0 , `nombre_cliente`='" & Form1.TextBox73.Text & "' WHERE rut='" & Form1.ComboBox10.Text & "';"
            General.IngresarDatos(sql)
            MsgBox("Operación Exitosa")
            LimpiarCampos()
            RecuperarClientes()
        End If
    End Sub
End Module
