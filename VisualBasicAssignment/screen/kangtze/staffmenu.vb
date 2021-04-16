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
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim cmdstr As String = "select * from Food"
        Dim arrImage() As Byte
        Dim i As Int16 = 0

        If openconnect() = True Then
            cmd = New SqlCommand(cmdstr, con)
            dr = cmd.ExecuteReader()


            While dr.Read

                arrImage = dr.Item("image")
                pic = New PictureBox
                pic.Width = 130
                pic.Height = 150
                pic.BackgroundImageLayout = ImageLayout.Stretch

                If arrImage IsNot Nothing Then
                    pic.BackgroundImage = ExFunctions.byteToImage(CType(arrImage, Byte()))
                End If
                Dim btnEdit As New Button
                btnEdit.Name = dr.Item("id")

                namelabel = New Label
                namelabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                namelabel.Text = "Name : " + dr.Item("title")
                namelabel.Dock = DockStyle.Top

                desclabel = New Label
                desclabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                desclabel.Text = dr.Item("descriptions")
                desclabel.Dock = DockStyle.Fill

                pricelabel = New Label
                pricelabel.Font = New Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                pricelabel.Text = "Price : RM" + dr.Item("price").ToString
                pricelabel.Dock = DockStyle.Top


                btnEdit.Text = "Edit"
                AddHandler btnEdit.Click, AddressOf Me.Button_Click
                btnEdit.Dock = DockStyle.Top

                pnl = New Panel

                pnl.Controls.Add(desclabel)
                pnl.Controls.Add(pricelabel)
                pnl.Controls.Add(namelabel)
                pnl.Controls.Add(btnEdit)

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
        editid = btn.Name
        edit.ShowDialog()
        Me.Dispose()
        Me.Show()

    End Sub

End Class