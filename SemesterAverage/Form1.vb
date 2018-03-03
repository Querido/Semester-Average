Public Class frmSemesterGrades

    Private Sub SemesterGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtGradeOne.Text = ""
        txtGradeTwo.Text = ""
        txtGradeThree.Text = ""
        txtGradeFour.Text = ""
        txtGradeFive.Text = ""
        txtGradeSix.Text = ""
        lblError.Text = ""
        lblGradeOne.Text = ""
        lblGradeTwo.Text = ""
        lblGradeThree.Text = ""
        lblGradeFour.Text = ""
        lblGradeFive.Text = ""
        lblGradeSix.Text = ""
        lblGradeFinal.Text = ""
        lblSemesterFinal.Text = ""
    End Sub

    Private Sub txtGradeOne_TextChanged(sender As Object, e As EventArgs) Handles txtGradeOne.TextChanged

    End Sub

    Private Sub txtGradeOne_Leave(sender As Object, e As EventArgs) Handles txtGradeOne.Leave

        Dim value As Double = 0
        If Double.TryParse(txtGradeOne.Text, value) AndAlso (value >= 0 AndAlso value <= 100) Then

            lblGradeOne.Text = FindGrade(value)
            lblError.Text = ""

        Else

            lblError.Text = "Please ensure that what you entered is a number between 0 and 100."
            txtGradeOne.Focus()
            txtGradeOne.SelectAll()

        End If

    End Sub

    Private Function FindGrade(grade As Double) As String

        If (grade < 0 Or grade > 100) Then

            Return ""

        ElseIf (grade < 50) Then

            Return "F"

        ElseIf (grade < 53) Then

            Return "D-"

        ElseIf (grade < 57) Then

            Return "D"

        ElseIf (grade < 60) Then

            Return "D+"

        ElseIf (grade < 63) Then

            Return "C-"

        ElseIf (grade < 67) Then

            Return "C"

        ElseIf (grade < 70) Then

            Return "C+"

        ElseIf (grade < 73) Then

            Return "B-"

        ElseIf (grade < 77) Then

            Return "B"

        ElseIf (grade < 80) Then

            Return "B+"

        ElseIf (grade < 85) Then

            Return "A-"

        ElseIf (grade < 90) Then

            Return "A"

        Else

            Return "A+"

        End If

    End Function

    Private Function CheckCourses() As Boolean

        Dim userInput() As String = {txtGradeOne.Text, txtGradeTwo.Text, txtGradeThree.Text, txtGradeFour.Text, txtGradeFive.Text, txtGradeSix.Text}
        Dim value = 0
        Dim valuesOk = True
        lblError.Text = ""

        For index As Double = 0 To userInput.Length - 1

            If userInput(index) = "" Then

                lblError.Text += "Please enter a value for course " & (index + 1) & "." & vbCrLf
                valuesOk = False

            ElseIf Not Double.TryParse(userInput(index), value) Then

                lblError.Text += "Please enter a numeric value for course " & (index + 1) & "." & vbCrLf
                valuesOk = False

            ElseIf value > 100 Or value < 0 Then

                lblError.Text += "Please enter a value between 0 and 100  for course " & (index + 1) & "." & vbCrLf
                valuesOk = False

            End If

        Next

        Return valuesOk

    End Function

    Private Sub txtGradeTwo_Leave(sender As Object, e As EventArgs) Handles txtGradeTwo.Leave

        Dim value As Double = 0
        If Double.TryParse(txtGradeTwo.Text, value) AndAlso (value >= 0 AndAlso value <= 100) Then

            lblGradeTwo.Text = FindGrade(value)
            lblError.Text = ""

        Else

            lblError.Text = "Please ensure that what you entered is a number between 0 and 100."
            txtGradeTwo.Focus()
            txtGradeTwo.SelectAll()

        End If

    End Sub

    Private Sub txtGradeThree_Leave(sender As Object, e As EventArgs) Handles txtGradeThree.Leave

        Dim value As Double = 0
        If Double.TryParse(txtGradeThree.Text, value) AndAlso (value >= 0 AndAlso value <= 100) Then

            lblGradeThree.Text = FindGrade(value)
            lblError.Text = ""

        Else

            lblError.Text = "Please ensure that what you entered is a number between 0 and 100."
            txtGradeThree.Focus()
            txtGradeThree.SelectAll()

        End If

    End Sub

    Private Sub txtGradeFour_Leave(sender As Object, e As EventArgs) Handles txtGradeFour.Leave

        Dim value As Double = 0
        If Double.TryParse(txtGradeFour.Text, value) AndAlso (value >= 0 AndAlso value <= 100) Then

            lblGradeFour.Text = FindGrade(value)
            lblError.Text = ""

        Else

            lblError.Text = "Please ensure that what you entered is a number between 0 and 100."
            txtGradeFour.Focus()
            txtGradeFour.SelectAll()

        End If

    End Sub

    Private Sub txtGradeFive_Leave(sender As Object, e As EventArgs) Handles txtGradeFive.Leave

        Dim value As Double = 0
        If Double.TryParse(txtGradeFive.Text, value) AndAlso (value >= 0 AndAlso value <= 100) Then

            lblGradeFive.Text = FindGrade(value)
            lblError.Text = ""

        Else

            lblError.Text = "Please ensure that what you entered is a number between 0 and 100."
            txtGradeFive.Focus()
            txtGradeFive.SelectAll()

        End If

    End Sub

    Private Sub txtGradeSix_Leave(sender As Object, e As EventArgs) Handles txtGradeSix.Leave

        Dim value As Double = 0
        If Double.TryParse(txtGradeSix.Text, value) AndAlso (value >= 0 AndAlso value <= 100) Then

            lblGradeSix.Text = FindGrade(value)
            lblError.Text = ""

        Else

            lblError.Text = "Please ensure that what you entered is a number between 0 and 100."
            txtGradeSix.Focus()
            txtGradeSix.SelectAll()

        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim average As Double

        If CheckCourses() Then

            average += GetValue(txtGradeOne)
            average += GetValue(txtGradeTwo)
            average += GetValue(txtGradeThree)
            average += GetValue(txtGradeFour)
            average += GetValue(txtGradeFive)
            average += GetValue(txtGradeSix)

            average = Math.Round(average / 6, 1)
            lblSemesterFinal.Text = average
            lblGradeFinal.Text = FindGrade(average)

        End If

    End Sub

    Private Function GetValue(txtCourse As TextBox) As Double

        Dim output As Double
        Double.TryParse(txtCourse.Text, output)
        Return output

    End Function

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
