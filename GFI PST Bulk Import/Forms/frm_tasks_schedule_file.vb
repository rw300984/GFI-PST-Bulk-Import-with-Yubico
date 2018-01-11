Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class frm_tasks_schedule_file


    Private Sub cbx_task_file_use_default_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_task_file_use_default.CheckedChanged
        task.task_file_use_default = cbx_task_file_use_default.Checked
        If cbx_task_file_use_default.Checked = True Then
            txt_task_file_path.Enabled = False
            txt_task_file_path.BackColor = Color.DarkGray
            btn_tasks_schedule_file_path.Enabled = False
            txt_task_file_path.Text = cfg_config.path_pstsource_default
        Else
            txt_task_file_path.Enabled = True
            txt_task_file_path.BackColor = Color.LightGray
            btn_tasks_schedule_file_path.Enabled = True
        End If
    End Sub
    Private Sub txt_task_file_path_TextChanged(sender As Object, e As EventArgs) Handles txt_task_file_path.TextChanged
        task.task_file_path = txt_task_file_path.Text
    End Sub
    Private Sub cbx_task_incl_sub_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_task_incl_sub.CheckedChanged
        task.task_file_include_subdirectories = cbx_task_incl_sub.Checked
    End Sub
    Private Sub btn_tasks_schedule_file_path_Click(sender As Object, e As EventArgs) Handles btn_tasks_schedule_file_path.Click
        txt_task_file_path.Text = ShowDialog()

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