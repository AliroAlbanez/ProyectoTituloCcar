Imports System.ComponentModel

Public Class Form2
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



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim op As DialogResult = MessageBox.Show("¿Desea agregar este modelo?", "Agregar Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            'Preparamos la sentencia sql a utilizar
            sql = "Insert into modelos(nombre_modelo,marca) values('" & TextBox1.Text & "','" & ComboBox1.Text & "');"
            General.IngresarDatos(sql) 'Utilizamos el Sub ingresarDatos con nuestra sentencia
            MsgBox("Operación Exitosa")
            'Limpiamos el campo de texto y el combobox 
            TextBox1.Clear()
            ComboBox1.Text = ("")
        End If
    End Sub

    Public Sub RecuperarMarcas()
        sql = "Select * from marcas" 'Preparamos la sentencia a utilizar
        ReDim General.consultaVector(0) 'Redimensionamos consultavector con la cantidad de datos necesitados
        General.consultaVector(0) = "nombre_marca"
        General.marca = General.recuperar(sql) 'Igualamos la matriz donde almacenaremos los datos con la funcion General.recuperar
        For i = 0 To General.marca.GetUpperBound(1) 'Ciclo for para recorrer la matriz que se igualo anteriormente
            ComboBox1.Items.Add(General.marca(0, i)) 'Cargamos los datos de nuestra base de datos al comboBox 
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecuperarMarcas() 'Llamado de sub
    End Sub

End Class