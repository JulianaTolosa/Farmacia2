<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim lblPosicion As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.DgEmpleados = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Btnborrar = New Guna.UI.WinForms.GunaButton()
        Me.Btneditar = New Guna.UI.WinForms.GunaButton()
        Me.Btnagregar = New Guna.UI.WinForms.GunaButton()
        Me.Btnlimpiar = New Guna.UI.WinForms.GunaButton()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblcontrasena = New System.Windows.Forms.Label()
        Me.Lblnombreusuario = New System.Windows.Forms.Label()
        Me.Txtnombreusuario = New System.Windows.Forms.TextBox()
        Me.Txtcontrasena = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtapellido = New System.Windows.Forms.TextBox()
        Me.cmbposicion = New System.Windows.Forms.ComboBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        lblPosicion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.DgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPosicion
        '
        lblPosicion.AutoSize = True
        lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPosicion.Location = New System.Drawing.Point(30, 196)
        lblPosicion.Name = "lblPosicion"
        lblPosicion.Size = New System.Drawing.Size(72, 20)
        lblPosicion.TabIndex = 34
        lblPosicion.Text = "Posicion:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Controls.Add(Me.lblEmpleados)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 50)
        Me.Panel1.TabIndex = 0
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
        Me.btnCerrarForm.TabIndex = 15
        Me.btnCerrarForm.TabStop = False
        '
        'lblEmpleados
        '
        Me.lblEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEmpleados.Location = New System.Drawing.Point(450, 10)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(127, 24)
        Me.lblEmpleados.TabIndex = 3
        Me.lblEmpleados.Text = "EMPLEADOS"
        Me.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.DgEmpleados)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(24, 323)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.GunaGroupBox1.Size = New System.Drawing.Size(976, 243)
        Me.GunaGroupBox1.TabIndex = 2
        Me.GunaGroupBox1.Text = "EMPLEADOS"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(488, 5)
        '
        'DgEmpleados
        '
        Me.DgEmpleados.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgEmpleados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgEmpleados.ColumnHeadersHeight = 26
        Me.DgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgEmpleados.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgEmpleados.EnableHeadersVisualStyles = False
        Me.DgEmpleados.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmpleados.Location = New System.Drawing.Point(34, 42)
        Me.DgEmpleados.Name = "DgEmpleados"
        Me.DgEmpleados.ReadOnly = True
        Me.DgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgEmpleados.RowHeadersVisible = False
        Me.DgEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgEmpleados.Size = New System.Drawing.Size(907, 188)
        Me.DgEmpleados.TabIndex = 37
        Me.DgEmpleados.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgEmpleados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgEmpleados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgEmpleados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgEmpleados.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgEmpleados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmpleados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmpleados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgEmpleados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEmpleados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgEmpleados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgEmpleados.ThemeStyle.HeaderStyle.Height = 26
        Me.DgEmpleados.ThemeStyle.ReadOnly = True
        Me.DgEmpleados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgEmpleados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgEmpleados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEmpleados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgEmpleados.ThemeStyle.RowsStyle.Height = 22
        Me.DgEmpleados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgEmpleados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.Btnborrar)
        Me.GunaGroupBox2.Controls.Add(Me.Btneditar)
        Me.GunaGroupBox2.Controls.Add(Me.Btnagregar)
        Me.GunaGroupBox2.Controls.Add(Me.Btnlimpiar)
        Me.GunaGroupBox2.Controls.Add(Me.LblCorreo)
        Me.GunaGroupBox2.Controls.Add(Me.LblApellido)
        Me.GunaGroupBox2.Controls.Add(Me.Lblnombre)
        Me.GunaGroupBox2.Controls.Add(Me.Lblcontrasena)
        Me.GunaGroupBox2.Controls.Add(Me.Lblnombreusuario)
        Me.GunaGroupBox2.Controls.Add(Me.Txtnombreusuario)
        Me.GunaGroupBox2.Controls.Add(Me.Txtcontrasena)
        Me.GunaGroupBox2.Controls.Add(Me.Txtnombre)
        Me.GunaGroupBox2.Controls.Add(Me.Txtapellido)
        Me.GunaGroupBox2.Controls.Add(lblPosicion)
        Me.GunaGroupBox2.Controls.Add(Me.cmbposicion)
        Me.GunaGroupBox2.Controls.Add(Me.Txtcorreo)
        Me.GunaGroupBox2.Controls.Add(Me.BtnImprimir)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(24, 67)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.GunaGroupBox2.Size = New System.Drawing.Size(976, 240)
        Me.GunaGroupBox2.TabIndex = 3
        Me.GunaGroupBox2.Text = "DATOS EMPLEADOS"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(488, 5)
        '
        'Btnborrar
        '
        Me.Btnborrar.AnimationHoverSpeed = 0.07!
        Me.Btnborrar.AnimationSpeed = 0.03!
        Me.Btnborrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnborrar.BorderColor = System.Drawing.Color.Black
        Me.Btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnborrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnborrar.FocusedColor = System.Drawing.Color.Empty
        Me.Btnborrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btnborrar.ForeColor = System.Drawing.Color.White
        Me.Btnborrar.Image = Nothing
        Me.Btnborrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnborrar.Location = New System.Drawing.Point(731, 139)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnborrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnborrar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnborrar.OnHoverImage = Nothing
        Me.Btnborrar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnborrar.Size = New System.Drawing.Size(125, 42)
        Me.Btnborrar.TabIndex = 43
        Me.Btnborrar.Text = "BORRAR"
        Me.Btnborrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btneditar
        '
        Me.Btneditar.AnimationHoverSpeed = 0.07!
        Me.Btneditar.AnimationSpeed = 0.03!
        Me.Btneditar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btneditar.BorderColor = System.Drawing.Color.Black
        Me.Btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btneditar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btneditar.FocusedColor = System.Drawing.Color.Empty
        Me.Btneditar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btneditar.ForeColor = System.Drawing.Color.White
        Me.Btneditar.Image = Nothing
        Me.Btneditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btneditar.Location = New System.Drawing.Point(731, 91)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btneditar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btneditar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btneditar.OnHoverImage = Nothing
        Me.Btneditar.OnPressedColor = System.Drawing.Color.Black
        Me.Btneditar.Size = New System.Drawing.Size(125, 42)
        Me.Btneditar.TabIndex = 42
        Me.Btneditar.Text = "EDITAR"
        Me.Btneditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Btnagregar.Location = New System.Drawing.Point(731, 45)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnagregar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnagregar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnagregar.OnHoverImage = Nothing
        Me.Btnagregar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnagregar.Size = New System.Drawing.Size(125, 42)
        Me.Btnagregar.TabIndex = 41
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.AnimationHoverSpeed = 0.07!
        Me.Btnlimpiar.AnimationSpeed = 0.03!
        Me.Btnlimpiar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnlimpiar.BorderColor = System.Drawing.Color.Black
        Me.Btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnlimpiar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnlimpiar.FocusedColor = System.Drawing.Color.Empty
        Me.Btnlimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.Btnlimpiar.Image = Nothing
        Me.Btnlimpiar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnlimpiar.Location = New System.Drawing.Point(731, 185)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnlimpiar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnlimpiar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnlimpiar.OnHoverImage = Nothing
        Me.Btnlimpiar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnlimpiar.Size = New System.Drawing.Size(125, 42)
        Me.Btnlimpiar.TabIndex = 40
        Me.Btnlimpiar.Text = "LIMPIAR"
        Me.Btnlimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.Location = New System.Drawing.Point(30, 166)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(61, 20)
        Me.LblCorreo.TabIndex = 39
        Me.LblCorreo.Text = "Correo:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(30, 136)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(69, 20)
        Me.LblApellido.TabIndex = 38
        Me.LblApellido.Text = "Apellido:"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombre.Location = New System.Drawing.Point(30, 106)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(69, 20)
        Me.Lblnombre.TabIndex = 37
        Me.Lblnombre.Text = "Nombre:"
        '
        'Lblcontrasena
        '
        Me.Lblcontrasena.AutoSize = True
        Me.Lblcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcontrasena.Location = New System.Drawing.Point(30, 76)
        Me.Lblcontrasena.Name = "Lblcontrasena"
        Me.Lblcontrasena.Size = New System.Drawing.Size(96, 20)
        Me.Lblcontrasena.TabIndex = 36
        Me.Lblcontrasena.Text = "Contraseña:"
        '
        'Lblnombreusuario
        '
        Me.Lblnombreusuario.AutoSize = True
        Me.Lblnombreusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombreusuario.Location = New System.Drawing.Point(30, 46)
        Me.Lblnombreusuario.Name = "Lblnombreusuario"
        Me.Lblnombreusuario.Size = New System.Drawing.Size(68, 20)
        Me.Lblnombreusuario.TabIndex = 35
        Me.Lblnombreusuario.Text = "Usuario:"
        '
        'Txtnombreusuario
        '
        Me.Txtnombreusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombreusuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtnombreusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombreusuario.Location = New System.Drawing.Point(150, 46)
        Me.Txtnombreusuario.Name = "Txtnombreusuario"
        Me.Txtnombreusuario.Size = New System.Drawing.Size(150, 19)
        Me.Txtnombreusuario.TabIndex = 24
        '
        'Txtcontrasena
        '
        Me.Txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcontrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcontrasena.Location = New System.Drawing.Point(150, 76)
        Me.Txtcontrasena.Name = "Txtcontrasena"
        Me.Txtcontrasena.Size = New System.Drawing.Size(150, 19)
        Me.Txtcontrasena.TabIndex = 25
        '
        'Txtnombre
        '
        Me.Txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombre.Location = New System.Drawing.Point(150, 106)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(250, 19)
        Me.Txtnombre.TabIndex = 26
        '
        'Txtapellido
        '
        Me.Txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtapellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtapellido.Location = New System.Drawing.Point(150, 136)
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(250, 19)
        Me.Txtapellido.TabIndex = 27
        '
        'cmbposicion
        '
        Me.cmbposicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbposicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbposicion.FormattingEnabled = True
        Me.cmbposicion.Items.AddRange(New Object() {"Administrador", "Encargado", "Vendedor"})
        Me.cmbposicion.Location = New System.Drawing.Point(150, 196)
        Me.cmbposicion.Name = "cmbposicion"
        Me.cmbposicion.Size = New System.Drawing.Size(150, 28)
        Me.cmbposicion.TabIndex = 29
        '
        'Txtcorreo
        '
        Me.Txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcorreo.Location = New System.Drawing.Point(150, 166)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(250, 19)
        Me.Txtcorreo.TabIndex = 28
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Location = New System.Drawing.Point(569, 193)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(90, 40)
        Me.BtnImprimir.TabIndex = 33
        Me.BtnImprimir.Text = "IMPRIMIR"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1020, 578)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.DgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents NombreusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContrasenaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PosicionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents LblCorreo As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents Lblcontrasena As System.Windows.Forms.Label
    Friend WithEvents Lblnombreusuario As System.Windows.Forms.Label
    Friend WithEvents Txtnombreusuario As System.Windows.Forms.TextBox
    Friend WithEvents Txtcontrasena As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents cmbposicion As System.Windows.Forms.ComboBox
    Friend WithEvents Txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents DgEmpleados As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Btnlimpiar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btnborrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btneditar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btnagregar As Guna.UI.WinForms.GunaButton
End Class
