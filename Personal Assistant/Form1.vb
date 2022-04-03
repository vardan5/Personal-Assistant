Imports System.Data.SqlClient
Public Class Form1
    Dim loc As Point
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim Username As String


    'TitlePanel

    'For draging
    Private Sub TitlePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseDown, LogoPB.MouseDown, TitleL.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub
    Private Sub TitlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseMove, LogoPB.MouseMove, TitleL.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    'For TitlePanel Buttons
    Private Sub CloseB_Click(sender As Object, e As EventArgs) Handles CloseB.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
    Private Sub MinimizeB_Click(sender As Object, e As EventArgs) Handles MinimizeB.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    'For Drawing grey border for all right-side panels
    Private Sub LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginPanel.Paint, EnterUsernamePanel.Paint, SecurityPanel.Paint, ChangePasswordPanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)
    End Sub



    'LoginPanel

    'Username and Password Dissapearing Feature
    Private Sub UsernameTB_Enter(sender As Object, e As EventArgs) Handles UsernameTB.Enter, EnterUsernameTB.Enter
        If sender.Text = "Username" Then
            sender.Text = ""
        End If
    End Sub
    Private Sub UsernameTB_Leave(sender As Object, e As EventArgs) Handles UsernameTB.Leave, EnterUsernameTB.Leave
        If sender.Text = "" Then
            sender.Text = "Username"
        End If
    End Sub
    Private Sub PasswordTB_Enter(sender As Object, e As EventArgs) Handles PasswordTB.Enter
        If PasswordTB.Text = "Password" Then
            PasswordTB.Text = ""
        End If
    End Sub
    Private Sub PasswordTB_Leave(sender As Object, e As EventArgs) Handles PasswordTB.Leave
        If PasswordTB.Text = "" Then
            PasswordTB.Text = "Password"
        End If
    End Sub

    'LoginPanel Components

    Private Sub ForgotPassLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPassLL.LinkClicked
        'LoginPanel visible -> false
        'EnterUsernamePanel visible -> true
        LoginPanel.Visible = False
        EnterUsernamePanel.Visible = True
    End Sub

    Private Sub LoginB_Click(sender As Object, e As EventArgs) Handles LoginB.Click
        If CheckLoginCredentials() Then
            MsgBox("Login Successful", 0, "Login Successful")
            'Login Parameter of Dashboard set to true
            Me.DialogResult = DialogResult.Yes
            Me.Close()

        Else
            MsgBox("Invalid Credentials. Login Failed.", 0, "Login Failed")
        End If
    End Sub

    Private Sub ResetB_Click(sender As Object, e As EventArgs) Handles ResetB.Click
        UsernameTB.Text = "Username"
        PasswordTB.Text = "Password"
    End Sub

    Private Sub NewUserLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NewUserLL.LinkClicked

        Dim numberOfUsers As Integer = findNumberOfUsers()
        If numberOfUsers = 0 Then
            'Code for Adding new User
        Else
            MsgBox("Only 1 user can be enrolled as of now. For more info please contact the developer", 0, "User Limit Reached")
        End If

    End Sub




    'EnterUsernamePanel

    'EnterUsernamePanel Components
    Private Sub BackToLoginB_Click_1(sender As Object, e As EventArgs) Handles BackToLoginB.Click
        'LoginPanel visible -> true
        'EnterUsernamePanel visible -> false
        UsernameTB.Text = "Username"
        PasswordTB.Text = "Password"
        LoginPanel.Visible = True
        EnterUsernamePanel.Visible = False
    End Sub
    Private Sub NextToSecQuesB_Click(sender As Object, e As EventArgs) Handles NextToSecQuesB.Click
        UsernameTB.Text = "Username"
        PasswordTB.Text = "Password"
        'Getting Username
        Username = EnterUsernameTB.Text
        'To set QuestionTB
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT SecurityQuestion FROM [User] WHERE Username='" + Username + "';"
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Try
            SecQuestionTB.Text = dr("SecurityQuestion")
        Catch ex As InvalidOperationException
            MsgBox("Username not present in database. Try a different Username or create a new User.", 0, "Invalid Username")
            con.Close()
            Return
        End Try
        con.Close()
        'EnterUsernamePanel visible -> false
        'SecurityPanel visible -> true
        EnterUsernamePanel.Visible = False
        SecurityPanel.Visible = True

    End Sub




    'SecurityPanel

    'Security panel features
    Private Sub SecAnswerTB_Enter(sender As Object, e As EventArgs) Handles SecAnswerTB.Enter
        If sender.Text = "Answer" Then
            sender.Text = ""
        End If
    End Sub


    Private Sub SecAnswerTB_Leave(sender As Object, e As EventArgs) Handles SecAnswerTB.Leave
        If sender.Text = "" Then
            sender.Text = "Answer"
        End If
    End Sub

    'SecurityPanel Components
    Private Sub BackToEnterUnameB_Click(sender As Object, e As EventArgs) Handles BackToEnterUnameB.Click
        'EnterUsernameTB visible -> true
        'SecurityPanel visible -> false
        EnterUsernameTB.Text = ""
        EnterUsernamePanel.Visible = True
        SecurityPanel.Visible = False
    End Sub
    Private Sub NextToNewPassB_Click(sender As Object, e As EventArgs) Handles NextToNewPassB.Click
        EnterUsernameTB.Text = ""
        'Check if Security Answer match with database
        Dim secAnswerInput As String = SecAnswerTB.Text
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select SecurityAnswer from [User] where Username = '" + Username + "';"
        Dim dr As SqlDataReader = cmd.ExecuteReader
        dr.Read()
        If dr("SecurityAnswer") = secAnswerInput Then
            'Code to open Change Password Panel
            SecurityPanel.Visible = False
            ChangePasswordPanel.Visible = True
        Else
            MsgBox("The Security Answer given is incorrect. Please try again.", 0, "Attempt Failed")
        End If
        con.Close()
    End Sub


    'For ChangePasswordPanel

    'ChangePasswordPanel Features
    Private Sub NewPassTB_Enter(sender As Object, e As EventArgs) Handles NewPassTB.Enter
        If sender.Text = "New Password" Then
            sender.Text = ""
        End If
    End Sub
    Private Sub NewPassTB_Leave(sender As Object, e As EventArgs) Handles NewPassTB.Leave
        If sender.Text = "" Then
            sender.Text = "New Password"
        End If
    End Sub
    Private Sub ConfirmPassTB_Enter(sender As Object, e As EventArgs) Handles ConfirmPassTB.Enter
        If sender.Text = "Confirm Password" Then
            sender.Text = ""
        End If
    End Sub
    Private Sub ConfirmPassTB_Leave(sender As Object, e As EventArgs) Handles ConfirmPassTB.Leave
        If sender.Text = "" Then
            sender.Text = "Confirm Password"
        End If
    End Sub


    'ChangePasswordPanel Components

    Private Sub BackToSecQuesB_Click(sender As Object, e As EventArgs) Handles BackToSecQuesB.Click
        SecAnswerTB.Text = ""
        ChangePasswordPanel.Visible = False
        SecurityPanel.Visible = True
    End Sub

    Private Sub NextToLoginB_Click(sender As Object, e As EventArgs) Handles NextToLoginB.Click
        SecAnswerTB.Text = ""
        Dim newPass As String = NewPassTB.Text
        If ConfirmPassTB.Text <> newPass Then
            MsgBox("The entered passwords do not match. Please try again.", 0, "Passwords do not match")
            NewPassTB.Text = ""
            ConfirmPassTB.Text = ""

        ElseIf newPass = "" Then
            MsgBox("Password cannot be empty. Please enter a valid password.")

        Else
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Update [User] SET [Password] = '" + newPass + "' WHERE Username = '" + Username + "';"
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Password changed Successfully. You will be taken back to the Login page now. ", 0, "Change Successful")
                'Change to LoginPanel
                NewPassTB.Text = ""
                ConfirmPassTB.Text = ""
                UsernameTB.Text = "Username"
                PasswordTB.Text = "Password"
                LoginPanel.Visible = True
                ChangePasswordPanel.Visible = False
            Else
                MsgBox("Password change failed. Try again. Contact developer if problem persists.", 0, "Change failed")
                NewPassTB.Text = ""
                ConfirmPassTB.Text = ""
            End If
        End If
        con.Close()
    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox(Application.UserAppDataPath)
        Dim DBLocation As String
        'Store the location of the database here
        DBLocation = "E:\VB Project\Personal Assistant\Personal Assistant\Personal Assistant\PersonalAssistantDB.mdf"
        'Setting Connection String
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & DBLocation & ";Integrated Security=True"

    End Sub




    'User Defined Functions and Subs

    Private Function findNumberOfUsers() As Integer
        Dim temp As Integer
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(Username) FROM [User];"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        dr1.Read()
        temp = dr1("")
        con.Close()
        Return temp

    End Function

    Private Function CheckLoginCredentials() As Boolean
        Dim Pass As String
        Dim UnameInput As String = UsernameTB.Text
        Dim PassInput As String = PasswordTB.Text
        Dim Answer As Boolean = False
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT Username,Password FROM [User];"
        Dim dr1 As SqlDataReader
        dr1 = cmd.ExecuteReader
        While dr1.Read()
            Username = dr1("Username")
            Pass = dr1("Password")
            If Username = UnameInput And Pass = PassInput Then
                Answer = True
            End If
        End While
        con.Close()
        Return Answer
    End Function

End Class
