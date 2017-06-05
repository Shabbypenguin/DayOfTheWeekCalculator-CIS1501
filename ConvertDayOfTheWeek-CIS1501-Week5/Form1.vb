Public Class Form1
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Application.Exit()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        'This clears both boxes when you click the clear button
        userInputBox.Text = ""
        dayOfTheWeekBox.Text = ""
    End Sub

    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        'We check if user has entered a number and if not alert them
        If Not IsNumeric(userInputBox.Text) Then
            MessageBox.Show("Please enter in a number")
        Else
            'We then need to check if its between 1 to 7
            If (userInputBox.Text <= 7 AndAlso userInputBox.Text > 0) Then
                'This takes the number and provies the day of the week name based on system settings
                dayOfTheWeekBox.Text = WeekdayName(userInputBox.Text)
            Else
                'We throw this error message if the user input a number that wouldn't work
                MessageBox.Show("Please enter in a number lower than 8 but higher than 0")
            End If
        End If
        Exit Sub
    End Sub

    Private Sub userInputBox_Click(sender As Object, e As EventArgs) Handles userInputBox.Click
        'Clearing out the userinput box for them as they click onto it.
        If userInputBox.Text = "Enter a number" Then
            userInputBox.Clear()
        End If
    End Sub
End Class
