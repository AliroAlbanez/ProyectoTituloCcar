Module EditarVehiculos
    Dim sql As String

    Public Sub recuCliente2()
        sql = "Select rut from cliente"
        ReDim General.consultaVector(0)
        General.consultaVector(0) = "rut"
        General.cliente = General.recuperar(sql)
        For i = 0 To General.cliente.GetUpperBound(1)
            Form1.ComboBox14.Items.Add(General.cliente(0, i))
        Next
    End Sub


    Public Sub recutipo2()
        sql = "Select * from tipos"
        ReDim General.consultaVector(0)
        General.consultaVector(0) = "nombre_tipo"
        General.tipo = General.recuperar(sql)
        For i = 0 To General.tipo.GetUpperBound(1)
            Form1.ComboBox13.Items.Add(General.tipo(0, i))
        Next
    End Sub


    Public Sub Recuperarvehiculo()
        'sql = "Select patente,propetario,rut_asociado,modelo,tipo,año,n_chasis,color_registro,empresa_seguro,liquidador,deducible,user from vehiculo"
        sql = "Select * from vehiculo Where vis=1"

        ReDim General.consultaVector(11)

        General.consultaVector(0) = "patente"
        General.consultaVector(1) = "propetario"
        General.consultaVector(2) = "rut_asociado"
        General.consultaVector(3) = "modelo"
        General.consultaVector(4) = "tipo"
        General.consultaVector(5) = "año"
        General.consultaVector(6) = "n_chasis"
        General.consultaVector(7) = "color_registro"
        General.consultaVector(8) = "empresa_seguro"
        General.consultaVector(9) = "liquidador"
        General.consultaVector(10) = "deducible"
        General.consultaVector(11) = "user"
        General.autos = General.recuperar(sql)
        Form1.ComboBox12.Items.Clear()
        For i = 0 To General.autos.GetUpperBound(1)
            Form1.ComboBox12.Items.Add(General.autos(0, i))
        Next
        Form1.ComboBox12.Text = ""
    End Sub

    Public Sub RecuperarDatos()
        For i = 0 To General.autos.GetUpperBound(1)
            Dim rata = Form1.ComboBox12.Text
            If rata = General.autos(0, i) Then
                Form1.TextBox70.Text = (General.autos(1, i)) 'propietario
                Form1.ComboBox14.Text = (General.autos(2, i)) 'rut asociado
                Form1.TextBox69.Text = (General.autos(3, i)) 'modelo
                Form1.ComboBox13.Text = (General.autos(4, i)) 'tipo vehiculo
                Form1.TextBox60.Text = (General.autos(5, i)) 'año
                Form1.TextBox64.Text = (General.autos(6, i)) 'nro chasis
                Form1.TextBox66.Text = (General.autos(7, i)) 'color
                Form1.TextBox71.Text = (General.autos(8, i)) 'seguro
                Form1.TextBox67.Text = (General.autos(9, i)) 'liquidador
                Form1.TextBox63.Text = (General.autos(10, i)) 'deducible
            End If

        Next
    End Sub

    Public Sub Editar()
        Dim op As DialogResult = MessageBox.Show("¿Desea modificar este Vehiculo?", "Editar Vehiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            Dim tipo = Form1.ComboBox13.Text
            Dim cliente = Form1.ComboBox14.Text
            'Preparamos la sentencia a utilizar
            sql = "update vehiculo set patente='" & Form1.ComboBox12.Text & "',propetario='" & Form1.TextBox70.Text & "',rut_asociado='" & cliente & "',modelo='" & Form1.TextBox69.Text & "',tipo='" & tipo & "',año='" & Form1.TextBox60.Text & "',n_chasis='" & Form1.TextBox64.Text & "',color_registro='" & Form1.TextBox66.Text & "',empresa_seguro='" & Form1.TextBox71.Text & "',liquidador='" & Form1.TextBox67.Text & "',deducible='" & Form1.TextBox63.Text & "'where patente='" & Form1.ComboBox12.Text & "'"
            General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            MsgBox("Operación Exitosa")
            Limpiar()
            Recuperarvehiculo()

        End If
    End Sub

    Public Sub Eliminar()
        Dim consulta As DialogResult
        consulta = MessageBox.Show("¿Desea eliminar el vehículo patente " & Form1.ComboBox12.Text & "?", "Eliminar vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If consulta = DialogResult.Yes Then
            sql = "UPDATE `vehiculo` SET `vis`= 0 , `modelo`='" & Form1.TextBox69.Text & "' WHERE patente='" & Form1.ComboBox12.Text & "';"
            General.IngresarDatos(sql)
            MsgBox("Operación Exitosa")
            Limpiar()
            Recuperarvehiculo()
        End If
    End Sub

    Public Sub Limpiar()
        Form1.ComboBox12.Text = ("")
        Form1.ComboBox13.Text = ("")
        Form1.ComboBox14.Text = ("")
        Form1.TextBox70.Clear()
        Form1.TextBox69.Clear()
        Form1.TextBox60.Clear()
        Form1.TextBox64.Clear()
        Form1.TextBox66.Clear()
        Form1.TextBox71.Clear()
        Form1.TextBox67.Clear()
        Form1.TextBox63.Clear()
    End Sub

End Module
