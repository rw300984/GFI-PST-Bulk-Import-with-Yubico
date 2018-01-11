Imports System.Xml

Module config
    Public cfg_config As configuration
    Public Structure configuration
        Dim monitor_cpu As String
        Dim monitor_memory As String
        Dim monitor_disk As String
        Dim monitor_network As String
        Dim monitor_service1 As String
        Dim monitor_service2 As String
        Dim monitor_service3 As String
        Dim monitor_service4 As String
        Dim monitor_service5 As String
        Dim monitor_service6 As String
        Dim monitor_pickup As String
        Dim monitor_queue As String
        Dim monitor_unclassified As String
        Dim monitor_alert_service As Integer
        Dim monitor_alert_directory As Integer
        Dim monitor_alert_task As Integer
        Dim monitor_alert_cpu As Integer
        Dim monitor_alert_mode As String
        Dim general_email_server As String
        Dim general_email_from As String
        Dim general_email_to As String
        Dim general_email_authentication As Boolean
        Dim general_email_user As String
        Dim general_email_password As String
        Dim general_language As String
        Dim path_archiver_install As String
        Dim path_archiver_pickup As String
        Dim path_archiver_queue As String
        Dim path_archiver_unclassified As String
        Dim path_bulkimport_install As String
        Dim path_bulkimport_logs As String
        Dim path_bulkimport_config As String
        Dim path_bulkimport_temp As String
        Dim path_pstsource_default As String
        Dim owner_owner_mode As Integer
        Dim owner_directory_mode_server As String
        Dim owner_directory_mode_port As String
        Dim owner_directory_mode_user As String
        Dim owner_directory_mode_password As String
        Dim owner_directory_mode_search_mode As Integer
        Dim owner_directory_mode_search_field As String
        Dim owner_path_mode_user_variable As String
        Dim tasks_import_mode As Integer
        Dim tasks_http_mode_url As String
        Dim tasks_http_mode_protocol As Integer
        Dim tasks_http_mode_user As String
        Dim tasks_http_mode_password As String
        Dim general_office_bit As String
        Dim auth_2fa As Boolean
        Dim auth_2fa_client As String
        Dim auth_2fa_secret As String
    End Structure
    Public Function Write_Config(ByVal config_value As configuration, ByVal config_file As String) As Integer
        Try
            Dim ConfigWriter As New XmlTextWriter(config_file, System.Text.Encoding.UTF8)
            ConfigWriter.WriteStartDocument(True)
            ConfigWriter.Formatting = Formatting.Indented
            ConfigWriter.Indentation = 2
            ConfigWriter.WriteStartElement("Configuration")
            CreateNodes("general_email_authentication", config_value.general_email_authentication, ConfigWriter)
            CreateNodes("general_email_from", config_value.general_email_from, ConfigWriter)
            CreateNodes("general_email_to", config_value.general_email_to, ConfigWriter)
            CreateNodes("general_email_username", config_value.general_email_user, ConfigWriter)
            CreateNodes("general_email_password", config_value.general_email_password, ConfigWriter)
            CreateNodes("general_email_server", config_value.general_email_server, ConfigWriter)
            CreateNodes("general_language", config_value.general_language, ConfigWriter)
            CreateNodes("monitor_cpu", config_value.monitor_cpu, ConfigWriter)
            CreateNodes("monitor_memory", config_value.monitor_memory, ConfigWriter)
            CreateNodes("monitor_disk", config_value.monitor_disk, ConfigWriter)
            CreateNodes("monitor_network", config_value.monitor_network, ConfigWriter)
            CreateNodes("monitor_pickup", config_value.monitor_pickup, ConfigWriter)
            CreateNodes("monitor_queue", config_value.monitor_queue, ConfigWriter)
            CreateNodes("monitor_unclassified", config_value.monitor_unclassified, ConfigWriter)
            CreateNodes("monitor_service1", config_value.monitor_service1, ConfigWriter)
            CreateNodes("monitor_Service2", config_value.monitor_service2, ConfigWriter)
            CreateNodes("monitor_service3", config_value.monitor_service3, ConfigWriter)
            CreateNodes("monitor_service4", config_value.monitor_service4, ConfigWriter)
            CreateNodes("monitor_service5", config_value.monitor_service5, ConfigWriter)
            CreateNodes("monitor_service6", config_value.monitor_service6, ConfigWriter)
            CreateNodes("owner_owner_mode", config_value.owner_owner_mode, ConfigWriter)
            CreateNodes("owner_directory_mode_server", config_value.owner_directory_mode_server, ConfigWriter)
            CreateNodes("owner_directory_mode_port", config_value.owner_directory_mode_port, ConfigWriter)
            CreateNodes("owner_directory_mode_user", config_value.owner_directory_mode_user, ConfigWriter)
            CreateNodes("owner_directory_mode_password", config_value.owner_directory_mode_password, ConfigWriter)
            CreateNodes("owner_directory_mode_search_field", config_value.owner_directory_mode_search_field, ConfigWriter)
            CreateNodes("owner_directory_mode_search_mode", config_value.owner_directory_mode_search_mode, ConfigWriter)
            CreateNodes("owner_path_mode_user_variable", config_value.owner_path_mode_user_variable, ConfigWriter)
            CreateNodes("path_archiver_install", config_value.path_archiver_install, ConfigWriter)
            CreateNodes("path_archiver_pickup", config_value.path_archiver_pickup, ConfigWriter)
            CreateNodes("path_archiver_queue", config_value.path_archiver_queue, ConfigWriter)
            CreateNodes("path_archiver_unclassified", config_value.path_archiver_unclassified, ConfigWriter)
            CreateNodes("path_bulkimport_config", config_value.path_bulkimport_config, ConfigWriter)
            CreateNodes("path_bulkimport_install", config_value.path_bulkimport_install, ConfigWriter)
            CreateNodes("path_bulkimport_logs", config_value.path_bulkimport_logs, ConfigWriter)
            CreateNodes("path_bulkimport_temp", config_value.path_bulkimport_temp, ConfigWriter)
            CreateNodes("path_pstsource_default", config_value.path_pstsource_default, ConfigWriter)
            CreateNodes("tasks_import_mode", config_value.tasks_import_mode, ConfigWriter)
            CreateNodes("tasks_http_mode_url", config_value.tasks_http_mode_url, ConfigWriter)
            CreateNodes("tasks_http_mode_protocol", config_value.tasks_http_mode_protocol, ConfigWriter)
            CreateNodes("tasks_http_mode_user", config_value.tasks_http_mode_user, ConfigWriter)
            CreateNodes("tasks_http_mode_password", config_value.tasks_http_mode_password, ConfigWriter)

            CreateNodes("monitor_alert_cpu", config_value.monitor_alert_cpu, ConfigWriter)
            CreateNodes("monitor_alert_directory", config_value.monitor_alert_directory, ConfigWriter)
            CreateNodes("monitor_alert_service", config_value.monitor_alert_service, ConfigWriter)
            CreateNodes("monitor_alert_task", config_value.monitor_alert_task, ConfigWriter)
            CreateNodes("monitor_alert_mode", config_value.monitor_alert_mode, ConfigWriter)

            CreateNodes("general_office_bit", config_value.general_office_bit, ConfigWriter)
            CreateNodes("auth_2fa", config_value.auth_2fa, ConfigWriter)
            CreateNodes("auth_2fa_clientid", config_value.auth_2fa_client, ConfigWriter)
            CreateNodes("auth_2fa_secret", config_value.auth_2fa_secret, ConfigWriter)
            ConfigWriter.WriteEndElement()
            ConfigWriter.WriteEndDocument()
            ConfigWriter.Close()
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Read_Config(ByVal file As String, ByVal ConfigAttribute As String)
        Try
            Dim ConfigReader As New Xml.XmlDocument
            Dim ConfigReader_Result As String
            ConfigReader.Load(file)
            ConfigReader_Result = ConfigReader.DocumentElement.ChildNodes(ConfigAttribute).InnerText
            Return ConfigReader_Result
        Catch ex As Exception
        End Try
    End Function
    Private Sub CreateNodes(ByVal Element As String, ByVal Value As String, ByVal ConfigWriter As XmlTextWriter)
        Try
            ConfigWriter.WriteStartElement(Element)
            ConfigWriter.WriteString(Value)
            ConfigWriter.WriteEndElement()
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetConfig(ByVal config As String)
        Try
            cfg_config.general_email_authentication = Read_Config(config, "0")
            cfg_config.general_email_from = Read_Config(config, "1")
            cfg_config.general_email_to = Read_Config(config, "2")
            cfg_config.general_email_user = Read_Config(config, "3")
            cfg_config.general_email_password = Read_Config(config, "4")
            cfg_config.general_email_server = Read_Config(config, "5")
            cfg_config.general_language = Read_Config(config, "6")
            cfg_config.monitor_cpu = Read_Config(config, "7")
            cfg_config.monitor_memory = Read_Config(config, "8")
            cfg_config.monitor_disk = Read_Config(config, "9")
            cfg_config.monitor_network = Read_Config(config, "10")
            cfg_config.monitor_pickup = Read_Config(config, "11")
            cfg_config.monitor_queue = Read_Config(config, "12")
            cfg_config.monitor_unclassified = Read_Config(config, "13")
            cfg_config.monitor_service1 = Read_Config(config, "14")
            cfg_config.monitor_service2 = Read_Config(config, "15")
            cfg_config.monitor_service3 = Read_Config(config, "16")
            cfg_config.monitor_service4 = Read_Config(config, "17")
            cfg_config.monitor_service5 = Read_Config(config, "18")
            cfg_config.monitor_service6 = Read_Config(config, "19")
            cfg_config.owner_owner_mode = Read_Config(config, "20")
            cfg_config.owner_directory_mode_server = Read_Config(config, "21")
            cfg_config.owner_directory_mode_port = Read_Config(config, "22")
            cfg_config.owner_directory_mode_user = Read_Config(config, "23")
            cfg_config.owner_directory_mode_password = Read_Config(config, "24")
            cfg_config.owner_directory_mode_search_field = Read_Config(config, "25")
            cfg_config.owner_directory_mode_search_mode = Read_Config(config, "26")
            cfg_config.owner_path_mode_user_variable = Read_Config(config, "27")
            cfg_config.path_archiver_install = Read_Config(config, "28")
            cfg_config.path_archiver_pickup = Read_Config(config, "29")
            cfg_config.path_archiver_queue = Read_Config(config, "30")
            cfg_config.path_archiver_unclassified = Read_Config(config, "31")
            cfg_config.path_bulkimport_config = Read_Config(config, "32")
            cfg_config.path_bulkimport_install = Read_Config(config, "33")
            cfg_config.path_bulkimport_logs = Read_Config(config, "34")
            cfg_config.path_bulkimport_temp = Read_Config(config, "35")
            cfg_config.path_pstsource_default = Read_Config(config, "36")
            cfg_config.tasks_import_mode = Read_Config(config, "37")
            cfg_config.tasks_http_mode_url = Read_Config(config, "38")
            cfg_config.tasks_http_mode_protocol = Read_Config(config, "39")
            cfg_config.tasks_http_mode_user = Read_Config(config, "40")
            cfg_config.tasks_http_mode_password = Read_Config(config, "41")
            cfg_config.monitor_alert_cpu = Read_Config(config, "42")
            cfg_config.monitor_alert_directory = Read_Config(config, "43")
            cfg_config.monitor_alert_service = Read_Config(config, "44")
            cfg_config.monitor_alert_task = Read_Config(config, "45")
            cfg_config.monitor_alert_mode = Read_Config(config, "46")
            cfg_config.general_office_bit = Read_Config(config, "47")
            cfg_config.auth_2fa = Read_Config(config, "48")
            cfg_config.auth_2fa_client = Read_Config(config, "49")
            cfg_config.auth_2fa_secret = Read_Config(config, "50")
        Catch ex As Exception

        End Try

    End Function
End Module
