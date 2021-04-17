﻿Public Class MyOder

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim u As User = DatabaseConnections.GetLoginUser()
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Me.dgvOrder.DataSource = (
                                      From d In db.Payments
                                      Where d.user_id = u.user_id
                                      Order By d.payment_date Descending
                                      Select New With {d.id, d.total_pay, d.payment_status}
                                      ).ToList()

            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
            Try
                If dgvOrder.FirstDisplayedCell IsNot Nothing Then
                    Dim data As Guid = Guid.Parse(dgvOrder.FirstDisplayedCell.Value)
                    Me.dgvOrderDetails.DataSource = (From d In db.PaymentDetails
                                                     Where d.payment_id = data
                                                     Order By d.food_id Ascending
                                                     Select New With {d.food_id, d.Food.title, d.quantity, d.Food.price}).ToList()
                End If
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellClick

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim pid As Guid = dgvOrder.SelectedRows.Item(0).Cells.Item(0).Value
            Try
                Me.dgvOrderDetails.DataSource = (From d In db.PaymentDetails
                                                 Where d.payment_id = pid
                                                 Order By d.food_id Ascending
                                                 Select New With {d.food_id, d.Food.title, d.quantity, d.Food.price}).ToList()
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
End Class
