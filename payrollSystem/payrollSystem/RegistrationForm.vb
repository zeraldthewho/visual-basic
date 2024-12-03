Public Class RegistrationForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        MsgBox("Database Successfully Established")
        connection.Close()
    End Sub

    Private Sub signupBtn_Click(sender As Object, e As EventArgs) Handles signupBtn.Click
        openConnection()
        Try
            cmd.Connection = connection
            cmd.Parameters.Clear()
            cmd.CommandText = "INSERT INTO users (FNAME, USERNAME, EMAIL, PASSWORD_HASH, ROLE) VALUES (@FNAME, @USERNAME, @EMAIL, @PASSWORD_HASH, @ROLE)"
            cmd.Parameters.AddWithValue("@FNAME", fname.Text)
            cmd.Parameters.AddWithValue("@USERNAME", uname.Text)
            cmd.Parameters.AddWithValue("@EMAIL", email.Text)
            cmd.Parameters.AddWithValue("@PASSWORD_HASH", password.Text)
            cmd.Parameters.AddWithValue("@ROLE", roleCmb.SelectedItem.ToString())

            cmd.ExecuteNonQuery()
            MsgBox("Registration Succesful!")
            connection.Close()
            fname.Clear()
            uname.Clear()
            email.Clear()
            password.Clear()
            roleCmb.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim signupForm As New loginForm()
        signupForm.Show()
        Me.Hide()
    End Sub
End Class
