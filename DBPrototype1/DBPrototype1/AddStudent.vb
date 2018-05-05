Imports System.Text
Public Class AddStudent
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles EnterStudentButton.Click
        Dim utils As New Utils
        Dim FirstName As String = FirstNameTxtBox.Text ' sets the firstname to the text box text
        Dim LastName As String = LastNameTxtBox.Text ' sets the lastname to the text box text
        Dim PCI As String = PCITxtBox.Text ' sets the parent contact info to the PCI text box  text 
        Dim Gender As String = GenderTxtBox.Text.ToUpper ' Sets the gender to the gender text box text 
        Dim Age As String = AgeTxtBox.Text ' sets the age to the age text box text
        Dim StudentiD As String = ""
        Dim Regex As New RegularExpressions.Regex("[a-zA-Z]") ' criteria of only strings characters from a to z 
        Dim regex2 As New RegularExpressions.Regex("[01234567]") ' only string characters from 0 to 9 


        If FirstName = "" Or LastName = "" Or PCI = "" Or Gender = "" Or Age = "" Then
            MsgBox("Message box empty") ' makes sure that the spaces arent left blank 
            Return
        ElseIf Not Regex.IsMatch(FirstName) Then ' uses rgex to see if the firstname matches the criteria
            MsgBox("incorrect name")
            Return
        ElseIf Not Regex.IsMatch(LastName) Then ' checks to see if the last name first the criteria 
            MsgBox("incorrect name")
            Return
        ElseIf Not Gender = "M" And Not Gender = "F" Then ' checks to see if gender fits the criteria 
            MsgBox(" enter a Gender between F and M ")
            Return
        ElseIf Not regex2.IsMatch(PCI) Then ' checks to see if PCI fits the criteria 
            MsgBox("please enter a vaild contact number")
            Return
        ElseIf Not Age = "17" Or Age = "18" Or Age = "16" Then ' checks to see if the age fits the criteria
            MsgBox("Student  doesnt fit the age boundaries of the six form")
        Else
            MsgBox("student was added successfully") ' lets the user know that they have added a student succesfully 
        End If
        Dim studentinteger = utils.CreateStudentinteger ' calls the create student integer using the function in the utils class
        StudentiD = FirstName.ElementAt(0) & LastName.ElementAt(0) & studentinteger ' creates the student id using a foreign key of the fist name last name and random integer 
        Dim search = utils.QueryDatabase("Select StudentID from StudentInfo where StudentID = '" & StudentiD & "'") ' searches if the id already exists
        While search.Count > 0 ' searches the database
            Dim studentNumber As Integer = CInt(studentinteger) ' turns the string into an integer  
            studentNumber += 1 ' add 1 
            studentinteger = studentNumber.ToString() ' turns it back to a string 
            StudentiD = FirstName.ElementAt(0) & LastName.ElementAt(0) & studentinteger ' adds the new integer to the end of the the student info
            search = utils.QueryDatabase("Select StudentID from StudentInfo where StudentID = '" & StudentiD & "'") ' checks he database again 
        End While
        utils.AddToLoginTableForSudents(StudentiD, FirstName, LastName, Age, Gender, PCI) ' adds it to the database
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
