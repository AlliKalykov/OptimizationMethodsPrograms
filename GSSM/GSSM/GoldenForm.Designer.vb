<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldenForm
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
        Me.LabelFunctionValueX1 = New System.Windows.Forms.Label()
        Me.SolutionOfTaskBox = New System.Windows.Forms.TextBox()
        Me.LabelRootX1OfEquation = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.RunGoldenSectionSearchMethod = New System.Windows.Forms.Button()
        Me.ToleranceBox = New System.Windows.Forms.TextBox()
        Me.k_maxBox = New System.Windows.Forms.TextBox()
        Me.LabelTolerance = New System.Windows.Forms.Label()
        Me.LabelLimitOfIterations = New System.Windows.Forms.Label()
        Me.RightEndPointBox = New System.Windows.Forms.TextBox()
        Me.LeftEndPointBox = New System.Windows.Forms.TextBox()
        Me.LabelRightEndPoint = New System.Windows.Forms.Label()
        Me.LabelLeftEndPoint = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minRadioButton = New System.Windows.Forms.RadioButton()
        Me.maxRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.OpenExcel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'funcBox
        '
        Me.funcBox.Location = New System.Drawing.Point(26, 29)
        Me.funcBox.Name = "funcBox"
        Me.funcBox.Size = New System.Drawing.Size(276, 20)
        Me.funcBox.TabIndex = 100
        Me.funcBox.Text = "x^2-4*sin(x)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "empty"
        '
        'elapsedTime
        '
        Me.elapsedTime.Location = New System.Drawing.Point(378, 196)
        Me.elapsedTime.Name = "elapsedTime"
        Me.elapsedTime.ReadOnly = True
        Me.elapsedTime.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.elapsedTime.Size = New System.Drawing.Size(117, 20)
        Me.elapsedTime.TabIndex = 97
        Me.elapsedTime.Text = "Elapsed time (in seconds)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Elapsed time (in seconds):"
        '
        'ButtonClearOutPut
        '
        Me.ButtonClearOutPut.Location = New System.Drawing.Point(482, 237)
        Me.ButtonClearOutPut.Name = "ButtonClearOutPut"
        Me.ButtonClearOutPut.Size = New System.Drawing.Size(87, 30)
        Me.ButtonClearOutPut.TabIndex = 95
        Me.ButtonClearOutPut.Text = "ClearOutPut:"
        Me.ButtonClearOutPut.UseVisualStyleBackColor = True
        '
        'AbsErrorBox
        '
        Me.AbsErrorBox.Location = New System.Drawing.Point(509, 159)
        Me.AbsErrorBox.Name = "AbsErrorBox"
        Me.AbsErrorBox.ReadOnly = True
        Me.AbsErrorBox.Size = New System.Drawing.Size(83, 20)
        Me.AbsErrorBox.TabIndex = 94
        Me.AbsErrorBox.Text = "final inaccuracy"
        '
        'LabelAbsError
        '
        Me.LabelAbsError.AutoSize = True
        Me.LabelAbsError.Location = New System.Drawing.Point(452, 162)
        Me.LabelAbsError.Name = "LabelAbsError"
        Me.LabelAbsError.Size = New System.Drawing.Size(51, 13)
        Me.LabelAbsError.TabIndex = 93
        Me.LabelAbsError.Text = "Abs(b–a):"
        '
        'NumberOfIterationsBox
        '
        Me.NumberOfIterationsBox.Location = New System.Drawing.Point(120, 196)
        Me.NumberOfIterationsBox.Name = "NumberOfIterationsBox"
        Me.NumberOfIterationsBox.ReadOnly = True
        Me.NumberOfIterationsBox.Size = New System.Drawing.Size(107, 20)
        Me.NumberOfIterationsBox.TabIndex = 92
        Me.NumberOfIterationsBox.Text = "Number Of Iterations"
        '
        'LabelNumberOfIterations
        '
        Me.LabelNumberOfIterations.AutoSize = True
        Me.LabelNumberOfIterations.Location = New System.Drawing.Point(17, 199)
        Me.LabelNumberOfIterations.Name = "LabelNumberOfIterations"
        Me.LabelNumberOfIterations.Size = New System.Drawing.Size(101, 13)
        Me.LabelNumberOfIterations.TabIndex = 91
        Me.LabelNumberOfIterations.Text = "NumberOfIterations:"
        '
        'ValueOfFunctionBox
        '
        Me.ValueOfFunctionBox.Location = New System.Drawing.Point(293, 159)
        Me.ValueOfFunctionBox.Name = "ValueOfFunctionBox"
        Me.ValueOfFunctionBox.ReadOnly = True
        Me.ValueOfFunctionBox.Size = New System.Drawing.Size(153, 20)
        Me.ValueOfFunctionBox.TabIndex = 90
        Me.ValueOfFunctionBox.Text = "function value at point X1"
        '
        'LabelFunctionValueX1
        '
        Me.LabelFunctionValueX1.AutoSize = True
        Me.LabelFunctionValueX1.Location = New System.Drawing.Point(263, 162)
        Me.LabelFunctionValueX1.Name = "LabelFunctionValueX1"
        Me.LabelFunctionValueX1.Size = New System.Drawing.Size(32, 13)
        Me.LabelFunctionValueX1.TabIndex = 89
        Me.LabelFunctionValueX1.Text = "f(X1):"
        '
        'SolutionOfTaskBox
        '
        Me.SolutionOfTaskBox.Location = New System.Drawing.Point(44, 159)
        Me.SolutionOfTaskBox.Name = "SolutionOfTaskBox"
        Me.SolutionOfTaskBox.ReadOnly = True
        Me.SolutionOfTaskBox.Size = New System.Drawing.Size(206, 20)
        Me.SolutionOfTaskBox.TabIndex = 88
        Me.SolutionOfTaskBox.Text = "solution of the problem"
        '
        'LabelRootX1OfEquation
        '
        Me.LabelRootX1OfEquation.AutoSize = True
        Me.LabelRootX1OfEquation.Location = New System.Drawing.Point(19, 162)
        Me.LabelRootX1OfEquation.Name = "LabelRootX1OfEquation"
        Me.LabelRootX1OfEquation.Size = New System.Drawing.Size(23, 13)
        Me.LabelRootX1OfEquation.TabIndex = 87
        Me.LabelRootX1OfEquation.Text = "X1:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.Location = New System.Drawing.Point(26, 123)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(593, 20)
        Me.ProgressBar1.TabIndex = 86
        '
        'RunGoldenSectionSearchMethod
        '
        Me.RunGoldenSectionSearchMethod.Location = New System.Drawing.Point(357, 67)
        Me.RunGoldenSectionSearchMethod.Name = "RunGoldenSectionSearchMethod"
        Me.RunGoldenSectionSearchMethod.Size = New System.Drawing.Size(179, 43)
        Me.RunGoldenSectionSearchMethod.TabIndex = 85
        Me.RunGoldenSectionSearchMethod.Text = "RunGoldenSectionSearchMethod"
        Me.RunGoldenSectionSearchMethod.UseVisualStyleBackColor = True
        '
        'ToleranceBox
        '
        Me.ToleranceBox.Location = New System.Drawing.Point(26, 80)
        Me.ToleranceBox.Name = "ToleranceBox"
        Me.ToleranceBox.Size = New System.Drawing.Size(224, 20)
        Me.ToleranceBox.TabIndex = 84
        Me.ToleranceBox.Text = "1e-15"
        '
        'k_maxBox
        '
        Me.k_maxBox.Location = New System.Drawing.Point(283, 80)
        Me.k_maxBox.Name = "k_maxBox"
        Me.k_maxBox.Size = New System.Drawing.Size(50, 20)
        Me.k_maxBox.TabIndex = 83
        Me.k_maxBox.Text = "100"
        '
        'LabelTolerance
        '
        Me.LabelTolerance.AutoSize = True
        Me.LabelTolerance.Location = New System.Drawing.Point(23, 64)
        Me.LabelTolerance.Name = "LabelTolerance"
        Me.LabelTolerance.Size = New System.Drawing.Size(55, 13)
        Me.LabelTolerance.TabIndex = 82
        Me.LabelTolerance.Text = "Tolerance"
        '
        'LabelLimitOfIterations
        '
        Me.LabelLimitOfIterations.AutoSize = True
        Me.LabelLimitOfIterations.Location = New System.Drawing.Point(266, 64)
        Me.LabelLimitOfIterations.Name = "LabelLimitOfIterations"
        Me.LabelLimitOfIterations.Size = New System.Drawing.Size(85, 13)
        Me.LabelLimitOfIterations.TabIndex = 81
        Me.LabelLimitOfIterations.Text = "LimitOfIterations:"
        '
        'RightEndPointBox
        '
        Me.RightEndPointBox.Location = New System.Drawing.Point(440, 29)
        Me.RightEndPointBox.Name = "RightEndPointBox"
        Me.RightEndPointBox.Size = New System.Drawing.Size(75, 20)
        Me.RightEndPointBox.TabIndex = 80
        Me.RightEndPointBox.Text = "3"
        '
        'LeftEndPointBox
        '
        Me.LeftEndPointBox.Location = New System.Drawing.Point(347, 29)
        Me.LeftEndPointBox.Name = "LeftEndPointBox"
        Me.LeftEndPointBox.Size = New System.Drawing.Size(75, 20)
        Me.LeftEndPointBox.TabIndex = 79
        Me.LeftEndPointBox.Text = "1"
        '
        'LabelRightEndPoint
        '
        Me.LabelRightEndPoint.AutoSize = True
        Me.LabelRightEndPoint.Location = New System.Drawing.Point(437, 11)
        Me.LabelRightEndPoint.Name = "LabelRightEndPoint"
        Me.LabelRightEndPoint.Size = New System.Drawing.Size(78, 13)
        Me.LabelRightEndPoint.TabIndex = 78
        Me.LabelRightEndPoint.Text = "RightEndPoint:"
        '
        'LabelLeftEndPoint
        '
        Me.LabelLeftEndPoint.AutoSize = True
        Me.LabelLeftEndPoint.Location = New System.Drawing.Point(346, 11)
        Me.LabelLeftEndPoint.Name = "LabelLeftEndPoint"
        Me.LabelLeftEndPoint.Size = New System.Drawing.Size(71, 13)
        Me.LabelLeftEndPoint.TabIndex = 77
        Me.LabelLeftEndPoint.Text = "LeftEndPoint:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Function f(X):"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.minRadioButton)
        Me.Panel1.Controls.Add(Me.maxRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(542, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(77, 77)
        Me.Panel1.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Search:"
        '
        'minRadioButton
        '
        Me.minRadioButton.AutoSize = True
        Me.minRadioButton.Checked = True
        Me.minRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.minRadioButton.Location = New System.Drawing.Point(13, 22)
        Me.minRadioButton.Name = "minRadioButton"
        Me.minRadioButton.Size = New System.Drawing.Size(48, 21)
        Me.minRadioButton.TabIndex = 76
        Me.minRadioButton.TabStop = True
        Me.minRadioButton.Text = "min"
        Me.minRadioButton.UseVisualStyleBackColor = True
        '
        'maxRadioButton
        '
        Me.maxRadioButton.AutoSize = True
        Me.maxRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.maxRadioButton.Location = New System.Drawing.Point(13, 48)
        Me.maxRadioButton.Name = "maxRadioButton"
        Me.maxRadioButton.Size = New System.Drawing.Size(51, 21)
        Me.maxRadioButton.TabIndex = 77
        Me.maxRadioButton.Text = "max"
        Me.maxRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(584, 237)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(35, 30)
        Me.ButtonExit.TabIndex = 113
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'OpenExcel
        '
        Me.OpenExcel.Location = New System.Drawing.Point(520, 189)
        Me.OpenExcel.Name = "OpenExcel"
        Me.OpenExcel.Size = New System.Drawing.Size(99, 32)
        Me.OpenExcel.TabIndex = 114
        Me.OpenExcel.Text = "Open Excel"
        Me.OpenExcel.UseVisualStyleBackColor = True
        '
        'GoldenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 275)
        Me.Controls.Add(Me.OpenExcel)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.LabelFunctionValueX1)
        Me.Controls.Add(Me.SolutionOfTaskBox)
        Me.Controls.Add(Me.LabelRootX1OfEquation)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.RunGoldenSectionSearchMethod)
        Me.Controls.Add(Me.ToleranceBox)
        Me.Controls.Add(Me.k_maxBox)
        Me.Controls.Add(Me.LabelTolerance)
        Me.Controls.Add(Me.LabelLimitOfIterations)
        Me.Controls.Add(Me.RightEndPointBox)
        Me.Controls.Add(Me.LeftEndPointBox)
        Me.Controls.Add(Me.LabelRightEndPoint)
        Me.Controls.Add(Me.LabelLeftEndPoint)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GoldenForm"
        Me.Text = "Golden Section Search Method"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents LabelFunctionValueX1 As Label
    Friend WithEvents SolutionOfTaskBox As TextBox
    Friend WithEvents LabelRootX1OfEquation As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents RunGoldenSectionSearchMethod As Button
    Friend WithEvents ToleranceBox As TextBox
    Friend WithEvents k_maxBox As TextBox
    Friend WithEvents LabelTolerance As Label
    Friend WithEvents LabelLimitOfIterations As Label
    Friend WithEvents RightEndPointBox As TextBox
    Friend WithEvents LeftEndPointBox As TextBox
    Friend WithEvents LabelRightEndPoint As Label
    Friend WithEvents LabelLeftEndPoint As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minRadioButton As RadioButton
    Friend WithEvents maxRadioButton As RadioButton
    Friend WithEvents ButtonExit As Button
    Friend WithEvents OpenExcel As Button
End Class
