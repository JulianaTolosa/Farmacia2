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
        Dim lblPosicion As System.Windows.Forms.Label
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbLProductos = New System.Windows.Forms.Label()
        Me.Lblpreciocom = New System.Windows.Forms.Label()
        Me.Lblprecioven = New System.Windows.Forms.Label()
        Me.Lbldescripcion = New System.Windows.Forms.Label()
        Me.Lblnombreproducto = New System.Windows.Forms.Label()
        Me.Txtnombreprod = New System.Windows.Forms.TextBox()
        Me.Txtprecioven = New System.Windows.Forms.TextBox()
        Me.cmbtipoprod = New System.Windows.Forms.ComboBox()
        Me.Txtpreciocomp = New System.Windows.Forms.TextBox()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        lblPosicion = New System.Windows.Forms.Label()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Lbldescripcion.Location = New System.Drawing.Point(42, 222)
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
        'Txtnombreprod
        '
        Me.Txtnombreprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombreprod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtnombreprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombreprod.Location = New System.Drawing.Point(162, 62)
        Me.Txtnombreprod.Name = "Txtnombreprod"
        Me.Txtnombreprod.Size = New System.Drawing.Size(150, 19)
        Me.Txtnombreprod.TabIndex = 24
        '
        'Txtprecioven
        '
        Me.Txtprecioven.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtprecioven.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtprecioven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprecioven.Location = New System.Drawing.Point(162, 98)
        Me.Txtprecioven.Name = "Txtprecioven"
        Me.Txtprecioven.Size = New System.Drawing.Size(250, 19)
        Me.Txtprecioven.TabIndex = 27
        '
        'lblPosicion
        '
        lblPosicion.AutoSize = True
        lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPosicion.Location = New System.Drawing.Point(42, 184)
        lblPosicion.Name = "lblPosicion"
        lblPosicion.Size = New System.Drawing.Size(43, 20)
        lblPosicion.TabIndex = 34
        lblPosicion.Text = "Tipo:"
        '
        'cmbtipoprod
        '
        Me.cmbtipoprod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbtipoprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbtipoprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipoprod.FormattingEnabled = True
        Me.cmbtipoprod.Items.AddRange(New Object() {"Comprimidos", "inyectables"})
        Me.cmbtipoprod.Location = New System.Drawing.Point(162, 176)
        Me.cmbtipoprod.Name = "cmbtipoprod"
        Me.cmbtipoprod.Size = New System.Drawing.Size(150, 28)
        Me.cmbtipoprod.TabIndex = 29
        '
        'Txtpreciocomp
        '
        Me.Txtpreciocomp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtpreciocomp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtpreciocomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpreciocomp.Location = New System.Drawing.Point(162, 135)
        Me.Txtpreciocomp.Name = "Txtpreciocomp"
        Me.Txtpreciocomp.Size = New System.Drawing.Size(250, 19)
        Me.Txtpreciocomp.TabIndex = 28
        '
        'Btnborrar
        '
        Me.Btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnborrar.Location = New System.Drawing.Point(562, 164)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(90, 40)
        Me.Btnborrar.TabIndex = 32
        Me.Btnborrar.Text = "BORRAR"
        Me.Btnborrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(562, 114)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 40)
        Me.BtnEditar.TabIndex = 31
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Btnagregar
        '
        Me.Btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnagregar.Location = New System.Drawing.Point(562, 64)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(90, 40)
        Me.Btnagregar.TabIndex = 30
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.UseVisualStyleBackColor = True
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdescripcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdescripcion.Location = New System.Drawing.Point(162, 222)
        Me.Txtdescripcion.Multiline = True
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(328, 111)
        Me.Txtdescripcion.TabIndex = 40
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(922, 572)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Lblpreciocom)
        Me.Controls.Add(Me.Lblprecioven)
        Me.Controls.Add(Me.Lbldescripcion)
        Me.Controls.Add(Me.Lblnombreproducto)
        Me.Controls.Add(Me.Txtnombreprod)
        Me.Controls.Add(Me.Txtprecioven)
        Me.Controls.Add(lblPosicion)
        Me.Controls.Add(Me.cmbtipoprod)
        Me.Controls.Add(Me.Txtpreciocomp)
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
    Friend WithEvents Txtnombreprod As System.Windows.Forms.TextBox
    Friend WithEvents Txtprecioven As System.Windows.Forms.TextBox
    Friend WithEvents cmbtipoprod As System.Windows.Forms.ComboBox
    Friend WithEvents Txtpreciocomp As System.Windows.Forms.TextBox
    Friend WithEvents Btnborrar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Btnagregar As System.Windows.Forms.Button
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
End Class
