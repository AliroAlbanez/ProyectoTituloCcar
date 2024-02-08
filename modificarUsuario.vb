Public Class modificarUsuario
    Public cambio As String
    Dim sql As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim caracteres As String = "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM"
        Dim vectordecaracteres() As Char = caracteres.ToCharArray
        Dim numAleatorio As New Random()
        Dim clave As String
        For i = 0 To 5
            clave = clave & vectordecaracteres(numAleatorio.Next(0, caracteres.Length - 1))
        Next
        TextBox3.Text = clave
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim num As Integer
        Dim nuevo As Integer
        If CheckBox1.Checked Then
            nuevo = 1
        Else
            nuevo = 0
        End If

        If CheckBox2.Checked Then
            num = 5
        Else
            num = 0
        End If

        If cambio <> "" Then
            sql = "UPDATE `usuario` SET `rut`='" & TextBox1.Text & "',`nombre`='" & TextBox2.Text & "',`apellidos`='" & TextBox4.Text & "',`clave`='" & TextBox3.Text & "',`user`='" & General.usuario(0, 0) & "',`nuevo`=" & nuevo & " ,`intentos`=" & num & " WHERE rut='" & cambio & "';"
            General.IngresarDatos(sql)
            MsgBox("Cambios realizados con exito")
        Else
            sql = "INSERT INTO `usuario`(`rut`, `nombre`, `apellidos`, `clave`, `user`, `nuevo`, `intentos`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & General.usuario(0, 0) & "'," & nuevo & "" & num & ");"
            General.IngresarDatos(sql)
            MsgBox("Nuevo usuario exitoso")
        End If

    End Sub
End Class