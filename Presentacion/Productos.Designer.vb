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
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbLProductos = New System.Windows.Forms.Label()
        Me.Lblpreciocom = New System.Windows.Forms.Label()
        Me.Lblprecioven = New System.Windows.Forms.Label()
        Me.Lbldescripcion = New System.Windows.Forms.Label()
        Me.Lblnombreproducto = New System.Windows.Forms.Label()
        Me.nombreprod = New System.Windows.Forms.TextBox()
        Me.precioventa = New System.Windows.Forms.TextBox()
        Me.preciocompra = New System.Windows.Forms.TextBox()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.Dgproductos = New System.Windows.Forms.DataGridView()
        Me.Lblcantidad = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Lbltipoprod = New System.Windows.Forms.Label()
        Me.Cmbtipoproducto = New System.Windows.Forms.ComboBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgproductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Lblpreciocom
        '
        Me.Lblpreciocom.AutoSize = True
        Me.Lblpreciocom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpreciocom.Location = New System.Drawing.Point(42, 135)
        Me.Lblpreciocom.Name = "Lblpreciocom"
        Me.Lblpreciocom.Size = New System.Drawing.Size(117, 20)
        Me.Lblpreciocom.TabIndex = 39
        Me.Lblpreciocom.Text = "Precio Compra:"
        '
        'Lblprecioven
        '
        Me.Lblprecioven.AutoSize = True
        Me.Lblprecioven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprecioven.Location = New System.Drawing.Point(42, 97)
        Me.Lblprecioven.Name = "Lblprecioven"
        Me.Lblprecioven.Size = New System.Drawing.Size(104, 20)
        Me.Lblprecioven.TabIndex = 38
        Me.Lblprecioven.Text = "Precio Venta:"
        '
        'Lbldescripcion
        '
        Me.Lbldescripcion.AutoSize = True
        Me.Lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldescripcion.Location = New System.Drawing.Point(42, 267)
        Me.Lbldescripcion.Name = "Lbldescripcion"
        Me.Lbldescripcion.Size = New System.Drawing.Size(96, 20)
        Me.Lbldescripcion.TabIndex = 36
        Me.Lbldescripcion.Text = "Descripción:"
        '
        'Lblnombreproducto
        '
        Me.Lblnombreproducto.AutoSize = True
        Me.Lblnombreproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombreproducto.Location = New System.Drawing.Point(42, 62)
        Me.Lblnombreproducto.Name = "Lblnombreproducto"
        Me.Lblnombreproducto.Size = New System.Drawing.Size(69, 20)
        Me.Lblnombreproducto.TabIndex = 35
        Me.Lblnombreproducto.Text = "Nombre:"
        '
        'nombreprod
        '
        Me.nombreprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nombreprod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nombreprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreprod.Location = New System.Drawing.Point(162, 62)
        Me.nombreprod.Name = "nombreprod"
        Me.nombreprod.Size = New System.Drawing.Size(480, 19)
        Me.nombreprod.TabIndex = 0
        '
        'precioventa
        '
        Me.precioventa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.precioventa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.precioventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precioventa.Location = New System.Drawing.Point(162, 98)
        Me.precioventa.Name = "precioventa"
        Me.precioventa.Size = New System.Drawing.Size(115, 19)
        Me.precioventa.TabIndex = 1
        '
        'preciocompra
        '
        Me.preciocompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.preciocompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.preciocompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preciocompra.Location = New System.Drawing.Point(162, 135)
        Me.preciocompra.Name = "preciocompra"
        Me.preciocompra.Size = New System.Drawing.Size(115, 19)
        Me.preciocompra.TabIndex = 2
        '
        'Btnborrar
        '
        Me.Btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnborrar.Location = New System.Drawing.Point(800, 162)
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
        Me.BtnEditar.Location = New System.Drawing.Point(800, 112)
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
        Me.Btnagregar.Location = New System.Drawing.Point(800, 62)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(90, 40)
        Me.Btnagregar.TabIndex = 6
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.UseVisualStyleBackColor = True
        '
        'Dgproductos
        '
        Me.Dgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgproductos.Location = New System.Drawing.Point(46, 360)
        Me.Dgproductos.Name = "Dgproductos"
        Me.Dgproductos.Size = New System.Drawing.Size(700, 167)
        Me.Dgproductos.TabIndex = 41
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AccessibleName = ""
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcantidad.Location = New System.Drawing.Point(42, 173)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(57, 20)
        Me.Lblcantidad.TabIndex = 43
        Me.Lblcantidad.Text = "Marca:"
        '
        'txtcantidad
        '
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcantidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(162, 173)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(480, 19)
        Me.txtcantidad.TabIndex = 3
        '
        'Lbltipoprod
        '
        Me.Lbltipoprod.AutoSize = True
        Me.Lbltipoprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipoprod.Location = New System.Drawing.Point(42, 215)
        Me.Lbltipoprod.Name = "Lbltipoprod"
        Me.Lbltipoprod.Size = New System.Drawing.Size(43, 20)
        Me.Lbltipoprod.TabIndex = 45
        Me.Lbltipoprod.Text = "Tipo:"
        '
        'Cmbtipoproducto
        '
        Me.Cmbtipoproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtipoproducto.FormattingEnabled = True
        Me.Cmbtipoproducto.Items.AddRange(New Object() {"Comprimidos", "Inyectables"})
        Me.Cmbtipoproducto.Location = New System.Drawing.Point(162, 213)
        Me.Cmbtipoproducto.Name = "Cmbtipoproducto"
        Me.Cmbtipoproducto.Size = New System.Drawing.Size(198, 28)
        Me.Cmbtipoproducto.TabIndex = 4
        '
        'txtdescripcion
        '
        Me.txtdescripcion.AccessibleDescription = ""
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescripcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(162, 268)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(480, 71)
        Me.txtdescripcion.TabIndex = 5
        Me.txtdescripcion.Tag = ""
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(922, 572)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Cmbtipoproducto)
        Me.Controls.Add(Me.Lbltipoprod)
        Me.Controls.Add(Me.Lblcantidad)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Dgproductos)
        Me.Controls.Add(Me.Lblpreciocom)
        Me.Controls.Add(Me.Lblprecioven)
        Me.Controls.Add(Me.Lbldescripcion)
        Me.Controls.Add(Me.Lblnombreproducto)
        Me.Controls.Add(Me.nombreprod)
        Me.Controls.Add(Me.precioventa)
        Me.Controls.Add(Me.preciocompra)
        Me.Controls.Add(Me.Btnborrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbLProductos As System.Windows.Forms.Label
    Friend WithEvents Lblpreciocom As System.Windows.Forms.Label
    Friend WithEvents Lblprecioven As System.Windows.Forms.Label
    Friend WithEvents Lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents Lblnombreproducto As System.Windows.Forms.Label
    Friend WithEvents nombreprod As System.Windows.Forms.TextBox
    Friend WithEvents precioventa As System.Windows.Forms.TextBox
    Friend WithEvents preciocompra As System.Windows.Forms.TextBox
    Friend WithEvents Btnborrar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Btnagregar As System.Windows.Forms.Button
    Friend WithEvents Dgproductos As System.Windows.Forms.DataGridView
    Friend WithEvents Lblcantidad As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Lbltipoprod As System.Windows.Forms.Label
    Friend WithEvents Cmbtipoproducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
End Class
