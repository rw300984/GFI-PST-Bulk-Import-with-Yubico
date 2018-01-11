Public Class frm_config_auth
    Private Sub cbx_config_auth_2fa_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_config_auth_2fa.CheckedChanged
        cfg_config.auth_2fa = cbx_config_auth_2fa.Checked
        If cbx_config_auth_2fa.Checked = False Then
            grpbox_config_auth_2fa_settings.Visible = False
            grpbox_config_auth_test2fa.Visible = False
        Else
            grpbox_config_auth_2fa_settings.Visible = True
            grpbox_config_auth_test2fa.Visible = True
        End If
    End Sub

    Private Async Sub btn_config_auth_test_Click(sender As Object, e As EventArgs) Handles btn_config_auth_test.Click
        If txt_config_auth_otp.Text.Count < 44 Then
            MessageBox.Show("not an otp, please verify that your yubikey is configured correctly")
        Else
            Await VerifyYubiKey(txt_config_auth_otp.Text, txt_config_auth_clientid.Text, txt_config_auth_secretkey.Text)
        End If
    End Sub

    Public Async Function VerifyYubiKey(ByVal otp As String, ByVal clientid As String, ByVal secret As String) As Threading.Tasks.Task
        Try
            txt_config_auth_2fa_output.Clear()
            Dim Client As YubicoClient = New YubicoClient(clientid, secret)
            Dim response As IYubicoResponse = Await Client.VerifyAsync(otp)
            txt_config_auth_2fa_output.AppendText("#### Yubico Verification Output ####" & vbCrLf & vbCrLf)
            txt_config_auth_2fa_output.AppendText("OTP: " & response.Otp & vbCrLf)
            txt_config_auth_2fa_output.AppendText("Public ID: " & response.PublicId & vbCrLf)
            txt_config_auth_2fa_output.AppendText("URL: " & response.Url & vbCrLf)
            txt_config_auth_2fa_output.AppendText("Sync: " & response.Sync & vbCrLf)
            txt_config_auth_2fa_output.AppendText("Status: " & response.Status & vbCrLf)
            txt_config_auth_2fa_output.AppendText("Session Counter: " & response.SessionCounter & vbCrLf)
            txt_config_auth_2fa_output.AppendText("Timestamp: " & response.Timestamp & vbCrLf)
            txt_config_auth_2fa_output.AppendText("UseCounter: " & response.UseCounter & vbCrLf)
            txt_config_auth_2fa_output.AppendText("H: " & response.H & vbCrLf)
            txt_config_auth_2fa_output.AppendText("T: " & response.T & vbCrLf)
        Catch ex As Exception
            txt_config_auth_2fa_output.AppendText("An error occured: " & ex.Message)
        End Try
    End Function

    Private Sub txt_config_auth_clientid_TextChanged(sender As Object, e As EventArgs) Handles txt_config_auth_clientid.TextChanged
        cfg_config.auth_2fa_client = crypto.AES_Encrypt(txt_config_auth_clientid.Text, "FcuNb;3M7/&[:HE2")

    End Sub

    Private Sub txt_config_auth_secretkey_TextChanged(sender As Object, e As EventArgs) Handles txt_config_auth_secretkey.TextChanged
        cfg_config.auth_2fa_secret = crypto.AES_Encrypt(txt_config_auth_secretkey.Text, "FcuNb;3M7/&[:HE2")
    End Sub

    Private Sub frm_config_auth_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cbx_config_auth_2fa.Checked = False Then
            grpbox_config_auth_2fa_settings.Visible = False
            grpbox_config_auth_test2fa.Visible = False
        Else
            grpbox_config_auth_2fa_settings.Visible = True
            grpbox_config_auth_test2fa.Visible = True
        End If
    End Sub
End Class