Public Class frm_tasks_menu

    Private Sub btn_tasks_ondemand_Click(sender As Object, e As EventArgs) Handles btn_tasks_ondemand.Click
        My.Forms.frm_main.show_forms("frm_tasks_ondemand")
    End Sub

    Private Sub btn_tasks_schedule_Click(sender As Object, e As EventArgs) Handles btn_tasks_schedule.Click
        My.Forms.frm_main.show_forms("frm_tasks_schedule")
    End Sub

    Private Sub btn_tasks_simulate_Click(sender As Object, e As EventArgs) Handles btn_tasks_simulate.Click
        My.Forms.frm_main.show_forms("frm_tasks_simulate")
    End Sub

    Private Sub frm_tasks_menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Forms.frm_main.show_forms("frm_tasks_ondemand")
    End Sub

End Class