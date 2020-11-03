<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.Paneltitulo = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Btnlimpiar = New Guna.UI.WinForms.GunaButton()
        Me.Btnborrar = New Guna.UI.WinForms.GunaButton()
        Me.Btneditar = New Guna.UI.WinForms.GunaButton()
        Me.dnitxt = New System.Windows.Forms.TextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.fechadate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.telefonotxt = New System.Windows.Forms.TextBox()
        Me.localidadtxt = New System.Windows.Forms.TextBox()
        Me.provinciatxt = New System.Windows.Forms.TextBox()
        Me.direcciontxt = New System.Windows.Forms.TextBox()
        Me.nombretxt = New System.Windows.Forms.TextBox()
        Me.apellidotxt = New System.Windows.Forms.TextBox()
        Me.Celulartxt = New System.Windows.Forms.TextBox()
        Me.Dnicmb = New Guna.UI.WinForms.GunaComboBox()
        Me.ObraSocialcmb = New Guna.UI.WinForms.GunaComboBox()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.DgDetalleClientes = New Guna.UI.WinForms.GunaDataGridView()
        Me.Paneltitulo.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.DgDetalleClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClientes
        '
        Me.lblClientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.ForeColor = System.Drawing.Color.White
        Me.lblClientes.Location = New System.Drawing.Point(456, 9)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(101, 24)
        Me.lblClientes.TabIndex = 0
        Me.lblClientes.Text = "CLIENTES"
        Me.lblClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Paneltitulo
        '
        Me.Paneltitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Paneltitulo.Controls.Add(Me.lblClientes)
        Me.Paneltitulo.Controls.Add(Me.btnCerrarForm)
        Me.Paneltitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Paneltitulo.Location = New System.Drawing.Point(0, 0)
        Me.Paneltitulo.Name = "Paneltitulo"
        Me.Paneltitulo.Size = New System.Drawing.Size(1020, 45)
        Me.Paneltitulo.TabIndex = 9
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(992, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 0
        Me.btnCerrarForm.TabStop = False
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.Btnlimpiar)
        Me.GunaGroupBox1.Controls.Add(Me.Btnborrar)
        Me.GunaGroupBox1.Controls.Add(Me.Btneditar)
        Me.GunaGroupBox1.Controls.Add(Me.dnitxt)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaGroupBox1.Controls.Add(Me.fechadate)
        Me.GunaGroupBox1.Controls.Add(Me.telefonotxt)
        Me.GunaGroupBox1.Controls.Add(Me.localidadtxt)
        Me.GunaGroupBox1.Controls.Add(Me.provinciatxt)
        Me.GunaGroupBox1.Controls.Add(Me.direcciontxt)
        Me.GunaGroupBox1.Controls.Add(Me.nombretxt)
        Me.GunaGroupBox1.Controls.Add(Me.apellidotxt)
        Me.GunaGroupBox1.Controls.Add(Me.Celulartxt)
        Me.GunaGroupBox1.Controls.Add(Me.Dnicmb)
        Me.GunaGroupBox1.Controls.Add(Me.ObraSocialcmb)
        Me.GunaGroupBox1.Controls.Add(Me.btnGuardar)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel11)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel10)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(28, 53)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.GunaGroupBox1.Size = New System.Drawing.Size(967, 367)
        Me.GunaGroupBox1.TabIndex = 33
        Me.GunaGroupBox1.Text = "ALTA CLIENTES"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(433, 5)
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
        Me.Btnlimpiar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.Btnlimpiar.Image = Nothing
        Me.Btnlimpiar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnlimpiar.Location = New System.Drawing.Point(688, 220)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnlimpiar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnlimpiar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnlimpiar.OnHoverImage = Nothing
        Me.Btnlimpiar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnlimpiar.Size = New System.Drawing.Size(136, 42)
        Me.Btnlimpiar.TabIndex = 37
        Me.Btnlimpiar.Text = "LIMPIAR"
        Me.Btnlimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Btnborrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnborrar.ForeColor = System.Drawing.Color.White
        Me.Btnborrar.Image = Nothing
        Me.Btnborrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnborrar.Location = New System.Drawing.Point(688, 172)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnborrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btnborrar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btnborrar.OnHoverImage = Nothing
        Me.Btnborrar.OnPressedColor = System.Drawing.Color.Black
        Me.Btnborrar.Size = New System.Drawing.Size(136, 42)
        Me.Btnborrar.TabIndex = 36
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
        Me.Btneditar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btneditar.ForeColor = System.Drawing.Color.White
        Me.Btneditar.Image = Nothing
        Me.Btneditar.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btneditar.Location = New System.Drawing.Point(688, 124)
        Me.Btneditar.Name = "Btneditar"
        Me.Btneditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btneditar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btneditar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btneditar.OnHoverImage = Nothing
        Me.Btneditar.OnPressedColor = System.Drawing.Color.Black
        Me.Btneditar.Size = New System.Drawing.Size(136, 42)
        Me.Btneditar.TabIndex = 35
        Me.Btneditar.Text = "EDITAR"
        Me.Btneditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dnitxt
        '
        Me.dnitxt.Location = New System.Drawing.Point(27, 105)
        Me.dnitxt.Name = "dnitxt"
        Me.dnitxt.Size = New System.Drawing.Size(169, 26)
        Me.dnitxt.TabIndex = 34
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.White
        Me.GunaLabel8.Location = New System.Drawing.Point(23, 83)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(94, 21)
        Me.GunaLabel8.TabIndex = 33
        Me.GunaLabel8.Text = "Documento:"
        '
        'fechadate
        '
        Me.fechadate.BaseColor = System.Drawing.Color.White
        Me.fechadate.BorderColor = System.Drawing.Color.Silver
        Me.fechadate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fechadate.CustomFormat = Nothing
        Me.fechadate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fechadate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fechadate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fechadate.ForeColor = System.Drawing.Color.Black
        Me.fechadate.Location = New System.Drawing.Point(321, 265)
        Me.fechadate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fechadate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fechadate.Name = "fechadate"
        Me.fechadate.OnHoverBaseColor = System.Drawing.Color.White
        Me.fechadate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fechadate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fechadate.OnPressedColor = System.Drawing.Color.Black
        Me.fechadate.Size = New System.Drawing.Size(243, 30)
        Me.fechadate.TabIndex = 32
        Me.fechadate.Text = "miércoles, 21 de octubre de 2020"
        Me.fechadate.Value = New Date(2020, 10, 21, 12, 16, 41, 578)
        '
        'telefonotxt
        '
        Me.telefonotxt.Location = New System.Drawing.Point(28, 326)
        Me.telefonotxt.Name = "telefonotxt"
        Me.telefonotxt.Size = New System.Drawing.Size(169, 26)
        Me.telefonotxt.TabIndex = 31
        '
        'localidadtxt
        '
        Me.localidadtxt.Location = New System.Drawing.Point(321, 212)
        Me.localidadtxt.Name = "localidadtxt"
        Me.localidadtxt.Size = New System.Drawing.Size(278, 26)
        Me.localidadtxt.TabIndex = 30
        '
        'provinciatxt
        '
        Me.provinciatxt.Location = New System.Drawing.Point(321, 155)
        Me.provinciatxt.Name = "provinciatxt"
        Me.provinciatxt.Size = New System.Drawing.Size(278, 26)
        Me.provinciatxt.TabIndex = 29
        '
        'direcciontxt
        '
        Me.direcciontxt.Location = New System.Drawing.Point(321, 99)
        Me.direcciontxt.Name = "direcciontxt"
        Me.direcciontxt.Size = New System.Drawing.Size(278, 26)
        Me.direcciontxt.TabIndex = 28
        '
        'nombretxt
        '
        Me.nombretxt.Location = New System.Drawing.Point(28, 152)
        Me.nombretxt.Name = "nombretxt"
        Me.nombretxt.Size = New System.Drawing.Size(169, 26)
        Me.nombretxt.TabIndex = 27
        '
        'apellidotxt
        '
        Me.apellidotxt.Location = New System.Drawing.Point(27, 212)
        Me.apellidotxt.Name = "apellidotxt"
        Me.apellidotxt.Size = New System.Drawing.Size(169, 26)
        Me.apellidotxt.TabIndex = 26
        '
        'Celulartxt
        '
        Me.Celulartxt.Location = New System.Drawing.Point(28, 269)
        Me.Celulartxt.Name = "Celulartxt"
        Me.Celulartxt.Size = New System.Drawing.Size(169, 26)
        Me.Celulartxt.TabIndex = 25
        '
        'Dnicmb
        '
        Me.Dnicmb.BackColor = System.Drawing.Color.Transparent
        Me.Dnicmb.BaseColor = System.Drawing.Color.White
        Me.Dnicmb.BorderColor = System.Drawing.Color.Silver
        Me.Dnicmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dnicmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Dnicmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dnicmb.FocusedColor = System.Drawing.Color.Empty
        Me.Dnicmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dnicmb.ForeColor = System.Drawing.Color.Black
        Me.Dnicmb.FormattingEnabled = True
        Me.Dnicmb.Location = New System.Drawing.Point(27, 57)
        Me.Dnicmb.Name = "Dnicmb"
        Me.Dnicmb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dnicmb.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Dnicmb.Size = New System.Drawing.Size(170, 26)
        Me.Dnicmb.TabIndex = 24
        '
        'ObraSocialcmb
        '
        Me.ObraSocialcmb.BackColor = System.Drawing.Color.Transparent
        Me.ObraSocialcmb.BaseColor = System.Drawing.Color.White
        Me.ObraSocialcmb.BorderColor = System.Drawing.Color.Silver
        Me.ObraSocialcmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ObraSocialcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ObraSocialcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ObraSocialcmb.FocusedColor = System.Drawing.Color.Empty
        Me.ObraSocialcmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ObraSocialcmb.ForeColor = System.Drawing.Color.Black
        Me.ObraSocialcmb.FormattingEnabled = True
        Me.ObraSocialcmb.Location = New System.Drawing.Point(321, 326)
        Me.ObraSocialcmb.Name = "ObraSocialcmb"
        Me.ObraSocialcmb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ObraSocialcmb.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ObraSocialcmb.Size = New System.Drawing.Size(503, 26)
        Me.ObraSocialcmb.TabIndex = 23
        '
        'btnGuardar
        '
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Nothing
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(688, 76)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Size = New System.Drawing.Size(136, 42)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.White
        Me.GunaLabel11.Location = New System.Drawing.Point(319, 128)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(77, 21)
        Me.GunaLabel11.TabIndex = 21
        Me.GunaLabel11.Text = "Provincia:"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.White
        Me.GunaLabel10.Location = New System.Drawing.Point(23, 298)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(73, 21)
        Me.GunaLabel10.TabIndex = 19
        Me.GunaLabel10.Text = "Telefono:"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.White
        Me.GunaLabel9.Location = New System.Drawing.Point(23, 184)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(70, 21)
        Me.GunaLabel9.TabIndex = 17
        Me.GunaLabel9.Text = "Apellido:"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(317, 184)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(79, 21)
        Me.GunaLabel7.TabIndex = 13
        Me.GunaLabel7.Text = "Localidad:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(317, 75)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(78, 21)
        Me.GunaLabel6.TabIndex = 11
        Me.GunaLabel6.Text = "Direccion:"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(23, 128)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(71, 21)
        Me.GunaLabel5.TabIndex = 9
        Me.GunaLabel5.Text = "Nombre:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(322, 298)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(93, 21)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "Obra Social:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(23, 241)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(62, 21)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Celular:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(317, 241)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(137, 21)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Fecha Nacimiento:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(23, 34)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(128, 21)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Tipo Documento:"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.DgDetalleClientes)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(28, 443)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.GunaGroupBox2.Size = New System.Drawing.Size(967, 155)
        Me.GunaGroupBox2.TabIndex = 34
        Me.GunaGroupBox2.Text = "DETALLE CLIENTES"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(433, 5)
        '
        'DgDetalleClientes
        '
        Me.DgDetalleClientes.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgDetalleClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgDetalleClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgDetalleClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgDetalleClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgDetalleClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgDetalleClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgDetalleClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgDetalleClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgDetalleClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgDetalleClientes.ColumnHeadersHeight = 26
        Me.DgDetalleClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgDetalleClientes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgDetalleClientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgDetalleClientes.EnableHeadersVisualStyles = False
        Me.DgDetalleClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalleClientes.Location = New System.Drawing.Point(16, 38)
        Me.DgDetalleClientes.Name = "DgDetalleClientes"
        Me.DgDetalleClientes.ReadOnly = True
        Me.DgDetalleClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgDetalleClientes.RowHeadersVisible = False
        Me.DgDetalleClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgDetalleClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgDetalleClientes.Size = New System.Drawing.Size(936, 103)
        Me.DgDetalleClientes.TabIndex = 38
        Me.DgDetalleClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgDetalleClientes.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgDetalleClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.Height = 26
        Me.DgDetalleClientes.ThemeStyle.ReadOnly = True
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.Height = 22
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Clientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1020, 620)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Paneltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes"
        Me.Paneltitulo.ResumeLayout(False)
        Me.Paneltitulo.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        CType(Me.DgDetalleClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents Paneltitulo As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents IdClientesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ObraSocialcmb As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents DgDetalleClientes As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Dnicmb As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Celulartxt As System.Windows.Forms.TextBox
    Friend WithEvents fechadate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents telefonotxt As System.Windows.Forms.TextBox
    Friend WithEvents localidadtxt As System.Windows.Forms.TextBox
    Friend WithEvents provinciatxt As System.Windows.Forms.TextBox
    Friend WithEvents direcciontxt As System.Windows.Forms.TextBox
    Friend WithEvents nombretxt As System.Windows.Forms.TextBox
    Friend WithEvents apellidotxt As System.Windows.Forms.TextBox
    Friend WithEvents dnitxt As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Btnlimpiar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btnborrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btneditar As Guna.UI.WinForms.GunaButton
End Class
