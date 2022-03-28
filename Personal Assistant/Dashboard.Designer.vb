<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.BasePanel = New System.Windows.Forms.Panel()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.NavigationPanel = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MinimizeB = New System.Windows.Forms.Button()
        Me.CloseB = New System.Windows.Forms.Button()
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
        Me.BasePanel.Location = New System.Drawing.Point(56, 52)
        Me.BasePanel.Name = "BasePanel"
        Me.BasePanel.Size = New System.Drawing.Size(965, 665)
        Me.BasePanel.TabIndex = 0
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
        Me.TitlePanel.Size = New System.Drawing.Size(965, 49)
        Me.TitlePanel.TabIndex = 0
        '
        'NavigationPanel
        '
        Me.NavigationPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NavigationPanel.Controls.Add(Me.Button4)
        Me.NavigationPanel.Controls.Add(Me.Button3)
        Me.NavigationPanel.Controls.Add(Me.Button2)
        Me.NavigationPanel.Controls.Add(Me.Button1)
        Me.NavigationPanel.Location = New System.Drawing.Point(2, 3)
        Me.NavigationPanel.Name = "NavigationPanel"
        Me.NavigationPanel.Size = New System.Drawing.Size(54, 714)
        Me.NavigationPanel.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.FinanceB
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(8, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.HealthB
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(8, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.TaskB1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(8, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.OptionsB
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(9, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
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
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.NavigationPanel)
        Me.Controls.Add(Me.BasePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TitlePanel.ResumeLayout(False)
        Me.NavigationPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BasePanel As Panel
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents NavigationPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MinimizeB As Button
    Friend WithEvents CloseB As Button
End Class
