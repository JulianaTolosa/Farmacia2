Public Class Ingreso

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBuscar.TextChanged
        Try
            Dim _ListaProductos = Datos.ConsultaStock(TextBuscar.Text.Trim())
            '_ListaProductos tiene la lista de productos buscados
            dgProductos.DataSource = _ListaProductos

        Catch ex As Exception

        End Try
    End Sub

   
End Class