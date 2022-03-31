<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.BasePanel = New System.Windows.Forms.Panel()
        Me.FinanceManagement1 = New Personal_Assistant.FinanceManagement()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.MinimizeB = New System.Windows.Forms.Button()
        Me.CloseB = New System.Windows.Forms.Button()
        Me.NavigationPanel = New System.Windows.Forms.Panel()
        Me.FinanceManagerNavB = New System.Windows.Forms.Button()
        Me.HealthMonitorNavB = New System.Windows.Forms.Button()
        Me.TaskManagerNavB = New System.Windows.Forms.Button()
        Me.OptionsB = New System.Windows.Forms.Button()
        Me.BasePanel.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.NavigationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BasePanel
        '
        Me.BasePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BasePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BasePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BasePanel.Controls.Add(Me.FinanceManagement1)
        Me.BasePanel.Location = New System.Drawing.Point(56, 52)
        Me.BasePanel.Name = "BasePanel"
        Me.BasePanel.Size = New System.Drawing.Size(965, 665)
        Me.BasePanel.TabIndex = 0
        '
        'FinanceManagement1
        '
        Me.FinanceManagement1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinanceManagement1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FinanceManagement1.BackColor = System.Drawing.Color.Indigo
        Me.FinanceManagement1.Location = New System.Drawing.Point(0, 0)
        Me.FinanceManagement1.Name = "FinanceManagement1"
        Me.FinanceManagement1.Size = New System.Drawing.Size(965, 665)
        Me.FinanceManagement1.TabIndex = 2
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TitlePanel.Controls.Add(Me.MinimizeB)
        Me.TitlePanel.Controls.Add(Me.CloseB)
        Me.TitlePanel.Location = New System.Drawing.Point(56, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(965, 43)
        Me.TitlePanel.TabIndex = 0
        '
        'MinimizeB
        '
        Me.MinimizeB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.MinB
        Me.MinimizeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MinimizeB.FlatAppearance.BorderSize = 0
        Me.MinimizeB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.MinimizeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeB.Location = New System.Drawing.Point(884, 9)
        Me.MinimizeB.Name = "MinimizeB"
        Me.MinimizeB.Size = New System.Drawing.Size(32, 32)
        Me.MinimizeB.TabIndex = 3
        Me.MinimizeB.UseVisualStyleBackColor = True
        '
        'CloseB
        '
        Me.CloseB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.CloseB
        Me.CloseB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseB.FlatAppearance.BorderSize = 0
        Me.CloseB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.CloseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseB.Location = New System.Drawing.Point(924, 8)
        Me.CloseB.Name = "CloseB"
        Me.CloseB.Size = New System.Drawing.Size(32, 33)
        Me.CloseB.TabIndex = 2
        Me.CloseB.UseVisualStyleBackColor = True
        '
        'NavigationPanel
        '
        Me.NavigationPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NavigationPanel.Controls.Add(Me.FinanceManagerNavB)
        Me.NavigationPanel.Controls.Add(Me.HealthMonitorNavB)
        Me.NavigationPanel.Controls.Add(Me.TaskManagerNavB)
        Me.NavigationPanel.Controls.Add(Me.OptionsB)
        Me.NavigationPanel.Location = New System.Drawing.Point(2, 3)
        Me.NavigationPanel.Name = "NavigationPanel"
        Me.NavigationPanel.Size = New System.Drawing.Size(54, 714)
        Me.NavigationPanel.TabIndex = 1
        '
        'FinanceManagerNavB
        '
        Me.FinanceManagerNavB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.FinanceB
        Me.FinanceManagerNavB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FinanceManagerNavB.FlatAppearance.BorderSize = 0
        Me.FinanceManagerNavB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.FinanceManagerNavB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinanceManagerNavB.Location = New System.Drawing.Point(8, 81)
        Me.FinanceManagerNavB.Name = "FinanceManagerNavB"
        Me.FinanceManagerNavB.Size = New System.Drawing.Size(40, 40)
        Me.FinanceManagerNavB.TabIndex = 3
        Me.FinanceManagerNavB.UseVisualStyleBackColor = True
        '
        'HealthMonitorNavB
        '
        Me.HealthMonitorNavB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.HealthB
        Me.HealthMonitorNavB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HealthMonitorNavB.FlatAppearance.BorderSize = 0
        Me.HealthMonitorNavB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.HealthMonitorNavB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HealthMonitorNavB.Location = New System.Drawing.Point(8, 235)
        Me.HealthMonitorNavB.Name = "HealthMonitorNavB"
        Me.HealthMonitorNavB.Size = New System.Drawing.Size(40, 48)
        Me.HealthMonitorNavB.TabIndex = 2
        Me.HealthMonitorNavB.UseVisualStyleBackColor = True
        '
        'TaskManagerNavB
        '
        Me.TaskManagerNavB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.TaskB1
        Me.TaskManagerNavB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TaskManagerNavB.FlatAppearance.BorderSize = 0
        Me.TaskManagerNavB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.TaskManagerNavB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskManagerNavB.Location = New System.Drawing.Point(8, 154)
        Me.TaskManagerNavB.Name = "TaskManagerNavB"
        Me.TaskManagerNavB.Size = New System.Drawing.Size(40, 48)
        Me.TaskManagerNavB.TabIndex = 1
        Me.TaskManagerNavB.UseVisualStyleBackColor = True
        '
        'OptionsB
        '
        Me.OptionsB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.OptionsB
        Me.OptionsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OptionsB.FlatAppearance.BorderSize = 0
        Me.OptionsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.OptionsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsB.Location = New System.Drawing.Point(9, 8)
        Me.OptionsB.Name = "OptionsB"
        Me.OptionsB.Size = New System.Drawing.Size(40, 40)
        Me.OptionsB.TabIndex = 0
        Me.OptionsB.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.NavigationPanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.BasePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BasePanel.ResumeLayout(False)
        Me.TitlePanel.ResumeLayout(False)
        Me.NavigationPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BasePanel As Panel
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents NavigationPanel As Panel
    Friend WithEvents OptionsB As Button
    Friend WithEvents FinanceManagerNavB As Button
    Friend WithEvents HealthMonitorNavB As Button
    Friend WithEvents TaskManagerNavB As Button
    Friend WithEvents MinimizeB As Button
    Friend WithEvents CloseB As Button
    Friend WithEvents FinanceManagement1 As FinanceManagement
End Class
