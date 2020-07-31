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


    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    
    
    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

    End Sub
End Class