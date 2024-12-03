<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class earnings
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
        Label3 = New Label()
        txtDays = New TextBox()
        Label1 = New Label()
        txtRate = New TextBox()
        Label2 = New Label()
        txtHour = New TextBox()
        Label4 = New Label()
        txtGross = New TextBox()
        Label5 = New Label()
        btnCompute = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(53, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 33)
        Label3.TabIndex = 12
        Label3.Text = "Earnings"
        ' 
        ' txtDays
        ' 
        txtDays.BorderStyle = BorderStyle.FixedSingle
        txtDays.Font = New Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDays.ForeColor = Color.ForestGreen
        txtDays.Location = New Point(63, 109)
        txtDays.Multiline = True
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(67, 24)
        txtDays.TabIndex = 13
        txtDays.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.ForestGreen
        Label1.Location = New Point(149, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 18)
        Label1.TabIndex = 12
        Label1.Text = "Numbers of  Day Worked"
        ' 
        ' txtRate
        ' 
        txtRate.BorderStyle = BorderStyle.FixedSingle
        txtRate.Font = New Font("Arial Narrow", 10.8F)
        txtRate.ForeColor = Color.ForestGreen
        txtRate.Location = New Point(63, 139)
        txtRate.Multiline = True
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(67, 24)
        txtRate.TabIndex = 13
        txtRate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.ForestGreen
        Label2.Location = New Point(149, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 18)
        Label2.TabIndex = 12
        Label2.Text = "Rate per hour"
        ' 
        ' txtHour
        ' 
        txtHour.BorderStyle = BorderStyle.FixedSingle
        txtHour.Font = New Font("Arial Narrow", 10.8F)
        txtHour.ForeColor = Color.ForestGreen
        txtHour.Location = New Point(63, 169)
        txtHour.Multiline = True
        txtHour.Name = "txtHour"
        txtHour.Size = New Size(67, 24)
        txtHour.TabIndex = 13
        txtHour.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.ForestGreen
        Label4.Location = New Point(149, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 18)
        Label4.TabIndex = 12
        Label4.Text = "Hour per day"
        ' 
        ' txtGross
        ' 
        txtGross.BorderStyle = BorderStyle.FixedSingle
        txtGross.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGross.ForeColor = Color.ForestGreen
        txtGross.Location = New Point(161, 214)
        txtGross.Multiline = True
        txtGross.Name = "txtGross"
        txtGross.Size = New Size(81, 23)
        txtGross.TabIndex = 13
        txtGross.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.ForestGreen
        Label5.Location = New Point(63, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 18)
        Label5.TabIndex = 12
        Label5.Text = "Gross Salary:"
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.ForestGreen
        btnCompute.Font = New Font("Microsoft Sans Serif", 9F)
        btnCompute.ForeColor = Color.White
        btnCompute.Location = New Point(247, 210)
        btnCompute.Margin = New Padding(3, 2, 3, 2)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(94, 28)
        btnCompute.TabIndex = 14
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' earnings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 419)
        Controls.Add(btnCompute)
        Controls.Add(txtGross)
        Controls.Add(txtHour)
        Controls.Add(txtRate)
        Controls.Add(txtDays)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Name = "earnings"
        Text = "earnings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHour As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCompute As Button
    Public WithEvents txtGross As TextBox
End Class
