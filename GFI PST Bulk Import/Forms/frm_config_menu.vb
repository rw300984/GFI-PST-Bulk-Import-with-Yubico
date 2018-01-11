Public Class frm_config_menu
    Private Sub frm_config_menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Forms.frm_main.show_forms("frm_config_monitor")
    End Sub

    Private Sub btn_config_monitor_Click(sender As Object, e As EventArgs) Handles btn_config_monitor.Click
        My.Forms.frm_main.show_forms("frm_config_monitor")
    End Sub

    Private Sub btn_config_general_Click(sender As Object, e As EventArgs) Handles btn_config_general.Click
        My.Forms.frm_main.show_forms("frm_config_general")
    End Sub

    Private Sub btn_config_path_Click(sender As Object, e As EventArgs) Handles btn_config_path.Click
        My.Forms.frm_main.show_forms("frm_config_path")
    End Sub

    Private Sub btn_config_owner_Click(sender As Object, e As EventArgs) Handles btn_config_owner.Click
        My.Forms.frm_main.show_forms("frm_config_owner")
    End Sub

    Private Sub btn_config_tasks_Click(sender As Object, e As EventArgs) Handles btn_config_tasks.Click
        My.Forms.frm_main.show_forms("frm_config_tasks")
    End Sub

    Private Sub btn_config_advanced_Click(sender As Object, e As EventArgs) Handles btn_config_advanced.Click
        My.Forms.frm_main.show_forms("frm_config_advanced")
    End Sub

    Private Sub btn_frm_main_save_settings_Click(sender As Object, e As EventArgs) Handles btn_frm_main_save_settings.Click
        Dim write_config_status As Integer = Write_Config(cfg_config, cfg_config.path_bulkimport_config & "\config.xml")
        If write_config_status = 1 Then
            btn_frm_main_save_settings.Text = "Settings saved"
            btn_frm_main_save_settings.BackColor = Color.Green
            btn_timer.Start()
        Else
            btn_frm_main_save_settings.Text = "Settings not saved"
            btn_frm_main_save_settings.BackColor = Color.Red
            btn_timer.Start()
        End If
    End Sub

    Private Sub lbl_timer_Tick(sender As Object, e As EventArgs) Handles btn_timer.Tick
        btn_frm_main_save_settings.BackColor = SystemColors.Highlight
        btn_frm_main_save_settings.Text = "Save settings"
    End Sub

    Private Sub btn_config_auth_Click(sender As Object, e As EventArgs) Handles btn_config_auth.Click
        My.Forms.frm_main.show_forms("frm_config_auth")
    End Sub
End Class