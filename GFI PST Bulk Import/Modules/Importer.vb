Imports System.IO
Imports System.Text
Module Importer
    Public ImportReportProcess As String = " "
    Public ImportPressKey As Integer

    Public Function GetFiles(ByVal user As String, ByVal directory As String, ByVal SubDirectory As Integer, Optional ByVal emaildomain As String = "", Optional ByVal mode As Integer = 0) As String()
        Try
            Dim variable As String = directory.Substring(directory.IndexOf("%"), directory.LastIndexOf("%") - directory.IndexOf("%") + 1)
            Dim path As String = directory.Replace(variable, user)
            Dim Folder As New IO.DirectoryInfo(path)
            Dim Files() As IO.FileInfo
            If SubDirectory = 1 Then
                Files = Folder.GetFiles("*.pst", IO.SearchOption.AllDirectories)
            Else
                Files = Folder.GetFiles("*.pst", IO.SearchOption.TopDirectoryOnly)
            End If
            Dim user_filepath(0) As String
            If Files IsNot Nothing Then
                Dim count As Integer = 0
                For Each file In Files
                    ReDim Preserve user_filepath(count)
                    If file.FullName.Contains(",") Then
                    Else
                        If mode = 0 Then
                            If emaildomain = "" Then
                                user_filepath(count) = file.FullName & "," & user
                            Else
                                user_filepath(count) = file.FullName & "," & user & "@" & emaildomain
                            End If
                        Else
                            If emaildomain = "" Then
                                user_filepath(count) = file.Name & "," & user
                            Else
                                user_filepath(count) = file.Name & "," & user & "@" & emaildomain
                            End If

                        End If

                    End If

                    count = count + 1
                Next
                Return user_filepath
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function GetFolders(ByVal Rootdirectory As String) As String()
        Try
            Dim fi As New IO.DirectoryInfo(Rootdirectory)

            Dim path() As String = {}

            For Each subfolder As IO.DirectoryInfo In fi.GetDirectories()

                Array.Resize(path, path.Length + 1)
                path(path.Length - 1) = subfolder.FullName

                For Each s As String In GetFolders(subfolder.FullName)
                    Array.Resize(path, path.Length + 1)
                    path(path.Length - 1) = s
                Next
            Next
            Return path
        Catch ex As Exception

        End Try
    End Function
    Public Function GetUser(ByVal searchdirectory As String) As String()
        Try
            Dim rootdirectory As String = searchdirectory
            rootdirectory = rootdirectory.Substring(0, rootdirectory.IndexOf("%") - 1)
            Dim fi As New IO.DirectoryInfo(rootdirectory)
            Dim users() As String = {}
            For Each subfolder As IO.DirectoryInfo In fi.GetDirectories
                Array.Resize(users, users.Length + 1)
                users(users.Length - 1) = subfolder.FullName.Substring(subfolder.FullName.LastIndexOf("\") + 1)
            Next
            Return users
        Catch ex As Exception

        End Try

    End Function
    Public Function CopyPST(path As String)
        Try
            Dim path_split() As String = path.Split(",")
            Dim dest_file As String = path_split(0).Substring(path_split(0).LastIndexOf("\") + 1)
            If cfg_config.path_bulkimport_temp.LastIndexOf("\") = cfg_config.path_bulkimport_temp.Length - 1 Then
            Else
                cfg_config.path_bulkimport_temp = cfg_config.path_bulkimport_temp.Replace(cfg_config.path_bulkimport_temp, cfg_config.path_bulkimport_temp & "\")
            End If
            If Directory.Exists(cfg_config.path_bulkimport_temp & path_split(1)) Then
            Else
                Directory.CreateDirectory(cfg_config.path_bulkimport_temp & path_split(1))
            End If
            If File.Exists(cfg_config.path_bulkimport_temp & path_split(1) & "\" & dest_file) Then
            Else
                File.Copy(path_split(0), cfg_config.path_bulkimport_temp & path_split(1) & "\" & DateTime.Now.ToString("HHmmssddMMyy_") & dest_file)
            End If
            Return cfg_config.path_bulkimport_temp & path_split(1) & "\" & dest_file
        Catch ex As Exception

        End Try

    End Function
    Public Function SaveAsCSV(ByVal jobname As String, ByVal text As String)
        Try
            Dim import_csv As IO.FileStream
            Dim byteData() As Byte
            byteData = Encoding.ASCII.GetBytes(text)
            import_csv = New FileStream(cfg_config.path_bulkimport_install & "\tasks\jobs\" & jobname & ".job", FileMode.Append)
            import_csv.Write(byteData, 0, byteData.Length)
            import_csv.Close()
        Catch ex As Exception

        End Try
    End Function
End Module
