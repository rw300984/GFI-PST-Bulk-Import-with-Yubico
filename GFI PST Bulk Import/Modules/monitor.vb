Imports System.IO
Imports System.Management
Imports System.ServiceProcess

Module monitor
    Public Structure WMI_Options
        Dim Duration As Integer
        Dim Host As String
        Dim Properties As String
        Dim Query As String
    End Structure
    Public Structure WMI_Credentials
        Dim username As String
        Dim password As String
        Dim domain As String
    End Structure
    Public Function WMI_Monitor(ByVal WMI_Options As WMI_Options, ByVal WMI_Credentials As WMI_Credentials) As Integer
        Try
            Dim count As Integer = 0
            Do While count <= WMI_Options.Duration
                Dim WMIResult As Integer = 0
                Dim WMIConnection As New ConnectionOptions
                WMIConnection.Username = WMI_Credentials.username
                WMIConnection.Password = WMI_Credentials.password
                WMIConnection.Authority = "ntlmdomain:" & WMI_Credentials.domain
                Dim WMIObjectCount As Integer = 0
                If WMI_Options.Host Is "localhost" Or WMI_Options.Host Is "127.0.0.1" Or WMI_Options.Host Is Environment.MachineName Then
                    Dim WMISearch As New ManagementObjectSearcher("root\CIMV2", WMI_Options.Query)
                    For Each WMIObject As ManagementObject In WMISearch.Get
                        WMIResult = WMIResult + WMIObject(WMI_Options.Properties)
                        WMIObjectCount = WMIObjectCount + 1
                    Next
                    WMIResult = WMIResult / WMIObjectCount
                Else
                    Dim WMIscope As New ManagementScope("\\" & WMI_Options.Host & "\root\CIMV2", WMIConnection)
                    WMIscope.Connect()
                    Dim WMIquery As New ObjectQuery(WMI_Options.Query)
                    Dim WMISearch As New ManagementObjectSearcher(WMIscope, WMIquery)
                    For Each WMIObject As ManagementObject In WMISearch.Get
                        WMIResult = WMIResult + WMIObject(WMI_Options.Properties)
                        WMIObjectCount = WMIObjectCount + 1
                    Next
                    WMIResult = WMIResult / WMIObjectCount
                End If
                count = count + 1
                If WMI_Options.Duration = 1 Then
                Else
                    Threading.Thread.Sleep(500)
                End If
                Return WMIResult
            Loop
        Catch ex As ManagementException
            Dim WMIResult As Integer
            WMIResult = -1
            Return WMIResult
        Catch ex As UnauthorizedAccessException
            Dim WMIResult As Integer
            WMIResult = -2
            Return WMIResult
        Catch ex As Exception
            Dim WMIResult As Integer
            WMIResult = -3
            Return WMIResult
        End Try

    End Function
    Public Function File_Monitor(ByVal path As String, ByVal filter As String) As Integer
        Try
            Dim Directory As New DirectoryInfo(path)
            Dim File_Monitor_Result As Integer = Directory.GetFiles(filter, SearchOption.AllDirectories).Count
            Return File_Monitor_Result
        Catch ex As Exception
            Dim File_monitor_result As Integer = -1
            Return File_Monitor_Result
        End Try
    End Function

    Public Function Service_Monitor(ByVal ServiceName As String) As Integer
        Try
            Dim Service_Monitor_result As Integer
            Dim service_check As New ServiceController(ServiceName)
            Select Case service_check.Status
                Case ServiceControllerStatus.Running
                    Service_Monitor_result = 4
                Case ServiceControllerStatus.Stopped
                    Service_Monitor_result = 1
                Case ServiceControllerStatus.StopPending
                    Service_Monitor_result = 3
                Case ServiceControllerStatus.PausePending
                    Service_Monitor_result = 6
                Case ServiceControllerStatus.StartPending
                    Service_Monitor_result = 2
                Case ServiceControllerStatus.Paused
                    Service_Monitor_result = 7
                Case ServiceControllerStatus.ContinuePending
                    Service_Monitor_result = 5
            End Select
            Return Service_Monitor_result
        Catch ex As Exception
            Dim Service_Monitor_result = -1
            Return Service_Monitor_result
        End Try
    End Function

    Public Function Service_start(ByVal ServiceName() As String)
        Try
            For Each service In ServiceName
                Dim Service_check As New ServiceController(service)
                Select Case Service_check.Status
                    Case ServiceControllerStatus.Stopped
                        Service_check.Start()
                   ' Service_check.WaitForStatus(ServiceControllerStatus.Running)
                    Case ServiceControllerStatus.Paused
                        Service_check.Continue()
                        ' Service_check.WaitForStatus(ServiceControllerStatus.Running)
                    Case Else
                End Select
            Next
        Catch ex As Exception

        End Try

    End Function




End Module
