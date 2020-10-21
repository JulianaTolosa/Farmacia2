Public Class Clientes
    'Prueba Lucas
    Private Sub btnCerrarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TesisDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'ghjggjgjgjjgj()

    End Sub

   
    
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaCliente.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If (String.IsNullOrEmpty(NombreTextBox.Text) Or String.IsNullOrEmpty(ApellidoTextBox.Text) Or String.IsNullOrEmpty(DireccionTextBox.Text) Or String.IsNullOrEmpty(DniTextBox.Text) Or String.IsNullOrEmpty(TelefonoTextBox.Text) Or String.IsNullOrEmpty(CelularTextBox.Text) Or String.IsNullOrEmpty(NacimientoTextBox.Text) Or String.IsNullOrEmpty(LocalidadTextBox.Text) Or String.IsNullOrEmpty(ProvinciaTextBox.Text) Or String.IsNullOrEmpty(ObraSocialcmb.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf Datos.ExisteCliente(CInt(DniTextBox.Text)) Then
            MessageBox.Show("El Cliente ya existe con este Documento, por favor intente nuevamente")
            limpiar()
        Else

            Dim Nombre As String = NombreTextBox.Text
            Dim Apellido As String = ApellidoTextBox.Text
            Dim Direccion As String = DireccionTextBox.Text
            Dim DNI As Integer = CInt(DniTextBox.Text)
            Dim Telefono As String = TelefonoTextBox.Text
            Dim Celular As String = CelularTextBox.Text
            Dim FechaNacimiento As Date = CDate(NacimientoTextBox.Text)
            Dim Localidad As String = LocalidadTextBox.Text
            Dim Provincia As String = ProvinciaTextBox.Text
            Dim IdObraSocial As String = ObraSocialcmb.Text

            Dim _Cliente As New Cliente()
            _Cliente._Nombre = NombreTextBox.Text
            _Cliente._Apellido = ApellidoTextBox.Text
            _Cliente._Direccion = DireccionTextBox.Text
            _Cliente._DNI = CInt(DniTextBox.Text)
            _Cliente._Telefono = TelefonoTextBox.Text
            _Cliente._Celular = CelularTextBox.Text
            _Cliente._FechaNacimiento = CDate(NacimientoTextBox.Text)
            _Cliente._Localidad = LocalidadTextBox.Text
            _Cliente._Provincia = ProvinciaTextBox.Text
            _Cliente._IdObraSocial = CInt(ObraSocialcmb.Text)

            If Datos.AgregarCliente(_Cliente) Then
                MsgBox("Cliente agregado correctamente!")
            Else
                MsgBox("Error al agregar Cliente!")
            End If

            limpiar()
        End If
    End Sub

    Public Sub limpiar()
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        DireccionTextBox.Text = ""
        DniTextBox.Text = ""
        NacimientoTextBox.Text = ""
        CelularTextBox.Text = ""
        TelefonoTextBox.Text = ""
        LocalidadTextBox.Text = ""
        ProvinciaTextBox.Text = ""
        ObraSocialcmb.Text = ""
        DniTextBox.Focus()
    End Sub


    Private Sub DniTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        End If
    End Sub


    
   
    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (String.IsNullOrEmpty(NombreTextBox.Text) Or String.IsNullOrEmpty(ApellidoTextBox.Text) Or String.IsNullOrEmpty(DireccionTextBox.Text) Or String.IsNullOrEmpty(DniTextBox.Text) Or String.IsNullOrEmpty(TelefonoTextBox.Text) Or String.IsNullOrEmpty(CelularTextBox.Text) Or String.IsNullOrEmpty(NacimientoTextBox.Text) Or String.IsNullOrEmpty(LocalidadTextBox.Text) Or String.IsNullOrEmpty(ProvinciaTextBox.Text) Or String.IsNullOrEmpty(ObraSocialcmb.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf Datos.ExisteCliente(CInt(DniTextBox.Text)) Then
            MessageBox.Show("El Cliente ya existe con este Documento, por favor intente nuevamente")
            limpiar()
        Else

            Dim Nombre As String = NombreTextBox.Text
            Dim Apellido As String = ApellidoTextBox.Text
            Dim Direccion As String = DireccionTextBox.Text
            Dim DNI As Integer = CInt(DniTextBox.Text)
            Dim Telefono As String = TelefonoTextBox.Text
            Dim Celular As String = CelularTextBox.Text
            Dim FechaNacimiento As Date = CDate(NacimientoTextBox.Text)
            Dim Localidad As String = LocalidadTextBox.Text
            Dim Provincia As String = ProvinciaTextBox.Text
            Dim IdObraSocial As String = ObraSocialcmb.Text

            Dim _Cliente As New Cliente()
            _Cliente._Nombre = NombreTextBox.Text
            _Cliente._Apellido = ApellidoTextBox.Text
            _Cliente._Direccion = DireccionTextBox.Text
            _Cliente._DNI = CInt(DniTextBox.Text)
            _Cliente._Telefono = TelefonoTextBox.Text
            _Cliente._Celular = CelularTextBox.Text
            _Cliente._FechaNacimiento = CDate(NacimientoTextBox.Text)
            _Cliente._Localidad = LocalidadTextBox.Text
            _Cliente._Provincia = ProvinciaTextBox.Text
            _Cliente._IdObraSocial = CInt(ObraSocialcmb.Text)

            If Datos.AgregarCliente(_Cliente) Then
                MsgBox("Cliente agregado correctamente!")
            Else
                MsgBox("Error al agregar Cliente!")
            End If

            limpiar()
        End If
    End Sub

    
End Class