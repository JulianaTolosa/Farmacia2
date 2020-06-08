Public Class Productos

    Private Sub btnCerrarForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCerrarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click
        If (String.IsNullOrEmpty(Txtnombreprod.Text) Or String.IsNullOrEmpty(Txtprecioven.Text) Or String.IsNullOrEmpty(Txtpreciocomp.Text) Or String.IsNullOrEmpty(Txtdescripcion.Text) Or String.IsNullOrEmpty(cmbtipoprod.Text) then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf 
            limpiar()
        Else
            Dim Nombre As String = NombreTextBox.Text
            Dim Apellido As String = ApellidoTextBox.Text
            Dim Direccion As String = DireccionTextBox.Text
            Dim DNI As Integer = CInt(DniTextBox.Text)
            Dim Telefono As String = TelefonoTextBox.Text
            Dim Celular As String = CelularTextBox.Text
            Dim FechaNacimiento As Date = CDate(NacimientoTextBox.Text)
            Dim Localidad As String = LocalidadTextBox.Text
            Dim Provincia As String = ProvinciaTextBox.Text
            Dim IdObraSocial As String = ObraSocialTextBox.Text

    End Sub
End Class