Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.Drawing.Imaging
Imports System.Drawing.Bitmap
Imports System.IO


Public Class custmenu
    Private WithEvents pnl As Panel
    Private WithEvents pic As PictureBox
    Private WithEvents namelabel As Label
    Private WithEvents pricelabel As Label
    'Private WithEvents btnEdit As Button

    Private Sub custmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.pnlPicture.AutoScroll = True
        ReLoad()
    End Sub

    Private Sub ReLoad()
        pnlPicture.Controls.Clear()
        Dim arrImage() As Byte
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim foods As List(Of Food) = (From d In db.Foods Order By d.id Descending).ToList()
            Try
                For i = 0 To foods.Count

                    arrImage = foods.Item(i).image
                    pic = New PictureBox
                    pic.Width = 130
                    pic.Height = 150
                    pic.BackgroundImageLayout = ImageLayout.Stretch

                    If arrImage IsNot Nothing Then
                        pic.BackgroundImage = ExFunctions.byteToImage(CType(arrImage, Byte()))
                    End If

                    namelabel = New Label
                    namelabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    namelabel.Text = "Name : " + foods.Item(i).title
                    namelabel.Dock = DockStyle.Top

                    pricelabel = New Label
                    pricelabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    pricelabel.Text = "Price : RM" + foods.Item(i).price.ToString
                    pricelabel.Dock = DockStyle.Top


                    Dim btnView As New Button
                    btnView.Name = foods.Item(i).id

                    btnView.Text = "View"
                    AddHandler btnView.Click, AddressOf Me.Button_Click
                    btnView.Dock = DockStyle.Top

                    Dim btnAddCart As New Button
                    btnAddCart.Name = foods.Item(i).id

                    btnAddCart.Text = "Add To Cart"
                    AddHandler btnAddCart.Click, AddressOf Me.AddToCart
                    btnAddCart.Dock = DockStyle.Top

                    pnl = New Panel
                    pnl.Controls.Add(pricelabel)
                    pnl.Controls.Add(namelabel)
                    pnl.Controls.Add(btnView)
                    pnl.Controls.Add(btnAddCart)

                    pnlPicture.Controls.Add(pic)
                    pnlPicture.Controls.Add(pnl)

                Next
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using

    End Sub

    Private Sub AddToCart(sender As Object, e As EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button)
        ExFunctions.addToCart(btn.Name)
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button)
        MessageBox.Show(btn.Name + "clicked")
        detailid = btn.Name
        detail.Show()

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        ReLoad()
    End Sub
End Class