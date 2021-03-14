Imports System.Text

Public Class Login
    Sub Page_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnCancel.BackColor = VRColor.WARNING_COLOR
        Me.btnLogin.BackColor = VRColor.COLORED_BG
        Me.MaximumSize = Me.Size
        'No Content
    End Sub

    Private Sub cancleBtnOnclick(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim name = txtName.Text.Replace(" ", "")
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If name = "" Then
            err.AppendLine("Please Insert Username!")
            ctr = If(ctr, txtName)
        End If
        If txtPassword.Text = "" Then
            err.AppendLine("Please Insert Password!")
            ctr = If(ctr, txtPassword)
        Else
            Me.Hide()
            Profile.Show()
        End If
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ctr.Focus()
            Return
        End If

    End Sub

    Private Sub tbxName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Me.Hide()
        Register.Show()
    End Sub
End Class