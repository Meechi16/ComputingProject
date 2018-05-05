<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstNameTxtBox = New System.Windows.Forms.TextBox()
        Me.LastNameTxtBox = New System.Windows.Forms.TextBox()
        Me.AgeTxtBox = New System.Windows.Forms.TextBox()
        Me.GenderTxtBox = New System.Windows.Forms.TextBox()
        Me.ClassIDTxtBox = New System.Windows.Forms.TextBox()
        Me.PCITxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EnterStudentButton = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LastName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ClassID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(277, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 5
        '
        'FirstNameTxtBox
        '
        Me.FirstNameTxtBox.Location = New System.Drawing.Point(103, 38)
        Me.FirstNameTxtBox.Name = "FirstNameTxtBox"
        Me.FirstNameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTxtBox.TabIndex = 6
        '
        'LastNameTxtBox
        '
        Me.LastNameTxtBox.Location = New System.Drawing.Point(346, 35)
        Me.LastNameTxtBox.Name = "LastNameTxtBox"
        Me.LastNameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTxtBox.TabIndex = 7
        '
        'AgeTxtBox
        '
        Me.AgeTxtBox.Location = New System.Drawing.Point(103, 143)
        Me.AgeTxtBox.Name = "AgeTxtBox"
        Me.AgeTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTxtBox.TabIndex = 8
        '
        'GenderTxtBox
        '
        Me.GenderTxtBox.Location = New System.Drawing.Point(103, 90)
        Me.GenderTxtBox.Name = "GenderTxtBox"
        Me.GenderTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTxtBox.TabIndex = 9
        '
        'ClassIDTxtBox
        '
        Me.ClassIDTxtBox.Location = New System.Drawing.Point(346, 93)
        Me.ClassIDTxtBox.Name = "ClassIDTxtBox"
        Me.ClassIDTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassIDTxtBox.TabIndex = 10
        '
        'PCITxtBox
        '
        Me.PCITxtBox.Location = New System.Drawing.Point(346, 147)
        Me.PCITxtBox.Name = "PCITxtBox"
        Me.PCITxtBox.Size = New System.Drawing.Size(100, 20)
        Me.PCITxtBox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ParentContactInfo"
        '
        'EnterStudentButton
        '
        Me.EnterStudentButton.BackColor = System.Drawing.Color.MintCream
        Me.EnterStudentButton.Location = New System.Drawing.Point(128, 226)
        Me.EnterStudentButton.Name = "EnterStudentButton"
        Me.EnterStudentButton.Size = New System.Drawing.Size(75, 23)
        Me.EnterStudentButton.TabIndex = 19
        Me.EnterStudentButton.Text = "Enter"
        Me.EnterStudentButton.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.MintCream
        Me.Cancel.Location = New System.Drawing.Point(250, 226)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 20
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(482, 261)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.EnterStudentButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PCITxtBox)
        Me.Controls.Add(Me.ClassIDTxtBox)
        Me.Controls.Add(Me.GenderTxtBox)
        Me.Controls.Add(Me.AgeTxtBox)
        Me.Controls.Add(Me.LastNameTxtBox)
        Me.Controls.Add(Me.FirstNameTxtBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddStudent"
        Me.Text = "AddStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FirstNameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassIDTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents PCITxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EnterStudentButton As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
