<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menus
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
        Panel2 = New Panel()
        BookDisplay = New Button()
        btnSales = New Button()
        btnMembers = New Button()
        btnSuppliers = New Button()
        btnEmployees = New Button()
        btnPurchases = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(BookDisplay)
        Panel2.Controls.Add(btnSales)
        Panel2.Controls.Add(btnMembers)
        Panel2.Controls.Add(btnSuppliers)
        Panel2.Controls.Add(btnEmployees)
        Panel2.Controls.Add(btnPurchases)
        Panel2.Location = New Point(-1, 58)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 354)
        Panel2.TabIndex = 9
        ' 
        ' BookDisplay
        ' 
        BookDisplay.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BookDisplay.Location = New Point(34, 33)
        BookDisplay.Name = "BookDisplay"
        BookDisplay.Size = New Size(142, 36)
        BookDisplay.TabIndex = 11
        BookDisplay.Text = "New Book"
        BookDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnSales
        ' 
        btnSales.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSales.Location = New Point(34, 297)
        btnSales.Name = "btnSales"
        btnSales.Size = New Size(142, 36)
        btnSales.TabIndex = 10
        btnSales.Text = "Sales"
        btnSales.UseVisualStyleBackColor = True
        ' 
        ' btnMembers
        ' 
        btnMembers.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMembers.Location = New Point(34, 244)
        btnMembers.Name = "btnMembers"
        btnMembers.Size = New Size(142, 38)
        btnMembers.TabIndex = 9
        btnMembers.Text = "Members"
        btnMembers.UseVisualStyleBackColor = True
        ' 
        ' btnSuppliers
        ' 
        btnSuppliers.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSuppliers.Location = New Point(34, 87)
        btnSuppliers.Name = "btnSuppliers"
        btnSuppliers.Size = New Size(142, 38)
        btnSuppliers.TabIndex = 6
        btnSuppliers.Text = "Suppliers"
        btnSuppliers.UseVisualStyleBackColor = True
        ' 
        ' btnEmployees
        ' 
        btnEmployees.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEmployees.Location = New Point(34, 193)
        btnEmployees.Name = "btnEmployees"
        btnEmployees.Size = New Size(142, 35)
        btnEmployees.TabIndex = 8
        btnEmployees.Text = "Employees"
        btnEmployees.UseVisualStyleBackColor = True
        ' 
        ' btnPurchases
        ' 
        btnPurchases.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPurchases.Location = New Point(34, 141)
        btnPurchases.Name = "btnPurchases"
        btnPurchases.Size = New Size(142, 38)
        btnPurchases.TabIndex = 7
        btnPurchases.Text = "Purchases"
        btnPurchases.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(934, 59)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Blue
        Label1.Font = New Font("Imprint MT Shadow", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(341, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 75)
        Label1.TabIndex = 11
        Label1.Text = "Book Shop"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Blue
        Panel3.Location = New Point(-1, 410)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(934, 65)
        Panel3.TabIndex = 10
        ' 
        ' Menus
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.one__3_
        ClientSize = New Size(932, 473)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        MaximizeBox = False
        Name = "Menus"
        Text = "Menus"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BookDisplay As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnPurchases As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
End Class
