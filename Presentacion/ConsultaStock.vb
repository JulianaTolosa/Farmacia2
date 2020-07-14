Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data

Public Class ConsultaStock


    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub



    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Try
            Dim _ListaProductos = Datos.ObtenerProductos(Txtbuscar.Text.Trim())
            '_ListaProductos tiene la lista de productos buscados
        Catch ex As Exception

        End Try
    End Sub

   
End Class