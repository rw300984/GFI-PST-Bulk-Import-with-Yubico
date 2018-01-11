Public Class frm_config_tasks
    Private Sub cbx_tasks_http_mode_protocol_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbx_tasks_http_mode_protocol.SelectedValueChanged
        cfg_config.tasks_http_mode_protocol = cbx_tasks_http_mode_protocol.SelectedIndex
    End Sub

    Private Sub rbtn_config_tasks_file_mode_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_config_tasks_file_mode.CheckedChanged
        If rbtn_config_tasks_file_mode.Checked = True Then
            cfg_config.tasks_import_mode = 0
            rbtn_config_tasks_file_mode.Checked = True
            rbtn_config_tasks_http_mode.Checked = False
            grp_config_tasks_http_mode.Enabled = False
            grp_config_tasks_http_mode.Visible = False
        Else
            cfg_config.tasks_import_mode = 1
            rbtn_config_tasks_file_mode.Checked = False
            rbtn_config_tasks_http_mode.Checked = True
            grp_config_tasks_http_mode.Enabled = True
            grp_config_tasks_http_mode.Visible = True
        End If

    End Sub

    Private Sub rbtn_config_tasks_http_mode_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_config_tasks_http_mode.CheckedChanged
        If rbtn_config_tasks_http_mode.Checked = True Then
            cfg_config.tasks_import_mode = 1
            rbtn_config_tasks_file_mode.Checked = False
            rbtn_config_tasks_http_mode.Checked = True
            grp_config_tasks_http_mode.Enabled = True
            grp_config_tasks_http_mode.Visible = True
        Else
            cfg_config.tasks_import_mode = 0
            rbtn_config_tasks_file_mode.Checked = True
            rbtn_config_tasks_http_mode.Checked = False
            grp_config_tasks_http_mode.Enabled = False
            grp_config_tasks_http_mode.Visible = False
        End If
    End Sub

    Private Sub txt_tasks_http_mode_password_TextChanged(sender As Object, e As EventArgs) Handles txt_tasks_http_mode_password.TextChanged
        cfg_config.tasks_http_mode_password = txt_tasks_http_mode_password.Text
    End Sub

    Private Sub txt_tasks_http_mode_url_TextChanged(sender As Object, e As EventArgs) Handles txt_tasks_http_mode_url.TextChanged
        cfg_config.tasks_http_mode_url = txt_tasks_http_mode_url.Text
    End Sub

    Private Sub txt_tasks_http_mode_user_TextChanged(sender As Object, e As EventArgs) Handles txt_tasks_http_mode_user.TextChanged
        cfg_config.tasks_http_mode_user = txt_tasks_http_mode_user.Text
    End Sub
End Class