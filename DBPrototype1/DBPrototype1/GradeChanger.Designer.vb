<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeChanger
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
        Me.StudentsComboBox = New System.Windows.Forms.ComboBox()
        Me.Update = New System.Windows.Forms.Button()
        Me.GradeBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StudentsComboBox
        '
        Me.StudentsComboBox.FormattingEnabled = True
        Me.StudentsComboBox.Location = New System.Drawing.Point(12, 101)
        Me.StudentsComboBox.Name = "StudentsComboBox"
        Me.StudentsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StudentsComboBox.TabIndex = 0
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(197, 99)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 23)
        Me.Update.TabIndex = 1
        Me.Update.Text = "Button1"
        Me.Update.UseVisualStyleBackColor = True
        '
        'GradeBox
        '
        Me.GradeBox.Location = New System.Drawing.Point(147, 101)
        Me.GradeBox.Name = "GradeBox"
        Me.GradeBox.Size = New System.Drawing.Size(44, 20)
        Me.GradeBox.TabIndex = 2
        '
        'GradeChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GradeBox)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.StudentsComboBox)
        Me.Name = "GradeChanger"
        Me.Text = "GradeChanger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Update As System.Windows.Forms.Button
    Friend WithEvents GradeBox As System.Windows.Forms.TextBox
End Class
