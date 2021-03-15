Public Class PaymentInfo
    Private Sub titleLabel_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub PaymentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Left = (Me.Width / 2) - (lblTitle.Width / 2)
    End Sub
End Class
