Imports MySql.Data.MySqlClient

Public Class Book

    Private id As Integer
    Private name As String
    Private auth As String
    Private price As Single
    Private qty As Integer

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand



    Public Sub Add()
        'calling connection function
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        If String.IsNullOrEmpty(idTextField.Text) Then
            MsgBox(" id is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(nameTextField.Text) Then
            MsgBox("name is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(authorTextField.Text) Then
            MsgBox("author is empty", MsgBoxStyle.Information)

        ElseIf String.IsNullOrEmpty(priceTextField.Text) Then
            MsgBox("price is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(quantityTextFields.Text) Then
            MsgBox("quantity is empty", MsgBoxStyle.Information)
        Else
            'asign variables to the data on the textboxes
            id = idTextField.Text
            name = nameTextField.Text
            auth = authorTextField.Text
            price = priceTextField.Text
            qty = quantityTextFields.Text

            'insertingb record into newbook table in the databse
            Try
                Dim sql As String = "INSERT INTO  `newbook`(`ID`, `name`, `author`, `price`, `qty`) VALUES ('" & id & "','" & name & "','" & auth & "','" & price & "','" & qty & "')"
                conn.Open()
                COMMAND = New MySqlCommand(sql, conn)
                READER = COMMAND.ExecuteReader
                MsgBox("Book Record Successfully saved", MsgBoxStyle.Information)

                idTextField.Text = ""
                nameTextField.Text = ""
                authorTextField.Text = ""
                priceTextField.Text = ""
                quantityTextField.Text = ""

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()

            End Try

        End If

    End Sub

    Public Sub UpdatePrice(ByVal newPrice As Single)
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader


        newPrice = priceTextField.Text
        id = idTextField.Text

        Try
            Dim sql As String = "UPDATE `newbook` SET `price`='" & newPrice & "' WHERE ID = '" & id & "'"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Book Price Succesfully Updated ", MsgBoxStyle.Information)

            'reseting textboxes to be empty after the successfull update
            idTextField.Text = ""
            nameTextField.Text = ""
            authorTextField.Text = ""
            priceTextField.Text = ""
            quantityTextField.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub Search()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()

        Try
            Dim sql As String = "SELECT * from newbook WHERE CONCAT (ID, name, author, price, qty)  like '%" & searchTextField.Text & "%'"
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
    Public Sub Update()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        id = idTextField.Text
        name = nameTextField.Text
        auth = authorTextField.Text
        price = priceTextField.Text
        qty = quantityTextField.Text

        Try
            Dim sql As String = "UPDATE `newbook` SET `ID`='" & id & "',`name`='" & name & "',`author`='" & auth & "',`price`='" & price & "',`qty`='" & qty & "' WHERE ID = '" & id & "'"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Book Record Succesfully Updated ", MsgBoxStyle.Information)

            idTextField.Text = ""
            nameTextField.Text = ""
            authorTextField.Text = ""
            priceTextField.Text = ""
            quantityTextField.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox("your record is violating the databse rules ", MsgBoxStyle.Information)
            conn.Close()

        End Try
    End Sub
    Public Sub Display()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()

        Try
            Dim sql As String = "SELECT * FROM `newbook`"
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

    Private Sub btnUpdatePrice_Click(sender As Object, e As EventArgs)
        price = priceTextField.Text
        UpdatePrice(price)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Update()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idTextField.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityTextField.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles priceTextField.KeyPress
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
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles authorTextField.KeyPress

        If Not (Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
            MsgBox("ONLY NUMBERS OR LETTERS ARE ALLOWED IN THIS FIELD ", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub btnDisplay_Click_1(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Display()
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub idTextField_TextChanged(sender As Object, e As EventArgs) Handles idTextField.TextChanged

    End Sub
End Class