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

Partial Public Class Cart
    Public Property id As Integer
    Public Property customer_id As Integer
    Public Property remark As String

    Public Overridable Property User As User
    Public Overridable Property CartDetails As ICollection(Of CartDetail) = New HashSet(Of CartDetail)

End Class