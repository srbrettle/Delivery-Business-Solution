Public Class frmLogin

    'MOUSE---------------------------------------------------------------------------------------------------------------
    Private Sub frmOrders_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '-Mouse Control via Keyboard
        If e.Control And e.KeyCode = Keys.Left Then 'Ctrl+Left Moves Cursor Left
            Cursor.Position = New Point(Cursor.Position.X - 10, Cursor.Position.Y)
        End If
        If e.Control And e.KeyCode = Keys.Right Then 'Ctrl+Right Moves Cursor Right
            Cursor.Position = New Point(Cursor.Position.X + 10, Cursor.Position.Y)
        End If
        If e.Control And e.KeyCode = Keys.Up Then 'Ctrl+Up Moves Cursor Up
            Cursor.Position = New Point(Cursor.Position.X, Cursor.Position.Y - 10)
        End If
        If e.Control And e.KeyCode = Keys.Down Then 'Ctrl+Down Moves Cursor Down
            Cursor.Position = New Point(Cursor.Position.X, Cursor.Position.Y + 10)
        End If
    End Sub
    '/MOUSE--------------------------------------------------------------------------------------------------------------

    Dim Count As Integer = 0
    Public Drive As String = "C:\Slice\"

    Structure LoginType
        <VBFixedString(20)> Dim User As String  '20
        <VBFixedString(20)> Dim Password As String  '20
    End Structure                           '=40

    Dim Login As LoginType
    Dim FileName As String
    Dim TableFormat As String = "{0,-20}{1,-20}"

    Dim User As String
    Dim Password As String

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'set the filename
        FileName = Drive & "\Settings.txt"
        'open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Login))
        'check the user and pass in file
        Do While Not EOF(1)
            FileGet(1, Login.User)
            FileGet(1, Login.Password)
        Loop
        'close the file
        FileClose(1)

        User = Login.User
        Password = Login.Password
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim Unlock As Boolean

        'Unlocks application
        If txtUser.Text = User And txtPass.Text = Password Then         'Usual access details
            Unlock = True
            imgUnlock.Visible = True
            imgLock.Visible = False
            tmrCorrect.Enabled = True

            'Debug
            Debug.Print(vbNewLine & "Access Granted")

        ElseIf txtUser.Text = "Admin" And txtPass.Text = "abc123" Then  'Allows entry for Administrator if usual password forgotten
            Unlock = True
            imgUnlock.Visible = True
            imgLock.Visible = False
            tmrCorrect.Enabled = True

            'Debug
            Debug.Print(vbNewLine & "Access Granted")

        Else                                                            'Failed Login
            Count = Count + 1
            imgUnlock.Visible = False
            imgLock.Visible = True
            lblCount.Text = Count
            MessageBox.Show("Username or Password Incorrect", "Message", MessageBoxButtons.OK)
        End If

        'Closes Program
        If Count = 3 Then
            End
        End If

    End Sub

    Private Sub tmrCorrect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCorrect.Tick
        'Debug
        Debug.Print("Entering Control Interface")

        'Shows password protected application
        frmSplash.Show()
        MyBase.Hide()
        tmrCorrect.Enabled = False
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogin.PerformClick()
        End If
    End Sub

End Class
