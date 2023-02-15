Module Recursion
    Public Sub Display()
        Dim cons As ConstructorDestructor = New ConstructorDestructor()
    End Sub
    Public Function Factorial(givennumber As Integer) As Integer
        'Dim N As Integer
        'Dim I As Integer
        'Dim Fact As Integer = 1

        'Console.Write("Enter the value of N : ")
        'N = Console.ReadLine()

        'Console.WriteLine()
        'Console.WriteLine("N        Factorial")


        'For I = 1 To N

        '    Fact = Fact * I

        '    Console.WriteLine("{0,-6}      {1,7 }", I, Fact)

        'Next

        If givennumber <= 1 Then
            Return 1
        Else
            Return (givennumber * Factorial(givennumber - 1))
        End If
    End Function
End Module
