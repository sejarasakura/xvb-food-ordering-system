Imports System.Data.Entity.Migrations
Public Class OrderItem
    Dim data As CartDetail
    Public Sub New(data As CartDetail)
        Me.data = data
    End Sub
    Public Sub OrderItem_Load()
        InitializeComponent()
        Me.ckb.Checked = True
        Me.img.Image = ExFunctions.byteToImage(data.Food.image)
        Me.info.Text = "Stock Remain: " + data.Food.stock.ToString + "<br/><br/>Price:RM " + data.Food.price.ToString
        Me.title.Text = "<b style='font-size: 15px'>" + data.Food.title + "</b> <br />" + data.Food.descriptions
        Me.upDownNumbering.Value = CType(data.quantity, Decimal)
        Me.upDownNumbering.Minimum = If(data.Food.stock = 0, 0, 1)
        Me.upDownNumbering.Maximum = CType(data.Food.stock, Decimal)
    End Sub

    Private Sub upDownNumbering_ValueChanged(sender As Object, e As EventArgs) Handles upDownNumbering.ValueChanged

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                data.quantity = CType(upDownNumbering.Value, Int32)
                data.add_datetime = DateTime.Now
                db.CartDetails.AddOrUpdate(data)
                db.SaveChanges()
                Console.WriteLine("Updated to quntity: {0}", db.CartDetails.Find(data.cart_id, data.food_id).quantity)
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub OrderItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrderItem_Load()
    End Sub
End Class
