Imports System.Data.SqlClient

Public Class ObraSocial

    Private Sub btnCerrarForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub



    Public Sub RefrescarListaObraSocial()
        DgListadoOB.DataSource = Datos.ObtenerDataTableObraS()
        'DgDetalleClientes.Columns(0).Visible = False
        'DgDetalleClientes.Columns(10).Visible = False
    End Sub


    Public Sub limpiar()
        TxtNombre.Text = ""
        Txtdireccion.Text = ""
        Txtprovincia.Text = ""
        Txtlocalidad.Text = ""
        Txttelefono.Text = ""
        Txtdescuento.Text = ""
        TxtNombre.Focus()
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click
        If (String.IsNullOrEmpty(TxtNombre.Text) Or String.IsNullOrEmpty(Txtdireccion.Text) Or String.IsNullOrEmpty(Txtprovincia.Text) Or String.IsNullOrEmpty(Txtlocalidad.Text) Or String.IsNullOrEmpty(Txttelefono.Text) Or String.IsNullOrEmpty(Txtdescuento.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf Datos.ExisteObraSocial(TxtNombre.Text) Then
            MessageBox.Show("La Obra Social ya esta registrado, por favor intente nuevamente")
        Else
            Dim nombre As String = TxtNombre.Text
            Dim direccion As String = Txtdireccion.Text
            Dim Localidad As String = Txtlocalidad.Text
            Dim Provincia As String = Txtprovincia.Text
            Dim telefono As Integer = CInt(((Txttelefono.Text)))
            Dim descuento As Double = CDbl(Txtdescuento.Text)

            Dim _OSocial As New OSocial()
            _OSocial._nombre = TxtNombre.Text
            _OSocial._direccion = (Txtdireccion.Text)
            _OSocial._localidad = (Txtlocalidad.Text)
            _OSocial._provincia = (Txtprovincia.Text)
            _OSocial._telefono = (Txttelefono.Text)
            _OSocial._descuento = CStr(CDbl(Txtdescuento.Text))


            If Datos.AgregarOSocial(_OSocial) Then
                MsgBox("Obra Social agregada correctamente!")
            Else
                MsgBox("Error al agregar Obra Social!")
            End If
        End If
        limpiar()
        RefrescarListaObraSocial()
    End Sub








    Private Sub ObraSocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescarListaObraSocial()
    End Sub

    Private Sub DgListadoOB_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgListadoOB.CellDoubleClick
        Dim i As Integer
        i = DgListadoOB.CurrentRow.Index

        TxtNombre.Text = CStr(DgListadoOB.Item(1, i).Value())
        Txtdireccion.Text = CStr(DgListadoOB.Item(2, i).Value())
        Txtprovincia.Text = CStr(DgListadoOB.Item(3, i).Value())
        Txtlocalidad.Text = CStr(DgListadoOB.Item(4, i).Value())
        Txttelefono.Text = CStr(DgListadoOB.Item(5, i).Value())
        Txtdescuento.Text = CStr(DgListadoOB.Item(6, i).Value())
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If (String.IsNullOrEmpty(TxtNombre.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        Else
            Dim Nombre As String = TxtNombre.Text
            Dim query As String = "delete ObraSocial where Nombre = @Nombre"
            Using con As SqlConnection = New SqlConnection("Data Source=LEO-PC;Initial Catalog=Tesis;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Nombre", Nombre)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Obra Social Eliminada Satisfactorimente")
                End Using
            End Using
            limpiar()
            TxtNombre.Focus()
        End If
        RefrescarListaObraSocial()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

    End Sub
End Class