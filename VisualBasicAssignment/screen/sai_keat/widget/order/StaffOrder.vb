Public Class StaffOrder

    Sub switchPanel2(ByVal panel As Control)
        Panel1.Controls.Clear()
        panel.Show()
        panel.Visible = True
        Panel1.Controls.Add(panel)
    End Sub

    Private Sub lnkNewOrder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNewOrder.LinkClicked
        switchPanel2(New NewOder())
    End Sub

    Private Sub linkSalesReport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSalesReport.LinkClicked
        switchPanel2(New SalesReport())
    End Sub

    Private Sub lnkPaymentReport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPaymentReport.LinkClicked
        switchPanel2(New PaymnetReport())
    End Sub

    Private Sub StaffOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel2(New NewOder())
    End Sub
End Class
