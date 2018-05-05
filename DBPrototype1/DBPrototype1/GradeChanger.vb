Public Class GradeChanger

    Dim classId As String
    Dim Utils As New Utils

    Public Sub setClassId(ByVal cid As String)
        Me.classId = cid
    End Sub
    Private Sub GradeChanger_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim StudentsInClass = Utils.QueryDatabase("SELECT StudentInfo.StudentID, Firstname, LastName FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = '" & classId & "'")

        For Each Student As Dictionary(Of String, String) In StudentsInClass
            Me.StudentsComboBox.Items.Add(Student.Item("StudentID"))
        Next

    End Sub

    Private Sub Update_Click(sender As System.Object, e As System.EventArgs) Handles Update.Click
        Dim SelctedStudent As String = Me.StudentsComboBox.SelectedItem
        Dim Grade As String = Me.GradeBox.Text
        If SelctedStudent = "" Then
            MessageBox.Show("Please Select a Student")
            Return
        End If

        If Grade = "" Then
            MessageBox.Show("Please Enter a Valid Grade")
            Return
        End If

        Utils.QueryDatabase("UPDATE TakenClass SET Score='" & Grade & "' WHERE StudentID='" & SelctedStudent & "'")

    End Sub
End Class