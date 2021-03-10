Public Class loginform
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Form1.Show()
        Me.Close()

    End Sub
End Class