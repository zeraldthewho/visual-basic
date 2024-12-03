Public Class home


    Private Sub signupBtn2_Click(sender As Object, e As EventArgs) Handles signupBtn2.Click

        Dim signupForm As New RegistrationForm()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim signinForm As New loginForm()
        signinForm.Show()
        Me.Hide()
    End Sub
End Class