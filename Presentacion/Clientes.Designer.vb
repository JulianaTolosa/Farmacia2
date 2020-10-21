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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.Paneltitulo = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.ObraSocialcmb = New Guna.UI.WinForms.GunaComboBox()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.ProvinciaTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.TelefonoTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.ApellidoTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.LocalidadTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.DireccionTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.NombreTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.CelularTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.NacimientoTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.DniTextBox = New Guna.UI.WinForms.GunaTextBox()
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
        Me.lblClientes.Location = New System.Drawing.Point(405, 9)
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
        Me.Paneltitulo.Size = New System.Drawing.Size(919, 45)
        Me.Paneltitulo.TabIndex = 9
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(891, 12)
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
        Me.GunaGroupBox1.Controls.Add(Me.ObraSocialcmb)
        Me.GunaGroupBox1.Controls.Add(Me.btnGuardar)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel11)
        Me.GunaGroupBox1.Controls.Add(Me.ProvinciaTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel10)
        Me.GunaGroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel9)
        Me.GunaGroupBox1.Controls.Add(Me.ApellidoTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GunaGroupBox1.Controls.Add(Me.LocalidadTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GunaGroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.CelularTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.NacimientoTextBox)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.DniTextBox)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(28, 53)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.GunaGroupBox1.Size = New System.Drawing.Size(866, 338)
        Me.GunaGroupBox1.TabIndex = 33
        Me.GunaGroupBox1.Text = "ALTA CLIENTES"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(433, 5)
        '
        'ObraSocialcmb
        '
        Me.ObraSocialcmb.BackColor = System.Drawing.Color.Transparent
        Me.ObraSocialcmb.BaseColor = System.Drawing.Color.White
        Me.ObraSocialcmb.BorderColor = System.Drawing.Color.Silver
        Me.ObraSocialcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ObraSocialcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ObraSocialcmb.FocusedColor = System.Drawing.Color.Empty
        Me.ObraSocialcmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ObraSocialcmb.ForeColor = System.Drawing.Color.Black
        Me.ObraSocialcmb.FormattingEnabled = True
        Me.ObraSocialcmb.Location = New System.Drawing.Point(326, 292)
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
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(688, 76)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Size = New System.Drawing.Size(160, 42)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.White
        Me.GunaLabel11.Location = New System.Drawing.Point(327, 97)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(77, 21)
        Me.GunaLabel11.TabIndex = 21
        Me.GunaLabel11.Text = "Provincia:"
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.BaseColor = System.Drawing.Color.White
        Me.ProvinciaTextBox.BorderColor = System.Drawing.Color.Silver
        Me.ProvinciaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProvinciaTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.ProvinciaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProvinciaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(326, 121)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(160, 26)
        Me.ProvinciaTextBox.TabIndex = 20
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.White
        Me.GunaLabel10.Location = New System.Drawing.Point(23, 264)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(73, 21)
        Me.GunaLabel10.TabIndex = 19
        Me.GunaLabel10.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BaseColor = System.Drawing.Color.White
        Me.TelefonoTextBox.BorderColor = System.Drawing.Color.Silver
        Me.TelefonoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TelefonoTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.TelefonoTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TelefonoTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TelefonoTextBox.Location = New System.Drawing.Point(23, 292)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TelefonoTextBox.Size = New System.Drawing.Size(172, 26)
        Me.TelefonoTextBox.TabIndex = 18
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.White
        Me.GunaLabel9.Location = New System.Drawing.Point(23, 150)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(70, 21)
        Me.GunaLabel9.TabIndex = 17
        Me.GunaLabel9.Text = "Apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.BaseColor = System.Drawing.Color.White
        Me.ApellidoTextBox.BorderColor = System.Drawing.Color.Silver
        Me.ApellidoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ApellidoTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.ApellidoTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ApellidoTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ApellidoTextBox.Location = New System.Drawing.Point(23, 178)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ApellidoTextBox.Size = New System.Drawing.Size(254, 26)
        Me.ApellidoTextBox.TabIndex = 16
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(327, 150)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(79, 21)
        Me.GunaLabel7.TabIndex = 13
        Me.GunaLabel7.Text = "Localidad:"
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.BaseColor = System.Drawing.Color.White
        Me.LocalidadTextBox.BorderColor = System.Drawing.Color.Silver
        Me.LocalidadTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LocalidadTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.LocalidadTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocalidadTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.LocalidadTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LocalidadTextBox.Location = New System.Drawing.Point(326, 174)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LocalidadTextBox.Size = New System.Drawing.Size(160, 26)
        Me.LocalidadTextBox.TabIndex = 12
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(327, 40)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(78, 21)
        Me.GunaLabel6.TabIndex = 11
        Me.GunaLabel6.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.BaseColor = System.Drawing.Color.White
        Me.DireccionTextBox.BorderColor = System.Drawing.Color.Silver
        Me.DireccionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DireccionTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.DireccionTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DireccionTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.DireccionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DireccionTextBox.Location = New System.Drawing.Point(326, 68)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DireccionTextBox.Size = New System.Drawing.Size(270, 26)
        Me.DireccionTextBox.TabIndex = 10
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(23, 97)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(71, 21)
        Me.GunaLabel5.TabIndex = 9
        Me.GunaLabel5.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BaseColor = System.Drawing.Color.White
        Me.NombreTextBox.BorderColor = System.Drawing.Color.Silver
        Me.NombreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NombreTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.NombreTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NombreTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.NombreTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(23, 121)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NombreTextBox.Size = New System.Drawing.Size(254, 26)
        Me.NombreTextBox.TabIndex = 8
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(327, 264)
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
        Me.GunaLabel3.Location = New System.Drawing.Point(23, 207)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(62, 21)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Celular:"
        '
        'CelularTextBox
        '
        Me.CelularTextBox.BaseColor = System.Drawing.Color.White
        Me.CelularTextBox.BorderColor = System.Drawing.Color.Silver
        Me.CelularTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CelularTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.CelularTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CelularTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.CelularTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CelularTextBox.Location = New System.Drawing.Point(25, 235)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CelularTextBox.Size = New System.Drawing.Size(172, 26)
        Me.CelularTextBox.TabIndex = 4
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(327, 207)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(137, 21)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Fecha Nacimiento:"
        '
        'NacimientoTextBox
        '
        Me.NacimientoTextBox.BaseColor = System.Drawing.Color.White
        Me.NacimientoTextBox.BorderColor = System.Drawing.Color.Silver
        Me.NacimientoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NacimientoTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.NacimientoTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NacimientoTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.NacimientoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NacimientoTextBox.Location = New System.Drawing.Point(326, 231)
        Me.NacimientoTextBox.Name = "NacimientoTextBox"
        Me.NacimientoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NacimientoTextBox.Size = New System.Drawing.Size(160, 26)
        Me.NacimientoTextBox.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(23, 40)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(94, 21)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Documento:"
        '
        'DniTextBox
        '
        Me.DniTextBox.BaseColor = System.Drawing.Color.White
        Me.DniTextBox.BorderColor = System.Drawing.Color.Silver
        Me.DniTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DniTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.DniTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DniTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.DniTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DniTextBox.Location = New System.Drawing.Point(23, 68)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DniTextBox.Size = New System.Drawing.Size(172, 26)
        Me.DniTextBox.TabIndex = 0
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
        Me.GunaGroupBox2.Location = New System.Drawing.Point(28, 408)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.GunaGroupBox2.Size = New System.Drawing.Size(866, 240)
        Me.GunaGroupBox2.TabIndex = 34
        Me.GunaGroupBox2.Text = "DETALLE CLIENTES"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(433, 5)
        '
        'DgDetalleClientes
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgDetalleClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgDetalleClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgDetalleClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgDetalleClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgDetalleClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgDetalleClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgDetalleClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgDetalleClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgDetalleClientes.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgDetalleClientes.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgDetalleClientes.EnableHeadersVisualStyles = False
        Me.DgDetalleClientes.GridColor = System.Drawing.Color.White
        Me.DgDetalleClientes.Location = New System.Drawing.Point(27, 45)
        Me.DgDetalleClientes.Name = "DgDetalleClientes"
        Me.DgDetalleClientes.RowHeadersVisible = False
        Me.DgDetalleClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgDetalleClientes.Size = New System.Drawing.Size(821, 178)
        Me.DgDetalleClientes.TabIndex = 0
        Me.DgDetalleClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgDetalleClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgDetalleClientes.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgDetalleClientes.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgDetalleClientes.ThemeStyle.HeaderStyle.Height = 4
        Me.DgDetalleClientes.ThemeStyle.ReadOnly = False
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.Height = 22
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgDetalleClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Clientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(919, 670)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Paneltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents ProvinciaTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TelefonoTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ApellidoTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LocalidadTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DireccionTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents NombreTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CelularTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents NacimientoTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DniTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ObraSocialcmb As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents DgDetalleClientes As Guna.UI.WinForms.GunaDataGridView
End Class
