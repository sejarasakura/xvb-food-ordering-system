Imports System
Imports System.Windows.Forms

Namespace CustomAlertBoxDemo
    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Alert(ByVal msg As String, ByVal type As Form_Alert.enmType)
            Dim frm = New Form_Alert()
            frm.showAlert(msg, type)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Alert("Success Alert", Form_Alert.enmType.Success)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Alert("Warning Alert", Form_Alert.enmType.Warning)
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Alert("Error Alert", Form_Alert.enmType.Error)
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Alert("Info Alert", Form_Alert.enmType.Info)
        End Sub
    End Class
End Namespace
