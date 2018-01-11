Imports System.Xml

Module tasks
    Public task As task_config

    Public Structure task_config
        Dim task_name As String
        Dim task_description As String
        Dim task_category As String
        Dim task_schedule As String
        Dim task_directory_ldap_path As String
        Dim task_directory_use_default As Boolean
        Dim task_directory_path As String
        Dim task_directory_include_subdirectories As Boolean
        Dim task_directory_recursive_search As String
        Dim task_file_use_default As Boolean
        Dim task_file_path As String
        Dim task_file_include_subdirectories As Boolean
    End Structure
    Public Function Write_task(ByVal task_attribute As task_config, ByVal config_file As String) As Integer
        Try
            Dim TaskWriter As New XmlTextWriter(config_file, System.Text.Encoding.UTF8)
            TaskWriter.WriteStartDocument(True)
            TaskWriter.Formatting = Formatting.Indented
            TaskWriter.Indentation = 2
            TaskWriter.WriteStartElement("Task")
            CreateNodes("name", task_attribute.task_name, TaskWriter)
            CreateNodes("description", task_attribute.task_description, TaskWriter)
            CreateNodes("category", task_attribute.task_category, TaskWriter)
            CreateNodes("schedule", task_attribute.task_schedule, TaskWriter)
            CreateNodes("directory_mode_ldap_path", task_attribute.task_directory_ldap_path, TaskWriter)
            CreateNodes("directory_mode_use_default", task_attribute.task_directory_use_default, TaskWriter)
            CreateNodes("directory_mode_path", task_attribute.task_directory_path, TaskWriter)
            CreateNodes("directory_mode_incl_sub", task_attribute.task_directory_include_subdirectories, TaskWriter)
            CreateNodes("directory_mode_recursive", task_attribute.task_directory_recursive_search, TaskWriter)
            CreateNodes("file_mode_use_default", task_attribute.task_file_use_default, TaskWriter)
            CreateNodes("file_mode_path", task_attribute.task_file_path, TaskWriter)
            CreateNodes("file_mode_incl_sub", task_attribute.task_file_include_subdirectories, TaskWriter)
            TaskWriter.WriteEndElement()
            TaskWriter.WriteEndDocument()
            TaskWriter.Close()
            Return 1
        Catch ex As Exception
            Return 0
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
    Public Function Read_task(ByVal file As String, ByVal ConfigAttribute As String)
        Try
            Dim ConfigReader As New Xml.XmlDocument
            Dim ConfigReader_Result As String
            ConfigReader.Load(file)
            ConfigReader_Result = ConfigReader.DocumentElement.ChildNodes(ConfigAttribute).InnerText
            Return ConfigReader_Result
        Catch ex As Exception
        End Try
    End Function
    Public Function GetTask(ByVal file As String)
        Try
            task.task_name = Read_task(file, "0")
            task.task_description = Read_task(file, "1")
            task.task_category = Read_task(file, "2")
            task.task_schedule = Read_task(file, "3")
            task.task_directory_ldap_path = Read_task(file, "4")
            task.task_directory_use_default = Read_task(file, "5")
            task.task_directory_path = Read_task(file, "6")
            task.task_directory_include_subdirectories = Read_task(file, "7")
            task.task_directory_recursive_search = Read_task(file, "8")
            task.task_file_use_default = Read_task(file, "9")
            task.task_file_path = Read_task(file, "10")
            task.task_file_include_subdirectories = Read_task(file, "11")
        Catch ex As Exception

        End Try

    End Function

End Module
