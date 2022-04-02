<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HealthMonitoring
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
        Me.AddTransactionB = New System.Windows.Forms.Button()
        Me.ViewTransactionB = New System.Windows.Forms.Button()
        Me.ViewAccountsB = New System.Windows.Forms.Button()
        Me.SoonB = New System.Windows.Forms.Button()
        Me.AddTransactionL = New System.Windows.Forms.Label()
        Me.ViewTransactionL = New System.Windows.Forms.Label()
        Me.ViewAccountsL = New System.Windows.Forms.Label()
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.HealthMonitoringL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Splitter1.BackColor = System.Drawing.Color.Indigo
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
        Me.TableLayoutPanel1.Controls.Add(Me.AddTransactionB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTransactionB, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewAccountsB, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SoonB, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AddTransactionL, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTransactionL, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewAccountsL, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 4)
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
        'AddTransactionB
        '
        Me.AddTransactionB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddTransactionB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.AddTransactionB
        Me.AddTransactionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddTransactionB.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.AddTransactionB.FlatAppearance.BorderSize = 2
        Me.AddTransactionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.AddTransactionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTransactionB.Location = New System.Drawing.Point(93, 90)
        Me.AddTransactionB.Name = "AddTransactionB"
        Me.AddTransactionB.Size = New System.Drawing.Size(162, 157)
        Me.AddTransactionB.TabIndex = 2
        Me.AddTransactionB.UseVisualStyleBackColor = True
        '
        'ViewTransactionB
        '
        Me.ViewTransactionB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewTransactionB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.ViewTransactionB
        Me.ViewTransactionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewTransactionB.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.ViewTransactionB.FlatAppearance.BorderSize = 2
        Me.ViewTransactionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.ViewTransactionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTransactionB.Location = New System.Drawing.Point(345, 90)
        Me.ViewTransactionB.Name = "ViewTransactionB"
        Me.ViewTransactionB.Size = New System.Drawing.Size(162, 157)
        Me.ViewTransactionB.TabIndex = 2
        Me.ViewTransactionB.UseVisualStyleBackColor = True
        '
        'ViewAccountsB
        '
        Me.ViewAccountsB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewAccountsB.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.ViewAccountsB1
        Me.ViewAccountsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewAccountsB.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.ViewAccountsB.FlatAppearance.BorderSize = 2
        Me.ViewAccountsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.ViewAccountsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewAccountsB.Location = New System.Drawing.Point(93, 334)
        Me.ViewAccountsB.Name = "ViewAccountsB"
        Me.ViewAccountsB.Size = New System.Drawing.Size(162, 157)
        Me.ViewAccountsB.TabIndex = 2
        Me.ViewAccountsB.UseVisualStyleBackColor = True
        '
        'SoonB
        '
        Me.SoonB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoonB.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.SoonB.FlatAppearance.BorderSize = 2
        Me.SoonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
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
        'AddTransactionL
        '
        Me.AddTransactionL.AutoSize = True
        Me.AddTransactionL.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddTransactionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTransactionL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddTransactionL.ForeColor = System.Drawing.Color.Indigo
        Me.AddTransactionL.Location = New System.Drawing.Point(93, 250)
        Me.AddTransactionL.Name = "AddTransactionL"
        Me.AddTransactionL.Size = New System.Drawing.Size(162, 70)
        Me.AddTransactionL.TabIndex = 3
        Me.AddTransactionL.Text = "Add Daily Info"
        Me.AddTransactionL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewTransactionL
        '
        Me.ViewTransactionL.AutoSize = True
        Me.ViewTransactionL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewTransactionL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTransactionL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewTransactionL.ForeColor = System.Drawing.Color.Indigo
        Me.ViewTransactionL.Location = New System.Drawing.Point(345, 250)
        Me.ViewTransactionL.Name = "ViewTransactionL"
        Me.ViewTransactionL.Size = New System.Drawing.Size(162, 70)
        Me.ViewTransactionL.TabIndex = 4
        Me.ViewTransactionL.Text = "View Daily Info"
        Me.ViewTransactionL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewAccountsL
        '
        Me.ViewAccountsL.AutoSize = True
        Me.ViewAccountsL.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViewAccountsL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewAccountsL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewAccountsL.ForeColor = System.Drawing.Color.Indigo
        Me.ViewAccountsL.Location = New System.Drawing.Point(93, 494)
        Me.ViewAccountsL.Name = "ViewAccountsL"
        Me.ViewAccountsL.Size = New System.Drawing.Size(162, 35)
        Me.ViewAccountsL.TabIndex = 5
        Me.ViewAccountsL.Text = "Add Goal"
        Me.ViewAccountsL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TitlePanel.Controls.Add(Me.HealthMonitoringL)
        Me.TitlePanel.Location = New System.Drawing.Point(3, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(959, 71)
        Me.TitlePanel.TabIndex = 4
        '
        'HealthMonitoringL
        '
        Me.HealthMonitoringL.AutoSize = True
        Me.HealthMonitoringL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HealthMonitoringL.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HealthMonitoringL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HealthMonitoringL.Location = New System.Drawing.Point(22, 10)
        Me.HealthMonitoringL.Name = "HealthMonitoringL"
        Me.HealthMonitoringL.Size = New System.Drawing.Size(350, 54)
        Me.HealthMonitoringL.TabIndex = 0
        Me.HealthMonitoringL.Text = "Health Monitoring"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(345, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "View Goals"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HealthMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.Controls.Add(Me.BasePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Name = "HealthMonitoring"
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
    Friend WithEvents AddTransactionB As Button
    Friend WithEvents ViewTransactionB As Button
    Friend WithEvents ViewAccountsB As Button
    Friend WithEvents SoonB As Button
    Friend WithEvents AddTransactionL As Label
    Friend WithEvents ViewTransactionL As Label
    Friend WithEvents ViewAccountsL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents HealthMonitoringL As Label
End Class
