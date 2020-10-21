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
        If (String.IsNullOrEmpty(TxtNombre.Text) Or String.IsNullOrEmpty(Txtprecioventa.Text) Or String.IsNullOrEmpty(Txtpreciocompra.Text) Or String.IsNullOrEmpty(Txtlaboratorio.Text) Or String.IsNullOrEmpty(CmbTipoproducto.Text) Or String.IsNullOrEmpty(Txtdescripcion.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        Else
            'limpiar()

            Dim nombre As String = TxtNombre.Text
            Dim precioven As Double = Val(Txtprecioventa.Text)
            Dim preciocomp As Double = Val((Txtpreciocompra.Text))
            Dim cantidad As Integer = CInt(Val((Txtcantidad.Text)))
            'Dim cantidad As Integer = (Val((cantidadTxt.Text)))
            Dim tipoprod As String = (CmbTipoproducto.Text)
            Dim descripcion As String = Txtdescripcion.Text

            Dim _Producto As New Producto()
            _Producto._Nombre = TxtNombre.Text
            _Producto._PrecioVenta = Val(Txtprecioventa.Text)
            _Producto._PrecioCompra = Val(Txtpreciocompra.Text)
            _Producto._cantidad = CInt((Val((Txtcantidad.Text))))
            _Producto._TipoProd = (CmbTipoproducto.Text)
            _Producto._Descripcion = Txtdescripcion.Text


            If Datos.AgregarProducto(_Producto) Then
                MsgBox("Producto agregado correctamente!")
            Else
                MsgBox("Error al agregar Producto!")
            End If
            limpiar()
        End If
    End Sub

    Public Sub limpiar()
        TxtNombre.Text = ""
        Txtprecioventa.Text = ""
        Txtpreciocompra.Text = ""
        Txtcantidad.Text = ""
        Cmbtipoproducto.Text = ""
        Txtdescripcion.Text = ""
        TxtNombre.Focus()
    End Sub


   
   

    
    Private Sub Btnborrar_Click(sender As Object, e As EventArgs) Handles Btnborrar.Click
        Dim nombreproducto As String = TxtNombre.Text
        Dim query As String = "delete Producto where nombre = @nombre"
        Using con As SqlConnection = New SqlConnection("Data Source=LEO-PC;Initial Catalog=Tesis;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@nombre", nombreproducto)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Producto Eliminado Satisfactorimente")
                'bindata()
                limpiar()
                TxtNombre.Focus()
                
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

   
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Dim nombreproducto As String = TxtNombre.Text
        Dim query As String = "delete Producto where nombre = @nombre"
        Using con As SqlConnection = New SqlConnection("Data Source=LEO-PC;Initial Catalog=Tesis;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@nombre", nombreproducto)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Producto Eliminado Satisfactorimente")
                'bindata()
                limpiar()
                TxtNombre.Focus()

            End Using
        End Using
    End Sub
End Class