Imports System.ComponentModel
Imports System.IO

Public Class frm_dashboard

    Private Sub frm_dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' bgw_dashboard_monitor.RunWorkerAsync()
        LoadServiceName()

        If bgw_dashboard_monitor.IsBusy = True Then
            btn_start_stop_monitoring.Text = "Stop monitoring"
        Else
            btn_start_stop_monitoring.Text = "Start monitoring"
        End If
    End Sub

    Public Function start_monitor()
        Try
            Dim credentials As monitor.WMI_Credentials
            Dim options As monitor.WMI_Options
            Dim wmi_monitor_0 As Integer
            Dim wmi_monitor_1 As Integer
            Dim wmi_monitor_temp_0 As Integer
            Dim wmi_monitor_temp_1 As Integer

            Dim service_monitor_0 As Integer
            Dim service_monitor_1 As Integer
            Dim service_monitor_2 As Integer
            Dim service_monitor_3 As Integer
            Dim service_monitor_4 As Integer
            Dim service_monitor_5 As Integer
            Dim service_monitor_6 As Integer

            Dim disk_monitor_0 As Single
            Dim disk_monitor_1 As Single

            Dim network_monitor_0 As Single
            Dim network_monitor_1 As Single

            Dim file_monitor_0 As Integer
            Dim file_monitor_1 As Integer
            Dim file_monitor_2 As Integer

            Dim event_monitor_1(4) As String
            Dim event_monitor_2(4) As String
            Dim event_monitor_3(4) As String
            Dim event_monitor_temp_0 As Integer

            Dim task_monitor_0 As String
            Dim task_monitor_1 As String
            Dim task_monitor_2 As String
            Dim task_monitor_3 As String


            Dim host As String = "localhost"
            credentials.username = "ronny.wolf"
            credentials.password = "Gina@1984"
            credentials.domain = "rw300984"

            options.Query = ""
            options.Properties = ""
            options.Duration = 1
            options.Host = host
            Do
                If bgw_dashboard_monitor.CancellationPending = True Then
                    bgw_dashboard_monitor.ReportProgress(Nothing, {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"})
                    Exit Function
                End If

                ' Monitor CPU and Memory

                pfc_cpu_load.InstanceName = cfg_config.monitor_cpu
                wmi_monitor_0 = pfc_cpu_load.NextValue
                If wmi_monitor_0 > 80 Then
                    CreateAlerts(0, "CPU", "Alert: High CPU Load " & wmi_monitor_0 & "% - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: CPU" & vbCrLf &
                    "Notification: High CPU Load" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & wmi_monitor_0)
                Else
                    treshold.cpu_count = 0
                End If

                'options.Query = "SELECT * FROM Win32_Processor"
                'options.Properties = "LoadPercentage"
                'wmi_monitor_0 = monitor.WMI_Monitor(options, credentials)
                options.Query = "SELECT * FROM Win32_OperatingSystem"
                options.Properties = "FreePhysicalMemory"
                wmi_monitor_temp_0 = monitor.WMI_Monitor(options, credentials)
                options.Query = "SELECT * FROM Win32_OperatingSystem"
                options.Properties = "TotalVisibleMemorySize"
                wmi_monitor_temp_1 = monitor.WMI_Monitor(options, credentials)
                wmi_monitor_1 = 100 - (wmi_monitor_temp_0 / wmi_monitor_temp_1 * 100)

                ' Monitor Disk I/O

                pfc_disk_read.InstanceName = cfg_config.monitor_disk
                pfc_disk_write.InstanceName = cfg_config.monitor_disk

                disk_monitor_0 = Math.Round(pfc_disk_read.NextValue() / 1024 / 1024, 2, MidpointRounding.AwayFromZero)
                disk_monitor_1 = Math.Round(pfc_disk_write.NextValue() / 1024 / 1024, 2, MidpointRounding.AwayFromZero)

                ' Monitor Network I/O

                pfc_net_received.InstanceName = cfg_config.monitor_network
                pfc_net_sent.InstanceName = cfg_config.monitor_network

                network_monitor_0 = Math.Round(pfc_net_received.NextValue() / 1024 / 1024, 2, MidpointRounding.AwayFromZero)
                network_monitor_1 = Math.Round(pfc_net_sent.NextValue() / 1024 / 1024, 2, MidpointRounding.AwayFromZero)

                ' Monitor File Queues

                file_monitor_0 = monitor.File_Monitor(cfg_config.path_archiver_pickup, "*.*")
                file_monitor_1 = monitor.File_Monitor(cfg_config.path_archiver_queue, "*.*")
                file_monitor_2 = monitor.File_Monitor(cfg_config.path_archiver_unclassified, "*.*")

                If file_monitor_0 > cfg_config.monitor_pickup Then
                    CreateAlerts(0, "Directory_pickup", "Alert: Pickup Directory: " & file_monitor_0 & " Files stored - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Directory" & vbCrLf &
                    "Notification: Pickup Directory reached treshold" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & file_monitor_0)
                Else
                    treshold.directory_pickup_count = 0
                End If

                If file_monitor_1 > cfg_config.monitor_queue Then
                    CreateAlerts(0, "Directory_queue", "Alert: Queue Directory: " & file_monitor_1 & " Files stored - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Directory" & vbCrLf &
                    "Notification: Queue Directory reached treshold" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & file_monitor_1)
                Else
                    treshold.directory_queue_count = 0
                End If

                If file_monitor_2 > cfg_config.monitor_unclassified Then
                    CreateAlerts(0, "Directory_unclassified", "Alert: Unclassified Directory: " & file_monitor_2 & " Files stored - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Directory" & vbCrLf &
                    "Notification: Unclassified Directory reached treshold" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & file_monitor_2)
                Else
                    treshold.directory_unclassified_count = 0
                End If

                ' Monitor Services

                service_monitor_0 = monitor.Service_Monitor(cfg_config.monitor_service1)
                service_monitor_1 = monitor.Service_Monitor(cfg_config.monitor_service2)
                service_monitor_2 = monitor.Service_Monitor(cfg_config.monitor_service3)
                service_monitor_3 = monitor.Service_Monitor(cfg_config.monitor_service4)
                service_monitor_4 = monitor.Service_Monitor(cfg_config.monitor_service5)
                service_monitor_5 = monitor.Service_Monitor(cfg_config.monitor_service6)

                If service_monitor_0 = 1 Then
                    CreateAlerts(0, "service_0", "Alert: " & cfg_config.monitor_service1 & " stopped - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Service Monitor" & vbCrLf &
                    "Notification: " & cfg_config.monitor_service1 & " stopped" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & service_monitor_0)
                Else
                    treshold.service_0_count = 0
                End If
                If service_monitor_1 = 1 Then
                    CreateAlerts(0, "service_1", "Alert: " & cfg_config.monitor_service2 & " stopped - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Service Monitor" & vbCrLf &
                    "Notification: " & cfg_config.monitor_service2 & " stopped" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & service_monitor_1)
                Else
                    treshold.service_1_count = 0
                End If
                If service_monitor_2 = 1 Then
                    CreateAlerts(0, "service_2", "Alert: " & cfg_config.monitor_service3 & " stopped - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Service Monitor" & vbCrLf &
                    "Notification: " & cfg_config.monitor_service3 & " stopped" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & service_monitor_2)
                Else
                    treshold.service_2_count = 0
                End If
                If service_monitor_3 = 1 Then
                    CreateAlerts(0, "service_3", "Alert: " & cfg_config.monitor_service4 & " stopped - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Service Monitor" & vbCrLf &
                    "Notification: " & cfg_config.monitor_service4 & " stopped" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & service_monitor_3)
                Else
                    treshold.service_3_count = 0
                End If
                If service_monitor_4 = 1 Then
                    CreateAlerts(0, "service_4", "Alert: " & cfg_config.monitor_service5 & " stopped - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Service Monitor" & vbCrLf &
                    "Notification: " & cfg_config.monitor_service5 & " stopped" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & service_monitor_4)
                Else
                    treshold.service_4_count = 0
                End If
                If service_monitor_5 = 1 Then
                    CreateAlerts(0, "service_5", "Alert: " & cfg_config.monitor_service6 & " stopped - GFI Bulk PST Importer on " & Environment.MachineName,
                    "Alert type: Service Monitor" & vbCrLf &
                    "Notification: " & cfg_config.monitor_service6 & " stopped" & vbCrLf &
                    "Machine Name: " & Environment.MachineName & vbCrLf &
                    "Date: " & DateTime.Now & vbCrLf &
                    "Value: " & service_monitor_5)
                Else
                    treshold.service_5_count = 0
                End If


                ' Task Monitor

                Dim myDir As DirectoryInfo = New DirectoryInfo(cfg_config.path_bulkimport_install & "\tasks\status")
                If (myDir.EnumerateFiles().Any()) Then
                    Dim myFile As New DirectoryInfo(cfg_config.path_bulkimport_install & "\tasks\status")
                    Dim file As FileInfo = myFile.GetFiles().OrderByDescending(Function(f) f.LastWriteTime).First()
                    task_monitor_0 = Read_Status(cfg_config.path_bulkimport_install & "\tasks\status\" & file.Name, "0") & " - " & Read_Status(cfg_config.path_bulkimport_install & "\tasks\status\" & file.Name, "6")
                    task_monitor_1 = Read_Status(cfg_config.path_bulkimport_install & "\tasks\status\" & file.Name, "1")
                    task_monitor_2 = Read_Status(cfg_config.path_bulkimport_install & "\tasks\status\" & file.Name, "2")
                    Dim span As TimeSpan = CDate(Read_Status(cfg_config.path_bulkimport_install & "\tasks\status\" & file.Name, "4")).Subtract(CDate(Read_Status(cfg_config.path_bulkimport_install & "\tasks\status\" & file.Name, "3")))
                    task_monitor_3 = span.Hours & ":" & span.Minutes & ":" & span.Seconds & " (" & Read_Status(cfg_config.path_bulkimport_install & "\tasks\status\" & file.Name, "5") & "%)"
                Else

                End If



                ' Monitor Eventlogs

                event_monitor_temp_0 = evt_system.Entries.Count - 1
                Dim count As Integer = event_monitor_temp_0 - 5
                Dim event_count As Integer = 0
                Do While count < event_monitor_temp_0
                    event_monitor_1(event_count) = evt_system.Entries.Item(count).TimeGenerated & ";" & evt_system.Entries.Item(count).EventID & ";" & evt_system.Entries.Item(count).EntryType & ";" & evt_system.Entries.Item(count).Source & ";" & evt_system.Entries.Item(count).Message
                    If event_count = 4 Then
                        Exit Do
                    End If
                    event_count = event_count + 1
                    count = count + 1
                Loop

                event_monitor_temp_0 = evt_application.Entries.Count - 1
                count = event_monitor_temp_0 - 5
                event_count = 0
                Do While count <= event_monitor_temp_0
                    event_monitor_3(event_count) = evt_application.Entries.Item(count).TimeGenerated & ";" & evt_application.Entries.Item(count).EventID & ";" & evt_application.Entries.Item(count).EntryType & ";" & evt_application.Entries.Item(count).Source & ";" & evt_application.Entries.Item(count).Message
                    If event_count = 4 Then
                        Exit Do
                    End If
                    event_count = event_count + 1
                    count = count + 1
                Loop

                bgw_dashboard_monitor.ReportProgress(Nothing, {wmi_monitor_0.ToString, wmi_monitor_1.ToString, service_monitor_0.ToString, service_monitor_1.ToString, service_monitor_2.ToString, service_monitor_3.ToString, service_monitor_4.ToString, service_monitor_5.ToString, service_monitor_6.ToString, disk_monitor_0.ToString, disk_monitor_1.ToString, network_monitor_0.ToString, network_monitor_1.ToString, event_monitor_1(0), event_monitor_1(1), event_monitor_1(2), event_monitor_1(3), event_monitor_1(4), event_monitor_2(0), event_monitor_2(1), event_monitor_2(2), event_monitor_2(3), event_monitor_2(4), event_monitor_3(0), event_monitor_3(1), event_monitor_3(2), event_monitor_3(3), event_monitor_3(4), file_monitor_0.ToString, file_monitor_1.ToString, file_monitor_2.ToString, task_monitor_0, task_monitor_1, task_monitor_2, task_monitor_3})
                Threading.Thread.Sleep(1000)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function



    Private Sub bgw_dashboard_monitor_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_dashboard_monitor.DoWork
        Try
            Call start_monitor()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bgw_dashboard_monitor_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_dashboard_monitor.ProgressChanged
        Try
            Dim userstate() As String = DirectCast(e.UserState, String())
            pgb_dashboard_cpu.Value = CInt(userstate(0))
            lbl_dashboard_cpu.Text = CInt(userstate(0)) & " %"
            pgb_dashboard_memory.Value = CInt(userstate(1))
            lbl_dashboard_memory.Text = CInt(userstate(1)) & " %"
            Select Case CInt(userstate(2))
                Case 4
                    lbl_dashboard_service_0.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_0.BackColor = Color.Green
                Case 1
                    lbl_dashboard_service_0.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_0.BackColor = Color.Red
                Case 0
                    lbl_dashboard_service_0.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_0.BackColor = Color.DimGray
                Case Else
                    lbl_dashboard_service_0.ForeColor = Color.Black
                    lbl_dashboard_service_0.BackColor = Color.Yellow
            End Select
            Select Case CInt(userstate(3))
                Case 4
                    lbl_dashboard_service_1.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_1.BackColor = Color.Green
                Case 1
                    lbl_dashboard_service_1.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_1.BackColor = Color.Red
                Case 0
                    lbl_dashboard_service_1.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_1.BackColor = Color.DimGray
                Case Else
                    lbl_dashboard_service_1.ForeColor = Color.Black
                    lbl_dashboard_service_1.BackColor = Color.Yellow
            End Select
            Select Case CInt(userstate(4))
                Case 4
                    lbl_dashboard_service_2.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_2.BackColor = Color.Green
                Case 1
                    lbl_dashboard_service_2.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_2.BackColor = Color.Red
                Case 0
                    lbl_dashboard_service_2.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_2.BackColor = Color.DimGray
                Case Else
                    lbl_dashboard_service_2.ForeColor = Color.Black
                    lbl_dashboard_service_2.BackColor = Color.Yellow
            End Select
            Select Case CInt(userstate(5))
                Case 4
                    lbl_dashboard_service_3.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_3.BackColor = Color.Green
                Case 1
                    lbl_dashboard_service_3.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_3.BackColor = Color.Red
                Case 0
                    lbl_dashboard_service_3.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_3.BackColor = Color.DimGray
                Case Else
                    lbl_dashboard_service_3.ForeColor = Color.Black
                    lbl_dashboard_service_3.BackColor = Color.Yellow
            End Select
            Select Case CInt(userstate(6))
                Case 4
                    lbl_dashboard_service_4.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_4.BackColor = Color.Green
                Case 1
                    lbl_dashboard_service_4.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_4.BackColor = Color.Red
                Case 0
                    lbl_dashboard_service_4.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_4.BackColor = Color.DimGray
                Case Else
                    lbl_dashboard_service_4.ForeColor = Color.Black
                    lbl_dashboard_service_4.BackColor = Color.Yellow
            End Select
            Select Case CInt(userstate(7))
                Case 4
                    lbl_dashboard_service_5.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_5.BackColor = Color.Green
                Case 1
                    lbl_dashboard_service_5.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_5.BackColor = Color.Red
                Case 0
                    lbl_dashboard_service_5.ForeColor = SystemColors.ControlLightLight
                    lbl_dashboard_service_5.BackColor = Color.DimGray
                Case Else
                    lbl_dashboard_service_5.ForeColor = Color.Black
                    lbl_dashboard_service_5.BackColor = Color.Yellow
            End Select
            lbl_dashboard_disk_read.Text = userstate(9) & " Mb/s"
            lbl_dashboard_disk_write.Text = userstate(10) & " Mb/s"
            lbl_dashboard_network_read.Text = userstate(11) & "Mb/s"
            lbl_dashboard_network_write.Text = userstate(12) & "Mb/s"
            RichTextBox3.Text = userstate(17) & vbCrLf & userstate(16) & vbCrLf & userstate(15) & vbCrLf & userstate(14) & vbCrLf & userstate(13) & vbCrLf
            RichTextBox1.Text = userstate(27) & vbCrLf & userstate(26) & vbCrLf & userstate(25) & vbCrLf & userstate(24) & vbCrLf & userstate(23) & vbCrLf
            pgb_dashboard_pickup.Maximum = cfg_config.monitor_pickup
            If userstate(28) = -1 Then
            Else
                If CInt(userstate(28)) > pgb_dashboard_pickup.Maximum Then
                    pgb_dashboard_pickup.Maximum = CInt(userstate(28))
                    pgb_dashboard_pickup.ForeColor = Color.Red
                    pgb_dashboard_pickup.Value = CInt(userstate(28))
                Else
                    pgb_dashboard_pickup.Value = CInt(userstate(28))
                    pgb_dashboard_pickup.ForeColor = SystemColors.Highlight
                End If
            End If


            pgb_dashboard_queue.Maximum = cfg_config.monitor_queue
            If userstate(29) = -1 Then
            Else
                If CInt(userstate(29)) > pgb_dashboard_queue.Maximum Then
                    pgb_dashboard_queue.Maximum = CInt(userstate(29))
                    pgb_dashboard_queue.ForeColor = Color.Red

                    pgb_dashboard_queue.Value = CInt(userstate(29))
                Else
                    pgb_dashboard_queue.ForeColor = SystemColors.Highlight

                    pgb_dashboard_queue.Value = CInt(userstate(29))
                End If
            End If

            pgb_dashboard_unclassified.Maximum = cfg_config.monitor_unclassified
            If userstate(30) = -1 Then
            Else
                If CInt(userstate(30)) > pgb_dashboard_unclassified.Maximum Then
                    pgb_dashboard_unclassified.Maximum = CInt(userstate(30))
                    pgb_dashboard_unclassified.ForeColor = Color.Red
                    pgb_dashboard_unclassified.Value = CInt(userstate(30))
                Else
                    pgb_dashboard_unclassified.ForeColor = SystemColors.Highlight
                    pgb_dashboard_unclassified.Value = CInt(userstate(30))
                End If
            End If



            lbl_dashboard_file_pickup.Text = CInt(userstate(28))
            lbl_dashboard_file_queue.Text = CInt(userstate(29))
            lbl_dashboard_file_unclassified.Text = CInt(userstate(30))

            lbl_dashboard_import_jobname.Text = userstate(31)
            lbl_dashboard_import_user.Text = userstate(32)
            lbl_dashboard_import_pst.Text = userstate(33)
            lbl_dashboard_import_duration.Text = userstate(34)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_start_stop_monitoring_Click(sender As Object, e As EventArgs) Handles btn_start_stop_monitoring.Click
        Try
            Select Case btn_start_stop_monitoring.Text
                Case "Start monitoring"
                    bgw_dashboard_monitor.RunWorkerAsync()
                    btn_start_stop_monitoring.Text = "Stop monitoring"
                Case "Stop monitoring"
                    bgw_dashboard_monitor.CancelAsync()
                    CleanDashboard()
                    btn_start_stop_monitoring.Text = "Start monitoring"
            End Select
        Catch ex As Exception
            CleanDashboard()

        End Try
    End Sub
    Public Function LoadServiceName()
        Try
            lbl_dashboard_service_0.Text = cfg_config.monitor_service1
            lbl_dashboard_service_1.Text = cfg_config.monitor_service2
            lbl_dashboard_service_2.Text = cfg_config.monitor_service3
            lbl_dashboard_service_3.Text = cfg_config.monitor_service4
            lbl_dashboard_service_4.Text = cfg_config.monitor_service5
            lbl_dashboard_service_5.Text = cfg_config.monitor_service6
        Catch ex As Exception

        End Try


    End Function

    Private Sub frm_dashboard_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Try
            LoadServiceName()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_start_archiver_services_Click(sender As Object, e As EventArgs) Handles btn_start_archiver_services.Click
        Try
            Dim Services As String() = {"MARCore", "MARIMAP", "MARMAIS", "MARSearch", "MARStore", "MARVSS"}
            monitor.Service_start(Services)
        Catch ex As Exception

        End Try

    End Sub

    Public Function CleanDashboard()
        RichTextBox1.Clear()

        RichTextBox3.Clear()
        pgb_dashboard_cpu.Value = 0
        pgb_dashboard_memory.Value = 0
        pgb_dashboard_pickup.Value = 0
        pgb_dashboard_queue.Value = 0
        pgb_dashboard_unclassified.Value = 0
        lbl_dashboard_service_0.BackColor = Color.DimGray
        lbl_dashboard_service_1.BackColor = Color.DimGray
        lbl_dashboard_service_2.BackColor = Color.DimGray
        lbl_dashboard_service_3.BackColor = Color.DimGray
        lbl_dashboard_service_4.BackColor = Color.DimGray
        lbl_dashboard_service_5.BackColor = Color.DimGray
        lbl_dashboard_cpu.Text = ""
        lbl_dashboard_disk_read.Text = ""
        lbl_dashboard_disk_write.Text = ""
        lbl_dashboard_file_pickup.Text = ""
        lbl_dashboard_file_queue.Text = ""
        lbl_dashboard_file_unclassified.Text = ""
        lbl_dashboard_memory.Text = ""
        lbl_dashboard_network_read.Text = ""
        lbl_dashboard_network_write.Text = ""


    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("explorer.exe", cfg_config.path_bulkimport_install & "\Debuglogs")
    End Sub
End Class