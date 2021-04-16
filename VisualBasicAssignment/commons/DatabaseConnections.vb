Public Class DatabaseConnections

    Private Shared Property loginUser As User
    Public Shared ReadOnly Property db As FoodShopEntities1 = New FoodShopEntities1()

    Public Shared Sub SetLoginUser(u As User)
        loginUser = u
    End Sub
    Public Shared Function GetLoginUser() As User
        Return db.Users.FirstOrDefault
    End Function

End Class
