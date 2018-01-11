<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config_owner
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
        Me.rbtn_config_owner_path_mode = New System.Windows.Forms.RadioButton()
        Me.rbtn_config_owner_directory_mode = New System.Windows.Forms.RadioButton()
        Me.grp_config_owner_directory_mode = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_owner_directory_mode_password = New System.Windows.Forms.TextBox()
        Me.txt_owner_directory_mode_server = New System.Windows.Forms.TextBox()
        Me.txt_owner_directory_mode_user = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_owner_directory_mode_port = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_owner_directory_mode_search_mode = New System.Windows.Forms.ComboBox()
        Me.txt_owner_directory_mode_search_field = New System.Windows.Forms.TextBox()
        Me.grp_config_owner_path_mode = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_owner_path_mode_user_variable = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tt_config_owner = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grp_config_owner_directory_mode.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grp_config_owner_path_mode.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn_config_owner_path_mode)
        Me.GroupBox1.Controls.Add(Me.rbtn_config_owner_directory_mode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Owner mode"
        '
        'rbtn_config_owner_path_mode
        '
        Me.rbtn_config_owner_path_mode.AutoSize = True
        Me.rbtn_config_owner_path_mode.FlatAppearance.BorderSize = 0
        Me.rbtn_config_owner_path_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_config_owner_path_mode.Location = New System.Drawing.Point(253, 19)
        Me.rbtn_config_owner_path_mode.Name = "rbtn_config_owner_path_mode"
        Me.rbtn_config_owner_path_mode.Size = New System.Drawing.Size(75, 17)
        Me.rbtn_config_owner_path_mode.TabIndex = 1
        Me.rbtn_config_owner_path_mode.TabStop = True
        Me.rbtn_config_owner_path_mode.Text = "Path mode"
        Me.rbtn_config_owner_path_mode.UseVisualStyleBackColor = True
        '
        'rbtn_config_owner_directory_mode
        '
        Me.rbtn_config_owner_directory_mode.AutoSize = True
        Me.rbtn_config_owner_directory_mode.FlatAppearance.BorderSize = 0
        Me.rbtn_config_owner_directory_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_config_owner_directory_mode.Location = New System.Drawing.Point(134, 19)
        Me.rbtn_config_owner_directory_mode.Name = "rbtn_config_owner_directory_mode"
        Me.rbtn_config_owner_directory_mode.Size = New System.Drawing.Size(95, 17)
        Me.rbtn_config_owner_directory_mode.TabIndex = 0
        Me.rbtn_config_owner_directory_mode.TabStop = True
        Me.rbtn_config_owner_directory_mode.Text = "Directory mode"
        Me.tt_config_owner.SetToolTip(Me.rbtn_config_owner_directory_mode, "coming soon")
        Me.rbtn_config_owner_directory_mode.UseVisualStyleBackColor = True
        '
        'grp_config_owner_directory_mode
        '
        Me.grp_config_owner_directory_mode.Controls.Add(Me.TableLayoutPanel1)
        Me.grp_config_owner_directory_mode.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_config_owner_directory_mode.Enabled = False
        Me.grp_config_owner_directory_mode.Location = New System.Drawing.Point(10, 62)
        Me.grp_config_owner_directory_mode.Name = "grp_config_owner_directory_mode"
        Me.grp_config_owner_directory_mode.Size = New System.Drawing.Size(448, 151)
        Me.grp_config_owner_directory_mode.TabIndex = 1
        Me.grp_config_owner_directory_mode.TabStop = False
        Me.grp_config_owner_directory_mode.Text = "Directory mode"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_owner_directory_mode_password, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_owner_directory_mode_server, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_owner_directory_mode_user, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_owner_directory_mode_port, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_owner_directory_mode_search_mode, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_owner_directory_mode_search_field, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 132)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(223, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 26)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Search field"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server"
        '
        'txt_owner_directory_mode_password
        '
        Me.txt_owner_directory_mode_password.BackColor = System.Drawing.Color.LightGray
        Me.txt_owner_directory_mode_password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_owner_directory_mode_password.Location = New System.Drawing.Point(289, 47)
        Me.txt_owner_directory_mode_password.Name = "txt_owner_directory_mode_password"
        Me.txt_owner_directory_mode_password.Size = New System.Drawing.Size(150, 20)
        Me.txt_owner_directory_mode_password.TabIndex = 7
        Me.txt_owner_directory_mode_password.UseSystemPasswordChar = True
        '
        'txt_owner_directory_mode_server
        '
        Me.txt_owner_directory_mode_server.BackColor = System.Drawing.Color.LightGray
        Me.txt_owner_directory_mode_server.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_owner_directory_mode_server.Location = New System.Drawing.Point(69, 3)
        Me.txt_owner_directory_mode_server.Name = "txt_owner_directory_mode_server"
        Me.txt_owner_directory_mode_server.Size = New System.Drawing.Size(148, 20)
        Me.txt_owner_directory_mode_server.TabIndex = 1
        '
        'txt_owner_directory_mode_user
        '
        Me.txt_owner_directory_mode_user.BackColor = System.Drawing.Color.LightGray
        Me.txt_owner_directory_mode_user.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_owner_directory_mode_user.Location = New System.Drawing.Point(289, 3)
        Me.txt_owner_directory_mode_user.Name = "txt_owner_directory_mode_user"
        Me.txt_owner_directory_mode_user.Size = New System.Drawing.Size(150, 20)
        Me.txt_owner_directory_mode_user.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'txt_owner_directory_mode_port
        '
        Me.txt_owner_directory_mode_port.BackColor = System.Drawing.Color.LightGray
        Me.txt_owner_directory_mode_port.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_owner_directory_mode_port.Location = New System.Drawing.Point(69, 47)
        Me.txt_owner_directory_mode_port.Name = "txt_owner_directory_mode_port"
        Me.txt_owner_directory_mode_port.Size = New System.Drawing.Size(148, 20)
        Me.txt_owner_directory_mode_port.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Search mode"
        '
        'cbx_owner_directory_mode_search_mode
        '
        Me.cbx_owner_directory_mode_search_mode.BackColor = System.Drawing.Color.LightGray
        Me.cbx_owner_directory_mode_search_mode.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbx_owner_directory_mode_search_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_owner_directory_mode_search_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_owner_directory_mode_search_mode.FormattingEnabled = True
        Me.cbx_owner_directory_mode_search_mode.Items.AddRange(New Object() {"Root only", "Recursive search"})
        Me.cbx_owner_directory_mode_search_mode.Location = New System.Drawing.Point(69, 91)
        Me.cbx_owner_directory_mode_search_mode.Name = "cbx_owner_directory_mode_search_mode"
        Me.cbx_owner_directory_mode_search_mode.Size = New System.Drawing.Size(148, 21)
        Me.cbx_owner_directory_mode_search_mode.TabIndex = 9
        '
        'txt_owner_directory_mode_search_field
        '
        Me.txt_owner_directory_mode_search_field.BackColor = System.Drawing.Color.LightGray
        Me.txt_owner_directory_mode_search_field.Location = New System.Drawing.Point(289, 91)
        Me.txt_owner_directory_mode_search_field.Name = "txt_owner_directory_mode_search_field"
        Me.txt_owner_directory_mode_search_field.Size = New System.Drawing.Size(150, 20)
        Me.txt_owner_directory_mode_search_field.TabIndex = 10
        '
        'grp_config_owner_path_mode
        '
        Me.grp_config_owner_path_mode.Controls.Add(Me.TableLayoutPanel2)
        Me.grp_config_owner_path_mode.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_config_owner_path_mode.Location = New System.Drawing.Point(10, 213)
        Me.grp_config_owner_path_mode.Name = "grp_config_owner_path_mode"
        Me.grp_config_owner_path_mode.Size = New System.Drawing.Size(448, 57)
        Me.grp_config_owner_path_mode.TabIndex = 2
        Me.grp_config_owner_path_mode.TabStop = False
        Me.grp_config_owner_path_mode.Text = "Path mode"
        Me.grp_config_owner_path_mode.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 387.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_owner_path_mode_user_variable, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(442, 38)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'txt_owner_path_mode_user_variable
        '
        Me.txt_owner_path_mode_user_variable.BackColor = System.Drawing.Color.LightGray
        Me.txt_owner_path_mode_user_variable.Location = New System.Drawing.Point(78, 3)
        Me.txt_owner_path_mode_user_variable.Name = "txt_owner_path_mode_user_variable"
        Me.txt_owner_path_mode_user_variable.Size = New System.Drawing.Size(248, 20)
        Me.txt_owner_path_mode_user_variable.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "User variable"
        '
        'frm_config_owner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(468, 390)
        Me.Controls.Add(Me.grp_config_owner_path_mode)
        Me.Controls.Add(Me.grp_config_owner_directory_mode)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_config_owner"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frm_config_owner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_config_owner_directory_mode.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grp_config_owner_path_mode.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn_config_owner_path_mode As RadioButton
    Friend WithEvents rbtn_config_owner_directory_mode As RadioButton
    Friend WithEvents grp_config_owner_directory_mode As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txt_owner_directory_mode_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_owner_directory_mode_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_owner_directory_mode_port As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_owner_directory_mode_server As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grp_config_owner_path_mode As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txt_owner_path_mode_user_variable As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_owner_directory_mode_search_mode As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_owner_directory_mode_search_field As TextBox
    Friend WithEvents tt_config_owner As ToolTip
End Class
