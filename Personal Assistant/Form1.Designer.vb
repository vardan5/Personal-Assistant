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
        Me.ForgotPassLL = New System.Windows.Forms.LinkLabel()
        Me.ResetB = New System.Windows.Forms.Button()
        Me.LoginB = New System.Windows.Forms.Button()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.RightLogoPB = New System.Windows.Forms.PictureBox()
        Me.NewUserLL = New System.Windows.Forms.LinkLabel()
        Me.MinimizePB = New System.Windows.Forms.PictureBox()
        Me.ClosePB = New System.Windows.Forms.PictureBox()
        Me.LogoPB = New System.Windows.Forms.PictureBox()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TitleL = New System.Windows.Forms.Label()
        Me.InfoPanel = New System.Windows.Forms.Panel()
        Me.ChangePasswordPanel = New System.Windows.Forms.Panel()
        Me.BackToLoginB = New System.Windows.Forms.Button()
        Me.BackToSecQuesB = New System.Windows.Forms.Button()
        Me.NextToSecQuesB = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NextToLoginB = New System.Windows.Forms.Button()
        Me.ConfirmPassTB = New System.Windows.Forms.TextBox()
        Me.NewPassTB = New System.Windows.Forms.TextBox()
        Me.ChangePassL = New System.Windows.Forms.Label()
        Me.SecurityPanel = New System.Windows.Forms.Panel()
        Me.SecurityL = New System.Windows.Forms.Label()
        Me.SecLogo = New System.Windows.Forms.PictureBox()
        Me.NextToNewPassB = New System.Windows.Forms.Button()
        Me.BackToEnterUnameB = New System.Windows.Forms.Button()
        Me.SecAnswerTB = New System.Windows.Forms.TextBox()
        Me.SecQuestionTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EnterUsernameTB = New System.Windows.Forms.TextBox()
        Me.EnterUnameL = New System.Windows.Forms.Label()
        Me.EnterUsernamePanel = New System.Windows.Forms.Panel()
        Me.LoginPanel.SuspendLayout()
        CType(Me.RightLogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        Me.ChangePasswordPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SecurityPanel.SuspendLayout()
        CType(Me.SecLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnterUsernamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginPanel
        '
        Me.LoginPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPanel.BackColor = System.Drawing.Color.Indigo
        Me.LoginPanel.Controls.Add(Me.ForgotPassLL)
        Me.LoginPanel.Controls.Add(Me.ResetB)
        Me.LoginPanel.Controls.Add(Me.LoginB)
        Me.LoginPanel.Controls.Add(Me.PasswordTB)
        Me.LoginPanel.Controls.Add(Me.UsernameTB)
        Me.LoginPanel.Controls.Add(Me.RightLogoPB)
        Me.LoginPanel.Controls.Add(Me.NewUserLL)
        Me.LoginPanel.Location = New System.Drawing.Point(427, 44)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(344, 470)
        Me.LoginPanel.TabIndex = 0
        '
        'ForgotPassLL
        '
        Me.ForgotPassLL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ForgotPassLL.AutoSize = True
        Me.ForgotPassLL.Location = New System.Drawing.Point(109, 250)
        Me.ForgotPassLL.Name = "ForgotPassLL"
        Me.ForgotPassLL.Size = New System.Drawing.Size(118, 20)
        Me.ForgotPassLL.TabIndex = 12
        Me.ForgotPassLL.TabStop = True
        Me.ForgotPassLL.Text = "forgot password"
        Me.ForgotPassLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResetB
        '
        Me.ResetB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ResetB.Location = New System.Drawing.Point(173, 301)
        Me.ResetB.Name = "ResetB"
        Me.ResetB.Size = New System.Drawing.Size(128, 29)
        Me.ResetB.TabIndex = 9
        Me.ResetB.Text = "Reset"
        Me.ResetB.UseVisualStyleBackColor = True
        '
        'LoginB
        '
        Me.LoginB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginB.Location = New System.Drawing.Point(42, 301)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.Size = New System.Drawing.Size(128, 29)
        Me.LoginB.TabIndex = 10
        Me.LoginB.Text = "Login"
        Me.LoginB.UseVisualStyleBackColor = True
        '
        'PasswordTB
        '
        Me.PasswordTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTB.Location = New System.Drawing.Point(33, 223)
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
        Me.UsernameTB.Location = New System.Drawing.Point(33, 181)
        Me.UsernameTB.Margin = New System.Windows.Forms.Padding(0)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(274, 27)
        Me.UsernameTB.TabIndex = 8
        Me.UsernameTB.Text = "Username"
        Me.UsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightLogoPB
        '
        Me.RightLogoPB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RightLogoPB.Image = CType(resources.GetObject("RightLogoPB.Image"), System.Drawing.Image)
        Me.RightLogoPB.Location = New System.Drawing.Point(99, 42)
        Me.RightLogoPB.Name = "RightLogoPB"
        Me.RightLogoPB.Size = New System.Drawing.Size(146, 96)
        Me.RightLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RightLogoPB.TabIndex = 11
        Me.RightLogoPB.TabStop = False
        '
        'NewUserLL
        '
        Me.NewUserLL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NewUserLL.AutoSize = True
        Me.NewUserLL.Location = New System.Drawing.Point(72, 380)
        Me.NewUserLL.Name = "NewUserLL"
        Me.NewUserLL.Size = New System.Drawing.Size(184, 20)
        Me.NewUserLL.TabIndex = 13
        Me.NewUserLL.TabStop = True
        Me.NewUserLL.Text = "New User? Create Account"
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
        'ChangePasswordPanel
        '
        Me.ChangePasswordPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangePasswordPanel.BackColor = System.Drawing.Color.Indigo
        Me.ChangePasswordPanel.Controls.Add(Me.BackToSecQuesB)
        Me.ChangePasswordPanel.Controls.Add(Me.PictureBox2)
        Me.ChangePasswordPanel.Controls.Add(Me.NextToLoginB)
        Me.ChangePasswordPanel.Controls.Add(Me.ConfirmPassTB)
        Me.ChangePasswordPanel.Controls.Add(Me.NewPassTB)
        Me.ChangePasswordPanel.Controls.Add(Me.ChangePassL)
        Me.ChangePasswordPanel.Location = New System.Drawing.Point(427, 44)
        Me.ChangePasswordPanel.Name = "ChangePasswordPanel"
        Me.ChangePasswordPanel.Size = New System.Drawing.Size(344, 470)
        Me.ChangePasswordPanel.TabIndex = 14
        Me.ChangePasswordPanel.Visible = False
        '
        'BackToLoginB
        '
        Me.BackToLoginB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackToLoginB.Location = New System.Drawing.Point(40, 337)
        Me.BackToLoginB.Name = "BackToLoginB"
        Me.BackToLoginB.Size = New System.Drawing.Size(127, 29)
        Me.BackToLoginB.TabIndex = 22
        Me.BackToLoginB.Text = "Back"
        Me.BackToLoginB.UseVisualStyleBackColor = True
        '
        'BackToSecQuesB
        '
        Me.BackToSecQuesB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackToSecQuesB.Location = New System.Drawing.Point(43, 375)
        Me.BackToSecQuesB.Name = "BackToSecQuesB"
        Me.BackToSecQuesB.Size = New System.Drawing.Size(127, 29)
        Me.BackToSecQuesB.TabIndex = 22
        Me.BackToSecQuesB.Text = "Back"
        Me.BackToSecQuesB.UseVisualStyleBackColor = True
        '
        'NextToSecQuesB
        '
        Me.NextToSecQuesB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NextToSecQuesB.Location = New System.Drawing.Point(173, 337)
        Me.NextToSecQuesB.Name = "NextToSecQuesB"
        Me.NextToSecQuesB.Size = New System.Drawing.Size(126, 29)
        Me.NextToSecQuesB.TabIndex = 21
        Me.NextToSecQuesB.Text = "Next"
        Me.NextToSecQuesB.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(99, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'NextToLoginB
        '
        Me.NextToLoginB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NextToLoginB.Location = New System.Drawing.Point(175, 375)
        Me.NextToLoginB.Name = "NextToLoginB"
        Me.NextToLoginB.Size = New System.Drawing.Size(127, 29)
        Me.NextToLoginB.TabIndex = 21
        Me.NextToLoginB.Text = "Next"
        Me.NextToLoginB.UseVisualStyleBackColor = True
        '
        'ConfirmPassTB
        '
        Me.ConfirmPassTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ConfirmPassTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConfirmPassTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmPassTB.Location = New System.Drawing.Point(41, 314)
        Me.ConfirmPassTB.Margin = New System.Windows.Forms.Padding(0)
        Me.ConfirmPassTB.Name = "ConfirmPassTB"
        Me.ConfirmPassTB.Size = New System.Drawing.Size(261, 34)
        Me.ConfirmPassTB.TabIndex = 20
        Me.ConfirmPassTB.Text = "Confirm Password"
        Me.ConfirmPassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewPassTB
        '
        Me.NewPassTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NewPassTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewPassTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewPassTB.Location = New System.Drawing.Point(41, 265)
        Me.NewPassTB.Margin = New System.Windows.Forms.Padding(0)
        Me.NewPassTB.Name = "NewPassTB"
        Me.NewPassTB.Size = New System.Drawing.Size(261, 34)
        Me.NewPassTB.TabIndex = 20
        Me.NewPassTB.Text = "New Password"
        Me.NewPassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChangePassL
        '
        Me.ChangePassL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChangePassL.AutoSize = True
        Me.ChangePassL.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChangePassL.ForeColor = System.Drawing.Color.White
        Me.ChangePassL.Location = New System.Drawing.Point(28, 182)
        Me.ChangePassL.Name = "ChangePassL"
        Me.ChangePassL.Size = New System.Drawing.Size(292, 45)
        Me.ChangePassL.TabIndex = 23
        Me.ChangePassL.Text = "Change Password"
        '
        'SecurityPanel
        '
        Me.SecurityPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SecurityPanel.BackColor = System.Drawing.Color.Indigo
        Me.SecurityPanel.Controls.Add(Me.SecurityL)
        Me.SecurityPanel.Controls.Add(Me.NextToNewPassB)
        Me.SecurityPanel.Controls.Add(Me.PictureBox1)
        Me.SecurityPanel.Controls.Add(Me.BackToEnterUnameB)
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
        Me.SecurityL.Location = New System.Drawing.Point(22, 206)
        Me.SecurityL.Name = "SecurityL"
        Me.SecurityL.Size = New System.Drawing.Size(295, 45)
        Me.SecurityL.TabIndex = 19
        Me.SecurityL.Text = "Security Question"
        '
        'SecLogo
        '
        Me.SecLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SecLogo.Image = CType(resources.GetObject("SecLogo.Image"), System.Drawing.Image)
        Me.SecLogo.Location = New System.Drawing.Point(99, 45)
        Me.SecLogo.Name = "SecLogo"
        Me.SecLogo.Size = New System.Drawing.Size(146, 96)
        Me.SecLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SecLogo.TabIndex = 18
        Me.SecLogo.TabStop = False
        '
        'NextToNewPassB
        '
        Me.NextToNewPassB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NextToNewPassB.Location = New System.Drawing.Point(174, 399)
        Me.NextToNewPassB.Name = "NextToNewPassB"
        Me.NextToNewPassB.Size = New System.Drawing.Size(128, 29)
        Me.NextToNewPassB.TabIndex = 16
        Me.NextToNewPassB.Text = "Next"
        Me.NextToNewPassB.UseVisualStyleBackColor = True
        '
        'BackToEnterUnameB
        '
        Me.BackToEnterUnameB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackToEnterUnameB.Location = New System.Drawing.Point(40, 399)
        Me.BackToEnterUnameB.Name = "BackToEnterUnameB"
        Me.BackToEnterUnameB.Size = New System.Drawing.Size(128, 29)
        Me.BackToEnterUnameB.TabIndex = 17
        Me.BackToEnterUnameB.Text = "Back"
        Me.BackToEnterUnameB.UseVisualStyleBackColor = True
        '
        'SecAnswerTB
        '
        Me.SecAnswerTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SecAnswerTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SecAnswerTB.Location = New System.Drawing.Point(33, 338)
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
        Me.SecQuestionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SecQuestionTB.Location = New System.Drawing.Point(33, 280)
        Me.SecQuestionTB.Margin = New System.Windows.Forms.Padding(0)
        Me.SecQuestionTB.Multiline = True
        Me.SecQuestionTB.Name = "SecQuestionTB"
        Me.SecQuestionTB.ReadOnly = True
        Me.SecQuestionTB.Size = New System.Drawing.Size(274, 43)
        Me.SecQuestionTB.TabIndex = 15
        Me.SecQuestionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'EnterUsernameTB
        '
        Me.EnterUsernameTB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EnterUsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EnterUsernameTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EnterUsernameTB.Location = New System.Drawing.Point(40, 241)
        Me.EnterUsernameTB.Margin = New System.Windows.Forms.Padding(0)
        Me.EnterUsernameTB.Name = "EnterUsernameTB"
        Me.EnterUsernameTB.Size = New System.Drawing.Size(261, 34)
        Me.EnterUsernameTB.TabIndex = 20
        Me.EnterUsernameTB.Text = "Username"
        Me.EnterUsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EnterUnameL
        '
        Me.EnterUnameL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EnterUnameL.AutoSize = True
        Me.EnterUnameL.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EnterUnameL.ForeColor = System.Drawing.Color.White
        Me.EnterUnameL.Location = New System.Drawing.Point(42, 158)
        Me.EnterUnameL.Name = "EnterUnameL"
        Me.EnterUnameL.Size = New System.Drawing.Size(267, 45)
        Me.EnterUnameL.TabIndex = 23
        Me.EnterUnameL.Text = "Enter Username"
        '
        'EnterUsernamePanel
        '
        Me.EnterUsernamePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnterUsernamePanel.BackColor = System.Drawing.Color.Indigo
        Me.EnterUsernamePanel.Controls.Add(Me.BackToLoginB)
        Me.EnterUsernamePanel.Controls.Add(Me.SecLogo)
        Me.EnterUsernamePanel.Controls.Add(Me.NextToSecQuesB)
        Me.EnterUsernamePanel.Controls.Add(Me.EnterUsernameTB)
        Me.EnterUsernamePanel.Controls.Add(Me.EnterUnameL)
        Me.EnterUsernamePanel.Location = New System.Drawing.Point(427, 44)
        Me.EnterUsernamePanel.Name = "EnterUsernamePanel"
        Me.EnterUsernamePanel.Size = New System.Drawing.Size(344, 470)
        Me.EnterUsernamePanel.TabIndex = 2
        Me.EnterUsernamePanel.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(774, 517)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.EnterUsernamePanel)
        Me.Controls.Add(Me.SecurityPanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.InfoPanel)
        Me.Controls.Add(Me.ChangePasswordPanel)
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
        Me.ChangePasswordPanel.ResumeLayout(False)
        Me.ChangePasswordPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SecurityPanel.ResumeLayout(False)
        Me.SecurityPanel.PerformLayout()
        CType(Me.SecLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnterUsernamePanel.ResumeLayout(False)
        Me.EnterUsernamePanel.PerformLayout()
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
    Friend WithEvents BackToEnterUnameB As Button
    Friend WithEvents SecAnswerTB As TextBox
    Friend WithEvents SecQuestionTB As TextBox
    Friend WithEvents SecurityL As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackToLoginB As Button
    Friend WithEvents NextToSecQuesB As Button
    Friend WithEvents EnterUsernameTB As TextBox
    Friend WithEvents EnterUnameL As Label
    Friend WithEvents EnterUsernamePanel As Panel
    Friend WithEvents ChangePasswordPanel As Panel
    Friend WithEvents BackToSecQuesB As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NextToLoginB As Button
    Friend WithEvents ConfirmPassTB As TextBox
    Friend WithEvents NewPassTB As TextBox
    Friend WithEvents ChangePassL As Label
End Class
