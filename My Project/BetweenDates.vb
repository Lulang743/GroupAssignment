Imports MySql.Data.MySqlClient


Public Class BetweenDates
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=book_shop"

        Dim READER As MySqlDataReader

        Dim table As New DataTable()




        Try
            Dim sql As String = "SELECT `amount` FROM `sales` WHERE `date_of_sale` >='" & firstDate.Text & "' AND `date_of_sale` <= '" & secondDate.Text & "' "
            conn.Open()
            Command = New MySqlCommand(sql, conn)
            'READER = COMMAND.ExecuteReader
            table.Load(Command.ExecuteReader)

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
End Class