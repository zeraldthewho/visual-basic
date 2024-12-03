<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Label1 = New Label()
        loginBtn = New Button()
        signupBtn2 = New Button()
        Label2 = New Label()
        homeForm = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(201, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 56)
        Label1.TabIndex = 2
        Label1.Text = "Payroll V1"
        ' 
        ' loginBtn
        ' 
        loginBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        loginBtn.BackColor = Color.ForestGreen
        loginBtn.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = Color.LightGreen
        loginBtn.Location = New Point(95, 134)
        loginBtn.Margin = New Padding(3, 2, 3, 2)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(192, 40)
        loginBtn.TabIndex = 4
        loginBtn.Text = "Sign in"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' signupBtn2
        ' 
        signupBtn2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        signupBtn2.BackColor = Color.ForestGreen
        signupBtn2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signupBtn2.ForeColor = Color.LightGreen
        signupBtn2.Location = New Point(375, 134)
        signupBtn2.Margin = New Padding(3, 2, 3, 2)
        signupBtn2.Name = "signupBtn2"
        signupBtn2.Size = New Size(192, 40)
        signupBtn2.TabIndex = 4
        signupBtn2.Text = "Sign up"
        signupBtn2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(112, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 19)
        Label2.TabIndex = 5
        Label2.Text = "Already have an account?"
        ' 
        ' homeForm
        ' 
        homeForm.AutoSize = True
        homeForm.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        homeForm.ForeColor = Color.White
        homeForm.Location = New Point(388, 176)
        homeForm.Name = "homeForm"
        homeForm.Size = New Size(161, 19)
        homeForm.TabIndex = 5
        homeForm.Text = "Don't have an account?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(155, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(359, 38)
        Label4.TabIndex = 5
        Label4.Text = "Go automated and avoid common computation errors!" & vbCrLf & vbCrLf
        ' 
        ' home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(655, 254)
        Controls.Add(homeForm)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(signupBtn2)
        Controls.Add(loginBtn)
        Controls.Add(Label1)
        Name = "home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll v1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents signupBtn2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents homeForm As Label
    Friend WithEvents Label4 As Label

End Class
