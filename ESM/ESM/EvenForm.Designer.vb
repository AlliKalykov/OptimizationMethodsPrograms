<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvenForm
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
        Me.CondBox = New System.Windows.Forms.TextBox()
        Me.CondLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AbsBox = New System.Windows.Forms.TextBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minRadioButton = New System.Windows.Forms.RadioButton()
        Me.maxRadioButton = New System.Windows.Forms.RadioButton()
        Me.funcBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.elapsedTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonClearOutPut = New System.Windows.Forms.Button()
        Me.NumberOfIterationsBox = New System.Windows.Forms.TextBox()
        Me.LabelNumberOfIterations = New System.Windows.Forms.Label()
        Me.ValueOfFunctionBox = New System.Windows.Forms.TextBox()
        Me.LabelFunctionValue = New System.Windows.Forms.Label()
        Me.SolutionOfTaskBox = New System.Windows.Forms.TextBox()
        Me.LabelRootOfEquation = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonRunEvenSearchMethod = New System.Windows.Forms.Button()
        Me.ToleranceBox = New System.Windows.Forms.TextBox()
        Me.k_maxBox = New System.Windows.Forms.TextBox()
        Me.LabelTolerance = New System.Windows.Forms.Label()
        Me.LabelLimitOfIterations = New System.Windows.Forms.Label()
        Me.InitialPointBox = New System.Windows.Forms.TextBox()
        Me.LabelLeftEndPoint = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CondBox
        '
        Me.CondBox.Location = New System.Drawing.Point(384, 301)
        Me.CondBox.Name = "CondBox"
        Me.CondBox.ReadOnly = True
        Me.CondBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.CondBox.Size = New System.Drawing.Size(117, 20)
        Me.CondBox.TabIndex = 147
        '
        'CondLabel
        '
        Me.CondLabel.AutoSize = True
        Me.CondLabel.Location = New System.Drawing.Point(345, 304)
        Me.CondLabel.Name = "CondLabel"
        Me.CondLabel.Size = New System.Drawing.Size(35, 13)
        Me.CondLabel.TabIndex = 146
        Me.CondLabel.Text = "Cond:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "abs(X1-X0):"
        '
        'AbsBox
        '
        Me.AbsBox.Location = New System.Drawing.Point(68, 301)
        Me.AbsBox.Name = "AbsBox"
        Me.AbsBox.ReadOnly = True
        Me.AbsBox.Size = New System.Drawing.Size(230, 20)
        Me.AbsBox.TabIndex = 144
        Me.AbsBox.Text = "final solution’s"
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(458, 368)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(35, 30)
        Me.ButtonExit.TabIndex = 143
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.minRadioButton)
        Me.Panel1.Controls.Add(Me.maxRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(331, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(77, 77)
        Me.Panel1.TabIndex = 138
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
        'funcBox
        '
        Me.funcBox.Location = New System.Drawing.Point(22, 28)
        Me.funcBox.Name = "funcBox"
        Me.funcBox.Size = New System.Drawing.Size(276, 20)
        Me.funcBox.TabIndex = 137
        Me.funcBox.Text = "x^2-4*sin(x)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "empty"
        '
        'elapsedTime
        '
        Me.elapsedTime.Location = New System.Drawing.Point(384, 266)
        Me.elapsedTime.Name = "elapsedTime"
        Me.elapsedTime.ReadOnly = True
        Me.elapsedTime.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.elapsedTime.Size = New System.Drawing.Size(117, 20)
        Me.elapsedTime.TabIndex = 134
        Me.elapsedTime.Text = "Elapsed time (in seconds)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Elapsed time (in seconds):"
        '
        'ButtonClearOutPut
        '
        Me.ButtonClearOutPut.Location = New System.Drawing.Point(361, 368)
        Me.ButtonClearOutPut.Name = "ButtonClearOutPut"
        Me.ButtonClearOutPut.Size = New System.Drawing.Size(76, 30)
        Me.ButtonClearOutPut.TabIndex = 132
        Me.ButtonClearOutPut.Text = "ClearOutPut"
        Me.ButtonClearOutPut.UseVisualStyleBackColor = True
        '
        'NumberOfIterationsBox
        '
        Me.NumberOfIterationsBox.Location = New System.Drawing.Point(394, 225)
        Me.NumberOfIterationsBox.Name = "NumberOfIterationsBox"
        Me.NumberOfIterationsBox.ReadOnly = True
        Me.NumberOfIterationsBox.Size = New System.Drawing.Size(107, 20)
        Me.NumberOfIterationsBox.TabIndex = 131
        Me.NumberOfIterationsBox.Text = "Number Of Iterations"
        '
        'LabelNumberOfIterations
        '
        Me.LabelNumberOfIterations.AutoSize = True
        Me.LabelNumberOfIterations.Location = New System.Drawing.Point(291, 228)
        Me.LabelNumberOfIterations.Name = "LabelNumberOfIterations"
        Me.LabelNumberOfIterations.Size = New System.Drawing.Size(101, 13)
        Me.LabelNumberOfIterations.TabIndex = 130
        Me.LabelNumberOfIterations.Text = "NumberOfIterations:"
        '
        'ValueOfFunctionBox
        '
        Me.ValueOfFunctionBox.Location = New System.Drawing.Point(68, 263)
        Me.ValueOfFunctionBox.Name = "ValueOfFunctionBox"
        Me.ValueOfFunctionBox.ReadOnly = True
        Me.ValueOfFunctionBox.Size = New System.Drawing.Size(176, 20)
        Me.ValueOfFunctionBox.TabIndex = 129
        Me.ValueOfFunctionBox.Text = "function value at point X*"
        '
        'LabelFunctionValue
        '
        Me.LabelFunctionValue.AutoSize = True
        Me.LabelFunctionValue.Location = New System.Drawing.Point(32, 266)
        Me.LabelFunctionValue.Name = "LabelFunctionValue"
        Me.LabelFunctionValue.Size = New System.Drawing.Size(36, 13)
        Me.LabelFunctionValue.TabIndex = 128
        Me.LabelFunctionValue.Text = "f1(X*):"
        '
        'SolutionOfTaskBox
        '
        Me.SolutionOfTaskBox.Location = New System.Drawing.Point(68, 225)
        Me.SolutionOfTaskBox.Name = "SolutionOfTaskBox"
        Me.SolutionOfTaskBox.ReadOnly = True
        Me.SolutionOfTaskBox.Size = New System.Drawing.Size(206, 20)
        Me.SolutionOfTaskBox.TabIndex = 127
        Me.SolutionOfTaskBox.Text = "solution of the problem"
        '
        'LabelRootOfEquation
        '
        Me.LabelRootOfEquation.AutoSize = True
        Me.LabelRootOfEquation.Location = New System.Drawing.Point(38, 228)
        Me.LabelRootOfEquation.Name = "LabelRootOfEquation"
        Me.LabelRootOfEquation.Size = New System.Drawing.Size(27, 13)
        Me.LabelRootOfEquation.TabIndex = 126
        Me.LabelRootOfEquation.Text = "X1*:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 181)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(481, 20)
        Me.ProgressBar1.TabIndex = 125
        '
        'ButtonRunEvenSearchMethod
        '
        Me.ButtonRunEvenSearchMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonRunEvenSearchMethod.Location = New System.Drawing.Point(226, 120)
        Me.ButtonRunEvenSearchMethod.Name = "ButtonRunEvenSearchMethod"
        Me.ButtonRunEvenSearchMethod.Size = New System.Drawing.Size(182, 41)
        Me.ButtonRunEvenSearchMethod.TabIndex = 124
        Me.ButtonRunEvenSearchMethod.Text = "RunEvenSearchMethod"
        Me.ButtonRunEvenSearchMethod.UseVisualStyleBackColor = True
        '
        'ToleranceBox
        '
        Me.ToleranceBox.Location = New System.Drawing.Point(20, 139)
        Me.ToleranceBox.Name = "ToleranceBox"
        Me.ToleranceBox.Size = New System.Drawing.Size(87, 20)
        Me.ToleranceBox.TabIndex = 123
        Me.ToleranceBox.Text = "1e-1"
        '
        'k_maxBox
        '
        Me.k_maxBox.Location = New System.Drawing.Point(151, 81)
        Me.k_maxBox.Name = "k_maxBox"
        Me.k_maxBox.Size = New System.Drawing.Size(91, 20)
        Me.k_maxBox.TabIndex = 122
        Me.k_maxBox.Text = "100"
        '
        'LabelTolerance
        '
        Me.LabelTolerance.AutoSize = True
        Me.LabelTolerance.Location = New System.Drawing.Point(17, 120)
        Me.LabelTolerance.Name = "LabelTolerance"
        Me.LabelTolerance.Size = New System.Drawing.Size(58, 13)
        Me.LabelTolerance.TabIndex = 121
        Me.LabelTolerance.Text = "Tolerance:"
        '
        'LabelLimitOfIterations
        '
        Me.LabelLimitOfIterations.AutoSize = True
        Me.LabelLimitOfIterations.Location = New System.Drawing.Point(148, 62)
        Me.LabelLimitOfIterations.Name = "LabelLimitOfIterations"
        Me.LabelLimitOfIterations.Size = New System.Drawing.Size(85, 13)
        Me.LabelLimitOfIterations.TabIndex = 120
        Me.LabelLimitOfIterations.Text = "LimitOfIterations:"
        '
        'InitialPointBox
        '
        Me.InitialPointBox.Location = New System.Drawing.Point(20, 83)
        Me.InitialPointBox.Name = "InitialPointBox"
        Me.InitialPointBox.Size = New System.Drawing.Size(87, 20)
        Me.InitialPointBox.TabIndex = 119
        Me.InitialPointBox.Text = "-2"
        '
        'LabelLeftEndPoint
        '
        Me.LabelLeftEndPoint.AutoSize = True
        Me.LabelLeftEndPoint.Location = New System.Drawing.Point(9, 62)
        Me.LabelLeftEndPoint.Name = "LabelLeftEndPoint"
        Me.LabelLeftEndPoint.Size = New System.Drawing.Size(107, 13)
        Me.LabelLeftEndPoint.TabIndex = 118
        Me.LabelLeftEndPoint.Text = "Initial point to search:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Function f(X):"
        '
        'EvenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 410)
        Me.Controls.Add(Me.CondBox)
        Me.Controls.Add(Me.CondLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AbsBox)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.funcBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.elapsedTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonClearOutPut)
        Me.Controls.Add(Me.NumberOfIterationsBox)
        Me.Controls.Add(Me.LabelNumberOfIterations)
        Me.Controls.Add(Me.ValueOfFunctionBox)
        Me.Controls.Add(Me.LabelFunctionValue)
        Me.Controls.Add(Me.SolutionOfTaskBox)
        Me.Controls.Add(Me.LabelRootOfEquation)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButtonRunEvenSearchMethod)
        Me.Controls.Add(Me.ToleranceBox)
        Me.Controls.Add(Me.k_maxBox)
        Me.Controls.Add(Me.LabelTolerance)
        Me.Controls.Add(Me.LabelLimitOfIterations)
        Me.Controls.Add(Me.InitialPointBox)
        Me.Controls.Add(Me.LabelLeftEndPoint)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EvenForm"
        Me.Text = "Even search method"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CondBox As TextBox
    Friend WithEvents CondLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AbsBox As TextBox
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minRadioButton As RadioButton
    Friend WithEvents maxRadioButton As RadioButton
    Friend WithEvents funcBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents elapsedTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonClearOutPut As Button
    Friend WithEvents NumberOfIterationsBox As TextBox
    Friend WithEvents LabelNumberOfIterations As Label
    Friend WithEvents ValueOfFunctionBox As TextBox
    Friend WithEvents LabelFunctionValue As Label
    Friend WithEvents SolutionOfTaskBox As TextBox
    Friend WithEvents LabelRootOfEquation As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ButtonRunEvenSearchMethod As Button
    Friend WithEvents ToleranceBox As TextBox
    Friend WithEvents k_maxBox As TextBox
    Friend WithEvents LabelTolerance As Label
    Friend WithEvents LabelLimitOfIterations As Label
    Friend WithEvents InitialPointBox As TextBox
    Friend WithEvents LabelLeftEndPoint As Label
    Friend WithEvents Label1 As Label
End Class
