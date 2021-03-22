Public Class OrderGroup
    Protected OrderList As List(Of OrderItem) = New List(Of OrderItem)()

    Private Sub OrderGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OrderList.Add(New OrderItem())
        OrderList.Add(New OrderItem())
        OrderList.Add(New OrderItem())
        OrderList.Add(New OrderItem())

        For Each item As OrderItem In OrderList
            item.BackColor = System.Drawing.Color.White
            item.Name = "OrderItem1"
            item.Size = New System.Drawing.Size(716, 138)
            item.TabIndex = 0
        Next
    End Sub
End Class
