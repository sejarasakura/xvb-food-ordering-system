Public Class VRButton

    Public Overrides Property Text As String
        Get
            Return Button1.Text
        End Get
        Set(ByVal value As String)
            Button1.Text = value
        End Set
    End Property

    Public Property ButtonBackColor As Color
        Get
            Return Button1.BackColor
        End Get
        Set(ByVal value As Color)
            Button1.BackColor = value
        End Set
    End Property

End Class
