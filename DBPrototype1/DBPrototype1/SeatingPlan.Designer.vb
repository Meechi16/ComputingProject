<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatingPlan
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
        Me.AddTable = New System.Windows.Forms.Button()
        Me.RemoveTable = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButtSP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddTable
        '
        Me.AddTable.Location = New System.Drawing.Point(498, 49)
        Me.AddTable.Name = "AddTable"
        Me.AddTable.Size = New System.Drawing.Size(75, 23)
        Me.AddTable.TabIndex = 0
        Me.AddTable.Text = "Add"
        Me.AddTable.UseVisualStyleBackColor = True
        '
        'RemoveTable
        '
        Me.RemoveTable.Location = New System.Drawing.Point(498, 100)
        Me.RemoveTable.Name = "RemoveTable"
        Me.RemoveTable.Size = New System.Drawing.Size(75, 23)
        Me.RemoveTable.TabIndex = 1
        Me.RemoveTable.Text = "Remove"
        Me.RemoveTable.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(498, 154)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButtSP
        '
        Me.BackButtSP.Location = New System.Drawing.Point(498, 204)
        Me.BackButtSP.Name = "BackButtSP"
        Me.BackButtSP.Size = New System.Drawing.Size(75, 23)
        Me.BackButtSP.TabIndex = 3
        Me.BackButtSP.Text = "back"
        Me.BackButtSP.UseVisualStyleBackColor = True
        '
        'SeatingPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 345)
        Me.Controls.Add(Me.BackButtSP)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.RemoveTable)
        Me.Controls.Add(Me.AddTable)
        Me.Name = "SeatingPlan"
        Me.Text = "SeatingPlan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddTable As System.Windows.Forms.Button
    Friend WithEvents RemoveTable As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackButtSP As System.Windows.Forms.Button
End Class
