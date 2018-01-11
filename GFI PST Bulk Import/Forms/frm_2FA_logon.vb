Public Class frm_2FA_logon
    Dim clientid As String = crypto.AES_Decrypt(Read_Config("config\config.xml", "49"), "FcuNb;3M7/&[:HE2")
    Dim secretkey As String = crypto.AES_Decrypt(Read_Config("config\config.xml", "50"), "FcuNb;3M7/&[:HE2")
    Private Async Sub btn_2fa_login_Click(sender As Object, e As EventArgs) Handles btn_2fa_login.Click
        Await VerifyYubiKey(txt_2fa_otp.Text, clientid, secretkey)
    End Sub

    Public Async Function VerifyYubiKey(ByVal otp As String, ByVal clientid As String, ByVal secretkey As String) As Threading.Tasks.Task
        Try
            If otp.Count < 44 Then
                lbl_2fa_status.Text = "OTP to short, close in 5 sec."
                Panel1.BackColor = Color.LightCoral
                Panel1.Update()
                lbl_2fa_status.Update()
                Threading.Thread.Sleep(5000)
                Application.Exit()
            Else
                Dim Client As YubicoClient = New YubicoClient(clientid, secretkey)
                Dim response As IYubicoResponse = Await Client.VerifyAsync(otp)
                If response.Status = YubicoResponseStatus.Ok Then
                    lbl_2fa_status.Text = "Successfully authenticated... start GFI PST Exporter"
                    Panel1.BackColor = Color.LightGreen
                    Panel1.Update()
                    lbl_2fa_status.Update()
                    Threading.Thread.Sleep(2500)
                    Me.Hide()
                    frm_main.ShowDialog()
                    Me.Close()
                Else
                    lbl_2fa_status.Text = "Authentication failed... close in 5 sec."
                    Panel1.BackColor = Color.LightCoral
                    Panel1.Update()
                    lbl_2fa_status.Update()
                    Threading.Thread.Sleep(2500)
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            lbl_2fa_status.Text = "An error occured... close in 5 sec."
            Panel1.BackColor = Color.LightCoral
            Panel1.Update()
            lbl_2fa_status.Update()
            Threading.Thread.Sleep(2500)
            Application.Exit()
        End Try
    End Function
End Class