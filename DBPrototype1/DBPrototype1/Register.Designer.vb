<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Firstnametb = New System.Windows.Forms.TextBox()
        Me.Lastnametb = New System.Windows.Forms.TextBox()
        Me.UserNametb = New System.Windows.Forms.TextBox()
        Me.Passwordtb = New System.Windows.Forms.TextBox()
        Me.RePasstb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Repassword = New System.Windows.Forms.Label()
        Me.Subjectdrop = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Firstnametb
        '
        Me.Firstnametb.Location = New System.Drawing.Point(133, 51)
        Me.Firstnametb.Name = "Firstnametb"
        Me.Firstnametb.Size = New System.Drawing.Size(100, 20)
        Me.Firstnametb.TabIndex = 2
        '
        'Lastnametb
        '
        Me.Lastnametb.Location = New System.Drawing.Point(364, 51)
        Me.Lastnametb.Name = "Lastnametb"
        Me.Lastnametb.Size = New System.Drawing.Size(100, 20)
        Me.Lastnametb.TabIndex = 3
        '
        'UserNametb
        '
        Me.UserNametb.Location = New System.Drawing.Point(133, 126)
        Me.UserNametb.Name = "UserNametb"
        Me.UserNametb.Size = New System.Drawing.Size(100, 20)
        Me.UserNametb.TabIndex = 4
        '
        'Passwordtb
        '
        Me.Passwordtb.Location = New System.Drawing.Point(364, 126)
        Me.Passwordtb.Name = "Passwordtb"
        Me.Passwordtb.Size = New System.Drawing.Size(100, 20)
        Me.Passwordtb.TabIndex = 5
        '
        'RePasstb
        '
        Me.RePasstb.Location = New System.Drawing.Point(364, 194)
        Me.RePasstb.Name = "RePasstb"
        Me.RePasstb.Size = New System.Drawing.Size(100, 20)
        Me.RePasstb.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'Repassword
        '
        Me.Repassword.AutoSize = True
        Me.Repassword.Location = New System.Drawing.Point(294, 201)
        Me.Repassword.Name = "Repassword"
        Me.Repassword.Size = New System.Drawing.Size(66, 13)
        Me.Repassword.TabIndex = 13
        Me.Repassword.Text = "Repassword"
        '
        'Subjectdrop
        '
        Me.Subjectdrop.FormattingEnabled = True
        Me.Subjectdrop.Items.AddRange(New Object() {"Maths", "Science", "English"})
        Me.Subjectdrop.Location = New System.Drawing.Point(133, 194)
        Me.Subjectdrop.Name = "Subjectdrop"
        Me.Subjectdrop.Size = New System.Drawing.Size(121, 21)
        Me.Subjectdrop.TabIndex = 14
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 281)
        Me.Controls.Add(Me.Subjectdrop)
        Me.Controls.Add(Me.Repassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RePasstb)
        Me.Controls.Add(Me.Passwordtb)
        Me.Controls.Add(Me.UserNametb)
        Me.Controls.Add(Me.Lastnametb)
        Me.Controls.Add(Me.Firstnametb)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Firstnametb As System.Windows.Forms.TextBox
    Friend WithEvents Lastnametb As System.Windows.Forms.TextBox
    Friend WithEvents UserNametb As System.Windows.Forms.TextBox
    Friend WithEvents Passwordtb As System.Windows.Forms.TextBox
    Friend WithEvents RePasstb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Repassword As System.Windows.Forms.Label
    Friend WithEvents Subjectdrop As System.Windows.Forms.ComboBox
End Class
