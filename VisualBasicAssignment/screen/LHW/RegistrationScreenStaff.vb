Public Class RegistrationScreenStaff
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStaffName.Clear()
        txtEmail.Clear()
        txtPosition.Clear()
        radMale.Checked = False
        radFemale.Checked = False
        txtAddress.Clear()
        txtSalary.Clear()
        txtMobileNumber.Clear()
        radSingle.Checked = False
        radMarried.Checked = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lblPosition_Click(sender As Object, e As EventArgs) Handles lblRole.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub
End Class