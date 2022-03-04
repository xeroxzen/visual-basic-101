Imports System

Module Program
    <Obsolete>
    Sub Main(args As String())
        Dim hoursWorked As Integer
        Dim payPerhour As Double
        Dim workDays As Integer = 28

        'Prompt the user for the number of hours they work per day
        Console.WriteLine("How many hours do you work per day? ")
        hoursWorked = Console.ReadLine()

        'Prompt the user for the amount they earn per hour
        Console.WriteLine("What is your hourly wage? ")
        payPerhour = Console.ReadLine()

        'Calculate the monthly wage
        Dim monthlySalary As Integer
        monthlySalary = (hoursWorked * payPerhour) * workDays

        'Output monthly wage
        Console.WriteLine("Your monthly salary is $" & monthlySalary)

        Console.WriteLine(vbNewLine & "Press any key to closer the terminal")
        Console.ReadKey()
    End Sub
End Module
