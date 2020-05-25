Imports System.Runtime.InteropServices
Imports Dominio

Public Class RecuperarContraseña

    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            Dim _Usuario As Usuario = Datos.ObtenerUsuario(TextBox1.Text)
            If _Usuario Is Nothing Then
                MsgBox("El Usuario no Existe")
                Exit Sub
            End If

            Dim _Asunto As String = "SYSTEM: Solicitud de recuperacion de contraseña"
            Dim _Cuerpo As String = "Hola, " & _Usuario._NombreUsuario & " solicita recuperar su contraseña." & vbNewLine & _
                "Su contraseña actual es: " & _Usuario._Contraseña & vbNewLine & _
                "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema."
            Dim _Destintarios As New List(Of String)
            _Destintarios.Add(_Usuario._Correo)
            If Mailing.EnviarCorreo(_Asunto, _Cuerpo, _Destintarios) Then
                lblresult.Text = "Hemos enviado un Correo(a " & _Usuario._Correo & ") con su contraseña actual." & vbNewLine &
                                     "Le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema."
            Else
                lblresult.Text = "Error al enviar el correo."
            End If
        Catch ex As Exception

        End Try




        'Dim user As New user
        'Dim result = user.recoryPassword(TextBox1.Text)

        'lblresult.Text = result
    End Sub


    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub PanelBarraTitulo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

   
End Class