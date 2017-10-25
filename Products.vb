Public Class frmProducts

    'MENU-STRIP----------------------------------------------------------------------------------------------------------
    Private Sub mnuCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomers.Click
        frmCustomers.Show()                                     'Customers form
        MyBase.Close()
    End Sub

    Private Sub mnuOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrders.Click
        frmOrders.Show()                                        'Orders form
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
    Private Sub frmProducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control And e.KeyCode = Keys.Enter Then            'Ctrl+Enter goes to Control
            mnuControl.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.C Then                'Ctrl+C goes to Customers
            mnuCustomers.PerformClick()
        End If

        If e.Control And e.KeyCode = Keys.O Then                'Ctrl+O goes to Orders
            mnuOrders.PerformClick()
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

    'Record structure for Product File
    Structure ProductType
        <VBFixedString(10)> Dim ID As Integer
        <VBFixedString(20)> Dim Name As String
        <VBFixedString(20)> Dim Category As String
        <VBFixedString(5)> Dim Price As Single
        <VBFixedString(4)> Dim Stock As Integer
        <VBFixedString(20)> Dim Supplier As String
    End Structure

    'Global Variables
    Dim Product As ProductType

    Dim ProductRecord(100) As ProductType          'Array ~ Max: 100
    Dim ArraySize As Integer = 0

    Dim ErrID As Boolean = False        'Validation Errors
    Dim ErrName As Boolean = False
    Dim ErrPrice As Boolean = False
    Dim ErrStock As Boolean = False
    Dim ErrSupplier As Boolean = False

    Dim FileName As String
    Dim NumberofRecords As Integer
    Dim TableFormat As String = "{0,-12}{1,-22}{2,-6}{3,-22}"
    Dim CurrentRec As Integer
    Dim RecordNumber As Integer

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set ID
        numID.Value = Product.ID + 1

        'Set the File Name
        FileName = frmLogin.Drive & "\Product.txt"
        'Open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
        'Check the number of records
        NumberofRecords = LOF(1) / Len(Product)
        'Close the file
        FileClose(1)

        If NumberofRecords > 0 Then
            'Display first record
            CurrentRec = 1
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
            FileGet(1, Product)
            numID.Text = Trim(Product.ID)
            txtName.Text = Trim(Product.Name)
            cboCategory.Text = Trim(Product.Category)
            txtPrice.Text = Trim(Product.Price)
            numStock.Text = Trim(Product.Stock)
            txtSupplier.Text = Trim(Product.Supplier)
            'Close the file
            FileClose()
        End If
        CurrentRec = 1

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim blnContinue As Boolean
        Dim Duplicate As Boolean = False
        Dim largestID As Integer = 0

        'HIGHEST ID VALUE
        'Open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
        'Search the Product
        Do While Not EOF(1)
            FileGet(1, Product)
            If Product.ID > largestID Then
                largestID = Product.ID
            End If
        Loop
        FileClose(1)
        '/HIGHEST ID VALUE

        If numID.Value = (largestID + 1) Then
            If txtName.Text = "" Or cboCategory.Text = "" Or txtPrice.Text = "" Or _
                            numStock.Text = "" Or txtSupplier.Text = "" Then
                MessageBox.Show("Input all fields", "Error", MessageBoxButtons.OK)
            Else
                blnContinue = True
            End If
        Else
            MessageBox.Show("ID must be 1 more than the Number of Records (" & largestID & "), Change automatically?", "Error", MessageBoxButtons.OKCancel)
            If vbOK Then
                numID.Value = largestID + 1
            End If
        End If

        Duplicate = False

        If blnContinue = True Then
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))

            '<------CHECK PRODUCT NOT ALREADY PRESENT----->
            'Search the Product

            Do While Duplicate = False And Not EOF(1)
                FileGet(1, Product)
                If (Trim(Product.Name) = txtName.Text) And (Trim(Product.Supplier) = txtSupplier.Text) Then
                    MessageBox.Show("Product already exists", "Message", MessageBoxButtons.OK)
                    Duplicate = True
                Else
                    Duplicate = False
                End If
            Loop
            FileClose(1)
            '<-------------------/CHECK------------------->
            If Not Duplicate = True Then
                'Get the data from the form
                Product.ID = numID.Text
                Product.Name = txtName.Text
                Product.Category = cboCategory.Text
                Product.Price = txtPrice.Text
                Product.Stock = numStock.Text
                Product.Supplier = txtSupplier.Text

                'Open the file
                FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
                'Write record to file
                FilePut(1, Product, NumberofRecords + 1)
                'Close the file
                FileClose(1)
                'Add 1 to the number of records
                NumberofRecords = NumberofRecords + 1
                'Clear the form
                txtName.Text = ""
                cboCategory.Text = ""
                txtPrice.Text = ""
                numStock.Value = 0
                txtSupplier.Text = ""

                numID.Value = numID.Value + 1
                'Place cursor in Product Name text box
                txtName.Focus()
            End If
        End If

    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        'ARRAY
        'Load Array
        Dim NextRec As Integer = 1
        Dim i As Integer = -1
        ' Read the Product records and add them to the array
        FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
        Do While Not EOF(1)
            i = i + 1
            FileGet(1, Product, NextRec)
            ProductRecord(i).ID = Trim(Product.ID)
            ProductRecord(i).Name = Trim(Product.Name)
            ProductRecord(i).Supplier = Trim(Product.Supplier)
            ProductRecord(i).Stock = Trim(Product.Stock)
            NextRec = NextRec + 1

        Loop
        FileClose(1)
        ArraySize = i
        'Sort Array
        Dim TmpProduct As ProductType
        For x = 0 To ArraySize - 1
            For y = 0 To ArraySize - 1
                If ProductRecord(y).Name > ProductRecord(y + 1).Name Then
                    TmpProduct = ProductRecord(y)
                    ProductRecord(y) = ProductRecord(y + 1)
                    ProductRecord(y + 1) = TmpProduct
                End If
            Next
        Next
        'View Array
        lstProduct.Items.Clear()
        'Headings
        lstProduct.Items.Add(String.Format(TableFormat, "ID", "Name", "Stock", "Supplier"))
        ' Read through the array and add to the List box
        For i = 0 To ArraySize
            lstProduct.Items.Add(String.Format(TableFormat, ProductRecord(i).ID, ProductRecord(i).Name, ProductRecord(i).Stock, ProductRecord(i).Supplier))
        Next

    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If CurrentRec < NumberofRecords Then
            RecordNumber = CurrentRec + 1
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
            'Get record
            FileGet(1, Product, RecordNumber)
            'Display record
            numID.Text = Trim(Product.ID)
            txtName.Text = Trim(Product.Name)
            cboCategory.Text = Trim(Product.Category)
            txtPrice.Text = Trim(Product.Price)
            numStock.Text = Trim(Product.Stock)
            txtSupplier.Text = Trim(Product.Supplier)
            'Close file
            FileClose()
            CurrentRec = CurrentRec + 1
        End If
    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        If CurrentRec > 1 Then
            RecordNumber = CurrentRec - 1
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
            'Get record
            FileGet(1, Product, RecordNumber)
            'Display record
            numID.Text = Trim(Product.ID)
            txtName.Text = Trim(Product.Name)
            cboCategory.Text = Trim(Product.Category)
            txtPrice.Text = Trim(Product.Price)
            numStock.Text = Trim(Product.Stock)
            txtSupplier.Text = Trim(Product.Supplier)
            'Close file
            FileClose()
            CurrentRec = RecordNumber
        Else
            RecordNumber = CurrentRec
        End If

    End Sub

    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        If NumberofRecords > 1 Then
            'Display the first record
            CurrentRec = 1
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
            'Get first record
            FileGet(1, Product)
            'Display record
            numID.Text = Trim(Product.ID)
            txtName.Text = Trim(Product.Name)
            cboCategory.Text = Trim(Product.Category)
            txtPrice.Text = Trim(Product.Price)
            numStock.Text = Trim(Product.Stock)
            txtSupplier.Text = Trim(Product.Supplier)
            'Close file
            FileClose()
        End If
    End Sub

    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        If NumberofRecords > 0 Then
            'Display the last record
            RecordNumber = NumberofRecords
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
            'Get last record
            FileGet(1, Product, RecordNumber)
            'Display record
            numID.Text = Trim(Product.ID)
            txtName.Text = Trim(Product.Name)
            cboCategory.Text = Trim(Product.Category)
            txtPrice.Text = Trim(Product.Price)
            numStock.Text = Trim(Product.Stock)
            txtSupplier.Text = Trim(Product.Supplier)
            'Close file
            FileClose()
            CurrentRec = NumberofRecords
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Dim msg, title, style As String
        Dim Response As MsgBoxResult

        msg = "Do you want to reset this file?"
        title = "Check"
        style = MsgBoxStyle.YesNo
        'Display message box
        Response = MsgBox(msg, style, title)
        'If yes delete
        If Response = MsgBoxResult.Yes Then
            'Delete the file
            Kill(FileName)
            'Set the file name
            FileName = frmLogin.Drive & "\Product.txt"
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
            'Check the number of records
            NumberofRecords = LOF(1) / Len(Product)
            'Close the file
            FileClose()
            'Reset current record
            CurrentRec = 1
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        numID.Value = NumberofRecords + 1
        txtName.Text = ""
        cboCategory.Text = ""
        txtPrice.Text = ""
        numStock.Value = 0
        txtSupplier.Text = ""
        txtName.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'Open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
        'Get details from the form record
        Product.ID = numID.Text
        Product.Name = txtName.Text
        Product.Category = cboCategory.Text
        Product.Price = txtPrice.Text
        Product.Stock = numStock.Text
        Product.Supplier = txtSupplier.Text
        'Save record
        FilePut(1, Product, CurrentRec)
        'Close file
        FileClose(1)
        MessageBox.Show("Product details saved.", "Message", MessageBoxButtons.OK)

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'Local Variables
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult
        Dim TempFileName As String
        Dim Number As String

        msg = "Do you want to delete this record?"
        title = "Check"
        style = MsgBoxStyle.YesNo
        'Display message box
        Response = MsgBox(msg, style, title)
        'If yes  delete
        If Response = MsgBoxResult.Yes Then
            'Get record number
            Number = numID.Text
            'Set temporary file
            TempFileName = frmLogin.Drive & "\Temp.txt"
            'Open Product file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Product))
            'Open temp file
            FileOpen(2, TempFileName, OpenMode.Random, , , Len(Product))
            Do While Not EOF(1)
                FileGet(1, Product)
                If Product.ID <> Number Then
                    FilePut(2, Product)
                End If
            Loop
            'Close Product File
            FileClose(1)
            'Close Temp File
            FileClose(2)
            'Delete Product File
            Kill(FileName)
            'Rename Temp File as Product File
            Rename(TempFileName, FileName)
            'Previous Product
            Call cmdPrevious_Click(sender, e)

        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Print
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
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
        e.Graphics.DrawString("▒▒          Products          ▒▒", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒", MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'blank line
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Product Details:"
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Product ID: " & numID.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Product Name: " & txtName.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Category: " & cboCategory.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight


        'build the line to be printed
        DLine = "Price: " & txtPrice.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Stock: " & numStock.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Supplier: " & txtSupplier.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight
    End Sub

    'VALIDATION
    Private Sub numID_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numID.Validating
        'Validation
        If Not IsNumeric(numID.Text) = True Or numID.Text = "" Then
            ErrorProvider1.SetError(numID, "Must Contain a Number")
            ErrID = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(numID, "")
            ErrID = False
            If ErrID = False And ErrName = False And ErrPrice = False And _
                ErrStock = False And ErrSupplier = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub txtName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        'Validation
        If txtName.Text = "" Then
            ErrorProvider1.SetError(txtName, "Must Contain Product Name")
            ErrName = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(txtName, "")
            ErrName = False
            If ErrID = False And ErrName = False And ErrPrice = False And _
                ErrStock = False And ErrSupplier = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub txtPrice_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
        'Validation
        If IsNumeric(txtPrice.Text) = False Or txtPrice.Text = "" Then
            ErrorProvider1.SetError(txtPrice, "Must Contain a Number")
            ErrPrice = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(txtPrice, "")
            ErrPrice = False
            If ErrID = False And ErrName = False And ErrPrice = False And _
                ErrStock = False And ErrSupplier = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub numStock_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numStock.Validating
        'Validation
        If Not IsNumeric(numStock.Text) = True Or numStock.Text = "" Then
            ErrorProvider1.SetError(numStock, "Must Contain a Number")
            ErrStock = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(numStock, "")
            ErrStock = False
            If ErrID = False And ErrName = False And ErrPrice = False And _
                ErrStock = False And ErrSupplier = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub txtSupplier_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSupplier.Validating
        'Validation
        If txtSupplier.Text = "" Then
            ErrorProvider1.SetError(txtSupplier, "Must Contain Supplier Name")
            ErrSupplier = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(txtSupplier, "")
            ErrSupplier = False
            If ErrID = False And ErrName = False And ErrPrice = False And _
                ErrStock = False And ErrSupplier = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub
End Class