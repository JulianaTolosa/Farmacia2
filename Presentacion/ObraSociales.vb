Public Class ObraSocial

    Private Sub btnCerrarForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

   
    
    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click
        If (String.IsNullOrEmpty(txtnombre.Text) Or String.IsNullOrEmpty(txtdireccion.Text) Or String.IsNullOrEmpty(txttelefono.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        Else
            'limpiar()
            Dim nombre As String = txtnombre.Text
            'Dim precioven As Double = Val(precioventa.Text)
            'Dim preciocomp As Double = Val((preciocompra.Text))
            Dim telefono As Integer = CInt((Val((txttelefono.Text))))
            'Dim tipoprod As String = (Cmbtipoproducto.Text)
            Dim direccion As String = txtdireccion.Text

            Dim _OSocial As New OSocial()
            _OSocial._nombre = txtnombre.Text
            _OSocial._direccion = (txtdireccion.Text)
            _OSocial._telefono = (txttelefono.Text)
            '_Producto._telefono = Val(txttelefono.Text)
            '_Producto._tipoprod = (Cmbtipoproducto.Text)
            '_Producto._descripcion = txtdescripcion.Text


            If Datos.AgregarOSocial(_OSocial) Then
                MsgBox("Obra Social agregada correctamente!")
            Else
                MsgBox("Error al agregar Obra Social!")
            End If
        End If
    End Sub


    Public Sub limpiar()
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtnombre.Focus()
    End Sub
End Class