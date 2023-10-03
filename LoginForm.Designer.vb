<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        UserLabel = New Label()
        PassLabel = New Label()
        Usertxt = New TextBox()
        Passtxt = New TextBox()
        LoginBtn = New Button()
        Closebtn = New Button()
        SuspendLayout()
        ' 
        ' UserLabel
        ' 
        UserLabel.AutoSize = True
        UserLabel.Location = New Point(12, 31)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New Size(63, 15)
        UserLabel.TabIndex = 1
        UserLabel.Text = "Username:"
        ' 
        ' PassLabel
        ' 
        PassLabel.AutoSize = True
        PassLabel.Location = New Point(12, 62)
        PassLabel.Name = "PassLabel"
        PassLabel.Size = New Size(60, 15)
        PassLabel.TabIndex = 2
        PassLabel.Text = "Password:"
        ' 
        ' Usertxt
        ' 
        Usertxt.Location = New Point(81, 28)
        Usertxt.Name = "Usertxt"
        Usertxt.Size = New Size(100, 23)
        Usertxt.TabIndex = 3
        ' 
        ' Passtxt
        ' 
        Passtxt.Location = New Point(81, 59)
        Passtxt.Name = "Passtxt"
        Passtxt.PasswordChar = "*"c
        Passtxt.Size = New Size(100, 23)
        Passtxt.TabIndex = 4
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Location = New Point(81, 88)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(100, 23)
        LoginBtn.TabIndex = 5
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' Closebtn
        ' 
        Closebtn.Location = New Point(81, 117)
        Closebtn.Name = "Closebtn"
        Closebtn.Size = New Size(100, 23)
        Closebtn.TabIndex = 6
        Closebtn.Text = "Cancel"
        Closebtn.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(210, 162)
        Controls.Add(Closebtn)
        Controls.Add(LoginBtn)
        Controls.Add(Passtxt)
        Controls.Add(Usertxt)
        Controls.Add(PassLabel)
        Controls.Add(UserLabel)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UserLabel As Label
    Friend WithEvents PassLabel As Label
    Friend WithEvents Usertxt As TextBox
    Friend WithEvents Passtxt As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Closebtn As Button
End Class
