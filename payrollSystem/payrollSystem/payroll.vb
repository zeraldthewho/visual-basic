Public Class payroll


    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnEarnings_Click(sender As Object, e As EventArgs) Handles btnEarnings.Click
        switchPanel(earnings)
    End Sub

    Private Sub newEmployee_Click(sender As Object, e As EventArgs) Handles newEmployee.Click
        Dim earnings As earnings = CType(Application.OpenForms("earnings"), earnings)
        If earnings IsNot Nothing Then
            earnings.ClearTextBox()
        End If

        txtEmployeeName.Clear()

    End Sub

    Private Sub btnDeduc_Click(sender As Object, e As EventArgs) Handles btnDeduc.Click
        switchPanel(deduction)
    End Sub
End Class