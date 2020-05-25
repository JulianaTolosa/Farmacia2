Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilidades.SetearCadenaConexion()
        If My.Settings.Id > 0 Then
            Utilidades._UsuarioLogueado = Datos.ObtenerUsuario(My.Settings.Id)
            If Utilidades._UsuarioLogueado Is Nothing Then
                Utilidades.SetearIdDeMySettings(0)
            Else
                FormPrincipal.Show()
            End If
        Else
            Login.Show()
        End If
        Me.Close()
    End Sub
End Class