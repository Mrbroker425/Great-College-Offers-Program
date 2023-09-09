Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmOffers
    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Dim intNumberofWeeks As Integer
        Dim intCourseAPrice As Integer = 234
        Dim decCourseBPrice As Decimal = CDec(287.5)

        Dim dectotalPriceAmount As Decimal

        Integer.TryParse(txtNumWeeks.Text, intNumberofWeeks)

        If ComCourse.SelectedItem.ToString().ToUpper() = "COURSE A" Then
            dectotalPriceAmount = (intCourseAPrice * 5)
        ElseIf ComCourse.SelectedItem.ToString().ToUpper() = "COURSE B" Then
            dectotalPriceAmount = (decCourseBPrice * 5)
        Else
            MessageBox.Show("Error. Please Try Again", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Exit Sub
        End If

        lblMessageDisplay.Text = "Your Amount for " & ComCourse.SelectedItem.ToString() & " is: " & dectotalPriceAmount.ToString("C2")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumWeeks.Text = ""
        txtNumWeeks.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub
End Class
