Public Class frm_main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_forms()
        load_config(cfg_config.path_bulkimport_config & "\config.xml")
        show_forms("frm_dashboard")
    End Sub

    Private Sub btn_configuration_Click(sender As Object, e As EventArgs) Handles btn_configuration.Click
        show_forms("frm_config_menu")
        show_forms("frm_config_monitor")
    End Sub

    Private Sub btn_tasks_Click(sender As Object, e As EventArgs) Handles btn_tasks.Click
        show_forms("frm_tasks_menu")
        show_forms("frm_tasks_ondemand")
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        show_forms("frm_dashboard")
    End Sub
    Public Function show_forms(ByVal frm_name As String)
        Select Case frm_name
            Case "frm_config_monitor"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_auth.Visible = False
                frm_config_monitor.Visible = True
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False
            Case "frm_config_general"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = True
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_auth.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False


            Case "frm_config_path"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_path.Visible = True
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_auth.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False


            Case "frm_config_owner"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = True
                frm_config_tasks.Visible = False
                frm_config_auth.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_config_owner.TopLevel = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False


            Case "frm_config_advanced"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_auth.Visible = False
                frm_config_advanced.Visible = True
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False
                frm_config_advanced.TopLevel = False

            Case "frm_config_tasks"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_auth.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = True
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False


            Case "frm_dashboard"
                SplitContainer2.Panel1Collapsed = True
                frm_dashboard.Visible = True
                frm_config_menu.Visible = False
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_path.Visible = False
                frm_config_auth.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False


            Case "frm_config_menu"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_auth.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False


            Case "frm_tasks_menu"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = False
                frm_tasks_menu.Visible = True
                frm_config_general.Visible = False
                frm_config_auth.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False

            Case "frm_tasks_schedule"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = False
                frm_tasks_menu.Visible = True
                frm_config_general.Visible = False
                frm_config_auth.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = True
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False

            Case "frm_tasks_ondemand"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = False
                frm_tasks_menu.Visible = True
                frm_config_general.Visible = False
                frm_config_auth.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = True
                frm_tasks_simulate.Visible = False

            Case "frm_tasks_simulate"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = False
                frm_tasks_menu.Visible = True
                frm_config_general.Visible = False
                frm_config_auth.Visible = False
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = True
            Case "frm_config_auth"
                SplitContainer2.Panel1Collapsed = False
                frm_dashboard.Visible = False
                frm_config_menu.Visible = True
                frm_tasks_menu.Visible = False
                frm_config_general.Visible = False
                frm_config_auth.Visible = True
                frm_config_path.Visible = False
                frm_config_owner.Visible = False
                frm_config_tasks.Visible = False
                frm_config_advanced.Visible = False
                frm_config_monitor.Visible = False
                frm_tasks_schedule.Visible = False
                frm_tasks_ondemand.Visible = False
                frm_tasks_simulate.Visible = False
        End Select
    End Function
    Public Function load_forms()
        frm_dashboard.Visible = False
        frm_config_menu.Visible = False
        frm_tasks_menu.Visible = False
        frm_config_general.Visible = False
        frm_config_path.Visible = False
        frm_config_owner.Visible = False
        frm_config_tasks.Visible = False
        frm_config_auth.Visible = False
        frm_config_advanced.Visible = False
        frm_config_monitor.Visible = False
        frm_tasks_schedule.Visible = False
        frm_tasks_ondemand.Visible = False
        frm_tasks_simulate.Visible = False

        frm_tasks_menu.TopLevel = False
        frm_tasks_menu.WindowState = FormWindowState.Maximized
        frm_tasks_menu.FormBorderStyle = FormBorderStyle.None
        frm_config_menu.TopLevel = False
        frm_config_menu.WindowState = FormWindowState.Maximized
        frm_config_menu.FormBorderStyle = FormBorderStyle.None
        frm_dashboard.TopLevel = False
        frm_dashboard.WindowState = FormWindowState.Maximized
        frm_dashboard.FormBorderStyle = FormBorderStyle.None
        frm_config_tasks.TopLevel = False
        frm_config_tasks.WindowState = FormWindowState.Maximized
        frm_config_tasks.FormBorderStyle = FormBorderStyle.None
        frm_config_auth.TopLevel = False
        frm_config_auth.WindowState = FormWindowState.Maximized
        frm_config_auth.FormBorderStyle = FormBorderStyle.None
        frm_config_advanced.TopLevel = False
        frm_config_advanced.WindowState = FormWindowState.Maximized
        frm_config_advanced.FormBorderStyle = FormBorderStyle.None
        frm_config_owner.TopLevel = False
        frm_config_owner.WindowState = FormWindowState.Maximized
        frm_config_owner.FormBorderStyle = FormBorderStyle.None
        frm_config_path.TopLevel = False
        frm_config_path.WindowState = FormWindowState.Maximized
        frm_config_path.FormBorderStyle = FormBorderStyle.None
        frm_config_general.TopLevel = False
        frm_config_general.WindowState = FormWindowState.Maximized
        frm_config_general.FormBorderStyle = FormBorderStyle.None
        frm_config_monitor.TopLevel = False
        frm_config_monitor.WindowState = FormWindowState.Maximized
        frm_config_monitor.FormBorderStyle = FormBorderStyle.None
        frm_tasks_ondemand.TopLevel = False
        frm_tasks_ondemand.WindowState = FormWindowState.Maximized
        frm_tasks_ondemand.FormBorderStyle = FormBorderStyle.None
        frm_tasks_schedule.TopLevel = False
        frm_tasks_schedule.WindowState = FormWindowState.Maximized
        frm_tasks_schedule.FormBorderStyle = FormBorderStyle.None
        frm_tasks_simulate.TopLevel = False
        frm_tasks_simulate.WindowState = FormWindowState.Maximized
        frm_tasks_simulate.FormBorderStyle = FormBorderStyle.None
        SplitContainer2.Panel1Collapsed = True

        SplitContainer2.Panel1.Controls.Add(frm_tasks_menu)
        SplitContainer2.Panel1.Controls.Add(frm_config_menu)
        SplitContainer2.Panel2.Controls.Add(frm_dashboard)
        SplitContainer2.Panel2.Controls.Add(frm_config_tasks)
        SplitContainer2.Panel2.Controls.Add(frm_config_owner)
        SplitContainer2.Panel2.Controls.Add(frm_config_advanced)
        SplitContainer2.Panel2.Controls.Add(frm_config_general)
        SplitContainer2.Panel2.Controls.Add(frm_config_path)
        SplitContainer2.Panel2.Controls.Add(frm_config_monitor)
        SplitContainer2.Panel2.Controls.Add(frm_config_auth)

        SplitContainer2.Panel2.Controls.Add(frm_tasks_ondemand)
        SplitContainer2.Panel2.Controls.Add(frm_tasks_schedule)
        SplitContainer2.Panel2.Controls.Add(frm_tasks_simulate)


    End Function
    Public Function load_config(ByVal config As String)
        GetConfig("config\config.xml")
        frm_config_monitor.cbx_monitor_cpu.Text = cfg_config.monitor_cpu
        frm_config_monitor.cbx_monitor_memory.Text = cfg_config.monitor_cpu
        frm_config_monitor.cbx_monitor_disk.Text = cfg_config.monitor_cpu
        frm_config_monitor.cbx_monitor_network.Text = cfg_config.monitor_cpu
        frm_config_monitor.cbx_monitor_pickup.Text = cfg_config.monitor_pickup
        frm_config_monitor.cbx_monitor_queue.Text = cfg_config.monitor_queue
        frm_config_monitor.cbx_monitor_unclassified.Text = cfg_config.monitor_unclassified
        frm_config_monitor.cbx_monitor_service1.Text = cfg_config.monitor_service1
        frm_config_monitor.cbx_monitor_service2.Text = cfg_config.monitor_service2
        frm_config_monitor.cbx_monitor_service3.Text = cfg_config.monitor_service3
        frm_config_monitor.cbx_monitor_service4.Text = cfg_config.monitor_service4
        frm_config_monitor.cbx_monitor_service5.Text = cfg_config.monitor_service5
        frm_config_monitor.cbx_monitor_service6.Text = cfg_config.monitor_service6
        frm_config_owner.txt_owner_directory_mode_password.Text = cfg_config.owner_directory_mode_password
        frm_config_owner.txt_owner_directory_mode_user.Text = cfg_config.owner_directory_mode_user
        frm_config_owner.txt_owner_directory_mode_server.Text = cfg_config.owner_directory_mode_server
        frm_config_owner.txt_owner_directory_mode_port.Text = cfg_config.owner_directory_mode_port
        frm_config_owner.txt_owner_directory_mode_search_field.Text = cfg_config.owner_directory_mode_search_field
        frm_config_owner.txt_owner_path_mode_user_variable.Text = cfg_config.owner_path_mode_user_variable
        frm_config_owner.cbx_owner_directory_mode_search_mode.SelectedIndex = cfg_config.owner_directory_mode_search_mode
        If cfg_config.owner_owner_mode = 1 Then
            frm_config_owner.rbtn_config_owner_directory_mode.Checked = False
            frm_config_owner.rbtn_config_owner_path_mode.Checked = True
        Else
            frm_config_owner.rbtn_config_owner_directory_mode.Checked = True
            frm_config_owner.rbtn_config_owner_path_mode.Checked = False
        End If
        frm_config_general.txt_general_email_from.Text = cfg_config.general_email_from
        frm_config_general.txt_general_email_to.Text = cfg_config.general_email_to
        frm_config_general.txt_general_email_password.Text = crypto.AES_Decrypt(cfg_config.general_email_password, "FcuNb;3M7/&[:HE2")

        frm_config_general.txt_general_email_user.Text = cfg_config.general_email_user
        frm_config_general.txt_general_email_server.Text = cfg_config.general_email_server
        frm_config_general.cbx_general_language.Text = cfg_config.general_language
        frm_config_general.cbx_email_authentication.Checked = cfg_config.general_email_authentication

        frm_config_path.txt_path_archiver_install.Text = cfg_config.path_archiver_install
        frm_config_path.txt_path_archiver_pickup.Text = cfg_config.path_archiver_pickup
        frm_config_path.txt_path_archiver_queue.Text = cfg_config.path_archiver_queue
        frm_config_path.txt_path_archiver_unclassified.Text = cfg_config.path_archiver_unclassified
        frm_config_path.txt_path_bulkimport_config.Text = cfg_config.path_bulkimport_config
        frm_config_path.txt_path_bulkimport_logs.Text = cfg_config.path_bulkimport_logs
        frm_config_path.txt_path_bulkimport_install.Text = cfg_config.path_bulkimport_install
        frm_config_path.txt_path_bulkimport_temp.Text = cfg_config.path_bulkimport_temp
        frm_config_path.txt_path_pstsource_default.Text = cfg_config.path_pstsource_default

        frm_config_tasks.cbx_tasks_http_mode_protocol.SelectedIndex = cfg_config.tasks_http_mode_protocol
        If cfg_config.tasks_import_mode = 0 Then
            frm_config_tasks.rbtn_config_tasks_file_mode.Checked = True
            frm_config_tasks.rbtn_config_tasks_http_mode.Checked = False
        Else
            frm_config_tasks.rbtn_config_tasks_file_mode.Checked = False
            frm_config_tasks.rbtn_config_tasks_http_mode.Checked = True
        End If

        frm_config_tasks.txt_tasks_http_mode_user.Text = cfg_config.tasks_http_mode_user
        frm_config_tasks.txt_tasks_http_mode_password.Text = cfg_config.tasks_http_mode_password
        frm_config_tasks.txt_tasks_http_mode_url.Text = cfg_config.tasks_http_mode_url

        frm_config_monitor.cbx_monitor_alert_cpu.CheckState = cfg_config.monitor_alert_cpu
        frm_config_monitor.cbx_monitor_alert_directory.CheckState = cfg_config.monitor_alert_directory
        frm_config_monitor.cbx_monitor_alert_service.CheckState = cfg_config.monitor_alert_service
        frm_config_monitor.cbx_monitor_alert_task.CheckState = cfg_config.monitor_alert_task
        frm_config_monitor.cbx_monitor_alert_mode.Text = cfg_config.monitor_alert_mode

        frm_config_general.ComboBox1.Text = cfg_config.general_office_bit

        My.MyProject.Forms.frm_config_auth.cbx_config_auth_2fa.Checked = cfg_config.auth_2fa
        My.MyProject.Forms.frm_config_auth.txt_config_auth_clientid.Text = crypto.AES_Decrypt(cfg_config.auth_2fa_client, "FcuNb;3M7/&[:HE2")
        My.MyProject.Forms.frm_config_auth.txt_config_auth_secretkey.Text = crypto.AES_Decrypt(cfg_config.auth_2fa_secret, "FcuNb;3M7/&[:HE2")



    End Function
End Class
