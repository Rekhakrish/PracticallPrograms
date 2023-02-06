Public Class Operators
    Dim a As Int32
    Dim b As Int32
    Dim c As Int32
    Public Sub ArthemeticOperations()
        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())
        c = a + b
        Console.WriteLine("After add the result is: {0}", c)
        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())
        c = a - b
        Console.WriteLine("After sub the result is: {0}", c)
        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())
        c = a * b
        Console.WriteLine("After multiply the result is: {0}", c)
        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())
        c = a / b
        Console.WriteLine("After Divide the result is: {0}", c)
        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())
        c = a Mod b
        Console.WriteLine("After Mod the result is: {0}", c)
    End Sub
    Public Sub AllOperations()
        Dim Number1 As Integer
        Dim Number2 As Integer
        Dim Result As Integer
        'Dim Unary As Integer

        Console.WriteLine("Enter the Number1: ")
        Number1 = Console.ReadLine()
        Console.WriteLine("Enter the Number2: ")
        Number2 = Console.ReadLine()

        'Arithmetic Opearator
        Result = Number1 + Number2
        Console.WriteLine("Result : " & Result)

        If Result = 10 Then
            Console.WriteLine("Get the Numberb")
        ElseIf (Result > 10) Then
            Console.WriteLine("Greater than Number")
        Else
            Console.WriteLine("Below the Number")
        End If
    End Sub
End Class
