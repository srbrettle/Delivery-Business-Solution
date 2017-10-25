Public Class frmOrderDetails
    Public Quantity As Integer
    Public OrderDate As String
    Public DeliveryDate As String
    Public DeliveryTime As String
    'Data Types: Date --> String: Ideal Value Format

    Private Sub cmdContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContinue.Click
        Quantity = numQuantity.Value
        OrderDate = datOrderDate.Text
        DeliveryDate = datDeliveryDate.Text
        DeliveryTime = datDeliveryTime.Text
        frmOrders.Go = True
        frmOrders.Show()
        frmOrders.cmdAdd.PerformClick()
        Me.Hide()
    End Sub

    Private Sub frmOrderDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the Format type and the CustomFormat string.
        datOrderDate.CustomFormat = "dd/MM/yyyy"
        datDeliveryDate.CustomFormat = "dd/MM/yyyy"

    End Sub
End Class