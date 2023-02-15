Imports System.Security.Cryptography.X509Certificates

Public Class Games
    Public Sub WordPrediction()

        Dim Score As Integer = 0


        Dim list As New List(Of String) From {"armets", "maters", "matres", "ramets", "stream", "tamers", "armet", "aster", "mares", "marse", "marts", "maser", "mater",
 "mates", "meats", "ramet", "rates", "reams", "resat", "satem", "smart", "smear", "stare", "steam", "tamer", "tames", "tares", "teams", "tears", "terms", "trams",
 "ares", "arms", "arts", "ates", "ears", "east", "eats", "eras", "erst", "etas", "maes", "mare", "mars", "mart", "mast", "mate", "mats", "meat", "mesa", "meta", "rams", "rase", "rate", "rats", "ream", "rems", "rest", "rets", "same", "sate",
 "seam", "sear", "seat", "sera", "seta", "star", "stem", "tame", "tams", "tare", "tars", "team", "tear", "teas", "term", "tram", "tres", "tsar", "are", "arm", "ars", "art", "ate",
 "ear", "eat", "ems", "era", "ers", "eta", "mae", "mar", "mas", "mat", "met", "ram", "ras", "rat", "rem", "res", "ret", "sae", "sat", "sea", "ser", "set", "tae", "tam", "tar", "tas", "tea", "ae", "am", "ar", "as", "at", "em", "er",
 "es", "et", "ma", "me", "re", "ta"}

        Dim userword As New List(Of String)


        Dim i As Int32 = 1
        While i > 0
            Console.Write(" Enter your word here : ")
            Dim userInput As String = (Console.ReadLine()).ToLower()
            If userInput <> "quit" Then
                If (Not (userword.Contains(userInput))) Then
                    If (list.Contains(userInput)) Then
                        Console.WriteLine("your entered a correct word")
                        userword.Add(userInput)
                        Score = Score + 1
                    Else
                        Console.WriteLine("Your input is invalid")
                    End If

                Else
                    Console.WriteLine("You Have Already Found This Word")
                End If
            Else
                i = 0
            End If
        End While



        Console.WriteLine("Your Final score: {0}", Score)
    End Sub



End Class
