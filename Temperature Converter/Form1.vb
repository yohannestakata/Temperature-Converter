Public Class Form1
    Dim mode As Char = "c"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mode = "c" Then
            mode = "f"
            Label1.Text = "Fahrenheit"
            Label2.Text = "Celsius"
        Else
            mode = "c"
            Label1.Text = "Celsius"
            Label2.Text = "Fahrenheit"
        End If

        Dim temp As String

        temp = TextBox1.Text
        TextBox1.Text = TextBox2.Text
        TextBox2.Text = temp
    End Sub

    Function ToCelsius(input As Double) As Double
        Return (input - 32) * 5 / 9
    End Function

    Function ToFahrenheit(input As Double) As Double
        Return (9 / 5) * input + 32
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If mode = "f" Then
            TextBox2.Text = ToCelsius(Double.Parse(TextBox1.Text))
        Else
            TextBox2.Text = ToFahrenheit(Double.Parse(TextBox1.Text))
        End If
    End Sub
End Class
