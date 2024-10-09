'Program Name: Londn Tube Tickets
'Date: October 3, 2024
'Author: K Bola
'Purpose: This application calculates the cost of tickets on the london tube
Public Class frmTicket
    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Const _cdecZoneOneThree As Decimal = 5.4
        Const _cdecZoneOneFive As Decimal = 6.51
        Const _cdecZoneOneSix As Decimal = 6.62
        Dim intFare As Integer
        Dim decTotalCost As Decimal
        If (IsNumeric(txtFare.Text)) Then
            intFare = Convert.ToInt32(txtFare.Text)
            If (intFare > 0 And radZone3.Checked) Then
                decTotalCost = intFare * _cdecZoneOneThree
                lblCost.Text = decTotalCost.ToString("C")
            ElseIf (intFare > 0 And radZone5.Checked) Then
                decTotalCost = intFare * _cdecZoneOneFive
                lblCost.Text = decTotalCost.ToString("C")
            ElseIf (intFare > 0 And radZone6.Checked) Then
                decTotalCost = intFare * _cdecZoneOneSix
                lblCost.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter a number greater than Zero", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
                txtFare.Clear()
                txtFare.Focus()
            End If
        Else
            MsgBox("Enter a number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
            txtFare.Clear()
            txtFare.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFare.Clear()
        txtFare.Focus()
        radZone3.Checked = True
        lblCost.Text = ""
    End Sub

    Private Sub frmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
    End Sub
End Class
