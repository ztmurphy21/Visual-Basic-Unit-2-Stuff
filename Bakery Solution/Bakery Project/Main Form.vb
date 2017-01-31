' Bakery Program
' Calculates the total costs for bakey product orders and also allows user to print receipt
' Programmer: Zachary Murphy 
Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales


        lblTotalItems.Text = Val(txtDonuts.Text) + Val(txtMuffins.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print sales receipt
        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False
        PrintForm1.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True


    End Sub
End Class
