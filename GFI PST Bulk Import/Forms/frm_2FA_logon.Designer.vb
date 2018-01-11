<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_2FA_logon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_2FA_logon))
        Me.txt_2fa_otp = New System.Windows.Forms.TextBox()
        Me.groupbox_1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_2fa_login = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_2fa_status = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupbox_1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_2fa_otp
        '
        Me.txt_2fa_otp.BackColor = System.Drawing.Color.LightGray
        Me.txt_2fa_otp.Location = New System.Drawing.Point(44, 103)
        Me.txt_2fa_otp.Name = "txt_2fa_otp"
        Me.txt_2fa_otp.Size = New System.Drawing.Size(174, 20)
        Me.txt_2fa_otp.TabIndex = 0
        '
        'groupbox_1
        '
        Me.groupbox_1.Controls.Add(Me.TextBox2)
        Me.groupbox_1.Location = New System.Drawing.Point(10, 133)
        Me.groupbox_1.Name = "groupbox_1"
        Me.groupbox_1.Size = New System.Drawing.Size(262, 180)
        Me.groupbox_1.TabIndex = 2
        Me.groupbox_1.TabStop = False
        Me.groupbox_1.Text = "Instruction"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightGray
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(3, 16)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(256, 161)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "OTP"
        '
        'btn_2fa_login
        '
        Me.btn_2fa_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2fa_login.Location = New System.Drawing.Point(222, 103)
        Me.btn_2fa_login.Name = "btn_2fa_login"
        Me.btn_2fa_login.Size = New System.Drawing.Size(50, 20)
        Me.btn_2fa_login.TabIndex = 4
        Me.btn_2fa_login.Text = "Login"
        Me.btn_2fa_login.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_2fa_status)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 22)
        Me.Panel1.TabIndex = 5
        '
        'lbl_2fa_status
        '
        Me.lbl_2fa_status.AutoSize = True
        Me.lbl_2fa_status.Location = New System.Drawing.Point(7, 5)
        Me.lbl_2fa_status.Name = "lbl_2fa_status"
        Me.lbl_2fa_status.Size = New System.Drawing.Size(73, 13)
        Me.lbl_2fa_status.TabIndex = 0
        Me.lbl_2fa_status.Text = "Login status..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GFI_PST_Bulk_Import.My.Resources.Resources.Yubico_Logo_Small1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_2FA_logon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 341)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_2fa_login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groupbox_1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_2fa_otp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_2FA_logon"
        Me.Text = "GFI PST Exporter with Yubikey"
        Me.groupbox_1.ResumeLayout(False)
        Me.groupbox_1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_2fa_otp As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents groupbox_1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_2fa_login As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_2fa_status As Label
End Class
