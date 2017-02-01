' Calculates projected sales for items
' Programmer: Zachary Murphy 

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calc the projected sales
        lblStraw.Text = Val(txtStraw.Text) + (Val(txtStraw.Text) * Val(txtProjIncrease.Text))
        lblBlue.Text = Val(txtBlue.Text) + (Val(txtBlue.Text) * Val(txtProjIncrease.Text))
        lblRasp.Text = Val(txtRasp.Text) + (Val(txtRasp.Text) * Val(txtProjIncrease.Text))

        ' format output for dollar signs
        lblStraw.Text = Format(lblStraw.Text, "currency")
        lblBlue.Text = Format(lblBlue.Text, "currency")
        lblRasp.Text = Format(lblRasp.Text, "currency")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears content entered by user
        txtProjIncrease.Text = String.Empty
        txtStraw.Text = String.Empty
        txtRasp.Text = String.Empty
        txtBlue.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty
        lblStraw.Text = String.Empty
        'focus to projection increase
        txtProjIncrease.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the application
        Me.Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalc.Visible = False
        btnClear.Visible = False
        btnPrint.Visible = False
        btnExit.Visible = False
        PrintForm1.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnPrint.Visible = True
        btnExit.Visible = True
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
