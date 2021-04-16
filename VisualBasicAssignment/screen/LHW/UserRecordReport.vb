Imports System.Text
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class UserRecordReport
    Dim db As New FoodShopDataContext()
    Public username As String
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        username = ""
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click, Guna2Button1.Click
        Dim rs = From o In db.Users
                 Where o.username.Contains(mskUsername.Text)
                 Select New With
                 {
                 o.user_id,
                 o.username,
                 o.user_email,
                 o.user_role,
                 o.first_name,
                 o.last_name,
                 o.phone_num,
                 o.gender,
                 o.password
                 }
        dgv.DataSource = rs
        updateItem()
    End Sub
    Private Sub updateItem()
        lblItem.Text = dgv.Rows.Count.ToString("0 item(s)")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        mskUsername.Clear()
        dgv.Rows.Clear()
        mskUsername.Focus()
        updateItem()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Dim rs = From o In db.Users
                 Select New With
                     {
                     o.user_id,
                     o.username,
                     o.user_email,
                     o.user_role,
                     o.first_name,
                     o.last_name,
                     o.phone_num,
                     o.gender,
                     o.password
                     }
        dgv.DataSource = rs

        updateItem()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddUser.ShowDialog(Me)
    End Sub
    Private Sub dgv_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.RowHeaderMouseDoubleClick
        Dim i As Integer = e.RowIndex
        Dim fid As String = CStr(dgv.Rows(i).Cells(0).Value)
        ModifyUser.fid = fid
        ModifyUser.Show()
    End Sub
End Class