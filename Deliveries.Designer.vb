<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeliveries
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitMaps = New System.Windows.Forms.SplitContainer()
        Me.cmdRoute = New System.Windows.Forms.Button()
        Me.cmdMap = New System.Windows.Forms.Button()
        Me.txtPCode = New System.Windows.Forms.TextBox()
        Me.numHouseNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblPCode = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.webMap = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.splitMaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMaps.Panel1.SuspendLayout()
        Me.splitMaps.Panel2.SuspendLayout()
        Me.splitMaps.SuspendLayout()
        CType(Me.numHouseNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuForms, Me.mnuPassword, Me.mnuControl, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(922, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuForms
        '
        Me.mnuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomers, Me.mnuProducts, Me.mnuOrders})
        Me.mnuForms.Name = "mnuForms"
        Me.mnuForms.Size = New System.Drawing.Size(60, 20)
        Me.mnuForms.Text = "Forms..."
        '
        'mnuCustomers
        '
        Me.mnuCustomers.Name = "mnuCustomers"
        Me.mnuCustomers.Size = New System.Drawing.Size(136, 22)
        Me.mnuCustomers.Text = "Customers"
        '
        'mnuProducts
        '
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(136, 22)
        Me.mnuProducts.Text = "Products"
        '
        'mnuOrders
        '
        Me.mnuOrders.Name = "mnuOrders"
        Me.mnuOrders.Size = New System.Drawing.Size(136, 22)
        Me.mnuOrders.Text = "Orders"
        '
        'mnuPassword
        '
        Me.mnuPassword.Name = "mnuPassword"
        Me.mnuPassword.Size = New System.Drawing.Size(96, 20)
        Me.mnuPassword.Text = "Reset Password"
        '
        'mnuControl
        '
        Me.mnuControl.Name = "mnuControl"
        Me.mnuControl.Size = New System.Drawing.Size(54, 20)
        Me.mnuControl.Text = "Control"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'splitMaps
        '
        Me.splitMaps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMaps.Location = New System.Drawing.Point(0, 24)
        Me.splitMaps.Name = "splitMaps"
        Me.splitMaps.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitMaps.Panel1
        '
        Me.splitMaps.Panel1.Controls.Add(Me.cmdRoute)
        Me.splitMaps.Panel1.Controls.Add(Me.cmdMap)
        Me.splitMaps.Panel1.Controls.Add(Me.txtPCode)
        Me.splitMaps.Panel1.Controls.Add(Me.numHouseNumber)
        Me.splitMaps.Panel1.Controls.Add(Me.lblPCode)
        Me.splitMaps.Panel1.Controls.Add(Me.lblStreet)
        Me.splitMaps.Panel1.Controls.Add(Me.lblTown)
        Me.splitMaps.Panel1.Controls.Add(Me.lblHouseNumber)
        Me.splitMaps.Panel1.Controls.Add(Me.txtStreet)
        Me.splitMaps.Panel1.Controls.Add(Me.txtTown)
        '
        'splitMaps.Panel2
        '
        Me.splitMaps.Panel2.Controls.Add(Me.webMap)
        Me.splitMaps.Size = New System.Drawing.Size(922, 493)
        Me.splitMaps.SplitterDistance = 96
        Me.splitMaps.TabIndex = 3
        '
        'cmdRoute
        '
        Me.cmdRoute.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRoute.Location = New System.Drawing.Point(262, 66)
        Me.cmdRoute.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRoute.Name = "cmdRoute"
        Me.cmdRoute.Size = New System.Drawing.Size(131, 22)
        Me.cmdRoute.TabIndex = 43
        Me.cmdRoute.Text = "Route"
        Me.cmdRoute.UseVisualStyleBackColor = True
        '
        'cmdMap
        '
        Me.cmdMap.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMap.Location = New System.Drawing.Point(125, 65)
        Me.cmdMap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMap.Name = "cmdMap"
        Me.cmdMap.Size = New System.Drawing.Size(131, 22)
        Me.cmdMap.TabIndex = 42
        Me.cmdMap.Text = "Map"
        Me.cmdMap.UseVisualStyleBackColor = True
        '
        'txtPCode
        '
        Me.txtPCode.Location = New System.Drawing.Point(283, 38)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(172, 20)
        Me.txtPCode.TabIndex = 19
        '
        'numHouseNumber
        '
        Me.numHouseNumber.Location = New System.Drawing.Point(63, 12)
        Me.numHouseNumber.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numHouseNumber.Name = "numHouseNumber"
        Me.numHouseNumber.Size = New System.Drawing.Size(172, 20)
        Me.numHouseNumber.TabIndex = 15
        '
        'lblPCode
        '
        Me.lblPCode.AutoSize = True
        Me.lblPCode.Location = New System.Drawing.Point(238, 41)
        Me.lblPCode.Name = "lblPCode"
        Me.lblPCode.Size = New System.Drawing.Size(39, 13)
        Me.lblPCode.TabIndex = 21
        Me.lblPCode.Text = "PCode"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(242, 14)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(35, 13)
        Me.lblStreet.TabIndex = 14
        Me.lblStreet.Text = "Street"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(23, 41)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(34, 13)
        Me.lblTown.TabIndex = 18
        Me.lblTown.Text = "Town"
        '
        'lblHouseNumber
        '
        Me.lblHouseNumber.AutoSize = True
        Me.lblHouseNumber.Location = New System.Drawing.Point(9, 14)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(48, 13)
        Me.lblHouseNumber.TabIndex = 20
        Me.lblHouseNumber.Text = "House #"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(283, 11)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(172, 20)
        Me.txtStreet.TabIndex = 16
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(63, 38)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(172, 20)
        Me.txtTown.TabIndex = 17
        '
        'webMap
        '
        Me.webMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webMap.Location = New System.Drawing.Point(0, 0)
        Me.webMap.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webMap.Name = "webMap"
        Me.webMap.Size = New System.Drawing.Size(922, 393)
        Me.webMap.TabIndex = 0
        '
        'frmDeliveries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(922, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.splitMaps)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.Name = "frmDeliveries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Deliveries"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.splitMaps.Panel1.ResumeLayout(False)
        Me.splitMaps.Panel1.PerformLayout()
        Me.splitMaps.Panel2.ResumeLayout(False)
        CType(Me.splitMaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMaps.ResumeLayout(False)
        CType(Me.numHouseNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents splitMaps As System.Windows.Forms.SplitContainer
    Friend WithEvents webMap As System.Windows.Forms.WebBrowser
    Friend WithEvents txtPCode As System.Windows.Forms.TextBox
    Friend WithEvents numHouseNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPCode As System.Windows.Forms.Label
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblHouseNumber As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents cmdRoute As System.Windows.Forms.Button
    Friend WithEvents cmdMap As System.Windows.Forms.Button
End Class
