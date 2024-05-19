<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        searchTextField = New TextBox()
        btnAddEmployee = New Button()
        btnDisplay = New Button()
        btnSearch = New Button()
        btnAssignMngStatus = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        idTextField = New TextBox()
        nameTextField = New TextBox()
        locationTextField = New TextBox()
        salaryTextField = New TextBox()
        mrgStatusTextField = New TextBox()
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
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1065, 66)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(197, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 41)
        Label1.TabIndex = 2
        Label1.Text = "Employees"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(searchTextField)
        Panel2.Controls.Add(btnAddEmployee)
        Panel2.Controls.Add(btnDisplay)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(btnAssignMngStatus)
        Panel2.Location = New Point(-1, 63)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 365)
        Panel2.TabIndex = 1
        ' 
        ' searchTextField
        ' 
        searchTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchTextField.Location = New Point(3, 23)
        searchTextField.Name = "searchTextField"
        searchTextField.Size = New Size(164, 33)
        searchTextField.TabIndex = 14
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddEmployee.Location = New Point(10, 73)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(164, 41)
        btnAddEmployee.TabIndex = 13
        btnAddEmployee.Text = "Add Employee"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDisplay.Location = New Point(10, 297)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(164, 41)
        btnDisplay.TabIndex = 16
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(10, 149)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(164, 42)
        btnSearch.TabIndex = 14
        btnSearch.Text = "Search "
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnAssignMngStatus
        ' 
        btnAssignMngStatus.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAssignMngStatus.Location = New Point(10, 224)
        btnAssignMngStatus.Name = "btnAssignMngStatus"
        btnAssignMngStatus.Size = New Size(164, 41)
        btnAssignMngStatus.TabIndex = 15
        btnAssignMngStatus.Text = "Assign Mrg Status"
        btnAssignMngStatus.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(272, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 24)
        Label2.TabIndex = 3
        Label2.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(272, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 24)
        Label3.TabIndex = 4
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(272, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 24)
        Label4.TabIndex = 5
        Label4.Text = "Location"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(696, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 24)
        Label5.TabIndex = 6
        Label5.Text = "Salary"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(696, 181)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 24)
        Label6.TabIndex = 7
        Label6.Text = "Mrg Status"
        ' 
        ' idTextField
        ' 
        idTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        idTextField.Location = New Point(431, 115)
        idTextField.Name = "idTextField"
        idTextField.Size = New Size(228, 33)
        idTextField.TabIndex = 8
        ' 
        ' nameTextField
        ' 
        nameTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameTextField.Location = New Point(431, 172)
        nameTextField.Name = "nameTextField"
        nameTextField.Size = New Size(228, 33)
        nameTextField.TabIndex = 9
        ' 
        ' locationTextField
        ' 
        locationTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        locationTextField.Location = New Point(431, 234)
        locationTextField.Name = "locationTextField"
        locationTextField.Size = New Size(228, 33)
        locationTextField.TabIndex = 10
        ' 
        ' salaryTextField
        ' 
        salaryTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        salaryTextField.Location = New Point(821, 110)
        salaryTextField.Name = "salaryTextField"
        salaryTextField.Size = New Size(228, 33)
        salaryTextField.TabIndex = 11
        ' 
        ' mrgStatusTextField
        ' 
        mrgStatusTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mrgStatusTextField.Location = New Point(821, 181)
        mrgStatusTextField.Name = "mrgStatusTextField"
        mrgStatusTextField.Size = New Size(228, 35)
        mrgStatusTextField.TabIndex = 12
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(199, 279)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(865, 149)
        DataGridView1.TabIndex = 13
        ' 
        ' Employees
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.OIP
        ClientSize = New Size(1064, 423)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(mrgStatusTextField)
        Controls.Add(salaryTextField)
        Controls.Add(locationTextField)
        Controls.Add(nameTextField)
        Controls.Add(idTextField)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Employees"
        Text = "Employees"
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
    Friend WithEvents idTextField As TextBox
    Friend WithEvents nameTextField As TextBox
    Friend WithEvents locationTextField As TextBox
    Friend WithEvents salaryTextField As TextBox
    Friend WithEvents mrgStatusTextField As TextBox
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAssignMngStatus As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchTextField As TextBox
End Class
