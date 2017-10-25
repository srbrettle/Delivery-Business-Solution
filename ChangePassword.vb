Public Class frmChangePass

    Structure LoginType
        <VBFixedString(20)> Dim User As String      '20
        <VBFixedString(20)> Dim Password As String  '20
    End Structure                                   '=40

    Dim Login As LoginType
    Dim FileName As String

    'MENU-STRIP----------------------------------------------------------------------------------------------------------
    Private Sub mnuCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomers.Click
        frmCustomers.Show()                                     'Customers form
        MyBase.Close()
    End Sub

    Private Sub mnuProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProducts.Click
        frmProducts.Show()                                      'Products form
        MyBase.Close()
    End Sub

    Private Sub mnuDeliveries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeliveries.Click
        frmDeliveries.URL = "http://maps.google.com/?ie=UTF8&ll=54.136696,-2.285156&spn=11.706707,42.84668&z=5"
        frmDeliveries.Show()                                    'Deliveries form
        MyBase.Close()
    End Sub

    Private Sub mnuOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrders.Click
        frmOrders.Show()                                        'Orders form
        MyBase.Close()
    End Sub

    Private Sub mnuControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuControl.Click
        frmControl.Show()                                       'Control form
        MyBase.Close()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End                                                     'Exits the program
    End Sub
    '/MENU-STRIP---------------------------------------------------------------------------------------------------------

    'HOTKEYS-------------------------------------------------------------------------------------------------------------
    Private Sub frmChangePass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control And e.KeyCode = Keys.Enter Then            'Ctrl+Enter goes to Control
            mnuControl.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.C Then                'Ctrl+C goes to Customers
            mnuCustomers.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.P Then                'Ctrl+P goes to Products
            mnuProducts.PerformClick()
        End If


        If e.Control And e.KeyCode = Keys.D Then                'Ctrl+D goes to Deliveries
            mnuDeliveries.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.O Then                'Ctrl+O goes to Orders
            mnuOrders.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.X Then                'Ctrl+X goes to Exit
            mnuExit.PerformClick()
        End If

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
    '/HOTKEYS------------------------------------------------------------------------------------------------------------
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Save As Char = "N"

        If txtPass.Text = txtPass2.Text Then                    'password verification
            If txtUser.Text = "" Or txtPass.Text = "" Or txtPass2.Text = "" Then
                Save = "N"
                MessageBox.Show("Please insert Username and Passwords", "Error", MessageBoxButtons.OK)
            Else
                Save = "Y"
            End If
        Else
            Save = "N"
            MessageBox.Show("Password's do not match", "Error", MessageBoxButtons.OK)
        End If

        If Save = "Y" Then
            Login.User = txtUser.Text                           'set user
            Login.Password = txtPass.Text                       'set password

            'save user and password to file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Login))
            FilePut(1, Login.User)
            FilePut(1, Login.Password)
            FileClose(1)

            lblNote.Visible = True
            txtUser.Text = ""
            txtPass.Text = ""
            txtPass2.Text = ""
        End If
    End Sub

    Private Sub frmChangePass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set the filename
        FileName = frmLogin.Drive & "\Settings.txt"
    End Sub

    Private Sub frmChangePassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Not e.Control Then
            If e.KeyCode = Keys.Enter Then
                cmdSave.PerformClick()
            End If
        End If
    End Sub

End Class
