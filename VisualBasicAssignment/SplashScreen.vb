Public Class SplashScreen
    Public Sub InitializeComponentCustom()
        'Initializing action'
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ((Panel2.Width >= 100 And Panel2.Width <= 120) Or Panel2.Width > 600) Then
            Panel2.Width += Int((2 * Rnd()) + 1)
        ElseIf (Panel2.Width < 100) Then
            Panel2.Width += Int((3 * Rnd()) + 0)
        Else
            Panel2.Width += Int((6 * Rnd()) + 0)
        End If
        If (Panel2.Width >= 650) Then
            Timer1.Stop()
            Screen.NAV_LOGIN_SCREEN.Show()
            Me.Hide()
        End If
    End Sub
End Class
