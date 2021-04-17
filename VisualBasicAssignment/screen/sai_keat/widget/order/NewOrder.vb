Public Class NewOder

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim u As User = DatabaseConnections.GetLoginUser()
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Me.dgvOrder.DataSource = (
                    From d In db.Foods
                    Select New With {d.id, d.title, d.price}
                    ).ToList()
                Dim cat As List(Of PaymentStatu) = db.PaymentStatus.ToList()
                Me.cmbStatus.DataSource = cat
                Me.cmbStatus.ValueMember = "id"
                Me.cmbStatus.DisplayMember = "name"

                Dim met As List(Of PaymentMethod) = db.PaymentMethods.ToList()
                Me.cmbMethod.DataSource = met
                Me.cmbMethod.ValueMember = "id"
                Me.cmbMethod.DisplayMember = "name"

                Dim user As List(Of User) = db.Users.ToList()
                Me.cmbUser.DataSource = user
                Me.cmbUser.ValueMember = "user_id"
                Me.cmbUser.DisplayMember = "username"

            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellClick

        Dim foodName As String = dgvOrder.SelectedRows.Item(0).Cells.Item(1).Value
        lblTitle.Text = foodName

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvOrder.Rows.Clear()
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim foodId As Int32 = dgvOrder.SelectedRows.Item(0).Cells.Item(0).Value
        Dim dgvr As DataGridViewRow = dgvOrder.SelectedRows.Item(0)
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                dgvOrderDetails.Rows.Add(dgvr.Cells.Item(0).Value, dgvr.Cells.Item(1).Value, dgvr.Cells.Item(2).Value, Me.nudQuantity.Value)
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim pd As PaymentDetail
        If dgvOrderDetails.Rows.Count <= 0 Then
            Return
        End If
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim total As Double
            Dim newPaynment As Payment = New Payment()
            newPaynment.payment_status = cmbStatus.SelectedValue
            newPaynment.user_id = cmbUser.SelectedValue
            newPaynment.payment_date = DateTime.Now
            newPaynment.id = Guid.NewGuid()
            newPaynment.notes = ""
            newPaynment.payment_method = cmbMethod.SelectedValue
            newPaynment.payment_meta = ""

            For i = 0 To dgvOrderDetails.Rows.Count() - 1
                Dim foodid As Int32 = dgvOrderDetails.Rows.Item(i).Cells.Item(0).Value
                Dim quan As Int32 = dgvOrderDetails.Rows.Item(i).Cells.Item(3).Value
                Dim food As Food = db.Foods.Find(foodid)
                total += Convert.ToDouble(food.price * quan)
                pd = New PaymentDetail()
                pd.add_date = Date.Now
                pd.quantity = quan
                pd.food_id = foodid
                pd.payment_id = newPaynment.id
                newPaynment.PaymentDetails.Add(pd)
            Next

            newPaynment.net_pay = total
            newPaynment.tax_change = total * 0.06
            newPaynment.total_pay = total * 1.06
            db.Payments.Add(newPaynment)

            Try
                dgvOrderDetails.Rows.Clear()
                MessageBox.Show(
                    "The order is sucessfull added to the system",
                    "Payment order sucessful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
                db.SaveChanges()
            Catch ex As Exception
                MessageBox.Show(
                    "The order is no added",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub
End Class
