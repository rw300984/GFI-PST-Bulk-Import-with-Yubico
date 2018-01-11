<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tasks_menu
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
        Me.btn_tasks_ondemand = New System.Windows.Forms.Button()
        Me.btn_tasks_schedule = New System.Windows.Forms.Button()
        Me.btn_tasks_simulate = New System.Windows.Forms.Button()
        Me.btn_frm_main_save_settings = New System.Windows.Forms.Button()
        Me.tt_task_menu = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btn_tasks_ondemand
        '
        Me.btn_tasks_ondemand.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_tasks_ondemand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_tasks_ondemand.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_tasks_ondemand.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_tasks_ondemand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tasks_ondemand.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tasks_ondemand.Location = New System.Drawing.Point(0, 0)
        Me.btn_tasks_ondemand.Name = "btn_tasks_ondemand"
        Me.btn_tasks_ondemand.Size = New System.Drawing.Size(120, 23)
        Me.btn_tasks_ondemand.TabIndex = 0
        Me.btn_tasks_ondemand.Text = "On demand"
        Me.btn_tasks_ondemand.UseVisualStyleBackColor = False
        '
        'btn_tasks_schedule
        '
        Me.btn_tasks_schedule.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_tasks_schedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_tasks_schedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_tasks_schedule.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_tasks_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tasks_schedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tasks_schedule.Location = New System.Drawing.Point(0, 23)
        Me.btn_tasks_schedule.Name = "btn_tasks_schedule"
        Me.btn_tasks_schedule.Size = New System.Drawing.Size(120, 23)
        Me.btn_tasks_schedule.TabIndex = 1
        Me.btn_tasks_schedule.Text = "Schedule"
        Me.tt_task_menu.SetToolTip(Me.btn_tasks_schedule, "coming soon")
        Me.btn_tasks_schedule.UseVisualStyleBackColor = False
        '
        'btn_tasks_simulate
        '
        Me.btn_tasks_simulate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_tasks_simulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_tasks_simulate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_tasks_simulate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_tasks_simulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tasks_simulate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tasks_simulate.Location = New System.Drawing.Point(0, 46)
        Me.btn_tasks_simulate.Name = "btn_tasks_simulate"
        Me.btn_tasks_simulate.Size = New System.Drawing.Size(120, 23)
        Me.btn_tasks_simulate.TabIndex = 2
        Me.btn_tasks_simulate.Text = "Simulation"
        Me.btn_tasks_simulate.UseVisualStyleBackColor = False
        Me.btn_tasks_simulate.Visible = False
        '
        'btn_frm_main_save_settings
        '
        Me.btn_frm_main_save_settings.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_frm_main_save_settings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_frm_main_save_settings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_frm_main_save_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_frm_main_save_settings.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_frm_main_save_settings.Location = New System.Drawing.Point(0, 92)
        Me.btn_frm_main_save_settings.Name = "btn_frm_main_save_settings"
        Me.btn_frm_main_save_settings.Size = New System.Drawing.Size(120, 23)
        Me.btn_frm_main_save_settings.TabIndex = 9
        Me.btn_frm_main_save_settings.Text = "Save settings"
        Me.btn_frm_main_save_settings.UseVisualStyleBackColor = False
        Me.btn_frm_main_save_settings.Visible = False
        '
        'tt_task_menu
        '
        Me.tt_task_menu.IsBalloon = True
        Me.tt_task_menu.ShowAlways = True
        '
        'frm_tasks_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(120, 115)
        Me.Controls.Add(Me.btn_frm_main_save_settings)
        Me.Controls.Add(Me.btn_tasks_simulate)
        Me.Controls.Add(Me.btn_tasks_schedule)
        Me.Controls.Add(Me.btn_tasks_ondemand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tasks_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_tasks_config"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_tasks_ondemand As Button
    Friend WithEvents btn_tasks_schedule As Button
    Friend WithEvents btn_tasks_simulate As Button
    Friend WithEvents btn_frm_main_save_settings As Button
    Friend WithEvents tt_task_menu As ToolTip
End Class
