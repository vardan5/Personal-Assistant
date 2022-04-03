<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.HomeL = New System.Windows.Forms.Label()
        Me.BasePanel = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FinanceManagementB = New System.Windows.Forms.Button()
        Me.TaskManagementB = New System.Windows.Forms.Button()
        Me.HealthMonitoring = New System.Windows.Forms.Button()
        Me.SoonB = New System.Windows.Forms.Button()
        Me.FinanceManagementL = New System.Windows.Forms.Label()
        Me.TaskManagementL = New System.Windows.Forms.Label()
        Me.HealthMonitoringL = New System.Windows.Forms.Label()
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.TitlePanel.SuspendLayout()
        Me.BasePanel.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.Controls.Add(Me.HomeL)
        Me.TitlePanel.Location = New System.Drawing.Point(3, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(959, 69)
        Me.TitlePanel.TabIndex = 3
        '
        'HomeL
        '
        Me.HomeL.AutoSize = True
        Me.HomeL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeL.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HomeL.Location = New System.Drawing.Point(22, 10)
        Me.HomeL.Name = "HomeL"
        Me.HomeL.Size = New System.Drawing.Size(216, 54)
        Me.HomeL.TabIndex = 0
        Me.HomeL.Text = "Dashboard"
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
        Me.BasePanel.TabIndex = 4
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
        Me.TableLayoutPanel1.Controls.Add(Me.FinanceManagementB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TaskManagementB, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HealthMonitoring, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SoonB, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FinanceManagementL, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TaskManagementL, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.HealthMonitoringL, 1, 4)
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
        'FinanceManagementB
        '
        Me.FinanceManagementB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinanceManagementB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.FinanceB
        Me.FinanceManagementB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FinanceManagementB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.FinanceManagementB.FlatAppearance.BorderSize = 2
        Me.FinanceManagementB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.FinanceManagementB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinanceManagementB.Location = New System.Drawing.Point(93, 90)
        Me.FinanceManagementB.Name = "FinanceManagementB"
        Me.FinanceManagementB.Size = New System.Drawing.Size(162, 157)
        Me.FinanceManagementB.TabIndex = 2
        Me.FinanceManagementB.UseVisualStyleBackColor = True
        '
        'TaskManagementB
        '
        Me.TaskManagementB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskManagementB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.TaskB1
        Me.TaskManagementB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaskManagementB.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.TaskManagementB.FlatAppearance.BorderSize = 2
        Me.TaskManagementB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.TaskManagementB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskManagementB.Location = New System.Drawing.Point(345, 90)
        Me.TaskManagementB.Name = "TaskManagementB"
        Me.TaskManagementB.Size = New System.Drawing.Size(162, 157)
        Me.TaskManagementB.TabIndex = 2
        Me.TaskManagementB.UseVisualStyleBackColor = True
        '
        'HealthMonitoring
        '
        Me.HealthMonitoring.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HealthMonitoring.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.HealthB
        Me.HealthMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HealthMonitoring.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet
        Me.HealthMonitoring.FlatAppearance.BorderSize = 2
        Me.HealthMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.HealthMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HealthMonitoring.Location = New System.Drawing.Point(93, 334)
        Me.HealthMonitoring.Name = "HealthMonitoring"
        Me.HealthMonitoring.Size = New System.Drawing.Size(162, 157)
        Me.HealthMonitoring.TabIndex = 2
        Me.HealthMonitoring.UseVisualStyleBackColor = True
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
        'FinanceManagementL
        '
        Me.FinanceManagementL.AutoSize = True
        Me.FinanceManagementL.Dock = System.Windows.Forms.DockStyle.Top
        Me.FinanceManagementL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinanceManagementL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinanceManagementL.ForeColor = System.Drawing.Color.BlueViolet
        Me.FinanceManagementL.Location = New System.Drawing.Point(93, 250)
        Me.FinanceManagementL.Name = "FinanceManagementL"
        Me.FinanceManagementL.Size = New System.Drawing.Size(162, 70)
        Me.FinanceManagementL.TabIndex = 3
        Me.FinanceManagementL.Text = "Finance Management"
        Me.FinanceManagementL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskManagementL
        '
        Me.TaskManagementL.AutoSize = True
        Me.TaskManagementL.Dock = System.Windows.Forms.DockStyle.Top
        Me.TaskManagementL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskManagementL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TaskManagementL.ForeColor = System.Drawing.Color.BlueViolet
        Me.TaskManagementL.Location = New System.Drawing.Point(345, 250)
        Me.TaskManagementL.Name = "TaskManagementL"
        Me.TaskManagementL.Size = New System.Drawing.Size(162, 70)
        Me.TaskManagementL.TabIndex = 4
        Me.TaskManagementL.Text = "Task Management"
        Me.TaskManagementL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HealthMonitoringL
        '
        Me.HealthMonitoringL.AutoSize = True
        Me.HealthMonitoringL.Dock = System.Windows.Forms.DockStyle.Top
        Me.HealthMonitoringL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HealthMonitoringL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HealthMonitoringL.ForeColor = System.Drawing.Color.BlueViolet
        Me.HealthMonitoringL.Location = New System.Drawing.Point(93, 494)
        Me.HealthMonitoringL.Name = "HealthMonitoringL"
        Me.HealthMonitoringL.Size = New System.Drawing.Size(162, 70)
        Me.HealthMonitoringL.TabIndex = 5
        Me.HealthMonitoringL.Text = "Health Monitoring"
        Me.HealthMonitoringL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.BasePanel)
        Me.DoubleBuffered = True
        Me.Name = "Home"
        Me.Size = New System.Drawing.Size(965, 665)
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.BasePanel.ResumeLayout(False)
        Me.ButtonPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitlePanel As Panel
    Friend WithEvents HomeL As Label
    Friend WithEvents BasePanel As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FinanceManagementB As Button
    Friend WithEvents TaskManagementB As Button
    Friend WithEvents HealthMonitoring As Button
    Friend WithEvents SoonB As Button
    Friend WithEvents FinanceManagementL As Label
    Friend WithEvents TaskManagementL As Label
    Friend WithEvents HealthMonitoringL As Label
    Friend WithEvents AnimationPanel As Panel
End Class
