Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim pass As String
    Dim Uname As String

    Dim connectionString As String = "server=127.0.0.1;userid=root;password='';database=book_shop"

    Public Function IsValidLogin(username As String, password As String) As Boolean
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim sql As String = "SELECT * FROM members WHERE name = @name AND password = @password"
        Dim command As New MySqlCommand(sql, connection)

        command.Parameters.AddWithValue("@name", username)
        command.Parameters.AddWithValue("@password", password)

        Dim reader As MySqlDataReader = command.ExecuteReader()
        Dim hasRows As Boolean = reader.HasRows

        reader.Close()
        command.Dispose()
        connection.Close()

        Return hasRows
    End Function
    Public Sub LogIn()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = usernameTextField.Text
        Dim password As String = passwordTextField.Text


        If IsValidLogin(username, password) Then
            MessageBox.Show("Login successful!", "Success")
            Me.Hide()
            Dim mainForm As New Menus()
            mainForm.Show()
        Else
            MessageBox.Show("Invalid username or password!", "Error")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Members.Show()
    End Sub
End Class
