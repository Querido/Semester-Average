<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.lblGradeOne = New System.Windows.Forms.Label()
        Me.txtGradeOne = New System.Windows.Forms.TextBox()
        Me.txtGradeTwo = New System.Windows.Forms.TextBox()
        Me.lblGradeTwo = New System.Windows.Forms.Label()
        Me.lblCourseTwo = New System.Windows.Forms.Label()
        Me.txtGradeThree = New System.Windows.Forms.TextBox()
        Me.lblGradeThree = New System.Windows.Forms.Label()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.txtGradeFour = New System.Windows.Forms.TextBox()
        Me.lblGradeFour = New System.Windows.Forms.Label()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.txtGradeFive = New System.Windows.Forms.TextBox()
        Me.lblGradeFive = New System.Windows.Forms.Label()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.txtGradeSix = New System.Windows.Forms.TextBox()
        Me.lblGradeSix = New System.Windows.Forms.Label()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.lblGradeFinal = New System.Windows.Forms.Label()
        Me.lblCourseFinal = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSemesterFinal = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Location = New System.Drawing.Point(13, 13)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course 1:"
        Me.lblCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGradeOne
        '
        Me.lblGradeOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeOne.Location = New System.Drawing.Point(210, 12)
        Me.lblGradeOne.Name = "lblGradeOne"
        Me.lblGradeOne.Size = New System.Drawing.Size(108, 24)
        Me.lblGradeOne.TabIndex = 2
        Me.lblGradeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGradeOne
        '
        Me.txtGradeOne.Location = New System.Drawing.Point(87, 10)
        Me.txtGradeOne.Name = "txtGradeOne"
        Me.txtGradeOne.Size = New System.Drawing.Size(100, 22)
        Me.txtGradeOne.TabIndex = 1
        Me.txtGradeOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtGradeOne, "Grade for course one")
        '
        'txtGradeTwo
        '
        Me.txtGradeTwo.Location = New System.Drawing.Point(87, 38)
        Me.txtGradeTwo.Name = "txtGradeTwo"
        Me.txtGradeTwo.Size = New System.Drawing.Size(100, 22)
        Me.txtGradeTwo.TabIndex = 4
        Me.txtGradeTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtGradeTwo, "Grade for course two")
        '
        'lblGradeTwo
        '
        Me.lblGradeTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeTwo.Location = New System.Drawing.Point(210, 40)
        Me.lblGradeTwo.Name = "lblGradeTwo"
        Me.lblGradeTwo.Size = New System.Drawing.Size(108, 24)
        Me.lblGradeTwo.TabIndex = 5
        Me.lblGradeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseTwo
        '
        Me.lblCourseTwo.Location = New System.Drawing.Point(13, 41)
        Me.lblCourseTwo.Name = "lblCourseTwo"
        Me.lblCourseTwo.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseTwo.TabIndex = 3
        Me.lblCourseTwo.Text = "Course 2:"
        Me.lblCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGradeThree
        '
        Me.txtGradeThree.Location = New System.Drawing.Point(87, 66)
        Me.txtGradeThree.Name = "txtGradeThree"
        Me.txtGradeThree.Size = New System.Drawing.Size(100, 22)
        Me.txtGradeThree.TabIndex = 7
        Me.txtGradeThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtGradeThree, "Grade for course three")
        '
        'lblGradeThree
        '
        Me.lblGradeThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeThree.Location = New System.Drawing.Point(210, 68)
        Me.lblGradeThree.Name = "lblGradeThree"
        Me.lblGradeThree.Size = New System.Drawing.Size(108, 24)
        Me.lblGradeThree.TabIndex = 8
        Me.lblGradeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseThree
        '
        Me.lblCourseThree.Location = New System.Drawing.Point(13, 69)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseThree.TabIndex = 6
        Me.lblCourseThree.Text = "Course 3:"
        Me.lblCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGradeFour
        '
        Me.txtGradeFour.Location = New System.Drawing.Point(87, 94)
        Me.txtGradeFour.Name = "txtGradeFour"
        Me.txtGradeFour.Size = New System.Drawing.Size(100, 22)
        Me.txtGradeFour.TabIndex = 10
        Me.txtGradeFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtGradeFour, "Grade for course four")
        '
        'lblGradeFour
        '
        Me.lblGradeFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeFour.Location = New System.Drawing.Point(210, 96)
        Me.lblGradeFour.Name = "lblGradeFour"
        Me.lblGradeFour.Size = New System.Drawing.Size(108, 24)
        Me.lblGradeFour.TabIndex = 11
        Me.lblGradeFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseFour
        '
        Me.lblCourseFour.Location = New System.Drawing.Point(13, 97)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseFour.TabIndex = 9
        Me.lblCourseFour.Text = "Course 4:"
        Me.lblCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGradeFive
        '
        Me.txtGradeFive.Location = New System.Drawing.Point(87, 122)
        Me.txtGradeFive.Name = "txtGradeFive"
        Me.txtGradeFive.Size = New System.Drawing.Size(100, 22)
        Me.txtGradeFive.TabIndex = 13
        Me.txtGradeFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtGradeFive, "Grade for course five")
        '
        'lblGradeFive
        '
        Me.lblGradeFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeFive.Location = New System.Drawing.Point(210, 124)
        Me.lblGradeFive.Name = "lblGradeFive"
        Me.lblGradeFive.Size = New System.Drawing.Size(108, 24)
        Me.lblGradeFive.TabIndex = 14
        Me.lblGradeFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseFive
        '
        Me.lblCourseFive.Location = New System.Drawing.Point(13, 125)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseFive.TabIndex = 12
        Me.lblCourseFive.Text = "Course 5:"
        Me.lblCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGradeSix
        '
        Me.txtGradeSix.Location = New System.Drawing.Point(87, 150)
        Me.txtGradeSix.Name = "txtGradeSix"
        Me.txtGradeSix.Size = New System.Drawing.Size(100, 22)
        Me.txtGradeSix.TabIndex = 16
        Me.txtGradeSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtGradeSix, "Grade for course six")
        '
        'lblGradeSix
        '
        Me.lblGradeSix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeSix.Location = New System.Drawing.Point(210, 152)
        Me.lblGradeSix.Name = "lblGradeSix"
        Me.lblGradeSix.Size = New System.Drawing.Size(108, 24)
        Me.lblGradeSix.TabIndex = 17
        Me.lblGradeSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseSix
        '
        Me.lblCourseSix.Location = New System.Drawing.Point(13, 153)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseSix.TabIndex = 15
        Me.lblCourseSix.Text = "Course 6:"
        Me.lblCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGradeFinal
        '
        Me.lblGradeFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeFinal.Location = New System.Drawing.Point(210, 180)
        Me.lblGradeFinal.Name = "lblGradeFinal"
        Me.lblGradeFinal.Size = New System.Drawing.Size(108, 24)
        Me.lblGradeFinal.TabIndex = 20
        Me.lblGradeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseFinal
        '
        Me.lblCourseFinal.Location = New System.Drawing.Point(13, 181)
        Me.lblCourseFinal.Name = "lblCourseFinal"
        Me.lblCourseFinal.Size = New System.Drawing.Size(72, 17)
        Me.lblCourseFinal.TabIndex = 18
        Me.lblCourseFinal.Text = "Semester:"
        Me.lblCourseFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblError.Location = New System.Drawing.Point(16, 216)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(302, 180)
        Me.lblError.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.lblError, "Error(s)")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 405)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Press to (C)alculate the average")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(126, 405)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Press to (R)eset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(210, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Press to (E)xit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSemesterFinal
        '
        Me.lblSemesterFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSemesterFinal.Location = New System.Drawing.Point(87, 181)
        Me.lblSemesterFinal.Name = "lblSemesterFinal"
        Me.lblSemesterFinal.Size = New System.Drawing.Size(100, 23)
        Me.lblSemesterFinal.TabIndex = 19
        Me.lblSemesterFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblSemesterFinal, "Average Grade")
        '
        'ToolTip1
        '
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(330, 440)
        Me.Controls.Add(Me.lblSemesterFinal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblGradeFinal)
        Me.Controls.Add(Me.lblCourseFinal)
        Me.Controls.Add(Me.txtGradeSix)
        Me.Controls.Add(Me.lblGradeSix)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.txtGradeFive)
        Me.Controls.Add(Me.lblGradeFive)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.txtGradeFour)
        Me.Controls.Add(Me.lblGradeFour)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.txtGradeThree)
        Me.Controls.Add(Me.lblGradeThree)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.txtGradeTwo)
        Me.Controls.Add(Me.lblGradeTwo)
        Me.Controls.Add(Me.lblCourseTwo)
        Me.Controls.Add(Me.txtGradeOne)
        Me.Controls.Add(Me.lblGradeOne)
        Me.Controls.Add(Me.lblCourseOne)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourseOne As Label
    Friend WithEvents lblGradeOne As Label
    Friend WithEvents txtGradeOne As TextBox
    Friend WithEvents txtGradeTwo As TextBox
    Friend WithEvents lblGradeTwo As Label
    Friend WithEvents lblCourseTwo As Label
    Friend WithEvents txtGradeThree As TextBox
    Friend WithEvents lblGradeThree As Label
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents txtGradeFour As TextBox
    Friend WithEvents lblGradeFour As Label
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents txtGradeFive As TextBox
    Friend WithEvents lblGradeFive As Label
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents txtGradeSix As TextBox
    Friend WithEvents lblGradeSix As Label
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents lblGradeFinal As Label
    Friend WithEvents lblCourseFinal As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSemesterFinal As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
