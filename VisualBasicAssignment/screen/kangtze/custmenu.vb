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
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim cmdstr As String = "select * from Food"
        Dim arrImage() As Byte
        Dim i As Int16 = 0

        If openconnect() = True Then
            cmd = New SqlCommand(cmdstr, con)
            dr = cmd.ExecuteReader()


            While dr.Read

                arrImage = dr.Item("food_image")
                Dim ms As New MemoryStream(arrImage)
                'PictureBox1.Image = Image.FromStream(ms)
                Dim bitmap As New Bitmap(Image.FromStream(ms))

                pic = New PictureBox
                pic.BackgroundImage = bitmap
                pic.Width = 130
                pic.Height = 150
                pic.BackgroundImageLayout = ImageLayout.Stretch

                namelabel = New Label
                namelabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                namelabel.Text = "Name : " + dr.Item("food_name")
                namelabel.Dock = DockStyle.Top

                pricelabel = New Label
                pricelabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                pricelabel.Text = "Price : RM" + dr.Item("food_price").ToString
                pricelabel.Dock = DockStyle.Top


                Dim btnView As New Button
                btnView.Name = dr.Item("food_id")

                btnView.Text = "View"
                AddHandler btnView.Click, AddressOf Me.Button_Click
                btnView.Dock = DockStyle.Top

                pnl = New Panel
                pnl.Controls.Add(pricelabel)
                pnl.Controls.Add(namelabel)
                pnl.Controls.Add(btnView)

                pnlPicture.Controls.Add(pic)
                pnlPicture.Controls.Add(pnl)


            End While

            closeconnect()
        End If
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button)
        MessageBox.Show(btn.Name + "clicked")
        detailid = btn.Name
        detail.Show()

    End Sub
End Class