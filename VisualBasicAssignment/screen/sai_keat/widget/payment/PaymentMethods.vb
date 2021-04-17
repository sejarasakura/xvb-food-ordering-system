Imports Guna.UI2.WinForms
Imports System.Data.Entity.Migrations

Public Class PaymentMethods

    Public master As Master
    Private Sub radVisa_CheckedChanged(sender As Object, e As EventArgs) Handles radVisa.CheckedChanged
        Dim btn As Guna2RadioButton = CType(sender, Guna2RadioButton)
        If (btn.Checked) Then
            radMaster.Checked = False
            radVisa.Checked = True
        End If
    End Sub

    Private Sub radMaster_CheckedChanged(sender As Object, e As EventArgs) Handles radMaster.CheckedChanged
        Dim btn As Guna2RadioButton = CType(sender, Guna2RadioButton)
        If (btn.Checked) Then
            radMaster.Checked = True
            radVisa.Checked = False
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        err.Tag = Nothing

        If Not ValidatePayment.isName(Me.txbName.Text) Then
            err.SetError(txbName, "Please type your name!")
            err.Tag = If(err.Tag, txbName)
        End If
        If radMaster.Checked Then
            If Not ValidatePayment.isMastercard(Me.txbCardNumber.Text) Then
                err.SetError(txbCardNumber, "Not master card format *Card number 16 number withoud white space!")
                err.Tag = If(err.Tag, txbCardNumber)
            End If
        Else
            If Not ValidatePayment.isVisacard(Me.txbCardNumber.Text) Then
                err.SetError(txbCardNumber, "Mot visa card format, Card number 16 number withoud white space!")
                err.Tag = If(err.Tag, txbCardNumber)
            End If
        End If
        If Not ValidatePayment.isCCV(Me.txbCCV.Text) Then
            err.SetError(txbCCV, "Please type your CCV!")
            err.Tag = If(err.Tag, txbCCV)
        End If
        If Not ValidatePayment.isExp(Me.txbExp.Text) Then
            err.SetError(txbExp, "Please type your EXP!")
            err.Tag = If(err.Tag, txbExp)
        End If

        If err.Tag Is Nothing Then
            Using db As FoodShopEntities1 = New FoodShopEntities1()
                Try
                    Dim pay As Payment = DatabaseConnections.GetCurrentPayment()
                    pay.customer_paid = pay.total_pay
                    pay.payment_meta = txbName.Text + "," + txbCardNumber.Text + "," + txbCCV.Text + "," + txbExp.Text
                    ' Set the payment status to completed
                    pay.payment_status = Guid.Parse("c595596d-8980-4138-bc20-a91056e1b1ce")
                    db.Payments.AddOrUpdate(pay)
                    db.SaveChanges()
                    master.Hide()

                    PaymentStep3.Show()
                Catch ex As Exception
                    Console.WriteLine("Exception caught: {0}", ex)
                End Try
            End Using
        End If

    End Sub
End Class
