' Program:   AirBnB Reservations
' Author:    Trevor Pelaez
' Date:      2/16/22
' Purpose:   This program is used to calculate the total cost for a stay in
'            a AirBnB in Orlando, Florida.
Public Class frmAirBnB
    Private Sub frmAirBnB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cost per night during every stay. Will be used for all calculations

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event happens when you click the exit button. closes the program and exits the window.
        Close()
    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        'This happens when you click the cost button. Calculates the total cost of the stay by
        'multiplying the  number of nights entered in the textbox by the pricePerNight.
        Const _cintPricePerNight As Integer = 79I
        Dim strNumberOfNights As String
        Dim intNumberOfNights As Integer
        Dim decTotalCost As Decimal
        strNumberOfNights = txtNumberOfNights.Text
        intNumberOfNights = Convert.ToInt32(strNumberOfNights)
        decTotalCost = intNumberOfNights * _cintPricePerNight
        lblTotalCost.Text = decTotalCost.ToString("C")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event happens when you click the clear button. Clears the textbox entry and and the total cost label
        'refocuses the cursor back into it.
        txtNumberOfNights.Clear()
        lblTotalCost.Text = ""
        txtNumberOfNights.Focus()
    End Sub

    Private Sub txtNumberOfNights_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfNights.TextChanged

    End Sub
End Class
