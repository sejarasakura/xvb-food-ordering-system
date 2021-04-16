Imports System.Data.SqlClient
Imports System.Drawing.Image
Imports System.Drawing.Imaging
Imports System.IO

Public Class addfood

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Dim cat As List(Of Catergory) = db.Catergories.ToList()
                Me.cmbCategory.DataSource = cat
                Me.cmbCategory.ValueMember = "id"
                Me.cmbCategory.DisplayMember = "name"
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        Try
            ofdImage.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            If ofdImage.ShowDialog() = DialogResult.OK Then
                pcbProduct.Image = New Bitmap(ofdImage.FileName)
            End If
        Catch ex As Exception
            Console.WriteLine("Exception caught: {0}", ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim ms As New MemoryStream
        pcbProduct.Image.Save(ms, pcbProduct.Image.RawFormat)

        Dim f As New Food()
        f.add_date = DateTime.Now()
        f.catergory_id = cmbCategory.SelectedValue
        f.descriptions = Me.txtDesc.Text
        f.duty_staff_id = DatabaseConnections.GetLoginUser().user_id
        f.title = Me.txtName.Text
        f.price = CType(Me.txtPrice.Text, Double)
        f.stock = 100
        f.image = ms.ToArray

        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                db.Foods.Add(f)
                db.SaveChanges()
                MessageBox.Show(
                    "Updates sucessful" + db.Foods.Count.ToString(),
                    "SUCCESS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDesc.Clear()
        txtName.Clear()
        txtPrice.Clear()
    End Sub
End Class