Public Class ExFunctions

    Public Shared Function byteToImage(b As Byte()) As Image
        Try
            Dim ms As New IO.MemoryStream(CType(b, Byte())) 'This is correct...
            Dim returnImage As Image = Image.FromStream(ms)
            Return returnImage
        Catch ex As Exception
            Console.WriteLine("Exception caught: {0}", ex)
            Return Nothing
        End Try
    End Function
End Class
