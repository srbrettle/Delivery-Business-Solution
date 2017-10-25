Public Class frmCustomers

    'MENU-STRIP----------------------------------------------------------------------------------------------------------
    Private Sub mnuProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProducts.Click
        frmProducts.Show()                                      'Products form
        MyBase.Close()
    End Sub

    Private Sub mnuOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrders.Click
        frmOrders.Show()                                        'Orders form
        MyBase.Close()
    End Sub

    Private Sub mnuDeliveries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeliveries.Click
        frmDeliveries.URL = "http://maps.google.com/?ie=UTF8&ll=54.136696,-2.285156&spn=11.706707,42.84668&z=5"
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
    '/MENU-STRIP----------------------------------------------------------------------------------------------------------

    'HOTKEYS-------------------------------------------------------------------------------------------------------------
    Private Sub frmCustomers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.Enter Then        'Ctrl+Enter goes to Control
            mnuControl.PerformClick()
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

    'Global Variables
    Dim Customer As CustomerType

    Dim ErrID As Boolean = False        'Validation Errors
    Dim ErrName As Boolean = False
    Dim ErrHouseNumber As Boolean = False
    Dim ErrStreet As Boolean = False
    Dim ErrTown As Boolean = False
    Dim ErrPCode As Boolean = False
    Dim ErrPhone As Boolean = False
    Dim ErrEmail As Boolean = False

    Dim FileName As String
    Dim NumberofRecords As Integer
    Dim TableFormat As String = "{0,-12}{1,-22}{2,-22}{3,-8}"
    Dim CurrentRec As Integer
    Dim RecordNumber As Integer

    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set ID
        numID.Value = Customer.ID + 1

        'Set the File Name
        FileName = frmLogin.Drive & "\Customer.txt"
        'Open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
        'Check the number of records
        NumberofRecords = LOF(1) / Len(Customer)
        'Close the file
        FileClose(1)

        If NumberofRecords > 0 Then
            'Display first record
            CurrentRec = 1
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
            FileGet(1, Customer)
            numID.Text = Trim(Customer.ID)
            txtName.Text = Trim(Customer.Name)
            numHouseNumber.Text = Trim(Customer.HouseNumber)
            txtStreet.Text = Trim(Customer.Street)
            txtTown.Text = Trim(Customer.Town)
            txtPCode.Text = Trim(Customer.PCode)
            txtPhone.Text = Trim(Customer.Phone)
            txtEmail.Text = Trim(Customer.Email)
            'Close the file
            FileClose()
        End If
        CurrentRec = 1

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim blnContinue As Boolean = False
        Dim Duplicate As Boolean = False
        Dim largestID As Integer = 0

        'HIGHEST ID VALUE
        'Open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
        'Search the Customer
        Do While Not EOF(1)
            FileGet(1, Customer)
            If Customer.ID > largestID Then
                largestID = Customer.ID
            End If
        Loop
        FileClose(1)
        '/HIGHEST ID VALUE

        If numID.Value = (largestID + 1) Then
            If txtName.Text = "" Or numHouseNumber.Text = "" Or txtStreet.Text = "" Or _
                            txtTown.Text = "" Or txtPCode.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Then
                MessageBox.Show("Input all fields", "Error", MessageBoxButtons.OK)
            Else
                blnContinue = True
            End If
        Else
            Dim Result As DialogResult = MessageBox.Show("ID must be 1 more than largest Customer ID (" & largestID & "), Change automatically?", "Error", MessageBoxButtons.OKCancel)
            If Result = DialogResult.OK Then
                numID.Value = largestID + 1
            End If
        End If

        Duplicate = False

        If blnContinue = True Then
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))

            '<------CHECK CUSTOMER NOT ALREADY PRESENT----->
            'Search the Customer

            Do While Duplicate = False And Not EOF(1)
                FileGet(1, Customer)
                If (Trim(Customer.Name) = txtName.Text) And (Trim(Customer.Email) = txtEmail.Text) Then
                    MessageBox.Show("Customer already exists", "Message", MessageBoxButtons.OK)
                    Duplicate = True
                Else
                    Duplicate = False
                End If
            Loop
            FileClose(1)
            '<-------------------/CHECK------------------->
            If Not Duplicate = True Then
                'Get the data from the form
                Customer.ID = numID.Text
                Customer.Name = txtName.Text
                Customer.HouseNumber = numHouseNumber.Text
                Customer.Street = txtStreet.Text
                Customer.Town = txtTown.Text
                Customer.PCode = txtPCode.Text
                Customer.Phone = txtPhone.Text
                Customer.Email = txtEmail.Text

                'Open the file
                FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
                'Write record to file
                FilePut(1, Customer, NumberofRecords + 1)
                'Close the file
                FileClose(1)
                'Add 1 to the number of records
                NumberofRecords = NumberofRecords + 1
                'Clear the form
                txtName.Text = ""
                numHouseNumber.Value = 0
                txtStreet.Text = ""
                txtTown.Text = ""
                txtPCode.Text = ""
                txtPhone.Text = ""
                txtEmail.Text = ""

                numID.Value = numID.Value + 1
                'Place cursor in Customer Name text box
                txtName.Focus()
            End If
        End If

    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        'Dim Number As Integer
        'Clear the list box
        lstCustomer.Items.Clear()
        'Headings
        lstCustomer.Items.Add(String.Format(TableFormat, "ID", "Name", "Town", "PCode"))
        'Open File
        FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
        'Add records to list box
        'Number = 1
        Customer.ID = 1
        Do While Not EOF(1)
            FileGet(1, Customer)
            lstCustomer.Items.Add(String.Format(TableFormat, _
                                            Customer.ID, Customer.Name, Customer.Town, _
                                            Customer.PCode))
            'Number = Number + 1
            Customer.ID = Customer.ID + 1
        Loop
        'Close File
        FileClose(1)
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If CurrentRec < NumberofRecords Then
            RecordNumber = CurrentRec + 1
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
            'Get record
            FileGet(1, Customer, RecordNumber)
            'Display record
            numID.Text = Trim(Customer.ID)
            txtName.Text = Trim(Customer.Name)
            numHouseNumber.Text = Trim(Customer.HouseNumber)
            txtStreet.Text = Trim(Customer.Street)
            txtTown.Text = Trim(Customer.Town)
            txtPCode.Text = Trim(Customer.PCode)
            txtPhone.Text = Trim(Customer.Phone)
            txtEmail.Text = Trim(Customer.Email)
            'Close file
            FileClose()
            CurrentRec = CurrentRec + 1
        End If
    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        If CurrentRec > 1 Then
            RecordNumber = CurrentRec - 1
        Else
            RecordNumber = CurrentRec
        End If
        'Open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
        'Get record
        FileGet(1, Customer, RecordNumber)
        'Display record
        numID.Text = Trim(Customer.ID)
        txtName.Text = Trim(Customer.Name)
        numHouseNumber.Text = Trim(Customer.HouseNumber)
        txtStreet.Text = Trim(Customer.Street)
        txtTown.Text = Trim(Customer.Town)
        txtPCode.Text = Trim(Customer.PCode)
        txtPhone.Text = Trim(Customer.Phone)
        txtEmail.Text = Trim(Customer.Email)
        'Close file
        FileClose()
        CurrentRec = RecordNumber
    End Sub

    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        If NumberofRecords > 0 Then
            'Display the first record
            CurrentRec = 1
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
            'Get first record
            FileGet(1, Customer)
            'Display record
            numID.Text = Trim(Customer.ID)
            txtName.Text = Trim(Customer.Name)
            numHouseNumber.Text = Trim(Customer.HouseNumber)
            txtStreet.Text = Trim(Customer.Street)
            txtTown.Text = Trim(Customer.Town)
            txtPCode.Text = Trim(Customer.PCode)
            txtPhone.Text = Trim(Customer.Phone)
            txtEmail.Text = Trim(Customer.Email)
            'Close file
            FileClose()
        End If
    End Sub

    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        If NumberofRecords > 1 Then
            'Display the last record
            RecordNumber = NumberofRecords
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
            'Get last record
            FileGet(1, Customer, RecordNumber)
            'Display record
            numID.Text = Trim(Customer.ID)
            txtName.Text = Trim(Customer.Name)
            numHouseNumber.Text = Trim(Customer.HouseNumber)
            txtStreet.Text = Trim(Customer.Street)
            txtTown.Text = Trim(Customer.Town)
            txtPCode.Text = Trim(Customer.PCode)
            txtPhone.Text = Trim(Customer.Phone)
            txtEmail.Text = Trim(Customer.Email)
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
            FileName = frmLogin.Drive & "\Customer.txt"
            'Open the file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
            'Check the number of records
            NumberofRecords = LOF(1) / Len(Customer)
            'Close the file
            FileClose()
            'Reset current record
            CurrentRec = 1
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        numID.Value = NumberofRecords + 1
        txtName.Text = ""
        numHouseNumber.Value = 0
        txtStreet.Text = ""
        txtTown.Text = ""
        txtPCode.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtName.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        'Open the file
        FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
        'Get details from the form record
        Customer.ID = numID.Text
        Customer.Name = txtName.Text
        Customer.HouseNumber = numHouseNumber.Text
        Customer.Street = txtStreet.Text
        Customer.Town = txtTown.Text
        Customer.PCode = txtPCode.Text
        Customer.Phone = txtPhone.Text
        Customer.Email = txtEmail.Text
        'Save record
        FilePut(1, Customer, CurrentRec)
        'Close file
        FileClose(1)
        MessageBox.Show("Customer details saved.", "Message", MessageBoxButtons.OK)

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
        'If yes delete
        If Response = MsgBoxResult.Yes Then
            'Get record number
            Number = numID.Text
            'Set temporary file
            TempFileName = frmLogin.Drive & "\Temp.txt"
            'Open Customer file
            FileOpen(1, FileName, OpenMode.Random, , , Len(Customer))
            'Open temp file
            FileOpen(2, TempFileName, OpenMode.Random, , , Len(Customer))
            Do While Not EOF(1)
                FileGet(1, Customer)
                If Customer.ID <> Number Then
                    FilePut(2, Customer)
                End If
            Loop
            'Close Customer File
            FileClose(1)
            'Close Temp File
            FileClose(2)
            'Delete Customer File
            Kill(FileName)
            'Rename Temp File as Customer File
            Rename(TempFileName, FileName)
            'Previous Customer
            Call cmdPrevious_Click(sender, e)
            NumberofRecords = NumberofRecords - 1
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
        e.Graphics.DrawString("▒▒          Customers          ▒▒", MyFont, Brushes.Black, x, y)
        y = y + FontHeight
        e.Graphics.DrawString("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒", MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'blank line
        e.Graphics.DrawString("", MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Customer Details:"
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Customer ID: " & numID.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Customer Name: " & txtName.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "House Number: " & numHouseNumber.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight


        'build the line to be printed
        DLine = "Street: " & txtStreet.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Town: " & txtTown.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "PCode: " & txtPCode.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight

        'build the line to be printed
        DLine = "Phone: " & txtPhone.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight


        'build the line to be printed
        DLine = "Email: " & txtEmail.Text
        'print line
        e.Graphics.DrawString(DLine, MyFont, Brushes.Black, x, y)
        y = y + FontHeight
    End Sub

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
            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub numHouseNumber_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numHouseNumber.Validating
        'Validation
        If Not IsNumeric(numHouseNumber.Text) = True Or numHouseNumber.Text = "" Then
            ErrorProvider1.SetError(numHouseNumber, "Must Contain a Number")
            ErrHouseNumber = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(numHouseNumber, "")
            ErrHouseNumber = False
            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub txtName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        'Validation
        If (IsAlphabetic(txtName.Text) = False) Or (txtName.Text = "") Then
            ErrorProvider1.SetError(txtName, "Must contain letters/spaces only")
            ErrName = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(txtName, "")
            ErrName = False
            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub txtStreet_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStreet.Validating
        'Validation
        If txtStreet.Text = "" Then
            ErrorProvider1.SetError(txtStreet, "Enter Name of Street")
            ErrStreet = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(txtStreet, "")
            ErrStreet = False
            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub txtTown_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTown.Validating
        'Validation
        If txtTown.Text = "" Then
            ErrorProvider1.SetError(txtTown, "Enter Name of Town")
            ErrTown = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        Else
            ErrorProvider1.SetError(txtTown, "")
            ErrTown = False
            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        End If
    End Sub

    Private Sub txtPCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPCode.Validating
        'Validation
        If txtPCode.Text Like "[A-Z][A-Z]## #[A-Z][A-Z]" Then
            ErrorProvider1.SetError(txtPCode, "")
            ErrPCode = False

            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        Else
            ErrorProvider1.SetError(txtPCode, "Invalid Format: eg. SA01 2BQ")
            ErrPCode = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        End If
    End Sub

    Private Sub txtPhone_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPhone.Validating
        'Validation
        If txtPhone.Text Like "##### ######" Then
            ErrorProvider1.SetError(txtPhone, "")
            ErrPhone = False
            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        Else
            ErrorProvider1.SetError(txtPhone, "Invalid Format, format as ##### ######")
            ErrPhone = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        End If
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        'Validation
        If txtEmail.Text.Contains("@") Then
            ErrorProvider1.SetError(txtEmail, "")
            ErrEmail = False
            If ErrID = False And ErrName = False And ErrHouseNumber = False And _
                ErrStreet = False And ErrTown = False And ErrPCode = False And ErrPhone = False And ErrEmail = False Then
                cmdAdd.Show()
                cmdDelete.Show()
                cmdSave.Show()
                cmdPrint.Show()
            End If
        Else
            ErrorProvider1.SetError(txtEmail, "Invalid Format, format as ...@...")
            ErrEmail = True
            cmdAdd.Hide()
            cmdDelete.Hide()
            cmdSave.Hide()
            cmdPrint.Hide()
        End If
    End Sub

End Class