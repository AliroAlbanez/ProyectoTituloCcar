Imports MySql.Data.MySqlClient
Module General
    'variables de conexion y consultas
    Dim Configuracion_conexion As String = "server=localhost;database=as;user id=root;password=;port=3306; SslMode=none"
    Dim Conexion As New MySqlConnection(Configuracion_conexion)
    Public dr As MySqlDataReader
    Public dr2 As MySqlDataReader

    'matrices para acumulacion de datos
    Public usuario(4, 0) As String
    Public usuarios(4, 0) As String
    Public papelera(6, 0) As String
    Public consultaVector(0) As String
    Public atras As Boolean = True
    Public editar As Integer
    Public marca(6, 0) As String
    Public modelo(6, 0) As String
    Public tipo(6, 0) As String
    Public region(6, 0) As String
    Public comuna(6, 0) As String
    Public cliente(9, 0) As String
    Public provincia(3, 0) As String
    Public autos(5, 0) As String
    Public seguro(5, 0) As String
    Public clientes(0, 0) As String
    Public vehiculos(0, 0) As String
    Public permisos(0, 0) As String
    Public nom As String
    'VARIABLES SHELO
    Public patente(6, 0) As String
    Public autoss(6, 0) As String
    Public Marcad(6, 0) As String
    Public Ecab(6, 0) As String
    Public estados(6, 0) As String
    Public estado(6, 0) As String
    Public acab(55, 0) As String
    Public hola(6, 0) As String
    'Variable M
    Public vrestado(2, 0) As String
    Public estadosv(0, 0) As String
    Public estadoc(0, 0) As String
    'Funciones y subs de consulta e ingreso de datos
    Public Function consultar(ByVal sql) As MySqlDataReader 'Funcion de consulta que retorna un reader para poder ocuparlo donde mas acomode
        Dim cm As MySqlCommand
        If Not Conexion Is Nothing Then Conexion.Close()
        Try
            Conexion.Open()

            cm = New MySqlCommand()
            cm.CommandText = sql
            cm.CommandType = CommandType.Text
            cm.Connection = Conexion
            Return cm.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Servidor fuera de línea, consulte con su administrador", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub ModificarDatos(ByVal sql)
        Dim MOdificar As New MySqlCommand(sql, Conexion)
        Try
            If Not Conexion Is Nothing Then Conexion.Close()
            Conexion.Open()
            MOdificar.ExecuteNonQuery()
        Catch


        End Try
        Conexion.Close()
    End Sub

    Public Sub IngresarDatos(ByVal sql)
        Dim insertar As New MySqlCommand(sql, Conexion)
        Try
            If Not Conexion Is Nothing Then Conexion.Close()
            Conexion.Open()
            insertar.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Dato repetido, compruebe que el registro no exista con anterioridad", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Conexion.Close()
    End Sub

    Public Function fechasVoltear(ByVal fecha) As String
        Dim nuevaFecha As String

        Dim delimitadores() As String = {"-", " "}
        Dim vectoraux() As String
        vectoraux = fecha.Split(delimitadores, StringSplitOptions.None)
        nuevaFecha = vectoraux(2) + "-" + vectoraux(1) + "-" + vectoraux(0)
        Return nuevaFecha
    End Function

    Public Function fechasAcotar(ByVal fecha) As String
        Dim nuevaFecha As String

        Dim delimitadores() As String = {"-", " ", ":"}
        Dim vectoraux() As String
        vectoraux = fecha.Split(delimitadores, StringSplitOptions.None)
        nuevaFecha = vectoraux(0) + "-" + vectoraux(1) + "-" + vectoraux(2) + "-" + vectoraux(3) + "-" + vectoraux(4) + vectoraux(5) + vectoraux(6)
        Return nuevaFecha
    End Function

    Public Function recuperar(ByVal sql)
        Dim num As Integer = 0 'contador para al fila
        dr = consultar(sql)
        Dim lVector As Integer = consultaVector.GetUpperBound(0) 'ultimo indice del vector para poder usar la matriz a voluntad
        Dim solu(lVector, num) As String 'se redimensiona al inicial para que se borren todos los datos
        While dr.Read()
            ReDim Preserve solu(lVector, num) 'se redimensiona solo las columnas preservando los datos por lo que el numero de fila no se puede editar
            For i = 0 To lVector
                solu(i, num) = dr(consultaVector(i)).ToString()
            Next
            num = num + 1

        End While
        Conexion.Close()
        Return solu 'devuelve la matriz llenada con los datos recuperados
    End Function


    'CODIGO SHELO
    Public Sub Recuperarpatentse(ByVal A)

        Dim num As Integer = 0
        Dim sql As String
        ReDim patente(3, num)
        If A = "" Then
            sql = "SELECT Patente FROM vehiculo_estado;"
        End If
        sql = "SELECT patente FROM vehiculo  WHERE patente LIKE '%" & A & "%';"
        patente(0, num) = ""
        dr = consultar(sql)
        While dr.Read()


            ReDim Preserve patente(3, num)
            patente(0, num) = dr("Patente").ToString()


            num = num + 1
        End While
        Conexion.Close()
    End Sub
    Public Sub RecuperarEstados()
        Dim num As Integer = 0

        ReDim Ecab(3, num)
        Dim sql As String = "SELECT Id, Nombre_Estado FROM estado;"
        dr = consultar(sql)
        While dr.Read()

            ReDim Preserve Ecab(3, num)
            Ecab(0, num) = dr("Id").ToString()
            Ecab(1, num) = dr("Nombre_Estado").ToString()


            num = num + 1
        End While
        Conexion.Close()
    End Sub
    'End Sub

    Public Sub Exportar(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        'Se crea una nueva hoja de calculo
        Dim xlwB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlwB.Worksheets(1)

        'Exportamos los caracteres de las columnas
        For c As Integer = 0 To dgv.Columns.Count - 1
            xlWS.cells(1, c + 1).value = dgv.Columns(c).HeaderText
        Next

        'Exportamos las cabeceras de columnas
        For r As Integer = 0 To dgv.RowCount - 1
            For c As Integer = 0 To dgv.Columns.Count - 1
                xlWS.cells(r + 2, c + 1).value = dgv.Item(c, r).Value
            Next
        Next

        'Guardamos la hoja de calculo en la ruta especifada
        Try
            xlwB.saveas(pth)
            xlWS = Nothing
            xlWS = Nothing
            xlApp.quit()
            xlApp = Nothing
        Catch ex As Exception

        End Try
    End Sub

End Module
