Imports System

Module PracticalExcercise
    Sub Main(args As String())
        Dim machine As Car = New Car()
        machine.AcceptDetails()
        machine.DisplayDetails()


        Dim Emp As Employee = New Employee()
        Emp.EmployeeDetails()


        Dim arr As Array = New Array()
        arr.EmpName()
        arr.DisplayEmpName()
        'MultidimenstionalArray()

        Dim oper As Operators = New Operators()
        oper.ArthemeticOperations()
        oper.AllOperations()




    End Sub
    Public Sub MultidimenstionalArray()
        Dim sum As Integer
        Dim rowsum As Integer
        Dim mArray As Integer(,) = New Integer(1, 3) {{2, 2, 2, 2}, {3, 3, 3, 3}}
        For row As Integer = 0 To 1
            rowsum = 0
            For Col As Integer = 0 To 3
                Console.Write("{0}" + vbTab, mArray(row, Col))
                rowsum = rowsum + mArray(row, Col)
            Next
            sum = sum + rowsum
            Console.Write("={0}", rowsum)
            Console.WriteLine(" ")
        Next
        Console.WriteLine("The sum of the Array is: {0}", sum)
    End Sub



End Module
