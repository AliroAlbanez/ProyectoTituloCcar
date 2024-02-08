Module VistaUsuarios
    Dim sql As String

    Public Sub verUsuarios()
        'preparar el sql a consultar
        sql = "SELECT rut, nombre, apellidos, clave, nuevo, intentos, user, date FROM usuario WHERE vis=1 AND nombre <> 'root' AND (rut LIKE '%" & Form1.TextBox90.Text & "%' OR nombre LIKE '%" & Form1.TextBox90.Text & "%' OR apellidos LIKE '%" & Form1.TextBox90.Text & "%');"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(7)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "rut"
        General.consultaVector(1) = "nombre"
        General.consultaVector(2) = "apellidos"
        General.consultaVector(3) = "clave"
        General.consultaVector(4) = "nuevo"
        General.consultaVector(5) = "intentos"
        General.consultaVector(6) = "user"
        General.consultaVector(7) = "date"
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim General.usuarios(0, 0)
        General.usuarios = General.recuperar(sql)
        Form1.DataGridView5.Rows.Clear() 'se eliminan todas las filas para que no quede una en registro
        If General.usuarios(0, 0) <> "" Then 'solo basta con que la primera fila se avacio para saber que no hay datos encontrados
            Form1.botonEliminar.Enabled = True
            Form1.botonEditar.Enabled = True
            For i = 0 To General.usuarios.GetUpperBound(1)
                Form1.DataGridView5.RowCount = i + 1
                For j = 0 To Form1.DataGridView5.ColumnCount - 1
                    Form1.DataGridView5(j, i).Value = General.usuarios(j, i)
                Next

            Next
        End If
    End Sub


    Public Sub botonEditar()
        Dim fila As Integer
        fila = Form1.DataGridView5.CurrentRow.Index
        modificarUsuario.Show()
        modificarUsuario.Text = "Editar usuario"
        modificarUsuario.cambio = Form1.DataGridView5(0, fila).Value
        modificarUsuario.TextBox1.Text = Form1.DataGridView5(0, fila).Value
        modificarUsuario.TextBox2.Text = Form1.DataGridView5(1, fila).Value
        modificarUsuario.TextBox4.Text = Form1.DataGridView5(2, fila).Value
        modificarUsuario.TextBox3.Text = Form1.DataGridView5(3, fila).Value
        modificarUsuario.CheckBox1.Checked = Form1.DataGridView5(4, fila).Value
        If Form1.DataGridView5(5, fila).Value > 4 Then
            modificarUsuario.CheckBox2.Checked = True
        End If
    End Sub

    Public Sub botonEliminar()
        Dim fila As Integer
        fila = Form1.DataGridView5.CurrentRow.Index
        Dim consulta As DialogResult
        consulta = MessageBox.Show("¿Desea eliminar al usuario " & Form1.DataGridView5(0, fila).Value & "?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If consulta = DialogResult.Yes Then
            sql = "UPDATE `usuario` SET `vis`= 0 , `user`='" & General.usuario(0, 0) & "' WHERE rut='" & Form1.DataGridView5(0, fila).Value & "';"
            General.IngresarDatos(sql)
            verUsuarios()
        End If
    End Sub

    Public Sub botonNuevo()
        modificarUsuario.Show()
        modificarUsuario.CheckBox1.Checked = True
        modificarUsuario.cambio = ""
        modificarUsuario.Text = "Nuevo usuario"
    End Sub


End Module
