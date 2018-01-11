Imports System.IO

Public Class frm_tasks_schedule
    Dim frm_tasks_schedule_file As New frm_tasks_schedule_file
    Dim frm_tasks_schedule_directory As New frm_tasks_schedule_directory
    Dim frm_tasks_schedule_daily As New frm_tasks_schedule_daily
    Dim frm_tasks_schedule_weekly As New frm_tasks_schedule_weekly
    Dim frm_tasks_schedule_monthly As New frm_tasks_schedule_monthly
    Dim frm_tasks_schedule_yearly As New frm_tasks_schedule_yearly
    Dim tv_selected_node As String
    Dim tv_selected_parent As String


    Private Sub AddTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTaskToolStripMenuItem.Click

        Select Case tv_tasks_schedule.SelectedNode.Text
            Case "Scheduled tasks"
            Case "Daily"
                txt_tasks_schedule_name.Text = "New Task"
                cbx_tasks_schedule_category.Text = "Daily"
                AddNode("Daily", "New Task")
                ShowOptionsBasedOnMode()
                WriteTask()
                tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(cbx_tasks_schedule_category.Text).Nodes(txt_tasks_schedule_name.Text)
                tv_tasks_schedule.Select()
                WriteTask()
            Case "Weekly"
                txt_tasks_schedule_name.Text = "New Task"
                cbx_tasks_schedule_category.Text = "Weekly"
                AddNode("Weekly", "New Task")
                ShowOptionsBasedOnMode()
                WriteTask()
                tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(cbx_tasks_schedule_category.Text).Nodes(txt_tasks_schedule_name.Text)
                tv_tasks_schedule.Select()
                WriteTask()
            Case "Monthly"
                txt_tasks_schedule_name.Text = "New Task"
                cbx_tasks_schedule_category.Text = "Monthly"
                AddNode("Monthly", "New Task")
                ShowOptionsBasedOnMode()
                WriteTask()
                tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(cbx_tasks_schedule_category.Text).Nodes(txt_tasks_schedule_name.Text)
                tv_tasks_schedule.Select()

                WriteTask()
            Case "Yearly"
                txt_tasks_schedule_name.Text = "New Task"
                cbx_tasks_schedule_category.Text = "Yearly"
                AddNode("Yearly", "New Task")
                ShowOptionsBasedOnMode()
                WriteTask()
                tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(cbx_tasks_schedule_category.Text).Nodes(txt_tasks_schedule_name.Text)
                tv_tasks_schedule.Select()
                WriteTask()
        End Select
    End Sub
    Private Sub ContextMenuStrip1_Opened(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Opened
        Select Case tv_tasks_schedule.SelectedNode.Text
            Case "Scheduled Tasks"
                AddTaskToolStripMenuItem.Enabled = False
                DeleteTaskToolStripMenuItem.Enabled = False

                RunTaskToolStripMenuItem.Enabled = True
                RunTaskToolStripMenuItem.Text = "Run all tasks"

            Case "Daily"
                AddTaskToolStripMenuItem.Enabled = True
                DeleteTaskToolStripMenuItem.Enabled = False

                RunTaskToolStripMenuItem.Enabled = True
                RunTaskToolStripMenuItem.Text = "Run all tasks"

            Case "Weekly"
                AddTaskToolStripMenuItem.Enabled = True
                DeleteTaskToolStripMenuItem.Enabled = False

                RunTaskToolStripMenuItem.Enabled = True
                RunTaskToolStripMenuItem.Text = "Run all tasks"

            Case "Monthly"
                AddTaskToolStripMenuItem.Enabled = True
                DeleteTaskToolStripMenuItem.Enabled = False

                RunTaskToolStripMenuItem.Enabled = True
                RunTaskToolStripMenuItem.Text = "Run all tasks"

            Case "Yearly"
                AddTaskToolStripMenuItem.Enabled = True
                DeleteTaskToolStripMenuItem.Enabled = False

                RunTaskToolStripMenuItem.Enabled = True
                RunTaskToolStripMenuItem.Text = "Run all tasks"
            Case Else
                AddTaskToolStripMenuItem.Enabled = False
                DeleteTaskToolStripMenuItem.Enabled = True

                RunTaskToolStripMenuItem.Enabled = True
                RunTaskToolStripMenuItem.Text = "Run task"
        End Select


    End Sub
    Private Sub DeleteTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteTaskToolStripMenuItem.Click

        System.IO.File.Delete(cfg_config.path_bulkimport_install & "\tasks\scheduled\" & task.task_category & "\" & task.task_name & ".xml")
        tv_tasks_schedule.SelectedNode.Remove()
    End Sub
    Private Sub EditTaskToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ShowOptionsBasedOnMode()
    End Sub
    Private Sub frm_tasks_schedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadforms()
        LoadNodes()
        'Panel3.Width = 284

        btn_tasks_schedule_save.Text = "Create task"
        cbx_tasks_schedule_category.Text = "Daily"
        ShowOptionsBasedOnMode()

    End Sub
    Private Sub tv_tasks_schedule_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv_tasks_schedule.AfterSelect
        If tv_tasks_schedule.SelectedNode.Text = "Scheduled Tasks" Then
        Else
            tv_selected_parent = tv_tasks_schedule.SelectedNode.Parent.Text
            tv_selected_node = tv_tasks_schedule.SelectedNode.Text
        End If

        Select Case tv_tasks_schedule.SelectedNode.Text
            Case "Scheduled Tasks"
                EmptyFields()
                cbx_tasks_schedule_category.Enabled = True
                btn_tasks_schedule_save.Text = "Create task"
                CheckNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
                ShowOptionsBasedOnMode()
            Case "Daily"
                EmptyFields()
                cbx_tasks_schedule_category.Enabled = False
                cbx_tasks_schedule_category.Text = "Daily"
                btn_tasks_schedule_save.Text = "Create task"
                CheckNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
                ShowOptionsBasedOnMode()
            Case "Weekly"
                EmptyFields()
                cbx_tasks_schedule_category.Enabled = False
                cbx_tasks_schedule_category.Text = "Weekly"
                btn_tasks_schedule_save.Text = "Create task"
                CheckNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
                ShowOptionsBasedOnMode()
            Case "Monthly"
                EmptyFields()
                cbx_tasks_schedule_category.Enabled = False
                cbx_tasks_schedule_category.Text = "Monthly"
                btn_tasks_schedule_save.Text = "Create task"
                CheckNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
                ShowOptionsBasedOnMode()
            Case "Yearly"
                EmptyFields()
                cbx_tasks_schedule_category.Enabled = False
                cbx_tasks_schedule_category.Text = "Yearly"
                btn_tasks_schedule_save.Text = "Create task"
                CheckNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
                ShowOptionsBasedOnMode()
            Case Else
                cbx_tasks_schedule_category.Enabled = False
                btn_tasks_schedule_save.Text = "Edit task"
                btn_tasks_schedule_save.Enabled = True
                txt_tasks_schedule_name.BackColor = Color.LightGray
                ShowOptionsBasedOnMode()
                ReadTask()
        End Select
    End Sub
    Public Function loadforms()
        frm_tasks_schedule_directory.TopLevel = False
        frm_tasks_schedule_directory.WindowState = FormWindowState.Maximized
        frm_tasks_schedule_directory.FormBorderStyle = FormBorderStyle.None
        ' frm_tasks_schedule_directory.Anchor = AnchorStyles.Bottom And AnchorStyles.Left And AnchorStyles.Right And AnchorStyles.Top

        frm_tasks_schedule_file.TopLevel = False
        frm_tasks_schedule_file.WindowState = FormWindowState.Maximized
        frm_tasks_schedule_file.FormBorderStyle = FormBorderStyle.None
        'frm_tasks_schedule_file.Anchor = AnchorStyles.Bottom And AnchorStyles.Left And AnchorStyles.Right And AnchorStyles.Top

        frm_tasks_schedule_daily.TopLevel = False
        frm_tasks_schedule_daily.WindowState = FormWindowState.Maximized
        frm_tasks_schedule_daily.FormBorderStyle = FormBorderStyle.None

        frm_tasks_schedule_weekly.TopLevel = False
        frm_tasks_schedule_weekly.WindowState = FormWindowState.Maximized
        frm_tasks_schedule_weekly.FormBorderStyle = FormBorderStyle.None

        frm_tasks_schedule_monthly.TopLevel = False
        frm_tasks_schedule_monthly.WindowState = FormWindowState.Maximized
        frm_tasks_schedule_monthly.FormBorderStyle = FormBorderStyle.None

        frm_tasks_schedule_yearly.TopLevel = False
        frm_tasks_schedule_yearly.WindowState = FormWindowState.Maximized
        frm_tasks_schedule_yearly.FormBorderStyle = FormBorderStyle.None

        frm_tasks_schedule_directory.Visible = False
        frm_tasks_schedule_file.Visible = False
        frm_tasks_schedule_daily.Visible = False
        frm_tasks_schedule_weekly.Visible = False
        frm_tasks_schedule_monthly.Visible = False
        frm_tasks_schedule_yearly.Visible = False

        GroupBox2.Controls.Add(frm_tasks_schedule_daily)
        GroupBox2.Controls.Add(frm_tasks_schedule_weekly)
        GroupBox2.Controls.Add(frm_tasks_schedule_monthly)
        GroupBox2.Controls.Add(frm_tasks_schedule_yearly)

        Panel3.Controls.Add(frm_tasks_schedule_file)
        Panel3.Controls.Add(frm_tasks_schedule_directory)
    End Function
    Private Sub btn_tasks_schedule_save_Click(sender As Object, e As EventArgs) Handles btn_tasks_schedule_save.Click
        If btn_tasks_schedule_save.Text = "Create task" Then
            AddNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
            ShowOptionsBasedOnMode()
            WriteTask()
            tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(cbx_tasks_schedule_category.Text).Nodes(txt_tasks_schedule_name.Text)
            tv_tasks_schedule.Select()
        Else
            Select Case EditNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
                Case 0
                    tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(tv_selected_parent).Nodes(tv_selected_node)
                    tv_tasks_schedule.Select()
                    ShowOptionsBasedOnMode()
                    txt_tasks_schedule_name.Text = tv_selected_node
                Case 1
                    'tv_tasks_schedule.Nodes(0).Nodes(tv_selected_parent).Nodes(tv_selected_node).Remove()

                    System.IO.File.Delete(cfg_config.path_bulkimport_install & "\tasks\scheduled\" & tv_selected_parent & "\" & tv_selected_node & ".xml")
                    tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(cbx_tasks_schedule_category.Text).Nodes(txt_tasks_schedule_name.Text)
                    tv_tasks_schedule.Select()
                    ShowOptionsBasedOnMode()
                    WriteTask()
                    tv_selected_node = txt_tasks_schedule_name.Text
                Case 2
                    tv_tasks_schedule.SelectedNode = tv_tasks_schedule.Nodes(0).Nodes(tv_selected_parent).Nodes(tv_selected_node)
                    tv_tasks_schedule.Select()
                    ShowOptionsBasedOnMode()
                    WriteTask()
                    tv_selected_node = txt_tasks_schedule_name.Text
            End Select
        End If
    End Sub
    Public Function AddNode(ByVal category As String, ByVal text As String)
        Select Case category
            Case "Daily"
                tv_tasks_schedule.Nodes(0).Nodes(0).Nodes.Add(text, text)
            Case "Weekly"
                tv_tasks_schedule.Nodes(0).Nodes(1).Nodes.Add(text, text)
            Case "Monthly"
                tv_tasks_schedule.Nodes(0).Nodes(2).Nodes.Add(text, text)
            Case "Yearly"
                tv_tasks_schedule.Nodes(0).Nodes(3).Nodes.Add(text, text)
        End Select
    End Function
    Public Function EditNode(ByVal catgory As String, ByVal text As String)
        Dim result As Integer
        If tv_selected_node = text Then
            result = 2
        Else
            If tv_tasks_schedule.Nodes(0).Nodes(tv_selected_parent).Nodes.IndexOfKey(text) >= 0 Then
                result = 0
            Else
                tv_tasks_schedule.Nodes(0).Nodes(tv_selected_parent).Nodes(tv_selected_node).Text = task.task_name
                tv_tasks_schedule.Nodes(0).Nodes(tv_selected_parent).Nodes(tv_selected_node).Name = task.task_name
                result = 1
            End If
        End If
        Return result

    End Function
    Public Function CheckNode(ByVal category As String, ByVal text As String)
        Select Case category
            Case "Daily"
                If tv_tasks_schedule.Nodes(0).Nodes(0).Nodes.IndexOfKey(text) >= 0 Then
                    btn_tasks_schedule_save.Enabled = False
                    txt_tasks_schedule_name.BackColor = Color.LightCoral
                Else
                    btn_tasks_schedule_save.Enabled = True
                    txt_tasks_schedule_name.BackColor = Color.LightGray
                End If
            Case "Weekly"
                If tv_tasks_schedule.Nodes(0).Nodes(1).Nodes.IndexOfKey(text) >= 0 Then
                    btn_tasks_schedule_save.Enabled = False
                    txt_tasks_schedule_name.BackColor = Color.LightCoral
                Else
                    btn_tasks_schedule_save.Enabled = True
                    txt_tasks_schedule_name.BackColor = Color.LightGray
                End If
            Case "Monthly"
                If tv_tasks_schedule.Nodes(0).Nodes(2).Nodes.IndexOfKey(text) >= 0 Then
                    btn_tasks_schedule_save.Enabled = False
                    txt_tasks_schedule_name.BackColor = Color.LightCoral
                Else
                    btn_tasks_schedule_save.Enabled = True
                    txt_tasks_schedule_name.BackColor = Color.LightGray
                End If
            Case "Yearly"
                If tv_tasks_schedule.Nodes(0).Nodes(3).Nodes.IndexOfKey(text) >= 0 Then
                    btn_tasks_schedule_save.Enabled = False
                    txt_tasks_schedule_name.BackColor = Color.LightCoral
                Else
                    btn_tasks_schedule_save.Enabled = True
                    txt_tasks_schedule_name.BackColor = Color.LightGray
                End If
        End Select
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_tasks_schedule_name.TextChanged
        task.task_name = txt_tasks_schedule_name.Text
        If btn_tasks_schedule_save.Text = "Edit task" Then

        Else
            CheckNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
        End If
    End Sub
    Private Sub cbx_tasks_schedule_category_TextChanged(sender As Object, e As EventArgs) Handles cbx_tasks_schedule_category.TextChanged
        task.task_category = cbx_tasks_schedule_category.Text
        If btn_tasks_schedule_save.Text = "Edit task" Then
            CheckScheduleOptions()
        Else
            CheckScheduleOptions()
            CheckNode(cbx_tasks_schedule_category.Text, txt_tasks_schedule_name.Text)
        End If
    End Sub
    Public Function ShowOptionsBasedOnMode()
        If cfg_config.owner_owner_mode = 0 Then
            frm_tasks_schedule_directory.Visible = True
            frm_tasks_schedule_file.Visible = False

        Else
            frm_tasks_schedule_directory.Visible = False
            frm_tasks_schedule_file.Visible = True

        End If
    End Function
    Private Sub frm_tasks_schedule_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ShowOptionsBasedOnMode()
    End Sub
    Public Function WriteTask()
        ConstructScheduleString()
        tasks.Write_task(task, cfg_config.path_bulkimport_install & "\tasks\scheduled\" & task.task_category & "\" & task.task_name & ".xml")
    End Function
    Public Function ReadTask()
        tasks.GetTask(cfg_config.path_bulkimport_install & "\tasks\scheduled\" & tv_selected_parent & "\" & tv_selected_node & ".xml")
        txt_tasks_schedule_name.Text = task.task_name
        txt_tasks_schedule_description.Text = task.task_description
        cbx_tasks_schedule_category.Text = task.task_category
        frm_tasks_schedule_directory.txt_task_directory_ldap_path.Text = task.task_directory_ldap_path
        frm_tasks_schedule_directory.txt_task_directory_recursive.Text = task.task_directory_recursive_search
        frm_tasks_schedule_directory.txt_task_schedule_directory_path.Text = task.task_directory_path
        frm_tasks_schedule_directory.cbx_task_directory_incl_sub.Checked = task.task_directory_include_subdirectories
        frm_tasks_schedule_directory.cbx_task_directory_use_default.Checked = task.task_directory_use_default
        frm_tasks_schedule_file.txt_task_file_path.Text = task.task_file_path
        frm_tasks_schedule_file.cbx_task_file_use_default.Checked = task.task_file_use_default
        frm_tasks_schedule_file.cbx_task_incl_sub.Checked = task.task_file_include_subdirectories
        Dim schedule() As String = task.task_schedule.Split(",")
        Select Case schedule(0)
            Case 0
                frm_tasks_schedule_daily.dtp_tasks_schedule_daily.Text = schedule(1)
            Case 1
                frm_tasks_schedule_weekly.dtp_tasks_schedule_weekly.Text = schedule(1)
                Dim day() As String = schedule(2).Split("-")
                frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_mon.CheckState = day(0)
                frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_tue.CheckState = day(1)
                frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_wed.CheckState = day(2)
                frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_thu.CheckState = day(3)
                frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_fri.CheckState = day(4)
                frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_sat.CheckState = day(5)
                frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_sun.CheckState = day(6)
            Case 2
                frm_tasks_schedule_monthly.dtp_tasks_schedule_monthly_time.Text = schedule(1)
                frm_tasks_schedule_monthly.dtp_tasks_schedule_monthly_day.Value = New DateTime(Date.Now.Year, Date.Now.Month, schedule(2))
            Case 3
                Dim time() As String = schedule(1).Split(":")
                frm_tasks_schedule_yearly.dtp_tasks_schedule_yearly.Value = New DateTime(Date.Now.Year, schedule(3), schedule(2), time(0), time(1), 0)
        End Select
    End Function

    Public Function ConstructScheduleString()
        Select Case cbx_tasks_schedule_category.Text
            Case "Daily"
                task.task_schedule = "0," & frm_tasks_schedule_daily.dtp_tasks_schedule_daily.Value.ToShortTimeString
            Case "Weekly"
                task.task_schedule = "1," & frm_tasks_schedule_weekly.dtp_tasks_schedule_weekly.Value.ToShortTimeString & "," &
                    frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_mon.CheckState & "-" &
                    frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_tue.CheckState & "-" &
                    frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_wed.CheckState & "-" &
                    frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_thu.CheckState & "-" &
                    frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_fri.CheckState & "-" &
                    frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_sat.CheckState & "-" &
                    frm_tasks_schedule_weekly.cbx_tasks_schedule_weekly_sun.CheckState
            Case "Monthly"
                task.task_schedule = "2," & frm_tasks_schedule_monthly.dtp_tasks_schedule_monthly_time.Value.ToShortTimeString & "," & frm_tasks_schedule_monthly.dtp_tasks_schedule_monthly_day.Text
            Case "Yearly"
                task.task_schedule = "3," & frm_tasks_schedule_yearly.dtp_tasks_schedule_yearly.Value.Hour & ":" & frm_tasks_schedule_yearly.dtp_tasks_schedule_yearly.Value.Minute & "," & frm_tasks_schedule_yearly.dtp_tasks_schedule_yearly.Value.Day & "," & frm_tasks_schedule_yearly.dtp_tasks_schedule_yearly.Value.Month
        End Select

    End Function

    Public Function CheckScheduleOptions()
        Select Case cbx_tasks_schedule_category.Text
            Case "Daily"
                GroupBox2.Size = New Size(284, 46)
                Panel3.AutoScroll = False
                frm_tasks_schedule_directory.AutoSize = False
                Panel3.VerticalScroll.Enabled = False
                Panel3.HorizontalScroll.Enabled = False
                frm_tasks_schedule_daily.Visible = True
                frm_tasks_schedule_weekly.Visible = False
                frm_tasks_schedule_monthly.Visible = False
                frm_tasks_schedule_yearly.Visible = False
                ShowOptionsBasedOnMode()
            Case "Weekly"
                GroupBox2.Size = New Size(284, 146)


                Panel3.HorizontalScroll.Maximum = 0
                Panel3.AutoScroll = False
                Panel3.VerticalScroll.Enabled = True
                Panel3.VerticalScroll.Visible = False
                Panel3.AutoScroll = True

                frm_tasks_schedule_directory.AutoSize = True
                frm_tasks_schedule_daily.Visible = False
                frm_tasks_schedule_weekly.Visible = True
                frm_tasks_schedule_monthly.Visible = False
                frm_tasks_schedule_yearly.Visible = False
                ShowOptionsBasedOnMode()
            Case "Monthly"
                GroupBox2.Size = New Size(284, 71)
                Panel3.AutoScroll = False
                frm_tasks_schedule_directory.AutoSize = False
                Panel3.VerticalScroll.Enabled = False
                Panel3.HorizontalScroll.Enabled = False
                frm_tasks_schedule_daily.Visible = False
                frm_tasks_schedule_weekly.Visible = False
                frm_tasks_schedule_monthly.Visible = True
                frm_tasks_schedule_yearly.Visible = False
                ShowOptionsBasedOnMode()
            Case "Yearly"
                GroupBox2.Size = New Size(284, 46)
                Panel3.AutoScroll = False
                frm_tasks_schedule_directory.AutoSize = False
                Panel3.VerticalScroll.Enabled = False
                Panel3.HorizontalScroll.Enabled = False
                frm_tasks_schedule_daily.Visible = False
                frm_tasks_schedule_weekly.Visible = False
                frm_tasks_schedule_monthly.Visible = False
                frm_tasks_schedule_yearly.Visible = True
                ShowOptionsBasedOnMode()
        End Select
    End Function
    Public Function EmptyFields()
        txt_tasks_schedule_name.Text = ""
        txt_tasks_schedule_description.Text = ""
    End Function

    Private Sub txt_tasks_schedule_description_TextChanged(sender As Object, e As EventArgs) Handles txt_tasks_schedule_description.TextChanged
        task.task_description = txt_tasks_schedule_description.Text
    End Sub

    Private Sub cbx_tasks_schedule_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tasks_schedule_category.SelectedIndexChanged
        task.task_category = cbx_tasks_schedule_category.Text
    End Sub

    Private Sub tv_tasks_schedule_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tv_tasks_schedule.NodeMouseClick
        If e.Button = MouseButtons.Right Then
            tv_tasks_schedule.SelectedNode = e.Node
        End If
    End Sub

    Public Function LoadNodes()
        Dim DailyNodes As String() = Directory.GetFiles(cfg_config.path_bulkimport_install & "\tasks\scheduled\daily\", "*.xml")
        For Each node In DailyNodes
            node = node.Remove(0, node.LastIndexOf("\") + 1)
            node = node.Remove(node.LastIndexOf("."), 4)
            '  MessageBox.Show(node)
            AddNode("Daily", node)
        Next
        Dim WeeklyNodes As String() = Directory.GetFiles(cfg_config.path_bulkimport_install & "\tasks\scheduled\weekly\", "*.xml")
        For Each node In WeeklyNodes
            node = node.Remove(0, node.LastIndexOf("\") + 1)
            node = node.Remove(node.LastIndexOf("."), 4)
            ' MessageBox.Show(node)
            AddNode("Weekly", node)

        Next
        Dim MonthlyNodes As String() = Directory.GetFiles(cfg_config.path_bulkimport_install & "\tasks\scheduled\monthly\", "*.xml")
        For Each node In MonthlyNodes
            node = node.Remove(0, node.LastIndexOf("\") + 1)
            node = node.Remove(node.LastIndexOf("."), 4)
            'MessageBox.Show(node)
            AddNode("Monthly", node)
        Next
        Dim YearlyNodes As String() = Directory.GetFiles(cfg_config.path_bulkimport_install & "\tasks\scheduled\yearly\", "*.xml")
        For Each node In YearlyNodes
            node = node.Remove(0, node.LastIndexOf("\") + 1)
            node = node.Remove(node.LastIndexOf("."), 4)
            ' MessageBox.Show(node)
            AddNode("Yearly", node)
        Next
    End Function

End Class