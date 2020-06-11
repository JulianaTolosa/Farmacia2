Module Datos
    'pruebank

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

    Public Function ExisteCliente(DNI As Integer) As Boolean
        Dim _Retorno As Boolean = False

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM Clientes WHERE DNI=@DNI"
        _Consulta.AgregarParametro("@DNI", DNI)
        Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
        If _Resultado.Rows.Count > 0 Then
            _Retorno = True
        End If

        Return _Retorno
    End Function

    Public Function AgregarCliente(_Cliente As Cliente) As Boolean
        Dim _Retorno As Boolean = True

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "  INSERT INTO Clientes"
            _Consulta.Consulta &= " (Nombre, Apellido, Direccion, DNI, Telefono, Celular, Fecha_Naci, Localidad, Provincia, IdObraSocial)"
            _Consulta.Consulta &= " VALUES"
            _Consulta.Consulta &= " (@Nombre, @Ape, @Dire, @DNI, @Tel, @Cel, @Naci, @Locali, @Prov, @Obra)"
            _Consulta.AgregarParametro("@Nombre", _Cliente._Nombre)
            _Consulta.AgregarParametro("@Ape", _Cliente._Apellido)
            _Consulta.AgregarParametro("@Dire", _Cliente._Direccion)
            _Consulta.AgregarParametro("@DNI", _Cliente._DNI)
            _Consulta.AgregarParametro("@Tel", _Cliente._Telefono)
            _Consulta.AgregarParametro("@Cel", _Cliente._Celular)
            _Consulta.AgregarParametro("@Naci", _Cliente._FechaNacimiento)
            _Consulta.AgregarParametro("@Locali", _Cliente._Localidad)
            _Consulta.AgregarParametro("@Prov", _Cliente._Provincia)
            _Consulta.AgregarParametro("@Obra", _Cliente._IdObraSocial)

            _Consulta.Ejecutar()
        Catch ex As Exception
            _Retorno = False
        End Try

        Return _Retorno
    End Function

    Public Function ObtenerUsuario(Id As Integer) As Usuario
        Dim _Retorno As Usuario = Nothing

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT * FROM Usuario WHERE IdUsuario=@ID"
            _Consulta.AgregarParametro("@ID", Id)
            Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
            If _Resultado.Rows.Count > 0 Then
                Dim _Row As DataRow = _Resultado.Rows(0)
                _Retorno = New Usuario
                _Retorno._Id = Convert.ToInt32(_Row("idusuario"))
                _Retorno._NombreUsuario = Convert.ToString(_Row("NombreUsuario"))
                _Retorno._Contraseña = Convert.ToString(_Row("Contrasena"))
                _Retorno._Nombre = Convert.ToString(_Row("Nombre"))
                _Retorno._Apellido = Convert.ToString(_Row("Apellido"))
                _Retorno._Posicion = Convert.ToString(_Row("Posicion"))
                _Retorno._Correo = Convert.ToString(_Row("Correo"))

            End If
        Catch ex As Exception
            _Retorno = Nothing
        End Try

        Return _Retorno
    End Function

    Public Function ObtenerUsuario(NombreUsuario As String) As Usuario
        Dim _Retorno As Usuario = Nothing

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT * FROM Usuario WHERE NombreUsuario=@NombreUsuario"
            _Consulta.AgregarParametro("@NombreUsuario", NombreUsuario)
            Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
            If _Resultado.Rows.Count > 0 Then
                Dim _Row As DataRow = _Resultado.Rows(0)
                _Retorno = New Usuario
                _Retorno._Id = Convert.ToInt32(_Row("idusuario"))
                _Retorno._NombreUsuario = Convert.ToString(_Row("NombreUsuario"))
                _Retorno._Contraseña = Convert.ToString(_Row("Contrasena"))
                _Retorno._Nombre = Convert.ToString(_Row("Nombre"))
                _Retorno._Apellido = Convert.ToString(_Row("Apellido"))
                _Retorno._Posicion = Convert.ToString(_Row("Posicion"))
                _Retorno._Correo = Convert.ToString(_Row("Correo"))

            End If
        Catch ex As Exception
            _Retorno = Nothing
        End Try

        Return _Retorno
    End Function

    Public Function AgregarProducto(_Producto As Producto) As Boolean
        Dim _Retorno As Boolean = True
        
        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "  INSERT INTO Producto"
            _Consulta.Consulta &= " (nombre,precio_venta, precio_compra,idtipoprod,descripcion)"
            _Consulta.Consulta &= " VALUES"
            _Consulta.Consulta &= " (@nombre, @precioven, @preciocomp,@tipoprod,@descripcion)"
            _Consulta.AgregarParametro("@nombre", _Producto._nombre)
            _Consulta.AgregarParametro("@precioven", _Producto._precioven)
            _Consulta.AgregarParametro("@preciocomp", _Producto._preciocomp)
            ' _Consulta.AgregarParametro("@canti", _Producto._cantidad)
            _Consulta.AgregarParametro("@tipoprod", _Producto._tipoprod)
            _Consulta.AgregarParametro("@descripcion", _Producto._descripcion)
            

            _Consulta.Ejecutar()
        Catch ex As Exception
            _Retorno = False
        End Try

        Return _Retorno
    End Function

