Public Class PreeSeatingPlan

    Private Sub OrderByComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles OrderByComboBox.SelectedIndexChanged
        Dim OrderbyWhat As String = OrderByComboBox.SelectedItem
    End Sub

    Private Sub Create_Click(sender As System.Object, e As System.EventArgs) Handles Create.Click
        Dim ClassID As String = Subjectlist.ClassTables.SelectedTab.Text ' uses the tab selected 
        SeatingPlan.SetClassID(ClassID) ' takes the class id from it and searches the names of the students associated with classid 
        SeatingPlan.Show() ' shows the class id 
    End Sub
End Class