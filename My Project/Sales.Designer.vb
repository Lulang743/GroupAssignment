<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        btnAddSales = New Button()
        btnTotalSales = New Button()
        btnTotalSaleByDate = New Button()
        btnTotalSalesByStartDate = New Button()
        searchTextfield = New TextBox()
        btnDisplay = New Button()
        btnUpdate = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        amountTextField = New TextBox()
        bookIdTextField = New TextBox()
        invoiceIdTextField = New TextBox()
        quantityTextField = New TextBox()
        memberIdTextField = New TextBox()
        saleDate = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Label8 = New Label()
        totalSales = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(945, 71)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(199, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 41)
        Label1.TabIndex = 2
        Label1.Text = "Sales"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(btnAddSales)
        Panel2.Controls.Add(btnTotalSales)
        Panel2.Controls.Add(btnTotalSaleByDate)
        Panel2.Controls.Add(btnTotalSalesByStartDate)
        Panel2.Controls.Add(searchTextfield)
        Panel2.Controls.Add(btnDisplay)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Location = New Point(1, 72)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 513)
        Panel2.TabIndex = 1
        ' 
        ' btnAddSales
        ' 
        btnAddSales.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddSales.Location = New Point(25, 70)
        btnAddSales.Name = "btnAddSales"
        btnAddSales.Size = New Size(161, 44)
        btnAddSales.TabIndex = 9
        btnAddSales.Text = "Add Sales"
        btnAddSales.UseVisualStyleBackColor = True
        ' 
        ' btnTotalSales
        ' 
        btnTotalSales.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTotalSales.Location = New Point(25, 131)
        btnTotalSales.Name = "btnTotalSales"
        btnTotalSales.Size = New Size(161, 45)
        btnTotalSales.TabIndex = 10
        btnTotalSales.Text = "Total Sales"
        btnTotalSales.UseVisualStyleBackColor = True
        ' 
        ' btnTotalSaleByDate
        ' 
        btnTotalSaleByDate.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTotalSaleByDate.Location = New Point(25, 188)
        btnTotalSaleByDate.Name = "btnTotalSaleByDate"
        btnTotalSaleByDate.Size = New Size(161, 41)
        btnTotalSaleByDate.TabIndex = 11
        btnTotalSaleByDate.Text = "Total By Date"
        btnTotalSaleByDate.UseVisualStyleBackColor = True
        ' 
        ' btnTotalSalesByStartDate
        ' 
        btnTotalSalesByStartDate.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTotalSalesByStartDate.Location = New Point(25, 242)
        btnTotalSalesByStartDate.Name = "btnTotalSalesByStartDate"
        btnTotalSalesByStartDate.Size = New Size(161, 50)
        btnTotalSalesByStartDate.TabIndex = 12
        btnTotalSalesByStartDate.Text = "Total By Start date"
        btnTotalSalesByStartDate.UseVisualStyleBackColor = True
        ' 
        ' searchTextfield
        ' 
        searchTextfield.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchTextfield.Location = New Point(25, 25)
        searchTextfield.Name = "searchTextfield"
        searchTextfield.Size = New Size(161, 33)
        searchTextfield.TabIndex = 17
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDisplay.Location = New Point(25, 298)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(161, 43)
        btnDisplay.TabIndex = 13
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(25, 350)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(161, 41)
        btnUpdate.TabIndex = 14
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(301, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 24)
        Label2.TabIndex = 3
        Label2.Text = "Invoice ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(301, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 24)
        Label3.TabIndex = 4
        Label3.Text = "Member ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(301, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 24)
        Label4.TabIndex = 5
        Label4.Text = "Book ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(301, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 24)
        Label5.TabIndex = 6
        Label5.Text = "Quantity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(301, 314)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 24)
        Label6.TabIndex = 7
        Label6.Text = "Amount"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(301, 374)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 24)
        Label7.TabIndex = 8
        Label7.Text = "Date of Sale"
        ' 
        ' amountTextField
        ' 
        amountTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        amountTextField.Location = New Point(470, 314)
        amountTextField.Name = "amountTextField"
        amountTextField.Size = New Size(225, 33)
        amountTextField.TabIndex = 15
        ' 
        ' bookIdTextField
        ' 
        bookIdTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bookIdTextField.Location = New Point(470, 215)
        bookIdTextField.Name = "bookIdTextField"
        bookIdTextField.Size = New Size(225, 33)
        bookIdTextField.TabIndex = 16
        ' 
        ' invoiceIdTextField
        ' 
        invoiceIdTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        invoiceIdTextField.Location = New Point(470, 107)
        invoiceIdTextField.Name = "invoiceIdTextField"
        invoiceIdTextField.Size = New Size(225, 33)
        invoiceIdTextField.TabIndex = 18
        ' 
        ' quantityTextField
        ' 
        quantityTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quantityTextField.Location = New Point(470, 262)
        quantityTextField.Name = "quantityTextField"
        quantityTextField.Size = New Size(225, 33)
        quantityTextField.TabIndex = 20
        ' 
        ' memberIdTextField
        ' 
        memberIdTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        memberIdTextField.Location = New Point(470, 163)
        memberIdTextField.Name = "memberIdTextField"
        memberIdTextField.Size = New Size(225, 33)
        memberIdTextField.TabIndex = 21
        ' 
        ' saleDate
        ' 
        saleDate.CalendarFont = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saleDate.CustomFormat = "yyyy-MM-dd"
        saleDate.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saleDate.Format = DateTimePickerFormat.Custom
        saleDate.Location = New Point(470, 378)
        saleDate.Name = "saleDate"
        saleDate.Size = New Size(225, 33)
        saleDate.TabIndex = 22
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(203, 420)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(739, 165)
        DataGridView1.TabIndex = 23
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(756, 106)
        Label8.Name = "Label8"
        Label8.Size = New Size(143, 30)
        Label8.TabIndex = 24
        Label8.Text = "TOTAL SALES"
        ' 
        ' totalSales
        ' 
        totalSales.Location = New Point(781, 155)
        totalSales.Name = "totalSales"
        totalSales.Size = New Size(91, 23)
        totalSales.TabIndex = 25
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(945, 582)
        Controls.Add(totalSales)
        Controls.Add(Label8)
        Controls.Add(DataGridView1)
        Controls.Add(saleDate)
        Controls.Add(memberIdTextField)
        Controls.Add(quantityTextField)
        Controls.Add(invoiceIdTextField)
        Controls.Add(bookIdTextField)
        Controls.Add(amountTextField)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Sales"
        Text = "Sales"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddSales As Button
    Friend WithEvents btnTotalSales As Button
    Friend WithEvents btnTotalSaleByDate As Button
    Friend WithEvents btnTotalSalesByStartDate As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents amountTextField As TextBox
    Friend WithEvents bookIdTextField As TextBox
    Friend WithEvents searchTextfield As TextBox
    Friend WithEvents invoiceIdTextField As TextBox
    Friend WithEvents quantityTextField As TextBox
    Friend WithEvents memberIdTextField As TextBox
    Friend WithEvents saleDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents totalSales As TextBox
End Class
