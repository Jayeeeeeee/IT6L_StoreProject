Public Class MainForm
    Private dt As DataTable
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim out As New System.Windows.Forms.DialogResult
        out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo)
        If out = Windows.Forms.DialogResult.Yes Then
            LoginForm.Show()
            Me.Hide()
            ClosedbConn()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("select * from product_info", InventoryDataGrid)
        loadToComboBox("select * from product_category_tbl", CategoryCB)
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        If (Nametxt.Text = "" Or Pricetxt.Text = "" Or Quantitytxt.Text = "") Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim ProductQuery = "INSERT INTO product_tbl VALUES(null, '" & Nametxt.Text & "', '" & Pricetxt.Text & "', '" & CategoryCB.SelectedValue & "', '" & Quantitytxt.Text & "')"
            SQLProcess(ProductQuery)

            MessageBox.Show("Product added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim ProductUpdate = "UPDATE product_info SET Name = '" & Nametxt.Text & "' , Price = '" & Pricetxt.Text & "', Quantity = '" & Quantitytxt.Text & "' WHERE ID = '" & IDtxt.Text & "'"
        SQLProcess(ProductUpdate)

        Dim PCatUpdate = "UPDATE product_info SET Category = '" & CategoryCB.Text & "' WHERE ID = '" & IDtxt.Text & "'"
        SQLProcess(ProductUpdate)

        MessageBox.Show("Update successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cleartxt()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim ProdDelete As New System.Windows.Forms.DialogResult
        ProdDelete = MessageBox.Show("Delete product?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ProdDelete = Windows.Forms.DialogResult.Yes Then
            Dim PDelete = "DELETE FROM product_tbl WHERE Product_ID = '" & IDtxt.Text & "'"
            SQLProcess(PDelete)
            MessageBox.Show("Product Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleartxt()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        cleartxt()
    End Sub

    Private Sub cleartxt()
        IDtxt.Text = ""
        Nametxt.Text = ""
        Pricetxt.Text = ""
        CategoryCB.Text = ""
        Quantitytxt.Text = ""
        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False
    End Sub

    Private Sub InventoryDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InventoryDataGrid.CellClick
        Try
            Dim i = e.RowIndex
            With InventoryDataGrid
                IDtxt.Text = .Item("ID", i).Value
                Nametxt.Text = .Item("Name", i).Value
                Pricetxt.Text = .Item("Price", i).Value
                CategoryCB.Text = .Item("Category", i).Value
                Quantitytxt.Text = .Item("Quantity", i).Value
            End With
            UpdateBtn.Enabled = True
            DeleteBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged

        If SearchCB.SelectedItem = "ID" Then
            Dim IDSearch = "select * from product_info where ID like '%" & SearchTxt.Text & "%'"
            displayInfo(IDSearch, InventoryDataGrid)

        ElseIf SearchCB.SelectedItem = "Name" Then
            Dim NameSearch = "select * from product_info where Name like '%" & SearchTxt.Text & "%'"
            displayInfo(NameSearch, InventoryDataGrid)

        ElseIf SearchCB.SelectedItem = "Price" Then
            Dim PSearch = "select * from product_info where Price like '%" & SearchTxt.Text & "%'"
            displayInfo(PSearch, InventoryDataGrid)

        ElseIf SearchCB.SelectedItem = "Category" Then
            Dim CSearch = "select * from product_info where Category like '%" & SearchTxt.Text & "%'"
            displayInfo(CSearch, InventoryDataGrid)

        ElseIf SearchCB.SelectedItem = "Quantity" Then
            Dim QSearch = "select * from product_info where Quantity like '%" & SearchTxt.Text & "%'"
            displayInfo(QSearch, InventoryDataGrid)
        End If
        'Dim searchQuery = "SELECT * FROM product_info where ID like '%" & SearchTxt.Text & "%' 
        'or Name like '%" & SearchTxt.Text & "%' 
        'or Price like '%" & SearchTxt.Text & "%' 
        'or Category like '%" & SearchTxt.Text & "%' 
        'or Quantity like '%" & SearchTxt.Text & "%'"
        '    displayInfo(searchQuery, InventoryDataGrid)

    End Sub

End Class