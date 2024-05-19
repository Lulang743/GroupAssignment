<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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
        Label5 = New Label()
        Panel2 = New Panel()
        btnDisplay = New Button()
        searchTextField = New TextBox()
        btnSearch = New Button()
        btnAdd = New Button()
        btnRemove = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        nameTextField = New TextBox()
        phoneTextField = New TextBox()
        locationTextField = New TextBox()
        idTextField = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1031, 63)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(196, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(164, 37)
        Label5.TabIndex = 11
        Label5.Text = "Suppliers"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(btnDisplay)
        Panel2.Controls.Add(searchTextField)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(btnRemove)
        Panel2.Location = New Point(2, 63)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 329)
        Panel2.TabIndex = 1
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDisplay.Location = New Point(28, 268)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(157, 36)
        btnDisplay.TabIndex = 14
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' searchTextField
        ' 
        searchTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchTextField.Location = New Point(28, 27)
        searchTextField.Name = "searchTextField"
        searchTextField.Size = New Size(157, 29)
        searchTextField.TabIndex = 9
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(28, 199)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(157, 37)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(28, 75)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(157, 39)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add Supplier"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.Location = New Point(28, 136)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(157, 39)
        btnRemove.TabIndex = 12
        btnRemove.Text = "Remove Supplier"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(274, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 29)
        Label1.TabIndex = 2
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(274, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 29)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(665, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 29)
        Label3.TabIndex = 4
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(665, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 29)
        Label4.TabIndex = 5
        Label4.Text = "Location"
        ' 
        ' nameTextField
        ' 
        nameTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameTextField.Location = New Point(413, 181)
        nameTextField.Name = "nameTextField"
        nameTextField.Size = New Size(198, 29)
        nameTextField.TabIndex = 6
        ' 
        ' phoneTextField
        ' 
        phoneTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        phoneTextField.Location = New Point(803, 111)
        phoneTextField.Name = "phoneTextField"
        phoneTextField.Size = New Size(198, 29)
        phoneTextField.TabIndex = 7
        ' 
        ' locationTextField
        ' 
        locationTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        locationTextField.Location = New Point(803, 184)
        locationTextField.Name = "locationTextField"
        locationTextField.Size = New Size(198, 29)
        locationTextField.TabIndex = 8
        ' 
        ' idTextField
        ' 
        idTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        idTextField.Location = New Point(413, 111)
        idTextField.Name = "idTextField"
        idTextField.Size = New Size(198, 29)
        idTextField.TabIndex = 10
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(202, 242)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(829, 150)
        DataGridView1.TabIndex = 11
        ' 
        ' Suppliers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 392)
        Controls.Add(DataGridView1)
        Controls.Add(idTextField)
        Controls.Add(locationTextField)
        Controls.Add(phoneTextField)
        Controls.Add(nameTextField)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Suppliers"
        Text = "Suppliers"
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
    Friend WithEvents btnDisplay As Button
    Friend WithEvents searchTextField As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameTextField As TextBox
    Friend WithEvents phoneTextField As TextBox
    Friend WithEvents locationTextField As TextBox
    Friend WithEvents idTextField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
