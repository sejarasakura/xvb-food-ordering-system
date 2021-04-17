Public Class PaymentConfirm

    Public master As Master
    Private Sub OrderItem1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pay As Payment = DatabaseConnections.GetCurrentPayment()
        Me.lblSubTotal.Text = String.Format("Sub Total: RM {0:0.00}", pay.net_pay)
        Me.lblTax.Text = String.Format("Tax Charge: RM {0:0.00}", pay.tax_change)
        Me.lblTotalAmount.Text = String.Format("Total Fees: RM {0:0.00}", pay.total_pay)
        Me.lblDelivaryFees.Text = "Delivery Fees: RM 0.0"
        Me.lblCustomerPaid.Text = String.Format("You Pay: RM {0:0.00}", pay.customer_paid)
        Me.lblNote.Text = "Payment Note: <br/>" + pay.notes
        Me.lblPaymentId.Text = "Payment ID: " + pay.id.ToString
        Me.lblDate.Text = "Payment date: " + pay.payment_date.ToString

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Me.dgvDetails.DataSource = (
                                      From d In db.PaymentDetails
                                      Where d.payment_id = pay.id
                                      Select New With {d.Food.title, d.quantity, d.Food.price}
                                      ).ToList()

            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

End Class
