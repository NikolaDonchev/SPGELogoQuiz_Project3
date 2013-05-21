Public Class Register
    Dim Project3InRegisterTA As New LogoQuizDataSetTableAdapters.UsersTableAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''For Each row In Project3InRegisterTA.GetData
        ''If (TextBox1.Text = row.username) Then
        ''MsgBox("Потребителското име вече е заето", , "Грешка")
        ''Else
        ''MsgBox("Успешна регистрация")
        ''End If
        ''Next
        Dim username, password, email As String
        username = TextBox1.Text
        password = TextBox2.Text
        email = TextBox3.Text
        Project3InRegisterTA.Insert(username, password, email, "0")
        MsgBox("Регистрацията е успешна", , "Честито")
        Me.Hide()
        Login.Show()
    End Sub
End Class