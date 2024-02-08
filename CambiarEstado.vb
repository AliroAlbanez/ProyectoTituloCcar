Public Class CambiarEstado
    Dim sql As String
    Private Sub CambiarEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "SELECT e.nombre_estado, r.status, r.id_estado FROM estado e INNER JOIN vehiculo_estado r ON e.id_estado=r.id_estado WHERE r.patente='" & Label1.Text & "';"


        ReDim General.consultaVector(2)

        General.consultaVector(0) = "nombre_estado"
        General.consultaVector(1) = "id_estado"
        General.consultaVector(2) = "status"
        ReDim General.estadosv(0, 0)
        'Igualamos la matriz donde se quieren guardar los datos  con la funcion General.recuperar(sql)
        General.estadosv = General.recuperar(Sql)

        For i = 0 To General.estadosv.GetUpperBound(1)
            ComboBox1.Items.Add(General.estadosv(0, i))
            If General.estadosv(2, i) = "True" Then
                ComboBox1.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "UPDATE vehiculo_estado  SET status = 0 WHERE patente='" & Label1.Text & "';"

        General.IngresarDatos(sql)

        sql = "UPDATE vehiculo_estado  SET status = 1 WHERE id_estado='" & General.estadosv(1, ComboBox1.SelectedIndex) & "' AND patente='" & Label1.Text & "';"

        General.IngresarDatos(sql)

        VerEstado1.mostrar()
    End Sub
End Class