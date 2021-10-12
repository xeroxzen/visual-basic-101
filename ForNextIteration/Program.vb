Imports System

Module Program
    Sub Main(args As String())
        For index = 1 To 10
            If index = 7 Then
                Console.WriteLine("Found 7")
                Exit For
            End If
            Console.WriteLine(index)
        Next

        Console.ReadLine()
    End Sub
End Module
