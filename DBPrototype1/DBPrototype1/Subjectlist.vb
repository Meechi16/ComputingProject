Imports System.Data.OleDb
Public Class Subjectlist
    Dim Utils As Utils
    Dim SDA As New OleDbDataAdapter

    Dim Username As String
    Dim GivenName As String
    Dim TeacherID As String

    Public Sub PassUserName(ByVal u As String)
        Username = u
    End Sub


    Private Sub Subjectlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Utils = New Utils
        Dim result = Utils.QueryDatabase("SELECT TeacherID FROM Login WHERE User='" & Username & "'")
        result(0).TryGetValue("TeacherID", TeacherID)

        Dim getClassQuery As String = "SELECT ClassID FROM Classes WHERE TeacherID = '" & TeacherID & "'"
        Dim result2 = Utils.QueryDatabase(getClassQuery)

        For i = 0 To result2.Count - 1
            Dim ClassID As String = ""
            result2(i).TryGetValue("ClassID", ClassID)
            Dim PickTheRightStudents1 As String = "Select * FROM StudentInfo " &
                "WHERE StudentID IN (SELECT StudentID FROM TakenClass WHERE TakenClass.ClassID = '" & ClassID & "')"


            Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data source="
            Dim datafile = "login form.accdb"
            Dim connectstring = provider & datafile ' telling the pro  gram wich file to look in
            Dim myconnection = New OleDbConnection
            myconnection.ConnectionString = connectstring ' establishing the connection string 
            myconnection.Open() ' open connection

            Dim commander = New OleDbCommand(PickTheRightStudents1, myconnection)
            SDA.SelectCommand = commander
            Dim DbDataSet As New DataTable
            SDA.Fill(DbDataSet)
            Dim BSource As New BindingSource
            BSource.DataSource = DbDataSet
            Dim NamesofStudents As New DataGridView
            NamesofStudents.DataSource = BSource
            SDA.Update(DbDataSet)
            Dim tabpage As New TabPage
            tabpage.Text = ClassID
            NamesofStudents.Parent = tabpage
            Me.ClassTables.TabPages.Add(tabpage)

            tabpage.Width = tabpage.Parent.Width
            tabpage.Height = tabpage.Parent.Height
            NamesofStudents.Width = NamesofStudents.Parent.Width
            NamesofStudents.Height = NamesofStudents.Parent.Height

            myconnection.Close()
        Next

    End Sub

    Private Sub SeatingButt_Click(sender As System.Object, e As System.EventArgs) Handles SeatingButt.Click
        Dim ClassID As String = Me.ClassTables.SelectedTab.Text
        SeatingPlan.SetClassID(ClassID)
        SeatingPlan.Show()
    End Sub

End Class