Public Class FinanceManagement

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles TitlePanel.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid, Color.FromArgb(255, 32, 32, 32), 3, ButtonBorderStyle.Solid)

    End Sub

    Private Sub BasePanel_SizeChanged(sender As Object, e As EventArgs) Handles BasePanel.SizeChanged
        Dim width As Integer = BasePanel.Width
        'MsgBox("Size changed")
        ButtonPanel.Width = width * 0.67

    End Sub
End Class
