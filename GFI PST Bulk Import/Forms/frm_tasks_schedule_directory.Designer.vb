<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_tasks_schedule_directory
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
        Me.txt_task_directory_ldap_path = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbx_task_directory_use_default = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_task_schedule_directory_path = New System.Windows.Forms.TextBox()
        Me.btn_tasks_schedule_directory_path = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_task_directory_recursive = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbx_task_directory_incl_sub = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.txt_task_directory_ldap_path)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LDAP path"
        '
        'txt_task_directory_ldap_path
        '
        Me.txt_task_directory_ldap_path.BackColor = System.Drawing.Color.LightGray
        Me.txt_task_directory_ldap_path.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_task_directory_ldap_path.Location = New System.Drawing.Point(3, 16)
        Me.txt_task_directory_ldap_path.Name = "txt_task_directory_ldap_path"
        Me.txt_task_directory_ldap_path.Size = New System.Drawing.Size(278, 20)
        Me.txt_task_directory_ldap_path.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.cbx_task_directory_use_default)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 40)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Use default path"
        '
        'cbx_task_directory_use_default
        '
        Me.cbx_task_directory_use_default.AutoSize = True
        Me.cbx_task_directory_use_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_task_directory_use_default.Location = New System.Drawing.Point(12, 19)
        Me.cbx_task_directory_use_default.Name = "cbx_task_directory_use_default"
        Me.cbx_task_directory_use_default.Size = New System.Drawing.Size(12, 11)
        Me.cbx_task_directory_use_default.TabIndex = 0
        Me.cbx_task_directory_use_default.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 47)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Path"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_task_schedule_directory_path, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_tasks_schedule_directory_path, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(278, 28)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'txt_task_schedule_directory_path
        '
        Me.txt_task_schedule_directory_path.BackColor = System.Drawing.Color.LightGray
        Me.txt_task_schedule_directory_path.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_task_schedule_directory_path.Location = New System.Drawing.Point(3, 3)
        Me.txt_task_schedule_directory_path.Name = "txt_task_schedule_directory_path"
        Me.txt_task_schedule_directory_path.Size = New System.Drawing.Size(230, 20)
        Me.txt_task_schedule_directory_path.TabIndex = 0
        '
        'btn_tasks_schedule_directory_path
        '
        Me.btn_tasks_schedule_directory_path.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_tasks_schedule_directory_path.FlatAppearance.BorderSize = 0
        Me.btn_tasks_schedule_directory_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tasks_schedule_directory_path.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tasks_schedule_directory_path.Location = New System.Drawing.Point(239, 3)
        Me.btn_tasks_schedule_directory_path.Name = "btn_tasks_schedule_directory_path"
        Me.btn_tasks_schedule_directory_path.Size = New System.Drawing.Size(36, 20)
        Me.btn_tasks_schedule_directory_path.TabIndex = 1
        Me.btn_tasks_schedule_directory_path.Text = "..."
        Me.btn_tasks_schedule_directory_path.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.Controls.Add(Me.txt_task_directory_recursive)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 135)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(284, 51)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Max recursive path search"
        '
        'txt_task_directory_recursive
        '
        Me.txt_task_directory_recursive.BackColor = System.Drawing.Color.LightGray
        Me.txt_task_directory_recursive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_task_directory_recursive.Location = New System.Drawing.Point(3, 16)
        Me.txt_task_directory_recursive.Name = "txt_task_directory_recursive"
        Me.txt_task_directory_recursive.Size = New System.Drawing.Size(278, 20)
        Me.txt_task_directory_recursive.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox5.Controls.Add(Me.cbx_task_directory_incl_sub)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 186)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(284, 40)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Include sub directories"
        '
        'cbx_task_directory_incl_sub
        '
        Me.cbx_task_directory_incl_sub.AutoSize = True
        Me.cbx_task_directory_incl_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_task_directory_incl_sub.Location = New System.Drawing.Point(12, 19)
        Me.cbx_task_directory_incl_sub.Name = "cbx_task_directory_incl_sub"
        Me.cbx_task_directory_incl_sub.Size = New System.Drawing.Size(12, 11)
        Me.cbx_task_directory_incl_sub.TabIndex = 0
        Me.cbx_task_directory_incl_sub.UseVisualStyleBackColor = True
        '
        'frm_tasks_schedule_directory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(284, 228)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tasks_schedule_directory"
        Me.Text = "frm_tasks_schedule_new"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbx_task_directory_use_default As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_task_directory_ldap_path As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txt_task_schedule_directory_path As TextBox
    Friend WithEvents btn_tasks_schedule_directory_path As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_task_directory_recursive As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbx_task_directory_incl_sub As CheckBox
End Class
