Imports System.Text

Public Class Login
    Sub Page_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cancleBtn.BackColor = VRColor.WARNING_COLOR
        Me.loginBtn.BackColor = VRColor.COLORED_BG
        Me.MaximumSize = Me.Size
        'No Content
    End Sub

    Private Sub cancleBtnOnclick(sender As Object, e As EventArgs) Handles cancleBtn.Click
        Me.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim name = tbxName.Text.Replace(" ", "")
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If name = "" Then
            err.AppendLine("Please Insert Username!")
            ctr = If(ctr, tbxName)
        End If

    End Sub

    Private Sub tbxName_TextChanged(sender As Object, e As EventArgs) Handles tbxName.TextChanged

    End Sub
End Class