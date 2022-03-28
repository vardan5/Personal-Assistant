Public Class Dashboard
    Dim loc As Point


    Private Sub Dashboard_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid)
    End Sub



    'TitlePanel

    'For draging
    Private Sub TitlePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseDown ', LogoPB.MouseDown, TitleL.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub
    Private Sub TitlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseMove ', LogoPB.MouseMove, TitleL.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    'For TitlePanel Buttons
    Private Sub ClosePB_Click(sender As Object, e As EventArgs) Handles ClosePB.Click
        Me.Close()
    End Sub
    Private Sub MinimizePB_Click(sender As Object, e As EventArgs) Handles MinimizePB.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles MinimizePB.MouseEnter, ClosePB.MouseEnter
        'sender.BorderStyle = BorderStyle.FixedSingle
        sender.BackColor = Color.FromArgb(200, 76, 0, 130)
    End Sub
    Private Sub Buttun_MouseLeave(sender As Object, e As EventArgs) Handles MinimizePB.MouseLeave, ClosePB.MouseLeave
        'sender.BorderStyle = BorderStyle.None
        sender.BackColor = Color.FromArgb(0, 255, 255, 255)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.WindowState = FormWindowState.Maximized
        'Form1.ShowDialog()

    End Sub

End Class