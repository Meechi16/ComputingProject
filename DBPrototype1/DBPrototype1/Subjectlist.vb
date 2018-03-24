Imports System.Data.OleDb
Public Class Subjectlist
    Dim Utils As Utils
    Dim SDA As New OleDbDataAdapter
    Dim DbDataSet As New DataTable
    Dim BSource As New BindingSource
    Dim Username As String
    Dim GivenName As String
    Dim TeacherID As String

    Public Sub PassUserName(ByVal u As String)
        Username = u
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles LoadTable.Click
        'Dim PickTheRightStudents1 As String = "SELECT * FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = 'Eng12'"
        Dim PickTheRightStudents2 As String = "SELECT Firstname, LastName FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = Mat12 "
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data source="
        Dim datafile = "login form.accdb"
        Dim connectstring = provider & datafile ' telling the program wich file to look in
        Dim myconnection = New OleDbConnection
        myconnection.ConnectionString = connectstring ' establishing the connection string 
        myconnection.Open() ' open connection

        Dim getClassQuery As String = "SELECT ClassID FROM Classes WHERE Teacher = '" & TeacherID & "'"
        Dim result = Utils.QueryDatabase(getClassQuery)
        Dim ClassID As String = ""
        result(0).TryGetValue("ClassID", ClassID)
        Dim PickTheRightStudents1 As String = "SELECT * FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = '" & ClassID & "'"

        Dim commander = New OleDbCommand(PickTheRightStudents1, myconnection)
        SDA.SelectCommand = commander
        SDA.Fill(DbDataSet)
        BSource.DataSource = DbDataSet
        NamesofStudents.DataSource = BSource
        SDA.Update(DbDataSet)


        myconnection.Close()
    End Sub


    Private Sub Subjectlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Utils = New Utils
        Dim result = Utils.QueryDatabase("SELECT TeacherID FROM Login WHERE User='" & Username & "'")
        result(0).TryGetValue("TeacherID", TeacherID)
    End Sub

    Private Sub SeatingButt_Click(sender As System.Object, e As System.EventArgs) Handles SeatingButt.Click
        SeatingPlan.SetTeacherID(TeacherID)
        SeatingPlan.Show()
    End Sub
End Class