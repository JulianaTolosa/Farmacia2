Imports System.Net
Imports System.Net.Mail

Public Class Mailing
    Private Shared smtpClient As New SmtpClient
    Private Shared senderMail As String = "soportefcialeod@gmail.com"
    Private Shared password As String = "@FciaLD1234"
    Private Shared host As String = "smtp.gmail.com"
    Private Shared port As Integer = 587
    Private Shared ssl As Boolean = True


    Public Shared Function EnviarCorreo(Asunto As String, Cuerpo As String, Destinatarios As List(Of String)) As Boolean
        Dim _Retorno As Boolean = False
        Dim mailMessage As New MailMessage()
        Try
            smtpClient.Credentials = New NetworkCredential(senderMail, password)
            smtpClient.Host = host
            smtpClient.Port = port
            smtpClient.EnableSsl = ssl
            mailMessage.From = New MailAddress(senderMail)
            For Each recipientMail As String In Destinatarios
                mailMessage.To.Add(recipientMail)
            Next
            mailMessage.Subject = Asunto
            mailMessage.Body = Cuerpo
            mailMessage.Priority = MailPriority.Normal

            smtpClient.Send(mailMessage)
            _Retorno = True

        Catch ex As Exception

        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()

        End Try

        Return _Retorno
    End Function

End Class