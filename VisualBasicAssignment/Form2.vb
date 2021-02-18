Public Class Form2
    Dim statusMax As Boolean = False


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Size = Panel1.MinimumSize
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If statusMax = True Then

            Panel1.Height -= 10
            If Panel1.Size = Panel1.MinimumSize Then
                statusMax = False
                Timer1.Stop()
            End If
        Else
            Panel1.Height += 10
            If Panel1.Size = Panel1.MaximumSize Then
                statusMax = True
                Timer1.Stop()
            End If
        End If

    End Sub

End Class