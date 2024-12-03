Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class earnings
    Public Sub ClearTextBox()
        txtGross.Clear()
        txtDays.Clear()
        txtRate.Clear()
        txtHour.Clear()
    End Sub
    Private Sub txtDays_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDays.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHour.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Dim result As Integer

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        result = ((txtHour.Text * txtDays.Text) * (txtRate.Text))
        txtGross.Text = result

        Dim deduc As New deduction
        deduc.Show()
        deduc.Hide()
    End Sub

    Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged

    End Sub
End Class