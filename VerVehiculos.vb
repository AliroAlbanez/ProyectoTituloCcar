Public Class VerVehiculos
    Dim sql As String
    Private Sub VerVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVehiculos()
    End Sub

    Public Sub CargarVehiculos()
        'preparar el sql a consultar
        sql = "SELECT patente, propetario, rut_asociado, modelo, tipo, fecha_ingreso, año, n_chasis, color_registro, empresa_seguro, liquidador, deducible, user, date FROM vehiculo WHERE vis=1 AND (patente LIKE '%" & TextBox1.Text & "%' OR rut_asociado LIKE '%" & TextBox1.Text & "%');"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(13)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "patente"
        General.consultaVector(1) = "propetario"
        General.consultaVector(2) = "rut_asociado"
        General.consultaVector(3) = "modelo"
        General.consultaVector(4) = "tipo"
        General.consultaVector(5) = "fecha_ingreso"
        General.consultaVector(6) = "año"
        General.consultaVector(7) = "n_chasis"
        General.consultaVector(8) = "color_registro"
        General.consultaVector(9) = "empresa_seguro"
        General.consultaVector(10) = "liquidador"
        General.consultaVector(11) = "deducible"
        General.consultaVector(12) = "user"
        General.consultaVector(13) = "date"
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim General.autos(0, 0)
        General.autos = General.recuperar(sql)
        DataGridView1.Rows.Clear() 'se eliminan todas las filas para que no quede una en registro
        If General.autos(0, 0) <> "" Then 'solo basta con que la primera fila se avacio para saber que no hay datos encontrados
            'botonEliminar.Enabled = True
            'botonEditar.Enabled = True
            For i = 0 To General.autos.GetUpperBound(1)
                DataGridView1.RowCount = i + 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    DataGridView1(j, i).Value = General.autos(j, i)
                Next

            Next
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CargarVehiculos()
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