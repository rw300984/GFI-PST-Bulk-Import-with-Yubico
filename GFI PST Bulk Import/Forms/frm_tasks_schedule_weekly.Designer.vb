<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tasks_schedule_weekly
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_tasks_schedule_weekly = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbx_tasks_schedule_weekly_thu = New System.Windows.Forms.CheckBox()
        Me.cbx_tasks_schedule_weekly_sun = New System.Windows.Forms.CheckBox()
        Me.cbx_tasks_schedule_weekly_wed = New System.Windows.Forms.CheckBox()
        Me.cbx_tasks_schedule_weekly_sat = New System.Windows.Forms.CheckBox()
        Me.cbx_tasks_schedule_weekly_fri = New System.Windows.Forms.CheckBox()
        Me.cbx_tasks_schedule_weekly_tue = New System.Windows.Forms.CheckBox()
        Me.cbx_tasks_schedule_weekly_mon = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtp_tasks_schedule_weekly, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(278, 127)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time"
        '
        'dtp_tasks_schedule_weekly
        '
        Me.dtp_tasks_schedule_weekly.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtp_tasks_schedule_weekly.CalendarMonthBackground = System.Drawing.Color.LightGray
        Me.dtp_tasks_schedule_weekly.CalendarTitleBackColor = System.Drawing.Color.LightGray
        Me.dtp_tasks_schedule_weekly.CustomFormat = "HH:mm:ss"
        Me.dtp_tasks_schedule_weekly.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tasks_schedule_weekly.Location = New System.Drawing.Point(44, 3)
        Me.dtp_tasks_schedule_weekly.Name = "dtp_tasks_schedule_weekly"
        Me.dtp_tasks_schedule_weekly.Size = New System.Drawing.Size(231, 20)
        Me.dtp_tasks_schedule_weekly.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Day"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.cbx_tasks_schedule_weekly_thu)
        Me.Panel1.Controls.Add(Me.cbx_tasks_schedule_weekly_sun)
        Me.Panel1.Controls.Add(Me.cbx_tasks_schedule_weekly_wed)
        Me.Panel1.Controls.Add(Me.cbx_tasks_schedule_weekly_sat)
        Me.Panel1.Controls.Add(Me.cbx_tasks_schedule_weekly_fri)
        Me.Panel1.Controls.Add(Me.cbx_tasks_schedule_weekly_tue)
        Me.Panel1.Controls.Add(Me.cbx_tasks_schedule_weekly_mon)
        Me.Panel1.Location = New System.Drawing.Point(44, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 92)
        Me.Panel1.TabIndex = 3
        '
        'cbx_tasks_schedule_weekly_thu
        '
        Me.cbx_tasks_schedule_weekly_thu.AutoSize = True
        Me.cbx_tasks_schedule_weekly_thu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_schedule_weekly_thu.Location = New System.Drawing.Point(3, 72)
        Me.cbx_tasks_schedule_weekly_thu.Name = "cbx_tasks_schedule_weekly_thu"
        Me.cbx_tasks_schedule_weekly_thu.Size = New System.Drawing.Size(67, 17)
        Me.cbx_tasks_schedule_weekly_thu.TabIndex = 6
        Me.cbx_tasks_schedule_weekly_thu.Text = "Thursday"
        Me.cbx_tasks_schedule_weekly_thu.UseVisualStyleBackColor = True
        '
        'cbx_tasks_schedule_weekly_sun
        '
        Me.cbx_tasks_schedule_weekly_sun.AutoSize = True
        Me.cbx_tasks_schedule_weekly_sun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_schedule_weekly_sun.Location = New System.Drawing.Point(90, 49)
        Me.cbx_tasks_schedule_weekly_sun.Name = "cbx_tasks_schedule_weekly_sun"
        Me.cbx_tasks_schedule_weekly_sun.Size = New System.Drawing.Size(59, 17)
        Me.cbx_tasks_schedule_weekly_sun.TabIndex = 5
        Me.cbx_tasks_schedule_weekly_sun.Text = "Sunday"
        Me.cbx_tasks_schedule_weekly_sun.UseVisualStyleBackColor = True
        '
        'cbx_tasks_schedule_weekly_wed
        '
        Me.cbx_tasks_schedule_weekly_wed.AutoSize = True
        Me.cbx_tasks_schedule_weekly_wed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_schedule_weekly_wed.Location = New System.Drawing.Point(3, 49)
        Me.cbx_tasks_schedule_weekly_wed.Name = "cbx_tasks_schedule_weekly_wed"
        Me.cbx_tasks_schedule_weekly_wed.Size = New System.Drawing.Size(80, 17)
        Me.cbx_tasks_schedule_weekly_wed.TabIndex = 4
        Me.cbx_tasks_schedule_weekly_wed.Text = "Wednesday"
        Me.cbx_tasks_schedule_weekly_wed.UseVisualStyleBackColor = True
        '
        'cbx_tasks_schedule_weekly_sat
        '
        Me.cbx_tasks_schedule_weekly_sat.AutoSize = True
        Me.cbx_tasks_schedule_weekly_sat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_schedule_weekly_sat.Location = New System.Drawing.Point(90, 26)
        Me.cbx_tasks_schedule_weekly_sat.Name = "cbx_tasks_schedule_weekly_sat"
        Me.cbx_tasks_schedule_weekly_sat.Size = New System.Drawing.Size(65, 17)
        Me.cbx_tasks_schedule_weekly_sat.TabIndex = 3
        Me.cbx_tasks_schedule_weekly_sat.Text = "Saturday"
        Me.cbx_tasks_schedule_weekly_sat.UseVisualStyleBackColor = True
        '
        'cbx_tasks_schedule_weekly_fri
        '
        Me.cbx_tasks_schedule_weekly_fri.AutoSize = True
        Me.cbx_tasks_schedule_weekly_fri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_schedule_weekly_fri.Location = New System.Drawing.Point(90, 3)
        Me.cbx_tasks_schedule_weekly_fri.Name = "cbx_tasks_schedule_weekly_fri"
        Me.cbx_tasks_schedule_weekly_fri.Size = New System.Drawing.Size(51, 17)
        Me.cbx_tasks_schedule_weekly_fri.TabIndex = 2
        Me.cbx_tasks_schedule_weekly_fri.Text = "Friday"
        Me.cbx_tasks_schedule_weekly_fri.UseVisualStyleBackColor = True
        '
        'cbx_tasks_schedule_weekly_tue
        '
        Me.cbx_tasks_schedule_weekly_tue.AutoSize = True
        Me.cbx_tasks_schedule_weekly_tue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_schedule_weekly_tue.Location = New System.Drawing.Point(3, 26)
        Me.cbx_tasks_schedule_weekly_tue.Name = "cbx_tasks_schedule_weekly_tue"
        Me.cbx_tasks_schedule_weekly_tue.Size = New System.Drawing.Size(64, 17)
        Me.cbx_tasks_schedule_weekly_tue.TabIndex = 1
        Me.cbx_tasks_schedule_weekly_tue.Text = "Tuesday"
        Me.cbx_tasks_schedule_weekly_tue.UseVisualStyleBackColor = True
        '
        'cbx_tasks_schedule_weekly_mon
        '
        Me.cbx_tasks_schedule_weekly_mon.AutoSize = True
        Me.cbx_tasks_schedule_weekly_mon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tasks_schedule_weekly_mon.Location = New System.Drawing.Point(3, 3)
        Me.cbx_tasks_schedule_weekly_mon.Name = "cbx_tasks_schedule_weekly_mon"
        Me.cbx_tasks_schedule_weekly_mon.Size = New System.Drawing.Size(61, 17)
        Me.cbx_tasks_schedule_weekly_mon.TabIndex = 0
        Me.cbx_tasks_schedule_weekly_mon.Text = "Monday"
        Me.cbx_tasks_schedule_weekly_mon.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 146)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schedule"
        '
        'frm_tasks_schedule_weekly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 146)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tasks_schedule_weekly"
        Me.Text = "frm_tasks_schedule_weekly"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_tasks_schedule_weekly As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbx_tasks_schedule_weekly_thu As CheckBox
    Friend WithEvents cbx_tasks_schedule_weekly_sun As CheckBox
    Friend WithEvents cbx_tasks_schedule_weekly_wed As CheckBox
    Friend WithEvents cbx_tasks_schedule_weekly_sat As CheckBox
    Friend WithEvents cbx_tasks_schedule_weekly_fri As CheckBox
    Friend WithEvents cbx_tasks_schedule_weekly_tue As CheckBox
    Friend WithEvents cbx_tasks_schedule_weekly_mon As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
