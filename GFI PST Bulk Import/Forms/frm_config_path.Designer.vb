<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config_path
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_config_path_archiver_unclassified = New System.Windows.Forms.Button()
        Me.btn_config_path_archiver_pickup = New System.Windows.Forms.Button()
        Me.btn_config_path_archiver_queue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_path_archiver_install = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_path_archiver_pickup = New System.Windows.Forms.TextBox()
        Me.txt_path_archiver_queue = New System.Windows.Forms.TextBox()
        Me.txt_path_archiver_unclassified = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_config_path_archiver_install = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_config_path_bulkimport_temp = New System.Windows.Forms.Button()
        Me.btn_config_path_bulkimport_logs = New System.Windows.Forms.Button()
        Me.btn_config_path_bulkimport_config = New System.Windows.Forms.Button()
        Me.txt_path_bulkimport_install = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_path_bulkimport_logs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_path_bulkimport_config = New System.Windows.Forms.TextBox()
        Me.txt_path_bulkimport_temp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_config_path_bulkimport_install = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_path_pstsource_default = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_path_pstsource_default = New System.Windows.Forms.TextBox()
        Me.fbd_config_path = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GFI Archiver Path"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_config_path_archiver_unclassified, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_config_path_archiver_pickup, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_config_path_archiver_queue, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_path_archiver_install, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_path_archiver_pickup, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_path_archiver_queue, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_path_archiver_unclassified, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_config_path_archiver_install, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(458, 81)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'btn_config_path_archiver_unclassified
        '
        Me.btn_config_path_archiver_unclassified.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_archiver_unclassified.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_archiver_unclassified.FlatAppearance.BorderSize = 0
        Me.btn_config_path_archiver_unclassified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_archiver_unclassified.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_archiver_unclassified.Location = New System.Drawing.Point(427, 50)
        Me.btn_config_path_archiver_unclassified.Name = "btn_config_path_archiver_unclassified"
        Me.btn_config_path_archiver_unclassified.Size = New System.Drawing.Size(28, 20)
        Me.btn_config_path_archiver_unclassified.TabIndex = 13
        Me.btn_config_path_archiver_unclassified.Text = "..."
        Me.btn_config_path_archiver_unclassified.UseVisualStyleBackColor = False
        '
        'btn_config_path_archiver_pickup
        '
        Me.btn_config_path_archiver_pickup.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_archiver_pickup.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_archiver_pickup.FlatAppearance.BorderSize = 0
        Me.btn_config_path_archiver_pickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_archiver_pickup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_archiver_pickup.Location = New System.Drawing.Point(199, 50)
        Me.btn_config_path_archiver_pickup.Name = "btn_config_path_archiver_pickup"
        Me.btn_config_path_archiver_pickup.Size = New System.Drawing.Size(26, 20)
        Me.btn_config_path_archiver_pickup.TabIndex = 12
        Me.btn_config_path_archiver_pickup.Text = "..."
        Me.btn_config_path_archiver_pickup.UseVisualStyleBackColor = False
        '
        'btn_config_path_archiver_queue
        '
        Me.btn_config_path_archiver_queue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_archiver_queue.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_archiver_queue.FlatAppearance.BorderSize = 0
        Me.btn_config_path_archiver_queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_archiver_queue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_archiver_queue.Location = New System.Drawing.Point(427, 10)
        Me.btn_config_path_archiver_queue.Name = "btn_config_path_archiver_queue"
        Me.btn_config_path_archiver_queue.Size = New System.Drawing.Size(28, 20)
        Me.btn_config_path_archiver_queue.TabIndex = 11
        Me.btn_config_path_archiver_queue.Text = "..."
        Me.btn_config_path_archiver_queue.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Install"
        '
        'txt_path_archiver_install
        '
        Me.txt_path_archiver_install.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_archiver_install.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_archiver_install.Location = New System.Drawing.Point(71, 10)
        Me.txt_path_archiver_install.Name = "txt_path_archiver_install"
        Me.txt_path_archiver_install.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_archiver_install.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pickup"
        '
        'txt_path_archiver_pickup
        '
        Me.txt_path_archiver_pickup.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_archiver_pickup.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_archiver_pickup.Location = New System.Drawing.Point(71, 50)
        Me.txt_path_archiver_pickup.Name = "txt_path_archiver_pickup"
        Me.txt_path_archiver_pickup.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_archiver_pickup.TabIndex = 3
        '
        'txt_path_archiver_queue
        '
        Me.txt_path_archiver_queue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_archiver_queue.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_archiver_queue.Location = New System.Drawing.Point(299, 10)
        Me.txt_path_archiver_queue.Name = "txt_path_archiver_queue"
        Me.txt_path_archiver_queue.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_archiver_queue.TabIndex = 8
        '
        'txt_path_archiver_unclassified
        '
        Me.txt_path_archiver_unclassified.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_archiver_unclassified.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_archiver_unclassified.Location = New System.Drawing.Point(299, 50)
        Me.txt_path_archiver_unclassified.Name = "txt_path_archiver_unclassified"
        Me.txt_path_archiver_unclassified.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_archiver_unclassified.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Queue"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unclassified"
        '
        'btn_config_path_archiver_install
        '
        Me.btn_config_path_archiver_install.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_archiver_install.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_archiver_install.FlatAppearance.BorderSize = 0
        Me.btn_config_path_archiver_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_archiver_install.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_archiver_install.Location = New System.Drawing.Point(199, 10)
        Me.btn_config_path_archiver_install.Name = "btn_config_path_archiver_install"
        Me.btn_config_path_archiver_install.Size = New System.Drawing.Size(26, 20)
        Me.btn_config_path_archiver_install.TabIndex = 10
        Me.btn_config_path_archiver_install.Text = "..."
        Me.btn_config_path_archiver_install.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GFI PST Bulk Import Path"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_config_path_bulkimport_temp, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_config_path_bulkimport_logs, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_config_path_bulkimport_config, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_path_bulkimport_install, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_path_bulkimport_logs, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_path_bulkimport_config, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_path_bulkimport_temp, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_config_path_bulkimport_install, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(458, 81)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'btn_config_path_bulkimport_temp
        '
        Me.btn_config_path_bulkimport_temp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_bulkimport_temp.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_bulkimport_temp.FlatAppearance.BorderSize = 0
        Me.btn_config_path_bulkimport_temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_bulkimport_temp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_bulkimport_temp.Location = New System.Drawing.Point(427, 50)
        Me.btn_config_path_bulkimport_temp.Name = "btn_config_path_bulkimport_temp"
        Me.btn_config_path_bulkimport_temp.Size = New System.Drawing.Size(28, 20)
        Me.btn_config_path_bulkimport_temp.TabIndex = 13
        Me.btn_config_path_bulkimport_temp.Text = "..."
        Me.btn_config_path_bulkimport_temp.UseVisualStyleBackColor = False
        '
        'btn_config_path_bulkimport_logs
        '
        Me.btn_config_path_bulkimport_logs.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_bulkimport_logs.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_bulkimport_logs.FlatAppearance.BorderSize = 0
        Me.btn_config_path_bulkimport_logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_bulkimport_logs.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_bulkimport_logs.Location = New System.Drawing.Point(199, 50)
        Me.btn_config_path_bulkimport_logs.Name = "btn_config_path_bulkimport_logs"
        Me.btn_config_path_bulkimport_logs.Size = New System.Drawing.Size(26, 20)
        Me.btn_config_path_bulkimport_logs.TabIndex = 12
        Me.btn_config_path_bulkimport_logs.Text = "..."
        Me.btn_config_path_bulkimport_logs.UseVisualStyleBackColor = False
        '
        'btn_config_path_bulkimport_config
        '
        Me.btn_config_path_bulkimport_config.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_bulkimport_config.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_bulkimport_config.FlatAppearance.BorderSize = 0
        Me.btn_config_path_bulkimport_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_bulkimport_config.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_bulkimport_config.Location = New System.Drawing.Point(427, 10)
        Me.btn_config_path_bulkimport_config.Name = "btn_config_path_bulkimport_config"
        Me.btn_config_path_bulkimport_config.Size = New System.Drawing.Size(28, 20)
        Me.btn_config_path_bulkimport_config.TabIndex = 11
        Me.btn_config_path_bulkimport_config.Text = "..."
        Me.btn_config_path_bulkimport_config.UseVisualStyleBackColor = False
        '
        'txt_path_bulkimport_install
        '
        Me.txt_path_bulkimport_install.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_bulkimport_install.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_bulkimport_install.Location = New System.Drawing.Point(71, 10)
        Me.txt_path_bulkimport_install.Name = "txt_path_bulkimport_install"
        Me.txt_path_bulkimport_install.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_bulkimport_install.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Export"
        '
        'txt_path_bulkimport_logs
        '
        Me.txt_path_bulkimport_logs.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_bulkimport_logs.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_bulkimport_logs.Location = New System.Drawing.Point(71, 50)
        Me.txt_path_bulkimport_logs.Name = "txt_path_bulkimport_logs"
        Me.txt_path_bulkimport_logs.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_bulkimport_logs.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Install"
        '
        'txt_path_bulkimport_config
        '
        Me.txt_path_bulkimport_config.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_bulkimport_config.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_bulkimport_config.Location = New System.Drawing.Point(299, 10)
        Me.txt_path_bulkimport_config.Name = "txt_path_bulkimport_config"
        Me.txt_path_bulkimport_config.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_bulkimport_config.TabIndex = 7
        '
        'txt_path_bulkimport_temp
        '
        Me.txt_path_bulkimport_temp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_bulkimport_temp.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_bulkimport_temp.Location = New System.Drawing.Point(299, 50)
        Me.txt_path_bulkimport_temp.Name = "txt_path_bulkimport_temp"
        Me.txt_path_bulkimport_temp.Size = New System.Drawing.Size(122, 20)
        Me.txt_path_bulkimport_temp.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(231, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Config"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(231, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PST Temp"
        '
        'btn_config_path_bulkimport_install
        '
        Me.btn_config_path_bulkimport_install.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_config_path_bulkimport_install.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path_bulkimport_install.FlatAppearance.BorderSize = 0
        Me.btn_config_path_bulkimport_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path_bulkimport_install.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path_bulkimport_install.Location = New System.Drawing.Point(199, 10)
        Me.btn_config_path_bulkimport_install.Name = "btn_config_path_bulkimport_install"
        Me.btn_config_path_bulkimport_install.Size = New System.Drawing.Size(26, 20)
        Me.btn_config_path_bulkimport_install.TabIndex = 10
        Me.btn_config_path_bulkimport_install.Text = "..."
        Me.btn_config_path_bulkimport_install.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(10, 210)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 59)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Default PST Path"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_path_pstsource_default, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_path_pstsource_default, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(458, 40)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btn_path_pstsource_default
        '
        Me.btn_path_pstsource_default.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_path_pstsource_default.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_path_pstsource_default.FlatAppearance.BorderSize = 0
        Me.btn_path_pstsource_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_path_pstsource_default.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_path_pstsource_default.Location = New System.Drawing.Point(414, 10)
        Me.btn_path_pstsource_default.Name = "btn_path_pstsource_default"
        Me.btn_path_pstsource_default.Size = New System.Drawing.Size(27, 20)
        Me.btn_path_pstsource_default.TabIndex = 14
        Me.btn_path_pstsource_default.Text = "..."
        Me.btn_path_pstsource_default.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 26)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "PST Source Location"
        '
        'txt_path_pstsource_default
        '
        Me.txt_path_pstsource_default.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_path_pstsource_default.BackColor = System.Drawing.Color.LightGray
        Me.txt_path_pstsource_default.Location = New System.Drawing.Point(117, 10)
        Me.txt_path_pstsource_default.Name = "txt_path_pstsource_default"
        Me.txt_path_pstsource_default.Size = New System.Drawing.Size(291, 20)
        Me.txt_path_pstsource_default.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_config_path
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(484, 429)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_config_path"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frm_config_path"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_path_archiver_unclassified As TextBox
    Friend WithEvents txt_path_archiver_install As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_path_archiver_pickup As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_path_bulkimport_temp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_path_bulkimport_config As TextBox
    Friend WithEvents txt_path_bulkimport_install As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_path_bulkimport_logs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_path_pstsource_default As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_config_path_archiver_unclassified As Button
    Friend WithEvents btn_config_path_archiver_pickup As Button
    Friend WithEvents btn_config_path_archiver_queue As Button
    Friend WithEvents txt_path_archiver_queue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_config_path_archiver_install As Button
    Friend WithEvents btn_config_path_bulkimport_temp As Button
    Friend WithEvents btn_config_path_bulkimport_logs As Button
    Friend WithEvents btn_config_path_bulkimport_config As Button
    Friend WithEvents btn_config_path_bulkimport_install As Button
    Friend WithEvents btn_path_pstsource_default As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents fbd_config_path As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
