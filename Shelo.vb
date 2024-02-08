Module Shelo

    Dim sql As String
    Dim nu = 1
    Dim nn = 1
    Dim na = 1
    Dim ne = 1
    Dim a = 1
    Dim ass = 1
    Dim control As Boolean
    Public Sub estadosAsignados_Load()

        ''Private Sub estadosAsignados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'preparar el sql a consultar
        sql = "SELECT id_estado, nombre_estado, descripcion FROM estado WHERE vis=1;"
        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(2)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "id_estado"
        General.consultaVector(1) = "nombre_estado"
        General.consultaVector(2) = "descripcion"

        ReDim General.estados(3, 0)
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        General.estados = General.recuperar(sql)

        'Creamos las nuevas columnas para los diferentes estados agregados
        If General.estados(0, 0) <> "" Then
            For i = 0 To General.estados.GetUpperBound(1)
                Dim col As New DataGridViewCheckBoxColumn()
                col.HeaderText = General.estados(1, i)
                col.Name = General.estados(1, i)
                col.ReadOnly = False

                Form1.DataGridView4.Columns.Add(col)

            Next

        End If
        revisar()
        agregarmas()



        Form1.DataGridView4.AutoResizeColumns()

        control = True


    End Sub
    Public Sub agregarmas()
        If General.estado(0, 0) <> "" Then
            Dim fila As Integer

            For i = 0 To General.estado.GetUpperBound(1)
                fila = 0
                If Form1.DataGridView4.RowCount > 0 Then
                    'revisar si la patente a ingresar existe ya en la tabla
                    For j = 0 To Form1.DataGridView4.RowCount - 1
                        If Form1.DataGridView4(1, j).Value = General.estado(1, i) Then
                            'revisar estados para recuperar indice
                            For h = 0 To General.estados.GetUpperBound(1)
                                If General.estados(0, h) = estado(2, i) Then
                                    'marcar como real el valor del indice
                                    Form1.DataGridView4(h + 2, j).Value = 1
                                    fila = 1
                                End If
                            Next
                        End If
                    Next
                End If
                If fila = 0 Then
                    Dim x As Integer
                    Form1.DataGridView4.RowCount = Form1.DataGridView4.RowCount + 1
                    x = Form1.DataGridView4.RowCount - 1
                    For j = 0 To 1
                        Form1.DataGridView4(j, x).Value = General.estado(j, i)
                    Next
                    For h = 0 To General.estados.GetUpperBound(1)
                        If General.estados(0, h) = estado(2, i) Then
                            'marcar como real el valor del indice
                            Form1.DataGridView4(h + 2, x).Value = True
                        End If
                    Next
                End If
            Next

        End If
    End Sub
    Public Sub revisar()
        control = False
        Dim hola = Form1.ComboBox5.Text

        'RECUPERAR VEHICULOS CON ESTADOS
        'preparar el sql a consultar
        'sql = "SELECT e.patente, e.id_estado, c.rut FROM vehiculo_estado e INNER JOIN vehiculo v ON v.patente=e.patente INNER JOIN cliente c ON v.rut_asociado=c.rut WHERE v.vis=1 AND c.vis=1;"
        If hola = "" Then
            sql = "SELECT e.patente, e.id_estado, c.rut FROM vehiculo_estado e INNER JOIN vehiculo v ON v.patente=e.patente INNER JOIN cliente c ON v.rut_asociado=c.rut WHERE v.vis=1 AND c.vis=1;"
            agregarmas()
        ElseIf hola <> "" Then
            sql = "SELECT e.patente, e.id_estado, c.rut FROM vehiculo_estado e INNER JOIN vehiculo v ON v.patente=e.patente INNER JOIN cliente c ON v.rut_asociado=c.rut WHERE v.vis=1 AND c.vis=1 AND v.patente LIKE '%" & hola & "%';"
            agregarmas()
            'sql = "SELECT e.patente, e.id_estado, c.rut FROM vehiculo_estado e INNER JOIN vehiculo v ON v.patente=e.patente INNER JOIN cliente c ON v.rut_asociado=c.rut WHERE e.patente ='" & hola & "' AND v.vis=1 AND c.vis=1;"
        End If

        'redimensionar consultaVector a la cantidad de datos que se necesita -1 (por el indice 0)
        ReDim General.consultaVector(2)
        'anotar los mismos nombres que se piden en el sql a cada espacio del vector
        General.consultaVector(0) = "rut"
        General.consultaVector(1) = "patente"
        General.consultaVector(2) = "id_estado"
        ReDim General.estado(2, 0)
        'Igualar la matriz donde se quieren guardar los datos con la funcion General.recuperar(sql)
        General.estado = General.recuperar(sql)


    End Sub
    Public Sub mause()
        ' If control = True Then 'control para evitar la comparación cuando carga la tabla
        Dim columna As Integer
            Dim fila As Integer
            Dim esta As Boolean
            esta = False
            columna = Form1.DataGridView4.CurrentCell.ColumnIndex
            fila = Form1.DataGridView4.CurrentCell.RowIndex

            If columna > 1 Then 'asegura que se trata de fila de permisos
                If Form1.DataGridView4.CurrentCell.EditedFormattedValue = True Then 'lo que hace si se otorga el permiso
                    For i = 0 To General.estado.GetUpperBound(1) 'revisa en la matriz estado
                        'Busca coincidencias entre patentes y estado para no repetir
                        If Form1.DataGridView4(1, fila).Value.ToString = General.estado(1, i) And estado(2, i) = estados(0, columna - 2) Then
                            esta = True 'si existe deja la variable en true para poder trabajar y evitar la repeticion de registro
                        End If
                    Next

                    If esta Then 'evitamos la repetición
                    Else
                    sql = "INSERT INTO `vehiculo_estado`(`patente`, `id_estado`, `user`) VALUES ('" & Form1.DataGridView4(1, fila).Value & "','" & General.estados(0, columna - 2) & "','" & General.nom & "');"
                    General.IngresarDatos(sql)
                        revisar()
                        control = True
                    End If

                Else
                    sql = "DELETE FROM `vehiculo_estado` WHERE patente='" & Form1.DataGridView4(1, fila).Value & "' AND id_estado='" & General.estados(0, columna - 2) & "';"
                    General.IngresarDatos(sql)
                    revisar()
                    control = True
                End If
            End If
        ' End If
    End Sub
    Public Sub INSERTARRRR()

    End Sub
End Module
