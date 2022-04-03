<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BasePanel = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddTaskB = New System.Windows.Forms.Button()
        Me.ViewTaskB = New System.Windows.Forms.Button()
        Me.DeleteTaskB = New System.Windows.Forms.Button()
        Me.SoonB = New System.Windows.Forms.Button()
        Me.AddTaskL = New System.Windows.Forms.Label()
        Me.ViewTaskL = New System.Windows.Forms.Label()
        Me.DeleteTaskL = New System.Windows.Forms.Label()
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TaskManagementL = New System.Windows.Forms.Label()
        Me.BasePanel.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BasePanel
        '
        Me.BasePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BasePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BasePanel.Controls.Add(Me.Splitter1)
        Me.BasePanel.Controls.Add(Me.ButtonPanel)
        Me.BasePanel.Controls.Add(Me.AnimationPanel)
        Me.BasePanel.Location = New System.Drawing.Point(3, 80)
        Me.BasePanel.Name = "BasePanel"
        Me.BasePanel.Size = New System.Drawing.Size(959, 585)
        Me.BasePanel.TabIndex = 5
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.BlueViolet
        Me.Splitter1.Location = New System.Drawing.Point(600, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 585)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonPanel.Location = New System.Drawing.Point(0, 0)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(600, 585)
        Me.ButtonPanel.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AddTaskB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTaskB, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteTaskB, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SoonB, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AddTaskL, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTaskL, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteTaskL, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 585)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'AddTaskB
        '
        Me.AddTaskB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddTaskB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.AddTaskB
        Me.AddTaskB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.AddTaskB.FlatAppearance.BorderSize = 2
        Me.AddTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.AddTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTaskB.Location = New System.Drawing.Point(93, 90)
        Me.AddTaskB.Name = "AddTaskB"
        Me.AddTaskB.Size = New System.Drawing.Size(162, 157)
        Me.AddTaskB.TabIndex = 2
        Me.AddTaskB.UseVisualStyleBackColor = True
        '
        'ViewTaskB
        '
        Me.ViewTaskB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewTaskB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.ViewTaskB
        Me.ViewTaskB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.ViewTaskB.FlatAppearance.BorderSize = 2
        Me.ViewTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.ViewTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTaskB.Location = New System.Drawing.Point(345, 90)
        Me.ViewTaskB.Name = "ViewTaskB"
        Me.ViewTaskB.Size = New System.Drawing.Size(162, 157)
        Me.ViewTaskB.TabIndex = 2
        Me.ViewTaskB.UseVisualStyleBackColor = True
        '
        'DeleteTaskB
        '
        Me.DeleteTaskB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteTaskB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.DeleteTaskB
        Me.DeleteTaskB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteTaskB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.DeleteTaskB.FlatAppearance.BorderSize = 2
        Me.DeleteTaskB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.DeleteTaskB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteTaskB.Location = New System.Drawing.Point(93, 334)
        Me.DeleteTaskB.Name = "DeleteTaskB"
        Me.DeleteTaskB.Size = New System.Drawing.Size(162, 157)
        Me.DeleteTaskB.TabIndex = 2
        Me.DeleteTaskB.UseVisualStyleBackColor = True
        '
        'SoonB
        '
        Me.SoonB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoonB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.SoonB.FlatAppearance.BorderSize = 2
        Me.SoonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.SoonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoonB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SoonB.ForeColor = System.Drawing.Color.White
        Me.SoonB.Location = New System.Drawing.Point(345, 334)
        Me.SoonB.Name = "SoonB"
        Me.SoonB.Size = New System.Drawing.Size(162, 157)
        Me.SoonB.TabIndex = 2
        Me.SoonB.Text = "COMING SOON"
        Me.SoonB.UseVisualStyleBackColor = True
        '
        'AddTaskL
        '
        Me.AddTaskL.AutoSize = True
        Me.AddTaskL.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddTaskL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTaskL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddTaskL.ForeColor = System.Drawing.Color.BlueViolet
        Me.AddTaskL.Location = New System.Drawing.Point(93, 250)
        Me.AddTaskL.Name = "AddTaskL"
        Me.AddTaskL.Size = New System.Drawing.Size(162, 35)
        Me.AddTaskL.TabIndex = 3
        Me.AddTaskL.Text = "Add Task"
        Me.AddTaskL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewTaskL
        '
        Me.ViewTaskL.AutoSize = True
        Me.ViewTaskL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewTaskL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTaskL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewTaskL.ForeColor = System.Drawing.Color.BlueViolet
        Me.ViewTaskL.Location = New System.Drawing.Point(345, 250)
        Me.ViewTaskL.Name = "ViewTaskL"
        Me.ViewTaskL.Size = New System.Drawing.Size(162, 35)
        Me.ViewTaskL.TabIndex = 4
        Me.ViewTaskL.Text = "View Task"
        Me.ViewTaskL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteTaskL
        '
        Me.DeleteTaskL.AutoSize = True
        Me.DeleteTaskL.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteTaskL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteTaskL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteTaskL.ForeColor = System.Drawing.Color.BlueViolet
        Me.DeleteTaskL.Location = New System.Drawing.Point(93, 494)
        Me.DeleteTaskL.Name = "DeleteTaskL"
        Me.DeleteTaskL.Size = New System.Drawing.Size(162, 35)
        Me.DeleteTaskL.TabIndex = 5
        Me.DeleteTaskL.Text = "Delete Task"
        Me.DeleteTaskL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnimationPanel
        '
        Me.AnimationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimationPanel.Location = New System.Drawing.Point(0, 0)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.AnimationPanel.Size = New System.Drawing.Size(959, 585)
        Me.AnimationPanel.TabIndex = 4
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.Controls.Add(Me.TaskManagementL)
        Me.TitlePanel.Location = New System.Drawing.Point(3, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(959, 71)
        Me.TitlePanel.TabIndex = 4
        '
        'TaskManagementL
        '
        Me.TaskManagementL.AutoSize = True
        Me.TaskManagementL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskManagementL.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TaskManagementL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TaskManagementL.Location = New System.Drawing.Point(22, 10)
        Me.TaskManagementL.Name = "TaskManagementL"
        Me.TaskManagementL.Size = New System.Drawing.Size(344, 54)
        Me.TaskManagementL.TabIndex = 0
        Me.TaskManagementL.Text = "Task Management"
        '
        'TaskManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.Controls.Add(Me.BasePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.DoubleBuffered = True
        Me.Name = "TaskManagement"
        Me.Size = New System.Drawing.Size(965, 665)
        Me.BasePanel.ResumeLayout(False)
        Me.ButtonPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BasePanel As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AddTaskB As Button
    Friend WithEvents ViewTaskB As Button
    Friend WithEvents DeleteTaskB As Button
    Friend WithEvents SoonB As Button
    Friend WithEvents AddTaskL As Label
    Friend WithEvents ViewTaskL As Label
    Friend WithEvents DeleteTaskL As Label
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents TaskManagementL As Label
End Class
