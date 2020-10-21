Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data

Public Class ConsultaStock


    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub




    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Try
            Dim _ListaProductos = Datos.ConsultaStock(Txtbuscar.Text.Trim())

            '_ListaProductos tiene la lista de productos buscados
            DgProducto.DataSource = _ListaProductos
            DgProducto.Columns(0).Visible = False

        Catch ex As Exception

        End Try
    End Sub





    

    'Private Sub DgProducto_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgProducto.CellValueChanged
    '    MessageBox.Show("Row2")
    'End Sub

    'Private Sub DgProducto_SelectionChanged(sender As Object, e As EventArgs) Handles DgProducto.SelectionChanged
    '    Dim rowCount As Integer = DgProducto.Rows.GetRowCount(DataGridViewElementStates.Selected)
    '    Dim DProd = New Datos.ConsultaMovimientos(ID)
    '    Dim idProducto As Integer
    '    If (rowCount > 0) Then
    '        idProducto = CInt(DgProducto.Rows(DgProducto.CurrentRow.Index).Cells(0).Value)
    '        dgMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        dgMovimientos.DataSource = DProd.GetData(idProducto)
    '    End If
    'End Sub
End Class