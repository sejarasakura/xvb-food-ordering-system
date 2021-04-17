Imports System.Text.RegularExpressions

Public Class ValidatePayment
    'Create Regex.
    Shared ReadOnly masterRegex As Regex = New Regex("^5[1-5][0-9]{14}|^(222[1-9]|22[3-9]\\d|2[3-6]\\d{2}|27[0-1]\\d|2720)[0-9]{12}$")
    Shared ReadOnly visaRegex As Regex = New Regex("^4\d{12}(?:\d{3})?$")
    Shared ReadOnly digitRegex As Regex = New Regex("^\d?$")
    Shared ReadOnly nameRegex As Regex = New Regex("^[ a-zA-Z]*?$")
    Shared ReadOnly ccvRegex As Regex = New Regex("^[0-9]{3}?$")
    Shared ReadOnly expRegex As Regex = New Regex("^[0-9]{2}[/]{1}[0-9]{2}?$")
    Shared ReadOnly phoneRegex As Regex = New Regex("^60[0-9]{9}?$")

    'Mastercard Checker
    Shared Function isMastercard(ByVal text As String) As Boolean
        If text Is Nothing Then
            Return False
        End If
        ' Step 2: call Match on Regex.
        Dim match As Match = masterRegex.Match(text)
        Return match.Success
    End Function

    'Visacard Checker
    Shared Function isVisacard(ByVal text As String) As Boolean
        If text Is Nothing Then
            Return False
        End If
        ' Step 2: call Match on Regex.
        Dim match As Match = visaRegex.Match(text)
        Return match.Success
    End Function

    Friend Shared Function isPhoneNumber(text As String) As Boolean
        If text Is Nothing Then
            Return False
        End If
        ' Step 2: call Match on Regex.
        Dim match As Match = phoneRegex.Match(text)
        Return match.Success
    End Function

    'Digit Checker
    Shared Function isDigit(ByVal text As String) As Boolean
        If text Is Nothing Then
            Return False
        End If
        ' Step 2: call Match on Regex.
        Dim match As Match = digitRegex.Match(text)
        Return match.Success
    End Function

    'Name Checker
    Shared Function isName(ByVal text As String) As Boolean
        If text Is Nothing Then
            Return False
        End If
        ' Step 2: call Match on Regex.
        Dim match As Match = nameRegex.Match(text)
        Return match.Success
    End Function

    'Exp Checker
    Shared Function isExp(ByVal text As String) As Boolean
        If text Is Nothing Then
            Return False
        End If
        ' Step 2: call Match on Regex.
        Dim match As Match = expRegex.Match(text)
        Return match.Success
    End Function

    'CCV Checker
    Shared Function isCCV(ByVal text As String) As Boolean
        If text Is Nothing Then
            Return False
        End If
        ' Step 2: call Match on Regex.
        Dim match As Match = ccvRegex.Match(text)
        Return match.Success
    End Function

    'Visacard Checker
    Shared Function isPaymentEnough(ByVal paymentId As Integer, ByVal payTotal As Double) As Boolean


        Using db As FoodShopEntities1 = New FoodShopEntities1()
            Try
                Dim p As Payment = db.Payments.Find(paymentId)
                'Dim pDetails As List(Of PaymentDetail) = p.PaymentDetails.ToList

                If p Is Nothing Then
                    Return False
                End If

                If p.total_pay > payTotal Then
                    Return False
                Else
                    Return True
                End If
                'For i = 0 To p.PaymentDetails.Count
                'pDetails.ElementAt(i).
                'Next

            Catch ex As Exception
                Console.WriteLine("Exception caught: {0}", ex)
            End Try
        End Using
    End Function

End Class
