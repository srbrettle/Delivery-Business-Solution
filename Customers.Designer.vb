<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeliveries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpContents = New System.Windows.Forms.GroupBox()
        Me.lstCustomer = New System.Windows.Forms.ListBox()
        Me.grpDetatils = New System.Windows.Forms.GroupBox()
        Me.txtPCode = New System.Windows.Forms.TextBox()
        Me.lblPCode = New System.Windows.Forms.Label()
        Me.numHouseNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.numID = New System.Windows.Forms.NumericUpDown()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
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
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.grpContents.SuspendLayout()
        Me.grpDetatils.SuspendLayout()
        CType(Me.numHouseNumber, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mnuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProducts, Me.mnuOrders})
        Me.mnuForms.Name = "mnuForms"
        Me.mnuForms.Size = New System.Drawing.Size(61, 20)
        Me.mnuForms.Text = "Forms..."
        '
        'mnuProducts
        '
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(121, 22)
        Me.mnuProducts.Text = "Products"
        '
        'mnuOrders
        '
        Me.mnuOrders.Name = "mnuOrders"
        Me.mnuOrders.Size = New System.Drawing.Size(121, 22)
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
        Me.grpContents.Controls.Add(Me.lstCustomer)
        Me.grpContents.Location = New System.Drawing.Point(17, 248)
        Me.grpContents.Name = "grpContents"
        Me.grpContents.Size = New System.Drawing.Size(567, 132)
        Me.grpContents.TabIndex = 27
        Me.grpContents.TabStop = False
        Me.grpContents.Text = "Contents of File"
        '
        'lstCustomer
        '
        Me.lstCustomer.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustomer.FormattingEnabled = True
        Me.lstCustomer.ItemHeight = 14
        Me.lstCustomer.Location = New System.Drawing.Point(6, 19)
        Me.lstCustomer.Name = "lstCustomer"
        Me.lstCustomer.Size = New System.Drawing.Size(555, 102)
        Me.lstCustomer.TabIndex = 0
        '
        'grpDetatils
        '
        Me.grpDetatils.Controls.Add(Me.txtPCode)
        Me.grpDetatils.Controls.Add(Me.lblPCode)
        Me.grpDetatils.Controls.Add(Me.numHouseNumber)
        Me.grpDetatils.Controls.Add(Me.lblHouseNumber)
        Me.grpDetatils.Controls.Add(Me.numID)
        Me.grpDetatils.Controls.Add(Me.txtTown)
        Me.grpDetatils.Controls.Add(Me.txtEmail)
        Me.grpDetatils.Controls.Add(Me.txtPhone)
        Me.grpDetatils.Controls.Add(Me.txtStreet)
        Me.grpDetatils.Controls.Add(Me.txtName)
        Me.grpDetatils.Controls.Add(Me.lblEmail)
        Me.grpDetatils.Controls.Add(Me.lblTown)
        Me.grpDetatils.Controls.Add(Me.lblPhone)
        Me.grpDetatils.Controls.Add(Me.lblStreet)
        Me.grpDetatils.Controls.Add(Me.lblName)
        Me.grpDetatils.Controls.Add(Me.lblID)
        Me.grpDetatils.Location = New System.Drawing.Point(17, 34)
        Me.grpDetatils.Name = "grpDetatils"
        Me.grpDetatils.Size = New System.Drawing.Size(508, 179)
        Me.grpDetatils.TabIndex = 25
        Me.grpDetatils.TabStop = False
        Me.grpDetatils.Text = "Customer Details"
        '
        'txtPCode
        '
        Me.txtPCode.Location = New System.Drawing.Point(311, 84)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(172, 20)
        Me.txtPCode.TabIndex = 6
        '
        'lblPCode
        '
        Me.lblPCode.AutoSize = True
        Me.lblPCode.Location = New System.Drawing.Point(266, 87)
        Me.lblPCode.Name = "lblPCode"
        Me.lblPCode.Size = New System.Drawing.Size(39, 13)
        Me.lblPCode.TabIndex = 13
        Me.lblPCode.Text = "PCode"
        '
        'numHouseNumber
        '
        Me.numHouseNumber.Location = New System.Drawing.Point(91, 58)
        Me.numHouseNumber.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numHouseNumber.Name = "numHouseNumber"
        Me.numHouseNumber.Size = New System.Drawing.Size(172, 20)
        Me.numHouseNumber.TabIndex = 3
        '
        'lblHouseNumber
        '
        Me.lblHouseNumber.AutoSize = True
        Me.lblHouseNumber.Location = New System.Drawing.Point(37, 60)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(48, 13)
        Me.lblHouseNumber.TabIndex = 11
        Me.lblHouseNumber.Text = "House #"
        '
        'numID
        '
        Me.numID.Location = New System.Drawing.Point(91, 32)
        Me.numID.Name = "numID"
        Me.numID.ReadOnly = True
        Me.numID.Size = New System.Drawing.Size(172, 20)
        Me.numID.TabIndex = 1
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(91, 84)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(172, 20)
        Me.txtTown.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(91, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(172, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(91, 110)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(172, 20)
        Me.txtPhone.TabIndex = 7
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(311, 57)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(172, 20)
        Me.txtStreet.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(311, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(172, 20)
        Me.txtName.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(53, 139)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(51, 87)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(34, 13)
        Me.lblTown.TabIndex = 6
        Me.lblTown.Text = "Town"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(47, 113)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(270, 60)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(35, 13)
        Me.lblStreet.TabIndex = 2
        Me.lblStreet.Text = "Street"
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
        Me.lblID.Location = New System.Drawing.Point(20, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(65, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Customer ID"
        '
        'cmdLast
        '
        Me.cmdLast.Location = New System.Drawing.Point(318, 219)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(46, 23)
        Me.cmdLast.TabIndex = 20
        Me.cmdLast.Text = ">>"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(266, 219)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(46, 23)
        Me.cmdNext.TabIndex = 19
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Location = New System.Drawing.Point(214, 219)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(46, 23)
        Me.cmdPrevious.TabIndex = 18
        Me.cmdPrevious.Text = "<"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        Me.cmdFirst.Location = New System.Drawing.Point(162, 219)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(46, 23)
        Me.cmdFirst.TabIndex = 17
        Me.cmdFirst.Text = "<<"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(590, 352)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 16
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(592, 291)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 55)
        Me.cmdReset.TabIndex = 15
        Me.cmdReset.Text = "Reset File - Empty"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(592, 262)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(75, 23)
        Me.cmdView.TabIndex = 14
        Me.cmdView.Text = "View"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(592, 184)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 13
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(592, 155)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(592, 106)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 43)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Save Changes"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(590, 77)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(590, 48)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 9
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
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
        'PrintDocument1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCustomers
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
        Me.Name = "frmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Customers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpContents.ResumeLayout(False)
        Me.grpDetatils.ResumeLayout(False)
        Me.grpDetatils.PerformLayout()
        CType(Me.numHouseNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpContents As System.Windows.Forms.GroupBox
    Friend WithEvents lstCustomer As System.Windows.Forms.ListBox
    Friend WithEvents grpDetatils As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblStreet As System.Windows.Forms.Label
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
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtPCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPCode As System.Windows.Forms.Label
    Friend WithEvents numHouseNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHouseNumber As System.Windows.Forms.Label
    Friend WithEvents numID As System.Windows.Forms.NumericUpDown
    Friend WithEvents mnuDeliveries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
