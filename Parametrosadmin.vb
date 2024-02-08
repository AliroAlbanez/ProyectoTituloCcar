Public Class Parametrosadmin
    Dim sql As String

    Private Sub Parametrosadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extraer()
    End Sub
    Public Sub extraer()
        Sql = "SELECT nombre_parametro,valor FROM parametros; "

        ReDim General.consultaVector(1)

        General.consultaVector(0) = "nombre_parametro"
        General.consultaVector(1) = "valor"



        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        General.hola = General.recuperar(Sql)
        TextBox1.Text = General.hola(1, 0)
        TextBox2.Text = General.hola(1, 1)

    End Sub

    Public Sub modificar()
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea guardar los cambios en los permisos?", "Cambio de permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If respuesta = DialogResult.Yes Then

            sql = "UPDATE parametros SET valor='" & TextBox1.Text & "' WHERE nombre_parametro='iva';"
            General.ModificarDatos(sql)


            sql = "UPDATE parametros SET valor='" & TextBox2.Text & "' WHERE nombre_parametro='UF';"
            General.ModificarDatos(sql)
            MessageBox.Show("Permisos guardados con éxito", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        modificar()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 
        Form1.Show()
    End Sub

End Class