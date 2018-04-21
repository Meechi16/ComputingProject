
Imports System.IO
Imports System.Data.OleDb ' used for the establishing a connection 
Imports System.Text
Imports System.Security.Cryptography ' used for encryption 

Public Class Utils

    Function QueryDatabase(query As String) As List(Of Dictionary(Of String, String))
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data source="
        Dim datafile = "login form.accdb"
        Dim connectstring = provider & datafile ' telling the program wich file to look in
        Dim myconnection = New OleDbConnection
        myconnection.ConnectionString = connectstring ' establishing the connection string 
        myconnection.Open() ' open connection

        Dim cmd As OleDbCommand = New OleDbCommand(query, myconnection) ' running the sql query against the file its connected to 
        Dim reader As OleDbDataReader = cmd.ExecuteReader

        Dim dictionaryArray As New List(Of Dictionary(Of String, String)) ' stores the data form the database into a dictionary 
        While reader.Read
            Dim dict As New Dictionary(Of String, String)
            Dim vals(reader.FieldCount - 1) As String
            reader.GetValues(vals)
            For i = 0 To vals.Length - 1
                dict.Add(reader.GetName(i), vals(i))
            Next

            dictionaryArray.Add(dict)
        End While

        cmd.Dispose()
        myconnection.Close() ' closing connections when done
        Return dictionaryArray
    End Function

    Sub AddToLoginTable(ParamArray values() As String)
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data source="
        Dim datafile = "login form.accdb"
        Dim connectstring = provider & datafile ' telling the program wich file to look in
        Dim myconnection = New OleDbConnection
        myconnection.ConnectionString = connectstring ' establishing the connection string 
        myconnection.Open() ' open connection

        Dim command = "INSERT INTO Login ([User], [Password], [Firstname], [Surname], [Subject], [TeacherID]) Values (" ' sql inserts the data into each table 
        For Each value In values
            command = command & "'" & value & "', "
        Next
        command = Left(command, command.Length - 2)
        command = command & ");"

        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection) ' running the sql query against the file its connected to 
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myconnection.Close()
    End Sub

    Function getHash(ByVal str As String) As String ' this function encrypts the password 

        Dim hashedString As String = Nothing
        Dim sha512 As SHA512 = SHA512Managed.Create() ' 
        Dim stringAsBytes As Byte() = Encoding.UTF8.GetBytes(str) ' turns the string into bytes 
        Dim stringBuilder As New StringBuilder()
        Dim hash As Byte() = sha512.ComputeHash(stringAsBytes) ' hashes the password 

        For i As Integer = 0 To hash.Length - 1
            stringBuilder = stringBuilder.Append(hash(i).ToString("x2"))
            hashedString = stringBuilder.ToString()
        Next

        Return hashedString ' returns the password to the database 

    End Function
    Function CreateTeacherId() '  creates a random 3 letter string to be used as the teacher id 
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim TeacherId As New StringBuilder
        For i As Integer = 1 To 3
            Dim idx As Integer = r.Next(0, 35)
            TeacherId.Append(s.Substring(idx, 1))
        Next
        Return TeacherId.ToString()
    End Function
End Class