Public Class NewOder

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim u As User = DatabaseConnections.GetLoginUser()
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Me.dgvOrder.DataSource = (
                                      From d In db.Foods
                                      Select New With {d.id, d.title, d.price}
                                      ).ToList()

            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellClick

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try

            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub
End Class
