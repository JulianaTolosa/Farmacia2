﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblconsultastock = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Totaltxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Subtotaltxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Descuentotxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cmbtipodni = New System.Windows.Forms.ComboBox()
        Me.CmbObraSocial = New System.Windows.Forms.ComboBox()
        Me.datelabel = New System.Windows.Forms.Timer(Me.components)
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgProductos = New System.Windows.Forms.DataGridView()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btnfactura = New System.Windows.Forms.RadioButton()
        Me.Btnboleta = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btnconfirmar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgDetalles = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Controls.Add(Me.lblconsultastock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 45)
        Me.Panel1.TabIndex = 2
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(1016, 12)
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
        Me.lblconsultastock.Location = New System.Drawing.Point(461, 12)
        Me.lblconsultastock.Name = "lblconsultastock"
        Me.lblconsultastock.Size = New System.Drawing.Size(145, 24)
        Me.lblconsultastock.TabIndex = 2
        Me.lblconsultastock.Text = "FACTURACION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblconsultastock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre/Razon"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(278, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Obra Social"
        '
        'Totaltxt
        '
        Me.Totaltxt.Enabled = False
        Me.Totaltxt.Location = New System.Drawing.Point(667, 639)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Cmbtipodni)
        Me.GroupBox1.Controls.Add(Me.CmbObraSocial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 207)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Clientes"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(24, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 36)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cmbtipodni
        '
        Me.Cmbtipodni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtipodni.FormattingEnabled = True
        Me.Cmbtipodni.Location = New System.Drawing.Point(157, 27)
        Me.Cmbtipodni.Name = "Cmbtipodni"
        Me.Cmbtipodni.Size = New System.Drawing.Size(165, 24)
        Me.Cmbtipodni.TabIndex = 29
        '
        'CmbObraSocial
        '
        Me.CmbObraSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbObraSocial.FormattingEnabled = True
        Me.CmbObraSocial.Location = New System.Drawing.Point(158, 110)
        Me.CmbObraSocial.Name = "CmbObraSocial"
        Me.CmbObraSocial.Size = New System.Drawing.Size(472, 24)
        Me.CmbObraSocial.TabIndex = 24
        '
        'datelabel
        '
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Location = New System.Drawing.Point(81, 68)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(79, 36)
        Me.BtnAgregar.TabIndex = 18
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgProductos)
        Me.GroupBox2.Controls.Add(Me.txtBuscador)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(48, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(968, 120)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle del Producto"
        '
        'dgProductos
        '
        Me.dgProductos.AllowUserToAddRows = False
        Me.dgProductos.AllowUserToResizeColumns = False
        Me.dgProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgProductos.ColumnHeadersHeight = 30
        Me.dgProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgProductos.EnableHeadersVisualStyles = False
        Me.dgProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgProductos.Location = New System.Drawing.Point(213, 19)
        Me.dgProductos.MultiSelect = False
        Me.dgProductos.Name = "dgProductos"
        Me.dgProductos.ReadOnly = True
        Me.dgProductos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgProductos.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgProductos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProductos.Size = New System.Drawing.Size(724, 95)
        Me.dgProductos.TabIndex = 30
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(24, 33)
        Me.txtBuscador.Multiline = True
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(183, 20)
        Me.txtBuscador.TabIndex = 29
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btnfactura)
        Me.GroupBox3.Controls.Add(Me.Btnboleta)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblfecha)
        Me.GroupBox3.Controls.Add(Me.lblhora)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(778, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 207)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'Btnfactura
        '
        Me.Btnfactura.AutoSize = True
        Me.Btnfactura.Location = New System.Drawing.Point(66, 174)
        Me.Btnfactura.Name = "Btnfactura"
        Me.Btnfactura.Size = New System.Drawing.Size(61, 17)
        Me.Btnfactura.TabIndex = 18
        Me.Btnfactura.TabStop = True
        Me.Btnfactura.Text = "Factura"
        Me.Btnfactura.UseVisualStyleBackColor = True
        '
        'Btnboleta
        '
        Me.Btnboleta.AutoSize = True
        Me.Btnboleta.Location = New System.Drawing.Point(66, 142)
        Me.Btnboleta.Name = "Btnboleta"
        Me.Btnboleta.Size = New System.Drawing.Size(55, 17)
        Me.Btnboleta.TabIndex = 17
        Me.Btnboleta.TabStop = True
        Me.Btnboleta.Text = "Boleta"
        Me.Btnboleta.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(51, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Tipo de Documento"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(84, 46)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(44, 13)
        Me.lblfecha.TabIndex = 15
        Me.lblfecha.Text = "lblfecha"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(86, 95)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(38, 13)
        Me.lblhora.TabIndex = 14
        Me.lblhora.Text = "lblhora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Hora"
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
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Location = New System.Drawing.Point(832, 635)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(79, 36)
        Me.BtnEliminar.TabIndex = 33
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgDetalles)
        Me.GroupBox4.Location = New System.Drawing.Point(48, 390)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(968, 239)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Detalle"
        '
        'dgDetalles
        '
        Me.dgDetalles.AllowUserToAddRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgDetalles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDetalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgDetalles.ColumnHeadersHeight = 30
        Me.dgDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDetalles.EnableHeadersVisualStyles = False
        Me.dgDetalles.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgDetalles.Location = New System.Drawing.Point(24, 35)
        Me.dgDetalles.MultiSelect = False
        Me.dgDetalles.Name = "dgDetalles"
        Me.dgDetalles.ReadOnly = True
        Me.dgDetalles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgDetalles.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetalles.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgDetalles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgDetalles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetalles.Size = New System.Drawing.Size(913, 198)
        Me.dgDetalles.TabIndex = 31
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1044, 687)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Btnconfirmar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Text = "FACTURACION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblconsultastock As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Totaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Subtotaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Descuentotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents datelabel As System.Windows.Forms.Timer
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmbtipodni As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btnfactura As System.Windows.Forms.RadioButton
    Friend WithEvents Btnboleta As System.Windows.Forms.RadioButton
    Friend WithEvents Btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents dgProductos As System.Windows.Forms.DataGridView
    Friend WithEvents dgDetalles As System.Windows.Forms.DataGridView
End Class
