<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_config_auth
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbx_config_auth_2fa = New System.Windows.Forms.CheckBox()
        Me.grpbox_config_auth_test2fa = New System.Windows.Forms.GroupBox()
        Me.txt_config_auth_2fa_output = New System.Windows.Forms.TextBox()
        Me.btn_config_auth_test = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_config_auth_otp = New System.Windows.Forms.TextBox()
        Me.grpbox_config_auth_2fa_settings = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_config_auth_secretkey = New System.Windows.Forms.TextBox()
        Me.txt_config_auth_clientid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_config_auth_test2fa.SuspendLayout()
        Me.grpbox_config_auth_2fa_settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.cbx_config_auth_2fa)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 94)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Two Factor Authentication"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.GFI_PST_Bulk_Import.My.Resources.Resources.Yubico_Logo_Small1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(458, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cbx_config_auth_2fa
        '
        Me.cbx_config_auth_2fa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_config_auth_2fa.AutoSize = True
        Me.cbx_config_auth_2fa.BackColor = System.Drawing.Color.DarkGray
        Me.cbx_config_auth_2fa.FlatAppearance.BorderSize = 0
        Me.cbx_config_auth_2fa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_config_auth_2fa.Location = New System.Drawing.Point(42, 72)
        Me.cbx_config_auth_2fa.Name = "cbx_config_auth_2fa"
        Me.cbx_config_auth_2fa.Size = New System.Drawing.Size(366, 17)
        Me.cbx_config_auth_2fa.TabIndex = 0
        Me.cbx_config_auth_2fa.Text = "Enable 2 Factor authentication powered by Yubico Cloud / Yubikey OTP"
        Me.cbx_config_auth_2fa.UseVisualStyleBackColor = False
        '
        'grpbox_config_auth_test2fa
        '
        Me.grpbox_config_auth_test2fa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpbox_config_auth_test2fa.Controls.Add(Me.txt_config_auth_2fa_output)
        Me.grpbox_config_auth_test2fa.Controls.Add(Me.btn_config_auth_test)
        Me.grpbox_config_auth_test2fa.Controls.Add(Me.Label1)
        Me.grpbox_config_auth_test2fa.Controls.Add(Me.txt_config_auth_otp)
        Me.grpbox_config_auth_test2fa.Location = New System.Drawing.Point(10, 182)
        Me.grpbox_config_auth_test2fa.Name = "grpbox_config_auth_test2fa"
        Me.grpbox_config_auth_test2fa.Size = New System.Drawing.Size(464, 237)
        Me.grpbox_config_auth_test2fa.TabIndex = 4
        Me.grpbox_config_auth_test2fa.TabStop = False
        Me.grpbox_config_auth_test2fa.Text = "Test your 2FA"
        Me.grpbox_config_auth_test2fa.Visible = False
        '
        'txt_config_auth_2fa_output
        '
        Me.txt_config_auth_2fa_output.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_config_auth_2fa_output.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_config_auth_2fa_output.Location = New System.Drawing.Point(9, 48)
        Me.txt_config_auth_2fa_output.Multiline = True
        Me.txt_config_auth_2fa_output.Name = "txt_config_auth_2fa_output"
        Me.txt_config_auth_2fa_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_config_auth_2fa_output.Size = New System.Drawing.Size(449, 178)
        Me.txt_config_auth_2fa_output.TabIndex = 3
        '
        'btn_config_auth_test
        '
        Me.btn_config_auth_test.Location = New System.Drawing.Point(383, 22)
        Me.btn_config_auth_test.Name = "btn_config_auth_test"
        Me.btn_config_auth_test.Size = New System.Drawing.Size(75, 20)
        Me.btn_config_auth_test.TabIndex = 2
        Me.btn_config_auth_test.Text = "Test"
        Me.btn_config_auth_test.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OTP:"
        '
        'txt_config_auth_otp
        '
        Me.txt_config_auth_otp.BackColor = System.Drawing.Color.LightGray
        Me.txt_config_auth_otp.Location = New System.Drawing.Point(44, 22)
        Me.txt_config_auth_otp.Name = "txt_config_auth_otp"
        Me.txt_config_auth_otp.Size = New System.Drawing.Size(333, 20)
        Me.txt_config_auth_otp.TabIndex = 0
        '
        'grpbox_config_auth_2fa_settings
        '
        Me.grpbox_config_auth_2fa_settings.Controls.Add(Me.Label4)
        Me.grpbox_config_auth_2fa_settings.Controls.Add(Me.txt_config_auth_secretkey)
        Me.grpbox_config_auth_2fa_settings.Controls.Add(Me.txt_config_auth_clientid)
        Me.grpbox_config_auth_2fa_settings.Controls.Add(Me.Label3)
        Me.grpbox_config_auth_2fa_settings.Controls.Add(Me.Label2)
        Me.grpbox_config_auth_2fa_settings.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpbox_config_auth_2fa_settings.Location = New System.Drawing.Point(10, 104)
        Me.grpbox_config_auth_2fa_settings.Name = "grpbox_config_auth_2fa_settings"
        Me.grpbox_config_auth_2fa_settings.Size = New System.Drawing.Size(464, 72)
        Me.grpbox_config_auth_2fa_settings.TabIndex = 5
        Me.grpbox_config_auth_2fa_settings.TabStop = False
        Me.grpbox_config_auth_2fa_settings.Text = "Yubico Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(452, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "To get a Client ID and Secret Key, please register on https://upgrade.yubico.com/" &
    "getapikey/  "
        '
        'txt_config_auth_secretkey
        '
        Me.txt_config_auth_secretkey.BackColor = System.Drawing.Color.LightGray
        Me.txt_config_auth_secretkey.Location = New System.Drawing.Point(250, 17)
        Me.txt_config_auth_secretkey.Name = "txt_config_auth_secretkey"
        Me.txt_config_auth_secretkey.Size = New System.Drawing.Size(196, 20)
        Me.txt_config_auth_secretkey.TabIndex = 3
        Me.txt_config_auth_secretkey.UseSystemPasswordChar = True
        '
        'txt_config_auth_clientid
        '
        Me.txt_config_auth_clientid.BackColor = System.Drawing.Color.LightGray
        Me.txt_config_auth_clientid.Location = New System.Drawing.Point(60, 17)
        Me.txt_config_auth_clientid.Name = "txt_config_auth_clientid"
        Me.txt_config_auth_clientid.Size = New System.Drawing.Size(119, 20)
        Me.txt_config_auth_clientid.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Secret Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Client ID"
        '
        'frm_config_auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(484, 429)
        Me.Controls.Add(Me.grpbox_config_auth_2fa_settings)
        Me.Controls.Add(Me.grpbox_config_auth_test2fa)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_config_auth"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frm_config_auth"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_config_auth_test2fa.ResumeLayout(False)
        Me.grpbox_config_auth_test2fa.PerformLayout()
        Me.grpbox_config_auth_2fa_settings.ResumeLayout(False)
        Me.grpbox_config_auth_2fa_settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbx_config_auth_2fa As CheckBox
    Friend WithEvents grpbox_config_auth_test2fa As GroupBox
    Friend WithEvents btn_config_auth_test As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_config_auth_otp As TextBox
    Friend WithEvents txt_config_auth_2fa_output As TextBox
    Friend WithEvents grpbox_config_auth_2fa_settings As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_config_auth_secretkey As TextBox
    Friend WithEvents txt_config_auth_clientid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
