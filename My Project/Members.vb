Imports MySql.Data.MySqlClient
Imports Mysqlx.Datatypes
Imports Mysqlx.XDevAPI.Relational

Public Class Members
    Private id As Integer
    Private name As String
    Private location As String
    Private phn As Long
    Private beg_date As Date
    Private end_date As Date
    Private valid As String

    Private pass As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Public Sub AddMem()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        If String.IsNullOrEmpty(idTextField.Text) Then
            MsgBox(" id is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(nameTextField.Text) Then
            MsgBox("name is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(phoneTextField.Text) Then
            MsgBox("phone is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(locationTextField.Text) Then
            MsgBox("location is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(validTextField.Text) Then
            MsgBox("valididty is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(passwordTextField.Text) Then
            MsgBox("Password is empty", MsgBoxStyle.Information)
        End If

        id = idTextField.Text
        name = nameTextField.Text
        location = locationTextField.Text
        phn = phoneTextField.Text
        beg_date = startDate.Text
        end_date = endDate.Text
        valid = validTextField.Text
        pass = passwordTextField.Text

        Try
            Dim sql As String = "INSERT INTO `members`(`mem_id`, `name`, `location`, `phone`, `beg_date`, `end_date`, `valid`, `password`)
            VALUES ('" & id & "','" & name & "','" & location & "','" & phn & "','" & beg_date & "','" & end_date & "','" & valid & "','" & pass & "')"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Member record Successfully saved", MsgBoxStyle.Information)

            idTextField.Text = ""
            nameTextField.Text = ""
            locationTextField.Text = ""
            phoneTextField.Text = ""
            startDate.Text = ""
            endDate.Text = ""
            validTextField.Text = ""


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub Refresh()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()

        Try
            Dim sql As String = "SELECT `mem_id`, `name`, `location`, `phone`,`valid` FROM `members`"
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
    Public Sub SearchMem()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()


        Try
            Dim sql As String = "SELECT `mem_id`, `name`, `location`, `phone`, `valid` from members WHERE CONCAT (mem_id, name, location, phone,valid)  like '%" & searchTextField.Text & "%'"
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idTextField.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneTextField.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nameTextField.KeyPress

        If Not (Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS OR LETTERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles locationTextField.KeyPress

        If Not (Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS OR LETTERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles validTextField.KeyPress

        If Not (Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS OR LETTERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        AddMem()

    End Sub

    Private Sub searchTextField_TextChanged(sender As Object, e As EventArgs) Handles searchTextField.TextChanged

    End Sub

    Private Sub btnSearchMember_Click(sender As Object, e As EventArgs) Handles btnSearchMember.Click
        SearchMem()
    End Sub

    Private Sub btnRefreshMember_Click(sender As Object, e As EventArgs) Handles btnRefreshMember.Click
        Refresh()
    End Sub
End Class