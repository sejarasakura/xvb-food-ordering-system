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

Partial Public Class Menu
    Public Property id As Integer
    Public Property start_date As Date
    Public Property end_date As Date
    Public Property title As String
    Public Property descriptions As String
    Public Property enabled As Nullable(Of Boolean)
    Public Property menu_image As Byte()

    Public Overridable Property Foods As ICollection(Of Food) = New HashSet(Of Food)

End Class
