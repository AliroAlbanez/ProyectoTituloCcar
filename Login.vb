Public Class Login
    Dim sql As String 'variable para el sql 
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'preparar el sql que utilizaremos para consultar y hacer la verificacion del usuario
        sql = "SELECT * from usuario WHERE usuario.rut='" & TextUsuario.Text & "' AND usuario.clave='" & TextPassword.Text & "' AND usuario.vis=1 AND usuario.intentos < 5;"
        'redimension consultaVector a la cantidad de datos que se necesita
        ReDim General.consultaVector(2)
        General.consultaVector(0) = "rut"
        General.consultaVector(1) = "nombre"
        General.consultaVector(2) = "clave"
        'Igualamos la matriz donde se quieren guardar los datos  con la funcion General.recuperar(sql)
        General.usuario = General.recuperar(sql)
        General.nom = General.usuario(1, 0)

        'si el usuario y contraseña coinciden ingresa al sistema y muestra la ventana del menu
        If General.usuario(0, 0) <> "" Then
            sql = "UPDATE usuario SET intentos = 0 WHERE usuario.rut= '" & TextUsuario.Text & "';"
            General.IngresarDatos(sql)
            Form1.Show()
            Me.Hide()
            TextUsuario.Text = ""
            TextPassword.Text = ""
            'si no se logra ingresar al sistema alteramos la tabla usuarios el campo de intentos +1
            'esto para controlar que solo puedan equivocarce 5 veces
        Else
            sql = "UPDATE usuario SET intentos = intentos + 1 WHERE usuario.rut= '" & TextUsuario.Text & "';"
            General.IngresarDatos(sql)
            'se muestra un mensaje por pantala al usuario que la contraseña o el usuario e incorrecto
            MessageBox.Show("Usuario o Contraseña incorrectos.", " Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextPassword.Text = ""
            'si el campo que acumula los intentos de ingresos es igual a 5 se necesita del administrados para restablecer la contraseña
        End If
    End Sub

    Private Sub TextUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUsuario.KeyPress
        'SOLO NUMEROS Y CARCATER 'K' O 'k'
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf InStr(TextUsuario.Text, "k") Then
            e.KeyChar = ""
        ElseIf InStr(TextUsuario.Text, "K") Then
            e.KeyChar = ""
        ElseIf e.KeyChar = "K" Then
            e.Handled = False
        ElseIf e.KeyChar = "k" Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPassword.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class