<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchases
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        btnNewOrder = New Button()
        btnViewOrder = New Button()
        btnCancelOrder = New Button()
        btnMarkReceived = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        receivedTextField = New TextBox()
        supplierIdTextField = New TextBox()
        etaTextField = New TextBox()
        orderIdTextField = New TextBox()
        quantityTextField = New TextBox()
        BookIdTexfield = New TextBox()
        invoiceTextField = New TextBox()
        dateOfOrder = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1122, 59)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(206, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 37)
        Label1.TabIndex = 6
        Label1.Text = "Purchases"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(btnNewOrder)
        Panel2.Controls.Add(btnViewOrder)
        Panel2.Controls.Add(btnCancelOrder)
        Panel2.Controls.Add(btnMarkReceived)
        Panel2.Location = New Point(4, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 447)
        Panel2.TabIndex = 1
        ' 
        ' btnNewOrder
        ' 
        btnNewOrder.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNewOrder.Location = New Point(28, 85)
        btnNewOrder.Name = "btnNewOrder"
        btnNewOrder.Size = New Size(146, 39)
        btnNewOrder.TabIndex = 2
        btnNewOrder.Text = "New Order"
        btnNewOrder.UseVisualStyleBackColor = True
        ' 
        ' btnViewOrder
        ' 
        btnViewOrder.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewOrder.Location = New Point(28, 151)
        btnViewOrder.Name = "btnViewOrder"
        btnViewOrder.Size = New Size(146, 42)
        btnViewOrder.TabIndex = 3
        btnViewOrder.Text = "Viere Order"
        btnViewOrder.UseVisualStyleBackColor = True
        ' 
        ' btnCancelOrder
        ' 
        btnCancelOrder.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelOrder.Location = New Point(28, 222)
        btnCancelOrder.Name = "btnCancelOrder"
        btnCancelOrder.Size = New Size(146, 41)
        btnCancelOrder.TabIndex = 4
        btnCancelOrder.Text = "Cancel Order"
        btnCancelOrder.UseVisualStyleBackColor = True
        ' 
        ' btnMarkReceived
        ' 
        btnMarkReceived.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMarkReceived.Location = New Point(28, 297)
        btnMarkReceived.Name = "btnMarkReceived"
        btnMarkReceived.Size = New Size(146, 42)
        btnMarkReceived.TabIndex = 5
        btnMarkReceived.Text = "Mark Received"
        btnMarkReceived.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(242, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 24)
        Label2.TabIndex = 7
        Label2.Text = "Order ID "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(242, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 24)
        Label3.TabIndex = 8
        Label3.Text = "Book ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(242, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 24)
        Label4.TabIndex = 9
        Label4.Text = "Supplier ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(698, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 24)
        Label5.TabIndex = 10
        Label5.Text = "Quantity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(242, 289)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 24)
        Label6.TabIndex = 11
        Label6.Text = "Date Of Order"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(700, 173)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 24)
        Label7.TabIndex = 12
        Label7.Text = "Eta"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(698, 296)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 24)
        Label8.TabIndex = 13
        Label8.Text = "Received"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(700, 230)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 24)
        Label9.TabIndex = 14
        Label9.Text = "Invoice"
        ' 
        ' receivedTextField
        ' 
        receivedTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        receivedTextField.Location = New Point(834, 288)
        receivedTextField.Name = "receivedTextField"
        receivedTextField.Size = New Size(249, 35)
        receivedTextField.TabIndex = 15
        ' 
        ' supplierIdTextField
        ' 
        supplierIdTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        supplierIdTextField.Location = New Point(416, 219)
        supplierIdTextField.Name = "supplierIdTextField"
        supplierIdTextField.Size = New Size(249, 35)
        supplierIdTextField.TabIndex = 16
        ' 
        ' etaTextField
        ' 
        etaTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        etaTextField.Location = New Point(834, 167)
        etaTextField.Name = "etaTextField"
        etaTextField.Size = New Size(249, 35)
        etaTextField.TabIndex = 18
        ' 
        ' orderIdTextField
        ' 
        orderIdTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        orderIdTextField.Location = New Point(416, 113)
        orderIdTextField.Name = "orderIdTextField"
        orderIdTextField.Size = New Size(249, 35)
        orderIdTextField.TabIndex = 19
        ' 
        ' quantityTextField
        ' 
        quantityTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quantityTextField.Location = New Point(834, 113)
        quantityTextField.Name = "quantityTextField"
        quantityTextField.Size = New Size(249, 35)
        quantityTextField.TabIndex = 20
        ' 
        ' BookIdTexfield
        ' 
        BookIdTexfield.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BookIdTexfield.Location = New Point(416, 167)
        BookIdTexfield.Name = "BookIdTexfield"
        BookIdTexfield.Size = New Size(249, 35)
        BookIdTexfield.TabIndex = 22
        ' 
        ' invoiceTextField
        ' 
        invoiceTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        invoiceTextField.Location = New Point(834, 230)
        invoiceTextField.Name = "invoiceTextField"
        invoiceTextField.Size = New Size(249, 35)
        invoiceTextField.TabIndex = 23
        ' 
        ' dateOfOrder
        ' 
        dateOfOrder.CustomFormat = "yyyy-MM-dd"
        dateOfOrder.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dateOfOrder.Format = DateTimePickerFormat.Custom
        dateOfOrder.Location = New Point(417, 280)
        dateOfOrder.Name = "dateOfOrder"
        dateOfOrder.Size = New Size(248, 33)
        dateOfOrder.TabIndex = 24
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(204, 354)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(921, 150)
        DataGridView1.TabIndex = 25
        ' 
        ' Purchases
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1126, 503)
        Controls.Add(DataGridView1)
        Controls.Add(dateOfOrder)
        Controls.Add(invoiceTextField)
        Controls.Add(BookIdTexfield)
        Controls.Add(quantityTextField)
        Controls.Add(orderIdTextField)
        Controls.Add(etaTextField)
        Controls.Add(supplierIdTextField)
        Controls.Add(receivedTextField)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Purchases"
        Text = "Purchases"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnViewOrder As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnMarkReceived As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents receivedTextField As TextBox
    Friend WithEvents supplierIdTextField As TextBox
    Friend WithEvents etaTextField As TextBox
    Friend WithEvents orderIdTextField As TextBox
    Friend WithEvents quantityTextField As TextBox
    Friend WithEvents BookIdTexfield As TextBox
    Friend WithEvents invoiceTextField As TextBox
    Friend WithEvents dateOfOrder As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
End Class
