Imports System.Data.OleDb
Public Class Subjectlist
    Dim Utils As Utils ' allows this class to be used in this class 
    Dim SDA As New OleDbDataAdapter ' helps fill the database 
    Dim Username As String ' declares the username 
    Dim GivenName As String ' declares the given name 
    Dim TeacherID As String ' declares the teacher id 

    Public Sub PassUserName(ByVal u As String)
        Username = u ' passes the user name from the login form 
    End Sub


    Private Sub Subjectlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Utils = New Utils
        Dim result = Utils.QueryDatabase("SELECT TeacherID FROM Login WHERE User='" & Username & "'") ' searches the teacherID of each teacher 
        result(0).TryGetValue("TeacherID", TeacherID)

        Dim getClassQuery As String = "SELECT ClassID FROM Classes WHERE TeacherID = '" & TeacherID & "'" ' searches the related teacherId to each name 
        Dim result2 = Utils.QueryDatabase(getClassQuery)

        For i = 0 To result2.Count - 1 ' loops a new tab for each new class id related to a teacherid 
            Dim ClassID As String = ""
            result2(i).TryGetValue("ClassID", ClassID) ' stores the result of the class id 
            Dim PickTheRightStudents1 As String = "Select * FROM StudentInfo " &
                "WHERE StudentID IN (SELECT StudentID FROM TakenClass WHERE TakenClass.ClassID = '" & ClassID & "')" ' selects all student with the classid's related to the classes 


            Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" ' the file path 
            Dim datafile = "login form.accdb"
            Dim connectstring = provider & datafile ' telling the program wich file to look in
            Dim myconnection = New OleDbConnection
            myconnection.ConnectionString = connectstring ' establishing the connection string 
            myconnection.Open() ' open connection

            Dim commander = New OleDbCommand(PickTheRightStudents1, myconnection) ' runs the query against the database 
            SDA.SelectCommand = commander
            Dim DbDataSet As New DataTable
            SDA.Fill(DbDataSet) ' takes the dataset and fills it into the table 
            Dim BSource As New BindingSource
            BSource.DataSource = DbDataSet
            Dim NamesofStudents As New DataGridView ' declares the datagridview 
            NamesofStudents.DataSource = BSource 'binds the data to the table 
            SDA.Update(DbDataSet)
            Dim tabpage As New TabPage ' decleres he tab names 
            tabpage.Text = ClassID ' writes the classid to the class names 
            NamesofStudents.Parent = tabpage
            Me.ClassTables.TabPages.Add(tabpage)

            tabpage.Width = tabpage.Parent.Width
            tabpage.Height = tabpage.Parent.Height
            NamesofStudents.Width = NamesofStudents.Parent.Width
            NamesofStudents.Height = NamesofStudents.Parent.Height ' this section of code equates the length of the table to the size of thr form 

            myconnection.Close() ' closes the connection 
        Next

    End Sub

    Private Sub SeatingButt_Click(sender As System.Object, e As System.EventArgs) Handles SeatingButt.Click
        PreeSeatingPlan.Show()
    End Sub

    Private Sub Addbutt_Click(sender As System.Object, e As System.EventArgs) Handles Addbutt.Click
        AddStudent.Show()
    End Sub

    Private Sub ChangeGrades_Click(sender As System.Object, e As System.EventArgs) Handles ChangeGrades.Click
        GradeChanger.setClassId(Me.ClassTables.SelectedTab.Text)
        GradeChanger.Show()
    End Sub
End Class