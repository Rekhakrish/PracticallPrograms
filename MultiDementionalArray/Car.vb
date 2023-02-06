Public Class Car

    'Member Variables
    Public engine As String
    Public noOfWheels As Integer


    'Member Functions
    Public Sub AcceptDetails()

        Console.WriteLine("Enter the Engine MOdel")
        engine = Console.ReadLine()
        Console.WriteLine("Enter the Number of wheels")
        noOfWheels = Console.ReadLine()
    End Sub
    Public Sub DisplayDetails()
        Console.WriteLine("The Engine model: {0}", engine)
        Console.WriteLine("The number of Wheels are: {0}", noOfWheels)


    End Sub

End Class
