
Imports System.Xml

Module files
    Public Structure Job_status
        Dim task_name As String
        Dim task_users As String
        Dim task_pst As String
        Dim task_starttime As DateTime
        Dim task_endtime As DateTime
        Dim task_progress As Integer
        Dim task_status As String
        Dim task_mode As String
    End Structure
    Public Function Write_Status(ByVal job_status As Job_status, ByVal job_file As String) As Integer
        Try
            Dim ConfigWriter As New XmlTextWriter(job_file, System.Text.Encoding.UTF8)
            ConfigWriter.WriteStartDocument(True)
            ConfigWriter.Formatting = Formatting.Indented
            ConfigWriter.Indentation = 2
            ConfigWriter.WriteStartElement("job_status")
            CreateNodes("task_name", job_status.task_name, ConfigWriter)
            CreateNodes("task_users", job_status.task_users, ConfigWriter)
            CreateNodes("task_pst", job_status.task_pst, ConfigWriter)
            CreateNodes("task_starttime", job_status.task_starttime, ConfigWriter)
            CreateNodes("task_endtime", job_status.task_endtime, ConfigWriter)
            CreateNodes("task_progress", job_status.task_progress, ConfigWriter)
            CreateNodes("task_status", job_status.task_status, ConfigWriter)
            ConfigWriter.WriteEndElement()
            ConfigWriter.WriteEndDocument()
            ConfigWriter.Close()
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
    Public Function Read_Status(ByVal file As String, ByVal ConfigAttribute As String)
        Try
            Dim ConfigReader As New Xml.XmlDocument
            Dim ConfigReader_Result As String
            ConfigReader.Load(file)
            ConfigReader_Result = ConfigReader.DocumentElement.ChildNodes(ConfigAttribute).InnerText
            Return ConfigReader_Result
        Catch ex As Exception
        End Try
    End Function
End Module
