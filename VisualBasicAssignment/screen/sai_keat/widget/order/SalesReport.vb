Public Class SalesReport

    '   Select Case productName, productDetail, productcate, productpri, productquan, SUM(Quantity) As SUM_OF_PRO_QUANTITY, ProductId FROM VIEW_PAYMENT GROUP BY ProductId, productName, productDetail, productcate, productquan, productstatus, productpri ORDER BY SUM_OF_PRO_QUANTITY DESC;

    '   Dim aggregate = From wod In db.WorkOrderDetails
    '                Group wod By Key = New With { Key wod.PriceCodeID, Key Description }
    '                Into Group
    '    Select Case agg = Key.PriceCodeID,
    '                             Key.Description,
    '                             Quantity = Group.Sum(Function(wod) wod.Quantity),
    '                             Subtotal = Group.Sum(Function(wod) wod.Subtotal),
    '                             Total = Group.Sum(Function(wod) wod.Total)




    Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatesRecords(Date.Now)
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        dgvReport.Rows.Clear()
    End Sub

    Private Sub UpdatesRecords(xDate As Date)
        Dim u As User = DatabaseConnections.GetLoginUser()
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Me.dgvReport.DataSource = (
                    From d In db.PaymentDetailsReportViews
                    Where d.payment_date.Value.Year = xDate.Year And d.payment_date.Value.Month = xDate.Month
                    Group By g = New With {d.food_id, d.title, d.price, d.descriptions} Into Group
                    Select
                        g.food_id,
                        g.title,
                        g.descriptions,
                        g.price,
                        quantity = Group.Sum(Function(d) d.quantity),
                        total = Group.Sum(Function(d) d.quantity) * g.price
                    ).ToList()

            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged
        Dim _date As Date = Guna2DateTimePicker1.Value
        UpdatesRecords(_date)
    End Sub
End Class
