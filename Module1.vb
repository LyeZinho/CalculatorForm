Imports NCalc
Module Module1

    Public Function calc(_imput As String) As Integer
        Dim expression = New Expression(_imput, EvaluateOptions.IgnoreCase)
        Dim result = expression.Evaluate()
        Return Convert.ToInt32(result)
    End Function
End Module
