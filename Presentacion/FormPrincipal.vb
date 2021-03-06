﻿Imports System.Runtime.InteropServices
Imports CapaComun
Imports Dominio



Public Class FormPrincipal
#Region "Funciones del Formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub


    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub


    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub




    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL 
    Public Sub AbrirFormEnPanel(Of Forms As {Form, New})()
        Dim formulario As Form
        formulario = PanelFormularios.Controls.OfType(Of Forms)().FirstOrDefault() 'busca un Formulario en la coleccion

        'Si el Form no fue encontrado,no existe
        If formulario Is Nothing Then
            formulario = New Forms()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
            'AddHandler formulario.FormClosed, AddressOf Me.cerrarformulario

            If formulario.WindowState = FormWindowState.Minimized Then
                formulario.WindowState = FormWindowState.Normal
            End If

            formulario.BringToFront()
        End If
    End Sub

    'METODO PARA OCULTAR SUBMENU
    Private Sub hideSubmenu()
        PanelsubmenuStock.Visible = False
        PanelsubmenuVentas.Visible = False
        '    aca se pueden agregar mas submenus, solo copiar(lo mismo de arriba) y modificar que tipo de submenu es
    End Sub

    'METODO PARA MOSTRAR SUBMENU
    Private Sub showSubmenu(ByVal submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub




    Private Sub FormPrincipal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Utilidades.SetearCadenaConexion()

        managePermissions()
        'security()
        loadUser()
        hideSubmenu()
    End Sub

    'DATOS DE USUARIO EN EL FORM PRINCIPAL
    Private Sub loadUser()
        lblNombre.Text = Utilidades._UsuarioLogueado._Nombre + " " + Utilidades._UsuarioLogueado._Apellido
        lblCorreo.Text = Utilidades._UsuarioLogueado._Correo
        lblPosicion.Text = Utilidades._UsuarioLogueado._Posicion
    End Sub

    'CHEQUEO DE INICIO DE SESION DESDE FORMULARIO PRINCIPAL Y NO DEL LOGIN
    'Private Sub security()
    '    Dim user As New user()

    '    If user.anyMethod(ActiveUser.idusuario) = False Then
    '        MessageBox.Show("¡Error!", " ADVERTENCIA ")
    '        Me.Close()
    '    End If
    'End Sub

    ' HABILITACION DE BOTONES SEGUN EL CARGO
    Private Sub managePermissions()
        If Utilidades._UsuarioLogueado._Posicion = Positions.Encargado Then
            btnClientes.Enabled = True
            btnStock.Enabled = False
            btnEmpleados.Enabled = True

        End If

        If Utilidades._UsuarioLogueado._Posicion = Positions.Vendedor Then
            btnClientes.Enabled = True
            btnStock.Enabled = False
            btnEmpleados.Enabled = True

        End If
    End Sub


    Private Sub btnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        openChildForm(New Ingreso())
        hideSubmenu()
    End Sub

    Private Sub btnConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        openChildForm(New ConsultaStock())
        hideSubmenu()
    End Sub

    Private Sub btnDepositos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        showSubmenu(PanelsubmenuStock)
    End Sub

    Private currentForm As Form = Nothing
    Public Sub openChildForm(ByVal childForm As Form, Optional ByVal CerrarFormAnterior As Boolean = True)
        If CerrarFormAnterior Then
            If currentForm IsNot Nothing Then currentForm.Close()
        End If
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelFormularios.Controls.Add(childForm)
        PanelFormularios.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If PanelLateral.Width = 230 Then
            Me.TmOcultarMenu.Enabled = True
        ElseIf PanelLateral.Width = 70 Then
            tmMostrarMenu.Enabled = True
        Else
            Me.PanelLateral.Width = PanelLateral.Width - 20

        End If
    End Sub



    Private Sub TmOcultarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmOcultarMenu.Tick
        If PanelLateral.Width <= 70 Then
            Me.TmOcultarMenu.Enabled = False
            btnClientes.Text = ""
            btnEmpleados.Text = ""
            btnStock.Text = ""
            Btningreso.Text = ""
            Btnconsultastock.Text = ""
            btnVentas.Text = ""
            btnfacturacion.Text = ""
            btnconsultaventa.Text = ""
            btnProductos.Text = ""
            btnOSocial.Text = ""
            btnMediospago.Text = ""
            btnListados.Text = ""
            btnSalir.Text = ""
        Else
            Me.PanelLateral.Width = PanelLateral.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarMenu.Tick
        If PanelLateral.Width >= 230 Then
            Me.tmMostrarMenu.Enabled = False
            btnClientes.Text = "CLIENTES"
            btnEmpleados.Text = "EMPLEADOS"
            btnStock.Text = "STOCK"
            Btningreso.Text = "INGRESO"
            Btnconsultastock.Text = "CONSULTAS STOCK"
            btnVentas.Text = "VENTAS"
            btnfacturacion.Text = "FACTURACION"
            btnconsultaventa.Text = "CONSULTAS"
            btnProductos.Text = "PRODUCTOS"
            btnOSocial.Text = "OBRA SOCIAL"
            btnMediospago.Text = "MEDIOS DE PAGO"
            btnListados.Text = "LISTADOS"
            btnSalir.Text = "SALIR"
        Else
            Me.PanelLateral.Width = PanelLateral.Width + 20

        End If
    End Sub



    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If MessageBox.Show("Esta seguro que desea cerrar sesion?", "ADVERTENCIA",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Hide()
            Utilidades.SetearIdDeMySettings(0)
            Login.Show()
            'lblNombre.Text = " "
            'lblCorreo.Text = " "
            'lblPosicion.Text = " "
        End If
    End Sub








    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        openChildForm(New Clientes())
        hideSubmenu()
    End Sub


    Private Sub btnEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpleados.Click
        openChildForm(Empleados)
    End Sub

    Private Sub btnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        openChildForm(New Ventas())
        hideSubmenu()
    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        openChildForm(New Productos())
        hideSubmenu()
    End Sub

    Private Sub btnOSocial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOSocial.Click
        openChildForm(New ObraSocial())
        hideSubmenu()
    End Sub

    Private Sub btnMediospago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMediospago.Click
        openChildForm(New MediosdePago())
        hideSubmenu()
    End Sub

    Private Sub btnDrogueria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListados.Click
        openChildForm(New Listados())
        hideSubmenu()
    End Sub

    Private Sub horafecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles horafecha.Tick
        lblhora.Text = DateTime.Now.ToLongTimeString
        lblfecha.Text = DateTime.Now.ToLongDateString
    End Sub





    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Private Sub btnVentas_Click_1(sender As Object, e As EventArgs) Handles btnVentas.Click
        showSubmenu(PanelsubmenuVentas)
    End Sub

    Private Sub btnfacturacion_Click(sender As Object, e As EventArgs) Handles btnfacturacion.Click
        openChildForm(New Facturacion())
        hideSubmenu()
    End Sub

    Private Sub btnconsultaventa_Click(sender As Object, e As EventArgs) Handles btnconsultaventa.Click
        openChildForm(New ConsultaVentas())
        hideSubmenu()
    End Sub

    Private Sub Btningreso_Click_1(sender As Object, e As EventArgs) Handles Btningreso.Click
        openChildForm(New Ingreso())
        hideSubmenu()
    End Sub

    Private Sub Btnconsultastock_Click(sender As Object, e As EventArgs) Handles Btnconsultastock.Click
        openChildForm(New ConsultaStock())
        hideSubmenu()
    End Sub



    

    
End Class

