<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtFacturacion = New Guna.UI.WinForms.GunaLabel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.GBxlistado = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox4 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox5 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBxlistado.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GunaGroupBox3.SuspendLayout()
        Me.GunaGroupBox4.SuspendLayout()
        Me.GunaGroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtFacturacion)
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 45)
        Me.Panel1.TabIndex = 3
        '
        'TxtFacturacion
        '
        Me.TxtFacturacion.AutoSize = True
        Me.TxtFacturacion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFacturacion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFacturacion.Location = New System.Drawing.Point(427, 12)
        Me.TxtFacturacion.Name = "TxtFacturacion"
        Me.TxtFacturacion.Size = New System.Drawing.Size(95, 25)
        Me.TxtFacturacion.TabIndex = 15
        Me.TxtFacturacion.Text = "LISTADOS"
        Me.TxtFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(826, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 14
        Me.btnCerrarForm.TabStop = False
        '
        'GBxlistado
        '
        Me.GBxlistado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBxlistado.BackColor = System.Drawing.Color.Transparent
        Me.GBxlistado.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GBxlistado.BorderColor = System.Drawing.Color.Gainsboro
        Me.GBxlistado.Controls.Add(Me.GunaGroupBox5)
        Me.GBxlistado.Controls.Add(Me.GunaGroupBox4)
        Me.GBxlistado.Controls.Add(Me.GunaGroupBox3)
        Me.GBxlistado.Controls.Add(Me.GunaGroupBox2)
        Me.GBxlistado.Controls.Add(Me.GunaGroupBox1)
        Me.GBxlistado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBxlistado.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GBxlistado.LineBottom = 1
        Me.GBxlistado.LineColor = System.Drawing.Color.Blue
        Me.GBxlistado.LineLeft = 1
        Me.GBxlistado.LineRight = 1
        Me.GBxlistado.Location = New System.Drawing.Point(33, 64)
        Me.GBxlistado.Name = "GBxlistado"
        Me.GBxlistado.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GBxlistado.Size = New System.Drawing.Size(794, 447)
        Me.GBxlistado.TabIndex = 38
        Me.GBxlistado.TextLocation = New System.Drawing.Point(320, 5)
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaButton1)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(29, 48)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GunaGroupBox1.Size = New System.Drawing.Size(211, 159)
        Me.GunaGroupBox1.TabIndex = 40
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(320, 5)
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
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(41, 84)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton1.TabIndex = 39
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.GunaButton2)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox2.LineBottom = 1
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox2.LineLeft = 1
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(288, 48)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GunaGroupBox2.Size = New System.Drawing.Size(211, 159)
        Me.GunaGroupBox2.TabIndex = 41
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(320, 5)
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(41, 84)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton2.TabIndex = 39
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox3.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox3.Controls.Add(Me.GunaButton3)
        Me.GunaGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox3.LineBottom = 1
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox3.LineLeft = 1
        Me.GunaGroupBox3.LineRight = 1
        Me.GunaGroupBox3.Location = New System.Drawing.Point(539, 48)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GunaGroupBox3.Size = New System.Drawing.Size(211, 159)
        Me.GunaGroupBox3.TabIndex = 41
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(320, 5)
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(41, 84)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton3.TabIndex = 39
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox4
        '
        Me.GunaGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox4.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox4.Controls.Add(Me.GunaButton4)
        Me.GunaGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox4.LineBottom = 1
        Me.GunaGroupBox4.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox4.LineLeft = 1
        Me.GunaGroupBox4.LineRight = 1
        Me.GunaGroupBox4.Location = New System.Drawing.Point(129, 244)
        Me.GunaGroupBox4.Name = "GunaGroupBox4"
        Me.GunaGroupBox4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GunaGroupBox4.Size = New System.Drawing.Size(211, 159)
        Me.GunaGroupBox4.TabIndex = 41
        Me.GunaGroupBox4.TextLocation = New System.Drawing.Point(320, 5)
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(41, 84)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton4.TabIndex = 39
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox5
        '
        Me.GunaGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox5.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGroupBox5.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox5.Controls.Add(Me.GunaButton5)
        Me.GunaGroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaGroupBox5.LineBottom = 1
        Me.GunaGroupBox5.LineColor = System.Drawing.Color.Blue
        Me.GunaGroupBox5.LineLeft = 1
        Me.GunaGroupBox5.LineRight = 1
        Me.GunaGroupBox5.Location = New System.Drawing.Point(399, 244)
        Me.GunaGroupBox5.Name = "GunaGroupBox5"
        Me.GunaGroupBox5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GunaGroupBox5.Size = New System.Drawing.Size(211, 159)
        Me.GunaGroupBox5.TabIndex = 41
        Me.GunaGroupBox5.TextLocation = New System.Drawing.Point(320, 5)
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton5.ForeColor = System.Drawing.Color.White
        Me.GunaButton5.Image = Nothing
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(41, 84)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton5.TabIndex = 39
        Me.GunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(854, 551)
        Me.Controls.Add(Me.GBxlistado)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Listados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBxlistado.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox4.ResumeLayout(False)
        Me.GunaGroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtFacturacion As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents GBxlistado As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox5 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGroupBox4 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
End Class
