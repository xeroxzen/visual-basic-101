Imports System

Module Program
    Dim Animals(6) As String
    Dim Found As Boolean = False
    Dim SearchFailed As Boolean = False
    Dim Middle As Integer
    Dim First As Integer
    Dim Last As Integer
    Dim SearchItem As String

    Sub Main(args As String())
        Animals(1) = "Ostrich"
        Animals(2) = "Monkey"
        Animals(3) = "Ant"
        Animals(4) = "Elephant"
        Animals(5) = "Bear"
        Animals(6) = "Tiger"

        Array.Sort(Animals)
        For i = 1 To 6
            Console.WriteLine("Slot " & i & " is: " & Animals(i))
        Next

        Console.WriteLine("What animal are you searching for?")
        SearchItem = Console.ReadLine()

        First = 1
        Last = 6

        Do While Found = False And SearchFailed = False
            Middle = (First + Last) / 2

            If Animals(Middle) = SearchItem Then
                Found = True
            ElseIf First >= Last Then
                SearchFailed = True
            ElseIf Animals(Middle) > SearchItem Then
                Last = Middle - 1
            Else
                First = Middle + 1
            End If
        Loop

        If Found = True Then
            Console.WriteLine("Found in slot " & Middle)
        Else
            Console.WriteLine("Not present in the array.")
        End If
    End Sub
End Module
