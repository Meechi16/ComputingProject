
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
    Dim tableDragging As Table
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

        'Dim results_dictionary = utils.QueryDatabase("SELECT Firstname, LastName FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = '" & ClassID & "'")

        Dim results_dictionary = OrderByGender()
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
        G.FillRectangle(Brushes.DarkSlateGray, r) ' draws it to the form 

        putTableOnMouse(tableDragging) 'Move the table thats currently being dragged to the mouse

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

        '' stops a table that is earlier in the arry being clicked on form taking over in the event that a table that have been overlapped, 
        'If MouseButtons = Windows.Forms.MouseButtons.Left And isClickedOn(lastTableClickedOn) Then ' looks whether the mouse button is clicked on and looks at if its on the last table thats been clicked on 
        '    putTableOnMouse(lastTableClickedOn) ' sets position of the table to mouse position 
        '    Exit Sub
        'End If

        'For Each Table As Table In tables

        '    If MouseButtons = Windows.Forms.MouseButtons.Left And isClickedOn(Table) Then
        '       putTableOnMouse(Table)
        '        lastTableClickedOn = Table
        '        Exit For ' that stops multiple tables sticking ot mouse pointer 
        '    End If

        'Next
    End Sub

    Sub putTableOnMouse(ByRef table As Table)
        If IsNothing(table) Then
            Return
        End If

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
       
    End Sub

    Private Sub SeatingPlan_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim tableclickedon As Boolean = False
        For Each Table As Table In tables
            If isClickedOn(Table) Then
                tableclickedon = True
                lastTableClickedOn = Table

            End If
        Next
        If Not tableclickedon Then
            Return
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            lastTableClickedOn.rotatetables()
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            tableDragging = lastTableClickedOn
        End If
    End Sub

    Private Sub SeatingPlan_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            tableDragging = Nothing
        End If
    End Sub
    Private Function OrderByGender() As List(Of Dictionary(Of String, String))
        Dim utils As New Utils
        Dim orderM = utils.QueryDatabase("SELECT Firstname FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = '" & ClassID & "' AND Gender = 'M'")
        Dim orderF = utils.QueryDatabase("SELECT Firstname FROM TakenClass INNER JOIN StudentInfo ON TakenClass.StudentID = StudentInfo.StudentID WHERE TakenClass.ClassID = '" & ClassID & "' AND Gender = 'F'")
        Dim gender As New List(Of Dictionary(Of String, String))
        Dim count As Integer = 0
        Dim pointerM As Integer = 0
        Dim pointerF As Integer = 0

        Dim MoreFemales As Boolean = orderF.Count > orderM.Count

        Dim MixCount = 0
        If MoreFemales Then
            MixCount = orderM.Count
        Else
            MixCount = orderF.Count
        End If


        For i = 0 To MixCount * 2 - 1
            If i Mod 2 = 0 Then
                gender.Add(orderF(pointerF))
                pointerF += 1
            Else
                gender.Add(orderM(pointerM))
                pointerM += 1
            End If
        Next

        If MoreFemales Then
            For i = pointerF To orderF.Count - 1
                gender.Add(orderF(i))

            Next
        Else : For i = pointerM To orderM.Count - 1

            Next
        End If

        Return gender
    End Function
    
End Class


