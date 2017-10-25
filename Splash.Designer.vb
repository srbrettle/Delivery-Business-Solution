<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.tmrEndSplash = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSplashChange = New System.Windows.Forms.Timer(Me.components)
        Me.picSplash2 = New System.Windows.Forms.PictureBox()
        Me.picSplash = New System.Windows.Forms.PictureBox()
        CType(Me.picSplash2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrEndSplash
        '
        Me.tmrEndSplash.Enabled = True
        Me.tmrEndSplash.Interval = 2000
        '
        'tmrSplashChange
        '
        Me.tmrSplashChange.Enabled = True
        Me.tmrSplashChange.Interval = 1500
        '
        'picSplash2
        '
        Me.picSplash2.Image = CType(resources.GetObject("picSplash2.Image"), System.Drawing.Image)
        Me.picSplash2.Location = New System.Drawing.Point(0, 0)
        Me.picSplash2.Name = "picSplash2"
        Me.picSplash2.Size = New System.Drawing.Size(623, 404)
        Me.picSplash2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSplash2.TabIndex = 0
        Me.picSplash2.TabStop = False
        Me.picSplash2.Visible = False
        '
        'picSplash
        '
        Me.picSplash.Image = Global.WindowsApplication1.My.Resources.Resources.hv_logo_wallpaper_1600x1200
        Me.picSplash.Location = New System.Drawing.Point(0, 0)
        Me.picSplash.Name = "picSplash"
        Me.picSplash.Size = New System.Drawing.Size(623, 404)
        Me.picSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSplash.TabIndex = 1
        Me.picSplash.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.picSplash)
        Me.Controls.Add(Me.picSplash2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A Slice of the Action: Splash"
        CType(Me.picSplash2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrEndSplash As System.Windows.Forms.Timer
    Friend WithEvents picSplash2 As System.Windows.Forms.PictureBox
    Friend WithEvents picSplash As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSplashChange As System.Windows.Forms.Timer
End Class
