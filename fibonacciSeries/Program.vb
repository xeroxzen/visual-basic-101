Imports System

Module Program
    Sub Main(args As String())
        Dim num1, num2 As Integer
        num1 = 0
        num2 = 1
        Console.WriteLine("{0}", num1)
        While num2 < 300
            Console.WriteLine(num2)

            num2 = num2 + num1
            num1 = num2 - num1
        End While
        Console.ReadLine()

    End Sub
End Module
