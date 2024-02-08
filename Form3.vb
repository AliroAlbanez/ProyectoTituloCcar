Imports System.ComponentModel

Public Class Form3
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

    'Agregar marca
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim op As DialogResult = MessageBox.Show("¿Desea agregar este marca?", "Agregar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            sql = "Insert into marcas(nombre_marca) values('" & TextBox1.Text & "');" 'Preparamos la sentencia a utilizar
            General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            MsgBox("Operación Exitosa")
            'Limpiamos el campo de texto
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IngresoVehiculo.RecuperarMarcas()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class