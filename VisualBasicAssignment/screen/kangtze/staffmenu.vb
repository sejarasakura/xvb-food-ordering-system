Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.Drawing.Imaging
Imports System.Drawing.Bitmap
Imports System.IO


Public Class staffmenu
    Private WithEvents pnl As Panel
    Private WithEvents pic As PictureBox
    Private WithEvents namelabel As Label
    Private WithEvents pricelabel As Label
    Private WithEvents desclabel As Label
    'Private WithEvents btnEdit As Button

    Private Sub custmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReLoad()
    End Sub

    Private Sub ReLoad()
        pnlPicture.Controls.Clear()
        Dim arrImage() As Byte
        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Dim foods As List(Of Food) = DatabaseConnections.db.Foods.ToList()
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


                    desclabel = New Label
                    desclabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    desclabel.Text = foods.Item(i).descriptions
                    desclabel.Dock = DockStyle.Fill

                    Dim btnEdit As New Button
                    btnEdit.Name = foods.Item(i).id

                    btnEdit.Text = "Edit"
                    AddHandler btnEdit.Click, AddressOf Me.Button_Click
                    btnEdit.Dock = DockStyle.Top

                    pnl = New Panel
                    pnl.Controls.Add(pricelabel)
                    pnl.Controls.Add(namelabel)
                    pnl.Controls.Add(desclabel)
                    pnl.Controls.Add(btnEdit)

                    pnlPicture.Controls.Add(pic)
                    pnlPicture.Controls.Add(pnl)

                Next
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using

    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button)
        MessageBox.Show(btn.Name + "clicked")
        editid = btn.Name
        edit.ShowDialog()
        Me.Show()

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        ReLoad()
    End Sub
End Class