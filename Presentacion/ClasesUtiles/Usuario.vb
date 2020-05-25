Public Class Usuario
    Public _Id As Integer
    Public _NombreUsuario As String
    Public _Contraseña As String
    Public _Nombre As String
    Public _Apellido As String
    Public _Posicion As String
    Public _Correo As String

    'Sub New(NombreUsuario As String)
    '    _NombreUsuario = NombreUsuario
    'End Sub
    'Sub New()
    'End Sub

    Public Function Guardar() As Boolean
        Dim _Retorno As Boolean = False
        Try
            _Retorno = Datos.GuardarUsuario(Me)
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function





    'Public Function ObtenerNombre() As String
    '    Return _Nombre
    'End Function
End Class
