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
            'limpiar()

            Dim nombre As String = nombreprod.Text
            Dim precioven As Double = Val(precioventa.Text)
            Dim preciocomp As Double = Val((preciocompra.Text))

            ' Dim cantidad As Integer = CInt(Val((txtcantidad.Text)))

            Dim cantidad As Integer = CInt((Val((txtcantidad.Text))))
            Dim tipoprod As String = (Cmbtipoproducto.Text)
            Dim descripcion As String = txtdescripcion.Text

            Dim _Producto As New Producto()
            _Producto._nombre = nombreprod.Text
            _Producto._PrecioVenta = Val(precioventa.Text)
            _Producto._PrecioCompra = Val(preciocompra.Text)
            '_Producto._cantidad = CInt(Val((txtcantidad.Text)))
            _Producto._tipoprod = (Cmbtipoproducto.Text)
            _Producto._descripcion = txtdescripcion.Text


            If Datos.AgregarProducto(_Producto) Then
                MsgBox("Producto agregado correctamente!")
            Else
                MsgBox("Error al agregar Producto!")
            End If
            'limpiar()
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


   
   

    
    Private Sub Btnborrar_Click(sender As Object, e As EventArgs) Handles Btnborrar.Click
        Dim nombreproducto As String = nombreprod.Text
        Dim query As String = "delete Producto where nombre = @nombre"
        Using con As SqlConnection = New SqlConnection("Data Source=LEO-PC;Initial Catalog=Tesis;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@nombre", nombreproducto)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Producto Eliminado Satisfactorimente")
                'bindata()
                nombreprod.Focus()
                nombreprod.Clear()
                txtdescripcion.Clear()
                Cmbtipoproducto.Text = ""
                preciocompra.Clear()
                precioventa.Clear()
            End Using
        End Using

    End Sub

    'Private Sub Productos_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Try
    '        Cmbtipoproducto.Items.Clear()
    '        Dim _Tipos As List(Of String) = Datos.ObtenerTiposProductos()
    '        For Each _Tipo As String In _Tipos
    '            Cmbtipoproducto.Items.Add(_Tipo)
    '        Next


    '    Catch ex As Exception

    '    End Try
    'End Sub
End Class