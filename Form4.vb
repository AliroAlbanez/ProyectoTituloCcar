Imports System.ComponentModel

Public Class Form4
    Dim sql As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'SOLO LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim op As DialogResult = MessageBox.Show("¿Desea agregar este modelo?", "Agregar Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            'Preparamos la sentencia sql a utilizar
            sql = "Insert into tipos(nombre_tipo) values('" & TextBox1.Text & "');"
            General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            MsgBox("Operación Exitosa")
            TextBox1.Clear() 'Limpiamos el campo de texto 
        End If
    End Sub


    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IngresoVehiculo.RecuperarTipos()
    End Sub
End Class