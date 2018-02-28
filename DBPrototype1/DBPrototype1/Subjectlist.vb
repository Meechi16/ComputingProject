Imports System.Data.OleDb
Public Class Subjectlist
    Dim Utils As Utils
    Dim SDA As New OleDbDataAdapter
    Dim DbDataSet As New DataTable
    Dim BSource As New BindingSource

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data source="
        Dim datafile = "login form.accdb"
        Dim connectstring = provider & datafile ' telling the program wich file to look in
        Dim myconnection = New OleDbConnection
        myconnection.ConnectionString = connectstring ' establishing the connection string 
        myconnection.Open() ' open connection
        Dim query As String = "SELECT * FROM Classes"
        Dim commander = New OleDbCommand(query, myconnection)
        SDA.SelectCommand = commander
        SDA.Fill(DbDataSet)
        BSource.DataSource = DbDataSet
        NamesofStudents.DataSource = BSource
        SDA.Update(DbDataSet)
    End Sub
End Class