Module IngresoClientes
    Dim sql As String


    Public Sub RecuperarRegion()
        sql = "Select * from regiones"
        ReDim General.consultaVector(1)
        General.consultaVector(0) = "id_region"
        General.consultaVector(1) = "nombre_region"
        General.region = General.recuperar(sql)
        For i = 0 To General.region.GetUpperBound(1)
            Form1.ComboBox1.Items.Add(General.region(1, i))
        Next
    End Sub
    Public Sub RecuperarProvincia()

        sql = "Select * from provincias where id_region LIKE'" & General.region(0, Form1.ComboBox1.SelectedIndex) & "%';"
        ReDim General.consultaVector(2)
        General.consultaVector(0) = "id_provincia"
        General.consultaVector(1) = "Nombre_provincia"
        General.consultaVector(2) = "id_region"
        General.provincia = General.recuperar(sql)
        Form1.ComboBox11.Items.Clear()
        For i = 0 To General.modelo.GetUpperBound(1)
            Form1.ComboBox11.Items.Add(General.provincia(1, i))
        Next
        Form1.ComboBox11.Text = ""
    End Sub


    Public Sub RecuperarComunas()

        sql = "Select * from comunas where id_provincia LIKE'" & General.provincia(0, Form1.ComboBox11.SelectedIndex) & "%';"
        ReDim General.consultaVector(2)
        General.consultaVector(0) = "id_comuna"
        General.consultaVector(1) = "nombre_comuna"
        General.consultaVector(2) = "id_provincia"
        General.comuna = General.recuperar(sql)
        Form1.ComboBox2.Items.Clear()
        For i = 0 To General.comuna.GetUpperBound(1)
            Form1.ComboBox2.Items.Add(General.comuna(1, i))
        Next
        Form1.ComboBox2.Text = ""
    End Sub

    Public Sub IngresarCliente()
        Dim op As DialogResult = MessageBox.Show("¿Desea ingresar este Cliente?", "Ingreso Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            'Preparamos la sentencia a utilizar
            If Form1.TextBox1.Text <> "" And Form1.TextBox2.Text <> "" And Form1.TextBox9.Text <> "" And Form1.TextBox14.Text <> "" And Form1.TextBox4.Text <> "" And Form1.ComboBox1.Text <> "" And Form1.ComboBox11.Text <> "" And Form1.ComboBox2.Text <> "" Then
                sql = "Insert into cliente(rut,nombre_cliente,direccion,id_comuna,giro_comercial,user) values('" & Form1.TextBox1.Text & "','" & Form1.TextBox2.Text & "','" & Form1.TextBox9.Text & "','" & General.comuna(0, Form1.ComboBox2.SelectedIndex) & "','" & Form1.TextBox14.Text & "','" & General.nom & "');"
                General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
                sql = "Insert into correos(correo, rut_asociado, nombre_contacto,user) values('" & Form1.TextBox4.Text & "', '" & Form1.TextBox1.Text & "','" & Form1.TextBox2.Text & "','" & General.nom & "'); " ' '" & General.usuario(0, 0) & "
                General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
                MsgBox("Operación Exitosa")
                LimpiarCampoCliente()
                RecuperarRegion()
            Else
                MsgBox("Quedan campos por completar")
            End If


        End If
    End Sub

    Public Sub LimpiarCampoCliente()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox9.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ("")
        Form1.ComboBox2.Text = ("")
        Form1.ComboBox11.Text = ("")
        Form1.TextBox14.Clear()
    End Sub
End Module
