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
        'vista
        'Lblusuario.Text = ActiveUser.nombreusuario
        'LblNombre3.Text = ActiveUser.Nombre
        'Lblapellido3.Text = ActiveUser.Apellido
        'Lblcorreo3.Text = ActiveUser.Correo
        'Lblposicion3.Text = ActiveUser.Posicion

        'Editar
        Txtnomusuario.Text = _UsuarioPorEditar._NombreUsuario
        Txtnombre.Text = _UsuarioPorEditar._Nombre
        Txtapellido.Text = _UsuarioPorEditar._Apellido
        Txtcorreo.Text = _UsuarioPorEditar._Correo
    End Sub

    'Public Sub initializeControlsEditPass()
    '    Lkllbleditar.Text = "EDITAR"
    '    Txtcontrasena.UseSystemPasswordChar = True
    '    Txtcontrasena.Enabled = False
    '    Txtconfirmar.UseSystemPasswordChar = True
    '    Txtconfirmar.Enabled = False
    '    Txtactualcontrasena.Text = ""
    'End Sub

    'Private Sub reset()
    '    loadUserData()
    '    initializeControlsEditPass()
    'End Sub


    'Private Sub Editarempleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    loadUserData()
    '    initializeControlsEditPass()
    'End Sub

    'Private Sub Lkllbleditar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    If Lkllbleditar.Text = "EDITAR" Then
    '        Lkllbleditar.Text = "CANCELAR"
    '        Txtcontrasena.Enabled = True
    '        Txtcontrasena.Text = ""
    '        Txtconfirmar.Enabled = True
    '        Txtconfirmar.Text = ""
    '    ElseIf Lkllbleditar.Text = "CANCELAR" Then
    '        reset()
    '    End If
    'End Sub

    'Private Sub LkllblEditarperfil_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    Panelder.Visible = True
    '    loadUserData()
    'End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        'If Txtcontrasena.Text = Txtconfirmar.Text Then
        '    If Txtactualcontrasena.Text = Utilidades._UsuarioLogueado._Contraseña Then

        '        Dim user As New user(idusuario:=Utilidades._UsuarioActivo.idusuario,
        '                               nombreusuario:=Txtnomusuario.Text,
        '                               Contrasena:=Txtcontrasena.Text,
        '                               Nombre:=Txtnombre.Text,
        '                               Apellido:=Txtapellido.Text,
        '                               Posicion:=Nothing,
        '                               Correo:=Txtcorreo.Text)
        '        Dim result = user.editUserProfile()
        '        MessageBox.Show(result)
        '        reset()
        '        Panelder.Visible = False
        '    Else
        '        MessageBox.Show("Contraseña actual incorrecta")
        '    End If
        'Else
        '    MessageBox.Show("Las contraseñas no coinciden,por favor intente nuevamente")
        'End If
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