<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinanceManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.FinManagementL = New System.Windows.Forms.Label()
        Me.BasePanel = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddTransactionB = New System.Windows.Forms.Button()
        Me.ViewTransactionB = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AddTransactionL = New System.Windows.Forms.Label()
        Me.ViewTransactionL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.TitlePanel.Controls.Add(Me.FinManagementL)
        Me.TitlePanel.Location = New System.Drawing.Point(3, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(959, 71)
        Me.TitlePanel.TabIndex = 2
        '
        'FinManagementL
        '
        Me.FinManagementL.AutoSize = True
        Me.FinManagementL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinManagementL.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinManagementL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FinManagementL.Location = New System.Drawing.Point(22, 10)
        Me.FinManagementL.Name = "FinManagementL"
        Me.FinManagementL.Size = New System.Drawing.Size(405, 54)
        Me.FinManagementL.TabIndex = 0
        Me.FinManagementL.Text = "Finance Management"
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
        Me.BasePanel.TabIndex = 3
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
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AddTransactionL, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewTransactionL, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 4)
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
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.Personal_Assistant.My.Resources.Resources.ViewAccountsB1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(93, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 157)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(345, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 157)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "COMING SOON"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.AddTransactionL.Text = "Add Transaction"
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
        Me.ViewTransactionL.Text = "View Transaction"
        Me.ViewTransactionL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(93, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 70)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "View Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnimationPanel
        '
        Me.AnimationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimationPanel.Location = New System.Drawing.Point(0, 0)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.AnimationPanel.Size = New System.Drawing.Size(959, 585)
        Me.AnimationPanel.TabIndex = 4
        '
        'FinanceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Indigo
        Me.Controls.Add(Me.BasePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.DoubleBuffered = True
        Me.Name = "FinanceManagement"
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
    Friend WithEvents FinManagementL As Label
    Friend WithEvents BasePanel As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AddTransactionB As Button
    Friend WithEvents ViewTransactionB As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents AddTransactionL As Label
    Friend WithEvents ViewTransactionL As Label
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents Label1 As Label
End Class
