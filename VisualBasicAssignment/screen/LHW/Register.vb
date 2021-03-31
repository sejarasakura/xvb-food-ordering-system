Public Class Register
    Dim err As New ErrorProvider

    Private Sub txtUserName_GotFocus(sender As Object, e As EventArgs) Handles txtUserName.GotFocus
        If txtUserName.Text = "" Or txtUserName.Text = "Username" Then
            txtUserName.Text = ""
        End If
    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        If txtEmail.Text = "" Or txtEmail.Text = "Email" Then
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "" Or txtPassword.Text = "Password" Then
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub txtConfirmPassword_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.GotFocus
        If txtConfirmPassword.Text = "" Or txtConfirmPassword.Text = "Confirm Password" Then
            txtConfirmPassword.Text = ""
        End If
    End Sub

    Private Sub txtUserName_LostFocus(sender As Object, e As EventArgs) Handles txtUserName.LostFocus
        If txtUserName.Text = "" Or txtUserName.Text = "Username" Then
            txtUserName.Text = "Username"
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Or txtEmail.Text = "Email" Then
            txtEmail.Text = "Email"
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Or txtPassword.Text = "Password" Then
            txtPassword.Text = "Password"
        End If
    End Sub

    Private Sub txtConfirmPassword_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.LostFocus
        If txtConfirmPassword.Text = "" Or txtConfirmPassword.Text = "Confirm Password" Then
            txtConfirmPassword.Text = "Confirm Password"
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim strName As String = txtUserName.Text()
        Dim strEmail As String = txtEmail.Text()
        Dim strPassword As String = txtPassword.Text()
        Dim strCPassword As String = txtConfirmPassword.Text()

        Err.Tag = Nothing

        If strName = "" Then
            err.SetError(txtUserName, "Please type [Username]")
            err.Tag = If(err.Tag, txtUserName)
        Else
            err.SetError(txtUserName, Nothing)
        End If
        If strEmail = "" Then
            err.SetError(txtEmail, "Please type [Email]")
            err.Tag = If(Err.Tag, txtEmail)
        Else
            err.SetError(txtEmail, Nothing)
        End If
        If strPassword = "" Then
            err.SetError(txtPassword, "Please type [Password]")
            err.Tag = If(Err.Tag, txtPassword)
        Else
            err.SetError(txtPassword, Nothing)
        End If
        If strCPassword = "" Then
            err.SetError(txtConfirmPassword, "Please type [Confirm Password]")
            err.Tag = If(err.Tag, txtConfirmPassword)
        Else
            err.SetError(txtConfirmPassword, Nothing)
        End If
        If Err.Tag IsNot Nothing Then
            CType(Err.Tag, Control).Focus()
            Return
        End If

        Dim c As New Customer()
        c.cust_name = strName
        c.cust_email = strEmail
        c.cust_password = strPassword

        Dim db As New FoodShopDataContext()
        db.Customers.InsertOnSubmit(c)
        db.SubmitChanges()

        MessageBox.Show("Successfully Registered")
    End Sub
End Class