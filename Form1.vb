Public Class Form1
    Private Sub BtnEvaluate_Click(sender As Object, e As EventArgs) Handles BtnEvaluate.Click


        Dim stentermarks As Integer = CInt(TxtEnterMarks.Text)
        Dim stgrade As String = TxtGrade.Text


        If stentermarks > 100 Or stentermarks < 0 Then
            MessageBox.Show("Wrong entry, please re-enter the marks")
            TxtEnterMarks.Clear()
        End If

        If stentermarks >= 90 And stentermarks < 100 Then
            TxtGrade.Text = "Excellent"
        ElseIf stentermarks >= 80 And stentermarks <= 89 Then
            TxtGrade.Text = "very good"
        ElseIf stentermarks >= 70 And stentermarks <= 79 Then
            TxtGrade.Text = "good"
        ElseIf stentermarks >= 60 And stentermarks <= 69 Then
            TxtGrade.Text = "medium"
        ElseIf stentermarks >= 50 And stentermarks <= 59 Then
            TxtGrade.Text = "pass"
        ElseIf stentermarks >= 0 And stentermarks <= 49 Then
            TxtGrade.Text = "fail"
        End If





    End Sub

    Private Sub LblEnterMarks_Click(sender As Object, e As EventArgs) Handles LblEnterMarks.Click

    End Sub
End Class
