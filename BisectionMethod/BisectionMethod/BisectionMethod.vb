Option Explicit On
Imports System.Math
Imports info.lundin.math
Imports System.Threading

Public Class BisectionMethod
    Dim func As String
    Dim k As Integer
    Dim SolutionOfTask As Decimal
    Dim ValueOfFunction As Decimal
    Dim FinalInaccuracy As Decimal

    Public Sub out(SolutionOfTaskBox As TextBox, ValueOfFunctionBox As TextBox,
                   NumberOfIterationsBox As TextBox, AbsErrorBox As TextBox)
        SolutionOfTaskBox.Text = SolutionOfTask
        ValueOfFunctionBox.Text = ValueOfFunction.ToString("0E0")
        NumberOfIterationsBox.Text = k
        AbsErrorBox.Text = FinalInaccuracy.ToString("0E0")
    End Sub

    Function F(par As Double) As Double
        Dim Parser As New ExpressionParser()
        Parser.Values.Add("x", par)
        Return Parser.Parse(func)
    End Function

    Public Sub start(funcBox As TextBox, LeftEndPointBox As TextBox,
                     RightEndPointBox As TextBox,
                     ToleranceBox As TextBox, k_maxBox As TextBox,
                     ByRef ProgressBar1 As ProgressBar, ByRef Label4 As Label)
        Dim Tolerance As Double
        Dim a, b As Decimal
        Dim mid As Decimal
        Dim i_Max, k_max As Integer
        func = funcBox.Text
        a = Decimal.Parse(LeftEndPointBox.Text)
        b = Decimal.Parse(RightEndPointBox.Text)
        Tolerance = Double.Parse(ToleranceBox.Text)
        k_max = Integer.Parse(k_maxBox.Text)
        k = 0
        '***********************************************************************
        If Math.Sign(F(a)) = Math.Sign(F(b)) Then
            MsgBox("Sign(F(a))= " & Sign(F(a)) & " and Sign(F(b))= " &
               Sign(F(b)) & " must be opposite! Check endpoints of the interval [a, b]!")
        Else
            '*******************************************************************
            While k < k_max
                mid = a + (b - a) / 2
                If Math.Sign(F(a)) = Math.Sign(F(mid)) Then
                    a = mid
                Else
                    b = mid
                End If
                FinalInaccuracy = Abs(b - a)
                k = k + 1
                i_Max = CInt(Math.Log((b - a) / Tolerance))
                '**********************************************************************
                If k >= k_max Then
                    Label4.Text = "Attention: It isn't possible to find a solution with the given Tolerance = " & Tolerance
                End If
                If FinalInaccuracy <= CDec(Tolerance) Then
                    Label4.Text = "The root of a nonlinear equation found with the given Tolerance = " & Tolerance
                    Exit While
                End If
                ProgressBar1.Visible = True
                ProgressBar1.Maximum = k + 0.00000001
                ProgressBar1.Value = k
                Thread.Sleep(50)
            End While
            ProgressBar1.Visible = False
            SolutionOfTask = mid
            ValueOfFunction = F(mid)
        End If
    End Sub
End Class
