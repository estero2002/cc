Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Utilities
    Public Const BACKSPACE = 8
    Public Shared Sub ShowErrorMessage(ByVal s As String)
        MessageBox.Show(s, "Cyber", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Shared Sub ShowExclamationMessage(ByVal s As String)
        MessageBox.Show(s, "Cyber", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Public Shared Sub ShowInformationMessage(ByVal s As String)
        MessageBox.Show(s, "Cyber", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Shared Function YesNoDialog(ByVal s As String) As DialogResult
        Return MessageBox.Show(s, "Cyber", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Public Shared Function Empty(ByVal s As String) As Boolean
        Empty = (s.Length = 0)
    End Function

    Public Shared Function IsPositiveNumber(ByVal nro As String) As Boolean
        Dim result As Integer
        IsPositiveNumber = (Int32.TryParse(nro, result) And (result > 0))
    End Function

    Public Shared Function SearchRecord(ByVal dt As DataTable, ByVal campo As String, ByVal valor As Long) As Long
        Dim i As Long = 0
        Dim found As Boolean = False
        While (i < dt.Rows.Count And Not found)
            If dt(i).RowState <> DataRowState.Deleted Then
                If (dt(i)(campo) = valor) Then
                    found = True
                End If
            End If
            If Not found Then
                i = i + 1
            End If
        End While
        SearchRecord = i
    End Function

    Public Shared Function ExistsRecord(ByVal dt As DataTable, ByVal campo As String, ByVal valor As String) As Boolean
        Dim i As Long = 0
        Dim found As Boolean = False
        While (i < dt.Rows.Count And Not found)
            If dt(i).RowState <> DataRowState.Deleted Then
                found = (dt(i)(campo) = valor)
            End If
            i = i + 1
        End While
        ExistsRecord = found
    End Function

    Public Shared Function SendEmail(ByVal ToAddress As String, ByVal UserName As String, ByVal Password As String, _
                                     Optional ByVal Server As String = "smtp.gmail.com", Optional ByVal Port As Integer = 587) As String
        Dim Email As New MailMessage()
        Dim FromAddress As String = "cybernoreply@gmail.com"
        Dim SmtpUser As String = "cybernoreply"
        Dim SmtpPassword As String = "cyber2013$"
        Try
            Dim SMTPServer As New SmtpClient

            Email.From = New MailAddress(FromAddress)
            Email.To.Add(New MailAddress(ToAddress))
            Email.Subject = "Su cuenta para CyberCafe ha sido creada"
            Email.Body = "Puede ingresar a CyberCafe con su usuario " & UserName & " y la siguiente contraseña: " & Password

            SMTPServer.Host = Server
            SMTPServer.Port = Port
            SMTPServer.Credentials = New System.Net.NetworkCredential(SmtpUser, SmtpPassword)
            SMTPServer.EnableSsl = True
            SMTPServer.Send(Email)

            Email.Dispose()
            Return "Se enviaron los datos de cuenta a " & ToAddress
        Catch ex As SmtpException
            Email.Dispose()
            Return "Error Smtp durante el envio"
        Catch ex As ArgumentOutOfRangeException
            Email.Dispose()
            Return "Error durante el envio. Revise el numero de puerto"
        Catch Ex As InvalidOperationException
            Email.Dispose()
            Return "Error durante el envio. Revise el numero de puerto"
        End Try
    End Function

    Public Shared Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")
        Return emailExpression.IsMatch(email)
    End Function
End Class
