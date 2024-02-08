Module ordenCompra
    Dim sql As String
    Dim datosOrden(9, 0) As String
    Dim diagnosticos(0, 0) As String
    Dim numeroCliente(0, 0) As String
    Dim tabla(0, 0) As String
    Public Sub cargarDatos(ByVal a)
        sql = "SELECT c.rut, c.nombre_cliente, c.direccion, v.patente, v.modelo, v.color_registro, v.año, m.marca, co.correo FROM cliente c INNER JOIN vehiculo v ON c.rut=v.rut_asociado INNER JOIN modelos m ON v.modelo=m.nombre_modelo INNER JOIN correos co ON c.rut=co.rut_asociado INNER JOIN presupuesto p ON p.patente_vehiculo=v.patente WHERE p.id_presupuesto='" & a & "';"
        ReDim General.consultaVector(8)
        General.consultaVector(0) = "rut"
        General.consultaVector(1) = "nombre_cliente"
        General.consultaVector(2) = "direccion"
        General.consultaVector(3) = "patente"
        General.consultaVector(4) = "modelo"
        General.consultaVector(5) = "color_registro"
        General.consultaVector(6) = "año"
        General.consultaVector(7) = "marca"
        General.consultaVector(8) = "correo"
        datosOrden = General.recuperar(sql)

        Form1.TextBox25.Text = datosOrden(0, 0)
        Form1.TextBox3.Text = datosOrden(1, 0)
        Form1.TextBox27.Text = datosOrden(2, 0)
        Form1.TextBox28.Text = datosOrden(3, 0)
        Form1.TextBox33.Text = datosOrden(4, 0)
        Form1.TextBox23.Text = datosOrden(5, 0)
        Form1.TextBox30.Text = datosOrden(6, 0)
        Form1.TextBox29.Text = datosOrden(7, 0)
        Form1.TextBox32.Text = datosOrden(8, 0)
        'telefono
        sql = "SELECT n.numero FROM telefonos n INNER JOIN cliente c ON c.rut=n.rut_asociado WHERE c.rut='" & datosOrden(0, 0) & "';"
        ReDim General.consultaVector(0)
        General.consultaVector(0) = "numero"
        numeroCliente = General.recuperar(sql)

        Form1.TextBox26.Text = numeroCliente(0, 0)

        'llenado tabla
        sql = "SELECT * FROM cuerpo_trabajo WHERE id_presupuesto='" & Form1.ComboBox17.Text & "';"
        ReDim General.consultaVector(4)
        General.consultaVector(0) = "descripcion"
        General.consultaVector(1) = "repuestos"
        General.consultaVector(2) = "dym"
        General.consultaVector(3) = "desab"
        General.consultaVector(4) = "pintura"
        tabla = General.recuperar(sql)
        Form1.DataGridView6.RowCount = 0
        For i = 0 To tabla.GetUpperBound(1)
            Form1.DataGridView6.RowCount = Form1.DataGridView6.RowCount + 1
            For j = 0 To Form1.DataGridView6.ColumnCount - 1
                Form1.DataGridView6(j, i).Value = tabla(j, i)
            Next
        Next
    End Sub

    Public Sub cargarDiagnosticos()
        sql = "SELECT id_presupuesto FROM presupuesto;"
        ReDim General.consultaVector(0)
        General.consultaVector(0) = "id_presupuesto"

        diagnosticos = General.recuperar(sql)
        Form1.ComboBox17.Items.Clear()

        For i = 0 To diagnosticos.GetUpperBound(1)
            Form1.ComboBox17.Items.Add(diagnosticos(0, i))
        Next
    End Sub

    Public Sub guardarOT()
        sql = "INSERT INTO `orden_trabajo`(`id_orden`, `id_presupuesto`, `estado`, `km`, `combustible`, `user`) VALUES ('" & Form1.TextBox22.Text & "','" & Form1.ComboBox17.Text & "','Activo','" & Form1.TextBox7.Text & "','" & Form1.TextBox17.Text & "','" & General.usuario(0, 0) & "');"
        General.IngresarDatos(sql)
        MessageBox.Show("Ingreso de orden exitosa", "Ingreso de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
