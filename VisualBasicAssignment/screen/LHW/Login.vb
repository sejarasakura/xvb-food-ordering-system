Public Class Login
    Dim db As New FoodShopDataContext()

    Sub Page_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"

        Dim dbName As User = db.Users.SingleOrDefault(Function(c) c.username = Name)
        Me.btnCancel.BackColor = VRColor.WARNING_COLOR
        Me.btnLogin.BackColor = VRColor.COLORED_BG
        Me.MaximumSize = Me.Size
        'No Content
    End Sub

    Private Sub cancleBtnOnclick(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As New FoodShopDataContext()
        Dim name As String = txtName.Text()
        Dim password As String = txtPassword.Text()
        Dim dbName As User = db.Users.SingleOrDefault(Function(c) c.username = name)
        Dim dbPassword As User = db.Users.SingleOrDefault(Function(c) c.password = txtPassword.Text And c.username = name)

        err.Tag = Nothing

        If name = "" Then
            err.SetError(txtName, "Please type username!")
            err.Tag = If(err.Tag, txtName)
        End If
        If password = "" Then
            err.SetError(txtPassword, "Please type password!")
            err.Tag = If(err.Tag, txtPassword)
        Else
            If dbName Is Nothing Then
                err.SetError(txtName, "Please Insert Valid Username!")
                err.Tag = If(err.Tag, txtName)
            Else
                If dbPassword Is Nothing Then
                    err.SetError(txtPassword, "Please Insert Valid Password!")
                    err.Tag = If(err.Tag, txtPassword)
                ElseIf dbName.user_role = "c" Then
                    Me.Hide()
                    Profile.username = name
                    UserRecordReport.Show()
                ElseIf dbName.user_role = "s" Then
                    Me.Hide()
                    Profile.username = name
                    UserRecordReport.Show()
                End If
            End If
        End If

    End Sub

    Private Sub tbxName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Register.ShowDialog(Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ForgotPassword.ShowDialog(Me)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class