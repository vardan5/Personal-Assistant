Public Class Dashboard
    Dim loc As Point
    Friend currentUserControl As UserControl

    Private Sub Dashboard_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 75, 0, 130), 3, ButtonBorderStyle.Solid)
    End Sub

    'FOR TITLE PANEL
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



    'FOR NAVIGAION PANEL
    Private Sub HomeNav_Click(sender As Object, e As EventArgs) Handles HomeNavB.Click
        'deactivating previously active UC
        currentUserControl.Enabled = False
        currentUserControl.Visible = False
        'Activating Required UC
        Home1.Enabled = True
        Home1.Visible = True
        'Setting new value for currentUC
        currentUserControl = Home1
    End Sub

    Private Sub FinanceManagerNavB_Click(sender As Object, e As EventArgs) Handles FinanceManagerNavB.Click
        'deactivating previously active UC
        currentUserControl.Enabled = False
        currentUserControl.Visible = False
        'Activating Required UC
        FinanceManagement1.Enabled = True
        FinanceManagement1.Visible = True
        'Setting new value for currentUC
        currentUserControl = FinanceManagement1
    End Sub

    Private Sub TaskManagerNavB_Click(sender As Object, e As EventArgs) Handles TaskManagerNavB.Click
        'deactivating previously active UC
        currentUserControl.Enabled = False
        currentUserControl.Visible = False
        'Activating Required UC
        TaskManagement1.Enabled = True
        TaskManagement1.Visible = True
        'Setting new value for currentUC
        currentUserControl = TaskManagement1
    End Sub

    Private Sub HealthMonitorNavB_Click(sender As Object, e As EventArgs) Handles HealthMonitorNavB.Click
        'deactivating previously active UC
        currentUserControl.Enabled = False
        currentUserControl.Visible = False
        'Activating Required UC
        HealthMonitoring1.Enabled = True
        HealthMonitoring1.Visible = True
        'Setting new value for currentUC
        currentUserControl = HealthMonitoring1
    End Sub




    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Enabled = False
        'Checking for Login Result
        Form1.ShowDialog()
        If Form1.DialogResult = DialogResult.No Then
            Application.Exit()
        End If
        If Form1.DialogResult = DialogResult.Yes Then
            Me.Enabled = True
        End If


        'For 
        currentUserControl = Home1

    End Sub

End Class