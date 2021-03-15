Public Class Profile
    Private Sub ProfileScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtPassowrd.Clear()
        txtConfirmPassword.Clear()
        txtEmail.Clear()
        txtHPNumber.Clear()
    End Sub
End Class