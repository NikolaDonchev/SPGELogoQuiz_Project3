Public Class Login
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If (TextBox1.Text = "Име") Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Грешно име или парола !"
        For Each n In MainScreen.ProjectUsersTA.CheckUser(TextBox1.Text, TextBox2.Text)
            If (TextBox1.Text = n.username And TextBox2.Text = n.password) Then
                MainScreen.Show()
                Me.Hide()
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Приложението е направено от Никола Дончев и Радослав Динев - 2013 година", , "За приложението")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register.Show()
    End Sub
End Class
