Public Class Level
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If (TextBox1.Text = "Опитайте се да познаете") Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usersScore As Integer
        Dim username As String
        For Each w In MainScreen.ProjectUsersTA.GetUsersScore(Login.TextBox1.Text)
            usersScore = w.score
            username = w.username
        Next
        For Each red In MainScreen.ProjectLevelsTA.GetLogoURLfromDB(MainScreen.GetLogoURL)
            If (TextBox1.Text = red.logo) Then
                MsgBox("Правилно", , "Точки")
                MainScreen.ProjectDataTA.Insert(Login.TextBox1.Text, red.logo)
                MainScreen.ProjectUsersTA.UpdateUsersScore(usersScore + red.points, Login.TextBox1.Text)
                TextBox1.Text = ""
                MainScreen.ListBox1.Items.Clear()
                For Each user In MainScreen.ProjectUsersTA.UsersSorting
                    MainScreen.ListBox1.Items.Add(user.ID & ". " & user.username & " - " & user.score & vbCrLf)
                Next
                Me.Close()
            Else
                MsgBox("Пич, не те бива...", , "Опааа")
            End If
        Next
    End Sub
End Class