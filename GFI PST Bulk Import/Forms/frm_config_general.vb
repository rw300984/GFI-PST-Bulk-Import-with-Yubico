
Imports System.ComponentModel

Public Class frm_config_general

    Private Sub cbx_email_authentication_CheckStateChanged(sender As Object, e As EventArgs) Handles cbx_email_authentication.CheckStateChanged
        cfg_config.general_email_authentication = cbx_email_authentication.Checked
        If cbx_email_authentication.Checked = True Then
            txt_general_email_password.Enabled = True
            txt_general_email_user.Enabled = True
        Else
            txt_general_email_password.Enabled = False
            txt_general_email_user.Enabled = False
        End If
    End Sub

    Private Sub cbx_general_language_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbx_general_language.SelectedValueChanged
        cfg_config.general_language = cbx_general_language.Text
    End Sub

    Private Sub txt_general_email_from_TextChanged(sender As Object, e As EventArgs) Handles txt_general_email_from.TextChanged
        cfg_config.general_email_from = txt_general_email_from.Text
    End Sub

    Private Sub txt_general_email_password_TextChanged(sender As Object, e As EventArgs) Handles txt_general_email_password.TextChanged
        cfg_config.general_email_password = crypto.AES_Encrypt(txt_general_email_password.Text, "FcuNb;3M7/&[:HE2")
    End Sub

    Private Sub txt_general_email_server_TextChanged(sender As Object, e As EventArgs) Handles txt_general_email_server.TextChanged
        cfg_config.general_email_server = txt_general_email_server.Text
    End Sub

    Private Sub txt_general_email_to_TextChanged(sender As Object, e As EventArgs) Handles txt_general_email_to.TextChanged
        cfg_config.general_email_to = txt_general_email_to.Text
    End Sub

    Private Sub txt_general_email_user_TextChanged(sender As Object, e As EventArgs) Handles txt_general_email_user.TextChanged
        cfg_config.general_email_user = txt_general_email_user.Text
    End Sub

    Private Sub btn_config_general_test_email_Click(sender As Object, e As EventArgs) Handles btn_config_general_test_email.Click
        Dim smtp_status As String = alerts.SendEmail("This is a Test message from GFI PST Bulk Importer", "Test message successfully send to the configured settings")
        If smtp_status.StartsWith("Successfully sent") Then
            btn_config_general_test_email.Text = smtp_status
            btn_config_general_test_email.BackColor = Color.Green
            btn_timer.Start()
        Else
            btn_config_general_test_email.Text = smtp_status
            btn_config_general_test_email.BackColor = Color.Coral
            btn_timer.Start()
        End If
    End Sub

    Private Sub lbl_timer_Tick(sender As Object, e As EventArgs) Handles btn_timer.Tick
        btn_config_general_test_email.BackColor = SystemColors.Highlight
        btn_config_general_test_email.Text = "Test E-mail settings"
    End Sub

    Private Sub frm_config_general_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cbx_email_authentication.Checked = False Then
            txt_general_email_password.Enabled = False
            txt_general_email_user.Enabled = False
        Else
            txt_general_email_password.Enabled = True
            txt_general_email_user.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        cfg_config.general_office_bit = ComboBox1.Text
    End Sub
End Class