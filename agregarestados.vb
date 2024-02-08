Public Class Form7
    Dim Sql As String
    Dim nombre, descripcion As String
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        nombre = TextBox6.Text
        descripcion = TextBox1.Text
        Dim op As DialogResult = MessageBox.Show("¿Desea agregar este marca?", "Agregar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            Sql = "Insert into estado(nombre_estado, descripcion) values('" & nombre & "','" & descripcion & "');" 'Preparamos la sentencia a utilizar
            General.IngresarDatos(Sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            MsgBox("Operación Exitosa")
            'Limpiamos el campo de texto
            TextBox6.Clear()
            TextBox1.Clear()
        End If
    End Sub
End Class