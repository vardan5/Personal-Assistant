<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.NewUserLL = New System.Windows.Forms.LinkLabel()
        Me.ForgotPassLL = New System.Windows.Forms.LinkLabel()
        Me.RightLogoPB = New System.Windows.Forms.PictureBox()
        Me.ResetB = New System.Windows.Forms.Button()
        Me.LoginB = New System.Windows.Forms.Button()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.MinimizePB = New System.Windows.Forms.PictureBox()
        Me.ClosePB = New System.Windows.Forms.PictureBox()
        Me.LogoPB = New System.Windows.Forms.PictureBox()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TitleL = New System.Windows.Forms.Label()
        Me.InfoPanel = New System.Windows.Forms.Panel()
        Me.SecurityPanel = New System.Windows.Forms.Panel()
        Me.SecurityL = New System.Windows.Forms.Label()
        Me.SecLogo = New System.Windows.Forms.PictureBox()
        Me.NextToNewPassB = New System.Windows.Forms.Button()
        Me.BackToLoginB = New System.Windows.Forms.Button()
        Me.SecAnswerTB = New System.Windows.Forms.TextBox()
        Me.SecQuestionTB = New System.Windows.Forms.TextBox()
        Me.LoginPanel.SuspendLayout()
        CType(Me.RightLogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        Me.SecurityPanel.SuspendLayout()
        CType(Me.SecLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginPanel
        '
        Me.LoginPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPanel.BackColor = System.Drawing.Color.Indigo
        Me.LoginPanel.Controls.Add(Me.NewUserLL)
        Me.LoginPanel.Controls.Add(Me.ForgotPassLL)
        Me.LoginPanel.Controls.Add(Me.RightLogoPB)
        Me.LoginPanel.Controls.Add(Me.ResetB)
        Me.LoginPanel.Controls.Add(Me.LoginB)
        Me.LoginPanel.Controls.Add(Me.PasswordTB)
        Me.LoginPanel.Controls.Add(Me.UsernameTB)
        Me.LoginPanel.Location = New System.Drawing.Point(427, 44)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(344, 470)
        Me.LoginPanel.TabIndex = 0
        '
        'NewUserLL
        '
        Me.NewUserLL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NewUserLL.AutoSize = True
        Me.NewUserLL.Location = New System.Drawing.Point(72, 398)
        Me.NewUserLL.Name = "NewUserLL"
        Me.NewUserLL.Size = New System.Drawing.Size(184, 20)
        Me.NewUserLL.TabIndex = 13
        Me.NewUserLL.TabStop = True
        Me.NewUserLL.Text = "New User? Create Account"
        '
        'ForgotPassLL
        '
        Me.ForgotPassLL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ForgotPassLL.AutoSize = True
        Me.ForgotPassLL.Location = New System.Drawing.Point(109, 268)
        Me.ForgotPassLL.Name = "ForgotPassLL"
        Me.ForgotPassLL.Size = New System.Drawing.Size(118, 20)
        Me.ForgotPassLL.TabIndex = 12
        Me.ForgotPassLL.TabStop = True
        Me.ForgotPassLL.Text = "forgot password"
        Me.ForgotPassLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightLogoPB
        '
        Me.RightLogoPB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RightLogoPB.Image = CType(resources.GetObject("RightLogoPB.Image"), System.Drawing.Image)
        Me.RightLogoPB.Location = New System.Drawing.Point(99, 21)
        Me.RightLogoPB.Name = "RightLogoPB"
        Me.RightLogoPB.Size = New System.Drawing.Size(146, 96)
        Me.RightLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RightLogoPB.TabIndex = 11
        Me.RightLogoPB.TabStop = False
        '
        'ResetB
        '
        Me.ResetB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ResetB.Location = New System.Drawing.Point(167, 320)
        Me.ResetB.Name = "ResetB"
        Me.ResetB.Size = New System.Drawing.Size(128, 29)
        Me.ResetB.TabIndex = 9
        Me.ResetB.Text = "Reset"
        Me.ResetB.UseVisualStyleBackColor = True
        '
        'LoginB
        '
        Me.LoginB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginB.Location = New System.Drawing.Point(36, 320)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.Size = New System.Drawing.Size(128, 29)
        Me.LoginB.TabIndex = 10
        Me.LoginB.Text = "Login"
        Me.LoginB.UseVisualStyleBackColor = True
        '
        'PasswordTB
        '
        Me.PasswordTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordTB.Location = New System.Drawing.Point(33, 241)
        Me.PasswordTB.Margin = New System.Windows.Forms.Padding(0)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(274, 27)
        Me.PasswordTB.TabIndex = 7
        Me.PasswordTB.Text = "Password"
        Me.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsernameTB
        '
        Me.UsernameTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTB.Location = New System.Drawing.Point(33, 199)
        Me.UsernameTB.Margin = New System.Windows.Forms.Padding(0)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(274, 27)
        Me.UsernameTB.TabIndex = 8
        Me.UsernameTB.Text = "Username"
        Me.UsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MinimizePB
        '
        Me.MinimizePB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizePB.Image = CType(resources.GetObject("MinimizePB.Image"), System.Drawing.Image)
        Me.MinimizePB.Location = New System.Drawing.Point(709, 9)
        Me.MinimizePB.Name = "MinimizePB"
        Me.MinimizePB.Size = New System.Drawing.Size(22, 20)
        Me.MinimizePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MinimizePB.TabIndex = 6
        Me.MinimizePB.TabStop = False
        '
        'ClosePB
        '
        Me.ClosePB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClosePB.Image = CType(resources.GetObject("ClosePB.Image"), System.Drawing.Image)
        Me.ClosePB.Location = New System.Drawing.Point(737, 9)
        Me.ClosePB.Name = "ClosePB"
        Me.ClosePB.Size = New System.Drawing.Size(22, 20)
        Me.ClosePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClosePB.TabIndex = 5
        Me.ClosePB.TabStop = False
        '
        'LogoPB
        '
        Me.LogoPB.Image = CType(resources.GetObject("LogoPB.Image"), System.Drawing.Image)
        Me.LogoPB.Location = New System.Drawing.Point(3, 3)
        Me.LogoPB.Name = "LogoPB"
        Me.LogoPB.Size = New System.Drawing.Size(43, 32)
        Me.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPB.TabIndex = 2
        Me.LogoPB.TabStop = False
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TitlePanel.Controls.Add(Me.TitleL)
        Me.TitlePanel.Controls.Add(Me.MinimizePB)
        Me.TitlePanel.Controls.Add(Me.LogoPB)
        Me.TitlePanel.Controls.Add(Me.ClosePB)
        Me.TitlePanel.Location = New System.Drawing.Point(3, 3)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(768, 38)
        Me.TitlePanel.TabIndex = 1
        '
        'TitleL
        '
        Me.TitleL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TitleL.AutoSize = True
        Me.TitleL.ForeColor = System.Drawing.Color.White
        Me.TitleL.Location = New System.Drawing.Point(52, 9)
        Me.TitleL.Name = "TitleL"
        Me.TitleL.Size = New System.Drawing.Size(46, 20)
        Me.TitleL.TabIndex = 0
        Me.TitleL.Text = "Login"
        '
        'InfoPanel
        '
        Me.InfoPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPanel.AutoSize = True
        Me.InfoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.InfoPanel.Location = New System.Drawing.Point(3, 44)
        Me.InfoPanel.Name = "InfoPanel"
        Me.InfoPanel.Size = New System.Drawing.Size(418, 470)
        Me.InfoPanel.TabIndex = 3
        '
        'SecurityPanel
        '
        Me.SecurityPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SecurityPanel.Controls.Add(Me.SecurityL)
        Me.SecurityPanel.Controls.Add(Me.SecLogo)
        Me.SecurityPanel.Controls.Add(Me.NextToNewPassB)
        Me.SecurityPanel.Controls.Add(Me.BackToLoginB)
        Me.SecurityPanel.Controls.Add(Me.SecAnswerTB)
        Me.SecurityPanel.Controls.Add(Me.SecQuestionTB)
        Me.SecurityPanel.Location = New System.Drawing.Point(427, 44)
        Me.SecurityPanel.Name = "SecurityPanel"
        Me.SecurityPanel.Size = New System.Drawing.Size(344, 470)
        Me.SecurityPanel.TabIndex = 0
        Me.SecurityPanel.Visible = False
        '
        'SecurityL
        '
        Me.SecurityL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SecurityL.AutoSize = True
        Me.SecurityL.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SecurityL.ForeColor = System.Drawing.Color.White
        Me.SecurityL.Location = New System.Drawing.Point(23, 130)
        Me.SecurityL.Name = "SecurityL"
        Me.SecurityL.Size = New System.Drawing.Size(303, 46)
        Me.SecurityL.TabIndex = 19
        Me.SecurityL.Text = "Security Question"
        '
        'SecLogo
        '
        Me.SecLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SecLogo.Image = CType(resources.GetObject("SecLogo.Image"), System.Drawing.Image)
        Me.SecLogo.Location = New System.Drawing.Point(97, 20)
        Me.SecLogo.Name = "SecLogo"
        Me.SecLogo.Size = New System.Drawing.Size(146, 96)
        Me.SecLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SecLogo.TabIndex = 18
        Me.SecLogo.TabStop = False
        '
        'NextToNewPassB
        '
        Me.NextToNewPassB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NextToNewPassB.Location = New System.Drawing.Point(176, 319)
        Me.NextToNewPassB.Name = "NextToNewPassB"
        Me.NextToNewPassB.Size = New System.Drawing.Size(128, 29)
        Me.NextToNewPassB.TabIndex = 16
        Me.NextToNewPassB.Text = "Next"
        Me.NextToNewPassB.UseVisualStyleBackColor = True
        '
        'BackToLoginB
        '
        Me.BackToLoginB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackToLoginB.Location = New System.Drawing.Point(45, 319)
        Me.BackToLoginB.Name = "BackToLoginB"
        Me.BackToLoginB.Size = New System.Drawing.Size(128, 29)
        Me.BackToLoginB.TabIndex = 17
        Me.BackToLoginB.Text = "Back"
        Me.BackToLoginB.UseVisualStyleBackColor = True
        '
        'SecAnswerTB
        '
        Me.SecAnswerTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SecAnswerTB.Location = New System.Drawing.Point(35, 258)
        Me.SecAnswerTB.Margin = New System.Windows.Forms.Padding(0)
        Me.SecAnswerTB.Name = "SecAnswerTB"
        Me.SecAnswerTB.Size = New System.Drawing.Size(274, 27)
        Me.SecAnswerTB.TabIndex = 14
        Me.SecAnswerTB.Text = "Answer"
        Me.SecAnswerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecQuestionTB
        '
        Me.SecQuestionTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SecQuestionTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SecQuestionTB.Location = New System.Drawing.Point(35, 200)
        Me.SecQuestionTB.Margin = New System.Windows.Forms.Padding(0)
        Me.SecQuestionTB.Multiline = True
        Me.SecQuestionTB.Name = "SecQuestionTB"
        Me.SecQuestionTB.Size = New System.Drawing.Size(274, 43)
        Me.SecQuestionTB.TabIndex = 15
        Me.SecQuestionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(774, 517)
        Me.Controls.Add(Me.SecurityPanel)
        Me.Controls.Add(Me.InfoPanel)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(774, 517)
        Me.Name = "Form1"
        Me.Text = "Personal Assistant Login"
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        CType(Me.RightLogoPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.SecurityPanel.ResumeLayout(False)
        Me.SecurityPanel.PerformLayout()
        CType(Me.SecLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoPB As PictureBox
    Friend WithEvents MinimizePB As PictureBox
    Friend WithEvents ClosePB As PictureBox
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents NewUserLL As LinkLabel
    Friend WithEvents ForgotPassLL As LinkLabel
    Friend WithEvents RightLogoPB As PictureBox
    Friend WithEvents ResetB As Button
    Friend WithEvents LoginB As Button
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents InfoPanel As Panel
    Friend WithEvents TitleL As Label
    Friend WithEvents SecurityPanel As Panel
    Friend WithEvents SecLogo As PictureBox
    Friend WithEvents NextToNewPassB As Button
    Friend WithEvents BackToLoginB As Button
    Friend WithEvents SecAnswerTB As TextBox
    Friend WithEvents SecQuestionTB As TextBox
    Friend WithEvents SecurityL As Label
End Class
