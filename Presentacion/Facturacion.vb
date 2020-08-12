Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data

Public Class Facturacion
    Dim item As Integer

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

        For Each col As DataGridViewColumn In dgProductos.Columns
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

    'Private Sub Cmbproducto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmbproducto.SelectionChangeCommitted
    '    Productos = TryCast(Cmbproducto.SelectedItem.ToString, Producto)
    '    'txtprecio.Text = Productos.precio.ToString()
    'End Sub




    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.KeyUp
        BuscarProductos()
    End Sub

    Private Sub BuscarProductos()
        Try
            Dim _PalabraBuscada = txtBuscador.Text.Trim
            Dim _ProductosEncontrados = Datos.ObtenerProductosParaGrilla(_PalabraBuscada)
            dgProductos.DataSource = _ProductosEncontrados
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        
            For Each row As DataGridViewRow In
        dgProductos.SelectedRows.Cast(Of DataGridViewRow)().Reverse()

                Dim index As Integer = dgDetalles.Rows.Add(DirectCast(row.Clone(), DataGridViewRow))

                For Each cell As DataGridViewCell In row.Cells
                    dgDetalles.Rows(index).Cells(cell.ColumnIndex).Value = cell.Value
                Next
            Next


            '    If (txtBuscador.Text = "") Then
            '        MsgBox("Por Favor seleccione un producto", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
            '        txtBuscador.Focus()

            '    ElseIf (txtBuscador.Text <> "") Then
            '        dgDetalles.Items.Clear()
            '        For Each row As DataGridViewRow In dgProductos.SelectedRows
            '            item = (item + 1)
            '            Lbxitem.Items.Add(item)
            '            Lbxproducto.Items.Add(Convert.ToString(row.Cells("nombre").Value))
            '            Lbxprecio.Items.Add(Convert.ToString(row.Cells("PO").Value))
            '            'Lbx.Items.Add(Convert.ToString(row.Cells("precio_venta").Value))

            '            LbxSubtotal.Items.Add(Lbxprecio)

            '        Next

            'If (Btnboleta.Checked = True) Then
            '    calcular()
            'Else
            '    impuesto()
            'End If
            'Else
            '    MsgBox("Ingrese cantidad valida!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)


    End Sub


    Private Sub dgProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProductos.CellContentClick
        
    End Sub
End Class