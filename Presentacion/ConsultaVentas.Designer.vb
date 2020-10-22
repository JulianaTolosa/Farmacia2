<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaVentas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblconsultastock = New System.Windows.Forms.Label()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaDateTimePicker2 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Btnbuscar = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Dgdetalleventas = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox3.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.Dgdetalleventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Controls.Add(Me.lblconsultastock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 45)
        Me.Panel1.TabIndex = 2
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
        'lblconsultastock
        '
        Me.lblconsultastock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblconsultastock.AutoSize = True
        Me.lblconsultastock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconsultastock.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblconsultastock.Location = New System.Drawing.Point(426, 12)
        Me.lblconsultastock.Name = "lblconsultastock"
        Me.lblconsultastock.Size = New System.Drawing.Size(206, 24)
        Me.lblconsultastock.TabIndex = 2
        Me.lblconsultastock.Text = "CONSULTAS VENTAS"
        Me.lblconsultastock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox3.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox3.Controls.Add(Me.GunaDateTimePicker2)
        Me.GunaGroupBox3.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox3.Controls.Add(Me.GunaDateTimePicker1)
        Me.GunaGroupBox3.Controls.Add(Me.Btnbuscar)
        Me.GunaGroupBox3.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox3.LineBottom = 1
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox3.LineLeft = 1
        Me.GunaGroupBox3.LineRight = 1
        Me.GunaGroupBox3.Location = New System.Drawing.Point(25, 60)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Padding = New System.Windows.Forms.Padding(5, 15, 5, 15)
        Me.GunaGroupBox3.Size = New System.Drawing.Size(972, 119)
        Me.GunaGroupBox3.TabIndex = 40
        Me.GunaGroupBox3.Text = "BUSQUEDA POR FECHAS"
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(486, 5)
        '
        'GunaDateTimePicker2
        '
        Me.GunaDateTimePicker2.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker2.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker2.CustomFormat = Nothing
        Me.GunaDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker2.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker2.Location = New System.Drawing.Point(491, 54)
        Me.GunaDateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker2.Name = "GunaDateTimePicker2"
        Me.GunaDateTimePicker2.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker2.Size = New System.Drawing.Size(252, 30)
        Me.GunaDateTimePicker2.TabIndex = 17
        Me.GunaDateTimePicker2.Text = "miércoles, 30 de septiembre de 2020"
        Me.GunaDateTimePicker2.Value = New Date(2020, 9, 30, 19, 48, 45, 261)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(400, 58)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(77, 25)
        Me.GunaLabel2.TabIndex = 16
        Me.GunaLabel2.Text = "HASTA:"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker1.CustomFormat = Nothing
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(111, 55)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(252, 30)
        Me.GunaDateTimePicker1.TabIndex = 15
        Me.GunaDateTimePicker1.Text = "miércoles, 30 de septiembre de 2020"
        Me.GunaDateTimePicker1.Value = New Date(2020, 9, 30, 19, 48, 45, 261)
        '
        'Btnbuscar
        '
        Me.Btnbuscar.AnimationHoverSpeed = 0.07!
        Me.Btnbuscar.AnimationSpeed = 0.03!
        Me.Btnbuscar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnbuscar.BorderColor = System.Drawing.Color.Black
        Me.Btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnbuscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnbuscar.FocusedColor = System.Drawing.Color.Empty
        Me.Btnbuscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.ForeColor = System.Drawing.Color.White
        Me.Btnbuscar.Image = CType(resources.GetObject("Btnbuscar.Image"), System.Drawing.Image)
        Me.Btnbuscar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnbuscar.Location = New System.Drawing.Point(790, 49)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnbuscar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnbuscar.OnHoverImage = Nothing
        Me.Btnbuscar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnbuscar.Size = New System.Drawing.Size(160, 42)
        Me.Btnbuscar.TabIndex = 14
        Me.Btnbuscar.Text = "BUSCAR"
        Me.Btnbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(19, 58)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(75, 25)
        Me.GunaLabel1.TabIndex = 13
        Me.GunaLabel1.Text = "DESDE:"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.Dgdetalleventas)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(24, 323)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Padding = New System.Windows.Forms.Padding(5, 15, 5, 15)
        Me.GunaGroupBox1.Size = New System.Drawing.Size(972, 243)
        Me.GunaGroupBox1.TabIndex = 41
        Me.GunaGroupBox1.Text = "DETALLE VENTAS"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(486, 5)
        '
        'Dgdetalleventas
        '
        Me.Dgdetalleventas.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgdetalleventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgdetalleventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgdetalleventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgdetalleventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgdetalleventas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgdetalleventas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgdetalleventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgdetalleventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgdetalleventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgdetalleventas.ColumnHeadersHeight = 26
        Me.Dgdetalleventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgdetalleventas.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgdetalleventas.EnableHeadersVisualStyles = False
        Me.Dgdetalleventas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleventas.Location = New System.Drawing.Point(44, 45)
        Me.Dgdetalleventas.Name = "Dgdetalleventas"
        Me.Dgdetalleventas.ReadOnly = True
        Me.Dgdetalleventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgdetalleventas.RowHeadersVisible = False
        Me.Dgdetalleventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgdetalleventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgdetalleventas.Size = New System.Drawing.Size(895, 171)
        Me.Dgdetalleventas.TabIndex = 38
        Me.Dgdetalleventas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.Dgdetalleventas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgdetalleventas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Dgdetalleventas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgdetalleventas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Dgdetalleventas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Dgdetalleventas.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgdetalleventas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleventas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleventas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgdetalleventas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgdetalleventas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Dgdetalleventas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgdetalleventas.ThemeStyle.HeaderStyle.Height = 26
        Me.Dgdetalleventas.ThemeStyle.ReadOnly = True
        Me.Dgdetalleventas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgdetalleventas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgdetalleventas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgdetalleventas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Dgdetalleventas.ThemeStyle.RowsStyle.Height = 22
        Me.Dgdetalleventas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgdetalleventas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.TextBox1)
        Me.GunaGroupBox2.Controls.Add(Me.GunaButton1)
        Me.GunaGroupBox2.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(24, 190)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Padding = New System.Windows.Forms.Padding(5, 15, 5, 15)
        Me.GunaGroupBox2.Size = New System.Drawing.Size(972, 119)
        Me.GunaGroupBox2.TabIndex = 41
        Me.GunaGroupBox2.Text = "BUSQUEDA POR CLIENTES"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(486, 5)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 26)
        Me.TextBox1.TabIndex = 15
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
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(790, 49)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton1.TabIndex = 14
        Me.GunaButton1.Text = "BUSCAR"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(19, 58)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(97, 25)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "NOMBRE:"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1020, 578)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.GunaGroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConsultaVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox3.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.Dgdetalleventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents lblconsultastock As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Btnbuscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaDateTimePicker2 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Dgdetalleventas As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
