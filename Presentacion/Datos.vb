Module Datos
    'pruebankjhjkhknk

    Public Function ObtenerDni() As List(Of String)
        Dim _Retorno As New List(Of String)
        Try
            Dim _Consulta As ConsultaSQL = New ConsultaSQL
            _Consulta.Consulta = "SELECT Tipo_Dni FROM Dni"
            Dim _DT As DataTable = _Consulta.ObtenerTabla()
            For Each _Row As DataRow In _DT.Rows
                _Retorno.Add(_Row("Tipo_Dni").ToString())

            Next
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function

    Public Function Obtenerobrasocial() As List(Of String)
        Dim _Retorno As New List(Of String)
        Try
            Dim _Consulta As ConsultaSQL = New ConsultaSQL
            _Consulta.Consulta = "SELECT Nombre FROM ObraSocial"
            Dim _DT As DataTable = _Consulta.ObtenerTabla()
            For Each _Row As DataRow In _DT.Rows
                _Retorno.Add(_Row("Nombre").ToString())
            Next
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function

    Public Function ObtenerMedioPago() As List(Of String)
        Dim _Retorno As New List(Of String)
        Try
            Dim _Consulta As ConsultaSQL = New ConsultaSQL
            _Consulta.Consulta = "SELECT Medios_Pago FROM MediosdePago"
            Dim _DT As DataTable = _Consulta.ObtenerTabla()
            For Each _Row As DataRow In _DT.Rows
                _Retorno.Add(_Row("Medios_Pago").ToString())
            Next
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function

    Public Function ObtenerPresentacion() As List(Of String)
        Dim _Retorno As New List(Of String)
        Try
            Dim _Consulta As ConsultaSQL = New ConsultaSQL
            _Consulta.Consulta = "SELECT presentacion FROM Producto"
            Dim _DT As DataTable = _Consulta.ObtenerTabla()
            For Each _Row As DataRow In _DT.Rows
                _Retorno.Add(_Row("presentacion").ToString())
            Next
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function

    Public Function ObtenerPrecioventa() As List(Of String)
        Dim _Retorno As New List(Of String)
        Try
            Dim _Consulta As ConsultaSQL = New ConsultaSQL
            _Consulta.Consulta = "SELECT precio_venta FROM Producto"
            Dim _DT As DataTable = _Consulta.ObtenerTabla()
            For Each _Row As DataRow In _DT.Rows
                _Retorno.Add(_Row("precio_venta").ToString())

            Next
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function

    'Public Function ObtenerProductos() As List(Of String)
    '    Dim _Retorno As New List(Of String)
    '    Try
    '        Dim _Consulta As ConsultaSQL = New ConsultaSQL
    '        _Consulta.Consulta = "SELECT nombre FROM Producto"
    '        Dim _DT As DataTable = _Consulta.ObtenerTabla()
    '        For Each _Row As DataRow In _DT.Rows
    '            _Retorno.Add(_Row("nombre").ToString())
    '            '_Retorno.Add(_Row("precio_venta").ToString())

    '        Next
    '    Catch ex As Exception

    '    End Try
    '    Return _Retorno
    'End Function


    'Public Function ObtenerTiposProductos() As List(Of String)
    '    Dim _Retorno As New List(Of String)
    '    Try
    '        Dim _Consulta As ConsultaSQL = New ConsultaSQL
    '        _Consulta.Consulta = "SELECT tipo FROM tipo_producto"
    '        Dim _DT As DataTable = _Consulta.ObtenerTabla()
    '        For Each _Row As DataRow In _DT.Rows
    '            _Retorno.Add(_Row("tipo").ToString())
    '        Next
    '    Catch ex As Exception

    '    End Try
    '    Return _Retorno
    'End Function

    Public Function ObtenerProductos() As DataTable
        Dim _Consulta As ConsultaSQL = New ConsultaSQL
        _Consulta.Consulta = "SELECT nombre,precio_venta FROM Producto"
        Return _Consulta.ObtenerTabla
    End Function

    Public Function ExisteObraSocial(Nombre As String) As Boolean
        Dim _Retorno As Boolean = False

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM ObraSocial WHERE nombre=@Nombre"
        _Consulta.AgregarParametro("@Nombre", Nombre)
        Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
        If _Resultado.Rows.Count > 0 Then
            _Retorno = True
        End If

        Return _Retorno
    End Function

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

    Public Function ObtenerDataTableCliente() As DataTable
        Dim _Retorno As New DataTable

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM Clientes"
        _Retorno = _Consulta.ObtenerTabla()

        Return _Retorno
    End Function

    Public Function ObtenerDataTableStock() As DataTable
        Dim _Retorno As New DataTable

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM Stock"
        _Retorno = _Consulta.ObtenerTabla()

        Return _Retorno
    End Function

    Public Function ObtenerDataTableObraS() As DataTable
        Dim _Retorno As New DataTable

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM ObraSocial"
        _Retorno = _Consulta.ObtenerTabla()

        Return _Retorno
    End Function

    Public Function ObtenerDataTableEmpleados() As DataTable
        Dim _Retorno As New DataTable

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "SELECT * FROM Usuario"
        _Retorno = _Consulta.ObtenerTabla()

        Return _Retorno
    End Function

    Public Function ObtenerDataTableProducto() As DataTable
        Dim _Retorno As New DataTable

        Dim _Consulta As New ConsultaSQL
        _Consulta.Consulta = "Select * From Producto"
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

    Public Function ObtenerCliente(Nombre As String) As Cliente
        Dim _Retorno As Cliente = Nothing

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT * FROM Clientes WHERE Nombre=@Nombre"
            _Consulta.AgregarParametro("@Nombre", Nombre)
            Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
            If _Resultado.Rows.Count > 0 Then
                Dim _Row As DataRow = _Resultado.Rows(0)
                _Retorno = New Cliente
                _Retorno._ID = Convert.ToInt32(_Row("idcliente"))
                _Retorno._Nombre = Convert.ToString(_Row("Nombre"))
                _Retorno._Apellido = Convert.ToString(_Row("Apellido"))
                _Retorno._Direccion = Convert.ToString(_Row("Direccion"))
                _Retorno._DNI = Convert.ToInt32(_Row("DNI"))
                _Retorno._Telefono = Convert.ToString(_Row("Telefono"))
                _Retorno._Celular = Convert.ToString(_Row("Celular"))
                _Retorno._FechaNacimiento = Convert.ToDateTime(_Row("FechaNacimiento"))
                _Retorno._Localidad = Convert.ToString(_Row("Localidad"))
                _Retorno._Provincia = Convert.ToString(_Row("Provincia"))
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
            _Consulta.Consulta &= " (nombre,descripcion,precio_venta,precio_compra,idtipoprod)"
            _Consulta.Consulta &= " VALUES"
            _Consulta.Consulta &= " (@nombre,@descripcion,@precioven,@preciocomp,@idtipoprod)"
            _Consulta.AgregarParametro("@nombre", _Producto._Nombre)
            _Consulta.AgregarParametro("@descripcion", _Producto._Descripcion)
            _Consulta.AgregarParametro("@precioven", _Producto._PrecioVenta)
            _Consulta.AgregarParametro("@preciocomp", _Producto._PrecioCompra)
            _Consulta.AgregarParametro("@idtipoprod", _Producto._TipoProd)
            '_Consulta.AgregarParametro("@canti", _Producto._Cantidad)

            _Consulta.Ejecutar()
        Catch ex As Exception
            _Retorno = False
        End Try

        Return _Retorno
    End Function

    Public Function AgregarOSocial(_OSocial As OSocial) As Boolean
        Dim _Retorno As Boolean = True

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "  INSERT INTO ObraSocial"
            _Consulta.Consulta &= " (Nombre,Direccion,Localidad,Provincia,Telefono,Descuento)"
            _Consulta.Consulta &= " VALUES"
            _Consulta.Consulta &= " (@Nombre,@Direccion,@Localidad,@Provincia,@Telefono,@Descuento)"
            _Consulta.AgregarParametro("@Nombre", _OSocial._nombre)
            _Consulta.AgregarParametro("@Direccion", _OSocial._direccion)
            _Consulta.AgregarParametro("@Localidad", _OSocial._localidad)
            _Consulta.AgregarParametro("@Provincia", _OSocial._provincia)
            _Consulta.AgregarParametro("@telefono", _OSocial._telefono)
            _Consulta.AgregarParametro("@Descuento", _OSocial._descuento)
           
            _Consulta.Ejecutar()
        Catch ex As Exception
            _Retorno = False
        End Try

        Return _Retorno
    End Function

    ''' <summary>
    ''' Devuelve un listado de Productos segun la palabra pasada como parametro.
    ''' La palabra puede ser el ID o bien una parte del nombre del producto buscado.
    ''' </summary>
    Public Function ObtenerProductos(_PalabraBuscada As String) As List(Of Producto)
        Dim _Retorno As New List(Of Producto)

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT * FROM Producto WHERE idproducto=@ID OR nombre LIKE '% + @PalabraBuscada + %' ORDER BY IdProducto"
            Dim _ID As Integer = 0
            Integer.TryParse(_PalabraBuscada, _ID)
            _Consulta.AgregarParametro("@ID", _ID)
            _Consulta.AgregarParametro("@PalabraBuscada", _PalabraBuscada)
            Dim _DT As DataTable = _Consulta.ObtenerTabla()
            For Each _Row As DataRow In _DT.Rows
                Dim _Prod As New Producto
                _Prod._Idproducto = Convert.ToInt32(_Row("idproducto"))
                _Prod._Nombre = Convert.ToString(_Row("nombre"))
                _Prod._Descripcion = Convert.ToString(_Row("descripcion"))
                _Prod._PrecioVenta = Convert.ToDouble(_Row("preciovent"))
                _Prod._PrecioCompra = Convert.ToDouble(_Row("preciocomp"))
                _Prod._TipoProd = Convert.ToString(_Row("tipoprod"))
                _Retorno.Add(_Prod)
            Next
        Catch ex As Exception
            _Retorno = New List(Of Producto)
        End Try
        Return _Retorno
    End Function

    ''' <summary>
    ''' Devuelve un DataTable segun la palabra pasada como parametro.
    ''' La palabra puede ser el ID o bien una parte del nombre del producto buscado.
    ''' </summary>
    Public Function ObtenerProductosEnDT(_PalabraBuscada As String) As DataTable
        Dim _Retorno As New DataTable

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT * FROM Producto WHERE idproducto=@ID OR nombre LIKE '%' + @PalabraBuscada + '%' ORDER BY IdProducto"

            Dim _ID As Integer = 0
            Integer.TryParse(_PalabraBuscada, _ID)
            _Consulta.AgregarParametro("@ID", _ID)
            _Consulta.AgregarParametro("@PalabraBuscada", _PalabraBuscada)
            _Retorno = _Consulta.ObtenerTabla()
        Catch ex As Exception
            _Retorno = New DataTable
        End Try
        Return _Retorno
    End Function
    ''' <summary>
    ''' Devuelve un DataTable segun la palabra pasada como parametro.
    ''' La palabra puede ser el ID o bien una parte del nombre del producto buscado.
    ''' </summary>
    Public Function ObtenerProductosParaGrilla(_PalabraBuscada As String) As DataTable
        Dim _Retorno As New DataTable

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta &= " SELECT "
            _Consulta.Consulta &= "	    P.IdProducto, P.Nombre,P.Presentacion,IdTipoprod as tipo,"
            _Consulta.Consulta &= "	    COALESCE(Pr.precio, precio_venta) as PO"
            _Consulta.Consulta &= " FROM Producto P"
            _Consulta.Consulta &= " LEFT JOIN Precios Pr ON P.Idproducto=Pr.Idproducto AND GETDATE() between Pr.fecha_dsde AND Pr.fecha_hst"
            _Consulta.Consulta &= " WHERE P.idproducto=@ID OR P.nombre LIKE '%' + @PalabraBuscada + '%' ORDER BY P.IdProducto"

            Dim _ID As Integer = 0
            Integer.TryParse(_PalabraBuscada, _ID)
            _Consulta.AgregarParametro("@ID", _ID)
            _Consulta.AgregarParametro("@PalabraBuscada", _PalabraBuscada)
            _Retorno = _Consulta.ObtenerTabla()
        Catch ex As Exception
            _Retorno = New DataTable
        End Try
        Return _Retorno
    End Function

    ''' <summary>
    ''' Retorna NULO cuando no puede setear al producto
    ''' </summary>
    Public Function ObtenerProducto(Id As Integer) As Producto
        Dim _Retorno As Producto = Nothing

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT * FROM Producto WHERE idproducto=@ID"
            _Consulta.AgregarParametro("@ID", Id)
            Dim _Resultado As DataTable = _Consulta.ObtenerTabla()
            If _Resultado.Rows.Count > 0 Then
                Dim _Row As DataRow = _Resultado.Rows(0)
                _Retorno = New Producto
                _Retorno._Idproducto = Convert.ToInt32(_Row("idproducto"))
                _Retorno._Nombre = Convert.ToString(_Row("nombre"))
                _Retorno._Descripcion = Convert.ToString(_Row("descripcion"))
                _Retorno._PrecioVenta = Convert.ToDouble(_Row("preciovent"))
                _Retorno._PrecioCompra = Convert.ToDouble(_Row("preciocomp"))
                _Retorno._TipoProd = Convert.ToString(_Row("tipoprod"))
            End If
        Catch ex As Exception
            _Retorno = Nothing
        End Try

        Return _Retorno
    End Function

    Public Function ConsultaStock(_PalabraBuscada As String) As DataTable
        Dim _Retorno As New DataTable

        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "SELECT IdProducto,Nombre, Presentacion FROM Producto WHERE  nombre LIKE '%' + @PalabraBuscada + '%' ORDER BY IdProducto"
            Dim _ID As Integer = 0
            Integer.TryParse(_PalabraBuscada, _ID)
            '_Consulta.AgregarParametro("@ID", _ID)
            _Consulta.AgregarParametro("@PalabraBuscada", _PalabraBuscada)
            _Retorno = _Consulta.ObtenerTabla()
        Catch ex As Exception
            _Retorno = New DataTable
        End Try
        Return _Retorno
    End Function

    'Public Function ConsultaMovimientos(_ID As Integer) As DataTable
    '    Dim _Retorno As New DataTable

    '    Try
    '        Dim _Consulta As New ConsultaSQL
    '        _Consulta.Consulta = "select * from Movimientos_Stock"
    '        Dim _ID As Integer = 0
    '        'Integer.TryParse(_ID)
    '        _Consulta.AgregarParametro("@ID", _ID)
    '        '_Consulta.AgregarParametro("@PalabraBuscada", _PalabraBuscada)
    '        _Retorno = _Consulta.ObtenerTabla()
    '    Catch ex As Exception
    '        _Retorno = New DataTable
    '    End Try
    '    Return _Retorno
    'End Function

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

    Public Function GuardarClientes(_Cliente As Cliente) As Boolean
        Dim _Retorno As Boolean = False
        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "  UPDATE Clientes SET "
            _Consulta.Consulta &= " Nombre = @Nombre,"
            _Consulta.Consulta &= " Apellido = @Apellido, "
            _Consulta.Consulta &= " Direccion = @Direccion, "
            _Consulta.Consulta &= " DNI = @DNI,  "
            _Consulta.Consulta &= " Telefono=@Telefono "
            _Consulta.Consulta &= " Celular=@Celular "
            _Consulta.Consulta &= " FechaNa=@FechaNa "
            _Consulta.Consulta &= " Localidad=@Localidad "
            _Consulta.Consulta &= " Provincia=@Provincia "
            _Consulta.Consulta &= " IdObraSocial=@IdObraSocial "
            _Consulta.Consulta &= " tipo_dni=@tipo_dni "
            _Consulta.Consulta &= " WHERE idusuario=@IdUsuario"
            _Consulta.AgregarParametro("@Nombre", _Cliente._Nombre)
            _Consulta.AgregarParametro("@Apellido", _Cliente._Apellido)
            _Consulta.AgregarParametro("@Direccion", _Cliente._Direccion)
            _Consulta.AgregarParametro("@DNI", _Cliente._DNI)
            _Consulta.AgregarParametro("@Telefono", _Cliente._Telefono)
            _Consulta.AgregarParametro("@Celular", _Cliente._Celular)
            _Consulta.AgregarParametro("@Correo", _Cliente._Correo)
            '_Consulta.AgregarParametro("@IdUsuario", _Cliente._Id)

            _Consulta.Ejecutar()
            _Retorno = True
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function

    Public Function GuardarProducto(_Producto As Producto) As Boolean
        Dim _Retorno As Boolean = False
        Try
            Dim _Consulta As New ConsultaSQL
            _Consulta.Consulta = "  UPDATE Producto SET "
            _Consulta.Consulta &= " Nombre = @Nombre,"
            _Consulta.Consulta &= " Apellido = @Apellido, "
            _Consulta.Consulta &= " Direccion = @Direccion, "
            _Consulta.Consulta &= " DNI = @DNI,  "
            _Consulta.Consulta &= " Telefono=@Telefono "
            _Consulta.Consulta &= " Celular=@Celular "
            _Consulta.Consulta &= " FechaNa=@FechaNa "
            _Consulta.Consulta &= " Localidad=@Localidad "
            _Consulta.Consulta &= " Provincia=@Provincia "
            _Consulta.Consulta &= " IdObraSocial=@IdObraSocial "
            _Consulta.Consulta &= " tipo_dni=@tipo_dni "
            _Consulta.Consulta &= " WHERE idusuario=@IdUsuario"
            '_Consulta.AgregarParametro("@Nombre", _Producto._Nombre)
            '_Consulta.AgregarParametro("@Apellido", _Producto._Apellido)
            '_Consulta.AgregarParametro("@Direccion", _Producto._Direccion)
            '_Consulta.AgregarParametro("@DNI", _Producto._DNI)
            '_Consulta.AgregarParametro("@Telefono", _Producto._Telefono)
            '_Consulta.AgregarParametro("@Celular", _Producto._Celular)
            '_Consulta.AgregarParametro("@Correo", _Producto._Correo)
            '_Consulta.AgregarParametro("@IdUsuario", _Producto._Id)

            _Consulta.Ejecutar()
            _Retorno = True
        Catch ex As Exception

        End Try
        Return _Retorno
    End Function

#End Region






End Module
