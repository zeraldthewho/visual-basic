Imports MySql.Data.MySqlClient

Public Class loginForm
    Private Sub signupBtn2_Click(sender As Object, e As EventArgs) Handles signupBtn2.Click
        Dim signupForm As New RegistrationForm()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub loginBtn_Click(Sender As Object, e As EventArgs) Handles loginBtn.Click
        connection = New MySqlConnection("server=localhost;username=root;password=;database=prsdb")
        Try
            connection.Open()
            cmd = connection.CreateCommand()
            cmd.CommandText = "SELECT * FROM users WHERE username = @username AND password_hash = @password_hash"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", userLogin.Text)
            cmd.Parameters.AddWithValue("@password_hash", passwordLogin.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("Login succesfull!")
            Else
                MessageBox.Show("Invalid username or password")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try

        Dim payroll As New payroll
        Me.Hide()
        payroll.Show()


    End Sub

End Class