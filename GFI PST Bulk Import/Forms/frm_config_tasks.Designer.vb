<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config_tasks
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
        Me.rbtn_config_tasks_http_mode = New System.Windows.Forms.RadioButton()
        Me.rbtn_config_tasks_file_mode = New System.Windows.Forms.RadioButton()
        Me.grp_config_tasks_http_mode = New System.Windows.Forms.GroupBox()
        Me.btn_tasks_http_mode_test_connect = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_tasks_http_mode_protocol = New System.Windows.Forms.ComboBox()
        Me.txt_tasks_http_mode_url = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tasks_http_mode_user = New System.Windows.Forms.TextBox()
        Me.txt_tasks_http_mode_password = New System.Windows.Forms.TextBox()
        Me.tt_config_tasks = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grp_config_tasks_http_mode.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn_config_tasks_http_mode)
        Me.GroupBox1.Controls.Add(Me.rbtn_config_tasks_file_mode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Import Mode"
        '
        'rbtn_config_tasks_http_mode
        '
        Me.rbtn_config_tasks_http_mode.AutoSize = True
        Me.rbtn_config_tasks_http_mode.FlatAppearance.BorderSize = 0
        Me.rbtn_config_tasks_http_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_config_tasks_http_mode.Location = New System.Drawing.Point(239, 28)
        Me.rbtn_config_tasks_http_mode.Name = "rbtn_config_tasks_http_mode"
        Me.rbtn_config_tasks_http_mode.Size = New System.Drawing.Size(82, 17)
        Me.rbtn_config_tasks_http_mode.TabIndex = 1
        Me.rbtn_config_tasks_http_mode.TabStop = True
        Me.rbtn_config_tasks_http_mode.Text = "HTTP mode"
        Me.tt_config_tasks.SetToolTip(Me.rbtn_config_tasks_http_mode, "coming soon")
        Me.rbtn_config_tasks_http_mode.UseVisualStyleBackColor = True
        '
        'rbtn_config_tasks_file_mode
        '
        Me.rbtn_config_tasks_file_mode.AutoSize = True
        Me.rbtn_config_tasks_file_mode.FlatAppearance.BorderSize = 0
        Me.rbtn_config_tasks_file_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_config_tasks_file_mode.Location = New System.Drawing.Point(138, 28)
        Me.rbtn_config_tasks_file_mode.Name = "rbtn_config_tasks_file_mode"
        Me.rbtn_config_tasks_file_mode.Size = New System.Drawing.Size(69, 17)
        Me.rbtn_config_tasks_file_mode.TabIndex = 0
        Me.rbtn_config_tasks_file_mode.TabStop = True
        Me.rbtn_config_tasks_file_mode.Text = "File mode"
        Me.rbtn_config_tasks_file_mode.UseVisualStyleBackColor = True
        '
        'grp_config_tasks_http_mode
        '
        Me.grp_config_tasks_http_mode.Controls.Add(Me.btn_tasks_http_mode_test_connect)
        Me.grp_config_tasks_http_mode.Controls.Add(Me.TableLayoutPanel1)
        Me.grp_config_tasks_http_mode.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_config_tasks_http_mode.Location = New System.Drawing.Point(10, 85)
        Me.grp_config_tasks_http_mode.Name = "grp_config_tasks_http_mode"
        Me.grp_config_tasks_http_mode.Size = New System.Drawing.Size(448, 147)
        Me.grp_config_tasks_http_mode.TabIndex = 1
        Me.grp_config_tasks_http_mode.TabStop = False
        Me.grp_config_tasks_http_mode.Text = "HTTP Mode"
        '
        'btn_tasks_http_mode_test_connect
        '
        Me.btn_tasks_http_mode_test_connect.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_tasks_http_mode_test_connect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_tasks_http_mode_test_connect.FlatAppearance.BorderSize = 0
        Me.btn_tasks_http_mode_test_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tasks_http_mode_test_connect.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tasks_http_mode_test_connect.Location = New System.Drawing.Point(3, 116)
        Me.btn_tasks_http_mode_test_connect.Name = "btn_tasks_http_mode_test_connect"
        Me.btn_tasks_http_mode_test_connect.Size = New System.Drawing.Size(442, 28)
        Me.btn_tasks_http_mode_test_connect.TabIndex = 1
        Me.btn_tasks_http_mode_test_connect.Text = "Test connection"
        Me.btn_tasks_http_mode_test_connect.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_tasks_http_mode_protocol, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_tasks_http_mode_url, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_tasks_http_mode_user, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_tasks_http_mode_password, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Protocol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "URL"
        '
        'cbx_tasks_http_mode_protocol
        '
        Me.cbx_tasks_http_mode_protocol.BackColor = System.Drawing.Color.LightGray
        Me.cbx_tasks_http_mode_protocol.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbx_tasks_http_mode_protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tasks_http_mode_protocol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_http_mode_protocol.FormattingEnabled = True
        Me.cbx_tasks_http_mode_protocol.Items.AddRange(New Object() {"HTTP", "HTTPs"})
        Me.cbx_tasks_http_mode_protocol.Location = New System.Drawing.Point(69, 3)
        Me.cbx_tasks_http_mode_protocol.Name = "cbx_tasks_http_mode_protocol"
        Me.cbx_tasks_http_mode_protocol.Size = New System.Drawing.Size(148, 21)
        Me.cbx_tasks_http_mode_protocol.TabIndex = 2
        '
        'txt_tasks_http_mode_url
        '
        Me.txt_tasks_http_mode_url.BackColor = System.Drawing.Color.LightGray
        Me.txt_tasks_http_mode_url.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_tasks_http_mode_url.Location = New System.Drawing.Point(69, 53)
        Me.txt_tasks_http_mode_url.Name = "txt_tasks_http_mode_url"
        Me.txt_tasks_http_mode_url.Size = New System.Drawing.Size(148, 20)
        Me.txt_tasks_http_mode_url.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'txt_tasks_http_mode_user
        '
        Me.txt_tasks_http_mode_user.BackColor = System.Drawing.Color.LightGray
        Me.txt_tasks_http_mode_user.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_tasks_http_mode_user.Location = New System.Drawing.Point(289, 3)
        Me.txt_tasks_http_mode_user.Name = "txt_tasks_http_mode_user"
        Me.txt_tasks_http_mode_user.Size = New System.Drawing.Size(150, 20)
        Me.txt_tasks_http_mode_user.TabIndex = 6
        '
        'txt_tasks_http_mode_password
        '
        Me.txt_tasks_http_mode_password.BackColor = System.Drawing.Color.LightGray
        Me.txt_tasks_http_mode_password.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_tasks_http_mode_password.Location = New System.Drawing.Point(289, 53)
        Me.txt_tasks_http_mode_password.Name = "txt_tasks_http_mode_password"
        Me.txt_tasks_http_mode_password.Size = New System.Drawing.Size(150, 20)
        Me.txt_tasks_http_mode_password.TabIndex = 7
        Me.txt_tasks_http_mode_password.UseSystemPasswordChar = True
        '
        'frm_config_tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(468, 390)
        Me.Controls.Add(Me.grp_config_tasks_http_mode)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_config_tasks"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frm_config_tasks"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_config_tasks_http_mode.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn_config_tasks_http_mode As RadioButton
    Friend WithEvents rbtn_config_tasks_file_mode As RadioButton
    Friend WithEvents grp_config_tasks_http_mode As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_tasks_http_mode_test_connect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_tasks_http_mode_protocol As ComboBox
    Friend WithEvents txt_tasks_http_mode_url As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tasks_http_mode_user As TextBox
    Friend WithEvents txt_tasks_http_mode_password As TextBox
    Friend WithEvents tt_config_tasks As ToolTip
End Class
