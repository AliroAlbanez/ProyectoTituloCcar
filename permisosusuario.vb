Public Class permisosusuario
    Dim sql As String
    Dim cambios As Boolean = False
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 
        Form1.Show()
    End Sub

    Private Sub permisosusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'preparar el sql a consultar
        sql = "SELECT u.nombre, u.apellidos, p.* FROM usuario u INNER JOIN permisos p ON u.rut=p.usuario WHERE u.vis=1 AND u.nombre <> 'root';"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(14)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "nombre"
        General.consultaVector(1) = "apellidos"
        General.consultaVector(2) = "administrador"
        General.consultaVector(3) = "reportes"
        General.consultaVector(4) = "editar"
        General.consultaVector(5) = "agregar"
        General.consultaVector(6) = "cliente"
        General.consultaVector(7) = "vehiculo"
        General.consultaVector(8) = "ot"
        General.consultaVector(9) = "diagnostico"
        General.consultaVector(10) = "papelera"
        General.consultaVector(11) = "estado"
        General.consultaVector(12) = "user"
        General.consultaVector(13) = "date"
        General.consultaVector(14) = "usuario"
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        General.usuarios = General.recuperar(Sql)

        If General.usuarios.GetUpperBound(1) <> 0 And General.usuarios(0, 0) <> "" Then
            PictureBox1.Enabled = True
            For i = 0 To General.usuarios.GetUpperBound(1)
                DataGridView1.RowCount = i + 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    DataGridView1(j, i).Value = General.usuarios(j, i)
                Next

            Next
            cambios = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        guardarpermisos()
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        cambios = True
    End Sub

    Private Sub guardarpermisos()
        If cambios Then
            Dim respuesta As DialogResult

            respuesta = MessageBox.Show("¿Desea guardar los cambios en los permisos?", "Cambio de permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If respuesta = DialogResult.Yes Then
                For i = 0 To DataGridView1.RowCount - 1
                    sql = "UPDATE permisos SET `administrador`=" & DataGridView1(2, i).Value & ",`reportes`=" & DataGridView1(3, i).Value & ",`editar`=" & DataGridView1(4, i).Value & ",`agregar`=" & DataGridView1(5, i).Value & ",`cliente`=" & DataGridView1(6, i).Value & ",`vehiculo`=" & DataGridView1(7, i).Value & ",`ot`=" & DataGridView1(8, i).Value & ",`diagnostico`=" & DataGridView1(9, i).Value & ",`papelera`=" & DataGridView1(10, i).Value & ",`estado`=" & DataGridView1(11, i).Value & ",`user`='" & General.usuario(0, 0) & "' WHERE usuario='" & General.usuarios(14, i) & "';"
                    General.IngresarDatos(sql)
                Next

                MessageBox.Show("Permisos guardados con éxito, vuelva a iniciar sesión para aplicar los cambios", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cambios = False
            End If
        End If
    End Sub

    Private Sub permisosusuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambios Then
            guardarpermisos()
        End If
        Form1.Show()
    End Sub
End Class