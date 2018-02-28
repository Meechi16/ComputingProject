Imports System.Data.OleDb
Public Class Subjectlist
    Dim Utils As Utils
    Dim SDA As New OleDbDataAdapter
    Dim DbDataSet As New DataTable
    Dim BSource As New BindingSource
    Dim form1 As Form1


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles LoadTable.Click
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data source="
        Dim datafile = "login form.accdb"
        Dim connectstring = provider & datafile ' telling the program wich file to look in
        Dim myconnection = New OleDbConnection
        myconnection.ConnectionString = connectstring ' establishing the connection string 
        myconnection.Open() ' open connection
        Dim PickTheRightStudents1 As String = "SELECT * FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = 'Eng12'"
        Dim PickTheRightStudents2 As String = "SELECT Firstname, LastName FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = Mat12 "
        Dim commander = New OleDbCommand(PickTheRightStudents1, myconnection)
        SDA.SelectCommand = commander
        SDA.Fill(DbDataSet)
        BSource.DataSource = DbDataSet
        NamesofStudents.DataSource = BSource
        SDA.Update(DbDataSet)
        myconnection.Close()
    End Sub

    
End Class