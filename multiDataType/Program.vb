Imports System

Module Program
    Sub Main(args As String())

        Dim firstName, lastName As String
        Dim firstNum, secondNum As Decimal

        Console.WriteLine("What is your name")
        firstName = Console.ReadLine()

        Console.WriteLine("What is your surname")
        lastName = Console.ReadLine()

        Console.WriteLine(firstName + " " & lastName)

        Console.WriteLine("May I have a number: ")
        firstNum = Console.ReadLine()

        Console.WriteLine("May I have the second number: ")
        secondNum = Console.ReadLine()

        Console.WriteLine("The product of the two numbers is: " & firstNum * secondNum)

    End Sub
End Module
