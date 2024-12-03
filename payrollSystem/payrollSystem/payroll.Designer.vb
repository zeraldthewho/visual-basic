<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        newEmployee = New Button()
        retrieveEmployee = New Button()
        txtEmployeeName = New TextBox()
        payslipDate = New DateTimePicker()
        btnEarnings = New Button()
        btnDeduc = New Button()
        btnPayslip = New Button()
        Process1 = New Process()
        Label3 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' MySqlDataAdapter1
        ' 
        MySqlDataAdapter1.DeleteCommand = Nothing
        MySqlDataAdapter1.InsertCommand = Nothing
        MySqlDataAdapter1.SelectCommand = Nothing
        MySqlDataAdapter1.UpdateCommand = Nothing
        ' 
        ' newEmployee
        ' 
        newEmployee.BackColor = Color.ForestGreen
        newEmployee.Font = New Font("Microsoft Sans Serif", 9F)
        newEmployee.ForeColor = Color.White
        newEmployee.Location = New Point(12, 22)
        newEmployee.Margin = New Padding(3, 2, 3, 2)
        newEmployee.Name = "newEmployee"
        newEmployee.Size = New Size(161, 31)
        newEmployee.TabIndex = 8
        newEmployee.Text = "New Employee"
        newEmployee.UseVisualStyleBackColor = False
        ' 
        ' retrieveEmployee
        ' 
        retrieveEmployee.BackColor = Color.ForestGreen
        retrieveEmployee.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        retrieveEmployee.Font = New Font("Microsoft Sans Serif", 9F)
        retrieveEmployee.ForeColor = Color.White
        retrieveEmployee.Location = New Point(205, 22)
        retrieveEmployee.Margin = New Padding(3, 2, 3, 2)
        retrieveEmployee.Name = "retrieveEmployee"
        retrieveEmployee.Size = New Size(161, 31)
        retrieveEmployee.TabIndex = 8
        retrieveEmployee.Text = "Retrieve Employee"
        retrieveEmployee.UseVisualStyleBackColor = False
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeName.Location = New Point(158, 58)
        txtEmployeeName.Multiline = True
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(206, 23)
        txtEmployeeName.TabIndex = 9
        ' 
        ' payslipDate
        ' 
        payslipDate.CalendarForeColor = SystemColors.WindowText
        payslipDate.CalendarTitleForeColor = Color.ForestGreen
        payslipDate.Location = New Point(158, 97)
        payslipDate.Name = "payslipDate"
        payslipDate.Size = New Size(206, 23)
        payslipDate.TabIndex = 10
        ' 
        ' btnEarnings
        ' 
        btnEarnings.BackColor = Color.ForestGreen
        btnEarnings.Font = New Font("Microsoft Sans Serif", 9F)
        btnEarnings.ForeColor = Color.White
        btnEarnings.Location = New Point(12, 134)
        btnEarnings.Margin = New Padding(3, 2, 3, 2)
        btnEarnings.Name = "btnEarnings"
        btnEarnings.Size = New Size(114, 42)
        btnEarnings.TabIndex = 8
        btnEarnings.Text = "Earnings"
        btnEarnings.UseVisualStyleBackColor = False
        ' 
        ' btnDeduc
        ' 
        btnDeduc.BackColor = Color.ForestGreen
        btnDeduc.Font = New Font("Microsoft Sans Serif", 9F)
        btnDeduc.ForeColor = Color.White
        btnDeduc.Location = New Point(132, 134)
        btnDeduc.Margin = New Padding(3, 2, 3, 2)
        btnDeduc.Name = "btnDeduc"
        btnDeduc.Size = New Size(114, 42)
        btnDeduc.TabIndex = 8
        btnDeduc.Text = "Deductions"
        btnDeduc.UseVisualStyleBackColor = False
        ' 
        ' btnPayslip
        ' 
        btnPayslip.BackColor = Color.ForestGreen
        btnPayslip.Font = New Font("Microsoft Sans Serif", 9F)
        btnPayslip.ForeColor = Color.White
        btnPayslip.Location = New Point(252, 134)
        btnPayslip.Margin = New Padding(3, 2, 3, 2)
        btnPayslip.Name = "btnPayslip"
        btnPayslip.Size = New Size(114, 42)
        btnPayslip.TabIndex = 8
        btnPayslip.Text = "Payslip"
        btnPayslip.UseVisualStyleBackColor = False
        ' 
        ' Process1
        ' 
        Process1.StartInfo.Domain = ""
        Process1.StartInfo.LoadUserProfile = False
        Process1.StartInfo.Password = Nothing
        Process1.StartInfo.StandardErrorEncoding = Nothing
        Process1.StartInfo.StandardInputEncoding = Nothing
        Process1.StartInfo.StandardOutputEncoding = Nothing
        Process1.StartInfo.UseCredentialsForNetworkingOnly = False
        Process1.StartInfo.UserName = ""
        Process1.SynchronizingObject = Me
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(12, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 11
        Label3.Text = "Employee"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.ForestGreen
        Label1.Location = New Point(12, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 19)
        Label1.TabIndex = 11
        Label1.Text = "Payslip Date"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(12, 200)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(354, 395)
        Panel1.TabIndex = 12
        ' 
        ' payroll
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(381, 607)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(payslipDate)
        Controls.Add(txtEmployeeName)
        Controls.Add(retrieveEmployee)
        Controls.Add(btnPayslip)
        Controls.Add(btnDeduc)
        Controls.Add(btnEarnings)
        Controls.Add(newEmployee)
        Name = "payroll"
        Text = "Payroll v1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents newEmployee As Button
    Friend WithEvents retrieveEmployee As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Process1 As Process
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents payslipDate As DateTimePicker
    Friend WithEvents btnEarnings As Button
    Friend WithEvents btnDeduc As Button
    Friend WithEvents btnPayslip As Button
End Class
