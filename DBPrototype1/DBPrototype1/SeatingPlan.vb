
Imports System.Drawing
Imports System.Xml
Imports System.IO

Public Class SeatingPlan
    Dim G As Graphics
    Dim r As Rectangle
    Dim BBG As Graphics
    Dim BB As Bitmap
    Dim isRunning As Boolean = True
    Dim tables As New List(Of Table)
    Dim lastTableClickedOn As Table
    Dim Utils As New Utils
    Dim TeacherID As String
    Dim ClassID As String

    Public Sub SetClassID(ByVal cid As String)
        ClassID = cid
    End Sub

    Private Sub Seat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If File.Exists(ClassID & ".xml") Then
            Dim serializer As New Xml.Serialization.XmlSerializer(tables.GetType)
            Dim file As New FileStream(ClassID & ".xml", FileMode.Open)
            tables = serializer.Deserialize(file)
            file.Close()
        Else
            setSeats()
        End If

        lastTableClickedOn = tables(0)
        G = Me.CreateGraphics
        BB = New Bitmap(480, 480) 'sets the pixels for the shape 
        gameloop()

    End Sub

    Private Sub setSeats()
        Dim utils As Utils = New Utils

        Dim results_dictionary = utils.QueryDatabase("SELECT Firstname, LastName FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = '" & ClassID & "'")
        Dim count As Integer = 0
        For y = 0 To 4
            For x = 0 To 3
                If count < results_dictionary.Count Then
                    tables.Add(New Table(results_dictionary(count).Item("Firstname"), x * 120, y * 60)) ' spreads the squares out so they dont overlap

                    count += 1

                Else
                    tables.Add(New Table("", x * 120, y * 60))
                End If
            Next
        Next
    End Sub

    Private Sub gameloop()
        Do While isRunning = True ' loops throught the board 
            Application.DoEvents()
            If isRunning Then
                drawgraphics()
            End If
        Loop
    End Sub
    Private Sub drawgraphics() ' draws grid
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, 0, 0, 480, 480)
        G.Clear(Color.Blue) ' sets sections of the for that dont have grid on it to blue 
        G = Graphics.FromImage(BB) ' makes the things we have drawn equal to the grid 

        r = New Rectangle(0, 0, 480, 480) ' makes each square size 32 by 32 pixles 
        G.FillRectangle(Brushes.Bisque, r) ' draws it to the form 

        For Each Table As Table In tables
            Dim rectangle As Rectangle ' draw the shape 
            rectangle = New Rectangle(Table.getCoord.X, Table.getCoord.Y, Table.getWidth(), Table.getHeight()) ' sets properties of this shape 
            G.FillRectangle(Brushes.Black, rectangle)
            G.DrawString(Table.getName(), SystemFonts.DefaultFont, Brushes.White, Table.getCoord)
        Next

    End Sub


    Private Function isClickedOn(ByRef table As Table) As Boolean
        Dim reletiveMousePos = Me.PointToClient(Control.MousePosition)
        Dim mouseX = reletiveMousePos.X
        Dim mouseY = reletiveMousePos.Y

        ' Checks whether mouse is within boundaries of shape
        Return mouseX >= table.getCoord.X And mouseX <= table.getCoord.X + table.getWidth() And
            mouseY >= table.getCoord.Y And mouseY <= table.getCoord.Y + table.getHeight()
    End Function

    Sub picturemousemove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove ' moves the picture

        ' stops a table that is earlier in the arry being clicked on form taking over in the event that a table that have been overlapped, 
        If MouseButtons = Windows.Forms.MouseButtons.Left And isClickedOn(lastTableClickedOn) Then ' looks whether the mouse button is clicked on and looks at if its on the last table thats been clicked on 
            putTableOnMouse(lastTableClickedOn) ' sets position of the table to mouse position 
            Exit Sub
        End If

        For Each Table As Table In tables

            If MouseButtons = Windows.Forms.MouseButtons.Left And isClickedOn(Table) Then
                putTableOnMouse(Table)
                lastTableClickedOn = Table
                Exit For ' that stops multiple tables sticking ot mouse pointer 
            End If

        Next
    End Sub

    Sub putTableOnMouse(ByRef table As Table)
        Dim reletiveMousePos = Me.PointToClient(Control.MousePosition)
        reletiveMousePos.X -= table.getWidth / 2
        reletiveMousePos.Y -= table.getHeight / 2
        table.setCoord(reletiveMousePos)
    End Sub


    Private Sub RemoveTable_Click(sender As System.Object, e As System.EventArgs) Handles RemoveTable.MouseClick
        tables.Remove(lastTableClickedOn)
    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        Dim serializer As New Xml.Serialization.XmlSerializer(tables.GetType)
        Dim filename = ClassID & ".xml"
        Dim file As New FileStream(filename, FileMode.OpenOrCreate)
        serializer.Serialize(file, tables)
        file.Close()
    End Sub

    Private Sub AddTable_Click(sender As System.Object, e As System.EventArgs) Handles AddTable.MouseClick
        tables.Add(New Table("", 0, 0))
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BackButtSP.Click
        Subjectlist.Show()
        Me.Close()
    End Sub

    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        isRunning = False
        'If MessageBox.Show("Are you sur to close this applicati?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        'Else
        '    e.Cancel = True
        'End If
    End Sub
End Class


