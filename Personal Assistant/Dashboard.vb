Public Class Dashboard
    Dim loc As Point

    Private Sub Dashboard_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid)
    End Sub



    'TitlePanel

    'For draging
    Private Sub TitlePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePanel1.MouseDown ', LogoPB.MouseDown, TitleL.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub
    Private Sub TitlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePanel1.MouseMove ', LogoPB.MouseMove, TitleL.MouseMove
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
        Me.Enabled = False
        Form1.ShowDialog()
        If Form1.DialogResult = DialogResult.No Then
            Application.Exit()
        End If
        If Form1.DialogResult = DialogResult.Yes Then
            Me.Enabled = True
        End If

    End Sub


End Class