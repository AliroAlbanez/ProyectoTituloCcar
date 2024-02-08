Public Class Form8
    Dim sql
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecuperarEstados()
    End Sub

    Public Sub RecuperarEstados()
        sql = "SELECT id_estado, nombre_estado ,descripcion  FROM estado Where vis=1"
        ReDim General.consultaVector(2)
        General.consultaVector(0) = "id_estado"
        General.consultaVector(1) = "nombre_estado"
        General.consultaVector(2) = "descripcion"
        General.estados = General.recuperar(sql)
        For i = 0 To General.estados.GetUpperBound(1)
            ComboBox5.Items.Add(General.estados(1, i))

        Next
    End Sub

    Public Sub RecuperarDatos()
        For i = 0 To General.estados.GetUpperBound(1)
            Dim rata = ComboBox5.Text
            If rata = General.estados(1, i) Then
                TextBox1.Text = (General.estados(2, i)) 'propietario

            End If

        Next
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        RecuperarDatos()
    End Sub
End Class