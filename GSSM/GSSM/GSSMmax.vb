Option Explicit On
Imports System.Math
Imports info.lundin.math
Imports System.Threading

Public Class GSSMmax
    Dim func As String
    Dim k As Integer
    Dim SolutionOfTask As Decimal
    Dim ValueOfFunction As Decimal
    Dim FinalInaccuracy As Decimal

    Public Sub out(SolutionOfTaskBox As TextBox, ValueOfFunctionBox As TextBox,
                       NumberOfIterationsBox As TextBox, AbsErrorBox As TextBox)
        SolutionOfTaskBox.Text = SolutionOfTask
        ValueOfFunctionBox.Text = ValueOfFunction.ToString()
        NumberOfIterationsBox.Text = k
        AbsErrorBox.Text = FinalInaccuracy.ToString("0E0")
    End Sub

    Function F(par As Double) As Double
        Dim Parser As New ExpressionParser()
        Parser.Values.Add("x", par)
        Return Parser.Parse(func)
    End Function

    Public Sub start(funcBox As ComboBox, LeftEndPointBox As TextBox,
                         RightEndPointBox As TextBox,
                         ToleranceBox As TextBox, k_maxBox As TextBox,
                         ByRef ProgressBar1 As ProgressBar, ByRef Label4 As Label)
        Dim Tolerance As Double
        Dim a, b As Decimal
        Dim x1, x2 As Decimal
        Dim YF1, YF2 As Decimal
        Dim k_max As Integer
        Dim CondK_Max As Boolean
        Dim R As Decimal
        R = (Math.Sqrt(5) - 1) / 2
        CondK_Max = 0
        func = funcBox.Text
        a = Decimal.Parse(LeftEndPointBox.Text)
        b = Decimal.Parse(RightEndPointBox.Text)
        Tolerance = Double.Parse(ToleranceBox.Text)
        k_max = Integer.Parse(k_maxBox.Text)

        x1 = a + (1 - R) * (b - a)
        YF1 = F(x1)
        x2 = a + R * (b - a)
        YF2 = F(x2)
        k = 0

        Do
            k += 1
            If k = k_max Then
                Dim rv As Long
                rv = MsgBox("Attention: It isn't possible to find a solution with the given Tolerance = " _
                            & Tolerance & " and for a given Number Of Iterations =" & k_max & vbCrLf _
                            & "Continue searching?", vbYesNo Or vbQuestion)
                If rv = vbYes Then
                    k_max = k_max + k_max
                    k_maxBox.Text = k_max
                Else
                    CondK_Max = 1
                    Label4.Text = "Attention: It isn't possible to find a solution with the given Tolerance = " _
                        & Tolerance & vbCrLf & "and for a given Number Of Iterations =" & k_max
                End If
            End If

            If YF1 < YF2 Then
                a = x1
                x1 = x2
                YF1 = YF2
                x2 = a + R * (b - a)
                YF2 = F(x2)
            Else
                b = x2
                x2 = x1
                YF2 = YF1
                x1 = a + (1 - R) * (b - a)
                YF1 = F(x1)
            End If
            FinalInaccuracy = Math.Abs(b - a)
            ProgressBar1.Visible = True
            ProgressBar1.Maximum = k + 0.00000001
            ProgressBar1.Value = k
            Thread.Sleep(0)
        Loop While CondK_Max = 0 And FinalInaccuracy > CDec(Tolerance)

        If FinalInaccuracy < CDec(Tolerance) Then
            Label4.Text = "Answer: The maximum point of extremum find with the given Tolerance = " & Tolerance
        End If

        ProgressBar1.Visible = False
        SolutionOfTask = x1
        ValueOfFunction = YF1

    End Sub
End Class
