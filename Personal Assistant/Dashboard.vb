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
    Private Sub CloseB_Click(sender As Object, e As EventArgs) Handles CloseB.Click
        Me.Close()
    End Sub
    Private Sub MinimizeB_Click(sender As Object, e As EventArgs) Handles MinimizeB.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub






    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Form1.ShowDialog()
        If Form1.DialogResult = DialogResult.No Then
            Application.Exit()
        End If
    End Sub

    Private Sub FinanceManagerNavB_Click(sender As Object, e As EventArgs) Handles FinanceManagerNavB.Click

    End Sub

    Private Sub TaskManagerNavB_Click(sender As Object, e As EventArgs) Handles TaskManagerNavB.Click

    End Sub

End Class