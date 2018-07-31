Public Class ForReceiveOrder
    Dim TableReceiveTem As DataTable = New DSInventoryClinic.RECEIVE_ITEM_TEM_DETAILDataTable
    Dim DAItem As New DSInventoryClinicTableAdapters.tblItemTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboItem
            .DataSource = DAItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click
        If ValidateCombobox(CboItem, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtQTYReceive, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtItemPrice, "", ErrReceive) = False Then Exit Sub
        AddReceiveTem()
        CalculateTotalReceive(TableReceiveTem)
    End Sub
    Function CheckValue(ByVal myTable As DataTable, ByVal columnName As String, ByVal searchValue As String) As Boolean
        For Each row As DataRow In myTable.Rows
            MsgBox(row(columnName))
            If row(columnName) = searchValue Then Return True
        Next
        Return False
    End Function
    Private Sub AddReceiveTem()
        If CheckValue(TableReceiveTem, "ITEM_ID", CboItem.SelectedValue) = True Then
            MessageBox.Show("The Item existing in list receive! pls check again.", "Receive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboItem.Focus()
            CboItem.SelectAll()
            Exit Sub
        End If
        Dim Dr As DataRow
        Dr = TableReceiveTem.NewRow
        Dr("ITEM_ID") = CboItem.SelectedValue
        Dr("ITEM_NAME") = CboItem.Text
        Dr("ITEM_QTY") = TxtQTYReceive.Text
        Dr("ITEM_MEASURE") = CboReceiveMeasure.Text
        Dr("ITEM_PRICE") = TxtItemPrice.Text
        Dr("ITEM_EXPIRYDATE") = IIf(DateExpiry.Checked = True, DateExpiry.Value, Nothing)
        Dr("TOTAL_AMOUNT") = CDbl(TxtQTYReceive.Text) * CDbl(TxtItemPrice.Text)
        TableReceiveTem.Rows.Add(Dr)
        RefreshDGTem()
        CleanItemReceived()
    End Sub
    Private Sub CleanItemReceived()
        CboItem.SelectedIndex = -1
        TxtQTYReceive.Text = ""
        TxtItemPrice.Text = ""
        CboReceiveMeasure.SelectedIndex = -1
        CboReceiveMeasure.Text = ""
        DateExpiry.Checked = False
    End Sub
    Private Sub DeleteRow(ByVal TblTem As DataTable, ByVal filter As String)
        Try
            TblTem.Rows.Find(filter).Delete()
            TblTem.AcceptChanges()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub RefreshDGTem()
        GridListItemReceive.DataSource = TableReceiveTem
    End Sub
    Private Sub CalculateTotalReceive(ByVal tblReceiveTem As DataTable)
        Dim TotalExcludeVAT As Double = 0
        Dim TotalAmountDue As Double = 0
        For Each Row As DataRow In tblReceiveTem.Rows
            TotalExcludeVAT = TotalExcludeVAT + CDbl(Row("TOTAL_AMOUNT"))
        Next
        TxtTotalAmoutExcludVAT.Text = TotalExcludeVAT
        TxtAmounDue.Text = TotalAmountDue
        'Dim drGrid As Janus.Windows .Gr
    End Sub

    Private Sub TxtQTYReceive_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTYReceive.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtItemPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtItemPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click

        If GridListItemReceive.SelectedItems.Count = 0 Then Exit Sub
        DeleteRow(TableReceiveTem, GridListItemReceive.GetRow.Cells("RECEIVETEM_ID").Value.ToString)
        RefreshDGTem()
        CalculateTotalReceive(TableReceiveTem)
    End Sub
   
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class