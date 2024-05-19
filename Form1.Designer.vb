<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        usernameTextField = New TextBox()
        passwordTextField = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(448, 475)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(109, 219)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(190, 10)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Text", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(52, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 69)
        Label1.TabIndex = 0
        Label1.Text = "BOOK SHOP "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Display", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(551, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 42)
        Label2.TabIndex = 1
        Label2.Text = "LOGIN HERE"
        ' 
        ' usernameTextField
        ' 
        usernameTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTextField.Location = New Point(525, 203)
        usernameTextField.Name = "usernameTextField"
        usernameTextField.PlaceholderText = "Username"
        usernameTextField.Size = New Size(236, 35)
        usernameTextField.TabIndex = 2
        usernameTextField.TextAlign = HorizontalAlignment.Center
        ' 
        ' passwordTextField
        ' 
        passwordTextField.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordTextField.Location = New Point(525, 259)
        passwordTextField.Name = "passwordTextField"
        passwordTextField.PlaceholderText = "Password"
        passwordTextField.Size = New Size(236, 35)
        passwordTextField.TabIndex = 3
        passwordTextField.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(525, 320)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 38)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Blue
        Button2.FlatAppearance.BorderColor = Color.Blue
        Button2.FlatAppearance.BorderSize = 0
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(656, 320)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 38)
        Button2.TabIndex = 5
        Button2.Text = "Register"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(893, 473)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(passwordTextField)
        Controls.Add(usernameTextField)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameTextField As TextBox
    Friend WithEvents passwordTextField As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand

End Class
