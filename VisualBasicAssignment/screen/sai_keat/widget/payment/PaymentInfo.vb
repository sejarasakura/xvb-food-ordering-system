
Imports System.Data.Entity.Migrations
Public Class PaymentInfo

    Public master As Master
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        lblTitle.Left = (Me.Width / 2) - (lblTitle.Width / 2)
        Dim u As User = DatabaseConnections.GetLoginUser()
        Dim p As Payment = DatabaseConnections.GetCurrentPayment()
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Me.dgvPaymnet.DataSource = (
                                      From d In db.PaymentDetails
                                      Where d.payment_id = p.id
                                      Select New With {d.Food.title, d.Food.price, d.quantity}
                                      ).ToList()
            Catch ex As Exception
                Console.WriteLine("Exception payment info caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub PaymentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        err.Tag = Nothing

        If Not ValidatePayment.isName(Me.txbName.Text) Then
            err.SetError(txbName, "Please type your name!")
            err.Tag = If(err.Tag, txbName)
        End If
        If Not ValidatePayment.isPhoneNumber(Me.txbPhoneNumber.Text) Then
            Console.WriteLine("Validate {0}", Me.txbPhoneNumber.Text)
            err.SetError(txbPhoneNumber, "Please type phone number!")
            err.Tag = If(err.Tag, txbPhoneNumber)
        End If

        If err.Tag Is Nothing Then
            Using db As FoodShopEntities1 = New FoodShopEntities1()
                Try
                    Dim pay As Payment = DatabaseConnections.GetCurrentPayment()
                    pay.notes = Me.txbCompanyName.Text + ", " + Me.txbNote.Text + "(" + Me.txbAddressDetails.Text + Me.txbAddressDetails2.Text + ") TO [" + Me.txbName.Text + ", " + Me.txbPhoneNumber.Text + "]"

                    db.Payments.AddOrUpdate(pay)
                    db.SaveChanges()

                    master.Hide()
                    PaymentStep2.Show()
                Catch ex As Exception
                    Console.WriteLine("Exception caught: {0}", ex)
                End Try
            End Using
        End If

    End Sub
End Class
