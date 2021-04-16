Public Class DebugScreen

    Dim combo As ComboBox.ObjectCollection
    Dim data_dic As Dictionary(Of String, System.Windows.Forms.Form) = New Dictionary(Of String, System.Windows.Forms.Form)()

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Screen.NAV_HOME_SCREEN.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Screen.NAV_ORDER_SCREEN.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Screen.NAV_PAYMENT_SCREEN.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Screen.NAV_SPLASH_SCREEN.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        'Screen.ALERT_DEBUG.Show()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Screen.NAV_FORM1_CUST.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Screen.NAV_FORM2_STAFF.Show()
    End Sub
End Class