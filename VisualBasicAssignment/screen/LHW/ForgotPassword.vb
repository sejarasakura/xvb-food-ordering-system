Public Class ForgotPassword
    Dim db As New FoodShopEntities1()
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim rs = From u In db.Users
            Dim check As Boolean = False
            For Each result In rs
                If result.phone_num = txtPhoneNum.Text And result.user_email = txtEmail.Text Then
                    check = True
                End If
            Next
            If check = True Then
                rs = From s In db.Users Where s.user_email = txtEmail.Text And s.phone_num = txtPhoneNum.Text
                For Each result In rs
                    txtUsername.Text = result.username
                    txtPassword.Text = result.password
                Next
            Else
                MessageBox.Show("Invalid both or one the Email or Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class