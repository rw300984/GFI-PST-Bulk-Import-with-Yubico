Imports Microsoft.WindowsAPICodePack.Dialogs
Public Class frm_tasks_schedule_directory
    Private Sub txt_task_directory_ldap_path_TextChanged(sender As Object, e As EventArgs) Handles txt_task_directory_ldap_path.TextChanged
        task.task_directory_ldap_path = txt_task_directory_ldap_path.Text
    End Sub

    Private Sub cbx_task_directory_use_default_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_task_directory_use_default.CheckedChanged
        task.task_directory_use_default = cbx_task_directory_use_default.Checked
        If cbx_task_directory_use_default.Checked = True Then
            txt_task_schedule_directory_path.Enabled = False
            txt_task_schedule_directory_path.BackColor = Color.DarkGray
            btn_tasks_schedule_directory_path.Enabled = False
        Else
            txt_task_schedule_directory_path.Enabled = True
            txt_task_schedule_directory_path.BackColor = Color.LightGray
            btn_tasks_schedule_directory_path.Enabled = True
        End If
    End Sub

    Private Sub txt_task_schedule_directory_path_TextChanged(sender As Object, e As EventArgs) Handles txt_task_schedule_directory_path.TextChanged
        task.task_directory_path = txt_task_schedule_directory_path.Text
    End Sub

    Private Sub txt_task_directory_recursive_TextChanged(sender As Object, e As EventArgs) Handles txt_task_directory_recursive.TextChanged
        task.task_directory_recursive_search = txt_task_directory_recursive.Text
    End Sub

    Private Sub cbx_task_directory_incl_sub_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_task_directory_incl_sub.CheckedChanged
        task.task_directory_include_subdirectories = cbx_task_directory_incl_sub.Checked
    End Sub

    Private Sub btn_tasks_schedule_directory_path_Click(sender As Object, e As EventArgs) Handles btn_tasks_schedule_directory_path.Click
        txt_task_schedule_directory_path.Text = ShowDialog()

    End Sub

    Public Function ShowDialog()
        Try
            Dim fbd_path As New CommonOpenFileDialog
            fbd_path.Title = "GFI Bulk PST Importer - Select a folder"
            fbd_path.InitialDirectory = "c:\"
            fbd_path.IsFolderPicker = True
            fbd_path.ShowDialog()
            Return fbd_path.FileName
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class