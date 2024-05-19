Imports MySql.Data.MySqlClient

Public Class Purchases

    Private ord_id As Integer
    Private book_id As Integer
    Private sup_id As Integer
    Private qty As Integer
    Private dt_ordered As Date
    Private eta As Integer
    Private received As Char
    Private inv As Integer

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Public Sub NewOrder()


        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        If String.IsNullOrEmpty(orderIdTextField.Text) Then
            MsgBox(" order id is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(BookIdTexfield.Text) Then
            MsgBox("book id is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(supplierIdTextField.Text) Then
            MsgBox("suppliers id is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(quantityTextField.Text) Then
            MsgBox("quantity is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(etaTextField.Text) Then
            MsgBox("eta is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(receivedTextField.Text) Then
            MsgBox("received status is empty", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(invoiceTextField.Text) Then
            MsgBox("invoice is empty", MsgBoxStyle.Information)
        End If

        ord_id = orderIdTextField.Text
        book_id = BookIdTexfield.Text
        sup_id = supplierIdTextField.Text
        qty = quantityTextField.Text
        eta = etaTextField.Text
        received = receivedTextField.Text
        inv = invoiceTextField.Text


        Try
            Dim sql As String = "INSERT INTO `purchases`(`order_id`, `book_id`, `supplier_id`, `quantity`, `date_of_order`, `eta`, `received`, `invoice`) 
             VALUES ('" & ord_id & " ','" & book_id & "','" & sup_id & "','" & qty & "','" & dateOfOrder.Text & "','" & eta & "','" & received & "','" & inv & "')"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Your order has been placed Successfully ", MsgBoxStyle.Information)

            orderIdTextField.Text = ""
            BookIdTexfield.Text = ""
            supplierIdTextField.Text = ""
            quantityTextField.Text = ""
            etaTextField.Text = ""
            receivedTextField.Text = ""
            invoiceTextField.Text = ""

            quantityTextField.Text = dt_ordered
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub ViewOrder()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader
        Dim table As New DataTable()


        Try
            Dim sql As String = "SELECT `order_id`, `book_id`, `supplier_id`, `quantity`, `eta`, `received`, `invoice` FROM `purchases`"
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
    Public Sub CancelOrder()

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        ord_id = orderIdTextField.Text

        Try
            Dim sql As String = "UPDATE `purchases` SET `received`='cancelled' WHERE order_id = '" & ord_id & "'"
            conn.Open()
            Command = New MySqlCommand(sql, conn)
            READER = Command.ExecuteReader
            MsgBox("Your order has been cancelled ", MsgBoxStyle.Information)

            orderIdTextField.Text = ""
            BookIdTexfield.Text = ""
            supplierIdTextField.Text = ""
            quantityTextField.Text = ""
            dateOfOrder.Text = ""
            etaTextField.Text = ""
            receivedTextField.Text = ""
            invoiceTextField.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Public Sub MarkReceived(ByVal status As Char)
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        ord_id = orderIdTextField.Text
        status = "Received"

        Try
            Dim sql As String = "UPDATE `purchases` SET `received`='" & status & "' WHERE order_id = '" & ord_id & "'"
            conn.Open()
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Your order has been marked as received ", MsgBoxStyle.Information)

            orderIdTextField.Text = ""
            BookIdTexfield.Text = ""
            supplierIdTextField.Text = ""
            quantityTextField.Text = ""
            dateOfOrder.Text = ""
            etaTextField.Text = ""
            receivedTextField.Text = ""
            invoiceTextField.Text = ""

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles orderIdTextField.KeyPress

        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
            MsgBox("only numbers ", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        NewOrder()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        CancelOrder()

    End Sub

    Private Sub btnMarkReceived_Click(sender As Object, e As EventArgs) Handles btnMarkReceived.Click

        MarkReceived("Received")

    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        ViewOrder()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub orderIdTextField_TextChanged(sender As Object, e As KeyPressEventArgs) Handles orderIdTextField.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8)) Then
            e.Handled = True
            MsgBox("Your order has been marked as received ", MsgBoxStyle.Information)
        End If
    End Sub
End Class