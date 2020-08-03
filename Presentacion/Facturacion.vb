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

    End Sub


    Private Sub datelabel_Tick(sender As Object, e As EventArgs) Handles datelabel.Tick
        Lbldatefecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblhora.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datelabel.Start()

        Try
            Cmbproducto.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerProductos()
            For Each nombre As String In _Tipos
                Cmbproducto.Items.Add(nombre)
            Next


        Catch ex As Exception

        End Try

        Try
            CmbMediopago.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.ObtenerMedioPago()
            For Each Medios_Pago As String In _Tipos
                CmbMediopago.Items.Add(Medios_Pago)
            Next

        Catch ex As Exception

        End Try

        Try
            CmbObraSocial.Items.Clear()
            Dim _Tipos As List(Of String) = Datos.Obtenerobrasocial()
            For Each nombre As String In _Tipos
                CmbObraSocial.Items.Add(nombre)
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrarForm_Click_1(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub
End Class