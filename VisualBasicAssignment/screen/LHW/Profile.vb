Public Class Profile
    Dim db As New FoodShopEntities1()
    Public username As String

    Private Sub ProfileScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim u As User = db.Users.FirstOrDefault(Function(i) i.username = username)
        loaddata()

        If u IsNot Nothing Then

            If u.user_role = "s" Then
                grpBox.Text = "Staff Information"
            Else
                If u.user_role = "c" Then
                    grpBox.Text = "Customer Information"
                End If
            End If

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtEmail.Clear()
        txtHPNumber.Clear()
        txtPassword.Clear()
        txtCPassword.Clear()
        txtLName.Clear()
        txtFName.Clear()
        txtGender.Clear()
    End Sub

    Private Sub txtReset_Click(sender As Object, e As EventArgs) Handles txtReset.Click
        Dim u As User = db.Users.FirstOrDefault(Function(i) i.username = username)
        If txtName.Text = "" Then
            MessageBox.Show("User Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtName.Text <> u.username Then
                u.username = txtName.Text
                db.SaveChanges()
                MessageBox.Show("The User Name already change!!!", "Successful Change User Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("User Email can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtEmail.Text <> u.user_email Then
                u.user_email = txtEmail.Text
                db.SaveChanges()
                MessageBox.Show("The Email already change!!!", "Successful Change Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If txtHPNumber.Text = "" Then
            MessageBox.Show("User H/P Number can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtHPNumber.Text <> u.phone_num Then
                u.phone_num = txtHPNumber.Text
                db.SaveChanges()
                MessageBox.Show("The H/P Number already change!!!", "Successful Change H/P Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If txtLName.Text = "" Then
            MessageBox.Show("User Last Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtLName.Text <> u.last_name Then
                u.last_name = txtLName.Text
                db.SaveChanges()
                MessageBox.Show("The Last Name already change!!!", "Successful Change Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If txtFName.Text = "" Then
            MessageBox.Show("First Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtFName.Text <> u.first_name Then
                u.first_name = txtFName.Text
                db.SaveChanges()
                MessageBox.Show("The First Name already change!!!", "Successful Change First Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If txtGender.Text = "" Then
            MessageBox.Show("Gender can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtGender.Text <> u.gender Then
                u.gender = txtGender.Text
                db.SaveChanges()
                MessageBox.Show("The Gender already change!!!", "Successful Change Gender", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If txtCPassword.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Invalid Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtCPassword.Text <> "" Then
                If txtCPassword.Text = txtPassword.Text Then
                    u.password = txtPassword.Text
                    db.SaveChanges()
                    MessageBox.Show("The Password already change!!!", "Successful Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCPassword.Text = ""
                Else
                    MessageBox.Show("The Comfirm password is not same with the Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Private Sub AutoGenerateCustId()
        Dim rs = (From c In db.Users).Count()
        lblId.Text = (99999 + rs).ToString()
    End Sub

    Private Sub loaddata()
        Dim rs = From s In db.Users Where s.username = username
        For Each result In rs
            AutoGenerateCustId()
            txtName.Text = result.username
            txtEmail.Text = result.user_email
            txtHPNumber.Text = result.phone_num
            txtPassword.Text = result.password
            txtLName.Text = result.last_name
            txtFName.Text = result.first_name
            txtGender.Text = result.gender
        Next
    End Sub
End Class