Public Class ConstructorDestructor
    Public Sub ConstructorDestructor()
        Console.WriteLine("Constructor is called")
    End Sub
    Protected Overrides Sub Finalize()
        Console.WriteLine("destructor is Called")
    End Sub
    'Public Function Factorial(givennumber As Integer) As Integer
    '    If givennumber <= 1 Then
    '        Return 1
    '    Else
    '        Return (givennumber * Factorial(givennumber - 1))
    '    End If
    'End Function
End Class
