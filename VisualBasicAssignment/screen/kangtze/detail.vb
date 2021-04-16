Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.Drawing.Imaging
Imports System.Drawing.Bitmap
Imports System.IO

Public Class detail
    Dim ds As DataSet = New DataSet()
    Dim da As SqlDataAdapter

    Private Sub detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select * from food where food_id='" + detailid + "'"
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

                lblName.Text = ds.Tables("Food").Rows(0).Item(1)
                lblDesc.Text = ds.Tables("Food").Rows(0).Item(3)
                lblPrice.Text = "RM" + ds.Tables("Food").Rows(0).Item(4).ToString

                pcbProduct.Image = bitmap
            End If
            closeconnect()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class