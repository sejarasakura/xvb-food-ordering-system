Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.Drawing.Imaging
Imports System.Drawing.Bitmap
Imports System.IO

Public Class detail
    Dim ds As DataSet = New DataSet()
    Dim da As SqlDataAdapter

    Private Sub detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Dim f As Food = db.Foods.Find(CType(detailid, Int32))

                If f Is Nothing Then
                Else
                    lblName.Text = f.title
                    lblDesc.Text = f.descriptions
                    lblPrice.Text = String.Format("RM {0:0.00}", f.price)

                    pcbProduct.Image = ExFunctions.byteToImage(f.image)
                End If
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class