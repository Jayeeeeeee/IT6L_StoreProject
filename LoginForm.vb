Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim LoginQuery As New MySqlCommand("SELECT Emp_User,Emp_Password FROM employee_login where Emp_User ='" & Usertxt.Text & "' and Emp_Password = '" & Passtxt.Text & "'", mysqlConn)
        Dim da As New MySqlDataAdapter(LoginQuery)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Wrong Username or Password!", "Please check your credentials.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cleartxt()
        Else
            MessageBox.Show("Successful Login!", "Welcome.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainForm.Show()
            Me.Hide()
            cleartxt()
        End If
    End Sub

    Private Sub cleartxt()
        Usertxt.Text = ""
        Passtxt.Text = ""
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Close()
        ClosedbConn()
    End Sub

End Class
