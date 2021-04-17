'Author Lim Sai Keat
Imports System.Data.Entity.Migrations
Public Class ExFunctions

    Public Shared Function byteToImage(b As Byte()) As Image
        Try
            Dim ms As New IO.MemoryStream(CType(b, Byte())) 'This is correct...
            Dim returnImage As Image = Image.FromStream(ms)
            Return returnImage
        Catch ex As Exception
            Console.WriteLine("Exception caught: {0}", ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function CreateCart() As Cart
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim newCart As Cart = New Cart()
            newCart.customer_id = DatabaseConnections.GetLoginUser().user_id

            Try
                db.Carts.Add(newCart)
                db.SaveChanges()
                Return newCart
            Catch e As Exception
                Return Nothing
            End Try
        End Using
    End Function

    Public Shared Sub addToCart(ByVal productId As String, ByVal Optional quantity As Integer = 1)
        Dim cd As CartDetail = New CartDetail()

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim cart As Cart = Nothing
            Dim user As User = DatabaseConnections.GetLoginUser()

            Dim carts = db.Carts.Where(Function(s) s.customer_id = user.user_id)

            If carts.Count() <= 0 Then
                cart = CreateCart()
            Else
                cart = carts.FirstOrDefault()
            End If

            If cart IsNot Nothing Then
                'string userid = Session["UserId"].ToString(); //user id for the logged in user
                Dim lProductid = productId 'get product id from the selected product
                Dim pidininteger = Integer.Parse(lProductid)
                Dim product = db.Foods.Find(pidininteger)
                cd.food_id = pidininteger 'art id
                cd.quantity = quantity
                cd.add_datetime = DateTime.Now 'added item must be recorded on real time\
                cd.cart_id = cart.id
                Dim old_details = db.CartDetails.Find(cart.id, cd.food_id)

                If old_details IsNot Nothing Then
                    old_details.quantity = old_details.quantity + quantity
                    db.CartDetails.AddOrUpdate(old_details)

                    Try
                        db.SaveChanges()
                        MessageBox.Show(
                            "You have successful added " & db.Foods.Find(cd.food_id).title & " to your shopping cart!",
                            "Successfully added to cart!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                    Catch __unusedException1__ As Exception
                        MessageBox.Show(
                            "This art that you are trying to add is already existed in your shopping cart",
                            "Art already existed in your cart",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                    End Try
                Else
                    db.CartDetails.Add(cd)

                    Try
                        db.SaveChanges()
                        MessageBox.Show(
                            "You have successful added " & db.Foods.Find(cd.food_id).title & " to your shopping cart!",
                            "Successfully added to cart!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                    Catch __unusedException1__ As Exception
                        MessageBox.Show(
                            "This art that you are trying to add is already existed in your shopping cart",
                            "Art already existed in your cart",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End Using
    End Sub
End Class
