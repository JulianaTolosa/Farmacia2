Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data

Public Class Facturacion
    Dim item As Integer
    Dim Subtotal As Double = 0
    Dim Fila As DataGridViewRow = New DataGridViewRow()
    Dim Descuento As Double = 10
    Dim Total As Double


    Private Sub datelabel_Tick(sender As Object, e As EventArgs) Handles datelabel.Tick
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblhora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datelabel.Start()
        'listmediopago()
        listobra()
        BuscarProductos()

        dgDetalles.Columns.Clear 

        For Each col As DataGridViewColumn In DgProducto.Columns
            dgDetalles.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
        Next
        'listproducto()


    End Sub
    'Public Sub listproducto() Handles Cmbproducto.Click

    '    Try
    '        Cmbproducto.Items.Clear()
    '        Dim _Tipos As List(Of String) = Datos.ObtenerProductos()
    '        'Dim _Tipos2 As List(Of String) = Datos.ObtenerPresentacion()
    '        For Each nombre As String In _Tipos
    '            CmbProducto.Items.Add(nombre)
    '            'For Each presentacion As String In _Tipos2
    '            'CmbProducto.Items.Add(nombre & Presentacion)
    '            ' Next

    '        Next


    '    Catch ex As Exception

    '    End Try
    'End Sub

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

    'Public Sub listocategoria() Handles Cmbcategoria.Click
    '    Try
    '        Cmbcategoria.Items.Clear()
    '        Dim _Tipos As List(Of String) = Datos.ObtenerTiposProductos()
    '        For Each tipo As String In _Tipos
    '            Cmbcategoria.Items.Add(tipo)
    '        Next

    '    Catch ex As Exception

    '    End Try
    'End Sub

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


    Private Sub Cmbproducto_SelectedIndexChanged(sender As Object, e As EventArgs)
        'txtprecio.Text = CDec(CmbProducto.SelectedValue).ToString("N2")
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.KeyUp
        BuscarProductos()
    End Sub

    Private Sub BuscarProductos()
        Try
            Dim _PalabraBuscada = txtBuscador.Text.Trim
            Dim _ProductosEncontrados = Datos.ObtenerProductosParaGrilla(_PalabraBuscada)
            DgProducto.DataSource = _ProductosEncontrados
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)

        For Each row As DataGridViewRow In
    DgProducto.SelectedRows.Cast(Of DataGridViewRow)().Reverse()

            Dim index As Integer = DgDetalles.Rows.Add(DirectCast(row.Clone(), DataGridViewRow))

            For Each cell As DataGridViewCell In row.Cells
                DgDetalles.Rows(index).Cells(cell.ColumnIndex).Value = cell.Value
            Next
        Next
        'Dim Subtotal As Double = 0
        Dim Fila As DataGridViewRow = New DataGridViewRow()
        Dim Descuento As Double
        For Each Fila In DgDetalles.Rows
            Subtotal += Convert.ToDouble(Fila.Cells("PO").Value)
        Next
        Subtotaltxt.Text = Convert.ToString(Subtotal)
        Descuentotxt.Text = CStr(((CDbl(Convert.ToString(Subtotal)) * 10) / 100))
        Totaltxt.Text = CStr(CDbl(Convert.ToString(Subtotal)) - CDbl(Convert.ToString(Descuento)))

    End Sub


    Private Sub dgProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub





    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        For Each row As DataGridViewRow In
    DgProducto.SelectedRows.Cast(Of DataGridViewRow)().Reverse()

            Dim index As Integer = DgDetalles.Rows.Add(DirectCast(row.Clone(), DataGridViewRow))

            For Each cell As DataGridViewCell In row.Cells
                DgDetalles.Rows(index).Cells(cell.ColumnIndex).Value = cell.Value
            Next
        Next
        Dim Subtotal As Double = 0
        Dim Fila As DataGridViewRow = New DataGridViewRow()
        Dim Descuento As Double = 10
        For Each Fila In DgDetalles.Rows
            Subtotal += Convert.ToDouble(Fila.Cells("PO").Value)
        Next
        Subtotaltxt.Text = Convert.ToString(Subtotal)
        Descuentotxt.Text = CStr(((CDbl(Convert.ToString(Subtotal)) * 10) / 100))
        Totaltxt.Text = CStr(CDbl(Convert.ToString(Subtotal)) - CDbl(Convert.ToString(Descuento)))
    End Sub

    
    
    Private Sub listobra(sender As Object, e As EventArgs) Handles CmbObraSocial.Click

    End Sub
    Private Sub listDni(sender As Object, e As EventArgs) Handles Cmbtipodni.Click

    End Sub

    


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DgDetalles.RowCount > 0 Then
            DgDetalles.Rows.Remove(DgDetalles.CurrentRow)
            'Subtotaltxt.Text = (Convert.ToString(Subtotal)))
            'Descuentotxt.Text = CStr(((CDbl(Convert.ToString(Subtotal)) * 0) / 100))
            'Totaltxt.Text = CStr(CDbl(Convert.ToString(Subtotal)) - CDbl(Convert.ToString(Descuento)))
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Cmbtipodni.Text = ""
        CmbObraSocial.Text = ""
        TxtNombre.Text = ""
    End Sub

   
    Private Sub txtBuscador_TextChanged(sender As Object, e As KeyEventArgs)

    End Sub
End Class