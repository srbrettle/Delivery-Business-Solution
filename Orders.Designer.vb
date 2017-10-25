<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrders))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeliveries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdRoute = New System.Windows.Forms.Button()
        Me.cmdMap = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lstCustomer = New System.Windows.Forms.ListBox()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.lblCName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.grpDetatils = New System.Windows.Forms.GroupBox()
        Me.lstOrder = New System.Windows.Forms.ListBox()
        Me.lstProduct = New System.Windows.Forms.ListBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblPName = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpDetatils.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuForms, Me.mnuDeliveries, Me.mnuPassword, Me.mnuControl, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuForms
        '
        Me.mnuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomers, Me.mnuProducts})
        Me.mnuForms.Name = "mnuForms"
        Me.mnuForms.Size = New System.Drawing.Size(61, 20)
        Me.mnuForms.Text = "Forms..."
        '
        'mnuCustomers
        '
        Me.mnuCustomers.Name = "mnuCustomers"
        Me.mnuCustomers.Size = New System.Drawing.Size(131, 22)
        Me.mnuCustomers.Text = "Customers"
        '
        'mnuProducts
        '
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(131, 22)
        Me.mnuProducts.Text = "Products"
        '
        'mnuDeliveries
        '
        Me.mnuDeliveries.Name = "mnuDeliveries"
        Me.mnuDeliveries.Size = New System.Drawing.Size(69, 20)
        Me.mnuDeliveries.Text = "Deliveries"
        '
        'mnuPassword
        '
        Me.mnuPassword.Name = "mnuPassword"
        Me.mnuPassword.Size = New System.Drawing.Size(100, 20)
        Me.mnuPassword.Text = "Reset Password"
        '
        'mnuControl
        '
        Me.mnuControl.Name = "mnuControl"
        Me.mnuControl.Size = New System.Drawing.Size(59, 20)
        Me.mnuControl.Text = "Control"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(499, 3)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 41
        Me.lblDate.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRoute)
        Me.GroupBox1.Controls.Add(Me.cmdMap)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.lstCustomer)
        Me.GroupBox1.Controls.Add(Me.txtCName)
        Me.GroupBox1.Controls.Add(Me.lblCName)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 179)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'cmdRoute
        '
        Me.cmdRoute.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRoute.Location = New System.Drawing.Point(430, 146)
        Me.cmdRoute.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRoute.Name = "cmdRoute"
        Me.cmdRoute.Size = New System.Drawing.Size(131, 22)
        Me.cmdRoute.TabIndex = 44
        Me.cmdRoute.Text = "Route"
        Me.cmdRoute.UseVisualStyleBackColor = True
        '
        'cmdMap
        '
        Me.cmdMap.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMap.Location = New System.Drawing.Point(430, 116)
        Me.cmdMap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMap.Name = "cmdMap"
        Me.cmdMap.Size = New System.Drawing.Size(131, 22)
        Me.cmdMap.TabIndex = 43
        Me.cmdMap.Text = "Map"
        Me.cmdMap.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(255, 80)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(139, 20)
        Me.txtPhone.TabIndex = 10
        '
        'lstCustomer
        '
        Me.lstCustomer.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustomer.FormattingEnabled = True
        Me.lstCustomer.ItemHeight = 14
        Me.lstCustomer.Location = New System.Drawing.Point(6, 19)
        Me.lstCustomer.Name = "lstCustomer"
        Me.lstCustomer.Size = New System.Drawing.Size(159, 144)
        Me.lstCustomer.TabIndex = 8
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(254, 28)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.ReadOnly = True
        Me.txtCName.Size = New System.Drawing.Size(207, 20)
        Me.txtCName.TabIndex = 9
        '
        'lblCName
        '
        Me.lblCName.AutoSize = True
        Me.lblCName.Location = New System.Drawing.Point(213, 31)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(35, 13)
        Me.lblCName.TabIndex = 8
        Me.lblCName.Text = "Name"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(253, 106)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(139, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(254, 54)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(207, 20)
        Me.txtAddress.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(215, 109)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(211, 83)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(203, 57)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'grpDetatils
        '
        Me.grpDetatils.Controls.Add(Me.lstOrder)
        Me.grpDetatils.Controls.Add(Me.lstProduct)
        Me.grpDetatils.Controls.Add(Me.cboCategory)
        Me.grpDetatils.Controls.Add(Me.txtPrice)
        Me.grpDetatils.Controls.Add(Me.txtStock)
        Me.grpDetatils.Controls.Add(Me.txtPName)
        Me.grpDetatils.Controls.Add(Me.lblStock)
        Me.grpDetatils.Controls.Add(Me.lblPrice)
        Me.grpDetatils.Controls.Add(Me.lblCategory)
        Me.grpDetatils.Controls.Add(Me.lblPName)
        Me.grpDetatils.Location = New System.Drawing.Point(57, 19)
        Me.grpDetatils.Name = "grpDetatils"
        Me.grpDetatils.Size = New System.Drawing.Size(570, 179)
        Me.grpDetatils.TabIndex = 46
        Me.grpDetatils.TabStop = False
        Me.grpDetatils.Text = "Product Details"
        '
        'lstOrder
        '
        Me.lstOrder.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.ItemHeight = 14
        Me.lstOrder.Location = New System.Drawing.Point(402, 20)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(159, 144)
        Me.lstOrder.TabIndex = 7
        '
        'lstProduct
        '
        Me.lstProduct.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.ItemHeight = 14
        Me.lstProduct.Location = New System.Drawing.Point(6, 20)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(159, 144)
        Me.lstProduct.TabIndex = 0
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Pizza", "Side-Dish", "Drink", "Dessert"})
        Me.cboCategory.Location = New System.Drawing.Point(255, 60)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(138, 21)
        Me.cboCategory.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(254, 87)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(138, 20)
        Me.txtPrice.TabIndex = 6
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(255, 113)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(139, 20)
        Me.txtStock.TabIndex = 4
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(254, 34)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.ReadOnly = True
        Me.txtPName.Size = New System.Drawing.Size(138, 20)
        Me.txtPName.TabIndex = 2
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(213, 116)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(35, 13)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Stock"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(217, 90)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price £"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(200, 63)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "Category"
        '
        'lblPName
        '
        Me.lblPName.AutoSize = True
        Me.lblPName.Location = New System.Drawing.Point(213, 37)
        Me.lblPName.Name = "lblPName"
        Me.lblPName.Size = New System.Drawing.Size(35, 13)
        Me.lblPName.TabIndex = 1
        Me.lblPName.Text = "Name"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(546, 204)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(81, 23)
        Me.cmdExit.TabIndex = 45
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(383, 204)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(157, 23)
        Me.cmdPrint.TabIndex = 44
        Me.cmdPrint.Text = "Print Order"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(220, 204)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(157, 23)
        Me.cmdDelete.TabIndex = 43
        Me.cmdDelete.Text = "Remove Order"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(57, 204)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(157, 23)
        Me.cmdAdd.TabIndex = 42
        Me.cmdAdd.Text = "Add Order"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lstCourses
        '
        Me.lstCourses.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.ItemHeight = 14
        Me.lstCourses.Location = New System.Drawing.Point(6, 20)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(159, 144)
        Me.lstCourses.TabIndex = 0
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpDetatils)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.Name = "frmOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Orders"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDetatils.ResumeLayout(False)
        Me.grpDetatils.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeliveries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstCustomer As System.Windows.Forms.ListBox
    Friend WithEvents txtCName As System.Windows.Forms.TextBox
    Friend WithEvents lblCName As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents grpDetatils As System.Windows.Forms.GroupBox
    Friend WithEvents lstOrder As System.Windows.Forms.ListBox
    Friend WithEvents lstProduct As System.Windows.Forms.ListBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtPName As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblPName As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents lstCourses As System.Windows.Forms.ListBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cmdMap As System.Windows.Forms.Button
    Friend WithEvents cmdRoute As System.Windows.Forms.Button
End Class
