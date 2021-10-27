Imports NCalc
Imports Form1
Module FuncsParaCalc
    Public Function Display(_calc As String, _result As String) As String
        Dim var = "" + _calc + "
                               " + _result
        Return var
    End Function


    Public Function Calc(_imput As String) As Double
        Dim expression = New Expression(_imput, EvaluateOptions.IgnoreCase)
        Dim result
        Try
            result = expression.Evaluate()
        Catch ex As Exception
            Form1.InvalidCalc = True
            result = "123456"
        End Try

        Return Convert.ToDouble(result)
    End Function
End Module
