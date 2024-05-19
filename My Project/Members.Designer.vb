<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Members
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
        btnAddMember = New Button()
        btnRefreshMember = New Button()
        btnSearchMember = New Button()
        searchTextField = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        locationTextField = New TextBox()
        validTextField = New TextBox()
        phoneTextField = New TextBox()
        nameTextField = New TextBox()
        idTextField = New TextBox()
        startDate = New DateTimePicker()
        endDate = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Label9 = New Label()
        passwordTextField = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 66)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(190, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 41)
        Label1.TabIndex = 2
        Label1.Text = "Memebrs"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(btnAddMember)
        Panel2.Controls.Add(btnRefreshMember)
        Panel2.Controls.Add(btnSearchMember)
        Panel2.Controls.Add(searchTextField)
        Panel2.Location = New Point(-1, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(233, 447)
        Panel2.TabIndex = 1
        ' 
        ' btnAddMember
        ' 
        btnAddMember.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddMember.Location = New Point(28, 84)
        btnAddMember.Name = "btnAddMember"
        btnAddMember.Size = New Size(180, 38)
        btnAddMember.TabIndex = 10
        btnAddMember.Text = "Add Member"
        btnAddMember.UseVisualStyleBackColor = True
        ' 
        ' btnRefreshMember
        ' 
        btnRefreshMember.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefreshMember.Location = New Point(28, 157)
        btnRefreshMember.Name = "btnRefreshMember"
        btnRefreshMember.Size = New Size(180, 38)
        btnRefreshMember.TabIndex = 11
        btnRefreshMember.Text = "Refresh"
        btnRefreshMember.UseVisualStyleBackColor = True
        ' 
        ' btnSearchMember
        ' 
        btnSearchMember.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchMember.Location = New Point(28, 233)
        btnSearchMember.Name = "btnSearchMember"
        btnSearchMember.Size = New Size(180, 34)
        btnSearchMember.TabIndex = 12
        btnSearchMember.Text = "Search"
        btnSearchMember.UseVisualStyleBackColor = True
        ' 
        ' searchTextField
        ' 
        searchTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchTextField.Location = New Point(28, 19)
        searchTextField.Name = "searchTextField"
        searchTextField.Size = New Size(180, 33)
        searchTextField.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(270, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 24)
        Label2.TabIndex = 3
        Label2.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(270, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 24)
        Label3.TabIndex = 4
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(270, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 24)
        Label4.TabIndex = 5
        Label4.Text = "Location"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(688, 110)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 24)
        Label5.TabIndex = 6
        Label5.Text = "Phone"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(688, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 24)
        Label6.TabIndex = 7
        Label6.Text = "Start Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(688, 237)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 24)
        Label7.TabIndex = 8
        Label7.Text = "End Date"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(270, 299)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 24)
        Label8.TabIndex = 9
        Label8.Text = "Valid"
        ' 
        ' locationTextField
        ' 
        locationTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        locationTextField.Location = New Point(388, 228)
        locationTextField.Name = "locationTextField"
        locationTextField.Size = New Size(256, 29)
        locationTextField.TabIndex = 16
        ' 
        ' validTextField
        ' 
        validTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        validTextField.Location = New Point(388, 290)
        validTextField.Name = "validTextField"
        validTextField.Size = New Size(256, 33)
        validTextField.TabIndex = 17
        ' 
        ' phoneTextField
        ' 
        phoneTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        phoneTextField.Location = New Point(827, 105)
        phoneTextField.Name = "phoneTextField"
        phoneTextField.Size = New Size(256, 29)
        phoneTextField.TabIndex = 18
        ' 
        ' nameTextField
        ' 
        nameTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameTextField.Location = New Point(388, 169)
        nameTextField.Name = "nameTextField"
        nameTextField.Size = New Size(256, 29)
        nameTextField.TabIndex = 20
        ' 
        ' idTextField
        ' 
        idTextField.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        idTextField.Location = New Point(388, 110)
        idTextField.Name = "idTextField"
        idTextField.Size = New Size(256, 29)
        idTextField.TabIndex = 21
        ' 
        ' startDate
        ' 
        startDate.CustomFormat = "yyyy-MM-dd"
        startDate.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        startDate.Format = DateTimePickerFormat.Custom
        startDate.Location = New Point(830, 165)
        startDate.Name = "startDate"
        startDate.Size = New Size(253, 35)
        startDate.TabIndex = 22
        ' 
        ' endDate
        ' 
        endDate.CustomFormat = "yyyy-MM-dd"
        endDate.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        endDate.Format = DateTimePickerFormat.Custom
        endDate.Location = New Point(827, 228)
        endDate.Name = "endDate"
        endDate.Size = New Size(253, 35)
        endDate.TabIndex = 23
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(232, 365)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(868, 150)
        DataGridView1.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(688, 292)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 32)
        Label9.TabIndex = 25
        Label9.Text = "Password"
        ' 
        ' passwordTextField
        ' 
        passwordTextField.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordTextField.Location = New Point(825, 290)
        passwordTextField.Name = "passwordTextField"
        passwordTextField.Size = New Size(255, 33)
        passwordTextField.TabIndex = 26
        ' 
        ' Members
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1104, 517)
        Controls.Add(passwordTextField)
        Controls.Add(Label9)
        Controls.Add(DataGridView1)
        Controls.Add(endDate)
        Controls.Add(startDate)
        Controls.Add(idTextField)
        Controls.Add(nameTextField)
        Controls.Add(phoneTextField)
        Controls.Add(validTextField)
        Controls.Add(locationTextField)
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
        Name = "Members"
        Text = "Members"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddMember As Button
    Friend WithEvents btnRefreshMember As Button
    Friend WithEvents btnSearchMember As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents searchTextField As TextBox
    Friend WithEvents locationTextField As TextBox
    Friend WithEvents validTextField As TextBox
    Friend WithEvents phoneTextField As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents nameTextField As TextBox
    Friend WithEvents idTextField As TextBox
    Friend WithEvents startDate As DateTimePicker
    Friend WithEvents endDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents passwordTextField As TextBox
End Class
