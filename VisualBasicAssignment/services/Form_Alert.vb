Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports CustomAlertBoxDemo.Properties

Namespace CustomAlertBoxDemo
    Public Partial Class Form_Alert
        Inherits Form

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Alert))

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Enum enmAction
            wait
            start
            close
        End Enum

        Public Enum enmType
            Success
            Warning
            [Error]
            Info
        End Enum

        Private action As enmAction
        Private x, y As Integer

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Select Case action
                Case enmAction.wait
                    timer1.Interval = 5000
                    action = enmAction.close
                    Exit Select
                Case enmAction.start
                    timer1.Interval = 1
                    Opacity += 0.1R

                    If x < Location.X Then
                        Left -= 1
                    ElseIf Opacity = 1.0R Then
                        action = enmAction.wait
                    End If

                    Exit Select
                Case enmAction.close
                    timer1.Interval = 1
                    Opacity -= 0.1R
                    Left -= 3

                    If Opacity = 0.0R Then
                        Close()
                    End If

                    Exit Select
            End Select
        End Sub

        Private Sub pictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs)
            timer1.Interval = 1
            action = enmAction.close
        End Sub

        Public Sub showAlert(ByVal msg As String, ByVal type As enmType)
            Opacity = 0.0R
            StartPosition = FormStartPosition.Manual
            Dim fname As String

            For i = 1 To 10 - 1
                fname = "alert" & i.ToString()
                Dim frm = CType(Application.OpenForms(fname), Form_Alert)

                If frm Is Nothing Then
                    Name = fname
                    x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Width + 15
                    y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i
                    Location = New Point(x, y)
                    Exit For
                End If
            Next

            x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Width - 5

            Select Case type
                Case enmType.Success
                    pictureBox1.Image = CType(resources.GetObject("success"), System.Drawing.Image)
                    BackColor = Color.SeaGreen
                    Exit Select
                Case enmType.Error
                    pictureBox1.Image = CType(resources.GetObject("error"), System.Drawing.Image)
                    BackColor = Color.DarkRed
                    Exit Select
                Case enmType.Info
                    pictureBox1.Image = CType(resources.GetObject("info"), System.Drawing.Image)
                    BackColor = Color.RoyalBlue
                    Exit Select
                Case enmType.Warning
                    pictureBox1.Image = CType(resources.GetObject("warning"), System.Drawing.Image)
                    BackColor = Color.DarkOrange
                    Exit Select
            End Select

            lblMsg.Text = msg
            Show()
            action = enmAction.start
            timer1.Interval = 1
            timer1.Start()
        End Sub
    End Class
End Namespace
