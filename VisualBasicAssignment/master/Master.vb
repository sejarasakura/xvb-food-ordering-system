Imports System.ComponentModel
Public Class Master
    Dim statusMax As Boolean = True
    Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Master))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnProfile.MouseClick, btnMenu.MouseClick, btnOrder.MouseClick, btnCart.MouseClick
        btnProfile.FillColor = Color.White
        btnProfile.ForeColor = Color.Black
    End Sub

    Private Sub btnNav_Click(sender As Object, e As EventArgs) Handles btnNav.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If statusMax = True Then
            btnProfile.Text = ""
            btnMenu.Text = ""
            btnCart.Text = ""
            btnOrder.Text = ""
            Panel1.Width -= 10
            If Panel1.Size = Panel1.MinimumSize Then
                statusMax = False
                Timer1.Stop()
            End If
        Else
            btnProfile.Text = "PROFILE"
            btnMenu.Text = "MENU"
            btnCart.Text = "CART"
            btnOrder.Text = "ORDER"
            Panel1.Width += 10
            If Panel1.Size = Panel1.MaximumSize Then
                statusMax = True
                Timer1.Stop()
            End If
        End If

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles panelMessage.Paint

    End Sub




    'Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid)
    'End Sub

End Class
