Public Class frmHotkeys

    'HOTKEYS-------------------------------------------------------------------------------------------------------------
    Private Sub frmControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control And e.Control AndAlso e.KeyCode = Keys.Enter Then        'Ctrl+Enter goes to Control
            frmControl.Show()
            Me.Close()
        End If

        If e.Control And e.KeyCode = Keys.C Then                'Ctrl+C goes to Customers
            frmCustomers.Show()
            Me.Close()
        End If

        If e.Control And e.KeyCode = Keys.P Then                'Ctrl+P goes to Products
            frmProducts.Show()
            Me.Close()
        End If

        If e.Control And e.KeyCode = Keys.O Then                'Ctrl+O goes to Orders
            frmOrders.Show()
            Me.Close()
        End If

        If e.Control And e.KeyCode = Keys.D Then                'Ctrl+D goes to Deliveries
            frmDeliveries.URL = "http://maps.google.com/?ie=UTF8&ll=54.136696,-2.285156&spn=11.706707,42.84668&z=5"
            frmDeliveries.Show()
            Me.Close()
        End If

        If e.Control And e.KeyCode = Keys.R Then                'Ctrl+R goes to Reset Password
            frmChangePass.Show()
            Me.Close()
        End If

        If e.Control And e.KeyCode = Keys.X Then                'Ctrl+X goes to Exit
            Me.Close()
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

    Private Sub frmHotkeys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTxt.Text = My.Resources.HKeyHelp.ToString    'Show .txt file from resources
    End Sub
End Class