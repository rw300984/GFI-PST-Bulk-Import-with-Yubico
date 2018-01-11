<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_config_monitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_monitor_cpu = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_memory = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_disk = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_network = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_monitor_service6 = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_service5 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_monitor_service1 = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_service2 = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_service3 = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_service4 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbx_monitor_pickup = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_queue = New System.Windows.Forms.ComboBox()
        Me.cbx_monitor_unclassified = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_monitor_alert_service = New System.Windows.Forms.CheckBox()
        Me.cbx_monitor_alert_task = New System.Windows.Forms.CheckBox()
        Me.cbx_monitor_alert_directory = New System.Windows.Forms.CheckBox()
        Me.cbx_monitor_alert_cpu = New System.Windows.Forms.CheckBox()
        Me.cbx_monitor_alert_mode = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Performance Counter"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_monitor_cpu, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_monitor_memory, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_monitor_disk, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_monitor_network, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(458, 81)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Network"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Memory"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Disk"
        '
        'cbx_monitor_cpu
        '
        Me.cbx_monitor_cpu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_cpu.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_cpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_cpu.FormattingEnabled = True
        Me.cbx_monitor_cpu.Location = New System.Drawing.Point(87, 9)
        Me.cbx_monitor_cpu.Name = "cbx_monitor_cpu"
        Me.cbx_monitor_cpu.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_cpu.TabIndex = 0
        '
        'cbx_monitor_memory
        '
        Me.cbx_monitor_memory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_memory.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_memory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_memory.Enabled = False
        Me.cbx_monitor_memory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_memory.FormattingEnabled = True
        Me.cbx_monitor_memory.Location = New System.Drawing.Point(87, 50)
        Me.cbx_monitor_memory.Name = "cbx_monitor_memory"
        Me.cbx_monitor_memory.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_memory.TabIndex = 1
        '
        'cbx_monitor_disk
        '
        Me.cbx_monitor_disk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_disk.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_disk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_disk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_disk.FormattingEnabled = True
        Me.cbx_monitor_disk.Location = New System.Drawing.Point(316, 9)
        Me.cbx_monitor_disk.Name = "cbx_monitor_disk"
        Me.cbx_monitor_disk.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_disk.TabIndex = 2
        '
        'cbx_monitor_network
        '
        Me.cbx_monitor_network.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_network.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_network.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_network.FormattingEnabled = True
        Me.cbx_monitor_network.Location = New System.Drawing.Point(316, 50)
        Me.cbx_monitor_network.Name = "cbx_monitor_network"
        Me.cbx_monitor_network.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_network.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CPU"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Services"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.166667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.166667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.166667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667!))
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_monitor_service6, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_monitor_service5, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_monitor_service1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_monitor_service2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_monitor_service3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_monitor_service4, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 4, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(458, 81)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'cbx_monitor_service6
        '
        Me.cbx_monitor_service6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_service6.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_service6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_service6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_service6.FormattingEnabled = True
        Me.cbx_monitor_service6.Location = New System.Drawing.Point(330, 50)
        Me.cbx_monitor_service6.Name = "cbx_monitor_service6"
        Me.cbx_monitor_service6.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_service6.TabIndex = 12
        '
        'cbx_monitor_service5
        '
        Me.cbx_monitor_service5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_service5.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_service5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_service5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_service5.FormattingEnabled = True
        Me.cbx_monitor_service5.Location = New System.Drawing.Point(330, 9)
        Me.cbx_monitor_service5.Name = "cbx_monitor_service5"
        Me.cbx_monitor_service5.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_service5.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "4"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "2"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(155, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "3"
        '
        'cbx_monitor_service1
        '
        Me.cbx_monitor_service1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_service1.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_service1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_service1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_service1.FormattingEnabled = True
        Me.cbx_monitor_service1.Location = New System.Drawing.Point(25, 9)
        Me.cbx_monitor_service1.Name = "cbx_monitor_service1"
        Me.cbx_monitor_service1.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_service1.TabIndex = 0
        '
        'cbx_monitor_service2
        '
        Me.cbx_monitor_service2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_service2.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_service2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_service2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_service2.FormattingEnabled = True
        Me.cbx_monitor_service2.Location = New System.Drawing.Point(25, 50)
        Me.cbx_monitor_service2.Name = "cbx_monitor_service2"
        Me.cbx_monitor_service2.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_service2.TabIndex = 1
        '
        'cbx_monitor_service3
        '
        Me.cbx_monitor_service3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_service3.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_service3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_service3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_service3.FormattingEnabled = True
        Me.cbx_monitor_service3.Location = New System.Drawing.Point(177, 9)
        Me.cbx_monitor_service3.Name = "cbx_monitor_service3"
        Me.cbx_monitor_service3.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_service3.TabIndex = 2
        '
        'cbx_monitor_service4
        '
        Me.cbx_monitor_service4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_service4.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_service4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_service4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_service4.FormattingEnabled = True
        Me.cbx_monitor_service4.Location = New System.Drawing.Point(177, 50)
        Me.cbx_monitor_service4.Name = "cbx_monitor_service4"
        Me.cbx_monitor_service4.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_service4.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "1"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "5"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(307, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "6"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(10, 210)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Directories"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cbx_monitor_pickup, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cbx_monitor_queue, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.cbx_monitor_unclassified, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(458, 81)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Queue"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(233, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 26)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Unclassified"
        '
        'cbx_monitor_pickup
        '
        Me.cbx_monitor_pickup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_pickup.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_pickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_pickup.FormattingEnabled = True
        Me.cbx_monitor_pickup.Items.AddRange(New Object() {"1000", "5000", "10000"})
        Me.cbx_monitor_pickup.Location = New System.Drawing.Point(87, 9)
        Me.cbx_monitor_pickup.Name = "cbx_monitor_pickup"
        Me.cbx_monitor_pickup.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_pickup.TabIndex = 0
        '
        'cbx_monitor_queue
        '
        Me.cbx_monitor_queue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_queue.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_queue.FormattingEnabled = True
        Me.cbx_monitor_queue.Items.AddRange(New Object() {"500", "1000", "5000", "10000"})
        Me.cbx_monitor_queue.Location = New System.Drawing.Point(87, 50)
        Me.cbx_monitor_queue.Name = "cbx_monitor_queue"
        Me.cbx_monitor_queue.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_queue.TabIndex = 1
        '
        'cbx_monitor_unclassified
        '
        Me.cbx_monitor_unclassified.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbx_monitor_unclassified.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_unclassified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_unclassified.FormattingEnabled = True
        Me.cbx_monitor_unclassified.Items.AddRange(New Object() {"5", "25", "100", "500"})
        Me.cbx_monitor_unclassified.Location = New System.Drawing.Point(316, 9)
        Me.cbx_monitor_unclassified.Name = "cbx_monitor_unclassified"
        Me.cbx_monitor_unclassified.Size = New System.Drawing.Size(121, 21)
        Me.cbx_monitor_unclassified.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Pickup"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(10, 310)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "E-Mail alerts"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cbx_monitor_alert_cpu, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cbx_monitor_alert_directory, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cbx_monitor_alert_task, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbx_monitor_alert_service, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbx_monitor_alert_mode, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(458, 81)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'cbx_monitor_alert_service
        '
        Me.cbx_monitor_alert_service.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_monitor_alert_service.AutoSize = True
        Me.cbx_monitor_alert_service.BackColor = System.Drawing.Color.DarkGray
        Me.cbx_monitor_alert_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_alert_service.Location = New System.Drawing.Point(3, 11)
        Me.cbx_monitor_alert_service.Name = "cbx_monitor_alert_service"
        Me.cbx_monitor_alert_service.Size = New System.Drawing.Size(100, 17)
        Me.cbx_monitor_alert_service.TabIndex = 0
        Me.cbx_monitor_alert_service.Text = "Service stopped"
        Me.cbx_monitor_alert_service.UseVisualStyleBackColor = False
        '
        'cbx_monitor_alert_task
        '
        Me.cbx_monitor_alert_task.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_monitor_alert_task.AutoSize = True
        Me.cbx_monitor_alert_task.BackColor = System.Drawing.Color.DarkGray
        Me.cbx_monitor_alert_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_alert_task.Location = New System.Drawing.Point(140, 11)
        Me.cbx_monitor_alert_task.Name = "cbx_monitor_alert_task"
        Me.cbx_monitor_alert_task.Size = New System.Drawing.Size(86, 17)
        Me.cbx_monitor_alert_task.TabIndex = 1
        Me.cbx_monitor_alert_task.Text = "Task finished"
        Me.cbx_monitor_alert_task.UseVisualStyleBackColor = False
        '
        'cbx_monitor_alert_directory
        '
        Me.cbx_monitor_alert_directory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_monitor_alert_directory.AutoSize = True
        Me.cbx_monitor_alert_directory.BackColor = System.Drawing.Color.DarkGray
        Me.cbx_monitor_alert_directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_alert_directory.Location = New System.Drawing.Point(3, 52)
        Me.cbx_monitor_alert_directory.Name = "cbx_monitor_alert_directory"
        Me.cbx_monitor_alert_directory.Size = New System.Drawing.Size(131, 17)
        Me.cbx_monitor_alert_directory.TabIndex = 2
        Me.cbx_monitor_alert_directory.Text = "Directory treshold reached"
        Me.cbx_monitor_alert_directory.UseVisualStyleBackColor = False
        '
        'cbx_monitor_alert_cpu
        '
        Me.cbx_monitor_alert_cpu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_monitor_alert_cpu.AutoSize = True
        Me.cbx_monitor_alert_cpu.BackColor = System.Drawing.Color.DarkGray
        Me.cbx_monitor_alert_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_alert_cpu.Location = New System.Drawing.Point(140, 52)
        Me.cbx_monitor_alert_cpu.Name = "cbx_monitor_alert_cpu"
        Me.cbx_monitor_alert_cpu.Size = New System.Drawing.Size(102, 17)
        Me.cbx_monitor_alert_cpu.TabIndex = 3
        Me.cbx_monitor_alert_cpu.Text = "High CPU usage"
        Me.cbx_monitor_alert_cpu.UseVisualStyleBackColor = False
        '
        'cbx_monitor_alert_mode
        '
        Me.cbx_monitor_alert_mode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_monitor_alert_mode.BackColor = System.Drawing.Color.LightGray
        Me.cbx_monitor_alert_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monitor_alert_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_monitor_alert_mode.FormattingEnabled = True
        Me.cbx_monitor_alert_mode.Items.AddRange(New Object() {"Alert once", "Alert every 5min", "Alert every 15min", "Alert every 30min"})
        Me.cbx_monitor_alert_mode.Location = New System.Drawing.Point(345, 9)
        Me.cbx_monitor_alert_mode.Name = "cbx_monitor_alert_mode"
        Me.cbx_monitor_alert_mode.Size = New System.Drawing.Size(110, 21)
        Me.cbx_monitor_alert_mode.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Alert mode:"
        '
        'frm_config_monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(484, 429)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_config_monitor"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frm_config_monitor"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_monitor_cpu As ComboBox
    Friend WithEvents cbx_monitor_memory As ComboBox
    Friend WithEvents cbx_monitor_disk As ComboBox
    Friend WithEvents cbx_monitor_network As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_monitor_service1 As ComboBox
    Friend WithEvents cbx_monitor_service2 As ComboBox
    Friend WithEvents cbx_monitor_service3 As ComboBox
    Friend WithEvents cbx_monitor_service4 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_monitor_service6 As ComboBox
    Friend WithEvents cbx_monitor_service5 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbx_monitor_pickup As ComboBox
    Friend WithEvents cbx_monitor_queue As ComboBox
    Friend WithEvents cbx_monitor_unclassified As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cbx_monitor_alert_cpu As CheckBox
    Friend WithEvents cbx_monitor_alert_directory As CheckBox
    Friend WithEvents cbx_monitor_alert_task As CheckBox
    Friend WithEvents cbx_monitor_alert_service As CheckBox
    Friend WithEvents cbx_monitor_alert_mode As ComboBox
    Friend WithEvents Label11 As Label
End Class
