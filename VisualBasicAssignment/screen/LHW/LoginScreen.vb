﻿Public Class LoginScreen
    Sub Page_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cancleBtn.BackColor = VRColor.WARNING_COLOR
        Me.loginBtn.BackColor = VRColor.COLORED_BG
        Me.MaximumSize = Me.Size
        'No Content
    End Sub

    Private Sub cancleBtnOnclick(sender As Object, e As EventArgs) Handles cancleBtn.Click
        Me.Hide()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Screen.NAV_HOME_SCREEN.Show()
        Me.Hide()
    End Sub
End Class