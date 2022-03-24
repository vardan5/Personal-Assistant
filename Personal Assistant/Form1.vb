Imports System.Data.SqlClient
Public Class Form1
    Dim loc As Point
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim Username As String 'Username

    Private Sub TitlePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If

    End Sub
    'For draging titlebar
    Private Sub TitlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub
    'For draging titlebar

    Private Sub LogoPB_MouseDown(sender As Object, e As MouseEventArgs) Handles LogoPB.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub
    'For draging titlebar
    Private Sub LogoPB_MouseMove(sender As Object, e As MouseEventArgs) Handles LogoPB.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub
    'For draging titlebar

    Private Sub LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginPanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)
    End Sub
    'For Drawing grey Panel border

    Private Sub SecurityPanel_Paint(sender As Object, e As PaintEventArgs) Handles SecurityPanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)
    End Sub
    'For Drawing grey Panel border

    Private Sub ClosePB_Click(sender As Object, e As EventArgs) Handles ClosePB.Click
        Me.Close()
    End Sub
    'For closing

    Private Sub MinimizePB_Click(sender As Object, e As EventArgs) Handles MinimizePB.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'For minimising

    Private Sub UsernameTB_Enter(sender As Object, e As EventArgs) Handles UsernameTB.Enter
        If UsernameTB.Text = "Username" Then
            UsernameTB.Text = ""
        End If
    End Sub
    'Username Feature
    Private Sub UsernameTB_Leave(sender As Object, e As EventArgs) Handles UsernameTB.Leave
        If UsernameTB.Text = "" Then
            UsernameTB.Text = "Username"
        End If
    End Sub
    'Username Feature

    Private Sub PasswordTB_Enter(sender As Object, e As EventArgs) Handles PasswordTB.Enter
        If PasswordTB.Text = "Password" Then
            PasswordTB.Text = ""
        End If
    End Sub
    'Password Feature
    Private Sub PasswordTB_Leave(sender As Object, e As EventArgs) Handles PasswordTB.Leave
        If PasswordTB.Text = "" Then
            PasswordTB.Text = "Password"
        End If
    End Sub
    'Password Feature



    'Interactions (Buttons, Labels)

    Private Sub ForgotPassLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPassLL.LinkClicked
        'LoginPanel visible -> false
        'SecurityPanel visible -> true
        LoginPanel.Visible = False
        SecurityPanel.Visible = True

    End Sub

    Private Sub LoginB_Click(sender As Object, e As EventArgs) Handles LoginB.Click
        If checkCredentials() Then
            MsgBox("Login Successful", 0, "Login Successful")
            'Load Dashboard Form here

        Else
            MsgBox("Invalid Credentials", 0, "Login Failed")
        End If
    End Sub

    Private Sub ResetB_Click(sender As Object, e As EventArgs) Handles ResetB.Click
        UsernameTB.Text = "Username"
        PasswordTB.Text = "Password"
    End Sub
    'For resetting textboxes

    Private Sub NewUserLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NewUserLL.LinkClicked

        Dim numberOfUsers As Integer = findNumberOfUsers()
        If numberOfUsers = 0 Then

        Else
            MsgBox("Only 1 user can be enrolled as of now. For more info please contact the developer", 0, "User Limit Reached")
        End If

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting Connection String
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\VB Project\Personal Assistant\Personal Assistant\Personal Assistant\PersonalAssistantDB.mdf;Integrated Security=True"

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

    Private Function checkCredentials() As Boolean
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
