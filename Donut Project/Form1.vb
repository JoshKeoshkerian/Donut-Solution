Imports System.Security.Cryptography

Public Class frmMain

    Dim Subtotal As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GetSubtotal()
        If radGlazed.Checked = True Then
            Subtotal += 1.05
        ElseIf radSugar.Checked = True Then
            Subtotal += 1.05
        ElseIf radChocolate.Checked = True Then
            Subtotal += 1.25
        ElseIf radFilled.Checked = True Then
            Subtotal += 1.5
        End If
        If radCappucino.Checked = True Then
            Subtotal += 2.75
        ElseIf radRegular.Checked = True Then
            Subtotal += 1.5
        End If
    End Sub

    Private Function GetSalesTax(ByVal dclSub As Double)
        Dim tax As Double
        tax = dclSub * 0.06
        Return tax
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        GetSubtotal()
        lblSubtotal.Text = Subtotal.ToString("C2")
        Dim result As Double = GetSalesTax(Subtotal)
        lblSales.Text = result.ToString("C2")
        result = ((Subtotal) + GetSalesTax(Subtotal))
        lblTotal.Text = result.ToString("C2")
    End Sub

    Private Sub radGlazed_CheckedChanged(sender As Object, e As EventArgs) _
        Handles radGlazed.CheckedChanged, radSugar.CheckedChanged,
        radChocolate.CheckedChanged, radFilled.CheckedChanged,
        radNone.CheckedChanged, radRegular.CheckedChanged, radCappucino.CheckedChanged

        lblSales.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTotal.Text = String.Empty
        Subtotal = 0
    End Sub
End Class
