Public Class frmDeliveries
    'MENU-STRIP----------------------------------------------------------------------------------------------------------
    Private Sub mnuCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomers.Click
        frmCustomers.Show()                                     'Customers form
        MyBase.Close()
    End Sub

    Private Sub mnuProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProducts.Click
        frmProducts.Show()                                      'Products form
        MyBase.Close()
    End Sub

    Private Sub mnuOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrders.Click
        frmOrders.Show()                                        'Orders form
        MyBase.Close()
    End Sub

    Private Sub mnuPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPassword.Click
        frmChangePass.Show()                                    'Change Password form
        MyBase.Close()
    End Sub

    Private Sub mnuControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuControl.Click
        frmControl.Show()                                       'Control form
        MyBase.Close()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End                                                     'Exits the program
    End Sub
    '/MENU-STRIP----------------------------------------------------------------------------------------------------------

    'HOTKEYS-------------------------------------------------------------------------------------------------------------
    Private Sub frmDeliveries_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.Enter Then        'Ctrl+Enter goes to Control
            mnuControl.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.C Then                'Ctrl+C goes to Customers
            mnuCustomers.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.P Then                'Ctrl+P goes to Products
            mnuProducts.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.O Then                'Ctrl+O goes to Orders
            mnuOrders.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.R Then                'Ctrl+R goes to Reset Password
            mnuPassword.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.X Then                'Ctrl+X goes to Exit
            mnuExit.PerformClick()
        End If

        If e.KeyCode = Keys.Enter Then                          'Enter Runs Mapping Feature
            cmdMap.PerformClick()
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

    Public URL As String

    Private Sub frmDeliveries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Maximize
        Me.WindowState = FormWindowState.Maximized

        'Bring up Map
        webMap.Navigate(URL)
    End Sub

    Private Sub cmdMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMap.Click
        Try
            Dim Address = numHouseNumber.Text.Replace(" ", "+") & "+" & txtStreet.Text.Replace(" ", "+") & "+" & txtTown.Text.Replace(" ", "+") & "+" & txtPCode.Text.Replace(" ", "+")
            URL = ("http://maps.google.co.uk/maps?q=" & Address)
            'Bring up Map
            webMap.Navigate(URL)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")
        End Try
    End Sub

    Private Sub cmdRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoute.Click
        Try
            Dim Address = numHouseNumber.Text.Replace(" ", "+") & "+" & txtStreet.Text.Replace(" ", "+") & "+" & txtTown.Text.Replace(" ", "+") & "+" & txtPCode.Text.Replace(" ", "+")
            URL = ("http://maps.google.com/maps?f=d" & "&saddr=cardiff" & "&daddr=" & Address)
            'Bring up Map
            webMap.Navigate(URL)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")
        End Try
    End Sub
End Class