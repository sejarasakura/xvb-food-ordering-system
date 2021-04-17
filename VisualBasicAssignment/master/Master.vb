Imports System.ComponentModel
Public Class Master
    Dim statusMax As Boolean = True
    Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Master))

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub


    'Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid,
    '                            Color.Black, 1, ButtonBorderStyle.Solid)
    'End Sub

End Class
