Public Class Form1
    'Variables a utilizar
    Dim sql As String
    Dim nu = 1
    Dim nn = 1
    Dim na = 1
    Dim ne = 1
    Dim a = 1
    Dim ass = 1
    Dim pa = 1
    Dim au = 1
    Dim m = 1
    Dim control As Boolean


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = True
        inicio.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If nn = 1 Then
            IngresoClientes.RecuperarRegion()
        End If
        nn = 2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = True
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If nu = 1 Then
            IngresoVehiculo.RecuperarTipos()
            IngresoVehiculo.RecuperarMarcas()
            IngresoVehiculo.RecuperarRut()
            IngresoVehiculo.RecuperarAseguradora()
            nu = 2
        End If
        nu = nu - 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        inicio.Visible = False
        ordendecompra.Visible = True
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        ordenCompra.cargarDiagnosticos()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = True
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If m = 1 Then
            VerEstado1.mostrar()
        End If
        m = 2
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)
        ' inicio.Visible = False
        ' ordendecompra.Visible = False
        ' Vehiculo.Visible = False
        ' Ingresocliente.Visible = False
        ' Editarestado.Visible = True
        'Papelera.Visible = False
        ' verestado.Visible = False
        'Diagnostico.Visible = False
        'Diagnostico3.Visible = False
        ' diagnostico2.Visible = False
        ' editar.Visible = False
        ' editar2.Visible = False
        ' If a = 1 Then
        '' estadosAsignados_Load()
        'uperarestado()
        'estadosAsignados_Load()
        ' End If

        'a = 2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = True
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If pa = 1 Then
            Papelera1.CargarPapelera()
            pa = 2
        End If
        pa = pa - 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False

    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Diagnostico.Visible = True
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        Diagnosticocodigo.cargarDiag1()

    End Sub
    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Diagnostico.Visible = False
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = True
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        DataGridView3.CommitEdit(True)
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Diagnostico.Visible = False
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = True
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub
    Private Sub PictureBox32_Click(sender As Object, e As EventArgs)
        'Diagnostico.Visible = False
        'inicio.Visible = False
        ' ordendecompra.Visible = False
        ' Vehiculo.Visible = False
        ' Ingresocliente.Visible = False
        ' Editarestado.Visible = False
        ' Papelera.Visible = False
        ' verestado.Visible = False
        ' Diagnostico3.Visible = False
        'diagnostico2.Visible = False
        ' editar.Visible = False
        'editar2.Visible = True
        '  If na = 1 Then
        'EditarClientes.RecuComuna()
        ' EditarClientes.RecuperarClientes()
        '  End If
        '  na = 2

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs)
        ' Diagnostico.Visible = False
        ' inicio.Visible = False
        ' ordendecompra.Visible = False
        'Vehiculo.Visible = False
        'Ingresocliente.Visible = False
        ' Editarestado.Visible = False
        'Papelera.Visible = False
        '' verestado.Visible = False
        ' Diagnostico3.Visible = False
        'diagnostico2.Visible = False
        ' editar.Visible = True
        'editar2.Visible = False
        ' If ne = 1 Then
        'tarVehiculos.recuCliente2()
        'EditarVehiculos.recutipo2()
        'EditarVehiculos.Recuperarvehiculo()
        ' End If
        ' ne = 2

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        modificarus.Visible = False
        editar2.Visible = False
        ot2.Visible = False

    End Sub


    Private Sub ParametroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametroToolStripMenuItem.Click
        Parametrosadmin.Show()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cambiocontraus.Show()
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        inicio.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = True
        ot2.Visible = False
        If au = 1 Then
            VistaUsuarios.verUsuarios()
        End If
        au = 2
    End Sub

    Private Sub PermisoAUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisoAUsuariosToolStripMenuItem.Click
        permisosusuario.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form3.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Form4.Show()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Form5.Show()
    End Sub

    Private Sub EditarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Editarus.Show()
    End Sub


    Private Sub AgregarModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarModeloToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub TipoVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoVehiculoToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub AgregarMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMarcaToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub AgregarAseguradoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarAseguradoraToolStripMenuItem.Click
        Form5.Show()
    End Sub


    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Diagnostico.Visible = True
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Diagnostico.Visible = False
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = True
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'SOLO NUMEROS 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf InStr(TextBox1.Text, "k") Then
            e.KeyChar = ""
        ElseIf InStr(TextBox1.Text, "K") Then
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

    Private Sub TextBox41_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox41.KeyPress
        'SOLO NUMEROS 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        'SOLO LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        'SOLO NUMEROS 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
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



    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        'SOLO LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        'SOLO LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        'SOLO NUMEROS 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox90_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox90.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox64_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox64.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox73_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox73.KeyPress
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

    Private Sub TextBox74_KeyPress(sender As Object, e As KeyPressEventArgs)
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


    Private Sub TextBox76_KeyPress(sender As Object, e As KeyPressEventArgs)
        'SOLO NUMEROS 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        'SOLO NUMEROS 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox5.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox70_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox70.KeyPress
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

    Private Sub TextBox60_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox60.KeyPress
        'SOLO NUMEROS
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox63_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox63.KeyPress
        'SOLO NUMEROS
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    '¨******************************************************************************************************************
    'Ingreso Vehículo

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        'Llamamos al Sub RecuperarModelos que se encuentra dentro del modulo Ingreso Vehiculo
        IngresoVehiculo.RecuperarModelos()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Llamamos al Sub IngresarVehiculo de el modulo Ingreso Vehiculo
        IngresoVehiculo.IngresarVehiculo()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Llamamos al Sub LimpiarCampoVehiculo de el modulo Ingreso Vehiculo
        IngresoVehiculo.LimpiarCampoVehículo()
    End Sub

    '**********************************************************************************************
    'Ingreso Cliente
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        IngresoClientes.RecuperarProvincia()
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged
        IngresoClientes.RecuperarComunas()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        IngresoClientes.IngresarCliente()
        Dim op As DialogResult = MessageBox.Show("¿Desea ingresar un nuevo vehículo?", "Ingreso Vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If op = DialogResult.Yes Then
            inicio.Visible = False
            ordendecompra.Visible = False
            Vehiculo.Visible = True
            Ingresocliente.Visible = False
            Editarestado.Visible = False
            Papelera.Visible = False
            verestado.Visible = False
            Diagnostico.Visible = False
            Diagnostico3.Visible = False
            diagnostico2.Visible = False
            editar.Visible = False
            editar2.Visible = False
            modificarus.Visible = False
            ot2.Visible = False
            If nu = 1 Then
                IngresoVehiculo.RecuperarTipos()
                IngresoVehiculo.RecuperarMarcas()
                IngresoVehiculo.RecuperarRut()
                IngresoVehiculo.RecuperarAseguradora()
            End If
            nu = 2
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Limpiamos todos los textBox y ComboBox 
        IngresoClientes.LimpiarCampoCliente()
    End Sub
    '**********************************************************************************************
    'Editar Cliente
    Private Sub EditarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarClienteToolStripMenuItem.Click
        Diagnostico.Visible = False
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = True
        modificarus.Visible = False
        ot2.Visible = False
        If na = 1 Then
            EditarClientes.RecuRegion()
            EditarClientes.RecuperarClientes()
            na = 2
        End If
        na = na - 1
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        'Limpiamos todos los textBox y ComboBox 
        EditarClientes.LimpiarCampos()
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        EditarClientes.RecuperacionDatos()
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        EditarClientes.Editar()
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        EditarClientes.Eliminar()
    End Sub


    '¨******************************************************************************************************************
    'Editar vehiculo
    Private Sub EditarVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarVehiculoToolStripMenuItem.Click
        Diagnostico.Visible = False
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = True
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If ne = 1 Then
            EditarVehiculos.recuCliente2()
            EditarVehiculos.recutipo2()
            EditarVehiculos.Recuperarvehiculo()
            ne = 2
        End If
        ne = ne - 1
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        EditarVehiculos.RecuperarDatos()
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        EditarVehiculos.Editar()
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        EditarVehiculos.Limpiar()
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        EditarVehiculos.Eliminar()
    End Sub


    '¨******************************************************************************************************************
    'CODIGO SHELO
    Private Sub EditarEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEstadoToolStripMenuItem.Click
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = True
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If a = 1 Then
            '' estadosAsignados_Load()
            'uperarestado()
            Shelo.estadosAsignados_Load()
        End If

        a = 2
    End Sub
    Private Sub DataGridView4_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView4.MouseUp
        Shelo.mause()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Form8.Show()
        'ass = 2
        'If ComboBox5.Text <> "" Then
        'DataGridView4.ClearSelection()
        'ass = 1
        'Shelo.revisar()
        'Shelo.agregarmas()
        'End If
        'Shelo.revisar()
        'Shelo.agregarmas()

    End Sub

    Private Sub ComboBox5_TextChanged_1(sender As Object, e As EventArgs) Handles ComboBox5.TextChanged
        If ComboBox5.Text = "" Then
            Shelo.revisar()
        End If
        DataGridView4.Rows.Clear()
        Shelo.revisar()
    End Sub

    Private Sub AgregarEstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEstadosToolStripMenuItem.Click
        Form7.Show()
    End Sub

    '¨******************************************************************************************************************
    'Papelera
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Papelera1.botonVaciar()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Papelera1.botonRestaurar()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Papelera1.botonEliminar()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    Private Sub PictureBox12_Click_1(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Diagnostico.Visible = False
        inicio.Visible = True
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
    End Sub

    '¨******************************************************************************************************************
    'Reportes
    Private Sub VerVehículoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerVehículoToolStripMenuItem.Click
        VerVehiculos.Show()
    End Sub

    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click
        VerClientes.Show()
    End Sub

    Private Sub VerEstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerEstadosToolStripMenuItem.Click
        Vre.Show()
    End Sub

    '¨******************************************************************************************************************
    'Modificar Usuarios

    Private Sub botonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        VistaUsuarios.botonEliminar()
    End Sub

    Private Sub botonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        VistaUsuarios.botonEditar()
    End Sub

    Private Sub PictureBox32_Click_1(sender As Object, e As EventArgs) Handles PictureBox32.Click
        VistaUsuarios.botonNuevo()
    End Sub


    Private Sub TextBox90_TextChanged(sender As Object, e As EventArgs) Handles TextBox90.TextChanged
        VistaUsuarios.verUsuarios()
    End Sub
    '¨******************************************************************************************************************
    'Cambiar Estado
    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        CambiarEstado.Label1.Text = DataGridView2(1, DataGridView2.CurrentRow.Index).Value
        CambiarEstado.Show()
    End Sub


    '¨******************************************************************************************************************
    'Diagnostico

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedIndex > -1 Then
            Diagnosticocodigo.llenardatosclienteDiag1(ComboBox7.SelectedIndex)
        End If
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox16.SelectedIndexChanged
        If ComboBox16.SelectedIndex > -1 Then
            Diagnosticocodigo.llenardatosautodiag1(ComboBox16.SelectedIndex)
        End If
    End Sub

    Private Sub DataGridView3_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellValueChanged
        If DataGridView3.RowCount > 1 Then
            Diagnosticocodigo.sumasvalores()
            Diagnosticocodigo.valorestotales()
        End If
    End Sub

    Private Sub TextBox53_TextChanged(sender As Object, e As EventArgs) Handles TextBox53.TextChanged
        Try
            If CInt(TextBox53.Text) > 0 Then
                Diagnosticocodigo.valorestotales()
            End If
        Catch ex As Exception
            TextBox53.Text = 0
        End Try
    End Sub

    Private Sub TextBox52_TextChanged(sender As Object, e As EventArgs) Handles TextBox52.TextChanged
        Try
            If CInt(TextBox52.Text) > 0 Then
                Diagnosticocodigo.valorestotales()
            End If
        Catch ex As Exception
            TextBox52.Text = 0
        End Try
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        If CheckBox1.Checked = True Then
            Diagnosticocodigo.guardarDiag(1)
        Else
            Diagnosticocodigo.guardarDiag(0)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Show()
    End Sub



    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        ordendecompra.Visible = False
        Vehiculo.Visible = False
        Ingresocliente.Visible = True
        inicio.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If nn = 1 Then
            IngresoClientes.RecuperarRegion()
        End If
        nn = 2
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = True
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
        ot2.Visible = False
        If nu = 1 Then
            IngresoVehiculo.RecuperarTipos()
            IngresoVehiculo.RecuperarMarcas()
            IngresoVehiculo.RecuperarRut()
            IngresoVehiculo.RecuperarAseguradora()
        End If
        nu = 2
    End Sub

    '¨******************************************************************************************************************
    'Cambiar Contraseña Usuario
    Private Sub CambiarContraseñaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem1.Click
        Cambiocontraus.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Text = General.usuario(1, 0)
        sql = "SELECT * FROM permisos WHERE usuario='" & General.usuario(0, 0) & "';"
        ReDim General.consultaVector(9)
        General.consultaVector(0) = "administrador"
        General.consultaVector(1) = "reportes"
        General.consultaVector(2) = "editar"
        General.consultaVector(3) = "agregar"
        General.consultaVector(4) = "cliente"
        General.consultaVector(5) = "vehiculo"
        General.consultaVector(6) = "ot"
        General.consultaVector(7) = "diagnostico"
        General.consultaVector(8) = "papelera"
        General.consultaVector(9) = "estado"

        General.permisos = General.recuperar(sql)

        If General.permisos(0, 0) = "True" Then
            ToolStripMenuItem1.Enabled = True
        Else
            ToolStripMenuItem1.Enabled = False
        End If

        If General.permisos(1, 0) = "True" Then
            MenuStrip4.Enabled = True
        Else
            MenuStrip4.Enabled = False
        End If

        If General.permisos(2, 0) = "True" Then
            EditarClienteToolStripMenuItem.Enabled = True
            EditarEstadoToolStripMenuItem.Enabled = True
            EditarVehiculoToolStripMenuItem.Enabled = True
        Else
            EditarClienteToolStripMenuItem.Enabled = False
            EditarEstadoToolStripMenuItem.Enabled = False
            EditarVehiculoToolStripMenuItem.Enabled = False
        End If

        If General.permisos(3, 0) = "True" Then
            AgregarToolStripMenuItem.Enabled = True
        Else
            AgregarToolStripMenuItem.Enabled = False
        End If

        If General.permisos(4, 0) = "True" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

        If General.permisos(5, 0) = "True" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If

        If General.permisos(6, 0) = "True" Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If

        If General.permisos(7, 0) = "True" Then
            Button9.Enabled = True
        Else
            Button9.Enabled = False
        End If

        If General.permisos(8, 0) = "True" Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If

        If General.permisos(9, 0) = "True" Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If

    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox17.SelectedIndexChanged
        ordenCompra.cargarDatos(ComboBox17.Text)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        ot2.Visible = False
        ordendecompra.Visible = True
        inicio.Visible = False
        Vehiculo.Visible = True
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        ot2.Visible = True
        inicio.Visible = False
        ordendecompra.Visible = False
        Vehiculo.Visible = True
        Ingresocliente.Visible = False
        Editarestado.Visible = False
        Papelera.Visible = False
        verestado.Visible = False
        Diagnostico.Visible = False
        Diagnostico3.Visible = False
        diagnostico2.Visible = False
        editar.Visible = False
        editar2.Visible = False
        modificarus.Visible = False
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Dim respuesta As DialogResult
        If TextBox22.Text = "" Or TextBox3.Text = "" Or TextBox7.Text = "" Or TextBox17.Text = "" Then
            MessageBox.Show("Debe completar los datos de N° Orden, diagnóstico, KM y combustible antes de continuar ", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            respuesta = MessageBox.Show("¿Desea guardar esta orden de trabajo?", "Guardar orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                ordenCompra.guardarOT()
            End If
        End If
    End Sub
End Class
