<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeliveries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpContents = New System.Windows.Forms.GroupBox()
        Me.lstProduct = New System.Windows.Forms.ListBox()
        Me.grpDetatils = New System.Windows.Forms.GroupBox()
        Me.numStock = New System.Windows.Forms.NumericUpDown()
        Me.numID = New System.Windows.Forms.NumericUpDown()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.grpContents.SuspendLayout()
        Me.grpDetatils.SuspendLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mnuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomers, Me.mnuOrders})
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
        'mnuOrders
        '
        Me.mnuOrders.Name = "mnuOrders"
        Me.mnuOrders.Size = New System.Drawing.Size(131, 22)
        Me.mnuOrders.Text = "Orders"
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
        'grpContents
        '
        Me.grpContents.Controls.Add(Me.lstProduct)
        Me.grpContents.Location = New System.Drawing.Point(17, 248)
        Me.grpContents.Name = "grpContents"
        Me.grpContents.Size = New System.Drawing.Size(567, 132)
        Me.grpContents.TabIndex = 41
        Me.grpContents.TabStop = False
        Me.grpContents.Text = "Contents of File"
        '
        'lstProduct
        '
        Me.lstProduct.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.ItemHeight = 14
        Me.lstProduct.Location = New System.Drawing.Point(6, 19)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(555, 102)
        Me.lstProduct.TabIndex = 0
        '
        'grpDetatils
        '
        Me.grpDetatils.Controls.Add(Me.numStock)
        Me.grpDetatils.Controls.Add(Me.numID)
        Me.grpDetatils.Controls.Add(Me.lblCategory)
        Me.grpDetatils.Controls.Add(Me.cboCategory)
        Me.grpDetatils.Controls.Add(Me.txtSupplier)
        Me.grpDetatils.Controls.Add(Me.txtPrice)
        Me.grpDetatils.Controls.Add(Me.txtName)
        Me.grpDetatils.Controls.Add(Me.lblStock)
        Me.grpDetatils.Controls.Add(Me.lblSupplier)
        Me.grpDetatils.Controls.Add(Me.lblPrice)
        Me.grpDetatils.Controls.Add(Me.lblName)
        Me.grpDetatils.Controls.Add(Me.lblID)
        Me.grpDetatils.Location = New System.Drawing.Point(17, 34)
        Me.grpDetatils.Name = "grpDetatils"
        Me.grpDetatils.Size = New System.Drawing.Size(501, 179)
        Me.grpDetatils.TabIndex = 39
        Me.grpDetatils.TabStop = False
        Me.grpDetatils.Text = "Product Details"
        '
        'numStock
        '
        Me.numStock.Location = New System.Drawing.Point(92, 85)
        Me.numStock.Name = "numStock"
        Me.numStock.ReadOnly = True
        Me.numStock.Size = New System.Drawing.Size(172, 20)
        Me.numStock.TabIndex = 5
        '
        'numID
        '
        Me.numID.Location = New System.Drawing.Point(92, 32)
        Me.numID.Name = "numID"
        Me.numID.ReadOnly = True
        Me.numID.Size = New System.Drawing.Size(172, 20)
        Me.numID.TabIndex = 1
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(36, 61)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 12
        Me.lblCategory.Text = "Category"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Pizza", "Side-Dish", "Drink", "Dessert"})
        Me.cboCategory.Location = New System.Drawing.Point(91, 58)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(172, 21)
        Me.cboCategory.TabIndex = 3
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(91, 110)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(172, 20)
        Me.txtSupplier.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(311, 57)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(172, 20)
        Me.txtPrice.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(311, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(172, 20)
        Me.txtName.TabIndex = 2
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(50, 87)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(35, 13)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Stock"
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(40, 113)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(45, 13)
        Me.lblSupplier.TabIndex = 4
        Me.lblSupplier.Text = "Supplier"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(274, 61)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price £"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(270, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(27, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(58, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Product ID"
        '
        'cmdLast
        '
        Me.cmdLast.Location = New System.Drawing.Point(318, 219)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(46, 23)
        Me.cmdLast.TabIndex = 15
        Me.cmdLast.Text = ">>"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(266, 219)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(46, 23)
        Me.cmdNext.TabIndex = 14
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Location = New System.Drawing.Point(214, 219)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(46, 23)
        Me.cmdPrevious.TabIndex = 13
        Me.cmdPrevious.Text = "<"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        Me.cmdFirst.Location = New System.Drawing.Point(162, 219)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(46, 23)
        Me.cmdFirst.TabIndex = 12
        Me.cmdFirst.Text = "<<"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(590, 352)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 18
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(592, 291)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 55)
        Me.cmdReset.TabIndex = 17
        Me.cmdReset.Text = "Reset File - Empty"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(592, 262)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(75, 23)
        Me.cmdView.TabIndex = 16
        Me.cmdView.Text = "View"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(592, 184)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 11
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(592, 155)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 10
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(592, 106)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 43)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save Changes"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(590, 77)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(590, 48)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpContents)
        Me.Controls.Add(Me.grpDetatils)
        Me.Controls.Add(Me.cmdLast)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.cmdFirst)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.Name = "frmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Products"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpContents.ResumeLayout(False)
        Me.grpDetatils.ResumeLayout(False)
        Me.grpDetatils.PerformLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpContents As System.Windows.Forms.GroupBox
    Friend WithEvents lstProduct As System.Windows.Forms.ListBox
    Friend WithEvents grpDetatils As System.Windows.Forms.GroupBox
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cmdLast As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdFirst As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents numID As System.Windows.Forms.NumericUpDown
    Friend WithEvents numStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents mnuDeliveries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
