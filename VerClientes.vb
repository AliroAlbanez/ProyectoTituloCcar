Public Class VerClientes
    Dim sql As String
    Private Sub VerClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    Public Sub CargarClientes()
        'preparar el sql a consultar
        sql = "SELECT rut, nombre_cliente, direccion, id_comuna, fecha_ingreso, giro_comercial, user, date FROM cliente WHERE vis=1 AND (rut LIKE '%" & TextBox1.Text & "%' OR nombre_cliente LIKE '%" & TextBox1.Text & "%');"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(7)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "rut"
        General.consultaVector(1) = "nombre_cliente"
        General.consultaVector(2) = "direccion"
        General.consultaVector(3) = "id_comuna"
        General.consultaVector(4) = "fecha_ingreso"
        General.consultaVector(5) = "giro_comercial"
        General.consultaVector(6) = "user"
        General.consultaVector(7) = "date"
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim General.cliente(0, 0)
        General.cliente = General.recuperar(sql)
        DataGridView1.Rows.Clear() 'se eliminan todas las filas para que no quede una en registro
        If General.cliente(0, 0) <> "" Then 'solo basta con que la primera fila se avacio para saber que no hay datos encontrados
            'botonEliminar.Enabled = True
            'botonEditar.Enabled = True
            For i = 0 To General.cliente.GetUpperBound(1)
                DataGridView1.RowCount = i + 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    DataGridView1(j, i).Value = General.cliente(j, i)
                Next

            Next
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CargarClientes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Reportes.Show()
        'VerVehiculos.Show()
    End Sub


    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            General.Exportar(DataGridView1, save.FileName)
            MsgBox("Documento creado")
        End If
    End Sub
End Class