Public Class frmOrders

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
        frmDeliveries.Show()                                    'Deliveries form
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
    '/MENU-STRIP---------------------------------------------------------------------------------------------------------

    'HOTKEYS-------------------------------------------------------------------------------------------------------------
    Private Sub frmOrders_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

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
            frmDeliveries.URL = "http://maps.google.com/?ie=UTF8&ll=54.136696,-2.285156&spn=11.706707,42.84668&z=5"
            mnuDeliveries.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.R Then                'Ctrl+R goes to Reset Password
            mnuPassword.PerformClick()
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


    'Record structure for Customer File
    Structure CustomerType
        <VBFixedString(10)> Dim ID As Integer
        <VBFixedString(20)> Dim Name As String
        <VBFixedString(4)> Dim HouseNumber As Integer
        <VBFixedString(20)> Dim Street As String
        <VBFixedString(20)> Dim Town As String
        <VBFixedString(8)> Dim PCode As String
        <VBFixedString(12)> Dim Phone As String
        <VBFixedString(30)> Dim Email As String
    End Structure

    'Record structure for Product File
    Structure ProductType
        <VBFixedString(10)> Dim ID As Integer
        <VBFixedString(20)> Dim Name As String
        <VBFixedString(20)> Dim Category As String
        <VBFixedString(5)> Dim Price As Single
        <VBFixedString(4)> Dim Stock As Integer
        <VBFixedString(20)> Dim Supplier As String
    End Structure

    'Record structure for Order File
    Structure OrderType
        <VBFixedString(10)> Dim ID As Integer
        <VBFixedString(10)> Dim CustomerID As Integer
        <VBFixedString(10)> Dim ProductID As Integer
        <VBFixedString(3)> Dim Quantity As Integer
        <VBFixedString(10)> Dim PreVAT As Single
        <VBFixedString(10)> Dim PostVAT As Single
        <VBFixedString(10)> Dim OrderDate As String
        <VBFixedString(10)> Dim DeliveryDate As String
        <VBFixedString(5)> Dim DeliveryTime As String
    End Structure

    'Public Variables
    Public Go As Boolean = False

    'Global Variables
    Dim Product As ProductType
    Dim Customer As CustomerType
    Dim Order As OrderType

    '-Add
    Dim AddSelectedProduct As String
    Dim AddSelectedCustomer As String

    '-lstProduct
    Dim ProductSelected As String

    '-Files
    Dim CustomerFilename As String = frmLogin.Drive & "\Customer.txt"
    Dim CustomerNumberOfRecords As Integer
    Dim ProductFilename As String = frmLogin.Drive & "\Product.txt"
    Dim ProductNumberOfRecords As Integer
    Dim OrderFileName As String = frmLogin.Drive & "\Order.txt"
    Dim OrderNumberOfRecords As Integer

    Private Sub frmOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lstOrder.ForeColor = Color.DodgerBlue
        lstOrder.Items.Add("Select a Product")

        Order.ID = 0
        'PRODUCTS------------------------------------------------------------------------------------------
        'Clear Product list box
        lstProduct.Items.Clear()
        'Open the file
        FileOpen(1, ProductFilename, OpenMode.Random, , , Len(Product))
        'Check the number of records in the file
        ProductNumberOfRecords = LOF(1) / Len(Product)
        'Add the Product IDs to the Product list box
        Do While Not EOF(1)
            FileGet(1, Product)
            lstProduct.Items.Add(Product.ID & ": " & Product.Name)
        Loop
        'Close file
        FileClose(1)

        'Customer File ----------------------------------------------------------
        'Open file
        FileOpen(3, CustomerFilename, OpenMode.Random, , , Len(Customer))
        'Check no of records
        CustomerNumberOfRecords = LOF(3) / Len(Customer)
        Do While Not EOF(3)
            FileGet(3, Customer)
            lstCustomer.Items.Add(Customer.ID & ": " & Customer.Name)
        Loop
        'Close file
        FileClose(3)

        'Display the date
        lblDate.Text = Today

    End Sub

    Private Sub lstProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProduct.SelectedIndexChanged
        Dim CustName As String = ""
        lstOrder.ForeColor = Color.Black

        'Remove all text except Product ID ~~> (": Product.Name")
        If lstProduct.Text.Contains(":") Then
            ProductSelected = lstProduct.Text.Substring(0, lstProduct.Text.LastIndexOf(":"))
        End If

        'Open Product file - search for Product details
        FileOpen(1, ProductFilename, OpenMode.Random, , , Len(Product))
        'Search the Product
        Do While Not EOF(1)
            FileGet(1, Product)
            If Product.ID = ProductSelected Then
                'display Product details
                txtPName.Text = Trim(Product.Name)
                cboCategory.Text = Trim(Product.Category)
                txtPrice.Text = Trim(Product.Price)
                txtStock.Text = Trim(Product.Stock)
            End If
        Loop
        'Close file
        FileClose(1)

        'clear Order list listbox  
        lstOrder.Items.Clear()
        'open Order list file
        FileOpen(2, OrderFileName, OpenMode.Random, , , Len(Order))
        'search for Customers on Product
        Do While Not EOF(2)
            FileGet(2, Order)
            '-----------------------------------------------------------------
            'Open Customer file - search for Customer details
            FileOpen(3, CustomerFilename, OpenMode.Random, , , Len(Customer))
            'Search the Customer
            Do While Not EOF(3)
                FileGet(3, Customer)
                If Customer.ID = Order.CustomerID Then
                    'set CustName
                    CustName = Customer.Name
                End If
            Loop
            'Close file
            FileClose(3)
            '-----------------------------------------------------------------
            If Order.ProductID = ProductSelected Then
                'add Customer to the Product list
                lstOrder.Items.Add(Order.ID & ":" & Order.CustomerID & "-" & CustName)
            End If
        Loop
        'Close file
        FileClose(2)
    End Sub

    Private Sub lstOrder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOrder.SelectedIndexChanged
        Dim CustomerSelected As String = ""
        Dim i As Integer

        If lstOrder.Text.Contains(":") Then
            'Remove all text except Customer ID ~~> ("Product.ID:")
            For i = Len(lstOrder.Text) To 1 Step -1
                If Mid(lstOrder.Text, i, 1) = ":" Then
                    Exit For
                Else
                    CustomerSelected = Mid(lstOrder.Text, i, 1) & CustomerSelected
                End If
            Next i

        End If

        Trim(CustomerSelected)

        If CustomerSelected.Contains("-") Then
            CustomerSelected = CustomerSelected.Substring(0, CustomerSelected.IndexOf("-"))
        End If

        If Not CustomerSelected = "" Then
            'Open Customer file - search for Customer details
            FileOpen(3, CustomerFilename, OpenMode.Random, , , Len(Customer))
            'Search the Customer
            Do While Not EOF(3)
                FileGet(3, Customer)
                If Customer.ID = CustomerSelected Then
                    'display Customer details
                    txtCName.Text = Trim(Customer.Name)
                    txtAddress.Text = Trim(Customer.HouseNumber) & ", " & Trim(Customer.Street) & ", " & Trim(Customer.Town) & ", " & Trim(Customer.PCode)
                    txtPhone.Text = Trim(Customer.Phone)
                    txtEmail.Text = Trim(Customer.Email)
                End If
            Loop
            'Close file
            FileClose(3)
        End If
    End Sub

    Private Sub lstCustomer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCustomer.SelectedIndexChanged
        Dim CustomerSelected As String = ""

        If Not lstCustomer.Text = "" Then
            'Remove all text except Customer ID ~~> (": Customer.Name")
            If lstCustomer.Text.Contains(":") Then
                CustomerSelected = lstCustomer.Text.Substring(0, lstCustomer.Text.LastIndexOf(":"))
            End If

            'Open Customers file - search for Customer details
            FileOpen(3, CustomerFilename, OpenMode.Random, , , Len(Customer))
            'Search the Customers
            Do While Not EOF(3)
                FileGet(3, Customer)
                If Customer.ID = CustomerSelected Then
                    'display Customer details
                    txtCName.Text = Trim(Customer.Name)
                    txtAddress.Text = Trim(Customer.HouseNumber) & ", " & Trim(Customer.Street) & ", " & Trim(Customer.Town) & ", " & Trim(Customer.PCode)
                    txtPhone.Text = Trim(Customer.Phone)
                    txtEmail.Text = Trim(Customer.Email)

                    'Deliveries Mapping
                    frmDeliveries.numHouseNumber.Value = Trim(Customer.HouseNumber)
                    frmDeliveries.txtStreet.Text = Trim(Customer.Street)
                    frmDeliveries.txtTown.Text = Trim(Customer.Town)
                    frmDeliveries.txtPCode.Text = Trim(Customer.PCode)
                End If
            Loop
            'Close file
            FileClose(3)

        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim CustName As String

        If Go = False And Not lstCustomer.SelectedItem = "" And Not lstProduct.SelectedItem = "" Then
            'Check if Product and Customer selected
            AddSelectedProduct = lstProduct.Text.Substring(0, lstProduct.Text.LastIndexOf(":"))
            AddSelectedCustomer = lstCustomer.Text.Substring(0, lstCustomer.Text.LastIndexOf(":"))

            If AddSelectedProduct = "" Or AddSelectedCustomer = "" Then
                MessageBox.Show("You must select a Product and a Customer", "Message", MessageBoxButtons.OK)
            Else
                frmOrderDetails.Show()
            End If

        Else
            'Add record to Product list file
            FileOpen(2, OrderFileName, OpenMode.Random, , , Len(Order))
            OrderNumberOfRecords = LOF(2) / Len(Order)
            Order.CustomerID = AddSelectedCustomer
            Order.ProductID = AddSelectedProduct
            Order.Quantity = frmOrderDetails.Quantity
            Order.OrderDate = frmOrderDetails.OrderDate
            Order.DeliveryDate = frmOrderDetails.DeliveryDate
            Order.DeliveryTime = frmOrderDetails.DeliveryTime
            '<---------------------Stock
            FileOpen(1, ProductFilename, OpenMode.Random, , , Len(Product))
            'Get record
            FileGet(1, Product, AddSelectedProduct)
            If frmOrderDetails.Quantity < Product.Stock Then
                Product.ID = AddSelectedProduct
                Product.Stock = Product.Stock - frmOrderDetails.Quantity
                Order.PreVAT = Product.Price * frmOrderDetails.Quantity
                Order.PostVAT = Order.PreVAT + (Order.PreVAT * 0.175) 'PreVAT + 17.5% of PreVAT
                FilePut(1, Product, Product.ID)
                FileClose(1)
                txtStock.Text = Product.Stock
                '/Stock-------------------->
                Order.ID = Order.ID + 1
                FilePut(2, Order, OrderNumberOfRecords + 1)
                FileClose(2)

                'Refresh the Order list
                lstOrder.Items.Clear()
                'open Order list file
                FileOpen(2, OrderFileName, OpenMode.Random, , , Len(Order))
                'search for Customers on Product
                Do While Not EOF(2)
                    FileGet(2, Order)
                    '-----------------------------------------------------------------
                    'Open Customer file - search for Customer details
                    FileOpen(3, CustomerFilename, OpenMode.Random, , , Len(Customer))
                    'Search the Customer
                    Do While Not EOF(3)
                        FileGet(3, Customer)
                        If Customer.ID = Order.CustomerID Then
                            'set CustName
                            CustName = Customer.Name
                        End If
                    Loop
                    'Close file
                    FileClose(3)
                    '-----------------------------------------------------------------
                    If Order.ProductID = ProductSelected Then
                        'add Customer to the Product list
                        lstOrder.Items.Add(Order.ID & ":" & Order.CustomerID & "-" & CustName)
                    End If
                Loop
                'Close file
                FileClose(2)
            Else
                MessageBox.Show("Quantity Requested larger than available stock", "Error", MessageBoxButtons.OK)
                'Close file
                FileClose(1)
                FileClose(2)
                frmOrderDetails.Quantity = "1"
            End If
            Go = False
            frmOrderDetails.Close()
        End If

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'Local Variables
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult
        Dim TempFileName As String
        Dim Number As Integer = Order.ID
        Dim CustName As String
        Dim CustomerSelected

        '------------------------------------------------------------------------------------------------------
        'open Order list file
        FileOpen(2, OrderFileName, OpenMode.Random, , , Len(Order))
        'search for Customers on Product
        Do While Not EOF(2)
            FileGet(2, Order)
            '-----------------------------------------------------------------
            'Remove all text except Customer ID ~~> ("Product.ID:")
            For i = Len(lstOrder.Text) To 1 Step -1
                If Mid(lstOrder.Text, i, 1) = ":" Then
                    Exit For
                Else
                    CustomerSelected = Mid(lstOrder.Text, i, 1) & CustomerSelected
                End If
            Next i
            Trim(CustomerSelected)
            CustomerSelected = CustomerSelected.Substring(0, CustomerSelected.IndexOf("-"))
            If Order.CustomerID = CustomerSelected Then
                Number = Order.ID
            End If
        Loop
        '-----------------------------------------------------------------
        'Close file
        FileClose(2)
        '------------------------------------------------------------------------------------------------------

        msg = "Do you want to delete this record?"
        title = "Check"
        style = MsgBoxStyle.YesNo
        'Display message box
        Response = MsgBox(msg, style, title)
        'If yes delete
        If Response = MsgBoxResult.Yes Then
            lstOrder.ClearSelected()
            'Set temporary file
            TempFileName = "Temp.txt"
            'Open Product file
            FileOpen(3, OrderFileName, OpenMode.Random, , , Len(Order))
            'Open temp file
            FileOpen(4, TempFileName, OpenMode.Random, , , Len(Order))
            Do While Not EOF(3)
                FileGet(3, Order)
                If Order.ID <> Number Then
                    FilePut(4, Order)
                End If
            Loop
            'Close Product File
            FileClose(3)
            'Close Temp File
            FileClose(4)
            'Delete Product File
            Kill(OrderFileName)
            'Rename Temp File as Product File
            Rename(TempFileName, OrderFileName)

            'clear Order list listbox  
            lstOrder.Items.Clear()
            'open Order list file
            FileOpen(2, OrderFileName, OpenMode.Random, , , Len(Order))
            'search for Customers on Product
            Do While Not EOF(2)
                FileGet(2, Order)
                '-----------------------------------------------------------------
                'Open Customer file - search for Customer details
                FileOpen(3, CustomerFilename, OpenMode.Random, , , Len(Customer))
                'Search the Customer
                Do While Not EOF(3)
                    FileGet(3, Customer)
                    If Customer.ID = Order.CustomerID Then
                        'set CustName
                        CustName = Customer.Name
                    End If
                Loop
                'Close file
                FileClose(3)
                '-----------------------------------------------------------------
                If Order.ProductID = ProductSelected Then
                    'add Customer to the Product list
                    lstOrder.Items.Add(Order.ID & ":" & Order.CustomerID & "-" & CustName)
                End If
            Loop
            'Close file
            FileClose(2)
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Print
        If Not lstOrder.SelectedItem = "" Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Else
            MessageBox.Show("Please Select an order", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim CustID As Integer
        Dim ProdID As Integer
        Dim x, y, FontHeight As Integer
        Dim MyFont As New Font("Calibri", 14, FontStyle.Regular)
        'display variable
        Dim DLine As String


        'calc font height
        FontHeight = MyFont.GetHeight(e.Graphics)
        'set x and y
        x = 50
        y = 50
        'print height
        e.Graphics.DrawString("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("▒▒            Order            ▒▒", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒", MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'blank line
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'PRODUCT DETAILS-----------------------------------------------
        'Open Product file - search for Product details
        FileOpen(1, ProductFilename, OpenMode.Random, , , Len(Product))
        'Search the Product
        Do While Not EOF(1)
            FileGet(1, Product)
            If Trim(Product.Name) = txtPName.Text Then
                ProdID = Product.ID

                'build the line to be printed
                DLine = "PRODUCT DETAILS:"

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Product ID: " & Trim(Product.ID)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Product Name: " & Trim(Product.Name)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Category: " & Trim(Product.Category)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Price: " & Trim(Product.Price)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Stock: " & Trim(Product.Stock)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Supplier: " & Trim(Product.Supplier)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'blank line
                e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
                y = y + FontHeight

            End If
        Loop
        'Close file
        FileClose(1)
        '/PRODUCT DETAILS----------------------------------------------

        'CUSTOMER DETAILS----------------------------------------------
        'Open Customers file - search for Product details
        FileOpen(3, CustomerFilename, OpenMode.Random, , , Len(Customer))
        'Search the Customers
        Do While Not EOF(3)
            FileGet(3, Customer)
            If Trim(Customer.Name) = txtCName.Text Then
                CustID = Trim(Customer.ID)

                'build the line to be printed
                DLine = "CUSTOMER DETAILS:"

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Customer ID: " & Trim(Customer.ID)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Customer Name: " & Trim(Customer.Name)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Address: " & Trim(Customer.HouseNumber) & ", " & Trim(Customer.Street) & ", " & Trim(Customer.Town) & ", " & Trim(Customer.PCode)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Phone: " & Trim(Customer.Phone)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Email: " & Trim(Customer.Email)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'blank line
                e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
                y = y + FontHeight

            End If
        Loop
        'Close file
        FileClose(3)
        '/CUSTOMER DETAILS---------------------------------------------

        'ORDER DETAILS-------------------------------------------------
        'Open Order list file
        FileOpen(2, OrderFileName, OpenMode.Random, , , Len(Order))
        'Search for Customers on Product
        Do While Not EOF(2)
            FileGet(2, Order)
            If (Order.CustomerID = CustID) And (Order.ProductID = ProdID) Then

                'build the line to be printed
                DLine = "ORDER DETAILS:"

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Order ID: " & Trim(Order.ID)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Customer ID: " & Trim(Order.CustomerID)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Product ID: " & Trim(Order.ProductID)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Quantity: " & Trim(Order.Quantity)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Pre VAT: " & FormatCurrency(Trim(Order.PreVAT))

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Post VAT: " & FormatCurrency(Trim(Order.PostVAT))

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Order Date: " & Trim(Order.OrderDate)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Delivery Date: " & Trim(Order.DeliveryDate)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'build the line to be printed
                DLine = "Delivery Time: " & Trim(Order.DeliveryTime)

                'print line
                e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
                y = y + FontHeight

                'blank line
                e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
                y = y + FontHeight

            End If
        Loop
        'Close file
        FileClose(2)
        '/ORDER DETAILS------------------------------------------------


    End Sub

    Private Sub cmdMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMap.Click
        Try
            Dim Address = frmDeliveries.numHouseNumber.Text.Replace(" ", "+") & "+" & frmDeliveries.txtStreet.Text.Replace(" ", "+") & "+" & frmDeliveries.txtTown.Text.Replace(" ", "+") & "+" & frmDeliveries.txtPCode.Text.Replace(" ", "+")
            frmDeliveries.URL = ("http://maps.google.co.uk/maps?q=" & Address)
            'Bring up Map
            frmDeliveries.webMap.Navigate(frmDeliveries.URL)
            frmDeliveries.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")
        End Try
    End Sub

    Private Sub cmdRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoute.Click
        Try
            Dim Address = frmDeliveries.numHouseNumber.Text.Replace(" ", "+") & "+" & frmDeliveries.txtStreet.Text.Replace(" ", "+") & "+" & frmDeliveries.txtTown.Text.Replace(" ", "+") & "+" & frmDeliveries.txtPCode.Text.Replace(" ", "+")
            frmDeliveries.URL = ("http://maps.google.com/maps?f=d" & "&saddr=cardiff" & "&daddr=" & Address)
            'Bring up Map
            frmDeliveries.webMap.Navigate(frmDeliveries.URL)
            frmDeliveries.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")
        End Try
    End Sub

End Class