<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotkeys
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
        Me.lblTxt = New System.Windows.Forms.Label()
        Me.picHotKeys = New System.Windows.Forms.PictureBox()
        CType(Me.picHotKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTxt
        '
        Me.lblTxt.AutoSize = True
        Me.lblTxt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxt.Location = New System.Drawing.Point(220, 27)
        Me.lblTxt.Name = "lblTxt"
        Me.lblTxt.Size = New System.Drawing.Size(0, 19)
        Me.lblTxt.TabIndex = 0
        '
        'picHotKeys
        '
        Me.picHotKeys.Image = Global.WindowsApplication1.My.Resources.Resources.keybr
        Me.picHotKeys.Location = New System.Drawing.Point(12, 199)
        Me.picHotKeys.Name = "picHotKeys"
        Me.picHotKeys.Size = New System.Drawing.Size(540, 157)
        Me.picHotKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHotKeys.TabIndex = 1
        Me.picHotKeys.TabStop = False
        '
        'frmHotkeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 368)
        Me.Controls.Add(Me.picHotKeys)
        Me.Controls.Add(Me.lblTxt)
        Me.Name = "frmHotkeys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Hotkeys"
        CType(Me.picHotKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTxt As System.Windows.Forms.Label
    Friend WithEvents picHotKeys As System.Windows.Forms.PictureBox
End Class
