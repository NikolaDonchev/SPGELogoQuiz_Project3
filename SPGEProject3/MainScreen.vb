Public Class MainScreen
    Public ProjectUsersTA As New LogoQuizDataSetTableAdapters.UsersTableAdapter
    Public ProjectLevelsTA As New LogoQuizDataSetTableAdapters.LogosTableAdapter
    Public ProjectDataTA As New LogoQuizDataSetTableAdapters.AnsweredLogosTableAdapter
    Public GetLogoURL As String
    Public GetLogoName As String
    Public UserScore As Integer
    Public Sub LevelSelect(ByVal LogoURL As Object)
        For Each row In ProjectLevelsTA.GetLevelData(LogoURL)
            Level.PictureBox1.Image = Image.FromFile(row.url)
            GetLogoURL = row.url
            GetLogoName = row.logo
            Level.Label2.Text = "Ако познаете това лого ще получите " & row.points & " точки !"
            If Level.Visible = True Then
                Level.Button2.Enabled = True
                Level.Button2.Text = "Готово"
            End If
            For Each rowUser In ProjectDataTA.CheckIfUsersAnsweredLogo(Login.TextBox1.Text, GetLogoName)
                Level.Button2.Enabled = False
                Level.Button2.Text = "Вече сте отговорил/а"
            Next
        Next
        
    End Sub
    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Здравей, " & Login.TextBox1.Text
        For Each user In ProjectUsersTA.UsersSorting
            ListBox1.Items.Add(user.ID & ". " & user.username & " - " & user.score & " точки" & vbCrLf)
        Next
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        Login.Show()
        Login.Label1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Level.Label1.Text = "Level 1"
        LevelSelect("VW")
        Level.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Level.Label1.Text = "Level 2"
        LevelSelect("SPGE")
        Level.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Level.Label1.Text = "Level 3"
        LevelSelect("The CW")
        Level.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Level.Label1.Text = "Level 4"
        LevelSelect("BGKino")
        Level.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Level.Label1.Text = "Level 5"
        LevelSelect("Coca Cola")
        Level.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Level.Label1.Text = "Level 6"
        LevelSelect("Ariana")
        Level.Show()
    End Sub
End Class