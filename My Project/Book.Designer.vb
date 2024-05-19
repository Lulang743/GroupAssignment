<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book
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
        quantityTextField = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        btnDisplay = New Button()
        quantityTextFields = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        btnSearch = New Button()
        searchTextField = New TextBox()
        btnUpdate = New Button()
        btnAdd = New Button()
        btnUpdatePrice = New Button()
        Label4 = New Label()
        Label3 = New Label()
        authorTextField = New TextBox()
        nameTextField = New TextBox()
        DataGridView1 = New DataGridView()
        idTextField = New TextBox()
        priceTextField = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' quantityTextField
        ' 
        quantityTextField.AutoSize = True
        quantityTextField.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        quantityTextField.Location = New Point(274, 218)
        quantityTextField.Name = "quantityTextField"
        quantityTextField.Size = New Size(110, 29)
        quantityTextField.TabIndex = 37
        quantityTextField.Text = "Quantity"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(1, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(999, 63)
        Panel1.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(196, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 37)
        Label5.TabIndex = 11
        Label5.Text = "Books "
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDisplay.Location = New Point(28, 296)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(157, 36)
        btnDisplay.TabIndex = 15
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' quantityTextFields
        ' 
        quantityTextFields.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quantityTextFields.Location = New Point(413, 209)
        quantityTextFields.Name = "quantityTextFields"
        quantityTextFields.Size = New Size(198, 29)
        quantityTextFields.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(274, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 29)
        Label1.TabIndex = 27
        Label1.Text = "ID"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(btnDisplay)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(searchTextField)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(btnUpdatePrice)
        Panel2.Location = New Point(2, 58)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 353)
        Panel2.TabIndex = 26
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(28, 249)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(157, 36)
        btnSearch.TabIndex = 14
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' searchTextField
        ' 
        searchTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchTextField.Location = New Point(28, 32)
        searchTextField.Name = "searchTextField"
        searchTextField.Size = New Size(157, 29)
        searchTextField.TabIndex = 9
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(28, 196)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(157, 37)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(28, 85)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(157, 39)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add Book"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdatePrice
        ' 
        btnUpdatePrice.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdatePrice.Location = New Point(28, 141)
        btnUpdatePrice.Name = "btnUpdatePrice"
        btnUpdatePrice.Size = New Size(157, 39)
        btnUpdatePrice.TabIndex = 12
        btnUpdatePrice.Text = "UpdatePrice"
        btnUpdatePrice.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(643, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 29)
        Label4.TabIndex = 30
        Label4.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(643, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 29)
        Label3.TabIndex = 29
        Label3.Text = "Author"
        ' 
        ' authorTextField
        ' 
        authorTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        authorTextField.Location = New Point(789, 87)
        authorTextField.Name = "authorTextField"
        authorTextField.Size = New Size(198, 29)
        authorTextField.TabIndex = 32
        ' 
        ' nameTextField
        ' 
        nameTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameTextField.Location = New Point(413, 146)
        nameTextField.Name = "nameTextField"
        nameTextField.Size = New Size(198, 29)
        nameTextField.TabIndex = 31
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(197, 261)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(803, 150)
        DataGridView1.TabIndex = 35
        ' 
        ' idTextField
        ' 
        idTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        idTextField.Location = New Point(413, 90)
        idTextField.Name = "idTextField"
        idTextField.Size = New Size(198, 29)
        idTextField.TabIndex = 34
        ' 
        ' priceTextField
        ' 
        priceTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        priceTextField.Location = New Point(789, 146)
        priceTextField.Name = "priceTextField"
        priceTextField.Size = New Size(198, 29)
        priceTextField.TabIndex = 33
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(274, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 29)
        Label2.TabIndex = 28
        Label2.Text = "Name"
        ' 
        ' Book
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.OIP
        ClientSize = New Size(999, 411)
        Controls.Add(quantityTextField)
        Controls.Add(Panel1)
        Controls.Add(quantityTextFields)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(authorTextField)
        Controls.Add(nameTextField)
        Controls.Add(DataGridView1)
        Controls.Add(idTextField)
        Controls.Add(priceTextField)
        Controls.Add(Label2)
        MaximizeBox = False
        Name = "Book"
        Text = "Book"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents quantityTextField As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents quantityTextFields As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents searchTextField As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdatePrice As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents authorTextField As TextBox
    Friend WithEvents nameTextField As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idTextField As TextBox
    Friend WithEvents priceTextField As TextBox
    Friend WithEvents Label2 As Label
End Class
