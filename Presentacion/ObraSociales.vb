Public Class ObraSocial

    Private Sub btnCerrarForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

   
    
    Private Sub Btnagregar_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub limpiar()
        txtnombre.Text = ""
        txtdireccion.Text = ""
        Txttelefono.Text = ""
        TxtLocalidad.Text = ""
        TxtProvincia.Text = ""
        TxtDescuento.Text = ""
        txtnombre.Focus()
    End Sub

    Private Sub GBagregar_Click(sender As Object, e As EventArgs) Handles GBagregar.Click
        If (String.IsNullOrEmpty(TxtNombre.Text) Or String.IsNullOrEmpty(Txtdireccion.Text) Or String.IsNullOrEmpty(Txttelefono.Text) Or String.IsNullOrEmpty(TxtLocalidad.Text) Or String.IsNullOrEmpty(TxtProvincia.Text) Or String.IsNullOrEmpty(TxtDescuento.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        Else
            Dim nombre As String = TxtNombre.Text
            Dim telefono As Integer = CInt((Val((Txttelefono.Text))))
            Dim direccion As String = Txtdireccion.Text
            Dim Localidad As String = TxtLocalidad.Text
            Dim Provincia As String = TxtProvincia.Text
            Dim Descuento As Double = CDbl(TxtDescuento.Text)

            Dim _OSocial As New OSocial()
            _OSocial._nombre = TxtNombre.Text
            _OSocial._direccion = (Txtdireccion.Text)
            _OSocial._telefono = (Txttelefono.Text)
            _OSocial._localidad = (Txtlocalidad.Text)
            _OSocial._provincia = (TxtProvincia.Text)
            _OSocial._descuento = CStr(Val(TxtDescuento.Text))


            If Datos.AgregarOSocial(_OSocial) Then
                MsgBox("Obra Social agregada correctamente!")
            Else
                MsgBox("Error al agregar Obra Social!")
            End If
        End If
    End Sub

    
    Private Sub TxtProvincia_TextChanged(sender As Object, e As EventArgs)

    End Sub

   
End Class