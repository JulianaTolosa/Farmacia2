<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panelbotones = New System.Windows.Forms.Panel()
        Me.btnDrogueria = New System.Windows.Forms.Button()
        Me.btnMediospago = New System.Windows.Forms.Button()
        Me.btnOSocial = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.PanelsubmenuVentas = New System.Windows.Forms.Panel()
        Me.btnconsultaventa = New System.Windows.Forms.Button()
        Me.btnfacturacion = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelsubmenuStock = New System.Windows.Forms.Panel()
        Me.btnconsultastock = New System.Windows.Forms.Button()
        Me.btningreso = New System.Windows.Forms.Button()
        Me.btnDepositos = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.btnmenu = New System.Windows.Forms.PictureBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPosicion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.TmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip8 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip9 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip10 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip11 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip12 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip13 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip14 = New System.Windows.Forms.ToolTip(Me.components)
        Me.horafecha = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        Me.Panelbotones.SuspendLayout()
        Me.PanelsubmenuVentas.SuspendLayout()
        Me.PanelsubmenuStock.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelLateral)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(899, 612)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.White
        Me.PanelFormularios.Controls.Add(Me.lblfecha)
        Me.PanelFormularios.Controls.Add(Me.lblhora)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(230, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(669, 572)
        Me.PanelFormularios.TabIndex = 2
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(206, 196)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(113, 37)
        Me.lblfecha.TabIndex = 1
        Me.lblfecha.Text = "Label2"
        '
        'lblhora
        '
        Me.lblhora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(263, 85)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(226, 73)
        Me.lblhora.TabIndex = 0
        Me.lblhora.Text = "Label2"
        '
        'PanelLateral
        '
        Me.PanelLateral.AutoScroll = True
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PanelLateral.Controls.Add(Me.Panelbotones)
        Me.PanelLateral.Controls.Add(Me.PanelUsuario)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 40)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(230, 572)
        Me.PanelLateral.TabIndex = 1
        '
        'Panelbotones
        '
        Me.Panelbotones.AutoScroll = True
        Me.Panelbotones.Controls.Add(Me.btnDrogueria)
        Me.Panelbotones.Controls.Add(Me.btnMediospago)
        Me.Panelbotones.Controls.Add(Me.btnOSocial)
        Me.Panelbotones.Controls.Add(Me.btnProductos)
        Me.Panelbotones.Controls.Add(Me.PanelsubmenuVentas)
        Me.Panelbotones.Controls.Add(Me.btnVentas)
        Me.Panelbotones.Controls.Add(Me.btnSalir)
        Me.Panelbotones.Controls.Add(Me.PanelsubmenuStock)
        Me.Panelbotones.Controls.Add(Me.btnDepositos)
        Me.Panelbotones.Controls.Add(Me.btnEmpleados)
        Me.Panelbotones.Controls.Add(Me.btnClientes)
        Me.Panelbotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelbotones.Location = New System.Drawing.Point(0, 123)
        Me.Panelbotones.Name = "Panelbotones"
        Me.Panelbotones.Size = New System.Drawing.Size(230, 449)
        Me.Panelbotones.TabIndex = 1
        '
        'btnDrogueria
        '
        Me.btnDrogueria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDrogueria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDrogueria.FlatAppearance.BorderSize = 0
        Me.btnDrogueria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrogueria.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDrogueria.Image = CType(resources.GetObject("btnDrogueria.Image"), System.Drawing.Image)
        Me.btnDrogueria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDrogueria.Location = New System.Drawing.Point(0, 550)
        Me.btnDrogueria.Name = "btnDrogueria"
        Me.btnDrogueria.Size = New System.Drawing.Size(213, 50)
        Me.btnDrogueria.TabIndex = 8
        Me.btnDrogueria.Text = "DROGUERIAS"
        Me.btnDrogueria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDrogueria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip13.SetToolTip(Me.btnDrogueria, "DROGUERIAS")
        Me.btnDrogueria.UseCompatibleTextRendering = True
        Me.btnDrogueria.UseVisualStyleBackColor = True
        '
        'btnMediospago
        '
        Me.btnMediospago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMediospago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMediospago.FlatAppearance.BorderSize = 0
        Me.btnMediospago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMediospago.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMediospago.Image = CType(resources.GetObject("btnMediospago.Image"), System.Drawing.Image)
        Me.btnMediospago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMediospago.Location = New System.Drawing.Point(0, 500)
        Me.btnMediospago.Name = "btnMediospago"
        Me.btnMediospago.Size = New System.Drawing.Size(213, 50)
        Me.btnMediospago.TabIndex = 7
        Me.btnMediospago.Text = "MEDIOS DE PAGO"
        Me.btnMediospago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMediospago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip12.SetToolTip(Me.btnMediospago, "MEDIOS DE PAGO")
        Me.btnMediospago.UseCompatibleTextRendering = True
        Me.btnMediospago.UseVisualStyleBackColor = True
        '
        'btnOSocial
        '
        Me.btnOSocial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOSocial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOSocial.FlatAppearance.BorderSize = 0
        Me.btnOSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOSocial.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnOSocial.Image = CType(resources.GetObject("btnOSocial.Image"), System.Drawing.Image)
        Me.btnOSocial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOSocial.Location = New System.Drawing.Point(0, 450)
        Me.btnOSocial.Name = "btnOSocial"
        Me.btnOSocial.Size = New System.Drawing.Size(213, 50)
        Me.btnOSocial.TabIndex = 6
        Me.btnOSocial.Text = "O. SOCIAL"
        Me.btnOSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOSocial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip11.SetToolTip(Me.btnOSocial, "O.SOCIAL")
        Me.btnOSocial.UseCompatibleTextRendering = True
        Me.btnOSocial.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 400)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(213, 50)
        Me.btnProductos.TabIndex = 5
        Me.btnProductos.Text = "PRODUCTOS"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip10.SetToolTip(Me.btnProductos, "PRODUCTOS")
        Me.btnProductos.UseCompatibleTextRendering = True
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'PanelsubmenuVentas
        '
        Me.PanelsubmenuVentas.Controls.Add(Me.btnconsultaventa)
        Me.PanelsubmenuVentas.Controls.Add(Me.btnfacturacion)
        Me.PanelsubmenuVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelsubmenuVentas.Location = New System.Drawing.Point(0, 300)
        Me.PanelsubmenuVentas.Name = "PanelsubmenuVentas"
        Me.PanelsubmenuVentas.Size = New System.Drawing.Size(213, 100)
        Me.PanelsubmenuVentas.TabIndex = 0
        '
        'btnconsultaventa
        '
        Me.btnconsultaventa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconsultaventa.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnconsultaventa.FlatAppearance.BorderSize = 0
        Me.btnconsultaventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconsultaventa.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnconsultaventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconsultaventa.Location = New System.Drawing.Point(0, 50)
        Me.btnconsultaventa.Name = "btnconsultaventa"
        Me.btnconsultaventa.Size = New System.Drawing.Size(213, 50)
        Me.btnconsultaventa.TabIndex = 3
        Me.btnconsultaventa.Text = "CONSULTA"
        Me.btnconsultaventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip9.SetToolTip(Me.btnconsultaventa, "CONSULTA VENTA")
        Me.btnconsultaventa.UseVisualStyleBackColor = True
        '
        'btnfacturacion
        '
        Me.btnfacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfacturacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnfacturacion.FlatAppearance.BorderSize = 0
        Me.btnfacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfacturacion.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnfacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfacturacion.Location = New System.Drawing.Point(0, 0)
        Me.btnfacturacion.Name = "btnfacturacion"
        Me.btnfacturacion.Size = New System.Drawing.Size(213, 50)
        Me.btnfacturacion.TabIndex = 2
        Me.btnfacturacion.Text = "     FACTURACION"
        Me.btnfacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip8.SetToolTip(Me.btnfacturacion, "FACTURACION VENTA")
        Me.btnfacturacion.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 250)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(213, 50)
        Me.btnVentas.TabIndex = 4
        Me.btnVentas.Text = "   VENTAS"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip7.SetToolTip(Me.btnVentas, "REPORTES")
        Me.btnVentas.UseCompatibleTextRendering = True
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 600)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(213, 50)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip14.SetToolTip(Me.btnSalir, "SALIR")
        Me.btnSalir.UseCompatibleTextRendering = True
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelsubmenuStock
        '
        Me.PanelsubmenuStock.Controls.Add(Me.btnconsultastock)
        Me.PanelsubmenuStock.Controls.Add(Me.btningreso)
        Me.PanelsubmenuStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelsubmenuStock.Location = New System.Drawing.Point(0, 150)
        Me.PanelsubmenuStock.Name = "PanelsubmenuStock"
        Me.PanelsubmenuStock.Size = New System.Drawing.Size(213, 100)
        Me.PanelsubmenuStock.TabIndex = 0
        '
        'btnconsultastock
        '
        Me.btnconsultastock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconsultastock.FlatAppearance.BorderSize = 0
        Me.btnconsultastock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconsultastock.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnconsultastock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconsultastock.Location = New System.Drawing.Point(0, 50)
        Me.btnconsultastock.Name = "btnconsultastock"
        Me.btnconsultastock.Size = New System.Drawing.Size(220, 50)
        Me.btnconsultastock.TabIndex = 1
        Me.btnconsultastock.Text = "CONSULTA"
        Me.btnconsultastock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip5.SetToolTip(Me.btnconsultastock, "CONSULTA STOCK")
        Me.btnconsultastock.UseVisualStyleBackColor = True
        '
        'btningreso
        '
        Me.btningreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btningreso.FlatAppearance.BorderSize = 0
        Me.btningreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btningreso.ForeColor = System.Drawing.Color.Gainsboro
        Me.btningreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btningreso.Location = New System.Drawing.Point(0, 0)
        Me.btningreso.Name = "btningreso"
        Me.btningreso.Size = New System.Drawing.Size(220, 50)
        Me.btningreso.TabIndex = 0
        Me.btningreso.Text = "INGRESOS"
        Me.btningreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip4.SetToolTip(Me.btningreso, "INGRESO STOCK")
        Me.btningreso.UseVisualStyleBackColor = True
        '
        'btnDepositos
        '
        Me.btnDepositos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepositos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDepositos.FlatAppearance.BorderSize = 0
        Me.btnDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDepositos.Image = CType(resources.GetObject("btnDepositos.Image"), System.Drawing.Image)
        Me.btnDepositos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepositos.Location = New System.Drawing.Point(0, 100)
        Me.btnDepositos.Name = "btnDepositos"
        Me.btnDepositos.Size = New System.Drawing.Size(213, 50)
        Me.btnDepositos.TabIndex = 3
        Me.btnDepositos.Text = "   STOCK"
        Me.btnDepositos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDepositos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip3.SetToolTip(Me.btnDepositos, "STOCK")
        Me.btnDepositos.UseCompatibleTextRendering = True
        Me.btnDepositos.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEmpleados.Image = CType(resources.GetObject("btnEmpleados.Image"), System.Drawing.Image)
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 50)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(213, 50)
        Me.btnEmpleados.TabIndex = 2
        Me.btnEmpleados.Text = "  EMPLEADOS"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip2.SetToolTip(Me.btnEmpleados, "EMPLEADOS")
        Me.btnEmpleados.UseCompatibleTextRendering = True
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.AccessibleDescription = ""
        Me.btnClientes.AccessibleName = ""
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 0)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(213, 50)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Tag = ""
        Me.btnClientes.Text = "   CLIENTES"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnClientes, "CLIENTES")
        Me.btnClientes.UseCompatibleTextRendering = True
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'PanelUsuario
        '
        Me.PanelUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelUsuario.Controls.Add(Me.btnmenu)
        Me.PanelUsuario.Controls.Add(Me.lblCorreo)
        Me.PanelUsuario.Controls.Add(Me.lblNombre)
        Me.PanelUsuario.Controls.Add(Me.lblPosicion)
        Me.PanelUsuario.Controls.Add(Me.PictureBox1)
        Me.PanelUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsuario.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(230, 123)
        Me.PanelUsuario.TabIndex = 0
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.Location = New System.Drawing.Point(190, 4)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(32, 32)
        Me.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnmenu.TabIndex = 0
        Me.btnmenu.TabStop = False
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCorreo.Location = New System.Drawing.Point(67, 95)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(44, 13)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "Correo :"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNombre.Location = New System.Drawing.Point(67, 69)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(53, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre : "
        '
        'lblPosicion
        '
        Me.lblPosicion.AutoSize = True
        Me.lblPosicion.BackColor = System.Drawing.Color.Transparent
        Me.lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosicion.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPosicion.Location = New System.Drawing.Point(67, 44)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(53, 13)
        Me.lblPosicion.TabIndex = 0
        Me.lblPosicion.Text = "Posicion :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox2)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(899, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(46, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FARMACIA"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(839, 12)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(808, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(839, 12)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(871, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'TmOcultarMenu
        '
        Me.TmOcultarMenu.Interval = 1
        '
        'tmMostrarMenu
        '
        Me.tmMostrarMenu.Interval = 2
        '
        'horafecha
        '
        Me.horafecha.Enabled = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 612)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(899, 568)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        Me.PanelLateral.ResumeLayout(False)
        Me.Panelbotones.ResumeLayout(False)
        Me.PanelsubmenuVentas.ResumeLayout(False)
        Me.PanelsubmenuStock.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents PanelBarraTitulo As System.Windows.Forms.Panel
    Friend WithEvents btnRestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents PanelLateral As System.Windows.Forms.Panel
    Friend WithEvents PanelUsuario As System.Windows.Forms.Panel
    Friend WithEvents PanelFormularios As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblPosicion As System.Windows.Forms.Label
    Friend WithEvents Panelbotones As System.Windows.Forms.Panel
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.PictureBox
    Friend WithEvents btnEmpleados As System.Windows.Forms.Button
    Friend WithEvents PanelsubmenuStock As System.Windows.Forms.Panel
    Friend WithEvents btnconsultastock As System.Windows.Forms.Button
    Friend WithEvents btningreso As System.Windows.Forms.Button
    Friend WithEvents TmOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents btnDepositos As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents PanelsubmenuVentas As System.Windows.Forms.Panel
    Friend WithEvents btnconsultaventa As System.Windows.Forms.Button
    Friend WithEvents btnfacturacion As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip5 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip9 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip8 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip7 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip6 As System.Windows.Forms.ToolTip
    Friend WithEvents btnDrogueria As System.Windows.Forms.Button
    Friend WithEvents btnMediospago As System.Windows.Forms.Button
    Friend WithEvents btnOSocial As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents ToolTip10 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip11 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip12 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip13 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip14 As System.Windows.Forms.ToolTip
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents horafecha As System.Windows.Forms.Timer

End Class
