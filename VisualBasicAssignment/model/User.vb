'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class User
    Public Property user_id As Integer
    Public Property user_email As String
    Public Property username As String
    Public Property last_name As String
    Public Property first_name As String
    Public Property user_role As String
    Public Property phone_num As String
    Public Property gender As String
    Public Property picture As Byte()
    Public Property password As String

    Public Overridable Property Carts As ICollection(Of Cart) = New HashSet(Of Cart)
    Public Overridable Property Customer As Customer
    Public Overridable Property Foods As ICollection(Of Food) = New HashSet(Of Food)
    Public Overridable Property Orders As ICollection(Of Order) = New HashSet(Of Order)
    Public Overridable Property Payments As ICollection(Of Payment) = New HashSet(Of Payment)
    Public Overridable Property ResetPasswordTokens As ICollection(Of ResetPasswordToken) = New HashSet(Of ResetPasswordToken)
    Public Overridable Property Staff As Staff
    Public Overridable Property Addresses As ICollection(Of Address) = New HashSet(Of Address)

End Class