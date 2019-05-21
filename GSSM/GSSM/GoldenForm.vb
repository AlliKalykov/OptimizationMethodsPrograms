Option Explicit On
Imports System.Math
Imports info.lundin.math
Imports System.Threading
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports excel = Microsoft.Office.Interop.Excel
Imports app = Microsoft.Office.Interop.Excel.Application

Public Class GoldenForm

    Sub Clean()
        SolutionOfTaskBox.Text = "Solution Of Task"
        ValueOfFunctionBox.Text = "Value Of Function"
        NumberOfIterationsBox.Text = "Number Of Iterations"
        elapsedTime.Text = "Elapsed time (in seconds)"
        AbsErrorBox.Text = "Final solution’s"
        Label4.Text = ""
    End Sub

    Private Sub GoldenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ""
        SolutionOfTaskBox.Text = "Solution of the problem"
        ValueOfFunctionBox.Text = "Function value at point X*"
        NumberOfIterationsBox.Text = "Number of iterations"
        elapsedTime.Text = "Elapsed time (in seconds)"
        AbsErrorBox.Text = "Final solution’s"
        Label4.Text = ""
    End Sub

    Private Sub ButtonExit_Click_1(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub ButtonClearOutPut_Click(sender As Object, e As EventArgs) Handles ButtonClearOutPut.Click
        Clean()
    End Sub

    Private Sub RunGoldenSectionSearchMethod_Click(sender As Object, e As EventArgs) Handles RunGoldenSectionSearchMethod.Click
        Dim started As DateTime = Now
        Dim finished As DateTime
        ProgressBar1.Value = 0
        Try
            If (funcBox.Text = "" Or LeftEndPointBox.Text = "" Or RightEndPointBox.Text = "" Or
                        ToleranceBox.Text = "" Or k_maxBox.Text = "") Then
                MsgBox("Input textboxes are empty! Enter the data")
            Else
                Clean()
                If minRadioButton.Checked = True Then
                    Dim PM As GSSMmin = New GSSMmin()
                    Label2.Text = "Analytical expression of the function is: f(x) = " & funcBox.Text
                    PM.start(funcBox, LeftEndPointBox, RightEndPointBox, ToleranceBox,
                     k_maxBox, ProgressBar1, Label4)
                    finished = Now
                    elapsedTime.Text = finished.Subtract(started).Seconds
                    PM.out(SolutionOfTaskBox, ValueOfFunctionBox, NumberOfIterationsBox, AbsErrorBox)
                Else
                    Dim PM As GSSMmax = New GSSMmax
                    Label2.Text = "Analytical expression of the function is: f(x) = " & funcBox.Text
                    PM.start(funcBox, LeftEndPointBox, RightEndPointBox, ToleranceBox,
                     k_maxBox, ProgressBar1, Label4)
                    finished = Now
                    elapsedTime.Text = finished.Subtract(started).Seconds
                    PM.out(SolutionOfTaskBox, ValueOfFunctionBox, NumberOfIterationsBox, AbsErrorBox)
                End If
            End If

        Catch ex As ParserException
            MsgBox("A mistake is in the analytical expression of the function f(x)")
        Catch ef As FormatException
            MsgBox("A mistake is in the format of the input data")
        End Try
    End Sub

    Private Sub OpenExcel_Click(sender As Object, e As EventArgs) Handles OpenExcel.Click
        Dim workbook As Workbook
        Dim worksheet As Worksheet
        Dim func As String
        Const ex As String = "MO_LookingForOneOptPoint_02.04.2012.xls"
        func = funcBox.Text()

        '*************All "х" replace in "D4 for Excel
        Dim funcLength As Integer = func.Length()
        If func(0) = "x" Then
            If Char.IsLetter(func(1)) = False Then
                func = "D4" & Mid(func, 2, funcLength - 1)
                funcLength += 1
            End If
        End If

        If func(funcLength - 1) = "x" Then
            If Char.IsLetter(func(funcLength - 2)) = False Then
                func = Mid(func, 1, funcLength - 1) & "D4"
                funcLength += 1
            End If
        End If

        For i As Integer = 1 To funcLength - 1
            If func(i) = "x" Then
                If Char.IsLetter(func(i - 1)) = False And Char.IsLetter(func(i + 1)) = False Then
                    func = Mid(func, 1, i) & "D4" & Mid(func, i + 2, funcLength - i)
                End If
            End If
        Next
        '**************Ending replace

        Dim app As New excel.Application()
        workbook = app.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, ex))
        worksheet = TryCast(workbook.ActiveSheet, Worksheet)
        worksheet.Cells(4, 9) = LeftEndPointBox.Text
        worksheet.Cells(4, 10) = RightEndPointBox.Text
        worksheet.Range("E4").Value = "=" + func
        app.Visible = True
        TopMost = True
    End Sub

    Private Sub OpenExcel_Hover(sender As Object, e As EventArgs) Handles OpenExcel.MouseHover
        Dim toolTip1 As New ToolTip()

        toolTip1.ShowAlways = True

        toolTip1.SetToolTip(OpenExcel, "Открыть Excel файл, чтобы увидеть график функции на отрезке [" & LeftEndPointBox.Text() & ";" & RightEndPointBox.Text() & "]")
    End Sub
End Class
