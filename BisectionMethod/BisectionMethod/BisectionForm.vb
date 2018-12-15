
Option Explicit On
    Imports System.Math
    Imports info.lundin.math
    Imports System.Threading

Public Class BisectionForm

    Sub Clean()
        SolutionOfTaskBox.Text = "Solution Of Task"
        ValueOfFunctionBox.Text = "Value Of Function"
        NumberOfIterationsBox.Text = "Number Of Iterations"
        AbsErrorBox.Text = "final inaccuracy"
        elapsedTime.Text = "Elapsed time (in seconds)"
        Label4.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRunBisectionMethod.Click
        Dim started As DateTime = Now
        Dim finished As DateTime
        ProgressBar1.Value = 0
        Try
            If (funcBox.Text = "" Or LeftEndPointBox.Text = "" Or RightEndPointBox.Text = "" _
        Or ToleranceBox.Text = "" Or k_maxBox.Text = "") Then
                MsgBox("Input textboxes are empty! Enter the data")
            Else
                'Before a run the subroutine BM.start clearning of the former results will be performed
                Clean()
                Dim BM As BisectionMethod = New BisectionMethod()
                Label2.Text = "Analytical expression of the function is: f(x) = " & funcBox.Text
                BM.start(funcBox, LeftEndPointBox, RightEndPointBox, ToleranceBox,
                 k_maxBox, ProgressBar1, Label4)
                finished = Now
                elapsedTime.Text = finished.Subtract(started).Seconds
                'Timer to measure elapsed time from click to button and finishing iterations (in seconds)
                BM.out(SolutionOfTaskBox, ValueOfFunctionBox, NumberOfIterationsBox, AbsErrorBox)
            End If
        Catch ex As ParserException
            MsgBox("A mistake is in the analytical expression of the function f(x)")
        Catch ef As FormatException
            MsgBox("A mistake is in the format of the input data")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonClearOutPut.Click
        Clean()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ""
        SolutionOfTaskBox.Text = "solution of the problem"
        ValueOfFunctionBox.Text = "function value at point X*"
        NumberOfIterationsBox.Text = "number of iterations"
        AbsErrorBox.Text = "final inaccuracy"
        elapsedTime.Text = "elapsed time (in seconds)"
        Label4.Text = ""
    End Sub
End Class
