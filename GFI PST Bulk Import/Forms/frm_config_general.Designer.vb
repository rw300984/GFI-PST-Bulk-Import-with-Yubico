<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_config_general
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_general_language = New System.Windows.Forms.ComboBox()
        Me.txt_general_email_server = New System.Windows.Forms.TextBox()
        Me.txt_general_email_to = New System.Windows.Forms.TextBox()
        Me.txt_general_email_from = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_email_authentication = New System.Windows.Forms.CheckBox()
        Me.txt_general_email_user = New System.Windows.Forms.TextBox()
        Me.txt_general_email_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_config_general_test_email = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_timer = New System.Windows.Forms.Timer(Me.components)
        Me.tt_config_general = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbx_general_language)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 69)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Language"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Select your language"
        '
        'cbx_general_language
        '
        Me.cbx_general_language.BackColor = System.Drawing.Color.LightGray
        Me.cbx_general_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_general_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_general_language.FormattingEnabled = True
        Me.cbx_general_language.Items.AddRange(New Object() {"English"})
        Me.cbx_general_language.Location = New System.Drawing.Point(223, 29)
        Me.cbx_general_language.Margin = New System.Windows.Forms.Padding(0)
        Me.cbx_general_language.Name = "cbx_general_language"
        Me.cbx_general_language.Size = New System.Drawing.Size(121, 21)
        Me.cbx_general_language.TabIndex = 0
        Me.tt_config_general.SetToolTip(Me.cbx_general_language, "coming soon")
        '
        'txt_general_email_server
        '
        Me.txt_general_email_server.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_general_email_server.BackColor = System.Drawing.Color.LightGray
        Me.txt_general_email_server.Location = New System.Drawing.Point(71, 6)
        Me.txt_general_email_server.Name = "txt_general_email_server"
        Me.txt_general_email_server.Size = New System.Drawing.Size(154, 20)
        Me.txt_general_email_server.TabIndex = 1
        '
        'txt_general_email_to
        '
        Me.txt_general_email_to.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_general_email_to.BackColor = System.Drawing.Color.LightGray
        Me.txt_general_email_to.Location = New System.Drawing.Point(71, 70)
        Me.txt_general_email_to.Name = "txt_general_email_to"
        Me.txt_general_email_to.Size = New System.Drawing.Size(154, 20)
        Me.txt_general_email_to.TabIndex = 2
        '
        'txt_general_email_from
        '
        Me.txt_general_email_from.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_general_email_from.BackColor = System.Drawing.Color.LightGray
        Me.txt_general_email_from.Location = New System.Drawing.Point(71, 38)
        Me.txt_general_email_from.Name = "txt_general_email_from"
        Me.txt_general_email_from.Size = New System.Drawing.Size(154, 20)
        Me.txt_general_email_from.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To"
        '
        'cbx_email_authentication
        '
        Me.cbx_email_authentication.AutoSize = True
        Me.cbx_email_authentication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbx_email_authentication.FlatAppearance.BorderSize = 0
        Me.cbx_email_authentication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_email_authentication.Location = New System.Drawing.Point(299, 3)
        Me.cbx_email_authentication.Name = "cbx_email_authentication"
        Me.cbx_email_authentication.Size = New System.Drawing.Size(156, 26)
        Me.cbx_email_authentication.TabIndex = 8
        Me.cbx_email_authentication.Text = "Use authentication"
        Me.cbx_email_authentication.UseVisualStyleBackColor = True
        '
        'txt_general_email_user
        '
        Me.txt_general_email_user.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_general_email_user.BackColor = System.Drawing.Color.LightGray
        Me.txt_general_email_user.Location = New System.Drawing.Point(299, 38)
        Me.txt_general_email_user.Name = "txt_general_email_user"
        Me.txt_general_email_user.Size = New System.Drawing.Size(156, 20)
        Me.txt_general_email_user.TabIndex = 9
        '
        'txt_general_email_password
        '
        Me.txt_general_email_password.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_general_email_password.BackColor = System.Drawing.Color.LightGray
        Me.txt_general_email_password.Location = New System.Drawing.Point(299, 70)
        Me.txt_general_email_password.Name = "txt_general_email_password"
        Me.txt_general_email_password.Size = New System.Drawing.Size(156, 20)
        Me.txt_general_email_password.TabIndex = 10
        Me.txt_general_email_password.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "User"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'btn_config_general_test_email
        '
        Me.btn_config_general_test_email.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_general_test_email.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_config_general_test_email.FlatAppearance.BorderSize = 0
        Me.btn_config_general_test_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_general_test_email.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_general_test_email.Location = New System.Drawing.Point(3, 113)
        Me.btn_config_general_test_email.Name = "btn_config_general_test_email"
        Me.btn_config_general_test_email.Size = New System.Drawing.Size(458, 33)
        Me.btn_config_general_test_email.TabIndex = 0
        Me.btn_config_general_test_email.Text = "Test E-mail settings"
        Me.btn_config_general_test_email.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.btn_config_general_test_email)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "E-Mail Settings"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_general_email_server, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_general_email_password, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_general_email_user, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_general_email_from, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_email_authentication, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_general_email_to, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(458, 97)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'btn_timer
        '
        Me.btn_timer.Interval = 5000
        '
        'tt_config_general
        '
        Me.tt_config_general.IsBalloon = True
        Me.tt_config_general.ShowAlways = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 66)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Outlook details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Bit version"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightGray
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"x86", "x64"})
        Me.ComboBox1.Location = New System.Drawing.Point(204, 26)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        Me.tt_config_general.SetToolTip(Me.ComboBox1, "coming soon")
        '
        'frm_config_general
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(484, 429)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_config_general"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frm_config_general"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_general_language As ComboBox
    Friend WithEvents txt_general_email_to As TextBox
    Friend WithEvents txt_general_email_from As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_email_authentication As CheckBox
    Friend WithEvents txt_general_email_user As TextBox
    Friend WithEvents txt_general_email_password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_config_general_test_email As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Public WithEvents txt_general_email_server As TextBox
    Friend WithEvents btn_timer As Timer
    Friend WithEvents tt_config_general As ToolTip
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
