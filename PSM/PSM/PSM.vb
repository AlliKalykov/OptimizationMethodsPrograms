Option Explicit On
Imports System.Math
Imports info.lundin.math
Imports System.Threading

Public Class PSM
    Dim func As String
    Dim k As Integer
    Dim SolutionOfTask As Decimal
    Dim ValueOfFunction As Decimal
    Dim FinalInaccuracy As Decimal
    Dim FinalH0 As Decimal

    Public Sub out(SolutionOfTaskBox As TextBox, ValueOfFunctionBox As TextBox,
                   NumberOfIterationsBox As TextBox, H0box As TextBox)
        SolutionOfTaskBox.Text = SolutionOfTask
        ValueOfFunctionBox.Text = ValueOfFunction
        NumberOfIterationsBox.Text = k
        H0box.Text = FinalH0.ToString("0E0")
    End Sub

    Function F(par As Double) As Double
        Dim Parser As New ExpressionParser()
        Parser.Values.Add("x", par)
        Return Parser.Parse(func)
    End Function

    Public Sub start(funcBox As TextBox, InitialPointBox As TextBox,
                     ToleranceBox As TextBox, k_maxBox As TextBox,
                     DecreasingBox As TextBox, InitialStepBox As TextBox,
                     minRadioButton As RadioButton, maxRadioButton As RadioButton,
                     ByRef ProgressBar1 As ProgressBar, ByRef Label4 As Label, H0box As TextBox)
        Dim Tolerance As Double
        Dim x0, x1 As Decimal
        Dim R As Decimal
        Dim H0, H1 As Decimal
        Dim YF0, YF1 As Decimal
        Dim k_max As Integer
        func = funcBox.Text
        x0 = Decimal.Parse(InitialPointBox.Text)
        Tolerance = Double.Parse(ToleranceBox.Text)
        k_max = Integer.Parse(k_maxBox.Text)
        R = Decimal.Parse(DecreasingBox.Text)
        H0 = Decimal.Parse(InitialStepBox.Text)
        Dim searchMin As Boolean
        Dim searchMax As Boolean

        searchMin = Boolean.Parse(minRadioButton.Checked)
        searchMax = Boolean.Parse(maxRadioButton.Checked)

        YF0 = F(x0)
        H1 = H0
        x1 = x0 + H1
        YF1 = F(x1)

        k = 0
        If searchMin = True And searchMax = False Then

            Do
                k = k + 1
                If YF1 >= YF0 Then
                    If Abs(H0) <= CDec(Tolerance / R) Then
                        H1 = H0
                        x1 = x0
                        YF1 = YF0
                        Label4.Text = "Answer: The minimum find with the given Tolerance = " & Tolerance
                        Exit Do
                    Else
                        H1 = -H0 / R
                        H0 = H1
                    End If
                Else
                    H1 = H0
                End If
                x0 = x1
                YF0 = YF1
                x1 = x0 + H1
                YF1 = F(x1)

                ProgressBar1.Visible = True
                ProgressBar1.Maximum = k + 0.00000001
                ProgressBar1.Value = k
                Thread.Sleep(0)

                If k = k_max Then
                    Dim rv As Long
                    rv = MsgBox("Attention: It isn't possible to find a solution with the given Tolerance = " & Tolerance & " and for a given Number Of Iterations =" & k_max & vbCrLf & "Continue searching?", vbYesNo Or vbQuestion)
                    If rv = vbYes Then
                        k_max = k_max + k_max
                        k_maxBox.Text = k_max
                    End If
                End If
            Loop While k < k_max

            If k >= k_max Then
                Label4.Text = "Attention: It isn't possible to find a solution with the given Tolerance = " & Tolerance & vbCrLf & "and for a given Number Of Iterations =" & k_max
            End If
        ElseIf searchMin = False And searchMax = True Then
            Do
                k = k + 1
                If YF1 <= YF0 Then
                    If Abs(H0) <= CDec(Tolerance / R) Then
                        H1 = H0
                        x1 = x0
                        YF1 = YF0
                        Label4.Text = "Answer: The maximum find with the given Tolerance = " & Tolerance
                        Exit Do
                    Else
                        H1 = -H0 / R
                        H0 = H1
                    End If
                Else
                    H1 = H0
                End If
                x0 = x1
                YF0 = YF1
                x1 = x0 + H1
                YF1 = F(x1)

                ProgressBar1.Visible = True
                ProgressBar1.Maximum = k + 0.00000001
                ProgressBar1.Value = k
                Thread.Sleep(0)

                If k = k_max Then
                    Dim rv As Long
                    rv = MsgBox("Attention: It isn't possible to find a solution with the given Tolerance = " & Tolerance & " and for a given Number Of Iterations = " & k_max & vbCrLf & "Continue searching?", vbYesNo Or vbQuestion)
                    If rv = vbYes Then
                        k_max = k_max + k_max
                        k_maxBox.Text = k_max
                    End If
                End If

            Loop While k < k_max

            If k >= k_max Then
                Label4.Text = "Attention: It isn't possible to find a solution with the given Tolerance = " & Tolerance & vbCrLf & "and for a given Number Of Iterations = " & k_max
            End If

        Else
            MsgBox("Error when choosing min/max: min = " & searchMin & " and max = " & searchMax)
        End If

        ProgressBar1.Visible = False
        SolutionOfTask = x1
        ValueOfFunction = YF0
        FinalH0 = Abs(H1)
    End Sub

End Class