Public Class Swapping2No
    Dim num1 As Integer
    Dim num2 As Integer
    Dim Temp As Integer
    Public Sub Swapping()
        Console.WriteLine("Enter The Two Number:")
        num1 = System.Console.ReadLine()
        num2 = System.Console.ReadLine()
        Console.WriteLine("The Two Number is:{0} And
{1}:", num1, num2)
        Temp = num1
        num1 = num2
        num2 = Temp
        Console.WriteLine("After Swapping Value is:{0} and
{1}:", num1, num2)
        System.Console.ReadLine()



    End Sub

End Class
