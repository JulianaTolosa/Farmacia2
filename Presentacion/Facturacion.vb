Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data

Public Class Facturacion



    'Dim dni As Integer
    'Dim nombre As String
    'Dim domicilio As String
    'Dim obrasocial As String
    'Dim localidad As String
    'Dim metodopago As String
    'Dim cantidad As Integer
    'Dim producto As String
    'Dim subtotal As Double
    'Dim total As Double
    'Dim iva As Double






    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click


    End Sub




    Private Sub datelabel_Tick(sender As Object, e As EventArgs) Handles datelabel.Tick
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblhora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datelabel.Start()
        'listmediopago()
        listobra()
        listproducto()


    End Sub
    Public Sub listproducto() Handles Cmbproducto.Click

        Try
            Cmbproducto.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerProductos()
            'Dim _Tipos2 As List(Of String) = Datos.ObtenerPresentacion()
            For Each nombre As String In _Tipos
                Cmbproducto.Items.Add(nombre)
                'For Each presentacion As String In _Tipos2
                'Cmbproducto.Items.Add(nombre + Presentacion)
                'Next

            Next


        Catch ex As Exception

        End Try
    End Sub

    Public Sub listDni() Handles Cmbtipodni.Click

        Try
            Cmbtipodni.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerDni()
            For Each tipo_dni As String In _Tipos
                Cmbtipodni.Items.Add(tipo_dni)
            Next


        Catch ex As Exception

        End Try
    End Sub



    'Public Sub listmediopago() Handles CmbMediopago.Click
    '    Try
    '        CmbMediopago.Items.Clear()
    '        Dim _Tipos As List(Of String) = Datos.ObtenerMedioPago()
    '        For Each Medios_Pago As String In _Tipos
    '            CmbMediopago.Items.Add(Medios_Pago)
    '        Next

    '    Catch ex As Exception

    '    End Try

    'End Sub

    Public Sub listocategoria() Handles Cmbcategoria.Click
        Try
            Cmbcategoria.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerTiposProductos()
            For Each tipo As String In _Tipos
                Cmbcategoria.Items.Add(tipo)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub listobra() Handles CmbObraSocial.Click
        Try
            CmbObraSocial.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.Obtenerobrasocial()
            For Each nombre As String In _Tipos
                CmbObraSocial.Items.Add(nombre)
            Next

        Catch ex As Exception

        End Try
    End Sub

    'Public Sub RefrescarListProducto()
    '    DgVentas.DataSource = Datos.ObtenerDataTableProducto()
    'End Sub

    Private Sub btnCerrarForm_Click_1(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub


    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        Cmbcategoria.Text = ""
        Cmbproducto.Text = ""
        txtprecio.Clear()
        txtcantidad.Clear()
        Cmbcategoria.Text = "Seleccione una categoria"
    End Sub


    Private Sub Cmbcategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcategoria.SelectedIndexChanged
        Dim pos As Integer
        pos = Cmbcategoria.SelectedIndex
        Select Case (pos)
            Case 1 : listproducto()



        End Select


    End Sub

    'Private Sub Cmbproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbproducto.SelectedIndexChanged
    '    txtprecio.Text = Cmbproducto.SelectedValue.ToString()
    'End Sub

    Private Sub Cmbproducto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmbproducto.SelectionChangeCommitted
        'producto = TryCast(Cmbproducto.SelectedItem.ToString, Producto)
        txtprecio.Text = ObtenerPrecioventa.ToString()
    End Sub

End Class