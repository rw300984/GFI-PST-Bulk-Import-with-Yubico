Public Class frm_config_monitor
    Private Sub cbx_monitor_cpu_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_cpu.TextChanged
        cfg_config.monitor_cpu = cbx_monitor_cpu.Text
    End Sub

    Private Sub cbx_monitor_disk_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_disk.TextChanged
        cfg_config.monitor_disk = cbx_monitor_disk.Text
    End Sub

    Private Sub cbx_monitor_memory_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_memory.TextChanged
        cfg_config.monitor_memory = cbx_monitor_memory.Text
    End Sub

    Private Sub cbx_monitor_network_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_network.TextChanged
        cfg_config.monitor_network = cbx_monitor_network.Text
    End Sub

    Private Sub cbx_monitor_pickup_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_pickup.TextChanged
        cfg_config.monitor_pickup = cbx_monitor_pickup.Text
    End Sub

    Private Sub cbx_monitor_queue_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_queue.TextChanged
        cfg_config.monitor_queue = cbx_monitor_queue.Text
    End Sub

    Private Sub cbx_monitor_service1_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_service1.TextChanged
        cfg_config.monitor_service1 = cbx_monitor_service1.Text
    End Sub

    Private Sub cbx_monitor_service2_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_service2.TextChanged
        cfg_config.monitor_service2 = cbx_monitor_service2.Text
    End Sub

    Private Sub cbx_monitor_service3_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_service3.TextChanged
        cfg_config.monitor_service3 = cbx_monitor_service3.Text
    End Sub

    Private Sub cbx_monitor_service4_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_service4.TextChanged
        cfg_config.monitor_service4 = cbx_monitor_service4.Text
    End Sub

    Private Sub cbx_monitor_service5_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_service5.TextChanged
        cfg_config.monitor_service5 = cbx_monitor_service5.Text
    End Sub

    Private Sub cbx_monitor_service6_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_service6.TextChanged
        cfg_config.monitor_service6 = cbx_monitor_service6.Text
    End Sub

    Private Sub cbx_monitor_unclassified_TextChanged(sender As Object, e As EventArgs) Handles cbx_monitor_unclassified.TextChanged
        cfg_config.monitor_unclassified = cbx_monitor_unclassified.Text
    End Sub

    Private Sub frm_config_monitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillPFC_CBX("Disk")
        FillPFC_CBX("Network")
        FillPFC_CBX("CPU")
        FillPFC_CBX("Memory")
        FillSVC_CBX()

        cbx_monitor_cpu.Text = cfg_config.monitor_cpu
        cbx_monitor_memory.Text = cfg_config.monitor_memory
        cbx_monitor_disk.Text = cfg_config.monitor_disk
        cbx_monitor_network.Text = cfg_config.monitor_network

        cbx_monitor_service1.Text = cfg_config.monitor_service1
        cbx_monitor_service2.Text = cfg_config.monitor_service2
        cbx_monitor_service3.Text = cfg_config.monitor_service3
        cbx_monitor_service4.Text = cfg_config.monitor_service4
        cbx_monitor_service5.Text = cfg_config.monitor_service5
        cbx_monitor_service6.Text = cfg_config.monitor_service6

        cbx_monitor_alert_cpu.CheckState = cfg_config.monitor_alert_cpu
        cbx_monitor_alert_directory.CheckState = cfg_config.monitor_alert_directory
        cbx_monitor_alert_service.CheckState = cfg_config.monitor_alert_service
        cbx_monitor_alert_task.CheckState = cfg_config.monitor_alert_task
        cbx_monitor_alert_mode.Text = cfg_config.monitor_alert_mode

        ' Dim CPU_Monitor() As String = GetInstanceName("", "")

        '  Dim Net_Monitor() As String = GetInstanceName("", "")
        '  Dim Memory_Monitor() As String = GetInstanceName("", "")

    End Sub

    Private Sub frm_config_monitor_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        '  GetInstanceName()
    End Sub

    Public Function GetPFCInstanceName(ByVal mode As Integer, ByVal category As String, ByVal counter As String) As Object()
        Select Case mode
            Case 0
                Dim pfc As PerformanceCounterCategory
                pfc = New PerformanceCounterCategory(category)
                Dim idcolcol As InstanceDataCollectionCollection
                idcolcol = pfc.ReadCategory
                If Not idcolcol.Contains(counter) Then
                Else
                    Dim countData As InstanceDataCollection = idcolcol(counter)

                    Dim idColKeys As ICollection = countData.Keys
                    Dim idColKeysArray(idColKeys.Count - 1) As String
                    idColKeys.CopyTo(idColKeysArray, 0)

                    Return idColKeysArray
                End If
            Case 1
                Dim pfc As New PerformanceCounterCategory(category)
                Dim counters() As PerformanceCounter = pfc.GetCounters
                Dim counter_array(counters.Count - 1) As String
                Dim count_count As Integer
                For count_count = 0 To counters.Length - 1
                    counter_array(count_count) = counters(count_count).CounterName
                Next count_count
                Return counter_array
        End Select

    End Function
    Public Function GetAllServices()
        Dim ServiceList() As System.ServiceProcess.ServiceController
        ServiceList = System.ServiceProcess.ServiceController.GetServices
        Dim ServiceArray(ServiceList.Count - 1) As String
        Dim service_count As Integer
        For service_count = 0 To ServiceList.Length - 1
            ServiceArray(service_count) = ServiceList(service_count).DisplayName
        Next service_count
        Return ServiceArray
    End Function

    Public Function FillSVC_CBX()
        Dim servicelist() As String = GetAllServices()
        cbx_monitor_service1.Items.AddRange(servicelist)
        cbx_monitor_service2.Items.AddRange(servicelist)
        cbx_monitor_service3.Items.AddRange(servicelist)
        cbx_monitor_service4.Items.AddRange(servicelist)
        cbx_monitor_service5.Items.AddRange(servicelist)
        cbx_monitor_service6.Items.AddRange(servicelist)
    End Function
    Public Function FillPFC_CBX(ByVal monitor As String)
        Select Case monitor
            Case "CPU"
                ' cbx_monitor_cpu.Items.Clear()
                Dim cpu_monitor() As String = GetPFCInstanceName(0, "Processor", "% Processor Time")
                cbx_monitor_cpu.Items.AddRange(cpu_monitor)
            Case "Memory"
                ' cbx_monitor_memory.Items.Clear()
                Dim mem_monitor() As String = GetPFCInstanceName(1, "Memory", "")
                cbx_monitor_memory.Items.AddRange(mem_monitor)
            Case "Disk"
                ' cbx_monitor_disk.Items.Clear()
                Dim Disk_Monitor() As String = GetPFCInstanceName(0, "LogicalDisk", "Disk Write Bytes/sec")
                cbx_monitor_disk.Items.AddRange(Disk_Monitor)
            Case "Network"
                ' cbx_monitor_network.Items.Clear()
                Dim Net_Monitor() As String = GetPFCInstanceName(0, "Network Adapter", "Bytes Received/sec")
                cbx_monitor_network.Items.AddRange(Net_Monitor)
        End Select
    End Function

    Private Sub cbx_monitor_alert_service_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_monitor_alert_service.CheckedChanged
        cfg_config.monitor_alert_service = cbx_monitor_alert_service.CheckState
    End Sub

    Private Sub cbx_monitor_alert_directory_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_monitor_alert_directory.CheckedChanged
        cfg_config.monitor_alert_directory = cbx_monitor_alert_directory.CheckState

    End Sub

    Private Sub cbx_monitor_alert_task_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_monitor_alert_task.CheckedChanged
        cfg_config.monitor_alert_task = cbx_monitor_alert_task.CheckState

    End Sub

    Private Sub cbx_monitor_alert_cpu_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_monitor_alert_cpu.CheckedChanged
        cfg_config.monitor_alert_cpu = cbx_monitor_alert_cpu.CheckState
    End Sub

    Private Sub cbx_monitor_alert_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_monitor_alert_mode.SelectedIndexChanged
        cfg_config.monitor_alert_mode = cbx_monitor_alert_mode.Text
    End Sub
End Class