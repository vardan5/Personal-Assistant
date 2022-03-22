Public Class Form1
    Dim loc As Point

    Private Sub TitlePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If

    End Sub 'For draging titlebar

    Private Sub TitlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub 'For draging titlebar

    Private Sub LogoPB_MouseDown(sender As Object, e As MouseEventArgs) Handles LogoPB.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub 'For draging titlebar

    Private Sub LogoPB_MouseMove(sender As Object, e As MouseEventArgs) Handles LogoPB.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub 'For draging titlebar



    Private Sub ClosePB_Click(sender As Object, e As EventArgs) Handles ClosePB.Click
        Me.Close()
    End Sub 'For closing

    Private Sub MinimizePB_Click(sender As Object, e As EventArgs) Handles MinimizePB.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub 'For minimising



    Private Sub ResetB_Click(sender As Object, e As EventArgs) Handles ResetB.Click
        UsernameTB.Text = "Username"
        PasswordTB.Text = "Password"
    End Sub 'For resetting textboxes


    Private Sub UsernameTB_Enter(sender As Object, e As EventArgs) Handles UsernameTB.Enter
        If UsernameTB.Text = "Username" Then
            UsernameTB.Text = ""
        End If
    End Sub 'Username Feature


    Private Sub UsernameTB_Leave(sender As Object, e As EventArgs) Handles UsernameTB.Leave
        If UsernameTB.Text = "" Then
            UsernameTB.Text = "Username"
        End If
    End Sub 'Username Feature

    Private Sub PasswordTB_Enter(sender As Object, e As EventArgs) Handles PasswordTB.Enter
        If PasswordTB.Text = "Password" Then
            PasswordTB.Text = ""
        End If
    End Sub 'Password Feature

    Private Sub PasswordTB_Leave(sender As Object, e As EventArgs) Handles PasswordTB.Leave
        If PasswordTB.Text = "" Then
            PasswordTB.Text = "Password"
        End If
    End Sub 'Password Feature

    Private Sub LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginPanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)
    End Sub
End Class
