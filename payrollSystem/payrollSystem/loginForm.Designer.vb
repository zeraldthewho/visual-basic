<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        SplitContainer1 = New SplitContainer()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        signupBtn2 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        loginBtn = New Button()
        Label6 = New Label()
        Label4 = New Label()
        passwordLogin = New TextBox()
        userLogin = New TextBox()
        Label2 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.Green
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(signupBtn2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.ForestGreen
        SplitContainer1.Panel2.Controls.Add(PictureBox1)
        SplitContainer1.Panel2.Controls.Add(loginBtn)
        SplitContainer1.Panel2.Controls.Add(Label6)
        SplitContainer1.Panel2.Controls.Add(Label4)
        SplitContainer1.Panel2.Controls.Add(passwordLogin)
        SplitContainer1.Panel2.Controls.Add(userLogin)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Size = New Size(502, 450)
        SplitContainer1.SplitterDistance = 200
        SplitContainer1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(41, 136)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(121, 104)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(23, 310)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 19)
        Label3.TabIndex = 6
        Label3.Text = "Don't have an account?"
        ' 
        ' signupBtn2
        ' 
        signupBtn2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        signupBtn2.BackColor = Color.ForestGreen
        signupBtn2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signupBtn2.ForeColor = Color.LightGreen
        signupBtn2.Location = New Point(41, 272)
        signupBtn2.Margin = New Padding(3, 2, 3, 2)
        signupBtn2.Name = "signupBtn2"
        signupBtn2.Size = New Size(121, 36)
        signupBtn2.TabIndex = 4
        signupBtn2.Text = "Sign up"
        signupBtn2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 37)
        Label1.TabIndex = 3
        Label1.Text = "Payroll V1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(86, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(103, 89)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' loginBtn
        ' 
        loginBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        loginBtn.BackColor = Color.ForestGreen
        loginBtn.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = Color.LightGreen
        loginBtn.Location = New Point(86, 353)
        loginBtn.Margin = New Padding(3, 2, 3, 2)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(114, 40)
        loginBtn.TabIndex = 7
        loginBtn.Text = "Sign in"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(64, 267)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 19)
        Label6.TabIndex = 6
        Label6.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(64, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 19)
        Label4.TabIndex = 5
        Label4.Text = "Username:"
        ' 
        ' passwordLogin
        ' 
        passwordLogin.BorderStyle = BorderStyle.FixedSingle
        passwordLogin.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordLogin.ForeColor = SystemColors.ActiveCaptionText
        passwordLogin.Location = New Point(64, 289)
        passwordLogin.Multiline = True
        passwordLogin.Name = "passwordLogin"
        passwordLogin.PasswordChar = "*"c
        passwordLogin.Size = New Size(171, 24)
        passwordLogin.TabIndex = 4
        ' 
        ' userLogin
        ' 
        userLogin.BorderStyle = BorderStyle.FixedSingle
        userLogin.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userLogin.ForeColor = SystemColors.ActiveCaptionText
        userLogin.Location = New Point(64, 216)
        userLogin.Multiline = True
        userLogin.Name = "userLogin"
        userLogin.Size = New Size(171, 24)
        userLogin.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(99, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 29)
        Label2.TabIndex = 3
        Label2.Text = "Login"
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(502, 450)
        Controls.Add(SplitContainer1)
        Name = "loginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll v1"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents signupBtn2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordLogin As TextBox
    Friend WithEvents userLogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub fname_TextChanged(sender As Object, e As EventArgs) Handles userLogin.TextChanged

    End Sub
End Class
