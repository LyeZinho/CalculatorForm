Imports NCalc

Public Class Form1
    Dim calc As String
    Dim DefaultResultDisplay As String = ""
    Public InvalidCalc As Boolean
    Dim Expanded As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 360
        Expanded = False
    End Sub

    Private Sub BtExpand_Click(sender As Object, e As EventArgs) Handles BtExpand.Click
        If Expanded = False Then
            Me.Width = 609
            Expanded = True
        ElseIf Expanded = True Then
            Me.Width = 360
            Expanded = False
        End If

    End Sub

    Private Sub BtNumeric0_Click(sender As Object, e As EventArgs) Handles BtNumeric0.Click
        calc = calc + "0"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric1_Click(sender As Object, e As EventArgs) Handles BtNumeric1.Click
        calc = calc + "1"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric2_Click(sender As Object, e As EventArgs) Handles BtNumeric2.Click
        calc = calc + "2"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric3_Click(sender As Object, e As EventArgs) Handles BtNumeric3.Click
        calc = calc + "3"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric4_Click(sender As Object, e As EventArgs) Handles BtNumeric4.Click
        calc = calc + "4"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric5_Click(sender As Object, e As EventArgs) Handles BtNumeric5.Click
        calc = calc + "5"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric6_Click(sender As Object, e As EventArgs) Handles BtNumeric6.Click
        calc = calc + "6"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric7_Click(sender As Object, e As EventArgs) Handles BtNumeric7.Click
        calc = calc + "7"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric8_Click(sender As Object, e As EventArgs) Handles BtNumeric8.Click
        calc = calc + "8"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtNumeric9_Click(sender As Object, e As EventArgs) Handles BtNumeric9.Click
        calc = calc + "9"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtCalcInterpunct_Click(sender As Object, e As EventArgs) Handles BtCalcInterpunct.Click
        calc = calc + "."
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtCalcPlus_Click(sender As Object, e As EventArgs) Handles BtCalcPlus.Click
        calc = calc + "+"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtCalcMinus_Click(sender As Object, e As EventArgs) Handles BtCalcMinus.Click
        calc = calc + "-"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtCalcAsterisk_Click(sender As Object, e As EventArgs) Handles BtCalcAsterisk.Click
        calc = calc + "*"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtCalcSlash_Click(sender As Object, e As EventArgs) Handles BtCalcSlash.Click
        calc = calc + "/"
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub

    Private Sub BtFuncClear_Click(sender As Object, e As EventArgs) Handles BtFuncClear.Click
        BtCalcDisplay.Text = Display("", DefaultResultDisplay)
        calc = ""
    End Sub

    Private Sub BtFuncExit_Click(sender As Object, e As EventArgs) Handles BtFuncExit.Click
        Me.Close()

    End Sub

    Private Sub BtCalcEqual_Click(sender As Object, e As EventArgs) Handles BtCalcEqual.Click
        Dim result As String = FuncsParaCalc.Calc(calc)

        If result = "123456" And InvalidCalc = True Then
            BtCalcDisplay.Text = Display(calc, "Expressão invalida")
        Else
            BtCalcDisplay.Text = Display(calc, result.ToString)
        End If

    End Sub

    '´To do concluir a parte cientifica
    Private Sub BtSQRT_Click(sender As Object, e As EventArgs) Handles BtSQRT.Click
        calc = calc + ""
        BtCalcDisplay.Text = Display(calc, DefaultResultDisplay)
    End Sub
End Class
