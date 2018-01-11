<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config_menu
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
        Me.btn_config_monitor = New System.Windows.Forms.Button()
        Me.btn_config_general = New System.Windows.Forms.Button()
        Me.btn_config_path = New System.Windows.Forms.Button()
        Me.btn_config_owner = New System.Windows.Forms.Button()
        Me.btn_config_tasks = New System.Windows.Forms.Button()
        Me.btn_config_advanced = New System.Windows.Forms.Button()
        Me.btn_timer = New System.Windows.Forms.Timer(Me.components)
        Me.btn_frm_main_save_settings = New System.Windows.Forms.Button()
        Me.btn_config_auth = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_config_monitor
        '
        Me.btn_config_monitor.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_monitor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_config_monitor.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_config_monitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_monitor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_monitor.Location = New System.Drawing.Point(0, 0)
        Me.btn_config_monitor.Name = "btn_config_monitor"
        Me.btn_config_monitor.Size = New System.Drawing.Size(120, 23)
        Me.btn_config_monitor.TabIndex = 1
        Me.btn_config_monitor.Text = "Monitor"
        Me.btn_config_monitor.UseVisualStyleBackColor = False
        '
        'btn_config_general
        '
        Me.btn_config_general.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_general.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_config_general.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_config_general.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_general.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_general.Location = New System.Drawing.Point(0, 23)
        Me.btn_config_general.Name = "btn_config_general"
        Me.btn_config_general.Size = New System.Drawing.Size(120, 23)
        Me.btn_config_general.TabIndex = 2
        Me.btn_config_general.Text = "General"
        Me.btn_config_general.UseVisualStyleBackColor = False
        '
        'btn_config_path
        '
        Me.btn_config_path.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_path.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_config_path.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_config_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_path.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_path.Location = New System.Drawing.Point(0, 46)
        Me.btn_config_path.Name = "btn_config_path"
        Me.btn_config_path.Size = New System.Drawing.Size(120, 23)
        Me.btn_config_path.TabIndex = 3
        Me.btn_config_path.Text = "Path"
        Me.btn_config_path.UseVisualStyleBackColor = False
        '
        'btn_config_owner
        '
        Me.btn_config_owner.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_owner.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_config_owner.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_config_owner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_owner.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_owner.Location = New System.Drawing.Point(0, 69)
        Me.btn_config_owner.Name = "btn_config_owner"
        Me.btn_config_owner.Size = New System.Drawing.Size(120, 23)
        Me.btn_config_owner.TabIndex = 4
        Me.btn_config_owner.Text = "Owner"
        Me.btn_config_owner.UseVisualStyleBackColor = False
        '
        'btn_config_tasks
        '
        Me.btn_config_tasks.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_tasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_config_tasks.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_config_tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_tasks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_tasks.Location = New System.Drawing.Point(0, 92)
        Me.btn_config_tasks.Name = "btn_config_tasks"
        Me.btn_config_tasks.Size = New System.Drawing.Size(120, 23)
        Me.btn_config_tasks.TabIndex = 6
        Me.btn_config_tasks.Text = "Tasks"
        Me.btn_config_tasks.UseVisualStyleBackColor = False
        '
        'btn_config_advanced
        '
        Me.btn_config_advanced.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_advanced.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_config_advanced.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_config_advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_advanced.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_advanced.Location = New System.Drawing.Point(0, 115)
        Me.btn_config_advanced.Name = "btn_config_advanced"
        Me.btn_config_advanced.Size = New System.Drawing.Size(120, 23)
        Me.btn_config_advanced.TabIndex = 7
        Me.btn_config_advanced.Text = "Advanced"
        Me.btn_config_advanced.UseVisualStyleBackColor = False
        Me.btn_config_advanced.Visible = False
        '
        'btn_timer
        '
        Me.btn_timer.Interval = 5000
        '
        'btn_frm_main_save_settings
        '
        Me.btn_frm_main_save_settings.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_frm_main_save_settings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_frm_main_save_settings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_frm_main_save_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_frm_main_save_settings.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_frm_main_save_settings.Location = New System.Drawing.Point(0, 188)
        Me.btn_frm_main_save_settings.Name = "btn_frm_main_save_settings"
        Me.btn_frm_main_save_settings.Size = New System.Drawing.Size(120, 23)
        Me.btn_frm_main_save_settings.TabIndex = 8
        Me.btn_frm_main_save_settings.Text = "Save settings"
        Me.btn_frm_main_save_settings.UseVisualStyleBackColor = False
        '
        'btn_config_auth
        '
        Me.btn_config_auth.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_config_auth.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_config_auth.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_config_auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config_auth.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_config_auth.Location = New System.Drawing.Point(0, 138)
        Me.btn_config_auth.Name = "btn_config_auth"
        Me.btn_config_auth.Size = New System.Drawing.Size(120, 23)
        Me.btn_config_auth.TabIndex = 9
        Me.btn_config_auth.Text = "Authentication"
        Me.btn_config_auth.UseVisualStyleBackColor = False
        '
        'frm_config_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(120, 211)
        Me.Controls.Add(Me.btn_config_auth)
        Me.Controls.Add(Me.btn_frm_main_save_settings)
        Me.Controls.Add(Me.btn_config_advanced)
        Me.Controls.Add(Me.btn_config_tasks)
        Me.Controls.Add(Me.btn_config_owner)
        Me.Controls.Add(Me.btn_config_path)
        Me.Controls.Add(Me.btn_config_general)
        Me.Controls.Add(Me.btn_config_monitor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_config_menu"
        Me.Text = "frm_config_menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_config_monitor As Button
    Friend WithEvents btn_config_general As Button
    Friend WithEvents btn_config_path As Button
    Friend WithEvents btn_config_owner As Button
    Friend WithEvents btn_config_tasks As Button
    Friend WithEvents btn_config_advanced As Button
    Friend WithEvents btn_timer As Timer
    Friend WithEvents btn_frm_main_save_settings As Button
    Friend WithEvents btn_config_auth As Button
End Class
