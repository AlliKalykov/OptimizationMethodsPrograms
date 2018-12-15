<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BisectionForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.funcBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.elapsedTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonClearOutPut = New System.Windows.Forms.Button()
        Me.AbsErrorBox = New System.Windows.Forms.TextBox()
        Me.LabelAbsError = New System.Windows.Forms.Label()
        Me.NumberOfIterationsBox = New System.Windows.Forms.TextBox()
        Me.LabelNumberOfIterations = New System.Windows.Forms.Label()
        Me.ValueOfFunctionBox = New System.Windows.Forms.TextBox()
        Me.LabelFunctionValue = New System.Windows.Forms.Label()
        Me.SolutionOfTaskBox = New System.Windows.Forms.TextBox()
        Me.LabelRootOfEquation = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonRunBisectionMethod = New System.Windows.Forms.Button()
        Me.ToleranceBox = New System.Windows.Forms.TextBox()
        Me.k_maxBox = New System.Windows.Forms.TextBox()
        Me.LabelTolerance = New System.Windows.Forms.Label()
        Me.LabelLimitOfIterations = New System.Windows.Forms.Label()
        Me.RightEndPointBox = New System.Windows.Forms.TextBox()
        Me.LeftEndPointBox = New System.Windows.Forms.TextBox()
        Me.LabelRightEndPoint = New System.Windows.Forms.Label()
        Me.LabelLeftEndPoint = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'funcBox
        '
        Me.funcBox.Location = New System.Drawing.Point(21, 34)
        Me.funcBox.Name = "funcBox"
        Me.funcBox.Size = New System.Drawing.Size(276, 20)
        Me.funcBox.TabIndex = 75
        Me.funcBox.Text = "x^2-4*sin(x)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "empty"
        '
        'elapsedTime
        '
        Me.elapsedTime.Location = New System.Drawing.Point(498, 199)
        Me.elapsedTime.Name = "elapsedTime"
        Me.elapsedTime.ReadOnly = True
        Me.elapsedTime.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.elapsedTime.Size = New System.Drawing.Size(117, 20)
        Me.elapsedTime.TabIndex = 72
        Me.elapsedTime.Text = "Elapsed time (in seconds)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Elapsed time (in seconds):"
        '
        'ButtonClearOutPut
        '
        Me.ButtonClearOutPut.Location = New System.Drawing.Point(527, 151)
        Me.ButtonClearOutPut.Name = "ButtonClearOutPut"
        Me.ButtonClearOutPut.Size = New System.Drawing.Size(87, 30)
        Me.ButtonClearOutPut.TabIndex = 70
        Me.ButtonClearOutPut.Text = "ClearOutPut:"
        Me.ButtonClearOutPut.UseVisualStyleBackColor = True
        '
        'AbsErrorBox
        '
        Me.AbsErrorBox.Location = New System.Drawing.Point(275, 198)
        Me.AbsErrorBox.Name = "AbsErrorBox"
        Me.AbsErrorBox.ReadOnly = True
        Me.AbsErrorBox.Size = New System.Drawing.Size(83, 20)
        Me.AbsErrorBox.TabIndex = 69
        Me.AbsErrorBox.Text = "final inaccuracy"
        '
        'LabelAbsError
        '
        Me.LabelAbsError.AutoSize = True
        Me.LabelAbsError.Location = New System.Drawing.Point(218, 201)
        Me.LabelAbsError.Name = "LabelAbsError"
        Me.LabelAbsError.Size = New System.Drawing.Size(51, 13)
        Me.LabelAbsError.TabIndex = 68
        Me.LabelAbsError.Text = "Abs(b–a):"
        '
        'NumberOfIterationsBox
        '
        Me.NumberOfIterationsBox.Location = New System.Drawing.Point(393, 157)
        Me.NumberOfIterationsBox.Name = "NumberOfIterationsBox"
        Me.NumberOfIterationsBox.ReadOnly = True
        Me.NumberOfIterationsBox.Size = New System.Drawing.Size(107, 20)
        Me.NumberOfIterationsBox.TabIndex = 67
        Me.NumberOfIterationsBox.Text = "Number Of Iterations"
        '
        'LabelNumberOfIterations
        '
        Me.LabelNumberOfIterations.AutoSize = True
        Me.LabelNumberOfIterations.Location = New System.Drawing.Point(290, 160)
        Me.LabelNumberOfIterations.Name = "LabelNumberOfIterations"
        Me.LabelNumberOfIterations.Size = New System.Drawing.Size(101, 13)
        Me.LabelNumberOfIterations.TabIndex = 66
        Me.LabelNumberOfIterations.Text = "NumberOfIterations:"
        '
        'ValueOfFunctionBox
        '
        Me.ValueOfFunctionBox.Location = New System.Drawing.Point(79, 196)
        Me.ValueOfFunctionBox.Name = "ValueOfFunctionBox"
        Me.ValueOfFunctionBox.ReadOnly = True
        Me.ValueOfFunctionBox.Size = New System.Drawing.Size(126, 20)
        Me.ValueOfFunctionBox.TabIndex = 65
        Me.ValueOfFunctionBox.Text = "function value at point X*"
        '
        'LabelFunctionValue
        '
        Me.LabelFunctionValue.AutoSize = True
        Me.LabelFunctionValue.Location = New System.Drawing.Point(31, 199)
        Me.LabelFunctionValue.Name = "LabelFunctionValue"
        Me.LabelFunctionValue.Size = New System.Drawing.Size(30, 13)
        Me.LabelFunctionValue.TabIndex = 64
        Me.LabelFunctionValue.Text = "f(X*):"
        '
        'SolutionOfTaskBox
        '
        Me.SolutionOfTaskBox.Location = New System.Drawing.Point(79, 157)
        Me.SolutionOfTaskBox.Name = "SolutionOfTaskBox"
        Me.SolutionOfTaskBox.ReadOnly = True
        Me.SolutionOfTaskBox.Size = New System.Drawing.Size(206, 20)
        Me.SolutionOfTaskBox.TabIndex = 63
        Me.SolutionOfTaskBox.Text = "solution of the problem"
        '
        'LabelRootOfEquation
        '
        Me.LabelRootOfEquation.AutoSize = True
        Me.LabelRootOfEquation.Location = New System.Drawing.Point(16, 160)
        Me.LabelRootOfEquation.Name = "LabelRootOfEquation"
        Me.LabelRootOfEquation.Size = New System.Drawing.Size(57, 13)
        Me.LabelRootOfEquation.TabIndex = 62
        Me.LabelRootOfEquation.Text = "Root is X*:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 121)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(593, 20)
        Me.ProgressBar1.TabIndex = 61
        '
        'ButtonRunBisectionMethod
        '
        Me.ButtonRunBisectionMethod.Location = New System.Drawing.Point(398, 62)
        Me.ButtonRunBisectionMethod.Name = "ButtonRunBisectionMethod"
        Me.ButtonRunBisectionMethod.Size = New System.Drawing.Size(217, 43)
        Me.ButtonRunBisectionMethod.TabIndex = 60
        Me.ButtonRunBisectionMethod.Text = "RunBisectionMethod"
        Me.ButtonRunBisectionMethod.UseVisualStyleBackColor = True
        '
        'ToleranceBox
        '
        Me.ToleranceBox.Location = New System.Drawing.Point(21, 85)
        Me.ToleranceBox.Name = "ToleranceBox"
        Me.ToleranceBox.Size = New System.Drawing.Size(224, 20)
        Me.ToleranceBox.TabIndex = 59
        Me.ToleranceBox.Text = "1e-15"
        '
        'k_maxBox
        '
        Me.k_maxBox.Location = New System.Drawing.Point(302, 85)
        Me.k_maxBox.Name = "k_maxBox"
        Me.k_maxBox.Size = New System.Drawing.Size(50, 20)
        Me.k_maxBox.TabIndex = 58
        Me.k_maxBox.Text = "100"
        '
        'LabelTolerance
        '
        Me.LabelTolerance.AutoSize = True
        Me.LabelTolerance.Location = New System.Drawing.Point(18, 69)
        Me.LabelTolerance.Name = "LabelTolerance"
        Me.LabelTolerance.Size = New System.Drawing.Size(55, 13)
        Me.LabelTolerance.TabIndex = 57
        Me.LabelTolerance.Text = "Tolerance"
        '
        'LabelLimitOfIterations
        '
        Me.LabelLimitOfIterations.AutoSize = True
        Me.LabelLimitOfIterations.Location = New System.Drawing.Point(285, 69)
        Me.LabelLimitOfIterations.Name = "LabelLimitOfIterations"
        Me.LabelLimitOfIterations.Size = New System.Drawing.Size(85, 13)
        Me.LabelLimitOfIterations.TabIndex = 56
        Me.LabelLimitOfIterations.Text = "LimitOfIterations:"
        '
        'RightEndPointBox
        '
        Me.RightEndPointBox.Location = New System.Drawing.Point(528, 35)
        Me.RightEndPointBox.Name = "RightEndPointBox"
        Me.RightEndPointBox.Size = New System.Drawing.Size(75, 20)
        Me.RightEndPointBox.TabIndex = 55
        Me.RightEndPointBox.Text = "3"
        '
        'LeftEndPointBox
        '
        Me.LeftEndPointBox.Location = New System.Drawing.Point(423, 35)
        Me.LeftEndPointBox.Name = "LeftEndPointBox"
        Me.LeftEndPointBox.Size = New System.Drawing.Size(75, 20)
        Me.LeftEndPointBox.TabIndex = 54
        Me.LeftEndPointBox.Text = "1"
        '
        'LabelRightEndPoint
        '
        Me.LabelRightEndPoint.AutoSize = True
        Me.LabelRightEndPoint.Location = New System.Drawing.Point(525, 17)
        Me.LabelRightEndPoint.Name = "LabelRightEndPoint"
        Me.LabelRightEndPoint.Size = New System.Drawing.Size(78, 13)
        Me.LabelRightEndPoint.TabIndex = 53
        Me.LabelRightEndPoint.Text = "RightEndPoint:"
        '
        'LabelLeftEndPoint
        '
        Me.LabelLeftEndPoint.AutoSize = True
        Me.LabelLeftEndPoint.Location = New System.Drawing.Point(422, 17)
        Me.LabelLeftEndPoint.Name = "LabelLeftEndPoint"
        Me.LabelLeftEndPoint.Size = New System.Drawing.Size(71, 13)
        Me.LabelLeftEndPoint.TabIndex = 52
        Me.LabelLeftEndPoint.Text = "LeftEndPoint:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Function f(X):"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 254)
        Me.Controls.Add(Me.funcBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.elapsedTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonClearOutPut)
        Me.Controls.Add(Me.AbsErrorBox)
        Me.Controls.Add(Me.LabelAbsError)
        Me.Controls.Add(Me.NumberOfIterationsBox)
        Me.Controls.Add(Me.LabelNumberOfIterations)
        Me.Controls.Add(Me.ValueOfFunctionBox)
        Me.Controls.Add(Me.LabelFunctionValue)
        Me.Controls.Add(Me.SolutionOfTaskBox)
        Me.Controls.Add(Me.LabelRootOfEquation)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButtonRunBisectionMethod)
        Me.Controls.Add(Me.ToleranceBox)
        Me.Controls.Add(Me.k_maxBox)
        Me.Controls.Add(Me.LabelTolerance)
        Me.Controls.Add(Me.LabelLimitOfIterations)
        Me.Controls.Add(Me.RightEndPointBox)
        Me.Controls.Add(Me.LeftEndPointBox)
        Me.Controls.Add(Me.LabelRightEndPoint)
        Me.Controls.Add(Me.LabelLeftEndPoint)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents funcBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents elapsedTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonClearOutPut As Button
    Friend WithEvents AbsErrorBox As TextBox
    Friend WithEvents LabelAbsError As Label
    Friend WithEvents NumberOfIterationsBox As TextBox
    Friend WithEvents LabelNumberOfIterations As Label
    Friend WithEvents ValueOfFunctionBox As TextBox
    Friend WithEvents LabelFunctionValue As Label
    Friend WithEvents SolutionOfTaskBox As TextBox
    Friend WithEvents LabelRootOfEquation As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ButtonRunBisectionMethod As Button
    Friend WithEvents ToleranceBox As TextBox
    Friend WithEvents k_maxBox As TextBox
    Friend WithEvents LabelTolerance As Label
    Friend WithEvents LabelLimitOfIterations As Label
    Friend WithEvents RightEndPointBox As TextBox
    Friend WithEvents LeftEndPointBox As TextBox
    Friend WithEvents LabelRightEndPoint As Label
    Friend WithEvents LabelLeftEndPoint As Label
    Friend WithEvents Label1 As Label
End Class
