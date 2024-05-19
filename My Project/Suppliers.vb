Imports MySql.Data.MySqlClient

Public Class Suppliers

    Private id As Integer
    Private name As String
    Private phn As Long
    Private location As String


    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public Sub AddSup()

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        If String.IsNullOrEmpty(idTextField.Text) Then
            MsgBox(" id is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(nameTextField.Text) Then
            MsgBox("name is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(phoneTextField.Text) Then
            MsgBox("phone is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(locationTextField.Text) Then
            MsgBox("location is empty", MsgBoxStyle.Information)
        End If

        id = idTextField.Text
        name = nameTextField.Text
        phn = phoneTextField.Text
        location = locationTextField.Text

        Try
            Dim sql As String = "INSERT INTO `suppliers`(`id`, `name`, `phone`, `location`) VALUES ('" & id & "','" & name & "','" & phn & "','" & location & "')"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Data Successfully saved", MsgBoxStyle.Information)

            idTextField.Text = ""
            nameTextField.Text = ""
            phoneTextField.Text = ""
            locationTextField.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try

    End Sub

    Public Sub RemoveSupplier()


        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        id = idTextField.Text

        Try
            Dim sql As String = "DELETE FROM `suppliers` where id = '" & idTextField.Text & "'"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Record Successfully removed from the database", MsgBoxStyle.Information)

            idTextField.Text = ""
            nameTextField.Text = ""
            phoneTextField.Text = ""
            locationTextField.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub SearchId()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()

        Try
            Dim sql As String = "SELECT * FROM `suppliers` WHERE CONCAT (id, name, phone, location)  like '%" & searchTextField.Text & "%'"

            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)

            table.Load(COMMAND.ExecuteReader)
            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub Display()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()

        Try
            Dim sql As String = "SELECT * FROM `suppliers`"
            conn.Open()
            Command = New MySqlCommand(sql, conn)

            table.Load(Command.ExecuteReader)
            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddSup()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveSupplier()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Display()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchId()
    End Sub
End Class