<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarCliente))
        Me.PanelTOP = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.BtnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.BtnCancelar = New Guna.UI.WinForms.GunaButton()
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
        Me.SuspendLayout()
        '
        'PanelTOP
        '
        Me.PanelTOP.Controls.Add(Me.btnCerrarForm)
        Me.PanelTOP.Controls.Add(Me.lblEmpleados)
        Me.PanelTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTOP.Location = New System.Drawing.Point(0, 0)
        Me.PanelTOP.Name = "PanelTOP"
        Me.PanelTOP.Size = New System.Drawing.Size(621, 45)
        Me.PanelTOP.TabIndex = 2
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(593, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 15
        Me.btnCerrarForm.TabStop = False
        '
        'lblEmpleados
        '
        Me.lblEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEmpleados.Location = New System.Drawing.Point(211, 10)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(162, 24)
        Me.lblEmpleados.TabIndex = 3
        Me.lblEmpleados.Text = "EDITAR CLIENTE"
        Me.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AnimationHoverSpeed = 0.07!
        Me.BtnGuardar.AnimationSpeed = 0.03!
        Me.BtnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnGuardar.BorderColor = System.Drawing.Color.Black
        Me.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = Nothing
        Me.BtnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnGuardar.Location = New System.Drawing.Point(160, 420)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnGuardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnGuardar.OnHoverImage = Nothing
        Me.BtnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.BtnGuardar.Size = New System.Drawing.Size(118, 42)
        Me.BtnGuardar.TabIndex = 28
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AnimationHoverSpeed = 0.07!
        Me.BtnCancelar.AnimationSpeed = 0.03!
        Me.BtnCancelar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancelar.BorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnCancelar.FocusedColor = System.Drawing.Color.Empty
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = Nothing
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnCancelar.Location = New System.Drawing.Point(38, 420)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancelar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnCancelar.OnHoverImage = Nothing
        Me.BtnCancelar.OnPressedColor = System.Drawing.Color.Black
        Me.BtnCancelar.Size = New System.Drawing.Size(116, 42)
        Me.BtnCancelar.TabIndex = 27
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtcorreo
        '
        Me.Txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcorreo.Location = New System.Drawing.Point(38, 228)
        Me.Txtcorreo.Multiline = True
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(270, 31)
        Me.Txtcorreo.TabIndex = 26
        '
        'Txtapellido
        '
        Me.Txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtapellido.Location = New System.Drawing.Point(38, 178)
        Me.Txtapellido.Multiline = True
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(270, 27)
        Me.Txtapellido.TabIndex = 25
        '
        'Txtnombre
        '
        Me.Txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombre.Location = New System.Drawing.Point(38, 128)
        Me.Txtnombre.Multiline = True
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(270, 20)
        Me.Txtnombre.TabIndex = 24
        '
        'Txtnomusuario
        '
        Me.Txtnomusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnomusuario.Location = New System.Drawing.Point(38, 78)
        Me.Txtnomusuario.Multiline = True
        Me.Txtnomusuario.Name = "Txtnomusuario"
        Me.Txtnomusuario.Size = New System.Drawing.Size(270, 20)
        Me.Txtnomusuario.TabIndex = 23
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(38, 208)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(56, 13)
        Me.LblCorreo.TabIndex = 22
        Me.LblCorreo.Text = "CORREO:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(38, 158)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(62, 13)
        Me.LblApellido.TabIndex = 21
        Me.LblApellido.Text = "APELLIDO:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(38, 108)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 13)
        Me.LblNombre.TabIndex = 20
        Me.LblNombre.Text = "NOMBRE:"
        '
        'Lblnombreusuario
        '
        Me.Lblnombreusuario.AutoSize = True
        Me.Lblnombreusuario.Location = New System.Drawing.Point(38, 58)
        Me.Lblnombreusuario.Name = "Lblnombreusuario"
        Me.Lblnombreusuario.Size = New System.Drawing.Size(59, 13)
        Me.Lblnombreusuario.TabIndex = 19
        Me.Lblnombreusuario.Text = "USUARIO:"
        Me.Lblnombreusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(621, 512)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Txtcorreo)
        Me.Controls.Add(Me.Txtapellido)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.Txtnomusuario)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.Lblnombreusuario)
        Me.Controls.Add(Me.PanelTOP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarCliente"
        Me.PanelTOP.ResumeLayout(False)
        Me.PanelTOP.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelTOP As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnCancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents Txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtnomusuario As System.Windows.Forms.TextBox
    Friend WithEvents LblCorreo As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Lblnombreusuario As System.Windows.Forms.Label
End Class
