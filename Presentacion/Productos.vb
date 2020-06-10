Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Imports System.Text.RegularExpressions

Public Class Productos

    Private Sub btnCerrarForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCerrarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click
        If (String.IsNullOrEmpty(nombreprod.Text) Or String.IsNullOrEmpty(precioventa.Text) Or String.IsNullOrEmpty(preciocompra.Text) Or String.IsNullOrEmpty(txtcantidad.Text) Or String.IsNullOrEmpty(Cmbtipoproducto.Text) Or String.IsNullOrEmpty(txtdescripcion.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        Else
            limpiar()
            Dim Nombre As String = nombreprod.Text
            Dim precioven As Double = Val(precioventa.Text)
            Dim preciocomp As Double = Val((preciocompra.Text))
            Dim cantidad As Integer = CInt(Val((txtcantidad.Text)))
            Dim tipoprod As String = (Cmbtipoproducto.Text)
            Dim descripcion As String = txtdescripcion.Text

            Dim _Producto As New Producto()
            _Producto._nombre = nombreprod.Text
            _Producto._precioven = Val(precioventa.Text)
            _Producto._preciocomp = Val(preciocompra.Text)
            _Producto._cantidad = CInt(Val((txtcantidad.Text)))
            _Producto._tipoprod = (Cmbtipoproducto.Text)
            _Producto._descripcion = txtdescripcion.Text


            If Datos.AgregarProducto(_Producto) Then
                MsgBox("Producto agregado correctamente!")
            Else
                MsgBox("Error al agregar Producto!")
            End If
        End If
    End Sub

    Public Sub limpiar()
        nombreprod.Text = ""
        precioventa.Text = ""
        preciocompra.Text = ""
        txtcantidad.Text = ""
        Cmbtipoproducto.Text = ""
        txtdescripcion.Text = ""
        nombreprod.Focus()
    End Sub

    
End Class