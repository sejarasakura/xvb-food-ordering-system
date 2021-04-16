Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.Drawing.Imaging
Imports System.Drawing.Bitmap
Imports System.IO
Public Class edit
    Dim ds As DataSet = New DataSet()
    Dim da As SqlDataAdapter


    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select * from food where food_id='" + editid + "'"
        'PictureBox1.Image = Image.FromStream(ms)
        Dim arrImage() As Byte

        If openconnect() = True Then
            ds.Clear()
            da = New SqlDataAdapter(cmdstr, con)
            da.Fill(ds, "Food")

            If ds.Tables("Food").Rows.Count = 1 Then
                arrImage = ds.Tables("Food").Rows(0).Item(2)
                Dim ms As New MemoryStream(arrImage)
                Dim bitmap As New Bitmap(Image.FromStream(ms))


                txtName.Text = ds.Tables("Food").Rows(0).Item(1)
                txtDesc.Text = ds.Tables("Food").Rows(0).Item(3)
                txtPrice.Text = ds.Tables("Food").Rows(0).Item(4)
                lblComboBox.Text = ds.Tables("Food").Rows(0).Item(5)
                pcbProduct.Image = bitmap
            End If
            closeconnect()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim cmdstr As String = "update [food] set [food_name]=@name, [food_price]=@price, [food_category]=@category  where food_id='" + editid + "'"
        Dim cmd As SqlCommand


        If openconnect() = True Then
            cmd = New SqlCommand(cmdstr, con)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@desc", txtDesc.Text)
            cmd.Parameters.AddWithValue("@price", Integer.Parse(txtPrice.Text))
            cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
            cmd.ExecuteNonQuery()
            closeconnect()
        End If
        Me.Close()
    End Sub
End Class