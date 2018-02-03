Imports System.Text
Imports System.Security.Cryptography
Public Class Register
        Dim util As New Utils
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim FirstName As String = Firstnametb.Text ' sets the firstname to the text box 
        Dim LastName As String = Lastnametb.Text   ' sets the lastname to the text box 
        Dim Password As String = Passwordtb.Text   ' sets the password tot he password box 
        Dim usernameIsOk As Boolean = False         ' bool checks if usernames meets criteria 
        Dim PasswordIsOk As Boolean = False  ' checks if password meets critera 
        Dim username As String = UserNametb.Text
        Dim RePassword As String = RePasstb.Text

        If FirstName = "" Or LastName = "" Then ' deals with blank spaces
            MsgBox("Please enter the valid boxes ")
            Return
        End If

        Dim queryResult = util.QueryDatabase("Select User From Login Where User = '" & username & "'") ' uses regular expression to create criteria for the password
        Dim caps As New RegularExpressions.Regex("[A-Z]")
        Dim digits As New RegularExpressions.Regex("[0-9]")

        If queryResult.Count > 0 Then
            MsgBox("User already exists") ' the if statements are used as validation in order to check if passowrd or username matches the criteria
            Return

        ElseIf Password.Length < 6 Then
            MsgBox("Password not secure enough")
            Return

        ElseIf Not caps.IsMatch(Password) Then
            MsgBox("Please include a capital letter in your password")
            Return

        ElseIf Not digits.IsMatch(Password) Then
            MsgBox("Please include a digit in your password")
            Return

        ElseIf RePassword = "" Or RePassword <> Password Then
            MsgBox("Please re enter the password correctly")
            Return

        Else : MsgBox("You have logged in sucessfully")
            Me.Close()
        End If

        Dim hashedPassword = util.getHash(Password)  ' if this is all correct then the password is hashed 
        util.AddToLoginTable(username, hashedPassword, FirstName, LastName, Subjectdrop.SelectedItem)


    End Sub

End Class

