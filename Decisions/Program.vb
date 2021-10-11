Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Would you prefer what is behind door #1 or #2 or #3?")
        Dim userInput As String
        userInput = Console.ReadLine()

        If userInput = "1" Then
            Console.WriteLine("You have won a car!")
            Console.ReadLine()
        ElseIf userInput = "2" Then
            Console.WriteLine("You have won a boat!")
            Console.ReadLine()
        ElseIf userInput = "3" Then
            Console.WriteLine("You have won a cat!")
            Console.ReadLine()
        Else
            Console.WriteLine("Sorry, your input wasn't understood!")
            Console.ReadLine()
        End If
    End Sub
End Module
