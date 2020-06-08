
Imports System.Runtime.InteropServices
Imports Dominio

Public Class Login
#Region "Form Comportamientos"
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub


#End Region

    Private Sub TituloBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TituloBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            IntentarLogin()
        End If
    End Sub

   

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
      
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#Region "Control Personalizado"
    Private Sub Componentepersonalizado()
        'txtUsuario
        txtUsuario.AutoSize = False
        txtUsuario.Size = New Size(350, 27)
        'txtContraseña
        txtcontraseña.AutoSize = False
        txtcontraseña.Size = New Size(350, 27)
        txtcontraseña.UseSystemPasswordChar = True
    End Sub

    Private Sub btnIngresar_Paint(sender As Object, e As PaintEventArgs) Handles btnIngresar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myrectangle As Rectangle = btnIngresar.ClientRectangle
        myrectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myrectangle)
        btnIngresar.Region = New Region(buttonPath)
    End Sub

#End Region
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Componentepersonalizado()
    End Sub

    
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        IntentarLogin()
    End Sub
    Private Sub IntentarLogin()

        Try
            Dim _Nombre As String = txtUsuario.Text
            Dim _Pass As String = txtcontraseña.Text
            If _Nombre.Length < 3 Or _Pass.Length < 3 Then
                MsgBox("Usuario y Contraseña deben tener al menos 3 caracteres")
                Exit Sub
            End If

            Dim _Usuario As Usuario = Datos.Login(_Nombre, _Pass)
            If _Usuario Is Nothing Then
                MsgBox("Usuario o Contraseña Incorrecta. Intente nuevamente")
                txtcontraseña.Text = ""
                Exit Sub
            End If

            Utilidades._UsuarioLogueado = _Usuario
            If Checkremember.Checked Then
                Utilidades.SetearIdDeMySettings(_Usuario._Id)
            End If
            Me.Hide()
            FormWelcome.Show()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUsuario.Clear()
        txtcontraseña.Clear()
        Me.Show()
        txtUsuario.Focus()
    End Sub

    Private Sub Lblolvidocontraseña_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Lblolvidocontraseña.LinkClicked
        Dim formrecoverpass As New RecuperarContraseña
        formrecoverpass.ShowDialog()

    End Sub

    Private Sub Login_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Validating

    End Sub
End Class