Imports Microsoft.WindowsAPICodePack.Dialogs


Public Class frm_config_path
    Private Sub txt_path_archiver_install_TextChanged(sender As Object, e As EventArgs) Handles txt_path_archiver_install.TextChanged
        cfg_config.path_archiver_install = txt_path_archiver_install.Text

    End Sub

    Private Sub txt_path_archiver_pickup_TextChanged(sender As Object, e As EventArgs) Handles txt_path_archiver_pickup.TextChanged
        cfg_config.path_archiver_pickup = txt_path_archiver_pickup.Text
    End Sub

    Private Sub txt_path_archiver_queue_TextChanged(sender As Object, e As EventArgs) Handles txt_path_archiver_queue.TextChanged
        cfg_config.path_archiver_queue = txt_path_archiver_queue.Text
    End Sub

    Private Sub txt_path_archiver_unclassified_TextChanged(sender As Object, e As EventArgs) Handles txt_path_archiver_unclassified.TextChanged
        cfg_config.path_archiver_unclassified = txt_path_archiver_unclassified.Text
    End Sub

    Private Sub txt_path_bulkimport_config_TextChanged(sender As Object, e As EventArgs) Handles txt_path_bulkimport_config.TextChanged
        cfg_config.path_bulkimport_config = txt_path_bulkimport_config.Text
    End Sub

    Private Sub txt_path_bulkimport_install_TextChanged(sender As Object, e As EventArgs) Handles txt_path_bulkimport_install.TextChanged
        cfg_config.path_bulkimport_install = txt_path_bulkimport_install.Text
    End Sub

    Private Sub txt_path_bulkimport_logs_TextChanged(sender As Object, e As EventArgs) Handles txt_path_bulkimport_logs.TextChanged
        cfg_config.path_bulkimport_logs = txt_path_bulkimport_logs.Text
    End Sub

    Private Sub txt_path_bulkimport_temp_TextChanged(sender As Object, e As EventArgs) Handles txt_path_bulkimport_temp.TextChanged
        cfg_config.path_bulkimport_temp = txt_path_bulkimport_temp.Text
    End Sub

    Private Sub txt_path_pstsource_default_TextChanged(sender As Object, e As EventArgs) Handles txt_path_pstsource_default.TextChanged
        cfg_config.path_pstsource_default = txt_path_pstsource_default.Text
    End Sub



    Public Function ShowFolderDialog() As String
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

    Private Sub btn_config_path_archiver_install_Click(sender As Object, e As EventArgs) Handles btn_config_path_archiver_install.Click
        txt_path_archiver_install.Text = ShowFolderDialog()
    End Sub

    Private Sub btn_config_path_archiver_pickup_Click(sender As Object, e As EventArgs) Handles btn_config_path_archiver_pickup.Click
        txt_path_archiver_pickup.Text = ShowFolderDialog()
    End Sub

    Private Sub btn_config_path_archiver_queue_Click(sender As Object, e As EventArgs) Handles btn_config_path_archiver_queue.Click
        txt_path_archiver_queue.Text = ShowFolderDialog()

    End Sub

    Private Sub btn_config_path_archiver_unclassified_Click(sender As Object, e As EventArgs) Handles btn_config_path_archiver_unclassified.Click
        txt_path_archiver_unclassified.Text = ShowFolderDialog()

    End Sub

    Private Sub btn_config_path_bulkimport_install_Click(sender As Object, e As EventArgs) Handles btn_config_path_bulkimport_install.Click
        txt_path_bulkimport_install.Text = ShowFolderDialog()

    End Sub

    Private Sub btn_config_path_bulkimport_config_Click(sender As Object, e As EventArgs) Handles btn_config_path_bulkimport_config.Click
        txt_path_bulkimport_config.Text = ShowFolderDialog()

    End Sub

    Private Sub btn_config_path_bulkimport_logs_Click(sender As Object, e As EventArgs) Handles btn_config_path_bulkimport_logs.Click
        txt_path_bulkimport_logs.Text = ShowFolderDialog()

    End Sub

    Private Sub btn_config_path_bulkimport_temp_Click(sender As Object, e As EventArgs) Handles btn_config_path_bulkimport_temp.Click
        txt_path_bulkimport_temp.Text = ShowFolderDialog()
    End Sub

    Private Sub btn_path_pstsource_default_Click(sender As Object, e As EventArgs) Handles btn_path_pstsource_default.Click
        txt_path_pstsource_default.Text = ShowFolderDialog()
    End Sub
End Class