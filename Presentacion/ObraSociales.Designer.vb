<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraSocial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObraSocial))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbLObraSocial = New System.Windows.Forms.Label()
        Me.DetalleGBx = New Guna.UI.WinForms.GunaGroupBox()
        Me.Btncancelar = New Guna.UI.WinForms.GunaButton()
        Me.BtnEditar = New Guna.UI.WinForms.GunaButton()
        Me.BtnBorrar = New Guna.UI.WinForms.GunaButton()
        Me.Txtdescuento = New System.Windows.Forms.TextBox()
        Me.Txttelefono = New System.Windows.Forms.TextBox()
        Me.Txtlocalidad = New System.Windows.Forms.TextBox()
        Me.Txtprovincia = New System.Windows.Forms.TextBox()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.LblProvincia = New Guna.UI.WinForms.GunaLabel()
        Me.LblTelefono = New Guna.UI.WinForms.GunaLabel()
        Me.LblDireccion = New Guna.UI.WinForms.GunaLabel()
        Me.LblNombre = New Guna.UI.WinForms.GunaLabel()
        Me.LocalidadLbl = New Guna.UI.WinForms.GunaLabel()
        Me.Btnagregar = New Guna.UI.WinForms.GunaButton()
        Me.Lbldescuento = New Guna.UI.WinForms.GunaLabel()
        Me.ListadoOSGBx = New Guna.UI.WinForms.GunaGroupBox()
        Me.DgListadoOB = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.DetalleGBx.SuspendLayout()
        Me.ListadoOSGBx.SuspendLayout()
        CType(Me.DgListadoOB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(992, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 7
        Me.btnCerrarForm.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbLObraSocial)
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 45)
        Me.Panel1.TabIndex = 8
        '
        'lbLObraSocial
        '
        Me.lbLObraSocial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbLObraSocial.AutoSize = True
        Me.lbLObraSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLObraSocial.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbLObraSocial.Location = New System.Drawing.Point(446, 10)
        Me.lbLObraSocial.Name = "lbLObraSocial"
        Me.lbLObraSocial.Size = New System.Drawing.Size(135, 24)
        Me.lbLObraSocial.TabIndex = 8
        Me.lbLObraSocial.Text = "OBRA SOCIAL"
        Me.lbLObraSocial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DetalleGBx
        '
        Me.DetalleGBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleGBx.BackColor = System.Drawing.Color.Transparent
        Me.DetalleGBx.BaseColor = System.Drawing.Color.Transparent
        Me.DetalleGBx.BorderColor = System.Drawing.Color.Gainsboro
        Me.DetalleGBx.Controls.Add(Me.Btncancelar)
        Me.DetalleGBx.Controls.Add(Me.BtnEditar)
        Me.DetalleGBx.Controls.Add(Me.BtnBorrar)
        Me.DetalleGBx.Controls.Add(Me.Txtdescuento)
        Me.DetalleGBx.Controls.Add(Me.Txttelefono)
        Me.DetalleGBx.Controls.Add(Me.Txtlocalidad)
        Me.DetalleGBx.Controls.Add(Me.Txtprovincia)
        Me.DetalleGBx.Controls.Add(Me.Txtdireccion)
        Me.DetalleGBx.Controls.Add(Me.TxtNombre)
        Me.DetalleGBx.Controls.Add(Me.GunaLabel1)
        Me.DetalleGBx.Controls.Add(Me.LblProvincia)
        Me.DetalleGBx.Controls.Add(Me.LblTelefono)
        Me.DetalleGBx.Controls.Add(Me.LblDireccion)
        Me.DetalleGBx.Controls.Add(Me.LblNombre)
        Me.DetalleGBx.Controls.Add(Me.LocalidadLbl)
        Me.DetalleGBx.Controls.Add(Me.Btnagregar)
        Me.DetalleGBx.Controls.Add(Me.Lbldescuento)
        Me.DetalleGBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetalleGBx.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DetalleGBx.LineBottom = 1
        Me.DetalleGBx.LineColor = System.Drawing.Color.Blue
        Me.DetalleGBx.LineLeft = 1
        Me.DetalleGBx.LineRight = 1
        Me.DetalleGBx.Location = New System.Drawing.Point(25, 65)
        Me.DetalleGBx.Name = "DetalleGBx"
        Me.DetalleGBx.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.DetalleGBx.Size = New System.Drawing.Size(976, 243)
        Me.DetalleGBx.TabIndex = 59
        Me.DetalleGBx.Text = "DETALLES"
        Me.DetalleGBx.TextLocation = New System.Drawing.Point(488, 5)
        '
        'Btncancelar
        '
        Me.Btncancelar.AnimationHoverSpeed = 0.07!
        Me.Btncancelar.AnimationSpeed = 0.03!
        Me.Btncancelar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancelar.BorderColor = System.Drawing.Color.Black
        Me.Btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btncancelar.FocusedColor = System.Drawing.Color.Empty
        Me.Btncancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btncancelar.ForeColor = System.Drawing.Color.White
        Me.Btncancelar.Image = Nothing
        Me.Btncancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btncancelar.Location = New System.Drawing.Point(704, 181)
        Me.Btncancelar.Name = "Btncancelar"
        Me.Btncancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancelar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btncancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btncancelar.OnHoverImage = Nothing
        Me.Btncancelar.OnPressedColor = System.Drawing.Color.Black
        Me.Btncancelar.Size = New System.Drawing.Size(141, 42)
        Me.Btncancelar.TabIndex = 83
        Me.Btncancelar.Text = "CANCELAR"
        Me.Btncancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnEditar
        '
        Me.BtnEditar.AnimationHoverSpeed = 0.07!
        Me.BtnEditar.AnimationSpeed = 0.03!
        Me.BtnEditar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditar.BorderColor = System.Drawing.Color.Black
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnEditar.FocusedColor = System.Drawing.Color.Empty
        Me.BtnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = Nothing
        Me.BtnEditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnEditar.Location = New System.Drawing.Point(704, 85)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEditar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnEditar.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnEditar.OnHoverImage = Nothing
        Me.BtnEditar.OnPressedColor = System.Drawing.Color.Black
        Me.BtnEditar.Size = New System.Drawing.Size(141, 42)
        Me.BtnEditar.TabIndex = 82
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnBorrar
        '
        Me.BtnBorrar.AnimationHoverSpeed = 0.07!
        Me.BtnBorrar.AnimationSpeed = 0.03!
        Me.BtnBorrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBorrar.BorderColor = System.Drawing.Color.Black
        Me.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBorrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnBorrar.FocusedColor = System.Drawing.Color.Empty
        Me.BtnBorrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Image = Nothing
        Me.BtnBorrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnBorrar.Location = New System.Drawing.Point(704, 133)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBorrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnBorrar.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnBorrar.OnHoverImage = Nothing
        Me.BtnBorrar.OnPressedColor = System.Drawing.Color.Black
        Me.BtnBorrar.Size = New System.Drawing.Size(141, 42)
        Me.BtnBorrar.TabIndex = 81
        Me.BtnBorrar.Text = "BORRAR"
        Me.BtnBorrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtdescuento
        '
        Me.Txtdescuento.Location = New System.Drawing.Point(150, 194)
        Me.Txtdescuento.Name = "Txtdescuento"
        Me.Txtdescuento.Size = New System.Drawing.Size(87, 26)
        Me.Txtdescuento.TabIndex = 80
        '
        'Txttelefono
        '
        Me.Txttelefono.Location = New System.Drawing.Point(149, 160)
        Me.Txttelefono.Name = "Txttelefono"
        Me.Txttelefono.Size = New System.Drawing.Size(374, 26)
        Me.Txttelefono.TabIndex = 79
        '
        'Txtlocalidad
        '
        Me.Txtlocalidad.Location = New System.Drawing.Point(149, 99)
        Me.Txtlocalidad.Name = "Txtlocalidad"
        Me.Txtlocalidad.Size = New System.Drawing.Size(374, 26)
        Me.Txtlocalidad.TabIndex = 78
        '
        'Txtprovincia
        '
        Me.Txtprovincia.Location = New System.Drawing.Point(149, 130)
        Me.Txtprovincia.Name = "Txtprovincia"
        Me.Txtprovincia.Size = New System.Drawing.Size(374, 26)
        Me.Txtprovincia.TabIndex = 77
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Location = New System.Drawing.Point(149, 68)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(374, 26)
        Me.Txtdireccion.TabIndex = 76
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(149, 37)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(374, 26)
        Me.TxtNombre.TabIndex = 75
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel1.Location = New System.Drawing.Point(250, 195)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(23, 21)
        Me.GunaLabel1.TabIndex = 74
        Me.GunaLabel1.Text = "%"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProvincia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblProvincia.Location = New System.Drawing.Point(29, 138)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(77, 21)
        Me.LblProvincia.TabIndex = 70
        Me.LblProvincia.Text = "Provincia:"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblTelefono.Location = New System.Drawing.Point(29, 165)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(73, 21)
        Me.LblTelefono.TabIndex = 69
        Me.LblTelefono.Text = "Telefono:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblDireccion.Location = New System.Drawing.Point(29, 73)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(78, 21)
        Me.LblDireccion.TabIndex = 68
        Me.LblDireccion.Text = "Direccion:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblNombre.Location = New System.Drawing.Point(29, 44)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(71, 21)
        Me.LblNombre.TabIndex = 67
        Me.LblNombre.Text = "Nombre:"
        '
        'LocalidadLbl
        '
        Me.LocalidadLbl.AutoSize = True
        Me.LocalidadLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalidadLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LocalidadLbl.Location = New System.Drawing.Point(29, 104)
        Me.LocalidadLbl.Name = "LocalidadLbl"
        Me.LocalidadLbl.Size = New System.Drawing.Size(79, 21)
        Me.LocalidadLbl.TabIndex = 62
        Me.LocalidadLbl.Text = "Localidad:"
        '
        'Btnagregar
        '
        Me.Btnagregar.AnimationHoverSpeed = 0.07!
        Me.Btnagregar.AnimationSpeed = 0.03!
        Me.Btnagregar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnagregar.BorderColor = System.Drawing.Color.Black
        Me.Btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnagregar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnagregar.FocusedColor = System.Drawing.Color.Empty
        Me.Btnagregar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btnagregar.ForeColor = System.Drawing.Color.White
        Me.Btnagregar.Image = Nothing
        Me.Btnagregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnagregar.Location = New System.Drawing.Point(704, 37)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnagregar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnagregar.OnHoverImage = Nothing
        Me.Btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnagregar.Size = New System.Drawing.Size(141, 42)
        Me.Btnagregar.TabIndex = 61
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbldescuento
        '
        Me.Lbldescuento.AutoSize = True
        Me.Lbldescuento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldescuento.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lbldescuento.Location = New System.Drawing.Point(29, 198)
        Me.Lbldescuento.Name = "Lbldescuento"
        Me.Lbldescuento.Size = New System.Drawing.Size(86, 21)
        Me.Lbldescuento.TabIndex = 59
        Me.Lbldescuento.Text = "Descuento:"
        '
        'ListadoOSGBx
        '
        Me.ListadoOSGBx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoOSGBx.BackColor = System.Drawing.Color.Transparent
        Me.ListadoOSGBx.BaseColor = System.Drawing.Color.Transparent
        Me.ListadoOSGBx.BorderColor = System.Drawing.Color.Gainsboro
        Me.ListadoOSGBx.Controls.Add(Me.DgListadoOB)
        Me.ListadoOSGBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoOSGBx.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListadoOSGBx.LineBottom = 1
        Me.ListadoOSGBx.LineColor = System.Drawing.Color.Blue
        Me.ListadoOSGBx.LineLeft = 1
        Me.ListadoOSGBx.LineRight = 1
        Me.ListadoOSGBx.Location = New System.Drawing.Point(25, 324)
        Me.ListadoOSGBx.Name = "ListadoOSGBx"
        Me.ListadoOSGBx.Padding = New System.Windows.Forms.Padding(10, 20, 10, 0)
        Me.ListadoOSGBx.Size = New System.Drawing.Size(976, 243)
        Me.ListadoOSGBx.TabIndex = 60
        Me.ListadoOSGBx.Text = "LISTADOS"
        Me.ListadoOSGBx.TextLocation = New System.Drawing.Point(488, 5)
        '
        'DgListadoOB
        '
        Me.DgListadoOB.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgListadoOB.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgListadoOB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgListadoOB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgListadoOB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgListadoOB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgListadoOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgListadoOB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgListadoOB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgListadoOB.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgListadoOB.ColumnHeadersHeight = 26
        Me.DgListadoOB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgListadoOB.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgListadoOB.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgListadoOB.EnableHeadersVisualStyles = False
        Me.DgListadoOB.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgListadoOB.Location = New System.Drawing.Point(27, 43)
        Me.DgListadoOB.Name = "DgListadoOB"
        Me.DgListadoOB.ReadOnly = True
        Me.DgListadoOB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgListadoOB.RowHeadersVisible = False
        Me.DgListadoOB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgListadoOB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgListadoOB.Size = New System.Drawing.Size(907, 188)
        Me.DgListadoOB.TabIndex = 38
        Me.DgListadoOB.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgListadoOB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgListadoOB.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgListadoOB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgListadoOB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgListadoOB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgListadoOB.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgListadoOB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgListadoOB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgListadoOB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgListadoOB.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgListadoOB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgListadoOB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgListadoOB.ThemeStyle.HeaderStyle.Height = 26
        Me.DgListadoOB.ThemeStyle.ReadOnly = True
        Me.DgListadoOB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgListadoOB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgListadoOB.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgListadoOB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgListadoOB.ThemeStyle.RowsStyle.Height = 22
        Me.DgListadoOB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgListadoOB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ObraSocial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1020, 578)
        Me.Controls.Add(Me.ListadoOSGBx)
        Me.Controls.Add(Me.DetalleGBx)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ObraSocial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Obra Social"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.DetalleGBx.ResumeLayout(False)
        Me.DetalleGBx.PerformLayout()
        Me.ListadoOSGBx.ResumeLayout(False)
        CType(Me.DgListadoOB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbLObraSocial As System.Windows.Forms.Label
    Friend WithEvents DetalleGBx As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents ListadoOSGBx As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Lbldescuento As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Btnagregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents LblProvincia As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblTelefono As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblDireccion As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LblNombre As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LocalidadLbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtlocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Txtprovincia As System.Windows.Forms.TextBox
    Friend WithEvents Txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents BtnBorrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btncancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnEditar As Guna.UI.WinForms.GunaButton
    Friend WithEvents DgListadoOB As Guna.UI.WinForms.GunaDataGridView
End Class
