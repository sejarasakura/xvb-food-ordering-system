Public Class ModifyUser
    Public fid As String
    Dim db As New FoodShopDataContext()
    Private Sub ModifyUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs = From u In db.Users Where u.user_id = fid
        For Each result In rs
            lblId.Text = fid
            txtName.Text = result.username
            txtEmail.Text = result.user_email
            txtRole.Text = result.user_role
            txtFName.Text = result.first_name
            txtLName.Text = result.last_name
            txtHPNumber.Text = result.phone_num
            txtGender.Text = result.gender
            txtPassword.Text = result.password
            txtRole.Text = result.user_role
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim u As User = db.Users.FirstOrDefault(Function(i) i.user_id = fid)
        Try
            u.username = txtName.Text
            u.user_email = txtEmail.Text
            u.user_role = txtRole.Text
            u.first_name = txtFName.Text
            u.last_name = txtLName.Text
            u.phone_num = txtHPNumber.Text
            u.gender = txtGender.Text
            u.password = txtPassword.Text
            u.user_role = txtRole.Text
            db.SubmitChanges()
            MessageBox.Show("The data have been updated!!!", "Update Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Invalid!!!" & vbNewLine & "Please fill up all, thanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class