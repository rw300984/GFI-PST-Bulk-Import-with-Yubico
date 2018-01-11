<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_dashboard_memory = New System.Windows.Forms.Label()
        Me.lbl_dashboard_cpu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pgb_dashboard_memory = New System.Windows.Forms.ProgressBar()
        Me.pgb_dashboard_cpu = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_dashboard_disk_write = New System.Windows.Forms.Label()
        Me.lbl_dashboard_disk_read = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_dashboard_import_duration = New System.Windows.Forms.Label()
        Me.lbl_dashboard_import_user = New System.Windows.Forms.Label()
        Me.lbl_dashboard_import_pst = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_import_jobname = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_dashboard_file_unclassified = New System.Windows.Forms.Label()
        Me.pgb_dashboard_unclassified = New System.Windows.Forms.ProgressBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_file_queue = New System.Windows.Forms.Label()
        Me.pgb_dashboard_queue = New System.Windows.Forms.ProgressBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_file_pickup = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pgb_dashboard_pickup = New System.Windows.Forms.ProgressBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbp_dashboard_event_system = New System.Windows.Forms.TabPage()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.tbp_dashboard_event_application = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_dashboard_service_2 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_service_1 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_service_0 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_service_5 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_service_4 = New System.Windows.Forms.Label()
        Me.lbl_dashboard_service_3 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_start_stop_monitoring = New System.Windows.Forms.Button()
        Me.btn_start_archiver_services = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bgw_dashboard_monitor = New System.ComponentModel.BackgroundWorker()
        Me.pfc_disk_read = New System.Diagnostics.PerformanceCounter()
        Me.pfc_disk_write = New System.Diagnostics.PerformanceCounter()
        Me.pfc_net_received = New System.Diagnostics.PerformanceCounter()
        Me.pfc_net_sent = New System.Diagnostics.PerformanceCounter()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lbl_dashboard_network_write = New System.Windows.Forms.Label()
        Me.lbl_dashboard_network_read = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.evt_system = New System.Diagnostics.EventLog()
        Me.evt_security = New System.Diagnostics.EventLog()
        Me.evt_application = New System.Diagnostics.EventLog()
        Me.pfc_cpu_load = New System.Diagnostics.PerformanceCounter()
        Me.tt_dashboard = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbp_dashboard_event_system.SuspendLayout()
        Me.tbp_dashboard_event_application.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pfc_disk_read, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfc_disk_write, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfc_net_received, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfc_net_sent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.evt_system, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.evt_security, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.evt_application, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfc_cpu_load, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.lbl_dashboard_memory)
        Me.GroupBox1.Controls.Add(Me.lbl_dashboard_cpu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.pgb_dashboard_memory)
        Me.GroupBox1.Controls.Add(Me.pgb_dashboard_cpu)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CPU and Memory"
        '
        'lbl_dashboard_memory
        '
        Me.lbl_dashboard_memory.AutoSize = True
        Me.lbl_dashboard_memory.Location = New System.Drawing.Point(159, 65)
        Me.lbl_dashboard_memory.Name = "lbl_dashboard_memory"
        Me.lbl_dashboard_memory.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_memory.TabIndex = 5
        '
        'lbl_dashboard_cpu
        '
        Me.lbl_dashboard_cpu.AutoSize = True
        Me.lbl_dashboard_cpu.Location = New System.Drawing.Point(159, 36)
        Me.lbl_dashboard_cpu.Name = "lbl_dashboard_cpu"
        Me.lbl_dashboard_cpu.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_cpu.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RAM:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CPU:"
        '
        'pgb_dashboard_memory
        '
        Me.pgb_dashboard_memory.Location = New System.Drawing.Point(44, 61)
        Me.pgb_dashboard_memory.Name = "pgb_dashboard_memory"
        Me.pgb_dashboard_memory.Size = New System.Drawing.Size(108, 23)
        Me.pgb_dashboard_memory.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgb_dashboard_memory.TabIndex = 1
        '
        'pgb_dashboard_cpu
        '
        Me.pgb_dashboard_cpu.Location = New System.Drawing.Point(44, 32)
        Me.pgb_dashboard_cpu.Name = "pgb_dashboard_cpu"
        Me.pgb_dashboard_cpu.Size = New System.Drawing.Size(108, 23)
        Me.pgb_dashboard_cpu.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgb_dashboard_cpu.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Controls.Add(Me.lbl_dashboard_disk_write)
        Me.GroupBox2.Controls.Add(Me.lbl_dashboard_disk_read)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Disk I/O"
        '
        'lbl_dashboard_disk_write
        '
        Me.lbl_dashboard_disk_write.AutoSize = True
        Me.lbl_dashboard_disk_write.Location = New System.Drawing.Point(68, 67)
        Me.lbl_dashboard_disk_write.Name = "lbl_dashboard_disk_write"
        Me.lbl_dashboard_disk_write.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_disk_write.TabIndex = 11
        '
        'lbl_dashboard_disk_read
        '
        Me.lbl_dashboard_disk_read.AutoSize = True
        Me.lbl_dashboard_disk_read.Location = New System.Drawing.Point(67, 36)
        Me.lbl_dashboard_disk_read.Name = "lbl_dashboard_disk_read"
        Me.lbl_dashboard_disk_read.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_disk_read.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Disk write:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Disk read:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(370, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Import statistics"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.47458!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.52542!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_dashboard_import_duration, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_dashboard_import_user, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_dashboard_import_pst, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_dashboard_import_jobname, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(236, 81)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'lbl_dashboard_import_duration
        '
        Me.lbl_dashboard_import_duration.AutoSize = True
        Me.lbl_dashboard_import_duration.Location = New System.Drawing.Point(82, 60)
        Me.lbl_dashboard_import_duration.Name = "lbl_dashboard_import_duration"
        Me.lbl_dashboard_import_duration.Size = New System.Drawing.Size(60, 13)
        Me.lbl_dashboard_import_duration.TabIndex = 5
        Me.lbl_dashboard_import_duration.Text = "Time min/h"
        '
        'lbl_dashboard_import_user
        '
        Me.lbl_dashboard_import_user.AutoSize = True
        Me.lbl_dashboard_import_user.Location = New System.Drawing.Point(82, 20)
        Me.lbl_dashboard_import_user.Name = "lbl_dashboard_import_user"
        Me.lbl_dashboard_import_user.Size = New System.Drawing.Size(44, 13)
        Me.lbl_dashboard_import_user.TabIndex = 7
        Me.lbl_dashboard_import_user.Text = "Number"
        '
        'lbl_dashboard_import_pst
        '
        Me.lbl_dashboard_import_pst.AutoSize = True
        Me.lbl_dashboard_import_pst.Location = New System.Drawing.Point(82, 40)
        Me.lbl_dashboard_import_pst.Name = "lbl_dashboard_import_pst"
        Me.lbl_dashboard_import_pst.Size = New System.Drawing.Size(44, 13)
        Me.lbl_dashboard_import_pst.TabIndex = 4
        Me.lbl_dashboard_import_pst.Text = "Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No. of Users:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "No. of PST:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Duration:"
        '
        'lbl_dashboard_import_jobname
        '
        Me.lbl_dashboard_import_jobname.AutoSize = True
        Me.lbl_dashboard_import_jobname.Location = New System.Drawing.Point(82, 0)
        Me.lbl_dashboard_import_jobname.Name = "lbl_dashboard_import_jobname"
        Me.lbl_dashboard_import_jobname.Size = New System.Drawing.Size(53, 13)
        Me.lbl_dashboard_import_jobname.TabIndex = 3
        Me.lbl_dashboard_import_jobname.Text = "Job name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Last job:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox4.Controls.Add(Me.lbl_dashboard_file_unclassified)
        Me.GroupBox4.Controls.Add(Me.pgb_dashboard_unclassified)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lbl_dashboard_file_queue)
        Me.GroupBox4.Controls.Add(Me.pgb_dashboard_queue)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lbl_dashboard_file_pickup)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.pgb_dashboard_pickup)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(197, 136)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Queues"
        '
        'lbl_dashboard_file_unclassified
        '
        Me.lbl_dashboard_file_unclassified.AutoSize = True
        Me.lbl_dashboard_file_unclassified.Location = New System.Drawing.Point(163, 90)
        Me.lbl_dashboard_file_unclassified.Name = "lbl_dashboard_file_unclassified"
        Me.lbl_dashboard_file_unclassified.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_file_unclassified.TabIndex = 20
        '
        'pgb_dashboard_unclassified
        '
        Me.pgb_dashboard_unclassified.Location = New System.Drawing.Point(79, 86)
        Me.pgb_dashboard_unclassified.Name = "pgb_dashboard_unclassified"
        Me.pgb_dashboard_unclassified.Size = New System.Drawing.Size(79, 23)
        Me.pgb_dashboard_unclassified.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgb_dashboard_unclassified.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Unclassified:"
        '
        'lbl_dashboard_file_queue
        '
        Me.lbl_dashboard_file_queue.AutoSize = True
        Me.lbl_dashboard_file_queue.Location = New System.Drawing.Point(163, 61)
        Me.lbl_dashboard_file_queue.Name = "lbl_dashboard_file_queue"
        Me.lbl_dashboard_file_queue.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_file_queue.TabIndex = 17
        '
        'pgb_dashboard_queue
        '
        Me.pgb_dashboard_queue.Location = New System.Drawing.Point(79, 57)
        Me.pgb_dashboard_queue.Name = "pgb_dashboard_queue"
        Me.pgb_dashboard_queue.Size = New System.Drawing.Size(79, 23)
        Me.pgb_dashboard_queue.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgb_dashboard_queue.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Pickup:"
        '
        'lbl_dashboard_file_pickup
        '
        Me.lbl_dashboard_file_pickup.AutoSize = True
        Me.lbl_dashboard_file_pickup.Location = New System.Drawing.Point(163, 32)
        Me.lbl_dashboard_file_pickup.Name = "lbl_dashboard_file_pickup"
        Me.lbl_dashboard_file_pickup.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_file_pickup.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Queue:"
        '
        'pgb_dashboard_pickup
        '
        Me.pgb_dashboard_pickup.Location = New System.Drawing.Point(79, 28)
        Me.pgb_dashboard_pickup.Name = "pgb_dashboard_pickup"
        Me.pgb_dashboard_pickup.Size = New System.Drawing.Size(79, 23)
        Me.pgb_dashboard_pickup.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgb_dashboard_pickup.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox5.Controls.Add(Me.TabControl1)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox5.Location = New System.Drawing.Point(218, 224)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(394, 136)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Alerts"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbp_dashboard_event_system)
        Me.TabControl1.Controls.Add(Me.tbp_dashboard_event_application)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(388, 117)
        Me.TabControl1.TabIndex = 0
        '
        'tbp_dashboard_event_system
        '
        Me.tbp_dashboard_event_system.AutoScroll = True
        Me.tbp_dashboard_event_system.BackColor = System.Drawing.Color.DimGray
        Me.tbp_dashboard_event_system.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbp_dashboard_event_system.Controls.Add(Me.RichTextBox3)
        Me.tbp_dashboard_event_system.Location = New System.Drawing.Point(4, 22)
        Me.tbp_dashboard_event_system.Name = "tbp_dashboard_event_system"
        Me.tbp_dashboard_event_system.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_dashboard_event_system.Size = New System.Drawing.Size(380, 91)
        Me.tbp_dashboard_event_system.TabIndex = 0
        Me.tbp_dashboard_event_system.Text = "System"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.DimGray
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox3.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(374, 85)
        Me.RichTextBox3.TabIndex = 4
        Me.RichTextBox3.Text = ""
        '
        'tbp_dashboard_event_application
        '
        Me.tbp_dashboard_event_application.AutoScroll = True
        Me.tbp_dashboard_event_application.BackColor = System.Drawing.Color.DimGray
        Me.tbp_dashboard_event_application.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbp_dashboard_event_application.Controls.Add(Me.RichTextBox1)
        Me.tbp_dashboard_event_application.Location = New System.Drawing.Point(4, 22)
        Me.tbp_dashboard_event_application.Name = "tbp_dashboard_event_application"
        Me.tbp_dashboard_event_application.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_dashboard_event_application.Size = New System.Drawing.Size(380, 91)
        Me.tbp_dashboard_event_application.TabIndex = 2
        Me.tbp_dashboard_event_application.Text = "Application"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.DimGray
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(374, 85)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox6.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox6.Location = New System.Drawing.Point(218, 118)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(394, 100)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Service Status"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_dashboard_service_2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_dashboard_service_1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_dashboard_service_0, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_dashboard_service_5, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_dashboard_service_4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_dashboard_service_3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(388, 81)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lbl_dashboard_service_2
        '
        Me.lbl_dashboard_service_2.AutoSize = True
        Me.lbl_dashboard_service_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_dashboard_service_2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_dashboard_service_2.Location = New System.Drawing.Point(258, 0)
        Me.lbl_dashboard_service_2.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_dashboard_service_2.Name = "lbl_dashboard_service_2"
        Me.lbl_dashboard_service_2.Size = New System.Drawing.Size(130, 40)
        Me.lbl_dashboard_service_2.TabIndex = 2
        Me.lbl_dashboard_service_2.Text = "Service 2"
        Me.lbl_dashboard_service_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dashboard_service_1
        '
        Me.lbl_dashboard_service_1.AutoSize = True
        Me.lbl_dashboard_service_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_dashboard_service_1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_dashboard_service_1.Location = New System.Drawing.Point(129, 0)
        Me.lbl_dashboard_service_1.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_dashboard_service_1.Name = "lbl_dashboard_service_1"
        Me.lbl_dashboard_service_1.Size = New System.Drawing.Size(129, 40)
        Me.lbl_dashboard_service_1.TabIndex = 1
        Me.lbl_dashboard_service_1.Text = "Service 1"
        Me.lbl_dashboard_service_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dashboard_service_0
        '
        Me.lbl_dashboard_service_0.AutoSize = True
        Me.lbl_dashboard_service_0.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dashboard_service_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_dashboard_service_0.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_dashboard_service_0.Location = New System.Drawing.Point(0, 0)
        Me.lbl_dashboard_service_0.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_dashboard_service_0.Name = "lbl_dashboard_service_0"
        Me.lbl_dashboard_service_0.Size = New System.Drawing.Size(129, 40)
        Me.lbl_dashboard_service_0.TabIndex = 0
        Me.lbl_dashboard_service_0.Text = "Service 0"
        Me.lbl_dashboard_service_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dashboard_service_5
        '
        Me.lbl_dashboard_service_5.AutoSize = True
        Me.lbl_dashboard_service_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_dashboard_service_5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_dashboard_service_5.Location = New System.Drawing.Point(258, 40)
        Me.lbl_dashboard_service_5.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_dashboard_service_5.Name = "lbl_dashboard_service_5"
        Me.lbl_dashboard_service_5.Size = New System.Drawing.Size(130, 41)
        Me.lbl_dashboard_service_5.TabIndex = 5
        Me.lbl_dashboard_service_5.Text = "Service 5"
        Me.lbl_dashboard_service_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dashboard_service_4
        '
        Me.lbl_dashboard_service_4.AutoSize = True
        Me.lbl_dashboard_service_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_dashboard_service_4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_dashboard_service_4.Location = New System.Drawing.Point(129, 40)
        Me.lbl_dashboard_service_4.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_dashboard_service_4.Name = "lbl_dashboard_service_4"
        Me.lbl_dashboard_service_4.Size = New System.Drawing.Size(129, 41)
        Me.lbl_dashboard_service_4.TabIndex = 4
        Me.lbl_dashboard_service_4.Text = "Service 4"
        Me.lbl_dashboard_service_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dashboard_service_3
        '
        Me.lbl_dashboard_service_3.AutoSize = True
        Me.lbl_dashboard_service_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_dashboard_service_3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_dashboard_service_3.Location = New System.Drawing.Point(0, 40)
        Me.lbl_dashboard_service_3.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_dashboard_service_3.Name = "lbl_dashboard_service_3"
        Me.lbl_dashboard_service_3.Size = New System.Drawing.Size(129, 41)
        Me.lbl_dashboard_service_3.TabIndex = 3
        Me.lbl_dashboard_service_3.Text = "Service 3"
        Me.lbl_dashboard_service_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox7.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox7.Location = New System.Drawing.Point(12, 366)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(600, 87)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Service Control"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_start_stop_monitoring, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_start_archiver_services, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(585, 62)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(441, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 56)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Show Logs"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btn_start_stop_monitoring
        '
        Me.btn_start_stop_monitoring.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_start_stop_monitoring.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_start_stop_monitoring.FlatAppearance.BorderSize = 0
        Me.btn_start_stop_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start_stop_monitoring.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_start_stop_monitoring.Location = New System.Drawing.Point(295, 3)
        Me.btn_start_stop_monitoring.Name = "btn_start_stop_monitoring"
        Me.btn_start_stop_monitoring.Size = New System.Drawing.Size(140, 56)
        Me.btn_start_stop_monitoring.TabIndex = 2
        Me.btn_start_stop_monitoring.Text = "Start Monitoring"
        Me.btn_start_stop_monitoring.UseVisualStyleBackColor = False
        '
        'btn_start_archiver_services
        '
        Me.btn_start_archiver_services.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_start_archiver_services.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_start_archiver_services.FlatAppearance.BorderSize = 0
        Me.btn_start_archiver_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start_archiver_services.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_start_archiver_services.Location = New System.Drawing.Point(149, 3)
        Me.btn_start_archiver_services.Name = "btn_start_archiver_services"
        Me.btn_start_archiver_services.Size = New System.Drawing.Size(140, 56)
        Me.btn_start_archiver_services.TabIndex = 1
        Me.btn_start_archiver_services.Text = "Start Archiver Service"
        Me.btn_start_archiver_services.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Import"
        Me.tt_dashboard.SetToolTip(Me.Button1, "coming soon")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bgw_dashboard_monitor
        '
        Me.bgw_dashboard_monitor.WorkerReportsProgress = True
        Me.bgw_dashboard_monitor.WorkerSupportsCancellation = True
        '
        'pfc_disk_read
        '
        Me.pfc_disk_read.CategoryName = "LogicalDisk"
        Me.pfc_disk_read.CounterName = "Disk Read Bytes/sec"
        Me.pfc_disk_read.InstanceName = "_Total"
        '
        'pfc_disk_write
        '
        Me.pfc_disk_write.CategoryName = "LogicalDisk"
        Me.pfc_disk_write.CounterName = "Disk Write Bytes/sec"
        Me.pfc_disk_write.InstanceName = "_Total"
        '
        'pfc_net_received
        '
        Me.pfc_net_received.CategoryName = "Network Adapter"
        Me.pfc_net_received.CounterName = "Bytes Received/sec"
        Me.pfc_net_received.InstanceName = "Intel[R] 82574L Gigabit Network Connection"
        '
        'pfc_net_sent
        '
        Me.pfc_net_sent.CategoryName = "Network Adapter"
        Me.pfc_net_sent.CounterName = "Bytes Sent/sec"
        Me.pfc_net_sent.InstanceName = "Intel[R] 82574L Gigabit Network Connection"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox8.Controls.Add(Me.lbl_dashboard_network_write)
        Me.GroupBox8.Controls.Add(Me.lbl_dashboard_network_read)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox8.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(146, 100)
        Me.GroupBox8.TabIndex = 16
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Network I/O"
        '
        'lbl_dashboard_network_write
        '
        Me.lbl_dashboard_network_write.AutoSize = True
        Me.lbl_dashboard_network_write.Location = New System.Drawing.Point(67, 65)
        Me.lbl_dashboard_network_write.Name = "lbl_dashboard_network_write"
        Me.lbl_dashboard_network_write.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_network_write.TabIndex = 15
        '
        'lbl_dashboard_network_read
        '
        Me.lbl_dashboard_network_read.AutoSize = True
        Me.lbl_dashboard_network_read.Location = New System.Drawing.Point(67, 36)
        Me.lbl_dashboard_network_read.Name = "lbl_dashboard_network_read"
        Me.lbl_dashboard_network_read.Size = New System.Drawing.Size(0, 13)
        Me.lbl_dashboard_network_read.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Sent:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Received:"
        '
        'evt_system
        '
        Me.evt_system.Log = "System"
        Me.evt_system.SynchronizingObject = Me
        '
        'evt_security
        '
        Me.evt_security.Log = "Security"
        Me.evt_security.SynchronizingObject = Me
        '
        'evt_application
        '
        Me.evt_application.Log = "Application"
        Me.evt_application.SynchronizingObject = Me
        '
        'pfc_cpu_load
        '
        Me.pfc_cpu_load.CategoryName = "Processor"
        Me.pfc_cpu_load.CounterName = "% Processor Time"
        Me.pfc_cpu_load.InstanceName = "_Total"
        '
        'frm_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(624, 465)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbp_dashboard_event_system.ResumeLayout(False)
        Me.tbp_dashboard_event_application.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pfc_disk_read, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfc_disk_write, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfc_net_received, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfc_net_sent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.evt_system, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.evt_security, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.evt_application, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfc_cpu_load, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_dashboard_memory As Label
    Friend WithEvents lbl_dashboard_cpu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pgb_dashboard_memory As ProgressBar
    Friend WithEvents pgb_dashboard_cpu As ProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_dashboard_disk_write As Label
    Friend WithEvents lbl_dashboard_disk_read As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_dashboard_import_pst As Label
    Friend WithEvents lbl_dashboard_import_jobname As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_dashboard_file_unclassified As Label
    Friend WithEvents pgb_dashboard_unclassified As ProgressBar
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_dashboard_file_queue As Label
    Friend WithEvents pgb_dashboard_queue As ProgressBar
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_dashboard_file_pickup As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents pgb_dashboard_pickup As ProgressBar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_start_stop_monitoring As Button
    Friend WithEvents btn_start_archiver_services As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents bgw_dashboard_monitor As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_dashboard_service_4 As Label
    Friend WithEvents lbl_dashboard_service_3 As Label
    Friend WithEvents lbl_dashboard_service_2 As Label
    Friend WithEvents lbl_dashboard_service_1 As Label
    Friend WithEvents lbl_dashboard_service_0 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbp_dashboard_event_system As TabPage
    Friend WithEvents tbp_dashboard_event_application As TabPage
    Friend WithEvents pfc_disk_read As PerformanceCounter
    Friend WithEvents pfc_disk_write As PerformanceCounter
    Friend WithEvents pfc_net_received As PerformanceCounter
    Friend WithEvents pfc_net_sent As PerformanceCounter
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lbl_dashboard_network_write As Label
    Friend WithEvents lbl_dashboard_network_read As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents evt_system As EventLog
    Friend WithEvents evt_security As EventLog
    Friend WithEvents evt_application As EventLog
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents pfc_cpu_load As PerformanceCounter
    Friend WithEvents lbl_dashboard_service_5 As Label
    Friend WithEvents lbl_dashboard_import_user As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lbl_dashboard_import_duration As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tt_dashboard As ToolTip
End Class
