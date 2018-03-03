<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.CancelButtons = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Subjectdrop = New System.Windows.Forms.ComboBox()
        Me.Subject = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(22, 237)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'CancelButtons
        '
        Me.CancelButtons.Location = New System.Drawing.Point(146, 237)
        Me.CancelButtons.Name = "CancelButtons"
        Me.CancelButtons.Size = New System.Drawing.Size(75, 23)
        Me.CancelButtons.TabIndex = 2
        Me.CancelButtons.Text = "Cancel"
        Me.CancelButtons.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(270, 237)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 3
        Me.RegisterButton.Text = "Sign up"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(121, 59)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(100, 20)
        Me.username.TabIndex = 4
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(121, 112)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 20)
        Me.Password.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Login "
        '
        'Subjectdrop
        '
        Me.Subjectdrop.FormattingEnabled = True
        Me.Subjectdrop.Items.AddRange(New Object() {"Maths", "English", "Science"})
        Me.Subjectdrop.Location = New System.Drawing.Point(121, 167)
        Me.Subjectdrop.Name = "Subjectdrop"
        Me.Subjectdrop.Size = New System.Drawing.Size(100, 21)
        Me.Subjectdrop.TabIndex = 9
        '
        'Subject
        '
        Me.Subject.AutoSize = True
        Me.Subject.Location = New System.Drawing.Point(30, 175)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(83, 13)
        Me.Subject.TabIndex = 10
        Me.Subject.Text = "TeacherSubject"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 297)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.Subjectdrop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.CancelButtons)
        Me.Controls.Add(Me.LoginButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents CancelButtons As System.Windows.Forms.Button
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Subjectdrop As System.Windows.Forms.ComboBox
    Friend WithEvents Subject As System.Windows.Forms.Label

End Class
