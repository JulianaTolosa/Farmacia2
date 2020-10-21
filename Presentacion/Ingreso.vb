Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Ingreso

    Dim prod As String
    Dim cantidad As Integer
    Dim fecha As DateTime



    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        Dim _ListaProductos = Datos.ConsultaStock(Textproducto.Text.Trim())
    '        '_ListaProductos tiene la lista de productos buscados
    '        dgProductos.DataSource = _ListaProductos

    '    Catch ex As Exception

    '    End Try
    'End Sub


    Public Sub RefrescarListaStock()
        Dgdetalleprod.DataSource = Datos.ObtenerDataTableStock()
    End Sub


    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click


    End Sub

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescarListaStock()
        Dgdetalleprod.Columns(0).Visible = False
    End Sub
End Class