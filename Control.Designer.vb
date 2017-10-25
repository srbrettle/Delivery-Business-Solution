<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmControl
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControl))
        Me.cmdCustomers = New System.Windows.Forms.Button()
        Me.cmdProducts = New System.Windows.Forms.Button()
        Me.cmdOrders = New System.Windows.Forms.Button()
        Me.cmdDeliveries = New System.Windows.Forms.Button()
        Me.picDeliveries = New System.Windows.Forms.PictureBox()
        Me.picOrders = New System.Windows.Forms.PictureBox()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.picProducts = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeliveries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.picHelp = New System.Windows.Forms.PictureBox()
        Me.tmrTimeDown = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picDeliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCustomers
        '
        Me.cmdCustomers.Location = New System.Drawing.Point(103, 169)
        Me.cmdCustomers.Name = "cmdCustomers"
        Me.cmdCustomers.Size = New System.Drawing.Size(75, 23)
        Me.cmdCustomers.TabIndex = 1
        Me.cmdCustomers.Text = "Customers"
        Me.cmdCustomers.UseVisualStyleBackColor = True
        '
        'cmdProducts
        '
        Me.cmdProducts.Location = New System.Drawing.Point(211, 169)
        Me.cmdProducts.Name = "cmdProducts"
        Me.cmdProducts.Size = New System.Drawing.Size(75, 23)
        Me.cmdProducts.TabIndex = 2
        Me.cmdProducts.Text = "Products"
        Me.cmdProducts.UseVisualStyleBackColor = True
        '
        'cmdOrders
        '
        Me.cmdOrders.Location = New System.Drawing.Point(330, 169)
        Me.cmdOrders.Name = "cmdOrders"
        Me.cmdOrders.Size = New System.Drawing.Size(75, 23)
        Me.cmdOrders.TabIndex = 3
        Me.cmdOrders.Text = "Orders"
        Me.cmdOrders.UseVisualStyleBackColor = True
        '
        'cmdDeliveries
        '
        Me.cmdDeliveries.Location = New System.Drawing.Point(212, 368)
        Me.cmdDeliveries.Name = "cmdDeliveries"
        Me.cmdDeliveries.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeliveries.TabIndex = 4
        Me.cmdDeliveries.Text = "Deliveries"
        Me.cmdDeliveries.UseVisualStyleBackColor = True
        '
        'picDeliveries
        '
        Me.picDeliveries.Image = Global.WindowsApplication1.My.Resources.Resources.delivery_icon_with_question_mark
        Me.picDeliveries.Location = New System.Drawing.Point(188, 244)
        Me.picDeliveries.Name = "picDeliveries"
        Me.picDeliveries.Size = New System.Drawing.Size(126, 118)
        Me.picDeliveries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeliveries.TabIndex = 8
        Me.picDeliveries.TabStop = False
        '
        'picOrders
        '
        Me.picOrders.Image = CType(resources.GetObject("picOrders.Image"), System.Drawing.Image)
        Me.picOrders.Location = New System.Drawing.Point(315, 59)
        Me.picOrders.Name = "picOrders"
        Me.picOrders.Size = New System.Drawing.Size(109, 104)
        Me.picOrders.TabIndex = 7
        Me.picOrders.TabStop = False
        '
        'picCustomer
        '
        Me.picCustomer.Image = Global.WindowsApplication1.My.Resources.Resources.customer
        Me.picCustomer.Location = New System.Drawing.Point(94, 45)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(93, 118)
        Me.picCustomer.TabIndex = 6
        Me.picCustomer.TabStop = False
        '
        'picProducts
        '
        Me.picProducts.Image = Global.WindowsApplication1.My.Resources.Resources.logo2
        Me.picProducts.Location = New System.Drawing.Point(193, 45)
        Me.picProducts.Name = "picProducts"
        Me.picProducts.Size = New System.Drawing.Size(113, 118)
        Me.picProducts.TabIndex = 5
        Me.picProducts.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuForms, Me.mnuDeliveries, Me.mnuPassword, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuForms
        '
        Me.mnuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomers, Me.mnuProducts, Me.mnuOrders})
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
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(531, 399)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 538
        Me.LineShape1.Y1 = 210
        Me.LineShape1.Y2 = 210
        '
        'picHelp
        '
        Me.picHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.picHelp.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Help_icon
        Me.picHelp.Location = New System.Drawing.Point(471, 27)
        Me.picHelp.Name = "picHelp"
        Me.picHelp.Size = New System.Drawing.Size(57, 51)
        Me.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHelp.TabIndex = 29
        Me.picHelp.TabStop = False
        '
        'tmrTimeDown
        '
        Me.tmrTimeDown.Interval = 1000
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.picHelp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picDeliveries)
        Me.Controls.Add(Me.picOrders)
        Me.Controls.Add(Me.picCustomer)
        Me.Controls.Add(Me.picProducts)
        Me.Controls.Add(Me.cmdDeliveries)
        Me.Controls.Add(Me.cmdOrders)
        Me.Controls.Add(Me.cmdProducts)
        Me.Controls.Add(Me.cmdCustomers)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.KeyPreview = True
        Me.Name = "frmControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Control"
        CType(Me.picDeliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCustomers As System.Windows.Forms.Button
    Friend WithEvents cmdProducts As System.Windows.Forms.Button
    Friend WithEvents cmdOrders As System.Windows.Forms.Button
    Friend WithEvents cmdDeliveries As System.Windows.Forms.Button
    Friend WithEvents picProducts As System.Windows.Forms.PictureBox
    Friend WithEvents picCustomer As System.Windows.Forms.PictureBox
    Friend WithEvents picOrders As System.Windows.Forms.PictureBox
    Friend WithEvents picDeliveries As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents mnuDeliveries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picHelp As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTimeDown As System.Windows.Forms.Timer
End Class
