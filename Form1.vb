Imports NCalc

Public Class Form1
    Dim calc As String

    Private Sub BtNumeric0_Click(sender As Object, e As EventArgs) Handles BtNumeric0.Click
        calc = calc + "0"
    End Sub

    Private Sub BtNumeric1_Click(sender As Object, e As EventArgs) Handles BtNumeric1.Click
        calc = calc + "1"
    End Sub

    Private Sub BtNumeric2_Click(sender As Object, e As EventArgs) Handles BtNumeric2.Click
        calc = calc + "2"
    End Sub

    Private Sub BtNumeric3_Click(sender As Object, e As EventArgs) Handles BtNumeric3.Click
        calc = calc + "3"
    End Sub

    Private Sub BtNumeric4_Click(sender As Object, e As EventArgs) Handles BtNumeric4.Click
        calc = calc + "4"
    End Sub

    Private Sub BtNumeric5_Click(sender As Object, e As EventArgs) Handles BtNumeric5.Click
        calc = calc + "5"
    End Sub

    Private Sub BtNumeric6_Click(sender As Object, e As EventArgs) Handles BtNumeric6.Click
        calc = calc + "6"
    End Sub

    Private Sub BtNumeric7_Click(sender As Object, e As EventArgs) Handles BtNumeric7.Click
        calc = calc + "7"
    End Sub

    Private Sub BtNumeric8_Click(sender As Object, e As EventArgs) Handles BtNumeric8.Click
        calc = calc + "8"
    End Sub

    Private Sub BtNumeric9_Click(sender As Object, e As EventArgs) Handles BtNumeric9.Click
        calc = calc + "9"
    End Sub

    Private Sub BtCalcInterpunct_Click(sender As Object, e As EventArgs) Handles BtCalcInterpunct.Click
        calc = calc + "."
    End Sub

    Private Sub BtCalcPlus_Click(sender As Object, e As EventArgs) Handles BtCalcPlus.Click
        calc = calc + "+"
    End Sub

    Private Sub BtCalcMinus_Click(sender As Object, e As EventArgs) Handles BtCalcMinus.Click
        calc = calc + "-"
    End Sub

    Private Sub BtCalcAsterisk_Click(sender As Object, e As EventArgs) Handles BtCalcAsterisk.Click
        calc = calc + "*"
    End Sub

    Private Sub BtCalcSlash_Click(sender As Object, e As EventArgs) Handles BtCalcSlash.Click
        calc = calc + "/"
    End Sub

    Private Sub BtFuncClear_Click(sender As Object, e As EventArgs) Handles BtFuncClear.Click
        calc = ""
    End Sub

    Private Sub BtFuncExit_Click(sender As Object, e As EventArgs) Handles BtFuncExit.Click
        Me.Close()
    End Sub

    Private Sub BtCalcEqual_Click(sender As Object, e As EventArgs) Handles BtCalcEqual.Click
        BtCalcDisplay.Text = "Algo"
    End Sub

End Class
