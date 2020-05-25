<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editarempleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editarempleado))
        Me.PanelTOP = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.Panelder = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Txtapellido = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtnomusuario = New System.Windows.Forms.TextBox()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Lblnombreusuario = New System.Windows.Forms.Label()
        Me.PanelTOP.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelder.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTOP
        '
        Me.PanelTOP.Controls.Add(Me.btnCerrarForm)
        Me.PanelTOP.Controls.Add(Me.lblEmpleados)
        Me.PanelTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTOP.Location = New System.Drawing.Point(0, 0)
        Me.PanelTOP.Name = "PanelTOP"
        Me.PanelTOP.Size = New System.Drawing.Size(623, 45)
        Me.PanelTOP.TabIndex = 1
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(595, 12)
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
        Me.lblEmpleados.Location = New System.Drawing.Point(212, 10)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(188, 24)
        Me.lblEmpleados.TabIndex = 3
        Me.lblEmpleados.Text = "EDITAR EMPLEADO"
        Me.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panelder
        '
        Me.Panelder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panelder.Controls.Add(Me.BtnGuardar)
        Me.Panelder.Controls.Add(Me.BtnCancelar)
        Me.Panelder.Controls.Add(Me.Txtcorreo)
        Me.Panelder.Controls.Add(Me.Txtapellido)
        Me.Panelder.Controls.Add(Me.Txtnombre)
        Me.Panelder.Controls.Add(Me.Txtnomusuario)
        Me.Panelder.Controls.Add(Me.LblCorreo)
        Me.Panelder.Controls.Add(Me.LblApellido)
        Me.Panelder.Controls.Add(Me.LblNombre)
        Me.Panelder.Controls.Add(Me.Lblnombreusuario)
        Me.Panelder.Location = New System.Drawing.Point(0, 37)
        Me.Panelder.Name = "Panelder"
        Me.Panelder.Size = New System.Drawing.Size(623, 443)
        Me.Panelder.TabIndex = 3
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Lime
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(170, 380)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(130, 40)
        Me.BtnGuardar.TabIndex = 16
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(30, 380)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(130, 40)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Txtcorreo
        '
        Me.Txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcorreo.Location = New System.Drawing.Point(30, 190)
        Me.Txtcorreo.Multiline = True
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(270, 20)
        Me.Txtcorreo.TabIndex = 10
        '
        'Txtapellido
        '
        Me.Txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtapellido.Location = New System.Drawing.Point(30, 140)
        Me.Txtapellido.Multiline = True
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(270, 20)
        Me.Txtapellido.TabIndex = 9
        '
        'Txtnombre
        '
        Me.Txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombre.Location = New System.Drawing.Point(30, 90)
        Me.Txtnombre.Multiline = True
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(270, 20)
        Me.Txtnombre.TabIndex = 8
        '
        'Txtnomusuario
        '
        Me.Txtnomusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnomusuario.Location = New System.Drawing.Point(30, 40)
        Me.Txtnomusuario.Multiline = True
        Me.Txtnomusuario.Name = "Txtnomusuario"
        Me.Txtnomusuario.Size = New System.Drawing.Size(270, 20)
        Me.Txtnomusuario.TabIndex = 7
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(30, 170)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(56, 13)
        Me.LblCorreo.TabIndex = 3
        Me.LblCorreo.Text = "CORREO:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(30, 120)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(62, 13)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "APELLIDO:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(30, 70)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "NOMBRE:"
        '
        'Lblnombreusuario
        '
        Me.Lblnombreusuario.AutoSize = True
        Me.Lblnombreusuario.Location = New System.Drawing.Point(30, 20)
        Me.Lblnombreusuario.Name = "Lblnombreusuario"
        Me.Lblnombreusuario.Size = New System.Drawing.Size(59, 13)
        Me.Lblnombreusuario.TabIndex = 0
        Me.Lblnombreusuario.Text = "USUARIO:"
        Me.Lblnombreusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Editarempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 481)
        Me.Controls.Add(Me.Panelder)
        Me.Controls.Add(Me.PanelTOP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Editarempleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editarempleado"
        Me.PanelTOP.ResumeLayout(False)
        Me.PanelTOP.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelder.ResumeLayout(False)
        Me.Panelder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTOP As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents Panelder As System.Windows.Forms.Panel
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Lblnombreusuario As System.Windows.Forms.Label
    Friend WithEvents LblCorreo As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents Txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents Txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtnomusuario As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
