Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hoursWorked As Integer
        Dim hourlyWage As Double
        Dim salary As Double
        Dim daysWorked As Integer = 28

        hoursWorked = TextBox1.Text
        hourlyWage = TextBox2.Text
        If hourlyWage And hourlyWage <> vbInteger Or vbDouble Then
            salary = (hoursWorked * hourlyWage) * daysWorked
        Else
            MsgBox("Hourly wage or hours is not a valid number.")
        End If


        TextBox3.Text = "$" & salary

    End Sub
End Class
