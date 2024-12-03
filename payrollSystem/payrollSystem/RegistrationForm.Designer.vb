<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        fname = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        uname = New TextBox()
        Label5 = New Label()
        email = New TextBox()
        Label6 = New Label()
        password = New TextBox()
        roleCmb = New ComboBox()
        Label7 = New Label()
        signupBtn = New Button()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' fname
        ' 
        fname.BorderStyle = BorderStyle.FixedSingle
        fname.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fname.ForeColor = SystemColors.ActiveCaptionText
        fname.Location = New Point(148, 179)
        fname.Multiline = True
        fname.Name = "fname"
        fname.Size = New Size(171, 24)
        fname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(24, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(368, 37)
        Label1.TabIndex = 1
        Label1.Text = "Welcome To Payroll V1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(63, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(273, 19)
        Label2.TabIndex = 1
        Label2.Text = "Fill out the form carefully for registration"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(49, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 19)
        Label3.TabIndex = 1
        Label3.Text = "Fullname:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(49, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 19)
        Label4.TabIndex = 1
        Label4.Text = "Username:"
        ' 
        ' uname
        ' 
        uname.BackColor = Color.White
        uname.BorderStyle = BorderStyle.FixedSingle
        uname.Font = New Font("Arial Narrow", 11.25F)
        uname.ForeColor = SystemColors.ActiveCaptionText
        uname.Location = New Point(148, 225)
        uname.Multiline = True
        uname.Name = "uname"
        uname.Size = New Size(171, 24)
        uname.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(49, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 19)
        Label5.TabIndex = 1
        Label5.Text = "Email:"
        ' 
        ' email
        ' 
        email.BackColor = Color.White
        email.BorderStyle = BorderStyle.FixedSingle
        email.Font = New Font("Arial Narrow", 11.25F)
        email.ForeColor = SystemColors.ActiveCaptionText
        email.Location = New Point(148, 271)
        email.Multiline = True
        email.Name = "email"
        email.Size = New Size(171, 24)
        email.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(49, 323)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 19)
        Label6.TabIndex = 1
        Label6.Text = "Password:"
        ' 
        ' password
        ' 
        password.BackColor = Color.White
        password.BorderStyle = BorderStyle.FixedSingle
        password.Font = New Font("Arial Narrow", 11.25F)
        password.ForeColor = SystemColors.ActiveCaptionText
        password.Location = New Point(148, 318)
        password.MaxLength = 16
        password.Multiline = True
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(171, 24)
        password.TabIndex = 0
        ' 
        ' roleCmb
        ' 
        roleCmb.BackColor = Color.White
        roleCmb.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roleCmb.FormattingEnabled = True
        roleCmb.Items.AddRange(New Object() {"Admin", "Employee"})
        roleCmb.Location = New Point(148, 364)
        roleCmb.Name = "roleCmb"
        roleCmb.Size = New Size(171, 28)
        roleCmb.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(49, 364)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 19)
        Label7.TabIndex = 1
        Label7.Text = "Role:"
        ' 
        ' signupBtn
        ' 
        signupBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        signupBtn.BackColor = Color.ForestGreen
        signupBtn.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signupBtn.ForeColor = Color.LightGreen
        signupBtn.Location = New Point(103, 417)
        signupBtn.Margin = New Padding(3, 2, 3, 2)
        signupBtn.Name = "signupBtn"
        signupBtn.Size = New Size(233, 40)
        signupBtn.TabIndex = 3
        signupBtn.Text = "Sign up"
        signupBtn.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.PaleGreen
        LinkLabel1.Location = New Point(135, 471)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(175, 19)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already have an account?"
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(443, 513)
        Controls.Add(LinkLabel1)
        Controls.Add(signupBtn)
        Controls.Add(roleCmb)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(password)
        Controls.Add(email)
        Controls.Add(uname)
        Controls.Add(fname)
        Name = "RegistrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll v1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents uname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents roleCmb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents signupBtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
