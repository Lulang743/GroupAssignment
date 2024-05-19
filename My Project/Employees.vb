Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Public Class Employees

    Private id As Integer
    Private name As String
    Private location As String
    Private salary As Long
    Private mgr_status As String

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public Sub AddEmp()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        If String.IsNullOrEmpty(idTextField.Text) Then
            MsgBox(" id is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(nameTextField.Text) Then
            MsgBox("name is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(locationTextField.Text) Then
            MsgBox("location is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(salaryTextField.Text) Then
            MsgBox("salary is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(mrgStatusTextField.Text) Then
            MsgBox("mrg status is empty", MsgBoxStyle.Information)
        End If

        id = idTextField.Text
        name = nameTextField.Text
        location = locationTextField.Text
        salary = salaryTextField.Text
        mgr_status = mrgStatusTextField.Text

        Try
            Dim sql As String = "INSERT INTO `employees`(`emp_id`, `emp_name`, `location`, `salary`, `mrg_status`) 
            VALUES ('" & id & "','" & name & "','" & location & "','" & salary & "','" & mgr_status & "')"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Employee record Successfully saved", MsgBoxStyle.Information)

            idTextField.Text = ""
            nameTextField.Text = ""
            locationTextField.Text = ""
            salaryTextField.Text = ""
            mrgStatusTextField.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub SearchEmp()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()

        Try
            Dim sql As String = "SELECT `emp_id`, `emp_name`, `location`, `salary`, `mrg_status` FROM employees WHERE CONCAT (emp_id, emp_name, location, salary, mrg_status)  like '%" & searchTextField.Text & "%'"
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
    Public Sub AssignMgrStat()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        id = idTextField.Text

        mgr_status = mrgStatusTextField.Text

        Try
            Dim sql As String = "UPDATE `employees` SET `mrg_status`='" & mgr_status & "' WHERE emp_id = '" & id & ""
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Employee mgr status has been Successfully assigned", MsgBoxStyle.Information)

            idTextField.Text = ""
            nameTextField.Text = ""
            locationTextField.Text = ""
            salaryTextField.Text = ""
            mrgStatusTextField.Text = ""

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
            Dim sql As String = "SELECT * FROM `employees`"
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salaryTextField.KeyPress
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

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        AddEmp()

    End Sub

    Private Sub btnAssignMngStatus_Click(sender As Object, e As EventArgs) Handles btnAssignMngStatus.Click
        AssignMgrStat()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Display()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchEmp()
    End Sub
End Class