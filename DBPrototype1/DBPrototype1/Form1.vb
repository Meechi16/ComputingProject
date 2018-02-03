Public Class Form1
    Dim utils As Utils
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        utils = New Utils()
        Dim hash = utils.getHash(Password.Text)
        Dim results = utils.QueryDatabase("Select User From Login Where User = '" & username.Text & "' AND password = '" & hash.ToString & "' ")
        If results.Count > 0 Then
            SeatingPlan.Show()
        Else
            MsgBox("Username or Password incorrect")
            username.Clear()
            Password.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Register.Show()

    End Sub
End Class
