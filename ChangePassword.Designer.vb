<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePass
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
        Me.lblNote = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeliveries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.lblPass2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblNote.Location = New System.Drawing.Point(41, 119)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(144, 19)
        Me.lblNote.TabIndex = 11
        Me.lblNote.Text = "Password Set/Reset"
        Me.lblNote.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(191, 50)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(60, 66)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(125, 20)
        Me.txtPass.TabIndex = 9
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(9, 63)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(45, 23)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "Pass"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(60, 40)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(125, 20)
        Me.txtUser.TabIndex = 7
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(8, 36)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(46, 23)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "User"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuForms, Me.mnuDeliveries, Me.mnuControl, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(276, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuForms
        '
        Me.mnuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomers, Me.mnuProducts, Me.mnuOrders})
        Me.mnuForms.Name = "mnuForms"
        Me.mnuForms.Size = New System.Drawing.Size(48, 20)
        Me.mnuForms.Text = "Forms"
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
        'mnuDeliveries
        '
        Me.mnuDeliveries.Name = "mnuDeliveries"
        Me.mnuDeliveries.Size = New System.Drawing.Size(65, 20)
        Me.mnuDeliveries.Text = "Deliveries"
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
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(60, 92)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(125, 20)
        Me.txtPass2.TabIndex = 10
        '
        'lblPass2
        '
        Me.lblPass2.AutoSize = True
        Me.lblPass2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass2.Location = New System.Drawing.Point(9, 89)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(45, 23)
        Me.lblPass2.TabIndex = 13
        Me.lblPass2.Text = "Pass"
        '
        'frmChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 147)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPass2)
        Me.Controls.Add(Me.lblPass2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.KeyPreview = True
        Me.Name = "frmChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Password Change"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPass2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPass2 As System.Windows.Forms.Label
    Friend WithEvents mnuControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeliveries As System.Windows.Forms.ToolStripMenuItem
End Class
