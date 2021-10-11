Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Would you prefer what is behind door #1 or #2 or #3?")
        Dim userInput As String
        userInput = Console.ReadLine()

        'Let's have a message variable
        Dim message As String

        If userInput = "1" Then
            message = "You have won a car!"

        ElseIf userInput = "2" Then
            message = "You have won a boat!"

        ElseIf userInput = "3" Then
            message = "You have won a cat!"

        Else
            message = "Sorry, your input wasn't understood!"

        End If
        Console.WriteLine(message)
        Console.ReadLine()
    End Sub
End Module
