<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BetweenDates
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
        firstDate = New DateTimePicker()
        btnFind = New Button()
        secondDate = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        totalSales = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' firstDate
        ' 
        firstDate.CustomFormat = "yyyy-MM-dd"
        firstDate.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstDate.Format = DateTimePickerFormat.Custom
        firstDate.Location = New Point(101, 105)
        firstDate.Name = "firstDate"
        firstDate.Size = New Size(200, 35)
        firstDate.TabIndex = 2
        ' 
        ' btnFind
        ' 
        btnFind.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFind.Location = New Point(629, 105)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(124, 37)
        btnFind.TabIndex = 3
        btnFind.Text = "Find"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' secondDate
        ' 
        secondDate.CustomFormat = "yyyy-MM-dd"
        secondDate.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        secondDate.Format = DateTimePickerFormat.Custom
        secondDate.Location = New Point(362, 105)
        secondDate.Name = "secondDate"
        secondDate.Size = New Size(200, 35)
        secondDate.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(101, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(433, 175)
        DataGridView1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(591, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 45)
        Label1.TabIndex = 6
        Label1.Text = "Total Sales"
        ' 
        ' totalSales
        ' 
        totalSales.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        totalSales.Location = New Point(629, 233)
        totalSales.Name = "totalSales"
        totalSales.Size = New Size(124, 35)
        totalSales.TabIndex = 7
        ' 
        ' BetweenDates
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Blue
        ClientSize = New Size(800, 450)
        Controls.Add(totalSales)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(secondDate)
        Controls.Add(btnFind)
        Controls.Add(firstDate)
        MaximizeBox = False
        Name = "BetweenDates"
        Text = "BetweenDates"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents firstDate As DateTimePicker
    Friend WithEvents btnFind As Button
    Friend WithEvents secondDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents totalSales As TextBox
End Class
