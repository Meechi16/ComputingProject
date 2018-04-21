Public Class Form1
    Dim utils As Utils

   
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles RegisterButton.Click
        Register.Show()
        Me.Close()
    End Sub
    Private Sub CancelButtons_Click(sender As System.Object, e As System.EventArgs) Handles CancelButtons.Click
        Me.Close()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        MessageBox.Show("Pressed a key")

        'If Not (e.KeyCode = Keys.Enter) Then
        '    Return
        'End If

        'utils = New Utils()
        'Dim hash = utils.getHash(Password.Text)
        'Dim results = utils.QueryDatabase("Select User From Login Where User = '" & username.Text & "' AND password = '" & hash.ToString & "' ")
        'If results.Count > 0 Then
        '    Subjectlist.PassUserName(username.Text)
        '    Subjectlist.Show()
        'Else
        '    MsgBox("Username or Password incorrect")
        '    username.Clear()
        '    Password.Clear()
        'End If
    End Sub

    Private Sub Password_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Password.KeyDown
        If Not (e.KeyCode = Keys.Enter) Then
            Return
        End If

        utils = New Utils()
        Dim hash = utils.getHash(Password.Text)
        Dim results = utils.QueryDatabase("Select User From Login Where User = '" & username.Text & "' AND password = '" & hash.ToString & "' ")
        If results.Count > 0 Then
            Subjectlist.PassUserName(username.Text)
            Subjectlist.Show()
        Else
            MsgBox("Username or Password incorrect")
            username.Clear()
            Password.Clear()
        End If
    End Sub
End Class
