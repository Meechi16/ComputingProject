<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreeSeatingPlan
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
        Me.Create = New System.Windows.Forms.Button()
        Me.OrderByComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Create
        '
        Me.Create.BackColor = System.Drawing.Color.MintCream
        Me.Create.Location = New System.Drawing.Point(100, 217)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(75, 23)
        Me.Create.TabIndex = 0
        Me.Create.Text = "Create"
        Me.Create.UseVisualStyleBackColor = False
        '
        'OrderByComboBox
        '
        Me.OrderByComboBox.FormattingEnabled = True
        Me.OrderByComboBox.Items.AddRange(New Object() {"Age", "Alphabetical ", "Gender", "Grades", "None"})
        Me.OrderByComboBox.Location = New System.Drawing.Point(85, 44)
        Me.OrderByComboBox.Name = "OrderByComboBox"
        Me.OrderByComboBox.Size = New System.Drawing.Size(121, 21)
        Me.OrderByComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "OrderBy"
        '
        'PreeSeatingPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderByComboBox)
        Me.Controls.Add(Me.Create)
        Me.Name = "PreeSeatingPlan"
        Me.Text = "PreeSeating_Plan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Create As System.Windows.Forms.Button
    Friend WithEvents OrderByComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
