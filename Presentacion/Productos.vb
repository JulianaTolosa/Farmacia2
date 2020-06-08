Public Class Productos

    Private Sub btnCerrarForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCerrarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click
        If (String.IsNullOrEmpty(Txtnombreprod.Text) Or String.IsNullOrEmpty(Txtprecioven.Text) Or String.IsNullOrEmpty(Txtpreciocomp.Text) Or String.IsNullOrEmpty(Txtdescripcion.Text) Or String.IsNullOrEmpty(cmbtipoprod.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        Else
            limpiar()
            Dim Nombre As String = Txtnombreprod.Text
            Dim precioven As Double = CDbl(Txtprecioven.Text)
            Dim preciocomp As Double = CDbl(Txtpreciocomp.Text)
            Dim Descripcion As String = Txtdescripcion.Text

            Dim _Producto As New Producto()
            _Producto._nombre = Txtnombreprod.Text
            _Producto._precioven = CDbl(Txtprecioven.Text)
            _Producto._preciocomp = CDbl(Txtpreciocomp.Text)
            _Producto._descripcion = Txtdescripcion.Text


            If Datos.AgregarProducto(_Producto) Then
                MsgBox("Producto agregado correctamente!")
            Else
                MsgBox("Error al agregar Producto!")
            End If
        End If
    End Sub

    Public Sub limpiar()
        Txtnombreprod.Text = ""
        Txtprecioven.Text = ""
        Txtpreciocomp.Text = ""
        Txtdescripcion.Text = ""
        Txtnombreprod.Focus()
    End Sub
End Class