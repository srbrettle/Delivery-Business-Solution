<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.tmrCorrect = New System.Windows.Forms.Timer(Me.components)
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.imgUnlock = New System.Windows.Forms.PictureBox()
        Me.imgLock = New System.Windows.Forms.PictureBox()
        CType(Me.imgUnlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(244, 8)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(13, 13)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "0"
        '
        'cmdLogin
        '
        Me.cmdLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLogin.BackColor = System.Drawing.Color.IndianRed
        Me.cmdLogin.Location = New System.Drawing.Point(9, 170)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(248, 23)
        Me.cmdLogin.TabIndex = 10
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(9, 87)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(56, 13)
        Me.lblUser.TabIndex = 11
        Me.lblUser.Text = "Username"
        '
        'lblPass
        '
        Me.lblPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(9, 128)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "Password"
        '
        'tmrCorrect
        '
        Me.tmrCorrect.Interval = 500
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtUser.Location = New System.Drawing.Point(12, 103)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(245, 20)
        Me.txtUser.TabIndex = 7
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPass.Location = New System.Drawing.Point(12, 144)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(245, 20)
        Me.txtPass.TabIndex = 9
        '
        'imgUnlock
        '
        Me.imgUnlock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgUnlock.Image = Global.WindowsApplication1.My.Resources.Resources.Unlocked
        Me.imgUnlock.Location = New System.Drawing.Point(101, 11)
        Me.imgUnlock.Name = "imgUnlock"
        Me.imgUnlock.Size = New System.Drawing.Size(75, 72)
        Me.imgUnlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUnlock.TabIndex = 13
        Me.imgUnlock.TabStop = False
        Me.imgUnlock.Visible = False
        '
        'imgLock
        '
        Me.imgLock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgLock.Image = Global.WindowsApplication1.My.Resources.Resources.Locked
        Me.imgLock.Location = New System.Drawing.Point(101, 11)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.Size = New System.Drawing.Size(75, 72)
        Me.imgLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLock.TabIndex = 12
        Me.imgLock.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(267, 205)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.imgUnlock)
        Me.Controls.Add(Me.imgLock)
        Me.KeyPreview = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Login"
        CType(Me.imgUnlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents imgUnlock As System.Windows.Forms.PictureBox
    Friend WithEvents imgLock As System.Windows.Forms.PictureBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents tmrCorrect As System.Windows.Forms.Timer
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox

End Class
