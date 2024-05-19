Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational
Imports System.Data
Imports System.Data.OleDb

Public Class Sales
    Private invoice_id As Integer
    Private member_id As Integer
    Private book_id As Integer
    Private qty As Integer
    Private amount As Single
    Private date_of_sale As Date

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Public Sub Add()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        If String.IsNullOrEmpty(invoiceIdTextField.Text) Then
            MsgBox("invoice id is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(memberIdTextField.Text) Then
            MsgBox("member id is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(bookIdTextField.Text) Then
            MsgBox("book id is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(quantityTextField.Text) Then
            MsgBox("Quantity is empty", MsgBoxStyle.Information)
        End If

        invoice_id = invoiceIdTextField.Text
        member_id = memberIdTextField.Text
        book_id = bookIdTextField.Text
        qty = quantityTextField.Text
        amount = amountTextField.Text
        date_of_sale = saleDate.Text

        Try
            Dim sql As String = "INSERT INTO `sales`(`invoice_id`, `mem_id`, `book_id`, `qty`, `amount`, `date_of_sale`) 
            VALUES ('" & invoice_id & "','" & member_id & "','" & book_id & "','" & qty & "','" & amount & "','" & saleDate.Text & "')"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Sale record Successfully saved", MsgBoxStyle.Information)

            invoiceIdTextField.Text = ""
            memberIdTextField.Text = ""
            bookIdTextField.Text = ""
            quantityTextField.Text = ""
            amountTextField.Text = ""
            saleDate.Text = ""

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
            Dim sql As String = "SELECT `invoice_id`, `mem_id`, `book_id`, `qty`, `amount` FROM `sales`"
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
    Public Sub FindTotalSales()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        Dim table As New DataTable()


        Try
            Dim sql As String = "SELECT `amount` FROM `sales`"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            'READER = COMMAND.ExecuteReader
            table.Load(COMMAND.ExecuteReader)

            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Dim colSum As Decimal

            For Each R As DataGridViewRow In DataGridView1.Rows
                colSum += R.Cells(0).Value

            Next
            totalSales.Text = colSum
            'DataGridView1.DataSource = table


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub FindTotalSales(ByVal sale_date As Date)
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        Dim table As New DataTable()
        sale_date = saleDate.Text



        Try
            Dim sql As String = "SELECT `amount` FROM `sales` WHERE date_of_sale = '" & saleDate.Text & "'"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            'READER = COMMAND.ExecuteReader
            table.Load(COMMAND.ExecuteReader)

            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Dim colSum As Decimal

            For Each R As DataGridViewRow In DataGridView1.Rows
                colSum += R.Cells(0).Value

            Next
            totalSales.Text = colSum
            'DataGridView1.DataSource = table


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub FindTotalSales(ByVal start_date As Date, ByVal end_date As Date)
        'Code for finding the total sales in a given date period
    End Sub
    Public Sub UpdateSal()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        If String.IsNullOrEmpty(invoiceIdTextField.Text) Then
            MsgBox("invoice id is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(memberIdTextField.Text) Then
            MsgBox("member id is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(bookIdTextField.Text) Then
            MsgBox("book id is empty", MsgBoxStyle.Information)
        End If
        If String.IsNullOrEmpty(quantityTextField.Text) Then
            MsgBox("Quantity is empty", MsgBoxStyle.Information)
        End If

        invoice_id = invoiceIdTextField.Text
        member_id = memberIdTextField.Text
        book_id = bookIdTextField.Text
        qty = quantityTextField.Text
        amount = amountTextField.Text
        date_of_sale = saleDate.Text

        Try
            Dim sql As String = "UPDATE `sales` SET `invoice_id`='" & invoice_id & "',`mem_id`='" & member_id & "',`book_id`='" & book_id & "',`qty`='" & qty & "',`amount`='" & amount & "',`date_of_sale`='" & date_of_sale & "' WHERE invoice_id = '" & invoice_id & "'"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Sale record Successfully saved", MsgBoxStyle.Information)

            invoiceIdTextField.Text = ""
            memberIdTextField.Text = ""
            bookIdTextField.Text = ""
            quantityTextField.Text = ""
            amountTextField.Text = ""
            saleDate.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Private Sub btnAddSales_Click(sender As Object, e As EventArgs) Handles btnAddSales.Click
        Add()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Display()
    End Sub

    Private Sub btnTotalSales_Click(sender As Object, e As EventArgs) Handles btnTotalSales.Click
        FindTotalSales()
    End Sub

    Private Sub btnTotalSaleByDate_Click(sender As Object, e As EventArgs) Handles btnTotalSaleByDate.Click
        Dim datee As Date
        datee = saleDate.Text
        FindTotalSales(datee)
    End Sub

    Private Sub btnTotalSalesByStartDate_Click(sender As Object, e As EventArgs) Handles btnTotalSalesByStartDate.Click
        BetweenDates.Show()
    End Sub
End Class