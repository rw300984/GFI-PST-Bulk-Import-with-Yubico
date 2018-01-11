Public Class frm_config_owner
    Private Sub cbx_owner_directory_mode_search_mode_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbx_owner_directory_mode_search_mode.SelectedValueChanged
        cfg_config.owner_directory_mode_search_mode = cbx_owner_directory_mode_search_mode.SelectedIndex
    End Sub

    Private Sub frm_config_owner_Load(sender As Object, e As EventArgs) Handles Me.Load
        rbtn_config_owner_path_mode.Checked = True
    End Sub

    Private Sub rbtn_config_owner_directory_mode_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_config_owner_directory_mode.CheckedChanged
        If rbtn_config_owner_directory_mode.Checked = True Then
            cfg_config.owner_owner_mode = 0
            rbtn_config_owner_path_mode.Checked = False
            rbtn_config_owner_directory_mode.Checked = True
            grp_config_owner_directory_mode.Enabled = True
            grp_config_owner_path_mode.Enabled = False
            grp_config_owner_directory_mode.Visible = True
            grp_config_owner_path_mode.Visible = False
        Else
            cfg_config.owner_owner_mode = 1
            rbtn_config_owner_path_mode.Checked = True
            rbtn_config_owner_directory_mode.Checked = False
            grp_config_owner_directory_mode.Enabled = False
            grp_config_owner_path_mode.Enabled = True
            grp_config_owner_directory_mode.Visible = False
            grp_config_owner_path_mode.Visible = False
        End If

    End Sub

    Private Sub rbtn_config_owner_path_mode_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_config_owner_path_mode.CheckedChanged
        If rbtn_config_owner_path_mode.Checked = True Then
            cfg_config.owner_owner_mode = 1
            rbtn_config_owner_path_mode.Checked = True
            rbtn_config_owner_directory_mode.Checked = False
            grp_config_owner_directory_mode.Enabled = False
            grp_config_owner_path_mode.Enabled = True
            grp_config_owner_directory_mode.Visible = False
            grp_config_owner_path_mode.Visible = False
        Else
            cfg_config.owner_owner_mode = 0
            rbtn_config_owner_path_mode.Checked = False
            rbtn_config_owner_directory_mode.Checked = True
            grp_config_owner_directory_mode.Enabled = True
            grp_config_owner_path_mode.Enabled = False
            grp_config_owner_directory_mode.Visible = True
            grp_config_owner_path_mode.Visible = False
        End If
    End Sub

    Private Sub txt_owner_directory_mode_password_TextChanged(sender As Object, e As EventArgs) Handles txt_owner_directory_mode_password.TextChanged
        cfg_config.owner_directory_mode_password = txt_owner_directory_mode_password.Text

    End Sub

    Private Sub txt_owner_directory_mode_port_TextChanged(sender As Object, e As EventArgs) Handles txt_owner_directory_mode_port.TextChanged
        cfg_config.owner_directory_mode_port = txt_owner_directory_mode_port.Text
    End Sub

    Private Sub txt_owner_directory_mode_search_field_TextChanged(sender As Object, e As EventArgs) Handles txt_owner_directory_mode_search_field.TextChanged
        cfg_config.owner_directory_mode_search_field = txt_owner_directory_mode_search_field.Text
    End Sub

    Private Sub txt_owner_directory_mode_server_TextChanged(sender As Object, e As EventArgs) Handles txt_owner_directory_mode_server.TextChanged
        cfg_config.owner_directory_mode_server = txt_owner_directory_mode_server.Text
    End Sub

    Private Sub txt_owner_directory_mode_user_TextChanged(sender As Object, e As EventArgs) Handles txt_owner_directory_mode_user.TextChanged
        cfg_config.owner_directory_mode_user = txt_owner_directory_mode_user.Text
    End Sub

    Private Sub txt_owner_path_mode_user_variable_TextChanged(sender As Object, e As EventArgs) Handles txt_owner_path_mode_user_variable.TextChanged
        cfg_config.owner_path_mode_user_variable = txt_owner_path_mode_user_variable.Text
    End Sub
End Class