Public Class Form1
    Dim utils As Utils
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        utils.getHash(Password.Text)
        utils.QueryDatabase("Select Username, Password From Login Where User = " & username.Text & "password =" & Password.Text)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Register.Show()

    End Sub
End Class
