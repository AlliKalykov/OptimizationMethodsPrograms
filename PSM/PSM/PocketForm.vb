Option Explicit On
Imports System.Math
Imports info.lundin.math
Imports System.Threading

Public Class PocketForm

    Sub Clean()
        SolutionOfTaskBox.Text = "Solution Of Task"
        ValueOfFunctionBox.Text = "Value Of Function"
        NumberOfIterationsBox.Text = "Number Of Iterations"
        elapsedTime.Text = "Elapsed time (in seconds)"
        H0box.Text = "Final solution’s"
        Label4.Text = ""
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ""
        SolutionOfTaskBox.Text = "Solution of the problem"
        ValueOfFunctionBox.Text = "Function value at point X*"
        NumberOfIterationsBox.Text = "Number of iterations"
        elapsedTime.Text = "Elapsed time (in seconds)"
        H0box.Text = "Final solution’s"
        Label4.Text = ""
    End Sub

    Private Sub ButtonExit_Click_1(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub ButtonClearOutPut_Click(sender As Object, e As EventArgs) Handles ButtonClearOutPut.Click
        Clean()
    End Sub

    Private Sub ButtonRunPocketSearchMethod_Click(sender As Object, e As EventArgs) Handles ButtonRunPocketSearchMethod.Click
        Dim started As DateTime = Now
        Dim finished As DateTime
        ProgressBar1.Value = 0
        Try
            If (funcBox.Text = "" Or InitialPointBox.Text = "" Or InitialStepBox.Text = "" _
                    Or DecreasingBox.Text = "" _
                    Or ToleranceBox.Text = "" Or k_maxBox.Text = "") Then
                MsgBox("Input textboxes are empty! Enter the data")
            Else
                Clean()
                Dim PM As PSM = New PSM()
                Label2.Text = "Analytical expression of the function is: f(x) = " & funcBox.Text
                PM.start(funcBox, InitialPointBox, ToleranceBox,
                 k_maxBox, DecreasingBox, InitialStepBox, minRadioButton, maxRadioButton,
                 ProgressBar1, Label4, H0box)
                finished = Now
                elapsedTime.Text = finished.Subtract(started).Seconds
                PM.out(SolutionOfTaskBox, ValueOfFunctionBox, NumberOfIterationsBox, H0box)
            End If
        Catch ex As ParserException
            MsgBox("A mistake is in the analytical expression of the function f(x)")
        Catch ef As FormatException
            MsgBox("A mistake is in the format of the input data")
        End Try
    End Sub

End Class