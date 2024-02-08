Module Papelera1
    Dim sql As String
    Public Sub CargarPapelera()
        'preparar el sql a consultar
        sql = "SELECT id_papelera, id_eliminado, nombre_primary, identificacion, entidad, date FROM papelera"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(5)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(5) = "id_papelera"
        General.consultaVector(0) = "id_eliminado"
        General.consultaVector(4) = "nombre_primary"
        General.consultaVector(1) = "identificacion"
        General.consultaVector(2) = "entidad"
        General.consultaVector(3) = "date"
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        ReDim General.papelera(5, 0)
        General.papelera = General.recuperar(sql)
        Form1.DataGridView1.Rows.Clear() 'se eliminan todas las filas para que no quede una en registro
        'MsgBox(General.papelera(0, 0)) PORSISEMEOLVIDA
        If General.papelera(0, 0) <> "" Then 'solo basta con que la primera fila se avacio para saber que no hay datos encontrados
            Form1.PictureBox10.Enabled = True
            Form1.PictureBox8.Enabled = True
            Form1.PictureBox9.Enabled = True
            For i = 0 To General.papelera.GetUpperBound(1)
                Form1.DataGridView1.RowCount = i + 1
                For j = 0 To Form1.DataGridView1.ColumnCount - 1
                    Form1.DataGridView1(j, i).Value = General.papelera(j, i)
                Next

            Next
        Else
            Form1.PictureBox10.Enabled = False
            Form1.PictureBox8.Enabled = False
            Form1.PictureBox9.Enabled = False
        End If
    End Sub

    Public Sub botonEliminar()
        Dim respu As DialogResult = MessageBox.Show("ADVERTENCIA: ¿Desea eliminar permanentemente este registro?", "Eliminar Permanente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If respu = 1 Then
            Dim num As Integer
            num = Form1.DataGridView1.CurrentRow.Index
            eliminarPapelera(General.papelera(5, num))
            eliminarObjeto(General.papelera(0, num), General.papelera(4, num), General.papelera(2, num))
            CargarPapelera()
        End If
    End Sub

    Public Sub eliminarPapelera(ByVal idp)
        sql = "DELETE FROM `papelera` WHERE id_papelera='" & idp & "';"
        General.IngresarDatos(sql)
    End Sub

    Public Sub eliminarObjeto(ByVal idel, ByVal npry, ByVal enti)
        sql = "DELETE FROM `" & enti & "` WHERE " & npry & "='" & idel & "';"
        General.IngresarDatos(sql)
    End Sub

    Public Sub restaurarObjeto(ByVal idel, ByVal npry, ByVal enti)
        sql = "UPDATE `" & enti & "` SET vis=1 WHERE " & npry & "='" & idel & "';"
        General.IngresarDatos(sql)
    End Sub

    Public Sub botonRestaurar()
        Dim respu As DialogResult = MessageBox.Show("¿Desea restaurar este registro?", "Restaurar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If respu = 1 Then
            Dim num As Integer
            num = Form1.DataGridView1.CurrentRow.Index
            eliminarPapelera(General.papelera(5, num))
            restaurarObjeto(General.papelera(0, num), General.papelera(4, num), General.papelera(2, num))
            CargarPapelera()
        End If
    End Sub

    Public Sub botonVaciar()
        Dim respu As DialogResult = MessageBox.Show("ADVERTENCIA: ¿Desea eliminar permanentemente todos los registros?", "Eliminar Permanente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If respu = 1 Then
            For i = 0 To Form1.DataGridView1.RowCount - 1
                eliminarPapelera(General.papelera(5, i))
                eliminarObjeto(General.papelera(0, i), General.papelera(4, i), General.papelera(2, i))
            Next
            CargarPapelera()
        End If
    End Sub

End Module
