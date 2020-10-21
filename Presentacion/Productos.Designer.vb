<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbLProductos = New System.Windows.Forms.Label()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.DgProducto = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Btn = New Guna.UI.WinForms.GunaButton()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Txtlaboratorio = New System.Windows.Forms.TextBox()
        Me.Txtpreciocompra = New System.Windows.Forms.TextBox()
        Me.Txtprecioventa = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.CantidadLbl = New System.Windows.Forms.Label()
        Me.CmbTipoproducto = New Guna.UI.WinForms.GunaComboBox()
        Me.Lbltipoprod = New System.Windows.Forms.Label()
        Me.LaboratorioLbl = New System.Windows.Forms.Label()
        Me.Lblpreciocom = New System.Windows.Forms.Label()
        Me.Lblprecioven = New System.Windows.Forms.Label()
        Me.Lbldescripcion = New System.Windows.Forms.Label()
        Me.Lblnombreproducto = New System.Windows.Forms.Label()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(894, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 13
        Me.btnCerrarForm.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbLProductos)
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 45)
        Me.Panel1.TabIndex = 14
        '
        'lbLProductos
        '
        Me.lbLProductos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbLProductos.AutoSize = True
        Me.lbLProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLProductos.Location = New System.Drawing.Point(411, 10)
        Me.lbLProductos.Name = "lbLProductos"
        Me.lbLProductos.Size = New System.Drawing.Size(128, 24)
        Me.lbLProductos.TabIndex = 1
        Me.lbLProductos.Text = "PRODUCTOS"
        Me.lbLProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btnborrar
        '
        Me.Btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnborrar.Location = New System.Drawing.Point(543, 250)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(90, 40)
        Me.Btnborrar.TabIndex = 8
        Me.Btnborrar.Text = "BORRAR"
        Me.Btnborrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(499, 190)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 40)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Btnagregar
        '
        Me.Btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnagregar.Location = New System.Drawing.Point(668, 257)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(90, 40)
        Me.Btnagregar.TabIndex = 6
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.UseVisualStyleBackColor = True
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.DgProducto)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 370)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.GunaGroupBox1.Size = New System.Drawing.Size(898, 298)
        Me.GunaGroupBox1.TabIndex = 46
        Me.GunaGroupBox1.Text = "DETALLE PRODUCTOS"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(400, 5)
        '
        'DgProducto
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgProducto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgProducto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgProducto.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgProducto.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgProducto.EnableHeadersVisualStyles = False
        Me.DgProducto.GridColor = System.Drawing.Color.White
        Me.DgProducto.Location = New System.Drawing.Point(24, 52)
        Me.DgProducto.Name = "DgProducto"
        Me.DgProducto.RowHeadersVisible = False
        Me.DgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProducto.Size = New System.Drawing.Size(854, 228)
        Me.DgProducto.TabIndex = 1
        Me.DgProducto.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgProducto.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProducto.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DgProducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgProducto.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgProducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgProducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgProducto.ThemeStyle.HeaderStyle.Height = 4
        Me.DgProducto.ThemeStyle.ReadOnly = False
        Me.DgProducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgProducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgProducto.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgProducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgProducto.ThemeStyle.RowsStyle.Height = 22
        Me.DgProducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.GunaButton2)
        Me.GunaGroupBox2.Controls.Add(Me.GunaButton1)
        Me.GunaGroupBox2.Controls.Add(Me.Btn)
        Me.GunaGroupBox2.Controls.Add(Me.Txtdescripcion)
        Me.GunaGroupBox2.Controls.Add(Me.Txtcantidad)
        Me.GunaGroupBox2.Controls.Add(Me.Txtlaboratorio)
        Me.GunaGroupBox2.Controls.Add(Me.Txtpreciocompra)
        Me.GunaGroupBox2.Controls.Add(Me.Txtprecioventa)
        Me.GunaGroupBox2.Controls.Add(Me.TxtNombre)
        Me.GunaGroupBox2.Controls.Add(Me.CantidadLbl)
        Me.GunaGroupBox2.Controls.Add(Me.CmbTipoproducto)
        Me.GunaGroupBox2.Controls.Add(Me.Lbltipoprod)
        Me.GunaGroupBox2.Controls.Add(Me.LaboratorioLbl)
        Me.GunaGroupBox2.Controls.Add(Me.Lblpreciocom)
        Me.GunaGroupBox2.Controls.Add(Me.Lblprecioven)
        Me.GunaGroupBox2.Controls.Add(Me.Lbldescripcion)
        Me.GunaGroupBox2.Controls.Add(Me.Lblnombreproducto)
        Me.GunaGroupBox2.Controls.Add(Me.Btnagregar)
        Me.GunaGroupBox2.Controls.Add(Me.BtnEditar)
        Me.GunaGroupBox2.Controls.Add(Me.Btnborrar)
        Me.GunaGroupBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(12, 61)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.GunaGroupBox2.Size = New System.Drawing.Size(898, 303)
        Me.GunaGroupBox2.TabIndex = 47
        Me.GunaGroupBox2.Text = "ALTA PRODUCTOS"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(400, 5)
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(648, 149)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton2.TabIndex = 75
        Me.GunaButton2.Text = "Agregar"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(648, 99)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton1.TabIndex = 74
        Me.GunaButton1.Text = "Agregar"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn
        '
        Me.Btn.AnimationHoverSpeed = 0.07!
        Me.Btn.AnimationSpeed = 0.03!
        Me.Btn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn.BorderColor = System.Drawing.Color.Black
        Me.Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn.ForeColor = System.Drawing.Color.White
        Me.Btn.Image = CType(resources.GetObject("Btn.Image"), System.Drawing.Image)
        Me.Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn.Location = New System.Drawing.Point(648, 49)
        Me.Btn.Name = "Btn"
        Me.Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn.OnHoverImage = Nothing
        Me.Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Btn.Size = New System.Drawing.Size(130, 42)
        Me.Btn.TabIndex = 73
        Me.Btn.Text = "Agregar"
        Me.Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(163, 264)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(374, 26)
        Me.Txtdescripcion.TabIndex = 72
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(162, 227)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(126, 26)
        Me.Txtcantidad.TabIndex = 71
        '
        'Txtlaboratorio
        '
        Me.Txtlaboratorio.Location = New System.Drawing.Point(162, 149)
        Me.Txtlaboratorio.Name = "Txtlaboratorio"
        Me.Txtlaboratorio.Size = New System.Drawing.Size(374, 26)
        Me.Txtlaboratorio.TabIndex = 70
        '
        'Txtpreciocompra
        '
        Me.Txtpreciocompra.Location = New System.Drawing.Point(162, 114)
        Me.Txtpreciocompra.Name = "Txtpreciocompra"
        Me.Txtpreciocompra.Size = New System.Drawing.Size(126, 26)
        Me.Txtpreciocompra.TabIndex = 69
        '
        'Txtprecioventa
        '
        Me.Txtprecioventa.Location = New System.Drawing.Point(163, 81)
        Me.Txtprecioventa.Name = "Txtprecioventa"
        Me.Txtprecioventa.Size = New System.Drawing.Size(125, 26)
        Me.Txtprecioventa.TabIndex = 68
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(163, 49)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(374, 26)
        Me.TxtNombre.TabIndex = 67
        '
        'CantidadLbl
        '
        Me.CantidadLbl.AutoSize = True
        Me.CantidadLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadLbl.Location = New System.Drawing.Point(20, 227)
        Me.CantidadLbl.Margin = New System.Windows.Forms.Padding(5)
        Me.CantidadLbl.Name = "CantidadLbl"
        Me.CantidadLbl.Padding = New System.Windows.Forms.Padding(5)
        Me.CantidadLbl.Size = New System.Drawing.Size(87, 30)
        Me.CantidadLbl.TabIndex = 65
        Me.CantidadLbl.Text = "Cantidad:"
        '
        'CmbTipoproducto
        '
        Me.CmbTipoproducto.BackColor = System.Drawing.Color.Transparent
        Me.CmbTipoproducto.BaseColor = System.Drawing.Color.White
        Me.CmbTipoproducto.BorderColor = System.Drawing.Color.Silver
        Me.CmbTipoproducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbTipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoproducto.FocusedColor = System.Drawing.Color.Empty
        Me.CmbTipoproducto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbTipoproducto.ForeColor = System.Drawing.Color.Black
        Me.CmbTipoproducto.FormattingEnabled = True
        Me.CmbTipoproducto.Location = New System.Drawing.Point(162, 190)
        Me.CmbTipoproducto.Name = "CmbTipoproducto"
        Me.CmbTipoproducto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbTipoproducto.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CmbTipoproducto.Size = New System.Drawing.Size(289, 26)
        Me.CmbTipoproducto.TabIndex = 63
        '
        'Lbltipoprod
        '
        Me.Lbltipoprod.AutoSize = True
        Me.Lbltipoprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipoprod.Location = New System.Drawing.Point(20, 186)
        Me.Lbltipoprod.Margin = New System.Windows.Forms.Padding(5)
        Me.Lbltipoprod.Name = "Lbltipoprod"
        Me.Lbltipoprod.Padding = New System.Windows.Forms.Padding(5)
        Me.Lbltipoprod.Size = New System.Drawing.Size(53, 30)
        Me.Lbltipoprod.TabIndex = 57
        Me.Lbltipoprod.Text = "Tipo:"
        '
        'LaboratorioLbl
        '
        Me.LaboratorioLbl.AccessibleName = ""
        Me.LaboratorioLbl.AutoSize = True
        Me.LaboratorioLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratorioLbl.Location = New System.Drawing.Point(20, 151)
        Me.LaboratorioLbl.Margin = New System.Windows.Forms.Padding(5)
        Me.LaboratorioLbl.Name = "LaboratorioLbl"
        Me.LaboratorioLbl.Padding = New System.Windows.Forms.Padding(5)
        Me.LaboratorioLbl.Size = New System.Drawing.Size(104, 30)
        Me.LaboratorioLbl.TabIndex = 56
        Me.LaboratorioLbl.Text = "Laboratorio:"
        '
        'Lblpreciocom
        '
        Me.Lblpreciocom.AutoSize = True
        Me.Lblpreciocom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpreciocom.Location = New System.Drawing.Point(20, 111)
        Me.Lblpreciocom.Margin = New System.Windows.Forms.Padding(5)
        Me.Lblpreciocom.Name = "Lblpreciocom"
        Me.Lblpreciocom.Padding = New System.Windows.Forms.Padding(5)
        Me.Lblpreciocom.Size = New System.Drawing.Size(127, 30)
        Me.Lblpreciocom.TabIndex = 55
        Me.Lblpreciocom.Text = "Precio Compra:"
        '
        'Lblprecioven
        '
        Me.Lblprecioven.AutoSize = True
        Me.Lblprecioven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprecioven.Location = New System.Drawing.Point(20, 75)
        Me.Lblprecioven.Margin = New System.Windows.Forms.Padding(5)
        Me.Lblprecioven.Name = "Lblprecioven"
        Me.Lblprecioven.Padding = New System.Windows.Forms.Padding(5)
        Me.Lblprecioven.Size = New System.Drawing.Size(114, 30)
        Me.Lblprecioven.TabIndex = 54
        Me.Lblprecioven.Text = "Precio Venta:"
        '
        'Lbldescripcion
        '
        Me.Lbldescripcion.AutoSize = True
        Me.Lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldescripcion.Location = New System.Drawing.Point(20, 260)
        Me.Lbldescripcion.Margin = New System.Windows.Forms.Padding(5)
        Me.Lbldescripcion.Name = "Lbldescripcion"
        Me.Lbldescripcion.Padding = New System.Windows.Forms.Padding(5)
        Me.Lbldescripcion.Size = New System.Drawing.Size(106, 30)
        Me.Lbldescripcion.TabIndex = 53
        Me.Lbldescripcion.Text = "Descripción:"
        '
        'Lblnombreproducto
        '
        Me.Lblnombreproducto.AutoSize = True
        Me.Lblnombreproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombreproducto.Location = New System.Drawing.Point(20, 39)
        Me.Lblnombreproducto.Margin = New System.Windows.Forms.Padding(5)
        Me.Lblnombreproducto.Name = "Lblnombreproducto"
        Me.Lblnombreproducto.Padding = New System.Windows.Forms.Padding(5)
        Me.Lblnombreproducto.Size = New System.Drawing.Size(79, 30)
        Me.Lblnombreproducto.TabIndex = 52
        Me.Lblnombreproducto.Text = "Nombre:"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(922, 680)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbLProductos As System.Windows.Forms.Label
    Friend WithEvents Btnborrar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Btnagregar As System.Windows.Forms.Button
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents DgProducto As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Lbltipoprod As System.Windows.Forms.Label
    Friend WithEvents LaboratorioLbl As System.Windows.Forms.Label
    Friend WithEvents Lblpreciocom As System.Windows.Forms.Label
    Friend WithEvents Lblprecioven As System.Windows.Forms.Label
    Friend WithEvents Lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents Lblnombreproducto As System.Windows.Forms.Label
    Friend WithEvents CmbTipoproducto As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents CantidadLbl As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Txtlaboratorio As System.Windows.Forms.TextBox
    Friend WithEvents Txtpreciocompra As System.Windows.Forms.TextBox
    Friend WithEvents Txtprecioventa As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn As Guna.UI.WinForms.GunaButton
End Class
