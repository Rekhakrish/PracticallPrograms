Public Class Games
    Public Sub WordPrediction()
        Dim Score As Integer = 0
        Dim Words As String = "MASTER"
        Console.WriteLine("Given Word: {0}", Words)
        Dim userword As New List(Of String)
        Dim input As String

        Console.WriteLine("Enter the word")
        input = Console.ReadLine()
        If userword.Contains(input) Then
            Console.WriteLine("You have entered this word:{0} ", input)
            ' Else userword.Append(Words)

            If IsValidWord(input) Then
                Console.WriteLine("Word is Correct")
                Score = Score + 1
            Else
                Console.WriteLine("Word is Incorrect")
            End If
        End If
        input = Console.ReadLine()
        Console.WriteLine("Your Final Score :{0}", Score)
    End Sub

    Public Function IsValidWord(words As String) As Boolean
        ' Dim valid As Boolean = True

    End Function

End Class
