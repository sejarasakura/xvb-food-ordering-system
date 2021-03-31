Public Class Register
    Dim db As New FoodShopDataContext()

    Private Sub AutoGenerateCustId()
        Dim rs = (From c In db.Customers).Count()
        lblCustId.Text = "c" & (100000000 + rs).ToString()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoGenerateCustId()
    End Sub

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

    Private Function IsDuplicatedName(strName As String) As Boolean
        Dim db As New FoodShopDataContext()
        Return db.Customers.Any(Function(o) o.cust_name = strName)
    End Function

    Private Function IsDuplicatedEmail(strEmail As String) As Boolean
        Dim db As New FoodShopDataContext()
        Return db.Customers.Any(Function(o) o.cust_email = strEmail)
    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim strName As String = txtUserName.Text.Trim()
        Dim strEmail As String = txtEmail.Text.Trim()
        Dim strPassword As String = txtPassword.Text.Trim()
        Dim strCPassword As String = txtConfirmPassword.Text.Trim()

        err.Tag = Nothing

        If strName = "Username" Then
                err.SetError(txtUserName, "Please type [Username]")
                err.Tag = If(err.Tag, txtUserName)
            ElseIf IsDuplicatedName(strName) Then
                err.SetError(txtUserName, "This [Username] is already taken")
                err.Tag = If(err.Tag, txtUserName)
            Else
                err.SetError(txtUserName, Nothing)
            End If

            If strEmail = "Email" Then
                err.SetError(txtEmail, "Please type [Email]")
                err.Tag = If(err.Tag, txtEmail)
            ElseIf IsDuplicatedEmail(strEmail) Then
                err.SetError(txtEmail, "[Email] is already registered")
                err.Tag = If(err.Tag, txtEmail)
            Else
                err.SetError(txtEmail, Nothing)
            End If

        If strPassword = "Password" And strCPassword = "Confirm Password" Then
            err.SetError(txtPassword, "Please type [Password]")
            err.Tag = If(err.Tag, txtPassword)
            err.SetError(txtConfirmPassword, "Please type [Confirm Password]")
            err.Tag = If(err.Tag, txtConfirmPassword)
        Else
            err.SetError(txtPassword, Nothing)
            err.SetError(txtConfirmPassword, Nothing)
        End If

        If strCPassword <> strPassword And strPassword <> "Password" AndAlso strCPassword <> "Confirm Password" Then
            MessageBox.Show("Comfirm Password does not match!" & vbNewLine & "Please fill up again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If err.Tag IsNot Nothing Then
                CType(err.Tag, Control).Focus()
                Return
            End If

            Dim c As New Customer()
            c.user_id = lblCustId.Text
            c.cust_name = strName
            c.cust_email = strEmail
            c.cust_password = strPassword

            Dim db As New FoodShopDataContext()
            db.Customers.InsertOnSubmit(c)
            db.SubmitChanges()

            MessageBox.Show("Successfully Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class