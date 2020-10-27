'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Imports System.Text.RegularExpressions

'prueba2

Public Class Empleados
    Private _IdUsuarioSeleccionado As Integer = 0

    Private Sub btnCerrarForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub


    Private Sub Btnnuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (String.IsNullOrEmpty(Txtnombreusuario.Text) Or String.IsNullOrEmpty(Txtcontrasena.Text) Or String.IsNullOrEmpty(Txtnombre.Text) Or String.IsNullOrEmpty(Txtapellido.Text) Or String.IsNullOrEmpty(cmbposicion.Text) Or String.IsNullOrEmpty(Txtcorreo.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf validar_Mail(Txtcorreo.Text) = False Then
            MessageBox.Show("Dirección de correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " & _
    " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK)
            Txtcorreo.Focus()
            Txtcorreo.SelectAll()
        ElseIf Datos.ExisteUsuario(Txtnombreusuario.Text) Then
            MessageBox.Show("El usuario ya esta registrado, por favor intente nuevamente")
            limpiar()
        Else
            Dim nombreusuario As String = Txtnombreusuario.Text
            Dim contrasena As String = Txtcontrasena.Text
            Dim nombre As String = Txtnombre.Text
            Dim apellido As String = Txtapellido.Text
            Dim posicion As String = cmbposicion.Text
            Dim correo As String = Txtcorreo.Text

            Dim _Usuario As New Usuario()
            _Usuario._NombreUsuario = Txtnombreusuario.Text
            _Usuario._Contraseña = Txtcontrasena.Text
            _Usuario._Nombre = Txtnombre.Text
            _Usuario._Apellido = Txtapellido.Text
            _Usuario._Posicion = cmbposicion.Text
            _Usuario._Correo = Txtcorreo.Text

            If Datos.AgregarUsuario(_Usuario) Then
                RefrescarListaEmpleados()
                MsgBox("Usuario creado correctamente!")
            Else
                MsgBox("Error al crear el usuario!")
            End If

            limpiar()
        End If

    End Sub

    Public Sub bindata()
        Dim query As String = "select * from Usuario"
        Using con As SqlConnection = New SqlConnection("Data Source=LEO-PC;Initial Catalog=Tesis;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DgEmpleados.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    'Public Sub RefrescarGridEmpleados(_DT As DataTable)
    '    DgEmpleados.DataSource = _DT
    'End Sub


    Public Sub limpiar()
        Txtnombreusuario.Text = ""
        Txtcontrasena.Text = ""
        Txtnombre.Text = ""
        Txtapellido.Text = ""
        cmbposicion.Text = ""
        Txtcorreo.Text = ""
        Txtnombreusuario.Focus()
    End Sub

    Public Function validar_Mail(ByVal Smail As String) As Boolean
        Return Regex.IsMatch(Smail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9:-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub Empleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub





    Public Sub Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        _IdUsuarioSeleccionado = 0
        RefrescarListaEmpleados()

    End Sub

    Public Sub RefrescarListaEmpleados()
        DgEmpleados.DataSource = Datos.ObtenerDataTableEmpleados()
    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function


    Private Sub DgEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEmpleados.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim Row As DataGridViewRow = DgEmpleados.Rows(e.RowIndex)
                'MsgBox(Row.Cells(0).Value)
                _IdUsuarioSeleccionado = CInt(Row.Cells(0).Value)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DgEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Editarempleado.Mostrar(Datos.ObtenerUsuario(_IdUsuarioSeleccionado))
    End Sub

    
    
  
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs)
        'Editarempleado.Show()
        If _IdUsuarioSeleccionado <= 0 Then
            MsgBox("Debe seleccionar un Usuario")
            Exit Sub
        End If

        'Cargo el formulario Editar
        Editarempleado.Mostrar(Datos.ObtenerUsuario(_IdUsuarioSeleccionado))
    End Sub
    


    Private Sub DgEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEmpleados.CellDoubleClick
        Dim i As Integer
        i = DgEmpleados.CurrentRow.Index

        Txtnombreusuario.Text = CStr(DgEmpleados.Item(1, i).Value())
        Txtcontrasena.Text = CStr(DgEmpleados.Item(2, i).Value())
        Txtnombre.Text = CStr(DgEmpleados.Item(3, i).Value())
        Txtapellido.Text = CStr(DgEmpleados.Item(4, i).Value())
        cmbposicion.Text = CStr(DgEmpleados.Item(5, i).Value())
        Txtcorreo.Text = CStr(DgEmpleados.Item(6, i).Value())
    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        limpiar()
    End Sub

   
    Private Sub Btneditar_Click_1(sender As Object, e As EventArgs) Handles Btneditar.Click
        ' Editarempleado.Show()
        If _IdUsuarioSeleccionado <= 0 Then
            MsgBox("Debe seleccionar un Usuario")
            Exit Sub
        End If

        'Cargo el formulario Editar
        Editarempleado.Mostrar(Datos.ObtenerUsuario(_IdUsuarioSeleccionado))
    End Sub

   
    
    Private Sub Btnborrar_Click_2(sender As Object, e As EventArgs) Handles Btnborrar.Click
        If (String.IsNullOrEmpty(Txtnombreusuario.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        Else
            Dim nombreusuario As String = Txtnombreusuario.Text
            Dim query As String = "delete Usuario where nombreusuario = @nombreusuario"
            Using con As SqlConnection = New SqlConnection("Data Source=LEO-PC;Initial Catalog=Tesis;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@nombreusuario", nombreusuario)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Usuario Eliminado Satisfactorimente")
                    bindata()
                    'Txtnombreusuario.Text = ""
                    'Txtcontrasena.Text = ""
                    'Txtnombre.Text = ""
                    'Txtapellido.Text = ""
                    'cmbposicion.Text = ""
                    'Txtcorreo.Text = ""
                    'Txtnombreusuario.Focus()
                End Using
            End Using
            limpiar()
            Txtnombreusuario.Focus()
        End If
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click
        If (String.IsNullOrEmpty(Txtnombreusuario.Text) Or String.IsNullOrEmpty(Txtcontrasena.Text) Or String.IsNullOrEmpty(Txtnombre.Text) Or String.IsNullOrEmpty(Txtapellido.Text) Or String.IsNullOrEmpty(cmbposicion.Text) Or String.IsNullOrEmpty(Txtcorreo.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf validar_Mail(Txtcorreo.Text) = False Then
            MessageBox.Show("Dirección de correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " & _
    " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK)
            Txtcorreo.Focus()
            Txtcorreo.SelectAll()
        ElseIf Datos.ExisteUsuario(Txtnombreusuario.Text) Then
            MessageBox.Show("El usuario ya esta registrado, por favor intente nuevamente")
            limpiar()
        Else

            Dim nombreusuario As String = Txtnombreusuario.Text
            Dim contrasena As String = Txtcontrasena.Text
            Dim nombre As String = Txtnombre.Text
            Dim apellido As String = Txtapellido.Text
            Dim posicion As String = cmbposicion.Text
            Dim correo As String = Txtcorreo.Text

            Dim _Usuario As New Usuario()
            _Usuario._NombreUsuario = Txtnombreusuario.Text
            _Usuario._Contraseña = Txtcontrasena.Text
            _Usuario._Nombre = Txtnombre.Text
            _Usuario._Apellido = Txtapellido.Text
            _Usuario._Posicion = cmbposicion.Text
            _Usuario._Correo = Txtcorreo.Text

            If Datos.AgregarUsuario(_Usuario) Then
                RefrescarListaEmpleados()
                MsgBox("Usuario creado correctamente!")
            Else
                MsgBox("Error al crear el usuario!")
            End If
        End If
        limpiar()
    End Sub


End Class