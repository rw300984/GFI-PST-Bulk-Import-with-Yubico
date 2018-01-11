<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_tasks_schedule_file
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_task_file_use_default = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_task_file_path = New System.Windows.Forms.TextBox()
        Me.btn_tasks_schedule_file_path = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_task_incl_sub = New System.Windows.Forms.CheckBox()
        Me.lbl_task_schedule_file_email_domain = New System.Windows.Forms.Label()
        Me.txt_task_schedule_file_email_domain = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Use default path"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cbx_task_file_use_default, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(294, 26)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'cbx_task_file_use_default
        '
        Me.cbx_task_file_use_default.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_task_file_use_default.AutoSize = True
        Me.cbx_task_file_use_default.BackColor = System.Drawing.Color.LightGray
        Me.cbx_task_file_use_default.FlatAppearance.BorderSize = 0
        Me.cbx_task_file_use_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_task_file_use_default.Location = New System.Drawing.Point(3, 7)
        Me.cbx_task_file_use_default.Name = "cbx_task_file_use_default"
        Me.cbx_task_file_use_default.Size = New System.Drawing.Size(12, 11)
        Me.cbx_task_file_use_default.TabIndex = 0
        Me.cbx_task_file_use_default.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 55)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Path"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(294, 36)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_task_file_path, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_tasks_schedule_file_path, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(288, 30)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'txt_task_file_path
        '
        Me.txt_task_file_path.BackColor = System.Drawing.Color.LightGray
        Me.txt_task_file_path.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_task_file_path.Location = New System.Drawing.Point(3, 3)
        Me.txt_task_file_path.Name = "txt_task_file_path"
        Me.txt_task_file_path.Size = New System.Drawing.Size(238, 20)
        Me.txt_task_file_path.TabIndex = 0
        '
        'btn_tasks_schedule_file_path
        '
        Me.btn_tasks_schedule_file_path.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_tasks_schedule_file_path.FlatAppearance.BorderSize = 0
        Me.btn_tasks_schedule_file_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tasks_schedule_file_path.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tasks_schedule_file_path.Location = New System.Drawing.Point(247, 3)
        Me.btn_tasks_schedule_file_path.Name = "btn_tasks_schedule_file_path"
        Me.btn_tasks_schedule_file_path.Size = New System.Drawing.Size(38, 20)
        Me.btn_tasks_schedule_file_path.TabIndex = 1
        Me.btn_tasks_schedule_file_path.Text = "..."
        Me.btn_tasks_schedule_file_path.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 47)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_task_incl_sub, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_task_schedule_file_email_domain, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_task_schedule_file_email_domain, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(294, 26)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cbx_task_incl_sub
        '
        Me.cbx_task_incl_sub.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_task_incl_sub.AutoSize = True
        Me.cbx_task_incl_sub.BackColor = System.Drawing.Color.DarkGray
        Me.cbx_task_incl_sub.FlatAppearance.BorderSize = 0
        Me.cbx_task_incl_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_task_incl_sub.Location = New System.Drawing.Point(3, 4)
        Me.cbx_task_incl_sub.Name = "cbx_task_incl_sub"
        Me.cbx_task_incl_sub.Size = New System.Drawing.Size(62, 17)
        Me.cbx_task_incl_sub.TabIndex = 0
        Me.cbx_task_incl_sub.Text = "incl. sub"
        Me.cbx_task_incl_sub.UseVisualStyleBackColor = False
        '
        'lbl_task_schedule_file_email_domain
        '
        Me.lbl_task_schedule_file_email_domain.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_task_schedule_file_email_domain.AutoSize = True
        Me.lbl_task_schedule_file_email_domain.Location = New System.Drawing.Point(82, 6)
        Me.lbl_task_schedule_file_email_domain.Name = "lbl_task_schedule_file_email_domain"
        Me.lbl_task_schedule_file_email_domain.Size = New System.Drawing.Size(75, 13)
        Me.lbl_task_schedule_file_email_domain.TabIndex = 1
        Me.lbl_task_schedule_file_email_domain.Text = "E-Mail Domain"
        '
        'txt_task_schedule_file_email_domain
        '
        Me.txt_task_schedule_file_email_domain.Location = New System.Drawing.Point(163, 3)
        Me.txt_task_schedule_file_email_domain.Name = "txt_task_schedule_file_email_domain"
        Me.txt_task_schedule_file_email_domain.Size = New System.Drawing.Size(128, 20)
        Me.txt_task_schedule_file_email_domain.TabIndex = 2
        '
        'frm_tasks_schedule_file
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(300, 149)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tasks_schedule_file"
        Me.Text = "frm_tasks_schedule_file"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cbx_task_file_use_default As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txt_task_file_path As TextBox
    Friend WithEvents btn_tasks_schedule_file_path As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbx_task_incl_sub As CheckBox
    Friend WithEvents lbl_task_schedule_file_email_domain As Label
    Friend WithEvents txt_task_schedule_file_email_domain As TextBox
End Class
