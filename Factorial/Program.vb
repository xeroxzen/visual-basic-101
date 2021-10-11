Imports System

Module Program
    Sub Main(args As String())
        Dim i, num As Integer, fact As Integer = 1
        Console.WriteLine("Enter any number: ")
        num = Integer.Parse(Console.ReadLine())

        For i = 1 To num
            fact = fact * i
        Next

        Console.WriteLine("Factorial of " & num & " is: " & fact)
        'Console.ReadLine()

        Console.WriteLine("Press any to exit")
    End Sub
End Module
