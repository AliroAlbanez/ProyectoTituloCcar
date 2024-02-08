Module IngresoVehiculo
    Dim sql As String
    Public Sub RecuperarMarcas()
        sql = "Select * from marcas" 'Preparamos la sentencia a utilizar
        ReDim General.consultaVector(0) 'Redimensionamos consultavector con la cantidad de datos necesitados
        General.consultaVector(0) = "nombre_marca"
        General.marca = General.recuperar(sql) 'Igualamos la matriz donde almacenaremos los datos con la funcion General.recuperar
        Form1.ComboBox3.Items.Clear()
        For i = 0 To General.marca.GetUpperBound(1) 'Ciclo for para recorrer la matriz que se igualo anteriormente
            Form1.ComboBox3.Items.Add(General.marca(0, i)) 'Cargamos los datos de nuestra base de datos al comboBox 
        Next
        Form1.ComboBox3.Text = ""
    End Sub

    Public Sub RecuperarTipos()
        sql = "Select * from tipos"
        ReDim General.consultaVector(0)
        General.consultaVector(0) = "nombre_tipo"
        General.tipo = General.recuperar(sql)
        Form1.ComboBox9.Items.Clear()
        If General.tipo.GetUpperBound(1) = 0 And General.tipo(0, 0) = "" Then
            MsgBox("No cuenta con tipos de vehículos, debe agregar alguno(s)")
        Else
            For i = 0 To General.tipo.GetUpperBound(1)
                Form1.ComboBox9.Items.Add(General.tipo(0, i))
            Next
        End If
        Form1.ComboBox9.Text = ""
    End Sub

    Public Sub RecuperarModelos()
        sql = "Select id_modelo,nombre_modelo from modelos where marca LIKE'" & General.marca(0, Form1.ComboBox3.SelectedIndex) & "%';"
        ReDim General.consultaVector(1)
        General.consultaVector(0) = "id_modelo"
        General.consultaVector(1) = "nombre_modelo"
        General.modelo = General.recuperar(sql)
        Form1.ComboBox4.Items.Clear()
        For i = 0 To General.modelo.GetUpperBound(1)
            Form1.ComboBox4.Items.Add(General.modelo(1, i))
        Next
        Form1.ComboBox4.Text = ""

    End Sub

    Public Sub RecuperarRut()
        sql = "Select rut From cliente Where vis=1;" 'Preparamos la sentencia a utilizar
        ReDim General.consultaVector(0) 'Redimensionamos consultavector con la cantidad de datos necesitados
        General.consultaVector(0) = "rut"
        General.cliente = General.recuperar(sql) 'Igualamos la matriz donde almacenaremos los datos con la funcion General.recuperar
        Form1.ComboBox15.Items.Clear()
        For i = 0 To General.cliente.GetUpperBound(1) 'Ciclo for para recorrer la matriz que se igualo anteriormente
            Form1.ComboBox15.Items.Add(General.cliente(0, i)) 'Cargamos los datos de nuestra base de datos al comboBox 
        Next
        Form1.ComboBox15.Text = ""
    End Sub

    Public Sub RecuperarAseguradora()
        sql = "Select nombre_empresa From empresa_seguro"
        ReDim General.consultaVector(0)
        General.consultaVector(0) = "nombre_empresa"
        General.seguro = General.recuperar(sql)
        Form1.ComboBox6.Items.Clear()
        If General.seguro.GetUpperBound(1) = 0 And General.seguro(0, 0) = "" Then
            MsgBox("No cuenta con empresas aseguradoras, debe agregar alguna(s)")
        Else
            For i = 0 To General.seguro.GetUpperBound(1)
                Form1.ComboBox6.Items.Add(General.seguro(0, i))
            Next
        End If
        Form1.ComboBox6.Text = ""
    End Sub

    Public Sub Llevar()
        sql = "INSERT INTO vehiculo_estado(patente, id_estado, user) VALUES ('" & Form1.TextBox6.Text & "','7','" & General.nom & "');"
        IngresarDatos(sql)
    End Sub

    Public Sub IngresarVehiculo()
        Dim op As DialogResult = MessageBox.Show("¿Desea ingresar este vehículo?", "Ingreso Vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'Form1.ComboBox15.Text 
        If op = DialogResult.Yes Then
            'Preparamos la sentencia a utilizar
            sql = "Insert into vehiculo(patente,propetario,rut_asociado,modelo,tipo,año,n_chasis,color_registro,empresa_seguro,liquidador,deducible,vis,user) values('" & Form1.TextBox6.Text & "','" & Form1.TextBox12.Text & "','" & Form1.ComboBox15.Text & "','" & Form1.ComboBox4.Text & "','" & Form1.ComboBox9.Text & "','" & Form1.TextBox16.Text & "','" & Form1.TextBox10.Text & "','" & Form1.TextBox13.Text & "','" & Form1.ComboBox6.Text & "','" & Form1.TextBox15.Text & "','" & Form1.TextBox11.Text & "','1','" & General.nom & "');" ' " & General.usuario(0, 0) & "
            General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            Llevar()
            MsgBox("Operación Exitosa")
            LimpiarCampoVehículo()
            RecuperarTipos()
            RecuperarMarcas()
            RecuperarRut()
            RecuperarAseguradora()
        End If

    End Sub

    Public Sub LimpiarCampoVehículo()
        'Limpiamos todos los textBox y ComboBox 
        Form1.TextBox6.Clear()
        Form1.TextBox12.Clear()
        Form1.TextBox15.Clear()
        Form1.TextBox13.Clear()
        Form1.TextBox10.Clear()
        Form1.TextBox16.Clear()
        Form1.TextBox11.Clear()
        Form1.ComboBox9.Text = ("")
        Form1.ComboBox3.Text = ("")
        Form1.ComboBox4.Text = ("")
        Form1.ComboBox15.Text = ("")
        Form1.ComboBox6.Text = ("")
    End Sub
End Module
