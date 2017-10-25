<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderDetails
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
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.lblDeliveryTime = New System.Windows.Forms.Label()
        Me.lblDeliveryDate = New System.Windows.Forms.Label()
        Me.datDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.datOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.datDeliveryTime = New System.Windows.Forms.DateTimePicker()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(37, 15)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Quantity"
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(24, 41)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(59, 13)
        Me.lblOrderDate.TabIndex = 14
        Me.lblOrderDate.Text = "Order Date"
        '
        'lblDeliveryTime
        '
        Me.lblDeliveryTime.AutoSize = True
        Me.lblDeliveryTime.Location = New System.Drawing.Point(12, 93)
        Me.lblDeliveryTime.Name = "lblDeliveryTime"
        Me.lblDeliveryTime.Size = New System.Drawing.Size(71, 13)
        Me.lblDeliveryTime.TabIndex = 12
        Me.lblDeliveryTime.Text = "Delivery Time"
        '
        'lblDeliveryDate
        '
        Me.lblDeliveryDate.AutoSize = True
        Me.lblDeliveryDate.Location = New System.Drawing.Point(12, 67)
        Me.lblDeliveryDate.Name = "lblDeliveryDate"
        Me.lblDeliveryDate.Size = New System.Drawing.Size(71, 13)
        Me.lblDeliveryDate.TabIndex = 11
        Me.lblDeliveryDate.Text = "Delivery Date"
        '
        'datDeliveryDate
        '
        Me.datDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datDeliveryDate.Location = New System.Drawing.Point(89, 64)
        Me.datDeliveryDate.Name = "datDeliveryDate"
        Me.datDeliveryDate.Size = New System.Drawing.Size(207, 20)
        Me.datDeliveryDate.TabIndex = 19
        '
        'datOrderDate
        '
        Me.datOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datOrderDate.Location = New System.Drawing.Point(89, 38)
        Me.datOrderDate.Name = "datOrderDate"
        Me.datOrderDate.Size = New System.Drawing.Size(207, 20)
        Me.datOrderDate.TabIndex = 20
        '
        'cmdContinue
        '
        Me.cmdContinue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdContinue.BackColor = System.Drawing.Color.IndianRed
        Me.cmdContinue.Location = New System.Drawing.Point(40, 116)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.Size = New System.Drawing.Size(248, 23)
        Me.cmdContinue.TabIndex = 22
        Me.cmdContinue.Text = "Continue"
        Me.cmdContinue.UseVisualStyleBackColor = False
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(89, 12)
        Me.numQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(207, 20)
        Me.numQuantity.TabIndex = 23
        Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'datDeliveryTime
        '
        Me.datDeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datDeliveryTime.Location = New System.Drawing.Point(89, 89)
        Me.datDeliveryTime.Name = "datDeliveryTime"
        Me.datDeliveryTime.ShowUpDown = True
        Me.datDeliveryTime.Size = New System.Drawing.Size(207, 20)
        Me.datDeliveryTime.TabIndex = 24
        '
        'frmOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.datDeliveryTime)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.cmdContinue)
        Me.Controls.Add(Me.datOrderDate)
        Me.Controls.Add(Me.datDeliveryDate)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblDeliveryTime)
        Me.Controls.Add(Me.lblDeliveryDate)
        Me.Name = "frmOrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Order Details"
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblOrderDate As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryTime As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryDate As System.Windows.Forms.Label
    Friend WithEvents datDeliveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents datOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdContinue As System.Windows.Forms.Button
    Friend WithEvents numQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents datDeliveryTime As System.Windows.Forms.DateTimePicker
End Class
