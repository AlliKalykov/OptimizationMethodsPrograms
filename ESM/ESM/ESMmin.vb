Option Explicit On
Imports System.Math
Imports info.lundin.math
Imports System.Threading

Public Class ESMmin
    Dim func As String
    Dim k As Integer
    Dim SolutionOfTask As Decimal
    Dim ValueOfFunction As Decimal
    Dim FinalInaccuracy As Decimal
    Dim FinalAbs As Decimal
    Dim cond As Boolean

    Public Sub out(SolutionOfTaskBox As TextBox, ValueOfFunctionBox As TextBox,
                   NumberOfIterationsBox As TextBox, AbsBox As TextBox, condBox As TextBox)
        SolutionOfTaskBox.Text = SolutionOfTask
        ValueOfFunctionBox.Text = ValueOfFunction
        NumberOfIterationsBox.Text = k
        AbsBox.Text = FinalAbs.ToString("0E0")
        condBox.Text = cond
    End Sub

    Function F(par As Double) As Double
        Dim Parser As New ExpressionParser()
        Parser.Values.Add("x", par)
        Return Parser.Parse(func)
    End Function

    Public Sub start(funcBox As TextBox, InitialPointBox As TextBox,
                     ToleranceBox As TextBox, k_maxBox As TextBox,
                     ByRef ProgressBar1 As ProgressBar, ByRef Label4 As Label)
        Dim Tolerance As Double
        Dim x0, x1 As Decimal
        Dim H As Decimal
        Dim YF0, YF1 As Decimal
        Dim k_max As Integer
        Dim CondK_Max As Boolean
        cond = 0
        CondK_Max = 0
        func = funcBox.Text
        x0 = Decimal.Parse(InitialPointBox.Text)
        Tolerance = Double.Parse(ToleranceBox.Text)
        k_max = Integer.Parse(k_maxBox.Text)

        H = Tolerance
        YF0 = CDec(F(CDbl(x0)))
        x1 = x0 + H
        YF1 = CDec(F(CDbl(x1)))
        k = 0

        Do
            k = k + 1
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
            If YF1 >= YF0 Then
                If k = 1 Then
                    cond = 1
                    Label4.Text = "Attention:Try to revise Initial point to check validity of the value, because" _
                        & vbCrLf & "1)Initial point Is x0 may be a solution for a given Tolerence = " & Tolerance _
                        & vbCrLf & "  You can reduce the Tolerance to check it." _
                        & vbCrLf & "2)The extremum point can be located to the left of the given Initial point = " & InitialPointBox.Text() _
                        & vbCrLf & "  You can reduce the Initial point to check it." _
                        & vbCrLf & "3)Probably, It means that ESM can't find  an extremum "
                End If
                x1 = x0
                YF1 = YF0
            Else
                x0 = x1
                YF0 = YF1
                x1 = x0 + H
                YF1 = CDec(F(CDbl(x1)))
            End If

            ProgressBar1.Maximum = k + 0.00000001
            ProgressBar1.Value = k
            Thread.Sleep(0)
        Loop While CondK_Max = 0 And cond = 0 And Math.Abs(x1 - x0) >= Tolerance

        If Math.Abs(x1 - x0) < Tolerance And cond = 0 Then
            Label4.Text = "Answer: The minimum point of extremum find with the given Tolerance = " & Tolerance
        End If

        ProgressBar1.Visible = False
        SolutionOfTask = x1
        ValueOfFunction = YF1
        FinalAbs = Math.Abs(x1 - x0)

    End Sub
End Class
