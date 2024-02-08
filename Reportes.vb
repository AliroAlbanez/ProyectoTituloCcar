Public Class Reportes
    Dim sql
    Dim fechass1 As String
    Dim fechass2 As String
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        fechass1 = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        fechass2 = DateTimePicker2.Value.ToString("yyyy/MM/dd")
        agregar()
    End Sub

    Public Sub agregar()
        sql = "SELECT v.patente, v.propetario,c.nombre_cliente ,v.rut_asociado,v.modelo,v.tipo,v.fecha_ingreso, v.año,v.n_chasis,v.color_registro,v.empresa_seguro,v.liquidador,v.deducible FROM vehiculo v INNER JOIN cliente c ON v.rut_asociado = c.rut WHERE v.vis = c.vis = 1 AND v.fecha_ingreso between '" & fechass1 & "' and '" & fechass2 & "';"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(12)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "patente"
        General.consultaVector(1) = "propetario"
        General.consultaVector(2) = "nombre_cliente"
        General.consultaVector(3) = "rut_asociado"
        General.consultaVector(4) = "modelo"
        General.consultaVector(5) = "tipo"
        General.consultaVector(6) = "fecha_ingreso"
        General.consultaVector(7) = "año"
        General.consultaVector(8) = "n_chasis"
        General.consultaVector(9) = "color_registro"
        General.consultaVector(10) = "empresa_seguro"
        General.consultaVector(11) = "liquidador"
        General.consultaVector(12) = "deducible"
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        General.acab = General.recuperar(sql)
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim General.usuarios(0, 0)
        General.usuarios = General.recuperar(sql)
        DataGridView1.Rows.Clear() 'se eliminan todas las filas para que no quede una en registro
        If General.usuarios(0, 0) <> "" Then 'solo basta con que la primera fila se avacio para saber que no hay datos encontrados
            For i = 0 To General.acab.GetUpperBound(1)
                DataGridView1.RowCount = i + 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    DataGridView1(j, i).Value = General.acab(j, i)
                Next

            Next
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'MsgBox("C:\Users\RadneiT\Desktop\uwu")
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            General.Exportar(DataGridView1, save.FileName)
            MsgBox("Documento creado")
        End If
    End Sub
End Class