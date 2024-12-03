Public Class deduction

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub deduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGross.Text = earnings.txtGross.Text
    End Sub

    Private Sub txtGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGross.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub


    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

    End Sub

    Private Sub chTax_CheckedChanged(sender As Object, e As EventArgs) Handles chTax.CheckedChanged

    End Sub
End Class
