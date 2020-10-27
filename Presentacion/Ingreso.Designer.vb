<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblMediosdePago = New System.Windows.Forms.Label()
        Me.GBxDetalle = New Guna.UI.WinForms.GunaGroupBox()
        Me.Dgdetalleprod = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Txtproducto = New System.Windows.Forms.TextBox()
        Me.fechaDT = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Lblfecha = New Guna.UI.WinForms.GunaLabel()
        Me.Lblcantidad = New Guna.UI.WinForms.GunaLabel()
        Me.Lblproducto = New Guna.UI.WinForms.GunaLabel()
        Me.Btnagregar = New Guna.UI.WinForms.GunaButton()
        Me.Btncancelar = New Guna.UI.WinForms.GunaButton()
        Me.Btncancel = New Guna.UI.WinForms.GunaButton()
        Me.Btnguardar = New Guna.UI.WinForms.GunaButton()
        Me.DgProducto = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBxDetalle.SuspendLayout()
        CType(Me.Dgdetalleprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Controls.Add(Me.lblMediosdePago)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 45)
        Me.Panel1.TabIndex = 1
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Location = New System.Drawing.Point(992, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 11
        Me.btnCerrarForm.TabStop = False
        '
        'lblMediosdePago
        '
        Me.lblMediosdePago.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMediosdePago.AutoSize = True
        Me.lblMediosdePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMediosdePago.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMediosdePago.Location = New System.Drawing.Point(432, 12)
        Me.lblMediosdePago.Name = "lblMediosdePago"
        Me.lblMediosdePago.Size = New System.Drawing.Size(164, 24)
        Me.lblMediosdePago.TabIndex = 10
        Me.lblMediosdePago.Text = "INGRESO STOCK"
        Me.lblMediosdePago.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GBxDetalle
        '
        Me.GBxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBxDetalle.BackColor = System.Drawing.Color.Transparent
        Me.GBxDetalle.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GBxDetalle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GBxDetalle.Controls.Add(Me.Dgdetalleprod)
        Me.GBxDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBxDetalle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GBxDetalle.LineBottom = 1
        Me.GBxDetalle.LineColor = System.Drawing.Color.Blue
        Me.GBxDetalle.LineLeft = 1
        Me.GBxDetalle.LineRight = 1
        Me.GBxDetalle.Location = New System.Drawing.Point(12, 295)
        Me.GBxDetalle.Name = "GBxDetalle"
        Me.GBxDetalle.Padding = New System.Windows.Forms.Padding(5, 0, 5, 15)
        Me.GBxDetalle.Size = New System.Drawing.Size(996, 210)
        Me.GBxDetalle.TabIndex = 36
        Me.GBxDetalle.Text = "DETALLES"
        Me.GBxDetalle.TextLocation = New System.Drawing.Point(498, 5)
        '
        'Dgdetalleprod
        '
        Me.Dgdetalleprod.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgdetalleprod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgdetalleprod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgdetalleprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgdetalleprod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgdetalleprod.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgdetalleprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgdetalleprod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgdetalleprod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgdetalleprod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgdetalleprod.ColumnHeadersHeight = 26
        Me.Dgdetalleprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgdetalleprod.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgdetalleprod.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgdetalleprod.EnableHeadersVisualStyles = False
        Me.Dgdetalleprod.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleprod.Location = New System.Drawing.Point(25, 40)
        Me.Dgdetalleprod.Name = "Dgdetalleprod"
        Me.Dgdetalleprod.ReadOnly = True
        Me.Dgdetalleprod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgdetalleprod.RowHeadersVisible = False
        Me.Dgdetalleprod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgdetalleprod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgdetalleprod.Size = New System.Drawing.Size(945, 150)
        Me.Dgdetalleprod.TabIndex = 38
        Me.Dgdetalleprod.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.Dgdetalleprod.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgdetalleprod.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Dgdetalleprod.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgdetalleprod.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Dgdetalleprod.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Dgdetalleprod.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgdetalleprod.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleprod.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleprod.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgdetalleprod.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgdetalleprod.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Dgdetalleprod.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgdetalleprod.ThemeStyle.HeaderStyle.Height = 26
        Me.Dgdetalleprod.ThemeStyle.ReadOnly = True
        Me.Dgdetalleprod.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgdetalleprod.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgdetalleprod.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgdetalleprod.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Dgdetalleprod.ThemeStyle.RowsStyle.Height = 22
        Me.Dgdetalleprod.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleprod.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.DgProducto)
        Me.GunaGroupBox1.Controls.Add(Me.Txtcantidad)
        Me.GunaGroupBox1.Controls.Add(Me.Txtproducto)
        Me.GunaGroupBox1.Controls.Add(Me.fechaDT)
        Me.GunaGroupBox1.Controls.Add(Me.Lblfecha)
        Me.GunaGroupBox1.Controls.Add(Me.Lblcantidad)
        Me.GunaGroupBox1.Controls.Add(Me.Lblproducto)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.GunaGroupBox1.Size = New System.Drawing.Size(996, 174)
        Me.GunaGroupBox1.TabIndex = 37
        Me.GunaGroupBox1.Text = "INGRESOS"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(498, 5)
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(108, 82)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(128, 26)
        Me.Txtcantidad.TabIndex = 7
        '
        'Txtproducto
        '
        Me.Txtproducto.Location = New System.Drawing.Point(108, 40)
        Me.Txtproducto.Name = "Txtproducto"
        Me.Txtproducto.Size = New System.Drawing.Size(241, 26)
        Me.Txtproducto.TabIndex = 6
        '
        'fechaDT
        '
        Me.fechaDT.BaseColor = System.Drawing.Color.White
        Me.fechaDT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fechaDT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fechaDT.CustomFormat = Nothing
        Me.fechaDT.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fechaDT.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fechaDT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fechaDT.ForeColor = System.Drawing.Color.Black
        Me.fechaDT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDT.Location = New System.Drawing.Point(108, 124)
        Me.fechaDT.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fechaDT.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fechaDT.Name = "fechaDT"
        Me.fechaDT.OnHoverBaseColor = System.Drawing.Color.White
        Me.fechaDT.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fechaDT.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fechaDT.OnPressedColor = System.Drawing.Color.Black
        Me.fechaDT.Size = New System.Drawing.Size(241, 26)
        Me.fechaDT.TabIndex = 5
        Me.fechaDT.Text = "09/10/2020"
        Me.fechaDT.Value = New Date(2020, 10, 9, 0, 0, 0, 0)
        '
        'Lblfecha
        '
        Me.Lblfecha.AutoSize = True
        Me.Lblfecha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Lblfecha.Location = New System.Drawing.Point(25, 135)
        Me.Lblfecha.Name = "Lblfecha"
        Me.Lblfecha.Size = New System.Drawing.Size(47, 15)
        Me.Lblfecha.TabIndex = 2
        Me.Lblfecha.Text = "FECHA:"
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Lblcantidad.Location = New System.Drawing.Point(25, 93)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(69, 15)
        Me.Lblcantidad.TabIndex = 1
        Me.Lblcantidad.Text = "CANTIDAD:"
        '
        'Lblproducto
        '
        Me.Lblproducto.AutoSize = True
        Me.Lblproducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Lblproducto.Location = New System.Drawing.Point(25, 51)
        Me.Lblproducto.Name = "Lblproducto"
        Me.Lblproducto.Size = New System.Drawing.Size(73, 15)
        Me.Lblproducto.TabIndex = 0
        Me.Lblproducto.Text = "PRODUCTO:"
        '
        'Btnagregar
        '
        Me.Btnagregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnagregar.AnimationHoverSpeed = 0.07!
        Me.Btnagregar.AnimationSpeed = 0.03!
        Me.Btnagregar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnagregar.BorderColor = System.Drawing.Color.Black
        Me.Btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnagregar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnagregar.FocusedColor = System.Drawing.Color.Empty
        Me.Btnagregar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btnagregar.ForeColor = System.Drawing.Color.White
        Me.Btnagregar.Image = CType(resources.GetObject("Btnagregar.Image"), System.Drawing.Image)
        Me.Btnagregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnagregar.Location = New System.Drawing.Point(663, 241)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnagregar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnagregar.OnHoverImage = Nothing
        Me.Btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnagregar.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Btnagregar.Size = New System.Drawing.Size(160, 42)
        Me.Btnagregar.TabIndex = 38
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btncancelar
        '
        Me.Btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btncancelar.AnimationHoverSpeed = 0.07!
        Me.Btncancelar.AnimationSpeed = 0.03!
        Me.Btncancelar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancelar.BorderColor = System.Drawing.Color.Black
        Me.Btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btncancelar.FocusedColor = System.Drawing.Color.Empty
        Me.Btncancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btncancelar.ForeColor = System.Drawing.Color.White
        Me.Btncancelar.Image = CType(resources.GetObject("Btncancelar.Image"), System.Drawing.Image)
        Me.Btncancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btncancelar.Location = New System.Drawing.Point(848, 241)
        Me.Btncancelar.Name = "Btncancelar"
        Me.Btncancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancelar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btncancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btncancelar.OnHoverImage = Nothing
        Me.Btncancelar.OnPressedColor = System.Drawing.Color.Black
        Me.Btncancelar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Btncancelar.Size = New System.Drawing.Size(160, 42)
        Me.Btncancelar.TabIndex = 39
        Me.Btncancelar.Text = "CANCELAR"
        Me.Btncancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btncancel
        '
        Me.Btncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btncancel.AnimationHoverSpeed = 0.07!
        Me.Btncancel.AnimationSpeed = 0.03!
        Me.Btncancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancel.BorderColor = System.Drawing.Color.Black
        Me.Btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btncancel.FocusedColor = System.Drawing.Color.Empty
        Me.Btncancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btncancel.ForeColor = System.Drawing.Color.White
        Me.Btncancel.Image = CType(resources.GetObject("Btncancel.Image"), System.Drawing.Image)
        Me.Btncancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btncancel.Location = New System.Drawing.Point(848, 520)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btncancel.OnHoverForeColor = System.Drawing.Color.White
        Me.Btncancel.OnHoverImage = Nothing
        Me.Btncancel.OnPressedColor = System.Drawing.Color.Black
        Me.Btncancel.Size = New System.Drawing.Size(160, 42)
        Me.Btncancel.TabIndex = 40
        Me.Btncancel.Text = "CANCELAR"
        Me.Btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btnguardar
        '
        Me.Btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnguardar.AnimationHoverSpeed = 0.07!
        Me.Btnguardar.AnimationSpeed = 0.03!
        Me.Btnguardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnguardar.BorderColor = System.Drawing.Color.Black
        Me.Btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnguardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnguardar.FocusedColor = System.Drawing.Color.Empty
        Me.Btnguardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btnguardar.ForeColor = System.Drawing.Color.White
        Me.Btnguardar.Image = CType(resources.GetObject("Btnguardar.Image"), System.Drawing.Image)
        Me.Btnguardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnguardar.Location = New System.Drawing.Point(663, 520)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnguardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnguardar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnguardar.OnHoverImage = Nothing
        Me.Btnguardar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnguardar.Size = New System.Drawing.Size(160, 42)
        Me.Btnguardar.TabIndex = 41
        Me.Btnguardar.Text = "GUARDAR"
        Me.Btnguardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DgProducto
        '
        Me.DgProducto.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgProducto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgProducto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgProducto.ColumnHeadersHeight = 26
        Me.DgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgProducto.ColumnHeadersVisible = False
        Me.DgProducto.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgProducto.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgProducto.EnableHeadersVisualStyles = False
        Me.DgProducto.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.Location = New System.Drawing.Point(375, 40)
        Me.DgProducto.Name = "DgProducto"
        Me.DgProducto.ReadOnly = True
        Me.DgProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgProducto.RowHeadersVisible = False
        Me.DgProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProducto.Size = New System.Drawing.Size(575, 26)
        Me.DgProducto.TabIndex = 39
        Me.DgProducto.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgProducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgProducto.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProducto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgProducto.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgProducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgProducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgProducto.ThemeStyle.HeaderStyle.Height = 26
        Me.DgProducto.ThemeStyle.ReadOnly = True
        Me.DgProducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgProducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgProducto.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgProducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgProducto.ThemeStyle.RowsStyle.Height = 22
        Me.DgProducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1020, 578)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Btncancelar)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.GBxDetalle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ingreso"
        Me.Text = "Ingreso"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBxDetalle.ResumeLayout(False)
        CType(Me.Dgdetalleprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents lblMediosdePago As System.Windows.Forms.Label
    Friend WithEvents GBxDetalle As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Dgdetalleprod As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents fechaDT As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Lblfecha As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lblcantidad As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lblproducto As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Btnagregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btncancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btncancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btnguardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Txtproducto As System.Windows.Forms.TextBox
    Friend WithEvents DgProducto As Guna.UI.WinForms.GunaDataGridView
End Class
