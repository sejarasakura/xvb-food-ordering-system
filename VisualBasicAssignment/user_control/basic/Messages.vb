Public Class Messages
    Private parent As Master

    Public Sub New(parent As Master)
        Me.parent = parent
    End Sub

    Private Sub Messages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblContent.Width = (Me.parent.panelMessage.Width - 65)
    End Sub
End Class
