Imports System.ComponentModel

Public Class Form5
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

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim op As DialogResult = MessageBox.Show("¿Desea agregar esta empresa de seguro?", "Agregar seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            'Preparamos la sentencia sql a utilizar
            sql = "Insert into empresa_seguro(nombre_empresa,vis,user) values('" & TextBox1.Text & "','1','alonso');"
            General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            MsgBox("Operación Exitosa")
            'Limpiamos el campo de texto y el combobox 
            TextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        'SOLO NUMEROS 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IngresoVehiculo.RecuperarAseguradora()
    End Sub
End Class