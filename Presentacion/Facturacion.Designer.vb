<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtFacturacion = New Guna.UI.WinForms.GunaLabel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Totaltxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Subtotaltxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Descuentotxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datelabel = New System.Windows.Forms.Timer(Me.components)
        Me.Btnconfirmar = New System.Windows.Forms.Button()
        Me.GBxDetalle = New Guna.UI.WinForms.GunaGroupBox()
        Me.DgDetalles = New Guna.UI.WinForms.GunaDataGridView()
        Me.GBxClientes = New Guna.UI.WinForms.GunaGroupBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New Guna.UI.WinForms.GunaButton()
        Me.CmbObraSocial = New Guna.UI.WinForms.GunaComboBox()
        Me.Cmbtipodni = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Btnfactura = New System.Windows.Forms.RadioButton()
        Me.Btnboleta = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn = New Guna.UI.WinForms.GunaButton()
        Me.GBxProductos = New Guna.UI.WinForms.GunaGroupBox()
        Me.TxtBuscador = New System.Windows.Forms.TextBox()
        Me.DgProducto = New Guna.UI.WinForms.GunaDataGridView()
        Me.BtnEliminar = New Guna.UI.WinForms.GunaButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBxDetalle.SuspendLayout()
        CType(Me.DgDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBxClientes.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GBxProductos.SuspendLayout()
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtFacturacion)
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 45)
        Me.Panel1.TabIndex = 2
        '
        'TxtFacturacion
        '
        Me.TxtFacturacion.AutoSize = True
        Me.TxtFacturacion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFacturacion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFacturacion.Location = New System.Drawing.Point(453, 12)
        Me.TxtFacturacion.Name = "TxtFacturacion"
        Me.TxtFacturacion.Size = New System.Drawing.Size(136, 25)
        Me.TxtFacturacion.TabIndex = 15
        Me.TxtFacturacion.Text = "FACTURACION"
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
        Me.btnCerrarForm.TabIndex = 14
        Me.btnCerrarForm.TabStop = False
        '
        'Totaltxt
        '
        Me.Totaltxt.Enabled = False
        Me.Totaltxt.Location = New System.Drawing.Point(621, 641)
        Me.Totaltxt.Name = "Totaltxt"
        Me.Totaltxt.ReadOnly = True
        Me.Totaltxt.Size = New System.Drawing.Size(118, 20)
        Me.Totaltxt.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(565, 646)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "TOTAL:"
        '
        'Subtotaltxt
        '
        Me.Subtotaltxt.Enabled = False
        Me.Subtotaltxt.Location = New System.Drawing.Point(129, 643)
        Me.Subtotaltxt.Name = "Subtotaltxt"
        Me.Subtotaltxt.ReadOnly = True
        Me.Subtotaltxt.Size = New System.Drawing.Size(144, 20)
        Me.Subtotaltxt.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 647)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "SUBTOTAL:"
        '
        'Descuentotxt
        '
        Me.Descuentotxt.Enabled = False
        Me.Descuentotxt.Location = New System.Drawing.Point(424, 640)
        Me.Descuentotxt.Name = "Descuentotxt"
        Me.Descuentotxt.ReadOnly = True
        Me.Descuentotxt.Size = New System.Drawing.Size(95, 20)
        Me.Descuentotxt.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(304, 647)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "DESCUENTO:"
        '
        'datelabel
        '
        '
        'Btnconfirmar
        '
        Me.Btnconfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnconfirmar.Location = New System.Drawing.Point(929, 635)
        Me.Btnconfirmar.Name = "Btnconfirmar"
        Me.Btnconfirmar.Size = New System.Drawing.Size(79, 36)
        Me.Btnconfirmar.TabIndex = 34
        Me.Btnconfirmar.Text = "Confirmar"
        Me.Btnconfirmar.UseVisualStyleBackColor = True
        '
        'GBxDetalle
        '
        Me.GBxDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBxDetalle.BackColor = System.Drawing.Color.Transparent
        Me.GBxDetalle.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GBxDetalle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GBxDetalle.Controls.Add(Me.DgDetalles)
        Me.GBxDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBxDetalle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GBxDetalle.LineBottom = 1
        Me.GBxDetalle.LineColor = System.Drawing.Color.Blue
        Me.GBxDetalle.LineLeft = 1
        Me.GBxDetalle.LineRight = 1
        Me.GBxDetalle.Location = New System.Drawing.Point(24, 433)
        Me.GBxDetalle.Name = "GBxDetalle"
        Me.GBxDetalle.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.GBxDetalle.Size = New System.Drawing.Size(968, 184)
        Me.GBxDetalle.TabIndex = 35
        Me.GBxDetalle.Text = "DETALLES"
        Me.GBxDetalle.TextLocation = New System.Drawing.Point(400, 5)
        '
        'DgDetalles
        '
        Me.DgDetalles.AllowUserToAddRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgDetalles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgDetalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DgDetalles.ColumnHeadersHeight = 26
        Me.DgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgDetalles.DefaultCellStyle = DataGridViewCellStyle10
        Me.DgDetalles.EnableHeadersVisualStyles = False
        Me.DgDetalles.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalles.Location = New System.Drawing.Point(36, 39)
        Me.DgDetalles.Name = "DgDetalles"
        Me.DgDetalles.ReadOnly = True
        Me.DgDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgDetalles.RowHeadersVisible = False
        Me.DgDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgDetalles.Size = New System.Drawing.Size(924, 107)
        Me.DgDetalles.TabIndex = 37
        Me.DgDetalles.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgDetalles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgDetalles.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgDetalles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgDetalles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgDetalles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgDetalles.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgDetalles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgDetalles.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDetalles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgDetalles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgDetalles.ThemeStyle.HeaderStyle.Height = 26
        Me.DgDetalles.ThemeStyle.ReadOnly = True
        Me.DgDetalles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgDetalles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgDetalles.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDetalles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgDetalles.ThemeStyle.RowsStyle.Height = 22
        Me.DgDetalles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GBxClientes
        '
        Me.GBxClientes.BackColor = System.Drawing.Color.Transparent
        Me.GBxClientes.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GBxClientes.BorderColor = System.Drawing.Color.Gainsboro
        Me.GBxClientes.Controls.Add(Me.TxtNombre)
        Me.GBxClientes.Controls.Add(Me.BtnLimpiar)
        Me.GBxClientes.Controls.Add(Me.CmbObraSocial)
        Me.GBxClientes.Controls.Add(Me.Cmbtipodni)
        Me.GBxClientes.Controls.Add(Me.Label1)
        Me.GBxClientes.Controls.Add(Me.Label3)
        Me.GBxClientes.Controls.Add(Me.Label4)
        Me.GBxClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBxClientes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GBxClientes.LineBottom = 1
        Me.GBxClientes.LineColor = System.Drawing.Color.Blue
        Me.GBxClientes.LineLeft = 1
        Me.GBxClientes.LineRight = 1
        Me.GBxClientes.Location = New System.Drawing.Point(24, 51)
        Me.GBxClientes.Name = "GBxClientes"
        Me.GBxClientes.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GBxClientes.Size = New System.Drawing.Size(724, 208)
        Me.GBxClientes.TabIndex = 37
        Me.GBxClientes.Text = "DATOS CLIENTES"
        Me.GBxClientes.TextLocation = New System.Drawing.Point(320, 5)
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(138, 81)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(374, 26)
        Me.TxtNombre.TabIndex = 40
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.AnimationHoverSpeed = 0.07!
        Me.BtnLimpiar.AnimationSpeed = 0.03!
        Me.BtnLimpiar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.BorderColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLimpiar.FocusedColor = System.Drawing.Color.Empty
        Me.BtnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnLimpiar.Location = New System.Drawing.Point(24, 156)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnLimpiar.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.OnHoverImage = Nothing
        Me.BtnLimpiar.OnPressedColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Size = New System.Drawing.Size(130, 42)
        Me.BtnLimpiar.TabIndex = 39
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbObraSocial
        '
        Me.CmbObraSocial.BackColor = System.Drawing.Color.Transparent
        Me.CmbObraSocial.BaseColor = System.Drawing.Color.White
        Me.CmbObraSocial.BorderColor = System.Drawing.Color.Silver
        Me.CmbObraSocial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbObraSocial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbObraSocial.FocusedColor = System.Drawing.Color.Empty
        Me.CmbObraSocial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbObraSocial.ForeColor = System.Drawing.Color.Black
        Me.CmbObraSocial.FormattingEnabled = True
        Me.CmbObraSocial.Location = New System.Drawing.Point(137, 119)
        Me.CmbObraSocial.Name = "CmbObraSocial"
        Me.CmbObraSocial.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbObraSocial.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CmbObraSocial.Size = New System.Drawing.Size(569, 26)
        Me.CmbObraSocial.TabIndex = 38
        '
        'Cmbtipodni
        '
        Me.Cmbtipodni.BackColor = System.Drawing.Color.Transparent
        Me.Cmbtipodni.BaseColor = System.Drawing.Color.White
        Me.Cmbtipodni.BorderColor = System.Drawing.Color.Silver
        Me.Cmbtipodni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmbtipodni.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmbtipodni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbtipodni.FocusedColor = System.Drawing.Color.Empty
        Me.Cmbtipodni.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Cmbtipodni.ForeColor = System.Drawing.Color.Black
        Me.Cmbtipodni.FormattingEnabled = True
        Me.Cmbtipodni.Location = New System.Drawing.Point(137, 46)
        Me.Cmbtipodni.Name = "Cmbtipodni"
        Me.Cmbtipodni.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmbtipodni.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Cmbtipodni.Size = New System.Drawing.Size(180, 26)
        Me.Cmbtipodni.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre/Razon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Obra Social"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.Controls.Add(Me.Btnfactura)
        Me.GunaGroupBox2.Controls.Add(Me.Btnboleta)
        Me.GunaGroupBox2.Controls.Add(Me.Label13)
        Me.GunaGroupBox2.Controls.Add(Me.lblfecha)
        Me.GunaGroupBox2.Controls.Add(Me.lblhora)
        Me.GunaGroupBox2.Controls.Add(Me.Label2)
        Me.GunaGroupBox2.Controls.Add(Me.Label7)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(755, 52)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Padding = New System.Windows.Forms.Padding(15, 0, 5, 0)
        Me.GunaGroupBox2.Size = New System.Drawing.Size(237, 207)
        Me.GunaGroupBox2.TabIndex = 38
        Me.GunaGroupBox2.Text = "FECHA"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(100, 5)
        '
        'Btnfactura
        '
        Me.Btnfactura.AutoSize = True
        Me.Btnfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfactura.ForeColor = System.Drawing.Color.Black
        Me.Btnfactura.Location = New System.Drawing.Point(98, 184)
        Me.Btnfactura.Name = "Btnfactura"
        Me.Btnfactura.Size = New System.Drawing.Size(66, 19)
        Me.Btnfactura.TabIndex = 25
        Me.Btnfactura.TabStop = True
        Me.Btnfactura.Text = "Factura"
        Me.Btnfactura.UseVisualStyleBackColor = True
        '
        'Btnboleta
        '
        Me.Btnboleta.AutoSize = True
        Me.Btnboleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnboleta.ForeColor = System.Drawing.Color.Black
        Me.Btnboleta.Location = New System.Drawing.Point(98, 152)
        Me.Btnboleta.Name = "Btnboleta"
        Me.Btnboleta.Size = New System.Drawing.Size(60, 19)
        Me.Btnboleta.TabIndex = 24
        Me.Btnboleta.TabStop = True
        Me.Btnboleta.Text = "Boleta"
        Me.Btnboleta.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(83, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Tipo de Documento"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.Black
        Me.lblfecha.Location = New System.Drawing.Point(116, 56)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(50, 15)
        Me.lblfecha.TabIndex = 22
        Me.lblfecha.Text = "lblfecha"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.Black
        Me.lblhora.Location = New System.Drawing.Point(118, 105)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(45, 15)
        Me.lblhora.TabIndex = 21
        Me.lblhora.Text = "lblhora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(116, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(116, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Hora"
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
        Me.Btn.Location = New System.Drawing.Point(24, 104)
        Me.Btn.Name = "Btn"
        Me.Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn.OnHoverImage = Nothing
        Me.Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Btn.Size = New System.Drawing.Size(130, 42)
        Me.Btn.TabIndex = 34
        Me.Btn.Text = "Agregar"
        Me.Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GBxProductos
        '
        Me.GBxProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBxProductos.BackColor = System.Drawing.Color.Transparent
        Me.GBxProductos.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GBxProductos.BorderColor = System.Drawing.Color.Gainsboro
        Me.GBxProductos.Controls.Add(Me.TxtBuscador)
        Me.GBxProductos.Controls.Add(Me.DgProducto)
        Me.GBxProductos.Controls.Add(Me.Btn)
        Me.GBxProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBxProductos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GBxProductos.LineBottom = 1
        Me.GBxProductos.LineColor = System.Drawing.Color.Blue
        Me.GBxProductos.LineLeft = 1
        Me.GBxProductos.LineRight = 1
        Me.GBxProductos.Location = New System.Drawing.Point(24, 265)
        Me.GBxProductos.Name = "GBxProductos"
        Me.GBxProductos.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.GBxProductos.Size = New System.Drawing.Size(968, 164)
        Me.GBxProductos.TabIndex = 36
        Me.GBxProductos.Text = "LISTADO PRODUCTOS"
        Me.GBxProductos.TextLocation = New System.Drawing.Point(400, 5)
        '
        'TxtBuscador
        '
        Me.TxtBuscador.Location = New System.Drawing.Point(24, 51)
        Me.TxtBuscador.Name = "TxtBuscador"
        Me.TxtBuscador.Size = New System.Drawing.Size(200, 26)
        Me.TxtBuscador.TabIndex = 41
        '
        'DgProducto
        '
        Me.DgProducto.AllowUserToAddRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgProducto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgProducto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DgProducto.ColumnHeadersHeight = 26
        Me.DgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgProducto.DefaultCellStyle = DataGridViewCellStyle13
        Me.DgProducto.EnableHeadersVisualStyles = False
        Me.DgProducto.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.Location = New System.Drawing.Point(245, 39)
        Me.DgProducto.Name = "DgProducto"
        Me.DgProducto.ReadOnly = True
        Me.DgProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgProducto.RowHeadersVisible = False
        Me.DgProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgProducto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DgProducto.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgProducto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProducto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProducto.Size = New System.Drawing.Size(705, 107)
        Me.DgProducto.TabIndex = 36
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
        Me.DgProducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgProducto.ThemeStyle.RowsStyle.Height = 22
        Me.DgProducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BtnEliminar
        '
        Me.BtnEliminar.AnimationHoverSpeed = 0.07!
        Me.BtnEliminar.AnimationSpeed = 0.03!
        Me.BtnEliminar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEliminar.BorderColor = System.Drawing.Color.Black
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnEliminar.FocusedColor = System.Drawing.Color.Empty
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnEliminar.Location = New System.Drawing.Point(755, 627)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnEliminar.OnHoverImage = Nothing
        Me.BtnEliminar.OnPressedColor = System.Drawing.Color.Black
        Me.BtnEliminar.Size = New System.Drawing.Size(130, 42)
        Me.BtnEliminar.TabIndex = 39
        Me.BtnEliminar.Text = "    ELIMINAR"
        Me.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1020, 681)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GBxClientes)
        Me.Controls.Add(Me.GBxProductos)
        Me.Controls.Add(Me.GBxDetalle)
        Me.Controls.Add(Me.Btnconfirmar)
        Me.Controls.Add(Me.Totaltxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Subtotaltxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Descuentotxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FACTURACION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBxDetalle.ResumeLayout(False)
        CType(Me.DgDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBxClientes.ResumeLayout(False)
        Me.GBxClientes.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.GBxProductos.ResumeLayout(False)
        Me.GBxProductos.PerformLayout()
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Totaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Subtotaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Descuentotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents datelabel As System.Windows.Forms.Timer
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents Btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents GBxDetalle As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GBxClientes As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Btnfactura As System.Windows.Forms.RadioButton
    Friend WithEvents Btnboleta As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnLimpiar As Guna.UI.WinForms.GunaButton
    Friend WithEvents CmbObraSocial As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Cmbtipodni As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents TxtFacturacion As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents GBxProductos As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents DgProducto As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents DgDetalles As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents BtnEliminar As Guna.UI.WinForms.GunaButton
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuscador As System.Windows.Forms.TextBox
End Class
