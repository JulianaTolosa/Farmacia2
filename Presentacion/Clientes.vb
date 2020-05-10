Public Class Clientes

    Private Sub btnCerrarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TesisDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'ghjggjgjgjjgj()

    End Sub

   
    
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        AltaCliente.Show()
    End Sub
End Class