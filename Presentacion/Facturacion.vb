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
        If (String.IsNullOrEmpty(Cmbproducto.Text) Or String.IsNullOrEmpty(txtcantidad.Text)) Then
            MsgBox("Algun de los campos estan vacios,por favor seleccione o rellene para continuar", MsgBoxStyle.Information)
        Else
            Dim producto As String = Cmbproducto.Text
            Dim cantidad As Integer = CInt(txtcantidad.Text)

            Dim _Ticket As New Tick_et
            _Ticket._Producto = Cmbproducto.Text
            _Ticket._Cantidad = CInt(txtcantidad.Text)



        End If

    End Sub


    Private Sub datelabel_Tick(sender As Object, e As EventArgs) Handles datelabel.Tick
        Lbldatefecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblhora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datelabel.Start()
        listmediopago()
        listobra()
        listproducto()

    End Sub
    Public Sub listproducto() Handles Cmbproducto.Click
        Try
            Cmbproducto.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerProductos()
            For Each nombre As String In _Tipos
                Cmbproducto.Items.Add(nombre)
            Next


        Catch ex As Exception

        End Try
    End Sub

    Public Sub listmediopago() Handles CmbMediopago.Click
        Try
            CmbMediopago.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerMedioPago()
            For Each Medios_Pago As String In _Tipos
                CmbMediopago.Items.Add(Medios_Pago)
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

    Public Sub RefrescarListProducto()
        DgVentas.DataSource = Datos.ObtenerDataTableProducto()
    End Sub

    Private Sub btnCerrarForm_Click_1(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Public Sub ventas() Handles BtnAgregar.Click
        If (String.IsNullOrEmpty(Cmbproducto.Text) Or String.IsNullOrEmpty(txtcantidad.Text)) Then
            MsgBox("Algun de los campos estan vacios,por favor seleccione o rellene para continuar", MsgBoxStyle.Information)
        Else

        End If
    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles Btncancelar.Click
        Cmbproducto.Text = ""
        txtcantidad.Clear()

    End Sub

    Private Sub DgVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgVentas.CellContentClick

    End Sub
End Class