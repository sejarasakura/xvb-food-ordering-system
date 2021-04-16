Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.Drawing.Imaging
Imports System.IO

Public Class addfood

    Dim cmd As SqlCommand
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ofdImage.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
        If ofdImage.ShowDialog() = DialogResult.OK Then
            pcbProduct.Image = New Bitmap(ofdImage.FileName)
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim cmd = New SqlCommand("insert into Food (food_id, food_name, food_image, food_desc, food_price, food_category, staff_id) values(@fid,@name,@image,@desc,@price,@category,@sid)", con)
        Dim ms As New MemoryStream
        Dim foodid As String = "f002"
        Dim staffid As String = "s001"
        pcbProduct.Image.Save(ms, pcbProduct.Image.RawFormat)

        cmd.Parameters.AddWithValue("@fid", foodid)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@desc", txtDesc.Text)
        cmd.Parameters.AddWithValue("@price", txtPrice.Text)
        cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
        cmd.Parameters.AddWithValue("@image", ms.ToArray)
        cmd.Parameters.AddWithValue("@sid", staffid)


        openconnect()
        cmd.ExecuteNonQuery()
        closeconnect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDesc.Clear()
        txtName.Clear()
        txtPrice.Clear()
    End Sub
End Class