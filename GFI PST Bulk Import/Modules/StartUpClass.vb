Public Class StartUpClass
    Dim frm_main As New frm_main
    Dim frm_auth_2fa As New frm_2FA_logon

    Dim frm_dashboard As New frm_dashboard
    Dim frm_config_menu As New frm_config_menu
    Dim frm_task_menu As New frm_tasks_menu
    Dim frm_config_monitor As New frm_config_monitor
    Dim frm_config_general As New frm_config_general
    Dim frm_config_path As New frm_config_path
    Dim frm_config_tasks As New frm_config_tasks
    Dim frm_config_owner As New frm_config_owner
    Dim frm_config_advanced As New frm_config_advanced
    Dim frm_tasks_ondemand As New frm_tasks_ondemand
    Dim frm_tasks_schedule As New frm_tasks_schedule
    Dim frm_tasks_simulate As New frm_tasks_simulate
    Dim frm_config_auth As New frm_config_auth

    Public Shared Sub Main()
        '  Dim value As String = Trim(Environment.CommandLine)

        Dim value As Boolean = Read_Config("config\config.xml", "48")

        Select Case value
            Case False
                frm_main.ShowDialog()
            Case True
                frm_2FA_logon.ShowDialog()
            Case Else
                MessageBox.Show("Can't read authentication mode, close!!")
                Application.Exit()
                ' Throw New Exception("Unsupported startup form option")
        End Select

    End Sub
End Class
