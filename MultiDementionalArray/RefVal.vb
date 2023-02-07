Imports System.Security.Cryptography.X509Certificates

Public Class RefVal
    Public Sub AddOne1(ByVal n As Integer)
        n += 1
    End Sub
    Public Sub AddOne(ByRef n As Integer)
        n = n + 10
    End Sub

    Public Sub DisplayMethod()
        Dim Number As Integer = 12
        AddOne(Number)
        Console.WriteLine("Passed By Value : {0}", Number)
        AddOne1(Number)
        Console.WriteLine("Passed By Reference : {0}", Number)
        ' Byvalue(Number)

    End Sub

End Class
