﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherSets
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
        Me.ListofStudents = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListofStudents
        '
        Me.ListofStudents.FormattingEnabled = True
        Me.ListofStudents.Location = New System.Drawing.Point(62, 24)
        Me.ListofStudents.Name = "ListofStudents"
        Me.ListofStudents.Size = New System.Drawing.Size(142, 225)
        Me.ListofStudents.TabIndex = 0
        '
        'TeacherSets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 261)
        Me.Controls.Add(Me.ListofStudents)
        Me.Name = "TeacherSets"
        Me.Text = "TeacherSets"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListofStudents As System.Windows.Forms.ListBox
End Class
