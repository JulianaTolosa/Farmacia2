Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data

Public Class Facturacion

    Dim dni As Integer
    Dim nombre As String
    Dim domicilio As String
    Dim obrasocial As String
    Dim localidad As String
    Dim metodopago As String
    Dim cantidad As Integer
    Dim producto As String
    Dim subtotal As Double
    Dim total As Double
    Dim iva As Double






    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If (String.IsNullOrEmpty(Cmbcategoria.Text) Or String.IsNullOrEmpty(txtprecio.Text)) Then
            MsgBox("Algun de los campos estan vacios,por favor seleccione o rellene para continuar", MsgBoxStyle.Information)
        Else
            Dim producto As String = Cmbcategoria.Text
            Dim cantidad As Integer = CInt(txtprecio.Text)

            Dim _Ticket As New Ticket
            _Ticket._Producto = Cmbcategoria.Text
            _Ticket._Cantidad = CInt(txtprecio.Text)



        End If

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
    Public Sub listproducto() Handles Cmbcategoria.Click

        Try
            Cmbproducto.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerProductos()
            Dim _Tipos2 As List(Of String) = Datos.ObtenerPresentacion()
            For Each nombre As String In _Tipos
                For Each presentacion As String In _Tipos2
                    Cmbproducto.Items.Add(nombre + presentacion)
                Next

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

    Public Sub ventas() Handles BtnAgregar.Click
        If (String.IsNullOrEmpty(Cmbcategoria.Text) Or String.IsNullOrEmpty(txtprecio.Text)) Then
            MsgBox("Algun de los campos estan vacios,por favor seleccione o rellene para continuar", MsgBoxStyle.Information)
        Else

        End If
    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        Cmbcategoria.Text = ""
        Cmbproducto.Text = ""
        txtprecio.Clear()
        txtcantidad.Clear()
        Cmbcategoria.Text = "Seleccione una categoria"
    End Sub





   
End Class