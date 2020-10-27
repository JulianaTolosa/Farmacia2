Imports CapaComun
Imports Dominio

Public Class Editarempleado
    Public _UsuarioPorEditar As Usuario

    Public Sub Mostrar(_Usuario As Usuario)

        If _Usuario Is Nothing Then
            MsgBox("Error al obtener el Usuario")
            Me.Hide()
            Exit Sub
        End If

        _UsuarioPorEditar = _Usuario
        SetearDatos()
        Me.Show()
    End Sub




    Private Sub btnCerrarForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub SetearDatos()
        'Editar
        Txtnomusuario.Text = _UsuarioPorEditar._NombreUsuario
        Txtnombre.Text = _UsuarioPorEditar._Nombre
        Txtapellido.Text = _UsuarioPorEditar._Apellido
        Txtcorreo.Text = _UsuarioPorEditar._Correo
    End Sub

    


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            _UsuarioPorEditar._NombreUsuario = Txtnomusuario.Text
            _UsuarioPorEditar._Nombre = Txtnombre.Text
            _UsuarioPorEditar._Apellido = Txtapellido.Text
            _UsuarioPorEditar._Correo = Txtcorreo.Text
            If _UsuarioPorEditar.Guardar() Then
                Empleados.RefrescarListaEmpleados()
                Me.Hide()
            Else
                MsgBox("Error al Guardar")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Hide()
    End Sub


End Class