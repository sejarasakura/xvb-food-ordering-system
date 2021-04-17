Public Class DatabaseConnections

    Private Shared Property loginUser As User
    Private Shared Property currenctPaymentServices As Payment

    Public Shared ReadOnly Property db As FoodShopEntities1 = New FoodShopEntities1()

    Public Shared Sub SetLoginUser(u As User)
        loginUser = u
    End Sub
    Public Shared Function GetLoginUser() As User
        Return loginUser
    End Function
    Public Shared Sub SetCurrentPayment(u As Payment)
        currenctPaymentServices = u
    End Sub
    Public Shared Function GetCurrentPayment() As Payment
        Return currenctPaymentServices
    End Function

End Class
