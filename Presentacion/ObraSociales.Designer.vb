<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraSocial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObraSocial))
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbLObraSocial = New System.Windows.Forms.Label()
        Me.Lbltelefono = New System.Windows.Forms.Label()
        Me.Lbldireccion = New System.Windows.Forms.Label()
        Me.Lblnombreproducto = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Btnagregar = New System.Windows.Forms.Button()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(885, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 7
        Me.btnCerrarForm.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbLObraSocial)
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 45)
        Me.Panel1.TabIndex = 8
        '
        'lbLObraSocial
        '
        Me.lbLObraSocial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbLObraSocial.AutoSize = True
        Me.lbLObraSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLObraSocial.Location = New System.Drawing.Point(392, 10)
        Me.lbLObraSocial.Name = "lbLObraSocial"
        Me.lbLObraSocial.Size = New System.Drawing.Size(135, 24)
        Me.lbLObraSocial.TabIndex = 8
        Me.lbLObraSocial.Text = "OBRA SOCIAL"
        Me.lbLObraSocial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbltelefono
        '
        Me.Lbltelefono.AutoSize = True
        Me.Lbltelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltelefono.Location = New System.Drawing.Point(12, 138)
        Me.Lbltelefono.Name = "Lbltelefono"
        Me.Lbltelefono.Size = New System.Drawing.Size(75, 20)
        Me.Lbltelefono.TabIndex = 58
        Me.Lbltelefono.Text = "Telefono:"
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldireccion.Location = New System.Drawing.Point(12, 100)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(79, 20)
        Me.Lbldireccion.TabIndex = 57
        Me.Lbldireccion.Text = "Direccion:"
        '
        'Lblnombreproducto
        '
        Me.Lblnombreproducto.AutoSize = True
        Me.Lblnombreproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombreproducto.Location = New System.Drawing.Point(12, 65)
        Me.Lblnombreproducto.Name = "Lblnombreproducto"
        Me.Lblnombreproducto.Size = New System.Drawing.Size(69, 20)
        Me.Lblnombreproducto.TabIndex = 55
        Me.Lblnombreproducto.Text = "Nombre:"
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(132, 65)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(480, 19)
        Me.txtnombre.TabIndex = 46
        '
        'txtdireccion
        '
        Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdireccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(132, 101)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(480, 19)
        Me.txtdireccion.TabIndex = 47
        '
        'txttelefono
        '
        Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(132, 138)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(227, 19)
        Me.txttelefono.TabIndex = 48
        '
        'Btnborrar
        '
        Me.Btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnborrar.Location = New System.Drawing.Point(784, 157)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(90, 40)
        Me.Btnborrar.TabIndex = 54
        Me.Btnborrar.Text = "BORRAR"
        Me.Btnborrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(784, 111)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 40)
        Me.BtnEditar.TabIndex = 53
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Btnagregar
        '
        Me.Btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnagregar.Location = New System.Drawing.Point(784, 65)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(90, 40)
        Me.Btnagregar.TabIndex = 52
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.UseVisualStyleBackColor = True
        '
        'ObraSocial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(913, 572)
        Me.Controls.Add(Me.Lbltelefono)
        Me.Controls.Add(Me.Lbldireccion)
        Me.Controls.Add(Me.Lblnombreproducto)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Btnborrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ObraSocial"
        Me.Text = "Obra Social"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbLObraSocial As System.Windows.Forms.Label
    Friend WithEvents Lbltelefono As System.Windows.Forms.Label
    Friend WithEvents Lbldireccion As System.Windows.Forms.Label
    Friend WithEvents Lblnombreproducto As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Btnborrar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Btnagregar As System.Windows.Forms.Button
End Class
