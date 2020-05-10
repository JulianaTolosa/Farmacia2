Module Utilidades
    Public ConnectionString = My.MySettings.Default.TesisConnectionString

    Public Function ExisteUsuario(NombreUsuario As String) As Boolean
        Dim _Retorno As Boolean = False

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM Usuario WHERE nombreusuario=@NombreUsuario"
        _Consulta.AgregarParametro("@NombreUsuario", NombreUsuario)
        Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
        If _Resultado.Rows.Count > 0 Then
            _Retorno = True
        End If

        Return _Retorno
    End Function

    Public Function AgregarUsuario(_Usuario As Usuario) As Boolean
        Dim _Retorno As Boolean = True


        'If IsNothing(_Usuario) Then
        '    Return False
        'End If
        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "  INSERT INTO Usuario"
            _Consulta.Consulta &= " (nombreusuario, Contrasena, Nombre, Apellido, Posicion, Correo)"
            _Consulta.Consulta &= " VALUES"
            _Consulta.Consulta &= " (@NombreUsuario, @Cont, @Nom, @Ape, @Pos, @Corr)"
            _Consulta.AgregarParametro("@NombreUsuario", _Usuario._NombreUsuario)
            _Consulta.AgregarParametro("@Cont", _Usuario._Contraseña)
            _Consulta.AgregarParametro("@Nom", _Usuario._Nombre)
            _Consulta.AgregarParametro("@Ape", _Usuario._Apellido)
            _Consulta.AgregarParametro("@Pos", _Usuario._Posicion)
            _Consulta.AgregarParametro("@Corr", _Usuario._Correo)

            _Consulta.Ejecutar()
        Catch ex As Exception
            _Retorno = False
        End Try

        Return _Retorno
    End Function

    Public Function ObtenerDataTableEmpleados() As DataTable
        Dim _Retorno As New DataTable

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM Usuario"
        _Retorno = _Consulta.ObtenerTabla()

        Return _Retorno
    End Function
End Module
