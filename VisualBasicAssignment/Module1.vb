﻿Module Module1
    Public con As New System.Data.SqlClient.SqlConnection
    Public editid As String
    Public detailid As String

    Public Function openconnect() As Boolean
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodShop.mdf;Integrated Security=True"
        Try
            con.ConnectionString = connString
            con.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub closeconnect()
        con.Close()
    End Sub




End Module
