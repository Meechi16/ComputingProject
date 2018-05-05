<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subjectlist
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
        Me.SeatingButt = New System.Windows.Forms.Button()
        Me.Addbutt = New System.Windows.Forms.Button()
        Me.DeleteButt = New System.Windows.Forms.Button()
        Me.ClassTables = New System.Windows.Forms.TabControl()
        Me.ChangeGrades = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SeatingButt
        '
        Me.SeatingButt.BackColor = System.Drawing.Color.MintCream
        Me.SeatingButt.Location = New System.Drawing.Point(365, 281)
        Me.SeatingButt.Name = "SeatingButt"
        Me.SeatingButt.Size = New System.Drawing.Size(75, 23)
        Me.SeatingButt.TabIndex = 2
        Me.SeatingButt.Text = "Seating Plan"
        Me.SeatingButt.UseVisualStyleBackColor = False
        '
        'Addbutt
        '
        Me.Addbutt.BackColor = System.Drawing.Color.MintCream
        Me.Addbutt.Location = New System.Drawing.Point(56, 252)
        Me.Addbutt.Name = "Addbutt"
        Me.Addbutt.Size = New System.Drawing.Size(75, 23)
        Me.Addbutt.TabIndex = 3
        Me.Addbutt.Text = "Add"
        Me.Addbutt.UseVisualStyleBackColor = False
        '
        'DeleteButt
        '
        Me.DeleteButt.BackColor = System.Drawing.Color.MintCream
        Me.DeleteButt.Location = New System.Drawing.Point(170, 252)
        Me.DeleteButt.Name = "DeleteButt"
        Me.DeleteButt.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButt.TabIndex = 4
        Me.DeleteButt.Text = "Delete"
        Me.DeleteButt.UseVisualStyleBackColor = False
        '
        'ClassTables
        '
        Me.ClassTables.Location = New System.Drawing.Point(29, 12)
        Me.ClassTables.Name = "ClassTables"
        Me.ClassTables.SelectedIndex = 0
        Me.ClassTables.Size = New System.Drawing.Size(411, 216)
        Me.ClassTables.TabIndex = 7
        '
        'ChangeGrades
        '
        Me.ChangeGrades.BackColor = System.Drawing.Color.MintCream
        Me.ChangeGrades.Location = New System.Drawing.Point(282, 252)
        Me.ChangeGrades.Name = "ChangeGrades"
        Me.ChangeGrades.Size = New System.Drawing.Size(75, 23)
        Me.ChangeGrades.TabIndex = 8
        Me.ChangeGrades.Text = "Grades"
        Me.ChangeGrades.UseVisualStyleBackColor = False
        '
        'Subjectlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(482, 316)
        Me.Controls.Add(Me.ChangeGrades)
        Me.Controls.Add(Me.ClassTables)
        Me.Controls.Add(Me.DeleteButt)
        Me.Controls.Add(Me.Addbutt)
        Me.Controls.Add(Me.SeatingButt)
        Me.Name = "Subjectlist"
        Me.Text = "`"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SeatingButt As System.Windows.Forms.Button
    Friend WithEvents Addbutt As System.Windows.Forms.Button
    Friend WithEvents DeleteButt As System.Windows.Forms.Button
    Friend WithEvents ClassTables As System.Windows.Forms.TabControl
    Friend WithEvents ChangeGrades As System.Windows.Forms.Button
End Class
