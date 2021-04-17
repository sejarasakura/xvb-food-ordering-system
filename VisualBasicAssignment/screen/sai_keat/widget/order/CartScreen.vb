Public Class CartScreen
    Dim details As List(Of CartDetail)
    Private Sub CartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.pnlPicture.AutoScroll = True
        ReLoad()
    End Sub

    Private Sub ReLoad()
        pnlPicture.Controls.Clear()
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim id As Int32 = DatabaseConnections.GetLoginUser().user_id
            Dim cart_record As Cart = db.Carts.Where(Function(s) s.customer_id = id).FirstOrDefault()

            If cart_record Is Nothing Then
                details = ExFunctions.CreateCart().CartDetails.ToList()
            Else
                details = cart_record.CartDetails.ToList()
            End If
            Try
                For i = 0 To details.Count
                    Dim items As OrderItem = New OrderItem(details.Item(i))
                    items.Visible = True
                    Console.WriteLine("Order Id: {0}", details.Item(i).food_id)
                    pnlPicture.Controls.Add(items)
                Next
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim pd As PaymentDetail

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim ctrl As OrderItem
            Dim total As Double
            Dim newPaynment As Payment = New Payment()
            newPaynment.PaymentStatu = db.PaymentStatus.Find(Guid.Parse("20bd9f32-b531-4b7f-a89a-80babe9aa707"))
            newPaynment.user_id = DatabaseConnections.GetLoginUser().user_id
            newPaynment.payment_date = DateTime.Now
            newPaynment.id = Guid.NewGuid()
            newPaynment.notes = ""
            newPaynment.payment_method = Guid.Parse("9244ee14-b4b5-4f2c-833b-3b3c18d68764")
            newPaynment.payment_meta = ""

            For i = 0 To details.Count() - 1
                ctrl = CType(pnlPicture.Controls.Item(i), OrderItem)
                If (ctrl.ckb.Checked) Then
                    total += Convert.ToDouble(details.Item(i).Food.price * details.Item(i).quantity)
                    pd = New PaymentDetail()
                    pd.add_date = Date.Now
                    pd.quantity = details.Item(i).quantity
                    pd.food_id = details.Item(i).food_id
                    pd.payment_id = newPaynment.id
                    db.CartDetails.Remove(db.CartDetails.Find(details.Item(i).cart_id, details.Item(i).food_id))
                    newPaynment.PaymentDetails.Add(pd)
                End If
            Next

            newPaynment.net_pay = total
            newPaynment.tax_change = total * 0.06
            newPaynment.total_pay = total * 1.06
            db.Payments.Add(newPaynment)

            Try
                db.SaveChanges()
                DatabaseConnections.SetCurrentPayment(newPaynment)
                PaymentStep1.Show()
                ReLoad()
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub
End Class
