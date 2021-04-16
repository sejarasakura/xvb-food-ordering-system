Public Class AddUser
    Dim db As New FoodShopEntities1()
    Public username As String
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoGenerateId()
    End Sub
    Private Sub AutoGenerateId()
        Dim rs = (From c In db.Users).Count()
        lblId.Text = (99999 + rs).ToString()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim u As New User()
            u.user_id = lblId.Text
            u.username = txtName.Text
            u.user_email = txtEmail.Text
            u.phone_num = txtHPNumber.Text
            u.password = txtPassword.Text
            u.last_name = txtLName.Text
            u.first_name = txtFName.Text
            u.gender = txtGender.Text
            u.user_role = txtRole.Text
            db.Users.Add(u)
            db.SaveChanges()
            MessageBox.Show("User has been added.", "Add Data Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AutoGenerateId()
            clear()
        Catch ex As Exception
            MessageBox.Show("Invalid!!!" & vbNewLine & "Please fill up all, thanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub clear()
        txtName.Text = ""
        txtEmail.Text = ""
        txtHPNumber.Text = ""
        txtPassword.Text = ""
        txtLName.Text = ""
        txtFName.Text = ""
        txtGender.Text = ""
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
End Class