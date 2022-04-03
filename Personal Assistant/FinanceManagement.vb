Imports Personal_Assistant.FinanceManagementModule
Public Class FinanceManagement
    Dim GroupBoxFont As New Font("Segoe UI", 10)

    'For TitlePanel Grey Border
    Private Sub TitlePanel_Paint(sender As Object, e As PaintEventArgs) Handles TitlePanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)

    End Sub

    'For Dynamically adjusting Splitter location
    Private Sub BasePanel_SizeChanged(sender As Object, e As EventArgs) Handles BasePanel.SizeChanged
        'For Adjusting Splitter location
        Dim width As Integer = BasePanel.Width
        ButtonPanel.Width = width * 0.67

    End Sub

    'For Changing font
    Private Sub ButtonPanel_SizeChanged(sender As Object, e As EventArgs) Handles ButtonPanel.SizeChanged
        'If ButtonPanel.Width < 
    End Sub




    'PANEL BUTTONS
    Private Sub AddTransactionB_Click(sender As Object, e As EventArgs) Handles AddTransactionB.Click
        BasePanel.Visible = False
        BasePanel.Enabled = False
        HorizondalSplitPanel.Visible = True
        HorizondalSplitPanel.Enabled = True
    End Sub

    Private Sub CancelTransactionB_Click(sender As Object, e As EventArgs) Handles CancelTransactionB.Click
        BasePanel.Visible = True
        BasePanel.Enabled = True
        AmountTB.Text = ""
        DescriptionTB.Text = ""
        HorizondalSplitPanel.Visible = False
        HorizondalSplitPanel.Enabled = False

    End Sub
End Class