﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.UpdateButt = New System.Windows.Forms.Button()
        Me.EditButt = New System.Windows.Forms.Button()
        Me.ClassTables = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'SeatingButt
        '
        Me.SeatingButt.Location = New System.Drawing.Point(187, 279)
        Me.SeatingButt.Name = "SeatingButt"
        Me.SeatingButt.Size = New System.Drawing.Size(75, 23)
        Me.SeatingButt.TabIndex = 2
        Me.SeatingButt.Text = "Seating Plan"
        Me.SeatingButt.UseVisualStyleBackColor = True
        '
        'Addbutt
        '
        Me.Addbutt.Location = New System.Drawing.Point(106, 281)
        Me.Addbutt.Name = "Addbutt"
        Me.Addbutt.Size = New System.Drawing.Size(75, 23)
        Me.Addbutt.TabIndex = 3
        Me.Addbutt.Text = "Add"
        Me.Addbutt.UseVisualStyleBackColor = True
        '
        'DeleteButt
        '
        Me.DeleteButt.Location = New System.Drawing.Point(152, 252)
        Me.DeleteButt.Name = "DeleteButt"
        Me.DeleteButt.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButt.TabIndex = 4
        Me.DeleteButt.Text = "Delete"
        Me.DeleteButt.UseVisualStyleBackColor = True
        '
        'UpdateButt
        '
        Me.UpdateButt.Location = New System.Drawing.Point(233, 252)
        Me.UpdateButt.Name = "UpdateButt"
        Me.UpdateButt.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButt.TabIndex = 5
        Me.UpdateButt.Text = "Update"
        Me.UpdateButt.UseVisualStyleBackColor = True
        '
        'EditButt
        '
        Me.EditButt.Location = New System.Drawing.Point(268, 279)
        Me.EditButt.Name = "EditButt"
        Me.EditButt.Size = New System.Drawing.Size(75, 23)
        Me.EditButt.TabIndex = 6
        Me.EditButt.Text = "Edit"
        Me.EditButt.UseVisualStyleBackColor = True
        '
        'ClassTables
        '
        Me.ClassTables.Location = New System.Drawing.Point(29, 12)
        Me.ClassTables.Name = "ClassTables"
        Me.ClassTables.SelectedIndex = 0
        Me.ClassTables.Size = New System.Drawing.Size(411, 216)
        Me.ClassTables.TabIndex = 7
        '
        'Subjectlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 316)
        Me.Controls.Add(Me.ClassTables)
        Me.Controls.Add(Me.EditButt)
        Me.Controls.Add(Me.UpdateButt)
        Me.Controls.Add(Me.DeleteButt)
        Me.Controls.Add(Me.Addbutt)
        Me.Controls.Add(Me.SeatingButt)
        Me.Name = "Subjectlist"
        Me.Text = "Subjectlist"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SeatingButt As System.Windows.Forms.Button
    Friend WithEvents Addbutt As System.Windows.Forms.Button
    Friend WithEvents DeleteButt As System.Windows.Forms.Button
    Friend WithEvents UpdateButt As System.Windows.Forms.Button
    Friend WithEvents EditButt As System.Windows.Forms.Button
    Friend WithEvents ClassTables As System.Windows.Forms.TabControl
End Class
