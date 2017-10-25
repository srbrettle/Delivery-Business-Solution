Public Class frmControl
    Dim intTimeDown As Integer = 5

    'MENU-STRIP----------------------------------------------------------------------------------------------------------
    Private Sub mnuCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomers.Click
        frmCustomers.Show()                                     'Customers form
        MyBase.Hide()
    End Sub

    Private Sub mnuProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProducts.Click
        frmProducts.Show()                                      'Products form
        MyBase.Hide()
    End Sub

    Private Sub mnuOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrders.Click
        frmOrders.Show()                                        'Orders form
        MyBase.Hide()
    End Sub

    Private Sub mnuDeliveries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeliveries.Click
        frmDeliveries.URL = "http://maps.google.com/?ie=UTF8&ll=54.136696,-2.285156&spn=11.706707,42.84668&z=5"
        frmDeliveries.Show()                                    'Deliveries form
        MyBase.Hide()
    End Sub

    Private Sub mnuPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPassword.Click
        frmChangePass.Show()                                    'Change Password form
        MyBase.Hide()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End                                                     'Exits the program
    End Sub
    '/MENU-STRIP----------------------------------------------------------------------------------------------------------

    'HOTKEYS-------------------------------------------------------------------------------------------------------------
    Private Sub frmControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control And e.KeyCode = Keys.C Then                'Ctrl+C goes to Customers
            mnuCustomers.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.P Then                'Ctrl+P goes to Products
            mnuProducts.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.O Then                'Ctrl+O goes to Orders
            mnuOrders.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.D Then                'Ctrl+D goes to Deliveries
            mnuDeliveries.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.R Then                'Ctrl+R goes to Reset Password
            mnuPassword.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.X Then                'Ctrl+X goes to Exit
            mnuExit.PerformClick()
        End If

        '-Mouse Control via Keyboard //Co-ordination handicap
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

    Private Sub cmdCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomers.Click
        frmCustomers.Show()                                      'Customers form
        MyBase.Hide()
    End Sub

    Private Sub cmdProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProducts.Click
        frmProducts.Show()                                      'Products form
        MyBase.Hide()
    End Sub

    Private Sub cmdOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrders.Click
        frmOrders.Show()                                        'Orders form
        MyBase.Hide()
    End Sub

    Private Sub cmdDeliveries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeliveries.Click
        frmDeliveries.URL = "http://maps.google.com/?ie=UTF8&ll=54.136696,-2.285156&spn=11.706707,42.84668&z=5"
        frmDeliveries.Show()                                    'Deliveries Form

        MyBase.Hide()
    End Sub

    Private Sub picHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHelp.Click
        frmHotkeys.Show()
    End Sub

    Private Sub tmrTimeDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeDown.Tick
        intTimeDown = intTimeDown - 1

        If intTimeDown = 0 Then
            frmHotkeys.Show()
            tmrTimeDown.Enabled = False
        End If

    End Sub
End Class