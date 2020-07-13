<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaStock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblconsultastock = New System.Windows.Forms.Label()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.Txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgProducto = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBnombre = New System.Windows.Forms.RadioButton()
        Me.RBid = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Controls.Add(Me.lblconsultastock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 45)
        Me.Panel1.TabIndex = 1
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(708, 12)
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
        Me.lblconsultastock.Location = New System.Drawing.Point(318, 12)
        Me.lblconsultastock.Name = "lblconsultastock"
        Me.lblconsultastock.Size = New System.Drawing.Size(129, 24)
        Me.lblconsultastock.TabIndex = 2
        Me.lblconsultastock.Text = "CONSULTAS "
        Me.lblconsultastock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbuscar.Location = New System.Drawing.Point(628, 109)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(96, 23)
        Me.Btnbuscar.TabIndex = 12
        Me.Btnbuscar.Text = "BUSCAR"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Txtbuscar
        '
        Me.Txtbuscar.Location = New System.Drawing.Point(106, 43)
        Me.Txtbuscar.Name = "Txtbuscar"
        Me.Txtbuscar.Size = New System.Drawing.Size(427, 20)
        Me.Txtbuscar.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BUSCAR:"
        '
        'DgProducto
        '
        Me.DgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProducto.Location = New System.Drawing.Point(36, 225)
        Me.DgProducto.Name = "DgProducto"
        Me.DgProducto.Size = New System.Drawing.Size(667, 232)
        Me.DgProducto.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RBnombre)
        Me.GroupBox1.Controls.Add(Me.RBid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txtbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 130)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "it"
        '
        'RBnombre
        '
        Me.RBnombre.AutoSize = True
        Me.RBnombre.Location = New System.Drawing.Point(223, 91)
        Me.RBnombre.Name = "RBnombre"
        Me.RBnombre.Size = New System.Drawing.Size(101, 17)
        Me.RBnombre.TabIndex = 13
        Me.RBnombre.TabStop = True
        Me.RBnombre.Text = "POR NOMBRE:"
        Me.RBnombre.UseVisualStyleBackColor = True
        '
        'RBid
        '
        Me.RBid.AutoSize = True
        Me.RBid.Location = New System.Drawing.Point(106, 91)
        Me.RBid.Name = "RBid"
        Me.RBid.Size = New System.Drawing.Size(65, 17)
        Me.RBid.TabIndex = 12
        Me.RBid.TabStop = True
        Me.RBid.Text = "POR ID:"
        Me.RBid.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(365, 91)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ConsultaStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 491)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgProducto)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaStock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents lblconsultastock As System.Windows.Forms.Label
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgProducto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBnombre As System.Windows.Forms.RadioButton
    Friend WithEvents RBid As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
