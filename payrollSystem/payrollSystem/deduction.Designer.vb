<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deduction
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
        btnCompute = New Button()
        txtGross = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtNet = New TextBox()
        txtDeduc = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        txtTotalDeduc = New TextBox()
        chTax = New CheckBox()
        chPhil = New CheckBox()
        chSSS = New CheckBox()
        SuspendLayout()
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.ForestGreen
        btnCompute.Font = New Font("Microsoft Sans Serif", 9F)
        btnCompute.ForeColor = Color.White
        btnCompute.Location = New Point(167, 284)
        btnCompute.Margin = New Padding(3, 2, 3, 2)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(94, 28)
        btnCompute.TabIndex = 24
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' txtGross
        ' 
        txtGross.BorderStyle = BorderStyle.FixedSingle
        txtGross.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGross.ForeColor = Color.ForestGreen
        txtGross.Location = New Point(167, 163)
        txtGross.Multiline = True
        txtGross.Name = "txtGross"
        txtGross.Size = New Size(81, 23)
        txtGross.TabIndex = 20
        txtGross.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.ForestGreen
        Label5.Location = New Point(69, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 18)
        Label5.TabIndex = 15
        Label5.Text = "Gross Salary:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.ForestGreen
        Label4.Location = New Point(179, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 18)
        Label4.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(69, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 19
        Label3.Text = "Deductions"
        ' 
        ' txtNet
        ' 
        txtNet.BorderStyle = BorderStyle.FixedSingle
        txtNet.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNet.ForeColor = Color.ForestGreen
        txtNet.Location = New Point(167, 191)
        txtNet.Multiline = True
        txtNet.Name = "txtNet"
        txtNet.Size = New Size(81, 23)
        txtNet.TabIndex = 20
        txtNet.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDeduc
        ' 
        txtDeduc.BorderStyle = BorderStyle.FixedSingle
        txtDeduc.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDeduc.ForeColor = Color.ForestGreen
        txtDeduc.Location = New Point(167, 220)
        txtDeduc.Multiline = True
        txtDeduc.Name = "txtDeduc"
        txtDeduc.Size = New Size(81, 23)
        txtDeduc.TabIndex = 20
        txtDeduc.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.ForestGreen
        Label1.Location = New Point(80, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 18)
        Label1.TabIndex = 15
        Label1.Text = "Net Salary:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.ForestGreen
        Label2.Location = New Point(62, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 18)
        Label2.TabIndex = 15
        Label2.Text = "Total Deduction:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.ForestGreen
        Label6.Location = New Point(80, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 18)
        Label6.TabIndex = 15
        Label6.Text = "Deduction:"
        ' 
        ' txtTotalDeduc
        ' 
        txtTotalDeduc.BorderStyle = BorderStyle.FixedSingle
        txtTotalDeduc.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotalDeduc.ForeColor = Color.ForestGreen
        txtTotalDeduc.Location = New Point(179, 251)
        txtTotalDeduc.Multiline = True
        txtTotalDeduc.Name = "txtTotalDeduc"
        txtTotalDeduc.Size = New Size(81, 23)
        txtTotalDeduc.TabIndex = 20
        txtTotalDeduc.TextAlign = HorizontalAlignment.Center
        ' 
        ' chTax
        ' 
        chTax.AutoSize = True
        chTax.Font = New Font("Calibri", 11.25F)
        chTax.ForeColor = Color.ForestGreen
        chTax.Location = New Point(86, 86)
        chTax.Margin = New Padding(3, 2, 3, 2)
        chTax.Name = "chTax"
        chTax.Size = New Size(85, 22)
        chTax.TabIndex = 25
        chTax.Text = "Tax (15%)"
        chTax.UseVisualStyleBackColor = True
        ' 
        ' chPhil
        ' 
        chPhil.AutoSize = True
        chPhil.Font = New Font("Calibri", 11.25F)
        chPhil.ForeColor = Color.ForestGreen
        chPhil.Location = New Point(86, 111)
        chPhil.Margin = New Padding(3, 2, 3, 2)
        chPhil.Name = "chPhil"
        chPhil.Size = New Size(123, 22)
        chPhil.TabIndex = 25
        chPhil.Text = "PhilHealth (5%)"
        chPhil.UseVisualStyleBackColor = True
        ' 
        ' chSSS
        ' 
        chSSS.AutoSize = True
        chSSS.Font = New Font("Calibri", 11.25F)
        chSSS.ForeColor = Color.ForestGreen
        chSSS.Location = New Point(86, 135)
        chSSS.Margin = New Padding(3, 2, 3, 2)
        chSSS.Name = "chSSS"
        chSSS.Size = New Size(79, 22)
        chSSS.TabIndex = 25
        chSSS.Text = "SSS (2%)"
        chSSS.UseVisualStyleBackColor = True
        ' 
        ' deduction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 375)
        Controls.Add(chSSS)
        Controls.Add(chPhil)
        Controls.Add(chTax)
        Controls.Add(btnCompute)
        Controls.Add(txtTotalDeduc)
        Controls.Add(txtDeduc)
        Controls.Add(txtNet)
        Controls.Add(txtGross)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Margin = New Padding(3, 2, 3, 2)
        Name = "deduction"
        Text = "deduction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCompute As Button
    Friend WithEvents txtGross As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNet As TextBox
    Friend WithEvents txtDeduc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalDeduc As TextBox
    Friend WithEvents chTax As CheckBox
    Friend WithEvents chPhil As CheckBox
    Friend WithEvents chSSS As CheckBox
End Class
