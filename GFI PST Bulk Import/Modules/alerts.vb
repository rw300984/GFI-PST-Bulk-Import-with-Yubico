Imports MailKit
Imports MimeKit

Module alerts
    Public Structure Alert_Treshold
        Dim cpu As DateTime
        Dim cpu_count As Integer
        Dim directory_pickup As DateTime
        Dim directory_pickup_count As Integer
        Dim directory_queue As DateTime
        Dim directory_queue_count As Integer
        Dim directory_unclassified As DateTime
        Dim directory_unclassified_count As Integer
        Dim service_0 As DateTime
        Dim service_0_count As Integer
        Dim service_1 As DateTime
        Dim service_1_count As Integer
        Dim service_2 As DateTime
        Dim service_2_count As Integer
        Dim service_3 As DateTime
        Dim service_3_count As Integer
        Dim service_4 As DateTime
        Dim service_4_count As Integer
        Dim service_5 As DateTime
        Dim service_5_count As Integer
    End Structure

    Public treshold As Alert_Treshold


    Public Function CreateAlerts(ByVal alert_type As Integer, ByVal alert_category As String, ByVal alert_subject As String, ByVal alert_text As String)
        Select Case alert_type
            Case 0
                Select Case cfg_config.monitor_alert_mode
                    Case "Alert once"
                        Select Case alert_category
                            Case "CPU"
                                If treshold.cpu_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.cpu_count = 1
                                End If
                            Case "service_0"
                                If treshold.service_0_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_0_count = 1
                                End If
                            Case "service_1"
                                If treshold.service_1_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_1_count = 1
                                End If
                            Case "service_2"
                                If treshold.service_2_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_2_count = 1
                                End If
                            Case "service_3"
                                If treshold.service_3_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_3_count = 1
                                End If
                            Case "service_4"
                                If treshold.service_4_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_4_count = 1
                                End If
                            Case "service_5"
                                If treshold.service_5_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_5_count = 1
                                End If
                            Case "Directory_pickup"
                                If treshold.directory_pickup_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_pickup_count = 1
                                End If
                            Case "Directory_queue"
                                If treshold.directory_queue_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_queue_count = 1
                                End If
                            Case "Directory_unclassified"
                                If treshold.directory_unclassified_count = 0 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_unclassified_count = 1
                                End If
                        End Select
                    Case "Alert every 5min"
                        Select Case alert_category
                            Case "CPU"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.cpu))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.cpu_count = 2
                                    treshold.cpu = DateTime.Now
                                Else
                                    If treshold.cpu_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.cpu_count = 2
                                        treshold.cpu = DateTime.Now
                                    End If
                                End If
                            Case "Directory_pickup"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_pickup))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_pickup_count = 2
                                    treshold.directory_pickup = DateTime.Now
                                Else
                                    If treshold.directory_pickup_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_pickup_count = 2
                                        treshold.directory_pickup = DateTime.Now
                                    End If
                                End If
                            Case "Directory_queue"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_queue))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_queue_count = 2
                                    treshold.directory_queue = DateTime.Now
                                Else
                                    If treshold.directory_queue_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_queue_count = 2
                                        treshold.directory_queue = DateTime.Now
                                    End If
                                End If
                            Case "Directory_unclassified"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_unclassified))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_unclassified_count = 2
                                    treshold.directory_unclassified = DateTime.Now
                                Else
                                    If treshold.directory_unclassified_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_unclassified_count = 2
                                        treshold.directory_unclassified = DateTime.Now
                                    End If
                                End If
                            Case "service_1"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_1))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_1_count = 2
                                    treshold.service_1 = DateTime.Now
                                Else
                                    If treshold.service_1_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_1_count = 2
                                        treshold.service_1 = DateTime.Now
                                    End If
                                End If
                            Case "service_2"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_2))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_2_count = 2
                                    treshold.service_2 = DateTime.Now
                                Else
                                    If treshold.service_2_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_2_count = 2
                                        treshold.service_2 = DateTime.Now
                                    End If
                                End If
                            Case "service_0"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_0))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_0_count = 2
                                    treshold.service_0 = DateTime.Now
                                Else
                                    If treshold.service_0_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_0_count = 2
                                        treshold.service_0 = DateTime.Now
                                    End If
                                End If
                            Case "service_3"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_3))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_3_count = 2
                                    treshold.service_3 = DateTime.Now
                                Else
                                    If treshold.service_3_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_3_count = 2
                                        treshold.service_3 = DateTime.Now
                                    End If
                                End If
                            Case "service_4"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_4))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_4_count = 2
                                    treshold.service_4 = DateTime.Now
                                Else
                                    If treshold.service_4_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_4_count = 2
                                        treshold.service_4 = DateTime.Now
                                    End If
                                End If
                            Case "service_5"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_5))
                                If span.Minutes = 5 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.service_5_count = 2
                                    treshold.service_5 = DateTime.Now
                                Else
                                    If treshold.service_5_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_5_count = 2
                                        treshold.service_5 = DateTime.Now
                                    End If
                                End If
                        End Select
                    Case "Alert every 15min"
                        Select Case alert_category
                            Case "CPU"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.cpu))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.cpu_count = 2
                                        treshold.cpu = DateTime.Now
                                    Else
                                        If treshold.cpu_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.cpu_count = 2
                                            treshold.cpu = DateTime.Now
                                        End If
                                    End If

                            Case "Directory_pickup"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_pickup))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_pickup_count = 2
                                        treshold.directory_pickup = DateTime.Now
                                    Else
                                        If treshold.directory_pickup_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.directory_pickup_count = 2
                                            treshold.directory_pickup = DateTime.Now
                                        End If
                                    End If

                            Case "Directory_queue"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_queue))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_queue_count = 2
                                        treshold.directory_queue = DateTime.Now
                                    Else
                                        If treshold.directory_queue_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.directory_queue_count = 2
                                            treshold.directory_queue = DateTime.Now
                                        End If
                                    End If

                            Case "Directory_unclassified"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_unclassified))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_unclassified_count = 2
                                        treshold.directory_unclassified = DateTime.Now
                                    Else
                                        If treshold.directory_unclassified_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.directory_unclassified_count = 2
                                            treshold.directory_unclassified = DateTime.Now
                                        End If
                                    End If

                            Case "service_1"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_1))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_1_count = 2
                                        treshold.service_1 = DateTime.Now
                                    Else
                                        If treshold.service_1_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_1_count = 2
                                            treshold.service_1 = DateTime.Now
                                        End If
                                    End If

                            Case "service_2"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_2))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_2_count = 2
                                        treshold.service_2 = DateTime.Now
                                    Else
                                        If treshold.service_2_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_2_count = 2
                                            treshold.service_2 = DateTime.Now
                                        End If
                                    End If

                            Case "service_0"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_0))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_0_count = 2
                                        treshold.service_0 = DateTime.Now
                                    Else
                                        If treshold.service_0_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_0_count = 2
                                            treshold.service_0 = DateTime.Now
                                        End If
                                    End If

                            Case "service_3"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_3))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_3_count = 2
                                        treshold.service_3 = DateTime.Now
                                    Else
                                        If treshold.service_3_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_3_count = 2
                                            treshold.service_3 = DateTime.Now
                                        End If
                                    End If

                            Case "service_4"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_4))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_4_count = 2
                                        treshold.service_4 = DateTime.Now
                                    Else
                                        If treshold.service_4_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_4_count = 2
                                            treshold.service_4 = DateTime.Now
                                        End If
                                    End If

                            Case "service_5"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_5))
                                    If span.Minutes = 15 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_5_count = 2
                                        treshold.service_5 = DateTime.Now
                                    Else
                                        If treshold.service_5_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_5_count = 2
                                            treshold.service_5 = DateTime.Now
                                        End If
                                    End If

                        End Select
                    Case "Alert every 30min"
                        Select Case alert_category
                            Case "CPU"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.cpu))
                                If span.Minutes = 30 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.cpu_count = 2
                                    treshold.cpu = DateTime.Now
                                Else
                                    If treshold.cpu_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.cpu_count = 2
                                        treshold.cpu = DateTime.Now
                                    End If
                                End If
                            Case "Directory_pickup"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_pickup))
                                If span.Minutes = 30 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_pickup_count = 2
                                    treshold.directory_pickup = DateTime.Now
                                Else
                                    If treshold.directory_pickup_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_pickup_count = 2
                                        treshold.directory_pickup = DateTime.Now
                                    End If
                                End If
                            Case "Directory_queue"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_queue))
                                If span.Minutes = 30 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_queue_count = 2
                                    treshold.directory_queue = DateTime.Now
                                Else
                                    If treshold.directory_queue_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_queue_count = 2
                                        treshold.directory_queue = DateTime.Now
                                    End If
                                End If
                            Case "Directory_unclassified"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.directory_unclassified))
                                If span.Minutes = 30 Then
                                    SendEmail(alert_subject, alert_text)
                                    treshold.directory_unclassified_count = 2
                                    treshold.directory_unclassified = DateTime.Now
                                Else
                                    If treshold.directory_unclassified_count < 2 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.directory_unclassified_count = 2
                                        treshold.directory_unclassified = DateTime.Now
                                    End If
                                End If
                            Case "service_1"
                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_1))
                                    If span.Minutes = 30 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_1_count = 2
                                        treshold.service_1 = DateTime.Now
                                    Else
                                        If treshold.service_1_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_1_count = 2
                                            treshold.service_1 = DateTime.Now
                                        End If
                                    End If

                            Case "service_2"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_2))
                                    If span.Minutes = 30 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_2_count = 2
                                        treshold.service_2 = DateTime.Now
                                    Else
                                        If treshold.service_2_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_2_count = 2
                                            treshold.service_2 = DateTime.Now
                                        End If
                                    End If

                            Case "service_0"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_0))
                                    If span.Minutes = 30 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_0_count = 2
                                        treshold.service_0 = DateTime.Now
                                    Else
                                        If treshold.service_0_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_0_count = 2
                                            treshold.service_0 = DateTime.Now
                                        End If
                                    End If

                            Case "service_3"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_3))
                                    If span.Minutes = 30 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_3_count = 2
                                        treshold.service_3 = DateTime.Now
                                    Else
                                        If treshold.service_3_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_3_count = 2
                                            treshold.service_3 = DateTime.Now
                                        End If
                                    End If

                            Case "service_4"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_4))
                                    If span.Minutes = 30 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_4_count = 2
                                        treshold.service_4 = DateTime.Now
                                    Else
                                        If treshold.service_4_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_4_count = 2
                                            treshold.service_4 = DateTime.Now
                                        End If
                                    End If

                            Case "service_5"

                                Dim span As TimeSpan = DateTime.Now.Subtract(CDate(treshold.service_5))
                                    If span.Minutes = 30 Then
                                        SendEmail(alert_subject, alert_text)
                                        treshold.service_5_count = 2
                                        treshold.service_5 = DateTime.Now
                                    Else
                                        If treshold.service_5_count < 2 Then
                                            SendEmail(alert_subject, alert_text)
                                            treshold.service_5_count = 2
                                            treshold.service_5 = DateTime.Now
                                        End If
                                    End If

                        End Select
                End Select
            Case 1
                Select Case alert_category
                    Case "Task"
                        SendEmail(alert_subject, alert_text)
                End Select

        End Select
    End Function
    Public Function SendEmail(ByVal Subject As String, ByVal Body As String) As String
        Try
            Dim message As New MimeMessage
            message.From.Add(New MailboxAddress(cfg_config.general_email_from))
            message.To.Add(New MailboxAddress(cfg_config.general_email_to))
            message.Subject = Subject
            Dim sText As New TextPart("plain")
            sText.SetText("UTF-8", Body)
            message.Body = sText

            Using smtp = New MailKit.Net.Smtp.SmtpClient
                ' smtp.LocalDomain = "rw300984.de"
                If cfg_config.general_email_server.Contains(":") = True Then
                    Dim server_port() As String = cfg_config.general_email_server.Split(":")
                    smtp.Connect(server_port(0), CInt(server_port(1)), Security.SecureSocketOptions.Auto)
                Else
                    smtp.Connect(cfg_config.general_email_server, 25, Security.SecureSocketOptions.Auto)
                End If

                If cfg_config.general_email_authentication = True Then
                    smtp.Authenticate(cfg_config.general_email_user, cfg_config.general_email_password)
                End If

                smtp.Send(message)
                smtp.Disconnect(True)
                Return "Successfully sent"
            End Using
        Catch ex As Exception
            Return "Not successful: " & ex.Message
            '  MessageBox.Show(ex.Message)
        End Try
    End Function
End Module