#Region "DatosUsuarios"

    ''' <summary>
    ''' Devuelve nulo si no puede loguear. 
    ''' Devuelve el usuario seteado si esta ok.
    ''' </summary>
    Public Function Login(NombreUsuario As String, Pass As String) As Usuario
        Dim _Retorno As Usuario = Nothing

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT * FROM Usuario WHERE NombreUsuario=@NombreUsuario AND Contrasena=@Pass"
            _Consulta.AgregarParametro("@NombreUsuario", NombreUsuario)
            _Consulta.AgregarParametro("@Pass", Pass)
            Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
            If _Resultado.Rows.Count > 0 Then
                Dim _Row As DataRow = _Resultado.Rows(0)
                _Retorno = New Usuario
                _Retorno._Id = Convert.ToInt32(_Row("idusuario"))
                _Retorno._NombreUsuario = Convert.ToString(_Row("NombreUsuario"))
                _Retorno._Contraseña = Convert.ToString(_Row("Contrasena"))
                _Retorno._Nombre = Convert.ToString(_Row("Nombre"))
                _Retorno._Apellido = Convert.ToString(_Row("Apellido"))
                _Retorno._Posicion = Convert.ToString(_Row("Posicion"))
                _Retorno._Correo = Convert.ToString(_Row("Correo"))

            End If
        Catch ex As Exception
            _Retorno = Nothing
        End Try

        Return _Retorno
    End Function

    Public Function GuardarUsuario(_Usuario As Usuario) As Boolean
        Dim _Retorno As Boolean = False
        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "  UPDATE Usuario SET "
            _Consulta.Consulta &= " NombreUsuario = @NombreUsuario,"
            _Consulta.Consulta &= " Contrasena = @Pass, "
            _Consulta.Consulta &= " Nombre = @Nombre, "
            _Consulta.Consulta &= " Apellido = @Apellido, "
            _Consulta.Consulta &= " Posicion = @Posicion,  "
            _Consulta.Consulta &= " Correo=@Correo "
            _Consulta.Consulta &= " WHERE idusuario=@IdUsuario"
            _Consulta.AgregarParametro("@NombreUsuario", _Usuario._NombreUsuario)
            _Consulta.AgregarParametro("@Pass", _Usuario._Contraseña)
            _Consulta.AgregarParametro("@Nombre", _Usuario._Nombre)
            _Consulta.AgregarParametro("@Apellido", _Usuario._Apellido)
            _Consulta.AgregarParametro("@Posicion", _Usuario._Posicion)
            _Consulta.AgregarParametro("@Correo", _Usuario._Correo)
            _Consulta.AgregarParametro("@IdUsuario", _Usuario._Id)

            _Consulta.Ejecutar()
            _Retorno = True
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function
#End Region


End Module
