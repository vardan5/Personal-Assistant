Public Class Home
    'For TitlePanel Grey Border
    Private Sub TitlePanel_Paint(sender As Object, e As PaintEventArgs) Handles TitlePanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)

    End Sub

    'For Dynamically adjusting Splitter location
    Private Sub BasePanel_SizeChanged(sender As Object, e As EventArgs) Handles BasePanel.SizeChanged
        Dim width As Integer = BasePanel.Width
        ButtonPanel.Width = width * 0.67
    End Sub

    Private Sub FinanceManagementB_Click(sender As Object, e As EventArgs) Handles FinanceManagementB.Click
        Dashboard.currentUserControl.Visible = False
        'deactivating previously active UC
        Dashboard.currentUserControl.Enabled = False
        Dashboard.currentUserControl.Visible = False
        'Activating Required UC
        Dashboard.FinanceManagement1.Enabled = True
        Dashboard.FinanceManagement1.Visible = True
        'Setting new value for currentUC
        Dashboard.currentUserControl = Dashboard.FinanceManagement1
    End Sub

    Private Sub TaskManagementB_Click(sender As Object, e As EventArgs) Handles TaskManagementB.Click
        Dashboard.currentUserControl.Visible = False
        'deactivating previously active UC
        Dashboard.currentUserControl.Enabled = False
        Dashboard.currentUserControl.Visible = False
        'Activating Required UC
        Dashboard.TaskManagement1.Enabled = True
        Dashboard.TaskManagement1.Visible = True
        'Setting new value for currentUC
        Dashboard.currentUserControl = Dashboard.TaskManagement1
    End Sub

    Private Sub HealthMonitoring_Click(sender As Object, e As EventArgs) Handles HealthMonitoring.Click
        Dashboard.currentUserControl.Visible = False
        'deactivating previously active UC
        Dashboard.currentUserControl.Enabled = False
        Dashboard.currentUserControl.Visible = False
        'Activating Required UC
        Dashboard.HealthMonitoring1.Enabled = True
        Dashboard.HealthMonitoring1.Visible = True
        'Setting new value for currentUC
        Dashboard.currentUserControl = Dashboard.HealthMonitoring1
    End Sub
End Class
