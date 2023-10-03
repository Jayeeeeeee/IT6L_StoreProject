<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        GroupBox2 = New GroupBox()
        SearchCB = New ComboBox()
        SearchTxt = New TextBox()
        InventoryDataGrid = New DataGridView()
        GroupBox1 = New GroupBox()
        CategoryCB = New ComboBox()
        Quantitytxt = New TextBox()
        Pricetxt = New TextBox()
        Nametxt = New TextBox()
        IDtxt = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        ClearBtn = New Button()
        DeleteBtn = New Button()
        UpdateBtn = New Button()
        CreateBtn = New Button()
        LogoutBtn = New Button()
        GroupBox2.SuspendLayout()
        CType(InventoryDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(SearchCB)
        GroupBox2.Controls.Add(SearchTxt)
        GroupBox2.Controls.Add(InventoryDataGrid)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(419, 50)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(636, 356)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search"
        ' 
        ' SearchCB
        ' 
        SearchCB.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        SearchCB.DropDownStyle = ComboBoxStyle.DropDownList
        SearchCB.FormattingEnabled = True
        SearchCB.Items.AddRange(New Object() {"ID", "Name", "Price", "Category", "Quantity"})
        SearchCB.Location = New Point(450, 19)
        SearchCB.Name = "SearchCB"
        SearchCB.Size = New Size(180, 27)
        SearchCB.TabIndex = 2
        ' 
        ' SearchTxt
        ' 
        SearchTxt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SearchTxt.Location = New Point(6, 20)
        SearchTxt.Name = "SearchTxt"
        SearchTxt.Size = New Size(438, 26)
        SearchTxt.TabIndex = 1
        ' 
        ' InventoryDataGrid
        ' 
        InventoryDataGrid.AllowUserToAddRows = False
        InventoryDataGrid.AllowUserToDeleteRows = False
        InventoryDataGrid.AllowUserToResizeColumns = False
        InventoryDataGrid.AllowUserToResizeRows = False
        InventoryDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        InventoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        InventoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InventoryDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically
        InventoryDataGrid.Location = New Point(6, 51)
        InventoryDataGrid.Name = "InventoryDataGrid"
        InventoryDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        InventoryDataGrid.RowTemplate.Height = 25
        InventoryDataGrid.Size = New Size(624, 298)
        InventoryDataGrid.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox1.Controls.Add(CategoryCB)
        GroupBox1.Controls.Add(Quantitytxt)
        GroupBox1.Controls.Add(Pricetxt)
        GroupBox1.Controls.Add(Nametxt)
        GroupBox1.Controls.Add(IDtxt)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 50)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(401, 256)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' CategoryCB
        ' 
        CategoryCB.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CategoryCB.DropDownStyle = ComboBoxStyle.DropDownList
        CategoryCB.FormattingEnabled = True
        CategoryCB.Location = New Point(176, 173)
        CategoryCB.Name = "CategoryCB"
        CategoryCB.Size = New Size(208, 27)
        CategoryCB.TabIndex = 5
        ' 
        ' Quantitytxt
        ' 
        Quantitytxt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Quantitytxt.Location = New Point(179, 217)
        Quantitytxt.Name = "Quantitytxt"
        Quantitytxt.Size = New Size(208, 26)
        Quantitytxt.TabIndex = 8
        ' 
        ' Pricetxt
        ' 
        Pricetxt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Pricetxt.Location = New Point(176, 131)
        Pricetxt.Name = "Pricetxt"
        Pricetxt.Size = New Size(208, 26)
        Pricetxt.TabIndex = 6
        ' 
        ' Nametxt
        ' 
        Nametxt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nametxt.Location = New Point(176, 89)
        Nametxt.Name = "Nametxt"
        Nametxt.Size = New Size(208, 26)
        Nametxt.TabIndex = 5
        ' 
        ' IDtxt
        ' 
        IDtxt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        IDtxt.Enabled = False
        IDtxt.Location = New Point(176, 43)
        IDtxt.Name = "IDtxt"
        IDtxt.Size = New Size(208, 26)
        IDtxt.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 19)
        Label5.TabIndex = 4
        Label5.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 19)
        Label4.TabIndex = 3
        Label4.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 19)
        Label3.TabIndex = 2
        Label3.Text = "Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 19)
        Label2.TabIndex = 1
        Label2.Text = "Product Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 19)
        Label1.TabIndex = 0
        Label1.Text = "Product ID"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox3.Controls.Add(ClearBtn)
        GroupBox3.Controls.Add(DeleteBtn)
        GroupBox3.Controls.Add(UpdateBtn)
        GroupBox3.Controls.Add(CreateBtn)
        GroupBox3.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.Location = New Point(12, 312)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(401, 94)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Location = New Point(298, 19)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(86, 68)
        ClearBtn.TabIndex = 3
        ClearBtn.Text = "Clear"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Location = New Point(202, 19)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(86, 68)
        DeleteBtn.TabIndex = 2
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' UpdateBtn
        ' 
        UpdateBtn.Location = New Point(110, 19)
        UpdateBtn.Name = "UpdateBtn"
        UpdateBtn.Size = New Size(86, 68)
        UpdateBtn.TabIndex = 1
        UpdateBtn.Text = "Update"
        UpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' CreateBtn
        ' 
        CreateBtn.Location = New Point(15, 19)
        CreateBtn.Name = "CreateBtn"
        CreateBtn.Size = New Size(86, 68)
        CreateBtn.TabIndex = 0
        CreateBtn.Text = "Create"
        CreateBtn.UseVisualStyleBackColor = True
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LogoutBtn.Location = New Point(969, 12)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(86, 36)
        LogoutBtn.TabIndex = 4
        LogoutBtn.Text = "Log Out"
        LogoutBtn.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1067, 411)
        Controls.Add(LogoutBtn)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Application"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(InventoryDataGrid, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents InventoryDataGrid As DataGridView
    Friend WithEvents ClearBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents CreateBtn As Button
    Friend WithEvents SearchCB As ComboBox
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents Quantitytxt As TextBox
    Friend WithEvents Pricetxt As TextBox
    Friend WithEvents Nametxt As TextBox
    Friend WithEvents IDtxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents CategoryCB As ComboBox
End Class
