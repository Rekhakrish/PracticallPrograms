Imports System

Module PracticalExcercise
    Public Sub Main()
        'Dim cons As ConstructorDestructor = New ConstructorDestructor()
        'cons.Factorial()
        'Console.WriteLine("Enter the number:")
        'Dim userinput As Integer = Convert.ToInt32(Console.ReadLine)
        'Console.WriteLine("Factorail of {0} = {1}", userinput, Recursion.Factorial(userinput))
        'Console.ReadLine()

        ' Dim swap As Swapping2No = New Swapping2No()
        'Dim num1 As Integer
        'Dim num2 As Integer
        'Console.WriteLine("Enter the number1")
        'num1 = Convert.ToInt32(Console.ReadLine)
        'onsole.WriteLine("Enter the @nd number")
        'num2 = Convert.ToInt32(Console.ReadLine)
        ' swap.Swapping()
        'Dim fact As Recursion = New Recursion()
        'fact.Display()
        '    Dim Number As Integer = 6
        '    AddOne1(Number)
        'Dim refval As RefVal = New RefVal()
        'refval.DisplayMethod()



        Console.WriteLine("Welcome To Our Word Game")
        Console.WriteLine("******* GAME INSTRUCTIONS *******")
        Console.WriteLine("Create the word from the letters in Master")
        Console.WriteLine("**********************************")
        Console.WriteLine(" Enter Quit if you want to end the Game")
        Console.WriteLine("Your Score will be Displayed once you Quit the Game")
        Dim gam As Games = New Games()
        gam.WordPrediction()
        'Dim gam As Games = New Games()
        'gam.WordPrediction()
        '    Dim machine As Car = New Car()
        '    machine.AcceptDetails()
        '    machine.DisplayDetails()
        '    Dim Emp As Employee = New Employee()
        '    Emp.EmployeeDetails()


        '    Dim arr As Array = New Array()
        '    arr.EmpName()
        '    arr.DisplayEmpName()
        '    'MultidimenstionalArray()

        '    Dim oper As Operators = New Operators()
        '    oper.ArthemeticOperations()
        '    oper.AllOperations()




        'End Sub
        'Public Sub MultidimenstionalArray()
        '    Dim sum As Integer
        '    Dim rowsum As Integer
        '    Dim mArray As Integer(,) = New Integer(1, 3) {{2, 2, 2, 2}, {3, 3, 3, 3}}
        '    For row As Integer = 0 To 1
        '        rowsum = 0
        '        For Col As Integer = 0 To 3
        '            Console.Write("{0}" + vbTab, mArray(row, Col))
        '            rowsum = rowsum + mArray(row, Col)
        '        Next
        '        sum = sum + rowsum
        '        Console.Write("={0}", rowsum)
        '        Console.WriteLine(" ")
        '    Next
        '    Console.WriteLine("The sum of the Array is: {0}", sum)
    End Sub



End Module
