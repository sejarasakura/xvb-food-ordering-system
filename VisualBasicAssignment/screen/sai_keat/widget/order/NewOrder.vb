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

        Dim foodName As String = dgvOrder.SelectedRows.Item(0).Cells.Item(1).Value
        lblTitle.Text = foodName

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, txbSearch.TextChanged
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Me.dgvOrder.DataSource = (
                    From d In db.Foods
                    Where d.title.Contains(txbSearch.Text)
                    Select New With {d.id, d.title, d.price}
                    ).ToList()
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
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
                dgvOrder.Rows.Add(dgvr.Cells.Item(0).Value, dgvr.Cells.Item(1).Value, dgvr.Cells.Item(2).Value, Me.nudQuantity.Value)
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub
End Class
