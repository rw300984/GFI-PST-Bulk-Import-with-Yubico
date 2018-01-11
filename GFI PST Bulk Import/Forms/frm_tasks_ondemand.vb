Imports System.ComponentModel

Imports System.IO


Public Class frm_tasks_ondemand
    Dim frm_tasks_ondemand_directory As New frm_tasks_schedule_directory
    Dim frm_tasks_ondemand_file As New frm_tasks_schedule_file
    Dim job_status As Job_status
    Dim batch_string As String
    Dim task_mode As Integer

    Private Sub frm_tasks_ondemand_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadForms()
            ShowOptionsBasedOnMode()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub frm_tasks_ondemand_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Try
            ShowOptionsBasedOnMode()
        Catch ex As Exception

        End Try


    End Sub

    Public Function LoadForms()
        Try
            frm_tasks_ondemand_file.TopLevel = False
            frm_tasks_ondemand_file.WindowState = FormWindowState.Maximized
            frm_tasks_ondemand_file.FormBorderStyle = FormBorderStyle.None

            frm_tasks_ondemand_directory.TopLevel = False
            frm_tasks_ondemand_directory.WindowState = FormWindowState.Maximized
            frm_tasks_ondemand_directory.FormBorderStyle = FormBorderStyle.None

            frm_tasks_ondemand_directory.Visible = False
            frm_tasks_ondemand_file.Visible = False

            Panel1.Controls.Add(frm_tasks_ondemand_file)
            Panel1.Controls.Add(frm_tasks_ondemand_directory)
        Catch ex As Exception

        End Try

    End Function

    Public Function ShowOptionsBasedOnMode()
        Try
            If cfg_config.owner_owner_mode = 0 Then
                frm_tasks_ondemand_directory.Visible = True
                frm_tasks_ondemand_file.Visible = False
            Else
                frm_tasks_ondemand_directory.Visible = False
                frm_tasks_ondemand_file.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Select Case Button1.Text
                Case "Run task"
                    task_mode = 0
                    txt_task_ondemand_status.Clear()
                    ProgressBar1.ForeColor = SystemColors.Highlight
                    ProgressBar1.Update()
                    bgw_tasks_ondemand.RunWorkerAsync()
                    Button1.Text = "Wait"
                    Button1.Enabled = False
                    Button2.Enabled = False
                Case "Wait"
                    bgw_tasks_ondemand.CancelAsync()
                    Button1.Text = "Run task"
                    Button1.Enabled = True
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Public Function RunTask(ByVal mode As Integer)
        Try
            Dim JobDir As New DirectoryInfo(cfg_config.path_bulkimport_install & "\tasks\Jobs")
            Dim TempDir As New DirectoryInfo(cfg_config.path_bulkimport_temp)
            For Each dir As DirectoryInfo In TempDir.GetDirectories
                dir.Delete(True)
            Next
            For Each file As FileInfo In JobDir.GetFiles()
                file.Delete()
            Next
            batch_string = ""
            job_status.task_name = "OnDemand"
            job_status.task_starttime = DateTime.Now
            job_status.task_status = "Starting"
            job_status.task_pst = "n.a."
            job_status.task_users = "n.a."
            job_status.task_progress = 0
            job_status.task_endtime = DateTime.Now
            files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
            bgw_tasks_ondemand.ReportProgress(10, {"###### Start On Demand Task at " & DateTime.Now & " ######" & vbCrLf})
            If frm_tasks_ondemand_file.txt_task_file_path.Text.Contains("%") Then
                Dim directory As String
                If frm_tasks_ondemand_file.cbx_task_file_use_default.Checked = False Then
                    directory = frm_tasks_ondemand_file.txt_task_file_path.Text
                Else
                    directory = cfg_config.path_pstsource_default
                End If
                Dim users As String() = Importer.GetUser(directory)
                bgw_tasks_ondemand.ReportProgress(15, {"----- Step 1: Get users -----" & vbCrLf})
                bgw_tasks_ondemand.ReportProgress(20, {"Result: " & users.Count & " Users identified" & vbCrLf})
                job_status.task_endtime = DateTime.Now
                job_status.task_status = "Running"
                job_status.task_progress = 20
                files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                bgw_tasks_ondemand.ReportProgress(20, {"----- Step 2.x: Get PST files for each user -----" & vbCrLf})
                If users IsNot Nothing Then
                    For Each user In users
                        Dim src_user_path() As String = Importer.GetFiles(user, directory, frm_tasks_ondemand_file.cbx_task_incl_sub.CheckState, frm_tasks_ondemand_file.txt_task_schedule_file_email_domain.Text)
                        If src_user_path IsNot Nothing Then
                            job_status.task_endtime = DateTime.Now
                            bgw_tasks_ondemand.ReportProgress(25, {"User (" & user & "): " & src_user_path.Count & " PST Files found" & vbCrLf})
                            bgw_tasks_ondemand.ReportProgress(25, {"----- Step 2.1: Copy PST files to Importer Temp location -----" & vbCrLf})
                            job_status.task_pst = src_user_path.Count
                            job_status.task_progress = 25
                            files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                            For Each src_path In src_user_path
                                If src_path Is Nothing Then
                                Else
                                    CopyPST(src_path)
                                End If
                                job_status.task_endtime = DateTime.Now
                                bgw_tasks_ondemand.ReportProgress(35, {"."})
                            Next
                            bgw_tasks_ondemand.ReportProgress(35, {vbCrLf & "----- Step 2.1: Copy PST files finished-----" & vbCrLf})
                            job_status.task_endtime = DateTime.Now
                            job_status.task_progress = 35
                            files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                        End If
                    Next
                    bgw_tasks_ondemand.ReportProgress(35, {"----- Step 2.x: Get PST files for each user finished-----" & vbCrLf})
                Else
                End If
            Else
                Dim directory As String
                If frm_tasks_ondemand_file.cbx_task_file_use_default.Checked = False Then
                    directory = frm_tasks_ondemand_file.txt_task_file_path.Text
                Else
                    directory = cfg_config.path_pstsource_default
                End If
                Dim folder As String() = Importer.GetFolders(directory)
                If folder IsNot Nothing Then
                    For Each entry In folder
                        txt_task_ondemand_status.AppendText(entry & vbCrLf)
                    Next
                Else
                    txt_task_ondemand_status.AppendText("No folders found or not accessible")
                End If
            End If
            Dim dst_directory As String = cfg_config.path_bulkimport_temp & "%user%"
            Dim dst_users As String() = Importer.GetUser(dst_directory)
            bgw_tasks_ondemand.ReportProgress(40, {"----- Step 3.x: Create Job files for each user-----" & vbCrLf})
            bgw_tasks_ondemand.ReportProgress(40, {"Result: " & dst_users.Count & " Users identified" & vbCrLf})
            job_status.task_endtime = DateTime.Now
            job_status.task_users = dst_users.Count
            job_status.task_progress = 40
            files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
            If dst_users IsNot Nothing Then
                For Each user In dst_users
                    Dim dst_path_cfg As String
                    Dim dst_user_path() As String = Importer.GetFiles(user, dst_directory, frm_tasks_ondemand_file.cbx_task_incl_sub.CheckState, "", 1)
                    If dst_user_path IsNot Nothing Then
                        bgw_tasks_ondemand.ReportProgress(45, {"User (" & user & "): Generating job file" & vbCrLf})
                        job_status.task_endtime = DateTime.Now
                        job_status.task_progress = 45
                        files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                        For Each dst_path In dst_user_path
                            bgw_tasks_ondemand.ReportProgress(45, {"."})
                            If dst_path Is Nothing Then
                            Else
                                Importer.SaveAsCSV(user & "_ondemand", dst_path + vbCrLf)
                                dst_path_cfg = user & "_ondemand"
                            End If
                        Next
                        bgw_tasks_ondemand.ReportProgress(55, {vbCrLf & "User (" & user & "): Job file (" & user & "_ondemand.job" & ") created" & vbCrLf})
                    End If
                    job_status.task_endtime = DateTime.Now
                    job_status.task_progress = 55
                    files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                    bgw_tasks_ondemand.ReportProgress(60, {"----- Step 3.1: Execute job -----" & vbCrLf})
                    job_status.task_progress = 60
                    job_status.task_endtime = DateTime.Now
                    Select Case mode
                        Case 0
                            job_status.task_status = "Exporting PST files"
                            files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                            job_status.task_mode = "Import"
                            StartImport(cfg_config.path_bulkimport_temp & user, user & "_ondemand.job")
                        Case 1
                            bgw_tasks_ondemand.ReportProgress(60, {"Create batch, please wait..." & vbCrLf})
                            job_status.task_status = "Create batch"
                            files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                            job_status.task_mode = "Create Batch"
                            CreateBatch(cfg_config.path_bulkimport_temp & user, user & "_ondemand.job")
                    End Select
                    'txt_task_ondemand_status.AppendText(ImportReportProcess & vbCrLf)
                    bgw_tasks_ondemand.ReportProgress(80, {"----- Step 3.1: Job completed -----" & vbCrLf})
                    job_status.task_progress = 80
                    job_status.task_endtime = DateTime.Now
                    files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                Next

                If mode = 1 Then
                    bgw_tasks_ondemand.ReportProgress(80, {"----- Step 3.2: Write batch file -----" & vbCrLf})
                    job_status.task_status = "Write batch file to export location"
                    files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                    File.WriteAllText(cfg_config.path_bulkimport_logs & "\" & DateTime.Now.ToString("HHmmssddMMyy_") & "_ondemand.bat", batch_string)
                    bgw_tasks_ondemand.ReportProgress(80, {"----- Step 3.2: Write batch completed -----" & vbCrLf})
                End If

                If job_status.task_status = "Error" Then
                Else
                    job_status.task_status = "Finished"
                End If

                job_status.task_progress = 100
                job_status.task_endtime = DateTime.Now
                files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
                bgw_tasks_ondemand.ReportProgress(100, {"----- Step 3.x: Tasks Finished -----" & vbCrLf})
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub bgw_tasks_ondemand_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_tasks_ondemand.DoWork
        Try
            '  ProgressBar1.ForeColor = SystemColors.Highlight
            Call RunTask(task_mode)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bgw_tasks_ondemand_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_tasks_ondemand.ProgressChanged
        Try
            Dim userstate() As String = DirectCast(e.UserState, String())

            If userstate(0).IndexOf("," & Chr(34) & "error ") > -1 Then
                ProgressBar1.ForeColor = Color.Coral
                job_status.task_status = "Error"
                files.Write_Status(job_status, cfg_config.path_bulkimport_install & "\tasks\status\" & job_status.task_name & ".status")
            End If

            txt_task_ondemand_status.AppendText(userstate(0))
            ProgressBar1.Value = e.ProgressPercentage
            ProgressBar1.Update()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bgw_tasks_ondemand_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_tasks_ondemand.RunWorkerCompleted
        If cfg_config.monitor_alert_task = 1 Then
            CreateAlerts(1, "Task", "Notification: Task completed " & job_status.task_name & " - GFI Bulk PST Importer on " & Environment.MachineName,
                   "Alert type: Task " & vbCrLf &
                   "Notification: Task " & Chr(34) & job_status.task_name & Chr(34) & " completed" & vbCrLf &
                   "Machine Name: " & Environment.MachineName & vbCrLf &
                   "Date: " & DateTime.Now & vbCrLf & vbCrLf &
                   "Additional information: " & vbCrLf &
                   "Mode: " & job_status.task_mode & vbCrLf &
                   "Start date: " & job_status.task_starttime & vbCrLf &
                   "End date: " & job_status.task_endtime & vbCrLf &
                   "Users retrieved: " & job_status.task_users & vbCrLf &
                   "PST files identified: " & job_status.task_pst & vbCrLf &
                   "Task Status:" & job_status.task_status)
        End If

        Button1.Text = "Run task"
        Button1.Enabled = True
        Button2.Text = "Create Batch only"
        Button2.Enabled = True
    End Sub

    Public Function StartImport(ByVal dst_user_path As String, ByVal dst_user_job As String)
        Try

            Dim dir As New DirectoryInfo(cfg_config.path_bulkimport_install & "\" & cfg_config.general_office_bit)
            For Each file As FileInfo In dir.GetFiles
                file.CopyTo(cfg_config.path_bulkimport_install & "\" & file.Name, True)
            Next

            Dim Importer As Process = New Process()
            Dim test() As Process = Process.GetProcessesByName("MassPSTExport")
            For Each killprocess In test
                killprocess.Kill()
            Next
            Dim logpath As String = cfg_config.path_bulkimport_install & "\Debuglogs\MassPSTExport.log"

            If File.Exists(logpath) = True Then
                File.Delete(logpath)
            End If

            Importer.StartInfo.FileName = "MassPSTExport.exe"
            Importer.StartInfo.Arguments = "/donotmark /ignoreflag /exportCalendar /exportPath" & Chr(34) & cfg_config.path_archiver_pickup & Chr(34) & " /pstDirectory" & Chr(34) & dst_user_path & Chr(34) & " /ownerFile" & Chr(34) & cfg_config.path_bulkimport_install & "\tasks\jobs\" & dst_user_job & Chr(34)
            Importer.StartInfo.UseShellExecute = False
            Importer.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

            Importer.StartInfo.CreateNoWindow = True

            Importer.Start()

            Dim p() As Process
            p = Process.GetProcessesByName("MassPSTExport")

            bgw_tasks_ondemand.ReportProgress(60, {"Please wait..."})
            Do While p.Count > 0
                Try
                    bgw_tasks_ondemand.ReportProgress(60, {"."})
                    Threading.Thread.Sleep(500)
                    p = Process.GetProcessesByName("MassPSTExport")
                Catch ex As Exception

                End Try
            Loop

            Dim fs As New FileStream(logpath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim sr As New StreamReader(fs)
            bgw_tasks_ondemand.ReportProgress(60, {vbCrLf & vbCrLf & "--- Import Result: " & vbCrLf & sr.ReadToEnd & vbCrLf})
            fs.Close()


        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function CreateBatch(ByVal dst_user_path As String, ByVal dst_user_job As String)
        Try
            Dim cmd As String = "MassPSTExport.exe /donotmark /ignoreflag /exportCalendar /exportPath" & Chr(34) & cfg_config.path_archiver_pickup & Chr(34) & " /pstDirectory" & Chr(34) & dst_user_path & Chr(34) & " /ownerFile" & Chr(34) & cfg_config.path_bulkimport_install & "\tasks\jobs\" & dst_user_job & Chr(34) & vbCrLf
            If batch_string = "" Then
                batch_string = cmd & vbCrLf
            Else
                batch_string = batch_string.Insert(batch_string.Length - 1, cmd & vbCrLf)
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Select Case Button2.Text
                Case "Create Batch only"
                    task_mode = 1
                    txt_task_ondemand_status.Clear()
                    ProgressBar1.ForeColor = SystemColors.Highlight
                    ProgressBar1.Update()
                    bgw_tasks_ondemand.RunWorkerAsync()
                    Button2.Text = "Wait"
                    Button1.Enabled = False
                    Button2.Enabled = False
                Case "Wait"
                    bgw_tasks_ondemand.CancelAsync()
                    Button2.Text = "Create Batch only"
                    Button2.Enabled = True
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class