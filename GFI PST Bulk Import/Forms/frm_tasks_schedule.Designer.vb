<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tasks_schedule
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Weekly")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Yearly")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Scheduled Tasks", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tv_tasks_schedule = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_tasks_schedule_save = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tasks_schedule_description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tasks_schedule_name = New System.Windows.Forms.TextBox()
        Me.cbx_tasks_schedule_category = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.tv_tasks_schedule)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(349, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 409)
        Me.Panel1.TabIndex = 0
        '
        'tv_tasks_schedule
        '
        Me.tv_tasks_schedule.BackColor = System.Drawing.Color.DimGray
        Me.tv_tasks_schedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tv_tasks_schedule.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tv_tasks_schedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv_tasks_schedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tv_tasks_schedule.Location = New System.Drawing.Point(0, 0)
        Me.tv_tasks_schedule.Name = "tv_tasks_schedule"
        TreeNode1.Name = "Daily"
        TreeNode1.Text = "Daily"
        TreeNode2.Name = "Weekly"
        TreeNode2.Text = "Weekly"
        TreeNode3.Name = "Monthly"
        TreeNode3.Text = "Monthly"
        TreeNode4.Name = "Yearly"
        TreeNode4.Text = "Yearly"
        TreeNode5.Name = "Scheduled Tasks"
        TreeNode5.Text = "Scheduled Tasks"
        Me.tv_tasks_schedule.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5})
        Me.tv_tasks_schedule.Size = New System.Drawing.Size(125, 409)
        Me.tv_tasks_schedule.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ContextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(0, 0)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTaskToolStripMenuItem, Me.DeleteTaskToolStripMenuItem, Me.RunTaskToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(107, 70)
        '
        'AddTaskToolStripMenuItem
        '
        Me.AddTaskToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddTaskToolStripMenuItem.Enabled = False
        Me.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem"
        Me.AddTaskToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.AddTaskToolStripMenuItem.Text = "Add task"
        '
        'DeleteTaskToolStripMenuItem
        '
        Me.DeleteTaskToolStripMenuItem.Enabled = False
        Me.DeleteTaskToolStripMenuItem.Name = "DeleteTaskToolStripMenuItem"
        Me.DeleteTaskToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DeleteTaskToolStripMenuItem.Text = "Delete task"
        '
        'RunTaskToolStripMenuItem
        '
        Me.RunTaskToolStripMenuItem.Enabled = False
        Me.RunTaskToolStripMenuItem.Name = "RunTaskToolStripMenuItem"
        Me.RunTaskToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.RunTaskToolStripMenuItem.Text = "Run task"
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_tasks_schedule_save)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 409)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 237)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(333, 149)
        Me.Panel3.TabIndex = 3
        '
        'btn_tasks_schedule_save
        '
        Me.btn_tasks_schedule_save.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_tasks_schedule_save.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_tasks_schedule_save.FlatAppearance.BorderSize = 0
        Me.btn_tasks_schedule_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tasks_schedule_save.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tasks_schedule_save.Location = New System.Drawing.Point(0, 386)
        Me.btn_tasks_schedule_save.Name = "btn_tasks_schedule_save"
        Me.btn_tasks_schedule_save.Size = New System.Drawing.Size(333, 23)
        Me.btn_tasks_schedule_save.TabIndex = 2
        Me.btn_tasks_schedule_save.Text = "Button1"
        Me.btn_tasks_schedule_save.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(0, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Schedule"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_tasks_schedule_description, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_tasks_schedule_name, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_tasks_schedule_category, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(327, 87)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category"
        '
        'txt_tasks_schedule_description
        '
        Me.txt_tasks_schedule_description.BackColor = System.Drawing.Color.LightGray
        Me.txt_tasks_schedule_description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_tasks_schedule_description.Location = New System.Drawing.Point(84, 32)
        Me.txt_tasks_schedule_description.Multiline = True
        Me.txt_tasks_schedule_description.Name = "txt_tasks_schedule_description"
        Me.txt_tasks_schedule_description.Size = New System.Drawing.Size(240, 23)
        Me.txt_tasks_schedule_description.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Task name"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'txt_tasks_schedule_name
        '
        Me.txt_tasks_schedule_name.BackColor = System.Drawing.Color.LightGray
        Me.txt_tasks_schedule_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_tasks_schedule_name.Location = New System.Drawing.Point(84, 3)
        Me.txt_tasks_schedule_name.Name = "txt_tasks_schedule_name"
        Me.txt_tasks_schedule_name.Size = New System.Drawing.Size(240, 20)
        Me.txt_tasks_schedule_name.TabIndex = 2
        '
        'cbx_tasks_schedule_category
        '
        Me.cbx_tasks_schedule_category.BackColor = System.Drawing.Color.LightGray
        Me.cbx_tasks_schedule_category.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbx_tasks_schedule_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tasks_schedule_category.FormattingEnabled = True
        Me.cbx_tasks_schedule_category.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Yearly"})
        Me.cbx_tasks_schedule_category.Location = New System.Drawing.Point(84, 61)
        Me.cbx_tasks_schedule_category.Name = "cbx_tasks_schedule_category"
        Me.cbx_tasks_schedule_category.Size = New System.Drawing.Size(240, 21)
        Me.cbx_tasks_schedule_category.TabIndex = 5
        '
        'frm_tasks_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(484, 429)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tasks_schedule"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frm_tasks_schedule"
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tv_tasks_schedule As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_tasks_schedule_description As TextBox
    Friend WithEvents txt_tasks_schedule_name As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_tasks_schedule_save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_tasks_schedule_category As ComboBox
    Friend WithEvents Panel3 As Panel
End Class
