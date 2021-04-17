Public Class Form2

    Dim statusMax As Boolean = True
    Private navindex As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        'btnClose.Image = My.Resources.icons8_close_window_96
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        'btnClose.Image = My.Resources.icons8_close_window_96__1_
    End Sub

    Private Sub btnMini_MouseHover(sender As Object, e As EventArgs) Handles btnMini.MouseHover
        'btnMini.Image = My.Resources.icons8_macos_minimize_90
    End Sub

    Private Sub btnMini_MouseLeave(sender As Object, e As EventArgs) Handles btnMini.MouseLeave
        'btnMini.Image = My.Resources.icons8_macos_minimize_96__1_
    End Sub

    Private Sub picIcon_MouseHover(sender As Object, e As EventArgs) Handles picIcon.MouseHover
        'picIcon.Image = My.Resources.icon2
    End Sub

    Private Sub picIcon_MouseLeave(sender As Object, e As EventArgs) Handles picIcon.MouseLeave
        'picIcon.Image = My.Resources.icon1
    End Sub


    Private Sub btnNav_Click(sender As Object, e As EventArgs) Handles btnNav.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If statusMax = True Then
            btnProfile.Text = ""
            btnMenu.Text = ""
            btnAddfood.Text = ""
            btnOrder.Text = ""
            Panel1.Width -= 10
            If Panel1.Size = Panel1.MinimumSize Then
                statusMax = False
                Timer1.Stop()
            End If
        Else
            btnProfile.Text = "PROFILE"
            btnMenu.Text = "MENU"
            btnAddfood.Text = "CART"
            btnOrder.Text = "ORDER"
            Panel1.Width += 10
            If Panel1.Size = Panel1.MaximumSize Then
                statusMax = True
                Timer1.Stop()
            End If
        End If

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        btnProfile.FillColor = Color.White
        btnProfile.ForeColor = Color.Black
        checkNav(1)
        switchPanel(Profile)
    End Sub

    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddfood.Click
        btnAddfood.FillColor = Color.White
        btnAddfood.ForeColor = Color.Black
        checkNav(2)
        switchPanel(addfood)
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        btnOrder.FillColor = Color.White
        btnOrder.ForeColor = Color.Black
        checkNav(3)
        switchPanel2(New StaffOrder())
    End Sub

    Sub switchPanel2(ByVal panel As Control)
        Panel4.Controls.Clear()
        panel.Show()
        panel.Visible = True
        Panel4.Controls.Add(panel)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        btnMenu.FillColor = Color.White
        btnMenu.ForeColor = Color.Black
        checkNav(4)
        switchPanel(custmenu)
    End Sub

    Private Sub checkNav(index As Integer)
        Select Case index
            Case 1
                btnAddfood.FillColor = Color.FromArgb(3, 139, 205)
                btnAddfood.ForeColor = Color.White
                btnOrder.FillColor = Color.FromArgb(3, 139, 205)
                btnOrder.ForeColor = Color.White
                btnMenu.FillColor = Color.FromArgb(3, 139, 205)
                btnMenu.ForeColor = Color.White

            Case 2
                btnProfile.FillColor = Color.FromArgb(3, 139, 205)
                btnProfile.ForeColor = Color.White
                btnOrder.FillColor = Color.FromArgb(3, 139, 205)
                btnOrder.ForeColor = Color.White
                btnMenu.FillColor = Color.FromArgb(3, 139, 205)
                btnMenu.ForeColor = Color.White
            Case 3
                btnProfile.FillColor = Color.FromArgb(3, 139, 205)
                btnProfile.ForeColor = Color.White
                btnAddfood.FillColor = Color.FromArgb(3, 139, 205)
                btnAddfood.ForeColor = Color.White
                btnMenu.FillColor = Color.FromArgb(3, 139, 205)
                btnMenu.ForeColor = Color.White
            Case 4
                btnProfile.FillColor = Color.FromArgb(3, 139, 205)
                btnProfile.ForeColor = Color.White
                btnAddfood.FillColor = Color.FromArgb(3, 139, 205)
                btnAddfood.ForeColor = Color.White
                btnOrder.FillColor = Color.FromArgb(3, 139, 205)
                btnOrder.ForeColor = Color.White
        End Select
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        Panel4.Controls.Add(panel)
        panel.Show()

    End Sub





    'Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid)
    'End Sub

End Class
