Public Class Clientes
    'Prueba Lucas
    Private Sub btnCerrarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TesisDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'ghjggjgjgjjgj()
        RefrescarListaclientes()
        listdni()
        listobra()
    End Sub

   
    
    

    Public Sub RefrescarListaclientes()
        DgDetalleClientes.DataSource = Datos.ObtenerDataTableCliente()
        DgDetalleClientes.Columns(0).Visible = False
        DgDetalleClientes.Columns(10).Visible = False
    End Sub

    
   

    Public Sub limpiar()
        nombretxt.Text = ""
        apellidotxt.Text = ""
        direcciontxt.Text = ""
        dnitxt.Text = ""
        fechadate.Text = ""
        Celulartxt.Text = ""
        telefonotxt.Text = ""
        localidadtxt.Text = ""
        provinciatxt.Text = ""
        ObraSocialcmb.Text = ""
        Dnicmb.Focus()
    End Sub


    Private Sub DniTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        End If
    End Sub

    Public Sub listdni() Handles Dnicmb.Click
        Try
            Dnicmb.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerDni()
            For Each nombre As String In _Tipos
                Dnicmb.Items.Add(nombre)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub listobra() Handles ObraSocialcmb.Click
        Try
            ObraSocialcmb.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.Obtenerobrasocial()
            For Each nombre As String In _Tipos
                ObraSocialcmb.Items.Add(nombre)
            Next

        Catch ex As Exception

        End Try
    End Sub

    
   
    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (String.IsNullOrEmpty(Dnicmb.Text) Or String.IsNullOrEmpty(dnitxt.Text) Or String.IsNullOrEmpty(nombretxt.Text) Or String.IsNullOrEmpty(apellidotxt.Text) Or String.IsNullOrEmpty(direcciontxt.Text) Or String.IsNullOrEmpty(dnitxt.Text) Or String.IsNullOrEmpty(telefonotxt.Text) Or String.IsNullOrEmpty(Celulartxt.Text) Or String.IsNullOrEmpty(fechadate.Text) Or String.IsNullOrEmpty(localidadtxt.Text) Or String.IsNullOrEmpty(provinciatxt.Text) Or String.IsNullOrEmpty(ObraSocialcmb.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf Datos.ExisteCliente(CInt(dnitxt.Text)) Then
            MessageBox.Show("El Cliente ya existe con este Documento, por favor intente nuevamente")
            limpiar()
        Else
            Dim tipo_dni As String = Dnicmb.Text
            Dim Nombre As String = nombretxt.Text
            Dim Apellido As String = apellidotxt.Text
            Dim Direccion As String = direcciontxt.Text
            Dim TipoDni As String = Dnicmb.Text
            Dim DNI As Integer = CInt(dnitxt.Text)
            Dim Telefono As String = telefonotxt.Text
            Dim Celular As String = Celulartxt.Text
            Dim FechaNacimiento As Date = CDate(fechadate.Text)
            Dim Localidad As String = localidadtxt.Text
            Dim Provincia As String = provinciatxt.Text
            Dim IdObraSocial As String = ObraSocialcmb.Text

            Dim _Cliente As New Cliente()
            _Cliente._Nombre = nombretxt.Text
            _Cliente._Apellido = apellidotxt.Text
            _Cliente._Direccion = direcciontxt.Text
            _Cliente._DNI = CInt(dnitxt.Text)
            _Cliente._Telefono = telefonotxt.Text
            _Cliente._Celular = Celulartxt.Text
            _Cliente._FechaNacimiento = CDate(fechadate.Text)
            _Cliente._Localidad = localidadtxt.Text
            _Cliente._Provincia = provinciatxt.Text
            _Cliente._IdObraSocial = (ObraSocialcmb.Text)
            _Cliente._tipodni = (Dnicmb.Text)

            If Datos.AgregarCliente(_Cliente) Then
                MsgBox("Cliente agregado correctamente!")
            Else
                MsgBox("Error al agregar Cliente!")
            End If

            limpiar()
        End If
    End Sub

    
End Class